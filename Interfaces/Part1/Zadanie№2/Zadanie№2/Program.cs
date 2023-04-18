namespace Задание__2
{
    public class Interfaces
    {
        static void Main()
        {
            Console.WriteLine("Задание №2\n Описать класс «автостоянка» для хранения сведений об автомобилях. " +
                "\n Для каждого автомобиля записываются госномер, цвет, " +
                "\n фамилия владельца и признак присутствия на стоянке.\n\nРешение:");

            Auto audi = new Auto();
            audi.Model = " Audi:";
            audi.Color = "red";
            audi.Number = "AS4566N";
            audi.Time = DateTime.Now.AddDays(-1);

            Auto mers = new Auto();
            mers.Model = " Mersedes:";
            mers.Color = "black";
            mers.Number = "NS6456A";
            mers.Time = DateTime.Now;

            Auto bmw = new Auto();
            bmw.Model = " Bmw:";
            bmw.Color = "cyan";
            bmw.Number = "DF3333H";
            bmw.Time = DateTime.Now.AddYears(-1);
            audi.toString();
            Console.WriteLine(audi.getNumber());
            mers.toString();
            Console.WriteLine(mers.getNumber());
            bmw.toString();
            Console.WriteLine(bmw.getNumber());
        }
    }
    class Auto : Stend
    {
        public string Model { get; set; }
        public string Color { get; set; }
        public string Number { get; set; }
        public DateTime Time { get; set; }
        private string AutoName;
        public void toString()
        {
            AutoName = Model + "\n  -цвет: " + Color + "\n  -номера: " + Number + "\n  -время прибытия: " + Time;
            printToDisplay();
        }
        public void printToDisplay()
        {
            Console.WriteLine(AutoName);
        }
        public string getNumber()
        {
            return (DateTime.Now - Time).TotalDays > 100 ? " Должник\n" : " Не должен\n";
        }
    }
    interface Stend
    {
        void printToDisplay();
        string getNumber();
    }
}