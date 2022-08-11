using System.Collections.Generic;

namespace CoolConsole
{
    public class ReturnCode
    {
        public int SelectedMenuItem = 0;
        public List<CheckBoxData> CheckBoxes;
        public List<string> TextBoxes;
        public ReturnCode()
        {
            CheckBoxes = new List<CheckBoxData>();
            TextBoxes = new List<string>();
        }
        public void AddCheckedBox(CheckBoxData checkedBox)
        {
            CheckBoxes.Add(checkedBox);
        }
    }
    public class CheckBoxData
    {
        public int _Index;
        public bool _Checked;
        public CheckBoxData(int index, bool checkedState)
        {
            _Index = index;
            _Checked = checkedState;
        }
    }
}