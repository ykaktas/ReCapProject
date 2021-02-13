using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IRentalService
    {
        IDataResult<List<Rental>> GetAll();
        IDataResult<List<Rental>> GetById(int RentalId);
        IResult Add(Rental Rental);
        IResult Update(Rental Rental);
        IResult Delete(Rental Rental);
    }
}
