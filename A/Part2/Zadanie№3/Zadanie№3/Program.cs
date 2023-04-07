namespace Задание__3
{
    class CalculationOfEduations
    {
        static void Main()
        {
            Console.WriteLine("Задание №3\n Напишите программу расчета по двум формулам. Предварительно\n " +
                "подготовьте тестовые примеры (результат вычисления по первой формуле\n " +
                "должен в большинстве вариантов совпадать со второй).\n\nРешение:");

            double a, z1, z2;

            Console.Write(" Введите значения a: ");
            a = double.Parse(Console.ReadLine());

            z1 = (1 - 2 * Math.Pow(Math.Sin(a), 2)) / (1 + Math.Sin(2 * a));
            Console.WriteLine(" z1 = (1 - 2 * sin^2(a)) / (1 + sin(2 * a)) = {0}", z1);

            z2 = ((1 - Math.Tan(a)) / (1 + Math.Tan(a)));
            Console.WriteLine(" z2 = (1 - tg(a)) / (1 + tg(a)) = {0}\n", z2);

            if (z1 == z2)
            {
                Console.WriteLine(" Первое и второе занение равны");
            }

            if (z1 > z2)
            {
                Console.WriteLine(" Первое занение больше второго");
            }

            if (z1 < z2)
            {
                Console.WriteLine(" Второе занение больше первого");
            }

            Console.ReadLine();
        }
    }
}