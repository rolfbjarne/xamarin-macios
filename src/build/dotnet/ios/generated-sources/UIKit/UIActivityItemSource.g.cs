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
	#pragma warning disable CS1573
	/// <summary>Abstract class that, when implemented, provides data for use by a <see cref="T:UIKit.UIActivityViewController" /></summary><remarks><para>This class should not be used for complex processing, as it is called on the main UI thread. Applications that require complex processing of data before passing it to <see cref="T:UIKit.UIActivity" /> objects should implement <see cref="T:UIKit.UIActivityItemProvider" />.</para></remarks><related type="externalDocumentation" href="https://developer.apple.com/library/ios/documentation/UIKit/Reference/UIActivityItemSource_protocol/index.html">Apple documentation for <c>UIActivityItemSource</c></related>
	[UnsupportedOSPlatform ("tvos")]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[Protocol (Name = "UIActivityItemSource", WrapperType = typeof (UIActivityItemSourceWrapper))]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "GetPlaceholderData", Selector = "activityViewControllerPlaceholderItem:", ReturnType = typeof (NSObject), ParameterType = new Type [] { typeof (UIActivityViewController) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "GetItemForActivity", Selector = "activityViewController:itemForActivityType:", ReturnType = typeof (NSObject), ParameterType = new Type [] { typeof (UIActivityViewController), typeof (NSString) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "GetDataTypeIdentifierForActivity", Selector = "activityViewController:dataTypeIdentifierForActivityType:", ReturnType = typeof (string), ParameterType = new Type [] { typeof (UIActivityViewController), typeof (NSString) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "GetSubjectForActivity", Selector = "activityViewController:subjectForActivityType:", ReturnType = typeof (string), ParameterType = new Type [] { typeof (UIActivityViewController), typeof (NSString) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "GetThumbnailImageForActivity", Selector = "activityViewController:thumbnailImageForActivityType:suggestedSize:", ReturnType = typeof (UIImage), ParameterType = new Type [] { typeof (UIActivityViewController), typeof (NSString), typeof (CGSize) }, ParameterByRef = new bool [] { false, false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "GetLinkMetadata", Selector = "activityViewControllerLinkMetadata:", ReturnType = typeof (LinkPresentation.LPLinkMetadata), ParameterType = new Type [] { typeof (UIActivityViewController) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "GetShareRecipients", Selector = "activityViewControllerShareRecipients:", ReturnType = typeof (Intents.INPerson[]), ParameterType = new Type [] { typeof (UIActivityViewController) }, ParameterByRef = new bool [] { false })]
	public partial interface IUIActivityItemSource : INativeObject, IDisposable
	{
		/// <param name="activityViewController">To be added.</param><summary>Returns data that can be used as a placeholder for real data.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.RequiredMember]
		[Export ("activityViewControllerPlaceholderItem:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSObject GetPlaceholderData (UIActivityViewController activityViewController)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="activityViewController">To be added.</param><summary>Returns data that can be used as a placeholder for real data.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static NSObject _GetPlaceholderData (IUIActivityItemSource This, UIActivityViewController activityViewController)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var activityViewController__handle__ = activityViewController!.GetNonNullHandle (nameof (activityViewController));
			NSObject? ret;
			ret = Runtime.GetNSObject (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("activityViewControllerPlaceholderItem:"), activityViewController__handle__), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (activityViewController);
			return ret!;
		}
		/// <param name="activityViewController">To be added.</param><param name="activityType"><para>To be added.</para><para tool="nullallowed">This parameter can be <see langword="null" />.</para></param><summary>The data to be acted upon by the specified actitivtyType.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.RequiredMember]
		[Export ("activityViewController:itemForActivityType:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSObject? GetItemForActivity (UIActivityViewController activityViewController, NSString? activityType)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="activityViewController">To be added.</param><param name="activityType"><para>To be added.</para><para tool="nullallowed">This parameter can be <see langword="null" />.</para></param><summary>The data to be acted upon by the specified actitivtyType.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static NSObject? _GetItemForActivity (IUIActivityItemSource This, UIActivityViewController activityViewController, NSString? activityType)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var activityViewController__handle__ = activityViewController!.GetNonNullHandle (nameof (activityViewController));
			var activityType__handle__ = activityType.GetHandle ();
			NSObject? ret;
			ret = Runtime.GetNSObject (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("activityViewController:itemForActivityType:"), activityViewController__handle__, activityType__handle__), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (activityViewController);
			GC.KeepAlive (activityType);
			return ret!;
		}
		/// <param name="activityViewController">To be added.</param><param name="activityType"><para>To be added.</para><para tool="nullallowed">This parameter can be <see langword="null" />.</para></param><summary>If the specified  provides NSData, this method returns the Uniform Type Identifier (UTI) of the item.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("activityViewController:dataTypeIdentifierForActivityType:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string GetDataTypeIdentifierForActivity (UIActivityViewController activityViewController, NSString? activityType)
		{
			return _GetDataTypeIdentifierForActivity (this, activityViewController, activityType);
		}
		/// <param name="activityViewController">To be added.</param><param name="activityType"><para>To be added.</para><para tool="nullallowed">This parameter can be <see langword="null" />.</para></param><summary>If the specified  provides NSData, this method returns the Uniform Type Identifier (UTI) of the item.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static string _GetDataTypeIdentifierForActivity (IUIActivityItemSource This, UIActivityViewController activityViewController, NSString? activityType)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var activityViewController__handle__ = activityViewController!.GetNonNullHandle (nameof (activityViewController));
			var activityType__handle__ = activityType.GetHandle ();
			string? ret;
			ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("activityViewController:dataTypeIdentifierForActivityType:"), activityViewController__handle__, activityType__handle__), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (activityViewController);
			GC.KeepAlive (activityType);
			return ret!;
		}
		/// <param name="activityViewController">To be added.</param><param name="activityType"><para>To be added.</para><para tool="nullallowed">This parameter can be <see langword="null" />.</para></param><summary>Returns the subject for the specified  .</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("activityViewController:subjectForActivityType:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string GetSubjectForActivity (UIActivityViewController activityViewController, NSString? activityType)
		{
			return _GetSubjectForActivity (this, activityViewController, activityType);
		}
		/// <param name="activityViewController">To be added.</param><param name="activityType"><para>To be added.</para><para tool="nullallowed">This parameter can be <see langword="null" />.</para></param><summary>Returns the subject for the specified  .</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static string _GetSubjectForActivity (IUIActivityItemSource This, UIActivityViewController activityViewController, NSString? activityType)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var activityViewController__handle__ = activityViewController!.GetNonNullHandle (nameof (activityViewController));
			var activityType__handle__ = activityType.GetHandle ();
			string? ret;
			ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("activityViewController:subjectForActivityType:"), activityViewController__handle__, activityType__handle__), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (activityViewController);
			GC.KeepAlive (activityType);
			return ret!;
		}
		/// <param name="activityViewController">To be added.</param><param name="activityType"><para>To be added.</para><para tool="nullallowed">This parameter can be <see langword="null" />.</para></param><param name="suggestedSize">To be added.</param><summary>Returns the preview image for the specified .</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("activityViewController:thumbnailImageForActivityType:suggestedSize:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual UIImage GetThumbnailImageForActivity (UIActivityViewController activityViewController, NSString? activityType, CGSize suggestedSize)
		{
			return _GetThumbnailImageForActivity (this, activityViewController, activityType, suggestedSize);
		}
		/// <param name="activityViewController">To be added.</param><param name="activityType"><para>To be added.</para><para tool="nullallowed">This parameter can be <see langword="null" />.</para></param><param name="suggestedSize">To be added.</param><summary>Returns the preview image for the specified .</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static UIImage _GetThumbnailImageForActivity (IUIActivityItemSource This, UIActivityViewController activityViewController, NSString? activityType, CGSize suggestedSize)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var activityViewController__handle__ = activityViewController!.GetNonNullHandle (nameof (activityViewController));
			var activityType__handle__ = activityType.GetHandle ();
			UIImage? ret;
			ret =  Runtime.GetNSObject<UIImage> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_CGSize (This.Handle, Selector.GetHandle ("activityViewController:thumbnailImageForActivityType:suggestedSize:"), activityViewController__handle__, activityType__handle__, suggestedSize), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (activityViewController);
			GC.KeepAlive (activityType);
			return ret!;
		}
		[global::Foundation.OptionalMember]
		[Export ("activityViewControllerLinkMetadata:")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual global::LinkPresentation.LPLinkMetadata? GetLinkMetadata (UIActivityViewController activityViewController)
		{
			return _GetLinkMetadata (this, activityViewController);
		}
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static global::LinkPresentation.LPLinkMetadata? _GetLinkMetadata (IUIActivityItemSource This, UIActivityViewController activityViewController)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var activityViewController__handle__ = activityViewController!.GetNonNullHandle (nameof (activityViewController));
			global::LinkPresentation.LPLinkMetadata? ret;
			ret =  Runtime.GetNSObject<global::LinkPresentation.LPLinkMetadata> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("activityViewControllerLinkMetadata:"), activityViewController__handle__), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (activityViewController);
			return ret!;
		}
		[global::Foundation.OptionalMember]
		[Export ("activityViewControllerShareRecipients:")]
		[SupportedOSPlatform ("ios18.0")]
		[SupportedOSPlatform ("maccatalyst18.0")]
		[UnsupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual global::Intents.INPerson[] GetShareRecipients (UIActivityViewController activityViewController)
		{
			return _GetShareRecipients (this, activityViewController);
		}
		[SupportedOSPlatform ("ios18.0")]
		[SupportedOSPlatform ("maccatalyst18.0")]
		[UnsupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static global::Intents.INPerson[] _GetShareRecipients (IUIActivityItemSource This, UIActivityViewController activityViewController)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var activityViewController__handle__ = activityViewController!.GetNonNullHandle (nameof (activityViewController));
			global::Intents.INPerson[]? ret;
			ret = CFArray.ArrayFromHandle<global::Intents.INPerson>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("activityViewControllerShareRecipients:"), activityViewController__handle__), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (activityViewController);
			return ret!;
		}
		[DynamicDependencyAttribute ("GetDataTypeIdentifierForActivity(UIKit.UIActivityViewController,Foundation.NSString)")]
		[DynamicDependencyAttribute ("GetItemForActivity(UIKit.UIActivityViewController,Foundation.NSString)")]
		[DynamicDependencyAttribute ("GetLinkMetadata(UIKit.UIActivityViewController)")]
		[DynamicDependencyAttribute ("GetPlaceholderData(UIKit.UIActivityViewController)")]
		[DynamicDependencyAttribute ("GetShareRecipients(UIKit.UIActivityViewController)")]
		[DynamicDependencyAttribute ("GetSubjectForActivity(UIKit.UIActivityViewController,Foundation.NSString)")]
		[DynamicDependencyAttribute ("GetThumbnailImageForActivity(UIKit.UIActivityViewController,Foundation.NSString,CoreGraphics.CGSize)")]
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.Interfaces | DynamicallyAccessedMemberTypes.PublicConstructors, typeof (UIActivityItemSourceWrapper))]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static IUIActivityItemSource ()
		{
			GC.KeepAlive (null);
		}
	}
	#pragma warning restore CS1573
	#pragma warning disable CS1573
	/// <summary>Extension methods to the <see cref="IUIActivityItemSource" /> interface to support all the methods from the UIActivityItemSource protocol.</summary>
	/// <remarks>
	///   <para>The extension methods for <see cref="IUIActivityItemSource" /> interface allow developers to treat instances of the interface as having all the optional methods of the original UIActivityItemSource protocol. Since the interface only contains the required members, these extension methods allow developers to call the optional members of the protocol.</para>
	/// </remarks>
	public unsafe static partial class UIActivityItemSource_Extensions {
		/// <param name="activityViewController">To be added.</param><param name="activityType"><para>To be added.</para><para tool="nullallowed">This parameter can be <see langword="null" />.</para></param><summary>If the specified  provides NSData, this method returns the Uniform Type Identifier (UTI) of the item.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static string GetDataTypeIdentifierForActivity (this IUIActivityItemSource This, UIActivityViewController activityViewController, NSString? activityType)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var activityViewController__handle__ = activityViewController!.GetNonNullHandle (nameof (activityViewController));
			var activityType__handle__ = activityType.GetHandle ();
			string? ret;
			ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("activityViewController:dataTypeIdentifierForActivityType:"), activityViewController__handle__, activityType__handle__), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (activityViewController);
			GC.KeepAlive (activityType);
			return ret!;
		}
		/// <param name="activityViewController">To be added.</param><param name="activityType"><para>To be added.</para><para tool="nullallowed">This parameter can be <see langword="null" />.</para></param><summary>Returns the subject for the specified  .</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static string GetSubjectForActivity (this IUIActivityItemSource This, UIActivityViewController activityViewController, NSString? activityType)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var activityViewController__handle__ = activityViewController!.GetNonNullHandle (nameof (activityViewController));
			var activityType__handle__ = activityType.GetHandle ();
			string? ret;
			ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("activityViewController:subjectForActivityType:"), activityViewController__handle__, activityType__handle__), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (activityViewController);
			GC.KeepAlive (activityType);
			return ret!;
		}
		/// <param name="activityViewController">To be added.</param><param name="activityType"><para>To be added.</para><para tool="nullallowed">This parameter can be <see langword="null" />.</para></param><param name="suggestedSize">To be added.</param><summary>Returns the preview image for the specified .</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static UIImage GetThumbnailImageForActivity (this IUIActivityItemSource This, UIActivityViewController activityViewController, NSString? activityType, CGSize suggestedSize)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var activityViewController__handle__ = activityViewController!.GetNonNullHandle (nameof (activityViewController));
			var activityType__handle__ = activityType.GetHandle ();
			UIImage? ret;
			ret =  Runtime.GetNSObject<UIImage> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_CGSize (This.Handle, Selector.GetHandle ("activityViewController:thumbnailImageForActivityType:suggestedSize:"), activityViewController__handle__, activityType__handle__, suggestedSize), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (activityViewController);
			GC.KeepAlive (activityType);
			return ret!;
		}
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static global::LinkPresentation.LPLinkMetadata? GetLinkMetadata (this IUIActivityItemSource This, UIActivityViewController activityViewController)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var activityViewController__handle__ = activityViewController!.GetNonNullHandle (nameof (activityViewController));
			global::LinkPresentation.LPLinkMetadata? ret;
			ret =  Runtime.GetNSObject<global::LinkPresentation.LPLinkMetadata> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("activityViewControllerLinkMetadata:"), activityViewController__handle__), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (activityViewController);
			return ret!;
		}
		[SupportedOSPlatform ("ios18.0")]
		[SupportedOSPlatform ("maccatalyst18.0")]
		[UnsupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static global::Intents.INPerson[] GetShareRecipients (this IUIActivityItemSource This, UIActivityViewController activityViewController)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var activityViewController__handle__ = activityViewController!.GetNonNullHandle (nameof (activityViewController));
			global::Intents.INPerson[]? ret;
			ret = CFArray.ArrayFromHandle<global::Intents.INPerson>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("activityViewControllerShareRecipients:"), activityViewController__handle__), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (activityViewController);
			return ret!;
		}
	}
	#pragma warning restore CS1573
	internal unsafe sealed class UIActivityItemSourceWrapper : BaseWrapper, IUIActivityItemSource {
		public UIActivityItemSourceWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.PublicConstructors, typeof (UIActivityItemSourceWrapper))]
		static UIActivityItemSourceWrapper ()
		{
			GC.KeepAlive (null);
		}
		/// <param name="activityViewController">To be added.</param><summary>Returns data that can be used as a placeholder for real data.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("activityViewControllerPlaceholderItem:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public NSObject GetPlaceholderData (UIActivityViewController activityViewController)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var activityViewController__handle__ = activityViewController!.GetNonNullHandle (nameof (activityViewController));
			NSObject? ret;
			ret = Runtime.GetNSObject (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("activityViewControllerPlaceholderItem:"), activityViewController__handle__), false)!;
			GC.KeepAlive (activityViewController);
			return ret!;
		}
		/// <param name="activityViewController">To be added.</param><param name="activityType"><para>To be added.</para><para tool="nullallowed">This parameter can be <see langword="null" />.</para></param><summary>The data to be acted upon by the specified actitivtyType.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("activityViewController:itemForActivityType:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public NSObject? GetItemForActivity (UIActivityViewController activityViewController, NSString? activityType)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var activityViewController__handle__ = activityViewController!.GetNonNullHandle (nameof (activityViewController));
			var activityType__handle__ = activityType.GetHandle ();
			NSObject? ret;
			ret = Runtime.GetNSObject (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("activityViewController:itemForActivityType:"), activityViewController__handle__, activityType__handle__), false)!;
			GC.KeepAlive (activityViewController);
			GC.KeepAlive (activityType);
			return ret!;
		}
	}
}
namespace UIKit {
	/// <summary>Abstract class that, when implemented, provides data for use by a <see cref="T:UIKit.UIActivityViewController" /></summary><remarks><para>This class should not be used for complex processing, as it is called on the main UI thread. Applications that require complex processing of data before passing it to <see cref="T:UIKit.UIActivity" /> objects should implement <see cref="T:UIKit.UIActivityItemProvider" />.</para></remarks><related type="externalDocumentation" href="https://developer.apple.com/library/ios/documentation/UIKit/Reference/UIActivityItemSource_protocol/index.html">Apple documentation for <c>UIActivityItemSource</c></related>
	[Protocol()]
	[Register("Microsoft_iOS__UIKit_UIActivityItemSource", false)]
	[Model]
	[UnsupportedOSPlatform ("tvos")]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	public unsafe abstract partial class UIActivityItemSource : NSObject, IUIActivityItemSource {
		/// <summary>Creates a new <see cref="UIActivityItemSource" /> with default values.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		protected UIActivityItemSource () : base (NSObjectFlag.Empty)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			IsDirectBinding = false;
			unsafe {
			var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
			InitializeHandle (global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (&__objc_super__, global::ObjCRuntime.Selector.GetHandle ("init")), "init");
			GC.KeepAlive (this);
			}
		}

		/// <summary>Constructor to call on derived classes to skip initialization and merely allocate the object.</summary>
		/// <param name="t">Unused sentinel value, pass NSObjectFlag.Empty.</param>
		/// <remarks>
		///     <para>
		///         This constructor should be called by derived classes when they completely construct the object in managed code and merely want the runtime to allocate and initialize the <see cref="Foundation.NSObject" />.
		///         This is required to implement the two-step initialization process that Objective-C uses, the first step is to perform the object allocation, the second step is to initialize the object.
		///         When developers invoke this constructor, they take advantage of a direct path that goes all the way up to <see cref="Foundation.NSObject" /> to merely allocate the object's memory and bind the Objective-C and C# objects together.
		///         The actual initialization of the object is up to the developer.
		///     </para>
		///     <para>
		///         This constructor is typically used by the binding generator to allocate the object, but prevent the actual initialization to take place.
		///         Once the allocation has taken place, the constructor has to initialize the object.
		///         With constructors generated by the binding generator this means that it manually invokes one of the "init" methods to initialize the object.
		///     </para>
		///     <para>It is the developer's responsibility to completely initialize the object if they chain up using this constructor chain.</para>
		///     <para>
		///         In general, if the developer's constructor invokes the corresponding base implementation, then it should also call an Objective-C init method.
		///         If this is not the case, developers should instead chain to the proper constructor in their class.
		///     </para>
		///     <para>
		///         The argument value is ignored and merely ensures that the only code that is executed is the construction phase is the basic <see cref="Foundation.NSObject" /> allocation and runtime type registration.
		///         Typically the chaining would look like this:
		///     </para>
		///     <example>
		///             <code lang="csharp lang-csharp"><![CDATA[
		/// //
		/// // The NSObjectFlag constructor merely allocates the object and registers the C# class with the Objective-C runtime if necessary.
		/// // No actual initXxx method is invoked, that is done later in the constructor
		/// //
		/// // This is taken from the iOS SDK's source code for the UIView class:
		/// //
		/// [Export ("initWithFrame:")]
		/// public UIView (CGRect frame) : base (NSObjectFlag.Empty)
		/// {
		///     // Invoke the init method now.
		///     var initWithFrame = new Selector ("initWithFrame:").Handle;
		///     if (IsDirectBinding) {
		///         Handle = ObjCRuntime.Messaging.IntPtr_objc_msgSend_CGRect (this.Handle, initWithFrame, frame);
		///     } else {
		///         unsafe {
		///             var __objc_super__ = new ObjCRuntime.ObjCSuper (this);
		///             Handle = ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper_CGRect (&__objc_super__, initWithFrame, frame);
		///         }
		///         GC.KeepAlive (this);
		///     }
		/// }
		/// ]]></code>
		///     </example>
		/// </remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected UIActivityItemSource (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = false;
		}

		/// <summary>A constructor used when creating managed representations of unmanaged objects. Called by the runtime.</summary>
		/// <param name="handle">Pointer (handle) to the unmanaged object.</param>
		/// <remarks>
		///     <para>
		///         This constructor is invoked by the runtime infrastructure (<see cref="ObjCRuntime.Runtime.GetNSObject(System.IntPtr)" />) to create a new managed representation for a pointer to an unmanaged Objective-C object.
		///         Developers should not invoke this method directly, instead they should call <see cref="ObjCRuntime.Runtime.GetNSObject(System.IntPtr)" /> as it will prevent two instances of a managed object pointing to the same native object.
		///     </para>
		/// </remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal UIActivityItemSource (NativeHandle handle) : base (handle)
		{
			IsDirectBinding = false;
		}

		/// <param name="activityViewController">To be added.</param><param name="activityType"><para>To be added.</para><para tool="nullallowed">This parameter can be <see langword="null" />.</para></param><summary>If the specified  provides NSData, this method returns the Uniform Type Identifier (UTI) of the item.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("activityViewController:dataTypeIdentifierForActivityType:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string GetDataTypeIdentifierForActivity (UIActivityViewController activityViewController, NSString? activityType)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="activityViewController">To be added.</param><param name="activityType"><para>To be added.</para><para tool="nullallowed">This parameter can be <see langword="null" />.</para></param><summary>The data to be acted upon by the specified actitivtyType.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("activityViewController:itemForActivityType:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSObject? GetItemForActivity (UIActivityViewController activityViewController, NSString? activityType)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("activityViewControllerLinkMetadata:")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual global::LinkPresentation.LPLinkMetadata? GetLinkMetadata (UIActivityViewController activityViewController)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="activityViewController">To be added.</param><summary>Returns data that can be used as a placeholder for real data.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("activityViewControllerPlaceholderItem:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSObject GetPlaceholderData (UIActivityViewController activityViewController)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("activityViewControllerShareRecipients:")]
		[SupportedOSPlatform ("ios18.0")]
		[SupportedOSPlatform ("maccatalyst18.0")]
		[UnsupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual global::Intents.INPerson[] GetShareRecipients (UIActivityViewController activityViewController)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="activityViewController">To be added.</param><param name="activityType"><para>To be added.</para><para tool="nullallowed">This parameter can be <see langword="null" />.</para></param><summary>Returns the subject for the specified  .</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("activityViewController:subjectForActivityType:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string GetSubjectForActivity (UIActivityViewController activityViewController, NSString? activityType)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="activityViewController">To be added.</param><param name="activityType"><para>To be added.</para><para tool="nullallowed">This parameter can be <see langword="null" />.</para></param><param name="suggestedSize">To be added.</param><summary>Returns the preview image for the specified .</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("activityViewController:thumbnailImageForActivityType:suggestedSize:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual UIImage GetThumbnailImageForActivity (UIActivityViewController activityViewController, NSString? activityType, CGSize suggestedSize)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
	} /* class UIActivityItemSource */
}
