using System;
using System.Collections.Generic;
using System.Text;
using ReCapBusiness.Abstarct;
using ReCapDataAccess.Concrete.InMemory;
using ReCapDataAccess.Abstract;
using ReCapEntities.Concrete;

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
    }
}
