namespace Задание__5
{
    class ExpressionSolution
    {
        static void Main()
        {
            Console.WriteLine("Задание №5\n Дано целое число N (N > 0). Найти значение выражения" +
                "\n1.1 – 1.2 + 1.3 – … (N слагаемых, знаки чередуются). Условный оператор\nне использовать.\n\nРешение:");

            Console.Write(" Введите число N: ");
            int N = Convert.ToInt32(Console.ReadLine());

            double rez = 0;

            for (int i = 1; i <= N; i++)
            {
                rez += Math.Pow(-1, i + 1) * (1.0 + (double)i / 10);
            }

            string rezult = string.Format("{0:f4}", rez);
            Console.WriteLine("\n Значение выражения: {0}", rezult);

            Console.ReadKey();
        }
        
    }
}