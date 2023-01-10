namespace FrameworkStatic.Pages.Facebook
{
    public class Login
    {
        public static void Open()
        {
            Driver.OpenPage("https://www.facebook.com/");
        }
        public static void CloseCookies()
        {
            Common.ClickElement("//*[@data-testid='cookie-policy-manage-dialog-accept-button']");
        }

        public static void InputEmail(string v)
        {
            Common.SendKeysToElement("//*[@id='email']", v);
        }

        public static void InputPassword(string v)
        {
            Common.SendKeysToElement("//*[@id='pass']", v);
        }
        public static void ClickLogin()
        {
            Common.ClickElement("//*[@data-testid='royal_login_button']");
        }

        public static void CheckThatWhatsOnYourMindElementExists(string whatsOnYourMindText)
        {
            Common.WaitForElementWithText(whatsOnYourMindText);
        }
    }
}
