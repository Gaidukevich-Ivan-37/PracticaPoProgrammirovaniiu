namespace Задание__1
{
    class Array
    {
        static void Main()
        {
            Console.WriteLine("Задание №1\n Вычислить сумму и количество элементов массива вещественных чисел." +
                "\n\nРешение:");

            double[] myArray = { 0.1, 0.2, 0.3, 0.4, 0.5, 0.6, 0.7, 0.8, 0.9 };
            int i;

            Console.Write(" Массив: ");
            for (i = 0; i < 9; ++i)
                Console.Write("{0} | ", myArray[i]);

            double sum = myArray.Sum();
            Console.WriteLine("\n\n Сумма элементов массива: {0}", sum);

            double kol = myArray.Length;
            Console.WriteLine(" Количество элементов массива: {0}", kol);
        }
    }
}