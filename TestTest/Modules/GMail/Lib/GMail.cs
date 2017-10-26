using System;
using System.Runtime.CompilerServices;
using Automation.Core.Framework.Configuration;
using Automation.Core.Framework.Controllers;
using Automation.Core.Framework.Utilities;
using Automation.Core.Framework.PageObjects.Webdriver;
using Automation.Core.Framework.Parsers;


namespace TestTest.GMail.Lib
{
    class GMail : AbstractPageCore
    {
        /// <summary>
        /// Campaign Content Panel
        /// Handles all actions for the Campagin Content Panel
        /// </summary>
        public GMail(WebdriverController webdriverController, [CallerFilePath] string callerFilePath = null) : base(webdriverController, callerFilePath)
        {
            // yml file setup
            const string gmailPath = "TestTest.Modules.GMail.Lib.GMail.yml";
            YamlParser = new YamlParser(gmailPath);

            // Go to your iFrame
            //GoToIframe("HomFrame");
        }

        public void SetLogin()
        {
            GetElement("UserName").SendKeys("vse.CuongNguyen@gmail.com");
        }

        public void SetPassword()
        {
            GetElement("Password").SendKeys("Changemenow");
        }

        public void ClickNext()
        {
            ClickElement("NextButton") ;
        }
    }
}
