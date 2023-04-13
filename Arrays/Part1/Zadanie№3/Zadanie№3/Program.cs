namespace Задание__3
{
    class Array
    {
        static void Main()
        {
            Console.WriteLine("Задание №3\n Вычислить сумму отрицательных элементов. " +
                "\nВычислить количество чётных элементов в каждой строки.\n\nРешение:");

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
                        mas[i, j] = rnd.Next(-50, 50);
                        Console.Write(mas[i, j] + "\t");
                    }

                    Console.WriteLine();
                }

                int sum = 0;
                int score = 0;
                int countEven = 0;

                foreach (int i in mas)
                {
                    if (i < 0)
                    {
                        sum += i;
                        score++;
                    }

                    if (i % 2 == 0)
                    {
                        countEven++;
                    }
                }

                if (score != 0)
                    Console.WriteLine("\n Сумма отрицательных элементов = {0}", sum);
                else
                    Console.WriteLine("\n Отрицательных элементов нет");

                if (countEven != 0)
                    Console.WriteLine(" Количество чётных элементов = {0}", countEven);
                else
                    Console.WriteLine(" Чётных элементов нет");
            }

            Console.ReadKey();
        }
    }
}