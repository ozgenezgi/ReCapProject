using System;
using System.Collections.Generic;
using System.Text;
using ReCapEntities.Concrete;
using ReCapEntities.DTOs;

namespace ReCapBusiness.Abstarct
{
    public interface ICarService
    {
        List<Car> GetAll();
        List<Car> GetAllByBrandId(int id);
        List<Car> GetByUnitPrice(decimal min, decimal max);
        List<CarDetailDto> GetCarDetails();
    }
}
