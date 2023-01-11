using FrameworkStatic;
using NUnit.Framework;
using NUnit.Framework.Interfaces;
using System;

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
            if (TestContext.CurrentContext.Result.Outcome != ResultState.Success)
            {
                Driver.TakeScreenshot(TestContext.CurrentContext.Test.FullName);
            }
            Driver.CloseDriver();
        }
    }
}
