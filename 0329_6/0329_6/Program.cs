﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0329_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    bool iok = (j == i) || (j == 4 - i);
                    if (iok) Console.Write("*");
                    if (!iok) Console.Write(" ");
                }
                Console.WriteLine();
            }
        }
    }
}
