namespace Задание__1
{
    class ArrayOperations
    {
        private string[,] array;

        // Конструктор для инициализации массива
        public ArrayOperations(int rows, int columns)
        {
            array = new string[rows, columns];
        }

        // Метод для установки значения элемента в массиве
        public void SetValue(int row, int column, string value)
        {
            array[row, column] = value;
        }

        // Метод получения значения элемента массива
        public string GetValue(int row, int column)
        {
            return array[row, column];
        }

        // Метод сравнения двух массивов на равенство
        public static bool operator ==(ArrayOperations array1, ArrayOperations array2)
        {
            if (array1.array.GetLength(0) != array2.array.GetLength(0) || array1.array.GetLength(1) != array2.array.GetLength(1))
            {
                return false;
            }

            for (int i = 0; i < array1.array.GetLength(0); i++)
            {
                for (int j = 0; j < array1.array.GetLength(1); j++)
                {
                    if (array1.array[i, j] != array2.array[i, j])
                    {
                        return false;
                    }
                }
            }

            return true;
        }

        // Метод сравнения двух массивов на неравенство
        public static bool operator !=(ArrayOperations array1, ArrayOperations array2)
        {
            return !(array1 == array2);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Задание №1\n Описать класс для работы с двумерным массивом строк" +
                "\n фиксированной длины. Обеспечить сравнение массивов на равенство" +
                "\n (перегрузку операции == для поэлементного сравнения). \n\nРешение:");

            ArrayOperations array1 = new ArrayOperations(2, 2);
            ArrayOperations array2 = new ArrayOperations(2, 2);

            array1.SetValue(0, 0, "Hello");
            array1.SetValue(0, 1, "World");
            array1.SetValue(1, 0, "C#");
            array1.SetValue(1, 1, "Programming");

            array2.SetValue(0, 0, "Hello");
            array2.SetValue(0, 1, "World");
            array2.SetValue(1, 0, "C#");
            array2.SetValue(1, 1, "Programming");

            if (array1 == array2)
            {
                Console.WriteLine("Массивы равны");
            }
            else
            {
                Console.WriteLine("Массивы неравны");
            }
        }
    }
}