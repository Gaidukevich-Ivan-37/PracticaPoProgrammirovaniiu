namespace Задание__2
{
    class RegularExpressions
    {
        static void Main()
        {
            Console.WriteLine("Задание №2\n Задан текст. Найти в тексте слова содержащие две подряд идущие" +
                "\n одинаковые буквы.\n\nРешение:");

            int counter = 0;
            string buf = string.Empty;
            char[] s = "Русская Википедия — русскоязычный раздел Википедии, основанный 11 мая 2001 года.".ToCharArray();

            foreach (char elem in s)
            {
                if (Char.IsLetter(elem))
                {
                    if (elem == 'с') 
                        counter++;
                    buf += elem.ToString();
                }
                else
                {
                    if (counter >= 2)
                    {
                        Console.WriteLine($" { buf}");
                    }

                    buf = string.Empty;
                    counter = 0;
                }
            }

            Console.ReadKey();
        }
    }
}