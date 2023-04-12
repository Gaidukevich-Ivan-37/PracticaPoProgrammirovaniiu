namespace Задание__3
{
    class A234
    {
        static void PowerA234(double A, out double B, out double C, out double D)
        {
            B = Math.Pow(A,2);
            C = Math.Pow(A, 3);
            D = Math.Pow(A, 4);
        }
        static void Main()
        {
            Console.WriteLine("Задание №3\n писать метод PowerA234(A, B, C, D), вычисляющий вторую," +
                    "\nтретью и четвертую степень числа A и возвращающую эти степени соответственно в переменных B," +
                    "\nC и D(A — входной, B, C, D — выходные параметры; все параметры являются вещественными)." +
                    "\nС помощью этого метода найти вторую, третью и четвертую степень пяти данных чисел.\n\nРешение:");

            for (int i = 2; i < 7; i++)
            {
                PowerA234(i, out double b, out double c, out double d);
                Console.WriteLine($" {b}");
            }
        }
    }
}