using System;
using Xamarin.UITest;
using Xamarin.UITest.iOS;

namespace XamarinWrapper
{
	public class IOSApplication: IAppLauncher
	{
		#region Fields
		private IApp app;
		private string iosAppPath;
		#endregion

		public IApp LaunchApp(){
			iosAppPath = String.Empty;
			app = ConfigureApp.iOS.AppBundle (iosAppPath).StartApp ();

			return app;
		}
	}
}

