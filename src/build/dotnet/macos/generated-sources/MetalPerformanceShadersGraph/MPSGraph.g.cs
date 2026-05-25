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
namespace MetalPerformanceShadersGraph {
	[Register("MPSGraph", true)]
	[SupportedOSPlatform ("ios14.0")]
	[SupportedOSPlatform ("tvos14.0")]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("macos")]
	public unsafe partial class MPSGraph : MPSGraphObject {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selCompileWithDevice_Feeds_TargetTensors_TargetOperations_CompilationDescriptor_X = "compileWithDevice:feeds:targetTensors:targetOperations:compilationDescriptor:";
		static readonly NativeHandle selCompileWithDevice_Feeds_TargetTensors_TargetOperations_CompilationDescriptor_XHandle = Selector.GetHandle ("compileWithDevice:feeds:targetTensors:targetOperations:compilationDescriptor:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selEncodeToCommandBuffer_Feeds_TargetOperations_ResultsDictionary_ExecutionDescriptor_X = "encodeToCommandBuffer:feeds:targetOperations:resultsDictionary:executionDescriptor:";
		static readonly NativeHandle selEncodeToCommandBuffer_Feeds_TargetOperations_ResultsDictionary_ExecutionDescriptor_XHandle = Selector.GetHandle ("encodeToCommandBuffer:feeds:targetOperations:resultsDictionary:executionDescriptor:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selEncodeToCommandBuffer_Feeds_TargetTensors_TargetOperations_ExecutionDescriptor_X = "encodeToCommandBuffer:feeds:targetTensors:targetOperations:executionDescriptor:";
		static readonly NativeHandle selEncodeToCommandBuffer_Feeds_TargetTensors_TargetOperations_ExecutionDescriptor_XHandle = Selector.GetHandle ("encodeToCommandBuffer:feeds:targetTensors:targetOperations:executionDescriptor:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selNewX = "new";
		static readonly NativeHandle selNewXHandle = Selector.GetHandle ("new");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selOptionsX = "options";
		static readonly NativeHandle selOptionsXHandle = Selector.GetHandle ("options");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selPlaceholderTensorsX = "placeholderTensors";
		static readonly NativeHandle selPlaceholderTensorsXHandle = Selector.GetHandle ("placeholderTensors");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selRunAsyncWithFeeds_TargetTensors_TargetOperations_ExecutionDescriptor_X = "runAsyncWithFeeds:targetTensors:targetOperations:executionDescriptor:";
		static readonly NativeHandle selRunAsyncWithFeeds_TargetTensors_TargetOperations_ExecutionDescriptor_XHandle = Selector.GetHandle ("runAsyncWithFeeds:targetTensors:targetOperations:executionDescriptor:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selRunAsyncWithMTLCommandQueue_Feeds_TargetOperations_ResultsDictionary_ExecutionDescriptor_X = "runAsyncWithMTLCommandQueue:feeds:targetOperations:resultsDictionary:executionDescriptor:";
		static readonly NativeHandle selRunAsyncWithMTLCommandQueue_Feeds_TargetOperations_ResultsDictionary_ExecutionDescriptor_XHandle = Selector.GetHandle ("runAsyncWithMTLCommandQueue:feeds:targetOperations:resultsDictionary:executionDescriptor:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selRunAsyncWithMTLCommandQueue_Feeds_TargetTensors_TargetOperations_ExecutionDescriptor_X = "runAsyncWithMTLCommandQueue:feeds:targetTensors:targetOperations:executionDescriptor:";
		static readonly NativeHandle selRunAsyncWithMTLCommandQueue_Feeds_TargetTensors_TargetOperations_ExecutionDescriptor_XHandle = Selector.GetHandle ("runAsyncWithMTLCommandQueue:feeds:targetTensors:targetOperations:executionDescriptor:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selRunWithFeeds_TargetTensors_TargetOperations_X = "runWithFeeds:targetTensors:targetOperations:";
		static readonly NativeHandle selRunWithFeeds_TargetTensors_TargetOperations_XHandle = Selector.GetHandle ("runWithFeeds:targetTensors:targetOperations:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selRunWithMTLCommandQueue_Feeds_TargetOperations_ResultsDictionary_X = "runWithMTLCommandQueue:feeds:targetOperations:resultsDictionary:";
		static readonly NativeHandle selRunWithMTLCommandQueue_Feeds_TargetOperations_ResultsDictionary_XHandle = Selector.GetHandle ("runWithMTLCommandQueue:feeds:targetOperations:resultsDictionary:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selRunWithMTLCommandQueue_Feeds_TargetTensors_TargetOperations_X = "runWithMTLCommandQueue:feeds:targetTensors:targetOperations:";
		static readonly NativeHandle selRunWithMTLCommandQueue_Feeds_TargetTensors_TargetOperations_XHandle = Selector.GetHandle ("runWithMTLCommandQueue:feeds:targetTensors:targetOperations:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetOptions_X = "setOptions:";
		static readonly NativeHandle selSetOptions_XHandle = Selector.GetHandle ("setOptions:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly NativeHandle class_ptr = Class.GetHandle ("MPSGraph");
		/// <summary>The Objective-C class handle for this class.</summary>
		/// <value>The pointer to the Objective-C class.</value>
		/// <remarks>
		///     Each managed class mirrors an unmanaged Objective-C class.
		///     This value contains the pointer to the Objective-C class.
		///     It is similar to calling the managed <see cref="ObjCRuntime.Class.GetHandle(string)" /> or the native <see href="https://developer.apple.com/documentation/objectivec/1418952-objc_getclass">objc_getClass</see> method with the type name.
		/// </remarks>
		public override NativeHandle ClassHandle { get { return class_ptr; } }
		/// <summary>Creates a new <see cref="MPSGraph" /> with default values.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public MPSGraph () : base (NSObjectFlag.Empty)
		{
			if (IsDirectBinding) {
				InitializeHandle (global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, global::ObjCRuntime.Selector.Init), "init");
			} else {
				unsafe {
				var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
				InitializeHandle (global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (&__objc_super__, global::ObjCRuntime.Selector.Init), "init");
				GC.KeepAlive (this);
				}
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
		protected MPSGraph (NSObjectFlag t) : base (t)
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
		protected internal MPSGraph (NativeHandle handle) : base (handle)
		{
		}

		[Export ("compileWithDevice:feeds:targetTensors:targetOperations:compilationDescriptor:")]
		[SupportedOSPlatform ("tvos15.0")]
		[SupportedOSPlatform ("ios15.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual MPSGraphExecutable Compile (MPSGraphDevice? device, NSDictionary<MPSGraphTensor, MPSGraphShapedType> feeds, MPSGraphTensor[] targetTensors, MPSGraphOperation[]? targetOperations, MPSGraphCompilationDescriptor? compilationDescriptor)
		{
			var device__handle__ = device.GetHandle ();
			var feeds__handle__ = feeds!.GetNonNullHandle (nameof (feeds));
			if (targetTensors is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (targetTensors));
			var compilationDescriptor__handle__ = compilationDescriptor.GetHandle ();
			using var nsa_targetTensors = NSArray.FromNSObjects (targetTensors);
			using var nsa_targetOperations = targetOperations is null ? null : NSArray.FromNSObjects (targetOperations);
			MPSGraphExecutable? ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<MPSGraphExecutable> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle_NativeHandle_NativeHandle (this.Handle, selCompileWithDevice_Feeds_TargetTensors_TargetOperations_CompilationDescriptor_XHandle, device__handle__, feeds__handle__, nsa_targetTensors.Handle, nsa_targetOperations.GetHandle (), compilationDescriptor__handle__), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<MPSGraphExecutable> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_NativeHandle_NativeHandle_NativeHandle_NativeHandle (&__objc_super__, selCompileWithDevice_Feeds_TargetTensors_TargetOperations_CompilationDescriptor_XHandle, device__handle__, feeds__handle__, nsa_targetTensors.Handle, nsa_targetOperations.GetHandle (), compilationDescriptor__handle__), false)!;
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (device);
			GC.KeepAlive (feeds);
			GC.KeepAlive (compilationDescriptor);
			return ret!;
		}
		[Export ("new")]
		[return: ReleaseAttribute ()]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MPSGraph Create ()
		{
			MPSGraph? ret;
			ret =  Runtime.GetNSObject<MPSGraph> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (class_ptr, selNewXHandle), true)!;
			return ret!;
		}
		[Export ("encodeToCommandBuffer:feeds:targetTensors:targetOperations:executionDescriptor:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSDictionary<MPSGraphTensor, MPSGraphTensorData> Encode (global::MetalPerformanceShaders.MPSCommandBuffer commandBuffer, NSDictionary<MPSGraphTensor, MPSGraphTensorData> feeds, MPSGraphTensor[] targetTensors, MPSGraphOperation[]? targetOperations, MPSGraphExecutionDescriptor? executionDescriptor)
		{
			var commandBuffer__handle__ = commandBuffer!.GetNonNullHandle (nameof (commandBuffer));
			var feeds__handle__ = feeds!.GetNonNullHandle (nameof (feeds));
			if (targetTensors is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (targetTensors));
			var executionDescriptor__handle__ = executionDescriptor.GetHandle ();
			using var nsa_targetTensors = NSArray.FromNSObjects (targetTensors);
			using var nsa_targetOperations = targetOperations is null ? null : NSArray.FromNSObjects (targetOperations);
			NSDictionary<MPSGraphTensor, MPSGraphTensorData>? ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<NSDictionary<MPSGraphTensor, MPSGraphTensorData>> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle_NativeHandle_NativeHandle (this.Handle, selEncodeToCommandBuffer_Feeds_TargetTensors_TargetOperations_ExecutionDescriptor_XHandle, commandBuffer__handle__, feeds__handle__, nsa_targetTensors.Handle, nsa_targetOperations.GetHandle (), executionDescriptor__handle__), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<NSDictionary<MPSGraphTensor, MPSGraphTensorData>> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_NativeHandle_NativeHandle_NativeHandle_NativeHandle (&__objc_super__, selEncodeToCommandBuffer_Feeds_TargetTensors_TargetOperations_ExecutionDescriptor_XHandle, commandBuffer__handle__, feeds__handle__, nsa_targetTensors.Handle, nsa_targetOperations.GetHandle (), executionDescriptor__handle__), false)!;
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (commandBuffer);
			GC.KeepAlive (feeds);
			GC.KeepAlive (executionDescriptor);
			return ret!;
		}
		[Export ("encodeToCommandBuffer:feeds:targetOperations:resultsDictionary:executionDescriptor:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void Encode (global::MetalPerformanceShaders.MPSCommandBuffer commandBuffer, NSDictionary<MPSGraphTensor, MPSGraphTensorData> feeds, MPSGraphOperation[]? targetOperations, NSDictionary<MPSGraphTensor, MPSGraphTensorData> resultsDictionary, MPSGraphExecutionDescriptor? executionDescriptor)
		{
			var commandBuffer__handle__ = commandBuffer!.GetNonNullHandle (nameof (commandBuffer));
			var feeds__handle__ = feeds!.GetNonNullHandle (nameof (feeds));
			var resultsDictionary__handle__ = resultsDictionary!.GetNonNullHandle (nameof (resultsDictionary));
			var executionDescriptor__handle__ = executionDescriptor.GetHandle ();
			using var nsa_targetOperations = targetOperations is null ? null : NSArray.FromNSObjects (targetOperations);
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle_NativeHandle_NativeHandle (this.Handle, selEncodeToCommandBuffer_Feeds_TargetOperations_ResultsDictionary_ExecutionDescriptor_XHandle, commandBuffer__handle__, feeds__handle__, nsa_targetOperations.GetHandle (), resultsDictionary__handle__, executionDescriptor__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_NativeHandle_NativeHandle_NativeHandle_NativeHandle (&__objc_super__, selEncodeToCommandBuffer_Feeds_TargetOperations_ResultsDictionary_ExecutionDescriptor_XHandle, commandBuffer__handle__, feeds__handle__, nsa_targetOperations.GetHandle (), resultsDictionary__handle__, executionDescriptor__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (commandBuffer);
			GC.KeepAlive (feeds);
			GC.KeepAlive (resultsDictionary);
			GC.KeepAlive (executionDescriptor);
		}
		[Export ("runWithFeeds:targetTensors:targetOperations:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSDictionary<MPSGraphTensor, MPSGraphTensorData> Run (NSDictionary<MPSGraphTensor, MPSGraphTensorData> feeds, MPSGraphTensor[] targetTensors, MPSGraphOperation[]? targetOperations)
		{
			var feeds__handle__ = feeds!.GetNonNullHandle (nameof (feeds));
			if (targetTensors is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (targetTensors));
			using var nsa_targetTensors = NSArray.FromNSObjects (targetTensors);
			using var nsa_targetOperations = targetOperations is null ? null : NSArray.FromNSObjects (targetOperations);
			NSDictionary<MPSGraphTensor, MPSGraphTensorData>? ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<NSDictionary<MPSGraphTensor, MPSGraphTensorData>> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (this.Handle, selRunWithFeeds_TargetTensors_TargetOperations_XHandle, feeds__handle__, nsa_targetTensors.Handle, nsa_targetOperations.GetHandle ()), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<NSDictionary<MPSGraphTensor, MPSGraphTensorData>> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_NativeHandle_NativeHandle (&__objc_super__, selRunWithFeeds_TargetTensors_TargetOperations_XHandle, feeds__handle__, nsa_targetTensors.Handle, nsa_targetOperations.GetHandle ()), false)!;
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (feeds);
			return ret!;
		}
		[Export ("runWithMTLCommandQueue:feeds:targetTensors:targetOperations:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSDictionary<MPSGraphTensor, MPSGraphTensorData> Run (global::Metal.IMTLCommandQueue commandQueue, NSDictionary<MPSGraphTensor, MPSGraphTensorData> feeds, MPSGraphTensor[] targetTensors, MPSGraphOperation[]? targetOperations)
		{
			var commandQueue__handle__ = commandQueue!.GetNonNullHandle (nameof (commandQueue));
			var feeds__handle__ = feeds!.GetNonNullHandle (nameof (feeds));
			if (targetTensors is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (targetTensors));
			using var nsa_targetTensors = NSArray.FromNSObjects (targetTensors);
			using var nsa_targetOperations = targetOperations is null ? null : NSArray.FromNSObjects (targetOperations);
			NSDictionary<MPSGraphTensor, MPSGraphTensorData>? ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<NSDictionary<MPSGraphTensor, MPSGraphTensorData>> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle_NativeHandle (this.Handle, selRunWithMTLCommandQueue_Feeds_TargetTensors_TargetOperations_XHandle, commandQueue__handle__, feeds__handle__, nsa_targetTensors.Handle, nsa_targetOperations.GetHandle ()), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<NSDictionary<MPSGraphTensor, MPSGraphTensorData>> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_NativeHandle_NativeHandle_NativeHandle (&__objc_super__, selRunWithMTLCommandQueue_Feeds_TargetTensors_TargetOperations_XHandle, commandQueue__handle__, feeds__handle__, nsa_targetTensors.Handle, nsa_targetOperations.GetHandle ()), false)!;
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (commandQueue);
			GC.KeepAlive (feeds);
			return ret!;
		}
		[Export ("runWithMTLCommandQueue:feeds:targetOperations:resultsDictionary:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void Run (global::Metal.IMTLCommandQueue commandQueue, NSDictionary<MPSGraphTensor, MPSGraphTensorData> feeds, MPSGraphOperation[]? targetOperations, NSDictionary<MPSGraphTensor, MPSGraphTensorData> resultsDictionary)
		{
			var commandQueue__handle__ = commandQueue!.GetNonNullHandle (nameof (commandQueue));
			var feeds__handle__ = feeds!.GetNonNullHandle (nameof (feeds));
			var resultsDictionary__handle__ = resultsDictionary!.GetNonNullHandle (nameof (resultsDictionary));
			using var nsa_targetOperations = targetOperations is null ? null : NSArray.FromNSObjects (targetOperations);
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle_NativeHandle (this.Handle, selRunWithMTLCommandQueue_Feeds_TargetOperations_ResultsDictionary_XHandle, commandQueue__handle__, feeds__handle__, nsa_targetOperations.GetHandle (), resultsDictionary__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_NativeHandle_NativeHandle_NativeHandle (&__objc_super__, selRunWithMTLCommandQueue_Feeds_TargetOperations_ResultsDictionary_XHandle, commandQueue__handle__, feeds__handle__, nsa_targetOperations.GetHandle (), resultsDictionary__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (commandQueue);
			GC.KeepAlive (feeds);
			GC.KeepAlive (resultsDictionary);
		}
		[Export ("runAsyncWithFeeds:targetTensors:targetOperations:executionDescriptor:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSDictionary<MPSGraphTensor, MPSGraphTensorData> RunAsync (NSDictionary<MPSGraphTensor, MPSGraphTensorData> feeds, MPSGraphTensor[] targetTensors, MPSGraphOperation[]? targetOperations, MPSGraphExecutionDescriptor? executionDescriptor)
		{
			var feeds__handle__ = feeds!.GetNonNullHandle (nameof (feeds));
			if (targetTensors is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (targetTensors));
			var executionDescriptor__handle__ = executionDescriptor.GetHandle ();
			using var nsa_targetTensors = NSArray.FromNSObjects (targetTensors);
			using var nsa_targetOperations = targetOperations is null ? null : NSArray.FromNSObjects (targetOperations);
			NSDictionary<MPSGraphTensor, MPSGraphTensorData>? ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<NSDictionary<MPSGraphTensor, MPSGraphTensorData>> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle_NativeHandle (this.Handle, selRunAsyncWithFeeds_TargetTensors_TargetOperations_ExecutionDescriptor_XHandle, feeds__handle__, nsa_targetTensors.Handle, nsa_targetOperations.GetHandle (), executionDescriptor__handle__), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<NSDictionary<MPSGraphTensor, MPSGraphTensorData>> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_NativeHandle_NativeHandle_NativeHandle (&__objc_super__, selRunAsyncWithFeeds_TargetTensors_TargetOperations_ExecutionDescriptor_XHandle, feeds__handle__, nsa_targetTensors.Handle, nsa_targetOperations.GetHandle (), executionDescriptor__handle__), false)!;
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (feeds);
			GC.KeepAlive (executionDescriptor);
			return ret!;
		}
		[Export ("runAsyncWithMTLCommandQueue:feeds:targetTensors:targetOperations:executionDescriptor:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSDictionary<MPSGraphTensor, MPSGraphTensorData> RunAsync (global::Metal.IMTLCommandQueue commandQueue, NSDictionary<MPSGraphTensor, MPSGraphTensorData> feeds, MPSGraphTensor[] targetTensors, MPSGraphOperation[]? targetOperations, MPSGraphExecutionDescriptor? executionDescriptor)
		{
			var commandQueue__handle__ = commandQueue!.GetNonNullHandle (nameof (commandQueue));
			var feeds__handle__ = feeds!.GetNonNullHandle (nameof (feeds));
			if (targetTensors is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (targetTensors));
			var executionDescriptor__handle__ = executionDescriptor.GetHandle ();
			using var nsa_targetTensors = NSArray.FromNSObjects (targetTensors);
			using var nsa_targetOperations = targetOperations is null ? null : NSArray.FromNSObjects (targetOperations);
			NSDictionary<MPSGraphTensor, MPSGraphTensorData>? ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<NSDictionary<MPSGraphTensor, MPSGraphTensorData>> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle_NativeHandle_NativeHandle (this.Handle, selRunAsyncWithMTLCommandQueue_Feeds_TargetTensors_TargetOperations_ExecutionDescriptor_XHandle, commandQueue__handle__, feeds__handle__, nsa_targetTensors.Handle, nsa_targetOperations.GetHandle (), executionDescriptor__handle__), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<NSDictionary<MPSGraphTensor, MPSGraphTensorData>> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_NativeHandle_NativeHandle_NativeHandle_NativeHandle (&__objc_super__, selRunAsyncWithMTLCommandQueue_Feeds_TargetTensors_TargetOperations_ExecutionDescriptor_XHandle, commandQueue__handle__, feeds__handle__, nsa_targetTensors.Handle, nsa_targetOperations.GetHandle (), executionDescriptor__handle__), false)!;
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (commandQueue);
			GC.KeepAlive (feeds);
			GC.KeepAlive (executionDescriptor);
			return ret!;
		}
		[Export ("runAsyncWithMTLCommandQueue:feeds:targetOperations:resultsDictionary:executionDescriptor:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void RunAsync (global::Metal.IMTLCommandQueue commandQueue, NSDictionary<MPSGraphTensor, MPSGraphTensorData> feeds, MPSGraphOperation[]? targetOperations, NSDictionary<MPSGraphTensor, MPSGraphTensorData> resultsDictionary, MPSGraphExecutionDescriptor? executionDescriptor)
		{
			var commandQueue__handle__ = commandQueue!.GetNonNullHandle (nameof (commandQueue));
			var feeds__handle__ = feeds!.GetNonNullHandle (nameof (feeds));
			var resultsDictionary__handle__ = resultsDictionary!.GetNonNullHandle (nameof (resultsDictionary));
			var executionDescriptor__handle__ = executionDescriptor.GetHandle ();
			using var nsa_targetOperations = targetOperations is null ? null : NSArray.FromNSObjects (targetOperations);
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle_NativeHandle_NativeHandle (this.Handle, selRunAsyncWithMTLCommandQueue_Feeds_TargetOperations_ResultsDictionary_ExecutionDescriptor_XHandle, commandQueue__handle__, feeds__handle__, nsa_targetOperations.GetHandle (), resultsDictionary__handle__, executionDescriptor__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_NativeHandle_NativeHandle_NativeHandle_NativeHandle (&__objc_super__, selRunAsyncWithMTLCommandQueue_Feeds_TargetOperations_ResultsDictionary_ExecutionDescriptor_XHandle, commandQueue__handle__, feeds__handle__, nsa_targetOperations.GetHandle (), resultsDictionary__handle__, executionDescriptor__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (commandQueue);
			GC.KeepAlive (feeds);
			GC.KeepAlive (resultsDictionary);
			GC.KeepAlive (executionDescriptor);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual MPSGraphOptions Options {
			[Export ("options", ArgumentSemantic.Assign)]
			get {
				MPSGraphOptions ret;
				if (IsDirectBinding) {
					ret = (MPSGraphOptions) global::ObjCRuntime.Messaging.UInt64_objc_msgSend (this.Handle, selOptionsXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = (MPSGraphOptions) global::ObjCRuntime.Messaging.UInt64_objc_msgSendSuper (&__objc_super__, selOptionsXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[Export ("setOptions:", ArgumentSemantic.Assign)]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_UInt64 (this.Handle, selSetOptions_XHandle, (UInt64)value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_UInt64 (&__objc_super__, selSetOptions_XHandle, (UInt64)value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual MPSGraphTensor[] PlaceholderTensors {
			[Export ("placeholderTensors")]
			get {
				MPSGraphTensor[]? ret;
				if (IsDirectBinding) {
					ret = CFArray.ArrayFromHandle<MPSGraphTensor>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selPlaceholderTensorsXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFArray.ArrayFromHandle<MPSGraphTensor>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selPlaceholderTensorsXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
	} /* class MPSGraph */
}
