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
namespace FSKit {
	#pragma warning disable CS1573
	/// <summary>This interface represents the Objective-C protocol <c>FSVolumePathConfOperations</c>.</summary>
	/// <remarks>
	///   <para>A class that implements this interface (and subclasses <see cref="NSObject" />) will be exported to Objective-C as implementing the Objective-C protocol this interface represents.</para>
	///   <para>A class may also implement members from this interface to implement members from the protocol.</para>
	/// </remarks>
	[SupportedOSPlatform ("macos15.4")]
	[Experimental ("APL0002")]
	[Protocol (Name = "FSVolumePathConfOperations", WrapperType = typeof (FSVolumePathConfOperationsWrapper), BackwardsCompatibleCodeGeneration = false)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "MaximumLinkCount", Selector = "maximumLinkCount", PropertyType = typeof (IntPtr), GetterSelector = "maximumLinkCount", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "MaximumNameLength", Selector = "maximumNameLength", PropertyType = typeof (IntPtr), GetterSelector = "maximumNameLength", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "RestrictsOwnershipChanges", Selector = "restrictsOwnershipChanges", PropertyType = typeof (bool), GetterSelector = "restrictsOwnershipChanges", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "TruncatesLongNames", Selector = "truncatesLongNames", PropertyType = typeof (bool), GetterSelector = "truncatesLongNames", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = false, IsProperty = true, IsStatic = false, Name = "MaximumXattrSize", Selector = "maximumXattrSize", PropertyType = typeof (IntPtr), GetterSelector = "maximumXattrSize", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = false, IsProperty = true, IsStatic = false, Name = "MaximumXattrSizeInBits", Selector = "maximumXattrSizeInBits", PropertyType = typeof (IntPtr), GetterSelector = "maximumXattrSizeInBits", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = false, IsProperty = true, IsStatic = false, Name = "MaximumFileSize", Selector = "maximumFileSize", PropertyType = typeof (ulong), GetterSelector = "maximumFileSize", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = false, IsProperty = true, IsStatic = false, Name = "MaximumFileSizeInBits", Selector = "maximumFileSizeInBits", PropertyType = typeof (IntPtr), GetterSelector = "maximumFileSizeInBits", ArgumentSemantic = ArgumentSemantic.None)]
	public partial interface IFSVolumePathConfOperations : INativeObject, IDisposable
	{
		[DynamicDependencyAttribute ("MaximumFileSize")]
		[DynamicDependencyAttribute ("MaximumFileSizeInBits")]
		[DynamicDependencyAttribute ("MaximumLinkCount")]
		[DynamicDependencyAttribute ("MaximumNameLength")]
		[DynamicDependencyAttribute ("MaximumXattrSize")]
		[DynamicDependencyAttribute ("MaximumXattrSizeInBits")]
		[DynamicDependencyAttribute ("RestrictsOwnershipChanges")]
		[DynamicDependencyAttribute ("TruncatesLongNames")]
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.Interfaces | DynamicallyAccessedMemberTypes.PublicConstructors, typeof (FSVolumePathConfOperationsWrapper))]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static IFSVolumePathConfOperations ()
		{
			GC.KeepAlive (null);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual nint MaximumLinkCount {
			[Export ("maximumLinkCount")]
			get {
				return _GetMaximumLinkCount (this);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static nint _GetMaximumLinkCount (IFSVolumePathConfOperations This)
		{
			nint ret;
			ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (This.Handle, Selector.GetHandle ("maximumLinkCount"));
			GC.KeepAlive (This);
			return ret;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual nint MaximumNameLength {
			[Export ("maximumNameLength")]
			get {
				return _GetMaximumNameLength (this);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static nint _GetMaximumNameLength (IFSVolumePathConfOperations This)
		{
			nint ret;
			ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (This.Handle, Selector.GetHandle ("maximumNameLength"));
			GC.KeepAlive (This);
			return ret;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual bool RestrictsOwnershipChanges {
			[Export ("restrictsOwnershipChanges")]
			get {
				return _GetRestrictsOwnershipChanges (this);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static bool _GetRestrictsOwnershipChanges (IFSVolumePathConfOperations This)
		{
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (This.Handle, Selector.GetHandle ("restrictsOwnershipChanges"));
			GC.KeepAlive (This);
			return ret != 0;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual bool TruncatesLongNames {
			[Export ("truncatesLongNames")]
			get {
				return _GetTruncatesLongNames (this);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static bool _GetTruncatesLongNames (IFSVolumePathConfOperations This)
		{
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (This.Handle, Selector.GetHandle ("truncatesLongNames"));
			GC.KeepAlive (This);
			return ret != 0;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.OptionalMember]
		public virtual nint MaximumXattrSize {
			[Export ("maximumXattrSize")]
			get {
				return _GetMaximumXattrSize (this);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static nint _GetMaximumXattrSize (IFSVolumePathConfOperations This)
		{
			nint ret;
			ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (This.Handle, Selector.GetHandle ("maximumXattrSize"));
			GC.KeepAlive (This);
			return ret;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.OptionalMember]
		public virtual nint MaximumXattrSizeInBits {
			[Export ("maximumXattrSizeInBits")]
			get {
				return _GetMaximumXattrSizeInBits (this);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static nint _GetMaximumXattrSizeInBits (IFSVolumePathConfOperations This)
		{
			nint ret;
			ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (This.Handle, Selector.GetHandle ("maximumXattrSizeInBits"));
			GC.KeepAlive (This);
			return ret;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.OptionalMember]
		public virtual ulong MaximumFileSize {
			[Export ("maximumFileSize")]
			get {
				return _GetMaximumFileSize (this);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static ulong _GetMaximumFileSize (IFSVolumePathConfOperations This)
		{
			ulong ret;
			ret = global::ObjCRuntime.Messaging.UInt64_objc_msgSend (This.Handle, Selector.GetHandle ("maximumFileSize"));
			GC.KeepAlive (This);
			return ret;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.OptionalMember]
		public virtual nint MaximumFileSizeInBits {
			[Export ("maximumFileSizeInBits")]
			get {
				return _GetMaximumFileSizeInBits (this);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static nint _GetMaximumFileSizeInBits (IFSVolumePathConfOperations This)
		{
			nint ret;
			ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (This.Handle, Selector.GetHandle ("maximumFileSizeInBits"));
			GC.KeepAlive (This);
			return ret;
		}
	}
	#pragma warning restore CS1573
	[Experimental ("APL0002")]
	internal unsafe sealed class FSVolumePathConfOperationsWrapper : BaseWrapper, IFSVolumePathConfOperations {
		[Experimental ("APL0002")]
		public FSVolumePathConfOperationsWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.PublicConstructors, typeof (FSVolumePathConfOperationsWrapper))]
		static FSVolumePathConfOperationsWrapper ()
		{
			GC.KeepAlive (null);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public nint MaximumLinkCount {
			[Export ("maximumLinkCount")]
			get {
				nint ret;
				ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("maximumLinkCount"));
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public nint MaximumNameLength {
			[Export ("maximumNameLength")]
			get {
				nint ret;
				ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("maximumNameLength"));
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public bool RestrictsOwnershipChanges {
			[Export ("restrictsOwnershipChanges")]
			get {
				byte ret;
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("restrictsOwnershipChanges"));
				return ret != 0;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public bool TruncatesLongNames {
			[Export ("truncatesLongNames")]
			get {
				byte ret;
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("truncatesLongNames"));
				return ret != 0;
			}
		}
	}
}
