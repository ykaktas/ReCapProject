using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
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
                new Car{CarId=1, BrandId=1, ColorId=1, DailyPrice = 1500, ModelYear = "2010", Descripton= "Toyota marka 2010 model kırmızı araba"},
                new Car{CarId=2, BrandId=2, ColorId=2, DailyPrice = 2500, ModelYear = "2019", Descripton= "Honda marka 2019 model beyaz araba"},
                new Car{CarId=3, BrandId=3, ColorId=3, DailyPrice = 1750, ModelYear = "2013", Descripton= "Ford marka 2013 model gri araba"},
                new Car{CarId=4, BrandId=2, ColorId=4, DailyPrice = 2250, ModelYear = "2018", Descripton= "Honda marka 2018 model mavi araba"},
                new Car{CarId=5, BrandId=1, ColorId=1, DailyPrice = 2600, ModelYear = "2020", Descripton= "Toyota marka 2020 model kırmızı araba"},
                new Car{CarId=6, BrandId=3, ColorId=4, DailyPrice = 1300, ModelYear = "2009", Descripton= "Ford marka 2009 model mavi araba"}
            };
           

        }
        
        public void Add(Car car)
        {
            _car.Add(car);
            Console.WriteLine(car.Descripton + " Broşüre Eklendi");
        }

        public void Delete(Car car)
        {
            Car CarToDelete = _car.SingleOrDefault(c=>c.CarId==car.CarId);
            _car.Remove(CarToDelete);
            Console.WriteLine(CarToDelete.Descripton + " Silindi.");
        }

        public List<Car> GetAll()
        {
            foreach (var x in _car)
            {
                Console.WriteLine(x.Descripton);
            }
            return _car;
        }

        public  List<Car> GetById(int CarId)
        {
            Car CarByID = _car.SingleOrDefault(c => c.CarId == CarId);
           if (CarId<=_car.Count)
            {
                Console.WriteLine("ID si girilen araba =  " + CarByID.Descripton);
            }
            else
            {
                Console.WriteLine("Geçerli Bir ID Giriniz..");
            }
            return _car;





        }

        public void Update(Car car)
        {
            Car CarToUpdate = _car.SingleOrDefault(c => c.CarId == car.CarId);
            car.BrandId = CarToUpdate.BrandId;
            car.ColorId = CarToUpdate.ColorId;
            car.DailyPrice = CarToUpdate.DailyPrice;
            car.Descripton = CarToUpdate.Descripton;
            car.ModelYear = CarToUpdate.ModelYear; 

        }
    }
}
