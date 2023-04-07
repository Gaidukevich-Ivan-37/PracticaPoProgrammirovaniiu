namespace Задание__1
{
    class Cylinder
    {
        static void Main()
        {
            Console.WriteLine("Задание №1\n Вычисление объема цилиндра\n Введите исходные данные:\n Радиус основания (см) " +
                "—--> 10\n Высота цилиндра (см) —--> 5\n Объем цилиндра 1570.80 куб. см.\n\nРешение:");

            double V;

            Console.Write(" Введите радиус R: ");
            double R = double.Parse(Console.ReadLine());

            Console.Write(" Введите высоту h: ");
            double h = double.Parse(Console.ReadLine());

            V = (Math.PI * R * R * h);
            string result = string.Format("{0:f}", V);
            Console.Write("\n Объем цилиндра: {0}", result);

            Console.ReadKey();
        }
    }
}