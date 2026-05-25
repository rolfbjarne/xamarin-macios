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
namespace ImageKit {
	[Register("IKScannerDeviceView", true)]
	public unsafe partial class IKScannerDeviceView : global::AppKit.NSView {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selDelegateX = "delegate";
		static readonly NativeHandle selDelegateXHandle = Selector.GetHandle ("delegate");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selDisplaysDownloadsDirectoryControlX = "displaysDownloadsDirectoryControl";
		static readonly NativeHandle selDisplaysDownloadsDirectoryControlXHandle = Selector.GetHandle ("displaysDownloadsDirectoryControl");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selDisplaysPostProcessApplicationControlX = "displaysPostProcessApplicationControl";
		static readonly NativeHandle selDisplaysPostProcessApplicationControlXHandle = Selector.GetHandle ("displaysPostProcessApplicationControl");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selDocumentNameX = "documentName";
		static readonly NativeHandle selDocumentNameXHandle = Selector.GetHandle ("documentName");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selDownloadsDirectoryX = "downloadsDirectory";
		static readonly NativeHandle selDownloadsDirectoryXHandle = Selector.GetHandle ("downloadsDirectory");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selHasDisplayModeAdvancedX = "hasDisplayModeAdvanced";
		static readonly NativeHandle selHasDisplayModeAdvancedXHandle = Selector.GetHandle ("hasDisplayModeAdvanced");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selHasDisplayModeSimpleX = "hasDisplayModeSimple";
		static readonly NativeHandle selHasDisplayModeSimpleXHandle = Selector.GetHandle ("hasDisplayModeSimple");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selInitWithFrame_X = "initWithFrame:";
		static readonly NativeHandle selInitWithFrame_XHandle = Selector.GetHandle ("initWithFrame:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selModeX = "mode";
		static readonly NativeHandle selModeXHandle = Selector.GetHandle ("mode");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selOverviewControlLabelX = "overviewControlLabel";
		static readonly NativeHandle selOverviewControlLabelXHandle = Selector.GetHandle ("overviewControlLabel");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selPostProcessApplicationX = "postProcessApplication";
		static readonly NativeHandle selPostProcessApplicationXHandle = Selector.GetHandle ("postProcessApplication");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selScanControlLabelX = "scanControlLabel";
		static readonly NativeHandle selScanControlLabelXHandle = Selector.GetHandle ("scanControlLabel");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selScannerDeviceX = "scannerDevice";
		static readonly NativeHandle selScannerDeviceXHandle = Selector.GetHandle ("scannerDevice");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetDelegate_X = "setDelegate:";
		static readonly NativeHandle selSetDelegate_XHandle = Selector.GetHandle ("setDelegate:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetDisplaysDownloadsDirectoryControl_X = "setDisplaysDownloadsDirectoryControl:";
		static readonly NativeHandle selSetDisplaysDownloadsDirectoryControl_XHandle = Selector.GetHandle ("setDisplaysDownloadsDirectoryControl:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetDisplaysPostProcessApplicationControl_X = "setDisplaysPostProcessApplicationControl:";
		static readonly NativeHandle selSetDisplaysPostProcessApplicationControl_XHandle = Selector.GetHandle ("setDisplaysPostProcessApplicationControl:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetDocumentName_X = "setDocumentName:";
		static readonly NativeHandle selSetDocumentName_XHandle = Selector.GetHandle ("setDocumentName:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetDownloadsDirectory_X = "setDownloadsDirectory:";
		static readonly NativeHandle selSetDownloadsDirectory_XHandle = Selector.GetHandle ("setDownloadsDirectory:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetHasDisplayModeAdvanced_X = "setHasDisplayModeAdvanced:";
		static readonly NativeHandle selSetHasDisplayModeAdvanced_XHandle = Selector.GetHandle ("setHasDisplayModeAdvanced:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetHasDisplayModeSimple_X = "setHasDisplayModeSimple:";
		static readonly NativeHandle selSetHasDisplayModeSimple_XHandle = Selector.GetHandle ("setHasDisplayModeSimple:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetMode_X = "setMode:";
		static readonly NativeHandle selSetMode_XHandle = Selector.GetHandle ("setMode:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetOverviewControlLabel_X = "setOverviewControlLabel:";
		static readonly NativeHandle selSetOverviewControlLabel_XHandle = Selector.GetHandle ("setOverviewControlLabel:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetPostProcessApplication_X = "setPostProcessApplication:";
		static readonly NativeHandle selSetPostProcessApplication_XHandle = Selector.GetHandle ("setPostProcessApplication:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetScanControlLabel_X = "setScanControlLabel:";
		static readonly NativeHandle selSetScanControlLabel_XHandle = Selector.GetHandle ("setScanControlLabel:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetScannerDevice_X = "setScannerDevice:";
		static readonly NativeHandle selSetScannerDevice_XHandle = Selector.GetHandle ("setScannerDevice:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetTransferMode_X = "setTransferMode:";
		static readonly NativeHandle selSetTransferMode_XHandle = Selector.GetHandle ("setTransferMode:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selTransferModeX = "transferMode";
		static readonly NativeHandle selTransferModeXHandle = Selector.GetHandle ("transferMode");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly NativeHandle class_ptr = Class.GetHandle ("IKScannerDeviceView");
		/// <summary>The Objective-C class handle for this class.</summary>
		/// <value>The pointer to the Objective-C class.</value>
		/// <remarks>
		///     Each managed class mirrors an unmanaged Objective-C class.
		///     This value contains the pointer to the Objective-C class.
		///     It is similar to calling the managed <see cref="ObjCRuntime.Class.GetHandle(string)" /> or the native <see href="https://developer.apple.com/documentation/objectivec/1418952-objc_getclass">objc_getClass</see> method with the type name.
		/// </remarks>
		public override NativeHandle ClassHandle { get { return class_ptr; } }
		/// <summary>Creates a new <see cref="IKScannerDeviceView" /> with default values.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public IKScannerDeviceView () : base (NSObjectFlag.Empty)
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

		/// <summary>A constructor that initializes the object from the data stored in the unarchiver object.</summary>
		/// <param name="coder">The unarchiver object.</param>
		/// <remarks>
		///   <para>This constructor is provided to allow the class to be initialized from an unarchiver (for example, during NIB deserialization). This is part of the <see cref="Foundation.NSCoding" /> protocol.</para>
		///   <para>If developers want to create a subclass of this object and continue to support deserialization from an archive, they should implement a constructor with an identical signature: taking a single parameter of type <see cref="Foundation.NSCoder" /> and decorate it with the <c>[Export("initWithCoder:"]</c> attribute.</para>
		///   <para>The state of this object can also be serialized by using the <see cref="Foundation.INSCoding.EncodeTo" /> companion method.</para>
		/// </remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[DesignatedInitializer]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("initWithCoder:")]
		public IKScannerDeviceView (NSCoder coder) : base (NSObjectFlag.Empty)
		{
			if (IsDirectBinding) {
				InitializeHandle (global::ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr (this.Handle, Selector.InitWithCoder, coder.Handle), "initWithCoder:");
			} else {
				unsafe {
				var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
				InitializeHandle (global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper_IntPtr (&__objc_super__, Selector.InitWithCoder, coder.Handle), "initWithCoder:");
				GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (coder);
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
		protected IKScannerDeviceView (NSObjectFlag t) : base (t)
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
		protected internal IKScannerDeviceView (NativeHandle handle) : base (handle)
		{
		}

		/// <param name="frameRect">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("initWithFrame:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public IKScannerDeviceView (CGRect frameRect)
			: base (NSObjectFlag.Empty)
		{
			if (IsDirectBinding) {
				InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_CGRect (this.Handle, selInitWithFrame_XHandle, frameRect), "initWithFrame:");
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_CGRect (&__objc_super__, selInitWithFrame_XHandle, frameRect), "initWithFrame:");
					GC.KeepAlive (this);
				}
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public IIKScannerDeviceViewDelegate Delegate {
			get {
				return (WeakDelegate as IIKScannerDeviceViewDelegate)!;
			}
			set {
				var rvalue = value as NSObject;
				if (!(value is null) && rvalue is null)
					throw new ArgumentException ("The object passed of type " + value.GetType () + " does not derive from NSObject");
				WeakDelegate = rvalue;
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual IKScannerDeviceViewDisplayMode DisplayMode {
			[Export ("mode")]
			get {
				IKScannerDeviceViewDisplayMode ret;
				if (IsDirectBinding) {
					ret = (ImageKit.IKScannerDeviceViewDisplayMode) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selModeXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = (ImageKit.IKScannerDeviceViewDisplayMode) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (&__objc_super__, selModeXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setMode:")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetMode_XHandle, (IntPtr) (long) value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (&__objc_super__, selSetMode_XHandle, (IntPtr) (long) value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool DisplaysDownloadsDirectoryControl {
			[Export ("displaysDownloadsDirectoryControl")]
			get {
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selDisplaysDownloadsDirectoryControlXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, selDisplaysDownloadsDirectoryControlXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
			[Export ("setDisplaysDownloadsDirectoryControl:")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, selSetDisplaysDownloadsDirectoryControl_XHandle, value ? (byte) 1 : (byte) 0);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (&__objc_super__, selSetDisplaysDownloadsDirectoryControl_XHandle, value ? (byte) 1 : (byte) 0);
						GC.KeepAlive (this);
					}
				}
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool DisplaysPostProcessApplicationControl {
			[Export ("displaysPostProcessApplicationControl")]
			get {
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selDisplaysPostProcessApplicationControlXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, selDisplaysPostProcessApplicationControlXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
			[Export ("setDisplaysPostProcessApplicationControl:")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, selSetDisplaysPostProcessApplicationControl_XHandle, value ? (byte) 1 : (byte) 0);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (&__objc_super__, selSetDisplaysPostProcessApplicationControl_XHandle, value ? (byte) 1 : (byte) 0);
						GC.KeepAlive (this);
					}
				}
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string DocumentName {
			[Export ("documentName", ArgumentSemantic.Copy)]
			get {
				string ret;
				if (IsDirectBinding) {
					ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selDocumentNameXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selDocumentNameXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[Export ("setDocumentName:", ArgumentSemantic.Copy)]
			set {
				if (value is null)
					ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (value));
				var nsvalue = CFString.CreateNative (value);
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selSetDocumentName_XHandle, nsvalue);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selSetDocumentName_XHandle, nsvalue);
						GC.KeepAlive (this);
					}
				}
				CFString.ReleaseNative (nsvalue);
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSUrl DownloadsDirectory {
			[Export ("downloadsDirectory", ArgumentSemantic.Retain)]
			get {
				NSUrl? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSUrl> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selDownloadsDirectoryXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<NSUrl> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selDownloadsDirectoryXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setDownloadsDirectory:", ArgumentSemantic.Retain)]
			set {
				var value__handle__ = value!.GetNonNullHandle (nameof (value));
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selSetDownloadsDirectory_XHandle, value__handle__);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selSetDownloadsDirectory_XHandle, value__handle__);
						GC.KeepAlive (this);
					}
				}
				GC.KeepAlive (value);
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool HasDisplayModeAdvanced {
			[Export ("hasDisplayModeAdvanced")]
			get {
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selHasDisplayModeAdvancedXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, selHasDisplayModeAdvancedXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
			[Export ("setHasDisplayModeAdvanced:")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, selSetHasDisplayModeAdvanced_XHandle, value ? (byte) 1 : (byte) 0);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (&__objc_super__, selSetHasDisplayModeAdvanced_XHandle, value ? (byte) 1 : (byte) 0);
						GC.KeepAlive (this);
					}
				}
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool HasDisplayModeSimple {
			[Export ("hasDisplayModeSimple")]
			get {
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selHasDisplayModeSimpleXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, selHasDisplayModeSimpleXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
			[Export ("setHasDisplayModeSimple:")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, selSetHasDisplayModeSimple_XHandle, value ? (byte) 1 : (byte) 0);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (&__objc_super__, selSetHasDisplayModeSimple_XHandle, value ? (byte) 1 : (byte) 0);
						GC.KeepAlive (this);
					}
				}
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string OverviewControlLabel {
			[Export ("overviewControlLabel", ArgumentSemantic.Copy)]
			get {
				string ret;
				if (IsDirectBinding) {
					ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selOverviewControlLabelXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selOverviewControlLabelXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[Export ("setOverviewControlLabel:", ArgumentSemantic.Copy)]
			set {
				if (value is null)
					ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (value));
				var nsvalue = CFString.CreateNative (value);
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selSetOverviewControlLabel_XHandle, nsvalue);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selSetOverviewControlLabel_XHandle, nsvalue);
						GC.KeepAlive (this);
					}
				}
				CFString.ReleaseNative (nsvalue);
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSUrl PostProcessApplication {
			[Export ("postProcessApplication", ArgumentSemantic.Retain)]
			get {
				NSUrl? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSUrl> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selPostProcessApplicationXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<NSUrl> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selPostProcessApplicationXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setPostProcessApplication:", ArgumentSemantic.Retain)]
			set {
				var value__handle__ = value!.GetNonNullHandle (nameof (value));
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selSetPostProcessApplication_XHandle, value__handle__);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selSetPostProcessApplication_XHandle, value__handle__);
						GC.KeepAlive (this);
					}
				}
				GC.KeepAlive (value);
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string ScanControlLabel {
			[Export ("scanControlLabel", ArgumentSemantic.Copy)]
			get {
				string ret;
				if (IsDirectBinding) {
					ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selScanControlLabelXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selScanControlLabelXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[Export ("setScanControlLabel:", ArgumentSemantic.Copy)]
			set {
				if (value is null)
					ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (value));
				var nsvalue = CFString.CreateNative (value);
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selSetScanControlLabel_XHandle, nsvalue);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selSetScanControlLabel_XHandle, nsvalue);
						GC.KeepAlive (this);
					}
				}
				CFString.ReleaseNative (nsvalue);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		object? __mt_ScannerDevice_var;
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual global::ImageCaptureCore.ICScannerDevice ScannerDevice {
			[Export ("scannerDevice", ArgumentSemantic.Assign)]
			get {
				global::ImageCaptureCore.ICScannerDevice? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<global::ImageCaptureCore.ICScannerDevice> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selScannerDeviceXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<global::ImageCaptureCore.ICScannerDevice> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selScannerDeviceXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				MarkDirty ();
				__mt_ScannerDevice_var = ret;
				return ret!;
			}
			[Export ("setScannerDevice:", ArgumentSemantic.Assign)]
			set {
				var value__handle__ = value!.GetNonNullHandle (nameof (value));
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selSetScannerDevice_XHandle, value__handle__);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selSetScannerDevice_XHandle, value__handle__);
						GC.KeepAlive (this);
					}
				}
				GC.KeepAlive (value);
				MarkDirty ();
				__mt_ScannerDevice_var = value;
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual IKScannerDeviceViewTransferMode TransferMode {
			[Export ("transferMode")]
			get {
				IKScannerDeviceViewTransferMode ret;
				if (IsDirectBinding) {
					ret = (ImageKit.IKScannerDeviceViewTransferMode) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selTransferModeXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = (ImageKit.IKScannerDeviceViewTransferMode) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (&__objc_super__, selTransferModeXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setTransferMode:")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetTransferMode_XHandle, (IntPtr) (long) value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (&__objc_super__, selSetTransferMode_XHandle, (IntPtr) (long) value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		object? __mt_WeakDelegate_var;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSObject? WeakDelegate {
			[Export ("delegate", ArgumentSemantic.Assign)]
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
			[Export ("setDelegate:", ArgumentSemantic.Assign)]
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
		//
		// Events and properties from the delegate
		//
		internal virtual Type GetInternalEventDelegateType
		{
			get { return typeof (_IKScannerDeviceViewDelegate); }
		}
		internal virtual _IKScannerDeviceViewDelegate CreateInternalEventDelegateType ()
		{
			return (_IKScannerDeviceViewDelegate)(new _IKScannerDeviceViewDelegate());
		}
		internal _IKScannerDeviceViewDelegate EnsureIKScannerDeviceViewDelegate ()
		{
			if (WeakDelegate is not null)
				NSApplication.EnsureEventAndDelegateAreNotMismatched (WeakDelegate, GetInternalEventDelegateType);
			var del = Delegate as _IKScannerDeviceViewDelegate;
			if (del is null){
				del = (_IKScannerDeviceViewDelegate)CreateInternalEventDelegateType ();
				Delegate = (IIKScannerDeviceViewDelegate)del;
			}
			return del;
		}
		#pragma warning disable 672
		[Register]
		internal class _IKScannerDeviceViewDelegate : NSObject, IIKScannerDeviceViewDelegate { 
			public _IKScannerDeviceViewDelegate () { IsDirectBinding = false; }
			[DynamicDependency (DynamicallyAccessedMemberTypes.PublicMethods, typeof (_IKScannerDeviceViewDelegate))]
			static _IKScannerDeviceViewDelegate ()
			{
				GC.KeepAlive (null);
			}
			internal EventHandler<IKScannerDeviceViewErrorEventArgs>? didEncounterError;
			[Export ("scannerDeviceView:didEncounterError:")]
			public void DidEncounterError (ImageKit.IKScannerDeviceView scannerDeviceView, NSError error)
			{
				var handler = didEncounterError;
				if (handler is not null){
					var args = new IKScannerDeviceViewErrorEventArgs (error);
					handler (scannerDeviceView, args);
				}
			}
			internal EventHandler<IKScannerDeviceViewScanEventArgs>? didScan;
			[Export ("scannerDeviceView:didScanToURL:fileData:error:")]
			public void DidScan (ImageKit.IKScannerDeviceView scannerDeviceView, NSUrl url, NSData data, NSError error)
			{
				var handler = didScan;
				if (handler is not null){
					var args = new IKScannerDeviceViewScanEventArgs (url, data, error);
					handler (scannerDeviceView, args);
				}
			}
			internal EventHandler<IKScannerDeviceViewScanBandDataEventArgs>? didScanToBandData;
			[Export ("scannerDeviceView:didScanToBandData:scanInfo:error:")]
			public void DidScanToBandData (ImageKit.IKScannerDeviceView scannerDeviceView, ImageCaptureCore.ICScannerBandData data, NSDictionary scanInfo, NSError error)
			{
				var handler = didScanToBandData;
				if (handler is not null){
					var args = new IKScannerDeviceViewScanBandDataEventArgs (data, scanInfo, error);
					handler (scannerDeviceView, args);
				}
			}
			internal EventHandler<IKScannerDeviceViewScanUrlEventArgs>? didScanToUrl;
			[Export ("scannerDeviceView:didScanToURL:error:")]
			public void DidScanToUrl (ImageKit.IKScannerDeviceView scannerDeviceView, NSUrl url, NSError error)
			{
				var handler = didScanToUrl;
				if (handler is not null){
					var args = new IKScannerDeviceViewScanUrlEventArgs (url, error);
					handler (scannerDeviceView, args);
				}
			}
		}
		#pragma warning restore 672
		/// <summary>To be added.</summary>
		/// <remarks>To be added.</remarks>
		public event EventHandler<IKScannerDeviceViewErrorEventArgs> DidEncounterError {
			add { EnsureIKScannerDeviceViewDelegate ()!.didEncounterError += value; }
			remove { EnsureIKScannerDeviceViewDelegate ()!.didEncounterError -= value; }
		}
		/// <summary>To be added.</summary>
		/// <remarks>To be added.</remarks>
		public event EventHandler<IKScannerDeviceViewScanEventArgs> DidScan {
			add { EnsureIKScannerDeviceViewDelegate ()!.didScan += value; }
			remove { EnsureIKScannerDeviceViewDelegate ()!.didScan -= value; }
		}
		public event EventHandler<IKScannerDeviceViewScanBandDataEventArgs> DidScanToBandData {
			add { EnsureIKScannerDeviceViewDelegate ()!.didScanToBandData += value; }
			remove { EnsureIKScannerDeviceViewDelegate ()!.didScanToBandData -= value; }
		}
		/// <summary>To be added.</summary>
		/// <remarks>To be added.</remarks>
		public event EventHandler<IKScannerDeviceViewScanUrlEventArgs> DidScanToUrl {
			add { EnsureIKScannerDeviceViewDelegate ()!.didScanToUrl += value; }
			remove { EnsureIKScannerDeviceViewDelegate ()!.didScanToUrl -= value; }
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		protected override void Dispose (bool disposing)
		{
			base.Dispose (disposing);
			if (Handle == IntPtr.Zero) {
				__mt_ScannerDevice_var = null;
				__mt_WeakDelegate_var = null;
			}
		}
	} /* class IKScannerDeviceView */
	//
	// EventArgs classes
	//
	/// <summary>Provides data for an event based on an Objective-C protocol method.</summary>
	public partial class IKScannerDeviceViewErrorEventArgs : EventArgs {
		/// <summary>Create a new instance of the <see cref="IKScannerDeviceViewErrorEventArgs" /> with the specified event data.</summary>
		/// <param name="error">The value for the <see cref="Error" /> property.</param>
		public IKScannerDeviceViewErrorEventArgs (NSError error)
		{
			this.Error = error;
		}
		public NSError Error { get; set; }
	}
	/// <summary>Provides data for an event based on an Objective-C protocol method.</summary>
	public partial class IKScannerDeviceViewScanBandDataEventArgs : EventArgs {
		/// <summary>Create a new instance of the <see cref="IKScannerDeviceViewScanBandDataEventArgs" /> with the specified event data.</summary>
		/// <param name="data">The value for the <see cref="Data" /> property.</param>
		/// <param name="scanInfo">The value for the <see cref="ScanInfo" /> property.</param>
		/// <param name="error">The value for the <see cref="Error" /> property.</param>
		public IKScannerDeviceViewScanBandDataEventArgs (ImageCaptureCore.ICScannerBandData data, NSDictionary scanInfo, NSError error)
		{
			this.Data = data;
			this.Error = error;
			this.ScanInfo = scanInfo;
		}
		public ImageCaptureCore.ICScannerBandData Data { get; set; }
		public NSError Error { get; set; }
		public NSDictionary ScanInfo { get; set; }
	}
	/// <summary>Provides data for an event based on an Objective-C protocol method.</summary>
	public partial class IKScannerDeviceViewScanEventArgs : EventArgs {
		/// <summary>Create a new instance of the <see cref="IKScannerDeviceViewScanEventArgs" /> with the specified event data.</summary>
		/// <param name="url">The value for the <see cref="Url" /> property.</param>
		/// <param name="data">The value for the <see cref="Data" /> property.</param>
		/// <param name="error">The value for the <see cref="Error" /> property.</param>
		public IKScannerDeviceViewScanEventArgs (NSUrl url, NSData data, NSError error)
		{
			this.Data = data;
			this.Error = error;
			this.Url = url;
		}
		public NSData Data { get; set; }
		public NSError Error { get; set; }
		public NSUrl Url { get; set; }
	}
	/// <summary>Provides data for an event based on an Objective-C protocol method.</summary>
	public partial class IKScannerDeviceViewScanUrlEventArgs : EventArgs {
		/// <summary>Create a new instance of the <see cref="IKScannerDeviceViewScanUrlEventArgs" /> with the specified event data.</summary>
		/// <param name="url">The value for the <see cref="Url" /> property.</param>
		/// <param name="error">The value for the <see cref="Error" /> property.</param>
		public IKScannerDeviceViewScanUrlEventArgs (NSUrl url, NSError error)
		{
			this.Error = error;
			this.Url = url;
		}
		public NSError Error { get; set; }
		public NSUrl Url { get; set; }
	}
}
