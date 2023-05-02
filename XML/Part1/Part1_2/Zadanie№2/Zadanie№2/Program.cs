namespace Задание__2
{
    //Создание интерфейса
    public interface IArOperation
    {
        string Name();
        string Year();
        string Telefon();
        string Number();
    }
    
    //Создание значений
    class A : IArOperation
    {
        private readonly string n;
        private readonly string y;
        private readonly string t;
        private readonly string num;
    
        public A(string n, string y, string t, string num)
        {
            this.n = n;
            this.y = y;
            this.t = t;
            this.num = num;
        }
        public virtual string Name()
        {
            return n;
        }
        public string Year()
        {
            return y;
        }
        public string Telefon()
        {
            return t;
        }
        public string Number()
        {
            return num;
        }
        public virtual void Rewrite()
        {
            Console.Write("Имя: {0}\tДата рождения: {1}\tНомер телефона: {2}\tНомер страницы: {3}", n, y, t, num);
        }
    }
    class Program
    {
        static void Main()
        {
            Console.WriteLine("\tobj1: ");
            A obj1 = new(n: "Ваня", y: "12.02.2003", t: "54-57-691", num: "1");       
            obj1.Rewrite();
            
            Console.WriteLine("\n\tobj2: ");
            A obj2 = new(n: "Коля", y: "06.12.2005", t: "67-32-123", num: "2");
            obj2.Rewrite();

            Console.ReadLine();
        }
    }
}