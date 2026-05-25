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
	[Register("NSFont", true)]
	[UnsupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("macos")]
	public unsafe partial class NSFont : NSObject, INSCoding, INSCopying, INSSecureCoding {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAdvancementForCGGlyph_X = "advancementForCGGlyph:";
		static readonly NativeHandle selAdvancementForCGGlyph_XHandle = Selector.GetHandle ("advancementForCGGlyph:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAdvancementForGlyph_X = "advancementForGlyph:";
		static readonly NativeHandle selAdvancementForGlyph_XHandle = Selector.GetHandle ("advancementForGlyph:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAscenderX = "ascender";
		static readonly NativeHandle selAscenderXHandle = Selector.GetHandle ("ascender");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selBoldSystemFontOfSize_X = "boldSystemFontOfSize:";
		static readonly NativeHandle selBoldSystemFontOfSize_XHandle = Selector.GetHandle ("boldSystemFontOfSize:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selBoundingRectForCGGlyph_X = "boundingRectForCGGlyph:";
		static readonly NativeHandle selBoundingRectForCGGlyph_XHandle = Selector.GetHandle ("boundingRectForCGGlyph:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selBoundingRectForFontX = "boundingRectForFont";
		static readonly NativeHandle selBoundingRectForFontXHandle = Selector.GetHandle ("boundingRectForFont");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selBoundingRectForGlyph_X = "boundingRectForGlyph:";
		static readonly NativeHandle selBoundingRectForGlyph_XHandle = Selector.GetHandle ("boundingRectForGlyph:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selCapHeightX = "capHeight";
		static readonly NativeHandle selCapHeightXHandle = Selector.GetHandle ("capHeight");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selControlContentFontOfSize_X = "controlContentFontOfSize:";
		static readonly NativeHandle selControlContentFontOfSize_XHandle = Selector.GetHandle ("controlContentFontOfSize:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selCopyWithZone_X = "copyWithZone:";
		static readonly NativeHandle selCopyWithZone_XHandle = Selector.GetHandle ("copyWithZone:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selCoveredCharacterSetX = "coveredCharacterSet";
		static readonly NativeHandle selCoveredCharacterSetXHandle = Selector.GetHandle ("coveredCharacterSet");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selDescenderX = "descender";
		static readonly NativeHandle selDescenderXHandle = Selector.GetHandle ("descender");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selDisplayNameX = "displayName";
		static readonly NativeHandle selDisplayNameXHandle = Selector.GetHandle ("displayName");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selEncodeWithCoder_X = "encodeWithCoder:";
		static readonly NativeHandle selEncodeWithCoder_XHandle = Selector.GetHandle ("encodeWithCoder:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selFamilyNameX = "familyName";
		static readonly NativeHandle selFamilyNameXHandle = Selector.GetHandle ("familyName");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selFontDescriptorX = "fontDescriptor";
		static readonly NativeHandle selFontDescriptorXHandle = Selector.GetHandle ("fontDescriptor");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selFontNameX = "fontName";
		static readonly NativeHandle selFontNameXHandle = Selector.GetHandle ("fontName");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selFontWithDescriptor_Size_X = "fontWithDescriptor:size:";
		static readonly NativeHandle selFontWithDescriptor_Size_XHandle = Selector.GetHandle ("fontWithDescriptor:size:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selFontWithDescriptor_TextTransform_X = "fontWithDescriptor:textTransform:";
		static readonly NativeHandle selFontWithDescriptor_TextTransform_XHandle = Selector.GetHandle ("fontWithDescriptor:textTransform:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selFontWithName_Size_X = "fontWithName:size:";
		static readonly NativeHandle selFontWithName_Size_XHandle = Selector.GetHandle ("fontWithName:size:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selFontWithSize_X = "fontWithSize:";
		static readonly NativeHandle selFontWithSize_XHandle = Selector.GetHandle ("fontWithSize:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selGetAdvancements_ForCGGlyphs_Count_X = "getAdvancements:forCGGlyphs:count:";
		static readonly NativeHandle selGetAdvancements_ForCGGlyphs_Count_XHandle = Selector.GetHandle ("getAdvancements:forCGGlyphs:count:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selGetBoundingRects_ForCGGlyphs_Count_X = "getBoundingRects:forCGGlyphs:count:";
		static readonly NativeHandle selGetBoundingRects_ForCGGlyphs_Count_XHandle = Selector.GetHandle ("getBoundingRects:forCGGlyphs:count:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selGlyphWithName_X = "glyphWithName:";
		static readonly NativeHandle selGlyphWithName_XHandle = Selector.GetHandle ("glyphWithName:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selInitWithCoder_X = "initWithCoder:";
		static readonly NativeHandle selInitWithCoder_XHandle = Selector.GetHandle ("initWithCoder:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selIsFixedPitchX = "isFixedPitch";
		static readonly NativeHandle selIsFixedPitchXHandle = Selector.GetHandle ("isFixedPitch");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selIsVerticalX = "isVertical";
		static readonly NativeHandle selIsVerticalXHandle = Selector.GetHandle ("isVertical");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selItalicAngleX = "italicAngle";
		static readonly NativeHandle selItalicAngleXHandle = Selector.GetHandle ("italicAngle");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selLabelFontOfSize_X = "labelFontOfSize:";
		static readonly NativeHandle selLabelFontOfSize_XHandle = Selector.GetHandle ("labelFontOfSize:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selLabelFontSizeX = "labelFontSize";
		static readonly NativeHandle selLabelFontSizeXHandle = Selector.GetHandle ("labelFontSize");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selLeadingX = "leading";
		static readonly NativeHandle selLeadingXHandle = Selector.GetHandle ("leading");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selMaximumAdvancementX = "maximumAdvancement";
		static readonly NativeHandle selMaximumAdvancementXHandle = Selector.GetHandle ("maximumAdvancement");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selMenuBarFontOfSize_X = "menuBarFontOfSize:";
		static readonly NativeHandle selMenuBarFontOfSize_XHandle = Selector.GetHandle ("menuBarFontOfSize:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selMenuFontOfSize_X = "menuFontOfSize:";
		static readonly NativeHandle selMenuFontOfSize_XHandle = Selector.GetHandle ("menuFontOfSize:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selMessageFontOfSize_X = "messageFontOfSize:";
		static readonly NativeHandle selMessageFontOfSize_XHandle = Selector.GetHandle ("messageFontOfSize:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selMonospacedDigitSystemFontOfSize_Weight_X = "monospacedDigitSystemFontOfSize:weight:";
		static readonly NativeHandle selMonospacedDigitSystemFontOfSize_Weight_XHandle = Selector.GetHandle ("monospacedDigitSystemFontOfSize:weight:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selMonospacedSystemFontOfSize_Weight_X = "monospacedSystemFontOfSize:weight:";
		static readonly NativeHandle selMonospacedSystemFontOfSize_Weight_XHandle = Selector.GetHandle ("monospacedSystemFontOfSize:weight:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selMostCompatibleStringEncodingX = "mostCompatibleStringEncoding";
		static readonly NativeHandle selMostCompatibleStringEncodingXHandle = Selector.GetHandle ("mostCompatibleStringEncoding");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selNumberOfGlyphsX = "numberOfGlyphs";
		static readonly NativeHandle selNumberOfGlyphsXHandle = Selector.GetHandle ("numberOfGlyphs");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selPaletteFontOfSize_X = "paletteFontOfSize:";
		static readonly NativeHandle selPaletteFontOfSize_XHandle = Selector.GetHandle ("paletteFontOfSize:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selPointSizeX = "pointSize";
		static readonly NativeHandle selPointSizeXHandle = Selector.GetHandle ("pointSize");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selPreferredFontForTextStyle_Options_X = "preferredFontForTextStyle:options:";
		static readonly NativeHandle selPreferredFontForTextStyle_Options_XHandle = Selector.GetHandle ("preferredFontForTextStyle:options:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selPrinterFontX = "printerFont";
		static readonly NativeHandle selPrinterFontXHandle = Selector.GetHandle ("printerFont");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selRenderingModeX = "renderingMode";
		static readonly NativeHandle selRenderingModeXHandle = Selector.GetHandle ("renderingMode");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selScreenFontX = "screenFont";
		static readonly NativeHandle selScreenFontXHandle = Selector.GetHandle ("screenFont");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selScreenFontWithRenderingMode_X = "screenFontWithRenderingMode:";
		static readonly NativeHandle selScreenFontWithRenderingMode_XHandle = Selector.GetHandle ("screenFontWithRenderingMode:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetX = "set";
		static readonly NativeHandle selSetXHandle = Selector.GetHandle ("set");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetInContext_X = "setInContext:";
		static readonly NativeHandle selSetInContext_XHandle = Selector.GetHandle ("setInContext:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetUserFixedPitchFont_X = "setUserFixedPitchFont:";
		static readonly NativeHandle selSetUserFixedPitchFont_XHandle = Selector.GetHandle ("setUserFixedPitchFont:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetUserFont_X = "setUserFont:";
		static readonly NativeHandle selSetUserFont_XHandle = Selector.GetHandle ("setUserFont:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSmallSystemFontSizeX = "smallSystemFontSize";
		static readonly NativeHandle selSmallSystemFontSizeXHandle = Selector.GetHandle ("smallSystemFontSize");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSystemFontOfSize_X = "systemFontOfSize:";
		static readonly NativeHandle selSystemFontOfSize_XHandle = Selector.GetHandle ("systemFontOfSize:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSystemFontOfSize_Weight_X = "systemFontOfSize:weight:";
		static readonly NativeHandle selSystemFontOfSize_Weight_XHandle = Selector.GetHandle ("systemFontOfSize:weight:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSystemFontOfSize_Weight_Width_X = "systemFontOfSize:weight:width:";
		static readonly NativeHandle selSystemFontOfSize_Weight_Width_XHandle = Selector.GetHandle ("systemFontOfSize:weight:width:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSystemFontSizeX = "systemFontSize";
		static readonly NativeHandle selSystemFontSizeXHandle = Selector.GetHandle ("systemFontSize");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSystemFontSizeForControlSize_X = "systemFontSizeForControlSize:";
		static readonly NativeHandle selSystemFontSizeForControlSize_XHandle = Selector.GetHandle ("systemFontSizeForControlSize:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selTextTransformX = "textTransform";
		static readonly NativeHandle selTextTransformXHandle = Selector.GetHandle ("textTransform");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selTitleBarFontOfSize_X = "titleBarFontOfSize:";
		static readonly NativeHandle selTitleBarFontOfSize_XHandle = Selector.GetHandle ("titleBarFontOfSize:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selToolTipsFontOfSize_X = "toolTipsFontOfSize:";
		static readonly NativeHandle selToolTipsFontOfSize_XHandle = Selector.GetHandle ("toolTipsFontOfSize:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selUnderlinePositionX = "underlinePosition";
		static readonly NativeHandle selUnderlinePositionXHandle = Selector.GetHandle ("underlinePosition");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selUnderlineThicknessX = "underlineThickness";
		static readonly NativeHandle selUnderlineThicknessXHandle = Selector.GetHandle ("underlineThickness");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selUserFixedPitchFontOfSize_X = "userFixedPitchFontOfSize:";
		static readonly NativeHandle selUserFixedPitchFontOfSize_XHandle = Selector.GetHandle ("userFixedPitchFontOfSize:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selUserFontOfSize_X = "userFontOfSize:";
		static readonly NativeHandle selUserFontOfSize_XHandle = Selector.GetHandle ("userFontOfSize:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selVerticalFontX = "verticalFont";
		static readonly NativeHandle selVerticalFontXHandle = Selector.GetHandle ("verticalFont");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selXHeightX = "xHeight";
		static readonly NativeHandle selXHeightXHandle = Selector.GetHandle ("xHeight");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly NativeHandle class_ptr = Class.GetHandle ("NSFont");
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
		public NSFont (NSCoder coder) : base (NSObjectFlag.Empty)
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
		protected NSFont (NSObjectFlag t) : base (t)
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
		protected internal NSFont (NativeHandle handle) : base (handle)
		{
		}

		[Export ("advancementForGlyph:")]
		[ObsoletedOSPlatform ("macos10.13", "Use the 'CGGlyph' APIs instead.")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual CGSize AdvancementForGlyph (uint aGlyph)
		{
			CGSize ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.CGSize_objc_msgSend_UInt32 (this.Handle, selAdvancementForGlyph_XHandle, aGlyph);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.CGSize_objc_msgSendSuper_UInt32 (&__objc_super__, selAdvancementForGlyph_XHandle, aGlyph);
					GC.KeepAlive (this);
				}
			}
			return ret;
		}
		[Export ("boundingRectForGlyph:")]
		[ObsoletedOSPlatform ("macos10.13", "Use the 'CGGlyph' APIs instead.")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual CGRect BoundingRectForGlyph (uint aGlyph)
		{
			CGRect ret;
			if (IsDirectBinding) {
				if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
					ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSend_UInt32 (this.Handle, selBoundingRectForGlyph_XHandle, aGlyph);
				} else {
					ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSend_stret_UInt32 (this.Handle, selBoundingRectForGlyph_XHandle, aGlyph);
				}
			} else {
				if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSendSuper_UInt32 (&__objc_super__, selBoundingRectForGlyph_XHandle, aGlyph);
						GC.KeepAlive (this);
					}
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSendSuper_stret_UInt32 (&__objc_super__, selBoundingRectForGlyph_XHandle, aGlyph);
						GC.KeepAlive (this);
					}
				}
			}
			return ret!;
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
		[Export ("advancementForCGGlyph:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual CGSize GetAdvancement (ushort glyph)
		{
			CGSize ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.CGSize_objc_msgSend_UInt16 (this.Handle, selAdvancementForCGGlyph_XHandle, glyph);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.CGSize_objc_msgSendSuper_UInt16 (&__objc_super__, selAdvancementForCGGlyph_XHandle, glyph);
					GC.KeepAlive (this);
				}
			}
			return ret;
		}
		[Export ("boundingRectForCGGlyph:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual CGRect GetBoundingRect (ushort glyph)
		{
			CGRect ret;
			if (IsDirectBinding) {
				if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
					ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSend_UInt16 (this.Handle, selBoundingRectForCGGlyph_XHandle, glyph);
				} else {
					ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSend_stret_UInt16 (this.Handle, selBoundingRectForCGGlyph_XHandle, glyph);
				}
			} else {
				if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSendSuper_UInt16 (&__objc_super__, selBoundingRectForCGGlyph_XHandle, glyph);
						GC.KeepAlive (this);
					}
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSendSuper_stret_UInt16 (&__objc_super__, selBoundingRectForCGGlyph_XHandle, glyph);
						GC.KeepAlive (this);
					}
				}
			}
			return ret!;
		}
		[Export ("fontWithSize:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSFont GetFont (nfloat fontSize)
		{
			NSFont ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<NSFont> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_nfloat (this.Handle, selFontWithSize_XHandle, fontSize), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<NSFont> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_nfloat (&__objc_super__, selFontWithSize_XHandle, fontSize), false)!;
					GC.KeepAlive (this);
				}
			}
			return ret;
		}
		[Export ("preferredFontForTextStyle:options:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSFont GetPreferredFont (string textStyle, NSDictionary options)
		{
			if (textStyle is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (textStyle));
			var options__handle__ = options!.GetNonNullHandle (nameof (options));
			var nstextStyle = CFString.CreateNative (textStyle);
			NSFont? ret;
			ret =  Runtime.GetNSObject<NSFont> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (class_ptr, selPreferredFontForTextStyle_Options_XHandle, nstextStyle, options__handle__), false)!;
			GC.KeepAlive (options);
			CFString.ReleaseNative (nstextStyle);
			return ret!;
		}
		[Export ("glyphWithName:")]
		[ObsoletedOSPlatform ("macos10.13", "Use the 'CGGlyph' APIs instead.")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual uint GlyphWithName (string aName)
		{
			if (aName is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (aName));
			var nsaName = CFString.CreateNative (aName);
			uint ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.UInt32_objc_msgSend_NativeHandle (this.Handle, selGlyphWithName_XHandle, nsaName);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.UInt32_objc_msgSendSuper_NativeHandle (&__objc_super__, selGlyphWithName_XHandle, nsaName);
					GC.KeepAlive (this);
				}
			}
			CFString.ReleaseNative (nsaName);
			return ret!;
		}
		[Export ("set")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void Set ()
		{
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, selSetXHandle);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper (&__objc_super__, selSetXHandle);
					GC.KeepAlive (this);
				}
			}
		}
		[Export ("setInContext:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetInContext (NSGraphicsContext graphicsContext)
		{
			var graphicsContext__handle__ = graphicsContext!.GetNonNullHandle (nameof (graphicsContext));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selSetInContext_XHandle, graphicsContext__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selSetInContext_XHandle, graphicsContext__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (graphicsContext);
		}
		[Export ("setUserFixedPitchFont:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void SetUserFixedPitchFont (NSFont? aFont)
		{
			var aFont__handle__ = aFont.GetHandle ();
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (class_ptr, selSetUserFixedPitchFont_XHandle, aFont__handle__);
			GC.KeepAlive (aFont);
		}
		[Export ("setUserFont:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void SetUserFont (NSFont? aFont)
		{
			var aFont__handle__ = aFont.GetHandle ();
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (class_ptr, selSetUserFont_XHandle, aFont__handle__);
			GC.KeepAlive (aFont);
		}
		[Export ("systemFontSizeForControlSize:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static nfloat SystemFontSizeForControlSize (NSControlSize controlSize)
		{
			nfloat ret;
			ret = global::ObjCRuntime.Messaging.nfloat_objc_msgSend_UIntPtr (class_ptr, selSystemFontSizeForControlSize_XHandle, (UIntPtr) (ulong) controlSize);
			return ret;
		}
		[Export ("boldSystemFontOfSize:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static nint _BoldSystemFontOfSize (nfloat fontSize)
		{
			nint ret;
			ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSend_nfloat (class_ptr, selBoldSystemFontOfSize_XHandle, fontSize);
			return ret;
		}
		[Export ("controlContentFontOfSize:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static nint _ControlContentFontOfSize (nfloat fontSize)
		{
			nint ret;
			ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSend_nfloat (class_ptr, selControlContentFontOfSize_XHandle, fontSize);
			return ret;
		}
		[Export ("fontWithDescriptor:size:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static nint _FromDescription (NSFontDescriptor fontDescriptor, nfloat fontSize)
		{
			var fontDescriptor__handle__ = fontDescriptor!.GetNonNullHandle (nameof (fontDescriptor));
			nint ret;
			ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSend_NativeHandle_nfloat (class_ptr, selFontWithDescriptor_Size_XHandle, fontDescriptor__handle__, fontSize);
			GC.KeepAlive (fontDescriptor);
			return ret!;
		}
		[Export ("fontWithDescriptor:textTransform:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static nint _FromDescription (NSFontDescriptor fontDescriptor, NSAffineTransform? textTransform)
		{
			var fontDescriptor__handle__ = fontDescriptor!.GetNonNullHandle (nameof (fontDescriptor));
			var textTransform__handle__ = textTransform.GetHandle ();
			nint ret;
			ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSend_NativeHandle_NativeHandle (class_ptr, selFontWithDescriptor_TextTransform_XHandle, fontDescriptor__handle__, textTransform__handle__);
			GC.KeepAlive (fontDescriptor);
			GC.KeepAlive (textTransform);
			return ret!;
		}
		[Export ("fontWithName:size:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static nint _FromFontName (string fontName, nfloat fontSize)
		{
			if (fontName is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (fontName));
			var nsfontName = CFString.CreateNative (fontName);
			nint ret;
			ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSend_NativeHandle_nfloat (class_ptr, selFontWithName_Size_XHandle, nsfontName, fontSize);
			CFString.ReleaseNative (nsfontName);
			return ret!;
		}
		[Export ("getAdvancements:forCGGlyphs:count:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal virtual void _GetAdvancements (nint advancements, nint glyphs, nuint glyphCount)
		{
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr_IntPtr_UIntPtr (this.Handle, selGetAdvancements_ForCGGlyphs_Count_XHandle, advancements, glyphs, glyphCount);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr_IntPtr_UIntPtr (&__objc_super__, selGetAdvancements_ForCGGlyphs_Count_XHandle, advancements, glyphs, glyphCount);
					GC.KeepAlive (this);
				}
			}
		}
		[Export ("getBoundingRects:forCGGlyphs:count:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal virtual void _GetBoundingRects (nint bounds, nint glyphs, nuint glyphCount)
		{
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr_IntPtr_UIntPtr (this.Handle, selGetBoundingRects_ForCGGlyphs_Count_XHandle, bounds, glyphs, glyphCount);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr_IntPtr_UIntPtr (&__objc_super__, selGetBoundingRects_ForCGGlyphs_Count_XHandle, bounds, glyphs, glyphCount);
					GC.KeepAlive (this);
				}
			}
		}
		[Export ("verticalFont")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal virtual nint _GetVerticalFont ()
		{
			nint ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selVerticalFontXHandle);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (&__objc_super__, selVerticalFontXHandle);
					GC.KeepAlive (this);
				}
			}
			return ret;
		}
		[Export ("labelFontOfSize:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static nint _LabelFontOfSize (nfloat fontSize)
		{
			nint ret;
			ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSend_nfloat (class_ptr, selLabelFontOfSize_XHandle, fontSize);
			return ret;
		}
		[Export ("menuBarFontOfSize:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static nint _MenuBarFontOfSize (nfloat fontSize)
		{
			nint ret;
			ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSend_nfloat (class_ptr, selMenuBarFontOfSize_XHandle, fontSize);
			return ret;
		}
		[Export ("menuFontOfSize:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static nint _MenuFontOfSize (nfloat fontSize)
		{
			nint ret;
			ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSend_nfloat (class_ptr, selMenuFontOfSize_XHandle, fontSize);
			return ret;
		}
		[Export ("messageFontOfSize:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static nint _MessageFontOfSize (nfloat fontSize)
		{
			nint ret;
			ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSend_nfloat (class_ptr, selMessageFontOfSize_XHandle, fontSize);
			return ret;
		}
		[Export ("monospacedDigitSystemFontOfSize:weight:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static nint _MonospacedDigitSystemFontOfSize (nfloat fontSize, nfloat weight)
		{
			nint ret;
			ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSend_nfloat_nfloat (class_ptr, selMonospacedDigitSystemFontOfSize_Weight_XHandle, fontSize, weight);
			return ret;
		}
		[Export ("monospacedSystemFontOfSize:weight:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static nint _MonospacedSystemFont (nfloat fontSize, nfloat weight)
		{
			nint ret;
			ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSend_nfloat_nfloat (class_ptr, selMonospacedSystemFontOfSize_Weight_XHandle, fontSize, weight);
			return ret;
		}
		[Export ("paletteFontOfSize:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static nint _PaletteFontOfSize (nfloat fontSize)
		{
			nint ret;
			ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSend_nfloat (class_ptr, selPaletteFontOfSize_XHandle, fontSize);
			return ret;
		}
		[Export ("screenFontWithRenderingMode:")]
		[ObsoletedOSPlatform ("macos10.13")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal virtual nint _ScreenFontWithRenderingMode (NSFontRenderingMode renderingMode)
		{
			nint ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSend_UIntPtr (this.Handle, selScreenFontWithRenderingMode_XHandle, (UIntPtr) (ulong) renderingMode);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper_UIntPtr (&__objc_super__, selScreenFontWithRenderingMode_XHandle, (UIntPtr) (ulong) renderingMode);
					GC.KeepAlive (this);
				}
			}
			return ret;
		}
		[Export ("systemFontOfSize:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static nint _SystemFontOfSize (nfloat fontSize)
		{
			nint ret;
			ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSend_nfloat (class_ptr, selSystemFontOfSize_XHandle, fontSize);
			return ret;
		}
		[Export ("systemFontOfSize:weight:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static nint _SystemFontOfSize (nfloat fontSize, nfloat weight)
		{
			nint ret;
			ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSend_nfloat_nfloat (class_ptr, selSystemFontOfSize_Weight_XHandle, fontSize, weight);
			return ret;
		}
		[Export ("systemFontOfSize:weight:width:")]
		[SupportedOSPlatform ("macos13.0")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static nint _SystemFontOfSize (nfloat fontSize, nfloat weight, nfloat width)
		{
			nint ret;
			ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSend_nfloat_nfloat_nfloat (class_ptr, selSystemFontOfSize_Weight_Width_XHandle, fontSize, weight, width);
			return ret;
		}
		[Export ("titleBarFontOfSize:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static nint _TitleBarFontOfSize (nfloat fontSize)
		{
			nint ret;
			ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSend_nfloat (class_ptr, selTitleBarFontOfSize_XHandle, fontSize);
			return ret;
		}
		[Export ("toolTipsFontOfSize:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static nint _ToolTipsFontOfSize (nfloat fontSize)
		{
			nint ret;
			ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSend_nfloat (class_ptr, selToolTipsFontOfSize_XHandle, fontSize);
			return ret;
		}
		[Export ("userFixedPitchFontOfSize:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static nint _UserFixedPitchFontOfSize (nfloat fontSize)
		{
			nint ret;
			ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSend_nfloat (class_ptr, selUserFixedPitchFontOfSize_XHandle, fontSize);
			return ret;
		}
		[Export ("userFontOfSize:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static nint _UserFontOfSize (nfloat fontSize)
		{
			nint ret;
			ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSend_nfloat (class_ptr, selUserFontOfSize_XHandle, fontSize);
			return ret;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual nfloat Ascender {
			[Export ("ascender")]
			get {
				nfloat ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.nfloat_objc_msgSend (this.Handle, selAscenderXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.nfloat_objc_msgSendSuper (&__objc_super__, selAscenderXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual CGRect BoundingRectForFont {
			[Export ("boundingRectForFont")]
			get {
				CGRect ret;
				if (IsDirectBinding) {
					if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
						ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSend (this.Handle, selBoundingRectForFontXHandle);
					} else {
						ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSend_stret (this.Handle, selBoundingRectForFontXHandle);
					}
				} else {
					if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
						unsafe {
							var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
							ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSendSuper (&__objc_super__, selBoundingRectForFontXHandle);
							GC.KeepAlive (this);
						}
					} else {
						unsafe {
							var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
							ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSendSuper_stret (&__objc_super__, selBoundingRectForFontXHandle);
							GC.KeepAlive (this);
						}
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual nfloat CapHeight {
			[Export ("capHeight")]
			get {
				nfloat ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.nfloat_objc_msgSend (this.Handle, selCapHeightXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.nfloat_objc_msgSendSuper (&__objc_super__, selCapHeightXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSCharacterSet CoveredCharacterSet {
			[Export ("coveredCharacterSet")]
			get {
				NSCharacterSet? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSCharacterSet> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selCoveredCharacterSetXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<NSCharacterSet> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selCoveredCharacterSetXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual nfloat Descender {
			[Export ("descender")]
			get {
				nfloat ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.nfloat_objc_msgSend (this.Handle, selDescenderXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.nfloat_objc_msgSendSuper (&__objc_super__, selDescenderXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string DisplayName {
			[Export ("displayName")]
			get {
				string ret;
				if (IsDirectBinding) {
					ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selDisplayNameXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selDisplayNameXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string FamilyName {
			[Export ("familyName")]
			get {
				string ret;
				if (IsDirectBinding) {
					ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selFamilyNameXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selFamilyNameXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSFontDescriptor FontDescriptor {
			[Export ("fontDescriptor")]
			get {
				NSFontDescriptor? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSFontDescriptor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selFontDescriptorXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<NSFontDescriptor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selFontDescriptorXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string FontName {
			[Export ("fontName")]
			get {
				string ret;
				if (IsDirectBinding) {
					ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selFontNameXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selFontNameXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual nint GlyphCount {
			[Export ("numberOfGlyphs")]
			get {
				nint ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selNumberOfGlyphsXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (&__objc_super__, selNumberOfGlyphsXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool IsFixedPitch {
			[Export ("isFixedPitch")]
			get {
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selIsFixedPitchXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, selIsFixedPitchXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool IsVertical {
			[Export ("isVertical")]
			get {
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selIsVerticalXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, selIsVerticalXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual nfloat ItalicAngle {
			[Export ("italicAngle")]
			get {
				nfloat ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.nfloat_objc_msgSend (this.Handle, selItalicAngleXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.nfloat_objc_msgSendSuper (&__objc_super__, selItalicAngleXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static nfloat LabelFontSize {
			[Export ("labelFontSize")]
			get {
				nfloat ret;
				ret = global::ObjCRuntime.Messaging.nfloat_objc_msgSend (class_ptr, selLabelFontSizeXHandle);
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual nfloat Leading {
			[Export ("leading")]
			get {
				nfloat ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.nfloat_objc_msgSend (this.Handle, selLeadingXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.nfloat_objc_msgSendSuper (&__objc_super__, selLeadingXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual CGSize MaximumAdvancement {
			[Export ("maximumAdvancement")]
			get {
				CGSize ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.CGSize_objc_msgSend (this.Handle, selMaximumAdvancementXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.CGSize_objc_msgSendSuper (&__objc_super__, selMaximumAdvancementXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSStringEncoding MostCompatibleStringEncoding {
			[Export ("mostCompatibleStringEncoding")]
			get {
				NSStringEncoding ret;
				if (IsDirectBinding) {
					ret = (NSStringEncoding) (ulong) global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend (this.Handle, selMostCompatibleStringEncodingXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = (NSStringEncoding) (ulong) global::ObjCRuntime.Messaging.UIntPtr_objc_msgSendSuper (&__objc_super__, selMostCompatibleStringEncodingXHandle);
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
		[ObsoletedOSPlatform ("macos10.13")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public virtual NSFontRenderingMode RenderingMode {
			[Export ("renderingMode")]
			get {
				NSFontRenderingMode ret;
				if (IsDirectBinding) {
					ret = (NSFontRenderingMode) (ulong) global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend (this.Handle, selRenderingModeXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = (NSFontRenderingMode) (ulong) global::ObjCRuntime.Messaging.UIntPtr_objc_msgSendSuper (&__objc_super__, selRenderingModeXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static nfloat SmallSystemFontSize {
			[Export ("smallSystemFontSize")]
			get {
				nfloat ret;
				ret = global::ObjCRuntime.Messaging.nfloat_objc_msgSend (class_ptr, selSmallSystemFontSizeXHandle);
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static nfloat SystemFontSize {
			[Export ("systemFontSize")]
			get {
				nfloat ret;
				ret = global::ObjCRuntime.Messaging.nfloat_objc_msgSend (class_ptr, selSystemFontSizeXHandle);
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSAffineTransform TextTransform {
			[Export ("textTransform")]
			get {
				NSAffineTransform? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSAffineTransform> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selTextTransformXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<NSAffineTransform> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selTextTransformXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual nfloat UnderlinePosition {
			[Export ("underlinePosition")]
			get {
				nfloat ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.nfloat_objc_msgSend (this.Handle, selUnderlinePositionXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.nfloat_objc_msgSendSuper (&__objc_super__, selUnderlinePositionXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual nfloat UnderlineThickness {
			[Export ("underlineThickness")]
			get {
				nfloat ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.nfloat_objc_msgSend (this.Handle, selUnderlineThicknessXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.nfloat_objc_msgSendSuper (&__objc_super__, selUnderlineThicknessXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual nfloat XHeight {
			[Export ("xHeight")]
			get {
				nfloat ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.nfloat_objc_msgSend (this.Handle, selXHeightXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.nfloat_objc_msgSendSuper (&__objc_super__, selXHeightXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[ObsoletedOSPlatform ("macos10.13")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		internal virtual nint _PrinterFont {
			[Export ("printerFont")]
			get {
				nint ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selPrinterFontXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (&__objc_super__, selPrinterFontXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[ObsoletedOSPlatform ("macos10.13")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		internal virtual nint _ScreenFont {
			[Export ("screenFont")]
			get {
				nint ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selScreenFontXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (&__objc_super__, selScreenFontXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _AntialiasThresholdChangedNotification;
		/// <summary>Notification constant for AntialiasThresholdChanged</summary>
		/// <value><see cref="NSString" /> constant, should be used as a token to <see cref="NSNotificationCenter" />.</value>
		/// <remarks>
		///   <para>
		///     This constant can be used with <see cref="NSNotificationCenter" /> to register a listener for this notification.
		///     This is an <see cref="NSString" /> instead of a string, because these values can be used as tokens in some native
		///     libraries instead of being used purely for their actual string content. The 'notification' parameter to the callback
		///     contains extra information that is specific to the notification type.
		///   </para>
		///   <para>
		///     To subscribe to this notification, developers can use the convenience <see cref="Notifications.ObserveAntialiasThresholdChanged(NSObject,EventHandler{NSNotificationEventArgs})" />
		///     or <see cref="Notifications.ObserveAntialiasThresholdChanged(EventHandler{NSNotificationEventArgs})" /> methods,
		///     which offers strongly typed access to the parameters of the notification.
		///   </para>
		///   <para>
		///     The following example shows how to use the strongly typed <see cref="Notifications" /> class, to take the guesswork
		///     out of the available properties in the notification:
		///   </para>
		///   <example>
		///     <code lang="csharp lang-csharp"><![CDATA[
		/// //
		/// // Lambda style
		/// //
		///
		/// // listening
		/// notification = NSFont.Notifications.ObserveAntialiasThresholdChanged ((sender, args) => {
		/// /* Access strongly typed args */
		/// Console.WriteLine ("Notification: {0}", args.Notification);
		/// });
		///
		/// // To stop listening:
		/// notification.Dispose ();
		///
		/// //
		/// // Method style
		/// //
		/// NSObject notification;
		/// void Callback (object sender, NSFont.NSNotificationEventArgs args)
		/// {
		///     // Access strongly typed args
		///     Console.WriteLine ("Notification: {0}", args.Notification);
		/// }
		///
		/// void Setup ()
		/// {
		///     notification = NSFont.Notifications.ObserveAntialiasThresholdChanged (Callback);
		/// }
		///
		/// void Teardown ()
		/// {
		///     notification.Dispose ();
		/// }]]></code>
		///   </example>
		///   <para>
		///     The following example shows how to use the notification with the DefaultCenter API:
		///   </para>
		///   <example>
		///     <code lang="csharp lang-csharp"><![CDATA[
		/// // Lambda style
		/// NSNotificationCenter.DefaultCenter.AddObserver (
		///     NSFont.AntialiasThresholdChangedNotification, (notification) => { Console.WriteLine ("Received the notification AntialiasThresholdChanged", notification); }
		/// );
		///
		/// // Method style
		/// void Callback (NSNotification notification)
		/// {
		///     Console.WriteLine ("Received the notification AntialiasThresholdChanged", notification);
		/// }
		///
		/// void Setup ()
		/// {
		///     NSNotificationCenter.DefaultCenter.AddObserver (NSFont.AntialiasThresholdChangedNotification, Callback);
		/// }
		/// ]]></code>
		///   </example>
		/// </remarks>
		[Field ("NSAntialiasThresholdChangedNotification",  "AppKit")]
		[Advice ("Use NSFont.Notifications.ObserveAntialiasThresholdChanged helper method instead.")]
		public static NSString AntialiasThresholdChangedNotification {
			get {
				if (_AntialiasThresholdChangedNotification is null)
					_AntialiasThresholdChangedNotification = Dlfcn.GetStringConstant (Libraries.AppKit.Handle, "NSAntialiasThresholdChangedNotification")!;
				return _AntialiasThresholdChangedNotification;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _CascadeListAttribute;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("NSFontCascadeListAttribute",  "AppKit")]
		public static NSString CascadeListAttribute {
			get {
				if (_CascadeListAttribute is null)
					_CascadeListAttribute = Dlfcn.GetStringConstant (Libraries.AppKit.Handle, "NSFontCascadeListAttribute")!;
				return _CascadeListAttribute;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _CharacterSetAttribute;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("NSFontCharacterSetAttribute",  "AppKit")]
		public static NSString CharacterSetAttribute {
			get {
				if (_CharacterSetAttribute is null)
					_CharacterSetAttribute = Dlfcn.GetStringConstant (Libraries.AppKit.Handle, "NSFontCharacterSetAttribute")!;
				return _CharacterSetAttribute;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _FaceAttribute;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("NSFontFaceAttribute",  "AppKit")]
		public static NSString FaceAttribute {
			get {
				if (_FaceAttribute is null)
					_FaceAttribute = Dlfcn.GetStringConstant (Libraries.AppKit.Handle, "NSFontFaceAttribute")!;
				return _FaceAttribute;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _FamilyAttribute;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("NSFontFamilyAttribute",  "AppKit")]
		public static NSString FamilyAttribute {
			get {
				if (_FamilyAttribute is null)
					_FamilyAttribute = Dlfcn.GetStringConstant (Libraries.AppKit.Handle, "NSFontFamilyAttribute")!;
				return _FamilyAttribute;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _FeatureSelectorIdentifierKey;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("NSFontFeatureSelectorIdentifierKey",  "AppKit")]
		public static NSString FeatureSelectorIdentifierKey {
			get {
				if (_FeatureSelectorIdentifierKey is null)
					_FeatureSelectorIdentifierKey = Dlfcn.GetStringConstant (Libraries.AppKit.Handle, "NSFontFeatureSelectorIdentifierKey")!;
				return _FeatureSelectorIdentifierKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _FeatureSettingsAttribute;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("NSFontFeatureSettingsAttribute",  "AppKit")]
		public static NSString FeatureSettingsAttribute {
			get {
				if (_FeatureSettingsAttribute is null)
					_FeatureSettingsAttribute = Dlfcn.GetStringConstant (Libraries.AppKit.Handle, "NSFontFeatureSettingsAttribute")!;
				return _FeatureSettingsAttribute;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _FeatureTypeIdentifierKey;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("NSFontFeatureTypeIdentifierKey",  "AppKit")]
		public static NSString FeatureTypeIdentifierKey {
			get {
				if (_FeatureTypeIdentifierKey is null)
					_FeatureTypeIdentifierKey = Dlfcn.GetStringConstant (Libraries.AppKit.Handle, "NSFontFeatureTypeIdentifierKey")!;
				return _FeatureTypeIdentifierKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _FixedAdvanceAttribute;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("NSFontFixedAdvanceAttribute",  "AppKit")]
		public static NSString FixedAdvanceAttribute {
			get {
				if (_FixedAdvanceAttribute is null)
					_FixedAdvanceAttribute = Dlfcn.GetStringConstant (Libraries.AppKit.Handle, "NSFontFixedAdvanceAttribute")!;
				return _FixedAdvanceAttribute;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _FontSetChangedNotification;
		/// <summary>Notification constant for FontSetChanged</summary>
		/// <value><see cref="NSString" /> constant, should be used as a token to <see cref="NSNotificationCenter" />.</value>
		/// <remarks>
		///   <para>
		///     This constant can be used with <see cref="NSNotificationCenter" /> to register a listener for this notification.
		///     This is an <see cref="NSString" /> instead of a string, because these values can be used as tokens in some native
		///     libraries instead of being used purely for their actual string content. The 'notification' parameter to the callback
		///     contains extra information that is specific to the notification type.
		///   </para>
		///   <para>
		///     To subscribe to this notification, developers can use the convenience <see cref="Notifications.ObserveFontSetChanged(NSObject,EventHandler{NSNotificationEventArgs})" />
		///     or <see cref="Notifications.ObserveFontSetChanged(EventHandler{NSNotificationEventArgs})" /> methods,
		///     which offers strongly typed access to the parameters of the notification.
		///   </para>
		///   <para>
		///     The following example shows how to use the strongly typed <see cref="Notifications" /> class, to take the guesswork
		///     out of the available properties in the notification:
		///   </para>
		///   <example>
		///     <code lang="csharp lang-csharp"><![CDATA[
		/// //
		/// // Lambda style
		/// //
		///
		/// // listening
		/// notification = NSFont.Notifications.ObserveFontSetChanged ((sender, args) => {
		/// /* Access strongly typed args */
		/// Console.WriteLine ("Notification: {0}", args.Notification);
		/// });
		///
		/// // To stop listening:
		/// notification.Dispose ();
		///
		/// //
		/// // Method style
		/// //
		/// NSObject notification;
		/// void Callback (object sender, NSFont.NSNotificationEventArgs args)
		/// {
		///     // Access strongly typed args
		///     Console.WriteLine ("Notification: {0}", args.Notification);
		/// }
		///
		/// void Setup ()
		/// {
		///     notification = NSFont.Notifications.ObserveFontSetChanged (Callback);
		/// }
		///
		/// void Teardown ()
		/// {
		///     notification.Dispose ();
		/// }]]></code>
		///   </example>
		///   <para>
		///     The following example shows how to use the notification with the DefaultCenter API:
		///   </para>
		///   <example>
		///     <code lang="csharp lang-csharp"><![CDATA[
		/// // Lambda style
		/// NSNotificationCenter.DefaultCenter.AddObserver (
		///     NSFont.FontSetChangedNotification, (notification) => { Console.WriteLine ("Received the notification FontSetChanged", notification); }
		/// );
		///
		/// // Method style
		/// void Callback (NSNotification notification)
		/// {
		///     Console.WriteLine ("Received the notification FontSetChanged", notification);
		/// }
		///
		/// void Setup ()
		/// {
		///     NSNotificationCenter.DefaultCenter.AddObserver (NSFont.FontSetChangedNotification, Callback);
		/// }
		/// ]]></code>
		///   </example>
		/// </remarks>
		[Field ("NSFontSetChangedNotification",  "AppKit")]
		[Advice ("Use NSFont.Notifications.ObserveFontSetChanged helper method instead.")]
		public static NSString FontSetChangedNotification {
			get {
				if (_FontSetChangedNotification is null)
					_FontSetChangedNotification = Dlfcn.GetStringConstant (Libraries.AppKit.Handle, "NSFontSetChangedNotification")!;
				return _FontSetChangedNotification;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _MatrixAttribute;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("NSFontMatrixAttribute",  "AppKit")]
		public static NSString MatrixAttribute {
			get {
				if (_MatrixAttribute is null)
					_MatrixAttribute = Dlfcn.GetStringConstant (Libraries.AppKit.Handle, "NSFontMatrixAttribute")!;
				return _MatrixAttribute;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _NameAttribute;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("NSFontNameAttribute",  "AppKit")]
		public static NSString NameAttribute {
			get {
				if (_NameAttribute is null)
					_NameAttribute = Dlfcn.GetStringConstant (Libraries.AppKit.Handle, "NSFontNameAttribute")!;
				return _NameAttribute;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _SizeAttribute;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("NSFontSizeAttribute",  "AppKit")]
		public static NSString SizeAttribute {
			get {
				if (_SizeAttribute is null)
					_SizeAttribute = Dlfcn.GetStringConstant (Libraries.AppKit.Handle, "NSFontSizeAttribute")!;
				return _SizeAttribute;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _SlantTrait;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("NSFontSlantTrait",  "AppKit")]
		public static NSString SlantTrait {
			get {
				if (_SlantTrait is null)
					_SlantTrait = Dlfcn.GetStringConstant (Libraries.AppKit.Handle, "NSFontSlantTrait")!;
				return _SlantTrait;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _SymbolicTrait;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("NSFontSymbolicTrait",  "AppKit")]
		public static NSString SymbolicTrait {
			get {
				if (_SymbolicTrait is null)
					_SymbolicTrait = Dlfcn.GetStringConstant (Libraries.AppKit.Handle, "NSFontSymbolicTrait")!;
				return _SymbolicTrait;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _TraitsAttribute;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("NSFontTraitsAttribute",  "AppKit")]
		public static NSString TraitsAttribute {
			get {
				if (_TraitsAttribute is null)
					_TraitsAttribute = Dlfcn.GetStringConstant (Libraries.AppKit.Handle, "NSFontTraitsAttribute")!;
				return _TraitsAttribute;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _VariationAttribute;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("NSFontVariationAttribute",  "AppKit")]
		public static NSString VariationAttribute {
			get {
				if (_VariationAttribute is null)
					_VariationAttribute = Dlfcn.GetStringConstant (Libraries.AppKit.Handle, "NSFontVariationAttribute")!;
				return _VariationAttribute;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _VariationAxisDefaultValueKey;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("NSFontVariationAxisDefaultValueKey",  "AppKit")]
		public static NSString VariationAxisDefaultValueKey {
			get {
				if (_VariationAxisDefaultValueKey is null)
					_VariationAxisDefaultValueKey = Dlfcn.GetStringConstant (Libraries.AppKit.Handle, "NSFontVariationAxisDefaultValueKey")!;
				return _VariationAxisDefaultValueKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _VariationAxisIdentifierKey;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("NSFontVariationAxisIdentifierKey",  "AppKit")]
		public static NSString VariationAxisIdentifierKey {
			get {
				if (_VariationAxisIdentifierKey is null)
					_VariationAxisIdentifierKey = Dlfcn.GetStringConstant (Libraries.AppKit.Handle, "NSFontVariationAxisIdentifierKey")!;
				return _VariationAxisIdentifierKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _VariationAxisMaximumValueKey;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("NSFontVariationAxisMaximumValueKey",  "AppKit")]
		public static NSString VariationAxisMaximumValueKey {
			get {
				if (_VariationAxisMaximumValueKey is null)
					_VariationAxisMaximumValueKey = Dlfcn.GetStringConstant (Libraries.AppKit.Handle, "NSFontVariationAxisMaximumValueKey")!;
				return _VariationAxisMaximumValueKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _VariationAxisMinimumValueKey;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("NSFontVariationAxisMinimumValueKey",  "AppKit")]
		public static NSString VariationAxisMinimumValueKey {
			get {
				if (_VariationAxisMinimumValueKey is null)
					_VariationAxisMinimumValueKey = Dlfcn.GetStringConstant (Libraries.AppKit.Handle, "NSFontVariationAxisMinimumValueKey")!;
				return _VariationAxisMinimumValueKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _VariationAxisNameKey;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("NSFontVariationAxisNameKey",  "AppKit")]
		public static NSString VariationAxisNameKey {
			get {
				if (_VariationAxisNameKey is null)
					_VariationAxisNameKey = Dlfcn.GetStringConstant (Libraries.AppKit.Handle, "NSFontVariationAxisNameKey")!;
				return _VariationAxisNameKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _VisibleNameAttribute;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("NSFontVisibleNameAttribute",  "AppKit")]
		public static NSString VisibleNameAttribute {
			get {
				if (_VisibleNameAttribute is null)
					_VisibleNameAttribute = Dlfcn.GetStringConstant (Libraries.AppKit.Handle, "NSFontVisibleNameAttribute")!;
				return _VisibleNameAttribute;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _WeightTrait;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("NSFontWeightTrait",  "AppKit")]
		public static NSString WeightTrait {
			get {
				if (_WeightTrait is null)
					_WeightTrait = Dlfcn.GetStringConstant (Libraries.AppKit.Handle, "NSFontWeightTrait")!;
				return _WeightTrait;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _WidthTrait;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("NSFontWidthTrait",  "AppKit")]
		public static NSString WidthTrait {
			get {
				if (_WidthTrait is null)
					_WidthTrait = Dlfcn.GetStringConstant (Libraries.AppKit.Handle, "NSFontWidthTrait")!;
				return _WidthTrait;
			}
		}
		//
		// Notifications
		//
		/// <summary>Notifications posted by the <see cref="global::AppKit.NSFont" /> class.</summary>
		/// <remarks>
		///    <para>This class contains various helper methods that allow developers to observe events posted in the notification hub (<see cref="Foundation.NSNotificationCenter" />).</para>
		///    <para>The methods defined in this class post events that invoke the provided method or lambda with a <see cref="Foundation.NSNotificationEventArgs" /> parameter, which contains strongly typed properties for the notification arguments.</para>
		/// </remarks>
		public static partial class Notifications {
			/// <summary>Strongly typed notification for the <see cref="global::AppKit.NSFont.AntialiasThresholdChangedNotification" /> constant.</summary>
			/// <param name="handler">The handler that responds to the notification when it occurs.</param>
			/// <returns>Token object that can be used to stop receiving notifications by either disposing it or passing it to <see cref="Foundation.NSNotificationCenter.RemoveObservers(System.Collections.Generic.IEnumerable{Foundation.NSObject})" />.</returns>
			/// <remarks>
			///   <para>This method can be used to subscribe to <see cref="global::AppKit.NSFont.AntialiasThresholdChangedNotification" /> notifications.</para>
			///   <example>
			///   <code lang="csharp lang-csharp"><![CDATA[
			/// // Listen to all notifications posted for any object
			/// var token = NSFont.Notifications.ObserveAntialiasThresholdChanged ((notification) => {
			///   Console.WriteLine ("Observed AntialiasThresholdChangedNotification!");
			/// };
			/// 
			/// // Stop listening for notifications
			/// token.Dispose ();
			/// ]]></code>
			///   </example>
			/// </remarks>
			public static NSObject ObserveAntialiasThresholdChanged (EventHandler<NSNotificationEventArgs> handler)
			{
				return NSNotificationCenter.DefaultCenter.AddObserver (AntialiasThresholdChangedNotification, notification => handler (null, new NSNotificationEventArgs (notification)));
			}
			/// <summary>Strongly typed notification for the <see cref="global::AppKit.NSFont.AntialiasThresholdChangedNotification" /> constant.</summary>
			/// <param name="objectToObserve">The specific object to observe.</param>
			/// <param name="handler">The handler that responds to the notification when it occurs.</param>
			/// <returns>Token object that can be used to stop receiving notifications by either disposing it or passing it to <see cref="Foundation.NSNotificationCenter.RemoveObservers(System.Collections.Generic.IEnumerable{Foundation.NSObject})" />.</returns>
			/// <remarks>
			///   <para>This method can be used to subscribe to <see cref="global::AppKit.NSFont.AntialiasThresholdChangedNotification" /> notifications.</para>
			///   <example>
			///     <code lang="csharp lang-csharp"><![CDATA[
			/// // Listen to all notifications posted for a single object
			/// var token = NSFont.Notifications.ObserveAntialiasThresholdChanged (objectToObserve, (notification) => {
			///   Console.WriteLine ($"Observed AntialiasThresholdChangedNotification for {nameof (objectToObserve)}!");
			/// };
			/// 
			/// // Stop listening for notifications
			/// token.Dispose ();
			/// ]]></code>
			///   </example>
			/// </remarks>
			public static NSObject ObserveAntialiasThresholdChanged (NSObject objectToObserve, EventHandler<NSNotificationEventArgs> handler)
			{
				return NSNotificationCenter.DefaultCenter.AddObserver (AntialiasThresholdChangedNotification, notification => handler (null, new NSNotificationEventArgs (notification)), objectToObserve);
			}
			/// <summary>Strongly typed notification for the <see cref="global::AppKit.NSFont.FontSetChangedNotification" /> constant.</summary>
			/// <param name="handler">The handler that responds to the notification when it occurs.</param>
			/// <returns>Token object that can be used to stop receiving notifications by either disposing it or passing it to <see cref="Foundation.NSNotificationCenter.RemoveObservers(System.Collections.Generic.IEnumerable{Foundation.NSObject})" />.</returns>
			/// <remarks>
			///   <para>This method can be used to subscribe to <see cref="global::AppKit.NSFont.FontSetChangedNotification" /> notifications.</para>
			///   <example>
			///   <code lang="csharp lang-csharp"><![CDATA[
			/// // Listen to all notifications posted for any object
			/// var token = NSFont.Notifications.ObserveFontSetChanged ((notification) => {
			///   Console.WriteLine ("Observed FontSetChangedNotification!");
			/// };
			/// 
			/// // Stop listening for notifications
			/// token.Dispose ();
			/// ]]></code>
			///   </example>
			/// </remarks>
			public static NSObject ObserveFontSetChanged (EventHandler<NSNotificationEventArgs> handler)
			{
				return NSNotificationCenter.DefaultCenter.AddObserver (FontSetChangedNotification, notification => handler (null, new NSNotificationEventArgs (notification)));
			}
			/// <summary>Strongly typed notification for the <see cref="global::AppKit.NSFont.FontSetChangedNotification" /> constant.</summary>
			/// <param name="objectToObserve">The specific object to observe.</param>
			/// <param name="handler">The handler that responds to the notification when it occurs.</param>
			/// <returns>Token object that can be used to stop receiving notifications by either disposing it or passing it to <see cref="Foundation.NSNotificationCenter.RemoveObservers(System.Collections.Generic.IEnumerable{Foundation.NSObject})" />.</returns>
			/// <remarks>
			///   <para>This method can be used to subscribe to <see cref="global::AppKit.NSFont.FontSetChangedNotification" /> notifications.</para>
			///   <example>
			///     <code lang="csharp lang-csharp"><![CDATA[
			/// // Listen to all notifications posted for a single object
			/// var token = NSFont.Notifications.ObserveFontSetChanged (objectToObserve, (notification) => {
			///   Console.WriteLine ($"Observed FontSetChangedNotification for {nameof (objectToObserve)}!");
			/// };
			/// 
			/// // Stop listening for notifications
			/// token.Dispose ();
			/// ]]></code>
			///   </example>
			/// </remarks>
			public static NSObject ObserveFontSetChanged (NSObject objectToObserve, EventHandler<NSNotificationEventArgs> handler)
			{
				return NSNotificationCenter.DefaultCenter.AddObserver (FontSetChangedNotification, notification => handler (null, new NSNotificationEventArgs (notification)), objectToObserve);
			}
		}
	} /* class NSFont */
}
