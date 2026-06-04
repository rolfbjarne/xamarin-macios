// 
// AVAssetDownloadTask.cs: AVAssetDownloadTask class
//
// Authors:
//	Alex Soto (alex.soto@xamarin.com)
//     
// Copyright 2015 Xamarin Inc.
//
#if !TVOS

#nullable enable

namespace AVFoundation {
#if !MONOMAC
	public partial class AVAssetDownloadUrlSession : NSUrlSession {

		/// <summary>Gets the shared session data.</summary>
		///         <value>To be added.</value>
		public new static NSUrlSession SharedSession {
			get {
				throw new NotSupportedException ("NS_UNAVAILABLE");
			}
		}

		/// <param name="configuration">The configuration to use.</param>
		///         <summary>Creates a new <see cref="Foundation.NSUrlSession" /> from the specified <paramref name="configuration" />.</summary>
		///         <returns>To be added.</returns>
		public new static NSUrlSession FromConfiguration (NSUrlSessionConfiguration configuration)
		{
			throw new NotSupportedException ("NS_UNAVAILABLE");
		}

		/// <param name="configuration">The session configuration to use.</param>
		///         <param name="sessionDelegate">The session delegate to use.</param>
		///         <param name="delegateQueue">The operation cue to use.</param>
		///         <summary>Creates a new <see cref="Foundation.NSUrlSession" /> by using the specified configuration, delegate, and delegate cue.</summary>
		///         <returns>To be added.</returns>
		public new static NSUrlSession FromConfiguration (NSUrlSessionConfiguration configuration, INSUrlSessionDelegate sessionDelegate, NSOperationQueue delegateQueue)
		{
			throw new NotSupportedException ("NS_UNAVAILABLE");
		}

		/// <param name="configuration">The configuration to use.</param>
		///         <param name="weakDelegate">The weak delegate.</param>
		///         <param name="delegateQueue">The delegate queue.</param>
		///         <summary>Creates a new <see cref="Foundation.NSUrlSession" /> from the specified <paramref name="configuration" />, weakly-referenced session delegate, and delegate queue.</summary>
		///         <returns>To be added.</returns>
		public new static NSUrlSession FromWeakConfiguration (NSUrlSessionConfiguration configuration, NSObject weakDelegate, NSOperationQueue delegateQueue)
		{
			throw new NotSupportedException ("NS_UNAVAILABLE");
		}

		/// <param name="request">The request.</param>
		///         <summary>Creates a new <see cref="Foundation.NSUrlSessionDataTask" /> with the specified request.</summary>
		///         <returns>To be added.</returns>
		public override NSUrlSessionDataTask CreateDataTask (NSUrlRequest request)
		{
			throw new NotSupportedException ("NS_UNAVAILABLE");
		}

		/// <param name="url">The URL to use.</param>
		///         <summary>Creates a new <see cref="Foundation.NSUrlSessionDataTask" /> for the specified URL.</summary>
		///         <returns>To be added.</returns>
		public override NSUrlSessionDataTask CreateDataTask (NSUrl url)
		{
			throw new NotSupportedException ("NS_UNAVAILABLE");
		}

		/// <param name="request">The request.</param>
		///         <param name="fileURL">The file u r l.</param>
		///         <summary>Creates a new <see cref="Foundation.NSUrlSessionUploadTask" /> for the specified <paramref name="request" /> and <paramref name="fileURL" />.</summary>
		///         <returns>To be added.</returns>
		public override NSUrlSessionUploadTask CreateUploadTask (NSUrlRequest request, NSUrl fileURL)
		{
			throw new NotSupportedException ("NS_UNAVAILABLE");
		}

		/// <param name="request">The request.</param>
		///         <param name="bodyData">The body data.</param>
		///         <summary>Creates a new <see cref="Foundation.NSUrlSessionUploadTask" /> for the specified <paramref name="request" /> and <paramref name="bodyData" />.</summary>
		///         <returns>To be added.</returns>
		public override NSUrlSessionUploadTask CreateUploadTask (NSUrlRequest request, NSData bodyData)
		{
			throw new NotSupportedException ("NS_UNAVAILABLE");
		}

		/// <param name="request">The request.</param>
		///         <summary>Creates a new <see cref="Foundation.NSUrlSessionUploadTask" /> for the specified request.</summary>
		///         <returns>To be added.</returns>
		public override NSUrlSessionUploadTask CreateUploadTask (NSUrlRequest request)
		{
			throw new NotSupportedException ("NS_UNAVAILABLE");
		}

		/// <param name="request">The request.</param>
		///         <summary>Creates a new <see cref="Foundation.NSUrlSessionDownloadTask" /> for the specified request.</summary>
		///         <returns>To be added.</returns>
		public override NSUrlSessionDownloadTask CreateDownloadTask (NSUrlRequest request)
		{
			throw new NotSupportedException ("NS_UNAVAILABLE");
		}

		/// <param name="url">The URL to use.</param>
		///         <summary>Creates a new <see cref="Foundation.NSUrlSessionDownloadTask" /> for the specified URL.</summary>
		///         <returns>To be added.</returns>
		public override NSUrlSessionDownloadTask CreateDownloadTask (NSUrl url)
		{
			throw new NotSupportedException ("NS_UNAVAILABLE");
		}

		/// <param name="resumeData">The resume data.</param>
		///         <summary>reates a new <see cref="Foundation.NSUrlSessionDataTask" /> that resumes downloading <paramref name="resumeData" />.</summary>
		///         <returns>To be added.</returns>
		public override NSUrlSessionDownloadTask CreateDownloadTask (NSData resumeData)
		{
			throw new NotSupportedException ("NS_UNAVAILABLE");
		}

		/// <param name="request">The request.</param>
		///         <param name="completionHandler">The completion handler to call when the operation completes.</param>
		///         <summary>reates a new <see cref="Foundation.NSUrlSessionDataTask" /> for the specified request, and runs a completion handler when it is finished.</summary>
		///         <returns>To be added.</returns>
		public override NSUrlSessionDataTask CreateDataTask (NSUrlRequest request, NSUrlSessionResponse? completionHandler)
		{
			throw new NotSupportedException ("NS_UNAVAILABLE");
		}

		/// <param name="url">The URL to use.</param>
		///         <param name="completionHandler">The completion handler to call when the operation completes.</param>
		///         <summary>Creates a new <see cref="Foundation.NSUrlSessionDataTask" /> for the specified URL, and runs a completion handler when it is finished.</summary>
		///         <returns>To be added.</returns>
		public override NSUrlSessionDataTask CreateDataTask (NSUrl url, NSUrlSessionResponse? completionHandler)
		{
			throw new NotSupportedException ("NS_UNAVAILABLE");
		}

		/// <param name="request">The request.</param>
		///         <param name="fileURL">The file u r l.</param>
		///         <param name="completionHandler">The completion handler to call when the operation completes.</param>
		///         <summary>Creates a new <see cref="Foundation.NSUrlSessionUploadTask" /> for the specified <paramref name="request" /> and <paramref name="fileURL" />, and runs <paramref name="completionHandler" /> when it is finished.</summary>
		///         <returns>To be added.</returns>
		public override NSUrlSessionUploadTask CreateUploadTask (NSUrlRequest request, NSUrl fileURL, NSUrlSessionResponse completionHandler)
		{
			throw new NotSupportedException ("NS_UNAVAILABLE");
		}

		/// <param name="request">The request.</param>
		///         <param name="bodyData">The body data.</param>
		///         <param name="completionHandler">The completion handler to call when the operation completes.</param>
		///         <summary>Creates a new <see cref="Foundation.NSUrlSessionUploadTask" /> for the specified <paramref name="request" /> and <paramref name="bodyData" />, and runs <paramref name="completionHandler" /> when it is finished.</summary>
		///         <returns>To be added.</returns>
		public override NSUrlSessionUploadTask CreateUploadTask (NSUrlRequest request, NSData bodyData, NSUrlSessionResponse completionHandler)
		{
			throw new NotSupportedException ("NS_UNAVAILABLE");
		}

		/// <param name="request">The request.</param>
		///         <param name="completionHandler">The completion handler to call when the operation completes.</param>
		///         <summary>Creates a new <see cref="Foundation.NSUrlSessionDownloadTask" /> for the specified request, and runs a completion handler when it is finished.</summary>
		///         <returns>To be added.</returns>
		public override NSUrlSessionDownloadTask CreateDownloadTask (NSUrlRequest request, NSUrlDownloadSessionResponse? completionHandler)
		{
			throw new NotSupportedException ("NS_UNAVAILABLE");
		}

		/// <param name="url">The URL to use.</param>
		///         <param name="completionHandler">The completion handler to call when the operation completes.</param>
		///         <summary>Creates a new <see cref="Foundation.NSUrlSessionDownloadTask" /> for the specified url, and runs a completion handler when it is finished.</summary>
		///         <returns>To be added.</returns>
		public override NSUrlSessionDownloadTask CreateDownloadTask (NSUrl url, NSUrlDownloadSessionResponse? completionHandler)
		{
			throw new NotSupportedException ("NS_UNAVAILABLE");
		}

		/// <param name="resumeData">The resume data.</param>
		///         <param name="completionHandler">The completion handler to call when the operation completes.</param>
		///         <summary>Creates a new <see cref="Foundation.NSUrlSessionDownloadTask" /> that resumes downloading the <paramref name="resumeData" />, and runs a completion handler when it is finished.</summary>
		///         <returns>To be added.</returns>
		public override NSUrlSessionDownloadTask CreateDownloadTaskFromResumeData (NSData resumeData, NSUrlDownloadSessionResponse? completionHandler)
		{
			throw new NotSupportedException ("NS_UNAVAILABLE");
		}
	}
#endif
}
#endif
