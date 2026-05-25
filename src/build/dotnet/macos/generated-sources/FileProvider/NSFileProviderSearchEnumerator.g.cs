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
	/// <summary>This interface represents the Objective-C protocol <c>NSFileProviderSearchEnumerator</c>.</summary>
	/// <remarks>
	///   <para>A class that implements this interface (and subclasses <see cref="NSObject" />) will be exported to Objective-C as implementing the Objective-C protocol this interface represents.</para>
	///   <para>A class may also implement members from this interface to implement members from the protocol.</para>
	/// </remarks>
	[UnsupportedOSPlatform ("tvos")]
	[UnsupportedOSPlatform ("maccatalyst")]
	[UnsupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos26.0")]
	[Protocol (Name = "NSFileProviderSearchEnumerator", WrapperType = typeof (NSFileProviderSearchEnumeratorWrapper), BackwardsCompatibleCodeGeneration = false)]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "Invalidate", Selector = "invalidate")]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "EnumerateSearchResults", Selector = "enumerateSearchResultsForObserver:startingAtPage:", ParameterType = new Type [] { typeof (INSFileProviderSearchEnumerationObserver), typeof (NSData) }, ParameterByRef = new bool [] { false, false })]
	public partial interface INSFileProviderSearchEnumerator : INativeObject, IDisposable
	{
		[global::Foundation.RequiredMember]
		[Export ("invalidate")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void Invalidate ()
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _Invalidate (INSFileProviderSearchEnumerator This)
		{
			global::ObjCRuntime.Messaging.void_objc_msgSend (This.Handle, Selector.GetHandle ("invalidate"));
			GC.KeepAlive (This);
		}
		[global::Foundation.RequiredMember]
		[Export ("enumerateSearchResultsForObserver:startingAtPage:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void EnumerateSearchResults (INSFileProviderSearchEnumerationObserver observer, NSData? page)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _EnumerateSearchResults (INSFileProviderSearchEnumerator This, INSFileProviderSearchEnumerationObserver observer, NSData? page)
		{
			var observer__handle__ = observer!.GetNonNullHandle (nameof (observer));
			var page__handle__ = page.GetHandle ();
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("enumerateSearchResultsForObserver:startingAtPage:"), observer__handle__, page__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (observer);
			GC.KeepAlive (page);
		}
		[DynamicDependencyAttribute ("EnumerateSearchResults(FileProvider.INSFileProviderSearchEnumerationObserver,Foundation.NSData)")]
		[DynamicDependencyAttribute ("Invalidate()")]
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.Interfaces | DynamicallyAccessedMemberTypes.PublicConstructors, typeof (NSFileProviderSearchEnumeratorWrapper))]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static INSFileProviderSearchEnumerator ()
		{
			GC.KeepAlive (null);
		}
	}
	#pragma warning restore CS1573
	internal unsafe sealed class NSFileProviderSearchEnumeratorWrapper : BaseWrapper, INSFileProviderSearchEnumerator {
		public NSFileProviderSearchEnumeratorWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.PublicConstructors, typeof (NSFileProviderSearchEnumeratorWrapper))]
		static NSFileProviderSearchEnumeratorWrapper ()
		{
			GC.KeepAlive (null);
		}
		[Export ("invalidate")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void Invalidate ()
		{
			global::ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, Selector.GetHandle ("invalidate"));
		}
		[Export ("enumerateSearchResultsForObserver:startingAtPage:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void EnumerateSearchResults (INSFileProviderSearchEnumerationObserver observer, NSData? page)
		{
			var observer__handle__ = observer!.GetNonNullHandle (nameof (observer));
			var page__handle__ = page.GetHandle ();
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("enumerateSearchResultsForObserver:startingAtPage:"), observer__handle__, page__handle__);
			GC.KeepAlive (observer);
			GC.KeepAlive (page);
		}
	}
}
