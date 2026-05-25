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
	[Register("NSString", true)]
	public unsafe partial class NSString : NSObject, INSCoding, INSCopying, INSItemProviderReading, INSItemProviderWriting, INSMutableCopying, INSSecureCoding, global::CloudKit.ICKRecordValue {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly NativeHandle class_ptr = Class.GetHandle ("NSString");
		/// <summary>The Objective-C class handle for this class.</summary>
		/// <value>The pointer to the Objective-C class.</value>
		/// <remarks>
		///     Each managed class mirrors an unmanaged Objective-C class.
		///     This value contains the pointer to the Objective-C class.
		///     It is similar to calling the managed <see cref="ObjCRuntime.Class.GetHandle(string)" /> or the native <see href="https://developer.apple.com/documentation/objectivec/1418952-objc_getclass">objc_getClass</see> method with the type name.
		/// </remarks>
		public override NativeHandle ClassHandle { get { return class_ptr; } }
		/// <summary>Creates a new <see cref="NSString" /> with default values.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[DesignatedInitializer]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public NSString () : base (NSObjectFlag.Empty)
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
		public NSString (NSCoder coder) : base (NSObjectFlag.Empty)
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
		protected NSString (NSObjectFlag t) : base (t)
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
		protected internal NSString (NativeHandle handle) : base (handle)
		{
		}

		[Export ("initWithData:encoding:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public NSString (NSData data, NSStringEncoding encoding)
			: base (NSObjectFlag.Empty)
		{
			var data__handle__ = data!.GetNonNullHandle (nameof (data));
			if (IsDirectBinding) {
				InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_UIntPtr (this.Handle, Selector.GetHandle ("initWithData:encoding:"), data__handle__, (UIntPtr) (ulong) encoding), "initWithData:encoding:");
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_UIntPtr (&__objc_super__, Selector.GetHandle ("initWithData:encoding:"), data__handle__, (UIntPtr) (ulong) encoding), "initWithData:encoding:");
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (data);
		}
		[Export ("stringByAbbreviatingWithTildeInPath")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSString AbbreviateTildeInPath ()
		{
			NSString ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<NSString> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("stringByAbbreviatingWithTildeInPath")), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<NSString> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("stringByAbbreviatingWithTildeInPath")), false)!;
					GC.KeepAlive (this);
				}
			}
			return ret;
		}
		[Export ("stringByAppendingPathComponent:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSString AppendPathComponent (NSString str)
		{
			var str__handle__ = str!.GetNonNullHandle (nameof (str));
			NSString? ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<NSString> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("stringByAppendingPathComponent:"), str__handle__), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<NSString> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle (&__objc_super__, Selector.GetHandle ("stringByAppendingPathComponent:"), str__handle__), false)!;
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (str);
			return ret!;
		}
		[Export ("stringByAppendingPathExtension:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSString AppendPathExtension (NSString str)
		{
			var str__handle__ = str!.GetNonNullHandle (nameof (str));
			NSString? ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<NSString> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("stringByAppendingPathExtension:"), str__handle__), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<NSString> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle (&__objc_super__, Selector.GetHandle ("stringByAppendingPathExtension:"), str__handle__), false)!;
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (str);
			return ret!;
		}
		[Export ("stringsByAppendingPaths:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string[] AppendPaths (string[] paths)
		{
			if (paths is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (paths));
			using var nsa_paths = NSArray.FromStrings (paths);
			string[] ret;
			if (IsDirectBinding) {
				ret = CFArray.StringArrayFromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("stringsByAppendingPaths:"), nsa_paths.Handle), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = CFArray.StringArrayFromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle (&__objc_super__, Selector.GetHandle ("stringsByAppendingPaths:"), nsa_paths.Handle), false)!;
					GC.KeepAlive (this);
				}
			}
			return ret;
		}
		[Export ("capitalizedStringWithLocale:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string Capitalize (NSLocale? locale)
		{
			var locale__handle__ = locale.GetHandle ();
			string? ret;
			if (IsDirectBinding) {
				ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("capitalizedStringWithLocale:"), locale__handle__), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle (&__objc_super__, Selector.GetHandle ("capitalizedStringWithLocale:"), locale__handle__), false)!;
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (locale);
			return ret!;
		}
		[Export ("commonPrefixWithString:options:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSString CommonPrefix (NSString aString, NSStringCompareOptions options)
		{
			var aString__handle__ = aString!.GetNonNullHandle (nameof (aString));
			NSString? ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<NSString> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_UIntPtr (this.Handle, Selector.GetHandle ("commonPrefixWithString:options:"), aString__handle__, (UIntPtr) (ulong) options), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<NSString> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_UIntPtr (&__objc_super__, Selector.GetHandle ("commonPrefixWithString:options:"), aString__handle__, (UIntPtr) (ulong) options), false)!;
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (aString);
			return ret!;
		}
		[Export ("compare:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSComparisonResult Compare (NSString aString)
		{
			var aString__handle__ = aString!.GetNonNullHandle (nameof (aString));
			NSComparisonResult ret;
			if (IsDirectBinding) {
				ret = (NSComparisonResult) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("compare:"), aString__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = (NSComparisonResult) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper_NativeHandle (&__objc_super__, Selector.GetHandle ("compare:"), aString__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (aString);
			return ret!;
		}
		[Export ("compare:options:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSComparisonResult Compare (NSString aString, NSStringCompareOptions mask)
		{
			var aString__handle__ = aString!.GetNonNullHandle (nameof (aString));
			NSComparisonResult ret;
			if (IsDirectBinding) {
				ret = (NSComparisonResult) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSend_NativeHandle_UIntPtr (this.Handle, Selector.GetHandle ("compare:options:"), aString__handle__, (UIntPtr) (ulong) mask);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = (NSComparisonResult) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper_NativeHandle_UIntPtr (&__objc_super__, Selector.GetHandle ("compare:options:"), aString__handle__, (UIntPtr) (ulong) mask);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (aString);
			return ret!;
		}
		[Export ("compare:options:range:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSComparisonResult Compare (NSString aString, NSStringCompareOptions mask, NSRange range)
		{
			var aString__handle__ = aString!.GetNonNullHandle (nameof (aString));
			NSComparisonResult ret;
			if (IsDirectBinding) {
				ret = (NSComparisonResult) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSend_NativeHandle_UIntPtr_NSRange (this.Handle, Selector.GetHandle ("compare:options:range:"), aString__handle__, (UIntPtr) (ulong) mask, range);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = (NSComparisonResult) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper_NativeHandle_UIntPtr_NSRange (&__objc_super__, Selector.GetHandle ("compare:options:range:"), aString__handle__, (UIntPtr) (ulong) mask, range);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (aString);
			return ret!;
		}
		[Export ("compare:options:range:locale:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSComparisonResult Compare (NSString aString, NSStringCompareOptions mask, NSRange range, NSLocale? locale)
		{
			var aString__handle__ = aString!.GetNonNullHandle (nameof (aString));
			var locale__handle__ = locale.GetHandle ();
			NSComparisonResult ret;
			if (IsDirectBinding) {
				ret = (NSComparisonResult) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSend_NativeHandle_UIntPtr_NSRange_NativeHandle (this.Handle, Selector.GetHandle ("compare:options:range:locale:"), aString__handle__, (UIntPtr) (ulong) mask, range, locale__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = (NSComparisonResult) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper_NativeHandle_UIntPtr_NSRange_NativeHandle (&__objc_super__, Selector.GetHandle ("compare:options:range:locale:"), aString__handle__, (UIntPtr) (ulong) mask, range, locale__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (aString);
			GC.KeepAlive (locale);
			return ret!;
		}
		[Export ("containsString:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool Contains (NSString str)
		{
			var str__handle__ = str!.GetNonNullHandle (nameof (str));
			byte ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("containsString:"), str__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper_NativeHandle (&__objc_super__, Selector.GetHandle ("containsString:"), str__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (str);
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
		[Export ("stringByDeletingLastPathComponent")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSString DeleteLastPathComponent ()
		{
			NSString ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<NSString> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("stringByDeletingLastPathComponent")), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<NSString> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("stringByDeletingLastPathComponent")), false)!;
					GC.KeepAlive (this);
				}
			}
			return ret;
		}
		[Export ("stringByDeletingPathExtension")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSString DeletePathExtension ()
		{
			NSString ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<NSString> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("stringByDeletingPathExtension")), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<NSString> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("stringByDeletingPathExtension")), false)!;
					GC.KeepAlive (this);
				}
			}
			return ret;
		}
		[Export ("stringEncodingForData:encodingOptions:convertedString:usedLossyConversion:")]
		[EditorBrowsable (EditorBrowsableState.Never)]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static nuint DetectStringEncoding (NSData rawData, NSDictionary options, out string convertedString, out bool usedLossyConversion)
		{
			var rawData__handle__ = rawData!.GetNonNullHandle (nameof (rawData));
			var options__handle__ = options!.GetNonNullHandle (nameof (options));
			NativeHandle convertedStringValue = IntPtr.Zero;
			fixed (bool* usedLossyConversion__pointer = &usedLossyConversion) {
			usedLossyConversion = default;
			nuint ret;
			ret = global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend_NativeHandle_NativeHandle_ref_NativeHandle_out_Boolean (class_ptr, Selector.GetHandle ("stringEncodingForData:encodingOptions:convertedString:usedLossyConversion:"), rawData__handle__, options__handle__, &convertedStringValue, (byte*) usedLossyConversion__pointer);
			GC.KeepAlive (rawData);
			GC.KeepAlive (options);
			convertedString = CFString.FromHandle (convertedStringValue)!;
			return ret!;
			}
		}
		/// <param name="rawData">To be added.</param><param name="options">To be added.</param><param name="convertedString">To be added.</param><param name="usedLossyConversion">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static nuint DetectStringEncoding (NSData rawData, EncodingDetectionOptions options, out string convertedString, out bool usedLossyConversion)
		{
			return DetectStringEncoding(rawData,options.GetDictionary ()!, out convertedString, out usedLossyConversion);
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
		[Export ("stringByExpandingTildeInPath")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSString ExpandTildeInPath ()
		{
			NSString ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<NSString> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("stringByExpandingTildeInPath")), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<NSString> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("stringByExpandingTildeInPath")), false)!;
					GC.KeepAlive (this);
				}
			}
			return ret;
		}
		/// <param name="typeIdentifier">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("itemProviderVisibilityForRepresentationWithTypeIdentifier:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSItemProviderRepresentationVisibility GetItemProviderVisibilityForTypeIdentifier (string typeIdentifier)
		{
			if (typeIdentifier is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (typeIdentifier));
			var nstypeIdentifier = CFString.CreateNative (typeIdentifier);
			NSItemProviderRepresentationVisibility ret;
			if (IsDirectBinding) {
				ret = (NSItemProviderRepresentationVisibility) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("itemProviderVisibilityForRepresentationWithTypeIdentifier:"), nstypeIdentifier);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = (NSItemProviderRepresentationVisibility) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper_NativeHandle (&__objc_super__, Selector.GetHandle ("itemProviderVisibilityForRepresentationWithTypeIdentifier:"), nstypeIdentifier);
					GC.KeepAlive (this);
				}
			}
			CFString.ReleaseNative (nstypeIdentifier);
			return ret!;
		}
		/// <param name="startPtr">To be added.</param><param name="lineEndPtr">To be added.</param><param name="contentsEndPtr">To be added.</param><param name="range">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("getLineStart:end:contentsEnd:forRange:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void GetLineStart (out nuint startPtr, out nuint lineEndPtr, out nuint contentsEndPtr, NSRange range)
		{
			fixed (nuint* startPtr__pointer = &startPtr) {
			fixed (nuint* lineEndPtr__pointer = &lineEndPtr) {
			fixed (nuint* contentsEndPtr__pointer = &contentsEndPtr) {
			startPtr = default;
			lineEndPtr = default;
			contentsEndPtr = default;
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_out_UIntPtr_out_UIntPtr_out_UIntPtr_NSRange (this.Handle, Selector.GetHandle ("getLineStart:end:contentsEnd:forRange:"), startPtr__pointer, lineEndPtr__pointer, contentsEndPtr__pointer, range);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_out_UIntPtr_out_UIntPtr_out_UIntPtr_NSRange (&__objc_super__, Selector.GetHandle ("getLineStart:end:contentsEnd:forRange:"), startPtr__pointer, lineEndPtr__pointer, contentsEndPtr__pointer, range);
					GC.KeepAlive (this);
				}
			}
			}
			}
			}
		}
		/// <param name="key">To be added.</param><param name="arguments">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("localizedUserNotificationStringForKey:arguments:")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSString GetLocalizedUserNotificationString (NSString key, params NSObject[]? arguments)
		{
			var key__handle__ = key!.GetNonNullHandle (nameof (key));
			using var nsa_arguments = arguments is null ? null : NSArray.FromNSObjects (arguments);
			NSString? ret;
			ret =  Runtime.GetNSObject<NSString> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (class_ptr, Selector.GetHandle ("localizedUserNotificationStringForKey:arguments:"), key__handle__, nsa_arguments.GetHandle ()), false)!;
			GC.KeepAlive (key);
			return ret!;
		}
		[Export ("objectWithItemProviderData:typeIdentifier:error:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static NSString? GetObject (NSData data, string typeIdentifier, out NSError? outError)
		{
			var data__handle__ = data!.GetNonNullHandle (nameof (data));
			if (typeIdentifier is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (typeIdentifier));
			NativeHandle outErrorValue = IntPtr.Zero;
			var nstypeIdentifier = CFString.CreateNative (typeIdentifier);
			NSString? ret;
			ret =  Runtime.GetNSObject<NSString> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_ref_NativeHandle (class_ptr, Selector.GetHandle ("objectWithItemProviderData:typeIdentifier:error:"), data__handle__, nstypeIdentifier, &outErrorValue), false)!;
			GC.KeepAlive (data);
			CFString.ReleaseNative (nstypeIdentifier);
			outError = Runtime.GetNSObject<NSError> (outErrorValue)!;
			return ret!;
		}
		/// <param name="paragraphStartPosition">To be added.</param><param name="paragraphEndPosition">To be added.</param><param name="contentsEndPosition">To be added.</param><param name="range">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("getParagraphStart:end:contentsEnd:forRange:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void GetParagraphPositions (out nuint paragraphStartPosition, out nuint paragraphEndPosition, out nuint contentsEndPosition, NSRange range)
		{
			fixed (nuint* paragraphStartPosition__pointer = &paragraphStartPosition) {
			fixed (nuint* paragraphEndPosition__pointer = &paragraphEndPosition) {
			fixed (nuint* contentsEndPosition__pointer = &contentsEndPosition) {
			paragraphStartPosition = default;
			paragraphEndPosition = default;
			contentsEndPosition = default;
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_out_UIntPtr_out_UIntPtr_out_UIntPtr_NSRange (this.Handle, Selector.GetHandle ("getParagraphStart:end:contentsEnd:forRange:"), paragraphStartPosition__pointer, paragraphEndPosition__pointer, contentsEndPosition__pointer, range);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_out_UIntPtr_out_UIntPtr_out_UIntPtr_NSRange (&__objc_super__, Selector.GetHandle ("getParagraphStart:end:contentsEnd:forRange:"), paragraphStartPosition__pointer, paragraphEndPosition__pointer, contentsEndPosition__pointer, range);
					GC.KeepAlive (this);
				}
			}
			}
			}
			}
		}
		[Export ("paragraphRangeForRange:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSRange GetParagraphRange (NSRange range)
		{
			NSRange ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.NSRange_objc_msgSend_NSRange (this.Handle, Selector.GetHandle ("paragraphRangeForRange:"), range);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.NSRange_objc_msgSendSuper_NSRange (&__objc_super__, Selector.GetHandle ("paragraphRangeForRange:"), range);
					GC.KeepAlive (this);
				}
			}
			return ret;
		}
		/// <param name="width">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("variantFittingPresentationWidth:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSString GetVariantFittingPresentationWidth (nint width)
		{
			NSString ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<NSString> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("variantFittingPresentationWidth:"), width), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<NSString> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_IntPtr (&__objc_super__, Selector.GetHandle ("variantFittingPresentationWidth:"), width), false)!;
					GC.KeepAlive (this);
				}
			}
			return ret;
		}
		[Export ("hasPrefix:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool HasPrefix (NSString prefix)
		{
			var prefix__handle__ = prefix!.GetNonNullHandle (nameof (prefix));
			byte ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("hasPrefix:"), prefix__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper_NativeHandle (&__objc_super__, Selector.GetHandle ("hasPrefix:"), prefix__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (prefix);
			return ret != 0;
		}
		[Export ("hasSuffix:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool HasSuffix (NSString suffix)
		{
			var suffix__handle__ = suffix!.GetNonNullHandle (nameof (suffix));
			byte ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("hasSuffix:"), suffix__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper_NativeHandle (&__objc_super__, Selector.GetHandle ("hasSuffix:"), suffix__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (suffix);
			return ret != 0;
		}
		/// <param name="handle">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public bool IsEqualTo (nint handle)
		{
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("isEqualToString:"), handle);
			return ret != 0;
		}
		[Export ("lineRangeForRange:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSRange LineRangeForRange (NSRange range)
		{
			NSRange ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.NSRange_objc_msgSend_NSRange (this.Handle, Selector.GetHandle ("lineRangeForRange:"), range);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.NSRange_objc_msgSendSuper_NSRange (&__objc_super__, Selector.GetHandle ("lineRangeForRange:"), range);
					GC.KeepAlive (this);
				}
			}
			return ret;
		}
		/// <param name="typeIdentifier">A Universal Type Identifier (UTI) indicating the type of data to load.</param><param name="completionHandler">The method called after the data is loaded.</param><summary>Implement this method to customize the loading of data by an <see cref="T:Foundation.NSItemProvider" />.</summary><returns>An <see cref="T:Foundation.NSProgress" /> object reflecting the data-loading operation.</returns><remarks><para>The <paramref name="typeIdentifier" /> must be in the set of values returned by <see cref="Foundation.NSItemProviderWriting_Extensions.GetWritableTypeIdentifiersForItemProvider(Foundation.INSItemProviderWriting)" />.</para></remarks>
		[Export ("loadDataWithTypeIdentifier:forItemProviderCompletionHandler:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual NSProgress? LoadData (string typeIdentifier, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity2V16))]global::System.Action<NSData, NSError> completionHandler)
		{
			if (typeIdentifier is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (typeIdentifier));
			if (completionHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completionHandler));
			var nstypeIdentifier = CFString.CreateNative (typeIdentifier);
			using var block_completionHandler = Trampolines.SDActionArity2V16.CreateBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = &block_completionHandler;
			NSProgress? ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<NSProgress> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("loadDataWithTypeIdentifier:forItemProviderCompletionHandler:"), nstypeIdentifier, (IntPtr) block_ptr_completionHandler), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<NSProgress> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, Selector.GetHandle ("loadDataWithTypeIdentifier:forItemProviderCompletionHandler:"), nstypeIdentifier, (IntPtr) block_ptr_completionHandler), false)!;
					GC.KeepAlive (this);
				}
			}
			CFString.ReleaseNative (nstypeIdentifier);
			return ret!;
		}
		/// <param name="typeIdentifier">A Universal Type Identifier (UTI) indicating the type of data to load.</param>
		/// <summary>Asynchronously loads data for the identified type from an item provider, returning a task that contains the data.</summary>
		/// <returns>To be added.</returns>
		/// <remarks>To be added.</remarks>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual Task<NSData> LoadDataAsync (string typeIdentifier)
		{
			var tcs = new TaskCompletionSource<NSData> ();
			LoadData(typeIdentifier, (arg1_, arg2_) => {
				if (arg2_ is not null)
					tcs.SetException (new NSErrorException(arg2_));
				else
					tcs.SetResult (arg1_!);
			});
			return tcs.Task;
		}
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual Task<NSData> LoadDataAsync (string typeIdentifier, out NSProgress result)
		{
			var tcs = new TaskCompletionSource<NSData> ();
			result = LoadData(typeIdentifier, (arg1_, arg2_) => {
				if (arg2_ is not null)
					tcs.SetException (new NSErrorException(arg2_));
				else
					tcs.SetResult (arg1_!);
			})!;
			return tcs.Task;
		}
		[Export ("localizedCaseInsensitiveContainsString:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool LocalizedCaseInsensitiveContains (NSString str)
		{
			var str__handle__ = str!.GetNonNullHandle (nameof (str));
			byte ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("localizedCaseInsensitiveContainsString:"), str__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper_NativeHandle (&__objc_super__, Selector.GetHandle ("localizedCaseInsensitiveContainsString:"), str__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (str);
			return ret != 0;
		}
		[Export ("localizedStandardContainsString:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool LocalizedStandardContainsString (NSString str)
		{
			var str__handle__ = str!.GetNonNullHandle (nameof (str));
			byte ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("localizedStandardContainsString:"), str__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper_NativeHandle (&__objc_super__, Selector.GetHandle ("localizedStandardContainsString:"), str__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (str);
			return ret != 0;
		}
		[Export ("localizedStandardRangeOfString:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSRange LocalizedStandardRangeOfString (NSString str)
		{
			var str__handle__ = str!.GetNonNullHandle (nameof (str));
			NSRange ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.NSRange_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("localizedStandardRangeOfString:"), str__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.NSRange_objc_msgSendSuper_NativeHandle (&__objc_super__, Selector.GetHandle ("localizedStandardRangeOfString:"), str__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (str);
			return ret!;
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
		[Export ("pathWithComponents:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static string[] PathWithComponents (string[] components)
		{
			if (components is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (components));
			using var nsa_components = NSArray.FromStrings (components);
			string[] ret;
			ret = CFArray.StringArrayFromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (class_ptr, Selector.GetHandle ("pathWithComponents:"), nsa_components.Handle), false)!;
			return ret;
		}
		[Export ("stringByReplacingCharactersInRange:withString:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSString Replace (NSRange range, NSString replacement)
		{
			var replacement__handle__ = replacement!.GetNonNullHandle (nameof (replacement));
			NSString? ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<NSString> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NSRange_NativeHandle (this.Handle, Selector.GetHandle ("stringByReplacingCharactersInRange:withString:"), range, replacement__handle__), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<NSString> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NSRange_NativeHandle (&__objc_super__, Selector.GetHandle ("stringByReplacingCharactersInRange:withString:"), range, replacement__handle__), false)!;
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (replacement);
			return ret!;
		}
		[Export ("stringByResolvingSymlinksInPath")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSString ResolveSymlinksInPath ()
		{
			NSString ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<NSString> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("stringByResolvingSymlinksInPath")), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<NSString> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("stringByResolvingSymlinksInPath")), false)!;
					GC.KeepAlive (this);
				}
			}
			return ret;
		}
		[Export ("componentsSeparatedByString:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSString[] SeparateComponents (NSString separator)
		{
			var separator__handle__ = separator!.GetNonNullHandle (nameof (separator));
			NSString[]? ret;
			if (IsDirectBinding) {
				ret = CFArray.ArrayFromHandle<NSString>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("componentsSeparatedByString:"), separator__handle__), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = CFArray.ArrayFromHandle<NSString>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle (&__objc_super__, Selector.GetHandle ("componentsSeparatedByString:"), separator__handle__), false)!;
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (separator);
			return ret!;
		}
		[Export ("componentsSeparatedByCharactersInSet:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSString[] SeparateComponents (NSCharacterSet separator)
		{
			var separator__handle__ = separator!.GetNonNullHandle (nameof (separator));
			NSString[]? ret;
			if (IsDirectBinding) {
				ret = CFArray.ArrayFromHandle<NSString>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("componentsSeparatedByCharactersInSet:"), separator__handle__), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = CFArray.ArrayFromHandle<NSString>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle (&__objc_super__, Selector.GetHandle ("componentsSeparatedByCharactersInSet:"), separator__handle__), false)!;
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (separator);
			return ret!;
		}
		[Export ("stringByStandardizingPath")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSString StandarizePath ()
		{
			NSString ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<NSString> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("stringByStandardizingPath")), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<NSString> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("stringByStandardizingPath")), false)!;
					GC.KeepAlive (this);
				}
			}
			return ret;
		}
		[Export ("lowercaseStringWithLocale:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string ToLower (NSLocale locale)
		{
			var locale__handle__ = locale!.GetNonNullHandle (nameof (locale));
			string? ret;
			if (IsDirectBinding) {
				ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("lowercaseStringWithLocale:"), locale__handle__), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle (&__objc_super__, Selector.GetHandle ("lowercaseStringWithLocale:"), locale__handle__), false)!;
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (locale);
			return ret!;
		}
		[Export ("uppercaseStringWithLocale:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string ToUpper (NSLocale locale)
		{
			var locale__handle__ = locale!.GetNonNullHandle (nameof (locale));
			string? ret;
			if (IsDirectBinding) {
				ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("uppercaseStringWithLocale:"), locale__handle__), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle (&__objc_super__, Selector.GetHandle ("uppercaseStringWithLocale:"), locale__handle__), false)!;
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (locale);
			return ret!;
		}
		[Export ("stringByApplyingTransform:reverse:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSString? TransliterateString (NSString transform, bool reverse)
		{
			var transform__handle__ = transform!.GetNonNullHandle (nameof (transform));
			NSString? ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<NSString> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_bool (this.Handle, Selector.GetHandle ("stringByApplyingTransform:reverse:"), transform__handle__, reverse ? (byte) 1 : (byte) 0), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<NSString> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_bool (&__objc_super__, Selector.GetHandle ("stringByApplyingTransform:reverse:"), transform__handle__, reverse ? (byte) 1 : (byte) 0), false)!;
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (transform);
			return ret!;
		}
		[Export ("characterAtIndex:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal virtual char _characterAtIndex (nint index)
		{
			ushort ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.char_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("characterAtIndex:"), index);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.char_objc_msgSendSuper_IntPtr (&__objc_super__, Selector.GetHandle ("characterAtIndex:"), index);
					GC.KeepAlive (this);
				}
			}
			return (char) ret;
		}
		/// <summary>Whether this is an absolute path.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool IsAbsolutePath {
			[Export ("isAbsolutePath")]
			get {
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("isAbsolutePath"));
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("isAbsolutePath"));
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSString LastPathComponent {
			[Export ("lastPathComponent")]
			get {
				NSString? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSString> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("lastPathComponent")), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<NSString> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("lastPathComponent")), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual nint Length {
			[Export ("length")]
			get {
				nint ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("length"));
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("length"));
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public virtual NSString LocalizedCapitalizedString {
			[Export ("localizedCapitalizedString")]
			get {
				NSString? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSString> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("localizedCapitalizedString")), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<NSString> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("localizedCapitalizedString")), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public virtual NSString LocalizedLowercaseString {
			[Export ("localizedLowercaseString")]
			get {
				NSString? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSString> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("localizedLowercaseString")), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<NSString> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("localizedLowercaseString")), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public virtual NSString LocalizedUppercaseString {
			[Export ("localizedUppercaseString")]
			get {
				NSString? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSString> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("localizedUppercaseString")), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<NSString> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("localizedUppercaseString")), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string[] PathComponents {
			[Export ("pathComponents")]
			get {
				string[] ret;
				if (IsDirectBinding) {
					ret = CFArray.StringArrayFromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("pathComponents")), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFArray.StringArrayFromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("pathComponents")), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSString PathExtension {
			[Export ("pathExtension")]
			get {
				NSString? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSString> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("pathExtension")), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<NSString> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("pathExtension")), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static string[] ReadableTypeIdentifiers {
			[Export ("readableTypeIdentifiersForItemProvider", ArgumentSemantic.Copy)]
			get {
				string[] ret;
				ret = CFArray.StringArrayFromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (class_ptr, Selector.GetHandle ("readableTypeIdentifiersForItemProvider")), false)!;
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static string[] WritableTypeIdentifiers {
			[Export ("writableTypeIdentifiersForItemProvider", ArgumentSemantic.Copy)]
			get {
				string[] ret;
				ret = CFArray.StringArrayFromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (class_ptr, Selector.GetHandle ("writableTypeIdentifiersForItemProvider")), false)!;
				return ret;
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public virtual string[] WritableTypeIdentifiersForItemProvider {
			[Export ("writableTypeIdentifiersForItemProvider", ArgumentSemantic.Copy)]
			get {
				string[] ret;
				if (IsDirectBinding) {
					ret = CFArray.StringArrayFromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("writableTypeIdentifiersForItemProvider")), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFArray.StringArrayFromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("writableTypeIdentifiersForItemProvider")), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _EncodingDetectionAllowLossyKey;
		/// <summary>Represents the value associated with the constant 'NSStringEncodingDetectionAllowLossyKey'.</summary>
		[Field ("NSStringEncodingDetectionAllowLossyKey",  "Foundation")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		internal static NSString EncodingDetectionAllowLossyKey {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_EncodingDetectionAllowLossyKey is null)
					_EncodingDetectionAllowLossyKey = Dlfcn.GetStringConstant (Libraries.Foundation.Handle, "NSStringEncodingDetectionAllowLossyKey")!;
				return _EncodingDetectionAllowLossyKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _EncodingDetectionDisallowedEncodingsKey;
		/// <summary>Represents the value associated with the constant 'NSStringEncodingDetectionDisallowedEncodingsKey'.</summary>
		[Field ("NSStringEncodingDetectionDisallowedEncodingsKey",  "Foundation")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		internal static NSString EncodingDetectionDisallowedEncodingsKey {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_EncodingDetectionDisallowedEncodingsKey is null)
					_EncodingDetectionDisallowedEncodingsKey = Dlfcn.GetStringConstant (Libraries.Foundation.Handle, "NSStringEncodingDetectionDisallowedEncodingsKey")!;
				return _EncodingDetectionDisallowedEncodingsKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _EncodingDetectionFromWindowsKey;
		/// <summary>Represents the value associated with the constant 'NSStringEncodingDetectionFromWindowsKey'.</summary>
		[Field ("NSStringEncodingDetectionFromWindowsKey",  "Foundation")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		internal static NSString EncodingDetectionFromWindowsKey {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_EncodingDetectionFromWindowsKey is null)
					_EncodingDetectionFromWindowsKey = Dlfcn.GetStringConstant (Libraries.Foundation.Handle, "NSStringEncodingDetectionFromWindowsKey")!;
				return _EncodingDetectionFromWindowsKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _EncodingDetectionLikelyLanguageKey;
		/// <summary>Represents the value associated with the constant 'NSStringEncodingDetectionLikelyLanguageKey'.</summary>
		[Field ("NSStringEncodingDetectionLikelyLanguageKey",  "Foundation")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		internal static NSString EncodingDetectionLikelyLanguageKey {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_EncodingDetectionLikelyLanguageKey is null)
					_EncodingDetectionLikelyLanguageKey = Dlfcn.GetStringConstant (Libraries.Foundation.Handle, "NSStringEncodingDetectionLikelyLanguageKey")!;
				return _EncodingDetectionLikelyLanguageKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _EncodingDetectionLossySubstitutionKey;
		/// <summary>Represents the value associated with the constant 'NSStringEncodingDetectionLossySubstitutionKey'.</summary>
		[Field ("NSStringEncodingDetectionLossySubstitutionKey",  "Foundation")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		internal static NSString EncodingDetectionLossySubstitutionKey {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_EncodingDetectionLossySubstitutionKey is null)
					_EncodingDetectionLossySubstitutionKey = Dlfcn.GetStringConstant (Libraries.Foundation.Handle, "NSStringEncodingDetectionLossySubstitutionKey")!;
				return _EncodingDetectionLossySubstitutionKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _EncodingDetectionSuggestedEncodingsKey;
		/// <summary>Represents the value associated with the constant 'NSStringEncodingDetectionSuggestedEncodingsKey'.</summary>
		[Field ("NSStringEncodingDetectionSuggestedEncodingsKey",  "Foundation")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		internal static NSString EncodingDetectionSuggestedEncodingsKey {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_EncodingDetectionSuggestedEncodingsKey is null)
					_EncodingDetectionSuggestedEncodingsKey = Dlfcn.GetStringConstant (Libraries.Foundation.Handle, "NSStringEncodingDetectionSuggestedEncodingsKey")!;
				return _EncodingDetectionSuggestedEncodingsKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _EncodingDetectionUseOnlySuggestedEncodingsKey;
		/// <summary>Represents the value associated with the constant 'NSStringEncodingDetectionUseOnlySuggestedEncodingsKey'.</summary>
		[Field ("NSStringEncodingDetectionUseOnlySuggestedEncodingsKey",  "Foundation")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		internal static NSString EncodingDetectionUseOnlySuggestedEncodingsKey {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_EncodingDetectionUseOnlySuggestedEncodingsKey is null)
					_EncodingDetectionUseOnlySuggestedEncodingsKey = Dlfcn.GetStringConstant (Libraries.Foundation.Handle, "NSStringEncodingDetectionUseOnlySuggestedEncodingsKey")!;
				return _EncodingDetectionUseOnlySuggestedEncodingsKey;
			}
		}
	} /* class NSString */
}
