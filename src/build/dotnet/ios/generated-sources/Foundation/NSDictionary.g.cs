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
using UIKit;
using GLKit;
using Metal;
using CoreML;
using MapKit;
using Photos;
using ModelIO;
using Network;
using SceneKit;
using Contacts;
using Security;
using Messages;
using AudioUnit;
using CoreVideo;
using CoreMedia;
using QuickLook;
using CoreImage;
using SpriteKit;
using Foundation;
using CoreMotion;
using ObjCRuntime;
using AddressBook;
using MediaPlayer;
using GameplayKit;
using CoreGraphics;
using CoreLocation;
using AVFoundation;
using NewsstandKit;
using FileProvider;
using CoreAnimation;
using CoreFoundation;
using NetworkExtension;
using MetalPerformanceShadersGraph;
#nullable enable
namespace Foundation {
	[Register("NSDictionary", true)]
	public unsafe partial class NSDictionary : NSObject, INSCoding, INSCopying, INSMutableCopying, INSSecureCoding, global::CoreData.INSFetchRequestResult {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly NativeHandle class_ptr = Class.GetHandle ("NSDictionary");
		/// <summary>The Objective-C class handle for this class.</summary>
		/// <value>The pointer to the Objective-C class.</value>
		/// <remarks>
		///     Each managed class mirrors an unmanaged Objective-C class.
		///     This value contains the pointer to the Objective-C class.
		///     It is similar to calling the managed <see cref="ObjCRuntime.Class.GetHandle(string)" /> or the native <see href="https://developer.apple.com/documentation/objectivec/1418952-objc_getclass">objc_getClass</see> method with the type name.
		/// </remarks>
		public override NativeHandle ClassHandle { get { return class_ptr; } }
		/// <summary>Creates a new <see cref="NSDictionary" /> with default values.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[DesignatedInitializer]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public NSDictionary () : base (NSObjectFlag.Empty)
		{
			if (IsDirectBinding) {
				InitializeHandle (global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, global::ObjCRuntime.Selector.GetHandle ("init")), "init");
			} else {
				unsafe {
				var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
				InitializeHandle (global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (&__objc_super__, global::ObjCRuntime.Selector.GetHandle ("init")), "init");
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
		public NSDictionary (NSCoder coder) : base (NSObjectFlag.Empty)
		{
			if (IsDirectBinding) {
				InitializeHandle (global::ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("initWithCoder:"), coder.Handle), "initWithCoder:");
			} else {
				unsafe {
				var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
				InitializeHandle (global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper_IntPtr (&__objc_super__, Selector.GetHandle ("initWithCoder:"), coder.Handle), "initWithCoder:");
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
		protected NSDictionary (NSObjectFlag t) : base (t)
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
		protected internal NSDictionary (NativeHandle handle) : base (handle)
		{
		}

		[Export ("initWithDictionary:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public NSDictionary (NSDictionary other)
			: base (NSObjectFlag.Empty)
		{
			var other__handle__ = other!.GetNonNullHandle (nameof (other));
			if (IsDirectBinding) {
				InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("initWithDictionary:"), other__handle__), "initWithDictionary:");
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle (&__objc_super__, Selector.GetHandle ("initWithDictionary:"), other__handle__), "initWithDictionary:");
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (other);
		}
		[Export ("initWithDictionary:copyItems:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public NSDictionary (NSDictionary other, bool copyItems)
			: base (NSObjectFlag.Empty)
		{
			var other__handle__ = other!.GetNonNullHandle (nameof (other));
			if (IsDirectBinding) {
				InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_bool (this.Handle, Selector.GetHandle ("initWithDictionary:copyItems:"), other__handle__, copyItems ? (byte) 1 : (byte) 0), "initWithDictionary:copyItems:");
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_bool (&__objc_super__, Selector.GetHandle ("initWithDictionary:copyItems:"), other__handle__, copyItems ? (byte) 1 : (byte) 0), "initWithDictionary:copyItems:");
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (other);
		}
		[Export ("initWithContentsOfFile:")]
		[ObsoletedOSPlatform ("macos10.15", "Use 'NSMutableDictionary(string)' constructor instead.")]
		[ObsoletedOSPlatform ("ios13.0", "Use 'NSMutableDictionary(string)' constructor instead.")]
		[ObsoletedOSPlatform ("tvos13.0", "Use 'NSMutableDictionary(string)' constructor instead.")]
		[ObsoletedOSPlatform ("maccatalyst13.1", "Use 'NSMutableDictionary(string)' constructor instead.")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public NSDictionary (string fileName)
			: base (NSObjectFlag.Empty)
		{
			if (fileName is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (fileName));
			var nsfileName = CFString.CreateNative (fileName);
			if (IsDirectBinding) {
				InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("initWithContentsOfFile:"), nsfileName), "initWithContentsOfFile:");
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle (&__objc_super__, Selector.GetHandle ("initWithContentsOfFile:"), nsfileName), "initWithContentsOfFile:");
					GC.KeepAlive (this);
				}
			}
			CFString.ReleaseNative (nsfileName);
		}
		[Export ("initWithObjects:forKeys:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal NSDictionary (NSArray objects, NSArray keys)
			: base (NSObjectFlag.Empty)
		{
			var objects__handle__ = objects!.GetNonNullHandle (nameof (objects));
			var keys__handle__ = keys!.GetNonNullHandle (nameof (keys));
			if (IsDirectBinding) {
				InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("initWithObjects:forKeys:"), objects__handle__, keys__handle__), "initWithObjects:forKeys:");
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, Selector.GetHandle ("initWithObjects:forKeys:"), objects__handle__, keys__handle__), "initWithObjects:forKeys:");
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (objects);
			GC.KeepAlive (keys);
		}
		[Export ("initWithContentsOfURL:")]
		[ObsoletedOSPlatform ("macos10.15", "Use 'NSMutableDictionary(NSUrl)' constructor instead.")]
		[ObsoletedOSPlatform ("ios13.0", "Use 'NSMutableDictionary(NSUrl)' constructor instead.")]
		[ObsoletedOSPlatform ("tvos13.0", "Use 'NSMutableDictionary(NSUrl)' constructor instead.")]
		[ObsoletedOSPlatform ("maccatalyst13.1", "Use 'NSMutableDictionary(NSUrl)' constructor instead.")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public NSDictionary (NSUrl url)
			: base (NSObjectFlag.Empty)
		{
			var url__handle__ = url!.GetNonNullHandle (nameof (url));
			if (IsDirectBinding) {
				InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("initWithContentsOfURL:"), url__handle__), "initWithContentsOfURL:");
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle (&__objc_super__, Selector.GetHandle ("initWithContentsOfURL:"), url__handle__), "initWithContentsOfURL:");
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (url);
		}
		[Export ("initWithContentsOfURL:error:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe NSDictionary (NSUrl url, out NSError error)
			: base (NSObjectFlag.Empty)
		{
			var url__handle__ = url!.GetNonNullHandle (nameof (url));
			NativeHandle errorValue = IntPtr.Zero;
			if (IsDirectBinding) {
				InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_ref_NativeHandle (this.Handle, Selector.GetHandle ("initWithContentsOfURL:error:"), url__handle__, &errorValue), "initWithContentsOfURL:error:");
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_ref_NativeHandle (&__objc_super__, Selector.GetHandle ("initWithContentsOfURL:error:"), url__handle__, &errorValue), "initWithContentsOfURL:error:");
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (url);
			error = Runtime.GetNSObject<NSError> (errorValue)!;
		}
		/// <param name="zone">Developers should pass <see langword="null" />.  Memory zones are no longer used.</param><summary>Performs a copy of the underlying Objective-C object.</summary><returns>The newly-allocated object.</returns><remarks><para>This method performs a "shallow copy" of <see langword="this" />. If this object contains references to external objects, the new object will contain references to the same object.</para></remarks>
		[Export ("copyWithZone:")]
		[return: ReleaseAttribute ()]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSObject Copy (NSZone? zone)
		{
			var zone__handle__ = zone.GetHandle ();
			NSObject? ret;
			if (IsDirectBinding) {
				ret = Runtime.GetNSObject (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("copyWithZone:"), zone__handle__), true)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = Runtime.GetNSObject (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle (&__objc_super__, Selector.GetHandle ("copyWithZone:"), zone__handle__), true)!;
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (zone);
			return ret!;
		}
		/// <summary>Encodes the state of the object using the provided encoder.</summary><param name="encoder">The encoder object where the state of the object will be stored</param><remarks><para>This method is part of the <see cref="T:Foundation.INSCoding" /> protocol and is used by applications to preserve the state of the object into an archive.</para><para>Developers will typically create an <see cref="T:Foundation.NSKeyedArchiver" /> and then invoke the <see cref="M:Foundation.NSKeyedArchiver.ArchiveRootObjectToFile(Foundation.NSObject,System.String)" /> method which will call into this method.</para><para>If developers want to allow their object to be archived, they should override this method and store their state in using the provided <paramref name="encoder" /> parameter. In addition, developers should also implement a constructor that takes an NSCoder argument and is exported with <c>[Export ("initWithCoder:")]</c>.</para><example><code lang="csharp lang-csharp"><![CDATA[public void override EncodeTo (NSCoder coder) {
		/// coder.Encode (1, key: "version");
		/// coder.Encode (userName, key: "userName");
		/// coder.Encode (hostName, key: "hostName");]]></code></example></remarks>
		[Export ("encodeWithCoder:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void EncodeTo (NSCoder encoder)
		{
			var encoder__handle__ = encoder!.GetNonNullHandle (nameof (encoder));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("encodeWithCoder:"), encoder__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, Selector.GetHandle ("encodeWithCoder:"), encoder__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (encoder);
		}
		[Export ("enumerateKeysAndObjectsUsingBlock:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void Enumerate ([BlockProxy (typeof (ObjCRuntime.Trampolines.NIDNSDictionaryEnumerator))]NSDictionaryEnumerator block)
		{
			if (block is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (block));
			using var block_block = Trampolines.SDNSDictionaryEnumerator.CreateBlock (block);
			BlockLiteral *block_ptr_block = &block_block;
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("enumerateKeysAndObjectsUsingBlock:"), (IntPtr) block_ptr_block);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, Selector.GetHandle ("enumerateKeysAndObjectsUsingBlock:"), (IntPtr) block_ptr_block);
					GC.KeepAlive (this);
				}
			}
		}
		[Export ("enumerateKeysAndObjectsWithOptions:usingBlock:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void Enumerate (NSEnumerationOptions options, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDNSDictionaryEnumerator))]NSDictionaryEnumerator block)
		{
			if (block is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (block));
			using var block_block = Trampolines.SDNSDictionaryEnumerator.CreateBlock (block);
			BlockLiteral *block_ptr_block = &block_block;
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_UIntPtr_NativeHandle (this.Handle, Selector.GetHandle ("enumerateKeysAndObjectsWithOptions:usingBlock:"), (UIntPtr) (ulong) options, (IntPtr) block_ptr_block);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_UIntPtr_NativeHandle (&__objc_super__, Selector.GetHandle ("enumerateKeysAndObjectsWithOptions:usingBlock:"), (UIntPtr) (ulong) options, (IntPtr) block_ptr_block);
					GC.KeepAlive (this);
				}
			}
		}
		[Export ("dictionaryWithDictionary:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSDictionary FromDictionary (NSDictionary source)
		{
			var source__handle__ = source!.GetNonNullHandle (nameof (source));
			NSDictionary? ret;
			ret =  Runtime.GetNSObject<NSDictionary> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (class_ptr, Selector.GetHandle ("dictionaryWithDictionary:"), source__handle__), false)!;
			GC.KeepAlive (source);
			return ret!;
		}
		[Export ("dictionaryWithContentsOfFile:")]
		[ObsoletedOSPlatform ("macos10.15", "Use 'NSMutableDictionary.FromFile' instead.")]
		[ObsoletedOSPlatform ("ios13.0", "Use 'NSMutableDictionary.FromFile' instead.")]
		[ObsoletedOSPlatform ("tvos13.0", "Use 'NSMutableDictionary.FromFile' instead.")]
		[ObsoletedOSPlatform ("maccatalyst13.1", "Use 'NSMutableDictionary.FromFile' instead.")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSDictionary FromFile (string path)
		{
			if (path is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (path));
			var nspath = CFString.CreateNative (path);
			NSDictionary? ret;
			ret =  Runtime.GetNSObject<NSDictionary> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (class_ptr, Selector.GetHandle ("dictionaryWithContentsOfFile:"), nspath), false)!;
			CFString.ReleaseNative (nspath);
			return ret!;
		}
		[Export ("dictionaryWithObject:forKey:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSDictionary FromObjectAndKey (NSObject obj, NSObject key)
		{
			var obj__handle__ = obj!.GetNonNullHandle (nameof (obj));
			var key__handle__ = key!.GetNonNullHandle (nameof (key));
			NSDictionary? ret;
			ret =  Runtime.GetNSObject<NSDictionary> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (class_ptr, Selector.GetHandle ("dictionaryWithObject:forKey:"), obj__handle__, key__handle__), false)!;
			GC.KeepAlive (obj);
			GC.KeepAlive (key);
			return ret!;
		}
		[Export ("dictionaryWithObjects:forKeys:count:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static NSDictionary FromObjectsAndKeysInternal (NSArray? objects, NSArray? keys, nint count)
		{
			var objects__handle__ = objects.GetHandle ();
			var keys__handle__ = keys.GetHandle ();
			NSDictionary? ret;
			ret =  Runtime.GetNSObject<NSDictionary> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_IntPtr (class_ptr, Selector.GetHandle ("dictionaryWithObjects:forKeys:count:"), objects__handle__, keys__handle__, count), false)!;
			GC.KeepAlive (objects);
			GC.KeepAlive (keys);
			return ret!;
		}
		[Export ("dictionaryWithObjects:forKeys:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static NSDictionary FromObjectsAndKeysInternal (NSArray objects, NSArray keys)
		{
			var objects__handle__ = objects!.GetNonNullHandle (nameof (objects));
			var keys__handle__ = keys!.GetNonNullHandle (nameof (keys));
			NSDictionary? ret;
			ret =  Runtime.GetNSObject<NSDictionary> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (class_ptr, Selector.GetHandle ("dictionaryWithObjects:forKeys:"), objects__handle__, keys__handle__), false)!;
			GC.KeepAlive (objects);
			GC.KeepAlive (keys);
			return ret!;
		}
		[Export ("dictionaryWithContentsOfURL:")]
		[ObsoletedOSPlatform ("macos10.15", "Use 'NSMutableDictionary.FromUrl' instead.")]
		[ObsoletedOSPlatform ("ios13.0", "Use 'NSMutableDictionary.FromUrl' instead.")]
		[ObsoletedOSPlatform ("tvos13.0", "Use 'NSMutableDictionary.FromUrl' instead.")]
		[ObsoletedOSPlatform ("maccatalyst13.1", "Use 'NSMutableDictionary.FromUrl' instead.")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSDictionary FromUrl (NSUrl url)
		{
			var url__handle__ = url!.GetNonNullHandle (nameof (url));
			NSDictionary? ret;
			ret =  Runtime.GetNSObject<NSDictionary> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (class_ptr, Selector.GetHandle ("dictionaryWithContentsOfURL:"), url__handle__), false)!;
			GC.KeepAlive (url);
			return ret!;
		}
		[Export ("dictionaryWithContentsOfURL:error:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static NSDictionary<NSString, NSObject>? FromUrl (NSUrl url, out NSError error)
		{
			var url__handle__ = url!.GetNonNullHandle (nameof (url));
			NativeHandle errorValue = IntPtr.Zero;
			NSDictionary<NSString, NSObject>? ret;
			ret =  Runtime.GetNSObject<NSDictionary<NSString, NSObject>> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_ref_NativeHandle (class_ptr, Selector.GetHandle ("dictionaryWithContentsOfURL:error:"), url__handle__, &errorValue), false)!;
			GC.KeepAlive (url);
			error = Runtime.GetNSObject<NSError> (errorValue)!;
			return ret!;
		}
		[Export ("descriptionWithLocale:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string GetDescription (NSObject? locale)
		{
			var locale__handle__ = locale.GetHandle ();
			string? ret;
			if (IsDirectBinding) {
				ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("descriptionWithLocale:"), locale__handle__), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle (&__objc_super__, Selector.GetHandle ("descriptionWithLocale:"), locale__handle__), false)!;
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (locale);
			return ret!;
		}
		[Export ("descriptionWithLocale:indent:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string GetDescription (NSObject? locale, nuint level)
		{
			var locale__handle__ = locale.GetHandle ();
			string? ret;
			if (IsDirectBinding) {
				ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_UIntPtr (this.Handle, Selector.GetHandle ("descriptionWithLocale:indent:"), locale__handle__, level), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_UIntPtr (&__objc_super__, Selector.GetHandle ("descriptionWithLocale:indent:"), locale__handle__, level), false)!;
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (locale);
			return ret!;
		}
		[Export ("keysOfEntriesPassingTest:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual NSSet GetKeys ([BlockProxy (typeof (ObjCRuntime.Trampolines.NIDNSDictionaryKeyFilter))]NSDictionaryKeyFilter predicate)
		{
			if (predicate is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (predicate));
			using var block_predicate = Trampolines.SDNSDictionaryKeyFilter.CreateBlock (predicate);
			BlockLiteral *block_ptr_predicate = &block_predicate;
			NSSet ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<NSSet> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("keysOfEntriesPassingTest:"), (IntPtr) block_ptr_predicate), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<NSSet> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle (&__objc_super__, Selector.GetHandle ("keysOfEntriesPassingTest:"), (IntPtr) block_ptr_predicate), false)!;
					GC.KeepAlive (this);
				}
			}
			return ret;
		}
		[Export ("keysOfEntriesWithOptions:passingTest:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual NSSet GetKeys (NSEnumerationOptions options, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDNSDictionaryKeyFilter))]NSDictionaryKeyFilter predicate)
		{
			if (predicate is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (predicate));
			using var block_predicate = Trampolines.SDNSDictionaryKeyFilter.CreateBlock (predicate);
			BlockLiteral *block_ptr_predicate = &block_predicate;
			NSSet ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<NSSet> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_UIntPtr_NativeHandle (this.Handle, Selector.GetHandle ("keysOfEntriesWithOptions:passingTest:"), (UIntPtr) (ulong) options, (IntPtr) block_ptr_predicate), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<NSSet> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_UIntPtr_NativeHandle (&__objc_super__, Selector.GetHandle ("keysOfEntriesWithOptions:passingTest:"), (UIntPtr) (ulong) options, (IntPtr) block_ptr_predicate), false)!;
					GC.KeepAlive (this);
				}
			}
			return ret;
		}
		[Export ("keysSortedByValueUsingComparator:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual NSObject[] GetKeysSortedByValue ([BlockProxy (typeof (ObjCRuntime.Trampolines.NIDNSComparator))]NSComparator comparator)
		{
			if (comparator is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (comparator));
			using var block_comparator = Trampolines.SDNSComparator.CreateBlock (comparator);
			BlockLiteral *block_ptr_comparator = &block_comparator;
			NSObject[] ret;
			if (IsDirectBinding) {
				ret = CFArray.ArrayFromHandle<NSObject>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("keysSortedByValueUsingComparator:"), (IntPtr) block_ptr_comparator), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = CFArray.ArrayFromHandle<NSObject>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle (&__objc_super__, Selector.GetHandle ("keysSortedByValueUsingComparator:"), (IntPtr) block_ptr_comparator), false)!;
					GC.KeepAlive (this);
				}
			}
			return ret;
		}
		[Export ("keysSortedByValueWithOptions:usingComparator:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual NSObject[] GetKeysSortedByValue (NSSortOptions options, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDNSComparator))]NSComparator comparator)
		{
			if (comparator is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (comparator));
			using var block_comparator = Trampolines.SDNSComparator.CreateBlock (comparator);
			BlockLiteral *block_ptr_comparator = &block_comparator;
			NSObject[] ret;
			if (IsDirectBinding) {
				ret = CFArray.ArrayFromHandle<NSObject>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_UIntPtr_NativeHandle (this.Handle, Selector.GetHandle ("keysSortedByValueWithOptions:usingComparator:"), (UIntPtr) (ulong) options, (IntPtr) block_ptr_comparator), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = CFArray.ArrayFromHandle<NSObject>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_UIntPtr_NativeHandle (&__objc_super__, Selector.GetHandle ("keysSortedByValueWithOptions:usingComparator:"), (UIntPtr) (ulong) options, (IntPtr) block_ptr_comparator), false)!;
					GC.KeepAlive (this);
				}
			}
			return ret;
		}
		[Export ("sharedKeySetForKeys:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSObject GetSharedKeySetForKeys (NSObject[] keys)
		{
			if (keys is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (keys));
			using var nsa_keys = NSArray.FromNSObjects (keys);
			NSObject ret;
			ret = Runtime.GetNSObject (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (class_ptr, Selector.GetHandle ("sharedKeySetForKeys:"), nsa_keys.Handle), false)!;
			return ret;
		}
		[Export ("isEqualToDictionary:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool IsEqualToDictionary (NSDictionary other)
		{
			var other__handle__ = other!.GetNonNullHandle (nameof (other));
			byte ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("isEqualToDictionary:"), other__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper_NativeHandle (&__objc_super__, Selector.GetHandle ("isEqualToDictionary:"), other__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (other);
			return ret != 0;
		}
		[Export ("allKeysForObject:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSObject[] KeysForObject (NSObject obj)
		{
			using (var autorelease_pool = new NSAutoreleasePool ()) {
				var obj__handle__ = obj!.GetNonNullHandle (nameof (obj));
				NSObject[]? ret;
				if (IsDirectBinding) {
					ret = CFArray.ArrayFromHandle<NSObject>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("allKeysForObject:"), obj__handle__), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFArray.ArrayFromHandle<NSObject>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle (&__objc_super__, Selector.GetHandle ("allKeysForObject:"), obj__handle__), false)!;
						GC.KeepAlive (this);
					}
				}
				GC.KeepAlive (obj);
				return ret!;
			}
		}
		/// <param name="zone">Zone to use to allocate this object, or null to use the default zone.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("mutableCopyWithZone:")]
		[return: ReleaseAttribute ()]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSObject MutableCopy (NSZone? zone)
		{
			var zone__handle__ = zone.GetHandle ();
			NSObject? ret;
			if (IsDirectBinding) {
				ret = Runtime.GetNSObject (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("mutableCopyWithZone:"), zone__handle__), true)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = Runtime.GetNSObject (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle (&__objc_super__, Selector.GetHandle ("mutableCopyWithZone:"), zone__handle__), true)!;
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (zone);
			return ret!;
		}
		[Export ("objectForKey:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSObject? ObjectForKey (NSObject key)
		{
			var key__handle__ = key!.GetNonNullHandle (nameof (key));
			NSObject? ret;
			if (IsDirectBinding) {
				ret = Runtime.GetNSObject (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("objectForKey:"), key__handle__), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = Runtime.GetNSObject (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle (&__objc_super__, Selector.GetHandle ("objectForKey:"), key__handle__), false)!;
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (key);
			return ret!;
		}
		[Export ("objectsForKeys:notFoundMarker:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSObject[] ObjectsForKeys (NSArray keys, NSObject marker)
		{
			using (var autorelease_pool = new NSAutoreleasePool ()) {
				var keys__handle__ = keys!.GetNonNullHandle (nameof (keys));
				var marker__handle__ = marker!.GetNonNullHandle (nameof (marker));
				NSObject[]? ret;
				if (IsDirectBinding) {
					ret = CFArray.ArrayFromHandle<NSObject>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("objectsForKeys:notFoundMarker:"), keys__handle__, marker__handle__), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFArray.ArrayFromHandle<NSObject>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, Selector.GetHandle ("objectsForKeys:notFoundMarker:"), keys__handle__, marker__handle__), false)!;
						GC.KeepAlive (this);
					}
				}
				GC.KeepAlive (keys);
				GC.KeepAlive (marker);
				return ret!;
			}
		}
		[Export ("valueForKey:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSObject? ValueForKey (NSString key)
		{
			var key__handle__ = key!.GetNonNullHandle (nameof (key));
			IntPtr exception_gchandle = IntPtr.Zero;
			NSObject? ret;
			if (IsDirectBinding) {
				ret = Runtime.GetNSObject (global::ObjCRuntime.Messaging.xamarin_NativeHandle_objc_msgSend_NativeHandle_exception (this.Handle, Selector.GetHandle ("valueForKey:"), key__handle__, &exception_gchandle), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = Runtime.GetNSObject (global::ObjCRuntime.Messaging.xamarin_NativeHandle_objc_msgSendSuper_NativeHandle_exception (&__objc_super__, Selector.GetHandle ("valueForKey:"), key__handle__, &exception_gchandle), false)!;
					GC.KeepAlive (this);
				}
			}
			Runtime.ThrowException (exception_gchandle);
			GC.KeepAlive (key);
			return ret!;
		}
		[Export ("writeToFile:atomically:")]
		[ObsoletedOSPlatform ("macos10.15")]
		[ObsoletedOSPlatform ("ios13.0")]
		[ObsoletedOSPlatform ("tvos13.0")]
		[ObsoletedOSPlatform ("maccatalyst13.1")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool WriteToFile (string path, bool useAuxiliaryFile)
		{
			if (path is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (path));
			var nspath = CFString.CreateNative (path);
			byte ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_bool (this.Handle, Selector.GetHandle ("writeToFile:atomically:"), nspath, useAuxiliaryFile ? (byte) 1 : (byte) 0);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper_NativeHandle_bool (&__objc_super__, Selector.GetHandle ("writeToFile:atomically:"), nspath, useAuxiliaryFile ? (byte) 1 : (byte) 0);
					GC.KeepAlive (this);
				}
			}
			CFString.ReleaseNative (nspath);
			return ret != 0;
		}
		[Export ("writeToURL:atomically:")]
		[ObsoletedOSPlatform ("macos10.15")]
		[ObsoletedOSPlatform ("ios13.0")]
		[ObsoletedOSPlatform ("tvos13.0")]
		[ObsoletedOSPlatform ("maccatalyst13.1")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool WriteToUrl (NSUrl url, bool atomically)
		{
			var url__handle__ = url!.GetNonNullHandle (nameof (url));
			byte ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_bool (this.Handle, Selector.GetHandle ("writeToURL:atomically:"), url__handle__, atomically ? (byte) 1 : (byte) 0);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper_NativeHandle_bool (&__objc_super__, Selector.GetHandle ("writeToURL:atomically:"), url__handle__, atomically ? (byte) 1 : (byte) 0);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (url);
			return ret != 0;
		}
		[Export ("writeToURL:error:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual bool WriteToUrl (NSUrl url, out NSError? error)
		{
			var url__handle__ = url!.GetNonNullHandle (nameof (url));
			NativeHandle errorValue = IntPtr.Zero;
			byte ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_ref_NativeHandle (this.Handle, Selector.GetHandle ("writeToURL:error:"), url__handle__, &errorValue);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper_NativeHandle_ref_NativeHandle (&__objc_super__, Selector.GetHandle ("writeToURL:error:"), url__handle__, &errorValue);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (url);
			error = Runtime.GetNSObject<NSError> (errorValue)!;
			return ret != 0;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal nint _AllKeys ()
		{
			nint ret;
			ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("allKeys"));
			return ret;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal nint _AllKeysForObject (nint obj)
		{
			nint ret;
			ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("allKeysForObject:"), obj);
			return ret;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal nint _AllValues ()
		{
			nint ret;
			ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("allValues"));
			return ret;
		}
		[Export ("dictionaryWithObjects:forKeys:count:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static nint _FromObjectsAndKeysInternal (nint objects, nint keys, nint count)
		{
			nint ret;
			ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_IntPtr (class_ptr, Selector.GetHandle ("dictionaryWithObjects:forKeys:count:"), objects, keys, count);
			return ret;
		}
		[Export ("dictionaryWithObjects:forKeys:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static nint _FromObjectsAndKeysInternal (nint objects, nint keys)
		{
			nint ret;
			ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr (class_ptr, Selector.GetHandle ("dictionaryWithObjects:forKeys:"), objects, keys);
			return ret;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal nint _ObjectForKey (nint key)
		{
			nint ret;
			ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("objectForKey:"), key);
			return ret;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal nint _ObjectsForKeys (nint keys, nint marker)
		{
			nint ret;
			ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr (this.Handle, Selector.GetHandle ("objectsForKeys:notFoundMarker:"), keys, marker);
			return ret;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual nuint Count {
			[Export ("count")]
			get {
				nuint ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("count"));
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.UIntPtr_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("count"));
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string DescriptionInStringsFileFormat {
			[Export ("descriptionInStringsFileFormat")]
			get {
				string ret;
				if (IsDirectBinding) {
					ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("descriptionInStringsFileFormat")), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("descriptionInStringsFileFormat")), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSEnumerator KeyEnumerator {
			[Export ("keyEnumerator")]
			get {
				NSEnumerator? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSEnumerator> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("keyEnumerator")), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<NSEnumerator> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("keyEnumerator")), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSObject[] Keys {
			[Export ("allKeys")]
			get {
				using (var autorelease_pool = new NSAutoreleasePool ()) {
					NSObject[]? ret;
					if (IsDirectBinding) {
						ret = CFArray.ArrayFromHandle<NSObject>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("allKeys")), false)!;
					} else {
						unsafe {
							var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
							ret = CFArray.ArrayFromHandle<NSObject>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("allKeys")), false)!;
							GC.KeepAlive (this);
						}
					}
					return ret!;
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSEnumerator ObjectEnumerator {
			[Export ("objectEnumerator")]
			get {
				NSEnumerator? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSEnumerator> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("objectEnumerator")), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<NSEnumerator> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("objectEnumerator")), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSObject[] Values {
			[Export ("allValues")]
			get {
				using (var autorelease_pool = new NSAutoreleasePool ()) {
					NSObject[]? ret;
					if (IsDirectBinding) {
						ret = CFArray.ArrayFromHandle<NSObject>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("allValues")), false)!;
					} else {
						unsafe {
							var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
							ret = CFArray.ArrayFromHandle<NSObject>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("allValues")), false)!;
							GC.KeepAlive (this);
						}
					}
					return ret!;
				}
			}
		}
	} /* class NSDictionary */
}
