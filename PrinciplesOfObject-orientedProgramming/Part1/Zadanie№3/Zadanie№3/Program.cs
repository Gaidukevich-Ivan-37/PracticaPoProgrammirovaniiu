namespace Задание__3
{
    class EasternСalendar
    {
        static void Main()
        {
            Console.WriteLine("Задание №3\n Составить программу. Дан год. Вывести на экран название животного," +
                "\nсимволизирующего заданный год по восточному календарю.\n\nРешение:");

            Console.Write(" Введите год: ");
            int year = Convert.ToInt16(Console.ReadLine());

            if (year < 1948 || year > 2031)
            {
                Console.WriteLine("\n Вы ошиблись");
            }
            else
            {
                year %= 12;
                year += 1;
                switch (year)
                {
                    case 1: Console.WriteLine("\n Обезьяна"); break;
                    case 2: Console.WriteLine("\n Петух"); break;
                    case 3: Console.WriteLine("\n Собака"); break;
                    case 4: Console.WriteLine("\n Свинья"); break;
                    case 5: Console.WriteLine("\n Крыса"); break;
                    case 6: Console.WriteLine("\n Бык"); break;
                    case 7: Console.WriteLine("\n Тигр"); break;
                    case 8: Console.WriteLine("\n Кролик"); break;
                    case 9: Console.WriteLine("\n Дракон"); break;
                    case 10: Console.WriteLine("\n Змея"); break;
                    case 11: Console.WriteLine("\n Лошадь"); break;
                    case 12: Console.WriteLine("\n Коза"); break;
                }
            }
            Console.ReadKey();
        }
    }
}