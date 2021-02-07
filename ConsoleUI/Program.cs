using Business.Concrete;
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
            //GetBrandById();
           // GetCarsByDetails();

        }

        private static void GetCarsByDetails()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            var result = carManager.GetCarDetails();
            foreach (var item in result)
            {
                Console.WriteLine(item.Description + " " + item.BrandName + " " + item.ColorName + " " + item.DailyPrice);
            }
        }

        private static void GetBrandById()
        {
            BrandManager brandManager = new BrandManager(new EfBrandDal());
            var result = brandManager.GetById(2);
            Console.WriteLine(result.BrandName);
        }

        private static void GetAllBrands()
        {
            BrandManager brandManager = new BrandManager(new EfBrandDal());
            foreach (var brands in brandManager.GetAll())
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
            foreach (var car in carManager.GetCarsByColorId(3))
            {
                Console.WriteLine(car.Description);
            }
        }

        private static void GetCarsByBrandId()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            foreach (var car in carManager.GetCarsByBrandId(2))
            {
                Console.WriteLine(car.Description);
            }
        }

        private static void GetAllCar()
        {
            CarManager carManager = new CarManager(new EfCarDal());

            foreach (var car in carManager.GetAll())
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
            Console.WriteLine(result.ColorName);
        }

        private static void GetAllColor()
        {
            ColorManager colorManager = new ColorManager(new EfColorDal());
           
            foreach (var color in colorManager.GetAll())
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
