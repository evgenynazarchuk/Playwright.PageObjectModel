using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Playwright.PageObjectModel;

public interface ITypedBlockModel<TPageModel>
    where TPageModel : PageModel
{
    TPageModel PageModel { get; }
}
