using System;
using System.Collections.Generic;
using System.Text;
using Core.Utilities.Results;
using ReCapEntities.Concrete;
using ReCapEntities.DTOs;

namespace ReCapBusiness.Abstarct
{
    public interface ICarService
    {
        IDataResult<List<Car>> GetAll();
        IDataResult<List<Car>> GetAllByBrandId(int id);
        IDataResult<List<Car>> GetByUnitPrice(decimal min, decimal max);
        IDataResult<List<CarDetailDto>> GetCarDetails();
        IDataResult<Car> GetById(int carId);
        IResult Add(Car car);
    }
}
