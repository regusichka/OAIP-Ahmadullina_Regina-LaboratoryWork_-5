using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oaip_laba5_Akhmadullina4235
{
    class LinearEquation
    {
        private double first;
        private double second;
        public void Read()
        {
            Console.Write("Введите коэффициент A: ");
            first = Convert.ToDouble(Console.ReadLine());

            Console.Write("Введите коэффициент B: ");
            second = Convert.ToDouble(Console.ReadLine());
        }
        public void Display()
        {
            Console.WriteLine($"A={first}, B={second}");
        }
        public double Function(double x)
        {
            return first * x + double;
        }
    }
}      
    
   