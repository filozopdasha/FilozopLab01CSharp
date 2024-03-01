using System;

namespace FilozopLab01.Models
{
    public class CountingBirthday
    {
        private DateTime _birthday;
        private readonly string[] chineseZodiacSign = new string[]
        {
            "Monkey", 
            "Rooster", 
            "Dog",    
            "Pig",    
            "Rat",     
            "Ox",      
            "Tiger",   
            "Rabbit",  
            "Dragon",  
            "Snake",   
            "Horse",   
            "Goat"
        };

        public DateTime Date
        {
            get { return _birthday; }
            set { _birthday = value; }
        }

        public int CountUserAge()
        {
            var currentDate = DateTime.Today;
            int age = currentDate.Year - _birthday.Year;

            if (currentDate.Month < _birthday.Month || (currentDate.Month == _birthday.Month && currentDate.Day < _birthday.Day))
            {
                age--;
            }

            return age;
        }

        public bool ValidationOfDate()
        {
            var userAge = CountUserAge();
            var currentDate = DateTime.Today;

            if (_birthday > currentDate || userAge < 0 || userAge > 135)
            {
                return false;
            }

            return true;
        }

        public string CountUserAgeWithValidation()
        {
            var currentDate = DateTime.Today;
            int age = currentDate.Year - _birthday.Year;

            if (currentDate.Month < _birthday.Month ||
                (currentDate.Month == _birthday.Month && currentDate.Day < _birthday.Day))
            {
                age--;
            }

            if (age < 0)
            {
                return "You're too young!";
            }
            else if (age > 135)
            {
                return "You're too old!";
            }
            else
            {
                return $"Your current age is: {age}";
            }
        }
        public Boolean TodayIsBirthday()
        {
            return _birthday.Month == DateTime.Today.Month && _birthday.Day == DateTime.Today.Day;
        }

        public string ZodiacChinese()
        {
            var bdayYear = _birthday.Year;
            return chineseZodiacSign[bdayYear % 12];
        }

        public string WesternZodiacSign()
        {
            int month = _birthday.Month;
            int day = _birthday.Day;

            if ((month == 1 && day <= 19) || (month == 12 && day >= 22))
            {
                return "Capricorn";
            }
            else if ((month == 1 && day >= 20) || (month == 2 && day <= 18))
            {
                return "Aquarius";
            }
            else if ((month == 2 && day >= 19) || (month == 3 && day <= 20))
            {
                return "Pisces";
            }
            else if ((month == 3 && day >= 21) || (month == 4 && day <= 19))
            {
                return "Aries";
            }
            else if ((month == 4 && day >= 20) || (month == 5 && day <= 20))
            {
                return "Taurus";
            }
            else if ((month == 5 && day >= 21) || (month == 6 && day <= 20))
            {
                return "Gemini";
            }
            else if ((month == 6 && day >= 21) || (month == 7 && day <= 22))
            {
                return "Cancer";
            }
            else if ((month == 7 && day >= 23) || (month == 8 && day <= 22))
            {
                return "Leo";
            }
            else if ((month == 8 && day >= 23) || (month == 9 && day <= 22))
            {
                return "Virgo";
            }
            else if ((month == 9 && day >= 23) || (month == 10 && day <= 22))
            {
                return "Libra";
            }
            else if ((month == 10 && day >= 23) || (month == 11 && day <= 21))
            {
                return "Scorpio";
            }
            else if ((month == 11 && day >= 22) || (month == 12 && day <= 21))
            {
                return "Sagittarius";
            }
            else
            {
                return "Unknown";
            }
        }
    }
}
