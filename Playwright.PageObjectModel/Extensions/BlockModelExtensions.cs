using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Playwright.Synchronous;
using Microsoft.Playwright;

namespace Playwright.PageObjectModel.Extensions;

public static class BlockModelExtensions
{
    public static TBlockModel Screenshot<TBlockModel>(this TBlockModel blockModel, ElementHandleScreenshotOptions? options = null)
        where TBlockModel : IBlockModel
    {
        blockModel.WaitForLoadPage();
        blockModel.Block.Screenshot(options);
        return blockModel;
    }
}
