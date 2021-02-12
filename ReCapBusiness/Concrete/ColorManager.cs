﻿using System;
using System.Collections.Generic;
using System.Text;
using ReCapBusiness.Abstarct;
using ReCapDataAccess.Abstract;
using ReCapEntities.Concrete;

namespace ReCapBusiness.Concrete
{
    public class ColorManager : IColorService
    {
        IColorDal _colorDal;

        public ColorManager(IColorDal colorDal)
        {
            _colorDal = colorDal;
        }

        public List<Color> GetAll()
        {
            return _colorDal.GetAll();
        }

        public Color GetById(int colorId)
        {
            return _colorDal.Get(a => a.ColorId == colorId);
        }
    }
}
