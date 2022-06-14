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

Console.WriteLine("Enter Password");
string PassWord = Console.ReadLine();
UserDeatailsValidation.RegexUserDetails User_Password = new UserDeatailsValidation.RegexUserDetails();
User_Password.PasswordValidation(PassWord);

Console.WriteLine("\nSample Emails Validation:\n");
string[] Sample_Email = File.ReadAllLines(@"D:\BridgeLabzFellowship\User-Registration-REGEX\UserDeatailsValidation\SampleEmail.txt");
UserDeatailsValidation.RegexUserDetails Sample_Email_Id = new UserDeatailsValidation.RegexUserDetails();
for (int i = 0; i < Sample_Email.Length; i++)
{
    bool Emails = Sample_Email_Id.EmailSampleChecker(Sample_Email[i]);
    Console.WriteLine(Sample_Email[i] + " " + Emails);
}