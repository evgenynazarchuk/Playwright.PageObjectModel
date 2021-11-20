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

namespace UIPageModel;

public partial class PageModel
{
    protected virtual void Before() { }

    protected virtual void After() { }

    protected virtual void BeforeFind() { }

    protected virtual void BeforeFindElements() { }

    protected virtual void BeforeClick() { }

    protected virtual void AfterClick() { }

    protected virtual void BeforeType() { }

    protected virtual void AfterType() { }

    protected virtual void BeforeFill() { }

    protected virtual void AfterFill() { }

    protected virtual void BeforeDbClick() { }

    protected virtual void AfterDbClick() { }

    protected virtual void BeforeHower() { }

    protected virtual void AfterHower() { }

    protected virtual void BeforeCheck() { }

    protected virtual void AfterCheck() { }

    protected virtual void BeforeUncheck() { }

    protected virtual void AfterUncheck() { }

    protected virtual void BeforeSetInputFile() { }

    protected virtual void AfterSetInputFile() { }

    protected virtual void BeforeScreenshot() { }

    protected virtual void AfterScreenshot() { }

    protected virtual void BeforeSetInputFiles() { }

    protected virtual void AfterSetInputFiles() { }

    protected virtual void BeforeDragAndDrop() { }

    protected virtual void AfterHover() { }

    protected virtual void BeforeHover() { }

    protected virtual void AfterDragAndDrop() { }

    protected virtual void BeforePress() { }

    protected virtual void AfterPress() { }

    protected virtual void BeforeSelectOption() { }

    protected virtual void AfterSelectOption() { }

    protected virtual void BeforeTap() { }

    protected virtual void AfterTap() { }

    protected virtual void BeforeSetChecked() { }

    protected virtual void AfterSetChecked() { }

}
