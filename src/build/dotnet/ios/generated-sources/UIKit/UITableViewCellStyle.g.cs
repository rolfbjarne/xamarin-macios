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
	/// <summary>The visual style of a <see cref="T:UIKit.UITableViewCell" />.</summary><remarks></remarks>
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("tvos")]
	[Native]
	public enum UITableViewCellStyle : long {
		/// <summary>Plain style with a black, left-aligned <see cref="P:UIKit.UITableViewCell.TextLabel" /> and an optional <see cref="P:UIKit.UITableViewCell.ImageView" /> (that will appear to the left of the text).</summary>
		Default = 0,
		/// <summary>Style with two text labels. The <see cref="P:UIKit.UITableViewCell.TextLabel" /> appears on the left, and is left-aligned with black text. <see cref="P:UIKit.UITableViewCell.DetailTextLabel" /> appears to the right, and is right-aligned with smaller blue text. The Settings app uses this style.</summary>
		Value1 = 1,
		/// <summary>Style with two text labels. The <see cref="P:UIKit.UITableViewCell.TextLabel" /> appears on the left, but is right-aligned with blue text. <see cref="P:UIKit.UITableViewCell.DetailTextLabel" /> appears to the right, but is left-aligned with black text. The detailed contact information in the Contacts app is an example of this cell style.</summary>
		Value2 = 2,
		/// <summary>Style with two text labels. They are both left-aligned, the top <see cref="P:UIKit.UITableViewCell.TextLabel" /> is large black text and the bottom <see cref="P:UIKit.UITableViewCell.DetailTextLabel" /> uses smaller gray text. The Music app's Albums listing is an example of this cell style.</summary>
		Subtitle = 3,
	}
}
