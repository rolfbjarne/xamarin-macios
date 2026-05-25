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
	[Register("NSFontDescriptor", true)]
	[UnsupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("macos")]
	public unsafe partial class NSFontDescriptor : NSObject, INSCoding, INSCopying, INSSecureCoding {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selCopyWithZone_X = "copyWithZone:";
		static readonly NativeHandle selCopyWithZone_XHandle = Selector.GetHandle ("copyWithZone:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selEncodeWithCoder_X = "encodeWithCoder:";
		static readonly NativeHandle selEncodeWithCoder_XHandle = Selector.GetHandle ("encodeWithCoder:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selFontAttributesX = "fontAttributes";
		static readonly NativeHandle selFontAttributesXHandle = Selector.GetHandle ("fontAttributes");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selFontDescriptorByAddingAttributes_X = "fontDescriptorByAddingAttributes:";
		static readonly NativeHandle selFontDescriptorByAddingAttributes_XHandle = Selector.GetHandle ("fontDescriptorByAddingAttributes:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selFontDescriptorWithDesign_X = "fontDescriptorWithDesign:";
		static readonly NativeHandle selFontDescriptorWithDesign_XHandle = Selector.GetHandle ("fontDescriptorWithDesign:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selFontDescriptorWithFace_X = "fontDescriptorWithFace:";
		static readonly NativeHandle selFontDescriptorWithFace_XHandle = Selector.GetHandle ("fontDescriptorWithFace:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selFontDescriptorWithFamily_X = "fontDescriptorWithFamily:";
		static readonly NativeHandle selFontDescriptorWithFamily_XHandle = Selector.GetHandle ("fontDescriptorWithFamily:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selFontDescriptorWithFontAttributes_X = "fontDescriptorWithFontAttributes:";
		static readonly NativeHandle selFontDescriptorWithFontAttributes_XHandle = Selector.GetHandle ("fontDescriptorWithFontAttributes:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selFontDescriptorWithMatrix_X = "fontDescriptorWithMatrix:";
		static readonly NativeHandle selFontDescriptorWithMatrix_XHandle = Selector.GetHandle ("fontDescriptorWithMatrix:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selFontDescriptorWithName_Matrix_X = "fontDescriptorWithName:matrix:";
		static readonly NativeHandle selFontDescriptorWithName_Matrix_XHandle = Selector.GetHandle ("fontDescriptorWithName:matrix:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selFontDescriptorWithName_Size_X = "fontDescriptorWithName:size:";
		static readonly NativeHandle selFontDescriptorWithName_Size_XHandle = Selector.GetHandle ("fontDescriptorWithName:size:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selFontDescriptorWithSize_X = "fontDescriptorWithSize:";
		static readonly NativeHandle selFontDescriptorWithSize_XHandle = Selector.GetHandle ("fontDescriptorWithSize:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selFontDescriptorWithSymbolicTraits_X = "fontDescriptorWithSymbolicTraits:";
		static readonly NativeHandle selFontDescriptorWithSymbolicTraits_XHandle = Selector.GetHandle ("fontDescriptorWithSymbolicTraits:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selInitWithCoder_X = "initWithCoder:";
		static readonly NativeHandle selInitWithCoder_XHandle = Selector.GetHandle ("initWithCoder:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selInitWithFontAttributes_X = "initWithFontAttributes:";
		static readonly NativeHandle selInitWithFontAttributes_XHandle = Selector.GetHandle ("initWithFontAttributes:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selMatchingFontDescriptorWithMandatoryKeys_X = "matchingFontDescriptorWithMandatoryKeys:";
		static readonly NativeHandle selMatchingFontDescriptorWithMandatoryKeys_XHandle = Selector.GetHandle ("matchingFontDescriptorWithMandatoryKeys:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selMatchingFontDescriptorsWithMandatoryKeys_X = "matchingFontDescriptorsWithMandatoryKeys:";
		static readonly NativeHandle selMatchingFontDescriptorsWithMandatoryKeys_XHandle = Selector.GetHandle ("matchingFontDescriptorsWithMandatoryKeys:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selMatrixX = "matrix";
		static readonly NativeHandle selMatrixXHandle = Selector.GetHandle ("matrix");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selObjectForKey_X = "objectForKey:";
		static readonly NativeHandle selObjectForKey_XHandle = Selector.GetHandle ("objectForKey:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selPointSizeX = "pointSize";
		static readonly NativeHandle selPointSizeXHandle = Selector.GetHandle ("pointSize");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selPostscriptNameX = "postscriptName";
		static readonly NativeHandle selPostscriptNameXHandle = Selector.GetHandle ("postscriptName");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selPreferredFontDescriptorForTextStyle_Options_X = "preferredFontDescriptorForTextStyle:options:";
		static readonly NativeHandle selPreferredFontDescriptorForTextStyle_Options_XHandle = Selector.GetHandle ("preferredFontDescriptorForTextStyle:options:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selRequiresFontAssetRequestX = "requiresFontAssetRequest";
		static readonly NativeHandle selRequiresFontAssetRequestXHandle = Selector.GetHandle ("requiresFontAssetRequest");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSymbolicTraitsX = "symbolicTraits";
		static readonly NativeHandle selSymbolicTraitsXHandle = Selector.GetHandle ("symbolicTraits");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly NativeHandle class_ptr = Class.GetHandle ("NSFontDescriptor");
		/// <summary>The Objective-C class handle for this class.</summary>
		/// <value>The pointer to the Objective-C class.</value>
		/// <remarks>
		///     Each managed class mirrors an unmanaged Objective-C class.
		///     This value contains the pointer to the Objective-C class.
		///     It is similar to calling the managed <see cref="ObjCRuntime.Class.GetHandle(string)" /> or the native <see href="https://developer.apple.com/documentation/objectivec/1418952-objc_getclass">objc_getClass</see> method with the type name.
		/// </remarks>
		public override NativeHandle ClassHandle { get { return class_ptr; } }
		/// <summary>Creates a new <see cref="NSFontDescriptor" /> with default values.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public NSFontDescriptor () : base (NSObjectFlag.Empty)
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
		public NSFontDescriptor (NSCoder coder) : base (NSObjectFlag.Empty)
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
		protected NSFontDescriptor (NSObjectFlag t) : base (t)
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
		protected internal NSFontDescriptor (NativeHandle handle) : base (handle)
		{
		}

		[Export ("initWithFontAttributes:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public NSFontDescriptor (NSDictionary? attributes)
			: base (NSObjectFlag.Empty)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var attributes__handle__ = attributes.GetHandle ();
			if (IsDirectBinding) {
				InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, selInitWithFontAttributes_XHandle, attributes__handle__), "initWithFontAttributes:");
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle (&__objc_super__, selInitWithFontAttributes_XHandle, attributes__handle__), "initWithFontAttributes:");
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (attributes);
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
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSFontDescriptor? Create (NSFontDescriptorSystemDesign design)
		{
			return Create (design.GetConstant ()!);
		}
		[Export ("fontDescriptorWithDesign:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSFontDescriptor? Create (NSString design)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var design__handle__ = design!.GetNonNullHandle (nameof (design));
			NSFontDescriptor? ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<NSFontDescriptor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, selFontDescriptorWithDesign_XHandle, design__handle__), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<NSFontDescriptor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle (&__objc_super__, selFontDescriptorWithDesign_XHandle, design__handle__), false)!;
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (design);
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
		[Export ("fontDescriptorByAddingAttributes:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSFontDescriptor FontDescriptorByAddingAttributes (NSDictionary attributes)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var attributes__handle__ = attributes!.GetNonNullHandle (nameof (attributes));
			NSFontDescriptor? ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<NSFontDescriptor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, selFontDescriptorByAddingAttributes_XHandle, attributes__handle__), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<NSFontDescriptor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle (&__objc_super__, selFontDescriptorByAddingAttributes_XHandle, attributes__handle__), false)!;
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (attributes);
			return ret!;
		}
		[Export ("fontDescriptorWithFace:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSFontDescriptor FontDescriptorWithFace (string newFace)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			if (newFace is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (newFace));
			var nsnewFace = CFString.CreateNative (newFace);
			NSFontDescriptor? ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<NSFontDescriptor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, selFontDescriptorWithFace_XHandle, nsnewFace), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<NSFontDescriptor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle (&__objc_super__, selFontDescriptorWithFace_XHandle, nsnewFace), false)!;
					GC.KeepAlive (this);
				}
			}
			CFString.ReleaseNative (nsnewFace);
			return ret!;
		}
		[Export ("fontDescriptorWithFamily:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSFontDescriptor FontDescriptorWithFamily (string newFamily)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			if (newFamily is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (newFamily));
			var nsnewFamily = CFString.CreateNative (newFamily);
			NSFontDescriptor? ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<NSFontDescriptor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, selFontDescriptorWithFamily_XHandle, nsnewFamily), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<NSFontDescriptor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle (&__objc_super__, selFontDescriptorWithFamily_XHandle, nsnewFamily), false)!;
					GC.KeepAlive (this);
				}
			}
			CFString.ReleaseNative (nsnewFamily);
			return ret!;
		}
		[Export ("fontDescriptorWithMatrix:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSFontDescriptor FontDescriptorWithMatrix (NSAffineTransform matrix)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var matrix__handle__ = matrix!.GetNonNullHandle (nameof (matrix));
			NSFontDescriptor? ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<NSFontDescriptor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, selFontDescriptorWithMatrix_XHandle, matrix__handle__), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<NSFontDescriptor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle (&__objc_super__, selFontDescriptorWithMatrix_XHandle, matrix__handle__), false)!;
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (matrix);
			return ret!;
		}
		[Export ("fontDescriptorWithSize:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSFontDescriptor FontDescriptorWithSize (nfloat newPointSize)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			NSFontDescriptor ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<NSFontDescriptor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_nfloat (this.Handle, selFontDescriptorWithSize_XHandle, newPointSize), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<NSFontDescriptor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_nfloat (&__objc_super__, selFontDescriptorWithSize_XHandle, newPointSize), false)!;
					GC.KeepAlive (this);
				}
			}
			return ret;
		}
		[Export ("fontDescriptorWithSymbolicTraits:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSFontDescriptor FontDescriptorWithSymbolicTraits (NSFontSymbolicTraits symbolicTraits)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			NSFontDescriptor ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<NSFontDescriptor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_int (this.Handle, selFontDescriptorWithSymbolicTraits_XHandle, (int)symbolicTraits), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<NSFontDescriptor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_int (&__objc_super__, selFontDescriptorWithSymbolicTraits_XHandle, (int)symbolicTraits), false)!;
					GC.KeepAlive (this);
				}
			}
			return ret;
		}
		[Export ("fontDescriptorWithFontAttributes:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSFontDescriptor FromAttributes (NSDictionary attributes)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var attributes__handle__ = attributes!.GetNonNullHandle (nameof (attributes));
			NSFontDescriptor? ret;
			ret =  Runtime.GetNSObject<NSFontDescriptor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (class_ptr, selFontDescriptorWithFontAttributes_XHandle, attributes__handle__), false)!;
			GC.KeepAlive (attributes);
			return ret!;
		}
		[Export ("fontDescriptorWithName:matrix:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSFontDescriptor FromNameMatrix (string fontName, NSAffineTransform matrix)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			if (fontName is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (fontName));
			var matrix__handle__ = matrix!.GetNonNullHandle (nameof (matrix));
			var nsfontName = CFString.CreateNative (fontName);
			NSFontDescriptor? ret;
			ret =  Runtime.GetNSObject<NSFontDescriptor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (class_ptr, selFontDescriptorWithName_Matrix_XHandle, nsfontName, matrix__handle__), false)!;
			GC.KeepAlive (matrix);
			CFString.ReleaseNative (nsfontName);
			return ret!;
		}
		[Export ("fontDescriptorWithName:size:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSFontDescriptor FromNameSize (string fontName, nfloat size)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			if (fontName is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (fontName));
			var nsfontName = CFString.CreateNative (fontName);
			NSFontDescriptor? ret;
			ret =  Runtime.GetNSObject<NSFontDescriptor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_nfloat (class_ptr, selFontDescriptorWithName_Size_XHandle, nsfontName, size), false)!;
			CFString.ReleaseNative (nsfontName);
			return ret!;
		}
		[Export ("preferredFontDescriptorForTextStyle:options:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSFontDescriptor GetPreferredFont (string textStyle, NSDictionary options)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			if (textStyle is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (textStyle));
			var options__handle__ = options!.GetNonNullHandle (nameof (options));
			var nstextStyle = CFString.CreateNative (textStyle);
			NSFontDescriptor? ret;
			ret =  Runtime.GetNSObject<NSFontDescriptor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (class_ptr, selPreferredFontDescriptorForTextStyle_Options_XHandle, nstextStyle, options__handle__), false)!;
			GC.KeepAlive (options);
			CFString.ReleaseNative (nstextStyle);
			return ret!;
		}
		[Export ("matchingFontDescriptorWithMandatoryKeys:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSFontDescriptor MatchingFontDescriptorWithMandatoryKeys (NSSet mandatoryKeys)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var mandatoryKeys__handle__ = mandatoryKeys!.GetNonNullHandle (nameof (mandatoryKeys));
			NSFontDescriptor? ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<NSFontDescriptor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, selMatchingFontDescriptorWithMandatoryKeys_XHandle, mandatoryKeys__handle__), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<NSFontDescriptor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle (&__objc_super__, selMatchingFontDescriptorWithMandatoryKeys_XHandle, mandatoryKeys__handle__), false)!;
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (mandatoryKeys);
			return ret!;
		}
		[Export ("matchingFontDescriptorsWithMandatoryKeys:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSFontDescriptor[] MatchingFontDescriptors (NSSet mandatoryKeys)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var mandatoryKeys__handle__ = mandatoryKeys!.GetNonNullHandle (nameof (mandatoryKeys));
			NSFontDescriptor[]? ret;
			if (IsDirectBinding) {
				ret = CFArray.ArrayFromHandle<NSFontDescriptor>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, selMatchingFontDescriptorsWithMandatoryKeys_XHandle, mandatoryKeys__handle__), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = CFArray.ArrayFromHandle<NSFontDescriptor>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle (&__objc_super__, selMatchingFontDescriptorsWithMandatoryKeys_XHandle, mandatoryKeys__handle__), false)!;
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (mandatoryKeys);
			return ret!;
		}
		[Export ("objectForKey:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSObject ObjectForKey (string key)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			if (key is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (key));
			var nskey = CFString.CreateNative (key);
			NSObject? ret;
			if (IsDirectBinding) {
				ret = Runtime.GetNSObject (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, selObjectForKey_XHandle, nskey), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = Runtime.GetNSObject (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle (&__objc_super__, selObjectForKey_XHandle, nskey), false)!;
					GC.KeepAlive (this);
				}
			}
			CFString.ReleaseNative (nskey);
			return ret!;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSDictionary FontAttributes {
			[Export ("fontAttributes")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				NSDictionary? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSDictionary> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selFontAttributesXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<NSDictionary> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selFontAttributesXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSAffineTransform Matrix {
			[Export ("matrix")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				NSAffineTransform? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSAffineTransform> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selMatrixXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<NSAffineTransform> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selMatrixXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual nfloat PointSize {
			[Export ("pointSize")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				nfloat ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.nfloat_objc_msgSend (this.Handle, selPointSizeXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.nfloat_objc_msgSendSuper (&__objc_super__, selPointSizeXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string PostscriptName {
			[Export ("postscriptName")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				string ret;
				if (IsDirectBinding) {
					ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selPostscriptNameXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selPostscriptNameXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool RequiresFontAssetRequest {
			[Export ("requiresFontAssetRequest")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selRequiresFontAssetRequestXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, selRequiresFontAssetRequestXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSFontSymbolicTraits SymbolicTraits {
			[Export ("symbolicTraits")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				NSFontSymbolicTraits ret;
				if (IsDirectBinding) {
					ret = (NSFontSymbolicTraits) global::ObjCRuntime.Messaging.int_objc_msgSend (this.Handle, selSymbolicTraitsXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = (NSFontSymbolicTraits) global::ObjCRuntime.Messaging.int_objc_msgSendSuper (&__objc_super__, selSymbolicTraitsXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
	} /* class NSFontDescriptor */
}
