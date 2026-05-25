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
namespace Metal {
	[Register("MTLRasterizationRateLayerDescriptor", true)]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("tvos16.0")]
	[SupportedOSPlatform ("ios13.0")]
	[SupportedOSPlatform ("macos")]
	public unsafe partial class MTLRasterizationRateLayerDescriptor : NSObject, INSCopying {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selCopyWithZone_X = "copyWithZone:";
		static readonly NativeHandle selCopyWithZone_XHandle = Selector.GetHandle ("copyWithZone:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selHorizontalX = "horizontal";
		static readonly NativeHandle selHorizontalXHandle = Selector.GetHandle ("horizontal");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selHorizontalSampleStorageX = "horizontalSampleStorage";
		static readonly NativeHandle selHorizontalSampleStorageXHandle = Selector.GetHandle ("horizontalSampleStorage");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selInitWithSampleCount_X = "initWithSampleCount:";
		static readonly NativeHandle selInitWithSampleCount_XHandle = Selector.GetHandle ("initWithSampleCount:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selInitWithSampleCount_Horizontal_Vertical_X = "initWithSampleCount:horizontal:vertical:";
		static readonly NativeHandle selInitWithSampleCount_Horizontal_Vertical_XHandle = Selector.GetHandle ("initWithSampleCount:horizontal:vertical:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selMaxSampleCountX = "maxSampleCount";
		static readonly NativeHandle selMaxSampleCountXHandle = Selector.GetHandle ("maxSampleCount");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSampleCountX = "sampleCount";
		static readonly NativeHandle selSampleCountXHandle = Selector.GetHandle ("sampleCount");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetSampleCount_X = "setSampleCount:";
		static readonly NativeHandle selSetSampleCount_XHandle = Selector.GetHandle ("setSampleCount:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selVerticalX = "vertical";
		static readonly NativeHandle selVerticalXHandle = Selector.GetHandle ("vertical");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selVerticalSampleStorageX = "verticalSampleStorage";
		static readonly NativeHandle selVerticalSampleStorageXHandle = Selector.GetHandle ("verticalSampleStorage");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly NativeHandle class_ptr = Class.GetHandle ("MTLRasterizationRateLayerDescriptor");
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
		protected MTLRasterizationRateLayerDescriptor (NSObjectFlag t) : base (t)
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
		protected internal MTLRasterizationRateLayerDescriptor (NativeHandle handle) : base (handle)
		{
		}

		[Export ("initWithSampleCount:")]
		[DesignatedInitializer]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public MTLRasterizationRateLayerDescriptor (MTLSize sampleCount)
			: base (NSObjectFlag.Empty)
		{
			if (IsDirectBinding) {
				InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_MTLSize (this.Handle, selInitWithSampleCount_XHandle, sampleCount), "initWithSampleCount:");
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_MTLSize (&__objc_super__, selInitWithSampleCount_XHandle, sampleCount), "initWithSampleCount:");
					GC.KeepAlive (this);
				}
			}
		}
		[Export ("initWithSampleCount:horizontal:vertical:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal MTLRasterizationRateLayerDescriptor (MTLSize sampleCount, nint horizontal, nint vertical)
			: base (NSObjectFlag.Empty)
		{
			if (IsDirectBinding) {
				InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_MTLSize_IntPtr_IntPtr (this.Handle, selInitWithSampleCount_Horizontal_Vertical_XHandle, sampleCount, horizontal, vertical), "initWithSampleCount:horizontal:vertical:");
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_MTLSize_IntPtr_IntPtr (&__objc_super__, selInitWithSampleCount_Horizontal_Vertical_XHandle, sampleCount, horizontal, vertical), "initWithSampleCount:horizontal:vertical:");
					GC.KeepAlive (this);
				}
			}
		}
		/// <param name="zone">Developers should pass <see langword="null" />.  Memory zones are no longer used.</param><summary>Performs a copy of the underlying Objective-C object.</summary><returns>The newly-allocated object.</returns><remarks><para>This method performs a "shallow copy" of <see langword="this" />. If this object contains references to external objects, the new object will contain references to the same object.</para></remarks>
		[Export ("copyWithZone:")]
		[return: ReleaseAttribute ()]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos16.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSObject Copy (NSZone? zone)
		{
			var zone__handle__ = zone.GetHandle ();
			NSObject? ret;
			if (IsDirectBinding) {
				ret = Runtime.GetNSObject (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, selCopyWithZone_XHandle, zone__handle__), true)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = Runtime.GetNSObject (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle (&__objc_super__, selCopyWithZone_XHandle, zone__handle__), true)!;
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (zone);
			return ret!;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos16.0")]
		public virtual MTLRasterizationRateSampleArray Horizontal {
			[Export ("horizontal")]
			get {
				MTLRasterizationRateSampleArray? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<MTLRasterizationRateSampleArray> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selHorizontalXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<MTLRasterizationRateSampleArray> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selHorizontalXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("ios15.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos16.0")]
		public virtual MTLSize MaxSampleCount {
			[Export ("maxSampleCount")]
			get {
				MTLSize ret;
				if (IsDirectBinding) {
					if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
						ret = global::ObjCRuntime.Messaging.MTLSize_objc_msgSend (this.Handle, selMaxSampleCountXHandle);
					} else {
						ret = global::ObjCRuntime.Messaging.MTLSize_objc_msgSend_stret (this.Handle, selMaxSampleCountXHandle);
					}
				} else {
					if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
						unsafe {
							var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
							ret = global::ObjCRuntime.Messaging.MTLSize_objc_msgSendSuper (&__objc_super__, selMaxSampleCountXHandle);
							GC.KeepAlive (this);
						}
					} else {
						unsafe {
							var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
							ret = global::ObjCRuntime.Messaging.MTLSize_objc_msgSendSuper_stret (&__objc_super__, selMaxSampleCountXHandle);
							GC.KeepAlive (this);
						}
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual MTLSize SampleCount {
			[Export ("sampleCount", ArgumentSemantic.Assign)]
			get {
				MTLSize ret;
				if (IsDirectBinding) {
					if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
						ret = global::ObjCRuntime.Messaging.MTLSize_objc_msgSend (this.Handle, selSampleCountXHandle);
					} else {
						ret = global::ObjCRuntime.Messaging.MTLSize_objc_msgSend_stret (this.Handle, selSampleCountXHandle);
					}
				} else {
					if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
						unsafe {
							var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
							ret = global::ObjCRuntime.Messaging.MTLSize_objc_msgSendSuper (&__objc_super__, selSampleCountXHandle);
							GC.KeepAlive (this);
						}
					} else {
						unsafe {
							var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
							ret = global::ObjCRuntime.Messaging.MTLSize_objc_msgSendSuper_stret (&__objc_super__, selSampleCountXHandle);
							GC.KeepAlive (this);
						}
					}
				}
				return ret!;
			}
			[Export ("setSampleCount:", ArgumentSemantic.Assign)]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_MTLSize (this.Handle, selSetSampleCount_XHandle, value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_MTLSize (&__objc_super__, selSetSampleCount_XHandle, value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos16.0")]
		public virtual MTLRasterizationRateSampleArray Vertical {
			[Export ("vertical")]
			get {
				MTLRasterizationRateSampleArray? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<MTLRasterizationRateSampleArray> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selVerticalXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<MTLRasterizationRateSampleArray> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selVerticalXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos16.0")]
		internal virtual nint _HorizontalSampleStorage {
			[Export ("horizontalSampleStorage")]
			get {
				nint ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selHorizontalSampleStorageXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (&__objc_super__, selHorizontalSampleStorageXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos16.0")]
		internal virtual nint _VerticalSampleStorage {
			[Export ("verticalSampleStorage")]
			get {
				nint ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selVerticalSampleStorageXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (&__objc_super__, selVerticalSampleStorageXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
	} /* class MTLRasterizationRateLayerDescriptor */
}
