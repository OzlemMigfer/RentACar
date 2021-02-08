﻿using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class CarManager : ICarService
    {
        ICarDal _carDal;//injection yaptık

        public CarManager(ICarDal carDal)//constructor çağırdık
        {
            _carDal = carDal;
        }

        public List<Car> GetAll()
        {
            //iş kodları
            return _carDal.GetAll();
        }

        public List<Car> GetCarsByBrandId(int id)
        {
            return _carDal.GetAll(c => c.BrandId == id);
        }

        public List<Car> GetCarsByColorId(int id)
        {
            return _carDal.GetAll(c => c.ColorId == id);
        }

        public List<Car> GetCarsByDailyPrice(decimal min,decimal max)
        {
            return _carDal.GetAll(c => c.DailyPrice >= min && c.DailyPrice <= max);
        }

        public void Add(Car car)
        {
            if(car.DailyPrice> 0 )
            {
                _carDal.Add(car);
            }
            else
            {
                Console.WriteLine("Daily car rental fee should be more than 0!!!");
            }
        }

        public void Delete(Car car)
        {
            _carDal.Delete(car);
        }

        public void Update(Car car)
        {
            _carDal.UpDate(car);
        }
    }
}
