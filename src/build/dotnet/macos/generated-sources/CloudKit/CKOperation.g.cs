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
namespace CloudKit {
	[Register("CKOperation", true)]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("tvos")]
	public unsafe partial class CKOperation : NSOperation {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAllowsCellularAccessX = "allowsCellularAccess";
		static readonly NativeHandle selAllowsCellularAccessXHandle = Selector.GetHandle ("allowsCellularAccess");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selConfigurationX = "configuration";
		static readonly NativeHandle selConfigurationXHandle = Selector.GetHandle ("configuration");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selContainerX = "container";
		static readonly NativeHandle selContainerXHandle = Selector.GetHandle ("container");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selGroupX = "group";
		static readonly NativeHandle selGroupXHandle = Selector.GetHandle ("group");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selInitX = "init";
		static readonly NativeHandle selInitXHandle = Selector.GetHandle ("init");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selIsLongLivedX = "isLongLived";
		static readonly NativeHandle selIsLongLivedXHandle = Selector.GetHandle ("isLongLived");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selLongLivedOperationWasPersistedBlockX = "longLivedOperationWasPersistedBlock";
		static readonly NativeHandle selLongLivedOperationWasPersistedBlockXHandle = Selector.GetHandle ("longLivedOperationWasPersistedBlock");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selOperationIDX = "operationID";
		static readonly NativeHandle selOperationIDXHandle = Selector.GetHandle ("operationID");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetAllowsCellularAccess_X = "setAllowsCellularAccess:";
		static readonly NativeHandle selSetAllowsCellularAccess_XHandle = Selector.GetHandle ("setAllowsCellularAccess:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetConfiguration_X = "setConfiguration:";
		static readonly NativeHandle selSetConfiguration_XHandle = Selector.GetHandle ("setConfiguration:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetContainer_X = "setContainer:";
		static readonly NativeHandle selSetContainer_XHandle = Selector.GetHandle ("setContainer:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetGroup_X = "setGroup:";
		static readonly NativeHandle selSetGroup_XHandle = Selector.GetHandle ("setGroup:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetLongLived_X = "setLongLived:";
		static readonly NativeHandle selSetLongLived_XHandle = Selector.GetHandle ("setLongLived:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetLongLivedOperationWasPersistedBlock_X = "setLongLivedOperationWasPersistedBlock:";
		static readonly NativeHandle selSetLongLivedOperationWasPersistedBlock_XHandle = Selector.GetHandle ("setLongLivedOperationWasPersistedBlock:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetTimeoutIntervalForRequest_X = "setTimeoutIntervalForRequest:";
		static readonly NativeHandle selSetTimeoutIntervalForRequest_XHandle = Selector.GetHandle ("setTimeoutIntervalForRequest:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetTimeoutIntervalForResource_X = "setTimeoutIntervalForResource:";
		static readonly NativeHandle selSetTimeoutIntervalForResource_XHandle = Selector.GetHandle ("setTimeoutIntervalForResource:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selTimeoutIntervalForRequestX = "timeoutIntervalForRequest";
		static readonly NativeHandle selTimeoutIntervalForRequestXHandle = Selector.GetHandle ("timeoutIntervalForRequest");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selTimeoutIntervalForResourceX = "timeoutIntervalForResource";
		static readonly NativeHandle selTimeoutIntervalForResourceXHandle = Selector.GetHandle ("timeoutIntervalForResource");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly NativeHandle class_ptr = Class.GetHandle ("CKOperation");
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
		protected CKOperation (NSObjectFlag t) : base (t)
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
		protected internal CKOperation (NativeHandle handle) : base (handle)
		{
		}

		[Export ("init")]
		[DesignatedInitializer]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		protected CKOperation ()
			: base (NSObjectFlag.Empty)
		{
			if (IsDirectBinding) {
				InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selInitXHandle), "init");
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selInitXHandle), "init");
					GC.KeepAlive (this);
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[ObsoletedOSPlatform ("ios11.0", "Use 'CKOperationConfiguration' instead.")]
		[ObsoletedOSPlatform ("macos10.13", "Use 'CKOperationConfiguration' instead.")]
		[ObsoletedOSPlatform ("tvos11.0", "Use 'CKOperationConfiguration' instead.")]
		[ObsoletedOSPlatform ("maccatalyst13.1", "Use 'CKOperationConfiguration' instead.")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		public virtual bool AllowsCellularAccess {
			[Export ("allowsCellularAccess")]
			get {
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selAllowsCellularAccessXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, selAllowsCellularAccessXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
			[Export ("setAllowsCellularAccess:")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, selSetAllowsCellularAccess_XHandle, value ? (byte) 1 : (byte) 0);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (&__objc_super__, selSetAllowsCellularAccess_XHandle, value ? (byte) 1 : (byte) 0);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public virtual CKOperationConfiguration? Configuration {
			[Export ("configuration", ArgumentSemantic.Copy)]
			get {
				CKOperationConfiguration? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<CKOperationConfiguration> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selConfigurationXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<CKOperationConfiguration> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selConfigurationXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setConfiguration:", ArgumentSemantic.Copy)]
			set {
				var value__handle__ = value.GetHandle ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selSetConfiguration_XHandle, value__handle__);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selSetConfiguration_XHandle, value__handle__);
						GC.KeepAlive (this);
					}
				}
				GC.KeepAlive (value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[ObsoletedOSPlatform ("ios11.0", "Use 'CKOperationConfiguration' instead.")]
		[ObsoletedOSPlatform ("macos10.13", "Use 'CKOperationConfiguration' instead.")]
		[ObsoletedOSPlatform ("tvos11.0", "Use 'CKOperationConfiguration' instead.")]
		[ObsoletedOSPlatform ("maccatalyst13.1", "Use 'CKOperationConfiguration' instead.")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		public virtual CKContainer? Container {
			[Export ("container", ArgumentSemantic.Retain)]
			get {
				CKContainer? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<CKContainer> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selContainerXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<CKContainer> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selContainerXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setContainer:", ArgumentSemantic.Retain)]
			set {
				var value__handle__ = value.GetHandle ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selSetContainer_XHandle, value__handle__);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selSetContainer_XHandle, value__handle__);
						GC.KeepAlive (this);
					}
				}
				GC.KeepAlive (value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public virtual CKOperationGroup? Group {
			[Export ("group", ArgumentSemantic.Retain)]
			get {
				CKOperationGroup? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<CKOperationGroup> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selGroupXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<CKOperationGroup> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selGroupXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setGroup:", ArgumentSemantic.Retain)]
			set {
				var value__handle__ = value.GetHandle ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selSetGroup_XHandle, value__handle__);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selSetGroup_XHandle, value__handle__);
						GC.KeepAlive (this);
					}
				}
				GC.KeepAlive (value);
			}
		}
		/// <summary>Gets or sets a value that tells whether this operation is long-lived.</summary><value>A value that tells whether this operation is long-lived.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[ObsoletedOSPlatform ("ios11.0", "Use 'CKOperationConfiguration' instead.")]
		[ObsoletedOSPlatform ("macos10.13", "Use 'CKOperationConfiguration' instead.")]
		[ObsoletedOSPlatform ("tvos11.0", "Use 'CKOperationConfiguration' instead.")]
		[SupportedOSPlatform ("maccatalyst")]
		[ObsoletedOSPlatform ("maccatalyst13.1", "Use 'CKOperationConfiguration' instead.")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public virtual bool LongLived {
			[Export ("isLongLived")]
			get {
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selIsLongLivedXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, selIsLongLivedXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
			[Export ("setLongLived:")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, selSetLongLived_XHandle, value ? (byte) 1 : (byte) 0);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (&__objc_super__, selSetLongLived_XHandle, value ? (byte) 1 : (byte) 0);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public unsafe virtual global::System.Action? LongLivedOperationWasPersistedCallback {
			[return: DelegateProxy (typeof (ObjCRuntime.Trampolines.SDAction))]
			[Export ("longLivedOperationWasPersistedBlock", ArgumentSemantic.Retain)]
			get {
				NativeHandle ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selLongLivedOperationWasPersistedBlockXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selLongLivedOperationWasPersistedBlockXHandle);
						GC.KeepAlive (this);
					}
				}
				return global::ObjCRuntime.Trampolines.NIDAction.Create (ret)!;
			}
			[param: BlockProxy (typeof (ObjCRuntime.Trampolines.NIDAction))]
			[Export ("setLongLivedOperationWasPersistedBlock:", ArgumentSemantic.Retain)]
			set {
				using var block_value = Trampolines.SDAction.CreateNullableBlock (value);
				BlockLiteral *block_ptr_value = null;
				if (value is not null)
					block_ptr_value = &block_value;
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selSetLongLivedOperationWasPersistedBlock_XHandle, (IntPtr) block_ptr_value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selSetLongLivedOperationWasPersistedBlock_XHandle, (IntPtr) block_ptr_value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public virtual string OperationID {
			[Export ("operationID")]
			get {
				string ret;
				if (IsDirectBinding) {
					ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selOperationIDXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selOperationIDXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[ObsoletedOSPlatform ("ios11.0", "Use 'CKOperationConfiguration' instead.")]
		[ObsoletedOSPlatform ("macos10.13", "Use 'CKOperationConfiguration' instead.")]
		[ObsoletedOSPlatform ("tvos11.0", "Use 'CKOperationConfiguration' instead.")]
		[SupportedOSPlatform ("maccatalyst")]
		[ObsoletedOSPlatform ("maccatalyst13.1", "Use 'CKOperationConfiguration' instead.")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public virtual double TimeoutIntervalForRequest {
			[Export ("timeoutIntervalForRequest")]
			get {
				double ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.Double_objc_msgSend (this.Handle, selTimeoutIntervalForRequestXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.Double_objc_msgSendSuper (&__objc_super__, selTimeoutIntervalForRequestXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[Export ("setTimeoutIntervalForRequest:")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_Double (this.Handle, selSetTimeoutIntervalForRequest_XHandle, value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_Double (&__objc_super__, selSetTimeoutIntervalForRequest_XHandle, value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[ObsoletedOSPlatform ("ios11.0", "Use 'CKOperationConfiguration' instead.")]
		[ObsoletedOSPlatform ("macos10.13", "Use 'CKOperationConfiguration' instead.")]
		[ObsoletedOSPlatform ("tvos11.0", "Use 'CKOperationConfiguration' instead.")]
		[SupportedOSPlatform ("maccatalyst")]
		[ObsoletedOSPlatform ("maccatalyst13.1", "Use 'CKOperationConfiguration' instead.")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public virtual double TimeoutIntervalForResource {
			[Export ("timeoutIntervalForResource")]
			get {
				double ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.Double_objc_msgSend (this.Handle, selTimeoutIntervalForResourceXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.Double_objc_msgSendSuper (&__objc_super__, selTimeoutIntervalForResourceXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[Export ("setTimeoutIntervalForResource:")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_Double (this.Handle, selSetTimeoutIntervalForResource_XHandle, value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_Double (&__objc_super__, selSetTimeoutIntervalForResource_XHandle, value);
						GC.KeepAlive (this);
					}
				}
			}
		}
	} /* class CKOperation */
}
