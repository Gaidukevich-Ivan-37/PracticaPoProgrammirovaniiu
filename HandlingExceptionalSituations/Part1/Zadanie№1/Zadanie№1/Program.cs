namespace Задание__1
{
    class DivideByZeroExceptionAndFormatException
    {
        static void Main()
        {
            Console.WriteLine("Задание №1\n Вычислить значение выражений. " +
                "\nВ каждой разработанной программе должна быть осуществлена обработка исключительных ситуаций." +
                "\nОтдельно обработаны исключения DivideByZeroException, FormatException.\n\nРешение:");
            
            Console.Write(" Введите значение x: ");
            double x = Convert.ToInt16(Console.ReadLine());
            try
            {
                double y1;

                if (x == -12) throw new DivideByZeroException();
                y1 = (Math.Tan(x - 2)) / (x + 12) + (Math.Pow(Math.Cos(x / 2), 2));
                Console.WriteLine("\n 1) y1 = (tg(x - 2)) / (x + 12) + cos^2(x / 2)= {0}", y1);
            }

            catch
            {
                Console.WriteLine("\n 1) Деление на ноль!");
            }

            try
            {
                double y2;

                if (x < 0) throw new FormatException();
                y2 = Math.Log10(x) - (Math.Atan(Math.Pow(x, 3))) / ((2 * x + 6));
                Console.WriteLine(" 2) y2 = (1 - tg(a)) / (1 + tg(a)) = {0}\n", y2);
            }

            catch 
            {
                Console.WriteLine(" 2) Аргумент ln не может быть меньше или равен нулю!");

            }

            Console.ReadLine();
        }
    }
}