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
namespace Metal {
	/// <summary>Enumeration of error codes describing why a command buffer has failed.</summary>
	[Native]
	public enum MTLCommandBufferError : ulong {
		/// <summary>To be added.</summary>
		None = 0,
		/// <summary>To be added.</summary>
		Internal = 1,
		/// <summary>To be added.</summary>
		Timeout = 2,
		/// <summary>To be added.</summary>
		PageFault = 3,
		/// <summary>To be added.</summary>
		Blacklisted = 4,
		/// <summary>To be added.</summary>
		NotPermitted = 7,
		/// <summary>To be added.</summary>
		OutOfMemory = 8,
		/// <summary>To be added.</summary>
		InvalidResource = 9,
		/// <summary>To be added.</summary>
		Memoryless = 10,
		/// <summary>Indicates that the device was removed.</summary>
		DeviceRemoved = 11,
		StackOverflow = 12,
	}
	/// <summary>Extension methods for the <see cref="global::Metal.MTLCommandBufferError" /> enumeration.</summary>
	/// <remarks>
	///   <para>The extension method for the <see cref="global::Metal.MTLCommandBufferError" /> enumeration can be used to fetch the error domain associated with these error codes.</para>
	/// </remarks>
	[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	static public partial class MTLCommandBufferErrorExtensions {
		[Field ("MTLCommandBufferErrorDomain", "Metal")]
		static NSString? _domain;
		/// <summary>Returns the error domain associated with the Metal.MTLCommandBufferError value</summary>
		/// <param name="self">The enumeration value</param>
		/// <remarks>
		///   <para>See the <see cref="global::Foundation.NSError" /> for information on how to use the error domains when reporting errors.</para>
		/// </remarks>
		public static NSString? GetDomain (this MTLCommandBufferError self)
		{
			if (_domain is null)
				_domain = Dlfcn.GetStringConstant (Libraries.Metal.Handle, "MTLCommandBufferErrorDomain");
			return _domain;
		}
	}
}
