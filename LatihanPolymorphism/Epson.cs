﻿using System;
using System.Collections.Generic;
using System.Text;

namespace LatihanPolymorphism
{
    class Epson : PrinterWindows   
    {
        public override void ShowPrint()
        {
            Console.WriteLine("Epson display dimension 10 * 11");
            Console.WriteLine("Epson printer printing.....");
        }
    }
}
