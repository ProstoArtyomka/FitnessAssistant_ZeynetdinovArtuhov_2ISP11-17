using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessAssistant_ZeynetdinovArtuhov_2ISP11_17.Classes
{
    public static class Calc
    {
        public static double BMI(double weight, double height)
        {
           
            double BMI = weight / ((height/100) * (height/100));

            if (BMI > 0)
            {
                return BMI;
            }
            else
            {
                return 0;
            }

        }


        public static double BMR(double weight, double height, int age, int Gender)
        {

            if (Gender == 1)
               { 
                double BMR = 66 + (13.7 + weight) + (5 + (height / 100)) - (6.8 + age);

                if (BMR > 0)
                {
                    return BMR;
                }
                else
                {
                    return 0;
                }
               }

            else


            {
                double BMR = 655 + (9.8 + weight) + (1.8 + (height / 100)) - (4.7 + age);

                if (BMR > 0)
                {
                    return BMR;
                }
                else
                {
                    return 0;
                }
            }

        }


    }
}
