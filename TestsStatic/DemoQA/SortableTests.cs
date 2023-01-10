using FrameworkStatic.Pages.DemoQA;
using FrameworkStatic;
using NUnit.Framework;

namespace TestsStatic.DemoQA
{
    internal class SortableTests
    {
        [SetUp]
        public void SetUp()
        {
            Driver.Initialize();
            Sortable.Open();
        }

        [Test]
        public void DragTwoToOne()
        {
            Sortable.DragTwoToOne();
        }

        [TearDown]
        public void TearDown()
        {
            Driver.CloseDriver();
        }
    }
}
