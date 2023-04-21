namespace Задание__2
{
    delegate void DelegateCalculator();

    class Program
    {
        static void Main()
        {
            Console.WriteLine("Задание №2\n Создайте четыре лямбда оператора для выполнения арифметических действий: " +
                "\n (Add – сложение, Sub – вычитание, Mul – умножение, Div – деление). \n\nРешение:");

            Console.Write(" Введите действие (+,-,*,/): ");
            string a = Console.ReadLine();

            switch (a)
            {
                case "+":
                    DelegateCalculator calcA = new DelegateCalculator(Add);
                    calcA();

                    break;
                case "-":
                    DelegateCalculator calcS = new DelegateCalculator(Sub);
                    calcS();

                    break;
                case "*":
                    DelegateCalculator calcM = new DelegateCalculator(Mul);
                    calcM();

                    break;
                case "/":
                    DelegateCalculator calcD = new DelegateCalculator(Div);
                    calcD();

                    break;
                default:
                    Console.WriteLine(" Ошибка ввода операции!");
                    break;
            }

            static (int, int) Input()
            {
                Console.Write(" Первое число: ");
                int x = Convert.ToInt32(Console.ReadLine());
                Console.Write(" Второе число: ");
                int y = Convert.ToInt32(Console.ReadLine());
                return (x, y);
            }

            static void Add()
            {
                (int b, int c) = Input();
                Console.WriteLine("\n Ответ:{0}", b + c);
            }

            static void Sub()
            {
                (int b, int c) = Input();
                Console.WriteLine("\n Ответ:{0}", b - c);
            }

            static void Mul()
            {
                (int b, int c) = Input();
                Console.WriteLine("\n Ответ:{0}", b * c);
            }

            static void Div()
            {
                try
                {
                    (int b, int c) = Input();
                    if (c == 0) throw new DivideByZeroException();
                    Console.WriteLine("\n Ответ:{0}", b / c);
                }
                catch
                {
                    Console.WriteLine("\n Деление на ноль!");
                }
            }

            Console.ReadKey();
        }
    }
}