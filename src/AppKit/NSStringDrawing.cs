#if !__MACCATALYST__
using AppKit;
using CoreGraphics;

#nullable enable

namespace AppKit {
	/// <summary>Provides extension methods for drawing strings with AppKit.</summary>
	[SupportedOSPlatform ("macos")]
	[UnsupportedOSPlatform ("ios")]
	[UnsupportedOSPlatform ("tvos")]
	[UnsupportedOSPlatform ("maccatalyst")]
	// Manual bindings, easier than make the generator support extension methods on non-NSObject-derived types (string in this case).
	public unsafe static partial class NSStringDrawing {
		/// <param name="This">The this.</param>
		///         <param name="point">The point.</param>
		///         <param name="attributes">The attributes.</param>
		///         <summary>Draws at point.</summary>
		public static void DrawAtPoint (this string This, CGPoint point, NSDictionary? attributes)
		{
			using (var self = ((NSString) This))
				self.DrawAtPoint (point, attributes);
		}

		/// <param name="This">The this.</param>
		///         <param name="point">The point.</param>
		///         <param name="attributes">The attributes.</param>
		///         <summary>Draws at point.</summary>
		public static void DrawAtPoint (this string This, CGPoint point, NSStringAttributes? attributes)
		{
			This.DrawAtPoint (point, attributes is null ? null : attributes.Dictionary);
		}

		/// <param name="This">The this.</param>
		///         <param name="rect">The rect.</param>
		///         <param name="attributes">The attributes.</param>
		///         <summary>Draws in rect.</summary>
		public static void DrawInRect (this string This, CGRect rect, NSDictionary? attributes)
		{
			using (var self = ((NSString) This))
				self.DrawInRect (rect, attributes);
		}

		/// <param name="This">The this.</param>
		///         <param name="rect">The rect.</param>
		///         <param name="attributes">The attributes.</param>
		///         <summary>Draws in rect.</summary>
		public static void DrawInRect (this string This, CGRect rect, NSStringAttributes? attributes)
		{
			This.DrawInRect (rect, attributes is null ? null : attributes.Dictionary);
		}

		/// <param name="This">The this.</param>
		///         <param name="attributes">The attributes.</param>
		///         <summary>Strings size.</summary>
		public static CGSize StringSize (this string This, NSDictionary? attributes)
		{
			using (var self = ((NSString) This))
				return self.StringSize (attributes);
		}

		/// <param name="This">The this.</param>
		///         <param name="attributes">The attributes.</param>
		///         <summary>Strings size.</summary>
		public static CGSize StringSize (this string This, NSStringAttributes? attributes)
		{
			return This.StringSize (attributes is null ? null : attributes.Dictionary);
		}
	}
}
#endif // !__MACCATALYST__
