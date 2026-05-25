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
namespace VideoToolbox {
	#pragma warning disable CS1573
	/// <summary>This interface represents the Objective-C protocol <c>VTFrameProcessorConfiguration</c>.</summary>
	/// <remarks>
	///   <para>A class that implements this interface (and subclasses <see cref="NSObject" />) will be exported to Objective-C as implementing the Objective-C protocol this interface represents.</para>
	///   <para>A class may also implement members from this interface to implement members from the protocol.</para>
	/// </remarks>
	[SupportedOSPlatform ("maccatalyst26.0")]
	[SupportedOSPlatform ("tvos26.0")]
	[SupportedOSPlatform ("ios26.0")]
	[SupportedOSPlatform ("macos15.4")]
	[Protocol (Name = "VTFrameProcessorConfiguration", WrapperType = typeof (VTFrameProcessorConfigurationWrapper), BackwardsCompatibleCodeGeneration = false)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "WeakFrameSupportedPixelFormats", Selector = "frameSupportedPixelFormats", PropertyType = typeof (NSNumber[]), GetterSelector = "frameSupportedPixelFormats", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "WeakSourcePixelBufferAttributes", Selector = "sourcePixelBufferAttributes", PropertyType = typeof (NSDictionary), GetterSelector = "sourcePixelBufferAttributes", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "WeakDestinationPixelBufferAttributes", Selector = "destinationPixelBufferAttributes", PropertyType = typeof (NSDictionary), GetterSelector = "destinationPixelBufferAttributes", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = false, IsProperty = true, IsStatic = false, Name = "NextFrameCount", Selector = "nextFrameCount", PropertyType = typeof (IntPtr), GetterSelector = "nextFrameCount", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = false, IsProperty = true, IsStatic = false, Name = "PreviousFrameCount", Selector = "previousFrameCount", PropertyType = typeof (IntPtr), GetterSelector = "previousFrameCount", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = false, IsProperty = true, IsStatic = true, Name = "MaximumDimensions", Selector = "maximumDimensions", PropertyType = typeof (CMVideoDimensions), GetterSelector = "maximumDimensions", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = false, IsProperty = true, IsStatic = true, Name = "MinimumDimensions", Selector = "minimumDimensions", PropertyType = typeof (CMVideoDimensions), GetterSelector = "minimumDimensions", ArgumentSemantic = ArgumentSemantic.None)]
	public partial interface IVTFrameProcessorConfiguration : INativeObject, IDisposable
	{
		[DynamicDependencyAttribute ("NextFrameCount")]
		[DynamicDependencyAttribute ("PreviousFrameCount")]
		[DynamicDependencyAttribute ("WeakDestinationPixelBufferAttributes")]
		[DynamicDependencyAttribute ("WeakFrameSupportedPixelFormats")]
		[DynamicDependencyAttribute ("WeakSourcePixelBufferAttributes")]
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.Interfaces | DynamicallyAccessedMemberTypes.PublicConstructors, typeof (VTFrameProcessorConfigurationWrapper))]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static IVTFrameProcessorConfiguration ()
		{
			GC.KeepAlive (null);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual NSNumber[] WeakFrameSupportedPixelFormats {
			[Export ("frameSupportedPixelFormats")]
			get {
				return _GetWeakFrameSupportedPixelFormats (this);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static NSNumber[] _GetWeakFrameSupportedPixelFormats (IVTFrameProcessorConfiguration This)
		{
			NSNumber[] ret;
			ret = CFArray.ArrayFromHandle<NSNumber>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("frameSupportedPixelFormats")), false)!;
			GC.KeepAlive (This);
			return ret;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual NSDictionary WeakSourcePixelBufferAttributes {
			[Export ("sourcePixelBufferAttributes")]
			get {
				return _GetWeakSourcePixelBufferAttributes (this);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static NSDictionary _GetWeakSourcePixelBufferAttributes (IVTFrameProcessorConfiguration This)
		{
			NSDictionary ret;
			ret =  Runtime.GetNSObject<NSDictionary> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("sourcePixelBufferAttributes")), false)!;
			GC.KeepAlive (This);
			return ret;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual NSDictionary WeakDestinationPixelBufferAttributes {
			[Export ("destinationPixelBufferAttributes")]
			get {
				return _GetWeakDestinationPixelBufferAttributes (this);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static NSDictionary _GetWeakDestinationPixelBufferAttributes (IVTFrameProcessorConfiguration This)
		{
			NSDictionary ret;
			ret =  Runtime.GetNSObject<NSDictionary> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("destinationPixelBufferAttributes")), false)!;
			GC.KeepAlive (This);
			return ret;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.OptionalMember]
		public virtual nint NextFrameCount {
			[Export ("nextFrameCount")]
			get {
				return _GetNextFrameCount (this);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static nint _GetNextFrameCount (IVTFrameProcessorConfiguration This)
		{
			nint ret;
			ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (This.Handle, Selector.GetHandle ("nextFrameCount"));
			GC.KeepAlive (This);
			return ret;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.OptionalMember]
		public virtual nint PreviousFrameCount {
			[Export ("previousFrameCount")]
			get {
				return _GetPreviousFrameCount (this);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static nint _GetPreviousFrameCount (IVTFrameProcessorConfiguration This)
		{
			nint ret;
			ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (This.Handle, Selector.GetHandle ("previousFrameCount"));
			GC.KeepAlive (This);
			return ret;
		}
		[global::Foundation.OptionalMember]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static global::CoreMedia.CMVideoDimensions GetMaximumDimensions<T> () where T: NSObject, IVTFrameProcessorConfiguration
		{
			var class_ptr = Class.GetHandle (typeof (T));
			global::CoreMedia.CMVideoDimensions ret;
			ret = global::ObjCRuntime.Messaging.CMVideoDimensions_objc_msgSend (class_ptr, Selector.GetHandle ("maximumDimensions"));
			return ret;
		}
		[global::Foundation.OptionalMember]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static global::CoreMedia.CMVideoDimensions GetMinimumDimensions<T> () where T: NSObject, IVTFrameProcessorConfiguration
		{
			var class_ptr = Class.GetHandle (typeof (T));
			global::CoreMedia.CMVideoDimensions ret;
			ret = global::ObjCRuntime.Messaging.CMVideoDimensions_objc_msgSend (class_ptr, Selector.GetHandle ("minimumDimensions"));
			return ret;
		}
	}
	#pragma warning restore CS1573
	internal unsafe sealed class VTFrameProcessorConfigurationWrapper : BaseWrapper, IVTFrameProcessorConfiguration {
		public VTFrameProcessorConfigurationWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.PublicConstructors, typeof (VTFrameProcessorConfigurationWrapper))]
		static VTFrameProcessorConfigurationWrapper ()
		{
			GC.KeepAlive (null);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public NSNumber[] WeakFrameSupportedPixelFormats {
			[Export ("frameSupportedPixelFormats")]
			get {
				NSNumber[] ret;
				ret = CFArray.ArrayFromHandle<NSNumber>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("frameSupportedPixelFormats")), false)!;
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public NSDictionary WeakSourcePixelBufferAttributes {
			[Export ("sourcePixelBufferAttributes")]
			get {
				NSDictionary ret;
				ret =  Runtime.GetNSObject<NSDictionary> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("sourcePixelBufferAttributes")), false)!;
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public NSDictionary WeakDestinationPixelBufferAttributes {
			[Export ("destinationPixelBufferAttributes")]
			get {
				NSDictionary ret;
				ret =  Runtime.GetNSObject<NSDictionary> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("destinationPixelBufferAttributes")), false)!;
				return ret;
			}
		}
	}
}
