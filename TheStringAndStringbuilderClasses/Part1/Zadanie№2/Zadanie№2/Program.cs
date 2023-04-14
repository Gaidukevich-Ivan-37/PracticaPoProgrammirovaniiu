namespace Задание__2
{
    class SearchForUppercaseCharacters
    {
        static void Main()
        {
            Console.WriteLine("Задание №2\n Исключите из строки все заглавные символы.\n\nРешение:");

            string s = " Задание №2. Исключите из строки все заглавные символы. Решение:";
            Console.WriteLine(s);

            s = new string(s.Where(x => !char.IsUpper(x)).ToArray());
            Console.WriteLine(s);

            Console.ReadKey();
        }
    }
}