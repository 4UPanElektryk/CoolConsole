using System;
using System.Collections.Generic;
using System.Text;

namespace CoolConsole.MenuItems
{
    public class CheckboxMenuItem : MenuItem
    {
        public bool IsChecked;
        public CheckboxMenuItem(string text, ConsoleColor color, ConsoleColor backgroundColor, bool check) : base(text, color, backgroundColor)
        {
            IsChecked = check;
        }
        public CheckboxMenuItem(string text, ConsoleColor color, bool check) : base(text, color)
        {
            IsChecked = check;
        }
        public CheckboxMenuItem(string text, bool check) : base(text)
        {
            IsChecked = check;
        }
        public CheckboxMenuItem(string text, ConsoleColor color, ConsoleColor backgroundColor) : base(text, color, backgroundColor)
        {
            IsChecked = false;
        }
        public CheckboxMenuItem(string text, ConsoleColor color) : base(text, color)
        {
            IsChecked = false;
        }
        public CheckboxMenuItem(string text) : base(text)
        {
            IsChecked = false;
        }

        public override void Write(bool selected, string prefix)
        {
            if (selected)
            {
                Console.BackgroundColor = _Color;
                Console.ForegroundColor = _BackgroundColor;
                Console.Write(" " + prefix);
            }
            else
            {
                Console.BackgroundColor = _BackgroundColor;
                Console.ForegroundColor = _Color;
                Console.Write("  ");
            }
            Console.Write("[");
            if (IsChecked)
            {
                Console.Write("X");
            }
            else
            {
                Console.Write(" ");
            }
            Console.WriteLine("]" + _Text);
            Console.ResetColor();
        }
        public override void OnSelect()
        {
            IsChecked = !IsChecked;
        }
        public override string GetType()
        {
            return "CheckboxMenuItem";
        }
    }
}
