﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    class Program
    {
        public static void Main(string[] args)
        {
            var names = new List<string>();
            names.Add("ravi");
            names.Add("Ashu");
            names.Add("nitesh");
            names.Add("Mohan");
            names.Add("Ram");
            names.Add("Ritu");

            foreach (var name in names)
            {
                Console.WriteLine(name);

            }
            Console.ReadLine();
        }
    }
}
