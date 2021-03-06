using System;
using System.Collections.Generic;
using System.Text;
using Core.Entities.Concrete;
using Core.Utilities.Results;


namespace ReCapBusiness.Abstarct
{
    public interface IUserService
    {
        List<OperationClaims> GetClaims(User user);
       
        IResult Add(User user);
        User GetByMail(string email);
    }
}
