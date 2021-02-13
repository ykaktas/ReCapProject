using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class CarManager : ICarService
    {
        ICarDal  _carDal;
        public CarManager(ICarDal CarDal)
        {
            _carDal = CarDal;
        }

  

        public IResult Add(Car car)
        {
            if (car.DailyPrice > 0)
            {
                
                 if (car.Description.Length>=2)
                {
                  _carDal.Add(car);
                   return new SuccessResult();
                }
               
            }
            
            
              
              return new ErrorResult(Messages.ProductNameInvalidAdd);
                      
        }

        public IResult Delete(Car car)
        {
            _carDal.Delete(car);
            return new SuccessResult(); 
        }

        public IDataResult<List<Car>> GetAll()
        {
            
            return new SuccessDataResult<List<Car>> (_carDal.GetAll(), Messages.ProductsListed);
        }

        public IDataResult<List<DetailedCarListDTO>> GetCarDetails()
        {
            return new SuccessDataResult<List<DetailedCarListDTO>>(_carDal.GetCarDetails());
        }

        public IDataResult<List<Car>> GetCarsByBrandId(int id)
        {
         
                return new SuccessDataResult<List<Car>>(_carDal.GetAll(p => p.BrandId == id),Messages.ProductsListed);
                    
        }

        public IDataResult<List<Car>> GetCarsByColorId(int id)
        {
            return new SuccessDataResult<List<Car>>(_carDal.GetAll(p => p.ColorId == id),Messages.ProductsListed);
        }

        public IResult Update(Car car)
        {
            
                   _carDal.Update(car);
            return new SuccessResult();
        }
    }
}
