using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CoolConsole;
using CoolConsole.Aditonal;
using CoolConsole.MenuItemTemplate;

namespace TestForCoolConsole
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            ProgressBar.show(1,10,20,true);
            Console.ReadKey(true);
            List<MenuItem> texts = new List<MenuItem>()
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
                new MenuItem("Submit")
            };
            ReturnCode i = Menu.Show(texts);
            foreach (var item in i.CheckBoxes)
            {
                Console.WriteLine("Setting " + texts[item._Index]._Text);
                Console.WriteLine("Is set to " + item._Checked);
            }
            Console.ReadKey();
        }
    }
}
