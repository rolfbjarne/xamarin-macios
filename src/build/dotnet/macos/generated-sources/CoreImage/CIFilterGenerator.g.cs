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
namespace CoreImage {
	[Register("CIFilterGenerator", true)]
	[SupportedOSPlatform ("ios17.0")]
	[SupportedOSPlatform ("maccatalyst17.0")]
	[UnsupportedOSPlatform ("tvos")]
	[SupportedOSPlatform ("macos")]
	public unsafe partial class CIFilterGenerator : NSObject, ICIFilterConstructor, INSCoding, INSCopying, INSSecureCoding {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selClassAttributesX = "classAttributes";
		static readonly NativeHandle selClassAttributesXHandle = Selector.GetHandle ("classAttributes");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selConnectObject_WithKey_ToObject_WithKey_X = "connectObject:withKey:toObject:withKey:";
		static readonly NativeHandle selConnectObject_WithKey_ToObject_WithKey_XHandle = Selector.GetHandle ("connectObject:withKey:toObject:withKey:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selCopyWithZone_X = "copyWithZone:";
		static readonly NativeHandle selCopyWithZone_XHandle = Selector.GetHandle ("copyWithZone:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selDisconnectObject_WithKey_ToObject_WithKey_X = "disconnectObject:withKey:toObject:withKey:";
		static readonly NativeHandle selDisconnectObject_WithKey_ToObject_WithKey_XHandle = Selector.GetHandle ("disconnectObject:withKey:toObject:withKey:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selEncodeWithCoder_X = "encodeWithCoder:";
		static readonly NativeHandle selEncodeWithCoder_XHandle = Selector.GetHandle ("encodeWithCoder:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selExportKey_FromObject_WithName_X = "exportKey:fromObject:withName:";
		static readonly NativeHandle selExportKey_FromObject_WithName_XHandle = Selector.GetHandle ("exportKey:fromObject:withName:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selExportedKeysX = "exportedKeys";
		static readonly NativeHandle selExportedKeysXHandle = Selector.GetHandle ("exportedKeys");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selFilterX = "filter";
		static readonly NativeHandle selFilterXHandle = Selector.GetHandle ("filter");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selFilterGeneratorX = "filterGenerator";
		static readonly NativeHandle selFilterGeneratorXHandle = Selector.GetHandle ("filterGenerator");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selFilterGeneratorWithContentsOfURL_X = "filterGeneratorWithContentsOfURL:";
		static readonly NativeHandle selFilterGeneratorWithContentsOfURL_XHandle = Selector.GetHandle ("filterGeneratorWithContentsOfURL:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selFilterWithName_X = "filterWithName:";
		static readonly NativeHandle selFilterWithName_XHandle = Selector.GetHandle ("filterWithName:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selInitWithCoder_X = "initWithCoder:";
		static readonly NativeHandle selInitWithCoder_XHandle = Selector.GetHandle ("initWithCoder:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selInitWithContentsOfURL_X = "initWithContentsOfURL:";
		static readonly NativeHandle selInitWithContentsOfURL_XHandle = Selector.GetHandle ("initWithContentsOfURL:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selRegisterFilterName_X = "registerFilterName:";
		static readonly NativeHandle selRegisterFilterName_XHandle = Selector.GetHandle ("registerFilterName:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selRemoveExportedKey_X = "removeExportedKey:";
		static readonly NativeHandle selRemoveExportedKey_XHandle = Selector.GetHandle ("removeExportedKey:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetAttributes_ForExportedKey_X = "setAttributes:forExportedKey:";
		static readonly NativeHandle selSetAttributes_ForExportedKey_XHandle = Selector.GetHandle ("setAttributes:forExportedKey:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetClassAttributes_X = "setClassAttributes:";
		static readonly NativeHandle selSetClassAttributes_XHandle = Selector.GetHandle ("setClassAttributes:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selWriteToURL_Atomically_X = "writeToURL:atomically:";
		static readonly NativeHandle selWriteToURL_Atomically_XHandle = Selector.GetHandle ("writeToURL:atomically:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly NativeHandle class_ptr = Class.GetHandle ("CIFilterGenerator");
		/// <summary>The Objective-C class handle for this class.</summary>
		/// <value>The pointer to the Objective-C class.</value>
		/// <remarks>
		///     Each managed class mirrors an unmanaged Objective-C class.
		///     This value contains the pointer to the Objective-C class.
		///     It is similar to calling the managed <see cref="ObjCRuntime.Class.GetHandle(string)" /> or the native <see href="https://developer.apple.com/documentation/objectivec/1418952-objc_getclass">objc_getClass</see> method with the type name.
		/// </remarks>
		public override NativeHandle ClassHandle { get { return class_ptr; } }
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
		public CIFilterGenerator (NSCoder coder) : base (NSObjectFlag.Empty)
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
		protected CIFilterGenerator (NSObjectFlag t) : base (t)
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
		protected internal CIFilterGenerator (NativeHandle handle) : base (handle)
		{
		}

		/// <param name="aURL">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("initWithContentsOfURL:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public CIFilterGenerator (NSUrl aURL)
			: base (NSObjectFlag.Empty)
		{
			var aURL__handle__ = aURL!.GetNonNullHandle (nameof (aURL));
			if (IsDirectBinding) {
				InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, selInitWithContentsOfURL_XHandle, aURL__handle__), "initWithContentsOfURL:");
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle (&__objc_super__, selInitWithContentsOfURL_XHandle, aURL__handle__), "initWithContentsOfURL:");
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (aURL);
		}
		/// <param name="sourceObject">To be added.</param><param name="withSourceKey">To be added.</param><param name="targetObject">To be added.</param><param name="targetKey">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("connectObject:withKey:toObject:withKey:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void ConnectObject (NSObject sourceObject, string? withSourceKey, NSObject targetObject, string targetKey)
		{
			var sourceObject__handle__ = sourceObject!.GetNonNullHandle (nameof (sourceObject));
			var targetObject__handle__ = targetObject!.GetNonNullHandle (nameof (targetObject));
			if (targetKey is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (targetKey));
			var nswithSourceKey = CFString.CreateNative (withSourceKey);
			var nstargetKey = CFString.CreateNative (targetKey);
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle_NativeHandle (this.Handle, selConnectObject_WithKey_ToObject_WithKey_XHandle, sourceObject__handle__, nswithSourceKey, targetObject__handle__, nstargetKey);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_NativeHandle_NativeHandle_NativeHandle (&__objc_super__, selConnectObject_WithKey_ToObject_WithKey_XHandle, sourceObject__handle__, nswithSourceKey, targetObject__handle__, nstargetKey);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (sourceObject);
			GC.KeepAlive (targetObject);
			CFString.ReleaseNative (nswithSourceKey);
			CFString.ReleaseNative (nstargetKey);
		}
		/// <param name="zone">Developers should pass <see langword="null" />.  Memory zones are no longer used.</param><summary>Performs a copy of the underlying Objective-C object.</summary><returns>The newly-allocated object.</returns><remarks><para>This method performs a "shallow copy" of <see langword="this" />. If this object contains references to external objects, the new object will contain references to the same object.</para></remarks>
		[Export ("copyWithZone:")]
		[return: ReleaseAttribute ()]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios17.0")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("maccatalyst17.0")]
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
		/// <summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("filterGenerator")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static CIFilterGenerator Create ()
		{
			CIFilterGenerator ret;
			ret =  Runtime.GetNSObject<CIFilterGenerator> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (class_ptr, selFilterGeneratorXHandle), false)!;
			return ret;
		}
		/// <summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("filter")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual CIFilter CreateFilter ()
		{
			CIFilter ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<CIFilter> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selFilterXHandle), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<CIFilter> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selFilterXHandle), false)!;
					GC.KeepAlive (this);
				}
			}
			return ret;
		}
		/// <param name="sourceObject">To be added.</param><param name="sourceKey">To be added.</param><param name="targetObject">To be added.</param><param name="targetKey">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("disconnectObject:withKey:toObject:withKey:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DisconnectObject (NSObject sourceObject, string sourceKey, NSObject targetObject, string targetKey)
		{
			var sourceObject__handle__ = sourceObject!.GetNonNullHandle (nameof (sourceObject));
			if (sourceKey is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (sourceKey));
			var targetObject__handle__ = targetObject!.GetNonNullHandle (nameof (targetObject));
			if (targetKey is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (targetKey));
			var nssourceKey = CFString.CreateNative (sourceKey);
			var nstargetKey = CFString.CreateNative (targetKey);
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle_NativeHandle (this.Handle, selDisconnectObject_WithKey_ToObject_WithKey_XHandle, sourceObject__handle__, nssourceKey, targetObject__handle__, nstargetKey);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_NativeHandle_NativeHandle_NativeHandle (&__objc_super__, selDisconnectObject_WithKey_ToObject_WithKey_XHandle, sourceObject__handle__, nssourceKey, targetObject__handle__, nstargetKey);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (sourceObject);
			GC.KeepAlive (targetObject);
			CFString.ReleaseNative (nssourceKey);
			CFString.ReleaseNative (nstargetKey);
		}
		/// <summary>Encodes the state of the object using the provided encoder.</summary><param name="encoder">The encoder object where the state of the object will be stored</param><remarks><para>This method is part of the <see cref="T:Foundation.INSCoding" /> protocol and is used by applications to preserve the state of the object into an archive.</para><para>Developers will typically create an <see cref="T:Foundation.NSKeyedArchiver" /> and then invoke the <see cref="M:Foundation.NSKeyedArchiver.ArchiveRootObjectToFile(Foundation.NSObject,System.String)" /> method which will call into this method.</para><para>If developers want to allow their object to be archived, they should override this method and store their state in using the provided <paramref name="encoder" /> parameter. In addition, developers should also implement a constructor that takes an NSCoder argument and is exported with <c>[Export ("initWithCoder:")]</c>.</para><example><code lang="csharp lang-csharp"><![CDATA[public void override EncodeTo (NSCoder coder) {
		/// coder.Encode (1, key: "version");
		/// coder.Encode (userName, key: "userName");
		/// coder.Encode (hostName, key: "hostName");]]></code></example></remarks>
		[Export ("encodeWithCoder:")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios17.0")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("maccatalyst17.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void EncodeTo (NSCoder encoder)
		{
			var encoder__handle__ = encoder!.GetNonNullHandle (nameof (encoder));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selEncodeWithCoder_XHandle, encoder__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selEncodeWithCoder_XHandle, encoder__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (encoder);
		}
		/// <param name="key">To be added.</param><param name="targetObject">To be added.</param><param name="exportedKeyName">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("exportKey:fromObject:withName:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void ExportKey (string key, NSObject targetObject, string? exportedKeyName)
		{
			if (key is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (key));
			var targetObject__handle__ = targetObject!.GetNonNullHandle (nameof (targetObject));
			var nskey = CFString.CreateNative (key);
			var nsexportedKeyName = CFString.CreateNative (exportedKeyName);
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (this.Handle, selExportKey_FromObject_WithName_XHandle, nskey, targetObject__handle__, nsexportedKeyName);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_NativeHandle_NativeHandle (&__objc_super__, selExportKey_FromObject_WithName_XHandle, nskey, targetObject__handle__, nsexportedKeyName);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (targetObject);
			CFString.ReleaseNative (nskey);
			CFString.ReleaseNative (nsexportedKeyName);
		}
		/// <param name="name">To be added.</param><summary>Creates a new filter from the provided name.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("filterWithName:")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios17.0")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("maccatalyst17.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual CIFilter? FilterWithName (string name)
		{
			if (name is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (name));
			var nsname = CFString.CreateNative (name);
			CIFilter? ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<CIFilter> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, selFilterWithName_XHandle, nsname), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<CIFilter> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle (&__objc_super__, selFilterWithName_XHandle, nsname), false)!;
					GC.KeepAlive (this);
				}
			}
			CFString.ReleaseNative (nsname);
			return ret!;
		}
		/// <param name="aURL">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("filterGeneratorWithContentsOfURL:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static CIFilterGenerator? FromUrl (NSUrl aURL)
		{
			var aURL__handle__ = aURL!.GetNonNullHandle (nameof (aURL));
			CIFilterGenerator? ret;
			ret =  Runtime.GetNSObject<CIFilterGenerator> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (class_ptr, selFilterGeneratorWithContentsOfURL_XHandle, aURL__handle__), false)!;
			GC.KeepAlive (aURL);
			return ret!;
		}
		/// <param name="name">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("registerFilterName:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void RegisterFilterName (string name)
		{
			if (name is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (name));
			var nsname = CFString.CreateNative (name);
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selRegisterFilterName_XHandle, nsname);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selRegisterFilterName_XHandle, nsname);
					GC.KeepAlive (this);
				}
			}
			CFString.ReleaseNative (nsname);
		}
		/// <param name="exportedKeyName">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("removeExportedKey:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void RemoveExportedKey (string exportedKeyName)
		{
			if (exportedKeyName is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (exportedKeyName));
			var nsexportedKeyName = CFString.CreateNative (exportedKeyName);
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selRemoveExportedKey_XHandle, nsexportedKeyName);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selRemoveExportedKey_XHandle, nsexportedKeyName);
					GC.KeepAlive (this);
				}
			}
			CFString.ReleaseNative (nsexportedKeyName);
		}
		/// <param name="toUrl">To be added.</param><param name="atomically">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("writeToURL:atomically:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool Save (NSUrl toUrl, bool atomically)
		{
			var toUrl__handle__ = toUrl!.GetNonNullHandle (nameof (toUrl));
			byte ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_bool (this.Handle, selWriteToURL_Atomically_XHandle, toUrl__handle__, atomically ? (byte) 1 : (byte) 0);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper_NativeHandle_bool (&__objc_super__, selWriteToURL_Atomically_XHandle, toUrl__handle__, atomically ? (byte) 1 : (byte) 0);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (toUrl);
			return ret != 0;
		}
		/// <param name="attributes">To be added.</param><param name="exportedKey">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("setAttributes:forExportedKey:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetAttributesforExportedKey (NSDictionary attributes, NSString exportedKey)
		{
			var attributes__handle__ = attributes!.GetNonNullHandle (nameof (attributes));
			var exportedKey__handle__ = exportedKey!.GetNonNullHandle (nameof (exportedKey));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (this.Handle, selSetAttributes_ForExportedKey_XHandle, attributes__handle__, exportedKey__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, selSetAttributes_ForExportedKey_XHandle, attributes__handle__, exportedKey__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (attributes);
			GC.KeepAlive (exportedKey);
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSDictionary ClassAttributes {
			[Export ("classAttributes")]
			get {
				NSDictionary? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSDictionary> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selClassAttributesXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<NSDictionary> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selClassAttributesXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setClassAttributes:")]
			set {
				var value__handle__ = value!.GetNonNullHandle (nameof (value));
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selSetClassAttributes_XHandle, value__handle__);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selSetClassAttributes_XHandle, value__handle__);
						GC.KeepAlive (this);
					}
				}
				GC.KeepAlive (value);
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSDictionary ExportedKeys {
			[Export ("exportedKeys")]
			get {
				NSDictionary? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSDictionary> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selExportedKeysXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<NSDictionary> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selExportedKeysXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ExportedKey;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCIFilterGeneratorExportedKey",  "Quartz")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("macos")]
		public static NSString ExportedKey {
			[UnsupportedOSPlatform ("ios")]
			[UnsupportedOSPlatform ("maccatalyst")]
			[UnsupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("macos")]
			get {
				if (_ExportedKey is null)
					_ExportedKey = Dlfcn.GetStringConstant (Libraries.Quartz.Handle, "kCIFilterGeneratorExportedKey")!;
				return _ExportedKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ExportedKeyName;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCIFilterGeneratorExportedKeyName",  "Quartz")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("macos")]
		public static NSString ExportedKeyName {
			[UnsupportedOSPlatform ("ios")]
			[UnsupportedOSPlatform ("maccatalyst")]
			[UnsupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("macos")]
			get {
				if (_ExportedKeyName is null)
					_ExportedKeyName = Dlfcn.GetStringConstant (Libraries.Quartz.Handle, "kCIFilterGeneratorExportedKeyName")!;
				return _ExportedKeyName;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ExportedKeyTargetObject;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCIFilterGeneratorExportedKeyTargetObject",  "Quartz")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("macos")]
		public static NSString ExportedKeyTargetObject {
			[UnsupportedOSPlatform ("ios")]
			[UnsupportedOSPlatform ("maccatalyst")]
			[UnsupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("macos")]
			get {
				if (_ExportedKeyTargetObject is null)
					_ExportedKeyTargetObject = Dlfcn.GetStringConstant (Libraries.Quartz.Handle, "kCIFilterGeneratorExportedKeyTargetObject")!;
				return _ExportedKeyTargetObject;
			}
		}
	} /* class CIFilterGenerator */
}
