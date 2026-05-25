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
	/// <summary>System protocol for raw data that is accessible in strides.</summary>
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("tvos")]
	[Protocol (Name = "MTLBuffer", WrapperType = typeof (MTLBufferWrapper))]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "DidModify", Selector = "didModifyRange:", ParameterType = new Type [] { typeof (NSRange) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "CreateTexture", Selector = "newTextureWithDescriptor:offset:bytesPerRow:", ReturnType = typeof (IMTLTexture), ParameterType = new Type [] { typeof (MTLTextureDescriptor), typeof (UIntPtr), typeof (UIntPtr) }, ParameterByRef = new bool [] { false, false, false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "AddDebugMarker", Selector = "addDebugMarker:range:", ParameterType = new Type [] { typeof (string), typeof (NSRange) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "RemoveAllDebugMarkers", Selector = "removeAllDebugMarkers")]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "CreateTensor", Selector = "newTensorWithDescriptor:offset:error:", ReturnType = typeof (IMTLTensor), ParameterType = new Type [] { typeof (MTLTensorDescriptor), typeof (UIntPtr), typeof (NSError) }, ParameterByRef = new bool [] { false, false, true })]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "Length", Selector = "length", PropertyType = typeof (UIntPtr), GetterSelector = "length", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "Contents", Selector = "contents", PropertyType = typeof (IntPtr), GetterSelector = "contents", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "GpuAddress", Selector = "gpuAddress", PropertyType = typeof (ulong), GetterSelector = "gpuAddress", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "SparseBufferTier", Selector = "sparseBufferTier", PropertyType = typeof (MTLBufferSparseTier), GetterSelector = "sparseBufferTier", ArgumentSemantic = ArgumentSemantic.None)]
	public partial interface IMTLBuffer : INativeObject, IDisposable, 
		Metal.IMTLAllocation
		, Metal.IMTLResource
	{
		/// <param name="range">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[global::Foundation.RequiredMember]
		[Export ("didModifyRange:")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidModify (NSRange range)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="range">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _DidModify (IMTLBuffer This, NSRange range)
		{
			global::ObjCRuntime.Messaging.void_objc_msgSend_NSRange (This.Handle, Selector.GetHandle ("didModifyRange:"), range);
			GC.KeepAlive (This);
		}
		/// <param name="descriptor">To be added.</param><param name="offset">To be added.</param><param name="bytesPerRow">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.RequiredMember]
		[Export ("newTextureWithDescriptor:offset:bytesPerRow:")]
		[return: ReleaseAttribute ()]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual IMTLTexture? CreateTexture (MTLTextureDescriptor descriptor, nuint offset, nuint bytesPerRow)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="descriptor">To be added.</param><param name="offset">To be added.</param><param name="bytesPerRow">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[return: ReleaseAttribute ()]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static IMTLTexture? _CreateTexture (IMTLBuffer This, MTLTextureDescriptor descriptor, nuint offset, nuint bytesPerRow)
		{
			var descriptor__handle__ = descriptor!.GetNonNullHandle (nameof (descriptor));
			IMTLTexture? ret;
			ret =  Runtime.GetINativeObject<IMTLTexture> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_UIntPtr_UIntPtr (This.Handle, Selector.GetHandle ("newTextureWithDescriptor:offset:bytesPerRow:"), descriptor__handle__, offset, bytesPerRow), true)!;
			GC.KeepAlive (This);
			GC.KeepAlive (descriptor);
			return ret!;
		}
		[global::Foundation.RequiredMember]
		[Export ("addDebugMarker:range:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void AddDebugMarker (string marker, NSRange range)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _AddDebugMarker (IMTLBuffer This, string marker, NSRange range)
		{
			if (marker is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (marker));
			var nsmarker = CFString.CreateNative (marker);
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NSRange (This.Handle, Selector.GetHandle ("addDebugMarker:range:"), nsmarker, range);
			GC.KeepAlive (This);
			CFString.ReleaseNative (nsmarker);
		}
		[global::Foundation.RequiredMember]
		[Export ("removeAllDebugMarkers")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void RemoveAllDebugMarkers ()
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _RemoveAllDebugMarkers (IMTLBuffer This)
		{
			global::ObjCRuntime.Messaging.void_objc_msgSend (This.Handle, Selector.GetHandle ("removeAllDebugMarkers"));
			GC.KeepAlive (This);
		}
		[global::Foundation.RequiredMember]
		[Export ("newTensorWithDescriptor:offset:error:")]
		[return: ReleaseAttribute ()]
		[SupportedOSPlatform ("macos26.0")]
		[SupportedOSPlatform ("ios26.0")]
		[SupportedOSPlatform ("tvos26.0")]
		[SupportedOSPlatform ("maccatalyst26.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual IMTLTensor? CreateTensor (MTLTensorDescriptor descriptor, nuint offset, out NSError? error)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[return: ReleaseAttribute ()]
		[SupportedOSPlatform ("macos26.0")]
		[SupportedOSPlatform ("ios26.0")]
		[SupportedOSPlatform ("tvos26.0")]
		[SupportedOSPlatform ("maccatalyst26.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal unsafe static IMTLTensor? _CreateTensor (IMTLBuffer This, MTLTensorDescriptor descriptor, nuint offset, out NSError? error)
		{
			var descriptor__handle__ = descriptor!.GetNonNullHandle (nameof (descriptor));
			NativeHandle errorValue = IntPtr.Zero;
			IMTLTensor? ret;
			ret =  Runtime.GetINativeObject<IMTLTensor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_UIntPtr_ref_NativeHandle (This.Handle, Selector.GetHandle ("newTensorWithDescriptor:offset:error:"), descriptor__handle__, offset, &errorValue), true)!;
			GC.KeepAlive (This);
			GC.KeepAlive (descriptor);
			error = Runtime.GetNSObject<NSError> (errorValue)!;
			return ret!;
		}
		[DynamicDependencyAttribute ("AddDebugMarker(System.String,Foundation.NSRange)")]
		[DynamicDependencyAttribute ("Contents")]
		[DynamicDependencyAttribute ("CreateTensor(Metal.MTLTensorDescriptor,System.UIntPtr,Foundation.NSError@)")]
		[DynamicDependencyAttribute ("CreateTexture(Metal.MTLTextureDescriptor,System.UIntPtr,System.UIntPtr)")]
		[DynamicDependencyAttribute ("DidModify(Foundation.NSRange)")]
		[DynamicDependencyAttribute ("GpuAddress")]
		[DynamicDependencyAttribute ("Length")]
		[DynamicDependencyAttribute ("RemoveAllDebugMarkers()")]
		[DynamicDependencyAttribute ("SparseBufferTier")]
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.Interfaces | DynamicallyAccessedMemberTypes.PublicConstructors, typeof (MTLBufferWrapper))]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static IMTLBuffer ()
		{
			GC.KeepAlive (null);
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual nuint Length {
			[Export ("length")]
			get {
				return _GetLength (this);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static nuint _GetLength (IMTLBuffer This)
		{
			nuint ret;
			ret = global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend (This.Handle, Selector.GetHandle ("length"));
			GC.KeepAlive (This);
			return ret;
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual nint Contents {
			[Export ("contents")]
			get {
				return _GetContents (this);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static nint _GetContents (IMTLBuffer This)
		{
			nint ret;
			ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (This.Handle, Selector.GetHandle ("contents"));
			GC.KeepAlive (This);
			return ret;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("macos13.0")]
		[SupportedOSPlatform ("ios16.0")]
		[SupportedOSPlatform ("tvos16.0")]
		[SupportedOSPlatform ("maccatalyst16.0")]
		[global::Foundation.RequiredMember]
		public virtual ulong GpuAddress {
			[Export ("gpuAddress")]
			get {
				return _GetGpuAddress (this);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static ulong _GetGpuAddress (IMTLBuffer This)
		{
			ulong ret;
			ret = global::ObjCRuntime.Messaging.UInt64_objc_msgSend (This.Handle, Selector.GetHandle ("gpuAddress"));
			GC.KeepAlive (This);
			return ret;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("macos26.0")]
		[SupportedOSPlatform ("ios26.0")]
		[SupportedOSPlatform ("tvos26.0")]
		[SupportedOSPlatform ("maccatalyst26.0")]
		[global::Foundation.RequiredMember]
		public virtual MTLBufferSparseTier SparseBufferTier {
			[Export ("sparseBufferTier")]
			get {
				return _GetSparseBufferTier (this);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static MTLBufferSparseTier _GetSparseBufferTier (IMTLBuffer This)
		{
			MTLBufferSparseTier ret;
			ret = (MTLBufferSparseTier) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (This.Handle, Selector.GetHandle ("sparseBufferTier"));
			GC.KeepAlive (This);
			return ret!;
		}
	}
	#pragma warning restore CS1573
	#pragma warning disable CS1573
	/// <summary>Extension methods to the <see cref="IMTLBuffer" /> interface to support all the methods from the MTLBuffer protocol.</summary>
	/// <remarks>
	///   <para>The extension methods for <see cref="IMTLBuffer" /> interface allow developers to treat instances of the interface as having all the optional methods of the original MTLBuffer protocol. Since the interface only contains the required members, these extension methods allow developers to call the optional members of the protocol.</para>
	/// </remarks>
	public unsafe static partial class MTLBuffer_Extensions {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static ulong GetGpuAddress (this IMTLBuffer This)
		{
			ulong ret;
			ret = global::ObjCRuntime.Messaging.UInt64_objc_msgSend (This.Handle, Selector.GetHandle ("gpuAddress"));
			GC.KeepAlive (This);
			return ret;
		}
	}
	#pragma warning restore CS1573
	internal unsafe sealed class MTLBufferWrapper : BaseWrapper, IMTLBuffer {
		public MTLBufferWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.PublicConstructors, typeof (MTLBufferWrapper))]
		static MTLBufferWrapper ()
		{
			GC.KeepAlive (null);
		}
		/// <param name="range">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("didModifyRange:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void DidModify (NSRange range)
		{
			global::ObjCRuntime.Messaging.void_objc_msgSend_NSRange (this.Handle, Selector.GetHandle ("didModifyRange:"), range);
		}
		/// <param name="descriptor">To be added.</param><param name="offset">To be added.</param><param name="bytesPerRow">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("newTextureWithDescriptor:offset:bytesPerRow:")]
		[return: ReleaseAttribute ()]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public IMTLTexture? CreateTexture (MTLTextureDescriptor descriptor, nuint offset, nuint bytesPerRow)
		{
			var descriptor__handle__ = descriptor!.GetNonNullHandle (nameof (descriptor));
			IMTLTexture? ret;
			ret =  Runtime.GetINativeObject<IMTLTexture> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_UIntPtr_UIntPtr (this.Handle, Selector.GetHandle ("newTextureWithDescriptor:offset:bytesPerRow:"), descriptor__handle__, offset, bytesPerRow), true)!;
			GC.KeepAlive (descriptor);
			return ret!;
		}
		[Export ("addDebugMarker:range:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void AddDebugMarker (string marker, NSRange range)
		{
			if (marker is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (marker));
			var nsmarker = CFString.CreateNative (marker);
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NSRange (this.Handle, Selector.GetHandle ("addDebugMarker:range:"), nsmarker, range);
			CFString.ReleaseNative (nsmarker);
		}
		[Export ("removeAllDebugMarkers")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void RemoveAllDebugMarkers ()
		{
			global::ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, Selector.GetHandle ("removeAllDebugMarkers"));
		}
		[Export ("newTensorWithDescriptor:offset:error:")]
		[return: ReleaseAttribute ()]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe IMTLTensor? CreateTensor (MTLTensorDescriptor descriptor, nuint offset, out NSError? error)
		{
			var descriptor__handle__ = descriptor!.GetNonNullHandle (nameof (descriptor));
			NativeHandle errorValue = IntPtr.Zero;
			IMTLTensor? ret;
			ret =  Runtime.GetINativeObject<IMTLTensor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_UIntPtr_ref_NativeHandle (this.Handle, Selector.GetHandle ("newTensorWithDescriptor:offset:error:"), descriptor__handle__, offset, &errorValue), true)!;
			GC.KeepAlive (descriptor);
			error = Runtime.GetNSObject<NSError> (errorValue)!;
			return ret!;
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
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public nuint Length {
			[Export ("length")]
			get {
				nuint ret;
				ret = global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("length"));
				return ret;
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public nint Contents {
			[Export ("contents")]
			get {
				nint ret;
				ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("contents"));
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("macos13.0")]
		[SupportedOSPlatform ("ios16.0")]
		[SupportedOSPlatform ("tvos16.0")]
		[SupportedOSPlatform ("maccatalyst16.0")]
		public ulong GpuAddress {
			[Export ("gpuAddress")]
			get {
				ulong ret;
				ret = global::ObjCRuntime.Messaging.UInt64_objc_msgSend (this.Handle, Selector.GetHandle ("gpuAddress"));
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("macos26.0")]
		[SupportedOSPlatform ("ios26.0")]
		[SupportedOSPlatform ("tvos26.0")]
		[SupportedOSPlatform ("maccatalyst26.0")]
		public MTLBufferSparseTier SparseBufferTier {
			[Export ("sparseBufferTier")]
			get {
				MTLBufferSparseTier ret;
				ret = (MTLBufferSparseTier) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("sparseBufferTier"));
				return ret!;
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		public string Label {
			[Export ("label")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("maccatalyst")]
			get {
				string ret;
				ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("label")), false)!;
				return ret;
			}
			[Export ("setLabel:")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
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
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		public IMTLDevice Device {
			[Export ("device")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("maccatalyst")]
			get {
				IMTLDevice ret;
				ret =  Runtime.GetINativeObject<IMTLDevice> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("device")), false)!;
				return ret;
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		public MTLCpuCacheMode CpuCacheMode {
			[Export ("cpuCacheMode")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
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
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public MTLStorageMode StorageMode {
			[Export ("storageMode")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
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
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public IMTLHeap? Heap {
			[Export ("heap")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
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
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public bool IsAliasable {
			[Export ("isAliasable")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
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
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public nuint AllocatedSize {
			[Export ("allocatedSize")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("maccatalyst")]
			get {
				nuint ret;
				ret = global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("allocatedSize"));
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("tvos13.0")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public MTLResourceOptions ResourceOptions {
			[Export ("resourceOptions")]
			[SupportedOSPlatform ("ios13.0")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos13.0")]
			[SupportedOSPlatform ("maccatalyst")]
			get {
				MTLResourceOptions ret;
				ret = (MTLResourceOptions) (ulong) global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("resourceOptions"));
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("tvos13.0")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public nuint HeapOffset {
			[Export ("heapOffset")]
			[SupportedOSPlatform ("ios13.0")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos13.0")]
			[SupportedOSPlatform ("maccatalyst")]
			get {
				nuint ret;
				ret = global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("heapOffset"));
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("tvos13.0")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public MTLHazardTrackingMode HazardTrackingMode {
			[Export ("hazardTrackingMode")]
			[SupportedOSPlatform ("ios13.0")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos13.0")]
			[SupportedOSPlatform ("maccatalyst")]
			get {
				MTLHazardTrackingMode ret;
				ret = (MTLHazardTrackingMode) (ulong) global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("hazardTrackingMode"));
				return ret!;
			}
		}
	}
}
