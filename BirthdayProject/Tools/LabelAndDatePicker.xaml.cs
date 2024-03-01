using System;
using System.Windows.Controls;

namespace FilozopLab01.BirthdayProject.Tools
{
    public partial class LabelAndDatePicker : UserControl
    {
        public string Caption
        {
            get 
            {
                return (string)BCaption.Content; 
            }
            set 
            {
                BCaption.Content = value; 
            }
        }

        public string Text
        {
            get 
            {
                return DField.Text; 
            }
        }

        public DateTime Value
        {
            get 
            {
                return DField.SelectedDate.Value;
            }
        }

        public LabelAndDatePicker()
        {
            InitializeComponent();
        }
    }
}