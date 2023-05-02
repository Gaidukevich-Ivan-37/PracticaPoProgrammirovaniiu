namespace Задание__2
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Задание №2\n Создать консольное приложение, в котором несколько потоков будут выполнять один и тот же метод. " +
                "\n (Количество потоков: 2, Метод: Сумма чисел от 1 до 10). " +
                "\nПроизвести расчет затраченного времени в миллисекундах на выполнение потока и вывести его на экран. \n\nРешение:");

            Thread thread1 = new(new ThreadStart(SumNumbers));
            thread1.Start();
            thread1.Join();

            Thread thread2 = new(new ThreadStart(SumNumbers));
            thread2.Start();
            thread2.Join();

            Console.ReadKey();
        }
        static void SumNumbers()
        {
            int sum = 0;
            for (int i = 1; i <= 10; i++)
            {
                sum += i;
            }

            Console.WriteLine($" Сумма: {sum}, затраченное время: {DateTime.Now.Millisecond}ms");
        }
    }
}