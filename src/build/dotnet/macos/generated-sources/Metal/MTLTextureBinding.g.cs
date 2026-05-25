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
	/// <summary>This interface represents the Objective-C protocol <c>MTLTextureBinding</c>.</summary>
	/// <remarks>
	///   <para>A class that implements this interface (and subclasses <see cref="NSObject" />) will be exported to Objective-C as implementing the Objective-C protocol this interface represents.</para>
	///   <para>A class may also implement members from this interface to implement members from the protocol.</para>
	/// </remarks>
	[SupportedOSPlatform ("macos13.0")]
	[SupportedOSPlatform ("ios16.0")]
	[SupportedOSPlatform ("tvos16.0")]
	[SupportedOSPlatform ("maccatalyst16.0")]
	[Protocol (Name = "MTLTextureBinding", WrapperType = typeof (MTLTextureBindingWrapper))]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "TextureType", Selector = "textureType", PropertyType = typeof (MTLTextureType), GetterSelector = "textureType", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "TextureDataType", Selector = "textureDataType", PropertyType = typeof (MTLDataType), GetterSelector = "textureDataType", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "DepthTexture", Selector = "depthTexture", PropertyType = typeof (bool), GetterSelector = "isDepthTexture", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "ArrayLength", Selector = "arrayLength", PropertyType = typeof (UIntPtr), GetterSelector = "arrayLength", ArgumentSemantic = ArgumentSemantic.None)]
	public partial interface IMTLTextureBinding : INativeObject, IDisposable, 
		Metal.IMTLBinding
	{
		[DynamicDependencyAttribute ("ArrayLength")]
		[DynamicDependencyAttribute ("DepthTexture")]
		[DynamicDependencyAttribute ("TextureDataType")]
		[DynamicDependencyAttribute ("TextureType")]
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.Interfaces | DynamicallyAccessedMemberTypes.PublicConstructors, typeof (MTLTextureBindingWrapper))]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static IMTLTextureBinding ()
		{
			GC.KeepAlive (null);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual MTLTextureType TextureType {
			[Export ("textureType")]
			get {
				return _GetTextureType (this);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static MTLTextureType _GetTextureType (IMTLTextureBinding This)
		{
			MTLTextureType ret;
			ret = (MTLTextureType) (ulong) global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend (This.Handle, Selector.GetHandle ("textureType"));
			GC.KeepAlive (This);
			return ret!;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual MTLDataType TextureDataType {
			[Export ("textureDataType")]
			get {
				return _GetTextureDataType (this);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static MTLDataType _GetTextureDataType (IMTLTextureBinding This)
		{
			MTLDataType ret;
			ret = (MTLDataType) (ulong) global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend (This.Handle, Selector.GetHandle ("textureDataType"));
			GC.KeepAlive (This);
			return ret!;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual bool DepthTexture {
			[Export ("isDepthTexture")]
			get {
				return _GetDepthTexture (this);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static bool _GetDepthTexture (IMTLTextureBinding This)
		{
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (This.Handle, Selector.GetHandle ("isDepthTexture"));
			GC.KeepAlive (This);
			return ret != 0;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual nuint ArrayLength {
			[Export ("arrayLength")]
			get {
				return _GetArrayLength (this);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static nuint _GetArrayLength (IMTLTextureBinding This)
		{
			nuint ret;
			ret = global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend (This.Handle, Selector.GetHandle ("arrayLength"));
			GC.KeepAlive (This);
			return ret;
		}
	}
	#pragma warning restore CS1573
	internal unsafe sealed class MTLTextureBindingWrapper : BaseWrapper, IMTLTextureBinding {
		public MTLTextureBindingWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.PublicConstructors, typeof (MTLTextureBindingWrapper))]
		static MTLTextureBindingWrapper ()
		{
			GC.KeepAlive (null);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public MTLTextureType TextureType {
			[Export ("textureType")]
			get {
				MTLTextureType ret;
				ret = (MTLTextureType) (ulong) global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("textureType"));
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public MTLDataType TextureDataType {
			[Export ("textureDataType")]
			get {
				MTLDataType ret;
				ret = (MTLDataType) (ulong) global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("textureDataType"));
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public bool DepthTexture {
			[Export ("isDepthTexture")]
			get {
				byte ret;
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("isDepthTexture"));
				return ret != 0;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public nuint ArrayLength {
			[Export ("arrayLength")]
			get {
				nuint ret;
				ret = global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("arrayLength"));
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("ios16.0")]
		[SupportedOSPlatform ("macos13.0")]
		[SupportedOSPlatform ("tvos16.0")]
		[SupportedOSPlatform ("maccatalyst16.0")]
		public string Name {
			[Export ("name")]
			[SupportedOSPlatform ("ios16.0")]
			[SupportedOSPlatform ("macos13.0")]
			[SupportedOSPlatform ("tvos16.0")]
			[SupportedOSPlatform ("maccatalyst16.0")]
			get {
				string ret;
				ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("name")), false)!;
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("ios16.0")]
		[SupportedOSPlatform ("macos13.0")]
		[SupportedOSPlatform ("tvos16.0")]
		[SupportedOSPlatform ("maccatalyst16.0")]
		public MTLBindingType Type {
			[Export ("type")]
			[SupportedOSPlatform ("ios16.0")]
			[SupportedOSPlatform ("macos13.0")]
			[SupportedOSPlatform ("tvos16.0")]
			[SupportedOSPlatform ("maccatalyst16.0")]
			get {
				MTLBindingType ret;
				ret = (MTLBindingType) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("type"));
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("ios16.0")]
		[SupportedOSPlatform ("macos13.0")]
		[SupportedOSPlatform ("tvos16.0")]
		[SupportedOSPlatform ("maccatalyst16.0")]
		public MTLBindingAccess Access {
			[Export ("access")]
			[SupportedOSPlatform ("ios16.0")]
			[SupportedOSPlatform ("macos13.0")]
			[SupportedOSPlatform ("tvos16.0")]
			[SupportedOSPlatform ("maccatalyst16.0")]
			get {
				MTLBindingAccess ret;
				ret = (MTLBindingAccess) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("access"));
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("ios16.0")]
		[SupportedOSPlatform ("macos13.0")]
		[SupportedOSPlatform ("tvos16.0")]
		[SupportedOSPlatform ("maccatalyst16.0")]
		public nuint Index {
			[Export ("index")]
			[SupportedOSPlatform ("ios16.0")]
			[SupportedOSPlatform ("macos13.0")]
			[SupportedOSPlatform ("tvos16.0")]
			[SupportedOSPlatform ("maccatalyst16.0")]
			get {
				nuint ret;
				ret = global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("index"));
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("ios16.0")]
		[SupportedOSPlatform ("macos13.0")]
		[SupportedOSPlatform ("tvos16.0")]
		[SupportedOSPlatform ("maccatalyst16.0")]
		public bool Used {
			[Export ("isUsed")]
			[SupportedOSPlatform ("ios16.0")]
			[SupportedOSPlatform ("macos13.0")]
			[SupportedOSPlatform ("tvos16.0")]
			[SupportedOSPlatform ("maccatalyst16.0")]
			get {
				byte ret;
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("isUsed"));
				return ret != 0;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("ios16.0")]
		[SupportedOSPlatform ("macos13.0")]
		[SupportedOSPlatform ("tvos16.0")]
		[SupportedOSPlatform ("maccatalyst16.0")]
		public bool Argument {
			[Export ("isArgument")]
			[SupportedOSPlatform ("ios16.0")]
			[SupportedOSPlatform ("macos13.0")]
			[SupportedOSPlatform ("tvos16.0")]
			[SupportedOSPlatform ("maccatalyst16.0")]
			get {
				byte ret;
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("isArgument"));
				return ret != 0;
			}
		}
	}
}
