using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework12T1
{
    class Program
    {
        static void Main(string[] args)
        {
            Zadachi.R = 3.604;// Позволяет получать длину окружности и площадь с помощью методов.
            Zadachi.x1 = 2;
            Zadachi.y1 = 3;// Позволяет определить принадлежность кругу с указанными координатами.
            Zadachi.Findp();
            Zadachi.Finds();
            Zadachi.Findu(); // Просто вводим значения из методов, чтобы проверить, что static класс работает
            Console.ReadKey();
        }
    }


    public static class Zadachi
    {
        public static double R;
        public static double x1;
        public static double y1;

        public static void Findp()
        {
            double P = 2 * Math.PI * R;
            Console.WriteLine("Длина окружности равняется = {0}", Math.Round(P));
        }

        public static void Finds()
        {
            double S = Math.PI * Math.Pow(R, 2);
            Console.WriteLine("Площадь круга равняется = {0}", Math.Round(S));
        }

        public static void Findu()
        {

            double r = Math.Sqrt(Math.Pow(x1, 2) + Math.Pow(y1, 2));
           
            if (R>=r)
            {
                Console.WriteLine("Точка с указаннымси координатами принадлежит кругу");
            }
            else if (R < r)
            {
                Console.WriteLine("Точка с указаннымси координатами не принадлежит кругу");
            }
           
        }

    }
}
