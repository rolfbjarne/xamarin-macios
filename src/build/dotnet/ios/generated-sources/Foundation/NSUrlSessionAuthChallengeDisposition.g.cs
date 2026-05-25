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
	/// <summary>An enumeration whose values specify the state of an authorization challenge.</summary><remarks><para>Instances of this type are passed as an argument to the completion handler callback in <see cref="M:Foundation.NSUrlSessionDelegate.DidReceiveChallenge(Foundation.NSUrlSession,Foundation.NSUrlAuthenticationChallenge,System.Action{Foundation.NSUrlSessionAuthChallengeDisposition,Foundation.NSUrlCredential})" /> and its overrides.</para></remarks>
	[Native]
	public enum NSUrlSessionAuthChallengeDisposition : long {
		/// <summary>To be added.</summary>
		UseCredential = 0,
		/// <summary>To be added.</summary>
		PerformDefaultHandling = 1,
		/// <summary>To be added.</summary>
		CancelAuthenticationChallenge = 2,
		/// <summary>To be added.</summary>
		RejectProtectionSpace = 3,
	}
}
