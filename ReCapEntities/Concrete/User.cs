﻿using System;
using System.Collections.Generic;
using System.Text;
using Core.Entities;

namespace ReCapEntities.Concrete
{
    public class User : IEntity
    {
        public int UserId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
    }
}