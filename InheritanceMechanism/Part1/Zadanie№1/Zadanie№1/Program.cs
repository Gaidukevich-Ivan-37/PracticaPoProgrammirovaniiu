namespace Задание__1
{
    class Notebook
    {
        private string? name;
        private double k;
        private double income;
        public Notebook()
        {
            name = null;
            k = 0;
            income = 0;
            Input();
        }
        public virtual void IncomePay()
        {
            income = 15 * k;
        }
        public string Name { get { return name; } set { name = value; } }
        public double K { get { return k; } set { k = value; } }
        public double Income { get { return income; } set { income = value; } }
        public void Input()
        {
            Console.Write(" Введите название тетради: ", name);
            name = Console.ReadLine();

            Console.Write(" Введите количество страниц: ", k);
            k = Convert.ToDouble(Console.ReadLine());
        }
    }
    class General : Notebook
    {
        int n;
        public General() : base()
        {
            n = 0;
            Input();
        }
        public new void Input()
        {
            Console.Write(" Введите количество материала обложки: ");
            n = Convert.ToInt32(Console.ReadLine());
        }
        public override void IncomePay() 
        {
            Income = 15 * K * n + 50;
        }
        public void GetInfo() 
        {
            Console.WriteLine("\n Название: {0} \n Количество страниц: {1} \n Материала обложки: {2} " +
                "\n\n Доход: {3} ", Name, K, n, Income);
        }
    }
    class Program 
    { 
        static void Main()
        {
            Console.WriteLine("Задание №1\n Базовый класс: Тетрадь (поле: название, количество листов –k). " +
                "Метод: Стоимость: 15 * k. Потомок: Общая (поле – материал обложки). Изменения в потомках: " +
                "Изменить стоимость с учетом надбавки за обложку на 50р.\n\nРешение:");

            General general = new();
            general.IncomePay();
            general.GetInfo();
            
            Console.ReadKey();
        }
    }
}