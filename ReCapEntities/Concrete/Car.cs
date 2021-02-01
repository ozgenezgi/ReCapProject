﻿using System;
using System.Collections.Generic;
using System.Text;
using ReCapEntities.Abstract;

namespace ReCapEntities.Concrete
{
    public class Car : IEntity
    {
        public int CarId { get; set; }
        public int BrandId { get; set; }
        public int ColorId { get; set; }
        public string ModelYear { get; set; }
        public int DailyPrice { get; set; }
        public string Description { get; set; }

    }
}
