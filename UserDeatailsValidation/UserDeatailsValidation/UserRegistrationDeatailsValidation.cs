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
         const string Mobile_no = "^[0-9]{1,3}[ ][789][0-9]{9} $";
        public void FirstNameValidation(string FirstName)
         {
            if (Regex.IsMatch(FirstName, NAME))
            {
               Console.WriteLine("First name is valid. ");
               return;
            }
               Console.WriteLine("First name is not valid");
         }
        public void LastNameValidation(string LastName)
        {
            if (Regex.IsMatch(LastName, NAME))
            {
                Console.WriteLine("Last name is valid. ");
                return;
            }
            Console.WriteLine("Last name is not valid");
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
    }

    
}

