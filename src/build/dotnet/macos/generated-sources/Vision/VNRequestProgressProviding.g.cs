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
namespace Vision {
	#pragma warning disable CS1573
	/// <summary>This interface represents the Objective-C protocol <c>VNRequestProgressProviding</c>.</summary>
	/// <remarks>
	///   <para>A class that implements this interface (and subclasses <see cref="NSObject" />) will be exported to Objective-C as implementing the Objective-C protocol this interface represents.</para>
	///   <para>A class may also implement members from this interface to implement members from the protocol.</para>
	/// </remarks>
	[SupportedOSPlatform ("tvos13.0")]
	[SupportedOSPlatform ("ios13.0")]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("macos")]
	[Protocol (Name = "VNRequestProgressProviding", WrapperType = typeof (VNRequestProgressProvidingWrapper))]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "ProgressHandler", Selector = "progressHandler", PropertyType = typeof (Vision.VNRequestProgressHandler), GetterSelector = "progressHandler", SetterSelector = "setProgressHandler:", ArgumentSemantic = ArgumentSemantic.Copy, ParameterBlockProxy = new Type [] { typeof (ObjCRuntime.Trampolines.NIDVNRequestProgressHandler) }, ReturnTypeDelegateProxy = typeof (ObjCRuntime.Trampolines.SDVNRequestProgressHandler))]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "Indeterminate", Selector = "indeterminate", PropertyType = typeof (bool), GetterSelector = "indeterminate", ArgumentSemantic = ArgumentSemantic.None)]
	public partial interface IVNRequestProgressProviding : INativeObject, IDisposable
	{
		[DynamicDependencyAttribute ("Indeterminate")]
		[DynamicDependencyAttribute ("ProgressHandler")]
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.Interfaces | DynamicallyAccessedMemberTypes.PublicConstructors, typeof (VNRequestProgressProvidingWrapper))]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static IVNRequestProgressProviding ()
		{
			GC.KeepAlive (null);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public unsafe virtual VNRequestProgressHandler ProgressHandler {
			[return: DelegateProxy (typeof (ObjCRuntime.Trampolines.SDVNRequestProgressHandler))]
			[Export ("progressHandler", ArgumentSemantic.Copy)]
			get {
				return _GetProgressHandler (this);
			}
			[param: BlockProxy (typeof (ObjCRuntime.Trampolines.NIDVNRequestProgressHandler))]
			[Export ("setProgressHandler:", ArgumentSemantic.Copy)]
			set {
				_SetProgressHandler (this, value);
			}
		}
		[return: DelegateProxy (typeof (ObjCRuntime.Trampolines.SDVNRequestProgressHandler))]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal unsafe static VNRequestProgressHandler _GetProgressHandler (IVNRequestProgressProviding This)
		{
			NativeHandle ret;
			ret = global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("progressHandler"));
			GC.KeepAlive (This);
			return global::ObjCRuntime.Trampolines.NIDVNRequestProgressHandler.Create (ret)!;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal unsafe static void _SetProgressHandler (IVNRequestProgressProviding This, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDVNRequestProgressHandler))]VNRequestProgressHandler value)
		{
			if (value is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (value));
			using var block_value = Trampolines.SDVNRequestProgressHandler.CreateBlock (value);
			BlockLiteral *block_ptr_value = &block_value;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("setProgressHandler:"), (IntPtr) block_ptr_value);
			GC.KeepAlive (This);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual bool Indeterminate {
			[Export ("indeterminate")]
			get {
				return _GetIndeterminate (this);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static bool _GetIndeterminate (IVNRequestProgressProviding This)
		{
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (This.Handle, Selector.GetHandle ("indeterminate"));
			GC.KeepAlive (This);
			return ret != 0;
		}
	}
	#pragma warning restore CS1573
	internal unsafe sealed class VNRequestProgressProvidingWrapper : BaseWrapper, IVNRequestProgressProviding {
		public VNRequestProgressProvidingWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.PublicConstructors, typeof (VNRequestProgressProvidingWrapper))]
		static VNRequestProgressProvidingWrapper ()
		{
			GC.KeepAlive (null);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe VNRequestProgressHandler ProgressHandler {
			[return: DelegateProxy (typeof (ObjCRuntime.Trampolines.SDVNRequestProgressHandler))]
			[Export ("progressHandler", ArgumentSemantic.Copy)]
			get {
				NativeHandle ret;
				ret = global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("progressHandler"));
				return global::ObjCRuntime.Trampolines.NIDVNRequestProgressHandler.Create (ret)!;
			}
			[param: BlockProxy (typeof (ObjCRuntime.Trampolines.NIDVNRequestProgressHandler))]
			[Export ("setProgressHandler:", ArgumentSemantic.Copy)]
			set {
				if (value is null)
					ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (value));
				using var block_value = Trampolines.SDVNRequestProgressHandler.CreateBlock (value);
				BlockLiteral *block_ptr_value = &block_value;
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("setProgressHandler:"), (IntPtr) block_ptr_value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public bool Indeterminate {
			[Export ("indeterminate")]
			get {
				byte ret;
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("indeterminate"));
				return ret != 0;
			}
		}
	}
}
