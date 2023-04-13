namespace Задание__5
{
    class Factorial
    {
        static void Main()
        {
            Console.WriteLine("Задание №5\n Разработать рекурсивный алгоритм и программу решения задачи, " +
                "\nв которой вычислить: f(n) = 2 / n!.Исходные данные вводятся с клавиатуры.\n\nРешение:");

            Console.Write(" Введите число : ");
            double num = Convert.ToInt16(Console.ReadLine());

            double factorial = 1;
            for (double i = 1; i <= num; i++)
            {
                factorial *= i/2;
                if (i == num)
                {
                    Console.Write(" {0}", i/2);
                }
                else
                {
                    Console.Write(" {0} * ", i/2);
                }
            }

            Console.Write(" = {0}", factorial);

            Console.ReadKey();
        }
    }
}