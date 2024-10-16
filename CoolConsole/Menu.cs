using CoolConsole.MenuItems;
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
            ConsoleKey key;
            #region main loop
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
                    if (list[selected].GetType() == typeof(MenuItem))
                    {
                        exit = true;
                    }
                    else
                    {
                        MenuItem f = (MenuItem)list[selected];
                        f.OnSelect();
                        list[selected] = f;
                    }
                }
                ReWrite(list, prefix, selected);
            } while (!exit);
			#endregion
			#region Returning Data
			ReturnCode returnCode = new ReturnCode();
            foreach (var item in list)
            {
                if (item.GetType() == typeof(CheckboxMenuItem))
                {
                    CheckboxMenuItem f = (CheckboxMenuItem)item;
                    returnCode.Checkboxes.Add(f.IsChecked);
                }
                else if (item.GetType() == typeof(TextboxMenuItem))
                {
                    TextboxMenuItem f = (TextboxMenuItem)item;
                    returnCode.Textboxes.Add(f.Value);
                }
                else if (item.GetType() == typeof(NumboxMenuItem))
                {
                    NumboxMenuItem f = (NumboxMenuItem)item;
                    returnCode.Numboxes.Add(f.Value);
                }
                else if (item.GetType() == typeof(SubMenuMenuItem))
                {
                    SubMenuMenuItem f = (SubMenuMenuItem)item;
                    returnCode.SubMenues.Add(f.returnCode);
                }
            }
            returnCode.SelectedMenuItem = selected;
            Console.Clear();
            return returnCode;
#endregion
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
