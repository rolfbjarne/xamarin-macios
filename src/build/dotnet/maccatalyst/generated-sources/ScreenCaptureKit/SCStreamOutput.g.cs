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
namespace ScreenCaptureKit {
	#pragma warning disable CS1573
	/// <summary>This interface represents the Objective-C protocol <c>SCStreamOutput</c>.</summary>
	/// <remarks>
	///   <para>A class that implements this interface (and subclasses <see cref="NSObject" />) will be exported to Objective-C as implementing the Objective-C protocol this interface represents.</para>
	///   <para>A class may also implement members from this interface to implement members from the protocol.</para>
	/// </remarks>
	[UnsupportedOSPlatform ("ios")]
	[UnsupportedOSPlatform ("tvos")]
	[SupportedOSPlatform ("macos12.3")]
	[SupportedOSPlatform ("maccatalyst18.2")]
	[Protocol (Name = "SCStreamOutput", WrapperType = typeof (SCStreamOutputWrapper))]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidOutputSampleBuffer", Selector = "stream:didOutputSampleBuffer:ofType:", ParameterType = new Type [] { typeof (ScreenCaptureKit.SCStream), typeof (CMSampleBuffer), typeof (ScreenCaptureKit.SCStreamOutputType) }, ParameterByRef = new bool [] { false, false, false })]
	public partial interface ISCStreamOutput : INativeObject, IDisposable
	{
		[global::Foundation.OptionalMember]
		[Export ("stream:didOutputSampleBuffer:ofType:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidOutputSampleBuffer (SCStream stream, global::CoreMedia.CMSampleBuffer sampleBuffer, SCStreamOutputType type)
		{
			_DidOutputSampleBuffer (this, stream, sampleBuffer, type);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _DidOutputSampleBuffer (ISCStreamOutput This, SCStream stream, global::CoreMedia.CMSampleBuffer sampleBuffer, SCStreamOutputType type)
		{
			var stream__handle__ = stream!.GetNonNullHandle (nameof (stream));
			var sampleBuffer__handle__ = sampleBuffer!.GetNonNullHandle (nameof (sampleBuffer));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_IntPtr (This.Handle, Selector.GetHandle ("stream:didOutputSampleBuffer:ofType:"), stream__handle__, sampleBuffer.Handle, (IntPtr) (long) type);
			GC.KeepAlive (This);
			GC.KeepAlive (stream);
			GC.KeepAlive (sampleBuffer);
		}
		[DynamicDependencyAttribute ("DidOutputSampleBuffer(ScreenCaptureKit.SCStream,CoreMedia.CMSampleBuffer,ScreenCaptureKit.SCStreamOutputType)")]
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.Interfaces | DynamicallyAccessedMemberTypes.PublicConstructors, typeof (SCStreamOutputWrapper))]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static ISCStreamOutput ()
		{
			GC.KeepAlive (null);
		}
	}
	#pragma warning restore CS1573
	#pragma warning disable CS1573
	/// <summary>Extension methods to the <see cref="ISCStreamOutput" /> interface to support all the methods from the SCStreamOutput protocol.</summary>
	/// <remarks>
	///   <para>The extension methods for <see cref="ISCStreamOutput" /> interface allow developers to treat instances of the interface as having all the optional methods of the original SCStreamOutput protocol. Since the interface only contains the required members, these extension methods allow developers to call the optional members of the protocol.</para>
	/// </remarks>
	public unsafe static partial class SCStreamOutput_Extensions {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void DidOutputSampleBuffer (this ISCStreamOutput This, SCStream stream, global::CoreMedia.CMSampleBuffer sampleBuffer, SCStreamOutputType type)
		{
			var stream__handle__ = stream!.GetNonNullHandle (nameof (stream));
			var sampleBuffer__handle__ = sampleBuffer!.GetNonNullHandle (nameof (sampleBuffer));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_IntPtr (This.Handle, Selector.GetHandle ("stream:didOutputSampleBuffer:ofType:"), stream__handle__, sampleBuffer.Handle, (IntPtr) (long) type);
			GC.KeepAlive (This);
			GC.KeepAlive (stream);
			GC.KeepAlive (sampleBuffer);
		}
	}
	#pragma warning restore CS1573
	internal unsafe sealed class SCStreamOutputWrapper : BaseWrapper, ISCStreamOutput {
		public SCStreamOutputWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.PublicConstructors, typeof (SCStreamOutputWrapper))]
		static SCStreamOutputWrapper ()
		{
			GC.KeepAlive (null);
		}
	}
}
