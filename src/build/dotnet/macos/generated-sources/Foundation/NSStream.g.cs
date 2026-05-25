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
namespace Foundation {
	[Register("NSStream", true)]
	public unsafe partial class NSStream : NSObject {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selCloseX = "close";
		static readonly NativeHandle selCloseXHandle = Selector.GetHandle ("close");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selDelegateX = "delegate";
		static readonly NativeHandle selDelegateXHandle = Selector.GetHandle ("delegate");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selGetBoundStreamsWithBufferSize_InputStream_OutputStream_X = "getBoundStreamsWithBufferSize:inputStream:outputStream:";
		static readonly NativeHandle selGetBoundStreamsWithBufferSize_InputStream_OutputStream_XHandle = Selector.GetHandle ("getBoundStreamsWithBufferSize:inputStream:outputStream:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selGetStreamsToHostWithName_Port_InputStream_OutputStream_X = "getStreamsToHostWithName:port:inputStream:outputStream:";
		static readonly NativeHandle selGetStreamsToHostWithName_Port_InputStream_OutputStream_XHandle = Selector.GetHandle ("getStreamsToHostWithName:port:inputStream:outputStream:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selOpenX = "open";
		static readonly NativeHandle selOpenXHandle = Selector.GetHandle ("open");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selPropertyForKey_X = "propertyForKey:";
		static readonly NativeHandle selPropertyForKey_XHandle = Selector.GetHandle ("propertyForKey:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selRemoveFromRunLoop_ForMode_X = "removeFromRunLoop:forMode:";
		static readonly NativeHandle selRemoveFromRunLoop_ForMode_XHandle = Selector.GetHandle ("removeFromRunLoop:forMode:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selScheduleInRunLoop_ForMode_X = "scheduleInRunLoop:forMode:";
		static readonly NativeHandle selScheduleInRunLoop_ForMode_XHandle = Selector.GetHandle ("scheduleInRunLoop:forMode:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetDelegate_X = "setDelegate:";
		static readonly NativeHandle selSetDelegate_XHandle = Selector.GetHandle ("setDelegate:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetProperty_ForKey_X = "setProperty:forKey:";
		static readonly NativeHandle selSetProperty_ForKey_XHandle = Selector.GetHandle ("setProperty:forKey:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selStreamErrorX = "streamError";
		static readonly NativeHandle selStreamErrorXHandle = Selector.GetHandle ("streamError");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selStreamStatusX = "streamStatus";
		static readonly NativeHandle selStreamStatusXHandle = Selector.GetHandle ("streamStatus");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly NativeHandle class_ptr = Class.GetHandle ("NSStream");
		/// <summary>The Objective-C class handle for this class.</summary>
		/// <value>The pointer to the Objective-C class.</value>
		/// <remarks>
		///     Each managed class mirrors an unmanaged Objective-C class.
		///     This value contains the pointer to the Objective-C class.
		///     It is similar to calling the managed <see cref="ObjCRuntime.Class.GetHandle(string)" /> or the native <see href="https://developer.apple.com/documentation/objectivec/1418952-objc_getclass">objc_getClass</see> method with the type name.
		/// </remarks>
		public override NativeHandle ClassHandle { get { return class_ptr; } }
		/// <summary>Creates a new <see cref="NSStream" /> with default values.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public NSStream () : base (NSObjectFlag.Empty)
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
		protected NSStream (NSObjectFlag t) : base (t)
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
		protected internal NSStream (NativeHandle handle) : base (handle)
		{
		}

		[Export ("close")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void Close ()
		{
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, selCloseXHandle);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper (&__objc_super__, selCloseXHandle);
					GC.KeepAlive (this);
				}
			}
		}
		/// <param name="bufferSize">To be added.</param><param name="inputStream">To be added.</param><param name="outputStream">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("getBoundStreamsWithBufferSize:inputStream:outputStream:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static void GetBoundStreams (nuint bufferSize, out NSInputStream inputStream, out NSOutputStream outputStream)
		{
			NativeHandle inputStreamValue = IntPtr.Zero;
			NativeHandle outputStreamValue = IntPtr.Zero;
			global::ObjCRuntime.Messaging.void_objc_msgSend_UIntPtr_ref_NativeHandle_ref_NativeHandle (class_ptr, selGetBoundStreamsWithBufferSize_InputStream_OutputStream_XHandle, bufferSize, &inputStreamValue, &outputStreamValue);
			inputStream = Runtime.GetNSObject<NSInputStream> (inputStreamValue)!;
			outputStream = Runtime.GetNSObject<NSOutputStream> (outputStreamValue)!;
		}
		[Export ("propertyForKey:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		protected virtual NSObject? GetProperty (NSString key)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="hostname">To be added.</param><param name="port">To be added.</param><param name="inputStream">To be added.</param><param name="outputStream">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("getStreamsToHostWithName:port:inputStream:outputStream:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static void GetStreamsToHost (string hostname, nint port, out NSInputStream inputStream, out NSOutputStream outputStream)
		{
			if (hostname is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (hostname));
			NativeHandle inputStreamValue = IntPtr.Zero;
			NativeHandle outputStreamValue = IntPtr.Zero;
			var nshostname = CFString.CreateNative (hostname);
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_IntPtr_ref_NativeHandle_ref_NativeHandle (class_ptr, selGetStreamsToHostWithName_Port_InputStream_OutputStream_XHandle, nshostname, port, &inputStreamValue, &outputStreamValue);
			CFString.ReleaseNative (nshostname);
			inputStream = Runtime.GetNSObject<NSInputStream> (inputStreamValue)!;
			outputStream = Runtime.GetNSObject<NSOutputStream> (outputStreamValue)!;
		}
		[Export ("open")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void Open ()
		{
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, selOpenXHandle);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper (&__objc_super__, selOpenXHandle);
					GC.KeepAlive (this);
				}
			}
		}
		[Export ("scheduleInRunLoop:forMode:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void Schedule (NSRunLoop aRunLoop, NSString mode)
		{
			var aRunLoop__handle__ = aRunLoop!.GetNonNullHandle (nameof (aRunLoop));
			var mode__handle__ = mode!.GetNonNullHandle (nameof (mode));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (this.Handle, selScheduleInRunLoop_ForMode_XHandle, aRunLoop__handle__, mode__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, selScheduleInRunLoop_ForMode_XHandle, aRunLoop__handle__, mode__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (aRunLoop);
			GC.KeepAlive (mode);
		}
		/// <param name="aRunLoop">To be added.</param><param name="mode">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void Schedule (NSRunLoop aRunLoop, NSRunLoopMode mode)
		{
			Schedule (aRunLoop, mode.GetConstant ()!);
		}
		[Export ("setProperty:forKey:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		protected virtual bool SetProperty (NSObject? property, NSString key)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("removeFromRunLoop:forMode:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void Unschedule (NSRunLoop aRunLoop, NSString mode)
		{
			var aRunLoop__handle__ = aRunLoop!.GetNonNullHandle (nameof (aRunLoop));
			var mode__handle__ = mode!.GetNonNullHandle (nameof (mode));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (this.Handle, selRemoveFromRunLoop_ForMode_XHandle, aRunLoop__handle__, mode__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, selRemoveFromRunLoop_ForMode_XHandle, aRunLoop__handle__, mode__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (aRunLoop);
			GC.KeepAlive (mode);
		}
		/// <param name="aRunLoop">To be added.</param><param name="mode">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void Unschedule (NSRunLoop aRunLoop, NSRunLoopMode mode)
		{
			Unschedule (aRunLoop, mode.GetConstant ()!);
		}
		/// <summary>An instance of the Foundation.INSStreamDelegate model class which acts as the class delegate.</summary><value>The instance of the Foundation.INSStreamDelegate model class</value><remarks><para>The delegate instance assigned to this object will be used to handle events or provide data on demand to this class.</para><para>When setting the Delegate or WeakDelegate values events will be delivered to the specified instance instead of being delivered to the C#-style events</para><para>This is the strongly typed version of the object, developers should use the WeakDelegate property instead if they want to merely assign a class derived from NSObject that has been decorated with [Export] attributes.</para></remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public INSStreamDelegate Delegate {
			get {
				return (WeakDelegate as INSStreamDelegate)!;
			}
			set {
				var rvalue = value as NSObject;
				if (!(value is null) && rvalue is null)
					throw new ArgumentException ("The object passed of type " + value.GetType () + " does not derive from NSObject");
				WeakDelegate = rvalue;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSError Error {
			[Export ("streamError")]
			get {
				NSError? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSError> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selStreamErrorXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<NSError> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selStreamErrorXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSStreamStatus Status {
			[Export ("streamStatus")]
			get {
				NSStreamStatus ret;
				if (IsDirectBinding) {
					ret = (NSStreamStatus) (ulong) global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend (this.Handle, selStreamStatusXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = (NSStreamStatus) (ulong) global::ObjCRuntime.Messaging.UIntPtr_objc_msgSendSuper (&__objc_super__, selStreamStatusXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		object? __mt_WeakDelegate_var;
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSObject? WeakDelegate {
			[Export ("delegate", ArgumentSemantic.Weak)]
			get {
				NSObject? ret;
				if (IsDirectBinding) {
					ret = Runtime.GetNSObject (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selDelegateXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = Runtime.GetNSObject (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selDelegateXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				MarkDirty ();
				__mt_WeakDelegate_var = ret;
				return ret!;
			}
			[Export ("setDelegate:", ArgumentSemantic.Weak)]
			set {
				NSApplication.EnsureDelegateAssignIsNotOverwritingInternalDelegate (__mt_WeakDelegate_var, value, GetInternalEventDelegateType);
				var value__handle__ = value.GetHandle ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selSetDelegate_XHandle, value__handle__);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selSetDelegate_XHandle, value__handle__);
						GC.KeepAlive (this);
					}
				}
				GC.KeepAlive (value);
				MarkDirty ();
				__mt_WeakDelegate_var = value;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _DataWrittenToMemoryStreamKey;
		/// <summary>Low-level key: Represents the value associated with the constant NSStreamDataWrittenToMemoryStreamKey</summary><value></value><remarks>To be added.</remarks>
		[Field ("NSStreamDataWrittenToMemoryStreamKey",  "Foundation")]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		public static NSString DataWrittenToMemoryStreamKey {
			get {
				if (_DataWrittenToMemoryStreamKey is null)
					_DataWrittenToMemoryStreamKey = Dlfcn.GetStringConstant (Libraries.Foundation.Handle, "NSStreamDataWrittenToMemoryStreamKey")!;
				return _DataWrittenToMemoryStreamKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _FileCurrentOffsetKey;
		/// <summary>Low-level key: Represents the value associated with the constant NSStreamFileCurrentOffsetKey</summary><value></value><remarks>To be added.</remarks>
		[Field ("NSStreamFileCurrentOffsetKey",  "Foundation")]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		public static NSString FileCurrentOffsetKey {
			get {
				if (_FileCurrentOffsetKey is null)
					_FileCurrentOffsetKey = Dlfcn.GetStringConstant (Libraries.Foundation.Handle, "NSStreamFileCurrentOffsetKey")!;
				return _FileCurrentOffsetKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _NetworkServiceType;
		/// <summary>The low-level service type that this stream is providing.</summary><value></value><remarks>This is the low-level token-based setting for the service type, in general, you can use the strongly typed ServiceType instead.</remarks>
		[Field ("NSStreamNetworkServiceType",  "Foundation")]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		public static NSString NetworkServiceType {
			get {
				if (_NetworkServiceType is null)
					_NetworkServiceType = Dlfcn.GetStringConstant (Libraries.Foundation.Handle, "NSStreamNetworkServiceType")!;
				return _NetworkServiceType;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _NetworkServiceTypeBackground;
		/// <summary>Low-level key: Represents the value associated with the constant NSStreamNetworkServiceTypeBackground</summary><value></value><remarks></remarks>
		[Field ("NSStreamNetworkServiceTypeBackground",  "Foundation")]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		public static NSString NetworkServiceTypeBackground {
			get {
				if (_NetworkServiceTypeBackground is null)
					_NetworkServiceTypeBackground = Dlfcn.GetStringConstant (Libraries.Foundation.Handle, "NSStreamNetworkServiceTypeBackground")!;
				return _NetworkServiceTypeBackground;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _NetworkServiceTypeCallSignaling;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("NSStreamNetworkServiceTypeCallSignaling",  "Foundation")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		public static NSString NetworkServiceTypeCallSignaling {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_NetworkServiceTypeCallSignaling is null)
					_NetworkServiceTypeCallSignaling = Dlfcn.GetStringConstant (Libraries.Foundation.Handle, "NSStreamNetworkServiceTypeCallSignaling")!;
				return _NetworkServiceTypeCallSignaling;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _NetworkServiceTypeVideo;
		/// <summary>Low-level key: Represents the value associated with the constant NSStreamNetworkServiceTypeVideo</summary><value></value><remarks>To be added.</remarks>
		[Field ("NSStreamNetworkServiceTypeVideo",  "Foundation")]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		public static NSString NetworkServiceTypeVideo {
			get {
				if (_NetworkServiceTypeVideo is null)
					_NetworkServiceTypeVideo = Dlfcn.GetStringConstant (Libraries.Foundation.Handle, "NSStreamNetworkServiceTypeVideo")!;
				return _NetworkServiceTypeVideo;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _NetworkServiceTypeVoIP;
		/// <summary>Low-level key: Represents the value associated with the constant NSStreamNetworkServiceTypeVoIP</summary><value></value><remarks>To be added.</remarks>
		[Field ("NSStreamNetworkServiceTypeVoIP",  "Foundation")]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		public static NSString NetworkServiceTypeVoIP {
			get {
				if (_NetworkServiceTypeVoIP is null)
					_NetworkServiceTypeVoIP = Dlfcn.GetStringConstant (Libraries.Foundation.Handle, "NSStreamNetworkServiceTypeVoIP")!;
				return _NetworkServiceTypeVoIP;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _NetworkServiceTypeVoice;
		/// <summary>Low-level key: Represents the value associated with the constant NSStreamNetworkServiceTypeVoice</summary><value></value><remarks>To be added.</remarks>
		[Field ("NSStreamNetworkServiceTypeVoice",  "Foundation")]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		public static NSString NetworkServiceTypeVoice {
			get {
				if (_NetworkServiceTypeVoice is null)
					_NetworkServiceTypeVoice = Dlfcn.GetStringConstant (Libraries.Foundation.Handle, "NSStreamNetworkServiceTypeVoice")!;
				return _NetworkServiceTypeVoice;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _SocketSecurityLevelKey;
		/// <summary>Low-level key: Represents the value associated with the constant NSStreamSocketSecurityLevelKey</summary><value></value><remarks>To be added.</remarks>
		[Field ("NSStreamSocketSecurityLevelKey",  "Foundation")]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		public static NSString SocketSecurityLevelKey {
			get {
				if (_SocketSecurityLevelKey is null)
					_SocketSecurityLevelKey = Dlfcn.GetStringConstant (Libraries.Foundation.Handle, "NSStreamSocketSecurityLevelKey")!;
				return _SocketSecurityLevelKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _SocketSecurityLevelNegotiatedSsl;
		/// <summary>Low-level key: Represents the value associated with the constant NSStreamSocketSecurityLevelNegotiatedSSL</summary><value></value><remarks>To be added.</remarks>
		[Field ("NSStreamSocketSecurityLevelNegotiatedSSL",  "Foundation")]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		public static NSString SocketSecurityLevelNegotiatedSsl {
			get {
				if (_SocketSecurityLevelNegotiatedSsl is null)
					_SocketSecurityLevelNegotiatedSsl = Dlfcn.GetStringConstant (Libraries.Foundation.Handle, "NSStreamSocketSecurityLevelNegotiatedSSL")!;
				return _SocketSecurityLevelNegotiatedSsl;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _SocketSecurityLevelNone;
		/// <summary>Low-level key: Represents the value associated with the constant NSStreamSocketSecurityLevelNone</summary><value></value><remarks>To be added.</remarks>
		[Field ("NSStreamSocketSecurityLevelNone",  "Foundation")]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		public static NSString SocketSecurityLevelNone {
			get {
				if (_SocketSecurityLevelNone is null)
					_SocketSecurityLevelNone = Dlfcn.GetStringConstant (Libraries.Foundation.Handle, "NSStreamSocketSecurityLevelNone")!;
				return _SocketSecurityLevelNone;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _SocketSecurityLevelSslV2;
		/// <summary>Low-level key: Represents the value associated with the constant NSStreamSocketSecurityLevelSSLv2</summary><value></value><remarks>To be added.</remarks>
		[Field ("NSStreamSocketSecurityLevelSSLv2",  "Foundation")]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		public static NSString SocketSecurityLevelSslV2 {
			get {
				if (_SocketSecurityLevelSslV2 is null)
					_SocketSecurityLevelSslV2 = Dlfcn.GetStringConstant (Libraries.Foundation.Handle, "NSStreamSocketSecurityLevelSSLv2")!;
				return _SocketSecurityLevelSslV2;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _SocketSecurityLevelSslV3;
		/// <summary>Low-level key: Represents the value associated with the constant NSStreamSocketSecurityLevelSSLv3</summary><value></value><remarks>To be added.</remarks>
		[Field ("NSStreamSocketSecurityLevelSSLv3",  "Foundation")]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		public static NSString SocketSecurityLevelSslV3 {
			get {
				if (_SocketSecurityLevelSslV3 is null)
					_SocketSecurityLevelSslV3 = Dlfcn.GetStringConstant (Libraries.Foundation.Handle, "NSStreamSocketSecurityLevelSSLv3")!;
				return _SocketSecurityLevelSslV3;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _SocketSecurityLevelTlsV1;
		/// <summary>Low-level key: Represents the value associated with the constant NSStreamSocketSecurityLevelTLSv1</summary><value></value><remarks>To be added.</remarks>
		[Field ("NSStreamSocketSecurityLevelTLSv1",  "Foundation")]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		public static NSString SocketSecurityLevelTlsV1 {
			get {
				if (_SocketSecurityLevelTlsV1 is null)
					_SocketSecurityLevelTlsV1 = Dlfcn.GetStringConstant (Libraries.Foundation.Handle, "NSStreamSocketSecurityLevelTLSv1")!;
				return _SocketSecurityLevelTlsV1;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _SocketSslErrorDomain;
		/// <summary>Low-level key: Represents the value associated with the constant NSStreamSocketSSLErrorDomain</summary><value></value><remarks>To be added.</remarks>
		[Field ("NSStreamSocketSSLErrorDomain",  "Foundation")]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		public static NSString SocketSslErrorDomain {
			get {
				if (_SocketSslErrorDomain is null)
					_SocketSslErrorDomain = Dlfcn.GetStringConstant (Libraries.Foundation.Handle, "NSStreamSocketSSLErrorDomain")!;
				return _SocketSslErrorDomain;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _SocksErrorDomain;
		/// <summary>Low-level key: Represents the value associated with the constant NSStreamSOCKSErrorDomain</summary><value></value><remarks>To be added.</remarks>
		[Field ("NSStreamSOCKSErrorDomain",  "Foundation")]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		public static NSString SocksErrorDomain {
			get {
				if (_SocksErrorDomain is null)
					_SocksErrorDomain = Dlfcn.GetStringConstant (Libraries.Foundation.Handle, "NSStreamSOCKSErrorDomain")!;
				return _SocksErrorDomain;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _SocksProxyConfigurationKey;
		/// <summary>Low-level key: Represents the value associated with the constant NSStreamSOCKSProxyConfigurationKey</summary><value></value><remarks>To be added.</remarks>
		[Field ("NSStreamSOCKSProxyConfigurationKey",  "Foundation")]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		public static NSString SocksProxyConfigurationKey {
			get {
				if (_SocksProxyConfigurationKey is null)
					_SocksProxyConfigurationKey = Dlfcn.GetStringConstant (Libraries.Foundation.Handle, "NSStreamSOCKSProxyConfigurationKey")!;
				return _SocksProxyConfigurationKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _SocksProxyHostKey;
		/// <summary>Low-level key: Represents the value associated with the constant NSStreamSOCKSProxyHostKey</summary><value></value><remarks>To be added.</remarks>
		[Field ("NSStreamSOCKSProxyHostKey",  "Foundation")]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		public static NSString SocksProxyHostKey {
			get {
				if (_SocksProxyHostKey is null)
					_SocksProxyHostKey = Dlfcn.GetStringConstant (Libraries.Foundation.Handle, "NSStreamSOCKSProxyHostKey")!;
				return _SocksProxyHostKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _SocksProxyPasswordKey;
		/// <summary>Low-level key: Represents the value associated with the constant NSStreamSOCKSProxyPasswordKey</summary><value></value><remarks>To be added.</remarks>
		[Field ("NSStreamSOCKSProxyPasswordKey",  "Foundation")]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		public static NSString SocksProxyPasswordKey {
			get {
				if (_SocksProxyPasswordKey is null)
					_SocksProxyPasswordKey = Dlfcn.GetStringConstant (Libraries.Foundation.Handle, "NSStreamSOCKSProxyPasswordKey")!;
				return _SocksProxyPasswordKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _SocksProxyPortKey;
		/// <summary>Low-level key: Represents the value associated with the constant NSStreamSOCKSProxyPortKey</summary><value></value><remarks>To be added.</remarks>
		[Field ("NSStreamSOCKSProxyPortKey",  "Foundation")]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		public static NSString SocksProxyPortKey {
			get {
				if (_SocksProxyPortKey is null)
					_SocksProxyPortKey = Dlfcn.GetStringConstant (Libraries.Foundation.Handle, "NSStreamSOCKSProxyPortKey")!;
				return _SocksProxyPortKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _SocksProxyUserKey;
		/// <summary>Low-level key: Represents the value associated with the constant NSStreamSOCKSProxyUserKey</summary><value></value><remarks>To be added.</remarks>
		[Field ("NSStreamSOCKSProxyUserKey",  "Foundation")]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		public static NSString SocksProxyUserKey {
			get {
				if (_SocksProxyUserKey is null)
					_SocksProxyUserKey = Dlfcn.GetStringConstant (Libraries.Foundation.Handle, "NSStreamSOCKSProxyUserKey")!;
				return _SocksProxyUserKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _SocksProxyVersion4;
		/// <summary>Low-level key: Represents the value associated with the constant NSStreamSOCKSProxyVersion4</summary><value></value><remarks>To be added.</remarks>
		[Field ("NSStreamSOCKSProxyVersion4",  "Foundation")]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		public static NSString SocksProxyVersion4 {
			get {
				if (_SocksProxyVersion4 is null)
					_SocksProxyVersion4 = Dlfcn.GetStringConstant (Libraries.Foundation.Handle, "NSStreamSOCKSProxyVersion4")!;
				return _SocksProxyVersion4;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _SocksProxyVersion5;
		/// <summary>Low-level key: Represents the value associated with the constant NSStreamSOCKSProxyVersion5</summary><value></value><remarks>To be added.</remarks>
		[Field ("NSStreamSOCKSProxyVersion5",  "Foundation")]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		public static NSString SocksProxyVersion5 {
			get {
				if (_SocksProxyVersion5 is null)
					_SocksProxyVersion5 = Dlfcn.GetStringConstant (Libraries.Foundation.Handle, "NSStreamSOCKSProxyVersion5")!;
				return _SocksProxyVersion5;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _SocksProxyVersionKey;
		/// <summary>Low-level key: Represents the value associated with the constant NSStreamSOCKSProxyVersionKey</summary><value></value><remarks>To be added.</remarks>
		[Field ("NSStreamSOCKSProxyVersionKey",  "Foundation")]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		public static NSString SocksProxyVersionKey {
			get {
				if (_SocksProxyVersionKey is null)
					_SocksProxyVersionKey = Dlfcn.GetStringConstant (Libraries.Foundation.Handle, "NSStreamSOCKSProxyVersionKey")!;
				return _SocksProxyVersionKey;
			}
		}
		//
		// Events and properties from the delegate
		//
		internal virtual Type GetInternalEventDelegateType
		{
			get { return typeof (_NSStreamDelegate); }
		}
		internal virtual _NSStreamDelegate CreateInternalEventDelegateType ()
		{
			return (_NSStreamDelegate)(new _NSStreamDelegate());
		}
		internal _NSStreamDelegate EnsureNSStreamDelegate ()
		{
			if (WeakDelegate is not null)
				NSApplication.EnsureEventAndDelegateAreNotMismatched (WeakDelegate, GetInternalEventDelegateType);
			var del = Delegate as _NSStreamDelegate;
			if (del is null){
				del = (_NSStreamDelegate)CreateInternalEventDelegateType ();
				Delegate = (INSStreamDelegate)del;
			}
			return del;
		}
		#pragma warning disable 672
		[Register]
		internal class _NSStreamDelegate : NSObject, INSStreamDelegate { 
			public _NSStreamDelegate () { IsDirectBinding = false; }
			[DynamicDependency (DynamicallyAccessedMemberTypes.PublicMethods, typeof (_NSStreamDelegate))]
			static _NSStreamDelegate ()
			{
				GC.KeepAlive (null);
			}
			internal EventHandler<NSStreamEventArgs>? handleEvent;
			[Export ("stream:handleEvent:")]
			public void HandleEvent (NSStream theStream, NSStreamEvent streamEvent)
			{
				var handler = handleEvent;
				if (handler is not null){
					var args = new NSStreamEventArgs (streamEvent);
					handler (theStream, args);
				}
			}
		}
		#pragma warning restore 672
		/// <summary>To be added.</summary>
		/// <remarks>To be added.</remarks>
		public event EventHandler<NSStreamEventArgs> OnEvent {
			add { EnsureNSStreamDelegate ()!.handleEvent += value; }
			remove { EnsureNSStreamDelegate ()!.handleEvent -= value; }
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		protected override void Dispose (bool disposing)
		{
			base.Dispose (disposing);
			if (Handle == IntPtr.Zero) {
				__mt_WeakDelegate_var = null;
			}
		}
	} /* class NSStream */
	//
	// EventArgs classes
	//
	/// <summary>Provides data for an event based on an Objective-C protocol method.</summary>
	public partial class NSStreamEventArgs : EventArgs {
		/// <summary>Create a new instance of the <see cref="NSStreamEventArgs" /> with the specified event data.</summary>
		/// <param name="streamEvent">The value for the <see cref="StreamEvent" /> property.</param>
		public NSStreamEventArgs (NSStreamEvent streamEvent)
		{
			this.StreamEvent = streamEvent;
		}
		public NSStreamEvent StreamEvent { get; set; }
	}
}
