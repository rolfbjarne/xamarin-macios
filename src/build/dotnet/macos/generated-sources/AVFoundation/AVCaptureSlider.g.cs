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
namespace AVFoundation {
	[Register("AVCaptureSlider", true)]
	[SupportedOSPlatform ("tvos18.0")]
	[SupportedOSPlatform ("maccatalyst18.0")]
	[SupportedOSPlatform ("macos15.0")]
	[SupportedOSPlatform ("ios18.0")]
	public unsafe partial class AVCaptureSlider : AVCaptureControl {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAccessibilityIdentifierX = "accessibilityIdentifier";
		static readonly NativeHandle selAccessibilityIdentifierXHandle = Selector.GetHandle ("accessibilityIdentifier");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selInitWithLocalizedTitle_SymbolName_MinValue_MaxValue_X = "initWithLocalizedTitle:symbolName:minValue:maxValue:";
		static readonly NativeHandle selInitWithLocalizedTitle_SymbolName_MinValue_MaxValue_XHandle = Selector.GetHandle ("initWithLocalizedTitle:symbolName:minValue:maxValue:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selInitWithLocalizedTitle_SymbolName_MinValue_MaxValue_Step_X = "initWithLocalizedTitle:symbolName:minValue:maxValue:step:";
		static readonly NativeHandle selInitWithLocalizedTitle_SymbolName_MinValue_MaxValue_Step_XHandle = Selector.GetHandle ("initWithLocalizedTitle:symbolName:minValue:maxValue:step:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selInitWithLocalizedTitle_SymbolName_Values_X = "initWithLocalizedTitle:symbolName:values:";
		static readonly NativeHandle selInitWithLocalizedTitle_SymbolName_Values_XHandle = Selector.GetHandle ("initWithLocalizedTitle:symbolName:values:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selLocalizedTitleX = "localizedTitle";
		static readonly NativeHandle selLocalizedTitleXHandle = Selector.GetHandle ("localizedTitle");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selLocalizedValueFormatX = "localizedValueFormat";
		static readonly NativeHandle selLocalizedValueFormatXHandle = Selector.GetHandle ("localizedValueFormat");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selProminentValuesX = "prominentValues";
		static readonly NativeHandle selProminentValuesXHandle = Selector.GetHandle ("prominentValues");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetAccessibilityIdentifier_X = "setAccessibilityIdentifier:";
		static readonly NativeHandle selSetAccessibilityIdentifier_XHandle = Selector.GetHandle ("setAccessibilityIdentifier:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetActionQueue_Action_X = "setActionQueue:action:";
		static readonly NativeHandle selSetActionQueue_Action_XHandle = Selector.GetHandle ("setActionQueue:action:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetLocalizedValueFormat_X = "setLocalizedValueFormat:";
		static readonly NativeHandle selSetLocalizedValueFormat_XHandle = Selector.GetHandle ("setLocalizedValueFormat:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetProminentValues_X = "setProminentValues:";
		static readonly NativeHandle selSetProminentValues_XHandle = Selector.GetHandle ("setProminentValues:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetValue_X = "setValue:";
		static readonly NativeHandle selSetValue_XHandle = Selector.GetHandle ("setValue:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSymbolNameX = "symbolName";
		static readonly NativeHandle selSymbolNameXHandle = Selector.GetHandle ("symbolName");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selValueX = "value";
		static readonly NativeHandle selValueXHandle = Selector.GetHandle ("value");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly NativeHandle class_ptr = Class.GetHandle ("AVCaptureSlider");
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
		protected AVCaptureSlider (NSObjectFlag t) : base (t)
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
		protected internal AVCaptureSlider (NativeHandle handle) : base (handle)
		{
		}

		[Export ("initWithLocalizedTitle:symbolName:minValue:maxValue:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public AVCaptureSlider (string localizedTitle, string symbolName, float minValue, float maxValue)
			: base (NSObjectFlag.Empty)
		{
			if (localizedTitle is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (localizedTitle));
			if (symbolName is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (symbolName));
			var nslocalizedTitle = CFString.CreateNative (localizedTitle);
			var nssymbolName = CFString.CreateNative (symbolName);
			if (IsDirectBinding) {
				InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_float_float (this.Handle, selInitWithLocalizedTitle_SymbolName_MinValue_MaxValue_XHandle, nslocalizedTitle, nssymbolName, minValue, maxValue), "initWithLocalizedTitle:symbolName:minValue:maxValue:");
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_NativeHandle_float_float (&__objc_super__, selInitWithLocalizedTitle_SymbolName_MinValue_MaxValue_XHandle, nslocalizedTitle, nssymbolName, minValue, maxValue), "initWithLocalizedTitle:symbolName:minValue:maxValue:");
					GC.KeepAlive (this);
				}
			}
			CFString.ReleaseNative (nslocalizedTitle);
			CFString.ReleaseNative (nssymbolName);
		}
		[Export ("initWithLocalizedTitle:symbolName:minValue:maxValue:step:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public AVCaptureSlider (string localizedTitle, string symbolName, float minValue, float maxValue, float step)
			: base (NSObjectFlag.Empty)
		{
			if (localizedTitle is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (localizedTitle));
			if (symbolName is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (symbolName));
			var nslocalizedTitle = CFString.CreateNative (localizedTitle);
			var nssymbolName = CFString.CreateNative (symbolName);
			if (IsDirectBinding) {
				InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_float_float_float (this.Handle, selInitWithLocalizedTitle_SymbolName_MinValue_MaxValue_Step_XHandle, nslocalizedTitle, nssymbolName, minValue, maxValue, step), "initWithLocalizedTitle:symbolName:minValue:maxValue:step:");
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_NativeHandle_float_float_float (&__objc_super__, selInitWithLocalizedTitle_SymbolName_MinValue_MaxValue_Step_XHandle, nslocalizedTitle, nssymbolName, minValue, maxValue, step), "initWithLocalizedTitle:symbolName:minValue:maxValue:step:");
					GC.KeepAlive (this);
				}
			}
			CFString.ReleaseNative (nslocalizedTitle);
			CFString.ReleaseNative (nssymbolName);
		}
		[Export ("initWithLocalizedTitle:symbolName:values:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public AVCaptureSlider (string localizedTitle, string symbolName, [BindAs (typeof (float[]), OriginalType = typeof (NSNumber[]))] float[] values)
			: base (NSObjectFlag.Empty)
		{
			if (localizedTitle is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (localizedTitle));
			if (symbolName is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (symbolName));
			if (values is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (values));
			var nslocalizedTitle = CFString.CreateNative (localizedTitle);
			var nssymbolName = CFString.CreateNative (symbolName);
			using var nsb_values = NSArray.FromNSObjects (o => new NSNumber (o), values);
			if (IsDirectBinding) {
				InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (this.Handle, selInitWithLocalizedTitle_SymbolName_Values_XHandle, nslocalizedTitle, nssymbolName, nsb_values.GetHandle ()), "initWithLocalizedTitle:symbolName:values:");
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_NativeHandle_NativeHandle (&__objc_super__, selInitWithLocalizedTitle_SymbolName_Values_XHandle, nslocalizedTitle, nssymbolName, nsb_values.GetHandle ()), "initWithLocalizedTitle:symbolName:values:");
					GC.KeepAlive (this);
				}
			}
			CFString.ReleaseNative (nslocalizedTitle);
			CFString.ReleaseNative (nssymbolName);
		}
		[Export ("setActionQueue:action:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void SetActionQueue (global::CoreFoundation.DispatchQueue actionQueue, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDAVCaptureSliderCallback))]AVCaptureSliderCallback action)
		{
			var actionQueue__handle__ = actionQueue!.GetNonNullHandle (nameof (actionQueue));
			if (action is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (action));
			using var block_action = Trampolines.SDAVCaptureSliderCallback.CreateBlock (action);
			BlockLiteral *block_ptr_action = &block_action;
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (this.Handle, selSetActionQueue_Action_XHandle, actionQueue.Handle, (IntPtr) block_ptr_action);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, selSetActionQueue_Action_XHandle, actionQueue.Handle, (IntPtr) block_ptr_action);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (actionQueue);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string? AccessibilityIdentifier {
			[Export ("accessibilityIdentifier")]
			get {
				string ret;
				if (IsDirectBinding) {
					ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selAccessibilityIdentifierXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selAccessibilityIdentifierXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[Export ("setAccessibilityIdentifier:")]
			set {
				var nsvalue = CFString.CreateNative (value);
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selSetAccessibilityIdentifier_XHandle, nsvalue);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selSetAccessibilityIdentifier_XHandle, nsvalue);
						GC.KeepAlive (this);
					}
				}
				CFString.ReleaseNative (nsvalue);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string LocalizedTitle {
			[Export ("localizedTitle")]
			get {
				string ret;
				if (IsDirectBinding) {
					ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selLocalizedTitleXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selLocalizedTitleXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string? LocalizedValueFormat {
			[Export ("localizedValueFormat")]
			get {
				string ret;
				if (IsDirectBinding) {
					ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selLocalizedValueFormatXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selLocalizedValueFormatXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[Export ("setLocalizedValueFormat:")]
			set {
				var nsvalue = CFString.CreateNative (value);
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selSetLocalizedValueFormat_XHandle, nsvalue);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selSetLocalizedValueFormat_XHandle, nsvalue);
						GC.KeepAlive (this);
					}
				}
				CFString.ReleaseNative (nsvalue);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[BindAs (typeof (float[]), OriginalType = typeof (NSNumber[]))]
		public virtual float[] ProminentValues {
			[Export ("prominentValues", ArgumentSemantic.Copy)]
			get {
				float[] ret;
				if (IsDirectBinding) {
					ret = NSArray.ArrayFromHandleFunc <float> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selProminentValuesXHandle), NSNumber.ToFloat, false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = NSArray.ArrayFromHandleFunc <float> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selProminentValuesXHandle), NSNumber.ToFloat, false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setProminentValues:", ArgumentSemantic.Copy)]
			set {
				if (value is null)
					ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (value));
				using var nsb_ProminentValues = NSArray.FromNSObjects (o => new NSNumber (o), value);
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selSetProminentValues_XHandle, nsb_ProminentValues.GetHandle ());
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selSetProminentValues_XHandle, nsb_ProminentValues.GetHandle ());
						GC.KeepAlive (this);
					}
				}
				nsb_ProminentValues?.Dispose ();
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string SymbolName {
			[Export ("symbolName")]
			get {
				string ret;
				if (IsDirectBinding) {
					ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selSymbolNameXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selSymbolNameXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual float Value {
			[Export ("value")]
			get {
				float ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.float_objc_msgSend (this.Handle, selValueXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.float_objc_msgSendSuper (&__objc_super__, selValueXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[Export ("setValue:")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_float (this.Handle, selSetValue_XHandle, value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_float (&__objc_super__, selSetValue_XHandle, value);
						GC.KeepAlive (this);
					}
				}
			}
		}
	} /* class AVCaptureSlider */
}
