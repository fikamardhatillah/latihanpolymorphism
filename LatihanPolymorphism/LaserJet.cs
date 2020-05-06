using System;
using System.Collections.Generic;
using System.Text;

namespace LatihanPolymorphism
{
    class LaserJet : PrinterWindows
    {
        public override void ShowPrint()
        {
            Console.WriteLine("LaserJet display dimension 12 * 12");
            Console.WriteLine("LaserJet printer printing.....");
        }
    }
}
