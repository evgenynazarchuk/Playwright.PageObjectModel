using Microsoft.Playwright.MSTest;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UIPageModel.SampleRunTests;

[TestClass]
public class UnitTest2 : PageTest
{
    [TestMethod]
    [Priority(2)]
    [TestCategory("Stream 2")]
    [DoNotParallelize]
    [TestCategory("Chromium")]
    public void TestMethod1()
    {
    }

    [TestMethod]
    [Priority(2)]
    [TestCategory("Stream 2")]
    [DoNotParallelize]
    [TestCategory("Firefox")]
    public void TestMethod2()
    {
    }

    [TestMethod]
    [Priority(2)]
    [TestCategory("Stream 2")]
    [TestCategory("Webkit")]
    public void TestMethod3()
    {
    }

    [TestMethod]
    [Priority(2)]
    [TestCategory("Stream 2")]
    [TestCategory("Chromium")]
    [TestCategory("Firefox")]
    [TestCategory("Webkit")]
    public void TestMethod4()
    {
    }
}