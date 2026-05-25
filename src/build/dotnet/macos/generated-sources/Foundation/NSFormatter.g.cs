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
	[Register("NSFormatter", true)]
	public unsafe partial class NSFormatter : NSObject, INSCoding, INSCopying {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAttributedStringForObjectValue_WithDefaultAttributes_X = "attributedStringForObjectValue:withDefaultAttributes:";
		static readonly NativeHandle selAttributedStringForObjectValue_WithDefaultAttributes_XHandle = Selector.GetHandle ("attributedStringForObjectValue:withDefaultAttributes:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selCopyWithZone_X = "copyWithZone:";
		static readonly NativeHandle selCopyWithZone_XHandle = Selector.GetHandle ("copyWithZone:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selEditingStringForObjectValue_X = "editingStringForObjectValue:";
		static readonly NativeHandle selEditingStringForObjectValue_XHandle = Selector.GetHandle ("editingStringForObjectValue:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selEncodeWithCoder_X = "encodeWithCoder:";
		static readonly NativeHandle selEncodeWithCoder_XHandle = Selector.GetHandle ("encodeWithCoder:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selGetObjectValue_ForString_ErrorDescription_X = "getObjectValue:forString:errorDescription:";
		static readonly NativeHandle selGetObjectValue_ForString_ErrorDescription_XHandle = Selector.GetHandle ("getObjectValue:forString:errorDescription:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selInitWithCoder_X = "initWithCoder:";
		static readonly NativeHandle selInitWithCoder_XHandle = Selector.GetHandle ("initWithCoder:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selIsPartialStringValid_NewEditingString_ErrorDescription_X = "isPartialStringValid:newEditingString:errorDescription:";
		static readonly NativeHandle selIsPartialStringValid_NewEditingString_ErrorDescription_XHandle = Selector.GetHandle ("isPartialStringValid:newEditingString:errorDescription:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selIsPartialStringValid_ProposedSelectedRange_OriginalString_OriginalSelectedRange_ErrorDescription_X = "isPartialStringValid:proposedSelectedRange:originalString:originalSelectedRange:errorDescription:";
		static readonly NativeHandle selIsPartialStringValid_ProposedSelectedRange_OriginalString_OriginalSelectedRange_ErrorDescription_XHandle = Selector.GetHandle ("isPartialStringValid:proposedSelectedRange:originalString:originalSelectedRange:errorDescription:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selStringForObjectValue_X = "stringForObjectValue:";
		static readonly NativeHandle selStringForObjectValue_XHandle = Selector.GetHandle ("stringForObjectValue:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly NativeHandle class_ptr = Class.GetHandle ("NSFormatter");
		/// <summary>The Objective-C class handle for this class.</summary>
		/// <value>The pointer to the Objective-C class.</value>
		/// <remarks>
		///     Each managed class mirrors an unmanaged Objective-C class.
		///     This value contains the pointer to the Objective-C class.
		///     It is similar to calling the managed <see cref="ObjCRuntime.Class.GetHandle(string)" /> or the native <see href="https://developer.apple.com/documentation/objectivec/1418952-objc_getclass">objc_getClass</see> method with the type name.
		/// </remarks>
		public override NativeHandle ClassHandle { get { return class_ptr; } }
		/// <summary>Creates a new <see cref="NSFormatter" /> with default values.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public NSFormatter () : base (NSObjectFlag.Empty)
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
		public NSFormatter (NSCoder coder) : base (NSObjectFlag.Empty)
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
		protected NSFormatter (NSObjectFlag t) : base (t)
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
		protected internal NSFormatter (NativeHandle handle) : base (handle)
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
		[Export ("editingStringForObjectValue:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string EditingStringFor (NSObject value)
		{
			var value__handle__ = value!.GetNonNullHandle (nameof (value));
			string? ret;
			if (IsDirectBinding) {
				ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, selEditingStringForObjectValue_XHandle, value__handle__), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle (&__objc_super__, selEditingStringForObjectValue_XHandle, value__handle__), false)!;
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (value);
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
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal NSAttributedString GetAttributedString (NSObject obj, NSDictionary defaultAttributes)
		{
			var obj__handle__ = obj!.GetNonNullHandle (nameof (obj));
			var defaultAttributes__handle__ = defaultAttributes!.GetNonNullHandle (nameof (defaultAttributes));
			NSAttributedString? ret;
			ret =  Runtime.GetNSObject<NSAttributedString> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (this.Handle, selAttributedStringForObjectValue_WithDefaultAttributes_XHandle, obj__handle__, defaultAttributes__handle__), false)!;
			GC.KeepAlive (obj);
			GC.KeepAlive (defaultAttributes);
			return ret!;
		}
		[Export ("attributedStringForObjectValue:withDefaultAttributes:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSAttributedString GetAttributedString (NSObject obj, NSDictionary<NSString, NSObject> defaultAttributes)
		{
			var obj__handle__ = obj!.GetNonNullHandle (nameof (obj));
			var defaultAttributes__handle__ = defaultAttributes!.GetNonNullHandle (nameof (defaultAttributes));
			NSAttributedString? ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<NSAttributedString> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (this.Handle, selAttributedStringForObjectValue_WithDefaultAttributes_XHandle, obj__handle__, defaultAttributes__handle__), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<NSAttributedString> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, selAttributedStringForObjectValue_WithDefaultAttributes_XHandle, obj__handle__, defaultAttributes__handle__), false)!;
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (obj);
			GC.KeepAlive (defaultAttributes);
			return ret!;
		}
		/// <param name="obj">To be added.</param><param name="defaultAttributes">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public NSAttributedString GetAttributedString (NSObject obj, global::AppKit.NSStringAttributes defaultAttributes)
		{
			return GetAttributedString (obj, defaultAttributes.GetDictionary ()!);
		}
		[Export ("getObjectValue:forString:errorDescription:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual bool GetObjectValue (out NSObject obj, string str, out NSString error)
		{
			if (str is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (str));
			NativeHandle objValue = IntPtr.Zero;
			NativeHandle errorValue = IntPtr.Zero;
			var nsstr = CFString.CreateNative (str);
			byte ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_ref_NativeHandle_NativeHandle_ref_NativeHandle (this.Handle, selGetObjectValue_ForString_ErrorDescription_XHandle, &objValue, nsstr, &errorValue);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper_ref_NativeHandle_NativeHandle_ref_NativeHandle (&__objc_super__, selGetObjectValue_ForString_ErrorDescription_XHandle, &objValue, nsstr, &errorValue);
					GC.KeepAlive (this);
				}
			}
			CFString.ReleaseNative (nsstr);
			obj = Runtime.GetNSObject<NSObject> (objValue)!;
			error = Runtime.GetNSObject<NSString> (errorValue)!;
			return ret != 0;
		}
		[Export ("isPartialStringValid:newEditingString:errorDescription:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual bool IsPartialStringValid (string partialString, out string? newString, out NSString? error)
		{
			if (partialString is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (partialString));
			NativeHandle newStringValue = IntPtr.Zero;
			NativeHandle errorValue = IntPtr.Zero;
			var nspartialString = CFString.CreateNative (partialString);
			byte ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_ref_NativeHandle_ref_NativeHandle (this.Handle, selIsPartialStringValid_NewEditingString_ErrorDescription_XHandle, nspartialString, &newStringValue, &errorValue);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper_NativeHandle_ref_NativeHandle_ref_NativeHandle (&__objc_super__, selIsPartialStringValid_NewEditingString_ErrorDescription_XHandle, nspartialString, &newStringValue, &errorValue);
					GC.KeepAlive (this);
				}
			}
			CFString.ReleaseNative (nspartialString);
			newString = CFString.FromHandle (newStringValue)!;
			error = Runtime.GetNSObject<NSString> (errorValue)!;
			return ret != 0;
		}
		[Export ("isPartialStringValid:proposedSelectedRange:originalString:originalSelectedRange:errorDescription:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual bool IsPartialStringValid (ref string partialString, out NSRange proposedSelRange, string origString, NSRange origSelRange, out string? error)
		{
			if (origString is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (origString));
			var partialStringValue = NSString.CreateNative (partialString, true);
			var partialStringOriginalValue = partialStringValue;
			fixed (NSRange* proposedSelRange__pointer = &proposedSelRange) {
			NativeHandle errorValue = IntPtr.Zero;
			proposedSelRange = default;
			var nsorigString = CFString.CreateNative (origString);
			byte ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_ref_NativeHandle_out_NSRange_NativeHandle_NSRange_ref_NativeHandle (this.Handle, selIsPartialStringValid_ProposedSelectedRange_OriginalString_OriginalSelectedRange_ErrorDescription_XHandle, &partialStringValue, proposedSelRange__pointer, nsorigString, origSelRange, &errorValue);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper_ref_NativeHandle_out_NSRange_NativeHandle_NSRange_ref_NativeHandle (&__objc_super__, selIsPartialStringValid_ProposedSelectedRange_OriginalString_OriginalSelectedRange_ErrorDescription_XHandle, &partialStringValue, proposedSelRange__pointer, nsorigString, origSelRange, &errorValue);
					GC.KeepAlive (this);
				}
			}
			CFString.ReleaseNative (nsorigString);
			if (partialStringValue != partialStringOriginalValue)
				partialString = CFString.FromHandle (partialStringValue)!;
			error = CFString.FromHandle (errorValue)!;
			return ret != 0;
			}
		}
		[Export ("stringForObjectValue:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string StringFor (NSObject? value)
		{
			var value__handle__ = value.GetHandle ();
			string? ret;
			if (IsDirectBinding) {
				ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, selStringForObjectValue_XHandle, value__handle__), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle (&__objc_super__, selStringForObjectValue_XHandle, value__handle__), false)!;
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (value);
			return ret!;
		}
	} /* class NSFormatter */
}
