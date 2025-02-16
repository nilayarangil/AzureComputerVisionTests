using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputerVisionTest
{
    internal class InputHelper
    {
        public static void PressAnyKey()
        {
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();

            Console.WriteLine();
        }
    }
}
