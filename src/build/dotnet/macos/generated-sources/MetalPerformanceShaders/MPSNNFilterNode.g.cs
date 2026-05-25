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
namespace MetalPerformanceShaders {
	/// <summary>A placeholder node in a neural network graph for an image filtering stage.</summary>
	[Register("MPSNNFilterNode", true)]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("tvos")]
	public unsafe partial class MPSNNFilterNode : NSObject {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selGradientFilterWithSource_X = "gradientFilterWithSource:";
		static readonly NativeHandle selGradientFilterWithSource_XHandle = Selector.GetHandle ("gradientFilterWithSource:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selGradientFilterWithSources_X = "gradientFilterWithSources:";
		static readonly NativeHandle selGradientFilterWithSources_XHandle = Selector.GetHandle ("gradientFilterWithSources:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selGradientFiltersWithSource_X = "gradientFiltersWithSource:";
		static readonly NativeHandle selGradientFiltersWithSource_XHandle = Selector.GetHandle ("gradientFiltersWithSource:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selGradientFiltersWithSources_X = "gradientFiltersWithSources:";
		static readonly NativeHandle selGradientFiltersWithSources_XHandle = Selector.GetHandle ("gradientFiltersWithSources:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selLabelX = "label";
		static readonly NativeHandle selLabelXHandle = Selector.GetHandle ("label");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selPaddingPolicyX = "paddingPolicy";
		static readonly NativeHandle selPaddingPolicyXHandle = Selector.GetHandle ("paddingPolicy");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selResultImageX = "resultImage";
		static readonly NativeHandle selResultImageXHandle = Selector.GetHandle ("resultImage");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selResultStateX = "resultState";
		static readonly NativeHandle selResultStateXHandle = Selector.GetHandle ("resultState");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selResultStatesX = "resultStates";
		static readonly NativeHandle selResultStatesXHandle = Selector.GetHandle ("resultStates");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetLabel_X = "setLabel:";
		static readonly NativeHandle selSetLabel_XHandle = Selector.GetHandle ("setLabel:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetPaddingPolicy_X = "setPaddingPolicy:";
		static readonly NativeHandle selSetPaddingPolicy_XHandle = Selector.GetHandle ("setPaddingPolicy:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selTrainingGraphWithSourceGradient_NodeHandler_X = "trainingGraphWithSourceGradient:nodeHandler:";
		static readonly NativeHandle selTrainingGraphWithSourceGradient_NodeHandler_XHandle = Selector.GetHandle ("trainingGraphWithSourceGradient:nodeHandler:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly NativeHandle class_ptr = Class.GetHandle ("MPSNNFilterNode");
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
		protected MPSNNFilterNode (NSObjectFlag t) : base (t)
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
		protected internal MPSNNFilterNode (NativeHandle handle) : base (handle)
		{
		}

		/// <param name="gradientImageSource">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("gradientFilterWithSource:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual MPSNNGradientFilterNode GetFilter (MPSNNImageNode gradientImageSource)
		{
			var gradientImageSource__handle__ = gradientImageSource!.GetNonNullHandle (nameof (gradientImageSource));
			MPSNNGradientFilterNode? ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<MPSNNGradientFilterNode> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, selGradientFilterWithSource_XHandle, gradientImageSource__handle__), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<MPSNNGradientFilterNode> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle (&__objc_super__, selGradientFilterWithSource_XHandle, gradientImageSource__handle__), false)!;
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (gradientImageSource);
			return ret!;
		}
		/// <param name="gradientImagesSources">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("gradientFilterWithSources:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual MPSNNGradientFilterNode GetFilter (MPSNNImageNode[] gradientImagesSources)
		{
			if (gradientImagesSources is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (gradientImagesSources));
			using var nsa_gradientImagesSources = NSArray.FromNSObjects (gradientImagesSources);
			MPSNNGradientFilterNode ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<MPSNNGradientFilterNode> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, selGradientFilterWithSources_XHandle, nsa_gradientImagesSources.Handle), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<MPSNNGradientFilterNode> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle (&__objc_super__, selGradientFilterWithSources_XHandle, nsa_gradientImagesSources.Handle), false)!;
					GC.KeepAlive (this);
				}
			}
			return ret;
		}
		/// <param name="gradientImagesSources">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("gradientFiltersWithSources:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual MPSNNGradientFilterNode[] GetFilters (MPSNNImageNode[] gradientImagesSources)
		{
			if (gradientImagesSources is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (gradientImagesSources));
			using var nsa_gradientImagesSources = NSArray.FromNSObjects (gradientImagesSources);
			MPSNNGradientFilterNode[] ret;
			if (IsDirectBinding) {
				ret = CFArray.ArrayFromHandle<MPSNNGradientFilterNode>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, selGradientFiltersWithSources_XHandle, nsa_gradientImagesSources.Handle), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = CFArray.ArrayFromHandle<MPSNNGradientFilterNode>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle (&__objc_super__, selGradientFiltersWithSources_XHandle, nsa_gradientImagesSources.Handle), false)!;
					GC.KeepAlive (this);
				}
			}
			return ret;
		}
		/// <param name="gradientImageSource">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("gradientFiltersWithSource:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual MPSNNGradientFilterNode[] GetFilters (MPSNNImageNode gradientImageSource)
		{
			var gradientImageSource__handle__ = gradientImageSource!.GetNonNullHandle (nameof (gradientImageSource));
			MPSNNGradientFilterNode[]? ret;
			if (IsDirectBinding) {
				ret = CFArray.ArrayFromHandle<MPSNNGradientFilterNode>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, selGradientFiltersWithSource_XHandle, gradientImageSource__handle__), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = CFArray.ArrayFromHandle<MPSNNGradientFilterNode>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle (&__objc_super__, selGradientFiltersWithSource_XHandle, gradientImageSource__handle__), false)!;
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (gradientImageSource);
			return ret!;
		}
		/// <param name="gradientImageSource">To be added.</param><param name="nodeHandler">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("trainingGraphWithSourceGradient:nodeHandler:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual MPSNNFilterNode[]? GetTrainingGraph (MPSNNImageNode? gradientImageSource, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDMPSGradientNodeHandler))]MPSGradientNodeHandler? nodeHandler)
		{
			var gradientImageSource__handle__ = gradientImageSource.GetHandle ();
			using var block_nodeHandler = Trampolines.SDMPSGradientNodeHandler.CreateNullableBlock (nodeHandler);
			BlockLiteral *block_ptr_nodeHandler = null;
			if (nodeHandler is not null)
				block_ptr_nodeHandler = &block_nodeHandler;
			MPSNNFilterNode[]? ret;
			if (IsDirectBinding) {
				ret = CFArray.ArrayFromHandle<MPSNNFilterNode>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (this.Handle, selTrainingGraphWithSourceGradient_NodeHandler_XHandle, gradientImageSource__handle__, (IntPtr) block_ptr_nodeHandler), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = CFArray.ArrayFromHandle<MPSNNFilterNode>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, selTrainingGraphWithSourceGradient_NodeHandler_XHandle, gradientImageSource__handle__, (IntPtr) block_ptr_nodeHandler), false)!;
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (gradientImageSource);
			return ret!;
		}
		/// <summary>To be added.</summary><value><para>(More documentation for this node is coming)</para><para tool="nullallowed">This value can be <see langword="null" />.</para></value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string? Label {
			[Export ("label")]
			get {
				string ret;
				if (IsDirectBinding) {
					ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selLabelXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selLabelXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[Export ("setLabel:")]
			set {
				var nsvalue = CFString.CreateNative (value);
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selSetLabel_XHandle, nsvalue);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selSetLabel_XHandle, nsvalue);
						GC.KeepAlive (this);
					}
				}
				CFString.ReleaseNative (nsvalue);
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual IMPSNNPadding PaddingPolicy {
			[Export ("paddingPolicy", ArgumentSemantic.Retain)]
			get {
				IMPSNNPadding? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetINativeObject<IMPSNNPadding> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selPaddingPolicyXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetINativeObject<IMPSNNPadding> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selPaddingPolicyXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setPaddingPolicy:", ArgumentSemantic.Retain)]
			set {
				var value__handle__ = value!.GetNonNullHandle (nameof (value));
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selSetPaddingPolicy_XHandle, value__handle__);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selSetPaddingPolicy_XHandle, value__handle__);
						GC.KeepAlive (this);
					}
				}
				GC.KeepAlive (value);
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual MPSNNImageNode ResultImage {
			[Export ("resultImage")]
			get {
				MPSNNImageNode? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<MPSNNImageNode> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selResultImageXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<MPSNNImageNode> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selResultImageXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		/// <summary>To be added.</summary><value><para>(More documentation for this node is coming)</para><para tool="nullallowed">This value can be <see langword="null" />.</para></value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual MPSNNStateNode? ResultState {
			[Export ("resultState")]
			get {
				MPSNNStateNode? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<MPSNNStateNode> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selResultStateXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<MPSNNStateNode> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selResultStateXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		/// <summary>To be added.</summary><value><para>(More documentation for this node is coming)</para><para tool="nullallowed">This value can be <see langword="null" />.</para></value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual MPSNNStateNode[]? ResultStates {
			[Export ("resultStates")]
			get {
				MPSNNStateNode[]? ret;
				if (IsDirectBinding) {
					ret = CFArray.ArrayFromHandle<MPSNNStateNode>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selResultStatesXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFArray.ArrayFromHandle<MPSNNStateNode>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selResultStatesXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
	} /* class MPSNNFilterNode */
}
