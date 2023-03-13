using System;
using System.Collections.Generic;
using System.Text;

namespace CoolConsole.MenuItems 
{
	public class SubMenuMenuItem : MenuItem
	{
        public List<MenuItem> items = new List<MenuItem>();
        public ReturnCode returnCode = new ReturnCode();
        public SubMenuMenuItem(string text, ConsoleColor color, ConsoleColor backgroundColor) : base(text, color, backgroundColor) { }
        public SubMenuMenuItem(string text, ConsoleColor color) : base(text, color) { }
        public SubMenuMenuItem(string text) : base(text) { }
        public override void OnSelect() 
        {
            Console.Clear();
            returnCode = Menu.Show(items);
        }
		public override string GetType()
		{
			return "SubMenuMenuItem";
		}
		public override void Write(bool selected, string prefix) 
        {
            if (selected) {
                Console.BackgroundColor = _Color;
                Console.ForegroundColor = _BackgroundColor;
                Console.Write(prefix + prefix);
            }
            else {
                Console.BackgroundColor = _BackgroundColor;
                Console.ForegroundColor = _Color;
                Console.Write("  ");
            }
            Console.WriteLine(_Text);
            Console.ResetColor();
        }
    }
}
