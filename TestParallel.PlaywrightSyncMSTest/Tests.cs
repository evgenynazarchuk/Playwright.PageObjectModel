using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.Playwright.MSTest;
using System.Threading.Tasks;
using Playwright.Synchronous;

namespace TestParallel.PlaywrightSyncMSTest;

[TestClass]
public class Tests : PageTest
{
    [TestMethod]
    public async Task TestMethod1()
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
    public async Task TestMethod2()
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
    public async Task TestMethod3()
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
    public async Task TestMethod4()
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
    public async Task TestMethod5()
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
    public async Task TestMethod6()
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
    public async Task TestMethod7()
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
    public async Task TestMethod8()
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
    public async Task TestMethod9()
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
    public async Task TestMethod10()
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
    public async Task TestMethod11()
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
    public async Task TestMethod12()
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
    public async Task TestMethod13()
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
    public async Task TestMethod14()
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
    public async Task TestMethod15()
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
    public async Task TestMethod16()
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
    public async Task TestMethod17()
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
    public async Task TestMethod18()
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
    public async Task TestMethod19()
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
    public async Task TestMethod20()
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
    public async Task TestMethod21()
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
    public async Task TestMethod22()
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
    public async Task TestMethod23()
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
    public async Task TestMethod24()
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
    public async Task TestMethod25()
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
    public async Task TestMethod26()
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
    public async Task TestMethod27()
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
    public async Task TestMethod28()
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
    public async Task TestMethod29()
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
    public async Task TestMethod30()
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
    public async Task TestMethod31()
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
    public async Task TestMethod32()
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
    public async Task TestMethod33()
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
    public async Task TestMethod34()
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
    public async Task TestMethod35()
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
    public async Task TestMethod36()
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
    public async Task TestMethod37()
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
    public async Task TestMethod38()
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
    public async Task TestMethod39()
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
    public async Task TestMethod40()
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
    public async Task TestMethod41()
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
    public async Task TestMethod42()
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
    public async Task TestMethod43()
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
    public async Task TestMethod44()
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
    public async Task TestMethod45()
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
    public async Task TestMethod46()
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
    public async Task TestMethod47()
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
    public async Task TestMethod48()
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
    public async Task TestMethod49()
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
    public async Task TestMethod50()
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
    public async Task TestMethod51()
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
    public async Task TestMethod52()
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
    public async Task TestMethod53()
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
    public async Task TestMethod54()
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
    public async Task TestMethod55()
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
    public async Task TestMethod56()
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
    public async Task TestMethod57()
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
    public async Task TestMethod58()
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
    public async Task TestMethod59()
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
    public async Task TestMethod60()
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
    public async Task TestMethod61()
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
    public async Task TestMethod62()
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
    public async Task TestMethod63()
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
    public async Task TestMethod64()
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
    public async Task TestMethod65()
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
    public async Task TestMethod66()
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
    public async Task TestMethod67()
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
    public async Task TestMethod68()
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
    public async Task TestMethod69()
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
    public async Task TestMethod70()
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
    public async Task TestMethod71()
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
    public async Task TestMethod72()
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
    public async Task TestMethod73()
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
    public async Task TestMethod74()
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
    public async Task TestMethod75()
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
    public async Task TestMethod76()
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
    public async Task TestMethod77()
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
    public async Task TestMethod78()
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
    public async Task TestMethod79()
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
    public async Task TestMethod80()
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
    public async Task TestMethod81()
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
    public async Task TestMethod82()
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
    public async Task TestMethod83()
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
    public async Task TestMethod84()
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
    public async Task TestMethod85()
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
    public async Task TestMethod86()
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
    public async Task TestMethod87()
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
    public async Task TestMethod88()
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
    public async Task TestMethod89()
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
    public async Task TestMethod90()
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
    public async Task TestMethod91()
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
    public async Task TestMethod92()
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
    public async Task TestMethod93()
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
    public async Task TestMethod94()
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
    public async Task TestMethod95()
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
    public async Task TestMethod96()
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
    public async Task TestMethod97()
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
    public async Task TestMethod98()
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
    public async Task TestMethod99()
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
    public async Task TestMethod100()
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
}