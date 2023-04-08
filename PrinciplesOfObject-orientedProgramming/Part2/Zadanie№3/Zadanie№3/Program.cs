namespace Задание__3
{
    class PointСoordinates
    {
        static void Main()
        {
            Console.WriteLine("Задание №3\n Даны два целых числа A и B (A < B). Вывести в порядке возрастания " +
                "все целые числа, расположенные между A и B(включая сами числа A и B), а также количество N этих чисел. " +
                "Входные данные: ввести два целых числа A, B(1 <= A,B <= 100). Выходные данные: " +
                "вывести в порядке возрастания все целые числа, расположенные между A и B(включая сами числа A и B), " +
                "а также количество N этих чисел.\n\nРешение:");

            Console.Write(" Ввести число a: ");
            int a = int.Parse(Console.ReadLine());

            Console.Write(" Ввести число b: ");
            int b = int.Parse(Console.ReadLine());

            if (a > b) Console.Write("\n a должна быть меьше b");
            else { 
                int kol = b - a + 1;
                Console.WriteLine("\n Вывод чисел:");
                for (int i = a; i <= b; i++)
                    Console.WriteLine($" {i}");
                Console.WriteLine(" Количество чисел равно: {0}", kol); 
            }
            
            Console.ReadKey();
        }
    }
}