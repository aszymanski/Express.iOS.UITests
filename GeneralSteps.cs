using Xamarin.UITest;
using Xamarin.UITest.Utils;
using Xamarin.UITest.iOS;
using TechTalk.SpecFlow;

namespace Express.iOS.UITests
{
	[Binding]
	public class GeneralSteps
	{
		iOSApp app;

		[BeforeScenario]
		public void SetUp()
		{
			//app = ConfigureApp.iOS.AppBundle("../../Express.iOS.app").DeviceIdentifier("a0f8c523e4b059cdf269d7fcf64108a7a5b63535").StartApp();
			//app = ConfigureApp.iOS.InstalledApp("com.infusion.Express.iOS").DeviceIdentifier("a0f8c523e4b059cdf269d7fcf64108a7a5b63535").StartApp();
			app = ConfigureApp.iOS.Debug().StartApp();
		}

		[Given("I open App")]
		public void IOpenApp()
		{
			app.Repl();
		}

		[Given(@"I can see ""(.*)"" button")]
		public void GivenICanSeeButton(string buttonName)
		{
			app.WaitForElement(c => c.Marked(buttonName));

		}

		[When(@"I tap ""(.*)"" button")]
		public void WhenITapButton(string buttonName)
		{
			app.Tap(c => c.Marked(buttonName));
		}

		[Then(@"I can see ""(.*)"" button")]
		public void ThenICanSeeButton(string buttonName)
		{
			app.WaitForElement(c => c.Marked(buttonName));
		}

		[Then(@"Popup appears ""(.*)""")]
		public void ThenPopupAppear(string msg)
		{
			app.WaitForElement(c => c.Class("TextView").Text(msg));

		}

		[Then(@"I can see ""(.*)"" screen")]
		public void ThenICanSeeScreen(string screenName)
		{
			app.WaitForElement(c => c.Class("TextView").Text(screenName));
			app.ScrollDown();
			app.ScrollDown();

		}

	}
}
