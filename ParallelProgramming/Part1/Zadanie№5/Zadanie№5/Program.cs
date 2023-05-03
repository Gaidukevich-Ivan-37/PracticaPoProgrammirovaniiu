namespace Задание__5
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Задание №5\n Выполните прерывание выполнения метода Parallel.Foreach при некотором условии. " +
                "\n Функции суммы и произведение чисел от 0 до N, где N значения из массива {6,5,12}. \n\nРешение:");

            int[] values = { 6, 5, 12 };

            foreach (int N in values)
            {
                int sum = 0;
                long mul = 1;
                int stopValue = N;

                //Установка условий выхода из цикла при достижения значения N
                Parallel.ForEach(
                    Enumerable.Range(0, N + 1),
                    (i, state) =>
                    {
                        if (i == stopValue)
                        {
                            state.Stop();
                            return;
                        }
                        sum += i;
                        mul *= i;
                    });

                Console.WriteLine(" Сумма чисел от 0 до {0}: {1}", stopValue, sum);
                Console.WriteLine(" Произведение чисел от 0 до {0}: {1}\n", stopValue, mul);  
            }

            Console.ReadKey();
        }
    }
}