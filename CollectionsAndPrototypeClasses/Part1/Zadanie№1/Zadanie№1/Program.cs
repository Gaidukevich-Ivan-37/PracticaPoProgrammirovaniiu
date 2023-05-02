namespace Задание__1
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Задание №1\n Решить задачи с использованием класса Stack. " +
                "\n Пусть символ # определен в текстовом редакторе как стирающий символ Backspace, т.е. строка abc#d##c в действительности является строкой ac. " +
                "\n Дан текст, в котором встречается символ #. Преобразовать его с учетом действия этого символа. \n\nРешение:");

            string text = "abc#d##c";
            Console.WriteLine($"Первоначальный текст: {text}");

            string result = RemoveBackspaces(text);
            Console.WriteLine($"Изменённый текст: {result}");
        }
        static string RemoveBackspaces(string text)
        {
            Stack<char> stack = new Stack<char>();
            foreach (char c in text)
            {
                if (c == '#')
                {
                    if (stack.Count > 0)
                    {
                        stack.Pop();
                    }
                }
                else
                {
                    stack.Push(c);
                }
            }

            char[] chars = stack.ToArray();
            Array.Reverse(chars);
            return new string(chars);
        }
    }
}