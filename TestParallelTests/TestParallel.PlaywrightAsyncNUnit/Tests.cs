using NUnit.Framework;
using Microsoft.Playwright.NUnit;
using System.Threading.Tasks;
using TestParallel.ActionExtensions;
using Microsoft.Playwright;

namespace TestParallel.PlaywrightAsyncNUnit;

[Parallelizable(ParallelScope.Self)]
public class Test1 : DesktopPage
{
    [Test]
    public async Task TestMethod1()
    {
        // Act
        await Page.GotoAsync("https://bing.com");
        await Page.WaitForLoadStateAsync(LoadState.NetworkIdle);
        // Assert
        var title = await Page.TitleAsync();
        Assert.AreEqual("Bing", title);

        // Act
        await Page.TypeAsync("input#sb_form_q", "wikipedia");
        await Page.PressAsync("input#sb_form_q", "Enter");
        await Page.WaitForLoadStateAsync(LoadState.NetworkIdle);

        // Assert
        title = await Page.TitleAsync();
        Assert.AreEqual("wikipedia - Bing", title);

        // Arrange
        var searchInputElement = await Page.QuerySelectorAsync("input#sb_form_q");
        var inputValue = await Page.EvaluateAsync<string>("(e) => e.value", searchInputElement);
        var inputLength = inputValue.Length;

        await Page.FocusAsync("input#sb_form_q");
        await Page.Keyboard.PressAsync("End");
        for (var i = 0; i < inputLength; i++)
        {
            await Page.Keyboard.PressAsync("Backspace");
        }

        // Act
        await Page.TypeAsync("input#sb_form_q", "archive");
        await Page.PressAsync("input#sb_form_q", "Enter");
        await Page.WaitForLoadStateAsync(LoadState.NetworkIdle);

        // Arrange
        title = await Page.TitleAsync();
        Assert.AreEqual("archive - Bing", title);
    }
}

[Parallelizable(ParallelScope.Self)]
public class Test2 : DesktopPage
{
    [Test]
    public async Task TestMethod()
    {
        // Act
        await Page.OpenBingComAsync();

        // Assert
        var title = await Page.TitleAsync();
        Assert.AreEqual("Bing", title);

        // Act
        await Page.SearchByTextAsync("wikipedia");

        // Assert
        title = await Page.TitleAsync();
        Assert.AreEqual("wikipedia - Bing", title);

        // Arrange
        await Page.ClearSearchTextAsync();

        // Act
        await Page.SearchByTextAsync("archive");

        // Arrange
        title = await Page.TitleAsync();
        Assert.AreEqual("archive - Bing", title);
    }
}

[Parallelizable(ParallelScope.Self)]
public class Test3 : DesktopPage
{
    [Test]
    public async Task TestMethod()
    {
        // Act
        await Page.OpenBingComAsync();

        // Assert
        var title = await Page.TitleAsync();
        Assert.AreEqual("Bing", title);

        // Act
        await Page.SearchByTextAsync("wikipedia");

        // Assert
        title = await Page.TitleAsync();
        Assert.AreEqual("wikipedia - Bing", title);

        // Arrange
        await Page.ClearSearchTextAsync();

        // Act
        await Page.SearchByTextAsync("archive");

        // Arrange
        title = await Page.TitleAsync();
        Assert.AreEqual("archive - Bing", title);
    }
}

[Parallelizable(ParallelScope.Self)]
public class Test4 : DesktopPage
{
    [Test]
    public async Task TestMethod()
    {
        // Act
        await Page.OpenBingComAsync();

        // Assert
        var title = await Page.TitleAsync();
        Assert.AreEqual("Bing", title);

        // Act
        await Page.SearchByTextAsync("wikipedia");

        // Assert
        title = await Page.TitleAsync();
        Assert.AreEqual("wikipedia - Bing", title);

        // Arrange
        await Page.ClearSearchTextAsync();

        // Act
        await Page.SearchByTextAsync("archive");

        // Arrange
        title = await Page.TitleAsync();
        Assert.AreEqual("archive - Bing", title);
    }
}

[Parallelizable(ParallelScope.Self)]
public class Test5 : DesktopPage
{
    [Test]
    public async Task TestMethod()
    {
        // Act
        await Page.OpenBingComAsync();

        // Assert
        var title = await Page.TitleAsync();
        Assert.AreEqual("Bing", title);

        // Act
        await Page.SearchByTextAsync("wikipedia");

        // Assert
        title = await Page.TitleAsync();
        Assert.AreEqual("wikipedia - Bing", title);

        // Arrange
        await Page.ClearSearchTextAsync();

        // Act
        await Page.SearchByTextAsync("archive");

        // Arrange
        title = await Page.TitleAsync();
        Assert.AreEqual("archive - Bing", title);
    }
}

[Parallelizable(ParallelScope.Self)]
public class Test6 : DesktopPage
{
    [Test]
    public async Task TestMethod()
    {
        // Act
        await Page.OpenBingComAsync();

        // Assert
        var title = await Page.TitleAsync();
        Assert.AreEqual("Bing", title);

        // Act
        await Page.SearchByTextAsync("wikipedia");

        // Assert
        title = await Page.TitleAsync();
        Assert.AreEqual("wikipedia - Bing", title);

        // Arrange
        await Page.ClearSearchTextAsync();

        // Act
        await Page.SearchByTextAsync("archive");

        // Arrange
        title = await Page.TitleAsync();
        Assert.AreEqual("archive - Bing", title);
    }
}

[Parallelizable(ParallelScope.Self)]
public class Test7 : DesktopPage
{
    [Test]
    public async Task TestMethod()
    {
        // Act
        await Page.OpenBingComAsync();

        // Assert
        var title = await Page.TitleAsync();
        Assert.AreEqual("Bing", title);

        // Act
        await Page.SearchByTextAsync("wikipedia");

        // Assert
        title = await Page.TitleAsync();
        Assert.AreEqual("wikipedia - Bing", title);

        // Arrange
        await Page.ClearSearchTextAsync();

        // Act
        await Page.SearchByTextAsync("archive");

        // Arrange
        title = await Page.TitleAsync();
        Assert.AreEqual("archive - Bing", title);
    }
}

[Parallelizable(ParallelScope.Self)]
public class Test8 : DesktopPage
{
    [Test]
    public async Task TestMethod()
    {
        // Act
        await Page.OpenBingComAsync();

        // Assert
        var title = await Page.TitleAsync();
        Assert.AreEqual("Bing", title);

        // Act
        await Page.SearchByTextAsync("wikipedia");

        // Assert
        title = await Page.TitleAsync();
        Assert.AreEqual("wikipedia - Bing", title);

        // Arrange
        await Page.ClearSearchTextAsync();

        // Act
        await Page.SearchByTextAsync("archive");

        // Arrange
        title = await Page.TitleAsync();
        Assert.AreEqual("archive - Bing", title);
    }
}

[Parallelizable(ParallelScope.Self)]
public class Test9 : DesktopPage
{
    [Test]
    public async Task TestMethod()
    {
        // Act
        await Page.OpenBingComAsync();

        // Assert
        var title = await Page.TitleAsync();
        Assert.AreEqual("Bing", title);

        // Act
        await Page.SearchByTextAsync("wikipedia");

        // Assert
        title = await Page.TitleAsync();
        Assert.AreEqual("wikipedia - Bing", title);

        // Arrange
        await Page.ClearSearchTextAsync();

        // Act
        await Page.SearchByTextAsync("archive");

        // Arrange
        title = await Page.TitleAsync();
        Assert.AreEqual("archive - Bing", title);
    }
}

[Parallelizable(ParallelScope.Self)]
public class Test10 : DesktopPage
{
    [Test]
    public async Task TestMethod()
    {
        // Act
        await Page.OpenBingComAsync();

        // Assert
        var title = await Page.TitleAsync();
        Assert.AreEqual("Bing", title);

        // Act
        await Page.SearchByTextAsync("wikipedia");

        // Assert
        title = await Page.TitleAsync();
        Assert.AreEqual("wikipedia - Bing", title);

        // Arrange
        await Page.ClearSearchTextAsync();

        // Act
        await Page.SearchByTextAsync("archive");

        // Arrange
        title = await Page.TitleAsync();
        Assert.AreEqual("archive - Bing", title);
    }
}

[Parallelizable(ParallelScope.Self)]
public class Test11 : DesktopPage
{
    [Test]
    public async Task TestMethod1()
    {
        // Act
        await Page.GotoAsync("https://bing.com");
        await Page.WaitForLoadStateAsync(LoadState.NetworkIdle);
        // Assert
        var title = await Page.TitleAsync();
        Assert.AreEqual("Bing", title);

        // Act
        await Page.TypeAsync("input#sb_form_q", "wikipedia");
        await Page.PressAsync("input#sb_form_q", "Enter");
        await Page.WaitForLoadStateAsync(LoadState.NetworkIdle);

        // Assert
        title = await Page.TitleAsync();
        Assert.AreEqual("wikipedia - Bing", title);

        // Arrange
        var searchInputElement = await Page.QuerySelectorAsync("input#sb_form_q");
        var inputValue = await Page.EvaluateAsync<string>("(e) => e.value", searchInputElement);
        var inputLength = inputValue.Length;

        await Page.FocusAsync("input#sb_form_q");
        await Page.Keyboard.PressAsync("End");
        for (var i = 0; i < inputLength; i++)
        {
            await Page.Keyboard.PressAsync("Backspace");
        }

        // Act
        await Page.TypeAsync("input#sb_form_q", "archive");
        await Page.PressAsync("input#sb_form_q", "Enter");
        await Page.WaitForLoadStateAsync(LoadState.NetworkIdle);

        // Arrange
        title = await Page.TitleAsync();
        Assert.AreEqual("archive - Bing", title);
    }
}

[Parallelizable(ParallelScope.Self)]
public class Test12 : DesktopPage
{
    [Test]
    public async Task TestMethod()
    {
        // Act
        await Page.OpenBingComAsync();

        // Assert
        var title = await Page.TitleAsync();
        Assert.AreEqual("Bing", title);

        // Act
        await Page.SearchByTextAsync("wikipedia");

        // Assert
        title = await Page.TitleAsync();
        Assert.AreEqual("wikipedia - Bing", title);

        // Arrange
        await Page.ClearSearchTextAsync();

        // Act
        await Page.SearchByTextAsync("archive");

        // Arrange
        title = await Page.TitleAsync();
        Assert.AreEqual("archive - Bing", title);
    }
}

[Parallelizable(ParallelScope.Self)]
public class Test13 : DesktopPage
{
    [Test]
    public async Task TestMethod()
    {
        // Act
        await Page.OpenBingComAsync();

        // Assert
        var title = await Page.TitleAsync();
        Assert.AreEqual("Bing", title);

        // Act
        await Page.SearchByTextAsync("wikipedia");

        // Assert
        title = await Page.TitleAsync();
        Assert.AreEqual("wikipedia - Bing", title);

        // Arrange
        await Page.ClearSearchTextAsync();

        // Act
        await Page.SearchByTextAsync("archive");

        // Arrange
        title = await Page.TitleAsync();
        Assert.AreEqual("archive - Bing", title);
    }
}

[Parallelizable(ParallelScope.Self)]
public class Test14 : DesktopPage
{
    [Test]
    public async Task TestMethod()
    {
        // Act
        await Page.OpenBingComAsync();

        // Assert
        var title = await Page.TitleAsync();
        Assert.AreEqual("Bing", title);

        // Act
        await Page.SearchByTextAsync("wikipedia");

        // Assert
        title = await Page.TitleAsync();
        Assert.AreEqual("wikipedia - Bing", title);

        // Arrange
        await Page.ClearSearchTextAsync();

        // Act
        await Page.SearchByTextAsync("archive");

        // Arrange
        title = await Page.TitleAsync();
        Assert.AreEqual("archive - Bing", title);
    }
}

[Parallelizable(ParallelScope.Self)]
public class Test15 : DesktopPage
{
    [Test]
    public async Task TestMethod()
    {
        // Act
        await Page.OpenBingComAsync();

        // Assert
        var title = await Page.TitleAsync();
        Assert.AreEqual("Bing", title);

        // Act
        await Page.SearchByTextAsync("wikipedia");

        // Assert
        title = await Page.TitleAsync();
        Assert.AreEqual("wikipedia - Bing", title);

        // Arrange
        await Page.ClearSearchTextAsync();

        // Act
        await Page.SearchByTextAsync("archive");

        // Arrange
        title = await Page.TitleAsync();
        Assert.AreEqual("archive - Bing", title);
    }
}

[Parallelizable(ParallelScope.Self)]
public class Test16 : DesktopPage
{
    [Test]
    public async Task TestMethod()
    {
        // Act
        await Page.OpenBingComAsync();

        // Assert
        var title = await Page.TitleAsync();
        Assert.AreEqual("Bing", title);

        // Act
        await Page.SearchByTextAsync("wikipedia");

        // Assert
        title = await Page.TitleAsync();
        Assert.AreEqual("wikipedia - Bing", title);

        // Arrange
        await Page.ClearSearchTextAsync();

        // Act
        await Page.SearchByTextAsync("archive");

        // Arrange
        title = await Page.TitleAsync();
        Assert.AreEqual("archive - Bing", title);
    }
}

[Parallelizable(ParallelScope.Self)]
public class Test17 : DesktopPage
{
    [Test]
    public async Task TestMethod()
    {
        // Act
        await Page.OpenBingComAsync();

        // Assert
        var title = await Page.TitleAsync();
        Assert.AreEqual("Bing", title);

        // Act
        await Page.SearchByTextAsync("wikipedia");

        // Assert
        title = await Page.TitleAsync();
        Assert.AreEqual("wikipedia - Bing", title);

        // Arrange
        await Page.ClearSearchTextAsync();

        // Act
        await Page.SearchByTextAsync("archive");

        // Arrange
        title = await Page.TitleAsync();
        Assert.AreEqual("archive - Bing", title);
    }
}

[Parallelizable(ParallelScope.Self)]
public class Test18 : DesktopPage
{
    [Test]
    public async Task TestMethod()
    {
        // Act
        await Page.OpenBingComAsync();

        // Assert
        var title = await Page.TitleAsync();
        Assert.AreEqual("Bing", title);

        // Act
        await Page.SearchByTextAsync("wikipedia");

        // Assert
        title = await Page.TitleAsync();
        Assert.AreEqual("wikipedia - Bing", title);

        // Arrange
        await Page.ClearSearchTextAsync();

        // Act
        await Page.SearchByTextAsync("archive");

        // Arrange
        title = await Page.TitleAsync();
        Assert.AreEqual("archive - Bing", title);
    }
}

[Parallelizable(ParallelScope.Self)]
public class Test19 : DesktopPage
{
    [Test]
    public async Task TestMethod()
    {
        // Act
        await Page.OpenBingComAsync();

        // Assert
        var title = await Page.TitleAsync();
        Assert.AreEqual("Bing", title);

        // Act
        await Page.SearchByTextAsync("wikipedia");

        // Assert
        title = await Page.TitleAsync();
        Assert.AreEqual("wikipedia - Bing", title);

        // Arrange
        await Page.ClearSearchTextAsync();

        // Act
        await Page.SearchByTextAsync("archive");

        // Arrange
        title = await Page.TitleAsync();
        Assert.AreEqual("archive - Bing", title);
    }
}

[Parallelizable(ParallelScope.Self)]
public class Test20 : DesktopPage
{
    [Test]
    public async Task TestMethod()
    {
        // Act
        await Page.OpenBingComAsync();

        // Assert
        var title = await Page.TitleAsync();
        Assert.AreEqual("Bing", title);

        // Act
        await Page.SearchByTextAsync("wikipedia");

        // Assert
        title = await Page.TitleAsync();
        Assert.AreEqual("wikipedia - Bing", title);

        // Arrange
        await Page.ClearSearchTextAsync();

        // Act
        await Page.SearchByTextAsync("archive");

        // Arrange
        title = await Page.TitleAsync();
        Assert.AreEqual("archive - Bing", title);
    }
}

[Parallelizable(ParallelScope.Self)]
public class Test21 : DesktopPage
{
    [Test]
    public async Task TestMethod1()
    {
        // Act
        await Page.GotoAsync("https://bing.com");
        await Page.WaitForLoadStateAsync(LoadState.NetworkIdle);
        // Assert
        var title = await Page.TitleAsync();
        Assert.AreEqual("Bing", title);

        // Act
        await Page.TypeAsync("input#sb_form_q", "wikipedia");
        await Page.PressAsync("input#sb_form_q", "Enter");
        await Page.WaitForLoadStateAsync(LoadState.NetworkIdle);

        // Assert
        title = await Page.TitleAsync();
        Assert.AreEqual("wikipedia - Bing", title);

        // Arrange
        var searchInputElement = await Page.QuerySelectorAsync("input#sb_form_q");
        var inputValue = await Page.EvaluateAsync<string>("(e) => e.value", searchInputElement);
        var inputLength = inputValue.Length;

        await Page.FocusAsync("input#sb_form_q");
        await Page.Keyboard.PressAsync("End");
        for (var i = 0; i < inputLength; i++)
        {
            await Page.Keyboard.PressAsync("Backspace");
        }

        // Act
        await Page.TypeAsync("input#sb_form_q", "archive");
        await Page.PressAsync("input#sb_form_q", "Enter");
        await Page.WaitForLoadStateAsync(LoadState.NetworkIdle);

        // Arrange
        title = await Page.TitleAsync();
        Assert.AreEqual("archive - Bing", title);
    }
}

[Parallelizable(ParallelScope.Self)]
public class Test22 : DesktopPage
{
    [Test]
    public async Task TestMethod()
    {
        // Act
        await Page.OpenBingComAsync();

        // Assert
        var title = await Page.TitleAsync();
        Assert.AreEqual("Bing", title);

        // Act
        await Page.SearchByTextAsync("wikipedia");

        // Assert
        title = await Page.TitleAsync();
        Assert.AreEqual("wikipedia - Bing", title);

        // Arrange
        await Page.ClearSearchTextAsync();

        // Act
        await Page.SearchByTextAsync("archive");

        // Arrange
        title = await Page.TitleAsync();
        Assert.AreEqual("archive - Bing", title);
    }
}

[Parallelizable(ParallelScope.Self)]
public class Test23 : DesktopPage
{
    [Test]
    public async Task TestMethod()
    {
        // Act
        await Page.OpenBingComAsync();

        // Assert
        var title = await Page.TitleAsync();
        Assert.AreEqual("Bing", title);

        // Act
        await Page.SearchByTextAsync("wikipedia");

        // Assert
        title = await Page.TitleAsync();
        Assert.AreEqual("wikipedia - Bing", title);

        // Arrange
        await Page.ClearSearchTextAsync();

        // Act
        await Page.SearchByTextAsync("archive");

        // Arrange
        title = await Page.TitleAsync();
        Assert.AreEqual("archive - Bing", title);
    }
}

[Parallelizable(ParallelScope.Self)]
public class Test24 : DesktopPage
{
    [Test]
    public async Task TestMethod()
    {
        // Act
        await Page.OpenBingComAsync();

        // Assert
        var title = await Page.TitleAsync();
        Assert.AreEqual("Bing", title);

        // Act
        await Page.SearchByTextAsync("wikipedia");

        // Assert
        title = await Page.TitleAsync();
        Assert.AreEqual("wikipedia - Bing", title);

        // Arrange
        await Page.ClearSearchTextAsync();

        // Act
        await Page.SearchByTextAsync("archive");

        // Arrange
        title = await Page.TitleAsync();
        Assert.AreEqual("archive - Bing", title);
    }
}

[Parallelizable(ParallelScope.Self)]
public class Test25 : DesktopPage
{
    [Test]
    public async Task TestMethod()
    {
        // Act
        await Page.OpenBingComAsync();

        // Assert
        var title = await Page.TitleAsync();
        Assert.AreEqual("Bing", title);

        // Act
        await Page.SearchByTextAsync("wikipedia");

        // Assert
        title = await Page.TitleAsync();
        Assert.AreEqual("wikipedia - Bing", title);

        // Arrange
        await Page.ClearSearchTextAsync();

        // Act
        await Page.SearchByTextAsync("archive");

        // Arrange
        title = await Page.TitleAsync();
        Assert.AreEqual("archive - Bing", title);
    }
}

[Parallelizable(ParallelScope.Self)]
public class Test26 : DesktopPage
{
    [Test]
    public async Task TestMethod()
    {
        // Act
        await Page.OpenBingComAsync();

        // Assert
        var title = await Page.TitleAsync();
        Assert.AreEqual("Bing", title);

        // Act
        await Page.SearchByTextAsync("wikipedia");

        // Assert
        title = await Page.TitleAsync();
        Assert.AreEqual("wikipedia - Bing", title);

        // Arrange
        await Page.ClearSearchTextAsync();

        // Act
        await Page.SearchByTextAsync("archive");

        // Arrange
        title = await Page.TitleAsync();
        Assert.AreEqual("archive - Bing", title);
    }
}

[Parallelizable(ParallelScope.Self)]
public class Test27 : DesktopPage
{
    [Test]
    public async Task TestMethod()
    {
        // Act
        await Page.OpenBingComAsync();

        // Assert
        var title = await Page.TitleAsync();
        Assert.AreEqual("Bing", title);

        // Act
        await Page.SearchByTextAsync("wikipedia");

        // Assert
        title = await Page.TitleAsync();
        Assert.AreEqual("wikipedia - Bing", title);

        // Arrange
        await Page.ClearSearchTextAsync();

        // Act
        await Page.SearchByTextAsync("archive");

        // Arrange
        title = await Page.TitleAsync();
        Assert.AreEqual("archive - Bing", title);
    }
}

[Parallelizable(ParallelScope.Self)]
public class Test28 : DesktopPage
{
    [Test]
    public async Task TestMethod()
    {
        // Act
        await Page.OpenBingComAsync();

        // Assert
        var title = await Page.TitleAsync();
        Assert.AreEqual("Bing", title);

        // Act
        await Page.SearchByTextAsync("wikipedia");

        // Assert
        title = await Page.TitleAsync();
        Assert.AreEqual("wikipedia - Bing", title);

        // Arrange
        await Page.ClearSearchTextAsync();

        // Act
        await Page.SearchByTextAsync("archive");

        // Arrange
        title = await Page.TitleAsync();
        Assert.AreEqual("archive - Bing", title);
    }
}

[Parallelizable(ParallelScope.Self)]
public class Test29 : DesktopPage
{
    [Test]
    public async Task TestMethod()
    {
        // Act
        await Page.OpenBingComAsync();

        // Assert
        var title = await Page.TitleAsync();
        Assert.AreEqual("Bing", title);

        // Act
        await Page.SearchByTextAsync("wikipedia");

        // Assert
        title = await Page.TitleAsync();
        Assert.AreEqual("wikipedia - Bing", title);

        // Arrange
        await Page.ClearSearchTextAsync();

        // Act
        await Page.SearchByTextAsync("archive");

        // Arrange
        title = await Page.TitleAsync();
        Assert.AreEqual("archive - Bing", title);
    }
}

[Parallelizable(ParallelScope.Self)]
public class Test30 : DesktopPage
{
    [Test]
    public async Task TestMethod()
    {
        // Act
        await Page.OpenBingComAsync();

        // Assert
        var title = await Page.TitleAsync();
        Assert.AreEqual("Bing", title);

        // Act
        await Page.SearchByTextAsync("wikipedia");

        // Assert
        title = await Page.TitleAsync();
        Assert.AreEqual("wikipedia - Bing", title);

        // Arrange
        await Page.ClearSearchTextAsync();

        // Act
        await Page.SearchByTextAsync("archive");

        // Arrange
        title = await Page.TitleAsync();
        Assert.AreEqual("archive - Bing", title);
    }
}

[Parallelizable(ParallelScope.Self)]
public class Test31 : DesktopPage
{
    [Test]
    public async Task TestMethod1()
    {
        // Act
        await Page.GotoAsync("https://bing.com");
        await Page.WaitForLoadStateAsync(LoadState.NetworkIdle);
        // Assert
        var title = await Page.TitleAsync();
        Assert.AreEqual("Bing", title);

        // Act
        await Page.TypeAsync("input#sb_form_q", "wikipedia");
        await Page.PressAsync("input#sb_form_q", "Enter");
        await Page.WaitForLoadStateAsync(LoadState.NetworkIdle);

        // Assert
        title = await Page.TitleAsync();
        Assert.AreEqual("wikipedia - Bing", title);

        // Arrange
        var searchInputElement = await Page.QuerySelectorAsync("input#sb_form_q");
        var inputValue = await Page.EvaluateAsync<string>("(e) => e.value", searchInputElement);
        var inputLength = inputValue.Length;

        await Page.FocusAsync("input#sb_form_q");
        await Page.Keyboard.PressAsync("End");
        for (var i = 0; i < inputLength; i++)
        {
            await Page.Keyboard.PressAsync("Backspace");
        }

        // Act
        await Page.TypeAsync("input#sb_form_q", "archive");
        await Page.PressAsync("input#sb_form_q", "Enter");
        await Page.WaitForLoadStateAsync(LoadState.NetworkIdle);

        // Arrange
        title = await Page.TitleAsync();
        Assert.AreEqual("archive - Bing", title);
    }
}

[Parallelizable(ParallelScope.Self)]
public class Test32 : DesktopPage
{
    [Test]
    public async Task TestMethod()
    {
        // Act
        await Page.OpenBingComAsync();

        // Assert
        var title = await Page.TitleAsync();
        Assert.AreEqual("Bing", title);

        // Act
        await Page.SearchByTextAsync("wikipedia");

        // Assert
        title = await Page.TitleAsync();
        Assert.AreEqual("wikipedia - Bing", title);

        // Arrange
        await Page.ClearSearchTextAsync();

        // Act
        await Page.SearchByTextAsync("archive");

        // Arrange
        title = await Page.TitleAsync();
        Assert.AreEqual("archive - Bing", title);
    }
}

[Parallelizable(ParallelScope.Self)]
public class Test33 : DesktopPage
{
    [Test]
    public async Task TestMethod()
    {
        // Act
        await Page.OpenBingComAsync();

        // Assert
        var title = await Page.TitleAsync();
        Assert.AreEqual("Bing", title);

        // Act
        await Page.SearchByTextAsync("wikipedia");

        // Assert
        title = await Page.TitleAsync();
        Assert.AreEqual("wikipedia - Bing", title);

        // Arrange
        await Page.ClearSearchTextAsync();

        // Act
        await Page.SearchByTextAsync("archive");

        // Arrange
        title = await Page.TitleAsync();
        Assert.AreEqual("archive - Bing", title);
    }
}

[Parallelizable(ParallelScope.Self)]
public class Test34 : DesktopPage
{
    [Test]
    public async Task TestMethod()
    {
        // Act
        await Page.OpenBingComAsync();

        // Assert
        var title = await Page.TitleAsync();
        Assert.AreEqual("Bing", title);

        // Act
        await Page.SearchByTextAsync("wikipedia");

        // Assert
        title = await Page.TitleAsync();
        Assert.AreEqual("wikipedia - Bing", title);

        // Arrange
        await Page.ClearSearchTextAsync();

        // Act
        await Page.SearchByTextAsync("archive");

        // Arrange
        title = await Page.TitleAsync();
        Assert.AreEqual("archive - Bing", title);
    }
}

[Parallelizable(ParallelScope.Self)]
public class Test35 : DesktopPage
{
    [Test]
    public async Task TestMethod()
    {
        // Act
        await Page.OpenBingComAsync();

        // Assert
        var title = await Page.TitleAsync();
        Assert.AreEqual("Bing", title);

        // Act
        await Page.SearchByTextAsync("wikipedia");

        // Assert
        title = await Page.TitleAsync();
        Assert.AreEqual("wikipedia - Bing", title);

        // Arrange
        await Page.ClearSearchTextAsync();

        // Act
        await Page.SearchByTextAsync("archive");

        // Arrange
        title = await Page.TitleAsync();
        Assert.AreEqual("archive - Bing", title);
    }
}

[Parallelizable(ParallelScope.Self)]
public class Test36 : DesktopPage
{
    [Test]
    public async Task TestMethod()
    {
        // Act
        await Page.OpenBingComAsync();

        // Assert
        var title = await Page.TitleAsync();
        Assert.AreEqual("Bing", title);

        // Act
        await Page.SearchByTextAsync("wikipedia");

        // Assert
        title = await Page.TitleAsync();
        Assert.AreEqual("wikipedia - Bing", title);

        // Arrange
        await Page.ClearSearchTextAsync();

        // Act
        await Page.SearchByTextAsync("archive");

        // Arrange
        title = await Page.TitleAsync();
        Assert.AreEqual("archive - Bing", title);
    }
}

[Parallelizable(ParallelScope.Self)]
public class Test37 : DesktopPage
{
    [Test]
    public async Task TestMethod()
    {
        // Act
        await Page.OpenBingComAsync();

        // Assert
        var title = await Page.TitleAsync();
        Assert.AreEqual("Bing", title);

        // Act
        await Page.SearchByTextAsync("wikipedia");

        // Assert
        title = await Page.TitleAsync();
        Assert.AreEqual("wikipedia - Bing", title);

        // Arrange
        await Page.ClearSearchTextAsync();

        // Act
        await Page.SearchByTextAsync("archive");

        // Arrange
        title = await Page.TitleAsync();
        Assert.AreEqual("archive - Bing", title);
    }
}

[Parallelizable(ParallelScope.Self)]
public class Test38 : DesktopPage
{
    [Test]
    public async Task TestMethod()
    {
        // Act
        await Page.OpenBingComAsync();

        // Assert
        var title = await Page.TitleAsync();
        Assert.AreEqual("Bing", title);

        // Act
        await Page.SearchByTextAsync("wikipedia");

        // Assert
        title = await Page.TitleAsync();
        Assert.AreEqual("wikipedia - Bing", title);

        // Arrange
        await Page.ClearSearchTextAsync();

        // Act
        await Page.SearchByTextAsync("archive");

        // Arrange
        title = await Page.TitleAsync();
        Assert.AreEqual("archive - Bing", title);
    }
}

[Parallelizable(ParallelScope.Self)]
public class Test39 : DesktopPage
{
    [Test]
    public async Task TestMethod()
    {
        // Act
        await Page.OpenBingComAsync();

        // Assert
        var title = await Page.TitleAsync();
        Assert.AreEqual("Bing", title);

        // Act
        await Page.SearchByTextAsync("wikipedia");

        // Assert
        title = await Page.TitleAsync();
        Assert.AreEqual("wikipedia - Bing", title);

        // Arrange
        await Page.ClearSearchTextAsync();

        // Act
        await Page.SearchByTextAsync("archive");

        // Arrange
        title = await Page.TitleAsync();
        Assert.AreEqual("archive - Bing", title);
    }
}

[Parallelizable(ParallelScope.Self)]
public class Test40 : DesktopPage
{
    [Test]
    public async Task TestMethod1()
    {
        // Act
        await Page.GotoAsync("https://bing.com");
        await Page.WaitForLoadStateAsync(LoadState.NetworkIdle);
        // Assert
        var title = await Page.TitleAsync();
        Assert.AreEqual("Bing", title);

        // Act
        await Page.TypeAsync("input#sb_form_q", "wikipedia");
        await Page.PressAsync("input#sb_form_q", "Enter");
        await Page.WaitForLoadStateAsync(LoadState.NetworkIdle);

        // Assert
        title = await Page.TitleAsync();
        Assert.AreEqual("wikipedia - Bing", title);

        // Arrange
        var searchInputElement = await Page.QuerySelectorAsync("input#sb_form_q");
        var inputValue = await Page.EvaluateAsync<string>("(e) => e.value", searchInputElement);
        var inputLength = inputValue.Length;

        await Page.FocusAsync("input#sb_form_q");
        await Page.Keyboard.PressAsync("End");
        for (var i = 0; i < inputLength; i++)
        {
            await Page.Keyboard.PressAsync("Backspace");
        }

        // Act
        await Page.TypeAsync("input#sb_form_q", "archive");
        await Page.PressAsync("input#sb_form_q", "Enter");
        await Page.WaitForLoadStateAsync(LoadState.NetworkIdle);

        // Arrange
        title = await Page.TitleAsync();
        Assert.AreEqual("archive - Bing", title);
    }
}

[Parallelizable(ParallelScope.Self)]
public class Test41 : DesktopPage
{
    [Test]
    public async Task TestMethod1()
    {
        // Act
        await Page.GotoAsync("https://bing.com");
        await Page.WaitForLoadStateAsync(LoadState.NetworkIdle);
        // Assert
        var title = await Page.TitleAsync();
        Assert.AreEqual("Bing", title);

        // Act
        await Page.TypeAsync("input#sb_form_q", "wikipedia");
        await Page.PressAsync("input#sb_form_q", "Enter");
        await Page.WaitForLoadStateAsync(LoadState.NetworkIdle);

        // Assert
        title = await Page.TitleAsync();
        Assert.AreEqual("wikipedia - Bing", title);

        // Arrange
        var searchInputElement = await Page.QuerySelectorAsync("input#sb_form_q");
        var inputValue = await Page.EvaluateAsync<string>("(e) => e.value", searchInputElement);
        var inputLength = inputValue.Length;

        await Page.FocusAsync("input#sb_form_q");
        await Page.Keyboard.PressAsync("End");
        for (var i = 0; i < inputLength; i++)
        {
            await Page.Keyboard.PressAsync("Backspace");
        }

        // Act
        await Page.TypeAsync("input#sb_form_q", "archive");
        await Page.PressAsync("input#sb_form_q", "Enter");
        await Page.WaitForLoadStateAsync(LoadState.NetworkIdle);

        // Arrange
        title = await Page.TitleAsync();
        Assert.AreEqual("archive - Bing", title);
    }
}

[Parallelizable(ParallelScope.Self)]
public class Test42 : DesktopPage
{
    [Test]
    public async Task TestMethod()
    {
        // Act
        await Page.OpenBingComAsync();

        // Assert
        var title = await Page.TitleAsync();
        Assert.AreEqual("Bing", title);

        // Act
        await Page.SearchByTextAsync("wikipedia");

        // Assert
        title = await Page.TitleAsync();
        Assert.AreEqual("wikipedia - Bing", title);

        // Arrange
        await Page.ClearSearchTextAsync();

        // Act
        await Page.SearchByTextAsync("archive");

        // Arrange
        title = await Page.TitleAsync();
        Assert.AreEqual("archive - Bing", title);
    }
}

[Parallelizable(ParallelScope.Self)]
public class Test43 : DesktopPage
{
    [Test]
    public async Task TestMethod()
    {
        // Act
        await Page.OpenBingComAsync();

        // Assert
        var title = await Page.TitleAsync();
        Assert.AreEqual("Bing", title);

        // Act
        await Page.SearchByTextAsync("wikipedia");

        // Assert
        title = await Page.TitleAsync();
        Assert.AreEqual("wikipedia - Bing", title);

        // Arrange
        await Page.ClearSearchTextAsync();

        // Act
        await Page.SearchByTextAsync("archive");

        // Arrange
        title = await Page.TitleAsync();
        Assert.AreEqual("archive - Bing", title);
    }
}

[Parallelizable(ParallelScope.Self)]
public class Test44 : DesktopPage
{
    [Test]
    public async Task TestMethod()
    {
        // Act
        await Page.OpenBingComAsync();

        // Assert
        var title = await Page.TitleAsync();
        Assert.AreEqual("Bing", title);

        // Act
        await Page.SearchByTextAsync("wikipedia");

        // Assert
        title = await Page.TitleAsync();
        Assert.AreEqual("wikipedia - Bing", title);

        // Arrange
        await Page.ClearSearchTextAsync();

        // Act
        await Page.SearchByTextAsync("archive");

        // Arrange
        title = await Page.TitleAsync();
        Assert.AreEqual("archive - Bing", title);
    }
}

[Parallelizable(ParallelScope.Self)]
public class Test45 : DesktopPage
{
    [Test]
    public async Task TestMethod()
    {
        // Act
        await Page.OpenBingComAsync();

        // Assert
        var title = await Page.TitleAsync();
        Assert.AreEqual("Bing", title);

        // Act
        await Page.SearchByTextAsync("wikipedia");

        // Assert
        title = await Page.TitleAsync();
        Assert.AreEqual("wikipedia - Bing", title);

        // Arrange
        await Page.ClearSearchTextAsync();

        // Act
        await Page.SearchByTextAsync("archive");

        // Arrange
        title = await Page.TitleAsync();
        Assert.AreEqual("archive - Bing", title);
    }
}

[Parallelizable(ParallelScope.Self)]
public class Test46 : DesktopPage
{
    [Test]
    public async Task TestMethod()
    {
        // Act
        await Page.OpenBingComAsync();

        // Assert
        var title = await Page.TitleAsync();
        Assert.AreEqual("Bing", title);

        // Act
        await Page.SearchByTextAsync("wikipedia");

        // Assert
        title = await Page.TitleAsync();
        Assert.AreEqual("wikipedia - Bing", title);

        // Arrange
        await Page.ClearSearchTextAsync();

        // Act
        await Page.SearchByTextAsync("archive");

        // Arrange
        title = await Page.TitleAsync();
        Assert.AreEqual("archive - Bing", title);
    }
}

[Parallelizable(ParallelScope.Self)]
public class Test47 : DesktopPage
{
    [Test]
    public async Task TestMethod()
    {
        // Act
        await Page.OpenBingComAsync();

        // Assert
        var title = await Page.TitleAsync();
        Assert.AreEqual("Bing", title);

        // Act
        await Page.SearchByTextAsync("wikipedia");

        // Assert
        title = await Page.TitleAsync();
        Assert.AreEqual("wikipedia - Bing", title);

        // Arrange
        await Page.ClearSearchTextAsync();

        // Act
        await Page.SearchByTextAsync("archive");

        // Arrange
        title = await Page.TitleAsync();
        Assert.AreEqual("archive - Bing", title);
    }
}

[Parallelizable(ParallelScope.Self)]
public class Test48 : DesktopPage
{
    [Test]
    public async Task TestMethod()
    {
        // Act
        await Page.OpenBingComAsync();

        // Assert
        var title = await Page.TitleAsync();
        Assert.AreEqual("Bing", title);

        // Act
        await Page.SearchByTextAsync("wikipedia");

        // Assert
        title = await Page.TitleAsync();
        Assert.AreEqual("wikipedia - Bing", title);

        // Arrange
        await Page.ClearSearchTextAsync();

        // Act
        await Page.SearchByTextAsync("archive");

        // Arrange
        title = await Page.TitleAsync();
        Assert.AreEqual("archive - Bing", title);
    }
}

[Parallelizable(ParallelScope.Self)]
public class Test49 : DesktopPage
{
    [Test]
    public async Task TestMethod()
    {
        // Act
        await Page.OpenBingComAsync();

        // Assert
        var title = await Page.TitleAsync();
        Assert.AreEqual("Bing", title);

        // Act
        await Page.SearchByTextAsync("wikipedia");

        // Assert
        title = await Page.TitleAsync();
        Assert.AreEqual("wikipedia - Bing", title);

        // Arrange
        await Page.ClearSearchTextAsync();

        // Act
        await Page.SearchByTextAsync("archive");

        // Arrange
        title = await Page.TitleAsync();
        Assert.AreEqual("archive - Bing", title);
    }
}

[Parallelizable(ParallelScope.Self)]
public class Test50 : DesktopPage
{
    [Test]
    public async Task TestMethod()
    {
        // Act
        await Page.OpenBingComAsync();

        // Assert
        var title = await Page.TitleAsync();
        Assert.AreEqual("Bing", title);

        // Act
        await Page.SearchByTextAsync("wikipedia");

        // Assert
        title = await Page.TitleAsync();
        Assert.AreEqual("wikipedia - Bing", title);

        // Arrange
        await Page.ClearSearchTextAsync();

        // Act
        await Page.SearchByTextAsync("archive");

        // Arrange
        title = await Page.TitleAsync();
        Assert.AreEqual("archive - Bing", title);
    }
}

[Parallelizable(ParallelScope.Self)]
public class Test51 : DesktopPage
{
    [Test]
    public async Task TestMethod1()
    {
        // Act
        await Page.GotoAsync("https://bing.com");
        await Page.WaitForLoadStateAsync(LoadState.NetworkIdle);
        // Assert
        var title = await Page.TitleAsync();
        Assert.AreEqual("Bing", title);

        // Act
        await Page.TypeAsync("input#sb_form_q", "wikipedia");
        await Page.PressAsync("input#sb_form_q", "Enter");
        await Page.WaitForLoadStateAsync(LoadState.NetworkIdle);

        // Assert
        title = await Page.TitleAsync();
        Assert.AreEqual("wikipedia - Bing", title);

        // Arrange
        var searchInputElement = await Page.QuerySelectorAsync("input#sb_form_q");
        var inputValue = await Page.EvaluateAsync<string>("(e) => e.value", searchInputElement);
        var inputLength = inputValue.Length;

        await Page.FocusAsync("input#sb_form_q");
        await Page.Keyboard.PressAsync("End");
        for (var i = 0; i < inputLength; i++)
        {
            await Page.Keyboard.PressAsync("Backspace");
        }

        // Act
        await Page.TypeAsync("input#sb_form_q", "archive");
        await Page.PressAsync("input#sb_form_q", "Enter");
        await Page.WaitForLoadStateAsync(LoadState.NetworkIdle);

        // Arrange
        title = await Page.TitleAsync();
        Assert.AreEqual("archive - Bing", title);
    }
}

[Parallelizable(ParallelScope.Self)]
public class Test52 : DesktopPage
{
    [Test]
    public async Task TestMethod()
    {
        // Act
        await Page.OpenBingComAsync();

        // Assert
        var title = await Page.TitleAsync();
        Assert.AreEqual("Bing", title);

        // Act
        await Page.SearchByTextAsync("wikipedia");

        // Assert
        title = await Page.TitleAsync();
        Assert.AreEqual("wikipedia - Bing", title);

        // Arrange
        await Page.ClearSearchTextAsync();

        // Act
        await Page.SearchByTextAsync("archive");

        // Arrange
        title = await Page.TitleAsync();
        Assert.AreEqual("archive - Bing", title);
    }
}

[Parallelizable(ParallelScope.Self)]
public class Test53 : DesktopPage
{
    [Test]
    public async Task TestMethod()
    {
        // Act
        await Page.OpenBingComAsync();

        // Assert
        var title = await Page.TitleAsync();
        Assert.AreEqual("Bing", title);

        // Act
        await Page.SearchByTextAsync("wikipedia");

        // Assert
        title = await Page.TitleAsync();
        Assert.AreEqual("wikipedia - Bing", title);

        // Arrange
        await Page.ClearSearchTextAsync();

        // Act
        await Page.SearchByTextAsync("archive");

        // Arrange
        title = await Page.TitleAsync();
        Assert.AreEqual("archive - Bing", title);
    }
}

[Parallelizable(ParallelScope.Self)]
public class Test54 : DesktopPage
{
    [Test]
    public async Task TestMethod()
    {
        // Act
        await Page.OpenBingComAsync();

        // Assert
        var title = await Page.TitleAsync();
        Assert.AreEqual("Bing", title);

        // Act
        await Page.SearchByTextAsync("wikipedia");

        // Assert
        title = await Page.TitleAsync();
        Assert.AreEqual("wikipedia - Bing", title);

        // Arrange
        await Page.ClearSearchTextAsync();

        // Act
        await Page.SearchByTextAsync("archive");

        // Arrange
        title = await Page.TitleAsync();
        Assert.AreEqual("archive - Bing", title);
    }
}

[Parallelizable(ParallelScope.Self)]
public class Test55 : DesktopPage
{
    [Test]
    public async Task TestMethod()
    {
        // Act
        await Page.OpenBingComAsync();

        // Assert
        var title = await Page.TitleAsync();
        Assert.AreEqual("Bing", title);

        // Act
        await Page.SearchByTextAsync("wikipedia");

        // Assert
        title = await Page.TitleAsync();
        Assert.AreEqual("wikipedia - Bing", title);

        // Arrange
        await Page.ClearSearchTextAsync();

        // Act
        await Page.SearchByTextAsync("archive");

        // Arrange
        title = await Page.TitleAsync();
        Assert.AreEqual("archive - Bing", title);
    }
}

[Parallelizable(ParallelScope.Self)]
public class Test56 : DesktopPage
{
    [Test]
    public async Task TestMethod()
    {
        // Act
        await Page.OpenBingComAsync();

        // Assert
        var title = await Page.TitleAsync();
        Assert.AreEqual("Bing", title);

        // Act
        await Page.SearchByTextAsync("wikipedia");

        // Assert
        title = await Page.TitleAsync();
        Assert.AreEqual("wikipedia - Bing", title);

        // Arrange
        await Page.ClearSearchTextAsync();

        // Act
        await Page.SearchByTextAsync("archive");

        // Arrange
        title = await Page.TitleAsync();
        Assert.AreEqual("archive - Bing", title);
    }
}

[Parallelizable(ParallelScope.Self)]
public class Test57 : DesktopPage
{
    [Test]
    public async Task TestMethod()
    {
        // Act
        await Page.OpenBingComAsync();

        // Assert
        var title = await Page.TitleAsync();
        Assert.AreEqual("Bing", title);

        // Act
        await Page.SearchByTextAsync("wikipedia");

        // Assert
        title = await Page.TitleAsync();
        Assert.AreEqual("wikipedia - Bing", title);

        // Arrange
        await Page.ClearSearchTextAsync();

        // Act
        await Page.SearchByTextAsync("archive");

        // Arrange
        title = await Page.TitleAsync();
        Assert.AreEqual("archive - Bing", title);
    }
}

[Parallelizable(ParallelScope.Self)]
public class Test58 : DesktopPage
{
    [Test]
    public async Task TestMethod()
    {
        // Act
        await Page.OpenBingComAsync();

        // Assert
        var title = await Page.TitleAsync();
        Assert.AreEqual("Bing", title);

        // Act
        await Page.SearchByTextAsync("wikipedia");

        // Assert
        title = await Page.TitleAsync();
        Assert.AreEqual("wikipedia - Bing", title);

        // Arrange
        await Page.ClearSearchTextAsync();

        // Act
        await Page.SearchByTextAsync("archive");

        // Arrange
        title = await Page.TitleAsync();
        Assert.AreEqual("archive - Bing", title);
    }
}

[Parallelizable(ParallelScope.Self)]
public class Test59 : DesktopPage
{
    [Test]
    public async Task TestMethod()
    {
        // Act
        await Page.OpenBingComAsync();

        // Assert
        var title = await Page.TitleAsync();
        Assert.AreEqual("Bing", title);

        // Act
        await Page.SearchByTextAsync("wikipedia");

        // Assert
        title = await Page.TitleAsync();
        Assert.AreEqual("wikipedia - Bing", title);

        // Arrange
        await Page.ClearSearchTextAsync();

        // Act
        await Page.SearchByTextAsync("archive");

        // Arrange
        title = await Page.TitleAsync();
        Assert.AreEqual("archive - Bing", title);
    }
}

[Parallelizable(ParallelScope.Self)]
public class Test60 : DesktopPage
{
    [Test]
    public async Task TestMethod()
    {
        // Act
        await Page.OpenBingComAsync();

        // Assert
        var title = await Page.TitleAsync();
        Assert.AreEqual("Bing", title);

        // Act
        await Page.SearchByTextAsync("wikipedia");

        // Assert
        title = await Page.TitleAsync();
        Assert.AreEqual("wikipedia - Bing", title);

        // Arrange
        await Page.ClearSearchTextAsync();

        // Act
        await Page.SearchByTextAsync("archive");

        // Arrange
        title = await Page.TitleAsync();
        Assert.AreEqual("archive - Bing", title);
    }
}

[Parallelizable(ParallelScope.Self)]
public class Test61 : DesktopPage
{
    [Test]
    public async Task TestMethod1()
    {
        // Act
        await Page.GotoAsync("https://bing.com");
        await Page.WaitForLoadStateAsync(LoadState.NetworkIdle);
        // Assert
        var title = await Page.TitleAsync();
        Assert.AreEqual("Bing", title);

        // Act
        await Page.TypeAsync("input#sb_form_q", "wikipedia");
        await Page.PressAsync("input#sb_form_q", "Enter");
        await Page.WaitForLoadStateAsync(LoadState.NetworkIdle);

        // Assert
        title = await Page.TitleAsync();
        Assert.AreEqual("wikipedia - Bing", title);

        // Arrange
        var searchInputElement = await Page.QuerySelectorAsync("input#sb_form_q");
        var inputValue = await Page.EvaluateAsync<string>("(e) => e.value", searchInputElement);
        var inputLength = inputValue.Length;

        await Page.FocusAsync("input#sb_form_q");
        await Page.Keyboard.PressAsync("End");
        for (var i = 0; i < inputLength; i++)
        {
            await Page.Keyboard.PressAsync("Backspace");
        }

        // Act
        await Page.TypeAsync("input#sb_form_q", "archive");
        await Page.PressAsync("input#sb_form_q", "Enter");
        await Page.WaitForLoadStateAsync(LoadState.NetworkIdle);

        // Arrange
        title = await Page.TitleAsync();
        Assert.AreEqual("archive - Bing", title);
    }
}

[Parallelizable(ParallelScope.Self)]
public class Test62 : DesktopPage
{
    [Test]
    public async Task TestMethod()
    {
        // Act
        await Page.OpenBingComAsync();

        // Assert
        var title = await Page.TitleAsync();
        Assert.AreEqual("Bing", title);

        // Act
        await Page.SearchByTextAsync("wikipedia");

        // Assert
        title = await Page.TitleAsync();
        Assert.AreEqual("wikipedia - Bing", title);

        // Arrange
        await Page.ClearSearchTextAsync();

        // Act
        await Page.SearchByTextAsync("archive");

        // Arrange
        title = await Page.TitleAsync();
        Assert.AreEqual("archive - Bing", title);
    }
}

[Parallelizable(ParallelScope.Self)]
public class Test63 : DesktopPage
{
    [Test]
    public async Task TestMethod()
    {
        // Act
        await Page.OpenBingComAsync();

        // Assert
        var title = await Page.TitleAsync();
        Assert.AreEqual("Bing", title);

        // Act
        await Page.SearchByTextAsync("wikipedia");

        // Assert
        title = await Page.TitleAsync();
        Assert.AreEqual("wikipedia - Bing", title);

        // Arrange
        await Page.ClearSearchTextAsync();

        // Act
        await Page.SearchByTextAsync("archive");

        // Arrange
        title = await Page.TitleAsync();
        Assert.AreEqual("archive - Bing", title);
    }
}

[Parallelizable(ParallelScope.Self)]
public class Test64 : DesktopPage
{
    [Test]
    public async Task TestMethod()
    {
        // Act
        await Page.OpenBingComAsync();

        // Assert
        var title = await Page.TitleAsync();
        Assert.AreEqual("Bing", title);

        // Act
        await Page.SearchByTextAsync("wikipedia");

        // Assert
        title = await Page.TitleAsync();
        Assert.AreEqual("wikipedia - Bing", title);

        // Arrange
        await Page.ClearSearchTextAsync();

        // Act
        await Page.SearchByTextAsync("archive");

        // Arrange
        title = await Page.TitleAsync();
        Assert.AreEqual("archive - Bing", title);
    }
}

[Parallelizable(ParallelScope.Self)]
public class Test65 : DesktopPage
{
    [Test]
    public async Task TestMethod()
    {
        // Act
        await Page.OpenBingComAsync();

        // Assert
        var title = await Page.TitleAsync();
        Assert.AreEqual("Bing", title);

        // Act
        await Page.SearchByTextAsync("wikipedia");

        // Assert
        title = await Page.TitleAsync();
        Assert.AreEqual("wikipedia - Bing", title);

        // Arrange
        await Page.ClearSearchTextAsync();

        // Act
        await Page.SearchByTextAsync("archive");

        // Arrange
        title = await Page.TitleAsync();
        Assert.AreEqual("archive - Bing", title);
    }
}

[Parallelizable(ParallelScope.Self)]
public class Test66 : DesktopPage
{
    [Test]
    public async Task TestMethod()
    {
        // Act
        await Page.OpenBingComAsync();

        // Assert
        var title = await Page.TitleAsync();
        Assert.AreEqual("Bing", title);

        // Act
        await Page.SearchByTextAsync("wikipedia");

        // Assert
        title = await Page.TitleAsync();
        Assert.AreEqual("wikipedia - Bing", title);

        // Arrange
        await Page.ClearSearchTextAsync();

        // Act
        await Page.SearchByTextAsync("archive");

        // Arrange
        title = await Page.TitleAsync();
        Assert.AreEqual("archive - Bing", title);
    }
}

[Parallelizable(ParallelScope.Self)]
public class Test67 : DesktopPage
{
    [Test]
    public async Task TestMethod()
    {
        // Act
        await Page.OpenBingComAsync();

        // Assert
        var title = await Page.TitleAsync();
        Assert.AreEqual("Bing", title);

        // Act
        await Page.SearchByTextAsync("wikipedia");

        // Assert
        title = await Page.TitleAsync();
        Assert.AreEqual("wikipedia - Bing", title);

        // Arrange
        await Page.ClearSearchTextAsync();

        // Act
        await Page.SearchByTextAsync("archive");

        // Arrange
        title = await Page.TitleAsync();
        Assert.AreEqual("archive - Bing", title);
    }
}

[Parallelizable(ParallelScope.Self)]
public class Test68 : DesktopPage
{
    [Test]
    public async Task TestMethod()
    {
        // Act
        await Page.OpenBingComAsync();

        // Assert
        var title = await Page.TitleAsync();
        Assert.AreEqual("Bing", title);

        // Act
        await Page.SearchByTextAsync("wikipedia");

        // Assert
        title = await Page.TitleAsync();
        Assert.AreEqual("wikipedia - Bing", title);

        // Arrange
        await Page.ClearSearchTextAsync();

        // Act
        await Page.SearchByTextAsync("archive");

        // Arrange
        title = await Page.TitleAsync();
        Assert.AreEqual("archive - Bing", title);
    }
}

[Parallelizable(ParallelScope.Self)]
public class Test69 : DesktopPage
{
    [Test]
    public async Task TestMethod()
    {
        // Act
        await Page.OpenBingComAsync();

        // Assert
        var title = await Page.TitleAsync();
        Assert.AreEqual("Bing", title);

        // Act
        await Page.SearchByTextAsync("wikipedia");

        // Assert
        title = await Page.TitleAsync();
        Assert.AreEqual("wikipedia - Bing", title);

        // Arrange
        await Page.ClearSearchTextAsync();

        // Act
        await Page.SearchByTextAsync("archive");

        // Arrange
        title = await Page.TitleAsync();
        Assert.AreEqual("archive - Bing", title);
    }
}

[Parallelizable(ParallelScope.Self)]
public class Test70 : DesktopPage
{
    [Test]
    public async Task TestMethod()
    {
        // Act
        await Page.OpenBingComAsync();

        // Assert
        var title = await Page.TitleAsync();
        Assert.AreEqual("Bing", title);

        // Act
        await Page.SearchByTextAsync("wikipedia");

        // Assert
        title = await Page.TitleAsync();
        Assert.AreEqual("wikipedia - Bing", title);

        // Arrange
        await Page.ClearSearchTextAsync();

        // Act
        await Page.SearchByTextAsync("archive");

        // Arrange
        title = await Page.TitleAsync();
        Assert.AreEqual("archive - Bing", title);
    }
}

[Parallelizable(ParallelScope.Self)]
public class Test71 : DesktopPage
{
    [Test]
    public async Task TestMethod1()
    {
        // Act
        await Page.GotoAsync("https://bing.com");
        await Page.WaitForLoadStateAsync(LoadState.NetworkIdle);
        // Assert
        var title = await Page.TitleAsync();
        Assert.AreEqual("Bing", title);

        // Act
        await Page.TypeAsync("input#sb_form_q", "wikipedia");
        await Page.PressAsync("input#sb_form_q", "Enter");
        await Page.WaitForLoadStateAsync(LoadState.NetworkIdle);

        // Assert
        title = await Page.TitleAsync();
        Assert.AreEqual("wikipedia - Bing", title);

        // Arrange
        var searchInputElement = await Page.QuerySelectorAsync("input#sb_form_q");
        var inputValue = await Page.EvaluateAsync<string>("(e) => e.value", searchInputElement);
        var inputLength = inputValue.Length;

        await Page.FocusAsync("input#sb_form_q");
        await Page.Keyboard.PressAsync("End");
        for (var i = 0; i < inputLength; i++)
        {
            await Page.Keyboard.PressAsync("Backspace");
        }

        // Act
        await Page.TypeAsync("input#sb_form_q", "archive");
        await Page.PressAsync("input#sb_form_q", "Enter");
        await Page.WaitForLoadStateAsync(LoadState.NetworkIdle);

        // Arrange
        title = await Page.TitleAsync();
        Assert.AreEqual("archive - Bing", title);
    }
}

[Parallelizable(ParallelScope.Self)]
public class Test72 : DesktopPage
{
    [Test]
    public async Task TestMethod()
    {
        // Act
        await Page.OpenBingComAsync();

        // Assert
        var title = await Page.TitleAsync();
        Assert.AreEqual("Bing", title);

        // Act
        await Page.SearchByTextAsync("wikipedia");

        // Assert
        title = await Page.TitleAsync();
        Assert.AreEqual("wikipedia - Bing", title);

        // Arrange
        await Page.ClearSearchTextAsync();

        // Act
        await Page.SearchByTextAsync("archive");

        // Arrange
        title = await Page.TitleAsync();
        Assert.AreEqual("archive - Bing", title);
    }
}

[Parallelizable(ParallelScope.Self)]
public class Test73 : DesktopPage
{
    [Test]
    public async Task TestMethod()
    {
        // Act
        await Page.OpenBingComAsync();

        // Assert
        var title = await Page.TitleAsync();
        Assert.AreEqual("Bing", title);

        // Act
        await Page.SearchByTextAsync("wikipedia");

        // Assert
        title = await Page.TitleAsync();
        Assert.AreEqual("wikipedia - Bing", title);

        // Arrange
        await Page.ClearSearchTextAsync();

        // Act
        await Page.SearchByTextAsync("archive");

        // Arrange
        title = await Page.TitleAsync();
        Assert.AreEqual("archive - Bing", title);
    }
}

[Parallelizable(ParallelScope.Self)]
public class Test74 : DesktopPage
{
    [Test]
    public async Task TestMethod()
    {
        // Act
        await Page.OpenBingComAsync();

        // Assert
        var title = await Page.TitleAsync();
        Assert.AreEqual("Bing", title);

        // Act
        await Page.SearchByTextAsync("wikipedia");

        // Assert
        title = await Page.TitleAsync();
        Assert.AreEqual("wikipedia - Bing", title);

        // Arrange
        await Page.ClearSearchTextAsync();

        // Act
        await Page.SearchByTextAsync("archive");

        // Arrange
        title = await Page.TitleAsync();
        Assert.AreEqual("archive - Bing", title);
    }
}

[Parallelizable(ParallelScope.Self)]
public class Test75 : DesktopPage
{
    [Test]
    public async Task TestMethod()
    {
        // Act
        await Page.OpenBingComAsync();

        // Assert
        var title = await Page.TitleAsync();
        Assert.AreEqual("Bing", title);

        // Act
        await Page.SearchByTextAsync("wikipedia");

        // Assert
        title = await Page.TitleAsync();
        Assert.AreEqual("wikipedia - Bing", title);

        // Arrange
        await Page.ClearSearchTextAsync();

        // Act
        await Page.SearchByTextAsync("archive");

        // Arrange
        title = await Page.TitleAsync();
        Assert.AreEqual("archive - Bing", title);
    }
}

[Parallelizable(ParallelScope.Self)]
public class Test76 : DesktopPage
{
    [Test]
    public async Task TestMethod()
    {
        // Act
        await Page.OpenBingComAsync();

        // Assert
        var title = await Page.TitleAsync();
        Assert.AreEqual("Bing", title);

        // Act
        await Page.SearchByTextAsync("wikipedia");

        // Assert
        title = await Page.TitleAsync();
        Assert.AreEqual("wikipedia - Bing", title);

        // Arrange
        await Page.ClearSearchTextAsync();

        // Act
        await Page.SearchByTextAsync("archive");

        // Arrange
        title = await Page.TitleAsync();
        Assert.AreEqual("archive - Bing", title);
    }
}

[Parallelizable(ParallelScope.Self)]
public class Test77 : DesktopPage
{
    [Test]
    public async Task TestMethod()
    {
        // Act
        await Page.OpenBingComAsync();

        // Assert
        var title = await Page.TitleAsync();
        Assert.AreEqual("Bing", title);

        // Act
        await Page.SearchByTextAsync("wikipedia");

        // Assert
        title = await Page.TitleAsync();
        Assert.AreEqual("wikipedia - Bing", title);

        // Arrange
        await Page.ClearSearchTextAsync();

        // Act
        await Page.SearchByTextAsync("archive");

        // Arrange
        title = await Page.TitleAsync();
        Assert.AreEqual("archive - Bing", title);
    }
}

[Parallelizable(ParallelScope.Self)]
public class Test78 : DesktopPage
{
    [Test]
    public async Task TestMethod()
    {
        // Act
        await Page.OpenBingComAsync();

        // Assert
        var title = await Page.TitleAsync();
        Assert.AreEqual("Bing", title);

        // Act
        await Page.SearchByTextAsync("wikipedia");

        // Assert
        title = await Page.TitleAsync();
        Assert.AreEqual("wikipedia - Bing", title);

        // Arrange
        await Page.ClearSearchTextAsync();

        // Act
        await Page.SearchByTextAsync("archive");

        // Arrange
        title = await Page.TitleAsync();
        Assert.AreEqual("archive - Bing", title);
    }
}

[Parallelizable(ParallelScope.Self)]
public class Test79 : DesktopPage
{
    [Test]
    public async Task TestMethod()
    {
        // Act
        await Page.OpenBingComAsync();

        // Assert
        var title = await Page.TitleAsync();
        Assert.AreEqual("Bing", title);

        // Act
        await Page.SearchByTextAsync("wikipedia");

        // Assert
        title = await Page.TitleAsync();
        Assert.AreEqual("wikipedia - Bing", title);

        // Arrange
        await Page.ClearSearchTextAsync();

        // Act
        await Page.SearchByTextAsync("archive");

        // Arrange
        title = await Page.TitleAsync();
        Assert.AreEqual("archive - Bing", title);
    }
}

[Parallelizable(ParallelScope.Self)]
public class Test80 : DesktopPage
{
    [Test]
    public async Task TestMethod()
    {
        // Act
        await Page.OpenBingComAsync();

        // Assert
        var title = await Page.TitleAsync();
        Assert.AreEqual("Bing", title);

        // Act
        await Page.SearchByTextAsync("wikipedia");

        // Assert
        title = await Page.TitleAsync();
        Assert.AreEqual("wikipedia - Bing", title);

        // Arrange
        await Page.ClearSearchTextAsync();

        // Act
        await Page.SearchByTextAsync("archive");

        // Arrange
        title = await Page.TitleAsync();
        Assert.AreEqual("archive - Bing", title);
    }
}

[Parallelizable(ParallelScope.Self)]
public class Test81 : DesktopPage
{
    [Test]
    public async Task TestMethod1()
    {
        // Act
        await Page.GotoAsync("https://bing.com");
        await Page.WaitForLoadStateAsync(LoadState.NetworkIdle);
        // Assert
        var title = await Page.TitleAsync();
        Assert.AreEqual("Bing", title);

        // Act
        await Page.TypeAsync("input#sb_form_q", "wikipedia");
        await Page.PressAsync("input#sb_form_q", "Enter");
        await Page.WaitForLoadStateAsync(LoadState.NetworkIdle);

        // Assert
        title = await Page.TitleAsync();
        Assert.AreEqual("wikipedia - Bing", title);

        // Arrange
        var searchInputElement = await Page.QuerySelectorAsync("input#sb_form_q");
        var inputValue = await Page.EvaluateAsync<string>("(e) => e.value", searchInputElement);
        var inputLength = inputValue.Length;

        await Page.FocusAsync("input#sb_form_q");
        await Page.Keyboard.PressAsync("End");
        for (var i = 0; i < inputLength; i++)
        {
            await Page.Keyboard.PressAsync("Backspace");
        }

        // Act
        await Page.TypeAsync("input#sb_form_q", "archive");
        await Page.PressAsync("input#sb_form_q", "Enter");
        await Page.WaitForLoadStateAsync(LoadState.NetworkIdle);

        // Arrange
        title = await Page.TitleAsync();
        Assert.AreEqual("archive - Bing", title);
    }
}

[Parallelizable(ParallelScope.Self)]
public class Test82 : DesktopPage
{
    [Test]
    public async Task TestMethod()
    {
        // Act
        await Page.OpenBingComAsync();

        // Assert
        var title = await Page.TitleAsync();
        Assert.AreEqual("Bing", title);

        // Act
        await Page.SearchByTextAsync("wikipedia");

        // Assert
        title = await Page.TitleAsync();
        Assert.AreEqual("wikipedia - Bing", title);

        // Arrange
        await Page.ClearSearchTextAsync();

        // Act
        await Page.SearchByTextAsync("archive");

        // Arrange
        title = await Page.TitleAsync();
        Assert.AreEqual("archive - Bing", title);
    }
}

[Parallelizable(ParallelScope.Self)]
public class Test83 : DesktopPage
{
    [Test]
    public async Task TestMethod()
    {
        // Act
        await Page.OpenBingComAsync();

        // Assert
        var title = await Page.TitleAsync();
        Assert.AreEqual("Bing", title);

        // Act
        await Page.SearchByTextAsync("wikipedia");

        // Assert
        title = await Page.TitleAsync();
        Assert.AreEqual("wikipedia - Bing", title);

        // Arrange
        await Page.ClearSearchTextAsync();

        // Act
        await Page.SearchByTextAsync("archive");

        // Arrange
        title = await Page.TitleAsync();
        Assert.AreEqual("archive - Bing", title);
    }
}

[Parallelizable(ParallelScope.Self)]
public class Test84 : DesktopPage
{
    [Test]
    public async Task TestMethod()
    {
        // Act
        await Page.OpenBingComAsync();

        // Assert
        var title = await Page.TitleAsync();
        Assert.AreEqual("Bing", title);

        // Act
        await Page.SearchByTextAsync("wikipedia");

        // Assert
        title = await Page.TitleAsync();
        Assert.AreEqual("wikipedia - Bing", title);

        // Arrange
        await Page.ClearSearchTextAsync();

        // Act
        await Page.SearchByTextAsync("archive");

        // Arrange
        title = await Page.TitleAsync();
        Assert.AreEqual("archive - Bing", title);
    }
}

[Parallelizable(ParallelScope.Self)]
public class Test85 : DesktopPage
{
    [Test]
    public async Task TestMethod()
    {
        // Act
        await Page.OpenBingComAsync();

        // Assert
        var title = await Page.TitleAsync();
        Assert.AreEqual("Bing", title);

        // Act
        await Page.SearchByTextAsync("wikipedia");

        // Assert
        title = await Page.TitleAsync();
        Assert.AreEqual("wikipedia - Bing", title);

        // Arrange
        await Page.ClearSearchTextAsync();

        // Act
        await Page.SearchByTextAsync("archive");

        // Arrange
        title = await Page.TitleAsync();
        Assert.AreEqual("archive - Bing", title);
    }
}

[Parallelizable(ParallelScope.Self)]
public class Test86 : DesktopPage
{
    [Test]
    public async Task TestMethod()
    {
        // Act
        await Page.OpenBingComAsync();

        // Assert
        var title = await Page.TitleAsync();
        Assert.AreEqual("Bing", title);

        // Act
        await Page.SearchByTextAsync("wikipedia");

        // Assert
        title = await Page.TitleAsync();
        Assert.AreEqual("wikipedia - Bing", title);

        // Arrange
        await Page.ClearSearchTextAsync();

        // Act
        await Page.SearchByTextAsync("archive");

        // Arrange
        title = await Page.TitleAsync();
        Assert.AreEqual("archive - Bing", title);
    }
}

[Parallelizable(ParallelScope.Self)]
public class Test87 : DesktopPage
{
    [Test]
    public async Task TestMethod()
    {
        // Act
        await Page.OpenBingComAsync();

        // Assert
        var title = await Page.TitleAsync();
        Assert.AreEqual("Bing", title);

        // Act
        await Page.SearchByTextAsync("wikipedia");

        // Assert
        title = await Page.TitleAsync();
        Assert.AreEqual("wikipedia - Bing", title);

        // Arrange
        await Page.ClearSearchTextAsync();

        // Act
        await Page.SearchByTextAsync("archive");

        // Arrange
        title = await Page.TitleAsync();
        Assert.AreEqual("archive - Bing", title);
    }
}

[Parallelizable(ParallelScope.Self)]
public class Test88 : DesktopPage
{
    [Test]
    public async Task TestMethod()
    {
        // Act
        await Page.OpenBingComAsync();

        // Assert
        var title = await Page.TitleAsync();
        Assert.AreEqual("Bing", title);

        // Act
        await Page.SearchByTextAsync("wikipedia");

        // Assert
        title = await Page.TitleAsync();
        Assert.AreEqual("wikipedia - Bing", title);

        // Arrange
        await Page.ClearSearchTextAsync();

        // Act
        await Page.SearchByTextAsync("archive");

        // Arrange
        title = await Page.TitleAsync();
        Assert.AreEqual("archive - Bing", title);
    }
}

[Parallelizable(ParallelScope.Self)]
public class Test89 : DesktopPage
{
    [Test]
    public async Task TestMethod()
    {
        // Act
        await Page.OpenBingComAsync();

        // Assert
        var title = await Page.TitleAsync();
        Assert.AreEqual("Bing", title);

        // Act
        await Page.SearchByTextAsync("wikipedia");

        // Assert
        title = await Page.TitleAsync();
        Assert.AreEqual("wikipedia - Bing", title);

        // Arrange
        await Page.ClearSearchTextAsync();

        // Act
        await Page.SearchByTextAsync("archive");

        // Arrange
        title = await Page.TitleAsync();
        Assert.AreEqual("archive - Bing", title);
    }
}

[Parallelizable(ParallelScope.Self)]
public class Test90 : DesktopPage
{
    [Test]
    public async Task TestMethod()
    {
        // Act
        await Page.OpenBingComAsync();

        // Assert
        var title = await Page.TitleAsync();
        Assert.AreEqual("Bing", title);

        // Act
        await Page.SearchByTextAsync("wikipedia");

        // Assert
        title = await Page.TitleAsync();
        Assert.AreEqual("wikipedia - Bing", title);

        // Arrange
        await Page.ClearSearchTextAsync();

        // Act
        await Page.SearchByTextAsync("archive");

        // Arrange
        title = await Page.TitleAsync();
        Assert.AreEqual("archive - Bing", title);
    }
}

[Parallelizable(ParallelScope.Self)]
public class Test91 : DesktopPage
{
    [Test]
    public async Task TestMethod1()
    {
        // Act
        await Page.GotoAsync("https://bing.com");
        await Page.WaitForLoadStateAsync(LoadState.NetworkIdle);
        // Assert
        var title = await Page.TitleAsync();
        Assert.AreEqual("Bing", title);

        // Act
        await Page.TypeAsync("input#sb_form_q", "wikipedia");
        await Page.PressAsync("input#sb_form_q", "Enter");
        await Page.WaitForLoadStateAsync(LoadState.NetworkIdle);

        // Assert
        title = await Page.TitleAsync();
        Assert.AreEqual("wikipedia - Bing", title);

        // Arrange
        var searchInputElement = await Page.QuerySelectorAsync("input#sb_form_q");
        var inputValue = await Page.EvaluateAsync<string>("(e) => e.value", searchInputElement);
        var inputLength = inputValue.Length;

        await Page.FocusAsync("input#sb_form_q");
        await Page.Keyboard.PressAsync("End");
        for (var i = 0; i < inputLength; i++)
        {
            await Page.Keyboard.PressAsync("Backspace");
        }

        // Act
        await Page.TypeAsync("input#sb_form_q", "archive");
        await Page.PressAsync("input#sb_form_q", "Enter");
        await Page.WaitForLoadStateAsync(LoadState.NetworkIdle);

        // Arrange
        title = await Page.TitleAsync();
        Assert.AreEqual("archive - Bing", title);
    }
}

[Parallelizable(ParallelScope.Self)]
public class Test92 : DesktopPage
{
    [Test]
    public async Task TestMethod()
    {
        // Act
        await Page.OpenBingComAsync();

        // Assert
        var title = await Page.TitleAsync();
        Assert.AreEqual("Bing", title);

        // Act
        await Page.SearchByTextAsync("wikipedia");

        // Assert
        title = await Page.TitleAsync();
        Assert.AreEqual("wikipedia - Bing", title);

        // Arrange
        await Page.ClearSearchTextAsync();

        // Act
        await Page.SearchByTextAsync("archive");

        // Arrange
        title = await Page.TitleAsync();
        Assert.AreEqual("archive - Bing", title);
    }
}

[Parallelizable(ParallelScope.Self)]
public class Test93 : DesktopPage
{
    [Test]
    public async Task TestMethod()
    {
        // Act
        await Page.OpenBingComAsync();

        // Assert
        var title = await Page.TitleAsync();
        Assert.AreEqual("Bing", title);

        // Act
        await Page.SearchByTextAsync("wikipedia");

        // Assert
        title = await Page.TitleAsync();
        Assert.AreEqual("wikipedia - Bing", title);

        // Arrange
        await Page.ClearSearchTextAsync();

        // Act
        await Page.SearchByTextAsync("archive");

        // Arrange
        title = await Page.TitleAsync();
        Assert.AreEqual("archive - Bing", title);
    }
}

[Parallelizable(ParallelScope.Self)]
public class Test94 : DesktopPage
{
    [Test]
    public async Task TestMethod()
    {
        // Act
        await Page.OpenBingComAsync();

        // Assert
        var title = await Page.TitleAsync();
        Assert.AreEqual("Bing", title);

        // Act
        await Page.SearchByTextAsync("wikipedia");

        // Assert
        title = await Page.TitleAsync();
        Assert.AreEqual("wikipedia - Bing", title);

        // Arrange
        await Page.ClearSearchTextAsync();

        // Act
        await Page.SearchByTextAsync("archive");

        // Arrange
        title = await Page.TitleAsync();
        Assert.AreEqual("archive - Bing", title);
    }
}

[Parallelizable(ParallelScope.Self)]
public class Test95 : DesktopPage
{
    [Test]
    public async Task TestMethod()
    {
        // Act
        await Page.OpenBingComAsync();

        // Assert
        var title = await Page.TitleAsync();
        Assert.AreEqual("Bing", title);

        // Act
        await Page.SearchByTextAsync("wikipedia");

        // Assert
        title = await Page.TitleAsync();
        Assert.AreEqual("wikipedia - Bing", title);

        // Arrange
        await Page.ClearSearchTextAsync();

        // Act
        await Page.SearchByTextAsync("archive");

        // Arrange
        title = await Page.TitleAsync();
        Assert.AreEqual("archive - Bing", title);
    }
}

[Parallelizable(ParallelScope.Self)]
public class Test96 : DesktopPage
{
    [Test]
    public async Task TestMethod()
    {
        // Act
        await Page.OpenBingComAsync();

        // Assert
        var title = await Page.TitleAsync();
        Assert.AreEqual("Bing", title);

        // Act
        await Page.SearchByTextAsync("wikipedia");

        // Assert
        title = await Page.TitleAsync();
        Assert.AreEqual("wikipedia - Bing", title);

        // Arrange
        await Page.ClearSearchTextAsync();

        // Act
        await Page.SearchByTextAsync("archive");

        // Arrange
        title = await Page.TitleAsync();
        Assert.AreEqual("archive - Bing", title);
    }
}

[Parallelizable(ParallelScope.Self)]
public class Test97 : DesktopPage
{
    [Test]
    public async Task TestMethod()
    {
        // Act
        await Page.OpenBingComAsync();

        // Assert
        var title = await Page.TitleAsync();
        Assert.AreEqual("Bing", title);

        // Act
        await Page.SearchByTextAsync("wikipedia");

        // Assert
        title = await Page.TitleAsync();
        Assert.AreEqual("wikipedia - Bing", title);

        // Arrange
        await Page.ClearSearchTextAsync();

        // Act
        await Page.SearchByTextAsync("archive");

        // Arrange
        title = await Page.TitleAsync();
        Assert.AreEqual("archive - Bing", title);
    }
}

[Parallelizable(ParallelScope.Self)]
public class Test98 : DesktopPage
{
    [Test]
    public async Task TestMethod()
    {
        // Act
        await Page.OpenBingComAsync();

        // Assert
        var title = await Page.TitleAsync();
        Assert.AreEqual("Bing", title);

        // Act
        await Page.SearchByTextAsync("wikipedia");

        // Assert
        title = await Page.TitleAsync();
        Assert.AreEqual("wikipedia - Bing", title);

        // Arrange
        await Page.ClearSearchTextAsync();

        // Act
        await Page.SearchByTextAsync("archive");

        // Arrange
        title = await Page.TitleAsync();
        Assert.AreEqual("archive - Bing", title);
    }
}

[Parallelizable(ParallelScope.Self)]
public class Test99 : DesktopPage
{
    [Test]
    public async Task TestMethod()
    {
        // Act
        await Page.OpenBingComAsync();

        // Assert
        var title = await Page.TitleAsync();
        Assert.AreEqual("Bing", title);

        // Act
        await Page.SearchByTextAsync("wikipedia");

        // Assert
        title = await Page.TitleAsync();
        Assert.AreEqual("wikipedia - Bing", title);

        // Arrange
        await Page.ClearSearchTextAsync();

        // Act
        await Page.SearchByTextAsync("archive");

        // Arrange
        title = await Page.TitleAsync();
        Assert.AreEqual("archive - Bing", title);
    }
}

[Parallelizable(ParallelScope.Self)]
public class Test100 : DesktopPage
{
    [Test]
    public async Task TestMethod()
    {
        // Act
        await Page.OpenBingComAsync();

        // Assert
        var title = await Page.TitleAsync();
        Assert.AreEqual("Bing", title);

        // Act
        await Page.SearchByTextAsync("wikipedia");

        // Assert
        title = await Page.TitleAsync();
        Assert.AreEqual("wikipedia - Bing", title);

        // Arrange
        await Page.ClearSearchTextAsync();

        // Act
        await Page.SearchByTextAsync("archive");

        // Arrange
        title = await Page.TitleAsync();
        Assert.AreEqual("archive - Bing", title);
    }
}