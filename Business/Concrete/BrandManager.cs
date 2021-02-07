using Business.Abstract;
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

        public void Add(Brand brand)
        {
            throw new NotImplementedException();
        }

        public void Delete(Brand brand)
        {
            throw new NotImplementedException();
        }

        public List<Brand> GetAll()
        {
            return _brandDal.GetAll();
        }

        public Brand GetById(int BrandId)
        {
            return _brandDal.Get(b => b.BrandId == BrandId);
        }

        public void Update(Brand brand)
        {
            throw new NotImplementedException();
        }
    }
}
