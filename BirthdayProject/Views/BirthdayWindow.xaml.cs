using System;
using System.Windows;
using System.Windows.Controls;
using FilozopLab01.BirthdayProject.ViewModels;

namespace FilozopLab01.BirthdayProject.Views
{
    /// <summary>
    /// Interaction logic for BirthdayWindow.xaml
    /// </summary>
    public partial class BirthdayWindow : UserControl
    {
        private readonly ViewModelBirthday _viewModel;
        public BirthdayWindow()
        {
            InitializeComponent();
            this.DataContext = _viewModel = new ViewModelBirthday();
        }

        private void Changed_Date(object sender, SelectionChangedEventArgs e)
        {
            DateTime? selectedDate = DField.SelectedDate;
            if (selectedDate != null)
            {
                _viewModel.UpdateDate = selectedDate.Value;
            }
        }
        private void Confirm_Click(object sender, RoutedEventArgs e)
        {
            _viewModel.ChooseBirthdayDate();
        }

    }
}