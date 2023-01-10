using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrameworkStatic.Pages.DemoQA
{
    public class Droppable
    {
        public static void Open()
        {
            Driver.OpenPage("https://demoqa.com/droppable");
        }

        public static void DragDragMeToDropHereJavascript()
        {
            Common.DragElementToTargetJavascript("#draggable", "#droppable");
        }

        public static void DragDragMeToDropHereActions()
        {
            Common.DragElementToTarget("//*[@id='draggable']", "//*[@id='droppable']");
        }
    }
}
