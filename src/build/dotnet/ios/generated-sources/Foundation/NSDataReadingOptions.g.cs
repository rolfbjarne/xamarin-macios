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
using UIKit;
using GLKit;
using Metal;
using CoreML;
using MapKit;
using Photos;
using ModelIO;
using Network;
using SceneKit;
using Contacts;
using Security;
using Messages;
using AudioUnit;
using CoreVideo;
using CoreMedia;
using QuickLook;
using CoreImage;
using SpriteKit;
using Foundation;
using CoreMotion;
using ObjCRuntime;
using AddressBook;
using MediaPlayer;
using GameplayKit;
using CoreGraphics;
using CoreLocation;
using AVFoundation;
using NewsstandKit;
using FileProvider;
using CoreAnimation;
using CoreFoundation;
using NetworkExtension;
using MetalPerformanceShadersGraph;
#nullable enable
namespace Foundation {
	/// <summary>Flags that determine how NSData loads files.</summary><remarks><para>
	/// 	By default NSData will loads the contents of the file in memory
	/// 	by allocating a block of memory and then reading the contents of
	/// 	the file into it.
	/// </para><para>
	/// 	The Mapped and MappedAlways parameter instruct NSData to use
	/// 	the kernel's interface to map the file into the process
	/// 	address space.  This has a few advantages: instead of
	/// 	allocating read/write memory for the process, that becomes
	/// 	real memory usage, the mapped versions map the file into
	/// 	memory which means that the data is loaded on demand instead
	/// 	of being loaded upfront.  This also allows the kernel to
	/// 	discard the data loaded from memory when the system is running
	/// 	low on memory. 
	/// </para></remarks>
	[Flags]
	[Native]
	public enum NSDataReadingOptions : ulong {
		/// <summary>Use the kernel's virtual memory map to load the file, if possible. If sucessful, this replaces read/write memory that can be very expensive with discardable memory that is backed by a file.</summary>
		Mapped = 1,
		/// <summary>Notify the kernel that it should not try to cache the contents of this file in its buffer cache.</summary>
		Uncached = 2,
		/// <summary>Force NSData to try to use the kernel's mapping support to load the file.   If sucessful, this replaces read/write memory that can be very expensive with discardable memory that is backed by a file.</summary>
		MappedAlways = 8,
	}
}
