using Business.Concrete;
using Entities.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            //ColorTest();
            //BrandTest();
            //CarTest();
            //CustomerTest();
            //UserTest();
            //RentalTest();
        }

        private static void RentalTest()
        {
            RentalManager rentalManager = new RentalManager(new EfRentalDal());
            rentalManager.Add(new Rental
            {
                CarId = 1,
                CustomerId = 1,
                RentDate = DateTime.Now,
                ReturnDate = DateTime.Today.AddDays(+1),
            });
            rentalManager.Add(new Rental
            {
                CarId = 2,
                CustomerId = 2,
                RentDate = DateTime.Now,
                ReturnDate = DateTime.Today.AddDays(+2),
            });
        }

        private static void UserTest()
        {
            UserManager userManager = new UserManager(new EfUserDal());
            userManager.Add(new User
            {
                FirstName = "Özlem",
                LastName = "Miğfer",
                Email = "kodlama@gmail.com",
                Password = 1234,
            });
            userManager.Add(new User
            {
                FirstName = "Arda",
                LastName = "Yüksek",
                Email = "kod@gmail.com",
                Password = 5678,
            });
        }

        private static void CustomerTest()
        {
            CustomerManager customerManager = new CustomerManager(new EfCustomerDal());
            customerManager.Add(new Customer
            {
                CompanyName = "KOSGIB",
            });
            customerManager.Add(new Customer
            {
                CompanyName = "MORTEK",
            });
        }

        private static void ColorTest()
        {
            ColorManager colorManager = new ColorManager(new EfColorDal());
            colorManager.Add(new Color
            {
                ColorName = "Black"
            });
            colorManager.Add(new Color
            {
                ColorName = "White"
            });
        }

        private static void BrandTest()
        {
            BrandManager brandManager = new BrandManager(new EfBrandDal());
            brandManager.Add(new Brand
            {
                BrandName = "Range Rover",
            });
            brandManager.Add(new Brand
            {
                BrandName = "Mercedes",
            });
        }

        private static void CarTest()
        {

            /*carManager.Add(new Car
            {
                BrandId = 2,
                ColorId = 1,
                ModelYear = 2021,
                Description = "Evoque",
                DailyPrice = 100,
            });

            carManager.Add(new Car
            {
                BrandId = 3,
                ColorId = 1,
                ModelYear = 2014,
                Description = "c180",
                DailyPrice = 150,
            });

            carManager.Add(new Car
            {
                BrandId = 2,
                ColorId = 2,
                ModelYear = 2019,
                Description = "Velar",
                DailyPrice = 110,
            });

            carManager.Add(new Car
            {
                BrandId = 3,
                ColorId = 2,
                ModelYear = 2020,
                Description = "g63",
                DailyPrice = 120,
            });
            */

            CarManager carManager = new CarManager(new EfCarDal());
            var result = carManager.GetCarDetails();
            if (result.Success == true)
            {
                foreach (var car in result.Data)
                {
                    Console.WriteLine(car.CarId + " |" + car.Description + " |" + car.BrandName + " |" + car.ColorName + " |" + car.DailyPrice);
                }
            }
            else
            {
                Console.WriteLine(result.Messages);
            }
        }
    }
}
