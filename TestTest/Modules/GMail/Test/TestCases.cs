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

        public TestCases()
        {
        }

        [SetUp]
        public void SetUp()
        {
            ApplitoolsController.Instance.Init("TestTest.Modules.GMail.Lib.Eyes.yml");
            ApplitoolsController.Instance.Open(wdc.ProtractorDriver, "appName", "testName2");
            ApplitoolsController.Instance.SetBatchName("TestBatch");
            ApplitoolsController.Instance.SetMatchLevel("Layout");
        }
        
        [TearDown]
        public void Teardown()
        {
            wdc.Dispose();
            ApplitoolsController.Instance.Dispose();
        }
        
        [Test]
        public void TestApplitools()
        {
            
            GMail gmail = new GMail(wdc);

            ApplitoolsController.Instance.CheckWindow("Window1");

            gmail.SetLogin();


            ApplitoolsController.Instance.CheckWindow("Window2");

            gmail.ClickNext();


            ApplitoolsController.Instance.CheckWindow("Window3");

            gmail.SetPassword();


            ApplitoolsController.Instance.CheckWindow("Window4");


            gmail.ClickNext();


            ApplitoolsController.Instance.CheckWindow("Window5");

            //ApplitoolsController.Instance.CheckElement("Element1", "Element1");
            //ApplitoolsController.Instance.CheckElement("Element2", "Element2");
            //ApplitoolsController.Instance.CheckRegionInFrame(":2p", "Region1", "Region1");


        }
    }
}
