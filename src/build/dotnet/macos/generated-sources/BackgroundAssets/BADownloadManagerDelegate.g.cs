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
using Metal;
using CoreML;
using OpenGL;
using AppKit;
using Photos;
using ModelIO;
using Network;
using SceneKit;
using Contacts;
using Security;
using CloudKit;
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
using FileProvider;
using CoreAnimation;
using CoreFoundation;
using NetworkExtension;
using MetalPerformanceShadersGraph;
#nullable enable
namespace BackgroundAssets {
	#pragma warning disable CS1573
	/// <summary>This interface represents the Objective-C protocol <c>BADownloadManagerDelegate</c>.</summary>
	/// <remarks>
	///   <para>A class that implements this interface (and subclasses <see cref="NSObject" />) will be exported to Objective-C as implementing the Objective-C protocol this interface represents.</para>
	///   <para>A class may also implement members from this interface to implement members from the protocol.</para>
	/// </remarks>
	[SupportedOSPlatform ("tvos18.4")]
	[SupportedOSPlatform ("macos13.0")]
	[SupportedOSPlatform ("ios16.0")]
	[SupportedOSPlatform ("maccatalyst16.0")]
	[Protocol (Name = "BADownloadManagerDelegate", WrapperType = typeof (BADownloadManagerDelegateWrapper))]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidBegin", Selector = "downloadDidBegin:", ParameterType = new Type [] { typeof (BackgroundAssets.BADownload) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidPause", Selector = "downloadDidPause:", ParameterType = new Type [] { typeof (BackgroundAssets.BADownload) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidWriteBytes", Selector = "download:didWriteBytes:totalBytesWritten:totalBytesExpectedToWrite:", ParameterType = new Type [] { typeof (BackgroundAssets.BADownload), typeof (long), typeof (long), typeof (long) }, ParameterByRef = new bool [] { false, false, false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidReceiveChallenge", Selector = "download:didReceiveChallenge:completionHandler:", ParameterType = new Type [] { typeof (BackgroundAssets.BADownload), typeof (NSUrlAuthenticationChallenge), typeof (global::System.Action<NSUrlSessionAuthChallengeDisposition, NSUrlCredential>) }, ParameterByRef = new bool [] { false, false, false }, ParameterBlockProxy = new Type? [] { null, null, typeof (ObjCRuntime.Trampolines.NIDActionArity2V7) })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "Failed", Selector = "download:failedWithError:", ParameterType = new Type [] { typeof (BackgroundAssets.BADownload), typeof (NSError) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "Finished", Selector = "download:finishedWithFileURL:", ParameterType = new Type [] { typeof (BackgroundAssets.BADownload), typeof (NSUrl) }, ParameterByRef = new bool [] { false, false })]
	public partial interface IBADownloadManagerDelegate : INativeObject, IDisposable
	{
		[global::Foundation.OptionalMember]
		[Export ("downloadDidBegin:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidBegin (BADownload download)
		{
			_DidBegin (this, download);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _DidBegin (IBADownloadManagerDelegate This, BADownload download)
		{
			var download__handle__ = download!.GetNonNullHandle (nameof (download));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("downloadDidBegin:"), download__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (download);
		}
		[global::Foundation.OptionalMember]
		[Export ("downloadDidPause:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidPause (BADownload download)
		{
			_DidPause (this, download);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _DidPause (IBADownloadManagerDelegate This, BADownload download)
		{
			var download__handle__ = download!.GetNonNullHandle (nameof (download));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("downloadDidPause:"), download__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (download);
		}
		[global::Foundation.OptionalMember]
		[Export ("download:didWriteBytes:totalBytesWritten:totalBytesExpectedToWrite:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidWriteBytes (BADownload download, long bytesWritten, long totalBytesWritten, long totalExpectedBytes)
		{
			_DidWriteBytes (this, download, bytesWritten, totalBytesWritten, totalExpectedBytes);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _DidWriteBytes (IBADownloadManagerDelegate This, BADownload download, long bytesWritten, long totalBytesWritten, long totalExpectedBytes)
		{
			var download__handle__ = download!.GetNonNullHandle (nameof (download));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_Int64_Int64_Int64 (This.Handle, Selector.GetHandle ("download:didWriteBytes:totalBytesWritten:totalBytesExpectedToWrite:"), download__handle__, bytesWritten, totalBytesWritten, totalExpectedBytes);
			GC.KeepAlive (This);
			GC.KeepAlive (download);
		}
		[global::Foundation.OptionalMember]
		[Export ("download:didReceiveChallenge:completionHandler:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void DidReceiveChallenge (BADownload download, NSUrlAuthenticationChallenge challenge, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity2V7))]global::System.Action<NSUrlSessionAuthChallengeDisposition, NSUrlCredential> completionHandler)
		{
			_DidReceiveChallenge (this, download, challenge, completionHandler);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal unsafe static void _DidReceiveChallenge (IBADownloadManagerDelegate This, BADownload download, NSUrlAuthenticationChallenge challenge, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity2V7))]global::System.Action<NSUrlSessionAuthChallengeDisposition, NSUrlCredential> completionHandler)
		{
			var download__handle__ = download!.GetNonNullHandle (nameof (download));
			var challenge__handle__ = challenge!.GetNonNullHandle (nameof (challenge));
			if (completionHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completionHandler));
			using var block_completionHandler = Trampolines.SDActionArity2V7.CreateBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = &block_completionHandler;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("download:didReceiveChallenge:completionHandler:"), download__handle__, challenge__handle__, (IntPtr) block_ptr_completionHandler);
			GC.KeepAlive (This);
			GC.KeepAlive (download);
			GC.KeepAlive (challenge);
		}
		[global::Foundation.OptionalMember]
		[Export ("download:failedWithError:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void Failed (BADownload download, NSError error)
		{
			_Failed (this, download, error);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _Failed (IBADownloadManagerDelegate This, BADownload download, NSError error)
		{
			var download__handle__ = download!.GetNonNullHandle (nameof (download));
			var error__handle__ = error!.GetNonNullHandle (nameof (error));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("download:failedWithError:"), download__handle__, error__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (download);
			GC.KeepAlive (error);
		}
		[global::Foundation.OptionalMember]
		[Export ("download:finishedWithFileURL:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void Finished (BADownload download, NSUrl fileUrl)
		{
			_Finished (this, download, fileUrl);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _Finished (IBADownloadManagerDelegate This, BADownload download, NSUrl fileUrl)
		{
			var download__handle__ = download!.GetNonNullHandle (nameof (download));
			var fileUrl__handle__ = fileUrl!.GetNonNullHandle (nameof (fileUrl));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("download:finishedWithFileURL:"), download__handle__, fileUrl__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (download);
			GC.KeepAlive (fileUrl);
		}
		[DynamicDependencyAttribute ("DidBegin(BackgroundAssets.BADownload)")]
		[DynamicDependencyAttribute ("DidPause(BackgroundAssets.BADownload)")]
		[DynamicDependencyAttribute ("DidReceiveChallenge(BackgroundAssets.BADownload,Foundation.NSUrlAuthenticationChallenge,System.Action{Foundation.NSUrlSessionAuthChallengeDisposition,Foundation.NSUrlCredential})")]
		[DynamicDependencyAttribute ("DidWriteBytes(BackgroundAssets.BADownload,System.Int64,System.Int64,System.Int64)")]
		[DynamicDependencyAttribute ("Failed(BackgroundAssets.BADownload,Foundation.NSError)")]
		[DynamicDependencyAttribute ("Finished(BackgroundAssets.BADownload,Foundation.NSUrl)")]
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.Interfaces | DynamicallyAccessedMemberTypes.PublicConstructors, typeof (BADownloadManagerDelegateWrapper))]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static IBADownloadManagerDelegate ()
		{
			GC.KeepAlive (null);
		}
	}
	#pragma warning restore CS1573
	#pragma warning disable CS1573
	/// <summary>Extension methods to the <see cref="IBADownloadManagerDelegate" /> interface to support all the methods from the BADownloadManagerDelegate protocol.</summary>
	/// <remarks>
	///   <para>The extension methods for <see cref="IBADownloadManagerDelegate" /> interface allow developers to treat instances of the interface as having all the optional methods of the original BADownloadManagerDelegate protocol. Since the interface only contains the required members, these extension methods allow developers to call the optional members of the protocol.</para>
	/// </remarks>
	public unsafe static partial class BADownloadManagerDelegate_Extensions {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void DidBegin (this IBADownloadManagerDelegate This, BADownload download)
		{
			var download__handle__ = download!.GetNonNullHandle (nameof (download));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("downloadDidBegin:"), download__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (download);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void DidPause (this IBADownloadManagerDelegate This, BADownload download)
		{
			var download__handle__ = download!.GetNonNullHandle (nameof (download));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("downloadDidPause:"), download__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (download);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void DidWriteBytes (this IBADownloadManagerDelegate This, BADownload download, long bytesWritten, long totalBytesWritten, long totalExpectedBytes)
		{
			var download__handle__ = download!.GetNonNullHandle (nameof (download));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_Int64_Int64_Int64 (This.Handle, Selector.GetHandle ("download:didWriteBytes:totalBytesWritten:totalBytesExpectedToWrite:"), download__handle__, bytesWritten, totalBytesWritten, totalExpectedBytes);
			GC.KeepAlive (This);
			GC.KeepAlive (download);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static void DidReceiveChallenge (this IBADownloadManagerDelegate This, BADownload download, NSUrlAuthenticationChallenge challenge, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity2V7))]global::System.Action<NSUrlSessionAuthChallengeDisposition, NSUrlCredential> completionHandler)
		{
			var download__handle__ = download!.GetNonNullHandle (nameof (download));
			var challenge__handle__ = challenge!.GetNonNullHandle (nameof (challenge));
			if (completionHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completionHandler));
			using var block_completionHandler = Trampolines.SDActionArity2V7.CreateBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = &block_completionHandler;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("download:didReceiveChallenge:completionHandler:"), download__handle__, challenge__handle__, (IntPtr) block_ptr_completionHandler);
			GC.KeepAlive (This);
			GC.KeepAlive (download);
			GC.KeepAlive (challenge);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void Failed (this IBADownloadManagerDelegate This, BADownload download, NSError error)
		{
			var download__handle__ = download!.GetNonNullHandle (nameof (download));
			var error__handle__ = error!.GetNonNullHandle (nameof (error));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("download:failedWithError:"), download__handle__, error__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (download);
			GC.KeepAlive (error);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void Finished (this IBADownloadManagerDelegate This, BADownload download, NSUrl fileUrl)
		{
			var download__handle__ = download!.GetNonNullHandle (nameof (download));
			var fileUrl__handle__ = fileUrl!.GetNonNullHandle (nameof (fileUrl));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("download:finishedWithFileURL:"), download__handle__, fileUrl__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (download);
			GC.KeepAlive (fileUrl);
		}
	}
	#pragma warning restore CS1573
	internal unsafe sealed class BADownloadManagerDelegateWrapper : BaseWrapper, IBADownloadManagerDelegate {
		public BADownloadManagerDelegateWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.PublicConstructors, typeof (BADownloadManagerDelegateWrapper))]
		static BADownloadManagerDelegateWrapper ()
		{
			GC.KeepAlive (null);
		}
	}
}
namespace BackgroundAssets {
	/// <summary>
	///   <para>This is a class that implements the interface <see cref="IBADownloadManagerDelegate" /> (for the protocol <c>BADownloadManagerDelegate</c>).</para>
	///   <para>Subclass this class to easily create a type that implements the protocol.</para>
	///   <para>An alternative is to create a subclass of <see cref="NSObject" /> and then implemented the interface <see cref="IBADownloadManagerDelegate" />.</para>
	/// </summary>
	[Protocol()]
	[Register("Microsoft_macOS__BackgroundAssets_BADownloadManagerDelegate", false)]
	[Model]
	[SupportedOSPlatform ("tvos18.4")]
	[SupportedOSPlatform ("macos13.0")]
	[SupportedOSPlatform ("ios16.0")]
	[SupportedOSPlatform ("maccatalyst16.0")]
	public unsafe partial class BADownloadManagerDelegate : NSObject, IBADownloadManagerDelegate {
		/// <summary>Creates a new <see cref="BADownloadManagerDelegate" /> with default values.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public BADownloadManagerDelegate () : base (NSObjectFlag.Empty)
		{
			IsDirectBinding = false;
			unsafe {
			var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
			InitializeHandle (global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (&__objc_super__, global::ObjCRuntime.Selector.Init), "init");
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
		protected BADownloadManagerDelegate (NSObjectFlag t) : base (t)
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
		protected internal BADownloadManagerDelegate (NativeHandle handle) : base (handle)
		{
			IsDirectBinding = false;
		}

		[Export ("downloadDidBegin:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidBegin (BADownload download)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("downloadDidPause:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidPause (BADownload download)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("download:didReceiveChallenge:completionHandler:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void DidReceiveChallenge (BADownload download, NSUrlAuthenticationChallenge challenge, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity2V7))]global::System.Action<NSUrlSessionAuthChallengeDisposition, NSUrlCredential> completionHandler)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("download:didWriteBytes:totalBytesWritten:totalBytesExpectedToWrite:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidWriteBytes (BADownload download, long bytesWritten, long totalBytesWritten, long totalExpectedBytes)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("download:failedWithError:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void Failed (BADownload download, NSError error)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("download:finishedWithFileURL:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void Finished (BADownload download, NSUrl fileUrl)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
	} /* class BADownloadManagerDelegate */
}
