namespace Задание__1
{
    class A
    {
        public double a;
        public double b;

        public A(double a, double b)
        {
            this.a = a;
            this.b = b;
        }

        public void Print()
        {
            Console.WriteLine("Задание №1\n Метод вычисления разности a и b, метод вычисления значения" +
                "\nвыражения (a + b) / (a - b)\n\nРешение:");
            
            Console.Write(" Введите значение a: {0}", a);
            Console.Write("\n Введите значение b: {0}\n", b);

            try
            {
                double y;

                if (a == b) throw new DivideByZeroException();
                Console.WriteLine("\n (a + b) / (a - b)) = {0}", y = (a + b) / (a - b));
            }
            catch
            {
                Console.WriteLine("\n Деление на ноль!");
            }

            Console.ReadKey();
        }
    }
    class Program
    {
        static void Main()
        {
            A a = new A(1, 1);
            a.Print();
        }
    }
}