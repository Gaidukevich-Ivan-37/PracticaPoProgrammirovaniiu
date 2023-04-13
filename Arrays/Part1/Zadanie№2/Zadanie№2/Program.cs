namespace Задание__2
{
    class Array
    {
        static void Main()
        {
            Console.WriteLine("Задание №2\n Пусть дано 50 чисел. Определите, сколько среди них отличных от " +
                "последнего числа.\n\nРешение:");

            Random random = new Random();

            int[] myArray = new int[50];
            int counter = 0;

            for (int i = 0; i < myArray.Length; i++)
                myArray[i] = random.Next(10);

            Console.Write(" Массив: ");
            foreach (var e in myArray)
            {
                Console.Write($"{e} ");

                if (e != myArray[^1])
                    counter++;
            }
            Console.WriteLine("\n\n Количество чисел, отличных от последнего: " + counter);

            int temp;
            for (int i = 0; i < myArray.Length - 1; i++)
            {
                for (int j = i + 1; j < myArray.Length; j++)
                {
                    if (myArray[i] > myArray[j])
                    {
                        temp = myArray[i];
                        myArray[i] = myArray[j];
                        myArray[j] = temp;
                    }
                }
            }

            Console.Write(" Вывод отсортированного массива: ");
            for (int i = 0; i < myArray.Length; i++)
            {
                Console.Write("{0} ",myArray[i]);
            }
        }
    }
}