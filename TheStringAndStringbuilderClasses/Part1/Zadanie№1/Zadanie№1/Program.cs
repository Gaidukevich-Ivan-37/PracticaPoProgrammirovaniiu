using System.Text.RegularExpressions;

namespace Задание__1
{
    class FindingNumbers
    {
        static void Main()
        {
            Console.WriteLine("Задание №1\n Вывести только те слова сообщения, которые содержат хотя бы " +
                "\n одну цифру.\n\nРешение:");

            string str = "Кра1сно-белый, 1др.уг2 4 1без кого2 5 ли3бо 3 1кр11асно1 белый tkj-rhfcysq море-красное12 1 f1jh-gh 12";
            Console.WriteLine($" {str}\n");

            Regex regex = new(@"(\D\S*\d\S*\D)");
            MatchCollection matches = regex.Matches(str);

            if (matches.Count > 0)
            {
                foreach (Match match in matches.Cast<Match>())       
                    Console.Write($" {match.Value}");
            }
            else
                Console.WriteLine("\n Совпадений не найдено");

            Console.ReadKey();
        }
    }
}