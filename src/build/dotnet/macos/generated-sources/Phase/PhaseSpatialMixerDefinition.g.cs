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
namespace Phase {
	[Register("PHASESpatialMixerDefinition", true)]
	[SupportedOSPlatform ("tvos17.0")]
	[SupportedOSPlatform ("ios15.0")]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("macos")]
	public unsafe partial class PhaseSpatialMixerDefinition : PhaseMixerDefinition {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selDistanceModelParametersX = "distanceModelParameters";
		static readonly NativeHandle selDistanceModelParametersXHandle = Selector.GetHandle ("distanceModelParameters");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selInitWithSpatialPipeline_X = "initWithSpatialPipeline:";
		static readonly NativeHandle selInitWithSpatialPipeline_XHandle = Selector.GetHandle ("initWithSpatialPipeline:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selInitWithSpatialPipeline_Identifier_X = "initWithSpatialPipeline:identifier:";
		static readonly NativeHandle selInitWithSpatialPipeline_Identifier_XHandle = Selector.GetHandle ("initWithSpatialPipeline:identifier:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selListenerDirectivityModelParametersX = "listenerDirectivityModelParameters";
		static readonly NativeHandle selListenerDirectivityModelParametersXHandle = Selector.GetHandle ("listenerDirectivityModelParameters");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetDistanceModelParameters_X = "setDistanceModelParameters:";
		static readonly NativeHandle selSetDistanceModelParameters_XHandle = Selector.GetHandle ("setDistanceModelParameters:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetListenerDirectivityModelParameters_X = "setListenerDirectivityModelParameters:";
		static readonly NativeHandle selSetListenerDirectivityModelParameters_XHandle = Selector.GetHandle ("setListenerDirectivityModelParameters:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetSourceDirectivityModelParameters_X = "setSourceDirectivityModelParameters:";
		static readonly NativeHandle selSetSourceDirectivityModelParameters_XHandle = Selector.GetHandle ("setSourceDirectivityModelParameters:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSourceDirectivityModelParametersX = "sourceDirectivityModelParameters";
		static readonly NativeHandle selSourceDirectivityModelParametersXHandle = Selector.GetHandle ("sourceDirectivityModelParameters");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSpatialPipelineX = "spatialPipeline";
		static readonly NativeHandle selSpatialPipelineXHandle = Selector.GetHandle ("spatialPipeline");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly NativeHandle class_ptr = Class.GetHandle ("PHASESpatialMixerDefinition");
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
		protected PhaseSpatialMixerDefinition (NSObjectFlag t) : base (t)
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
		protected internal PhaseSpatialMixerDefinition (NativeHandle handle) : base (handle)
		{
		}

		[Export ("initWithSpatialPipeline:")]
		[DesignatedInitializer]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public PhaseSpatialMixerDefinition (PhaseSpatialPipeline spatialPipeline)
			: base (NSObjectFlag.Empty)
		{
			var spatialPipeline__handle__ = spatialPipeline!.GetNonNullHandle (nameof (spatialPipeline));
			if (IsDirectBinding) {
				InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, selInitWithSpatialPipeline_XHandle, spatialPipeline__handle__), "initWithSpatialPipeline:");
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle (&__objc_super__, selInitWithSpatialPipeline_XHandle, spatialPipeline__handle__), "initWithSpatialPipeline:");
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (spatialPipeline);
		}
		[Export ("initWithSpatialPipeline:identifier:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public PhaseSpatialMixerDefinition (PhaseSpatialPipeline spatialPipeline, string identifier)
			: base (NSObjectFlag.Empty)
		{
			var spatialPipeline__handle__ = spatialPipeline!.GetNonNullHandle (nameof (spatialPipeline));
			if (identifier is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (identifier));
			var nsidentifier = CFString.CreateNative (identifier);
			if (IsDirectBinding) {
				InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (this.Handle, selInitWithSpatialPipeline_Identifier_XHandle, spatialPipeline__handle__, nsidentifier), "initWithSpatialPipeline:identifier:");
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, selInitWithSpatialPipeline_Identifier_XHandle, spatialPipeline__handle__, nsidentifier), "initWithSpatialPipeline:identifier:");
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (spatialPipeline);
			CFString.ReleaseNative (nsidentifier);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual PhaseDistanceModelParameters? DistanceModelParameters {
			[Export ("distanceModelParameters", ArgumentSemantic.Retain)]
			get {
				PhaseDistanceModelParameters? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<PhaseDistanceModelParameters> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selDistanceModelParametersXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<PhaseDistanceModelParameters> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selDistanceModelParametersXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setDistanceModelParameters:", ArgumentSemantic.Retain)]
			set {
				var value__handle__ = value.GetHandle ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selSetDistanceModelParameters_XHandle, value__handle__);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selSetDistanceModelParameters_XHandle, value__handle__);
						GC.KeepAlive (this);
					}
				}
				GC.KeepAlive (value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual PhaseDirectivityModelParameters? ListenerDirectivityModelParameters {
			[Export ("listenerDirectivityModelParameters", ArgumentSemantic.Retain)]
			get {
				PhaseDirectivityModelParameters? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<PhaseDirectivityModelParameters> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selListenerDirectivityModelParametersXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<PhaseDirectivityModelParameters> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selListenerDirectivityModelParametersXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setListenerDirectivityModelParameters:", ArgumentSemantic.Retain)]
			set {
				var value__handle__ = value.GetHandle ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selSetListenerDirectivityModelParameters_XHandle, value__handle__);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selSetListenerDirectivityModelParameters_XHandle, value__handle__);
						GC.KeepAlive (this);
					}
				}
				GC.KeepAlive (value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual PhaseDirectivityModelParameters? SourceDirectivityModelParameters {
			[Export ("sourceDirectivityModelParameters", ArgumentSemantic.Retain)]
			get {
				PhaseDirectivityModelParameters? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<PhaseDirectivityModelParameters> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selSourceDirectivityModelParametersXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<PhaseDirectivityModelParameters> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selSourceDirectivityModelParametersXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setSourceDirectivityModelParameters:", ArgumentSemantic.Retain)]
			set {
				var value__handle__ = value.GetHandle ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selSetSourceDirectivityModelParameters_XHandle, value__handle__);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selSetSourceDirectivityModelParameters_XHandle, value__handle__);
						GC.KeepAlive (this);
					}
				}
				GC.KeepAlive (value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual PhaseSpatialPipeline SpatialPipeline {
			[Export ("spatialPipeline", ArgumentSemantic.Retain)]
			get {
				PhaseSpatialPipeline? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<PhaseSpatialPipeline> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selSpatialPipelineXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<PhaseSpatialPipeline> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selSpatialPipelineXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
	} /* class PhaseSpatialMixerDefinition */
}
