using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessAssistant_ZeynetdinovArtuhov_2ISP11_17.Classes
{
    public class Validation
    {
        //Пароль
        public static bool ValidationPassword(String Password)
        {
            if (Password.Length < 8 || Password.Length > 20)
                return false;

            if (!Password.Any(Char.IsUpper))
                return false;
            if (!Password.Any(Char.IsLower))
                return false;
            if (!Password.Any(Char.IsDigit))
                return false;
            if (!Password.Any(Char.IsPunctuation))
                return false;
            if (Password.Any(Char.IsWhiteSpace))
                return false;

            return true;
        }

        //Логин
        public static bool ValidationLogin(String Login)
        {
            if (Login.Length < 5 || Login.Length > 50)
                return false;

            if (!Login.Any(Char.IsUpper))
                return false;
            if (!Login.Any(Char.IsLower))
                return false;
            if (!Login.Any(Char.IsDigit))
                return false;
            if (!Login.Any(Char.IsPunctuation))
                return false;
            if (Login.Any(Char.IsWhiteSpace))
                return false;

            return true;
        }

        //Фамилия Имя и Отчество
        public static bool ValidationFullName(String FullName)
        {
            if (FullName.Length < 2 || FullName.Length > 50)
                return false;
            if (!FullName.Any(Char.IsLower))
                return false;
            if (!FullName.Any(Char.IsUpper))
                return false;
            if (FullName.Any(Char.IsDigit))
                return false;
            if (!FullName.Contains("-") && !FullName.Contains(" ") && FullName.Any(Char.IsWhiteSpace))
                return false;
            if (FullName.Contains("  ") || FullName.Contains("--"))
                return false;

            return true;
        }

        //рост и вес, только цифры и значения от 0 до 300, int and double
        public static bool ValidationWeightAndHeight(String WeightAndHeight)
        {
            if (WeightAndHeight.Length < 2 || WeightAndHeight.Length > 3 || Convert.ToDouble(WeightAndHeight) > 300 || Convert.ToDouble(WeightAndHeight) <= 0)
                return false;

            if (WeightAndHeight.Any(Char.IsUpper) || (WeightAndHeight.Any(Char.IsLower) || (WeightAndHeight.Any(Char.IsPunctuation) || (WeightAndHeight.Any(Char.IsWhiteSpace)))))
                return false;
            if (!WeightAndHeight.Any(Char.IsDigit))
                return false;
            if (WeightAndHeight.Contains(" "))
                return false;

            return true;
        }

        //BMI=вес/рост^2
        public static bool ValidationBMI(String BMI, String Weight, String Height)
        {
            if (BMI.Length < 1 || BMI.Length > 50)
                return false;
            if (Weight.Length < 1 || Weight.Length > 3)
                return false;
            if (Convert.ToInt32(Weight) < 11 || Convert.ToInt32(Weight) > 440)
                return false;
            if (Height.Length < 1 || Height.Length > 3)
                return false;
            if (Convert.ToInt32(Height) < 10 || Convert.ToInt32(Height) > 272)
                return false;

            if (BMI.Contains("-") || Weight.Contains("-") || Height.Contains("-"))
                return false;
            if (BMI.Contains("-") || Weight.Contains(" ") || Height.Contains(" "))
                return false;

            if (BMI.Any(Char.IsUpper))
                return false;
            if (BMI.Any(Char.IsLower))
                return false;
            if (!BMI.Any(Char.IsDigit))
                return false;
            if (!BMI.Any(Char.IsPunctuation))
                return false;

            if (Weight.Any(Char.IsUpper))
                return false;
            if (Weight.Any(Char.IsLower))
                return false;
            if (!Weight.Any(Char.IsDigit))
                return false;
            if (Weight.Any(Char.IsPunctuation))
                return false;

            if (Height.Any(Char.IsUpper))
                return false;
            if (Height.Any(Char.IsLower))
                return false;
            if (!Height.Any(Char.IsDigit))
                return false;
            if (Height.Any(Char.IsPunctuation))
                return false;

            return true;
        }

        public static bool ValidationBMR(String BMR, String Weight, String Height,String Age,String Gender)
        {
            if (BMR.Length < 1 || BMR.Length > 50)
                return false;
            if (Weight.Length < 1 || Weight.Length > 3)
                return false;
            if (Convert.ToInt32(Weight) < 1 || Convert.ToInt32(Weight) > 440)
                return false;
            if (Height.Length < 1 || Height.Length > 3)
                return false;
            if (Convert.ToInt32(Height) < 1 || Convert.ToInt32(Height) > 272)
                return false;
            if (Age.Length < 0 || Age.Length > 3)
                return false;
            if(Convert.ToInt32(Age) < 1 || Convert.ToInt32(Age) > 122)
                return false;
            if (Gender.Length < 0 || Gender.Length > 2)
                return false;
            if (Convert.ToInt32(Gender) < 0 || Convert.ToInt32(Gender) > 2)
                return false;

            if (BMR.Contains("-") || Weight.Contains("-") || Height.Contains("-") || Age.Contains("-") || Gender.Contains("-"))
                return false;
            if (BMR.Contains("-") || Weight.Contains(" ") || Height.Contains(" ") || Age.Contains(" ") || Gender.Contains(" "))
                return false;

            if (BMR.Any(Char.IsUpper))
                return false;
            if (BMR.Any(Char.IsLower))
                return false;
            if (!BMR.Any(Char.IsDigit))
                return false;
            if (!BMR.Any(Char.IsPunctuation))
                return false;

            if (Weight.Any(Char.IsUpper))
                return false;
            if (Weight.Any(Char.IsLower))
                return false;
            if (!Weight.Any(Char.IsDigit))
                return false;
            if (Weight.Any(Char.IsPunctuation))
                return false;

            if (Height.Any(Char.IsUpper))
                return false;
            if (Height.Any(Char.IsLower))
                return false;
            if (!Height.Any(Char.IsDigit))
                return false;
            if (Height.Any(Char.IsPunctuation))
                return false;

            if (Age.Any(Char.IsUpper))
                return false;
            if (Age.Any(Char.IsLower))
                return false;
            if (!Age.Any(Char.IsDigit))
                return false;
            if (Age.Any(Char.IsPunctuation))
                return false;

            if (Gender.Any(Char.IsUpper))
                return false;
            if (Gender.Any(Char.IsLower))
                return false;
            if (!Gender.Any(Char.IsDigit))
                return false;
            if (Gender.Any(Char.IsPunctuation))
                return false;

            return true;
        }
    }  
}