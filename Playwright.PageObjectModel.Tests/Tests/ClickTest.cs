using Microsoft.Playwright;
using Microsoft.Playwright.MSTest;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;

namespace Playwright.PageObjectModel.Tests;

[TestClass]
public class ClickTest : PageTest
{
    private string Path => $"file://{Directory.GetCurrentDirectory()}/Tests/ClickTest1.html";

    [TestMethod]
    public void ClickOnPageModelTest()
    {
        // Arrange
        var test = new PageTesting1(this.Page!);
        test.Open(this.Path);

        // Act
        test.ClickToPage2().ClickToPage1();

        // Assert
    }

    [TestMethod]
    public void ClickOnBlockModelTest()
    {
        // Arrange
        var test = new PageTesting1(this.Page!);
        test.Open(this.Path);

        // Act
        test.BlockLink.ToPage2().BlockLink.ToPage1();

        // Assert
    }

    class PageTesting1 : PageModel
    {
        public void Open(string url) => Page.GotoAsync(url).Wait();

        public PageTesting1(IPage page) : base(page) { }

        public PageTesting2 ClickToPage2() => this.Click<PageTesting2>(".link");

        public Page1Block<PageTesting1> BlockLink => new Page1Block<PageTesting1>(this, ".page1_block");
    }

    class PageTesting2 : PageModel
    {
        public void Open(string url) => Page.GotoAsync(url).Wait();

        public PageTesting2(IPage page) : base(page) { }

        public PageTesting1 ClickToPage1() => this.Click<PageTesting1>(".link");

        public Page2Block<PageTesting2> BlockLink => new Page2Block<PageTesting2>(this, ".page2_block");
    }

    class Page1Block<TPageModel> : ElementModel<TPageModel>
        where TPageModel : PageModel
    {
        public void Open(string url) => Page.GotoAsync(url).Wait();

        public Page1Block(TPageModel pageModel, string selector)
            : base(pageModel, selector) { }

        public Page1Block(ElementModel<TPageModel> parenTElementModel, string selector)
            : base(parenTElementModel, selector) { }

        public PageTesting2 ToPage2() => this.Click<PageTesting2>(".block-link");
    }

    class Page2Block<TPageModel> : ElementModel<TPageModel>
        where TPageModel : PageModel
    {
        public void Open(string url) => Page.GotoAsync(url).Wait();

        public Page2Block(TPageModel pageModel, string selector)
            : base(pageModel, selector) { }

        public Page2Block(ElementModel<TPageModel> parenTElementModel, string selector)
            : base(parenTElementModel, selector) { }

        public PageTesting1 ToPage1() => this.Click<PageTesting1>(".block-link");
    }
}
