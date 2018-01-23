using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using TechTalk.SpecFlow;
using NUnit.Framework;
using System.Threading;
using TechTalk.SpecFlow.Assist;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq;
using System.Text;



namespace CreateForm.ShareStep
{
	[Binding]
	public class MyShareThings
	{
		public IWebDriver driver;
		public string xpath;

		public void GoToJobsdb()
		{
			driver = new ChromeDriver();
			driver.Navigate().GoToUrl("https://id.jobsdb.com/id");

			WaitingForElement("//A[@class='navbar-brand-logo'][text()='jobsDB']");

			driver.FindElement(By.Id("PrimaryLanguageButton")).Click();
		}

		public void WaitForElementText(string param, string value)
		{
			WaitingForElement(param);
			Assert.IsTrue(driver.FindElement(By.XPath(param)).Displayed);
			Assert.AreEqual(driver.FindElement(By.XPath(param)).Text, value);
		}

		public void WaitingForElement(string param)
		{
			TimeSpan time = TimeSpan.FromSeconds(50);
			WebDriverWait waitHome = new WebDriverWait(driver, time);

			IWebElement elementHome = waitHome.Until(ExpectedConditions.ElementIsVisible(By.XPath(param)));
		}
		public class SignUp_Profile
		{
			public string First_name { get; set; }
			public string Last_name { get; set; }
			public string Email { get; set; }
			public string Password { get; set; }
		}
	
		public void InputMoreYourself(Table Yourself_more)
		{

			var Yourself = Yourself_more.CreateInstance<TableYourSelf>();

			driver.FindElement(By.LinkText("Please select")).Click();
			driver.FindElement(By.Id("reg-careerexp-dropdown-item-c_JsPeP1S2ItDap_YrOfWkEe0_3")).Click();

			driver.FindElement(By.XPath("//INPUT[@id='c_JsPeP1S2ItDap_Pn0']")).SendKeys(Yourself.What_is_your_latest_job);
			driver.FindElement(By.XPath("//input[@id='c_JsPeP1S2ItDap_Cy0']")).SendKeys(Yourself.Who_is_your_latest_employer);

			driver.FindElement(By.LinkText("Month")).Click();
			driver.FindElement(By.Id("reg-startmonth-dropdown-item--c_JsPeP1S2ItDap_EtPdStMh0_1")).Click();

			driver.FindElement(By.LinkText("Year")).Click();
			driver.FindElement(By.Id("reg-startyear-dropdown-item--c_JsPeP1S2ItDap_EtPdStYr0_2017")).Click();

			driver.FindElement(By.LinkText("Please select")).Click();
			driver.FindElement(By.Id("reg-jobcat-dropdown-item--c_JsPeP1S2ItDap_JbFn0_131")).Click();

			WaitingForElement("//a[@id='reg-jobcatLv2-display_131']");
			driver.FindElement(By.LinkText("Please select")).Click();
			driver.FindElement(By.XPath("//P[@id='reg-jobcatLv2-dropdown-item--c_JsPeP1S2ItDap_JbF20_137']")).Click();

			WaitingForElement("//a[@id='reg-jobind-display']//span[.='Please select']");
			driver.FindElement(By.LinkText("Please select")).Click();
			driver.FindElement(By.Id("reg-jobind-dropdown-item--c_JsPeP1S2ItDap_Iy0_15")).Click();

			driver.FindElement(By.LinkText("Monthly")).Click();
			driver.FindElement(By.Id("reg-salarytype-dropdown-item--c_JsPeP1S2ItDap_SyTe0_1")).Click();

			WaitingForElement("//input[@id='c_JsPeP1S2ItDap_SyFm0']");
			driver.FindElement(By.XPath("//input[@id='c_JsPeP1S2ItDap_SyFm0']")).SendKeys("4000000");
			WaitingForElement("//input[@id='c_JsPeP1S2ItDap_SyTo0']");
			driver.FindElement(By.XPath("//input[@id='c_JsPeP1S2ItDap_SyTo0']")).SendKeys("5000000");

			WaitingForElement("//a[@id='reg-edulv-display']//span[.='Please select']");
			driver.FindElement(By.LinkText("Please select")).Click();
			driver.FindElement(By.Id("reg-edulv-dropdown-item-c_JsPeP1S2ItDap_HtEnLl0_13")).Click();

			WaitingForElement("//p[@id='reg-nation-display']");
			driver.FindElement(By.LinkText("Please select")).Click();
			driver.FindElement(By.Id("reg-resideLv1-dropdown-item-c_JsPeP1S2ItDap_CyOfRe0_4")).Click();

			driver.FindElement(By.LinkText("Please select")).Click();
			driver.FindElement(By.Id("reg-resideLv2-dropdown-item-c_JsPeP1S2ItDap_LnId0_367")).Click();

			WaitingForElement("//a[@id='reg-resideLv3-display_367']");
			driver.FindElement(By.LinkText("Please select")).Click();
			driver.FindElement(By.XPath("//p[@id='reg-resideLv3-dropdown-item-c_JsPeP1S2ItDap_L3Id0_372']")).Click();
		}

		public class TableYourSelf
		{
			public string What_is_your_latest_job { get; set; }
			public string Who_is_your_latest_employer { get; set; }
			public string Rp { get; set; }
			public string to { get; set; }

		}

		public void CreateProfile(Table Profile_SignUp)
		{
			var signup = Profile_SignUp.CreateInstance<SignUp_Profile>();

			driver.FindElement(By.XPath("//INPUT[@id='c_P1RnItDap_GnNe0']")).SendKeys(signup.First_name);
			driver.FindElement(By.XPath("//INPUT[@id='c_P1RnItDap_FyNe0']")).SendKeys(signup.Last_name);
			driver.FindElement(By.XPath("//INPUT[@id='c_P1RnItDap_El0']")).SendKeys(signup.Email);
			driver.FindElement(By.XPath("//INPUT[@id='c_P1RnItDap_Pd0']")).SendKeys(signup.Password);
		}

		
	}
}

