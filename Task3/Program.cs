namespace Task3
{
    delegate double CalcDelegate(double a, double b, string operation);
    class CalcProgram
    {
        static double Calc(double a, double b, string operation)
        {
            if(operation == "+") { return a + b; }
            else if(operation == "-") {  return a - b; }
            else if(operation == "*") {  return a * b; }
            else if(operation == "/") { return b == 0 ? 0 : a / b; }
            return 0;
        }
        public CalcDelegate FuncCalc = new CalcDelegate(Calc);
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            CalcProgram p = new CalcProgram();
            Console.WriteLine(p.FuncCalc(5, 6, "+"));

        }
    }
}
