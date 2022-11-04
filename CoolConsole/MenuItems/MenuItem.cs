using System;
using System.Collections.Generic;
using System.Text;

namespace CoolConsole.MenuItems
{
    public class MenuItem
    {
        public string _Text;
        public ConsoleColor _Color;
        public ConsoleColor _BackgroundColor;
        public MenuItem(string text, ConsoleColor color, ConsoleColor backgroundColor)
        {
            _Text = text;
            _Color = color;
            _BackgroundColor = backgroundColor;
        }
        public MenuItem(string text, ConsoleColor color)
        {
            _Text = text;
            _Color = color;
            _BackgroundColor = ConsoleColor.Black;
        }
        public MenuItem(string text)
        {
            _Text = text;
            _Color = ConsoleColor.Gray;
            _BackgroundColor = ConsoleColor.Black;
        }
        public virtual void OnSelect() 
        {

        }

        public virtual void Write(bool selected, string prefix)
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
            Console.WriteLine(_Text);
            Console.ResetColor();
        }
        public new virtual string GetType()
        {
            return "MenuItem";
        }
    }
}
