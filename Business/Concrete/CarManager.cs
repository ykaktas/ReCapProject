using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class CarManager : ICarService
    {
        ICarDal  _CarDal;
        public CarManager(ICarDal CarDal)
        {
            _CarDal = CarDal;
        }
        public List<Car> GetAll()
        {
            return _CarDal.GetAll();
        }
    }
}
