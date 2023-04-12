namespace Задание__1
{
    class MinimumNumber
    {   
        static double min (double a, double b)
        { 
            return (a < b) ? a : b;
        }
        static void Main()
        {
            Console.WriteLine("Задание №1\n Разработать метод min (a,b) для " +
                "\nнахождения минимального из двух чисел. Вычислить с помощью него " +
                "\nзначение минимальное значение из чеырёх чисел x, y, z, v.\n\nРешение:");

            Console.Write(" Введите радиус x: ");
            double x = double.Parse(Console.ReadLine());

            Console.Write(" Введите высоту y: ");
            double y = double.Parse(Console.ReadLine());

            Console.Write(" Введите высоту z: ");
            double z = double.Parse(Console.ReadLine());

            Console.Write(" Введите высоту v: ");
            double v = double.Parse(Console.ReadLine());

            Console.WriteLine("\n Минимальное значение: {0}",min(min(x, y), min(z, v)));
            
            Console.ReadKey();
        }
    }
}