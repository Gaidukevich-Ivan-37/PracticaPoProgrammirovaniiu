namespace Задание__4
{
    class Program
    {
        delegate int MyDelegate();
        delegate double MyDel(MyDelegate[] a);
        static int GetRandom()
        {
            Random random = new();
            int number = random.Next(1, 10);
            Console.WriteLine(number);
            return number;
        }
        static void Main()
        {
            Console.WriteLine("Задание №4\n Создайте анонимный метод, который принимает в качестве аргумента массив делегатов и " +
                "\n возвращает среднее арифметическое возвращаемых значений методов сообщенных с делегатами в массиве. " +
                "\n Методы, сообщенные с делегатами из массива, возвращают случайное значение типа int. \n\nРешение:");

            Console.Write(" Введите число элементов массива: ");
            int n = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine(new string('-', 50));

            var array = new MyDelegate[n];

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = () => new MyDelegate(GetRandom)();
            }

            double d(MyDelegate[] a)
            {
                double sr = 0;
                for (int i = 0; i < a.Length; i++)
                {
                    sr += a[i]();
                }
                return sr / array.Length;
            }

            Console.WriteLine("\n Среднее арифметическое = {0}", d(array));
            
            Console.ReadKey();
        }
    }
}