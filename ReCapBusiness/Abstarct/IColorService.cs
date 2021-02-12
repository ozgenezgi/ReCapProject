using System;
using System.Collections.Generic;

using System.Text;
using ReCapEntities.Concrete;

namespace ReCapBusiness.Abstarct
{
    public interface IColorService
    {
        List<Color> GetAll();
        Color GetById(int colorId);
    }
}
