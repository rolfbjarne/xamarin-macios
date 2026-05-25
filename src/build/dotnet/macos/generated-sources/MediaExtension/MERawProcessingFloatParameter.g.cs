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
namespace MediaExtension {
	[Register("MERAWProcessingFloatParameter", true)]
	[UnsupportedOSPlatform ("tvos")]
	[UnsupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos15.0")]
	[UnsupportedOSPlatform ("maccatalyst")]
	public unsafe partial class MERawProcessingFloatParameter : MERawProcessingParameter {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selCurrentValueX = "currentValue";
		static readonly NativeHandle selCurrentValueXHandle = Selector.GetHandle ("currentValue");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selHasCameraValue_X = "hasCameraValue:";
		static readonly NativeHandle selHasCameraValue_XHandle = Selector.GetHandle ("hasCameraValue:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selHasNeutralValue_X = "hasNeutralValue:";
		static readonly NativeHandle selHasNeutralValue_XHandle = Selector.GetHandle ("hasNeutralValue:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selInitWithName_Key_Description_InitialValue_Maximum_Minimum_X = "initWithName:key:description:initialValue:maximum:minimum:";
		static readonly NativeHandle selInitWithName_Key_Description_InitialValue_Maximum_Minimum_XHandle = Selector.GetHandle ("initWithName:key:description:initialValue:maximum:minimum:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selInitWithName_Key_Description_InitialValue_Maximum_Minimum_CameraValue_X = "initWithName:key:description:initialValue:maximum:minimum:cameraValue:";
		static readonly NativeHandle selInitWithName_Key_Description_InitialValue_Maximum_Minimum_CameraValue_XHandle = Selector.GetHandle ("initWithName:key:description:initialValue:maximum:minimum:cameraValue:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selInitWithName_Key_Description_InitialValue_Maximum_Minimum_NeutralValue_X = "initWithName:key:description:initialValue:maximum:minimum:neutralValue:";
		static readonly NativeHandle selInitWithName_Key_Description_InitialValue_Maximum_Minimum_NeutralValue_XHandle = Selector.GetHandle ("initWithName:key:description:initialValue:maximum:minimum:neutralValue:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selInitWithName_Key_Description_InitialValue_Maximum_Minimum_NeutralValue_CameraValue_X = "initWithName:key:description:initialValue:maximum:minimum:neutralValue:cameraValue:";
		static readonly NativeHandle selInitWithName_Key_Description_InitialValue_Maximum_Minimum_NeutralValue_CameraValue_XHandle = Selector.GetHandle ("initWithName:key:description:initialValue:maximum:minimum:neutralValue:cameraValue:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selInitialValueX = "initialValue";
		static readonly NativeHandle selInitialValueXHandle = Selector.GetHandle ("initialValue");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selMaximumValueX = "maximumValue";
		static readonly NativeHandle selMaximumValueXHandle = Selector.GetHandle ("maximumValue");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selMinimumValueX = "minimumValue";
		static readonly NativeHandle selMinimumValueXHandle = Selector.GetHandle ("minimumValue");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetCurrentValue_X = "setCurrentValue:";
		static readonly NativeHandle selSetCurrentValue_XHandle = Selector.GetHandle ("setCurrentValue:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly NativeHandle class_ptr = Class.GetHandle ("MERAWProcessingFloatParameter");
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
		protected MERawProcessingFloatParameter (NSObjectFlag t) : base (t)
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
		protected internal MERawProcessingFloatParameter (NativeHandle handle) : base (handle)
		{
		}

		[Export ("initWithName:key:description:initialValue:maximum:minimum:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public MERawProcessingFloatParameter (string name, string key, string description, float initialValue, float maximum, float minimum)
			: base (NSObjectFlag.Empty)
		{
			if (name is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (name));
			if (key is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (key));
			if (description is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (description));
			var nsname = CFString.CreateNative (name);
			var nskey = CFString.CreateNative (key);
			var nsdescription = CFString.CreateNative (description);
			if (IsDirectBinding) {
				InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle_float_float_float (this.Handle, selInitWithName_Key_Description_InitialValue_Maximum_Minimum_XHandle, nsname, nskey, nsdescription, initialValue, maximum, minimum), "initWithName:key:description:initialValue:maximum:minimum:");
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_NativeHandle_NativeHandle_float_float_float (&__objc_super__, selInitWithName_Key_Description_InitialValue_Maximum_Minimum_XHandle, nsname, nskey, nsdescription, initialValue, maximum, minimum), "initWithName:key:description:initialValue:maximum:minimum:");
					GC.KeepAlive (this);
				}
			}
			CFString.ReleaseNative (nsname);
			CFString.ReleaseNative (nskey);
			CFString.ReleaseNative (nsdescription);
		}
		[Export ("initWithName:key:description:initialValue:maximum:minimum:neutralValue:cameraValue:")]
		[DesignatedInitializer]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public MERawProcessingFloatParameter (string name, string key, string description, float initialValue, float maximum, float minimum, float neutralValue, float cameraValue)
			: base (NSObjectFlag.Empty)
		{
			if (name is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (name));
			if (key is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (key));
			if (description is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (description));
			var nsname = CFString.CreateNative (name);
			var nskey = CFString.CreateNative (key);
			var nsdescription = CFString.CreateNative (description);
			if (IsDirectBinding) {
				InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle_float_float_float_float_float (this.Handle, selInitWithName_Key_Description_InitialValue_Maximum_Minimum_NeutralValue_CameraValue_XHandle, nsname, nskey, nsdescription, initialValue, maximum, minimum, neutralValue, cameraValue), "initWithName:key:description:initialValue:maximum:minimum:neutralValue:cameraValue:");
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_NativeHandle_NativeHandle_float_float_float_float_float (&__objc_super__, selInitWithName_Key_Description_InitialValue_Maximum_Minimum_NeutralValue_CameraValue_XHandle, nsname, nskey, nsdescription, initialValue, maximum, minimum, neutralValue, cameraValue), "initWithName:key:description:initialValue:maximum:minimum:neutralValue:cameraValue:");
					GC.KeepAlive (this);
				}
			}
			CFString.ReleaseNative (nsname);
			CFString.ReleaseNative (nskey);
			CFString.ReleaseNative (nsdescription);
		}
		[Export ("hasCameraValue:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual bool HasCameraValue (out float cameraValue)
		{
			fixed (float* cameraValue__pointer = &cameraValue) {
			cameraValue = default;
			byte ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_out_Single (this.Handle, selHasCameraValue_XHandle, cameraValue__pointer);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper_out_Single (&__objc_super__, selHasCameraValue_XHandle, cameraValue__pointer);
					GC.KeepAlive (this);
				}
			}
			return ret != 0;
			}
		}
		[Export ("hasNeutralValue:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual bool HasNeutralValue (out float neutralValue)
		{
			fixed (float* neutralValue__pointer = &neutralValue) {
			neutralValue = default;
			byte ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_out_Single (this.Handle, selHasNeutralValue_XHandle, neutralValue__pointer);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper_out_Single (&__objc_super__, selHasNeutralValue_XHandle, neutralValue__pointer);
					GC.KeepAlive (this);
				}
			}
			return ret != 0;
			}
		}
		[Export ("initWithName:key:description:initialValue:maximum:minimum:cameraValue:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal virtual NativeHandle _InitWithCameraValue (string name, string key, string description, float initialValue, float maximum, float minimum, float cameraValue)
		{
			if (name is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (name));
			if (key is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (key));
			if (description is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (description));
			var nsname = CFString.CreateNative (name);
			var nskey = CFString.CreateNative (key);
			var nsdescription = CFString.CreateNative (description);
			NativeHandle ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle_float_float_float_float (this.Handle, selInitWithName_Key_Description_InitialValue_Maximum_Minimum_CameraValue_XHandle, nsname, nskey, nsdescription, initialValue, maximum, minimum, cameraValue);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_NativeHandle_NativeHandle_float_float_float_float (&__objc_super__, selInitWithName_Key_Description_InitialValue_Maximum_Minimum_CameraValue_XHandle, nsname, nskey, nsdescription, initialValue, maximum, minimum, cameraValue);
					GC.KeepAlive (this);
				}
			}
			CFString.ReleaseNative (nsname);
			CFString.ReleaseNative (nskey);
			CFString.ReleaseNative (nsdescription);
			return ret!;
		}
		[Export ("initWithName:key:description:initialValue:maximum:minimum:neutralValue:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal virtual NativeHandle _InitWithNeutralValue (string name, string key, string description, float initialValue, float maximum, float minimum, float neutralValue)
		{
			if (name is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (name));
			if (key is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (key));
			if (description is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (description));
			var nsname = CFString.CreateNative (name);
			var nskey = CFString.CreateNative (key);
			var nsdescription = CFString.CreateNative (description);
			NativeHandle ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle_float_float_float_float (this.Handle, selInitWithName_Key_Description_InitialValue_Maximum_Minimum_NeutralValue_XHandle, nsname, nskey, nsdescription, initialValue, maximum, minimum, neutralValue);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_NativeHandle_NativeHandle_float_float_float_float (&__objc_super__, selInitWithName_Key_Description_InitialValue_Maximum_Minimum_NeutralValue_XHandle, nsname, nskey, nsdescription, initialValue, maximum, minimum, neutralValue);
					GC.KeepAlive (this);
				}
			}
			CFString.ReleaseNative (nsname);
			CFString.ReleaseNative (nskey);
			CFString.ReleaseNative (nsdescription);
			return ret!;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual float CurrentValue {
			[Export ("currentValue")]
			get {
				float ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.float_objc_msgSend (this.Handle, selCurrentValueXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.float_objc_msgSendSuper (&__objc_super__, selCurrentValueXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[Export ("setCurrentValue:")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_float (this.Handle, selSetCurrentValue_XHandle, value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_float (&__objc_super__, selSetCurrentValue_XHandle, value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual float InitialValue {
			[Export ("initialValue")]
			get {
				float ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.float_objc_msgSend (this.Handle, selInitialValueXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.float_objc_msgSendSuper (&__objc_super__, selInitialValueXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual float MaximumValue {
			[Export ("maximumValue")]
			get {
				float ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.float_objc_msgSend (this.Handle, selMaximumValueXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.float_objc_msgSendSuper (&__objc_super__, selMaximumValueXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual float MinimumValue {
			[Export ("minimumValue")]
			get {
				float ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.float_objc_msgSend (this.Handle, selMinimumValueXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.float_objc_msgSendSuper (&__objc_super__, selMinimumValueXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
	} /* class MERawProcessingFloatParameter */
}
