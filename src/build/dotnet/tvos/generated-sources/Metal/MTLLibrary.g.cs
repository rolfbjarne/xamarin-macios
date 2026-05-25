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
using Photos;
using ModelIO;
using Network;
using SceneKit;
using Security;
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
using CoreAnimation;
using CoreFoundation;
using NetworkExtension;
using MetalPerformanceShadersGraph;
#nullable enable
namespace Metal {
	#pragma warning disable CS1573
	/// <summary>System protocol for libraries of shaders.</summary>
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("tvos")]
	[Protocol (Name = "MTLLibrary", WrapperType = typeof (MTLLibraryWrapper))]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "CreateFunction", Selector = "newFunctionWithName:", ReturnType = typeof (IMTLFunction), ParameterType = new Type [] { typeof (string) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "CreateFunction", Selector = "newFunctionWithName:constantValues:error:", ReturnType = typeof (IMTLFunction), ParameterType = new Type [] { typeof (string), typeof (MTLFunctionConstantValues), typeof (NSError) }, ParameterByRef = new bool [] { false, false, true })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "CreateFunction", Selector = "newFunctionWithName:constantValues:completionHandler:", ParameterType = new Type [] { typeof (string), typeof (MTLFunctionConstantValues), typeof (global::System.Action<global::Metal.IMTLFunction, NSError>) }, ParameterByRef = new bool [] { false, false, false }, ParameterBlockProxy = new Type? [] { null, null, typeof (ObjCRuntime.Trampolines.NIDActionArity2V79) })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "CreateFunction", Selector = "newFunctionWithDescriptor:completionHandler:", ParameterType = new Type [] { typeof (MTLFunctionDescriptor), typeof (global::System.Action<global::Metal.IMTLFunction, NSError>) }, ParameterByRef = new bool [] { false, false }, ParameterBlockProxy = new Type? [] { null, typeof (ObjCRuntime.Trampolines.NIDActionArity2V79) })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "CreateFunction", Selector = "newFunctionWithDescriptor:error:", ReturnType = typeof (IMTLFunction), ParameterType = new Type [] { typeof (MTLFunctionDescriptor), typeof (NSError) }, ParameterByRef = new bool [] { false, true })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "CreateIntersectionFunction", Selector = "newIntersectionFunctionWithDescriptor:completionHandler:", ParameterType = new Type [] { typeof (MTLIntersectionFunctionDescriptor), typeof (global::System.Action<global::Metal.IMTLFunction, NSError>) }, ParameterByRef = new bool [] { false, false }, ParameterBlockProxy = new Type? [] { null, typeof (ObjCRuntime.Trampolines.NIDActionArity2V79) })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "CreateIntersectionFunction", Selector = "newIntersectionFunctionWithDescriptor:error:", ReturnType = typeof (IMTLFunction), ParameterType = new Type [] { typeof (MTLIntersectionFunctionDescriptor), typeof (NSError) }, ParameterByRef = new bool [] { false, true })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "CreateFunctionReflection", Selector = "reflectionForFunctionWithName:", ReturnType = typeof (MTLFunctionReflection), ParameterType = new Type [] { typeof (string) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "Label", Selector = "label", PropertyType = typeof (string), GetterSelector = "label", SetterSelector = "setLabel:", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "Device", Selector = "device", PropertyType = typeof (IMTLDevice), GetterSelector = "device", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "FunctionNames", Selector = "functionNames", PropertyType = typeof (String[]), GetterSelector = "functionNames", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "Type", Selector = "type", PropertyType = typeof (MTLLibraryType), GetterSelector = "type", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "InstallName", Selector = "installName", PropertyType = typeof (string), GetterSelector = "installName", ArgumentSemantic = ArgumentSemantic.None)]
	public partial interface IMTLLibrary : INativeObject, IDisposable
	{
		/// <param name="functionName">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.RequiredMember]
		[Export ("newFunctionWithName:")]
		[return: ReleaseAttribute ()]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual IMTLFunction CreateFunction (string functionName)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="functionName">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[return: ReleaseAttribute ()]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static IMTLFunction _CreateFunction (IMTLLibrary This, string functionName)
		{
			if (functionName is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (functionName));
			var nsfunctionName = CFString.CreateNative (functionName);
			IMTLFunction? ret;
			ret =  Runtime.GetINativeObject<IMTLFunction> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("newFunctionWithName:"), nsfunctionName), true)!;
			GC.KeepAlive (This);
			CFString.ReleaseNative (nsfunctionName);
			return ret!;
		}
		[global::Foundation.RequiredMember]
		[Export ("newFunctionWithName:constantValues:error:")]
		[return: ReleaseAttribute ()]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual IMTLFunction? CreateFunction (string name, MTLFunctionConstantValues constantValues, out NSError error)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[return: ReleaseAttribute ()]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal unsafe static IMTLFunction? _CreateFunction (IMTLLibrary This, string name, MTLFunctionConstantValues constantValues, out NSError error)
		{
			if (name is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (name));
			var constantValues__handle__ = constantValues!.GetNonNullHandle (nameof (constantValues));
			NativeHandle errorValue = IntPtr.Zero;
			var nsname = CFString.CreateNative (name);
			IMTLFunction? ret;
			ret =  Runtime.GetINativeObject<IMTLFunction> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_ref_NativeHandle (This.Handle, Selector.GetHandle ("newFunctionWithName:constantValues:error:"), nsname, constantValues__handle__, &errorValue), true)!;
			GC.KeepAlive (This);
			GC.KeepAlive (constantValues);
			CFString.ReleaseNative (nsname);
			error = Runtime.GetNSObject<NSError> (errorValue)!;
			return ret!;
		}
		[global::Foundation.RequiredMember]
		[Export ("newFunctionWithName:constantValues:completionHandler:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void CreateFunction (string name, MTLFunctionConstantValues constantValues, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity2V79))]global::System.Action<IMTLFunction, NSError> completionHandler)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual Task<IMTLFunction> CreateFunctionAsync (string name, MTLFunctionConstantValues constantValues)
		{
			var tcs = new TaskCompletionSource<IMTLFunction> ();
			CreateFunction(name, constantValues, (arg1_, arg2_) => {
				if (arg2_ is not null)
					tcs.SetException (new NSErrorException(arg2_));
				else
					tcs.SetResult (arg1_!);
			});
			return tcs.Task;
		}
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal unsafe static void _CreateFunction (IMTLLibrary This, string name, MTLFunctionConstantValues constantValues, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity2V79))]global::System.Action<IMTLFunction, NSError> completionHandler)
		{
			if (name is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (name));
			var constantValues__handle__ = constantValues!.GetNonNullHandle (nameof (constantValues));
			if (completionHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completionHandler));
			var nsname = CFString.CreateNative (name);
			using var block_completionHandler = Trampolines.SDActionArity2V79.CreateBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = &block_completionHandler;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("newFunctionWithName:constantValues:completionHandler:"), nsname, constantValues__handle__, (IntPtr) block_ptr_completionHandler);
			GC.KeepAlive (This);
			GC.KeepAlive (constantValues);
			CFString.ReleaseNative (nsname);
		}
		[global::Foundation.RequiredMember]
		[Export ("newFunctionWithDescriptor:completionHandler:")]
		[SupportedOSPlatform ("ios14.0")]
		[SupportedOSPlatform ("tvos14.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void CreateFunction (MTLFunctionDescriptor descriptor, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity2V79))]global::System.Action<IMTLFunction, NSError> completionHandler)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[SupportedOSPlatform ("ios14.0")]
		[SupportedOSPlatform ("tvos14.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal unsafe static void _CreateFunction (IMTLLibrary This, MTLFunctionDescriptor descriptor, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity2V79))]global::System.Action<IMTLFunction, NSError> completionHandler)
		{
			var descriptor__handle__ = descriptor!.GetNonNullHandle (nameof (descriptor));
			if (completionHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completionHandler));
			using var block_completionHandler = Trampolines.SDActionArity2V79.CreateBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = &block_completionHandler;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("newFunctionWithDescriptor:completionHandler:"), descriptor__handle__, (IntPtr) block_ptr_completionHandler);
			GC.KeepAlive (This);
			GC.KeepAlive (descriptor);
		}
		[global::Foundation.RequiredMember]
		[Export ("newFunctionWithDescriptor:error:")]
		[return: ReleaseAttribute ()]
		[SupportedOSPlatform ("ios14.0")]
		[SupportedOSPlatform ("tvos14.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual IMTLFunction? CreateFunction (MTLFunctionDescriptor descriptor, out NSError? error)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[return: ReleaseAttribute ()]
		[SupportedOSPlatform ("ios14.0")]
		[SupportedOSPlatform ("tvos14.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal unsafe static IMTLFunction? _CreateFunction (IMTLLibrary This, MTLFunctionDescriptor descriptor, out NSError? error)
		{
			var descriptor__handle__ = descriptor!.GetNonNullHandle (nameof (descriptor));
			NativeHandle errorValue = IntPtr.Zero;
			IMTLFunction? ret;
			ret =  Runtime.GetINativeObject<IMTLFunction> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_ref_NativeHandle (This.Handle, Selector.GetHandle ("newFunctionWithDescriptor:error:"), descriptor__handle__, &errorValue), true)!;
			GC.KeepAlive (This);
			GC.KeepAlive (descriptor);
			error = Runtime.GetNSObject<NSError> (errorValue)!;
			return ret!;
		}
		[global::Foundation.RequiredMember]
		[Export ("newIntersectionFunctionWithDescriptor:completionHandler:")]
		[SupportedOSPlatform ("ios14.0")]
		[SupportedOSPlatform ("tvos16.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void CreateIntersectionFunction (MTLIntersectionFunctionDescriptor descriptor, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity2V79))]global::System.Action<IMTLFunction, NSError> completionHandler)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[SupportedOSPlatform ("ios14.0")]
		[SupportedOSPlatform ("tvos16.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal unsafe static void _CreateIntersectionFunction (IMTLLibrary This, MTLIntersectionFunctionDescriptor descriptor, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity2V79))]global::System.Action<IMTLFunction, NSError> completionHandler)
		{
			var descriptor__handle__ = descriptor!.GetNonNullHandle (nameof (descriptor));
			if (completionHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completionHandler));
			using var block_completionHandler = Trampolines.SDActionArity2V79.CreateBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = &block_completionHandler;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("newIntersectionFunctionWithDescriptor:completionHandler:"), descriptor__handle__, (IntPtr) block_ptr_completionHandler);
			GC.KeepAlive (This);
			GC.KeepAlive (descriptor);
		}
		[global::Foundation.RequiredMember]
		[Export ("newIntersectionFunctionWithDescriptor:error:")]
		[return: ReleaseAttribute ()]
		[SupportedOSPlatform ("ios14.0")]
		[SupportedOSPlatform ("tvos16.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual IMTLFunction? CreateIntersectionFunction (MTLIntersectionFunctionDescriptor descriptor, out NSError? error)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[return: ReleaseAttribute ()]
		[SupportedOSPlatform ("ios14.0")]
		[SupportedOSPlatform ("tvos16.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal unsafe static IMTLFunction? _CreateIntersectionFunction (IMTLLibrary This, MTLIntersectionFunctionDescriptor descriptor, out NSError? error)
		{
			var descriptor__handle__ = descriptor!.GetNonNullHandle (nameof (descriptor));
			NativeHandle errorValue = IntPtr.Zero;
			IMTLFunction? ret;
			ret =  Runtime.GetINativeObject<IMTLFunction> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_ref_NativeHandle (This.Handle, Selector.GetHandle ("newIntersectionFunctionWithDescriptor:error:"), descriptor__handle__, &errorValue), true)!;
			GC.KeepAlive (This);
			GC.KeepAlive (descriptor);
			error = Runtime.GetNSObject<NSError> (errorValue)!;
			return ret!;
		}
		[global::Foundation.RequiredMember]
		[Export ("reflectionForFunctionWithName:")]
		[SupportedOSPlatform ("macos26.0")]
		[SupportedOSPlatform ("ios26.0")]
		[SupportedOSPlatform ("tvos26.0")]
		[SupportedOSPlatform ("maccatalyst26.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual MTLFunctionReflection? CreateFunctionReflection (string functionName)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[SupportedOSPlatform ("macos26.0")]
		[SupportedOSPlatform ("ios26.0")]
		[SupportedOSPlatform ("tvos26.0")]
		[SupportedOSPlatform ("maccatalyst26.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static MTLFunctionReflection? _CreateFunctionReflection (IMTLLibrary This, string functionName)
		{
			if (functionName is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (functionName));
			var nsfunctionName = CFString.CreateNative (functionName);
			MTLFunctionReflection? ret;
			ret =  Runtime.GetNSObject<MTLFunctionReflection> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("reflectionForFunctionWithName:"), nsfunctionName), false)!;
			GC.KeepAlive (This);
			CFString.ReleaseNative (nsfunctionName);
			return ret!;
		}
		[DynamicDependencyAttribute ("CreateFunction(Metal.MTLFunctionDescriptor,Foundation.NSError@)")]
		[DynamicDependencyAttribute ("CreateFunction(Metal.MTLFunctionDescriptor,System.Action{Metal.IMTLFunction,Foundation.NSError})")]
		[DynamicDependencyAttribute ("CreateFunction(System.String,Metal.MTLFunctionConstantValues,Foundation.NSError@)")]
		[DynamicDependencyAttribute ("CreateFunction(System.String,Metal.MTLFunctionConstantValues,System.Action{Metal.IMTLFunction,Foundation.NSError})")]
		[DynamicDependencyAttribute ("CreateFunction(System.String)")]
		[DynamicDependencyAttribute ("CreateFunctionReflection(System.String)")]
		[DynamicDependencyAttribute ("CreateIntersectionFunction(Metal.MTLIntersectionFunctionDescriptor,Foundation.NSError@)")]
		[DynamicDependencyAttribute ("CreateIntersectionFunction(Metal.MTLIntersectionFunctionDescriptor,System.Action{Metal.IMTLFunction,Foundation.NSError})")]
		[DynamicDependencyAttribute ("Device")]
		[DynamicDependencyAttribute ("FunctionNames")]
		[DynamicDependencyAttribute ("InstallName")]
		[DynamicDependencyAttribute ("Label")]
		[DynamicDependencyAttribute ("Type")]
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.Interfaces | DynamicallyAccessedMemberTypes.PublicConstructors, typeof (MTLLibraryWrapper))]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static IMTLLibrary ()
		{
			GC.KeepAlive (null);
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual string Label {
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
		internal static string _GetLabel (IMTLLibrary This)
		{
			string ret;
			ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("label")), false)!;
			GC.KeepAlive (This);
			return ret;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SetLabel (IMTLLibrary This, string value)
		{
			if (value is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (value));
			var nsvalue = CFString.CreateNative (value);
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("setLabel:"), nsvalue);
			GC.KeepAlive (This);
			CFString.ReleaseNative (nsvalue);
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual IMTLDevice Device {
			[Export ("device")]
			get {
				return _GetDevice (this);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static IMTLDevice _GetDevice (IMTLLibrary This)
		{
			IMTLDevice ret;
			ret =  Runtime.GetINativeObject<IMTLDevice> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("device")), false)!;
			GC.KeepAlive (This);
			return ret;
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual string[] FunctionNames {
			[Export ("functionNames")]
			get {
				return _GetFunctionNames (this);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static string[] _GetFunctionNames (IMTLLibrary This)
		{
			string[] ret;
			ret = CFArray.StringArrayFromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("functionNames")), false)!;
			GC.KeepAlive (This);
			return ret;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("ios14.0")]
		[SupportedOSPlatform ("tvos14.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[global::Foundation.RequiredMember]
		public virtual MTLLibraryType Type {
			[Export ("type")]
			get {
				return _GetType (this);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static MTLLibraryType _GetType (IMTLLibrary This)
		{
			MTLLibraryType ret;
			ret = (MTLLibraryType) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (This.Handle, Selector.GetHandle ("type"));
			GC.KeepAlive (This);
			return ret!;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("ios14.0")]
		[SupportedOSPlatform ("tvos14.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[global::Foundation.RequiredMember]
		public virtual string? InstallName {
			[Export ("installName")]
			get {
				return _GetInstallName (this);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static string _GetInstallName (IMTLLibrary This)
		{
			string ret;
			ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("installName")), false)!;
			GC.KeepAlive (This);
			return ret;
		}
	}
	#pragma warning restore CS1573
	#pragma warning disable CS1573
	/// <summary>Extension methods to the <see cref="IMTLLibrary" /> interface to support all the methods from the MTLLibrary protocol.</summary>
	/// <remarks>
	///   <para>The extension methods for <see cref="IMTLLibrary" /> interface allow developers to treat instances of the interface as having all the optional methods of the original MTLLibrary protocol. Since the interface only contains the required members, these extension methods allow developers to call the optional members of the protocol.</para>
	/// </remarks>
	public unsafe static partial class MTLLibrary_Extensions {
		[SupportedOSPlatform ("ios14.0")]
		[SupportedOSPlatform ("tvos16.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static void CreateIntersectionFunction (this IMTLLibrary This, MTLIntersectionFunctionDescriptor descriptor, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity2V79))]global::System.Action<IMTLFunction, NSError> completionHandler)
		{
			var descriptor__handle__ = descriptor!.GetNonNullHandle (nameof (descriptor));
			if (completionHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completionHandler));
			using var block_completionHandler = Trampolines.SDActionArity2V79.CreateBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = &block_completionHandler;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("newIntersectionFunctionWithDescriptor:completionHandler:"), descriptor__handle__, (IntPtr) block_ptr_completionHandler);
			GC.KeepAlive (This);
			GC.KeepAlive (descriptor);
		}
		[return: ReleaseAttribute ()]
		[SupportedOSPlatform ("ios14.0")]
		[SupportedOSPlatform ("tvos16.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static IMTLFunction? CreateIntersectionFunction (this IMTLLibrary This, MTLIntersectionFunctionDescriptor descriptor, out NSError? error)
		{
			var descriptor__handle__ = descriptor!.GetNonNullHandle (nameof (descriptor));
			NativeHandle errorValue = IntPtr.Zero;
			IMTLFunction? ret;
			ret =  Runtime.GetINativeObject<IMTLFunction> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_ref_NativeHandle (This.Handle, Selector.GetHandle ("newIntersectionFunctionWithDescriptor:error:"), descriptor__handle__, &errorValue), true)!;
			GC.KeepAlive (This);
			GC.KeepAlive (descriptor);
			error = Runtime.GetNSObject<NSError> (errorValue)!;
			return ret!;
		}
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static Task<IMTLFunction> CreateFunctionAsync (this IMTLLibrary This, string name, MTLFunctionConstantValues constantValues)
		{
			var tcs = new TaskCompletionSource<IMTLFunction> ();
			This.CreateFunction(name, constantValues, (arg1_, arg2_) => {
				if (arg2_ is not null)
					tcs.SetException (new NSErrorException(arg2_));
				else
					tcs.SetResult (arg1_!);
			});
			return tcs.Task;
		}
	}
	#pragma warning restore CS1573
	internal unsafe sealed class MTLLibraryWrapper : BaseWrapper, IMTLLibrary {
		public MTLLibraryWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.PublicConstructors, typeof (MTLLibraryWrapper))]
		static MTLLibraryWrapper ()
		{
			GC.KeepAlive (null);
		}
		/// <param name="functionName">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("newFunctionWithName:")]
		[return: ReleaseAttribute ()]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public IMTLFunction CreateFunction (string functionName)
		{
			if (functionName is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (functionName));
			var nsfunctionName = CFString.CreateNative (functionName);
			IMTLFunction? ret;
			ret =  Runtime.GetINativeObject<IMTLFunction> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("newFunctionWithName:"), nsfunctionName), true)!;
			CFString.ReleaseNative (nsfunctionName);
			return ret!;
		}
		[Export ("newFunctionWithName:constantValues:error:")]
		[return: ReleaseAttribute ()]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe IMTLFunction? CreateFunction (string name, MTLFunctionConstantValues constantValues, out NSError error)
		{
			if (name is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (name));
			var constantValues__handle__ = constantValues!.GetNonNullHandle (nameof (constantValues));
			NativeHandle errorValue = IntPtr.Zero;
			var nsname = CFString.CreateNative (name);
			IMTLFunction? ret;
			ret =  Runtime.GetINativeObject<IMTLFunction> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_ref_NativeHandle (this.Handle, Selector.GetHandle ("newFunctionWithName:constantValues:error:"), nsname, constantValues__handle__, &errorValue), true)!;
			GC.KeepAlive (constantValues);
			CFString.ReleaseNative (nsname);
			error = Runtime.GetNSObject<NSError> (errorValue)!;
			return ret!;
		}
		[Export ("newFunctionWithName:constantValues:completionHandler:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe void CreateFunction (string name, MTLFunctionConstantValues constantValues, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity2V79))]global::System.Action<IMTLFunction, NSError> completionHandler)
		{
			if (name is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (name));
			var constantValues__handle__ = constantValues!.GetNonNullHandle (nameof (constantValues));
			if (completionHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completionHandler));
			var nsname = CFString.CreateNative (name);
			using var block_completionHandler = Trampolines.SDActionArity2V79.CreateBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = &block_completionHandler;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("newFunctionWithName:constantValues:completionHandler:"), nsname, constantValues__handle__, (IntPtr) block_ptr_completionHandler);
			GC.KeepAlive (constantValues);
			CFString.ReleaseNative (nsname);
		}
		[Export ("newFunctionWithDescriptor:completionHandler:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe void CreateFunction (MTLFunctionDescriptor descriptor, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity2V79))]global::System.Action<IMTLFunction, NSError> completionHandler)
		{
			var descriptor__handle__ = descriptor!.GetNonNullHandle (nameof (descriptor));
			if (completionHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completionHandler));
			using var block_completionHandler = Trampolines.SDActionArity2V79.CreateBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = &block_completionHandler;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("newFunctionWithDescriptor:completionHandler:"), descriptor__handle__, (IntPtr) block_ptr_completionHandler);
			GC.KeepAlive (descriptor);
		}
		[Export ("newFunctionWithDescriptor:error:")]
		[return: ReleaseAttribute ()]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe IMTLFunction? CreateFunction (MTLFunctionDescriptor descriptor, out NSError? error)
		{
			var descriptor__handle__ = descriptor!.GetNonNullHandle (nameof (descriptor));
			NativeHandle errorValue = IntPtr.Zero;
			IMTLFunction? ret;
			ret =  Runtime.GetINativeObject<IMTLFunction> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_ref_NativeHandle (this.Handle, Selector.GetHandle ("newFunctionWithDescriptor:error:"), descriptor__handle__, &errorValue), true)!;
			GC.KeepAlive (descriptor);
			error = Runtime.GetNSObject<NSError> (errorValue)!;
			return ret!;
		}
		[Export ("newIntersectionFunctionWithDescriptor:completionHandler:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe void CreateIntersectionFunction (MTLIntersectionFunctionDescriptor descriptor, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity2V79))]global::System.Action<IMTLFunction, NSError> completionHandler)
		{
			var descriptor__handle__ = descriptor!.GetNonNullHandle (nameof (descriptor));
			if (completionHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completionHandler));
			using var block_completionHandler = Trampolines.SDActionArity2V79.CreateBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = &block_completionHandler;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("newIntersectionFunctionWithDescriptor:completionHandler:"), descriptor__handle__, (IntPtr) block_ptr_completionHandler);
			GC.KeepAlive (descriptor);
		}
		[Export ("newIntersectionFunctionWithDescriptor:error:")]
		[return: ReleaseAttribute ()]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe IMTLFunction? CreateIntersectionFunction (MTLIntersectionFunctionDescriptor descriptor, out NSError? error)
		{
			var descriptor__handle__ = descriptor!.GetNonNullHandle (nameof (descriptor));
			NativeHandle errorValue = IntPtr.Zero;
			IMTLFunction? ret;
			ret =  Runtime.GetINativeObject<IMTLFunction> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_ref_NativeHandle (this.Handle, Selector.GetHandle ("newIntersectionFunctionWithDescriptor:error:"), descriptor__handle__, &errorValue), true)!;
			GC.KeepAlive (descriptor);
			error = Runtime.GetNSObject<NSError> (errorValue)!;
			return ret!;
		}
		[Export ("reflectionForFunctionWithName:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public MTLFunctionReflection? CreateFunctionReflection (string functionName)
		{
			if (functionName is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (functionName));
			var nsfunctionName = CFString.CreateNative (functionName);
			MTLFunctionReflection? ret;
			ret =  Runtime.GetNSObject<MTLFunctionReflection> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("reflectionForFunctionWithName:"), nsfunctionName), false)!;
			CFString.ReleaseNative (nsfunctionName);
			return ret!;
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public string Label {
			[Export ("label")]
			get {
				string ret;
				ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("label")), false)!;
				return ret;
			}
			[Export ("setLabel:")]
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
		public IMTLDevice Device {
			[Export ("device")]
			get {
				IMTLDevice ret;
				ret =  Runtime.GetINativeObject<IMTLDevice> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("device")), false)!;
				return ret;
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public string[] FunctionNames {
			[Export ("functionNames")]
			get {
				string[] ret;
				ret = CFArray.StringArrayFromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("functionNames")), false)!;
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("ios14.0")]
		[SupportedOSPlatform ("tvos14.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public MTLLibraryType Type {
			[Export ("type")]
			get {
				MTLLibraryType ret;
				ret = (MTLLibraryType) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("type"));
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("ios14.0")]
		[SupportedOSPlatform ("tvos14.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public string? InstallName {
			[Export ("installName")]
			get {
				string ret;
				ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("installName")), false)!;
				return ret;
			}
		}
	}
}
