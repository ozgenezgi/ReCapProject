using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using Core.DataAccess.EntityFramework;
using ReCapDataAccess.Abstract;
using ReCapEntities.Concrete;

namespace ReCapDataAccess.Concrete.EntityFramework
{
    public class EfUserDal : EfEntityRepositoryBase<User, CarDatabaseContext>, IUserDal
    {
        public void Add(Core.Entities.Concrete.User entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Core.Entities.Concrete.User entity)
        {
            throw new NotImplementedException();
        }

        public Core.Entities.Concrete.User Get(Expression<Func<Core.Entities.Concrete.User, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Core.Entities.Concrete.User> GetAll(Expression<Func<Core.Entities.Concrete.User, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<Core.Entities.Concrete.OperationClaims> GetClaims(Core.Entities.Concrete.User user)
        {
            throw new NotImplementedException();
        }

        public void Update(Core.Entities.Concrete.User entity)
        {
            throw new NotImplementedException();
        }
    }
}
