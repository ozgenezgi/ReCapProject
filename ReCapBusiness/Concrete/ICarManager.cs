using System;
using System.Collections.Generic;
using System.Text;
using ReCapBusiness.Abstarct;
using ReCapDataAccess.Concrete.InMemory;
using ReCapDataAccess.Abstract;
using ReCapEntities.Concrete;
using ReCapEntities.DTOs;
using Core.Utilities.Results;
using ReCapBusiness.Constants;

namespace ReCapBusiness.Concrete
{
    public class ICarManager : ICarService
    {
        ICarDal _carDal;

        public ICarManager(ICarDal carDal)
        {
            _carDal = carDal;
        }

        public IResult Add(Car car)
        {
            if (car.ModelYear.Length < 2)
            {
                //magic strings
                return new ErrorResult(Messages.CarYearInvalid);
            }
            _carDal.Add(car);

            return new SuccessResult(Messages.CarAdded);
        }

        public IDataResult<List<Car>> GetAll()
        {
            if (DateTime.Now.Hour == 1)
            {
                return new ErrorDataResult<List<Car>>(Messages.MaintenanceTime);
            }

            return new SuccessDataResult<List<Car>>(_carDal.GetAll(), Messages.CarsListed);
        }

        public IDataResult<List<Car>> GetAllByBrandId(int id)
        {
            return new SuccessDataResult<List<Car>>(_carDal.GetAll(c => c.BrandId == id));
        }

        public IDataResult<Car> GetById(int carId)
        {
            return new SuccessDataResult<Car>(_carDal.Get(c => c.CarId == carId), Messages.CarsListed);
        }

        public IDataResult<List<Car>> GetByUnitPrice(decimal min, decimal max)
        {
            return new SuccessDataResult<List<Car>>(_carDal.GetAll(c => c.DailyPrice >= min && c.DailyPrice <= max));
        }
       

        public IDataResult<List<CarDetailDto>> GetCarDetails()
        {
            if (DateTime.Now.Hour == 23)
            {
                return new ErrorDataResult<List<CarDetailDto>>(Messages.MaintenanceTime);
            }
            return new SuccessDataResult<List<CarDetailDto>>(_carDal.GetCarDetails());
        }

        
    }
}
