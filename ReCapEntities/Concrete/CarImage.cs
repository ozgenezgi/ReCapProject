﻿using System;
using System.Collections.Generic;
using System.Text;
using Core.Entities;

namespace ReCapEntities.Concrete
{
    public class CarImage: IEntity
    {

        public int Id { get; set; }
        public int CarId { get; set; }
        public string ImagePath { get; set; }
        public DateTime? Date { get; set; }
    }
}
