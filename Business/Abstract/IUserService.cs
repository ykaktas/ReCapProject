using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
   public interface IUserService
    {
        IDataResult<List<User>> GetAll();
        IDataResult<List<User>> GetById(int UserId);
        IResult Add(User User);
        IResult Update(User User);
        IResult Delete(User User);
    }
}
