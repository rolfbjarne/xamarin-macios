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
namespace GameController {
	#pragma warning disable CS1573
	/// <summary>This interface represents the Objective-C protocol <c>GCButtonElement</c>.</summary>
	/// <remarks>
	///   <para>A class that implements this interface (and subclasses <see cref="NSObject" />) will be exported to Objective-C as implementing the Objective-C protocol this interface represents.</para>
	///   <para>A class may also implement members from this interface to implement members from the protocol.</para>
	/// </remarks>
	[SupportedOSPlatform ("macos13.0")]
	[SupportedOSPlatform ("ios16.0")]
	[SupportedOSPlatform ("maccatalyst16.0")]
	[SupportedOSPlatform ("tvos16.0")]
	[Protocol (Name = "GCButtonElement", WrapperType = typeof (GCButtonElementWrapper))]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "PressedInput", Selector = "pressedInput", PropertyType = typeof (NSObject), GetterSelector = "pressedInput", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "TouchedInput", Selector = "touchedInput", PropertyType = typeof (GameController.IGCTouchedStateInput), GetterSelector = "touchedInput", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "ForceInput", Selector = "forceInput", PropertyType = typeof (GameController.IGCLinearInput), GetterSelector = "forceInput", ArgumentSemantic = ArgumentSemantic.None)]
	public partial interface IGCButtonElement : INativeObject, IDisposable, 
		GameController.IGCPhysicalInputElement
	{
		[DynamicDependencyAttribute ("ForceInput")]
		[DynamicDependencyAttribute ("PressedInput")]
		[DynamicDependencyAttribute ("TouchedInput")]
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.Interfaces | DynamicallyAccessedMemberTypes.PublicConstructors, typeof (GCButtonElementWrapper))]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static IGCButtonElement ()
		{
			GC.KeepAlive (null);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual NSObject PressedInput {
			[Export ("pressedInput")]
			get {
				return _GetPressedInput (this);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static NSObject _GetPressedInput (IGCButtonElement This)
		{
			NSObject ret;
			ret = Runtime.GetNSObject (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("pressedInput")), false)!;
			GC.KeepAlive (This);
			return ret;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual IGCTouchedStateInput? TouchedInput {
			[Export ("touchedInput")]
			get {
				return _GetTouchedInput (this);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static IGCTouchedStateInput _GetTouchedInput (IGCButtonElement This)
		{
			IGCTouchedStateInput ret;
			ret =  Runtime.GetINativeObject<IGCTouchedStateInput> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("touchedInput")), false)!;
			GC.KeepAlive (This);
			return ret;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("maccatalyst26.0")]
		[SupportedOSPlatform ("tvos26.0")]
		[SupportedOSPlatform ("macos26.0")]
		[SupportedOSPlatform ("ios26.0")]
		[global::Foundation.RequiredMember]
		public virtual IGCLinearInput? ForceInput {
			[Export ("forceInput")]
			get {
				return _GetForceInput (this);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static IGCLinearInput _GetForceInput (IGCButtonElement This)
		{
			IGCLinearInput ret;
			ret =  Runtime.GetINativeObject<IGCLinearInput> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("forceInput")), false)!;
			GC.KeepAlive (This);
			return ret;
		}
	}
	#pragma warning restore CS1573
	internal unsafe sealed class GCButtonElementWrapper : BaseWrapper, IGCButtonElement {
		public GCButtonElementWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.PublicConstructors, typeof (GCButtonElementWrapper))]
		static GCButtonElementWrapper ()
		{
			GC.KeepAlive (null);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public NSObject PressedInput {
			[Export ("pressedInput")]
			get {
				NSObject ret;
				ret = Runtime.GetNSObject (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("pressedInput")), false)!;
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public IGCTouchedStateInput? TouchedInput {
			[Export ("touchedInput")]
			get {
				IGCTouchedStateInput ret;
				ret =  Runtime.GetINativeObject<IGCTouchedStateInput> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("touchedInput")), false)!;
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("maccatalyst26.0")]
		[SupportedOSPlatform ("tvos26.0")]
		[SupportedOSPlatform ("macos26.0")]
		[SupportedOSPlatform ("ios26.0")]
		public IGCLinearInput? ForceInput {
			[Export ("forceInput")]
			get {
				IGCLinearInput ret;
				ret =  Runtime.GetINativeObject<IGCLinearInput> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("forceInput")), false)!;
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("ios16.0")]
		[SupportedOSPlatform ("macos13.0")]
		[SupportedOSPlatform ("tvos16.0")]
		[SupportedOSPlatform ("maccatalyst16.0")]
		public string? SfSymbolsName {
			[Export ("sfSymbolsName")]
			[SupportedOSPlatform ("ios16.0")]
			[SupportedOSPlatform ("macos13.0")]
			[SupportedOSPlatform ("tvos16.0")]
			[SupportedOSPlatform ("maccatalyst16.0")]
			get {
				string ret;
				ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("sfSymbolsName")), false)!;
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("ios16.0")]
		[SupportedOSPlatform ("macos13.0")]
		[SupportedOSPlatform ("tvos16.0")]
		[SupportedOSPlatform ("maccatalyst16.0")]
		public string? LocalizedName {
			[Export ("localizedName")]
			[SupportedOSPlatform ("ios16.0")]
			[SupportedOSPlatform ("macos13.0")]
			[SupportedOSPlatform ("tvos16.0")]
			[SupportedOSPlatform ("maccatalyst16.0")]
			get {
				string ret;
				ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("localizedName")), false)!;
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("ios16.0")]
		[SupportedOSPlatform ("macos13.0")]
		[SupportedOSPlatform ("tvos16.0")]
		[SupportedOSPlatform ("maccatalyst16.0")]
		public NSSet<NSString> Aliases {
			[Export ("aliases")]
			[SupportedOSPlatform ("ios16.0")]
			[SupportedOSPlatform ("macos13.0")]
			[SupportedOSPlatform ("tvos16.0")]
			[SupportedOSPlatform ("maccatalyst16.0")]
			get {
				NSSet<NSString> ret;
				ret =  Runtime.GetNSObject<NSSet<NSString>> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("aliases")), false)!;
				return ret;
			}
		}
	}
}
