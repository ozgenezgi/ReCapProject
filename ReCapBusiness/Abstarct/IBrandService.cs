using System;
using System.Collections.Generic;
using System.Text;
using ReCapEntities.Concrete;

namespace ReCapBusiness.Abstarct
{
    public interface IBrandService
    {
        List<Brand> GetAll();
        Brand GetById(int brandId);
    }
}
