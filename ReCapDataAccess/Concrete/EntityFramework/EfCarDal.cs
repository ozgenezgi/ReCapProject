using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using Core.DataAccess.EntityFramework;
using Microsoft.EntityFrameworkCore;
using ReCapDataAccess.Abstract;
using ReCapEntities.Concrete;
using ReCapEntities.DTOs;

namespace ReCapDataAccess.Concrete.EntityFramework
{
    public class EfCarDal : EfEntityRepositoryBase<Car, CarDatabaseContext>, ICarDal
    {
       

        public List<CarDetailDto> GetCarDetails()
        {
            using (CarDatabaseContext context = new CarDatabaseContext())
            {
                var result = from c in context.Car
                             join b in context.Brand
                             on c.BrandId equals b.BrandId
                             join a in context.Color
                             on c.ColorId equals a.ColorId
                             select new CarDetailDto
                             {
                                 CarId = c.CarId,
                                 BrandName = b.BrandName,
                                 DailyPrice = c.DailyPrice,
                                 Description = c.Description,
                                 ColorName = a.ColorName
                             };
                return result.ToList();
            }
        }

     
    }
}
