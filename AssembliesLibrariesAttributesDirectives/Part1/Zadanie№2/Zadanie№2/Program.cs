namespace Задание__2
{
    public abstract class CarPark
    {
        public abstract void Opisanie();
        public abstract void Sr();
        public class Car : CarPark
        {
            public Car(string name, string color, int kol, string type)
            {
                this.name = name;
                this.color = color;
                this.kol = kol;
                this.type = type;
            }

            public string name;
            public string color;
            public int kol;
            public string type;
            public override void Opisanie()
            {
                Console.WriteLine(" Название: {0} \n Цвет: {1} \n Количество: {2} \n Тип: {3}", name, color, kol, type);
            }
            public override void Sr()
            {
                if (kol == 0) Console.WriteLine("  Машин нет\n");
                else Console.WriteLine("  Машины есть\n");
            }
        }
    }
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Задание №2\n Создать свою библиотеку на тему автопарк и продемонстрировать ее функциональность. \n\nРешение:");

            const int n = 4;
            CarPark[] carpark = new CarPark[n];
            carpark[0] = new CarPark.Car("acura", "red", 15, "автомобиль");
            carpark[1] = new CarPark.Car("alfa romeo", "black", 5, "автомобиль");
            carpark[2] = new CarPark.Car("audi", "blue", 0, "автомобиль");
            carpark[3] = new CarPark.Car("bentley", "yellow", 10, "автомобиль");

            foreach (CarPark elem in carpark)
            {
                elem.Opisanie();
                elem.Sr();
            }

            Console.ReadKey();
        }
    }
}