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
	/// <summary>This interface represents the Objective-C protocol <c>NSTextLocation</c>.</summary>
	/// <remarks>
	///   <para>A class that implements this interface (and subclasses <see cref="NSObject" />) will be exported to Objective-C as implementing the Objective-C protocol this interface represents.</para>
	///   <para>A class may also implement members from this interface to implement members from the protocol.</para>
	/// </remarks>
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("macos")]
	[UnsupportedOSPlatform ("tvos")]
	[UnsupportedOSPlatform ("ios")]
	[Protocol (Name = "NSTextLocation", WrapperType = typeof (NSTextLocationWrapper))]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "Compare", Selector = "compare:", ReturnType = typeof (NSComparisonResult), ParameterType = new Type [] { typeof (INSTextLocation) }, ParameterByRef = new bool [] { false })]
	public partial interface INSTextLocation : INativeObject, IDisposable
	{
		[global::Foundation.RequiredMember]
		[Export ("compare:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSComparisonResult Compare (INSTextLocation location)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static NSComparisonResult _Compare (INSTextLocation This, INSTextLocation location)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var location__handle__ = location!.GetNonNullHandle (nameof (location));
			NSComparisonResult ret;
			ret = (NSComparisonResult) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("compare:"), location__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (location);
			return ret!;
		}
		[DynamicDependencyAttribute ("Compare(AppKit.INSTextLocation)")]
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.Interfaces | DynamicallyAccessedMemberTypes.PublicConstructors, typeof (NSTextLocationWrapper))]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static INSTextLocation ()
		{
			GC.KeepAlive (null);
		}
	}
	#pragma warning restore CS1573
	internal unsafe sealed class NSTextLocationWrapper : BaseWrapper, INSTextLocation {
		public NSTextLocationWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.PublicConstructors, typeof (NSTextLocationWrapper))]
		static NSTextLocationWrapper ()
		{
			GC.KeepAlive (null);
		}
		[Export ("compare:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public NSComparisonResult Compare (INSTextLocation location)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var location__handle__ = location!.GetNonNullHandle (nameof (location));
			NSComparisonResult ret;
			ret = (NSComparisonResult) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("compare:"), location__handle__);
			GC.KeepAlive (location);
			return ret!;
		}
	}
}
