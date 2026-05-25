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
namespace NetworkExtension {
	/// <summary>Filters network data.</summary><related type="externalDocumentation" href="https://developer.apple.com/library/ios/documentation/NetworkExtension/Reference/NEFilterDataProviderClassRef/index.html">Apple documentation for <c>NEFilterDataProvider</c></related>
	[Register("NEFilterDataProvider", true)]
	[UnsupportedOSPlatform ("tvos")]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	public unsafe partial class NEFilterDataProvider : NEFilterProvider {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selApplySettings_CompletionHandler_X = "applySettings:completionHandler:";
		static readonly NativeHandle selApplySettings_CompletionHandler_XHandle = Selector.GetHandle ("applySettings:completionHandler:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selHandleInboundDataCompleteForFlow_X = "handleInboundDataCompleteForFlow:";
		static readonly NativeHandle selHandleInboundDataCompleteForFlow_XHandle = Selector.GetHandle ("handleInboundDataCompleteForFlow:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selHandleInboundDataFromFlow_ReadBytesStartOffset_ReadBytes_X = "handleInboundDataFromFlow:readBytesStartOffset:readBytes:";
		static readonly NativeHandle selHandleInboundDataFromFlow_ReadBytesStartOffset_ReadBytes_XHandle = Selector.GetHandle ("handleInboundDataFromFlow:readBytesStartOffset:readBytes:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selHandleNewFlow_X = "handleNewFlow:";
		static readonly NativeHandle selHandleNewFlow_XHandle = Selector.GetHandle ("handleNewFlow:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selHandleOutboundDataCompleteForFlow_X = "handleOutboundDataCompleteForFlow:";
		static readonly NativeHandle selHandleOutboundDataCompleteForFlow_XHandle = Selector.GetHandle ("handleOutboundDataCompleteForFlow:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selHandleOutboundDataFromFlow_ReadBytesStartOffset_ReadBytes_X = "handleOutboundDataFromFlow:readBytesStartOffset:readBytes:";
		static readonly NativeHandle selHandleOutboundDataFromFlow_ReadBytesStartOffset_ReadBytes_XHandle = Selector.GetHandle ("handleOutboundDataFromFlow:readBytesStartOffset:readBytes:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selResumeFlow_WithVerdict_X = "resumeFlow:withVerdict:";
		static readonly NativeHandle selResumeFlow_WithVerdict_XHandle = Selector.GetHandle ("resumeFlow:withVerdict:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selUpdateFlow_UsingVerdict_ForDirection_X = "updateFlow:usingVerdict:forDirection:";
		static readonly NativeHandle selUpdateFlow_UsingVerdict_ForDirection_XHandle = Selector.GetHandle ("updateFlow:usingVerdict:forDirection:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly NativeHandle class_ptr = Class.GetHandle ("NEFilterDataProvider");
		/// <summary>The Objective-C class handle for this class.</summary>
		/// <value>The pointer to the Objective-C class.</value>
		/// <remarks>
		///     Each managed class mirrors an unmanaged Objective-C class.
		///     This value contains the pointer to the Objective-C class.
		///     It is similar to calling the managed <see cref="ObjCRuntime.Class.GetHandle(string)" /> or the native <see href="https://developer.apple.com/documentation/objectivec/1418952-objc_getclass">objc_getClass</see> method with the type name.
		/// </remarks>
		public override NativeHandle ClassHandle { get { return class_ptr; } }
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
		protected NEFilterDataProvider (NSObjectFlag t) : base (t)
		{
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
		protected internal NEFilterDataProvider (NativeHandle handle) : base (handle)
		{
		}

		[Export ("applySettings:completionHandler:")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void ApplySettings (NEFilterSettings? settings, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V16))]global::System.Action<NSError> completionHandler)
		{
			var settings__handle__ = settings.GetHandle ();
			if (completionHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completionHandler));
			using var block_completionHandler = Trampolines.SDActionArity1V16.CreateBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = &block_completionHandler;
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (this.Handle, selApplySettings_CompletionHandler_XHandle, settings__handle__, (IntPtr) block_ptr_completionHandler);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, selApplySettings_CompletionHandler_XHandle, settings__handle__, (IntPtr) block_ptr_completionHandler);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (settings);
		}
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual Task ApplySettingsAsync (NEFilterSettings? settings)
		{
			var tcs = new TaskCompletionSource<bool> ();
			ApplySettings(settings, (obj_) => {
				if (obj_ is not null)
					tcs.SetException (new NSErrorException(obj_));
				else
					tcs.SetResult (true);
			});
			return tcs.Task;
		}
		/// <param name="flow">To be added.</param><summary>Method that is called to make a filtering decision for inbound data flow after the data is seen.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("handleInboundDataCompleteForFlow:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NEFilterDataVerdict HandleInboundDataCompleteForFlow (NEFilterFlow flow)
		{
			var flow__handle__ = flow!.GetNonNullHandle (nameof (flow));
			NEFilterDataVerdict? ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<NEFilterDataVerdict> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, selHandleInboundDataCompleteForFlow_XHandle, flow__handle__), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<NEFilterDataVerdict> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle (&__objc_super__, selHandleInboundDataCompleteForFlow_XHandle, flow__handle__), false)!;
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (flow);
			return ret!;
		}
		/// <param name="flow">To be added.</param><param name="offset">To be added.</param><param name="readBytes">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("handleInboundDataFromFlow:readBytesStartOffset:readBytes:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NEFilterDataVerdict HandleInboundDataFromFlow (NEFilterFlow flow, nuint offset, NSData readBytes)
		{
			var flow__handle__ = flow!.GetNonNullHandle (nameof (flow));
			var readBytes__handle__ = readBytes!.GetNonNullHandle (nameof (readBytes));
			NEFilterDataVerdict? ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<NEFilterDataVerdict> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_UIntPtr_NativeHandle (this.Handle, selHandleInboundDataFromFlow_ReadBytesStartOffset_ReadBytes_XHandle, flow__handle__, offset, readBytes__handle__), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<NEFilterDataVerdict> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_UIntPtr_NativeHandle (&__objc_super__, selHandleInboundDataFromFlow_ReadBytesStartOffset_ReadBytes_XHandle, flow__handle__, offset, readBytes__handle__), false)!;
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (flow);
			GC.KeepAlive (readBytes);
			return ret!;
		}
		/// <param name="flow">To be added.</param><summary>Method that is called to filter a new network flow.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("handleNewFlow:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NEFilterNewFlowVerdict HandleNewFlow (NEFilterFlow flow)
		{
			var flow__handle__ = flow!.GetNonNullHandle (nameof (flow));
			NEFilterNewFlowVerdict? ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<NEFilterNewFlowVerdict> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, selHandleNewFlow_XHandle, flow__handle__), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<NEFilterNewFlowVerdict> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle (&__objc_super__, selHandleNewFlow_XHandle, flow__handle__), false)!;
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (flow);
			return ret!;
		}
		/// <param name="flow">To be added.</param><summary>ethod that is called to make a filtering decision for outbound data flow after the data is seen.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("handleOutboundDataCompleteForFlow:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NEFilterDataVerdict HandleOutboundDataCompleteForFlow (NEFilterFlow flow)
		{
			var flow__handle__ = flow!.GetNonNullHandle (nameof (flow));
			NEFilterDataVerdict? ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<NEFilterDataVerdict> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, selHandleOutboundDataCompleteForFlow_XHandle, flow__handle__), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<NEFilterDataVerdict> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle (&__objc_super__, selHandleOutboundDataCompleteForFlow_XHandle, flow__handle__), false)!;
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (flow);
			return ret!;
		}
		/// <param name="flow">To be added.</param><param name="offset">To be added.</param><param name="readBytes">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("handleOutboundDataFromFlow:readBytesStartOffset:readBytes:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NEFilterDataVerdict HandleOutboundDataFromFlow (NEFilterFlow flow, nuint offset, NSData readBytes)
		{
			var flow__handle__ = flow!.GetNonNullHandle (nameof (flow));
			var readBytes__handle__ = readBytes!.GetNonNullHandle (nameof (readBytes));
			NEFilterDataVerdict? ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<NEFilterDataVerdict> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_UIntPtr_NativeHandle (this.Handle, selHandleOutboundDataFromFlow_ReadBytesStartOffset_ReadBytes_XHandle, flow__handle__, offset, readBytes__handle__), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<NEFilterDataVerdict> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_UIntPtr_NativeHandle (&__objc_super__, selHandleOutboundDataFromFlow_ReadBytesStartOffset_ReadBytes_XHandle, flow__handle__, offset, readBytes__handle__), false)!;
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (flow);
			GC.KeepAlive (readBytes);
			return ret!;
		}
		[Export ("resumeFlow:withVerdict:")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void ResumeFlow (NEFilterFlow flow, NEFilterVerdict verdict)
		{
			var flow__handle__ = flow!.GetNonNullHandle (nameof (flow));
			var verdict__handle__ = verdict!.GetNonNullHandle (nameof (verdict));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (this.Handle, selResumeFlow_WithVerdict_XHandle, flow__handle__, verdict__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, selResumeFlow_WithVerdict_XHandle, flow__handle__, verdict__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (flow);
			GC.KeepAlive (verdict);
		}
		[Export ("updateFlow:usingVerdict:forDirection:")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void UpdateFlow (NEFilterSocketFlow flow, NEFilterDataVerdict verdict, NETrafficDirection direction)
		{
			var flow__handle__ = flow!.GetNonNullHandle (nameof (flow));
			var verdict__handle__ = verdict!.GetNonNullHandle (nameof (verdict));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_IntPtr (this.Handle, selUpdateFlow_UsingVerdict_ForDirection_XHandle, flow__handle__, verdict__handle__, (IntPtr) (long) direction);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_NativeHandle_IntPtr (&__objc_super__, selUpdateFlow_UsingVerdict_ForDirection_XHandle, flow__handle__, verdict__handle__, (IntPtr) (long) direction);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (flow);
			GC.KeepAlive (verdict);
		}
	} /* class NEFilterDataProvider */
}
