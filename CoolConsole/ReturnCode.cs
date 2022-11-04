using System.Collections.Generic;

namespace CoolConsole
{
    public class ReturnCode
    {
        public int SelectedMenuItem = 0;
        public List<CheckboxData> Checkboxes;
        public List<TextboxData> Textboxes;
        public List<NumboxData> Numboxes;
        public ReturnCode()
        {
            Checkboxes = new List<CheckboxData>();
            Textboxes = new List<TextboxData>();
            Numboxes = new List<NumboxData>();
        }
        public void AddCheckbox(CheckboxData checkbox)
        {
            Checkboxes.Add(checkbox);
        }
        public void AddTextbox(TextboxData textbox)
        {
            Textboxes.Add(textbox);
        }
        public void AddNumbox(NumboxData textbox)
        {
            Numboxes.Add(textbox);
        }
    }
    public class CheckboxData
    {
        public int _Index;
        public bool _Value;
        public CheckboxData(int index, bool value)
        {
            _Index = index;
            _Value = value;
        }
    }
    public class TextboxData
    {
        public int _Index;
        public string _Value;
        public TextboxData(int index, string value)
        {
            _Index = index;
            _Value = value;
        }
    }
    public class NumboxData
    {
        public int _Index;
        public int _Value;
        public NumboxData(int index, int value)
        {
            _Index = index;
            _Value = value;
        }
    }
}