namespace Задание__1
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Задание №1\n  Описать структуру с именем STUDENT, содержащую следующие поля:" +
                "\n - фамилия и инициалы;\n - номер группы;\n - успеваемость (массив из пяти элементов)." +
                "\n  Написать программу, выполняющую следующие действия:" +
                "\n - ввод с клавиатуры данных в массив, состоящий из десяти структур типа STUDENT \n" +
                "(записи должны быть упорядочены по возрастанию номера группы);" +
                "\n - вывод на экран фамилий и номеров групп для всех студентов, включенных в массив, если" +
                "\n средний балл студента больше 4,0 (если таких студентов нет, вывести соответствующее сообщение)." +
                "\n\nРешение:");

            Student[] students = new Student[2];

            for (int i = 0; i < students.Length; i++)
            {
                Console.Write(" Введите фамилия и инициалы {0}-го студента: ", i + 1);
                string name = Console.ReadLine();

                Console.Write(" Введите номер группы {0}-го студента: ", i + 1);
                int number = int.Parse(Console.ReadLine());

                Console.Write(" Введите, через запятую, 5 оценок {0}-го студента: ", i + 1);
                string[] marks = Console.ReadLine().Split(',');

                Console.WriteLine("-----------------------------------------------------------");

                int[] progress = new int[5];
                for (int a = 0; a < 5; a++)
                    progress[a] = int.Parse(marks[a].ToString());


                students[i] = new Student(name, number, progress);
            }

            var stud = from i in students orderby i.GroupNumber select i; //Сортировка

            Console.WriteLine("\n Упорядоченный по номеру группы массив студентов: ");

            foreach (Student student in stud)
                Console.WriteLine(" " + student.ToString());

            int count = 0;
            foreach (Student student in students)
                if (student.MediumBall() > 4)
                    count++;

            if (count == 0)
                Console.WriteLine("\n Нет студентов со средним баллом больше 4!");
            else
                Console.WriteLine("\n Список студентов со средним баллом больше 4: ");

            foreach (Student student in students)
                if (student.MediumBall() > 4)
                    Console.WriteLine(" " + student.ToString());

            Console.ReadKey();
        }
    }

    struct Student
    {
        public string Name;
        public int GroupNumber;
        readonly int[] progress;

        public Student(string Name, int GroupNumber, int[] marks)
        {
            this.Name = Name;
            this.GroupNumber = GroupNumber;
            progress = marks;
        }

        public double MediumBall()
        {
            double MedBall = 0;

            foreach (int i in progress)
                MedBall += i;
            MedBall /= progress.Length;

            return MedBall;
        }

        public override string ToString()
        {
            return string.Format(" ФИО: {0} \n  Номер группы: {1}", Name, GroupNumber);
        }
    }
}