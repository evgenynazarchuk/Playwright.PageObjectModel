using Microsoft.VisualStudio.TestTools.UnitTesting;
using Playwright.FluentAssertions;
using BingSearchTests.MSTest.Support;

namespace BingSearchTests.MSTest
{
    [TestClass]
    public class UnitTest1 : BingTest
    {
        [TestMethod]
        public void BingTitleWhenMainPage()
        {
            OpenMainPage()
                .Should().HaveTitle("Bing");
        }

        [TestMethod]
        public void BingTitleWhenSearchPlaywright()
        {
            OpenMainPage()
                .SearchBar.SearchByText("playwright")
                .Should().HaveTitle("playwright - Bing");
        }

        [TestMethod]
        public void BingTitleWhenSearchWindows()
        {
            OpenMainPage()
                .SearchBar.SearchByText("windows")
                .Should().HaveTitle("windows - Bing");
        }
    }
}