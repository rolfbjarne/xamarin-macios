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
namespace SharedWithYouCore {
	#pragma warning disable CS1573
	/// <summary>This interface represents the Objective-C protocol <c>SWCollaborationActionHandler</c>.</summary>
	/// <remarks>
	///   <para>A class that implements this interface (and subclasses <see cref="NSObject" />) will be exported to Objective-C as implementing the Objective-C protocol this interface represents.</para>
	///   <para>A class may also implement members from this interface to implement members from the protocol.</para>
	/// </remarks>
	[UnsupportedOSPlatform ("tvos")]
	[SupportedOSPlatform ("macos13.0")]
	[SupportedOSPlatform ("ios16.0")]
	[SupportedOSPlatform ("maccatalyst16.0")]
	[Protocol (Name = "SWCollaborationActionHandler", WrapperType = typeof (SWCollaborationActionHandlerWrapper))]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "HandleStartCollaborationAction", Selector = "collaborationCoordinator:handleStartCollaborationAction:", ParameterType = new Type [] { typeof (SharedWithYouCore.SWCollaborationCoordinator), typeof (SharedWithYouCore.SWStartCollaborationAction) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "HandleUpdateCollaborationParticipantsAction", Selector = "collaborationCoordinator:handleUpdateCollaborationParticipantsAction:", ParameterType = new Type [] { typeof (SharedWithYouCore.SWCollaborationCoordinator), typeof (SharedWithYouCore.SWUpdateCollaborationParticipantsAction) }, ParameterByRef = new bool [] { false, false })]
	public partial interface ISWCollaborationActionHandler : INativeObject, IDisposable
	{
		[global::Foundation.RequiredMember]
		[Export ("collaborationCoordinator:handleStartCollaborationAction:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void HandleStartCollaborationAction (SWCollaborationCoordinator coordinator, SWStartCollaborationAction action)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _HandleStartCollaborationAction (ISWCollaborationActionHandler This, SWCollaborationCoordinator coordinator, SWStartCollaborationAction action)
		{
			var coordinator__handle__ = coordinator!.GetNonNullHandle (nameof (coordinator));
			var action__handle__ = action!.GetNonNullHandle (nameof (action));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("collaborationCoordinator:handleStartCollaborationAction:"), coordinator__handle__, action__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (coordinator);
			GC.KeepAlive (action);
		}
		[global::Foundation.RequiredMember]
		[Export ("collaborationCoordinator:handleUpdateCollaborationParticipantsAction:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void HandleUpdateCollaborationParticipantsAction (SWCollaborationCoordinator coordinator, SWUpdateCollaborationParticipantsAction action)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _HandleUpdateCollaborationParticipantsAction (ISWCollaborationActionHandler This, SWCollaborationCoordinator coordinator, SWUpdateCollaborationParticipantsAction action)
		{
			var coordinator__handle__ = coordinator!.GetNonNullHandle (nameof (coordinator));
			var action__handle__ = action!.GetNonNullHandle (nameof (action));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("collaborationCoordinator:handleUpdateCollaborationParticipantsAction:"), coordinator__handle__, action__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (coordinator);
			GC.KeepAlive (action);
		}
		[DynamicDependencyAttribute ("HandleStartCollaborationAction(SharedWithYouCore.SWCollaborationCoordinator,SharedWithYouCore.SWStartCollaborationAction)")]
		[DynamicDependencyAttribute ("HandleUpdateCollaborationParticipantsAction(SharedWithYouCore.SWCollaborationCoordinator,SharedWithYouCore.SWUpdateCollaborationParticipantsAction)")]
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.Interfaces | DynamicallyAccessedMemberTypes.PublicConstructors, typeof (SWCollaborationActionHandlerWrapper))]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static ISWCollaborationActionHandler ()
		{
			GC.KeepAlive (null);
		}
	}
	#pragma warning restore CS1573
	internal unsafe sealed class SWCollaborationActionHandlerWrapper : BaseWrapper, ISWCollaborationActionHandler {
		public SWCollaborationActionHandlerWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.PublicConstructors, typeof (SWCollaborationActionHandlerWrapper))]
		static SWCollaborationActionHandlerWrapper ()
		{
			GC.KeepAlive (null);
		}
		[Export ("collaborationCoordinator:handleStartCollaborationAction:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void HandleStartCollaborationAction (SWCollaborationCoordinator coordinator, SWStartCollaborationAction action)
		{
			var coordinator__handle__ = coordinator!.GetNonNullHandle (nameof (coordinator));
			var action__handle__ = action!.GetNonNullHandle (nameof (action));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("collaborationCoordinator:handleStartCollaborationAction:"), coordinator__handle__, action__handle__);
			GC.KeepAlive (coordinator);
			GC.KeepAlive (action);
		}
		[Export ("collaborationCoordinator:handleUpdateCollaborationParticipantsAction:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void HandleUpdateCollaborationParticipantsAction (SWCollaborationCoordinator coordinator, SWUpdateCollaborationParticipantsAction action)
		{
			var coordinator__handle__ = coordinator!.GetNonNullHandle (nameof (coordinator));
			var action__handle__ = action!.GetNonNullHandle (nameof (action));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("collaborationCoordinator:handleUpdateCollaborationParticipantsAction:"), coordinator__handle__, action__handle__);
			GC.KeepAlive (coordinator);
			GC.KeepAlive (action);
		}
	}
}
