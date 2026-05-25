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
using MapKit;
using Photos;
using ModelIO;
using Network;
using SceneKit;
using Contacts;
using Security;
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
using NewsstandKit;
using FileProvider;
using CoreAnimation;
using CoreFoundation;
using NetworkExtension;
using MetalPerformanceShadersGraph;
#nullable enable
namespace UIKit {
	[Register("UIKeyCommand", true)]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("tvos")]
	public unsafe partial class UIKeyCommand : UICommand {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly NativeHandle class_ptr = Class.GetHandle ("UIKeyCommand");
		/// <summary>The Objective-C class handle for this class.</summary>
		/// <value>The pointer to the Objective-C class.</value>
		/// <remarks>
		///     Each managed class mirrors an unmanaged Objective-C class.
		///     This value contains the pointer to the Objective-C class.
		///     It is similar to calling the managed <see cref="ObjCRuntime.Class.GetHandle(string)" /> or the native <see href="https://developer.apple.com/documentation/objectivec/1418952-objc_getclass">objc_getClass</see> method with the type name.
		/// </remarks>
		public override NativeHandle ClassHandle { get { return class_ptr; } }
		/// <summary>Creates a new <see cref="UIKeyCommand" /> with default values.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[DesignatedInitializer]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public UIKeyCommand () : base (NSObjectFlag.Empty)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			if (IsDirectBinding) {
				InitializeHandle (global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, global::ObjCRuntime.Selector.GetHandle ("init")), "init");
			} else {
				unsafe {
				var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
				InitializeHandle (global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (&__objc_super__, global::ObjCRuntime.Selector.GetHandle ("init")), "init");
				GC.KeepAlive (this);
				}
			}
		}

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
		public UIKeyCommand (NSCoder coder) : base (NSObjectFlag.Empty)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
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
		protected UIKeyCommand (NSObjectFlag t) : base (t)
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
		protected internal UIKeyCommand (NativeHandle handle) : base (handle)
		{
		}

		[Export ("keyCommandWithInput:modifierFlags:action:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static UIKeyCommand Create (NSString keyCommandInput, UIKeyModifierFlags modifierFlags, Selector action)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var keyCommandInput__handle__ = keyCommandInput!.GetNonNullHandle (nameof (keyCommandInput));
			var action__handle__ = action!.GetNonNullHandle (nameof (action));
			UIKeyCommand? ret;
			ret =  Runtime.GetNSObject<UIKeyCommand> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_IntPtr_NativeHandle (class_ptr, Selector.GetHandle ("keyCommandWithInput:modifierFlags:action:"), keyCommandInput__handle__, (IntPtr) (long) modifierFlags, action.Handle), false)!;
			GC.KeepAlive (keyCommandInput);
			GC.KeepAlive (action);
			return ret!;
		}
		[Export ("commandWithTitle:image:action:input:modifierFlags:propertyList:")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("tvos13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static UIKeyCommand Create (string title, UIImage? image, Selector action, string input, UIKeyModifierFlags modifierFlags, NSObject? propertyList)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			if (title is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (title));
			var image__handle__ = image.GetHandle ();
			var action__handle__ = action!.GetNonNullHandle (nameof (action));
			if (input is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (input));
			var propertyList__handle__ = propertyList.GetHandle ();
			var nstitle = CFString.CreateNative (title);
			var nsinput = CFString.CreateNative (input);
			UIKeyCommand? ret;
			ret =  Runtime.GetNSObject<UIKeyCommand> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle_NativeHandle_IntPtr_NativeHandle (class_ptr, Selector.GetHandle ("commandWithTitle:image:action:input:modifierFlags:propertyList:"), nstitle, image__handle__, action.Handle, nsinput, (IntPtr) (long) modifierFlags, propertyList__handle__), false)!;
			GC.KeepAlive (image);
			GC.KeepAlive (action);
			GC.KeepAlive (propertyList);
			CFString.ReleaseNative (nstitle);
			CFString.ReleaseNative (nsinput);
			return ret!;
		}
		[Export ("commandWithTitle:image:action:input:modifierFlags:propertyList:alternates:")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("tvos13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static UIKeyCommand Create (string title, UIImage? image, Selector action, string input, UIKeyModifierFlags modifierFlags, NSObject? propertyList, UICommandAlternate[] alternates)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			if (title is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (title));
			var image__handle__ = image.GetHandle ();
			var action__handle__ = action!.GetNonNullHandle (nameof (action));
			if (input is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (input));
			var propertyList__handle__ = propertyList.GetHandle ();
			if (alternates is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (alternates));
			var nstitle = CFString.CreateNative (title);
			var nsinput = CFString.CreateNative (input);
			using var nsa_alternates = NSArray.FromNSObjects (alternates);
			UIKeyCommand? ret;
			ret =  Runtime.GetNSObject<UIKeyCommand> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle_NativeHandle_IntPtr_NativeHandle_NativeHandle (class_ptr, Selector.GetHandle ("commandWithTitle:image:action:input:modifierFlags:propertyList:alternates:"), nstitle, image__handle__, action.Handle, nsinput, (IntPtr) (long) modifierFlags, propertyList__handle__, nsa_alternates.Handle), false)!;
			GC.KeepAlive (image);
			GC.KeepAlive (action);
			GC.KeepAlive (propertyList);
			CFString.ReleaseNative (nstitle);
			CFString.ReleaseNative (nsinput);
			return ret!;
		}
		[Export ("keyCommandWithInput:modifierFlags:action:discoverabilityTitle:")]
		[ObsoletedOSPlatform ("ios13.0", "Use 'UIKeyCommand.Create (NSString, UIKeyModifierFlags, Selector)' overload instead.")]
		[ObsoletedOSPlatform ("tvos13.0", "Use 'UIKeyCommand.Create (NSString, UIKeyModifierFlags, Selector)' overload instead.")]
		[SupportedOSPlatform ("maccatalyst")]
		[ObsoletedOSPlatform ("maccatalyst13.1", "Use 'UIKeyCommand.Create (NSString, UIKeyModifierFlags, Selector)' overload instead.")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static UIKeyCommand Create (NSString keyCommandInput, UIKeyModifierFlags modifierFlags, Selector action, NSString discoverabilityTitle)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var keyCommandInput__handle__ = keyCommandInput!.GetNonNullHandle (nameof (keyCommandInput));
			var action__handle__ = action!.GetNonNullHandle (nameof (action));
			var discoverabilityTitle__handle__ = discoverabilityTitle!.GetNonNullHandle (nameof (discoverabilityTitle));
			UIKeyCommand? ret;
			ret =  Runtime.GetNSObject<UIKeyCommand> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_IntPtr_NativeHandle_NativeHandle (class_ptr, Selector.GetHandle ("keyCommandWithInput:modifierFlags:action:discoverabilityTitle:"), keyCommandInput__handle__, (IntPtr) (long) modifierFlags, action.Handle, discoverabilityTitle__handle__), false)!;
			GC.KeepAlive (keyCommandInput);
			GC.KeepAlive (action);
			GC.KeepAlive (discoverabilityTitle);
			return ret!;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("ios15.0")]
		[SupportedOSPlatform ("tvos15.0")]
		[SupportedOSPlatform ("maccatalyst")]
		public virtual bool AllowsAutomaticLocalization {
			[Export ("allowsAutomaticLocalization")]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("allowsAutomaticLocalization"));
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("allowsAutomaticLocalization"));
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
			[Export ("setAllowsAutomaticLocalization:")]
			set {
				global::UIKit.UIApplication.EnsureUIThread ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("setAllowsAutomaticLocalization:"), value ? (byte) 1 : (byte) 0);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (&__objc_super__, Selector.GetHandle ("setAllowsAutomaticLocalization:"), value ? (byte) 1 : (byte) 0);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("ios15.0")]
		[SupportedOSPlatform ("tvos15.0")]
		[SupportedOSPlatform ("maccatalyst")]
		public virtual bool AllowsAutomaticMirroring {
			[Export ("allowsAutomaticMirroring")]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("allowsAutomaticMirroring"));
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("allowsAutomaticMirroring"));
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
			[Export ("setAllowsAutomaticMirroring:")]
			set {
				global::UIKit.UIApplication.EnsureUIThread ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("setAllowsAutomaticMirroring:"), value ? (byte) 1 : (byte) 0);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (&__objc_super__, Selector.GetHandle ("setAllowsAutomaticMirroring:"), value ? (byte) 1 : (byte) 0);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("tvos13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		public virtual UICommandAlternate[] Alternates {
			[Export ("alternates")]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				UICommandAlternate[]? ret;
				if (IsDirectBinding) {
					ret = CFArray.ArrayFromHandle<UICommandAlternate>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("alternates")), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFArray.ArrayFromHandle<UICommandAlternate>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("alternates")), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("tvos13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		public virtual UIMenuElementAttributes Attributes {
			[Export ("attributes", ArgumentSemantic.Assign)]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				UIMenuElementAttributes ret;
				if (IsDirectBinding) {
					ret = (UIMenuElementAttributes) (ulong) global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("attributes"));
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = (UIMenuElementAttributes) (ulong) global::ObjCRuntime.Messaging.UIntPtr_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("attributes"));
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setAttributes:", ArgumentSemantic.Assign)]
			set {
				global::UIKit.UIApplication.EnsureUIThread ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_UIntPtr (this.Handle, Selector.GetHandle ("setAttributes:"), (UIntPtr) (ulong) value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_UIntPtr (&__objc_super__, Selector.GetHandle ("setAttributes:"), (UIntPtr) (ulong) value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		public virtual NSString? DiscoverabilityTitle {
			[Export ("discoverabilityTitle")]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				NSString? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSString> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("discoverabilityTitle")), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<NSString> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("discoverabilityTitle")), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setDiscoverabilityTitle:")]
			set {
				global::UIKit.UIApplication.EnsureUIThread ();
				var value__handle__ = value.GetHandle ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("setDiscoverabilityTitle:"), value__handle__);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, Selector.GetHandle ("setDiscoverabilityTitle:"), value__handle__);
						GC.KeepAlive (this);
					}
				}
				GC.KeepAlive (value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("tvos13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		public virtual UIImage? Image {
			[Export ("image", ArgumentSemantic.Copy)]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				UIImage? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<UIImage> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("image")), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<UIImage> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("image")), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setImage:", ArgumentSemantic.Copy)]
			set {
				global::UIKit.UIApplication.EnsureUIThread ();
				var value__handle__ = value.GetHandle ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("setImage:"), value__handle__);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, Selector.GetHandle ("setImage:"), value__handle__);
						GC.KeepAlive (this);
					}
				}
				GC.KeepAlive (value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSString? Input {
			[Export ("input")]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				NSString? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSString> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("input")), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<NSString> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("input")), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual UIKeyModifierFlags ModifierFlags {
			[Export ("modifierFlags")]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				UIKeyModifierFlags ret;
				if (IsDirectBinding) {
					ret = (UIKeyModifierFlags) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("modifierFlags"));
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = (UIKeyModifierFlags) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("modifierFlags"));
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("tvos13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		public virtual NSObject? PropertyList {
			[Export ("propertyList")]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				NSObject? ret;
				if (IsDirectBinding) {
					ret = Runtime.GetNSObject (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("propertyList")), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = Runtime.GetNSObject (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("propertyList")), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("tvos13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		public virtual UIMenuElementState State {
			[Export ("state", ArgumentSemantic.Assign)]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				UIMenuElementState ret;
				if (IsDirectBinding) {
					ret = (UIMenuElementState) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("state"));
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = (UIMenuElementState) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("state"));
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setState:", ArgumentSemantic.Assign)]
			set {
				global::UIKit.UIApplication.EnsureUIThread ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setState:"), (IntPtr) (long) value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (&__objc_super__, Selector.GetHandle ("setState:"), (IntPtr) (long) value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("tvos13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		public virtual string Title {
			[Export ("title")]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				string ret;
				if (IsDirectBinding) {
					ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("title")), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("title")), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[Export ("setTitle:")]
			set {
				global::UIKit.UIApplication.EnsureUIThread ();
				if (value is null)
					ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (value));
				var nsvalue = CFString.CreateNative (value);
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("setTitle:"), nsvalue);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, Selector.GetHandle ("setTitle:"), nsvalue);
						GC.KeepAlive (this);
					}
				}
				CFString.ReleaseNative (nsvalue);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("ios15.0")]
		[SupportedOSPlatform ("tvos15.0")]
		[SupportedOSPlatform ("maccatalyst")]
		public virtual bool WantsPriorityOverSystemBehavior {
			[Export ("wantsPriorityOverSystemBehavior")]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("wantsPriorityOverSystemBehavior"));
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("wantsPriorityOverSystemBehavior"));
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
			[Export ("setWantsPriorityOverSystemBehavior:")]
			set {
				global::UIKit.UIApplication.EnsureUIThread ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("setWantsPriorityOverSystemBehavior:"), value ? (byte) 1 : (byte) 0);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (&__objc_super__, Selector.GetHandle ("setWantsPriorityOverSystemBehavior:"), value ? (byte) 1 : (byte) 0);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _Delete;
		/// <summary>Represents the value associated with the constant 'UIKeyInputDelete'.</summary>
		[Field ("UIKeyInputDelete",  "UIKit")]
		[SupportedOSPlatform ("ios15.0")]
		[SupportedOSPlatform ("tvos15.0")]
		[SupportedOSPlatform ("maccatalyst")]
		public static NSString Delete {
			[SupportedOSPlatform ("ios15.0")]
			[SupportedOSPlatform ("tvos15.0")]
			[SupportedOSPlatform ("maccatalyst")]
			get {
				if (_Delete is null)
					_Delete = Dlfcn.GetStringConstant (Libraries.UIKit.Handle, "UIKeyInputDelete")!;
				return _Delete;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _DownArrow;
		/// <summary>Represents the value associated with the constant UIKeyInputDownArrow</summary><value></value><remarks>To be added.</remarks>
		[Field ("UIKeyInputDownArrow",  "UIKit")]
		public static NSString DownArrow {
			get {
				if (_DownArrow is null)
					_DownArrow = Dlfcn.GetStringConstant (Libraries.UIKit.Handle, "UIKeyInputDownArrow")!;
				return _DownArrow;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _End;
		/// <summary>Represents the value associated with the constant 'UIKeyInputEnd'.</summary>
		[Field ("UIKeyInputEnd",  "UIKit")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios13.4")]
		[SupportedOSPlatform ("tvos13.4")]
		public static NSString End {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios13.4")]
			[SupportedOSPlatform ("tvos13.4")]
			get {
				if (_End is null)
					_End = Dlfcn.GetStringConstant (Libraries.UIKit.Handle, "UIKeyInputEnd")!;
				return _End;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _Escape;
		/// <summary>Represents the value associated with the constant UIKeyInputEscape</summary><value></value><remarks>To be added.</remarks>
		[Field ("UIKeyInputEscape",  "UIKit")]
		public static NSString Escape {
			get {
				if (_Escape is null)
					_Escape = Dlfcn.GetStringConstant (Libraries.UIKit.Handle, "UIKeyInputEscape")!;
				return _Escape;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _F1;
		/// <summary>Represents the value associated with the constant 'UIKeyInputF1'.</summary>
		[Field ("UIKeyInputF1",  "UIKit")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios13.4")]
		[SupportedOSPlatform ("tvos13.4")]
		public static NSString F1 {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios13.4")]
			[SupportedOSPlatform ("tvos13.4")]
			get {
				if (_F1 is null)
					_F1 = Dlfcn.GetStringConstant (Libraries.UIKit.Handle, "UIKeyInputF1")!;
				return _F1;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _F10;
		/// <summary>Represents the value associated with the constant 'UIKeyInputF10'.</summary>
		[Field ("UIKeyInputF10",  "UIKit")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios13.4")]
		[SupportedOSPlatform ("tvos13.4")]
		public static NSString F10 {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios13.4")]
			[SupportedOSPlatform ("tvos13.4")]
			get {
				if (_F10 is null)
					_F10 = Dlfcn.GetStringConstant (Libraries.UIKit.Handle, "UIKeyInputF10")!;
				return _F10;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _F11;
		/// <summary>Represents the value associated with the constant 'UIKeyInputF11'.</summary>
		[Field ("UIKeyInputF11",  "UIKit")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios13.4")]
		[SupportedOSPlatform ("tvos13.4")]
		public static NSString F11 {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios13.4")]
			[SupportedOSPlatform ("tvos13.4")]
			get {
				if (_F11 is null)
					_F11 = Dlfcn.GetStringConstant (Libraries.UIKit.Handle, "UIKeyInputF11")!;
				return _F11;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _F12;
		/// <summary>Represents the value associated with the constant 'UIKeyInputF12'.</summary>
		[Field ("UIKeyInputF12",  "UIKit")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios13.4")]
		[SupportedOSPlatform ("tvos13.4")]
		public static NSString F12 {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios13.4")]
			[SupportedOSPlatform ("tvos13.4")]
			get {
				if (_F12 is null)
					_F12 = Dlfcn.GetStringConstant (Libraries.UIKit.Handle, "UIKeyInputF12")!;
				return _F12;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _F2;
		/// <summary>Represents the value associated with the constant 'UIKeyInputF2'.</summary>
		[Field ("UIKeyInputF2",  "UIKit")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios13.4")]
		[SupportedOSPlatform ("tvos13.4")]
		public static NSString F2 {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios13.4")]
			[SupportedOSPlatform ("tvos13.4")]
			get {
				if (_F2 is null)
					_F2 = Dlfcn.GetStringConstant (Libraries.UIKit.Handle, "UIKeyInputF2")!;
				return _F2;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _F3;
		/// <summary>Represents the value associated with the constant 'UIKeyInputF3'.</summary>
		[Field ("UIKeyInputF3",  "UIKit")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios13.4")]
		[SupportedOSPlatform ("tvos13.4")]
		public static NSString F3 {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios13.4")]
			[SupportedOSPlatform ("tvos13.4")]
			get {
				if (_F3 is null)
					_F3 = Dlfcn.GetStringConstant (Libraries.UIKit.Handle, "UIKeyInputF3")!;
				return _F3;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _F4;
		/// <summary>Represents the value associated with the constant 'UIKeyInputF4'.</summary>
		[Field ("UIKeyInputF4",  "UIKit")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios13.4")]
		[SupportedOSPlatform ("tvos13.4")]
		public static NSString F4 {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios13.4")]
			[SupportedOSPlatform ("tvos13.4")]
			get {
				if (_F4 is null)
					_F4 = Dlfcn.GetStringConstant (Libraries.UIKit.Handle, "UIKeyInputF4")!;
				return _F4;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _F5;
		/// <summary>Represents the value associated with the constant 'UIKeyInputF5'.</summary>
		[Field ("UIKeyInputF5",  "UIKit")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios13.4")]
		[SupportedOSPlatform ("tvos13.4")]
		public static NSString F5 {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios13.4")]
			[SupportedOSPlatform ("tvos13.4")]
			get {
				if (_F5 is null)
					_F5 = Dlfcn.GetStringConstant (Libraries.UIKit.Handle, "UIKeyInputF5")!;
				return _F5;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _F6;
		/// <summary>Represents the value associated with the constant 'UIKeyInputF6'.</summary>
		[Field ("UIKeyInputF6",  "UIKit")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios13.4")]
		[SupportedOSPlatform ("tvos13.4")]
		public static NSString F6 {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios13.4")]
			[SupportedOSPlatform ("tvos13.4")]
			get {
				if (_F6 is null)
					_F6 = Dlfcn.GetStringConstant (Libraries.UIKit.Handle, "UIKeyInputF6")!;
				return _F6;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _F7;
		/// <summary>Represents the value associated with the constant 'UIKeyInputF7'.</summary>
		[Field ("UIKeyInputF7",  "UIKit")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios13.4")]
		[SupportedOSPlatform ("tvos13.4")]
		public static NSString F7 {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios13.4")]
			[SupportedOSPlatform ("tvos13.4")]
			get {
				if (_F7 is null)
					_F7 = Dlfcn.GetStringConstant (Libraries.UIKit.Handle, "UIKeyInputF7")!;
				return _F7;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _F8;
		/// <summary>Represents the value associated with the constant 'UIKeyInputF8'.</summary>
		[Field ("UIKeyInputF8",  "UIKit")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios13.4")]
		[SupportedOSPlatform ("tvos13.4")]
		public static NSString F8 {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios13.4")]
			[SupportedOSPlatform ("tvos13.4")]
			get {
				if (_F8 is null)
					_F8 = Dlfcn.GetStringConstant (Libraries.UIKit.Handle, "UIKeyInputF8")!;
				return _F8;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _F9;
		/// <summary>Represents the value associated with the constant 'UIKeyInputF9'.</summary>
		[Field ("UIKeyInputF9",  "UIKit")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios13.4")]
		[SupportedOSPlatform ("tvos13.4")]
		public static NSString F9 {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios13.4")]
			[SupportedOSPlatform ("tvos13.4")]
			get {
				if (_F9 is null)
					_F9 = Dlfcn.GetStringConstant (Libraries.UIKit.Handle, "UIKeyInputF9")!;
				return _F9;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _Home;
		/// <summary>Represents the value associated with the constant 'UIKeyInputHome'.</summary>
		[Field ("UIKeyInputHome",  "UIKit")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios13.4")]
		[SupportedOSPlatform ("tvos13.4")]
		public static NSString Home {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios13.4")]
			[SupportedOSPlatform ("tvos13.4")]
			get {
				if (_Home is null)
					_Home = Dlfcn.GetStringConstant (Libraries.UIKit.Handle, "UIKeyInputHome")!;
				return _Home;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _LeftArrow;
		/// <summary>Represents the value associated with the constant UIKeyInputLeftArrow</summary><value></value><remarks>To be added.</remarks>
		[Field ("UIKeyInputLeftArrow",  "UIKit")]
		public static NSString LeftArrow {
			get {
				if (_LeftArrow is null)
					_LeftArrow = Dlfcn.GetStringConstant (Libraries.UIKit.Handle, "UIKeyInputLeftArrow")!;
				return _LeftArrow;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _PageDown;
		/// <summary>Represents the value associated with the constant 'UIKeyInputPageDown'.</summary>
		[Field ("UIKeyInputPageDown",  "UIKit")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios13.4")]
		[SupportedOSPlatform ("tvos13.4")]
		public static NSString PageDown {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios13.4")]
			[SupportedOSPlatform ("tvos13.4")]
			get {
				if (_PageDown is null)
					_PageDown = Dlfcn.GetStringConstant (Libraries.UIKit.Handle, "UIKeyInputPageDown")!;
				return _PageDown;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _PageUp;
		/// <summary>Represents the value associated with the constant 'UIKeyInputPageUp'.</summary>
		[Field ("UIKeyInputPageUp",  "UIKit")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios13.4")]
		[SupportedOSPlatform ("tvos13.4")]
		public static NSString PageUp {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios13.4")]
			[SupportedOSPlatform ("tvos13.4")]
			get {
				if (_PageUp is null)
					_PageUp = Dlfcn.GetStringConstant (Libraries.UIKit.Handle, "UIKeyInputPageUp")!;
				return _PageUp;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _RightArrow;
		/// <summary>Represents the value associated with the constant UIKeyInputRightArrow</summary><value></value><remarks>To be added.</remarks>
		[Field ("UIKeyInputRightArrow",  "UIKit")]
		public static NSString RightArrow {
			get {
				if (_RightArrow is null)
					_RightArrow = Dlfcn.GetStringConstant (Libraries.UIKit.Handle, "UIKeyInputRightArrow")!;
				return _RightArrow;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _UpArrow;
		/// <summary>Represents the value associated with the constant UIKeyInputUpArrow</summary><value></value><remarks>To be added.</remarks>
		[Field ("UIKeyInputUpArrow",  "UIKit")]
		public static NSString UpArrow {
			get {
				if (_UpArrow is null)
					_UpArrow = Dlfcn.GetStringConstant (Libraries.UIKit.Handle, "UIKeyInputUpArrow")!;
				return _UpArrow;
			}
		}
	} /* class UIKeyCommand */
}
