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

namespace UIPageModel;

public partial class BlockModel<TPageModel>
    where TPageModel : PageModel
{
    public BlockModel(TPageModel pageModel, string selector, PageQuerySelectorOptions? options = null)
    {
        this.PageModel = pageModel;
        this.HtmlBlock = this.PageModel.FindElement(selector, options);
    }

    public BlockModel(BlockModel<TPageModel> parentBlockModel, string selector)
    {
        this.PageModel = parentBlockModel.PageModel;
        this.HtmlBlock = parentBlockModel.FindElement(selector);
    }

    public BlockModel(TPageModel pageModel, IElementHandle element)
    {
        this.PageModel = pageModel;
        this.HtmlBlock = element;
    }

    public BlockModel(BlockModel<TPageModel> parentBlockModel, IElementHandle element)
    {
        this.PageModel = parentBlockModel.PageModel;
        this.HtmlBlock = element;
    }
    
    protected readonly TPageModel PageModel;

    protected readonly IElementHandle HtmlBlock;
}
