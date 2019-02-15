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
            var birthDate = "";
            var randomNumbers = "";
            var gender = "";
            var socialSecurityNumber = "";

            while(true)
            {
                socialSecurityNumber = "";
                birthDate = helpMethods.GetBirthDateAsString();
                randomNumbers = helpMethods.GetTwoRandomNumbersAsString();
                gender = helpMethods.GetGenderNumberAsString();
                socialSecurityNumber = birthDate + "-" + randomNumbers + gender;
                socialSecurityNumber += helpMethods.GetControlNumberAsString(socialSecurityNumber);

                if(!hs.Add(socialSecurityNumber))
                {
                    randomNumbers = helpMethods.GetTwoRandomNumbersAsString();
                    socialSecurityNumber = birthDate + "-" + randomNumbers + gender;
                    socialSecurityNumber += helpMethods.GetControlNumberAsString(socialSecurityNumber);
                }

                Console.Clear();
                Console.WriteLine($"The social security number will be: {socialSecurityNumber}");
                Console.WriteLine("\nThe list of social security numbers: ");
                foreach(var item in hs)
                    Console.WriteLine(item);
                Console.WriteLine();
            }
        }
    }
}