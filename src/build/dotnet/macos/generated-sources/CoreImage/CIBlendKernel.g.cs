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
namespace CoreImage {
	/// <summary>A <see cref="T:CoreImage.CIColorKernel" /> that blends images using the GPU.</summary>
	[Register("CIBlendKernel", true)]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("tvos")]
	public unsafe partial class CIBlendKernel : CIColorKernel {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selApplyWithForeground_Background_X = "applyWithForeground:background:";
		static readonly NativeHandle selApplyWithForeground_Background_XHandle = Selector.GetHandle ("applyWithForeground:background:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selApplyWithForeground_Background_ColorSpace_X = "applyWithForeground:background:colorSpace:";
		static readonly NativeHandle selApplyWithForeground_Background_ColorSpace_XHandle = Selector.GetHandle ("applyWithForeground:background:colorSpace:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selClearX = "clear";
		static readonly NativeHandle selClearXHandle = Selector.GetHandle ("clear");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selColorX = "color";
		static readonly NativeHandle selColorXHandle = Selector.GetHandle ("color");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selColorBurnX = "colorBurn";
		static readonly NativeHandle selColorBurnXHandle = Selector.GetHandle ("colorBurn");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selColorDodgeX = "colorDodge";
		static readonly NativeHandle selColorDodgeXHandle = Selector.GetHandle ("colorDodge");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selComponentAddX = "componentAdd";
		static readonly NativeHandle selComponentAddXHandle = Selector.GetHandle ("componentAdd");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selComponentMaxX = "componentMax";
		static readonly NativeHandle selComponentMaxXHandle = Selector.GetHandle ("componentMax");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selComponentMinX = "componentMin";
		static readonly NativeHandle selComponentMinXHandle = Selector.GetHandle ("componentMin");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selComponentMultiplyX = "componentMultiply";
		static readonly NativeHandle selComponentMultiplyXHandle = Selector.GetHandle ("componentMultiply");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selDarkenX = "darken";
		static readonly NativeHandle selDarkenXHandle = Selector.GetHandle ("darken");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selDarkerColorX = "darkerColor";
		static readonly NativeHandle selDarkerColorXHandle = Selector.GetHandle ("darkerColor");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selDestinationX = "destination";
		static readonly NativeHandle selDestinationXHandle = Selector.GetHandle ("destination");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selDestinationAtopX = "destinationAtop";
		static readonly NativeHandle selDestinationAtopXHandle = Selector.GetHandle ("destinationAtop");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selDestinationInX = "destinationIn";
		static readonly NativeHandle selDestinationInXHandle = Selector.GetHandle ("destinationIn");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selDestinationOutX = "destinationOut";
		static readonly NativeHandle selDestinationOutXHandle = Selector.GetHandle ("destinationOut");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selDestinationOverX = "destinationOver";
		static readonly NativeHandle selDestinationOverXHandle = Selector.GetHandle ("destinationOver");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selDifferenceX = "difference";
		static readonly NativeHandle selDifferenceXHandle = Selector.GetHandle ("difference");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selDivideX = "divide";
		static readonly NativeHandle selDivideXHandle = Selector.GetHandle ("divide");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selExclusionX = "exclusion";
		static readonly NativeHandle selExclusionXHandle = Selector.GetHandle ("exclusion");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selExclusiveOrX = "exclusiveOr";
		static readonly NativeHandle selExclusiveOrXHandle = Selector.GetHandle ("exclusiveOr");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selHardLightX = "hardLight";
		static readonly NativeHandle selHardLightXHandle = Selector.GetHandle ("hardLight");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selHardMixX = "hardMix";
		static readonly NativeHandle selHardMixXHandle = Selector.GetHandle ("hardMix");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selHueX = "hue";
		static readonly NativeHandle selHueXHandle = Selector.GetHandle ("hue");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selKernelWithString_X = "kernelWithString:";
		static readonly NativeHandle selKernelWithString_XHandle = Selector.GetHandle ("kernelWithString:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selLightenX = "lighten";
		static readonly NativeHandle selLightenXHandle = Selector.GetHandle ("lighten");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selLighterColorX = "lighterColor";
		static readonly NativeHandle selLighterColorXHandle = Selector.GetHandle ("lighterColor");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selLinearBurnX = "linearBurn";
		static readonly NativeHandle selLinearBurnXHandle = Selector.GetHandle ("linearBurn");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selLinearDodgeX = "linearDodge";
		static readonly NativeHandle selLinearDodgeXHandle = Selector.GetHandle ("linearDodge");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selLinearLightX = "linearLight";
		static readonly NativeHandle selLinearLightXHandle = Selector.GetHandle ("linearLight");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selLuminosityX = "luminosity";
		static readonly NativeHandle selLuminosityXHandle = Selector.GetHandle ("luminosity");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selMultiplyX = "multiply";
		static readonly NativeHandle selMultiplyXHandle = Selector.GetHandle ("multiply");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selOverlayX = "overlay";
		static readonly NativeHandle selOverlayXHandle = Selector.GetHandle ("overlay");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selPinLightX = "pinLight";
		static readonly NativeHandle selPinLightXHandle = Selector.GetHandle ("pinLight");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSaturationX = "saturation";
		static readonly NativeHandle selSaturationXHandle = Selector.GetHandle ("saturation");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selScreenX = "screen";
		static readonly NativeHandle selScreenXHandle = Selector.GetHandle ("screen");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSoftLightX = "softLight";
		static readonly NativeHandle selSoftLightXHandle = Selector.GetHandle ("softLight");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSourceX = "source";
		static readonly NativeHandle selSourceXHandle = Selector.GetHandle ("source");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSourceAtopX = "sourceAtop";
		static readonly NativeHandle selSourceAtopXHandle = Selector.GetHandle ("sourceAtop");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSourceInX = "sourceIn";
		static readonly NativeHandle selSourceInXHandle = Selector.GetHandle ("sourceIn");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSourceOutX = "sourceOut";
		static readonly NativeHandle selSourceOutXHandle = Selector.GetHandle ("sourceOut");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSourceOverX = "sourceOver";
		static readonly NativeHandle selSourceOverXHandle = Selector.GetHandle ("sourceOver");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSubtractX = "subtract";
		static readonly NativeHandle selSubtractXHandle = Selector.GetHandle ("subtract");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selVividLightX = "vividLight";
		static readonly NativeHandle selVividLightXHandle = Selector.GetHandle ("vividLight");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly NativeHandle class_ptr = Class.GetHandle ("CIBlendKernel");
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
		protected CIBlendKernel (NSObjectFlag t) : base (t)
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
		protected internal CIBlendKernel (NativeHandle handle) : base (handle)
		{
		}

		/// <param name="foreground">To be added.</param><param name="background">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("applyWithForeground:background:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual CIImage? Apply (CIImage foreground, CIImage background)
		{
			var foreground__handle__ = foreground!.GetNonNullHandle (nameof (foreground));
			var background__handle__ = background!.GetNonNullHandle (nameof (background));
			CIImage? ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<CIImage> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (this.Handle, selApplyWithForeground_Background_XHandle, foreground__handle__, background__handle__), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<CIImage> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, selApplyWithForeground_Background_XHandle, foreground__handle__, background__handle__), false)!;
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (foreground);
			GC.KeepAlive (background);
			return ret!;
		}
		[Export ("applyWithForeground:background:colorSpace:")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("tvos13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual CIImage? Apply (CIImage foreground, CIImage background, CGColorSpace colorSpace)
		{
			var foreground__handle__ = foreground!.GetNonNullHandle (nameof (foreground));
			var background__handle__ = background!.GetNonNullHandle (nameof (background));
			var colorSpace__handle__ = colorSpace!.GetNonNullHandle (nameof (colorSpace));
			CIImage? ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<CIImage> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (this.Handle, selApplyWithForeground_Background_ColorSpace_XHandle, foreground__handle__, background__handle__, colorSpace.Handle), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<CIImage> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_NativeHandle_NativeHandle (&__objc_super__, selApplyWithForeground_Background_ColorSpace_XHandle, foreground__handle__, background__handle__, colorSpace.Handle), false)!;
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (foreground);
			GC.KeepAlive (background);
			GC.KeepAlive (colorSpace);
			return ret!;
		}
		/// <param name="string">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("kernelWithString:")]
		[ObsoletedOSPlatform ("ios12.0")]
		[ObsoletedOSPlatform ("tvos12.0")]
		[ObsoletedOSPlatform ("macos10.14")]
		[ObsoletedOSPlatform ("maccatalyst13.1")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static CIBlendKernel? CreateKernel (string @string)
		{
			if (@string is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (@string));
			var nsstring = CFString.CreateNative (@string);
			CIBlendKernel? ret;
			ret =  Runtime.GetNSObject<CIBlendKernel> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (class_ptr, selKernelWithString_XHandle, nsstring), false)!;
			CFString.ReleaseNative (nsstring);
			return ret!;
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static CIBlendKernel Clear {
			[Export ("clear", ArgumentSemantic.Retain)]
			get {
				CIBlendKernel? ret;
				ret =  Runtime.GetNSObject<CIBlendKernel> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (class_ptr, selClearXHandle), false)!;
				return ret!;
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static CIBlendKernel Color {
			[Export ("color", ArgumentSemantic.Retain)]
			get {
				CIBlendKernel? ret;
				ret =  Runtime.GetNSObject<CIBlendKernel> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (class_ptr, selColorXHandle), false)!;
				return ret!;
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static CIBlendKernel ColorBurn {
			[Export ("colorBurn", ArgumentSemantic.Retain)]
			get {
				CIBlendKernel? ret;
				ret =  Runtime.GetNSObject<CIBlendKernel> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (class_ptr, selColorBurnXHandle), false)!;
				return ret!;
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static CIBlendKernel ColorDodge {
			[Export ("colorDodge", ArgumentSemantic.Retain)]
			get {
				CIBlendKernel? ret;
				ret =  Runtime.GetNSObject<CIBlendKernel> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (class_ptr, selColorDodgeXHandle), false)!;
				return ret!;
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static CIBlendKernel ComponentAdd {
			[Export ("componentAdd", ArgumentSemantic.Retain)]
			get {
				CIBlendKernel? ret;
				ret =  Runtime.GetNSObject<CIBlendKernel> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (class_ptr, selComponentAddXHandle), false)!;
				return ret!;
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static CIBlendKernel ComponentMax {
			[Export ("componentMax", ArgumentSemantic.Retain)]
			get {
				CIBlendKernel? ret;
				ret =  Runtime.GetNSObject<CIBlendKernel> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (class_ptr, selComponentMaxXHandle), false)!;
				return ret!;
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static CIBlendKernel ComponentMin {
			[Export ("componentMin", ArgumentSemantic.Retain)]
			get {
				CIBlendKernel? ret;
				ret =  Runtime.GetNSObject<CIBlendKernel> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (class_ptr, selComponentMinXHandle), false)!;
				return ret!;
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static CIBlendKernel ComponentMultiply {
			[Export ("componentMultiply", ArgumentSemantic.Retain)]
			get {
				CIBlendKernel? ret;
				ret =  Runtime.GetNSObject<CIBlendKernel> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (class_ptr, selComponentMultiplyXHandle), false)!;
				return ret!;
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static CIBlendKernel Darken {
			[Export ("darken", ArgumentSemantic.Retain)]
			get {
				CIBlendKernel? ret;
				ret =  Runtime.GetNSObject<CIBlendKernel> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (class_ptr, selDarkenXHandle), false)!;
				return ret!;
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static CIBlendKernel DarkerColor {
			[Export ("darkerColor", ArgumentSemantic.Retain)]
			get {
				CIBlendKernel? ret;
				ret =  Runtime.GetNSObject<CIBlendKernel> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (class_ptr, selDarkerColorXHandle), false)!;
				return ret!;
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static CIBlendKernel Destination {
			[Export ("destination", ArgumentSemantic.Retain)]
			get {
				CIBlendKernel? ret;
				ret =  Runtime.GetNSObject<CIBlendKernel> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (class_ptr, selDestinationXHandle), false)!;
				return ret!;
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static CIBlendKernel DestinationAtop {
			[Export ("destinationAtop", ArgumentSemantic.Retain)]
			get {
				CIBlendKernel? ret;
				ret =  Runtime.GetNSObject<CIBlendKernel> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (class_ptr, selDestinationAtopXHandle), false)!;
				return ret!;
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static CIBlendKernel DestinationIn {
			[Export ("destinationIn", ArgumentSemantic.Retain)]
			get {
				CIBlendKernel? ret;
				ret =  Runtime.GetNSObject<CIBlendKernel> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (class_ptr, selDestinationInXHandle), false)!;
				return ret!;
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static CIBlendKernel DestinationOut {
			[Export ("destinationOut", ArgumentSemantic.Retain)]
			get {
				CIBlendKernel? ret;
				ret =  Runtime.GetNSObject<CIBlendKernel> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (class_ptr, selDestinationOutXHandle), false)!;
				return ret!;
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static CIBlendKernel DestinationOver {
			[Export ("destinationOver", ArgumentSemantic.Retain)]
			get {
				CIBlendKernel? ret;
				ret =  Runtime.GetNSObject<CIBlendKernel> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (class_ptr, selDestinationOverXHandle), false)!;
				return ret!;
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static CIBlendKernel Difference {
			[Export ("difference", ArgumentSemantic.Retain)]
			get {
				CIBlendKernel? ret;
				ret =  Runtime.GetNSObject<CIBlendKernel> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (class_ptr, selDifferenceXHandle), false)!;
				return ret!;
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static CIBlendKernel Divide {
			[Export ("divide", ArgumentSemantic.Retain)]
			get {
				CIBlendKernel? ret;
				ret =  Runtime.GetNSObject<CIBlendKernel> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (class_ptr, selDivideXHandle), false)!;
				return ret!;
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static CIBlendKernel Exclusion {
			[Export ("exclusion", ArgumentSemantic.Retain)]
			get {
				CIBlendKernel? ret;
				ret =  Runtime.GetNSObject<CIBlendKernel> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (class_ptr, selExclusionXHandle), false)!;
				return ret!;
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static CIBlendKernel ExclusiveOr {
			[Export ("exclusiveOr", ArgumentSemantic.Retain)]
			get {
				CIBlendKernel? ret;
				ret =  Runtime.GetNSObject<CIBlendKernel> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (class_ptr, selExclusiveOrXHandle), false)!;
				return ret!;
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static CIBlendKernel HardLight {
			[Export ("hardLight", ArgumentSemantic.Retain)]
			get {
				CIBlendKernel? ret;
				ret =  Runtime.GetNSObject<CIBlendKernel> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (class_ptr, selHardLightXHandle), false)!;
				return ret!;
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static CIBlendKernel HardMix {
			[Export ("hardMix", ArgumentSemantic.Retain)]
			get {
				CIBlendKernel? ret;
				ret =  Runtime.GetNSObject<CIBlendKernel> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (class_ptr, selHardMixXHandle), false)!;
				return ret!;
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static CIBlendKernel Hue {
			[Export ("hue", ArgumentSemantic.Retain)]
			get {
				CIBlendKernel? ret;
				ret =  Runtime.GetNSObject<CIBlendKernel> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (class_ptr, selHueXHandle), false)!;
				return ret!;
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static CIBlendKernel Lighten {
			[Export ("lighten", ArgumentSemantic.Retain)]
			get {
				CIBlendKernel? ret;
				ret =  Runtime.GetNSObject<CIBlendKernel> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (class_ptr, selLightenXHandle), false)!;
				return ret!;
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static CIBlendKernel LighterColor {
			[Export ("lighterColor", ArgumentSemantic.Retain)]
			get {
				CIBlendKernel? ret;
				ret =  Runtime.GetNSObject<CIBlendKernel> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (class_ptr, selLighterColorXHandle), false)!;
				return ret!;
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static CIBlendKernel LinearBurn {
			[Export ("linearBurn", ArgumentSemantic.Retain)]
			get {
				CIBlendKernel? ret;
				ret =  Runtime.GetNSObject<CIBlendKernel> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (class_ptr, selLinearBurnXHandle), false)!;
				return ret!;
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static CIBlendKernel LinearDodge {
			[Export ("linearDodge", ArgumentSemantic.Retain)]
			get {
				CIBlendKernel? ret;
				ret =  Runtime.GetNSObject<CIBlendKernel> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (class_ptr, selLinearDodgeXHandle), false)!;
				return ret!;
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static CIBlendKernel LinearLight {
			[Export ("linearLight", ArgumentSemantic.Retain)]
			get {
				CIBlendKernel? ret;
				ret =  Runtime.GetNSObject<CIBlendKernel> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (class_ptr, selLinearLightXHandle), false)!;
				return ret!;
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static CIBlendKernel Luminosity {
			[Export ("luminosity", ArgumentSemantic.Retain)]
			get {
				CIBlendKernel? ret;
				ret =  Runtime.GetNSObject<CIBlendKernel> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (class_ptr, selLuminosityXHandle), false)!;
				return ret!;
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static CIBlendKernel Multiply {
			[Export ("multiply", ArgumentSemantic.Retain)]
			get {
				CIBlendKernel? ret;
				ret =  Runtime.GetNSObject<CIBlendKernel> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (class_ptr, selMultiplyXHandle), false)!;
				return ret!;
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static CIBlendKernel Overlay {
			[Export ("overlay", ArgumentSemantic.Retain)]
			get {
				CIBlendKernel? ret;
				ret =  Runtime.GetNSObject<CIBlendKernel> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (class_ptr, selOverlayXHandle), false)!;
				return ret!;
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static CIBlendKernel PinLight {
			[Export ("pinLight", ArgumentSemantic.Retain)]
			get {
				CIBlendKernel? ret;
				ret =  Runtime.GetNSObject<CIBlendKernel> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (class_ptr, selPinLightXHandle), false)!;
				return ret!;
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static CIBlendKernel Saturation {
			[Export ("saturation", ArgumentSemantic.Retain)]
			get {
				CIBlendKernel? ret;
				ret =  Runtime.GetNSObject<CIBlendKernel> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (class_ptr, selSaturationXHandle), false)!;
				return ret!;
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static CIBlendKernel Screen {
			[Export ("screen", ArgumentSemantic.Retain)]
			get {
				CIBlendKernel? ret;
				ret =  Runtime.GetNSObject<CIBlendKernel> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (class_ptr, selScreenXHandle), false)!;
				return ret!;
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static CIBlendKernel SoftLight {
			[Export ("softLight", ArgumentSemantic.Retain)]
			get {
				CIBlendKernel? ret;
				ret =  Runtime.GetNSObject<CIBlendKernel> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (class_ptr, selSoftLightXHandle), false)!;
				return ret!;
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static CIBlendKernel Source {
			[Export ("source", ArgumentSemantic.Retain)]
			get {
				CIBlendKernel? ret;
				ret =  Runtime.GetNSObject<CIBlendKernel> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (class_ptr, selSourceXHandle), false)!;
				return ret!;
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static CIBlendKernel SourceAtop {
			[Export ("sourceAtop", ArgumentSemantic.Retain)]
			get {
				CIBlendKernel? ret;
				ret =  Runtime.GetNSObject<CIBlendKernel> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (class_ptr, selSourceAtopXHandle), false)!;
				return ret!;
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static CIBlendKernel SourceIn {
			[Export ("sourceIn", ArgumentSemantic.Retain)]
			get {
				CIBlendKernel? ret;
				ret =  Runtime.GetNSObject<CIBlendKernel> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (class_ptr, selSourceInXHandle), false)!;
				return ret!;
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static CIBlendKernel SourceOut {
			[Export ("sourceOut", ArgumentSemantic.Retain)]
			get {
				CIBlendKernel? ret;
				ret =  Runtime.GetNSObject<CIBlendKernel> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (class_ptr, selSourceOutXHandle), false)!;
				return ret!;
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static CIBlendKernel SourceOver {
			[Export ("sourceOver", ArgumentSemantic.Retain)]
			get {
				CIBlendKernel? ret;
				ret =  Runtime.GetNSObject<CIBlendKernel> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (class_ptr, selSourceOverXHandle), false)!;
				return ret!;
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static CIBlendKernel Subtract {
			[Export ("subtract", ArgumentSemantic.Retain)]
			get {
				CIBlendKernel? ret;
				ret =  Runtime.GetNSObject<CIBlendKernel> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (class_ptr, selSubtractXHandle), false)!;
				return ret!;
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static CIBlendKernel VividLight {
			[Export ("vividLight", ArgumentSemantic.Retain)]
			get {
				CIBlendKernel? ret;
				ret =  Runtime.GetNSObject<CIBlendKernel> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (class_ptr, selVividLightXHandle), false)!;
				return ret!;
			}
		}
	} /* class CIBlendKernel */
}
