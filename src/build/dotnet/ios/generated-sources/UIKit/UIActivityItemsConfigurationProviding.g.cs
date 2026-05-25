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
	/// <summary>This interface represents the Objective-C protocol <c>UIActivityItemsConfigurationProviding</c>.</summary>
	/// <remarks>
	///   <para>A class that implements this interface (and subclasses <see cref="NSObject" />) will be exported to Objective-C as implementing the Objective-C protocol this interface represents.</para>
	///   <para>A class may also implement members from this interface to implement members from the protocol.</para>
	/// </remarks>
	[UnsupportedOSPlatform ("tvos")]
	[SupportedOSPlatform ("ios15.0")]
	[SupportedOSPlatform ("maccatalyst")]
	[Protocol (Name = "UIActivityItemsConfigurationProviding", WrapperType = typeof (UIActivityItemsConfigurationProvidingWrapper))]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "ActivityItemsConfiguration", Selector = "activityItemsConfiguration", PropertyType = typeof (IUIActivityItemsConfigurationReading), GetterSelector = "activityItemsConfiguration", ArgumentSemantic = ArgumentSemantic.Retain)]
	public partial interface IUIActivityItemsConfigurationProviding : INativeObject, IDisposable
	{
		[DynamicDependencyAttribute ("ActivityItemsConfiguration")]
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.Interfaces | DynamicallyAccessedMemberTypes.PublicConstructors, typeof (UIActivityItemsConfigurationProvidingWrapper))]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static IUIActivityItemsConfigurationProviding ()
		{
			GC.KeepAlive (null);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual IUIActivityItemsConfigurationReading? ActivityItemsConfiguration {
			[Export ("activityItemsConfiguration", ArgumentSemantic.Retain)]
			get {
				return _GetActivityItemsConfiguration (this);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static IUIActivityItemsConfigurationReading _GetActivityItemsConfiguration (IUIActivityItemsConfigurationProviding This)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			IUIActivityItemsConfigurationReading ret;
			ret =  Runtime.GetINativeObject<IUIActivityItemsConfigurationReading> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("activityItemsConfiguration")), false)!;
			GC.KeepAlive (This);
			return ret;
		}
	}
	#pragma warning restore CS1573
	internal unsafe sealed class UIActivityItemsConfigurationProvidingWrapper : BaseWrapper, IUIActivityItemsConfigurationProviding {
		public UIActivityItemsConfigurationProvidingWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.PublicConstructors, typeof (UIActivityItemsConfigurationProvidingWrapper))]
		static UIActivityItemsConfigurationProvidingWrapper ()
		{
			GC.KeepAlive (null);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public IUIActivityItemsConfigurationReading? ActivityItemsConfiguration {
			[Export ("activityItemsConfiguration", ArgumentSemantic.Retain)]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				IUIActivityItemsConfigurationReading ret;
				ret =  Runtime.GetINativeObject<IUIActivityItemsConfigurationReading> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("activityItemsConfiguration")), false)!;
				return ret;
			}
		}
	}
}
