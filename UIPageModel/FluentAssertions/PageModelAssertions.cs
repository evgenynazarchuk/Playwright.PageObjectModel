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

using System;
using System.Text.RegularExpressions;
using Microsoft.Playwright;
using UITesting.Page.Sync;

namespace UIPageModel.FluentAssertions;

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
        string because = "")
        where TPageModel : PageModel
    {
        var title = pageModel.Value.Title();
        Match match = Regex.Match(pattern, title, RegexOptions.Compiled);

        if (!match.Success)
        {
            throw new AssertException(@$"
HaveTitle Assert Exception
Expected: {title}
Actual: {pattern}
Because: {because}
");
        }

        return pageModel.Value;
    }

    public static TPageModel NotHaveTitle<TPageModel>(
        this ReferenceTypeAssertion<TPageModel> pageModel,
        string pattern, 
        string because = "")
        where TPageModel : PageModel
    {
        var title = pageModel.Value.Title();
        Match match = Regex.Match(pattern, title, RegexOptions.Compiled);

        if (match.Success)
        {
            throw new AssertException(@$"
NotHaveTitle Assert Exception
Expected: {title}
Actual: {pattern}
Bacause: {because}
");
        }

        return pageModel.Value;
    }

    public static TPageModel HaveContent<TPageModel>(
        this ReferenceTypeAssertion<TPageModel> pageModel,
        string pattern,
        string because = "")
        where TPageModel : PageModel
    {
        var title = pageModel.Value.Content();
        Match match = Regex.Match(pattern, title, RegexOptions.Compiled);

        if (!match.Success)
        {
            throw new AssertException(@$"
HaveContent Assert Exception
Expected: {title}
Actual: {pattern}
Because: {because}
");
        }

        return pageModel.Value;
    }

    public static TPageModel NotHaveContent<TPageModel>(
        this ReferenceTypeAssertion<TPageModel> pageModel,
        string pattern,
        string because = "")
        where TPageModel : PageModel
    {
        var title = pageModel.Value.Content();
        Match match = Regex.Match(pattern, title, RegexOptions.Compiled);

        if (match.Success)
        {
            throw new AssertException(@$"
NotHaveContent Assert Exception
Expected: {title}
Actual: {pattern}
Because: {because}
");
        }

        return pageModel.Value;
    }

    public static TPageModel HaveElementAttribute<TPageModel>(
        this ReferenceTypeAssertion<TPageModel> pageModel,
        string selector, 
        string attributeName,
        string because = "")
        where TPageModel : PageModel
    {
        var attributeValue = pageModel.Value.GetAttribute(selector, attributeName);

        if (attributeValue is null)
        {
            throw new AssertException($@"
HaveElementAttribute Assert Exception
Expected: selector {selector}, attribute name {attributeName}
Because: {because}
");
        }

        return pageModel.Value;
    }

    public static TPageModel HaveElementAttributeValue<TPageModel>(
        this ReferenceTypeAssertion<TPageModel> pageModel,
        string selector, 
        string attributeName, 
        string value,
        string because = "",
        PageGetAttributeOptions? options = null)
        where TPageModel : PageModel
    {
        var result = pageModel.Value.GetAttribute(selector, attributeName, options);

        if (string.Compare(result, value) != 0)
        {
            throw new AssertException($@"
HaveElementAttribute Assert Exception
Expected: selector {selector}, attribute name {attributeName}, 
Because: {because}
");
        }

        return pageModel.Value;
    }

    public static TPageModel NotHaveElementAttribute<TPageModel>(
        this ReferenceTypeAssertion<TPageModel> pageModel,
        string selector,
        string attributeName,
        string because = "",
        PageGetAttributeOptions? options = null)
        where TPageModel : PageModel
    {
        var result = pageModel.Value.GetAttribute(selector, attributeName, options);

        if (result is not null)
        {
            throw new AssertException($@"
NotHaveElementAttribute Assert Exception
Not expected attribute: selector {selector}, attribute name {attributeName}, 
Because: {because}
");
        }

        return pageModel.Value;
    }

    public static TPageModel HaveElement<TPageModel>(
        this ReferenceTypeAssertion<TPageModel> pageModel,
        string selector,
        string because = "",
        PageQuerySelectorOptions? options = null)
        where TPageModel : PageModel
    {
        var result = pageModel.Value.FindElementOrNull(selector, options);

        if (result is null)
        {
            throw new AssertException($@"
HaveElement Assert Exception
Expected element: selector {selector} 
Because: {because}
");
        }

        return pageModel.Value;
    }

    public static TPageModel HaveElementCount<TPageModel>(
        this ReferenceTypeAssertion<TPageModel> pageModel,
        string selector,
        int count,
        string because = "")
        where TPageModel : PageModel
    {
        var result = pageModel.Value.FindElements(selector);

        if (result is null || result.Count != count)
        {
            throw new AssertException($@"
HaveElementCount Assert Exception
Expected count element: selector {selector}, count {count}
Because: {because}
");
        }

        return pageModel.Value;
    }

    public static TPageModel HaveElementWithContent<TPageModel>(
        this ReferenceTypeAssertion<TPageModel> pageModel,
        string selector,
        string textContent,
        string because = "",
        PageQuerySelectorOptions? options = null)
        where TPageModel : PageModel
    {
        var result = pageModel.Value.FindElement(selector, options);
        var actualContent = result.TextContent();

        if (string.Compare(actualContent, textContent) != 0)
        {
            throw new AssertException($@"
HaveElementWithContent Assert Exception
Expected: selector {selector}, textContent {textContent}
Actual text content: {actualContent}
Because: {because}
");
        }

        return pageModel.Value;
    }

    public static TPageModel HaveChecked<TPageModel>(
        this ReferenceTypeAssertion<TPageModel> pageModel,
        string selector,
        string because = "",
        PageIsCheckedOptions? options = null)
        where TPageModel : PageModel
    {
        var isChecked = pageModel.Value.IsChecked(selector, options);

        if (!isChecked)
        {
            throw new AssertException($@"
HaveChecked Assert Exception
Expected: selector {selector} is checked
Actual: {isChecked}
Because: {because}
");
        }

        return pageModel.Value;
    }

    public static TPageModel HaveDisabled<TPageModel>(
        this ReferenceTypeAssertion<TPageModel> pageModel,
        string selector,
        string because = "",
        PageIsDisabledOptions? options = null)
        where TPageModel : PageModel
    {
        var isDisabled = pageModel.Value.IsDisabled(selector, options);

        if (!isDisabled)
        {
            throw new AssertException($@"
HaveDisabled Assert Exception
Expected: selector {selector} is disabled
Actual: {isDisabled}
Because: {because}
");
        }

        return pageModel.Value;
    }

    public static TPageModel HaveEditable<TPageModel>(
        this ReferenceTypeAssertion<TPageModel> pageModel,
        string selector,
        PageIsEditableOptions? options = null,
        string because = "")
        where TPageModel : PageModel
    {
        var isEditable = pageModel.Value.IsEditable(selector, options);

        if (!isEditable)
        {
            throw new AssertException($@"
HaveEditable Assert Exception
Expected: selector {selector} is editable
Actual: {isEditable}
Because: {because}
");
        }

        return pageModel.Value;
    }

    public static TPageModel HaveEnabled<TPageModel>(
        this ReferenceTypeAssertion<TPageModel> pageModel,
        string selector,
        PageIsEnabledOptions? options = null,
        string because = "")
        where TPageModel : PageModel
    {
        var isEnable = pageModel.Value.IsEnabled(selector, options);

        if (!isEnable)
        {
            throw new AssertException($@"
HaveEnabled Assert Exception
Expected: selector {selector} is enable
Actual: {isEnable}
Because: {because}
");
        }

        return pageModel.Value;
    }

    public static TPageModel HaveHidden<TPageModel>(
        this ReferenceTypeAssertion<TPageModel> pageModel,
        string selector,
        PageIsHiddenOptions? options = null,
        string because = "")
        where TPageModel : PageModel
    {
        var isHidden = pageModel.Value.IsHidden(selector, options);

        if (!isHidden)
        {
            throw new AssertException($@"
HaveHidden Assert Exception
Expected: selector {selector} is hidden
Actual: {isHidden}
Because: {because}
");
        }

        return pageModel.Value;
    }

    public static TPageModel HaveVisible<TPageModel>(
        this ReferenceTypeAssertion<TPageModel> pageModel,
        string selector,
        PageIsVisibleOptions? options = null,
        string because = "")
        where TPageModel : PageModel
    {
        var isVisible = pageModel.Value.IsVisible(selector, options);

        if (!isVisible)
        {
            throw new AssertException($@"
HaveVisible Assert Exception
Expected: selector {selector} is visible
Actual: {isVisible}
Because: {because}
");
        }

        return pageModel.Value;
    }

    public static TPageModel NotHaveChecked<TPageModel>(
        this ReferenceTypeAssertion<TPageModel> pageModel,
        string selector,
        PageIsCheckedOptions? options = null,
        string because = "")
        where TPageModel : PageModel
    {
        var isChecked = pageModel.Value.IsChecked(selector, options);

        if (isChecked)
        {
            throw new AssertException($@"
NotHaveChecked Assert Exception
Expected: selector {selector} is not checked
Actual: {isChecked}
Because: {because}
");
        }

        return pageModel.Value;
    }

    public static TPageModel NotHaveEditable<TPageModel>(
        this ReferenceTypeAssertion<TPageModel> pageModel,
        string selector,
        PageIsEditableOptions? options = null,
        string because = "")
        where TPageModel : PageModel
    {
        var isChecked = pageModel.Value.IsEditable(selector, options);

        if (isChecked)
        {
            throw new AssertException($@"
NotHaveEditable Assert Exception
Expected: selector {selector} is not editable
Actual: {isChecked}
Because: {because}
");
        }

        return pageModel.Value;
    }
}
