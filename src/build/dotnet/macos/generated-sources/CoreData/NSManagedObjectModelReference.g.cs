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
namespace CoreData {
	[Register("NSManagedObjectModelReference", true)]
	[SupportedOSPlatform ("tvos17.0")]
	[SupportedOSPlatform ("macos14.0")]
	[SupportedOSPlatform ("ios17.0")]
	[SupportedOSPlatform ("maccatalyst17.0")]
	public unsafe partial class NSManagedObjectModelReference : NSObject {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selInitWithEntityVersionHashes_InBundle_VersionChecksum_X = "initWithEntityVersionHashes:inBundle:versionChecksum:";
		static readonly NativeHandle selInitWithEntityVersionHashes_InBundle_VersionChecksum_XHandle = Selector.GetHandle ("initWithEntityVersionHashes:inBundle:versionChecksum:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selInitWithFileURL_VersionChecksum_X = "initWithFileURL:versionChecksum:";
		static readonly NativeHandle selInitWithFileURL_VersionChecksum_XHandle = Selector.GetHandle ("initWithFileURL:versionChecksum:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selInitWithModel_VersionChecksum_X = "initWithModel:versionChecksum:";
		static readonly NativeHandle selInitWithModel_VersionChecksum_XHandle = Selector.GetHandle ("initWithModel:versionChecksum:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selInitWithName_InBundle_VersionChecksum_X = "initWithName:inBundle:versionChecksum:";
		static readonly NativeHandle selInitWithName_InBundle_VersionChecksum_XHandle = Selector.GetHandle ("initWithName:inBundle:versionChecksum:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selResolvedModelX = "resolvedModel";
		static readonly NativeHandle selResolvedModelXHandle = Selector.GetHandle ("resolvedModel");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selVersionChecksumX = "versionChecksum";
		static readonly NativeHandle selVersionChecksumXHandle = Selector.GetHandle ("versionChecksum");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly NativeHandle class_ptr = Class.GetHandle ("NSManagedObjectModelReference");
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
		protected NSManagedObjectModelReference (NSObjectFlag t) : base (t)
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
		protected internal NSManagedObjectModelReference (NativeHandle handle) : base (handle)
		{
		}

		[Export ("initWithModel:versionChecksum:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public NSManagedObjectModelReference (NSManagedObjectModel model, string versionChecksum)
			: base (NSObjectFlag.Empty)
		{
			var model__handle__ = model!.GetNonNullHandle (nameof (model));
			if (versionChecksum is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (versionChecksum));
			var nsversionChecksum = CFString.CreateNative (versionChecksum);
			if (IsDirectBinding) {
				InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (this.Handle, selInitWithModel_VersionChecksum_XHandle, model__handle__, nsversionChecksum), "initWithModel:versionChecksum:");
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, selInitWithModel_VersionChecksum_XHandle, model__handle__, nsversionChecksum), "initWithModel:versionChecksum:");
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (model);
			CFString.ReleaseNative (nsversionChecksum);
		}
		[Export ("initWithFileURL:versionChecksum:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public NSManagedObjectModelReference (NSUrl fileUrl, string versionChecksum)
			: base (NSObjectFlag.Empty)
		{
			var fileUrl__handle__ = fileUrl!.GetNonNullHandle (nameof (fileUrl));
			if (versionChecksum is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (versionChecksum));
			var nsversionChecksum = CFString.CreateNative (versionChecksum);
			if (IsDirectBinding) {
				InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (this.Handle, selInitWithFileURL_VersionChecksum_XHandle, fileUrl__handle__, nsversionChecksum), "initWithFileURL:versionChecksum:");
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, selInitWithFileURL_VersionChecksum_XHandle, fileUrl__handle__, nsversionChecksum), "initWithFileURL:versionChecksum:");
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (fileUrl);
			CFString.ReleaseNative (nsversionChecksum);
		}
		[Export ("initWithEntityVersionHashes:inBundle:versionChecksum:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public NSManagedObjectModelReference (NSDictionary versionHash, NSBundle? bundle, string versionChecksum)
			: base (NSObjectFlag.Empty)
		{
			var versionHash__handle__ = versionHash!.GetNonNullHandle (nameof (versionHash));
			var bundle__handle__ = bundle.GetHandle ();
			if (versionChecksum is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (versionChecksum));
			var nsversionChecksum = CFString.CreateNative (versionChecksum);
			if (IsDirectBinding) {
				InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (this.Handle, selInitWithEntityVersionHashes_InBundle_VersionChecksum_XHandle, versionHash__handle__, bundle__handle__, nsversionChecksum), "initWithEntityVersionHashes:inBundle:versionChecksum:");
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_NativeHandle_NativeHandle (&__objc_super__, selInitWithEntityVersionHashes_InBundle_VersionChecksum_XHandle, versionHash__handle__, bundle__handle__, nsversionChecksum), "initWithEntityVersionHashes:inBundle:versionChecksum:");
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (versionHash);
			GC.KeepAlive (bundle);
			CFString.ReleaseNative (nsversionChecksum);
		}
		[Export ("initWithName:inBundle:versionChecksum:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public NSManagedObjectModelReference (string modelName, NSBundle? bundle, string versionChecksum)
			: base (NSObjectFlag.Empty)
		{
			if (modelName is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (modelName));
			var bundle__handle__ = bundle.GetHandle ();
			if (versionChecksum is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (versionChecksum));
			var nsmodelName = CFString.CreateNative (modelName);
			var nsversionChecksum = CFString.CreateNative (versionChecksum);
			if (IsDirectBinding) {
				InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (this.Handle, selInitWithName_InBundle_VersionChecksum_XHandle, nsmodelName, bundle__handle__, nsversionChecksum), "initWithName:inBundle:versionChecksum:");
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_NativeHandle_NativeHandle (&__objc_super__, selInitWithName_InBundle_VersionChecksum_XHandle, nsmodelName, bundle__handle__, nsversionChecksum), "initWithName:inBundle:versionChecksum:");
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (bundle);
			CFString.ReleaseNative (nsmodelName);
			CFString.ReleaseNative (nsversionChecksum);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSManagedObjectModel ResolvedModel {
			[Export ("resolvedModel", ArgumentSemantic.Retain)]
			get {
				NSManagedObjectModel? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSManagedObjectModel> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selResolvedModelXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<NSManagedObjectModel> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selResolvedModelXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string VersionChecksum {
			[Export ("versionChecksum", ArgumentSemantic.Retain)]
			get {
				string ret;
				if (IsDirectBinding) {
					ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selVersionChecksumXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selVersionChecksumXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
	} /* class NSManagedObjectModelReference */
}
