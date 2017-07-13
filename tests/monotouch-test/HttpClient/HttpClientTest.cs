﻿#if !__WATCHOS__
using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

#if XAMCORE_2_0
using Foundation;
#else
using MonoTouch.Foundation;
#endif
using NUnit.Framework;


namespace MonoTouchFixtures.HttpClientTests
{
	[TestFixture]
	public class HttpClientTest
	{
		const int WaitTimeout = 5000;

		interface IHandlerWrapper
		{
			bool AllowAutoRedirect { get; set; }
			HttpMessageHandler Handler { get; }

		}

		// Add new classes to deal with in this class in order not to change the tests, that way we ensure all
		// handlers will pass the exact same tests with no duplication.
		class HandlerWrapper : IHandlerWrapper
		{
			string handlerType;
			HttpMessageHandler handler;

			public HandlerWrapper (CFNetworkHandler handler)
			{
				this.handlerType = handler.GetType ().Name;
				this.handler = new CFNetworkHandler ();
			}

			public HandlerWrapper (NSUrlSessionHandler handler)
			{
				this.handlerType = handler.GetType ().Name;
				this.handler = new NSUrlSessionHandler ();
			}

			public HandlerWrapper (HttpClientHandler handler)
			{
				this.handlerType = handler.GetType ().Name;
				this.handler = handler;
			}

			public bool AllowAutoRedirect {
				get {
					if (handlerType == "CFNetworkHandler")
						return ((CFNetworkHandler)handler).AllowAutoRedirect;
					if (handlerType == "NSUrlSessionHandler")
						return ((NSUrlSessionHandler)handler).AllowAutoRedirect;
					if (handlerType == "HttpClientHandler")
						return ((HttpClientHandler)handler).AllowAutoRedirect;
					throw new InvalidOperationException ();
				}
				set {
					if (handlerType == "CFNetworkHandler")
						((CFNetworkHandler)handler).AllowAutoRedirect = value;
					if (handlerType == "NSUrlSessionHandler")
						((NSUrlSessionHandler)handler).AllowAutoRedirect = value;
					if (handlerType == "HttpClientHandler")
						((HttpClientHandler)handler).AllowAutoRedirect = value;
					throw new InvalidOperationException ();
				}
			}

			public HttpMessageHandler Handler { get { return handler; } }

			public static IHandlerWrapper GetWrapper (Type handlerType)
			{
				switch (handlerType.Name) {
				case "CFNetworkHandler":
					return new HandlerWrapper (new CFNetworkHandler ());
				case "NSUrlSessionHandler":
					return new HandlerWrapper (new NSUrlSessionHandler ());
				case "HttpClientHandler":
					return new HandlerWrapper (new HttpClientHandler ());
				default:
					throw new InvalidOperationException ();
				}
			}
		}

		[TestCase (typeof (HttpClientHandler))]
		[TestCase (typeof (CFNetworkHandler))]
		[TestCase (typeof (NSUrlSessionHandler))]
		public void EnsureModifiabilityPostSend (Type handlerType)
		{
			var wrapper = HandlerWrapper.GetWrapper (handlerType);
			using (var client = new HttpClient (wrapper.Handler))
			using (var request = new HttpRequestMessage (HttpMethod.Get, "http://xamarin.com")) {
				var token = new CancellationTokenSource ();
				client.SendAsync (request, token.Token);
				Assert.Throws<InvalidOperationException> (() => wrapper.AllowAutoRedirect = !wrapper.AllowAutoRedirect);
				// cancel to ensure that we do not have side effects
				token.Cancel ();
			}
		}
	}
}
#endif

