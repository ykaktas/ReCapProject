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
    public class UserManager : IUserService
    {
        IUserDal _userDal;
        public UserManager(IUserDal userManager)
        {
            _userDal = userManager;
        }

        public IResult Add(User User)
        {
            _userDal.Add(User);
            return new SuccessResult();
        }

        public IResult Delete(User user)
        {
            _userDal.Delete(user);
            return new SuccessResult();
        }

        public IDataResult<List<User>> GetAll()
        {
            return new SuccessDataResult<List<User>>(_userDal.GetAll(), Messages.ProductsListed);
        }

        public IDataResult<List<User>> GetById(int UserId)
        {
            return new SuccessDataResult<List<User>>(_userDal.GetAll(u=>u.Id==UserId), Messages.ProductsListed);
        }

        public IResult Update(User User)
        {
            _userDal.Update(User);
            return new SuccessResult();
        }
    }
}
