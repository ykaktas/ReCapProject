using Business.Abstract;
using Business.Constants;
using Business.ValidationRules.FluentValidation;
using Core.Aspects.Autofac.Validation;
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
        [ValidationAspect(typeof(CustomerValidator))]
        public IResult Add(Customer Customer)
        {
            _customerDal.Add(Customer);
            return new SuccessResult();
        }

        public IResult AddTransactionalTest(Customer entity)
        {
            throw new NotImplementedException();
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

        public IDataResult<Customer> GetById(int CustomerId)
        {
            return new SuccessDataResult<Customer>(_customerDal.Get(c=>c.Id==CustomerId));
        }

        public IResult Update(Customer Customer)
        {
            _customerDal.Update(Customer);
            return new SuccessResult();
        }
    }
}
