using System;
using System.Collections.Generic;
using System.Text;

namespace Lab
{
    public class HelpMethods
    {




        #region Birthdate

        public string GetBirthDateAsString()
        {
            var isCorrect = false;
            var birthDate = "";
            var x = 0;

            do
            {
                isCorrect = false;
                Console.Write("Enter birth date (6 numbers): ");

                birthDate = Console.ReadLine();

                if(int.TryParse(birthDate, out x))
                    isCorrect = true;
            } while(isCorrect == false || birthDate.Length != 6);

            return birthDate;
        }

        #endregion




        #region Random numbers

        public string GetTwoRandomNumbersAsString()
        {
            Random rand = new Random();
            int x = rand.Next(9);
            int y = rand.Next(9);
            return x.ToString() + y.ToString();
        }

        #endregion




        #region Gender numbers

        public string GetGenderNumberAsString()
        {
            Random random = new Random();
            string gender;
            bool isSet = false;

            do
            {
                Console.Write("Gender (Female = 0, Male = 1): ");
                gender = Console.ReadLine();

                if(gender == "1" || gender == "0")
                    isSet = true;

            } while(isSet == false);

            //Create female number
            if(Convert.ToInt32(gender) % 2 == 0)
            {
                int x;

                do
                {
                    x = random.Next(0, 9);

                } while(x % 2 == 1);

                gender = x.ToString();
            }

            //Create male number
            if(Convert.ToInt32(gender) % 2 == 1)
            {
                int x;

                do
                {
                    x = random.Next(0, 9);

                } while(x % 2 == 0);

                gender = x.ToString();
            }
            return gender;
        }

        #endregion




        #region Control number

        public string GetControlNumberAsString(string almostCompleteSSN)
        {
            var socialSecurityNumberMinusOne = "";
            var sumToControl = 0;
            var controlNumber = 0;

            for(int i = 0; i < almostCompleteSSN.Length; i++)
            {
                int part = Convert.ToInt32(almostCompleteSSN[i]) - 48;
                if(i % 2 == 0)
                    part = part * 2;
                socialSecurityNumberMinusOne += part.ToString();
            }

            foreach(var item in socialSecurityNumberMinusOne)
                sumToControl += Convert.ToInt32(item) - 48;

            controlNumber = sumToControl % 10 == 0 ? 0 : 10 - sumToControl % 10;

            return controlNumber.ToString();
        }

        #endregion




    }
}
