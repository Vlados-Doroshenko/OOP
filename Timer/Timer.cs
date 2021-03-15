using System;
using System.Collections.Generic;
using System.Text;
using System.Timers;

namespace Timer
{
    class Timer
    {
        delegate void TimerDelegate();

        
        public void Time()
        {
            TimerDelegate tm;
            DateTime date = DateTime.Now;
            TimeSpan Period = date.AddSeconds(5) - date;
            int i = 0;
            while (i < 10)
            {
                if(DateTime.Now - date >= Period)
                {
                    if (i % 2 == 0)
                    {
                        tm = Tic;
                    }
                    else
                    {
                        tm = Tac;
                    }
                    tm.Invoke();
                    date = DateTime.Now;
                    i++;
                }
            }

        }
        public void Tic()
        {
            Console.WriteLine("Tic");
        }
        public void Tac()
        {
            Console.WriteLine("Tac");
        }
    }
}
