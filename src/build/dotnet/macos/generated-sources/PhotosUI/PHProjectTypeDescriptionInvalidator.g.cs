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
namespace PhotosUI {
	#pragma warning disable CS1573
	/// <summary>This interface represents the Objective-C protocol <c>PHProjectTypeDescriptionInvalidator</c>.</summary>
	/// <remarks>
	///   <para>A class that implements this interface (and subclasses <see cref="NSObject" />) will be exported to Objective-C as implementing the Objective-C protocol this interface represents.</para>
	///   <para>A class may also implement members from this interface to implement members from the protocol.</para>
	/// </remarks>
	[UnsupportedOSPlatform ("ios")]
	[UnsupportedOSPlatform ("tvos")]
	[UnsupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("macos")]
	[Protocol (Name = "PHProjectTypeDescriptionInvalidator", WrapperType = typeof (PHProjectTypeDescriptionInvalidatorWrapper))]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "InvalidateTypeDescription", Selector = "invalidateTypeDescriptionForProjectType:", ParameterType = new Type [] { typeof (NSString) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "InvalidateFooterTextForSubtypes", Selector = "invalidateFooterTextForSubtypesOfProjectType:", ParameterType = new Type [] { typeof (NSString) }, ParameterByRef = new bool [] { false })]
	public partial interface IPHProjectTypeDescriptionInvalidator : INativeObject, IDisposable
	{
		/// <param name="projectType">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[global::Foundation.RequiredMember]
		[Export ("invalidateTypeDescriptionForProjectType:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void InvalidateTypeDescription (NSString projectType)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="projectType">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _InvalidateTypeDescription (IPHProjectTypeDescriptionInvalidator This, NSString projectType)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var projectType__handle__ = projectType!.GetNonNullHandle (nameof (projectType));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("invalidateTypeDescriptionForProjectType:"), projectType__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (projectType);
		}
		/// <param name="projectType">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[global::Foundation.RequiredMember]
		[Export ("invalidateFooterTextForSubtypesOfProjectType:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void InvalidateFooterTextForSubtypes (NSString projectType)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="projectType">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _InvalidateFooterTextForSubtypes (IPHProjectTypeDescriptionInvalidator This, NSString projectType)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var projectType__handle__ = projectType!.GetNonNullHandle (nameof (projectType));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("invalidateFooterTextForSubtypesOfProjectType:"), projectType__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (projectType);
		}
		[DynamicDependencyAttribute ("InvalidateFooterTextForSubtypes(Foundation.NSString)")]
		[DynamicDependencyAttribute ("InvalidateTypeDescription(Foundation.NSString)")]
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.Interfaces | DynamicallyAccessedMemberTypes.PublicConstructors, typeof (PHProjectTypeDescriptionInvalidatorWrapper))]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static IPHProjectTypeDescriptionInvalidator ()
		{
			GC.KeepAlive (null);
		}
	}
	#pragma warning restore CS1573
	internal unsafe sealed class PHProjectTypeDescriptionInvalidatorWrapper : BaseWrapper, IPHProjectTypeDescriptionInvalidator {
		public PHProjectTypeDescriptionInvalidatorWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.PublicConstructors, typeof (PHProjectTypeDescriptionInvalidatorWrapper))]
		static PHProjectTypeDescriptionInvalidatorWrapper ()
		{
			GC.KeepAlive (null);
		}
		/// <param name="projectType">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("invalidateTypeDescriptionForProjectType:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void InvalidateTypeDescription (NSString projectType)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var projectType__handle__ = projectType!.GetNonNullHandle (nameof (projectType));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("invalidateTypeDescriptionForProjectType:"), projectType__handle__);
			GC.KeepAlive (projectType);
		}
		/// <param name="projectType">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("invalidateFooterTextForSubtypesOfProjectType:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void InvalidateFooterTextForSubtypes (NSString projectType)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var projectType__handle__ = projectType!.GetNonNullHandle (nameof (projectType));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("invalidateFooterTextForSubtypesOfProjectType:"), projectType__handle__);
			GC.KeepAlive (projectType);
		}
	}
}
