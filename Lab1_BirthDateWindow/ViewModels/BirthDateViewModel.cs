using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using Lab1_BirthDateWindow.Models;
using Lab1_BirthDateWindow.Views;

namespace Lab1_BirthDateWindow.ViewModels
{
    internal class BirthDateViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler? PropertyChanged;

        private UserBirthInfo _user = new UserBirthInfo();

        public string ChineseZodiacSign
        {
            get { return _user.ChineseZodiacSign; }
        }


        public string WesternZodiacSign
        {
            get { return _user.WesternZodiacSign; }
        }


        public Visibility IsBirthdayToday
        {
            get { return _user.IsBirthdayToday ? Visibility.Visible : Visibility.Collapsed; }
        }


        public string Age
        {
            get { return $"Your age is {_user.Age}"; }
        }


        public DateTime BirthDate
        {
            get { return _user.BirthDate; }
            set
            {
                if (value > DateTime.Today)
                {
                    MessageBox.Show("The selected date is in the future. Please select a valid date.");
                    return;
                }
                else if (UserBirthInfo.CalculateAge(value) > 135)
                {
                    MessageBox.Show("The age entered is too high. Please select a valid birth date.");
                    return;
                }
                _user.BirthDate = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Age)));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(IsBirthdayToday)));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(WesternZodiacSign)));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(ChineseZodiacSign)));
            }
        }

    }
}
