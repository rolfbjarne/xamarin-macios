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
	/// <summary>This interface represents the Objective-C protocol <c>FSManageableResourceMaintenanceOperations</c>.</summary>
	/// <remarks>
	///   <para>A class that implements this interface (and subclasses <see cref="NSObject" />) will be exported to Objective-C as implementing the Objective-C protocol this interface represents.</para>
	///   <para>A class may also implement members from this interface to implement members from the protocol.</para>
	/// </remarks>
	[SupportedOSPlatform ("macos15.4")]
	[Experimental ("APL0002")]
	[Protocol (Name = "FSManageableResourceMaintenanceOperations", WrapperType = typeof (FSManageableResourceMaintenanceOperationsWrapper), BackwardsCompatibleCodeGeneration = false)]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "StartCheckWithTask", Selector = "startCheckWithTask:options:error:", ReturnType = typeof (NSProgress), ParameterType = new Type [] { typeof (FSKit.FSTask), typeof (FSKit.FSTaskOptions), typeof (NSError) }, ParameterByRef = new bool [] { false, false, true })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "StartFormat", Selector = "startFormatWithTask:options:error:", ReturnType = typeof (NSProgress), ParameterType = new Type [] { typeof (FSKit.FSTask), typeof (FSKit.FSTaskOptions), typeof (NSError) }, ParameterByRef = new bool [] { false, false, true })]
	public partial interface IFSManageableResourceMaintenanceOperations : INativeObject, IDisposable
	{
		[global::Foundation.RequiredMember]
		[Export ("startCheckWithTask:options:error:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual NSProgress StartCheckWithTask (FSTask task, FSTaskOptions options, out NSError? error)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal unsafe static NSProgress _StartCheckWithTask (IFSManageableResourceMaintenanceOperations This, FSTask task, FSTaskOptions options, out NSError? error)
		{
			var task__handle__ = task!.GetNonNullHandle (nameof (task));
			var options__handle__ = options!.GetNonNullHandle (nameof (options));
			NativeHandle errorValue = IntPtr.Zero;
			NSProgress? ret;
			ret =  Runtime.GetNSObject<NSProgress> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_ref_NativeHandle (This.Handle, Selector.GetHandle ("startCheckWithTask:options:error:"), task__handle__, options__handle__, &errorValue), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (task);
			GC.KeepAlive (options);
			error = Runtime.GetNSObject<NSError> (errorValue)!;
			return ret!;
		}
		[global::Foundation.RequiredMember]
		[Export ("startFormatWithTask:options:error:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual NSProgress? StartFormat (FSTask task, FSTaskOptions options, out NSError? error)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal unsafe static NSProgress? _StartFormat (IFSManageableResourceMaintenanceOperations This, FSTask task, FSTaskOptions options, out NSError? error)
		{
			var task__handle__ = task!.GetNonNullHandle (nameof (task));
			var options__handle__ = options!.GetNonNullHandle (nameof (options));
			NativeHandle errorValue = IntPtr.Zero;
			NSProgress? ret;
			ret =  Runtime.GetNSObject<NSProgress> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_ref_NativeHandle (This.Handle, Selector.GetHandle ("startFormatWithTask:options:error:"), task__handle__, options__handle__, &errorValue), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (task);
			GC.KeepAlive (options);
			error = Runtime.GetNSObject<NSError> (errorValue)!;
			return ret!;
		}
		[DynamicDependencyAttribute ("StartCheckWithTask(FSKit.FSTask,FSKit.FSTaskOptions,Foundation.NSError@)")]
		[DynamicDependencyAttribute ("StartFormat(FSKit.FSTask,FSKit.FSTaskOptions,Foundation.NSError@)")]
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.Interfaces | DynamicallyAccessedMemberTypes.PublicConstructors, typeof (FSManageableResourceMaintenanceOperationsWrapper))]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static IFSManageableResourceMaintenanceOperations ()
		{
			GC.KeepAlive (null);
		}
	}
	#pragma warning restore CS1573
	[Experimental ("APL0002")]
	internal unsafe sealed class FSManageableResourceMaintenanceOperationsWrapper : BaseWrapper, IFSManageableResourceMaintenanceOperations {
		[Experimental ("APL0002")]
		public FSManageableResourceMaintenanceOperationsWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.PublicConstructors, typeof (FSManageableResourceMaintenanceOperationsWrapper))]
		static FSManageableResourceMaintenanceOperationsWrapper ()
		{
			GC.KeepAlive (null);
		}
		[Export ("startCheckWithTask:options:error:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe NSProgress StartCheckWithTask (FSTask task, FSTaskOptions options, out NSError? error)
		{
			var task__handle__ = task!.GetNonNullHandle (nameof (task));
			var options__handle__ = options!.GetNonNullHandle (nameof (options));
			NativeHandle errorValue = IntPtr.Zero;
			NSProgress? ret;
			ret =  Runtime.GetNSObject<NSProgress> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_ref_NativeHandle (this.Handle, Selector.GetHandle ("startCheckWithTask:options:error:"), task__handle__, options__handle__, &errorValue), false)!;
			GC.KeepAlive (task);
			GC.KeepAlive (options);
			error = Runtime.GetNSObject<NSError> (errorValue)!;
			return ret!;
		}
		[Export ("startFormatWithTask:options:error:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe NSProgress? StartFormat (FSTask task, FSTaskOptions options, out NSError? error)
		{
			var task__handle__ = task!.GetNonNullHandle (nameof (task));
			var options__handle__ = options!.GetNonNullHandle (nameof (options));
			NativeHandle errorValue = IntPtr.Zero;
			NSProgress? ret;
			ret =  Runtime.GetNSObject<NSProgress> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_ref_NativeHandle (this.Handle, Selector.GetHandle ("startFormatWithTask:options:error:"), task__handle__, options__handle__, &errorValue), false)!;
			GC.KeepAlive (task);
			GC.KeepAlive (options);
			error = Runtime.GetNSObject<NSError> (errorValue)!;
			return ret!;
		}
	}
}
