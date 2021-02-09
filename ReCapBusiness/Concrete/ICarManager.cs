using System;
using System.Collections.Generic;
using System.Text;
using ReCapBusiness.Abstarct;
using ReCapDataAccess.Concrete.InMemory;
using ReCapDataAccess.Abstract;
using ReCapEntities.Concrete;
using ReCapEntities.DTOs;

namespace ReCapBusiness.Concrete
{
    public class ICarManager : ICarService
    {
        ICarDal _carDal;

        public ICarManager(ICarDal carDal)
        {
            _carDal = carDal;
        }

        public List<Car> GetAll()
        {
            return _carDal.GetAll();
        }

        public List<Car> GetAllByBrandId(int id)
        {
            return _carDal.GetAll(c => c.BrandId == id);
        }

        public List<Car> GetByUnitPrice(decimal min, decimal max)
        {
            return _carDal.GetAll(c => c.DailyPrice >= min && c.DailyPrice <= max);
        }
       

        public List<CarDetailDto> GetCarDetails()
        {
            return _carDal.GetCarDetails();
        }

     
    }
}
