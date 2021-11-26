using FluentAssertions;
using Microsoft.Playwright;
using Microsoft.Playwright.MSTest;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Playwright.PageObjectModel;
using System.IO;

namespace Playwright.PageObjectModel.Tests;

[TestClass]
public class FindBlockOrNullTest : PageTest
{
    private string Path => $"file://{Directory.GetCurrentDirectory()}/Tests/FindBlockOrNullTest.html";

    [TestMethod]
    public void FindMayBeNullBlockOnPageModelTest()
    {
        // Arrange
        var test = new PageTesting(this.Page!);
        test.Open(this.Path);

        // Act
        var block1 = test.FindBlock1WhenNotNull();

        // Assert
        block1!.Text.Should().Contain("Test text");
    }

    [TestMethod]
    public void FindNullBlockOnPageModelTest()
    {
        // Arrange
        var test = new PageTesting(this.Page!);
        test.Open(this.Path);

        // Act
        var block = test.FindBlock1WhenNull();

        // Assert
        block.Should().BeNull();
    }

    [TestMethod]
    public void FindMayBeNullBlockOnBlockModelTest()
    {
        // Arrange
        var test = new PageTesting(this.Page!);
        test.Open(this.Path);

        // Act
        var block = test.FindBlock1WhenNotNull()!.FindBlock2WhenNotNull();

        // Assert
        block!.Text.Contains("Test text");
    }

    [TestMethod]
    public void FindNullBlockOnBlockModelTest()
    {
        // Arrange
        var test = new PageTesting(this.Page!);
        test.Open(this.Path);

        // Act
        var block = test.FindBlock1WhenNotNull()!.FindBlock2WhenNull();

        // Assert
        block.Should().BeNull();
    }

    class PageTesting : PageModel
    {
        public PageTesting(IPage page)
            : base(page) { }

        public Block1<PageTesting>? FindBlock1WhenNotNull()
        {
            return this.FindBlock<Block1<PageTesting>>(".block1");
        }

        public Block1<PageTesting>? FindBlock1WhenNull()
        {
            return this.FindBlockOrNull<Block1<PageTesting>>(".not_found_block");
        }
    }

    class Block1<TPageModel> : BlockModel<TPageModel>
        where TPageModel : PageModel
    {
        public Block1(TPageModel page, string selector)
            : base(page, selector) { }

        public Block2<PageTesting>? FindBlock2WhenNotNull()
        {
            return this.FindBlockOrNull<Block2<PageTesting>>(".block2");
        }

        public Block2<PageTesting>? FindBlock2WhenNull()
        {
            return this.FindBlockOrNull<Block2<PageTesting>>(".not_found_block");
        }

        public string Text => this.InnerText();
    }

    class Block2<TPageModel> : BlockModel<TPageModel>
        where TPageModel : PageModel
    {
        public Block2(BlockModel<TPageModel> parentBlockModel, string selector)
            : base(parentBlockModel, selector) { }

        public Block3<PageTesting>? FindBlock3WhenNotNull()
        {
            return this.FindBlockOrNull<Block3<PageTesting>>(".block3");
        }

        public Block2<PageTesting>? FindBlock3WhenNull()
        {
            return this.FindBlockOrNull<Block2<PageTesting>>(".not_found_block");
        }

        public string Text => this.InnerText();
    }

    class Block3<TPageModel> : BlockModel<TPageModel>
        where TPageModel : PageModel
    {
        public Block3(BlockModel<TPageModel> parentBlockModel, string selector)
            : base(parentBlockModel, selector) { }

        public string Text => this.InnerText();
    }
}