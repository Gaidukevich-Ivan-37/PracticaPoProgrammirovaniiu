namespace Задание__2
{
    public enum Post
    {
        bookkeeper = 193,
        programmer = 124,
        electrician = 223,
        mechanic = 100,
        agronomist = 99,
        engineer = 123,
        builder = 101
    }
    public class Accountant
    {
        private int hours;
        public Accountant()
        {
            hours = 0;
        }
        public void Date()
        {
            Console.WriteLine(" Минимальное время для каждого рабочего для получения премии: \n  bookkeeper = 193; " +
                              "\n  programmer = 124; \n  electrician = 223; \n  mechanic = 100; \n  agronomist = 99; " +
                              "\n  engineer = 123; \n  builder = 101.\n");

            foreach (string post in Enum.GetNames(typeof(Post)))
            {
                Console.Write($" Введите, сколько времени проработал за этот месяц {post}: ");
                hours = Convert.ToInt32(Console.ReadLine());
                Enum.TryParse<Post>(post, true, out Post postEnum);
                Console.WriteLine($"  Полагается ли {post} премия: {AskForBonus(postEnum, hours)}");
                Console.WriteLine();
            }
        }
        public static bool AskForBonus(Post worker, int hours)
        {
            if ((int)worker <= hours)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
    public class Legacy : Accountant
    {
        private int d;
        public Legacy()
        {
            d = 0;
        }
        public int Legacy_Result()
        {
            int a = 12;
            int b = 0;
            int oneYears = 0;
            int[] enums = (int[])Enum.GetValues(typeof(Post));
            int sizeEnum = Enum.GetNames(typeof(Post)).Length;
            for (int i = 0; i < sizeEnum; i++)
            {
                d = enums[i];
                oneYears += a * (b + d);
            }
            return oneYears;
        }
    }
    public class ProgramMain
    {
        public static void Main()
        {
            Console.WriteLine("Задание №1\n Создайте перечисление, в котором будут содержаться должности" +
                "\n сотрудников как имена констант. Присвойте каждой константе значение," +
                "\n задающее количество часов, которые должен отработать сотрудник за месяц.\n\nРешение:");

            Accountant acc = new();
            acc.Date();

            Legacy l = new();
            Console.WriteLine($"{l.Legacy_Result()} Часов в год на работников.");

            Console.ReadKey();
        }
    }
}