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
namespace Metal {
	#pragma warning disable CS1573
	/// <summary>System protocol for shader functions that are suitable for use on a GPU in a shader or compute function.</summary>
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("tvos")]
	[Protocol (Name = "MTLFunction", WrapperType = typeof (MTLFunctionWrapper))]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "CreateArgumentEncoder", Selector = "newArgumentEncoderWithBufferIndex:", ReturnType = typeof (IMTLArgumentEncoder), ParameterType = new Type [] { typeof (UIntPtr) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "CreateArgumentEncoder", Selector = "newArgumentEncoderWithBufferIndex:reflection:", ReturnType = typeof (IMTLArgumentEncoder), ParameterType = new Type [] { typeof (UIntPtr), typeof (MTLArgument) }, ParameterByRef = new bool [] { false, true })]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "Label", Selector = "label", PropertyType = typeof (string), GetterSelector = "label", SetterSelector = "setLabel:", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "Device", Selector = "device", PropertyType = typeof (IMTLDevice), GetterSelector = "device", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "FunctionType", Selector = "functionType", PropertyType = typeof (MTLFunctionType), GetterSelector = "functionType", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "VertexAttributes", Selector = "vertexAttributes", PropertyType = typeof (MTLVertexAttribute[]), GetterSelector = "vertexAttributes", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "Name", Selector = "name", PropertyType = typeof (string), GetterSelector = "name", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "PatchType", Selector = "patchType", PropertyType = typeof (MTLPatchType), GetterSelector = "patchType", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "PatchControlPointCount", Selector = "patchControlPointCount", PropertyType = typeof (IntPtr), GetterSelector = "patchControlPointCount", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "StageInputAttributes", Selector = "stageInputAttributes", PropertyType = typeof (MTLAttribute[]), GetterSelector = "stageInputAttributes", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "FunctionConstants", Selector = "functionConstantsDictionary", PropertyType = typeof (global::Foundation.NSDictionary<NSString, global::Metal.MTLFunctionConstant>), GetterSelector = "functionConstantsDictionary", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "Options", Selector = "options", PropertyType = typeof (MTLFunctionOptions), GetterSelector = "options", ArgumentSemantic = ArgumentSemantic.None)]
	public partial interface IMTLFunction : INativeObject, IDisposable
	{
		/// <summary>Creates a new argument encoder for the specified buffer index.</summary><param name="bufferIndex">Index into a graphics function or compute function of the argument buffer.</param>
		[global::Foundation.RequiredMember]
		[Export ("newArgumentEncoderWithBufferIndex:")]
		[return: ReleaseAttribute ()]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual IMTLArgumentEncoder CreateArgumentEncoder (nuint bufferIndex)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <summary>Creates a new argument encoder for the specified buffer index.</summary><param name="bufferIndex">Index into a graphics function or compute function of the argument buffer.</param>
		[return: ReleaseAttribute ()]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static IMTLArgumentEncoder _CreateArgumentEncoder (IMTLFunction This, nuint bufferIndex)
		{
			IMTLArgumentEncoder? ret;
			ret =  Runtime.GetINativeObject<IMTLArgumentEncoder> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_UIntPtr (This.Handle, Selector.GetHandle ("newArgumentEncoderWithBufferIndex:"), bufferIndex), true)!;
			GC.KeepAlive (This);
			return ret!;
		}
		/// <summary>Creates a new argument encoder for the specified buffer index and reflection argument.</summary><param name="bufferIndex">Index into a graphics function or compute function of the argument buffer.</param><param name="reflection">The resulting reflection data.</param>
		[global::Foundation.RequiredMember]
		[Export ("newArgumentEncoderWithBufferIndex:reflection:")]
		[return: ReleaseAttribute ()]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual IMTLArgumentEncoder CreateArgumentEncoder (nuint bufferIndex, out MTLArgument? reflection)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <summary>Creates a new argument encoder for the specified buffer index and reflection argument.</summary><param name="bufferIndex">Index into a graphics function or compute function of the argument buffer.</param><param name="reflection">The resulting reflection data.</param>
		[return: ReleaseAttribute ()]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal unsafe static IMTLArgumentEncoder _CreateArgumentEncoder (IMTLFunction This, nuint bufferIndex, out MTLArgument? reflection)
		{
			NativeHandle reflectionValue = IntPtr.Zero;
			IMTLArgumentEncoder? ret;
			ret =  Runtime.GetINativeObject<IMTLArgumentEncoder> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_UIntPtr_ref_NativeHandle (This.Handle, Selector.GetHandle ("newArgumentEncoderWithBufferIndex:reflection:"), bufferIndex, &reflectionValue), true)!;
			GC.KeepAlive (This);
			reflection = Runtime.GetNSObject<MTLArgument> (reflectionValue)!;
			return ret!;
		}
		[DynamicDependencyAttribute ("CreateArgumentEncoder(System.UIntPtr,Metal.MTLArgument@)")]
		[DynamicDependencyAttribute ("CreateArgumentEncoder(System.UIntPtr)")]
		[DynamicDependencyAttribute ("Device")]
		[DynamicDependencyAttribute ("FunctionConstants")]
		[DynamicDependencyAttribute ("FunctionType")]
		[DynamicDependencyAttribute ("Label")]
		[DynamicDependencyAttribute ("Name")]
		[DynamicDependencyAttribute ("Options")]
		[DynamicDependencyAttribute ("PatchControlPointCount")]
		[DynamicDependencyAttribute ("PatchType")]
		[DynamicDependencyAttribute ("StageInputAttributes")]
		[DynamicDependencyAttribute ("VertexAttributes")]
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.Interfaces | DynamicallyAccessedMemberTypes.PublicConstructors, typeof (MTLFunctionWrapper))]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static IMTLFunction ()
		{
			GC.KeepAlive (null);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
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
		internal static string _GetLabel (IMTLFunction This)
		{
			string ret;
			ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("label")), false)!;
			GC.KeepAlive (This);
			return ret;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SetLabel (IMTLFunction This, string? value)
		{
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
		internal static IMTLDevice _GetDevice (IMTLFunction This)
		{
			IMTLDevice ret;
			ret =  Runtime.GetINativeObject<IMTLDevice> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("device")), false)!;
			GC.KeepAlive (This);
			return ret;
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual MTLFunctionType FunctionType {
			[Export ("functionType")]
			get {
				return _GetFunctionType (this);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static MTLFunctionType _GetFunctionType (IMTLFunction This)
		{
			MTLFunctionType ret;
			ret = (MTLFunctionType) (ulong) global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend (This.Handle, Selector.GetHandle ("functionType"));
			GC.KeepAlive (This);
			return ret!;
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual MTLVertexAttribute[] VertexAttributes {
			[Export ("vertexAttributes")]
			get {
				return _GetVertexAttributes (this);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static MTLVertexAttribute[] _GetVertexAttributes (IMTLFunction This)
		{
			MTLVertexAttribute[] ret;
			ret = CFArray.ArrayFromHandle<MTLVertexAttribute>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("vertexAttributes")), false)!;
			GC.KeepAlive (This);
			return ret;
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual string Name {
			[Export ("name")]
			get {
				return _GetName (this);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static string _GetName (IMTLFunction This)
		{
			string ret;
			ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("name")), false)!;
			GC.KeepAlive (This);
			return ret;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[global::Foundation.RequiredMember]
		public virtual MTLPatchType PatchType {
			[Export ("patchType")]
			get {
				return _GetPatchType (this);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static MTLPatchType _GetPatchType (IMTLFunction This)
		{
			MTLPatchType ret;
			ret = (MTLPatchType) (ulong) global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend (This.Handle, Selector.GetHandle ("patchType"));
			GC.KeepAlive (This);
			return ret!;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[global::Foundation.RequiredMember]
		public virtual nint PatchControlPointCount {
			[Export ("patchControlPointCount")]
			get {
				return _GetPatchControlPointCount (this);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static nint _GetPatchControlPointCount (IMTLFunction This)
		{
			nint ret;
			ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (This.Handle, Selector.GetHandle ("patchControlPointCount"));
			GC.KeepAlive (This);
			return ret;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[global::Foundation.RequiredMember]
		public virtual MTLAttribute[]? StageInputAttributes {
			[Export ("stageInputAttributes")]
			get {
				return _GetStageInputAttributes (this);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static MTLAttribute[] _GetStageInputAttributes (IMTLFunction This)
		{
			MTLAttribute[] ret;
			ret = CFArray.ArrayFromHandle<MTLAttribute>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("stageInputAttributes")), false)!;
			GC.KeepAlive (This);
			return ret;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[global::Foundation.RequiredMember]
		public virtual NSDictionary<NSString, MTLFunctionConstant> FunctionConstants {
			[Export ("functionConstantsDictionary")]
			get {
				return _GetFunctionConstants (this);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static NSDictionary<NSString, MTLFunctionConstant> _GetFunctionConstants (IMTLFunction This)
		{
			NSDictionary<NSString, MTLFunctionConstant> ret;
			ret =  Runtime.GetNSObject<NSDictionary<NSString, MTLFunctionConstant>> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("functionConstantsDictionary")), false)!;
			GC.KeepAlive (This);
			return ret;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("ios14.0")]
		[SupportedOSPlatform ("tvos16.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[global::Foundation.RequiredMember]
		public virtual MTLFunctionOptions Options {
			[Export ("options")]
			get {
				return _GetOptions (this);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static MTLFunctionOptions _GetOptions (IMTLFunction This)
		{
			MTLFunctionOptions ret;
			ret = (MTLFunctionOptions) (ulong) global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend (This.Handle, Selector.GetHandle ("options"));
			GC.KeepAlive (This);
			return ret!;
		}
	}
	#pragma warning restore CS1573
	#pragma warning disable CS1573
	/// <summary>Extension methods to the <see cref="IMTLFunction" /> interface to support all the methods from the MTLFunction protocol.</summary>
	/// <remarks>
	///   <para>The extension methods for <see cref="IMTLFunction" /> interface allow developers to treat instances of the interface as having all the optional methods of the original MTLFunction protocol. Since the interface only contains the required members, these extension methods allow developers to call the optional members of the protocol.</para>
	/// </remarks>
	public unsafe static partial class MTLFunction_Extensions {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MTLFunctionOptions GetOptions (this IMTLFunction This)
		{
			MTLFunctionOptions ret;
			ret = (MTLFunctionOptions) (ulong) global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend (This.Handle, Selector.GetHandle ("options"));
			GC.KeepAlive (This);
			return ret!;
		}
	}
	#pragma warning restore CS1573
	internal unsafe sealed class MTLFunctionWrapper : BaseWrapper, IMTLFunction {
		public MTLFunctionWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.PublicConstructors, typeof (MTLFunctionWrapper))]
		static MTLFunctionWrapper ()
		{
			GC.KeepAlive (null);
		}
		/// <summary>Creates a new argument encoder for the specified buffer index.</summary><param name="bufferIndex">Index into a graphics function or compute function of the argument buffer.</param>
		[Export ("newArgumentEncoderWithBufferIndex:")]
		[return: ReleaseAttribute ()]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public IMTLArgumentEncoder CreateArgumentEncoder (nuint bufferIndex)
		{
			IMTLArgumentEncoder? ret;
			ret =  Runtime.GetINativeObject<IMTLArgumentEncoder> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_UIntPtr (this.Handle, Selector.GetHandle ("newArgumentEncoderWithBufferIndex:"), bufferIndex), true)!;
			return ret!;
		}
		/// <summary>Creates a new argument encoder for the specified buffer index and reflection argument.</summary><param name="bufferIndex">Index into a graphics function or compute function of the argument buffer.</param><param name="reflection">The resulting reflection data.</param>
		[Export ("newArgumentEncoderWithBufferIndex:reflection:")]
		[return: ReleaseAttribute ()]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe IMTLArgumentEncoder CreateArgumentEncoder (nuint bufferIndex, out MTLArgument? reflection)
		{
			NativeHandle reflectionValue = IntPtr.Zero;
			IMTLArgumentEncoder? ret;
			ret =  Runtime.GetINativeObject<IMTLArgumentEncoder> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_UIntPtr_ref_NativeHandle (this.Handle, Selector.GetHandle ("newArgumentEncoderWithBufferIndex:reflection:"), bufferIndex, &reflectionValue), true)!;
			reflection = Runtime.GetNSObject<MTLArgument> (reflectionValue)!;
			return ret!;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
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
		public MTLFunctionType FunctionType {
			[Export ("functionType")]
			get {
				MTLFunctionType ret;
				ret = (MTLFunctionType) (ulong) global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("functionType"));
				return ret!;
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public MTLVertexAttribute[] VertexAttributes {
			[Export ("vertexAttributes")]
			get {
				MTLVertexAttribute[] ret;
				ret = CFArray.ArrayFromHandle<MTLVertexAttribute>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("vertexAttributes")), false)!;
				return ret;
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public string Name {
			[Export ("name")]
			get {
				string ret;
				ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("name")), false)!;
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public MTLPatchType PatchType {
			[Export ("patchType")]
			get {
				MTLPatchType ret;
				ret = (MTLPatchType) (ulong) global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("patchType"));
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public nint PatchControlPointCount {
			[Export ("patchControlPointCount")]
			get {
				nint ret;
				ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("patchControlPointCount"));
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public MTLAttribute[]? StageInputAttributes {
			[Export ("stageInputAttributes")]
			get {
				MTLAttribute[] ret;
				ret = CFArray.ArrayFromHandle<MTLAttribute>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("stageInputAttributes")), false)!;
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public NSDictionary<NSString, MTLFunctionConstant> FunctionConstants {
			[Export ("functionConstantsDictionary")]
			get {
				NSDictionary<NSString, MTLFunctionConstant> ret;
				ret =  Runtime.GetNSObject<NSDictionary<NSString, MTLFunctionConstant>> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("functionConstantsDictionary")), false)!;
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("ios14.0")]
		[SupportedOSPlatform ("tvos16.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public MTLFunctionOptions Options {
			[Export ("options")]
			get {
				MTLFunctionOptions ret;
				ret = (MTLFunctionOptions) (ulong) global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("options"));
				return ret!;
			}
		}
	}
}
