namespace Задание__2
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Задание №2\n Решить следующие задачи с использованием класса Queue. " +
                "\n Дан текстовый файл. За один просмотр файла напечатать элементы файла в следующем порядке: сначала все символы, отличные от цифр, " +
                "\n а затем все цифры, сохраняя исходный порядок в каждой группе символов. \n\nРешение:");

            Queue<char> characters = new Queue<char>();
            Queue<char> digits = new Queue<char>();

            string filePath = "D:\\Практика по программированию\\CollectionsAndPrototypeClasses\\Part1\\Zadanie№2\\file.txt";
            string fileContent = File.ReadAllText(filePath);

            foreach (char c in fileContent)
            {
                if (Char.IsDigit(c))
                {
                    digits.Enqueue(c);
                }
                else
                {
                    characters.Enqueue(c);
                }
            }

            while (characters.Count > 0)
            {
                Console.Write(characters.Dequeue());
            }

            while (digits.Count > 0)
            {
                Console.Write(digits.Dequeue());
            }
        }
    }
}