using System;
using System.Collections.Generic;
using System.Text;
using ReCapEntities.Concrete;

namespace ReCapBusiness.Abstarct
{
    public interface ICarService
    {
        List<Car> GetAll();
    }
}
