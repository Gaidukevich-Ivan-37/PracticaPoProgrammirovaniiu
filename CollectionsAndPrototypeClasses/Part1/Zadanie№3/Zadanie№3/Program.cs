using System.Collections;
using System.Collections.Generic;

namespace Задание__3
{
    class Theater
    {
        public string n;
        public string f;
        public Theater(string n, string f)
        {
            this.n = n;
            this.f = f;
        }
        virtual public void PrintTheater()
        {
            Console.WriteLine("В" + n + " погода " + f);
        }
    }
    class Films : Theater
    {
        readonly int kol;
        public Films(string n, string f, int kol): base(n, f)
        {
            this.kol = kol;
        }
        override public void PrintTheater()
        {

            Console.WriteLine("В театре " + n + " прокатывается фильм " + f + " с количеством билетов: " + kol);
        }
    }
    class InfoObj
    {
        public static void Info<tip>(tip obj)
            where tip : Theater
        {
            obj.PrintTheater();
        }
    }
    class Th : IEnumerable
    {
        private readonly ArrayList list;
        public Th()
        {
            list = new ArrayList();
        }
        public Th(ArrayList a)
        {
            list = a;
        }
        public void Add(Films m)
        {
            list.Add(m);
        }
        public Th Clone()
        {
            return new Th(list);
        }
        public void RemoveAt(int i)
        {
            list.RemoveAt(i);
        }
        public void Clear()
        {
            list.Clear();
        }
        public IEnumerator GetEnumerator()
        {
            return list.GetEnumerator();
        }
    }
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Задание №3\n Создать класс-прототип, с обобщенным методом, с методами добавления, удаления, клонирования экземпляров класса. " +
                "\n В основной программе продемонстрировать: " +
                "\n  -функциональность созданного класса и всех его методов;" +
                "\n  -использование обнуляемых типов;" +
                "\n  -использование абстрактных структур(List <P> Dictionary <Key,Value>). \n\nРешение:");

            Th TheaterList = new();
            Dictionary <int, string> Name = new(3);
            for (int i = 0; i < 3; i++)
            {
                Console.Write(" Введите название театра: ");
                string n = null;
                n = Console.ReadLine();

                Console.Write(" Введите название фильма: ");
                string f = Console.ReadLine();

                Console.Write(" Введите количество билетов: ");
                int kol = int.Parse(Console.ReadLine());
                TheaterList.Add(new Films(n, f, kol));
                Name[i + 1] = f;
                Console.WriteLine("----------------------------------------------------------");
            }

            foreach (Films x in TheaterList)
            x.PrintTheater();
            TheaterList.RemoveAt(1);

            Console.WriteLine("----------------------------------------------------------");
            Th cl = (Th)TheaterList.Clone();
            foreach (Films x in cl) x.PrintTheater();
            Console.ReadLine();
        }
    }
}