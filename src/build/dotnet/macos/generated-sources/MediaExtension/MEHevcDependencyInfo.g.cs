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
	[Register("MEHEVCDependencyInfo", true)]
	[UnsupportedOSPlatform ("tvos")]
	[UnsupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos15.0")]
	[UnsupportedOSPlatform ("maccatalyst")]
	public unsafe partial class MEHevcDependencyInfo : NSObject, INSCopying {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selConstraintIndicatorFlagsX = "constraintIndicatorFlags";
		static readonly NativeHandle selConstraintIndicatorFlagsXHandle = Selector.GetHandle ("constraintIndicatorFlags");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selHasStepwiseTemporalSubLayerAccessX = "hasStepwiseTemporalSubLayerAccess";
		static readonly NativeHandle selHasStepwiseTemporalSubLayerAccessXHandle = Selector.GetHandle ("hasStepwiseTemporalSubLayerAccess");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selHasTemporalSubLayerAccessX = "hasTemporalSubLayerAccess";
		static readonly NativeHandle selHasTemporalSubLayerAccessXHandle = Selector.GetHandle ("hasTemporalSubLayerAccess");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selLevelIndexX = "levelIndex";
		static readonly NativeHandle selLevelIndexXHandle = Selector.GetHandle ("levelIndex");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selProfileCompatibilityFlagsX = "profileCompatibilityFlags";
		static readonly NativeHandle selProfileCompatibilityFlagsXHandle = Selector.GetHandle ("profileCompatibilityFlags");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selProfileIndexX = "profileIndex";
		static readonly NativeHandle selProfileIndexXHandle = Selector.GetHandle ("profileIndex");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selProfileSpaceX = "profileSpace";
		static readonly NativeHandle selProfileSpaceXHandle = Selector.GetHandle ("profileSpace");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetConstraintIndicatorFlags_X = "setConstraintIndicatorFlags:";
		static readonly NativeHandle selSetConstraintIndicatorFlags_XHandle = Selector.GetHandle ("setConstraintIndicatorFlags:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetLevelIndex_X = "setLevelIndex:";
		static readonly NativeHandle selSetLevelIndex_XHandle = Selector.GetHandle ("setLevelIndex:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetProfileCompatibilityFlags_X = "setProfileCompatibilityFlags:";
		static readonly NativeHandle selSetProfileCompatibilityFlags_XHandle = Selector.GetHandle ("setProfileCompatibilityFlags:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetProfileIndex_X = "setProfileIndex:";
		static readonly NativeHandle selSetProfileIndex_XHandle = Selector.GetHandle ("setProfileIndex:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetProfileSpace_X = "setProfileSpace:";
		static readonly NativeHandle selSetProfileSpace_XHandle = Selector.GetHandle ("setProfileSpace:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetStepwiseTemporalSubLayerAccess_X = "setStepwiseTemporalSubLayerAccess:";
		static readonly NativeHandle selSetStepwiseTemporalSubLayerAccess_XHandle = Selector.GetHandle ("setStepwiseTemporalSubLayerAccess:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetSyncSampleNALUnitType_X = "setSyncSampleNALUnitType:";
		static readonly NativeHandle selSetSyncSampleNALUnitType_XHandle = Selector.GetHandle ("setSyncSampleNALUnitType:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetTemporalLevel_X = "setTemporalLevel:";
		static readonly NativeHandle selSetTemporalLevel_XHandle = Selector.GetHandle ("setTemporalLevel:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetTemporalSubLayerAccess_X = "setTemporalSubLayerAccess:";
		static readonly NativeHandle selSetTemporalSubLayerAccess_XHandle = Selector.GetHandle ("setTemporalSubLayerAccess:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetTierFlag_X = "setTierFlag:";
		static readonly NativeHandle selSetTierFlag_XHandle = Selector.GetHandle ("setTierFlag:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSyncSampleNALUnitTypeX = "syncSampleNALUnitType";
		static readonly NativeHandle selSyncSampleNALUnitTypeXHandle = Selector.GetHandle ("syncSampleNALUnitType");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selTemporalLevelX = "temporalLevel";
		static readonly NativeHandle selTemporalLevelXHandle = Selector.GetHandle ("temporalLevel");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selTierFlagX = "tierFlag";
		static readonly NativeHandle selTierFlagXHandle = Selector.GetHandle ("tierFlag");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly NativeHandle class_ptr = Class.GetHandle ("MEHEVCDependencyInfo");
		/// <summary>The Objective-C class handle for this class.</summary>
		/// <value>The pointer to the Objective-C class.</value>
		/// <remarks>
		///     Each managed class mirrors an unmanaged Objective-C class.
		///     This value contains the pointer to the Objective-C class.
		///     It is similar to calling the managed <see cref="ObjCRuntime.Class.GetHandle(string)" /> or the native <see href="https://developer.apple.com/documentation/objectivec/1418952-objc_getclass">objc_getClass</see> method with the type name.
		/// </remarks>
		public override NativeHandle ClassHandle { get { return class_ptr; } }
		/// <summary>Creates a new <see cref="MEHevcDependencyInfo" /> with default values.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public MEHevcDependencyInfo () : base (NSObjectFlag.Empty)
		{
			if (IsDirectBinding) {
				InitializeHandle (global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, global::ObjCRuntime.Selector.Init), "init");
			} else {
				unsafe {
				var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
				InitializeHandle (global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (&__objc_super__, global::ObjCRuntime.Selector.Init), "init");
				GC.KeepAlive (this);
				}
			}
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
		protected MEHevcDependencyInfo (NSObjectFlag t) : base (t)
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
		protected internal MEHevcDependencyInfo (NativeHandle handle) : base (handle)
		{
		}

		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSData? ConstraintIndicatorFlags {
			[Export ("constraintIndicatorFlags", ArgumentSemantic.Copy)]
			get {
				NSData? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSData> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selConstraintIndicatorFlagsXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<NSData> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selConstraintIndicatorFlagsXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setConstraintIndicatorFlags:", ArgumentSemantic.Copy)]
			set {
				var value__handle__ = value.GetHandle ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selSetConstraintIndicatorFlags_XHandle, value__handle__);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selSetConstraintIndicatorFlags_XHandle, value__handle__);
						GC.KeepAlive (this);
					}
				}
				GC.KeepAlive (value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual short LevelIndex {
			[Export ("levelIndex")]
			get {
				short ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.short_objc_msgSend (this.Handle, selLevelIndexXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.short_objc_msgSendSuper (&__objc_super__, selLevelIndexXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[Export ("setLevelIndex:")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_short (this.Handle, selSetLevelIndex_XHandle, value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_short (&__objc_super__, selSetLevelIndex_XHandle, value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSData? ProfileCompatibilityFlags {
			[Export ("profileCompatibilityFlags", ArgumentSemantic.Copy)]
			get {
				NSData? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSData> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selProfileCompatibilityFlagsXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<NSData> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selProfileCompatibilityFlagsXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setProfileCompatibilityFlags:", ArgumentSemantic.Copy)]
			set {
				var value__handle__ = value.GetHandle ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selSetProfileCompatibilityFlags_XHandle, value__handle__);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selSetProfileCompatibilityFlags_XHandle, value__handle__);
						GC.KeepAlive (this);
					}
				}
				GC.KeepAlive (value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual short ProfileIndex {
			[Export ("profileIndex")]
			get {
				short ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.short_objc_msgSend (this.Handle, selProfileIndexXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.short_objc_msgSendSuper (&__objc_super__, selProfileIndexXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[Export ("setProfileIndex:")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_short (this.Handle, selSetProfileIndex_XHandle, value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_short (&__objc_super__, selSetProfileIndex_XHandle, value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual short ProfileSpace {
			[Export ("profileSpace")]
			get {
				short ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.short_objc_msgSend (this.Handle, selProfileSpaceXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.short_objc_msgSendSuper (&__objc_super__, selProfileSpaceXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[Export ("setProfileSpace:")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_short (this.Handle, selSetProfileSpace_XHandle, value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_short (&__objc_super__, selSetProfileSpace_XHandle, value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool StepwiseTemporalSubLayerAccess {
			[Export ("hasStepwiseTemporalSubLayerAccess")]
			get {
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selHasStepwiseTemporalSubLayerAccessXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, selHasStepwiseTemporalSubLayerAccessXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
			[Export ("setStepwiseTemporalSubLayerAccess:")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, selSetStepwiseTemporalSubLayerAccess_XHandle, value ? (byte) 1 : (byte) 0);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (&__objc_super__, selSetStepwiseTemporalSubLayerAccess_XHandle, value ? (byte) 1 : (byte) 0);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual short SyncSampleNALUnitType {
			[Export ("syncSampleNALUnitType")]
			get {
				short ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.short_objc_msgSend (this.Handle, selSyncSampleNALUnitTypeXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.short_objc_msgSendSuper (&__objc_super__, selSyncSampleNALUnitTypeXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[Export ("setSyncSampleNALUnitType:")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_short (this.Handle, selSetSyncSampleNALUnitType_XHandle, value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_short (&__objc_super__, selSetSyncSampleNALUnitType_XHandle, value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual short TemporalLevel {
			[Export ("temporalLevel")]
			get {
				short ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.short_objc_msgSend (this.Handle, selTemporalLevelXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.short_objc_msgSendSuper (&__objc_super__, selTemporalLevelXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[Export ("setTemporalLevel:")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_short (this.Handle, selSetTemporalLevel_XHandle, value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_short (&__objc_super__, selSetTemporalLevel_XHandle, value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool TemporalSubLayerAccess {
			[Export ("hasTemporalSubLayerAccess")]
			get {
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selHasTemporalSubLayerAccessXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, selHasTemporalSubLayerAccessXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
			[Export ("setTemporalSubLayerAccess:")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, selSetTemporalSubLayerAccess_XHandle, value ? (byte) 1 : (byte) 0);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (&__objc_super__, selSetTemporalSubLayerAccess_XHandle, value ? (byte) 1 : (byte) 0);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual short TierFlag {
			[Export ("tierFlag")]
			get {
				short ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.short_objc_msgSend (this.Handle, selTierFlagXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.short_objc_msgSendSuper (&__objc_super__, selTierFlagXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[Export ("setTierFlag:")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_short (this.Handle, selSetTierFlag_XHandle, value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_short (&__objc_super__, selSetTierFlag_XHandle, value);
						GC.KeepAlive (this);
					}
				}
			}
		}
	} /* class MEHevcDependencyInfo */
}
