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
	[Register("PHASEEngine", true)]
	[SupportedOSPlatform ("tvos17.0")]
	[SupportedOSPlatform ("ios15.0")]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("macos")]
	public unsafe partial class PhaseEngine : NSObject {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selActiveGroupPresetX = "activeGroupPreset";
		static readonly NativeHandle selActiveGroupPresetXHandle = Selector.GetHandle ("activeGroupPreset");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAssetRegistryX = "assetRegistry";
		static readonly NativeHandle selAssetRegistryXHandle = Selector.GetHandle ("assetRegistry");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selDefaultMediumX = "defaultMedium";
		static readonly NativeHandle selDefaultMediumXHandle = Selector.GetHandle ("defaultMedium");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selDefaultReverbPresetX = "defaultReverbPreset";
		static readonly NativeHandle selDefaultReverbPresetXHandle = Selector.GetHandle ("defaultReverbPreset");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selDuckersX = "duckers";
		static readonly NativeHandle selDuckersXHandle = Selector.GetHandle ("duckers");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selGroupsX = "groups";
		static readonly NativeHandle selGroupsXHandle = Selector.GetHandle ("groups");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selInitWithUpdateMode_X = "initWithUpdateMode:";
		static readonly NativeHandle selInitWithUpdateMode_XHandle = Selector.GetHandle ("initWithUpdateMode:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selLastRenderTimeX = "lastRenderTime";
		static readonly NativeHandle selLastRenderTimeXHandle = Selector.GetHandle ("lastRenderTime");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selOutputSpatializationModeX = "outputSpatializationMode";
		static readonly NativeHandle selOutputSpatializationModeXHandle = Selector.GetHandle ("outputSpatializationMode");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selPauseX = "pause";
		static readonly NativeHandle selPauseXHandle = Selector.GetHandle ("pause");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selRenderingStateX = "renderingState";
		static readonly NativeHandle selRenderingStateXHandle = Selector.GetHandle ("renderingState");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selRootObjectX = "rootObject";
		static readonly NativeHandle selRootObjectXHandle = Selector.GetHandle ("rootObject");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetDefaultMedium_X = "setDefaultMedium:";
		static readonly NativeHandle selSetDefaultMedium_XHandle = Selector.GetHandle ("setDefaultMedium:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetDefaultReverbPreset_X = "setDefaultReverbPreset:";
		static readonly NativeHandle selSetDefaultReverbPreset_XHandle = Selector.GetHandle ("setDefaultReverbPreset:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetOutputSpatializationMode_X = "setOutputSpatializationMode:";
		static readonly NativeHandle selSetOutputSpatializationMode_XHandle = Selector.GetHandle ("setOutputSpatializationMode:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetUnitsPerMeter_X = "setUnitsPerMeter:";
		static readonly NativeHandle selSetUnitsPerMeter_XHandle = Selector.GetHandle ("setUnitsPerMeter:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetUnitsPerSecond_X = "setUnitsPerSecond:";
		static readonly NativeHandle selSetUnitsPerSecond_XHandle = Selector.GetHandle ("setUnitsPerSecond:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSoundEventsX = "soundEvents";
		static readonly NativeHandle selSoundEventsXHandle = Selector.GetHandle ("soundEvents");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selStartAndReturnError_X = "startAndReturnError:";
		static readonly NativeHandle selStartAndReturnError_XHandle = Selector.GetHandle ("startAndReturnError:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selStopX = "stop";
		static readonly NativeHandle selStopXHandle = Selector.GetHandle ("stop");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selUnitsPerMeterX = "unitsPerMeter";
		static readonly NativeHandle selUnitsPerMeterXHandle = Selector.GetHandle ("unitsPerMeter");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selUnitsPerSecondX = "unitsPerSecond";
		static readonly NativeHandle selUnitsPerSecondXHandle = Selector.GetHandle ("unitsPerSecond");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selUpdateX = "update";
		static readonly NativeHandle selUpdateXHandle = Selector.GetHandle ("update");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly NativeHandle class_ptr = Class.GetHandle ("PHASEEngine");
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
		protected PhaseEngine (NSObjectFlag t) : base (t)
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
		protected internal PhaseEngine (NativeHandle handle) : base (handle)
		{
		}

		[Export ("initWithUpdateMode:")]
		[DesignatedInitializer]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public PhaseEngine (PhaseUpdateMode updateMode)
			: base (NSObjectFlag.Empty)
		{
			if (IsDirectBinding) {
				InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_IntPtr (this.Handle, selInitWithUpdateMode_XHandle, (IntPtr) (long) updateMode), "initWithUpdateMode:");
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_IntPtr (&__objc_super__, selInitWithUpdateMode_XHandle, (IntPtr) (long) updateMode), "initWithUpdateMode:");
					GC.KeepAlive (this);
				}
			}
		}
		[Export ("pause")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void Pause ()
		{
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, selPauseXHandle);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper (&__objc_super__, selPauseXHandle);
					GC.KeepAlive (this);
				}
			}
		}
		[Export ("startAndReturnError:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual bool Start (out NSError? error)
		{
			NativeHandle errorValue = IntPtr.Zero;
			byte ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_ref_NativeHandle (this.Handle, selStartAndReturnError_XHandle, &errorValue);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper_ref_NativeHandle (&__objc_super__, selStartAndReturnError_XHandle, &errorValue);
					GC.KeepAlive (this);
				}
			}
			error = Runtime.GetNSObject<NSError> (errorValue)!;
			return ret != 0;
		}
		[Export ("stop")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void Stop ()
		{
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, selStopXHandle);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper (&__objc_super__, selStopXHandle);
					GC.KeepAlive (this);
				}
			}
		}
		[Export ("update")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void Update ()
		{
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, selUpdateXHandle);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper (&__objc_super__, selUpdateXHandle);
					GC.KeepAlive (this);
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual PhaseGroupPreset? ActiveGroupPreset {
			[Export ("activeGroupPreset", ArgumentSemantic.Retain)]
			get {
				PhaseGroupPreset? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<PhaseGroupPreset> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selActiveGroupPresetXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<PhaseGroupPreset> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selActiveGroupPresetXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual PhaseAssetRegistry AssetRegistry {
			[Export ("assetRegistry", ArgumentSemantic.Retain)]
			get {
				PhaseAssetRegistry? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<PhaseAssetRegistry> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selAssetRegistryXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<PhaseAssetRegistry> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selAssetRegistryXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual PhaseMedium DefaultMedium {
			[Export ("defaultMedium", ArgumentSemantic.Retain)]
			get {
				PhaseMedium? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<PhaseMedium> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selDefaultMediumXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<PhaseMedium> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selDefaultMediumXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setDefaultMedium:", ArgumentSemantic.Retain)]
			set {
				var value__handle__ = value!.GetNonNullHandle (nameof (value));
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selSetDefaultMedium_XHandle, value__handle__);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selSetDefaultMedium_XHandle, value__handle__);
						GC.KeepAlive (this);
					}
				}
				GC.KeepAlive (value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual PhaseReverbPreset DefaultReverbPreset {
			[Export ("defaultReverbPreset", ArgumentSemantic.Assign)]
			get {
				PhaseReverbPreset ret;
				if (IsDirectBinding) {
					ret = (Phase.PhaseReverbPreset) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selDefaultReverbPresetXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = (Phase.PhaseReverbPreset) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (&__objc_super__, selDefaultReverbPresetXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setDefaultReverbPreset:", ArgumentSemantic.Assign)]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetDefaultReverbPreset_XHandle, (IntPtr) (long) value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (&__objc_super__, selSetDefaultReverbPreset_XHandle, (IntPtr) (long) value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual PhaseDucker[] Duckers {
			[Export ("duckers", ArgumentSemantic.Copy)]
			get {
				PhaseDucker[]? ret;
				if (IsDirectBinding) {
					ret = CFArray.ArrayFromHandle<PhaseDucker>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selDuckersXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFArray.ArrayFromHandle<PhaseDucker>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selDuckersXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSDictionary<NSString, PhaseGroup> Groups {
			[Export ("groups", ArgumentSemantic.Copy)]
			get {
				NSDictionary<NSString, PhaseGroup>? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSDictionary<NSString, PhaseGroup>> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selGroupsXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<NSDictionary<NSString, PhaseGroup>> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selGroupsXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("tvos26.0")]
		[SupportedOSPlatform ("maccatalyst26.0")]
		[SupportedOSPlatform ("macos26.0")]
		[SupportedOSPlatform ("ios26.0")]
		public virtual global::AVFoundation.AVAudioTime? LastRenderTime {
			[Export ("lastRenderTime")]
			get {
				global::AVFoundation.AVAudioTime? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<global::AVFoundation.AVAudioTime> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selLastRenderTimeXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<global::AVFoundation.AVAudioTime> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selLastRenderTimeXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual PhaseSpatializationMode OutputSpatializationMode {
			[Export ("outputSpatializationMode", ArgumentSemantic.Assign)]
			get {
				PhaseSpatializationMode ret;
				if (IsDirectBinding) {
					ret = (Phase.PhaseSpatializationMode) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selOutputSpatializationModeXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = (Phase.PhaseSpatializationMode) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (&__objc_super__, selOutputSpatializationModeXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setOutputSpatializationMode:", ArgumentSemantic.Assign)]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetOutputSpatializationMode_XHandle, (IntPtr) (long) value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (&__objc_super__, selSetOutputSpatializationMode_XHandle, (IntPtr) (long) value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual PhaseRenderingState RenderingState {
			[Export ("renderingState")]
			get {
				PhaseRenderingState ret;
				if (IsDirectBinding) {
					ret = (Phase.PhaseRenderingState) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selRenderingStateXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = (Phase.PhaseRenderingState) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (&__objc_super__, selRenderingStateXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual PhaseObject RootObject {
			[Export ("rootObject", ArgumentSemantic.Retain)]
			get {
				PhaseObject? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<PhaseObject> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selRootObjectXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<PhaseObject> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selRootObjectXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual PhaseSoundEvent[] SoundEvents {
			[Export ("soundEvents", ArgumentSemantic.Copy)]
			get {
				PhaseSoundEvent[]? ret;
				if (IsDirectBinding) {
					ret = CFArray.ArrayFromHandle<PhaseSoundEvent>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selSoundEventsXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFArray.ArrayFromHandle<PhaseSoundEvent>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selSoundEventsXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual double UnitsPerMeter {
			[Export ("unitsPerMeter")]
			get {
				double ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.Double_objc_msgSend (this.Handle, selUnitsPerMeterXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.Double_objc_msgSendSuper (&__objc_super__, selUnitsPerMeterXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[Export ("setUnitsPerMeter:")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_Double (this.Handle, selSetUnitsPerMeter_XHandle, value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_Double (&__objc_super__, selSetUnitsPerMeter_XHandle, value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual double UnitsPerSecond {
			[Export ("unitsPerSecond")]
			get {
				double ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.Double_objc_msgSend (this.Handle, selUnitsPerSecondXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.Double_objc_msgSendSuper (&__objc_super__, selUnitsPerSecondXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[Export ("setUnitsPerSecond:")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_Double (this.Handle, selSetUnitsPerSecond_XHandle, value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_Double (&__objc_super__, selSetUnitsPerSecond_XHandle, value);
						GC.KeepAlive (this);
					}
				}
			}
		}
	} /* class PhaseEngine */
}
