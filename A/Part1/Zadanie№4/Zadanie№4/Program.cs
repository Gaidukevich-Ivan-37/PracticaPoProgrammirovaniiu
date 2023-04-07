namespace Задание__4
{
    class Time
    {
        static void Main()
        {
            Console.WriteLine("Задание №4\n Определить время t падения камня на поверхность земли с высоты h.\n\nРешение:");

            double g, t;

            g = 9.81523;

            Console.Write(" Введите высоту h: ");
            double h = double.Parse(Console.ReadLine());

            t = (Math.Sqrt(2 * h / g));

            Console.Write("\n Время падения камня t: {0}", Math.Round(t, 5));

            Console.ReadKey();
        }
    }
}