﻿
using Core.Entities;

using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Conctre
{
    public class Brand : IEntity
    {

        public int BrandId { get; set; }
        public string BrandName { get; set; }
    }
}
