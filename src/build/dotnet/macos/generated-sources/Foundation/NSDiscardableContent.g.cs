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
namespace Foundation {
	#pragma warning disable CS1573
	/// <summary>Interface for a class that can save memory by discarding some of its subcomponents when they are not in use.</summary><remarks>To be added.</remarks>
	[Protocol (Name = "NSDiscardableContent", WrapperType = typeof (NSDiscardableContentWrapper))]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "BeginContentAccess", Selector = "beginContentAccess", ReturnType = typeof (bool))]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "EndContentAccess", Selector = "endContentAccess")]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "DiscardContentIfPossible", Selector = "discardContentIfPossible")]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "IsContentDiscarded", Selector = "isContentDiscarded", PropertyType = typeof (bool), GetterSelector = "isContentDiscarded", ArgumentSemantic = ArgumentSemantic.None)]
	public partial interface INSDiscardableContent : INativeObject, IDisposable
	{
		/// <summary>Requests access to the content, and returns <see langword="true" /> if the contents are available and were successfully accessed. (Otherwise, returns <see langword="false" />.)</summary><returns><see langword="true" /> if the contents can be retrieved.</returns><remarks>To be added.</remarks>
		[global::Foundation.RequiredMember]
		[Export ("beginContentAccess")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool BeginContentAccess ()
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <summary>Requests access to the content, and returns <see langword="true" /> if the contents are available and were successfully accessed. (Otherwise, returns <see langword="false" />.)</summary><returns><see langword="true" /> if the contents can be retrieved.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static bool _BeginContentAccess (INSDiscardableContent This)
		{
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (This.Handle, Selector.GetHandle ("beginContentAccess"));
			GC.KeepAlive (This);
			return ret != 0;
		}
		/// <summary>Indicates that access to the content is no longer needed.</summary><remarks>To be added.</remarks>
		[global::Foundation.RequiredMember]
		[Export ("endContentAccess")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void EndContentAccess ()
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <summary>Indicates that access to the content is no longer needed.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _EndContentAccess (INSDiscardableContent This)
		{
			global::ObjCRuntime.Messaging.void_objc_msgSend (This.Handle, Selector.GetHandle ("endContentAccess"));
			GC.KeepAlive (This);
		}
		/// <summary>Discards the content if it is not being accessed.</summary><remarks>To be added.</remarks>
		[global::Foundation.RequiredMember]
		[Export ("discardContentIfPossible")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DiscardContentIfPossible ()
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <summary>Discards the content if it is not being accessed.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _DiscardContentIfPossible (INSDiscardableContent This)
		{
			global::ObjCRuntime.Messaging.void_objc_msgSend (This.Handle, Selector.GetHandle ("discardContentIfPossible"));
			GC.KeepAlive (This);
		}
		[DynamicDependencyAttribute ("BeginContentAccess()")]
		[DynamicDependencyAttribute ("DiscardContentIfPossible()")]
		[DynamicDependencyAttribute ("EndContentAccess()")]
		[DynamicDependencyAttribute ("IsContentDiscarded")]
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.Interfaces | DynamicallyAccessedMemberTypes.PublicConstructors, typeof (NSDiscardableContentWrapper))]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static INSDiscardableContent ()
		{
			GC.KeepAlive (null);
		}
		/// <summary>Gets a Boolean value that tells whether the content has been discarded.</summary><value><see langword="true" /> if the content has been discarded.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual bool IsContentDiscarded {
			[Export ("isContentDiscarded")]
			get {
				return _GetIsContentDiscarded (this);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static bool _GetIsContentDiscarded (INSDiscardableContent This)
		{
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (This.Handle, Selector.GetHandle ("isContentDiscarded"));
			GC.KeepAlive (This);
			return ret != 0;
		}
	}
	#pragma warning restore CS1573
	internal unsafe sealed class NSDiscardableContentWrapper : BaseWrapper, INSDiscardableContent {
		public NSDiscardableContentWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.PublicConstructors, typeof (NSDiscardableContentWrapper))]
		static NSDiscardableContentWrapper ()
		{
			GC.KeepAlive (null);
		}
		/// <summary>Requests access to the content, and returns <see langword="true" /> if the contents are available and were successfully accessed. (Otherwise, returns <see langword="false" />.)</summary><returns><see langword="true" /> if the contents can be retrieved.</returns><remarks>To be added.</remarks>
		[Export ("beginContentAccess")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public bool BeginContentAccess ()
		{
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("beginContentAccess"));
			return ret != 0;
		}
		/// <summary>Indicates that access to the content is no longer needed.</summary><remarks>To be added.</remarks>
		[Export ("endContentAccess")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void EndContentAccess ()
		{
			global::ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, Selector.GetHandle ("endContentAccess"));
		}
		/// <summary>Discards the content if it is not being accessed.</summary><remarks>To be added.</remarks>
		[Export ("discardContentIfPossible")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void DiscardContentIfPossible ()
		{
			global::ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, Selector.GetHandle ("discardContentIfPossible"));
		}
		/// <summary>Gets a Boolean value that tells whether the content has been discarded.</summary><value><see langword="true" /> if the content has been discarded.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public bool IsContentDiscarded {
			[Export ("isContentDiscarded")]
			get {
				byte ret;
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("isContentDiscarded"));
				return ret != 0;
			}
		}
	}
}
