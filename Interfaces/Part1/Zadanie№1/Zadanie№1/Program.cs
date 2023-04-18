namespace Задание__1
{
    interface Ix
    {
        void IxF0(double xKey);
        void IxF1();
    }
    interface Iy
    {
        void F0(double xKey);
        void F1();
    }
    interface Iz
    {
        void F0(double xKey);
        void F1();
    }
    class TestClass : Ix, Iy, Iz
    {
        public double xVal;
        public TestClass()
        {
            xVal = 125;
        }
        public TestClass(double key)
        {
            xVal = key;
        }
        public void IxF0(double key)
        {
            xVal = Math.Cos(key); Console.WriteLine(" IxF0({0})...", xVal);
        }
        public void IxF1()
        {
            xVal = Math.Cos(xVal);
            Console.WriteLine(" IxF1({0})...", xVal);
        }
        public void F0(double xKey)
        {
            xVal = Math.Exp(xVal);
            Console.WriteLine(" (Exp(Iy))F0({0})...", xVal);
        }
        public void F1()
        {
            xVal = Math.Exp(xVal);
            Console.WriteLine(" (Exp(Iy))F1({0})...", xVal);
        }
        void Iz.F0(double xKey)
        {
            xVal = 1/Math.Exp(xKey);
            Console.WriteLine(" Iz.F0({0})...", xVal);
        }
        void Iz.F1()
        {
            xVal = 1 / Math.Exp(xVal);
            Console.WriteLine(" Iz.F1({0})...", xVal);
        }
        public void bF0()

        {
            Console.WriteLine(" bF0()...");
        }
        class Interfaces
        {
            static void Main()
            {
                Console.WriteLine("Задание №1\n Параметр (double).\n IxF0, IxF1 возвращают (Cos(w))." +
                    "\n F0 F1 возвращают:\n  -неявная реализация (Exp(w)),\n  -явная реализация Iz (1/Exp(w))." +
                    "\n\nРешение:");

                TestClass x0 = new TestClass();
                TestClass x1 = new TestClass(5);
                x0.bF0();

                x0.IxF0(10);
                x1.IxF1();

                x0.F0(5);
                x1.F1();

                (x0 as Iy).F0(7);
                (x1 as Iz).F1();

                Console.WriteLine(" ==========Prism test==========");
                Console.WriteLine(" ==========Ix==========");
                Ix ix = x1;
                ix.IxF0(5);
                ix.IxF1();

                Console.WriteLine(" ==========Iy==========");
                Iy iy = x1;
                iy.F0(5);
                iy.F1();

                Console.WriteLine(" ==========Iz==========");
                Iz iz = x1;
                iz.F0(5);
                iz.F1();

                Console.ReadKey();
            }
        }
    }
}