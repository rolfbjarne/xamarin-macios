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
namespace FSKit {
	#pragma warning disable CS1573
	/// <summary>This interface represents the Objective-C protocol <c>FSVolumeItemDeactivation</c>.</summary>
	/// <remarks>
	///   <para>A class that implements this interface (and subclasses <see cref="NSObject" />) will be exported to Objective-C as implementing the Objective-C protocol this interface represents.</para>
	///   <para>A class may also implement members from this interface to implement members from the protocol.</para>
	/// </remarks>
	[SupportedOSPlatform ("macos15.4")]
	[Experimental ("APL0002")]
	[Protocol (Name = "FSVolumeItemDeactivation", WrapperType = typeof (FSVolumeItemDeactivationWrapper), BackwardsCompatibleCodeGeneration = false)]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "DeactivateItem", Selector = "deactivateItem:replyHandler:", ParameterType = new Type [] { typeof (FSKit.FSItem), typeof (FSKit.FSVolumeItemDeactivationDeactivateItemHandler) }, ParameterByRef = new bool [] { false, false }, ParameterBlockProxy = new Type? [] { null, typeof (ObjCRuntime.Trampolines.NIDFSVolumeItemDeactivationDeactivateItemHandler) })]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "ItemDeactivationPolicy", Selector = "itemDeactivationPolicy", PropertyType = typeof (FSKit.FSItemDeactivationOptions), GetterSelector = "itemDeactivationPolicy", ArgumentSemantic = ArgumentSemantic.None)]
	public partial interface IFSVolumeItemDeactivation : INativeObject, IDisposable
	{
		[global::Foundation.RequiredMember]
		[Export ("deactivateItem:replyHandler:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void DeactivateItem (FSItem item, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDFSVolumeItemDeactivationDeactivateItemHandler))]FSVolumeItemDeactivationDeactivateItemHandler reply)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal unsafe static void _DeactivateItem (IFSVolumeItemDeactivation This, FSItem item, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDFSVolumeItemDeactivationDeactivateItemHandler))]FSVolumeItemDeactivationDeactivateItemHandler reply)
		{
			var item__handle__ = item!.GetNonNullHandle (nameof (item));
			if (reply is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (reply));
			using var block_reply = Trampolines.SDFSVolumeItemDeactivationDeactivateItemHandler.CreateBlock (reply);
			BlockLiteral *block_ptr_reply = &block_reply;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("deactivateItem:replyHandler:"), item__handle__, (IntPtr) block_ptr_reply);
			GC.KeepAlive (This);
			GC.KeepAlive (item);
		}
		[DynamicDependencyAttribute ("DeactivateItem(FSKit.FSItem,FSKit.FSVolumeItemDeactivationDeactivateItemHandler)")]
		[DynamicDependencyAttribute ("ItemDeactivationPolicy")]
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.Interfaces | DynamicallyAccessedMemberTypes.PublicConstructors, typeof (FSVolumeItemDeactivationWrapper))]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static IFSVolumeItemDeactivation ()
		{
			GC.KeepAlive (null);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual FSItemDeactivationOptions ItemDeactivationPolicy {
			[Export ("itemDeactivationPolicy")]
			get {
				return _GetItemDeactivationPolicy (this);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static FSItemDeactivationOptions _GetItemDeactivationPolicy (IFSVolumeItemDeactivation This)
		{
			FSItemDeactivationOptions ret;
			ret = (FSKit.FSItemDeactivationOptions) (ulong) global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend (This.Handle, Selector.GetHandle ("itemDeactivationPolicy"));
			GC.KeepAlive (This);
			return ret!;
		}
	}
	#pragma warning restore CS1573
	[Experimental ("APL0002")]
	internal unsafe sealed class FSVolumeItemDeactivationWrapper : BaseWrapper, IFSVolumeItemDeactivation {
		[Experimental ("APL0002")]
		public FSVolumeItemDeactivationWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.PublicConstructors, typeof (FSVolumeItemDeactivationWrapper))]
		static FSVolumeItemDeactivationWrapper ()
		{
			GC.KeepAlive (null);
		}
		[Export ("deactivateItem:replyHandler:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe void DeactivateItem (FSItem item, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDFSVolumeItemDeactivationDeactivateItemHandler))]FSVolumeItemDeactivationDeactivateItemHandler reply)
		{
			var item__handle__ = item!.GetNonNullHandle (nameof (item));
			if (reply is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (reply));
			using var block_reply = Trampolines.SDFSVolumeItemDeactivationDeactivateItemHandler.CreateBlock (reply);
			BlockLiteral *block_ptr_reply = &block_reply;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("deactivateItem:replyHandler:"), item__handle__, (IntPtr) block_ptr_reply);
			GC.KeepAlive (item);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public FSItemDeactivationOptions ItemDeactivationPolicy {
			[Export ("itemDeactivationPolicy")]
			get {
				FSItemDeactivationOptions ret;
				ret = (FSKit.FSItemDeactivationOptions) (ulong) global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("itemDeactivationPolicy"));
				return ret!;
			}
		}
	}
}
