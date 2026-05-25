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
	/// <summary>Identifiers for iOS-provided activities.</summary><remarks><para>These identifiers correspond to the <see cref="P:UIKit.UIActivity.Type" /> property of the iOS-provided <see cref="T:UIKit.UIActivity" />s. </para><para>They are typically used as values for the <see cref="P:UIKit.UIActivity.Type" /> or as parameters in the constructor for <see cref="T:UIKit.UIActivityViewController" />.</para><example><code lang="csharp lang-csharp"><![CDATA[
	/// //
	/// // Share an image 
	/// //
	/// var imageToShare = UIImage.FromFile ("demo.png");
	/// var activityItems = new NSObject[] { imageToShare };
	/// var controller = new UIActivityViewController (activityItems, null);
	/// this.PresentViewController(controller, true, null)
	/// 
	/// // 
	/// // Now share the image, but explicitly exclude posting as a message
	/// //
	/// controller = new UIActivityViewController (activityItems, null) {
	/// ExcludedActivityTypes = new NSString[] {
	/// UIActivityType.PostToWeibo,
	/// UIActivityType.Message
	/// }
	/// };
	/// this.PresentViewController(controller, true, null)
	/// 
	/// 	]]></code></example></remarks>
	[UnsupportedOSPlatform ("tvos")]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	public unsafe static partial class UIActivityType  {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _AddToHomeScreen;
		/// <summary>Represents the value associated with the constant 'UIActivityTypeAddToHomeScreen'.</summary>
		[Field ("UIActivityTypeAddToHomeScreen",  "UIKit")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios16.4")]
		[SupportedOSPlatform ("maccatalyst16.4")]
		public static NSString AddToHomeScreen {
			[UnsupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("ios16.4")]
			[SupportedOSPlatform ("maccatalyst16.4")]
			get {
				if (_AddToHomeScreen is null)
					_AddToHomeScreen = Dlfcn.GetStringConstant (Libraries.UIKit.Handle, "UIActivityTypeAddToHomeScreen")!;
				return _AddToHomeScreen;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _AddToReadingList;
		/// <summary>This activity adds a URL to the Safari Reading List.</summary><value></value><remarks></remarks>
		[Field ("UIActivityTypeAddToReadingList",  "UIKit")]
		public static NSString AddToReadingList {
			get {
				if (_AddToReadingList is null)
					_AddToReadingList = Dlfcn.GetStringConstant (Libraries.UIKit.Handle, "UIActivityTypeAddToReadingList")!;
				return _AddToReadingList;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _AirDrop;
		/// <summary>Makes the provided object available over AirDrop.</summary><remarks>
		/// The object must hold an individual <see cref="T:Foundation.NSAttributedString" />, <see cref="T:Foundation.NSString" />,
		/// <see cref="T:Foundation.NSUrl" />, or <see cref="T:UIKit.UIImage" />.
		/// Or you can provide a collection of those objects by passing an <see cref="T:Foundation.NSDictionary" /> or an <see cref="T:Foundation.NSArray" />
		/// with those objects.
		/// </remarks>
		[Field ("UIActivityTypeAirDrop",  "UIKit")]
		public static NSString AirDrop {
			get {
				if (_AirDrop is null)
					_AirDrop = Dlfcn.GetStringConstant (Libraries.UIKit.Handle, "UIActivityTypeAirDrop")!;
				return _AirDrop;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _AssignToContact;
		/// <summary>Assigns a UIImage to a contact.</summary><value></value><remarks>The value provided must be a <see cref="T:UIKit.UIImage" />.</remarks>
		[Field ("UIActivityTypeAssignToContact",  "UIKit")]
		public static NSString AssignToContact {
			get {
				if (_AssignToContact is null)
					_AssignToContact = Dlfcn.GetStringConstant (Libraries.UIKit.Handle, "UIActivityTypeAssignToContact")!;
				return _AssignToContact;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _CollaborationCopyLink;
		/// <summary>Represents the value associated with the constant 'UIActivityTypeCollaborationCopyLink'.</summary>
		[Field ("UIActivityTypeCollaborationCopyLink",  "UIKit")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios16.0")]
		[SupportedOSPlatform ("maccatalyst16.0")]
		public static NSString CollaborationCopyLink {
			[UnsupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("ios16.0")]
			[SupportedOSPlatform ("maccatalyst16.0")]
			get {
				if (_CollaborationCopyLink is null)
					_CollaborationCopyLink = Dlfcn.GetStringConstant (Libraries.UIKit.Handle, "UIActivityTypeCollaborationCopyLink")!;
				return _CollaborationCopyLink;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _CollaborationInviteWithLink;
		/// <summary>Represents the value associated with the constant 'UIActivityTypeCollaborationInviteWithLink'.</summary>
		[Field ("UIActivityTypeCollaborationInviteWithLink",  "UIKit")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios16.0")]
		[SupportedOSPlatform ("maccatalyst16.0")]
		public static NSString CollaborationInviteWithLink {
			[UnsupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("ios16.0")]
			[SupportedOSPlatform ("maccatalyst16.0")]
			get {
				if (_CollaborationInviteWithLink is null)
					_CollaborationInviteWithLink = Dlfcn.GetStringConstant (Libraries.UIKit.Handle, "UIActivityTypeCollaborationInviteWithLink")!;
				return _CollaborationInviteWithLink;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _CopyToPasteboard;
		/// <summary>Makes the object available on the pasteboard.</summary><value></value><remarks>
		/// 	  The object must hold an individual <see cref="T:Foundation.NSString" />, <see cref="T:Foundation.NSUrl" />, <see cref="T:UIKit.UIColor" />, <see cref="T:UIKit.UIImage" />.  Or you can provide a
		/// 	  collection of those objects by passing an NSDictionary with those objects.
		/// 	</remarks>
		[Field ("UIActivityTypeCopyToPasteboard",  "UIKit")]
		public static NSString CopyToPasteboard {
			get {
				if (_CopyToPasteboard is null)
					_CopyToPasteboard = Dlfcn.GetStringConstant (Libraries.UIKit.Handle, "UIActivityTypeCopyToPasteboard")!;
				return _CopyToPasteboard;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _Mail;
		/// <summary>Sends the provided content by email.</summary><value></value><remarks>
		/// 	  The object must hold an individual <see cref="T:Foundation.NSString" />, <see cref="T:Foundation.NSUrl" /> (pointing to a local file) or a <see cref="T:UIKit.UIImage" />.  
		/// 	</remarks>
		[Field ("UIActivityTypeMail",  "UIKit")]
		public static NSString Mail {
			get {
				if (_Mail is null)
					_Mail = Dlfcn.GetStringConstant (Libraries.UIKit.Handle, "UIActivityTypeMail")!;
				return _Mail;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _MarkupAsPdf;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("UIActivityTypeMarkupAsPDF",  "UIKit")]
		[SupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios")]
		public static NSString MarkupAsPdf {
			[SupportedOSPlatform ("maccatalyst")]
			[UnsupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("ios")]
			get {
				if (_MarkupAsPdf is null)
					_MarkupAsPdf = Dlfcn.GetStringConstant (Libraries.UIKit.Handle, "UIActivityTypeMarkupAsPDF")!;
				return _MarkupAsPdf;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _Message;
		/// <summary>Represents the value associated with the constant UIActivityTypeMessage</summary><value></value><remarks>To be added.</remarks>
		[Field ("UIActivityTypeMessage",  "UIKit")]
		public static NSString Message {
			get {
				if (_Message is null)
					_Message = Dlfcn.GetStringConstant (Libraries.UIKit.Handle, "UIActivityTypeMessage")!;
				return _Message;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _OpenInIBooks;
		/// <summary>Indicates the activity of opening a document in iBooks.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("UIActivityTypeOpenInIBooks",  "UIKit")]
		[SupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios")]
		public static NSString OpenInIBooks {
			[SupportedOSPlatform ("maccatalyst")]
			[UnsupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("ios")]
			get {
				if (_OpenInIBooks is null)
					_OpenInIBooks = Dlfcn.GetStringConstant (Libraries.UIKit.Handle, "UIActivityTypeOpenInIBooks")!;
				return _OpenInIBooks;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _PostToFacebook;
		/// <summary>Represents the value associated with the constant UIActivityTypePostToFacebook</summary><value /><remarks>To be added.</remarks>
		[Field ("UIActivityTypePostToFacebook",  "UIKit")]
		public static NSString PostToFacebook {
			get {
				if (_PostToFacebook is null)
					_PostToFacebook = Dlfcn.GetStringConstant (Libraries.UIKit.Handle, "UIActivityTypePostToFacebook")!;
				return _PostToFacebook;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _PostToFlickr;
		/// <summary>Represents the value associated with the constant UIActivityTypePostToFlickr</summary><value></value><remarks>To be added.</remarks>
		[Field ("UIActivityTypePostToFlickr",  "UIKit")]
		public static NSString PostToFlickr {
			get {
				if (_PostToFlickr is null)
					_PostToFlickr = Dlfcn.GetStringConstant (Libraries.UIKit.Handle, "UIActivityTypePostToFlickr")!;
				return _PostToFlickr;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _PostToTencentWeibo;
		/// <summary>Represents the value associated with the constant UIActivityTypePostToTencentWeibo</summary><value></value><remarks>To be added.</remarks>
		[Field ("UIActivityTypePostToTencentWeibo",  "UIKit")]
		public static NSString PostToTencentWeibo {
			get {
				if (_PostToTencentWeibo is null)
					_PostToTencentWeibo = Dlfcn.GetStringConstant (Libraries.UIKit.Handle, "UIActivityTypePostToTencentWeibo")!;
				return _PostToTencentWeibo;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _PostToTwitter;
		/// <summary>Represents the value associated with the constant UIActivityTypePostToTwitter</summary><value></value><remarks>To be added.</remarks>
		[Field ("UIActivityTypePostToTwitter",  "UIKit")]
		public static NSString PostToTwitter {
			get {
				if (_PostToTwitter is null)
					_PostToTwitter = Dlfcn.GetStringConstant (Libraries.UIKit.Handle, "UIActivityTypePostToTwitter")!;
				return _PostToTwitter;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _PostToVimeo;
		/// <summary>Represents the value associated with the constant UIActivityTypePostToVimeo</summary><value></value><remarks>To be added.</remarks>
		[Field ("UIActivityTypePostToVimeo",  "UIKit")]
		public static NSString PostToVimeo {
			get {
				if (_PostToVimeo is null)
					_PostToVimeo = Dlfcn.GetStringConstant (Libraries.UIKit.Handle, "UIActivityTypePostToVimeo")!;
				return _PostToVimeo;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _PostToWeibo;
		/// <summary>Represents the value associated with the constant UIActivityTypePostToWeibo</summary><value></value><remarks>To be added.</remarks>
		[Field ("UIActivityTypePostToWeibo",  "UIKit")]
		public static NSString PostToWeibo {
			get {
				if (_PostToWeibo is null)
					_PostToWeibo = Dlfcn.GetStringConstant (Libraries.UIKit.Handle, "UIActivityTypePostToWeibo")!;
				return _PostToWeibo;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _Print;
		/// <summary>Used to print the provided object.</summary><value></value><remarks>
		/// 	  The object must hold an individual <see cref="T:Foundation.NSData" />, <see cref="T:Foundation.NSUrl" /> (pointing to a local resource), <see cref="T:UIKit.UIImage" />,  <see cref="T:UIKit.UIPrintPageRenderer" />, <see cref="T:UIKit.UIPrintFormatter" /> or <see cref="T:UIKit.UIPrintInfo" />.
		/// 	</remarks>
		[Field ("UIActivityTypePrint",  "UIKit")]
		public static NSString Print {
			get {
				if (_Print is null)
					_Print = Dlfcn.GetStringConstant (Libraries.UIKit.Handle, "UIActivityTypePrint")!;
				return _Print;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _SaveToCameraRoll;
		/// <summary>Represents the value associated with the constant UIActivityTypeSaveToCameraRoll</summary><value></value><remarks>To be added.</remarks>
		[Field ("UIActivityTypeSaveToCameraRoll",  "UIKit")]
		public static NSString SaveToCameraRoll {
			get {
				if (_SaveToCameraRoll is null)
					_SaveToCameraRoll = Dlfcn.GetStringConstant (Libraries.UIKit.Handle, "UIActivityTypeSaveToCameraRoll")!;
				return _SaveToCameraRoll;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _UIActivityTypeSharePlay;
		/// <summary>Represents the value associated with the constant 'UIActivityTypeSharePlay'.</summary>
		[Field ("UIActivityTypeSharePlay",  "UIKit")]
		[SupportedOSPlatform ("ios15.4")]
		[SupportedOSPlatform ("maccatalyst15.4")]
		[UnsupportedOSPlatform ("tvos")]
		public static NSString UIActivityTypeSharePlay {
			[SupportedOSPlatform ("ios15.4")]
			[SupportedOSPlatform ("maccatalyst15.4")]
			[UnsupportedOSPlatform ("tvos")]
			get {
				if (_UIActivityTypeSharePlay is null)
					_UIActivityTypeSharePlay = Dlfcn.GetStringConstant (Libraries.UIKit.Handle, "UIActivityTypeSharePlay")!;
				return _UIActivityTypeSharePlay;
			}
		}
	} /* class UIActivityType */
}
