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
	/// <summary>This interface represents the Objective-C protocol <c>MTLIntersectionFunctionTable</c>.</summary>
	/// <remarks>
	///   <para>A class that implements this interface (and subclasses <see cref="NSObject" />) will be exported to Objective-C as implementing the Objective-C protocol this interface represents.</para>
	///   <para>A class may also implement members from this interface to implement members from the protocol.</para>
	/// </remarks>
	[SupportedOSPlatform ("ios14.0")]
	[SupportedOSPlatform ("tvos16.0")]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("macos")]
	[Protocol (Name = "MTLIntersectionFunctionTable", WrapperType = typeof (MTLIntersectionFunctionTableWrapper))]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "SetBuffer", Selector = "setBuffer:offset:atIndex:", ParameterType = new Type [] { typeof (IMTLBuffer), typeof (UIntPtr), typeof (UIntPtr) }, ParameterByRef = new bool [] { false, false, false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "SetBuffers", Selector = "setBuffers:offsets:withRange:", ParameterType = new Type [] { typeof (IntPtr), typeof (IntPtr), typeof (NSRange) }, ParameterByRef = new bool [] { false, false, false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "SetFunction", Selector = "setFunction:atIndex:", ParameterType = new Type [] { typeof (IMTLFunctionHandle), typeof (UIntPtr) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "SetFunctions", Selector = "setFunctions:withRange:", ParameterType = new Type [] { typeof (IMTLFunctionHandle[]), typeof (NSRange) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "SetOpaqueTriangleIntersectionFunction", Selector = "setOpaqueTriangleIntersectionFunctionWithSignature:atIndex:", ParameterType = new Type [] { typeof (MTLIntersectionFunctionSignature), typeof (UIntPtr) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "SetOpaqueTriangleIntersectionFunction", Selector = "setOpaqueTriangleIntersectionFunctionWithSignature:withRange:", ParameterType = new Type [] { typeof (MTLIntersectionFunctionSignature), typeof (NSRange) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "SetVisibleFunctionTable", Selector = "setVisibleFunctionTable:atBufferIndex:", ParameterType = new Type [] { typeof (IMTLVisibleFunctionTable), typeof (UIntPtr) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "SetVisibleFunctionTables", Selector = "setVisibleFunctionTables:withBufferRange:", ParameterType = new Type [] { typeof (IMTLVisibleFunctionTable[]), typeof (NSRange) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "SetOpaqueCurveIntersectionFunction", Selector = "setOpaqueCurveIntersectionFunctionWithSignature:atIndex:", ParameterType = new Type [] { typeof (MTLIntersectionFunctionSignature), typeof (UIntPtr) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "SetOpaqueCurveIntersectionFunction", Selector = "setOpaqueCurveIntersectionFunctionWithSignature:withRange:", ParameterType = new Type [] { typeof (MTLIntersectionFunctionSignature), typeof (NSRange) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "GpuResourceId", Selector = "gpuResourceID", PropertyType = typeof (MTLResourceId), GetterSelector = "gpuResourceID", ArgumentSemantic = ArgumentSemantic.None)]
	public partial interface IMTLIntersectionFunctionTable : INativeObject, IDisposable, 
		Metal.IMTLAllocation
		, Metal.IMTLResource
	{
		[global::Foundation.RequiredMember]
		[Export ("setBuffer:offset:atIndex:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetBuffer (IMTLBuffer? buffer, nuint offset, nuint index)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SetBuffer (IMTLIntersectionFunctionTable This, IMTLBuffer? buffer, nuint offset, nuint index)
		{
			var buffer__handle__ = buffer.GetHandle ();
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_UIntPtr_UIntPtr (This.Handle, Selector.GetHandle ("setBuffer:offset:atIndex:"), buffer__handle__, offset, index);
			GC.KeepAlive (This);
			GC.KeepAlive (buffer);
		}
		[global::Foundation.RequiredMember]
		[Export ("setBuffers:offsets:withRange:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetBuffers (nint buffers, nint offsets, NSRange range)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SetBuffers (IMTLIntersectionFunctionTable This, nint buffers, nint offsets, NSRange range)
		{
			global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr_IntPtr_NSRange (This.Handle, Selector.GetHandle ("setBuffers:offsets:withRange:"), buffers, offsets, range);
			GC.KeepAlive (This);
		}
		[global::Foundation.RequiredMember]
		[Export ("setFunction:atIndex:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetFunction (IMTLFunctionHandle? function, nuint index)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SetFunction (IMTLIntersectionFunctionTable This, IMTLFunctionHandle? function, nuint index)
		{
			var function__handle__ = function.GetHandle ();
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_UIntPtr (This.Handle, Selector.GetHandle ("setFunction:atIndex:"), function__handle__, index);
			GC.KeepAlive (This);
			GC.KeepAlive (function);
		}
		[global::Foundation.RequiredMember]
		[Export ("setFunctions:withRange:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetFunctions (IMTLFunctionHandle[] functions, NSRange range)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SetFunctions (IMTLIntersectionFunctionTable This, IMTLFunctionHandle[] functions, NSRange range)
		{
			if (functions is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (functions));
			using var nsa_functions = NSArray.FromNSObjects (functions);
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NSRange (This.Handle, Selector.GetHandle ("setFunctions:withRange:"), nsa_functions.Handle, range);
			GC.KeepAlive (This);
		}
		[global::Foundation.RequiredMember]
		[Export ("setOpaqueTriangleIntersectionFunctionWithSignature:atIndex:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetOpaqueTriangleIntersectionFunction (MTLIntersectionFunctionSignature signature, nuint index)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SetOpaqueTriangleIntersectionFunction (IMTLIntersectionFunctionTable This, MTLIntersectionFunctionSignature signature, nuint index)
		{
			global::ObjCRuntime.Messaging.void_objc_msgSend_UIntPtr_UIntPtr (This.Handle, Selector.GetHandle ("setOpaqueTriangleIntersectionFunctionWithSignature:atIndex:"), (UIntPtr) (ulong) signature, index);
			GC.KeepAlive (This);
		}
		[global::Foundation.RequiredMember]
		[Export ("setOpaqueTriangleIntersectionFunctionWithSignature:withRange:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetOpaqueTriangleIntersectionFunction (MTLIntersectionFunctionSignature signature, NSRange range)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SetOpaqueTriangleIntersectionFunction (IMTLIntersectionFunctionTable This, MTLIntersectionFunctionSignature signature, NSRange range)
		{
			global::ObjCRuntime.Messaging.void_objc_msgSend_UIntPtr_NSRange (This.Handle, Selector.GetHandle ("setOpaqueTriangleIntersectionFunctionWithSignature:withRange:"), (UIntPtr) (ulong) signature, range);
			GC.KeepAlive (This);
		}
		[global::Foundation.RequiredMember]
		[Export ("setVisibleFunctionTable:atBufferIndex:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetVisibleFunctionTable (IMTLVisibleFunctionTable? functionTable, nuint bufferIndex)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SetVisibleFunctionTable (IMTLIntersectionFunctionTable This, IMTLVisibleFunctionTable? functionTable, nuint bufferIndex)
		{
			var functionTable__handle__ = functionTable.GetHandle ();
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_UIntPtr (This.Handle, Selector.GetHandle ("setVisibleFunctionTable:atBufferIndex:"), functionTable__handle__, bufferIndex);
			GC.KeepAlive (This);
			GC.KeepAlive (functionTable);
		}
		[global::Foundation.RequiredMember]
		[Export ("setVisibleFunctionTables:withBufferRange:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetVisibleFunctionTables (IMTLVisibleFunctionTable[] functionTables, NSRange bufferRange)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SetVisibleFunctionTables (IMTLIntersectionFunctionTable This, IMTLVisibleFunctionTable[] functionTables, NSRange bufferRange)
		{
			if (functionTables is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (functionTables));
			using var nsa_functionTables = NSArray.FromNSObjects (functionTables);
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NSRange (This.Handle, Selector.GetHandle ("setVisibleFunctionTables:withBufferRange:"), nsa_functionTables.Handle, bufferRange);
			GC.KeepAlive (This);
		}
		[global::Foundation.RequiredMember]
		[Export ("setOpaqueCurveIntersectionFunctionWithSignature:atIndex:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetOpaqueCurveIntersectionFunction (MTLIntersectionFunctionSignature signature, nuint index)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SetOpaqueCurveIntersectionFunction (IMTLIntersectionFunctionTable This, MTLIntersectionFunctionSignature signature, nuint index)
		{
			global::ObjCRuntime.Messaging.void_objc_msgSend_UIntPtr_UIntPtr (This.Handle, Selector.GetHandle ("setOpaqueCurveIntersectionFunctionWithSignature:atIndex:"), (UIntPtr) (ulong) signature, index);
			GC.KeepAlive (This);
		}
		[global::Foundation.RequiredMember]
		[Export ("setOpaqueCurveIntersectionFunctionWithSignature:withRange:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetOpaqueCurveIntersectionFunction (MTLIntersectionFunctionSignature signature, NSRange range)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SetOpaqueCurveIntersectionFunction (IMTLIntersectionFunctionTable This, MTLIntersectionFunctionSignature signature, NSRange range)
		{
			global::ObjCRuntime.Messaging.void_objc_msgSend_UIntPtr_NSRange (This.Handle, Selector.GetHandle ("setOpaqueCurveIntersectionFunctionWithSignature:withRange:"), (UIntPtr) (ulong) signature, range);
			GC.KeepAlive (This);
		}
		[DynamicDependencyAttribute ("GpuResourceId")]
		[DynamicDependencyAttribute ("SetBuffer(Metal.IMTLBuffer,System.UIntPtr,System.UIntPtr)")]
		[DynamicDependencyAttribute ("SetBuffers(System.IntPtr,System.IntPtr,Foundation.NSRange)")]
		[DynamicDependencyAttribute ("SetFunction(Metal.IMTLFunctionHandle,System.UIntPtr)")]
		[DynamicDependencyAttribute ("SetFunctions(Metal.IMTLFunctionHandle[],Foundation.NSRange)")]
		[DynamicDependencyAttribute ("SetOpaqueCurveIntersectionFunction(Metal.MTLIntersectionFunctionSignature,Foundation.NSRange)")]
		[DynamicDependencyAttribute ("SetOpaqueCurveIntersectionFunction(Metal.MTLIntersectionFunctionSignature,System.UIntPtr)")]
		[DynamicDependencyAttribute ("SetOpaqueTriangleIntersectionFunction(Metal.MTLIntersectionFunctionSignature,Foundation.NSRange)")]
		[DynamicDependencyAttribute ("SetOpaqueTriangleIntersectionFunction(Metal.MTLIntersectionFunctionSignature,System.UIntPtr)")]
		[DynamicDependencyAttribute ("SetVisibleFunctionTable(Metal.IMTLVisibleFunctionTable,System.UIntPtr)")]
		[DynamicDependencyAttribute ("SetVisibleFunctionTables(Metal.IMTLVisibleFunctionTable[],Foundation.NSRange)")]
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.Interfaces | DynamicallyAccessedMemberTypes.PublicConstructors, typeof (MTLIntersectionFunctionTableWrapper))]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static IMTLIntersectionFunctionTable ()
		{
			GC.KeepAlive (null);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("macos13.0")]
		[SupportedOSPlatform ("ios16.0")]
		[SupportedOSPlatform ("tvos16.0")]
		[SupportedOSPlatform ("maccatalyst16.0")]
		[global::Foundation.RequiredMember]
		public virtual MTLResourceId GpuResourceId {
			[Export ("gpuResourceID")]
			get {
				return _GetGpuResourceId (this);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static MTLResourceId _GetGpuResourceId (IMTLIntersectionFunctionTable This)
		{
			MTLResourceId ret;
			ret = global::ObjCRuntime.Messaging.MTLResourceId_objc_msgSend (This.Handle, Selector.GetHandle ("gpuResourceID"));
			GC.KeepAlive (This);
			return ret;
		}
	}
	#pragma warning restore CS1573
	#pragma warning disable CS1573
	/// <summary>Extension methods to the <see cref="IMTLIntersectionFunctionTable" /> interface to support all the methods from the MTLIntersectionFunctionTable protocol.</summary>
	/// <remarks>
	///   <para>The extension methods for <see cref="IMTLIntersectionFunctionTable" /> interface allow developers to treat instances of the interface as having all the optional methods of the original MTLIntersectionFunctionTable protocol. Since the interface only contains the required members, these extension methods allow developers to call the optional members of the protocol.</para>
	/// </remarks>
	public unsafe static partial class MTLIntersectionFunctionTable_Extensions {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void SetOpaqueCurveIntersectionFunction (this IMTLIntersectionFunctionTable This, MTLIntersectionFunctionSignature signature, nuint index)
		{
			global::ObjCRuntime.Messaging.void_objc_msgSend_UIntPtr_UIntPtr (This.Handle, Selector.GetHandle ("setOpaqueCurveIntersectionFunctionWithSignature:atIndex:"), (UIntPtr) (ulong) signature, index);
			GC.KeepAlive (This);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void SetOpaqueCurveIntersectionFunction (this IMTLIntersectionFunctionTable This, MTLIntersectionFunctionSignature signature, NSRange range)
		{
			global::ObjCRuntime.Messaging.void_objc_msgSend_UIntPtr_NSRange (This.Handle, Selector.GetHandle ("setOpaqueCurveIntersectionFunctionWithSignature:withRange:"), (UIntPtr) (ulong) signature, range);
			GC.KeepAlive (This);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MTLResourceId GetGpuResourceId (this IMTLIntersectionFunctionTable This)
		{
			MTLResourceId ret;
			ret = global::ObjCRuntime.Messaging.MTLResourceId_objc_msgSend (This.Handle, Selector.GetHandle ("gpuResourceID"));
			GC.KeepAlive (This);
			return ret;
		}
	}
	#pragma warning restore CS1573
	internal unsafe sealed class MTLIntersectionFunctionTableWrapper : BaseWrapper, IMTLIntersectionFunctionTable {
		public MTLIntersectionFunctionTableWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.PublicConstructors, typeof (MTLIntersectionFunctionTableWrapper))]
		static MTLIntersectionFunctionTableWrapper ()
		{
			GC.KeepAlive (null);
		}
		[Export ("setBuffer:offset:atIndex:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void SetBuffer (IMTLBuffer? buffer, nuint offset, nuint index)
		{
			var buffer__handle__ = buffer.GetHandle ();
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_UIntPtr_UIntPtr (this.Handle, Selector.GetHandle ("setBuffer:offset:atIndex:"), buffer__handle__, offset, index);
			GC.KeepAlive (buffer);
		}
		[Export ("setBuffers:offsets:withRange:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void SetBuffers (nint buffers, nint offsets, NSRange range)
		{
			global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr_IntPtr_NSRange (this.Handle, Selector.GetHandle ("setBuffers:offsets:withRange:"), buffers, offsets, range);
		}
		[Export ("setFunction:atIndex:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void SetFunction (IMTLFunctionHandle? function, nuint index)
		{
			var function__handle__ = function.GetHandle ();
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_UIntPtr (this.Handle, Selector.GetHandle ("setFunction:atIndex:"), function__handle__, index);
			GC.KeepAlive (function);
		}
		[Export ("setFunctions:withRange:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void SetFunctions (IMTLFunctionHandle[] functions, NSRange range)
		{
			if (functions is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (functions));
			using var nsa_functions = NSArray.FromNSObjects (functions);
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NSRange (this.Handle, Selector.GetHandle ("setFunctions:withRange:"), nsa_functions.Handle, range);
		}
		[Export ("setOpaqueTriangleIntersectionFunctionWithSignature:atIndex:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void SetOpaqueTriangleIntersectionFunction (MTLIntersectionFunctionSignature signature, nuint index)
		{
			global::ObjCRuntime.Messaging.void_objc_msgSend_UIntPtr_UIntPtr (this.Handle, Selector.GetHandle ("setOpaqueTriangleIntersectionFunctionWithSignature:atIndex:"), (UIntPtr) (ulong) signature, index);
		}
		[Export ("setOpaqueTriangleIntersectionFunctionWithSignature:withRange:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void SetOpaqueTriangleIntersectionFunction (MTLIntersectionFunctionSignature signature, NSRange range)
		{
			global::ObjCRuntime.Messaging.void_objc_msgSend_UIntPtr_NSRange (this.Handle, Selector.GetHandle ("setOpaqueTriangleIntersectionFunctionWithSignature:withRange:"), (UIntPtr) (ulong) signature, range);
		}
		[Export ("setVisibleFunctionTable:atBufferIndex:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void SetVisibleFunctionTable (IMTLVisibleFunctionTable? functionTable, nuint bufferIndex)
		{
			var functionTable__handle__ = functionTable.GetHandle ();
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_UIntPtr (this.Handle, Selector.GetHandle ("setVisibleFunctionTable:atBufferIndex:"), functionTable__handle__, bufferIndex);
			GC.KeepAlive (functionTable);
		}
		[Export ("setVisibleFunctionTables:withBufferRange:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void SetVisibleFunctionTables (IMTLVisibleFunctionTable[] functionTables, NSRange bufferRange)
		{
			if (functionTables is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (functionTables));
			using var nsa_functionTables = NSArray.FromNSObjects (functionTables);
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NSRange (this.Handle, Selector.GetHandle ("setVisibleFunctionTables:withBufferRange:"), nsa_functionTables.Handle, bufferRange);
		}
		[Export ("setOpaqueCurveIntersectionFunctionWithSignature:atIndex:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void SetOpaqueCurveIntersectionFunction (MTLIntersectionFunctionSignature signature, nuint index)
		{
			global::ObjCRuntime.Messaging.void_objc_msgSend_UIntPtr_UIntPtr (this.Handle, Selector.GetHandle ("setOpaqueCurveIntersectionFunctionWithSignature:atIndex:"), (UIntPtr) (ulong) signature, index);
		}
		[Export ("setOpaqueCurveIntersectionFunctionWithSignature:withRange:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void SetOpaqueCurveIntersectionFunction (MTLIntersectionFunctionSignature signature, NSRange range)
		{
			global::ObjCRuntime.Messaging.void_objc_msgSend_UIntPtr_NSRange (this.Handle, Selector.GetHandle ("setOpaqueCurveIntersectionFunctionWithSignature:withRange:"), (UIntPtr) (ulong) signature, range);
		}
		/// <param name="state">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("setPurgeableState:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public MTLPurgeableState SetPurgeableState (MTLPurgeableState state)
		{
			MTLPurgeableState ret;
			ret = (MTLPurgeableState) (ulong) global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend_UIntPtr (this.Handle, Selector.GetHandle ("setPurgeableState:"), (UIntPtr) (ulong) state);
			return ret!;
		}
		/// <summary>Makes the resource aliasable.</summary>
		[Export ("makeAliasable")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void MakeAliasable ()
		{
			global::ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, Selector.GetHandle ("makeAliasable"));
		}
		[Export ("setOwnerWithIdentity:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public int SetOwnerWithIdentity (uint taskIdToken)
		{
			int ret;
			ret = global::ObjCRuntime.Messaging.int_objc_msgSend_UInt32 (this.Handle, Selector.GetHandle ("setOwnerWithIdentity:"), taskIdToken);
			return ret;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("macos13.0")]
		[SupportedOSPlatform ("ios16.0")]
		[SupportedOSPlatform ("tvos16.0")]
		[SupportedOSPlatform ("maccatalyst16.0")]
		public MTLResourceId GpuResourceId {
			[Export ("gpuResourceID")]
			get {
				MTLResourceId ret;
				ret = global::ObjCRuntime.Messaging.MTLResourceId_objc_msgSend (this.Handle, Selector.GetHandle ("gpuResourceID"));
				return ret;
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("ios14.0")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos16.0")]
		[SupportedOSPlatform ("maccatalyst")]
		public string Label {
			[Export ("label")]
			[SupportedOSPlatform ("ios14.0")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos16.0")]
			[SupportedOSPlatform ("maccatalyst")]
			get {
				string ret;
				ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("label")), false)!;
				return ret;
			}
			[Export ("setLabel:")]
			[SupportedOSPlatform ("ios14.0")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos16.0")]
			[SupportedOSPlatform ("maccatalyst")]
			set {
				if (value is null)
					ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (value));
				var nsvalue = CFString.CreateNative (value);
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("setLabel:"), nsvalue);
				CFString.ReleaseNative (nsvalue);
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("ios14.0")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos16.0")]
		[SupportedOSPlatform ("maccatalyst")]
		public IMTLDevice Device {
			[Export ("device")]
			[SupportedOSPlatform ("ios14.0")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos16.0")]
			[SupportedOSPlatform ("maccatalyst")]
			get {
				IMTLDevice ret;
				ret =  Runtime.GetINativeObject<IMTLDevice> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("device")), false)!;
				return ret;
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("ios14.0")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos16.0")]
		[SupportedOSPlatform ("maccatalyst")]
		public MTLCpuCacheMode CpuCacheMode {
			[Export ("cpuCacheMode")]
			[SupportedOSPlatform ("ios14.0")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos16.0")]
			[SupportedOSPlatform ("maccatalyst")]
			get {
				MTLCpuCacheMode ret;
				ret = (MTLCpuCacheMode) (ulong) global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("cpuCacheMode"));
				return ret!;
			}
		}
		/// <summary>Returns a description of the location and permissions of the resource.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios14.0")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos16.0")]
		public MTLStorageMode StorageMode {
			[Export ("storageMode")]
			[SupportedOSPlatform ("ios14.0")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos16.0")]
			[SupportedOSPlatform ("maccatalyst")]
			get {
				MTLStorageMode ret;
				ret = (MTLStorageMode) (ulong) global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("storageMode"));
				return ret!;
			}
		}
		/// <summary>Returns the heap that sub-allocated the resource.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios14.0")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos16.0")]
		public IMTLHeap? Heap {
			[Export ("heap")]
			[SupportedOSPlatform ("ios14.0")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos16.0")]
			[SupportedOSPlatform ("maccatalyst")]
			get {
				IMTLHeap ret;
				ret =  Runtime.GetINativeObject<IMTLHeap> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("heap")), false)!;
				return ret;
			}
		}
		/// <summary>Returns a Boolean value that tells whether future sub-allocations can alias the resource's memory.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios14.0")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos16.0")]
		public bool IsAliasable {
			[Export ("isAliasable")]
			[SupportedOSPlatform ("ios14.0")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos16.0")]
			[SupportedOSPlatform ("maccatalyst")]
			get {
				byte ret;
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("isAliasable"));
				return ret != 0;
			}
		}
		/// <summary>Returns the allocated size of the resource.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios14.0")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos16.0")]
		public nuint AllocatedSize {
			[Export ("allocatedSize")]
			[SupportedOSPlatform ("ios14.0")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos16.0")]
			[SupportedOSPlatform ("maccatalyst")]
			get {
				nuint ret;
				ret = global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("allocatedSize"));
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("tvos16.0")]
		[SupportedOSPlatform ("ios14.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public MTLResourceOptions ResourceOptions {
			[Export ("resourceOptions")]
			[SupportedOSPlatform ("ios14.0")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos16.0")]
			[SupportedOSPlatform ("maccatalyst")]
			get {
				MTLResourceOptions ret;
				ret = (MTLResourceOptions) (ulong) global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("resourceOptions"));
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("tvos16.0")]
		[SupportedOSPlatform ("ios14.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public nuint HeapOffset {
			[Export ("heapOffset")]
			[SupportedOSPlatform ("ios14.0")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos16.0")]
			[SupportedOSPlatform ("maccatalyst")]
			get {
				nuint ret;
				ret = global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("heapOffset"));
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("tvos16.0")]
		[SupportedOSPlatform ("ios14.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public MTLHazardTrackingMode HazardTrackingMode {
			[Export ("hazardTrackingMode")]
			[SupportedOSPlatform ("ios14.0")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos16.0")]
			[SupportedOSPlatform ("maccatalyst")]
			get {
				MTLHazardTrackingMode ret;
				ret = (MTLHazardTrackingMode) (ulong) global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("hazardTrackingMode"));
				return ret!;
			}
		}
	}
}
