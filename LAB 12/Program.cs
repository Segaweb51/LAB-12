using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB_12
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Cat.voice);
            Console.ReadKey();
        }
        public class Cat
        {
            public static string voice = "Мяу";
            public const int countFeet = 4;
            public readonly bool wool = true;
            public string Name { get; set; }
            public string Color { get; set; }
            int age;

            public int Age;

            public Cat (string name, string colore, int age, bool wool)
            {
                Name = name;
                Color = Color;
                Age = age;
                this.wool = wool;
            }
            public void Say()
            {
                Console.WriteLine("Мяу. Меня зовут {0}. У меня {1} цвет. Мне {2} лет.", Name, Color, Age);
            }
     
        }
    }
}
