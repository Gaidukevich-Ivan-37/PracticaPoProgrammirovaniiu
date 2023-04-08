namespace Задание__2
{
    class PointСoordinates
    {
        static void Main()
        {
            Console.WriteLine("Задание №2\n Проверить истинность высказывания: <<Данные числа x, y" +
                "\nявляются координатами точки, лежащей во второй координатной четверти>>.\n\nРешение:");

            Console.Write(" Введите координату x: ");
            double x = Convert.ToInt16(Console.ReadLine());
            Console.Write(" Введите координату y: ");
            double y = Convert.ToInt16(Console.ReadLine());

            if (x < 0 && y > 0) Console.Write("\n Четверть 2");
            else Console.Write("\n Не четверть 2");

            Console.ReadKey();
        }
    }
}