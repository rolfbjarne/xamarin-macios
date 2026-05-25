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
	[Register("NSMutableCharacterSet", true)]
	public unsafe partial class NSMutableCharacterSet : NSCharacterSet {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAddCharactersInRange_X = "addCharactersInRange:";
		static readonly NativeHandle selAddCharactersInRange_XHandle = Selector.GetHandle ("addCharactersInRange:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAddCharactersInString_X = "addCharactersInString:";
		static readonly NativeHandle selAddCharactersInString_XHandle = Selector.GetHandle ("addCharactersInString:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAlphanumericCharacterSetX = "alphanumericCharacterSet";
		static readonly NativeHandle selAlphanumericCharacterSetXHandle = Selector.GetHandle ("alphanumericCharacterSet");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selCapitalizedLetterCharacterSetX = "capitalizedLetterCharacterSet";
		static readonly NativeHandle selCapitalizedLetterCharacterSetXHandle = Selector.GetHandle ("capitalizedLetterCharacterSet");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selCharacterSetWithBitmapRepresentation_X = "characterSetWithBitmapRepresentation:";
		static readonly NativeHandle selCharacterSetWithBitmapRepresentation_XHandle = Selector.GetHandle ("characterSetWithBitmapRepresentation:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selCharacterSetWithCharactersInString_X = "characterSetWithCharactersInString:";
		static readonly NativeHandle selCharacterSetWithCharactersInString_XHandle = Selector.GetHandle ("characterSetWithCharactersInString:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selCharacterSetWithContentsOfFile_X = "characterSetWithContentsOfFile:";
		static readonly NativeHandle selCharacterSetWithContentsOfFile_XHandle = Selector.GetHandle ("characterSetWithContentsOfFile:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selCharacterSetWithRange_X = "characterSetWithRange:";
		static readonly NativeHandle selCharacterSetWithRange_XHandle = Selector.GetHandle ("characterSetWithRange:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selControlCharacterSetX = "controlCharacterSet";
		static readonly NativeHandle selControlCharacterSetXHandle = Selector.GetHandle ("controlCharacterSet");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selDecimalDigitCharacterSetX = "decimalDigitCharacterSet";
		static readonly NativeHandle selDecimalDigitCharacterSetXHandle = Selector.GetHandle ("decimalDigitCharacterSet");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selDecomposableCharacterSetX = "decomposableCharacterSet";
		static readonly NativeHandle selDecomposableCharacterSetXHandle = Selector.GetHandle ("decomposableCharacterSet");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selFormIntersectionWithCharacterSet_X = "formIntersectionWithCharacterSet:";
		static readonly NativeHandle selFormIntersectionWithCharacterSet_XHandle = Selector.GetHandle ("formIntersectionWithCharacterSet:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selFormUnionWithCharacterSet_X = "formUnionWithCharacterSet:";
		static readonly NativeHandle selFormUnionWithCharacterSet_XHandle = Selector.GetHandle ("formUnionWithCharacterSet:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selIllegalCharacterSetX = "illegalCharacterSet";
		static readonly NativeHandle selIllegalCharacterSetXHandle = Selector.GetHandle ("illegalCharacterSet");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selInvertX = "invert";
		static readonly NativeHandle selInvertXHandle = Selector.GetHandle ("invert");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selLetterCharacterSetX = "letterCharacterSet";
		static readonly NativeHandle selLetterCharacterSetXHandle = Selector.GetHandle ("letterCharacterSet");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selLowercaseLetterCharacterSetX = "lowercaseLetterCharacterSet";
		static readonly NativeHandle selLowercaseLetterCharacterSetXHandle = Selector.GetHandle ("lowercaseLetterCharacterSet");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selNewlineCharacterSetX = "newlineCharacterSet";
		static readonly NativeHandle selNewlineCharacterSetXHandle = Selector.GetHandle ("newlineCharacterSet");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selNonBaseCharacterSetX = "nonBaseCharacterSet";
		static readonly NativeHandle selNonBaseCharacterSetXHandle = Selector.GetHandle ("nonBaseCharacterSet");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selPunctuationCharacterSetX = "punctuationCharacterSet";
		static readonly NativeHandle selPunctuationCharacterSetXHandle = Selector.GetHandle ("punctuationCharacterSet");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selRemoveCharactersInRange_X = "removeCharactersInRange:";
		static readonly NativeHandle selRemoveCharactersInRange_XHandle = Selector.GetHandle ("removeCharactersInRange:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selRemoveCharactersInString_X = "removeCharactersInString:";
		static readonly NativeHandle selRemoveCharactersInString_XHandle = Selector.GetHandle ("removeCharactersInString:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSymbolCharacterSetX = "symbolCharacterSet";
		static readonly NativeHandle selSymbolCharacterSetXHandle = Selector.GetHandle ("symbolCharacterSet");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selUppercaseLetterCharacterSetX = "uppercaseLetterCharacterSet";
		static readonly NativeHandle selUppercaseLetterCharacterSetXHandle = Selector.GetHandle ("uppercaseLetterCharacterSet");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selWhitespaceAndNewlineCharacterSetX = "whitespaceAndNewlineCharacterSet";
		static readonly NativeHandle selWhitespaceAndNewlineCharacterSetXHandle = Selector.GetHandle ("whitespaceAndNewlineCharacterSet");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selWhitespaceCharacterSetX = "whitespaceCharacterSet";
		static readonly NativeHandle selWhitespaceCharacterSetXHandle = Selector.GetHandle ("whitespaceCharacterSet");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly NativeHandle class_ptr = Class.GetHandle ("NSMutableCharacterSet");
		/// <summary>The Objective-C class handle for this class.</summary>
		/// <value>The pointer to the Objective-C class.</value>
		/// <remarks>
		///     Each managed class mirrors an unmanaged Objective-C class.
		///     This value contains the pointer to the Objective-C class.
		///     It is similar to calling the managed <see cref="ObjCRuntime.Class.GetHandle(string)" /> or the native <see href="https://developer.apple.com/documentation/objectivec/1418952-objc_getclass">objc_getClass</see> method with the type name.
		/// </remarks>
		public override NativeHandle ClassHandle { get { return class_ptr; } }
		/// <summary>Creates a new <see cref="NSMutableCharacterSet" /> with default values.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public NSMutableCharacterSet () : base (NSObjectFlag.Empty)
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
		public NSMutableCharacterSet (NSCoder coder) : base (NSObjectFlag.Empty)
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
		protected NSMutableCharacterSet (NSObjectFlag t) : base (t)
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
		protected internal NSMutableCharacterSet (NativeHandle handle) : base (handle)
		{
		}

		[Export ("addCharactersInRange:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void AddCharacters (NSRange aRange)
		{
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NSRange (this.Handle, selAddCharactersInRange_XHandle, aRange);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NSRange (&__objc_super__, selAddCharactersInRange_XHandle, aRange);
					GC.KeepAlive (this);
				}
			}
		}
		[Export ("addCharactersInString:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void AddCharacters (NSString str)
		{
			var str__handle__ = str!.GetNonNullHandle (nameof (str));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selAddCharactersInString_XHandle, str__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selAddCharactersInString_XHandle, str__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (str);
		}
		[Export ("characterSetWithBitmapRepresentation:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSCharacterSet FromBitmapRepresentation (NSData data)
		{
			var data__handle__ = data!.GetNonNullHandle (nameof (data));
			NSCharacterSet? ret;
			ret =  Runtime.GetNSObject<NSCharacterSet> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (class_ptr, selCharacterSetWithBitmapRepresentation_XHandle, data__handle__), false)!;
			GC.KeepAlive (data);
			return ret!;
		}
		[Export ("characterSetWithContentsOfFile:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSCharacterSet? FromFile (string path)
		{
			if (path is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (path));
			var nspath = CFString.CreateNative (path);
			NSCharacterSet? ret;
			ret =  Runtime.GetNSObject<NSCharacterSet> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (class_ptr, selCharacterSetWithContentsOfFile_XHandle, nspath), false)!;
			CFString.ReleaseNative (nspath);
			return ret!;
		}
		[Export ("characterSetWithRange:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSCharacterSet FromRange (NSRange aRange)
		{
			NSCharacterSet ret;
			ret =  Runtime.GetNSObject<NSCharacterSet> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NSRange (class_ptr, selCharacterSetWithRange_XHandle, aRange), false)!;
			return ret;
		}
		[Export ("characterSetWithCharactersInString:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSCharacterSet FromString (string aString)
		{
			if (aString is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (aString));
			var nsaString = CFString.CreateNative (aString);
			NSCharacterSet? ret;
			ret =  Runtime.GetNSObject<NSCharacterSet> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (class_ptr, selCharacterSetWithCharactersInString_XHandle, nsaString), false)!;
			CFString.ReleaseNative (nsaString);
			return ret!;
		}
		[Export ("formIntersectionWithCharacterSet:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void IntersectWith (NSCharacterSet otherSet)
		{
			var otherSet__handle__ = otherSet!.GetNonNullHandle (nameof (otherSet));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selFormIntersectionWithCharacterSet_XHandle, otherSet__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selFormIntersectionWithCharacterSet_XHandle, otherSet__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (otherSet);
		}
		[Export ("invert")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void Invert ()
		{
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, selInvertXHandle);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper (&__objc_super__, selInvertXHandle);
					GC.KeepAlive (this);
				}
			}
		}
		[Export ("removeCharactersInRange:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void RemoveCharacters (NSRange aRange)
		{
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NSRange (this.Handle, selRemoveCharactersInRange_XHandle, aRange);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NSRange (&__objc_super__, selRemoveCharactersInRange_XHandle, aRange);
					GC.KeepAlive (this);
				}
			}
		}
		[Export ("removeCharactersInString:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void RemoveCharacters (NSString str)
		{
			var str__handle__ = str!.GetNonNullHandle (nameof (str));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selRemoveCharactersInString_XHandle, str__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selRemoveCharactersInString_XHandle, str__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (str);
		}
		[Export ("formUnionWithCharacterSet:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void UnionWith (NSCharacterSet otherSet)
		{
			var otherSet__handle__ = otherSet!.GetNonNullHandle (nameof (otherSet));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selFormUnionWithCharacterSet_XHandle, otherSet__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selFormUnionWithCharacterSet_XHandle, otherSet__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (otherSet);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static NSCharacterSet Alphanumerics {
			[Export ("alphanumericCharacterSet")]
			get {
				NSCharacterSet? ret;
				ret =  Runtime.GetNSObject<NSCharacterSet> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (class_ptr, selAlphanumericCharacterSetXHandle), false)!;
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static NSCharacterSet Capitalized {
			[Export ("capitalizedLetterCharacterSet")]
			get {
				NSCharacterSet? ret;
				ret =  Runtime.GetNSObject<NSCharacterSet> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (class_ptr, selCapitalizedLetterCharacterSetXHandle), false)!;
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static NSCharacterSet Controls {
			[Export ("controlCharacterSet")]
			get {
				NSCharacterSet? ret;
				ret =  Runtime.GetNSObject<NSCharacterSet> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (class_ptr, selControlCharacterSetXHandle), false)!;
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static NSCharacterSet DecimalDigits {
			[Export ("decimalDigitCharacterSet")]
			get {
				NSCharacterSet? ret;
				ret =  Runtime.GetNSObject<NSCharacterSet> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (class_ptr, selDecimalDigitCharacterSetXHandle), false)!;
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static NSCharacterSet Decomposables {
			[Export ("decomposableCharacterSet")]
			get {
				NSCharacterSet? ret;
				ret =  Runtime.GetNSObject<NSCharacterSet> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (class_ptr, selDecomposableCharacterSetXHandle), false)!;
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static NSCharacterSet Illegals {
			[Export ("illegalCharacterSet")]
			get {
				NSCharacterSet? ret;
				ret =  Runtime.GetNSObject<NSCharacterSet> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (class_ptr, selIllegalCharacterSetXHandle), false)!;
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static NSCharacterSet Letters {
			[Export ("letterCharacterSet")]
			get {
				NSCharacterSet? ret;
				ret =  Runtime.GetNSObject<NSCharacterSet> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (class_ptr, selLetterCharacterSetXHandle), false)!;
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static NSCharacterSet LowercaseLetters {
			[Export ("lowercaseLetterCharacterSet")]
			get {
				NSCharacterSet? ret;
				ret =  Runtime.GetNSObject<NSCharacterSet> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (class_ptr, selLowercaseLetterCharacterSetXHandle), false)!;
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static NSCharacterSet Marks {
			[Export ("nonBaseCharacterSet")]
			get {
				NSCharacterSet? ret;
				ret =  Runtime.GetNSObject<NSCharacterSet> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (class_ptr, selNonBaseCharacterSetXHandle), false)!;
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static NSCharacterSet Newlines {
			[Export ("newlineCharacterSet")]
			get {
				NSCharacterSet? ret;
				ret =  Runtime.GetNSObject<NSCharacterSet> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (class_ptr, selNewlineCharacterSetXHandle), false)!;
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static NSCharacterSet Punctuation {
			[Export ("punctuationCharacterSet")]
			get {
				NSCharacterSet? ret;
				ret =  Runtime.GetNSObject<NSCharacterSet> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (class_ptr, selPunctuationCharacterSetXHandle), false)!;
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static NSCharacterSet Symbols {
			[Export ("symbolCharacterSet")]
			get {
				NSCharacterSet? ret;
				ret =  Runtime.GetNSObject<NSCharacterSet> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (class_ptr, selSymbolCharacterSetXHandle), false)!;
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static NSCharacterSet UppercaseLetters {
			[Export ("uppercaseLetterCharacterSet")]
			get {
				NSCharacterSet? ret;
				ret =  Runtime.GetNSObject<NSCharacterSet> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (class_ptr, selUppercaseLetterCharacterSetXHandle), false)!;
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static NSCharacterSet WhitespaceAndNewlines {
			[Export ("whitespaceAndNewlineCharacterSet")]
			get {
				NSCharacterSet? ret;
				ret =  Runtime.GetNSObject<NSCharacterSet> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (class_ptr, selWhitespaceAndNewlineCharacterSetXHandle), false)!;
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static NSCharacterSet Whitespaces {
			[Export ("whitespaceCharacterSet")]
			get {
				NSCharacterSet? ret;
				ret =  Runtime.GetNSObject<NSCharacterSet> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (class_ptr, selWhitespaceCharacterSetXHandle), false)!;
				return ret!;
			}
		}
	} /* class NSMutableCharacterSet */
}
