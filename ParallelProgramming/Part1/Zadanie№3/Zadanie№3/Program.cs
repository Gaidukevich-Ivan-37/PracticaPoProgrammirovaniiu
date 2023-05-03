namespace Задание__3
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Задание №3\n Создайте два объекта класса Task. Первый объект возвращает результат вычисления, " +
                "\n второй объект является задачей продолжения первого объекта и выводит результат первой задачи на консоль. " +
                "\n Задания для реализации метода выполняемого в первом объекте класса Task: дано четырехзначное число. Найти произведение его цифр. " +
                "\n\nРешение:");

            // Создание первой задачи на вычисление произведения цифр двузначного числа
            Task<int> task1 = Task.Run(() =>
            {
                Console.Write(" Создать двузначное число: ");
                int num = Convert.ToInt16(Console.ReadLine());
                int product = 1;

                while (num > 0)
                {
                    int digit = num % 10;
                    product *= digit;
                    num /= 10;
                }
                return product;
            }); 

            // Создание второй задачи, для вывода результата первой задачи.
            Task task2 = task1.ContinueWith((antecedent) =>
            {
                Console.WriteLine($"\n Произведение цифр двузначного числа: {antecedent.Result}");
            });

            task2.Wait();

            Console.ReadKey();
        }
    }
}