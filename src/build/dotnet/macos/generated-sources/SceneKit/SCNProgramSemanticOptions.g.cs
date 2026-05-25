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
	/// <summary>Defines the <see cref="P:SceneKit.SCNProgramSemanticOptions.MappingChannel" /> for use with <see cref="M:SceneKit.SCNProgram.SetSemantic(Foundation.NSString,System.String,SceneKit.SCNProgramSemanticOptions)" />.</summary>
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("tvos")]
	public partial class SCNProgramSemanticOptions : DictionaryContainer {
#if !COREBUILD
		/// <summary>Creates a new <see cref="SCNProgramSemanticOptions" /> with default (empty) values.</summary>
		public SCNProgramSemanticOptions () : base (new NSMutableDictionary ()) {}
		/// <summary>Creates a new <see cref="SCNProgramSemanticOptions" /> from the values that are specified in <paramref name="dictionary" />.</summary>
		/// <param name="dictionary">The dictionary to use to populate the properties of this type.</param>
		public SCNProgramSemanticOptions (NSDictionary? dictionary) : base (dictionary) {}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		public nuint? MappingChannel {
			get {
				return  GetNUIntValue (SCNProgram.MappingChannelKey!);
			}
			set {
				SetNumberValue (SCNProgram.MappingChannelKey!, value);
			}
		}
#endif
	}
}
