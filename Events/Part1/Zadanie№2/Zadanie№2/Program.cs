namespace Задание__2
{
    class Program
    {
        public delegate void TriangleDelegate(double side);

        static void Main()
        {
            Console.WriteLine("Задание №2\n Создать 3 метода подсчитывающих периметр, площадь равностороннего треугольника, " +
                "\n и выводящий сторону треугольника . Создать делегат. В программе вызывать все три метода при помощи делегата. " +
                "\n В этой программе создать метод, в котором делегат будет параметром.\n\nРешение:");

            TriangleDelegate triangleDelegate = new(CalculateTriangle);
            triangleDelegate.Invoke(5);
            CallTriangleDelegate(triangleDelegate);
        }
        public static void CalculateTriangle(double side)
        {
            try
            {
                if (side <= 0)
                {
                    throw new ArgumentException(" Длина стороны должна быть положительным");
                }
          
                double triangleSide = side;
                Console.WriteLine($" Длина стороны треугольника: {triangleSide}");

                double perimeter = 3 * side;
                Console.WriteLine($" Периметр: {perimeter}");

                double area = (Math.Sqrt(3) / 4) * Math.Pow(side, 2);
                Console.WriteLine($" Площадь: {area}\n");
            }
            catch (ArgumentException e)
            {
                Console.WriteLine($" Error: {e.Message}");
            }
        }
        public static void CallTriangleDelegate(TriangleDelegate triangleDelegate)
        {
            triangleDelegate.Invoke(7);
        }
    }
}