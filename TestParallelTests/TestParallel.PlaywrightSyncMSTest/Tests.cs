using Microsoft.VisualStudio.TestTools.UnitTesting;
using Playwright.Synchronous;
using TestParallel.ActionExtensions;
using Microsoft.Playwright;
using TestParallel.PlaywrightSyncMSTest.Support;

namespace TestParallel.PlaywrightSyncMSTest;

[TestClass]
public class Tests : DesktopPage
{
    [UITest]
    [RestartOnException(3)]
    public void TestMethod1()
    {
        // Act
        Page.Goto("https://www.google.com/?hl=en");
        Page.WaitForLoadState(LoadState.NetworkIdle);

        // Assert
        var title = Page.Title();
        Assert.AreEqual("Google", title);   

        // Act
        Page.Type("div+input[name='q']", "wikipedia");
        Page.Press("div+input[name='q']", "Enter");
        Page.WaitForLoadState(LoadState.NetworkIdle);

        // Assert
        title = Page.Title();
        Assert.AreEqual("wikipedia - Google Search", title);

        // Arrange
        var searchInputElement = Page.QuerySelector("div+input[name='q']");
        var inputValue = Page.Evaluate<string>("(e) => e.value", searchInputElement);
        var inputLength = inputValue.Length;

        Page.Focus("div+input[name='q']");
        Page.Keyboard.Press("End");
        for (var i = 0; i < inputLength; i++)
        {
            Page.Keyboard.Press("Backspace");
        }

        // Act
        Page.Type("div+input[name='q']", "archive");
        Page.Press("div+input[name='q']", "Enter");
        Page.WaitForLoadState(LoadState.NetworkIdle);

        // Assert
        title = Page.Title();
        Assert.AreEqual("archive - Google Search", title);
    }

    [UITest]
    [RestartOnException(3)]
    public void TestMethod2()
    {
        // Act
        Page.OpenSearchPage();

        // Assert
        var title = Page.Title();
        Assert.AreEqual("Google", title);

        // Act
        Page.SearchByText("wikipedia");

        // Assert
        title = Page.Title();
        Assert.AreEqual("wikipedia - Google Search", title);

        // Arrange
        Page.ClearSearchText();

        // Act
        Page.SearchByText("archive");

        // Assert
        title = Page.Title();
        Assert.AreEqual("archive - Google Search", title);
    }

    [UITest]
    [RestartOnException(3)]
    public void TestMethod3()
    {
        // Act
        Page.OpenSearchPage();

        // Assert
        var title = Page.Title();
        Assert.AreEqual("Google", title);

        // Act
        Page.SearchByText("wikipedia");

        // Assert
        title = Page.Title();
        Assert.AreEqual("wikipedia - Google Search", title);

        // Arrange
        Page.ClearSearchText();

        // Act
        Page.SearchByText("archive");

        // Assert
        title = Page.Title();
        Assert.AreEqual("archive - Google Search", title);
    }

    [UITest]
    [RestartOnException(3)]
    public void TestMethod4()
    {
        // Act
        Page.OpenSearchPage();

        // Assert
        var title = Page.Title();
        Assert.AreEqual("Google", title);

        // Act
        Page.SearchByText("wikipedia");

        // Assert
        title = Page.Title();
        Assert.AreEqual("wikipedia - Google Search", title);

        // Arrange
        Page.ClearSearchText();

        // Act
        Page.SearchByText("archive");

        // Assert
        title = Page.Title();
        Assert.AreEqual("archive - Google Search", title);
    }

    [UITest]
    [RestartOnException(3)]
    public void TestMethod5()
    {
        // Act
        Page.OpenSearchPage();

        // Assert
        var title = Page.Title();
        Assert.AreEqual("Google", title);

        // Act
        Page.SearchByText("wikipedia");

        // Assert
        title = Page.Title();
        Assert.AreEqual("wikipedia - Google Search", title);

        // Arrange
        Page.ClearSearchText();

        // Act
        Page.SearchByText("archive");

        // Assert
        title = Page.Title();
        Assert.AreEqual("archive - Google Search", title);
    }

    [UITest]
    [RestartOnException(3)]
    public void TestMethod6()
    {
        // Act
        Page.OpenSearchPage();

        // Assert
        var title = Page.Title();
        Assert.AreEqual("Google", title);

        // Act
        Page.SearchByText("wikipedia");

        // Assert
        title = Page.Title();
        Assert.AreEqual("wikipedia - Google Search", title);

        // Arrange
        Page.ClearSearchText();

        // Act
        Page.SearchByText("archive");

        // Assert
        title = Page.Title();
        Assert.AreEqual("archive - Google Search", title);
    }

    [UITest]
    [RestartOnException(3)]
    public void TestMethod7()
    {
        // Act
        Page.OpenSearchPage();

        // Assert
        var title = Page.Title();
        Assert.AreEqual("Google", title);

        // Act
        Page.SearchByText("wikipedia");

        // Assert
        title = Page.Title();
        Assert.AreEqual("wikipedia - Google Search", title);

        // Arrange
        Page.ClearSearchText();

        // Act
        Page.SearchByText("archive");

        // Assert
        title = Page.Title();
        Assert.AreEqual("archive - Google Search", title);
    }

    [UITest]
    [RestartOnException(3)]
    public void TestMethod8()
    {
        // Act
        Page.OpenSearchPage();

        // Assert
        var title = Page.Title();
        Assert.AreEqual("Google", title);

        // Act
        Page.SearchByText("wikipedia");

        // Assert
        title = Page.Title();
        Assert.AreEqual("wikipedia - Google Search", title);

        // Arrange
        Page.ClearSearchText();

        // Act
        Page.SearchByText("archive");

        // Assert
        title = Page.Title();
        Assert.AreEqual("archive - Google Search", title);
    }

    [UITest]
    [RestartOnException(3)]
    public void TestMethod9()
    {
        // Act
        Page.OpenSearchPage();

        // Assert
        var title = Page.Title();
        Assert.AreEqual("Google", title);

        // Act
        Page.SearchByText("wikipedia");

        // Assert
        title = Page.Title();
        Assert.AreEqual("wikipedia - Google Search", title);

        // Arrange
        Page.ClearSearchText();

        // Act
        Page.SearchByText("archive");

        // Assert
        title = Page.Title();
        Assert.AreEqual("archive - Google Search", title);
    }

    [UITest]
    [RestartOnException(3)]
    public void TestMethod10()
    {
        // Act
        Page.OpenSearchPage();

        // Assert
        var title = Page.Title();
        Assert.AreEqual("Google", title);

        // Act
        Page.SearchByText("wikipedia");

        // Assert
        title = Page.Title();
        Assert.AreEqual("wikipedia - Google Search", title);

        // Arrange
        Page.ClearSearchText();

        // Act
        Page.SearchByText("archive");

        // Assert
        title = Page.Title();
        Assert.AreEqual("archive - Google Search", title);
    }

    [UITest]
    [RestartOnException(3)]
    public void TestMethod11()
    {
        // Act
        Page.OpenSearchPage();

        // Assert
        var title = Page.Title();
        Assert.AreEqual("Google", title);

        // Act
        Page.SearchByText("wikipedia");

        // Assert
        title = Page.Title();
        Assert.AreEqual("wikipedia - Google Search", title);

        // Arrange
        Page.ClearSearchText();

        // Act
        Page.SearchByText("archive");

        // Assert
        title = Page.Title();
        Assert.AreEqual("archive - Google Search", title);
    }

    [UITest]
    [RestartOnException(3)]
    public void TestMethod12()
    {
        // Act
        Page.OpenSearchPage();

        // Assert
        var title = Page.Title();
        Assert.AreEqual("Google", title);

        // Act
        Page.SearchByText("wikipedia");

        // Assert
        title = Page.Title();
        Assert.AreEqual("wikipedia - Google Search", title);

        // Arrange
        Page.ClearSearchText();

        // Act
        Page.SearchByText("archive");

        // Assert
        title = Page.Title();
        Assert.AreEqual("archive - Google Search", title);
    }

    [UITest]
    [RestartOnException(3)]
    public void TestMethod13()
    {
        // Act
        Page.OpenSearchPage();

        // Assert
        var title = Page.Title();
        Assert.AreEqual("Google", title);

        // Act
        Page.SearchByText("wikipedia");

        // Assert
        title = Page.Title();
        Assert.AreEqual("wikipedia - Google Search", title);

        // Arrange
        Page.ClearSearchText();

        // Act
        Page.SearchByText("archive");

        // Assert
        title = Page.Title();
        Assert.AreEqual("archive - Google Search", title);
    }

    [UITest]
    [RestartOnException(3)]
    public void TestMethod14()
    {
        // Act
        Page.OpenSearchPage();

        // Assert
        var title = Page.Title();
        Assert.AreEqual("Google", title);

        // Act
        Page.SearchByText("wikipedia");

        // Assert
        title = Page.Title();
        Assert.AreEqual("wikipedia - Google Search", title);

        // Arrange
        Page.ClearSearchText();

        // Act
        Page.SearchByText("archive");

        // Assert
        title = Page.Title();
        Assert.AreEqual("archive - Google Search", title);
    }

    [UITest]
    [RestartOnException(3)]
    public void TestMethod15()
    {
        // Act
        Page.OpenSearchPage();

        // Assert
        var title = Page.Title();
        Assert.AreEqual("Google", title);

        // Act
        Page.SearchByText("wikipedia");

        // Assert
        title = Page.Title();
        Assert.AreEqual("wikipedia - Google Search", title);

        // Arrange
        Page.ClearSearchText();

        // Act
        Page.SearchByText("archive");

        // Assert
        title = Page.Title();
        Assert.AreEqual("archive - Google Search", title);
    }

    [UITest]
    [RestartOnException(3)]
    public void TestMethod16()
    {
        // Act
        Page.OpenSearchPage();

        // Assert
        var title = Page.Title();
        Assert.AreEqual("Google", title);

        // Act
        Page.SearchByText("wikipedia");

        // Assert
        title = Page.Title();
        Assert.AreEqual("wikipedia - Google Search", title);

        // Arrange
        Page.ClearSearchText();

        // Act
        Page.SearchByText("archive");

        // Assert
        title = Page.Title();
        Assert.AreEqual("archive - Google Search", title);
    }

    [UITest]
    [RestartOnException(3)]
    public void TestMethod17()
    {
        // Act
        Page.OpenSearchPage();

        // Assert
        var title = Page.Title();
        Assert.AreEqual("Google", title);

        // Act
        Page.SearchByText("wikipedia");

        // Assert
        title = Page.Title();
        Assert.AreEqual("wikipedia - Google Search", title);

        // Arrange
        Page.ClearSearchText();

        // Act
        Page.SearchByText("archive");

        // Assert
        title = Page.Title();
        Assert.AreEqual("archive - Google Search", title);
    }

    [UITest]
    [RestartOnException(3)]
    public void TestMethod18()
    {
        // Act
        Page.OpenSearchPage();

        // Assert
        var title = Page.Title();
        Assert.AreEqual("Google", title);

        // Act
        Page.SearchByText("wikipedia");

        // Assert
        title = Page.Title();
        Assert.AreEqual("wikipedia - Google Search", title);

        // Arrange
        Page.ClearSearchText();

        // Act
        Page.SearchByText("archive");

        // Assert
        title = Page.Title();
        Assert.AreEqual("archive - Google Search", title);
    }

    [UITest]
    [RestartOnException(3)]
    public void TestMethod19()
    {
        // Act
        Page.OpenSearchPage();

        // Assert
        var title = Page.Title();
        Assert.AreEqual("Google", title);

        // Act
        Page.SearchByText("wikipedia");

        // Assert
        title = Page.Title();
        Assert.AreEqual("wikipedia - Google Search", title);

        // Arrange
        Page.ClearSearchText();

        // Act
        Page.SearchByText("archive");

        // Assert
        title = Page.Title();
        Assert.AreEqual("archive - Google Search", title);
    }

    [UITest]
    [RestartOnException(3)]
    public void TestMethod20()
    {
        // Act
        Page.OpenSearchPage();

        // Assert
        var title = Page.Title();
        Assert.AreEqual("Google", title);

        // Act
        Page.SearchByText("wikipedia");

        // Assert
        title = Page.Title();
        Assert.AreEqual("wikipedia - Google Search", title);

        // Arrange
        Page.ClearSearchText();

        // Act
        Page.SearchByText("archive");

        // Assert
        title = Page.Title();
        Assert.AreEqual("archive - Google Search", title);
    }

    [UITest]
    [RestartOnException(3)]
    public void TestMethod21()
    {
        // Act
        Page.OpenSearchPage();

        // Assert
        var title = Page.Title();
        Assert.AreEqual("Google", title);

        // Act
        Page.SearchByText("wikipedia");

        // Assert
        title = Page.Title();
        Assert.AreEqual("wikipedia - Google Search", title);

        // Arrange
        Page.ClearSearchText();

        // Act
        Page.SearchByText("archive");

        // Assert
        title = Page.Title();
        Assert.AreEqual("archive - Google Search", title);
    }

    [UITest]
    [RestartOnException(3)]
    public void TestMethod22()
    {
        // Act
        Page.OpenSearchPage();

        // Assert
        var title = Page.Title();
        Assert.AreEqual("Google", title);

        // Act
        Page.SearchByText("wikipedia");

        // Assert
        title = Page.Title();
        Assert.AreEqual("wikipedia - Google Search", title);

        // Arrange
        Page.ClearSearchText();

        // Act
        Page.SearchByText("archive");

        // Assert
        title = Page.Title();
        Assert.AreEqual("archive - Google Search", title);
    }

    [UITest]
    [RestartOnException(3)]
    public void TestMethod23()
    {
        // Act
        Page.OpenSearchPage();

        // Assert
        var title = Page.Title();
        Assert.AreEqual("Google", title);

        // Act
        Page.SearchByText("wikipedia");

        // Assert
        title = Page.Title();
        Assert.AreEqual("wikipedia - Google Search", title);

        // Arrange
        Page.ClearSearchText();

        // Act
        Page.SearchByText("archive");

        // Assert
        title = Page.Title();
        Assert.AreEqual("archive - Google Search", title);
    }

    [UITest]
    [RestartOnException(3)]
    public void TestMethod24()
    {
        // Act
        Page.OpenSearchPage();

        // Assert
        var title = Page.Title();
        Assert.AreEqual("Google", title);

        // Act
        Page.SearchByText("wikipedia");

        // Assert
        title = Page.Title();
        Assert.AreEqual("wikipedia - Google Search", title);

        // Arrange
        Page.ClearSearchText();

        // Act
        Page.SearchByText("archive");

        // Assert
        title = Page.Title();
        Assert.AreEqual("archive - Google Search", title);
    }

    [UITest]
    [RestartOnException(3)]
    public void TestMethod25()
    {
        // Act
        Page.OpenSearchPage();

        // Assert
        var title = Page.Title();
        Assert.AreEqual("Google", title);

        // Act
        Page.SearchByText("wikipedia");

        // Assert
        title = Page.Title();
        Assert.AreEqual("wikipedia - Google Search", title);

        // Arrange
        Page.ClearSearchText();

        // Act
        Page.SearchByText("archive");

        // Assert
        title = Page.Title();
        Assert.AreEqual("archive - Google Search", title);
    }

    [UITest]
    [RestartOnException(3)]
    public void TestMethod26()
    {
        // Act
        Page.OpenSearchPage();

        // Assert
        var title = Page.Title();
        Assert.AreEqual("Google", title);

        // Act
        Page.SearchByText("wikipedia");

        // Assert
        title = Page.Title();
        Assert.AreEqual("wikipedia - Google Search", title);

        // Arrange
        Page.ClearSearchText();

        // Act
        Page.SearchByText("archive");

        // Assert
        title = Page.Title();
        Assert.AreEqual("archive - Google Search", title);
    }

    [UITest]
    [RestartOnException(3)]
    public void TestMethod27()
    {
        // Act
        Page.OpenSearchPage();

        // Assert
        var title = Page.Title();
        Assert.AreEqual("Google", title);

        // Act
        Page.SearchByText("wikipedia");

        // Assert
        title = Page.Title();
        Assert.AreEqual("wikipedia - Google Search", title);

        // Arrange
        Page.ClearSearchText();

        // Act
        Page.SearchByText("archive");

        // Assert
        title = Page.Title();
        Assert.AreEqual("archive - Google Search", title);
    }

    [UITest]
    [RestartOnException(3)]
    public void TestMethod28()
    {
        // Act
        Page.OpenSearchPage();

        // Assert
        var title = Page.Title();
        Assert.AreEqual("Google", title);

        // Act
        Page.SearchByText("wikipedia");

        // Assert
        title = Page.Title();
        Assert.AreEqual("wikipedia - Google Search", title);

        // Arrange
        Page.ClearSearchText();

        // Act
        Page.SearchByText("archive");

        // Assert
        title = Page.Title();
        Assert.AreEqual("archive - Google Search", title);
    }

    [UITest]
    [RestartOnException(3)]
    public void TestMethod29()
    {
        // Act
        Page.OpenSearchPage();

        // Assert
        var title = Page.Title();
        Assert.AreEqual("Google", title);

        // Act
        Page.SearchByText("wikipedia");

        // Assert
        title = Page.Title();
        Assert.AreEqual("wikipedia - Google Search", title);

        // Arrange
        Page.ClearSearchText();

        // Act
        Page.SearchByText("archive");

        // Assert
        title = Page.Title();
        Assert.AreEqual("archive - Google Search", title);
    }

    [UITest]
    [RestartOnException(3)]
    public void TestMethod30()
    {
        // Act
        Page.OpenSearchPage();

        // Assert
        var title = Page.Title();
        Assert.AreEqual("Google", title);

        // Act
        Page.SearchByText("wikipedia");

        // Assert
        title = Page.Title();
        Assert.AreEqual("wikipedia - Google Search", title);

        // Arrange
        Page.ClearSearchText();

        // Act
        Page.SearchByText("archive");

        // Assert
        title = Page.Title();
        Assert.AreEqual("archive - Google Search", title);
    }

    [UITest]
    [RestartOnException(3)]
    public void TestMethod31()
    {
        // Act
        Page.OpenSearchPage();

        // Assert
        var title = Page.Title();
        Assert.AreEqual("Google", title);

        // Act
        Page.SearchByText("wikipedia");

        // Assert
        title = Page.Title();
        Assert.AreEqual("wikipedia - Google Search", title);

        // Arrange
        Page.ClearSearchText();

        // Act
        Page.SearchByText("archive");

        // Assert
        title = Page.Title();
        Assert.AreEqual("archive - Google Search", title);
    }

    [UITest]
    [RestartOnException(3)]
    public void TestMethod32()
    {
        // Act
        Page.OpenSearchPage();

        // Assert
        var title = Page.Title();
        Assert.AreEqual("Google", title);

        // Act
        Page.SearchByText("wikipedia");

        // Assert
        title = Page.Title();
        Assert.AreEqual("wikipedia - Google Search", title);

        // Arrange
        Page.ClearSearchText();

        // Act
        Page.SearchByText("archive");

        // Assert
        title = Page.Title();
        Assert.AreEqual("archive - Google Search", title);
    }

    [UITest]
    [RestartOnException(3)]
    public void TestMethod33()
    {
        // Act
        Page.OpenSearchPage();

        // Assert
        var title = Page.Title();
        Assert.AreEqual("Google", title);

        // Act
        Page.SearchByText("wikipedia");

        // Assert
        title = Page.Title();
        Assert.AreEqual("wikipedia - Google Search", title);

        // Arrange
        Page.ClearSearchText();

        // Act
        Page.SearchByText("archive");

        // Assert
        title = Page.Title();
        Assert.AreEqual("archive - Google Search", title);
    }

    [UITest]
    [RestartOnException(3)]
    public void TestMethod34()
    {
        // Act
        Page.OpenSearchPage();

        // Assert
        var title = Page.Title();
        Assert.AreEqual("Google", title);

        // Act
        Page.SearchByText("wikipedia");

        // Assert
        title = Page.Title();
        Assert.AreEqual("wikipedia - Google Search", title);

        // Arrange
        Page.ClearSearchText();

        // Act
        Page.SearchByText("archive");

        // Assert
        title = Page.Title();
        Assert.AreEqual("archive - Google Search", title);
    }

    [UITest]
    [RestartOnException(3)]
    public void TestMethod35()
    {
        // Act
        Page.OpenSearchPage();

        // Assert
        var title = Page.Title();
        Assert.AreEqual("Google", title);

        // Act
        Page.SearchByText("wikipedia");

        // Assert
        title = Page.Title();
        Assert.AreEqual("wikipedia - Google Search", title);

        // Arrange
        Page.ClearSearchText();

        // Act
        Page.SearchByText("archive");

        // Assert
        title = Page.Title();
        Assert.AreEqual("archive - Google Search", title);
    }

    [UITest]
    [RestartOnException(3)]
    public void TestMethod36()
    {
        // Act
        Page.OpenSearchPage();

        // Assert
        var title = Page.Title();
        Assert.AreEqual("Google", title);

        // Act
        Page.SearchByText("wikipedia");

        // Assert
        title = Page.Title();
        Assert.AreEqual("wikipedia - Google Search", title);

        // Arrange
        Page.ClearSearchText();

        // Act
        Page.SearchByText("archive");

        // Assert
        title = Page.Title();
        Assert.AreEqual("archive - Google Search", title);
    }

    [UITest]
    [RestartOnException(3)]
    public void TestMethod37()
    {
        // Act
        Page.OpenSearchPage();

        // Assert
        var title = Page.Title();
        Assert.AreEqual("Google", title);

        // Act
        Page.SearchByText("wikipedia");

        // Assert
        title = Page.Title();
        Assert.AreEqual("wikipedia - Google Search", title);

        // Arrange
        Page.ClearSearchText();

        // Act
        Page.SearchByText("archive");

        // Assert
        title = Page.Title();
        Assert.AreEqual("archive - Google Search", title);
    }

    [UITest]
    [RestartOnException(3)]
    public void TestMethod38()
    {
        // Act
        Page.OpenSearchPage();

        // Assert
        var title = Page.Title();
        Assert.AreEqual("Google", title);

        // Act
        Page.SearchByText("wikipedia");

        // Assert
        title = Page.Title();
        Assert.AreEqual("wikipedia - Google Search", title);

        // Arrange
        Page.ClearSearchText();

        // Act
        Page.SearchByText("archive");

        // Assert
        title = Page.Title();
        Assert.AreEqual("archive - Google Search", title);
    }

    [UITest]
    [RestartOnException(3)]
    public void TestMethod39()
    {
        // Act
        Page.OpenSearchPage();

        // Assert
        var title = Page.Title();
        Assert.AreEqual("Google", title);

        // Act
        Page.SearchByText("wikipedia");

        // Assert
        title = Page.Title();
        Assert.AreEqual("wikipedia - Google Search", title);

        // Arrange
        Page.ClearSearchText();

        // Act
        Page.SearchByText("archive");

        // Assert
        title = Page.Title();
        Assert.AreEqual("archive - Google Search", title);
    }

    [UITest]
    [RestartOnException(3)]
    public void TestMethod40()
    {
        // Act
        Page.OpenSearchPage();

        // Assert
        var title = Page.Title();
        Assert.AreEqual("Google", title);

        // Act
        Page.SearchByText("wikipedia");

        // Assert
        title = Page.Title();
        Assert.AreEqual("wikipedia - Google Search", title);

        // Arrange
        Page.ClearSearchText();

        // Act
        Page.SearchByText("archive");

        // Assert
        title = Page.Title();
        Assert.AreEqual("archive - Google Search", title);
    }

    [UITest]
    [RestartOnException(3)]
    public void TestMethod41()
    {
        // Act
        Page.OpenSearchPage();

        // Assert
        var title = Page.Title();
        Assert.AreEqual("Google", title);

        // Act
        Page.SearchByText("wikipedia");

        // Assert
        title = Page.Title();
        Assert.AreEqual("wikipedia - Google Search", title);

        // Arrange
        Page.ClearSearchText();

        // Act
        Page.SearchByText("archive");

        // Assert
        title = Page.Title();
        Assert.AreEqual("archive - Google Search", title);
    }

    [UITest]
    [RestartOnException(3)]
    public void TestMethod42()
    {
        // Act
        Page.OpenSearchPage();

        // Assert
        var title = Page.Title();
        Assert.AreEqual("Google", title);

        // Act
        Page.SearchByText("wikipedia");

        // Assert
        title = Page.Title();
        Assert.AreEqual("wikipedia - Google Search", title);

        // Arrange
        Page.ClearSearchText();

        // Act
        Page.SearchByText("archive");

        // Assert
        title = Page.Title();
        Assert.AreEqual("archive - Google Search", title);
    }

    [UITest]
    [RestartOnException(3)]
    public void TestMethod43()
    {
        // Act
        Page.OpenSearchPage();

        // Assert
        var title = Page.Title();
        Assert.AreEqual("Google", title);

        // Act
        Page.SearchByText("wikipedia");

        // Assert
        title = Page.Title();
        Assert.AreEqual("wikipedia - Google Search", title);

        // Arrange
        Page.ClearSearchText();

        // Act
        Page.SearchByText("archive");

        // Assert
        title = Page.Title();
        Assert.AreEqual("archive - Google Search", title);
    }

    [UITest]
    [RestartOnException(3)]
    public void TestMethod44()
    {
        // Act
        Page.OpenSearchPage();

        // Assert
        var title = Page.Title();
        Assert.AreEqual("Google", title);

        // Act
        Page.SearchByText("wikipedia");

        // Assert
        title = Page.Title();
        Assert.AreEqual("wikipedia - Google Search", title);

        // Arrange
        Page.ClearSearchText();

        // Act
        Page.SearchByText("archive");

        // Assert
        title = Page.Title();
        Assert.AreEqual("archive - Google Search", title);
    }

    [UITest]
    [RestartOnException(3)]
    public void TestMethod45()
    {
        // Act
        Page.OpenSearchPage();

        // Assert
        var title = Page.Title();
        Assert.AreEqual("Google", title);

        // Act
        Page.SearchByText("wikipedia");

        // Assert
        title = Page.Title();
        Assert.AreEqual("wikipedia - Google Search", title);

        // Arrange
        Page.ClearSearchText();

        // Act
        Page.SearchByText("archive");

        // Assert
        title = Page.Title();
        Assert.AreEqual("archive - Google Search", title);
    }

    [UITest]
    [RestartOnException(3)]
    public void TestMethod46()
    {
        // Act
        Page.OpenSearchPage();

        // Assert
        var title = Page.Title();
        Assert.AreEqual("Google", title);

        // Act
        Page.SearchByText("wikipedia");

        // Assert
        title = Page.Title();
        Assert.AreEqual("wikipedia - Google Search", title);

        // Arrange
        Page.ClearSearchText();

        // Act
        Page.SearchByText("archive");

        // Assert
        title = Page.Title();
        Assert.AreEqual("archive - Google Search", title);
    }

    [UITest]
    [RestartOnException(3)]
    public void TestMethod47()
    {
        // Act
        Page.OpenSearchPage();

        // Assert
        var title = Page.Title();
        Assert.AreEqual("Google", title);

        // Act
        Page.SearchByText("wikipedia");

        // Assert
        title = Page.Title();
        Assert.AreEqual("wikipedia - Google Search", title);

        // Arrange
        Page.ClearSearchText();

        // Act
        Page.SearchByText("archive");

        // Assert
        title = Page.Title();
        Assert.AreEqual("archive - Google Search", title);
    }

    [UITest]
    [RestartOnException(3)]
    public void TestMethod48()
    {
        // Act
        Page.OpenSearchPage();

        // Assert
        var title = Page.Title();
        Assert.AreEqual("Google", title);

        // Act
        Page.SearchByText("wikipedia");

        // Assert
        title = Page.Title();
        Assert.AreEqual("wikipedia - Google Search", title);

        // Arrange
        Page.ClearSearchText();

        // Act
        Page.SearchByText("archive");

        // Assert
        title = Page.Title();
        Assert.AreEqual("archive - Google Search", title);
    }

    [UITest]
    [RestartOnException(3)]
    public void TestMethod49()
    {
        // Act
        Page.OpenSearchPage();

        // Assert
        var title = Page.Title();
        Assert.AreEqual("Google", title);

        // Act
        Page.SearchByText("wikipedia");

        // Assert
        title = Page.Title();
        Assert.AreEqual("wikipedia - Google Search", title);

        // Arrange
        Page.ClearSearchText();

        // Act
        Page.SearchByText("archive");

        // Assert
        title = Page.Title();
        Assert.AreEqual("archive - Google Search", title);
    }

    [UITest]
    [RestartOnException(3)]
    public void TestMethod50()
    {
        // Act
        Page.OpenSearchPage();

        // Assert
        var title = Page.Title();
        Assert.AreEqual("Google", title);

        // Act
        Page.SearchByText("wikipedia");

        // Assert
        title = Page.Title();
        Assert.AreEqual("wikipedia - Google Search", title);

        // Arrange
        Page.ClearSearchText();

        // Act
        Page.SearchByText("archive");

        // Assert
        title = Page.Title();
        Assert.AreEqual("archive - Google Search", title);
    }

    [UITest]
    [RestartOnException(3)]
    public void TestMethod51()
    {
        // Act
        Page.OpenSearchPage();

        // Assert
        var title = Page.Title();
        Assert.AreEqual("Google", title);

        // Act
        Page.SearchByText("wikipedia");

        // Assert
        title = Page.Title();
        Assert.AreEqual("wikipedia - Google Search", title);

        // Arrange
        Page.ClearSearchText();

        // Act
        Page.SearchByText("archive");

        // Assert
        title = Page.Title();
        Assert.AreEqual("archive - Google Search", title);
    }

    [UITest]
    [RestartOnException(3)]
    public void TestMethod52()
    {
        // Act
        Page.OpenSearchPage();

        // Assert
        var title = Page.Title();
        Assert.AreEqual("Google", title);

        // Act
        Page.SearchByText("wikipedia");

        // Assert
        title = Page.Title();
        Assert.AreEqual("wikipedia - Google Search", title);

        // Arrange
        Page.ClearSearchText();

        // Act
        Page.SearchByText("archive");

        // Assert
        title = Page.Title();
        Assert.AreEqual("archive - Google Search", title);
    }

    [UITest]
    [RestartOnException(3)]
    public void TestMethod53()
    {
        // Act
        Page.OpenSearchPage();

        // Assert
        var title = Page.Title();
        Assert.AreEqual("Google", title);

        // Act
        Page.SearchByText("wikipedia");

        // Assert
        title = Page.Title();
        Assert.AreEqual("wikipedia - Google Search", title);

        // Arrange
        Page.ClearSearchText();

        // Act
        Page.SearchByText("archive");

        // Assert
        title = Page.Title();
        Assert.AreEqual("archive - Google Search", title);
    }

    [UITest]
    [RestartOnException(3)]
    public void TestMethod54()
    {
        // Act
        Page.OpenSearchPage();

        // Assert
        var title = Page.Title();
        Assert.AreEqual("Google", title);

        // Act
        Page.SearchByText("wikipedia");

        // Assert
        title = Page.Title();
        Assert.AreEqual("wikipedia - Google Search", title);

        // Arrange
        Page.ClearSearchText();

        // Act
        Page.SearchByText("archive");

        // Assert
        title = Page.Title();
        Assert.AreEqual("archive - Google Search", title);
    }

    [UITest]
    [RestartOnException(3)]
    public void TestMethod55()
    {
        // Act
        Page.OpenSearchPage();

        // Assert
        var title = Page.Title();
        Assert.AreEqual("Google", title);

        // Act
        Page.SearchByText("wikipedia");

        // Assert
        title = Page.Title();
        Assert.AreEqual("wikipedia - Google Search", title);

        // Arrange
        Page.ClearSearchText();

        // Act
        Page.SearchByText("archive");

        // Assert
        title = Page.Title();
        Assert.AreEqual("archive - Google Search", title);
    }

    [UITest]
    [RestartOnException(3)]
    public void TestMethod56()
    {
        // Act
        Page.OpenSearchPage();

        // Assert
        var title = Page.Title();
        Assert.AreEqual("Google", title);

        // Act
        Page.SearchByText("wikipedia");

        // Assert
        title = Page.Title();
        Assert.AreEqual("wikipedia - Google Search", title);

        // Arrange
        Page.ClearSearchText();

        // Act
        Page.SearchByText("archive");

        // Assert
        title = Page.Title();
        Assert.AreEqual("archive - Google Search", title);
    }

    [UITest]
    [RestartOnException(3)]
    public void TestMethod57()
    {
        // Act
        Page.OpenSearchPage();

        // Assert
        var title = Page.Title();
        Assert.AreEqual("Google", title);

        // Act
        Page.SearchByText("wikipedia");

        // Assert
        title = Page.Title();
        Assert.AreEqual("wikipedia - Google Search", title);

        // Arrange
        Page.ClearSearchText();

        // Act
        Page.SearchByText("archive");

        // Assert
        title = Page.Title();
        Assert.AreEqual("archive - Google Search", title);
    }

    [UITest]
    [RestartOnException(3)]
    public void TestMethod58()
    {
        // Act
        Page.OpenSearchPage();

        // Assert
        var title = Page.Title();
        Assert.AreEqual("Google", title);

        // Act
        Page.SearchByText("wikipedia");

        // Assert
        title = Page.Title();
        Assert.AreEqual("wikipedia - Google Search", title);

        // Arrange
        Page.ClearSearchText();

        // Act
        Page.SearchByText("archive");

        // Assert
        title = Page.Title();
        Assert.AreEqual("archive - Google Search", title);
    }

    [UITest]
    [RestartOnException(3)]
    public void TestMethod59()
    {
        // Act
        Page.OpenSearchPage();

        // Assert
        var title = Page.Title();
        Assert.AreEqual("Google", title);

        // Act
        Page.SearchByText("wikipedia");

        // Assert
        title = Page.Title();
        Assert.AreEqual("wikipedia - Google Search", title);

        // Arrange
        Page.ClearSearchText();

        // Act
        Page.SearchByText("archive");

        // Assert
        title = Page.Title();
        Assert.AreEqual("archive - Google Search", title);
    }

    [UITest]
    [RestartOnException(3)]
    public void TestMethod60()
    {
        // Act
        Page.OpenSearchPage();

        // Assert
        var title = Page.Title();
        Assert.AreEqual("Google", title);

        // Act
        Page.SearchByText("wikipedia");

        // Assert
        title = Page.Title();
        Assert.AreEqual("wikipedia - Google Search", title);

        // Arrange
        Page.ClearSearchText();

        // Act
        Page.SearchByText("archive");

        // Assert
        title = Page.Title();
        Assert.AreEqual("archive - Google Search", title);
    }

    [UITest]
    [RestartOnException(3)]
    public void TestMethod61()
    {
        // Act
        Page.OpenSearchPage();

        // Assert
        var title = Page.Title();
        Assert.AreEqual("Google", title);

        // Act
        Page.SearchByText("wikipedia");

        // Assert
        title = Page.Title();
        Assert.AreEqual("wikipedia - Google Search", title);

        // Arrange
        Page.ClearSearchText();

        // Act
        Page.SearchByText("archive");

        // Assert
        title = Page.Title();
        Assert.AreEqual("archive - Google Search", title);
    }

    [UITest]
    [RestartOnException(3)]
    public void TestMethod62()
    {
        // Act
        Page.OpenSearchPage();

        // Assert
        var title = Page.Title();
        Assert.AreEqual("Google", title);

        // Act
        Page.SearchByText("wikipedia");

        // Assert
        title = Page.Title();
        Assert.AreEqual("wikipedia - Google Search", title);

        // Arrange
        Page.ClearSearchText();

        // Act
        Page.SearchByText("archive");

        // Assert
        title = Page.Title();
        Assert.AreEqual("archive - Google Search", title);
    }

    [UITest]
    [RestartOnException(3)]
    public void TestMethod63()
    {
        // Act
        Page.OpenSearchPage();

        // Assert
        var title = Page.Title();
        Assert.AreEqual("Google", title);

        // Act
        Page.SearchByText("wikipedia");

        // Assert
        title = Page.Title();
        Assert.AreEqual("wikipedia - Google Search", title);

        // Arrange
        Page.ClearSearchText();

        // Act
        Page.SearchByText("archive");

        // Assert
        title = Page.Title();
        Assert.AreEqual("archive - Google Search", title);
    }

    [UITest]
    [RestartOnException(3)]
    public void TestMethod64()
    {
        // Act
        Page.OpenSearchPage();

        // Assert
        var title = Page.Title();
        Assert.AreEqual("Google", title);

        // Act
        Page.SearchByText("wikipedia");

        // Assert
        title = Page.Title();
        Assert.AreEqual("wikipedia - Google Search", title);

        // Arrange
        Page.ClearSearchText();

        // Act
        Page.SearchByText("archive");

        // Assert
        title = Page.Title();
        Assert.AreEqual("archive - Google Search", title);
    }

    [UITest]
    [RestartOnException(3)]
    public void TestMethod65()
    {
        // Act
        Page.OpenSearchPage();

        // Assert
        var title = Page.Title();
        Assert.AreEqual("Google", title);

        // Act
        Page.SearchByText("wikipedia");

        // Assert
        title = Page.Title();
        Assert.AreEqual("wikipedia - Google Search", title);

        // Arrange
        Page.ClearSearchText();

        // Act
        Page.SearchByText("archive");

        // Assert
        title = Page.Title();
        Assert.AreEqual("archive - Google Search", title);
    }

    [UITest]
    [RestartOnException(3)]
    public void TestMethod66()
    {
        // Act
        Page.OpenSearchPage();

        // Assert
        var title = Page.Title();
        Assert.AreEqual("Google", title);

        // Act
        Page.SearchByText("wikipedia");

        // Assert
        title = Page.Title();
        Assert.AreEqual("wikipedia - Google Search", title);

        // Arrange
        Page.ClearSearchText();

        // Act
        Page.SearchByText("archive");

        // Assert
        title = Page.Title();
        Assert.AreEqual("archive - Google Search", title);
    }

    [UITest]
    [RestartOnException(3)]
    public void TestMethod67()
    {
        // Act
        Page.OpenSearchPage();

        // Assert
        var title = Page.Title();
        Assert.AreEqual("Google", title);

        // Act
        Page.SearchByText("wikipedia");

        // Assert
        title = Page.Title();
        Assert.AreEqual("wikipedia - Google Search", title);

        // Arrange
        Page.ClearSearchText();

        // Act
        Page.SearchByText("archive");

        // Assert
        title = Page.Title();
        Assert.AreEqual("archive - Google Search", title);
    }

    [UITest]
    [RestartOnException(3)]
    public void TestMethod68()
    {
        // Act
        Page.OpenSearchPage();

        // Assert
        var title = Page.Title();
        Assert.AreEqual("Google", title);

        // Act
        Page.SearchByText("wikipedia");

        // Assert
        title = Page.Title();
        Assert.AreEqual("wikipedia - Google Search", title);

        // Arrange
        Page.ClearSearchText();

        // Act
        Page.SearchByText("archive");

        // Assert
        title = Page.Title();
        Assert.AreEqual("archive - Google Search", title);
    }

    [UITest]
    [RestartOnException(3)]
    public void TestMethod69()
    {
        // Act
        Page.OpenSearchPage();

        // Assert
        var title = Page.Title();
        Assert.AreEqual("Google", title);

        // Act
        Page.SearchByText("wikipedia");

        // Assert
        title = Page.Title();
        Assert.AreEqual("wikipedia - Google Search", title);

        // Arrange
        Page.ClearSearchText();

        // Act
        Page.SearchByText("archive");

        // Assert
        title = Page.Title();
        Assert.AreEqual("archive - Google Search", title);
    }

    [UITest]
    [RestartOnException(3)]
    public void TestMethod70()
    {
        // Act
        Page.OpenSearchPage();

        // Assert
        var title = Page.Title();
        Assert.AreEqual("Google", title);

        // Act
        Page.SearchByText("wikipedia");

        // Assert
        title = Page.Title();
        Assert.AreEqual("wikipedia - Google Search", title);

        // Arrange
        Page.ClearSearchText();

        // Act
        Page.SearchByText("archive");

        // Assert
        title = Page.Title();
        Assert.AreEqual("archive - Google Search", title);
    }

    [UITest]
    [RestartOnException(3)]
    public void TestMethod71()
    {
        // Act
        Page.OpenSearchPage();

        // Assert
        var title = Page.Title();
        Assert.AreEqual("Google", title);

        // Act
        Page.SearchByText("wikipedia");

        // Assert
        title = Page.Title();
        Assert.AreEqual("wikipedia - Google Search", title);

        // Arrange
        Page.ClearSearchText();

        // Act
        Page.SearchByText("archive");

        // Assert
        title = Page.Title();
        Assert.AreEqual("archive - Google Search", title);
    }

    [UITest]
    [RestartOnException(3)]
    public void TestMethod72()
    {
        // Act
        Page.OpenSearchPage();

        // Assert
        var title = Page.Title();
        Assert.AreEqual("Google", title);

        // Act
        Page.SearchByText("wikipedia");

        // Assert
        title = Page.Title();
        Assert.AreEqual("wikipedia - Google Search", title);

        // Arrange
        Page.ClearSearchText();

        // Act
        Page.SearchByText("archive");

        // Assert
        title = Page.Title();
        Assert.AreEqual("archive - Google Search", title);
    }

    [UITest]
    [RestartOnException(3)]
    public void TestMethod73()
    {
        // Act
        Page.OpenSearchPage();

        // Assert
        var title = Page.Title();
        Assert.AreEqual("Google", title);

        // Act
        Page.SearchByText("wikipedia");

        // Assert
        title = Page.Title();
        Assert.AreEqual("wikipedia - Google Search", title);

        // Arrange
        Page.ClearSearchText();

        // Act
        Page.SearchByText("archive");

        // Assert
        title = Page.Title();
        Assert.AreEqual("archive - Google Search", title);
    }

    [UITest]
    [RestartOnException(3)]
    public void TestMethod74()
    {
        // Act
        Page.OpenSearchPage();

        // Assert
        var title = Page.Title();
        Assert.AreEqual("Google", title);

        // Act
        Page.SearchByText("wikipedia");

        // Assert
        title = Page.Title();
        Assert.AreEqual("wikipedia - Google Search", title);

        // Arrange
        Page.ClearSearchText();

        // Act
        Page.SearchByText("archive");

        // Assert
        title = Page.Title();
        Assert.AreEqual("archive - Google Search", title);
    }

    [UITest]
    [RestartOnException(3)]
    public void TestMethod75()
    {
        // Act
        Page.OpenSearchPage();

        // Assert
        var title = Page.Title();
        Assert.AreEqual("Google", title);

        // Act
        Page.SearchByText("wikipedia");

        // Assert
        title = Page.Title();
        Assert.AreEqual("wikipedia - Google Search", title);

        // Arrange
        Page.ClearSearchText();

        // Act
        Page.SearchByText("archive");

        // Assert
        title = Page.Title();
        Assert.AreEqual("archive - Google Search", title);
    }

    [UITest]
    [RestartOnException(3)]
    public void TestMethod76()
    {
        // Act
        Page.OpenSearchPage();

        // Assert
        var title = Page.Title();
        Assert.AreEqual("Google", title);

        // Act
        Page.SearchByText("wikipedia");

        // Assert
        title = Page.Title();
        Assert.AreEqual("wikipedia - Google Search", title);

        // Arrange
        Page.ClearSearchText();

        // Act
        Page.SearchByText("archive");

        // Assert
        title = Page.Title();
        Assert.AreEqual("archive - Google Search", title);
    }

    [UITest]
    [RestartOnException(3)]
    public void TestMethod77()
    {
        // Act
        Page.OpenSearchPage();

        // Assert
        var title = Page.Title();
        Assert.AreEqual("Google", title);

        // Act
        Page.SearchByText("wikipedia");

        // Assert
        title = Page.Title();
        Assert.AreEqual("wikipedia - Google Search", title);

        // Arrange
        Page.ClearSearchText();

        // Act
        Page.SearchByText("archive");

        // Assert
        title = Page.Title();
        Assert.AreEqual("archive - Google Search", title);
    }

    [UITest]
    [RestartOnException(3)]
    public void TestMethod78()
    {
        // Act
        Page.OpenSearchPage();

        // Assert
        var title = Page.Title();
        Assert.AreEqual("Google", title);

        // Act
        Page.SearchByText("wikipedia");

        // Assert
        title = Page.Title();
        Assert.AreEqual("wikipedia - Google Search", title);

        // Arrange
        Page.ClearSearchText();

        // Act
        Page.SearchByText("archive");

        // Assert
        title = Page.Title();
        Assert.AreEqual("archive - Google Search", title);
    }

    [UITest]
    [RestartOnException(3)]
    public void TestMethod79()
    {
        // Act
        Page.OpenSearchPage();

        // Assert
        var title = Page.Title();
        Assert.AreEqual("Google", title);

        // Act
        Page.SearchByText("wikipedia");

        // Assert
        title = Page.Title();
        Assert.AreEqual("wikipedia - Google Search", title);

        // Arrange
        Page.ClearSearchText();

        // Act
        Page.SearchByText("archive");

        // Assert
        title = Page.Title();
        Assert.AreEqual("archive - Google Search", title);
    }

    [UITest]
    [RestartOnException(3)]
    public void TestMethod80()
    {
        // Act
        Page.OpenSearchPage();

        // Assert
        var title = Page.Title();
        Assert.AreEqual("Google", title);

        // Act
        Page.SearchByText("wikipedia");

        // Assert
        title = Page.Title();
        Assert.AreEqual("wikipedia - Google Search", title);

        // Arrange
        Page.ClearSearchText();

        // Act
        Page.SearchByText("archive");

        // Assert
        title = Page.Title();
        Assert.AreEqual("archive - Google Search", title);
    }

    [UITest]
    [RestartOnException(3)]
    public void TestMethod81()
    {
        // Act
        Page.OpenSearchPage();

        // Assert
        var title = Page.Title();
        Assert.AreEqual("Google", title);

        // Act
        Page.SearchByText("wikipedia");

        // Assert
        title = Page.Title();
        Assert.AreEqual("wikipedia - Google Search", title);

        // Arrange
        Page.ClearSearchText();

        // Act
        Page.SearchByText("archive");

        // Assert
        title = Page.Title();
        Assert.AreEqual("archive - Google Search", title);
    }

    [UITest]
    [RestartOnException(3)]
    public void TestMethod82()
    {
        // Act
        Page.OpenSearchPage();

        // Assert
        var title = Page.Title();
        Assert.AreEqual("Google", title);

        // Act
        Page.SearchByText("wikipedia");

        // Assert
        title = Page.Title();
        Assert.AreEqual("wikipedia - Google Search", title);

        // Arrange
        Page.ClearSearchText();

        // Act
        Page.SearchByText("archive");

        // Assert
        title = Page.Title();
        Assert.AreEqual("archive - Google Search", title);
    }

    [UITest]
    [RestartOnException(3)]
    public void TestMethod83()
    {
        // Act
        Page.OpenSearchPage();

        // Assert
        var title = Page.Title();
        Assert.AreEqual("Google", title);

        // Act
        Page.SearchByText("wikipedia");

        // Assert
        title = Page.Title();
        Assert.AreEqual("wikipedia - Google Search", title);

        // Arrange
        Page.ClearSearchText();

        // Act
        Page.SearchByText("archive");

        // Assert
        title = Page.Title();
        Assert.AreEqual("archive - Google Search", title);
    }

    [UITest]
    [RestartOnException(3)]
    public void TestMethod84()
    {
        // Act
        Page.OpenSearchPage();

        // Assert
        var title = Page.Title();
        Assert.AreEqual("Google", title);

        // Act
        Page.SearchByText("wikipedia");

        // Assert
        title = Page.Title();
        Assert.AreEqual("wikipedia - Google Search", title);

        // Arrange
        Page.ClearSearchText();

        // Act
        Page.SearchByText("archive");

        // Assert
        title = Page.Title();
        Assert.AreEqual("archive - Google Search", title);
    }

    [UITest]
    [RestartOnException(3)]
    public void TestMethod85()
    {
        // Act
        Page.OpenSearchPage();

        // Assert
        var title = Page.Title();
        Assert.AreEqual("Google", title);

        // Act
        Page.SearchByText("wikipedia");

        // Assert
        title = Page.Title();
        Assert.AreEqual("wikipedia - Google Search", title);

        // Arrange
        Page.ClearSearchText();

        // Act
        Page.SearchByText("archive");

        // Assert
        title = Page.Title();
        Assert.AreEqual("archive - Google Search", title);
    }

    [UITest]
    [RestartOnException(3)]
    public void TestMethod86()
    {
        // Act
        Page.OpenSearchPage();

        // Assert
        var title = Page.Title();
        Assert.AreEqual("Google", title);

        // Act
        Page.SearchByText("wikipedia");

        // Assert
        title = Page.Title();
        Assert.AreEqual("wikipedia - Google Search", title);

        // Arrange
        Page.ClearSearchText();

        // Act
        Page.SearchByText("archive");

        // Assert
        title = Page.Title();
        Assert.AreEqual("archive - Google Search", title);
    }

    [UITest]
    [RestartOnException(3)]
    public void TestMethod87()
    {
        // Act
        Page.OpenSearchPage();

        // Assert
        var title = Page.Title();
        Assert.AreEqual("Google", title);

        // Act
        Page.SearchByText("wikipedia");

        // Assert
        title = Page.Title();
        Assert.AreEqual("wikipedia - Google Search", title);

        // Arrange
        Page.ClearSearchText();

        // Act
        Page.SearchByText("archive");

        // Assert
        title = Page.Title();
        Assert.AreEqual("archive - Google Search", title);
    }

    [UITest]
    [RestartOnException(3)]
    public void TestMethod88()
    {
        // Act
        Page.OpenSearchPage();

        // Assert
        var title = Page.Title();
        Assert.AreEqual("Google", title);

        // Act
        Page.SearchByText("wikipedia");

        // Assert
        title = Page.Title();
        Assert.AreEqual("wikipedia - Google Search", title);

        // Arrange
        Page.ClearSearchText();

        // Act
        Page.SearchByText("archive");

        // Assert
        title = Page.Title();
        Assert.AreEqual("archive - Google Search", title);
    }

    [UITest]
    [RestartOnException(3)]
    public void TestMethod89()
    {
        // Act
        Page.OpenSearchPage();

        // Assert
        var title = Page.Title();
        Assert.AreEqual("Google", title);

        // Act
        Page.SearchByText("wikipedia");

        // Assert
        title = Page.Title();
        Assert.AreEqual("wikipedia - Google Search", title);

        // Arrange
        Page.ClearSearchText();

        // Act
        Page.SearchByText("archive");

        // Assert
        title = Page.Title();
        Assert.AreEqual("archive - Google Search", title);
    }

    [UITest]
    [RestartOnException(3)]
    public void TestMethod90()
    {
        // Act
        Page.OpenSearchPage();

        // Assert
        var title = Page.Title();
        Assert.AreEqual("Google", title);

        // Act
        Page.SearchByText("wikipedia");

        // Assert
        title = Page.Title();
        Assert.AreEqual("wikipedia - Google Search", title);

        // Arrange
        Page.ClearSearchText();

        // Act
        Page.SearchByText("archive");

        // Assert
        title = Page.Title();
        Assert.AreEqual("archive - Google Search", title);
    }

    [UITest]
    [RestartOnException(3)]
    public void TestMethod91()
    {
        // Act
        Page.OpenSearchPage();

        // Assert
        var title = Page.Title();
        Assert.AreEqual("Google", title);

        // Act
        Page.SearchByText("wikipedia");

        // Assert
        title = Page.Title();
        Assert.AreEqual("wikipedia - Google Search", title);

        // Arrange
        Page.ClearSearchText();

        // Act
        Page.SearchByText("archive");

        // Assert
        title = Page.Title();
        Assert.AreEqual("archive - Google Search", title);
    }

    [UITest]
    [RestartOnException(3)]
    public void TestMethod92()
    {
        // Act
        Page.OpenSearchPage();

        // Assert
        var title = Page.Title();
        Assert.AreEqual("Google", title);

        // Act
        Page.SearchByText("wikipedia");

        // Assert
        title = Page.Title();
        Assert.AreEqual("wikipedia - Google Search", title);

        // Arrange
        Page.ClearSearchText();

        // Act
        Page.SearchByText("archive");

        // Assert
        title = Page.Title();
        Assert.AreEqual("archive - Google Search", title);
    }

    [UITest]
    [RestartOnException(3)]
    public void TestMethod93()
    {
        // Act
        Page.OpenSearchPage();

        // Assert
        var title = Page.Title();
        Assert.AreEqual("Google", title);

        // Act
        Page.SearchByText("wikipedia");

        // Assert
        title = Page.Title();
        Assert.AreEqual("wikipedia - Google Search", title);

        // Arrange
        Page.ClearSearchText();

        // Act
        Page.SearchByText("archive");

        // Assert
        title = Page.Title();
        Assert.AreEqual("archive - Google Search", title);
    }

    [UITest]
    [RestartOnException(3)]
    public void TestMethod94()
    {
        // Act
        Page.OpenSearchPage();

        // Assert
        var title = Page.Title();
        Assert.AreEqual("Google", title);

        // Act
        Page.SearchByText("wikipedia");

        // Assert
        title = Page.Title();
        Assert.AreEqual("wikipedia - Google Search", title);

        // Arrange
        Page.ClearSearchText();

        // Act
        Page.SearchByText("archive");

        // Assert
        title = Page.Title();
        Assert.AreEqual("archive - Google Search", title);
    }

    [UITest]
    [RestartOnException(3)]
    public void TestMethod95()
    {
        // Act
        Page.OpenSearchPage();

        // Assert
        var title = Page.Title();
        Assert.AreEqual("Google", title);

        // Act
        Page.SearchByText("wikipedia");

        // Assert
        title = Page.Title();
        Assert.AreEqual("wikipedia - Google Search", title);

        // Arrange
        Page.ClearSearchText();

        // Act
        Page.SearchByText("archive");

        // Assert
        title = Page.Title();
        Assert.AreEqual("archive - Google Search", title);
    }

    [UITest]
    [RestartOnException(3)]
    public void TestMethod96()
    {
        // Act
        Page.OpenSearchPage();

        // Assert
        var title = Page.Title();
        Assert.AreEqual("Google", title);

        // Act
        Page.SearchByText("wikipedia");

        // Assert
        title = Page.Title();
        Assert.AreEqual("wikipedia - Google Search", title);

        // Arrange
        Page.ClearSearchText();

        // Act
        Page.SearchByText("archive");

        // Assert
        title = Page.Title();
        Assert.AreEqual("archive - Google Search", title);
    }

    [UITest]
    [RestartOnException(3)]
    public void TestMethod97()
    {
        // Act
        Page.OpenSearchPage();

        // Assert
        var title = Page.Title();
        Assert.AreEqual("Google", title);

        // Act
        Page.SearchByText("wikipedia");

        // Assert
        title = Page.Title();
        Assert.AreEqual("wikipedia - Google Search", title);

        // Arrange
        Page.ClearSearchText();

        // Act
        Page.SearchByText("archive");

        // Assert
        title = Page.Title();
        Assert.AreEqual("archive - Google Search", title);
    }

    [UITest]
    [RestartOnException(3)]
    public void TestMethod98()
    {
        // Act
        Page.OpenSearchPage();

        // Assert
        var title = Page.Title();
        Assert.AreEqual("Google", title);

        // Act
        Page.SearchByText("wikipedia");

        // Assert
        title = Page.Title();
        Assert.AreEqual("wikipedia - Google Search", title);

        // Arrange
        Page.ClearSearchText();

        // Act
        Page.SearchByText("archive");

        // Assert
        title = Page.Title();
        Assert.AreEqual("archive - Google Search", title);
    }

    [UITest]
    [RestartOnException(3)]
    public void TestMethod99()
    {
        // Act
        Page.OpenSearchPage();

        // Assert
        var title = Page.Title();
        Assert.AreEqual("Google", title);

        // Act
        Page.SearchByText("wikipedia");

        // Assert
        title = Page.Title();
        Assert.AreEqual("wikipedia - Google Search", title);

        // Arrange
        Page.ClearSearchText();

        // Act
        Page.SearchByText("archive");

        // Assert
        title = Page.Title();
        Assert.AreEqual("archive - Google Search", title);
    }

    [UITest]
    [RestartOnException(3)]
    public void TestMethod100()
    {
        // Act
        Page.OpenSearchPage();

        // Assert
        var title = Page.Title();
        Assert.AreEqual("Google", title);

        // Act
        Page.SearchByText("wikipedia");

        // Assert
        title = Page.Title();
        Assert.AreEqual("wikipedia - Google Search", title);

        // Arrange
        Page.ClearSearchText();

        // Act
        Page.SearchByText("archive");

        // Assert
        title = Page.Title();
        Assert.AreEqual("archive - Google Search", title);
    }
}