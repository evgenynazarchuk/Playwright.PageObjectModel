using FluentAssertions;
using Microsoft.Playwright;
using Microsoft.Playwright.MSTest;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;

namespace Playwright.PageObjectModel.Tests;

[TestClass]
public class FindBlockTest : PageTest
{
    private string Path => $"file://{Directory.GetCurrentDirectory()}/Tests/FindBlockTest.html";

    [TestMethod]
    public void FindBlockOnPageModelTest()
    {
        // Arrange
        var testing = new PageTesting(this.Page!);
        testing.Open(this.Path);

        // Act
        var text = testing.FindBlock1().Text;

        // Assert
        text.Should().Contain("Block1Text");
    }

    [TestMethod]
    public void FindBlockOnBlockModelTest()
    {
        // Arrange
        var testing = new PageTesting(this.Page!);
        testing.Open(this.Path);

        // Act
        var text = testing.FindBlock1().FindBlock2().Text;

        // Assert
        text.Should().Contain("Block2Text");
    }

    [TestMethod]
    public void NotFoundBlockOnPageModelTest()
    {
        // Arrange
        var testing = new PageTesting(this.Page!);
        testing.Open(this.Path);

        // Act
        Action act = () => testing.NotFoundBlock();

        // Assert
        act.Should().Throw<TimeoutException>();
    }

    [TestMethod]
    public void NotFoundBlockOnBlockModelTest()
    {
        // Arrange
        var testing = new PageTesting(this.Page!);
        testing.Open(this.Path);

        // Act
        Action act = () => testing.FindBlock1().NotFoundBlock();

        // Assert
        act.Should().Throw<ApplicationException>("Element not found");
    }

    [TestMethod]
    public void FindInnerBlock()
    {
        // Arrange
        var testing = new PageTesting(this.Page!);
        testing.Open(this.Path);

        // Act
        testing.FindBlock3().FindBlock5();

        // Assert
    }

    class PageTesting : PageModel
    {
        public void Open(string url) => Page.GotoAsync(url).Wait();

        public PageTesting(IPage page)
            : base(page) { }

        public Block1<PageTesting> FindBlock1()
        {
            return this.GetBlockModel<Block1<PageTesting>>(".block1");
        }

        public Block3<PageTesting> FindBlock3()
        {
            return this.GetBlockModel<Block3<PageTesting>>(".block3");
        }

        public Block1<PageTesting>? NotFoundBlock()
        {
            return this.GetBlockModel<Block1<PageTesting>>(".not_found_block");
        }
    }

    class Block1<TPageModel> : BlockModel<TPageModel>
        where TPageModel : PageModel
    {
        public void Open(string url) => Page.GotoAsync(url).Wait();

        public Block1(TPageModel page, string selector)
            : base(page, selector) { }

        public string Text => this.InnerText();

        public Block2<PageTesting> FindBlock2()
        {
            return this.GetBlockModel<Block2<PageTesting>>(".block2");
        }

        public Block2<PageTesting>? NotFoundBlock()
        {
            return this.GetBlockModel<Block2<PageTesting>>(".not_found_block");
        }
    }

    class Block2<TPageModel> : BlockModel<TPageModel>
        where TPageModel : PageModel
    {
        public void Open(string url) => Page.GotoAsync(url).Wait();

        public Block2(TPageModel page, string selector)
            : base(page, selector) { }

        public Block2(BlockModel<TPageModel> parentBlockModel, string selector)
            : base(parentBlockModel, selector) { }

        public string Text => this.InnerText();
    }

    class Block3<TPageModel> : BlockModel<TPageModel>
        where TPageModel : PageModel
    {
        public void Open(string url) => Page.GotoAsync(url).Wait();

        public Block3(TPageModel page, string selector)
            : base(page, selector) { }

        public Block3(BlockModel<TPageModel> parentBlockModel, string selector)
            : base(parentBlockModel, selector) { }

        public Block5<TPageModel> FindBlock5()
        {
            return this.GetBlockModel<Block5<TPageModel>>(".block5");
        }
    }

    class Block4<TPageModel> : BlockModel<TPageModel>
        where TPageModel : PageModel
    {
        public void Open(string url) => Page.GotoAsync(url).Wait();

        public Block4(TPageModel page, string selector)
            : base(page, selector) { }

        public Block4(BlockModel<TPageModel> parentBlockModel, string selector)
            : base(parentBlockModel, selector) { }

        public Block5<TPageModel> FindBlock5()
        {
            return this.GetBlockModel<Block5<TPageModel>>(".block5");
        }
    }

    class Block5<TPageModel> : BlockModel<TPageModel>
        where TPageModel : PageModel
    {
        public void Open(string url) => Page.GotoAsync(url).Wait();

        public Block5(TPageModel page, string selector)
            : base(page, selector) { }

        public Block5(BlockModel<TPageModel> parentBlockModel, string selector)
            : base(parentBlockModel, selector) { }
    }
}