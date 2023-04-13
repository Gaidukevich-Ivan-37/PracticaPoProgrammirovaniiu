namespace Задание__4
{
    class Array
    {
        static void Main()
        {
            Console.WriteLine("Задание №4\n Дан двумерный массив. Составить программу, определяющую, верно ли, " +
                "что сумма элементов строки массива с известным номером превышает заданное число?\n\nРешение:");

            Console.Write(" Введите размерность массива nxn: ");
            int n = Convert.ToInt16(Console.ReadLine());

            int[,] mas = new int[n, n];

            Random rnd = new();

            if (mas.Length == 0)
            {
                Console.WriteLine("\n Вы ввели матрицу размерностью 0 на 0");
            }
            else
            {
                Console.WriteLine(" Матрица случайных чисел:");
                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < n; j++)
                    {
                        mas[i, j] = rnd.Next(0, 10);
                        Console.Write(mas[i, j] + "\t");
                    }

                    Console.WriteLine();
                }

                Console.WriteLine("Введите номер строки");
                int num = Convert.ToInt16(Console.ReadLine());
                Console.WriteLine("Введите число");
                int ch = Convert.ToInt16(Console.ReadLine());
                int a = mas.GetLength(0);
                int b = mas.GetLength(1);
                if (num < a)
                {
                    int sum = 0;
                    for (int j = 0; j < b; j++)
                    {
                        sum += mas[num, j];
                    }
                    if (sum > ch)
                    {
                        Console.WriteLine("Сумма элементов строки массива с номером = {0} превышает заданное число ({1})", num, ch);
                    }
                    else
                    {
                        Console.WriteLine("Сумма элементов строки массива с номером = {0} не превышает заданное число ({1})", num, ch);
                    }
                }

                Console.ReadLine();

                Console.ReadKey();
            }
        }
    }
}