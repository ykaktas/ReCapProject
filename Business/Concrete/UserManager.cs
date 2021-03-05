using Business.Abstract;
using Business.Constants;
using Business.ValidationRules.FluentValidation;
using Core.Aspects.Autofac.Validation;
using Core.Entities.Concrete;
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
        [ValidationAspect(typeof(UserValidator))]
        public IResult Add(User User)
        {
            _userDal.Add(User);
            return new SuccessResult();
        }

        public IResult AddTransactionalTest(User entity)
        {
            throw new NotImplementedException();
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

        public IDataResult<User> GetById(int UserId)
        {
            return new SuccessDataResult<User>(_userDal.Get(u => u.Id == UserId), Messages.ProductsListed);
        }

        public IDataResult<User> GetByMail(string Email)
        {
           return  new SuccessDataResult<User>(_userDal.Get(u => u.Email == Email));
        }

        public IDataResult<List<OperationClaim>> GetClaims(User user)
        {
            var result = _userDal.GetClaims(user);
            return new SuccessDataResult<List<OperationClaim>> (result);
        }

        public IResult Update(User User)
        {
            _userDal.Update(User);
            return new SuccessResult();
        }
    }
}
