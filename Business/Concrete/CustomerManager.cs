using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class CustomerManager : ICustomerService
    {
        ICustomerDal _customerDal;
        public CustomerManager(ICustomerDal customerManager)
        {
            _customerDal = customerManager;
        }
        public IResult Add(Customer Customer)
        {
            _customerDal.Add(Customer);
            return new SuccessResult();
        }

        public IResult Delete(Customer Customer)
        {
            _customerDal.Delete(Customer);
            return new SuccessResult();
        }

        public IDataResult<List<Customer>> GetAll()
        {
            return new SuccessDataResult<List<Customer>>( _customerDal.GetAll(),Messages.ProductsListed);
            
        }

        public IDataResult<List<Customer>> GetById(int CustomerId)
        {
            return new SuccessDataResult<List<Customer>>(_customerDal.GetAll(c=>c.UserId==CustomerId), Messages.ProductsListed);
        }

        public IResult Update(Customer Customer)
        {
            _customerDal.Update(Customer);
            return new SuccessResult();
        }
    }
}
