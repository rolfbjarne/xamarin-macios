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
using Metal;
using CoreML;
using AppKit;
using MapKit;
using Photos;
using ModelIO;
using Network;
using SceneKit;
using Contacts;
using Security;
using CloudKit;
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
using FileProvider;
using CoreAnimation;
using CoreFoundation;
using NetworkExtension;
using MetalPerformanceShadersGraph;
#nullable enable
namespace Contacts {
	#pragma warning disable CS1573
	/// <summary>This interface represents the Objective-C protocol <c>CNChangeHistoryEventVisitor</c>.</summary>
	/// <remarks>
	///   <para>A class that implements this interface (and subclasses <see cref="NSObject" />) will be exported to Objective-C as implementing the Objective-C protocol this interface represents.</para>
	///   <para>A class may also implement members from this interface to implement members from the protocol.</para>
	/// </remarks>
	[SupportedOSPlatform ("ios13.0")]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("macos")]
	[Protocol (Name = "CNChangeHistoryEventVisitor", WrapperType = typeof (CNChangeHistoryEventVisitorWrapper))]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "DropEverything", Selector = "visitDropEverythingEvent:", ParameterType = new Type [] { typeof (CNChangeHistoryDropEverythingEvent) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "AddContact", Selector = "visitAddContactEvent:", ParameterType = new Type [] { typeof (CNChangeHistoryAddContactEvent) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "UpdateContact", Selector = "visitUpdateContactEvent:", ParameterType = new Type [] { typeof (CNChangeHistoryUpdateContactEvent) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "DeleteContact", Selector = "visitDeleteContactEvent:", ParameterType = new Type [] { typeof (CNChangeHistoryDeleteContactEvent) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "AddGroup", Selector = "visitAddGroupEvent:", ParameterType = new Type [] { typeof (CNChangeHistoryAddGroupEvent) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "UpdateGroup", Selector = "visitUpdateGroupEvent:", ParameterType = new Type [] { typeof (CNChangeHistoryUpdateGroupEvent) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DeleteGroup", Selector = "visitDeleteGroupEvent:", ParameterType = new Type [] { typeof (CNChangeHistoryDeleteGroupEvent) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "AddMemberToGroup", Selector = "visitAddMemberToGroupEvent:", ParameterType = new Type [] { typeof (CNChangeHistoryAddMemberToGroupEvent) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "RemoveMemberFromGroup", Selector = "visitRemoveMemberFromGroupEvent:", ParameterType = new Type [] { typeof (CNChangeHistoryRemoveMemberFromGroupEvent) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "AddSubgroupToGroup", Selector = "visitAddSubgroupToGroupEvent:", ParameterType = new Type [] { typeof (CNChangeHistoryAddSubgroupToGroupEvent) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "RemoveSubgroupFromGroup", Selector = "visitRemoveSubgroupFromGroupEvent:", ParameterType = new Type [] { typeof (CNChangeHistoryRemoveSubgroupFromGroupEvent) }, ParameterByRef = new bool [] { false })]
	public partial interface ICNChangeHistoryEventVisitor : INativeObject, IDisposable
	{
		[global::Foundation.RequiredMember]
		[Export ("visitDropEverythingEvent:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DropEverything (CNChangeHistoryDropEverythingEvent @event)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _DropEverything (ICNChangeHistoryEventVisitor This, CNChangeHistoryDropEverythingEvent @event)
		{
			var @event__handle__ = @event!.GetNonNullHandle (nameof (@event));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("visitDropEverythingEvent:"), @event__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (@event);
		}
		[global::Foundation.RequiredMember]
		[Export ("visitAddContactEvent:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void AddContact (CNChangeHistoryAddContactEvent @event)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _AddContact (ICNChangeHistoryEventVisitor This, CNChangeHistoryAddContactEvent @event)
		{
			var @event__handle__ = @event!.GetNonNullHandle (nameof (@event));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("visitAddContactEvent:"), @event__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (@event);
		}
		[global::Foundation.RequiredMember]
		[Export ("visitUpdateContactEvent:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void UpdateContact (CNChangeHistoryUpdateContactEvent @event)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _UpdateContact (ICNChangeHistoryEventVisitor This, CNChangeHistoryUpdateContactEvent @event)
		{
			var @event__handle__ = @event!.GetNonNullHandle (nameof (@event));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("visitUpdateContactEvent:"), @event__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (@event);
		}
		[global::Foundation.RequiredMember]
		[Export ("visitDeleteContactEvent:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DeleteContact (CNChangeHistoryDeleteContactEvent @event)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _DeleteContact (ICNChangeHistoryEventVisitor This, CNChangeHistoryDeleteContactEvent @event)
		{
			var @event__handle__ = @event!.GetNonNullHandle (nameof (@event));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("visitDeleteContactEvent:"), @event__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (@event);
		}
		[global::Foundation.OptionalMember]
		[Export ("visitAddGroupEvent:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void AddGroup (CNChangeHistoryAddGroupEvent @event)
		{
			_AddGroup (this, @event);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _AddGroup (ICNChangeHistoryEventVisitor This, CNChangeHistoryAddGroupEvent @event)
		{
			var @event__handle__ = @event!.GetNonNullHandle (nameof (@event));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("visitAddGroupEvent:"), @event__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (@event);
		}
		[global::Foundation.OptionalMember]
		[Export ("visitUpdateGroupEvent:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void UpdateGroup (CNChangeHistoryUpdateGroupEvent @event)
		{
			_UpdateGroup (this, @event);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _UpdateGroup (ICNChangeHistoryEventVisitor This, CNChangeHistoryUpdateGroupEvent @event)
		{
			var @event__handle__ = @event!.GetNonNullHandle (nameof (@event));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("visitUpdateGroupEvent:"), @event__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (@event);
		}
		[global::Foundation.OptionalMember]
		[Export ("visitDeleteGroupEvent:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DeleteGroup (CNChangeHistoryDeleteGroupEvent @event)
		{
			_DeleteGroup (this, @event);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _DeleteGroup (ICNChangeHistoryEventVisitor This, CNChangeHistoryDeleteGroupEvent @event)
		{
			var @event__handle__ = @event!.GetNonNullHandle (nameof (@event));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("visitDeleteGroupEvent:"), @event__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (@event);
		}
		[global::Foundation.OptionalMember]
		[Export ("visitAddMemberToGroupEvent:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void AddMemberToGroup (CNChangeHistoryAddMemberToGroupEvent @event)
		{
			_AddMemberToGroup (this, @event);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _AddMemberToGroup (ICNChangeHistoryEventVisitor This, CNChangeHistoryAddMemberToGroupEvent @event)
		{
			var @event__handle__ = @event!.GetNonNullHandle (nameof (@event));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("visitAddMemberToGroupEvent:"), @event__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (@event);
		}
		[global::Foundation.OptionalMember]
		[Export ("visitRemoveMemberFromGroupEvent:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void RemoveMemberFromGroup (CNChangeHistoryRemoveMemberFromGroupEvent @event)
		{
			_RemoveMemberFromGroup (this, @event);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _RemoveMemberFromGroup (ICNChangeHistoryEventVisitor This, CNChangeHistoryRemoveMemberFromGroupEvent @event)
		{
			var @event__handle__ = @event!.GetNonNullHandle (nameof (@event));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("visitRemoveMemberFromGroupEvent:"), @event__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (@event);
		}
		[global::Foundation.OptionalMember]
		[Export ("visitAddSubgroupToGroupEvent:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void AddSubgroupToGroup (CNChangeHistoryAddSubgroupToGroupEvent @event)
		{
			_AddSubgroupToGroup (this, @event);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _AddSubgroupToGroup (ICNChangeHistoryEventVisitor This, CNChangeHistoryAddSubgroupToGroupEvent @event)
		{
			var @event__handle__ = @event!.GetNonNullHandle (nameof (@event));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("visitAddSubgroupToGroupEvent:"), @event__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (@event);
		}
		[global::Foundation.OptionalMember]
		[Export ("visitRemoveSubgroupFromGroupEvent:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void RemoveSubgroupFromGroup (CNChangeHistoryRemoveSubgroupFromGroupEvent @event)
		{
			_RemoveSubgroupFromGroup (this, @event);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _RemoveSubgroupFromGroup (ICNChangeHistoryEventVisitor This, CNChangeHistoryRemoveSubgroupFromGroupEvent @event)
		{
			var @event__handle__ = @event!.GetNonNullHandle (nameof (@event));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("visitRemoveSubgroupFromGroupEvent:"), @event__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (@event);
		}
		[DynamicDependencyAttribute ("AddContact(Contacts.CNChangeHistoryAddContactEvent)")]
		[DynamicDependencyAttribute ("AddGroup(Contacts.CNChangeHistoryAddGroupEvent)")]
		[DynamicDependencyAttribute ("AddMemberToGroup(Contacts.CNChangeHistoryAddMemberToGroupEvent)")]
		[DynamicDependencyAttribute ("AddSubgroupToGroup(Contacts.CNChangeHistoryAddSubgroupToGroupEvent)")]
		[DynamicDependencyAttribute ("DeleteContact(Contacts.CNChangeHistoryDeleteContactEvent)")]
		[DynamicDependencyAttribute ("DeleteGroup(Contacts.CNChangeHistoryDeleteGroupEvent)")]
		[DynamicDependencyAttribute ("DropEverything(Contacts.CNChangeHistoryDropEverythingEvent)")]
		[DynamicDependencyAttribute ("RemoveMemberFromGroup(Contacts.CNChangeHistoryRemoveMemberFromGroupEvent)")]
		[DynamicDependencyAttribute ("RemoveSubgroupFromGroup(Contacts.CNChangeHistoryRemoveSubgroupFromGroupEvent)")]
		[DynamicDependencyAttribute ("UpdateContact(Contacts.CNChangeHistoryUpdateContactEvent)")]
		[DynamicDependencyAttribute ("UpdateGroup(Contacts.CNChangeHistoryUpdateGroupEvent)")]
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.Interfaces | DynamicallyAccessedMemberTypes.PublicConstructors, typeof (CNChangeHistoryEventVisitorWrapper))]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static ICNChangeHistoryEventVisitor ()
		{
			GC.KeepAlive (null);
		}
	}
	#pragma warning restore CS1573
	#pragma warning disable CS1573
	/// <summary>Extension methods to the <see cref="ICNChangeHistoryEventVisitor" /> interface to support all the methods from the CNChangeHistoryEventVisitor protocol.</summary>
	/// <remarks>
	///   <para>The extension methods for <see cref="ICNChangeHistoryEventVisitor" /> interface allow developers to treat instances of the interface as having all the optional methods of the original CNChangeHistoryEventVisitor protocol. Since the interface only contains the required members, these extension methods allow developers to call the optional members of the protocol.</para>
	/// </remarks>
	public unsafe static partial class CNChangeHistoryEventVisitor_Extensions {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void AddGroup (this ICNChangeHistoryEventVisitor This, CNChangeHistoryAddGroupEvent @event)
		{
			var @event__handle__ = @event!.GetNonNullHandle (nameof (@event));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("visitAddGroupEvent:"), @event__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (@event);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void UpdateGroup (this ICNChangeHistoryEventVisitor This, CNChangeHistoryUpdateGroupEvent @event)
		{
			var @event__handle__ = @event!.GetNonNullHandle (nameof (@event));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("visitUpdateGroupEvent:"), @event__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (@event);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void DeleteGroup (this ICNChangeHistoryEventVisitor This, CNChangeHistoryDeleteGroupEvent @event)
		{
			var @event__handle__ = @event!.GetNonNullHandle (nameof (@event));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("visitDeleteGroupEvent:"), @event__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (@event);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void AddMemberToGroup (this ICNChangeHistoryEventVisitor This, CNChangeHistoryAddMemberToGroupEvent @event)
		{
			var @event__handle__ = @event!.GetNonNullHandle (nameof (@event));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("visitAddMemberToGroupEvent:"), @event__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (@event);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void RemoveMemberFromGroup (this ICNChangeHistoryEventVisitor This, CNChangeHistoryRemoveMemberFromGroupEvent @event)
		{
			var @event__handle__ = @event!.GetNonNullHandle (nameof (@event));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("visitRemoveMemberFromGroupEvent:"), @event__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (@event);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void AddSubgroupToGroup (this ICNChangeHistoryEventVisitor This, CNChangeHistoryAddSubgroupToGroupEvent @event)
		{
			var @event__handle__ = @event!.GetNonNullHandle (nameof (@event));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("visitAddSubgroupToGroupEvent:"), @event__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (@event);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void RemoveSubgroupFromGroup (this ICNChangeHistoryEventVisitor This, CNChangeHistoryRemoveSubgroupFromGroupEvent @event)
		{
			var @event__handle__ = @event!.GetNonNullHandle (nameof (@event));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("visitRemoveSubgroupFromGroupEvent:"), @event__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (@event);
		}
	}
	#pragma warning restore CS1573
	internal unsafe sealed class CNChangeHistoryEventVisitorWrapper : BaseWrapper, ICNChangeHistoryEventVisitor {
		public CNChangeHistoryEventVisitorWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.PublicConstructors, typeof (CNChangeHistoryEventVisitorWrapper))]
		static CNChangeHistoryEventVisitorWrapper ()
		{
			GC.KeepAlive (null);
		}
		[Export ("visitDropEverythingEvent:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void DropEverything (CNChangeHistoryDropEverythingEvent @event)
		{
			var @event__handle__ = @event!.GetNonNullHandle (nameof (@event));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("visitDropEverythingEvent:"), @event__handle__);
			GC.KeepAlive (@event);
		}
		[Export ("visitAddContactEvent:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void AddContact (CNChangeHistoryAddContactEvent @event)
		{
			var @event__handle__ = @event!.GetNonNullHandle (nameof (@event));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("visitAddContactEvent:"), @event__handle__);
			GC.KeepAlive (@event);
		}
		[Export ("visitUpdateContactEvent:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void UpdateContact (CNChangeHistoryUpdateContactEvent @event)
		{
			var @event__handle__ = @event!.GetNonNullHandle (nameof (@event));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("visitUpdateContactEvent:"), @event__handle__);
			GC.KeepAlive (@event);
		}
		[Export ("visitDeleteContactEvent:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void DeleteContact (CNChangeHistoryDeleteContactEvent @event)
		{
			var @event__handle__ = @event!.GetNonNullHandle (nameof (@event));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("visitDeleteContactEvent:"), @event__handle__);
			GC.KeepAlive (@event);
		}
	}
}
