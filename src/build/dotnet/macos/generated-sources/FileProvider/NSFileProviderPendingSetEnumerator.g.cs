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
	/// <summary>This interface represents the Objective-C protocol <c>NSFileProviderPendingSetEnumerator</c>.</summary>
	/// <remarks>
	///   <para>A class that implements this interface (and subclasses <see cref="NSObject" />) will be exported to Objective-C as implementing the Objective-C protocol this interface represents.</para>
	///   <para>A class may also implement members from this interface to implement members from the protocol.</para>
	/// </remarks>
	[UnsupportedOSPlatform ("maccatalyst")]
	[UnsupportedOSPlatform ("tvos")]
	[SupportedOSPlatform ("ios16.0")]
	[SupportedOSPlatform ("macos")]
	[Protocol (Name = "NSFileProviderPendingSetEnumerator", WrapperType = typeof (NSFileProviderPendingSetEnumeratorWrapper))]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "DomainVersion", Selector = "domainVersion", PropertyType = typeof (NSFileProviderDomainVersion), GetterSelector = "domainVersion", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "RefreshInterval", Selector = "refreshInterval", PropertyType = typeof (double), GetterSelector = "refreshInterval", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = false, IsProperty = true, IsStatic = false, Name = "MaximumSizeReached", Selector = "maximumSizeReached", PropertyType = typeof (bool), GetterSelector = "isMaximumSizeReached", ArgumentSemantic = ArgumentSemantic.None)]
	public partial interface INSFileProviderPendingSetEnumerator : INativeObject, IDisposable, 
		FileProvider.INSFileProviderEnumerator
	{
		[DynamicDependencyAttribute ("DomainVersion")]
		[DynamicDependencyAttribute ("MaximumSizeReached")]
		[DynamicDependencyAttribute ("RefreshInterval")]
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.Interfaces | DynamicallyAccessedMemberTypes.PublicConstructors, typeof (NSFileProviderPendingSetEnumeratorWrapper))]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static INSFileProviderPendingSetEnumerator ()
		{
			GC.KeepAlive (null);
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
		internal static NSFileProviderDomainVersion _GetDomainVersion (INSFileProviderPendingSetEnumerator This)
		{
			NSFileProviderDomainVersion ret;
			ret =  Runtime.GetNSObject<NSFileProviderDomainVersion> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("domainVersion")), false)!;
			GC.KeepAlive (This);
			return ret;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual double RefreshInterval {
			[Export ("refreshInterval")]
			get {
				return _GetRefreshInterval (this);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static double _GetRefreshInterval (INSFileProviderPendingSetEnumerator This)
		{
			double ret;
			ret = global::ObjCRuntime.Messaging.Double_objc_msgSend (This.Handle, Selector.GetHandle ("refreshInterval"));
			GC.KeepAlive (This);
			return ret;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos13.0")]
		[SupportedOSPlatform ("ios16.0")]
		[global::Foundation.OptionalMember]
		public virtual bool MaximumSizeReached {
			[Export ("isMaximumSizeReached")]
			get {
				return _GetMaximumSizeReached (this);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static bool _GetMaximumSizeReached (INSFileProviderPendingSetEnumerator This)
		{
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (This.Handle, Selector.GetHandle ("isMaximumSizeReached"));
			GC.KeepAlive (This);
			return ret != 0;
		}
	}
	#pragma warning restore CS1573
	#pragma warning disable CS1573
	/// <summary>Extension methods to the <see cref="INSFileProviderPendingSetEnumerator" /> interface to support all the methods from the NSFileProviderPendingSetEnumerator protocol.</summary>
	/// <remarks>
	///   <para>The extension methods for <see cref="INSFileProviderPendingSetEnumerator" /> interface allow developers to treat instances of the interface as having all the optional methods of the original NSFileProviderPendingSetEnumerator protocol. Since the interface only contains the required members, these extension methods allow developers to call the optional members of the protocol.</para>
	/// </remarks>
	public unsafe static partial class NSFileProviderPendingSetEnumerator_Extensions {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool GetMaximumSizeReached (this INSFileProviderPendingSetEnumerator This)
		{
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (This.Handle, Selector.GetHandle ("isMaximumSizeReached"));
			GC.KeepAlive (This);
			return ret != 0;
		}
	}
	#pragma warning restore CS1573
	internal unsafe sealed class NSFileProviderPendingSetEnumeratorWrapper : BaseWrapper, INSFileProviderPendingSetEnumerator {
		public NSFileProviderPendingSetEnumeratorWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.PublicConstructors, typeof (NSFileProviderPendingSetEnumeratorWrapper))]
		static NSFileProviderPendingSetEnumeratorWrapper ()
		{
			GC.KeepAlive (null);
		}
		/// <summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("invalidate")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void Invalidate ()
		{
			global::ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, Selector.GetHandle ("invalidate"));
		}
		/// <param name="observer">To be added.</param><param name="startPage">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("enumerateItemsForObserver:startingAtPage:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void EnumerateItems (INSFileProviderEnumerationObserver observer, NSData startPage)
		{
			var observer__handle__ = observer!.GetNonNullHandle (nameof (observer));
			var startPage__handle__ = startPage!.GetNonNullHandle (nameof (startPage));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("enumerateItemsForObserver:startingAtPage:"), observer__handle__, startPage__handle__);
			GC.KeepAlive (observer);
			GC.KeepAlive (startPage);
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
		public double RefreshInterval {
			[Export ("refreshInterval")]
			get {
				double ret;
				ret = global::ObjCRuntime.Messaging.Double_objc_msgSend (this.Handle, Selector.GetHandle ("refreshInterval"));
				return ret;
			}
		}
	}
}
