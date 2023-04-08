namespace Задание__4
{
    class EvenNumbers
    {
        static void Main()
        {
            Console.WriteLine("Задание №4\n Вывести на экран (задачу решите тремя способами - используя операторы " +
                "цикла while, do while и for) целые числа 10, 12, 14, ..., 80 в обратном порядке в столбик.\n\nРешение:");

            Console.WriteLine(" Решение задачи с помощью оператора for:");
            for (int i = 80; i >= 10; i -= 2)
            {
                Console.WriteLine($" {i}");
            }

            Console.WriteLine("\n Решение задачи с помощью оператора while:");
            int k = 80;
            while (k >= 10)
            {   
                Console.WriteLine($" {k}");
                k -= 2;
            }

            Console.WriteLine("\n Решение задачи с помощью оператора do while:");
            int n = 80;
            do
            {
                Console.WriteLine($" {n}");
                n -= 2;
            }
            while (n >= 10);

            Console.ReadKey();
        }
    }
}