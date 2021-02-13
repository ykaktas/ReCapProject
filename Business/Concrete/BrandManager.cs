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
    public class BrandManager : IBrandService

    {
        IBrandDal _brandDal;

        public BrandManager(IBrandDal brandService)
        {
            _brandDal = brandService;
        }

        public IResult Add(Brand brand)
        {
                    _brandDal.Add(brand);
            return new SuccessResult();         

        }

        public IResult Delete(Brand brand)
        {
            _brandDal.Delete(brand);
            return new SuccessResult();
        }

        public IDataResult<List<Brand>> GetAll()
        {

            return new SuccessDataResult<List<Brand>>(_brandDal.GetAll(), Messages.ProductsListed);
        }

        public IDataResult<List<Brand>> GetById(int BrandId)
        {
            
            return new SuccessDataResult<List<Brand>>(_brandDal.GetAll(p => p.BrandId == BrandId));
            
        }

        public IResult Update(Brand brand)
        {

            _brandDal.Update(brand);
            return new SuccessResult();
        }
    }
}
