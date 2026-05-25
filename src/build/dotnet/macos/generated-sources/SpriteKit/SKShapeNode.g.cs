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
namespace SpriteKit {
	/// <summary>A <see cref="T:SpriteKit.SKShapeNode" /> defined by a Core Graphics <see cref="T:CoreGraphics.CGPath" />.</summary><related type="externalDocumentation" href="https://developer.apple.com/library/ios/documentation/SpriteKit/Reference/SKShapeNode_Ref/index.html">Apple documentation for <c>SKShapeNode</c></related>
	[Register("SKShapeNode", true)]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("tvos")]
	public unsafe partial class SKShapeNode : SKNode {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAttributeValuesX = "attributeValues";
		static readonly NativeHandle selAttributeValuesXHandle = Selector.GetHandle ("attributeValues");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selBlendModeX = "blendMode";
		static readonly NativeHandle selBlendModeXHandle = Selector.GetHandle ("blendMode");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selFillColorX = "fillColor";
		static readonly NativeHandle selFillColorXHandle = Selector.GetHandle ("fillColor");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selFillShaderX = "fillShader";
		static readonly NativeHandle selFillShaderXHandle = Selector.GetHandle ("fillShader");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selFillTextureX = "fillTexture";
		static readonly NativeHandle selFillTextureXHandle = Selector.GetHandle ("fillTexture");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selGlowWidthX = "glowWidth";
		static readonly NativeHandle selGlowWidthXHandle = Selector.GetHandle ("glowWidth");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selIsAntialiasedX = "isAntialiased";
		static readonly NativeHandle selIsAntialiasedXHandle = Selector.GetHandle ("isAntialiased");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selLineCapX = "lineCap";
		static readonly NativeHandle selLineCapXHandle = Selector.GetHandle ("lineCap");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selLineJoinX = "lineJoin";
		static readonly NativeHandle selLineJoinXHandle = Selector.GetHandle ("lineJoin");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selLineLengthX = "lineLength";
		static readonly NativeHandle selLineLengthXHandle = Selector.GetHandle ("lineLength");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selLineWidthX = "lineWidth";
		static readonly NativeHandle selLineWidthXHandle = Selector.GetHandle ("lineWidth");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selMiterLimitX = "miterLimit";
		static readonly NativeHandle selMiterLimitXHandle = Selector.GetHandle ("miterLimit");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selPathX = "path";
		static readonly NativeHandle selPathXHandle = Selector.GetHandle ("path");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetAntialiased_X = "setAntialiased:";
		static readonly NativeHandle selSetAntialiased_XHandle = Selector.GetHandle ("setAntialiased:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetAttributeValues_X = "setAttributeValues:";
		static readonly NativeHandle selSetAttributeValues_XHandle = Selector.GetHandle ("setAttributeValues:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetBlendMode_X = "setBlendMode:";
		static readonly NativeHandle selSetBlendMode_XHandle = Selector.GetHandle ("setBlendMode:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetFillColor_X = "setFillColor:";
		static readonly NativeHandle selSetFillColor_XHandle = Selector.GetHandle ("setFillColor:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetFillShader_X = "setFillShader:";
		static readonly NativeHandle selSetFillShader_XHandle = Selector.GetHandle ("setFillShader:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetFillTexture_X = "setFillTexture:";
		static readonly NativeHandle selSetFillTexture_XHandle = Selector.GetHandle ("setFillTexture:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetGlowWidth_X = "setGlowWidth:";
		static readonly NativeHandle selSetGlowWidth_XHandle = Selector.GetHandle ("setGlowWidth:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetLineCap_X = "setLineCap:";
		static readonly NativeHandle selSetLineCap_XHandle = Selector.GetHandle ("setLineCap:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetLineJoin_X = "setLineJoin:";
		static readonly NativeHandle selSetLineJoin_XHandle = Selector.GetHandle ("setLineJoin:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetLineWidth_X = "setLineWidth:";
		static readonly NativeHandle selSetLineWidth_XHandle = Selector.GetHandle ("setLineWidth:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetMiterLimit_X = "setMiterLimit:";
		static readonly NativeHandle selSetMiterLimit_XHandle = Selector.GetHandle ("setMiterLimit:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetPath_X = "setPath:";
		static readonly NativeHandle selSetPath_XHandle = Selector.GetHandle ("setPath:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetStrokeColor_X = "setStrokeColor:";
		static readonly NativeHandle selSetStrokeColor_XHandle = Selector.GetHandle ("setStrokeColor:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetStrokeShader_X = "setStrokeShader:";
		static readonly NativeHandle selSetStrokeShader_XHandle = Selector.GetHandle ("setStrokeShader:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetStrokeTexture_X = "setStrokeTexture:";
		static readonly NativeHandle selSetStrokeTexture_XHandle = Selector.GetHandle ("setStrokeTexture:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetValue_ForAttributeNamed_X = "setValue:forAttributeNamed:";
		static readonly NativeHandle selSetValue_ForAttributeNamed_XHandle = Selector.GetHandle ("setValue:forAttributeNamed:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selShapeNodeWithCircleOfRadius_X = "shapeNodeWithCircleOfRadius:";
		static readonly NativeHandle selShapeNodeWithCircleOfRadius_XHandle = Selector.GetHandle ("shapeNodeWithCircleOfRadius:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selShapeNodeWithEllipseInRect_X = "shapeNodeWithEllipseInRect:";
		static readonly NativeHandle selShapeNodeWithEllipseInRect_XHandle = Selector.GetHandle ("shapeNodeWithEllipseInRect:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selShapeNodeWithEllipseOfSize_X = "shapeNodeWithEllipseOfSize:";
		static readonly NativeHandle selShapeNodeWithEllipseOfSize_XHandle = Selector.GetHandle ("shapeNodeWithEllipseOfSize:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selShapeNodeWithPath_X = "shapeNodeWithPath:";
		static readonly NativeHandle selShapeNodeWithPath_XHandle = Selector.GetHandle ("shapeNodeWithPath:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selShapeNodeWithPath_Centered_X = "shapeNodeWithPath:centered:";
		static readonly NativeHandle selShapeNodeWithPath_Centered_XHandle = Selector.GetHandle ("shapeNodeWithPath:centered:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selShapeNodeWithPoints_Count_X = "shapeNodeWithPoints:count:";
		static readonly NativeHandle selShapeNodeWithPoints_Count_XHandle = Selector.GetHandle ("shapeNodeWithPoints:count:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selShapeNodeWithRect_X = "shapeNodeWithRect:";
		static readonly NativeHandle selShapeNodeWithRect_XHandle = Selector.GetHandle ("shapeNodeWithRect:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selShapeNodeWithRect_CornerRadius_X = "shapeNodeWithRect:cornerRadius:";
		static readonly NativeHandle selShapeNodeWithRect_CornerRadius_XHandle = Selector.GetHandle ("shapeNodeWithRect:cornerRadius:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selShapeNodeWithRectOfSize_X = "shapeNodeWithRectOfSize:";
		static readonly NativeHandle selShapeNodeWithRectOfSize_XHandle = Selector.GetHandle ("shapeNodeWithRectOfSize:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selShapeNodeWithRectOfSize_CornerRadius_X = "shapeNodeWithRectOfSize:cornerRadius:";
		static readonly NativeHandle selShapeNodeWithRectOfSize_CornerRadius_XHandle = Selector.GetHandle ("shapeNodeWithRectOfSize:cornerRadius:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selShapeNodeWithSplinePoints_Count_X = "shapeNodeWithSplinePoints:count:";
		static readonly NativeHandle selShapeNodeWithSplinePoints_Count_XHandle = Selector.GetHandle ("shapeNodeWithSplinePoints:count:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selStrokeColorX = "strokeColor";
		static readonly NativeHandle selStrokeColorXHandle = Selector.GetHandle ("strokeColor");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selStrokeShaderX = "strokeShader";
		static readonly NativeHandle selStrokeShaderXHandle = Selector.GetHandle ("strokeShader");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selStrokeTextureX = "strokeTexture";
		static readonly NativeHandle selStrokeTextureXHandle = Selector.GetHandle ("strokeTexture");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selValueForAttributeNamed_X = "valueForAttributeNamed:";
		static readonly NativeHandle selValueForAttributeNamed_XHandle = Selector.GetHandle ("valueForAttributeNamed:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly NativeHandle class_ptr = Class.GetHandle ("SKShapeNode");
		/// <summary>The Objective-C class handle for this class.</summary>
		/// <value>The pointer to the Objective-C class.</value>
		/// <remarks>
		///     Each managed class mirrors an unmanaged Objective-C class.
		///     This value contains the pointer to the Objective-C class.
		///     It is similar to calling the managed <see cref="ObjCRuntime.Class.GetHandle(string)" /> or the native <see href="https://developer.apple.com/documentation/objectivec/1418952-objc_getclass">objc_getClass</see> method with the type name.
		/// </remarks>
		public override NativeHandle ClassHandle { get { return class_ptr; } }
		/// <summary>Creates a new <see cref="SKShapeNode" /> with default values.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public SKShapeNode () : base (NSObjectFlag.Empty)
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
		public SKShapeNode (NSCoder coder) : base (NSObjectFlag.Empty)
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
		protected SKShapeNode (NSObjectFlag t) : base (t)
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
		protected internal SKShapeNode (NativeHandle handle) : base (handle)
		{
		}

		/// <param name="radius">To be added.</param><summary>Creates a new circular shape node from a radius.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("shapeNodeWithCircleOfRadius:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static SKShapeNode FromCircle (nfloat radius)
		{
			SKShapeNode ret;
			ret =  Runtime.GetNSObject<SKShapeNode> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_nfloat (class_ptr, selShapeNodeWithCircleOfRadius_XHandle, radius), false)!;
			return ret;
		}
		[Export ("shapeNodeWithEllipseInRect:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static SKShapeNode FromEllipse (CGRect rect)
		{
			SKShapeNode ret;
			ret =  Runtime.GetNSObject<SKShapeNode> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_CGRect (class_ptr, selShapeNodeWithEllipseInRect_XHandle, rect), false)!;
			return ret;
		}
		[Export ("shapeNodeWithEllipseOfSize:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static SKShapeNode FromEllipse (CGSize size)
		{
			SKShapeNode ret;
			ret =  Runtime.GetNSObject<SKShapeNode> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_CGSize (class_ptr, selShapeNodeWithEllipseOfSize_XHandle, size), false)!;
			return ret;
		}
		[Export ("shapeNodeWithPath:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static SKShapeNode FromPath (CGPath path)
		{
			var path__handle__ = path!.GetNonNullHandle (nameof (path));
			SKShapeNode? ret;
			ret =  Runtime.GetNSObject<SKShapeNode> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (class_ptr, selShapeNodeWithPath_XHandle, path.Handle), false)!;
			GC.KeepAlive (path);
			return ret!;
		}
		[Export ("shapeNodeWithPath:centered:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static SKShapeNode FromPath (CGPath path, bool centered)
		{
			var path__handle__ = path!.GetNonNullHandle (nameof (path));
			SKShapeNode? ret;
			ret =  Runtime.GetNSObject<SKShapeNode> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_bool (class_ptr, selShapeNodeWithPath_Centered_XHandle, path.Handle, centered ? (byte) 1 : (byte) 0), false)!;
			GC.KeepAlive (path);
			return ret!;
		}
		/// <param name="points">To be added.</param><param name="numPoints">To be added.</param><summary>Creates a shape node from the specified list of points.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("shapeNodeWithPoints:count:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal unsafe static SKShapeNode FromPoints (ref CGPoint points, nuint numPoints)
		{
			fixed (CGPoint* points__pointer = &points) {
			SKShapeNode ret;
			ret =  Runtime.GetNSObject<SKShapeNode> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_ref_CGPoint_UIntPtr (class_ptr, selShapeNodeWithPoints_Count_XHandle, points__pointer, numPoints), false)!;
			return ret;
			}
		}
		[Export ("shapeNodeWithRect:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static SKShapeNode FromRect (CGRect rect)
		{
			SKShapeNode ret;
			ret =  Runtime.GetNSObject<SKShapeNode> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_CGRect (class_ptr, selShapeNodeWithRect_XHandle, rect), false)!;
			return ret;
		}
		[Export ("shapeNodeWithRectOfSize:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static SKShapeNode FromRect (CGSize size)
		{
			SKShapeNode ret;
			ret =  Runtime.GetNSObject<SKShapeNode> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_CGSize (class_ptr, selShapeNodeWithRectOfSize_XHandle, size), false)!;
			return ret;
		}
		/// <param name="rect">To be added.</param><param name="cornerRadius">To be added.</param><summary>Creates a shape node from the specified rectangle and the specified corner radius.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("shapeNodeWithRect:cornerRadius:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static SKShapeNode FromRect (CGRect rect, nfloat cornerRadius)
		{
			SKShapeNode ret;
			ret =  Runtime.GetNSObject<SKShapeNode> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_CGRect_nfloat (class_ptr, selShapeNodeWithRect_CornerRadius_XHandle, rect, cornerRadius), false)!;
			return ret;
		}
		/// <param name="size">To be added.</param><param name="cornerRadius">To be added.</param><summary>Creates a shape node with the specified corner radius by treating the specified size as a rectangle.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("shapeNodeWithRectOfSize:cornerRadius:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static SKShapeNode FromRect (CGSize size, nfloat cornerRadius)
		{
			SKShapeNode ret;
			ret =  Runtime.GetNSObject<SKShapeNode> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_CGSize_nfloat (class_ptr, selShapeNodeWithRectOfSize_CornerRadius_XHandle, size, cornerRadius), false)!;
			return ret;
		}
		/// <param name="points">To be added.</param><param name="numPoints">To be added.</param><summary>Creates a shape node that represents a quadratic spline curve through the specified points.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("shapeNodeWithSplinePoints:count:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal unsafe static SKShapeNode FromSplinePoints (ref CGPoint points, nuint numPoints)
		{
			fixed (CGPoint* points__pointer = &points) {
			SKShapeNode ret;
			ret =  Runtime.GetNSObject<SKShapeNode> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_ref_CGPoint_UIntPtr (class_ptr, selShapeNodeWithSplinePoints_Count_XHandle, points__pointer, numPoints), false)!;
			return ret;
			}
		}
		[Export ("valueForAttributeNamed:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual SKAttributeValue? GetValue (string key)
		{
			if (key is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (key));
			var nskey = CFString.CreateNative (key);
			SKAttributeValue? ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<SKAttributeValue> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, selValueForAttributeNamed_XHandle, nskey), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<SKAttributeValue> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle (&__objc_super__, selValueForAttributeNamed_XHandle, nskey), false)!;
					GC.KeepAlive (this);
				}
			}
			CFString.ReleaseNative (nskey);
			return ret!;
		}
		[Export ("setValue:forAttributeNamed:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetValue (SKAttributeValue value, string key)
		{
			var value__handle__ = value!.GetNonNullHandle (nameof (value));
			if (key is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (key));
			var nskey = CFString.CreateNative (key);
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (this.Handle, selSetValue_ForAttributeNamed_XHandle, value__handle__, nskey);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, selSetValue_ForAttributeNamed_XHandle, value__handle__, nskey);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (value);
			CFString.ReleaseNative (nskey);
		}
		/// <summary>Gets or sets a value that controls whether to antialias the shape.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool Antialiased {
			[Export ("isAntialiased")]
			get {
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selIsAntialiasedXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, selIsAntialiasedXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
			[Export ("setAntialiased:")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, selSetAntialiased_XHandle, value ? (byte) 1 : (byte) 0);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (&__objc_super__, selSetAntialiased_XHandle, value ? (byte) 1 : (byte) 0);
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
		public virtual NSDictionary<NSString, SKAttributeValue> AttributeValues {
			[Export ("attributeValues", ArgumentSemantic.Copy)]
			get {
				NSDictionary<NSString, SKAttributeValue>? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSDictionary<NSString, SKAttributeValue>> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selAttributeValuesXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<NSDictionary<NSString, SKAttributeValue>> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selAttributeValuesXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setAttributeValues:", ArgumentSemantic.Copy)]
			set {
				var value__handle__ = value!.GetNonNullHandle (nameof (value));
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selSetAttributeValues_XHandle, value__handle__);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selSetAttributeValues_XHandle, value__handle__);
						GC.KeepAlive (this);
					}
				}
				GC.KeepAlive (value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual SKBlendMode BlendMode {
			[Export ("blendMode")]
			get {
				SKBlendMode ret;
				if (IsDirectBinding) {
					ret = (SKBlendMode) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selBlendModeXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = (SKBlendMode) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (&__objc_super__, selBlendModeXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setBlendMode:")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetBlendMode_XHandle, (IntPtr) (long) value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (&__objc_super__, selSetBlendMode_XHandle, (IntPtr) (long) value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual global::AppKit.NSColor FillColor {
			[Export ("fillColor", ArgumentSemantic.Retain)]
			get {
				global::AppKit.NSColor? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<global::AppKit.NSColor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selFillColorXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<global::AppKit.NSColor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selFillColorXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setFillColor:", ArgumentSemantic.Retain)]
			set {
				var value__handle__ = value!.GetNonNullHandle (nameof (value));
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selSetFillColor_XHandle, value__handle__);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selSetFillColor_XHandle, value__handle__);
						GC.KeepAlive (this);
					}
				}
				GC.KeepAlive (value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public virtual SKShader? FillShader {
			[Export ("fillShader", ArgumentSemantic.Retain)]
			get {
				SKShader? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<SKShader> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selFillShaderXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<SKShader> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selFillShaderXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setFillShader:", ArgumentSemantic.Retain)]
			set {
				var value__handle__ = value.GetHandle ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selSetFillShader_XHandle, value__handle__);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selSetFillShader_XHandle, value__handle__);
						GC.KeepAlive (this);
					}
				}
				GC.KeepAlive (value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public virtual SKTexture? FillTexture {
			[Export ("fillTexture", ArgumentSemantic.Retain)]
			get {
				SKTexture? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<SKTexture> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selFillTextureXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<SKTexture> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selFillTextureXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setFillTexture:", ArgumentSemantic.Retain)]
			set {
				var value__handle__ = value.GetHandle ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selSetFillTexture_XHandle, value__handle__);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selSetFillTexture_XHandle, value__handle__);
						GC.KeepAlive (this);
					}
				}
				GC.KeepAlive (value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual nfloat GlowWidth {
			[Export ("glowWidth")]
			get {
				nfloat ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.nfloat_objc_msgSend (this.Handle, selGlowWidthXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.nfloat_objc_msgSendSuper (&__objc_super__, selGlowWidthXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[Export ("setGlowWidth:")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_nfloat (this.Handle, selSetGlowWidth_XHandle, value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_nfloat (&__objc_super__, selSetGlowWidth_XHandle, value);
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
		public virtual CGLineCap LineCap {
			[Export ("lineCap")]
			get {
				CGLineCap ret;
				if (IsDirectBinding) {
					ret = (CGLineCap) global::ObjCRuntime.Messaging.int_objc_msgSend (this.Handle, selLineCapXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = (CGLineCap) global::ObjCRuntime.Messaging.int_objc_msgSendSuper (&__objc_super__, selLineCapXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[Export ("setLineCap:")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_int (this.Handle, selSetLineCap_XHandle, (int)value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_int (&__objc_super__, selSetLineCap_XHandle, (int)value);
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
		public virtual CGLineJoin LineJoin {
			[Export ("lineJoin")]
			get {
				CGLineJoin ret;
				if (IsDirectBinding) {
					ret = (CGLineJoin) global::ObjCRuntime.Messaging.int_objc_msgSend (this.Handle, selLineJoinXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = (CGLineJoin) global::ObjCRuntime.Messaging.int_objc_msgSendSuper (&__objc_super__, selLineJoinXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[Export ("setLineJoin:")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_int (this.Handle, selSetLineJoin_XHandle, (int)value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_int (&__objc_super__, selSetLineJoin_XHandle, (int)value);
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
		public virtual nfloat LineLength {
			[Export ("lineLength")]
			get {
				nfloat ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.nfloat_objc_msgSend (this.Handle, selLineLengthXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.nfloat_objc_msgSendSuper (&__objc_super__, selLineLengthXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
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
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
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
		public virtual CGPath? Path {
			[Export ("path")]
			get {
				CGPath ret;
				if (IsDirectBinding) {
					ret = Runtime.GetINativeObject<global::CoreGraphics.CGPath> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selPathXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = Runtime.GetINativeObject<global::CoreGraphics.CGPath> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selPathXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[Export ("setPath:")]
			set {
				var value__handle__ = value.GetHandle ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selSetPath_XHandle, value__handle__);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selSetPath_XHandle, value__handle__);
						GC.KeepAlive (this);
					}
				}
				GC.KeepAlive (value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual global::AppKit.NSColor StrokeColor {
			[Export ("strokeColor", ArgumentSemantic.Retain)]
			get {
				global::AppKit.NSColor? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<global::AppKit.NSColor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selStrokeColorXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<global::AppKit.NSColor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selStrokeColorXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setStrokeColor:", ArgumentSemantic.Retain)]
			set {
				var value__handle__ = value!.GetNonNullHandle (nameof (value));
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selSetStrokeColor_XHandle, value__handle__);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selSetStrokeColor_XHandle, value__handle__);
						GC.KeepAlive (this);
					}
				}
				GC.KeepAlive (value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public virtual SKShader? StrokeShader {
			[Export ("strokeShader", ArgumentSemantic.Retain)]
			get {
				SKShader? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<SKShader> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selStrokeShaderXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<SKShader> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selStrokeShaderXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setStrokeShader:", ArgumentSemantic.Retain)]
			set {
				var value__handle__ = value.GetHandle ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selSetStrokeShader_XHandle, value__handle__);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selSetStrokeShader_XHandle, value__handle__);
						GC.KeepAlive (this);
					}
				}
				GC.KeepAlive (value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public virtual SKTexture? StrokeTexture {
			[Export ("strokeTexture", ArgumentSemantic.Retain)]
			get {
				SKTexture? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<SKTexture> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selStrokeTextureXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<SKTexture> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selStrokeTextureXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setStrokeTexture:", ArgumentSemantic.Retain)]
			set {
				var value__handle__ = value.GetHandle ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selSetStrokeTexture_XHandle, value__handle__);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selSetStrokeTexture_XHandle, value__handle__);
						GC.KeepAlive (this);
					}
				}
				GC.KeepAlive (value);
			}
		}
	} /* class SKShapeNode */
}
