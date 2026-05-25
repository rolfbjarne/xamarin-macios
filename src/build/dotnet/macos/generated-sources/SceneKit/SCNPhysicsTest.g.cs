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
namespace SceneKit {
	/// <summary>Valid options for use with <see cref="M:SceneKit.SCNPhysicsWorld.ContactTest(SceneKit.SCNPhysicsBody,SceneKit.SCNPhysicsBody,Foundation.NSDictionary)" />.</summary>
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("tvos")]
	public partial class SCNPhysicsTest : DictionaryContainer {
#if !COREBUILD
		/// <summary>Creates a new <see cref="SCNPhysicsTest" /> with default (empty) values.</summary>
		public SCNPhysicsTest () : base (new NSMutableDictionary ()) {}
		/// <summary>Creates a new <see cref="SCNPhysicsTest" /> from the values that are specified in <paramref name="dictionary" />.</summary>
		/// <param name="dictionary">The dictionary to use to populate the properties of this type.</param>
		public SCNPhysicsTest (NSDictionary? dictionary) : base (dictionary) {}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		public nuint? CollisionBitMask {
			get {
				return  GetNUIntValue (SCNPhysicsTestKeys.CollisionBitMaskKey!);
			}
			set {
				SetNumberValue (SCNPhysicsTestKeys.CollisionBitMaskKey!, value);
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		public bool? BackfaceCulling {
			get {
				return  GetBoolValue (SCNPhysicsTestKeys.BackfaceCullingKey!);
			}
			set {
				SetBooleanValue (SCNPhysicsTestKeys.BackfaceCullingKey!, value);
			}
		}
		internal NSString? _SearchMode {
			get {
				return GetNSStringValue (SCNPhysicsTestKeys.SearchModeKey);
			}
			set {
				SetStringValue (SCNPhysicsTestKeys.SearchModeKey, value);
			}
		}
#endif
	}
}
