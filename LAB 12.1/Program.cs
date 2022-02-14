using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB_12._1
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
            Console.Write("Введите радиус :");
            Double Radius = Convert.ToDouble(Console.ReadLine());
            if (Radius <= 0)
            {
                Console.Write("Радиус натуральное положительное число");
                return;
            }
            Console.Write("Введите координату X");
            double positionX = Math.Abs(Convert.ToDouble(Console.ReadLine()));
            Console.Write("Введите координату Y");
            double positionY = Math.Abs(Convert.ToDouble(Console.ReadLine()));

            Circle.GetСircleline(Radius);
            Circle.GetSquare(Radius);
            Circle.GetPosition(Radius, positionX, positionY);
            }
            catch (FormatException)
            {
                Console.WriteLine("Неверный радиус");
                return;
            }
        }
        static class Circle
        {
            public static void GetСircleline(double Radius)
            {
                double Сircumference = Math.PI * 2 * Radius;
                Console.WriteLine("Длина окружности равна {0:f2}", Сircumference);
                
            }
            public static void GetSquare(double Radius)
            {
                double Square = Math.PI * Math.Pow(Radius, 2.0);
                Console.WriteLine("Площадь круга равна {0:f2}", Square);
                

            }
            public static void GetPosition(double Radius, double positionX, double positionY)
            {
                if (positionX <= Radius && positionY <= Radius)
                {
                    Console.WriteLine("Точка с координатами ({0},{1}) принадлежит кругу с радиусом {2}", positionX, positionY, Radius);
                    Console.ReadKey();
                }
                else
                {
                    Console.WriteLine("Точка с координатами ({0},{1}) не принадлежит кругу с радиусом {2}", positionX, positionY, Radius);
                    Console.ReadKey();
                }

            }
        }
    }
}
