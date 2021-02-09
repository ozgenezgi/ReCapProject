using System;
using System.Collections.Generic;
using System.Text;
using Core.Entities;

namespace ReCapEntities.DTOs
{
    public class CarDetailDto : IDto
    {
        public int CarId { get; set; }
        public string BrandName { get; set; }
        public int BrandId { get; set; }
        public int DailyPrice { get; set; }
    }
}
