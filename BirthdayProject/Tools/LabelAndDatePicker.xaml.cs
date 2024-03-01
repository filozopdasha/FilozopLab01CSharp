using System;
using System.Windows.Controls;

namespace FilozopLab01.BirthdayProject.Tools
{
    public partial class LabelAndDatePicker : UserControl
    {
        public string Caption
        {
            get { return (string)birthdayCaption.Content; }
            set { birthdayCaption.Content = value; }
        }

        public string Text
        {
            get { return dateField.Text; }
        }

        public DateTime Value
        {
            get { return dateField.SelectedDate.Value; }
        }

        public LabelAndDatePicker()
        {
            InitializeComponent();
        }
    }
}