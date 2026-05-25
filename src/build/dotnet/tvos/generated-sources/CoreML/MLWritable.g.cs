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
using Photos;
using ModelIO;
using Network;
using SceneKit;
using Security;
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
using CoreAnimation;
using CoreFoundation;
using NetworkExtension;
using MetalPerformanceShadersGraph;
#nullable enable
namespace CoreML {
	#pragma warning disable CS1573
	/// <summary>This interface represents the Objective-C protocol <c>MLWritable</c>.</summary>
	/// <remarks>
	///   <para>A class that implements this interface (and subclasses <see cref="NSObject" />) will be exported to Objective-C as implementing the Objective-C protocol this interface represents.</para>
	///   <para>A class may also implement members from this interface to implement members from the protocol.</para>
	/// </remarks>
	[SupportedOSPlatform ("tvos13.0")]
	[SupportedOSPlatform ("ios13.0")]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("macos")]
	[Protocol (Name = "MLWritable", WrapperType = typeof (MLWritableWrapper))]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "Write", Selector = "writeToURL:error:", ReturnType = typeof (bool), ParameterType = new Type [] { typeof (NSUrl), typeof (NSError) }, ParameterByRef = new bool [] { false, true })]
	public partial interface IMLWritable : INativeObject, IDisposable
	{
		[global::Foundation.RequiredMember]
		[Export ("writeToURL:error:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual bool Write (NSUrl url, out NSError? error)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal unsafe static bool _Write (IMLWritable This, NSUrl url, out NSError? error)
		{
			var url__handle__ = url!.GetNonNullHandle (nameof (url));
			NativeHandle errorValue = IntPtr.Zero;
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_ref_NativeHandle (This.Handle, Selector.GetHandle ("writeToURL:error:"), url__handle__, &errorValue);
			GC.KeepAlive (This);
			GC.KeepAlive (url);
			error = Runtime.GetNSObject<NSError> (errorValue)!;
			return ret != 0;
		}
		[DynamicDependencyAttribute ("Write(Foundation.NSUrl,Foundation.NSError@)")]
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.Interfaces | DynamicallyAccessedMemberTypes.PublicConstructors, typeof (MLWritableWrapper))]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static IMLWritable ()
		{
			GC.KeepAlive (null);
		}
	}
	#pragma warning restore CS1573
	internal unsafe sealed class MLWritableWrapper : BaseWrapper, IMLWritable {
		public MLWritableWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.PublicConstructors, typeof (MLWritableWrapper))]
		static MLWritableWrapper ()
		{
			GC.KeepAlive (null);
		}
		[Export ("writeToURL:error:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe bool Write (NSUrl url, out NSError? error)
		{
			var url__handle__ = url!.GetNonNullHandle (nameof (url));
			NativeHandle errorValue = IntPtr.Zero;
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_ref_NativeHandle (this.Handle, Selector.GetHandle ("writeToURL:error:"), url__handle__, &errorValue);
			GC.KeepAlive (url);
			error = Runtime.GetNSObject<NSError> (errorValue)!;
			return ret != 0;
		}
	}
}
