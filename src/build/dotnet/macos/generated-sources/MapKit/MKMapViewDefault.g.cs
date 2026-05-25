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
namespace MapKit {
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("tvos")]
	public unsafe static partial class MKMapViewDefault  {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _AnnotationViewReuseIdentifier;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("MKMapViewDefaultAnnotationViewReuseIdentifier",  "MapKit")]
		public static NSString AnnotationViewReuseIdentifier {
			get {
				if (_AnnotationViewReuseIdentifier is null)
					_AnnotationViewReuseIdentifier = Dlfcn.GetStringConstant (Libraries.MapKit.Handle, "MKMapViewDefaultAnnotationViewReuseIdentifier")!;
				return _AnnotationViewReuseIdentifier;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ClusterAnnotationViewReuseIdentifier;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("MKMapViewDefaultClusterAnnotationViewReuseIdentifier",  "MapKit")]
		public static NSString ClusterAnnotationViewReuseIdentifier {
			get {
				if (_ClusterAnnotationViewReuseIdentifier is null)
					_ClusterAnnotationViewReuseIdentifier = Dlfcn.GetStringConstant (Libraries.MapKit.Handle, "MKMapViewDefaultClusterAnnotationViewReuseIdentifier")!;
				return _ClusterAnnotationViewReuseIdentifier;
			}
		}
	} /* class MKMapViewDefault */
}
