using System;
using System.Collections.Generic;
using System.Text;
using Core.Utilities.Results;
using ReCapBusiness.Abstarct;
using ReCapBusiness.Constants;
using ReCapDataAccess.Abstract;
using ReCapEntities.Concrete;
using ReCapEntities.DTOs;

namespace ReCapBusiness.Concrete
{
    public class RentalManager : IRentalService
    {
        IRentalDal _rentalDal;

        public RentalManager(IRentalDal rentalDal)
        {
            _rentalDal = rentalDal;
        }

        public IResult Add(Rental rental)
        {
            if (rental.RentalId == 0)
            {
                
                return new ErrorResult(Messages.CarsRentalError);
            }
            _rentalDal.Add(rental);

            return new SuccessResult(Messages.CarsRental);
        }

        public IResult CheckReturnDate(int carId)
        {
            var result = _rentalDal.GetRentalDetails(r => r.CarId == carId && r.ReturnDate == null);
            if (result.Count > 0)
            {
                return new ErrorResult(Messages.CarsRentalError);
            }
            return new SuccessResult(Messages.CarsRental);
        }

        public IResult Delete(Rental rental)
        {
            _rentalDal.Delete(rental);
            return new SuccessResult(Messages.CarsRentalDeleted);
        }

        public IDataResult<List<Rental>> GetAll()
        {
            return new SuccessDataResult<List<Rental>>(_rentalDal.GetAll());

        }

   
       
    }
}
