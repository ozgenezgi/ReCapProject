using System;
using System.Collections.Generic;

using System.Text;
using Core.Utilities.Results;
using ReCapEntities.Concrete;

namespace ReCapBusiness.Abstarct
{
    public interface IColorService
    {
        IDataResult<List<Color>> GetAll();
        IDataResult<Color> GetById(int colorId);
    }
}
