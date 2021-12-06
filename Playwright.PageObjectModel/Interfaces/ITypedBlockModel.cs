namespace Playwright.PageObjectModel;

public interface ITypedBlockModel<TPageModel>
    where TPageModel : PageModel
{
    TPageModel PageModel { get; }
}
