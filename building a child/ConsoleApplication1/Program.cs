﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
         

        static void Main(string[] args)
        {
            Class1 game = new Class1();
            game.run();

            Console.WriteLine("Press any key to exit");
            Console.ReadLine();
        }
    }
}
