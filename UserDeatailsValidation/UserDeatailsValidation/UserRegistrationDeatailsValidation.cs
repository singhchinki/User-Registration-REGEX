using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace UserDeatailsValidation
{
    public class RegexUserFirst_Name
    {
         const string NAME = "^[A-Z]{1}[a-z]{2,}$";
         public void FirstNameValidation(string firstName)
         {
            if (Regex.IsMatch(firstName, NAME))
            {
               Console.WriteLine("First name is valid. ");
               return;
            }
               Console.WriteLine("First name is not valid");
         }
    }
    
}

