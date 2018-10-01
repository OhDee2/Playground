using System;
using System.Collections.Generic;
using System.Text;

namespace DelegatesAndEvents
{
    // write it like this if you want to use it elsewhere
    //public delegate int WorkPerformedHandler(object sender, WorkPerformedEventArgs e);

    public class Worker
    {
        public event EventHandler<WorkPerformedEventArgs> WorkPerformed;
        public event EventHandler WorkCompleted;

        public void DoWork(int hours, WorkType workType)
        {
            for (int i = 0; i < hours; i++)
            {
                
            }
            // raise event
        }

        protected virtual void OnWorkPerformed(int hours, WorkType workType)
        {
            WorkPerformed?.Invoke(this, new WorkPerformedEventArgs(hours, workType));
        }

        protected virtual void OnWorkCompleted(int hours, WorkType workType)
        {
            WorkCompleted?.Invoke(this, EventArgs.Empty);
        }
    }
}
