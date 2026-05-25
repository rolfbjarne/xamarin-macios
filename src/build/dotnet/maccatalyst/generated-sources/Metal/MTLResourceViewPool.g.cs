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
namespace Metal {
	#pragma warning disable CS1573
	/// <summary>This interface represents the Objective-C protocol <c>MTLResourceViewPool</c>.</summary>
	/// <remarks>
	///   <para>A class that implements this interface (and subclasses <see cref="NSObject" />) will be exported to Objective-C as implementing the Objective-C protocol this interface represents.</para>
	///   <para>A class may also implement members from this interface to implement members from the protocol.</para>
	/// </remarks>
	[SupportedOSPlatform ("macos26.0")]
	[SupportedOSPlatform ("ios26.0")]
	[SupportedOSPlatform ("tvos26.0")]
	[SupportedOSPlatform ("maccatalyst26.0")]
	[Protocol (Name = "MTLResourceViewPool", WrapperType = typeof (MTLResourceViewPoolWrapper), BackwardsCompatibleCodeGeneration = false)]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "CopyResourceViews", Selector = "copyResourceViewsFromPool:sourceRange:destinationIndex:", ReturnType = typeof (MTLResourceId), ParameterType = new Type [] { typeof (IMTLResourceViewPool), typeof (NSRange), typeof (UIntPtr) }, ParameterByRef = new bool [] { false, false, false })]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "BaseResourceId", Selector = "baseResourceID", PropertyType = typeof (MTLResourceId), GetterSelector = "baseResourceID", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "ResourceViewCount", Selector = "resourceViewCount", PropertyType = typeof (UIntPtr), GetterSelector = "resourceViewCount", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "Device", Selector = "device", PropertyType = typeof (IMTLDevice), GetterSelector = "device", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "Label", Selector = "label", PropertyType = typeof (string), GetterSelector = "label", ArgumentSemantic = ArgumentSemantic.None)]
	public partial interface IMTLResourceViewPool : INativeObject, IDisposable
	{
		[global::Foundation.RequiredMember]
		[Export ("copyResourceViewsFromPool:sourceRange:destinationIndex:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual MTLResourceId CopyResourceViews (IMTLResourceViewPool sourcePool, NSRange sourceRange, nuint destinationIndex)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static MTLResourceId _CopyResourceViews (IMTLResourceViewPool This, IMTLResourceViewPool sourcePool, NSRange sourceRange, nuint destinationIndex)
		{
			var sourcePool__handle__ = sourcePool!.GetNonNullHandle (nameof (sourcePool));
			MTLResourceId ret;
			ret = global::ObjCRuntime.Messaging.MTLResourceId_objc_msgSend_NativeHandle_NSRange_UIntPtr (This.Handle, Selector.GetHandle ("copyResourceViewsFromPool:sourceRange:destinationIndex:"), sourcePool__handle__, sourceRange, destinationIndex);
			GC.KeepAlive (This);
			GC.KeepAlive (sourcePool);
			return ret!;
		}
		[DynamicDependencyAttribute ("BaseResourceId")]
		[DynamicDependencyAttribute ("CopyResourceViews(Metal.IMTLResourceViewPool,Foundation.NSRange,System.UIntPtr)")]
		[DynamicDependencyAttribute ("Device")]
		[DynamicDependencyAttribute ("Label")]
		[DynamicDependencyAttribute ("ResourceViewCount")]
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.Interfaces | DynamicallyAccessedMemberTypes.PublicConstructors, typeof (MTLResourceViewPoolWrapper))]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static IMTLResourceViewPool ()
		{
			GC.KeepAlive (null);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual MTLResourceId BaseResourceId {
			[Export ("baseResourceID")]
			get {
				return _GetBaseResourceId (this);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static MTLResourceId _GetBaseResourceId (IMTLResourceViewPool This)
		{
			MTLResourceId ret;
			ret = global::ObjCRuntime.Messaging.MTLResourceId_objc_msgSend (This.Handle, Selector.GetHandle ("baseResourceID"));
			GC.KeepAlive (This);
			return ret;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual nuint ResourceViewCount {
			[Export ("resourceViewCount")]
			get {
				return _GetResourceViewCount (this);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static nuint _GetResourceViewCount (IMTLResourceViewPool This)
		{
			nuint ret;
			ret = global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend (This.Handle, Selector.GetHandle ("resourceViewCount"));
			GC.KeepAlive (This);
			return ret;
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
		internal static IMTLDevice _GetDevice (IMTLResourceViewPool This)
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
		internal static string _GetLabel (IMTLResourceViewPool This)
		{
			string ret;
			ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("label")), false)!;
			GC.KeepAlive (This);
			return ret;
		}
	}
	#pragma warning restore CS1573
	internal unsafe sealed class MTLResourceViewPoolWrapper : BaseWrapper, IMTLResourceViewPool {
		public MTLResourceViewPoolWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.PublicConstructors, typeof (MTLResourceViewPoolWrapper))]
		static MTLResourceViewPoolWrapper ()
		{
			GC.KeepAlive (null);
		}
		[Export ("copyResourceViewsFromPool:sourceRange:destinationIndex:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public MTLResourceId CopyResourceViews (IMTLResourceViewPool sourcePool, NSRange sourceRange, nuint destinationIndex)
		{
			var sourcePool__handle__ = sourcePool!.GetNonNullHandle (nameof (sourcePool));
			MTLResourceId ret;
			ret = global::ObjCRuntime.Messaging.MTLResourceId_objc_msgSend_NativeHandle_NSRange_UIntPtr (this.Handle, Selector.GetHandle ("copyResourceViewsFromPool:sourceRange:destinationIndex:"), sourcePool__handle__, sourceRange, destinationIndex);
			GC.KeepAlive (sourcePool);
			return ret!;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public MTLResourceId BaseResourceId {
			[Export ("baseResourceID")]
			get {
				MTLResourceId ret;
				ret = global::ObjCRuntime.Messaging.MTLResourceId_objc_msgSend (this.Handle, Selector.GetHandle ("baseResourceID"));
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public nuint ResourceViewCount {
			[Export ("resourceViewCount")]
			get {
				nuint ret;
				ret = global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("resourceViewCount"));
				return ret;
			}
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
	}
}
