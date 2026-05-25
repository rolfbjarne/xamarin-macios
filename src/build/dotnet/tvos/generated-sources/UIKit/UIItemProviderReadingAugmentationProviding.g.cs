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
namespace UIKit {
	#pragma warning disable CS1573
	/// <summary>This interface represents the Objective-C protocol <c>UIItemProviderReadingAugmentationProviding</c>.</summary>
	/// <remarks>
	///   <para>A class that implements this interface (and subclasses <see cref="NSObject" />) will be exported to Objective-C as implementing the Objective-C protocol this interface represents.</para>
	///   <para>A class may also implement members from this interface to implement members from the protocol.</para>
	/// </remarks>
	[SupportedOSPlatform ("tvos17.4")]
	[SupportedOSPlatform ("ios17.4")]
	[SupportedOSPlatform ("maccatalyst17.4")]
	[Protocol (Name = "UIItemProviderReadingAugmentationProviding", WrapperType = typeof (UIItemProviderReadingAugmentationProvidingWrapper), BackwardsCompatibleCodeGeneration = false)]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = true, Name = "GetTypeIdentifier", Selector = "objectWithItemProviderData:typeIdentifier:requestedClass:error:", ReturnType = typeof (NSObject), ParameterType = new Type [] { typeof (NSData), typeof (string), typeof (Class), typeof (NSError) }, ParameterByRef = new bool [] { false, false, false, true })]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = true, Name = "AdditionalLeadingReadableTypeIdentifiersForItemProvider", Selector = "additionalLeadingReadableTypeIdentifiersForItemProvider", PropertyType = typeof (String[]), GetterSelector = "additionalLeadingReadableTypeIdentifiersForItemProvider", ArgumentSemantic = ArgumentSemantic.Copy)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = true, Name = "AdditionalTrailingReadableTypeIdentifiersForItemProvider", Selector = "additionalTrailingReadableTypeIdentifiersForItemProvider", PropertyType = typeof (String[]), GetterSelector = "additionalTrailingReadableTypeIdentifiersForItemProvider", ArgumentSemantic = ArgumentSemantic.Copy)]
	public partial interface IUIItemProviderReadingAugmentationProviding : INativeObject, IDisposable
	{
		[global::Foundation.RequiredMember]
		[Export ("objectWithItemProviderData:typeIdentifier:requestedClass:error:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static NSObject? GetTypeIdentifier<T> (NSData data, string typeIdentifier, Class requestedClass, out NSError? outError) where T: NSObject, IUIItemProviderReadingAugmentationProviding
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var data__handle__ = data!.GetNonNullHandle (nameof (data));
			if (typeIdentifier is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (typeIdentifier));
			var requestedClass__handle__ = requestedClass!.GetNonNullHandle (nameof (requestedClass));
			var class_ptr = Class.GetHandle (typeof (T));
			NativeHandle outErrorValue = IntPtr.Zero;
			var nstypeIdentifier = CFString.CreateNative (typeIdentifier);
			NSObject? ret;
			ret = Runtime.GetNSObject (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle_ref_NativeHandle (class_ptr, Selector.GetHandle ("objectWithItemProviderData:typeIdentifier:requestedClass:error:"), data__handle__, nstypeIdentifier, requestedClass.Handle, &outErrorValue), false)!;
			GC.KeepAlive (data);
			GC.KeepAlive (requestedClass);
			CFString.ReleaseNative (nstypeIdentifier);
			outError = Runtime.GetNSObject<NSError> (outErrorValue)!;
			return ret!;
		}
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.Interfaces | DynamicallyAccessedMemberTypes.PublicConstructors, typeof (UIItemProviderReadingAugmentationProvidingWrapper))]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static IUIItemProviderReadingAugmentationProviding ()
		{
			GC.KeepAlive (null);
		}
		[global::Foundation.RequiredMember]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static string[] GetAdditionalLeadingReadableTypeIdentifiersForItemProvider<T> () where T: NSObject, IUIItemProviderReadingAugmentationProviding
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var class_ptr = Class.GetHandle (typeof (T));
			string[] ret;
			ret = CFArray.StringArrayFromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (class_ptr, Selector.GetHandle ("additionalLeadingReadableTypeIdentifiersForItemProvider")), false)!;
			return ret;
		}
		[global::Foundation.RequiredMember]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static string[] GetAdditionalTrailingReadableTypeIdentifiersForItemProvider<T> () where T: NSObject, IUIItemProviderReadingAugmentationProviding
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var class_ptr = Class.GetHandle (typeof (T));
			string[] ret;
			ret = CFArray.StringArrayFromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (class_ptr, Selector.GetHandle ("additionalTrailingReadableTypeIdentifiersForItemProvider")), false)!;
			return ret;
		}
	}
	#pragma warning restore CS1573
	internal unsafe sealed class UIItemProviderReadingAugmentationProvidingWrapper : BaseWrapper, IUIItemProviderReadingAugmentationProviding {
		public UIItemProviderReadingAugmentationProvidingWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.PublicConstructors, typeof (UIItemProviderReadingAugmentationProvidingWrapper))]
		static UIItemProviderReadingAugmentationProvidingWrapper ()
		{
			GC.KeepAlive (null);
		}
	}
}
