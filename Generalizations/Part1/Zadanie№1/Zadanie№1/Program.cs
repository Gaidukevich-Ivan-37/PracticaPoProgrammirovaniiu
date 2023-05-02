namespace Задание__1
{
    class MyList<T>
    {
        private List<T> items;
        public MyList()
        {
            items = new List<T>();
        }
        public void Add(T item)
        {
            items.Add(item);
        }
        public T this[int index]
        {
            get {return items[index];}
            set {items[index] = value;}
        }
        public int Count
        {
            get {return items.Count;}
        }
    }
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Задание №1\n Создайте класс MyList<T>. Реализуйте возможность использования его экземпляра " +
                "\n аналогично экземпляру класса List<T>. \n\nРешение:");

            MyList<int> myList = new MyList<int>();

            myList.Add(1);
            myList.Add(2);
            myList.Add(3);
            
            int i = 2;
            int item = myList[i];
            int count = myList.Count;

            Console.WriteLine($" Пункт с индексом {i}: {item}");
            Console.WriteLine($" Всего элементов в списке: {count}");
        }
    }
}