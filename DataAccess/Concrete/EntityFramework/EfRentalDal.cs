using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfRentalDal : EfEntityRepositoryBase<Rental, ReCapProjectDatabaseContext>, IRentalDal
    {
        public List<RentalDetailDto> GetRentalDetails()
        {
            using (ReCapProjectDatabaseContext context=new ReCapProjectDatabaseContext())
            {
                var result = from r in context.Rentals
                             join cr in context.Cars
                             on r.CarId equals cr.CarId
                             join cs in context.Customers
                             on r.Id equals cs.Id
                             join u in context.Users
                             on cs.Id equals u.Id
                             join br in context.Brands
                             on cr.BrandId equals br.BrandId
                             select new RentalDetailDto
                             {
                                 UserId=u.Id,
                                 CarId=cr.CarId,
                                 BrandName=br.BrandName,
                                 UserName=u.FirstName+" "+u.LastName,
                                 CustomerName=cs.CompanyName,
                                 RentDate=r.RentDate,
                                 ReturnDate=r.ReturnDate,
                             };
                return result.ToList();
            }
        }
    }
}
