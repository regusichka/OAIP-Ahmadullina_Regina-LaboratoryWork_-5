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
                Angle a1 = new Angle();
                Angle a2 = new Angle();

                Console.WriteLine("Угол 1:");
                a1.Read();

                Console.WriteLine("\nУгол 2:");
                a2.Read();

                Console.WriteLine($"\nУгол 1: "); a1.Display();
                Console.WriteLine($"Радианы: {a1.Radians()}");
                Console.WriteLine($"Синус: {a1.Sine()}");

                Console.WriteLine($"\nУгол 2: "); a2.Display();

                Console.WriteLine($"\nСравнение: {a1.Comparisone(a2)}");

            }
        }
    }

        
    
   