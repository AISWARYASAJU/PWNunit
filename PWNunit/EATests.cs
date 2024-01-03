using Microsoft.Playwright;
using Microsoft.Playwright.NUnit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PWNunit 
{
    [TestFixture]
    internal class EATests: PageTest
    {
        [Test]
        public async Task LoginTest()
        {
            Console.WriteLine("Opened Browser");
            await Page.GotoAsync("http://eaapp.somee.com/");
            Console.WriteLine("Page loaded");

            //var lnkLogin = Page.Locator(selector: "text=Login");
            //await lnkLogin.ClickAsync();

            await Page.ClickAsync(selector: "text=Login");
           // await Page.GetByText("Login").ClickAsync();// asynchronous so giving await
            await Console.Out.WriteLineAsync("Link Clicked");

            await Expect(Page).ToHaveURLAsync("http://eaapp.somee.com/Account/Login");

            ////await Page.GetByLabel("UserName").FillAsync(value: "admin");
            ////await Page.GetByLabel("Password").FillAsync(value: "password");
            ////await Console.Out.WriteLineAsync("Typed");
            ///

            //await Page.Locator("#UserName").FillAsync(value: "admin");
            //await Page.Locator("#Password").FillAsync(value: "password");
            //await Console.Out.WriteLineAsync("Typed");

            await Page.FillAsync(selector: "#UserName", "admin");
            await Page.FillAsync(selector: "#Password", "password");
            await Console.Out.WriteLineAsync("Typed");


            var btnLogin = Page.Locator(selector: "input", new PageLocatorOptions()

            { HasTextString = "Log in" });

            await  btnLogin.ClickAsync();
            //await Page.Locator("//input[@value='Log in']").ClickAsync();
            await Console.Out.WriteLineAsync("Clicked");

            await Expect(Page).ToHaveTitleAsync("Home - Execute Automation Employee App");
        }
    }
}
