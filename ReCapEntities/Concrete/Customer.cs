using System;
using System.Collections.Generic;
using System.Text;
using Core.Entities;

namespace ReCapEntities.Concrete
{
    public class Customer: IEntity
    {
        public int CustomerId { get; set; }
        public int UserId { get; set; }
        public string CompanyName { get; set; }

    }
}
