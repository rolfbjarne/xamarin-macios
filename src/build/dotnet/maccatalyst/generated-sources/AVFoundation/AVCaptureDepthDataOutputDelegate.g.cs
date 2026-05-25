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
namespace AVFoundation {
	#pragma warning disable CS1573
	/// <summary>Delegate for receiving captured depth data.</summary>
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("tvos17.0")]
	[UnsupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("ios")]
	[Protocol (Name = "AVCaptureDepthDataOutputDelegate", WrapperType = typeof (AVCaptureDepthDataOutputDelegateWrapper))]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidOutputDepthData", Selector = "depthDataOutput:didOutputDepthData:timestamp:connection:", ParameterType = new Type [] { typeof (AVCaptureDepthDataOutput), typeof (AVDepthData), typeof (CMTime), typeof (AVCaptureConnection) }, ParameterByRef = new bool [] { false, false, false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidDropDepthData", Selector = "depthDataOutput:didDropDepthData:timestamp:connection:reason:", ParameterType = new Type [] { typeof (AVCaptureDepthDataOutput), typeof (AVDepthData), typeof (CMTime), typeof (AVCaptureConnection), typeof (AVCaptureOutputDataDroppedReason) }, ParameterByRef = new bool [] { false, false, false, false, false })]
	public partial interface IAVCaptureDepthDataOutputDelegate : INativeObject, IDisposable
	{
		/// <param name="output">The output that provided the data.</param><param name="depthData">The captured data.</param><param name="timestamp">The time the data was captured.</param><param name="connection">The capture connection.</param><summary>Method that is called when depth data is output.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("depthDataOutput:didOutputDepthData:timestamp:connection:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidOutputDepthData (AVCaptureDepthDataOutput output, AVDepthData depthData, global::CoreMedia.CMTime timestamp, AVCaptureConnection connection)
		{
			_DidOutputDepthData (this, output, depthData, timestamp, connection);
		}
		/// <param name="output">The output that provided the data.</param><param name="depthData">The captured data.</param><param name="timestamp">The time the data was captured.</param><param name="connection">The capture connection.</param><summary>Method that is called when depth data is output.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _DidOutputDepthData (IAVCaptureDepthDataOutputDelegate This, AVCaptureDepthDataOutput output, AVDepthData depthData, global::CoreMedia.CMTime timestamp, AVCaptureConnection connection)
		{
			var output__handle__ = output!.GetNonNullHandle (nameof (output));
			var depthData__handle__ = depthData!.GetNonNullHandle (nameof (depthData));
			var connection__handle__ = connection!.GetNonNullHandle (nameof (connection));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_CMTime_NativeHandle (This.Handle, Selector.GetHandle ("depthDataOutput:didOutputDepthData:timestamp:connection:"), output__handle__, depthData__handle__, timestamp, connection__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (output);
			GC.KeepAlive (depthData);
			GC.KeepAlive (connection);
		}
		/// <param name="output">The output that dropped the data.</param><param name="depthData">The dropped data.</param><param name="timestamp">The time the data was captured.</param><param name="connection">The capture connection.</param><param name="reason">The reason the depth data was dropped.</param><summary>Method that is called when depth data is dropped.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("depthDataOutput:didDropDepthData:timestamp:connection:reason:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidDropDepthData (AVCaptureDepthDataOutput output, AVDepthData depthData, global::CoreMedia.CMTime timestamp, AVCaptureConnection connection, AVCaptureOutputDataDroppedReason reason)
		{
			_DidDropDepthData (this, output, depthData, timestamp, connection, reason);
		}
		/// <param name="output">The output that dropped the data.</param><param name="depthData">The dropped data.</param><param name="timestamp">The time the data was captured.</param><param name="connection">The capture connection.</param><param name="reason">The reason the depth data was dropped.</param><summary>Method that is called when depth data is dropped.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _DidDropDepthData (IAVCaptureDepthDataOutputDelegate This, AVCaptureDepthDataOutput output, AVDepthData depthData, global::CoreMedia.CMTime timestamp, AVCaptureConnection connection, AVCaptureOutputDataDroppedReason reason)
		{
			var output__handle__ = output!.GetNonNullHandle (nameof (output));
			var depthData__handle__ = depthData!.GetNonNullHandle (nameof (depthData));
			var connection__handle__ = connection!.GetNonNullHandle (nameof (connection));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_CMTime_NativeHandle_IntPtr (This.Handle, Selector.GetHandle ("depthDataOutput:didDropDepthData:timestamp:connection:reason:"), output__handle__, depthData__handle__, timestamp, connection__handle__, (IntPtr) (long) reason);
			GC.KeepAlive (This);
			GC.KeepAlive (output);
			GC.KeepAlive (depthData);
			GC.KeepAlive (connection);
		}
		[DynamicDependencyAttribute ("DidDropDepthData(AVFoundation.AVCaptureDepthDataOutput,AVFoundation.AVDepthData,CoreMedia.CMTime,AVFoundation.AVCaptureConnection,AVFoundation.AVCaptureOutputDataDroppedReason)")]
		[DynamicDependencyAttribute ("DidOutputDepthData(AVFoundation.AVCaptureDepthDataOutput,AVFoundation.AVDepthData,CoreMedia.CMTime,AVFoundation.AVCaptureConnection)")]
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.Interfaces | DynamicallyAccessedMemberTypes.PublicConstructors, typeof (AVCaptureDepthDataOutputDelegateWrapper))]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static IAVCaptureDepthDataOutputDelegate ()
		{
			GC.KeepAlive (null);
		}
	}
	#pragma warning restore CS1573
	#pragma warning disable CS1573
	/// <summary>Extension methods to the <see cref="IAVCaptureDepthDataOutputDelegate" /> interface to support all the methods from the AVCaptureDepthDataOutputDelegate protocol.</summary>
	/// <remarks>
	///   <para>The extension methods for <see cref="IAVCaptureDepthDataOutputDelegate" /> interface allow developers to treat instances of the interface as having all the optional methods of the original AVCaptureDepthDataOutputDelegate protocol. Since the interface only contains the required members, these extension methods allow developers to call the optional members of the protocol.</para>
	/// </remarks>
	public unsafe static partial class AVCaptureDepthDataOutputDelegate_Extensions {
		/// <param name="output">The output that provided the data.</param><param name="depthData">The captured data.</param><param name="timestamp">The time the data was captured.</param><param name="connection">The capture connection.</param><summary>Method that is called when depth data is output.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void DidOutputDepthData (this IAVCaptureDepthDataOutputDelegate This, AVCaptureDepthDataOutput output, AVDepthData depthData, global::CoreMedia.CMTime timestamp, AVCaptureConnection connection)
		{
			var output__handle__ = output!.GetNonNullHandle (nameof (output));
			var depthData__handle__ = depthData!.GetNonNullHandle (nameof (depthData));
			var connection__handle__ = connection!.GetNonNullHandle (nameof (connection));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_CMTime_NativeHandle (This.Handle, Selector.GetHandle ("depthDataOutput:didOutputDepthData:timestamp:connection:"), output__handle__, depthData__handle__, timestamp, connection__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (output);
			GC.KeepAlive (depthData);
			GC.KeepAlive (connection);
		}
		/// <param name="output">The output that dropped the data.</param><param name="depthData">The dropped data.</param><param name="timestamp">The time the data was captured.</param><param name="connection">The capture connection.</param><param name="reason">The reason the depth data was dropped.</param><summary>Method that is called when depth data is dropped.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void DidDropDepthData (this IAVCaptureDepthDataOutputDelegate This, AVCaptureDepthDataOutput output, AVDepthData depthData, global::CoreMedia.CMTime timestamp, AVCaptureConnection connection, AVCaptureOutputDataDroppedReason reason)
		{
			var output__handle__ = output!.GetNonNullHandle (nameof (output));
			var depthData__handle__ = depthData!.GetNonNullHandle (nameof (depthData));
			var connection__handle__ = connection!.GetNonNullHandle (nameof (connection));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_CMTime_NativeHandle_IntPtr (This.Handle, Selector.GetHandle ("depthDataOutput:didDropDepthData:timestamp:connection:reason:"), output__handle__, depthData__handle__, timestamp, connection__handle__, (IntPtr) (long) reason);
			GC.KeepAlive (This);
			GC.KeepAlive (output);
			GC.KeepAlive (depthData);
			GC.KeepAlive (connection);
		}
	}
	#pragma warning restore CS1573
	internal unsafe sealed class AVCaptureDepthDataOutputDelegateWrapper : BaseWrapper, IAVCaptureDepthDataOutputDelegate {
		public AVCaptureDepthDataOutputDelegateWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.PublicConstructors, typeof (AVCaptureDepthDataOutputDelegateWrapper))]
		static AVCaptureDepthDataOutputDelegateWrapper ()
		{
			GC.KeepAlive (null);
		}
	}
}
namespace AVFoundation {
	/// <summary>Delegate for receiving captured depth data.</summary>
	[Protocol()]
	[Register("Microsoft_MacCatalyst__AVFoundation_AVCaptureDepthDataOutputDelegate", false)]
	[Model]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("tvos17.0")]
	[UnsupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("ios")]
	public unsafe partial class AVCaptureDepthDataOutputDelegate : NSObject, IAVCaptureDepthDataOutputDelegate {
		/// <summary>Creates a new <see cref="AVCaptureDepthDataOutputDelegate" /> with default values.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public AVCaptureDepthDataOutputDelegate () : base (NSObjectFlag.Empty)
		{
			IsDirectBinding = false;
			unsafe {
			var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
			InitializeHandle (global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (&__objc_super__, global::ObjCRuntime.Selector.GetHandle ("init")), "init");
			GC.KeepAlive (this);
			}
		}

		/// <summary>Constructor to call on derived classes to skip initialization and merely allocate the object.</summary>
		/// <param name="t">Unused sentinel value, pass NSObjectFlag.Empty.</param>
		/// <remarks>
		///     <para>
		///         This constructor should be called by derived classes when they completely construct the object in managed code and merely want the runtime to allocate and initialize the <see cref="Foundation.NSObject" />.
		///         This is required to implement the two-step initialization process that Objective-C uses, the first step is to perform the object allocation, the second step is to initialize the object.
		///         When developers invoke this constructor, they take advantage of a direct path that goes all the way up to <see cref="Foundation.NSObject" /> to merely allocate the object's memory and bind the Objective-C and C# objects together.
		///         The actual initialization of the object is up to the developer.
		///     </para>
		///     <para>
		///         This constructor is typically used by the binding generator to allocate the object, but prevent the actual initialization to take place.
		///         Once the allocation has taken place, the constructor has to initialize the object.
		///         With constructors generated by the binding generator this means that it manually invokes one of the "init" methods to initialize the object.
		///     </para>
		///     <para>It is the developer's responsibility to completely initialize the object if they chain up using this constructor chain.</para>
		///     <para>
		///         In general, if the developer's constructor invokes the corresponding base implementation, then it should also call an Objective-C init method.
		///         If this is not the case, developers should instead chain to the proper constructor in their class.
		///     </para>
		///     <para>
		///         The argument value is ignored and merely ensures that the only code that is executed is the construction phase is the basic <see cref="Foundation.NSObject" /> allocation and runtime type registration.
		///         Typically the chaining would look like this:
		///     </para>
		///     <example>
		///             <code lang="csharp lang-csharp"><![CDATA[
		/// //
		/// // The NSObjectFlag constructor merely allocates the object and registers the C# class with the Objective-C runtime if necessary.
		/// // No actual initXxx method is invoked, that is done later in the constructor
		/// //
		/// // This is taken from the iOS SDK's source code for the UIView class:
		/// //
		/// [Export ("initWithFrame:")]
		/// public UIView (CGRect frame) : base (NSObjectFlag.Empty)
		/// {
		///     // Invoke the init method now.
		///     var initWithFrame = new Selector ("initWithFrame:").Handle;
		///     if (IsDirectBinding) {
		///         Handle = ObjCRuntime.Messaging.IntPtr_objc_msgSend_CGRect (this.Handle, initWithFrame, frame);
		///     } else {
		///         unsafe {
		///             var __objc_super__ = new ObjCRuntime.ObjCSuper (this);
		///             Handle = ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper_CGRect (&__objc_super__, initWithFrame, frame);
		///         }
		///         GC.KeepAlive (this);
		///     }
		/// }
		/// ]]></code>
		///     </example>
		/// </remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected AVCaptureDepthDataOutputDelegate (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = false;
		}

		/// <summary>A constructor used when creating managed representations of unmanaged objects. Called by the runtime.</summary>
		/// <param name="handle">Pointer (handle) to the unmanaged object.</param>
		/// <remarks>
		///     <para>
		///         This constructor is invoked by the runtime infrastructure (<see cref="ObjCRuntime.Runtime.GetNSObject(System.IntPtr)" />) to create a new managed representation for a pointer to an unmanaged Objective-C object.
		///         Developers should not invoke this method directly, instead they should call <see cref="ObjCRuntime.Runtime.GetNSObject(System.IntPtr)" /> as it will prevent two instances of a managed object pointing to the same native object.
		///     </para>
		/// </remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal AVCaptureDepthDataOutputDelegate (NativeHandle handle) : base (handle)
		{
			IsDirectBinding = false;
		}

		/// <param name="output">The output that dropped the data.</param><param name="depthData">The dropped data.</param><param name="timestamp">The time the data was captured.</param><param name="connection">The capture connection.</param><param name="reason">The reason the depth data was dropped.</param><summary>Method that is called when depth data is dropped.</summary><remarks>To be added.</remarks>
		[Export ("depthDataOutput:didDropDepthData:timestamp:connection:reason:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidDropDepthData (AVCaptureDepthDataOutput output, AVDepthData depthData, global::CoreMedia.CMTime timestamp, AVCaptureConnection connection, AVCaptureOutputDataDroppedReason reason)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="output">The output that provided the data.</param><param name="depthData">The captured data.</param><param name="timestamp">The time the data was captured.</param><param name="connection">The capture connection.</param><summary>Method that is called when depth data is output.</summary><remarks>To be added.</remarks>
		[Export ("depthDataOutput:didOutputDepthData:timestamp:connection:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidOutputDepthData (AVCaptureDepthDataOutput output, AVDepthData depthData, global::CoreMedia.CMTime timestamp, AVCaptureConnection connection)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
	} /* class AVCaptureDepthDataOutputDelegate */
}
