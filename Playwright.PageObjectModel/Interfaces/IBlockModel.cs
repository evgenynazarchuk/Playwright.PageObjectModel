using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Playwright;

namespace Playwright.PageObjectModel;

public interface IBlockModel
{
    IElementHandle Block { get; }
}