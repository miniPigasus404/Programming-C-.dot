using System.Runtime.CompilerServices;

namespace Task5
{
    class ParallelUtils<T, TR>
    {
        private T operand1;
        private T operand2;
        private Func<T, T, TR> operation;

        public ParallelUtils(T operand1, T operand2, Func<T, T, TR> operation)
        {
            this.operand1 = operand1;
            this.operand2 = operand2;
            this.operation = operation;
        }

        public TR Result { get; private set; }

        public Task StartEvaluation()
        {
            return Task.Run(() => this.Result = operation(operand1, operand2));
        }

        public async Task Evaluation()
        {
            this.Result = await Task.Run(() => operation(this.operand1, this.operand2));
        }


    }
    internal class Program
    {
        static double addiotion(int a, int b)
        {
            return a + b;
        }
        static double substraction(int a, int b)
        {
            return a - b;
        }
        static async Task Main(string[] args)
        {
            int op1 = 10;
            int op2 = 5;
            ParallelUtils<int, double> ex1 = new ParallelUtils<int, double>(op1, op2, addiotion);
            ParallelUtils<int, double> ex2 = new ParallelUtils<int, double>(op1, op2, substraction);

            ex1.Evaluation();
            ex1.StartEvaluation();

            ex2.Evaluation();
            ex2.StartEvaluation();

            Task.WaitAll();
            Console.WriteLine($"Ex1 Res: {ex1.Result}, Ex2 Res: {ex2.Result}");
        }
    }
}
