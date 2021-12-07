using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.Playwright.MSTest;
using System.Threading.Tasks;
using Playwright.Synchronous;
using TestParallel.ActionExtensions;

namespace TestParallel.PlaywrightSyncMSTest;

[TestClass]
public class Tests : PageTest
{
    [TestMethod]
    public void TestMethod1()
    {
        // Act
        Page.Goto("https://bing.com");

        // Assert
        var title = Page.Title();
        Assert.AreEqual("Bing", title);

        // Act
        Page.Type("input#sb_form_q", "wikipedia");
        Page.Press("input#sb_form_q", "Enter");

        // Assert
        title = Page.Title();
        Assert.AreEqual("wikipedia - Bing", title);

        // Arrange
        var searchInputElement = Page.QuerySelector("input#sb_form_q");
        var inputValue = Page.Evaluate<string>("(e) => e.value", searchInputElement);
        var inputLength = inputValue.Length;

        Page.Focus("input#sb_form_q");
        Page.Keyboard.Press("End");
        for (var i = 0; i < inputLength; i++)
        {
            Page.Keyboard.Press("Backspace");
        }

        // Act
        Page.Type("input#sb_form_q", "archive");
        Page.Press("input#sb_form_q", "Enter");

        // Arrange
        title = Page.Title();
        Assert.AreEqual("archive - Bing", title);
    }

    [TestMethod]
    public void TestMethod2()
    {
        // Act
        Page.OpenBingCom();

        // Assert
        var title = Page.Title();
        Assert.AreEqual("Bing", title);

        // Act
        Page.SearchByText("wikipedia");

        // Assert
        title = Page.Title();
        Assert.AreEqual("wikipedia - Bing", title);

        // Arrange
        Page.ClearSearchText();

        // Act
        Page.SearchByText("archive");

        // Arrange
        title = Page.Title();
        Assert.AreEqual("archive - Bing", title);
    }

    [TestMethod]
    public void TestMethod3()
    {
        // Act
        Page.OpenBingCom();

        // Assert
        var title = Page.Title();
        Assert.AreEqual("Bing", title);

        // Act
        Page.SearchByText("wikipedia");

        // Assert
        title = Page.Title();
        Assert.AreEqual("wikipedia - Bing", title);

        // Arrange
        Page.ClearSearchText();

        // Act
        Page.SearchByText("archive");

        // Arrange
        title = Page.Title();
        Assert.AreEqual("archive - Bing", title);
    }

    [TestMethod]
    public void TestMethod4()
    {
        // Act
        Page.OpenBingCom();

        // Assert
        var title = Page.Title();
        Assert.AreEqual("Bing", title);

        // Act
        Page.SearchByText("wikipedia");

        // Assert
        title = Page.Title();
        Assert.AreEqual("wikipedia - Bing", title);

        // Arrange
        Page.ClearSearchText();

        // Act
        Page.SearchByText("archive");

        // Arrange
        title = Page.Title();
        Assert.AreEqual("archive - Bing", title);
    }

    [TestMethod]
    public void TestMethod5()
    {
        // Act
        Page.OpenBingCom();

        // Assert
        var title = Page.Title();
        Assert.AreEqual("Bing", title);

        // Act
        Page.SearchByText("wikipedia");

        // Assert
        title = Page.Title();
        Assert.AreEqual("wikipedia - Bing", title);

        // Arrange
        Page.ClearSearchText();

        // Act
        Page.SearchByText("archive");

        // Arrange
        title = Page.Title();
        Assert.AreEqual("archive - Bing", title);
    }

    [TestMethod]
    public void TestMethod6()
    {
        // Act
        Page.OpenBingCom();

        // Assert
        var title = Page.Title();
        Assert.AreEqual("Bing", title);

        // Act
        Page.SearchByText("wikipedia");

        // Assert
        title = Page.Title();
        Assert.AreEqual("wikipedia - Bing", title);

        // Arrange
        Page.ClearSearchText();

        // Act
        Page.SearchByText("archive");

        // Arrange
        title = Page.Title();
        Assert.AreEqual("archive - Bing", title);
    }

    [TestMethod]
    public void TestMethod7()
    {
        // Act
        Page.OpenBingCom();

        // Assert
        var title = Page.Title();
        Assert.AreEqual("Bing", title);

        // Act
        Page.SearchByText("wikipedia");

        // Assert
        title = Page.Title();
        Assert.AreEqual("wikipedia - Bing", title);

        // Arrange
        Page.ClearSearchText();

        // Act
        Page.SearchByText("archive");

        // Arrange
        title = Page.Title();
        Assert.AreEqual("archive - Bing", title);
    }

    [TestMethod]
    public void TestMethod8()
    {
        // Act
        Page.OpenBingCom();

        // Assert
        var title = Page.Title();
        Assert.AreEqual("Bing", title);

        // Act
        Page.SearchByText("wikipedia");

        // Assert
        title = Page.Title();
        Assert.AreEqual("wikipedia - Bing", title);

        // Arrange
        Page.ClearSearchText();

        // Act
        Page.SearchByText("archive");

        // Arrange
        title = Page.Title();
        Assert.AreEqual("archive - Bing", title);
    }

    [TestMethod]
    public void TestMethod9()
    {
        // Act
        Page.OpenBingCom();

        // Assert
        var title = Page.Title();
        Assert.AreEqual("Bing", title);

        // Act
        Page.SearchByText("wikipedia");

        // Assert
        title = Page.Title();
        Assert.AreEqual("wikipedia - Bing", title);

        // Arrange
        Page.ClearSearchText();

        // Act
        Page.SearchByText("archive");

        // Arrange
        title = Page.Title();
        Assert.AreEqual("archive - Bing", title);
    }

    [TestMethod]
    public void TestMethod10()
    {
        // Act
        Page.OpenBingCom();

        // Assert
        var title = Page.Title();
        Assert.AreEqual("Bing", title);

        // Act
        Page.SearchByText("wikipedia");

        // Assert
        title = Page.Title();
        Assert.AreEqual("wikipedia - Bing", title);

        // Arrange
        Page.ClearSearchText();

        // Act
        Page.SearchByText("archive");

        // Arrange
        title = Page.Title();
        Assert.AreEqual("archive - Bing", title);
    }

    [TestMethod]
    public void TestMethod11()
    {
        // Act
        Page.OpenBingCom();

        // Assert
        var title = Page.Title();
        Assert.AreEqual("Bing", title);

        // Act
        Page.SearchByText("wikipedia");

        // Assert
        title = Page.Title();
        Assert.AreEqual("wikipedia - Bing", title);

        // Arrange
        Page.ClearSearchText();

        // Act
        Page.SearchByText("archive");

        // Arrange
        title = Page.Title();
        Assert.AreEqual("archive - Bing", title);
    }

    [TestMethod]
    public void TestMethod12()
    {
        // Act
        Page.OpenBingCom();

        // Assert
        var title = Page.Title();
        Assert.AreEqual("Bing", title);

        // Act
        Page.SearchByText("wikipedia");

        // Assert
        title = Page.Title();
        Assert.AreEqual("wikipedia - Bing", title);

        // Arrange
        Page.ClearSearchText();

        // Act
        Page.SearchByText("archive");

        // Arrange
        title = Page.Title();
        Assert.AreEqual("archive - Bing", title);
    }

    [TestMethod]
    public void TestMethod13()
    {
        // Act
        Page.OpenBingCom();

        // Assert
        var title = Page.Title();
        Assert.AreEqual("Bing", title);

        // Act
        Page.SearchByText("wikipedia");

        // Assert
        title = Page.Title();
        Assert.AreEqual("wikipedia - Bing", title);

        // Arrange
        Page.ClearSearchText();

        // Act
        Page.SearchByText("archive");

        // Arrange
        title = Page.Title();
        Assert.AreEqual("archive - Bing", title);
    }

    [TestMethod]
    public void TestMethod14()
    {
        // Act
        Page.OpenBingCom();

        // Assert
        var title = Page.Title();
        Assert.AreEqual("Bing", title);

        // Act
        Page.SearchByText("wikipedia");

        // Assert
        title = Page.Title();
        Assert.AreEqual("wikipedia - Bing", title);

        // Arrange
        Page.ClearSearchText();

        // Act
        Page.SearchByText("archive");

        // Arrange
        title = Page.Title();
        Assert.AreEqual("archive - Bing", title);
    }

    [TestMethod]
    public void TestMethod15()
    {
        // Act
        Page.OpenBingCom();

        // Assert
        var title = Page.Title();
        Assert.AreEqual("Bing", title);

        // Act
        Page.SearchByText("wikipedia");

        // Assert
        title = Page.Title();
        Assert.AreEqual("wikipedia - Bing", title);

        // Arrange
        Page.ClearSearchText();

        // Act
        Page.SearchByText("archive");

        // Arrange
        title = Page.Title();
        Assert.AreEqual("archive - Bing", title);
    }

    [TestMethod]
    public void TestMethod16()
    {
        // Act
        Page.OpenBingCom();

        // Assert
        var title = Page.Title();
        Assert.AreEqual("Bing", title);

        // Act
        Page.SearchByText("wikipedia");

        // Assert
        title = Page.Title();
        Assert.AreEqual("wikipedia - Bing", title);

        // Arrange
        Page.ClearSearchText();

        // Act
        Page.SearchByText("archive");

        // Arrange
        title = Page.Title();
        Assert.AreEqual("archive - Bing", title);
    }

    [TestMethod]
    public void TestMethod17()
    {
        // Act
        Page.OpenBingCom();

        // Assert
        var title = Page.Title();
        Assert.AreEqual("Bing", title);

        // Act
        Page.SearchByText("wikipedia");

        // Assert
        title = Page.Title();
        Assert.AreEqual("wikipedia - Bing", title);

        // Arrange
        Page.ClearSearchText();

        // Act
        Page.SearchByText("archive");

        // Arrange
        title = Page.Title();
        Assert.AreEqual("archive - Bing", title);
    }

    [TestMethod]
    public void TestMethod18()
    {
        // Act
        Page.OpenBingCom();

        // Assert
        var title = Page.Title();
        Assert.AreEqual("Bing", title);

        // Act
        Page.SearchByText("wikipedia");

        // Assert
        title = Page.Title();
        Assert.AreEqual("wikipedia - Bing", title);

        // Arrange
        Page.ClearSearchText();

        // Act
        Page.SearchByText("archive");

        // Arrange
        title = Page.Title();
        Assert.AreEqual("archive - Bing", title);
    }

    [TestMethod]
    public void TestMethod19()
    {
        // Act
        Page.OpenBingCom();

        // Assert
        var title = Page.Title();
        Assert.AreEqual("Bing", title);

        // Act
        Page.SearchByText("wikipedia");

        // Assert
        title = Page.Title();
        Assert.AreEqual("wikipedia - Bing", title);

        // Arrange
        Page.ClearSearchText();

        // Act
        Page.SearchByText("archive");

        // Arrange
        title = Page.Title();
        Assert.AreEqual("archive - Bing", title);
    }

    [TestMethod]
    public void TestMethod20()
    {
        // Act
        Page.OpenBingCom();

        // Assert
        var title = Page.Title();
        Assert.AreEqual("Bing", title);

        // Act
        Page.SearchByText("wikipedia");

        // Assert
        title = Page.Title();
        Assert.AreEqual("wikipedia - Bing", title);

        // Arrange
        Page.ClearSearchText();

        // Act
        Page.SearchByText("archive");

        // Arrange
        title = Page.Title();
        Assert.AreEqual("archive - Bing", title);
    }

    [TestMethod]
    public void TestMethod21()
    {
        // Act
        Page.OpenBingCom();

        // Assert
        var title = Page.Title();
        Assert.AreEqual("Bing", title);

        // Act
        Page.SearchByText("wikipedia");

        // Assert
        title = Page.Title();
        Assert.AreEqual("wikipedia - Bing", title);

        // Arrange
        Page.ClearSearchText();

        // Act
        Page.SearchByText("archive");

        // Arrange
        title = Page.Title();
        Assert.AreEqual("archive - Bing", title);
    }

    [TestMethod]
    public void TestMethod22()
    {
        // Act
        Page.OpenBingCom();

        // Assert
        var title = Page.Title();
        Assert.AreEqual("Bing", title);

        // Act
        Page.SearchByText("wikipedia");

        // Assert
        title = Page.Title();
        Assert.AreEqual("wikipedia - Bing", title);

        // Arrange
        Page.ClearSearchText();

        // Act
        Page.SearchByText("archive");

        // Arrange
        title = Page.Title();
        Assert.AreEqual("archive - Bing", title);
    }

    [TestMethod]
    public void TestMethod23()
    {
        // Act
        Page.OpenBingCom();

        // Assert
        var title = Page.Title();
        Assert.AreEqual("Bing", title);

        // Act
        Page.SearchByText("wikipedia");

        // Assert
        title = Page.Title();
        Assert.AreEqual("wikipedia - Bing", title);

        // Arrange
        Page.ClearSearchText();

        // Act
        Page.SearchByText("archive");

        // Arrange
        title = Page.Title();
        Assert.AreEqual("archive - Bing", title);
    }

    [TestMethod]
    public void TestMethod24()
    {
        // Act
        Page.OpenBingCom();

        // Assert
        var title = Page.Title();
        Assert.AreEqual("Bing", title);

        // Act
        Page.SearchByText("wikipedia");

        // Assert
        title = Page.Title();
        Assert.AreEqual("wikipedia - Bing", title);

        // Arrange
        Page.ClearSearchText();

        // Act
        Page.SearchByText("archive");

        // Arrange
        title = Page.Title();
        Assert.AreEqual("archive - Bing", title);
    }

    [TestMethod]
    public void TestMethod25()
    {
        // Act
        Page.OpenBingCom();

        // Assert
        var title = Page.Title();
        Assert.AreEqual("Bing", title);

        // Act
        Page.SearchByText("wikipedia");

        // Assert
        title = Page.Title();
        Assert.AreEqual("wikipedia - Bing", title);

        // Arrange
        Page.ClearSearchText();

        // Act
        Page.SearchByText("archive");

        // Arrange
        title = Page.Title();
        Assert.AreEqual("archive - Bing", title);
    }

    [TestMethod]
    public void TestMethod26()
    {
        // Act
        Page.OpenBingCom();

        // Assert
        var title = Page.Title();
        Assert.AreEqual("Bing", title);

        // Act
        Page.SearchByText("wikipedia");

        // Assert
        title = Page.Title();
        Assert.AreEqual("wikipedia - Bing", title);

        // Arrange
        Page.ClearSearchText();

        // Act
        Page.SearchByText("archive");

        // Arrange
        title = Page.Title();
        Assert.AreEqual("archive - Bing", title);
    }

    [TestMethod]
    public void TestMethod27()
    {
        // Act
        Page.OpenBingCom();

        // Assert
        var title = Page.Title();
        Assert.AreEqual("Bing", title);

        // Act
        Page.SearchByText("wikipedia");

        // Assert
        title = Page.Title();
        Assert.AreEqual("wikipedia - Bing", title);

        // Arrange
        Page.ClearSearchText();

        // Act
        Page.SearchByText("archive");

        // Arrange
        title = Page.Title();
        Assert.AreEqual("archive - Bing", title);
    }

    [TestMethod]
    public void TestMethod28()
    {
        // Act
        Page.OpenBingCom();

        // Assert
        var title = Page.Title();
        Assert.AreEqual("Bing", title);

        // Act
        Page.SearchByText("wikipedia");

        // Assert
        title = Page.Title();
        Assert.AreEqual("wikipedia - Bing", title);

        // Arrange
        Page.ClearSearchText();

        // Act
        Page.SearchByText("archive");

        // Arrange
        title = Page.Title();
        Assert.AreEqual("archive - Bing", title);
    }

    [TestMethod]
    public void TestMethod29()
    {
        // Act
        Page.OpenBingCom();

        // Assert
        var title = Page.Title();
        Assert.AreEqual("Bing", title);

        // Act
        Page.SearchByText("wikipedia");

        // Assert
        title = Page.Title();
        Assert.AreEqual("wikipedia - Bing", title);

        // Arrange
        Page.ClearSearchText();

        // Act
        Page.SearchByText("archive");

        // Arrange
        title = Page.Title();
        Assert.AreEqual("archive - Bing", title);
    }

    [TestMethod]
    public void TestMethod30()
    {
        // Act
        Page.OpenBingCom();

        // Assert
        var title = Page.Title();
        Assert.AreEqual("Bing", title);

        // Act
        Page.SearchByText("wikipedia");

        // Assert
        title = Page.Title();
        Assert.AreEqual("wikipedia - Bing", title);

        // Arrange
        Page.ClearSearchText();

        // Act
        Page.SearchByText("archive");

        // Arrange
        title = Page.Title();
        Assert.AreEqual("archive - Bing", title);
    }

    [TestMethod]
    public void TestMethod31()
    {
        // Act
        Page.OpenBingCom();

        // Assert
        var title = Page.Title();
        Assert.AreEqual("Bing", title);

        // Act
        Page.SearchByText("wikipedia");

        // Assert
        title = Page.Title();
        Assert.AreEqual("wikipedia - Bing", title);

        // Arrange
        Page.ClearSearchText();

        // Act
        Page.SearchByText("archive");

        // Arrange
        title = Page.Title();
        Assert.AreEqual("archive - Bing", title);
    }

    [TestMethod]
    public void TestMethod32()
    {
        // Act
        Page.OpenBingCom();

        // Assert
        var title = Page.Title();
        Assert.AreEqual("Bing", title);

        // Act
        Page.SearchByText("wikipedia");

        // Assert
        title = Page.Title();
        Assert.AreEqual("wikipedia - Bing", title);

        // Arrange
        Page.ClearSearchText();

        // Act
        Page.SearchByText("archive");

        // Arrange
        title = Page.Title();
        Assert.AreEqual("archive - Bing", title);
    }

    [TestMethod]
    public void TestMethod33()
    {
        // Act
        Page.OpenBingCom();

        // Assert
        var title = Page.Title();
        Assert.AreEqual("Bing", title);

        // Act
        Page.SearchByText("wikipedia");

        // Assert
        title = Page.Title();
        Assert.AreEqual("wikipedia - Bing", title);

        // Arrange
        Page.ClearSearchText();

        // Act
        Page.SearchByText("archive");

        // Arrange
        title = Page.Title();
        Assert.AreEqual("archive - Bing", title);
    }

    [TestMethod]
    public void TestMethod34()
    {
        // Act
        Page.OpenBingCom();

        // Assert
        var title = Page.Title();
        Assert.AreEqual("Bing", title);

        // Act
        Page.SearchByText("wikipedia");

        // Assert
        title = Page.Title();
        Assert.AreEqual("wikipedia - Bing", title);

        // Arrange
        Page.ClearSearchText();

        // Act
        Page.SearchByText("archive");

        // Arrange
        title = Page.Title();
        Assert.AreEqual("archive - Bing", title);
    }

    [TestMethod]
    public void TestMethod35()
    {
        // Act
        Page.OpenBingCom();

        // Assert
        var title = Page.Title();
        Assert.AreEqual("Bing", title);

        // Act
        Page.SearchByText("wikipedia");

        // Assert
        title = Page.Title();
        Assert.AreEqual("wikipedia - Bing", title);

        // Arrange
        Page.ClearSearchText();

        // Act
        Page.SearchByText("archive");

        // Arrange
        title = Page.Title();
        Assert.AreEqual("archive - Bing", title);
    }

    [TestMethod]
    public void TestMethod36()
    {
        // Act
        Page.OpenBingCom();

        // Assert
        var title = Page.Title();
        Assert.AreEqual("Bing", title);

        // Act
        Page.SearchByText("wikipedia");

        // Assert
        title = Page.Title();
        Assert.AreEqual("wikipedia - Bing", title);

        // Arrange
        Page.ClearSearchText();

        // Act
        Page.SearchByText("archive");

        // Arrange
        title = Page.Title();
        Assert.AreEqual("archive - Bing", title);
    }

    [TestMethod]
    public void TestMethod37()
    {
        // Act
        Page.OpenBingCom();

        // Assert
        var title = Page.Title();
        Assert.AreEqual("Bing", title);

        // Act
        Page.SearchByText("wikipedia");

        // Assert
        title = Page.Title();
        Assert.AreEqual("wikipedia - Bing", title);

        // Arrange
        Page.ClearSearchText();

        // Act
        Page.SearchByText("archive");

        // Arrange
        title = Page.Title();
        Assert.AreEqual("archive - Bing", title);
    }

    [TestMethod]
    public void TestMethod38()
    {
        // Act
        Page.OpenBingCom();

        // Assert
        var title = Page.Title();
        Assert.AreEqual("Bing", title);

        // Act
        Page.SearchByText("wikipedia");

        // Assert
        title = Page.Title();
        Assert.AreEqual("wikipedia - Bing", title);

        // Arrange
        Page.ClearSearchText();

        // Act
        Page.SearchByText("archive");

        // Arrange
        title = Page.Title();
        Assert.AreEqual("archive - Bing", title);
    }

    [TestMethod]
    public void TestMethod39()
    {
        // Act
        Page.OpenBingCom();

        // Assert
        var title = Page.Title();
        Assert.AreEqual("Bing", title);

        // Act
        Page.SearchByText("wikipedia");

        // Assert
        title = Page.Title();
        Assert.AreEqual("wikipedia - Bing", title);

        // Arrange
        Page.ClearSearchText();

        // Act
        Page.SearchByText("archive");

        // Arrange
        title = Page.Title();
        Assert.AreEqual("archive - Bing", title);
    }

    [TestMethod]
    public void TestMethod40()
    {
        // Act
        Page.OpenBingCom();

        // Assert
        var title = Page.Title();
        Assert.AreEqual("Bing", title);

        // Act
        Page.SearchByText("wikipedia");

        // Assert
        title = Page.Title();
        Assert.AreEqual("wikipedia - Bing", title);

        // Arrange
        Page.ClearSearchText();

        // Act
        Page.SearchByText("archive");

        // Arrange
        title = Page.Title();
        Assert.AreEqual("archive - Bing", title);
    }

    [TestMethod]
    public void TestMethod41()
    {
        // Act
        Page.OpenBingCom();

        // Assert
        var title = Page.Title();
        Assert.AreEqual("Bing", title);

        // Act
        Page.SearchByText("wikipedia");

        // Assert
        title = Page.Title();
        Assert.AreEqual("wikipedia - Bing", title);

        // Arrange
        Page.ClearSearchText();

        // Act
        Page.SearchByText("archive");

        // Arrange
        title = Page.Title();
        Assert.AreEqual("archive - Bing", title);
    }

    [TestMethod]
    public void TestMethod42()
    {
        // Act
        Page.OpenBingCom();

        // Assert
        var title = Page.Title();
        Assert.AreEqual("Bing", title);

        // Act
        Page.SearchByText("wikipedia");

        // Assert
        title = Page.Title();
        Assert.AreEqual("wikipedia - Bing", title);

        // Arrange
        Page.ClearSearchText();

        // Act
        Page.SearchByText("archive");

        // Arrange
        title = Page.Title();
        Assert.AreEqual("archive - Bing", title);
    }

    [TestMethod]
    public void TestMethod43()
    {
        // Act
        Page.OpenBingCom();

        // Assert
        var title = Page.Title();
        Assert.AreEqual("Bing", title);

        // Act
        Page.SearchByText("wikipedia");

        // Assert
        title = Page.Title();
        Assert.AreEqual("wikipedia - Bing", title);

        // Arrange
        Page.ClearSearchText();

        // Act
        Page.SearchByText("archive");

        // Arrange
        title = Page.Title();
        Assert.AreEqual("archive - Bing", title);
    }

    [TestMethod]
    public void TestMethod44()
    {
        // Act
        Page.OpenBingCom();

        // Assert
        var title = Page.Title();
        Assert.AreEqual("Bing", title);

        // Act
        Page.SearchByText("wikipedia");

        // Assert
        title = Page.Title();
        Assert.AreEqual("wikipedia - Bing", title);

        // Arrange
        Page.ClearSearchText();

        // Act
        Page.SearchByText("archive");

        // Arrange
        title = Page.Title();
        Assert.AreEqual("archive - Bing", title);
    }

    [TestMethod]
    public void TestMethod45()
    {
        // Act
        Page.OpenBingCom();

        // Assert
        var title = Page.Title();
        Assert.AreEqual("Bing", title);

        // Act
        Page.SearchByText("wikipedia");

        // Assert
        title = Page.Title();
        Assert.AreEqual("wikipedia - Bing", title);

        // Arrange
        Page.ClearSearchText();

        // Act
        Page.SearchByText("archive");

        // Arrange
        title = Page.Title();
        Assert.AreEqual("archive - Bing", title);
    }

    [TestMethod]
    public void TestMethod46()
    {
        // Act
        Page.OpenBingCom();

        // Assert
        var title = Page.Title();
        Assert.AreEqual("Bing", title);

        // Act
        Page.SearchByText("wikipedia");

        // Assert
        title = Page.Title();
        Assert.AreEqual("wikipedia - Bing", title);

        // Arrange
        Page.ClearSearchText();

        // Act
        Page.SearchByText("archive");

        // Arrange
        title = Page.Title();
        Assert.AreEqual("archive - Bing", title);
    }

    [TestMethod]
    public void TestMethod47()
    {
        // Act
        Page.OpenBingCom();

        // Assert
        var title = Page.Title();
        Assert.AreEqual("Bing", title);

        // Act
        Page.SearchByText("wikipedia");

        // Assert
        title = Page.Title();
        Assert.AreEqual("wikipedia - Bing", title);

        // Arrange
        Page.ClearSearchText();

        // Act
        Page.SearchByText("archive");

        // Arrange
        title = Page.Title();
        Assert.AreEqual("archive - Bing", title);
    }

    [TestMethod]
    public void TestMethod48()
    {
        // Act
        Page.OpenBingCom();

        // Assert
        var title = Page.Title();
        Assert.AreEqual("Bing", title);

        // Act
        Page.SearchByText("wikipedia");

        // Assert
        title = Page.Title();
        Assert.AreEqual("wikipedia - Bing", title);

        // Arrange
        Page.ClearSearchText();

        // Act
        Page.SearchByText("archive");

        // Arrange
        title = Page.Title();
        Assert.AreEqual("archive - Bing", title);
    }

    [TestMethod]
    public void TestMethod49()
    {
        // Act
        Page.OpenBingCom();

        // Assert
        var title = Page.Title();
        Assert.AreEqual("Bing", title);

        // Act
        Page.SearchByText("wikipedia");

        // Assert
        title = Page.Title();
        Assert.AreEqual("wikipedia - Bing", title);

        // Arrange
        Page.ClearSearchText();

        // Act
        Page.SearchByText("archive");

        // Arrange
        title = Page.Title();
        Assert.AreEqual("archive - Bing", title);
    }

    [TestMethod]
    public void TestMethod50()
    {
        // Act
        Page.OpenBingCom();

        // Assert
        var title = Page.Title();
        Assert.AreEqual("Bing", title);

        // Act
        Page.SearchByText("wikipedia");

        // Assert
        title = Page.Title();
        Assert.AreEqual("wikipedia - Bing", title);

        // Arrange
        Page.ClearSearchText();

        // Act
        Page.SearchByText("archive");

        // Arrange
        title = Page.Title();
        Assert.AreEqual("archive - Bing", title);
    }

    [TestMethod]
    public void TestMethod51()
    {
        // Act
        Page.OpenBingCom();

        // Assert
        var title = Page.Title();
        Assert.AreEqual("Bing", title);

        // Act
        Page.SearchByText("wikipedia");

        // Assert
        title = Page.Title();
        Assert.AreEqual("wikipedia - Bing", title);

        // Arrange
        Page.ClearSearchText();

        // Act
        Page.SearchByText("archive");

        // Arrange
        title = Page.Title();
        Assert.AreEqual("archive - Bing", title);
    }

    [TestMethod]
    public void TestMethod52()
    {
        // Act
        Page.OpenBingCom();

        // Assert
        var title = Page.Title();
        Assert.AreEqual("Bing", title);

        // Act
        Page.SearchByText("wikipedia");

        // Assert
        title = Page.Title();
        Assert.AreEqual("wikipedia - Bing", title);

        // Arrange
        Page.ClearSearchText();

        // Act
        Page.SearchByText("archive");

        // Arrange
        title = Page.Title();
        Assert.AreEqual("archive - Bing", title);
    }

    [TestMethod]
    public void TestMethod53()
    {
        // Act
        Page.OpenBingCom();

        // Assert
        var title = Page.Title();
        Assert.AreEqual("Bing", title);

        // Act
        Page.SearchByText("wikipedia");

        // Assert
        title = Page.Title();
        Assert.AreEqual("wikipedia - Bing", title);

        // Arrange
        Page.ClearSearchText();

        // Act
        Page.SearchByText("archive");

        // Arrange
        title = Page.Title();
        Assert.AreEqual("archive - Bing", title);
    }

    [TestMethod]
    public void TestMethod54()
    {
        // Act
        Page.OpenBingCom();

        // Assert
        var title = Page.Title();
        Assert.AreEqual("Bing", title);

        // Act
        Page.SearchByText("wikipedia");

        // Assert
        title = Page.Title();
        Assert.AreEqual("wikipedia - Bing", title);

        // Arrange
        Page.ClearSearchText();

        // Act
        Page.SearchByText("archive");

        // Arrange
        title = Page.Title();
        Assert.AreEqual("archive - Bing", title);
    }

    [TestMethod]
    public void TestMethod55()
    {
        // Act
        Page.OpenBingCom();

        // Assert
        var title = Page.Title();
        Assert.AreEqual("Bing", title);

        // Act
        Page.SearchByText("wikipedia");

        // Assert
        title = Page.Title();
        Assert.AreEqual("wikipedia - Bing", title);

        // Arrange
        Page.ClearSearchText();

        // Act
        Page.SearchByText("archive");

        // Arrange
        title = Page.Title();
        Assert.AreEqual("archive - Bing", title);
    }

    [TestMethod]
    public void TestMethod56()
    {
        // Act
        Page.OpenBingCom();

        // Assert
        var title = Page.Title();
        Assert.AreEqual("Bing", title);

        // Act
        Page.SearchByText("wikipedia");

        // Assert
        title = Page.Title();
        Assert.AreEqual("wikipedia - Bing", title);

        // Arrange
        Page.ClearSearchText();

        // Act
        Page.SearchByText("archive");

        // Arrange
        title = Page.Title();
        Assert.AreEqual("archive - Bing", title);
    }

    [TestMethod]
    public void TestMethod57()
    {
        // Act
        Page.OpenBingCom();

        // Assert
        var title = Page.Title();
        Assert.AreEqual("Bing", title);

        // Act
        Page.SearchByText("wikipedia");

        // Assert
        title = Page.Title();
        Assert.AreEqual("wikipedia - Bing", title);

        // Arrange
        Page.ClearSearchText();

        // Act
        Page.SearchByText("archive");

        // Arrange
        title = Page.Title();
        Assert.AreEqual("archive - Bing", title);
    }

    [TestMethod]
    public void TestMethod58()
    {
        // Act
        Page.OpenBingCom();

        // Assert
        var title = Page.Title();
        Assert.AreEqual("Bing", title);

        // Act
        Page.SearchByText("wikipedia");

        // Assert
        title = Page.Title();
        Assert.AreEqual("wikipedia - Bing", title);

        // Arrange
        Page.ClearSearchText();

        // Act
        Page.SearchByText("archive");

        // Arrange
        title = Page.Title();
        Assert.AreEqual("archive - Bing", title);
    }

    [TestMethod]
    public void TestMethod59()
    {
        // Act
        Page.OpenBingCom();

        // Assert
        var title = Page.Title();
        Assert.AreEqual("Bing", title);

        // Act
        Page.SearchByText("wikipedia");

        // Assert
        title = Page.Title();
        Assert.AreEqual("wikipedia - Bing", title);

        // Arrange
        Page.ClearSearchText();

        // Act
        Page.SearchByText("archive");

        // Arrange
        title = Page.Title();
        Assert.AreEqual("archive - Bing", title);
    }

    [TestMethod]
    public void TestMethod60()
    {
        // Act
        Page.OpenBingCom();

        // Assert
        var title = Page.Title();
        Assert.AreEqual("Bing", title);

        // Act
        Page.SearchByText("wikipedia");

        // Assert
        title = Page.Title();
        Assert.AreEqual("wikipedia - Bing", title);

        // Arrange
        Page.ClearSearchText();

        // Act
        Page.SearchByText("archive");

        // Arrange
        title = Page.Title();
        Assert.AreEqual("archive - Bing", title);
    }

    [TestMethod]
    public void TestMethod61()
    {
        // Act
        Page.OpenBingCom();

        // Assert
        var title = Page.Title();
        Assert.AreEqual("Bing", title);

        // Act
        Page.SearchByText("wikipedia");

        // Assert
        title = Page.Title();
        Assert.AreEqual("wikipedia - Bing", title);

        // Arrange
        Page.ClearSearchText();

        // Act
        Page.SearchByText("archive");

        // Arrange
        title = Page.Title();
        Assert.AreEqual("archive - Bing", title);
    }

    [TestMethod]
    public void TestMethod62()
    {
        // Act
        Page.OpenBingCom();

        // Assert
        var title = Page.Title();
        Assert.AreEqual("Bing", title);

        // Act
        Page.SearchByText("wikipedia");

        // Assert
        title = Page.Title();
        Assert.AreEqual("wikipedia - Bing", title);

        // Arrange
        Page.ClearSearchText();

        // Act
        Page.SearchByText("archive");

        // Arrange
        title = Page.Title();
        Assert.AreEqual("archive - Bing", title);
    }

    [TestMethod]
    public void TestMethod63()
    {
        // Act
        Page.OpenBingCom();

        // Assert
        var title = Page.Title();
        Assert.AreEqual("Bing", title);

        // Act
        Page.SearchByText("wikipedia");

        // Assert
        title = Page.Title();
        Assert.AreEqual("wikipedia - Bing", title);

        // Arrange
        Page.ClearSearchText();

        // Act
        Page.SearchByText("archive");

        // Arrange
        title = Page.Title();
        Assert.AreEqual("archive - Bing", title);
    }

    [TestMethod]
    public void TestMethod64()
    {
        // Act
        Page.OpenBingCom();

        // Assert
        var title = Page.Title();
        Assert.AreEqual("Bing", title);

        // Act
        Page.SearchByText("wikipedia");

        // Assert
        title = Page.Title();
        Assert.AreEqual("wikipedia - Bing", title);

        // Arrange
        Page.ClearSearchText();

        // Act
        Page.SearchByText("archive");

        // Arrange
        title = Page.Title();
        Assert.AreEqual("archive - Bing", title);
    }

    [TestMethod]
    public void TestMethod65()
    {
        // Act
        Page.OpenBingCom();

        // Assert
        var title = Page.Title();
        Assert.AreEqual("Bing", title);

        // Act
        Page.SearchByText("wikipedia");

        // Assert
        title = Page.Title();
        Assert.AreEqual("wikipedia - Bing", title);

        // Arrange
        Page.ClearSearchText();

        // Act
        Page.SearchByText("archive");

        // Arrange
        title = Page.Title();
        Assert.AreEqual("archive - Bing", title);
    }

    [TestMethod]
    public void TestMethod66()
    {
        // Act
        Page.OpenBingCom();

        // Assert
        var title = Page.Title();
        Assert.AreEqual("Bing", title);

        // Act
        Page.SearchByText("wikipedia");

        // Assert
        title = Page.Title();
        Assert.AreEqual("wikipedia - Bing", title);

        // Arrange
        Page.ClearSearchText();

        // Act
        Page.SearchByText("archive");

        // Arrange
        title = Page.Title();
        Assert.AreEqual("archive - Bing", title);
    }

    [TestMethod]
    public void TestMethod67()
    {
        // Act
        Page.OpenBingCom();

        // Assert
        var title = Page.Title();
        Assert.AreEqual("Bing", title);

        // Act
        Page.SearchByText("wikipedia");

        // Assert
        title = Page.Title();
        Assert.AreEqual("wikipedia - Bing", title);

        // Arrange
        Page.ClearSearchText();

        // Act
        Page.SearchByText("archive");

        // Arrange
        title = Page.Title();
        Assert.AreEqual("archive - Bing", title);
    }

    [TestMethod]
    public void TestMethod68()
    {
        // Act
        Page.OpenBingCom();

        // Assert
        var title = Page.Title();
        Assert.AreEqual("Bing", title);

        // Act
        Page.SearchByText("wikipedia");

        // Assert
        title = Page.Title();
        Assert.AreEqual("wikipedia - Bing", title);

        // Arrange
        Page.ClearSearchText();

        // Act
        Page.SearchByText("archive");

        // Arrange
        title = Page.Title();
        Assert.AreEqual("archive - Bing", title);
    }

    [TestMethod]
    public void TestMethod69()
    {
        // Act
        Page.OpenBingCom();

        // Assert
        var title = Page.Title();
        Assert.AreEqual("Bing", title);

        // Act
        Page.SearchByText("wikipedia");

        // Assert
        title = Page.Title();
        Assert.AreEqual("wikipedia - Bing", title);

        // Arrange
        Page.ClearSearchText();

        // Act
        Page.SearchByText("archive");

        // Arrange
        title = Page.Title();
        Assert.AreEqual("archive - Bing", title);
    }

    [TestMethod]
    public void TestMethod70()
    {
        // Act
        Page.OpenBingCom();

        // Assert
        var title = Page.Title();
        Assert.AreEqual("Bing", title);

        // Act
        Page.SearchByText("wikipedia");

        // Assert
        title = Page.Title();
        Assert.AreEqual("wikipedia - Bing", title);

        // Arrange
        Page.ClearSearchText();

        // Act
        Page.SearchByText("archive");

        // Arrange
        title = Page.Title();
        Assert.AreEqual("archive - Bing", title);
    }

    [TestMethod]
    public void TestMethod71()
    {
        // Act
        Page.OpenBingCom();

        // Assert
        var title = Page.Title();
        Assert.AreEqual("Bing", title);

        // Act
        Page.SearchByText("wikipedia");

        // Assert
        title = Page.Title();
        Assert.AreEqual("wikipedia - Bing", title);

        // Arrange
        Page.ClearSearchText();

        // Act
        Page.SearchByText("archive");

        // Arrange
        title = Page.Title();
        Assert.AreEqual("archive - Bing", title);
    }

    [TestMethod]
    public void TestMethod72()
    {
        // Act
        Page.OpenBingCom();

        // Assert
        var title = Page.Title();
        Assert.AreEqual("Bing", title);

        // Act
        Page.SearchByText("wikipedia");

        // Assert
        title = Page.Title();
        Assert.AreEqual("wikipedia - Bing", title);

        // Arrange
        Page.ClearSearchText();

        // Act
        Page.SearchByText("archive");

        // Arrange
        title = Page.Title();
        Assert.AreEqual("archive - Bing", title);
    }

    [TestMethod]
    public void TestMethod73()
    {
        // Act
        Page.OpenBingCom();

        // Assert
        var title = Page.Title();
        Assert.AreEqual("Bing", title);

        // Act
        Page.SearchByText("wikipedia");

        // Assert
        title = Page.Title();
        Assert.AreEqual("wikipedia - Bing", title);

        // Arrange
        Page.ClearSearchText();

        // Act
        Page.SearchByText("archive");

        // Arrange
        title = Page.Title();
        Assert.AreEqual("archive - Bing", title);
    }

    [TestMethod]
    public void TestMethod74()
    {
        // Act
        Page.OpenBingCom();

        // Assert
        var title = Page.Title();
        Assert.AreEqual("Bing", title);

        // Act
        Page.SearchByText("wikipedia");

        // Assert
        title = Page.Title();
        Assert.AreEqual("wikipedia - Bing", title);

        // Arrange
        Page.ClearSearchText();

        // Act
        Page.SearchByText("archive");

        // Arrange
        title = Page.Title();
        Assert.AreEqual("archive - Bing", title);
    }

    [TestMethod]
    public void TestMethod75()
    {
        // Act
        Page.OpenBingCom();

        // Assert
        var title = Page.Title();
        Assert.AreEqual("Bing", title);

        // Act
        Page.SearchByText("wikipedia");

        // Assert
        title = Page.Title();
        Assert.AreEqual("wikipedia - Bing", title);

        // Arrange
        Page.ClearSearchText();

        // Act
        Page.SearchByText("archive");

        // Arrange
        title = Page.Title();
        Assert.AreEqual("archive - Bing", title);
    }

    [TestMethod]
    public void TestMethod76()
    {
        // Act
        Page.OpenBingCom();

        // Assert
        var title = Page.Title();
        Assert.AreEqual("Bing", title);

        // Act
        Page.SearchByText("wikipedia");

        // Assert
        title = Page.Title();
        Assert.AreEqual("wikipedia - Bing", title);

        // Arrange
        Page.ClearSearchText();

        // Act
        Page.SearchByText("archive");

        // Arrange
        title = Page.Title();
        Assert.AreEqual("archive - Bing", title);
    }

    [TestMethod]
    public void TestMethod77()
    {
        // Act
        Page.OpenBingCom();

        // Assert
        var title = Page.Title();
        Assert.AreEqual("Bing", title);

        // Act
        Page.SearchByText("wikipedia");

        // Assert
        title = Page.Title();
        Assert.AreEqual("wikipedia - Bing", title);

        // Arrange
        Page.ClearSearchText();

        // Act
        Page.SearchByText("archive");

        // Arrange
        title = Page.Title();
        Assert.AreEqual("archive - Bing", title);
    }

    [TestMethod]
    public void TestMethod78()
    {
        // Act
        Page.OpenBingCom();

        // Assert
        var title = Page.Title();
        Assert.AreEqual("Bing", title);

        // Act
        Page.SearchByText("wikipedia");

        // Assert
        title = Page.Title();
        Assert.AreEqual("wikipedia - Bing", title);

        // Arrange
        Page.ClearSearchText();

        // Act
        Page.SearchByText("archive");

        // Arrange
        title = Page.Title();
        Assert.AreEqual("archive - Bing", title);
    }

    [TestMethod]
    public void TestMethod79()
    {
        // Act
        Page.OpenBingCom();

        // Assert
        var title = Page.Title();
        Assert.AreEqual("Bing", title);

        // Act
        Page.SearchByText("wikipedia");

        // Assert
        title = Page.Title();
        Assert.AreEqual("wikipedia - Bing", title);

        // Arrange
        Page.ClearSearchText();

        // Act
        Page.SearchByText("archive");

        // Arrange
        title = Page.Title();
        Assert.AreEqual("archive - Bing", title);
    }

    [TestMethod]
    public void TestMethod80()
    {
        // Act
        Page.OpenBingCom();

        // Assert
        var title = Page.Title();
        Assert.AreEqual("Bing", title);

        // Act
        Page.SearchByText("wikipedia");

        // Assert
        title = Page.Title();
        Assert.AreEqual("wikipedia - Bing", title);

        // Arrange
        Page.ClearSearchText();

        // Act
        Page.SearchByText("archive");

        // Arrange
        title = Page.Title();
        Assert.AreEqual("archive - Bing", title);
    }

    [TestMethod]
    public void TestMethod81()
    {
        // Act
        Page.OpenBingCom();

        // Assert
        var title = Page.Title();
        Assert.AreEqual("Bing", title);

        // Act
        Page.SearchByText("wikipedia");

        // Assert
        title = Page.Title();
        Assert.AreEqual("wikipedia - Bing", title);

        // Arrange
        Page.ClearSearchText();

        // Act
        Page.SearchByText("archive");

        // Arrange
        title = Page.Title();
        Assert.AreEqual("archive - Bing", title);
    }

    [TestMethod]
    public void TestMethod82()
    {
        // Act
        Page.OpenBingCom();

        // Assert
        var title = Page.Title();
        Assert.AreEqual("Bing", title);

        // Act
        Page.SearchByText("wikipedia");

        // Assert
        title = Page.Title();
        Assert.AreEqual("wikipedia - Bing", title);

        // Arrange
        Page.ClearSearchText();

        // Act
        Page.SearchByText("archive");

        // Arrange
        title = Page.Title();
        Assert.AreEqual("archive - Bing", title);
    }

    [TestMethod]
    public void TestMethod83()
    {
        // Act
        Page.OpenBingCom();

        // Assert
        var title = Page.Title();
        Assert.AreEqual("Bing", title);

        // Act
        Page.SearchByText("wikipedia");

        // Assert
        title = Page.Title();
        Assert.AreEqual("wikipedia - Bing", title);

        // Arrange
        Page.ClearSearchText();

        // Act
        Page.SearchByText("archive");

        // Arrange
        title = Page.Title();
        Assert.AreEqual("archive - Bing", title);
    }

    [TestMethod]
    public void TestMethod84()
    {
        // Act
        Page.OpenBingCom();

        // Assert
        var title = Page.Title();
        Assert.AreEqual("Bing", title);

        // Act
        Page.SearchByText("wikipedia");

        // Assert
        title = Page.Title();
        Assert.AreEqual("wikipedia - Bing", title);

        // Arrange
        Page.ClearSearchText();

        // Act
        Page.SearchByText("archive");

        // Arrange
        title = Page.Title();
        Assert.AreEqual("archive - Bing", title);
    }

    [TestMethod]
    public void TestMethod85()
    {
        // Act
        Page.OpenBingCom();

        // Assert
        var title = Page.Title();
        Assert.AreEqual("Bing", title);

        // Act
        Page.SearchByText("wikipedia");

        // Assert
        title = Page.Title();
        Assert.AreEqual("wikipedia - Bing", title);

        // Arrange
        Page.ClearSearchText();

        // Act
        Page.SearchByText("archive");

        // Arrange
        title = Page.Title();
        Assert.AreEqual("archive - Bing", title);
    }

    [TestMethod]
    public void TestMethod86()
    {
        // Act
        Page.OpenBingCom();

        // Assert
        var title = Page.Title();
        Assert.AreEqual("Bing", title);

        // Act
        Page.SearchByText("wikipedia");

        // Assert
        title = Page.Title();
        Assert.AreEqual("wikipedia - Bing", title);

        // Arrange
        Page.ClearSearchText();

        // Act
        Page.SearchByText("archive");

        // Arrange
        title = Page.Title();
        Assert.AreEqual("archive - Bing", title);
    }

    [TestMethod]
    public void TestMethod87()
    {
        // Act
        Page.OpenBingCom();

        // Assert
        var title = Page.Title();
        Assert.AreEqual("Bing", title);

        // Act
        Page.SearchByText("wikipedia");

        // Assert
        title = Page.Title();
        Assert.AreEqual("wikipedia - Bing", title);

        // Arrange
        Page.ClearSearchText();

        // Act
        Page.SearchByText("archive");

        // Arrange
        title = Page.Title();
        Assert.AreEqual("archive - Bing", title);
    }

    [TestMethod]
    public void TestMethod88()
    {
        // Act
        Page.OpenBingCom();

        // Assert
        var title = Page.Title();
        Assert.AreEqual("Bing", title);

        // Act
        Page.SearchByText("wikipedia");

        // Assert
        title = Page.Title();
        Assert.AreEqual("wikipedia - Bing", title);

        // Arrange
        Page.ClearSearchText();

        // Act
        Page.SearchByText("archive");

        // Arrange
        title = Page.Title();
        Assert.AreEqual("archive - Bing", title);
    }

    [TestMethod]
    public void TestMethod89()
    {
        // Act
        Page.OpenBingCom();

        // Assert
        var title = Page.Title();
        Assert.AreEqual("Bing", title);

        // Act
        Page.SearchByText("wikipedia");

        // Assert
        title = Page.Title();
        Assert.AreEqual("wikipedia - Bing", title);

        // Arrange
        Page.ClearSearchText();

        // Act
        Page.SearchByText("archive");

        // Arrange
        title = Page.Title();
        Assert.AreEqual("archive - Bing", title);
    }

    [TestMethod]
    public void TestMethod90()
    {
        // Act
        Page.OpenBingCom();

        // Assert
        var title = Page.Title();
        Assert.AreEqual("Bing", title);

        // Act
        Page.SearchByText("wikipedia");

        // Assert
        title = Page.Title();
        Assert.AreEqual("wikipedia - Bing", title);

        // Arrange
        Page.ClearSearchText();

        // Act
        Page.SearchByText("archive");

        // Arrange
        title = Page.Title();
        Assert.AreEqual("archive - Bing", title);
    }

    [TestMethod]
    public void TestMethod91()
    {
        // Act
        Page.OpenBingCom();

        // Assert
        var title = Page.Title();
        Assert.AreEqual("Bing", title);

        // Act
        Page.SearchByText("wikipedia");

        // Assert
        title = Page.Title();
        Assert.AreEqual("wikipedia - Bing", title);

        // Arrange
        Page.ClearSearchText();

        // Act
        Page.SearchByText("archive");

        // Arrange
        title = Page.Title();
        Assert.AreEqual("archive - Bing", title);
    }

    [TestMethod]
    public void TestMethod92()
    {
        // Act
        Page.OpenBingCom();

        // Assert
        var title = Page.Title();
        Assert.AreEqual("Bing", title);

        // Act
        Page.SearchByText("wikipedia");

        // Assert
        title = Page.Title();
        Assert.AreEqual("wikipedia - Bing", title);

        // Arrange
        Page.ClearSearchText();

        // Act
        Page.SearchByText("archive");

        // Arrange
        title = Page.Title();
        Assert.AreEqual("archive - Bing", title);
    }

    [TestMethod]
    public void TestMethod93()
    {
        // Act
        Page.OpenBingCom();

        // Assert
        var title = Page.Title();
        Assert.AreEqual("Bing", title);

        // Act
        Page.SearchByText("wikipedia");

        // Assert
        title = Page.Title();
        Assert.AreEqual("wikipedia - Bing", title);

        // Arrange
        Page.ClearSearchText();

        // Act
        Page.SearchByText("archive");

        // Arrange
        title = Page.Title();
        Assert.AreEqual("archive - Bing", title);
    }

    [TestMethod]
    public void TestMethod94()
    {
        // Act
        Page.OpenBingCom();

        // Assert
        var title = Page.Title();
        Assert.AreEqual("Bing", title);

        // Act
        Page.SearchByText("wikipedia");

        // Assert
        title = Page.Title();
        Assert.AreEqual("wikipedia - Bing", title);

        // Arrange
        Page.ClearSearchText();

        // Act
        Page.SearchByText("archive");

        // Arrange
        title = Page.Title();
        Assert.AreEqual("archive - Bing", title);
    }

    [TestMethod]
    public void TestMethod95()
    {
        // Act
        Page.OpenBingCom();

        // Assert
        var title = Page.Title();
        Assert.AreEqual("Bing", title);

        // Act
        Page.SearchByText("wikipedia");

        // Assert
        title = Page.Title();
        Assert.AreEqual("wikipedia - Bing", title);

        // Arrange
        Page.ClearSearchText();

        // Act
        Page.SearchByText("archive");

        // Arrange
        title = Page.Title();
        Assert.AreEqual("archive - Bing", title);
    }

    [TestMethod]
    public void TestMethod96()
    {
        // Act
        Page.OpenBingCom();

        // Assert
        var title = Page.Title();
        Assert.AreEqual("Bing", title);

        // Act
        Page.SearchByText("wikipedia");

        // Assert
        title = Page.Title();
        Assert.AreEqual("wikipedia - Bing", title);

        // Arrange
        Page.ClearSearchText();

        // Act
        Page.SearchByText("archive");

        // Arrange
        title = Page.Title();
        Assert.AreEqual("archive - Bing", title);
    }

    [TestMethod]
    public void TestMethod97()
    {
        // Act
        Page.OpenBingCom();

        // Assert
        var title = Page.Title();
        Assert.AreEqual("Bing", title);

        // Act
        Page.SearchByText("wikipedia");

        // Assert
        title = Page.Title();
        Assert.AreEqual("wikipedia - Bing", title);

        // Arrange
        Page.ClearSearchText();

        // Act
        Page.SearchByText("archive");

        // Arrange
        title = Page.Title();
        Assert.AreEqual("archive - Bing", title);
    }

    [TestMethod]
    public void TestMethod98()
    {
        // Act
        Page.OpenBingCom();

        // Assert
        var title = Page.Title();
        Assert.AreEqual("Bing", title);

        // Act
        Page.SearchByText("wikipedia");

        // Assert
        title = Page.Title();
        Assert.AreEqual("wikipedia - Bing", title);

        // Arrange
        Page.ClearSearchText();

        // Act
        Page.SearchByText("archive");

        // Arrange
        title = Page.Title();
        Assert.AreEqual("archive - Bing", title);
    }

    [TestMethod]
    public void TestMethod99()
    {
        // Act
        Page.OpenBingCom();

        // Assert
        var title = Page.Title();
        Assert.AreEqual("Bing", title);

        // Act
        Page.SearchByText("wikipedia");

        // Assert
        title = Page.Title();
        Assert.AreEqual("wikipedia - Bing", title);

        // Arrange
        Page.ClearSearchText();

        // Act
        Page.SearchByText("archive");

        // Arrange
        title = Page.Title();
        Assert.AreEqual("archive - Bing", title);
    }

    [TestMethod]
    public void TestMethod100()
    {
        // Act
        Page.OpenBingCom();

        // Assert
        var title = Page.Title();
        Assert.AreEqual("Bing", title);

        // Act
        Page.SearchByText("wikipedia");

        // Assert
        title = Page.Title();
        Assert.AreEqual("wikipedia - Bing", title);

        // Arrange
        Page.ClearSearchText();

        // Act
        Page.SearchByText("archive");

        // Arrange
        title = Page.Title();
        Assert.AreEqual("archive - Bing", title);
    }
}