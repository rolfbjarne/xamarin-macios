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
namespace PencilKit {
	[Register("PKInkingTool", true)]
	[SupportedOSPlatform ("ios13.0")]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("macos")]
	public unsafe partial class PKInkingTool : PKTool {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAzimuthX = "azimuth";
		static readonly NativeHandle selAzimuthXHandle = Selector.GetHandle ("azimuth");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selColorX = "color";
		static readonly NativeHandle selColorXHandle = Selector.GetHandle ("color");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selDefaultWidthForInkType_X = "defaultWidthForInkType:";
		static readonly NativeHandle selDefaultWidthForInkType_XHandle = Selector.GetHandle ("defaultWidthForInkType:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selInitWithInk_Width_X = "initWithInk:width:";
		static readonly NativeHandle selInitWithInk_Width_XHandle = Selector.GetHandle ("initWithInk:width:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selInitWithInkType_Color_X = "initWithInkType:color:";
		static readonly NativeHandle selInitWithInkType_Color_XHandle = Selector.GetHandle ("initWithInkType:color:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selInitWithInkType_Color_Width_X = "initWithInkType:color:width:";
		static readonly NativeHandle selInitWithInkType_Color_Width_XHandle = Selector.GetHandle ("initWithInkType:color:width:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selInitWithInkType_Color_Width_Azimuth_X = "initWithInkType:color:width:azimuth:";
		static readonly NativeHandle selInitWithInkType_Color_Width_Azimuth_XHandle = Selector.GetHandle ("initWithInkType:color:width:azimuth:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selInkX = "ink";
		static readonly NativeHandle selInkXHandle = Selector.GetHandle ("ink");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selInkTypeX = "inkType";
		static readonly NativeHandle selInkTypeXHandle = Selector.GetHandle ("inkType");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selInvertColor_X = "invertColor:";
		static readonly NativeHandle selInvertColor_XHandle = Selector.GetHandle ("invertColor:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selMaximumWidthForInkType_X = "maximumWidthForInkType:";
		static readonly NativeHandle selMaximumWidthForInkType_XHandle = Selector.GetHandle ("maximumWidthForInkType:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selMinimumWidthForInkType_X = "minimumWidthForInkType:";
		static readonly NativeHandle selMinimumWidthForInkType_XHandle = Selector.GetHandle ("minimumWidthForInkType:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selRequiredContentVersionX = "requiredContentVersion";
		static readonly NativeHandle selRequiredContentVersionXHandle = Selector.GetHandle ("requiredContentVersion");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selWidthX = "width";
		static readonly NativeHandle selWidthXHandle = Selector.GetHandle ("width");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly NativeHandle class_ptr = Class.GetHandle ("PKInkingTool");
		/// <summary>The Objective-C class handle for this class.</summary>
		/// <value>The pointer to the Objective-C class.</value>
		/// <remarks>
		///     Each managed class mirrors an unmanaged Objective-C class.
		///     This value contains the pointer to the Objective-C class.
		///     It is similar to calling the managed <see cref="ObjCRuntime.Class.GetHandle(string)" /> or the native <see href="https://developer.apple.com/documentation/objectivec/1418952-objc_getclass">objc_getClass</see> method with the type name.
		/// </remarks>
		public override NativeHandle ClassHandle { get { return class_ptr; } }
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
		protected PKInkingTool (NSObjectFlag t) : base (t)
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
		protected internal PKInkingTool (NativeHandle handle) : base (handle)
		{
		}

		[Export ("initWithInkType:color:width:")]
		[DesignatedInitializer]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public PKInkingTool ([BindAs (typeof (PKInkType), OriginalType = typeof (NSString))] global::PencilKit.PKInkType type, global::AppKit.NSColor color, nfloat width)
			: base (NSObjectFlag.Empty)
		{
			var color__handle__ = color!.GetNonNullHandle (nameof (color));
			using var nsb_type = global::PencilKit.PKInkTypeExtensions.GetConstant (type);
			if (IsDirectBinding) {
				InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_nfloat (this.Handle, selInitWithInkType_Color_Width_XHandle, nsb_type.GetHandle (), color__handle__, width), "initWithInkType:color:width:");
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_NativeHandle_nfloat (&__objc_super__, selInitWithInkType_Color_Width_XHandle, nsb_type.GetHandle (), color__handle__, width), "initWithInkType:color:width:");
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (color);
		}
		[Export ("initWithInkType:color:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public PKInkingTool ([BindAs (typeof (PKInkType), OriginalType = typeof (NSString))] global::PencilKit.PKInkType type, global::AppKit.NSColor color)
			: base (NSObjectFlag.Empty)
		{
			var color__handle__ = color!.GetNonNullHandle (nameof (color));
			using var nsb_type = global::PencilKit.PKInkTypeExtensions.GetConstant (type);
			if (IsDirectBinding) {
				InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (this.Handle, selInitWithInkType_Color_XHandle, nsb_type.GetHandle (), color__handle__), "initWithInkType:color:");
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, selInitWithInkType_Color_XHandle, nsb_type.GetHandle (), color__handle__), "initWithInkType:color:");
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (color);
		}
		[Export ("initWithInkType:color:width:azimuth:")]
		[SupportedOSPlatform ("macos26.0")]
		[SupportedOSPlatform ("ios26.0")]
		[SupportedOSPlatform ("maccatalyst26.0")]
		[DesignatedInitializer]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public PKInkingTool ([BindAs (typeof (PKInkType), OriginalType = typeof (NSString))] global::PencilKit.PKInkType type, global::AppKit.NSColor color, nfloat width, nfloat azimuth)
			: base (NSObjectFlag.Empty)
		{
			var color__handle__ = color!.GetNonNullHandle (nameof (color));
			using var nsb_type = global::PencilKit.PKInkTypeExtensions.GetConstant (type);
			if (IsDirectBinding) {
				InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_nfloat_nfloat (this.Handle, selInitWithInkType_Color_Width_Azimuth_XHandle, nsb_type.GetHandle (), color__handle__, width, azimuth), "initWithInkType:color:width:azimuth:");
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_NativeHandle_nfloat_nfloat (&__objc_super__, selInitWithInkType_Color_Width_Azimuth_XHandle, nsb_type.GetHandle (), color__handle__, width, azimuth), "initWithInkType:color:width:azimuth:");
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (color);
		}
		[Export ("initWithInk:width:")]
		[SupportedOSPlatform ("ios14.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public PKInkingTool (PKInk ink, nfloat width)
			: base (NSObjectFlag.Empty)
		{
			var ink__handle__ = ink!.GetNonNullHandle (nameof (ink));
			if (IsDirectBinding) {
				InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_nfloat (this.Handle, selInitWithInk_Width_XHandle, ink__handle__, width), "initWithInk:width:");
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_nfloat (&__objc_super__, selInitWithInk_Width_XHandle, ink__handle__, width), "initWithInk:width:");
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (ink);
		}
		[Export ("defaultWidthForInkType:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static nfloat GetDefaultWidth ([BindAs (typeof (PKInkType), OriginalType = typeof (NSString))] global::PencilKit.PKInkType inkType)
		{
			using var nsb_inkType = global::PencilKit.PKInkTypeExtensions.GetConstant (inkType);
			nfloat ret;
			ret = global::ObjCRuntime.Messaging.nfloat_objc_msgSend_NativeHandle (class_ptr, selDefaultWidthForInkType_XHandle, nsb_inkType.GetHandle ());
			return ret;
		}
		[Export ("maximumWidthForInkType:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static nfloat GetMaximumWidth ([BindAs (typeof (PKInkType), OriginalType = typeof (NSString))] global::PencilKit.PKInkType inkType)
		{
			using var nsb_inkType = global::PencilKit.PKInkTypeExtensions.GetConstant (inkType);
			nfloat ret;
			ret = global::ObjCRuntime.Messaging.nfloat_objc_msgSend_NativeHandle (class_ptr, selMaximumWidthForInkType_XHandle, nsb_inkType.GetHandle ());
			return ret;
		}
		[Export ("minimumWidthForInkType:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static nfloat GetMinimumWidth ([BindAs (typeof (PKInkType), OriginalType = typeof (NSString))] global::PencilKit.PKInkType inkType)
		{
			using var nsb_inkType = global::PencilKit.PKInkTypeExtensions.GetConstant (inkType);
			nfloat ret;
			ret = global::ObjCRuntime.Messaging.nfloat_objc_msgSend_NativeHandle (class_ptr, selMinimumWidthForInkType_XHandle, nsb_inkType.GetHandle ());
			return ret;
		}
		[Export ("invertColor:")]
		[SupportedOSPlatform ("ios26.0")]
		[SupportedOSPlatform ("macos26.0")]
		[SupportedOSPlatform ("maccatalyst26.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static CGColor InvertColor (CGColor color)
		{
			var color__handle__ = color!.GetNonNullHandle (nameof (color));
			CGColor? ret;
			ret = Runtime.GetINativeObject<global::CoreGraphics.CGColor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (class_ptr, selInvertColor_XHandle, color.Handle), false)!;
			GC.KeepAlive (color);
			return ret!;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("macos26.0")]
		[SupportedOSPlatform ("ios26.0")]
		[SupportedOSPlatform ("maccatalyst26.0")]
		public virtual nfloat Azimuth {
			[Export ("azimuth")]
			get {
				nfloat ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.nfloat_objc_msgSend (this.Handle, selAzimuthXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.nfloat_objc_msgSendSuper (&__objc_super__, selAzimuthXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual global::AppKit.NSColor Color {
			[Export ("color")]
			get {
				global::AppKit.NSColor? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<global::AppKit.NSColor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selColorXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<global::AppKit.NSColor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selColorXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("ios14.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public virtual PKInk Ink {
			[Export ("ink")]
			get {
				PKInk? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<PKInk> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selInkXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<PKInk> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selInkXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[BindAs (typeof (PKInkType), OriginalType = typeof (NSString))]
		public virtual global::PencilKit.PKInkType InkType {
			[Export ("inkType")]
			get {
				global::PencilKit.PKInkType ret;
				if (IsDirectBinding) {
					ret = global::PencilKit.PKInkTypeExtensions.GetValue (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selInkTypeXHandle));
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::PencilKit.PKInkTypeExtensions.GetValue (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selInkTypeXHandle));
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("macos14.0")]
		[SupportedOSPlatform ("ios17.0")]
		[SupportedOSPlatform ("maccatalyst17.0")]
		public virtual PKContentVersion RequiredContentVersion {
			[Export ("requiredContentVersion")]
			get {
				PKContentVersion ret;
				if (IsDirectBinding) {
					ret = (PencilKit.PKContentVersion) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selRequiredContentVersionXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = (PencilKit.PKContentVersion) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (&__objc_super__, selRequiredContentVersionXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual nfloat Width {
			[Export ("width")]
			get {
				nfloat ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.nfloat_objc_msgSend (this.Handle, selWidthXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.nfloat_objc_msgSendSuper (&__objc_super__, selWidthXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
	} /* class PKInkingTool */
}
