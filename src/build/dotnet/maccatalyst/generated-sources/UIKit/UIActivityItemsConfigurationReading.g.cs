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
	/// <summary>This interface represents the Objective-C protocol <c>UIActivityItemsConfigurationReading</c>.</summary>
	/// <remarks>
	///   <para>A class that implements this interface (and subclasses <see cref="NSObject" />) will be exported to Objective-C as implementing the Objective-C protocol this interface represents.</para>
	///   <para>A class may also implement members from this interface to implement members from the protocol.</para>
	/// </remarks>
	[UnsupportedOSPlatform ("tvos")]
	[SupportedOSPlatform ("ios13.0")]
	[SupportedOSPlatform ("maccatalyst")]
	[Protocol (Name = "UIActivityItemsConfigurationReading", WrapperType = typeof (UIActivityItemsConfigurationReadingWrapper))]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "GetActivityItemsConfigurationSupportsInteraction", Selector = "activityItemsConfigurationSupportsInteraction:", ReturnType = typeof (bool), ParameterType = new Type [] { typeof (NSString) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "GetActivityItemsConfigurationMetadata", Selector = "activityItemsConfigurationMetadataForKey:", ReturnType = typeof (NSObject), ParameterType = new Type [] { typeof (NSString) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "GetActivityItemsConfigurationMetadata", Selector = "activityItemsConfigurationMetadataForItemAtIndex:key:", ReturnType = typeof (NSObject), ParameterType = new Type [] { typeof (IntPtr), typeof (NSString) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "GetActivityItemsConfigurationPreview", Selector = "activityItemsConfigurationPreviewForItemAtIndex:intent:suggestedSize:", ReturnType = typeof (NSItemProvider), ParameterType = new Type [] { typeof (IntPtr), typeof (NSString), typeof (CGSize) }, ParameterByRef = new bool [] { false, false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "GetApplicationActivitiesForActivityItemsConfiguration", Selector = "applicationActivitiesForActivityItemsConfiguration", ReturnType = typeof (UIActivity[]))]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "ItemProvidersForActivityItemsConfiguration", Selector = "itemProvidersForActivityItemsConfiguration", PropertyType = typeof (NSItemProvider[]), GetterSelector = "itemProvidersForActivityItemsConfiguration", ArgumentSemantic = ArgumentSemantic.Copy)]
	public partial interface IUIActivityItemsConfigurationReading : INativeObject, IDisposable
	{
		[global::Foundation.OptionalMember]
		[Export ("activityItemsConfigurationSupportsInteraction:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool GetActivityItemsConfigurationSupportsInteraction (NSString activityItemsConfigurationInteraction)
		{
			return _GetActivityItemsConfigurationSupportsInteraction (this, activityItemsConfigurationInteraction);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static bool _GetActivityItemsConfigurationSupportsInteraction (IUIActivityItemsConfigurationReading This, NSString activityItemsConfigurationInteraction)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var activityItemsConfigurationInteraction__handle__ = activityItemsConfigurationInteraction!.GetNonNullHandle (nameof (activityItemsConfigurationInteraction));
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("activityItemsConfigurationSupportsInteraction:"), activityItemsConfigurationInteraction__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (activityItemsConfigurationInteraction);
			return ret != 0;
		}
		[global::Foundation.OptionalMember]
		[Export ("activityItemsConfigurationMetadataForKey:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSObject? GetActivityItemsConfigurationMetadata (NSString activityItemsConfigurationMetadataKey)
		{
			return _GetActivityItemsConfigurationMetadata (this, activityItemsConfigurationMetadataKey);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static NSObject? _GetActivityItemsConfigurationMetadata (IUIActivityItemsConfigurationReading This, NSString activityItemsConfigurationMetadataKey)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var activityItemsConfigurationMetadataKey__handle__ = activityItemsConfigurationMetadataKey!.GetNonNullHandle (nameof (activityItemsConfigurationMetadataKey));
			NSObject? ret;
			ret = Runtime.GetNSObject (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("activityItemsConfigurationMetadataForKey:"), activityItemsConfigurationMetadataKey__handle__), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (activityItemsConfigurationMetadataKey);
			return ret!;
		}
		[global::Foundation.OptionalMember]
		[Export ("activityItemsConfigurationMetadataForItemAtIndex:key:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSObject? GetActivityItemsConfigurationMetadata (nint index, NSString activityItemsConfigurationMetadataKey)
		{
			return _GetActivityItemsConfigurationMetadata (this, index, activityItemsConfigurationMetadataKey);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static NSObject? _GetActivityItemsConfigurationMetadata (IUIActivityItemsConfigurationReading This, nint index, NSString activityItemsConfigurationMetadataKey)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var activityItemsConfigurationMetadataKey__handle__ = activityItemsConfigurationMetadataKey!.GetNonNullHandle (nameof (activityItemsConfigurationMetadataKey));
			NSObject? ret;
			ret = Runtime.GetNSObject (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_IntPtr_NativeHandle (This.Handle, Selector.GetHandle ("activityItemsConfigurationMetadataForItemAtIndex:key:"), index, activityItemsConfigurationMetadataKey__handle__), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (activityItemsConfigurationMetadataKey);
			return ret!;
		}
		[global::Foundation.OptionalMember]
		[Export ("activityItemsConfigurationPreviewForItemAtIndex:intent:suggestedSize:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSItemProvider? GetActivityItemsConfigurationPreview (nint index, NSString activityItemsConfigurationPreviewIntent, CGSize suggestedSize)
		{
			return _GetActivityItemsConfigurationPreview (this, index, activityItemsConfigurationPreviewIntent, suggestedSize);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static NSItemProvider? _GetActivityItemsConfigurationPreview (IUIActivityItemsConfigurationReading This, nint index, NSString activityItemsConfigurationPreviewIntent, CGSize suggestedSize)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var activityItemsConfigurationPreviewIntent__handle__ = activityItemsConfigurationPreviewIntent!.GetNonNullHandle (nameof (activityItemsConfigurationPreviewIntent));
			NSItemProvider? ret;
			ret =  Runtime.GetNSObject<NSItemProvider> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_IntPtr_NativeHandle_CGSize (This.Handle, Selector.GetHandle ("activityItemsConfigurationPreviewForItemAtIndex:intent:suggestedSize:"), index, activityItemsConfigurationPreviewIntent__handle__, suggestedSize), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (activityItemsConfigurationPreviewIntent);
			return ret!;
		}
		[global::Foundation.OptionalMember]
		[Export ("applicationActivitiesForActivityItemsConfiguration")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual UIActivity[]? GetApplicationActivitiesForActivityItemsConfiguration ()
		{
			return _GetApplicationActivitiesForActivityItemsConfiguration (this);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static UIActivity[]? _GetApplicationActivitiesForActivityItemsConfiguration (IUIActivityItemsConfigurationReading This)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			UIActivity[] ret;
			ret = CFArray.ArrayFromHandle<UIActivity>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("applicationActivitiesForActivityItemsConfiguration")), false)!;
			GC.KeepAlive (This);
			return ret;
		}
		[DynamicDependencyAttribute ("GetActivityItemsConfigurationMetadata(Foundation.NSString)")]
		[DynamicDependencyAttribute ("GetActivityItemsConfigurationMetadata(System.IntPtr,Foundation.NSString)")]
		[DynamicDependencyAttribute ("GetActivityItemsConfigurationPreview(System.IntPtr,Foundation.NSString,CoreGraphics.CGSize)")]
		[DynamicDependencyAttribute ("GetActivityItemsConfigurationSupportsInteraction(Foundation.NSString)")]
		[DynamicDependencyAttribute ("GetApplicationActivitiesForActivityItemsConfiguration()")]
		[DynamicDependencyAttribute ("ItemProvidersForActivityItemsConfiguration")]
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.Interfaces | DynamicallyAccessedMemberTypes.PublicConstructors, typeof (UIActivityItemsConfigurationReadingWrapper))]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static IUIActivityItemsConfigurationReading ()
		{
			GC.KeepAlive (null);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual NSItemProvider[] ItemProvidersForActivityItemsConfiguration {
			[Export ("itemProvidersForActivityItemsConfiguration", ArgumentSemantic.Copy)]
			get {
				return _GetItemProvidersForActivityItemsConfiguration (this);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static NSItemProvider[] _GetItemProvidersForActivityItemsConfiguration (IUIActivityItemsConfigurationReading This)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			NSItemProvider[] ret;
			ret = CFArray.ArrayFromHandle<NSItemProvider>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("itemProvidersForActivityItemsConfiguration")), false)!;
			GC.KeepAlive (This);
			return ret;
		}
	}
	#pragma warning restore CS1573
	#pragma warning disable CS1573
	/// <summary>Extension methods to the <see cref="IUIActivityItemsConfigurationReading" /> interface to support all the methods from the UIActivityItemsConfigurationReading protocol.</summary>
	/// <remarks>
	///   <para>The extension methods for <see cref="IUIActivityItemsConfigurationReading" /> interface allow developers to treat instances of the interface as having all the optional methods of the original UIActivityItemsConfigurationReading protocol. Since the interface only contains the required members, these extension methods allow developers to call the optional members of the protocol.</para>
	/// </remarks>
	public unsafe static partial class UIActivityItemsConfigurationReading_Extensions {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool GetActivityItemsConfigurationSupportsInteraction (this IUIActivityItemsConfigurationReading This, NSString activityItemsConfigurationInteraction)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var activityItemsConfigurationInteraction__handle__ = activityItemsConfigurationInteraction!.GetNonNullHandle (nameof (activityItemsConfigurationInteraction));
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("activityItemsConfigurationSupportsInteraction:"), activityItemsConfigurationInteraction__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (activityItemsConfigurationInteraction);
			return ret != 0;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSObject? GetActivityItemsConfigurationMetadata (this IUIActivityItemsConfigurationReading This, NSString activityItemsConfigurationMetadataKey)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var activityItemsConfigurationMetadataKey__handle__ = activityItemsConfigurationMetadataKey!.GetNonNullHandle (nameof (activityItemsConfigurationMetadataKey));
			NSObject? ret;
			ret = Runtime.GetNSObject (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("activityItemsConfigurationMetadataForKey:"), activityItemsConfigurationMetadataKey__handle__), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (activityItemsConfigurationMetadataKey);
			return ret!;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSObject? GetActivityItemsConfigurationMetadata (this IUIActivityItemsConfigurationReading This, nint index, NSString activityItemsConfigurationMetadataKey)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var activityItemsConfigurationMetadataKey__handle__ = activityItemsConfigurationMetadataKey!.GetNonNullHandle (nameof (activityItemsConfigurationMetadataKey));
			NSObject? ret;
			ret = Runtime.GetNSObject (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_IntPtr_NativeHandle (This.Handle, Selector.GetHandle ("activityItemsConfigurationMetadataForItemAtIndex:key:"), index, activityItemsConfigurationMetadataKey__handle__), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (activityItemsConfigurationMetadataKey);
			return ret!;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSItemProvider? GetActivityItemsConfigurationPreview (this IUIActivityItemsConfigurationReading This, nint index, NSString activityItemsConfigurationPreviewIntent, CGSize suggestedSize)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var activityItemsConfigurationPreviewIntent__handle__ = activityItemsConfigurationPreviewIntent!.GetNonNullHandle (nameof (activityItemsConfigurationPreviewIntent));
			NSItemProvider? ret;
			ret =  Runtime.GetNSObject<NSItemProvider> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_IntPtr_NativeHandle_CGSize (This.Handle, Selector.GetHandle ("activityItemsConfigurationPreviewForItemAtIndex:intent:suggestedSize:"), index, activityItemsConfigurationPreviewIntent__handle__, suggestedSize), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (activityItemsConfigurationPreviewIntent);
			return ret!;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static UIActivity[]? GetApplicationActivitiesForActivityItemsConfiguration (this IUIActivityItemsConfigurationReading This)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			UIActivity[] ret;
			ret = CFArray.ArrayFromHandle<UIActivity>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("applicationActivitiesForActivityItemsConfiguration")), false)!;
			GC.KeepAlive (This);
			return ret;
		}
	}
	#pragma warning restore CS1573
	internal unsafe sealed class UIActivityItemsConfigurationReadingWrapper : BaseWrapper, IUIActivityItemsConfigurationReading {
		public UIActivityItemsConfigurationReadingWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.PublicConstructors, typeof (UIActivityItemsConfigurationReadingWrapper))]
		static UIActivityItemsConfigurationReadingWrapper ()
		{
			GC.KeepAlive (null);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public NSItemProvider[] ItemProvidersForActivityItemsConfiguration {
			[Export ("itemProvidersForActivityItemsConfiguration", ArgumentSemantic.Copy)]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				NSItemProvider[] ret;
				ret = CFArray.ArrayFromHandle<NSItemProvider>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("itemProvidersForActivityItemsConfiguration")), false)!;
				return ret;
			}
		}
	}
}
