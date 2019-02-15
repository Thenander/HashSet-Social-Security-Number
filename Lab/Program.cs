using System;
using System.Collections.Generic;

namespace Lab
{
    class Program
    {
        static void Main(string[] args)
        {
            HelpMethods helpMethods = new HelpMethods();
            HashSet<string> hs = new HashSet<string>();
            var birthDate = "720611";
            var randomNumbers = "";
            var gender = 0;
            var socialSecurityNumber = "";

            while(true)
            {
                socialSecurityNumber = "";
                //birthDate = helpMethods.GetBirthDateAsString();
                randomNumbers = helpMethods.GetTwoRandomNumbersAsString();
                //gender = helpMethods.GetGenderNumber();
                socialSecurityNumber = birthDate + randomNumbers + gender.ToString();
                socialSecurityNumber += helpMethods.GetControlNumberAsString(socialSecurityNumber);

                while(!hs.Add(socialSecurityNumber))
                {
                    randomNumbers = helpMethods.GetTwoRandomNumbersAsString();
                    //gender = gender % 2 == 0 ? helpMethods.GenerateFemaleRandomNumber() : helpMethods.GenerateMaleRandomNumber();
                    socialSecurityNumber = birthDate + randomNumbers + gender.ToString();
                    socialSecurityNumber += helpMethods.GetControlNumberAsString(socialSecurityNumber);
                }

                Console.Clear();
                Console.WriteLine($"The social security number will be: {socialSecurityNumber.Insert(6, "-")}");
                Console.WriteLine("\nThe list of social security numbers: ");
                foreach(var item in hs)
                    Console.WriteLine(item.Insert(6, "-"));
                Console.WriteLine();
            }
        }
    }
}