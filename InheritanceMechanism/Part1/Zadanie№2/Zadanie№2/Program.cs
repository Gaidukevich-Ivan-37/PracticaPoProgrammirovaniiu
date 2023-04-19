namespace Задание__2
{
    class A
    {
        private double a;
        private double b;
        private double c;
        private double c1;
        public A()
        {
            a = 0;
            b = 0;
            c = 0;
            c1 = 0;
            Input();
        }
        public virtual void IncomePay()
        {
            c = a + b;
        }
        public double A1 { get { return a; } set { a = value; } }
        public double B1 { get { return b; } set { b = value; } }
        public double C1 { get { return c; } set { c = value; } }
        public double C2 { get { return c1; } set { c1 = value; } }
        public void Input()
        {
            Console.Write(" Введите число a: ", a);
            a = Convert.ToDouble(Console.ReadLine());
            Console.Write(" Введите число b: ", b);
            b = Convert.ToDouble(Console.ReadLine());
        }
        class B : A
        {
            double d;
            public B() : base()
            {
                d = 0;
                Input();
            }
            public new void Input()
            {
                Console.Write(" Введите число d: ");
                d = Convert.ToInt32(Console.ReadLine());
            }
            public override void IncomePay()
            {
                C1 = A1 + B1;
                C2 = A1 + B1 + d;
            }

            public void GetInfo()
            {
                if (C1 == C2)
                    Console.WriteLine("\n С1 = С2");
                else
                {
                    Console.WriteLine("\n a + b = {0}", C1);
                    Console.WriteLine(" a + b + d = {0}", C2);
                }
            }
        }
        class Program
        {
            static void Main()
            {
                Console.WriteLine("Задание №2\n В рамках консольного приложения разработать класс " +
                    "\n В-наследник класса А(класс А с полями а и b и свойством с. " +
                    "\n Свойство – значение выражения над полями а и b(выражение и типы полей – см. вариант в таблице 1). " +
                    "\n Поля инициализировать при объявлении класса. Конструктор оставить по умолчанию. " +
                    "\n Проследить, чтобы поля а и b напрямую в других классах были недоступны.) с полем d и свойством с2." +
                    "\n\nРешение:");

                B b1 = new();
                b1.IncomePay();
                b1.GetInfo();

                Console.ReadKey();
            }
        }
    } 
}