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
namespace CoreAnimation {
	/// <summary>Layers hold the images that are rendered into the screen.</summary><remarks><para>
	/// 	CALayers hold the image content that is rendered into the
	/// 	screen.  They encapsulate position, styling, size and
	/// 	transformation components.  They also implement the
	/// 	CAMediaTiming methods which allows them to participate in
	/// 	animations.
	/// </para><para>
	/// 	There are several subclasses of CALayer that developers can use:
	/// 	<see cref="T:CoreAnimation.CAEmitterLayer" />, 
	/// 	<see cref="T:CoreAnimation.CAGradientLayer" />, 
	/// 	<see cref="T:CoreAnimation.CAOpenGLLayer" />, 
	/// 	<see cref="T:CoreAnimation.CAReplicatorLayer" />, 
	/// 	<see cref="T:CoreAnimation.CAScrollLayer" />, 
	/// 	<see cref="T:CoreAnimation.CAShapeLayer" />, 
	/// 	<see cref="T:CoreAnimation.CATextLayer" />, 
	/// 	<see cref="T:CoreAnimation.CATiledLayer" />, 
	/// 	<see cref="T:CoreAnimation.CATransformLayer" /> and 
	/// 	<see cref="T:QuartzComposer.QCCompositionLayer" />.
	/// 
	/// </para><format type="text/html"><h2>Layer Content</h2></format><para>
	/// 	There are three ways of providing content to a layer:
	/// 	subclassing the layer class and overriding the draw methods,
	/// 	using a layer delegate to implement the drawing or assigning a
	/// 	static image to the layer.  
	/// </para><para>
	/// 	To set the contents of the layer with a static image or from one of the rendering approaches, app devs must
	/// 	assign a <see cref="T:CoreGraphics.CGImage" /> to the
	/// 	<see cref="P:CoreAnimation.CALayer.Contents" />
	/// 	property.   For static content, they can just assign this property and the changes will be reflected directly.
	/// </para><format type="text/html"><h3>Contents by Subclassing CALayer</h3></format><para>
	/// 	If you choose to subclass the CALayer class, you can either
	/// 	subclass the <see cref="M:CoreAnimation.CALayer.Display" /> method
	/// 	which is then requires to set the <see cref="P:CoreAnimation.CALayer.Contents" /> property
	/// 	or you can override the <see cref="M:CoreAnimation.CALayer.DrawInContext(CoreGraphics.CGContext)" /> method which provides you with a graphics context that you
	/// 	can use to render into the display.
	/// 
	/// </para><example><code lang="csharp lang-csharp"><![CDATA[
	/// // Overriding DrawInContext
	/// public class DemoLayer : CALayer {
	/// public override void DrawInContext (CGContext context)
	/// {
	/// base.DrawInContext (context);
	/// 
	/// // Fill in circle
	/// context.SetFillColor (Color);
	/// context.SetShadowWithColor (CGSize.Empty, 10.0f, glowColor);
	/// context.EOFillPath();
	/// }
	/// }
	/// 
	/// // Overriding Display
	/// public class DemoLayer2 : CALayer {
	/// CGImage image =  UIImage.FromBundle ("demo.png").CGImage;
	/// 
	/// public override void Display ()
	/// {
	/// Contents = image;
	/// }
	/// }
	/// ]]></code></example><format type="text/html"><h3>Contents by Providing a CALayerDelegate</h3></format><para>
	/// 
	/// 	This approach can be used if the developer does not want to change the
	/// 	class used for their CALayer rendering, and all they need to do is
	/// 	assign the <see cref="P:CoreAnimation.CALayer.Delegate" /> property
	/// 	to an instance of a subclass of <see cref="T:CoreAnimation.CALayerDelegate" /> where they
	/// 	either override the <see cref="M:CoreAnimation.CALayerDelegate.DisplayLayer(CoreAnimation.CALayer)" />
	/// 	method in which they must set the <see cref="P:CoreAnimation.CALayer.Contents" /> property,
	/// 	or they override the <see cref="M:CoreAnimation.CALayerDelegate.DrawLayer(CoreAnimation.CALayer,CoreGraphics.CGContext)" />
	/// 	method and provide their own rendering code there.
	/// 
	/// </para><example><code lang="csharp lang-csharp"><![CDATA[
	/// // Overriding DisplayLayer
	/// public class DemoLayerDelegate : CALayerDelegate {
	/// CGImage image =  UIImage.FromBundle ("demo.png").CGImage;
	/// 
	/// public override void DisplayLayer (CALayer layer)
	/// {
	/// layer.Contents = image;
	/// }
	/// }
	/// 
	/// // Overriding DrawLayer
	/// public class DemoLayerDelegate2 : CALayerDelegate {
	/// public override DrawLayer (CALayer layer, CGContext context)
	/// {
	/// // Fill in circle
	/// context.SetFillColor (Color);
	/// context.SetShadowWithColor (CGSize.Empty, 10.0f, glowColor);
	/// context.EOFillPath();
	/// }
	/// }
	/// 
	/// // To use the code:
	/// 
	/// void SetupViews (UIView view, UIView view2)
	/// {
	/// view.Layer.Delegate = new DemoLayerDelegate ();
	/// view2.Layer.Delegate = new DemoLayerDelegate2 ();
	/// }
	/// ]]></code></example><format type="text/html"><h2>Using Custom Layers with your UIViews or NSViews.</h2></format><para>
	/// 	On iOS, every UIView automatically has a CALayer associated
	/// 	with it.  When you want to use one of the CALayer subclasses
	/// 	as your UIView's backing layer, you need to add the following
	/// 	code snippet to your class:
	/// </para><example><code lang="csharp lang-csharp"><![CDATA[
	/// class MyView : UIView {
	/// //
	/// // This instructs the runtime that whenever a MyView is created
	/// // that it should instantiate a CATiledLayer and assign that to the
	/// // UIView.Layer property
	/// //
	/// [Export ("layerClass")]
	/// public static Class LayerClass () {
	/// return new Class (typeof (CATiledLayer));
	/// }
	/// }
	/// ]]></code></example><para>
	/// 	If you want to subclass the CALayer class, you must provide a
	/// 	constructor that takes a CALayer and is annotated with an
	/// 	[Export ("initWithLayer:")] attribute.  When you do this, you
	/// 	should also override the <see cref="CoreAnimation.CALayer.Clone(CoreAnimation.CALayer)" /> as these
	/// 	two are used to create copies of your layer state on demand in
	/// 	response to CoreAnimation creating a mirror of your object
	/// 	hierarchy if anyone accesses the <see cref="P:CoreAnimation.CALayer.PresentationLayer" />
	/// 	property.
	/// 
	/// </para><example><code lang="csharp lang-csharp"><![CDATA[
	/// public class MyLayer : CALayer {
	/// 	UIColor FirstColor, SecondColor;
	/// 
	/// 	//
	/// 	// Invoked by CoreAnimation if it needs to create a copy of your layer
	/// 	// with a specific state in response to the user fetching the PresentationLayer
	/// 	// property
	/// 	//
	/// 	[Export ("initWithLayer:")]
	/// 	public MyLayer (Mylayer other) : base (layer)
	/// 	{
	/// 		// Do nothing, since we override Clone, but we could
	/// 		// just clone the data here as well if we wanted to.
	/// 	}
	/// 
	/// 	//
	/// 	// This is the constructor you would use to create your new CALayer
	/// 	public MyLayer (UIColor firstColor, UIColor secondColor)
	/// 	{
	/// 		FirstColor = firstColor;
	/// 		SecondColor = secondColor;
	/// 	}
	/// 
	/// 	// We must copy our own state here from the original layer
	/// 	public override void Clone (CALayer _other)
	/// 	{
	/// 		MyLayer other = (MyLayer) _other;
	/// 		FirstColor = other.FirstColor;
	/// 		SecondColor = other.SecondColor;
	/// 	}
	/// }
	/// 	]]></code></example><para>
	/// 	On macOS, CALayers are optional.  To enable them, you must set
	/// 	the <see cref="P:AppKit.NSView.WantsLayer" /> property
	/// 	to true.  You can change the layer for an NSView by setting
	/// 	the <see cref="P:AppKit.NSView.Layer" /> property.
	/// 
	/// </para><para>
	/// 	On macOS, to change the default layer class used for a given
	/// 	NSView, you can override the <see cref="M:AppKit.NSView.MakeBackingLayer" /> method.
	/// 
	/// </para></remarks><related type="externalDocumentation" href="https://developer.apple.com/library/ios/documentation/GraphicsImaging/Reference/CALayer_class/index.html">Apple documentation for <c>CALayer</c></related>
	[Register("CALayer", true)]
	public unsafe partial class CALayer : NSObject, ICAMediaTiming, INSCoding, INSSecureCoding {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selActionForKey_X = "actionForKey:";
		static readonly NativeHandle selActionForKey_XHandle = Selector.GetHandle ("actionForKey:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selActionsX = "actions";
		static readonly NativeHandle selActionsXHandle = Selector.GetHandle ("actions");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAddAnimation_ForKey_X = "addAnimation:forKey:";
		static readonly NativeHandle selAddAnimation_ForKey_XHandle = Selector.GetHandle ("addAnimation:forKey:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAddConstraint_X = "addConstraint:";
		static readonly NativeHandle selAddConstraint_XHandle = Selector.GetHandle ("addConstraint:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAddSublayer_X = "addSublayer:";
		static readonly NativeHandle selAddSublayer_XHandle = Selector.GetHandle ("addSublayer:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAffineTransformX = "affineTransform";
		static readonly NativeHandle selAffineTransformXHandle = Selector.GetHandle ("affineTransform");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAllowsEdgeAntialiasingX = "allowsEdgeAntialiasing";
		static readonly NativeHandle selAllowsEdgeAntialiasingXHandle = Selector.GetHandle ("allowsEdgeAntialiasing");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAllowsGroupOpacityX = "allowsGroupOpacity";
		static readonly NativeHandle selAllowsGroupOpacityXHandle = Selector.GetHandle ("allowsGroupOpacity");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAnchorPointX = "anchorPoint";
		static readonly NativeHandle selAnchorPointXHandle = Selector.GetHandle ("anchorPoint");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAnchorPointZX = "anchorPointZ";
		static readonly NativeHandle selAnchorPointZXHandle = Selector.GetHandle ("anchorPointZ");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAnimationForKey_X = "animationForKey:";
		static readonly NativeHandle selAnimationForKey_XHandle = Selector.GetHandle ("animationForKey:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAnimationKeysX = "animationKeys";
		static readonly NativeHandle selAnimationKeysXHandle = Selector.GetHandle ("animationKeys");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAutoresizingMaskX = "autoresizingMask";
		static readonly NativeHandle selAutoresizingMaskXHandle = Selector.GetHandle ("autoresizingMask");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAutoreversesX = "autoreverses";
		static readonly NativeHandle selAutoreversesXHandle = Selector.GetHandle ("autoreverses");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selBackgroundColorX = "backgroundColor";
		static readonly NativeHandle selBackgroundColorXHandle = Selector.GetHandle ("backgroundColor");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selBackgroundFiltersX = "backgroundFilters";
		static readonly NativeHandle selBackgroundFiltersXHandle = Selector.GetHandle ("backgroundFilters");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selBeginTimeX = "beginTime";
		static readonly NativeHandle selBeginTimeXHandle = Selector.GetHandle ("beginTime");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selBorderColorX = "borderColor";
		static readonly NativeHandle selBorderColorXHandle = Selector.GetHandle ("borderColor");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selBorderWidthX = "borderWidth";
		static readonly NativeHandle selBorderWidthXHandle = Selector.GetHandle ("borderWidth");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selBoundsX = "bounds";
		static readonly NativeHandle selBoundsXHandle = Selector.GetHandle ("bounds");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selCompositingFilterX = "compositingFilter";
		static readonly NativeHandle selCompositingFilterXHandle = Selector.GetHandle ("compositingFilter");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selConstraintsX = "constraints";
		static readonly NativeHandle selConstraintsXHandle = Selector.GetHandle ("constraints");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selContainsPoint_X = "containsPoint:";
		static readonly NativeHandle selContainsPoint_XHandle = Selector.GetHandle ("containsPoint:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selContentsX = "contents";
		static readonly NativeHandle selContentsXHandle = Selector.GetHandle ("contents");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selContentsAreFlippedX = "contentsAreFlipped";
		static readonly NativeHandle selContentsAreFlippedXHandle = Selector.GetHandle ("contentsAreFlipped");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selContentsCenterX = "contentsCenter";
		static readonly NativeHandle selContentsCenterXHandle = Selector.GetHandle ("contentsCenter");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selContentsFormatX = "contentsFormat";
		static readonly NativeHandle selContentsFormatXHandle = Selector.GetHandle ("contentsFormat");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selContentsGravityX = "contentsGravity";
		static readonly NativeHandle selContentsGravityXHandle = Selector.GetHandle ("contentsGravity");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selContentsHeadroomX = "contentsHeadroom";
		static readonly NativeHandle selContentsHeadroomXHandle = Selector.GetHandle ("contentsHeadroom");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selContentsRectX = "contentsRect";
		static readonly NativeHandle selContentsRectXHandle = Selector.GetHandle ("contentsRect");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selContentsScaleX = "contentsScale";
		static readonly NativeHandle selContentsScaleXHandle = Selector.GetHandle ("contentsScale");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selConvertPoint_FromLayer_X = "convertPoint:fromLayer:";
		static readonly NativeHandle selConvertPoint_FromLayer_XHandle = Selector.GetHandle ("convertPoint:fromLayer:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selConvertPoint_ToLayer_X = "convertPoint:toLayer:";
		static readonly NativeHandle selConvertPoint_ToLayer_XHandle = Selector.GetHandle ("convertPoint:toLayer:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selConvertRect_FromLayer_X = "convertRect:fromLayer:";
		static readonly NativeHandle selConvertRect_FromLayer_XHandle = Selector.GetHandle ("convertRect:fromLayer:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selConvertRect_ToLayer_X = "convertRect:toLayer:";
		static readonly NativeHandle selConvertRect_ToLayer_XHandle = Selector.GetHandle ("convertRect:toLayer:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selConvertTime_FromLayer_X = "convertTime:fromLayer:";
		static readonly NativeHandle selConvertTime_FromLayer_XHandle = Selector.GetHandle ("convertTime:fromLayer:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selConvertTime_ToLayer_X = "convertTime:toLayer:";
		static readonly NativeHandle selConvertTime_ToLayer_XHandle = Selector.GetHandle ("convertTime:toLayer:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selCornerCurveX = "cornerCurve";
		static readonly NativeHandle selCornerCurveXHandle = Selector.GetHandle ("cornerCurve");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selCornerCurveExpansionFactor_X = "cornerCurveExpansionFactor:";
		static readonly NativeHandle selCornerCurveExpansionFactor_XHandle = Selector.GetHandle ("cornerCurveExpansionFactor:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selCornerRadiusX = "cornerRadius";
		static readonly NativeHandle selCornerRadiusXHandle = Selector.GetHandle ("cornerRadius");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selDefaultActionForKey_X = "defaultActionForKey:";
		static readonly NativeHandle selDefaultActionForKey_XHandle = Selector.GetHandle ("defaultActionForKey:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selDefaultValueForKey_X = "defaultValueForKey:";
		static readonly NativeHandle selDefaultValueForKey_XHandle = Selector.GetHandle ("defaultValueForKey:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selDelegateX = "delegate";
		static readonly NativeHandle selDelegateXHandle = Selector.GetHandle ("delegate");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selDisplayX = "display";
		static readonly NativeHandle selDisplayXHandle = Selector.GetHandle ("display");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selDisplayIfNeededX = "displayIfNeeded";
		static readonly NativeHandle selDisplayIfNeededXHandle = Selector.GetHandle ("displayIfNeeded");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selDrawInContext_X = "drawInContext:";
		static readonly NativeHandle selDrawInContext_XHandle = Selector.GetHandle ("drawInContext:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selDrawsAsynchronouslyX = "drawsAsynchronously";
		static readonly NativeHandle selDrawsAsynchronouslyXHandle = Selector.GetHandle ("drawsAsynchronously");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selDurationX = "duration";
		static readonly NativeHandle selDurationXHandle = Selector.GetHandle ("duration");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selEdgeAntialiasingMaskX = "edgeAntialiasingMask";
		static readonly NativeHandle selEdgeAntialiasingMaskXHandle = Selector.GetHandle ("edgeAntialiasingMask");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selEncodeWithCoder_X = "encodeWithCoder:";
		static readonly NativeHandle selEncodeWithCoder_XHandle = Selector.GetHandle ("encodeWithCoder:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selFillModeX = "fillMode";
		static readonly NativeHandle selFillModeXHandle = Selector.GetHandle ("fillMode");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selFiltersX = "filters";
		static readonly NativeHandle selFiltersXHandle = Selector.GetHandle ("filters");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selFrameX = "frame";
		static readonly NativeHandle selFrameXHandle = Selector.GetHandle ("frame");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selHitTest_X = "hitTest:";
		static readonly NativeHandle selHitTest_XHandle = Selector.GetHandle ("hitTest:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selInitWithCoder_X = "initWithCoder:";
		static readonly NativeHandle selInitWithCoder_XHandle = Selector.GetHandle ("initWithCoder:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selInsertSublayer_Above_X = "insertSublayer:above:";
		static readonly NativeHandle selInsertSublayer_Above_XHandle = Selector.GetHandle ("insertSublayer:above:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selInsertSublayer_AtIndex_X = "insertSublayer:atIndex:";
		static readonly NativeHandle selInsertSublayer_AtIndex_XHandle = Selector.GetHandle ("insertSublayer:atIndex:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selInsertSublayer_Below_X = "insertSublayer:below:";
		static readonly NativeHandle selInsertSublayer_Below_XHandle = Selector.GetHandle ("insertSublayer:below:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selIsDoubleSidedX = "isDoubleSided";
		static readonly NativeHandle selIsDoubleSidedXHandle = Selector.GetHandle ("isDoubleSided");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selIsGeometryFlippedX = "isGeometryFlipped";
		static readonly NativeHandle selIsGeometryFlippedXHandle = Selector.GetHandle ("isGeometryFlipped");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selIsHiddenX = "isHidden";
		static readonly NativeHandle selIsHiddenXHandle = Selector.GetHandle ("isHidden");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selIsOpaqueX = "isOpaque";
		static readonly NativeHandle selIsOpaqueXHandle = Selector.GetHandle ("isOpaque");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selLayerX = "layer";
		static readonly NativeHandle selLayerXHandle = Selector.GetHandle ("layer");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selLayerWithRemoteClientId_X = "layerWithRemoteClientId:";
		static readonly NativeHandle selLayerWithRemoteClientId_XHandle = Selector.GetHandle ("layerWithRemoteClientId:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selLayoutIfNeededX = "layoutIfNeeded";
		static readonly NativeHandle selLayoutIfNeededXHandle = Selector.GetHandle ("layoutIfNeeded");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selLayoutManagerX = "layoutManager";
		static readonly NativeHandle selLayoutManagerXHandle = Selector.GetHandle ("layoutManager");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selLayoutSublayersX = "layoutSublayers";
		static readonly NativeHandle selLayoutSublayersXHandle = Selector.GetHandle ("layoutSublayers");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selMagnificationFilterX = "magnificationFilter";
		static readonly NativeHandle selMagnificationFilterXHandle = Selector.GetHandle ("magnificationFilter");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selMaskX = "mask";
		static readonly NativeHandle selMaskXHandle = Selector.GetHandle ("mask");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selMaskedCornersX = "maskedCorners";
		static readonly NativeHandle selMaskedCornersXHandle = Selector.GetHandle ("maskedCorners");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selMasksToBoundsX = "masksToBounds";
		static readonly NativeHandle selMasksToBoundsXHandle = Selector.GetHandle ("masksToBounds");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selMinificationFilterX = "minificationFilter";
		static readonly NativeHandle selMinificationFilterXHandle = Selector.GetHandle ("minificationFilter");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selMinificationFilterBiasX = "minificationFilterBias";
		static readonly NativeHandle selMinificationFilterBiasXHandle = Selector.GetHandle ("minificationFilterBias");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selModelLayerX = "modelLayer";
		static readonly NativeHandle selModelLayerXHandle = Selector.GetHandle ("modelLayer");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selNameX = "name";
		static readonly NativeHandle selNameXHandle = Selector.GetHandle ("name");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selNeedsDisplayX = "needsDisplay";
		static readonly NativeHandle selNeedsDisplayXHandle = Selector.GetHandle ("needsDisplay");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selNeedsDisplayForKey_X = "needsDisplayForKey:";
		static readonly NativeHandle selNeedsDisplayForKey_XHandle = Selector.GetHandle ("needsDisplayForKey:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selNeedsDisplayOnBoundsChangeX = "needsDisplayOnBoundsChange";
		static readonly NativeHandle selNeedsDisplayOnBoundsChangeXHandle = Selector.GetHandle ("needsDisplayOnBoundsChange");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selNeedsLayoutX = "needsLayout";
		static readonly NativeHandle selNeedsLayoutXHandle = Selector.GetHandle ("needsLayout");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selOpacityX = "opacity";
		static readonly NativeHandle selOpacityXHandle = Selector.GetHandle ("opacity");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selPositionX = "position";
		static readonly NativeHandle selPositionXHandle = Selector.GetHandle ("position");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selPreferredDynamicRangeX = "preferredDynamicRange";
		static readonly NativeHandle selPreferredDynamicRangeXHandle = Selector.GetHandle ("preferredDynamicRange");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selPreferredFrameSizeX = "preferredFrameSize";
		static readonly NativeHandle selPreferredFrameSizeXHandle = Selector.GetHandle ("preferredFrameSize");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selPresentationLayerX = "presentationLayer";
		static readonly NativeHandle selPresentationLayerXHandle = Selector.GetHandle ("presentationLayer");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selRasterizationScaleX = "rasterizationScale";
		static readonly NativeHandle selRasterizationScaleXHandle = Selector.GetHandle ("rasterizationScale");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selRemoveAllAnimationsX = "removeAllAnimations";
		static readonly NativeHandle selRemoveAllAnimationsXHandle = Selector.GetHandle ("removeAllAnimations");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selRemoveAnimationForKey_X = "removeAnimationForKey:";
		static readonly NativeHandle selRemoveAnimationForKey_XHandle = Selector.GetHandle ("removeAnimationForKey:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selRemoveFromSuperlayerX = "removeFromSuperlayer";
		static readonly NativeHandle selRemoveFromSuperlayerXHandle = Selector.GetHandle ("removeFromSuperlayer");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selRenderInContext_X = "renderInContext:";
		static readonly NativeHandle selRenderInContext_XHandle = Selector.GetHandle ("renderInContext:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selRepeatCountX = "repeatCount";
		static readonly NativeHandle selRepeatCountXHandle = Selector.GetHandle ("repeatCount");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selRepeatDurationX = "repeatDuration";
		static readonly NativeHandle selRepeatDurationXHandle = Selector.GetHandle ("repeatDuration");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selReplaceSublayer_With_X = "replaceSublayer:with:";
		static readonly NativeHandle selReplaceSublayer_With_XHandle = Selector.GetHandle ("replaceSublayer:with:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selResizeSublayersWithOldSize_X = "resizeSublayersWithOldSize:";
		static readonly NativeHandle selResizeSublayersWithOldSize_XHandle = Selector.GetHandle ("resizeSublayersWithOldSize:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selResizeWithOldSuperlayerSize_X = "resizeWithOldSuperlayerSize:";
		static readonly NativeHandle selResizeWithOldSuperlayerSize_XHandle = Selector.GetHandle ("resizeWithOldSuperlayerSize:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selScrollPoint_X = "scrollPoint:";
		static readonly NativeHandle selScrollPoint_XHandle = Selector.GetHandle ("scrollPoint:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selScrollRectToVisible_X = "scrollRectToVisible:";
		static readonly NativeHandle selScrollRectToVisible_XHandle = Selector.GetHandle ("scrollRectToVisible:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetActions_X = "setActions:";
		static readonly NativeHandle selSetActions_XHandle = Selector.GetHandle ("setActions:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetAffineTransform_X = "setAffineTransform:";
		static readonly NativeHandle selSetAffineTransform_XHandle = Selector.GetHandle ("setAffineTransform:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetAllowsEdgeAntialiasing_X = "setAllowsEdgeAntialiasing:";
		static readonly NativeHandle selSetAllowsEdgeAntialiasing_XHandle = Selector.GetHandle ("setAllowsEdgeAntialiasing:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetAllowsGroupOpacity_X = "setAllowsGroupOpacity:";
		static readonly NativeHandle selSetAllowsGroupOpacity_XHandle = Selector.GetHandle ("setAllowsGroupOpacity:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetAnchorPoint_X = "setAnchorPoint:";
		static readonly NativeHandle selSetAnchorPoint_XHandle = Selector.GetHandle ("setAnchorPoint:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetAnchorPointZ_X = "setAnchorPointZ:";
		static readonly NativeHandle selSetAnchorPointZ_XHandle = Selector.GetHandle ("setAnchorPointZ:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetAutoresizingMask_X = "setAutoresizingMask:";
		static readonly NativeHandle selSetAutoresizingMask_XHandle = Selector.GetHandle ("setAutoresizingMask:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetAutoreverses_X = "setAutoreverses:";
		static readonly NativeHandle selSetAutoreverses_XHandle = Selector.GetHandle ("setAutoreverses:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetBackgroundColor_X = "setBackgroundColor:";
		static readonly NativeHandle selSetBackgroundColor_XHandle = Selector.GetHandle ("setBackgroundColor:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetBackgroundFilters_X = "setBackgroundFilters:";
		static readonly NativeHandle selSetBackgroundFilters_XHandle = Selector.GetHandle ("setBackgroundFilters:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetBeginTime_X = "setBeginTime:";
		static readonly NativeHandle selSetBeginTime_XHandle = Selector.GetHandle ("setBeginTime:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetBorderColor_X = "setBorderColor:";
		static readonly NativeHandle selSetBorderColor_XHandle = Selector.GetHandle ("setBorderColor:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetBorderWidth_X = "setBorderWidth:";
		static readonly NativeHandle selSetBorderWidth_XHandle = Selector.GetHandle ("setBorderWidth:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetBounds_X = "setBounds:";
		static readonly NativeHandle selSetBounds_XHandle = Selector.GetHandle ("setBounds:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetCompositingFilter_X = "setCompositingFilter:";
		static readonly NativeHandle selSetCompositingFilter_XHandle = Selector.GetHandle ("setCompositingFilter:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetConstraints_X = "setConstraints:";
		static readonly NativeHandle selSetConstraints_XHandle = Selector.GetHandle ("setConstraints:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetContents_X = "setContents:";
		static readonly NativeHandle selSetContents_XHandle = Selector.GetHandle ("setContents:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetContentsCenter_X = "setContentsCenter:";
		static readonly NativeHandle selSetContentsCenter_XHandle = Selector.GetHandle ("setContentsCenter:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetContentsFormat_X = "setContentsFormat:";
		static readonly NativeHandle selSetContentsFormat_XHandle = Selector.GetHandle ("setContentsFormat:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetContentsGravity_X = "setContentsGravity:";
		static readonly NativeHandle selSetContentsGravity_XHandle = Selector.GetHandle ("setContentsGravity:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetContentsHeadroom_X = "setContentsHeadroom:";
		static readonly NativeHandle selSetContentsHeadroom_XHandle = Selector.GetHandle ("setContentsHeadroom:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetContentsRect_X = "setContentsRect:";
		static readonly NativeHandle selSetContentsRect_XHandle = Selector.GetHandle ("setContentsRect:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetContentsScale_X = "setContentsScale:";
		static readonly NativeHandle selSetContentsScale_XHandle = Selector.GetHandle ("setContentsScale:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetCornerCurve_X = "setCornerCurve:";
		static readonly NativeHandle selSetCornerCurve_XHandle = Selector.GetHandle ("setCornerCurve:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetCornerRadius_X = "setCornerRadius:";
		static readonly NativeHandle selSetCornerRadius_XHandle = Selector.GetHandle ("setCornerRadius:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetDelegate_X = "setDelegate:";
		static readonly NativeHandle selSetDelegate_XHandle = Selector.GetHandle ("setDelegate:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetDoubleSided_X = "setDoubleSided:";
		static readonly NativeHandle selSetDoubleSided_XHandle = Selector.GetHandle ("setDoubleSided:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetDrawsAsynchronously_X = "setDrawsAsynchronously:";
		static readonly NativeHandle selSetDrawsAsynchronously_XHandle = Selector.GetHandle ("setDrawsAsynchronously:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetDuration_X = "setDuration:";
		static readonly NativeHandle selSetDuration_XHandle = Selector.GetHandle ("setDuration:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetEdgeAntialiasingMask_X = "setEdgeAntialiasingMask:";
		static readonly NativeHandle selSetEdgeAntialiasingMask_XHandle = Selector.GetHandle ("setEdgeAntialiasingMask:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetFillMode_X = "setFillMode:";
		static readonly NativeHandle selSetFillMode_XHandle = Selector.GetHandle ("setFillMode:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetFilters_X = "setFilters:";
		static readonly NativeHandle selSetFilters_XHandle = Selector.GetHandle ("setFilters:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetFrame_X = "setFrame:";
		static readonly NativeHandle selSetFrame_XHandle = Selector.GetHandle ("setFrame:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetGeometryFlipped_X = "setGeometryFlipped:";
		static readonly NativeHandle selSetGeometryFlipped_XHandle = Selector.GetHandle ("setGeometryFlipped:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetHidden_X = "setHidden:";
		static readonly NativeHandle selSetHidden_XHandle = Selector.GetHandle ("setHidden:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetLayoutManager_X = "setLayoutManager:";
		static readonly NativeHandle selSetLayoutManager_XHandle = Selector.GetHandle ("setLayoutManager:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetMagnificationFilter_X = "setMagnificationFilter:";
		static readonly NativeHandle selSetMagnificationFilter_XHandle = Selector.GetHandle ("setMagnificationFilter:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetMask_X = "setMask:";
		static readonly NativeHandle selSetMask_XHandle = Selector.GetHandle ("setMask:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetMaskedCorners_X = "setMaskedCorners:";
		static readonly NativeHandle selSetMaskedCorners_XHandle = Selector.GetHandle ("setMaskedCorners:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetMasksToBounds_X = "setMasksToBounds:";
		static readonly NativeHandle selSetMasksToBounds_XHandle = Selector.GetHandle ("setMasksToBounds:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetMinificationFilter_X = "setMinificationFilter:";
		static readonly NativeHandle selSetMinificationFilter_XHandle = Selector.GetHandle ("setMinificationFilter:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetMinificationFilterBias_X = "setMinificationFilterBias:";
		static readonly NativeHandle selSetMinificationFilterBias_XHandle = Selector.GetHandle ("setMinificationFilterBias:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetName_X = "setName:";
		static readonly NativeHandle selSetName_XHandle = Selector.GetHandle ("setName:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetNeedsDisplayX = "setNeedsDisplay";
		static readonly NativeHandle selSetNeedsDisplayXHandle = Selector.GetHandle ("setNeedsDisplay");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetNeedsDisplayInRect_X = "setNeedsDisplayInRect:";
		static readonly NativeHandle selSetNeedsDisplayInRect_XHandle = Selector.GetHandle ("setNeedsDisplayInRect:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetNeedsDisplayOnBoundsChange_X = "setNeedsDisplayOnBoundsChange:";
		static readonly NativeHandle selSetNeedsDisplayOnBoundsChange_XHandle = Selector.GetHandle ("setNeedsDisplayOnBoundsChange:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetNeedsLayoutX = "setNeedsLayout";
		static readonly NativeHandle selSetNeedsLayoutXHandle = Selector.GetHandle ("setNeedsLayout");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetOpacity_X = "setOpacity:";
		static readonly NativeHandle selSetOpacity_XHandle = Selector.GetHandle ("setOpacity:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetOpaque_X = "setOpaque:";
		static readonly NativeHandle selSetOpaque_XHandle = Selector.GetHandle ("setOpaque:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetPosition_X = "setPosition:";
		static readonly NativeHandle selSetPosition_XHandle = Selector.GetHandle ("setPosition:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetPreferredDynamicRange_X = "setPreferredDynamicRange:";
		static readonly NativeHandle selSetPreferredDynamicRange_XHandle = Selector.GetHandle ("setPreferredDynamicRange:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetRasterizationScale_X = "setRasterizationScale:";
		static readonly NativeHandle selSetRasterizationScale_XHandle = Selector.GetHandle ("setRasterizationScale:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetRepeatCount_X = "setRepeatCount:";
		static readonly NativeHandle selSetRepeatCount_XHandle = Selector.GetHandle ("setRepeatCount:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetRepeatDuration_X = "setRepeatDuration:";
		static readonly NativeHandle selSetRepeatDuration_XHandle = Selector.GetHandle ("setRepeatDuration:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetShadowColor_X = "setShadowColor:";
		static readonly NativeHandle selSetShadowColor_XHandle = Selector.GetHandle ("setShadowColor:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetShadowOffset_X = "setShadowOffset:";
		static readonly NativeHandle selSetShadowOffset_XHandle = Selector.GetHandle ("setShadowOffset:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetShadowOpacity_X = "setShadowOpacity:";
		static readonly NativeHandle selSetShadowOpacity_XHandle = Selector.GetHandle ("setShadowOpacity:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetShadowPath_X = "setShadowPath:";
		static readonly NativeHandle selSetShadowPath_XHandle = Selector.GetHandle ("setShadowPath:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetShadowRadius_X = "setShadowRadius:";
		static readonly NativeHandle selSetShadowRadius_XHandle = Selector.GetHandle ("setShadowRadius:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetShouldRasterize_X = "setShouldRasterize:";
		static readonly NativeHandle selSetShouldRasterize_XHandle = Selector.GetHandle ("setShouldRasterize:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetSpeed_X = "setSpeed:";
		static readonly NativeHandle selSetSpeed_XHandle = Selector.GetHandle ("setSpeed:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetStyle_X = "setStyle:";
		static readonly NativeHandle selSetStyle_XHandle = Selector.GetHandle ("setStyle:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetSublayerTransform_X = "setSublayerTransform:";
		static readonly NativeHandle selSetSublayerTransform_XHandle = Selector.GetHandle ("setSublayerTransform:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetSublayers_X = "setSublayers:";
		static readonly NativeHandle selSetSublayers_XHandle = Selector.GetHandle ("setSublayers:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetTimeOffset_X = "setTimeOffset:";
		static readonly NativeHandle selSetTimeOffset_XHandle = Selector.GetHandle ("setTimeOffset:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetToneMapMode_X = "setToneMapMode:";
		static readonly NativeHandle selSetToneMapMode_XHandle = Selector.GetHandle ("setToneMapMode:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetTransform_X = "setTransform:";
		static readonly NativeHandle selSetTransform_XHandle = Selector.GetHandle ("setTransform:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetWantsExtendedDynamicRangeContent_X = "setWantsExtendedDynamicRangeContent:";
		static readonly NativeHandle selSetWantsExtendedDynamicRangeContent_XHandle = Selector.GetHandle ("setWantsExtendedDynamicRangeContent:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetZPosition_X = "setZPosition:";
		static readonly NativeHandle selSetZPosition_XHandle = Selector.GetHandle ("setZPosition:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selShadowColorX = "shadowColor";
		static readonly NativeHandle selShadowColorXHandle = Selector.GetHandle ("shadowColor");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selShadowOffsetX = "shadowOffset";
		static readonly NativeHandle selShadowOffsetXHandle = Selector.GetHandle ("shadowOffset");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selShadowOpacityX = "shadowOpacity";
		static readonly NativeHandle selShadowOpacityXHandle = Selector.GetHandle ("shadowOpacity");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selShadowPathX = "shadowPath";
		static readonly NativeHandle selShadowPathXHandle = Selector.GetHandle ("shadowPath");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selShadowRadiusX = "shadowRadius";
		static readonly NativeHandle selShadowRadiusXHandle = Selector.GetHandle ("shadowRadius");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selShouldRasterizeX = "shouldRasterize";
		static readonly NativeHandle selShouldRasterizeXHandle = Selector.GetHandle ("shouldRasterize");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSpeedX = "speed";
		static readonly NativeHandle selSpeedXHandle = Selector.GetHandle ("speed");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selStyleX = "style";
		static readonly NativeHandle selStyleXHandle = Selector.GetHandle ("style");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSublayerTransformX = "sublayerTransform";
		static readonly NativeHandle selSublayerTransformXHandle = Selector.GetHandle ("sublayerTransform");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSublayersX = "sublayers";
		static readonly NativeHandle selSublayersXHandle = Selector.GetHandle ("sublayers");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSuperlayerX = "superlayer";
		static readonly NativeHandle selSuperlayerXHandle = Selector.GetHandle ("superlayer");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selTimeOffsetX = "timeOffset";
		static readonly NativeHandle selTimeOffsetXHandle = Selector.GetHandle ("timeOffset");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selToneMapModeX = "toneMapMode";
		static readonly NativeHandle selToneMapModeXHandle = Selector.GetHandle ("toneMapMode");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selTransformX = "transform";
		static readonly NativeHandle selTransformXHandle = Selector.GetHandle ("transform");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selVisibleRectX = "visibleRect";
		static readonly NativeHandle selVisibleRectXHandle = Selector.GetHandle ("visibleRect");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selWantsExtendedDynamicRangeContentX = "wantsExtendedDynamicRangeContent";
		static readonly NativeHandle selWantsExtendedDynamicRangeContentXHandle = Selector.GetHandle ("wantsExtendedDynamicRangeContent");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selZPositionX = "zPosition";
		static readonly NativeHandle selZPositionXHandle = Selector.GetHandle ("zPosition");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly NativeHandle class_ptr = Class.GetHandle ("CALayer");
		/// <summary>The Objective-C class handle for this class.</summary>
		/// <value>The pointer to the Objective-C class.</value>
		/// <remarks>
		///     Each managed class mirrors an unmanaged Objective-C class.
		///     This value contains the pointer to the Objective-C class.
		///     It is similar to calling the managed <see cref="ObjCRuntime.Class.GetHandle(string)" /> or the native <see href="https://developer.apple.com/documentation/objectivec/1418952-objc_getclass">objc_getClass</see> method with the type name.
		/// </remarks>
		public override NativeHandle ClassHandle { get { return class_ptr; } }
		/// <summary>Creates a new <see cref="CALayer" /> with default values.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public CALayer () : base (NSObjectFlag.Empty)
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
			MarkDirtyIfDerived ();
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
		public CALayer (NSCoder coder) : base (NSObjectFlag.Empty)
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
			MarkDirtyIfDerived ();
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
		protected CALayer (NSObjectFlag t) : base (t)
		{
			MarkDirtyIfDerived ();
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
		protected internal CALayer (NativeHandle handle) : base (handle)
		{
			MarkDirtyIfDerived ();
		}

		/// <param name="eventKey">Identifier of the action desired.</param><summary>Returns the <see cref="P:CoreAnimation.CALayer.Actions" /> value associated with the specified key.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("actionForKey:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSObject? ActionForKey (string eventKey)
		{
			if (eventKey is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (eventKey));
			var nseventKey = CFString.CreateNative (eventKey);
			NSObject? ret;
			if (IsDirectBinding) {
				ret = Runtime.GetNSObject (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, selActionForKey_XHandle, nseventKey), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = Runtime.GetNSObject (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle (&__objc_super__, selActionForKey_XHandle, nseventKey), false)!;
					GC.KeepAlive (this);
				}
			}
			CFString.ReleaseNative (nseventKey);
			return ret!;
		}
		/// <param name="animation">To be added.</param><param name="key"><para>
		/// 	    An identifier for the animation.  If the key already exists in the layer, the previous animation is removed.   
		/// 	  </para><para tool="nullallowed">This parameter can be <see langword="null" />.</para></param><summary>Adds the <paramref name="animation" /> to the render tree for the layer and associates it in <see cref="P:CoreAnimation.CALayer.Actions" /> with the key <paramref name="key" />.</summary><remarks>To be added.</remarks>
		[Export ("addAnimation:forKey:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void AddAnimation (CAAnimation animation, string? key)
		{
			var animation__handle__ = animation!.GetNonNullHandle (nameof (animation));
			var nskey = CFString.CreateNative (key);
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (this.Handle, selAddAnimation_ForKey_XHandle, animation__handle__, nskey);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, selAddAnimation_ForKey_XHandle, animation__handle__, nskey);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (animation);
			CFString.ReleaseNative (nskey);
		}
		/// <param name="c">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("addConstraint:")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void AddConstraint (CAConstraint c)
		{
			var c__handle__ = c!.GetNonNullHandle (nameof (c));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selAddConstraint_XHandle, c__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selAddConstraint_XHandle, c__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (c);
		}
		/// <param name="layer">The layer being added.</param><summary>Appends the <paramref name="layer" /> to this layer's <see cref="P:CoreAnimation.CALayer.Sublayers" />.</summary><remarks>To be added.</remarks>
		[Export ("addSublayer:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void AddSublayer (CALayer layer)
		{
			var layer__handle__ = layer!.GetNonNullHandle (nameof (layer));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selAddSublayer_XHandle, layer__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selAddSublayer_XHandle, layer__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (layer);
			#pragma warning disable 168
			#pragma warning restore 168
		}
		/// <param name="key">The animation's identifier.</param><summary>Returns the animation associated with the <paramref name="key" />.</summary><returns>The <see cref="T:CoreAnimation.CAAnimation" /> associated with <paramref name="key" /> or <see langword="null" /> if there is no such animation.</returns><remarks>To be added.</remarks>
		[Export ("animationForKey:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual CAAnimation? AnimationForKey (string key)
		{
			if (key is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (key));
			var nskey = CFString.CreateNative (key);
			CAAnimation? ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<CAAnimation> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, selAnimationForKey_XHandle, nskey), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<CAAnimation> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle (&__objc_super__, selAnimationForKey_XHandle, nskey), false)!;
					GC.KeepAlive (this);
				}
			}
			CFString.ReleaseNative (nskey);
			return ret!;
		}
		/// <param name="p">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("containsPoint:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool Contains (CGPoint p)
		{
			byte ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_CGPoint (this.Handle, selContainsPoint_XHandle, p);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper_CGPoint (&__objc_super__, selContainsPoint_XHandle, p);
					GC.KeepAlive (this);
				}
			}
			return ret != 0;
		}
		/// <param name="point">To be added.</param><param name="layer"><para>To be added.</para><para tool="nullallowed">This parameter can be <see langword="null" />.</para></param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("convertPoint:fromLayer:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual CGPoint ConvertPointFromLayer (CGPoint point, CALayer? layer)
		{
			var layer__handle__ = layer.GetHandle ();
			CGPoint ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.CGPoint_objc_msgSend_CGPoint_NativeHandle (this.Handle, selConvertPoint_FromLayer_XHandle, point, layer__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.CGPoint_objc_msgSendSuper_CGPoint_NativeHandle (&__objc_super__, selConvertPoint_FromLayer_XHandle, point, layer__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (layer);
			return ret!;
		}
		/// <param name="point">To be added.</param><param name="layer"><para>To be added.</para><para tool="nullallowed">This parameter can be <see langword="null" />.</para></param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("convertPoint:toLayer:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual CGPoint ConvertPointToLayer (CGPoint point, CALayer? layer)
		{
			var layer__handle__ = layer.GetHandle ();
			CGPoint ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.CGPoint_objc_msgSend_CGPoint_NativeHandle (this.Handle, selConvertPoint_ToLayer_XHandle, point, layer__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.CGPoint_objc_msgSendSuper_CGPoint_NativeHandle (&__objc_super__, selConvertPoint_ToLayer_XHandle, point, layer__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (layer);
			return ret!;
		}
		/// <param name="rect">To be added.</param><param name="layer"><para>To be added.</para><para tool="nullallowed">This parameter can be <see langword="null" />.</para></param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("convertRect:fromLayer:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual CGRect ConvertRectFromLayer (CGRect rect, CALayer? layer)
		{
			var layer__handle__ = layer.GetHandle ();
			CGRect ret;
			if (IsDirectBinding) {
				if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
					ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSend_CGRect_NativeHandle (this.Handle, selConvertRect_FromLayer_XHandle, rect, layer__handle__);
				} else {
					ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSend_stret_CGRect_NativeHandle (this.Handle, selConvertRect_FromLayer_XHandle, rect, layer__handle__);
				}
			} else {
				if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSendSuper_CGRect_NativeHandle (&__objc_super__, selConvertRect_FromLayer_XHandle, rect, layer__handle__);
						GC.KeepAlive (this);
					}
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSendSuper_stret_CGRect_NativeHandle (&__objc_super__, selConvertRect_FromLayer_XHandle, rect, layer__handle__);
						GC.KeepAlive (this);
					}
				}
			}
			GC.KeepAlive (layer);
			return ret!;
		}
		/// <param name="rect">To be added.</param><param name="layer"><para>To be added.</para><para tool="nullallowed">This parameter can be <see langword="null" />.</para></param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("convertRect:toLayer:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual CGRect ConvertRectToLayer (CGRect rect, CALayer? layer)
		{
			var layer__handle__ = layer.GetHandle ();
			CGRect ret;
			if (IsDirectBinding) {
				if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
					ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSend_CGRect_NativeHandle (this.Handle, selConvertRect_ToLayer_XHandle, rect, layer__handle__);
				} else {
					ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSend_stret_CGRect_NativeHandle (this.Handle, selConvertRect_ToLayer_XHandle, rect, layer__handle__);
				}
			} else {
				if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSendSuper_CGRect_NativeHandle (&__objc_super__, selConvertRect_ToLayer_XHandle, rect, layer__handle__);
						GC.KeepAlive (this);
					}
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSendSuper_stret_CGRect_NativeHandle (&__objc_super__, selConvertRect_ToLayer_XHandle, rect, layer__handle__);
						GC.KeepAlive (this);
					}
				}
			}
			GC.KeepAlive (layer);
			return ret!;
		}
		/// <param name="timeInterval">To be added.</param><param name="layer"><para>They layer that will be used to convert the time from.</para><para tool="nullallowed">This parameter can be <see langword="null" />.</para></param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("convertTime:fromLayer:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual double ConvertTimeFromLayer (double timeInterval, CALayer? layer)
		{
			var layer__handle__ = layer.GetHandle ();
			double ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.Double_objc_msgSend_Double_NativeHandle (this.Handle, selConvertTime_FromLayer_XHandle, timeInterval, layer__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.Double_objc_msgSendSuper_Double_NativeHandle (&__objc_super__, selConvertTime_FromLayer_XHandle, timeInterval, layer__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (layer);
			return ret!;
		}
		/// <param name="timeInterval">To be added.</param><param name="layer"><para>The layer that will be used to convert the time to.</para><para tool="nullallowed">This parameter can be <see langword="null" />.</para></param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("convertTime:toLayer:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual double ConvertTimeToLayer (double timeInterval, CALayer? layer)
		{
			var layer__handle__ = layer.GetHandle ();
			double ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.Double_objc_msgSend_Double_NativeHandle (this.Handle, selConvertTime_ToLayer_XHandle, timeInterval, layer__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.Double_objc_msgSendSuper_Double_NativeHandle (&__objc_super__, selConvertTime_ToLayer_XHandle, timeInterval, layer__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (layer);
			return ret!;
		}
		/// <summary>Factory method to create a new <see cref="T:CoreAnimation.CALayer" />.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("layer")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static CALayer Create ()
		{
			CALayer ret;
			ret =  Runtime.GetNSObject<CALayer> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (class_ptr, selLayerXHandle), false)!;
			return ret;
		}
		/// <param name="eventKey">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("defaultActionForKey:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSObject? DefaultActionForKey (string eventKey)
		{
			if (eventKey is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (eventKey));
			var nseventKey = CFString.CreateNative (eventKey);
			NSObject? ret;
			ret = Runtime.GetNSObject (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (class_ptr, selDefaultActionForKey_XHandle, nseventKey), false)!;
			CFString.ReleaseNative (nseventKey);
			return ret!;
		}
		/// <param name="key"><para>To be added.</para><para tool="nullallowed">This parameter can be <see langword="null" />.</para></param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("defaultValueForKey:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSObject? DefaultValue (string key)
		{
			if (key is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (key));
			var nskey = CFString.CreateNative (key);
			NSObject? ret;
			ret = Runtime.GetNSObject (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (class_ptr, selDefaultValueForKey_XHandle, nskey), false)!;
			CFString.ReleaseNative (nskey);
			return ret!;
		}
		/// <summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("display")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void Display ()
		{
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, selDisplayXHandle);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper (&__objc_super__, selDisplayXHandle);
					GC.KeepAlive (this);
				}
			}
		}
		/// <summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("displayIfNeeded")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DisplayIfNeeded ()
		{
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, selDisplayIfNeededXHandle);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper (&__objc_super__, selDisplayIfNeededXHandle);
					GC.KeepAlive (this);
				}
			}
		}
		/// <param name="ctx">Prepared context to draw into.</param><summary>Draws the layer on the specified context.</summary><remarks><para>
		/// 	    Developers override this method to provide custom
		/// 	    rendering of the contents of their instance of the
		/// 	    CALayer.  If this method is not overwritten, the CALayer
		/// 	    will invoke the <see cref="M:CoreAnimation.CALayerDelegate.DrawLayer(CoreAnimation.CALayer,CoreGraphics.CGContext)" />
		/// 	    method to render the contents.
		/// 	  </para><para>
		/// 	    The provided context has been preconfigured for the target
		/// 	    surface as well as having a clipping region defined.
		/// 	  </para></remarks>
		[Export ("drawInContext:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DrawInContext (CGContext ctx)
		{
			var ctx__handle__ = ctx!.GetNonNullHandle (nameof (ctx));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selDrawInContext_XHandle, ctx.Handle);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selDrawInContext_XHandle, ctx.Handle);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (ctx);
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
		[Export ("cornerCurveExpansionFactor:")]
		[SupportedOSPlatform ("tvos13.0")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static nfloat GetCornerCurveExpansionFactor ([BindAs (typeof (CACornerCurve), OriginalType = typeof (NSString))] global::CoreAnimation.CACornerCurve curve)
		{
			using var nsb_curve = global::CoreAnimation.CACornerCurveExtensions.GetConstant (curve);
			nfloat ret;
			ret = global::ObjCRuntime.Messaging.nfloat_objc_msgSend_NativeHandle (class_ptr, selCornerCurveExpansionFactor_XHandle, nsb_curve.GetHandle ());
			return ret;
		}
		[Export ("layerWithRemoteClientId:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static CALayer GetLayerWithRemoteClientId (uint client_id)
		{
			CALayer ret;
			ret =  Runtime.GetNSObject<CALayer> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_UInt32 (class_ptr, selLayerWithRemoteClientId_XHandle, client_id), false)!;
			return ret;
		}
		/// <param name="p">A point, in the coordinate system of this layer's <see cref="P:CoreAnimation.CALayer.SuperLayer" />.</param><summary>The furthest descendant in this layer's hierarchy that contains the point <paramref name="p" />.</summary><returns>The layer (possible <c>this</c>) that contains the point <paramref name="p" /> or <see langword="null" /> if <paramref name="p" /> lies outside the <see cref="P:CoreAnimation.CALayer.Bounds" /> rectangle of <c>this</c>.</returns><remarks>To be added.</remarks>
		[Export ("hitTest:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual CALayer? HitTest (CGPoint p)
		{
			CALayer ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<CALayer> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_CGPoint (this.Handle, selHitTest_XHandle, p), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<CALayer> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_CGPoint (&__objc_super__, selHitTest_XHandle, p), false)!;
					GC.KeepAlive (this);
				}
			}
			return ret;
		}
		/// <param name="layer">The layer being inserted.</param><param name="index">The index at which to insert the <paramref name="layer" />.</param><summary>Inserts the specified layer into the <see cref="P:CoreAnimation.CALayer.Sublayers" /> array at the specified index.</summary><remarks>To be added.</remarks>
		[Export ("insertSublayer:atIndex:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void InsertSublayer (CALayer layer, int index)
		{
			var layer__handle__ = layer!.GetNonNullHandle (nameof (layer));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_int (this.Handle, selInsertSublayer_AtIndex_XHandle, layer__handle__, index);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_int (&__objc_super__, selInsertSublayer_AtIndex_XHandle, layer__handle__, index);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (layer);
			#pragma warning disable 168
			#pragma warning restore 168
		}
		/// <param name="layer">The layer being inserted.</param><param name="sibling">The existing sublayer, which will subsequently appear behind <paramref name="layer" />.</param><summary>Inserts the specified layer into the <see cref="P:CoreAnimation.CALayer.Sublayers" /> array immediately after <paramref name="sibling" />.</summary><remarks>To be added.</remarks>
		[Export ("insertSublayer:above:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void InsertSublayerAbove (CALayer layer, CALayer? sibling)
		{
			var layer__handle__ = layer!.GetNonNullHandle (nameof (layer));
			var sibling__handle__ = sibling.GetHandle ();
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (this.Handle, selInsertSublayer_Above_XHandle, layer__handle__, sibling__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, selInsertSublayer_Above_XHandle, layer__handle__, sibling__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (layer);
			GC.KeepAlive (sibling);
			#pragma warning disable 168
			#pragma warning restore 168
		}
		/// <param name="layer">The layer being inserted.</param><param name="sibling">The existing sublayer, which will subsequently appear in front of <paramref name="layer" />.</param><summary>Inserts the specified layer into the <see cref="P:CoreAnimation.CALayer.Sublayers" /> array immediately prior to <paramref name="sibling" />.</summary><remarks>To be added.</remarks>
		[Export ("insertSublayer:below:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void InsertSublayerBelow (CALayer layer, CALayer? sibling)
		{
			var layer__handle__ = layer!.GetNonNullHandle (nameof (layer));
			var sibling__handle__ = sibling.GetHandle ();
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (this.Handle, selInsertSublayer_Below_XHandle, layer__handle__, sibling__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, selInsertSublayer_Below_XHandle, layer__handle__, sibling__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (layer);
			GC.KeepAlive (sibling);
			#pragma warning disable 168
			#pragma warning restore 168
		}
		/// <summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("layoutIfNeeded")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void LayoutIfNeeded ()
		{
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, selLayoutIfNeededXHandle);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper (&__objc_super__, selLayoutIfNeededXHandle);
					GC.KeepAlive (this);
				}
			}
		}
		/// <summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("layoutSublayers")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void LayoutSublayers ()
		{
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, selLayoutSublayersXHandle);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper (&__objc_super__, selLayoutSublayersXHandle);
					GC.KeepAlive (this);
				}
			}
		}
		/// <param name="key">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("needsDisplayForKey:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool NeedsDisplayForKey (string key)
		{
			if (key is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (key));
			var nskey = CFString.CreateNative (key);
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle (class_ptr, selNeedsDisplayForKey_XHandle, nskey);
			CFString.ReleaseNative (nskey);
			return ret != 0;
		}
		/// <summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("needsLayout")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool NeedsLayout ()
		{
			byte ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selNeedsLayoutXHandle);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, selNeedsLayoutXHandle);
					GC.KeepAlive (this);
				}
			}
			return ret != 0;
		}
		/// <summary>The preferred size for this layer, in the coordinate of its <see cref="P:CoreAnimation.CALayer.SuperLayer" />.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("preferredFrameSize")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual CGSize PreferredFrameSize ()
		{
			CGSize ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.CGSize_objc_msgSend (this.Handle, selPreferredFrameSizeXHandle);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.CGSize_objc_msgSendSuper (&__objc_super__, selPreferredFrameSizeXHandle);
					GC.KeepAlive (this);
				}
			}
			return ret;
		}
		/// <summary>Removes all animations currently attached to the layer.</summary><remarks>To be added.</remarks>
		[Export ("removeAllAnimations")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void RemoveAllAnimations ()
		{
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, selRemoveAllAnimationsXHandle);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper (&__objc_super__, selRemoveAllAnimationsXHandle);
					GC.KeepAlive (this);
				}
			}
		}
		/// <param name="key">The animation's identifier.</param><summary>Removes the specified animation from the layer.</summary><remarks>To be added.</remarks>
		[Export ("removeAnimationForKey:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void RemoveAnimation (string key)
		{
			if (key is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (key));
			var nskey = CFString.CreateNative (key);
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selRemoveAnimationForKey_XHandle, nskey);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selRemoveAnimationForKey_XHandle, nskey);
					GC.KeepAlive (this);
				}
			}
			CFString.ReleaseNative (nskey);
		}
		/// <summary>Removes <c>this</c> from its <see cref="P:CoreAnimation.CALayer.SuperLayer" />.</summary><remarks>To be added.</remarks>
		[Export ("removeFromSuperlayer")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void RemoveFromSuperLayer ()
		{
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, selRemoveFromSuperlayerXHandle);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper (&__objc_super__, selRemoveFromSuperlayerXHandle);
					GC.KeepAlive (this);
				}
			}
		}
		/// <param name="ctx">The context in which the layer should be rendered.</param><summary>Renders the layer into the specified <see cref="T:CoreGraphics.CGContext" />.</summary><remarks>To be added.</remarks>
		[Export ("renderInContext:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void RenderInContext (CGContext ctx)
		{
			var ctx__handle__ = ctx!.GetNonNullHandle (nameof (ctx));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selRenderInContext_XHandle, ctx.Handle);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selRenderInContext_XHandle, ctx.Handle);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (ctx);
		}
		/// <param name="layer">To be added.</param><param name="with">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("replaceSublayer:with:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void ReplaceSublayer (CALayer layer, CALayer with)
		{
			var layer__handle__ = layer!.GetNonNullHandle (nameof (layer));
			var with__handle__ = with!.GetNonNullHandle (nameof (with));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (this.Handle, selReplaceSublayer_With_XHandle, layer__handle__, with__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, selReplaceSublayer_With_XHandle, layer__handle__, with__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (layer);
			GC.KeepAlive (with);
			#pragma warning disable 168
			#pragma warning restore 168
		}
		/// <param name="oldSuperlayerSize">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("resizeWithOldSuperlayerSize:")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void Resize (CGSize oldSuperlayerSize)
		{
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_CGSize (this.Handle, selResizeWithOldSuperlayerSize_XHandle, oldSuperlayerSize);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_CGSize (&__objc_super__, selResizeWithOldSuperlayerSize_XHandle, oldSuperlayerSize);
					GC.KeepAlive (this);
				}
			}
		}
		/// <param name="oldSize">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("resizeSublayersWithOldSize:")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void ResizeSublayers (CGSize oldSize)
		{
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_CGSize (this.Handle, selResizeSublayersWithOldSize_XHandle, oldSize);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_CGSize (&__objc_super__, selResizeSublayersWithOldSize_XHandle, oldSize);
					GC.KeepAlive (this);
				}
			}
		}
		/// <param name="p">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("scrollPoint:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void ScrollPoint (CGPoint p)
		{
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_CGPoint (this.Handle, selScrollPoint_XHandle, p);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_CGPoint (&__objc_super__, selScrollPoint_XHandle, p);
					GC.KeepAlive (this);
				}
			}
		}
		/// <param name="r">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("scrollRectToVisible:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void ScrollRectToVisible (CGRect r)
		{
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_CGRect (this.Handle, selScrollRectToVisible_XHandle, r);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_CGRect (&__objc_super__, selScrollRectToVisible_XHandle, r);
					GC.KeepAlive (this);
				}
			}
		}
		/// <summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("setNeedsDisplay")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetNeedsDisplay ()
		{
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, selSetNeedsDisplayXHandle);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper (&__objc_super__, selSetNeedsDisplayXHandle);
					GC.KeepAlive (this);
				}
			}
		}
		/// <param name="r">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("setNeedsDisplayInRect:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetNeedsDisplayInRect (CGRect r)
		{
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_CGRect (this.Handle, selSetNeedsDisplayInRect_XHandle, r);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_CGRect (&__objc_super__, selSetNeedsDisplayInRect_XHandle, r);
					GC.KeepAlive (this);
				}
			}
		}
		/// <summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("setNeedsLayout")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetNeedsLayout ()
		{
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, selSetNeedsLayoutXHandle);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper (&__objc_super__, selSetNeedsLayoutXHandle);
					GC.KeepAlive (this);
				}
			}
		}
		/// <summary><see cref="T:Foundation.NSDictionary" /> containing the layer's actions.</summary><value><para>The default value is <see langword="null" />.</para><para tool="nullallowed">This value can be <see langword="null" />.</para></value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSDictionary? Actions {
			[Export ("actions", ArgumentSemantic.Copy)]
			get {
				NSDictionary? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSDictionary> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selActionsXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<NSDictionary> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selActionsXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setActions:", ArgumentSemantic.Copy)]
			set {
				var value__handle__ = value.GetHandle ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selSetActions_XHandle, value__handle__);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selSetActions_XHandle, value__handle__);
						GC.KeepAlive (this);
					}
				}
				GC.KeepAlive (value);
			}
		}
		/// <summary>The affine version of the layer's <see cref="P:CoreAnimation.CALayer.Transform" />.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual CGAffineTransform AffineTransform {
			[Export ("affineTransform")]
			get {
				CGAffineTransform ret;
				if (IsDirectBinding) {
					if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
						ret = global::ObjCRuntime.Messaging.CGAffineTransform_objc_msgSend (this.Handle, selAffineTransformXHandle);
					} else {
						ret = global::ObjCRuntime.Messaging.CGAffineTransform_objc_msgSend_stret (this.Handle, selAffineTransformXHandle);
					}
				} else {
					if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
						unsafe {
							var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
							ret = global::ObjCRuntime.Messaging.CGAffineTransform_objc_msgSendSuper (&__objc_super__, selAffineTransformXHandle);
							GC.KeepAlive (this);
						}
					} else {
						unsafe {
							var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
							ret = global::ObjCRuntime.Messaging.CGAffineTransform_objc_msgSendSuper_stret (&__objc_super__, selAffineTransformXHandle);
							GC.KeepAlive (this);
						}
					}
				}
				return ret!;
			}
			[Export ("setAffineTransform:")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_CGAffineTransform (this.Handle, selSetAffineTransform_XHandle, value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_CGAffineTransform (&__objc_super__, selSetAffineTransform_XHandle, value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		/// <summary>Whether edge antialiasing is allowed.</summary><value><see langword="true" /> if edge antialisting is allowed. By default, antialiasing is allowed for all edges.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public virtual bool AllowsEdgeAntialiasing {
			[Export ("allowsEdgeAntialiasing")]
			get {
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selAllowsEdgeAntialiasingXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, selAllowsEdgeAntialiasingXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
			[Export ("setAllowsEdgeAntialiasing:")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, selSetAllowsEdgeAntialiasing_XHandle, value ? (byte) 1 : (byte) 0);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (&__objc_super__, selSetAllowsEdgeAntialiasing_XHandle, value ? (byte) 1 : (byte) 0);
						GC.KeepAlive (this);
					}
				}
			}
		}
		/// <summary>Whether group opacity is allowed.</summary><value><see langword="true" /> if group opacity is allowed. By default, opacity is allowed for all groups.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public virtual bool AllowsGroupOpacity {
			[Export ("allowsGroupOpacity")]
			get {
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selAllowsGroupOpacityXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, selAllowsGroupOpacityXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
			[Export ("setAllowsGroupOpacity:")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, selSetAllowsGroupOpacity_XHandle, value ? (byte) 1 : (byte) 0);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (&__objc_super__, selSetAllowsGroupOpacity_XHandle, value ? (byte) 1 : (byte) 0);
						GC.KeepAlive (this);
					}
				}
			}
		}
		/// <summary>The anchor point for the <see cref="P:CoreAnimation.CALayer.Bounds" /> rectangle.</summary><value>The developer specifies the value for this property using the unit coordinate space. The default value for this property is (0.5, 0.5), representing the center of the bounds rectangle for this layer.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual CGPoint AnchorPoint {
			[Export ("anchorPoint")]
			get {
				CGPoint ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.CGPoint_objc_msgSend (this.Handle, selAnchorPointXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.CGPoint_objc_msgSendSuper (&__objc_super__, selAnchorPointXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[Export ("setAnchorPoint:")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_CGPoint (this.Handle, selSetAnchorPoint_XHandle, value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_CGPoint (&__objc_super__, selSetAnchorPoint_XHandle, value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		/// <summary>The anchor point for the <see cref="P:CoreAnimation.CALayer.Bounds" />, defined along the Z axis.</summary><value>The default value is 0.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual nfloat AnchorPointZ {
			[Export ("anchorPointZ")]
			get {
				nfloat ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.nfloat_objc_msgSend (this.Handle, selAnchorPointZXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.nfloat_objc_msgSendSuper (&__objc_super__, selAnchorPointZXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[Export ("setAnchorPointZ:")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_nfloat (this.Handle, selSetAnchorPointZ_XHandle, value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_nfloat (&__objc_super__, selSetAnchorPointZ_XHandle, value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		/// <summary>Identifiers for the animations associated with this layer.</summary><value><para>(More documentation for this node is coming)</para><para tool="nullallowed">This value can be <see langword="null" />.</para></value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string[]? AnimationKeys {
			[Export ("animationKeys")]
			get {
				string[] ret;
				if (IsDirectBinding) {
					ret = CFArray.StringArrayFromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selAnimationKeysXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFArray.StringArrayFromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selAnimationKeysXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool AutoReverses {
			[Export ("autoreverses")]
			get {
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selAutoreversesXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, selAutoreversesXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
			[Export ("setAutoreverses:")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, selSetAutoreverses_XHandle, value ? (byte) 1 : (byte) 0);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (&__objc_super__, selSetAutoreverses_XHandle, value ? (byte) 1 : (byte) 0);
						GC.KeepAlive (this);
					}
				}
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public virtual CAAutoresizingMask AutoresizingMask {
			[Export ("autoresizingMask")]
			get {
				CAAutoresizingMask ret;
				if (IsDirectBinding) {
					ret = (CAAutoresizingMask) global::ObjCRuntime.Messaging.UInt32_objc_msgSend (this.Handle, selAutoresizingMaskXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = (CAAutoresizingMask) global::ObjCRuntime.Messaging.UInt32_objc_msgSendSuper (&__objc_super__, selAutoresizingMaskXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[Export ("setAutoresizingMask:")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_UInt32 (this.Handle, selSetAutoresizingMask_XHandle, (UInt32)value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_UInt32 (&__objc_super__, selSetAutoresizingMask_XHandle, (UInt32)value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		/// <summary>The background color of the layer.</summary><value><para>(More documentation for this node is coming)</para><para tool="nullallowed">This value can be <see langword="null" />.</para></value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual CGColor? BackgroundColor {
			[Export ("backgroundColor")]
			get {
				CGColor ret;
				if (IsDirectBinding) {
					ret = Runtime.GetINativeObject<global::CoreGraphics.CGColor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selBackgroundColorXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = Runtime.GetINativeObject<global::CoreGraphics.CGColor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selBackgroundColorXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[Export ("setBackgroundColor:")]
			set {
				var value__handle__ = value.GetHandle ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selSetBackgroundColor_XHandle, value__handle__);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selSetBackgroundColor_XHandle, value__handle__);
						GC.KeepAlive (this);
					}
				}
				GC.KeepAlive (value);
			}
		}
		/// <summary>An array of Core Image filters that are applied to the content behind this layer.</summary><value><para>(More documentation for this node is coming)</para><para tool="nullallowed">This value can be <see langword="null" />.</para></value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual global::CoreImage.CIFilter[]? BackgroundFilters {
			[Export ("backgroundFilters", ArgumentSemantic.Copy)]
			get {
				global::CoreImage.CIFilter[]? ret;
				if (IsDirectBinding) {
					ret = CFArray.ArrayFromHandle<global::CoreImage.CIFilter>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selBackgroundFiltersXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFArray.ArrayFromHandle<global::CoreImage.CIFilter>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selBackgroundFiltersXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setBackgroundFilters:", ArgumentSemantic.Copy)]
			set {
				using var nsa_value = value is null ? null : NSArray.FromNSObjects (value);
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selSetBackgroundFilters_XHandle, nsa_value.GetHandle ());
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selSetBackgroundFilters_XHandle, nsa_value.GetHandle ());
						GC.KeepAlive (this);
					}
				}
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual double BeginTime {
			[Export ("beginTime")]
			get {
				double ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.Double_objc_msgSend (this.Handle, selBeginTimeXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.Double_objc_msgSendSuper (&__objc_super__, selBeginTimeXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[Export ("setBeginTime:")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_Double (this.Handle, selSetBeginTime_XHandle, value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_Double (&__objc_super__, selSetBeginTime_XHandle, value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		/// <summary>The color of the border of the layer.</summary><value>The default value is black.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual CGColor? BorderColor {
			[Export ("borderColor")]
			get {
				CGColor ret;
				if (IsDirectBinding) {
					ret = Runtime.GetINativeObject<global::CoreGraphics.CGColor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selBorderColorXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = Runtime.GetINativeObject<global::CoreGraphics.CGColor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selBorderColorXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[Export ("setBorderColor:")]
			set {
				var value__handle__ = value.GetHandle ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selSetBorderColor_XHandle, value__handle__);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selSetBorderColor_XHandle, value__handle__);
						GC.KeepAlive (this);
					}
				}
				GC.KeepAlive (value);
			}
		}
		/// <summary>The width of the border of the layer.</summary><value>The default value is 0.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual nfloat BorderWidth {
			[Export ("borderWidth")]
			get {
				nfloat ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.nfloat_objc_msgSend (this.Handle, selBorderWidthXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.nfloat_objc_msgSendSuper (&__objc_super__, selBorderWidthXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[Export ("setBorderWidth:")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_nfloat (this.Handle, selSetBorderWidth_XHandle, value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_nfloat (&__objc_super__, selSetBorderWidth_XHandle, value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
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
			[Export ("setBounds:")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_CGRect (this.Handle, selSetBounds_XHandle, value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_CGRect (&__objc_super__, selSetBounds_XHandle, value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		/// <summary>A Core Image filter that is used for compositing the layer and the content behind it.</summary><value><para>The default value is <see langword="null" />, causing
		/// 	  the layer to use source-over compositing.</para><para tool="nullallowed">This value can be <see langword="null" />.</para></value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSObject? CompositingFilter {
			[Export ("compositingFilter", ArgumentSemantic.Retain)]
			get {
				NSObject? ret;
				if (IsDirectBinding) {
					ret = Runtime.GetNSObject (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selCompositingFilterXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = Runtime.GetNSObject (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selCompositingFilterXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setCompositingFilter:", ArgumentSemantic.Retain)]
			set {
				var value__handle__ = value.GetHandle ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selSetCompositingFilter_XHandle, value__handle__);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selSetCompositingFilter_XHandle, value__handle__);
						GC.KeepAlive (this);
					}
				}
				GC.KeepAlive (value);
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public virtual CAConstraint[]? Constraints {
			[Export ("constraints")]
			get {
				CAConstraint[]? ret;
				if (IsDirectBinding) {
					ret = CFArray.ArrayFromHandle<CAConstraint>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selConstraintsXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFArray.ArrayFromHandle<CAConstraint>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selConstraintsXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setConstraints:")]
			set {
				using var nsa_value = value is null ? null : NSArray.FromNSObjects (value);
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selSetConstraints_XHandle, nsa_value.GetHandle ());
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selSetConstraints_XHandle, nsa_value.GetHandle ());
						GC.KeepAlive (this);
					}
				}
			}
		}
		/// <summary>The contents of this layer, as a <see cref="T:CoreGraphics.CGImage" />.</summary><remarks>To get or set this property using a different type, call <see cref="GetContentsAs&lt;T&gt;()" /> or <see cref="SetContents(NSObject)" />.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[DebuggerBrowsable (DebuggerBrowsableState.Never)]
		public virtual CGImage? Contents {
			[Export ("contents", ArgumentSemantic.Retain)]
			get {
				CGImage ret;
				if (IsDirectBinding) {
					ret = Runtime.GetINativeObject<global::CoreGraphics.CGImage> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selContentsXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = Runtime.GetINativeObject<global::CoreGraphics.CGImage> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selContentsXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[Export ("setContents:", ArgumentSemantic.Retain)]
			set {
				var value__handle__ = value.GetHandle ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selSetContents_XHandle, value__handle__);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selSetContents_XHandle, value__handle__);
						GC.KeepAlive (this);
					}
				}
				GC.KeepAlive (value);
			}
		}
		/// <summary>Whether the layer's contents are implicitly flipped when the layer is rendered.</summary><value>The default value is <see langword="false" />.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool ContentsAreFlipped {
			[Export ("contentsAreFlipped")]
			get {
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selContentsAreFlippedXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, selContentsAreFlippedXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual CGRect ContentsCenter {
			[Export ("contentsCenter")]
			get {
				CGRect ret;
				if (IsDirectBinding) {
					if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
						ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSend (this.Handle, selContentsCenterXHandle);
					} else {
						ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSend_stret (this.Handle, selContentsCenterXHandle);
					}
				} else {
					if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
						unsafe {
							var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
							ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSendSuper (&__objc_super__, selContentsCenterXHandle);
							GC.KeepAlive (this);
						}
					} else {
						unsafe {
							var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
							ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSendSuper_stret (&__objc_super__, selContentsCenterXHandle);
							GC.KeepAlive (this);
						}
					}
				}
				return ret!;
			}
			[Export ("setContentsCenter:")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_CGRect (this.Handle, selSetContentsCenter_XHandle, value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_CGRect (&__objc_super__, selSetContentsCenter_XHandle, value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string ContentsGravity {
			[Export ("contentsGravity", ArgumentSemantic.Copy)]
			get {
				string ret;
				if (IsDirectBinding) {
					ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selContentsGravityXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selContentsGravityXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[Export ("setContentsGravity:", ArgumentSemantic.Copy)]
			set {
				if (value is null)
					ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (value));
				var nsvalue = CFString.CreateNative (value);
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selSetContentsGravity_XHandle, nsvalue);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selSetContentsGravity_XHandle, nsvalue);
						GC.KeepAlive (this);
					}
				}
				CFString.ReleaseNative (nsvalue);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("tvos26.0")]
		[SupportedOSPlatform ("maccatalyst26.0")]
		[SupportedOSPlatform ("macos26.0")]
		[SupportedOSPlatform ("ios26.0")]
		public virtual nfloat ContentsHeadroom {
			[Export ("contentsHeadroom")]
			get {
				nfloat ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.nfloat_objc_msgSend (this.Handle, selContentsHeadroomXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.nfloat_objc_msgSendSuper (&__objc_super__, selContentsHeadroomXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[Export ("setContentsHeadroom:")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_nfloat (this.Handle, selSetContentsHeadroom_XHandle, value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_nfloat (&__objc_super__, selSetContentsHeadroom_XHandle, value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual CGRect ContentsRect {
			[Export ("contentsRect")]
			get {
				CGRect ret;
				if (IsDirectBinding) {
					if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
						ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSend (this.Handle, selContentsRectXHandle);
					} else {
						ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSend_stret (this.Handle, selContentsRectXHandle);
					}
				} else {
					if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
						unsafe {
							var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
							ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSendSuper (&__objc_super__, selContentsRectXHandle);
							GC.KeepAlive (this);
						}
					} else {
						unsafe {
							var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
							ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSendSuper_stret (&__objc_super__, selContentsRectXHandle);
							GC.KeepAlive (this);
						}
					}
				}
				return ret!;
			}
			[Export ("setContentsRect:")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_CGRect (this.Handle, selSetContentsRect_XHandle, value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_CGRect (&__objc_super__, selSetContentsRect_XHandle, value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		/// <summary>The scale factor applied to the layer.</summary><value>The default value is 1.0.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual nfloat ContentsScale {
			[Export ("contentsScale")]
			get {
				nfloat ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.nfloat_objc_msgSend (this.Handle, selContentsScaleXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.nfloat_objc_msgSendSuper (&__objc_super__, selContentsScaleXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[Export ("setContentsScale:")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_nfloat (this.Handle, selSetContentsScale_XHandle, value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_nfloat (&__objc_super__, selSetContentsScale_XHandle, value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("tvos13.0")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindAs (typeof (CACornerCurve), OriginalType = typeof (NSString))]
		public virtual global::CoreAnimation.CACornerCurve CornerCurve {
			[Export ("cornerCurve")]
			get {
				global::CoreAnimation.CACornerCurve ret;
				if (IsDirectBinding) {
					ret = global::CoreAnimation.CACornerCurveExtensions.GetValue (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selCornerCurveXHandle));
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::CoreAnimation.CACornerCurveExtensions.GetValue (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selCornerCurveXHandle));
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setCornerCurve:")]
			set {
				using var nsb_CornerCurve = global::CoreAnimation.CACornerCurveExtensions.GetConstant (value);
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selSetCornerCurve_XHandle, nsb_CornerCurve.GetHandle ());
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selSetCornerCurve_XHandle, nsb_CornerCurve.GetHandle ());
						GC.KeepAlive (this);
					}
				}
			}
		}
		/// <summary>The radius used when drawing rounded corners.</summary><value>The default value is 0.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual nfloat CornerRadius {
			[Export ("cornerRadius")]
			get {
				nfloat ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.nfloat_objc_msgSend (this.Handle, selCornerRadiusXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.nfloat_objc_msgSendSuper (&__objc_super__, selCornerRadiusXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[Export ("setCornerRadius:")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_nfloat (this.Handle, selSetCornerRadius_XHandle, value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_nfloat (&__objc_super__, selSetCornerRadius_XHandle, value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		/// <summary>An instance of the CoreAnimation.ICALayerDelegate model class which acts as the class delegate.</summary><value>The instance of the CoreAnimation.ICALayerDelegate model class</value><remarks><para>The delegate instance assigned to this object will be used to handle events or provide data on demand to this class.</para><para>When setting the Delegate or WeakDelegate values events will be delivered to the specified instance instead of being delivered to the C#-style events</para><para>This is the strongly typed version of the object, developers should use the WeakDelegate property instead if they want to merely assign a class derived from NSObject that has been decorated with [Export] attributes.</para></remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public ICALayerDelegate Delegate {
			get {
				return (WeakDelegate as ICALayerDelegate)!;
			}
			set {
				var rvalue = value as NSObject;
				if (!(value is null) && rvalue is null)
					throw new ArgumentException ("The object passed of type " + value.GetType () + " does not derive from NSObject");
				WeakDelegate = rvalue;
			}
		}
		/// <summary>Whether the layer draws its content when facing away from the viewer.</summary><value>The default value is <see langword="true" />.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool DoubleSided {
			[Export ("isDoubleSided")]
			get {
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selIsDoubleSidedXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, selIsDoubleSidedXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
			[Export ("setDoubleSided:")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, selSetDoubleSided_XHandle, value ? (byte) 1 : (byte) 0);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (&__objc_super__, selSetDoubleSided_XHandle, value ? (byte) 1 : (byte) 0);
						GC.KeepAlive (this);
					}
				}
			}
		}
		/// <summary>Whether drawing commands are deferred and processed asynchronously on a background thread.</summary><value>The default value is <see langword="false" />.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool DrawsAsynchronously {
			[Export ("drawsAsynchronously")]
			get {
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selDrawsAsynchronouslyXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, selDrawsAsynchronouslyXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
			[Export ("setDrawsAsynchronously:")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, selSetDrawsAsynchronously_XHandle, value ? (byte) 1 : (byte) 0);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (&__objc_super__, selSetDrawsAsynchronously_XHandle, value ? (byte) 1 : (byte) 0);
						GC.KeepAlive (this);
					}
				}
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual double Duration {
			[Export ("duration")]
			get {
				double ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.Double_objc_msgSend (this.Handle, selDurationXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.Double_objc_msgSendSuper (&__objc_super__, selDurationXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[Export ("setDuration:")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_Double (this.Handle, selSetDuration_XHandle, value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_Double (&__objc_super__, selSetDuration_XHandle, value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual CAEdgeAntialiasingMask EdgeAntialiasingMask {
			[Export ("edgeAntialiasingMask")]
			get {
				CAEdgeAntialiasingMask ret;
				if (IsDirectBinding) {
					ret = (CAEdgeAntialiasingMask) global::ObjCRuntime.Messaging.UInt32_objc_msgSend (this.Handle, selEdgeAntialiasingMaskXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = (CAEdgeAntialiasingMask) global::ObjCRuntime.Messaging.UInt32_objc_msgSendSuper (&__objc_super__, selEdgeAntialiasingMaskXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[Export ("setEdgeAntialiasingMask:")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_UInt32 (this.Handle, selSetEdgeAntialiasingMask_XHandle, (UInt32)value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_UInt32 (&__objc_super__, selSetEdgeAntialiasingMask_XHandle, (UInt32)value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string FillMode {
			[Export ("fillMode", ArgumentSemantic.Copy)]
			get {
				string ret;
				if (IsDirectBinding) {
					ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selFillModeXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selFillModeXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[Export ("setFillMode:", ArgumentSemantic.Copy)]
			set {
				if (value is null)
					ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (value));
				var nsvalue = CFString.CreateNative (value);
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selSetFillMode_XHandle, nsvalue);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selSetFillMode_XHandle, nsvalue);
						GC.KeepAlive (this);
					}
				}
				CFString.ReleaseNative (nsvalue);
			}
		}
		/// <summary>An array of Core Image filters applied to the content of this layer and its sublayers.</summary><value><para>The default value is <see langword="null" />.</para><para tool="nullallowed">This value can be <see langword="null" />.</para></value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual global::CoreImage.CIFilter[]? Filters {
			[Export ("filters", ArgumentSemantic.Copy)]
			get {
				global::CoreImage.CIFilter[]? ret;
				if (IsDirectBinding) {
					ret = CFArray.ArrayFromHandle<global::CoreImage.CIFilter>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selFiltersXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFArray.ArrayFromHandle<global::CoreImage.CIFilter>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selFiltersXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setFilters:", ArgumentSemantic.Copy)]
			set {
				using var nsa_value = value is null ? null : NSArray.FromNSObjects (value);
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selSetFilters_XHandle, nsa_value.GetHandle ());
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selSetFilters_XHandle, nsa_value.GetHandle ());
						GC.KeepAlive (this);
					}
				}
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual CGRect Frame {
			[Export ("frame")]
			get {
				CGRect ret;
				if (IsDirectBinding) {
					if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
						ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSend (this.Handle, selFrameXHandle);
					} else {
						ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSend_stret (this.Handle, selFrameXHandle);
					}
				} else {
					if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
						unsafe {
							var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
							ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSendSuper (&__objc_super__, selFrameXHandle);
							GC.KeepAlive (this);
						}
					} else {
						unsafe {
							var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
							ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSendSuper_stret (&__objc_super__, selFrameXHandle);
							GC.KeepAlive (this);
						}
					}
				}
				return ret!;
			}
			[Export ("setFrame:")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_CGRect (this.Handle, selSetFrame_XHandle, value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_CGRect (&__objc_super__, selSetFrame_XHandle, value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool GeometryFlipped {
			[Export ("isGeometryFlipped")]
			get {
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selIsGeometryFlippedXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, selIsGeometryFlippedXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
			[Export ("setGeometryFlipped:")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, selSetGeometryFlipped_XHandle, value ? (byte) 1 : (byte) 0);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (&__objc_super__, selSetGeometryFlipped_XHandle, value ? (byte) 1 : (byte) 0);
						GC.KeepAlive (this);
					}
				}
			}
		}
		/// <summary>Whether the layer is not displayed.</summary><value>The default value is <see langword="false" />.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool Hidden {
			[Export ("isHidden")]
			get {
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selIsHiddenXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, selIsHiddenXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
			[Export ("setHidden:")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, selSetHidden_XHandle, value ? (byte) 1 : (byte) 0);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (&__objc_super__, selSetHidden_XHandle, value ? (byte) 1 : (byte) 0);
						GC.KeepAlive (this);
					}
				}
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public virtual NSObject? LayoutManager {
			[Export ("layoutManager", ArgumentSemantic.Retain)]
			get {
				NSObject? ret;
				if (IsDirectBinding) {
					ret = Runtime.GetNSObject (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selLayoutManagerXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = Runtime.GetNSObject (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selLayoutManagerXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setLayoutManager:", ArgumentSemantic.Retain)]
			set {
				var value__handle__ = value.GetHandle ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selSetLayoutManager_XHandle, value__handle__);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selSetLayoutManager_XHandle, value__handle__);
						GC.KeepAlive (this);
					}
				}
				GC.KeepAlive (value);
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string MagnificationFilter {
			[Export ("magnificationFilter", ArgumentSemantic.Copy)]
			get {
				string ret;
				if (IsDirectBinding) {
					ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selMagnificationFilterXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selMagnificationFilterXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[Export ("setMagnificationFilter:", ArgumentSemantic.Copy)]
			set {
				if (value is null)
					ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (value));
				var nsvalue = CFString.CreateNative (value);
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selSetMagnificationFilter_XHandle, nsvalue);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selSetMagnificationFilter_XHandle, nsvalue);
						GC.KeepAlive (this);
					}
				}
				CFString.ReleaseNative (nsvalue);
			}
		}
		/// <summary>An optional layer, the alpha channel of which is used to mask the contents of this layer.</summary><value><para>(More documentation for this node is coming)</para><para tool="nullallowed">This value can be <see langword="null" />.</para></value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual CALayer? Mask {
			[Export ("mask", ArgumentSemantic.Retain)]
			get {
				CALayer? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<CALayer> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selMaskXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<CALayer> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selMaskXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setMask:", ArgumentSemantic.Retain)]
			set {
				var value__handle__ = value.GetHandle ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selSetMask_XHandle, value__handle__);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selSetMask_XHandle, value__handle__);
						GC.KeepAlive (this);
					}
				}
				GC.KeepAlive (value);
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public virtual CACornerMask MaskedCorners {
			[Export ("maskedCorners", ArgumentSemantic.Assign)]
			get {
				CACornerMask ret;
				if (IsDirectBinding) {
					ret = (CACornerMask) (ulong) global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend (this.Handle, selMaskedCornersXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = (CACornerMask) (ulong) global::ObjCRuntime.Messaging.UIntPtr_objc_msgSendSuper (&__objc_super__, selMaskedCornersXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setMaskedCorners:", ArgumentSemantic.Assign)]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_UIntPtr (this.Handle, selSetMaskedCorners_XHandle, (UIntPtr) (ulong) value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_UIntPtr (&__objc_super__, selSetMaskedCorners_XHandle, (UIntPtr) (ulong) value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		/// <summary>Whether sublayers are clipped to the <see cref="P:CoreAnimation.CALayer.Bounds" /> of this layer.</summary><value>The default value is <see langword="false" />.</value><remarks>If <see langword="true" />, the clipping mask matches the bounds of <c>this</c><see cref="T:CoreAnimation.CALayer" />, including rounded corners.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool MasksToBounds {
			[Export ("masksToBounds")]
			get {
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selMasksToBoundsXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, selMasksToBoundsXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
			[Export ("setMasksToBounds:")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, selSetMasksToBounds_XHandle, value ? (byte) 1 : (byte) 0);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (&__objc_super__, selSetMasksToBounds_XHandle, value ? (byte) 1 : (byte) 0);
						GC.KeepAlive (this);
					}
				}
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string MinificationFilter {
			[Export ("minificationFilter", ArgumentSemantic.Copy)]
			get {
				string ret;
				if (IsDirectBinding) {
					ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selMinificationFilterXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selMinificationFilterXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[Export ("setMinificationFilter:", ArgumentSemantic.Copy)]
			set {
				if (value is null)
					ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (value));
				var nsvalue = CFString.CreateNative (value);
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selSetMinificationFilter_XHandle, nsvalue);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selSetMinificationFilter_XHandle, nsvalue);
						GC.KeepAlive (this);
					}
				}
				CFString.ReleaseNative (nsvalue);
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual float MinificationFilterBias {
			[Export ("minificationFilterBias")]
			get {
				float ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.float_objc_msgSend (this.Handle, selMinificationFilterBiasXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.float_objc_msgSendSuper (&__objc_super__, selMinificationFilterBiasXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[Export ("setMinificationFilterBias:")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_float (this.Handle, selSetMinificationFilterBias_XHandle, value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_float (&__objc_super__, selSetMinificationFilterBias_XHandle, value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual CALayer ModelLayer {
			[Export ("modelLayer")]
			get {
				CALayer? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<CALayer> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selModelLayerXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<CALayer> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selModelLayerXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		/// <summary>To be added.</summary><value><para>(More documentation for this node is coming)</para><para tool="nullallowed">This value can be <see langword="null" />.</para></value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string? Name {
			[Export ("name", ArgumentSemantic.Copy)]
			get {
				string ret;
				if (IsDirectBinding) {
					ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selNameXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selNameXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[Export ("setName:", ArgumentSemantic.Copy)]
			set {
				var nsvalue = CFString.CreateNative (value);
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selSetName_XHandle, nsvalue);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selSetName_XHandle, nsvalue);
						GC.KeepAlive (this);
					}
				}
				CFString.ReleaseNative (nsvalue);
			}
		}
		/// <summary>Whether the layer has been marked as requiring an update.</summary><value><see langword="true" /> if the layer has been marked as requiring an update.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool NeedsDisplay {
			[Export ("needsDisplay")]
			get {
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selNeedsDisplayXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, selNeedsDisplayXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool NeedsDisplayOnBoundsChange {
			[Export ("needsDisplayOnBoundsChange")]
			get {
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selNeedsDisplayOnBoundsChangeXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, selNeedsDisplayOnBoundsChangeXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
			[Export ("setNeedsDisplayOnBoundsChange:")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, selSetNeedsDisplayOnBoundsChange_XHandle, value ? (byte) 1 : (byte) 0);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (&__objc_super__, selSetNeedsDisplayOnBoundsChange_XHandle, value ? (byte) 1 : (byte) 0);
						GC.KeepAlive (this);
					}
				}
			}
		}
		/// <summary>The transparency of the layer, in the range 0 (transparent) to 1.0 (opaque).</summary><value>The default value is 1.0.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual float Opacity {
			[Export ("opacity")]
			get {
				float ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.float_objc_msgSend (this.Handle, selOpacityXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.float_objc_msgSendSuper (&__objc_super__, selOpacityXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[Export ("setOpacity:")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_float (this.Handle, selSetOpacity_XHandle, value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_float (&__objc_super__, selSetOpacity_XHandle, value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		/// <summary>Whether the layer and its contents are completely opaque.</summary><value>The default value is <see langword="false" />. If <see langword="true" />, the system can render the layer more quickly.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool Opaque {
			[Export ("isOpaque")]
			get {
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selIsOpaqueXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, selIsOpaqueXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
			[Export ("setOpaque:")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, selSetOpaque_XHandle, value ? (byte) 1 : (byte) 0);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (&__objc_super__, selSetOpaque_XHandle, value ? (byte) 1 : (byte) 0);
						GC.KeepAlive (this);
					}
				}
			}
		}
		/// <summary>The layer's position in the coordinate space of its <see cref="P:CoreAnimation.CALayer.SuperLayer" />.</summary><value>The default is (0,0). This value is specified in points relative to the layer's <see cref="P:CoreAnimation.CALayer.AnchorPoint" />.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual CGPoint Position {
			[Export ("position")]
			get {
				CGPoint ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.CGPoint_objc_msgSend (this.Handle, selPositionXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.CGPoint_objc_msgSendSuper (&__objc_super__, selPositionXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[Export ("setPosition:")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_CGPoint (this.Handle, selSetPosition_XHandle, value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_CGPoint (&__objc_super__, selSetPosition_XHandle, value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("tvos26.0")]
		[SupportedOSPlatform ("maccatalyst26.0")]
		[SupportedOSPlatform ("macos26.0")]
		[SupportedOSPlatform ("ios26.0")]
		public virtual CADynamicRange PreferredDynamicRange {
			[SupportedOSPlatform ("tvos26.0")]
			[SupportedOSPlatform ("maccatalyst26.0")]
			[SupportedOSPlatform ("macos26.0")]
			[SupportedOSPlatform ("ios26.0")]
			get {
				return CADynamicRangeExtensions.GetValue (WeakPreferredDynamicRange);
			}
			[SupportedOSPlatform ("tvos26.0")]
			[SupportedOSPlatform ("maccatalyst26.0")]
			[SupportedOSPlatform ("macos26.0")]
			[SupportedOSPlatform ("ios26.0")]
			set {
				WeakPreferredDynamicRange = value.GetConstant ()!;
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual CALayer? PresentationLayer {
			[Export ("presentationLayer")]
			get {
				CALayer? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<CALayer> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selPresentationLayerXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<CALayer> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selPresentationLayerXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual nfloat RasterizationScale {
			[Export ("rasterizationScale")]
			get {
				nfloat ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.nfloat_objc_msgSend (this.Handle, selRasterizationScaleXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.nfloat_objc_msgSendSuper (&__objc_super__, selRasterizationScaleXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[Export ("setRasterizationScale:")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_nfloat (this.Handle, selSetRasterizationScale_XHandle, value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_nfloat (&__objc_super__, selSetRasterizationScale_XHandle, value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual float RepeatCount {
			[Export ("repeatCount")]
			get {
				float ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.float_objc_msgSend (this.Handle, selRepeatCountXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.float_objc_msgSendSuper (&__objc_super__, selRepeatCountXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[Export ("setRepeatCount:")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_float (this.Handle, selSetRepeatCount_XHandle, value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_float (&__objc_super__, selSetRepeatCount_XHandle, value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual double RepeatDuration {
			[Export ("repeatDuration")]
			get {
				double ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.Double_objc_msgSend (this.Handle, selRepeatDurationXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.Double_objc_msgSendSuper (&__objc_super__, selRepeatDurationXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[Export ("setRepeatDuration:")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_Double (this.Handle, selSetRepeatDuration_XHandle, value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_Double (&__objc_super__, selSetRepeatDuration_XHandle, value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual CGColor? ShadowColor {
			[Export ("shadowColor")]
			get {
				CGColor ret;
				if (IsDirectBinding) {
					ret = Runtime.GetINativeObject<global::CoreGraphics.CGColor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selShadowColorXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = Runtime.GetINativeObject<global::CoreGraphics.CGColor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selShadowColorXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[Export ("setShadowColor:")]
			set {
				var value__handle__ = value.GetHandle ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selSetShadowColor_XHandle, value__handle__);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selSetShadowColor_XHandle, value__handle__);
						GC.KeepAlive (this);
					}
				}
				GC.KeepAlive (value);
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual CGSize ShadowOffset {
			[Export ("shadowOffset")]
			get {
				CGSize ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.CGSize_objc_msgSend (this.Handle, selShadowOffsetXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.CGSize_objc_msgSendSuper (&__objc_super__, selShadowOffsetXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[Export ("setShadowOffset:")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_CGSize (this.Handle, selSetShadowOffset_XHandle, value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_CGSize (&__objc_super__, selSetShadowOffset_XHandle, value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual float ShadowOpacity {
			[Export ("shadowOpacity")]
			get {
				float ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.float_objc_msgSend (this.Handle, selShadowOpacityXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.float_objc_msgSendSuper (&__objc_super__, selShadowOpacityXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[Export ("setShadowOpacity:")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_float (this.Handle, selSetShadowOpacity_XHandle, value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_float (&__objc_super__, selSetShadowOpacity_XHandle, value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		/// <summary>To be added.</summary><value><para>(More documentation for this node is coming)</para><para tool="nullallowed">This value can be <see langword="null" />.</para></value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual CGPath? ShadowPath {
			[Export ("shadowPath")]
			get {
				CGPath ret;
				if (IsDirectBinding) {
					ret = Runtime.GetINativeObject<global::CoreGraphics.CGPath> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selShadowPathXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = Runtime.GetINativeObject<global::CoreGraphics.CGPath> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selShadowPathXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[Export ("setShadowPath:")]
			set {
				var value__handle__ = value.GetHandle ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selSetShadowPath_XHandle, value__handle__);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selSetShadowPath_XHandle, value__handle__);
						GC.KeepAlive (this);
					}
				}
				GC.KeepAlive (value);
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual nfloat ShadowRadius {
			[Export ("shadowRadius")]
			get {
				nfloat ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.nfloat_objc_msgSend (this.Handle, selShadowRadiusXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.nfloat_objc_msgSendSuper (&__objc_super__, selShadowRadiusXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[Export ("setShadowRadius:")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_nfloat (this.Handle, selSetShadowRadius_XHandle, value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_nfloat (&__objc_super__, selSetShadowRadius_XHandle, value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool ShouldRasterize {
			[Export ("shouldRasterize")]
			get {
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selShouldRasterizeXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, selShouldRasterizeXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
			[Export ("setShouldRasterize:")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, selSetShouldRasterize_XHandle, value ? (byte) 1 : (byte) 0);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (&__objc_super__, selSetShouldRasterize_XHandle, value ? (byte) 1 : (byte) 0);
						GC.KeepAlive (this);
					}
				}
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual float Speed {
			[Export ("speed")]
			get {
				float ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.float_objc_msgSend (this.Handle, selSpeedXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.float_objc_msgSendSuper (&__objc_super__, selSpeedXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[Export ("setSpeed:")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_float (this.Handle, selSetSpeed_XHandle, value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_float (&__objc_super__, selSetSpeed_XHandle, value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		/// <summary>To be added.</summary><value><para>(More documentation for this node is coming)</para><para tool="nullallowed">This value can be <see langword="null" />.</para></value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSDictionary? Style {
			[Export ("style", ArgumentSemantic.Copy)]
			get {
				NSDictionary? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSDictionary> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selStyleXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<NSDictionary> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selStyleXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setStyle:", ArgumentSemantic.Copy)]
			set {
				var value__handle__ = value.GetHandle ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selSetStyle_XHandle, value__handle__);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selSetStyle_XHandle, value__handle__);
						GC.KeepAlive (this);
					}
				}
				GC.KeepAlive (value);
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual CATransform3D SublayerTransform {
			[Export ("sublayerTransform")]
			get {
				CATransform3D ret;
				if (IsDirectBinding) {
					if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
						ret = global::ObjCRuntime.Messaging.CATransform3D_objc_msgSend (this.Handle, selSublayerTransformXHandle);
					} else {
						ret = global::ObjCRuntime.Messaging.CATransform3D_objc_msgSend_stret (this.Handle, selSublayerTransformXHandle);
					}
				} else {
					if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
						unsafe {
							var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
							ret = global::ObjCRuntime.Messaging.CATransform3D_objc_msgSendSuper (&__objc_super__, selSublayerTransformXHandle);
							GC.KeepAlive (this);
						}
					} else {
						unsafe {
							var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
							ret = global::ObjCRuntime.Messaging.CATransform3D_objc_msgSendSuper_stret (&__objc_super__, selSublayerTransformXHandle);
							GC.KeepAlive (this);
						}
					}
				}
				return ret!;
			}
			[Export ("setSublayerTransform:")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_CATransform3D (this.Handle, selSetSublayerTransform_XHandle, value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_CATransform3D (&__objc_super__, selSetSublayerTransform_XHandle, value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		/// <summary>To be added.</summary><value><para>(More documentation for this node is coming)</para><para tool="nullallowed">This value can be <see langword="null" />.</para></value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual CALayer[]? Sublayers {
			[Export ("sublayers", ArgumentSemantic.Copy)]
			get {
				CALayer[]? ret;
				if (IsDirectBinding) {
					ret = CFArray.ArrayFromHandle<CALayer>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selSublayersXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFArray.ArrayFromHandle<CALayer>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selSublayersXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setSublayers:", ArgumentSemantic.Copy)]
			set {
				using var nsa_value = value is null ? null : NSArray.FromNSObjects (value);
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selSetSublayers_XHandle, nsa_value.GetHandle ());
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selSetSublayers_XHandle, nsa_value.GetHandle ());
						GC.KeepAlive (this);
					}
				}
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual CALayer? SuperLayer {
			[Export ("superlayer")]
			get {
				CALayer? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<CALayer> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selSuperlayerXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<CALayer> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selSuperlayerXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual double TimeOffset {
			[Export ("timeOffset")]
			get {
				double ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.Double_objc_msgSend (this.Handle, selTimeOffsetXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.Double_objc_msgSendSuper (&__objc_super__, selTimeOffsetXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[Export ("setTimeOffset:")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_Double (this.Handle, selSetTimeOffset_XHandle, value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_Double (&__objc_super__, selSetTimeOffset_XHandle, value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("macos15.0")]
		[SupportedOSPlatform ("ios18.0")]
		[SupportedOSPlatform ("tvos18.0")]
		[SupportedOSPlatform ("maccatalyst18.0")]
		[BindAs (typeof (CAToneMapMode), OriginalType = typeof (NSString))]
		public virtual global::CoreAnimation.CAToneMapMode ToneMapMode {
			[Export ("toneMapMode")]
			get {
				global::CoreAnimation.CAToneMapMode ret;
				if (IsDirectBinding) {
					ret = global::CoreAnimation.CAToneMapModeExtensions.GetValue (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selToneMapModeXHandle));
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::CoreAnimation.CAToneMapModeExtensions.GetValue (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selToneMapModeXHandle));
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setToneMapMode:")]
			set {
				using var nsb_ToneMapMode = global::CoreAnimation.CAToneMapModeExtensions.GetConstant (value);
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selSetToneMapMode_XHandle, nsb_ToneMapMode.GetHandle ());
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selSetToneMapMode_XHandle, nsb_ToneMapMode.GetHandle ());
						GC.KeepAlive (this);
					}
				}
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual CATransform3D Transform {
			[Export ("transform")]
			get {
				CATransform3D ret;
				if (IsDirectBinding) {
					if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
						ret = global::ObjCRuntime.Messaging.CATransform3D_objc_msgSend (this.Handle, selTransformXHandle);
					} else {
						ret = global::ObjCRuntime.Messaging.CATransform3D_objc_msgSend_stret (this.Handle, selTransformXHandle);
					}
				} else {
					if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
						unsafe {
							var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
							ret = global::ObjCRuntime.Messaging.CATransform3D_objc_msgSendSuper (&__objc_super__, selTransformXHandle);
							GC.KeepAlive (this);
						}
					} else {
						unsafe {
							var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
							ret = global::ObjCRuntime.Messaging.CATransform3D_objc_msgSendSuper_stret (&__objc_super__, selTransformXHandle);
							GC.KeepAlive (this);
						}
					}
				}
				return ret!;
			}
			[Export ("setTransform:")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_CATransform3D (this.Handle, selSetTransform_XHandle, value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_CATransform3D (&__objc_super__, selSetTransform_XHandle, value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual CGRect VisibleRect {
			[Export ("visibleRect")]
			get {
				CGRect ret;
				if (IsDirectBinding) {
					if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
						ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSend (this.Handle, selVisibleRectXHandle);
					} else {
						ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSend_stret (this.Handle, selVisibleRectXHandle);
					}
				} else {
					if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
						unsafe {
							var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
							ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSendSuper (&__objc_super__, selVisibleRectXHandle);
							GC.KeepAlive (this);
						}
					} else {
						unsafe {
							var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
							ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSendSuper_stret (&__objc_super__, selVisibleRectXHandle);
							GC.KeepAlive (this);
						}
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[UnsupportedOSPlatform ("ios26.0", "Use 'PreferredDynamicRange' instead.")]
		[UnsupportedOSPlatform ("maccatalyst26.0", "Use 'PreferredDynamicRange' instead.")]
		[UnsupportedOSPlatform ("macos26.0", "Use 'PreferredDynamicRange' instead.")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios17.0")]
		[SupportedOSPlatform ("maccatalyst17.0")]
		[SupportedOSPlatform ("macos14.0")]
		public virtual bool WantsExtendedDynamicRangeContent {
			[Export ("wantsExtendedDynamicRangeContent")]
			get {
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selWantsExtendedDynamicRangeContentXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, selWantsExtendedDynamicRangeContentXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
			[Export ("setWantsExtendedDynamicRangeContent:")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, selSetWantsExtendedDynamicRangeContent_XHandle, value ? (byte) 1 : (byte) 0);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (&__objc_super__, selSetWantsExtendedDynamicRangeContent_XHandle, value ? (byte) 1 : (byte) 0);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		object? __mt_WeakDelegate_var;
		/// <summary>An object that can respond to the delegate protocol for this type</summary><value>The instance that will respond to events and data requests.</value><remarks><para>The delegate instance assigned to this object will be used to handle events or provide data on demand to this class.</para><para>When setting the Delegate or WeakDelegate values events will be delivered to the specified instance instead of being delivered to the C#-style events</para><para>   Methods must be decorated with the [Export ("selectorName")] attribute to respond to each method from the protocol.   Alternatively use the Delegate method which is strongly typed and does not require the [Export] attributes on methods.</para></remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSObject? WeakDelegate {
			[Export ("delegate", ArgumentSemantic.Weak)]
			get {
				NSObject? ret;
				if (IsDirectBinding) {
					ret = Runtime.GetNSObject (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selDelegateXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = Runtime.GetNSObject (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selDelegateXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				MarkDirty ();
				__mt_WeakDelegate_var = ret;
				return ret!;
			}
			[Export ("setDelegate:", ArgumentSemantic.Weak)]
			set {
				var value__handle__ = value.GetHandle ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selSetDelegate_XHandle, value__handle__);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selSetDelegate_XHandle, value__handle__);
						GC.KeepAlive (this);
					}
				}
				SetCALayerDelegate (value as CALayerDelegate);
				GC.KeepAlive (value);
				MarkDirty ();
				__mt_WeakDelegate_var = value;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("tvos26.0")]
		[SupportedOSPlatform ("maccatalyst26.0")]
		[SupportedOSPlatform ("macos26.0")]
		[SupportedOSPlatform ("ios26.0")]
		public virtual NSString WeakPreferredDynamicRange {
			[Export ("preferredDynamicRange", ArgumentSemantic.Copy)]
			get {
				NSString? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSString> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selPreferredDynamicRangeXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<NSString> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selPreferredDynamicRangeXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setPreferredDynamicRange:", ArgumentSemantic.Copy)]
			set {
				var value__handle__ = value!.GetNonNullHandle (nameof (value));
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selSetPreferredDynamicRange_XHandle, value__handle__);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selSetPreferredDynamicRange_XHandle, value__handle__);
						GC.KeepAlive (this);
					}
				}
				GC.KeepAlive (value);
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual nfloat ZPosition {
			[Export ("zPosition")]
			get {
				nfloat ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.nfloat_objc_msgSend (this.Handle, selZPositionXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.nfloat_objc_msgSendSuper (&__objc_super__, selZPositionXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[Export ("setZPosition:")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_nfloat (this.Handle, selSetZPosition_XHandle, value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_nfloat (&__objc_super__, selSetZPosition_XHandle, value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal nint _Contents {
			get {
				nint ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selContentsXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (&__objc_super__, selContentsXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetContents_XHandle, value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (&__objc_super__, selSetContents_XHandle, value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		internal virtual NSString _ContentsFormat {
			[Export ("contentsFormat")]
			get {
				NSString? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSString> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selContentsFormatXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<NSString> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selContentsFormatXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setContentsFormat:")]
			set {
				var value__handle__ = value!.GetNonNullHandle (nameof (value));
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selSetContentsFormat_XHandle, value__handle__);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selSetContentsFormat_XHandle, value__handle__);
						GC.KeepAlive (this);
					}
				}
				GC.KeepAlive (value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _FilterLinear;
		/// <summary>Represents the value associated with the constant kCAFilterLinear</summary><value></value><remarks>To be added.</remarks>
		[Field ("kCAFilterLinear",  "CoreAnimation")]
		public static NSString FilterLinear {
			get {
				if (_FilterLinear is null)
					_FilterLinear = Dlfcn.GetStringConstant (Libraries.CoreAnimation.Handle, "kCAFilterLinear")!;
				return _FilterLinear;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _FilterNearest;
		/// <summary>Represents the value associated with the constant kCAFilterNearest</summary><value></value><remarks>To be added.</remarks>
		[Field ("kCAFilterNearest",  "CoreAnimation")]
		public static NSString FilterNearest {
			get {
				if (_FilterNearest is null)
					_FilterNearest = Dlfcn.GetStringConstant (Libraries.CoreAnimation.Handle, "kCAFilterNearest")!;
				return _FilterNearest;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _FilterTrilinear;
		/// <summary>Represents the value associated with the constant kCAFilterTrilinear</summary><value></value><remarks>To be added.</remarks>
		[Field ("kCAFilterTrilinear",  "CoreAnimation")]
		public static NSString FilterTrilinear {
			get {
				if (_FilterTrilinear is null)
					_FilterTrilinear = Dlfcn.GetStringConstant (Libraries.CoreAnimation.Handle, "kCAFilterTrilinear")!;
				return _FilterTrilinear;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _GravityBottom;
		/// <summary>Represents the value associated with the constant kCAGravityBottom</summary><value></value><remarks>To be added.</remarks>
		[Field ("kCAGravityBottom",  "CoreAnimation")]
		public static NSString GravityBottom {
			get {
				if (_GravityBottom is null)
					_GravityBottom = Dlfcn.GetStringConstant (Libraries.CoreAnimation.Handle, "kCAGravityBottom")!;
				return _GravityBottom;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _GravityBottomLeft;
		/// <summary>Represents the value associated with the constant kCAGravityBottomLeft</summary><value></value><remarks>To be added.</remarks>
		[Field ("kCAGravityBottomLeft",  "CoreAnimation")]
		public static NSString GravityBottomLeft {
			get {
				if (_GravityBottomLeft is null)
					_GravityBottomLeft = Dlfcn.GetStringConstant (Libraries.CoreAnimation.Handle, "kCAGravityBottomLeft")!;
				return _GravityBottomLeft;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _GravityBottomRight;
		/// <summary>Represents the value associated with the constant kCAGravityBottomRight</summary><value></value><remarks>To be added.</remarks>
		[Field ("kCAGravityBottomRight",  "CoreAnimation")]
		public static NSString GravityBottomRight {
			get {
				if (_GravityBottomRight is null)
					_GravityBottomRight = Dlfcn.GetStringConstant (Libraries.CoreAnimation.Handle, "kCAGravityBottomRight")!;
				return _GravityBottomRight;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _GravityCenter;
		/// <summary>Represents the value associated with the constant kCAGravityCenter</summary><value></value><remarks>To be added.</remarks>
		[Field ("kCAGravityCenter",  "CoreAnimation")]
		public static NSString GravityCenter {
			get {
				if (_GravityCenter is null)
					_GravityCenter = Dlfcn.GetStringConstant (Libraries.CoreAnimation.Handle, "kCAGravityCenter")!;
				return _GravityCenter;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _GravityLeft;
		/// <summary>Represents the value associated with the constant kCAGravityLeft</summary><value></value><remarks>To be added.</remarks>
		[Field ("kCAGravityLeft",  "CoreAnimation")]
		public static NSString GravityLeft {
			get {
				if (_GravityLeft is null)
					_GravityLeft = Dlfcn.GetStringConstant (Libraries.CoreAnimation.Handle, "kCAGravityLeft")!;
				return _GravityLeft;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _GravityResize;
		/// <summary>Represents the value associated with the constant kCAGravityResize</summary><value></value><remarks>To be added.</remarks>
		[Field ("kCAGravityResize",  "CoreAnimation")]
		public static NSString GravityResize {
			get {
				if (_GravityResize is null)
					_GravityResize = Dlfcn.GetStringConstant (Libraries.CoreAnimation.Handle, "kCAGravityResize")!;
				return _GravityResize;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _GravityResizeAspect;
		/// <summary>Represents the value associated with the constant kCAGravityResizeAspect</summary><value></value><remarks>To be added.</remarks>
		[Field ("kCAGravityResizeAspect",  "CoreAnimation")]
		public static NSString GravityResizeAspect {
			get {
				if (_GravityResizeAspect is null)
					_GravityResizeAspect = Dlfcn.GetStringConstant (Libraries.CoreAnimation.Handle, "kCAGravityResizeAspect")!;
				return _GravityResizeAspect;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _GravityResizeAspectFill;
		/// <summary>Represents the value associated with the constant kCAGravityResizeAspectFill</summary><value></value><remarks>To be added.</remarks>
		[Field ("kCAGravityResizeAspectFill",  "CoreAnimation")]
		public static NSString GravityResizeAspectFill {
			get {
				if (_GravityResizeAspectFill is null)
					_GravityResizeAspectFill = Dlfcn.GetStringConstant (Libraries.CoreAnimation.Handle, "kCAGravityResizeAspectFill")!;
				return _GravityResizeAspectFill;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _GravityRight;
		/// <summary>Represents the value associated with the constant kCAGravityRight</summary><value></value><remarks>To be added.</remarks>
		[Field ("kCAGravityRight",  "CoreAnimation")]
		public static NSString GravityRight {
			get {
				if (_GravityRight is null)
					_GravityRight = Dlfcn.GetStringConstant (Libraries.CoreAnimation.Handle, "kCAGravityRight")!;
				return _GravityRight;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _GravityTop;
		/// <summary>Represents the value associated with the constant kCAGravityTop</summary><value></value><remarks>To be added.</remarks>
		[Field ("kCAGravityTop",  "CoreAnimation")]
		public static NSString GravityTop {
			get {
				if (_GravityTop is null)
					_GravityTop = Dlfcn.GetStringConstant (Libraries.CoreAnimation.Handle, "kCAGravityTop")!;
				return _GravityTop;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _GravityTopLeft;
		/// <summary>Represents the value associated with the constant kCAGravityTopLeft</summary><value></value><remarks>To be added.</remarks>
		[Field ("kCAGravityTopLeft",  "CoreAnimation")]
		public static NSString GravityTopLeft {
			get {
				if (_GravityTopLeft is null)
					_GravityTopLeft = Dlfcn.GetStringConstant (Libraries.CoreAnimation.Handle, "kCAGravityTopLeft")!;
				return _GravityTopLeft;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _GravityTopRight;
		/// <summary>Represents the value associated with the constant kCAGravityTopRight</summary><value></value><remarks>To be added.</remarks>
		[Field ("kCAGravityTopRight",  "CoreAnimation")]
		public static NSString GravityTopRight {
			get {
				if (_GravityTopRight is null)
					_GravityTopRight = Dlfcn.GetStringConstant (Libraries.CoreAnimation.Handle, "kCAGravityTopRight")!;
				return _GravityTopRight;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _OnOrderIn;
		/// <summary>Represents the value associated with the constant kCAOnOrderIn</summary><value></value><remarks>To be added.</remarks>
		[Field ("kCAOnOrderIn",  "CoreAnimation")]
		public static NSString OnOrderIn {
			get {
				if (_OnOrderIn is null)
					_OnOrderIn = Dlfcn.GetStringConstant (Libraries.CoreAnimation.Handle, "kCAOnOrderIn")!;
				return _OnOrderIn;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _OnOrderOut;
		/// <summary>Represents the value associated with the constant kCAOnOrderOut</summary><value></value><remarks>To be added.</remarks>
		[Field ("kCAOnOrderOut",  "CoreAnimation")]
		public static NSString OnOrderOut {
			get {
				if (_OnOrderOut is null)
					_OnOrderOut = Dlfcn.GetStringConstant (Libraries.CoreAnimation.Handle, "kCAOnOrderOut")!;
				return _OnOrderOut;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _Transition;
		/// <summary>Represents the value associated with the constant kCATransition</summary><value></value><remarks>To be added.</remarks>
		[Field ("kCATransition",  "CoreAnimation")]
		public static NSString Transition {
			get {
				if (_Transition is null)
					_Transition = Dlfcn.GetStringConstant (Libraries.CoreAnimation.Handle, "kCATransition")!;
				return _Transition;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		protected override void Dispose (bool disposing)
		{
			OnDispose ();
			base.Dispose (disposing);
			if (Handle == IntPtr.Zero) {
				__mt_WeakDelegate_var = null;
			}
		}
	} /* class CALayer */
}
