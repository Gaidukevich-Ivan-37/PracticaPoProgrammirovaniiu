namespace Задание__1
{
    class Program
    {
        delegate void TriangleDelegate();

        static void Main()
        {
            Console.WriteLine("Задание №1\n Создать 3 метода подсчитывающих периметр, площадь равностороннего треугольника, " +
                "\n и выводящий сторону треугольника . Создать делегат. В программе вызывать все три метода при помощи делегата. \n\nРешение:");

            TriangleDelegate triangleDelegate = new(CalculateTriangle);
            triangleDelegate();
        }
        static void CalculateTriangle()
        {
            try
            {
                Console.Write(" Введите длину стороны треугольника: ");
                double side = Convert.ToInt16(Console.ReadLine());
 
                double triangleSide = side;
                Console.WriteLine($"\n Длина стороны: {triangleSide}");

                double perimeter = 3 * side;
                Console.WriteLine($" Периметр: {perimeter}");

                double area = (Math.Sqrt(3) / 4) * Math.Pow(side, 2);
                Console.WriteLine($" Площадь: {area}");
            }
            catch (FormatException e)
            {
                Console.WriteLine($"\n Error: {e.Message}");
            }
        }
    }
}