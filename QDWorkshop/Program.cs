﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QDWorkshop
{
    public class Program
    {
        public static void Main(string[] args)
        {

            Console.WriteLine("Enter ssn: ");
            var x = Convert.ToBoolean(Console.ReadLine());

            var stringOperations = new StringOperations();
            Console.WriteLine(stringOperations.GetBirthday(x.ToString()));
            Console.ReadLine();
        }
    }
}
