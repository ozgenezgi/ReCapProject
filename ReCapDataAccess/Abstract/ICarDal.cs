﻿using System;
using System.Collections.Generic;
using System.Text;
using Core.DataAccess;
using ReCapEntities.Concrete;
using ReCapEntities.DTOs;

namespace ReCapDataAccess.Abstract
{
    public interface ICarDal : IEntityRepository<Car>
    {
        
        List<CarDetailDto> GetCarDetails();
    }
}
