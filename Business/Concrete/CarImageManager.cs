using Business.Abstract;
using Business.Constants;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Utilities.Business;
using Core.Utilities.Results;

namespace Business.Concrete
{
    public class CarImageManager : ICarImageService
    {
        private readonly ICarImageDal _carImageDal;

        public CarImageManager(ICarImageDal carImageDal)
        {
            _carImageDal = carImageDal;
        }

        public IResult Add(CarImage carImage)
        {           
            _carImageDal.Add(carImage);
            return new SuccessResult(Messages.CarImageAdded);
        }

        public IResult Update(CarImage carImage)
        {
            _carImageDal.UpDate(carImage);
            return new SuccessResult();
        }

        public IResult Delete(CarImage carImage)
        {
            var result = BusinessRules.Run(CheckIfDataExists());
            if (result != null)
            {
                return new ErrorResult(result.Message);
            }
            _carImageDal.Delete(carImage);
            return new SuccessResult(Messages.CarImageDeleted);
        }

        public IDataResult<List<CarImage>> GetAllByCarId(int carId)
        {
            var result = BusinessRules.Run(CheckIfCarImageExists(carId));
            if (result != null)
            {
                return new ErrorDataResult<List<CarImage>>(new List<CarImage> {
                    new CarImage {Id=404, CarId = carId, Date = DateTime.Now, ImagePath = Paths.DefaultCarImage}}, result.Message);
            }
            return new SuccessDataResult<List<CarImage>>(_carImageDal.GetAll(image => image.CarId == carId),"Listelendi");
        }

        private IResult CheckIfCarImagesExceed(int carId)
        {
            var result = _carImageDal.GetAll(image => image.CarId == carId).Count;
            if (result >= 5)
            {
                return new ErrorResult();
            }
            return new SuccessResult();
        }

        private IResult CheckIfCarImageExists(int carId)
        {
            var result = _carImageDal.GetAll(image => image.CarId == carId).Any();
            if (!result)
            {
                return new ErrorResult("şlkjklş");
            }
            return new SuccessResult();
        }

        private IResult CheckIfDataExists()
        {
            var result = _carImageDal.GetAll().Any();
            if (!result)
            {
                return new ErrorResult();
            }
            return new SuccessResult();
        }
    }
}