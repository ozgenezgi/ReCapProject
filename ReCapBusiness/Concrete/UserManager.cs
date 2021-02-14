using System;
using System.Collections.Generic;
using System.Text;
using Core.Utilities.Results;
using ReCapBusiness.Abstarct;
using ReCapBusiness.Constants;
using ReCapDataAccess.Abstract;
using ReCapEntities.Concrete;

namespace ReCapBusiness.Concrete
{
    public class UserManager : IUserService
    {
        IUserDal _userDal;

        public UserManager(IUserDal userDal)
        {
            _userDal = userDal;
        }

        public IResult Add(User user)
        {
            if (user.UserId == 0)
            {

                return new ErrorResult(Messages.UserError);
            }
            _userDal.Add(user);

            return new SuccessResult(Messages.UserAdded);
        }

        public IResult Delete(User user)
        {
            _userDal.Delete(user);
            return new SuccessResult(Messages.UserDeleted);
        }

        public IDataResult<List<User>> GetAll()
        {
            return new SuccessDataResult<List<User>>(_userDal.GetAll());
        }

 
    }
}
