using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using TechTalk.SpecFlow;

namespace CreateForm.ShareStep
{
	[Binding]
	public class BaseStep
	{
		protected MyShareThings things;

		public BaseStep (MyShareThings sharedThings)
		{
			this.things = sharedThings;
		}

		[AfterScenario("Login")]
		public void Teardown()
		{
			things.driver.Quit();
		}
	}
}
