﻿/*
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
        var title = pageModel.Value.Title();
        var match = Regex.Match(title, pattern, RegexOptions.Compiled);

        if (!match.Success)
        {
            throw new AssertException(@$"
HaveTitle Assert Exception
Actual title: {title}
Expected pattern: {pattern}
Because: {because}
");
        }

        return pageModel.Value;
    }

    public static TPageModel HaveNotTitle<TPageModel>(
        this ReferenceTypeAssertion<TPageModel> pageModel,
        string pattern,
        string because = "no reason given")
        where TPageModel : PageModel
    {
        var title = pageModel.Value.Title();
        var match = Regex.Match(title, pattern, RegexOptions.Compiled);

        if (match.Success)
        {
            throw new AssertException(@$"
HaveNotTitle Assert Exception
Actual title: {title}
Expected pattern: {pattern}
Bacause: {because}
");
        }

        return pageModel.Value;
    }

    public static TPageModel HaveContent<TPageModel>(
        this ReferenceTypeAssertion<TPageModel> pageModel,
        string pattern,
        string because = "no reason given")
        where TPageModel : PageModel
    {
        var content = pageModel.Value.Content();
        var match = Regex.Match(content, pattern, RegexOptions.Compiled);

        if (!match.Success)
        {
            throw new AssertException(@$"
HaveContent Assert Exception
Actual content: {content}
Expected pattern: {pattern}
Because: {because}
");
        }

        return pageModel.Value;
    }

    public static TPageModel HaveNotContent<TPageModel>(
        this ReferenceTypeAssertion<TPageModel> pageModel,
        string pattern,
        string because = "no reason given")
        where TPageModel : PageModel
    {
        var content = pageModel.Value.Content();
        var match = Regex.Match(content, pattern, RegexOptions.Compiled);

        if (match.Success)
        {
            throw new AssertException(@$"
HaveNotContent Assert Exception
Actual content: {content}
Expected pattern: {pattern}
Because: {because}
");
        }

        return pageModel.Value;
    }

    public static TPageModel HaveElementTextContent<TPageModel>(
        this ReferenceTypeAssertion<TPageModel> pageModel,
        string selector,
        string pattern,
        string because = "no reason given",
        PageTextContentOptions? options = null)
        where TPageModel : PageModel
    {
        var textContent = pageModel.Value.TextContent(selector, options) ?? "";
        var match = Regex.Match(textContent, pattern, RegexOptions.Compiled);

        if (!match.Success)
        {
            throw new AssertException(@$"
HaveTextContent Assert Exception
Selector: {selector}
Actual text content: {textContent}
Expected pattern: {pattern}
Because: {because}
");
        }

        return pageModel.Value;
    }

    public static TPageModel HaveNotElementTextContent<TPageModel>(
        this ReferenceTypeAssertion<TPageModel> pageModel,
        string selector,
        string pattern,
        string because = "no reason given",
        PageTextContentOptions? options = null)
        where TPageModel : PageModel
    {
        var textContent = pageModel.Value.TextContent(selector, options) ?? "";
        var match = Regex.Match(textContent, pattern, RegexOptions.Compiled);

        if (match.Success)
        {
            throw new AssertException(@$"
HaveNotTextContent Assert Exception
Selector: {selector}
Actual text content: {textContent}
Not expected pattern: {pattern}
Because: {because}
");
        }

        return pageModel.Value;
    }

    public static TPageModel HaveElementInnerHTML<TPageModel>(
        this ReferenceTypeAssertion<TPageModel> pageModel,
        string selector,
        string pattern,
        string because = "no reason given",
        PageInnerHTMLOptions? options = null)
        where TPageModel : PageModel
    {
        var innerHtml = pageModel.Value.InnerHTML(selector, options);
        var match = Regex.Match(innerHtml, pattern, RegexOptions.Compiled);

        if (!match.Success)
        {
            throw new AssertException(@$"
HaveInnerHTML Assert Exception
Selector: {selector}
Actual inner html: {innerHtml}
Expected pattern: {pattern}
Because: {because}
");
        }

        return pageModel.Value;
    }

    public static TPageModel HaveNotElementInnerHTML<TPageModel>(
        this ReferenceTypeAssertion<TPageModel> pageModel,
        string selector,
        string pattern,
        string because = "no reason given",
        PageInnerHTMLOptions? options = null)
        where TPageModel : PageModel
    {
        var innerHtml = pageModel.Value.InnerHTML(selector, options);
        var match = Regex.Match(innerHtml, pattern, RegexOptions.Compiled);

        if (match.Success)
        {
            throw new AssertException(@$"
HaveNotInnerHTML Assert Exception
Selector: {selector}
Actual inner html: {innerHtml}
Not expected pattern: {pattern}
Because: {because}
");
        }

        return pageModel.Value;
    }

    public static TPageModel HaveElementInnerText<TPageModel>(
        this ReferenceTypeAssertion<TPageModel> pageModel,
        string selector,
        string pattern,
        string because = "no reason given",
        PageInnerTextOptions? options = null)
        where TPageModel : PageModel
    {
        var innerText = pageModel.Value.InnerText(selector, options);
        var match = Regex.Match(innerText, pattern, RegexOptions.Compiled);

        if (!match.Success)
        {
            throw new AssertException(@$"
HaveInnerText Assert Exception
Selector: {selector}
Actual inner text: {innerText}
Expected pattern: {pattern}
Because: {because}
");
        }

        return pageModel.Value;
    }

    public static TPageModel HaveNotElementInnerText<TPageModel>(
        this ReferenceTypeAssertion<TPageModel> pageModel,
        string selector,
        string pattern,
        string because = "no reason given",
        PageInnerTextOptions? options = null)
        where TPageModel : PageModel
    {
        var innerText = pageModel.Value.InnerText(selector, options);
        var match = Regex.Match(innerText, pattern, RegexOptions.Compiled);

        if (match.Success)
        {
            throw new AssertException(@$"
HaveNotInnerText Assert Exception
Selector: {selector}
Actual inner text: {innerText}
Not expected pattern: {pattern}
Because: {because}
");
        }

        return pageModel.Value;
    }

    public static TPageModel HaveElementInputValue<TPageModel>(
        this ReferenceTypeAssertion<TPageModel> pageModel,
        string selector,
        string pattern,
        string because = "no reason given",
        PageInputValueOptions? options = null)
        where TPageModel : PageModel
    {
        var inputValue = pageModel.Value.InputValue(selector, options);
        var match = Regex.Match(inputValue, pattern, RegexOptions.Compiled);

        if (!match.Success)
        {
            throw new AssertException(@$"
HaveInputValue Assert Exception
Selector: {selector}
Actual input text: {inputValue}
Expected pattern: {pattern}
Because: {because}
");
        }

        return pageModel.Value;
    }

    public static TPageModel HaveNotElementInputValue<TPageModel>(
        this ReferenceTypeAssertion<TPageModel> pageModel,
        string selector,
        string pattern,
        string because = "no reason given",
        PageInputValueOptions? options = null)
        where TPageModel : PageModel
    {
        var inputValue = pageModel.Value.InputValue(selector, options);
        var match = Regex.Match(inputValue, pattern, RegexOptions.Compiled);

        if (match.Success)
        {
            throw new AssertException(@$"
HaveInputValue Assert Exception
Selector: {selector}
Actual input text: {inputValue}
Not expected pattern: {pattern}
Because: {because}
");
        }

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
        var value = pageModel.Value.GetAttribute(selector, attributeName, options);

        if (value is null)
        {
            throw new AssertException($@"
HaveElementAttribute Assert Exception
Selector: {selector}
Expected attribute: {attributeName}
Because: {because}
");
        }

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
        var value = pageModel.Value.GetAttribute(selector, attributeName, options);
        if (value is null) throw new AssertException($@"Attibute not found. Selector {selector}. Attribute {attributeName}");

        if (string.Compare(value, expectedValue) != 0)
        {
            throw new AssertException($@"
HaveElementAttributeValue Assert Exception
Selector: {selector}
Attribute name: {attributeName},
Attribute value: {expectedValue}
Because: {because}
");
        }

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
        var value = pageModel.Value.GetAttribute(selector, attributeName, options);

        if (value is not null)
        {
            throw new AssertException($@"
HaveNotElementAttribute Assert Exception
Selector: {selector}
Attribute name: {attributeName}
Because: {because}
");
        }

        return pageModel.Value;
    }

    public static TPageModel HaveElement<TPageModel>(
        this ReferenceTypeAssertion<TPageModel> pageModel,
        string selector,
        string because = "no reason given",
        PageQuerySelectorOptions? options = null)
        where TPageModel : PageModel
    {
        var element = pageModel.Value.FindElementOrNull(selector, options);

        if (element is null)
        {
            throw new AssertException($@"
HaveElement Assert Exception
Selector {selector}
Because: {because}
");
        }

        return pageModel.Value;
    }

    public static TPageModel HaveElementCount<TPageModel>(
        this ReferenceTypeAssertion<TPageModel> pageModel,
        string selector,
        int count,
        string because = "no reason given")
        where TPageModel : PageModel
    {
        var elements = pageModel.Value.FindElements(selector);

        if (elements is null || elements.Count != count)
        {
            throw new AssertException($@"
HaveElementCount Assert Exception
Selector: {selector}
Count: {count}
Because: {because}
");
        }

        return pageModel.Value;
    }

    public static TPageModel HaveCheckedElement<TPageModel>(
        this ReferenceTypeAssertion<TPageModel> pageModel,
        string selector,
        string because = "no reason given",
        PageIsCheckedOptions? options = null)
        where TPageModel : PageModel
    {
        var isChecked = pageModel.Value.IsChecked(selector, options);

        if (!isChecked)
        {
            throw new AssertException($@"
HaveChecked Assert Exception
Selector: {selector}
Expected: checked
Actual: not checked
Because: {because}
");
        }

        return pageModel.Value;
    }

    public static TPageModel HaveNotCheckedElement<TPageModel>(
        this ReferenceTypeAssertion<TPageModel> pageModel,
        string selector,
        string because = "no reason given",
        PageIsCheckedOptions? options = null)
        where TPageModel : PageModel
    {
        var isChecked = pageModel.Value.IsChecked(selector, options);

        if (isChecked)
        {
            throw new AssertException($@"
HaveNotChecked Assert Exception
Selector: {selector}
Expected not checked
Actual: checked
Because: {because}
");
        }

        return pageModel.Value;
    }

    public static TPageModel HaveDisabledElement<TPageModel>(
        this ReferenceTypeAssertion<TPageModel> pageModel,
        string selector,
        string because = "no reason given",
        PageIsDisabledOptions? options = null)
        where TPageModel : PageModel
    {
        var isDisabled = pageModel.Value.IsDisabled(selector, options);

        if (!isDisabled)
        {
            throw new AssertException($@"
HaveDisabled Assert Exception
Selector: {selector}
Expected: disabled
Actual: not disabled
Because: {because}
");
        }

        return pageModel.Value;
    }

    public static TPageModel HaveNotDisabledElement<TPageModel>(
        this ReferenceTypeAssertion<TPageModel> pageModel,
        string selector,
        string because = "no reason given",
        PageIsDisabledOptions? options = null)
        where TPageModel : PageModel
    {
        var isDisabled = pageModel.Value.IsDisabled(selector, options);

        if (isDisabled)
        {
            throw new AssertException($@"
HaveNotDisabled Assert Exception
Selector: {selector}
Expected: not disabled
Actual: disabled
Because: {because}
");
        }

        return pageModel.Value;
    }

    public static TPageModel HaveEditableElement<TPageModel>(
        this ReferenceTypeAssertion<TPageModel> pageModel,
        string selector,
        string because = "no reason given",
        PageIsEditableOptions? options = null)
        where TPageModel : PageModel
    {
        var isEditable = pageModel.Value.IsEditable(selector, options);

        if (!isEditable)
        {
            throw new AssertException($@"
HaveEditable Assert Exception
Selector: {selector}
Expected: editable
Actual: not editable
Because: {because}
");
        }

        return pageModel.Value;
    }

    public static TPageModel HaveNotEditableElement<TPageModel>(
        this ReferenceTypeAssertion<TPageModel> pageModel,
        string selector,
        string because = "no reason given",
        PageIsEditableOptions? options = null)
        where TPageModel : PageModel
    {
        var isEditable = pageModel.Value.IsEditable(selector, options);

        if (isEditable)
        {
            throw new AssertException($@"
HaveNotEditable Assert Exception
Selector: {selector}
Expected: not editable
Actual: editable
Because: {because}
");
        }

        return pageModel.Value;
    }

    public static TPageModel HaveEnabledElement<TPageModel>(
        this ReferenceTypeAssertion<TPageModel> pageModel,
        string selector,
        string because = "no reason given",
        PageIsEnabledOptions? options = null)
        where TPageModel : PageModel
    {
        var isEnable = pageModel.Value.IsEnabled(selector, options);

        if (!isEnable)
        {
            throw new AssertException($@"
HaveEnabled Assert Exception
Selector: {selector}
Expected: enabled
Actual: not enabled
Because: {because}
");
        }

        return pageModel.Value;
    }

    public static TPageModel HaveNotEnabledElement<TPageModel>(
        this ReferenceTypeAssertion<TPageModel> pageModel,
        string selector,
        string because = "no reason given",
        PageIsEnabledOptions? options = null)
        where TPageModel : PageModel
    {
        var isEnable = pageModel.Value.IsEnabled(selector, options);

        if (isEnable)
        {
            throw new AssertException($@"
HaveNotEnabled Assert Exception
Selector: {selector}
Expected: not enabled
Actual: enabled
Because: {because}
");
        }

        return pageModel.Value;
    }

    public static TPageModel HaveHiddenElement<TPageModel>(
        this ReferenceTypeAssertion<TPageModel> pageModel,
        string selector,
        string because = "no reason given",
        PageIsHiddenOptions? options = null)
        where TPageModel : PageModel
    {
        var isHidden = pageModel.Value.IsHidden(selector, options);

        if (!isHidden)
        {
            throw new AssertException($@"
HaveHidden Assert Exception
Selector: {selector}
Expected: hidden
Actual: not hidden
Because: {because}
");
        }

        return pageModel.Value;
    }

    public static TPageModel HaveNotHiddenElement<TPageModel>(
        this ReferenceTypeAssertion<TPageModel> pageModel,
        string selector,
        string because = "no reason given",
        PageIsHiddenOptions? options = null)
        where TPageModel : PageModel
    {
        var isHidden = pageModel.Value.IsHidden(selector, options);

        if (isHidden)
        {
            throw new AssertException($@"
HaveNotHidden Assert Exception
Selector: {selector}
Expected: not hidden
Actual: hidden
Because: {because}
");
        }

        return pageModel.Value;
    }

    public static TPageModel HaveVisibleElement<TPageModel>(
        this ReferenceTypeAssertion<TPageModel> pageModel,
        string selector,
        string because = "no reason given",
        PageIsVisibleOptions? options = null)
        where TPageModel : PageModel
    {
        var isVisible = pageModel.Value.IsVisible(selector, options);

        if (!isVisible)
        {
            throw new AssertException($@"
HaveVisible Assert Exception
Selector: {selector}
Expected: visible
Actual: not visible
Because: {because}
");
        }

        return pageModel.Value;
    }

    public static TPageModel HaveNotVisibleElement<TPageModel>(
        this ReferenceTypeAssertion<TPageModel> pageModel,
        string selector,
        string because = "no reason given",
        PageIsVisibleOptions? options = null)
        where TPageModel : PageModel
    {
        var isVisible = pageModel.Value.IsVisible(selector, options);

        if (isVisible)
        {
            throw new AssertException($@"
HaveNotVisible Assert Exception
Selector: {selector}
Expected: not visible
Actual: visible
Because: {because}
");
        }

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
        var element = pageModel.Value.QuerySelector(selector, options);
        if (element is null) throw new AssertException($"Element not found. Selector: {selector}");

        var actualStylevalue = element.Evaluate($"e => getComputedStyle(e).{styleName}", element).ToString();
        if (actualStylevalue is null) throw new AssertException($"Style not found. Style name: {styleName}");

        if (string.Compare(actualStylevalue, expectedStyleValue) != 0)
        {
            throw new AssertException($@"
HaveComputedStyle Assert Exception
Style name: {styleName}
Expected style value: {expectedStyleValue}
Actual style value: {actualStylevalue}
Because: {because}
");
        }

        return pageModel.Value;
    }
}
