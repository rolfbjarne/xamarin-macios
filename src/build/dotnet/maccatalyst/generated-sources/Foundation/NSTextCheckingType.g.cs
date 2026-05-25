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
using Metal;
using CoreML;
using AppKit;
using MapKit;
using Photos;
using ModelIO;
using Network;
using SceneKit;
using Contacts;
using Security;
using CloudKit;
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
using FileProvider;
using CoreAnimation;
using CoreFoundation;
using NetworkExtension;
using MetalPerformanceShadersGraph;
#nullable enable
namespace Foundation {
	/// <summary>Enumerates available predefined regular expressions for checking text.</summary><remarks>To be added.</remarks>
	[Flags]
	public enum NSTextCheckingType : ulong {
		/// <summary>To be added.</summary>
		Orthography = 1,
		/// <summary>To be added.</summary>
		Spelling = 2,
		/// <summary>To be added.</summary>
		Grammar = 4,
		/// <summary>To be added.</summary>
		Date = 8,
		/// <summary>To be added.</summary>
		Address = 16,
		/// <summary>To be added.</summary>
		Link = 32,
		/// <summary>To be added.</summary>
		Quote = 64,
		/// <summary>To be added.</summary>
		Dash = 128,
		/// <summary>To be added.</summary>
		Replacement = 256,
		/// <summary>To be added.</summary>
		Correction = 512,
		/// <summary>To be added.</summary>
		RegularExpression = 1024,
		/// <summary>To be added.</summary>
		PhoneNumber = 2048,
		/// <summary>To be added.</summary>
		TransitInformation = 4096,
	}
}
