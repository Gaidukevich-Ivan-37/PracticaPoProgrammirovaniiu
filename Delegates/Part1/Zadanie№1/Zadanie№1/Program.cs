namespace Задание__1
{
    class Program
    {
        public delegate double CalcFigure(double R);
        static double Get_Length(double r)
        {
            double D = 2 * Math.PI * r;
            Console.WriteLine("\n Длина окружности = {0}", D);
            return D;
        }
        static double Get_Area(double r)
        {
           double S = Math.PI * Math.Pow(r, 2);
            Console.WriteLine(" Площадь круга = {0}", S);
            return S;
        }
        static double Get_Volume(double r)
        {
            double V = 4 / 3 * Math.PI * Math.Pow(r, 3);
            Console.WriteLine(" Объём шара = {0}", V);
            return V;
        }

        static void Main()
        {
            Console.WriteLine("Задание №1\n Реализовать вызов методов с помощью делегата, которые получают радиус R и вычисляют:" +
                "\n  -длину окружности по формуле D = 2 · π · R;" +
                "\n  -площадь круга по формуле S = π · R^2 ;" +
                "\n  -объём шара. Формула: V = 4/3 * π · R^3. \n\nРешение:");

            Console.Write(" Введите радиус r: ");
            double rad = Convert.ToDouble(Console.ReadLine());
            CalcFigure CF = new CalcFigure(Get_Length);
            CF += Get_Area;
            CF += Get_Volume;
            CF(rad);

            Console.ReadKey();
        }
    }
}