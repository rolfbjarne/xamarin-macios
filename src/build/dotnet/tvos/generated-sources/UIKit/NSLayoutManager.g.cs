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
using Photos;
using ModelIO;
using Network;
using SceneKit;
using Security;
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
using CoreAnimation;
using CoreFoundation;
using NetworkExtension;
using MetalPerformanceShadersGraph;
#nullable enable
namespace UIKit {
	/// <summary>Responsible for layout of text stored in a <see cref="T:UIKit.NSTextStorage" /> object.</summary><remarks><para>iOS 7 introduced "Text Kit," a broad set of APIs and modifications of existing classes, built on <see cref="N:CoreText" />, that greatly expands the typographical flexibility of iOS.</para><para>
	/// The <see cref="P:UIKit.NSLayoutManager.TextStorage" /> property holds a reference to a <see cref="T:UIKit.NSTextStorage" /> object,
	/// that holds a potentially large amount of styled text. The <see cref="P:UIKit.NSLayoutManager.TextContainers" /> property holds
	/// an ordered array of <see cref="T:UIKit.NSTextContainer" /> objects in which it lays out text. The <see cref="T:UIKit.NSTextContainer" />s, in turn, hold references to
	/// <see cref="T:UIKit.UITextView" /> objects, which actually display the text.
	/// </para></remarks><related type="externalDocumentation" href="https://developer.apple.com/documentation/uikit/nslayoutmanager">Apple documentation for <c>NSLayoutManager</c></related>
	[Register("NSLayoutManager", true)]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("tvos")]
	public unsafe partial class NSLayoutManager : NSObject, INSCoding, INSSecureCoding {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly NativeHandle class_ptr = Class.GetHandle ("NSLayoutManager");
		/// <summary>The Objective-C class handle for this class.</summary>
		/// <value>The pointer to the Objective-C class.</value>
		/// <remarks>
		///     Each managed class mirrors an unmanaged Objective-C class.
		///     This value contains the pointer to the Objective-C class.
		///     It is similar to calling the managed <see cref="ObjCRuntime.Class.GetHandle(string)" /> or the native <see href="https://developer.apple.com/documentation/objectivec/1418952-objc_getclass">objc_getClass</see> method with the type name.
		/// </remarks>
		public override NativeHandle ClassHandle { get { return class_ptr; } }
		/// <summary>Creates a new <see cref="NSLayoutManager" /> with default values.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[DesignatedInitializer]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public NSLayoutManager () : base (NSObjectFlag.Empty)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
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
		public NSLayoutManager (NSCoder coder) : base (NSObjectFlag.Empty)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
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
		protected NSLayoutManager (NSObjectFlag t) : base (t)
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
		protected internal NSLayoutManager (NativeHandle handle) : base (handle)
		{
		}

		/// <summary>Appends a <see cref="T:UIKit.NSTextContainer" /> to the <see cref="P:UIKit.NSLayoutManager.TextContainers" /> property.</summary><param name="container">An <see cref="T:UIKit.NSTextContainer" /> to be appended to the <see cref="P:UIKit.NSLayoutManager.TextContainers" /> property.</param><altmember cref="M:UIKit.NSLayoutManager.InsertTextContainer(UIKit.NSTextContainer,System.IntPtr)" />
		[Export ("addTextContainer:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void AddTextContainer (NSTextContainer container)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var container__handle__ = container!.GetNonNullHandle (nameof (container));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("addTextContainer:"), container__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, Selector.GetHandle ("addTextContainer:"), container__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (container);
		}
		/// <summary>Draws background marks for the given glyph range.</summary><param name="glyphsToShow">To be added.</param><param name="origin">To be added.</param><remarks><para>Background marks include text background color, highlighting, and table backgrounds and borders. Application developers can override this function in subclasses to fully customize background drawing.</para><para><paramref name="glyphsToShow" /> must specify glyphs within a single <see cref="T:UIKit.NSTextContainer" />.</para></remarks>
		[Export ("drawBackgroundForGlyphRange:atPoint:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DrawBackground (NSRange glyphsToShow, CGPoint origin)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NSRange_CGPoint (this.Handle, Selector.GetHandle ("drawBackgroundForGlyphRange:atPoint:"), glyphsToShow, origin);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NSRange_CGPoint (&__objc_super__, Selector.GetHandle ("drawBackgroundForGlyphRange:atPoint:"), glyphsToShow, origin);
					GC.KeepAlive (this);
				}
			}
		}
		/// <summary>Draws the specified glyph range.</summary><param name="glyphsToShow">To be added.</param><param name="origin">To be added.</param><remarks><para>This method causes glyph generation and layout, if needed.</para><para><paramref name="glyphsToShow" /> must specify glyphs within a single <see cref="T:UIKit.NSTextContainer" />.</para></remarks>
		[Export ("drawGlyphsForGlyphRange:atPoint:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DrawGlyphs (NSRange glyphsToShow, CGPoint origin)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NSRange_CGPoint (this.Handle, Selector.GetHandle ("drawGlyphsForGlyphRange:atPoint:"), glyphsToShow, origin);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NSRange_CGPoint (&__objc_super__, Selector.GetHandle ("drawGlyphsForGlyphRange:atPoint:"), glyphsToShow, origin);
					GC.KeepAlive (this);
				}
			}
		}
		/// <param name="glyphRange">The range of glyphs to be struck through.</param><param name="strikethroughVal">The drawing style of the strikethrough (for instance, dashed or solid).</param><param name="baselineOffset">Distance above the baseline to draw the strikethrough.</param><param name="lineRect">The line fragment rectangle containing <paramref name="glyphRange" />.</param><param name="lineGlyphRange">All glyphs within <paramref name="lineRect" />.</param><param name="containerOrigin">The origin of the <paramref name="lineRect" /> objects containing <see cref="T:UIKit.NSTextContainer" />.</param><summary>Draws a strikethrough line through the glyphs in <paramref name="glyphRange" />.</summary><remarks><para>Developers should generally use the simpler <see cref="M:UIKit.NSLayoutManager.Strikethrough(Foundation.NSRange,Foundation.NSUnderlineStyle,CoreGraphics.CGRect,Foundation.NSRange,CoreGraphics.CGPoint)" /> method.</para></remarks>
		[Export ("drawStrikethroughForGlyphRange:strikethroughType:baselineOffset:lineFragmentRect:lineFragmentGlyphRange:containerOrigin:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DrawStrikethrough (NSRange glyphRange, NSUnderlineStyle strikethroughVal, nfloat baselineOffset, CGRect lineRect, NSRange lineGlyphRange, CGPoint containerOrigin)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NSRange_IntPtr_nfloat_CGRect_NSRange_CGPoint (this.Handle, Selector.GetHandle ("drawStrikethroughForGlyphRange:strikethroughType:baselineOffset:lineFragmentRect:lineFragmentGlyphRange:containerOrigin:"), glyphRange, (IntPtr) (long) strikethroughVal, baselineOffset, lineRect, lineGlyphRange, containerOrigin);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NSRange_IntPtr_nfloat_CGRect_NSRange_CGPoint (&__objc_super__, Selector.GetHandle ("drawStrikethroughForGlyphRange:strikethroughType:baselineOffset:lineFragmentRect:lineFragmentGlyphRange:containerOrigin:"), glyphRange, (IntPtr) (long) strikethroughVal, baselineOffset, lineRect, lineGlyphRange, containerOrigin);
					GC.KeepAlive (this);
				}
			}
		}
		/// <summary>Underlines the glyphs in <paramref name="glyphRange" />.</summary><param name="glyphRange">The range of glyphs to be underlined.</param><param name="underlineVal">The drawing style of the underline.</param><param name="baselineOffset">The distance from the baseline to draw the underline.</param><param name="lineRect">The line fragment rectangle containing <paramref name="glyphRange" />.</param><param name="lineGlyphRange">All glyphs within <paramref name="lineRect" />.</param><param name="containerOrigin">The origin of the <paramref name="lineRect" /> objects containing <see cref="T:UIKit.NSTextContainer" />.</param><remarks><para>Developers should generally use the simpler <see cref="M:UIKit.NSLayoutManager.Underline(Foundation.NSRange,Foundation.NSUnderlineStyle,CoreGraphics.CGRect,Foundation.NSRange,CoreGraphics.CGPoint)" /> method.</para></remarks>
		[Export ("drawUnderlineForGlyphRange:underlineType:baselineOffset:lineFragmentRect:lineFragmentGlyphRange:containerOrigin:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DrawUnderline (NSRange glyphRange, NSUnderlineStyle underlineVal, nfloat baselineOffset, CGRect lineRect, NSRange lineGlyphRange, CGPoint containerOrigin)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NSRange_IntPtr_nfloat_CGRect_NSRange_CGPoint (this.Handle, Selector.GetHandle ("drawUnderlineForGlyphRange:underlineType:baselineOffset:lineFragmentRect:lineFragmentGlyphRange:containerOrigin:"), glyphRange, (IntPtr) (long) underlineVal, baselineOffset, lineRect, lineGlyphRange, containerOrigin);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NSRange_IntPtr_nfloat_CGRect_NSRange_CGPoint (&__objc_super__, Selector.GetHandle ("drawUnderlineForGlyphRange:underlineType:baselineOffset:lineFragmentRect:lineFragmentGlyphRange:containerOrigin:"), glyphRange, (IntPtr) (long) underlineVal, baselineOffset, lineRect, lineGlyphRange, containerOrigin);
					GC.KeepAlive (this);
				}
			}
		}
		/// <param name="glyphIndex">To be added.</param><summary>Returns <see langword="true" /> if the specified glyph draws outside of its line fragment rectangle.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("drawsOutsideLineFragmentForGlyphAtIndex:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool DrawsOutsideLineFragmentForGlyph (nuint glyphIndex)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			byte ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_UIntPtr (this.Handle, Selector.GetHandle ("drawsOutsideLineFragmentForGlyphAtIndex:"), glyphIndex);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper_UIntPtr (&__objc_super__, Selector.GetHandle ("drawsOutsideLineFragmentForGlyphAtIndex:"), glyphIndex);
					GC.KeepAlive (this);
				}
			}
			return ret != 0;
		}
		/// <summary>Encodes the state of the object using the provided encoder.</summary><param name="encoder">The encoder object where the state of the object will be stored</param><remarks><para>This method is part of the <see cref="T:Foundation.INSCoding" /> protocol and is used by applications to preserve the state of the object into an archive.</para><para>Developers will typically create an <see cref="T:Foundation.NSKeyedArchiver" /> and then invoke the <see cref="M:Foundation.NSKeyedArchiver.ArchiveRootObjectToFile(Foundation.NSObject,System.String)" /> method which will call into this method.</para><para>If developers want to allow their object to be archived, they should override this method and store their state in using the provided <paramref name="encoder" /> parameter. In addition, developers should also implement a constructor that takes an NSCoder argument and is exported with <c>[Export ("initWithCoder:")]</c>.</para><example><code lang="csharp lang-csharp"><![CDATA[public void override EncodeTo (NSCoder coder) {
		/// coder.Encode (1, key: "version");
		/// coder.Encode (userName, key: "userName");
		/// coder.Encode (hostName, key: "hostName");]]></code></example></remarks>
		[Export ("encodeWithCoder:")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void EncodeTo (NSCoder encoder)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
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
		/// <summary>Forces the <see cref="T:UIKit.NSLayoutManager" /> to generate glyphs for the specified characters, if it has not already done so.</summary><param name="characterRange">To be added.</param><remarks><para>The <see cref="T:UIKit.NSLayoutManager" /> may calculate glyphs for a range larger than the <paramref name="characterRange" />. If <see cref="P:UIKit.NSLayoutManager.AllowsNonContiguousLayout" /> is <see langword="false" />, the range will always extend to the beginning of the text.</para></remarks>
		[Export ("ensureGlyphsForCharacterRange:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void EnsureGlyphsForCharacterRange (NSRange characterRange)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NSRange (this.Handle, Selector.GetHandle ("ensureGlyphsForCharacterRange:"), characterRange);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NSRange (&__objc_super__, Selector.GetHandle ("ensureGlyphsForCharacterRange:"), characterRange);
					GC.KeepAlive (this);
				}
			}
		}
		/// <summary>Forces the <see cref="T:UIKit.NSLayoutManager" /> to generate glyphs for the specified glyph range, if it has not already done so.</summary><param name="glyphRange">To be added.</param><remarks><para>The <see cref="T:UIKit.NSLayoutManager" /> may calculate glyphs for a range larger than the <paramref name="glyphRange" />. If <see cref="P:UIKit.NSLayoutManager.AllowsNonContiguousLayout" /> is <see langword="false" />, the range will always extend to the beginning of the text.</para></remarks>
		[Export ("ensureGlyphsForGlyphRange:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void EnsureGlyphsForGlyphRange (NSRange glyphRange)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NSRange (this.Handle, Selector.GetHandle ("ensureGlyphsForGlyphRange:"), glyphRange);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NSRange (&__objc_super__, Selector.GetHandle ("ensureGlyphsForGlyphRange:"), glyphRange);
					GC.KeepAlive (this);
				}
			}
		}
		/// <summary>Forces the layout manager to perform layout on <paramref name="bounds" /> within <paramref name="container" />.</summary><param name="bounds">To be added.</param><param name="container">To be added.</param><remarks><para>The layout manager may lay out areas larger than <paramref name="bounds" />.</para></remarks>
		[Export ("ensureLayoutForBoundingRect:inTextContainer:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void EnsureLayoutForBoundingRect (CGRect bounds, NSTextContainer container)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var container__handle__ = container!.GetNonNullHandle (nameof (container));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_CGRect_NativeHandle (this.Handle, Selector.GetHandle ("ensureLayoutForBoundingRect:inTextContainer:"), bounds, container__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_CGRect_NativeHandle (&__objc_super__, Selector.GetHandle ("ensureLayoutForBoundingRect:inTextContainer:"), bounds, container__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (container);
		}
		/// <summary>Forces the <see cref="T:UIKit.NSLayoutManager" /> to layout the specified characters, if it has not already done so.</summary><param name="characterRange">To be added.</param><remarks><para>The <see cref="T:UIKit.NSLayoutManager" /> may layout an area larger than the <paramref name="characterRange" />. If <see cref="P:UIKit.NSLayoutManager.AllowsNonContiguousLayout" /> is <see langword="false" />, the range will always extend to the beginning of the text.</para></remarks>
		[Export ("ensureLayoutForCharacterRange:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void EnsureLayoutForCharacterRange (NSRange characterRange)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NSRange (this.Handle, Selector.GetHandle ("ensureLayoutForCharacterRange:"), characterRange);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NSRange (&__objc_super__, Selector.GetHandle ("ensureLayoutForCharacterRange:"), characterRange);
					GC.KeepAlive (this);
				}
			}
		}
		/// <summary>Forces the <see cref="T:UIKit.NSLayoutManager" /> to layout the specified glyphs, if it has not already done so.</summary><param name="glyphRange">To be added.</param><remarks><para>The <see cref="T:UIKit.NSLayoutManager" /> may layout a larger range than the specified <paramref name="glyphRange" />. If <see cref="P:UIKit.NSLayoutManager.AllowsNonContiguousLayout" /> is <see langword="false" />, the range will always extend to the beginning of the text.</para></remarks>
		[Export ("ensureLayoutForGlyphRange:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void EnsureLayoutForGlyphRange (NSRange glyphRange)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NSRange (this.Handle, Selector.GetHandle ("ensureLayoutForGlyphRange:"), glyphRange);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NSRange (&__objc_super__, Selector.GetHandle ("ensureLayoutForGlyphRange:"), glyphRange);
					GC.KeepAlive (this);
				}
			}
		}
		/// <summary>Forces the <see cref="T:UIKit.NSLayoutManager" /> to layout the specified <see cref="T:UIKit.NSTextContainer" />, if it has not already done so.</summary><param name="container">To be added.</param><remarks><para>The <see cref="T:UIKit.NSLayoutManager" /> may layout more than the specified <paramref name="container" />. If <see cref="P:UIKit.NSLayoutManager.AllowsNonContiguousLayout" /> is <see langword="false" />, the range will always extend to the beginning of the text.</para></remarks>
		[Export ("ensureLayoutForTextContainer:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void EnsureLayoutForTextContainer (NSTextContainer container)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var container__handle__ = container!.GetNonNullHandle (nameof (container));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("ensureLayoutForTextContainer:"), container__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, Selector.GetHandle ("ensureLayoutForTextContainer:"), container__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (container);
		}
		/// <summary>Enumerates the enclosing rectangles for the specified glyph range.</summary><param name="glyphRange">To be added.</param><param name="selectedRange">To be added.</param><param name="textContainer">To be added.</param><param name="callback">To be added.</param><remarks>To be added.</remarks>
		[Export ("enumerateEnclosingRectsForGlyphRange:withinSelectedGlyphRange:inTextContainer:usingBlock:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void EnumerateEnclosingRects (NSRange glyphRange, NSRange selectedRange, NSTextContainer textContainer, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDNSTextLayoutEnumerateEnclosingRects))]NSTextLayoutEnumerateEnclosingRects callback)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var textContainer__handle__ = textContainer!.GetNonNullHandle (nameof (textContainer));
			if (callback is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (callback));
			using var block_callback = Trampolines.SDNSTextLayoutEnumerateEnclosingRects.CreateBlock (callback);
			BlockLiteral *block_ptr_callback = &block_callback;
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NSRange_NSRange_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("enumerateEnclosingRectsForGlyphRange:withinSelectedGlyphRange:inTextContainer:usingBlock:"), glyphRange, selectedRange, textContainer__handle__, (IntPtr) block_ptr_callback);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NSRange_NSRange_NativeHandle_NativeHandle (&__objc_super__, Selector.GetHandle ("enumerateEnclosingRectsForGlyphRange:withinSelectedGlyphRange:inTextContainer:usingBlock:"), glyphRange, selectedRange, textContainer__handle__, (IntPtr) block_ptr_callback);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (textContainer);
		}
		/// <summary>Enumerate the line fragments intersecting with the specified glyph range.|Enumerate the line fragments intersecting with the specified glyph rane.</summary><param name="glyphRange">To be added.</param><param name="callback">To be added.</param><remarks>To be added.</remarks>
		[Export ("enumerateLineFragmentsForGlyphRange:usingBlock:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void EnumerateLineFragments (NSRange glyphRange, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDNSTextLayoutEnumerateLineFragments))]NSTextLayoutEnumerateLineFragments callback)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			if (callback is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (callback));
			using var block_callback = Trampolines.SDNSTextLayoutEnumerateLineFragments.CreateBlock (callback);
			BlockLiteral *block_ptr_callback = &block_callback;
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NSRange_NativeHandle (this.Handle, Selector.GetHandle ("enumerateLineFragmentsForGlyphRange:usingBlock:"), glyphRange, (IntPtr) block_ptr_callback);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NSRange_NativeHandle (&__objc_super__, Selector.GetHandle ("enumerateLineFragmentsForGlyphRange:usingBlock:"), glyphRange, (IntPtr) block_ptr_callback);
					GC.KeepAlive (this);
				}
			}
		}
		[Export ("fillBackgroundRectArray:count:forCharacterRange:color:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[Advice (@"This method should never be called, only overridden.")]
		protected virtual void FillBackground (nint rectArray, nuint rectCount, NSRange characterRange, UIColor color)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var color__handle__ = color!.GetNonNullHandle (nameof (color));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr_UIntPtr_NSRange_NativeHandle (this.Handle, Selector.GetHandle ("fillBackgroundRectArray:count:forCharacterRange:color:"), rectArray, rectCount, characterRange, color__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr_UIntPtr_NSRange_NativeHandle (&__objc_super__, Selector.GetHandle ("fillBackgroundRectArray:count:forCharacterRange:color:"), rectArray, rectCount, characterRange, color__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (color);
		}
		/// <param name="glyphIndex">To be added.</param><summary>The size of the attachment cell associated with the glyph at the specified index</summary><returns>The size of attachment cell at the glyph at <paramref name="glyphIndex" />. Returns {-1.0f, -1.0f} if there is no attachment at the specified glyph.</returns><remarks>To be added.</remarks>
		[Export ("attachmentSizeForGlyphAtIndex:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual CGSize GetAttachmentSizeForGlyph (nuint glyphIndex)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			CGSize ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.CGSize_objc_msgSend_UIntPtr (this.Handle, Selector.GetHandle ("attachmentSizeForGlyphAtIndex:"), glyphIndex);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.CGSize_objc_msgSendSuper_UIntPtr (&__objc_super__, Selector.GetHandle ("attachmentSizeForGlyphAtIndex:"), glyphIndex);
					GC.KeepAlive (this);
				}
			}
			return ret;
		}
		/// <param name="glyphRange">To be added.</param><param name="container">To be added.</param><summary>The bounding rectangle, in container coordinates, for the glyphs in the specified range.</summary><returns>To be added.</returns><remarks><para>The returned <see cref="T:CoreGraphics.CGRect" /> includes the area needed for all marks associated with the glyphs, including the area needed for glyphs that draw outside of their line fragment rectangle and for marks such as underlining.</para></remarks>
		[Export ("boundingRectForGlyphRange:inTextContainer:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual CGRect GetBoundingRect (NSRange glyphRange, NSTextContainer container)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var container__handle__ = container!.GetNonNullHandle (nameof (container));
			CGRect ret;
			if (IsDirectBinding) {
				if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
					ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSend_NSRange_NativeHandle (this.Handle, Selector.GetHandle ("boundingRectForGlyphRange:inTextContainer:"), glyphRange, container__handle__);
				} else {
					ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSend_stret_NSRange_NativeHandle (this.Handle, Selector.GetHandle ("boundingRectForGlyphRange:inTextContainer:"), glyphRange, container__handle__);
				}
			} else {
				if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSendSuper_NSRange_NativeHandle (&__objc_super__, Selector.GetHandle ("boundingRectForGlyphRange:inTextContainer:"), glyphRange, container__handle__);
						GC.KeepAlive (this);
					}
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSendSuper_stret_NSRange_NativeHandle (&__objc_super__, Selector.GetHandle ("boundingRectForGlyphRange:inTextContainer:"), glyphRange, container__handle__);
						GC.KeepAlive (this);
					}
				}
			}
			GC.KeepAlive (container);
			return ret!;
		}
		/// <summary>The index of the first character associated with the glyph at the specified index.</summary><param name="glyphIndex">To be added.</param><returns>To be added.</returns><remarks><para>If <see cref="P:UIKit.NSLayoutManager.AllowsNonContiguousLayout" /> is <see langword="false" />, calling this method will result in generating all glyphs up to and including <paramref name="glyphIndex" />.</para></remarks>
		[Export ("characterIndexForGlyphAtIndex:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual nuint GetCharacterIndex (nuint glyphIndex)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			nuint ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend_UIntPtr (this.Handle, Selector.GetHandle ("characterIndexForGlyphAtIndex:"), glyphIndex);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.UIntPtr_objc_msgSendSuper_UIntPtr (&__objc_super__, Selector.GetHandle ("characterIndexForGlyphAtIndex:"), glyphIndex);
					GC.KeepAlive (this);
				}
			}
			return ret;
		}
		[Export ("characterIndexForPoint:inTextContainer:fractionOfDistanceBetweenInsertionPoints:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		protected virtual nuint GetCharacterIndex (CGPoint point, NSTextContainer container, nint fractionOfDistanceBetweenInsertionPoints)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var container__handle__ = container!.GetNonNullHandle (nameof (container));
			nuint ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend_CGPoint_NativeHandle_IntPtr (this.Handle, Selector.GetHandle ("characterIndexForPoint:inTextContainer:fractionOfDistanceBetweenInsertionPoints:"), point, container__handle__, fractionOfDistanceBetweenInsertionPoints);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.UIntPtr_objc_msgSendSuper_CGPoint_NativeHandle_IntPtr (&__objc_super__, Selector.GetHandle ("characterIndexForPoint:inTextContainer:fractionOfDistanceBetweenInsertionPoints:"), point, container__handle__, fractionOfDistanceBetweenInsertionPoints);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (container);
			return ret!;
		}
		/// <param name="point">To be added.</param><param name="container">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public nuint GetCharacterIndex (CGPoint point, NSTextContainer container)
		{
			return GetCharacterIndex (point, container, IntPtr.Zero);
		}
		/// <param name="point">To be added.</param><param name="container">To be added.</param><param name="fractionOfDistanceBetweenInsertionPoints">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe nuint GetCharacterIndex (CGPoint point, NSTextContainer container, out nfloat fractionOfDistanceBetweenInsertionPoints)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var container__handle__ = container!.GetNonNullHandle (nameof (container));
			fixed (nfloat* fractionOfDistanceBetweenInsertionPoints__pointer = &fractionOfDistanceBetweenInsertionPoints) {
			fractionOfDistanceBetweenInsertionPoints = default;
			nuint ret;
			ret = global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend_CGPoint_NativeHandle_out_NFloat (this.Handle, Selector.GetHandle ("characterIndexForPoint:inTextContainer:fractionOfDistanceBetweenInsertionPoints:"), point, container__handle__, fractionOfDistanceBetweenInsertionPoints__pointer);
			GC.KeepAlive (container);
			return ret!;
			}
		}
		/// <param name="glyphRange">To be added.</param><param name="actualGlyphRange">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("characterRangeForGlyphRange:actualGlyphRange:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		protected virtual NSRange GetCharacterRange (NSRange glyphRange, nint actualGlyphRange)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			NSRange ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.NSRange_objc_msgSend_NSRange_IntPtr (this.Handle, Selector.GetHandle ("characterRangeForGlyphRange:actualGlyphRange:"), glyphRange, actualGlyphRange);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.NSRange_objc_msgSendSuper_NSRange_IntPtr (&__objc_super__, Selector.GetHandle ("characterRangeForGlyphRange:actualGlyphRange:"), glyphRange, actualGlyphRange);
					GC.KeepAlive (this);
				}
			}
			return ret;
		}
		/// <param name="glyphRange">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public NSRange GetCharacterRange (NSRange glyphRange)
		{
			return GetCharacterRange (glyphRange, IntPtr.Zero);
		}
		/// <param name="glyphRange">To be added.</param><param name="actualGlyphRange">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe NSRange GetCharacterRange (NSRange glyphRange, out NSRange actualGlyphRange)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			fixed (NSRange* actualGlyphRange__pointer = &actualGlyphRange) {
			actualGlyphRange = default;
			NSRange ret;
			ret = global::ObjCRuntime.Messaging.NSRange_objc_msgSend_NSRange_out_NSRange (this.Handle, Selector.GetHandle ("characterRangeForGlyphRange:actualGlyphRange:"), glyphRange, actualGlyphRange__pointer);
			return ret;
			}
		}
		/// <summary>The indices of the first character and glyph that are not laid out.</summary><param name="characterIndex">To be added.</param><param name="glyphIndex">To be added.</param><remarks><para>Application developers should be aware that <paramref name="characterIndex" /> and <paramref name="glyphIndex" /> may be <see langword="null" /> if the text is fully laid out.</para></remarks>
		[Export ("getFirstUnlaidCharacterIndex:glyphIndex:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void GetFirstUnlaidCharacterIndex (out nuint characterIndex, out nuint glyphIndex)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			fixed (nuint* characterIndex__pointer = &characterIndex) {
			fixed (nuint* glyphIndex__pointer = &glyphIndex) {
			characterIndex = default;
			glyphIndex = default;
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_out_UIntPtr_out_UIntPtr (this.Handle, Selector.GetHandle ("getFirstUnlaidCharacterIndex:glyphIndex:"), characterIndex__pointer, glyphIndex__pointer);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_out_UIntPtr_out_UIntPtr (&__objc_super__, Selector.GetHandle ("getFirstUnlaidCharacterIndex:glyphIndex:"), characterIndex__pointer, glyphIndex__pointer);
					GC.KeepAlive (this);
				}
			}
			}
			}
		}
		/// <summary>Developers should call <see cref="M:UIKit.NSLayoutManager.GetGlyphIndex(CoreGraphics.CGPoint,UIKit.NSTextContainer)" /> rather than this primitive function.</summary><param name="point">To be added.</param><param name="container">To be added.</param><returns>To be added.</returns><remarks><para>This method is <c>public</c> for overriding purposes but is not intended for developers to call.</para></remarks>
		[Export ("fractionOfDistanceThroughGlyphForPoint:inTextContainer:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual nfloat GetFractionOfDistanceThroughGlyph (CGPoint point, NSTextContainer container)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var container__handle__ = container!.GetNonNullHandle (nameof (container));
			nfloat ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.nfloat_objc_msgSend_CGPoint_NativeHandle (this.Handle, Selector.GetHandle ("fractionOfDistanceThroughGlyphForPoint:inTextContainer:"), point, container__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.nfloat_objc_msgSendSuper_CGPoint_NativeHandle (&__objc_super__, Selector.GetHandle ("fractionOfDistanceThroughGlyphForPoint:inTextContainer:"), point, container__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (container);
			return ret!;
		}
		/// <param name="glyphIndex">To be added.</param><param name="isValidIndex">To be added.</param><summary>Retrieves the glyph as <paramref name="glyphIndex" />, setting <paramref name="isValidIndex" /> to <see langword="true" /> if the index is valid.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("CGGlyphAtIndex:isValidIndex:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual ushort GetGlyph (nuint glyphIndex, out bool isValidIndex)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			fixed (bool* isValidIndex__pointer = &isValidIndex) {
			isValidIndex = default;
			ushort ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.UInt16_objc_msgSend_UIntPtr_out_Boolean (this.Handle, Selector.GetHandle ("CGGlyphAtIndex:isValidIndex:"), glyphIndex, (byte*) isValidIndex__pointer);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.UInt16_objc_msgSendSuper_UIntPtr_out_Boolean (&__objc_super__, Selector.GetHandle ("CGGlyphAtIndex:isValidIndex:"), glyphIndex, (byte*) isValidIndex__pointer);
					GC.KeepAlive (this);
				}
			}
			return ret;
			}
		}
		/// <param name="glyphIndex">To be added.</param><summary>Retrieves the glyph at <paramref name="glyphIndex" />.</summary><returns>To be added.</returns><remarks><para>Calling this method generates all glyphs up to and including the glyph at <paramref name="glyphIndex" />.</para></remarks>
		[Export ("CGGlyphAtIndex:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual ushort GetGlyph (nuint glyphIndex)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			ushort ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.UInt16_objc_msgSend_UIntPtr (this.Handle, Selector.GetHandle ("CGGlyphAtIndex:"), glyphIndex);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.UInt16_objc_msgSendSuper_UIntPtr (&__objc_super__, Selector.GetHandle ("CGGlyphAtIndex:"), glyphIndex);
					GC.KeepAlive (this);
				}
			}
			return ret;
		}
		/// <summary>The glyph index for the character at the specified index.</summary><param name="characterIndex">To be added.</param><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("glyphIndexForCharacterAtIndex:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual nuint GetGlyphIndex (nuint characterIndex)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			nuint ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend_UIntPtr (this.Handle, Selector.GetHandle ("glyphIndexForCharacterAtIndex:"), characterIndex);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.UIntPtr_objc_msgSendSuper_UIntPtr (&__objc_super__, Selector.GetHandle ("glyphIndexForCharacterAtIndex:"), characterIndex);
					GC.KeepAlive (this);
				}
			}
			return ret;
		}
		/// <summary>The glyph index for the glyph at <paramref name="point" />, in the <paramref name="container" /> object's coordinate system.</summary><param name="point">To be added.</param><param name="container">To be added.</param><param name="fractionOfDistanceThroughGlyph">To be added.</param><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("glyphIndexForPoint:inTextContainer:fractionOfDistanceThroughGlyph:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual nuint GetGlyphIndex (CGPoint point, NSTextContainer container, out nfloat fractionOfDistanceThroughGlyph)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var container__handle__ = container!.GetNonNullHandle (nameof (container));
			fixed (nfloat* fractionOfDistanceThroughGlyph__pointer = &fractionOfDistanceThroughGlyph) {
			fractionOfDistanceThroughGlyph = default;
			nuint ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend_CGPoint_NativeHandle_out_NFloat (this.Handle, Selector.GetHandle ("glyphIndexForPoint:inTextContainer:fractionOfDistanceThroughGlyph:"), point, container__handle__, fractionOfDistanceThroughGlyph__pointer);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.UIntPtr_objc_msgSendSuper_CGPoint_NativeHandle_out_NFloat (&__objc_super__, Selector.GetHandle ("glyphIndexForPoint:inTextContainer:fractionOfDistanceThroughGlyph:"), point, container__handle__, fractionOfDistanceThroughGlyph__pointer);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (container);
			return ret!;
			}
		}
		/// <summary>Developers should call <see cref="M:UIKit.NSLayoutManager.GetGlyphIndex(CoreGraphics.CGPoint,UIKit.NSTextContainer,System.Runtime.InteropServices.NFloat@)" /> rather than this primitive method.</summary><param name="point">To be added.</param><param name="container">To be added.</param><returns>To be added.</returns><remarks><para>This method is public for overriding purposes. Developers should call <see cref="M:UIKit.NSLayoutManager.GetGlyphIndex(CoreGraphics.CGPoint,UIKit.NSTextContainer,System.Runtime.InteropServices.NFloat@)" />  rather than this primitive method.</para></remarks>
		[Export ("glyphIndexForPoint:inTextContainer:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual nuint GetGlyphIndex (CGPoint point, NSTextContainer container)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var container__handle__ = container!.GetNonNullHandle (nameof (container));
			nuint ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend_CGPoint_NativeHandle (this.Handle, Selector.GetHandle ("glyphIndexForPoint:inTextContainer:"), point, container__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.UIntPtr_objc_msgSendSuper_CGPoint_NativeHandle (&__objc_super__, Selector.GetHandle ("glyphIndexForPoint:inTextContainer:"), point, container__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (container);
			return ret!;
		}
		/// <param name="characterRange">To be added.</param><param name="actualCharacterRange">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("glyphRangeForCharacterRange:actualCharacterRange:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		protected virtual NSRange GetGlyphRange (NSRange characterRange, nint actualCharacterRange)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			NSRange ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.NSRange_objc_msgSend_NSRange_IntPtr (this.Handle, Selector.GetHandle ("glyphRangeForCharacterRange:actualCharacterRange:"), characterRange, actualCharacterRange);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.NSRange_objc_msgSendSuper_NSRange_IntPtr (&__objc_super__, Selector.GetHandle ("glyphRangeForCharacterRange:actualCharacterRange:"), characterRange, actualCharacterRange);
					GC.KeepAlive (this);
				}
			}
			return ret;
		}
		/// <param name="characterRange">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public NSRange GetGlyphRange (NSRange characterRange)
		{
			return GetGlyphRange (characterRange, IntPtr.Zero);
		}
		/// <param name="characterRange">To be added.</param><param name="actualCharacterRange">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe NSRange GetGlyphRange (NSRange characterRange, out NSRange actualCharacterRange)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			fixed (NSRange* actualCharacterRange__pointer = &actualCharacterRange) {
			actualCharacterRange = default;
			NSRange ret;
			ret = global::ObjCRuntime.Messaging.NSRange_objc_msgSend_NSRange_out_NSRange (this.Handle, Selector.GetHandle ("glyphRangeForCharacterRange:actualCharacterRange:"), characterRange, actualCharacterRange__pointer);
			return ret;
			}
		}
		/// <summary>The range of glyph indices contained in the specified <see cref="T:UIKit.NSTextContainer" />.</summary><param name="container">To be added.</param><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("glyphRangeForTextContainer:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSRange GetGlyphRange (NSTextContainer container)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var container__handle__ = container!.GetNonNullHandle (nameof (container));
			NSRange ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.NSRange_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("glyphRangeForTextContainer:"), container__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.NSRange_objc_msgSendSuper_NativeHandle (&__objc_super__, Selector.GetHandle ("glyphRangeForTextContainer:"), container__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (container);
			return ret!;
		}
		/// <param name="bounds">To be added.</param><param name="container">To be added.</param><summary>Returns the range of glyph indices that are at least partially in the <paramref name="bounds" />.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("glyphRangeForBoundingRect:inTextContainer:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSRange GetGlyphRangeForBoundingRect (CGRect bounds, NSTextContainer container)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var container__handle__ = container!.GetNonNullHandle (nameof (container));
			NSRange ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.NSRange_objc_msgSend_CGRect_NativeHandle (this.Handle, Selector.GetHandle ("glyphRangeForBoundingRect:inTextContainer:"), bounds, container__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.NSRange_objc_msgSendSuper_CGRect_NativeHandle (&__objc_super__, Selector.GetHandle ("glyphRangeForBoundingRect:inTextContainer:"), bounds, container__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (container);
			return ret!;
		}
		/// <param name="bounds">To be added.</param><param name="container">To be added.</param><summary>Returns the range of glyph indices that are at least partially in the <paramref name="bounds" /> without glyph production or layout.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("glyphRangeForBoundingRectWithoutAdditionalLayout:inTextContainer:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSRange GetGlyphRangeForBoundingRectWithoutAdditionalLayout (CGRect bounds, NSTextContainer container)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var container__handle__ = container!.GetNonNullHandle (nameof (container));
			NSRange ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.NSRange_objc_msgSend_CGRect_NativeHandle (this.Handle, Selector.GetHandle ("glyphRangeForBoundingRectWithoutAdditionalLayout:inTextContainer:"), bounds, container__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.NSRange_objc_msgSendSuper_CGRect_NativeHandle (&__objc_super__, Selector.GetHandle ("glyphRangeForBoundingRectWithoutAdditionalLayout:inTextContainer:"), bounds, container__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (container);
			return ret!;
		}
		/// <param name="glyphRange">To be added.</param><param name="glyphBuffer">To be added.</param><param name="properties">To be added.</param><param name="characterIndexBuffer">To be added.</param><param name="bidiLevelBuffer">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("getGlyphsInRange:glyphs:properties:characterIndexes:bidiLevels:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		protected virtual nuint GetGlyphs (NSRange glyphRange, nint glyphBuffer, nint properties, nint characterIndexBuffer, nint bidiLevelBuffer)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			nuint ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend_NSRange_IntPtr_IntPtr_IntPtr_IntPtr (this.Handle, Selector.GetHandle ("getGlyphsInRange:glyphs:properties:characterIndexes:bidiLevels:"), glyphRange, glyphBuffer, properties, characterIndexBuffer, bidiLevelBuffer);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.UIntPtr_objc_msgSendSuper_NSRange_IntPtr_IntPtr_IntPtr_IntPtr (&__objc_super__, Selector.GetHandle ("getGlyphsInRange:glyphs:properties:characterIndexes:bidiLevels:"), glyphRange, glyphBuffer, properties, characterIndexBuffer, bidiLevelBuffer);
					GC.KeepAlive (this);
				}
			}
			return ret;
		}
		[Export ("getLineFragmentInsertionPointsForCharacterAtIndex:alternatePositions:inDisplayOrder:positions:characterIndexes:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		protected virtual nuint GetLineFragmentInsertionPoints (nuint characterIndex, bool alternatePositions, bool inDisplayOrder, nint positions, nint characterIndexes)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			nuint ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend_UIntPtr_bool_bool_IntPtr_IntPtr (this.Handle, Selector.GetHandle ("getLineFragmentInsertionPointsForCharacterAtIndex:alternatePositions:inDisplayOrder:positions:characterIndexes:"), characterIndex, alternatePositions ? (byte) 1 : (byte) 0, inDisplayOrder ? (byte) 1 : (byte) 0, positions, characterIndexes);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.UIntPtr_objc_msgSendSuper_UIntPtr_bool_bool_IntPtr_IntPtr (&__objc_super__, Selector.GetHandle ("getLineFragmentInsertionPointsForCharacterAtIndex:alternatePositions:inDisplayOrder:positions:characterIndexes:"), characterIndex, alternatePositions ? (byte) 1 : (byte) 0, inDisplayOrder ? (byte) 1 : (byte) 0, positions, characterIndexes);
					GC.KeepAlive (this);
				}
			}
			return ret;
		}
		[Export ("lineFragmentRectForGlyphAtIndex:effectiveRange:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		protected virtual CGRect GetLineFragmentRect (nuint glyphIndex, nint effectiveGlyphRange)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			CGRect ret;
			if (IsDirectBinding) {
				if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
					ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSend_UIntPtr_IntPtr (this.Handle, Selector.GetHandle ("lineFragmentRectForGlyphAtIndex:effectiveRange:"), glyphIndex, effectiveGlyphRange);
				} else {
					ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSend_stret_UIntPtr_IntPtr (this.Handle, Selector.GetHandle ("lineFragmentRectForGlyphAtIndex:effectiveRange:"), glyphIndex, effectiveGlyphRange);
				}
			} else {
				if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSendSuper_UIntPtr_IntPtr (&__objc_super__, Selector.GetHandle ("lineFragmentRectForGlyphAtIndex:effectiveRange:"), glyphIndex, effectiveGlyphRange);
						GC.KeepAlive (this);
					}
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSendSuper_stret_UIntPtr_IntPtr (&__objc_super__, Selector.GetHandle ("lineFragmentRectForGlyphAtIndex:effectiveRange:"), glyphIndex, effectiveGlyphRange);
						GC.KeepAlive (this);
					}
				}
			}
			return ret!;
		}
		/// <param name="glyphIndex">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public CGRect GetLineFragmentRect (nuint glyphIndex)
		{
			return GetLineFragmentRect (glyphIndex, IntPtr.Zero);
		}
		/// <param name="glyphIndex">To be added.</param><param name="effectiveGlyphRange">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe CGRect GetLineFragmentRect (nuint glyphIndex, out NSRange effectiveGlyphRange)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			fixed (NSRange* effectiveGlyphRange__pointer = &effectiveGlyphRange) {
			effectiveGlyphRange = default;
			CGRect ret;
			if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
				ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSend_UIntPtr_out_NSRange (this.Handle, Selector.GetHandle ("lineFragmentRectForGlyphAtIndex:effectiveRange:"), glyphIndex, effectiveGlyphRange__pointer);
			} else {
				ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSend_stret_UIntPtr_out_NSRange (this.Handle, Selector.GetHandle ("lineFragmentRectForGlyphAtIndex:effectiveRange:"), glyphIndex, effectiveGlyphRange__pointer);
			}
			return ret!;
			}
		}
		[Export ("lineFragmentRectForGlyphAtIndex:effectiveRange:withoutAdditionalLayout:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		protected virtual CGRect GetLineFragmentRect (nuint glyphIndex, nint effectiveGlyphRange, bool withoutAdditionalLayout)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			CGRect ret;
			if (IsDirectBinding) {
				if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
					ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSend_UIntPtr_IntPtr_bool (this.Handle, Selector.GetHandle ("lineFragmentRectForGlyphAtIndex:effectiveRange:withoutAdditionalLayout:"), glyphIndex, effectiveGlyphRange, withoutAdditionalLayout ? (byte) 1 : (byte) 0);
				} else {
					ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSend_stret_UIntPtr_IntPtr_bool (this.Handle, Selector.GetHandle ("lineFragmentRectForGlyphAtIndex:effectiveRange:withoutAdditionalLayout:"), glyphIndex, effectiveGlyphRange, withoutAdditionalLayout ? (byte) 1 : (byte) 0);
				}
			} else {
				if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSendSuper_UIntPtr_IntPtr_bool (&__objc_super__, Selector.GetHandle ("lineFragmentRectForGlyphAtIndex:effectiveRange:withoutAdditionalLayout:"), glyphIndex, effectiveGlyphRange, withoutAdditionalLayout ? (byte) 1 : (byte) 0);
						GC.KeepAlive (this);
					}
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSendSuper_stret_UIntPtr_IntPtr_bool (&__objc_super__, Selector.GetHandle ("lineFragmentRectForGlyphAtIndex:effectiveRange:withoutAdditionalLayout:"), glyphIndex, effectiveGlyphRange, withoutAdditionalLayout ? (byte) 1 : (byte) 0);
						GC.KeepAlive (this);
					}
				}
			}
			return ret!;
		}
		/// <param name="glyphIndex">To be added.</param><param name="withoutAdditionalLayout">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public CGRect GetLineFragmentRect (nuint glyphIndex, bool withoutAdditionalLayout)
		{
			return GetLineFragmentRect (glyphIndex, IntPtr.Zero);
		}
		/// <param name="glyphIndex">The index of the glyph for which the rect is requested.</param><param name="effectiveGlyphRange">If not <see langword="null" />, the range of all glyphs in the line fragment.</param><param name="withoutAdditionalLayout">If <see langword="true" />, glyph generation and layout are not performed.</param><summary>Gets the line fragment <see cref="T:CoreGraphics.CGRect" /> containing the glyph at <paramref name="glyphIndex" />, with the option of not triggering layout.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe CGRect GetLineFragmentRect (nuint glyphIndex, out NSRange effectiveGlyphRange, bool withoutAdditionalLayout)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			fixed (NSRange* effectiveGlyphRange__pointer = &effectiveGlyphRange) {
			effectiveGlyphRange = default;
			CGRect ret;
			if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
				ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSend_UIntPtr_out_NSRange_bool (this.Handle, Selector.GetHandle ("lineFragmentRectForGlyphAtIndex:effectiveRange:withoutAdditionalLayout:"), glyphIndex, effectiveGlyphRange__pointer, withoutAdditionalLayout ? (byte) 1 : (byte) 0);
			} else {
				ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSend_stret_UIntPtr_out_NSRange_bool (this.Handle, Selector.GetHandle ("lineFragmentRectForGlyphAtIndex:effectiveRange:withoutAdditionalLayout:"), glyphIndex, effectiveGlyphRange__pointer, withoutAdditionalLayout ? (byte) 1 : (byte) 0);
			}
			return ret!;
			}
		}
		[Export ("lineFragmentUsedRectForGlyphAtIndex:effectiveRange:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		protected virtual CGRect GetLineFragmentUsedRect (nuint glyphIndex, nint effectiveGlyphRange)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			CGRect ret;
			if (IsDirectBinding) {
				if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
					ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSend_UIntPtr_IntPtr (this.Handle, Selector.GetHandle ("lineFragmentUsedRectForGlyphAtIndex:effectiveRange:"), glyphIndex, effectiveGlyphRange);
				} else {
					ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSend_stret_UIntPtr_IntPtr (this.Handle, Selector.GetHandle ("lineFragmentUsedRectForGlyphAtIndex:effectiveRange:"), glyphIndex, effectiveGlyphRange);
				}
			} else {
				if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSendSuper_UIntPtr_IntPtr (&__objc_super__, Selector.GetHandle ("lineFragmentUsedRectForGlyphAtIndex:effectiveRange:"), glyphIndex, effectiveGlyphRange);
						GC.KeepAlive (this);
					}
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSendSuper_stret_UIntPtr_IntPtr (&__objc_super__, Selector.GetHandle ("lineFragmentUsedRectForGlyphAtIndex:effectiveRange:"), glyphIndex, effectiveGlyphRange);
						GC.KeepAlive (this);
					}
				}
			}
			return ret!;
		}
		/// <param name="glyphIndex">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public CGRect GetLineFragmentUsedRect (nuint glyphIndex)
		{
			return GetLineFragmentUsedRect (glyphIndex, IntPtr.Zero);
		}
		/// <param name="glyphIndex">To be added.</param><param name="effectiveGlyphRange">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe CGRect GetLineFragmentUsedRect (nuint glyphIndex, out NSRange effectiveGlyphRange)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			fixed (NSRange* effectiveGlyphRange__pointer = &effectiveGlyphRange) {
			effectiveGlyphRange = default;
			CGRect ret;
			if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
				ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSend_UIntPtr_out_NSRange (this.Handle, Selector.GetHandle ("lineFragmentUsedRectForGlyphAtIndex:effectiveRange:"), glyphIndex, effectiveGlyphRange__pointer);
			} else {
				ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSend_stret_UIntPtr_out_NSRange (this.Handle, Selector.GetHandle ("lineFragmentUsedRectForGlyphAtIndex:effectiveRange:"), glyphIndex, effectiveGlyphRange__pointer);
			}
			return ret!;
			}
		}
		[Export ("lineFragmentUsedRectForGlyphAtIndex:effectiveRange:withoutAdditionalLayout:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		protected virtual CGRect GetLineFragmentUsedRect (nuint glyphIndex, nint effectiveGlyphRange, bool withoutAdditionalLayout)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			CGRect ret;
			if (IsDirectBinding) {
				if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
					ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSend_UIntPtr_IntPtr_bool (this.Handle, Selector.GetHandle ("lineFragmentUsedRectForGlyphAtIndex:effectiveRange:withoutAdditionalLayout:"), glyphIndex, effectiveGlyphRange, withoutAdditionalLayout ? (byte) 1 : (byte) 0);
				} else {
					ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSend_stret_UIntPtr_IntPtr_bool (this.Handle, Selector.GetHandle ("lineFragmentUsedRectForGlyphAtIndex:effectiveRange:withoutAdditionalLayout:"), glyphIndex, effectiveGlyphRange, withoutAdditionalLayout ? (byte) 1 : (byte) 0);
				}
			} else {
				if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSendSuper_UIntPtr_IntPtr_bool (&__objc_super__, Selector.GetHandle ("lineFragmentUsedRectForGlyphAtIndex:effectiveRange:withoutAdditionalLayout:"), glyphIndex, effectiveGlyphRange, withoutAdditionalLayout ? (byte) 1 : (byte) 0);
						GC.KeepAlive (this);
					}
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSendSuper_stret_UIntPtr_IntPtr_bool (&__objc_super__, Selector.GetHandle ("lineFragmentUsedRectForGlyphAtIndex:effectiveRange:withoutAdditionalLayout:"), glyphIndex, effectiveGlyphRange, withoutAdditionalLayout ? (byte) 1 : (byte) 0);
						GC.KeepAlive (this);
					}
				}
			}
			return ret!;
		}
		/// <param name="glyphIndex">To be added.</param><param name="withoutAdditionalLayout">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public CGRect GetLineFragmentUsedRect (nuint glyphIndex, bool withoutAdditionalLayout)
		{
			return GetLineFragmentUsedRect (glyphIndex, IntPtr.Zero);
		}
		/// <param name="glyphIndex">The index of the glyph for which the rect is requested.</param><param name="effectiveGlyphRange">If not <see langword="null" />, the range of all glyphs in the line fragment.</param><param name="withoutAdditionalLayout">If <see langword="true" />, glyph generation and layout are not performed.</param><summary>Gets the usage <see cref="T:CoreGraphics.CGRect" /> containing the glyph at <paramref name="glyphIndex" />, with the option of not triggering layout.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe CGRect GetLineFragmentUsedRect (nuint glyphIndex, out NSRange effectiveGlyphRange, bool withoutAdditionalLayout)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			fixed (NSRange* effectiveGlyphRange__pointer = &effectiveGlyphRange) {
			effectiveGlyphRange = default;
			CGRect ret;
			if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
				ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSend_UIntPtr_out_NSRange_bool (this.Handle, Selector.GetHandle ("lineFragmentUsedRectForGlyphAtIndex:effectiveRange:withoutAdditionalLayout:"), glyphIndex, effectiveGlyphRange__pointer, withoutAdditionalLayout ? (byte) 1 : (byte) 0);
			} else {
				ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSend_stret_UIntPtr_out_NSRange_bool (this.Handle, Selector.GetHandle ("lineFragmentUsedRectForGlyphAtIndex:effectiveRange:withoutAdditionalLayout:"), glyphIndex, effectiveGlyphRange__pointer, withoutAdditionalLayout ? (byte) 1 : (byte) 0);
			}
			return ret!;
			}
		}
		/// <param name="glyphIndex">To be added.</param><summary>The location of the glyph at the specified index, relative to the containing line fragment's origin.</summary><returns>To be added.</returns><remarks><para>This method will layout and generate glyphs for the line fragment containing the glyph at <paramref name="glyphIndex" />.</para></remarks>
		[Export ("locationForGlyphAtIndex:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual CGPoint GetLocationForGlyph (nuint glyphIndex)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			CGPoint ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.CGPoint_objc_msgSend_UIntPtr (this.Handle, Selector.GetHandle ("locationForGlyphAtIndex:"), glyphIndex);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.CGPoint_objc_msgSendSuper_UIntPtr (&__objc_super__, Selector.GetHandle ("locationForGlyphAtIndex:"), glyphIndex);
					GC.KeepAlive (this);
				}
			}
			return ret;
		}
		/// <param name="glyphIndex">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("propertyForGlyphAtIndex:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSGlyphProperty GetProperty (nuint glyphIndex)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			NSGlyphProperty ret;
			if (IsDirectBinding) {
				ret = (NSGlyphProperty) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSend_UIntPtr (this.Handle, Selector.GetHandle ("propertyForGlyphAtIndex:"), glyphIndex);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = (NSGlyphProperty) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper_UIntPtr (&__objc_super__, Selector.GetHandle ("propertyForGlyphAtIndex:"), glyphIndex);
					GC.KeepAlive (this);
				}
			}
			return ret!;
		}
		/// <param name="glyphIndex">To be added.</param><summary>The largest range of glyphs surrounding the glyph at the specified index that can be displayed using only advancement, not pairwise kerning or other adjustments.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("rangeOfNominallySpacedGlyphsContainingIndex:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSRange GetRangeOfNominallySpacedGlyphsContainingIndex (nuint glyphIndex)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			NSRange ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.NSRange_objc_msgSend_UIntPtr (this.Handle, Selector.GetHandle ("rangeOfNominallySpacedGlyphsContainingIndex:"), glyphIndex);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.NSRange_objc_msgSendSuper_UIntPtr (&__objc_super__, Selector.GetHandle ("rangeOfNominallySpacedGlyphsContainingIndex:"), glyphIndex);
					GC.KeepAlive (this);
				}
			}
			return ret;
		}
		[Export ("textContainerForGlyphAtIndex:effectiveRange:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		protected virtual NSTextContainer? GetTextContainer (nuint glyphIndex, nint effectiveGlyphRange)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			NSTextContainer ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<NSTextContainer> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_UIntPtr_IntPtr (this.Handle, Selector.GetHandle ("textContainerForGlyphAtIndex:effectiveRange:"), glyphIndex, effectiveGlyphRange), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<NSTextContainer> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_UIntPtr_IntPtr (&__objc_super__, Selector.GetHandle ("textContainerForGlyphAtIndex:effectiveRange:"), glyphIndex, effectiveGlyphRange), false)!;
					GC.KeepAlive (this);
				}
			}
			return ret;
		}
		/// <param name="glyphIndex">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public NSTextContainer? GetTextContainer (nuint glyphIndex)
		{
			return GetTextContainer (glyphIndex, IntPtr.Zero);
		}
		/// <param name="glyphIndex">To be added.</param><param name="effectiveGlyphRange">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe NSTextContainer? GetTextContainer (nuint glyphIndex, out NSRange effectiveGlyphRange)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			fixed (NSRange* effectiveGlyphRange__pointer = &effectiveGlyphRange) {
			effectiveGlyphRange = default;
			NSTextContainer ret;
			ret =  Runtime.GetNSObject<NSTextContainer> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_UIntPtr_out_NSRange (this.Handle, Selector.GetHandle ("textContainerForGlyphAtIndex:effectiveRange:"), glyphIndex, effectiveGlyphRange__pointer), false)!;
			return ret;
			}
		}
		[Export ("textContainerForGlyphAtIndex:effectiveRange:withoutAdditionalLayout:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		protected virtual NSTextContainer? GetTextContainer (nuint glyphIndex, nint effectiveGlyphRange, bool withoutAdditionalLayout)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			NSTextContainer ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<NSTextContainer> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_UIntPtr_IntPtr_bool (this.Handle, Selector.GetHandle ("textContainerForGlyphAtIndex:effectiveRange:withoutAdditionalLayout:"), glyphIndex, effectiveGlyphRange, withoutAdditionalLayout ? (byte) 1 : (byte) 0), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<NSTextContainer> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_UIntPtr_IntPtr_bool (&__objc_super__, Selector.GetHandle ("textContainerForGlyphAtIndex:effectiveRange:withoutAdditionalLayout:"), glyphIndex, effectiveGlyphRange, withoutAdditionalLayout ? (byte) 1 : (byte) 0), false)!;
					GC.KeepAlive (this);
				}
			}
			return ret;
		}
		/// <param name="glyphIndex">To be added.</param><param name="flag">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public NSTextContainer? GetTextContainer (nuint glyphIndex, bool flag)
		{
			return GetTextContainer (glyphIndex, IntPtr.Zero, flag);
		}
		/// <summary>Gets the <see cref="T:UIKit.NSTextContainer" /> containing the glyph at <paramref name="glyphIndex" />, with the option of not triggering layout.</summary><param name="glyphIndex">The index of the glyph for which the rect is requested.</param><param name="effectiveGlyphRange">If not <see langword="null" />, the range of all glyphs in the line fragment.</param><param name="withoutAdditionalLayout">If <see langword="true" />, glyph generation and layout are not performed.</param><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe NSTextContainer? GetTextContainer (nuint glyphIndex, out NSRange effectiveGlyphRange, bool withoutAdditionalLayout)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			fixed (NSRange* effectiveGlyphRange__pointer = &effectiveGlyphRange) {
			effectiveGlyphRange = default;
			NSTextContainer ret;
			ret =  Runtime.GetNSObject<NSTextContainer> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_UIntPtr_out_NSRange_bool (this.Handle, Selector.GetHandle ("textContainerForGlyphAtIndex:effectiveRange:withoutAdditionalLayout:"), glyphIndex, effectiveGlyphRange__pointer, withoutAdditionalLayout ? (byte) 1 : (byte) 0), false)!;
			return ret;
			}
		}
		/// <param name="glyphIndex">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("truncatedGlyphRangeInLineFragmentForGlyphAtIndex:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSRange GetTruncatedGlyphRangeInLineFragment (nuint glyphIndex)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			NSRange ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.NSRange_objc_msgSend_UIntPtr (this.Handle, Selector.GetHandle ("truncatedGlyphRangeInLineFragmentForGlyphAtIndex:"), glyphIndex);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.NSRange_objc_msgSendSuper_UIntPtr (&__objc_super__, Selector.GetHandle ("truncatedGlyphRangeInLineFragmentForGlyphAtIndex:"), glyphIndex);
					GC.KeepAlive (this);
				}
			}
			return ret;
		}
		/// <summary>The bounding rectangle in the <see cref="T:UIKit.NSTextContainer" />'s coordinates of the laid out glyphs in the <see cref="T:UIKit.NSTextContainer" />.</summary><param name="container">To be added.</param><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("usedRectForTextContainer:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual CGRect GetUsedRect (NSTextContainer container)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var container__handle__ = container!.GetNonNullHandle (nameof (container));
			CGRect ret;
			if (IsDirectBinding) {
				if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
					ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("usedRectForTextContainer:"), container__handle__);
				} else {
					ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSend_stret_NativeHandle (this.Handle, Selector.GetHandle ("usedRectForTextContainer:"), container__handle__);
				}
			} else {
				if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSendSuper_NativeHandle (&__objc_super__, Selector.GetHandle ("usedRectForTextContainer:"), container__handle__);
						GC.KeepAlive (this);
					}
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSendSuper_stret_NativeHandle (&__objc_super__, Selector.GetHandle ("usedRectForTextContainer:"), container__handle__);
						GC.KeepAlive (this);
					}
				}
			}
			GC.KeepAlive (container);
			return ret!;
		}
		/// <summary>Developers should use <see cref="M:UIKit.NSLayoutManager.GetGlyph(System.UIntPtr,System.Boolean@)" /> rather than this deprecated method.</summary><param name="glyphIndex">To be added.</param><param name="isValidIndex">To be added.</param><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("glyphAtIndex:isValidIndex:")]
		[ObsoletedOSPlatform ("ios9.0", "Use 'GetGlyph' instead.")]
		[ObsoletedOSPlatform ("tvos9.0", "Use 'GetGlyph' instead.")]
		[ObsoletedOSPlatform ("maccatalyst13.1", "Use 'GetGlyph' instead.")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual ushort GlyphAtIndex (nuint glyphIndex, ref bool isValidIndex)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			fixed (bool* isValidIndex__pointer = &isValidIndex) {
			ushort ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.UInt16_objc_msgSend_UIntPtr_ref_Boolean (this.Handle, Selector.GetHandle ("glyphAtIndex:isValidIndex:"), glyphIndex, (byte*) isValidIndex__pointer);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.UInt16_objc_msgSendSuper_UIntPtr_ref_Boolean (&__objc_super__, Selector.GetHandle ("glyphAtIndex:isValidIndex:"), glyphIndex, (byte*) isValidIndex__pointer);
					GC.KeepAlive (this);
				}
			}
			return ret;
			}
		}
		/// <summary>Developers should not use this deprecated method. Developers should use <see cref="M:UIKit.NSLayoutManager.GetGlyph(System.UIntPtr,System.Boolean@)" /> instead.</summary><param name="glyphIndex">To be added.</param><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("glyphAtIndex:")]
		[ObsoletedOSPlatform ("ios9.0", "Use 'GetGlyph' instead.")]
		[ObsoletedOSPlatform ("tvos9.0", "Use 'GetGlyph' instead.")]
		[ObsoletedOSPlatform ("maccatalyst13.1", "Use 'GetGlyph' instead.")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual ushort GlyphAtIndex (nuint glyphIndex)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			ushort ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.UInt16_objc_msgSend_UIntPtr (this.Handle, Selector.GetHandle ("glyphAtIndex:"), glyphIndex);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.UInt16_objc_msgSendSuper_UIntPtr (&__objc_super__, Selector.GetHandle ("glyphAtIndex:"), glyphIndex);
					GC.KeepAlive (this);
				}
			}
			return ret;
		}
		/// <summary>Inserts the specified <see cref="T:UIKit.NSTextContainer" /> into <see cref="P:UIKit.NSLayoutManager.TextContainers" /> at the specified <paramref name="index" />.</summary><param name="container">To be added.</param><param name="index">To be added.</param><altmember cref="M:UIKit.NSLayoutManager.AddTextContainer(UIKit.NSTextContainer)" />
		[Export ("insertTextContainer:atIndex:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void InsertTextContainer (NSTextContainer container, nint index)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var container__handle__ = container!.GetNonNullHandle (nameof (container));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_IntPtr (this.Handle, Selector.GetHandle ("insertTextContainer:atIndex:"), container__handle__, index);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_IntPtr (&__objc_super__, Selector.GetHandle ("insertTextContainer:atIndex:"), container__handle__, index);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (container);
		}
		/// <summary>Invalidates the display for the given character range.</summary><param name="characterRange">To be added.</param><remarks><para>This method does not automatically trigger layout.</para></remarks>
		[Export ("invalidateDisplayForCharacterRange:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void InvalidateDisplayForCharacterRange (NSRange characterRange)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NSRange (this.Handle, Selector.GetHandle ("invalidateDisplayForCharacterRange:"), characterRange);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NSRange (&__objc_super__, Selector.GetHandle ("invalidateDisplayForCharacterRange:"), characterRange);
					GC.KeepAlive (this);
				}
			}
		}
		/// <summary>Invalidates the display for the given glyph range.</summary><param name="glyphRange">To be added.</param><remarks><para>This method does not automatically trigger layout.</para></remarks>
		[Export ("invalidateDisplayForGlyphRange:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void InvalidateDisplayForGlyphRange (NSRange glyphRange)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NSRange (this.Handle, Selector.GetHandle ("invalidateDisplayForGlyphRange:"), glyphRange);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NSRange (&__objc_super__, Selector.GetHandle ("invalidateDisplayForGlyphRange:"), glyphRange);
					GC.KeepAlive (this);
				}
			}
		}
		[Export ("invalidateGlyphsForCharacterRange:changeInLength:actualCharacterRange:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		protected virtual void InvalidateGlyphs (NSRange characterRange, nint delta, nint actualCharacterRange)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NSRange_IntPtr_IntPtr (this.Handle, Selector.GetHandle ("invalidateGlyphsForCharacterRange:changeInLength:actualCharacterRange:"), characterRange, delta, actualCharacterRange);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NSRange_IntPtr_IntPtr (&__objc_super__, Selector.GetHandle ("invalidateGlyphsForCharacterRange:changeInLength:actualCharacterRange:"), characterRange, delta, actualCharacterRange);
					GC.KeepAlive (this);
				}
			}
		}
		/// <param name="characterRange">To be added.</param><param name="delta">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void InvalidateGlyphs (NSRange characterRange, nint delta)
		{
			InvalidateGlyphs (characterRange, delta, IntPtr.Zero);
		}
		/// <summary>Invalidates the glyphs in the <paramref name="characterRange" />.</summary><param name="characterRange">To be added.</param><param name="delta">To be added.</param><param name="actualCharacterRange">To be added.</param><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe void InvalidateGlyphs (NSRange characterRange, nint delta, out NSRange actualCharacterRange)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			fixed (NSRange* actualCharacterRange__pointer = &actualCharacterRange) {
			actualCharacterRange = default;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NSRange_IntPtr_out_NSRange (this.Handle, Selector.GetHandle ("invalidateGlyphsForCharacterRange:changeInLength:actualCharacterRange:"), characterRange, delta, actualCharacterRange__pointer);
			}
		}
		[Export ("invalidateLayoutForCharacterRange:actualCharacterRange:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		protected virtual void InvalidateLayout (NSRange characterRange, nint actualCharacterRange)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NSRange_IntPtr (this.Handle, Selector.GetHandle ("invalidateLayoutForCharacterRange:actualCharacterRange:"), characterRange, actualCharacterRange);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NSRange_IntPtr (&__objc_super__, Selector.GetHandle ("invalidateLayoutForCharacterRange:actualCharacterRange:"), characterRange, actualCharacterRange);
					GC.KeepAlive (this);
				}
			}
		}
		/// <param name="characterRange">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void InvalidateLayout (NSRange characterRange)
		{
			InvalidateLayout (characterRange, IntPtr.Zero);
		}
		/// <summary>Invalidates the layout for the specified character range. Does not automatically trigger re-layout.</summary><param name="actualCharacterRange">If not <see langword="null" />, on output holds the actual range invalidated.</param><remarks><para>This method does not trigger either glyph generation or layout. Application developers will not normally need to call this method.</para></remarks><param name="characterRange">To be added.</param>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe void InvalidateLayout (NSRange characterRange, out NSRange actualCharacterRange)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			fixed (NSRange* actualCharacterRange__pointer = &actualCharacterRange) {
			actualCharacterRange = default;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NSRange_out_NSRange (this.Handle, Selector.GetHandle ("invalidateLayoutForCharacterRange:actualCharacterRange:"), characterRange, actualCharacterRange__pointer);
			}
		}
		/// <summary>Whether the glyph at the specified index is shown.</summary><param name="glyphIndex">To be added.</param><returns>To be added.</returns><remarks><para>Glyphs such as tabs and newlines are not typically shown, but effect layout. Spaces are considered shown, as they "show" a characteristic displacement.</para><para>This method will cause layout up to the specified index. If <see cref="P:UIKit.NSLayoutManager.AllowsNonContiguousLayout" /> is <see langword="true" />, the layout will be confined to the containing line fragment.</para></remarks>
		[Export ("notShownAttributeForGlyphAtIndex:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool IsNotShownAttributeForGlyph (nuint glyphIndex)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			byte ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_UIntPtr (this.Handle, Selector.GetHandle ("notShownAttributeForGlyphAtIndex:"), glyphIndex);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper_UIntPtr (&__objc_super__, Selector.GetHandle ("notShownAttributeForGlyphAtIndex:"), glyphIndex);
					GC.KeepAlive (this);
				}
			}
			return ret != 0;
		}
		/// <summary>Whether the <paramref name="glyphIndex" /> specifies a valid glyph.</summary><param name="glyphIndex">To be added.</param><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("isValidGlyphIndex:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool IsValidGlyph (nuint glyphIndex)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			byte ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_UIntPtr (this.Handle, Selector.GetHandle ("isValidGlyphIndex:"), glyphIndex);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper_UIntPtr (&__objc_super__, Selector.GetHandle ("isValidGlyphIndex:"), glyphIndex);
					GC.KeepAlive (this);
				}
			}
			return ret != 0;
		}
		/// <param name="textStorage">To be added.</param><param name="editMask">To be added.</param><param name="newCharacterRange">To be added.</param><param name="delta">To be added.</param><param name="invalidatedCharacterRange">To be added.</param><summary>Notifies the <see cref="T:UIKit.NSLayoutManager" /> of an edit action.</summary><remarks>To be added.</remarks>
		[Export ("processEditingForTextStorage:edited:range:changeInLength:invalidatedRange:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void ProcessEditing (NSTextStorage textStorage, NSTextStorageEditActions editMask, NSRange newCharacterRange, nint delta, NSRange invalidatedCharacterRange)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var textStorage__handle__ = textStorage!.GetNonNullHandle (nameof (textStorage));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_UIntPtr_NSRange_IntPtr_NSRange (this.Handle, Selector.GetHandle ("processEditingForTextStorage:edited:range:changeInLength:invalidatedRange:"), textStorage__handle__, (UIntPtr) (ulong) editMask, newCharacterRange, delta, invalidatedCharacterRange);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_UIntPtr_NSRange_IntPtr_NSRange (&__objc_super__, Selector.GetHandle ("processEditingForTextStorage:edited:range:changeInLength:invalidatedRange:"), textStorage__handle__, (UIntPtr) (ulong) editMask, newCharacterRange, delta, invalidatedCharacterRange);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (textStorage);
		}
		/// <summary>Removes the specified <see cref="T:UIKit.NSTextContainer" /> from the <see cref="P:UIKit.NSLayoutManager.TextContainers" /> array. Invalidates layout as necessary.</summary><param name="index">To be added.</param><remarks>To be added.</remarks>
		[Export ("removeTextContainerAtIndex:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void RemoveTextContainer (nint index)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("removeTextContainerAtIndex:"), index);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (&__objc_super__, Selector.GetHandle ("removeTextContainerAtIndex:"), index);
					GC.KeepAlive (this);
				}
			}
		}
		/// <summary>Sets the size for the glyph to draw within the <paramref name="glyphRange" />.</summary><param name="attachmentSize">To be added.</param><param name="glyphRange">To be added.</param><remarks>To be added.</remarks>
		[Export ("setAttachmentSize:forGlyphRange:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetAttachmentSize (CGSize attachmentSize, NSRange glyphRange)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_CGSize_NSRange (this.Handle, Selector.GetHandle ("setAttachmentSize:forGlyphRange:"), attachmentSize, glyphRange);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_CGSize_NSRange (&__objc_super__, Selector.GetHandle ("setAttachmentSize:forGlyphRange:"), attachmentSize, glyphRange);
					GC.KeepAlive (this);
				}
			}
		}
		/// <summary>Specifies whether the glyph at the specified index draws outside the bounds of its line segment.</summary><param name="flag">To be added.</param><param name="glyphIndex">To be added.</param><remarks><para>This method is generally only called by custom typesetters.</para></remarks>
		[Export ("setDrawsOutsideLineFragment:forGlyphAtIndex:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetDrawsOutsideLineFragment (bool flag, nuint glyphIndex)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_bool_UIntPtr (this.Handle, Selector.GetHandle ("setDrawsOutsideLineFragment:forGlyphAtIndex:"), flag ? (byte) 1 : (byte) 0, glyphIndex);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_bool_UIntPtr (&__objc_super__, Selector.GetHandle ("setDrawsOutsideLineFragment:forGlyphAtIndex:"), flag ? (byte) 1 : (byte) 0, glyphIndex);
					GC.KeepAlive (this);
				}
			}
		}
		/// <summary>Sets the details for the extra line fragment required when the text back is either totally empty or ends with a hard line break.</summary><param name="fragmentRect">To be added.</param><param name="usedRect">To be added.</param><param name="container">To be added.</param><remarks><para>Developers should only call this method when implementing custom typesetting.</para></remarks>
		[Export ("setExtraLineFragmentRect:usedRect:textContainer:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetExtraLineFragment (CGRect fragmentRect, CGRect usedRect, NSTextContainer container)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var container__handle__ = container!.GetNonNullHandle (nameof (container));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_CGRect_CGRect_NativeHandle (this.Handle, Selector.GetHandle ("setExtraLineFragmentRect:usedRect:textContainer:"), fragmentRect, usedRect, container__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_CGRect_CGRect_NativeHandle (&__objc_super__, Selector.GetHandle ("setExtraLineFragmentRect:usedRect:textContainer:"), fragmentRect, usedRect, container__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (container);
		}
		/// <param name="glyphs">To be added.</param><param name="properties">To be added.</param><param name="characterIndexes">To be added.</param><param name="font">To be added.</param><param name="glyphRange">To be added.</param><summary>Specifies the initial glyphs and glyph properties for the specified character range.</summary><remarks>To be added.</remarks>
		[Export ("setGlyphs:properties:characterIndexes:font:forGlyphRange:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetGlyphs (nint glyphs, nint properties, nint characterIndexes, UIFont font, NSRange glyphRange)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var font__handle__ = font!.GetNonNullHandle (nameof (font));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr_NativeHandle_NSRange (this.Handle, Selector.GetHandle ("setGlyphs:properties:characterIndexes:font:forGlyphRange:"), glyphs, properties, characterIndexes, font__handle__, glyphRange);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr_IntPtr_IntPtr_NativeHandle_NSRange (&__objc_super__, Selector.GetHandle ("setGlyphs:properties:characterIndexes:font:forGlyphRange:"), glyphs, properties, characterIndexes, font__handle__, glyphRange);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (font);
		}
		/// <summary>Associated the line fragment with bounds <paramref name="fragmentRect" /> with the glyphs in <paramref name="glyphRange" />.</summary><param name="fragmentRect">To be added.</param><param name="glyphRange">To be added.</param><param name="usedRect">To be added.</param><remarks>To be added.</remarks>
		[Export ("setLineFragmentRect:forGlyphRange:usedRect:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetLineFragment (CGRect fragmentRect, NSRange glyphRange, CGRect usedRect)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_CGRect_NSRange_CGRect (this.Handle, Selector.GetHandle ("setLineFragmentRect:forGlyphRange:usedRect:"), fragmentRect, glyphRange, usedRect);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_CGRect_NSRange_CGRect (&__objc_super__, Selector.GetHandle ("setLineFragmentRect:forGlyphRange:usedRect:"), fragmentRect, glyphRange, usedRect);
					GC.KeepAlive (this);
				}
			}
		}
		/// <summary>Sets the <paramref name="location" /> for the first glyph in <paramref name="forStartOfGlyphRange" />.</summary><param name="location">To be added.</param><param name="forStartOfGlyphRange">To be added.</param><remarks>To be added.</remarks>
		[Export ("setLocation:forStartOfGlyphRange:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetLocation (CGPoint location, NSRange forStartOfGlyphRange)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_CGPoint_NSRange (this.Handle, Selector.GetHandle ("setLocation:forStartOfGlyphRange:"), location, forStartOfGlyphRange);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_CGPoint_NSRange (&__objc_super__, Selector.GetHandle ("setLocation:forStartOfGlyphRange:"), location, forStartOfGlyphRange);
					GC.KeepAlive (this);
				}
			}
		}
		/// <summary>Specifies that the glyph at the specified index should be marked as not shown.</summary><param name="flag">To be added.</param><param name="glyphIndex">To be added.</param><remarks><para>This method is generally only called by custom typesetters.</para></remarks>
		[Export ("setNotShownAttribute:forGlyphAtIndex:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetNotShownAttribute (bool flag, nuint glyphIndex)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_bool_UIntPtr (this.Handle, Selector.GetHandle ("setNotShownAttribute:forGlyphAtIndex:"), flag ? (byte) 1 : (byte) 0, glyphIndex);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_bool_UIntPtr (&__objc_super__, Selector.GetHandle ("setNotShownAttribute:forGlyphAtIndex:"), flag ? (byte) 1 : (byte) 0, glyphIndex);
					GC.KeepAlive (this);
				}
			}
		}
		/// <summary>Sets the NSTextContainer for the specified glyph range.</summary><param name="container">To be added.</param><param name="glyphRange">To be added.</param><remarks>To be added.</remarks>
		[Export ("setTextContainer:forGlyphRange:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetTextContainer (NSTextContainer container, NSRange glyphRange)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var container__handle__ = container!.GetNonNullHandle (nameof (container));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NSRange (this.Handle, Selector.GetHandle ("setTextContainer:forGlyphRange:"), container__handle__, glyphRange);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_NSRange (&__objc_super__, Selector.GetHandle ("setTextContainer:forGlyphRange:"), container__handle__, glyphRange);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (container);
		}
		[Export ("showCGGlyphs:positions:count:font:matrix:attributes:inContext:")]
		[ObsoletedOSPlatform ("ios13.0", "Use the overload that takes 'nint glyphCount' instead.")]
		[ObsoletedOSPlatform ("tvos13.0", "Use the overload that takes 'nint glyphCount' instead.")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[ObsoletedOSPlatform ("maccatalyst13.1", "Use the overload that takes 'nint glyphCount' instead.")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		protected virtual void ShowGlyphs (nint glyphs, nint positions, nuint glyphCount, UIFont font, CGAffineTransform textMatrix, NSDictionary attributes, CGContext graphicsContext)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var font__handle__ = font!.GetNonNullHandle (nameof (font));
			var attributes__handle__ = attributes!.GetNonNullHandle (nameof (attributes));
			var graphicsContext__handle__ = graphicsContext!.GetNonNullHandle (nameof (graphicsContext));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr_IntPtr_UIntPtr_NativeHandle_CGAffineTransform_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("showCGGlyphs:positions:count:font:matrix:attributes:inContext:"), glyphs, positions, glyphCount, font__handle__, textMatrix, attributes__handle__, graphicsContext.Handle);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr_IntPtr_UIntPtr_NativeHandle_CGAffineTransform_NativeHandle_NativeHandle (&__objc_super__, Selector.GetHandle ("showCGGlyphs:positions:count:font:matrix:attributes:inContext:"), glyphs, positions, glyphCount, font__handle__, textMatrix, attributes__handle__, graphicsContext.Handle);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (font);
			GC.KeepAlive (attributes);
			GC.KeepAlive (graphicsContext);
		}
		[Export ("showCGGlyphs:positions:count:font:textMatrix:attributes:inContext:")]
		[SupportedOSPlatform ("tvos13.0")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		protected virtual void ShowGlyphs (nint glyphs, nint positions, nint glyphCount, UIFont font, CGAffineTransform textMatrix, NSDictionary attributes, CGContext graphicsContext)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var font__handle__ = font!.GetNonNullHandle (nameof (font));
			var attributes__handle__ = attributes!.GetNonNullHandle (nameof (attributes));
			var graphicsContext__handle__ = graphicsContext!.GetNonNullHandle (nameof (graphicsContext));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr_NativeHandle_CGAffineTransform_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("showCGGlyphs:positions:count:font:textMatrix:attributes:inContext:"), glyphs, positions, glyphCount, font__handle__, textMatrix, attributes__handle__, graphicsContext.Handle);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr_IntPtr_IntPtr_NativeHandle_CGAffineTransform_NativeHandle_NativeHandle (&__objc_super__, Selector.GetHandle ("showCGGlyphs:positions:count:font:textMatrix:attributes:inContext:"), glyphs, positions, glyphCount, font__handle__, textMatrix, attributes__handle__, graphicsContext.Handle);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (font);
			GC.KeepAlive (attributes);
			GC.KeepAlive (graphicsContext);
		}
		/// <summary>Draws a strikethrough through the glyphs at <paramref name="glyphRange" />.</summary><param name="glyphRange">To be added.</param><param name="strikethroughVal">To be added.</param><param name="lineRect">To be added.</param><param name="lineGlyphRange">To be added.</param><param name="containerOrigin">To be added.</param><remarks>To be added.</remarks>
		[Export ("strikethroughGlyphRange:strikethroughType:lineFragmentRect:lineFragmentGlyphRange:containerOrigin:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void Strikethrough (NSRange glyphRange, NSUnderlineStyle strikethroughVal, CGRect lineRect, NSRange lineGlyphRange, CGPoint containerOrigin)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NSRange_IntPtr_CGRect_NSRange_CGPoint (this.Handle, Selector.GetHandle ("strikethroughGlyphRange:strikethroughType:lineFragmentRect:lineFragmentGlyphRange:containerOrigin:"), glyphRange, (IntPtr) (long) strikethroughVal, lineRect, lineGlyphRange, containerOrigin);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NSRange_IntPtr_CGRect_NSRange_CGPoint (&__objc_super__, Selector.GetHandle ("strikethroughGlyphRange:strikethroughType:lineFragmentRect:lineFragmentGlyphRange:containerOrigin:"), glyphRange, (IntPtr) (long) strikethroughVal, lineRect, lineGlyphRange, containerOrigin);
					GC.KeepAlive (this);
				}
			}
		}
		/// <summary>Invalidates the layout information and glyphs for the specified <see cref="T:UIKit.NSTextContainer" /> and any following.</summary><param name="container">To be added.</param><remarks><para>Application developers will typically not need to call this method unless they have subclassed <see cref="T:UIKit.NSTextContainer" /> (for example, creating a <see cref="T:UIKit.NSTextContainer" /> subclass that changes shape to accommodate placed graphics).</para></remarks>
		[Export ("textContainerChangedGeometry:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void TextContainerChangedGeometry (NSTextContainer container)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var container__handle__ = container!.GetNonNullHandle (nameof (container));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("textContainerChangedGeometry:"), container__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, Selector.GetHandle ("textContainerChangedGeometry:"), container__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (container);
		}
		/// <summary>Underlines the glyphs in <paramref name="glyphRange" />.</summary><param name="glyphRange">To be added.</param><param name="underlineVal">To be added.</param><param name="lineRect">To be added.</param><param name="lineGlyphRange">To be added.</param><param name="containerOrigin">To be added.</param><remarks>To be added.</remarks>
		[Export ("underlineGlyphRange:underlineType:lineFragmentRect:lineFragmentGlyphRange:containerOrigin:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void Underline (NSRange glyphRange, NSUnderlineStyle underlineVal, CGRect lineRect, NSRange lineGlyphRange, CGPoint containerOrigin)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NSRange_IntPtr_CGRect_NSRange_CGPoint (this.Handle, Selector.GetHandle ("underlineGlyphRange:underlineType:lineFragmentRect:lineFragmentGlyphRange:containerOrigin:"), glyphRange, (IntPtr) (long) underlineVal, lineRect, lineGlyphRange, containerOrigin);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NSRange_IntPtr_CGRect_NSRange_CGPoint (&__objc_super__, Selector.GetHandle ("underlineGlyphRange:underlineType:lineFragmentRect:lineFragmentGlyphRange:containerOrigin:"), glyphRange, (IntPtr) (long) underlineVal, lineRect, lineGlyphRange, containerOrigin);
					GC.KeepAlive (this);
				}
			}
		}
		/// <summary>Whether layout can be done for a portion of the document without laying-out being recalculated from the beginning.</summary><value>The default value is <see langword="false" />.</value><remarks><para>Setting this value to <see langword="true" /> allows the <see cref="T:UIKit.NSLayoutManager" /> to perform noncontiguous layout. In large documents, this can significantly increase performance, since the layout does not need to performed from the beginning of the document.</para><para>Application developers can use the <c>EnsureLayout...</c> methods with noncontiguous methods to confirm that particular portions of the text are being laid out properly.</para><para>The <see cref="T:UIKit.NSLayoutManager" /> is instantiated with its <see cref="P:UIKit.NSLayoutManager.AllowsNonContiguousLayout" /> property set to <see langword="true" />.</para></remarks><altmember cref="P:UIKit.NSLayoutManager.HasNonContiguousLayout" /><altmember cref="M:UIKit.NSLayoutManager.EnsureGlyphsForCharacterRange(Foundation.NSRange)" /><altmember cref="M:UIKit.NSLayoutManager.EnsureGlyphsForGlyphRange(Foundation.NSRange)" /><altmember cref="M:UIKit.NSLayoutManager.EnsureLayoutForCharacterRange(Foundation.NSRange)" /><altmember cref="M:UIKit.NSLayoutManager.EnsureLayoutForGlyphRange(Foundation.NSRange)" /><altmember cref="M:UIKit.NSLayoutManager.EnsureLayoutForTextContainer(UIKit.NSTextContainer)" /><altmember cref="M:UIKit.NSLayoutManager.EnsureLayoutForBoundingRect(CoreGraphics.CGRect,UIKit.NSTextContainer)" />
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool AllowsNonContiguousLayout {
			[Export ("allowsNonContiguousLayout")]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("allowsNonContiguousLayout"));
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("allowsNonContiguousLayout"));
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
			[Export ("setAllowsNonContiguousLayout:")]
			set {
				global::UIKit.UIApplication.EnsureUIThread ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("setAllowsNonContiguousLayout:"), value ? (byte) 1 : (byte) 0);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (&__objc_super__, Selector.GetHandle ("setAllowsNonContiguousLayout:"), value ? (byte) 1 : (byte) 0);
						GC.KeepAlive (this);
					}
				}
			}
		}
		/// <summary>An instance of the UIKit.INSLayoutManagerDelegate model class which acts as the class delegate.</summary><value>The instance of the UIKit.INSLayoutManagerDelegate model class</value><remarks><para>The delegate instance assigned to this object will be used to handle events or provide data on demand to this class.</para><para>When setting the Delegate or WeakDelegate values events will be delivered to the specified instance instead of being delivered to the C#-style events</para><para>This is the strongly typed version of the object, developers should use the WeakDelegate property instead if they want to merely assign a class derived from NSObject that has been decorated with [Export] attributes.</para></remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public INSLayoutManagerDelegate Delegate {
			get {
				return (WeakDelegate as INSLayoutManagerDelegate)!;
			}
			set {
				var rvalue = value as NSObject;
				if (!(value is null) && rvalue is null)
					throw new ArgumentException ("The object passed of type " + value.GetType () + " does not derive from NSObject");
				WeakDelegate = rvalue;
			}
		}
		/// <summary>The <see cref="T:CoreGraphics.CGRect" /> needed for the insertion point.</summary><value>Returns the rectangle defining the extra line fragment for the insertion point or {0,0,0,0} if there is no such retangle.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual CGRect ExtraLineFragmentRect {
			[Export ("extraLineFragmentRect")]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				CGRect ret;
				if (IsDirectBinding) {
					if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
						ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSend (this.Handle, Selector.GetHandle ("extraLineFragmentRect"));
					} else {
						ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSend_stret (this.Handle, Selector.GetHandle ("extraLineFragmentRect"));
					}
				} else {
					if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
						unsafe {
							var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
							ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("extraLineFragmentRect"));
							GC.KeepAlive (this);
						}
					} else {
						unsafe {
							var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
							ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSendSuper_stret (&__objc_super__, Selector.GetHandle ("extraLineFragmentRect"));
							GC.KeepAlive (this);
						}
					}
				}
				return ret!;
			}
		}
		/// <summary>The <see cref="T:UIKit.NSTextContainer" /> containing the <see cref="P:UIKit.NSLayoutManager.ExtraLineFragmentRect" />.</summary><value>Returns <see langword="null" /> if the <see cref="P:UIKit.NSLayoutManager.ExtraLineFragmentRect" /> does not exist (is {0,0,0,0}).</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSTextContainer ExtraLineFragmentTextContainer {
			[Export ("extraLineFragmentTextContainer")]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				NSTextContainer? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSTextContainer> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("extraLineFragmentTextContainer")), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<NSTextContainer> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("extraLineFragmentTextContainer")), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		/// <summary>The rectangle enclosing the insertion point.</summary><value>Twice the <see cref="P:UIKit.NSTextContainer.LineFragmentPadding" />, with the insertion point in the middle.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual CGRect ExtraLineFragmentUsedRect {
			[Export ("extraLineFragmentUsedRect")]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				CGRect ret;
				if (IsDirectBinding) {
					if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
						ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSend (this.Handle, Selector.GetHandle ("extraLineFragmentUsedRect"));
					} else {
						ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSend_stret (this.Handle, Selector.GetHandle ("extraLineFragmentUsedRect"));
					}
				} else {
					if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
						unsafe {
							var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
							ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("extraLineFragmentUsedRect"));
							GC.KeepAlive (this);
						}
					} else {
						unsafe {
							var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
							ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSendSuper_stret (&__objc_super__, Selector.GetHandle ("extraLineFragmentUsedRect"));
							GC.KeepAlive (this);
						}
					}
				}
				return ret!;
			}
		}
		/// <summary>The index of the first character that has not been laid out.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual nuint FirstUnlaidCharacterIndex {
			[Export ("firstUnlaidCharacterIndex")]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				nuint ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("firstUnlaidCharacterIndex"));
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.UIntPtr_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("firstUnlaidCharacterIndex"));
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
		/// <summary>The index of the first glyph that has not been laid out.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual nuint FirstUnlaidGlyphIndex {
			[Export ("firstUnlaidGlyphIndex")]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				nuint ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("firstUnlaidGlyphIndex"));
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.UIntPtr_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("firstUnlaidGlyphIndex"));
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
		/// <summary>Whether the <see cref="T:UIKit.NSLayoutManager" /> currently contains any areas of noncontiguous layout.</summary><remarks><para>Even if <see cref="P:UIKit.NSLayoutManager.AllowsNonContiguousLayout" /> is <see langword="true" />, this method may return <see langword="false" />, for instance, if layout is complete.</para></remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool HasNonContiguousLayout {
			[Export ("hasNonContiguousLayout")]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("hasNonContiguousLayout"));
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("hasNonContiguousLayout"));
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
		}
		/// <summary>The hyphenation threshold.</summary><value>A value in the range 0 to 1. 0 indicates hyphenation is off, 1.0 causes hyphenation to always be attempted.</value><remarks><para>Application developers should prefer to set this value to 0.0, because hyphenation is slow and consumes memory.</para></remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[ObsoletedOSPlatform ("ios13.0", "Please use 'UsesDefaultHyphenation' or 'NSParagraphStyle.HyphenationFactor' instead.")]
		[ObsoletedOSPlatform ("tvos13.0", "Please use 'UsesDefaultHyphenation' or 'NSParagraphStyle.HyphenationFactor' instead.")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[ObsoletedOSPlatform ("maccatalyst13.1", "Please use 'UsesDefaultHyphenation' or 'NSParagraphStyle.HyphenationFactor' instead.")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("macos")]
		public virtual nfloat HyphenationFactor {
			[Export ("hyphenationFactor")]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				nfloat ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.nfloat_objc_msgSend (this.Handle, Selector.GetHandle ("hyphenationFactor"));
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.nfloat_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("hyphenationFactor"));
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[Export ("setHyphenationFactor:")]
			set {
				global::UIKit.UIApplication.EnsureUIThread ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_nfloat (this.Handle, Selector.GetHandle ("setHyphenationFactor:"), value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_nfloat (&__objc_super__, Selector.GetHandle ("setHyphenationFactor:"), value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		public virtual bool LimitsLayoutForSuspiciousContents {
			[Export ("limitsLayoutForSuspiciousContents")]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("limitsLayoutForSuspiciousContents"));
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("limitsLayoutForSuspiciousContents"));
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
			[Export ("setLimitsLayoutForSuspiciousContents:")]
			set {
				global::UIKit.UIApplication.EnsureUIThread ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("setLimitsLayoutForSuspiciousContents:"), value ? (byte) 1 : (byte) 0);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (&__objc_super__, Selector.GetHandle ("setLimitsLayoutForSuspiciousContents:"), value ? (byte) 1 : (byte) 0);
						GC.KeepAlive (this);
					}
				}
			}
		}
		/// <summary>The number of glyphs in the <see cref="T:UIKit.NSLayoutManager" />.</summary><value>To be added.</value><remarks><para>If <see cref="P:UIKit.NSLayoutManager.AllowsNonContiguousLayout" /> is <see langword="false" />, this method will force glyph generation for all characters.</para></remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual nuint NumberOfGlyphs {
			[Export ("numberOfGlyphs")]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				nuint ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("numberOfGlyphs"));
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.UIntPtr_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("numberOfGlyphs"));
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
		/// <summary>Specifies whether control characters should be shown or not.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool ShowsControlCharacters {
			[Export ("showsControlCharacters")]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("showsControlCharacters"));
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("showsControlCharacters"));
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
			[Export ("setShowsControlCharacters:")]
			set {
				global::UIKit.UIApplication.EnsureUIThread ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("setShowsControlCharacters:"), value ? (byte) 1 : (byte) 0);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (&__objc_super__, Selector.GetHandle ("setShowsControlCharacters:"), value ? (byte) 1 : (byte) 0);
						GC.KeepAlive (this);
					}
				}
			}
		}
		/// <summary>Specifies whether normally-invisible characters such as whitespace should have visible glyphs.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool ShowsInvisibleCharacters {
			[Export ("showsInvisibleCharacters")]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("showsInvisibleCharacters"));
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("showsInvisibleCharacters"));
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
			[Export ("setShowsInvisibleCharacters:")]
			set {
				global::UIKit.UIApplication.EnsureUIThread ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("setShowsInvisibleCharacters:"), value ? (byte) 1 : (byte) 0);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (&__objc_super__, Selector.GetHandle ("setShowsInvisibleCharacters:"), value ? (byte) 1 : (byte) 0);
						GC.KeepAlive (this);
					}
				}
			}
		}
		/// <summary>An array of <see cref="T:UIKit.NSTextContainer" />s that model the geometric layout of a document.</summary><remarks><para>The <see cref="T:UIKit.NSLayoutManager" /> lays out the text in its <see cref="P:UIKit.NSLayoutManager.TextStorage" /> property in the <see cref="T:UIKit.NSTextContainer" />s of this property, starting with the <see cref="T:UIKit.NSTextContainer" /> at index 0. </para></remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSTextContainer[] TextContainers {
			[Export ("textContainers")]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				NSTextContainer[]? ret;
				if (IsDirectBinding) {
					ret = CFArray.ArrayFromHandle<NSTextContainer>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("textContainers")), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFArray.ArrayFromHandle<NSTextContainer>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("textContainers")), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		object? __mt_TextStorage_var;
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSTextStorage? TextStorage {
			[Export ("textStorage", ArgumentSemantic.Assign)]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				NSTextStorage? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSTextStorage> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("textStorage")), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<NSTextStorage> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("textStorage")), false)!;
						GC.KeepAlive (this);
					}
				}
				MarkDirty ();
				__mt_TextStorage_var = ret;
				return ret!;
			}
			[Export ("setTextStorage:", ArgumentSemantic.Assign)]
			set {
				global::UIKit.UIApplication.EnsureUIThread ();
				var value__handle__ = value.GetHandle ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("setTextStorage:"), value__handle__);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, Selector.GetHandle ("setTextStorage:"), value__handle__);
						GC.KeepAlive (this);
					}
				}
				GC.KeepAlive (value);
				MarkDirty ();
				__mt_TextStorage_var = value;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("tvos13.0")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		public virtual bool UsesDefaultHyphenation {
			[Export ("usesDefaultHyphenation")]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("usesDefaultHyphenation"));
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("usesDefaultHyphenation"));
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
			[Export ("setUsesDefaultHyphenation:")]
			set {
				global::UIKit.UIApplication.EnsureUIThread ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("setUsesDefaultHyphenation:"), value ? (byte) 1 : (byte) 0);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (&__objc_super__, Selector.GetHandle ("setUsesDefaultHyphenation:"), value ? (byte) 1 : (byte) 0);
						GC.KeepAlive (this);
					}
				}
			}
		}
		/// <summary>Whether the <see cref="T:UIKit.NSLayoutManager" /> should use the leading provided in the font.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool UsesFontLeading {
			[Export ("usesFontLeading")]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("usesFontLeading"));
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("usesFontLeading"));
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
			[Export ("setUsesFontLeading:")]
			set {
				global::UIKit.UIApplication.EnsureUIThread ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("setUsesFontLeading:"), value ? (byte) 1 : (byte) 0);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (&__objc_super__, Selector.GetHandle ("setUsesFontLeading:"), value ? (byte) 1 : (byte) 0);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		object? __mt_WeakDelegate_var;
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSObject? WeakDelegate {
			[Export ("delegate", ArgumentSemantic.Assign)]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				NSObject? ret;
				if (IsDirectBinding) {
					ret = Runtime.GetNSObject (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("delegate")), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = Runtime.GetNSObject (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("delegate")), false)!;
						GC.KeepAlive (this);
					}
				}
				MarkDirty ();
				__mt_WeakDelegate_var = ret;
				return ret!;
			}
			[Export ("setDelegate:", ArgumentSemantic.Assign)]
			set {
				global::UIKit.UIApplication.EnsureUIThread ();
				var value__handle__ = value.GetHandle ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("setDelegate:"), value__handle__);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, Selector.GetHandle ("setDelegate:"), value__handle__);
						GC.KeepAlive (this);
					}
				}
				GC.KeepAlive (value);
				MarkDirty ();
				__mt_WeakDelegate_var = value;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		protected override void Dispose (bool disposing)
		{
			base.Dispose (disposing);
			if (Handle == IntPtr.Zero) {
				__mt_TextStorage_var = null;
				__mt_WeakDelegate_var = null;
			}
		}
	} /* class NSLayoutManager */
}
