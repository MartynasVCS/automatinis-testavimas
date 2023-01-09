namespace FrameworkStatic.Pages.SeleniumEasy
{
    public class BasicSelectDropdownDemo
    {
        private static string url = "https://demo.seleniumeasy.com/basic-select-dropdown-demo.html";
        private static string selectElementLocator = "//*[@id='select-demo']";
        private static string messageWeekDayLocator = "//*[@class='selected-value']";

        public static void Open()
        {
            Driver.OpenPage(url);
        }

        public static void SelectWeekday(string weekDay)
        {
            Common.SelectOptionByValue(selectElementLocator, weekDay);
        }

        public static string GetDaySelectedMessage()
        {
            return Common.GetElementText(messageWeekDayLocator);
        }
    }
}