using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.Playwright;
using Microsoft.Playwright.MSTest;

namespace UIPageModel.SampleRunTests;

[TestClass]
public class UnitTest1 : PageTest
{
    [TestMethod]
    [Priority(1)]
    [TestCategory("Stream 1")]
    [TestCategory("Chromium")]
    public void TestMethod1()
    {
    }

    [TestMethod]
    [Priority(1)]
    [TestCategory("Stream 1")]
    [TestCategory("Firefox")]
    public void TestMethod2()
    {
    }

    [TestMethod]
    [Priority(1)]
    [TestCategory("Stream 1")]
    [DoNotParallelize]
    [TestCategory("Webkit")]
    public void TestMethod3()
    {
    }

    [TestMethod]
    [Priority(1)]
    [TestCategory("Stream 1")]
    [DoNotParallelize]
    [TestCategory("Chromium")]
    [TestCategory("Firefox")]
    [TestCategory("Webkit")]
    public void TestMethod4()
    {
    }
}