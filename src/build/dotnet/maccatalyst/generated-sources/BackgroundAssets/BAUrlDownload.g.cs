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
using Metal;
using CoreML;
using AppKit;
using MapKit;
using Photos;
using ModelIO;
using Network;
using SceneKit;
using Contacts;
using Security;
using CloudKit;
using Messages;
using AudioUnit;
using CoreVideo;
using CoreMedia;
using QuickLook;
using CoreImage;
using SpriteKit;
using Foundation;
using CoreMotion;
using ObjCRuntime;
using AddressBook;
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
	[Register("BAURLDownload", true)]
	[SupportedOSPlatform ("tvos18.4")]
	[SupportedOSPlatform ("macos13.0")]
	[SupportedOSPlatform ("ios16.0")]
	[SupportedOSPlatform ("maccatalyst16.0")]
	public unsafe partial class BAUrlDownload : BADownload {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly NativeHandle class_ptr = Class.GetHandle ("BAURLDownload");
		/// <summary>The Objective-C class handle for this class.</summary>
		/// <value>The pointer to the Objective-C class.</value>
		/// <remarks>
		///     Each managed class mirrors an unmanaged Objective-C class.
		///     This value contains the pointer to the Objective-C class.
		///     It is similar to calling the managed <see cref="ObjCRuntime.Class.GetHandle(string)" /> or the native <see href="https://developer.apple.com/documentation/objectivec/1418952-objc_getclass">objc_getClass</see> method with the type name.
		/// </remarks>
		public override NativeHandle ClassHandle { get { return class_ptr; } }
		/// <summary>A constructor that initializes the object from the data stored in the unarchiver object.</summary>
		/// <param name="coder">The unarchiver object.</param>
		/// <remarks>
		///   <para>This constructor is provided to allow the class to be initialized from an unarchiver (for example, during NIB deserialization). This is part of the <see cref="Foundation.NSCoding" /> protocol.</para>
		///   <para>If developers want to create a subclass of this object and continue to support deserialization from an archive, they should implement a constructor with an identical signature: taking a single parameter of type <see cref="Foundation.NSCoder" /> and decorate it with the <c>[Export("initWithCoder:"]</c> attribute.</para>
		///   <para>The state of this object can also be serialized by using the <see cref="Foundation.INSCoding.EncodeTo" /> companion method.</para>
		/// </remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[DesignatedInitializer]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("initWithCoder:")]
		public BAUrlDownload (NSCoder coder) : base (NSObjectFlag.Empty)
		{
			if (IsDirectBinding) {
				InitializeHandle (global::ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("initWithCoder:"), coder.Handle), "initWithCoder:");
			} else {
				unsafe {
				var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
				InitializeHandle (global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper_IntPtr (&__objc_super__, Selector.GetHandle ("initWithCoder:"), coder.Handle), "initWithCoder:");
				GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (coder);
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
		protected BAUrlDownload (NSObjectFlag t) : base (t)
		{
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
		protected internal BAUrlDownload (NativeHandle handle) : base (handle)
		{
		}

		[Export ("initWithIdentifier:request:applicationGroupIdentifier:")]
		[UnsupportedOSPlatform ("tvos")]
		[ObsoletedOSPlatform ("ios16.4")]
		[ObsoletedOSPlatform ("macos13.3")]
		[ObsoletedOSPlatform ("maccatalyst16.4")]
		[SupportedOSPlatform ("ios16.0")]
		[SupportedOSPlatform ("macos13.0")]
		[SupportedOSPlatform ("maccatalyst16.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public BAUrlDownload (string identifier, NSUrlRequest request, string applicationGroupIdentifier)
			: base (NSObjectFlag.Empty)
		{
			if (identifier is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (identifier));
			var request__handle__ = request!.GetNonNullHandle (nameof (request));
			if (applicationGroupIdentifier is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (applicationGroupIdentifier));
			var nsidentifier = CFString.CreateNative (identifier);
			var nsapplicationGroupIdentifier = CFString.CreateNative (applicationGroupIdentifier);
			if (IsDirectBinding) {
				InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("initWithIdentifier:request:applicationGroupIdentifier:"), nsidentifier, request__handle__, nsapplicationGroupIdentifier), "initWithIdentifier:request:applicationGroupIdentifier:");
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_NativeHandle_NativeHandle (&__objc_super__, Selector.GetHandle ("initWithIdentifier:request:applicationGroupIdentifier:"), nsidentifier, request__handle__, nsapplicationGroupIdentifier), "initWithIdentifier:request:applicationGroupIdentifier:");
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (request);
			CFString.ReleaseNative (nsidentifier);
			CFString.ReleaseNative (nsapplicationGroupIdentifier);
		}
		[Export ("initWithIdentifier:request:applicationGroupIdentifier:priority:")]
		[UnsupportedOSPlatform ("tvos")]
		[ObsoletedOSPlatform ("ios16.4")]
		[ObsoletedOSPlatform ("macos13.3")]
		[ObsoletedOSPlatform ("maccatalyst16.4")]
		[SupportedOSPlatform ("ios16.0")]
		[SupportedOSPlatform ("macos13.0")]
		[SupportedOSPlatform ("maccatalyst16.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public BAUrlDownload (string identifier, NSUrlRequest request, string applicationGroupIdentifier, nint priority)
			: base (NSObjectFlag.Empty)
		{
			if (identifier is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (identifier));
			var request__handle__ = request!.GetNonNullHandle (nameof (request));
			if (applicationGroupIdentifier is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (applicationGroupIdentifier));
			var nsidentifier = CFString.CreateNative (identifier);
			var nsapplicationGroupIdentifier = CFString.CreateNative (applicationGroupIdentifier);
			if (IsDirectBinding) {
				InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle_IntPtr (this.Handle, Selector.GetHandle ("initWithIdentifier:request:applicationGroupIdentifier:priority:"), nsidentifier, request__handle__, nsapplicationGroupIdentifier, priority), "initWithIdentifier:request:applicationGroupIdentifier:priority:");
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_NativeHandle_NativeHandle_IntPtr (&__objc_super__, Selector.GetHandle ("initWithIdentifier:request:applicationGroupIdentifier:priority:"), nsidentifier, request__handle__, nsapplicationGroupIdentifier, priority), "initWithIdentifier:request:applicationGroupIdentifier:priority:");
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (request);
			CFString.ReleaseNative (nsidentifier);
			CFString.ReleaseNative (nsapplicationGroupIdentifier);
		}
		[Export ("initWithIdentifier:request:fileSize:applicationGroupIdentifier:")]
		[SupportedOSPlatform ("macos13.3")]
		[SupportedOSPlatform ("ios16.4")]
		[SupportedOSPlatform ("maccatalyst16.4")]
		[SupportedOSPlatform ("tvos18.4")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public BAUrlDownload (string identifier, NSUrlRequest request, nuint fileSize, string applicationGroupIdentifier)
			: base (NSObjectFlag.Empty)
		{
			if (identifier is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (identifier));
			var request__handle__ = request!.GetNonNullHandle (nameof (request));
			if (applicationGroupIdentifier is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (applicationGroupIdentifier));
			var nsidentifier = CFString.CreateNative (identifier);
			var nsapplicationGroupIdentifier = CFString.CreateNative (applicationGroupIdentifier);
			if (IsDirectBinding) {
				InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_UIntPtr_NativeHandle (this.Handle, Selector.GetHandle ("initWithIdentifier:request:fileSize:applicationGroupIdentifier:"), nsidentifier, request__handle__, fileSize, nsapplicationGroupIdentifier), "initWithIdentifier:request:fileSize:applicationGroupIdentifier:");
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_NativeHandle_UIntPtr_NativeHandle (&__objc_super__, Selector.GetHandle ("initWithIdentifier:request:fileSize:applicationGroupIdentifier:"), nsidentifier, request__handle__, fileSize, nsapplicationGroupIdentifier), "initWithIdentifier:request:fileSize:applicationGroupIdentifier:");
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (request);
			CFString.ReleaseNative (nsidentifier);
			CFString.ReleaseNative (nsapplicationGroupIdentifier);
		}
		[Export ("initWithIdentifier:request:essential:fileSize:applicationGroupIdentifier:priority:")]
		[SupportedOSPlatform ("macos13.3")]
		[SupportedOSPlatform ("ios16.4")]
		[SupportedOSPlatform ("maccatalyst16.4")]
		[SupportedOSPlatform ("tvos18.4")]
		[DesignatedInitializer]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public BAUrlDownload (string identifier, NSUrlRequest request, bool essential, nuint fileSize, string applicationGroupIdentifier, nint priority)
			: base (NSObjectFlag.Empty)
		{
			if (identifier is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (identifier));
			var request__handle__ = request!.GetNonNullHandle (nameof (request));
			if (applicationGroupIdentifier is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (applicationGroupIdentifier));
			var nsidentifier = CFString.CreateNative (identifier);
			var nsapplicationGroupIdentifier = CFString.CreateNative (applicationGroupIdentifier);
			if (IsDirectBinding) {
				InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_bool_UIntPtr_NativeHandle_IntPtr (this.Handle, Selector.GetHandle ("initWithIdentifier:request:essential:fileSize:applicationGroupIdentifier:priority:"), nsidentifier, request__handle__, essential ? (byte) 1 : (byte) 0, fileSize, nsapplicationGroupIdentifier, priority), "initWithIdentifier:request:essential:fileSize:applicationGroupIdentifier:priority:");
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_NativeHandle_bool_UIntPtr_NativeHandle_IntPtr (&__objc_super__, Selector.GetHandle ("initWithIdentifier:request:essential:fileSize:applicationGroupIdentifier:priority:"), nsidentifier, request__handle__, essential ? (byte) 1 : (byte) 0, fileSize, nsapplicationGroupIdentifier, priority), "initWithIdentifier:request:essential:fileSize:applicationGroupIdentifier:priority:");
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (request);
			CFString.ReleaseNative (nsidentifier);
			CFString.ReleaseNative (nsapplicationGroupIdentifier);
		}
		/// <summary>Represents the value associated with the constant 'BADownloaderPriorityDefault'.</summary>
		[Field ("BADownloaderPriorityDefault",  "BackgroundAssets")]
		public static nint DefaultPriority {
			get {
				return Dlfcn.GetIntPtr (Libraries.BackgroundAssets.Handle, "BADownloaderPriorityDefault");
			}
		}
		/// <summary>Represents the value associated with the constant 'BADownloaderPriorityMax'.</summary>
		[Field ("BADownloaderPriorityMax",  "BackgroundAssets")]
		public static nint MaxPriority {
			get {
				return Dlfcn.GetIntPtr (Libraries.BackgroundAssets.Handle, "BADownloaderPriorityMax");
			}
		}
		/// <summary>Represents the value associated with the constant 'BADownloaderPriorityMin'.</summary>
		[Field ("BADownloaderPriorityMin",  "BackgroundAssets")]
		public static nint MinPriority {
			get {
				return Dlfcn.GetIntPtr (Libraries.BackgroundAssets.Handle, "BADownloaderPriorityMin");
			}
		}
	} /* class BAUrlDownload */
}
