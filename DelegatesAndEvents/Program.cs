using System;
using System.Security.Cryptography.X509Certificates;

namespace DelegatesAndEvents
{
    public delegate int BizRulesDelegate(int x, int y);

    public enum WorkType
    {
        Meetings,
        Standups,
        Reviews
    }

    class Program
    {
        private static void Main(string[] args)
        {
            // local variables
            var data = new ProcessData();
            int addDel(int x, int y) => x + y;
            int MultiplyDel(int x, int y) => x * y;
            data.Process(2, 3, MultiplyDel);

            int FuncAddDel(int x, int y) => x + y;
            int funcMultiplyDel(int x, int y) => x * y;
            data.ProcessFunc(3,2, FuncAddDel);
            
            // action
            Action<int, int> myAction = (x, y) => Console.WriteLine(x + y);
            void MyMultiplyAction(int x, int y) => Console.WriteLine(x * y);
            data.ProcessAction(2, 3, MyMultiplyAction);

            var worker = new Worker();
            worker.WorkPerformed += Worker_WorkPerformed;
            // with lamda
            //worker.WorkPerformed += (s,e) => Console.WriteLine($"{e.Hours} hours doing {e.WorkType}");
            worker.WorkCompleted += Worker_WorkCompleted;
            worker.DoWork(8, WorkType.Standups);

            Console.Read();

        }

        private static void Worker_WorkPerformed(object sender, WorkPerformedEventArgs e)
        {
            Console.WriteLine($"{e.Hours} hours doing {e.WorkType}");
        }

        private static void Worker_WorkCompleted(object sender, EventArgs e)
        {
            Console.WriteLine("Worker is done");
        }
        
    }
}
