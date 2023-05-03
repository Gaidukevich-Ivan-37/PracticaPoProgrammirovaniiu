namespace Задание__2
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Задание №2\n Создайте массив из 2 задач (объектов класс Task) в каждом объекте выполните вычисление значения функций и " +
                "\n выполните условия: " +
                "\n 1. Дождитесь выполнения всех задач;" +
                "\n 2. Дождитесь выполнения хот бы одной задачи." +
                "\n Замедлить выполнение задачи можно с помощью Thread.Sleep(n) в методе, выполняемом задачей; где n – время в миллисекундах. \n\nРешение:");

            double a = 0;
            Console.WriteLine(" a = {0}", a); 

            Task<double> task1 = Task.Run(() =>
            {
                Thread.Sleep(1000);
                return (1 - 2 * Math.Pow(Math.Sin(a), 2)) / (1 + 2 * Math.Sin(2 * a));
            });

            Task<double> task2 = Task.Run(() =>
            {
                Thread.Sleep(1000);
                return (1 - Math.Tan(a)) / (1 + Math.Tan(a));
            });

            // Дождаться выполнения всех задач
            Task.WaitAll(task1, task2);
            Console.WriteLine("\n Результаты выполнения всех задач:");
            Console.WriteLine($"  Значение функции z1 = (1 - 2 * sin^2(a)) / (1 + 2 * sin(2 * a)) = {task1.Result}");
            Console.WriteLine($"  Значение функции z2 = (1 - tg(a)) / (1 + tg(a)) = {task2.Result}");

            Task<string> task3 = Task.Run(() =>
            {
                Thread.Sleep(5000);
                string b = "Ждём";
                return b;
            });

            Task<double> task4 = Task.Run(() =>
            {
                Thread.Sleep(10000);
                return (1 - 2 * Math.Pow(Math.Sin(a), 2)) / (1 + 2 * Math.Sin(2 * a));
            });

            Task<string> task5 = Task.Run(() =>
            {
                Thread.Sleep(15000);
                string c = "Не спеша так, ждём...";
                return c;
            });

            Task<string> task6 = Task.Run(() =>
            {
                Thread.Sleep(25000);
                string d = "._.";
                return d;
            });

            Task<double> task7 = Task.Run(() =>
            {
                Thread.Sleep(30000);
                return (1 - Math.Tan(a)) / (1 + Math.Tan(a));
            });

            // Дождаться выполнения хотя бы одной задачи
            int index = Task.WaitAny(task3, task5);
            Console.WriteLine("\n Результат выполнения затоморженных задач:");
            Console.WriteLine($"  {task3.Result}");

            Console.WriteLine($"  Значение функции z1 = (1 - 2 * sin^2(a)) / (1 + 2 * sin(2 * a)) = {task4.Result}");
            
            Console.Write($"  {task5.Result}");
            Console.WriteLine($"  {task6.Result}");

            Console.WriteLine($"  Значение функции z2 = (1 - tg(a)) / (1 + tg(a)) = {task7.Result}");

            Console.ReadKey();
        }
    }
}