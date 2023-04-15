using System.Text.RegularExpressions;

namespace Задание__1
{
    class RegularExpressions
    {
        static void Main()
        {
            Console.WriteLine("Задание №1\n Найти в тексте слова с дефисом.\n\nРешение:");

            string s = "Красно-белый друг - без кого либо красно белый tkj-rhfcysq море-красное12 f1jh-gh";

            Regex regex = new Regex(@"(\w*\D\w-\w*\D)");
            MatchCollection matches = regex.Matches(s);

            if (matches.Count > 0)
            {
                foreach (Match match in matches)
                    Console.WriteLine($" {match.Value}");
            }
            else
            {
                Console.WriteLine(" Совпадений не найдено");
            }

            Console.ReadKey();
        }
    }
}