using FluentAssertions;
using Microsoft.Playwright;
using Microsoft.Playwright.MSTest;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.IO;

namespace Playwright.PageObjectModel.Tests;

[TestClass]
public class FindBlocksTest : PageTest
{
    private string Path => $"file://{Directory.GetCurrentDirectory()}/Tests/FindBlocksTest.html";

    [TestMethod]
    public void FindBlocksOnPageModelTest()
    {
        // Arrange
        var test = new PageTesting(this.Page!);
        test.Open(this.Path);

        // Act
        var blocks = test.FindBlocks();

        // Assert
        blocks.Should().HaveCount(3);
    }

    [TestMethod]
    public void FindBlocksOnBlockModelTest()
    {
        // Arrange
        var test = new PageTesting(this.Page!);
        test.Open(this.Path);

        // Act
        var blocks = test.FindBlockCollection().FindBlocks();

        // Assert
        blocks.Should().HaveCount(3);
    }

    class PageTesting : PageModel
    {
        public PageTesting(IPage page) : base(page) { }

        public IReadOnlyCollection<Block<PageTesting>> FindBlocks() => this.GetBlocks<Block<PageTesting>>("body>.block");

        public BlocksCollection<PageTesting> FindBlockCollection() => this.GetBlock<BlocksCollection<PageTesting>>(".blocksCollection");
    }

    class Block<TPageModel> : BlockModel<TPageModel>
        where TPageModel : PageModel
    {
        public Block(TPageModel pageModel, string selector)
            : base(pageModel, selector) { }

        public Block(BlockModel<TPageModel> parentBlock, string selector)
            : base(parentBlock, selector) { }
    }

    class BlocksCollection<TPageModel> : BlockModel<TPageModel>
        where TPageModel : PageModel
    {
        public BlocksCollection(TPageModel page, string selector)
            : base(page, selector) { }

        public BlocksCollection(BlockModel<TPageModel> parentBlock, string selector)
            : base(parentBlock, selector) { }

        public IReadOnlyCollection<Block<PageTesting>> FindBlocks() => this.FindBlocks<Block<PageTesting>>(".block");
    }
}