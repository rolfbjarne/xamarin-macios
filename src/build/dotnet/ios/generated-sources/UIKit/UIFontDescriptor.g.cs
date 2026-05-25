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
namespace UIKit {
	[Register("UIFontDescriptor", true)]
	public unsafe partial class UIFontDescriptor : NSObject, INSCoding, INSCopying, INSSecureCoding {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly NativeHandle class_ptr = Class.GetHandle ("UIFontDescriptor");
		/// <summary>The Objective-C class handle for this class.</summary>
		/// <value>The pointer to the Objective-C class.</value>
		/// <remarks>
		///     Each managed class mirrors an unmanaged Objective-C class.
		///     This value contains the pointer to the Objective-C class.
		///     It is similar to calling the managed <see cref="ObjCRuntime.Class.GetHandle(string)" /> or the native <see href="https://developer.apple.com/documentation/objectivec/1418952-objc_getclass">objc_getClass</see> method with the type name.
		/// </remarks>
		public override NativeHandle ClassHandle { get { return class_ptr; } }
		/// <summary>Creates a new <see cref="UIFontDescriptor" /> with default values.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public UIFontDescriptor () : base (NSObjectFlag.Empty)
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
		public UIFontDescriptor (NSCoder coder) : base (NSObjectFlag.Empty)
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
		protected UIFontDescriptor (NSObjectFlag t) : base (t)
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
		protected internal UIFontDescriptor (NativeHandle handle) : base (handle)
		{
		}

		[Export ("initWithFontAttributes:")]
		[DesignatedInitializer]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public UIFontDescriptor (NSDictionary attributes)
			: base (NSObjectFlag.Empty)
		{
			var attributes__handle__ = attributes!.GetNonNullHandle (nameof (attributes));
			if (IsDirectBinding) {
				InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("initWithFontAttributes:"), attributes__handle__), "initWithFontAttributes:");
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle (&__objc_super__, Selector.GetHandle ("initWithFontAttributes:"), attributes__handle__), "initWithFontAttributes:");
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (attributes);
		}
		/// <param name="attributes">List of desired font attributes.</param><summary>Creates a font descriptor using the specified font attributes.</summary><remarks><para></para><para tool="threads">This can be used from a background thread.</para></remarks>
		[DesignatedInitializer]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public UIFontDescriptor (UIFontAttributes attributes)
			: this (attributes.GetDictionary ()!)
		{
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
		[Export ("fontDescriptorByAddingAttributes:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual UIFontDescriptor CreateWithAttributes (NSDictionary attributes)
		{
			var attributes__handle__ = attributes!.GetNonNullHandle (nameof (attributes));
			UIFontDescriptor? ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<UIFontDescriptor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("fontDescriptorByAddingAttributes:"), attributes__handle__), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<UIFontDescriptor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle (&__objc_super__, Selector.GetHandle ("fontDescriptorByAddingAttributes:"), attributes__handle__), false)!;
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (attributes);
			return ret!;
		}
		/// <param name="attributes">dictionary containing the attributes.</param><summary>Creates a new UIFontDescriptor based on adding the provided attributes to the current descriptor.</summary><returns>New UIFontDescriptor containing the added attributes.</returns><remarks><para></para><para tool="threads">This can be used from a background thread.</para></remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public UIFontDescriptor CreateWithAttributes (UIFontAttributes attributes)
		{
			return CreateWithAttributes (attributes.GetDictionary ()!);
		}
		[Export ("fontDescriptorWithDesign:")]
		[EditorBrowsable (EditorBrowsableState.Never)]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("tvos13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual UIFontDescriptor? CreateWithDesign (NSString design)
		{
			var design__handle__ = design!.GetNonNullHandle (nameof (design));
			UIFontDescriptor? ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<UIFontDescriptor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("fontDescriptorWithDesign:"), design__handle__), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<UIFontDescriptor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle (&__objc_super__, Selector.GetHandle ("fontDescriptorWithDesign:"), design__handle__), false)!;
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (design);
			return ret!;
		}
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("tvos13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public UIFontDescriptor? CreateWithDesign (UIFontDescriptorSystemDesign design)
		{
			return CreateWithDesign (design.GetConstant ()!);
		}
		[Export ("fontDescriptorWithFace:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual UIFontDescriptor CreateWithFace (string newFace)
		{
			if (newFace is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (newFace));
			var nsnewFace = CFString.CreateNative (newFace);
			UIFontDescriptor? ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<UIFontDescriptor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("fontDescriptorWithFace:"), nsnewFace), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<UIFontDescriptor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle (&__objc_super__, Selector.GetHandle ("fontDescriptorWithFace:"), nsnewFace), false)!;
					GC.KeepAlive (this);
				}
			}
			CFString.ReleaseNative (nsnewFace);
			return ret!;
		}
		[Export ("fontDescriptorWithFamily:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual UIFontDescriptor CreateWithFamily (string newFamily)
		{
			if (newFamily is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (newFamily));
			var nsnewFamily = CFString.CreateNative (newFamily);
			UIFontDescriptor? ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<UIFontDescriptor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("fontDescriptorWithFamily:"), nsnewFamily), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<UIFontDescriptor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle (&__objc_super__, Selector.GetHandle ("fontDescriptorWithFamily:"), nsnewFamily), false)!;
					GC.KeepAlive (this);
				}
			}
			CFString.ReleaseNative (nsnewFamily);
			return ret!;
		}
		[Export ("fontDescriptorWithMatrix:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual UIFontDescriptor CreateWithMatrix (CGAffineTransform matrix)
		{
			UIFontDescriptor ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<UIFontDescriptor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_CGAffineTransform (this.Handle, Selector.GetHandle ("fontDescriptorWithMatrix:"), matrix), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<UIFontDescriptor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_CGAffineTransform (&__objc_super__, Selector.GetHandle ("fontDescriptorWithMatrix:"), matrix), false)!;
					GC.KeepAlive (this);
				}
			}
			return ret;
		}
		/// <param name="newPointSize">New desired font size for the descriptor.</param><summary>Creates a new UIFontDescriptor based on setting a new font size to the current descriptor.</summary><returns>New UIFontDescriptor containing the added font size.</returns><remarks><para></para><para tool="threads">This can be used from a background thread.</para></remarks>
		[Export ("fontDescriptorWithSize:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual UIFontDescriptor CreateWithSize (nfloat newPointSize)
		{
			UIFontDescriptor ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<UIFontDescriptor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_nfloat (this.Handle, Selector.GetHandle ("fontDescriptorWithSize:"), newPointSize), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<UIFontDescriptor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_nfloat (&__objc_super__, Selector.GetHandle ("fontDescriptorWithSize:"), newPointSize), false)!;
					GC.KeepAlive (this);
				}
			}
			return ret;
		}
		[Export ("fontDescriptorWithSymbolicTraits:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual UIFontDescriptor CreateWithTraits (UIFontDescriptorSymbolicTraits symbolicTraits)
		{
			UIFontDescriptor ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<UIFontDescriptor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_UInt32 (this.Handle, Selector.GetHandle ("fontDescriptorWithSymbolicTraits:"), (UInt32)symbolicTraits), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<UIFontDescriptor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_UInt32 (&__objc_super__, Selector.GetHandle ("fontDescriptorWithSymbolicTraits:"), (UInt32)symbolicTraits), false)!;
					GC.KeepAlive (this);
				}
			}
			return ret;
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
		[Export ("fontDescriptorWithFontAttributes:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static UIFontDescriptor FromAttributes (NSDictionary attributes)
		{
			var attributes__handle__ = attributes!.GetNonNullHandle (nameof (attributes));
			UIFontDescriptor? ret;
			ret =  Runtime.GetNSObject<UIFontDescriptor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (class_ptr, Selector.GetHandle ("fontDescriptorWithFontAttributes:"), attributes__handle__), false)!;
			GC.KeepAlive (attributes);
			return ret!;
		}
		/// <param name="attributes">Weak dictionary of font attributes.</param><summary>Creates a UIFontDescriptor using a set of attributes contained in the dictionary.</summary><returns></returns><remarks><para></para><para tool="threads">This can be used from a background thread.</para></remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static UIFontDescriptor FromAttributes (UIFontAttributes attributes)
		{
			return FromAttributes (attributes.GetDictionary ()!);
		}
		/// <param name="fontName">Font name.</param><param name="size">Font size.</param><summary>Creates a UIFontDescriptor using the specified name and font size.</summary><returns></returns><remarks><para></para><para tool="threads">This can be used from a background thread.</para></remarks>
		[Export ("fontDescriptorWithName:size:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static UIFontDescriptor FromName (string fontName, nfloat size)
		{
			if (fontName is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (fontName));
			var nsfontName = CFString.CreateNative (fontName);
			UIFontDescriptor? ret;
			ret =  Runtime.GetNSObject<UIFontDescriptor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_nfloat (class_ptr, Selector.GetHandle ("fontDescriptorWithName:size:"), nsfontName, size), false)!;
			CFString.ReleaseNative (nsfontName);
			return ret!;
		}
		[Export ("fontDescriptorWithName:matrix:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static UIFontDescriptor FromName (string fontName, CGAffineTransform matrix)
		{
			if (fontName is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (fontName));
			var nsfontName = CFString.CreateNative (fontName);
			UIFontDescriptor? ret;
			ret =  Runtime.GetNSObject<UIFontDescriptor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_CGAffineTransform (class_ptr, Selector.GetHandle ("fontDescriptorWithName:matrix:"), nsfontName, matrix), false)!;
			CFString.ReleaseNative (nsfontName);
			return ret!;
		}
		[Export ("matchingFontDescriptorsWithMandatoryKeys:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual UIFontDescriptor[] GetMatchingFontDescriptors (NSSet? mandatoryKeys)
		{
			var mandatoryKeys__handle__ = mandatoryKeys.GetHandle ();
			UIFontDescriptor[]? ret;
			if (IsDirectBinding) {
				ret = CFArray.ArrayFromHandle<UIFontDescriptor>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("matchingFontDescriptorsWithMandatoryKeys:"), mandatoryKeys__handle__), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = CFArray.ArrayFromHandle<UIFontDescriptor>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle (&__objc_super__, Selector.GetHandle ("matchingFontDescriptorsWithMandatoryKeys:"), mandatoryKeys__handle__), false)!;
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (mandatoryKeys);
			return ret!;
		}
		[Export ("objectForKey:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSObject? GetObject (NSString anAttribute)
		{
			var anAttribute__handle__ = anAttribute!.GetNonNullHandle (nameof (anAttribute));
			NSObject? ret;
			if (IsDirectBinding) {
				ret = Runtime.GetNSObject (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("objectForKey:"), anAttribute__handle__), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = Runtime.GetNSObject (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle (&__objc_super__, Selector.GetHandle ("objectForKey:"), anAttribute__handle__), false)!;
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (anAttribute);
			return ret!;
		}
		[Export ("preferredFontDescriptorWithTextStyle:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static UIFontDescriptor GetPreferredDescriptorForTextStyle (NSString uiFontTextStyle)
		{
			var uiFontTextStyle__handle__ = uiFontTextStyle!.GetNonNullHandle (nameof (uiFontTextStyle));
			UIFontDescriptor? ret;
			ret =  Runtime.GetNSObject<UIFontDescriptor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (class_ptr, Selector.GetHandle ("preferredFontDescriptorWithTextStyle:"), uiFontTextStyle__handle__), false)!;
			GC.KeepAlive (uiFontTextStyle);
			return ret!;
		}
		/// <param name="uiFontTextStyle">Name of one of the built-in system text styles.</param><summary>Weakly-typed version of an API used to retrieve the user's desired font size.</summary><returns>To be added.</returns><remarks><para>(More documentation for this node is coming)</para><para tool="threads">This can be used from a background thread.</para></remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static UIFontDescriptor GetPreferredDescriptorForTextStyle (UIFontTextStyle uiFontTextStyle)
		{
			return GetPreferredDescriptorForTextStyle (uiFontTextStyle.GetConstant ()!);
		}
		[Export ("preferredFontDescriptorWithTextStyle:compatibleWithTraitCollection:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static UIFontDescriptor GetPreferredDescriptorForTextStyle (NSString uiFontTextStyle, UITraitCollection? traitCollection)
		{
			var uiFontTextStyle__handle__ = uiFontTextStyle!.GetNonNullHandle (nameof (uiFontTextStyle));
			var traitCollection__handle__ = traitCollection.GetHandle ();
			UIFontDescriptor? ret;
			ret =  Runtime.GetNSObject<UIFontDescriptor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (class_ptr, Selector.GetHandle ("preferredFontDescriptorWithTextStyle:compatibleWithTraitCollection:"), uiFontTextStyle__handle__, traitCollection__handle__), false)!;
			GC.KeepAlive (uiFontTextStyle);
			GC.KeepAlive (traitCollection);
			return ret!;
		}
		/// <param name="uiFontTextStyle">Name of one of the built-in system text styles.</param><param name="traitCollection"><para>The trait collection for which to get the preferred font descriptor.</para><para tool="nullallowed">This parameter can be <see langword="null" />.</para></param><summary>Returns the preferred font descriptor for the specified style and trait collection.</summary><returns>To be added.</returns><remarks><para>(More documentation for this node is coming)</para><para tool="threads">This can be used from a background thread.</para></remarks>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static UIFontDescriptor GetPreferredDescriptorForTextStyle (UIFontTextStyle uiFontTextStyle, UITraitCollection? traitCollection)
		{
			return GetPreferredDescriptorForTextStyle (uiFontTextStyle.GetConstant ()!, traitCollection);
		}
		/// <summary>The font attributes.</summary><value></value><remarks><para tool="threads">This can be used from a background thread.</para></remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public UIFontAttributes FontAttributes {
			get {
				var src = WeakFontAttributes is not null ? new NSMutableDictionary (WeakFontAttributes) : null;
				return src is null ? null! : new UIFontAttributes(src);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual CGAffineTransform Matrix {
			[Export ("matrix")]
			get {
				CGAffineTransform ret;
				if (IsDirectBinding) {
					if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
						ret = global::ObjCRuntime.Messaging.CGAffineTransform_objc_msgSend (this.Handle, Selector.GetHandle ("matrix"));
					} else {
						ret = global::ObjCRuntime.Messaging.CGAffineTransform_objc_msgSend_stret (this.Handle, Selector.GetHandle ("matrix"));
					}
				} else {
					if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
						unsafe {
							var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
							ret = global::ObjCRuntime.Messaging.CGAffineTransform_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("matrix"));
							GC.KeepAlive (this);
						}
					} else {
						unsafe {
							var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
							ret = global::ObjCRuntime.Messaging.CGAffineTransform_objc_msgSendSuper_stret (&__objc_super__, Selector.GetHandle ("matrix"));
							GC.KeepAlive (this);
						}
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual nfloat PointSize {
			[Export ("pointSize")]
			get {
				nfloat ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.nfloat_objc_msgSend (this.Handle, Selector.GetHandle ("pointSize"));
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.nfloat_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("pointSize"));
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
				string ret;
				if (IsDirectBinding) {
					ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("postscriptName")), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("postscriptName")), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual UIFontDescriptorSymbolicTraits SymbolicTraits {
			[Export ("symbolicTraits")]
			get {
				UIFontDescriptorSymbolicTraits ret;
				if (IsDirectBinding) {
					ret = (UIFontDescriptorSymbolicTraits) global::ObjCRuntime.Messaging.UInt32_objc_msgSend (this.Handle, Selector.GetHandle ("symbolicTraits"));
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = (UIFontDescriptorSymbolicTraits) global::ObjCRuntime.Messaging.UInt32_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("symbolicTraits"));
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSDictionary WeakFontAttributes {
			[Export ("fontAttributes")]
			get {
				NSDictionary? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSDictionary> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("fontAttributes")), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<NSDictionary> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("fontAttributes")), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _CascadeListAttribute;
		/// <summary>Represents the value associated with the constant 'UIFontDescriptorCascadeListAttribute'.</summary>
		[Field ("UIFontDescriptorCascadeListAttribute",  "UIKit")]
		internal static NSString CascadeListAttribute {
			get {
				if (_CascadeListAttribute is null)
					_CascadeListAttribute = Dlfcn.GetStringConstant (Libraries.UIKit.Handle, "UIFontDescriptorCascadeListAttribute")!;
				return _CascadeListAttribute;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _CharacterSetAttribute;
		/// <summary>Represents the value associated with the constant 'UIFontDescriptorCharacterSetAttribute'.</summary>
		[Field ("UIFontDescriptorCharacterSetAttribute",  "UIKit")]
		internal static NSString CharacterSetAttribute {
			get {
				if (_CharacterSetAttribute is null)
					_CharacterSetAttribute = Dlfcn.GetStringConstant (Libraries.UIKit.Handle, "UIFontDescriptorCharacterSetAttribute")!;
				return _CharacterSetAttribute;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _FaceAttribute;
		/// <summary>Represents the value associated with the constant 'UIFontDescriptorFaceAttribute'.</summary>
		[Field ("UIFontDescriptorFaceAttribute",  "UIKit")]
		internal static NSString FaceAttribute {
			get {
				if (_FaceAttribute is null)
					_FaceAttribute = Dlfcn.GetStringConstant (Libraries.UIKit.Handle, "UIFontDescriptorFaceAttribute")!;
				return _FaceAttribute;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _FamilyAttribute;
		/// <summary>Represents the value associated with the constant 'UIFontDescriptorFamilyAttribute'.</summary>
		[Field ("UIFontDescriptorFamilyAttribute",  "UIKit")]
		internal static NSString FamilyAttribute {
			get {
				if (_FamilyAttribute is null)
					_FamilyAttribute = Dlfcn.GetStringConstant (Libraries.UIKit.Handle, "UIFontDescriptorFamilyAttribute")!;
				return _FamilyAttribute;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _FeatureSettingsAttribute;
		/// <summary>Represents the value associated with the constant 'UIFontDescriptorFeatureSettingsAttribute'.</summary>
		[Field ("UIFontDescriptorFeatureSettingsAttribute",  "UIKit")]
		internal static NSString FeatureSettingsAttribute {
			get {
				if (_FeatureSettingsAttribute is null)
					_FeatureSettingsAttribute = Dlfcn.GetStringConstant (Libraries.UIKit.Handle, "UIFontDescriptorFeatureSettingsAttribute")!;
				return _FeatureSettingsAttribute;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _FixedAdvanceAttribute;
		/// <summary>Represents the value associated with the constant 'UIFontDescriptorFixedAdvanceAttribute'.</summary>
		[Field ("UIFontDescriptorFixedAdvanceAttribute",  "UIKit")]
		internal static NSString FixedAdvanceAttribute {
			get {
				if (_FixedAdvanceAttribute is null)
					_FixedAdvanceAttribute = Dlfcn.GetStringConstant (Libraries.UIKit.Handle, "UIFontDescriptorFixedAdvanceAttribute")!;
				return _FixedAdvanceAttribute;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _MatrixAttribute;
		/// <summary>Represents the value associated with the constant 'UIFontDescriptorMatrixAttribute'.</summary>
		[Field ("UIFontDescriptorMatrixAttribute",  "UIKit")]
		internal static NSString MatrixAttribute {
			get {
				if (_MatrixAttribute is null)
					_MatrixAttribute = Dlfcn.GetStringConstant (Libraries.UIKit.Handle, "UIFontDescriptorMatrixAttribute")!;
				return _MatrixAttribute;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _NameAttribute;
		/// <summary>Represents the value associated with the constant 'UIFontDescriptorNameAttribute'.</summary>
		[Field ("UIFontDescriptorNameAttribute",  "UIKit")]
		internal static NSString NameAttribute {
			get {
				if (_NameAttribute is null)
					_NameAttribute = Dlfcn.GetStringConstant (Libraries.UIKit.Handle, "UIFontDescriptorNameAttribute")!;
				return _NameAttribute;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _SizeAttribute;
		/// <summary>Represents the value associated with the constant 'UIFontDescriptorSizeAttribute'.</summary>
		[Field ("UIFontDescriptorSizeAttribute",  "UIKit")]
		internal static NSString SizeAttribute {
			get {
				if (_SizeAttribute is null)
					_SizeAttribute = Dlfcn.GetStringConstant (Libraries.UIKit.Handle, "UIFontDescriptorSizeAttribute")!;
				return _SizeAttribute;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _SlantTrait;
		/// <summary>Represents the value associated with the constant 'UIFontSlantTrait'.</summary>
		[Field ("UIFontSlantTrait",  "UIKit")]
		internal static NSString SlantTrait {
			get {
				if (_SlantTrait is null)
					_SlantTrait = Dlfcn.GetStringConstant (Libraries.UIKit.Handle, "UIFontSlantTrait")!;
				return _SlantTrait;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _SymbolicTrait;
		/// <summary>Represents the value associated with the constant 'UIFontSymbolicTrait'.</summary>
		[Field ("UIFontSymbolicTrait",  "UIKit")]
		internal static NSString SymbolicTrait {
			get {
				if (_SymbolicTrait is null)
					_SymbolicTrait = Dlfcn.GetStringConstant (Libraries.UIKit.Handle, "UIFontSymbolicTrait")!;
				return _SymbolicTrait;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _TextStyleAttribute;
		/// <summary>Represents the value associated with the constant 'UIFontDescriptorTextStyleAttribute'.</summary>
		[Field ("UIFontDescriptorTextStyleAttribute",  "UIKit")]
		internal static NSString TextStyleAttribute {
			get {
				if (_TextStyleAttribute is null)
					_TextStyleAttribute = Dlfcn.GetStringConstant (Libraries.UIKit.Handle, "UIFontDescriptorTextStyleAttribute")!;
				return _TextStyleAttribute;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _TraitsAttribute;
		/// <summary>Represents the value associated with the constant 'UIFontDescriptorTraitsAttribute'.</summary>
		[Field ("UIFontDescriptorTraitsAttribute",  "UIKit")]
		internal static NSString TraitsAttribute {
			get {
				if (_TraitsAttribute is null)
					_TraitsAttribute = Dlfcn.GetStringConstant (Libraries.UIKit.Handle, "UIFontDescriptorTraitsAttribute")!;
				return _TraitsAttribute;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _UIFontFeatureSelectorIdentifierKey;
		/// <summary>Represents the value associated with the constant 'UIFontFeatureSelectorIdentifierKey'.</summary>
		[Field ("UIFontFeatureSelectorIdentifierKey",  "UIKit")]
		internal static NSString UIFontFeatureSelectorIdentifierKey {
			get {
				if (_UIFontFeatureSelectorIdentifierKey is null)
					_UIFontFeatureSelectorIdentifierKey = Dlfcn.GetStringConstant (Libraries.UIKit.Handle, "UIFontFeatureSelectorIdentifierKey")!;
				return _UIFontFeatureSelectorIdentifierKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _UIFontFeatureTypeIdentifierKey;
		/// <summary>Represents the value associated with the constant 'UIFontFeatureTypeIdentifierKey'.</summary>
		[Field ("UIFontFeatureTypeIdentifierKey",  "UIKit")]
		internal static NSString UIFontFeatureTypeIdentifierKey {
			get {
				if (_UIFontFeatureTypeIdentifierKey is null)
					_UIFontFeatureTypeIdentifierKey = Dlfcn.GetStringConstant (Libraries.UIKit.Handle, "UIFontFeatureTypeIdentifierKey")!;
				return _UIFontFeatureTypeIdentifierKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _VisibleNameAttribute;
		/// <summary>Represents the value associated with the constant 'UIFontDescriptorVisibleNameAttribute'.</summary>
		[Field ("UIFontDescriptorVisibleNameAttribute",  "UIKit")]
		internal static NSString VisibleNameAttribute {
			get {
				if (_VisibleNameAttribute is null)
					_VisibleNameAttribute = Dlfcn.GetStringConstant (Libraries.UIKit.Handle, "UIFontDescriptorVisibleNameAttribute")!;
				return _VisibleNameAttribute;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _WeightTrait;
		/// <summary>Represents the value associated with the constant 'UIFontWeightTrait'.</summary>
		[Field ("UIFontWeightTrait",  "UIKit")]
		internal static NSString WeightTrait {
			get {
				if (_WeightTrait is null)
					_WeightTrait = Dlfcn.GetStringConstant (Libraries.UIKit.Handle, "UIFontWeightTrait")!;
				return _WeightTrait;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _WidthTrait;
		/// <summary>Represents the value associated with the constant 'UIFontWidthTrait'.</summary>
		[Field ("UIFontWidthTrait",  "UIKit")]
		internal static NSString WidthTrait {
			get {
				if (_WidthTrait is null)
					_WidthTrait = Dlfcn.GetStringConstant (Libraries.UIKit.Handle, "UIFontWidthTrait")!;
				return _WidthTrait;
			}
		}
	} /* class UIFontDescriptor */
}
