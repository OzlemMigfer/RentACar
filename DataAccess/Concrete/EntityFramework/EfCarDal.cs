using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCarDal : EfEntityRepositoryBase<Car, ReCapProjectDatabaseContext>, ICarDal
    {
        public List<CarDetailDto> GetCarDetails()
        {
            using (ReCapProjectDatabaseContext context=new ReCapProjectDatabaseContext())
            {
                var result = from cr in context.Cars
                             join br in context.Brands
                             on cr.BrandId equals br.BrandId
                             join cl in context.Colors
                             on cr.ColorId equals cl.ColorId
                             select new CarDetailDto
                             {
                                 CarId=cr.CarId,
                                 Description=cr.Description,
                                 BrandName=br.BrandName,
                                 ColorName=cl.ColorName,
                                 DailyPrice=cr.DailyPrice,
                                 ModelYear=cr.ModelYear
                             };
                return result.ToList();
            }
        }

    }
}
