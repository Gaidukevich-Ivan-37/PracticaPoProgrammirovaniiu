namespace Задание__1
{
    class SumOfNumbers
    {
        static void Main()
        {
            Console.WriteLine("Задание №1\n Запрашивает с клавиатуры три целых числа, и выводит на экран сумму данных чисел " +
                "в прямом и обратном порядке.\n\nРешение:");

            int sum = 0;

            Console.WriteLine(" Ввдедите 3 числа:");

            Console.Write(" a= ");
            int a = Convert.ToInt16(Console.ReadLine());

            Console.Write(" b= ");
            int b = Convert.ToInt16(Console.ReadLine());

            Console.Write(" c= ");
            int c = Convert.ToInt16(Console.ReadLine());

            sum = a + b + c;

            Console.WriteLine(" {0}+{1}+{2}={2}+{1}+{0}", a, b, c);

            Console.ReadKey();
        }
    }
}