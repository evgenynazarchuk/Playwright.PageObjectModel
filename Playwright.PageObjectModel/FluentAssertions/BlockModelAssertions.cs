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

using Playwright.PageObjectModel;
using Playwright.Synchronous;
using System;


namespace Playwright.FluentAssertions;

public static class BlockModelAssertions
{
    public static ReferenceTypeAssertion<T> Should<T>(this T blockModel)
        where T : BlockModel<PageModel>
    {
        return new ReferenceTypeAssertion<T>(blockModel);
    }

    public static TBlockModel VerifyThat<TBlockModel>(
        this TBlockModel blockModel,
        Action<TBlockModel> action)
        where TBlockModel : BlockModel<PageModel>
    {
        action(blockModel);
        return blockModel;
    }

    public static TBlockModel HaveTextContent<TBlockModel>(
        this ReferenceTypeAssertion<TBlockModel> blockModel,
        string expectedTextContent,
        string? selector = null,
        string because = "no reason given")
        where TBlockModel : BlockModel<PageModel>
    {
        var block = blockModel.Value.Block;

        if (selector is not null)
        {
            var element = block.QuerySelector(selector);
            if (element is null) throw new AssertException($"Element not found. Selector: {selector}");

            element.Should().HaveTextContent(expectedTextContent, because);
        }
        else
        {
            block.Should().HaveTextContent(expectedTextContent, because);
        }

        return blockModel.Value;
    }

    public static TBlockModel HaveNotTextContent<TBlockModel>(
        this ReferenceTypeAssertion<TBlockModel> blockModel,
        string notExpectedTextContent,
        string? selector = null,
        string because = "no reason given")
        where TBlockModel : BlockModel<PageModel>
    {
        var block = blockModel.Value.Block;

        if (selector is not null)
        {
            var element = block.QuerySelector(selector);
            if (element is null) throw new AssertException($"Element not found. Selector {selector}");

            element.Should().HaveNotTextContent(notExpectedTextContent, because);
        }
        else
        {
            block.Should().HaveNotTextContent(notExpectedTextContent, because);
        }

        return blockModel.Value;
    }

    public static TBlockModel HaveInnerHTML<TBlockModel>(
        this ReferenceTypeAssertion<TBlockModel> blockModel,
        string expectedInnerHtml,
        string? selector = null,
        string because = "no reason given")
        where TBlockModel : BlockModel<PageModel>
    {
        var block = blockModel.Value.Block;

        if (selector is not null)
        {
            var element = block.QuerySelector(selector);
            if (element is null) throw new AssertException($"Element not found. Selector {selector}");

            element.Should().HaveInnerHTML(expectedInnerHtml, because);
        }
        else
        {
            block.Should().HaveInnerHTML(expectedInnerHtml, because);
        }

        return blockModel.Value;
    }

    public static TBlockModel HaveNotInnerHTML<TBlockModel>(
        this ReferenceTypeAssertion<TBlockModel> blockModel,
        string notExpectedInnerHtml,
        string? selector = null,
        string because = "no reason given")
        where TBlockModel : BlockModel<PageModel>
    {
        var block = blockModel.Value.Block;

        if (selector is not null)
        {
            var element = block.QuerySelector(selector);
            if (element is null) throw new AssertException($"Element not found. Selector {selector}");

            element.Should().HaveNotInnerHTML(notExpectedInnerHtml, because);
        }
        else
        {
            block.Should().HaveNotInnerHTML(notExpectedInnerHtml, because);
        }

        return blockModel.Value;
    }

    public static TBlockModel HaveInnerText<TBlockModel>(
        this ReferenceTypeAssertion<TBlockModel> blockModel,
        string expectedInnerText,
        string? selector = null,
        string because = "no reason given")
        where TBlockModel : BlockModel<PageModel>
    {
        var block = blockModel.Value.Block;

        if (selector is not null)
        {
            var element = block.QuerySelector(selector);
            if (element is null) throw new AssertException($"Element not found. Selector {selector}");

            element.Should().HaveInnerText(expectedInnerText, because);
        }
        else
        {
            block.Should().HaveInnerText(expectedInnerText, because);
        }

        return blockModel.Value;
    }

    public static TBlockModel HaveNotInnerText<TBlockModel>(
        this ReferenceTypeAssertion<TBlockModel> blockModel,
        string notExpectedInnerText,
        string? selector = null,
        string because = "no reason given")
        where TBlockModel : BlockModel<PageModel>
    {
        var block = blockModel.Value.Block;

        if (selector is not null)
        {
            var element = block.QuerySelector(selector);
            if (element is null) throw new AssertException($"Element not found. Selector {selector}");

            element.Should().HaveNotInnerText(notExpectedInnerText, because);
        }
        else
        {
            block.Should().HaveNotInnerText(notExpectedInnerText, because);
        }

        return blockModel.Value;
    }

    public static TBlockModel HaveInputValue<TBlockModel>(
        this ReferenceTypeAssertion<TBlockModel> blockModel,
        string expectedInputValue,
        string? selector = null,
        string because = "no reason given")
        where TBlockModel : BlockModel<PageModel>
    {
        var block = blockModel.Value.Block;

        if (selector is not null)
        {
            var element = block.QuerySelector(selector);
            if (element is null) throw new AssertException($"Element not found. Selector {selector}");

            element.Should().HaveInputValue(expectedInputValue, because);
        }
        else
        {
            block.Should().HaveInputValue(expectedInputValue, because);
        }

        return blockModel.Value;
    }

    public static TBlockModel HaveNotInputValue<TBlockModel>(
        this ReferenceTypeAssertion<TBlockModel> blockModel,
        string notExpectedInputValue,
        string? selector = null,
        string because = "no reason given")
        where TBlockModel : BlockModel<PageModel>
    {
        var block = blockModel.Value.Block;

        if (selector is not null)
        {
            var element = block.QuerySelector(selector);
            if (element is null) throw new AssertException($"Element not found. Selector {selector}");

            element.Should().HaveNotInputValue(notExpectedInputValue, because);
        }
        else
        {
            block.Should().HaveNotInputValue(notExpectedInputValue, because);
        }

        return blockModel.Value;
    }

    public static TBlockModel HaveChecked<TBlockModel>(
        this ReferenceTypeAssertion<TBlockModel> blockModel,
        string? selector = null,
        string because = "no reason given")
        where TBlockModel : BlockModel<PageModel>
    {
        var block = blockModel.Value.Block;

        if (selector is not null)
        {
            var element = block.QuerySelector(selector);
            if (element is null) throw new ApplicationException($"Element not found. Selector {selector}");

            element.Should().BeChecked(because);
        }
        else
        {
            block.Should().BeChecked(because);
        }

        return blockModel.Value;
    }

    public static TBlockModel HaveNotChecked<TBlockModel>(
        this ReferenceTypeAssertion<TBlockModel> blockModel,
        string? selector = null,
        string because = "no reason given")
        where TBlockModel : BlockModel<PageModel>
    {
        var block = blockModel.Value.Block;

        if (selector is not null)
        {
            var element = block.QuerySelector(selector);
            if (element is null) throw new ApplicationException($"Element not found. Selector {selector}");

            element.Should().BeNotChecked(because);
        }
        else
        {
            block.Should().BeNotChecked(because);
        }

        return blockModel.Value;
    }

    public static TBlockModel HaveDisabled<TBlockModel>(
        this ReferenceTypeAssertion<TBlockModel> blockModel,
        string? selector = null,
        string because = "no reason given")
        where TBlockModel : BlockModel<PageModel>
    {
        var block = blockModel.Value.Block;

        if (selector is not null)
        {
            var element = blockModel.Value.Block.QuerySelector(selector);
            if (element is null) throw new ApplicationException($"Element not found. Selector {selector}");

            element.Should().BeDisabled(because);
        }
        else
        {
            block.Should().BeDisabled(because);
        }

        return blockModel.Value;
    }

    public static TBlockModel HaveNotDisabled<TBlockModel>(
        this ReferenceTypeAssertion<TBlockModel> blockModel,
        string? selector = null,
        string because = "no reason given")
        where TBlockModel : BlockModel<PageModel>
    {
        var block = blockModel.Value.Block;

        if (selector is not null)
        {
            var element = block.QuerySelector(selector);
            if (element is null) throw new ApplicationException($"Element not found. Selector {selector}");

            element.Should().BeNotDisabled(because);
        }
        else
        {
            block.Should().BeNotDisabled(because);
        }

        return blockModel.Value;
    }

    public static TBlockModel HaveEditable<TBlockModel>(
        this ReferenceTypeAssertion<TBlockModel> blockModel,
        string? selector = null,
        string because = "no reason given")
        where TBlockModel : BlockModel<PageModel>
    {
        var block = blockModel.Value.Block;

        if (selector is not null)
        {
            var element = block.QuerySelector(selector);
            if (element is null) throw new ApplicationException($"Element not found. Selector {selector}");

            element.Should().BeEditable(because);
        }
        else
        {
            block.Should().BeEditable(because);
        }

        return blockModel.Value;
    }

    public static TBlockModel HaveNotEditable<TBlockModel>(
        this ReferenceTypeAssertion<TBlockModel> blockModel,
        string? selector = null,
        string because = "no reason given")
        where TBlockModel : BlockModel<PageModel>
    {
        var block = blockModel.Value.Block;

        if (selector is not null)
        {
            var element = block.QuerySelector(selector);
            if (element is null) throw new ApplicationException($"Element not found. Selector {selector}");

            element.Should().BeNotEditable(because);
        }
        else
        {
            block.Should().BeNotEditable(because);
        }

        return blockModel.Value;
    }

    public static TBlockModel HaveEnabled<TBlockModel>(
        this ReferenceTypeAssertion<TBlockModel> blockModel,
        string? selector = null,
        string because = "no reason given")
        where TBlockModel : BlockModel<PageModel>
    {
        var block = blockModel.Value.Block;

        if (selector is not null)
        {
            var element = blockModel.Value.Block.QuerySelector(selector);
            if (element is null) throw new ApplicationException($"Element not found. Selector {selector}");

            block.Should().BeEnabled(because);
        }
        else
        {
            block.Should().BeEnabled(because);
        }

        return blockModel.Value;
    }

    public static TBlockModel HaveNotEnabled<TBlockModel>(
        this ReferenceTypeAssertion<TBlockModel> blockModel,
        string? selector = null,
        string because = "no reason given")
        where TBlockModel : BlockModel<PageModel>
    {
        var block = blockModel.Value.Block;

        if (selector is not null)
        {
            var element = blockModel.Value.Block.QuerySelector(selector);
            if (element is null) throw new ApplicationException($"Element not found. Selector {selector}");

            block.Should().BeNotEnabled(because);
        }
        else
        {
            block.Should().BeNotEnabled(because);
        }

        return blockModel.Value;
    }

    public static TBlockModel HaveHidden<TBlockModel>(
        this ReferenceTypeAssertion<TBlockModel> blockModel,
        string? selector = null,
        string because = "no reason given")
        where TBlockModel : BlockModel<PageModel>
    {
        var block = blockModel.Value.Block;

        if (selector is not null)
        {
            var element = blockModel.Value.Block.QuerySelector(selector);
            if (element is null) throw new ApplicationException($"Element not found. Selector {selector}");

            element.Should().BeHidden(because);
        }
        else
        {
            block.Should().BeHidden(because);
        }

        return blockModel.Value;
    }

    public static TBlockModel HaveNotHidden<TBlockModel>(
        this ReferenceTypeAssertion<TBlockModel> blockModel,
        string? selector = null,
        string because = "no reason given")
        where TBlockModel : BlockModel<PageModel>
    {
        var block = blockModel.Value.Block;

        if (selector is not null)
        {
            var element = blockModel.Value.Block.QuerySelector(selector);
            if (element is null) throw new ApplicationException($"Element not found. Selector {selector}");

            element.Should().BeNotHidden(because);
        }
        else
        {
            block.Should().BeNotHidden(because);
        }

        return blockModel.Value;
    }

    public static TBlockModel HaveVisible<TBlockModel>(
        this ReferenceTypeAssertion<TBlockModel> blockModel,
        string? selector = null,
        string because = "no reason given")
        where TBlockModel : BlockModel<PageModel>
    {
        var block = blockModel.Value.Block;

        if (selector is not null)
        {
            var element = blockModel.Value.Block.QuerySelector(selector);
            if (element is null) throw new ApplicationException($"Element not found. Selector {selector}");

            element.Should().BeVisible(because);
        }
        else
        {
            block.Should().BeVisible(because);
        }

        return blockModel.Value;
    }

    public static TBlockModel HaveNotVisible<TBlockModel>(
        this ReferenceTypeAssertion<TBlockModel> blockModel,
        string? selector = null,
        string because = "no reason given")
        where TBlockModel : BlockModel<PageModel>
    {
        var block = blockModel.Value.Block;

        if (selector is not null)
        {
            var element = blockModel.Value.Block.QuerySelector(selector);
            if (element is null) throw new ApplicationException($"Element not found. Selector {selector}");

            element.Should().BeNotVisible(because);
        }
        else
        {
            block.Should().BeNotVisible(because);
        }

        return blockModel.Value;
    }

    public static TBlockModel HaveAttribute<TBlockModel>(
        this ReferenceTypeAssertion<TBlockModel> blockModel,
        string attributeName,
        string? selector = null,
        string because = "no reason given")
        where TBlockModel : BlockModel<PageModel>
    {
        var block = blockModel.Value.Block;

        if (selector is not null)
        {
            var element = block.QuerySelector(selector);
            if (element is null) throw new AssertException($@"Element not found. Selector {selector}");

            element.Should().HaveAttribute(attributeName, because);
        }
        else
        {
            block.Should().HaveAttribute(attributeName, because);
        }

        return blockModel.Value;
    }

    public static TBlockModel HaveNotAttribute<TBlockModel>(
        this ReferenceTypeAssertion<TBlockModel> blockModel,
        string attributeName,
        string? selector = null,
        string because = "no reason given")
        where TBlockModel : BlockModel<PageModel>
    {
        var block = blockModel.Value.Block;

        if (selector is not null)
        {
            var element = block.QuerySelector(selector);
            if (element is null) throw new AssertException($@"Element not found. Selector {selector}");

            element.Should().HaveNotAttribute(attributeName, because);
        }
        else
        {
            block.Should().HaveNotAttribute(attributeName, because);
        }

        return blockModel.Value;
    }

    public static TBlockModel HaveAttributeValue<TBlockModel>(
        this ReferenceTypeAssertion<TBlockModel> blockModel,
        string attributeName,
        string value,
        string? selector = null,
        string because = "no reason given")
        where TBlockModel : BlockModel<PageModel>
    {
        var block = blockModel.Value.Block;

        if (selector is not null)
        {
            var element = block.QuerySelector(selector);
            if (element is null) throw new AssertException($@"Element not found. Selector {selector}");

            element.Should().HaveAttributeValue(attributeName, value, because);
        }
        else
        {
            block.Should().HaveAttributeValue(attributeName, value, because);
        }

        return blockModel.Value;
    }

    public static TBlockModel HaveComputedStyle<TBlockModel>(
        this ReferenceTypeAssertion<TBlockModel> blockModel,
        string styleName,
        string expectedStyleValue,
        string? selector = null,
        string because = "no reason given")
        where TBlockModel : BlockModel<PageModel>
    {
        var block = blockModel.Value.Block;

        if (selector is not null)
        {
            var element = block.QuerySelector(selector);
            if (element is null) throw new AssertException($"Element not found. Selector: {selector}");

            element.Should().HaveComputedStyle(styleName, expectedStyleValue, because);
        }
        else
        {
            block.Should().HaveComputedStyle(styleName, expectedStyleValue, because);
        }

        return blockModel.Value;
    }
}
