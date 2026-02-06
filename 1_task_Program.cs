using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oaip_laba5_Akhmadullina4235
{
    class Program
    {
        static void Main()
        {
            LinearEquation le = new LinearEquation();
            le.Read();
            le.Display();
            Console.Write("Введите значение х: ");
            double x = Convert.ToDouble(Console.ReadLine());
            double y = le.Function(x);
            Console.WriteLine($"y = {y}");
        }
    }
}
}
        
    
   