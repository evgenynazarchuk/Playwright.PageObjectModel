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
using System;
using System.Collections.Generic;
using System.Text.Json;

namespace Playwright.PageObjectModel;

public partial class ElementModel<TPageModel> : IElementModel, ITypedElementModel<TPageModel>
    where TPageModel : PageModel
{
    public IPage Page { get; }

    public IElementHandle Element { get; }

    public TPageModel PageModel { get; }

    public ElementModel(TPageModel pageModel, 
        string selector, 
        PageWaitForSelectorOptions? waitOptions = null, 
        PageQuerySelectorOptions? queryOptions = null)
    {
        this.PageModel = pageModel;
        this.PageModel.Page.WaitForSelector(selector, waitOptions);
        this.Element = this.PageModel.Page.QuerySelector(selector, queryOptions)!;
        this.PageModel = pageModel;
        this.Page = this.PageModel.Page;
    }

    public ElementModel(ElementModel<TPageModel> parentElementModel, 
        string selector, 
        ElementHandleWaitForSelectorOptions? waitOptions = null)
    {
        this.Element = parentElementModel.GetElement(selector, waitOptions);
        this.PageModel = parentElementModel.PageModel;
        this.Page = this.PageModel.Page;
    }

    public ElementModel(TPageModel pageModel, IElementHandle element)
    {
        this.PageModel = pageModel;
        this.Element = element;
        this.Page = this.PageModel.Page;
    }

    public ElementModel(ElementModel<TPageModel> parenTElementModel, IElementHandle element)
    {
        this.PageModel = parenTElementModel.PageModel;
        this.Element = element;
        this.Page = this.PageModel.Page;
    }

    public TPageModel UpToPage()
    {
        return this.PageModel;
    }

    protected virtual IElementHandle GetElement(string selector, ElementHandleWaitForSelectorOptions? options = null)
    {
        this.Element.WaitForSelector(selector, options);
        var element = this.Element.QuerySelector(selector);
        return element!;
    }

    protected virtual IElementHandle? GetElementOrNull(string selector)
    {
        var element = this.Element.QuerySelector(selector);
        return element;
    }

    protected virtual IReadOnlyList<IElementHandle> GetElements(string selector, ElementHandleWaitForSelectorOptions? options = null)
    {
        var elements = this.Element.QuerySelectorAll(selector);
        return elements;
    }

    protected virtual TElementModel GetElementModel<TElementModel>(string selector)
        where TElementModel : ITypedElementModel<TPageModel>
    {
        var blockType = typeof(TElementModel);
        var ctorArgs = new[] { typeof(ElementModel<TPageModel>), typeof(string) };

        var ctor = blockType.GetConstructor(ctorArgs);
        if (ctor is null) throw new ApplicationException("Block Model not found");

        var block = ctor.Invoke(new[] { this, (object)selector });
        if (block is null) throw new ApplicationException("Block Model not created");

        return (TElementModel)block;
    }

    protected virtual IReadOnlyCollection<TElementModel> GetElementModels<TElementModel>(string selector)
        where TElementModel : ITypedElementModel<TPageModel>
    {
        var elements = this.Element.QuerySelectorAll(selector);
        var blocks = new List<TElementModel>();

        foreach (var element in elements)
        {
            var blockType = typeof(TElementModel);
            var ctorArgs = new[] { this.GetType(), typeof(string) };
            var ctor = blockType.GetConstructor(ctorArgs);
            if (ctor is null) throw new ApplicationException("Block Model not found");

            var block = ctor.Invoke(new[] { this, (object)selector });

            blocks.Add((TElementModel)block);
        }

        return blocks;
    }

    protected virtual void Click(string? selector = null, ElementHandleClickOptions? options = null)
    {
        var element = selector is null ? this.Element : this.GetElement(selector);
        element.Click(options);
    }

    protected virtual TReturnPage Click<TReturnPage>(string? selector = null, ElementHandleClickOptions? options = null)
        where TReturnPage : PageModel
    {
        this.Click(selector, options);

        var ctor = typeof(TReturnPage).GetConstructor(new[] { typeof(IPage) });
        if (ctor is null) throw new ApplicationException("Page Model not found");
        var returnPage = ctor.Invoke(new[] { this.PageModel.Page });
        if (returnPage is null) throw new ApplicationException("Page Model not created");

        return (TReturnPage)returnPage;
    }

    protected virtual void DbClick(string? selector = null, ElementHandleDblClickOptions? options = null)
    {
        var element = selector is null ? this.Element : this.GetElement(selector);
        element.DblClick(options);
    }

    protected virtual void Hover(string? selector = null, ElementHandleHoverOptions? options = null)
    {
        var element = selector is null ? this.Element : this.GetElement(selector);
        element.Hover(options);
    }

    protected virtual void ClearInput(string? selector = null)
    {
        var element = selector is null ? this.Element : this.GetElement(selector);
        element.Evaluate("(element) => element.value =''", element);
    }

    protected virtual void Type(string? selector = null, string value = "", ElementHandleTypeOptions? options = null)
    {
        var element = selector is null ? this.Element : this.GetElement(selector);
        element.Type(value, options);
    }

    protected virtual void Fill(string? selector = null, string value = "", ElementHandleFillOptions? options = null)
    {
        var element = selector is null ? this.Element : this.GetElement(selector);
        element.Fill(value, options);
    }

    protected virtual void Check(string? selector = null, ElementHandleCheckOptions? options = null)
    {
        var element = selector is null ? this.Element : this.GetElement(selector);
        element.Check(options);
    }

    protected virtual void Uncheck(string? selector = null, ElementHandleUncheckOptions? options = null)
    {
        var element = selector is null ? this.Element : this.GetElement(selector);
        element.Uncheck(options);
    }

    protected virtual void Focus(string? selector = null)
    {
        var element = selector is null ? this.Element : this.GetElement(selector);
        element.Focus();
    }

    protected virtual void Tap(string? selector = null, ElementHandleTapOptions? options = null)
    {
        var element = selector is null ? this.Element : this.GetElement(selector);
        element.Tap(options);
    }

    protected virtual void Press(string key, string? selector = null, ElementHandlePressOptions? options = null)
    {
        var element = selector is null ? this.Element : this.GetElement(selector);
        element.Press(key, options);
    }

    protected virtual void SelectText(string? selector = null, ElementHandleSelectTextOptions? options = null)
    {
        var element = selector is null ? this.Element : this.GetElement(selector);
        element.SelectText(options);
    }

    protected virtual void SetChecked(bool checkedState, string? selector = null, ElementHandleSetCheckedOptions? options = null)
    {
        var element = selector is null ? this.Element : this.GetElement(selector);
        element.SetChecked(checkedState);
    }

    protected virtual void SetInputFiles(string files, string? selector = null, ElementHandleSetInputFilesOptions? options = null)
    {
        var element = selector is null ? this.Element : this.GetElement(selector);
        element.SetInputFiles(files, options);
    }

    protected virtual void SetInputFiles(FilePayload files, string? selector = null, ElementHandleSetInputFilesOptions? options = null)
    {
        var element = selector is null ? this.Element : this.GetElement(selector);
        element.SetInputFiles(files, options);
    }

    protected virtual void SetInputFiles(IEnumerable<string> files, string? selector = null, ElementHandleSetInputFilesOptions? options = null)
    {
        var element = selector is null ? this.Element : this.GetElement(selector);
        element.SetInputFiles(files, options);
    }

    protected virtual void SetInputFiles(IEnumerable<FilePayload> files, string? selector = null, ElementHandleSetInputFilesOptions? options = null)
    {
        var element = selector is null ? this.Element : this.GetElement(selector);
        element.SetInputFiles(files, options);
    }

    protected virtual void SelectOption(string values, string? selector = null, ElementHandleSelectOptionOptions? options = null)
    {
        var element = selector is null ? this.Element : this.GetElement(selector);
        element.SelectOption(values, options);
    }

    protected virtual void SelectOption(IElementHandle values, string? selector = null, ElementHandleSelectOptionOptions? options = null)
    {
        var element = selector is null ? this.Element : this.GetElement(selector);
        element.SelectOption(values, options);
    }

    protected virtual void SelectOption(IEnumerable<string> values, string? selector = null, ElementHandleSelectOptionOptions? options = null)
    {
        var element = selector is null ? this.Element : this.GetElement(selector);
        element.SelectOption(values, options);
    }

    protected virtual void SelectOption(SelectOptionValue values, string? selector = null, ElementHandleSelectOptionOptions? options = null)
    {
        var element = selector is null ? this.Element : this.GetElement(selector);
        element.SelectOption(values, options);
    }

    protected virtual void SelectOption(IEnumerable<IElementHandle> values, string? selector = null, ElementHandleSelectOptionOptions? options = null)
    {
        var element = selector is null ? this.Element : this.GetElement(selector);
        element.SelectOption(values, options);
    }

    protected virtual void SelectOption(IEnumerable<SelectOptionValue> values, string? selector = null, ElementHandleSelectOptionOptions? options = null)
    {
        var element = selector is null ? this.Element : this.GetElement(selector);
        element.SelectOption(values, options);
    }

    protected virtual void ScrollIntoViewIfNeeded(string? selector = null, ElementHandleScrollIntoViewIfNeededOptions? options = null)
    {
        var element = selector is null ? this.Element : this.GetElement(selector);
        element.ScrollIntoViewIfNeeded(options);
    }

    protected virtual void Screenshot(string? selector = null, ElementHandleScreenshotOptions? options = null)
    {
        var element = selector is null ? this.Element : this.GetElement(selector);
        element.Screenshot(options);
    }

    protected virtual string TextContent(string? selector = null)
    {
        var element = selector is null ? this.Element : this.GetElement(selector);
        return element.TextContent() ?? "";
    }

    protected virtual string InnerText(string? selector = null)
    {
        var element = selector is null ? this.Element : this.GetElement(selector);
        return element.InnerText();
    }

    protected virtual string InnerHTML(string? selector = null)
    {
        var element = selector is null ? this.Element : this.GetElement(selector);
        return element.InnerHTML();
    }

    protected virtual string InputValue(string? selector = null, ElementHandleInputValueOptions? options = null)
    {
        var element = selector is null ? this.Element : this.GetElement(selector);
        return element.InputValue(options);
    }

    protected virtual bool IsChecked(string? selector = null)
    {
        var element = selector is null ? this.Element : this.GetElement(selector);
        return element.IsChecked();
    }

    protected virtual bool IsDisabled(string? selector = null)
    {
        var element = selector is null ? this.Element : this.GetElement(selector);
        return element.IsDisabled();
    }

    protected virtual bool IsEditable(string? selector = null)
    {
        var element = selector is null ? this.Element : this.GetElement(selector);
        return element.IsEditable();
    }

    protected virtual bool IsEnabled(string? selector = null)
    {
        var element = selector is null ? this.Element : this.GetElement(selector);
        return element.IsEnabled();
    }

    protected virtual bool IsHidden(string? selector = null)
    {
        var element = selector is null ? this.Element : this.GetElement(selector);
        return element.IsHidden();
    }

    protected virtual bool IsVisible(string? selector = null)
    {
        var element = selector is null ? this.Element : this.GetElement(selector);
        return element.IsVisible();
    }

    protected virtual ElementHandleBoundingBoxResult? BoundingBox(string? selector = null)
    {
        var element = selector is null ? this.Element : this.GetElement(selector);
        return element.BoundingBox();
    }

    protected virtual IFrame? ContentFrame(string? selector = null)
    {
        var element = selector is null ? this.Element : this.GetElement(selector);
        return element.ContentFrame();
    }

    protected virtual void DispatchEvent(string type, string? selector = null, object? eventInit = null)
    {
        var element = selector is null ? this.Element : this.GetElement(selector);
        element.DispatchEvent(type);
    }

    protected virtual T EvalOnSelector<T>(string selector, string expression, object? arg = null)
    {
        return this.Element.EvalOnSelector<T>(selector, expression, arg);
    }

    protected virtual T EvalOnSelectorAll<T>(string selector, string expression, object? arg = null)
    {
        return this.Element.EvalOnSelectorAll<T>(selector, expression, arg);
    }

    protected virtual JsonElement? EvalOnSelector(string selector, string expression, object? arg = null)
    {
        return this.Element.EvalOnSelector(selector, expression, arg);
    }

    protected string? GetAttributeValue(string name, string? selector = null)
    {
        var element = selector is null ? this.Element : this.GetElement(selector);
        return element.GetAttribute(name);
    }

    protected string GetComputedStyle(string name, string? selector = null)
    {
        var element = selector is null ? this.Element : GetElement(selector);
        var value = Element.Evaluate<string>($"e => getComputedStyle(e).{name}", element);
        return value;
    }

    protected virtual IFrame? OwnerFrame(string? selector = null)
    {
        var element = selector is null ? this.Element : this.GetElement(selector);
        return element.OwnerFrame();
    }
}