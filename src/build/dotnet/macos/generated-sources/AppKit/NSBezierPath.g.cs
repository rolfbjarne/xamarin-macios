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
	[Register("NSBezierPath", true)]
	[UnsupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("macos")]
	public unsafe partial class NSBezierPath : NSObject, INSCoding, INSCopying, INSSecureCoding {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selCGPathX = "CGPath";
		static readonly NativeHandle selCGPathXHandle = Selector.GetHandle ("CGPath");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAddClipX = "addClip";
		static readonly NativeHandle selAddClipXHandle = Selector.GetHandle ("addClip");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAppendBezierPath_X = "appendBezierPath:";
		static readonly NativeHandle selAppendBezierPath_XHandle = Selector.GetHandle ("appendBezierPath:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAppendBezierPathWithArcFromPoint_ToPoint_Radius_X = "appendBezierPathWithArcFromPoint:toPoint:radius:";
		static readonly NativeHandle selAppendBezierPathWithArcFromPoint_ToPoint_Radius_XHandle = Selector.GetHandle ("appendBezierPathWithArcFromPoint:toPoint:radius:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAppendBezierPathWithArcWithCenter_Radius_StartAngle_EndAngle_X = "appendBezierPathWithArcWithCenter:radius:startAngle:endAngle:";
		static readonly NativeHandle selAppendBezierPathWithArcWithCenter_Radius_StartAngle_EndAngle_XHandle = Selector.GetHandle ("appendBezierPathWithArcWithCenter:radius:startAngle:endAngle:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAppendBezierPathWithArcWithCenter_Radius_StartAngle_EndAngle_Clockwise_X = "appendBezierPathWithArcWithCenter:radius:startAngle:endAngle:clockwise:";
		static readonly NativeHandle selAppendBezierPathWithArcWithCenter_Radius_StartAngle_EndAngle_Clockwise_XHandle = Selector.GetHandle ("appendBezierPathWithArcWithCenter:radius:startAngle:endAngle:clockwise:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAppendBezierPathWithCGGlyph_InFont_X = "appendBezierPathWithCGGlyph:inFont:";
		static readonly NativeHandle selAppendBezierPathWithCGGlyph_InFont_XHandle = Selector.GetHandle ("appendBezierPathWithCGGlyph:inFont:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAppendBezierPathWithCGGlyphs_Count_InFont_X = "appendBezierPathWithCGGlyphs:count:inFont:";
		static readonly NativeHandle selAppendBezierPathWithCGGlyphs_Count_InFont_XHandle = Selector.GetHandle ("appendBezierPathWithCGGlyphs:count:inFont:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAppendBezierPathWithGlyph_InFont_X = "appendBezierPathWithGlyph:inFont:";
		static readonly NativeHandle selAppendBezierPathWithGlyph_InFont_XHandle = Selector.GetHandle ("appendBezierPathWithGlyph:inFont:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAppendBezierPathWithGlyphs_Count_InFont_X = "appendBezierPathWithGlyphs:count:inFont:";
		static readonly NativeHandle selAppendBezierPathWithGlyphs_Count_InFont_XHandle = Selector.GetHandle ("appendBezierPathWithGlyphs:count:inFont:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAppendBezierPathWithOvalInRect_X = "appendBezierPathWithOvalInRect:";
		static readonly NativeHandle selAppendBezierPathWithOvalInRect_XHandle = Selector.GetHandle ("appendBezierPathWithOvalInRect:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAppendBezierPathWithPackedGlyphs_X = "appendBezierPathWithPackedGlyphs:";
		static readonly NativeHandle selAppendBezierPathWithPackedGlyphs_XHandle = Selector.GetHandle ("appendBezierPathWithPackedGlyphs:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAppendBezierPathWithPoints_Count_X = "appendBezierPathWithPoints:count:";
		static readonly NativeHandle selAppendBezierPathWithPoints_Count_XHandle = Selector.GetHandle ("appendBezierPathWithPoints:count:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAppendBezierPathWithRect_X = "appendBezierPathWithRect:";
		static readonly NativeHandle selAppendBezierPathWithRect_XHandle = Selector.GetHandle ("appendBezierPathWithRect:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAppendBezierPathWithRoundedRect_XRadius_YRadius_X = "appendBezierPathWithRoundedRect:xRadius:yRadius:";
		static readonly NativeHandle selAppendBezierPathWithRoundedRect_XRadius_YRadius_XHandle = Selector.GetHandle ("appendBezierPathWithRoundedRect:xRadius:yRadius:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selBezierPathByFlatteningPathX = "bezierPathByFlatteningPath";
		static readonly NativeHandle selBezierPathByFlatteningPathXHandle = Selector.GetHandle ("bezierPathByFlatteningPath");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selBezierPathByReversingPathX = "bezierPathByReversingPath";
		static readonly NativeHandle selBezierPathByReversingPathXHandle = Selector.GetHandle ("bezierPathByReversingPath");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selBezierPathWithCGPath_X = "bezierPathWithCGPath:";
		static readonly NativeHandle selBezierPathWithCGPath_XHandle = Selector.GetHandle ("bezierPathWithCGPath:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selBezierPathWithOvalInRect_X = "bezierPathWithOvalInRect:";
		static readonly NativeHandle selBezierPathWithOvalInRect_XHandle = Selector.GetHandle ("bezierPathWithOvalInRect:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selBezierPathWithRect_X = "bezierPathWithRect:";
		static readonly NativeHandle selBezierPathWithRect_XHandle = Selector.GetHandle ("bezierPathWithRect:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selBezierPathWithRoundedRect_XRadius_YRadius_X = "bezierPathWithRoundedRect:xRadius:yRadius:";
		static readonly NativeHandle selBezierPathWithRoundedRect_XRadius_YRadius_XHandle = Selector.GetHandle ("bezierPathWithRoundedRect:xRadius:yRadius:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selBoundsX = "bounds";
		static readonly NativeHandle selBoundsXHandle = Selector.GetHandle ("bounds");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selClipRect_X = "clipRect:";
		static readonly NativeHandle selClipRect_XHandle = Selector.GetHandle ("clipRect:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selClosePathX = "closePath";
		static readonly NativeHandle selClosePathXHandle = Selector.GetHandle ("closePath");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selContainsPoint_X = "containsPoint:";
		static readonly NativeHandle selContainsPoint_XHandle = Selector.GetHandle ("containsPoint:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selControlPointBoundsX = "controlPointBounds";
		static readonly NativeHandle selControlPointBoundsXHandle = Selector.GetHandle ("controlPointBounds");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selCopyWithZone_X = "copyWithZone:";
		static readonly NativeHandle selCopyWithZone_XHandle = Selector.GetHandle ("copyWithZone:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selCurrentPointX = "currentPoint";
		static readonly NativeHandle selCurrentPointXHandle = Selector.GetHandle ("currentPoint");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selCurveToPoint_ControlPoint1_ControlPoint2_X = "curveToPoint:controlPoint1:controlPoint2:";
		static readonly NativeHandle selCurveToPoint_ControlPoint1_ControlPoint2_XHandle = Selector.GetHandle ("curveToPoint:controlPoint1:controlPoint2:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selCurveToPoint_ControlPoint_X = "curveToPoint:controlPoint:";
		static readonly NativeHandle selCurveToPoint_ControlPoint_XHandle = Selector.GetHandle ("curveToPoint:controlPoint:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selDefaultFlatnessX = "defaultFlatness";
		static readonly NativeHandle selDefaultFlatnessXHandle = Selector.GetHandle ("defaultFlatness");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selDefaultLineCapStyleX = "defaultLineCapStyle";
		static readonly NativeHandle selDefaultLineCapStyleXHandle = Selector.GetHandle ("defaultLineCapStyle");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selDefaultLineJoinStyleX = "defaultLineJoinStyle";
		static readonly NativeHandle selDefaultLineJoinStyleXHandle = Selector.GetHandle ("defaultLineJoinStyle");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selDefaultLineWidthX = "defaultLineWidth";
		static readonly NativeHandle selDefaultLineWidthXHandle = Selector.GetHandle ("defaultLineWidth");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selDefaultMiterLimitX = "defaultMiterLimit";
		static readonly NativeHandle selDefaultMiterLimitXHandle = Selector.GetHandle ("defaultMiterLimit");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selDefaultWindingRuleX = "defaultWindingRule";
		static readonly NativeHandle selDefaultWindingRuleXHandle = Selector.GetHandle ("defaultWindingRule");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selDrawPackedGlyphs_AtPoint_X = "drawPackedGlyphs:atPoint:";
		static readonly NativeHandle selDrawPackedGlyphs_AtPoint_XHandle = Selector.GetHandle ("drawPackedGlyphs:atPoint:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selElementAtIndex_X = "elementAtIndex:";
		static readonly NativeHandle selElementAtIndex_XHandle = Selector.GetHandle ("elementAtIndex:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selElementAtIndex_AssociatedPoints_X = "elementAtIndex:associatedPoints:";
		static readonly NativeHandle selElementAtIndex_AssociatedPoints_XHandle = Selector.GetHandle ("elementAtIndex:associatedPoints:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selElementCountX = "elementCount";
		static readonly NativeHandle selElementCountXHandle = Selector.GetHandle ("elementCount");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selEncodeWithCoder_X = "encodeWithCoder:";
		static readonly NativeHandle selEncodeWithCoder_XHandle = Selector.GetHandle ("encodeWithCoder:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selFillX = "fill";
		static readonly NativeHandle selFillXHandle = Selector.GetHandle ("fill");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selFillRect_X = "fillRect:";
		static readonly NativeHandle selFillRect_XHandle = Selector.GetHandle ("fillRect:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selFlatnessX = "flatness";
		static readonly NativeHandle selFlatnessXHandle = Selector.GetHandle ("flatness");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selGetLineDash_Count_Phase_X = "getLineDash:count:phase:";
		static readonly NativeHandle selGetLineDash_Count_Phase_XHandle = Selector.GetHandle ("getLineDash:count:phase:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selInitWithCoder_X = "initWithCoder:";
		static readonly NativeHandle selInitWithCoder_XHandle = Selector.GetHandle ("initWithCoder:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selIsEmptyX = "isEmpty";
		static readonly NativeHandle selIsEmptyXHandle = Selector.GetHandle ("isEmpty");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selLineCapStyleX = "lineCapStyle";
		static readonly NativeHandle selLineCapStyleXHandle = Selector.GetHandle ("lineCapStyle");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selLineJoinStyleX = "lineJoinStyle";
		static readonly NativeHandle selLineJoinStyleXHandle = Selector.GetHandle ("lineJoinStyle");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selLineToPoint_X = "lineToPoint:";
		static readonly NativeHandle selLineToPoint_XHandle = Selector.GetHandle ("lineToPoint:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selLineWidthX = "lineWidth";
		static readonly NativeHandle selLineWidthXHandle = Selector.GetHandle ("lineWidth");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selMiterLimitX = "miterLimit";
		static readonly NativeHandle selMiterLimitXHandle = Selector.GetHandle ("miterLimit");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selMoveToPoint_X = "moveToPoint:";
		static readonly NativeHandle selMoveToPoint_XHandle = Selector.GetHandle ("moveToPoint:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selRelativeCurveToPoint_ControlPoint1_ControlPoint2_X = "relativeCurveToPoint:controlPoint1:controlPoint2:";
		static readonly NativeHandle selRelativeCurveToPoint_ControlPoint1_ControlPoint2_XHandle = Selector.GetHandle ("relativeCurveToPoint:controlPoint1:controlPoint2:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selRelativeCurveToPoint_ControlPoint_X = "relativeCurveToPoint:controlPoint:";
		static readonly NativeHandle selRelativeCurveToPoint_ControlPoint_XHandle = Selector.GetHandle ("relativeCurveToPoint:controlPoint:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selRelativeLineToPoint_X = "relativeLineToPoint:";
		static readonly NativeHandle selRelativeLineToPoint_XHandle = Selector.GetHandle ("relativeLineToPoint:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selRelativeMoveToPoint_X = "relativeMoveToPoint:";
		static readonly NativeHandle selRelativeMoveToPoint_XHandle = Selector.GetHandle ("relativeMoveToPoint:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selRemoveAllPointsX = "removeAllPoints";
		static readonly NativeHandle selRemoveAllPointsXHandle = Selector.GetHandle ("removeAllPoints");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetAssociatedPoints_AtIndex_X = "setAssociatedPoints:atIndex:";
		static readonly NativeHandle selSetAssociatedPoints_AtIndex_XHandle = Selector.GetHandle ("setAssociatedPoints:atIndex:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetCGPath_X = "setCGPath:";
		static readonly NativeHandle selSetCGPath_XHandle = Selector.GetHandle ("setCGPath:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetClipX = "setClip";
		static readonly NativeHandle selSetClipXHandle = Selector.GetHandle ("setClip");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetDefaultFlatness_X = "setDefaultFlatness:";
		static readonly NativeHandle selSetDefaultFlatness_XHandle = Selector.GetHandle ("setDefaultFlatness:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetDefaultLineCapStyle_X = "setDefaultLineCapStyle:";
		static readonly NativeHandle selSetDefaultLineCapStyle_XHandle = Selector.GetHandle ("setDefaultLineCapStyle:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetDefaultLineJoinStyle_X = "setDefaultLineJoinStyle:";
		static readonly NativeHandle selSetDefaultLineJoinStyle_XHandle = Selector.GetHandle ("setDefaultLineJoinStyle:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetDefaultLineWidth_X = "setDefaultLineWidth:";
		static readonly NativeHandle selSetDefaultLineWidth_XHandle = Selector.GetHandle ("setDefaultLineWidth:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetDefaultMiterLimit_X = "setDefaultMiterLimit:";
		static readonly NativeHandle selSetDefaultMiterLimit_XHandle = Selector.GetHandle ("setDefaultMiterLimit:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetDefaultWindingRule_X = "setDefaultWindingRule:";
		static readonly NativeHandle selSetDefaultWindingRule_XHandle = Selector.GetHandle ("setDefaultWindingRule:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetFlatness_X = "setFlatness:";
		static readonly NativeHandle selSetFlatness_XHandle = Selector.GetHandle ("setFlatness:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetLineCapStyle_X = "setLineCapStyle:";
		static readonly NativeHandle selSetLineCapStyle_XHandle = Selector.GetHandle ("setLineCapStyle:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetLineDash_Count_Phase_X = "setLineDash:count:phase:";
		static readonly NativeHandle selSetLineDash_Count_Phase_XHandle = Selector.GetHandle ("setLineDash:count:phase:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetLineJoinStyle_X = "setLineJoinStyle:";
		static readonly NativeHandle selSetLineJoinStyle_XHandle = Selector.GetHandle ("setLineJoinStyle:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetLineWidth_X = "setLineWidth:";
		static readonly NativeHandle selSetLineWidth_XHandle = Selector.GetHandle ("setLineWidth:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetMiterLimit_X = "setMiterLimit:";
		static readonly NativeHandle selSetMiterLimit_XHandle = Selector.GetHandle ("setMiterLimit:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetWindingRule_X = "setWindingRule:";
		static readonly NativeHandle selSetWindingRule_XHandle = Selector.GetHandle ("setWindingRule:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selStrokeX = "stroke";
		static readonly NativeHandle selStrokeXHandle = Selector.GetHandle ("stroke");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selStrokeLineFromPoint_ToPoint_X = "strokeLineFromPoint:toPoint:";
		static readonly NativeHandle selStrokeLineFromPoint_ToPoint_XHandle = Selector.GetHandle ("strokeLineFromPoint:toPoint:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selStrokeRect_X = "strokeRect:";
		static readonly NativeHandle selStrokeRect_XHandle = Selector.GetHandle ("strokeRect:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selTransformUsingAffineTransform_X = "transformUsingAffineTransform:";
		static readonly NativeHandle selTransformUsingAffineTransform_XHandle = Selector.GetHandle ("transformUsingAffineTransform:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selWindingRuleX = "windingRule";
		static readonly NativeHandle selWindingRuleXHandle = Selector.GetHandle ("windingRule");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly NativeHandle class_ptr = Class.GetHandle ("NSBezierPath");
		/// <summary>The Objective-C class handle for this class.</summary>
		/// <value>The pointer to the Objective-C class.</value>
		/// <remarks>
		///     Each managed class mirrors an unmanaged Objective-C class.
		///     This value contains the pointer to the Objective-C class.
		///     It is similar to calling the managed <see cref="ObjCRuntime.Class.GetHandle(string)" /> or the native <see href="https://developer.apple.com/documentation/objectivec/1418952-objc_getclass">objc_getClass</see> method with the type name.
		/// </remarks>
		public override NativeHandle ClassHandle { get { return class_ptr; } }
		/// <summary>Creates a new <see cref="NSBezierPath" /> with default values.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public NSBezierPath () : base (NSObjectFlag.Empty)
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
		public NSBezierPath (NSCoder coder) : base (NSObjectFlag.Empty)
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
		protected NSBezierPath (NSObjectFlag t) : base (t)
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
		protected internal NSBezierPath (NativeHandle handle) : base (handle)
		{
		}

		[Export ("addClip")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void AddClip ()
		{
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, selAddClipXHandle);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper (&__objc_super__, selAddClipXHandle);
					GC.KeepAlive (this);
				}
			}
		}
		/// <param name="path">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void Append (NSBezierPath path)
		{
			AppendPath (path);
		}
		[Export ("appendBezierPath:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void AppendPath (NSBezierPath path)
		{
			var path__handle__ = path!.GetNonNullHandle (nameof (path));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selAppendBezierPath_XHandle, path__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selAppendBezierPath_XHandle, path__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (path);
		}
		[Export ("appendBezierPathWithArcWithCenter:radius:startAngle:endAngle:clockwise:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void AppendPathWithArc (CGPoint center, nfloat radius, nfloat startAngle, nfloat endAngle, bool clockwise)
		{
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_CGPoint_nfloat_nfloat_nfloat_bool (this.Handle, selAppendBezierPathWithArcWithCenter_Radius_StartAngle_EndAngle_Clockwise_XHandle, center, radius, startAngle, endAngle, clockwise ? (byte) 1 : (byte) 0);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_CGPoint_nfloat_nfloat_nfloat_bool (&__objc_super__, selAppendBezierPathWithArcWithCenter_Radius_StartAngle_EndAngle_Clockwise_XHandle, center, radius, startAngle, endAngle, clockwise ? (byte) 1 : (byte) 0);
					GC.KeepAlive (this);
				}
			}
		}
		[Export ("appendBezierPathWithArcWithCenter:radius:startAngle:endAngle:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void AppendPathWithArc (CGPoint center, nfloat radius, nfloat startAngle, nfloat endAngle)
		{
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_CGPoint_nfloat_nfloat_nfloat (this.Handle, selAppendBezierPathWithArcWithCenter_Radius_StartAngle_EndAngle_XHandle, center, radius, startAngle, endAngle);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_CGPoint_nfloat_nfloat_nfloat (&__objc_super__, selAppendBezierPathWithArcWithCenter_Radius_StartAngle_EndAngle_XHandle, center, radius, startAngle, endAngle);
					GC.KeepAlive (this);
				}
			}
		}
		[Export ("appendBezierPathWithArcFromPoint:toPoint:radius:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void AppendPathWithArc (CGPoint point1, CGPoint point2, nfloat radius)
		{
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_CGPoint_CGPoint_nfloat (this.Handle, selAppendBezierPathWithArcFromPoint_ToPoint_Radius_XHandle, point1, point2, radius);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_CGPoint_CGPoint_nfloat (&__objc_super__, selAppendBezierPathWithArcFromPoint_ToPoint_Radius_XHandle, point1, point2, radius);
					GC.KeepAlive (this);
				}
			}
		}
		[Export ("appendBezierPathWithCGGlyph:inFont:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void AppendPathWithCGGlyph (ushort glyph, NSFont font)
		{
			var font__handle__ = font!.GetNonNullHandle (nameof (font));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_UInt16_NativeHandle (this.Handle, selAppendBezierPathWithCGGlyph_InFont_XHandle, glyph, font__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_UInt16_NativeHandle (&__objc_super__, selAppendBezierPathWithCGGlyph_InFont_XHandle, glyph, font__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (font);
		}
		[Export ("appendBezierPathWithGlyph:inFont:")]
		[ObsoletedOSPlatform ("macos10.13", "Use 'AppendPathWithCGGlyph (CGGlyph, NSFont)' instead.")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void AppendPathWithGlyph (uint glyph, NSFont font)
		{
			var font__handle__ = font!.GetNonNullHandle (nameof (font));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_UInt32_NativeHandle (this.Handle, selAppendBezierPathWithGlyph_InFont_XHandle, glyph, font__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_UInt32_NativeHandle (&__objc_super__, selAppendBezierPathWithGlyph_InFont_XHandle, glyph, font__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (font);
		}
		[Export ("appendBezierPathWithOvalInRect:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void AppendPathWithOvalInRect (CGRect rect)
		{
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_CGRect (this.Handle, selAppendBezierPathWithOvalInRect_XHandle, rect);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_CGRect (&__objc_super__, selAppendBezierPathWithOvalInRect_XHandle, rect);
					GC.KeepAlive (this);
				}
			}
		}
		[Export ("appendBezierPathWithPackedGlyphs:")]
		[ObsoletedOSPlatform ("macos10.13", "Use 'Append (uint[], NSFont)' instead.")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void AppendPathWithPackedGlyphs (nint packedGlyphs)
		{
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selAppendBezierPathWithPackedGlyphs_XHandle, packedGlyphs);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (&__objc_super__, selAppendBezierPathWithPackedGlyphs_XHandle, packedGlyphs);
					GC.KeepAlive (this);
				}
			}
		}
		[Export ("appendBezierPathWithRect:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void AppendPathWithRect (CGRect rect)
		{
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_CGRect (this.Handle, selAppendBezierPathWithRect_XHandle, rect);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_CGRect (&__objc_super__, selAppendBezierPathWithRect_XHandle, rect);
					GC.KeepAlive (this);
				}
			}
		}
		[Export ("appendBezierPathWithRoundedRect:xRadius:yRadius:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void AppendPathWithRoundedRect (CGRect rect, nfloat xRadius, nfloat yRadius)
		{
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_CGRect_nfloat_nfloat (this.Handle, selAppendBezierPathWithRoundedRect_XRadius_YRadius_XHandle, rect, xRadius, yRadius);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_CGRect_nfloat_nfloat (&__objc_super__, selAppendBezierPathWithRoundedRect_XRadius_YRadius_XHandle, rect, xRadius, yRadius);
					GC.KeepAlive (this);
				}
			}
		}
		[Export ("bezierPathByFlatteningPath")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSBezierPath BezierPathByFlatteningPath ()
		{
			NSBezierPath ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<NSBezierPath> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selBezierPathByFlatteningPathXHandle), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<NSBezierPath> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selBezierPathByFlatteningPathXHandle), false)!;
					GC.KeepAlive (this);
				}
			}
			return ret;
		}
		[Export ("bezierPathByReversingPath")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSBezierPath BezierPathByReversingPath ()
		{
			NSBezierPath ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<NSBezierPath> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selBezierPathByReversingPathXHandle), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<NSBezierPath> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selBezierPathByReversingPathXHandle), false)!;
					GC.KeepAlive (this);
				}
			}
			return ret;
		}
		[Export ("clipRect:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void ClipRect (CGRect rect)
		{
			global::ObjCRuntime.Messaging.void_objc_msgSend_CGRect (class_ptr, selClipRect_XHandle, rect);
		}
		[Export ("closePath")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void ClosePath ()
		{
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, selClosePathXHandle);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper (&__objc_super__, selClosePathXHandle);
					GC.KeepAlive (this);
				}
			}
		}
		[Export ("containsPoint:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool Contains (CGPoint point)
		{
			byte ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_CGPoint (this.Handle, selContainsPoint_XHandle, point);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper_CGPoint (&__objc_super__, selContainsPoint_XHandle, point);
					GC.KeepAlive (this);
				}
			}
			return ret != 0;
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
		[Export ("curveToPoint:controlPoint1:controlPoint2:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void CurveTo (CGPoint endPoint, CGPoint controlPoint1, CGPoint controlPoint2)
		{
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_CGPoint_CGPoint_CGPoint (this.Handle, selCurveToPoint_ControlPoint1_ControlPoint2_XHandle, endPoint, controlPoint1, controlPoint2);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_CGPoint_CGPoint_CGPoint (&__objc_super__, selCurveToPoint_ControlPoint1_ControlPoint2_XHandle, endPoint, controlPoint1, controlPoint2);
					GC.KeepAlive (this);
				}
			}
		}
		[Export ("curveToPoint:controlPoint:")]
		[SupportedOSPlatform ("macos14.0")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void CurveTo (CGPoint endPoint, CGPoint controlPoint)
		{
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_CGPoint_CGPoint (this.Handle, selCurveToPoint_ControlPoint_XHandle, endPoint, controlPoint);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_CGPoint_CGPoint (&__objc_super__, selCurveToPoint_ControlPoint_XHandle, endPoint, controlPoint);
					GC.KeepAlive (this);
				}
			}
		}
		[Export ("drawPackedGlyphs:atPoint:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void DrawPackedGlyphsAtPoint (nint packedGlyphs, CGPoint point)
		{
			global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr_CGPoint (class_ptr, selDrawPackedGlyphs_AtPoint_XHandle, packedGlyphs, point);
		}
		[Export ("elementAtIndex:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSBezierPathElement ElementAt (nint index)
		{
			NSBezierPathElement ret;
			if (IsDirectBinding) {
				ret = (NSBezierPathElement) (ulong) global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend_IntPtr (this.Handle, selElementAtIndex_XHandle, index);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = (NSBezierPathElement) (ulong) global::ObjCRuntime.Messaging.UIntPtr_objc_msgSendSuper_IntPtr (&__objc_super__, selElementAtIndex_XHandle, index);
					GC.KeepAlive (this);
				}
			}
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
		[Export ("fill")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void Fill ()
		{
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, selFillXHandle);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper (&__objc_super__, selFillXHandle);
					GC.KeepAlive (this);
				}
			}
		}
		[Export ("fillRect:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void FillRect (CGRect rect)
		{
			global::ObjCRuntime.Messaging.void_objc_msgSend_CGRect (class_ptr, selFillRect_XHandle, rect);
		}
		[Export ("bezierPathWithCGPath:")]
		[SupportedOSPlatform ("macos14.0")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSBezierPath FromCGPath (CGPath cgPath)
		{
			var cgPath__handle__ = cgPath!.GetNonNullHandle (nameof (cgPath));
			NSBezierPath? ret;
			ret =  Runtime.GetNSObject<NSBezierPath> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (class_ptr, selBezierPathWithCGPath_XHandle, cgPath.Handle), false)!;
			GC.KeepAlive (cgPath);
			return ret!;
		}
		[Export ("bezierPathWithOvalInRect:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSBezierPath FromOvalInRect (CGRect rect)
		{
			NSBezierPath ret;
			ret =  Runtime.GetNSObject<NSBezierPath> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_CGRect (class_ptr, selBezierPathWithOvalInRect_XHandle, rect), false)!;
			return ret;
		}
		[Export ("bezierPathWithRect:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSBezierPath FromRect (CGRect rect)
		{
			NSBezierPath ret;
			ret =  Runtime.GetNSObject<NSBezierPath> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_CGRect (class_ptr, selBezierPathWithRect_XHandle, rect), false)!;
			return ret;
		}
		[Export ("bezierPathWithRoundedRect:xRadius:yRadius:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSBezierPath FromRoundedRect (CGRect rect, nfloat xRadius, nfloat yRadius)
		{
			NSBezierPath ret;
			ret =  Runtime.GetNSObject<NSBezierPath> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_CGRect_nfloat_nfloat (class_ptr, selBezierPathWithRoundedRect_XRadius_YRadius_XHandle, rect, xRadius, yRadius), false)!;
			return ret;
		}
		[Export ("lineToPoint:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void LineTo (CGPoint point)
		{
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_CGPoint (this.Handle, selLineToPoint_XHandle, point);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_CGPoint (&__objc_super__, selLineToPoint_XHandle, point);
					GC.KeepAlive (this);
				}
			}
		}
		[Export ("moveToPoint:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void MoveTo (CGPoint point)
		{
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_CGPoint (this.Handle, selMoveToPoint_XHandle, point);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_CGPoint (&__objc_super__, selMoveToPoint_XHandle, point);
					GC.KeepAlive (this);
				}
			}
		}
		[Export ("relativeCurveToPoint:controlPoint1:controlPoint2:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void RelativeCurveTo (CGPoint endPoint, CGPoint controlPoint1, CGPoint controlPoint2)
		{
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_CGPoint_CGPoint_CGPoint (this.Handle, selRelativeCurveToPoint_ControlPoint1_ControlPoint2_XHandle, endPoint, controlPoint1, controlPoint2);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_CGPoint_CGPoint_CGPoint (&__objc_super__, selRelativeCurveToPoint_ControlPoint1_ControlPoint2_XHandle, endPoint, controlPoint1, controlPoint2);
					GC.KeepAlive (this);
				}
			}
		}
		[Export ("relativeCurveToPoint:controlPoint:")]
		[SupportedOSPlatform ("macos14.0")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void RelativeCurveTo (CGPoint endPoint, CGPoint controlPoint)
		{
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_CGPoint_CGPoint (this.Handle, selRelativeCurveToPoint_ControlPoint_XHandle, endPoint, controlPoint);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_CGPoint_CGPoint (&__objc_super__, selRelativeCurveToPoint_ControlPoint_XHandle, endPoint, controlPoint);
					GC.KeepAlive (this);
				}
			}
		}
		[Export ("relativeLineToPoint:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void RelativeLineTo (CGPoint point)
		{
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_CGPoint (this.Handle, selRelativeLineToPoint_XHandle, point);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_CGPoint (&__objc_super__, selRelativeLineToPoint_XHandle, point);
					GC.KeepAlive (this);
				}
			}
		}
		[Export ("relativeMoveToPoint:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void RelativeMoveTo (CGPoint point)
		{
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_CGPoint (this.Handle, selRelativeMoveToPoint_XHandle, point);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_CGPoint (&__objc_super__, selRelativeMoveToPoint_XHandle, point);
					GC.KeepAlive (this);
				}
			}
		}
		[Export ("removeAllPoints")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void RemoveAllPoints ()
		{
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, selRemoveAllPointsXHandle);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper (&__objc_super__, selRemoveAllPointsXHandle);
					GC.KeepAlive (this);
				}
			}
		}
		[Export ("setClip")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetClip ()
		{
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, selSetClipXHandle);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper (&__objc_super__, selSetClipXHandle);
					GC.KeepAlive (this);
				}
			}
		}
		[Export ("stroke")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void Stroke ()
		{
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, selStrokeXHandle);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper (&__objc_super__, selStrokeXHandle);
					GC.KeepAlive (this);
				}
			}
		}
		[Export ("strokeLineFromPoint:toPoint:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void StrokeLine (CGPoint point1, CGPoint point2)
		{
			global::ObjCRuntime.Messaging.void_objc_msgSend_CGPoint_CGPoint (class_ptr, selStrokeLineFromPoint_ToPoint_XHandle, point1, point2);
		}
		[Export ("strokeRect:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void StrokeRect (CGRect rect)
		{
			global::ObjCRuntime.Messaging.void_objc_msgSend_CGRect (class_ptr, selStrokeRect_XHandle, rect);
		}
		[Export ("transformUsingAffineTransform:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void TransformUsingAffineTransform (NSAffineTransform transform)
		{
			var transform__handle__ = transform!.GetNonNullHandle (nameof (transform));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selTransformUsingAffineTransform_XHandle, transform__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selTransformUsingAffineTransform_XHandle, transform__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (transform);
		}
		[Export ("appendBezierPathWithCGGlyphs:count:inFont:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal virtual void _AppendBezierPathWithCGGlyphs (nint glyphs, nint count, NSFont font)
		{
			var font__handle__ = font!.GetNonNullHandle (nameof (font));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr_IntPtr_NativeHandle (this.Handle, selAppendBezierPathWithCGGlyphs_Count_InFont_XHandle, glyphs, count, font__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr_IntPtr_NativeHandle (&__objc_super__, selAppendBezierPathWithCGGlyphs_Count_InFont_XHandle, glyphs, count, font__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (font);
		}
		[Export ("appendBezierPathWithGlyphs:count:inFont:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal virtual void _AppendPathWithGlyphs (nint glyphs, nint count, NSFont font)
		{
			var font__handle__ = font!.GetNonNullHandle (nameof (font));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr_IntPtr_NativeHandle (this.Handle, selAppendBezierPathWithGlyphs_Count_InFont_XHandle, glyphs, count, font__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr_IntPtr_NativeHandle (&__objc_super__, selAppendBezierPathWithGlyphs_Count_InFont_XHandle, glyphs, count, font__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (font);
		}
		[Export ("appendBezierPathWithPoints:count:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal virtual void _AppendPathWithPoints (nint points, nint count)
		{
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr_IntPtr (this.Handle, selAppendBezierPathWithPoints_Count_XHandle, points, count);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr_IntPtr (&__objc_super__, selAppendBezierPathWithPoints_Count_XHandle, points, count);
					GC.KeepAlive (this);
				}
			}
		}
		[Export ("elementAtIndex:associatedPoints:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal virtual NSBezierPathElement _ElementAt (nint index, nint points)
		{
			NSBezierPathElement ret;
			if (IsDirectBinding) {
				ret = (NSBezierPathElement) (ulong) global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend_IntPtr_IntPtr (this.Handle, selElementAtIndex_AssociatedPoints_XHandle, index, points);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = (NSBezierPathElement) (ulong) global::ObjCRuntime.Messaging.UIntPtr_objc_msgSendSuper_IntPtr_IntPtr (&__objc_super__, selElementAtIndex_AssociatedPoints_XHandle, index, points);
					GC.KeepAlive (this);
				}
			}
			return ret!;
		}
		[Export ("getLineDash:count:phase:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal unsafe virtual void _GetLineDash (nint pattern, out nint count, out nfloat phase)
		{
			fixed (nint* count__pointer = &count) {
			fixed (nfloat* phase__pointer = &phase) {
			count = default;
			phase = default;
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr_out_IntPtr_out_NFloat (this.Handle, selGetLineDash_Count_Phase_XHandle, pattern, count__pointer, phase__pointer);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr_out_IntPtr_out_NFloat (&__objc_super__, selGetLineDash_Count_Phase_XHandle, pattern, count__pointer, phase__pointer);
					GC.KeepAlive (this);
				}
			}
			}
			}
		}
		[Export ("setAssociatedPoints:atIndex:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal virtual void _SetAssociatedPointsAtIndex (nint points, nint index)
		{
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr_IntPtr (this.Handle, selSetAssociatedPoints_AtIndex_XHandle, points, index);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr_IntPtr (&__objc_super__, selSetAssociatedPoints_AtIndex_XHandle, points, index);
					GC.KeepAlive (this);
				}
			}
		}
		[Export ("setLineDash:count:phase:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal virtual void _SetLineDash (nint pattern, nint count, nfloat phase)
		{
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr_IntPtr_nfloat (this.Handle, selSetLineDash_Count_Phase_XHandle, pattern, count, phase);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr_IntPtr_nfloat (&__objc_super__, selSetLineDash_Count_Phase_XHandle, pattern, count, phase);
					GC.KeepAlive (this);
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual CGRect Bounds {
			[Export ("bounds")]
			get {
				CGRect ret;
				if (IsDirectBinding) {
					if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
						ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSend (this.Handle, selBoundsXHandle);
					} else {
						ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSend_stret (this.Handle, selBoundsXHandle);
					}
				} else {
					if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
						unsafe {
							var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
							ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSendSuper (&__objc_super__, selBoundsXHandle);
							GC.KeepAlive (this);
						}
					} else {
						unsafe {
							var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
							ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSendSuper_stret (&__objc_super__, selBoundsXHandle);
							GC.KeepAlive (this);
						}
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("macos14.0")]
		[UnsupportedOSPlatform ("maccatalyst")]
		public virtual CGPath CGPath {
			[Export ("CGPath", ArgumentSemantic.Assign)]
			get {
				CGPath ret;
				if (IsDirectBinding) {
					ret = Runtime.GetINativeObject<global::CoreGraphics.CGPath> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selCGPathXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = Runtime.GetINativeObject<global::CoreGraphics.CGPath> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selCGPathXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[Export ("setCGPath:", ArgumentSemantic.Assign)]
			set {
				var value__handle__ = value!.GetNonNullHandle (nameof (value));
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selSetCGPath_XHandle, value.Handle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selSetCGPath_XHandle, value.Handle);
						GC.KeepAlive (this);
					}
				}
				GC.KeepAlive (value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual CGRect ControlPointBounds {
			[Export ("controlPointBounds")]
			get {
				CGRect ret;
				if (IsDirectBinding) {
					if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
						ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSend (this.Handle, selControlPointBoundsXHandle);
					} else {
						ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSend_stret (this.Handle, selControlPointBoundsXHandle);
					}
				} else {
					if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
						unsafe {
							var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
							ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSendSuper (&__objc_super__, selControlPointBoundsXHandle);
							GC.KeepAlive (this);
						}
					} else {
						unsafe {
							var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
							ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSendSuper_stret (&__objc_super__, selControlPointBoundsXHandle);
							GC.KeepAlive (this);
						}
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual CGPoint CurrentPoint {
			[Export ("currentPoint")]
			get {
				CGPoint ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.CGPoint_objc_msgSend (this.Handle, selCurrentPointXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.CGPoint_objc_msgSendSuper (&__objc_super__, selCurrentPointXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static nfloat DefaultFlatness {
			[Export ("defaultFlatness")]
			get {
				nfloat ret;
				ret = global::ObjCRuntime.Messaging.nfloat_objc_msgSend (class_ptr, selDefaultFlatnessXHandle);
				return ret;
			}
			[Export ("setDefaultFlatness:")]
			set {
				global::ObjCRuntime.Messaging.void_objc_msgSend_nfloat (class_ptr, selSetDefaultFlatness_XHandle, value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSLineCapStyle DefaultLineCapStyle {
			[Export ("defaultLineCapStyle")]
			get {
				NSLineCapStyle ret;
				ret = (NSLineCapStyle) (ulong) global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend (class_ptr, selDefaultLineCapStyleXHandle);
				return ret!;
			}
			[Export ("setDefaultLineCapStyle:")]
			set {
				global::ObjCRuntime.Messaging.void_objc_msgSend_UIntPtr (class_ptr, selSetDefaultLineCapStyle_XHandle, (UIntPtr) (ulong) value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSLineJoinStyle DefaultLineJoinStyle {
			[Export ("defaultLineJoinStyle")]
			get {
				NSLineJoinStyle ret;
				ret = (NSLineJoinStyle) (ulong) global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend (class_ptr, selDefaultLineJoinStyleXHandle);
				return ret!;
			}
			[Export ("setDefaultLineJoinStyle:")]
			set {
				global::ObjCRuntime.Messaging.void_objc_msgSend_UIntPtr (class_ptr, selSetDefaultLineJoinStyle_XHandle, (UIntPtr) (ulong) value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static nfloat DefaultLineWidth {
			[Export ("defaultLineWidth")]
			get {
				nfloat ret;
				ret = global::ObjCRuntime.Messaging.nfloat_objc_msgSend (class_ptr, selDefaultLineWidthXHandle);
				return ret;
			}
			[Export ("setDefaultLineWidth:")]
			set {
				global::ObjCRuntime.Messaging.void_objc_msgSend_nfloat (class_ptr, selSetDefaultLineWidth_XHandle, value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static nfloat DefaultMiterLimit {
			[Export ("defaultMiterLimit")]
			get {
				nfloat ret;
				ret = global::ObjCRuntime.Messaging.nfloat_objc_msgSend (class_ptr, selDefaultMiterLimitXHandle);
				return ret;
			}
			[Export ("setDefaultMiterLimit:")]
			set {
				global::ObjCRuntime.Messaging.void_objc_msgSend_nfloat (class_ptr, selSetDefaultMiterLimit_XHandle, value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSWindingRule DefaultWindingRule {
			[Export ("defaultWindingRule")]
			get {
				NSWindingRule ret;
				ret = (NSWindingRule) (ulong) global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend (class_ptr, selDefaultWindingRuleXHandle);
				return ret!;
			}
			[Export ("setDefaultWindingRule:")]
			set {
				global::ObjCRuntime.Messaging.void_objc_msgSend_UIntPtr (class_ptr, selSetDefaultWindingRule_XHandle, (UIntPtr) (ulong) value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual nint ElementCount {
			[Export ("elementCount")]
			get {
				nint ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selElementCountXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (&__objc_super__, selElementCountXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual nfloat Flatness {
			[Export ("flatness")]
			get {
				nfloat ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.nfloat_objc_msgSend (this.Handle, selFlatnessXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.nfloat_objc_msgSendSuper (&__objc_super__, selFlatnessXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[Export ("setFlatness:")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_nfloat (this.Handle, selSetFlatness_XHandle, value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_nfloat (&__objc_super__, selSetFlatness_XHandle, value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool IsEmpty {
			[Export ("isEmpty")]
			get {
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selIsEmptyXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, selIsEmptyXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSLineCapStyle LineCapStyle {
			[Export ("lineCapStyle")]
			get {
				NSLineCapStyle ret;
				if (IsDirectBinding) {
					ret = (NSLineCapStyle) (ulong) global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend (this.Handle, selLineCapStyleXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = (NSLineCapStyle) (ulong) global::ObjCRuntime.Messaging.UIntPtr_objc_msgSendSuper (&__objc_super__, selLineCapStyleXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setLineCapStyle:")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_UIntPtr (this.Handle, selSetLineCapStyle_XHandle, (UIntPtr) (ulong) value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_UIntPtr (&__objc_super__, selSetLineCapStyle_XHandle, (UIntPtr) (ulong) value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSLineJoinStyle LineJoinStyle {
			[Export ("lineJoinStyle")]
			get {
				NSLineJoinStyle ret;
				if (IsDirectBinding) {
					ret = (NSLineJoinStyle) (ulong) global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend (this.Handle, selLineJoinStyleXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = (NSLineJoinStyle) (ulong) global::ObjCRuntime.Messaging.UIntPtr_objc_msgSendSuper (&__objc_super__, selLineJoinStyleXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setLineJoinStyle:")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_UIntPtr (this.Handle, selSetLineJoinStyle_XHandle, (UIntPtr) (ulong) value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_UIntPtr (&__objc_super__, selSetLineJoinStyle_XHandle, (UIntPtr) (ulong) value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual nfloat LineWidth {
			[Export ("lineWidth")]
			get {
				nfloat ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.nfloat_objc_msgSend (this.Handle, selLineWidthXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.nfloat_objc_msgSendSuper (&__objc_super__, selLineWidthXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[Export ("setLineWidth:")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_nfloat (this.Handle, selSetLineWidth_XHandle, value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_nfloat (&__objc_super__, selSetLineWidth_XHandle, value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual nfloat MiterLimit {
			[Export ("miterLimit")]
			get {
				nfloat ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.nfloat_objc_msgSend (this.Handle, selMiterLimitXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.nfloat_objc_msgSendSuper (&__objc_super__, selMiterLimitXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[Export ("setMiterLimit:")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_nfloat (this.Handle, selSetMiterLimit_XHandle, value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_nfloat (&__objc_super__, selSetMiterLimit_XHandle, value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSWindingRule WindingRule {
			[Export ("windingRule")]
			get {
				NSWindingRule ret;
				if (IsDirectBinding) {
					ret = (NSWindingRule) (ulong) global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend (this.Handle, selWindingRuleXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = (NSWindingRule) (ulong) global::ObjCRuntime.Messaging.UIntPtr_objc_msgSendSuper (&__objc_super__, selWindingRuleXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setWindingRule:")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_UIntPtr (this.Handle, selSetWindingRule_XHandle, (UIntPtr) (ulong) value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_UIntPtr (&__objc_super__, selSetWindingRule_XHandle, (UIntPtr) (ulong) value);
						GC.KeepAlive (this);
					}
				}
			}
		}
	} /* class NSBezierPath */
}
