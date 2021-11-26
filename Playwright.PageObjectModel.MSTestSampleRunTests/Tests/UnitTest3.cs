using Microsoft.Playwright.MSTest;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Threading.Tasks;

namespace Playwright.PageObjectModel.MSTestSampleTests;

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