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
	[Register("NSKeyedArchiver", true)]
	public unsafe partial class NSKeyedArchiver : NSCoder {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selArchiveRootObject_ToFile_X = "archiveRootObject:toFile:";
		static readonly NativeHandle selArchiveRootObject_ToFile_XHandle = Selector.GetHandle ("archiveRootObject:toFile:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selArchivedDataWithRootObject_X = "archivedDataWithRootObject:";
		static readonly NativeHandle selArchivedDataWithRootObject_XHandle = Selector.GetHandle ("archivedDataWithRootObject:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selArchivedDataWithRootObject_RequiringSecureCoding_Error_X = "archivedDataWithRootObject:requiringSecureCoding:error:";
		static readonly NativeHandle selArchivedDataWithRootObject_RequiringSecureCoding_Error_XHandle = Selector.GetHandle ("archivedDataWithRootObject:requiringSecureCoding:error:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selClassNameForClass_X = "classNameForClass:";
		static readonly NativeHandle selClassNameForClass_XHandle = Selector.GetHandle ("classNameForClass:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selDelegateX = "delegate";
		static readonly NativeHandle selDelegateXHandle = Selector.GetHandle ("delegate");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selEncodedDataX = "encodedData";
		static readonly NativeHandle selEncodedDataXHandle = Selector.GetHandle ("encodedData");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selFinishEncodingX = "finishEncoding";
		static readonly NativeHandle selFinishEncodingXHandle = Selector.GetHandle ("finishEncoding");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selInitX = "init";
		static readonly NativeHandle selInitXHandle = Selector.GetHandle ("init");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selInitForWritingWithMutableData_X = "initForWritingWithMutableData:";
		static readonly NativeHandle selInitForWritingWithMutableData_XHandle = Selector.GetHandle ("initForWritingWithMutableData:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selInitRequiringSecureCoding_X = "initRequiringSecureCoding:";
		static readonly NativeHandle selInitRequiringSecureCoding_XHandle = Selector.GetHandle ("initRequiringSecureCoding:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selOutputFormatX = "outputFormat";
		static readonly NativeHandle selOutputFormatXHandle = Selector.GetHandle ("outputFormat");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selRequiresSecureCodingX = "requiresSecureCoding";
		static readonly NativeHandle selRequiresSecureCodingXHandle = Selector.GetHandle ("requiresSecureCoding");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetClassName_ForClass_X = "setClassName:forClass:";
		static readonly NativeHandle selSetClassName_ForClass_XHandle = Selector.GetHandle ("setClassName:forClass:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetDelegate_X = "setDelegate:";
		static readonly NativeHandle selSetDelegate_XHandle = Selector.GetHandle ("setDelegate:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetOutputFormat_X = "setOutputFormat:";
		static readonly NativeHandle selSetOutputFormat_XHandle = Selector.GetHandle ("setOutputFormat:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetRequiresSecureCoding_X = "setRequiresSecureCoding:";
		static readonly NativeHandle selSetRequiresSecureCoding_XHandle = Selector.GetHandle ("setRequiresSecureCoding:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly NativeHandle class_ptr = Class.GetHandle ("NSKeyedArchiver");
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
		protected NSKeyedArchiver (NSObjectFlag t) : base (t)
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
		protected internal NSKeyedArchiver (NativeHandle handle) : base (handle)
		{
		}

		[Export ("initRequiringSecureCoding:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public NSKeyedArchiver (bool requiresSecureCoding)
			: base (NSObjectFlag.Empty)
		{
			if (IsDirectBinding) {
				InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_bool (this.Handle, selInitRequiringSecureCoding_XHandle, requiresSecureCoding ? (byte) 1 : (byte) 0), "initRequiringSecureCoding:");
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_bool (&__objc_super__, selInitRequiringSecureCoding_XHandle, requiresSecureCoding ? (byte) 1 : (byte) 0), "initRequiringSecureCoding:");
					GC.KeepAlive (this);
				}
			}
		}
		[Export ("init")]
		[ObsoletedOSPlatform ("tvos12.0", "Use 'NSKeyedArchiver (bool)' instead.")]
		[ObsoletedOSPlatform ("ios12.0", "Use 'NSKeyedArchiver (bool)' instead.")]
		[ObsoletedOSPlatform ("macos10.14", "Use 'NSKeyedArchiver (bool)' instead.")]
		[SupportedOSPlatform ("maccatalyst")]
		[ObsoletedOSPlatform ("maccatalyst13.1", "Use 'NSKeyedArchiver (bool)' instead.")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public NSKeyedArchiver ()
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
		[Export ("initForWritingWithMutableData:")]
		[ObsoletedOSPlatform ("tvos12.0", "Use 'NSKeyedArchiver (bool)' instead.")]
		[ObsoletedOSPlatform ("ios12.0", "Use 'NSKeyedArchiver (bool)' instead.")]
		[ObsoletedOSPlatform ("macos10.14", "Use 'NSKeyedArchiver (bool)' instead.")]
		[ObsoletedOSPlatform ("maccatalyst13.1", "Use 'NSKeyedArchiver (bool)' instead.")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public NSKeyedArchiver (NSMutableData data)
			: base (NSObjectFlag.Empty)
		{
			var data__handle__ = data!.GetNonNullHandle (nameof (data));
			if (IsDirectBinding) {
				InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, selInitForWritingWithMutableData_XHandle, data__handle__), "initForWritingWithMutableData:");
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle (&__objc_super__, selInitForWritingWithMutableData_XHandle, data__handle__), "initForWritingWithMutableData:");
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (data);
		}
		[Export ("archiveRootObject:toFile:")]
		[ObsoletedOSPlatform ("tvos12.0", "Use 'GetArchivedData (NSObject, bool, out NSError)' and then 'NSData.Save' instead.")]
		[ObsoletedOSPlatform ("ios12.0", "Use 'GetArchivedData (NSObject, bool, out NSError)' and then 'NSData.Save' instead.")]
		[ObsoletedOSPlatform ("macos10.14", "Use 'GetArchivedData (NSObject, bool, out NSError)' and then 'NSData.Save' instead.")]
		[ObsoletedOSPlatform ("maccatalyst13.1", "Use 'GetArchivedData (NSObject, bool, out NSError)' and then 'NSData.Save' instead.")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool ArchiveRootObjectToFile (NSObject root, string file)
		{
			var root__handle__ = root!.GetNonNullHandle (nameof (root));
			if (file is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (file));
			var nsfile = CFString.CreateNative (file);
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_NativeHandle (class_ptr, selArchiveRootObject_ToFile_XHandle, root__handle__, nsfile);
			GC.KeepAlive (root);
			CFString.ReleaseNative (nsfile);
			return ret != 0;
		}
		[Export ("finishEncoding")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void FinishEncoding ()
		{
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, selFinishEncodingXHandle);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper (&__objc_super__, selFinishEncodingXHandle);
					GC.KeepAlive (this);
				}
			}
		}
		[Export ("archivedDataWithRootObject:requiringSecureCoding:error:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static NSData? GetArchivedData (NSObject @object, bool requiresSecureCoding, out NSError? error)
		{
			var @object__handle__ = @object!.GetNonNullHandle (nameof (@object));
			NativeHandle errorValue = IntPtr.Zero;
			NSData? ret;
			ret =  Runtime.GetNSObject<NSData> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_bool_ref_NativeHandle (class_ptr, selArchivedDataWithRootObject_RequiringSecureCoding_Error_XHandle, @object__handle__, requiresSecureCoding ? (byte) 1 : (byte) 0, &errorValue), false)!;
			GC.KeepAlive (@object);
			error = Runtime.GetNSObject<NSError> (errorValue)!;
			return ret!;
		}
		[Export ("archivedDataWithRootObject:")]
		[ObsoletedOSPlatform ("tvos12.0", "Use 'GetArchivedData (NSObject, bool, out NSError)' instead.")]
		[ObsoletedOSPlatform ("ios12.0", "Use 'GetArchivedData (NSObject, bool, out NSError)' instead.")]
		[ObsoletedOSPlatform ("macos10.14", "Use 'GetArchivedData (NSObject, bool, out NSError)' instead.")]
		[ObsoletedOSPlatform ("maccatalyst13.1", "Use 'GetArchivedData (NSObject, bool, out NSError)' instead.")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSData GetArchivedData (NSObject root)
		{
			var root__handle__ = root!.GetNonNullHandle (nameof (root));
			NSData? ret;
			ret =  Runtime.GetNSObject<NSData> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (class_ptr, selArchivedDataWithRootObject_XHandle, root__handle__), false)!;
			GC.KeepAlive (root);
			return ret!;
		}
		[Export ("classNameForClass:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string GetClassName (Class kls)
		{
			var kls__handle__ = kls!.GetNonNullHandle (nameof (kls));
			string? ret;
			if (IsDirectBinding) {
				ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, selClassNameForClass_XHandle, kls.Handle), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle (&__objc_super__, selClassNameForClass_XHandle, kls.Handle), false)!;
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (kls);
			return ret!;
		}
		[Export ("setClassName:forClass:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetClassName (string name, Class kls)
		{
			if (name is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (name));
			var kls__handle__ = kls!.GetNonNullHandle (nameof (kls));
			var nsname = CFString.CreateNative (name);
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (this.Handle, selSetClassName_ForClass_XHandle, nsname, kls.Handle);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, selSetClassName_ForClass_XHandle, nsname, kls.Handle);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (kls);
			CFString.ReleaseNative (nsname);
		}
		/// <summary>An instance of the Foundation.INSKeyedArchiverDelegate model class which acts as the class delegate.</summary><value>The instance of the Foundation.INSKeyedArchiverDelegate model class</value><remarks><para>The delegate instance assigned to this object will be used to handle events or provide data on demand to this class.</para><para>When setting the Delegate or WeakDelegate values events will be delivered to the specified instance instead of being delivered to the C#-style events</para><para>This is the strongly typed version of the object, developers should use the WeakDelegate property instead if they want to merely assign a class derived from NSObject that has been decorated with [Export] attributes.</para></remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public INSKeyedArchiverDelegate Delegate {
			get {
				return (WeakDelegate as INSKeyedArchiverDelegate)!;
			}
			set {
				var rvalue = value as NSObject;
				if (!(value is null) && rvalue is null)
					throw new ArgumentException ("The object passed of type " + value.GetType () + " does not derive from NSObject");
				WeakDelegate = rvalue;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public virtual NSData EncodedData {
			[Export ("encodedData", ArgumentSemantic.Retain)]
			get {
				NSData? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSData> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selEncodedDataXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<NSData> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selEncodedDataXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSPropertyListFormat PropertyListFormat {
			[Export ("outputFormat")]
			get {
				NSPropertyListFormat ret;
				if (IsDirectBinding) {
					ret = (NSPropertyListFormat) (ulong) global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend (this.Handle, selOutputFormatXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = (NSPropertyListFormat) (ulong) global::ObjCRuntime.Messaging.UIntPtr_objc_msgSendSuper (&__objc_super__, selOutputFormatXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setOutputFormat:")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_UIntPtr (this.Handle, selSetOutputFormat_XHandle, (UIntPtr) (ulong) value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_UIntPtr (&__objc_super__, selSetOutputFormat_XHandle, (UIntPtr) (ulong) value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool RequiresSecureCoding {
			[Export ("requiresSecureCoding")]
			get {
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selRequiresSecureCodingXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, selRequiresSecureCodingXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
			[Export ("setRequiresSecureCoding:")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, selSetRequiresSecureCoding_XHandle, value ? (byte) 1 : (byte) 0);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (&__objc_super__, selSetRequiresSecureCoding_XHandle, value ? (byte) 1 : (byte) 0);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		object? __mt_WeakDelegate_var;
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
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _RootObjectKey;
		/// <summary>Represents the value associated with the constant NSKeyedArchiveRootObjectKey</summary><value></value><remarks>To be added.</remarks>
		[Field ("NSKeyedArchiveRootObjectKey",  "Foundation")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static NSString RootObjectKey {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_RootObjectKey is null)
					_RootObjectKey = Dlfcn.GetStringConstant (Libraries.Foundation.Handle, "NSKeyedArchiveRootObjectKey")!;
				return _RootObjectKey;
			}
		}
		//
		// Events and properties from the delegate
		//
		internal virtual Type GetInternalEventDelegateType
		{
			get { return typeof (_NSKeyedArchiverDelegate); }
		}
		internal virtual _NSKeyedArchiverDelegate CreateInternalEventDelegateType ()
		{
			return (_NSKeyedArchiverDelegate)(new _NSKeyedArchiverDelegate());
		}
		internal _NSKeyedArchiverDelegate EnsureNSKeyedArchiverDelegate ()
		{
			if (WeakDelegate is not null)
				NSApplication.EnsureEventAndDelegateAreNotMismatched (WeakDelegate, GetInternalEventDelegateType);
			var del = Delegate as _NSKeyedArchiverDelegate;
			if (del is null){
				del = (_NSKeyedArchiverDelegate)CreateInternalEventDelegateType ();
				Delegate = (INSKeyedArchiverDelegate)del;
			}
			return del;
		}
		#pragma warning disable 672
		[Register]
		internal class _NSKeyedArchiverDelegate : NSObject, INSKeyedArchiverDelegate { 
			public _NSKeyedArchiverDelegate () { IsDirectBinding = false; }
			[DynamicDependency (DynamicallyAccessedMemberTypes.PublicMethods, typeof (_NSKeyedArchiverDelegate))]
			static _NSKeyedArchiverDelegate ()
			{
				GC.KeepAlive (null);
			}
			internal EventHandler<NSObjectEventArgs>? encodedObject;
			[Export ("archiver:didEncodeObject:")]
			public void EncodedObject (NSKeyedArchiver archiver, NSObject obj)
			{
				var handler = encodedObject;
				if (handler is not null){
					var args = new NSObjectEventArgs (obj);
					handler (archiver, args);
				}
			}
			internal EventHandler? finished;
			[Export ("archiverDidFinish:")]
			public void Finished (NSKeyedArchiver archiver)
			{
				var handler = finished;
				if (handler is not null){
					handler (archiver, EventArgs.Empty);
				}
			}
			internal EventHandler? finishing;
			[Export ("archiverWillFinish:")]
			public void Finishing (NSKeyedArchiver archiver)
			{
				var handler = finishing;
				if (handler is not null){
					handler (archiver, EventArgs.Empty);
				}
			}
			internal EventHandler<NSArchiveReplaceEventArgs>? replacingObject;
			[Export ("archiver:willReplaceObject:withObject:")]
			public void ReplacingObject (NSKeyedArchiver archiver, NSObject oldObject, NSObject newObject)
			{
				var handler = replacingObject;
				if (handler is not null){
					var args = new NSArchiveReplaceEventArgs (oldObject, newObject);
					handler (archiver, args);
				}
			}
			internal NSEncodeHook? willEncode;
			[Export ("archiver:willEncodeObject:")]
			public NSObject WillEncode (NSKeyedArchiver archiver, NSObject obj)
			{
				var handler = willEncode;
				if (handler is not null)
					return handler (archiver, obj);
				return null!;
			}
		}
		#pragma warning restore 672
		/// <summary>Event raised by the object.</summary>
		/// <remarks>If developers do not assign a value to this event, this will reset the value for the WeakDelegate property to an internal handler that maps delegates to events.</remarks>
		public event EventHandler<NSObjectEventArgs> EncodedObject {
			add { EnsureNSKeyedArchiverDelegate ()!.encodedObject += value; }
			remove { EnsureNSKeyedArchiverDelegate ()!.encodedObject -= value; }
		}
		/// <summary>Event raised by the object.</summary>
		/// <remarks>If developers do not assign a value to this event, this will reset the value for the WeakDelegate property to an internal handler that maps delegates to events.</remarks>
		public event EventHandler Finished {
			add { EnsureNSKeyedArchiverDelegate ()!.finished += value; }
			remove { EnsureNSKeyedArchiverDelegate ()!.finished -= value; }
		}
		/// <summary>Event raised by the object.</summary>
		/// <remarks>If developers do not assign a value to this event, this will reset the value for the WeakDelegate property to an internal handler that maps delegates to events.</remarks>
		public event EventHandler Finishing {
			add { EnsureNSKeyedArchiverDelegate ()!.finishing += value; }
			remove { EnsureNSKeyedArchiverDelegate ()!.finishing -= value; }
		}
		/// <summary>Event raised by the object.</summary>
		/// <remarks>If developers do not assign a value to this event, this will reset the value for the WeakDelegate property to an internal handler that maps delegates to events.</remarks>
		public event EventHandler<NSArchiveReplaceEventArgs> ReplacingObject {
			add { EnsureNSKeyedArchiverDelegate ()!.replacingObject += value; }
			remove { EnsureNSKeyedArchiverDelegate ()!.replacingObject -= value; }
		}
		/// <summary>Delegate invoked by the object to get a value.</summary>
		/// <value>To be added.</value>
		/// <remarks>Developers assign a function, delegate or anonymous method to this property to return a value to the object.   If developers assign a value to this property, it this will reset the value for the WeakDelegate property to an internal handler that maps delegates to events.</remarks>
		public NSEncodeHook? WillEncode {
			get { return EnsureNSKeyedArchiverDelegate ()!.willEncode; }
			set { EnsureNSKeyedArchiverDelegate ()!.willEncode = value; }
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		protected override void Dispose (bool disposing)
		{
			base.Dispose (disposing);
			if (Handle == IntPtr.Zero) {
				__mt_WeakDelegate_var = null;
			}
		}
	} /* class NSKeyedArchiver */
	//
	// EventArgs classes
	//
	/// <summary>Provides data for an event based on an Objective-C protocol method.</summary>
	public partial class NSArchiveReplaceEventArgs : EventArgs {
		/// <summary>Create a new instance of the <see cref="NSArchiveReplaceEventArgs" /> with the specified event data.</summary>
		/// <param name="oldObject">The value for the <see cref="OldObject" /> property.</param>
		/// <param name="newObject">The value for the <see cref="NewObject" /> property.</param>
		public NSArchiveReplaceEventArgs (NSObject oldObject, NSObject newObject)
		{
			this.NewObject = newObject;
			this.OldObject = oldObject;
		}
		public NSObject NewObject { get; set; }
		public NSObject OldObject { get; set; }
	}
}
