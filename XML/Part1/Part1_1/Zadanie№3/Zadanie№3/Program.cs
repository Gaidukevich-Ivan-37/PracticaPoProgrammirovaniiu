namespace Задание__3
{
    //Создание уравнений и их условий
    class Program
    {
        //Перегрузка метода
        static double F(double x, out double y)
        {
            if (Math.Abs(x) < 3)
                y = Math.Sin(x);

            else if ((Math.Abs(x) >= 3) || (Math.Abs(x) < 9))
                y = (Math.Sqrt(Math.Pow(x, 2) + 1)) / (Math.Sqrt(Math.Pow(x, 2) + 5));

            else
                y = (Math.Sqrt(Math.Pow(x, 2) + 1)) - (Math.Sqrt(Math.Pow(x, 2) + 5));
            Console.WriteLine(x + ") " + y);
            return y;
        }
        static double F(double x)
        {
            double y;
            if (Math.Abs(x) < 3)
                y = Math.Sin(x);

            else if ((Math.Abs(x) >= 3) || (Math.Abs(x) < 9))
                y = (Math.Sqrt(Math.Pow(x, 2) + 1)) / (Math.Sqrt(Math.Pow(x, 2) + 5));

            else
                y = (Math.Sqrt(Math.Pow(x, 2) + 1)) - (Math.Sqrt(Math.Pow(x, 2) + 5));
            Console.WriteLine(x + ") " + y);
            return y;
        }
        static void Main()
        {
            Console.WriteLine("Задание №3\n Перегрузить метод F из предыдущего раздела.\n\nРешение:");

            Console.Write(" Начало диапазона a: ");
            double a = double.Parse(Console.ReadLine());

            Console.Write(" Конец диапазона b: ");
            double b = double.Parse(Console.ReadLine());

            Console.Write(" Шаг h: ");
            double h = double.Parse(Console.ReadLine());

            double y = 0;
            for (double i = a; i <= b; i += h)
            {
                y = F(i);
                F(i, out y);
            }

            Console.WriteLine();
            Console.ReadLine();
        }
    }
}