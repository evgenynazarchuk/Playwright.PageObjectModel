using BingSearchTests.NUnit.Support;
using NUnit.Framework;
using Playwright.FluentAssertions;

namespace BingSearchTests;

public class Tests : BingTest
{
    // assert for page model
    [Test]
    public void Test1()
    {
        OpenMainPage().Should().HaveTitle("Bing");
    }

    // assert for block model
    // parameterized test
    [Test]
    [TestCase("playwright")]
    [TestCase("windows 11")]
    public void Test2(string searchText)
    {
        OpenMainPage()
            .SearchBar
            .SearchByText($"{searchText}")
            .Should().HaveTitle($"{searchText} - Bing")
            .SearchBar
            .SearchByText($"{searchText}")
            .Should().HaveTitle($"{searchText} - Bing");
    }

    // assert primitive types
    [Test]
    public void Test3()
    {
        OpenMainPage()
            .SearchBar.SearchByText("playwright")
            .SearchResult.VerifyThat(block =>
            {
                block.ResultCount.Should().Be("4 310 000 results");
                // other tests for primitive types
            })
            .UpToPage()
            .SearchBar.VerifyThat(block => block.SearchText.Should().Be("playwright"));
    }
}