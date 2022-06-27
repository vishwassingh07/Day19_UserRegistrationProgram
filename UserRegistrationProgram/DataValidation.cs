﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace UserRegistrationProgram
{
    public class DataValidation
    {
        public Regex First_Name_Regex = new Regex(@"^[A-Z]{1}[A-Za-z]{2,}?$");
        public void ValidateFirstName()
        {
            Console.Write("Enter First Name : ");
            string firstName = Console.ReadLine();

            if (First_Name_Regex.IsMatch(firstName))
            {
                Console.WriteLine("The First Name Is Valid ");
            }
            else
            {
                Console.WriteLine("The First Name Is Not Valid");
            }
        }
    }
}
