﻿using Core.DataAccess;
using Entities.Conctre;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstract
{
    public interface ICarDal: IEntityRepository<Cars>
    {
        List<CarDetailsDto> GetCarsDetails();


    }
}
