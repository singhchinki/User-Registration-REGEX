UserDeatailsValidation.RegexUserDetails userFirst_Name = new UserDeatailsValidation.RegexUserDetails();
userFirst_Name.FirstNameValidation("Chinki");
UserDeatailsValidation.RegexUserDetails userLast_Name = new UserDeatailsValidation.RegexUserDetails();
userLast_Name.LastNameValidation("Singh");

Console.WriteLine("Enter Email Id");
string Email = Console.ReadLine();
UserDeatailsValidation.RegexUserDetails Email_Id = new UserDeatailsValidation.RegexUserDetails();
Email_Id.EmailValidation(Email);

Console.WriteLine("Enter Mobile Number");
string MobileNo = Console.ReadLine();
UserDeatailsValidation.RegexUserDetails MobileNo_Number = new UserDeatailsValidation.RegexUserDetails();
MobileNo_Number.MobileValidation(MobileNo);

