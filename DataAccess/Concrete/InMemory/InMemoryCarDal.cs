using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _car;
        public InMemoryCarDal()
        {
            _car = new List<Car>
            {
                new Car{CarId=1, BrandId=1, ColorId=1, DailyPrice = 1500, ModelYear = "2010", Description= "Toyota marka 2010 model kırmızı araba"},
                new Car{CarId=2, BrandId=2, ColorId=2, DailyPrice = 2500, ModelYear = "2019", Description= "Honda marka 2019 model beyaz araba"},
                new Car{CarId=3, BrandId=3, ColorId=3, DailyPrice = 1750, ModelYear = "2013", Description= "Ford marka 2013 model gri araba"},
                new Car{CarId=4, BrandId=2, ColorId=4, DailyPrice = 2250, ModelYear = "2018", Description= "Honda marka 2018 model mavi araba"},
                new Car{CarId=5, BrandId=1, ColorId=1, DailyPrice = 2600, ModelYear = "2020", Description= "Toyota marka 2020 model kırmızı araba"},
                new Car{CarId=6, BrandId=3, ColorId=4, DailyPrice = 1300, ModelYear = "2009", Description= "Ford marka 2009 model mavi araba"}
            };
           

        }
        
        public void Add(Car car)
        {
            _car.Add(car);
            Console.WriteLine(car.Description + " Broşüre Eklendi");
        }

        public void Delete(Car car)
        {
            Car CarToDelete = _car.SingleOrDefault(c=>c.CarId==car.CarId);
            _car.Remove(CarToDelete);
            Console.WriteLine(CarToDelete.Description + " Silindi.");
        }

        public Car Get(Expression<Func<Car, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetAll()
        {
            foreach (var x in _car)
            {
                Console.WriteLine(x.Description);
            }
            return _car;
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public  List<Car> GetById(int CarId)
        {
            Car CarByID = _car.SingleOrDefault(c => c.CarId == CarId);
           if (CarId<=_car.Count)
            {
                Console.WriteLine("ID si girilen araba =  " + CarByID.Description);
            }
            else
            {
                Console.WriteLine("Geçerli Bir ID Giriniz..");
            }
            return _car;





        }

        public List<DetailedCarListDTO> GetCarDetails()
        {
            throw new NotImplementedException();
        }

        public void Update(Car car)
        {
            Car CarToUpdate = _car.SingleOrDefault(c => c.CarId == car.CarId);
            car.BrandId = CarToUpdate.BrandId;
            car.ColorId = CarToUpdate.ColorId;
            car.DailyPrice = CarToUpdate.DailyPrice;
            car.Description = CarToUpdate.Description;
            car.ModelYear = CarToUpdate.ModelYear; 

        }
    }
}
