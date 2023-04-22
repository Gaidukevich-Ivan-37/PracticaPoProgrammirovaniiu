namespace Задание__3
{
    class MyInfo
    {
        private string name;

        public event EventHandler NameChanged;
        public string Name
        {
            get { return name; }
            set
            {
                name = value;
                OnNameChanged();
            }
        }
        protected virtual void OnNameChanged()
        {
            NameChanged?.Invoke(this, EventArgs.Empty);
        }
    }
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Задание №3\n Для класса MyInfo содержащего поле name (Ваше имя) создать событие выводящее оповещение в случае " +
                "\n изменения значения поля name. \n\nРешение:");

            MyInfo info = new();
            info.NameChanged += Info_NameChanged;

            info.Name = " John Doe";
        }
        private static void Info_NameChanged(object sender, EventArgs e)
        {
            Console.WriteLine(" Имя было изменено");
        }
    }
}