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
	/// <summary>This interface represents the Objective-C protocol <c>NSFileProviderSearching</c>.</summary>
	/// <remarks>
	///   <para>A class that implements this interface (and subclasses <see cref="NSObject" />) will be exported to Objective-C as implementing the Objective-C protocol this interface represents.</para>
	///   <para>A class may also implement members from this interface to implement members from the protocol.</para>
	/// </remarks>
	[UnsupportedOSPlatform ("tvos")]
	[UnsupportedOSPlatform ("maccatalyst")]
	[UnsupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos26.0")]
	[Protocol (Name = "NSFileProviderSearching", WrapperType = typeof (NSFileProviderSearchingWrapper), BackwardsCompatibleCodeGeneration = false)]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "SearchEnumerator", Selector = "searchEnumeratorForStringSearchRequest:", ReturnType = typeof (INSFileProviderSearchEnumerator), ParameterType = new Type [] { typeof (NSFileProviderStringSearchRequest) }, ParameterByRef = new bool [] { false })]
	public partial interface INSFileProviderSearching : INativeObject, IDisposable
	{
		[global::Foundation.RequiredMember]
		[Export ("searchEnumeratorForStringSearchRequest:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual INSFileProviderSearchEnumerator SearchEnumerator (NSFileProviderStringSearchRequest request)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static INSFileProviderSearchEnumerator _SearchEnumerator (INSFileProviderSearching This, NSFileProviderStringSearchRequest request)
		{
			var request__handle__ = request!.GetNonNullHandle (nameof (request));
			INSFileProviderSearchEnumerator? ret;
			ret =  Runtime.GetINativeObject<INSFileProviderSearchEnumerator> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("searchEnumeratorForStringSearchRequest:"), request__handle__), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (request);
			return ret!;
		}
		[DynamicDependencyAttribute ("SearchEnumerator(FileProvider.NSFileProviderStringSearchRequest)")]
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.Interfaces | DynamicallyAccessedMemberTypes.PublicConstructors, typeof (NSFileProviderSearchingWrapper))]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static INSFileProviderSearching ()
		{
			GC.KeepAlive (null);
		}
	}
	#pragma warning restore CS1573
	internal unsafe sealed class NSFileProviderSearchingWrapper : BaseWrapper, INSFileProviderSearching {
		public NSFileProviderSearchingWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.PublicConstructors, typeof (NSFileProviderSearchingWrapper))]
		static NSFileProviderSearchingWrapper ()
		{
			GC.KeepAlive (null);
		}
		[Export ("searchEnumeratorForStringSearchRequest:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public INSFileProviderSearchEnumerator SearchEnumerator (NSFileProviderStringSearchRequest request)
		{
			var request__handle__ = request!.GetNonNullHandle (nameof (request));
			INSFileProviderSearchEnumerator? ret;
			ret =  Runtime.GetINativeObject<INSFileProviderSearchEnumerator> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("searchEnumeratorForStringSearchRequest:"), request__handle__), false)!;
			GC.KeepAlive (request);
			return ret!;
		}
	}
}
