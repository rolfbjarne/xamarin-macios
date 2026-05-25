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
using Metal;
using CoreML;
using AppKit;
using MapKit;
using Photos;
using ModelIO;
using Network;
using SceneKit;
using Contacts;
using Security;
using CloudKit;
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
using FileProvider;
using CoreAnimation;
using CoreFoundation;
using NetworkExtension;
using MetalPerformanceShadersGraph;
#nullable enable
namespace Foundation {
	[Register("NSCharacterSet", true)]
	public unsafe partial class NSCharacterSet : NSObject, INSCoding, INSCopying, INSMutableCopying, INSSecureCoding {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly NativeHandle class_ptr = Class.GetHandle ("NSCharacterSet");
		/// <summary>The Objective-C class handle for this class.</summary>
		/// <value>The pointer to the Objective-C class.</value>
		/// <remarks>
		///     Each managed class mirrors an unmanaged Objective-C class.
		///     This value contains the pointer to the Objective-C class.
		///     It is similar to calling the managed <see cref="ObjCRuntime.Class.GetHandle(string)" /> or the native <see href="https://developer.apple.com/documentation/objectivec/1418952-objc_getclass">objc_getClass</see> method with the type name.
		/// </remarks>
		public override NativeHandle ClassHandle { get { return class_ptr; } }
		/// <summary>Creates a new <see cref="NSCharacterSet" /> with default values.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public NSCharacterSet () : base (NSObjectFlag.Empty)
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
		public NSCharacterSet (NSCoder coder) : base (NSObjectFlag.Empty)
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
		protected NSCharacterSet (NSObjectFlag t) : base (t)
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
		protected internal NSCharacterSet (NativeHandle handle) : base (handle)
		{
		}

		[Export ("characterIsMember:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool Contains (char aCharacter)
		{
			byte ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_char (this.Handle, Selector.GetHandle ("characterIsMember:"), aCharacter);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper_char (&__objc_super__, Selector.GetHandle ("characterIsMember:"), aCharacter);
					GC.KeepAlive (this);
				}
			}
			return ret != 0;
		}
		[Export ("longCharacterIsMember:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool Contains (uint theLongChar)
		{
			byte ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_UInt32 (this.Handle, Selector.GetHandle ("longCharacterIsMember:"), theLongChar);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper_UInt32 (&__objc_super__, Selector.GetHandle ("longCharacterIsMember:"), theLongChar);
					GC.KeepAlive (this);
				}
			}
			return ret != 0;
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
		[Export ("characterSetWithBitmapRepresentation:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSCharacterSet FromBitmap (NSData data)
		{
			var data__handle__ = data!.GetNonNullHandle (nameof (data));
			NSCharacterSet? ret;
			ret =  Runtime.GetNSObject<NSCharacterSet> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (class_ptr, Selector.GetHandle ("characterSetWithBitmapRepresentation:"), data__handle__), false)!;
			GC.KeepAlive (data);
			return ret!;
		}
		[Export ("characterSetWithContentsOfFile:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSCharacterSet? FromFile (string path)
		{
			if (path is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (path));
			var nspath = CFString.CreateNative (path);
			NSCharacterSet? ret;
			ret =  Runtime.GetNSObject<NSCharacterSet> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (class_ptr, Selector.GetHandle ("characterSetWithContentsOfFile:"), nspath), false)!;
			CFString.ReleaseNative (nspath);
			return ret!;
		}
		[Export ("characterSetWithRange:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSCharacterSet FromRange (NSRange aRange)
		{
			NSCharacterSet ret;
			ret =  Runtime.GetNSObject<NSCharacterSet> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NSRange (class_ptr, Selector.GetHandle ("characterSetWithRange:"), aRange), false)!;
			return ret;
		}
		[Export ("characterSetWithCharactersInString:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSCharacterSet FromString (string aString)
		{
			if (aString is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (aString));
			var nsaString = CFString.CreateNative (aString);
			NSCharacterSet? ret;
			ret =  Runtime.GetNSObject<NSCharacterSet> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (class_ptr, Selector.GetHandle ("characterSetWithCharactersInString:"), nsaString), false)!;
			CFString.ReleaseNative (nsaString);
			return ret!;
		}
		[Export ("bitmapRepresentation")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSData GetBitmapRepresentation ()
		{
			NSData ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<NSData> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("bitmapRepresentation")), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<NSData> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("bitmapRepresentation")), false)!;
					GC.KeepAlive (this);
				}
			}
			return ret;
		}
		[Export ("hasMemberInPlane:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool HasMemberInPlane (byte thePlane)
		{
			byte ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_byte (this.Handle, Selector.GetHandle ("hasMemberInPlane:"), thePlane);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper_byte (&__objc_super__, Selector.GetHandle ("hasMemberInPlane:"), thePlane);
					GC.KeepAlive (this);
				}
			}
			return ret != 0;
		}
		[Export ("isSupersetOfSet:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool IsSupersetOf (NSCharacterSet theOtherSet)
		{
			var theOtherSet__handle__ = theOtherSet!.GetNonNullHandle (nameof (theOtherSet));
			byte ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("isSupersetOfSet:"), theOtherSet__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper_NativeHandle (&__objc_super__, Selector.GetHandle ("isSupersetOfSet:"), theOtherSet__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (theOtherSet);
			return ret != 0;
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
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSCharacterSet Alphanumerics {
			[Export ("alphanumericCharacterSet", ArgumentSemantic.Copy)]
			get {
				NSCharacterSet? ret;
				ret =  Runtime.GetNSObject<NSCharacterSet> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (class_ptr, Selector.GetHandle ("alphanumericCharacterSet")), false)!;
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSCharacterSet Capitalized {
			[Export ("capitalizedLetterCharacterSet", ArgumentSemantic.Copy)]
			get {
				NSCharacterSet? ret;
				ret =  Runtime.GetNSObject<NSCharacterSet> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (class_ptr, Selector.GetHandle ("capitalizedLetterCharacterSet")), false)!;
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSCharacterSet Controls {
			[Export ("controlCharacterSet", ArgumentSemantic.Copy)]
			get {
				NSCharacterSet? ret;
				ret =  Runtime.GetNSObject<NSCharacterSet> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (class_ptr, Selector.GetHandle ("controlCharacterSet")), false)!;
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSCharacterSet DecimalDigits {
			[Export ("decimalDigitCharacterSet", ArgumentSemantic.Copy)]
			get {
				NSCharacterSet? ret;
				ret =  Runtime.GetNSObject<NSCharacterSet> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (class_ptr, Selector.GetHandle ("decimalDigitCharacterSet")), false)!;
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSCharacterSet Decomposables {
			[Export ("decomposableCharacterSet", ArgumentSemantic.Copy)]
			get {
				NSCharacterSet? ret;
				ret =  Runtime.GetNSObject<NSCharacterSet> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (class_ptr, Selector.GetHandle ("decomposableCharacterSet")), false)!;
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSCharacterSet Illegals {
			[Export ("illegalCharacterSet", ArgumentSemantic.Copy)]
			get {
				NSCharacterSet? ret;
				ret =  Runtime.GetNSObject<NSCharacterSet> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (class_ptr, Selector.GetHandle ("illegalCharacterSet")), false)!;
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSCharacterSet InvertedSet {
			[Export ("invertedSet")]
			get {
				NSCharacterSet? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSCharacterSet> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("invertedSet")), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<NSCharacterSet> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("invertedSet")), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSCharacterSet Letters {
			[Export ("letterCharacterSet", ArgumentSemantic.Copy)]
			get {
				NSCharacterSet? ret;
				ret =  Runtime.GetNSObject<NSCharacterSet> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (class_ptr, Selector.GetHandle ("letterCharacterSet")), false)!;
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSCharacterSet LowercaseLetters {
			[Export ("lowercaseLetterCharacterSet", ArgumentSemantic.Copy)]
			get {
				NSCharacterSet? ret;
				ret =  Runtime.GetNSObject<NSCharacterSet> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (class_ptr, Selector.GetHandle ("lowercaseLetterCharacterSet")), false)!;
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSCharacterSet Marks {
			[Export ("nonBaseCharacterSet", ArgumentSemantic.Copy)]
			get {
				NSCharacterSet? ret;
				ret =  Runtime.GetNSObject<NSCharacterSet> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (class_ptr, Selector.GetHandle ("nonBaseCharacterSet")), false)!;
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSCharacterSet Newlines {
			[Export ("newlineCharacterSet", ArgumentSemantic.Copy)]
			get {
				NSCharacterSet? ret;
				ret =  Runtime.GetNSObject<NSCharacterSet> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (class_ptr, Selector.GetHandle ("newlineCharacterSet")), false)!;
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSCharacterSet Punctuation {
			[Export ("punctuationCharacterSet", ArgumentSemantic.Copy)]
			get {
				NSCharacterSet? ret;
				ret =  Runtime.GetNSObject<NSCharacterSet> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (class_ptr, Selector.GetHandle ("punctuationCharacterSet")), false)!;
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSCharacterSet Symbols {
			[Export ("symbolCharacterSet", ArgumentSemantic.Copy)]
			get {
				NSCharacterSet? ret;
				ret =  Runtime.GetNSObject<NSCharacterSet> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (class_ptr, Selector.GetHandle ("symbolCharacterSet")), false)!;
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSCharacterSet UppercaseLetters {
			[Export ("uppercaseLetterCharacterSet", ArgumentSemantic.Copy)]
			get {
				NSCharacterSet? ret;
				ret =  Runtime.GetNSObject<NSCharacterSet> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (class_ptr, Selector.GetHandle ("uppercaseLetterCharacterSet")), false)!;
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSCharacterSet UrlFragmentAllowed {
			[Export ("URLFragmentAllowedCharacterSet", ArgumentSemantic.Copy)]
			get {
				NSCharacterSet? ret;
				ret =  Runtime.GetNSObject<NSCharacterSet> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (class_ptr, Selector.GetHandle ("URLFragmentAllowedCharacterSet")), false)!;
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSCharacterSet UrlHostAllowed {
			[Export ("URLHostAllowedCharacterSet", ArgumentSemantic.Copy)]
			get {
				NSCharacterSet? ret;
				ret =  Runtime.GetNSObject<NSCharacterSet> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (class_ptr, Selector.GetHandle ("URLHostAllowedCharacterSet")), false)!;
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSCharacterSet UrlPasswordAllowed {
			[Export ("URLPasswordAllowedCharacterSet", ArgumentSemantic.Copy)]
			get {
				NSCharacterSet? ret;
				ret =  Runtime.GetNSObject<NSCharacterSet> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (class_ptr, Selector.GetHandle ("URLPasswordAllowedCharacterSet")), false)!;
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSCharacterSet UrlPathAllowed {
			[Export ("URLPathAllowedCharacterSet", ArgumentSemantic.Copy)]
			get {
				NSCharacterSet? ret;
				ret =  Runtime.GetNSObject<NSCharacterSet> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (class_ptr, Selector.GetHandle ("URLPathAllowedCharacterSet")), false)!;
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSCharacterSet UrlQueryAllowed {
			[Export ("URLQueryAllowedCharacterSet", ArgumentSemantic.Copy)]
			get {
				NSCharacterSet? ret;
				ret =  Runtime.GetNSObject<NSCharacterSet> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (class_ptr, Selector.GetHandle ("URLQueryAllowedCharacterSet")), false)!;
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSCharacterSet UrlUserAllowed {
			[Export ("URLUserAllowedCharacterSet", ArgumentSemantic.Copy)]
			get {
				NSCharacterSet? ret;
				ret =  Runtime.GetNSObject<NSCharacterSet> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (class_ptr, Selector.GetHandle ("URLUserAllowedCharacterSet")), false)!;
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSCharacterSet WhitespaceAndNewlines {
			[Export ("whitespaceAndNewlineCharacterSet", ArgumentSemantic.Copy)]
			get {
				NSCharacterSet? ret;
				ret =  Runtime.GetNSObject<NSCharacterSet> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (class_ptr, Selector.GetHandle ("whitespaceAndNewlineCharacterSet")), false)!;
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSCharacterSet Whitespaces {
			[Export ("whitespaceCharacterSet", ArgumentSemantic.Copy)]
			get {
				NSCharacterSet? ret;
				ret =  Runtime.GetNSObject<NSCharacterSet> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (class_ptr, Selector.GetHandle ("whitespaceCharacterSet")), false)!;
				return ret!;
			}
		}
	} /* class NSCharacterSet */
}
