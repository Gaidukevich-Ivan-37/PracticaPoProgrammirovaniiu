namespace Задание__2
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Задание №2\n С помощью метода CreateDirectory() создайте папку “New_folder”. \n\nРешение:");

            CreateNewFolder("New_folder");
        }
        static void CreateNewFolder(string folderName)
        {
            try
            {
                string path = Path.Combine(Directory.GetCurrentDirectory(), folderName);

                if (Directory.Exists(path))
                {
                    Console.WriteLine($" Папка {folderName} уже существует");
                    return;
                }

                Directory.CreateDirectory(path);
                Console.WriteLine($" Папка {folderName} успешно создана");
            }
            catch (Exception e)
            {
                Console.WriteLine($"Error: {e.Message}");
            }
        }
    }
}