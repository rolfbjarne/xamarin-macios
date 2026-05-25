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
	/// <summary>This interface represents the Objective-C protocol <c>MTLBufferBinding</c>.</summary>
	/// <remarks>
	///   <para>A class that implements this interface (and subclasses <see cref="NSObject" />) will be exported to Objective-C as implementing the Objective-C protocol this interface represents.</para>
	///   <para>A class may also implement members from this interface to implement members from the protocol.</para>
	/// </remarks>
	[SupportedOSPlatform ("macos13.0")]
	[SupportedOSPlatform ("ios16.0")]
	[SupportedOSPlatform ("tvos16.0")]
	[SupportedOSPlatform ("maccatalyst16.0")]
	[Protocol (Name = "MTLBufferBinding", WrapperType = typeof (MTLBufferBindingWrapper))]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "BufferAlignment", Selector = "bufferAlignment", PropertyType = typeof (UIntPtr), GetterSelector = "bufferAlignment", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "BufferDataSize", Selector = "bufferDataSize", PropertyType = typeof (UIntPtr), GetterSelector = "bufferDataSize", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "BufferDataType", Selector = "bufferDataType", PropertyType = typeof (MTLDataType), GetterSelector = "bufferDataType", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "BufferStructType", Selector = "bufferStructType", PropertyType = typeof (MTLStructType), GetterSelector = "bufferStructType", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "BufferPointerType", Selector = "bufferPointerType", PropertyType = typeof (MTLPointerType), GetterSelector = "bufferPointerType", ArgumentSemantic = ArgumentSemantic.None)]
	public partial interface IMTLBufferBinding : INativeObject, IDisposable, 
		Metal.IMTLBinding
	{
		[DynamicDependencyAttribute ("BufferAlignment")]
		[DynamicDependencyAttribute ("BufferDataSize")]
		[DynamicDependencyAttribute ("BufferDataType")]
		[DynamicDependencyAttribute ("BufferPointerType")]
		[DynamicDependencyAttribute ("BufferStructType")]
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.Interfaces | DynamicallyAccessedMemberTypes.PublicConstructors, typeof (MTLBufferBindingWrapper))]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static IMTLBufferBinding ()
		{
			GC.KeepAlive (null);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual nuint BufferAlignment {
			[Export ("bufferAlignment")]
			get {
				return _GetBufferAlignment (this);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static nuint _GetBufferAlignment (IMTLBufferBinding This)
		{
			nuint ret;
			ret = global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend (This.Handle, Selector.GetHandle ("bufferAlignment"));
			GC.KeepAlive (This);
			return ret;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual nuint BufferDataSize {
			[Export ("bufferDataSize")]
			get {
				return _GetBufferDataSize (this);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static nuint _GetBufferDataSize (IMTLBufferBinding This)
		{
			nuint ret;
			ret = global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend (This.Handle, Selector.GetHandle ("bufferDataSize"));
			GC.KeepAlive (This);
			return ret;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual MTLDataType BufferDataType {
			[Export ("bufferDataType")]
			get {
				return _GetBufferDataType (this);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static MTLDataType _GetBufferDataType (IMTLBufferBinding This)
		{
			MTLDataType ret;
			ret = (MTLDataType) (ulong) global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend (This.Handle, Selector.GetHandle ("bufferDataType"));
			GC.KeepAlive (This);
			return ret!;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual MTLStructType? BufferStructType {
			[Export ("bufferStructType")]
			get {
				return _GetBufferStructType (this);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static MTLStructType _GetBufferStructType (IMTLBufferBinding This)
		{
			MTLStructType ret;
			ret =  Runtime.GetNSObject<MTLStructType> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("bufferStructType")), false)!;
			GC.KeepAlive (This);
			return ret;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual MTLPointerType? BufferPointerType {
			[Export ("bufferPointerType")]
			get {
				return _GetBufferPointerType (this);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static MTLPointerType _GetBufferPointerType (IMTLBufferBinding This)
		{
			MTLPointerType ret;
			ret =  Runtime.GetNSObject<MTLPointerType> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("bufferPointerType")), false)!;
			GC.KeepAlive (This);
			return ret;
		}
	}
	#pragma warning restore CS1573
	internal unsafe sealed class MTLBufferBindingWrapper : BaseWrapper, IMTLBufferBinding {
		public MTLBufferBindingWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.PublicConstructors, typeof (MTLBufferBindingWrapper))]
		static MTLBufferBindingWrapper ()
		{
			GC.KeepAlive (null);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public nuint BufferAlignment {
			[Export ("bufferAlignment")]
			get {
				nuint ret;
				ret = global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("bufferAlignment"));
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public nuint BufferDataSize {
			[Export ("bufferDataSize")]
			get {
				nuint ret;
				ret = global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("bufferDataSize"));
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public MTLDataType BufferDataType {
			[Export ("bufferDataType")]
			get {
				MTLDataType ret;
				ret = (MTLDataType) (ulong) global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("bufferDataType"));
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public MTLStructType? BufferStructType {
			[Export ("bufferStructType")]
			get {
				MTLStructType ret;
				ret =  Runtime.GetNSObject<MTLStructType> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("bufferStructType")), false)!;
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public MTLPointerType? BufferPointerType {
			[Export ("bufferPointerType")]
			get {
				MTLPointerType ret;
				ret =  Runtime.GetNSObject<MTLPointerType> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("bufferPointerType")), false)!;
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
