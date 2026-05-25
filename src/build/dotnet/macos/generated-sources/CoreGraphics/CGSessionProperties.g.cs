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
namespace CoreGraphics {
	[UnsupportedOSPlatform ("ios")]
	[UnsupportedOSPlatform ("tvos")]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("macos")]
	public partial class CGSessionProperties : DictionaryContainer {
#if !COREBUILD
		/// <summary>Creates a new <see cref="CGSessionProperties" /> with default (empty) values.</summary>
		public CGSessionProperties () : base (new NSMutableDictionary ()) {}
		/// <summary>Creates a new <see cref="CGSessionProperties" /> from the values that are specified in <paramref name="dictionary" />.</summary>
		/// <param name="dictionary">The dictionary to use to populate the properties of this type.</param>
		public CGSessionProperties (NSDictionary? dictionary) : base (dictionary) {}
		public uint? UserId {
			get {
				return  GetUInt32Value (CGSessionKeys.UserIdKey!);
			}
		}
		public string? UserName {
			get {
				return GetStringValue (CGSessionKeys.UserNameKey!);
			}
		}
		public uint? ConsoleSet {
			get {
				return  GetUInt32Value (CGSessionKeys.ConsoleSetKey!);
			}
		}
		public bool? OnConsole {
			get {
				return  GetBoolValue (CGSessionKeys.OnConsoleKey!);
			}
		}
		public bool? LoginDone {
			get {
				return  GetBoolValue (CGSessionKeys.LoginDoneKey!);
			}
		}
#endif
	}
}
