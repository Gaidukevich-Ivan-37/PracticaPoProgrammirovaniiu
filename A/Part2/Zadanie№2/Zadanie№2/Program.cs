namespace Задание__2
{
    class ProductOfDigits
    {
        static void Main()
        {
            Console.WriteLine("Задание №2\n Дано двузначное число. Найти произведение его цифр.\n\nРешение:");

            int num, fir, sec, mul;

            Console.Write(" Введите двузначное число num: ");
            num = Convert.ToInt32(Console.ReadLine());

            if (num >= 10 && num <= 99)
            {
                fir = num / 10;
                Console.WriteLine(" Первая цифра fir: {0}", fir);

                sec = num % 10;
                Console.WriteLine(" Вторая цифра sec: {0}\n", sec);

                mul = fir * sec;
                Console.Write(" Произведение цифр: {0}", mul);
            }
            else
            {
                Console.WriteLine(" Это не двухначное число num");
            }

            Console.ReadLine();
        }
    }
}