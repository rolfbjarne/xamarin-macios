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
	/// <summary>This interface represents the Objective-C protocol <c>NSFileProviderSearchEnumerationObserver</c>.</summary>
	/// <remarks>
	///   <para>A class that implements this interface (and subclasses <see cref="NSObject" />) will be exported to Objective-C as implementing the Objective-C protocol this interface represents.</para>
	///   <para>A class may also implement members from this interface to implement members from the protocol.</para>
	/// </remarks>
	[UnsupportedOSPlatform ("tvos")]
	[UnsupportedOSPlatform ("maccatalyst")]
	[UnsupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos26.0")]
	[Protocol (Name = "NSFileProviderSearchEnumerationObserver", WrapperType = typeof (NSFileProviderSearchEnumerationObserverWrapper), BackwardsCompatibleCodeGeneration = false)]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "DidEnumerateSearchResults", Selector = "didEnumerateSearchResults:", ParameterType = new Type [] { typeof (INSFileProviderSearchResult[]) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "FinishEnumeratingUpToPage", Selector = "finishEnumeratingUpToPage:", ParameterType = new Type [] { typeof (NSData) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "FinishEnumeratingWithError", Selector = "finishEnumeratingWithError:", ParameterType = new Type [] { typeof (NSError) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "MaximumNumberOfResultsPerPage", Selector = "maximumNumberOfResultsPerPage", PropertyType = typeof (IntPtr), GetterSelector = "maximumNumberOfResultsPerPage", ArgumentSemantic = ArgumentSemantic.None)]
	public partial interface INSFileProviderSearchEnumerationObserver : INativeObject, IDisposable
	{
		[global::Foundation.RequiredMember]
		[Export ("didEnumerateSearchResults:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidEnumerateSearchResults (INSFileProviderSearchResult[] searchResults)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _DidEnumerateSearchResults (INSFileProviderSearchEnumerationObserver This, INSFileProviderSearchResult[] searchResults)
		{
			if (searchResults is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (searchResults));
			using var nsa_searchResults = NSArray.FromNSObjects (searchResults);
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("didEnumerateSearchResults:"), nsa_searchResults.Handle);
			GC.KeepAlive (This);
		}
		[global::Foundation.RequiredMember]
		[Export ("finishEnumeratingUpToPage:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void FinishEnumeratingUpToPage (NSData? nextPage)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _FinishEnumeratingUpToPage (INSFileProviderSearchEnumerationObserver This, NSData? nextPage)
		{
			var nextPage__handle__ = nextPage.GetHandle ();
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("finishEnumeratingUpToPage:"), nextPage__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (nextPage);
		}
		[global::Foundation.RequiredMember]
		[Export ("finishEnumeratingWithError:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void FinishEnumeratingWithError (NSError error)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _FinishEnumeratingWithError (INSFileProviderSearchEnumerationObserver This, NSError error)
		{
			var error__handle__ = error!.GetNonNullHandle (nameof (error));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("finishEnumeratingWithError:"), error__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (error);
		}
		[DynamicDependencyAttribute ("DidEnumerateSearchResults(FileProvider.INSFileProviderSearchResult[])")]
		[DynamicDependencyAttribute ("FinishEnumeratingUpToPage(Foundation.NSData)")]
		[DynamicDependencyAttribute ("FinishEnumeratingWithError(Foundation.NSError)")]
		[DynamicDependencyAttribute ("MaximumNumberOfResultsPerPage")]
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.Interfaces | DynamicallyAccessedMemberTypes.PublicConstructors, typeof (NSFileProviderSearchEnumerationObserverWrapper))]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static INSFileProviderSearchEnumerationObserver ()
		{
			GC.KeepAlive (null);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual nint MaximumNumberOfResultsPerPage {
			[Export ("maximumNumberOfResultsPerPage")]
			get {
				return _GetMaximumNumberOfResultsPerPage (this);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static nint _GetMaximumNumberOfResultsPerPage (INSFileProviderSearchEnumerationObserver This)
		{
			nint ret;
			ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (This.Handle, Selector.GetHandle ("maximumNumberOfResultsPerPage"));
			GC.KeepAlive (This);
			return ret;
		}
	}
	#pragma warning restore CS1573
	internal unsafe sealed class NSFileProviderSearchEnumerationObserverWrapper : BaseWrapper, INSFileProviderSearchEnumerationObserver {
		public NSFileProviderSearchEnumerationObserverWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.PublicConstructors, typeof (NSFileProviderSearchEnumerationObserverWrapper))]
		static NSFileProviderSearchEnumerationObserverWrapper ()
		{
			GC.KeepAlive (null);
		}
		[Export ("didEnumerateSearchResults:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void DidEnumerateSearchResults (INSFileProviderSearchResult[] searchResults)
		{
			if (searchResults is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (searchResults));
			using var nsa_searchResults = NSArray.FromNSObjects (searchResults);
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("didEnumerateSearchResults:"), nsa_searchResults.Handle);
		}
		[Export ("finishEnumeratingUpToPage:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void FinishEnumeratingUpToPage (NSData? nextPage)
		{
			var nextPage__handle__ = nextPage.GetHandle ();
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("finishEnumeratingUpToPage:"), nextPage__handle__);
			GC.KeepAlive (nextPage);
		}
		[Export ("finishEnumeratingWithError:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void FinishEnumeratingWithError (NSError error)
		{
			var error__handle__ = error!.GetNonNullHandle (nameof (error));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("finishEnumeratingWithError:"), error__handle__);
			GC.KeepAlive (error);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public nint MaximumNumberOfResultsPerPage {
			[Export ("maximumNumberOfResultsPerPage")]
			get {
				nint ret;
				ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("maximumNumberOfResultsPerPage"));
				return ret;
			}
		}
	}
}
