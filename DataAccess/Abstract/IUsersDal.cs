﻿using Core.DataAccess;
using Core.Entities;
using Core.Entities.Concrete;
using Entities.Conctre;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstract
{
    public interface IUserDal: IEntityRepository<User>
    {

        List<OperationClaim> GetClaims(User user);
    }
}
