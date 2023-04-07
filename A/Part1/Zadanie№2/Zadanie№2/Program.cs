namespace Задание__2
{
    class ProductOfDigits
    {
        static void Main()
        {
            Console.WriteLine("Задание №2\n Дано четырехзначное число. Найти произведение его цифр.\n\nРешение:");

            int num, fir, sec, thi, fou, mul;

            Console.Write(" Введите четырёхзначное число num: ");
            num = Convert.ToInt32(Console.ReadLine());

            if (num >= 1000 && num <= 9999)
            {
                fir = num / 1000;
                Console.WriteLine(" Первая цифра fir: {0}", fir);

                sec = num / 100 % 10;
                Console.WriteLine(" Вторая цифра sec: {0}", sec);

                thi = num / 10 % 10;
                Console.WriteLine(" Первая цифра thi: {0}", thi);

                fou = num % 10;
                Console.WriteLine(" Вторая цифра fou: {0}\n", fou);

                mul = fir * sec * thi * fou;
                Console.Write(" Произведение цифр: {0}", mul);
            }
            else
            {
                Console.WriteLine(" Это не четырёхзначное число num");
            }

            Console.ReadLine();
        }
    }
}