//
// SKAction helpers
//
// Authors:
//   Sebastien Pouliot  <sebastien@xamarin.com>
//
// Copyright 2013 Xamarin Inc.
//

using CoreGraphics;
using CoreFoundation;

#nullable enable

namespace SpriteKit {
	public partial class SKAction {

		/// <param name="size">The size.</param>
		/// <param name="duration">The duration.</param>
		/// <summary>Creates an action that resizes a node to the specified size over the given duration.</summary>
		/// <returns>A new resize action.</returns>
		public static SKAction ResizeTo (CGSize size, double duration)
		{
			return SKAction.ResizeTo (size.Width, size.Height, duration);
		}
	}
}
