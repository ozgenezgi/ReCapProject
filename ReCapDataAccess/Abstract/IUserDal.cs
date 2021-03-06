﻿using System;
using System.Collections.Generic;
using System.Text;
using Core.DataAccess;
using Core.Entities.Concrete;


namespace ReCapDataAccess.Abstract
{
    public interface IUserDal: IEntityRepository<User>
    {

        List<OperationClaims> GetClaims(User user);
    }
}
