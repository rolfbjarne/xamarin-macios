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
namespace FileProvider {
	#pragma warning disable CS1573
	/// <summary>This interface represents the Objective-C protocol <c>NSFileProviderTestingCollisionResolution</c>.</summary>
	/// <remarks>
	///   <para>A class that implements this interface (and subclasses <see cref="NSObject" />) will be exported to Objective-C as implementing the Objective-C protocol this interface represents.</para>
	///   <para>A class may also implement members from this interface to implement members from the protocol.</para>
	/// </remarks>
	[UnsupportedOSPlatform ("maccatalyst")]
	[UnsupportedOSPlatform ("tvos")]
	[SupportedOSPlatform ("ios16.0")]
	[SupportedOSPlatform ("macos")]
	[Protocol (Name = "NSFileProviderTestingCollisionResolution", WrapperType = typeof (NSFileProviderTestingCollisionResolutionWrapper))]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "Side", Selector = "side", PropertyType = typeof (NSFileProviderTestingOperationSide), GetterSelector = "side", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "RenamedItem", Selector = "renamedItem", PropertyType = typeof (INSFileProviderItem), GetterSelector = "renamedItem", ArgumentSemantic = ArgumentSemantic.None)]
	public partial interface INSFileProviderTestingCollisionResolution : INativeObject, IDisposable, 
		FileProvider.INSFileProviderTestingOperation
	{
		[DynamicDependencyAttribute ("RenamedItem")]
		[DynamicDependencyAttribute ("Side")]
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.Interfaces | DynamicallyAccessedMemberTypes.PublicConstructors, typeof (NSFileProviderTestingCollisionResolutionWrapper))]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static INSFileProviderTestingCollisionResolution ()
		{
			GC.KeepAlive (null);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual NSFileProviderTestingOperationSide Side {
			[Export ("side")]
			get {
				return _GetSide (this);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static NSFileProviderTestingOperationSide _GetSide (INSFileProviderTestingCollisionResolution This)
		{
			NSFileProviderTestingOperationSide ret;
			ret = (NSFileProviderTestingOperationSide) (ulong) global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend (This.Handle, Selector.GetHandle ("side"));
			GC.KeepAlive (This);
			return ret!;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual INSFileProviderItem RenamedItem {
			[Export ("renamedItem")]
			get {
				return _GetRenamedItem (this);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static INSFileProviderItem _GetRenamedItem (INSFileProviderTestingCollisionResolution This)
		{
			INSFileProviderItem ret;
			ret =  Runtime.GetINativeObject<INSFileProviderItem> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("renamedItem")), false)!;
			GC.KeepAlive (This);
			return ret;
		}
	}
	#pragma warning restore CS1573
	internal unsafe sealed class NSFileProviderTestingCollisionResolutionWrapper : BaseWrapper, INSFileProviderTestingCollisionResolution {
		public NSFileProviderTestingCollisionResolutionWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.PublicConstructors, typeof (NSFileProviderTestingCollisionResolutionWrapper))]
		static NSFileProviderTestingCollisionResolutionWrapper ()
		{
			GC.KeepAlive (null);
		}
		[Export ("asIngestion")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public INSFileProviderTestingIngestion? GetAsIngestion ()
		{
			INSFileProviderTestingIngestion ret;
			ret =  Runtime.GetINativeObject<INSFileProviderTestingIngestion> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("asIngestion")), false)!;
			return ret;
		}
		[Export ("asLookup")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public INSFileProviderTestingLookup? GetAsLookup ()
		{
			INSFileProviderTestingLookup ret;
			ret =  Runtime.GetINativeObject<INSFileProviderTestingLookup> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("asLookup")), false)!;
			return ret;
		}
		[Export ("asCreation")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public INSFileProviderTestingCreation? GetAsCreation ()
		{
			INSFileProviderTestingCreation ret;
			ret =  Runtime.GetINativeObject<INSFileProviderTestingCreation> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("asCreation")), false)!;
			return ret;
		}
		[Export ("asModification")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public INSFileProviderTestingModification? GetAsModification ()
		{
			INSFileProviderTestingModification ret;
			ret =  Runtime.GetINativeObject<INSFileProviderTestingModification> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("asModification")), false)!;
			return ret;
		}
		[Export ("asDeletion")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public INSFileProviderTestingDeletion? GetAsDeletion ()
		{
			INSFileProviderTestingDeletion ret;
			ret =  Runtime.GetINativeObject<INSFileProviderTestingDeletion> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("asDeletion")), false)!;
			return ret;
		}
		[Export ("asContentFetch")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public INSFileProviderTestingContentFetch? GetAsContentFetch ()
		{
			INSFileProviderTestingContentFetch ret;
			ret =  Runtime.GetINativeObject<INSFileProviderTestingContentFetch> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("asContentFetch")), false)!;
			return ret;
		}
		[Export ("asChildrenEnumeration")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public INSFileProviderTestingChildrenEnumeration? GetAsChildrenEnumeration ()
		{
			INSFileProviderTestingChildrenEnumeration ret;
			ret =  Runtime.GetINativeObject<INSFileProviderTestingChildrenEnumeration> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("asChildrenEnumeration")), false)!;
			return ret;
		}
		[Export ("asCollisionResolution")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public INSFileProviderTestingCollisionResolution? GetAsCollisionResolution ()
		{
			INSFileProviderTestingCollisionResolution ret;
			ret =  Runtime.GetINativeObject<INSFileProviderTestingCollisionResolution> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("asCollisionResolution")), false)!;
			return ret;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public NSFileProviderTestingOperationSide Side {
			[Export ("side")]
			get {
				NSFileProviderTestingOperationSide ret;
				ret = (NSFileProviderTestingOperationSide) (ulong) global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("side"));
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public INSFileProviderItem RenamedItem {
			[Export ("renamedItem")]
			get {
				INSFileProviderItem ret;
				ret =  Runtime.GetINativeObject<INSFileProviderItem> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("renamedItem")), false)!;
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[UnsupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios16.0")]
		[SupportedOSPlatform ("macos")]
		public NSFileProviderTestingOperationType Type {
			[Export ("type")]
			[UnsupportedOSPlatform ("maccatalyst")]
			[UnsupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("ios16.0")]
			[SupportedOSPlatform ("macos")]
			get {
				NSFileProviderTestingOperationType ret;
				ret = (NSFileProviderTestingOperationType) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("type"));
				return ret!;
			}
		}
	}
}
