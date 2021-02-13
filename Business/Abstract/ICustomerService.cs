using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
   public interface ICustomerService
    {
        IDataResult<List<Customer>> GetAll();
        IDataResult<List<Customer>> GetById(int CustomerId);
        IResult Add(Customer Customer);
        IResult Update(Customer Customer);
        IResult Delete(Customer Customer);
    }
}
