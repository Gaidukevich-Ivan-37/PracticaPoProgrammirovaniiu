namespace Задание__4
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Задание №4\n Дана последовательность натуральных чисел {a(0) ... a(n–1)}. " +
                "\n Создать многопоточное приложение для поиска суммы Еa(i), где a(i) – чётные числа. \n\nРешение:");

            int[] arr = {1, 2, 3, 4, 5, 6, 7, 8, 9, 10};
            int numThreads = 1;

            int[] partialSums = new int[numThreads];
            Thread[] threads = new Thread[numThreads];

            for (int i = 0; i < numThreads; i++)
            {
                int threadNum = i;
                threads[i] = new Thread(() => partialSums[threadNum] = SumEvenNumbers(arr, threadNum, numThreads));
                threads[i].Start();
            }

            for (int i = 0; i < numThreads; i++)
            {
                threads[i].Join();
            }

            int totalSum = 0;
            for (int i = 0; i < numThreads; i++)
            {
                totalSum += partialSums[i];
            }

            Console.WriteLine(" Общая сумма чётных чисел: " + totalSum);
        }
        static int SumEvenNumbers(int[] arr, int startIndex, int step)
        {
            int sum = 0;
            for (int i = startIndex; i < arr.Length; i += step)
            {
                if (arr[i] % 2 == 0)
                {
                    sum += arr[i];
                }
            }

            return sum;
        }
    }
}