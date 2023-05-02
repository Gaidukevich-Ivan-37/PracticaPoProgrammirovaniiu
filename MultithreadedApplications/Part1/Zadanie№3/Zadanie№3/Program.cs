namespace Задание__2
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Задание №3\n Создать консольное приложение, в котором будут два метода, " +
                "\n один метод будет выполняться двумя потоками одновременно, а другой метод в каждый момент времени будет выполняться одним потоком. " +
                "\n (Количество потоков: 2, Метод: 1. A + A^1 + A^2 + A^3 + .. + A^N, А и N вводятся с клавиатуры; " +
                "\n 2. A * A^1 * A^2 * A^3 * .. * A^N, А и N вводятся с клавиатуры). \n\nРешение:");

            Console.Write(" Ввести число A: ");
            int A = Convert.ToInt16(Console.ReadLine());

            Console.Write(" Ввести степень N: ");
            int N = Convert.ToInt16(Console.ReadLine());

            Thread thread1 = new Thread(() => Method1(A, N));
            thread1.Start();
            thread1.Join();

            Thread thread2 = new Thread(() => Method2(A, N));
            thread2.Start(); 
            thread2.Join();
        }
        static void Method1(int A, int N)
        {
            int sum = 0;
            for (int i = 1; i <= N; i++)
            {
                sum += (int)Math.Pow(A, i);
            }

            int sum1 = A + sum;
            Console.WriteLine($"\n Метод 1: A + A^1 + A^2 + .. + A^N = {sum1}");
        }
        static void Method2(int A, int N)
        {
            int mul = 1;
            for (int i = 1; i <= N; i++)
            {
                mul *= (int)Math.Pow(A, i);
            }

            int mul1 = A * mul;
            Console.WriteLine($" Метод 2: A * A^1 * A^2 * .. * A^N = {mul1}");
        }
    }
}