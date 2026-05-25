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
namespace CoreFoundation {
	/// <summary>Provides the necessary methods needed for accessing the system's global proxy configuration settings and resolving a list of proxies to use for connecting to a URL.</summary>
	public unsafe partial class CFNetwork  {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ErrorDomain;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCFErrorDomainCFNetwork",  "CFNetwork")]
		public static NSString ErrorDomain {
			get {
				if (_ErrorDomain is null)
					_ErrorDomain = Dlfcn.GetStringConstant (Libraries.CFNetwork.Handle, "kCFErrorDomainCFNetwork")!;
				return _ErrorDomain;
			}
		}
	} /* class CFNetwork */
}
