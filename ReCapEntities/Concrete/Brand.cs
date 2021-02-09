using System;
using System.Collections.Generic;
using System.Text;
using Core.Entities;


namespace ReCapEntities.Concrete
{
    public class Brand : IEntity
    {
        public int BrandId { get; set; }
        public string BrandName { get; set; }
    }
}
