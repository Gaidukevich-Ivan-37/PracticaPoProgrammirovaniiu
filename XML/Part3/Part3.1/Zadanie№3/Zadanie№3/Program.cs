namespace Задание__3
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Задание №3\n Создать текстовый файл, в который записать 5 строк различной длины. " +
                "\n Для данного файла выполнить следующие действия:" +
                "\n  a) вывести весь файл на экран;" +
                "\n  b) подсчитать количество строк;" +
                "\n  c) подсчитать количество символов в каждой строке;" +
                "\n  d) удалить последнюю строку из файла, результат записать в новый файл;" +
                "\n  e) вывести на экран строки с s1 по s2;" +
                "\n  f) найти длину самой длинной строки и вывести ее на экран;" +
                "\n  g) вывести на экран все строки начинающиеся с заданной буквы;" +
                "\n  h) переписать его строки в другой файл, порядок строк во втором файле должен быть обратным по отношению " +
                "\n   к порядку строк в заданном файле. \n\nРешение:");

            //Создание и запись файла
            string filePath = "file.txt";
            using (StreamWriter writer = new(filePath))
            {
                writer.WriteLine("  Какой");
                writer.WriteLine("  сегодня");
                writer.WriteLine("  хороший");
                writer.WriteLine("  день");
                writer.WriteLine("  .");
            }

            //Вывод символов из файла
            using StreamReader reader = new(filePath);
            Console.WriteLine(" a) Вывести весь файл на экран");
            Console.Write(reader.ReadToEnd());
            Console.WriteLine("---------------------------------------------------------------------------");

            //Подсчёт строк символов в файле
            Console.WriteLine(" b) Подсчитать количество строк");
            reader.DiscardBufferedData();
            reader.BaseStream.Seek(0, SeekOrigin.Begin);
            int lineCount = File.ReadLines(filePath).Count();
            Console.WriteLine($"  Коичество строк: {lineCount}");
            Console.WriteLine("---------------------------------------------------------------------------");

            //Подсчёт символов в файле
            Console.WriteLine(" c) Подсчитать количество символов в каждой строке");
            reader.DiscardBufferedData();
            reader.BaseStream.Seek(0, SeekOrigin.Begin);
            string line;
            int num = 1;
            while ((line = reader.ReadLine()) != null)
            {
                Console.WriteLine($"  Строка {num++}: {line.Length - 2} символов");
            }
            Console.WriteLine("---------------------------------------------------------------------------");

            //Удаление последней строки символов
            Console.WriteLine(" d) Удалить последнюю строку из файла, результат записать в новый файл");
            reader.DiscardBufferedData();
            reader.BaseStream.Seek(0, SeekOrigin.Begin);
            string[] lines = File.ReadAllLines(filePath);
            string[] newLines = lines.Take(lines.Length - 1).ToArray();
            File.WriteAllLines("newFile.txt", newLines);
            Console.WriteLine("---------------------------------------------------------------------------");

            //Вывод строк символов из файла по [s1,s2] 
            Console.WriteLine(" e) Вывести на экран строки с s1 по s2");
            reader.DiscardBufferedData();
            reader.BaseStream.Seek(0, SeekOrigin.Begin);
            int s1 = 2;
            int s2 = 4;
            lineCount = 1;
            while ((line = reader.ReadLine()) != null)
            {
                if (lineCount >= s1 && lineCount <= s2)
                {
                    Console.WriteLine(line);
                }
                lineCount++;
            }
            Console.WriteLine("---------------------------------------------------------------------------");

            //Поиск самой большой длины строкм символов в файле
            Console.WriteLine(" f) Найти длину самой длинной строки и вывести ее на экран");
            reader.DiscardBufferedData();
            reader.BaseStream.Seek(0, SeekOrigin.Begin);
            int longestLineLength = 0;
            while ((line = reader.ReadLine()) != null)
            {
                if (line.Length > longestLineLength)
                {
                    longestLineLength = line.Length;
                }
            }
            Console.WriteLine($"  Длина самой длинной строки: {longestLineLength}");
            Console.WriteLine("---------------------------------------------------------------------------");

            //Поменять порядок строк символов в файле с меньшего-большее на большего-меньшее
            Console.WriteLine(" h) Переписать его строки в другой файл, порядок строк во втором " +
                "\n  файле должен быть обратным по отношению к порядку строк в заданном файле.");
            reader.DiscardBufferedData();
            reader.BaseStream.Seek(0, SeekOrigin.Begin);
            string[] reversedLines = lines.Reverse().ToArray();
            File.WriteAllLines("reversedFile.txt", reversedLines);
        }
    }
}