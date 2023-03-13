using System.Collections.Generic;

namespace CoolConsole
{
    public class ReturnCode
    {
        public int SelectedMenuItem = 0;
        public List<bool> Checkboxes;
        public List<string> Textboxes;
        public List<int> Numboxes;
        public List<ReturnCode> SubMenues;
        public ReturnCode()
        {
            Checkboxes = new List<bool>();
            Textboxes = new List<string>();
            Numboxes = new List<int>();
            SubMenues = new List<ReturnCode>();
        }
    }
}