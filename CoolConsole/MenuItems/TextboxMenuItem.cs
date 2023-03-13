using System;
using System.Collections.Generic;
using System.Text;

namespace CoolConsole.MenuItems
{
    public class TextboxMenuItem : MenuItem
    {
        public TextboxMenuItem(string text, string defaultValue) : base(text)
        {
            Value = defaultValue;
        }

        public string Value { get; set; }
		public override string GetType()
		{
			return "TextboxMenuItem";
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
            Console.Write(Value);
            Console.WriteLine("]" + _Text);
            Console.ResetColor();
        }
        public override void OnSelect()
        {
            Console.WriteLine("Enter text:");
            Value = Console.ReadLine();
            
        }
    }
}
