using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CreateForm.ShareStep;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;
using static CreateForm.ShareStep.MyShareThings;

namespace CreateForm.TestCases.Login
{
	[Binding]
	public sealed class CreateFormLogin : BaseStep
	{
		public object Profile_Signup { get; private set; }

		public CreateFormLogin (MyShareThings sharedThings) : base (sharedThings)
		{
		}
		[Given(@"user is at the home page jobsdb")]
		public void GivenUserIsAtTheHomePageJobsdb()
		{
			things.GoToJobsdb();
		}

		[Given(@"Navigate to Sign Up page")]
		public void GivenNavigateToSignUpPage()
		{
			things.WaitingForElement("//A[@class='btn btn-primary fn-header-canreg'][text()='Sign up']");
			things.driver.FindElement(By.XPath("//A[@class='btn btn-primary fn-header-canreg'][text()='Sign up']")).Click();
			things.WaitingForElement("//H1[text()='Create a profile to apply for jobs and get relevant job recommendations']");
		}

		[When(@"user created a profile in form sign up")]
		public void WhenUserCreatedAProfileInFormSignUp(Table SignUp)
		{
			var signup = SignUp.CreateInstance<SignUp_Profile>();
			things.CreateProfile(SignUp);
		}

		[When(@"Click on the create profile button")]
		public void WhenClickOnTheCreateProfileButton()
		{
			things.WaitingForElement("//BUTTON[@id='reg-register-button']");
			things.driver.FindElement(By.XPath("//BUTTON[@id='reg-register-button']")).Click();
		}
		[When(@"user Input data about yourself")]
		public void WhenUserInputDataAboutYourself(Table Yourself)
		{
			var yourself = Yourself.CreateInstance<TableYourSelf>();
			things.WaitingForElement("//H2[text()='Tell us more about yourself']");
			things.InputMoreYourself(Yourself);
		}

		[When(@"Click on the continue button")]
		public void WhenClickOnTheContinueButton()
		{
			things.WaitingForElement("//BUTTON[@id='reg-continue']");
			things.driver.FindElement(By.XPath("//BUTTON[@id='reg-continue']")).Click();
			things.WaitForElementText("//H2[text()='Your profile is ready']", "Your profile is ready");
		}

		[Then(@"the user can be access to login in jobsdb for search job")]
		public void ThenTheUserCanBeAccessToLoginInJobsdbForSearchJob()
		{
			things.WaitingForElement("//H2[text()='Your profile is ready']");
			things.driver.FindElement(By.XPath("//BUTTON[@id='reg-finish']")).Click();
			things.WaitingForElement("//STRONG[@id='label_SSOUserName']");
		}

	}
}
