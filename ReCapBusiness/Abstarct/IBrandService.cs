﻿using System;
using System.Collections.Generic;
using System.Text;
using Core.Utilities.Results;
using ReCapEntities.Concrete;

namespace ReCapBusiness.Abstarct
{
    public interface IBrandService
    {
        IDataResult<List<Brand>> GetAll();
        IDataResult<Brand> GetById(int brandId);
    }
}