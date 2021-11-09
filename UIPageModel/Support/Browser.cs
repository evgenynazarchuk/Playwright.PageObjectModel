using System;
using System.Threading.Tasks;
using Microsoft.Playwright;

namespace UIPageModel
{
    public class Browser
    {
        public Browser()
        {
            this.playwright = Playwright.CreateAsync().GetAwaiter().GetResult();
        }

        public virtual IBrowser GetChromium()
        {
            return this.playwright.Chromium.LaunchAsync(new() { Headless = false }).GetAwaiter().GetResult();
        }

        public virtual IBrowserContext GetNewContext()
        {
            return this.GetChromium().NewContextAsync().GetAwaiter().GetResult();
        }

        public virtual IPage GetNewPage()
        {
            return this.GetNewContext().NewPageAsync().GetAwaiter().GetResult();
        }

        protected readonly IPlaywright playwright;
    }
}
