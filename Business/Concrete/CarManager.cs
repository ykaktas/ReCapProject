using Business.Abstract;
using Business.BusinessAspects.Autofac;
using Business.Constants;
using Business.ValidationRules.FluentValidation;
using Core.Aspects.Autofac.Caching;
using Core.Aspects.Autofac.Transaction;
using Core.Aspects.Autofac.Validation;
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
        ICarDal _carDal;
        public CarManager(ICarDal CarDal)
        {
            _carDal = CarDal;
        }
        [ValidationAspect(typeof(CarValidator))]
        [SecuredOperation("product.add,admin")]
        [CacheAspect(duration: 10)]
        [CacheRemoveAspect("ICarService.Get")]
        public IResult Add(Car car)
        {

            _carDal.Add(car);
            return new SuccessResult();
        }



        public IResult Delete(Car car)
        {
            _carDal.Delete(car);
            return new SuccessResult();
        }
       // [ValidationAspect(typeof(CarValidator))]
        [SecuredOperation("Car.List,admin")]
        [CacheAspect(duration: 10)]
        [CacheRemoveAspect("ICarService.Get")]
        public IDataResult<List<Car>> GetAll()
        {

            return new SuccessDataResult<List<Car>>(_carDal.GetAll(), Messages.ProductsListed);
        }

        public IDataResult<Car> GetById(int CarId)
        {
            return new SuccessDataResult<Car>(_carDal.Get(c => c.CarId == CarId));
        }

        public IDataResult<List<DetailedCarListDTO>> GetCarDetails()
        {
            return new SuccessDataResult<List<DetailedCarListDTO>>(_carDal.GetCarDetails());
        }

        public IDataResult<List<Car>> GetCarsByBrandId(int id)
        {

            return new SuccessDataResult<List<Car>>(_carDal.GetAll(p => p.BrandId == id), Messages.ProductsListed);

        }

        public IDataResult<List<Car>> GetCarsByColorId(int id)
        {
            return new SuccessDataResult<List<Car>>(_carDal.GetAll(p => p.ColorId == id), Messages.ProductsListed);
        }

        public IResult Update(Car car)
        {

            _carDal.Update(car);
            return new SuccessResult();
        }
        [TransactionScopeAspect]
        public IResult AddTransactionalTest(Car car)
        {
            _carDal.Add(car);
            _carDal.Delete(car);
            _carDal.Update(car);
            return new SuccessResult();
        }
    }
}
