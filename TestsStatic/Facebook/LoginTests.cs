using FrameworkStatic;
using FrameworkStatic.Pages.Facebook;
using NUnit.Framework;

namespace TestsStatic.Facebook
{
    internal class LoginTests
    {
        [SetUp]
        public void SetUp()
        {
            Driver.Initialize();
            Login.Open();
            Login.CloseCookies();
        }

        [Test]
        public void LoginTest()
        {
            string userEmail = "email";
            string userPassword = "password";
            string userName = "username";
            string expectedText = $"What's on your mind, {userName}?";
            Login.InputEmail(userEmail);
            Login.InputPassword(userPassword);
            Login.ClickLogin();
            Login.CheckThatWhatsOnYourMindElementExists(expectedText);
        }

        [TearDown]
        public void TearDown()
        {
            //Driver.CloseDriver();
        }

    }
}
