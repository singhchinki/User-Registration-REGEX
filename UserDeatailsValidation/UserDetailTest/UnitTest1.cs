 
namespace UserDetailTest
{
    public class Tests
    {

        [Test]
        public void GivenFirstName_CheckRegexPattern_ReturnTrue()
        {
            string FirstName = "chinki";
            UserDeatailsValidation.RegexUserDetails check = new UserDeatailsValidation.RegexUserDetails();
            bool actualResult = check.FirstNameValidation(FirstName);
            Assert.IsTrue(actualResult);
        }
        [Test]
        public void GivenLastName_CheckRegexPattern_ReturnTrue()
        {
            string LastName = "singh";
            UserDeatailsValidation.RegexUserDetails check = new UserDeatailsValidation.RegexUserDetails();
            bool actualResult = check.LastNameValidation(LastName);
            Assert.IsTrue(actualResult);
        }
        [Test]
        public void GivenMailId_CheckRegexPattern_Return()
        {
            string Sample_Email = "Chinki.singh@gmail.com";
            UserDeatailsValidation.RegexUserDetails check = new UserDeatailsValidation.RegexUserDetails();
            bool actualRresult = check.EmailSampleChecker(Sample_Email);
            Assert.IsTrue(actualRresult);

        }
        public void GivenMobileNo_CheckRegexPattern_Return()
        {
            string MobileNo = "91 7566752725";
            UserDeatailsValidation.RegexUserDetails check = new UserDeatailsValidation.RegexUserDetails();
            bool actualResult = check.MobileValidation(MobileNo);
            Assert.IsTrue(actualResult);
        }
        public void GivenPassword_CheckRegexPattern_Return()
        {
            string Password = "Chinki@1994";
            UserDeatailsValidation.RegexUserDetails check = new  UserDeatailsValidation.RegexUserDetails();
            bool actualResult = check.PasswordValidation(Password);
            Assert.IsTrue(actualResult);


        }
    }
}