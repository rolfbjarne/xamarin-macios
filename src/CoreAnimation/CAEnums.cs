//
// CAEnums.cs: definitions used for CoreAnimation
// 
// Authors:
//   Geoff Norton
//   Miguel de Icaza
//
// Copyright 2009-2010, Novell, Inc.
// Copyright 2014 Xamarin Inc.
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
using CoreGraphics;

#nullable enable

namespace CoreAnimation {

	// untyped enum -> CALayer.h
	// note: edgeAntialiasingMask is an `unsigned int` @property
	/// <summary>Flags used to determine what side of a layer should be antialiased.</summary>
	[Flags]
	public enum CAEdgeAntialiasingMask : uint {
		/// <summary>Left side of the layer is antialiased.</summary>
		LeftEdge = 1 << 0,
		/// <summary>Right side of the layer is antialiased.</summary>
		RightEdge = 1 << 1,
		/// <summary>Bottom side of the layer is antialiased.</summary>
		BottomEdge = 1 << 2,
		/// <summary>Top side of the layer is antialiased.</summary>
		TopEdge = 1 << 3,
		/// <summary>All sides of the layer are antialiased.</summary>
		All = LeftEdge | RightEdge | BottomEdge | TopEdge,
		/// <summary>Left and right sides of the layer are antialiased.</summary>
		LeftRightEdges = LeftEdge | RightEdge,
		/// <summary>Top and bottom side of the layer are antialiased.</summary>
		TopBottomEdges = TopEdge | BottomEdge,
	}

	[MacCatalyst (13, 1)]
	[Native]
	[Flags]
	public enum CACornerMask : ulong {
		/// <summary>Indicates min x min y corner.</summary>
		MinXMinYCorner = 1 << 0,
		/// <summary>Indicates max x min y corner.</summary>
		MaxXMinYCorner = 1 << 1,
		/// <summary>Indicates min x max y corner.</summary>
		MinXMaxYCorner = 1 << 2,
		/// <summary>Indicates max x max y corner.</summary>
		MaxXMaxYCorner = 1 << 3,
	}

	// untyped enum -> CALayer.h (only on OSX headers)
	// note: autoresizingMask is an `unsigned int` @property
	[Flags]
	[NoiOS]
	[NoTV]
	[MacCatalyst (13, 1)]
	public enum CAAutoresizingMask : uint {
		/// <summary>Indicates not sizable.</summary>
		NotSizable = 0,
		/// <summary>Indicates min x margin.</summary>
		MinXMargin = 1 << 0,
		/// <summary>Indicates width sizable.</summary>
		WidthSizable = 1 << 1,
		/// <summary>Indicates max x margin.</summary>
		MaxXMargin = 1 << 2,
		/// <summary>Indicates min y margin.</summary>
		MinYMargin = 1 << 3,
		/// <summary>Indicates height sizable.</summary>
		HeightSizable = 1 << 4,
		/// <summary>Indicates max y margin.</summary>
		MaxYMargin = 1 << 5,
	}

	// typedef int -> CAConstraintLayoutManager.h
	[NoiOS]
	[NoTV]
	[MacCatalyst (13, 1)]
	public enum CAConstraintAttribute {
		/// <summary>Indicates min x.</summary>
		MinX,
		/// <summary>Indicates mid x.</summary>
		MidX,
		/// <summary>Indicates max x.</summary>
		MaxX,
		/// <summary>Indicates width.</summary>
		Width,
		/// <summary>Indicates min y.</summary>
		MinY,
		/// <summary>Indicates mid y.</summary>
		MidY,
		/// <summary>Indicates max y.</summary>
		MaxY,
		/// <summary>Indicates height.</summary>
		Height,
	};
}
