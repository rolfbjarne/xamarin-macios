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
namespace AppKit {
	[Register("NSFontCollection", true)]
	[UnsupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("macos")]
	public unsafe partial class NSFontCollection : NSObject, INSCoding, INSCopying, INSMutableCopying, INSSecureCoding {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAllFontCollectionNamesX = "allFontCollectionNames";
		static readonly NativeHandle selAllFontCollectionNamesXHandle = Selector.GetHandle ("allFontCollectionNames");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selCopyWithZone_X = "copyWithZone:";
		static readonly NativeHandle selCopyWithZone_XHandle = Selector.GetHandle ("copyWithZone:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selEncodeWithCoder_X = "encodeWithCoder:";
		static readonly NativeHandle selEncodeWithCoder_XHandle = Selector.GetHandle ("encodeWithCoder:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selExclusionDescriptorsX = "exclusionDescriptors";
		static readonly NativeHandle selExclusionDescriptorsXHandle = Selector.GetHandle ("exclusionDescriptors");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selFontCollectionWithAllAvailableDescriptorsX = "fontCollectionWithAllAvailableDescriptors";
		static readonly NativeHandle selFontCollectionWithAllAvailableDescriptorsXHandle = Selector.GetHandle ("fontCollectionWithAllAvailableDescriptors");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selFontCollectionWithDescriptors_X = "fontCollectionWithDescriptors:";
		static readonly NativeHandle selFontCollectionWithDescriptors_XHandle = Selector.GetHandle ("fontCollectionWithDescriptors:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selFontCollectionWithLocale_X = "fontCollectionWithLocale:";
		static readonly NativeHandle selFontCollectionWithLocale_XHandle = Selector.GetHandle ("fontCollectionWithLocale:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selFontCollectionWithName_X = "fontCollectionWithName:";
		static readonly NativeHandle selFontCollectionWithName_XHandle = Selector.GetHandle ("fontCollectionWithName:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selFontCollectionWithName_Visibility_X = "fontCollectionWithName:visibility:";
		static readonly NativeHandle selFontCollectionWithName_Visibility_XHandle = Selector.GetHandle ("fontCollectionWithName:visibility:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selHideFontCollectionWithName_Visibility_Error_X = "hideFontCollectionWithName:visibility:error:";
		static readonly NativeHandle selHideFontCollectionWithName_Visibility_Error_XHandle = Selector.GetHandle ("hideFontCollectionWithName:visibility:error:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selInitWithCoder_X = "initWithCoder:";
		static readonly NativeHandle selInitWithCoder_XHandle = Selector.GetHandle ("initWithCoder:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selMatchingDescriptorsX = "matchingDescriptors";
		static readonly NativeHandle selMatchingDescriptorsXHandle = Selector.GetHandle ("matchingDescriptors");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selMatchingDescriptorsForFamily_X = "matchingDescriptorsForFamily:";
		static readonly NativeHandle selMatchingDescriptorsForFamily_XHandle = Selector.GetHandle ("matchingDescriptorsForFamily:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selMatchingDescriptorsForFamily_Options_X = "matchingDescriptorsForFamily:options:";
		static readonly NativeHandle selMatchingDescriptorsForFamily_Options_XHandle = Selector.GetHandle ("matchingDescriptorsForFamily:options:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selMatchingDescriptorsWithOptions_X = "matchingDescriptorsWithOptions:";
		static readonly NativeHandle selMatchingDescriptorsWithOptions_XHandle = Selector.GetHandle ("matchingDescriptorsWithOptions:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selMutableCopyWithZone_X = "mutableCopyWithZone:";
		static readonly NativeHandle selMutableCopyWithZone_XHandle = Selector.GetHandle ("mutableCopyWithZone:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selQueryDescriptorsX = "queryDescriptors";
		static readonly NativeHandle selQueryDescriptorsXHandle = Selector.GetHandle ("queryDescriptors");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selRenameFontCollectionWithName_Visibility_ToName_Error_X = "renameFontCollectionWithName:visibility:toName:error:";
		static readonly NativeHandle selRenameFontCollectionWithName_Visibility_ToName_Error_XHandle = Selector.GetHandle ("renameFontCollectionWithName:visibility:toName:error:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selShowFontCollection_WithName_Visibility_Error_X = "showFontCollection:withName:visibility:error:";
		static readonly NativeHandle selShowFontCollection_WithName_Visibility_Error_XHandle = Selector.GetHandle ("showFontCollection:withName:visibility:error:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly NativeHandle class_ptr = Class.GetHandle ("NSFontCollection");
		/// <summary>The Objective-C class handle for this class.</summary>
		/// <value>The pointer to the Objective-C class.</value>
		/// <remarks>
		///     Each managed class mirrors an unmanaged Objective-C class.
		///     This value contains the pointer to the Objective-C class.
		///     It is similar to calling the managed <see cref="ObjCRuntime.Class.GetHandle(string)" /> or the native <see href="https://developer.apple.com/documentation/objectivec/1418952-objc_getclass">objc_getClass</see> method with the type name.
		/// </remarks>
		public override NativeHandle ClassHandle { get { return class_ptr; } }
		/// <summary>Creates a new <see cref="NSFontCollection" /> with default values.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public NSFontCollection () : base (NSObjectFlag.Empty)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
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
		public NSFontCollection (NSCoder coder) : base (NSObjectFlag.Empty)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
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
		protected NSFontCollection (NSObjectFlag t) : base (t)
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
		protected internal NSFontCollection (NativeHandle handle) : base (handle)
		{
		}

		/// <param name="zone">Developers should pass <see langword="null" />.  Memory zones are no longer used.</param><summary>Performs a copy of the underlying Objective-C object.</summary><returns>The newly-allocated object.</returns><remarks><para>This method performs a "shallow copy" of <see langword="this" />. If this object contains references to external objects, the new object will contain references to the same object.</para></remarks>
		[Export ("copyWithZone:")]
		[return: ReleaseAttribute ()]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSObject Copy (NSZone? zone)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
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
		/// <summary>Encodes the state of the object using the provided encoder.</summary><param name="encoder">The encoder object where the state of the object will be stored</param><remarks><para>This method is part of the <see cref="T:Foundation.INSCoding" /> protocol and is used by applications to preserve the state of the object into an archive.</para><para>Developers will typically create an <see cref="T:Foundation.NSKeyedArchiver" /> and then invoke the <see cref="M:Foundation.NSKeyedArchiver.ArchiveRootObjectToFile(Foundation.NSObject,System.String)" /> method which will call into this method.</para><para>If developers want to allow their object to be archived, they should override this method and store their state in using the provided <paramref name="encoder" /> parameter. In addition, developers should also implement a constructor that takes an NSCoder argument and is exported with <c>[Export ("initWithCoder:")]</c>.</para><example><code lang="csharp lang-csharp"><![CDATA[public void override EncodeTo (NSCoder coder) {
		/// coder.Encode (1, key: "version");
		/// coder.Encode (userName, key: "userName");
		/// coder.Encode (hostName, key: "hostName");]]></code></example></remarks>
		[Export ("encodeWithCoder:")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void EncodeTo (NSCoder encoder)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
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
		[Export ("fontCollectionWithDescriptors:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSFontCollection FromDescriptors (NSFontDescriptor[] queryDescriptors)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			if (queryDescriptors is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (queryDescriptors));
			using var nsa_queryDescriptors = NSArray.FromNSObjects (queryDescriptors);
			NSFontCollection ret;
			ret =  Runtime.GetNSObject<NSFontCollection> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (class_ptr, selFontCollectionWithDescriptors_XHandle, nsa_queryDescriptors.Handle), false)!;
			return ret;
		}
		[Export ("fontCollectionWithLocale:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSFontCollection FromLocale (NSLocale locale)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var locale__handle__ = locale!.GetNonNullHandle (nameof (locale));
			NSFontCollection? ret;
			ret =  Runtime.GetNSObject<NSFontCollection> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (class_ptr, selFontCollectionWithLocale_XHandle, locale__handle__), false)!;
			GC.KeepAlive (locale);
			return ret!;
		}
		[Export ("fontCollectionWithName:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSFontCollection FromName (string name)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			if (name is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (name));
			var nsname = CFString.CreateNative (name);
			NSFontCollection? ret;
			ret =  Runtime.GetNSObject<NSFontCollection> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (class_ptr, selFontCollectionWithName_XHandle, nsname), false)!;
			CFString.ReleaseNative (nsname);
			return ret!;
		}
		[Export ("fontCollectionWithName:visibility:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSFontCollection FromName (string name, NSFontCollectionVisibility visibility)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			if (name is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (name));
			var nsname = CFString.CreateNative (name);
			NSFontCollection? ret;
			ret =  Runtime.GetNSObject<NSFontCollection> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_UIntPtr (class_ptr, selFontCollectionWithName_Visibility_XHandle, nsname, (UIntPtr) (ulong) visibility), false)!;
			CFString.ReleaseNative (nsname);
			return ret!;
		}
		[Export ("fontCollectionWithAllAvailableDescriptors")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSFontCollection GetAllAvailableFonts ()
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			NSFontCollection ret;
			ret =  Runtime.GetNSObject<NSFontCollection> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (class_ptr, selFontCollectionWithAllAvailableDescriptorsXHandle), false)!;
			return ret;
		}
		[Export ("exclusionDescriptors")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSFontDescriptor[] GetExclusionDescriptors ()
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			NSFontDescriptor[] ret;
			if (IsDirectBinding) {
				ret = CFArray.ArrayFromHandle<NSFontDescriptor>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selExclusionDescriptorsXHandle), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = CFArray.ArrayFromHandle<NSFontDescriptor>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selExclusionDescriptorsXHandle), false)!;
					GC.KeepAlive (this);
				}
			}
			return ret;
		}
		[Export ("matchingDescriptors")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSFontDescriptor[] GetMatchingDescriptors ()
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			NSFontDescriptor[] ret;
			if (IsDirectBinding) {
				ret = CFArray.ArrayFromHandle<NSFontDescriptor>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selMatchingDescriptorsXHandle), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = CFArray.ArrayFromHandle<NSFontDescriptor>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selMatchingDescriptorsXHandle), false)!;
					GC.KeepAlive (this);
				}
			}
			return ret;
		}
		[Export ("matchingDescriptorsWithOptions:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSFontDescriptor[] GetMatchingDescriptors (NSDictionary options)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var options__handle__ = options!.GetNonNullHandle (nameof (options));
			NSFontDescriptor[]? ret;
			if (IsDirectBinding) {
				ret = CFArray.ArrayFromHandle<NSFontDescriptor>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, selMatchingDescriptorsWithOptions_XHandle, options__handle__), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = CFArray.ArrayFromHandle<NSFontDescriptor>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle (&__objc_super__, selMatchingDescriptorsWithOptions_XHandle, options__handle__), false)!;
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (options);
			return ret!;
		}
		[Export ("matchingDescriptorsForFamily:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSFontDescriptor[] GetMatchingDescriptors (string family)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			if (family is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (family));
			var nsfamily = CFString.CreateNative (family);
			NSFontDescriptor[]? ret;
			if (IsDirectBinding) {
				ret = CFArray.ArrayFromHandle<NSFontDescriptor>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, selMatchingDescriptorsForFamily_XHandle, nsfamily), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = CFArray.ArrayFromHandle<NSFontDescriptor>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle (&__objc_super__, selMatchingDescriptorsForFamily_XHandle, nsfamily), false)!;
					GC.KeepAlive (this);
				}
			}
			CFString.ReleaseNative (nsfamily);
			return ret!;
		}
		[Export ("matchingDescriptorsForFamily:options:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSFontDescriptor[] GetMatchingDescriptors (string family, NSDictionary options)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			if (family is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (family));
			var options__handle__ = options!.GetNonNullHandle (nameof (options));
			var nsfamily = CFString.CreateNative (family);
			NSFontDescriptor[]? ret;
			if (IsDirectBinding) {
				ret = CFArray.ArrayFromHandle<NSFontDescriptor>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (this.Handle, selMatchingDescriptorsForFamily_Options_XHandle, nsfamily, options__handle__), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = CFArray.ArrayFromHandle<NSFontDescriptor>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, selMatchingDescriptorsForFamily_Options_XHandle, nsfamily, options__handle__), false)!;
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (options);
			CFString.ReleaseNative (nsfamily);
			return ret!;
		}
		[Export ("queryDescriptors")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSFontDescriptor[] GetQueryDescriptors ()
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			NSFontDescriptor[] ret;
			if (IsDirectBinding) {
				ret = CFArray.ArrayFromHandle<NSFontDescriptor>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selQueryDescriptorsXHandle), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = CFArray.ArrayFromHandle<NSFontDescriptor>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selQueryDescriptorsXHandle), false)!;
					GC.KeepAlive (this);
				}
			}
			return ret;
		}
		[Export ("hideFontCollectionWithName:visibility:error:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static bool HideFontCollection (string name, NSFontCollectionVisibility visibility, out NSError error)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			if (name is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (name));
			NativeHandle errorValue = IntPtr.Zero;
			var nsname = CFString.CreateNative (name);
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_UIntPtr_ref_NativeHandle (class_ptr, selHideFontCollectionWithName_Visibility_Error_XHandle, nsname, (UIntPtr) (ulong) visibility, &errorValue);
			CFString.ReleaseNative (nsname);
			error = Runtime.GetNSObject<NSError> (errorValue)!;
			return ret != 0;
		}
		/// <param name="zone">Zone to use to allocate this object, or null to use the default zone.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("mutableCopyWithZone:")]
		[return: ReleaseAttribute ()]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSObject MutableCopy (NSZone? zone)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var zone__handle__ = zone.GetHandle ();
			NSObject? ret;
			if (IsDirectBinding) {
				ret = Runtime.GetNSObject (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, selMutableCopyWithZone_XHandle, zone__handle__), true)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = Runtime.GetNSObject (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle (&__objc_super__, selMutableCopyWithZone_XHandle, zone__handle__), true)!;
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (zone);
			return ret!;
		}
		[Export ("renameFontCollectionWithName:visibility:toName:error:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static bool RenameFontCollection (string fromName, NSFontCollectionVisibility visibility, string toName, out NSError error)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			if (fromName is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (fromName));
			if (toName is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (toName));
			NativeHandle errorValue = IntPtr.Zero;
			var nsfromName = CFString.CreateNative (fromName);
			var nstoName = CFString.CreateNative (toName);
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_UIntPtr_NativeHandle_ref_NativeHandle (class_ptr, selRenameFontCollectionWithName_Visibility_ToName_Error_XHandle, nsfromName, (UIntPtr) (ulong) visibility, nstoName, &errorValue);
			CFString.ReleaseNative (nsfromName);
			CFString.ReleaseNative (nstoName);
			error = Runtime.GetNSObject<NSError> (errorValue)!;
			return ret != 0;
		}
		[Export ("showFontCollection:withName:visibility:error:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static bool ShowFontCollection (NSFontCollection fontCollection, string name, NSFontCollectionVisibility visibility, out NSError error)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var fontCollection__handle__ = fontCollection!.GetNonNullHandle (nameof (fontCollection));
			if (name is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (name));
			NativeHandle errorValue = IntPtr.Zero;
			var nsname = CFString.CreateNative (name);
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_NativeHandle_UIntPtr_ref_NativeHandle (class_ptr, selShowFontCollection_WithName_Visibility_Error_XHandle, fontCollection__handle__, nsname, (UIntPtr) (ulong) visibility, &errorValue);
			GC.KeepAlive (fontCollection);
			CFString.ReleaseNative (nsname);
			error = Runtime.GetNSObject<NSError> (errorValue)!;
			return ret != 0;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static string[] AllFontCollectionNames {
			[Export ("allFontCollectionNames", ArgumentSemantic.Copy)]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				string[] ret;
				ret = CFArray.StringArrayFromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (class_ptr, selAllFontCollectionNamesXHandle), false)!;
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ActionKey;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("NSFontCollectionActionKey",  "AppKit")]
		public static NSString ActionKey {
			get {
				if (_ActionKey is null)
					_ActionKey = Dlfcn.GetStringConstant (Libraries.AppKit.Handle, "NSFontCollectionActionKey")!;
				return _ActionKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ActionWasHidden;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("NSFontCollectionWasHidden",  "AppKit")]
		public static NSString ActionWasHidden {
			get {
				if (_ActionWasHidden is null)
					_ActionWasHidden = Dlfcn.GetStringConstant (Libraries.AppKit.Handle, "NSFontCollectionWasHidden")!;
				return _ActionWasHidden;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ActionWasRenamed;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("NSFontCollectionWasRenamed",  "AppKit")]
		public static NSString ActionWasRenamed {
			get {
				if (_ActionWasRenamed is null)
					_ActionWasRenamed = Dlfcn.GetStringConstant (Libraries.AppKit.Handle, "NSFontCollectionWasRenamed")!;
				return _ActionWasRenamed;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ActionWasShown;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("NSFontCollectionWasShown",  "AppKit")]
		public static NSString ActionWasShown {
			get {
				if (_ActionWasShown is null)
					_ActionWasShown = Dlfcn.GetStringConstant (Libraries.AppKit.Handle, "NSFontCollectionWasShown")!;
				return _ActionWasShown;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ChangedNotification;
		/// <summary>Notification constant for Changed</summary>
		/// <value><see cref="NSString" /> constant, should be used as a token to <see cref="NSNotificationCenter" />.</value>
		/// <remarks>
		///   <para>
		///     This constant can be used with <see cref="NSNotificationCenter" /> to register a listener for this notification.
		///     This is an <see cref="NSString" /> instead of a string, because these values can be used as tokens in some native
		///     libraries instead of being used purely for their actual string content. The 'notification' parameter to the callback
		///     contains extra information that is specific to the notification type.
		///   </para>
		///   <para>
		///     To subscribe to this notification, developers can use the convenience <see cref="Notifications.ObserveChanged(NSObject,EventHandler{NSFontCollectionChangedEventArgs})" />
		///     or <see cref="Notifications.ObserveChanged(EventHandler{NSFontCollectionChangedEventArgs})" /> methods,
		///     which offers strongly typed access to the parameters of the notification.
		///   </para>
		///   <para>
		///     The following example shows how to use the strongly typed <see cref="Notifications" /> class, to take the guesswork
		///     out of the available properties in the notification:
		///   </para>
		///   <example>
		///     <code lang="csharp lang-csharp"><![CDATA[
		/// //
		/// // Lambda style
		/// //
		///
		/// // listening
		/// notification = NSFontCollection.Notifications.ObserveChanged ((sender, args) => {
		/// /* Access strongly typed args */
		/// Console.WriteLine ("Notification: {0}", args.Notification);
		/// });
		///
		/// // To stop listening:
		/// notification.Dispose ();
		///
		/// //
		/// // Method style
		/// //
		/// NSObject notification;
		/// void Callback (object sender, NSFontCollection.NSFontCollectionChangedEventArgs args)
		/// {
		///     // Access strongly typed args
		///     Console.WriteLine ("Notification: {0}", args.Notification);
		/// }
		///
		/// void Setup ()
		/// {
		///     notification = NSFontCollection.Notifications.ObserveChanged (Callback);
		/// }
		///
		/// void Teardown ()
		/// {
		///     notification.Dispose ();
		/// }]]></code>
		///   </example>
		///   <para>
		///     The following example shows how to use the notification with the DefaultCenter API:
		///   </para>
		///   <example>
		///     <code lang="csharp lang-csharp"><![CDATA[
		/// // Lambda style
		/// NSNotificationCenter.DefaultCenter.AddObserver (
		///     NSFontCollection.ChangedNotification, (notification) => { Console.WriteLine ("Received the notification Changed", notification); }
		/// );
		///
		/// // Method style
		/// void Callback (NSNotification notification)
		/// {
		///     Console.WriteLine ("Received the notification Changed", notification);
		/// }
		///
		/// void Setup ()
		/// {
		///     NSNotificationCenter.DefaultCenter.AddObserver (NSFontCollection.ChangedNotification, Callback);
		/// }
		/// ]]></code>
		///   </example>
		/// </remarks>
		[Field ("NSFontCollectionDidChangeNotification",  "AppKit")]
		[Advice ("Use NSFontCollection.Notifications.ObserveChanged helper method instead.")]
		public static NSString ChangedNotification {
			get {
				if (_ChangedNotification is null)
					_ChangedNotification = Dlfcn.GetStringConstant (Libraries.AppKit.Handle, "NSFontCollectionDidChangeNotification")!;
				return _ChangedNotification;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _DisallowAutoActivationOption;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("NSFontCollectionDisallowAutoActivationOption",  "AppKit")]
		public static NSString DisallowAutoActivationOption {
			get {
				if (_DisallowAutoActivationOption is null)
					_DisallowAutoActivationOption = Dlfcn.GetStringConstant (Libraries.AppKit.Handle, "NSFontCollectionDisallowAutoActivationOption")!;
				return _DisallowAutoActivationOption;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _IncludeDisabledFontsOption;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("NSFontCollectionIncludeDisabledFontsOption",  "AppKit")]
		public static NSString IncludeDisabledFontsOption {
			get {
				if (_IncludeDisabledFontsOption is null)
					_IncludeDisabledFontsOption = Dlfcn.GetStringConstant (Libraries.AppKit.Handle, "NSFontCollectionIncludeDisabledFontsOption")!;
				return _IncludeDisabledFontsOption;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _NameAllFonts;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("NSFontCollectionAllFonts",  "AppKit")]
		public static NSString NameAllFonts {
			get {
				if (_NameAllFonts is null)
					_NameAllFonts = Dlfcn.GetStringConstant (Libraries.AppKit.Handle, "NSFontCollectionAllFonts")!;
				return _NameAllFonts;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _NameFavorites;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("NSFontCollectionFavorites",  "AppKit")]
		public static NSString NameFavorites {
			get {
				if (_NameFavorites is null)
					_NameFavorites = Dlfcn.GetStringConstant (Libraries.AppKit.Handle, "NSFontCollectionFavorites")!;
				return _NameFavorites;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _NameKey;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("NSFontCollectionNameKey",  "AppKit")]
		public static NSString NameKey {
			get {
				if (_NameKey is null)
					_NameKey = Dlfcn.GetStringConstant (Libraries.AppKit.Handle, "NSFontCollectionNameKey")!;
				return _NameKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _NameRecentlyUsed;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("NSFontCollectionRecentlyUsed",  "AppKit")]
		public static NSString NameRecentlyUsed {
			get {
				if (_NameRecentlyUsed is null)
					_NameRecentlyUsed = Dlfcn.GetStringConstant (Libraries.AppKit.Handle, "NSFontCollectionRecentlyUsed")!;
				return _NameRecentlyUsed;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _NameUser;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("NSFontCollectionUser",  "AppKit")]
		public static NSString NameUser {
			get {
				if (_NameUser is null)
					_NameUser = Dlfcn.GetStringConstant (Libraries.AppKit.Handle, "NSFontCollectionUser")!;
				return _NameUser;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _OldNameKey;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("NSFontCollectionOldNameKey",  "AppKit")]
		public static NSString OldNameKey {
			get {
				if (_OldNameKey is null)
					_OldNameKey = Dlfcn.GetStringConstant (Libraries.AppKit.Handle, "NSFontCollectionOldNameKey")!;
				return _OldNameKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _RemoveDuplicatesOption;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("NSFontCollectionRemoveDuplicatesOption",  "AppKit")]
		public static NSString RemoveDuplicatesOption {
			get {
				if (_RemoveDuplicatesOption is null)
					_RemoveDuplicatesOption = Dlfcn.GetStringConstant (Libraries.AppKit.Handle, "NSFontCollectionRemoveDuplicatesOption")!;
				return _RemoveDuplicatesOption;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _VisibilityKey;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("NSFontCollectionVisibilityKey",  "AppKit")]
		public static NSString VisibilityKey {
			get {
				if (_VisibilityKey is null)
					_VisibilityKey = Dlfcn.GetStringConstant (Libraries.AppKit.Handle, "NSFontCollectionVisibilityKey")!;
				return _VisibilityKey;
			}
		}
		//
		// Notifications
		//
		/// <summary>Notifications posted by the <see cref="global::AppKit.NSFontCollection" /> class.</summary>
		/// <remarks>
		///    <para>This class contains various helper methods that allow developers to observe events posted in the notification hub (<see cref="Foundation.NSNotificationCenter" />).</para>
		///    <para>The methods defined in this class post events that invoke the provided method or lambda with a <see cref="Foundation.NSNotificationEventArgs" /> parameter, which contains strongly typed properties for the notification arguments.</para>
		/// </remarks>
		public static partial class Notifications {
			/// <summary>Strongly typed notification for the <see cref="global::AppKit.NSFontCollection.ChangedNotification" /> constant.</summary>
			/// <param name="handler">The handler that responds to the notification when it occurs.</param>
			/// <returns>Token object that can be used to stop receiving notifications by either disposing it or passing it to <see cref="Foundation.NSNotificationCenter.RemoveObservers(System.Collections.Generic.IEnumerable{Foundation.NSObject})" />.</returns>
			/// <remarks>
			///   <para>This method can be used to subscribe to <see cref="global::AppKit.NSFontCollection.ChangedNotification" /> notifications.</para>
			///   <example>
			///   <code lang="csharp lang-csharp"><![CDATA[
			/// // Listen to all notifications posted for any object
			/// var token = NSFontCollection.Notifications.ObserveChanged ((notification) => {
			///   Console.WriteLine ("Observed ChangedNotification!");
			/// };
			/// 
			/// // Stop listening for notifications
			/// token.Dispose ();
			/// ]]></code>
			///   </example>
			/// </remarks>
			public static NSObject ObserveChanged (EventHandler<AppKit.NSFontCollectionChangedEventArgs> handler)
			{
				return NSNotificationCenter.DefaultCenter.AddObserver (ChangedNotification, notification => handler (null, new AppKit.NSFontCollectionChangedEventArgs (notification)));
			}
			/// <summary>Strongly typed notification for the <see cref="global::AppKit.NSFontCollection.ChangedNotification" /> constant.</summary>
			/// <param name="objectToObserve">The specific object to observe.</param>
			/// <param name="handler">The handler that responds to the notification when it occurs.</param>
			/// <returns>Token object that can be used to stop receiving notifications by either disposing it or passing it to <see cref="Foundation.NSNotificationCenter.RemoveObservers(System.Collections.Generic.IEnumerable{Foundation.NSObject})" />.</returns>
			/// <remarks>
			///   <para>This method can be used to subscribe to <see cref="global::AppKit.NSFontCollection.ChangedNotification" /> notifications.</para>
			///   <example>
			///     <code lang="csharp lang-csharp"><![CDATA[
			/// // Listen to all notifications posted for a single object
			/// var token = NSFontCollection.Notifications.ObserveChanged (objectToObserve, (notification) => {
			///   Console.WriteLine ($"Observed ChangedNotification for {nameof (objectToObserve)}!");
			/// };
			/// 
			/// // Stop listening for notifications
			/// token.Dispose ();
			/// ]]></code>
			///   </example>
			/// </remarks>
			public static NSObject ObserveChanged (NSObject objectToObserve, EventHandler<AppKit.NSFontCollectionChangedEventArgs> handler)
			{
				return NSNotificationCenter.DefaultCenter.AddObserver (ChangedNotification, notification => handler (null, new AppKit.NSFontCollectionChangedEventArgs (notification)), objectToObserve);
			}
		}
	} /* class NSFontCollection */
}
