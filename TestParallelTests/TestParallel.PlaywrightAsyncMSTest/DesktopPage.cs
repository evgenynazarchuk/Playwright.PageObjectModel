using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.Playwright.MSTest;

namespace TestParallel.PlaywrightAsyncMSTest;

public class DesktopPage : PageTest
{
    public DesktopPage()
        : base() { }

    [TestInitialize]
    public void Init()
    {
        Page.SetDefaultNavigationTimeout(300 * 1000);
        Page.SetDefaultTimeout(300 * 1000);
    }
}
