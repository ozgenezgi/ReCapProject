using System;
using System.Collections.Generic;
using System.Text;
using Core.DataAccess.EntityFramework;
using ReCapDataAccess.Abstract;
using ReCapEntities.Concrete;

namespace ReCapDataAccess.Concrete.EntityFramework
{
    public class EfUserDal : EfEntityRepositoryBase<User, CarDatabaseContext>, IUserDal
    {
    }
}
