using Microsoft.Playwright;
using Microsoft.Playwright.NUnit;

namespace PWNunit
{
    public class GHPTests : PageTest//Class inside playright
    {
        [SetUp]
        public void Setup()
        {
        }

      /*  [Test]
        public async Task Test1()
        {



            //playwight startup
            using var playwright = await Playwright.CreateAsync();


            //launch browser
            await using var browser = await playwright.Chromium.LaunchAsync(
                new BrowserTypeLaunchOptions
                {
                    Headless = false
                }
                );


            //page instance
            var context = await browser.NewContextAsync();
            var page = await context.NewPageAsync();


            Console.WriteLine("Opened Browse");
            await page.GotoAsync("https://www.google.com");
            Console.WriteLine("Page loaded");

            string title = await page.TitleAsync();
            Console.WriteLine(title);

            //await page.GetByTitle("Search").FillAsync("hp laptop");
            await page.Locator("#APjFqb").FillAsync("selenium");
            Console.WriteLine("typed");

            await page.Locator("(//input[@value='Google Search'])[2]").ClickAsync();
            Console.WriteLine("Clicked");

            title = await page.TitleAsync();
            Console.WriteLine(title);


            //await page.GetByRole('button').ClickAsync();
            //Console.WriteLine("Clicked");

            //await page.GetByText("")

        }
    }
}*/
        [Test]
    public async Task Test2()
    {



        //playwight startup
        //using var playwright = await Playwright.CreateAsync();


        ////launch browser
        //await using var browser = await playwright.Chromium.LaunchAsync();


        ////page instance
        //var context = await browser.NewContextAsync();
        //var page = await context.NewPageAsync();


        Console.WriteLine("Opened Browse");
        await Page.GotoAsync("https://www.google.com");
        Console.WriteLine("Page loaded");

        string title = await Page.TitleAsync();
        Console.WriteLine(title);

        //await page.GetByTitle("Search").FillAsync("hp laptop");
        await Page.Locator("#APjFqb").FillAsync("selenium");
        Console.WriteLine("typed");

        await Page.Locator("(//input[@value='Google Search'])[2]").ClickAsync();
        Console.WriteLine("Clicked");

            await Expect(Page).ToHaveTitleAsync("selenium - Google Search");

       // title = await Page.TitleAsync();
       // Console.WriteLine(title);




            //await page.GetByRole('button').ClickAsync();
            //Console.WriteLine("Clicked");

            //await page.GetByText("")
            //Assert.That(title, Does.Contain("selenium"));
            // Expect((ILocator)Page.Equals("selenium");



    }
}

}