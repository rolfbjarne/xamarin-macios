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
	[Register("NSAttributedString", true)]
	public unsafe partial class NSAttributedString : NSObject, INSCoding, INSCopying, INSItemProviderReading, INSItemProviderWriting, INSMutableCopying, INSSecureCoding {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly NativeHandle class_ptr = Class.GetHandle ("NSAttributedString");
		/// <summary>The Objective-C class handle for this class.</summary>
		/// <value>The pointer to the Objective-C class.</value>
		/// <remarks>
		///     Each managed class mirrors an unmanaged Objective-C class.
		///     This value contains the pointer to the Objective-C class.
		///     It is similar to calling the managed <see cref="ObjCRuntime.Class.GetHandle(string)" /> or the native <see href="https://developer.apple.com/documentation/objectivec/1418952-objc_getclass">objc_getClass</see> method with the type name.
		/// </remarks>
		public override NativeHandle ClassHandle { get { return class_ptr; } }
		/// <summary>Creates a new <see cref="NSAttributedString" /> with default values.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public NSAttributedString () : base (NSObjectFlag.Empty)
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
		public NSAttributedString (NSCoder coder) : base (NSObjectFlag.Empty)
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
		protected NSAttributedString (NSObjectFlag t) : base (t)
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
		protected internal NSAttributedString (NativeHandle handle) : base (handle)
		{
		}

		[Export ("initWithString:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public NSAttributedString (string str)
			: base (NSObjectFlag.Empty)
		{
			if (str is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (str));
			var nsstr = CFString.CreateNative (str);
			if (IsDirectBinding) {
				InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("initWithString:"), nsstr), "initWithString:");
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle (&__objc_super__, Selector.GetHandle ("initWithString:"), nsstr), "initWithString:");
					GC.KeepAlive (this);
				}
			}
			CFString.ReleaseNative (nsstr);
		}
		[Export ("initWithString:attributes:")]
		[EditorBrowsable (EditorBrowsableState.Never)]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public NSAttributedString (string str, NSDictionary? attributes)
			: base (NSObjectFlag.Empty)
		{
			if (str is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (str));
			var attributes__handle__ = attributes.GetHandle ();
			var nsstr = CFString.CreateNative (str);
			if (IsDirectBinding) {
				InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("initWithString:attributes:"), nsstr, attributes__handle__), "initWithString:attributes:");
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, Selector.GetHandle ("initWithString:attributes:"), nsstr, attributes__handle__), "initWithString:attributes:");
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (attributes);
			CFString.ReleaseNative (nsstr);
		}
		[Export ("initWithAttributedString:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public NSAttributedString (NSAttributedString other)
			: base (NSObjectFlag.Empty)
		{
			var other__handle__ = other!.GetNonNullHandle (nameof (other));
			if (IsDirectBinding) {
				InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("initWithAttributedString:"), other__handle__), "initWithAttributedString:");
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle (&__objc_super__, Selector.GetHandle ("initWithAttributedString:"), other__handle__), "initWithAttributedString:");
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (other);
		}
		/// <param name="url">To be added.</param><param name="options"><para>To be added.</para><para tool="nullallowed">This parameter can be <see langword="null" />.</para></param><param name="resultDocumentAttributes">To be added.</param><param name="error">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("initWithURL:options:documentAttributes:error:")]
		[Obsolete ("Use the 'Create' method instead, because there's no way to return an error from a constructor.", false)]
		[EditorBrowsable (EditorBrowsableState.Never)]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe NSAttributedString (NSUrl url, NSDictionary options, out NSDictionary resultDocumentAttributes, ref NSError error)
			: base (NSObjectFlag.Empty)
		{
			var url__handle__ = url!.GetNonNullHandle (nameof (url));
			var options__handle__ = options!.GetNonNullHandle (nameof (options));
			NativeHandle resultDocumentAttributesValue = IntPtr.Zero;
			var errorValue = Runtime.RetainAndAutoreleaseNativeObject (error);
			if (IsDirectBinding) {
				InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_ref_NativeHandle_ref_NativeHandle (this.Handle, Selector.GetHandle ("initWithURL:options:documentAttributes:error:"), url__handle__, options__handle__, &resultDocumentAttributesValue, &errorValue), "initWithURL:options:documentAttributes:error:");
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_NativeHandle_ref_NativeHandle_ref_NativeHandle (&__objc_super__, Selector.GetHandle ("initWithURL:options:documentAttributes:error:"), url__handle__, options__handle__, &resultDocumentAttributesValue, &errorValue), "initWithURL:options:documentAttributes:error:");
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (url);
			GC.KeepAlive (options);
			resultDocumentAttributes = Runtime.GetNSObject<NSDictionary> (resultDocumentAttributesValue)!;
			error = Runtime.GetNSObject<NSError> (errorValue)!;
		}
		/// <param name="data">To be added.</param><param name="options"><para>To be added.</para><para tool="nullallowed">This parameter can be <see langword="null" />.</para></param><param name="resultDocumentAttributes">To be added.</param><param name="error">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("initWithData:options:documentAttributes:error:")]
		[Obsolete ("Use the 'Create' method instead, because there's no way to return an error from a constructor.", false)]
		[EditorBrowsable (EditorBrowsableState.Never)]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe NSAttributedString (NSData data, NSDictionary options, out NSDictionary resultDocumentAttributes, ref NSError error)
			: base (NSObjectFlag.Empty)
		{
			var data__handle__ = data!.GetNonNullHandle (nameof (data));
			var options__handle__ = options!.GetNonNullHandle (nameof (options));
			NativeHandle resultDocumentAttributesValue = IntPtr.Zero;
			var errorValue = Runtime.RetainAndAutoreleaseNativeObject (error);
			if (IsDirectBinding) {
				InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_ref_NativeHandle_ref_NativeHandle (this.Handle, Selector.GetHandle ("initWithData:options:documentAttributes:error:"), data__handle__, options__handle__, &resultDocumentAttributesValue, &errorValue), "initWithData:options:documentAttributes:error:");
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_NativeHandle_ref_NativeHandle_ref_NativeHandle (&__objc_super__, Selector.GetHandle ("initWithData:options:documentAttributes:error:"), data__handle__, options__handle__, &resultDocumentAttributesValue, &errorValue), "initWithData:options:documentAttributes:error:");
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (data);
			GC.KeepAlive (options);
			resultDocumentAttributes = Runtime.GetNSObject<NSDictionary> (resultDocumentAttributesValue)!;
			error = Runtime.GetNSObject<NSError> (errorValue)!;
		}
		/// <param name="url">To be added.</param><param name="options">To be added.</param><param name="resultDocumentAttributes">To be added.</param><param name="error">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Obsolete ("Use the 'Create' method instead, because there's no way to return an error from a constructor.", false)]
		[EditorBrowsable (EditorBrowsableState.Never)]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe NSAttributedString (NSUrl url, NSAttributedStringDocumentAttributes options, out NSDictionary resultDocumentAttributes, ref NSError error)
			: this (url, options.GetDictionary ()!, out resultDocumentAttributes, ref error)
		{
		}
		/// <param name="data">To be added.</param><param name="options">To be added.</param><param name="resultDocumentAttributes">To be added.</param><param name="error">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Obsolete ("Use the 'Create' method instead, because there's no way to return an error from a constructor.", false)]
		[EditorBrowsable (EditorBrowsableState.Never)]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe NSAttributedString (NSData data, NSAttributedStringDocumentAttributes options, out NSDictionary resultDocumentAttributes, ref NSError error)
			: this (data, options.GetDictionary ()!, out resultDocumentAttributes, ref error)
		{
		}
		[Export ("initWithContentsOfMarkdownFileAtURL:options:baseURL:error:")]
		[Obsolete ("Use the 'Create' method instead, because there's no way to return an error from a constructor.", false)]
		[EditorBrowsable (EditorBrowsableState.Never)]
		[SupportedOSPlatform ("tvos15.0")]
		[SupportedOSPlatform ("ios15.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe NSAttributedString (NSUrl markdownFile, NSAttributedStringMarkdownParsingOptions? options, NSUrl? baseUrl, out NSError? error)
			: base (NSObjectFlag.Empty)
		{
			var markdownFile__handle__ = markdownFile!.GetNonNullHandle (nameof (markdownFile));
			var options__handle__ = options.GetHandle ();
			var baseUrl__handle__ = baseUrl.GetHandle ();
			NativeHandle errorValue = IntPtr.Zero;
			if (IsDirectBinding) {
				InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle_ref_NativeHandle (this.Handle, Selector.GetHandle ("initWithContentsOfMarkdownFileAtURL:options:baseURL:error:"), markdownFile__handle__, options__handle__, baseUrl__handle__, &errorValue), "initWithContentsOfMarkdownFileAtURL:options:baseURL:error:");
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_NativeHandle_NativeHandle_ref_NativeHandle (&__objc_super__, Selector.GetHandle ("initWithContentsOfMarkdownFileAtURL:options:baseURL:error:"), markdownFile__handle__, options__handle__, baseUrl__handle__, &errorValue), "initWithContentsOfMarkdownFileAtURL:options:baseURL:error:");
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (markdownFile);
			GC.KeepAlive (options);
			GC.KeepAlive (baseUrl);
			error = Runtime.GetNSObject<NSError> (errorValue)!;
		}
		[Export ("initWithMarkdown:options:baseURL:error:")]
		[Obsolete ("Use the 'Create' method instead, because there's no way to return an error from a constructor.", false)]
		[EditorBrowsable (EditorBrowsableState.Never)]
		[SupportedOSPlatform ("tvos15.0")]
		[SupportedOSPlatform ("ios15.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe NSAttributedString (NSData markdown, NSAttributedStringMarkdownParsingOptions? options, NSUrl? baseUrl, out NSError? error)
			: base (NSObjectFlag.Empty)
		{
			var markdown__handle__ = markdown!.GetNonNullHandle (nameof (markdown));
			var options__handle__ = options.GetHandle ();
			var baseUrl__handle__ = baseUrl.GetHandle ();
			NativeHandle errorValue = IntPtr.Zero;
			if (IsDirectBinding) {
				InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle_ref_NativeHandle (this.Handle, Selector.GetHandle ("initWithMarkdown:options:baseURL:error:"), markdown__handle__, options__handle__, baseUrl__handle__, &errorValue), "initWithMarkdown:options:baseURL:error:");
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_NativeHandle_NativeHandle_ref_NativeHandle (&__objc_super__, Selector.GetHandle ("initWithMarkdown:options:baseURL:error:"), markdown__handle__, options__handle__, baseUrl__handle__, &errorValue), "initWithMarkdown:options:baseURL:error:");
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (markdown);
			GC.KeepAlive (options);
			GC.KeepAlive (baseUrl);
			error = Runtime.GetNSObject<NSError> (errorValue)!;
		}
		[Export ("initWithMarkdownString:options:baseURL:error:")]
		[Obsolete ("Use the 'Create' method instead, because there's no way to return an error from a constructor.", false)]
		[EditorBrowsable (EditorBrowsableState.Never)]
		[SupportedOSPlatform ("tvos15.0")]
		[SupportedOSPlatform ("ios15.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe NSAttributedString (string markdownString, NSAttributedStringMarkdownParsingOptions? options, NSUrl? baseUrl, out NSError? error)
			: base (NSObjectFlag.Empty)
		{
			if (markdownString is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (markdownString));
			var options__handle__ = options.GetHandle ();
			var baseUrl__handle__ = baseUrl.GetHandle ();
			NativeHandle errorValue = IntPtr.Zero;
			var nsmarkdownString = CFString.CreateNative (markdownString);
			if (IsDirectBinding) {
				InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle_ref_NativeHandle (this.Handle, Selector.GetHandle ("initWithMarkdownString:options:baseURL:error:"), nsmarkdownString, options__handle__, baseUrl__handle__, &errorValue), "initWithMarkdownString:options:baseURL:error:");
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_NativeHandle_NativeHandle_ref_NativeHandle (&__objc_super__, Selector.GetHandle ("initWithMarkdownString:options:baseURL:error:"), nsmarkdownString, options__handle__, baseUrl__handle__, &errorValue), "initWithMarkdownString:options:baseURL:error:");
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (options);
			GC.KeepAlive (baseUrl);
			CFString.ReleaseNative (nsmarkdownString);
			error = Runtime.GetNSObject<NSError> (errorValue)!;
		}
		/// <param name="range">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("containsAttachmentsInRange:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool ContainsAttachmentsInRange (NSRange range)
		{
			byte ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NSRange (this.Handle, Selector.GetHandle ("containsAttachmentsInRange:"), range);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper_NSRange (&__objc_super__, Selector.GetHandle ("containsAttachmentsInRange:"), range);
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
		[Export ("attributedStringWithAdaptiveImageGlyph:attributes:")]
		[SupportedOSPlatform ("tvos18.0")]
		[SupportedOSPlatform ("macos15.0")]
		[SupportedOSPlatform ("ios18.0")]
		[SupportedOSPlatform ("maccatalyst18.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSAttributedString Create (global::UIKit.NSAdaptiveImageGlyph adaptiveImageGlyph, NSDictionary<NSString, NSObject> attributes)
		{
			var adaptiveImageGlyph__handle__ = adaptiveImageGlyph!.GetNonNullHandle (nameof (adaptiveImageGlyph));
			var attributes__handle__ = attributes!.GetNonNullHandle (nameof (attributes));
			NSAttributedString? ret;
			ret =  Runtime.GetNSObject<NSAttributedString> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (class_ptr, Selector.GetHandle ("attributedStringWithAdaptiveImageGlyph:attributes:"), adaptiveImageGlyph__handle__, attributes__handle__), false)!;
			GC.KeepAlive (adaptiveImageGlyph);
			GC.KeepAlive (attributes);
			return ret!;
		}
		/// <param name="rect">To be added.</param><param name="options">To be added.</param><param name="context"><para>To be added.</para><para tool="nullallowed">This parameter can be <see langword="null" />.</para></param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("drawWithRect:options:context:")]
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DrawString (CGRect rect, NSStringDrawingOptions options, NSStringDrawingContext? context)
		{
			var context__handle__ = context.GetHandle ();
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_CGRect_UIntPtr_NativeHandle (this.Handle, Selector.GetHandle ("drawWithRect:options:context:"), rect, (UIntPtr) (ulong) options, context__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_CGRect_UIntPtr_NativeHandle (&__objc_super__, Selector.GetHandle ("drawWithRect:options:context:"), rect, (UIntPtr) (ulong) options, context__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (context);
		}
		/// <param name="point">To be added.</param><summary>Draws the string at the specified point.</summary><remarks>To be added.</remarks>
		[Export ("drawAtPoint:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DrawString (CGPoint point)
		{
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_CGPoint (this.Handle, Selector.GetHandle ("drawAtPoint:"), point);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_CGPoint (&__objc_super__, Selector.GetHandle ("drawAtPoint:"), point);
					GC.KeepAlive (this);
				}
			}
		}
		/// <param name="rect">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("drawInRect:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DrawString (CGRect rect)
		{
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_CGRect (this.Handle, Selector.GetHandle ("drawInRect:"), rect);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_CGRect (&__objc_super__, Selector.GetHandle ("drawInRect:"), rect);
					GC.KeepAlive (this);
				}
			}
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
		[Export ("enumerateAttribute:inRange:options:usingBlock:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void EnumerateAttribute (NSString attributeName, NSRange inRange, NSAttributedStringEnumeration options, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDNSAttributedStringCallback))]NSAttributedStringCallback callback)
		{
			var attributeName__handle__ = attributeName!.GetNonNullHandle (nameof (attributeName));
			if (callback is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (callback));
			using var block_callback = Trampolines.SDNSAttributedStringCallback.CreateBlock (callback);
			BlockLiteral *block_ptr_callback = &block_callback;
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NSRange_UIntPtr_NativeHandle (this.Handle, Selector.GetHandle ("enumerateAttribute:inRange:options:usingBlock:"), attributeName__handle__, inRange, (UIntPtr) (ulong) options, (IntPtr) block_ptr_callback);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_NSRange_UIntPtr_NativeHandle (&__objc_super__, Selector.GetHandle ("enumerateAttribute:inRange:options:usingBlock:"), attributeName__handle__, inRange, (UIntPtr) (ulong) options, (IntPtr) block_ptr_callback);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (attributeName);
		}
		[Export ("enumerateAttributesInRange:options:usingBlock:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void EnumerateAttributes (NSRange range, NSAttributedStringEnumeration options, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDNSAttributedRangeCallback))]NSAttributedRangeCallback callback)
		{
			if (callback is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (callback));
			using var block_callback = Trampolines.SDNSAttributedRangeCallback.CreateBlock (callback);
			BlockLiteral *block_ptr_callback = &block_callback;
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NSRange_UIntPtr_NativeHandle (this.Handle, Selector.GetHandle ("enumerateAttributesInRange:options:usingBlock:"), range, (UIntPtr) (ulong) options, (IntPtr) block_ptr_callback);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NSRange_UIntPtr_NativeHandle (&__objc_super__, Selector.GetHandle ("enumerateAttributesInRange:options:usingBlock:"), range, (UIntPtr) (ulong) options, (IntPtr) block_ptr_callback);
					GC.KeepAlive (this);
				}
			}
		}
		/// <param name="attachment">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("attributedStringWithAttachment:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSAttributedString FromAttachment (global::UIKit.NSTextAttachment attachment)
		{
			var attachment__handle__ = attachment!.GetNonNullHandle (nameof (attachment));
			NSAttributedString? ret;
			ret =  Runtime.GetNSObject<NSAttributedString> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (class_ptr, Selector.GetHandle ("attributedStringWithAttachment:"), attachment__handle__), false)!;
			GC.KeepAlive (attachment);
			return ret!;
		}
		[Export ("attributedStringWithAttachment:attributes:")]
		[SupportedOSPlatform ("tvos18.0")]
		[SupportedOSPlatform ("macos15.0")]
		[SupportedOSPlatform ("ios18.0")]
		[SupportedOSPlatform ("maccatalyst18.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSAttributedString FromAttachment (global::UIKit.NSTextAttachment attachment, NSDictionary<NSString, NSObject> attributes)
		{
			var attachment__handle__ = attachment!.GetNonNullHandle (nameof (attachment));
			var attributes__handle__ = attributes!.GetNonNullHandle (nameof (attributes));
			NSAttributedString? ret;
			ret =  Runtime.GetNSObject<NSAttributedString> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (class_ptr, Selector.GetHandle ("attributedStringWithAttachment:attributes:"), attachment__handle__, attributes__handle__), false)!;
			GC.KeepAlive (attachment);
			GC.KeepAlive (attributes);
			return ret!;
		}
		/// <param name="attribute">To be added.</param><param name="location">To be added.</param><param name="effectiveRange">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("attribute:atIndex:effectiveRange:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual NSObject GetAttribute (string attribute, nint location, out NSRange effectiveRange)
		{
			if (attribute is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (attribute));
			fixed (NSRange* effectiveRange__pointer = &effectiveRange) {
			var nsattribute = CFString.CreateNative (attribute);
			effectiveRange = default;
			NSObject? ret;
			if (IsDirectBinding) {
				ret = Runtime.GetNSObject (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_IntPtr_out_NSRange (this.Handle, Selector.GetHandle ("attribute:atIndex:effectiveRange:"), nsattribute, location, effectiveRange__pointer), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = Runtime.GetNSObject (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_IntPtr_out_NSRange (&__objc_super__, Selector.GetHandle ("attribute:atIndex:effectiveRange:"), nsattribute, location, effectiveRange__pointer), false)!;
					GC.KeepAlive (this);
				}
			}
			CFString.ReleaseNative (nsattribute);
			return ret!;
			}
		}
		/// <param name="attribute">To be added.</param><param name="location">To be added.</param><param name="longestEffectiveRange">To be added.</param><param name="rangeLimit">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("attribute:atIndex:longestEffectiveRange:inRange:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual NSObject GetAttribute (string attribute, nint location, out NSRange longestEffectiveRange, NSRange rangeLimit)
		{
			if (attribute is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (attribute));
			fixed (NSRange* longestEffectiveRange__pointer = &longestEffectiveRange) {
			var nsattribute = CFString.CreateNative (attribute);
			longestEffectiveRange = default;
			NSObject? ret;
			if (IsDirectBinding) {
				ret = Runtime.GetNSObject (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_IntPtr_out_NSRange_NSRange (this.Handle, Selector.GetHandle ("attribute:atIndex:longestEffectiveRange:inRange:"), nsattribute, location, longestEffectiveRange__pointer, rangeLimit), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = Runtime.GetNSObject (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_IntPtr_out_NSRange_NSRange (&__objc_super__, Selector.GetHandle ("attribute:atIndex:longestEffectiveRange:inRange:"), nsattribute, location, longestEffectiveRange__pointer, rangeLimit), false)!;
					GC.KeepAlive (this);
				}
			}
			CFString.ReleaseNative (nsattribute);
			return ret!;
			}
		}
		/// <param name="location">To be added.</param><param name="longestEffectiveRange">To be added.</param><param name="rangeLimit">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("attributesAtIndex:longestEffectiveRange:inRange:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual NSDictionary GetAttributes (nint location, out NSRange longestEffectiveRange, NSRange rangeLimit)
		{
			fixed (NSRange* longestEffectiveRange__pointer = &longestEffectiveRange) {
			longestEffectiveRange = default;
			NSDictionary ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<NSDictionary> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_IntPtr_out_NSRange_NSRange (this.Handle, Selector.GetHandle ("attributesAtIndex:longestEffectiveRange:inRange:"), location, longestEffectiveRange__pointer, rangeLimit), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<NSDictionary> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_IntPtr_out_NSRange_NSRange (&__objc_super__, Selector.GetHandle ("attributesAtIndex:longestEffectiveRange:inRange:"), location, longestEffectiveRange__pointer, rangeLimit), false)!;
					GC.KeepAlive (this);
				}
			}
			return ret;
			}
		}
		/// <param name="size">To be added.</param><param name="options">To be added.</param><param name="context"><para>To be added.</para><para tool="nullallowed">This parameter can be <see langword="null" />.</para></param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("boundingRectWithSize:options:context:")]
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual CGRect GetBoundingRect (CGSize size, NSStringDrawingOptions options, NSStringDrawingContext? context)
		{
			var context__handle__ = context.GetHandle ();
			CGRect ret;
			if (IsDirectBinding) {
				if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
					ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSend_CGSize_UIntPtr_NativeHandle (this.Handle, Selector.GetHandle ("boundingRectWithSize:options:context:"), size, (UIntPtr) (ulong) options, context__handle__);
				} else {
					ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSend_stret_CGSize_UIntPtr_NativeHandle (this.Handle, Selector.GetHandle ("boundingRectWithSize:options:context:"), size, (UIntPtr) (ulong) options, context__handle__);
				}
			} else {
				if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSendSuper_CGSize_UIntPtr_NativeHandle (&__objc_super__, Selector.GetHandle ("boundingRectWithSize:options:context:"), size, (UIntPtr) (ulong) options, context__handle__);
						GC.KeepAlive (this);
					}
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSendSuper_stret_CGSize_UIntPtr_NativeHandle (&__objc_super__, Selector.GetHandle ("boundingRectWithSize:options:context:"), size, (UIntPtr) (ulong) options, context__handle__);
						GC.KeepAlive (this);
					}
				}
			}
			GC.KeepAlive (context);
			return ret!;
		}
		/// <param name="range">To be added.</param><param name="options">To be added.</param><param name="error">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe NSData? GetData (NSRange range, NSDictionary options, out NSError error)
		{
			var options__handle__ = options!.GetNonNullHandle (nameof (options));
			NativeHandle errorValue = IntPtr.Zero;
			NSData? ret;
			ret =  Runtime.GetNSObject<NSData> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NSRange_NativeHandle_ref_NativeHandle (this.Handle, Selector.GetHandle ("dataFromRange:documentAttributes:error:"), range, options__handle__, &errorValue), false)!;
			GC.KeepAlive (options);
			error = Runtime.GetNSObject<NSError> (errorValue)!;
			return ret!;
		}
		/// <param name="range">To be added.</param><param name="options">To be added.</param><param name="error">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe NSData? GetData (NSRange range, NSAttributedStringDocumentAttributes options, out NSError error)
		{
			return this.GetData (range, options.GetDictionary ()!, out error);
		}
		/// <param name="range">To be added.</param><param name="attributes">To be added.</param><param name="error">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("dataFromRange:documentAttributes:error:")]
		[Obsolete ("Use 'GetData' instead.", false)]
		[EditorBrowsable (EditorBrowsableState.Never)]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual NSData? GetDataFromRange (NSRange range, NSDictionary attributes, ref NSError error)
		{
			var attributes__handle__ = attributes!.GetNonNullHandle (nameof (attributes));
			var errorValue = Runtime.RetainAndAutoreleaseNativeObject (error);
			NSData? ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<NSData> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NSRange_NativeHandle_ref_NativeHandle (this.Handle, Selector.GetHandle ("dataFromRange:documentAttributes:error:"), range, attributes__handle__, &errorValue), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<NSData> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NSRange_NativeHandle_ref_NativeHandle (&__objc_super__, Selector.GetHandle ("dataFromRange:documentAttributes:error:"), range, attributes__handle__, &errorValue), false)!;
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (attributes);
			error = Runtime.GetNSObject<NSError> (errorValue)!;
			return ret!;
		}
		/// <param name="range">To be added.</param><param name="documentAttributes">To be added.</param><param name="error">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Obsolete ("Use 'GetData' instead.", false)]
		[EditorBrowsable (EditorBrowsableState.Never)]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe NSData? GetDataFromRange (NSRange range, NSAttributedStringDocumentAttributes documentAttributes, ref NSError error)
		{
			return GetDataFromRange (range, documentAttributes.GetDictionary ()!, ref error);
		}
		/// <param name="range">To be added.</param><param name="options">To be added.</param><param name="error">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe NSFileWrapper? GetFileWrapper (NSRange range, NSDictionary options, out NSError error)
		{
			var options__handle__ = options!.GetNonNullHandle (nameof (options));
			NativeHandle errorValue = IntPtr.Zero;
			NSFileWrapper? ret;
			ret =  Runtime.GetNSObject<NSFileWrapper> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NSRange_NativeHandle_ref_NativeHandle (this.Handle, Selector.GetHandle ("fileWrapperFromRange:documentAttributes:error:"), range, options__handle__, &errorValue), false)!;
			GC.KeepAlive (options);
			error = Runtime.GetNSObject<NSError> (errorValue)!;
			return ret!;
		}
		/// <param name="range">To be added.</param><param name="options">To be added.</param><param name="error">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe NSFileWrapper? GetFileWrapper (NSRange range, NSAttributedStringDocumentAttributes options, out NSError error)
		{
			return this.GetFileWrapper (range, options.GetDictionary ()!, out error);
		}
		/// <param name="range">To be added.</param><param name="attributes">To be added.</param><param name="error">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("fileWrapperFromRange:documentAttributes:error:")]
		[Obsolete ("Use 'GetFileWrapper' instead.", false)]
		[EditorBrowsable (EditorBrowsableState.Never)]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual NSFileWrapper? GetFileWrapperFromRange (NSRange range, NSDictionary attributes, ref NSError error)
		{
			var attributes__handle__ = attributes!.GetNonNullHandle (nameof (attributes));
			var errorValue = Runtime.RetainAndAutoreleaseNativeObject (error);
			NSFileWrapper? ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<NSFileWrapper> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NSRange_NativeHandle_ref_NativeHandle (this.Handle, Selector.GetHandle ("fileWrapperFromRange:documentAttributes:error:"), range, attributes__handle__, &errorValue), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<NSFileWrapper> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NSRange_NativeHandle_ref_NativeHandle (&__objc_super__, Selector.GetHandle ("fileWrapperFromRange:documentAttributes:error:"), range, attributes__handle__, &errorValue), false)!;
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (attributes);
			error = Runtime.GetNSObject<NSError> (errorValue)!;
			return ret!;
		}
		/// <param name="range">To be added.</param><param name="documentAttributes">To be added.</param><param name="error">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Obsolete ("Use 'GetFileWrapper' instead.", false)]
		[EditorBrowsable (EditorBrowsableState.Never)]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe NSFileWrapper? GetFileWrapperFromRange (NSRange range, NSAttributedStringDocumentAttributes documentAttributes, ref NSError error)
		{
			return GetFileWrapperFromRange (range, documentAttributes.GetDictionary ()!, ref error);
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
		/// <param name="data">To be added.</param><param name="typeIdentifier">To be added.</param><param name="outError">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("objectWithItemProviderData:typeIdentifier:error:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static INSItemProviderReading? GetObject (NSData data, string typeIdentifier, out NSError? outError)
		{
			var data__handle__ = data!.GetNonNullHandle (nameof (data));
			if (typeIdentifier is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (typeIdentifier));
			NativeHandle outErrorValue = IntPtr.Zero;
			var nstypeIdentifier = CFString.CreateNative (typeIdentifier);
			INSItemProviderReading? ret;
			ret =  Runtime.GetINativeObject<INSItemProviderReading> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_ref_NativeHandle (class_ptr, Selector.GetHandle ("objectWithItemProviderData:typeIdentifier:error:"), data__handle__, nstypeIdentifier, &outErrorValue), false)!;
			GC.KeepAlive (data);
			CFString.ReleaseNative (nstypeIdentifier);
			outError = Runtime.GetNSObject<NSError> (outErrorValue)!;
			return ret!;
		}
		[Export ("isEqualToAttributedString:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool IsEqual (NSAttributedString other)
		{
			var other__handle__ = other!.GetNonNullHandle (nameof (other));
			byte ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("isEqualToAttributedString:"), other__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper_NativeHandle (&__objc_super__, Selector.GetHandle ("isEqualToAttributedString:"), other__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (other);
			return ret != 0;
		}
		/// <param name="typeIdentifier">A Universal Type Identifier (UTI) indicating the type of data to load.</param><param name="completionHandler">The method called after the data is loaded.</param><summary>Implement this method to customize the loading of data by an <see cref="T:Foundation.NSItemProvider" />.</summary><returns>An <see cref="T:Foundation.NSProgress" /> object reflecting the data-loading operation.</returns><remarks><para>The <paramref name="typeIdentifier" /> must be in the set of values returned by <see cref="Foundation.NSItemProviderWriting_Extensions.GetWritableTypeIdentifiersForItemProvider(Foundation.INSItemProviderWriting)" />.</para></remarks>
		[Export ("loadDataWithTypeIdentifier:forItemProviderCompletionHandler:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual NSProgress? LoadData (string typeIdentifier, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity2V19))]global::System.Action<NSData, NSError> completionHandler)
		{
			if (typeIdentifier is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (typeIdentifier));
			if (completionHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completionHandler));
			var nstypeIdentifier = CFString.CreateNative (typeIdentifier);
			using var block_completionHandler = Trampolines.SDActionArity2V19.CreateBlock (completionHandler);
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
		[Export ("loadFromHTMLWithRequest:options:completionHandler:")]
		[EditorBrowsable (EditorBrowsableState.Never)]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static void LoadFromHtml (NSUrlRequest request, NSDictionary options, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDNSAttributedStringCompletionHandler))]NSAttributedStringCompletionHandler completionHandler)
		{
			var request__handle__ = request!.GetNonNullHandle (nameof (request));
			var options__handle__ = options!.GetNonNullHandle (nameof (options));
			if (completionHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completionHandler));
			using var block_completionHandler = Trampolines.SDNSAttributedStringCompletionHandler.CreateBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = &block_completionHandler;
			GC.KeepAlive (WebKit.WKContentMode.Recommended); // no-op to ensure WebKit.framework is loaded into memory
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (class_ptr, Selector.GetHandle ("loadFromHTMLWithRequest:options:completionHandler:"), request__handle__, options__handle__, (IntPtr) block_ptr_completionHandler);
			GC.KeepAlive (request);
			GC.KeepAlive (options);
		}
		[EditorBrowsable (EditorBrowsableState.Never)]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static Task<NSLoadFromHtmlResult> LoadFromHtmlAsync (NSUrlRequest request, NSDictionary options)
		{
			var tcs = new TaskCompletionSource<NSLoadFromHtmlResult> ();
			LoadFromHtml(request, options, (attributedString_, attributes_, error_) => {
				if (error_ is not null)
					tcs.SetException (new NSErrorException(error_));
				else
					tcs.SetResult (new NSLoadFromHtmlResult (attributedString_!, attributes_!));
			});
			return tcs.Task;
		}
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static void LoadFromHtml (NSUrlRequest request, NSAttributedStringDocumentAttributes options, NSAttributedStringCompletionHandler completionHandler)
		{
			LoadFromHtml (request, options.GetDictionary ()!, completionHandler);
		}
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static Task<NSLoadFromHtmlResult> LoadFromHtmlAsync (NSUrlRequest request, NSAttributedStringDocumentAttributes options)
		{
			var tcs = new TaskCompletionSource<NSLoadFromHtmlResult> ();
			LoadFromHtml(request, options, (attributedString_, attributes_, error_) => {
				if (error_ is not null)
					tcs.SetException (new NSErrorException(error_));
				else
					tcs.SetResult (new NSLoadFromHtmlResult (attributedString_!, attributes_!));
			});
			return tcs.Task;
		}
		[Export ("loadFromHTMLWithFileURL:options:completionHandler:")]
		[EditorBrowsable (EditorBrowsableState.Never)]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static void LoadFromHtml (NSUrl fileUrl, NSDictionary options, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDNSAttributedStringCompletionHandler))]NSAttributedStringCompletionHandler completionHandler)
		{
			var fileUrl__handle__ = fileUrl!.GetNonNullHandle (nameof (fileUrl));
			var options__handle__ = options!.GetNonNullHandle (nameof (options));
			if (completionHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completionHandler));
			using var block_completionHandler = Trampolines.SDNSAttributedStringCompletionHandler.CreateBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = &block_completionHandler;
			GC.KeepAlive (WebKit.WKContentMode.Recommended); // no-op to ensure WebKit.framework is loaded into memory
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (class_ptr, Selector.GetHandle ("loadFromHTMLWithFileURL:options:completionHandler:"), fileUrl__handle__, options__handle__, (IntPtr) block_ptr_completionHandler);
			GC.KeepAlive (fileUrl);
			GC.KeepAlive (options);
		}
		[EditorBrowsable (EditorBrowsableState.Never)]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static Task<NSLoadFromHtmlResult> LoadFromHtmlAsync (NSUrl fileUrl, NSDictionary options)
		{
			var tcs = new TaskCompletionSource<NSLoadFromHtmlResult> ();
			LoadFromHtml(fileUrl, options, (attributedString_, attributes_, error_) => {
				if (error_ is not null)
					tcs.SetException (new NSErrorException(error_));
				else
					tcs.SetResult (new NSLoadFromHtmlResult (attributedString_!, attributes_!));
			});
			return tcs.Task;
		}
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static void LoadFromHtml (NSUrl fileUrl, NSAttributedStringDocumentAttributes options, NSAttributedStringCompletionHandler completionHandler)
		{
			LoadFromHtml (fileUrl, options.GetDictionary ()!, completionHandler);
		}
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static Task<NSLoadFromHtmlResult> LoadFromHtmlAsync (NSUrl fileUrl, NSAttributedStringDocumentAttributes options)
		{
			var tcs = new TaskCompletionSource<NSLoadFromHtmlResult> ();
			LoadFromHtml(fileUrl, options, (attributedString_, attributes_, error_) => {
				if (error_ is not null)
					tcs.SetException (new NSErrorException(error_));
				else
					tcs.SetResult (new NSLoadFromHtmlResult (attributedString_!, attributes_!));
			});
			return tcs.Task;
		}
		[Export ("loadFromHTMLWithString:options:completionHandler:")]
		[EditorBrowsable (EditorBrowsableState.Never)]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static void LoadFromHtml (string @string, NSDictionary options, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDNSAttributedStringCompletionHandler))]NSAttributedStringCompletionHandler completionHandler)
		{
			if (@string is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (@string));
			var options__handle__ = options!.GetNonNullHandle (nameof (options));
			if (completionHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completionHandler));
			var nsstring = CFString.CreateNative (@string);
			using var block_completionHandler = Trampolines.SDNSAttributedStringCompletionHandler.CreateBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = &block_completionHandler;
			GC.KeepAlive (WebKit.WKContentMode.Recommended); // no-op to ensure WebKit.framework is loaded into memory
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (class_ptr, Selector.GetHandle ("loadFromHTMLWithString:options:completionHandler:"), nsstring, options__handle__, (IntPtr) block_ptr_completionHandler);
			GC.KeepAlive (options);
			CFString.ReleaseNative (nsstring);
		}
		[EditorBrowsable (EditorBrowsableState.Never)]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static Task<NSLoadFromHtmlResult> LoadFromHtmlAsync (string @string, NSDictionary options)
		{
			var tcs = new TaskCompletionSource<NSLoadFromHtmlResult> ();
			LoadFromHtml(@string, options, (attributedString_, attributes_, error_) => {
				if (error_ is not null)
					tcs.SetException (new NSErrorException(error_));
				else
					tcs.SetResult (new NSLoadFromHtmlResult (attributedString_!, attributes_!));
			});
			return tcs.Task;
		}
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static void LoadFromHtml (string @string, NSAttributedStringDocumentAttributes options, NSAttributedStringCompletionHandler completionHandler)
		{
			LoadFromHtml (@string, options.GetDictionary ()!, completionHandler);
		}
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static Task<NSLoadFromHtmlResult> LoadFromHtmlAsync (string @string, NSAttributedStringDocumentAttributes options)
		{
			var tcs = new TaskCompletionSource<NSLoadFromHtmlResult> ();
			LoadFromHtml(@string, options, (attributedString_, attributes_, error_) => {
				if (error_ is not null)
					tcs.SetException (new NSErrorException(error_));
				else
					tcs.SetResult (new NSLoadFromHtmlResult (attributedString_!, attributes_!));
			});
			return tcs.Task;
		}
		[Export ("loadFromHTMLWithData:options:completionHandler:")]
		[EditorBrowsable (EditorBrowsableState.Never)]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static void LoadFromHtml (NSData data, NSDictionary options, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDNSAttributedStringCompletionHandler))]NSAttributedStringCompletionHandler completionHandler)
		{
			var data__handle__ = data!.GetNonNullHandle (nameof (data));
			var options__handle__ = options!.GetNonNullHandle (nameof (options));
			if (completionHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completionHandler));
			using var block_completionHandler = Trampolines.SDNSAttributedStringCompletionHandler.CreateBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = &block_completionHandler;
			GC.KeepAlive (WebKit.WKContentMode.Recommended); // no-op to ensure WebKit.framework is loaded into memory
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (class_ptr, Selector.GetHandle ("loadFromHTMLWithData:options:completionHandler:"), data__handle__, options__handle__, (IntPtr) block_ptr_completionHandler);
			GC.KeepAlive (data);
			GC.KeepAlive (options);
		}
		[EditorBrowsable (EditorBrowsableState.Never)]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static Task<NSLoadFromHtmlResult> LoadFromHtmlAsync (NSData data, NSDictionary options)
		{
			var tcs = new TaskCompletionSource<NSLoadFromHtmlResult> ();
			LoadFromHtml(data, options, (attributedString_, attributes_, error_) => {
				if (error_ is not null)
					tcs.SetException (new NSErrorException(error_));
				else
					tcs.SetResult (new NSLoadFromHtmlResult (attributedString_!, attributes_!));
			});
			return tcs.Task;
		}
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static void LoadFromHtml (NSData data, NSAttributedStringDocumentAttributes options, NSAttributedStringCompletionHandler completionHandler)
		{
			LoadFromHtml (data, options.GetDictionary ()!, completionHandler);
		}
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static Task<NSLoadFromHtmlResult> LoadFromHtmlAsync (NSData data, NSAttributedStringDocumentAttributes options)
		{
			var tcs = new TaskCompletionSource<NSLoadFromHtmlResult> ();
			LoadFromHtml(data, options, (attributedString_, attributes_, error_) => {
				if (error_ is not null)
					tcs.SetException (new NSErrorException(error_));
				else
					tcs.SetResult (new NSLoadFromHtmlResult (attributedString_!, attributes_!));
			});
			return tcs.Task;
		}
		[Export ("attributesAtIndex:effectiveRange:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual nint LowLevelGetAttributes (nint location, nint effectiveRange)
		{
			nint ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr (this.Handle, Selector.GetHandle ("attributesAtIndex:effectiveRange:"), location, effectiveRange);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr (&__objc_super__, Selector.GetHandle ("attributesAtIndex:effectiveRange:"), location, effectiveRange);
					GC.KeepAlive (this);
				}
			}
			return ret;
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
		[Export ("prefersRTFDInRange:")]
		[SupportedOSPlatform ("tvos18.0")]
		[SupportedOSPlatform ("macos15.0")]
		[SupportedOSPlatform ("ios18.0")]
		[SupportedOSPlatform ("maccatalyst18.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool PrefersRtfdInRange (NSRange range)
		{
			byte ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NSRange (this.Handle, Selector.GetHandle ("prefersRTFDInRange:"), range);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper_NSRange (&__objc_super__, Selector.GetHandle ("prefersRTFDInRange:"), range);
					GC.KeepAlive (this);
				}
			}
			return ret != 0;
		}
		[Export ("attributedSubstringFromRange:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal virtual NSAttributedString Substring (NSRange range)
		{
			NSAttributedString ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<NSAttributedString> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NSRange (this.Handle, Selector.GetHandle ("attributedSubstringFromRange:"), range), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<NSAttributedString> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NSRange (&__objc_super__, Selector.GetHandle ("attributedSubstringFromRange:"), range), false)!;
					GC.KeepAlive (this);
				}
			}
			return ret;
		}
		[SupportedOSPlatform ("tvos15.0")]
		[SupportedOSPlatform ("ios15.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal unsafe NativeHandle _InitWithContentsOfMarkdownFile (NSUrl markdownFile, NSAttributedStringMarkdownParsingOptions? options, NSUrl? baseUrl, out NSError? error)
		{
			var markdownFile__handle__ = markdownFile!.GetNonNullHandle (nameof (markdownFile));
			var options__handle__ = options.GetHandle ();
			var baseUrl__handle__ = baseUrl.GetHandle ();
			NativeHandle errorValue = IntPtr.Zero;
			NativeHandle ret;
			ret = global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle_ref_NativeHandle (this.Handle, Selector.GetHandle ("initWithContentsOfMarkdownFileAtURL:options:baseURL:error:"), markdownFile__handle__, options__handle__, baseUrl__handle__, &errorValue);
			GC.KeepAlive (markdownFile);
			GC.KeepAlive (options);
			GC.KeepAlive (baseUrl);
			error = Runtime.GetNSObject<NSError> (errorValue)!;
			return ret!;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal unsafe NativeHandle _InitWithData (NSData data, NSDictionary options, out NSDictionary resultDocumentAttributes, out NSError error)
		{
			var data__handle__ = data!.GetNonNullHandle (nameof (data));
			var options__handle__ = options!.GetNonNullHandle (nameof (options));
			NativeHandle resultDocumentAttributesValue = IntPtr.Zero;
			NativeHandle errorValue = IntPtr.Zero;
			NativeHandle ret;
			ret = global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_ref_NativeHandle_ref_NativeHandle (this.Handle, Selector.GetHandle ("initWithData:options:documentAttributes:error:"), data__handle__, options__handle__, &resultDocumentAttributesValue, &errorValue);
			GC.KeepAlive (data);
			GC.KeepAlive (options);
			resultDocumentAttributes = Runtime.GetNSObject<NSDictionary> (resultDocumentAttributesValue)!;
			error = Runtime.GetNSObject<NSError> (errorValue)!;
			return ret!;
		}
		[SupportedOSPlatform ("tvos15.0")]
		[SupportedOSPlatform ("ios15.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal unsafe NativeHandle _InitWithMarkdown (NSData markdown, NSAttributedStringMarkdownParsingOptions? options, NSUrl? baseUrl, out NSError? error)
		{
			var markdown__handle__ = markdown!.GetNonNullHandle (nameof (markdown));
			var options__handle__ = options.GetHandle ();
			var baseUrl__handle__ = baseUrl.GetHandle ();
			NativeHandle errorValue = IntPtr.Zero;
			NativeHandle ret;
			ret = global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle_ref_NativeHandle (this.Handle, Selector.GetHandle ("initWithMarkdown:options:baseURL:error:"), markdown__handle__, options__handle__, baseUrl__handle__, &errorValue);
			GC.KeepAlive (markdown);
			GC.KeepAlive (options);
			GC.KeepAlive (baseUrl);
			error = Runtime.GetNSObject<NSError> (errorValue)!;
			return ret!;
		}
		[SupportedOSPlatform ("tvos15.0")]
		[SupportedOSPlatform ("ios15.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal unsafe NativeHandle _InitWithMarkdownString (string markdownString, NSAttributedStringMarkdownParsingOptions? options, NSUrl? baseUrl, out NSError? error)
		{
			if (markdownString is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (markdownString));
			var options__handle__ = options.GetHandle ();
			var baseUrl__handle__ = baseUrl.GetHandle ();
			NativeHandle errorValue = IntPtr.Zero;
			var nsmarkdownString = CFString.CreateNative (markdownString);
			NativeHandle ret;
			ret = global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle_ref_NativeHandle (this.Handle, Selector.GetHandle ("initWithMarkdownString:options:baseURL:error:"), nsmarkdownString, options__handle__, baseUrl__handle__, &errorValue);
			GC.KeepAlive (options);
			GC.KeepAlive (baseUrl);
			CFString.ReleaseNative (nsmarkdownString);
			error = Runtime.GetNSObject<NSError> (errorValue)!;
			return ret!;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal unsafe NativeHandle _InitWithUrl (NSUrl url, NSDictionary options, out NSDictionary resultDocumentAttributes, out NSError error)
		{
			var url__handle__ = url!.GetNonNullHandle (nameof (url));
			var options__handle__ = options!.GetNonNullHandle (nameof (options));
			NativeHandle resultDocumentAttributesValue = IntPtr.Zero;
			NativeHandle errorValue = IntPtr.Zero;
			NativeHandle ret;
			ret = global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_ref_NativeHandle_ref_NativeHandle (this.Handle, Selector.GetHandle ("initWithURL:options:documentAttributes:error:"), url__handle__, options__handle__, &resultDocumentAttributesValue, &errorValue);
			GC.KeepAlive (url);
			GC.KeepAlive (options);
			resultDocumentAttributes = Runtime.GetNSObject<NSDictionary> (resultDocumentAttributesValue)!;
			error = Runtime.GetNSObject<NSError> (errorValue)!;
			return ret!;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("tvos15.0")]
		[SupportedOSPlatform ("ios15.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public virtual NSAttributedString AttributedStringByInflectingString {
			[Export ("attributedStringByInflectingString")]
			get {
				NSAttributedString? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSAttributedString> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("attributedStringByInflectingString")), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<NSAttributedString> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("attributedStringByInflectingString")), false)!;
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
		public virtual nint LowLevelValue {
			[Export ("string")]
			get {
				nint ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("string"));
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("string"));
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
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
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public virtual CGSize Size {
			[Export ("size")]
			get {
				CGSize ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.CGSize_objc_msgSend (this.Handle, Selector.GetHandle ("size"));
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.CGSize_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("size"));
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
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
		static NSString? _CocoaVersionDocumentAttribute;
		/// <summary>Represents the value associated with the constant 'NSCocoaVersionDocumentAttribute'.</summary>
		[Field ("NSCocoaVersionDocumentAttribute",  "UIKit")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("tvos13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public static NSString CocoaVersionDocumentAttribute {
			[SupportedOSPlatform ("ios13.0")]
			[SupportedOSPlatform ("tvos13.0")]
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("macos")]
			get {
				if (_CocoaVersionDocumentAttribute is null)
					_CocoaVersionDocumentAttribute = Dlfcn.GetStringConstant (Libraries.UIKit.Handle, "NSCocoaVersionDocumentAttribute")!;
				return _CocoaVersionDocumentAttribute;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _SourceTextScalingDocumentAttribute;
		/// <summary>Represents the value associated with the constant 'NSSourceTextScalingDocumentAttribute'.</summary>
		[Field ("NSSourceTextScalingDocumentAttribute",  "UIKit")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("tvos13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public static NSString SourceTextScalingDocumentAttribute {
			[SupportedOSPlatform ("ios13.0")]
			[SupportedOSPlatform ("tvos13.0")]
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("macos")]
			get {
				if (_SourceTextScalingDocumentAttribute is null)
					_SourceTextScalingDocumentAttribute = Dlfcn.GetStringConstant (Libraries.UIKit.Handle, "NSSourceTextScalingDocumentAttribute")!;
				return _SourceTextScalingDocumentAttribute;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _TextLayoutSectionOrientation;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("NSTextLayoutSectionOrientation",  "UIKit")]
		public static NSString TextLayoutSectionOrientation {
			get {
				if (_TextLayoutSectionOrientation is null)
					_TextLayoutSectionOrientation = Dlfcn.GetStringConstant (Libraries.UIKit.Handle, "NSTextLayoutSectionOrientation")!;
				return _TextLayoutSectionOrientation;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _TextLayoutSectionRange;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("NSTextLayoutSectionRange",  "UIKit")]
		public static NSString TextLayoutSectionRange {
			get {
				if (_TextLayoutSectionRange is null)
					_TextLayoutSectionRange = Dlfcn.GetStringConstant (Libraries.UIKit.Handle, "NSTextLayoutSectionRange")!;
				return _TextLayoutSectionRange;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _TextLayoutSectionsAttribute;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("NSTextLayoutSectionsAttribute",  "UIKit")]
		public static NSString TextLayoutSectionsAttribute {
			get {
				if (_TextLayoutSectionsAttribute is null)
					_TextLayoutSectionsAttribute = Dlfcn.GetStringConstant (Libraries.UIKit.Handle, "NSTextLayoutSectionsAttribute")!;
				return _TextLayoutSectionsAttribute;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _TextScalingDocumentAttribute;
		/// <summary>Represents the value associated with the constant 'NSTextScalingDocumentAttribute'.</summary>
		[Field ("NSTextScalingDocumentAttribute",  "UIKit")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("tvos13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public static NSString TextScalingDocumentAttribute {
			[SupportedOSPlatform ("ios13.0")]
			[SupportedOSPlatform ("tvos13.0")]
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("macos")]
			get {
				if (_TextScalingDocumentAttribute is null)
					_TextScalingDocumentAttribute = Dlfcn.GetStringConstant (Libraries.UIKit.Handle, "NSTextScalingDocumentAttribute")!;
				return _TextScalingDocumentAttribute;
			}
		}
	} /* class NSAttributedString */
	//
	// Async result classes
	//
	/// <summary>This class holds the return values for an asynchronous operation.</summary>
	public partial class NSLoadFromHtmlResult {
		/// <summary>The result value from the asynchronous operation.</summary>
		public NSAttributedString AttributedString { get; set; }
		/// <summary>The result value from the asynchronous operation.</summary>
		public NSDictionary<NSString, NSObject> Attributes { get; set; }
		partial void Initialize ();
		/// <summary>Creates a new instance of this class.</summary>
		/// <param name="attributedString">Result value from an asynchronous operation.</param>
		/// <param name="attributes">Result value from an asynchronous operation.</param>
		public NSLoadFromHtmlResult (NSAttributedString attributedString, NSDictionary<NSString, NSObject> attributes) {
			this.AttributedString = attributedString;
			this.Attributes = attributes;
			Initialize ();
		}
	}
}
