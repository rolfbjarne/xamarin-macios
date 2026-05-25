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
namespace VideoToolbox {
	#pragma warning disable CS1573
	/// <summary>This interface represents the Objective-C protocol <c>VTFrameProcessorParameters</c>.</summary>
	/// <remarks>
	///   <para>A class that implements this interface (and subclasses <see cref="NSObject" />) will be exported to Objective-C as implementing the Objective-C protocol this interface represents.</para>
	///   <para>A class may also implement members from this interface to implement members from the protocol.</para>
	/// </remarks>
	[SupportedOSPlatform ("maccatalyst26.0")]
	[SupportedOSPlatform ("tvos26.0")]
	[SupportedOSPlatform ("ios26.0")]
	[SupportedOSPlatform ("macos15.4")]
	[Protocol (Name = "VTFrameProcessorParameters", WrapperType = typeof (VTFrameProcessorParametersWrapper), BackwardsCompatibleCodeGeneration = false)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "SourceFrame", Selector = "sourceFrame", PropertyType = typeof (VideoToolbox.VTFrameProcessorFrame), GetterSelector = "sourceFrame", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = false, IsProperty = true, IsStatic = false, Name = "DestinationFrame", Selector = "destinationFrame", PropertyType = typeof (VideoToolbox.VTFrameProcessorFrame), GetterSelector = "destinationFrame", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = false, IsProperty = true, IsStatic = false, Name = "DestinationFrames", Selector = "destinationFrames", PropertyType = typeof (VideoToolbox.VTFrameProcessorFrame[]), GetterSelector = "destinationFrames", ArgumentSemantic = ArgumentSemantic.None)]
	public partial interface IVTFrameProcessorParameters : INativeObject, IDisposable
	{
		[DynamicDependencyAttribute ("DestinationFrame")]
		[DynamicDependencyAttribute ("DestinationFrames")]
		[DynamicDependencyAttribute ("SourceFrame")]
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.Interfaces | DynamicallyAccessedMemberTypes.PublicConstructors, typeof (VTFrameProcessorParametersWrapper))]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static IVTFrameProcessorParameters ()
		{
			GC.KeepAlive (null);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual VTFrameProcessorFrame SourceFrame {
			[Export ("sourceFrame")]
			get {
				return _GetSourceFrame (this);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static VTFrameProcessorFrame _GetSourceFrame (IVTFrameProcessorParameters This)
		{
			VTFrameProcessorFrame ret;
			ret =  Runtime.GetNSObject<VTFrameProcessorFrame> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("sourceFrame")), false)!;
			GC.KeepAlive (This);
			return ret;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("maccatalyst26.0")]
		[SupportedOSPlatform ("tvos26.0")]
		[SupportedOSPlatform ("ios26.0")]
		[SupportedOSPlatform ("macos26.0")]
		[global::Foundation.OptionalMember]
		public virtual VTFrameProcessorFrame DestinationFrame {
			[Export ("destinationFrame")]
			get {
				return _GetDestinationFrame (this);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static VTFrameProcessorFrame _GetDestinationFrame (IVTFrameProcessorParameters This)
		{
			VTFrameProcessorFrame ret;
			ret =  Runtime.GetNSObject<VTFrameProcessorFrame> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("destinationFrame")), false)!;
			GC.KeepAlive (This);
			return ret;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("maccatalyst26.0")]
		[SupportedOSPlatform ("tvos26.0")]
		[SupportedOSPlatform ("ios26.0")]
		[SupportedOSPlatform ("macos26.0")]
		[global::Foundation.OptionalMember]
		public virtual VTFrameProcessorFrame[] DestinationFrames {
			[Export ("destinationFrames")]
			get {
				return _GetDestinationFrames (this);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static VTFrameProcessorFrame[] _GetDestinationFrames (IVTFrameProcessorParameters This)
		{
			VTFrameProcessorFrame[] ret;
			ret = CFArray.ArrayFromHandle<VTFrameProcessorFrame>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("destinationFrames")), false)!;
			GC.KeepAlive (This);
			return ret;
		}
	}
	#pragma warning restore CS1573
	internal unsafe sealed class VTFrameProcessorParametersWrapper : BaseWrapper, IVTFrameProcessorParameters {
		public VTFrameProcessorParametersWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.PublicConstructors, typeof (VTFrameProcessorParametersWrapper))]
		static VTFrameProcessorParametersWrapper ()
		{
			GC.KeepAlive (null);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public VTFrameProcessorFrame SourceFrame {
			[Export ("sourceFrame")]
			get {
				VTFrameProcessorFrame ret;
				ret =  Runtime.GetNSObject<VTFrameProcessorFrame> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("sourceFrame")), false)!;
				return ret;
			}
		}
	}
}
