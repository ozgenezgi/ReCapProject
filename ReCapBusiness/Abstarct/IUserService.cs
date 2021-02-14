using System;
using System.Collections.Generic;
using System.Text;
using Core.Utilities.Results;
using ReCapEntities.Concrete;

namespace ReCapBusiness.Abstarct
{
    public interface IUserService
    {
        IDataResult<List<User>> GetAll();
        IResult Add(User user);
        IResult Delete(User user);
    }
}
