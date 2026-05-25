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
namespace AudioUnit {
	/// <summary>An input or output connection to an audio unit.</summary><related type="externalDocumentation" href="https://developer.apple.com/library/ios/documentation/AudioUnit/Reference/AUAudioUnitBus_ClassReference/index.html">Apple documentation for <c>AUAudioUnitBus</c></related>
	[Register("AUAudioUnitBus", true)]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("tvos")]
	public unsafe partial class AUAudioUnitBus : NSObject {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selBusTypeX = "busType";
		static readonly NativeHandle selBusTypeXHandle = Selector.GetHandle ("busType");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selContextPresentationLatencyX = "contextPresentationLatency";
		static readonly NativeHandle selContextPresentationLatencyXHandle = Selector.GetHandle ("contextPresentationLatency");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selFormatX = "format";
		static readonly NativeHandle selFormatXHandle = Selector.GetHandle ("format");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selIndexX = "index";
		static readonly NativeHandle selIndexXHandle = Selector.GetHandle ("index");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selInitWithFormat_Error_X = "initWithFormat:error:";
		static readonly NativeHandle selInitWithFormat_Error_XHandle = Selector.GetHandle ("initWithFormat:error:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selIsEnabledX = "isEnabled";
		static readonly NativeHandle selIsEnabledXHandle = Selector.GetHandle ("isEnabled");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selMaximumChannelCountX = "maximumChannelCount";
		static readonly NativeHandle selMaximumChannelCountXHandle = Selector.GetHandle ("maximumChannelCount");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selNameX = "name";
		static readonly NativeHandle selNameXHandle = Selector.GetHandle ("name");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selOwnerAudioUnitX = "ownerAudioUnit";
		static readonly NativeHandle selOwnerAudioUnitXHandle = Selector.GetHandle ("ownerAudioUnit");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetContextPresentationLatency_X = "setContextPresentationLatency:";
		static readonly NativeHandle selSetContextPresentationLatency_XHandle = Selector.GetHandle ("setContextPresentationLatency:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetEnabled_X = "setEnabled:";
		static readonly NativeHandle selSetEnabled_XHandle = Selector.GetHandle ("setEnabled:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetFormat_Error_X = "setFormat:error:";
		static readonly NativeHandle selSetFormat_Error_XHandle = Selector.GetHandle ("setFormat:error:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetMaximumChannelCount_X = "setMaximumChannelCount:";
		static readonly NativeHandle selSetMaximumChannelCount_XHandle = Selector.GetHandle ("setMaximumChannelCount:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetName_X = "setName:";
		static readonly NativeHandle selSetName_XHandle = Selector.GetHandle ("setName:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetShouldAllocateBuffer_X = "setShouldAllocateBuffer:";
		static readonly NativeHandle selSetShouldAllocateBuffer_XHandle = Selector.GetHandle ("setShouldAllocateBuffer:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetSupportedChannelCounts_X = "setSupportedChannelCounts:";
		static readonly NativeHandle selSetSupportedChannelCounts_XHandle = Selector.GetHandle ("setSupportedChannelCounts:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selShouldAllocateBufferX = "shouldAllocateBuffer";
		static readonly NativeHandle selShouldAllocateBufferXHandle = Selector.GetHandle ("shouldAllocateBuffer");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSupportedChannelCountsX = "supportedChannelCounts";
		static readonly NativeHandle selSupportedChannelCountsXHandle = Selector.GetHandle ("supportedChannelCounts");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSupportedChannelLayoutTagsX = "supportedChannelLayoutTags";
		static readonly NativeHandle selSupportedChannelLayoutTagsXHandle = Selector.GetHandle ("supportedChannelLayoutTags");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly NativeHandle class_ptr = Class.GetHandle ("AUAudioUnitBus");
		/// <summary>The Objective-C class handle for this class.</summary>
		/// <value>The pointer to the Objective-C class.</value>
		/// <remarks>
		///     Each managed class mirrors an unmanaged Objective-C class.
		///     This value contains the pointer to the Objective-C class.
		///     It is similar to calling the managed <see cref="ObjCRuntime.Class.GetHandle(string)" /> or the native <see href="https://developer.apple.com/documentation/objectivec/1418952-objc_getclass">objc_getClass</see> method with the type name.
		/// </remarks>
		public override NativeHandle ClassHandle { get { return class_ptr; } }
		/// <summary>Creates a new <see cref="AUAudioUnitBus" /> with default values.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public AUAudioUnitBus () : base (NSObjectFlag.Empty)
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
		protected AUAudioUnitBus (NSObjectFlag t) : base (t)
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
		protected internal AUAudioUnitBus (NativeHandle handle) : base (handle)
		{
		}

		/// <param name="format">A value that provides a detailed description of the channels and formats of audio data.</param><param name="outError"><para>A location to which to record success or failure.</para><para tool="nullallowed">This parameter can be <see langword="null" />.</para></param><summary>Creates a new <see cref="T:AudioUnit.AUAudioUnitBus" /> with the specified <paramref name="format" /> and reports success or failure to <paramref name="outError" />.</summary><remarks>To be added.</remarks>
		[Export ("initWithFormat:error:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe AUAudioUnitBus (global::AVFoundation.AVAudioFormat format, out NSError? outError)
			: base (NSObjectFlag.Empty)
		{
			var format__handle__ = format!.GetNonNullHandle (nameof (format));
			NativeHandle outErrorValue = IntPtr.Zero;
			if (IsDirectBinding) {
				InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_ref_NativeHandle (this.Handle, selInitWithFormat_Error_XHandle, format__handle__, &outErrorValue), "initWithFormat:error:");
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_ref_NativeHandle (&__objc_super__, selInitWithFormat_Error_XHandle, format__handle__, &outErrorValue), "initWithFormat:error:");
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (format);
			outError = Runtime.GetNSObject<NSError> (outErrorValue)!;
		}
		/// <param name="format">A description of the audio format for the bus.</param><param name="outError"><para>A location to which to record success or failure.</para><para tool="nullallowed">This parameter can be <see langword="null" />.</para></param><summary>Sets configuration details about the supported channels and formats of audio data on this bus.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("setFormat:error:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual bool SetFormat (global::AVFoundation.AVAudioFormat format, out NSError? outError)
		{
			var format__handle__ = format!.GetNonNullHandle (nameof (format));
			NativeHandle outErrorValue = IntPtr.Zero;
			byte ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_ref_NativeHandle (this.Handle, selSetFormat_Error_XHandle, format__handle__, &outErrorValue);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper_NativeHandle_ref_NativeHandle (&__objc_super__, selSetFormat_Error_XHandle, format__handle__, &outErrorValue);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (format);
			outError = Runtime.GetNSObject<NSError> (outErrorValue)!;
			return ret != 0;
		}
		/// <summary>Gets a value of type <see cref="T:AudioUnit.AUAudioUnitBusType" /> that tells whether this is an input or output connection.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual AUAudioUnitBusType BusType {
			[Export ("busType")]
			get {
				AUAudioUnitBusType ret;
				if (IsDirectBinding) {
					ret = (AUAudioUnitBusType) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selBusTypeXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = (AUAudioUnitBusType) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (&__objc_super__, selBusTypeXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		/// <summary>Gets or sets the latency of the processing context for the audio unit.</summary><value>To be added.</value><remarks>For input units, this is the time, in seconds, since the arriving audio was acquired. For output units, this is the delay, in seconds, until the output is presented.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual double ContextPresentationLatency {
			[Export ("contextPresentationLatency")]
			get {
				double ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.Double_objc_msgSend (this.Handle, selContextPresentationLatencyXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.Double_objc_msgSendSuper (&__objc_super__, selContextPresentationLatencyXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[Export ("setContextPresentationLatency:")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_Double (this.Handle, selSetContextPresentationLatency_XHandle, value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_Double (&__objc_super__, selSetContextPresentationLatency_XHandle, value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		/// <summary>Gets or sets a value that determines whether the bus is active.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool Enabled {
			[Export ("isEnabled")]
			get {
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selIsEnabledXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, selIsEnabledXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
			[Export ("setEnabled:")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, selSetEnabled_XHandle, value ? (byte) 1 : (byte) 0);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (&__objc_super__, selSetEnabled_XHandle, value ? (byte) 1 : (byte) 0);
						GC.KeepAlive (this);
					}
				}
			}
		}
		/// <summary>Gets a value that provides a detailed description of the channels and formats of audio data.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual global::AVFoundation.AVAudioFormat Format {
			[Export ("format")]
			get {
				global::AVFoundation.AVAudioFormat? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<global::AVFoundation.AVAudioFormat> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selFormatXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<global::AVFoundation.AVAudioFormat> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selFormatXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		/// <summary>Gets the zero-based location of this audio bus in the array that contains it.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual nuint Index {
			[Export ("index")]
			get {
				nuint ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend (this.Handle, selIndexXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.UIntPtr_objc_msgSendSuper (&__objc_super__, selIndexXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
		/// <summary>Gets or sets the maximum number of audio channels that the bus supports.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual uint MaximumChannelCount {
			[Export ("maximumChannelCount")]
			get {
				uint ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.UInt32_objc_msgSend (this.Handle, selMaximumChannelCountXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.UInt32_objc_msgSendSuper (&__objc_super__, selMaximumChannelCountXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[Export ("setMaximumChannelCount:")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_UInt32 (this.Handle, selSetMaximumChannelCount_XHandle, value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_UInt32 (&__objc_super__, selSetMaximumChannelCount_XHandle, value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		/// <summary>Gets or sets the name for the bus.</summary><value><para>(More documentation for this node is coming)</para><para tool="nullallowed">This value can be <see langword="null" />.</para></value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string? Name {
			[Export ("name")]
			get {
				string ret;
				if (IsDirectBinding) {
					ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selNameXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selNameXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[Export ("setName:")]
			set {
				var nsvalue = CFString.CreateNative (value);
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selSetName_XHandle, nsvalue);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selSetName_XHandle, nsvalue);
						GC.KeepAlive (this);
					}
				}
				CFString.ReleaseNative (nsvalue);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		object? __mt_OwnerAudioUnit_var;
		/// <summary>Gets the audio unit that owns this bus.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual AUAudioUnit OwnerAudioUnit {
			[Export ("ownerAudioUnit", ArgumentSemantic.Assign)]
			get {
				AUAudioUnit? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<AUAudioUnit> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selOwnerAudioUnitXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<AUAudioUnit> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selOwnerAudioUnitXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				MarkDirty ();
				__mt_OwnerAudioUnit_var = ret;
				return ret!;
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public virtual bool ShouldAllocateBuffer {
			[Export ("shouldAllocateBuffer")]
			get {
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selShouldAllocateBufferXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, selShouldAllocateBufferXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
			[Export ("setShouldAllocateBuffer:")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, selSetShouldAllocateBuffer_XHandle, value ? (byte) 1 : (byte) 0);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (&__objc_super__, selSetShouldAllocateBuffer_XHandle, value ? (byte) 1 : (byte) 0);
						GC.KeepAlive (this);
					}
				}
			}
		}
		/// <summary>Gets or sets an array that contains the allowable channel counts for this bus. <see langword="null" /> indicates that any number less than <see cref="P:AudioUnit.AUAudioUnitBus.MaximumChannelCount" /> is supported.</summary><value><para>(More documentation for this node is coming)</para><para tool="nullallowed">This value can be <see langword="null" />.</para></value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSNumber[]? SupportedChannelCounts {
			[Export ("supportedChannelCounts", ArgumentSemantic.Retain)]
			get {
				NSNumber[]? ret;
				if (IsDirectBinding) {
					ret = CFArray.ArrayFromHandle<NSNumber>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selSupportedChannelCountsXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFArray.ArrayFromHandle<NSNumber>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selSupportedChannelCountsXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setSupportedChannelCounts:", ArgumentSemantic.Retain)]
			set {
				using var nsa_value = value is null ? null : NSArray.FromNSObjects (value);
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selSetSupportedChannelCounts_XHandle, nsa_value.GetHandle ());
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selSetSupportedChannelCounts_XHandle, nsa_value.GetHandle ());
						GC.KeepAlive (this);
					}
				}
			}
		}
		/// <summary>Gets an array of audio channel layout tags that are supported by this bus.</summary><value><para>(More documentation for this node is coming)</para><para tool="nullallowed">This value can be <see langword="null" />.</para></value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSNumber[]? SupportedChannelLayoutTags {
			[Export ("supportedChannelLayoutTags", ArgumentSemantic.Copy)]
			get {
				NSNumber[]? ret;
				if (IsDirectBinding) {
					ret = CFArray.ArrayFromHandle<NSNumber>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selSupportedChannelLayoutTagsXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFArray.ArrayFromHandle<NSNumber>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selSupportedChannelLayoutTagsXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		protected override void Dispose (bool disposing)
		{
			base.Dispose (disposing);
			if (Handle == IntPtr.Zero) {
				__mt_OwnerAudioUnit_var = null;
			}
		}
	} /* class AUAudioUnitBus */
}
