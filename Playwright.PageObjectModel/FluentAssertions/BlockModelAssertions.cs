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

using Playwright.Synchronization;
using System;

namespace Playwright.PageObjectModel;

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

    public static TBlockModel HaveChecked<TBlockModel>(
        this ReferenceTypeAssertion<TBlockModel> blockModel,
        string? selector = null,
        string because = "")
        where TBlockModel : BlockModel<PageModel>
    {
        bool isChecked;

        if (selector is not null)
        {
            var element = blockModel.Value.ElementHandle.QuerySelector(selector);
            if (element is null) throw new ApplicationException("Element not found");
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
Because: {because}
");
        }

        return blockModel.Value;
    }
}
