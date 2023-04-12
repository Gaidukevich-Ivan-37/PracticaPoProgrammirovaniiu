namespace Задание__2
{
    class Program
    {
        static public double F(double x)
        {
            double y = 0;

            if (Math.Abs(x) < 3)
            {
                y = Math.Sin(x);

                Console.WriteLine("\n y = Math.Sin(x)", y);
            }
            else
            {
                if ((Math.Abs(x) >= 3) || (Math.Abs(x) < 9))
                {
                    y = (Math.Sqrt(Math.Pow(x, 2) + 1)) /
                        (Math.Sqrt(Math.Pow(x, 2) + 5));

                    Console.WriteLine("\n y = (Math.Sqrt(Math.Pow(x, 2) + 1)) / " +
                        "(Math.Sqrt(Math.Pow(x, 2) + 5))", y);
                }
                else
                {
                    if (Math.Abs(x) >= 9)
                    {
                        y = (Math.Sqrt(Math.Pow(x, 2) + 1)) -
                            (Math.Sqrt(Math.Pow(x, 2) + 5));

                        Console.WriteLine("\n y = (Math.Sqrt(Math.Pow(x, 2) + 1)) - " +
                        "(Math.Sqrt(Math.Pow(x, 2) + 5))", y);
                    }
                }
            }
            return y;
        }
        public static void Main()
        {
            Console.WriteLine("Задание №2\n Построить таблицу значений функции " +
                "\ny=f(x) для x[a, b] с шагом h.\n\nРешение:");

            double a, b, h, y;

            Console.Write(" Введите значение а: ");
            a = Convert.ToDouble(Console.ReadLine());

            Console.Write(" Введите значение b: ");
            b = Convert.ToDouble(Console.ReadLine());

            if (a > b)
                Console.WriteLine("\n Значение a больше b");
            else
            {
                Console.Write(" Введите значение h: ");
                h = Convert.ToDouble(Console.ReadLine());

                double s = a;
                while (s <= (b + h))
                {
                    y = F(s);
                    Console.WriteLine(" x=  " + s + "    " + "y= " + y);
                    s += h;
                }

                Console.ReadKey();
            }
        }
    }
}