using System;
using System.Collections.Generic;
using System.Text;

namespace CoolConsole.MenuItemTemplate
{
    class TextboxMenuItem : MenuItem
    {
        public TextboxMenuItem(string text, string textboxText) : base(text)
        {
            TextboxText = textboxText;
        }

        public string TextboxText { get; set; }
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
        public void OnSelect()
        {
            Console.WriteLine("Enter text:");
            TextboxText = Console.ReadLine();
            
        }

        public override string GetType()
        {
            return "TextboxMenuItem";
        }
    }
}
