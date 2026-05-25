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
namespace SceneKit {
	/// <summary>Reads scene-defining data from a file or NSData object.</summary><related type="externalDocumentation" href="https://developer.apple.com/library/ios/documentation/SceneKit/Reference/SCNSceneSource_Class/index.html">Apple documentation for <c>SCNSceneSource</c></related>
	[Register("SCNSceneSource", true)]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("tvos")]
	public unsafe partial class SCNSceneSource : NSObject {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selDataX = "data";
		static readonly NativeHandle selDataXHandle = Selector.GetHandle ("data");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selEntriesPassingTest_X = "entriesPassingTest:";
		static readonly NativeHandle selEntriesPassingTest_XHandle = Selector.GetHandle ("entriesPassingTest:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selEntryWithIdentifier_WithClass_X = "entryWithIdentifier:withClass:";
		static readonly NativeHandle selEntryWithIdentifier_WithClass_XHandle = Selector.GetHandle ("entryWithIdentifier:withClass:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selIdentifiersOfEntriesWithClass_X = "identifiersOfEntriesWithClass:";
		static readonly NativeHandle selIdentifiersOfEntriesWithClass_XHandle = Selector.GetHandle ("identifiersOfEntriesWithClass:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selInitWithData_Options_X = "initWithData:options:";
		static readonly NativeHandle selInitWithData_Options_XHandle = Selector.GetHandle ("initWithData:options:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selInitWithURL_Options_X = "initWithURL:options:";
		static readonly NativeHandle selInitWithURL_Options_XHandle = Selector.GetHandle ("initWithURL:options:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selPropertyForKey_X = "propertyForKey:";
		static readonly NativeHandle selPropertyForKey_XHandle = Selector.GetHandle ("propertyForKey:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSceneSourceWithData_Options_X = "sceneSourceWithData:options:";
		static readonly NativeHandle selSceneSourceWithData_Options_XHandle = Selector.GetHandle ("sceneSourceWithData:options:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSceneSourceWithURL_Options_X = "sceneSourceWithURL:options:";
		static readonly NativeHandle selSceneSourceWithURL_Options_XHandle = Selector.GetHandle ("sceneSourceWithURL:options:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSceneWithOptions_Error_X = "sceneWithOptions:error:";
		static readonly NativeHandle selSceneWithOptions_Error_XHandle = Selector.GetHandle ("sceneWithOptions:error:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSceneWithOptions_StatusHandler_X = "sceneWithOptions:statusHandler:";
		static readonly NativeHandle selSceneWithOptions_StatusHandler_XHandle = Selector.GetHandle ("sceneWithOptions:statusHandler:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selUrlX = "url";
		static readonly NativeHandle selUrlXHandle = Selector.GetHandle ("url");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly NativeHandle class_ptr = Class.GetHandle ("SCNSceneSource");
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
		protected SCNSceneSource (NSObjectFlag t) : base (t)
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
		protected internal SCNSceneSource (NativeHandle handle) : base (handle)
		{
		}

		[Export ("initWithURL:options:")]
		[EditorBrowsable (EditorBrowsableState.Never)]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public SCNSceneSource (NSUrl url, NSDictionary? options)
			: base (NSObjectFlag.Empty)
		{
			var url__handle__ = url!.GetNonNullHandle (nameof (url));
			var options__handle__ = options.GetHandle ();
			if (IsDirectBinding) {
				InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (this.Handle, selInitWithURL_Options_XHandle, url__handle__, options__handle__), "initWithURL:options:");
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, selInitWithURL_Options_XHandle, url__handle__, options__handle__), "initWithURL:options:");
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (url);
			GC.KeepAlive (options);
		}
		/// <param name="url">To be added.</param><param name="options">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public SCNSceneSource (NSUrl url, SCNSceneLoadingOptions options)
			: this (url, options.GetDictionary ())
		{
		}
		[Export ("initWithData:options:")]
		[EditorBrowsable (EditorBrowsableState.Never)]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public SCNSceneSource (NSData data, NSDictionary? options)
			: base (NSObjectFlag.Empty)
		{
			var data__handle__ = data!.GetNonNullHandle (nameof (data));
			var options__handle__ = options.GetHandle ();
			if (IsDirectBinding) {
				InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (this.Handle, selInitWithData_Options_XHandle, data__handle__, options__handle__), "initWithData:options:");
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, selInitWithData_Options_XHandle, data__handle__, options__handle__), "initWithData:options:");
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (data);
			GC.KeepAlive (options);
		}
		/// <param name="data">To be added.</param><param name="options">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public SCNSceneSource (NSData data, SCNSceneLoadingOptions options)
			: this (data, options.GetDictionary ())
		{
		}
		[Export ("entriesPassingTest:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual NSObject[] EntriesPassingTest ([BlockProxy (typeof (ObjCRuntime.Trampolines.NIDSCNSceneSourceFilter))]SCNSceneSourceFilter predicate)
		{
			if (predicate is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (predicate));
			using var block_predicate = Trampolines.SDSCNSceneSourceFilter.CreateBlock (predicate);
			BlockLiteral *block_ptr_predicate = &block_predicate;
			NSObject[] ret;
			if (IsDirectBinding) {
				ret = CFArray.ArrayFromHandle<NSObject>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, selEntriesPassingTest_XHandle, (IntPtr) block_ptr_predicate), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = CFArray.ArrayFromHandle<NSObject>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle (&__objc_super__, selEntriesPassingTest_XHandle, (IntPtr) block_ptr_predicate), false)!;
					GC.KeepAlive (this);
				}
			}
			return ret;
		}
		[Export ("sceneSourceWithData:options:")]
		[EditorBrowsable (EditorBrowsableState.Never)]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static SCNSceneSource? FromData (NSData data, NSDictionary? options)
		{
			var data__handle__ = data!.GetNonNullHandle (nameof (data));
			var options__handle__ = options.GetHandle ();
			SCNSceneSource? ret;
			ret =  Runtime.GetNSObject<SCNSceneSource> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (class_ptr, selSceneSourceWithData_Options_XHandle, data__handle__, options__handle__), false)!;
			GC.KeepAlive (data);
			GC.KeepAlive (options);
			return ret!;
		}
		/// <param name="data">To be added.</param><param name="options">To be added.</param><summary>Creates a scene source that reads the graph that is contained in <paramref name="data" />.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static SCNSceneSource? FromData (NSData data, SCNSceneLoadingOptions options)
		{
			return FromData (data, options.GetDictionary ());
		}
		[Export ("sceneSourceWithURL:options:")]
		[EditorBrowsable (EditorBrowsableState.Never)]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static SCNSceneSource? FromUrl (NSUrl url, NSDictionary? options)
		{
			var url__handle__ = url!.GetNonNullHandle (nameof (url));
			var options__handle__ = options.GetHandle ();
			SCNSceneSource? ret;
			ret =  Runtime.GetNSObject<SCNSceneSource> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (class_ptr, selSceneSourceWithURL_Options_XHandle, url__handle__, options__handle__), false)!;
			GC.KeepAlive (url);
			GC.KeepAlive (options);
			return ret!;
		}
		/// <param name="url">To be added.</param><param name="options">To be added.</param><summary>Creates a scene source that reads the graph that is contained in the file that is pointed to by <paramref name="url" />.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public SCNSceneSource? FromUrl (NSUrl url, SCNSceneLoadingOptions options)
		{
			return FromUrl (url, options.GetDictionary ());
		}
		[Export ("entryWithIdentifier:withClass:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSObject? GetEntryWithIdentifier (string uid, Class entryClass)
		{
			if (uid is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (uid));
			var entryClass__handle__ = entryClass!.GetNonNullHandle (nameof (entryClass));
			var nsuid = CFString.CreateNative (uid);
			NSObject? ret;
			if (IsDirectBinding) {
				ret = Runtime.GetNSObject (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (this.Handle, selEntryWithIdentifier_WithClass_XHandle, nsuid, entryClass.Handle), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = Runtime.GetNSObject (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, selEntryWithIdentifier_WithClass_XHandle, nsuid, entryClass.Handle), false)!;
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (entryClass);
			CFString.ReleaseNative (nsuid);
			return ret!;
		}
		[Export ("identifiersOfEntriesWithClass:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string[] GetIdentifiersOfEntries (Class entryClass)
		{
			var entryClass__handle__ = entryClass!.GetNonNullHandle (nameof (entryClass));
			string[]? ret;
			if (IsDirectBinding) {
				ret = CFArray.StringArrayFromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, selIdentifiersOfEntriesWithClass_XHandle, entryClass.Handle), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = CFArray.StringArrayFromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle (&__objc_super__, selIdentifiersOfEntriesWithClass_XHandle, entryClass.Handle), false)!;
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (entryClass);
			return ret!;
		}
		[Export ("propertyForKey:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSObject? GetProperty (NSString key)
		{
			var key__handle__ = key!.GetNonNullHandle (nameof (key));
			NSObject? ret;
			if (IsDirectBinding) {
				ret = Runtime.GetNSObject (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, selPropertyForKey_XHandle, key__handle__), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = Runtime.GetNSObject (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle (&__objc_super__, selPropertyForKey_XHandle, key__handle__), false)!;
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (key);
			return ret!;
		}
		[Export ("sceneWithOptions:statusHandler:")]
		[EditorBrowsable (EditorBrowsableState.Never)]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual SCNScene? SceneFromOptions (NSDictionary? options, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDSCNSceneSourceStatusHandler))]SCNSceneSourceStatusHandler? statusHandler)
		{
			var options__handle__ = options.GetHandle ();
			using var block_statusHandler = Trampolines.SDSCNSceneSourceStatusHandler.CreateNullableBlock (statusHandler);
			BlockLiteral *block_ptr_statusHandler = null;
			if (statusHandler is not null)
				block_ptr_statusHandler = &block_statusHandler;
			SCNScene? ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<SCNScene> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (this.Handle, selSceneWithOptions_StatusHandler_XHandle, options__handle__, (IntPtr) block_ptr_statusHandler), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<SCNScene> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, selSceneWithOptions_StatusHandler_XHandle, options__handle__, (IntPtr) block_ptr_statusHandler), false)!;
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (options);
			return ret!;
		}
		/// <param name="options">To be added.</param><param name="statusHandler">To be added.</param><summary>Creates a new scene from the specified options dictionary, periodically calling <paramref name="statusHandler" /> to report progress.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe SCNScene? SceneFromOptions (SCNSceneLoadingOptions? options, SCNSceneSourceStatusHandler? statusHandler)
		{
			return SceneFromOptions (options?.GetDictionary (), statusHandler);
		}
		[Export ("sceneWithOptions:error:")]
		[EditorBrowsable (EditorBrowsableState.Never)]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual SCNScene? SceneWithOption (NSDictionary? options, out NSError error)
		{
			var options__handle__ = options.GetHandle ();
			NativeHandle errorValue = IntPtr.Zero;
			SCNScene? ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<SCNScene> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_ref_NativeHandle (this.Handle, selSceneWithOptions_Error_XHandle, options__handle__, &errorValue), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<SCNScene> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_ref_NativeHandle (&__objc_super__, selSceneWithOptions_Error_XHandle, options__handle__, &errorValue), false)!;
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (options);
			error = Runtime.GetNSObject<NSError> (errorValue)!;
			return ret!;
		}
		/// <param name="options">To be added.</param><param name="error">To be added.</param><summary>Creates a new scene from the specified options dictionary, and reporting any error condtion in <paramref name="error" />.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe SCNScene? SceneWithOption (SCNSceneLoadingOptions options, out NSError error)
		{
			return SceneWithOption (options?.GetDictionary (), out error);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSData? Data {
			[Export ("data")]
			get {
				NSData? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSData> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selDataXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<NSData> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selDataXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSUrl? Url {
			[Export ("url")]
			get {
				NSUrl? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSUrl> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selUrlXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<NSUrl> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selUrlXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
	} /* class SCNSceneSource */
}
