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
	/// <summary>This interface represents the Objective-C protocol <c>MTLAllocation</c>.</summary>
	/// <remarks>
	///   <para>A class that implements this interface (and subclasses <see cref="NSObject" />) will be exported to Objective-C as implementing the Objective-C protocol this interface represents.</para>
	///   <para>A class may also implement members from this interface to implement members from the protocol.</para>
	/// </remarks>
	[SupportedOSPlatform ("macos15.0")]
	[SupportedOSPlatform ("ios18.0")]
	[SupportedOSPlatform ("maccatalyst18.0")]
	[SupportedOSPlatform ("tvos18.0")]
	[Protocol (Name = "MTLAllocation", WrapperType = typeof (MTLAllocationWrapper), BackwardsCompatibleCodeGeneration = false)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "AllocatedSize", Selector = "allocatedSize", PropertyType = typeof (UIntPtr), GetterSelector = "allocatedSize", ArgumentSemantic = ArgumentSemantic.None)]
	public partial interface IMTLAllocation : INativeObject, IDisposable
	{
		[DynamicDependencyAttribute ("AllocatedSize")]
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.Interfaces | DynamicallyAccessedMemberTypes.PublicConstructors, typeof (MTLAllocationWrapper))]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static IMTLAllocation ()
		{
			GC.KeepAlive (null);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual nuint AllocatedSize {
			[Export ("allocatedSize")]
			get {
				return _GetAllocatedSize (this);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static nuint _GetAllocatedSize (IMTLAllocation This)
		{
			nuint ret;
			ret = global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend (This.Handle, Selector.GetHandle ("allocatedSize"));
			GC.KeepAlive (This);
			return ret;
		}
	}
	#pragma warning restore CS1573
	internal unsafe sealed class MTLAllocationWrapper : BaseWrapper, IMTLAllocation {
		public MTLAllocationWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.PublicConstructors, typeof (MTLAllocationWrapper))]
		static MTLAllocationWrapper ()
		{
			GC.KeepAlive (null);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public nuint AllocatedSize {
			[Export ("allocatedSize")]
			get {
				nuint ret;
				ret = global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("allocatedSize"));
				return ret;
			}
		}
	}
}
