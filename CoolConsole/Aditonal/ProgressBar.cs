using System;
using System.Collections.Generic;
using System.Text;

namespace CoolConsole.Aditonal
{
    public class ProgressBar
    {
        public static void Show(int done, int goal, int size = 10, bool showprocentage = false)
        {
            string toshow = "[";
            double step = goal / (size * 1.0);
            double procentage = (done * 100) / goal;
            for (int i = 0; i < size; i++)
            {
                if ((i + 1.00) * step <= done)
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
        public static void ShowColor(int done, int goal, ConsoleColor color, int size = 10, bool showprocentage = false)
        {
            Console.ResetColor();
            Console.Write("[");
            string toshow = "";
            double step = goal / (size * 1.0);
            double procentage = (done * 100) / goal;
            for (int i = 0; i < size; i++)
            {
                if ((i + 1.00) * step <= done)
                {
                    toshow += "#";
                }
                else
                {
                    toshow += " ";
                }
            }
            Console.ForegroundColor = color;
            Console.Write(toshow);
            Console.ResetColor();
            Console.Write("]");


            if (showprocentage)
            {
                Console.WriteLine(procentage + "%");
            }
            else
            {
                Console.WriteLine(done + "/" + goal);
            }

        }
    }
}
