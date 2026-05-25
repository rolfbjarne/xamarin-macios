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
	[Register("NSRegularExpression", true)]
	public unsafe partial class NSRegularExpression : NSObject, INSCoding, INSCopying, INSSecureCoding {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selCopyWithZone_X = "copyWithZone:";
		static readonly NativeHandle selCopyWithZone_XHandle = Selector.GetHandle ("copyWithZone:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selEncodeWithCoder_X = "encodeWithCoder:";
		static readonly NativeHandle selEncodeWithCoder_XHandle = Selector.GetHandle ("encodeWithCoder:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selEnumerateMatchesInString_Options_Range_UsingBlock_X = "enumerateMatchesInString:options:range:usingBlock:";
		static readonly NativeHandle selEnumerateMatchesInString_Options_Range_UsingBlock_XHandle = Selector.GetHandle ("enumerateMatchesInString:options:range:usingBlock:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selEscapedPatternForString_X = "escapedPatternForString:";
		static readonly NativeHandle selEscapedPatternForString_XHandle = Selector.GetHandle ("escapedPatternForString:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selEscapedTemplateForString_X = "escapedTemplateForString:";
		static readonly NativeHandle selEscapedTemplateForString_XHandle = Selector.GetHandle ("escapedTemplateForString:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selFirstMatchInString_Options_Range_X = "firstMatchInString:options:range:";
		static readonly NativeHandle selFirstMatchInString_Options_Range_XHandle = Selector.GetHandle ("firstMatchInString:options:range:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selInitWithCoder_X = "initWithCoder:";
		static readonly NativeHandle selInitWithCoder_XHandle = Selector.GetHandle ("initWithCoder:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selInitWithPattern_Options_Error_X = "initWithPattern:options:error:";
		static readonly NativeHandle selInitWithPattern_Options_Error_XHandle = Selector.GetHandle ("initWithPattern:options:error:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selMatchesInString_Options_Range_X = "matchesInString:options:range:";
		static readonly NativeHandle selMatchesInString_Options_Range_XHandle = Selector.GetHandle ("matchesInString:options:range:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selNumberOfCaptureGroupsX = "numberOfCaptureGroups";
		static readonly NativeHandle selNumberOfCaptureGroupsXHandle = Selector.GetHandle ("numberOfCaptureGroups");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selNumberOfMatchesInString_Options_Range_X = "numberOfMatchesInString:options:range:";
		static readonly NativeHandle selNumberOfMatchesInString_Options_Range_XHandle = Selector.GetHandle ("numberOfMatchesInString:options:range:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selOptionsX = "options";
		static readonly NativeHandle selOptionsXHandle = Selector.GetHandle ("options");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selPatternX = "pattern";
		static readonly NativeHandle selPatternXHandle = Selector.GetHandle ("pattern");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selRangeOfFirstMatchInString_Options_Range_X = "rangeOfFirstMatchInString:options:range:";
		static readonly NativeHandle selRangeOfFirstMatchInString_Options_Range_XHandle = Selector.GetHandle ("rangeOfFirstMatchInString:options:range:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selRegularExpressionWithPattern_Options_Error_X = "regularExpressionWithPattern:options:error:";
		static readonly NativeHandle selRegularExpressionWithPattern_Options_Error_XHandle = Selector.GetHandle ("regularExpressionWithPattern:options:error:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selReplaceMatchesInString_Options_Range_WithTemplate_X = "replaceMatchesInString:options:range:withTemplate:";
		static readonly NativeHandle selReplaceMatchesInString_Options_Range_WithTemplate_XHandle = Selector.GetHandle ("replaceMatchesInString:options:range:withTemplate:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selReplacementStringForResult_InString_Offset_Template_X = "replacementStringForResult:inString:offset:template:";
		static readonly NativeHandle selReplacementStringForResult_InString_Offset_Template_XHandle = Selector.GetHandle ("replacementStringForResult:inString:offset:template:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selStringByReplacingMatchesInString_Options_Range_WithTemplate_X = "stringByReplacingMatchesInString:options:range:withTemplate:";
		static readonly NativeHandle selStringByReplacingMatchesInString_Options_Range_WithTemplate_XHandle = Selector.GetHandle ("stringByReplacingMatchesInString:options:range:withTemplate:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly NativeHandle class_ptr = Class.GetHandle ("NSRegularExpression");
		/// <summary>The Objective-C class handle for this class.</summary>
		/// <value>The pointer to the Objective-C class.</value>
		/// <remarks>
		///     Each managed class mirrors an unmanaged Objective-C class.
		///     This value contains the pointer to the Objective-C class.
		///     It is similar to calling the managed <see cref="ObjCRuntime.Class.GetHandle(string)" /> or the native <see href="https://developer.apple.com/documentation/objectivec/1418952-objc_getclass">objc_getClass</see> method with the type name.
		/// </remarks>
		public override NativeHandle ClassHandle { get { return class_ptr; } }
		/// <summary>Creates a new <see cref="NSRegularExpression" /> with default values.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public NSRegularExpression () : base (NSObjectFlag.Empty)
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
		public NSRegularExpression (NSCoder coder) : base (NSObjectFlag.Empty)
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
		protected NSRegularExpression (NSObjectFlag t) : base (t)
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
		protected internal NSRegularExpression (NativeHandle handle) : base (handle)
		{
		}

		[Export ("initWithPattern:options:error:")]
		[DesignatedInitializer]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe NSRegularExpression (NSString pattern, NSRegularExpressionOptions options, out NSError error)
			: base (NSObjectFlag.Empty)
		{
			var pattern__handle__ = pattern!.GetNonNullHandle (nameof (pattern));
			NativeHandle errorValue = IntPtr.Zero;
			if (IsDirectBinding) {
				InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_UIntPtr_ref_NativeHandle (this.Handle, selInitWithPattern_Options_Error_XHandle, pattern__handle__, (UIntPtr) (ulong) options, &errorValue), "initWithPattern:options:error:");
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_UIntPtr_ref_NativeHandle (&__objc_super__, selInitWithPattern_Options_Error_XHandle, pattern__handle__, (UIntPtr) (ulong) options, &errorValue), "initWithPattern:options:error:");
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (pattern);
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
		[Export ("regularExpressionWithPattern:options:error:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static NSRegularExpression Create (NSString pattern, NSRegularExpressionOptions options, out NSError error)
		{
			var pattern__handle__ = pattern!.GetNonNullHandle (nameof (pattern));
			NativeHandle errorValue = IntPtr.Zero;
			NSRegularExpression? ret;
			ret =  Runtime.GetNSObject<NSRegularExpression> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_UIntPtr_ref_NativeHandle (class_ptr, selRegularExpressionWithPattern_Options_Error_XHandle, pattern__handle__, (UIntPtr) (ulong) options, &errorValue), false)!;
			GC.KeepAlive (pattern);
			error = Runtime.GetNSObject<NSError> (errorValue)!;
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
		[Export ("enumerateMatchesInString:options:range:usingBlock:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void EnumerateMatches (NSString str, NSMatchingOptions options, NSRange range, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDNSMatchEnumerator))]NSMatchEnumerator enumerator)
		{
			var str__handle__ = str!.GetNonNullHandle (nameof (str));
			if (enumerator is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (enumerator));
			using var block_enumerator = Trampolines.SDNSMatchEnumerator.CreateBlock (enumerator);
			BlockLiteral *block_ptr_enumerator = &block_enumerator;
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_UIntPtr_NSRange_NativeHandle (this.Handle, selEnumerateMatchesInString_Options_Range_UsingBlock_XHandle, str__handle__, (UIntPtr) (ulong) options, range, (IntPtr) block_ptr_enumerator);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_UIntPtr_NSRange_NativeHandle (&__objc_super__, selEnumerateMatchesInString_Options_Range_UsingBlock_XHandle, str__handle__, (UIntPtr) (ulong) options, range, (IntPtr) block_ptr_enumerator);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (str);
		}
		[Export ("firstMatchInString:options:range:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSTextCheckingResult? FindFirstMatch (string str, NSMatchingOptions options, NSRange range)
		{
			if (str is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (str));
			var nsstr = CFString.CreateNative (str);
			NSTextCheckingResult? ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<NSTextCheckingResult> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_UIntPtr_NSRange (this.Handle, selFirstMatchInString_Options_Range_XHandle, nsstr, (UIntPtr) (ulong) options, range), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<NSTextCheckingResult> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_UIntPtr_NSRange (&__objc_super__, selFirstMatchInString_Options_Range_XHandle, nsstr, (UIntPtr) (ulong) options, range), false)!;
					GC.KeepAlive (this);
				}
			}
			CFString.ReleaseNative (nsstr);
			return ret!;
		}
		[Export ("escapedPatternForString:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSString GetEscapedPattern (NSString str)
		{
			var str__handle__ = str!.GetNonNullHandle (nameof (str));
			NSString? ret;
			ret =  Runtime.GetNSObject<NSString> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (class_ptr, selEscapedPatternForString_XHandle, str__handle__), false)!;
			GC.KeepAlive (str);
			return ret!;
		}
		[Export ("escapedTemplateForString:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSString GetEscapedTemplate (NSString str)
		{
			var str__handle__ = str!.GetNonNullHandle (nameof (str));
			NSString? ret;
			ret =  Runtime.GetNSObject<NSString> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (class_ptr, selEscapedTemplateForString_XHandle, str__handle__), false)!;
			GC.KeepAlive (str);
			return ret!;
		}
		[Export ("matchesInString:options:range:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSTextCheckingResult[] GetMatches (NSString str, NSMatchingOptions options, NSRange range)
		{
			var str__handle__ = str!.GetNonNullHandle (nameof (str));
			NSTextCheckingResult[]? ret;
			if (IsDirectBinding) {
				ret = CFArray.ArrayFromHandle<NSTextCheckingResult>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_UIntPtr_NSRange (this.Handle, selMatchesInString_Options_Range_XHandle, str__handle__, (UIntPtr) (ulong) options, range), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = CFArray.ArrayFromHandle<NSTextCheckingResult>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_UIntPtr_NSRange (&__objc_super__, selMatchesInString_Options_Range_XHandle, str__handle__, (UIntPtr) (ulong) options, range), false)!;
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (str);
			return ret!;
		}
		[Export ("numberOfMatchesInString:options:range:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual nuint GetNumberOfMatches (NSString str, NSMatchingOptions options, NSRange range)
		{
			var str__handle__ = str!.GetNonNullHandle (nameof (str));
			nuint ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend_NativeHandle_UIntPtr_NSRange (this.Handle, selNumberOfMatchesInString_Options_Range_XHandle, str__handle__, (UIntPtr) (ulong) options, range);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.UIntPtr_objc_msgSendSuper_NativeHandle_UIntPtr_NSRange (&__objc_super__, selNumberOfMatchesInString_Options_Range_XHandle, str__handle__, (UIntPtr) (ulong) options, range);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (str);
			return ret!;
		}
		[Export ("rangeOfFirstMatchInString:options:range:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSRange GetRangeOfFirstMatch (string str, NSMatchingOptions options, NSRange range)
		{
			if (str is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (str));
			var nsstr = CFString.CreateNative (str);
			NSRange ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.NSRange_objc_msgSend_NativeHandle_UIntPtr_NSRange (this.Handle, selRangeOfFirstMatchInString_Options_Range_XHandle, nsstr, (UIntPtr) (ulong) options, range);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.NSRange_objc_msgSendSuper_NativeHandle_UIntPtr_NSRange (&__objc_super__, selRangeOfFirstMatchInString_Options_Range_XHandle, nsstr, (UIntPtr) (ulong) options, range);
					GC.KeepAlive (this);
				}
			}
			CFString.ReleaseNative (nsstr);
			return ret!;
		}
		/// <param name="result">To be added.</param><param name="str">To be added.</param><param name="offset">To be added.</param><param name="template">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("replacementStringForResult:inString:offset:template:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSString GetReplacementString (NSTextCheckingResult result, NSString str, nint offset, NSString template)
		{
			var result__handle__ = result!.GetNonNullHandle (nameof (result));
			var str__handle__ = str!.GetNonNullHandle (nameof (str));
			var template__handle__ = template!.GetNonNullHandle (nameof (template));
			NSString? ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<NSString> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_IntPtr_NativeHandle (this.Handle, selReplacementStringForResult_InString_Offset_Template_XHandle, result__handle__, str__handle__, offset, template__handle__), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<NSString> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_NativeHandle_IntPtr_NativeHandle (&__objc_super__, selReplacementStringForResult_InString_Offset_Template_XHandle, result__handle__, str__handle__, offset, template__handle__), false)!;
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (result);
			GC.KeepAlive (str);
			GC.KeepAlive (template);
			return ret!;
		}
		[Export ("stringByReplacingMatchesInString:options:range:withTemplate:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string ReplaceMatches (string sourceString, NSMatchingOptions options, NSRange range, string template)
		{
			if (sourceString is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (sourceString));
			if (template is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (template));
			var nssourceString = CFString.CreateNative (sourceString);
			var nstemplate = CFString.CreateNative (template);
			string? ret;
			if (IsDirectBinding) {
				ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_UIntPtr_NSRange_NativeHandle (this.Handle, selStringByReplacingMatchesInString_Options_Range_WithTemplate_XHandle, nssourceString, (UIntPtr) (ulong) options, range, nstemplate), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_UIntPtr_NSRange_NativeHandle (&__objc_super__, selStringByReplacingMatchesInString_Options_Range_WithTemplate_XHandle, nssourceString, (UIntPtr) (ulong) options, range, nstemplate), false)!;
					GC.KeepAlive (this);
				}
			}
			CFString.ReleaseNative (nssourceString);
			CFString.ReleaseNative (nstemplate);
			return ret!;
		}
		[Export ("replaceMatchesInString:options:range:withTemplate:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual nuint ReplaceMatches (NSMutableString mutableString, NSMatchingOptions options, NSRange range, NSString template)
		{
			var mutableString__handle__ = mutableString!.GetNonNullHandle (nameof (mutableString));
			var template__handle__ = template!.GetNonNullHandle (nameof (template));
			nuint ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend_NativeHandle_UIntPtr_NSRange_NativeHandle (this.Handle, selReplaceMatchesInString_Options_Range_WithTemplate_XHandle, mutableString__handle__, (UIntPtr) (ulong) options, range, template__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.UIntPtr_objc_msgSendSuper_NativeHandle_UIntPtr_NSRange_NativeHandle (&__objc_super__, selReplaceMatchesInString_Options_Range_WithTemplate_XHandle, mutableString__handle__, (UIntPtr) (ulong) options, range, template__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (mutableString);
			GC.KeepAlive (template);
			return ret!;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual nuint NumberOfCaptureGroups {
			[Export ("numberOfCaptureGroups")]
			get {
				nuint ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend (this.Handle, selNumberOfCaptureGroupsXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.UIntPtr_objc_msgSendSuper (&__objc_super__, selNumberOfCaptureGroupsXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSRegularExpressionOptions Options {
			[Export ("options")]
			get {
				NSRegularExpressionOptions ret;
				if (IsDirectBinding) {
					ret = (NSRegularExpressionOptions) (ulong) global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend (this.Handle, selOptionsXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = (NSRegularExpressionOptions) (ulong) global::ObjCRuntime.Messaging.UIntPtr_objc_msgSendSuper (&__objc_super__, selOptionsXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSString Pattern {
			[Export ("pattern")]
			get {
				NSString? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSString> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selPatternXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<NSString> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selPatternXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
	} /* class NSRegularExpression */
}
