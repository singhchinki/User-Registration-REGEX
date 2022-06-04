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

    }

    
}

