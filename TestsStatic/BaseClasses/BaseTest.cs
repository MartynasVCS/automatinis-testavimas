using FrameworkStatic;
using NUnit.Framework;

namespace TestsStatic.BaseClasses
{
    internal class BaseTest
    {
        [SetUp]
        public virtual void SetUp()
        {
            Driver.Initialize();
        }

        [TearDown]
        public virtual void TearDown()
        {
            Driver.CloseDriver();
        }
    }
}
