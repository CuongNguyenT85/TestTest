using Automation.Core.Framework.Controllers;
using NUnit.Framework;
using Automation.Core.Framework.TestFixtures;
using TestTest.GMail.Lib;

namespace ApplitoolsTest
{
    [TestFixture]
    public class TestCases : AbstractTestCore
    {
        WebdriverController wdc = new WebdriverController();

        ApplitoolsController applitools = new ApplitoolsController();

        [SetUp]
        public void SetUp()
        {
            applitools.Open(wdc.ProtractorDriver, "appName", "testName2");
            applitools.SetBatchName("TestBatch");
            applitools.SetMatchLevel("Layout");
        }
        
        [TearDown]
        public void Teardown()
        {
            wdc.Dispose();
            applitools.Dispose();
        }
        
        [Test]
        public void TestApplitools()
        {
            
            GMail gmail = new GMail(wdc);

            applitools.CheckWindow("Window1");

            gmail.SetLogin();


            applitools.CheckWindow("Window2");

            gmail.ClickNext();


            applitools.CheckWindow("Window3");

            gmail.SetPassword();


            applitools.CheckWindow("Window4");


            gmail.ClickNext();


            applitools.CheckWindow("Window5");

            //applitools.CheckElement("Element1", "Element1");
            //applitoolse.CheckElement("Element2", "Element2");
            //applitools.CheckRegionInFrame(":2p", "Region1", "Region1");


        }
    }
}
