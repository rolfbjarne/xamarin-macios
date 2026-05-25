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
	[Register("NSTextLayoutFragment", true)]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("macos")]
	[UnsupportedOSPlatform ("tvos")]
	[UnsupportedOSPlatform ("ios")]
	public unsafe partial class NSTextLayoutFragment : NSObject, INSCoding, INSSecureCoding {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selBottomMarginX = "bottomMargin";
		static readonly NativeHandle selBottomMarginXHandle = Selector.GetHandle ("bottomMargin");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selDrawAtPoint_InContext_X = "drawAtPoint:inContext:";
		static readonly NativeHandle selDrawAtPoint_InContext_XHandle = Selector.GetHandle ("drawAtPoint:inContext:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selEncodeWithCoder_X = "encodeWithCoder:";
		static readonly NativeHandle selEncodeWithCoder_XHandle = Selector.GetHandle ("encodeWithCoder:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selFrameForTextAttachmentAtLocation_X = "frameForTextAttachmentAtLocation:";
		static readonly NativeHandle selFrameForTextAttachmentAtLocation_XHandle = Selector.GetHandle ("frameForTextAttachmentAtLocation:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selInitWithCoder_X = "initWithCoder:";
		static readonly NativeHandle selInitWithCoder_XHandle = Selector.GetHandle ("initWithCoder:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selInitWithTextElement_Range_X = "initWithTextElement:range:";
		static readonly NativeHandle selInitWithTextElement_Range_XHandle = Selector.GetHandle ("initWithTextElement:range:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selInvalidateLayoutX = "invalidateLayout";
		static readonly NativeHandle selInvalidateLayoutXHandle = Selector.GetHandle ("invalidateLayout");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selLayoutFragmentFrameX = "layoutFragmentFrame";
		static readonly NativeHandle selLayoutFragmentFrameXHandle = Selector.GetHandle ("layoutFragmentFrame");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selLayoutQueueX = "layoutQueue";
		static readonly NativeHandle selLayoutQueueXHandle = Selector.GetHandle ("layoutQueue");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selLeadingPaddingX = "leadingPadding";
		static readonly NativeHandle selLeadingPaddingXHandle = Selector.GetHandle ("leadingPadding");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selRangeInElementX = "rangeInElement";
		static readonly NativeHandle selRangeInElementXHandle = Selector.GetHandle ("rangeInElement");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selRenderingSurfaceBoundsX = "renderingSurfaceBounds";
		static readonly NativeHandle selRenderingSurfaceBoundsXHandle = Selector.GetHandle ("renderingSurfaceBounds");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetLayoutQueue_X = "setLayoutQueue:";
		static readonly NativeHandle selSetLayoutQueue_XHandle = Selector.GetHandle ("setLayoutQueue:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selStateX = "state";
		static readonly NativeHandle selStateXHandle = Selector.GetHandle ("state");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selTextAttachmentViewProvidersX = "textAttachmentViewProviders";
		static readonly NativeHandle selTextAttachmentViewProvidersXHandle = Selector.GetHandle ("textAttachmentViewProviders");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selTextElementX = "textElement";
		static readonly NativeHandle selTextElementXHandle = Selector.GetHandle ("textElement");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selTextLayoutManagerX = "textLayoutManager";
		static readonly NativeHandle selTextLayoutManagerXHandle = Selector.GetHandle ("textLayoutManager");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selTextLineFragmentForTextLocation_IsUpstreamAffinity_X = "textLineFragmentForTextLocation:isUpstreamAffinity:";
		static readonly NativeHandle selTextLineFragmentForTextLocation_IsUpstreamAffinity_XHandle = Selector.GetHandle ("textLineFragmentForTextLocation:isUpstreamAffinity:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selTextLineFragmentForVerticalOffset_RequiresExactMatch_X = "textLineFragmentForVerticalOffset:requiresExactMatch:";
		static readonly NativeHandle selTextLineFragmentForVerticalOffset_RequiresExactMatch_XHandle = Selector.GetHandle ("textLineFragmentForVerticalOffset:requiresExactMatch:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selTextLineFragmentsX = "textLineFragments";
		static readonly NativeHandle selTextLineFragmentsXHandle = Selector.GetHandle ("textLineFragments");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selTopMarginX = "topMargin";
		static readonly NativeHandle selTopMarginXHandle = Selector.GetHandle ("topMargin");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selTrailingPaddingX = "trailingPadding";
		static readonly NativeHandle selTrailingPaddingXHandle = Selector.GetHandle ("trailingPadding");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly NativeHandle class_ptr = Class.GetHandle ("NSTextLayoutFragment");
		/// <summary>The Objective-C class handle for this class.</summary>
		/// <value>The pointer to the Objective-C class.</value>
		/// <remarks>
		///     Each managed class mirrors an unmanaged Objective-C class.
		///     This value contains the pointer to the Objective-C class.
		///     It is similar to calling the managed <see cref="ObjCRuntime.Class.GetHandle(string)" /> or the native <see href="https://developer.apple.com/documentation/objectivec/1418952-objc_getclass">objc_getClass</see> method with the type name.
		/// </remarks>
		public override NativeHandle ClassHandle { get { return class_ptr; } }
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
		public NSTextLayoutFragment (NSCoder coder) : base (NSObjectFlag.Empty)
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
		protected NSTextLayoutFragment (NSObjectFlag t) : base (t)
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
		protected internal NSTextLayoutFragment (NativeHandle handle) : base (handle)
		{
		}

		[Export ("initWithTextElement:range:")]
		[DesignatedInitializer]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public NSTextLayoutFragment (NSTextElement textElement, NSTextRange? rangeInElement)
			: base (NSObjectFlag.Empty)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var textElement__handle__ = textElement!.GetNonNullHandle (nameof (textElement));
			var rangeInElement__handle__ = rangeInElement.GetHandle ();
			if (IsDirectBinding) {
				InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (this.Handle, selInitWithTextElement_Range_XHandle, textElement__handle__, rangeInElement__handle__), "initWithTextElement:range:");
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, selInitWithTextElement_Range_XHandle, textElement__handle__, rangeInElement__handle__), "initWithTextElement:range:");
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (textElement);
			GC.KeepAlive (rangeInElement);
		}
		[Export ("drawAtPoint:inContext:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void Draw (CGPoint point, CGContext context)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var context__handle__ = context!.GetNonNullHandle (nameof (context));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_CGPoint_NativeHandle (this.Handle, selDrawAtPoint_InContext_XHandle, point, context.Handle);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_CGPoint_NativeHandle (&__objc_super__, selDrawAtPoint_InContext_XHandle, point, context.Handle);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (context);
		}
		/// <summary>Encodes the state of the object using the provided encoder.</summary><param name="encoder">The encoder object where the state of the object will be stored</param><remarks><para>This method is part of the <see cref="T:Foundation.INSCoding" /> protocol and is used by applications to preserve the state of the object into an archive.</para><para>Developers will typically create an <see cref="T:Foundation.NSKeyedArchiver" /> and then invoke the <see cref="M:Foundation.NSKeyedArchiver.ArchiveRootObjectToFile(Foundation.NSObject,System.String)" /> method which will call into this method.</para><para>If developers want to allow their object to be archived, they should override this method and store their state in using the provided <paramref name="encoder" /> parameter. In addition, developers should also implement a constructor that takes an NSCoder argument and is exported with <c>[Export ("initWithCoder:")]</c>.</para><example><code lang="csharp lang-csharp"><![CDATA[public void override EncodeTo (NSCoder coder) {
		/// coder.Encode (1, key: "version");
		/// coder.Encode (userName, key: "userName");
		/// coder.Encode (hostName, key: "hostName");]]></code></example></remarks>
		[Export ("encodeWithCoder:")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("maccatalyst")]
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
		[Export ("frameForTextAttachmentAtLocation:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual CGRect GetFrameForTextAttachment (INSTextLocation location)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var location__handle__ = location!.GetNonNullHandle (nameof (location));
			CGRect ret;
			if (IsDirectBinding) {
				if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
					ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSend_NativeHandle (this.Handle, selFrameForTextAttachmentAtLocation_XHandle, location__handle__);
				} else {
					ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSend_stret_NativeHandle (this.Handle, selFrameForTextAttachmentAtLocation_XHandle, location__handle__);
				}
			} else {
				if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSendSuper_NativeHandle (&__objc_super__, selFrameForTextAttachmentAtLocation_XHandle, location__handle__);
						GC.KeepAlive (this);
					}
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSendSuper_stret_NativeHandle (&__objc_super__, selFrameForTextAttachmentAtLocation_XHandle, location__handle__);
						GC.KeepAlive (this);
					}
				}
			}
			GC.KeepAlive (location);
			return ret!;
		}
		[Export ("textLineFragmentForVerticalOffset:requiresExactMatch:")]
		[SupportedOSPlatform ("macos14.0")]
		[SupportedOSPlatform ("maccatalyst17.0")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("ios")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSTextLineFragment? GetTextLineFragment (nfloat verticalOffset, bool requiresExactMatch)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			NSTextLineFragment ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<NSTextLineFragment> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_nfloat_bool (this.Handle, selTextLineFragmentForVerticalOffset_RequiresExactMatch_XHandle, verticalOffset, requiresExactMatch ? (byte) 1 : (byte) 0), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<NSTextLineFragment> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_nfloat_bool (&__objc_super__, selTextLineFragmentForVerticalOffset_RequiresExactMatch_XHandle, verticalOffset, requiresExactMatch ? (byte) 1 : (byte) 0), false)!;
					GC.KeepAlive (this);
				}
			}
			return ret;
		}
		[Export ("textLineFragmentForTextLocation:isUpstreamAffinity:")]
		[SupportedOSPlatform ("macos14.0")]
		[SupportedOSPlatform ("maccatalyst17.0")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("ios")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSTextLineFragment? GetTextLineFragment (INSTextLocation textLocation, bool isUpstreamAffinity)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var textLocation__handle__ = textLocation!.GetNonNullHandle (nameof (textLocation));
			NSTextLineFragment? ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<NSTextLineFragment> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_bool (this.Handle, selTextLineFragmentForTextLocation_IsUpstreamAffinity_XHandle, textLocation__handle__, isUpstreamAffinity ? (byte) 1 : (byte) 0), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<NSTextLineFragment> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_bool (&__objc_super__, selTextLineFragmentForTextLocation_IsUpstreamAffinity_XHandle, textLocation__handle__, isUpstreamAffinity ? (byte) 1 : (byte) 0), false)!;
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (textLocation);
			return ret!;
		}
		[Export ("invalidateLayout")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void InvalidateLayout ()
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, selInvalidateLayoutXHandle);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper (&__objc_super__, selInvalidateLayoutXHandle);
					GC.KeepAlive (this);
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual nfloat BottomMargin {
			[Export ("bottomMargin")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				nfloat ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.nfloat_objc_msgSend (this.Handle, selBottomMarginXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.nfloat_objc_msgSendSuper (&__objc_super__, selBottomMarginXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual CGRect LayoutFragmentFrame {
			[Export ("layoutFragmentFrame")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				CGRect ret;
				if (IsDirectBinding) {
					if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
						ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSend (this.Handle, selLayoutFragmentFrameXHandle);
					} else {
						ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSend_stret (this.Handle, selLayoutFragmentFrameXHandle);
					}
				} else {
					if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
						unsafe {
							var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
							ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSendSuper (&__objc_super__, selLayoutFragmentFrameXHandle);
							GC.KeepAlive (this);
						}
					} else {
						unsafe {
							var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
							ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSendSuper_stret (&__objc_super__, selLayoutFragmentFrameXHandle);
							GC.KeepAlive (this);
						}
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSOperationQueue? LayoutQueue {
			[Export ("layoutQueue", ArgumentSemantic.Retain)]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				NSOperationQueue? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSOperationQueue> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selLayoutQueueXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<NSOperationQueue> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selLayoutQueueXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setLayoutQueue:", ArgumentSemantic.Retain)]
			set {
				global::AppKit.NSApplication.EnsureUIThread ();
				var value__handle__ = value.GetHandle ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selSetLayoutQueue_XHandle, value__handle__);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selSetLayoutQueue_XHandle, value__handle__);
						GC.KeepAlive (this);
					}
				}
				GC.KeepAlive (value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual nfloat LeadingPadding {
			[Export ("leadingPadding")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				nfloat ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.nfloat_objc_msgSend (this.Handle, selLeadingPaddingXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.nfloat_objc_msgSendSuper (&__objc_super__, selLeadingPaddingXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSTextRange RangeInElement {
			[Export ("rangeInElement", ArgumentSemantic.Retain)]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				NSTextRange? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSTextRange> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selRangeInElementXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<NSTextRange> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selRangeInElementXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual CGRect RenderingSurfaceBounds {
			[Export ("renderingSurfaceBounds")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				CGRect ret;
				if (IsDirectBinding) {
					if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
						ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSend (this.Handle, selRenderingSurfaceBoundsXHandle);
					} else {
						ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSend_stret (this.Handle, selRenderingSurfaceBoundsXHandle);
					}
				} else {
					if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
						unsafe {
							var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
							ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSendSuper (&__objc_super__, selRenderingSurfaceBoundsXHandle);
							GC.KeepAlive (this);
						}
					} else {
						unsafe {
							var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
							ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSendSuper_stret (&__objc_super__, selRenderingSurfaceBoundsXHandle);
							GC.KeepAlive (this);
						}
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSTextLayoutFragmentState State {
			[Export ("state")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				NSTextLayoutFragmentState ret;
				if (IsDirectBinding) {
					ret = (NSTextLayoutFragmentState) (ulong) global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend (this.Handle, selStateXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = (NSTextLayoutFragmentState) (ulong) global::ObjCRuntime.Messaging.UIntPtr_objc_msgSendSuper (&__objc_super__, selStateXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSTextAttachmentViewProvider[] TextAttachmentViewProviders {
			[Export ("textAttachmentViewProviders", ArgumentSemantic.Copy)]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				NSTextAttachmentViewProvider[]? ret;
				if (IsDirectBinding) {
					ret = CFArray.ArrayFromHandle<NSTextAttachmentViewProvider>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selTextAttachmentViewProvidersXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFArray.ArrayFromHandle<NSTextAttachmentViewProvider>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selTextAttachmentViewProvidersXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		object? __mt_TextElement_var;
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSTextElement? TextElement {
			[Export ("textElement", ArgumentSemantic.Weak)]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				NSTextElement? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSTextElement> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selTextElementXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<NSTextElement> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selTextElementXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				MarkDirty ();
				__mt_TextElement_var = ret;
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		object? __mt_TextLayoutManager_var;
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSTextLayoutManager? TextLayoutManager {
			[Export ("textLayoutManager", ArgumentSemantic.Weak)]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				NSTextLayoutManager? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSTextLayoutManager> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selTextLayoutManagerXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<NSTextLayoutManager> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selTextLayoutManagerXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				MarkDirty ();
				__mt_TextLayoutManager_var = ret;
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSTextLineFragment[] TextLineFragments {
			[Export ("textLineFragments", ArgumentSemantic.Copy)]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				NSTextLineFragment[]? ret;
				if (IsDirectBinding) {
					ret = CFArray.ArrayFromHandle<NSTextLineFragment>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selTextLineFragmentsXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFArray.ArrayFromHandle<NSTextLineFragment>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selTextLineFragmentsXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual nfloat TopMargin {
			[Export ("topMargin")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				nfloat ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.nfloat_objc_msgSend (this.Handle, selTopMarginXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.nfloat_objc_msgSendSuper (&__objc_super__, selTopMarginXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual nfloat TrailingPadding {
			[Export ("trailingPadding")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				nfloat ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.nfloat_objc_msgSend (this.Handle, selTrailingPaddingXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.nfloat_objc_msgSendSuper (&__objc_super__, selTrailingPaddingXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		protected override void Dispose (bool disposing)
		{
			base.Dispose (disposing);
			if (Handle == IntPtr.Zero) {
				__mt_TextElement_var = null;
				__mt_TextLayoutManager_var = null;
			}
		}
	} /* class NSTextLayoutFragment */
}
