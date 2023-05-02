using System.Text;

namespace Задание__1
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Задание №1\n Компонентами файла g являются натуральные числа. Найти количество четных чисел среди компонент. \n\nРешение:");

            string path = @"f.txt";

            //Проверка исключений массива
            try
            {
                using (FileStream fs = File.Create(path))
                {
                    byte[] info = new UTF8Encoding(true).GetBytes(" -5 -4 -3 -2 -1 0 1 2 3 4 5");
                    fs.Write(info, 0, info.Length);
                }

                using StreamReader sr = File.OpenText(path);
                string s = " ";
                while ((s = sr.ReadLine()) != null)
                {
                    Console.WriteLine(s);
                }
            }
            //Обработка исключений массива
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }

            //Прочитать файл и вывести из него нужные символы
            int[] mas = File.ReadAllText("f.txt").
                Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToList().
                ConvertAll(new Converter<string, int>(delegate (string s) { return Convert.ToInt32(s); })).
                FindAll(g => (g % 2 == 0)).ToArray();
            Console.Write("\n Чётные числа:");
            mas.ToList().ForEach(g => Console.Write($" {g}"));
            
            Console.ReadKey();
        }
    }
}