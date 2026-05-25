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
	/// <summary>This interface represents the Objective-C protocol <c>FSVolumeXattrOperations</c>.</summary>
	/// <remarks>
	///   <para>A class that implements this interface (and subclasses <see cref="NSObject" />) will be exported to Objective-C as implementing the Objective-C protocol this interface represents.</para>
	///   <para>A class may also implement members from this interface to implement members from the protocol.</para>
	/// </remarks>
	[SupportedOSPlatform ("macos15.4")]
	[Experimental ("APL0002")]
	[Protocol (Name = "FSVolumeXattrOperations", WrapperType = typeof (FSVolumeXattrOperationsWrapper), BackwardsCompatibleCodeGeneration = false)]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "GetSupportedXattrNames", Selector = "supportedXattrNamesForItem:", ReturnType = typeof (FSKit.FSFileName[]), ParameterType = new Type [] { typeof (FSKit.FSItem) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "GetXattr", Selector = "getXattrNamed:ofItem:replyHandler:", ParameterType = new Type [] { typeof (FSKit.FSFileName), typeof (FSKit.FSItem), typeof (FSKit.FSVolumeXattrOperationsGetHandler) }, ParameterByRef = new bool [] { false, false, false }, ParameterBlockProxy = new Type? [] { null, null, typeof (ObjCRuntime.Trampolines.NIDFSVolumeXattrOperationsGetHandler) })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "SetXattr", Selector = "setXattrNamed:toData:onItem:policy:replyHandler:", ParameterType = new Type [] { typeof (FSKit.FSFileName), typeof (NSData), typeof (FSKit.FSItem), typeof (FSKit.FSSetXattrPolicy), typeof (FSKit.FSVolumeXattrOperationsSetHandler) }, ParameterByRef = new bool [] { false, false, false, false, false }, ParameterBlockProxy = new Type? [] { null, null, null, null, typeof (ObjCRuntime.Trampolines.NIDFSVolumeXattrOperationsSetHandler) })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "ListXattrs", Selector = "listXattrsOfItem:replyHandler:", ParameterType = new Type [] { typeof (FSKit.FSItem), typeof (FSKit.FSVolumeXattrOperationsListHandler) }, ParameterByRef = new bool [] { false, false }, ParameterBlockProxy = new Type? [] { null, typeof (ObjCRuntime.Trampolines.NIDFSVolumeXattrOperationsListHandler) })]
	[ProtocolMember (IsRequired = false, IsProperty = true, IsStatic = false, Name = "XattrOperationsInhibited", Selector = "xattrOperationsInhibited", PropertyType = typeof (bool), GetterSelector = "xattrOperationsInhibited", SetterSelector = "setXattrOperationsInhibited:", ArgumentSemantic = ArgumentSemantic.None)]
	public partial interface IFSVolumeXattrOperations : INativeObject, IDisposable
	{
		[global::Foundation.OptionalMember]
		[Export ("supportedXattrNamesForItem:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual FSFileName[]? GetSupportedXattrNames (FSItem item)
		{
			return _GetSupportedXattrNames (this, item);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static FSFileName[]? _GetSupportedXattrNames (IFSVolumeXattrOperations This, FSItem item)
		{
			var item__handle__ = item!.GetNonNullHandle (nameof (item));
			FSFileName[]? ret;
			ret = CFArray.ArrayFromHandle<FSFileName>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("supportedXattrNamesForItem:"), item__handle__), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (item);
			return ret!;
		}
		[global::Foundation.RequiredMember]
		[Export ("getXattrNamed:ofItem:replyHandler:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void GetXattr (FSFileName name, FSItem item, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDFSVolumeXattrOperationsGetHandler))]FSVolumeXattrOperationsGetHandler reply)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal unsafe static void _GetXattr (IFSVolumeXattrOperations This, FSFileName name, FSItem item, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDFSVolumeXattrOperationsGetHandler))]FSVolumeXattrOperationsGetHandler reply)
		{
			var name__handle__ = name!.GetNonNullHandle (nameof (name));
			var item__handle__ = item!.GetNonNullHandle (nameof (item));
			if (reply is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (reply));
			using var block_reply = Trampolines.SDFSVolumeXattrOperationsGetHandler.CreateBlock (reply);
			BlockLiteral *block_ptr_reply = &block_reply;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("getXattrNamed:ofItem:replyHandler:"), name__handle__, item__handle__, (IntPtr) block_ptr_reply);
			GC.KeepAlive (This);
			GC.KeepAlive (name);
			GC.KeepAlive (item);
		}
		[global::Foundation.RequiredMember]
		[Export ("setXattrNamed:toData:onItem:policy:replyHandler:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void SetXattr (FSFileName name, NSData? value, FSItem item, FSSetXattrPolicy policy, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDFSVolumeXattrOperationsSetHandler))]FSVolumeXattrOperationsSetHandler reply)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal unsafe static void _SetXattr (IFSVolumeXattrOperations This, FSFileName name, NSData? value, FSItem item, FSSetXattrPolicy policy, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDFSVolumeXattrOperationsSetHandler))]FSVolumeXattrOperationsSetHandler reply)
		{
			var name__handle__ = name!.GetNonNullHandle (nameof (name));
			var value__handle__ = value.GetHandle ();
			var item__handle__ = item!.GetNonNullHandle (nameof (item));
			if (reply is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (reply));
			using var block_reply = Trampolines.SDFSVolumeXattrOperationsSetHandler.CreateBlock (reply);
			BlockLiteral *block_ptr_reply = &block_reply;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle_UIntPtr_NativeHandle (This.Handle, Selector.GetHandle ("setXattrNamed:toData:onItem:policy:replyHandler:"), name__handle__, value__handle__, item__handle__, (UIntPtr) (ulong) policy, (IntPtr) block_ptr_reply);
			GC.KeepAlive (This);
			GC.KeepAlive (name);
			GC.KeepAlive (value);
			GC.KeepAlive (item);
		}
		[global::Foundation.RequiredMember]
		[Export ("listXattrsOfItem:replyHandler:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void ListXattrs (FSItem item, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDFSVolumeXattrOperationsListHandler))]FSVolumeXattrOperationsListHandler reply)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal unsafe static void _ListXattrs (IFSVolumeXattrOperations This, FSItem item, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDFSVolumeXattrOperationsListHandler))]FSVolumeXattrOperationsListHandler reply)
		{
			var item__handle__ = item!.GetNonNullHandle (nameof (item));
			if (reply is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (reply));
			using var block_reply = Trampolines.SDFSVolumeXattrOperationsListHandler.CreateBlock (reply);
			BlockLiteral *block_ptr_reply = &block_reply;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("listXattrsOfItem:replyHandler:"), item__handle__, (IntPtr) block_ptr_reply);
			GC.KeepAlive (This);
			GC.KeepAlive (item);
		}
		[DynamicDependencyAttribute ("GetSupportedXattrNames(FSKit.FSItem)")]
		[DynamicDependencyAttribute ("GetXattr(FSKit.FSFileName,FSKit.FSItem,FSKit.FSVolumeXattrOperationsGetHandler)")]
		[DynamicDependencyAttribute ("ListXattrs(FSKit.FSItem,FSKit.FSVolumeXattrOperationsListHandler)")]
		[DynamicDependencyAttribute ("SetXattr(FSKit.FSFileName,Foundation.NSData,FSKit.FSItem,FSKit.FSSetXattrPolicy,FSKit.FSVolumeXattrOperationsSetHandler)")]
		[DynamicDependencyAttribute ("XattrOperationsInhibited")]
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.Interfaces | DynamicallyAccessedMemberTypes.PublicConstructors, typeof (FSVolumeXattrOperationsWrapper))]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static IFSVolumeXattrOperations ()
		{
			GC.KeepAlive (null);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.OptionalMember]
		public virtual bool XattrOperationsInhibited {
			[Export ("xattrOperationsInhibited")]
			get {
				return _GetXattrOperationsInhibited (this);
			}
			[Export ("setXattrOperationsInhibited:")]
			set {
				_SetXattrOperationsInhibited (this, value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static bool _GetXattrOperationsInhibited (IFSVolumeXattrOperations This)
		{
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (This.Handle, Selector.GetHandle ("xattrOperationsInhibited"));
			GC.KeepAlive (This);
			return ret != 0;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SetXattrOperationsInhibited (IFSVolumeXattrOperations This, bool value)
		{
			global::ObjCRuntime.Messaging.void_objc_msgSend_bool (This.Handle, Selector.GetHandle ("setXattrOperationsInhibited:"), value ? (byte) 1 : (byte) 0);
			GC.KeepAlive (This);
		}
	}
	#pragma warning restore CS1573
	[Experimental ("APL0002")]
	internal unsafe sealed class FSVolumeXattrOperationsWrapper : BaseWrapper, IFSVolumeXattrOperations {
		[Experimental ("APL0002")]
		public FSVolumeXattrOperationsWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.PublicConstructors, typeof (FSVolumeXattrOperationsWrapper))]
		static FSVolumeXattrOperationsWrapper ()
		{
			GC.KeepAlive (null);
		}
		[Export ("getXattrNamed:ofItem:replyHandler:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe void GetXattr (FSFileName name, FSItem item, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDFSVolumeXattrOperationsGetHandler))]FSVolumeXattrOperationsGetHandler reply)
		{
			var name__handle__ = name!.GetNonNullHandle (nameof (name));
			var item__handle__ = item!.GetNonNullHandle (nameof (item));
			if (reply is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (reply));
			using var block_reply = Trampolines.SDFSVolumeXattrOperationsGetHandler.CreateBlock (reply);
			BlockLiteral *block_ptr_reply = &block_reply;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("getXattrNamed:ofItem:replyHandler:"), name__handle__, item__handle__, (IntPtr) block_ptr_reply);
			GC.KeepAlive (name);
			GC.KeepAlive (item);
		}
		[Export ("setXattrNamed:toData:onItem:policy:replyHandler:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe void SetXattr (FSFileName name, NSData? value, FSItem item, FSSetXattrPolicy policy, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDFSVolumeXattrOperationsSetHandler))]FSVolumeXattrOperationsSetHandler reply)
		{
			var name__handle__ = name!.GetNonNullHandle (nameof (name));
			var value__handle__ = value.GetHandle ();
			var item__handle__ = item!.GetNonNullHandle (nameof (item));
			if (reply is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (reply));
			using var block_reply = Trampolines.SDFSVolumeXattrOperationsSetHandler.CreateBlock (reply);
			BlockLiteral *block_ptr_reply = &block_reply;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle_UIntPtr_NativeHandle (this.Handle, Selector.GetHandle ("setXattrNamed:toData:onItem:policy:replyHandler:"), name__handle__, value__handle__, item__handle__, (UIntPtr) (ulong) policy, (IntPtr) block_ptr_reply);
			GC.KeepAlive (name);
			GC.KeepAlive (value);
			GC.KeepAlive (item);
		}
		[Export ("listXattrsOfItem:replyHandler:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe void ListXattrs (FSItem item, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDFSVolumeXattrOperationsListHandler))]FSVolumeXattrOperationsListHandler reply)
		{
			var item__handle__ = item!.GetNonNullHandle (nameof (item));
			if (reply is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (reply));
			using var block_reply = Trampolines.SDFSVolumeXattrOperationsListHandler.CreateBlock (reply);
			BlockLiteral *block_ptr_reply = &block_reply;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("listXattrsOfItem:replyHandler:"), item__handle__, (IntPtr) block_ptr_reply);
			GC.KeepAlive (item);
		}
	}
}
