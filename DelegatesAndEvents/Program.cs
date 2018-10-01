using System;

namespace DelegatesAndEvents
{
    public enum WorkType
    {
        Meetings,
        Standups,
        Reviews
    }

    class Program
    {
        static void Main(string[] args)
        {
            //WorkPerformedHandler del1 = WorkPerformed1;
            //WorkPerformedHandler del2 = WorkPerformed2;
            //WorkPerformedHandler del3 = WorkPerformed3;


            //del1 += del2 + del3;

            //int finalHours = del1(10, WorkType.Meetings);

            //Console.WriteLine(finalHours);

            var worker = new Worker();
            //worker.

            Console.Read();

        }

        //static void DoWork(WorkPerformedHandler del)
        //{
        //    del(5, WorkType.Reviews);
        //}

        static int WorkPerformed1(int hours, WorkType workType)
        {
            Console.WriteLine($"WorkPerformed1 called - {hours} hours doing {workType}");
            return hours + 1;
        }

        static int WorkPerformed2(int hours, WorkType workType)
        {
            Console.WriteLine($"WorkPerformed2 called - {hours} hours doing {workType}");
            return hours + 2;

        }

        static int WorkPerformed3(int hours, WorkType workType)
        {
            Console.WriteLine($"WorkPerformed2 called - {hours} hours doing {workType}");
            return hours + 3;

        }
    }
}
