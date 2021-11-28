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

using Playwright.Synchronous;
using Playwright.PageObjectModel;
using System;
using System.Text.RegularExpressions;
using Microsoft.Playwright;


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
        string pattern,
        string? selector = null,
        string because = "no reason given")
        where TBlockModel : BlockModel<PageModel>
    {
        var block = blockModel.Value.ElementHandle;
        string? textContent = null;

        if (selector is not null)
        {
            var element = block.QuerySelector(selector);
            if (element is null) throw new AssertException($"Element not found. Selector {selector}");

            textContent = element.TextContent();
        }
        else
        {
            textContent = block.TextContent();
        }

        var match = Regex.Match(textContent ?? "", pattern, RegexOptions.Compiled);

        if (!match.Success)
        {
            throw new AssertException(@$"
HaveContent Assert Exception
Actual text content: {textContent}
Expected pattern: {pattern}
Because: {because}
");
        }

        return blockModel.Value;
    }

    public static TBlockModel HaveNotTextContent<TBlockModel>(
        this ReferenceTypeAssertion<TBlockModel> blockModel,
        string pattern,
        string? selector = null,
        string because = "no reason given")
        where TBlockModel : BlockModel<PageModel>
    {
        var block = blockModel.Value.ElementHandle;
        string? textContent = null;

        if (selector is not null)
        {
            var element = block.QuerySelector(selector);
            if (element is null) throw new AssertException($"Element not found. Selector {selector}");

            textContent = element.TextContent();
        }
        else
        {
            textContent = block.TextContent();
        }

        var match = Regex.Match(textContent ?? "", pattern, RegexOptions.Compiled);

        if (match.Success)
        {
            throw new AssertException(@$"
HaveNotTextContent Assert Exception
Actual text content: {textContent}
Not expected pattern: {pattern}
Because: {because}
");
        }

        return blockModel.Value;
    }

    public static TBlockModel HaveInnerHTML<TBlockModel>(
        this ReferenceTypeAssertion<TBlockModel> blockModel,
        string pattern,
        string? selector = null,
        string because = "no reason given")
        where TBlockModel : BlockModel<PageModel>
    {
        var block = blockModel.Value.ElementHandle;
        string? innerHtml = null;

        if (selector is not null)
        {
            var element = block.QuerySelector(selector);
            if (element is null) throw new AssertException($"Element not found. Selector {selector}");

            innerHtml = element.InnerHTML();
        }
        else
        {
            innerHtml = block.InnerHTML();
        }

        var match = Regex.Match(innerHtml ?? "", pattern, RegexOptions.Compiled);

        if (!match.Success)
        {
            throw new AssertException(@$"
HaveInnerHTML Assert Exception
Actual inner html: {innerHtml}
Expected pattern: {pattern}
Because: {because}
");
        }

        return blockModel.Value;
    }

    public static TBlockModel HaveNotInnerHTML<TBlockModel>(
        this ReferenceTypeAssertion<TBlockModel> blockModel,
        string pattern,
        string? selector = null,
        string because = "no reason given")
        where TBlockModel : BlockModel<PageModel>
    {
        var block = blockModel.Value.ElementHandle;
        string? innerHtml = null;

        if (selector is not null)
        {
            var element = block.QuerySelector(selector);
            if (element is null) throw new AssertException($"Element not found. Selector {selector}");

            innerHtml = element.InnerHTML();
        }
        else
        {
            innerHtml = block.InnerHTML();
        }

        var match = Regex.Match(innerHtml ?? "", pattern, RegexOptions.Compiled);

        if (match.Success)
        {
            throw new AssertException(@$"
HaveNotInnerHTML Assert Exception
Actual inner html: {innerHtml}
Not expected pattern: {pattern}
Because: {because}
");
        }

        return blockModel.Value;
    }

    public static TBlockModel HaveInnerText<TBlockModel>(
        this ReferenceTypeAssertion<TBlockModel> blockModel,
        string pattern,
        string? selector = null,
        string because = "no reason given")
        where TBlockModel : BlockModel<PageModel>
    {
        var block = blockModel.Value.ElementHandle;
        string? innerText = null;

        if (selector is not null)
        {
            var element = block.QuerySelector(selector);
            if (element is null) throw new AssertException($"Element not found. Selector {selector}");

            innerText = element.InnerText();
        }
        else
        {
            innerText = block.InnerText();
        }

        var match = Regex.Match(innerText ?? "", pattern, RegexOptions.Compiled);

        if (!match.Success)
        {
            throw new AssertException(@$"
HaveInnerText Assert Exception
Actual inner text: {innerText}
Expected pattern: {pattern}
Because: {because}
");
        }

        return blockModel.Value;
    }

    public static TBlockModel HaveNotInnerText<TBlockModel>(
        this ReferenceTypeAssertion<TBlockModel> blockModel,
        string pattern,
        string? selector = null,
        string because = "no reason given")
        where TBlockModel : BlockModel<PageModel>
    {
        var block = blockModel.Value.ElementHandle;
        string? innerText = null;

        if (selector is not null)
        {
            var element = block.QuerySelector(selector);
            if (element is null) throw new AssertException($"Element not found. Selector {selector}");

            innerText = element.InnerText();
        }
        else
        {
            innerText = block.InnerText();
        }

        var match = Regex.Match(innerText ?? "", pattern, RegexOptions.Compiled);

        if (match.Success)
        {
            throw new AssertException(@$"
HaveNotInnerText Assert Exception
Actual inner text: {innerText}
Not expected pattern: {pattern}
Because: {because}
");
        }

        return blockModel.Value;
    }

    public static TBlockModel HaveInputValue<TBlockModel>(
        this ReferenceTypeAssertion<TBlockModel> blockModel,
        string pattern,
        string? selector = null,
        string because = "no reason given")
        where TBlockModel : BlockModel<PageModel>
    {
        var block = blockModel.Value.ElementHandle;
        string? inputValue = null;

        if (selector is not null)
        {
            var element = block.QuerySelector(selector);
            if (element is null) throw new AssertException($"Element not found. Selector {selector}");

            inputValue = element.InputValue();
        }
        else
        {
            inputValue = block.InputValue();
        }

        var match = Regex.Match(inputValue ?? "", pattern, RegexOptions.Compiled);

        if (!match.Success)
        {
            throw new AssertException(@$"
HaveInputValue Assert Exception
Actual input value: {inputValue}
Expected pattern: {pattern}
Because: {because}
");
        }

        return blockModel.Value;
    }

    public static TBlockModel HaveNotInputValue<TBlockModel>(
        this ReferenceTypeAssertion<TBlockModel> blockModel,
        string pattern,
        string? selector = null,
        string because = "no reason given")
        where TBlockModel : BlockModel<PageModel>
    {
        var block = blockModel.Value.ElementHandle;
        string? inputValue = null;

        if (selector is not null)
        {
            var element = block.QuerySelector(selector);
            if (element is null) throw new AssertException($"Element not found. Selector {selector}");

            inputValue = element.InputValue();
        }
        else
        {
            inputValue = block.InputValue();
        }

        var match = Regex.Match(inputValue ?? "", pattern, RegexOptions.Compiled);

        if (match.Success)
        {
            throw new AssertException(@$"
HaveNotInputValue Assert Exception
Actual input value: {inputValue}
Not expected pattern: {pattern}
Because: {because}
");
        }

        return blockModel.Value;
    }

    public static TBlockModel HaveElementAttribute<TBlockModel>(
        this ReferenceTypeAssertion<TBlockModel> blockModel,
        string attributeName,
        string? selector = null,
        string because = "no reason given")
        where TBlockModel : BlockModel<PageModel>
    {
        var block = blockModel.Value.ElementHandle;
        string? attributeValue = null;

        if (selector is not null)
        {
            var element = block.QuerySelector(selector);
            if (element is null) throw new AssertException($@"Element not found. Selector {selector}");

            attributeValue = element.GetAttribute(attributeName);
        }
        else
        {
            attributeValue = block.GetAttribute(attributeName);
        }

        if (attributeValue is null)
        {
            throw new AssertException($@"
HaveElementAttribute Assert Exception
Expected attribute: {attributeName}
Actual: attribute {attributeName} not found
Because: {because}
");
        }

        return blockModel.Value;
    }

    public static TBlockModel NotHaveElementAttribute<TBlockModel>(
        this ReferenceTypeAssertion<TBlockModel> blockModel,
        string attributeName,
        string? selector = null,
        string because = "no reason given")
        where TBlockModel : BlockModel<PageModel>
    {
        var block = blockModel.Value.ElementHandle;
        string? attributeValue = null;

        if (selector is not null)
        {
            var element = block.QuerySelector(selector);
            if (element is null) throw new AssertException($@"Element not found. Selector {selector}");

            attributeValue = element.GetAttribute(attributeName);
        }
        else
        {
            attributeValue = block.GetAttribute(attributeName);
        }

        if (attributeValue is not null)
        {
            throw new AssertException($@"
HaveElementAttribute Assert Exception
Not expected attribute: {attributeName}
Because: {because}
");
        }

        return blockModel.Value;
    }

    public static TBlockModel HaveElementAttributeValue<TBlockModel>(
        this ReferenceTypeAssertion<TBlockModel> blockModel,
        string attributeName,
        string value,
        string? selector = null,
        string because = "no reason given")
        where TBlockModel : BlockModel<PageModel>
    {
        var block = blockModel.Value.ElementHandle;
        string? attributeValue = null;

        if (selector is not null)
        {
            var element = block.QuerySelector(selector);
            if (element is null) throw new AssertException($@"Element not found. Selector {selector}");

            attributeValue = element.GetAttribute(attributeName);
        }
        else
        {
            attributeValue = block.GetAttribute(attributeName);
        }

        if (attributeValue is not null && string.Compare(attributeValue, value) != 0)
        {
            throw new AssertException($@"
HaveElementAttributeValue Assert Exception
Expected attribute: {attributeName}
Expected attribute value: {value}
Because: {because}
");
        }

        return blockModel.Value;
    }

    public static TBlockModel HaveChecked<TBlockModel>(
        this ReferenceTypeAssertion<TBlockModel> blockModel,
        string? selector = null,
        string because = "no reason given")
        where TBlockModel : BlockModel<PageModel>
    {
        bool isChecked;

        if (selector is not null)
        {
            var element = blockModel.Value.ElementHandle.QuerySelector(selector);
            if (element is null) throw new ApplicationException($"Element not found. Selector {selector}");
            isChecked = element.IsChecked();
        }
        else
        {
            isChecked = blockModel.Value.ElementHandle.IsChecked();
        }

        if (isChecked is false)
        {
            throw new AssertException($@"
HaveChecked Assert Exception
Selector: {selector}
Expected: checked
Actual: not checked
Because: {because}
");
        }

        return blockModel.Value;
    }

    public static TBlockModel HaveNotChecked<TBlockModel>(
        this ReferenceTypeAssertion<TBlockModel> blockModel,
        string? selector = null,
        string because = "no reason given")
        where TBlockModel : BlockModel<PageModel>
    {
        bool isChecked;

        if (selector is not null)
        {
            var element = blockModel.Value.ElementHandle.QuerySelector(selector);
            if (element is null) throw new ApplicationException($"Element not found. Selector {selector}");
            isChecked = element.IsChecked();
        }
        else
        {
            isChecked = blockModel.Value.ElementHandle.IsChecked();
        }

        if (isChecked is true)
        {
            throw new AssertException($@"
HaveNotChecked Assert Exception
Selector: {selector}
Expected: not checked
Actual: checked
Because: {because}
");
        }

        return blockModel.Value;
    }

    public static TBlockModel HaveDisabled<TBlockModel>(
        this ReferenceTypeAssertion<TBlockModel> blockModel,
        string? selector = null,
        string because = "no reason given")
        where TBlockModel : BlockModel<PageModel>
    {
        bool isDisabled;

        if (selector is not null)
        {
            var element = blockModel.Value.ElementHandle.QuerySelector(selector);
            if (element is null) throw new ApplicationException($"Element not found. Selector {selector}");
            isDisabled = element.IsDisabled();
        }
        else
        {
            isDisabled = blockModel.Value.ElementHandle.IsDisabled();
        }

        if (isDisabled is false)
        {
            throw new AssertException($@"
HaveDisabled Assert Exception
Selector: {selector}
Expected: disable
Atual: not disable
Because: {because}
");
        }

        return blockModel.Value;
    }

    public static TBlockModel HaveNotDisabled<TBlockModel>(
        this ReferenceTypeAssertion<TBlockModel> blockModel,
        string? selector = null,
        string because = "no reason given")
        where TBlockModel : BlockModel<PageModel>
    {
        bool isDisabled;

        if (selector is not null)
        {
            var element = blockModel.Value.ElementHandle.QuerySelector(selector);
            if (element is null) throw new ApplicationException($"Element not found. Selector {selector}");
            isDisabled = element.IsDisabled();
        }
        else
        {
            isDisabled = blockModel.Value.ElementHandle.IsDisabled();
        }

        if (isDisabled is true)
        {
            throw new AssertException($@"
HaveNotDisabled Assert Exception
Selector: {selector}
Expected: not disable
Atual: disable
Because: {because}
");
        }

        return blockModel.Value;
    }

    public static TBlockModel HaveEditable<TBlockModel>(
        this ReferenceTypeAssertion<TBlockModel> blockModel,
        string? selector = null,
        string because = "no reason given")
        where TBlockModel : BlockModel<PageModel>
    {
        bool isEditable;

        if (selector is not null)
        {
            var element = blockModel.Value.ElementHandle.QuerySelector(selector);
            if (element is null) throw new ApplicationException($"Element not found. Selector {selector}");
            isEditable = element.IsEditable();
        }
        else
        {
            isEditable = blockModel.Value.ElementHandle.IsEditable();
        }

        if (isEditable is false)
        {
            throw new AssertException($@"
HaveEditable Assert Exception
Selector: {selector}
Expected: editable
Actual: not editable
Because: {because}
");
        }

        return blockModel.Value;
    }

    public static TBlockModel HaveNotEditable<TBlockModel>(
        this ReferenceTypeAssertion<TBlockModel> blockModel,
        string? selector = null,
        string because = "no reason given")
        where TBlockModel : BlockModel<PageModel>
    {
        bool isEditable;

        if (selector is not null)
        {
            var element = blockModel.Value.ElementHandle.QuerySelector(selector);
            if (element is null) throw new ApplicationException($"Element not found. Selector {selector}");
            isEditable = element.IsEditable();
        }
        else
        {
            isEditable = blockModel.Value.ElementHandle.IsEditable();
        }

        if (isEditable is true)
        {
            throw new AssertException($@"
HaveNotEditable Assert Exception
Selector: {selector}
Expected: editable
Actual: not editable
Because: {because}
");
        }

        return blockModel.Value;
    }

    public static TBlockModel HaveEnabled<TBlockModel>(
        this ReferenceTypeAssertion<TBlockModel> blockModel,
        string? selector = null,
        string because = "no reason given")
        where TBlockModel : BlockModel<PageModel>
    {
        bool isEnabled;

        if (selector is not null)
        {
            var element = blockModel.Value.ElementHandle.QuerySelector(selector);
            if (element is null) throw new ApplicationException($"Element not found. Selector {selector}");
            isEnabled = element.IsEnabled();
        }
        else
        {
            isEnabled = blockModel.Value.ElementHandle.IsEnabled();
        }

        if (isEnabled is false)
        {
            throw new AssertException($@"
HaveEnabled Assert Exception
Selector: {selector}
Expected: enable
Actual: not enable
Because: {because}
");
        }

        return blockModel.Value;
    }

    public static TBlockModel HaveNotEnabled<TBlockModel>(
        this ReferenceTypeAssertion<TBlockModel> blockModel,
        string? selector = null,
        string because = "no reason given")
        where TBlockModel : BlockModel<PageModel>
    {
        bool isEnabled;

        if (selector is not null)
        {
            var element = blockModel.Value.ElementHandle.QuerySelector(selector);
            if (element is null) throw new ApplicationException($"Element not found. Selector {selector}");
            isEnabled = element.IsEnabled();
        }
        else
        {
            isEnabled = blockModel.Value.ElementHandle.IsEnabled();
        }

        if (isEnabled is true)
        {
            throw new AssertException($@"
HaveNotEnabled Assert Exception
Selector: {selector}
Expected: not enable
Actual: enable
Because: {because}
");
        }

        return blockModel.Value;
    }

    public static TBlockModel HaveHidden<TBlockModel>(
        this ReferenceTypeAssertion<TBlockModel> blockModel,
        string? selector = null,
        string because = "no reason given")
        where TBlockModel : BlockModel<PageModel>
    {
        bool isEnabled;

        if (selector is not null)
        {
            var element = blockModel.Value.ElementHandle.QuerySelector(selector);
            if (element is null) throw new ApplicationException($"Element not found. Selector {selector}");
            isEnabled = element.IsHidden();
        }
        else
        {
            isEnabled = blockModel.Value.ElementHandle.IsHidden();
        }

        if (isEnabled is false)
        {
            throw new AssertException($@"
HaveHidden Assert Exception
Selector: {selector}
Expected: hidden
Actual: not hidden
Because: {because}
");
        }

        return blockModel.Value;
    }

    public static TBlockModel HaveNotHidden<TBlockModel>(
        this ReferenceTypeAssertion<TBlockModel> blockModel,
        string? selector = null,
        string because = "no reason given")
        where TBlockModel : BlockModel<PageModel>
    {
        bool isEnabled;

        if (selector is not null)
        {
            var element = blockModel.Value.ElementHandle.QuerySelector(selector);
            if (element is null) throw new ApplicationException($"Element not found. Selector {selector}");
            isEnabled = element.IsHidden();
        }
        else
        {
            isEnabled = blockModel.Value.ElementHandle.IsHidden();
        }

        if (isEnabled is true)
        {
            throw new AssertException($@"
HaveNotHidden Assert Exception
Selector: {selector}
Expected: not hidden
Actual: hidden
Because: {because}
");
        }

        return blockModel.Value;
    }

    public static TBlockModel HaveVisible<TBlockModel>(
        this ReferenceTypeAssertion<TBlockModel> blockModel,
        string? selector = null,
        string because = "no reason given")
        where TBlockModel : BlockModel<PageModel>
    {
        bool isEnabled;

        if (selector is not null)
        {
            var element = blockModel.Value.ElementHandle.QuerySelector(selector);
            if (element is null) throw new ApplicationException($"Element not found. Selector {selector}");
            isEnabled = element.IsVisible();
        }
        else
        {
            isEnabled = blockModel.Value.ElementHandle.IsVisible();
        }

        if (isEnabled is false)
        {
            throw new AssertException($@"
HaveVisible Assert Exception
Selector: {selector}
Expected: visible
Actual: not visible
Because: {because}
");
        }

        return blockModel.Value;
    }

    public static TBlockModel HaveNotVisible<TBlockModel>(
        this ReferenceTypeAssertion<TBlockModel> blockModel,
        string? selector = null,
        string because = "no reason given")
        where TBlockModel : BlockModel<PageModel>
    {
        bool isEnabled;

        if (selector is not null)
        {
            var element = blockModel.Value.ElementHandle.QuerySelector(selector);
            if (element is null) throw new ApplicationException($"Element not found. Selector {selector}");
            isEnabled = element.IsVisible();
        }
        else
        {
            isEnabled = blockModel.Value.ElementHandle.IsVisible();
        }

        if (isEnabled is true)
        {
            throw new AssertException($@"
HaveNotVisible Assert Exception
Selector: {selector}
Expected: not visible
Actual: visible
Because: {because}
");
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
        var element = blockModel.Value.ElementHandle;
        IElementHandle? checkElement = null;
        string? actualStylevalue = null;

        if (selector is null)
        {
            checkElement = element;
        }
        else
        {
            checkElement = element.QuerySelector(selector);
            if (checkElement is null) throw new AssertException($"Element not found. Selector: {selector}");
        }

        actualStylevalue = checkElement.Evaluate($"e => getComputedStyle(e).{styleName}", element).ToString();
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

        return blockModel.Value;
    }
}
