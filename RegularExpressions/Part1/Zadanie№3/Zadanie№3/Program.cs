using System.Text.RegularExpressions;

namespace Задание__3
{
    class RegularExpressions
    {
        static void Main()
        {
            Console.WriteLine("Задание №3\n Задан текст. Определить, содержит ли он цифры.\n\nРешение:");

            Console.WriteLine((Regex.IsMatch("Hello, W0rld!", @"\d")) ? " Содержит" : " Неа");

            Console.ReadKey();
        }
    }
}