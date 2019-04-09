using AventStack.ExtentReports;
using AventStack.ExtentReports.Reporter;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning2019
{
    [TestClass]
    public class ExtentReportDemo
    {

        //just run Test and open Extent Dashboard folder from the project

        [TestMethod]
        public void ExtentTestCase()
        {
            var htmlReporter = new ExtentHtmlReporter("extentReport.html");
            var extent = new ExtentReports();

            //if you want to write real values for OS, Host and Browser
            //string hostname = Dns.GetHostname();
            //OperatingSystem os = Environment.OSVersion;

            //hard coding
            //instead of Windows 10 put os.ToString()
            extent.AddSystemInfo("Operating System: ", "Windows 10");
            //instead of Selenium PC put hostname
            extent.AddSystemInfo("HostName: ", "Selenium PC");
            extent.AddSystemInfo("Browser: ", "Google Chrome");

            var test = extent.CreateTest("ExtentTestCase");
            test.Log(Status.Info, "Step 1: Test case starts");
            test.Log(Status.Pass, "Step 2: Test case Passed");
            test.Log(Status.Fail, "Step 3: Test case Failed");

            test.Pass("Screenshot", MediaEntityBuilder.CreateScreenCaptureFromPath("screenshot.png").Build());
            test.Pass("Screenshot").AddScreenCaptureFromPath("screenshot.png");
            extent.Flush();
        }
    }
}
