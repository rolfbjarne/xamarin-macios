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
namespace Metal {
	#pragma warning disable CS1573
	/// <summary>This interface represents the Objective-C protocol <c>MTLResidencySet</c>.</summary>
	/// <remarks>
	///   <para>A class that implements this interface (and subclasses <see cref="NSObject" />) will be exported to Objective-C as implementing the Objective-C protocol this interface represents.</para>
	///   <para>A class may also implement members from this interface to implement members from the protocol.</para>
	/// </remarks>
	[SupportedOSPlatform ("macos15.0")]
	[SupportedOSPlatform ("ios18.0")]
	[SupportedOSPlatform ("maccatalyst18.0")]
	[SupportedOSPlatform ("tvos18.0")]
	[Protocol (Name = "MTLResidencySet", WrapperType = typeof (MTLResidencySetWrapper), BackwardsCompatibleCodeGeneration = false)]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "RequestResidency", Selector = "requestResidency")]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "EndResidency", Selector = "endResidency")]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "AddAllocation", Selector = "addAllocation:", ParameterType = new Type [] { typeof (IMTLAllocation) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "AddAllocations", Selector = "addAllocations:count:", ParameterType = new Type [] { typeof (IntPtr), typeof (UIntPtr) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "RemoveAllocation", Selector = "removeAllocation:", ParameterType = new Type [] { typeof (IMTLAllocation) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "RemoveAllocations", Selector = "removeAllocations:count:", ParameterType = new Type [] { typeof (IntPtr), typeof (UIntPtr) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "RemoveAllAllocations", Selector = "removeAllAllocations")]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "ContainsAllocation", Selector = "containsAllocation:", ReturnType = typeof (bool), ParameterType = new Type [] { typeof (IMTLAllocation) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "Commit", Selector = "commit")]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "Device", Selector = "device", PropertyType = typeof (IMTLDevice), GetterSelector = "device", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "Label", Selector = "label", PropertyType = typeof (string), GetterSelector = "label", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "AllocatedSize", Selector = "allocatedSize", PropertyType = typeof (ulong), GetterSelector = "allocatedSize", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "AllAllocations", Selector = "allAllocations", PropertyType = typeof (IMTLAllocation[]), GetterSelector = "allAllocations", ArgumentSemantic = ArgumentSemantic.Copy)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "AllocationCount", Selector = "allocationCount", PropertyType = typeof (UIntPtr), GetterSelector = "allocationCount", ArgumentSemantic = ArgumentSemantic.None)]
	public partial interface IMTLResidencySet : INativeObject, IDisposable
	{
		[global::Foundation.RequiredMember]
		[Export ("requestResidency")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void RequestResidency ()
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _RequestResidency (IMTLResidencySet This)
		{
			global::ObjCRuntime.Messaging.void_objc_msgSend (This.Handle, Selector.GetHandle ("requestResidency"));
			GC.KeepAlive (This);
		}
		[global::Foundation.RequiredMember]
		[Export ("endResidency")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void EndResidency ()
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _EndResidency (IMTLResidencySet This)
		{
			global::ObjCRuntime.Messaging.void_objc_msgSend (This.Handle, Selector.GetHandle ("endResidency"));
			GC.KeepAlive (This);
		}
		[global::Foundation.RequiredMember]
		[Export ("addAllocation:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void AddAllocation (IMTLAllocation allocation)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _AddAllocation (IMTLResidencySet This, IMTLAllocation allocation)
		{
			var allocation__handle__ = allocation!.GetNonNullHandle (nameof (allocation));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("addAllocation:"), allocation__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (allocation);
		}
		[global::Foundation.RequiredMember]
		[Export ("addAllocations:count:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void AddAllocations (nint allocations, nuint count)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _AddAllocations (IMTLResidencySet This, nint allocations, nuint count)
		{
			global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr_UIntPtr (This.Handle, Selector.GetHandle ("addAllocations:count:"), allocations, count);
			GC.KeepAlive (This);
		}
		[global::Foundation.RequiredMember]
		[Export ("removeAllocation:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void RemoveAllocation (IMTLAllocation allocation)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _RemoveAllocation (IMTLResidencySet This, IMTLAllocation allocation)
		{
			var allocation__handle__ = allocation!.GetNonNullHandle (nameof (allocation));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("removeAllocation:"), allocation__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (allocation);
		}
		[global::Foundation.RequiredMember]
		[Export ("removeAllocations:count:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void RemoveAllocations (nint allocations, nuint count)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _RemoveAllocations (IMTLResidencySet This, nint allocations, nuint count)
		{
			global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr_UIntPtr (This.Handle, Selector.GetHandle ("removeAllocations:count:"), allocations, count);
			GC.KeepAlive (This);
		}
		[global::Foundation.RequiredMember]
		[Export ("removeAllAllocations")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void RemoveAllAllocations ()
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _RemoveAllAllocations (IMTLResidencySet This)
		{
			global::ObjCRuntime.Messaging.void_objc_msgSend (This.Handle, Selector.GetHandle ("removeAllAllocations"));
			GC.KeepAlive (This);
		}
		[global::Foundation.RequiredMember]
		[Export ("containsAllocation:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool ContainsAllocation (IMTLAllocation allocation)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static bool _ContainsAllocation (IMTLResidencySet This, IMTLAllocation allocation)
		{
			var allocation__handle__ = allocation!.GetNonNullHandle (nameof (allocation));
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("containsAllocation:"), allocation__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (allocation);
			return ret != 0;
		}
		[global::Foundation.RequiredMember]
		[Export ("commit")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void Commit ()
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _Commit (IMTLResidencySet This)
		{
			global::ObjCRuntime.Messaging.void_objc_msgSend (This.Handle, Selector.GetHandle ("commit"));
			GC.KeepAlive (This);
		}
		[DynamicDependencyAttribute ("AddAllocation(Metal.IMTLAllocation)")]
		[DynamicDependencyAttribute ("AddAllocations(System.IntPtr,System.UIntPtr)")]
		[DynamicDependencyAttribute ("AllAllocations")]
		[DynamicDependencyAttribute ("AllocatedSize")]
		[DynamicDependencyAttribute ("AllocationCount")]
		[DynamicDependencyAttribute ("Commit()")]
		[DynamicDependencyAttribute ("ContainsAllocation(Metal.IMTLAllocation)")]
		[DynamicDependencyAttribute ("Device")]
		[DynamicDependencyAttribute ("EndResidency()")]
		[DynamicDependencyAttribute ("Label")]
		[DynamicDependencyAttribute ("RemoveAllAllocations()")]
		[DynamicDependencyAttribute ("RemoveAllocation(Metal.IMTLAllocation)")]
		[DynamicDependencyAttribute ("RemoveAllocations(System.IntPtr,System.UIntPtr)")]
		[DynamicDependencyAttribute ("RequestResidency()")]
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.Interfaces | DynamicallyAccessedMemberTypes.PublicConstructors, typeof (MTLResidencySetWrapper))]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static IMTLResidencySet ()
		{
			GC.KeepAlive (null);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual IMTLDevice Device {
			[Export ("device")]
			get {
				return _GetDevice (this);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static IMTLDevice _GetDevice (IMTLResidencySet This)
		{
			IMTLDevice ret;
			ret =  Runtime.GetINativeObject<IMTLDevice> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("device")), false)!;
			GC.KeepAlive (This);
			return ret;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual string? Label {
			[Export ("label")]
			get {
				return _GetLabel (this);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static string _GetLabel (IMTLResidencySet This)
		{
			string ret;
			ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("label")), false)!;
			GC.KeepAlive (This);
			return ret;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual ulong AllocatedSize {
			[Export ("allocatedSize")]
			get {
				return _GetAllocatedSize (this);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static ulong _GetAllocatedSize (IMTLResidencySet This)
		{
			ulong ret;
			ret = global::ObjCRuntime.Messaging.UInt64_objc_msgSend (This.Handle, Selector.GetHandle ("allocatedSize"));
			GC.KeepAlive (This);
			return ret;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual IMTLAllocation[] AllAllocations {
			[Export ("allAllocations", ArgumentSemantic.Copy)]
			get {
				return _GetAllAllocations (this);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static IMTLAllocation[] _GetAllAllocations (IMTLResidencySet This)
		{
			IMTLAllocation[] ret;
			ret = CFArray.ArrayFromHandle<IMTLAllocation>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("allAllocations")), false)!;
			GC.KeepAlive (This);
			return ret;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual nuint AllocationCount {
			[Export ("allocationCount")]
			get {
				return _GetAllocationCount (this);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static nuint _GetAllocationCount (IMTLResidencySet This)
		{
			nuint ret;
			ret = global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend (This.Handle, Selector.GetHandle ("allocationCount"));
			GC.KeepAlive (This);
			return ret;
		}
	}
	#pragma warning restore CS1573
	internal unsafe sealed class MTLResidencySetWrapper : BaseWrapper, IMTLResidencySet {
		public MTLResidencySetWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.PublicConstructors, typeof (MTLResidencySetWrapper))]
		static MTLResidencySetWrapper ()
		{
			GC.KeepAlive (null);
		}
		[Export ("requestResidency")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void RequestResidency ()
		{
			global::ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, Selector.GetHandle ("requestResidency"));
		}
		[Export ("endResidency")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void EndResidency ()
		{
			global::ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, Selector.GetHandle ("endResidency"));
		}
		[Export ("addAllocation:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void AddAllocation (IMTLAllocation allocation)
		{
			var allocation__handle__ = allocation!.GetNonNullHandle (nameof (allocation));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("addAllocation:"), allocation__handle__);
			GC.KeepAlive (allocation);
		}
		[Export ("addAllocations:count:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void AddAllocations (nint allocations, nuint count)
		{
			global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr_UIntPtr (this.Handle, Selector.GetHandle ("addAllocations:count:"), allocations, count);
		}
		[Export ("removeAllocation:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void RemoveAllocation (IMTLAllocation allocation)
		{
			var allocation__handle__ = allocation!.GetNonNullHandle (nameof (allocation));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("removeAllocation:"), allocation__handle__);
			GC.KeepAlive (allocation);
		}
		[Export ("removeAllocations:count:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void RemoveAllocations (nint allocations, nuint count)
		{
			global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr_UIntPtr (this.Handle, Selector.GetHandle ("removeAllocations:count:"), allocations, count);
		}
		[Export ("removeAllAllocations")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void RemoveAllAllocations ()
		{
			global::ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, Selector.GetHandle ("removeAllAllocations"));
		}
		[Export ("containsAllocation:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public bool ContainsAllocation (IMTLAllocation allocation)
		{
			var allocation__handle__ = allocation!.GetNonNullHandle (nameof (allocation));
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("containsAllocation:"), allocation__handle__);
			GC.KeepAlive (allocation);
			return ret != 0;
		}
		[Export ("commit")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void Commit ()
		{
			global::ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, Selector.GetHandle ("commit"));
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public IMTLDevice Device {
			[Export ("device")]
			get {
				IMTLDevice ret;
				ret =  Runtime.GetINativeObject<IMTLDevice> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("device")), false)!;
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public string? Label {
			[Export ("label")]
			get {
				string ret;
				ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("label")), false)!;
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public ulong AllocatedSize {
			[Export ("allocatedSize")]
			get {
				ulong ret;
				ret = global::ObjCRuntime.Messaging.UInt64_objc_msgSend (this.Handle, Selector.GetHandle ("allocatedSize"));
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public IMTLAllocation[] AllAllocations {
			[Export ("allAllocations", ArgumentSemantic.Copy)]
			get {
				IMTLAllocation[] ret;
				ret = CFArray.ArrayFromHandle<IMTLAllocation>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("allAllocations")), false)!;
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public nuint AllocationCount {
			[Export ("allocationCount")]
			get {
				nuint ret;
				ret = global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("allocationCount"));
				return ret;
			}
		}
	}
}
