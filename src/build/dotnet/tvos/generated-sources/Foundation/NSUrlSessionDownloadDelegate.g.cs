//
// Auto-generated from generator.cs, do not edit
//
// We keep references to objects, so warning 414 is expected
#pragma warning disable 414
using System;
using System.Drawing;
using System.Diagnostics;
using System.ComponentModel;
using System.Threading.Tasks;
using System.Runtime.Versioning;
using System.Runtime.InteropServices;
using System.Diagnostics.CodeAnalysis;
using UIKit;
using GLKit;
using Metal;
using CoreML;
using Photos;
using ModelIO;
using Network;
using SceneKit;
using Security;
using AudioUnit;
using CoreVideo;
using CoreMedia;
using CoreImage;
using SpriteKit;
using Foundation;
using ObjCRuntime;
using MediaPlayer;
using GameplayKit;
using CoreGraphics;
using CoreLocation;
using AVFoundation;
using CoreAnimation;
using CoreFoundation;
using NetworkExtension;
using MetalPerformanceShadersGraph;
#nullable enable
namespace Foundation {
	#pragma warning disable CS1573
	/// <summary>This interface represents the Objective-C protocol <c>NSURLSessionDownloadDelegate</c>.</summary>
	/// <remarks>
	///   <para>A class that implements this interface (and subclasses <see cref="NSObject" />) will be exported to Objective-C as implementing the Objective-C protocol this interface represents.</para>
	///   <para>A class may also implement members from this interface to implement members from the protocol.</para>
	/// </remarks>
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("tvos")]
	[Protocol (Name = "NSURLSessionDownloadDelegate", WrapperType = typeof (NSUrlSessionDownloadDelegateWrapper))]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "DidFinishDownloading", Selector = "URLSession:downloadTask:didFinishDownloadingToURL:", ParameterType = new Type [] { typeof (NSUrlSession), typeof (NSUrlSessionDownloadTask), typeof (NSUrl) }, ParameterByRef = new bool [] { false, false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidWriteData", Selector = "URLSession:downloadTask:didWriteData:totalBytesWritten:totalBytesExpectedToWrite:", ParameterType = new Type [] { typeof (NSUrlSession), typeof (NSUrlSessionDownloadTask), typeof (long), typeof (long), typeof (long) }, ParameterByRef = new bool [] { false, false, false, false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidResume", Selector = "URLSession:downloadTask:didResumeAtOffset:expectedTotalBytes:", ParameterType = new Type [] { typeof (NSUrlSession), typeof (NSUrlSessionDownloadTask), typeof (long), typeof (long) }, ParameterByRef = new bool [] { false, false, false, false })]
	public partial interface INSUrlSessionDownloadDelegate : INativeObject, IDisposable, 
		Foundation.INSUrlSessionTaskDelegate
	{
		/// <param name="session">To be added.</param><param name="downloadTask">To be added.</param><param name="location">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[global::Foundation.RequiredMember]
		[Export ("URLSession:downloadTask:didFinishDownloadingToURL:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidFinishDownloading (NSUrlSession session, NSUrlSessionDownloadTask downloadTask, NSUrl location)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="session">To be added.</param><param name="downloadTask">To be added.</param><param name="location">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _DidFinishDownloading (INSUrlSessionDownloadDelegate This, NSUrlSession session, NSUrlSessionDownloadTask downloadTask, NSUrl location)
		{
			var session__handle__ = session!.GetNonNullHandle (nameof (session));
			var downloadTask__handle__ = downloadTask!.GetNonNullHandle (nameof (downloadTask));
			var location__handle__ = location!.GetNonNullHandle (nameof (location));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("URLSession:downloadTask:didFinishDownloadingToURL:"), session__handle__, downloadTask__handle__, location__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (session);
			GC.KeepAlive (downloadTask);
			GC.KeepAlive (location);
		}
		/// <param name="session">To be added.</param><param name="downloadTask">To be added.</param><param name="bytesWritten">To be added.</param><param name="totalBytesWritten">To be added.</param><param name="totalBytesExpectedToWrite">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("URLSession:downloadTask:didWriteData:totalBytesWritten:totalBytesExpectedToWrite:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidWriteData (NSUrlSession session, NSUrlSessionDownloadTask downloadTask, long bytesWritten, long totalBytesWritten, long totalBytesExpectedToWrite)
		{
			_DidWriteData (this, session, downloadTask, bytesWritten, totalBytesWritten, totalBytesExpectedToWrite);
		}
		/// <param name="session">To be added.</param><param name="downloadTask">To be added.</param><param name="bytesWritten">To be added.</param><param name="totalBytesWritten">To be added.</param><param name="totalBytesExpectedToWrite">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _DidWriteData (INSUrlSessionDownloadDelegate This, NSUrlSession session, NSUrlSessionDownloadTask downloadTask, long bytesWritten, long totalBytesWritten, long totalBytesExpectedToWrite)
		{
			var session__handle__ = session!.GetNonNullHandle (nameof (session));
			var downloadTask__handle__ = downloadTask!.GetNonNullHandle (nameof (downloadTask));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_Int64_Int64_Int64 (This.Handle, Selector.GetHandle ("URLSession:downloadTask:didWriteData:totalBytesWritten:totalBytesExpectedToWrite:"), session__handle__, downloadTask__handle__, bytesWritten, totalBytesWritten, totalBytesExpectedToWrite);
			GC.KeepAlive (This);
			GC.KeepAlive (session);
			GC.KeepAlive (downloadTask);
		}
		/// <param name="session">To be added.</param><param name="downloadTask">To be added.</param><param name="resumeFileOffset">To be added.</param><param name="expectedTotalBytes">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("URLSession:downloadTask:didResumeAtOffset:expectedTotalBytes:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidResume (NSUrlSession session, NSUrlSessionDownloadTask downloadTask, long resumeFileOffset, long expectedTotalBytes)
		{
			_DidResume (this, session, downloadTask, resumeFileOffset, expectedTotalBytes);
		}
		/// <param name="session">To be added.</param><param name="downloadTask">To be added.</param><param name="resumeFileOffset">To be added.</param><param name="expectedTotalBytes">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _DidResume (INSUrlSessionDownloadDelegate This, NSUrlSession session, NSUrlSessionDownloadTask downloadTask, long resumeFileOffset, long expectedTotalBytes)
		{
			var session__handle__ = session!.GetNonNullHandle (nameof (session));
			var downloadTask__handle__ = downloadTask!.GetNonNullHandle (nameof (downloadTask));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_Int64_Int64 (This.Handle, Selector.GetHandle ("URLSession:downloadTask:didResumeAtOffset:expectedTotalBytes:"), session__handle__, downloadTask__handle__, resumeFileOffset, expectedTotalBytes);
			GC.KeepAlive (This);
			GC.KeepAlive (session);
			GC.KeepAlive (downloadTask);
		}
		[DynamicDependencyAttribute ("DidFinishDownloading(Foundation.NSUrlSession,Foundation.NSUrlSessionDownloadTask,Foundation.NSUrl)")]
		[DynamicDependencyAttribute ("DidResume(Foundation.NSUrlSession,Foundation.NSUrlSessionDownloadTask,System.Int64,System.Int64)")]
		[DynamicDependencyAttribute ("DidWriteData(Foundation.NSUrlSession,Foundation.NSUrlSessionDownloadTask,System.Int64,System.Int64,System.Int64)")]
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.Interfaces | DynamicallyAccessedMemberTypes.PublicConstructors, typeof (NSUrlSessionDownloadDelegateWrapper))]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static INSUrlSessionDownloadDelegate ()
		{
			GC.KeepAlive (null);
		}
	}
	#pragma warning restore CS1573
	#pragma warning disable CS1573
	/// <summary>Extension methods to the <see cref="INSUrlSessionDownloadDelegate" /> interface to support all the methods from the NSURLSessionDownloadDelegate protocol.</summary>
	/// <remarks>
	///   <para>The extension methods for <see cref="INSUrlSessionDownloadDelegate" /> interface allow developers to treat instances of the interface as having all the optional methods of the original NSURLSessionDownloadDelegate protocol. Since the interface only contains the required members, these extension methods allow developers to call the optional members of the protocol.</para>
	/// </remarks>
	public unsafe static partial class NSUrlSessionDownloadDelegate_Extensions {
		/// <param name="session">To be added.</param><param name="downloadTask">To be added.</param><param name="bytesWritten">To be added.</param><param name="totalBytesWritten">To be added.</param><param name="totalBytesExpectedToWrite">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void DidWriteData (this INSUrlSessionDownloadDelegate This, NSUrlSession session, NSUrlSessionDownloadTask downloadTask, long bytesWritten, long totalBytesWritten, long totalBytesExpectedToWrite)
		{
			var session__handle__ = session!.GetNonNullHandle (nameof (session));
			var downloadTask__handle__ = downloadTask!.GetNonNullHandle (nameof (downloadTask));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_Int64_Int64_Int64 (This.Handle, Selector.GetHandle ("URLSession:downloadTask:didWriteData:totalBytesWritten:totalBytesExpectedToWrite:"), session__handle__, downloadTask__handle__, bytesWritten, totalBytesWritten, totalBytesExpectedToWrite);
			GC.KeepAlive (This);
			GC.KeepAlive (session);
			GC.KeepAlive (downloadTask);
		}
		/// <param name="session">To be added.</param><param name="downloadTask">To be added.</param><param name="resumeFileOffset">To be added.</param><param name="expectedTotalBytes">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void DidResume (this INSUrlSessionDownloadDelegate This, NSUrlSession session, NSUrlSessionDownloadTask downloadTask, long resumeFileOffset, long expectedTotalBytes)
		{
			var session__handle__ = session!.GetNonNullHandle (nameof (session));
			var downloadTask__handle__ = downloadTask!.GetNonNullHandle (nameof (downloadTask));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_Int64_Int64 (This.Handle, Selector.GetHandle ("URLSession:downloadTask:didResumeAtOffset:expectedTotalBytes:"), session__handle__, downloadTask__handle__, resumeFileOffset, expectedTotalBytes);
			GC.KeepAlive (This);
			GC.KeepAlive (session);
			GC.KeepAlive (downloadTask);
		}
	}
	#pragma warning restore CS1573
	internal unsafe sealed class NSUrlSessionDownloadDelegateWrapper : BaseWrapper, INSUrlSessionDownloadDelegate {
		public NSUrlSessionDownloadDelegateWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.PublicConstructors, typeof (NSUrlSessionDownloadDelegateWrapper))]
		static NSUrlSessionDownloadDelegateWrapper ()
		{
			GC.KeepAlive (null);
		}
		/// <param name="session">To be added.</param><param name="downloadTask">To be added.</param><param name="location">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("URLSession:downloadTask:didFinishDownloadingToURL:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void DidFinishDownloading (NSUrlSession session, NSUrlSessionDownloadTask downloadTask, NSUrl location)
		{
			var session__handle__ = session!.GetNonNullHandle (nameof (session));
			var downloadTask__handle__ = downloadTask!.GetNonNullHandle (nameof (downloadTask));
			var location__handle__ = location!.GetNonNullHandle (nameof (location));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("URLSession:downloadTask:didFinishDownloadingToURL:"), session__handle__, downloadTask__handle__, location__handle__);
			GC.KeepAlive (session);
			GC.KeepAlive (downloadTask);
			GC.KeepAlive (location);
		}
	}
}
namespace Foundation {
	/// <summary>
	///   <para>This is a class that implements the interface <see cref="INSUrlSessionDownloadDelegate" /> (for the protocol <c>NSURLSessionDownloadDelegate</c>).</para>
	///   <para>Subclass this class to easily create a type that implements the protocol.</para>
	///   <para>An alternative is to create a subclass of <see cref="NSObject" /> and then implemented the interface <see cref="INSUrlSessionDownloadDelegate" />.</para>
	/// </summary>
	[Protocol()]
	[Register("Microsoft_tvOS__Foundation_NSUrlSessionDownloadDelegate", false)]
	[Model]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("tvos")]
	public unsafe abstract partial class NSUrlSessionDownloadDelegate : NSUrlSessionTaskDelegate, INSUrlSessionDownloadDelegate {
		/// <summary>Creates a new <see cref="NSUrlSessionDownloadDelegate" /> with default values.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		protected NSUrlSessionDownloadDelegate () : base (NSObjectFlag.Empty)
		{
			IsDirectBinding = false;
			unsafe {
			var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
			InitializeHandle (global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (&__objc_super__, global::ObjCRuntime.Selector.GetHandle ("init")), "init");
			GC.KeepAlive (this);
			}
		}

		/// <summary>Constructor to call on derived classes to skip initialization and merely allocate the object.</summary>
		/// <param name="t">Unused sentinel value, pass NSObjectFlag.Empty.</param>
		/// <remarks>
		///     <para>
		///         This constructor should be called by derived classes when they completely construct the object in managed code and merely want the runtime to allocate and initialize the <see cref="Foundation.NSObject" />.
		///         This is required to implement the two-step initialization process that Objective-C uses, the first step is to perform the object allocation, the second step is to initialize the object.
		///         When developers invoke this constructor, they take advantage of a direct path that goes all the way up to <see cref="Foundation.NSObject" /> to merely allocate the object's memory and bind the Objective-C and C# objects together.
		///         The actual initialization of the object is up to the developer.
		///     </para>
		///     <para>
		///         This constructor is typically used by the binding generator to allocate the object, but prevent the actual initialization to take place.
		///         Once the allocation has taken place, the constructor has to initialize the object.
		///         With constructors generated by the binding generator this means that it manually invokes one of the "init" methods to initialize the object.
		///     </para>
		///     <para>It is the developer's responsibility to completely initialize the object if they chain up using this constructor chain.</para>
		///     <para>
		///         In general, if the developer's constructor invokes the corresponding base implementation, then it should also call an Objective-C init method.
		///         If this is not the case, developers should instead chain to the proper constructor in their class.
		///     </para>
		///     <para>
		///         The argument value is ignored and merely ensures that the only code that is executed is the construction phase is the basic <see cref="Foundation.NSObject" /> allocation and runtime type registration.
		///         Typically the chaining would look like this:
		///     </para>
		///     <example>
		///             <code lang="csharp lang-csharp"><![CDATA[
		/// //
		/// // The NSObjectFlag constructor merely allocates the object and registers the C# class with the Objective-C runtime if necessary.
		/// // No actual initXxx method is invoked, that is done later in the constructor
		/// //
		/// // This is taken from the iOS SDK's source code for the UIView class:
		/// //
		/// [Export ("initWithFrame:")]
		/// public UIView (CGRect frame) : base (NSObjectFlag.Empty)
		/// {
		///     // Invoke the init method now.
		///     var initWithFrame = new Selector ("initWithFrame:").Handle;
		///     if (IsDirectBinding) {
		///         Handle = ObjCRuntime.Messaging.IntPtr_objc_msgSend_CGRect (this.Handle, initWithFrame, frame);
		///     } else {
		///         unsafe {
		///             var __objc_super__ = new ObjCRuntime.ObjCSuper (this);
		///             Handle = ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper_CGRect (&__objc_super__, initWithFrame, frame);
		///         }
		///         GC.KeepAlive (this);
		///     }
		/// }
		/// ]]></code>
		///     </example>
		/// </remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected NSUrlSessionDownloadDelegate (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = false;
		}

		/// <summary>A constructor used when creating managed representations of unmanaged objects. Called by the runtime.</summary>
		/// <param name="handle">Pointer (handle) to the unmanaged object.</param>
		/// <remarks>
		///     <para>
		///         This constructor is invoked by the runtime infrastructure (<see cref="ObjCRuntime.Runtime.GetNSObject(System.IntPtr)" />) to create a new managed representation for a pointer to an unmanaged Objective-C object.
		///         Developers should not invoke this method directly, instead they should call <see cref="ObjCRuntime.Runtime.GetNSObject(System.IntPtr)" /> as it will prevent two instances of a managed object pointing to the same native object.
		///     </para>
		/// </remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal NSUrlSessionDownloadDelegate (NativeHandle handle) : base (handle)
		{
			IsDirectBinding = false;
		}

		/// <param name="session">To be added.</param><param name="downloadTask">To be added.</param><param name="location">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("URLSession:downloadTask:didFinishDownloadingToURL:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidFinishDownloading (NSUrlSession session, NSUrlSessionDownloadTask downloadTask, NSUrl location)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="session">To be added.</param><param name="downloadTask">To be added.</param><param name="resumeFileOffset">To be added.</param><param name="expectedTotalBytes">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("URLSession:downloadTask:didResumeAtOffset:expectedTotalBytes:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidResume (NSUrlSession session, NSUrlSessionDownloadTask downloadTask, long resumeFileOffset, long expectedTotalBytes)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="session">To be added.</param><param name="downloadTask">To be added.</param><param name="bytesWritten">To be added.</param><param name="totalBytesWritten">To be added.</param><param name="totalBytesExpectedToWrite">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("URLSession:downloadTask:didWriteData:totalBytesWritten:totalBytesExpectedToWrite:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidWriteData (NSUrlSession session, NSUrlSessionDownloadTask downloadTask, long bytesWritten, long totalBytesWritten, long totalBytesExpectedToWrite)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _TaskResumeDataKey;
		/// <summary>Represents the value associated with the constant NSURLSessionDownloadTaskResumeData</summary><value></value><remarks>To be added.</remarks>
		[Field ("NSURLSessionDownloadTaskResumeData",  "Foundation")]
		public static NSString TaskResumeDataKey {
			get {
				if (_TaskResumeDataKey is null)
					_TaskResumeDataKey = Dlfcn.GetStringConstant (Libraries.Foundation.Handle, "NSURLSessionDownloadTaskResumeData")!;
				return _TaskResumeDataKey;
			}
		}
	} /* class NSUrlSessionDownloadDelegate */
}
