namespace Задание__1
{
    // Контекст определяет интерфейс, представляющий интерес для клиентов.
    class Context
    {
        private IStrategy _strategy;
        public Context()
        { }
        public Context(IStrategy strategy)
        {
            this._strategy = strategy;
        }
        public void SetStrategy(IStrategy strategy)
        {
            this._strategy = strategy;
        }

        // Контекст делегирует некоторую работу объекту Стратегии.
        public void DoSomeBusinessLogic()
        {
            var result = this._strategy.DoAlgorithm(new List<string> { "a", "b", "c", "d", "e" });

            string resultStr = string.Empty;
            foreach (var element in result as List<string>)
            {
                resultStr += element + ",";
            }

            Console.WriteLine(resultStr);
        }
    }
    public interface IStrategy
    {
        object DoAlgorithm(object data);
    }

    // Конкретные стратегии реализуют алгоритм, следуя базовому интерфейсу стратегии. Этот интерфейс делает их взаимозаменяемыми в контексте.
    class ConcreteStrategyA : IStrategy
    {
        public object DoAlgorithm(object data)
        {
            var list = data as List<string>;
            list.Sort();

            return list;
        }
    }

    class ConcreteStrategyB : IStrategy
    {
        public object DoAlgorithm(object data)
        {
            var list = data as List<string>;
            list.Sort();
            list.Reverse();

            return list;
        }
    }
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Задание №1\n Реализовать паттерн стратегия \n\nРешение:");

            var context = new Context();

            Console.Write(" Клиент: cтратегия настроена на нормальную сортировку: ");
            context.SetStrategy(new ConcreteStrategyA());
            context.DoSomeBusinessLogic();

            Console.WriteLine();

            Console.Write(" Клиент: cтратегия настроена на обратную сортировку: ");
            context.SetStrategy(new ConcreteStrategyB());
            context.DoSomeBusinessLogic();
        }
    }
}