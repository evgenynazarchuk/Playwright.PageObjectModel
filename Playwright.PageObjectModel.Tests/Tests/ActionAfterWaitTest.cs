using Microsoft.Playwright;
using Microsoft.Playwright.MSTest;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;
using System.IO;

namespace Playwright.PageObjectModel.Tests;

[TestClass]
public class ActionAfterWaitTest : PageTest
{
    [TestMethod]
    public async Task ClickAfterWait()
    {
        await Page.SetContentAsync(@"
<html>
<head>
	<script defer>
	setTimeout(() => {
	let elem = document.querySelector('#app')
	elem.innerHTML += '<button>Click</button>'
	}, 5000)
	</script>
</head>
<body>
	<div id = 'app'>
	</div>
</body>
</html>
");
		await Page.ClickAsync("//button");
    }

	[TestMethod]
	public async Task QueryAfterWait()
	{
		await Page.SetContentAsync(@"
<html>
<head>
	<script defer>
	setTimeout(() => {
	let elem = document.querySelector('#app')
	elem.innerHTML += '<button>Click</button>'
	}, 5000)
	</script>
</head>
<body>
	<div id = 'app'>
	</div>
</body>
</html>
");
		await Page.WaitForSelectorAsync("//button");
		var elem = await Page.QuerySelectorAsync("//button");
		await elem!.ClickAsync();
	}

	[TestMethod]
	public async Task TypeAfterWait()
	{
		await Page.SetContentAsync(@"
<html>
<head>
	<script defer>
	setTimeout(() => {
	let elem = document.querySelector('#app')
	elem.innerHTML += '<input/>'
	}, 5000)
	</script>
</head>
<body>
	<div id = 'app'>
	</div>
</body>
</html>
");
		await Page.TypeAsync("//input", "Hola");
	}

	[TestMethod]
	public async Task IsDisabledAfterWaitTest()
	{
		await Page.SetContentAsync(@"
<html>
<head>
	<script defer>
	setTimeout(() => {
	let elem = document.querySelector('#app')
	elem.innerHTML += '<input disabled/>'
	}, 5000)
	</script>
</head>
<body>
	<div id = 'app'>
	</div>
</body>
</html>
");
		var result = await Page.IsDisabledAsync("//input");
		Assert.IsTrue(result);
	}
}
