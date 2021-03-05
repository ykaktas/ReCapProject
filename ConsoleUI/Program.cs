using Business.Concrete;
using Core.Entities.Concrete;
using DataAccess.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            //----COLOR METHODS----//

            //GetByColorID();
            //GetAllColor();
            //DeleteColor();
            //AddColor();
            //UpdateColor();

            //----CAR METHODS---// 

            //AddCar();
            //DeleteCar();
            //UpdateCar();
            //GetAllCar();
            //GetCarsByBrandId();
            //GetCarsByColorId();

            //-----BRAND METHODS-----//

            //UpdateBrand();
            //AddBrand();
            //DeleteBrand();
            //GetAllBrands();
            // GetBrandById();
            // GetCarsByDetails();
            //-------USER METHODS-----//
            // DeleteUser();
            //AddRental();
            //UserManager userManager = new UserManager(new EfCustomerDal());
            //userManager.Add(new Customer { CompanyName = "yka" });

            
        }

        private static void AddRental()
        {
          
            RentalManager rentalManager = new RentalManager(new EfRentalDal());
            var result = rentalManager.Add(new Rental { CarId = 1, CustomerId = 1, Id = 1, RentDate = (new DateTime(2025, 02, 03)) });
         
            Console.WriteLine(result.Message);

        }

        private static void DeleteUser()
        {
            UserManager userManager = new UserManager(new EfUserDal());

            userManager.Delete(new User { Id = 2 });
            foreach (var result in userManager.GetAll().Data)
            {
                Console.WriteLine(result.Email);
            }
        }

        private static void GetCarsByDetails()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            
            foreach (var item in carManager.GetCarDetails().Data)
            {
                Console.WriteLine( item.Description + " " + item.BrandName + " " + item.ColorName + " " + item.DailyPrice);
            }
        }

        //private static void GetBrandById()
        //{
        //    BrandManager brandManager = new BrandManager(new EfBrandDal());
        //    foreach (var result in brandManager.GetById(3).Data)
        //    {
        //        Console.WriteLine(result.BrandName);
        //    } 
            
        //}

        private static void GetAllBrands()
        {
            BrandManager brandManager = new BrandManager(new EfBrandDal());
            foreach (var brands in brandManager.GetAll().Data)
            {
                Console.WriteLine(brands.BrandName);
            }
        }

        private static void DeleteBrand()
        {
            BrandManager brandManager = new BrandManager(new EfBrandDal());
            brandManager.Delete(new Brand { BrandId = 3 });
        }

        private static void AddBrand()
        {
            BrandManager brandManager = new BrandManager(new EfBrandDal());
            brandManager.Add(new Brand { BrandName = "Porsche", BrandId = 8 });
        }

        private static void UpdateBrand()
        {
            BrandManager brandManager = new BrandManager(new EfBrandDal());
            brandManager.Update(new Brand { BrandName = "Porsche", BrandId = 3 });
        }

        private static void GetCarsByColorId()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            foreach (var car in carManager.GetCarsByColorId(3).Data)
            {
                Console.WriteLine(car.Description);
            }
        }

        private static void GetCarsByBrandId()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            foreach (var car in carManager.GetCarsByBrandId(2).Data)
            {
                Console.WriteLine(car.Description);
            }
        }

        private static void GetAllCar()
        {
            CarManager carManager = new CarManager(new EfCarDal());

            foreach (var car in carManager.GetAll().Data)
            {
                Console.WriteLine(car.Description);
                
            }
        }

        private static void UpdateCar()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            carManager.Update(new Car
            {
                CarId = 3,
                BrandId = 2,
                ColorId = 2,
                DailyPrice = 2414,
                Description = "Hoş Araba",
                ModelYear = "2023"
            });
        }

        private static void DeleteCarById()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            carManager.Delete(new Car
            {
                CarId = 5
            });
        }

        private static void GetByColorID()
        {
            ColorManager colorManager = new ColorManager(new EfColorDal());
            var result = colorManager.GetById(2);
            Console.WriteLine(result.Data);
        }

        private static void GetAllColor()
        {
            ColorManager colorManager = new ColorManager(new EfColorDal());
           
            foreach (var color in colorManager.GetAll().Data)
            {
                Console.WriteLine(color.ColorName);
            }
        }

        private static void DeleteColor()
        {
            ColorManager colorManager = new ColorManager(new EfColorDal());
            colorManager.Delete(new Color
            {
                ColorId = 5,
            });
        }

        private static void AddColor()
        {
            ColorManager color = new ColorManager(new EfColorDal());
            color.Add(new Color
            {
                ColorId = 5,
                ColorName = "Pink"
            });
        }

        private static void AddCar()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            carManager.Add(new Car
            {
                CarId = 7,
                ColorId = 3,
                BrandId = 4,
                DailyPrice = 2000,
                Description = "İyi Araba",
                ModelYear = "2015"
            });
        }

        private static void UpdateColor()
        {
            ColorManager colorManager = new ColorManager(new EfColorDal());
            colorManager.Update(new Color { ColorName = "White", ColorId = 3 });
        }
    }
}
