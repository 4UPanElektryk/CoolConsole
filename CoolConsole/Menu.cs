using CoolConsole.MenuItemTemplate;
using System;
using System.Collections.Generic;

namespace CoolConsole
{
    public class Menu
    {
        public static ReturnCode Show(List<MenuItem> list) 
        {
            return Show(list, ">");
        }
        public static ReturnCode Show(List<MenuItem> list, string prefix)
        {
            int selected = 0;
            bool exit = false;
            ReWrite(list, prefix, selected);
            ConsoleKey key = ConsoleKey.Spacebar;
            do
            {
                key = Console.ReadKey(true).Key;
                if (key == ConsoleKey.UpArrow)
                {
                    if (selected > 0)
                    {
                        selected--;
                    }
                    else
                    {
                        selected = list.Count - 1;
                    }
                }
                else if (key == ConsoleKey.DownArrow)
                {
                    if (selected < list.Count - 1)
                    {
                        selected++;
                    }
                    else
                    {
                        selected = 0;
                    }
                }
                else if (key == ConsoleKey.Enter)
                {
                    if (list[selected].GetType() == "CheckboxMenuItem")
                    {
                        CheckboxMenuItem f = (CheckboxMenuItem)list[selected];
                        f.ChangeChecked();
                        list[selected] = f;
                    }
                    else
                    {
                        exit = true;
                    }
                }
                ReWrite(list, prefix, selected);
            } while (!exit);
            ReturnCode returnCode = new ReturnCode();
            int i = 0;
            foreach (var item in list)
            {
                if (item.GetType() == "CheckboxMenuItem")
                {
                    CheckboxMenuItem f = (CheckboxMenuItem)item;
                    returnCode.AddCheckedBox(new CheckBoxData(i,f.IsChecked));
                }
                i++;
            }
            returnCode.SelectedMenuItem = selected;
            Console.Clear();
            return returnCode;
        }
        private static void ReWrite(List<MenuItem> list, string prefix, int selected)
        {
            int index = 0;
            Console.Clear();
            foreach (MenuItem item in list)
            {
                item.Write(index == selected, prefix);
                index++;
            }
        }
    }    
}
