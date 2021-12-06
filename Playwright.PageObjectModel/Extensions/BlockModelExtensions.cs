using Microsoft.Playwright;
using Playwright.Synchronous;

namespace Playwright.PageObjectModel;

public static class BlockModelExtensions
{
    public static TBlockModel Screenshot<TBlockModel>(this TBlockModel blockModel, ElementHandleScreenshotOptions? options = null)
        where TBlockModel : IBlockModel, IWaiter
    {
        blockModel.WaitForLoadPage();
        blockModel.Block.Screenshot(options);
        return blockModel;
    }
}
