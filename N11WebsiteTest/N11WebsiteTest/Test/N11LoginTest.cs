using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using N11WebsiteTest.Helper;
using N11WebsiteTest.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N11WebsiteTest.Test
{
    class N11LoginTest
    {

        IWebDriver webDriver;

        public object TimeUnit { get; private set; }

  
        [SetUp]
        public void InitializeBrowser()

        {
            webDriver = BrowserFactory.StartBrowser("chrome", "https://www.n11.com/");

        }

        [Test]
        public void TestN11Login()
        {
            HomePage ObjHome = new HomePage(webDriver);
            LoginPage ObjLogin = new LoginPage(webDriver);

            //N11 User Login is here. 
            ObjLogin.LoginIntoN11("Here enter Username", "Here enter Password");
            ObjHome.Search("Samsung");
            ObjHome.getPage();
            ObjHome.addFavorite();
            ObjHome.navigateAccount();
            ObjHome.navigateWishesList();
            ObjHome.listFavorite();
            ObjHome.deleteFavItem();
            ObjHome.confirm();
        }

    }
}
