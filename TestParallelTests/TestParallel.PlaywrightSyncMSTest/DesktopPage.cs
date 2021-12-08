using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.Playwright.MSTest;

namespace TestParallel.PlaywrightSyncMSTest;

public class DesktopPage : PageTest
{
    public DesktopPage()
        : base() { }

    [TestInitialize]
    public void Init()
    {
        Page.SetDefaultNavigationTimeout(120 * 1000);
        Page.SetDefaultTimeout(300 * 1000);
    }
}
