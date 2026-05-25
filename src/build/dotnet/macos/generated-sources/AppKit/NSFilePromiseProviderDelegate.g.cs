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
namespace AppKit {
	#pragma warning disable CS1573
	/// <summary>This interface represents the Objective-C protocol <c>NSFilePromiseProviderDelegate</c>.</summary>
	/// <remarks>
	///   <para>A class that implements this interface (and subclasses <see cref="NSObject" />) will be exported to Objective-C as implementing the Objective-C protocol this interface represents.</para>
	///   <para>A class may also implement members from this interface to implement members from the protocol.</para>
	/// </remarks>
	[UnsupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("macos")]
	[Protocol (Name = "NSFilePromiseProviderDelegate", WrapperType = typeof (NSFilePromiseProviderDelegateWrapper))]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "GetFileNameForDestination", Selector = "filePromiseProvider:fileNameForType:", ReturnType = typeof (string), ParameterType = new Type [] { typeof (NSFilePromiseProvider), typeof (string) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "WritePromiseToUrl", Selector = "filePromiseProvider:writePromiseToURL:completionHandler:", ParameterType = new Type [] { typeof (NSFilePromiseProvider), typeof (NSUrl), typeof (global::System.Action<NSError>) }, ParameterByRef = new bool [] { false, false, false }, ParameterBlockProxy = new Type? [] { null, null, typeof (ObjCRuntime.Trampolines.NIDActionArity1V16) })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "GetOperationQueue", Selector = "operationQueueForFilePromiseProvider:", ReturnType = typeof (NSOperationQueue), ParameterType = new Type [] { typeof (NSFilePromiseProvider) }, ParameterByRef = new bool [] { false })]
	public partial interface INSFilePromiseProviderDelegate : INativeObject, IDisposable
	{
		/// <param name="filePromiseProvider">To be added.</param><param name="fileType">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.RequiredMember]
		[Export ("filePromiseProvider:fileNameForType:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string GetFileNameForDestination (NSFilePromiseProvider filePromiseProvider, string fileType)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="filePromiseProvider">To be added.</param><param name="fileType">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static string _GetFileNameForDestination (INSFilePromiseProviderDelegate This, NSFilePromiseProvider filePromiseProvider, string fileType)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var filePromiseProvider__handle__ = filePromiseProvider!.GetNonNullHandle (nameof (filePromiseProvider));
			if (fileType is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (fileType));
			var nsfileType = CFString.CreateNative (fileType);
			string? ret;
			ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("filePromiseProvider:fileNameForType:"), filePromiseProvider__handle__, nsfileType), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (filePromiseProvider);
			CFString.ReleaseNative (nsfileType);
			return ret!;
		}
		[global::Foundation.RequiredMember]
		[Export ("filePromiseProvider:writePromiseToURL:completionHandler:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void WritePromiseToUrl (NSFilePromiseProvider filePromiseProvider, NSUrl url, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V16))]global::System.Action<NSError>? completionHandler)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal unsafe static void _WritePromiseToUrl (INSFilePromiseProviderDelegate This, NSFilePromiseProvider filePromiseProvider, NSUrl url, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V16))]global::System.Action<NSError>? completionHandler)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var filePromiseProvider__handle__ = filePromiseProvider!.GetNonNullHandle (nameof (filePromiseProvider));
			var url__handle__ = url!.GetNonNullHandle (nameof (url));
			using var block_completionHandler = Trampolines.SDActionArity1V16.CreateNullableBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = null;
			if (completionHandler is not null)
				block_ptr_completionHandler = &block_completionHandler;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("filePromiseProvider:writePromiseToURL:completionHandler:"), filePromiseProvider__handle__, url__handle__, (IntPtr) block_ptr_completionHandler);
			GC.KeepAlive (This);
			GC.KeepAlive (filePromiseProvider);
			GC.KeepAlive (url);
		}
		/// <param name="filePromiseProvider">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("operationQueueForFilePromiseProvider:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSOperationQueue GetOperationQueue (NSFilePromiseProvider filePromiseProvider)
		{
			return _GetOperationQueue (this, filePromiseProvider);
		}
		/// <param name="filePromiseProvider">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static NSOperationQueue _GetOperationQueue (INSFilePromiseProviderDelegate This, NSFilePromiseProvider filePromiseProvider)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var filePromiseProvider__handle__ = filePromiseProvider!.GetNonNullHandle (nameof (filePromiseProvider));
			NSOperationQueue? ret;
			ret =  Runtime.GetNSObject<NSOperationQueue> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("operationQueueForFilePromiseProvider:"), filePromiseProvider__handle__), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (filePromiseProvider);
			return ret!;
		}
		[DynamicDependencyAttribute ("GetFileNameForDestination(AppKit.NSFilePromiseProvider,System.String)")]
		[DynamicDependencyAttribute ("GetOperationQueue(AppKit.NSFilePromiseProvider)")]
		[DynamicDependencyAttribute ("WritePromiseToUrl(AppKit.NSFilePromiseProvider,Foundation.NSUrl,System.Action{Foundation.NSError})")]
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.Interfaces | DynamicallyAccessedMemberTypes.PublicConstructors, typeof (NSFilePromiseProviderDelegateWrapper))]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static INSFilePromiseProviderDelegate ()
		{
			GC.KeepAlive (null);
		}
	}
	#pragma warning restore CS1573
	#pragma warning disable CS1573
	/// <summary>Extension methods to the <see cref="INSFilePromiseProviderDelegate" /> interface to support all the methods from the NSFilePromiseProviderDelegate protocol.</summary>
	/// <remarks>
	///   <para>The extension methods for <see cref="INSFilePromiseProviderDelegate" /> interface allow developers to treat instances of the interface as having all the optional methods of the original NSFilePromiseProviderDelegate protocol. Since the interface only contains the required members, these extension methods allow developers to call the optional members of the protocol.</para>
	/// </remarks>
	public unsafe static partial class NSFilePromiseProviderDelegate_Extensions {
		/// <param name="filePromiseProvider">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSOperationQueue GetOperationQueue (this INSFilePromiseProviderDelegate This, NSFilePromiseProvider filePromiseProvider)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var filePromiseProvider__handle__ = filePromiseProvider!.GetNonNullHandle (nameof (filePromiseProvider));
			NSOperationQueue? ret;
			ret =  Runtime.GetNSObject<NSOperationQueue> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("operationQueueForFilePromiseProvider:"), filePromiseProvider__handle__), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (filePromiseProvider);
			return ret!;
		}
	}
	#pragma warning restore CS1573
	internal unsafe sealed class NSFilePromiseProviderDelegateWrapper : BaseWrapper, INSFilePromiseProviderDelegate {
		public NSFilePromiseProviderDelegateWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.PublicConstructors, typeof (NSFilePromiseProviderDelegateWrapper))]
		static NSFilePromiseProviderDelegateWrapper ()
		{
			GC.KeepAlive (null);
		}
		/// <param name="filePromiseProvider">To be added.</param><param name="fileType">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("filePromiseProvider:fileNameForType:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public string GetFileNameForDestination (NSFilePromiseProvider filePromiseProvider, string fileType)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var filePromiseProvider__handle__ = filePromiseProvider!.GetNonNullHandle (nameof (filePromiseProvider));
			if (fileType is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (fileType));
			var nsfileType = CFString.CreateNative (fileType);
			string? ret;
			ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("filePromiseProvider:fileNameForType:"), filePromiseProvider__handle__, nsfileType), false)!;
			GC.KeepAlive (filePromiseProvider);
			CFString.ReleaseNative (nsfileType);
			return ret!;
		}
		[Export ("filePromiseProvider:writePromiseToURL:completionHandler:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe void WritePromiseToUrl (NSFilePromiseProvider filePromiseProvider, NSUrl url, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V16))]global::System.Action<NSError>? completionHandler)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var filePromiseProvider__handle__ = filePromiseProvider!.GetNonNullHandle (nameof (filePromiseProvider));
			var url__handle__ = url!.GetNonNullHandle (nameof (url));
			using var block_completionHandler = Trampolines.SDActionArity1V16.CreateNullableBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = null;
			if (completionHandler is not null)
				block_ptr_completionHandler = &block_completionHandler;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("filePromiseProvider:writePromiseToURL:completionHandler:"), filePromiseProvider__handle__, url__handle__, (IntPtr) block_ptr_completionHandler);
			GC.KeepAlive (filePromiseProvider);
			GC.KeepAlive (url);
		}
	}
}
namespace AppKit {
	/// <summary>
	///   <para>This is a class that implements the interface <see cref="INSFilePromiseProviderDelegate" /> (for the protocol <c>NSFilePromiseProviderDelegate</c>).</para>
	///   <para>Subclass this class to easily create a type that implements the protocol.</para>
	///   <para>An alternative is to create a subclass of <see cref="NSObject" /> and then implemented the interface <see cref="INSFilePromiseProviderDelegate" />.</para>
	/// </summary>
	[Protocol()]
	[Register("Microsoft_macOS__AppKit_NSFilePromiseProviderDelegate", false)]
	[Model]
	[UnsupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("macos")]
	public unsafe abstract partial class NSFilePromiseProviderDelegate : NSObject, INSFilePromiseProviderDelegate {
		/// <summary>Creates a new <see cref="NSFilePromiseProviderDelegate" /> with default values.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		protected NSFilePromiseProviderDelegate () : base (NSObjectFlag.Empty)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
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
		protected NSFilePromiseProviderDelegate (NSObjectFlag t) : base (t)
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
		protected internal NSFilePromiseProviderDelegate (NativeHandle handle) : base (handle)
		{
			IsDirectBinding = false;
		}

		/// <param name="filePromiseProvider">To be added.</param><param name="fileType">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("filePromiseProvider:fileNameForType:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string GetFileNameForDestination (NSFilePromiseProvider filePromiseProvider, string fileType)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="filePromiseProvider">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("operationQueueForFilePromiseProvider:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSOperationQueue GetOperationQueue (NSFilePromiseProvider filePromiseProvider)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("filePromiseProvider:writePromiseToURL:completionHandler:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void WritePromiseToUrl (NSFilePromiseProvider filePromiseProvider, NSUrl url, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V16))]global::System.Action<NSError>? completionHandler)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
	} /* class NSFilePromiseProviderDelegate */
}
