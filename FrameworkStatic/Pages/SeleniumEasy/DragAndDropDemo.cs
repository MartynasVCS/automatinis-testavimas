using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrameworkStatic.Pages.SeleniumEasy
{
    public class DragAndDropDemo
    {
        private static string url = "https://demo.seleniumeasy.com/drag-and-drop-demo.html";
        private static string draggable1LocatorXpath = "//*[text()='Draggable 1']";
        private static string draggable2LocatorXpath = "//*[text()='Draggable 2']";
        private static string targetLocatorXpath = "//*[@id='mydropzone']";
        private static string draggable1LocatorCss = "#todrag > span:nth-of-type(1)";
        private static string draggable2LocatorCss = "#todrag > span:nth-of-type(2)";
        private static string targetLocatorCss = "#mydropzone";
        private static string droppedListLocator = "//*[@id='droppedlist']/span";

        public static void Open()
        {
            Driver.OpenPage(url);
        }

        public static void DragDraggable1ToDropZoneJavascript()
        {
            Common.DragElementToTargetJavascript(draggable1LocatorCss, targetLocatorCss);
        }

        public static void DragDraggable1ToDropZoneActions()
        {
            Common.DragElementToTarget(draggable1LocatorXpath, targetLocatorXpath);
        }

        public static void DragDraggable2ToDropZoneJavascript()
        {
            Common.DragElementToTargetJavascript(draggable2LocatorCss, targetLocatorCss);
        }

        public static void DragDraggable2ToDropZoneActions()
        {
            Common.DragElementToTarget(draggable2LocatorXpath, targetLocatorXpath);
        }

        public static List<string> GetDroppedItemsList()
        {
            return Common.GetElementsTextList(droppedListLocator);
        }
    }
}
