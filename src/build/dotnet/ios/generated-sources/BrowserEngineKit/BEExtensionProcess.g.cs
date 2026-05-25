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
namespace BrowserEngineKit {
	#pragma warning disable CS1573
	/// <summary>This interface represents the Objective-C protocol <c>BEExtensionProcess</c>.</summary>
	/// <remarks>
	///   <para>A class that implements this interface (and subclasses <see cref="NSObject" />) will be exported to Objective-C as implementing the Objective-C protocol this interface represents.</para>
	///   <para>A class may also implement members from this interface to implement members from the protocol.</para>
	/// </remarks>
	[UnsupportedOSPlatform ("tvos")]
	[SupportedOSPlatform ("macos26.0")]
	[SupportedOSPlatform ("ios26.0")]
	[UnsupportedOSPlatform ("maccatalyst")]
	[Protocol (Name = "BEExtensionProcess", WrapperType = typeof (BEExtensionProcessWrapper), BackwardsCompatibleCodeGeneration = false)]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "Invalidate", Selector = "invalidate")]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "MakeLibXpcConnection", Selector = "makeLibXPCConnectionError:", ReturnType = typeof (NSObject), ParameterType = new Type [] { typeof (NSError) }, ParameterByRef = new bool [] { true })]
	public partial interface IBEExtensionProcess : INativeObject, IDisposable
	{
		[global::Foundation.RequiredMember]
		[Export ("invalidate")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void Invalidate ()
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _Invalidate (IBEExtensionProcess This)
		{
			global::ObjCRuntime.Messaging.void_objc_msgSend (This.Handle, Selector.GetHandle ("invalidate"));
			GC.KeepAlive (This);
		}
		[global::Foundation.RequiredMember]
		[Export ("makeLibXPCConnectionError:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual NSObject? MakeLibXpcConnection (out NSError? error)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal unsafe static NSObject? _MakeLibXpcConnection (IBEExtensionProcess This, out NSError? error)
		{
			NativeHandle errorValue = IntPtr.Zero;
			NSObject? ret;
			ret = Runtime.GetNSObject (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_ref_NativeHandle (This.Handle, Selector.GetHandle ("makeLibXPCConnectionError:"), &errorValue), false)!;
			GC.KeepAlive (This);
			error = Runtime.GetNSObject<NSError> (errorValue)!;
			return ret!;
		}
		[DynamicDependencyAttribute ("Invalidate()")]
		[DynamicDependencyAttribute ("MakeLibXpcConnection(Foundation.NSError@)")]
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.Interfaces | DynamicallyAccessedMemberTypes.PublicConstructors, typeof (BEExtensionProcessWrapper))]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static IBEExtensionProcess ()
		{
			GC.KeepAlive (null);
		}
	}
	#pragma warning restore CS1573
	internal unsafe sealed class BEExtensionProcessWrapper : BaseWrapper, IBEExtensionProcess {
		public BEExtensionProcessWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.PublicConstructors, typeof (BEExtensionProcessWrapper))]
		static BEExtensionProcessWrapper ()
		{
			GC.KeepAlive (null);
		}
		[Export ("invalidate")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void Invalidate ()
		{
			global::ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, Selector.GetHandle ("invalidate"));
		}
		[Export ("makeLibXPCConnectionError:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe NSObject? MakeLibXpcConnection (out NSError? error)
		{
			NativeHandle errorValue = IntPtr.Zero;
			NSObject? ret;
			ret = Runtime.GetNSObject (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_ref_NativeHandle (this.Handle, Selector.GetHandle ("makeLibXPCConnectionError:"), &errorValue), false)!;
			error = Runtime.GetNSObject<NSError> (errorValue)!;
			return ret!;
		}
	}
}
