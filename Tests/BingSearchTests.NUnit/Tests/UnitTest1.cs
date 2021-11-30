using NUnit.Framework;
using BingSearchTests.NUnit.Support;
using Playwright.FluentAssertions;
using System;
using Playwright.PageObjectModel;
using Playwright.Synchronous;
using BingPageObjectModel.Pages;
using BingPageObjectModel.Blocks;
using Microsoft.Playwright;

namespace BingSearchTests;

public class Tests : BingTest
{
    [SetUp]
    public void SetUp()
    { 
    }

    [Test]
    public void BingTitleWhenMainPage()
    {
        OpenMainPage()
            .Should().HaveTitle("Bing");
    }

    [Test]
    [TestCase("playwright")]
    [TestCase("windows 11")]
    public void BingTitleWhenSearchPlaywright(string searchText)
    {
        OpenMainPage()
            .SearchBar.SearchByText(searchText)
            .Should().HaveTitle($"{searchText} - Bing");
    }

    [Test]
    public void SearchResultCountTest()
    {
        OpenMainPage()
            .SearchBar.SearchByText("playwright")
            .SearchResult.Should().HaveInnerText("4 310 000 Results", "span.sb_count");
    }
}