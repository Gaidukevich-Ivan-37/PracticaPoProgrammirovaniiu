namespace Задание__7
{
    class AutonomousNumber
    {
        static void Main()
        {
            Console.WriteLine("Задание №7\n Число называется автоморфным, если оно равно последним цифрам своего " +
                "квадрата. Например, 5^2 = 25.\n\nРешение:");

            Console.Write(" Введите число a: ");
            int a = Convert.ToInt32(Console.ReadLine());

            double b = Math.Pow(a, 2);
            Console.WriteLine($" {a}^2 = {b}");

            int sec = (int)b / 10 % 10;
            int thi = (int)b % 10;

            if (b >= 100 && b <= 999)
            {
                if (a == sec * 10 + thi)
                {
                    Console.Write("\n Число a автоморфное");
                }
                else
                {
                    Console.WriteLine("\n Число a не автоморфное");
                }
            }
            else
            {
                Console.WriteLine("\n Число b не трёхзначное");
            }

            Console.ReadLine();
        }
    }
}