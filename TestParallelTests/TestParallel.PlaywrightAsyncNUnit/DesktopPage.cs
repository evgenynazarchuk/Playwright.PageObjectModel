using NUnit.Framework;
using Microsoft.Playwright.NUnit;

namespace TestParallel.PlaywrightAsyncNUnit;

public class DesktopPage : PageTest
{
    public DesktopPage()
        : base() { }

    [SetUp]
    public void Init()
    {
        Page.SetDefaultNavigationTimeout(300 * 1000);
        Page.SetDefaultTimeout(300 * 1000);
    }
}
