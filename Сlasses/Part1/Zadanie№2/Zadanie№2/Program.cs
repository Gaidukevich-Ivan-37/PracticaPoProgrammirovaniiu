namespace Задание__2
{
    class Print
    {
        protected int page = 0;
        public void SetPage(int page)
        {
            if (page > 0 && page < 500)
            {
                this.page = page;
            }
            else
                this.page = 0;
        }
        public int GetAge()
        {
            return page;
        }

        protected string name = "";
        public void SetName(string name)
        {
            this.name = name;
        }
        public string GetName()
        {
            return name;
        }
    }
    class Magazine : Print
    {
        protected int Price = 0;

        public void SetPrice(int price)
        {
            if (price > 0 && price < 200)
            {
                this.Price = price;
            }
            else
                this.Price = 0;
        }
        public int GetPrice()
        {
            return Price;
        }

        class Book : Print
        {
            protected int year = 0;
            public void SetYear(int year)
            {
                if (1990 > 0 && year < 2012)
                    this.year = year;
                else
                    this.year = 0;
            }
            public int GetYear()
            {
                return year;
            }
            internal void SetPrice(int p)
            {
                throw new NotImplementedException();
            }
        }
        class Textbook : Book
        {
            protected int kolvo_statej = 0;
            public void SetStatya(int kolvo_statej)
            {
                this.kolvo_statej = kolvo_statej;
            }
            public int GetStatya()
            {
                return kolvo_statej;
            }
        }
        class Test
        {
            static void Main()
            {
                Console.WriteLine("Задание №2\n Построить иерархию классов: журнал, книга, печатное издание," +
                    " учебник.\n\nРешение:");

                Print print = new Print();
                Magazine magazine = new Magazine();
                Book book = new Book();
                Textbook textbook = new Textbook();

                Console.Write(" Введите возможное кол-во страниц печатного издания: ");
                print.SetPage(Convert.ToInt32(Console.ReadLine()));

                Console.Write(" Введите имя печатного издания: ");
                print.SetName(Convert.ToString(Console.ReadLine()));

                Console.Write(" Введите кол-во страниц журнала: ");
                magazine.SetPage(Convert.ToInt32(Console.ReadLine()));

                Console.Write(" Введите название журнала: ");
                magazine.SetName(Convert.ToString(Console.ReadLine()));

                Console.Write(" Введите цену журнала: ");
                magazine.SetPrice(Convert.ToInt32(Console.ReadLine()));

                Console.Write(" Введите кол-во страниц учебника: ");
                textbook.SetPage(Convert.ToInt32(Console.ReadLine()));

                Console.Write(" Введите название учебника: ");
                textbook.SetName(Convert.ToString(Console.ReadLine()));
            }
        }
    }
}