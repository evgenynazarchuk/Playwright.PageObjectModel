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

using Microsoft.Playwright;
using Playwright.PageObjectModel;
using Playwright.Synchronous;
using System;

namespace Playwright.FluentAssertions;

public static class ElementModelAssertions
{
    public static ReferenceTypeAssertion<TElementModel> Should<TElementModel>(this TElementModel elementModel)
        where TElementModel : IElementModel
    {
        return new ReferenceTypeAssertion<TElementModel>(elementModel);
    }

    public static TElementModel VerifyThat<TElementModel>(this TElementModel elementModel, Action<TElementModel> action)
        where TElementModel : IElementModel
    {
        action(elementModel);
        return elementModel;
    }

    public static TElementModel HaveTextContent<TElementModel>(
        this ReferenceTypeAssertion<TElementModel> elementModel,
        string expectedTextContent,
        string? selector = null,
        string because = "no reason given",
        ElementHandleWaitForSelectorOptions? waitOptions = null)
        where TElementModel : IElementModel
    {
        var block = elementModel.Value.Element;

        if(selector is not null) block.WaitForSelector(selector, waitOptions);
        var element = selector is null ? block : block.QuerySelector(selector)!;

        element.Should().HaveTextContent(expectedTextContent, because);
        return elementModel.Value;
    }

    public static TElementModel HaveNotTextContent<TElementModel>(
        this ReferenceTypeAssertion<TElementModel> elementModel,
        string notExpectedTextContent,
        string? selector = null,
        string because = "no reason given",
        ElementHandleWaitForSelectorOptions? waitOptions = null)
        where TElementModel : IElementModel
    {
        var block = elementModel.Value.Element;

        if (selector is not null) block.WaitForSelector(selector, waitOptions);
        var element = selector is null ? block : block.QuerySelector(selector)!;

        element.Should().HaveNotTextContent(notExpectedTextContent, because);
        return elementModel.Value;
    }

    public static TElementModel HaveInnerHTML<TElementModel>(
        this ReferenceTypeAssertion<TElementModel> elementModel,
        string expectedInnerHtml,
        string? selector = null,
        string because = "no reason given",
        ElementHandleWaitForSelectorOptions? waitOptions = null)
        where TElementModel : IElementModel
    {
        var block = elementModel.Value.Element;

        if (selector is not null) block.WaitForSelector(selector, waitOptions);
        var element = selector is null ? block : block.QuerySelector(selector)!;

        element.Should().HaveInnerHTML(expectedInnerHtml, because);
        return elementModel.Value;
    }

    public static TElementModel HaveNotInnerHTML<TElementModel>(
        this ReferenceTypeAssertion<TElementModel> elementModel,
        string notExpectedInnerHtml,
        string? selector = null,
        string because = "no reason given",
        ElementHandleWaitForSelectorOptions? waitOptions = null)
        where TElementModel : IElementModel
    {
        var block = elementModel.Value.Element;

        if (selector is not null) block.WaitForSelector(selector, waitOptions);
        var element = selector is null ? block : block.QuerySelector(selector)!;

        element.Should().HaveNotInnerHTML(notExpectedInnerHtml, because);
        return elementModel.Value;
    }

    public static TElementModel HaveInnerText<TElementModel>(
        this ReferenceTypeAssertion<TElementModel> elementModel,
        string expectedInnerText,
        string? selector = null,
        string because = "no reason given",
        ElementHandleWaitForSelectorOptions? waitOptions = null)
        where TElementModel : IElementModel
    {
        var block = elementModel.Value.Element;

        if (selector is not null) block.WaitForSelector(selector, waitOptions);
        var element = selector is null ? block : block.QuerySelector(selector)!;

        element.Should().HaveInnerText(expectedInnerText, because);
        return elementModel.Value;
    }

    public static TElementModel HaveNotInnerText<TElementModel>(
        this ReferenceTypeAssertion<TElementModel> elementModel,
        string notExpectedInnerText,
        string? selector = null,
        string because = "no reason given",
        ElementHandleWaitForSelectorOptions? waitOptions = null)
        where TElementModel : IElementModel
    {
        var block = elementModel.Value.Element;

        if (selector is not null) block.WaitForSelector(selector, waitOptions);
        var element = selector is null ? block : block.QuerySelector(selector)!;

        element.Should().HaveNotInnerText(notExpectedInnerText, because);
        return elementModel.Value;
    }

    public static TElementModel HaveInputValue<TElementModel>(
        this ReferenceTypeAssertion<TElementModel> elementModel,
        string expectedInputValue,
        string? selector = null,
        string because = "no reason given",
        ElementHandleWaitForSelectorOptions? waitOptions = null)
        where TElementModel : IElementModel
    {
        var block = elementModel.Value.Element;

        if (selector is not null) block.WaitForSelector(selector, waitOptions);
        var element = selector is null ? block : block.QuerySelector(selector)!;

        element.Should().HaveInputValue(expectedInputValue, because);
        return elementModel.Value;
    }

    public static TElementModel HaveNotInputValue<TElementModel>(
        this ReferenceTypeAssertion<TElementModel> elementModel,
        string notExpectedInputValue,
        string? selector = null,
        string because = "no reason given",
        ElementHandleWaitForSelectorOptions? waitOptions = null)
        where TElementModel : IElementModel
    {
        var block = elementModel.Value.Element;

        if (selector is not null) block.WaitForSelector(selector, waitOptions);
        var element = selector is null ? block : block.QuerySelector(selector)!;

        element.Should().HaveNotInputValue(notExpectedInputValue, because);
        return elementModel.Value;
    }

    public static TElementModel HaveChecked<TElementModel>(
        this ReferenceTypeAssertion<TElementModel> elementModel,
        string? selector = null,
        string because = "no reason given",
        ElementHandleWaitForSelectorOptions? waitOptions = null)
        where TElementModel : IElementModel
    {
        var block = elementModel.Value.Element;

        if (selector is not null) block.WaitForSelector(selector, waitOptions);
        var element = selector is null ? block : block.QuerySelector(selector)!;

        element.Should().BeChecked(because);
        return elementModel.Value;
    }

    public static TElementModel HaveNotChecked<TElementModel>(
        this ReferenceTypeAssertion<TElementModel> elementModel,
        string? selector = null,
        string because = "no reason given",
        ElementHandleWaitForSelectorOptions? waitOptions = null)
        where TElementModel : IElementModel
    {
        var block = elementModel.Value.Element;

        if (selector is not null) block.WaitForSelector(selector, waitOptions);
        var element = selector is null ? block : block.QuerySelector(selector)!;

        element.Should().BeNotChecked(because);
        return elementModel.Value;
    }

    public static TElementModel HaveDisabled<TElementModel>(
        this ReferenceTypeAssertion<TElementModel> elementModel,
        string? selector = null,
        string because = "no reason given",
        ElementHandleWaitForSelectorOptions? waitOptions = null)
        where TElementModel : IElementModel
    {
        var block = elementModel.Value.Element;

        if (selector is not null) block.WaitForSelector(selector, waitOptions);
        var element = selector is null ? block : block.QuerySelector(selector)!;

        element.Should().BeDisabled(because);
        return elementModel.Value;
    }

    public static TElementModel HaveNotDisabled<TElementModel>(
        this ReferenceTypeAssertion<TElementModel> elementModel,
        string? selector = null,
        string because = "no reason given",
        ElementHandleWaitForSelectorOptions? waitOptions = null)
        where TElementModel : IElementModel
    {
        var block = elementModel.Value.Element;

        if (selector is not null) block.WaitForSelector(selector, waitOptions);
        var element = selector is null ? block : block.QuerySelector(selector)!;

        element.Should().BeNotDisabled(because);
        return elementModel.Value;
    }

    public static TElementModel HaveEditable<TElementModel>(
        this ReferenceTypeAssertion<TElementModel> elementModel,
        string? selector = null,
        string because = "no reason given",
        ElementHandleWaitForSelectorOptions? waitOptions = null)
        where TElementModel : IElementModel
    {
        var block = elementModel.Value.Element;

        if (selector is not null) block.WaitForSelector(selector, waitOptions);
        var element = selector is null ? block : block.QuerySelector(selector)!;

        element.Should().BeEditable(because);
        return elementModel.Value;
    }

    public static TElementModel HaveNotEditable<TElementModel>(
        this ReferenceTypeAssertion<TElementModel> elementModel,
        string? selector = null,
        string because = "no reason given",
        ElementHandleWaitForSelectorOptions? waitOptions = null)
        where TElementModel : IElementModel
    {
        var block = elementModel.Value.Element;

        if (selector is not null) block.WaitForSelector(selector, waitOptions);
        var element = selector is null ? block : block.QuerySelector(selector)!;

        element.Should().BeNotEditable(because);
        return elementModel.Value;
    }

    public static TElementModel HaveEnabled<TElementModel>(
        this ReferenceTypeAssertion<TElementModel> elementModel,
        string? selector = null,
        string because = "no reason given",
        ElementHandleWaitForSelectorOptions? waitOptions = null)
        where TElementModel : IElementModel
    {
        var block = elementModel.Value.Element;

        if (selector is not null) block.WaitForSelector(selector, waitOptions);
        var element = selector is null ? block : block.QuerySelector(selector)!;

        element.Should().BeEnabled(because);
        return elementModel.Value;
    }

    public static TElementModel HaveNotEnabled<TElementModel>(
        this ReferenceTypeAssertion<TElementModel> elementModel,
        string? selector = null,
        string because = "no reason given",
        ElementHandleWaitForSelectorOptions? waitOptions = null)
        where TElementModel : IElementModel
    {
        var block = elementModel.Value.Element;

        if (selector is not null) block.WaitForSelector(selector, waitOptions);
        var element = selector is null ? block : block.QuerySelector(selector)!;

        element.Should().BeNotEnabled(because);
        return elementModel.Value;
    }

    public static TElementModel HaveHidden<TElementModel>(
        this ReferenceTypeAssertion<TElementModel> elementModel,
        string? selector = null,
        string because = "no reason given",
        ElementHandleWaitForSelectorOptions? waitOptions = null)
        where TElementModel : IElementModel
    {
        var block = elementModel.Value.Element;

        if (selector is not null) block.WaitForSelector(selector, waitOptions);
        var element = selector is null ? block : block.QuerySelector(selector)!;

        element.Should().BeHidden(because);
        return elementModel.Value;
    }

    public static TElementModel HaveNotHidden<TElementModel>(
        this ReferenceTypeAssertion<TElementModel> elementModel,
        string? selector = null,
        string because = "no reason given",
        ElementHandleWaitForSelectorOptions? waitOptions = null)
        where TElementModel : IElementModel
    {
        var block = elementModel.Value.Element;

        if (selector is not null) block.WaitForSelector(selector, waitOptions);
        var element = selector is null ? block : block.QuerySelector(selector)!;

        element.Should().BeNotHidden(because);
        return elementModel.Value;
    }

    public static TElementModel HaveVisible<TElementModel>(
        this ReferenceTypeAssertion<TElementModel> elementModel,
        string? selector = null,
        string because = "no reason given",
        ElementHandleWaitForSelectorOptions? waitOptions = null)
        where TElementModel : IElementModel
    {
        var block = elementModel.Value.Element;

        if (selector is not null) block.WaitForSelector(selector, waitOptions);
        var element = selector is null ? block : block.QuerySelector(selector)!;

        element.Should().BeVisible(because);
        return elementModel.Value;
    }

    public static TElementModel HaveNotVisible<TElementModel>(
        this ReferenceTypeAssertion<TElementModel> elementModel,
        string? selector = null,
        string because = "no reason given",
        ElementHandleWaitForSelectorOptions? waitOptions = null)
        where TElementModel : IElementModel
    {
        var block = elementModel.Value.Element;

        if (selector is not null) block.WaitForSelector(selector, waitOptions);
        var element = selector is null ? block : block.QuerySelector(selector)!;

        element.Should().BeNotVisible(because);
        return elementModel.Value;
    }

    public static TElementModel HaveAttribute<TElementModel>(
        this ReferenceTypeAssertion<TElementModel> elementModel,
        string attributeName,
        string? selector = null,
        string because = "no reason given",
        ElementHandleWaitForSelectorOptions? waitOptions = null)
        where TElementModel : IElementModel
    {
        var block = elementModel.Value.Element;

        if (selector is not null) block.WaitForSelector(selector, waitOptions);
        var element = selector is null ? block : block.QuerySelector(selector)!;

        element.Should().HaveAttribute(attributeName, because);
        return elementModel.Value;
    }

    public static TElementModel HaveNotAttribute<TElementModel>(
        this ReferenceTypeAssertion<TElementModel> elementModel,
        string attributeName,
        string? selector = null,
        string because = "no reason given",
        ElementHandleWaitForSelectorOptions? waitOptions = null)
        where TElementModel : IElementModel
    {
        var block = elementModel.Value.Element;

        if (selector is not null) block.WaitForSelector(selector, waitOptions);
        var element = selector is null ? block : block.QuerySelector(selector)!;

        element.Should().HaveNotAttribute(attributeName, because);
        return elementModel.Value;
    }

    public static TElementModel HaveAttributeValue<TElementModel>(
        this ReferenceTypeAssertion<TElementModel> elementModel,
        string attributeName,
        string value,
        string? selector = null,
        string because = "no reason given",
        ElementHandleWaitForSelectorOptions? waitOptions = null)
        where TElementModel : IElementModel
    {
        var block = elementModel.Value.Element;

        if (selector is not null) block.WaitForSelector(selector, waitOptions);
        var element = selector is null ? block : block.QuerySelector(selector)!;

        element.Should().HaveAttributeValue(attributeName, value, because);
        return elementModel.Value;
    }

    public static TElementModel HaveComputedStyle<TElementModel>(
        this ReferenceTypeAssertion<TElementModel> elementModel,
        string styleName,
        string expectedStyleValue,
        string? selector = null,
        string because = "no reason given",
        ElementHandleWaitForSelectorOptions? waitOptions = null)
        where TElementModel : IElementModel
    {
        var block = elementModel.Value.Element;

        if (selector is not null) block.WaitForSelector(selector, waitOptions);
        var element = selector is null ? block : block.QuerySelector(selector)!;

        element.Should().HaveComputedStyle(styleName, expectedStyleValue, because);
        return elementModel.Value;
    }
}
