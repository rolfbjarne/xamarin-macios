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
namespace Metal {
	#pragma warning disable CS1573
	/// <summary>This interface represents the Objective-C protocol <c>MTL4CompilerTask</c>.</summary>
	/// <remarks>
	///   <para>A class that implements this interface (and subclasses <see cref="NSObject" />) will be exported to Objective-C as implementing the Objective-C protocol this interface represents.</para>
	///   <para>A class may also implement members from this interface to implement members from the protocol.</para>
	/// </remarks>
	[SupportedOSPlatform ("macos26.0")]
	[SupportedOSPlatform ("ios26.0")]
	[SupportedOSPlatform ("tvos26.0")]
	[SupportedOSPlatform ("maccatalyst26.0")]
	[UnsupportedSimulator ("tvos")]
	[Protocol (Name = "MTL4CompilerTask", WrapperType = typeof (MTL4CompilerTaskWrapper), BackwardsCompatibleCodeGeneration = false)]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "WaitUntilCompleted", Selector = "waitUntilCompleted")]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "Compiler", Selector = "compiler", PropertyType = typeof (IMTL4Compiler), GetterSelector = "compiler", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "Status", Selector = "status", PropertyType = typeof (MTL4CompilerTaskStatus), GetterSelector = "status", ArgumentSemantic = ArgumentSemantic.None)]
	public partial interface IMTL4CompilerTask : INativeObject, IDisposable
	{
		[global::Foundation.RequiredMember]
		[Export ("waitUntilCompleted")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void WaitUntilCompleted ()
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _WaitUntilCompleted (IMTL4CompilerTask This)
		{
			global::ObjCRuntime.Messaging.void_objc_msgSend (This.Handle, Selector.GetHandle ("waitUntilCompleted"));
			GC.KeepAlive (This);
		}
		[DynamicDependencyAttribute ("Compiler")]
		[DynamicDependencyAttribute ("Status")]
		[DynamicDependencyAttribute ("WaitUntilCompleted()")]
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.Interfaces | DynamicallyAccessedMemberTypes.PublicConstructors, typeof (MTL4CompilerTaskWrapper))]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static IMTL4CompilerTask ()
		{
			GC.KeepAlive (null);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual IMTL4Compiler Compiler {
			[Export ("compiler")]
			get {
				return _GetCompiler (this);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static IMTL4Compiler _GetCompiler (IMTL4CompilerTask This)
		{
			IMTL4Compiler ret;
			ret =  Runtime.GetINativeObject<IMTL4Compiler> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("compiler")), false)!;
			GC.KeepAlive (This);
			return ret;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual MTL4CompilerTaskStatus Status {
			[Export ("status")]
			get {
				return _GetStatus (this);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static MTL4CompilerTaskStatus _GetStatus (IMTL4CompilerTask This)
		{
			MTL4CompilerTaskStatus ret;
			ret = (MTL4CompilerTaskStatus) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (This.Handle, Selector.GetHandle ("status"));
			GC.KeepAlive (This);
			return ret!;
		}
	}
	#pragma warning restore CS1573
	internal unsafe sealed class MTL4CompilerTaskWrapper : BaseWrapper, IMTL4CompilerTask {
		public MTL4CompilerTaskWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.PublicConstructors, typeof (MTL4CompilerTaskWrapper))]
		static MTL4CompilerTaskWrapper ()
		{
			GC.KeepAlive (null);
		}
		[Export ("waitUntilCompleted")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void WaitUntilCompleted ()
		{
			global::ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, Selector.GetHandle ("waitUntilCompleted"));
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public IMTL4Compiler Compiler {
			[Export ("compiler")]
			get {
				IMTL4Compiler ret;
				ret =  Runtime.GetINativeObject<IMTL4Compiler> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("compiler")), false)!;
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public MTL4CompilerTaskStatus Status {
			[Export ("status")]
			get {
				MTL4CompilerTaskStatus ret;
				ret = (MTL4CompilerTaskStatus) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("status"));
				return ret!;
			}
		}
	}
}
