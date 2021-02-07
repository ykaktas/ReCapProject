using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCarDal : EfEntityRepositoryBase<Car, CarRentalContext>, ICarDal
    {
        public List<DetailedCarListDTO> GetCarDetails()
        {
            using (CarRentalContext context = new CarRentalContext())

            {
                

                var result = from c in context.Cars
                             join cl in context.Colors
                             on c.ColorId equals cl.ColorId
                             join b in context.Brands
                             on c.BrandId equals b.BrandId

                             select new DetailedCarListDTO
                             { 
                               BrandName = b.BrandName,
                               ColorName = cl.ColorName,
                               DailyPrice = c.DailyPrice,
                               Description = c.Description
                                 
                             };
                return result.ToList();       

                             
                             

                             
                             
                             
                             
                           
                          

            }
        }
    }
}
