//
// MessageHandlers.cs
//

using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using System.Net;
using System.Net.Http;
#if NET
using System.Net.Security;
using System.Security.Cryptography.X509Certificates;
#endif
using System.Linq;
using System.IO;

using NUnit.Framework;
using System.Net;
using System.Net.Http.Headers;
using System.Security.Authentication;
using System.Text;
using Foundation;
using ObjCRuntime;
using Xamarin.Utils;

namespace MonoTests.System.Net.Http {
	[TestFixture]
	[Preserve (AllMembers = true)]
	public class MessageHandlerTest {
		public MessageHandlerTest ()
		{
			// Https seems broken on our macOS 10.9 bot, so skip this test.
			TestRuntime.AssertSystemVersion (ApplePlatform.MacOSX, 10, 10, throwIfOtherPlatform: false);
		}

		void PrintHandlerToTest ()
		{
#if !__WATCHOS__
			Console.WriteLine (new HttpClientHandler ());
			Console.WriteLine (new CFNetworkHandler ());
#if NET
			Console.WriteLine (new SocketsHttpHandler ());
#endif
#endif
			Console.WriteLine (new NSUrlSessionHandler ());
		}

		HttpMessageHandler GetHandler (Type handler_type)
		{
#if !__WATCHOS__
			if (handler_type == typeof (HttpClientHandler))
				return new HttpClientHandler ();
			if (handler_type == typeof (CFNetworkHandler))
				return new CFNetworkHandler ();
#endif
#if NET
			if (handler_type == typeof (SocketsHttpHandler))
				return new SocketsHttpHandler ();
#endif
			if (handler_type == typeof (NSUrlSessionHandler))
				return new NSUrlSessionHandler ();

			throw new NotImplementedException ($"Unknown handler type: {handler_type}");
		}

		[Test]
#if !__WATCHOS__
		[TestCase (typeof (HttpClientHandler))]
		[TestCase (typeof (CFNetworkHandler))]
#if NET
		[TestCase (typeof (SocketsHttpHandler))]
#endif
#endif
		[TestCase (typeof (NSUrlSessionHandler))]
		public void DnsFailure (Type handlerType)
		{
			TestRuntime.AssertSystemVersion (ApplePlatform.MacOSX, 10, 9, throwIfOtherPlatform: false);
			TestRuntime.AssertSystemVersion (ApplePlatform.iOS, 7, 0, throwIfOtherPlatform: false);

			PrintHandlerToTest ();

			bool done = false;
			string response = null;
			Exception ex = null;

			TestRuntime.RunAsync (DateTime.Now.AddSeconds (30), async () => {
				try {
					HttpClient client = new HttpClient (GetHandler (handlerType));
					response = await client.GetStringAsync ("http://doesnotexist.xamarin.com");
				} catch (Exception e) {
					ex = e;
				} finally {
					done = true;
				}
			}, () => done);

			Assert.IsTrue (done, "Did not time out");
			Assert.IsNull (response, $"Response is not null {response}");
			Assert.IsInstanceOf (typeof (HttpRequestException), ex, "Exception");
		}

#if !__WATCHOS__
		// ensure that we do get the same cookies as the managed handler
		[Test]
		public void TestNSUrlSessionHandlerCookies ()
		{
			var managedCookieResult = false;
			var nativeCookieResult = false;
			Exception ex = null;
			var completed = false;
			IEnumerable<string> nativeCookies = null;
			IEnumerable<string> managedCookies = null;

			TestRuntime.RunAsync (DateTime.Now.AddSeconds (30), async () => {
				var url = NetworkResources.Httpbin.GetSetCookieUrl ("cookie", "chocolate-chip");
				try {
					var managedHandler = new HttpClientHandler () {
						AllowAutoRedirect = false,
					};
					var managedClient = new HttpClient (managedHandler);
					var managedResponse = await managedClient.GetAsync (url);
					managedCookieResult = managedResponse.Headers.TryGetValues ("Set-Cookie", out managedCookies);

					var nativeHandler = new NSUrlSessionHandler () {
						AllowAutoRedirect = false,
					};
					nativeHandler.AllowAutoRedirect = true;
					var nativeClient = new HttpClient (nativeHandler);
					var nativeResponse = await nativeClient.GetAsync (url);
					nativeCookieResult = nativeResponse.Headers.TryGetValues ("Set-Cookie", out nativeCookies);
				} catch (Exception e) {
					ex = e;
				} finally {
					completed = true;
				}
			}, () => completed);

			if (!completed)
				TestRuntime.IgnoreInCI ("Transient network failure - ignore in CI");
			Assert.IsTrue (completed, "Network request completed");
			Assert.IsNull (ex, "Exception");
			Assert.IsTrue (managedCookieResult, $"Failed to get managed cookies");
			Assert.IsTrue (nativeCookieResult, $"Failed to get native cookies");
			Assert.AreEqual (1, managedCookies.Count (), $"Managed Cookie Count");
			Assert.AreEqual (1, nativeCookies.Count (), $"Native Cookie Count");
			Assert.That (nativeCookies.First (), Does.StartWith ("cookie=chocolate-chip;"), $"Native Cookie Value");
			Assert.That (managedCookies.First (), Does.StartWith ("cookie=chocolate-chip;"), $"Managed Cookie Value");
		}

		// ensure that we can use a cookie container to set the cookies for a url
		[Test]
		public void TestNSUrlSessionHandlerCookieContainer ()
		{
			var url = NetworkResources.Httpbin.CookiesUrl;
			var cookie = new Cookie ("cookie", "chocolate-chip");
			var cookieContainer = new CookieContainer ();
			cookieContainer.Add (new Uri (url), cookie);

			string managedCookieResult = null;
			string nativeCookieResult = null;
			Exception ex = null;
			var completed = false;

			TestRuntime.RunAsync (DateTime.Now.AddSeconds (30), async () => {
				try {
					var managedHandler = new HttpClientHandler () {
						AllowAutoRedirect = false,
						CookieContainer = cookieContainer,
					};
					var managedClient = new HttpClient (managedHandler);
					var managedResponse = await managedClient.GetAsync (url);
					managedCookieResult = await managedResponse.Content.ReadAsStringAsync ();

					var nativeHandler = new NSUrlSessionHandler () {
						AllowAutoRedirect = true,
						CookieContainer = cookieContainer,
					};
					var nativeClient = new HttpClient (nativeHandler);
					var nativeResponse = await nativeClient.GetAsync (url);
					nativeCookieResult = await nativeResponse.Content.ReadAsStringAsync ();
				} catch (Exception e) {
					ex = e;
				} finally {
					completed = true;
				}
			}, () => completed);

			if (!completed || managedCookieResult.Contains ("502 Bad Gateway") || nativeCookieResult.Contains ("502 Bad Gateway") || managedCookieResult.Contains ("504 Gateway Time-out") || nativeCookieResult.Contains ("504 Gateway Time-out"))
				TestRuntime.IgnoreInCI ("Transient network failure - ignore in CI");
			Assert.IsTrue (completed, "Network request completed");
			Assert.IsNull (ex, "Exception");
			Assert.IsNotNull (managedCookieResult, "Managed cookies result");
			Assert.IsNotNull (nativeCookieResult, "Native cookies result");
			Assert.AreEqual (managedCookieResult, nativeCookieResult, "Cookies");
		}

		// ensure that the Set-Cookie headers do update the CookieContainer
		[Test]
		public void TestNSurlSessionHandlerCookieContainerSetCookie ()
		{
			var url = NetworkResources.Httpbin.GetSetCookieUrl ("cookie", "chocolate-chip");
			var cookieContainer = new CookieContainer ();

			string nativeCookieResult = null;
			Exception ex = null;
			var completed = false;

			TestRuntime.RunAsync (DateTime.Now.AddSeconds (30), async () => {
				try {

					var nativeHandler = new NSUrlSessionHandler () {
						AllowAutoRedirect = true,
						CookieContainer = cookieContainer,
					};
					var nativeClient = new HttpClient (nativeHandler);
					var nativeResponse = await nativeClient.GetAsync (url);
					nativeCookieResult = await nativeResponse.Content.ReadAsStringAsync ();
				} catch (Exception e) {
					ex = e;
				} finally {
					completed = true;
				}
			}, () => completed);

			if (!completed)
				TestRuntime.IgnoreInCI ("Transient network failure - ignore in CI");
			Assert.IsTrue (completed, "Network request completed");
			Assert.IsNull (ex, "Exception");
			Assert.IsNotNull (nativeCookieResult, "Native cookies result");
			var cookiesFromServer = cookieContainer.GetCookies (new Uri (url));
			Assert.AreEqual (1, cookiesFromServer.Count, "Cookies received from server.");
		}

		[Test]
		public void TestNSUrlSessionDefaultDisabledCookies ()
		{
			// simple test. send a request with a set-cookie url, get the data
			// and ensure that the second request does not send any cookies.
			var url = NetworkResources.Httpbin.GetSetCookieUrl ("cookie", "chocolate-chip");

			string nativeSetCookieResult = null;
			string nativeCookieResult = null;


			Exception ex = null;
			var completed = false;

			TestRuntime.RunAsync (DateTime.Now.AddSeconds (30), async () => {
				try {

					var nativeHandler = new NSUrlSessionHandler () {
						AllowAutoRedirect = true,
						UseCookies = false,
					};
					var nativeClient = new HttpClient (nativeHandler);
					var nativeResponse = await nativeClient.GetAsync (url);
					nativeSetCookieResult = await nativeResponse.Content.ReadAsStringAsync ();

					// got the response, perofm a second queries to the cookies endpoint to get
					// the actual cookies sent from the storage
					nativeResponse = await nativeClient.GetAsync (NetworkResources.Httpbin.CookiesUrl);
					nativeCookieResult = await nativeResponse.Content.ReadAsStringAsync ();
				} catch (Exception e) {
					ex = e;
				} finally {
					completed = true;
				}
			}, () => completed);

			if (!completed)
				TestRuntime.IgnoreInCI ("Transient network failure - ignore in CI");
			Assert.IsTrue (completed, "Network request completed");
			Assert.IsNull (ex, "Exception");
			Assert.IsNotNull (nativeSetCookieResult, "Native set-cookies result");
			Assert.IsNotNull (nativeCookieResult, "Native cookies result");
			Assert.IsFalse (nativeCookieResult.Contains ("chocolate-chip"));
		}

		[Test]
		public void TestNSUrlSessionDefaultDisableCookiesWithManagedContainer ()
		{
			// simple test. send a request with a set-cookie url, get the data
			// and ensure that the second request does not send any cookies.
			var url = NetworkResources.Httpbin.GetSetCookieUrl ("cookie", "chocolate-chip");

			string nativeSetCookieResult = null;
			string nativeCookieResult = null;
			var cookieContainer = new CookieContainer ();


			Exception ex = null;
			var completed = false;

			TestRuntime.RunAsync (DateTime.Now.AddSeconds (30), async () => {
				try {

					var nativeHandler = new NSUrlSessionHandler () {
						AllowAutoRedirect = true,
						UseCookies = false,
					};
					var nativeClient = new HttpClient (nativeHandler);
					var nativeResponse = await nativeClient.GetAsync (url);
					nativeSetCookieResult = await nativeResponse.Content.ReadAsStringAsync ();

					// got the response, preform a second queries to the cookies endpoint to get
					// the actual cookies sent from the storage
					nativeResponse = await nativeClient.GetAsync (NetworkResources.Httpbin.CookiesUrl);
					nativeCookieResult = await nativeResponse.Content.ReadAsStringAsync ();
				} catch (Exception e) {
					ex = e;
				} finally {
					completed = true;
				}
			}, () => completed);

			if (!completed)
				TestRuntime.IgnoreInCI ("Transient network failure - ignore in CI");
			Assert.IsTrue (completed, "Network request completed");
			Assert.IsNull (ex, "Exception");
			Assert.IsNotNull (nativeSetCookieResult, "Native set-cookies result");
			Assert.IsNotNull (nativeCookieResult, "Native cookies result");
			Assert.IsFalse (nativeCookieResult.Contains ("chocolate-chip"));
			var cookiesFromServer = cookieContainer.GetCookies (new Uri (url));
			Assert.AreEqual (0, cookiesFromServer.Count, "Cookies received from server.");
		}

		[Test]
		public void TestNSUrlSessionEphemeralDisabledCookies ()
		{
			// assert we do throw an exception with ephmeral configs.
			using (var config = NSUrlSessionConfiguration.EphemeralSessionConfiguration) {
				Assert.True (config.SessionType == NSUrlSessionConfiguration.SessionConfigurationType.Ephemeral, "Session type.");
				var nativeHandler = new NSUrlSessionHandler (config);
				Assert.Throws<InvalidOperationException> (() => {
					nativeHandler.UseCookies = false;
				});
			}
		}

#endif

		// ensure that if we have a redirect, we do not have the auth headers in the following requests
#if !__WATCHOS__
		[TestCase (typeof (HttpClientHandler))]
		[TestCase (typeof (CFNetworkHandler))]
#endif
		[TestCase (typeof (NSUrlSessionHandler))]
		public void RedirectionWithAuthorizationHeaders (Type handlerType)
		{

			TestRuntime.AssertSystemVersion (ApplePlatform.MacOSX, 10, 9, throwIfOtherPlatform: false);
			TestRuntime.AssertSystemVersion (ApplePlatform.iOS, 7, 0, throwIfOtherPlatform: false);

			bool containsAuthorizarion = false;
			bool containsHeaders = false;
			string json = "";
			bool done = false;
			Exception ex = null;

			TestRuntime.RunAsync (DateTime.Now.AddSeconds (30), async () => {
				try {
					HttpClient client = new HttpClient (GetHandler (handlerType));
					client.BaseAddress = NetworkResources.Httpbin.Uri;
					var byteArray = new UTF8Encoding ().GetBytes ("username:password");
					client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue ("Basic", Convert.ToBase64String (byteArray));
					var result = await client.GetAsync (NetworkResources.Httpbin.GetRedirectUrl (3));
					// get the data returned from httpbin which contains the details of the requested performed.
					json = await result.Content.ReadAsStringAsync ();
					containsAuthorizarion = json.Contains ("Authorization");
					containsHeaders = json.Contains ("headers");  // ensure we do have the headers in the response
				} catch (Exception e) {
					ex = e;
				} finally {
					done = true;
				}
			}, () => done);

			if (!done) { // timeouts happen in the bots due to dns issues, connection issues etc.. we do not want to fail
				Assert.Inconclusive ("Request timedout.");
			} else if (!containsHeaders) {
				Assert.Inconclusive ("Response from httpbin does not contain headers, therefore we cannot ensure that if the authoriation is present.");
			} else {
				Assert.IsFalse (containsAuthorizarion, $"Authorization header did reach the final destination. {json}");
				Assert.IsNull (ex, $"Exception {ex} for {json}");
			}
		}

#if !__WATCHOS__
#if !NET // By default HttpClientHandler redirects to a NSUrlSessionHandler, so no need to test that here.
		[TestCase (typeof (HttpClientHandler))]
#endif
#endif
#if NET
		[TestCase (typeof (SocketsHttpHandler))]
#endif
		[TestCase (typeof (NSUrlSessionHandler))]
		public void RejectSslCertificatesServicePointManager (Type handlerType)
		{
			TestRuntime.AssertSystemVersion (ApplePlatform.MacOSX, 10, 9, throwIfOtherPlatform: false);
			TestRuntime.AssertSystemVersion (ApplePlatform.iOS, 7, 0, throwIfOtherPlatform: false);

#if __MACOS__
			if (handlerType == typeof (NSUrlSessionHandler) && TestRuntime.CheckSystemVersion (ApplePlatform.MacOSX, 10, 10, 0) && !TestRuntime.CheckSystemVersion (ApplePlatform.MacOSX, 10, 11, 0))
				Assert.Ignore ("Fails on macOS 10.10: https://github.com/xamarin/maccore/issues/1645");
#endif

			bool validationCbWasExecuted = false;
			bool customValidationCbWasExecuted = false;
			bool invalidServicePointManagerCbWasExcuted = false;
			bool done = false;
			Exception ex = null;
			Type expectedExceptionType = null;
			HttpResponseMessage result = null;

			var handler = GetHandler (handlerType);
			if (handler is HttpClientHandler ch) {
				expectedExceptionType = typeof (AuthenticationException);
				ch.ServerCertificateCustomValidationCallback = (sender, certificate, chain, errors) => {
					validationCbWasExecuted = true;
					// return false, since we want to test that the exception is raised
					return false;
				};
				ServicePointManager.ServerCertificateValidationCallback = (sender, certificate, chain, errors) => {
					invalidServicePointManagerCbWasExcuted = true;
					return false;
				};
#if NET
			} else if (handler is SocketsHttpHandler shh) {
				expectedExceptionType = typeof (AuthenticationException);
				var sslOptions = new SslClientAuthenticationOptions {
					// Leave certs unvalidated for debugging
					RemoteCertificateValidationCallback = delegate
					{
						validationCbWasExecuted = true;
						// return false, since we want to test that the exception is raised
						return false;
					},
				};
				shh.SslOptions = sslOptions;
#endif // NET
			} else if (handler is NSUrlSessionHandler ns) {
				expectedExceptionType = typeof (WebException);
#if NET
				ns.TrustOverrideForUrl += (a, b, c) => {
#else
				ns.TrustOverride += (a, b) => {
#endif
					validationCbWasExecuted = true;
					// return false, since we want to test that the exception is raised
					return false;
				};
			} else {
				Assert.Fail ($"Invalid HttpMessageHandler: '{handler.GetType ()}'.");
			}

			TestRuntime.RunAsync (DateTime.Now.AddSeconds (30), async () => {
				try {
					HttpClient client = new HttpClient (handler);
					client.BaseAddress = NetworkResources.Httpbin.Uri;
					var byteArray = new UTF8Encoding ().GetBytes ("username:password");
					client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue ("Basic", Convert.ToBase64String (byteArray));
					result = await client.GetAsync (NetworkResources.Httpbin.GetRedirectUrl (3));
				} catch (Exception e) {
					ex = e;
				} finally {
					done = true;
					ServicePointManager.ServerCertificateValidationCallback = null;
				}
			}, () => done);

			if (!done) { // timeouts happen in the bots due to dns issues, connection issues etc.. we do not want to fail
				Assert.Inconclusive ("Request timedout.");
			} else {
				// the ServicePointManager.ServerCertificateValidationCallback will never be executed.
				Assert.False (invalidServicePointManagerCbWasExcuted, "Invalid SPM executed");
				Assert.True (validationCbWasExecuted, "Validation Callback called");
				// assert the exception type
				Assert.IsNotNull (ex, (result == null) ? "Expected exception is missing and got no result" : $"Expected exception but got {result.Content.ReadAsStringAsync ().Result}");
				Assert.IsInstanceOf (typeof (HttpRequestException), ex, "Exception type");
				Assert.IsNotNull (ex.InnerException, "InnerException");
				Assert.IsInstanceOf (expectedExceptionType, ex.InnerException, "InnerException type");
			}
		}

#if !__WATCHOS__
		[TestCase (typeof (HttpClientHandler))]
#endif
		[TestCase (typeof (NSUrlSessionHandler))]
		public void AcceptSslCertificatesServicePointManager (Type handlerType)
		{
			TestRuntime.AssertSystemVersion (ApplePlatform.MacOSX, 10, 9, throwIfOtherPlatform: false);
			TestRuntime.AssertSystemVersion (ApplePlatform.iOS, 7, 0, throwIfOtherPlatform: false);

			bool servicePointManagerCbWasExcuted = false;
			bool done = false;
			Exception ex = null;

			var handler = GetHandler (handlerType);
			if (handler is NSUrlSessionHandler ns) {
#if NET
				ns.TrustOverrideForUrl += (a, b, c) => {
#else
				ns.TrustOverride += (a, b) => {
#endif
					servicePointManagerCbWasExcuted = true;
					return true;
				};
			} else {
				ServicePointManager.ServerCertificateValidationCallback = (sender, certificate, chain, errors) => {
					servicePointManagerCbWasExcuted = true;
					return true;
				};
			}

			TestRuntime.RunAsync (DateTime.Now.AddSeconds (30), async () => {
				try {
					HttpClient client = new HttpClient (handler);
					client.BaseAddress = NetworkResources.Httpbin.Uri;
					var byteArray = new UTF8Encoding ().GetBytes ("username:password");
					client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue ("Basic", Convert.ToBase64String (byteArray));
					var result = await client.GetAsync (NetworkResources.Httpbin.GetRedirectUrl (3));
				} catch (Exception e) {
					ex = e;
				} finally {
					done = true;
					ServicePointManager.ServerCertificateValidationCallback = null;
				}
			}, () => done);

			if (!done) { // timeouts happen in the bots due to dns issues, connection issues etc.. we do not want to fail
				Assert.Inconclusive ("Request timedout.");
			} else {
				// assert that we did not get an exception
				if (ex != null && ex.InnerException != null) {
					// we could get here.. if we have a diff issue, in that case, lets get the exception message and assert is not the trust issue
					Assert.AreNotEqual (ex.InnerException.Message, "Error: TrustFailure");
				}
			}
		}

#if NET
		[TestCase ("https://self-signed.badssl.com/")]
		[TestCase ("https://wrong.host.badssl.com/")]
		public void AcceptSslCertificatesWithCustomValidationCallbackNSUrlSessionHandler (string url)
		{
			TestRuntime.AssertSystemVersion (ApplePlatform.MacOSX, 10, 9, throwIfOtherPlatform: false);
			TestRuntime.AssertSystemVersion (ApplePlatform.iOS, 7, 0, throwIfOtherPlatform: false);

			bool callbackWasExecuted = false;
			bool done = false;
			Exception ex = null;
			HttpResponseMessage result = null;
			X509Certificate2 serverCertificate = null;
			SslPolicyErrors sslPolicyErrors = SslPolicyErrors.None;

			var handler = new NSUrlSessionHandler {
				ServerCertificateCustomValidationCallback = (request, certificate, chain, errors) => {
					callbackWasExecuted = true;
					serverCertificate = certificate;
					sslPolicyErrors = errors;
					return true;
				}
			};

			TestRuntime.RunAsync (DateTime.Now.AddSeconds (30), async () => {
				try {
					var client = new HttpClient (handler);
					result = await client.GetAsync (url);
				} catch (Exception e) {
					ex = e;
				} finally {
					done = true;
				}
			}, () => done);

			if (!done) { // timeouts happen in the bots due to dns issues, connection issues etc.. we do not want to fail
				Assert.Inconclusive ("Request timedout.");
			} else {
				Assert.True (callbackWasExecuted, "Validation Callback called");
				Assert.AreNotEqual (SslPolicyErrors.None, sslPolicyErrors, "Callback was called with unexpected SslPolicyErrors");
				Assert.IsNotNull (serverCertificate, "Server certificate is null");
				Assert.IsNull (ex, "Exception wasn't expected.");
				Assert.IsNotNull (result, "Result was null");
				Assert.IsTrue (result.IsSuccessStatusCode, "Status code was not success");
			}
		}

		[TestCase ("https://www.microsoft.com/")]
		public void RejectSslCertificatesWithCustomValidationCallbackNSUrlSessionHandler (string url)
		{
			TestRuntime.AssertSystemVersion (ApplePlatform.MacOSX, 10, 9, throwIfOtherPlatform: false);
			TestRuntime.AssertSystemVersion (ApplePlatform.iOS, 7, 0, throwIfOtherPlatform: false);

			bool callbackWasExecuted = false;
			bool done = false;
			Exception ex = null;
			Exception ex2 = null;
			HttpResponseMessage result = null;

			var handler = new NSUrlSessionHandler {
				ServerCertificateCustomValidationCallback = (sender, certificate, chain, errors) => {
					callbackWasExecuted = true;
					try {
						Assert.IsNotNull (certificate);
						Assert.AreEqual (SslPolicyErrors.None, errors);
					} catch (Exception e) {
						ex2 = e;
					}
					return false;
				}
			};

			TestRuntime.RunAsync (DateTime.Now.AddSeconds (30), async () => {
				try {
					var client = new HttpClient (handler);
					result = await client.GetAsync (url);
				} catch (Exception e) {
					ex = e;
				} finally {
					done = true;
				}
			}, () => done);

			if (!done) { // timeouts happen in the bots due to dns issues, connection issues etc.. we do not want to fail
				Assert.Inconclusive ("Request timedout.");
			} else {
				Assert.True (callbackWasExecuted, "Validation Callback called.");
				Assert.IsNotNull (ex, result == null ? "Expected exception is missing and got no result." : $"Expected exception but got {result.Content.ReadAsStringAsync ().Result}.");
				Assert.IsInstanceOf (typeof (HttpRequestException), ex, "Exception type");
				Assert.IsNotNull (ex.InnerException, "InnerException");
				Assert.IsInstanceOf (typeof (WebException), ex.InnerException, "InnerException type");
				Assert.IsNull (ex2, "Callback asserts");
			}
		}
#endif

		[Test]
		public void AssertDefaultValuesNSUrlSessionHandler ()
		{
			using (var handler = new NSUrlSessionHandler ()) {
				Assert.True (handler.AllowAutoRedirect, "Default redirects value");
				Assert.True (handler.AllowsCellularAccess, "Default cellular data value.");
			}
			using (var config = NSUrlSessionConfiguration.DefaultSessionConfiguration) {
				config.AllowsCellularAccess = false;
				using (var handler = new NSUrlSessionHandler (config)) {
					Assert.False (handler.AllowsCellularAccess, "Configuration cellular data value.");
				}
			}
		}

		[TestCase (HttpStatusCode.OK, "mandel", "12345678", "mandel", "12345678")]
		[TestCase (HttpStatusCode.Unauthorized, "mandel", "12345678", "mandel", "87654321")]
		[TestCase (HttpStatusCode.Unauthorized, "mandel", "12345678", "", "")]
		public void GHIssue8342 (HttpStatusCode expectedStatus, string validUsername, string validPassword, string username, string password)
		{
			// create a http client to use with some creds that we do know are not valid
			var handler = new NSUrlSessionHandler () {
				Credentials = new NetworkCredential (username, password, "")
			};

			var client = new HttpClient (handler);

			bool done = false;
			HttpStatusCode httpStatus = HttpStatusCode.NotFound;
			Exception ex = null;
			TestRuntime.RunAsync (DateTime.Now.AddSeconds (30), async () => {
				try {

					var result = await client.GetAsync ($"https://httpbin.org/basic-auth/{validUsername}/{validPassword}");
					httpStatus = result.StatusCode;
				} catch (Exception e) {
					ex = e;
				} finally {
					done = true;
				}
			}, () => done);

			if (!done) { // timeouts happen in the bots due to dns issues, connection issues etc.. we do not want to fail
				Assert.Inconclusive ("Request timedout.");
			} else {
				TestRuntime.IgnoreInCIIfBadNetwork (httpStatus);
				Assert.IsNull (ex, "Exception not null");
				Assert.AreEqual (expectedStatus, httpStatus, "Status not ok");
			}
		}

		[TestCase]
		public void GHIssue8344 ()
		{
			var username = "mandel";
			var password = "12345678";
			var url = $"https://httpbin.org/basic-auth/{username}/{password}";
			// perform two requests, one that will get a 200 with valid creds, one that wont and assert that
			// the second call does get a 401
			// create a http client to use with some creds that we do know are not valid
			var firstHandler = new NSUrlSessionHandler () {
				Credentials = new NetworkCredential (username, password, "")
			};

			var firstClient = new HttpClient (firstHandler);

			bool done = false;
			HttpStatusCode httpStatus = HttpStatusCode.NotFound;
			Exception ex = null;
			TestRuntime.RunAsync (DateTime.Now.AddSeconds (30), async () => {
				try {

					var result = await firstClient.GetAsync (url);
					httpStatus = result.StatusCode;
				} catch (Exception e) {
					ex = e;
				} finally {
					done = true;
				}
			}, () => done);

			if (!done) { // timeouts happen in the bots due to dns issues, connection issues etc.. we do not want to fail
				Assert.Inconclusive ("First request timedout.");
			} else {
				TestRuntime.IgnoreInCIIfBadNetwork (httpStatus);
				Assert.IsNull (ex, "First request exception not null");
				Assert.AreEqual (HttpStatusCode.OK, httpStatus, "First status not ok");
			}
			// exactly same operation, diff handler, wrong password, should fail

			var secondHandler = new NSUrlSessionHandler () {
				Credentials = new NetworkCredential (username, password + password, "")
			};

			var secondClient = new HttpClient (secondHandler);

			done = false;
			httpStatus = HttpStatusCode.NotFound;
			ex = null;
			TestRuntime.RunAsync (DateTime.Now.AddSeconds (30), async () => {
				try {

					var result = await secondClient.GetAsync (url);
					httpStatus = result.StatusCode;
				} catch (Exception e) {
					ex = e;
				} finally {
					done = true;
				}
			}, () => done);

			if (!done) { // timeouts happen in the bots due to dns issues, connection issues etc.. we do not want to fail
				Assert.Inconclusive ("Second request timedout.");
			} else {
				TestRuntime.IgnoreInCIIfBadNetwork (httpStatus);
				Assert.IsNull (ex, "Second request exception not null");
				Assert.AreEqual (HttpStatusCode.Unauthorized, httpStatus, "Second status not ok");
			}
		}
	}
}
