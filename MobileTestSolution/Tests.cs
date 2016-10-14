using System;
using System.IO;
using System.Linq;
using NUnit.Framework;
using Xamarin.UITest;
using Xamarin.UITest.Android;
using XamarinWrapper;

namespace MobileTests
{
	[TestFixture]
	public class Tests
	{
		IApp app;

		[SetUp]
		public void BeforeEachTest ()
		{
			app = ApplicationFactory.GetAppInstance<IAppLauncher>().LaunchApp();
		}

		[Test]
		public void AppLaunches ()
		{
			//app.Repl();
			app.Tap (x => x.Button ("button_connect_with_facebook"));
		}
	}
}