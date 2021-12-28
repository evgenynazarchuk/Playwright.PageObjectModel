using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Playwright.PageObjectModel.Interfaces.ModelActions;
using Microsoft.Playwright;
using Playwright.PageObjectModel;
using Playwright.Synchronous;

namespace Playwright.PageObjectModel.ModelActions;

public class ElementModelActions : IElementModelActions
{
    public virtual void Wait<TPageModel>(ITypedElementModel<TPageModel> elementModel)
        where TPageModel : PageModel
    {
        elementModel.PageModel.Wait();
    }

    public virtual void WaitForLoadState<TPageModel>(
        ITypedElementModel<TPageModel> elementModel, 
        LoadState loadState,
        PageWaitForLoadStateOptions? options = null)
        where TPageModel : PageModel
    {
        elementModel.PageModel.WaitForLoadState(loadState, options);
    }

    public TPageModel UpToPage<TPageModel>(ITypedElementModel<TPageModel> elementModel)
        where TPageModel : PageModel
    {
        return elementModel.PageModel;
    }

    public virtual IElementHandle GetElement<TPageModel>(
        ITypedElementModel<TPageModel> elementModel, 
        string selector, 
        ElementHandleWaitForSelectorOptions? options = null)
        where TPageModel : PageModel
    {
        elementModel.Element.WaitForSelector(selector, options);
        var element = elementModel.Element.QuerySelector(selector);
        return element!;
    }

    public virtual TElementModel GeTElementModel<TElementModel>(string selector)
        where TElementModel : class
    {
        var blockType = typeof(TElementModel);
        var ctorArgs = new[] { typeof(ElementModel<TPageModel>), typeof(string) };

        var ctor = blockType.GetConstructor(ctorArgs);
        if (ctor is null) throw new ApplicationException("Block Model not found");

        var block = ctor.Invoke(new[] { this, (object)selector });
        if (block is null) throw new ApplicationException("Block Model not created");

        return (TElementModel)block;
    }

    public virtual IReadOnlyList<IElementHandle> GetElements(string selector, ElementHandleWaitForSelectorOptions? options = null)
    {
        var elements = this.Block.QuerySelectorAll(selector);
        return elements;
    }

    public virtual IReadOnlyCollection<TElementModel> GetBlocks<TElementModel>(string selector)
        where TElementModel : class
    {
        var elements = this.Block.QuerySelectorAll(selector);
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

    public virtual IElementHandle? GetElementOrNull(string selector)
    {
        var element = this.Block.QuerySelector(selector);
        return element;
    }

    public virtual TElementModel? GeTElementModelOrNull<TElementModel>(string selector)
        where TElementModel : class
    {
        var blockType = typeof(TElementModel);
        var ctorArgs = new[] { this.GetType(), typeof(string) };
        var ctor = blockType.GetConstructor(ctorArgs);
        if (ctor is null) throw new ApplicationException("Block Model not found");

        object? block = null;
        try
        {
            block = ctor.Invoke(new[] { this, (object)selector });
        }
        catch { }

        return (TElementModel?)block;
    }

    public virtual void Click(string? selector = null, ElementHandleClickOptions? options = null)
    {
        var element = selector is null ? this.Block : this.GetElement(selector);
        element.Click(options);
    }

    public virtual TReturnPage Click<TReturnPage>(string? selector = null, ElementHandleClickOptions? options = null)
        where TReturnPage : PageModel
    {
        this.Click(selector, options);

        var ctor = typeof(TReturnPage).GetConstructor(new[] { typeof(IPage) });
        if (ctor is null) throw new ApplicationException("Page Model not found");
        var returnPage = ctor.Invoke(new[] { pageModel.Page });

        return (TReturnPage)returnPage;
    }

    public virtual void DbClick(string? selector = null, ElementHandleDblClickOptions? options = null)
    {
        var element = selector is null ? this.Block : this.GetElement(selector);
        element.DblClick(options);
    }

    public virtual void Hover(string? selector = null, ElementHandleHoverOptions? options = null)
    {
        var element = selector is null ? this.Block : this.GetElement(selector);
        element.Hover(options);
    }

    public virtual void ClearInput(string? selector = null)
    {
        var element = selector is null ? this.Block : this.GetElement(selector);
        element.Evaluate("(element) => element.value =''", element);
    }

    public virtual void Type(string? selector = null, string value = "", ElementHandleTypeOptions? options = null)
    {
        var element = selector is null ? this.Block : this.GetElement(selector);
        element.Type(value, options);
    }

    public virtual void Fill(string? selector = null, string value = "", ElementHandleFillOptions? options = null)
    {
        var element = selector is null ? this.Block : this.GetElement(selector);
        element.Fill(value, options);
    }

    public virtual void Check(string? selector = null, ElementHandleCheckOptions? options = null)
    {
        var element = selector is null ? this.Block : this.GetElement(selector);
        element.Check(options);
    }

    public virtual void Uncheck(string? selector = null, ElementHandleUncheckOptions? options = null)
    {
        var element = selector is null ? this.Block : this.GetElement(selector);
        element.Uncheck(options);
    }

    public virtual void Focus(string? selector = null)
    {
        var element = selector is null ? this.Block : this.GetElement(selector);
        element.Focus();
    }

    public virtual void Tap(string? selector = null, ElementHandleTapOptions? options = null)
    {
        var element = selector is null ? this.Block : this.GetElement(selector);
        element.Tap(options);
    }

    public virtual void Press(string key, string? selector = null, ElementHandlePressOptions? options = null)
    {
        var element = selector is null ? this.Block : this.GetElement(selector);
        element.Press(key, options);
    }

    public virtual void SelectText(string? selector = null, ElementHandleSelectTextOptions? options = null)
    {
        var element = selector is null ? this.Block : this.GetElement(selector);
        element.SelectText(options);
    }

    public virtual void SetChecked(bool checkedState, string? selector = null, ElementHandleSetCheckedOptions? options = null)
    {
        var element = selector is null ? this.Block : this.GetElement(selector);
        element.SetChecked(checkedState);
    }

    public virtual void SetInputFiles(string files, string? selector = null, ElementHandleSetInputFilesOptions? options = null)
    {
        var element = selector is null ? this.Block : this.GetElement(selector);
        element.SetInputFiles(files, options);
    }

    public virtual void SetInputFiles(FilePayload files, string? selector = null, ElementHandleSetInputFilesOptions? options = null)
    {
        var element = selector is null ? this.Block : this.GetElement(selector);
        element.SetInputFiles(files, options);
    }

    public virtual void SetInputFiles(IEnumerable<string> files, string? selector = null, ElementHandleSetInputFilesOptions? options = null)
    {
        var element = selector is null ? this.Block : this.GetElement(selector);
        element.SetInputFiles(files, options);
    }

    public virtual void SetInputFiles(IEnumerable<FilePayload> files, string? selector = null, ElementHandleSetInputFilesOptions? options = null)
    {
        var element = selector is null ? this.Block : this.GetElement(selector);
        element.SetInputFiles(files, options);
    }

    public virtual IReadOnlyList<string> SelectOption(string values, string? selector = null, ElementHandleSelectOptionOptions? options = null)
    {
        var element = selector is null ? this.Block : this.GetElement(selector);
        var result = element.SelectOption(values, options);
        return result;
    }

    public virtual IReadOnlyList<string> SelectOption(IElementHandle values, string? selector = null, ElementHandleSelectOptionOptions? options = null)
    {
        var element = selector is null ? this.Block : this.GetElement(selector);
        var result = element.SelectOption(values, options);
        return result;
    }

    public virtual IReadOnlyList<string> SelectOption(IEnumerable<string> values, string? selector = null, ElementHandleSelectOptionOptions? options = null)
    {
        var element = selector is null ? this.Block : this.GetElement(selector);
        var result = element.SelectOption(values, options);
        return result;
    }

    public virtual IReadOnlyList<string> SelectOption(SelectOptionValue values, string? selector = null, ElementHandleSelectOptionOptions? options = null)
    {
        var element = selector is null ? this.Block : this.GetElement(selector);
        var result = element.SelectOption(values, options);
        return result;
    }

    public virtual IReadOnlyList<string> SelectOption(IEnumerable<IElementHandle> values, string? selector = null, ElementHandleSelectOptionOptions? options = null)
    {
        var element = selector is null ? this.Block : this.GetElement(selector);
        var result = element.SelectOption(values, options);
        return result;
    }

    public virtual IReadOnlyList<string> SelectOption(IEnumerable<SelectOptionValue> values, string? selector = null, ElementHandleSelectOptionOptions? options = null)
    {
        var element = selector is null ? this.Block : this.GetElement(selector);
        var result = element.SelectOption(values, options);
        return result;
    }

    public virtual void ScrollIntoViewIfNeeded(string? selector = null, ElementHandleScrollIntoViewIfNeededOptions? options = null)
    {
        var element = selector is null ? this.Block : this.GetElement(selector);
        element.ScrollIntoViewIfNeeded(options);
    }

    public virtual void Screenshot(string? selector = null, ElementHandleScreenshotOptions? options = null)
    {
        var element = selector is null ? this.Block : this.GetElement(selector);
        element.Screenshot(options);
    }

    public virtual string TextContent(string? selector = null)
    {
        var element = selector is null ? this.Block : this.GetElement(selector);
        return element.TextContent() ?? "";
    }

    public virtual string InnerText(string? selector = null)
    {
        var element = selector is null ? this.Block : this.GetElement(selector);
        return element.InnerText();
    }

    public virtual string InnerHTML(string? selector = null)
    {
        var element = selector is null ? this.Block : this.GetElement(selector);
        return element.InnerHTML();
    }

    public virtual string InputValue(string? selector = null, ElementHandleInputValueOptions? options = null)
    {
        var element = selector is null ? this.Block : this.GetElement(selector);
        return element.InputValue(options);
    }

    public virtual bool IsChecked(string? selector = null)
    {
        var element = selector is null ? this.Block : this.GetElement(selector);
        return element.IsChecked();
    }

    public virtual bool IsDisabled(string? selector = null)
    {
        var element = selector is null ? this.Block : this.GetElement(selector);
        return element.IsDisabled();
    }

    public virtual bool IsEditable(string? selector = null)
    {
        var element = selector is null ? this.Block : this.GetElement(selector);
        return element.IsEditable();
    }

    public virtual bool IsEnabled(string? selector = null)
    {
        var element = selector is null ? this.Block : this.GetElement(selector);
        return element.IsEnabled();
    }

    public virtual bool IsHidden(string? selector = null)
    {
        var element = selector is null ? this.Block : this.GetElement(selector);
        return element.IsHidden();
    }

    public virtual bool IsVisible(string? selector = null)
    {
        var element = selector is null ? this.Block : this.GetElement(selector);
        return element.IsVisible();
    }

    public virtual ElementHandleBoundingBoxResult? BoundingBox(string? selector = null)
    {
        var element = selector is null ? this.Block : this.GetElement(selector);
        return element.BoundingBox();
    }

    public virtual IFrame? ContentFrame(string? selector = null)
    {
        var element = selector is null ? this.Block : this.GetElement(selector);
        return element.ContentFrame();
    }

    public virtual void DispatchEvent(string type, string? selector = null, object? eventInit = null)
    {
        var element = selector is null ? this.Block : this.GetElement(selector);
        element.DispatchEvent(type);
    }

    public virtual T EvalOnSelector<T>(string selector, string expression, object? arg = null)
    {
        return this.Block.EvalOnSelector<T>(selector, expression, arg);
    }

    public virtual T EvalOnSelectorAll<T>(string selector, string expression, object? arg = null)
    {
        return this.Block.EvalOnSelectorAll<T>(selector, expression, arg);
    }

    public virtual JsonElement? EvalOnSelector(string selector, string expression, object? arg = null)
    {
        return this.Block.EvalOnSelector(selector, expression, arg);
    }

    public string? GetAttributeValue(string name, string? selector = null)
    {
        var element = selector is null ? this.Block : this.GetElement(selector);
        return element.GetAttribute(name);
    }

    public string GetComputedStyle(string name, string? selector = null)
    {
        var element = selector is null ? this.Block : GetElement(selector);
        var value = Block.Evaluate<string>($"e => getComputedStyle(e).{name}", element);
        return value;
    }

    public virtual IFrame? OwnerFrame(string? selector = null)
    {
        var element = selector is null ? this.Block : this.GetElement(selector);
        return element.OwnerFrame();
    }
}
