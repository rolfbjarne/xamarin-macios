//
// coreanimation.cs: API definition for CoreAnimation binding
//
// Authors:
//   Geoff Norton
//   Miguel de Icaza
//
// Copyright 2009, Novell, Inc.
// Copyright 2010, Novell, Inc.
// Copyright 2011, 2012, 2015 Xamarin Inc
//
// Permission is hereby granted, free of charge, to any person obtaining
// a copy of this software and associated documentation files (the
// "Software"), to deal in the Software without restriction, including
// without limitation the rights to use, copy, modify, merge, publish,
// distribute, sublicense, and/or sell copies of the Software, and to
// permit persons to whom the Software is furnished to do so, subject to
// the following conditions:
// 
// The above copyright notice and this permission notice shall be
// included in all copies or substantial portions of the Software.
// 
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND,
// EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF
// MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND
// NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE
// LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION
// OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION
// WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.
//

using System.ComponentModel;
using System.Diagnostics;
#if MONOMAC
using AppKit;
using CoreVideo;
using OpenGL;
#else
using UIKit;
#endif
#if HAS_OPENGLES
using OpenGLES;
#endif
using CoreImage;
using CoreGraphics;
using Metal;
using SceneKit; // For SCNAnimationEvent

#if __TVOS__
using CAEdrMetadata = Foundation.NSObject;
#endif

#if !MONOMAC
using CGLPixelFormat = Foundation.NSObject;
using CVTimeStamp = Foundation.NSObject;
using CGLContext = System.IntPtr;
#endif

namespace CoreAnimation {

	/// <summary>Provides a hierarchical timing system, with support for repetition and sequencing.</summary>
	///     
	///     <related type="externalDocumentation" href="https://developer.apple.com/library/ios/documentation/GraphicsImaging/Reference/CAMediaTiming_protocol/index.html">Apple documentation for <c>CAMediaTiming</c></related>
	[BaseType (typeof (NSObject))]
	[Model]
	[Protocol]
	interface CAMediaTiming {
		/// <summary>Gets or sets the BeginTime value.</summary>
		[Abstract]
		[Export ("beginTime")]
		double BeginTime { get; set; }

		/// <summary>Gets or sets the Duration value.</summary>
		[Abstract]
		[Export ("duration")]
		double Duration { get; set; }

		/// <summary>Gets or sets the Speed value.</summary>
		[Abstract]
		[Export ("speed")]
		float Speed { get; set; } /* float, not CGFloat */

		/// <summary>Gets or sets the TimeOffset value.</summary>
		[Abstract]
		[Export ("timeOffset")]
		double TimeOffset { get; set; }

		/// <summary>Gets or sets the RepeatCount value.</summary>
		[Abstract]
		[Export ("repeatCount")]
		float RepeatCount { get; set; } /* float, not CGFloat */

		/// <summary>Gets or sets the RepeatDuration value.</summary>
		[Abstract]
		[Export ("repeatDuration")]
		double RepeatDuration { get; set; }

		/// <summary>Gets or sets the AutoReverses value.</summary>
		[Abstract]
		[Export ("autoreverses")]
		bool AutoReverses { get; set; }

		/// <summary>Gets or sets the FillMode value.</summary>
		[Abstract]
		[Export ("fillMode", ArgumentSemantic.Copy)]
		string FillMode { get; set; }
	}

	interface ICAMediaTiming { }

	[NoiOS]
	[NoTV]
	[MacCatalyst (13, 1)]
	[BaseType (typeof (NSObject))]
	interface CAConstraintLayoutManager : NSCoding, CALayoutManager {
		/// <summary>Gets the LayoutManager value.</summary>
		[Static]
		[Export ("layoutManager")]
		CAConstraintLayoutManager LayoutManager { get; }
	}

	[NoiOS]
	[NoTV]
	[MacCatalyst (13, 1)]
	[BaseType (typeof (NSObject))]
	interface CAConstraint : NSSecureCoding {
		/// <summary>Gets the Attribute value.</summary>
		[Export ("attribute")]
		CAConstraintAttribute Attribute { get; }

		/// <summary>Gets the SourceName value.</summary>
		[Export ("sourceName")]
		string SourceName { get; }

		/// <summary>Gets the SourceAttribute value.</summary>
		[Export ("sourceAttribute")]
		CAConstraintAttribute SourceAttribute { get; }

		/// <summary>Gets the Scale value.</summary>
		[Export ("scale")]
		nfloat Scale { get; }

		[Export ("offset")]
		nfloat Offset { get; }

		/// <param name="attribute">The constraint attribute.</param>
		/// <param name="relativeToSource">The source layer name.</param>
		/// <param name="srcAttr">The source attribute.</param>
		/// <param name="scale">The scale factor.</param>
		/// <param name="offset">The offset value.</param>
		/// <summary>Performs the create operation.</summary>
		/// <returns>The result of the operation.</returns>
		[Static]
		[Export ("constraintWithAttribute:relativeTo:attribute:scale:offset:")]
		CAConstraint Create (CAConstraintAttribute attribute, string relativeToSource, CAConstraintAttribute srcAttr, nfloat scale, nfloat offset);

		/// <param name="attribute">The constraint attribute.</param>
		/// <param name="relativeToSource">The source layer name.</param>
		/// <param name="srcAttr">The source attribute.</param>
		/// <param name="offset">The offset value.</param>
		/// <summary>Performs the create operation.</summary>
		/// <returns>The result of the operation.</returns>
		[Static]
		[Export ("constraintWithAttribute:relativeTo:attribute:offset:")]
		CAConstraint Create (CAConstraintAttribute attribute, string relativeToSource, CAConstraintAttribute srcAttr, nfloat offset);

		/// <param name="attribute">The constraint attribute.</param>
		///         <param name="relativeToSource">The source layer name.</param>
		///         <param name="srcAttribute">The source attribute.</param>
		///         <summary>Performs the create operation.</summary>
		///         <returns>The result of the operation.</returns>
		[Static]
		[Export ("constraintWithAttribute:relativeTo:attribute:")]
		CAConstraint Create (CAConstraintAttribute attribute, string relativeToSource, CAConstraintAttribute srcAttribute);

		/// <param name="attribute">The constraint attribute.</param>
		/// <param name="relativeToSource">The source layer name.</param>
		/// <param name="srcAttr">The source attribute.</param>
		/// <param name="scale">The scale factor.</param>
		/// <param name="offset">The offset value.</param>
		/// <summary>Creates a new instance with the specified parameters.</summary>
		[Export ("initWithAttribute:relativeTo:attribute:scale:offset:")]
		NativeHandle Constructor (CAConstraintAttribute attribute, string relativeToSource, CAConstraintAttribute srcAttr, nfloat scale, nfloat offset);
	}

	/// <include file="../docs/api/CoreAnimation/CADisplayLink.xml" path="/Documentation/Docs[@DocId='T:CoreAnimation.CADisplayLink']/*" />
	[Mac (14, 0)]
	[MacCatalyst (13, 1)]
	[BaseType (typeof (NSObject))]
	interface CADisplayLink {
		/// <param name="target">Target object to invoke the selector on.</param>
		///         <param name="sel">Selector to invoke.</param>
		///         <summary>Objective-C style registration of the method to be invoked every time the display is about to be updated.</summary>
		///         <returns>The DisplayLink object that will invoke the specified method on each screen update.</returns>
		///         <remarks>
		///           <para>
		/// 	    With C# you can use the Create overload that takes a NSAction as it can be used with lambdas.
		/// 	  </para>
		///           <para>
		/// 	    Once you create the display link, you must add the handler to the runloop.
		/// 	  </para>
		///         </remarks>
		[Export ("displayLinkWithTarget:selector:")]
		[Static]
		CADisplayLink Create (NSObject target, Selector sel);

		/// <param name="runloop">The runloop on which to run.</param>
		///         <param name="mode">Modes in which the timer will be invoked, one of the various NSString constants in <see cref="Foundation.NSRunLoop" />.<para tool="nullallowed">This parameter can be <see langword="null" />.</para></param>
		///         <summary>Trigger timer events on the specified runloop for the specified modes (weakly typed parameters).</summary>
		///         <remarks>
		///           <para>You should use the strongly typed version if possible, as it prevents common errors.</para>
		///           <para>
		/// 	    The mode parameter will determine when the event is sent.
		/// 	    The NSRunLoop.NSDefaultRunLoopMode is not delivered during
		/// 	    UI tracking events (like scrolling in a UIScrollbar).  For
		/// 	    getting those kinds of events use
		/// 	    NSRunLoop.UITrackingRunLoopMode.  Or use
		/// 	    NSRunLoop.NSRunLoopCommonModes which covers both cases.
		///
		/// 	  </para>
		///         </remarks>
		[Export ("addToRunLoop:forMode:")]
		void AddToRunLoop (NSRunLoop runloop, NSString mode);

		/// <param name="runloop">The runloop on which to run.</param>
		///         <param name="mode">Modes in which the timer will be invoked.</param>
		///         <summary>Trigger timer events on the specified runloop for the specified modes.</summary>
		///         <remarks>
		///           <para>The mode parameter will determine when the event is sent. The NSRunLoop.NSDefaultRunLoopMode is not delivered during UI tracking events (like scrolling in a UIScrollbar). For getting those kinds of events use NSRunLoop.UITrackingRunLoopMode. Or use NSRunLoop.NSRunLoopCommonModes which covers both cases.  	  </para>
		///         </remarks>
		[Wrap ("AddToRunLoop (runloop, mode.GetConstant ()!)")]
		void AddToRunLoop (NSRunLoop runloop, NSRunLoopMode mode);

		/// <param name="runloop">The run loop from which to remove the display link.</param>
		///         <param name="mode">
		///           <para>The mode of the run loop.</para>
		///           <para tool="nullallowed">This parameter can be <see langword="null" />.</para>
		///         </param>
		///         <summary>Removes the display link from the provided run loop when in the specified mode.</summary>
		[Export ("removeFromRunLoop:forMode:")]
		void RemoveFromRunLoop (NSRunLoop runloop, NSString mode);

		/// <param name="runloop">The run loop from which to remove the display link.</param>
		///         <param name="mode">The mode of the run loop.</param>
		///         <summary>Removes the display link from the provided run loop when in the specified mode.</summary>
		[Wrap ("RemoveFromRunLoop (runloop, mode.GetConstant ()!)")]
		void RemoveFromRunLoop (NSRunLoop runloop, NSRunLoopMode mode);

		/// <summary>Terminates the connection between CoreAnimation and your code.     This removes the CADisplayLink from all run loops.</summary>
		[Export ("invalidate")]
		void Invalidate ();

		/// <summary>Timestamp for the last frame displayed.</summary>
		///         <value>
		///         </value>
		///         <remarks>
		///           <para>Developers can this value to compute which date should be displayed next.</para>
		///         </remarks>
		[Export ("timestamp")]
		double Timestamp { get; }

		/// <summary>Whether the notifications between the animation loop and your code are suspended.</summary>
		[Export ("paused")]
		bool Paused { [Bind ("isPaused")] get; set; }

		/// <summary>Developers should not use this deprecated property. Developers should use 'PreferredFramesPerSecond' property.</summary>
		///         <remarks>
		///           <para>
		/// 	    The default value is one, which means that your code is
		/// 	    invoked once each time that a screen refresh will take
		/// 	    place.  If you set this value to two, then your method will
		/// 	    only be invoked half the time (once every two frames) and so
		/// 	    on.
		/// 	  </para>
		///           <para>
		/// 	    In general, you should not skip frames.  If your software
		/// 	    can not keep up with the frame rate, it is better to
		/// 	    increase the frame interval and deliver a consistent set
		/// 	    of updates.
		/// 	  </para>
		///         </remarks>
		[Obsoleted (PlatformName.iOS, 10, 0, message: "Use 'PreferredFramesPerSecond' property.")]
		[Obsoleted (PlatformName.TvOS, 10, 0, message: "Use 'PreferredFramesPerSecond' property.")]
		[Obsoleted (PlatformName.MacCatalyst, 13, 1, message: "Use 'PreferredFramesPerSecond' property.")]
		[NoMac]
		[Export ("frameInterval")]
		nint FrameInterval { get; set; }

		/// <summary>The time between screen refreshes.</summary>
		[Export ("duration")]
		double Duration { get; }

		/// <summary>Gets the time stamp for the desired time to start displaying the target of the display link.</summary>
		///         <value>The time stamp for the desired time to start displaying the target of the display link.</value>
		[MacCatalyst (13, 1)]
		[Export ("targetTimestamp")]
		double TargetTimestamp { get; }

		/// <summary>Gets or sets the preferred display rate.</summary>
		[Deprecated (PlatformName.iOS, 15, 0, message: "Use 'PreferredFrameRateRange' property.")]
		[Deprecated (PlatformName.TvOS, 15, 0, message: "Use 'PreferredFrameRateRange' property.")]
		[MacCatalyst (13, 1)]
		[Deprecated (PlatformName.MacCatalyst, 15, 0, message: "Use 'PreferredFrameRateRange' property.")]
		[NoMac]
		[Export ("preferredFramesPerSecond")]
		nint PreferredFramesPerSecond { get; set; }

		[TV (15, 0), iOS (15, 0), MacCatalyst (15, 0)]
		[Export ("preferredFrameRateRange", ArgumentSemantic.Assign)]
		CAFrameRateRange PreferredFrameRateRange { get; set; }
	}

	[MacCatalyst (13, 1)]
	enum CAContentsFormat {
		/// <summary>An 8-bit grayscale unsigned integer format.</summary>
		[Field ("kCAContentsFormatGray8Uint")]
		Gray8Uint,
		/// <summary>An RGBA 8-bit unsigned integer format.</summary>
		[Field ("kCAContentsFormatRGBA8Uint")]
		Rgba8Uint,
		/// <summary>An RGBA 16-bit floating-point format.</summary>
		[Field ("kCAContentsFormatRGBA16Float")]
		Rgba16Float,
		[Field ("kCAContentsFormatAutomatic")]
		Automatic,
	}


#if __MACOS__
	/// <include file="../docs/api/CoreAnimation/CALayer.xml" path="/Documentation/Docs[@DocId='T:CoreAnimation.CALayer' and contains(@Platforms,'macOS')]/*" />
#else
	/// <include file="../docs/api/CoreAnimation/CALayer.xml" path="/Documentation/Docs[@DocId='T:CoreAnimation.CALayer' and not(@Platforms)]/*" />
#endif
	[BaseType (typeof (NSObject))]
	[Dispose ("OnDispose ();", Optimizable = true)]
	interface CALayer : CAMediaTiming, NSSecureCoding {
		/// <summary>Factory method to create a new <see cref="CoreAnimation.CALayer" />.</summary>
		///         <returns>The result of the operation.</returns>
		[Export ("layer")]
		[Static]
		CALayer Create ();

		/// <summary>Gets the PresentationLayer value.</summary>
		[Export ("presentationLayer")]
		[NullAllowed]
		CALayer PresentationLayer { get; }

		/// <summary>Gets the ModelLayer value.</summary>
		[Export ("modelLayer")]
		CALayer ModelLayer { get; }

		/// <param name="key">
		///           <para>A task representing the asynchronous operation.</para>
		///           <para tool="nullallowed">This parameter can be <see langword="null" />.</para>
		///         </param>
		///         <summary>Performs the default value operation.</summary>
		///         <returns>The result of the operation.</returns>
		[Static]
		[Export ("defaultValueForKey:")]
		[return: NullAllowed]
		NSObject DefaultValue (string key);

		/// <param name="key">The key.</param>
		///         <summary>Performs the needs display for key operation.</summary>
		///         <returns>The result of the operation.</returns>
		[Static]
		[Export ("needsDisplayForKey:")]
		bool NeedsDisplayForKey (string key);

		/// <summary>Gets or sets the Bounds value.</summary>
		[Export ("bounds")]
		CGRect Bounds { get; set; }

		/// <summary>Gets or sets the ZPosition value.</summary>
		[Export ("zPosition")]
		nfloat ZPosition { get; set; }

		/// <summary>The anchor point for the <see cref="CoreAnimation.CALayer.Bounds" /> rectangle.</summary>
		///         <value>The developer specifies the value for this property using the unit coordinate space. The default value for this property is (0.5, 0.5), representing the center of the bounds rectangle for this layer.</value>
		[Export ("anchorPoint")]
		CGPoint AnchorPoint { get; set; }

		/// <summary>The anchor point for the <see cref="CoreAnimation.CALayer.Bounds" />, defined along the Z axis.</summary>
		///         <value>The default value is 0.</value>
		[Export ("anchorPointZ")]
		nfloat AnchorPointZ { get; set; }

		/// <summary>The layer's position in the coordinate space of its <see cref="CoreAnimation.CALayer.SuperLayer" />.</summary>
		///         <value>The default is (0,0). This value is specified in points relative to the layer's <see cref="CoreAnimation.CALayer.AnchorPoint" />.</value>
		[Export ("position")]
		CGPoint Position { get; set; }

		/// <summary>Gets or sets the Transform value.</summary>
		[Export ("transform")]
		CATransform3D Transform { get; set; }

		/// <summary>The affine version of the layer's <see cref="CoreAnimation.CALayer.Transform" />.</summary>
		[Export ("affineTransform")]
		CGAffineTransform AffineTransform { get; set; }

		/// <summary>Gets or sets the Frame value.</summary>
		[Export ("frame")]
		CGRect Frame { get; set; }

		/// <summary>Whether the layer is not displayed.</summary>
		///         <value>The default value is <see langword="false" />.</value>
		[Export ("hidden")] // Setter needs setHidden instead
		bool Hidden { [Bind ("isHidden")] get; set; }

		/// <summary>Whether the layer draws its content when facing away from the viewer.</summary>
		///         <value>The default value is <see langword="true" />.</value>
		[Export ("doubleSided")]  // Setter needs setDoubleSided
		bool DoubleSided { [Bind ("isDoubleSided")] get; set; }

		/// <summary>Gets or sets the GeometryFlipped value.</summary>
		[Export ("geometryFlipped")]
		bool GeometryFlipped { [Bind ("isGeometryFlipped")] get; set; }

		/// <summary>Whether the layer's contents are implicitly flipped when the layer is rendered.</summary>
		///         <value>The default value is <see langword="false" />.</value>
		[Export ("contentsAreFlipped")]
		bool ContentsAreFlipped { get; }

		/// <summary>Gets the SuperLayer value.</summary>
		[Export ("superlayer")]
		[NullAllowed]
		CALayer SuperLayer { get; }

		/// <summary>Removes <c>this</c> from its <see cref="CoreAnimation.CALayer.SuperLayer" />.</summary>
		[Export ("removeFromSuperlayer")]
		void RemoveFromSuperLayer ();

		/// <summary>Gets or sets the Sublayers value.</summary>
		///         <value>
		///           <para>(More documentation for this node is coming)</para>
		///           <para tool="nullallowed">This value can be <see langword="null" />.</para>
		///         </value>
		[NullAllowed] // by default this property is null
		[Export ("sublayers", ArgumentSemantic.Copy)]
		CALayer [] Sublayers { get; set; }

		/// <param name="layer">The layer being added.</param>
		///         <summary>Appends the <paramref name="layer" /> to this layer's <see cref="CoreAnimation.CALayer.Sublayers" />.</summary>
		[Export ("addSublayer:")]
		[PostGet ("Sublayers")]
		void AddSublayer (CALayer layer);

		/// <param name="layer">The layer being inserted.</param>
		///         <param name="index">The index at which to insert the <paramref name="layer" />.</param>
		///         <summary>Inserts the specified layer into the <see cref="CoreAnimation.CALayer.Sublayers" /> array at the specified index.</summary>
		[Export ("insertSublayer:atIndex:")]
		[PostGet ("Sublayers")]
		void InsertSublayer (CALayer layer, int index);

		/// <param name="layer">The layer being inserted.</param>
		///         <param name="sibling">The existing sublayer, which will subsequently appear in front of <paramref name="layer" />.</param>
		///         <summary>Inserts the specified layer into the <see cref="CoreAnimation.CALayer.Sublayers" /> array immediately prior to <paramref name="sibling" />.</summary>
		[Export ("insertSublayer:below:")]
		[PostGet ("Sublayers")]
		void InsertSublayerBelow (CALayer layer, [NullAllowed] CALayer sibling);

		/// <param name="layer">The layer being inserted.</param>
		///         <param name="sibling">The existing sublayer, which will subsequently appear behind <paramref name="layer" />.</param>
		///         <summary>Inserts the specified layer into the <see cref="CoreAnimation.CALayer.Sublayers" /> array immediately after <paramref name="sibling" />.</summary>
		[Export ("insertSublayer:above:")]
		[PostGet ("Sublayers")]
		void InsertSublayerAbove (CALayer layer, [NullAllowed] CALayer sibling);

		/// <param name="layer">The layer.</param>
		///         <param name="with">The context.</param>
		///         <summary>Performs the replace sublayer operation.</summary>
		[Export ("replaceSublayer:with:")]
		[PostGet ("Sublayers")]
		void ReplaceSublayer (CALayer layer, CALayer with);

		/// <summary>Gets or sets the SublayerTransform value.</summary>
		[Export ("sublayerTransform")]
		CATransform3D SublayerTransform { get; set; }

		/// <summary>An optional layer, the alpha channel of which is used to mask the contents of this layer.</summary>
		///         <value>
		///           <para>(More documentation for this node is coming)</para>
		///           <para tool="nullallowed">This value can be <see langword="null" />.</para>
		///         </value>
		[Export ("mask", ArgumentSemantic.Strong)]
		[NullAllowed]
		CALayer Mask { get; set; }

		/// <summary>Whether sublayers are clipped to the <see cref="CoreAnimation.CALayer.Bounds" /> of this layer.</summary>
		///         <value>The default value is <see langword="false" />.</value>
		///         <remarks>If <see langword="true" />, the clipping mask matches the bounds of <c>this</c><see cref="CoreAnimation.CALayer" />, including rounded corners.</remarks>
		[Export ("masksToBounds")]
		bool MasksToBounds { get; set; }

		/// <param name="point">The point.</param>
		///         <param name="layer">
		///           <para>A task representing the asynchronous operation.</para>
		///           <para tool="nullallowed">This parameter can be <see langword="null" />.</para>
		///         </param>
		///         <summary>Performs the convert point from layer operation.</summary>
		///         <returns>The result of the operation.</returns>
		[Export ("convertPoint:fromLayer:")]
		CGPoint ConvertPointFromLayer (CGPoint point, [NullAllowed] CALayer layer);

		/// <param name="point">The point.</param>
		///         <param name="layer">
		///           <para>A task representing the asynchronous operation.</para>
		///           <para tool="nullallowed">This parameter can be <see langword="null" />.</para>
		///         </param>
		///         <summary>Performs the convert point to layer operation.</summary>
		///         <returns>The result of the operation.</returns>
		[Export ("convertPoint:toLayer:")]
		CGPoint ConvertPointToLayer (CGPoint point, [NullAllowed] CALayer layer);

		/// <param name="rect">The rectangle.</param>
		///         <param name="layer">
		///           <para>A task representing the asynchronous operation.</para>
		///           <para tool="nullallowed">This parameter can be <see langword="null" />.</para>
		///         </param>
		///         <summary>Performs the convert rect from layer operation.</summary>
		///         <returns>The result of the operation.</returns>
		[Export ("convertRect:fromLayer:")]
		CGRect ConvertRectFromLayer (CGRect rect, [NullAllowed] CALayer layer);

		/// <param name="rect">The rectangle.</param>
		///         <param name="layer">
		///           <para>A task representing the asynchronous operation.</para>
		///           <para tool="nullallowed">This parameter can be <see langword="null" />.</para>
		///         </param>
		///         <summary>Performs the convert rect to layer operation.</summary>
		///         <returns>The result of the operation.</returns>
		[Export ("convertRect:toLayer:")]
		CGRect ConvertRectToLayer (CGRect rect, [NullAllowed] CALayer layer);

		/// <param name="timeInterval">The time interval.</param>
		///         <param name="layer">
		///           <para>They layer that will be used to convert the time from.</para>
		///           <para tool="nullallowed">This parameter can be <see langword="null" />.</para>
		///         </param>
		///         <summary>Performs the convert time from layer operation.</summary>
		///         <returns>The result of the operation.</returns>
		[Export ("convertTime:fromLayer:")]
		double ConvertTimeFromLayer (double timeInterval, [NullAllowed] CALayer layer);

		/// <param name="timeInterval">The time interval.</param>
		///         <param name="layer">
		///           <para>The layer that will be used to convert the time to.</para>
		///           <para tool="nullallowed">This parameter can be <see langword="null" />.</para>
		///         </param>
		///         <summary>Performs the convert time to layer operation.</summary>
		///         <returns>The result of the operation.</returns>
		[Export ("convertTime:toLayer:")]
		double ConvertTimeToLayer (double timeInterval, [NullAllowed] CALayer layer);

		/// <param name="p">A point, in the coordinate system of this layer's <see cref="CoreAnimation.CALayer.SuperLayer" />.</param>
		///         <summary>The furthest descendant in this layer's hierarchy that contains the point <paramref name="p" />.</summary>
		///         <returns>The layer (possible <c>this</c>) that contains the point <paramref name="p" /> or <see langword="null" /> if <paramref name="p" /> lies outside the <see cref="CoreAnimation.CALayer.Bounds" /> rectangle of <c>this</c>.</returns>
		[Export ("hitTest:")]
		[return: NullAllowed]
		CALayer HitTest (CGPoint p);

		/// <param name="p">The point.</param>
		///         <summary>Performs the contains operation.</summary>
		///         <returns>The result of the operation.</returns>
		[Export ("containsPoint:")]
		bool Contains (CGPoint p);

		/// <summary>The contents of this layer, as a <see cref="CoreGraphics.CGImage" />.</summary>
		/// <remarks>To get or set this property using a different type, call <see cref="GetContentsAs{T}()" /> or <see cref="SetContents(NSObject)" />.</remarks>
		[DebuggerBrowsable (DebuggerBrowsableState.Never)]
		[Export ("contents", ArgumentSemantic.Strong), NullAllowed]
		CGImage Contents { get; set; }

		[Export ("contents", ArgumentSemantic.Strong)]
		[Internal]
		[Sealed]
		IntPtr _Contents { get; set; }

		/// <summary>Gets or sets the LayoutManager value.</summary>
		[NoiOS]
		[NoTV]
		[MacCatalyst (13, 1)]
		[Export ("layoutManager", ArgumentSemantic.Retain)]
		[NullAllowed]
		NSObject LayoutManager { get; set; }

		/// <summary>The scale factor applied to the layer.</summary>
		///         <value>The default value is 1.0.</value>
		[Export ("contentsScale")]
		nfloat ContentsScale { get; set; }

		/// <summary>Gets or sets the ContentsRect value.</summary>
		[Export ("contentsRect")]
		CGRect ContentsRect { get; set; }

		/// <summary>Gets or sets the ContentsGravity value.</summary>
		[Export ("contentsGravity", ArgumentSemantic.Copy)]
		string ContentsGravity { get; set; }

		/// <summary>Gets or sets the ContentsCenter value.</summary>
		[Export ("contentsCenter")]
		CGRect ContentsCenter { get; set; }

		/// <summary>Gets or sets the MinificationFilter value.</summary>
		[Export ("minificationFilter", ArgumentSemantic.Copy)]
		string MinificationFilter { get; set; }

		/// <summary>Gets or sets the MagnificationFilter value.</summary>
		[Export ("magnificationFilter", ArgumentSemantic.Copy)]
		string MagnificationFilter { get; set; }

		/// <summary>Whether the layer and its contents are completely opaque.</summary>
		///         <value>The default value is <see langword="false" />. If <see langword="true" />, the system can render the layer more quickly.</value>
		[Export ("opaque")]
		bool Opaque { [Bind ("isOpaque")] get; set; }

		/// <summary>Performs the display operation.</summary>
		[Export ("display")]
		void Display ();

		/// <summary>Whether the layer has been marked as requiring an update.</summary>
		///         <value>
		///           <see langword="true" /> if the layer has been marked as requiring an update.</value>
		[Export ("needsDisplay")]
		bool NeedsDisplay { get; }

		/// <summary>Performs the set needs display operation.</summary>
		[Export ("setNeedsDisplay")]
		void SetNeedsDisplay ();

		/// <param name="r">The rectangle.</param>
		///         <summary>Performs the set needs display in rect operation.</summary>
		[Export ("setNeedsDisplayInRect:")]
		void SetNeedsDisplayInRect (CGRect r);

		/// <summary>Performs the display if needed operation.</summary>
		[Export ("displayIfNeeded")]
		void DisplayIfNeeded ();

		/// <summary>Gets or sets the NeedsDisplayOnBoundsChange value.</summary>
		[Export ("needsDisplayOnBoundsChange")]
		bool NeedsDisplayOnBoundsChange { get; set; }

		/// <param name="ctx">Prepared context to draw into.</param>
		///         <summary>Draws the layer on the specified context.</summary>
		///         <remarks>
		///           <para>
		/// 	    Developers override this method to provide custom
		/// 	    rendering of the contents of their instance of the
		/// 	    CALayer.  If this method is not overwritten, the CALayer
		/// 	    will invoke the <see cref="CoreAnimation.CALayerDelegate.DrawLayer(CoreAnimation.CALayer,CoreGraphics.CGContext)" />
		/// 	    method to render the contents.
		/// 	  </para>
		///           <para>
		/// 	    The provided context has been preconfigured for the target
		/// 	    surface as well as having a clipping region defined.
		/// 	  </para>
		///         </remarks>
		[Export ("drawInContext:")]
		void DrawInContext (CGContext ctx);

		/// <param name="ctx">The context in which the layer should be rendered.</param>
		///         <summary>Renders the layer into the specified <see cref="CoreGraphics.CGContext" />.</summary>
		[Export ("renderInContext:")]
		void RenderInContext (CGContext ctx);

		/// <summary>The background color of the layer.</summary>
		///         <value>
		///           <para>(More documentation for this node is coming)</para>
		///           <para tool="nullallowed">This value can be <see langword="null" />.</para>
		///         </value>
		[NullAllowed]
		[Export ("backgroundColor")]
		CGColor BackgroundColor { get; set; }

		/// <summary>The radius used when drawing rounded corners.</summary>
		///         <value>The default value is 0.</value>
		[Export ("cornerRadius")]
		nfloat CornerRadius { get; set; }

		/// <summary>The width of the border of the layer.</summary>
		///         <value>The default value is 0.</value>
		[Export ("borderWidth")]
		nfloat BorderWidth { get; set; }

		/// <summary>The color of the border of the layer.</summary>
		///         <value>The default value is black.</value>
		[Export ("borderColor")]
		[NullAllowed]
		CGColor BorderColor { get; set; }

		/// <summary>The transparency of the layer, in the range 0 (transparent) to 1.0 (opaque).</summary>
		///         <value>The default value is 1.0.</value>
		[Export ("opacity")]
		float Opacity { get; set; } /* float, not CGFloat */

		/// <summary>Gets or sets the EdgeAntialiasingMask value.</summary>
		[Export ("edgeAntialiasingMask")]
		CAEdgeAntialiasingMask EdgeAntialiasingMask { get; set; }

		// Layout methods

		/// <summary>The preferred size for this layer, in the coordinate of its <see cref="CoreAnimation.CALayer.SuperLayer" />.</summary>
		///         <returns>The result of the operation.</returns>
		[Export ("preferredFrameSize")]
		CGSize PreferredFrameSize ();

		/// <summary>Performs the set needs layout operation.</summary>
		[Export ("setNeedsLayout")]
		void SetNeedsLayout ();

		/// <summary>Performs the needs layout operation.</summary>
		///         <returns>The result of the operation.</returns>
		[Export ("needsLayout")]
		bool NeedsLayout ();

		/// <summary>Performs the layout if needed operation.</summary>
		[Export ("layoutIfNeeded")]
		void LayoutIfNeeded ();

		/// <summary>Performs the layout sublayers operation.</summary>
		[Export ("layoutSublayers")]
		void LayoutSublayers ();

		/// <param name="eventKey">The event key.</param>
		///         <summary>Performs the default action for key operation.</summary>
		///         <returns>The result of the operation.</returns>
		[Static]
		[Export ("defaultActionForKey:")]
		[return: NullAllowed]
		NSObject DefaultActionForKey (string eventKey);

		/// <param name="eventKey">Identifier of the action desired.</param>
		///         <summary>Returns the <see cref="CoreAnimation.CALayer.Actions" /> value associated with the specified key.</summary>
		///         <returns>The result of the operation.</returns>
		[Export ("actionForKey:")]
		[return: NullAllowed]
		NSObject ActionForKey (string eventKey);

		/// <summary>
		///           <see cref="Foundation.NSDictionary" /> containing the layer's actions.</summary>
		///         <value>
		///           <para>The default value is <see langword="null" />.</para>
		///           <para tool="nullallowed">This value can be <see langword="null" />.</para>
		///         </value>
		[NullAllowed] // by default this property is null
		[Export ("actions", ArgumentSemantic.Copy)]
		NSDictionary Actions { get; set; }

		/// <param name="animation">The animation.</param>
		///         <param name="key">
		///           <para>
		/// 	    An identifier for the animation.  If the key already exists in the layer, the previous animation is removed.   
		/// 	  </para>
		///           <para tool="nullallowed">This parameter can be <see langword="null" />.</para>
		///         </param>
		///         <summary>Adds the <paramref name="animation" /> to the render tree for the layer and associates it in <see cref="CoreAnimation.CALayer.Actions" /> with the key <paramref name="key" />.</summary>
		[Export ("addAnimation:forKey:")]
		void AddAnimation (CAAnimation animation, [NullAllowed] string key);

		/// <summary>Removes all animations currently attached to the layer.</summary>
		[Export ("removeAllAnimations")]
		void RemoveAllAnimations ();

		/// <param name="key">The animation's identifier.</param>
		///         <summary>Removes the specified animation from the layer.</summary>
		[Export ("removeAnimationForKey:")]
		void RemoveAnimation (string key);

		/// <summary>Identifiers for the animations associated with this layer.</summary>
		///         <value>
		///           <para>(More documentation for this node is coming)</para>
		///           <para tool="nullallowed">This value can be <see langword="null" />.</para>
		///         </value>
		[Export ("animationKeys"), NullAllowed]
		string [] AnimationKeys { get; }

		/// <param name="key">The animation's identifier.</param>
		///         <summary>Returns the animation associated with the <paramref name="key" />.</summary>
		///         <returns>The <see cref="CoreAnimation.CAAnimation" /> associated with <paramref name="key" /> or <see langword="null" /> if there is no such animation.</returns>
		[Export ("animationForKey:")]
		[return: NullAllowed]
		CAAnimation AnimationForKey (string key);

		/// <summary>Gets or sets the Name value.</summary>
		///         <value>
		///           <para>(More documentation for this node is coming)</para>
		///           <para tool="nullallowed">This value can be <see langword="null" />.</para>
		///         </value>
		[NullAllowed] // by default this property is null
		[Export ("name", ArgumentSemantic.Copy)]
		string Name { get; set; }

		/// <summary>An object that can respond to the delegate protocol for this type</summary>
		///         <value>The instance that will respond to events and data requests.</value>
		///         <remarks>
		///           <para>The delegate instance assigned to this object will be used to handle events or provide data on demand to this class.</para>
		///           <para>When setting the Delegate or WeakDelegate values events will be delivered to the specified instance instead of being delivered to the C#-style events</para>
		///           <para>   Methods must be decorated with the [Export ("selectorName")] attribute to respond to each method from the protocol.   Alternatively use the Delegate method which is strongly typed and does not require the [Export] attributes on methods.</para>
		///         </remarks>
		[Export ("delegate", ArgumentSemantic.Weak)]
		[NullAllowed]
		NSObject WeakDelegate { get; [PostSnippet (@"SetCALayerDelegate (value as CALayerDelegate);", Optimizable = true)] set; }

		/// <summary>An instance of the CoreAnimation.ICALayerDelegate model class which acts as the class delegate.</summary>
		///         <value>The instance of the CoreAnimation.ICALayerDelegate model class</value>
		///         <remarks>
		///           <para>The delegate instance assigned to this object will be used to handle events or provide data on demand to this class.</para>
		///           <para>When setting the Delegate or WeakDelegate values events will be delivered to the specified instance instead of being delivered to the C#-style events</para>
		///           <para>This is the strongly typed version of the object, developers should use the WeakDelegate property instead if they want to merely assign a class derived from NSObject that has been decorated with [Export] attributes.</para>
		///         </remarks>
		[Wrap ("WeakDelegate")]
		ICALayerDelegate Delegate { get; set; }

		/// <summary>Gets or sets the ShadowColor value.</summary>
		[Export ("shadowColor")]
		[NullAllowed]
		CGColor ShadowColor { get; set; }

		/// <summary>Gets or sets the ShadowOffset value.</summary>
		[Export ("shadowOffset")]
		CGSize ShadowOffset { get; set; }

		/// <summary>Gets or sets the ShadowOpacity value.</summary>
		[Export ("shadowOpacity")]
		float ShadowOpacity { get; set; } /* float, not CGFloat */

		/// <summary>Gets or sets the ShadowRadius value.</summary>
		[Export ("shadowRadius")]
		nfloat ShadowRadius { get; set; }

		/// <summary>Represents the value associated with the constant kCATransition</summary>
		///         <value>
		///         </value>
		[Field ("kCATransition")]
		NSString Transition { get; }

		/// <summary>Represents the value associated with the constant kCAGravityCenter</summary>
		///         <value>
		///         </value>
		[Field ("kCAGravityCenter")]
		NSString GravityCenter { get; }

		/// <summary>Represents the value associated with the constant kCAGravityTop</summary>
		///         <value>
		///         </value>
		[Field ("kCAGravityTop")]
		NSString GravityTop { get; }

		/// <summary>Represents the value associated with the constant kCAGravityBottom</summary>
		///         <value>
		///         </value>
		[Field ("kCAGravityBottom")]
		NSString GravityBottom { get; }

		/// <summary>Represents the value associated with the constant kCAGravityLeft</summary>
		///         <value>
		///         </value>
		[Field ("kCAGravityLeft")]
		NSString GravityLeft { get; }

		/// <summary>Represents the value associated with the constant kCAGravityRight</summary>
		///         <value>
		///         </value>
		[Field ("kCAGravityRight")]
		NSString GravityRight { get; }

		/// <summary>Represents the value associated with the constant kCAGravityTopLeft</summary>
		///         <value>
		///         </value>
		[Field ("kCAGravityTopLeft")]
		NSString GravityTopLeft { get; }

		/// <summary>Represents the value associated with the constant kCAGravityTopRight</summary>
		///         <value>
		///         </value>
		[Field ("kCAGravityTopRight")]
		NSString GravityTopRight { get; }

		/// <summary>Represents the value associated with the constant kCAGravityBottomLeft</summary>
		///         <value>
		///         </value>
		[Field ("kCAGravityBottomLeft")]
		NSString GravityBottomLeft { get; }

		/// <summary>Represents the value associated with the constant kCAGravityBottomRight</summary>
		///         <value>
		///         </value>
		[Field ("kCAGravityBottomRight")]
		NSString GravityBottomRight { get; }

		/// <summary>Represents the value associated with the constant kCAGravityResize</summary>
		///         <value>
		///         </value>
		[Field ("kCAGravityResize")]
		NSString GravityResize { get; }

		/// <summary>Represents the value associated with the constant kCAGravityResizeAspect</summary>
		///         <value>
		///         </value>
		[Field ("kCAGravityResizeAspect")]
		NSString GravityResizeAspect { get; }

		/// <summary>Represents the value associated with the constant kCAGravityResizeAspectFill</summary>
		///         <value>
		///         </value>
		[Field ("kCAGravityResizeAspectFill")]
		NSString GravityResizeAspectFill { get; }

		/// <summary>Represents the value associated with the constant kCAFilterNearest</summary>
		///         <value>
		///         </value>
		[Field ("kCAFilterNearest")]
		NSString FilterNearest { get; }

		/// <summary>Represents the value associated with the constant kCAFilterLinear</summary>
		///         <value>
		///         </value>
		[Field ("kCAFilterLinear")]
		NSString FilterLinear { get; }

		/// <summary>Represents the value associated with the constant kCAFilterTrilinear</summary>
		///         <value>
		///         </value>
		[Field ("kCAFilterTrilinear")]
		NSString FilterTrilinear { get; }

		/// <summary>Represents the value associated with the constant kCAOnOrderIn</summary>
		///         <value>
		///         </value>
		[Field ("kCAOnOrderIn")]
		NSString OnOrderIn { get; }

		/// <summary>Represents the value associated with the constant kCAOnOrderOut</summary>
		///         <value>
		///         </value>
		[Field ("kCAOnOrderOut")]
		NSString OnOrderOut { get; }

		[MacCatalyst (13, 1)]
		[Internal]
		[Export ("contentsFormat")]
		NSString _ContentsFormat { get; set; }

		/// <summary>Gets the VisibleRect value.</summary>
		[Export ("visibleRect")]
		CGRect VisibleRect { get; }

		/// <param name="p">The point.</param>
		///         <summary>Performs the scroll point operation.</summary>
		[Export ("scrollPoint:")]
		void ScrollPoint (CGPoint p);

		/// <param name="r">The rectangle.</param>
		///         <summary>Performs the scroll rect to visible operation.</summary>
		[Export ("scrollRectToVisible:")]
		void ScrollRectToVisible (CGRect r);

		/// <summary>An array of Core Image filters applied to the content of this layer and its sublayers.</summary>
		///         <value>
		///           <para>The default value is <see langword="null" />.</para>
		///           <para tool="nullallowed">This value can be <see langword="null" />.</para>
		///         </value>
		[NullAllowed] // by default this property is null
		[Export ("filters", ArgumentSemantic.Copy)]
		CIFilter [] Filters { get; set; }

		/// <summary>An array of Core Image filters that are applied to the content behind this layer.</summary>
		///         <value>
		///           <para>(More documentation for this node is coming)</para>
		///           <para tool="nullallowed">This value can be <see langword="null" />.</para>
		///         </value>
		[NullAllowed] // by default this property is null
		[Export ("backgroundFilters", ArgumentSemantic.Copy)]
		CIFilter [] BackgroundFilters { get; set; }

		/// <summary>Gets or sets the Style value.</summary>
		///         <value>
		///           <para>(More documentation for this node is coming)</para>
		///           <para tool="nullallowed">This value can be <see langword="null" />.</para>
		///         </value>
		[Export ("style", ArgumentSemantic.Copy), NullAllowed]
		NSDictionary Style { get; set; }

		/// <summary>Gets or sets the MinificationFilterBias value.</summary>
		[Export ("minificationFilterBias")]
		float MinificationFilterBias { get; set; } /* float, not CGFloat */

		/// <summary>Gets or sets the AutoresizingMask value.</summary>
		[NoiOS]
		[NoTV]
		[MacCatalyst (13, 1)]
		[Export ("autoresizingMask")]
		CAAutoresizingMask AutoresizingMask { get; set; }

		/// <param name="oldSize">The old size.</param>
		///         <summary>Performs the resize sublayers operation.</summary>
		[NoiOS]
		[NoTV]
		[MacCatalyst (13, 1)]
		[Export ("resizeSublayersWithOldSize:")]
		void ResizeSublayers (CGSize oldSize);

		/// <param name="oldSuperlayerSize">The old superlayer size.</param>
		///         <summary>Performs the resize operation.</summary>
		[NoiOS]
		[NoTV]
		[MacCatalyst (13, 1)]
		[Export ("resizeWithOldSuperlayerSize:")]
		void Resize (CGSize oldSuperlayerSize);

		/// <summary>Gets or sets the Constraints value.</summary>
		[NoiOS]
		[NoTV]
		[MacCatalyst (13, 1)]
		[Export ("constraints")]
		[NullAllowed]
		CAConstraint [] Constraints { get; set; }

		/// <param name="c">The context.</param>
		///         <summary>Performs the add constraint operation.</summary>
		[NoiOS]
		[NoTV]
		[MacCatalyst (13, 1)]
		[Export ("addConstraint:")]
		void AddConstraint (CAConstraint c);

		/// <summary>Gets or sets the ShouldRasterize value.</summary>
		[Export ("shouldRasterize")]
		bool ShouldRasterize { get; set; }

		/// <summary>Gets or sets the ShadowPath value.</summary>
		///         <value>
		///           <para>(More documentation for this node is coming)</para>
		///           <para tool="nullallowed">This value can be <see langword="null" />.</para>
		///         </value>
		[NullAllowed]
		[Export ("shadowPath")]
		CGPath ShadowPath { get; set; }

		/// <summary>Gets or sets the RasterizationScale value.</summary>
		[Export ("rasterizationScale")]
		nfloat RasterizationScale { get; set; }

		/// <summary>Whether drawing commands are deferred and processed asynchronously on a background thread.</summary>
		///         <value>The default value is <see langword="false" />.</value>
		[Export ("drawsAsynchronously")]
		bool DrawsAsynchronously { get; set; }

		/// <summary>Whether edge antialiasing is allowed.</summary>
		///         <value>
		///           <see langword="true" /> if edge antialisting is allowed. By default, antialiasing is allowed for all edges.</value>
		[MacCatalyst (13, 1)]
		[Export ("allowsEdgeAntialiasing")]
		bool AllowsEdgeAntialiasing { get; set; }

		/// <summary>Whether group opacity is allowed.</summary>
		///         <value>
		///           <see langword="true" /> if group opacity is allowed. By default, opacity is allowed for all groups.</value>
		[MacCatalyst (13, 1)]
		[Export ("allowsGroupOpacity")]
		bool AllowsGroupOpacity { get; set; }

		/// <summary>A Core Image filter that is used for compositing the layer and the content behind it.</summary>
		///         <value>
		///           <para>The default value is <see langword="null" />, causing
		/// 	  the layer to use source-over compositing.</para>
		///           <para tool="nullallowed">This value can be <see langword="null" />.</para>
		///         </value>
		[NullAllowed] // by default this property is null
		[Export ("compositingFilter", ArgumentSemantic.Strong)]
		NSObject CompositingFilter { get; set; }

		/// <summary>Gets or sets the MaskedCorners value.</summary>
		[MacCatalyst (13, 1)]
		[Export ("maskedCorners", ArgumentSemantic.Assign)]
		CACornerMask MaskedCorners { get; set; }

		[BindAs (typeof (CACornerCurve))]
		[TV (13, 0)]
		[iOS (13, 0)]
		[MacCatalyst (13, 1)]
		[Export ("cornerCurve")]
		NSString CornerCurve { get; set; }

		[TV (13, 0)]
		[iOS (13, 0)]
		[MacCatalyst (13, 1)]
		[Static]
		[Export ("cornerCurveExpansionFactor:")]
		nfloat GetCornerCurveExpansionFactor ([BindAs (typeof (CACornerCurve))] NSString curve);

		[Obsoleted (PlatformName.iOS, 26, 0, "Use 'PreferredDynamicRange' instead.")]
		[Obsoleted (PlatformName.MacCatalyst, 26, 0, "Use 'PreferredDynamicRange' instead.")]
		[Obsoleted (PlatformName.MacOSX, 26, 0, "Use 'PreferredDynamicRange' instead.")]
		[NoTV]
		[iOS (17, 0)]
		[MacCatalyst (17, 0)]
		[Mac (14, 0)]
		[Export ("wantsExtendedDynamicRangeContent")]
		bool WantsExtendedDynamicRangeContent { get; set; }

		[Mac (15, 0), iOS (18, 0), TV (18, 0), MacCatalyst (18, 0)]
		[Export ("toneMapMode")]
		[BindAs (typeof (CAToneMapMode))]
		NSString ToneMapMode { get; set; }

		[TV (26, 0), MacCatalyst (26, 0), Mac (26, 0), iOS (26, 0)]
		[Export ("preferredDynamicRange", ArgumentSemantic.Copy)]
		NSString WeakPreferredDynamicRange { get; set; }

		[TV (26, 0), MacCatalyst (26, 0), Mac (26, 0), iOS (26, 0)]
		CADynamicRange PreferredDynamicRange {
			[Wrap ("CADynamicRangeExtensions.GetValue (WeakPreferredDynamicRange)")]
			get;
			[Wrap ("WeakPreferredDynamicRange = value.GetConstant ()!")]
			set;
		}

		[TV (26, 0), MacCatalyst (26, 0), Mac (26, 0), iOS (26, 0)]
		[Export ("contentsHeadroom")]
		nfloat ContentsHeadroom { get; set; }

		// From the CARemoteLayerServer (CALayer) category
		[MacCatalyst (13, 1)]
		[Static]
		[Export ("layerWithRemoteClientId:")]
		CALayer GetLayerWithRemoteClientId (uint client_id);
	}

	[TV (13, 0)]
	[iOS (13, 0)]
	[MacCatalyst (13, 1)]
	enum CACornerCurve {
		[DefaultEnumValue]
		[Field ("kCACornerCurveCircular")]
		Circular,
		[Field ("kCACornerCurveContinuous")]
		Continuous,
	}

	[Mac (15, 0), iOS (18, 0), TV (18, 0), MacCatalyst (18, 0)]
	enum CAToneMapMode {
		[DefaultEnumValue]
		[Field ("CAToneMapModeAutomatic")]
		Automatic,
		[Field ("CAToneMapModeNever")]
		Never,
		[Field ("CAToneMapModeIfSupported")]
		IfSupported,
	}

	interface ICAMetalDrawable { }

	/// <summary>Interface that defines AProtocol for a display buffer at the metal layer.</summary>
	[Protocol]
	[MacCatalyst (13, 1)]
	interface CAMetalDrawable : MTLDrawable {
		/// <summary>Gets the Texture value.</summary>
		[Abstract]
		[Export ("texture")]
		IMTLTexture Texture { get; }

		/// <summary>Gets the Layer value.</summary>
		[Abstract]
		[Export ("layer")]
		CAMetalLayer Layer { get; }
	}

	/// <summary>A <see cref="CoreAnimation.CALayer" /> that is rendered using Metal functions.</summary>
	///     
	///     <related type="externalDocumentation" href="https://developer.apple.com/library/ios/documentation/Animation/Reference/CAMetalLayer_Ref/index.html">Apple documentation for <c>CAMetalLayer</c></related>
	[MacCatalyst (13, 1)]
	[BaseType (typeof (CALayer))]
	interface CAMetalLayer {
		/// <summary>Gets or sets the Device value.</summary>
		///         <value>
		///           <para>(More documentation for this node is coming)</para>
		///           <para tool="nullallowed">This value can be <see langword="null" />.</para>
		///         </value>
		[NullAllowed] // by default this property is null
		[Export ("device")]
		IMTLDevice Device { get; set; }

		/// <summary>Gets or sets the PixelFormat value.</summary>
		[Export ("pixelFormat")]
		MTLPixelFormat PixelFormat { get; set; }

		/// <summary>Gets or sets the FramebufferOnly value.</summary>
		[Export ("framebufferOnly")]
		bool FramebufferOnly { get; set; }

		/// <summary>Gets or sets the DrawableSize value.</summary>
		[Export ("drawableSize")]
		CGSize DrawableSize { get; set; }

		/// <summary>Performs the next drawable operation.</summary>
		///         <returns>The result of the operation.</returns>
		[Export ("nextDrawable")]
		[return: NullAllowed]
		ICAMetalDrawable NextDrawable ();

		/// <summary>Gets or sets the PresentsWithTransaction value.</summary>
		[Export ("presentsWithTransaction")]
		bool PresentsWithTransaction { [Bind ("presentsWithTransaction")] get; set; }

		/// <summary>Gets or sets the DisplaySyncEnabled value.</summary>
		[NoTV]
		[NoiOS]
		[MacCatalyst (13, 1)]
		[Export ("displaySyncEnabled")]
		bool DisplaySyncEnabled { get; set; }

		/// <summary>Gets or sets the AllowsNextDrawableTimeout value.</summary>
		[MacCatalyst (13, 1)]
		[Export ("allowsNextDrawableTimeout")]
		bool AllowsNextDrawableTimeout { get; set; }

		/// <summary>Gets or sets the MaximumDrawableCount value.</summary>
		[MacCatalyst (13, 1)]
		[Export ("maximumDrawableCount")]
		nuint MaximumDrawableCount { get; set; }

		[TV (13, 0)]
		[iOS (13, 0)]
		[MacCatalyst (13, 1)]
		[NullAllowed, Export ("colorspace", ArgumentSemantic.Assign)]
		CGColorSpace ColorSpace { get; set; }

		[TV (13, 0)]
		[iOS (13, 0)]
		[MacCatalyst (13, 1)]
		[NullAllowed, Export ("preferredDevice")]
		IMTLDevice PreferredDevice { get; }

		[iOS (16, 0)]
		[NoTV]
		[MacCatalyst (16, 0)]
		[NullAllowed, Export ("EDRMetadata", ArgumentSemantic.Strong)]
		CAEdrMetadata EdrMetadata { get; set; }

		[NoTV]
		[iOS (16, 0)]
		[MacCatalyst (16, 0)]
		[Export ("wantsExtendedDynamicRangeContent")]
		bool WantsExtendedDynamicRangeContent { get; set; }

		[TV (16, 0)]
		[iOS (16, 0)]
		[MacCatalyst (16, 0)]
		[Mac (13, 0)]
		[Export ("developerHUDProperties", ArgumentSemantic.Copy)]
		[NullAllowed]
		// There's no documentation about which values are valid in this dictionary, so we can't create any strong bindings for it.
		NSDictionary DeveloperHudProperties { get; set; }

		[TV (26, 0), MacCatalyst (26, 0), Mac (26, 0), iOS (26, 0)]
		[Export ("residencySet")]
		IMTLResidencySet ResidencySet { get; }
	}

	/// <summary>Layer whose content can be provided asynchronously, and with multiple levels of detail.</summary>
	///     <remarks>
	///       <para>
	///    When you want to use one of the CALayer subclasses as your UIView's backing layer, you need to add the following code snippet to your class:
	/// </para>
	///       <example>
	///         <code lang="csharp lang-csharp"><![CDATA[
	/// class MyView : UIView {
	///     //
	///     // This instructs the runtime that whenever a MyView is created
	///     // that it should instantiate a CATiledLayer and assign that to the
	///     // UIView.Layer property
	///     //
	///     [Export ("layerClass")]
	///     public static Class LayerClass () {
	///         return new Class (typeof (CATilerLayer));
	///     }
	/// }
	///   ]]></code>
	///       </example>
	///     </remarks>
	///     <related type="externalDocumentation" href="https://developer.apple.com/library/ios/documentation/GraphicsImaging/Reference/CATiledLayer_class/index.html">Apple documentation for <c>CATiledLayer</c></related>
	[BaseType (typeof (CALayer))]
	interface CATiledLayer {
		/// <summary>Performs the create operation.</summary>
		///         <returns>The result of the operation.</returns>
		[Export ("layer"), New, Static]
		CALayer Create ();

		/// <summary>Gets the FadeDuration value.</summary>
		[Static]
		[Export ("fadeDuration")]
		double FadeDuration { get; }

		/// <summary>Gets or sets the LevelsOfDetail value.</summary>
		[Export ("levelsOfDetail")]
		nint LevelsOfDetail { get; set; }

		/// <summary>Gets or sets the LevelsOfDetailBias value.</summary>
		[Export ("levelsOfDetailBias")]
		nint LevelsOfDetailBias { get; set; }

		/// <summary>Gets or sets the TileSize value.</summary>
		[Export ("tileSize")]
		CGSize TileSize { get; set; }
	}

	/// <summary>A layer that replicates an existing layer, with some attributes (color, transform) altered.</summary>
	///     <remarks>
	///       <para>
	///    When you want to use one of the CALayer subclasses as your UIView's backing layer, you need to add the following code snippet to your class:
	/// </para>
	///       <example>
	///         <code lang="csharp lang-csharp"><![CDATA[
	/// class MyView : UIView {
	///     //
	///     // This instructs the runtime that whenever a MyView is created
	///     // that it should instantiate a CAReplicatorLayer and assign that to the
	///     // UIView.Layer property
	///     //
	///     [Export ("layerClass")]
	///     public static Class LayerClass () {
	///         return new Class (typeof (CAReplicatorLayer));
	///     }
	/// }
	///   ]]></code>
	///       </example>
	///     </remarks>
	///     <related type="externalDocumentation" href="https://developer.apple.com/library/ios/documentation/GraphicsImaging/Reference/CAReplicatorLayer_class/index.html">Apple documentation for <c>CAReplicatorLayer</c></related>
	[BaseType (typeof (CALayer))]
	interface CAReplicatorLayer {
		/// <summary>Performs the create operation.</summary>
		///         <returns>The result of the operation.</returns>
		[Export ("layer"), New, Static]
		CALayer Create ();

		/// <summary>Gets or sets the InstanceCount value.</summary>
		[Export ("instanceCount")]
		nint InstanceCount { get; set; }

		/// <summary>Gets or sets the InstanceDelay value.</summary>
		[Export ("instanceDelay")]
		double InstanceDelay { get; set; }

		/// <summary>Gets or sets the InstanceTransform value.</summary>
		[Export ("instanceTransform")]
		CATransform3D InstanceTransform { get; set; }

		/// <summary>Gets or sets the PreservesDepth value.</summary>
		[Export ("preservesDepth")]
		bool PreservesDepth { get; set; }

		/// <summary>Gets or sets the InstanceColor value.</summary>
		[Export ("instanceColor")]
		[NullAllowed]
		CGColor InstanceColor { get; set; }

		/// <summary>Gets or sets the InstanceRedOffset value.</summary>
		[Export ("instanceRedOffset")]
		float InstanceRedOffset { get; set; } /* float, not CGFloat */

		/// <summary>Gets or sets the InstanceGreenOffset value.</summary>
		[Export ("instanceGreenOffset")]
		float InstanceGreenOffset { get; set; } /* float, not CGFloat */

		/// <summary>Gets or sets the InstanceBlueOffset value.</summary>
		[Export ("instanceBlueOffset")]
		float InstanceBlueOffset { get; set; } /* float, not CGFloat */

		/// <summary>Gets or sets the InstanceAlphaOffset value.</summary>
		[Export ("instanceAlphaOffset")]
		float InstanceAlphaOffset { get; set; } /* float, not CGFloat */
	}


	/// <summary>Layer used to show portions of another layer.</summary>
	///     <remarks>
	///       <para>
	///    When you want to use one of the CALayer subclasses as your UIView's backing layer, you need to add the following code snippet to your class:
	/// </para>
	///       <example>
	///         <code lang="csharp lang-csharp"><![CDATA[
	/// class MyView : UIView {
	///     //
	///     // This instructs the runtime that whenever a MyView is created
	///     // that it should instantiate a CAScrollLayer and assign that to the
	///     // UIView.Layer property
	///     //
	///     [Export ("layerClass")]
	///     public static Class LayerClass () {
	///         return new Class (typeof (CAScrollLayer));
	///     }
	/// }
	///   ]]></code>
	///       </example>
	///     </remarks>
	///     <related type="externalDocumentation" href="https://developer.apple.com/library/ios/documentation/GraphicsImaging/Reference/CAScrollLayer_class/index.html">Apple documentation for <c>CAScrollLayer</c></related>
	[BaseType (typeof (CALayer))]
	interface CAScrollLayer {
		/// <summary>Creates a new scroll layer with default values.</summary>
		///         <returns>The result of the operation.</returns>
		[Export ("layer"), New, Static]
		CALayer Create ();

		[Protected]
		[Export ("scrollMode", ArgumentSemantic.Copy)]
		NSString WeakScrollMode { get; set; }

		/// <summary>Gets or sets a string that describes the scroll mode.</summary>
		CAScroll ScrollMode {
			[Wrap ("CAScrollExtensions.GetValue (WeakScrollMode)")]
			get;
			[Wrap ("WeakScrollMode = value.GetConstant ()!")]
			set;
		}

		/// <param name="p">The point.</param>
		///         <summary>Scrolls the scroll layer to the supplied point.</summary>
		[Export ("scrollToPoint:")]
		void ScrollToPoint (CGPoint p);

		/// <param name="r">The rectangle.</param>
		///         <summary>Scrolls the scroll layer to include the specified rectangle.</summary>
		[Export ("scrollToRect:")]
		void ScrollToRect (CGRect r);
	}

	/// <summary>Enumerates scrolling directions.</summary>
	enum CAScroll {

		/// <summary>Neither vertical nor horizontal scrolling.</summary>
		[Field ("kCAScrollNone")]
		None,

		/// <summary>Vertical scrolling.</summary>
		[Field ("kCAScrollVertically")]
		Vertically,

		/// <summary>Horizontal scrolling.</summary>
		[Field ("kCAScrollHorizontally")]
		Horizontally,

		/// <summary>Both vertical and horizontal scrolling.</summary>
		[Field ("kCAScrollBoth")]
		Both,
	}

	/// <summary>Draws a bezier curve and composes the result with its first sublayer.</summary>
	///     <remarks>
	///       <para>
	///    When you want to use one of the CALayer subclasses as your UIView's backing layer, you need to add the following code snippet to your class:
	/// </para>
	///       <example>
	///         <code lang="csharp lang-csharp"><![CDATA[
	/// class MyView : UIView {
	///     //
	///     // This instructs the runtime that whenever a MyView is created
	///     // that it should instantiate a CAShapeLayer and assign that to the
	///     // UIView.Layer property
	///     //
	///     [Export ("layerClass")]
	///     public static Class LayerClass () {
	///         return new Class (typeof (CAShapeLayer));
	///     }
	/// }
	///   ]]></code>
	///       </example>
	///     </remarks>
	///     <related type="externalDocumentation" href="https://developer.apple.com/library/ios/documentation/GraphicsImaging/Reference/CAShapeLayer_class/index.html">Apple documentation for <c>CAShapeLayer</c></related>
	[BaseType (typeof (CALayer))]
	interface CAShapeLayer {
		/// <summary>Performs the create operation.</summary>
		///         <returns>The result of the operation.</returns>
		[Export ("layer"), New, Static]
		CALayer Create ();

		/// <summary>Gets or sets the Path value.</summary>
		///         <value>
		///           <para>(More documentation for this node is coming)</para>
		///           <para tool="nullallowed">This value can be <see langword="null" />.</para>
		///         </value>
		[Export ("path")]
		[NullAllowed]
		CGPath Path { get; set; }

		/// <summary>Gets or sets the FillColor value.</summary>
		///         <value>
		///           <para>(More documentation for this node is coming)</para>
		///           <para tool="nullallowed">This value can be <see langword="null" />.</para>
		///         </value>
		[Export ("fillColor")]
		[NullAllowed]
		CGColor FillColor { get; set; }

		/// <summary>Gets the FillRule key constant.</summary>
		[Export ("fillRule", ArgumentSemantic.Copy)]
		NSString FillRule { get; set; }

		/// <summary>Gets the LineCap key constant.</summary>
		[Export ("lineCap", ArgumentSemantic.Copy)]
		NSString LineCap { get; set; }

		/// <summary>Gets or sets the LineDashPattern value.</summary>
		///         <value>
		///           <para>(More documentation for this node is coming)</para>
		///           <para tool="nullallowed">This value can be <see langword="null" />.</para>
		///         </value>
		[Export ("lineDashPattern", ArgumentSemantic.Copy)]
		[NullAllowed]
		NSNumber [] LineDashPattern { get; set; }

		/// <summary>Gets or sets the LineDashPhase value.</summary>
		[Export ("lineDashPhase")]
		nfloat LineDashPhase { get; set; }

		/// <summary>Gets the LineJoin key constant.</summary>
		[Export ("lineJoin", ArgumentSemantic.Copy)]
		NSString LineJoin { get; set; }

		/// <summary>Gets or sets the LineWidth value.</summary>
		[Export ("lineWidth")]
		nfloat LineWidth { get; set; }

		/// <summary>Gets or sets the MiterLimit value.</summary>
		[Export ("miterLimit")]
		nfloat MiterLimit { get; set; }

		/// <summary>Gets or sets the StrokeColor value.</summary>
		///         <value>
		///           <para>(More documentation for this node is coming)</para>
		///           <para tool="nullallowed">This value can be <see langword="null" />.</para>
		///         </value>
		[Export ("strokeColor")]
		[NullAllowed]
		CGColor StrokeColor { get; set; }

		/// <summary>Gets or sets the StrokeStart value.</summary>
		[Export ("strokeStart")]
		nfloat StrokeStart { get; set; }

		/// <summary>Gets or sets the StrokeEnd value.</summary>
		[Export ("strokeEnd")]
		nfloat StrokeEnd { get; set; }

		/// <summary>Represents the value associated with the constant kCALineJoinMiter</summary>
		///         <value>
		///         </value>
		[Field ("kCALineJoinMiter")]
		NSString JoinMiter { get; }

		/// <summary>Represents the value associated with the constant kCALineJoinRound</summary>
		///         <value>
		///         </value>
		[Field ("kCALineJoinRound")]
		NSString JoinRound { get; }

		/// <summary>Represents the value associated with the constant kCALineJoinBevel</summary>
		///         <value>
		///         </value>
		[Field ("kCALineJoinBevel")]
		NSString JoinBevel { get; }

		/// <summary>Represents the value associated with the constant kCALineCapButt</summary>
		///         <value>
		///         </value>
		[Field ("kCALineCapButt")]
		NSString CapButt { get; }

		/// <summary>Represents the value associated with the constant kCALineCapRound</summary>
		///         <value>
		///         </value>
		[Field ("kCALineCapRound")]
		NSString CapRound { get; }

		/// <summary>Represents the value associated with the constant kCALineCapSquare</summary>
		///         <value>
		///         </value>
		[Field ("kCALineCapSquare")]
		NSString CapSquare { get; }

		/// <summary>Represents the value associated with the constant kCAFillRuleNonZero</summary>
		///         <value>
		///         </value>
		[Field ("kCAFillRuleNonZero")]
		NSString FillRuleNonZero { get; }

		/// <summary>Represents the value associated with the constant kCAFillRuleEvenOdd</summary>
		///         <value>
		///         </value>
		[Field ("kCAFillRuleEvenOdd")]
		NSString FillRuleEvenOdd { get; }
	}

	/// <summary>3D compositing layer.</summary>
	///     <remarks>
	///       <para>
	///    When you want to use one of the CALayer subclasses as your UIView's backing layer, you need to add the following code snippet to your class:
	/// </para>
	///       <example>
	///         <code lang="csharp lang-csharp"><![CDATA[
	/// class MyView : UIView {
	///     //
	///     // This instructs the runtime that whenever a MyView is created
	///     // that it should instantiate a CATransformLayer and assign that to the
	///     // UIView.Layer property
	///     //
	///     [Export ("layerClass")]
	///     public static Class LayerClass () {
	///         return new Class (typeof (CATransformLayer));
	///     }
	/// }
	///   ]]></code>
	///       </example>
	///     </remarks>
	///     <related type="externalDocumentation" href="https://developer.apple.com/library/ios/documentation/GraphicsImaging/Reference/CATransformLayer_class/index.html">Apple documentation for <c>CATransformLayer</c></related>
	[BaseType (typeof (CALayer))]
	interface CATransformLayer {
		/// <summary>Performs the create operation.</summary>
		///         <returns>The result of the operation.</returns>
		[Export ("layer"), New, Static]
		CALayer Create ();

		/// <param name="thePoint">The point.</param>
		///         <summary>Performs the hit test operation.</summary>
		///         <returns>The result of the operation.</returns>
		[Export ("hitTest:")]
		CALayer HitTest (CGPoint thePoint);
	}

	enum CATextLayerTruncationMode {
		/// <summary>No truncation.</summary>
		[Field ("kCATruncationNone")]
		None,

		/// <summary>Truncate at the start.</summary>
		[Field ("kCATruncationStart")]
		Start,

		/// <summary>Truncate in the middle.</summary>
		[Field ("kCATruncationMiddle")]
		Middle,

		/// <summary>Truncate at the end.</summary>
		[Field ("kCATruncationEnd")]
		End,
	}

	enum CATextLayerAlignmentMode {
		/// <summary>Left-aligned text.</summary>
		[Field ("kCAAlignmentLeft")]
		Left,

		/// <summary>Right-aligned text.</summary>
		[Field ("kCAAlignmentRight")]
		Right,

		/// <summary>Center-aligned text.</summary>
		[Field ("kCAAlignmentCenter")]
		Center,

		/// <summary>Justified text.</summary>
		[Field ("kCAAlignmentJustified")]
		Justified,

		/// <summary>Natural text alignment.</summary>
		[Field ("kCAAlignmentNatural")]
		Natural,
	}

	/// <summary>Simple text layour and rendering of regular or attributed text.</summary>
	///     <remarks>
	///       <para>
	///    When you want to use one of the CALayer subclasses as your UIView's backing layer, you need to add the following code snippet to your class:
	/// </para>
	///       <example>
	///         <code lang="csharp lang-csharp"><![CDATA[
	/// class MyView : UIView {
	///     //
	///     // This instructs the runtime that whenever a MyView is created
	///     // that it should instantiate a CATextLayer and assign that to the
	///     // UIView.Layer property
	///     //
	///     [Export ("layerClass")]
	///     public static Class LayerClass () {
	///         return new Class (typeof (CATextLayer));
	///     }
	/// }
	///   ]]></code>
	///       </example>
	///     </remarks>
	///     <related type="externalDocumentation" href="https://developer.apple.com/library/ios/documentation/GraphicsImaging/Reference/CATextLayer_class/index.html">Apple documentation for <c>CATextLayer</c></related>
	[BaseType (typeof (CALayer))]
	interface CATextLayer {
		/// <summary>Creates and returns a new <see cref="CoreAnimation.CALayer" />.</summary>
		///         <returns>The result of the operation.</returns>
		[Export ("layer"), New, Static]
		CALayer Create ();

		/// <summary>Gets the text that will be rendered.</summary>
		///         <value>
		///           <para>(More documentation for this node is coming)</para>
		///           <para tool="nullallowed">This value can be <see langword="null" />.</para>
		///         </value>
		[NullAllowed] // by default this property is null
		[Export ("string", ArgumentSemantic.Copy)]
		string String { get; set; }

		[Sealed]
		[Internal]
		[NullAllowed] // by default this property is null
		[Export ("string", ArgumentSemantic.Copy)]
		IntPtr _AttributedString { get; set; }

		/// <summary>Gets or sets the font size.</summary>
		[Export ("fontSize")]
		nfloat FontSize { get; set; }

		[Export ("font"), Internal]
		IntPtr _Font { get; set; }

		/// <summary>Gets or sets the foreground color.</summary>
		[Export ("foregroundColor")]
		[NullAllowed]
		CGColor ForegroundColor { get; set; }

		/// <summary>Gets or sets a Boolean value that controls whether to wrap text to the bounds of the layer.</summary>
		[Export ("wrapped")]
		bool Wrapped { [Bind ("isWrapped")] get; set; }

		/// <summary>Gets the WeakTruncationMode key constant.</summary>
		[Protected]
		[Export ("truncationMode", ArgumentSemantic.Copy)]
		NSString WeakTruncationMode { get; set; }

		/// <summary>Gets the WeakAlignmentMode key constant.</summary>
		[Protected]
		[Export ("alignmentMode", ArgumentSemantic.Copy)]
		NSString WeakAlignmentMode { get; set; }

		/// <summary>Gets or sets a Boolean value that controls whether subpixel quantization is allowed.</summary>
		[MacCatalyst (13, 1)]
		[Export ("allowsFontSubpixelQuantization")]
		bool AllowsFontSubpixelQuantization { get; set; }
	}

	interface ICALayerDelegate { }

	/// <summary>Delegate class for the CALayer.</summary>
	///     
	/// <related type="externalDocumentation" href="https://developer.apple.com/documentation/quartzcore/calayerdelegate">Apple documentation for <c>CALayerDelegate</c></related>
	[BaseType (typeof (NSObject))]
	[Model]
#if IOS || TVOS
	[Protocol (FormalSince = "10.0")]
#elif MONOMAC
	[Protocol (FormalSince = "10.12")]
#else
	[Protocol]
#endif
	interface CALayerDelegate {
		/// <param name="layer">The layer.</param>
		///         <summary>Performs the display layer operation.</summary>
		[Export ("displayLayer:")]
		void DisplayLayer (CALayer layer);

		/// <param name="layer">The layer.</param>
		///         <param name="context">The context.</param>
		///         <summary>Performs the draw layer operation.</summary>
		[Export ("drawLayer:inContext:"), EventArgs ("CALayerDrawEventArgs")]
		void DrawLayer (CALayer layer, CGContext context);

		/// <param name="layer">The layer that will be redrawn.</param>
		///         <summary>Method that is called when <paramref name="layer" /> is about to be drawn.</summary>
		[MacCatalyst (13, 1)]
		[Export ("layerWillDraw:")]
		void WillDrawLayer (CALayer layer);

		/// <param name="layer">The layer.</param>
		///         <summary>Performs the layout sublayers of layer operation.</summary>
		[Export ("layoutSublayersOfLayer:")]
		void LayoutSublayersOfLayer (CALayer layer);

		/// <param name="layer">The layer.</param>
		///         <param name="eventKey">The event key.</param>
		///         <summary>Performs the action for layer operation.</summary>
		///         <returns>The result of the operation.</returns>
		[Export ("actionForLayer:forKey:"), EventArgs ("CALayerDelegateAction"), DefaultValue (null)]
		[return: NullAllowed]
		NSObject ActionForLayer (CALayer layer, string eventKey);
	}

#if HAS_OPENGLES
	/// <summary>Layer
	///  used to render OpenGL content.</summary>
	///     <remarks>
	///       <para>
	///    When you want to use one of the CALayer subclasses as your UIView's backing layer, you need to add the following code snippet to your class:
	/// </para>
	///       <example>
	///         <code lang="csharp lang-csharp"><![CDATA[
	/// class MyView : UIView {
	///     //
	///     // This instructs the runtime that whenever a MyView is created
	///     // that it should instantiate a CAEAGLLayer and assign that to the
	///     // UIView.Layer property
	///     //
	///     [Export ("layerClass")]
	///     public static Class LayerClass () {
	///         return new Class (typeof (CAEAGLLayer));
	///     }
	/// }
	///   ]]></code>
	///       </example>
	///     </remarks>
	///     <related type="externalDocumentation" href="https://developer.apple.com/library/ios/documentation/QuartzCore/Reference/CAEAGLLayer_Class/index.html">Apple documentation for <c>CAEAGLLayer</c></related>
	[NoMac]
	[NoMacCatalyst]
	[Deprecated (PlatformName.TvOS, 12, 0, message: "Use 'CAMetalLayer' instead.")]
	[Deprecated (PlatformName.iOS, 12, 0, message: "Use 'CAMetalLayer' instead.")]
	[BaseType (typeof (CALayer))]
	interface CAEAGLLayer : EAGLDrawable {
		/// <summary>Creates and returns a new <see cref="CoreAnimation.CALayer" />.</summary>
		/// <returns>The result of the operation.</returns>
		[Export ("layer"), New, Static]
		CALayer Create ();

		/// <summary>Gets or sets a Boolean value that controls whether the layer is presented synchronously or asynchronously. <see langword="true" /> indicates synchronous presentation. Default is <see langword="false" /></summary>
		[Export ("presentsWithTransaction")]
		bool PresentsWithTransaction { get; set; }
	}
#endif

	/// <summary>An interface implemented by objects that participate in animations coordinated by a CALayer.</summary>
	///     
	///     <related type="externalDocumentation" href="https://developer.apple.com/library/ios/documentation/GraphicsImaging/Reference/CAAction_protocol/index.html">Apple documentation for <c>CAAction</c></related>
	[BaseType (typeof (NSObject))]
	[Model]
	[Protocol]
	[DisableDefaultCtor]
	interface CAAction {
		/// <param name="eventKey">The event key.</param>
		///         <param name="obj">The object.</param>
		///         <param name="arguments">
		///           <para>A task representing the asynchronous operation.</para>
		///           <para tool="nullallowed">This parameter can be <see langword="null" />.</para>
		///         </param>
		///         <summary>Performs the run action operation.</summary>
		[Abstract]
		[Export ("runActionForKey:object:arguments:")]
		void RunAction (string eventKey, NSObject obj, [NullAllowed] NSDictionary arguments);
	}

#if __MACOS__
	/// <include file="../docs/api/CoreAnimation/CAAnimation.xml" path="/Documentation/Docs[@DocId='T:CoreAnimation.CAAnimation' and contains(@Platforms,'macOS')]/*" />
#else
	/// <include file="../docs/api/CoreAnimation/CAAnimation.xml" path="/Documentation/Docs[@DocId='T:CoreAnimation.CAAnimation' and not(@Platforms)]/*" />
#endif
	[BaseType (typeof (NSObject)
		, Delegates = new string [] { "WeakDelegate" }, Events = new Type [] { typeof (CAAnimationDelegate) }
	)]
	interface CAAnimation : CAAction, CAMediaTiming, NSSecureCoding, NSMutableCopying, SCNAnimationProtocol {
		/// <summary>Creates a new animation, you will use the derived classes static method instead.</summary>
		///         <returns>The result of the operation.</returns>
		[Export ("animation"), Static]
		CAAnimation CreateAnimation ();

		/// <param name="key">
		///           <para>A task representing the asynchronous operation.</para>
		///           <para tool="nullallowed">This parameter can be <see langword="null" />.</para>
		///         </param>
		///         <summary>The default value used for the given object.</summary>
		///         <returns>The result of the operation.</returns>
		[Static]
		[Export ("defaultValueForKey:")]
		[return: NullAllowed]
		NSObject DefaultValue (string key);

		/// <summary>The timing function used to compute the animation.</summary>
		///         <value>
		///           <para>(More documentation for this node is coming)</para>
		///           <para tool="nullallowed">This value can be <see langword="null" />.</para>
		///         </value>
		[NullAllowed] // by default this property is null
		[Export ("timingFunction", ArgumentSemantic.Strong)]
		CAMediaTimingFunction TimingFunction { get; set; }

		// before that we need to be wrap this manually to avoid the BI1110 error
		/// <summary>An instance of the CoreAnimation.CAAnimationDelegate model class which acts as the class delegate.</summary>
		///         <value>The instance of the CoreAnimation.CAAnimationDelegate model class</value>
		///         <remarks>
		///           <para>The delegate instance assigned to this object will be used to handle events or provide data on demand to this class.</para>
		///           <para>When setting the Delegate or WeakDelegate values events will be delivered to the specified instance instead of being delivered to the C#-style events</para>
		///           <para>This is the strongly typed version of the object, developers should use the WeakDelegate property instead if they want to merely assign a class derived from NSObject that has been decorated with [Export] attributes.</para>
		///         </remarks>
		[Wrap ("WeakDelegate")]
		ICAAnimationDelegate Delegate { get; set; }

		/// <summary>An object that can respond to the delegate protocol for this type</summary>
		///         <value>The instance that will respond to events and data requests.</value>
		///         <remarks>
		///           <para>The delegate instance assigned to this object will be used to handle events or provide data on demand to this class.</para>
		///           <para>When setting the Delegate or WeakDelegate values events will be delivered to the specified instance instead of being delivered to the C#-style events</para>
		///           <para>   Methods must be decorated with the [Export ("selectorName")] attribute to respond to each method from the protocol.   Alternatively use the Delegate method which is strongly typed and does not require the [Export] attributes on methods.</para>
		///         </remarks>
		[Export ("delegate", ArgumentSemantic.Strong)]
		[NullAllowed]
		NSObject WeakDelegate { get; set; }

		/// <summary>Whether the animation is removed from the layer on completion.</summary>
		[Export ("removedOnCompletion")]
		bool RemovedOnCompletion { [Bind ("isRemovedOnCompletion")] get; set; }

		/// <param name="key">The key.</param>
		///         <summary>With key-value observing, indicates that the value associated with <paramref name="key" /> is about to change.</summary>
		[Export ("willChangeValueForKey:")]
		void WillChangeValueForKey (string key);

		/// <param name="key">The key.</param>
		///         <summary>As part of key-value observing, indicates that the value represented by <paramref name="key" /> has changed.</summary>
		[Export ("didChangeValueForKey:")]
		void DidChangeValueForKey (string key);

		/// <param name="key">
		///           <para>A task representing the asynchronous operation.</para>
		///           <para tool="nullallowed">This parameter can be <see langword="null" />.</para>
		///         </param>
		///         <summary>Whether the value for the given key should be archived.</summary>
		///         <returns>The result of the operation.</returns>
		[Export ("shouldArchiveValueForKey:")]
		bool ShouldArchiveValueForKey (string key);

		/// <summary>Represents the value associated with the constant kCATransitionFade</summary>
		///         <value>
		///         </value>
		[Field ("kCATransitionFade")]
		NSString TransitionFade { get; }

		/// <summary>Represents the value associated with the constant kCATransitionMoveIn</summary>
		///         <value>
		///         </value>
		[Field ("kCATransitionMoveIn")]
		NSString TransitionMoveIn { get; }

		/// <summary>Represents the value associated with the constant kCATransitionPush</summary>
		///         <value>
		///         </value>
		[Field ("kCATransitionPush")]
		NSString TransitionPush { get; }

		/// <summary>Represents the value associated with the constant kCATransitionReveal</summary>
		///         <value>
		///         </value>
		[Field ("kCATransitionReveal")]
		NSString TransitionReveal { get; }

		/// <summary>Represents the value associated with the constant kCATransitionFromRight</summary>
		///         <value>
		///         </value>
		[Field ("kCATransitionFromRight")]
		NSString TransitionFromRight { get; }

		/// <summary>Represents the value associated with the constant kCATransitionFromLeft</summary>
		///         <value>
		///         </value>
		[Field ("kCATransitionFromLeft")]
		NSString TransitionFromLeft { get; }

		/// <summary>Represents the value associated with the constant kCATransitionFromTop</summary>
		///         <value>
		///         </value>
		[Field ("kCATransitionFromTop")]
		NSString TransitionFromTop { get; }

		/// <summary>Represents the value associated with the constant kCATransitionFromBottom</summary>
		///         <value>
		///         </value>
		[Field ("kCATransitionFromBottom")]
		NSString TransitionFromBottom { get; }

		/* 'calculationMode' strings. */
		/// <summary>Represents the value associated with the constant kCAAnimationLinear</summary>
		///         <value>
		///         </value>
		[Field ("kCAAnimationLinear")]
		NSString AnimationLinear { get; }

		/// <summary>Represents the value associated with the constant kCAAnimationDiscrete</summary>
		[Field ("kCAAnimationDiscrete")]
		NSString AnimationDiscrete { get; }

		/// <summary>Represents the value associated with the constant kCAAnimationPaced</summary>
		///         <value>
		///         </value>
		[Field ("kCAAnimationPaced")]
		NSString AnimationPaced { get; }

		/// <summary>Represents the value associated with the constant kCAAnimationCubic</summary>
		///         <value>
		///         </value>
		[Field ("kCAAnimationCubic")]
		NSString AnimationCubic { get; }

		/// <summary>Represents the value associated with the constant kCAAnimationCubicPaced</summary>
		///         <value>
		///         </value>
		[Field ("kCAAnimationCubicPaced")]
		NSString AnimationCubicPaced { get; }

		/* 'rotationMode' strings. */
		/// <summary>Represents the value associated with the constant kCAAnimationRotateAuto</summary>
		///         <value>
		///         </value>
		[Field ("kCAAnimationRotateAuto")]
		NSString RotateModeAuto { get; }

		/// <summary>Represents the value associated with the constant kCAAnimationRotateAutoReverse</summary>
		///         <value>
		///         </value>
		[Field ("kCAAnimationRotateAutoReverse")]
		NSString RotateModeAutoReverse { get; }

		#region SceneKitAdditions

		/// <param name="animation">The animation.</param>
		///         <summary>Performs the from s c n animation operation.</summary>
		///         <returns>The result of the operation.</returns>
		[MacCatalyst (13, 1)]
		[Static]
		[Export ("animationWithSCNAnimation:")]
		CAAnimation FromSCNAnimation (SCNAnimation animation);

		/// <summary>Gets or sets the UsesSceneTimeBase value.</summary>
		[MacCatalyst (13, 1)]
		[Export ("usesSceneTimeBase")]
		bool UsesSceneTimeBase { get; set; }

		/// <summary>Gets or sets the FadeInDuration value.</summary>
		[MacCatalyst (13, 1)]
		[Export ("fadeInDuration")]
		nfloat FadeInDuration { get; set; }

		/// <summary>Gets or sets the FadeOutDuration value.</summary>
		[MacCatalyst (13, 1)]
		[Export ("fadeOutDuration")]
		nfloat FadeOutDuration { get; set; }

		/// <summary>Gets or sets the AnimationEvents value.</summary>
		///         <value>
		///           <para>(More documentation for this node is coming)</para>
		///           <para tool="nullallowed">This value can be <see langword="null" />.</para>
		///         </value>
		[MacCatalyst (13, 1)]
		[NullAllowed] // by default this property is null
		[Export ("animationEvents", ArgumentSemantic.Retain)]
		SCNAnimationEvent [] AnimationEvents { get; set; }

		#endregion

		[TV (15, 0), iOS (15, 0), MacCatalyst (15, 0)]
		[Export ("preferredFrameRateRange", ArgumentSemantic.Assign)]
		CAFrameRateRange PreferredFrameRateRange { get; set; }
	}

	interface ICAAnimationDelegate { }

	/// <summary>Delegate for responding to animation lifecycle events.</summary>
	[BaseType (typeof (NSObject))]
#if IOS || TVOS
	[Protocol (FormalSince = "10.0")]
#elif MONOMAC
	[Protocol (FormalSince = "10.12")]
#else
	[Synthetic]
#endif
	[Model]
	interface CAAnimationDelegate {
		/// <param name="anim">
		///           <para>A task representing the asynchronous operation.</para>
		///           <para tool="nullallowed">This parameter can be <see langword="null" />.</para>
		///         </param>
		///         <summary>The animation has started.</summary>
		[EventArgs ("", XmlDocs = """
			<summary>Event raised by the object.</summary>
			<remarks>If developers do not assign a value to this event, this will reset the value for the WeakDelegate property to an internal handler that maps delegates to events.</remarks>
			""")]
		[Export ("animationDidStart:")]
		void AnimationStarted (CAAnimation anim);

		/// <param name="anim">
		///           <para>A task representing the asynchronous operation.</para>
		///           <para tool="nullallowed">This parameter can be <see langword="null" />.</para>
		///         </param>
		///         <param name="finished">Whether the animation finished.</param>
		///         <summary>The animation has stopped.  Use the bool value to determine if this is a temporary pause, or the end of the animation.</summary>
		[Export ("animationDidStop:finished:"), EventArgs ("CAAnimationState", XmlDocs = """
			<summary>Event raised by the object.</summary>
			<remarks>If developers do not assign a value to this event, this will reset the value for the WeakDelegate property to an internal handler that maps delegates to events.</remarks>
			""")]
		void AnimationStopped (CAAnimation anim, bool finished);

	}

	/// <summary>An animation that can animate object properties.</summary>
	///     <remarks>For a list of common properties to animate, see the documentation for <see cref="CoreAnimation.CAPropertyAnimation.KeyPath" /></remarks>
	///     <related type="externalDocumentation" href="https://developer.apple.com/library/ios/documentation/GraphicsImaging/Reference/CAPropertyAnimation_class/index.html">Apple documentation for <c>CAPropertyAnimation</c></related>
	[BaseType (typeof (CAAnimation))]
	interface CAPropertyAnimation {
		/// <include file="../docs/api/CoreAnimation/CAPropertyAnimation.xml" path="/Documentation/Docs[@DocId='M:CoreAnimation.CAPropertyAnimation.FromKeyPath(System.String)']/*" />
		[Static]
		[Export ("animationWithKeyPath:")]
		CAPropertyAnimation FromKeyPath ([NullAllowed] string path);

		/// <summary>Gets or sets the KeyPath value.</summary>
		///         <value>
		///           <para>(More documentation for this node is coming)</para>
		///           <para tool="nullallowed">This value can be <see langword="null" />.</para>
		///         </value>
		[NullAllowed] // by default this property is null
		[Export ("keyPath", ArgumentSemantic.Copy)]
		string KeyPath { get; set; }

		/// <summary>Gets or sets the Additive value.</summary>
		[Export ("additive")]
		bool Additive { [Bind ("isAdditive")] get; set; }

		/// <summary>Gets or sets the Cumulative value.</summary>
		[Export ("cumulative")]
		bool Cumulative { [Bind ("isCumulative")] get; set; }

		/// <summary>Gets or sets the ValueFunction value.</summary>
		///         <value>
		///           <para>(More documentation for this node is coming)</para>
		///           <para tool="nullallowed">This value can be <see langword="null" />.</para>
		///         </value>
		[NullAllowed] // by default this property is null
		[Export ("valueFunction", ArgumentSemantic.Strong)]
		CAValueFunction ValueFunction { get; set; }
	}

	/// <include file="../docs/api/CoreAnimation/CABasicAnimation.xml" path="/Documentation/Docs[@DocId='T:CoreAnimation.CABasicAnimation']/*" />
	[BaseType (typeof (CAPropertyAnimation))]
	interface CABasicAnimation {
		/// <param name="path">
		///           <para>A string representing the keypath for the animation.</para>
		///           <para tool="nullallowed">This parameter can be <see langword="null" />.</para>
		///         </param>
		///         <summary>Creates an animation from the given key path.</summary>
		///         <returns>The new animation.</returns>
		///         <remarks>See the base class FromKeyPath for information on the values for the key path.</remarks>
		[Static, New, Export ("animationWithKeyPath:")]
		CABasicAnimation FromKeyPath ([NullAllowed] string path);

		[Export ("fromValue", ArgumentSemantic.Strong)]
		[Internal]
		[Sealed]
		IntPtr _From { get; set; }

		/// <summary>Initial value for the property to animate.</summary>
		///         <value>
		///           <para>(More documentation for this node is coming)</para>
		///           <para tool="nullallowed">This value can be <see langword="null" />.</para>
		///         </value>
		[Export ("fromValue", ArgumentSemantic.Strong)]
		[NullAllowed]
		NSObject From { get; set; }

		[Export ("toValue", ArgumentSemantic.Strong)]
		[Internal]
		[Sealed]
		IntPtr _To { get; set; }

		/// <summary>Destination value for the property to animate.</summary>
		///         <value>
		///           <para>Final value that the property will have.</para>
		///           <para tool="nullallowed">This value can be <see langword="null" />.</para>
		///         </value>
		///         <remarks>
		///         </remarks>
		[Export ("toValue", ArgumentSemantic.Strong)]
		[NullAllowed]
		NSObject To { get; set; }

		[Export ("byValue", ArgumentSemantic.Strong)]
		[Internal]
		[Sealed]
		IntPtr _By { get; set; }

		/// <summary>Value to increment by.</summary>
		///         <value>
		///           <para>(More documentation for this node is coming)</para>
		///           <para tool="nullallowed">This value can be <see langword="null" />.</para>
		///         </value>
		[Export ("byValue", ArgumentSemantic.Strong)]
		[NullAllowed]
		NSObject By { get; set; }
	}

	/// <summary>A spring animation with stiffness, mass, and damping.</summary>
	///     
	/// <related type="externalDocumentation" href="https://developer.apple.com/documentation/quartzcore/caspringanimation">Apple documentation for <c>CASpringAnimation</c></related>
	[MacCatalyst (13, 1)]
	[BaseType (typeof (CABasicAnimation))]
	interface CASpringAnimation {
		/// <param name="path">
		///           <para>A task representing the asynchronous operation.</para>
		///           <para tool="nullallowed">This parameter can be <see langword="null" />.</para>
		///         </param>
		///         <summary>Creates a new animation from the specified key path.</summary>
		///         <returns>The result of the operation.</returns>
		[Static, New, Export ("animationWithKeyPath:")]
		CABasicAnimation FromKeyPath ([NullAllowed] string path);

		/// <summary>Gets or sets the mass for the animation.</summary>
		[Export ("mass")]
		nfloat Mass { get; set; }

		/// <summary>Gets or sets the stiffness of the spring for the animation.</summary>
		[Export ("stiffness")]
		nfloat Stiffness { get; set; }

		/// <summary>Gets or sets the damping for the spring animation.</summary>
		[Export ("damping")]
		nfloat Damping { get; set; }

		/// <summary>Gets or sets the initial velocity of the animation.</summary>
		[Export ("initialVelocity")]
		nfloat InitialVelocity { get; set; }

		/// <summary>Gets the settling time for the animation.</summary>
		[Export ("settlingDuration")]
		double /* CFTimeInterval */ SettlingDuration { get; }

		[iOS (17, 0), TV (17, 0), MacCatalyst (17, 0), Mac (14, 0)]
		[Export ("allowsOverdamping")]
		bool AllowsOverdamping { get; set; }

		[iOS (17, 0), TV (17, 0), MacCatalyst (17, 0), Mac (14, 0)]
		[Export ("initWithPerceptualDuration:bounce:")]
		NativeHandle Constructor (double /* CFTimeInterval */ perceptualDuration, nfloat bounce);

		[iOS (17, 0), TV (17, 0), MacCatalyst (17, 0), Mac (14, 0)]
		[Export ("perceptualDuration")]
		double /* CFTimeInterval */ PerceptualDuration { get; }

		[iOS (17, 0), TV (17, 0), MacCatalyst (17, 0), Mac (14, 0)]
		[Export ("bounce")]
		nfloat Bounce { get; }
	}

	/// <summary>Keyframe-based animation support.</summary>
	///     
	///     <related type="externalDocumentation" href="https://developer.apple.com/library/ios/documentation/GraphicsImaging/Reference/CAKeyframeAnimation_class/index.html">Apple documentation for <c>CAKeyframeAnimation</c></related>
	[BaseType (typeof (CAPropertyAnimation), Name = "CAKeyframeAnimation")]
	interface CAKeyFrameAnimation {
		/// <param name="path">
		///           <para>A task representing the asynchronous operation.</para>
		///           <para tool="nullallowed">This parameter can be <see langword="null" />.</para>
		///         </param>
		///         <summary>Performs the from key path operation.</summary>
		///         <returns>The result of the operation.</returns>
		[Static, Export ("animationWithKeyPath:")]
		CAKeyFrameAnimation FromKeyPath ([NullAllowed] string path);

		/// <summary>Sets the key frame animation values.</summary>
		///         <value>
		///           <para tool="nullallowed">This value can be <see langword="null" />.</para>
		///         </value>
		///         <remarks>
		///           <para>
		/// 	    To pass number, create instances of <see cref="Foundation.NSNumber" /> with the value,
		/// 	    to pass other values, use <see cref="Foundation.NSValue" />.
		///
		/// 	  </para>
		///           <para>
		/// 	    If you need to pass CoreGraphics objects, or retrieve
		/// 	    elements from the key frame that might contain CoreGraphics
		/// 	    objects, you should use the <see cref="CoreAnimation.CAKeyFrameAnimation.SetValues" /> and
		/// 	    <see cref="CoreAnimation.CAKeyFrameAnimation.GetValuesAs{T}" /> methods instead.
		///
		/// 	  </para>
		///         </remarks>
		[NullAllowed] // by default this property is null
		[Export ("values", ArgumentSemantic.Copy)]
		NSObject [] Values { get; set; }

		[Export ("values", ArgumentSemantic.Strong)]
		[Internal]
		[Sealed]
		NSArray _Values { get; set; }

		/// <summary>Gets or sets the Path value.</summary>
		///         <value>
		///           <para>(More documentation for this node is coming)</para>
		///           <para tool="nullallowed">This value can be <see langword="null" />.</para>
		///         </value>
		[NullAllowed]
		[Export ("path")]
		CGPath Path { get; set; }

		/// <summary>Gets or sets the KeyTimes value.</summary>
		///         <value>
		///           <para>(More documentation for this node is coming)</para>
		///           <para tool="nullallowed">This value can be <see langword="null" />.</para>
		///         </value>
		[Export ("keyTimes", ArgumentSemantic.Copy)]
		[NullAllowed]
		NSNumber [] KeyTimes { get; set; }

		/// <summary>Gets or sets the TimingFunctions value.</summary>
		///         <value>
		///           <para>(More documentation for this node is coming)</para>
		///           <para tool="nullallowed">This value can be <see langword="null" />.</para>
		///         </value>
		[NullAllowed] // by default this property is null
		[Export ("timingFunctions", ArgumentSemantic.Copy)]
		CAMediaTimingFunction [] TimingFunctions { get; set; }

		[Export ("calculationMode", ArgumentSemantic.Copy)]
		[Internal]
		NSString _CalculationMode { get; set; }

		/// <summary>Gets or sets the RotationMode value.</summary>
		///         <value>
		///           <para>(More documentation for this node is coming)</para>
		///           <para tool="nullallowed">This value can be <see langword="null" />.</para>
		///         </value>
		[Export ("rotationMode", ArgumentSemantic.Copy)]
		[NullAllowed]
		string RotationMode { get; set; }

		/// <summary>Gets or sets the TensionValues value.</summary>
		///         <value>
		///           <para>(More documentation for this node is coming)</para>
		///           <para tool="nullallowed">This value can be <see langword="null" />.</para>
		///         </value>
		[NullAllowed] // by default this property is null
		[Export ("tensionValues", ArgumentSemantic.Copy)]
		NSNumber [] TensionValues { get; set; }

		/// <summary>Gets or sets the ContinuityValues value.</summary>
		///         <value>
		///           <para>(More documentation for this node is coming)</para>
		///           <para tool="nullallowed">This value can be <see langword="null" />.</para>
		///         </value>
		[NullAllowed] // by default this property is null
		[Export ("continuityValues", ArgumentSemantic.Copy)]
		NSNumber [] ContinuityValues { get; set; }

		/// <summary>Gets or sets the BiasValues value.</summary>
		///         <value>
		///           <para>(More documentation for this node is coming)</para>
		///           <para tool="nullallowed">This value can be <see langword="null" />.</para>
		///         </value>
		[NullAllowed] // by default this property is null
		[Export ("biasValues", ArgumentSemantic.Copy)]
		NSNumber [] BiasValues { get; set; }
	}

	/// <summary>Transition animations for a layer.</summary>
	///     
	///     <related type="externalDocumentation" href="https://developer.apple.com/library/ios/documentation/GraphicsImaging/Reference/CATransition_class/index.html">Apple documentation for <c>CATransition</c></related>
	[BaseType (typeof (CAAnimation))]
	interface CATransition {
		/// <summary>Performs the create animation operation.</summary>
		///         <returns>The result of the operation.</returns>
		[Export ("animation"), Static, New]
		CATransition CreateAnimation ();

		/// <summary>Gets or sets the Type value.</summary>
		[Export ("type", ArgumentSemantic.Copy)]
		string Type { get; set; }

		/// <summary>Gets or sets the Subtype value.</summary>
		///         <value>
		///           <para>(More documentation for this node is coming)</para>
		///           <para tool="nullallowed">This value can be <see langword="null" />.</para>
		///         </value>
		[NullAllowed] // by default this property is null
		[Export ("subtype", ArgumentSemantic.Copy)]
		string Subtype { get; set; }

		/// <summary>Gets or sets the StartProgress value.</summary>
		[Export ("startProgress")]
		float StartProgress { get; set; } /* float, not CGFloat */

		/// <summary>Gets or sets the EndProgress value.</summary>
		[Export ("endProgress")]
		float EndProgress { get; set; } /* float, not CGFloat */

		/// <summary>Gets or sets the Filter value.</summary>
		///         <value>
		///           <para>(More documentation for this node is coming)</para>
		///           <para tool="nullallowed">This value can be <see langword="null" />.</para>
		///         </value>
		[Export ("filter", ArgumentSemantic.Strong)]
		[NullAllowed]
		NSObject Filter { get; set; }
	}

	/// <summary>Constants used for the FillMode property in CAAnimation and CALayer, used to control the behavior of objects once the animation has completed.</summary>
	///     <remarks>These are used in the FillMode property of CAAnimation and CALayer.</remarks>
	[Static]
	interface CAFillMode {
		/// <summary>Represents the value associated with the constant kCAFillModeForwards</summary>
		///         <value>
		///         </value>
		[Field ("kCAFillModeForwards")]
		NSString Forwards { get; }

		/// <summary>Represents the value associated with the constant kCAFillModeBackwards</summary>
		///         <value>
		///         </value>
		[Field ("kCAFillModeBackwards")]
		NSString Backwards { get; }

		/// <summary>Represents the value associated with the constant kCAFillModeBoth</summary>
		///         <value>
		///         </value>
		[Field ("kCAFillModeBoth")]
		NSString Both { get; }

		/// <summary>Represents the value associated with the constant kCAFillModeRemoved</summary>
		///         <value>
		///         </value>
		[Field ("kCAFillModeRemoved")]
		NSString Removed { get; }
	}

	/// <summary>Framework to synchronize multiple transformation operations.</summary>
	///     
	///     <related type="externalDocumentation" href="https://developer.apple.com/library/ios/documentation/GraphicsImaging/Reference/CATransaction_class/index.html">Apple documentation for <c>CATransaction</c></related>
	[BaseType (typeof (NSObject))]
	interface CATransaction {
		/// <summary>Performs the begin operation.</summary>
		[Static]
		[Export ("begin")]
		void Begin ();

		/// <summary>Performs the commit operation.</summary>
		[Static]
		[Export ("commit")]
		void Commit ();

		/// <summary>Performs the flush operation.</summary>
		[Static]
		[Export ("flush")]
		void Flush ();

		/// <summary>Performs the lock operation.</summary>
		[Static]
		[Export ("lock")]
		void Lock ();

		/// <summary>Performs the unlock operation.</summary>
		[Static]
		[Export ("unlock")]
		void Unlock ();

		/// <summary>Gets or sets the AnimationDuration value.</summary>
		[Static]
		[Export ("animationDuration")]
		double AnimationDuration { get; set; }

		/// <summary>Gets or sets the AnimationTimingFunction value.</summary>
		///         <value>
		///           <para>(More documentation for this node is coming)</para>
		///           <para tool="nullallowed">This value can be <see langword="null" />.</para>
		///         </value>
		[Static, NullAllowed]
		[Export ("animationTimingFunction")]
		CAMediaTimingFunction AnimationTimingFunction { get; set; }

		/// <summary>Gets or sets the DisableActions value.</summary>
		[Static]
		[Export ("disableActions")]
		bool DisableActions { get; set; }

		/// <param name="key">The key.</param>
		///         <summary>Performs the value for key operation.</summary>
		///         <returns>The result of the operation.</returns>
		[Static]
		[Export ("valueForKey:")]
		[return: NullAllowed]
		NSObject ValueForKey (NSString key);

		/// <param name="anObject">
		///           <para>A task representing the asynchronous operation.</para>
		///           <para tool="nullallowed">This parameter can be <see langword="null" />.</para>
		///         </param>
		///         <param name="key">The key.</param>
		///         <summary>Performs the set value for key operation.</summary>
		[Static]
		[Export ("setValue:forKey:")]
		void SetValueForKey ([NullAllowed] NSObject anObject, NSString key);

		/// <summary>Gets or sets the CompletionBlock value.</summary>
		///         <value>
		///           <para>(More documentation for this node is coming)</para>
		///           <para tool="nullallowed">This value can be <see langword="null" />.</para>
		///         </value>
		[Static, Export ("completionBlock"), NullAllowed]
		Action CompletionBlock { get; set; }

		/// <summary>Represents the value associated with the constant kCATransactionAnimationDuration</summary>
		///         <value>
		///         </value>
		[Field ("kCATransactionAnimationDuration")]
		NSString AnimationDurationKey { get; }

		/// <summary>Represents the value associated with the constant kCATransactionDisableActions</summary>
		///         <value>
		///         </value>
		[Field ("kCATransactionDisableActions")]
		NSString DisableActionsKey { get; }

		/// <summary>Represents the value associated with the constant kCATransactionAnimationTimingFunction</summary>
		///         <value>
		///         </value>
		[Field ("kCATransactionAnimationTimingFunction")]
		NSString TimingFunctionKey { get; }

		/// <summary>Represents the value associated with the constant kCATransactionCompletionBlock</summary>
		///         <value>
		///         </value>
		[Field ("kCATransactionCompletionBlock")]
		NSString CompletionBlockKey { get; }
	}

	/// <summary>Groups and orchestrates multiple animations.</summary>
	///     
	///     <related type="externalDocumentation" href="https://developer.apple.com/library/ios/documentation/GraphicsImaging/Reference/CAAnimationGroup_class/index.html">Apple documentation for <c>CAAnimationGroup</c></related>
	[BaseType (typeof (CAAnimation))]
	interface CAAnimationGroup {
		/// <summary>An array of the animations in this group.</summary>
		///         <value>
		///           <para>(More documentation for this node is coming)</para>
		///           <para tool="nullallowed">This value can be <see langword="null" />.</para>
		///         </value>
		[NullAllowed] // by default this property is null
		[Export ("animations", ArgumentSemantic.Copy)]
		CAAnimation [] Animations { get; set; }

		/// <summary>Factory method that creates a new CAAnimationGroup.</summary>
		///         <returns>The result of the operation.</returns>
		[Export ("animation"), Static, New]
		CAAnimationGroup CreateAnimation ();
	}

	/// <summary>Layer that renders a gradient over its background.</summary>
	///     <remarks>
	///       <para>
	///    When you want to use one of the CALayer subclasses as your UIView's backing layer, you need to add the following code snippet to your class:
	/// </para>
	///       <example>
	///         <code lang="csharp lang-csharp"><![CDATA[
	/// class MyView : UIView {
	///     //
	///     // This instructs the runtime that whenever a MyView is created
	///     // that it should instantiate a CAGradientLayer and assign that to the
	///     // UIView.Layer property
	///     //
	///     [Export ("layerClass")]
	///     public static Class LayerClass () {
	///         return new Class (typeof (CAGradientLayer));
	///     }
	/// }
	///   ]]></code>
	///       </example>
	///     </remarks>
	///     <related type="externalDocumentation" href="https://developer.apple.com/library/ios/documentation/GraphicsImaging/Reference/CAGradientLayer_class/index.html">Apple documentation for <c>CAGradientLayer</c></related>
	[BaseType (typeof (CALayer))]
	interface CAGradientLayer {
		/// <summary>Performs the create operation.</summary>
		///         <returns>The result of the operation.</returns>
		[Export ("layer"), New, Static]
		CALayer Create ();

		[NullAllowed] // by default this property is null
		[Export ("colors", ArgumentSemantic.Copy)]
		[Internal]
		IntPtr _Colors { get; set; }

		/// <summary>Optional array of NSNumbers that describe the position of each gradient stop.   This property can be animated.</summary>
		///         <value>
		///           <para>(More documentation for this node is coming)</para>
		///           <para tool="nullallowed">This value can be <see langword="null" />.</para>
		///         </value>
		[NullAllowed] // by default this property is null
		[Export ("locations", ArgumentSemantic.Copy)]
		NSNumber [] Locations { get; set; }

		/// <summary>Starting point for the gradient.</summary>
		[Export ("startPoint")]
		CGPoint StartPoint { get; set; }

		/// <summary>The end point for the gradient.   This property can be animated.</summary>
		[Export ("endPoint")]
		CGPoint EndPoint { get; set; }

		/// <summary>The gradient type displayed.</summary>
		CAGradientLayerType LayerType {
			[Wrap ("CAGradientLayerTypeExtensions.GetValue (WeakLayerType)")]
			get;
			[Wrap ("WeakLayerType = value.GetConstant ()!")]
			set;
		}

		[Export ("type", ArgumentSemantic.Copy)]
		NSString WeakLayerType { get; set; }
	}

	enum CAGradientLayerType {
		/// <summary>The axial value.</summary>
		[Field ("kCAGradientLayerAxial")]
		Axial,

		/// <summary>The radial value.</summary>
		[MacCatalyst (13, 1)]
		[Field ("kCAGradientLayerRadial")]
		Radial,

		/// <summary>The conic value.</summary>
		[MacCatalyst (13, 1)]
		[Field ("kCAGradientLayerConic")]
		Conic,
	}

	/// <summary>Defines the pacing of an animation.</summary>
	///     
	///     <related type="externalDocumentation" href="https://developer.apple.com/library/ios/documentation/Cocoa/Reference/CAMediaTimingFunction_class/index.html">Apple documentation for <c>CAMediaTimingFunction</c></related>
	[BaseType (typeof (NSObject))]
	[DisableDefaultCtor]
	interface CAMediaTimingFunction : NSSecureCoding {
		/// <param name="name">The name.</param>
		///         <summary>Performs the from name operation.</summary>
		///         <returns>The result of the operation.</returns>
		[Export ("functionWithName:")]
		[Static]
		CAMediaTimingFunction FromName (NSString name);

		/// <param name="c1x">The X coordinate of the first control point.</param>
		///         <param name="c1y">The Y coordinate of the first control point.</param>
		///         <param name="c2x">The X coordinate of the second control point.</param>
		///         <param name="c2y">The Y coordinate of the second control point.</param>
		///         <summary>Performs the from control points operation.</summary>
		///         <returns>The result of the operation.</returns>
		[Static]
		[Export ("functionWithControlPoints::::")]
		CAMediaTimingFunction FromControlPoints (float c1x, float c1y, float c2x, float c2y); /* all float, not CGFloat */

		/// <param name="c1x">The X coordinate of the first control point.</param>
		/// <param name="c1y">The Y coordinate of the first control point.</param>
		/// <param name="c2x">The X coordinate of the second control point.</param>
		/// <param name="c2y">The Y coordinate of the second control point.</param>
		/// <summary>Creates a new instance with the specified parameters.</summary>
		[Export ("initWithControlPoints::::")]
		NativeHandle Constructor (float c1x, float c1y, float c2x, float c2y); /* all float, not CGFloat */

		[Export ("getControlPointAtIndex:values:"), Internal]
		void GetControlPointAtIndex (nint idx, IntPtr /* float[2] */ point);

		/// <summary>Represents the value associated with the constant kCAMediaTimingFunctionLinear</summary>
		///         <value>
		///         </value>
		[Field ("kCAMediaTimingFunctionLinear")]
		NSString Linear { get; }

		/// <summary>Represents the value associated with the constant kCAMediaTimingFunctionEaseIn</summary>
		///         <value>
		///         </value>
		[Field ("kCAMediaTimingFunctionEaseIn")]
		NSString EaseIn { get; }

		/// <summary>Represents the value associated with the constant kCAMediaTimingFunctionEaseOut</summary>
		///         <value>
		///         </value>
		[Field ("kCAMediaTimingFunctionEaseOut")]
		NSString EaseOut { get; }

		/// <summary>Represents the value associated with the constant kCAMediaTimingFunctionEaseInEaseOut</summary>
		///         <value>
		///         </value>
		[Field ("kCAMediaTimingFunctionEaseInEaseOut")]
		NSString EaseInEaseOut { get; }

		/// <summary>Represents the value associated with the constant kCAMediaTimingFunctionDefault</summary>
		///         <value>
		///         </value>
		[Field ("kCAMediaTimingFunctionDefault")]
		NSString Default { get; }
	}

	/// <summary>Class used to apply functions to property values during an animation.</summary>
	///     
	///     <related type="externalDocumentation" href="https://developer.apple.com/library/ios/documentation/GraphicsImaging/Reference/CAValueFunction_class/index.html">Apple documentation for <c>CAValueFunction</c></related>
	[BaseType (typeof (NSObject))]
	interface CAValueFunction : NSSecureCoding {
		/// <param name="name">The name.</param>
		///         <summary>Performs the from name operation.</summary>
		///         <returns>The result of the operation.</returns>
		[Export ("functionWithName:"), Static]
		[return: NullAllowed]
		CAValueFunction FromName (string name);

		/// <summary>Gets the Name value.</summary>
		[Export ("name")]
		string Name { get; }

		/// <summary>Represents the value associated with the constant kCAValueFunctionRotateX</summary>
		///         <value>
		///         </value>
		[Field ("kCAValueFunctionRotateX")]
		NSString RotateX { get; }

		/// <summary>Represents the value associated with the constant kCAValueFunctionRotateY</summary>
		///         <value>
		///         </value>
		[Field ("kCAValueFunctionRotateY")]
		NSString RotateY { get; }

		/// <summary>Represents the value associated with the constant kCAValueFunctionRotateZ</summary>
		///         <value>
		///         </value>
		[Field ("kCAValueFunctionRotateZ")]
		NSString RotateZ { get; }

		/// <summary>Represents the value associated with the constant kCAValueFunctionScale</summary>
		///         <value>
		///         </value>
		[Field ("kCAValueFunctionScale")]
		NSString Scale { get; }

		/// <summary>Represents the value associated with the constant kCAValueFunctionScaleX</summary>
		///         <value>
		///         </value>
		[Field ("kCAValueFunctionScaleX")]
		NSString ScaleX { get; }

		/// <summary>Represents the value associated with the constant kCAValueFunctionScaleY</summary>
		///         <value>
		///         </value>
		[Field ("kCAValueFunctionScaleY")]
		NSString ScaleY { get; }

		/// <summary>Represents the value associated with the constant kCAValueFunctionScaleZ</summary>
		///         <value>
		///         </value>
		[Field ("kCAValueFunctionScaleZ")]
		NSString ScaleZ { get; }

		/// <summary>Represents the value associated with the constant kCAValueFunctionTranslate</summary>
		///         <value>
		///         </value>
		[Field ("kCAValueFunctionTranslate")]
		NSString Translate { get; }

		/// <summary>Represents the value associated with the constant kCAValueFunctionTranslateX</summary>
		///         <value>
		///         </value>
		[Field ("kCAValueFunctionTranslateX")]
		NSString TranslateX { get; }

		/// <summary>Represents the value associated with the constant kCAValueFunctionTranslateY</summary>
		///         <value>
		///         </value>
		[Field ("kCAValueFunctionTranslateY")]
		NSString TranslateY { get; }

		/// <summary>Represents the value associated with the constant kCAValueFunctionTranslateZ</summary>
		///         <value>
		///         </value>
		[Field ("kCAValueFunctionTranslateZ")]
		NSString TranslateZ { get; }

	}

	[NoiOS]
	[NoTV]
	[Deprecated (PlatformName.MacOSX, 10, 14, message: "Use 'CAMetalLayer' instead.")]
	[NoMacCatalyst]
	[BaseType (typeof (CALayer))]
	interface CAOpenGLLayer {
		/// <summary>Performs the create operation.</summary>
		///         <returns>The result of the operation.</returns>
		[Export ("layer"), New, Static]
		CALayer Create ();

		/// <summary>Gets or sets the Asynchronous value.</summary>
		[Export ("asynchronous")]
		bool Asynchronous { [Bind ("isAsynchronous")] get; set; }

		/// <param name="glContext">The OpenGL context.</param>
		///         <param name="pixelFormat">The pixel format.</param>
		///         <param name="timeInterval">The time interval.</param>
		///         <param name="timeStamp">The timestamp.</param>
		///         <summary>Performs the can draw in c g l context operation.</summary>
		///         <returns>The result of the operation.</returns>
		[Export ("canDrawInCGLContext:pixelFormat:forLayerTime:displayTime:")]
		bool CanDrawInCGLContext (CGLContext glContext, CGLPixelFormat pixelFormat, double timeInterval, ref CVTimeStamp timeStamp);

		/// <param name="glContext">The OpenGL context.</param>
		///         <param name="pixelFormat">The pixel format.</param>
		///         <param name="timeInterval">The time interval.</param>
		///         <param name="timeStamp">The timestamp.</param>
		///         <summary>Performs the draw in c g l context operation.</summary>
		[Export ("drawInCGLContext:pixelFormat:forLayerTime:displayTime:")]
		void DrawInCGLContext (CGLContext glContext, CGLPixelFormat pixelFormat, double timeInterval, ref CVTimeStamp timeStamp);

		/// <param name="mask">The autoresizing mask.</param>
		///         <summary>Performs the copy c g l pixel format for display mask operation.</summary>
		///         <returns>The result of the operation.</returns>
		[Export ("copyCGLPixelFormatForDisplayMask:")]
		[return: Release]
		CGLPixelFormat CopyCGLPixelFormatForDisplayMask (UInt32 mask);

		/// <param name="pixelFormat">The pixel format.</param>
		///         <summary>Performs the release operation.</summary>
		[Export ("releaseCGLPixelFormat:")]
		void Release (CGLPixelFormat pixelFormat);

		/// <param name="pixelFormat">The pixel format.</param>
		///         <summary>Performs the copy context operation.</summary>
		///         <returns>The result of the operation.</returns>
		[Export ("copyCGLContextForPixelFormat:")]
		[return: Release]
		CGLContext CopyContext (CGLPixelFormat pixelFormat);

		/// <param name="glContext">The OpenGL context.</param>
		///         <summary>Performs the release operation.</summary>
		[Export ("releaseCGLContext:")]
		void Release (CGLContext glContext);
	}

	/// <summary>A source of particles emitted by a <see cref="CoreAnimation.CAEmitterLayer" /> instance.</summary>
	///     
	///     <related type="externalDocumentation" href="https://developer.apple.com/library/ios/documentation/GraphicsImaging/Reference/CAEmitterCell_class/index.html">Apple documentation for <c>CAEmitterCell</c></related>
	[BaseType (typeof (NSObject))]
	interface CAEmitterCell : CAMediaTiming, NSSecureCoding {
		/// <summary>Gets or sets a name for the cell that can be used in animation keypaths.</summary>
		///         <value>
		///           <para>(More documentation for this node is coming)</para>
		///           <para tool="nullallowed">This value can be <see langword="null" />.</para>
		///         </value>
		[NullAllowed] // by default this property is null
		[Export ("name", ArgumentSemantic.Copy)]
		string Name { get; set; }

		/// <summary>Gets or sets a Boolean value that controls whether emitted cells are rendered.</summary>
		[Export ("enabled")]
		bool Enabled { [Bind ("isEnabled")] get; set; }

		/// <summary>Gets or sets the frequency, in Hz, at which particles are emitted.</summary>
		[Export ("birthRate")]
		float BirthRate { get; set; } /* float, not CGFloat */

		/// <summary>Gets or sets the average particle lifetime.</summary>
		[Export ("lifetime")]
		float LifeTime { get; set; } /* float, not CGFloat */

		/// <summary>Gets or sets the average amount of variation in the particle lifetime.</summary>
		[Export ("lifetimeRange")]
		float LifetimeRange { get; set; } /* float, not CGFloat */

		/// <summary>Gets the angle from the Z axis at which particles are emitted.</summary>
		[Export ("emissionLatitude")]
		nfloat EmissionLatitude { get; set; }

		/// <summary>Gets or sets the azimuth angle of the emitted particles.</summary>
		[Export ("emissionLongitude")]
		nfloat EmissionLongitude { get; set; }

		/// <summary>Gets or sets the average amount of variation in the particle emission rate.</summary>
		[Export ("emissionRange")]
		nfloat EmissionRange { get; set; }

		/// <summary>Gets or sets the initial velocity of the emitter cell.</summary>
		[Export ("velocity")]
		nfloat Velocity { get; set; }

		/// <summary>Gets or sets the average value by which the velocity can differ from its nominal value.</summary>
		[Export ("velocityRange")]
		nfloat VelocityRange { get; set; }

		/// <summary>Gets or sets the X component of the cell's acceleration.</summary>
		[Export ("xAcceleration")]
		nfloat AccelerationX { get; set; }

		/// <summary>Gets or sets the Y component of the cell's acceleration.</summary>
		[Export ("yAcceleration")]
		nfloat AccelerationY { get; set; }

		/// <summary>Gets or sets the Z component of the cell's acceleration.</summary>
		[Export ("zAcceleration")]
		nfloat AccelerationZ { get; set; }

		/// <summary>Gets or sets the scale factor to apply to the emitter cell.</summary>
		[Export ("scale")]
		nfloat Scale { get; set; }

		/// <summary>Gets or sets the average value by which the scale factor can differ from its nominal value.</summary>
		[Export ("scaleRange")]
		nfloat ScaleRange { get; set; }

		/// <summary>Gets or sets the speed at which the scale factor changes.</summary>
		[Export ("scaleSpeed")]
		nfloat ScaleSpeed { get; set; }

		/// <summary>Gets or sets the rotational speed in radians per second.</summary>
		[Export ("spin")]
		nfloat Spin { get; set; }

		/// <summary>Gets or sets the average value by which the spin can differ from its nominal value.</summary>
		[Export ("spinRange")]
		nfloat SpinRange { get; set; }

		/// <summary>Gets or sets the color or average color of the emitted objects.</summary>
		[Export ("color")]
		[NullAllowed]
		CGColor Color { get; set; }

		/// <summary>Gets or sets the speed at which the red value changes.</summary>
		[Export ("redSpeed")]
		float RedSpeed { get; set; } /* float, not CGFloat */

		/// <summary>Gets or sets the speed at which the green value changes.</summary>
		[Export ("greenSpeed")]
		float GreenSpeed { get; set; } /* float, not CGFloat */

		/// <summary>Gets or sets the speed at which the blue value changes.</summary>
		[Export ("blueSpeed")]
		float BlueSpeed { get; set; } /* float, not CGFloat */

		/// <summary>Gets or sets the speed at which the alpha value changes.</summary>
		[Export ("alphaSpeed")]
		float AlphaSpeed { get; set; } /* float, not CGFloat */

		/// <summary>Gets or sets a weak reference to the image contents for the layer.</summary>
		///         <value>
		///           <para>(More documentation for this node is coming)</para>
		///           <para tool="nullallowed">This value can be <see langword="null" />.</para>
		///         </value>
		[NullAllowed] // by default this property is null
		[Export ("contents", ArgumentSemantic.Strong)]
		NSObject WeakContents { get; set; }

		/// <summary>Gets or sets the image content of the layer.</summary>
		///         <value>
		///           <para>(More documentation for this node is coming)</para>
		///           <para tool="nullallowed">This value can be <see langword="null" />.</para>
		///         </value>
		[NullAllowed] // just like it's weak property
		[Sealed]
		[Export ("contents", ArgumentSemantic.Strong)]
		CGImage Contents { get; set; }

		/// <summary>Gets or sets the rectangular portion of the image contents to draw.</summary>
		[Export ("contentsRect")]
		CGRect ContentsRect { get; set; }

		/// <summary>TGets or sets the filter to use when shrinking content.</summary>
		[Export ("minificationFilter", ArgumentSemantic.Copy)]
		string MinificationFilter { get; set; }

		/// <summary>Gets or sets the filter to use when enlarging content.</summary>
		[Export ("magnificationFilter", ArgumentSemantic.Copy)]
		string MagnificationFilter { get; set; }

		/// <summary>Gets or sets a numerical value that controls detail presentation for a trilinear minification filter.</summary>
		[Export ("minificationFilterBias")]
		float MinificationFilterBias { get; set; } /* float, not CGFloat */

		/// <summary>Gets or sets an optional array of subcells.</summary>
		///         <value>
		///           <para>(More documentation for this node is coming)</para>
		///           <para tool="nullallowed">This value can be <see langword="null" />.</para>
		///         </value>
		[NullAllowed] // by default this property is null
		[Export ("emitterCells", ArgumentSemantic.Copy)]
		CAEmitterCell [] Cells { get; set; }

		/// <summary>Gets or sets an optional dictionary of style values.</summary>
		///         <value>
		///           <para>(More documentation for this node is coming)</para>
		///           <para tool="nullallowed">This value can be <see langword="null" />.</para>
		///         </value>
		[NullAllowed] // by default this property is null
		[Export ("style", ArgumentSemantic.Copy)]
		NSDictionary Style { get; set; }

		/// <summary>Creates and returns a new <see cref="CoreAnimation.CAEmitterCell" />.</summary>
		///         <returns>The result of the operation.</returns>
		[Static]
		[Export ("emitterCell")]
		CAEmitterCell EmitterCell ();

		/// <param name="key">
		///           <para>A task representing the asynchronous operation.</para>
		///           <para tool="nullallowed">This parameter can be <see langword="null" />.</para>
		///         </param>
		///         <summary>Returns the default value for the property that is indexed by the specified <paramref name="key" />.</summary>
		///         <returns>The result of the operation.</returns>
		[Static]
		[Export ("defaultValueForKey:")]
		[return: NullAllowed]
		NSObject DefaultValueForKey (string key);

		/// <param name="key">
		///           <para>A task representing the asynchronous operation.</para>
		///           <para tool="nullallowed">This parameter can be <see langword="null" />.</para>
		///         </param>
		///         <summary>Returns a Boolean value that tells if the value for <paramref name="key" /> should be archived.</summary>
		///         <returns>The result of the operation.</returns>
		[Export ("shouldArchiveValueForKey:")]
		bool ShouldArchiveValueForKey (string key);

		/// <summary>Gets or sets the average deviation of the blue color component.</summary>
		[Export ("redRange")]
		float RedRange { get; set; } /* float, not CGFloat */

		/// <summary>Gets or sets the average deviation of the green color component.</summary>
		[Export ("greenRange")]
		float GreenRange { get; set; } /* float, not CGFloat */

		/// <summary>Gets or sets the average deviation of the blue color component.</summary>
		[Export ("blueRange")]
		float BlueRange { get; set; } /* float, not CGFloat */

		/// <summary>Gets or sets the average amount of the alpha variation.</summary>
		[Export ("alphaRange")]
		float AlphaRange { get; set; } /* float, not CGFloat */

		/// <summary>Gets or sets the scale at which to draw the image contents.</summary>
		[MacCatalyst (13, 1)]
		[Export ("contentsScale")]
		nfloat ContentsScale { get; set; }
	}

	/// <summary>A particle-system emitter. Particle types are defined by <see cref="CoreAnimation.CAEmitterCell" />.</summary>
	///     
	///     <related type="externalDocumentation" href="https://developer.apple.com/library/ios/documentation/GraphicsImaging/Reference/CAEmitterLayer_class/index.html">Apple documentation for <c>CAEmitterLayer</c></related>
	[BaseType (typeof (CALayer))]
	interface CAEmitterLayer {
		/// <summary>Performs the create operation.</summary>
		///         <returns>The result of the operation.</returns>
		[Export ("layer"), New, Static]
		CALayer Create ();

		/// <summary>Gets or sets the Cells value.</summary>
		///         <value>
		///           <para>(More documentation for this node is coming)</para>
		///           <para tool="nullallowed">This value can be <see langword="null" />.</para>
		///         </value>
		[NullAllowed] // by default this property is null
		[Export ("emitterCells", ArgumentSemantic.Copy)]
		CAEmitterCell [] Cells { get; set; }

		/// <summary>Gets or sets the BirthRate value.</summary>
		[Export ("birthRate")]
		float BirthRate { get; set; } /* float, not CGFloat */

		/// <summary>Gets or sets the LifeTime value.</summary>
		[Export ("lifetime")]
		float LifeTime { get; set; } /* float, not CGFloat */

		/// <summary>Gets or sets the Position value.</summary>
		[Export ("emitterPosition")]
		CGPoint Position { get; set; }

		/// <summary>Gets or sets the ZPosition value.</summary>
		[Export ("emitterZPosition")]
		nfloat ZPosition { get; set; }

		/// <summary>Gets or sets the Size value.</summary>
		[Export ("emitterSize")]
		CGSize Size { get; set; }

		/// <summary>Gets or sets the Depth value.</summary>
		[Export ("emitterDepth")]
		nfloat Depth { get; set; }

		/// <summary>Gets or sets the Shape value.</summary>
		[Export ("emitterShape", ArgumentSemantic.Copy)]
		string Shape { get; set; }

		/// <summary>Gets or sets the Mode value.</summary>
		[Export ("emitterMode", ArgumentSemantic.Copy)]
		string Mode { get; set; }

		/// <summary>Gets or sets the RenderMode value.</summary>
		[Export ("renderMode", ArgumentSemantic.Copy)]
		string RenderMode { get; set; }

		/// <summary>Gets or sets the PreservesDepth value.</summary>
		[Export ("preservesDepth")]
		bool PreservesDepth { get; set; }

		/// <summary>Gets or sets the Velocity value.</summary>
		[Export ("velocity")]
		float Velocity { get; set; } /* float, not CGFloat */

		/// <summary>Gets or sets the Scale value.</summary>
		[Export ("scale")]
		float Scale { get; set; } /* float, not CGFloat */

		/// <summary>Gets or sets the Spin value.</summary>
		[Export ("spin")]
		float Spin { get; set; } /* float, not CGFloat */

		/// <summary>Gets or sets the Seed value.</summary>
		[Export ("seed")]
		int Seed { get; set; } // unsigned int

		/* `emitterShape' values. */
		/// <summary>Represents the value associated with the constant kCAEmitterLayerPoint</summary>
		///         <value>
		///         </value>
		[Field ("kCAEmitterLayerPoint")]
		NSString ShapePoint { get; }

		/// <summary>Represents the value associated with the constant kCAEmitterLayerLine</summary>
		///         <value>
		///         </value>
		[Field ("kCAEmitterLayerLine")]
		NSString ShapeLine { get; }

		/// <summary>Represents the value associated with the constant kCAEmitterLayerRectangle</summary>
		///         <value>
		///         </value>
		[Field ("kCAEmitterLayerRectangle")]
		NSString ShapeRectangle { get; }

		/// <summary>Represents the value associated with the constant kCAEmitterLayerCuboid</summary>
		///         <value>
		///         </value>
		[Field ("kCAEmitterLayerCuboid")]
		NSString ShapeCuboid { get; }

		/// <summary>Represents the value associated with the constant kCAEmitterLayerCircle</summary>
		///         <value>
		///         </value>
		[Field ("kCAEmitterLayerCircle")]
		NSString ShapeCircle { get; }

		/// <summary>Represents the value associated with the constant kCAEmitterLayerSphere</summary>
		///         <value>
		///         </value>
		[Field ("kCAEmitterLayerSphere")]
		NSString ShapeSphere { get; }

		/* `emitterMode' values. */
		/// <summary>Represents the value associated with the constant kCAEmitterLayerPoints</summary>
		///         <value>
		///         </value>
		[Field ("kCAEmitterLayerPoints")]
		NSString ModePoints { get; }

		/// <summary>Represents the value associated with the constant kCAEmitterLayerOutline</summary>
		///         <value>
		///         </value>
		[Field ("kCAEmitterLayerOutline")]
		NSString ModeOutline { get; }

		/// <summary>Represents the value associated with the constant kCAEmitterLayerSurface</summary>
		///         <value>
		///         </value>
		[Field ("kCAEmitterLayerSurface")]
		NSString ModeSurface { get; }

		/// <summary>Represents the value associated with the constant kCAEmitterLayerVolume</summary>
		///         <value>
		///         </value>
		[Field ("kCAEmitterLayerVolume")]
		NSString ModeVolume { get; }

		/*  `renderOrder' values. */
		/// <summary>Represents the value associated with the constant kCAEmitterLayerUnordered</summary>
		///         <value>
		///         </value>
		[Field ("kCAEmitterLayerUnordered")]
		NSString RenderUnordered { get; }

		/// <summary>Represents the value associated with the constant kCAEmitterLayerOldestFirst</summary>
		///         <value>
		///         </value>
		[Field ("kCAEmitterLayerOldestFirst")]
		NSString RenderOldestFirst { get; }

		/// <summary>Represents the value associated with the constant kCAEmitterLayerOldestLast</summary>
		///         <value>
		///         </value>
		[Field ("kCAEmitterLayerOldestLast")]
		NSString RenderOldestLast { get; }

		/// <summary>Represents the value associated with the constant kCAEmitterLayerBackToFront</summary>
		///         <value>
		///         </value>
		[Field ("kCAEmitterLayerBackToFront")]
		NSString RenderBackToFront { get; }

		/// <summary>Represents the value associated with the constant kCAEmitterLayerAdditive</summary>
		///         <value>
		///         </value>
		[Field ("kCAEmitterLayerAdditive")]
		NSString RenderAdditive { get; }
	}

	[Internal]
	[Static]
	partial interface CARendererOptionKeys {
		[Field ("kCARendererColorSpace")]
		NSString ColorSpace { get; }

		[Field ("kCARendererMetalCommandQueue")]
		NSString MetalCommandQueue { get; }
	}

	[StrongDictionary ("CARendererOptionKeys")]
	interface CARendererOptions {

		/// <summary>Gets or sets the ColorSpace value.</summary>
		[Export ("ColorSpace")]
		CGColorSpace ColorSpace { get; set; }

		/// <summary>Gets or sets the MetalCommandQueue value.</summary>
		[NoMacCatalyst]
		[Export ("MetalCommandQueue")]
		IMTLCommandQueue MetalCommandQueue { get; set; }
	}

	[BaseType (typeof (NSObject))]
	interface CARenderer {
		/// <param name="tex">The texture.</param>
		///         <param name="dict">The options dictionary.</param>
		///         <summary>Performs the create operation.</summary>
		///         <returns>The result of the operation.</returns>
		[Static]
		[Export ("rendererWithMTLTexture:options:")]
		CARenderer Create (IMTLTexture tex, [NullAllowed] NSDictionary dict);

		/// <param name="tex">The texture.</param>
		///         <param name="options">The options dictionary.</param>
		///         <summary>Performs the create operation.</summary>
		///         <returns>The result of the operation.</returns>
		[Static]
		[Wrap ("Create (tex, options.GetDictionary ())")]
		CARenderer Create (IMTLTexture tex, [NullAllowed] CARendererOptions options);

		/// <summary>Gets or sets the Layer value.</summary>
		[NullAllowed, Export ("layer", ArgumentSemantic.Strong)]
		CALayer Layer { get; set; }

		/// <summary>Gets or sets the Bounds value.</summary>
		[Export ("bounds", ArgumentSemantic.Assign)]
		CGRect Bounds { get; set; }

		/// <param name="timeInSeconds">The time in seconds.</param>
		///         <param name="ts">The timebase.</param>
		///         <summary>Performs the begin frame operation.</summary>
		[Export ("beginFrameAtTime:timeStamp:")]
		void BeginFrame (double timeInSeconds, ref CVTimeStamp ts);

		[Sealed]
		[Internal] // since the timestamp is nullable
		[Export ("beginFrameAtTime:timeStamp:")]
		void BeginFrame (double timeInSeconds, IntPtr ts);

		/// <param name="timeInSeconds">The time in seconds.</param>
		///         <summary>Performs the begin frame operation.</summary>
		[Wrap ("BeginFrame (timeInSeconds, IntPtr.Zero)")]
		void BeginFrame (double timeInSeconds);

		/// <summary>Performs the update bounds operation.</summary>
		///         <returns>The result of the operation.</returns>
		[Export ("updateBounds")]
		CGRect UpdateBounds ();

		/// <param name="r">The rectangle.</param>
		///         <summary>Performs the add update operation.</summary>
		[Export ("addUpdateRect:")]
		void AddUpdate (CGRect r);

		/// <summary>Performs the render operation.</summary>
		[Export ("render")]
		void Render ();

		/// <summary>Gets the time for the next frame.</summary>
		///         <returns>The result of the operation.</returns>
		[Export ("nextFrameTime")]
		double /* CFTimeInterval */ GetNextFrameTime ();

		/// <summary>Performs the end frame operation.</summary>
		[Export ("endFrame")]
		void EndFrame ();

		/// <param name="tex">The texture.</param>
		///         <summary>Performs the set destination operation.</summary>
		[Export ("setDestination:")]
		void SetDestination (IMTLTexture tex);
	}

	[iOS (16, 0)]
	[NoTV]
	[MacCatalyst (16, 0)]
	[BaseType (typeof (NSObject), Name = "CAEDRMetadata")]
	[DisableDefaultCtor]
	interface CAEdrMetadata : NSCopying, NSSecureCoding {

		[Static]
		[Export ("HDR10MetadataWithDisplayInfo:contentInfo:opticalOutputScale:")]
		CAEdrMetadata GetHdr10Metadata ([NullAllowed] NSData displayData, [NullAllowed] NSData contentData, float scale);

		[Static]
		[Export ("HDR10MetadataWithMinLuminance:maxLuminance:opticalOutputScale:")]
		CAEdrMetadata GetHdr10Metadata (float minNits, float maxNits, float scale);

		[Static]
		[Export ("HLGMetadata", ArgumentSemantic.Retain)]
		CAEdrMetadata HlgMetadata { get; }

		[Mac (13, 0)]
		[MacCatalyst (13, 1)]
		[Static]
		[Export ("available")]
		bool Available { [Bind ("isAvailable")] get; }

		[Static]
		[Mac (14, 0), iOS (17, 0), MacCatalyst (17, 0)]
		[Export ("HLGMetadataWithAmbientViewingEnvironment:")]
		CAEdrMetadata GetHlgMetadata (NSData ambientViewingEnvironmentData);
	}

	[BaseType (typeof (NSObject))]
	[iOS (17, 0), TV (17, 0), Mac (14, 0), MacCatalyst (17, 0)]
	[DisableDefaultCtor]
	interface CAMetalDisplayLinkUpdate {
		[Export ("drawable")]
		ICAMetalDrawable Drawable { get; }

		[Export ("targetTimestamp")]
		double /* CFTimeInterval */ TargetTimestamp { get; }

		[Export ("targetPresentationTimestamp")]
		double /* CFTimeInterval */ TargetPresentationTimestamp { get; }
	}

	[Protocol (BackwardsCompatibleCodeGeneration = false), Model]
	[BaseType (typeof (NSObject))]
	[iOS (17, 0), TV (17, 0), Mac (14, 0), MacCatalyst (17, 0)]
	interface CAMetalDisplayLinkDelegate {
		[Abstract]
		[Export ("metalDisplayLink:needsUpdate:")]
		void NeedsUpdate (CAMetalDisplayLink link, CAMetalDisplayLinkUpdate update);
	}

	interface ICAMetalDisplayLinkDelegate { }

	[BaseType (typeof (NSObject))]
	[iOS (17, 0), TV (17, 0), Mac (14, 0), MacCatalyst (17, 0)]
	[DisableDefaultCtor]
	interface CAMetalDisplayLink {
		[Export ("initWithMetalLayer:")]
		NativeHandle Constructor (CAMetalLayer layer);

		[Export ("addToRunLoop:forMode:")]
		void AddToRunLoop (NSRunLoop runloop, NSRunLoopMode mode);

		[Export ("removeFromRunLoop:forMode:")]
		void RemoveFromRunLoop (NSRunLoop runloop, NSRunLoopMode mode);

		[Export ("invalidate")]
		void Invalidate ();

		[Export ("delegate", ArgumentSemantic.Weak), NullAllowed]
		NSObject WeakDelegate { get; set; }

		[Wrap ("WeakDelegate"), NullAllowed]
		ICAMetalDisplayLinkDelegate Delegate { get; set; }

		[Export ("preferredFrameLatency")]
		float PreferredFrameLatency { get; set; }

		[Export ("preferredFrameRateRange")]
		CAFrameRateRange PreferredFrameRateRange { get; set; }

		[Export ("paused")]
		bool Paused { [Bind ("isPaused")] get; set; }
	}

	[TV (26, 0), MacCatalyst (26, 0), Mac (26, 0), iOS (26, 0)]
	enum CADynamicRange {
		[Field ("CADynamicRangeAutomatic")]
		Automatic,

		[Field ("CADynamicRangeStandard")]
		Standard,

		[Field ("CADynamicRangeConstrainedHigh")]
		ConstrainedHigh,

		[Field ("CADynamicRangeHigh")]
		High,
	}

	[NoiOS, NoTV]
	[MacCatalyst (13, 1)]
	[Protocol (BackwardsCompatibleCodeGeneration = false)]
	interface CALayoutManager {
		[Export ("preferredSizeOfLayer:")]
		CGSize GetPreferredSize (CALayer layer);

		[Export ("invalidateLayoutOfLayer:")]
		void InvalidateLayout (CALayer layer);

		[Export ("layoutSublayersOfLayer:")]
		void LayoutSublayers (CALayer layer);
	}

	[NoTV, NoiOS, MacCatalyst (13, 1)]
	[BaseType (typeof (NSObject))]
	[DisableDefaultCtor]
	interface CARemoteLayerClient {
		[Export ("initWithServerPort:")]
		NativeHandle Constructor (uint port);

		[Export ("invalidate")]
		void Invalidate ();

		[Export ("clientId")]
		uint ClientId { get; }

		[NullAllowed, Export ("layer", ArgumentSemantic.Strong)]
		CALayer Layer { get; set; }
	}

	[NoTV, NoiOS, MacCatalyst (13, 1)]
	[BaseType (typeof (NSObject))]
	[DisableDefaultCtor]
	interface CARemoteLayerServer {
		[Static]
		[Export ("sharedServer")]
		CARemoteLayerServer SharedServer { get; }

		[Export ("serverPort")]
		uint ServerPort { get; }
	}
}
