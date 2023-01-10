using FrameworkStatic;
using FrameworkStatic.Pages.DemoQA;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestsStatic.DemoQA
{
    internal class DroppableTests
    {
        [SetUp]
        public void SetUp()
        {
            Driver.Initialize();
            Droppable.Open();
        }

        [Test]
        public void TestJavascript()
        {
            Droppable.DragDragMeToDropHereJavascript();
        }

        [Test]
        public void TestActions()
        {
            Droppable.DragDragMeToDropHereActions();
        }

        [TearDown]
        public void TearDown()
        {
            Driver.CloseDriver();
        }
    }
}
