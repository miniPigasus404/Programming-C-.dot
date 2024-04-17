namespace Task1
{
    class MyAccessModifiers
    {
        private int BirthYear;
        protected string personalInfo;
        private protected string IdNumber;
        public MyAccessModifiers(int birthYear, string personalInfo, string idNumber)
        {
            BirthYear = birthYear;
            this.personalInfo = personalInfo;
            IdNumber = idNumber;
        }
        public int Age
        {
            get{ return DateTime.Now.Year - BirthYear;}
        }
        public static byte averageMiddleAge = 50;
        internal string Name { get; set; }
        public string NickName { get; internal set; }
        protected void HasLivedHalfOfLife(){}
        public static bool operator==(MyAccessModifiers a, MyAccessModifiers b)
        {
            if((a.Name == b.Name) &&( a.Age == b.Age) && (a.personalInfo==b.personalInfo)) return true;
            else return false;
        }
        public static bool operator!=(MyAccessModifiers a, MyAccessModifiers b) { return !(a == b); }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            MyAccessModifiers acc1 = new MyAccessModifiers(2007, "Have computer", "5593");
            Console.WriteLine($"Demonstraition of Age property: {acc1.Age}");
            Console.WriteLine("Write the name of user");
            acc1.Name = Console.ReadLine();
            Console.WriteLine("Write the nickname of user");
            acc1.NickName = Console.ReadLine();
            Console.WriteLine($"Demonstration of Name and Nickname properties:\nName: {acc1.Name}\tNickname: {acc1.NickName}");
            MyAccessModifiers acc2 = new MyAccessModifiers(2007, "Have computer", "5593");
            acc2.Name = acc1.Name;
            MyAccessModifiers acc3 = new MyAccessModifiers(2008, "Have computer", "5133");

            Console.WriteLine("Demonstraition of == operator:");
            Console.WriteLine(acc1 == acc2);
            Console.WriteLine(acc1 == acc3);
        }
    }
}
