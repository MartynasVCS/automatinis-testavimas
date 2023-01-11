using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.Extensions;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System;
using System.Collections.Generic;
using System.IO;
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

        internal static void DragElementToTargetJavascript(string sourceCssLocator, string targetCssLocator)
        {
            string currentDir = Directory.GetCurrentDirectory();
            string solutionDir = Directory.GetParent(currentDir).Parent.Parent.FullName;
            string javascriptFilePath = $"{solutionDir}/FrameworkStatic/Javascript/drag-and-drop.js";
            string jqueryFilePath = $"{solutionDir}/FrameworkStatic/Javascript/jquery-3.6.3.min.js";
            string javascriptFile = File.ReadAllText(javascriptFilePath);
            string jqueryFile = File.ReadAllText(jqueryFilePath);
            string javascriptCode = $"{jqueryFile}{javascriptFile}$('{sourceCssLocator}').simulateDragDrop({{dropTarget: '{targetCssLocator}'}});";
            
            Driver.GetDriver().ExecuteJavaScript(javascriptCode);
        }

        internal static void DragElementToTarget(string sourceLocator, string targetLocator)
        {
            IWebElement source = GetElement(sourceLocator);
            IWebElement target = GetElement(targetLocator);
            Actions actions = new Actions(Driver.GetDriver());

            actions.ClickAndHold(source);
            actions.MoveToElement(target);
            actions.Release();
            actions.Perform();
        }

        internal static List<string> GetElementsTextList(string locator)
        {
            List<string> elementsText = new List<string>();
            List<IWebElement> elements = Common.GetElements(locator);
            foreach(IWebElement element in elements)
            {
                elementsText.Add(element.Text);
            }
            return elementsText;
        }

        internal static void SelectMultipleOptionsByText(string selectElementLocator, List<string> optionTextList)
        {
            SelectElement selectElement = GetSelectElement(selectElementLocator);
            foreach(string optionText in optionTextList)
            {
                selectElement.SelectByText(optionText);
            }
        }

        internal static void SelectMultipleOptionsByTextUsingActions(string selectElementLocator, List<string> optionElementLocatorList)
        {
            IWebElement selectElement = GetElement(selectElementLocator);

            // Iš lokatorių sąrašo 'pasigaminame' elementų sąrašą
            List<IWebElement> optionElements = new List<IWebElement>();
            foreach (string optionLocator in optionElementLocatorList)
            {
                optionElements.Add(GetElement(optionLocator));
            }

            // Atliekame elementų pažymėjimą
            Actions actions = new Actions(Driver.GetDriver());
            actions.ScrollToElement(selectElement); // Turime 'nuscrolinti' prie select elemento (kažkodėl), kad būtų atvaizduota ir pirma reikšmė
            actions.KeyDown(Keys.Control);
            foreach (IWebElement element in optionElements)
            {
                actions.Click(element);
            }
            actions.Perform();
        }

        internal static void AcceptAlert()
        {
            Driver.GetDriver().SwitchTo().Alert().Accept();
        }

        internal static string GetAlertText()
        {
            return Driver.GetDriver().SwitchTo().Alert().Text;
        }

        internal static void DismissAlert()
        {
            Driver.GetDriver().SwitchTo().Alert().Dismiss();
        }

        internal static void SendKeysToAlert(string keys)
        {
            Driver.GetDriver().SwitchTo().Alert().SendKeys(keys);
        }

        internal static bool CheckIfElementIsPresent(string locator)
        {
            try
            {
                GetElement(locator);
                return true;
            }
            catch (NoSuchElementException)
            {
                return false;
            }
        }

        internal static bool CheckIfAlertIsPresent()
        {
            try
            {
                Driver.GetDriver().SwitchTo().Alert();
                return true;
            }
            catch (NoAlertPresentException)
            {
                return false;
            }
        }

        internal static void WaitForAlertToBePresent()
        {
            WebDriverWait wait = new WebDriverWait(Driver.GetDriver(), TimeSpan.FromSeconds(10));
            wait.Until(ExpectedConditions.AlertIsPresent());
        }

        internal static void WaitForElementWithText(string text)
        {
            WebDriverWait wait = new WebDriverWait(Driver.GetDriver(), TimeSpan.FromSeconds(20));

            // diskusija apie stale element exception ir sprendimas: https://stackoverflow.com/a/41502474/4054411
            wait.IgnoreExceptionTypes(typeof(StaleElementReferenceException));
            wait.Until(ExpectedConditions.TextToBePresentInElementLocated(By.XPath("//*"), text));
        }

        internal static string GetCurrentWindowHandle()
        {
            return Driver.GetDriver().CurrentWindowHandle;
        }

        internal static List<string> GetWindowHandles()
        {
            return Driver.GetDriver().WindowHandles.ToList();
        }

        internal static void SwitchToWindowByHandle(string handle)
        {
            Driver.GetDriver().SwitchTo().Window(handle);
        }

        internal static void SwitchToNewWindowFromParentWindowByHandle(string parentWindowHandle)
        {
            List<string> handles = GetWindowHandles();
            foreach (string handle in handles)
            {
                if (handle != parentWindowHandle)
                {
                    SwitchToWindowByHandle(handle);
                    break;
                }
            }
        }
    }
}