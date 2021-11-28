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
using Playwright.Synchronous;
using Playwright.PageObjectModel;
using System;
using System.Text.RegularExpressions;

namespace Playwright.FluentAssertions;

public static partial class PageModelAssertions
{
    public static ReferenceTypeAssertion<T> Should<T>(this T pageModel)
        where T : PageModel
    {
        return new ReferenceTypeAssertion<T>(pageModel);
    }

    public static TPageModel VerifyThat<TPageModel>(
        this TPageModel pageModel,
        Action<TPageModel> action)
        where TPageModel : PageModel
    {
        action(pageModel);
        return pageModel;
    }

    public static TPageModel HaveTitle<TPageModel>(
        this ReferenceTypeAssertion<TPageModel> pageModel,
        string pattern,
        string because = "no reason given")
        where TPageModel : PageModel
    {
        pageModel.Value.Page.Should().HaveTitle(pattern, because);
        return pageModel.Value;
    }

    public static TPageModel HaveNotTitle<TPageModel>(
        this ReferenceTypeAssertion<TPageModel> pageModel,
        string pattern,
        string because = "no reason given")
        where TPageModel : PageModel
    {
        pageModel.Value.Page.Should().HaveNotTitle(pattern, because);
        return pageModel.Value;
    }

    public static TPageModel HaveContent<TPageModel>(
        this ReferenceTypeAssertion<TPageModel> pageModel,
        string pattern,
        string because = "no reason given")
        where TPageModel : PageModel
    {
        pageModel.Value.Page.Should().HaveContent(pattern, because);
        return pageModel.Value;
    }

    public static TPageModel HaveNotContent<TPageModel>(
        this ReferenceTypeAssertion<TPageModel> pageModel,
        string pattern,
        string because = "no reason given")
        where TPageModel : PageModel
    {
        pageModel.Value.Page.Should().HaveNotContent(pattern, because);
        return pageModel.Value;
    }

    public static TPageModel HaveElementTextContent<TPageModel>(
        this ReferenceTypeAssertion<TPageModel> pageModel,
        string selector,
        string pattern,
        string because = "no reason given",
        PageQuerySelectorOptions? options = null)
        where TPageModel : PageModel
    {
        pageModel.Value.Page.Should().HaveElementTextContent(selector, pattern, because, options);
        return pageModel.Value;
    }

    public static TPageModel HaveNotElementTextContent<TPageModel>(
        this ReferenceTypeAssertion<TPageModel> pageModel,
        string selector,
        string pattern,
        string because = "no reason given",
        PageQuerySelectorOptions? options = null)
        where TPageModel : PageModel
    {
        pageModel.Value.Page.Should().HaveNotElementTextContent(selector, pattern, because, options);
        return pageModel.Value;
    }

    public static TPageModel HaveElementInnerHTML<TPageModel>(
        this ReferenceTypeAssertion<TPageModel> pageModel,
        string selector,
        string pattern,
        string because = "no reason given",
        PageQuerySelectorOptions? options = null)
        where TPageModel : PageModel
    {
        pageModel.Value.Page.Should().HaveElementInnerHTML(selector, pattern, because, options);
        return pageModel.Value;
    }

    public static TPageModel HaveNotElementInnerHTML<TPageModel>(
        this ReferenceTypeAssertion<TPageModel> pageModel,
        string selector,
        string pattern,
        string because = "no reason given",
        PageQuerySelectorOptions? options = null)
        where TPageModel : PageModel
    {
        pageModel.Value.Page.Should().HaveNotElementInnerHTML(selector, pattern, because, options);
        return pageModel.Value;
    }

    public static TPageModel HaveElementInnerText<TPageModel>(
        this ReferenceTypeAssertion<TPageModel> pageModel,
        string selector,
        string pattern,
        string because = "no reason given",
        PageQuerySelectorOptions? options = null)
        where TPageModel : PageModel
    {
        pageModel.Value.Page.Should().HaveElementInnerText(selector, pattern, because, options);
        return pageModel.Value;
    }

    public static TPageModel HaveNotElementInnerText<TPageModel>(
        this ReferenceTypeAssertion<TPageModel> pageModel,
        string selector,
        string pattern,
        string because = "no reason given",
        PageQuerySelectorOptions? options = null)
        where TPageModel : PageModel
    {
        pageModel.Value.Page.Should().HaveNotElementInnerText(selector, pattern, because, options);
        return pageModel.Value;
    }

    public static TPageModel HaveElementInputValue<TPageModel>(
        this ReferenceTypeAssertion<TPageModel> pageModel,
        string selector,
        string pattern,
        string because = "no reason given",
        PageQuerySelectorOptions? options = null)
        where TPageModel : PageModel
    {
        pageModel.Value.Page.Should().HaveElementInputValue(selector, pattern, because, options);
        return pageModel.Value;
    }

    public static TPageModel HaveNotElementInputValue<TPageModel>(
        this ReferenceTypeAssertion<TPageModel> pageModel,
        string selector,
        string pattern,
        string because = "no reason given",
        PageQuerySelectorOptions? options = null)
        where TPageModel : PageModel
    {
        pageModel.Value.Page.Should().HaveNotElementInputValue(selector, pattern, because, options);
        return pageModel.Value;
    }

    public static TPageModel HaveCheckedElement<TPageModel>(
        this ReferenceTypeAssertion<TPageModel> pageModel,
        string selector,
        string because = "no reason given",
        PageQuerySelectorOptions? options = null)
        where TPageModel : PageModel
    {
        pageModel.Value.Page.Should().HaveCheckedElement(selector, because, options);
        return pageModel.Value;
    }

    public static TPageModel HaveNotCheckedElement<TPageModel>(
        this ReferenceTypeAssertion<TPageModel> pageModel,
        string selector,
        string because = "no reason given",
        PageQuerySelectorOptions? options = null)
        where TPageModel : PageModel
    {
        pageModel.Value.Page.Should().HaveNotCheckedElement(selector, because, options);
        return pageModel.Value;
    }

    public static TPageModel HaveDisabledElement<TPageModel>(
        this ReferenceTypeAssertion<TPageModel> pageModel,
        string selector,
        string because = "no reason given",
        PageQuerySelectorOptions? options = null)
        where TPageModel : PageModel
    {
        pageModel.Value.Page.Should().HaveDisabledElement(selector, because, options);
        return pageModel.Value;
    }

    public static TPageModel HaveNotDisabledElement<TPageModel>(
        this ReferenceTypeAssertion<TPageModel> pageModel,
        string selector,
        string because = "no reason given",
        PageQuerySelectorOptions? options = null)
        where TPageModel : PageModel
    {
        pageModel.Value.Page.Should().HaveNotDisabledElement(selector, because, options);
        return pageModel.Value;
    }

    public static TPageModel HaveEditableElement<TPageModel>(
        this ReferenceTypeAssertion<TPageModel> pageModel,
        string selector,
        string because = "no reason given",
        PageQuerySelectorOptions? options = null)
        where TPageModel : PageModel
    {
        pageModel.Value.Page.Should().HaveEditableElement(selector, because, options);
        return pageModel.Value;
    }

    public static TPageModel HaveNotEditableElement<TPageModel>(
        this ReferenceTypeAssertion<TPageModel> pageModel,
        string selector,
        string because = "no reason given",
        PageQuerySelectorOptions? options = null)
        where TPageModel : PageModel
    {
        pageModel.Value.Page.Should().HaveNotEditableElement(selector, because, options);
        return pageModel.Value;
    }

    public static TPageModel HaveEnabledElement<TPageModel>(
        this ReferenceTypeAssertion<TPageModel> pageModel,
        string selector,
        string because = "no reason given",
        PageQuerySelectorOptions? options = null)
        where TPageModel : PageModel
    {
        pageModel.Value.Page.Should().HaveEnabledElement(selector, because, options);
        return pageModel.Value;
    }

    public static TPageModel HaveNotEnabledElement<TPageModel>(
        this ReferenceTypeAssertion<TPageModel> pageModel,
        string selector,
        string because = "no reason given",
        PageQuerySelectorOptions? options = null)
        where TPageModel : PageModel
    {
        pageModel.Value.Should().HaveNotEnabledElement(selector, because, options);
        return pageModel.Value;
    }

    public static TPageModel HaveHiddenElement<TPageModel>(
        this ReferenceTypeAssertion<TPageModel> pageModel,
        string selector,
        string because = "no reason given",
        PageQuerySelectorOptions? options = null)
        where TPageModel : PageModel
    {
        pageModel.Value.Page.Should().HaveHiddenElement(selector, because, options);
        return pageModel.Value;
    }

    public static TPageModel HaveNotHiddenElement<TPageModel>(
        this ReferenceTypeAssertion<TPageModel> pageModel,
        string selector,
        string because = "no reason given",
        PageQuerySelectorOptions? options = null)
        where TPageModel : PageModel
    {
        pageModel.Value.Page.Should().HaveNotHiddenElement(selector, because, options);
        return pageModel.Value;
    }

    public static TPageModel HaveVisibleElement<TPageModel>(
        this ReferenceTypeAssertion<TPageModel> pageModel,
        string selector,
        string because = "no reason given",
        PageQuerySelectorOptions? options = null)
        where TPageModel : PageModel
    {
        pageModel.Value.Page.Should().HaveVisibleElement(selector, because, options);
        return pageModel.Value;
    }

    public static TPageModel HaveNotVisibleElement<TPageModel>(
        this ReferenceTypeAssertion<TPageModel> pageModel,
        string selector,
        string because = "no reason given",
        PageQuerySelectorOptions? options = null)
        where TPageModel : PageModel
    {
        pageModel.Value.Page.Should().HaveNotVisibleElement(selector, because, options);
        return pageModel.Value;
    }

    public static TPageModel HaveElementAttribute<TPageModel>(
        this ReferenceTypeAssertion<TPageModel> pageModel,
        string selector,
        string attributeName,
        string because = "no reason given",
        PageGetAttributeOptions? options = null)
        where TPageModel : PageModel
    {
        pageModel.Value.Should().HaveElementAttribute(selector, attributeName, because, options);

        return pageModel.Value;
    }

    public static TPageModel HaveElementAttributeValue<TPageModel>(
        this ReferenceTypeAssertion<TPageModel> pageModel,
        string selector,
        string attributeName,
        string expectedValue,
        string because = "no reason given",
        PageGetAttributeOptions? options = null)
        where TPageModel : PageModel
    {
        pageModel.Value.Should().HaveElementAttributeValue(
            selector,
            attributeName,
            expectedValue,
            because,
            options);

        return pageModel.Value;
    }

    public static TPageModel HaveNotElementAttribute<TPageModel>(
        this ReferenceTypeAssertion<TPageModel> pageModel,
        string selector,
        string attributeName,
        string because = "no reason given",
        PageGetAttributeOptions? options = null)
        where TPageModel : PageModel
    {
        pageModel.Value.Should().HaveNotElementAttribute(
            selector, 
            attributeName, 
            because,
            options);

        return pageModel.Value;
    }

    public static TPageModel HaveComputedStyle<TPageModel>(
        this ReferenceTypeAssertion<TPageModel> pageModel,
        string selector,
        string styleName,
        string expectedStyleValue,
        string because = "no reason given",
        PageQuerySelectorOptions? options = null)
        where TPageModel : PageModel
    {
        pageModel.Value.Should().HaveComputedStyle(
            selector,
            styleName,
            expectedStyleValue,
            because,
            options);

        return pageModel.Value;
    }
}
