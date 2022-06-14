using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace UserDeatailsValidation
{
    public class RegexUserDetails
    {
         const string NAME = "^[A-Z]{1}[a-z]{2,}$";
         const string EMAIL_ID = "^(abc).?[a-z]{3,}[@](bl).?(co).?[a-z]{2,}$";
         const string CONTACT = "^[0-9]{1,3}[ ][789][0-9]{9}$";
         const string PASSWORD = "^[A-Z]{1,}[a-z]{8,}[0-9]{1,}[~!@#$%^&*]{1,}?$";
         const string SAMPLE_MAIL = "^[a-z]+([._+-][0-9a-z]+)*[@][0-9a-z]+.[a-z]{2,3}(.[a-z]{2,3})?$";
        public bool FirstNameValidation(string FirstName)
         {
            if (Regex.IsMatch(FirstName, NAME))
            {
               Console.WriteLine("First name is valid. ");
               return true;
            }
               Console.WriteLine("First name is not valid");
            return false;
         }
        public bool LastNameValidation(string LastName)
        {
            if (Regex.IsMatch(LastName, NAME))
            {
                Console.WriteLine("Last name is valid. ");
                return true;
            }
            Console.WriteLine("Last name is not valid");
            return false;
        }
        public void EmailValidation(string Email)
        {
            if (Regex.IsMatch(Email, EMAIL_ID))
            {
                Console.WriteLine("Eamil ID is valid. ");
                return;
            }
            Console.WriteLine("Email ID is not valid");
        }
        public bool MobileValidation(string MobileNo)
        {
            if (Regex.IsMatch(MobileNo, CONTACT))
            {
                Console.WriteLine("Mobile number is valid. ");
                return true;
            }
            Console.WriteLine("Mobile  number is not valid");
            return false;
        }
        public bool PasswordValidation(string PassWord)
        {
            if (Regex.IsMatch(PassWord, PASSWORD))
            {
                Console.WriteLine("Password is valid. ");
                return true;
            }
            Console.WriteLine("Password is not valid");
               return false;
        }
        //-Uc-11-multiple email entry Validation
        public bool EmailSampleChecker(string Sample_Email)
        {
            if (Regex.IsMatch(Sample_Email, SAMPLE_MAIL))
            {
                Console.WriteLine("valid email" + Sample_Email);
                return true;
            }
            Console.WriteLine("Invalid email" + Sample_Email);
            return false;
        }
    }

    
}

