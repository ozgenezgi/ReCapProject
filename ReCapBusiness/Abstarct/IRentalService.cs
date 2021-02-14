using System;
using System.Collections.Generic;
using System.Text;
using Core.Utilities.Results;
using ReCapEntities.Concrete;
using ReCapEntities.DTOs;

namespace ReCapBusiness.Abstarct
{
    public interface IRentalService
    {
        IResult Add(Rental rental);
        IResult Delete(Rental rental);
        IDataResult<List<Rental>> GetAll();
        
        IResult CheckReturnDate(int carId);
        
    }
}
