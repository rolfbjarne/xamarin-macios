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
	/// <summary>This interface represents the Objective-C protocol <c>NSEditor</c>.</summary>
	/// <remarks>
	///   <para>A class that implements this interface (and subclasses <see cref="NSObject" />) will be exported to Objective-C as implementing the Objective-C protocol this interface represents.</para>
	///   <para>A class may also implement members from this interface to implement members from the protocol.</para>
	/// </remarks>
	[UnsupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("macos")]
	[Protocol (Name = "NSEditor", WrapperType = typeof (NSEditorWrapper))]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "DiscardEditing", Selector = "discardEditing")]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "CommitEditing", Selector = "commitEditing", ReturnType = typeof (bool))]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "CommitEditing", Selector = "commitEditingWithDelegate:didCommitSelector:contextInfo:", ParameterType = new Type [] { typeof (NSObject), typeof (Selector), typeof (IntPtr) }, ParameterByRef = new bool [] { false, false, false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "CommitEditing", Selector = "commitEditingAndReturnError:", ReturnType = typeof (bool), ParameterType = new Type [] { typeof (NSError) }, ParameterByRef = new bool [] { true })]
	public partial interface INSEditor : INativeObject, IDisposable
	{
		/// <summary>To be added.</summary><remarks>To be added.</remarks>
		[global::Foundation.RequiredMember]
		[Export ("discardEditing")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DiscardEditing ()
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _DiscardEditing (INSEditor This)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			global::ObjCRuntime.Messaging.void_objc_msgSend (This.Handle, Selector.GetHandle ("discardEditing"));
			GC.KeepAlive (This);
		}
		/// <summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.RequiredMember]
		[Export ("commitEditing")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool CommitEditing ()
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static bool _CommitEditing (INSEditor This)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (This.Handle, Selector.GetHandle ("commitEditing"));
			GC.KeepAlive (This);
			return ret != 0;
		}
		/// <param name="delegateObject">To be added.</param><param name="didCommitSelector">To be added.</param><param name="contextInfo">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[global::Foundation.RequiredMember]
		[Export ("commitEditingWithDelegate:didCommitSelector:contextInfo:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void CommitEditing (NSObject? delegateObject, Selector? didCommitSelector, nint contextInfo)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="delegateObject">To be added.</param><param name="didCommitSelector">To be added.</param><param name="contextInfo">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _CommitEditing (INSEditor This, NSObject? delegateObject, Selector? didCommitSelector, nint contextInfo)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var delegateObject__handle__ = delegateObject.GetHandle ();
			var didCommitSelector__handle__ = didCommitSelector.GetHandle ();
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_IntPtr (This.Handle, Selector.GetHandle ("commitEditingWithDelegate:didCommitSelector:contextInfo:"), delegateObject__handle__, didCommitSelector__handle__, contextInfo);
			GC.KeepAlive (This);
			GC.KeepAlive (delegateObject);
			GC.KeepAlive (didCommitSelector);
		}
		/// <param name="error">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.RequiredMember]
		[Export ("commitEditingAndReturnError:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual bool CommitEditing (out NSError? error)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="error">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal unsafe static bool _CommitEditing (INSEditor This, out NSError? error)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			NativeHandle errorValue = IntPtr.Zero;
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_ref_NativeHandle (This.Handle, Selector.GetHandle ("commitEditingAndReturnError:"), &errorValue);
			GC.KeepAlive (This);
			error = Runtime.GetNSObject<NSError> (errorValue)!;
			return ret != 0;
		}
		[DynamicDependencyAttribute ("CommitEditing()")]
		[DynamicDependencyAttribute ("CommitEditing(Foundation.NSError@)")]
		[DynamicDependencyAttribute ("CommitEditing(Foundation.NSObject,ObjCRuntime.Selector,System.IntPtr)")]
		[DynamicDependencyAttribute ("DiscardEditing()")]
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.Interfaces | DynamicallyAccessedMemberTypes.PublicConstructors, typeof (NSEditorWrapper))]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static INSEditor ()
		{
			GC.KeepAlive (null);
		}
	}
	#pragma warning restore CS1573
	internal unsafe sealed class NSEditorWrapper : BaseWrapper, INSEditor {
		public NSEditorWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.PublicConstructors, typeof (NSEditorWrapper))]
		static NSEditorWrapper ()
		{
			GC.KeepAlive (null);
		}
		/// <summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("discardEditing")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void DiscardEditing ()
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			global::ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, Selector.GetHandle ("discardEditing"));
		}
		/// <summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("commitEditing")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public bool CommitEditing ()
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("commitEditing"));
			return ret != 0;
		}
		/// <param name="delegateObject">To be added.</param><param name="didCommitSelector">To be added.</param><param name="contextInfo">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("commitEditingWithDelegate:didCommitSelector:contextInfo:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void CommitEditing (NSObject? delegateObject, Selector? didCommitSelector, nint contextInfo)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var delegateObject__handle__ = delegateObject.GetHandle ();
			var didCommitSelector__handle__ = didCommitSelector.GetHandle ();
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_IntPtr (this.Handle, Selector.GetHandle ("commitEditingWithDelegate:didCommitSelector:contextInfo:"), delegateObject__handle__, didCommitSelector__handle__, contextInfo);
			GC.KeepAlive (delegateObject);
			GC.KeepAlive (didCommitSelector);
		}
		/// <param name="error">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("commitEditingAndReturnError:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe bool CommitEditing (out NSError? error)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			NativeHandle errorValue = IntPtr.Zero;
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_ref_NativeHandle (this.Handle, Selector.GetHandle ("commitEditingAndReturnError:"), &errorValue);
			error = Runtime.GetNSObject<NSError> (errorValue)!;
			return ret != 0;
		}
	}
}
