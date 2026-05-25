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
namespace UIKit {
	/// <summary>How the views in a <see cref="T:UIKit.UIStackView" /> are distributed along the view's alignment axis.</summary><remarks>To be added.</remarks>
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("tvos")]
	[Native]
	public enum UIStackViewDistribution : long {
		/// <summary>Attempts to fill along the <see cref="P:UIKit.UIStackView.Axis" /> according to the <see cref="P:UIKit.UIStackView.ArrangedSubviews" />' <see cref="M:UIKit.UIView.ContentCompressionResistancePriority(UIKit.UILayoutConstraintAxis)" /> and <see cref="M:UIKit.UIView.ContentHuggingPriority(UIKit.UILayoutConstraintAxis)" /> properties.</summary>
		Fill = 0,
		/// <summary>Attempts to fill along the <see cref="P:UIKit.UIStackView.Axis" /> by giving the <see cref="P:UIKit.UIStackView.ArrangedSubviews" /> the same space.</summary>
		FillEqually = 1,
		/// <summary>Attempts to fill along the <see cref="P:UIKit.UIStackView.Axis" /> by giving the <see cref="P:UIKit.UIStackView.ArrangedSubviews" /> the space required by their <see cref="P:UIKit.UIView.IntrinsicContentSize" /> property.</summary>
		FillProportionally = 2,
		/// <summary>Attempts to maintain equal spacing between <see cref="P:UIKit.UIStackView.ArrangedSubviews" />.</summary>
		EqualSpacing = 3,
		/// <summary>Attempts to maintain equal center-to-center spacing between <see cref="P:UIKit.UIStackView.ArrangedSubviews" />.</summary>
		EqualCentering = 4,
	}
}
