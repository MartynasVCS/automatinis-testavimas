using FrameworkStatic;
using FrameworkStatic.Pages.SeleniumEasy;
using NUnit.Framework;
using System.Collections.Generic;

namespace TestsStatic.SeleniumEasy
{
    internal class DragAndDropDemoTests
    {
        [SetUp]
        public void SetUp()
        {
            Driver.Initialize();
            DragAndDropDemo.Open();
        }

        [Test]
        public void TestDragAndDropJavascript()
        {
            DragAndDropDemo.DragDraggable1ToDropZoneJavascript();
            DragAndDropDemo.DragDraggable2ToDropZoneJavascript();

            List<string> resultsList = DragAndDropDemo.GetDroppedItemsList();

            Assert.Contains("Draggable 1", resultsList);
            Assert.Contains("Draggable 2", resultsList);
        }

        [Test]
        public void TestDragAndDropActions()
        {
            DragAndDropDemo.DragDraggable1ToDropZoneActions();
            DragAndDropDemo.DragDraggable2ToDropZoneActions();

            List<string> resultsList = DragAndDropDemo.GetDroppedItemsList();

            Assert.Contains("Draggable 1", resultsList);
            Assert.Contains("Draggable 2", resultsList);
        }

        [TearDown]
        public void TearDown()
        {
            Driver.CloseDriver();
        }
    }
}
