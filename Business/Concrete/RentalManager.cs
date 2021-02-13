using Business.Abstract;
using Business.Constants;
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
        public IResult Add(Rental Rental)
        {
            if (Rental.RentDate>DateTime.Now)
            {
                return new ErrorResult(Messages.CarDateInvalidAdd);
            }
            _rentalDal.Add(Rental);
            return new SuccessResult(Messages.CarRentSuccess);
            
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

        public IDataResult<List<Rental>> GetById(int RentalId)
        {
            return new SuccessDataResult<List<Rental>>(_rentalDal.GetAll(r=>r.Id==RentalId), Messages.ProductsListed);
        }

        public IResult Update(Rental Rental)
        {
            _rentalDal.Update(Rental);
            return new SuccessResult();
        }
    }
}
