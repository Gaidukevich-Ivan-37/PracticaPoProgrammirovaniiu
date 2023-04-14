using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Задание__4
{
    class SurnameNamePatronymic
    {
        static void Main()
        {
            Console.WriteLine("Задание №4\n Известны фамилия, имя и отчество пользователя. Найти его код личности. " +
                "\n Правило получения кода личности: каждой букве ставится в соответствие число - порядковый " +
                "\n номер буквы в алфавите. Эти числа складываются. " +
                "\n Если полученная сумма не является однозначным числом, то цифры числа снова складываются и " +
                "\n так до тех пор, пока не будет получено однозначное число.\n\nРешение:");

            const string ABC = "*АБВГДЕЁЖЗИЙКЛМНОПРСТУФХЦЧШЩЪЫЬЭЮЯ";
            const string NUM = "0123456789";

            Console.Write(" Ф.И.О.: ");

            string c2 = Console.ReadLine();
            var strHash = Hash(Regex.Replace(c2.ToUpper(), @"[^А-Я]", ""), ABC);
            do
            {
                strHash = Hash(strHash, NUM);
            } 
            while (strHash.Length > 1);
            Console.WriteLine("\n Код личности: {0}",strHash);

            Console.ReadKey();
        }

        static string Hash(string str, string ABC)
        {
            return str.Select(ch => ABC.IndexOf(ch))
            .Aggregate(0, (acc, charValue) => acc + charValue)
            .ToString();
        }
    }
}