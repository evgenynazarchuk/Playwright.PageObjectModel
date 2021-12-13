using Microsoft.Playwright;
using Microsoft.Playwright.MSTest;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;
using System.IO;

namespace Playwright.PageObjectModel.Tests;

[TestClass]
public class SelectorClickTest : PageTest
{
    [TestMethod]
    public async Task ClickAfterWait()
    {
        await Page.SetContentAsync(@"
<html>
<head>
</head>
<body>
	<div class='first'>
		<div class='item'>First</div>
	</div>
	<div class='second'>
		<div class='item'>Second</div>
	</div>
</body>
</html>
");
		var elem = await Page.QuerySelectorAsync("//div[@class='second']");
		var item = await elem.QuerySelectorAsync("//div[@class='item']");
		var text = await item.InnerTextAsync();
		Assert.AreEqual("Second", text);
    }
}
