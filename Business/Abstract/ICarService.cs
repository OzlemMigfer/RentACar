using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    //iş katmanında kullanacağımız servis operasyonu
    public interface ICarService
    {
        List<Car> GetAll();
        List<Car> GetCarsByColorId(int id);
        List<Car> GetCarsByBrandId(int id);
        List<Car> GetCarsByDailyPrice(decimal min,decimal max);
    }
}
