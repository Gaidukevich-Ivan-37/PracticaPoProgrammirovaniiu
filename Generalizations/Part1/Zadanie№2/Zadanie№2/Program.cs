namespace Задание__2
{
    class MyDictionary<TKey, TValue>
    {
        private List<KeyValuePair<TKey, TValue>> _items = new List<KeyValuePair<TKey, TValue>>();

        public void Add(TKey key, TValue value)
        {
            _items.Add(new KeyValuePair<TKey, TValue>(key, value));
        }

        public TValue this[TKey key]
        {
            get
            {
                foreach (var item in _items)
                {
                    if (item.Key.Equals(key))
                    {
                        return item.Value;
                    }
                }
                throw new KeyNotFoundException();
            }
        }

        public int Count
        {
            get { return _items.Count; }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Задание №2\n Создайте класс MyDictionary <TKey, TValue>. Реализуйте возможность использования его экземпляра " +
                "\n аналогично экземпляру класса Dictionary. \n\nРешение:");

            MyDictionary<string, string> myDictionary = new MyDictionary<string, string>();
            myDictionary.Add("key1", "value1");
            myDictionary.Add("key2", "value2");
            Console.WriteLine(myDictionary["key1"]);
            Console.WriteLine(myDictionary.Count); 
        }
    }
}