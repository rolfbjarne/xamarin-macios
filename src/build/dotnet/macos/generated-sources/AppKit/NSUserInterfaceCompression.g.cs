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
namespace AppKit {
	#pragma warning disable CS1573
	/// <summary>This interface represents the Objective-C protocol <c>NSUserInterfaceCompression</c>.</summary>
	/// <remarks>
	///   <para>A class that implements this interface (and subclasses <see cref="NSObject" />) will be exported to Objective-C as implementing the Objective-C protocol this interface represents.</para>
	///   <para>A class may also implement members from this interface to implement members from the protocol.</para>
	/// </remarks>
	[UnsupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("macos")]
	[Protocol (Name = "NSUserInterfaceCompression", WrapperType = typeof (NSUserInterfaceCompressionWrapper))]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "Compress", Selector = "compressWithPrioritizedCompressionOptions:", ParameterType = new Type [] { typeof (NSUserInterfaceCompressionOptions[]) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "GetMinimumSize", Selector = "minimumSizeWithPrioritizedCompressionOptions:", ReturnType = typeof (CGSize), ParameterType = new Type [] { typeof (NSUserInterfaceCompressionOptions[]) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "ActiveCompressionOptions", Selector = "activeCompressionOptions", PropertyType = typeof (NSUserInterfaceCompressionOptions), GetterSelector = "activeCompressionOptions", ArgumentSemantic = ArgumentSemantic.Copy)]
	public partial interface INSUserInterfaceCompression : INativeObject, IDisposable
	{
		/// <param name="prioritizedOptions">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[global::Foundation.RequiredMember]
		[Export ("compressWithPrioritizedCompressionOptions:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void Compress (NSUserInterfaceCompressionOptions[] prioritizedOptions)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="prioritizedOptions">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _Compress (INSUserInterfaceCompression This, NSUserInterfaceCompressionOptions[] prioritizedOptions)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			if (prioritizedOptions is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (prioritizedOptions));
			using var nsa_prioritizedOptions = NSArray.FromNSObjects (prioritizedOptions);
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("compressWithPrioritizedCompressionOptions:"), nsa_prioritizedOptions.Handle);
			GC.KeepAlive (This);
		}
		/// <param name="prioritizedOptions">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.RequiredMember]
		[Export ("minimumSizeWithPrioritizedCompressionOptions:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual CGSize GetMinimumSize (NSUserInterfaceCompressionOptions[] prioritizedOptions)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="prioritizedOptions">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static CGSize _GetMinimumSize (INSUserInterfaceCompression This, NSUserInterfaceCompressionOptions[] prioritizedOptions)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			if (prioritizedOptions is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (prioritizedOptions));
			using var nsa_prioritizedOptions = NSArray.FromNSObjects (prioritizedOptions);
			CGSize ret;
			ret = global::ObjCRuntime.Messaging.CGSize_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("minimumSizeWithPrioritizedCompressionOptions:"), nsa_prioritizedOptions.Handle);
			GC.KeepAlive (This);
			return ret;
		}
		[DynamicDependencyAttribute ("ActiveCompressionOptions")]
		[DynamicDependencyAttribute ("Compress(AppKit.NSUserInterfaceCompressionOptions[])")]
		[DynamicDependencyAttribute ("GetMinimumSize(AppKit.NSUserInterfaceCompressionOptions[])")]
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.Interfaces | DynamicallyAccessedMemberTypes.PublicConstructors, typeof (NSUserInterfaceCompressionWrapper))]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static INSUserInterfaceCompression ()
		{
			GC.KeepAlive (null);
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual NSUserInterfaceCompressionOptions ActiveCompressionOptions {
			[Export ("activeCompressionOptions", ArgumentSemantic.Copy)]
			get {
				return _GetActiveCompressionOptions (this);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static NSUserInterfaceCompressionOptions _GetActiveCompressionOptions (INSUserInterfaceCompression This)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			NSUserInterfaceCompressionOptions ret;
			ret =  Runtime.GetNSObject<NSUserInterfaceCompressionOptions> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("activeCompressionOptions")), false)!;
			GC.KeepAlive (This);
			return ret;
		}
	}
	#pragma warning restore CS1573
	internal unsafe sealed class NSUserInterfaceCompressionWrapper : BaseWrapper, INSUserInterfaceCompression {
		public NSUserInterfaceCompressionWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.PublicConstructors, typeof (NSUserInterfaceCompressionWrapper))]
		static NSUserInterfaceCompressionWrapper ()
		{
			GC.KeepAlive (null);
		}
		/// <param name="prioritizedOptions">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("compressWithPrioritizedCompressionOptions:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void Compress (NSUserInterfaceCompressionOptions[] prioritizedOptions)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			if (prioritizedOptions is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (prioritizedOptions));
			using var nsa_prioritizedOptions = NSArray.FromNSObjects (prioritizedOptions);
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("compressWithPrioritizedCompressionOptions:"), nsa_prioritizedOptions.Handle);
		}
		/// <param name="prioritizedOptions">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("minimumSizeWithPrioritizedCompressionOptions:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public CGSize GetMinimumSize (NSUserInterfaceCompressionOptions[] prioritizedOptions)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			if (prioritizedOptions is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (prioritizedOptions));
			using var nsa_prioritizedOptions = NSArray.FromNSObjects (prioritizedOptions);
			CGSize ret;
			ret = global::ObjCRuntime.Messaging.CGSize_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("minimumSizeWithPrioritizedCompressionOptions:"), nsa_prioritizedOptions.Handle);
			return ret;
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public NSUserInterfaceCompressionOptions ActiveCompressionOptions {
			[Export ("activeCompressionOptions", ArgumentSemantic.Copy)]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				NSUserInterfaceCompressionOptions ret;
				ret =  Runtime.GetNSObject<NSUserInterfaceCompressionOptions> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("activeCompressionOptions")), false)!;
				return ret;
			}
		}
	}
}
