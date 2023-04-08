namespace Задание__1
{
    class Weight
    {
        static void Main()
        {
            Console.WriteLine("Задание №1\n Дана масса в килограммах. Найти число полных центнеров в ней.\n\nРешение:");

            Console.Write(" Введите массу(кг) m: ");
            double m = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine($"\n Масса(ц) m: {m / 100}");

            Console.ReadKey();
        }
    }
}