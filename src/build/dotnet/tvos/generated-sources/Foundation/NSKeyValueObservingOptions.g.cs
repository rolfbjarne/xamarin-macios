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
using Photos;
using ModelIO;
using Network;
using SceneKit;
using Security;
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
using CoreAnimation;
using CoreFoundation;
using NetworkExtension;
using MetalPerformanceShadersGraph;
#nullable enable
namespace Foundation {
	/// <summary>An enumeration of values specifying options to be used with the <see cref="Foundation.NSObject.AddObserver(Foundation.NSObject,System.String,Foundation.NSKeyValueObservingOptions,System.IntPtr)" /> method.</summary><remarks><para></para></remarks>
	[Flags]
	[Native]
	public enum NSKeyValueObservingOptions : ulong {
		None = 0,
		/// <summary>Request that new values be delivered to the observer.</summary>
		New = 1,
		/// <summary>Requests that old values be delivered to the observer.</summary>
		Old = 2,
		/// <summary>Requests that both old and new values be delivered to the observer.</summary>
		OldNew = 3,
		/// <summary>Use this to send a notification on first use, without waiting for an actual change to take place.</summary>
		Initial = 4,
		/// <summary>If set, notifications are sent before and after the change to the property is made.   Otherwise the notifications are only sent after the property has been set.</summary>
		Prior = 8,
	}
}
