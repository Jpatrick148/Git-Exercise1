﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitExercise
{
    class Program
    {
        static void Main(string[] args)
        {

            string input = Console.ReadLine();
            int num;

            while (!(int.TryParse(input, out num)))
            {
                Console.Write("Input must be a whole number.\nPlease try again: ");
            }



        }
    }
}
