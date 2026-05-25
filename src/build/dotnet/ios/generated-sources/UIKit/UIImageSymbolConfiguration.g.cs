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
	[Register("UIImageSymbolConfiguration", true)]
	[SupportedOSPlatform ("tvos13.0")]
	[SupportedOSPlatform ("ios13.0")]
	[SupportedOSPlatform ("maccatalyst")]
	public unsafe partial class UIImageSymbolConfiguration : UIImageConfiguration {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly NativeHandle class_ptr = Class.GetHandle ("UIImageSymbolConfiguration");
		/// <summary>The Objective-C class handle for this class.</summary>
		/// <value>The pointer to the Objective-C class.</value>
		/// <remarks>
		///     Each managed class mirrors an unmanaged Objective-C class.
		///     This value contains the pointer to the Objective-C class.
		///     It is similar to calling the managed <see cref="ObjCRuntime.Class.GetHandle(string)" /> or the native <see href="https://developer.apple.com/documentation/objectivec/1418952-objc_getclass">objc_getClass</see> method with the type name.
		/// </remarks>
		public override NativeHandle ClassHandle { get { return class_ptr; } }
		/// <summary>Creates a new <see cref="UIImageSymbolConfiguration" /> with default values.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public UIImageSymbolConfiguration () : base (NSObjectFlag.Empty)
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
		public UIImageSymbolConfiguration (NSCoder coder) : base (NSObjectFlag.Empty)
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
		protected UIImageSymbolConfiguration (NSObjectFlag t) : base (t)
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
		protected internal UIImageSymbolConfiguration (NativeHandle handle) : base (handle)
		{
		}

		[Export ("configurationWithScale:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static UIImageSymbolConfiguration Create (UIImageSymbolScale scale)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			UIImageSymbolConfiguration ret;
			ret =  Runtime.GetNSObject<UIImageSymbolConfiguration> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_IntPtr (class_ptr, Selector.GetHandle ("configurationWithScale:"), (IntPtr) (long) scale), false)!;
			return ret;
		}
		[Export ("configurationWithPointSize:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static UIImageSymbolConfiguration Create (nfloat pointSize)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			UIImageSymbolConfiguration ret;
			ret =  Runtime.GetNSObject<UIImageSymbolConfiguration> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_nfloat (class_ptr, Selector.GetHandle ("configurationWithPointSize:"), pointSize), false)!;
			return ret;
		}
		[Export ("configurationWithWeight:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static UIImageSymbolConfiguration Create (UIImageSymbolWeight weight)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			UIImageSymbolConfiguration ret;
			ret =  Runtime.GetNSObject<UIImageSymbolConfiguration> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_IntPtr (class_ptr, Selector.GetHandle ("configurationWithWeight:"), (IntPtr) (long) weight), false)!;
			return ret;
		}
		[Export ("configurationWithPointSize:weight:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static UIImageSymbolConfiguration Create (nfloat pointSize, UIImageSymbolWeight weight)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			UIImageSymbolConfiguration ret;
			ret =  Runtime.GetNSObject<UIImageSymbolConfiguration> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_nfloat_IntPtr (class_ptr, Selector.GetHandle ("configurationWithPointSize:weight:"), pointSize, (IntPtr) (long) weight), false)!;
			return ret;
		}
		[Export ("configurationWithPointSize:weight:scale:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static UIImageSymbolConfiguration Create (nfloat pointSize, UIImageSymbolWeight weight, UIImageSymbolScale scale)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			UIImageSymbolConfiguration ret;
			ret =  Runtime.GetNSObject<UIImageSymbolConfiguration> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_nfloat_IntPtr_IntPtr (class_ptr, Selector.GetHandle ("configurationWithPointSize:weight:scale:"), pointSize, (IntPtr) (long) weight, (IntPtr) (long) scale), false)!;
			return ret;
		}
		[Export ("configurationWithTextStyle:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static UIImageSymbolConfiguration Create ([BindAs (typeof (UIFontTextStyle), OriginalType = typeof (NSString))] global::UIKit.UIFontTextStyle textStyle)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			using var nsb_textStyle = global::UIKit.UIFontTextStyleExtensions.GetConstant (textStyle);
			UIImageSymbolConfiguration ret;
			ret =  Runtime.GetNSObject<UIImageSymbolConfiguration> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (class_ptr, Selector.GetHandle ("configurationWithTextStyle:"), nsb_textStyle.GetHandle ()), false)!;
			return ret;
		}
		[Export ("configurationWithTextStyle:scale:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static UIImageSymbolConfiguration Create ([BindAs (typeof (UIFontTextStyle), OriginalType = typeof (NSString))] global::UIKit.UIFontTextStyle textStyle, UIImageSymbolScale scale)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			using var nsb_textStyle = global::UIKit.UIFontTextStyleExtensions.GetConstant (textStyle);
			UIImageSymbolConfiguration ret;
			ret =  Runtime.GetNSObject<UIImageSymbolConfiguration> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_IntPtr (class_ptr, Selector.GetHandle ("configurationWithTextStyle:scale:"), nsb_textStyle.GetHandle (), (IntPtr) (long) scale), false)!;
			return ret;
		}
		[Export ("configurationWithFont:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static UIImageSymbolConfiguration Create (UIFont font)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var font__handle__ = font!.GetNonNullHandle (nameof (font));
			UIImageSymbolConfiguration? ret;
			ret =  Runtime.GetNSObject<UIImageSymbolConfiguration> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (class_ptr, Selector.GetHandle ("configurationWithFont:"), font__handle__), false)!;
			GC.KeepAlive (font);
			return ret!;
		}
		[Export ("configurationWithFont:scale:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static UIImageSymbolConfiguration Create (UIFont font, UIImageSymbolScale scale)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var font__handle__ = font!.GetNonNullHandle (nameof (font));
			UIImageSymbolConfiguration? ret;
			ret =  Runtime.GetNSObject<UIImageSymbolConfiguration> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_IntPtr (class_ptr, Selector.GetHandle ("configurationWithFont:scale:"), font__handle__, (IntPtr) (long) scale), false)!;
			GC.KeepAlive (font);
			return ret!;
		}
		[Export ("configurationWithHierarchicalColor:")]
		[SupportedOSPlatform ("tvos15.0")]
		[SupportedOSPlatform ("ios15.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static UIImageSymbolConfiguration Create (UIColor hierarchicalColor)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var hierarchicalColor__handle__ = hierarchicalColor!.GetNonNullHandle (nameof (hierarchicalColor));
			UIImageSymbolConfiguration? ret;
			ret =  Runtime.GetNSObject<UIImageSymbolConfiguration> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (class_ptr, Selector.GetHandle ("configurationWithHierarchicalColor:"), hierarchicalColor__handle__), false)!;
			GC.KeepAlive (hierarchicalColor);
			return ret!;
		}
		[Export ("configurationWithPaletteColors:")]
		[SupportedOSPlatform ("tvos15.0")]
		[SupportedOSPlatform ("ios15.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static UIImageSymbolConfiguration Create (UIColor[] paletteColors)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			if (paletteColors is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (paletteColors));
			using var nsa_paletteColors = NSArray.FromNSObjects (paletteColors);
			UIImageSymbolConfiguration ret;
			ret =  Runtime.GetNSObject<UIImageSymbolConfiguration> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (class_ptr, Selector.GetHandle ("configurationWithPaletteColors:"), nsa_paletteColors.Handle), false)!;
			return ret;
		}
		[Export ("configurationWithColorRenderingMode:")]
		[SupportedOSPlatform ("tvos26.0")]
		[SupportedOSPlatform ("ios26.0")]
		[SupportedOSPlatform ("maccatalyst26.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static UIImageSymbolConfiguration Create (UIImageSymbolColorRenderingMode colorRenderingMode)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			UIImageSymbolConfiguration ret;
			ret =  Runtime.GetNSObject<UIImageSymbolConfiguration> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_IntPtr (class_ptr, Selector.GetHandle ("configurationWithColorRenderingMode:"), (IntPtr) (long) colorRenderingMode), false)!;
			return ret;
		}
		[Export ("configurationWithVariableValueMode:")]
		[SupportedOSPlatform ("tvos26.0")]
		[SupportedOSPlatform ("ios26.0")]
		[SupportedOSPlatform ("maccatalyst26.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static UIImageSymbolConfiguration Create (UIImageSymbolVariableValueMode variableValueMode)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			UIImageSymbolConfiguration ret;
			ret =  Runtime.GetNSObject<UIImageSymbolConfiguration> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_IntPtr (class_ptr, Selector.GetHandle ("configurationWithVariableValueMode:"), (IntPtr) (long) variableValueMode), false)!;
			return ret;
		}
		[Export ("configurationPreferringMonochrome")]
		[SupportedOSPlatform ("tvos16.0")]
		[SupportedOSPlatform ("maccatalyst16.0")]
		[SupportedOSPlatform ("ios16.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static UIImageSymbolConfiguration GetConfigurationPreferringMonochrome ()
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			UIImageSymbolConfiguration ret;
			ret =  Runtime.GetNSObject<UIImageSymbolConfiguration> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (class_ptr, Selector.GetHandle ("configurationPreferringMonochrome")), false)!;
			return ret;
		}
		[Export ("isEqualToConfiguration:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool IsEqualTo (UIImageSymbolConfiguration? otherConfiguration)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var otherConfiguration__handle__ = otherConfiguration.GetHandle ();
			byte ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("isEqualToConfiguration:"), otherConfiguration__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper_NativeHandle (&__objc_super__, Selector.GetHandle ("isEqualToConfiguration:"), otherConfiguration__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (otherConfiguration);
			return ret != 0;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("tvos15.0")]
		[SupportedOSPlatform ("ios15.0")]
		[SupportedOSPlatform ("maccatalyst")]
		public static UIImageSymbolConfiguration ConfigurationPreferringMulticolor {
			[Export ("configurationPreferringMulticolor")]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				UIImageSymbolConfiguration? ret;
				ret =  Runtime.GetNSObject<UIImageSymbolConfiguration> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (class_ptr, Selector.GetHandle ("configurationPreferringMulticolor")), false)!;
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual UIImageSymbolConfiguration ConfigurationWithoutPointSizeAndWeight {
			[Export ("configurationWithoutPointSizeAndWeight")]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				UIImageSymbolConfiguration? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<UIImageSymbolConfiguration> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("configurationWithoutPointSizeAndWeight")), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<UIImageSymbolConfiguration> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("configurationWithoutPointSizeAndWeight")), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual UIImageSymbolConfiguration ConfigurationWithoutScale {
			[Export ("configurationWithoutScale")]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				UIImageSymbolConfiguration? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<UIImageSymbolConfiguration> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("configurationWithoutScale")), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<UIImageSymbolConfiguration> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("configurationWithoutScale")), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual UIImageSymbolConfiguration ConfigurationWithoutTextStyle {
			[Export ("configurationWithoutTextStyle")]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				UIImageSymbolConfiguration? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<UIImageSymbolConfiguration> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("configurationWithoutTextStyle")), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<UIImageSymbolConfiguration> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("configurationWithoutTextStyle")), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual UIImageSymbolConfiguration ConfigurationWithoutWeight {
			[Export ("configurationWithoutWeight")]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				UIImageSymbolConfiguration? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<UIImageSymbolConfiguration> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("configurationWithoutWeight")), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<UIImageSymbolConfiguration> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("configurationWithoutWeight")), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static UIImageSymbolConfiguration UnspecifiedConfiguration {
			[Export ("unspecifiedConfiguration")]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				UIImageSymbolConfiguration? ret;
				ret =  Runtime.GetNSObject<UIImageSymbolConfiguration> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (class_ptr, Selector.GetHandle ("unspecifiedConfiguration")), false)!;
				return ret!;
			}
		}
	} /* class UIImageSymbolConfiguration */
}
