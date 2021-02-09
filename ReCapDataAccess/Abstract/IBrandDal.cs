using System;
using System.Collections.Generic;
using System.Text;
using Core.DataAccess;
using ReCapEntities.Concrete;

namespace ReCapDataAccess.Abstract
{
    public interface IBrandDal: IEntityRepository<Brand>
    {
    }
}
