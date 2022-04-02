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

        if (Password.Length <8 || Password.Length >20)
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

            if (Login.Length < 1 || Login.Length > 50)
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

            if (WeightAndHeight.Length <2 || WeightAndHeight.Length > 3 || Convert.ToDouble(WeightAndHeight)>300 || Convert.ToDouble(WeightAndHeight) <=0)
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
        public static bool ValidationBMI(String BMI)

        {

            if (BMI.Length < 1 || BMI.Length > 80)
                return false;

            if (BMI.Any(Char.IsUpper))
                return false;
            if (BMI.Any(Char.IsLower))
                return false;
            if (!BMI.Any(Char.IsDigit))
                return false;
            if (BMI.Any(Char.IsPunctuation))
                return false;
            if (BMI.Any(Char.IsWhiteSpace))
                return false;

            return true;
        }

    }
    
}