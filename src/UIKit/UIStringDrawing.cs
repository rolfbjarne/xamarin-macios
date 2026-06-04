#if IOS

using UIKit;
using CoreGraphics;

namespace UIKit {
	public unsafe static partial class UIStringDrawing {
		/// <summary>Developers should use <see cref="NSStringDrawing.DrawString(NSString,CoreGraphics.CGPoint,UIKit.UIStringAttributes)" /> rather than this deprecated method.</summary>
		/// <param name="This">The this.</param>
		/// <param name="point">The point.</param>
		/// <param name="font">The font.</param>
		/// <remarks>To be added.</remarks>
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("maccatalyst")]
		[ObsoletedOSPlatform ("ios", "Use NSString.DrawString(CGPoint, UIStringAttributes) instead.")]
		[ObsoletedOSPlatform ("maccatalyst", "Use NSString.DrawString(CGPoint, UIStringAttributes) instead.")]
		[UnsupportedOSPlatform ("tvos")]
		public static CGSize DrawString (this string This, CGPoint point, UIFont font)
		{
			using (var self = ((NSString) This))
				return self.DrawString (point, font);
		}

		/// <param name="This">The this.</param>
		/// <param name="point">The point.</param>
		/// <param name="width">The width.</param>
		/// <param name="font">The font.</param>
		/// <param name="breakMode">The break mode.</param>
		/// <summary>Developers should use <see cref="NSStringDrawing.DrawString(NSString, CoreGraphics.CGRect, UIKit.UIStringAttributes)" /> rather than this deprecated method.</summary>
		/// <remarks>To be added.</remarks>
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("maccatalyst")]
		[ObsoletedOSPlatform ("ios", "Use NSString.DrawString(CGRect, UIStringAttributes) instead.")]
		[ObsoletedOSPlatform ("maccatalyst", "Use NSString.DrawString(CGRect, UIStringAttributes) instead.")]
		[UnsupportedOSPlatform ("tvos")]
		public static CGSize DrawString (this string This, CGPoint point, nfloat width, UIFont font, UILineBreakMode breakMode)
		{
			using (var self = ((NSString) This))
				return self.DrawString (point, width, font, breakMode);
		}

		/// <param name="This">The this.</param>
		/// <param name="point">The point.</param>
		/// <param name="width">The width.</param>
		/// <param name="font">The font.</param>
		/// <param name="fontSize">The font size.</param>
		/// <param name="breakMode">The break mode.</param>
		/// <param name="adjustment">The adjustment.</param>
		/// <summary>Developers should use <see cref="NSStringDrawing.DrawString(NSString, CoreGraphics.CGRect, UIKit.UIStringAttributes)" /> rather than this deprecated method..</summary>
		/// <remarks>To be added.</remarks>
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("maccatalyst")]
		[ObsoletedOSPlatform ("ios", "Use NSString.DrawString(CGRect, UIStringAttributes) instead.")]
		[ObsoletedOSPlatform ("maccatalyst", "Use NSString.DrawString(CGRect, UIStringAttributes) instead.")]
		[UnsupportedOSPlatform ("tvos")]
		public static CGSize DrawString (this string This, CGPoint point, nfloat width, UIFont font, nfloat fontSize, UILineBreakMode breakMode, UIBaselineAdjustment adjustment)
		{
			using (var self = ((NSString) This))
				return self.DrawString (point, width, font, fontSize, breakMode, adjustment);
		}

		/// <param name="This">The this.</param>
		/// <param name="point">The point.</param>
		/// <param name="width">The width.</param>
		/// <param name="font">The font.</param>
		/// <param name="minFontSize">The min font size.</param>
		/// <param name="actualFontSize">The actual font size.</param>
		/// <param name="breakMode">The break mode.</param>
		/// <param name="adjustment">The adjustment.</param>
		/// <summary>Developers should use <see cref="NSStringDrawing.DrawString(NSString, CoreGraphics.CGRect, UIKit.UIStringAttributes)" /> rather than this deprecated method.</summary>
		/// <remarks>To be added.</remarks>
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("maccatalyst")]
		[ObsoletedOSPlatform ("ios", "Use NSString.DrawString(CGRect, UIStringAttributes) instead.")]
		[ObsoletedOSPlatform ("maccatalyst", "Use NSString.DrawString(CGRect, UIStringAttributes) instead.")]
		[UnsupportedOSPlatform ("tvos")]
		public static CGSize DrawString (this string This, CGPoint point, nfloat width, UIFont font, nfloat minFontSize, ref nfloat actualFontSize, UILineBreakMode breakMode, UIBaselineAdjustment adjustment)
		{
			using (var self = ((NSString) This))
				return self.DrawString (point, width, font, minFontSize, ref actualFontSize, breakMode, adjustment);
		}

		/// <param name="This">The this.</param>
		///         <param name="rect">The rect.</param>
		///         <param name="font">The font.</param>
		///         <summary>Developers should use <see cref="NSStringDrawing.DrawString(NSString, CoreGraphics.CGRect, UIKit.UIStringAttributes)" /> rather than this deprecated method.</summary>
		///         <remarks>To be added.</remarks>
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("maccatalyst")]
		[ObsoletedOSPlatform ("ios", "Use NSString.DrawString(CGRect, UIStringAttributes) instead.")]
		[ObsoletedOSPlatform ("maccatalyst", "Use NSString.DrawString(CGRect, UIStringAttributes) instead.")]
		[UnsupportedOSPlatform ("tvos")]
		public static CGSize DrawString (this string This, CGRect rect, UIFont font)
		{
			using (var self = ((NSString) This))
				return self.DrawString (rect, font);
		}

		/// <param name="This">The this.</param>
		///         <param name="rect">The rect.</param>
		///         <param name="font">The font.</param>
		///         <param name="mode">The mode.</param>
		///         <summary>Developers should use <see cref="NSStringDrawing.DrawString(NSString, CoreGraphics.CGRect, UIKit.UIStringAttributes)" /> rather than this deprecated method.</summary>
		///         <remarks>To be added.</remarks>
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("maccatalyst")]
		[ObsoletedOSPlatform ("ios", "Use NSString.DrawString(CGRect, UIStringAttributes) instead.")]
		[ObsoletedOSPlatform ("maccatalyst", "Use NSString.DrawString(CGRect, UIStringAttributes) instead.")]
		[UnsupportedOSPlatform ("tvos")]
		public static CGSize DrawString (this string This, CGRect rect, UIFont font, UILineBreakMode mode)
		{
			using (var self = ((NSString) This))
				return self.DrawString (rect, font, mode);
		}

		/// <param name="This">The this.</param>
		///         <param name="rect">The rect.</param>
		///         <param name="font">The font.</param>
		///         <param name="mode">The mode.</param>
		///         <param name="alignment">The alignment.</param>
		///         <summary>Developers should use <see cref="NSStringDrawing.DrawString(NSString, CoreGraphics.CGRect, UIKit.UIStringAttributes)" /> rather than this deprecated method.</summary>
		///         <remarks>To be added.</remarks>
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("maccatalyst")]
		[ObsoletedOSPlatform ("ios", "Use NSString.DrawString(CGRect, UIStringAttributes) instead.")]
		[ObsoletedOSPlatform ("maccatalyst", "Use NSString.DrawString(CGRect, UIStringAttributes) instead.")]
		[UnsupportedOSPlatform ("tvos")]
		public static CGSize DrawString (this string This, CGRect rect, UIFont font, UILineBreakMode mode, UITextAlignment alignment)
		{
			using (var self = ((NSString) This))
				return self.DrawString (rect, font, mode, alignment);
		}

		/// <param name="This">The instance on which this method operates.</param>
		///         <param name="font">The font.</param>
		///         <summary>Developers should use <see cref="NSStringDrawing.GetSizeUsingAttributes(Foundation.NSString,UIKit.UIStringAttributes)" /> rather than this deprecated method.</summary>
		///         <remarks>To be added.</remarks>
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("maccatalyst")]
		[ObsoletedOSPlatform ("ios", "Use NSString.GetSizeUsingAttributes(UIStringAttributes) instead.")]
		[ObsoletedOSPlatform ("maccatalyst", "Use NSString.GetSizeUsingAttributes(UIStringAttributes) instead.")]
		[UnsupportedOSPlatform ("tvos")]
		public static CGSize StringSize (this string This, UIFont font)
		{
			using (var self = ((NSString) This))
				return self.StringSize (font);
		}

		/// <param name="This">The this.</param>
		/// <param name="font">The font.</param>
		/// <param name="forWidth">The for width.</param>
		/// <param name="breakMode">The break mode.</param>
		/// <summary>Gets the <see cref="CoreGraphics.CGSize" /> necessary to display this <see cref="Foundation.NSString" />.</summary>
		/// <remarks>To be added.</remarks>
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("maccatalyst")]
		[ObsoletedOSPlatform ("ios", "Use NSString.GetBoundingRect (CGSize, NSStringDrawingOptions, UIStringAttributes, NSStringDrawingContext) instead.")]
		[ObsoletedOSPlatform ("maccatalyst", "Use NSString.GetBoundingRect (CGSize, NSStringDrawingOptions, UIStringAttributes, NSStringDrawingContext) instead.")]
		[UnsupportedOSPlatform ("tvos")]
		public static CGSize StringSize (this string This, UIFont font, nfloat forWidth, UILineBreakMode breakMode)
		{
			using (var self = ((NSString) This))
				return self.StringSize (font, forWidth, breakMode);
		}

		/// <param name="This">The instance on which this method operates.</param>
		///         <param name="font">The font.</param>
		///         <param name="constrainedToSize">The constrained to size.</param>
		///         <summary>The calculated size of the string if rendered with the <paramref name="font" /> or <paramref name="constrainedToSize" />, whichever is smaller.</summary>
		///         <remarks>To be added.</remarks>
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("maccatalyst")]
		[ObsoletedOSPlatform ("ios", "Use NSString.GetBoundingRect (CGSize, NSStringDrawingOptions, UIStringAttributes, NSStringDrawingContext) instead.")]
		[ObsoletedOSPlatform ("maccatalyst", "Use NSString.GetBoundingRect (CGSize, NSStringDrawingOptions, UIStringAttributes, NSStringDrawingContext) instead.")]
		[UnsupportedOSPlatform ("tvos")]
		public static CGSize StringSize (this string This, UIFont font, CGSize constrainedToSize)
		{
			using (var self = ((NSString) This))
				return self.StringSize (font, constrainedToSize);
		}

		/// <param name="This">The this.</param>
		///         <param name="font">The font.</param>
		///         <param name="constrainedToSize">The constrained to size.</param>
		///         <param name="lineBreakMode">The line break mode.</param>
		///         <summary>Gets the <see cref="CoreGraphics.CGSize" /> necessary to display this <see cref="Foundation.NSString" />.</summary>
		///         <remarks>To be added.</remarks>
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("maccatalyst")]
		[ObsoletedOSPlatform ("ios", "Use NSString.GetBoundingRect (CGSize, NSStringDrawingOptions, UIStringAttributes, NSStringDrawingContext) instead.")]
		[ObsoletedOSPlatform ("maccatalyst", "Use NSString.GetBoundingRect (CGSize, NSStringDrawingOptions, UIStringAttributes, NSStringDrawingContext) instead.")]
		[UnsupportedOSPlatform ("tvos")]
		public static CGSize StringSize (this string This, UIFont font, CGSize constrainedToSize, UILineBreakMode lineBreakMode)
		{
			using (var self = ((NSString) This))
				return self.StringSize (font, constrainedToSize, lineBreakMode);
		}

		/// <param name="This">The this.</param>
		/// <param name="font">The font.</param>
		/// <param name="minFontSize">The min font size.</param>
		/// <param name="actualFontSize">The actual font size.</param>
		/// <param name="forWidth">The for width.</param>
		/// <param name="lineBreakMode">The line break mode.</param>
		/// <summary>Gets the <see cref="CoreGraphics.CGSize" /> necessary to display this <see cref="Foundation.NSString" />.</summary>
		/// <remarks>To be added.</remarks>
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("maccatalyst")]
		[ObsoletedOSPlatform ("ios")]
		[ObsoletedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("tvos")]
		public static CGSize StringSize (this string This, UIFont font, nfloat minFontSize, ref nfloat actualFontSize, nfloat forWidth, UILineBreakMode lineBreakMode)
		{
			using (var self = ((NSString) This))
				return self.StringSize (font, minFontSize, ref actualFontSize, forWidth, lineBreakMode);
		}
	}
}

#endif // IOS
