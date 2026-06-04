//
// Copyright 2011, Novell, Inc.
// Copyright 2011, Regan Sarwas
//
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

//
// Enums.cs: Enums for ImageKit
//

#nullable enable

namespace ImageKit {

	/// <summary>Specifies the display mode for the camera device view.</summary>
	[Native]
	public enum IKCameraDeviceViewDisplayMode : long {
		None = -1,
		/// <summary>Indicates table.</summary>
		Table = 0,
		/// <summary>Indicates icon.</summary>
		Icon = 1,
	};

	/// <summary>Specifies the transfer mode for the camera device view.</summary>
	[Native]
	public enum IKCameraDeviceViewTransferMode : long {
		/// <summary>Indicates file.</summary>
		File = 0,
		/// <summary>Indicates memory.</summary>
		Memory = 1,
	};

	/// <summary>Specifies the display mode for the device browser view.</summary>
	[Native]
	public enum IKDeviceBrowserViewDisplayMode : long {
		/// <summary>Indicates table.</summary>
		Table = 0,
		/// <summary>Indicates outline.</summary>
		Outline = 1,
		/// <summary>Indicates icon.</summary>
		Icon = 2,
	};

	// Untyped enum in ObjC
	/// <summary>Specifies the state of an image browser cell.</summary>
	public enum IKImageBrowserCellState : int {
		/// <summary>Indicates no image.</summary>
		NoImage = 0,
		/// <summary>Indicates invalid.</summary>
		Invalid = 1,
		/// <summary>Indicates ready.</summary>
		Ready = 2,
	};

	/// <summary>Specifies the resampling mode for image browser cells.</summary>
	[Flags]
	[Native]
	public enum IKCellsStyle : ulong {
		/// <summary>Indicates none.</summary>
		None = 0,
		/// <summary>Indicates shadowed.</summary>
		Shadowed = 1 << 0,
		/// <summary>Indicates outlined.</summary>
		Outlined = 1 << 1,
		/// <summary>Indicates titled.</summary>
		Titled = 1 << 2,
		/// <summary>Indicates subtitled.</summary>
		Subtitled = 1 << 3,
	};

	//used as a value for the IKImageBrowserGroupStyleKey in the NSDictionary that defines a group in IKImageBrowserView
	/// <summary>Specifies the style of a group in the image browser.</summary>
	[Native]
	public enum IKGroupStyle : long {
		/// <summary>Indicates bezel.</summary>
		Bezel = 0,
		/// <summary>Indicates disclosure.</summary>
		Disclosure = 1,
	};

	// Untyped enum in ObjC
	/// <summary>Specifies the drop operation for the image browser.</summary>
	public enum IKImageBrowserDropOperation : int {
		/// <summary>Indicates on.</summary>
		On = 0,
		/// <summary>Indicates before.</summary>
		Before = 1,
	};

	/// <summary>Specifies the transfer mode for the scanner device view.</summary>
	[Native]
	public enum IKScannerDeviceViewTransferMode : long {
		/// <summary>Indicates file.</summary>
		File = 0,
		/// <summary>Indicates memory.</summary>
		Memory = 1,
	};

	/// <summary>Specifies the display mode for the scanner device view.</summary>
	[Native]
	public enum IKScannerDeviceViewDisplayMode : long {
		None = -1,
		/// <summary>Indicates simple.</summary>
		Simple = 0,
		/// <summary>Indicates advanced.</summary>
		Advanced = 1,
	};

	/// <summary>Specifies style mask options for the filter browser panel.</summary>
	[Flags]
	public enum IKFilterBrowserPanelStyleMask : uint {
		/// <summary>Indicates normal.</summary>
		Normal = 0,
		/// <summary>Indicates textured.</summary>
		Textured = 1 << 8,
		// Other NSWindow Style Mask bit settings do not apply to this panel
	}
}
