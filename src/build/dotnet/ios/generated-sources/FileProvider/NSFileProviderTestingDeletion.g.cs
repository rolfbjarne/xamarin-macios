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
	/// <summary>This interface represents the Objective-C protocol <c>NSFileProviderTestingDeletion</c>.</summary>
	/// <remarks>
	///   <para>A class that implements this interface (and subclasses <see cref="NSObject" />) will be exported to Objective-C as implementing the Objective-C protocol this interface represents.</para>
	///   <para>A class may also implement members from this interface to implement members from the protocol.</para>
	/// </remarks>
	[UnsupportedOSPlatform ("maccatalyst")]
	[UnsupportedOSPlatform ("tvos")]
	[SupportedOSPlatform ("ios16.0")]
	[SupportedOSPlatform ("macos")]
	[Protocol (Name = "NSFileProviderTestingDeletion", WrapperType = typeof (NSFileProviderTestingDeletionWrapper))]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "TargetSide", Selector = "targetSide", PropertyType = typeof (NSFileProviderTestingOperationSide), GetterSelector = "targetSide", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "SourceItemIdentifier", Selector = "sourceItemIdentifier", PropertyType = typeof (string), GetterSelector = "sourceItemIdentifier", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "TargetItemIdentifier", Selector = "targetItemIdentifier", PropertyType = typeof (string), GetterSelector = "targetItemIdentifier", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "TargetItemBaseVersion", Selector = "targetItemBaseVersion", PropertyType = typeof (NSFileProviderItemVersion), GetterSelector = "targetItemBaseVersion", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "DomainVersion", Selector = "domainVersion", PropertyType = typeof (NSFileProviderDomainVersion), GetterSelector = "domainVersion", ArgumentSemantic = ArgumentSemantic.None)]
	public partial interface INSFileProviderTestingDeletion : INativeObject, IDisposable, 
		FileProvider.INSFileProviderTestingOperation
	{
		[DynamicDependencyAttribute ("DomainVersion")]
		[DynamicDependencyAttribute ("SourceItemIdentifier")]
		[DynamicDependencyAttribute ("TargetItemBaseVersion")]
		[DynamicDependencyAttribute ("TargetItemIdentifier")]
		[DynamicDependencyAttribute ("TargetSide")]
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.Interfaces | DynamicallyAccessedMemberTypes.PublicConstructors, typeof (NSFileProviderTestingDeletionWrapper))]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static INSFileProviderTestingDeletion ()
		{
			GC.KeepAlive (null);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual NSFileProviderTestingOperationSide TargetSide {
			[Export ("targetSide")]
			get {
				return _GetTargetSide (this);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static NSFileProviderTestingOperationSide _GetTargetSide (INSFileProviderTestingDeletion This)
		{
			NSFileProviderTestingOperationSide ret;
			ret = (NSFileProviderTestingOperationSide) (ulong) global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend (This.Handle, Selector.GetHandle ("targetSide"));
			GC.KeepAlive (This);
			return ret!;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual string SourceItemIdentifier {
			[Export ("sourceItemIdentifier")]
			get {
				return _GetSourceItemIdentifier (this);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static string _GetSourceItemIdentifier (INSFileProviderTestingDeletion This)
		{
			string ret;
			ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("sourceItemIdentifier")), false)!;
			GC.KeepAlive (This);
			return ret;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual string TargetItemIdentifier {
			[Export ("targetItemIdentifier")]
			get {
				return _GetTargetItemIdentifier (this);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static string _GetTargetItemIdentifier (INSFileProviderTestingDeletion This)
		{
			string ret;
			ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("targetItemIdentifier")), false)!;
			GC.KeepAlive (This);
			return ret;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual NSFileProviderItemVersion TargetItemBaseVersion {
			[Export ("targetItemBaseVersion")]
			get {
				return _GetTargetItemBaseVersion (this);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static NSFileProviderItemVersion _GetTargetItemBaseVersion (INSFileProviderTestingDeletion This)
		{
			NSFileProviderItemVersion ret;
			ret =  Runtime.GetNSObject<NSFileProviderItemVersion> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("targetItemBaseVersion")), false)!;
			GC.KeepAlive (This);
			return ret;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual NSFileProviderDomainVersion? DomainVersion {
			[Export ("domainVersion")]
			get {
				return _GetDomainVersion (this);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static NSFileProviderDomainVersion _GetDomainVersion (INSFileProviderTestingDeletion This)
		{
			NSFileProviderDomainVersion ret;
			ret =  Runtime.GetNSObject<NSFileProviderDomainVersion> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("domainVersion")), false)!;
			GC.KeepAlive (This);
			return ret;
		}
	}
	#pragma warning restore CS1573
	internal unsafe sealed class NSFileProviderTestingDeletionWrapper : BaseWrapper, INSFileProviderTestingDeletion {
		public NSFileProviderTestingDeletionWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.PublicConstructors, typeof (NSFileProviderTestingDeletionWrapper))]
		static NSFileProviderTestingDeletionWrapper ()
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
		public NSFileProviderTestingOperationSide TargetSide {
			[Export ("targetSide")]
			get {
				NSFileProviderTestingOperationSide ret;
				ret = (NSFileProviderTestingOperationSide) (ulong) global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("targetSide"));
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public string SourceItemIdentifier {
			[Export ("sourceItemIdentifier")]
			get {
				string ret;
				ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("sourceItemIdentifier")), false)!;
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public string TargetItemIdentifier {
			[Export ("targetItemIdentifier")]
			get {
				string ret;
				ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("targetItemIdentifier")), false)!;
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public NSFileProviderItemVersion TargetItemBaseVersion {
			[Export ("targetItemBaseVersion")]
			get {
				NSFileProviderItemVersion ret;
				ret =  Runtime.GetNSObject<NSFileProviderItemVersion> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("targetItemBaseVersion")), false)!;
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public NSFileProviderDomainVersion? DomainVersion {
			[Export ("domainVersion")]
			get {
				NSFileProviderDomainVersion ret;
				ret =  Runtime.GetNSObject<NSFileProviderDomainVersion> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("domainVersion")), false)!;
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
