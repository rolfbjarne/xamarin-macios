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
namespace GameController {
	[Register("GCPhysicalInputProfile", true)]
	[SupportedOSPlatform ("tvos14.0")]
	[SupportedOSPlatform ("ios14.0")]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("macos")]
	public unsafe partial class GCPhysicalInputProfile : NSObject {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAllAxesX = "allAxes";
		static readonly NativeHandle selAllAxesXHandle = Selector.GetHandle ("allAxes");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAllButtonsX = "allButtons";
		static readonly NativeHandle selAllButtonsXHandle = Selector.GetHandle ("allButtons");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAllDpadsX = "allDpads";
		static readonly NativeHandle selAllDpadsXHandle = Selector.GetHandle ("allDpads");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAllElementsX = "allElements";
		static readonly NativeHandle selAllElementsXHandle = Selector.GetHandle ("allElements");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAllTouchpadsX = "allTouchpads";
		static readonly NativeHandle selAllTouchpadsXHandle = Selector.GetHandle ("allTouchpads");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAxesX = "axes";
		static readonly NativeHandle selAxesXHandle = Selector.GetHandle ("axes");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selButtonsX = "buttons";
		static readonly NativeHandle selButtonsXHandle = Selector.GetHandle ("buttons");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selCaptureX = "capture";
		static readonly NativeHandle selCaptureXHandle = Selector.GetHandle ("capture");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selDeviceX = "device";
		static readonly NativeHandle selDeviceXHandle = Selector.GetHandle ("device");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selDpadsX = "dpads";
		static readonly NativeHandle selDpadsXHandle = Selector.GetHandle ("dpads");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selElementsX = "elements";
		static readonly NativeHandle selElementsXHandle = Selector.GetHandle ("elements");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selHasRemappedElementsX = "hasRemappedElements";
		static readonly NativeHandle selHasRemappedElementsXHandle = Selector.GetHandle ("hasRemappedElements");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selLastEventTimestampX = "lastEventTimestamp";
		static readonly NativeHandle selLastEventTimestampXHandle = Selector.GetHandle ("lastEventTimestamp");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selMappedElementAliasForPhysicalInputName_X = "mappedElementAliasForPhysicalInputName:";
		static readonly NativeHandle selMappedElementAliasForPhysicalInputName_XHandle = Selector.GetHandle ("mappedElementAliasForPhysicalInputName:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selMappedPhysicalInputNamesForElementAlias_X = "mappedPhysicalInputNamesForElementAlias:";
		static readonly NativeHandle selMappedPhysicalInputNamesForElementAlias_XHandle = Selector.GetHandle ("mappedPhysicalInputNamesForElementAlias:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selObjectForKeyedSubscript_X = "objectForKeyedSubscript:";
		static readonly NativeHandle selObjectForKeyedSubscript_XHandle = Selector.GetHandle ("objectForKeyedSubscript:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetStateFromPhysicalInput_X = "setStateFromPhysicalInput:";
		static readonly NativeHandle selSetStateFromPhysicalInput_XHandle = Selector.GetHandle ("setStateFromPhysicalInput:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetValueDidChangeHandler_X = "setValueDidChangeHandler:";
		static readonly NativeHandle selSetValueDidChangeHandler_XHandle = Selector.GetHandle ("setValueDidChangeHandler:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selTouchpadsX = "touchpads";
		static readonly NativeHandle selTouchpadsXHandle = Selector.GetHandle ("touchpads");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selValueDidChangeHandlerX = "valueDidChangeHandler";
		static readonly NativeHandle selValueDidChangeHandlerXHandle = Selector.GetHandle ("valueDidChangeHandler");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly NativeHandle class_ptr = Class.GetHandle ("GCPhysicalInputProfile");
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
		protected GCPhysicalInputProfile (NSObjectFlag t) : base (t)
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
		protected internal GCPhysicalInputProfile (NativeHandle handle) : base (handle)
		{
		}

		[Export ("capture")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual GCPhysicalInputProfile Capture ()
		{
			GCPhysicalInputProfile ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<GCPhysicalInputProfile> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selCaptureXHandle), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<GCPhysicalInputProfile> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selCaptureXHandle), false)!;
					GC.KeepAlive (this);
				}
			}
			return ret;
		}
		[Export ("mappedElementAliasForPhysicalInputName:")]
		[SupportedOSPlatform ("tvos15.0")]
		[SupportedOSPlatform ("ios15.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string GetMappedElementAlias (string physicalInputName)
		{
			if (physicalInputName is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (physicalInputName));
			var nsphysicalInputName = CFString.CreateNative (physicalInputName);
			string? ret;
			if (IsDirectBinding) {
				ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, selMappedElementAliasForPhysicalInputName_XHandle, nsphysicalInputName), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle (&__objc_super__, selMappedElementAliasForPhysicalInputName_XHandle, nsphysicalInputName), false)!;
					GC.KeepAlive (this);
				}
			}
			CFString.ReleaseNative (nsphysicalInputName);
			return ret!;
		}
		[Export ("mappedPhysicalInputNamesForElementAlias:")]
		[SupportedOSPlatform ("tvos15.0")]
		[SupportedOSPlatform ("ios15.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSSet<NSString> GetMappedPhysicalInputNames (string elementAlias)
		{
			if (elementAlias is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (elementAlias));
			var nselementAlias = CFString.CreateNative (elementAlias);
			NSSet<NSString>? ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<NSSet<NSString>> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, selMappedPhysicalInputNamesForElementAlias_XHandle, nselementAlias), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<NSSet<NSString>> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle (&__objc_super__, selMappedPhysicalInputNamesForElementAlias_XHandle, nselementAlias), false)!;
					GC.KeepAlive (this);
				}
			}
			CFString.ReleaseNative (nselementAlias);
			return ret!;
		}
		[Export ("objectForKeyedSubscript:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual GCControllerElement? GetObjectForKeyedSubscript (string key)
		{
			if (key is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (key));
			var nskey = CFString.CreateNative (key);
			GCControllerElement? ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<GCControllerElement> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, selObjectForKeyedSubscript_XHandle, nskey), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<GCControllerElement> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle (&__objc_super__, selObjectForKeyedSubscript_XHandle, nskey), false)!;
					GC.KeepAlive (this);
				}
			}
			CFString.ReleaseNative (nskey);
			return ret!;
		}
		[Export ("setStateFromPhysicalInput:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetState (GCPhysicalInputProfile physicalInput)
		{
			var physicalInput__handle__ = physicalInput!.GetNonNullHandle (nameof (physicalInput));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selSetStateFromPhysicalInput_XHandle, physicalInput__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selSetStateFromPhysicalInput_XHandle, physicalInput__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (physicalInput);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSSet<GCControllerAxisInput> AllAxes {
			[Export ("allAxes", ArgumentSemantic.Retain)]
			get {
				NSSet<GCControllerAxisInput>? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSSet<GCControllerAxisInput>> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selAllAxesXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<NSSet<GCControllerAxisInput>> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selAllAxesXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSSet<GCControllerButtonInput> AllButtons {
			[Export ("allButtons", ArgumentSemantic.Retain)]
			get {
				NSSet<GCControllerButtonInput>? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSSet<GCControllerButtonInput>> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selAllButtonsXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<NSSet<GCControllerButtonInput>> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selAllButtonsXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSSet<GCControllerDirectionPad> AllDpads {
			[Export ("allDpads", ArgumentSemantic.Retain)]
			get {
				NSSet<GCControllerDirectionPad>? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSSet<GCControllerDirectionPad>> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selAllDpadsXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<NSSet<GCControllerDirectionPad>> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selAllDpadsXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSSet<GCControllerElement> AllElements {
			[Export ("allElements", ArgumentSemantic.Retain)]
			get {
				NSSet<GCControllerElement>? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSSet<GCControllerElement>> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selAllElementsXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<NSSet<GCControllerElement>> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selAllElementsXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("tvos15.0")]
		[SupportedOSPlatform ("ios15.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public virtual NSSet<GCControllerTouchpad> AllTouchpads {
			[Export ("allTouchpads", ArgumentSemantic.Retain)]
			get {
				NSSet<GCControllerTouchpad>? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSSet<GCControllerTouchpad>> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selAllTouchpadsXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<NSSet<GCControllerTouchpad>> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selAllTouchpadsXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSDictionary<NSString, GCControllerAxisInput> Axes {
			[Export ("axes", ArgumentSemantic.Retain)]
			get {
				NSDictionary<NSString, GCControllerAxisInput>? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSDictionary<NSString, GCControllerAxisInput>> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selAxesXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<NSDictionary<NSString, GCControllerAxisInput>> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selAxesXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSDictionary<NSString, GCControllerButtonInput> Buttons {
			[Export ("buttons", ArgumentSemantic.Retain)]
			get {
				NSDictionary<NSString, GCControllerButtonInput>? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSDictionary<NSString, GCControllerButtonInput>> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selButtonsXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<NSDictionary<NSString, GCControllerButtonInput>> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selButtonsXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		object? __mt_Device_var;
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual IGCDevice? Device {
			[Export ("device", ArgumentSemantic.Weak)]
			get {
				IGCDevice? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetINativeObject<IGCDevice> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selDeviceXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetINativeObject<IGCDevice> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selDeviceXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				MarkDirty ();
				__mt_Device_var = ret;
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSDictionary<NSString, GCControllerDirectionPad> Dpads {
			[Export ("dpads", ArgumentSemantic.Retain)]
			get {
				NSDictionary<NSString, GCControllerDirectionPad>? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSDictionary<NSString, GCControllerDirectionPad>> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selDpadsXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<NSDictionary<NSString, GCControllerDirectionPad>> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selDpadsXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSDictionary<NSString, GCControllerElement> Elements {
			[Export ("elements", ArgumentSemantic.Retain)]
			get {
				NSDictionary<NSString, GCControllerElement>? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSDictionary<NSString, GCControllerElement>> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selElementsXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<NSDictionary<NSString, GCControllerElement>> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selElementsXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("tvos15.0")]
		[SupportedOSPlatform ("ios15.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public virtual bool HasRemappedElements {
			[Export ("hasRemappedElements")]
			get {
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selHasRemappedElementsXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, selHasRemappedElementsXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual double LastEventTimestamp {
			[Export ("lastEventTimestamp")]
			get {
				double ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.Double_objc_msgSend (this.Handle, selLastEventTimestampXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.Double_objc_msgSendSuper (&__objc_super__, selLastEventTimestampXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("tvos15.0")]
		[SupportedOSPlatform ("ios15.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public virtual NSDictionary<NSString, GCControllerTouchpad> Touchpads {
			[Export ("touchpads", ArgumentSemantic.Retain)]
			get {
				NSDictionary<NSString, GCControllerTouchpad>? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSDictionary<NSString, GCControllerTouchpad>> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selTouchpadsXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<NSDictionary<NSString, GCControllerTouchpad>> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selTouchpadsXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("tvos16.0")]
		[SupportedOSPlatform ("macos13.0")]
		[SupportedOSPlatform ("ios16.0")]
		[SupportedOSPlatform ("maccatalyst16.0")]
		public unsafe virtual global::System.Action<GCPhysicalInputProfile, GCControllerElement>? ValueDidChangeHandler {
			[return: DelegateProxy (typeof (ObjCRuntime.Trampolines.SDActionArity2V81))]
			[Export ("valueDidChangeHandler", ArgumentSemantic.Copy)]
			get {
				NativeHandle ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selValueDidChangeHandlerXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selValueDidChangeHandlerXHandle);
						GC.KeepAlive (this);
					}
				}
				return global::ObjCRuntime.Trampolines.NIDActionArity2V81.Create (ret)!;
			}
			[param: BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity2V81))]
			[Export ("setValueDidChangeHandler:", ArgumentSemantic.Copy)]
			set {
				using var block_value = Trampolines.SDActionArity2V81.CreateNullableBlock (value);
				BlockLiteral *block_ptr_value = null;
				if (value is not null)
					block_ptr_value = &block_value;
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selSetValueDidChangeHandler_XHandle, (IntPtr) block_ptr_value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selSetValueDidChangeHandler_XHandle, (IntPtr) block_ptr_value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		protected override void Dispose (bool disposing)
		{
			base.Dispose (disposing);
			if (Handle == IntPtr.Zero) {
				__mt_Device_var = null;
			}
		}
	} /* class GCPhysicalInputProfile */
}
