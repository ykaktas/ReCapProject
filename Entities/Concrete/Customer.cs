﻿using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class Customer : IEntity
    {
            
        public string CompanyName { get; set; }
        public int Id { get; set; }



    }
}
