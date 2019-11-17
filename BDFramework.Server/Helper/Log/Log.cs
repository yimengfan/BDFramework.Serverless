﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BitSprite.Helper
{
    static public class Log
    {

       public static void WriteLine(string name , ConsoleColor color  =  ConsoleColor.White)
        {
            Console.ForegroundColor = color;
            Console.WriteLine(name);
        }
    }
}
