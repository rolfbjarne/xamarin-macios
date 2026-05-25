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
namespace FileProvider {
	#pragma warning disable CS1573
	/// <summary>This interface represents the Objective-C protocol <c>NSFileProviderTestingOperation</c>.</summary>
	/// <remarks>
	///   <para>A class that implements this interface (and subclasses <see cref="NSObject" />) will be exported to Objective-C as implementing the Objective-C protocol this interface represents.</para>
	///   <para>A class may also implement members from this interface to implement members from the protocol.</para>
	/// </remarks>
	[UnsupportedOSPlatform ("maccatalyst")]
	[UnsupportedOSPlatform ("tvos")]
	[SupportedOSPlatform ("ios16.0")]
	[SupportedOSPlatform ("macos")]
	[Protocol (Name = "NSFileProviderTestingOperation", WrapperType = typeof (NSFileProviderTestingOperationWrapper))]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "GetAsIngestion", Selector = "asIngestion", ReturnType = typeof (INSFileProviderTestingIngestion))]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "GetAsLookup", Selector = "asLookup", ReturnType = typeof (INSFileProviderTestingLookup))]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "GetAsCreation", Selector = "asCreation", ReturnType = typeof (INSFileProviderTestingCreation))]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "GetAsModification", Selector = "asModification", ReturnType = typeof (INSFileProviderTestingModification))]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "GetAsDeletion", Selector = "asDeletion", ReturnType = typeof (INSFileProviderTestingDeletion))]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "GetAsContentFetch", Selector = "asContentFetch", ReturnType = typeof (INSFileProviderTestingContentFetch))]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "GetAsChildrenEnumeration", Selector = "asChildrenEnumeration", ReturnType = typeof (INSFileProviderTestingChildrenEnumeration))]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "GetAsCollisionResolution", Selector = "asCollisionResolution", ReturnType = typeof (INSFileProviderTestingCollisionResolution))]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "Type", Selector = "type", PropertyType = typeof (NSFileProviderTestingOperationType), GetterSelector = "type", ArgumentSemantic = ArgumentSemantic.None)]
	public partial interface INSFileProviderTestingOperation : INativeObject, IDisposable
	{
		[global::Foundation.RequiredMember]
		[Export ("asIngestion")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual INSFileProviderTestingIngestion? GetAsIngestion ()
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static INSFileProviderTestingIngestion? _GetAsIngestion (INSFileProviderTestingOperation This)
		{
			INSFileProviderTestingIngestion ret;
			ret =  Runtime.GetINativeObject<INSFileProviderTestingIngestion> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("asIngestion")), false)!;
			GC.KeepAlive (This);
			return ret;
		}
		[global::Foundation.RequiredMember]
		[Export ("asLookup")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual INSFileProviderTestingLookup? GetAsLookup ()
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static INSFileProviderTestingLookup? _GetAsLookup (INSFileProviderTestingOperation This)
		{
			INSFileProviderTestingLookup ret;
			ret =  Runtime.GetINativeObject<INSFileProviderTestingLookup> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("asLookup")), false)!;
			GC.KeepAlive (This);
			return ret;
		}
		[global::Foundation.RequiredMember]
		[Export ("asCreation")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual INSFileProviderTestingCreation? GetAsCreation ()
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static INSFileProviderTestingCreation? _GetAsCreation (INSFileProviderTestingOperation This)
		{
			INSFileProviderTestingCreation ret;
			ret =  Runtime.GetINativeObject<INSFileProviderTestingCreation> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("asCreation")), false)!;
			GC.KeepAlive (This);
			return ret;
		}
		[global::Foundation.RequiredMember]
		[Export ("asModification")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual INSFileProviderTestingModification? GetAsModification ()
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static INSFileProviderTestingModification? _GetAsModification (INSFileProviderTestingOperation This)
		{
			INSFileProviderTestingModification ret;
			ret =  Runtime.GetINativeObject<INSFileProviderTestingModification> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("asModification")), false)!;
			GC.KeepAlive (This);
			return ret;
		}
		[global::Foundation.RequiredMember]
		[Export ("asDeletion")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual INSFileProviderTestingDeletion? GetAsDeletion ()
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static INSFileProviderTestingDeletion? _GetAsDeletion (INSFileProviderTestingOperation This)
		{
			INSFileProviderTestingDeletion ret;
			ret =  Runtime.GetINativeObject<INSFileProviderTestingDeletion> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("asDeletion")), false)!;
			GC.KeepAlive (This);
			return ret;
		}
		[global::Foundation.RequiredMember]
		[Export ("asContentFetch")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual INSFileProviderTestingContentFetch? GetAsContentFetch ()
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static INSFileProviderTestingContentFetch? _GetAsContentFetch (INSFileProviderTestingOperation This)
		{
			INSFileProviderTestingContentFetch ret;
			ret =  Runtime.GetINativeObject<INSFileProviderTestingContentFetch> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("asContentFetch")), false)!;
			GC.KeepAlive (This);
			return ret;
		}
		[global::Foundation.RequiredMember]
		[Export ("asChildrenEnumeration")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual INSFileProviderTestingChildrenEnumeration? GetAsChildrenEnumeration ()
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static INSFileProviderTestingChildrenEnumeration? _GetAsChildrenEnumeration (INSFileProviderTestingOperation This)
		{
			INSFileProviderTestingChildrenEnumeration ret;
			ret =  Runtime.GetINativeObject<INSFileProviderTestingChildrenEnumeration> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("asChildrenEnumeration")), false)!;
			GC.KeepAlive (This);
			return ret;
		}
		[global::Foundation.RequiredMember]
		[Export ("asCollisionResolution")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual INSFileProviderTestingCollisionResolution? GetAsCollisionResolution ()
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static INSFileProviderTestingCollisionResolution? _GetAsCollisionResolution (INSFileProviderTestingOperation This)
		{
			INSFileProviderTestingCollisionResolution ret;
			ret =  Runtime.GetINativeObject<INSFileProviderTestingCollisionResolution> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("asCollisionResolution")), false)!;
			GC.KeepAlive (This);
			return ret;
		}
		[DynamicDependencyAttribute ("GetAsChildrenEnumeration()")]
		[DynamicDependencyAttribute ("GetAsCollisionResolution()")]
		[DynamicDependencyAttribute ("GetAsContentFetch()")]
		[DynamicDependencyAttribute ("GetAsCreation()")]
		[DynamicDependencyAttribute ("GetAsDeletion()")]
		[DynamicDependencyAttribute ("GetAsIngestion()")]
		[DynamicDependencyAttribute ("GetAsLookup()")]
		[DynamicDependencyAttribute ("GetAsModification()")]
		[DynamicDependencyAttribute ("Type")]
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.Interfaces | DynamicallyAccessedMemberTypes.PublicConstructors, typeof (NSFileProviderTestingOperationWrapper))]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static INSFileProviderTestingOperation ()
		{
			GC.KeepAlive (null);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual NSFileProviderTestingOperationType Type {
			[Export ("type")]
			get {
				return _GetType (this);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static NSFileProviderTestingOperationType _GetType (INSFileProviderTestingOperation This)
		{
			NSFileProviderTestingOperationType ret;
			ret = (NSFileProviderTestingOperationType) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (This.Handle, Selector.GetHandle ("type"));
			GC.KeepAlive (This);
			return ret!;
		}
	}
	#pragma warning restore CS1573
	internal unsafe sealed class NSFileProviderTestingOperationWrapper : BaseWrapper, INSFileProviderTestingOperation {
		public NSFileProviderTestingOperationWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.PublicConstructors, typeof (NSFileProviderTestingOperationWrapper))]
		static NSFileProviderTestingOperationWrapper ()
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
		public NSFileProviderTestingOperationType Type {
			[Export ("type")]
			get {
				NSFileProviderTestingOperationType ret;
				ret = (NSFileProviderTestingOperationType) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("type"));
				return ret!;
			}
		}
	}
}
