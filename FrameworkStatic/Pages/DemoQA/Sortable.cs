namespace FrameworkStatic.Pages.DemoQA
{
    public class Sortable
    {
        public static void Open()
        {
            Driver.OpenPage("https://demoqa.com/sortable");
        }

        public static void DragTwoToOne()
        {
            Common.DragElementToTarget("//*[text()='Two']", "//*[text()='One']");
        }
    }
}
