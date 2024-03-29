﻿using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows;
using FilozopLab01.Models;

namespace FilozopLab01.BirthdayProject.ViewModels
{
    public class ViewModelBirthday : INotifyPropertyChanged
    {

        #region Fields
        private CountingBirthday _birthday = new();
        public event PropertyChangedEventHandler? PropertyChanged;
        private string _age;
        private string _chineseZodiacSign;
        private string _westernZodiacSign;
        #endregion

        #region Properties
        public DateTime UpdateDate
        {
            get 
            { 
                return _birthday.Date; 
            }
            set 
            {
                _birthday.Date = value; 
            }
        }

        public string Age
        {
            get 
            {
                return _age; 
            }
            set
            {
                _age = value; OnPropertyChanged(); 
            }
        }

        public string ChineseZodiacSign
        {
            get 
            {
                return _chineseZodiacSign; 
            }
            set 
            {
                _chineseZodiacSign = value; OnPropertyChanged(); 
            }
        }

        public string WesternZodiacSign
        {
            get 
            {
                return _westernZodiacSign; 
            }
            set 
            {
                _westernZodiacSign = value; OnPropertyChanged();
            }
        }
        #endregion


        public void ChooseBirthdayDate()
        {
            var userAge = _birthday.CountUserAge();

            if (!_birthday.DateIsValid())
            {
                if (userAge < 0)
                {
                    MessageBox.Show("You're probably isn't born yet");
                }
                else if (userAge > 135)
                {
                    MessageBox.Show("You're probably dead");
                }
                else
                {
                    MessageBox.Show("Invalid birthday");
                }
                Age = "";
                ChineseZodiacSign = "";
                WesternZodiacSign = "";

            }
            else
            {
                if (_birthday.Date.Month == DateTime.Today.Month && _birthday.Date.Day == DateTime.Today.Day)
                {
                    MessageBox.Show("Today is your birthday! You became a year older");
                    Age = $"Today your age became: {userAge}";
                }
                else
                {
                    Age = $"Your age is: {userAge}";
                }

                ChineseZodiacSign = $"Your Chinese Zodiac Sign: {_birthday.ZodiacChinese()}";
                WesternZodiacSign = $"Your Western Zodiac Sign: {_birthday.ZodiacWestern()}";
            }
        }


        public void OnPropertyChanged([CallerMemberName] string property = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(property));
        }
    }
}


