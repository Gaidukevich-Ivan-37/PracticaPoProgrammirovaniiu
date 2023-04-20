namespace Задание__1
{
    class Building
    {
        public string? name;
        public Building()
        {
            name = null;
        }
        public virtual void Inputof()
        {
            Console.Write("\n Введите название офиса: ");
            name = Console.ReadLine();
        }
        public virtual void Inputfa()
        {
            Console.Write("\n Введите название завода: ");
            name = Console.ReadLine();
        }

        public virtual void GetInfo() 
        {
            Console.WriteLine(" Название: {0}", name);
        }
    }
    class Office : Building
    {
        public int N;
        public double o;
        public Office()
        {
            N = 0;
            Inputof();
        }
        public override void Inputof()
        {
            base.Inputof();
            Console.Write(" Введите количество этажей: ");
            N = Convert.ToInt16(Console.ReadLine());
        }
        public virtual void CostPlane()
        {
            o = 0.05 * N;
        }
        public override void GetInfo()
        {
            CostPlane();
            Console.WriteLine("\n Название офиса: {0} \n Количество этажей: {1} \n Высота фундамента офиса: {2}", name, N, o);
        }
    }
    class Factory : Building
    {
        public int G;
        public double f;
        public Factory()
        {
            G = 0;
            Inputfa();
        }
        public override void Inputfa()
        {
            base.Inputfa();
            Console.Write(" Введите вес завода: ");
            G = Convert.ToInt16(Console.ReadLine());
        }
        public virtual void CostShip()
        {
            f = 0.000002 * G;
        }
        public override void GetInfo()
        {
            CostShip();
            Console.WriteLine("\n Название завода: {0} \n Вес: {1} \n Высота фундамента завода: {2}", name, G, f);
        }
    }  
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Задание №1\n Составить программу с одним родительским классом и двумя потомками. " +
                "\n Потомки должны содержать виртуальные функции. Создать виртуальную функцию выдачи результатов расчета методов на экран монитора " +
                "\n с указанием названий и полей, и их значений соответствующего объекта. Составить тестирующую программу с выдачей протокола " +
                "\n монитора. При этом создать объекты базового и производных типов, используя полиморфный контейнер - массив ссылок базового класса " +
                "\n на объекты базового и производных классов (количество объектов >= 5). " +
                "\n Родительский класс: населённый пункт (поле название). Потомки: офис (поле - количество этажей N), завод (поле - вес G). \n\nРешение:");

            int kol = 5;
            Building[] building = new Building[kol];

            Console.WriteLine(" Выберите создаваемый объект: ");
            Console.WriteLine(" 1.Офис\n 2.Завод");
            Console.Write("\n Ввести цифру: ");
            int change = Convert.ToInt32(Console.ReadLine());

            int i = 0;
            double ho = 0;
            double hf = 0;

            while (i < kol)
            {
                switch (change)
                {
                    case 1:
                        Office office = new();
                        office.CostPlane();
                        ho += office.o;
                        building[i] = office; ++i ; break;
                    case 2:
                        Factory factory = new();
                        factory.CostShip();
                        hf += factory.f;
                        building[i] = factory; ++i ; break;
                    default: 
                        Console.WriteLine("Нет такого пункта!"); ++i; break;
                }
            }

            for (int t = 0; t < building.Length; t++)
            {
                building[t]?.GetInfo();
            }

            Console.ReadKey();
        }
    }
}