﻿using System;
namespace UserRegistrationProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the User Registration Program\n========================================");
            DataValidation validating = new DataValidation();
            bool end = true;
            Console.WriteLine("1. Validate First Name\n2. Validate Last Name\n3. Validate Email\n4. " +
                "Validate Phone Number\n5. Validate Password With Rule 1\n6. Validate Password With Rule 2\n7." +
                " Validate Password With Rule 3\n8. Validate Password With Rule 4\n9. End The Program");
            while (end)
            {
                Console.Write("Choose an option to execute : ");
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:                       
                        validating.ValidateFirstName();
                        break;
                    case 2:
                        validating.ValidateLastName();
                        break;
                    case 3:
                        validating.ValidateEmail("abc.xyz@bl.co.in");
                        validating.ValidateEmail("abc111@abc.com");
                        validating.ValidateEmail("abc@bl.co");
                        validating.ValidateEmail("abc1232.com");
                        break;
                    case 4:
                        validating.ValidatePhoneNumber();
                        break;
                    case 5:
                        PasswordRules validate = new PasswordRules();
                        validate.ValidatePassword();                       
                        break;
                    case 6:
                        PasswordRules validate2 = new PasswordRules();
                        validate2.ValidatePassword2();
                        break;
                    case 7:
                        PasswordRules validate3 = new PasswordRules();
                        validate3.ValidatePassword3();
                        break;
                    case 8:
                        PasswordRules validate4 = new PasswordRules();
                        validate4.ValidatePassword4();
                        break;
                    case 9:
                        end = false;
                        break;
                    default:
                        Console.WriteLine("Please choose correct option");
                        break;
                }
            }
        }
    }
}