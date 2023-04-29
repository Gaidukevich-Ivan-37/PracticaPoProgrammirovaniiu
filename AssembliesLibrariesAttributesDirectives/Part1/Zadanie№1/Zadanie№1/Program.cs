namespace Задание__1
{
    public class Triangle
    {
        public double SideA { get; set; }
        public double SideB { get; set; }
        public double SideC { get; set; }
        public Triangle(double sideA, double sideB, double sideC)
        {
            SideA = sideA;
            SideB = sideB;
            SideC = sideC;
        }
        public bool IsValid()
        {
            return SideA + SideB > SideC && SideA + SideC > SideB && SideB + SideC > SideA;
        }
        public double Perimeter()
        {
            return SideA + SideB + SideC;
        }
        public double Area()
        {
            double s = (SideA + SideB + SideC) / 2;
            return Math.Sqrt(s * (s - SideA) * (s - SideB) * (s - SideC));
        }
        public string Type()
        {
            if (SideA == SideB && SideB == SideC)
            {
                return "равнобедренный";
            }
            else if (SideA == SideB || SideA == SideC || SideB == SideC)
            {
                return "равносторонний";
            }
            else
            {
                return "разносторонний";
            }
        }
    }
    public class Rectangle
    {
        public double Length { get; set; }
        public double Width { get; set; }
        public Rectangle(double length, double width)
        {
            Length = length;
            Width = width;
        }
        public bool IsValid()
        {
            return Length > 0 && Width > 0;
        }
        public bool IsValid1()
        {
            return Length == Width;
        }
        public double Perimeter()
        {
            return 2 * (Length + Width);
        }
        public double Area()
        {
            return Length * Width;
        }
    }
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Задание №1\n Создать библиотеку с двумя классами: Треугольник (методы ввода сторон, проверки на существование, " +
                "\n вычисления периметра, вычисления площади, определения вида треугольника (разносторонний, равнобедренный, равносторонний)); " +
                "\n Прямоугольник (методы ввода сторон, вычисления периметра, вычисления площади). \n\nРешение:");

            Triangle triangle = new Triangle(3, 4, 5);

            Console.WriteLine(" Треугольник:");
            Console.WriteLine($"  Длина стороны A: {triangle.SideA}");
            Console.WriteLine($"  Длина стороны B: {triangle.SideB}");
            Console.WriteLine($"  Длина стороны C: {triangle.SideC}");

            if (triangle.IsValid())
            {
                Console.WriteLine($"\n  Периметр: {triangle.Perimeter()}");
                Console.WriteLine($"  Площадь: {triangle.Area()}");
                Console.WriteLine($"  Тип: {triangle.Type()}");
            }
            else
            {
                Console.WriteLine("\n Такого треугольника нет");
            }

            Rectangle rectangle = new Rectangle(4, 5);

            Console.WriteLine("\n Прямоугольник:"); ;
            Console.WriteLine($"  Длина: {rectangle.Length}");
            Console.WriteLine($"  Ширина: {rectangle.Width}");

            if (rectangle.IsValid1())
            {
                Console.WriteLine("\n Это не прямоугольник");
            }
            else
            {
                if (rectangle.IsValid())
                {
                    Console.WriteLine($"\n  Периметр: {rectangle.Perimeter()}");
                    Console.WriteLine($"  Площадь: {rectangle.Area()}");
                }
                else
                {
                    Console.WriteLine("\n Такого прямоугольника нет");
                }
            }

            Console.ReadKey();
        }
    }
}