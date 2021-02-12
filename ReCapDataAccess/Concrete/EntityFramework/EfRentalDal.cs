using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using Core.DataAccess.EntityFramework;
using ReCapDataAccess.Abstract;
using ReCapEntities.Concrete;
using ReCapEntities.DTOs;

namespace ReCapDataAccess.Concrete.EntityFramework
{
    public class EfRentalDal : EfEntityRepositoryBase<Rental, CarDatabaseContext>, IRentalDal
    {
        public List<RentalDetailDto> GetRentalDetails(Expression<Func<Rental, bool>> filter = null)
        {

            using (CarDatabaseContext context = new CarDatabaseContext())
            {
                var result = from r in filter is null ? context.Rental : context.Rental.Where(filter)
                             join c in context.Car
                             on r.CarId equals c.CarId
                             join cu in context.Customer
                             on r.CustomerId equals cu.CustomerId
                             join u in context.User
                             on cu.UserId equals u.UserId
                             select new RentalDetailDto
                             {
                                 RentalId = r.RentalId,
                                 CustomerName = cu.CompanyName,
                                 CarId = c.CarId,
                                 RentDate = r.RentDate,
                                 ReturnDate = r.ReturnDate,
                                 UserName = u.FirstName + " " + u.LastName
                             };

                return result.ToList();

            }

        }
    }
}
