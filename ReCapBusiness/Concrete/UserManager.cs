

using System.Collections.Generic;
using Core.Entities.Concrete;
using Core.Utilities.Results;
using ReCapBusiness.Abstarct;
using ReCapBusiness.Constants;
using ReCapDataAccess.Abstract;

namespace ReCapBusiness.Concrete
{
    public class UserManager : IUserService
    {
        IUserDal _userDal;

        public UserManager(IUserDal userDal)
        {
            _userDal = userDal;
        }

        public List<OperationClaims> GetClaims(User user)
        {
            return _userDal.GetClaims(user);
        }


        public User GetByMail(string email)
        {
            return _userDal.Get(u => u.Email == email);
        }

        public IResult Add(User user)
        {
           
            
            _userDal.Add(user);

            return new SuccessResult(Messages.UserrAdded);
        }
    }







}

