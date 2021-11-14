using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.Playwright;
using Microsoft.Playwright.MSTest;
using System.Threading.Tasks;
using System;

namespace UIPageModel.SampleRunTests;

[TestClass]
public class UnitTest3 : PageTest
{
    public static int Count = 0;

    [UITestMethod]
    [RetryOnError(2)]
    
    public void TestMethod1()
    {
        Task.Delay(5000).GetAwaiter().GetResult();

        if (Count == 0)
        {
            Count++;
            throw new ApplicationException();
        }
    }
}