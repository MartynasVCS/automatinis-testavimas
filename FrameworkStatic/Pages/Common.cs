using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.Extensions;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System;
using System.Collections.Generic;
using System.Linq;

namespace FrameworkStatic.Pages
{
    internal class Common
    {
        private static IWebElement GetElement(string locator)
        {
            return Driver.GetDriver().FindElement(By.XPath(locator));
        }

        internal static List<IWebElement> GetElements(string locator)
        {
            return Driver.GetDriver().FindElements(By.XPath(locator)).ToList();
        }

        internal static void ClickElement(string locator)
        {
            GetElement(locator).Click();
        }

        internal static void SendKeysToElement(string locator, string keys)
        {
            GetElement(locator).SendKeys(keys);
        }

        internal static string GetElementText(string locator)
        {
            return GetElement(locator).Text;
        }

        internal static string GetAttributeValue(string locator, string attributeName)
        {
            return GetElement(locator).GetAttribute(attributeName);
        }

        internal static void ClearInputElement(string locator)
        {
            GetElement(locator).Clear();
        }

        internal static void ClickMultipleElements(string locator)
        {
            List<IWebElement> elements = GetElements(locator);

            foreach (IWebElement element in elements)
            {
                element.Click();
            }
        }

        internal static bool GetElementSelectedStatus(string locator)
        {
            return GetElement(locator).Selected;
        }

        internal static List<bool> GetMultipleElementSelectedStatus(string locator)
        {
            List<IWebElement> elements = GetElements(locator);
            List<bool> statuses = new List<bool>();

            foreach (IWebElement element in elements)
            {
                statuses.Add(element.Selected);
            }

            return statuses;
        }

        internal static void WaitForElementToBeClickable(string locator)
        {
            WebDriverWait wait = new WebDriverWait(Driver.GetDriver(), TimeSpan.FromSeconds(10));
            wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath(locator)));
        }

        internal static void WaitForElementAttributeToContainValue(string locator, string attributeName, string value)
        {
            WebDriverWait wait = new WebDriverWait(Driver.GetDriver(), TimeSpan.FromSeconds(10));
            wait.Until(driver => driver.FindElement(By.XPath(locator)).GetAttribute(attributeName).Contains(value));
        }

        internal static void WaitForElementToBeVisible(string locator)
        {
            WebDriverWait wait = new WebDriverWait(Driver.GetDriver(), TimeSpan.FromSeconds(10));
            wait.Until(ExpectedConditions.ElementIsVisible(By.XPath(locator)));
        }

        internal static bool GetElementEnabledStatus(string locator)
        {
            return GetElement(locator).Enabled;
        }

        internal static void LeftClickElement(string locator)
        {
            IWebElement element = GetElement(locator);
            Actions actions = new Actions(Driver.GetDriver());

            actions.Click(element);
            actions.Perform();
        }

        internal static void DoubleClickElement(string locator)
        {
            IWebElement element = GetElement(locator);
            Actions actions = new Actions(Driver.GetDriver());

            actions.DoubleClick(element);
            actions.Perform();
        }

        internal static void RightClickElement(string locator)
        {
            IWebElement element = GetElement(locator);
            Actions actions = new Actions(Driver.GetDriver());

            actions.ContextClick(element);
            actions.Perform();
        }

        private static SelectElement GetSelectElement(string locator)
        {
            IWebElement element = GetElement(locator);
            return new SelectElement(element);
        }

        internal static void SelectOptionByValue(string selectElementLocator, string value)
        {
            SelectElement selectElement = GetSelectElement(selectElementLocator);
            selectElement.SelectByValue(value);
        }

        internal static void SelectOptionByText(string selectElementLocator, string optionText)
        {
            SelectElement selectElement = GetSelectElement(selectElementLocator);
            selectElement.SelectByText(optionText);
        }

        internal static string GetSelectedOptionText(string selectElementLocator)
        {
            SelectElement selectElement = GetSelectElement(selectElementLocator);
            return selectElement.SelectedOption.Text;
        }
    }
}