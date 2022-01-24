﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLibrary
{
    public abstract class Duck
    {
        public string Swim()
        {
            return "swim" + "" + GetType();
        }
        public abstract string Display();
    }
}