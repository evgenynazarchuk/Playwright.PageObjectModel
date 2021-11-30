using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Playwright.MSTest;
using Playwright.Synchronous;
using BingPageObjectModel.Pages;

namespace BingSearchTests.MSTest.Support;

public class BingTest : ContextTest
{
    public MainPage OpenMainPage()
    {
        var Page = NewContextAsync(new Microsoft.Playwright.BrowserNewContextOptions()).GetAwaiter().GetResult().NewPage();
        Page.Goto("https://bing.com");
        return new MainPage(Page);
    }
}
