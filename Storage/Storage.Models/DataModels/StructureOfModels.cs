﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Storage.Models.DataModels
{
    public abstract class StructureOfModels
    {
        DateTime data = new DateTime();

        public  int Amount { get; set; }

        public  int GoodId {get;set;}
    }
}
