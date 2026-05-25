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
namespace IntentsUI {
	#pragma warning disable CS1573
	/// <summary>This interface represents the Objective-C protocol <c>INUIHostedViewSiriProviding</c>.</summary>
	/// <remarks>
	///   <para>A class that implements this interface (and subclasses <see cref="NSObject" />) will be exported to Objective-C as implementing the Objective-C protocol this interface represents.</para>
	///   <para>A class may also implement members from this interface to implement members from the protocol.</para>
	/// </remarks>
	[UnsupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[Protocol (Name = "INUIHostedViewSiriProviding", WrapperType = typeof (INUIHostedViewSiriProvidingWrapper))]
	[ProtocolMember (IsRequired = false, IsProperty = true, IsStatic = false, Name = "DisplaysMap", Selector = "displaysMap", PropertyType = typeof (bool), GetterSelector = "displaysMap", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = false, IsProperty = true, IsStatic = false, Name = "DisplaysMessage", Selector = "displaysMessage", PropertyType = typeof (bool), GetterSelector = "displaysMessage", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = false, IsProperty = true, IsStatic = false, Name = "DisplaysPaymentTransaction", Selector = "displaysPaymentTransaction", PropertyType = typeof (bool), GetterSelector = "displaysPaymentTransaction", ArgumentSemantic = ArgumentSemantic.None)]
	public partial interface IINUIHostedViewSiriProviding : INativeObject, IDisposable
	{
		[DynamicDependencyAttribute ("DisplaysMap")]
		[DynamicDependencyAttribute ("DisplaysMessage")]
		[DynamicDependencyAttribute ("DisplaysPaymentTransaction")]
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.Interfaces | DynamicallyAccessedMemberTypes.PublicConstructors, typeof (INUIHostedViewSiriProvidingWrapper))]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static IINUIHostedViewSiriProviding ()
		{
			GC.KeepAlive (null);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.OptionalMember]
		public virtual bool DisplaysMap {
			[Export ("displaysMap")]
			get {
				return _GetDisplaysMap (this);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static bool _GetDisplaysMap (IINUIHostedViewSiriProviding This)
		{
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (This.Handle, Selector.GetHandle ("displaysMap"));
			GC.KeepAlive (This);
			return ret != 0;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.OptionalMember]
		public virtual bool DisplaysMessage {
			[Export ("displaysMessage")]
			get {
				return _GetDisplaysMessage (this);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static bool _GetDisplaysMessage (IINUIHostedViewSiriProviding This)
		{
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (This.Handle, Selector.GetHandle ("displaysMessage"));
			GC.KeepAlive (This);
			return ret != 0;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.OptionalMember]
		public virtual bool DisplaysPaymentTransaction {
			[Export ("displaysPaymentTransaction")]
			get {
				return _GetDisplaysPaymentTransaction (this);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static bool _GetDisplaysPaymentTransaction (IINUIHostedViewSiriProviding This)
		{
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (This.Handle, Selector.GetHandle ("displaysPaymentTransaction"));
			GC.KeepAlive (This);
			return ret != 0;
		}
	}
	#pragma warning restore CS1573
	#pragma warning disable CS1573
	/// <summary>Extension methods to the <see cref="IINUIHostedViewSiriProviding" /> interface to support all the methods from the INUIHostedViewSiriProviding protocol.</summary>
	/// <remarks>
	///   <para>The extension methods for <see cref="IINUIHostedViewSiriProviding" /> interface allow developers to treat instances of the interface as having all the optional methods of the original INUIHostedViewSiriProviding protocol. Since the interface only contains the required members, these extension methods allow developers to call the optional members of the protocol.</para>
	/// </remarks>
	public unsafe static partial class INUIHostedViewSiriProviding_Extensions {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool GetDisplaysMap (this IINUIHostedViewSiriProviding This)
		{
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (This.Handle, Selector.GetHandle ("displaysMap"));
			GC.KeepAlive (This);
			return ret != 0;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool GetDisplaysMessage (this IINUIHostedViewSiriProviding This)
		{
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (This.Handle, Selector.GetHandle ("displaysMessage"));
			GC.KeepAlive (This);
			return ret != 0;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool GetDisplaysPaymentTransaction (this IINUIHostedViewSiriProviding This)
		{
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (This.Handle, Selector.GetHandle ("displaysPaymentTransaction"));
			GC.KeepAlive (This);
			return ret != 0;
		}
	}
	#pragma warning restore CS1573
	internal unsafe sealed class INUIHostedViewSiriProvidingWrapper : BaseWrapper, IINUIHostedViewSiriProviding {
		public INUIHostedViewSiriProvidingWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.PublicConstructors, typeof (INUIHostedViewSiriProvidingWrapper))]
		static INUIHostedViewSiriProvidingWrapper ()
		{
			GC.KeepAlive (null);
		}
	}
}
