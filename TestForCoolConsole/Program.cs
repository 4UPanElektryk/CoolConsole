using System;
using System.Collections.Generic;
using CoolConsole;
using CoolConsole.Aditonal;
using CoolConsole.MenuItems;

namespace TestForCoolConsole
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            ProgressBar.Show(1,10,20,true);
            Console.ReadKey(true);
            List<MenuItem> texts = new List<MenuItem>
            {
                new CheckboxMenuItem("SelectedCheckbox1", true),
                new CheckboxMenuItem("SelectedCheckbox2", true),
                new CheckboxMenuItem("SelectedCheckbox3", true),
                new CheckboxMenuItem("SelectedCheckbox4", true),
                new CheckboxMenuItem("SelectedCheckbox5", true),
                new CheckboxMenuItem("UnselectedCheckbox1", false),
                new CheckboxMenuItem("UnselectedCheckbox2", false),
                new CheckboxMenuItem("UnselectedCheckbox3", false),
                new CheckboxMenuItem("UnselectedCheckbox4", false),
                new CheckboxMenuItem("UnselectedCheckbox5", false),
                new TextboxMenuItem("TextInput1","wow"),
                new NumboxMenuItem("noice",69),
                new SubMenuMenuItem("Menu++")
                {
                    items = new List<MenuItem>
                    {
						new CheckboxMenuItem("UnselectedCheckbox2", false),
				        new CheckboxMenuItem("UnselectedCheckbox3", false),
				        new CheckboxMenuItem("UnselectedCheckbox4", false),
				        new CheckboxMenuItem("UnselectedCheckbox5", false),
				        new TextboxMenuItem("TextInput1","wow"),
				        new NumboxMenuItem("noice",69),
						new MenuItem("Submit")
					}
                },
                new MenuItem("Submit")
            };
            ReturnCode i = Menu.Show(texts);
            GetRetCode(i);
            Console.ReadKey();
        }
        public static void GetRetCode(ReturnCode returnCode)
        {
			foreach (var item in returnCode.Checkboxes)
			{
				Console.WriteLine(item);
			}
			foreach (var item in returnCode.Textboxes)
			{
				Console.WriteLine(item);
			}
			foreach (var item in returnCode.Numboxes)
			{
				Console.WriteLine(item);
			}
			foreach (var item in returnCode.SubMenues)
            {
                GetRetCode(item);
            }
		}
    }
}
