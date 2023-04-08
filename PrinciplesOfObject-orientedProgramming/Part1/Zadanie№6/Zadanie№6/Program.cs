namespace Задание__6
{
    class EvaluateExpression
    {
            static double Func(double x)
            {
                return 2 - Math.Sin(x);
            }
            static void Main()
            {
                Console.WriteLine("Задание №6\n Составить программу вычисления значений\nфункции F(x) " +
                    "на отрезке [A, B] в точках x i =x+H, где H=(B-A)/M, M – заданное\nцелое число.\n\nРешение:");

                double A = Math.PI / 4;
                double B = Math.PI / 2;
                double H = (B - A) / 15;

                for (double i = A; i <= B; i += H)
                    Console.WriteLine("Func({0:0.000}) = {1:0.000}", i, Func(i));
                
                Console.ReadLine();
            }
        }
    }