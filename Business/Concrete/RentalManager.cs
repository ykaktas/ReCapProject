using Business.Abstract;
using Business.Constants;
using Business.ValidationRules.FluentValidation;
using Core.Aspects.Autofac.Validation;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;

namespace Business.Concrete
{
    public class RentalManager : IRentalService
    {
        IRentalDal _rentalDal;
        public RentalManager(IRentalDal rentalService)
        {
            _rentalDal = rentalService;
        }
        [ValidationAspect(typeof(RentalValidator))]
        public IResult Add(Rental Rental)
        {
            //if (Rental.RentDate>DateTime.Now)
            //{
            //    return new ErrorResult(Messages.CarDateInvalidAdd);
            //}
            _rentalDal.Add(Rental);
            return new SuccessResult(Messages.CarRentSuccess);
            
        }

        public IResult AddTransactionalTest(Rental entity)
        {
            throw new NotImplementedException();
        }

        public IResult Delete(Rental Rental)
        {
            _rentalDal.Delete(Rental);
            return new SuccessResult();
        }

        public IDataResult<List<Rental>> GetAll()
        {
            return new SuccessDataResult<List<Rental>>(_rentalDal.GetAll(), Messages.ProductsListed);
        }

        public IDataResult<Rental> GetById(int RentalId)
        {
            return new SuccessDataResult<Rental>(_rentalDal.Get(r=>r.Id==RentalId), Messages.ProductsListed);
        }

        public IResult Update(Rental Rental)
        {
            _rentalDal.Update(Rental);
            return new SuccessResult();
        }
    }
}
