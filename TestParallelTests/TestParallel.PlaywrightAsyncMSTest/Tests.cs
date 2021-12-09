/*
 * MIT License
 *
 * Copyright (c) Evgeny Nazarchuk.
 *
 * Permission is hereby granted, free of charge, to any person obtaining a copy
 * of this software and associated documentation files (the "Software"), to deal
 * in the Software without restriction, including without limitation the rights
 * to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
 * copies of the Software, and to permit persons to whom the Software is
 * furnished to do so, subject to the following conditions:
 *
 * The above copyright notice and this permission notice shall be included in all
 * copies or substantial portions of the Software.
 *
 * THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
 * IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
 * FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
 * AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
 * LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
 * OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
 * SOFTWARE.
 */

using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;
using Microsoft.Playwright;
using TestParallel.ActionExtensions;
using TestParallel.PlaywrightAsyncMSTest.Support;

namespace TestParallel.PlaywrightAsyncMSTest;

[TestClass]
public class Tests : DesktopPage
{
    [UITest]
    [RestartOnException(3)]
    public async Task TestMethod1()
    {
        // Act
        await Page.GotoAsync("https://www.google.com/?hl=en");
        await Page.WaitForLoadStateAsync(LoadState.NetworkIdle);

        // Assert
        var title = await Page.TitleAsync();
        Assert.AreEqual("Google", title);

        // Act
        await Page.TypeAsync("div+input[name='q']", "wikipedia");
        await Page.PressAsync("div+input[name='q']", "Enter");
        await Page.WaitForLoadStateAsync(LoadState.NetworkIdle);

        // Assert
        title = await Page.TitleAsync();
        Assert.AreEqual("wikipedia - Google Search", title);

        // Arrange
        var searchInputElement = await Page.QuerySelectorAsync("div+input[name='q']");
        var inputValue = await Page.EvaluateAsync<string>("(e) => e.value", searchInputElement);
        var inputLength = inputValue.Length;

        await Page.FocusAsync("div+input[name='q']");
        await Page.Keyboard.PressAsync("End");
        for (var i = 0; i < inputLength; i++)
        {
            await Page.Keyboard.PressAsync("Backspace");
        }

        // Act
        await Page.TypeAsync("div+input[name='q']", "archive");
        await Page.PressAsync("div+input[name='q']", "Enter");
        await Page.WaitForLoadStateAsync(LoadState.NetworkIdle);

        // Assert
        title = await Page.TitleAsync();
        Assert.AreEqual("archive - Google Search", title);
    }

    [UITest]
    [RestartOnException(3)]
    public async Task TestMethod2()
    {
        // Act
        await Page.OpenSearchPageAsync();

        // Assert
        var title = await Page.TitleAsync();
        Assert.AreEqual("Google", title);

        // Act
        await Page.SearchByTextAsync("wikipedia");

        // Assert
        title = await Page.TitleAsync();
        Assert.AreEqual("wikipedia - Google Search", title);

        // Arrange
        await Page.ClearSearchTextAsync();

        // Act
        await Page.SearchByTextAsync("archive");

        // Assert
        title = await Page.TitleAsync();
        Assert.AreEqual("archive - Google Search", title);
    }

    [UITest]
    [RestartOnException(3)]
    public async Task TestMethod3()
    {
        // Act
        await Page.OpenSearchPageAsync();

        // Assert
        var title = await Page.TitleAsync();
        Assert.AreEqual("Google", title);

        // Act
        await Page.SearchByTextAsync("wikipedia");

        // Assert
        title = await Page.TitleAsync();
        Assert.AreEqual("wikipedia - Google Search", title);

        // Arrange
        await Page.ClearSearchTextAsync();

        // Act
        await Page.SearchByTextAsync("archive");

        // Assert
        title = await Page.TitleAsync();
        Assert.AreEqual("archive - Google Search", title);
    }

    [UITest]
    [RestartOnException(3)]
    public async Task TestMethod4()
    {
        // Act
        await Page.OpenSearchPageAsync();

        // Assert
        var title = await Page.TitleAsync();
        Assert.AreEqual("Google", title);

        // Act
        await Page.SearchByTextAsync("wikipedia");

        // Assert
        title = await Page.TitleAsync();
        Assert.AreEqual("wikipedia - Google Search", title);

        // Arrange
        await Page.ClearSearchTextAsync();

        // Act
        await Page.SearchByTextAsync("archive");

        // Assert
        title = await Page.TitleAsync();
        Assert.AreEqual("archive - Google Search", title);
    }

    [UITest]
    [RestartOnException(3)]
    public async Task TestMethod5()
    {
        // Act
        await Page.OpenSearchPageAsync();

        // Assert
        var title = await Page.TitleAsync();
        Assert.AreEqual("Google", title);

        // Act
        await Page.SearchByTextAsync("wikipedia");

        // Assert
        title = await Page.TitleAsync();
        Assert.AreEqual("wikipedia - Google Search", title);

        // Arrange
        await Page.ClearSearchTextAsync();

        // Act
        await Page.SearchByTextAsync("archive");

        // Assert
        title = await Page.TitleAsync();
        Assert.AreEqual("archive - Google Search", title);
    }

    [UITest]
    [RestartOnException(3)]
    public async Task TestMethod6()
    {
        // Act
        await Page.OpenSearchPageAsync();

        // Assert
        var title = await Page.TitleAsync();
        Assert.AreEqual("Google", title);

        // Act
        await Page.SearchByTextAsync("wikipedia");

        // Assert
        title = await Page.TitleAsync();
        Assert.AreEqual("wikipedia - Google Search", title);

        // Arrange
        await Page.ClearSearchTextAsync();

        // Act
        await Page.SearchByTextAsync("archive");

        // Assert
        title = await Page.TitleAsync();
        Assert.AreEqual("archive - Google Search", title);
    }

    [UITest]
    [RestartOnException(3)]
    public async Task TestMethod7()
    {
        // Act
        await Page.OpenSearchPageAsync();

        // Assert
        var title = await Page.TitleAsync();
        Assert.AreEqual("Google", title);

        // Act
        await Page.SearchByTextAsync("wikipedia");

        // Assert
        title = await Page.TitleAsync();
        Assert.AreEqual("wikipedia - Google Search", title);

        // Arrange
        await Page.ClearSearchTextAsync();

        // Act
        await Page.SearchByTextAsync("archive");

        // Assert
        title = await Page.TitleAsync();
        Assert.AreEqual("archive - Google Search", title);
    }

    [UITest]
    [RestartOnException(3)]
    public async Task TestMethod8()
    {
        // Act
        await Page.OpenSearchPageAsync();

        // Assert
        var title = await Page.TitleAsync();
        Assert.AreEqual("Google", title);

        // Act
        await Page.SearchByTextAsync("wikipedia");

        // Assert
        title = await Page.TitleAsync();
        Assert.AreEqual("wikipedia - Google Search", title);

        // Arrange
        await Page.ClearSearchTextAsync();

        // Act
        await Page.SearchByTextAsync("archive");

        // Assert
        title = await Page.TitleAsync();
        Assert.AreEqual("archive - Google Search", title);
    }

    [UITest]
    [RestartOnException(3)]
    public async Task TestMethod9()
    {
        // Act
        await Page.OpenSearchPageAsync();

        // Assert
        var title = await Page.TitleAsync();
        Assert.AreEqual("Google", title);

        // Act
        await Page.SearchByTextAsync("wikipedia");

        // Assert
        title = await Page.TitleAsync();
        Assert.AreEqual("wikipedia - Google Search", title);

        // Arrange
        await Page.ClearSearchTextAsync();

        // Act
        await Page.SearchByTextAsync("archive");

        // Assert
        title = await Page.TitleAsync();
        Assert.AreEqual("archive - Google Search", title);
    }

    [UITest]
    [RestartOnException(3)]
    public async Task TestMethod10()
    {
        // Act
        await Page.OpenSearchPageAsync();

        // Assert
        var title = await Page.TitleAsync();
        Assert.AreEqual("Google", title);

        // Act
        await Page.SearchByTextAsync("wikipedia");

        // Assert
        title = await Page.TitleAsync();
        Assert.AreEqual("wikipedia - Google Search", title);

        // Arrange
        await Page.ClearSearchTextAsync();

        // Act
        await Page.SearchByTextAsync("archive");

        // Assert
        title = await Page.TitleAsync();
        Assert.AreEqual("archive - Google Search", title);
    }

    [UITest]
    [RestartOnException(3)]
    public async Task TestMethod11()
    {
        // Act
        await Page.OpenSearchPageAsync();

        // Assert
        var title = await Page.TitleAsync();
        Assert.AreEqual("Google", title);

        // Act
        await Page.SearchByTextAsync("wikipedia");

        // Assert
        title = await Page.TitleAsync();
        Assert.AreEqual("wikipedia - Google Search", title);

        // Arrange
        await Page.ClearSearchTextAsync();

        // Act
        await Page.SearchByTextAsync("archive");

        // Assert
        title = await Page.TitleAsync();
        Assert.AreEqual("archive - Google Search", title);
    }

    [UITest]
    [RestartOnException(3)]
    public async Task TestMethod12()
    {
        // Act
        await Page.OpenSearchPageAsync();

        // Assert
        var title = await Page.TitleAsync();
        Assert.AreEqual("Google", title);

        // Act
        await Page.SearchByTextAsync("wikipedia");

        // Assert
        title = await Page.TitleAsync();
        Assert.AreEqual("wikipedia - Google Search", title);

        // Arrange
        await Page.ClearSearchTextAsync();

        // Act
        await Page.SearchByTextAsync("archive");

        // Assert
        title = await Page.TitleAsync();
        Assert.AreEqual("archive - Google Search", title);
    }

    [UITest]
    [RestartOnException(3)]
    public async Task TestMethod13()
    {
        // Act
        await Page.OpenSearchPageAsync();

        // Assert
        var title = await Page.TitleAsync();
        Assert.AreEqual("Google", title);

        // Act
        await Page.SearchByTextAsync("wikipedia");

        // Assert
        title = await Page.TitleAsync();
        Assert.AreEqual("wikipedia - Google Search", title);

        // Arrange
        await Page.ClearSearchTextAsync();

        // Act
        await Page.SearchByTextAsync("archive");

        // Assert
        title = await Page.TitleAsync();
        Assert.AreEqual("archive - Google Search", title);
    }

    [UITest]
    [RestartOnException(3)]
    public async Task TestMethod14()
    {
        // Act
        await Page.OpenSearchPageAsync();

        // Assert
        var title = await Page.TitleAsync();
        Assert.AreEqual("Google", title);

        // Act
        await Page.SearchByTextAsync("wikipedia");

        // Assert
        title = await Page.TitleAsync();
        Assert.AreEqual("wikipedia - Google Search", title);

        // Arrange
        await Page.ClearSearchTextAsync();

        // Act
        await Page.SearchByTextAsync("archive");

        // Assert
        title = await Page.TitleAsync();
        Assert.AreEqual("archive - Google Search", title);
    }

    [UITest]
    [RestartOnException(3)]
    public async Task TestMethod15()
    {
        // Act
        await Page.OpenSearchPageAsync();

        // Assert
        var title = await Page.TitleAsync();
        Assert.AreEqual("Google", title);

        // Act
        await Page.SearchByTextAsync("wikipedia");

        // Assert
        title = await Page.TitleAsync();
        Assert.AreEqual("wikipedia - Google Search", title);

        // Arrange
        await Page.ClearSearchTextAsync();

        // Act
        await Page.SearchByTextAsync("archive");

        // Assert
        title = await Page.TitleAsync();
        Assert.AreEqual("archive - Google Search", title);
    }

    [UITest]
    [RestartOnException(3)]
    public async Task TestMethod16()
    {
        // Act
        await Page.OpenSearchPageAsync();

        // Assert
        var title = await Page.TitleAsync();
        Assert.AreEqual("Google", title);

        // Act
        await Page.SearchByTextAsync("wikipedia");

        // Assert
        title = await Page.TitleAsync();
        Assert.AreEqual("wikipedia - Google Search", title);

        // Arrange
        await Page.ClearSearchTextAsync();

        // Act
        await Page.SearchByTextAsync("archive");

        // Assert
        title = await Page.TitleAsync();
        Assert.AreEqual("archive - Google Search", title);
    }

    [UITest]
    [RestartOnException(3)]
    public async Task TestMethod17()
    {
        // Act
        await Page.OpenSearchPageAsync();

        // Assert
        var title = await Page.TitleAsync();
        Assert.AreEqual("Google", title);

        // Act
        await Page.SearchByTextAsync("wikipedia");

        // Assert
        title = await Page.TitleAsync();
        Assert.AreEqual("wikipedia - Google Search", title);

        // Arrange
        await Page.ClearSearchTextAsync();

        // Act
        await Page.SearchByTextAsync("archive");

        // Assert
        title = await Page.TitleAsync();
        Assert.AreEqual("archive - Google Search", title);
    }

    [UITest]
    [RestartOnException(3)]
    public async Task TestMethod18()
    {
        // Act
        await Page.OpenSearchPageAsync();

        // Assert
        var title = await Page.TitleAsync();
        Assert.AreEqual("Google", title);

        // Act
        await Page.SearchByTextAsync("wikipedia");

        // Assert
        title = await Page.TitleAsync();
        Assert.AreEqual("wikipedia - Google Search", title);

        // Arrange
        await Page.ClearSearchTextAsync();

        // Act
        await Page.SearchByTextAsync("archive");

        // Assert
        title = await Page.TitleAsync();
        Assert.AreEqual("archive - Google Search", title);
    }

    [UITest]
    [RestartOnException(3)]
    public async Task TestMethod19()
    {
        // Act
        await Page.OpenSearchPageAsync();

        // Assert
        var title = await Page.TitleAsync();
        Assert.AreEqual("Google", title);

        // Act
        await Page.SearchByTextAsync("wikipedia");

        // Assert
        title = await Page.TitleAsync();
        Assert.AreEqual("wikipedia - Google Search", title);

        // Arrange
        await Page.ClearSearchTextAsync();

        // Act
        await Page.SearchByTextAsync("archive");

        // Assert
        title = await Page.TitleAsync();
        Assert.AreEqual("archive - Google Search", title);
    }

    [UITest]
    [RestartOnException(3)]
    public async Task TestMethod20()
    {
        // Act
        await Page.OpenSearchPageAsync();

        // Assert
        var title = await Page.TitleAsync();
        Assert.AreEqual("Google", title);

        // Act
        await Page.SearchByTextAsync("wikipedia");

        // Assert
        title = await Page.TitleAsync();
        Assert.AreEqual("wikipedia - Google Search", title);

        // Arrange
        await Page.ClearSearchTextAsync();

        // Act
        await Page.SearchByTextAsync("archive");

        // Assert
        title = await Page.TitleAsync();
        Assert.AreEqual("archive - Google Search", title);
    }

    [UITest]
    [RestartOnException(3)]
    public async Task TestMethod21()
    {
        // Act
        await Page.OpenSearchPageAsync();

        // Assert
        var title = await Page.TitleAsync();
        Assert.AreEqual("Google", title);

        // Act
        await Page.SearchByTextAsync("wikipedia");

        // Assert
        title = await Page.TitleAsync();
        Assert.AreEqual("wikipedia - Google Search", title);

        // Arrange
        await Page.ClearSearchTextAsync();

        // Act
        await Page.SearchByTextAsync("archive");

        // Assert
        title = await Page.TitleAsync();
        Assert.AreEqual("archive - Google Search", title);
    }

    [UITest]
    [RestartOnException(3)]
    public async Task TestMethod22()
    {
        // Act
        await Page.OpenSearchPageAsync();

        // Assert
        var title = await Page.TitleAsync();
        Assert.AreEqual("Google", title);

        // Act
        await Page.SearchByTextAsync("wikipedia");

        // Assert
        title = await Page.TitleAsync();
        Assert.AreEqual("wikipedia - Google Search", title);

        // Arrange
        await Page.ClearSearchTextAsync();

        // Act
        await Page.SearchByTextAsync("archive");

        // Assert
        title = await Page.TitleAsync();
        Assert.AreEqual("archive - Google Search", title);
    }

    [UITest]
    [RestartOnException(3)]
    public async Task TestMethod23()
    {
        // Act
        await Page.OpenSearchPageAsync();

        // Assert
        var title = await Page.TitleAsync();
        Assert.AreEqual("Google", title);

        // Act
        await Page.SearchByTextAsync("wikipedia");

        // Assert
        title = await Page.TitleAsync();
        Assert.AreEqual("wikipedia - Google Search", title);

        // Arrange
        await Page.ClearSearchTextAsync();

        // Act
        await Page.SearchByTextAsync("archive");

        // Assert
        title = await Page.TitleAsync();
        Assert.AreEqual("archive - Google Search", title);
    }

    [UITest]
    [RestartOnException(3)]
    public async Task TestMethod24()
    {
        // Act
        await Page.OpenSearchPageAsync();

        // Assert
        var title = await Page.TitleAsync();
        Assert.AreEqual("Google", title);

        // Act
        await Page.SearchByTextAsync("wikipedia");

        // Assert
        title = await Page.TitleAsync();
        Assert.AreEqual("wikipedia - Google Search", title);

        // Arrange
        await Page.ClearSearchTextAsync();

        // Act
        await Page.SearchByTextAsync("archive");

        // Assert
        title = await Page.TitleAsync();
        Assert.AreEqual("archive - Google Search", title);
    }

    [UITest]
    [RestartOnException(3)]
    public async Task TestMethod25()
    {
        // Act
        await Page.OpenSearchPageAsync();

        // Assert
        var title = await Page.TitleAsync();
        Assert.AreEqual("Google", title);

        // Act
        await Page.SearchByTextAsync("wikipedia");

        // Assert
        title = await Page.TitleAsync();
        Assert.AreEqual("wikipedia - Google Search", title);

        // Arrange
        await Page.ClearSearchTextAsync();

        // Act
        await Page.SearchByTextAsync("archive");

        // Assert
        title = await Page.TitleAsync();
        Assert.AreEqual("archive - Google Search", title);
    }

    [UITest]
    [RestartOnException(3)]
    public async Task TestMethod26()
    {
        // Act
        await Page.OpenSearchPageAsync();

        // Assert
        var title = await Page.TitleAsync();
        Assert.AreEqual("Google", title);

        // Act
        await Page.SearchByTextAsync("wikipedia");

        // Assert
        title = await Page.TitleAsync();
        Assert.AreEqual("wikipedia - Google Search", title);

        // Arrange
        await Page.ClearSearchTextAsync();

        // Act
        await Page.SearchByTextAsync("archive");

        // Assert
        title = await Page.TitleAsync();
        Assert.AreEqual("archive - Google Search", title);
    }

    [UITest]
    [RestartOnException(3)]
    public async Task TestMethod27()
    {
        // Act
        await Page.OpenSearchPageAsync();

        // Assert
        var title = await Page.TitleAsync();
        Assert.AreEqual("Google", title);

        // Act
        await Page.SearchByTextAsync("wikipedia");

        // Assert
        title = await Page.TitleAsync();
        Assert.AreEqual("wikipedia - Google Search", title);

        // Arrange
        await Page.ClearSearchTextAsync();

        // Act
        await Page.SearchByTextAsync("archive");

        // Assert
        title = await Page.TitleAsync();
        Assert.AreEqual("archive - Google Search", title);
    }

    [UITest]
    [RestartOnException(3)]
    public async Task TestMethod28()
    {
        // Act
        await Page.OpenSearchPageAsync();

        // Assert
        var title = await Page.TitleAsync();
        Assert.AreEqual("Google", title);

        // Act
        await Page.SearchByTextAsync("wikipedia");

        // Assert
        title = await Page.TitleAsync();
        Assert.AreEqual("wikipedia - Google Search", title);

        // Arrange
        await Page.ClearSearchTextAsync();

        // Act
        await Page.SearchByTextAsync("archive");

        // Assert
        title = await Page.TitleAsync();
        Assert.AreEqual("archive - Google Search", title);
    }

    [UITest]
    [RestartOnException(3)]
    public async Task TestMethod29()
    {
        // Act
        await Page.OpenSearchPageAsync();

        // Assert
        var title = await Page.TitleAsync();
        Assert.AreEqual("Google", title);

        // Act
        await Page.SearchByTextAsync("wikipedia");

        // Assert
        title = await Page.TitleAsync();
        Assert.AreEqual("wikipedia - Google Search", title);

        // Arrange
        await Page.ClearSearchTextAsync();

        // Act
        await Page.SearchByTextAsync("archive");

        // Assert
        title = await Page.TitleAsync();
        Assert.AreEqual("archive - Google Search", title);
    }

    [UITest]
    [RestartOnException(3)]
    public async Task TestMethod30()
    {
        // Act
        await Page.OpenSearchPageAsync();

        // Assert
        var title = await Page.TitleAsync();
        Assert.AreEqual("Google", title);

        // Act
        await Page.SearchByTextAsync("wikipedia");

        // Assert
        title = await Page.TitleAsync();
        Assert.AreEqual("wikipedia - Google Search", title);

        // Arrange
        await Page.ClearSearchTextAsync();

        // Act
        await Page.SearchByTextAsync("archive");

        // Assert
        title = await Page.TitleAsync();
        Assert.AreEqual("archive - Google Search", title);
    }

    [UITest]
    [RestartOnException(3)]
    public async Task TestMethod31()
    {
        // Act
        await Page.OpenSearchPageAsync();

        // Assert
        var title = await Page.TitleAsync();
        Assert.AreEqual("Google", title);

        // Act
        await Page.SearchByTextAsync("wikipedia");

        // Assert
        title = await Page.TitleAsync();
        Assert.AreEqual("wikipedia - Google Search", title);

        // Arrange
        await Page.ClearSearchTextAsync();

        // Act
        await Page.SearchByTextAsync("archive");

        // Assert
        title = await Page.TitleAsync();
        Assert.AreEqual("archive - Google Search", title);
    }

    [UITest]
    [RestartOnException(3)]
    public async Task TestMethod32()
    {
        // Act
        await Page.OpenSearchPageAsync();

        // Assert
        var title = await Page.TitleAsync();
        Assert.AreEqual("Google", title);

        // Act
        await Page.SearchByTextAsync("wikipedia");

        // Assert
        title = await Page.TitleAsync();
        Assert.AreEqual("wikipedia - Google Search", title);

        // Arrange
        await Page.ClearSearchTextAsync();

        // Act
        await Page.SearchByTextAsync("archive");

        // Assert
        title = await Page.TitleAsync();
        Assert.AreEqual("archive - Google Search", title);
    }

    [UITest]
    [RestartOnException(3)]
    public async Task TestMethod33()
    {
        // Act
        await Page.OpenSearchPageAsync();

        // Assert
        var title = await Page.TitleAsync();
        Assert.AreEqual("Google", title);

        // Act
        await Page.SearchByTextAsync("wikipedia");

        // Assert
        title = await Page.TitleAsync();
        Assert.AreEqual("wikipedia - Google Search", title);

        // Arrange
        await Page.ClearSearchTextAsync();

        // Act
        await Page.SearchByTextAsync("archive");

        // Assert
        title = await Page.TitleAsync();
        Assert.AreEqual("archive - Google Search", title);
    }

    [UITest]
    [RestartOnException(3)]
    public async Task TestMethod34()
    {
        // Act
        await Page.OpenSearchPageAsync();

        // Assert
        var title = await Page.TitleAsync();
        Assert.AreEqual("Google", title);

        // Act
        await Page.SearchByTextAsync("wikipedia");

        // Assert
        title = await Page.TitleAsync();
        Assert.AreEqual("wikipedia - Google Search", title);

        // Arrange
        await Page.ClearSearchTextAsync();

        // Act
        await Page.SearchByTextAsync("archive");

        // Assert
        title = await Page.TitleAsync();
        Assert.AreEqual("archive - Google Search", title);
    }

    [UITest]
    [RestartOnException(3)]
    public async Task TestMethod35()
    {
        // Act
        await Page.OpenSearchPageAsync();

        // Assert
        var title = await Page.TitleAsync();
        Assert.AreEqual("Google", title);

        // Act
        await Page.SearchByTextAsync("wikipedia");

        // Assert
        title = await Page.TitleAsync();
        Assert.AreEqual("wikipedia - Google Search", title);

        // Arrange
        await Page.ClearSearchTextAsync();

        // Act
        await Page.SearchByTextAsync("archive");

        // Assert
        title = await Page.TitleAsync();
        Assert.AreEqual("archive - Google Search", title);
    }

    [UITest]
    [RestartOnException(3)]
    public async Task TestMethod36()
    {
        // Act
        await Page.OpenSearchPageAsync();

        // Assert
        var title = await Page.TitleAsync();
        Assert.AreEqual("Google", title);

        // Act
        await Page.SearchByTextAsync("wikipedia");

        // Assert
        title = await Page.TitleAsync();
        Assert.AreEqual("wikipedia - Google Search", title);

        // Arrange
        await Page.ClearSearchTextAsync();

        // Act
        await Page.SearchByTextAsync("archive");

        // Assert
        title = await Page.TitleAsync();
        Assert.AreEqual("archive - Google Search", title);
    }

    [UITest]
    [RestartOnException(3)]
    public async Task TestMethod37()
    {
        // Act
        await Page.OpenSearchPageAsync();

        // Assert
        var title = await Page.TitleAsync();
        Assert.AreEqual("Google", title);

        // Act
        await Page.SearchByTextAsync("wikipedia");

        // Assert
        title = await Page.TitleAsync();
        Assert.AreEqual("wikipedia - Google Search", title);

        // Arrange
        await Page.ClearSearchTextAsync();

        // Act
        await Page.SearchByTextAsync("archive");

        // Assert
        title = await Page.TitleAsync();
        Assert.AreEqual("archive - Google Search", title);
    }

    [UITest]
    [RestartOnException(3)]
    public async Task TestMethod38()
    {
        // Act
        await Page.OpenSearchPageAsync();

        // Assert
        var title = await Page.TitleAsync();
        Assert.AreEqual("Google", title);

        // Act
        await Page.SearchByTextAsync("wikipedia");

        // Assert
        title = await Page.TitleAsync();
        Assert.AreEqual("wikipedia - Google Search", title);

        // Arrange
        await Page.ClearSearchTextAsync();

        // Act
        await Page.SearchByTextAsync("archive");

        // Assert
        title = await Page.TitleAsync();
        Assert.AreEqual("archive - Google Search", title);
    }

    [UITest]
    [RestartOnException(3)]
    public async Task TestMethod39()
    {
        // Act
        await Page.OpenSearchPageAsync();

        // Assert
        var title = await Page.TitleAsync();
        Assert.AreEqual("Google", title);

        // Act
        await Page.SearchByTextAsync("wikipedia");

        // Assert
        title = await Page.TitleAsync();
        Assert.AreEqual("wikipedia - Google Search", title);

        // Arrange
        await Page.ClearSearchTextAsync();

        // Act
        await Page.SearchByTextAsync("archive");

        // Assert
        title = await Page.TitleAsync();
        Assert.AreEqual("archive - Google Search", title);
    }

    [UITest]
    [RestartOnException(3)]
    public async Task TestMethod40()
    {
        // Act
        await Page.OpenSearchPageAsync();

        // Assert
        var title = await Page.TitleAsync();
        Assert.AreEqual("Google", title);

        // Act
        await Page.SearchByTextAsync("wikipedia");

        // Assert
        title = await Page.TitleAsync();
        Assert.AreEqual("wikipedia - Google Search", title);

        // Arrange
        await Page.ClearSearchTextAsync();

        // Act
        await Page.SearchByTextAsync("archive");

        // Assert
        title = await Page.TitleAsync();
        Assert.AreEqual("archive - Google Search", title);
    }

    [UITest]
    [RestartOnException(3)]
    public async Task TestMethod41()
    {
        // Act
        await Page.OpenSearchPageAsync();

        // Assert
        var title = await Page.TitleAsync();
        Assert.AreEqual("Google", title);

        // Act
        await Page.SearchByTextAsync("wikipedia");

        // Assert
        title = await Page.TitleAsync();
        Assert.AreEqual("wikipedia - Google Search", title);

        // Arrange
        await Page.ClearSearchTextAsync();

        // Act
        await Page.SearchByTextAsync("archive");

        // Assert
        title = await Page.TitleAsync();
        Assert.AreEqual("archive - Google Search", title);
    }

    [UITest]
    [RestartOnException(3)]
    public async Task TestMethod42()
    {
        // Act
        await Page.OpenSearchPageAsync();

        // Assert
        var title = await Page.TitleAsync();
        Assert.AreEqual("Google", title);

        // Act
        await Page.SearchByTextAsync("wikipedia");

        // Assert
        title = await Page.TitleAsync();
        Assert.AreEqual("wikipedia - Google Search", title);

        // Arrange
        await Page.ClearSearchTextAsync();

        // Act
        await Page.SearchByTextAsync("archive");

        // Assert
        title = await Page.TitleAsync();
        Assert.AreEqual("archive - Google Search", title);
    }

    [UITest]
    [RestartOnException(3)]
    public async Task TestMethod43()
    {
        // Act
        await Page.OpenSearchPageAsync();

        // Assert
        var title = await Page.TitleAsync();
        Assert.AreEqual("Google", title);

        // Act
        await Page.SearchByTextAsync("wikipedia");

        // Assert
        title = await Page.TitleAsync();
        Assert.AreEqual("wikipedia - Google Search", title);

        // Arrange
        await Page.ClearSearchTextAsync();

        // Act
        await Page.SearchByTextAsync("archive");

        // Assert
        title = await Page.TitleAsync();
        Assert.AreEqual("archive - Google Search", title);
    }

    [UITest]
    [RestartOnException(3)]
    public async Task TestMethod44()
    {
        // Act
        await Page.OpenSearchPageAsync();

        // Assert
        var title = await Page.TitleAsync();
        Assert.AreEqual("Google", title);

        // Act
        await Page.SearchByTextAsync("wikipedia");

        // Assert
        title = await Page.TitleAsync();
        Assert.AreEqual("wikipedia - Google Search", title);

        // Arrange
        await Page.ClearSearchTextAsync();

        // Act
        await Page.SearchByTextAsync("archive");

        // Assert
        title = await Page.TitleAsync();
        Assert.AreEqual("archive - Google Search", title);
    }

    [UITest]
    [RestartOnException(3)]
    public async Task TestMethod45()
    {
        // Act
        await Page.OpenSearchPageAsync();

        // Assert
        var title = await Page.TitleAsync();
        Assert.AreEqual("Google", title);

        // Act
        await Page.SearchByTextAsync("wikipedia");

        // Assert
        title = await Page.TitleAsync();
        Assert.AreEqual("wikipedia - Google Search", title);

        // Arrange
        await Page.ClearSearchTextAsync();

        // Act
        await Page.SearchByTextAsync("archive");

        // Assert
        title = await Page.TitleAsync();
        Assert.AreEqual("archive - Google Search", title);
    }

    [UITest]
    [RestartOnException(3)]
    public async Task TestMethod46()
    {
        // Act
        await Page.OpenSearchPageAsync();

        // Assert
        var title = await Page.TitleAsync();
        Assert.AreEqual("Google", title);

        // Act
        await Page.SearchByTextAsync("wikipedia");

        // Assert
        title = await Page.TitleAsync();
        Assert.AreEqual("wikipedia - Google Search", title);

        // Arrange
        await Page.ClearSearchTextAsync();

        // Act
        await Page.SearchByTextAsync("archive");

        // Assert
        title = await Page.TitleAsync();
        Assert.AreEqual("archive - Google Search", title);
    }

    [UITest]
    [RestartOnException(3)]
    public async Task TestMethod47()
    {
        // Act
        await Page.OpenSearchPageAsync();

        // Assert
        var title = await Page.TitleAsync();
        Assert.AreEqual("Google", title);

        // Act
        await Page.SearchByTextAsync("wikipedia");

        // Assert
        title = await Page.TitleAsync();
        Assert.AreEqual("wikipedia - Google Search", title);

        // Arrange
        await Page.ClearSearchTextAsync();

        // Act
        await Page.SearchByTextAsync("archive");

        // Assert
        title = await Page.TitleAsync();
        Assert.AreEqual("archive - Google Search", title);
    }

    [UITest]
    [RestartOnException(3)]
    public async Task TestMethod48()
    {
        // Act
        await Page.OpenSearchPageAsync();

        // Assert
        var title = await Page.TitleAsync();
        Assert.AreEqual("Google", title);

        // Act
        await Page.SearchByTextAsync("wikipedia");

        // Assert
        title = await Page.TitleAsync();
        Assert.AreEqual("wikipedia - Google Search", title);

        // Arrange
        await Page.ClearSearchTextAsync();

        // Act
        await Page.SearchByTextAsync("archive");

        // Assert
        title = await Page.TitleAsync();
        Assert.AreEqual("archive - Google Search", title);
    }

    [UITest]
    [RestartOnException(3)]
    public async Task TestMethod49()
    {
        // Act
        await Page.OpenSearchPageAsync();

        // Assert
        var title = await Page.TitleAsync();
        Assert.AreEqual("Google", title);

        // Act
        await Page.SearchByTextAsync("wikipedia");

        // Assert
        title = await Page.TitleAsync();
        Assert.AreEqual("wikipedia - Google Search", title);

        // Arrange
        await Page.ClearSearchTextAsync();

        // Act
        await Page.SearchByTextAsync("archive");

        // Assert
        title = await Page.TitleAsync();
        Assert.AreEqual("archive - Google Search", title);
    }

    [UITest]
    [RestartOnException(3)]
    public async Task TestMethod50()
    {
        // Act
        await Page.OpenSearchPageAsync();

        // Assert
        var title = await Page.TitleAsync();
        Assert.AreEqual("Google", title);

        // Act
        await Page.SearchByTextAsync("wikipedia");

        // Assert
        title = await Page.TitleAsync();
        Assert.AreEqual("wikipedia - Google Search", title);

        // Arrange
        await Page.ClearSearchTextAsync();

        // Act
        await Page.SearchByTextAsync("archive");

        // Assert
        title = await Page.TitleAsync();
        Assert.AreEqual("archive - Google Search", title);
    }

    [UITest]
    [RestartOnException(3)]
    public async Task TestMethod51()
    {
        // Act
        await Page.OpenSearchPageAsync();

        // Assert
        var title = await Page.TitleAsync();
        Assert.AreEqual("Google", title);

        // Act
        await Page.SearchByTextAsync("wikipedia");

        // Assert
        title = await Page.TitleAsync();
        Assert.AreEqual("wikipedia - Google Search", title);

        // Arrange
        await Page.ClearSearchTextAsync();

        // Act
        await Page.SearchByTextAsync("archive");

        // Assert
        title = await Page.TitleAsync();
        Assert.AreEqual("archive - Google Search", title);
    }

    [UITest]
    [RestartOnException(3)]
    public async Task TestMethod52()
    {
        // Act
        await Page.OpenSearchPageAsync();

        // Assert
        var title = await Page.TitleAsync();
        Assert.AreEqual("Google", title);

        // Act
        await Page.SearchByTextAsync("wikipedia");

        // Assert
        title = await Page.TitleAsync();
        Assert.AreEqual("wikipedia - Google Search", title);

        // Arrange
        await Page.ClearSearchTextAsync();

        // Act
        await Page.SearchByTextAsync("archive");

        // Assert
        title = await Page.TitleAsync();
        Assert.AreEqual("archive - Google Search", title);
    }

    [UITest]
    [RestartOnException(3)]
    public async Task TestMethod53()
    {
        // Act
        await Page.OpenSearchPageAsync();

        // Assert
        var title = await Page.TitleAsync();
        Assert.AreEqual("Google", title);

        // Act
        await Page.SearchByTextAsync("wikipedia");

        // Assert
        title = await Page.TitleAsync();
        Assert.AreEqual("wikipedia - Google Search", title);

        // Arrange
        await Page.ClearSearchTextAsync();

        // Act
        await Page.SearchByTextAsync("archive");

        // Assert
        title = await Page.TitleAsync();
        Assert.AreEqual("archive - Google Search", title);
    }

    [UITest]
    [RestartOnException(3)]
    public async Task TestMethod54()
    {
        // Act
        await Page.OpenSearchPageAsync();

        // Assert
        var title = await Page.TitleAsync();
        Assert.AreEqual("Google", title);

        // Act
        await Page.SearchByTextAsync("wikipedia");

        // Assert
        title = await Page.TitleAsync();
        Assert.AreEqual("wikipedia - Google Search", title);

        // Arrange
        await Page.ClearSearchTextAsync();

        // Act
        await Page.SearchByTextAsync("archive");

        // Assert
        title = await Page.TitleAsync();
        Assert.AreEqual("archive - Google Search", title);
    }

    [UITest]
    [RestartOnException(3)]
    public async Task TestMethod55()
    {
        // Act
        await Page.OpenSearchPageAsync();

        // Assert
        var title = await Page.TitleAsync();
        Assert.AreEqual("Google", title);

        // Act
        await Page.SearchByTextAsync("wikipedia");

        // Assert
        title = await Page.TitleAsync();
        Assert.AreEqual("wikipedia - Google Search", title);

        // Arrange
        await Page.ClearSearchTextAsync();

        // Act
        await Page.SearchByTextAsync("archive");

        // Assert
        title = await Page.TitleAsync();
        Assert.AreEqual("archive - Google Search", title);
    }

    [UITest]
    [RestartOnException(3)]
    public async Task TestMethod56()
    {
        // Act
        await Page.OpenSearchPageAsync();

        // Assert
        var title = await Page.TitleAsync();
        Assert.AreEqual("Google", title);

        // Act
        await Page.SearchByTextAsync("wikipedia");

        // Assert
        title = await Page.TitleAsync();
        Assert.AreEqual("wikipedia - Google Search", title);

        // Arrange
        await Page.ClearSearchTextAsync();

        // Act
        await Page.SearchByTextAsync("archive");

        // Assert
        title = await Page.TitleAsync();
        Assert.AreEqual("archive - Google Search", title);
    }

    [UITest]
    [RestartOnException(3)]
    public async Task TestMethod57()
    {
        // Act
        await Page.OpenSearchPageAsync();

        // Assert
        var title = await Page.TitleAsync();
        Assert.AreEqual("Google", title);

        // Act
        await Page.SearchByTextAsync("wikipedia");

        // Assert
        title = await Page.TitleAsync();
        Assert.AreEqual("wikipedia - Google Search", title);

        // Arrange
        await Page.ClearSearchTextAsync();

        // Act
        await Page.SearchByTextAsync("archive");

        // Assert
        title = await Page.TitleAsync();
        Assert.AreEqual("archive - Google Search", title);
    }

    [UITest]
    [RestartOnException(3)]
    public async Task TestMethod58()
    {
        // Act
        await Page.OpenSearchPageAsync();

        // Assert
        var title = await Page.TitleAsync();
        Assert.AreEqual("Google", title);

        // Act
        await Page.SearchByTextAsync("wikipedia");

        // Assert
        title = await Page.TitleAsync();
        Assert.AreEqual("wikipedia - Google Search", title);

        // Arrange
        await Page.ClearSearchTextAsync();

        // Act
        await Page.SearchByTextAsync("archive");

        // Assert
        title = await Page.TitleAsync();
        Assert.AreEqual("archive - Google Search", title);
    }

    [UITest]
    [RestartOnException(3)]
    public async Task TestMethod59()
    {
        // Act
        await Page.OpenSearchPageAsync();

        // Assert
        var title = await Page.TitleAsync();
        Assert.AreEqual("Google", title);

        // Act
        await Page.SearchByTextAsync("wikipedia");

        // Assert
        title = await Page.TitleAsync();
        Assert.AreEqual("wikipedia - Google Search", title);

        // Arrange
        await Page.ClearSearchTextAsync();

        // Act
        await Page.SearchByTextAsync("archive");

        // Assert
        title = await Page.TitleAsync();
        Assert.AreEqual("archive - Google Search", title);
    }

    [UITest]
    [RestartOnException(3)]
    public async Task TestMethod60()
    {
        // Act
        await Page.OpenSearchPageAsync();

        // Assert
        var title = await Page.TitleAsync();
        Assert.AreEqual("Google", title);

        // Act
        await Page.SearchByTextAsync("wikipedia");

        // Assert
        title = await Page.TitleAsync();
        Assert.AreEqual("wikipedia - Google Search", title);

        // Arrange
        await Page.ClearSearchTextAsync();

        // Act
        await Page.SearchByTextAsync("archive");

        // Assert
        title = await Page.TitleAsync();
        Assert.AreEqual("archive - Google Search", title);
    }

    [UITest]
    [RestartOnException(3)]
    public async Task TestMethod61()
    {
        // Act
        await Page.OpenSearchPageAsync();

        // Assert
        var title = await Page.TitleAsync();
        Assert.AreEqual("Google", title);

        // Act
        await Page.SearchByTextAsync("wikipedia");

        // Assert
        title = await Page.TitleAsync();
        Assert.AreEqual("wikipedia - Google Search", title);

        // Arrange
        await Page.ClearSearchTextAsync();

        // Act
        await Page.SearchByTextAsync("archive");

        // Assert
        title = await Page.TitleAsync();
        Assert.AreEqual("archive - Google Search", title);
    }

    [UITest]
    [RestartOnException(3)]
    public async Task TestMethod62()
    {
        // Act
        await Page.OpenSearchPageAsync();

        // Assert
        var title = await Page.TitleAsync();
        Assert.AreEqual("Google", title);

        // Act
        await Page.SearchByTextAsync("wikipedia");

        // Assert
        title = await Page.TitleAsync();
        Assert.AreEqual("wikipedia - Google Search", title);

        // Arrange
        await Page.ClearSearchTextAsync();

        // Act
        await Page.SearchByTextAsync("archive");

        // Assert
        title = await Page.TitleAsync();
        Assert.AreEqual("archive - Google Search", title);
    }

    [UITest]
    [RestartOnException(3)]
    public async Task TestMethod63()
    {
        // Act
        await Page.OpenSearchPageAsync();

        // Assert
        var title = await Page.TitleAsync();
        Assert.AreEqual("Google", title);

        // Act
        await Page.SearchByTextAsync("wikipedia");

        // Assert
        title = await Page.TitleAsync();
        Assert.AreEqual("wikipedia - Google Search", title);

        // Arrange
        await Page.ClearSearchTextAsync();

        // Act
        await Page.SearchByTextAsync("archive");

        // Assert
        title = await Page.TitleAsync();
        Assert.AreEqual("archive - Google Search", title);
    }

    [UITest]
    [RestartOnException(3)]
    public async Task TestMethod64()
    {
        // Act
        await Page.OpenSearchPageAsync();

        // Assert
        var title = await Page.TitleAsync();
        Assert.AreEqual("Google", title);

        // Act
        await Page.SearchByTextAsync("wikipedia");

        // Assert
        title = await Page.TitleAsync();
        Assert.AreEqual("wikipedia - Google Search", title);

        // Arrange
        await Page.ClearSearchTextAsync();

        // Act
        await Page.SearchByTextAsync("archive");

        // Assert
        title = await Page.TitleAsync();
        Assert.AreEqual("archive - Google Search", title);
    }

    [UITest]
    [RestartOnException(3)]
    public async Task TestMethod65()
    {
        // Act
        await Page.OpenSearchPageAsync();

        // Assert
        var title = await Page.TitleAsync();
        Assert.AreEqual("Google", title);

        // Act
        await Page.SearchByTextAsync("wikipedia");

        // Assert
        title = await Page.TitleAsync();
        Assert.AreEqual("wikipedia - Google Search", title);

        // Arrange
        await Page.ClearSearchTextAsync();

        // Act
        await Page.SearchByTextAsync("archive");

        // Assert
        title = await Page.TitleAsync();
        Assert.AreEqual("archive - Google Search", title);
    }

    [UITest]
    [RestartOnException(3)]
    public async Task TestMethod66()
    {
        // Act
        await Page.OpenSearchPageAsync();

        // Assert
        var title = await Page.TitleAsync();
        Assert.AreEqual("Google", title);

        // Act
        await Page.SearchByTextAsync("wikipedia");

        // Assert
        title = await Page.TitleAsync();
        Assert.AreEqual("wikipedia - Google Search", title);

        // Arrange
        await Page.ClearSearchTextAsync();

        // Act
        await Page.SearchByTextAsync("archive");

        // Assert
        title = await Page.TitleAsync();
        Assert.AreEqual("archive - Google Search", title);
    }

    [UITest]
    [RestartOnException(3)]
    public async Task TestMethod67()
    {
        // Act
        await Page.OpenSearchPageAsync();

        // Assert
        var title = await Page.TitleAsync();
        Assert.AreEqual("Google", title);

        // Act
        await Page.SearchByTextAsync("wikipedia");

        // Assert
        title = await Page.TitleAsync();
        Assert.AreEqual("wikipedia - Google Search", title);

        // Arrange
        await Page.ClearSearchTextAsync();

        // Act
        await Page.SearchByTextAsync("archive");

        // Assert
        title = await Page.TitleAsync();
        Assert.AreEqual("archive - Google Search", title);
    }

    [UITest]
    [RestartOnException(3)]
    public async Task TestMethod68()
    {
        // Act
        await Page.OpenSearchPageAsync();

        // Assert
        var title = await Page.TitleAsync();
        Assert.AreEqual("Google", title);

        // Act
        await Page.SearchByTextAsync("wikipedia");

        // Assert
        title = await Page.TitleAsync();
        Assert.AreEqual("wikipedia - Google Search", title);

        // Arrange
        await Page.ClearSearchTextAsync();

        // Act
        await Page.SearchByTextAsync("archive");

        // Assert
        title = await Page.TitleAsync();
        Assert.AreEqual("archive - Google Search", title);
    }

    [UITest]
    [RestartOnException(3)]
    public async Task TestMethod69()
    {
        // Act
        await Page.OpenSearchPageAsync();

        // Assert
        var title = await Page.TitleAsync();
        Assert.AreEqual("Google", title);

        // Act
        await Page.SearchByTextAsync("wikipedia");

        // Assert
        title = await Page.TitleAsync();
        Assert.AreEqual("wikipedia - Google Search", title);

        // Arrange
        await Page.ClearSearchTextAsync();

        // Act
        await Page.SearchByTextAsync("archive");

        // Assert
        title = await Page.TitleAsync();
        Assert.AreEqual("archive - Google Search", title);
    }

    [UITest]
    [RestartOnException(3)]
    public async Task TestMethod70()
    {
        // Act
        await Page.OpenSearchPageAsync();

        // Assert
        var title = await Page.TitleAsync();
        Assert.AreEqual("Google", title);

        // Act
        await Page.SearchByTextAsync("wikipedia");

        // Assert
        title = await Page.TitleAsync();
        Assert.AreEqual("wikipedia - Google Search", title);

        // Arrange
        await Page.ClearSearchTextAsync();

        // Act
        await Page.SearchByTextAsync("archive");

        // Assert
        title = await Page.TitleAsync();
        Assert.AreEqual("archive - Google Search", title);
    }

    [UITest]
    [RestartOnException(3)]
    public async Task TestMethod71()
    {
        // Act
        await Page.OpenSearchPageAsync();

        // Assert
        var title = await Page.TitleAsync();
        Assert.AreEqual("Google", title);

        // Act
        await Page.SearchByTextAsync("wikipedia");

        // Assert
        title = await Page.TitleAsync();
        Assert.AreEqual("wikipedia - Google Search", title);

        // Arrange
        await Page.ClearSearchTextAsync();

        // Act
        await Page.SearchByTextAsync("archive");

        // Assert
        title = await Page.TitleAsync();
        Assert.AreEqual("archive - Google Search", title);
    }

    [UITest]
    [RestartOnException(3)]
    public async Task TestMethod72()
    {
        // Act
        await Page.OpenSearchPageAsync();

        // Assert
        var title = await Page.TitleAsync();
        Assert.AreEqual("Google", title);

        // Act
        await Page.SearchByTextAsync("wikipedia");

        // Assert
        title = await Page.TitleAsync();
        Assert.AreEqual("wikipedia - Google Search", title);

        // Arrange
        await Page.ClearSearchTextAsync();

        // Act
        await Page.SearchByTextAsync("archive");

        // Assert
        title = await Page.TitleAsync();
        Assert.AreEqual("archive - Google Search", title);
    }

    [UITest]
    [RestartOnException(3)]
    public async Task TestMethod73()
    {
        // Act
        await Page.OpenSearchPageAsync();

        // Assert
        var title = await Page.TitleAsync();
        Assert.AreEqual("Google", title);

        // Act
        await Page.SearchByTextAsync("wikipedia");

        // Assert
        title = await Page.TitleAsync();
        Assert.AreEqual("wikipedia - Google Search", title);

        // Arrange
        await Page.ClearSearchTextAsync();

        // Act
        await Page.SearchByTextAsync("archive");

        // Assert
        title = await Page.TitleAsync();
        Assert.AreEqual("archive - Google Search", title);
    }

    [UITest]
    [RestartOnException(3)]
    public async Task TestMethod74()
    {
        // Act
        await Page.OpenSearchPageAsync();

        // Assert
        var title = await Page.TitleAsync();
        Assert.AreEqual("Google", title);

        // Act
        await Page.SearchByTextAsync("wikipedia");

        // Assert
        title = await Page.TitleAsync();
        Assert.AreEqual("wikipedia - Google Search", title);

        // Arrange
        await Page.ClearSearchTextAsync();

        // Act
        await Page.SearchByTextAsync("archive");

        // Assert
        title = await Page.TitleAsync();
        Assert.AreEqual("archive - Google Search", title);
    }

    [UITest]
    [RestartOnException(3)]
    public async Task TestMethod75()
    {
        // Act
        await Page.OpenSearchPageAsync();

        // Assert
        var title = await Page.TitleAsync();
        Assert.AreEqual("Google", title);

        // Act
        await Page.SearchByTextAsync("wikipedia");

        // Assert
        title = await Page.TitleAsync();
        Assert.AreEqual("wikipedia - Google Search", title);

        // Arrange
        await Page.ClearSearchTextAsync();

        // Act
        await Page.SearchByTextAsync("archive");

        // Assert
        title = await Page.TitleAsync();
        Assert.AreEqual("archive - Google Search", title);
    }

    [UITest]
    [RestartOnException(3)]
    public async Task TestMethod76()
    {
        // Act
        await Page.OpenSearchPageAsync();

        // Assert
        var title = await Page.TitleAsync();
        Assert.AreEqual("Google", title);

        // Act
        await Page.SearchByTextAsync("wikipedia");

        // Assert
        title = await Page.TitleAsync();
        Assert.AreEqual("wikipedia - Google Search", title);

        // Arrange
        await Page.ClearSearchTextAsync();

        // Act
        await Page.SearchByTextAsync("archive");

        // Assert
        title = await Page.TitleAsync();
        Assert.AreEqual("archive - Google Search", title);
    }

    [UITest]
    [RestartOnException(3)]
    public async Task TestMethod77()
    {
        // Act
        await Page.OpenSearchPageAsync();

        // Assert
        var title = await Page.TitleAsync();
        Assert.AreEqual("Google", title);

        // Act
        await Page.SearchByTextAsync("wikipedia");

        // Assert
        title = await Page.TitleAsync();
        Assert.AreEqual("wikipedia - Google Search", title);

        // Arrange
        await Page.ClearSearchTextAsync();

        // Act
        await Page.SearchByTextAsync("archive");

        // Assert
        title = await Page.TitleAsync();
        Assert.AreEqual("archive - Google Search", title);
    }

    [UITest]
    [RestartOnException(3)]
    public async Task TestMethod78()
    {
        // Act
        await Page.OpenSearchPageAsync();

        // Assert
        var title = await Page.TitleAsync();
        Assert.AreEqual("Google", title);

        // Act
        await Page.SearchByTextAsync("wikipedia");

        // Assert
        title = await Page.TitleAsync();
        Assert.AreEqual("wikipedia - Google Search", title);

        // Arrange
        await Page.ClearSearchTextAsync();

        // Act
        await Page.SearchByTextAsync("archive");

        // Assert
        title = await Page.TitleAsync();
        Assert.AreEqual("archive - Google Search", title);
    }

    [UITest]
    [RestartOnException(3)]
    public async Task TestMethod79()
    {
        // Act
        await Page.OpenSearchPageAsync();

        // Assert
        var title = await Page.TitleAsync();
        Assert.AreEqual("Google", title);

        // Act
        await Page.SearchByTextAsync("wikipedia");

        // Assert
        title = await Page.TitleAsync();
        Assert.AreEqual("wikipedia - Google Search", title);

        // Arrange
        await Page.ClearSearchTextAsync();

        // Act
        await Page.SearchByTextAsync("archive");

        // Assert
        title = await Page.TitleAsync();
        Assert.AreEqual("archive - Google Search", title);
    }

    [UITest]
    [RestartOnException(3)]
    public async Task TestMethod80()
    {
        // Act
        await Page.OpenSearchPageAsync();

        // Assert
        var title = await Page.TitleAsync();
        Assert.AreEqual("Google", title);

        // Act
        await Page.SearchByTextAsync("wikipedia");

        // Assert
        title = await Page.TitleAsync();
        Assert.AreEqual("wikipedia - Google Search", title);

        // Arrange
        await Page.ClearSearchTextAsync();

        // Act
        await Page.SearchByTextAsync("archive");

        // Assert
        title = await Page.TitleAsync();
        Assert.AreEqual("archive - Google Search", title);
    }

    [UITest]
    [RestartOnException(3)]
    public async Task TestMethod81()
    {
        // Act
        await Page.OpenSearchPageAsync();

        // Assert
        var title = await Page.TitleAsync();
        Assert.AreEqual("Google", title);

        // Act
        await Page.SearchByTextAsync("wikipedia");

        // Assert
        title = await Page.TitleAsync();
        Assert.AreEqual("wikipedia - Google Search", title);

        // Arrange
        await Page.ClearSearchTextAsync();

        // Act
        await Page.SearchByTextAsync("archive");

        // Assert
        title = await Page.TitleAsync();
        Assert.AreEqual("archive - Google Search", title);
    }

    [UITest]
    [RestartOnException(3)]
    public async Task TestMethod82()
    {
        // Act
        await Page.OpenSearchPageAsync();

        // Assert
        var title = await Page.TitleAsync();
        Assert.AreEqual("Google", title);

        // Act
        await Page.SearchByTextAsync("wikipedia");

        // Assert
        title = await Page.TitleAsync();
        Assert.AreEqual("wikipedia - Google Search", title);

        // Arrange
        await Page.ClearSearchTextAsync();

        // Act
        await Page.SearchByTextAsync("archive");

        // Assert
        title = await Page.TitleAsync();
        Assert.AreEqual("archive - Google Search", title);
    }

    [UITest]
    [RestartOnException(3)]
    public async Task TestMethod83()
    {
        // Act
        await Page.OpenSearchPageAsync();

        // Assert
        var title = await Page.TitleAsync();
        Assert.AreEqual("Google", title);

        // Act
        await Page.SearchByTextAsync("wikipedia");

        // Assert
        title = await Page.TitleAsync();
        Assert.AreEqual("wikipedia - Google Search", title);

        // Arrange
        await Page.ClearSearchTextAsync();

        // Act
        await Page.SearchByTextAsync("archive");

        // Assert
        title = await Page.TitleAsync();
        Assert.AreEqual("archive - Google Search", title);
    }

    [UITest]
    [RestartOnException(3)]
    public async Task TestMethod84()
    {
        // Act
        await Page.OpenSearchPageAsync();

        // Assert
        var title = await Page.TitleAsync();
        Assert.AreEqual("Google", title);

        // Act
        await Page.SearchByTextAsync("wikipedia");

        // Assert
        title = await Page.TitleAsync();
        Assert.AreEqual("wikipedia - Google Search", title);

        // Arrange
        await Page.ClearSearchTextAsync();

        // Act
        await Page.SearchByTextAsync("archive");

        // Assert
        title = await Page.TitleAsync();
        Assert.AreEqual("archive - Google Search", title);
    }

    [UITest]
    [RestartOnException(3)]
    public async Task TestMethod85()
    {
        // Act
        await Page.OpenSearchPageAsync();

        // Assert
        var title = await Page.TitleAsync();
        Assert.AreEqual("Google", title);

        // Act
        await Page.SearchByTextAsync("wikipedia");

        // Assert
        title = await Page.TitleAsync();
        Assert.AreEqual("wikipedia - Google Search", title);

        // Arrange
        await Page.ClearSearchTextAsync();

        // Act
        await Page.SearchByTextAsync("archive");

        // Assert
        title = await Page.TitleAsync();
        Assert.AreEqual("archive - Google Search", title);
    }

    [UITest]
    [RestartOnException(3)]
    public async Task TestMethod86()
    {
        // Act
        await Page.OpenSearchPageAsync();

        // Assert
        var title = await Page.TitleAsync();
        Assert.AreEqual("Google", title);

        // Act
        await Page.SearchByTextAsync("wikipedia");

        // Assert
        title = await Page.TitleAsync();
        Assert.AreEqual("wikipedia - Google Search", title);

        // Arrange
        await Page.ClearSearchTextAsync();

        // Act
        await Page.SearchByTextAsync("archive");

        // Assert
        title = await Page.TitleAsync();
        Assert.AreEqual("archive - Google Search", title);
    }

    [UITest]
    [RestartOnException(3)]
    public async Task TestMethod87()
    {
        // Act
        await Page.OpenSearchPageAsync();

        // Assert
        var title = await Page.TitleAsync();
        Assert.AreEqual("Google", title);

        // Act
        await Page.SearchByTextAsync("wikipedia");

        // Assert
        title = await Page.TitleAsync();
        Assert.AreEqual("wikipedia - Google Search", title);

        // Arrange
        await Page.ClearSearchTextAsync();

        // Act
        await Page.SearchByTextAsync("archive");

        // Assert
        title = await Page.TitleAsync();
        Assert.AreEqual("archive - Google Search", title);
    }

    [UITest]
    [RestartOnException(3)]
    public async Task TestMethod88()
    {
        // Act
        await Page.OpenSearchPageAsync();

        // Assert
        var title = await Page.TitleAsync();
        Assert.AreEqual("Google", title);

        // Act
        await Page.SearchByTextAsync("wikipedia");

        // Assert
        title = await Page.TitleAsync();
        Assert.AreEqual("wikipedia - Google Search", title);

        // Arrange
        await Page.ClearSearchTextAsync();

        // Act
        await Page.SearchByTextAsync("archive");

        // Assert
        title = await Page.TitleAsync();
        Assert.AreEqual("archive - Google Search", title);
    }

    [UITest]
    [RestartOnException(3)]
    public async Task TestMethod89()
    {
        // Act
        await Page.OpenSearchPageAsync();

        // Assert
        var title = await Page.TitleAsync();
        Assert.AreEqual("Google", title);

        // Act
        await Page.SearchByTextAsync("wikipedia");

        // Assert
        title = await Page.TitleAsync();
        Assert.AreEqual("wikipedia - Google Search", title);

        // Arrange
        await Page.ClearSearchTextAsync();

        // Act
        await Page.SearchByTextAsync("archive");

        // Assert
        title = await Page.TitleAsync();
        Assert.AreEqual("archive - Google Search", title);
    }

    [UITest]
    [RestartOnException(3)]
    public async Task TestMethod90()
    {
        // Act
        await Page.OpenSearchPageAsync();

        // Assert
        var title = await Page.TitleAsync();
        Assert.AreEqual("Google", title);

        // Act
        await Page.SearchByTextAsync("wikipedia");

        // Assert
        title = await Page.TitleAsync();
        Assert.AreEqual("wikipedia - Google Search", title);

        // Arrange
        await Page.ClearSearchTextAsync();

        // Act
        await Page.SearchByTextAsync("archive");

        // Assert
        title = await Page.TitleAsync();
        Assert.AreEqual("archive - Google Search", title);
    }

    [UITest]
    [RestartOnException(3)]
    public async Task TestMethod91()
    {
        // Act
        await Page.OpenSearchPageAsync();

        // Assert
        var title = await Page.TitleAsync();
        Assert.AreEqual("Google", title);

        // Act
        await Page.SearchByTextAsync("wikipedia");

        // Assert
        title = await Page.TitleAsync();
        Assert.AreEqual("wikipedia - Google Search", title);

        // Arrange
        await Page.ClearSearchTextAsync();

        // Act
        await Page.SearchByTextAsync("archive");

        // Assert
        title = await Page.TitleAsync();
        Assert.AreEqual("archive - Google Search", title);
    }

    [UITest]
    [RestartOnException(3)]
    public async Task TestMethod92()
    {
        // Act
        await Page.OpenSearchPageAsync();

        // Assert
        var title = await Page.TitleAsync();
        Assert.AreEqual("Google", title);

        // Act
        await Page.SearchByTextAsync("wikipedia");

        // Assert
        title = await Page.TitleAsync();
        Assert.AreEqual("wikipedia - Google Search", title);

        // Arrange
        await Page.ClearSearchTextAsync();

        // Act
        await Page.SearchByTextAsync("archive");

        // Assert
        title = await Page.TitleAsync();
        Assert.AreEqual("archive - Google Search", title);
    }

    [UITest]
    [RestartOnException(3)]
    public async Task TestMethod93()
    {
        // Act
        await Page.OpenSearchPageAsync();

        // Assert
        var title = await Page.TitleAsync();
        Assert.AreEqual("Google", title);

        // Act
        await Page.SearchByTextAsync("wikipedia");

        // Assert
        title = await Page.TitleAsync();
        Assert.AreEqual("wikipedia - Google Search", title);

        // Arrange
        await Page.ClearSearchTextAsync();

        // Act
        await Page.SearchByTextAsync("archive");

        // Assert
        title = await Page.TitleAsync();
        Assert.AreEqual("archive - Google Search", title);
    }

    [UITest]
    [RestartOnException(3)]
    public async Task TestMethod94()
    {
        // Act
        await Page.OpenSearchPageAsync();

        // Assert
        var title = await Page.TitleAsync();
        Assert.AreEqual("Google", title);

        // Act
        await Page.SearchByTextAsync("wikipedia");

        // Assert
        title = await Page.TitleAsync();
        Assert.AreEqual("wikipedia - Google Search", title);

        // Arrange
        await Page.ClearSearchTextAsync();

        // Act
        await Page.SearchByTextAsync("archive");

        // Assert
        title = await Page.TitleAsync();
        Assert.AreEqual("archive - Google Search", title);
    }

    [UITest]
    [RestartOnException(3)]
    public async Task TestMethod95()
    {
        // Act
        await Page.OpenSearchPageAsync();

        // Assert
        var title = await Page.TitleAsync();
        Assert.AreEqual("Google", title);

        // Act
        await Page.SearchByTextAsync("wikipedia");

        // Assert
        title = await Page.TitleAsync();
        Assert.AreEqual("wikipedia - Google Search", title);

        // Arrange
        await Page.ClearSearchTextAsync();

        // Act
        await Page.SearchByTextAsync("archive");

        // Assert
        title = await Page.TitleAsync();
        Assert.AreEqual("archive - Google Search", title);
    }

    [UITest]
    [RestartOnException(3)]
    public async Task TestMethod96()
    {
        // Act
        await Page.OpenSearchPageAsync();

        // Assert
        var title = await Page.TitleAsync();
        Assert.AreEqual("Google", title);

        // Act
        await Page.SearchByTextAsync("wikipedia");

        // Assert
        title = await Page.TitleAsync();
        Assert.AreEqual("wikipedia - Google Search", title);

        // Arrange
        await Page.ClearSearchTextAsync();

        // Act
        await Page.SearchByTextAsync("archive");

        // Assert
        title = await Page.TitleAsync();
        Assert.AreEqual("archive - Google Search", title);
    }

    [UITest]
    [RestartOnException(3)]
    public async Task TestMethod97()
    {
        // Act
        await Page.OpenSearchPageAsync();

        // Assert
        var title = await Page.TitleAsync();
        Assert.AreEqual("Google", title);

        // Act
        await Page.SearchByTextAsync("wikipedia");

        // Assert
        title = await Page.TitleAsync();
        Assert.AreEqual("wikipedia - Google Search", title);

        // Arrange
        await Page.ClearSearchTextAsync();

        // Act
        await Page.SearchByTextAsync("archive");

        // Assert
        title = await Page.TitleAsync();
        Assert.AreEqual("archive - Google Search", title);
    }

    [UITest]
    [RestartOnException(3)]
    public async Task TestMethod98()
    {
        // Act
        await Page.OpenSearchPageAsync();

        // Assert
        var title = await Page.TitleAsync();
        Assert.AreEqual("Google", title);

        // Act
        await Page.SearchByTextAsync("wikipedia");

        // Assert
        title = await Page.TitleAsync();
        Assert.AreEqual("wikipedia - Google Search", title);

        // Arrange
        await Page.ClearSearchTextAsync();

        // Act
        await Page.SearchByTextAsync("archive");

        // Assert
        title = await Page.TitleAsync();
        Assert.AreEqual("archive - Google Search", title);
    }

    [UITest]
    [RestartOnException(3)]
    public async Task TestMethod99()
    {
        // Act
        await Page.OpenSearchPageAsync();

        // Assert
        var title = await Page.TitleAsync();
        Assert.AreEqual("Google", title);

        // Act
        await Page.SearchByTextAsync("wikipedia");

        // Assert
        title = await Page.TitleAsync();
        Assert.AreEqual("wikipedia - Google Search", title);

        // Arrange
        await Page.ClearSearchTextAsync();

        // Act
        await Page.SearchByTextAsync("archive");

        // Assert
        title = await Page.TitleAsync();
        Assert.AreEqual("archive - Google Search", title);
    }

    [UITest]
    [RestartOnException(3)]
    public async Task TestMethod100()
    {
        // Act
        await Page.OpenSearchPageAsync();

        // Assert
        var title = await Page.TitleAsync();
        Assert.AreEqual("Google", title);

        // Act
        await Page.SearchByTextAsync("wikipedia");

        // Assert
        title = await Page.TitleAsync();
        Assert.AreEqual("wikipedia - Google Search", title);

        // Arrange
        await Page.ClearSearchTextAsync();

        // Act
        await Page.SearchByTextAsync("archive");

        // Assert
        title = await Page.TitleAsync();
        Assert.AreEqual("archive - Google Search", title);
    }
}