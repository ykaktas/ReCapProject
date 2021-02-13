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
    public class ColorManager : IColorService
    {
        IColorDal _colorDal;

        public ColorManager(IColorDal colorDal)
        {
            _colorDal = colorDal;
        }

        public IResult Add(Color Color)
        {
            _colorDal.Add(Color);
            return new SuccessResult();
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

        public IDataResult<List<Color>> GetById(int ColorId)
        {
            
            return new SuccessDataResult<List<Color>>(_colorDal.GetAll(c=>c.ColorId==ColorId));
        }

        public IResult Update(Color Color)
        {
            _colorDal.Update(Color);
            return new SuccessResult();
        }
    }
}
