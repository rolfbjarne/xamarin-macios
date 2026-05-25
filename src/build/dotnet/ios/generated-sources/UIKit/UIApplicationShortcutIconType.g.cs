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
	/// <summary>Enumerates system-provided icons for quick actions.</summary><remarks><list type="table"><listheader><term>Concern</term><description>Value</description><description>Icon</description></listheader><item><term>Add</term><description><see cref="F:UIKit.UIApplicationShortcutIconType.Add" /></description><description><img href="~/xml/UIKit/_images/UIKit.UIApplicationShortcutIconType.Add.png" alt="Application shortcut icon." /></description></item><item><term>Alarm</term><description><see cref="F:UIKit.UIApplicationShortcutIconType.Alarm" /></description><description><img href="~/xml/UIKit/_images/UIKit.UIApplicationShortcutIconType.Alarm.png" alt="Application shortcut icon." /></description></item><item><term>Audio</term><description><see cref="F:UIKit.UIApplicationShortcutIconType.Audio" /></description><description><img href="~/xml/UIKit/_images/UIKit.UIApplicationShortcutIconType.Audio.png" alt="Application shortcut icon." /></description></item><item><term>Bookmark</term><description><see cref="F:UIKit.UIApplicationShortcutIconType.Bookmark" /></description><description><img href="~/xml/UIKit/_images/UIKit.UIApplicationShortcutIconType.Bookmark.png" alt="Application shortcut icon." /></description></item><item><term>CapturePhoto</term><description><see cref="F:UIKit.UIApplicationShortcutIconType.CapturePhoto" /></description><description><img href="~/xml/UIKit/_images/UIKit.UIApplicationShortcutIconType.CapturePhoto.png" alt="Application shortcut icon." /></description></item><item><term>CaptureVideo</term><description><see cref="F:UIKit.UIApplicationShortcutIconType.CaptureVideo" /></description><description><img href="~/xml/UIKit/_images/UIKit.UIApplicationShortcutIconType.CaptureVideo.png" alt="Application shortcut icon." /></description></item><item><term>Cloud</term><description><see cref="F:UIKit.UIApplicationShortcutIconType.Cloud" /></description><description><img href="~/xml/UIKit/_images/UIKit.UIApplicationShortcutIconType.Cloud.png" alt="Application shortcut icon." /></description></item><item><term>Compose</term><description><see cref="F:UIKit.UIApplicationShortcutIconType.Compose" /></description><description><img href="~/xml/UIKit/_images/UIKit.UIApplicationShortcutIconType.Compose.png" alt="Application shortcut icon." /></description></item><item><term>Confirmation</term><description><see cref="F:UIKit.UIApplicationShortcutIconType.Confirmation" /></description><description><img href="~/xml/UIKit/_images/UIKit.UIApplicationShortcutIconType.Confirmation.png" alt="Application shortcut icon." /></description></item><item><term>Contact</term><description><see cref="F:UIKit.UIApplicationShortcutIconType.Contact" /></description><description><img href="~/xml/UIKit/_images/UIKit.UIApplicationShortcutIconType.Contact.png" alt="Application shortcut icon." /></description></item><item><term>Date</term><description><see cref="F:UIKit.UIApplicationShortcutIconType.Date" /></description><description><img href="~/xml/UIKit/_images/UIKit.UIApplicationShortcutIconType.Date.png" alt="Application shortcut icon." /></description></item><item><term>Favorite</term><description><see cref="F:UIKit.UIApplicationShortcutIconType.Favorite" /></description><description><img href="~/xml/UIKit/_images/UIKit.UIApplicationShortcutIconType.Favorite.png" alt="Application shortcut icon." /></description></item><item><term>Home</term><description><see cref="F:UIKit.UIApplicationShortcutIconType.Home" /></description><description><img href="~/xml/UIKit/_images/UIKit.UIApplicationShortcutIconType.Home.png" alt="Application shortcut icon." /></description></item><item><term>Invitation</term><description><see cref="F:UIKit.UIApplicationShortcutIconType.Invitation" /></description><description><img href="~/xml/UIKit/_images/UIKit.UIApplicationShortcutIconType.Invitation.png" alt="Application shortcut icon." /></description></item><item><term>Location</term><description><see cref="F:UIKit.UIApplicationShortcutIconType.Location" /></description><description><img href="~/xml/UIKit/_images/UIKit.UIApplicationShortcutIconType.Location.png" alt="Application shortcut icon." /></description></item><item><term>Love</term><description><see cref="F:UIKit.UIApplicationShortcutIconType.Love" /></description><description><img href="~/xml/UIKit/_images/UIKit.UIApplicationShortcutIconType.Love.png" alt="Application shortcut icon." /></description></item><item><term>Mail</term><description><see cref="F:UIKit.UIApplicationShortcutIconType.Mail" /></description><description><img href="~/xml/UIKit/_images/UIKit.UIApplicationShortcutIconType.Mail.png" alt="Application shortcut icon." /></description></item><item><term>MarkLocation</term><description><see cref="F:UIKit.UIApplicationShortcutIconType.MarkLocation" /></description><description><img href="~/xml/UIKit/_images/UIKit.UIApplicationShortcutIconType.MarkLocation.png" alt="Application shortcut icon." /></description></item><item><term>Message</term><description><see cref="F:UIKit.UIApplicationShortcutIconType.Message" /></description><description><img href="~/xml/UIKit/_images/UIKit.UIApplicationShortcutIconType.Message.png" alt="Application shortcut icon." /></description></item><item><term>Pause</term><description><see cref="F:UIKit.UIApplicationShortcutIconType.Pause" /></description><description><img href="~/xml/UIKit/_images/UIKit.UIApplicationShortcutIconType.Pause.png" alt="Application shortcut icon." /></description></item><item><term>Play</term><description><see cref="F:UIKit.UIApplicationShortcutIconType.Play" /></description><description><img href="~/xml/UIKit/_images/UIKit.UIApplicationShortcutIconType.Play.png" alt="Application shortcut icon." /></description></item><item><term>Prohibit</term><description><see cref="F:UIKit.UIApplicationShortcutIconType.Prohibit" /></description><description><img href="~/xml/UIKit/_images/UIKit.UIApplicationShortcutIconType.Prohibit.png" alt="Application shortcut icon." /></description></item><item><term>Search</term><description><see cref="F:UIKit.UIApplicationShortcutIconType.Search" /></description><description><img href="~/xml/UIKit/_images/UIKit.UIApplicationShortcutIconType.Search.png" alt="Application shortcut icon." /></description></item><item><term>Share</term><description><see cref="F:UIKit.UIApplicationShortcutIconType.Share" /></description><description><img href="~/xml/UIKit/_images/UIKit.UIApplicationShortcutIconType.Share.png" alt="Application shortcut icon." /></description></item><item><term>Shuffle</term><description><see cref="F:UIKit.UIApplicationShortcutIconType.Shuffle" /></description><description><img href="~/xml/UIKit/_images/UIKit.UIApplicationShortcutIconType.Shuffle.png" alt="Application shortcut icon." /></description></item><item><term>Task</term><description><see cref="F:UIKit.UIApplicationShortcutIconType.Task" /></description><description><img href="~/xml/UIKit/_images/UIKit.UIApplicationShortcutIconType.Task.png" alt="Application shortcut icon." /></description></item><item><term>TaskCompleted</term><description><see cref="F:UIKit.UIApplicationShortcutIconType.TaskCompleted" /></description><description><img href="~/xml/UIKit/_images/UIKit.UIApplicationShortcutIconType.TaskCompleted.png" alt="Application shortcut icon." /></description></item><item><term>Time</term><description><see cref="F:UIKit.UIApplicationShortcutIconType.Time" /></description><description><img href="~/xml/UIKit/_images/UIKit.UIApplicationShortcutIconType.Time.png" alt="Application shortcut icon." /></description></item><item><term>Update</term><description><see cref="F:UIKit.UIApplicationShortcutIconType.Update" /></description><description><img href="~/xml/UIKit/_images/UIKit.UIApplicationShortcutIconType.Update.png" alt="Application shortcut icon." /></description></item></list></remarks>
	[UnsupportedOSPlatform ("tvos")]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[Native]
	public enum UIApplicationShortcutIconType : long {
		/// <summary>Icon for a "Compose" Quick Action</summary>
		Compose = 0,
		/// <summary>Icon for a "Play" Quick Action</summary>
		Play = 1,
		/// <summary>Icon for a "Pause" Quick Action</summary>
		Pause = 2,
		/// <summary>Icon for a "Add" Quick Action</summary>
		Add = 3,
		/// <summary>Icon for a "Location" Quick Action</summary>
		Location = 4,
		/// <summary>Icon for a "Search" Quick Action</summary>
		Search = 5,
		/// <summary>Icon for a "Share" Quick Action</summary>
		Share = 6,
		/// <summary>Icon for a "Prohibit" Quick Action</summary>
		Prohibit = 7,
		/// <summary>Icon for a "Contact" Quick Action</summary>
		Contact = 8,
		/// <summary>Icon for a "Home" Quick Action</summary>
		Home = 9,
		/// <summary>Icon for a "MarkLocation" Quick Action</summary>
		MarkLocation = 10,
		/// <summary>Icon for a "Favorite" Quick Action</summary>
		Favorite = 11,
		/// <summary>Icon for a "Love" Quick Action</summary>
		Love = 12,
		/// <summary>Icon for a "Cloud" Quick Action</summary>
		Cloud = 13,
		/// <summary>Icon for a "Invitation" Quick Action</summary>
		Invitation = 14,
		/// <summary>Icon for a "Confirmation" Quick Action</summary>
		Confirmation = 15,
		/// <summary>Icon for a "Mail" Quick Action</summary>
		Mail = 16,
		/// <summary>Icon for a "Message" Quick Action</summary>
		Message = 17,
		/// <summary>Icon for a "Date" Quick Action</summary>
		Date = 18,
		/// <summary>Icon for a "Time" Quick Action</summary>
		Time = 19,
		/// <summary>Icon for a "CapturePhoto" Quick Action</summary>
		CapturePhoto = 20,
		/// <summary>Icon for a "CaptureVideo" Quick Action</summary>
		CaptureVideo = 21,
		/// <summary>Icon for a "Task" Quick Action</summary>
		Task = 22,
		/// <summary>Icon for a "TaskCompleted" Quick Action</summary>
		TaskCompleted = 23,
		/// <summary>Icon for a "Alarm" Quick Action</summary>
		Alarm = 24,
		/// <summary>Icon for a "Bookmark" Quick Action</summary>
		Bookmark = 25,
		/// <summary>Icon for a "Shuffle" Quick Action</summary>
		Shuffle = 26,
		/// <summary>Icon for a "Audio" Quick Action</summary>
		Audio = 27,
		/// <summary>Icon for a "Update" Quick Action</summary>
		Update = 28,
	}
}
