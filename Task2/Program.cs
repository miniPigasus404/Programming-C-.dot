namespace Task2
{
    class Employee {
        internal string name;
        private DateTime hiringdate; //DateTime specificDateTime = new DateTime(2024, 3, 22, 10, 30, 0);// Year, Month, Day
        public Employee(string name, DateTime hiringdate) {
            this.name = name;
            this.hiringdate = hiringdate;
        }
        public int Experience()
        {
            return DateTime.Today.Year - hiringdate.Year;
        }
        public void ShowInfo()
        {
            Console.WriteLine($"{name} has {this.Experience()} years of experience");
        }
    }
    class Developer : Employee {
        public Developer(string name, DateTime hiringDate, string programmingLanguage)
       : base(name, hiringDate)
        {
            this.programmingLanguage = programmingLanguage;
        }
        private string programmingLanguage; 
        public void ShowInfo()
        {
            Console.WriteLine($"{name} has {this.Experience()} years of experience\n{name} is {programmingLanguage} programmer");
        }
    }
    class Tester : Employee {
        public Tester(string name, DateTime hiringDate, bool isAuthomation)
        :base(name, hiringDate)
        {
            this.isAuthomation = isAuthomation;
        }
        private bool isAuthomation;
        public void ShowInfo()
        {
            if (isAuthomation)
            {
                Console.WriteLine($"{name} is authomated tester and has {this.Experience()} year(s) of experience");
            }
            else { Console.WriteLine($"{name} is manual tester and has {this.Experience()} year(s) of experience"); }
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            DateTime specificDateTime = new DateTime(2020, 3, 22);
            Developer d = new Developer("Anton", specificDateTime, "Python");
            Console.WriteLine(d.Experience());
            d.ShowInfo();
        }
    }
}
