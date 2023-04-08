namespace Задание__1
{
    class FunctionSolution
    {
        static void Main()
        {
            Console.WriteLine("Задание №1\n Написать программу, которая вычисляет значение функции у.\n\nРешение:");

            double x, y;

            Console.Write(" Введите значение x: ");
            x = Convert.ToInt32(Console.ReadLine());

            if (x >= 10)
            {
                y = 4 + Math.Pow(x,2) - Math.Exp(Math.Sqrt(x));
                Console.WriteLine("\n Функция y: {0}", Math.Round(y, 1));
            }
            else
            {
                y = 3.4 - x + 0.3 * Math.Pow(x, 3);
                Console.WriteLine("\n Функция y: {0}", Math.Round(y, 1));
            }

            Console.ReadKey();
        }
    }
}