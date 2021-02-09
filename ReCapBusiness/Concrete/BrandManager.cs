﻿using System;
using System.Collections.Generic;
using System.Text;
using ReCapBusiness.Abstarct;
using ReCapDataAccess.Abstract;
using ReCapEntities.Concrete;

namespace ReCapBusiness.Concrete
{
    public class BrandManager : IBrandService
    {
        IBrandDal _brandDal;

        public BrandManager(IBrandDal brandDal)
        {
            _brandDal = brandDal;
        }
        public List<Brand> GetAll()
        {
            return _brandDal.GetAll();
        }

       

        public Brand GetById(int brandId)
        {
            return _brandDal.Get(b => b.BrandId == brandId);
        }
    }
}
