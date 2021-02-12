using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using Core.DataAccess;
using ReCapEntities.Concrete;
using ReCapEntities.DTOs;

namespace ReCapDataAccess.Abstract
{
    public interface IRentalDal : IEntityRepository<Rental>
    {
        List<RentalDetailDto> GetRentalDetails(Expression<Func<Rental, bool>> filter = null);
    }
}
