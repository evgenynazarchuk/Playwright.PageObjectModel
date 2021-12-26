using NUnit.Framework;
using Playwright.PageObjectModel.Samples.Support;
using Playwright.FluentAssertions;

namespace Playwright.PageObjectModel.Samples;

public class PageObjectModelTests : UITest
{
    [Test]
    public void StartPageTest()
    {
        Open()
            .Should().HaveTitle("Fast and reliable end-to-end testing for modern web apps | Playwright")
            .Should().HaveElementInnerText(".hero__title.heroTitle_2lCx", "Playwright enables reliable end-to-end testing for modern web apps.");
    }

    [Test]
    public void ToggleThemeTest()
    {
        Open()
            .Should().HaveComputedStyle("//nav", "colorScheme", "dark")
            .Should().HaveComputedStyle("//main", "colorScheme", "dark")
            .Menu.ToggleTheme()
            .Should().HaveComputedStyle("//nav", "colorScheme", "light")
            .Should().HaveComputedStyle("//main", "colorScheme", "light")
            .Menu.ToggleTheme()
            .Should().HaveComputedStyle("//nav", "colorScheme", "dark")
            .Should().HaveComputedStyle("//main", "colorScheme", "dark");
    }

    [Test]
    public void GoDocsPageTest()
    {
        Open()
            .Menu.Docs()
            .Should().HaveTitle("Getting started | Playwright");
    }

    [Test]
    public void GoApiPageTest()
    {
        Open()
            .Menu.API()
            .Should().HaveTitle("Playwright Library | Playwright");
    }
}
