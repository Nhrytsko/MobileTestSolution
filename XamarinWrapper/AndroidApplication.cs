using System;
using Xamarin.UITest;
using Xamarin.UITest.Android;

namespace XamarinWrapper
{
	public class AndroidApplication: IAppLauncher
	{
		#region Fields
		private IApp app;
		private string androidAPKPAth;
		#endregion

		public IApp LaunchApp(){

			androidAPKPAth = "../../ResourceFiles/Calendar.apk";

			app = ConfigureApp
				.Android
				.ApkFile (androidAPKPAth)
				.StartApp ();
			return app;
	}
	}
}

