using System;
using System.Configuration;
using System.Collections.Generic;

namespace XamarinWrapper
{
	public class ApplicationFactory
	{
		static Dictionary<Type, object> ApplicationInstanceCatalog = new Dictionary<Type, object>();

		// Returns appropriate application instance specified in App.config file
		private static T GetAppTypeFromConfig<T>() where T: class
		{
			//gets the string value of application type form configuration file
			string applicationType = ConfigurationManager.AppSettings[typeof(T).ToString()];
			if (string.IsNullOrEmpty(applicationType)) return null;

			//check the case sensitive value of specifed type. 
			Type appType = Type.GetType (applicationType);

			//create instance of appropriate type
			object applicationInstance = Activator.CreateInstance (appType);
			T appInstance = applicationInstance as T;

			return appInstance;
		}

		// Gets the existing application instance or creates another one 
		public static T GetAppInstance<T>() where T: class
		{
			T instance = GetFromInstanceCatalog<T>();
			if (instance == null) instance = GetAppTypeFromConfig<T>();
			return instance;
		}

		//Tries to get the existing application instance 
		private static T GetFromInstanceCatalog<T>() where T : class
		{
			object instance;
			ApplicationInstanceCatalog.TryGetValue(typeof(T), out instance);
			return instance as T;
		}
	}
}

