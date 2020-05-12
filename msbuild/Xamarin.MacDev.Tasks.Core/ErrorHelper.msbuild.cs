using System;
namespace Xamarin.Bundler {
	public class ProductException : Exception { }
	public static class ErrorHelper {
		public static void Warning (params object[] args)
		{
			throw new NotImplementedException ();
		}
		public static Exception CreateError (params object [] args)
		{
			throw new NotImplementedException ();
		}
	}
}

