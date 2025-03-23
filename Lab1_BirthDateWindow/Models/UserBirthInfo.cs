using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1_BirthDateWindow.Models
{
    internal class UserBirthInfo
    {
		private DateTime _birthDate;
		private int _age;
		private bool _isBirthdayToday;
		private string _westernZodiacSign = "";
		private string _chineseZodiacSign = "";

		public string ChineseZodiacSign
		{
			get { return _chineseZodiacSign; }
			private set { _chineseZodiacSign = value; }
		}


		public string WesternZodiacSign
		{
			get { return _westernZodiacSign; }
			private set { _westernZodiacSign = value; }
		}


		public bool IsBirthdayToday
		{
			get { return _isBirthdayToday; }
			private set { _isBirthdayToday = value; }
		}


		public int Age
		{
			get { return _age; }
			private set { _age = value; }
		}


		public DateTime BirthDate
		{
			get { return _birthDate; }
			set
			{ 
				_birthDate = value;
				UpdateData();
			}
		}

		private void UpdateData()
		{
			Age = CalculateAge(BirthDate);
			IsBirthdayToday = BirthDate.Month == DateTime.Today.Month && BirthDate.Day == DateTime.Today.Day;
            WesternZodiacSign = GetWesternZodiacSign(BirthDate);
            ChineseZodiacSign = GetChineseZodiacSign(BirthDate);
        }

        private string GetChineseZodiacSign(DateTime birthDate)
        {
            return ((ChineseZodiac)(birthDate.Year % 12)).ToString();
        }

        private string GetWesternZodiacSign(DateTime birthDate)
        {
            int month = birthDate.Month, day = birthDate.Day;

            if ((month == 3 && day >= 21) || (month == 4 && day <= 19)) return "Aries";
            if ((month == 4 && day >= 20) || (month == 5 && day <= 20)) return "Taurus";
            if ((month == 5 && day >= 21) || (month == 6 && day <= 21)) return "Gemini";
            if ((month == 6 && day >= 22) || (month == 7 && day <= 22)) return "Cancer";
            if ((month == 7 && day >= 23) || (month == 8 && day <= 22)) return "Leo";
            if ((month == 8 && day >= 23) || (month == 9 && day <= 22)) return "Virgo";
            if ((month == 9 && day >= 23) || (month == 10 && day <= 23)) return "Libra";
            if ((month == 10 && day >= 24) || (month == 11 && day <= 21)) return "Scorpio";
            if ((month == 11 && day >= 22) || (month == 12 && day <= 21)) return "Sagittarius";
            if ((month == 12 && day >= 22) || (month == 1 && day <= 19)) return "Capricorn";
            if ((month == 1 && day >= 20) || (month == 2 && day <= 18)) return "Aquarius";
            return "Pisces";
        }

        public static int CalculateAge(DateTime birthDate)
        {
            int age = DateTime.Today.Year - birthDate.Year;
            if (birthDate > DateTime.Today.AddYears(-age)) age--;
            return age;
        }
    }
}
