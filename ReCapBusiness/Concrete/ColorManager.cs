using System;
using System.Collections.Generic;
using System.Text;
using Core.Utilities.Results;
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

        public IDataResult<List<Color>> GetAll()
        {
            return (IDataResult<List<Color>>)_colorDal.GetAll();
        }

        public IDataResult<Color> GetById(int colorId)
        {
            return (IDataResult<Color>)_colorDal.Get(a => a.ColorId == colorId);
        }
    }
}
