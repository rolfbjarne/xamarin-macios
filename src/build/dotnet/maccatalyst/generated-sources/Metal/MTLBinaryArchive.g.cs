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
	/// <summary>This interface represents the Objective-C protocol <c>MTLBinaryArchive</c>.</summary>
	/// <remarks>
	///   <para>A class that implements this interface (and subclasses <see cref="NSObject" />) will be exported to Objective-C as implementing the Objective-C protocol this interface represents.</para>
	///   <para>A class may also implement members from this interface to implement members from the protocol.</para>
	/// </remarks>
	[SupportedOSPlatform ("ios14.0")]
	[SupportedOSPlatform ("tvos14.0")]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("macos")]
	[Protocol (Name = "MTLBinaryArchive", WrapperType = typeof (MTLBinaryArchiveWrapper))]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "AddComputePipelineFunctions", Selector = "addComputePipelineFunctionsWithDescriptor:error:", ReturnType = typeof (bool), ParameterType = new Type [] { typeof (MTLComputePipelineDescriptor), typeof (NSError) }, ParameterByRef = new bool [] { false, true })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "AddRenderPipelineFunctions", Selector = "addRenderPipelineFunctionsWithDescriptor:error:", ReturnType = typeof (bool), ParameterType = new Type [] { typeof (MTLRenderPipelineDescriptor), typeof (NSError) }, ParameterByRef = new bool [] { false, true })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "AddTileRenderPipelineFunctions", Selector = "addTileRenderPipelineFunctionsWithDescriptor:error:", ReturnType = typeof (bool), ParameterType = new Type [] { typeof (MTLTileRenderPipelineDescriptor), typeof (NSError) }, ParameterByRef = new bool [] { false, true })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "Serialize", Selector = "serializeToURL:error:", ReturnType = typeof (bool), ParameterType = new Type [] { typeof (NSUrl), typeof (NSError) }, ParameterByRef = new bool [] { false, true })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "AddFunctionWithDescriptor", Selector = "addFunctionWithDescriptor:library:error:", ReturnType = typeof (bool), ParameterType = new Type [] { typeof (MTLFunctionDescriptor), typeof (IMTLLibrary), typeof (NSError) }, ParameterByRef = new bool [] { false, false, true })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "AddMeshRenderPipelineFunctions", Selector = "addMeshRenderPipelineFunctionsWithDescriptor:error:", ReturnType = typeof (bool), ParameterType = new Type [] { typeof (MTLMeshRenderPipelineDescriptor), typeof (NSError) }, ParameterByRef = new bool [] { false, true })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "AddLibrary", Selector = "addLibraryWithDescriptor:error:", ReturnType = typeof (bool), ParameterType = new Type [] { typeof (MTLStitchedLibraryDescriptor), typeof (NSError) }, ParameterByRef = new bool [] { false, true })]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "Label", Selector = "label", PropertyType = typeof (string), GetterSelector = "label", SetterSelector = "setLabel:", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "Device", Selector = "device", PropertyType = typeof (IMTLDevice), GetterSelector = "device", ArgumentSemantic = ArgumentSemantic.None)]
	public partial interface IMTLBinaryArchive : INativeObject, IDisposable
	{
		[global::Foundation.RequiredMember]
		[Export ("addComputePipelineFunctionsWithDescriptor:error:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual bool AddComputePipelineFunctions (MTLComputePipelineDescriptor descriptor, out NSError? error)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal unsafe static bool _AddComputePipelineFunctions (IMTLBinaryArchive This, MTLComputePipelineDescriptor descriptor, out NSError? error)
		{
			var descriptor__handle__ = descriptor!.GetNonNullHandle (nameof (descriptor));
			NativeHandle errorValue = IntPtr.Zero;
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_ref_NativeHandle (This.Handle, Selector.GetHandle ("addComputePipelineFunctionsWithDescriptor:error:"), descriptor__handle__, &errorValue);
			GC.KeepAlive (This);
			GC.KeepAlive (descriptor);
			error = Runtime.GetNSObject<NSError> (errorValue)!;
			return ret != 0;
		}
		[global::Foundation.RequiredMember]
		[Export ("addRenderPipelineFunctionsWithDescriptor:error:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual bool AddRenderPipelineFunctions (MTLRenderPipelineDescriptor descriptor, out NSError? error)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal unsafe static bool _AddRenderPipelineFunctions (IMTLBinaryArchive This, MTLRenderPipelineDescriptor descriptor, out NSError? error)
		{
			var descriptor__handle__ = descriptor!.GetNonNullHandle (nameof (descriptor));
			NativeHandle errorValue = IntPtr.Zero;
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_ref_NativeHandle (This.Handle, Selector.GetHandle ("addRenderPipelineFunctionsWithDescriptor:error:"), descriptor__handle__, &errorValue);
			GC.KeepAlive (This);
			GC.KeepAlive (descriptor);
			error = Runtime.GetNSObject<NSError> (errorValue)!;
			return ret != 0;
		}
		[global::Foundation.RequiredMember]
		[Export ("addTileRenderPipelineFunctionsWithDescriptor:error:")]
		[SupportedOSPlatform ("tvos14.5")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios14.0")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual bool AddTileRenderPipelineFunctions (MTLTileRenderPipelineDescriptor descriptor, out NSError? error)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[SupportedOSPlatform ("tvos14.5")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios14.0")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal unsafe static bool _AddTileRenderPipelineFunctions (IMTLBinaryArchive This, MTLTileRenderPipelineDescriptor descriptor, out NSError? error)
		{
			var descriptor__handle__ = descriptor!.GetNonNullHandle (nameof (descriptor));
			NativeHandle errorValue = IntPtr.Zero;
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_ref_NativeHandle (This.Handle, Selector.GetHandle ("addTileRenderPipelineFunctionsWithDescriptor:error:"), descriptor__handle__, &errorValue);
			GC.KeepAlive (This);
			GC.KeepAlive (descriptor);
			error = Runtime.GetNSObject<NSError> (errorValue)!;
			return ret != 0;
		}
		[global::Foundation.RequiredMember]
		[Export ("serializeToURL:error:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual bool Serialize (NSUrl url, out NSError? error)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal unsafe static bool _Serialize (IMTLBinaryArchive This, NSUrl url, out NSError? error)
		{
			var url__handle__ = url!.GetNonNullHandle (nameof (url));
			NativeHandle errorValue = IntPtr.Zero;
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_ref_NativeHandle (This.Handle, Selector.GetHandle ("serializeToURL:error:"), url__handle__, &errorValue);
			GC.KeepAlive (This);
			GC.KeepAlive (url);
			error = Runtime.GetNSObject<NSError> (errorValue)!;
			return ret != 0;
		}
		[global::Foundation.RequiredMember]
		[Export ("addFunctionWithDescriptor:library:error:")]
		[SupportedOSPlatform ("ios15.0")]
		[SupportedOSPlatform ("tvos15.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual bool AddFunctionWithDescriptor (MTLFunctionDescriptor descriptor, IMTLLibrary library, out NSError? error)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[SupportedOSPlatform ("ios15.0")]
		[SupportedOSPlatform ("tvos15.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal unsafe static bool _AddFunctionWithDescriptor (IMTLBinaryArchive This, MTLFunctionDescriptor descriptor, IMTLLibrary library, out NSError? error)
		{
			var descriptor__handle__ = descriptor!.GetNonNullHandle (nameof (descriptor));
			var library__handle__ = library!.GetNonNullHandle (nameof (library));
			NativeHandle errorValue = IntPtr.Zero;
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_NativeHandle_ref_NativeHandle (This.Handle, Selector.GetHandle ("addFunctionWithDescriptor:library:error:"), descriptor__handle__, library__handle__, &errorValue);
			GC.KeepAlive (This);
			GC.KeepAlive (descriptor);
			GC.KeepAlive (library);
			error = Runtime.GetNSObject<NSError> (errorValue)!;
			return ret != 0;
		}
		[global::Foundation.RequiredMember]
		[Export ("addMeshRenderPipelineFunctionsWithDescriptor:error:")]
		[SupportedOSPlatform ("tvos18.0")]
		[SupportedOSPlatform ("macos15.0")]
		[SupportedOSPlatform ("ios18.0")]
		[SupportedOSPlatform ("maccatalyst18.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual bool AddMeshRenderPipelineFunctions (MTLMeshRenderPipelineDescriptor descriptor, out NSError error)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[SupportedOSPlatform ("tvos18.0")]
		[SupportedOSPlatform ("macos15.0")]
		[SupportedOSPlatform ("ios18.0")]
		[SupportedOSPlatform ("maccatalyst18.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal unsafe static bool _AddMeshRenderPipelineFunctions (IMTLBinaryArchive This, MTLMeshRenderPipelineDescriptor descriptor, out NSError error)
		{
			var descriptor__handle__ = descriptor!.GetNonNullHandle (nameof (descriptor));
			NativeHandle errorValue = IntPtr.Zero;
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_ref_NativeHandle (This.Handle, Selector.GetHandle ("addMeshRenderPipelineFunctionsWithDescriptor:error:"), descriptor__handle__, &errorValue);
			GC.KeepAlive (This);
			GC.KeepAlive (descriptor);
			error = Runtime.GetNSObject<NSError> (errorValue)!;
			return ret != 0;
		}
		[global::Foundation.RequiredMember]
		[Export ("addLibraryWithDescriptor:error:")]
		[SupportedOSPlatform ("tvos18.0")]
		[SupportedOSPlatform ("macos15.0")]
		[SupportedOSPlatform ("ios18.0")]
		[SupportedOSPlatform ("maccatalyst18.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual bool AddLibrary (MTLStitchedLibraryDescriptor descriptor, out NSError error)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[SupportedOSPlatform ("tvos18.0")]
		[SupportedOSPlatform ("macos15.0")]
		[SupportedOSPlatform ("ios18.0")]
		[SupportedOSPlatform ("maccatalyst18.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal unsafe static bool _AddLibrary (IMTLBinaryArchive This, MTLStitchedLibraryDescriptor descriptor, out NSError error)
		{
			var descriptor__handle__ = descriptor!.GetNonNullHandle (nameof (descriptor));
			NativeHandle errorValue = IntPtr.Zero;
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_ref_NativeHandle (This.Handle, Selector.GetHandle ("addLibraryWithDescriptor:error:"), descriptor__handle__, &errorValue);
			GC.KeepAlive (This);
			GC.KeepAlive (descriptor);
			error = Runtime.GetNSObject<NSError> (errorValue)!;
			return ret != 0;
		}
		[DynamicDependencyAttribute ("AddComputePipelineFunctions(Metal.MTLComputePipelineDescriptor,Foundation.NSError@)")]
		[DynamicDependencyAttribute ("AddFunctionWithDescriptor(Metal.MTLFunctionDescriptor,Metal.IMTLLibrary,Foundation.NSError@)")]
		[DynamicDependencyAttribute ("AddLibrary(Metal.MTLStitchedLibraryDescriptor,Foundation.NSError@)")]
		[DynamicDependencyAttribute ("AddMeshRenderPipelineFunctions(Metal.MTLMeshRenderPipelineDescriptor,Foundation.NSError@)")]
		[DynamicDependencyAttribute ("AddRenderPipelineFunctions(Metal.MTLRenderPipelineDescriptor,Foundation.NSError@)")]
		[DynamicDependencyAttribute ("AddTileRenderPipelineFunctions(Metal.MTLTileRenderPipelineDescriptor,Foundation.NSError@)")]
		[DynamicDependencyAttribute ("Device")]
		[DynamicDependencyAttribute ("Label")]
		[DynamicDependencyAttribute ("Serialize(Foundation.NSUrl,Foundation.NSError@)")]
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.Interfaces | DynamicallyAccessedMemberTypes.PublicConstructors, typeof (MTLBinaryArchiveWrapper))]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static IMTLBinaryArchive ()
		{
			GC.KeepAlive (null);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual string? Label {
			[Export ("label")]
			get {
				return _GetLabel (this);
			}
			[Export ("setLabel:")]
			set {
				_SetLabel (this, value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static string _GetLabel (IMTLBinaryArchive This)
		{
			string ret;
			ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("label")), false)!;
			GC.KeepAlive (This);
			return ret;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SetLabel (IMTLBinaryArchive This, string? value)
		{
			var nsvalue = CFString.CreateNative (value);
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("setLabel:"), nsvalue);
			GC.KeepAlive (This);
			CFString.ReleaseNative (nsvalue);
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
		internal static IMTLDevice _GetDevice (IMTLBinaryArchive This)
		{
			IMTLDevice ret;
			ret =  Runtime.GetINativeObject<IMTLDevice> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("device")), false)!;
			GC.KeepAlive (This);
			return ret;
		}
	}
	#pragma warning restore CS1573
	internal unsafe sealed class MTLBinaryArchiveWrapper : BaseWrapper, IMTLBinaryArchive {
		public MTLBinaryArchiveWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.PublicConstructors, typeof (MTLBinaryArchiveWrapper))]
		static MTLBinaryArchiveWrapper ()
		{
			GC.KeepAlive (null);
		}
		[Export ("addComputePipelineFunctionsWithDescriptor:error:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe bool AddComputePipelineFunctions (MTLComputePipelineDescriptor descriptor, out NSError? error)
		{
			var descriptor__handle__ = descriptor!.GetNonNullHandle (nameof (descriptor));
			NativeHandle errorValue = IntPtr.Zero;
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_ref_NativeHandle (this.Handle, Selector.GetHandle ("addComputePipelineFunctionsWithDescriptor:error:"), descriptor__handle__, &errorValue);
			GC.KeepAlive (descriptor);
			error = Runtime.GetNSObject<NSError> (errorValue)!;
			return ret != 0;
		}
		[Export ("addRenderPipelineFunctionsWithDescriptor:error:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe bool AddRenderPipelineFunctions (MTLRenderPipelineDescriptor descriptor, out NSError? error)
		{
			var descriptor__handle__ = descriptor!.GetNonNullHandle (nameof (descriptor));
			NativeHandle errorValue = IntPtr.Zero;
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_ref_NativeHandle (this.Handle, Selector.GetHandle ("addRenderPipelineFunctionsWithDescriptor:error:"), descriptor__handle__, &errorValue);
			GC.KeepAlive (descriptor);
			error = Runtime.GetNSObject<NSError> (errorValue)!;
			return ret != 0;
		}
		[Export ("addTileRenderPipelineFunctionsWithDescriptor:error:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe bool AddTileRenderPipelineFunctions (MTLTileRenderPipelineDescriptor descriptor, out NSError? error)
		{
			var descriptor__handle__ = descriptor!.GetNonNullHandle (nameof (descriptor));
			NativeHandle errorValue = IntPtr.Zero;
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_ref_NativeHandle (this.Handle, Selector.GetHandle ("addTileRenderPipelineFunctionsWithDescriptor:error:"), descriptor__handle__, &errorValue);
			GC.KeepAlive (descriptor);
			error = Runtime.GetNSObject<NSError> (errorValue)!;
			return ret != 0;
		}
		[Export ("serializeToURL:error:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe bool Serialize (NSUrl url, out NSError? error)
		{
			var url__handle__ = url!.GetNonNullHandle (nameof (url));
			NativeHandle errorValue = IntPtr.Zero;
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_ref_NativeHandle (this.Handle, Selector.GetHandle ("serializeToURL:error:"), url__handle__, &errorValue);
			GC.KeepAlive (url);
			error = Runtime.GetNSObject<NSError> (errorValue)!;
			return ret != 0;
		}
		[Export ("addFunctionWithDescriptor:library:error:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe bool AddFunctionWithDescriptor (MTLFunctionDescriptor descriptor, IMTLLibrary library, out NSError? error)
		{
			var descriptor__handle__ = descriptor!.GetNonNullHandle (nameof (descriptor));
			var library__handle__ = library!.GetNonNullHandle (nameof (library));
			NativeHandle errorValue = IntPtr.Zero;
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_NativeHandle_ref_NativeHandle (this.Handle, Selector.GetHandle ("addFunctionWithDescriptor:library:error:"), descriptor__handle__, library__handle__, &errorValue);
			GC.KeepAlive (descriptor);
			GC.KeepAlive (library);
			error = Runtime.GetNSObject<NSError> (errorValue)!;
			return ret != 0;
		}
		[Export ("addMeshRenderPipelineFunctionsWithDescriptor:error:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe bool AddMeshRenderPipelineFunctions (MTLMeshRenderPipelineDescriptor descriptor, out NSError error)
		{
			var descriptor__handle__ = descriptor!.GetNonNullHandle (nameof (descriptor));
			NativeHandle errorValue = IntPtr.Zero;
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_ref_NativeHandle (this.Handle, Selector.GetHandle ("addMeshRenderPipelineFunctionsWithDescriptor:error:"), descriptor__handle__, &errorValue);
			GC.KeepAlive (descriptor);
			error = Runtime.GetNSObject<NSError> (errorValue)!;
			return ret != 0;
		}
		[Export ("addLibraryWithDescriptor:error:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe bool AddLibrary (MTLStitchedLibraryDescriptor descriptor, out NSError error)
		{
			var descriptor__handle__ = descriptor!.GetNonNullHandle (nameof (descriptor));
			NativeHandle errorValue = IntPtr.Zero;
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_ref_NativeHandle (this.Handle, Selector.GetHandle ("addLibraryWithDescriptor:error:"), descriptor__handle__, &errorValue);
			GC.KeepAlive (descriptor);
			error = Runtime.GetNSObject<NSError> (errorValue)!;
			return ret != 0;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public string? Label {
			[Export ("label")]
			get {
				string ret;
				ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("label")), false)!;
				return ret;
			}
			[Export ("setLabel:")]
			set {
				var nsvalue = CFString.CreateNative (value);
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("setLabel:"), nsvalue);
				CFString.ReleaseNative (nsvalue);
			}
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
	}
}
