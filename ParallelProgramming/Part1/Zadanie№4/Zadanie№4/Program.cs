namespace Задание__4
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Задание №4\n Выполните параллельное вычисления значений функции 2 - sin(x) для каждого значения на отрезке [А,B], " +
                "\n где A=-3, B=7. Используя метод Parallel.For. \n\nРешение:");

            double A = -3;
            double B = 7;

            int n = 10;

            double h = (B - A) / n;

            double[] results = new double[n];

            // Выполнение параллельного вычисления
            Parallel.For(0, n, i =>
            {
                double x = A + i * h;
                results[i] = 2 - Math.Sin(x);
            });

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($" x = {A + i * h}, y = {results[i]}");
            }

            Console.ReadKey();
        }
    }
}