﻿using System;
using System.Collections.Generic;
using System.Text;
using Core.Entities;


namespace ReCapEntities.Concrete
{
    public class Color : IEntity
    {
        public int ColorId { get; set; }
        public string ColorName { get; set; }

    }
}
