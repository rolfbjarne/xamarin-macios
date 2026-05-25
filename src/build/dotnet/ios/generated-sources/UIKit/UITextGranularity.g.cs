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
namespace UIKit {
	/// <summary>An enumeration of values that specify the granularity of a text range .</summary><remarks>To be added.</remarks><altmember cref="T:UIKit.UITextInputStringTokenizer" /><altmember cref="T:UIKit.UITextInputTokenizer" />
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("tvos")]
	[Native]
	public enum UITextGranularity : long {
		/// <summary>The unit of text is a character.</summary>
		Character = 0,
		/// <summary>The unit of text is a word.</summary>
		Word = 1,
		/// <summary>The unit of text is a sentence.</summary>
		Sentence = 2,
		/// <summary>The unit of text is a paragraph.</summary>
		Paragraph = 3,
		/// <summary>The unit of text is a line.</summary>
		Line = 4,
		/// <summary>The unit of text is a document.</summary>
		Document = 5,
	}
}
