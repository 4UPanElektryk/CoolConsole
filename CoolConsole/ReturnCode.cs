using System.Collections.Generic;

namespace CoolConsole
{
    public class ReturnCode
    {
        public int SelectedMenuItem = 0;
        public List<CheckboxData> Checkboxes;
        public List<TextboxData> Textboxes;
        public ReturnCode()
        {
            Checkboxes = new List<CheckboxData>();
            Textboxes = new List<TextboxData>();
        }
        public void AddCheckbox(CheckboxData checkbox)
        {
            Checkboxes.Add(checkbox);
        }
        public void AddTextbox(TextboxData textbox)
        {
            Textboxes.Add(textbox);
        }
    }
    public class CheckboxData
    {
        public int _Index;
        public bool _Checked;
        public CheckboxData(int index, bool checkedState)
        {
            _Index = index;
            _Checked = checkedState;
        }
    }
    public class TextboxData
    {
        public int _Index;
        public string _Text;
        public TextboxData(int index, string text)
        {
            _Index = index;
            _Text = text;
        }
    }
}