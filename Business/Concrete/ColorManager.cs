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
    public class ColorManager : IColorService
    {
        IColorDal _colorDal;

        public ColorManager(IColorDal colorDal)
        {
            _colorDal = colorDal;
        }
        [ValidationAspect(typeof(ColorValidator))]

        public IResult Add(Color Color)
        {
            _colorDal.Add(Color);
            return new SuccessResult();
        }

        public IResult AddTransactionalTest(Color entity)
        {
            throw new NotImplementedException();
        }

        public IResult Delete(Color Color)
        {
            _colorDal.Add(Color);
            return new SuccessResult();
        }

        public IDataResult<List<Color>> GetAll()
        {
            return new SuccessDataResult<List<Color>>(_colorDal.GetAll(),Messages.ProductsListed);
        }

        public IDataResult<Color> GetById(int ColorId)
        {
            
            return new SuccessDataResult<Color>(_colorDal.Get(c=>c.ColorId==ColorId));
        }

        public IResult Update(Color Color)
        {
            _colorDal.Update(Color);
            return new SuccessResult();
        }

    }
}
