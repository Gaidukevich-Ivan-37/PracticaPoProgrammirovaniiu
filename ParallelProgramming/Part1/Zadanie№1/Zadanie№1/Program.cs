namespace Задание__1
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Задание №1\n Создайте и реализуйте метод решения задачи и выполните его в объектах класса Task " +
                "\n используя три варианта создания объектов класса Task: дано четырехзначное число. Найти произведение его цифр. \n\nРешение:");

            int number = 1234;
            int result1 = 0, result2 = 0, result3 = 0;

            // Способ 1: Использование метода Task.Run()
            Task task1 = Task.Run(() =>
            {
                result1 = GetProductOfDigits(number);
            });

            // Method 2: Использование метода Task.Factory.StartNew()
            Task task2 = Task.Factory.StartNew(() =>
            {
                result2 = GetProductOfDigits(number);
            });

            // Method 3: Использование конструктора Task
            Task task3 = new(() =>
            {
                result3 = GetProductOfDigits(number);
            });
            task3.Start();

            Task.WaitAll(task1, task2, task3);

            Console.WriteLine($" Произведение цифр {number} с использованием Task.Run(): {result1}");
            Console.WriteLine($" Произведение цифр {number} с использованием Task.Factory.StartNew(): {result2}");
            Console.WriteLine($" Произведение цифр {number} с использованием Task constructor: {result3}");

            Console.ReadKey();
        }

        //Произведение цифр
        static int GetProductOfDigits(int number)
        {
            int product = 1;
            while (number > 0)
            {
                product *= number % 10;
                number /= 10;
            }
            return product;
        }
    }
}