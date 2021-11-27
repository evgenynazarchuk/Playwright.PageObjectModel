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
using Playwright.Synchronization;

namespace Playwright.FluentAsserions;

public static partial class ElementHandleAssertions
{
    public static ReferenceTypeAssertion<IElementHandle> Should(this IElementHandle elementHandle)
    {
        return new ReferenceTypeAssertion<IElementHandle>(elementHandle);
    }

    public static IElementHandle BeChecked(
        this ReferenceTypeAssertion<IElementHandle> elementHandle,
        string because = "")
    {
        var element = elementHandle.Value;
        var isChecked = element.IsChecked();

        if (!isChecked)
        {
            throw new AssertException(@$"
BeChecked Assert Exception
Actual: not checked
Expected: checked
Because: {because}
");
        }

        return element;
    }

    public static IElementHandle BeDisabled(
        this ReferenceTypeAssertion<IElementHandle> elementHandle,
        string because = "")
    {
        var element = elementHandle.Value;
        var isDisabled = element.IsDisabled();

        if (!isDisabled)
        {
            throw new AssertException(@$"
BeDisabled Assert Exception
Actual: not disabled
Expected: disabled
Because: {because}
");
        }

        return element;
    }

    public static IElementHandle BeEditable(
        this ReferenceTypeAssertion<IElementHandle> elementHandle,
        string because = "")
    {
        var element = elementHandle.Value;
        var isEditable = element.IsEditable();

        if (!isEditable)
        {
            throw new AssertException(@$"
BeEditable Assert Exception
Actual: not editable
Expected: editable
Because: {because}
");
        }

        return element;
    }

    public static IElementHandle BeEnabled(
        this ReferenceTypeAssertion<IElementHandle> elementHandle,
        string because = "")
    {
        var element = elementHandle.Value;
        var isEnabled = element.IsEnabled();

        if (!isEnabled)
        {
            throw new AssertException(@$"
BeEnabled Assert Exception
Actual: not enabled
Expected: enabled
Because: {because}
");
        }

        return element;
    }

    public static IElementHandle BeHidden(
        this ReferenceTypeAssertion<IElementHandle> elementHandle,
        string because = "")
    {
        var element = elementHandle.Value;
        var isHidden = element.IsHidden();

        if (!isHidden)
        {
            throw new AssertException(@$"
BeHidden Assert Exception
Actual: not hidden
Expected: hidden
Because: {because}
");
        }

        return element;
    }

    public static IElementHandle BeVisible(
        this ReferenceTypeAssertion<IElementHandle> elementHandle,
        string because = "")
    {
        var element = elementHandle.Value;
        var isVisible = element.IsVisible();

        if (!isVisible)
        {
            throw new AssertException(@$"
BeVisible Assert Exception
Actual: not visible
Expected: visible
Because: {because}
");
        }

        return element;
    }
}
