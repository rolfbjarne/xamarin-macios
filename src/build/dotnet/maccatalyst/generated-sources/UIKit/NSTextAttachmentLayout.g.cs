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
	#pragma warning disable CS1573
	/// <summary>This interface represents the Objective-C protocol <c>NSTextAttachmentLayout</c>.</summary>
	/// <remarks>
	///   <para>A class that implements this interface (and subclasses <see cref="NSObject" />) will be exported to Objective-C as implementing the Objective-C protocol this interface represents.</para>
	///   <para>A class may also implement members from this interface to implement members from the protocol.</para>
	/// </remarks>
	[SupportedOSPlatform ("tvos15.0")]
	[SupportedOSPlatform ("ios15.0")]
	[SupportedOSPlatform ("maccatalyst")]
	[Protocol (Name = "NSTextAttachmentLayout", WrapperType = typeof (NSTextAttachmentLayoutWrapper))]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "GetImageForBounds", Selector = "imageForBounds:attributes:location:textContainer:", ReturnType = typeof (UIImage), ParameterType = new Type [] { typeof (CGRect), typeof (global::Foundation.NSDictionary<NSString, NSObject>), typeof (INSTextLocation), typeof (NSTextContainer) }, ParameterByRef = new bool [] { false, false, false, false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "GetAttachmentBounds", Selector = "attachmentBoundsForAttributes:location:textContainer:proposedLineFragment:position:", ReturnType = typeof (CGRect), ParameterType = new Type [] { typeof (global::Foundation.NSDictionary<NSString, NSObject>), typeof (INSTextLocation), typeof (NSTextContainer), typeof (CGRect), typeof (CGPoint) }, ParameterByRef = new bool [] { false, false, false, false, false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "GetViewProvider", Selector = "viewProviderForParentView:location:textContainer:", ReturnType = typeof (NSTextAttachmentViewProvider), ParameterType = new Type [] { typeof (UIView), typeof (INSTextLocation), typeof (NSTextContainer) }, ParameterByRef = new bool [] { false, false, false })]
	public partial interface INSTextAttachmentLayout : INativeObject, IDisposable
	{
		[global::Foundation.RequiredMember]
		[Export ("imageForBounds:attributes:location:textContainer:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios15.0")]
		[SupportedOSPlatform ("tvos15.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual UIImage? GetImageForBounds (CGRect bounds, NSDictionary<NSString, NSObject> attributes, INSTextLocation location, NSTextContainer? textContainer)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios15.0")]
		[SupportedOSPlatform ("tvos15.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static UIImage? _GetImageForBounds (INSTextAttachmentLayout This, CGRect bounds, NSDictionary<NSString, NSObject> attributes, INSTextLocation location, NSTextContainer? textContainer)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var attributes__handle__ = attributes!.GetNonNullHandle (nameof (attributes));
			var location__handle__ = location!.GetNonNullHandle (nameof (location));
			var textContainer__handle__ = textContainer.GetHandle ();
			UIImage? ret;
			ret =  Runtime.GetNSObject<UIImage> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_CGRect_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("imageForBounds:attributes:location:textContainer:"), bounds, attributes__handle__, location__handle__, textContainer__handle__), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (attributes);
			GC.KeepAlive (location);
			GC.KeepAlive (textContainer);
			return ret!;
		}
		[global::Foundation.RequiredMember]
		[Export ("attachmentBoundsForAttributes:location:textContainer:proposedLineFragment:position:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios15.0")]
		[SupportedOSPlatform ("tvos15.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual CGRect GetAttachmentBounds (NSDictionary<NSString, NSObject> attributes, INSTextLocation location, NSTextContainer? textContainer, CGRect proposedLineFragment, CGPoint position)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios15.0")]
		[SupportedOSPlatform ("tvos15.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static CGRect _GetAttachmentBounds (INSTextAttachmentLayout This, NSDictionary<NSString, NSObject> attributes, INSTextLocation location, NSTextContainer? textContainer, CGRect proposedLineFragment, CGPoint position)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var attributes__handle__ = attributes!.GetNonNullHandle (nameof (attributes));
			var location__handle__ = location!.GetNonNullHandle (nameof (location));
			var textContainer__handle__ = textContainer.GetHandle ();
			CGRect ret;
			if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
				ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSend_NativeHandle_NativeHandle_NativeHandle_CGRect_CGPoint (This.Handle, Selector.GetHandle ("attachmentBoundsForAttributes:location:textContainer:proposedLineFragment:position:"), attributes__handle__, location__handle__, textContainer__handle__, proposedLineFragment, position);
				GC.KeepAlive (This);
			} else {
				ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSend_stret_NativeHandle_NativeHandle_NativeHandle_CGRect_CGPoint (This.Handle, Selector.GetHandle ("attachmentBoundsForAttributes:location:textContainer:proposedLineFragment:position:"), attributes__handle__, location__handle__, textContainer__handle__, proposedLineFragment, position);
				GC.KeepAlive (This);
			}
			GC.KeepAlive (attributes);
			GC.KeepAlive (location);
			GC.KeepAlive (textContainer);
			return ret!;
		}
		[global::Foundation.RequiredMember]
		[Export ("viewProviderForParentView:location:textContainer:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios15.0")]
		[SupportedOSPlatform ("tvos15.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSTextAttachmentViewProvider? GetViewProvider (UIView? parentView, INSTextLocation location, NSTextContainer? textContainer)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios15.0")]
		[SupportedOSPlatform ("tvos15.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static NSTextAttachmentViewProvider? _GetViewProvider (INSTextAttachmentLayout This, UIView? parentView, INSTextLocation location, NSTextContainer? textContainer)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var parentView__handle__ = parentView.GetHandle ();
			var location__handle__ = location!.GetNonNullHandle (nameof (location));
			var textContainer__handle__ = textContainer.GetHandle ();
			NSTextAttachmentViewProvider? ret;
			ret =  Runtime.GetNSObject<NSTextAttachmentViewProvider> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("viewProviderForParentView:location:textContainer:"), parentView__handle__, location__handle__, textContainer__handle__), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (parentView);
			GC.KeepAlive (location);
			GC.KeepAlive (textContainer);
			return ret!;
		}
		[DynamicDependencyAttribute ("GetAttachmentBounds(Foundation.NSDictionary{Foundation.NSString,Foundation.NSObject},UIKit.INSTextLocation,UIKit.NSTextContainer,CoreGraphics.CGRect,CoreGraphics.CGPoint)")]
		[DynamicDependencyAttribute ("GetImageForBounds(CoreGraphics.CGRect,Foundation.NSDictionary{Foundation.NSString,Foundation.NSObject},UIKit.INSTextLocation,UIKit.NSTextContainer)")]
		[DynamicDependencyAttribute ("GetViewProvider(UIKit.UIView,UIKit.INSTextLocation,UIKit.NSTextContainer)")]
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.Interfaces | DynamicallyAccessedMemberTypes.PublicConstructors, typeof (NSTextAttachmentLayoutWrapper))]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static INSTextAttachmentLayout ()
		{
			GC.KeepAlive (null);
		}
	}
	#pragma warning restore CS1573
	internal unsafe sealed class NSTextAttachmentLayoutWrapper : BaseWrapper, INSTextAttachmentLayout {
		public NSTextAttachmentLayoutWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.PublicConstructors, typeof (NSTextAttachmentLayoutWrapper))]
		static NSTextAttachmentLayoutWrapper ()
		{
			GC.KeepAlive (null);
		}
		[Export ("imageForBounds:attributes:location:textContainer:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public UIImage? GetImageForBounds (CGRect bounds, NSDictionary<NSString, NSObject> attributes, INSTextLocation location, NSTextContainer? textContainer)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var attributes__handle__ = attributes!.GetNonNullHandle (nameof (attributes));
			var location__handle__ = location!.GetNonNullHandle (nameof (location));
			var textContainer__handle__ = textContainer.GetHandle ();
			UIImage? ret;
			ret =  Runtime.GetNSObject<UIImage> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_CGRect_NativeHandle_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("imageForBounds:attributes:location:textContainer:"), bounds, attributes__handle__, location__handle__, textContainer__handle__), false)!;
			GC.KeepAlive (attributes);
			GC.KeepAlive (location);
			GC.KeepAlive (textContainer);
			return ret!;
		}
		[Export ("attachmentBoundsForAttributes:location:textContainer:proposedLineFragment:position:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public CGRect GetAttachmentBounds (NSDictionary<NSString, NSObject> attributes, INSTextLocation location, NSTextContainer? textContainer, CGRect proposedLineFragment, CGPoint position)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var attributes__handle__ = attributes!.GetNonNullHandle (nameof (attributes));
			var location__handle__ = location!.GetNonNullHandle (nameof (location));
			var textContainer__handle__ = textContainer.GetHandle ();
			CGRect ret;
			if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
				ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSend_NativeHandle_NativeHandle_NativeHandle_CGRect_CGPoint (this.Handle, Selector.GetHandle ("attachmentBoundsForAttributes:location:textContainer:proposedLineFragment:position:"), attributes__handle__, location__handle__, textContainer__handle__, proposedLineFragment, position);
			} else {
				ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSend_stret_NativeHandle_NativeHandle_NativeHandle_CGRect_CGPoint (this.Handle, Selector.GetHandle ("attachmentBoundsForAttributes:location:textContainer:proposedLineFragment:position:"), attributes__handle__, location__handle__, textContainer__handle__, proposedLineFragment, position);
			}
			GC.KeepAlive (attributes);
			GC.KeepAlive (location);
			GC.KeepAlive (textContainer);
			return ret!;
		}
		[Export ("viewProviderForParentView:location:textContainer:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public NSTextAttachmentViewProvider? GetViewProvider (UIView? parentView, INSTextLocation location, NSTextContainer? textContainer)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var parentView__handle__ = parentView.GetHandle ();
			var location__handle__ = location!.GetNonNullHandle (nameof (location));
			var textContainer__handle__ = textContainer.GetHandle ();
			NSTextAttachmentViewProvider? ret;
			ret =  Runtime.GetNSObject<NSTextAttachmentViewProvider> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("viewProviderForParentView:location:textContainer:"), parentView__handle__, location__handle__, textContainer__handle__), false)!;
			GC.KeepAlive (parentView);
			GC.KeepAlive (location);
			GC.KeepAlive (textContainer);
			return ret!;
		}
	}
}
