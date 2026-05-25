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
using Metal;
using CoreML;
using OpenGL;
using AppKit;
using Photos;
using ModelIO;
using Network;
using SceneKit;
using Contacts;
using Security;
using CloudKit;
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
using FileProvider;
using CoreAnimation;
using CoreFoundation;
using NetworkExtension;
using MetalPerformanceShadersGraph;
#nullable enable
namespace Metal {
	#pragma warning disable CS1573
	/// <summary>This interface represents the Objective-C protocol <c>MTLRasterizationRateMap</c>.</summary>
	/// <remarks>
	///   <para>A class that implements this interface (and subclasses <see cref="NSObject" />) will be exported to Objective-C as implementing the Objective-C protocol this interface represents.</para>
	///   <para>A class may also implement members from this interface to implement members from the protocol.</para>
	/// </remarks>
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("tvos16.0")]
	[SupportedOSPlatform ("ios13.0")]
	[SupportedOSPlatform ("macos")]
	[Protocol (Name = "MTLRasterizationRateMap", WrapperType = typeof (MTLRasterizationRateMapWrapper))]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "CopyParameterData", Selector = "copyParameterDataToBuffer:offset:", ParameterType = new Type [] { typeof (IMTLBuffer), typeof (UIntPtr) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "GetPhysicalSize", Selector = "physicalSizeForLayer:", ReturnType = typeof (MTLSize), ParameterType = new Type [] { typeof (UIntPtr) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "MapScreenToPhysicalCoordinates", Selector = "mapScreenToPhysicalCoordinates:forLayer:", ReturnType = typeof (MTLCoordinate2D), ParameterType = new Type [] { typeof (MTLCoordinate2D), typeof (UIntPtr) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "MapPhysicalToScreenCoordinates", Selector = "mapPhysicalToScreenCoordinates:forLayer:", ReturnType = typeof (MTLCoordinate2D), ParameterType = new Type [] { typeof (MTLCoordinate2D), typeof (UIntPtr) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "Device", Selector = "device", PropertyType = typeof (IMTLDevice), GetterSelector = "device", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "Label", Selector = "label", PropertyType = typeof (string), GetterSelector = "label", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "ScreenSize", Selector = "screenSize", PropertyType = typeof (MTLSize), GetterSelector = "screenSize", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "PhysicalGranularity", Selector = "physicalGranularity", PropertyType = typeof (MTLSize), GetterSelector = "physicalGranularity", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "LayerCount", Selector = "layerCount", PropertyType = typeof (UIntPtr), GetterSelector = "layerCount", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "ParameterBufferSizeAndAlign", Selector = "parameterBufferSizeAndAlign", PropertyType = typeof (MTLSizeAndAlign), GetterSelector = "parameterBufferSizeAndAlign", ArgumentSemantic = ArgumentSemantic.None)]
	public partial interface IMTLRasterizationRateMap : INativeObject, IDisposable
	{
		[global::Foundation.RequiredMember]
		[Export ("copyParameterDataToBuffer:offset:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void CopyParameterData (IMTLBuffer buffer, nuint offset)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _CopyParameterData (IMTLRasterizationRateMap This, IMTLBuffer buffer, nuint offset)
		{
			var buffer__handle__ = buffer!.GetNonNullHandle (nameof (buffer));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_UIntPtr (This.Handle, Selector.GetHandle ("copyParameterDataToBuffer:offset:"), buffer__handle__, offset);
			GC.KeepAlive (This);
			GC.KeepAlive (buffer);
		}
		[global::Foundation.RequiredMember]
		[Export ("physicalSizeForLayer:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual MTLSize GetPhysicalSize (nuint layerIndex)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static MTLSize _GetPhysicalSize (IMTLRasterizationRateMap This, nuint layerIndex)
		{
			MTLSize ret;
			if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
				ret = global::ObjCRuntime.Messaging.MTLSize_objc_msgSend_UIntPtr (This.Handle, Selector.GetHandle ("physicalSizeForLayer:"), layerIndex);
				GC.KeepAlive (This);
			} else {
				ret = global::ObjCRuntime.Messaging.MTLSize_objc_msgSend_stret_UIntPtr (This.Handle, Selector.GetHandle ("physicalSizeForLayer:"), layerIndex);
				GC.KeepAlive (This);
			}
			return ret!;
		}
		[global::Foundation.RequiredMember]
		[Export ("mapScreenToPhysicalCoordinates:forLayer:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual MTLCoordinate2D MapScreenToPhysicalCoordinates (MTLCoordinate2D screenCoordinates, nuint layerIndex)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static MTLCoordinate2D _MapScreenToPhysicalCoordinates (IMTLRasterizationRateMap This, MTLCoordinate2D screenCoordinates, nuint layerIndex)
		{
			MTLCoordinate2D ret;
			ret = global::ObjCRuntime.Messaging.MTLCoordinate2D_objc_msgSend_MTLCoordinate2D_UIntPtr (This.Handle, Selector.GetHandle ("mapScreenToPhysicalCoordinates:forLayer:"), screenCoordinates, layerIndex);
			GC.KeepAlive (This);
			return ret;
		}
		[global::Foundation.RequiredMember]
		[Export ("mapPhysicalToScreenCoordinates:forLayer:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual MTLCoordinate2D MapPhysicalToScreenCoordinates (MTLCoordinate2D physicalCoordinates, nuint layerIndex)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static MTLCoordinate2D _MapPhysicalToScreenCoordinates (IMTLRasterizationRateMap This, MTLCoordinate2D physicalCoordinates, nuint layerIndex)
		{
			MTLCoordinate2D ret;
			ret = global::ObjCRuntime.Messaging.MTLCoordinate2D_objc_msgSend_MTLCoordinate2D_UIntPtr (This.Handle, Selector.GetHandle ("mapPhysicalToScreenCoordinates:forLayer:"), physicalCoordinates, layerIndex);
			GC.KeepAlive (This);
			return ret;
		}
		[DynamicDependencyAttribute ("CopyParameterData(Metal.IMTLBuffer,System.UIntPtr)")]
		[DynamicDependencyAttribute ("Device")]
		[DynamicDependencyAttribute ("GetPhysicalSize(System.UIntPtr)")]
		[DynamicDependencyAttribute ("Label")]
		[DynamicDependencyAttribute ("LayerCount")]
		[DynamicDependencyAttribute ("MapPhysicalToScreenCoordinates(Metal.MTLCoordinate2D,System.UIntPtr)")]
		[DynamicDependencyAttribute ("MapScreenToPhysicalCoordinates(Metal.MTLCoordinate2D,System.UIntPtr)")]
		[DynamicDependencyAttribute ("ParameterBufferSizeAndAlign")]
		[DynamicDependencyAttribute ("PhysicalGranularity")]
		[DynamicDependencyAttribute ("ScreenSize")]
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.Interfaces | DynamicallyAccessedMemberTypes.PublicConstructors, typeof (MTLRasterizationRateMapWrapper))]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static IMTLRasterizationRateMap ()
		{
			GC.KeepAlive (null);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual IMTLDevice Device {
			[Export ("device")]
			get {
				return _GetDevice (this);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static IMTLDevice _GetDevice (IMTLRasterizationRateMap This)
		{
			IMTLDevice ret;
			ret =  Runtime.GetINativeObject<IMTLDevice> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("device")), false)!;
			GC.KeepAlive (This);
			return ret;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual string? Label {
			[Export ("label")]
			get {
				return _GetLabel (this);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static string _GetLabel (IMTLRasterizationRateMap This)
		{
			string ret;
			ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("label")), false)!;
			GC.KeepAlive (This);
			return ret;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual MTLSize ScreenSize {
			[Export ("screenSize")]
			get {
				return _GetScreenSize (this);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static MTLSize _GetScreenSize (IMTLRasterizationRateMap This)
		{
			MTLSize ret;
			if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
				ret = global::ObjCRuntime.Messaging.MTLSize_objc_msgSend (This.Handle, Selector.GetHandle ("screenSize"));
				GC.KeepAlive (This);
			} else {
				ret = global::ObjCRuntime.Messaging.MTLSize_objc_msgSend_stret (This.Handle, Selector.GetHandle ("screenSize"));
				GC.KeepAlive (This);
			}
			return ret!;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual MTLSize PhysicalGranularity {
			[Export ("physicalGranularity")]
			get {
				return _GetPhysicalGranularity (this);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static MTLSize _GetPhysicalGranularity (IMTLRasterizationRateMap This)
		{
			MTLSize ret;
			if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
				ret = global::ObjCRuntime.Messaging.MTLSize_objc_msgSend (This.Handle, Selector.GetHandle ("physicalGranularity"));
				GC.KeepAlive (This);
			} else {
				ret = global::ObjCRuntime.Messaging.MTLSize_objc_msgSend_stret (This.Handle, Selector.GetHandle ("physicalGranularity"));
				GC.KeepAlive (This);
			}
			return ret!;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual nuint LayerCount {
			[Export ("layerCount")]
			get {
				return _GetLayerCount (this);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static nuint _GetLayerCount (IMTLRasterizationRateMap This)
		{
			nuint ret;
			ret = global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend (This.Handle, Selector.GetHandle ("layerCount"));
			GC.KeepAlive (This);
			return ret;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual MTLSizeAndAlign ParameterBufferSizeAndAlign {
			[Export ("parameterBufferSizeAndAlign")]
			get {
				return _GetParameterBufferSizeAndAlign (this);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static MTLSizeAndAlign _GetParameterBufferSizeAndAlign (IMTLRasterizationRateMap This)
		{
			MTLSizeAndAlign ret;
			ret = global::ObjCRuntime.Messaging.MTLSizeAndAlign_objc_msgSend (This.Handle, Selector.GetHandle ("parameterBufferSizeAndAlign"));
			GC.KeepAlive (This);
			return ret;
		}
	}
	#pragma warning restore CS1573
	internal unsafe sealed class MTLRasterizationRateMapWrapper : BaseWrapper, IMTLRasterizationRateMap {
		public MTLRasterizationRateMapWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.PublicConstructors, typeof (MTLRasterizationRateMapWrapper))]
		static MTLRasterizationRateMapWrapper ()
		{
			GC.KeepAlive (null);
		}
		[Export ("copyParameterDataToBuffer:offset:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void CopyParameterData (IMTLBuffer buffer, nuint offset)
		{
			var buffer__handle__ = buffer!.GetNonNullHandle (nameof (buffer));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_UIntPtr (this.Handle, Selector.GetHandle ("copyParameterDataToBuffer:offset:"), buffer__handle__, offset);
			GC.KeepAlive (buffer);
		}
		[Export ("physicalSizeForLayer:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public MTLSize GetPhysicalSize (nuint layerIndex)
		{
			MTLSize ret;
			if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
				ret = global::ObjCRuntime.Messaging.MTLSize_objc_msgSend_UIntPtr (this.Handle, Selector.GetHandle ("physicalSizeForLayer:"), layerIndex);
			} else {
				ret = global::ObjCRuntime.Messaging.MTLSize_objc_msgSend_stret_UIntPtr (this.Handle, Selector.GetHandle ("physicalSizeForLayer:"), layerIndex);
			}
			return ret!;
		}
		[Export ("mapScreenToPhysicalCoordinates:forLayer:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public MTLCoordinate2D MapScreenToPhysicalCoordinates (MTLCoordinate2D screenCoordinates, nuint layerIndex)
		{
			MTLCoordinate2D ret;
			ret = global::ObjCRuntime.Messaging.MTLCoordinate2D_objc_msgSend_MTLCoordinate2D_UIntPtr (this.Handle, Selector.GetHandle ("mapScreenToPhysicalCoordinates:forLayer:"), screenCoordinates, layerIndex);
			return ret;
		}
		[Export ("mapPhysicalToScreenCoordinates:forLayer:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public MTLCoordinate2D MapPhysicalToScreenCoordinates (MTLCoordinate2D physicalCoordinates, nuint layerIndex)
		{
			MTLCoordinate2D ret;
			ret = global::ObjCRuntime.Messaging.MTLCoordinate2D_objc_msgSend_MTLCoordinate2D_UIntPtr (this.Handle, Selector.GetHandle ("mapPhysicalToScreenCoordinates:forLayer:"), physicalCoordinates, layerIndex);
			return ret;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public IMTLDevice Device {
			[Export ("device")]
			get {
				IMTLDevice ret;
				ret =  Runtime.GetINativeObject<IMTLDevice> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("device")), false)!;
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public string? Label {
			[Export ("label")]
			get {
				string ret;
				ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("label")), false)!;
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public MTLSize ScreenSize {
			[Export ("screenSize")]
			get {
				MTLSize ret;
				if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
					ret = global::ObjCRuntime.Messaging.MTLSize_objc_msgSend (this.Handle, Selector.GetHandle ("screenSize"));
				} else {
					ret = global::ObjCRuntime.Messaging.MTLSize_objc_msgSend_stret (this.Handle, Selector.GetHandle ("screenSize"));
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public MTLSize PhysicalGranularity {
			[Export ("physicalGranularity")]
			get {
				MTLSize ret;
				if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
					ret = global::ObjCRuntime.Messaging.MTLSize_objc_msgSend (this.Handle, Selector.GetHandle ("physicalGranularity"));
				} else {
					ret = global::ObjCRuntime.Messaging.MTLSize_objc_msgSend_stret (this.Handle, Selector.GetHandle ("physicalGranularity"));
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public nuint LayerCount {
			[Export ("layerCount")]
			get {
				nuint ret;
				ret = global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("layerCount"));
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public MTLSizeAndAlign ParameterBufferSizeAndAlign {
			[Export ("parameterBufferSizeAndAlign")]
			get {
				MTLSizeAndAlign ret;
				ret = global::ObjCRuntime.Messaging.MTLSizeAndAlign_objc_msgSend (this.Handle, Selector.GetHandle ("parameterBufferSizeAndAlign"));
				return ret;
			}
		}
	}
}
