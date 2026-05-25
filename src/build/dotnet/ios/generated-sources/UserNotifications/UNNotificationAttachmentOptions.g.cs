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
namespace UserNotifications {
	/// <summary>A dictionary of values that control aspects of notification behavior.</summary>
	[UnsupportedOSPlatform ("tvos")]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	public partial class UNNotificationAttachmentOptions : DictionaryContainer {
#if !COREBUILD
		/// <summary>Creates a new <see cref="UNNotificationAttachmentOptions" /> with default (empty) values.</summary>
		public UNNotificationAttachmentOptions () : base (new NSMutableDictionary ()) {}
		/// <summary>Creates a new <see cref="UNNotificationAttachmentOptions" /> from the values that are specified in <paramref name="dictionary" />.</summary>
		/// <param name="dictionary">The dictionary to use to populate the properties of this type.</param>
		public UNNotificationAttachmentOptions (NSDictionary? dictionary) : base (dictionary) {}
		/// <summary>Gets or sets a type hint for the attachment.</summary><value>The type hint for the attachment.</value><remarks>To be added.</remarks>
		public string? TypeHint {
			get {
				return GetStringValue (UNNotificationAttachmentOptionsKeys.TypeHint!);
			}
			set {
				SetStringValue (UNNotificationAttachmentOptionsKeys.TypeHint!, value);
			}
		}
		/// <summary>Gets or sets a value that controls whether the thumbnail image is hidden.</summary><value>To be added.</value><remarks>To be added.</remarks>
		public bool? ThumbnailHidden {
			get {
				return  GetBoolValue (UNNotificationAttachmentOptionsKeys.ThumbnailHidden!);
			}
			set {
				SetBooleanValue (UNNotificationAttachmentOptionsKeys.ThumbnailHidden!, value);
			}
		}
		/// <summary>Gets or sets the clipping rectangle for displaying a thumbail image from a larger source image.</summary><value>The clipping rectangle for displaying a thumbail image from a larger source image.</value><remarks>To be added.</remarks>
		public CGRect? ThumbnailClippingRect {
			get {
				return  GetCGRectValue (UNNotificationAttachmentOptionsKeys.ThumbnailClippingRect!);
			}
			set {
				SetCGRectValue (UNNotificationAttachmentOptionsKeys.ThumbnailClippingRect!, value);
			}
		}
		/// <summary>Gets or sets the number of a starting frame for an animated attachment image.</summary><value>The number of a starting frame for an animated image.</value><remarks>To be added.</remarks>
		public global::CoreMedia.CMTime? ThumbnailTime {
			get {
				return  GetCMTimeValue (UNNotificationAttachmentOptionsKeys.ThumbnailTime!);
			}
			set {
				SetCMTimeValue (UNNotificationAttachmentOptionsKeys.ThumbnailTime!, value);
			}
		}
		/// <summary>Gets or sets the time offset at which to begin playing an animated attachment image.</summary><value>The time offset at which to begin playing an animated attachment image.</value><remarks>To be added.</remarks>
		public double? ThumbnailTimeInSeconds {
			get {
				return  GetDoubleValue (UNNotificationAttachmentOptionsKeys.ThumbnailTime!);
			}
			set {
				SetNumberValue (UNNotificationAttachmentOptionsKeys.ThumbnailTime!, value);
			}
		}
#endif
	}
}
