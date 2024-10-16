using System;
using System.Collections.Generic;
using System.Text;

namespace CoolConsole.MenuItems
{
    public class NumboxMenuItem : MenuItem
    {
        public NumboxMenuItem(string text, int defaultValue) : base(text)
        {
            Value = defaultValue;
        }
        public int Value { get; set; }
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
            Console.Write(Value);
            Console.WriteLine("]" + _Text);
            Console.ResetColor();
        }
		public override void OnSelect()
        {
            Console.WriteLine("Enter a number:");
            string num = Console.ReadLine();
            int g;
            if (int.TryParse(num,out g))
            {
                Value = g;
            }
        }
    }
}

