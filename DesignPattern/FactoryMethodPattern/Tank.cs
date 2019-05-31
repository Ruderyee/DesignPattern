﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodPattern
{
    public class Tank : IFireable
    {
        public void Fire()
        {
            Console.WriteLine("Tank Fire!!");
        }
    }
}
