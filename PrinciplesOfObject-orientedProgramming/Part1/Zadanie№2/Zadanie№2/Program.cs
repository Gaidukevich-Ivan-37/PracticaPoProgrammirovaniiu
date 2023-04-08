namespace Задание__2
{
    class EvenAndOddNumber
    {
        static void Main()
        {
            Console.WriteLine("Задание №2\n Написать программу, которая определяет является ли заданное " +
                "целое число четным.\n\nРешение:");

            Console.Write(" Введите значение x: ");
            int x = Convert.ToInt16(Console.ReadLine());

            if ((x % 2) == 0)
            {
                Console.WriteLine("\n Чётное число");
            }
            else
            {
                Console.WriteLine("\n Нечётное число");
            }

            Console.ReadKey();
        }
    }
}