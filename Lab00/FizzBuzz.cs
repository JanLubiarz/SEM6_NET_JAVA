﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int liczba = 30;
            FizzBuzzClass fz = new FizzBuzzClass(liczba);
            fz.Display();
        }
    }
}
