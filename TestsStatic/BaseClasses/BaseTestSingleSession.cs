using FrameworkStatic;
using NUnit.Framework;

namespace TestsStatic.BaseClasses
{
    /// <summary>
    /// Ši bazinė klasė leidžia panaudoti tą pačia naršyklės sesiją keliems testams
    /// </summary>
    internal class BaseTestSingleSession
    {
        [OneTimeSetUp]
        public virtual void SetUp()
        {
            Driver.Initialize();
        }

        [OneTimeTearDown]
        public virtual void TearDown()
        {
            Driver.CloseDriver();
        }
    }
}
