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
	/// <summary>This interface represents the Objective-C protocol <c>NSFileProviderUserInteractionSuppressing</c>.</summary>
	/// <remarks>
	///   <para>A class that implements this interface (and subclasses <see cref="NSObject" />) will be exported to Objective-C as implementing the Objective-C protocol this interface represents.</para>
	///   <para>A class may also implement members from this interface to implement members from the protocol.</para>
	/// </remarks>
	[UnsupportedOSPlatform ("tvos")]
	[UnsupportedOSPlatform ("ios")]
	[UnsupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("macos")]
	[Protocol (Name = "NSFileProviderUserInteractionSuppressing", WrapperType = typeof (NSFileProviderUserInteractionSuppressingWrapper))]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "SetInteractionSuppressed", Selector = "setInteractionSuppressed:forIdentifier:", ParameterType = new Type [] { typeof (bool), typeof (string) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "IsInteractionSuppressed", Selector = "isInteractionSuppressedForIdentifier:", ReturnType = typeof (bool), ParameterType = new Type [] { typeof (string) }, ParameterByRef = new bool [] { false })]
	public partial interface INSFileProviderUserInteractionSuppressing : INativeObject, IDisposable
	{
		[global::Foundation.RequiredMember]
		[Export ("setInteractionSuppressed:forIdentifier:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetInteractionSuppressed (bool suppression, string suppressionIdentifier)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SetInteractionSuppressed (INSFileProviderUserInteractionSuppressing This, bool suppression, string suppressionIdentifier)
		{
			if (suppressionIdentifier is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (suppressionIdentifier));
			var nssuppressionIdentifier = CFString.CreateNative (suppressionIdentifier);
			global::ObjCRuntime.Messaging.void_objc_msgSend_bool_NativeHandle (This.Handle, Selector.GetHandle ("setInteractionSuppressed:forIdentifier:"), suppression ? (byte) 1 : (byte) 0, nssuppressionIdentifier);
			GC.KeepAlive (This);
			CFString.ReleaseNative (nssuppressionIdentifier);
		}
		[global::Foundation.RequiredMember]
		[Export ("isInteractionSuppressedForIdentifier:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool IsInteractionSuppressed (string suppressionIdentifier)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static bool _IsInteractionSuppressed (INSFileProviderUserInteractionSuppressing This, string suppressionIdentifier)
		{
			if (suppressionIdentifier is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (suppressionIdentifier));
			var nssuppressionIdentifier = CFString.CreateNative (suppressionIdentifier);
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("isInteractionSuppressedForIdentifier:"), nssuppressionIdentifier);
			GC.KeepAlive (This);
			CFString.ReleaseNative (nssuppressionIdentifier);
			return ret != 0;
		}
		[DynamicDependencyAttribute ("IsInteractionSuppressed(System.String)")]
		[DynamicDependencyAttribute ("SetInteractionSuppressed(System.Boolean,System.String)")]
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.Interfaces | DynamicallyAccessedMemberTypes.PublicConstructors, typeof (NSFileProviderUserInteractionSuppressingWrapper))]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static INSFileProviderUserInteractionSuppressing ()
		{
			GC.KeepAlive (null);
		}
	}
	#pragma warning restore CS1573
	internal unsafe sealed class NSFileProviderUserInteractionSuppressingWrapper : BaseWrapper, INSFileProviderUserInteractionSuppressing {
		public NSFileProviderUserInteractionSuppressingWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.PublicConstructors, typeof (NSFileProviderUserInteractionSuppressingWrapper))]
		static NSFileProviderUserInteractionSuppressingWrapper ()
		{
			GC.KeepAlive (null);
		}
		[Export ("setInteractionSuppressed:forIdentifier:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void SetInteractionSuppressed (bool suppression, string suppressionIdentifier)
		{
			if (suppressionIdentifier is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (suppressionIdentifier));
			var nssuppressionIdentifier = CFString.CreateNative (suppressionIdentifier);
			global::ObjCRuntime.Messaging.void_objc_msgSend_bool_NativeHandle (this.Handle, Selector.GetHandle ("setInteractionSuppressed:forIdentifier:"), suppression ? (byte) 1 : (byte) 0, nssuppressionIdentifier);
			CFString.ReleaseNative (nssuppressionIdentifier);
		}
		[Export ("isInteractionSuppressedForIdentifier:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public bool IsInteractionSuppressed (string suppressionIdentifier)
		{
			if (suppressionIdentifier is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (suppressionIdentifier));
			var nssuppressionIdentifier = CFString.CreateNative (suppressionIdentifier);
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("isInteractionSuppressedForIdentifier:"), nssuppressionIdentifier);
			CFString.ReleaseNative (nssuppressionIdentifier);
			return ret != 0;
		}
	}
}
