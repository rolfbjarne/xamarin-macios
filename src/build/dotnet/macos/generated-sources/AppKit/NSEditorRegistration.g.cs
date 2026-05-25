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
	/// <summary>This interface represents the Objective-C protocol <c>NSEditorRegistration</c>.</summary>
	/// <remarks>
	///   <para>A class that implements this interface (and subclasses <see cref="NSObject" />) will be exported to Objective-C as implementing the Objective-C protocol this interface represents.</para>
	///   <para>A class may also implement members from this interface to implement members from the protocol.</para>
	/// </remarks>
	[UnsupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("macos")]
	[Protocol (Name = "NSEditorRegistration", WrapperType = typeof (NSEditorRegistrationWrapper))]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "ObjectDidBeginEditing", Selector = "objectDidBeginEditing:", ParameterType = new Type [] { typeof (INSEditor) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "ObjectDidEndEditing", Selector = "objectDidEndEditing:", ParameterType = new Type [] { typeof (INSEditor) }, ParameterByRef = new bool [] { false })]
	public partial interface INSEditorRegistration : INativeObject, IDisposable
	{
		/// <param name="editor">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("objectDidBeginEditing:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void ObjectDidBeginEditing (INSEditor editor)
		{
			_ObjectDidBeginEditing (this, editor);
		}
		/// <param name="editor">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _ObjectDidBeginEditing (INSEditorRegistration This, INSEditor editor)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var editor__handle__ = editor!.GetNonNullHandle (nameof (editor));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("objectDidBeginEditing:"), editor__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (editor);
		}
		/// <param name="editor">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("objectDidEndEditing:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void ObjectDidEndEditing (INSEditor editor)
		{
			_ObjectDidEndEditing (this, editor);
		}
		/// <param name="editor">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _ObjectDidEndEditing (INSEditorRegistration This, INSEditor editor)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var editor__handle__ = editor!.GetNonNullHandle (nameof (editor));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("objectDidEndEditing:"), editor__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (editor);
		}
		[DynamicDependencyAttribute ("ObjectDidBeginEditing(AppKit.INSEditor)")]
		[DynamicDependencyAttribute ("ObjectDidEndEditing(AppKit.INSEditor)")]
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.Interfaces | DynamicallyAccessedMemberTypes.PublicConstructors, typeof (NSEditorRegistrationWrapper))]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static INSEditorRegistration ()
		{
			GC.KeepAlive (null);
		}
	}
	#pragma warning restore CS1573
	#pragma warning disable CS1573
	/// <summary>Extension methods to the <see cref="INSEditorRegistration" /> interface to support all the methods from the NSEditorRegistration protocol.</summary>
	/// <remarks>
	///   <para>The extension methods for <see cref="INSEditorRegistration" /> interface allow developers to treat instances of the interface as having all the optional methods of the original NSEditorRegistration protocol. Since the interface only contains the required members, these extension methods allow developers to call the optional members of the protocol.</para>
	/// </remarks>
	public unsafe static partial class NSEditorRegistration_Extensions {
		/// <param name="editor">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void ObjectDidBeginEditing (this INSEditorRegistration This, INSEditor editor)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var editor__handle__ = editor!.GetNonNullHandle (nameof (editor));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("objectDidBeginEditing:"), editor__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (editor);
		}
		/// <param name="editor">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void ObjectDidEndEditing (this INSEditorRegistration This, INSEditor editor)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var editor__handle__ = editor!.GetNonNullHandle (nameof (editor));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("objectDidEndEditing:"), editor__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (editor);
		}
	}
	#pragma warning restore CS1573
	internal unsafe sealed class NSEditorRegistrationWrapper : BaseWrapper, INSEditorRegistration {
		public NSEditorRegistrationWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.PublicConstructors, typeof (NSEditorRegistrationWrapper))]
		static NSEditorRegistrationWrapper ()
		{
			GC.KeepAlive (null);
		}
	}
}
