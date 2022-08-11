using System;
using System.Collections.Generic;
using System.Text;

namespace CoolConsole.Aditonal
{
    public class ProgressBar
    {
        public static void show(int done, int goal,int size = 10, bool showprocentage = false)
        {
            string toshow = "[";
            double step = goal / (size * 1.0);
            double procentage = (done * 100) / goal;
            for (int i = 0; i < size; i++)
            {
                if ((i+1.00) * step <= done)
                {
                    toshow += "#";
                }
                else
                {
                    toshow += " ";
                }
            }
            toshow += "]";
            if (showprocentage)
            {
                toshow += procentage + "%";
            }
            else
            {
                toshow += done;
                toshow += "/";
                toshow += goal;
            }
            Console.WriteLine(toshow);
        }
    }
}
