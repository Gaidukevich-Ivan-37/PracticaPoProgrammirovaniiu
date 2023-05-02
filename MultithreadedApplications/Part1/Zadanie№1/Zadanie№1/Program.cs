namespace Задание__1
{
    class Program
    {
        static void Main( )
        {
            Console.WriteLine("Задание №1\n Создать консольное приложение, в котором реализовано 3 потока. " +
                "\n Первый выводит числа от 0 до 9, второй – от 10 до 19, третий – от 20 до 29. " +
                "\n Вывод значений на экран происходит следующим образом: сначала своё число выводит первый поток, а затем второй и третий. " +
                "\n Организовать возможность использования методов Start и Sleep, а также изменение свойства Priority, позволяющее изменить приоритет потока. " +
                "\n Можно воспользоваться инструментами синхронизации потоков lock, AutoResetEvent и т.д. \n\nРешение:");

            Thread thread1 = new(CountNumbers)
            {
                Priority = ThreadPriority.Highest
            };
            thread1.Start(0);
            thread1.Join();

            Thread thread2 = new(CountNumbers)
            {
                Priority = ThreadPriority.Normal
            };
            thread2.Start(10);
            thread2.Join();

            Thread thread3 = new(CountNumbers)
            {
                Priority = ThreadPriority.Lowest
            };
            thread3.Start(20);
            thread3.Join();

            Console.ReadKey();
        }
        static void CountNumbers(object start)
        {
            int num = (int)start;

            lock (Console.Out)
            {
                for (int i = 0; i < 10; i++)
                {
                    Console.WriteLine($" {num}");
                    num++;
                    Thread.Sleep(50);
                }
            }
        }
    }
}