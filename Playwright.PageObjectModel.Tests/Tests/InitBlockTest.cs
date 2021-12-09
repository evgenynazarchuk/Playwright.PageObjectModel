using FluentAssertions;
using Microsoft.Playwright;
using Microsoft.Playwright.MSTest;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;

namespace Playwright.PageObjectModel.Tests;

[TestClass]
public class InitBlockTest : PageTest
{
    private string Path => $"file://{Directory.GetCurrentDirectory()}/Tests/InitBlockTest.html";

    [TestMethod]
    public void InitBlockChainTest()
    {
        // Arrange
        var testPage = new PageTesting(this.Page!);
        testPage.Open(this.Path);

        // Act
        testPage.Block1.Block2.Block3.UpToPage();
    }

    [TestMethod]
    public void NotInitBlockOnPageModelTest()
    {
        // Arrange
        var testPage = new PageTesting(this.Page!);
        testPage.Open(this.Path);

        // Act
        Action act = () => testPage.NotFoundBlock();

        // Assert
        act.Should().Throw<ApplicationException>().WithMessage("Element not found. Selector: .not_found_block");
    }

    [TestMethod]
    public void NotInitInnerBlockOnPageModelTest()
    {
        // Arrange
        var testPage = new PageTesting(this.Page!);
        testPage.Open(this.Path);

        // Act
        Action act = () => testPage.Block1.NotFoundBlock();

        // Assert
        act.Should().Throw<ApplicationException>().WithMessage("Element not found. Selector: .not_found_block");
    }

    class PageTesting : PageModel
    {
        public PageTesting(IPage page)
            : base(page) { }

        public Block1<PageTesting> Block1 => new Block1<PageTesting>(this, ".block1");

        public Block1<PageTesting> NotFoundBlock() => new Block1<PageTesting>(this, ".not_found_block");
    }

    class Block1<TPageModel> : BlockModel<TPageModel>
        where TPageModel : PageModel
    {
        public Block1(TPageModel page, string selector)
            : base(page, selector) { }

        public Block2<TPageModel> Block2 => new Block2<TPageModel>(this, ".block2");

        public Block2<TPageModel> NotFoundBlock() => new Block2<TPageModel>(this, ".not_found_block");
    }

    class Block2<TPageModel> : BlockModel<TPageModel>
        where TPageModel : PageModel
    {
        public Block2(BlockModel<TPageModel> parentBlockModel, string selector)
            : base(parentBlockModel, selector) { }

        public Block3<TPageModel> Block3 => new Block3<TPageModel>(this, ".block3");
    }

    class Block3<TPageModel> : BlockModel<TPageModel>
        where TPageModel : PageModel
    {
        public Block3(BlockModel<TPageModel> parentBlockModel, string selector)
            : base(parentBlockModel, selector) { }
    }
}