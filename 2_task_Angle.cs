using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oaip_laba5_Akhmadullina4235
{
    class Angle
    {
        private double degrees;
        private double minutes;
        public void Read()
        {
            Console.Write("Введите градусы: ");
            degrees = Convert.ToDouble(Console.ReadLine());

            Console.Write("Введите минуты: ");
            minutes = Convert.ToDouble(Console.ReadLine());

            NormalAngle();
        }
        public void Display()
        {
            Console.WriteLine($"{degrees} градусов,{minutes} минут");
        }
        public double Radians()
        {
            double TotalRadians = degrees + (minutes / 60.0);
            return TotalRadians * 3.14159 / 180.0;
        }
        private void NormalAngle()
        {
            while (minutes >= 60)
            {
                degrees++;
                minutes -= 60;
            }
            while (minutes < 0)
            {
                degrees--;
                minutes += 60;
            }
            while (degrees >= 360)
            {
                degrees -= 360;
            }
            while (degrees < 0)
            {
                degrees += 360;
            }
        }
        public void Increase(int deg, int min)
        {
            degrees += deg;
            minutes += min;
            NormalAngle();
        }
        public void Decrease(int deg, int min)
        {
            degrees -= deg;
            minutes -= min;
            NormalAngle();
        }
        public double Sine()
        {
            double rad = Radians();
            return Math.Sin(rad);
        }

        public string Comparisone(Angle other)
        {
            int total1 = Convert.ToInt32(degrees) * 60 + Convert.ToInt32(minutes);
            int total2 = Convert.ToInt32(other.degrees) * 60 + Convert.ToInt32(other.minutes);

            if (total1 > total2)
                return "первый угол больше";
            else if (total1 < total2)
                return "первый угол меньше";
            else
                return "углы равны";
        }
    }
}


   