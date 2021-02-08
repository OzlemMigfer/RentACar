using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    //burası bellek işlerinin yapılacağı yer
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;//Car ları listeliyoruz
        public InMemoryCarDal()//constructor ekliyoruz
        {
            //biz burayı çalıştırınca veritabanından bu bilgileri getirir , Oracle,Sql Server veritabanı vs.
            _cars = new List<Car> { 
                new Car{CarId=1,BrandId=1,ColorId=1,ModelYear=2000,Description="Mercedes Car",DailyPrice=500},
                new Car{CarId=2,BrandId=2,ColorId=1,ModelYear=2006,Description="Ford Car",DailyPrice=50},
                new Car{CarId=3,BrandId=2,ColorId=2,ModelYear=2006,Description="Ford Car",DailyPrice=50},
                new Car{CarId=4,BrandId=3,ColorId=3,ModelYear=2010,Description="Nissan Car",DailyPrice=45},
                new Car{CarId=5,BrandId=4,ColorId=4,ModelYear=2005,Description="Renault Car",DailyPrice=55},
            };
        }
        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            //linq ile yapıyoruz bu işlemi
            Car carToDelete = _cars.SingleOrDefault(c => c.CarId == car.CarId);
            _cars.Remove(carToDelete);
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetById(int id)
        {
            return _cars.Where(c => c.CarId == id).ToList();
        }

        public void UpDate(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(c => c.CarId == car.CarId);
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.ModelYear = car.ModelYear;
            carToUpdate.Description = car.Description;
            carToUpdate.DailyPrice = car.DailyPrice;
        }

        public List<Car> GetAllByBrand(int brandId)
        {
           return _cars.Where(c => c.BrandId == brandId).ToList();
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public Car Get(Expression<Func<Car, bool>> filter)
        {
            throw new NotImplementedException();
        }
    }
}
