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
	[Register("MPSGraphStencilOpDescriptor", true)]
	[SupportedOSPlatform ("tvos15.0")]
	[SupportedOSPlatform ("ios15.0")]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("macos")]
	public unsafe partial class MPSGraphStencilOpDescriptor : MPSGraphObject, INSCopying {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selBoundaryModeX = "boundaryMode";
		static readonly NativeHandle selBoundaryModeXHandle = Selector.GetHandle ("boundaryMode");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selCopyWithZone_X = "copyWithZone:";
		static readonly NativeHandle selCopyWithZone_XHandle = Selector.GetHandle ("copyWithZone:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selDescriptorWithExplicitPadding_X = "descriptorWithExplicitPadding:";
		static readonly NativeHandle selDescriptorWithExplicitPadding_XHandle = Selector.GetHandle ("descriptorWithExplicitPadding:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selDescriptorWithOffsets_ExplicitPadding_X = "descriptorWithOffsets:explicitPadding:";
		static readonly NativeHandle selDescriptorWithOffsets_ExplicitPadding_XHandle = Selector.GetHandle ("descriptorWithOffsets:explicitPadding:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selDescriptorWithPaddingStyle_X = "descriptorWithPaddingStyle:";
		static readonly NativeHandle selDescriptorWithPaddingStyle_XHandle = Selector.GetHandle ("descriptorWithPaddingStyle:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selDescriptorWithReductionMode_Offsets_Strides_DilationRates_ExplicitPadding_BoundaryMode_PaddingStyle_PaddingConstant_X = "descriptorWithReductionMode:offsets:strides:dilationRates:explicitPadding:boundaryMode:paddingStyle:paddingConstant:";
		static readonly NativeHandle selDescriptorWithReductionMode_Offsets_Strides_DilationRates_ExplicitPadding_BoundaryMode_PaddingStyle_PaddingConstant_XHandle = Selector.GetHandle ("descriptorWithReductionMode:offsets:strides:dilationRates:explicitPadding:boundaryMode:paddingStyle:paddingConstant:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selDilationRatesX = "dilationRates";
		static readonly NativeHandle selDilationRatesXHandle = Selector.GetHandle ("dilationRates");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selExplicitPaddingX = "explicitPadding";
		static readonly NativeHandle selExplicitPaddingXHandle = Selector.GetHandle ("explicitPadding");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selOffsetsX = "offsets";
		static readonly NativeHandle selOffsetsXHandle = Selector.GetHandle ("offsets");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selPaddingConstantX = "paddingConstant";
		static readonly NativeHandle selPaddingConstantXHandle = Selector.GetHandle ("paddingConstant");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selPaddingStyleX = "paddingStyle";
		static readonly NativeHandle selPaddingStyleXHandle = Selector.GetHandle ("paddingStyle");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selReductionModeX = "reductionMode";
		static readonly NativeHandle selReductionModeXHandle = Selector.GetHandle ("reductionMode");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetBoundaryMode_X = "setBoundaryMode:";
		static readonly NativeHandle selSetBoundaryMode_XHandle = Selector.GetHandle ("setBoundaryMode:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetDilationRates_X = "setDilationRates:";
		static readonly NativeHandle selSetDilationRates_XHandle = Selector.GetHandle ("setDilationRates:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetExplicitPadding_X = "setExplicitPadding:";
		static readonly NativeHandle selSetExplicitPadding_XHandle = Selector.GetHandle ("setExplicitPadding:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetOffsets_X = "setOffsets:";
		static readonly NativeHandle selSetOffsets_XHandle = Selector.GetHandle ("setOffsets:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetPaddingConstant_X = "setPaddingConstant:";
		static readonly NativeHandle selSetPaddingConstant_XHandle = Selector.GetHandle ("setPaddingConstant:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetPaddingStyle_X = "setPaddingStyle:";
		static readonly NativeHandle selSetPaddingStyle_XHandle = Selector.GetHandle ("setPaddingStyle:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetReductionMode_X = "setReductionMode:";
		static readonly NativeHandle selSetReductionMode_XHandle = Selector.GetHandle ("setReductionMode:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetStrides_X = "setStrides:";
		static readonly NativeHandle selSetStrides_XHandle = Selector.GetHandle ("setStrides:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selStridesX = "strides";
		static readonly NativeHandle selStridesXHandle = Selector.GetHandle ("strides");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly NativeHandle class_ptr = Class.GetHandle ("MPSGraphStencilOpDescriptor");
		/// <summary>The Objective-C class handle for this class.</summary>
		/// <value>The pointer to the Objective-C class.</value>
		/// <remarks>
		///     Each managed class mirrors an unmanaged Objective-C class.
		///     This value contains the pointer to the Objective-C class.
		///     It is similar to calling the managed <see cref="ObjCRuntime.Class.GetHandle(string)" /> or the native <see href="https://developer.apple.com/documentation/objectivec/1418952-objc_getclass">objc_getClass</see> method with the type name.
		/// </remarks>
		public override NativeHandle ClassHandle { get { return class_ptr; } }
		/// <summary>Creates a new <see cref="MPSGraphStencilOpDescriptor" /> with default values.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public MPSGraphStencilOpDescriptor () : base (NSObjectFlag.Empty)
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
		protected MPSGraphStencilOpDescriptor (NSObjectFlag t) : base (t)
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
		protected internal MPSGraphStencilOpDescriptor (NativeHandle handle) : base (handle)
		{
		}

		/// <param name="zone">Developers should pass <see langword="null" />.  Memory zones are no longer used.</param><summary>Performs a copy of the underlying Objective-C object.</summary><returns>The newly-allocated object.</returns><remarks><para>This method performs a "shallow copy" of <see langword="this" />. If this object contains references to external objects, the new object will contain references to the same object.</para></remarks>
		[Export ("copyWithZone:")]
		[return: ReleaseAttribute ()]
		[SupportedOSPlatform ("ios15.0")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos15.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSObject Copy (NSZone? zone)
		{
			var zone__handle__ = zone.GetHandle ();
			NSObject? ret;
			if (IsDirectBinding) {
				ret = Runtime.GetNSObject (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, selCopyWithZone_XHandle, zone__handle__), true)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = Runtime.GetNSObject (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle (&__objc_super__, selCopyWithZone_XHandle, zone__handle__), true)!;
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (zone);
			return ret!;
		}
		[Export ("descriptorWithReductionMode:offsets:strides:dilationRates:explicitPadding:boundaryMode:paddingStyle:paddingConstant:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MPSGraphStencilOpDescriptor? Create (MPSGraphReductionMode reductionMode, [BindAs (typeof (int[]), OriginalType = typeof (NSNumber[]))] int[] offsets, [BindAs (typeof (int[]), OriginalType = typeof (NSNumber[]))] int[] strides, [BindAs (typeof (int[]), OriginalType = typeof (NSNumber[]))] int[] dilationRates, [BindAs (typeof (int[]), OriginalType = typeof (NSNumber[]))] int[] explicitPadding, MPSGraphPaddingMode boundaryMode, MPSGraphPaddingStyle paddingStyle, float paddingConstant)
		{
			if (offsets is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (offsets));
			if (strides is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (strides));
			if (dilationRates is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (dilationRates));
			if (explicitPadding is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (explicitPadding));
			using var nsb_offsets = NSArray.FromNSObjects (o => new NSNumber (o), offsets);
			using var nsb_strides = NSArray.FromNSObjects (o => new NSNumber (o), strides);
			using var nsb_dilationRates = NSArray.FromNSObjects (o => new NSNumber (o), dilationRates);
			using var nsb_explicitPadding = NSArray.FromNSObjects (o => new NSNumber (o), explicitPadding);
			MPSGraphStencilOpDescriptor ret;
			ret =  Runtime.GetNSObject<MPSGraphStencilOpDescriptor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_UIntPtr_NativeHandle_NativeHandle_NativeHandle_NativeHandle_IntPtr_UIntPtr_float (class_ptr, selDescriptorWithReductionMode_Offsets_Strides_DilationRates_ExplicitPadding_BoundaryMode_PaddingStyle_PaddingConstant_XHandle, (UIntPtr) (ulong) reductionMode, nsb_offsets.GetHandle (), nsb_strides.GetHandle (), nsb_dilationRates.GetHandle (), nsb_explicitPadding.GetHandle (), (IntPtr) (long) boundaryMode, (UIntPtr) (ulong) paddingStyle, paddingConstant), false)!;
			return ret;
		}
		[Export ("descriptorWithOffsets:explicitPadding:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MPSGraphStencilOpDescriptor? Create ([BindAs (typeof (int[]), OriginalType = typeof (NSNumber[]))] int[] offsets, [BindAs (typeof (int[]), OriginalType = typeof (NSNumber[]))] int[] explicitPadding)
		{
			if (offsets is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (offsets));
			if (explicitPadding is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (explicitPadding));
			using var nsb_offsets = NSArray.FromNSObjects (o => new NSNumber (o), offsets);
			using var nsb_explicitPadding = NSArray.FromNSObjects (o => new NSNumber (o), explicitPadding);
			MPSGraphStencilOpDescriptor ret;
			ret =  Runtime.GetNSObject<MPSGraphStencilOpDescriptor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (class_ptr, selDescriptorWithOffsets_ExplicitPadding_XHandle, nsb_offsets.GetHandle (), nsb_explicitPadding.GetHandle ()), false)!;
			return ret;
		}
		[Export ("descriptorWithExplicitPadding:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MPSGraphStencilOpDescriptor? Create ([BindAs (typeof (int[]), OriginalType = typeof (NSNumber[]))] int[] explicitPadding)
		{
			if (explicitPadding is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (explicitPadding));
			using var nsb_explicitPadding = NSArray.FromNSObjects (o => new NSNumber (o), explicitPadding);
			MPSGraphStencilOpDescriptor ret;
			ret =  Runtime.GetNSObject<MPSGraphStencilOpDescriptor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (class_ptr, selDescriptorWithExplicitPadding_XHandle, nsb_explicitPadding.GetHandle ()), false)!;
			return ret;
		}
		[Export ("descriptorWithPaddingStyle:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MPSGraphStencilOpDescriptor? Create (MPSGraphPaddingStyle paddingStyle)
		{
			MPSGraphStencilOpDescriptor ret;
			ret =  Runtime.GetNSObject<MPSGraphStencilOpDescriptor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_UIntPtr (class_ptr, selDescriptorWithPaddingStyle_XHandle, (UIntPtr) (ulong) paddingStyle), false)!;
			return ret;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual MPSGraphPaddingMode BoundaryMode {
			[Export ("boundaryMode", ArgumentSemantic.Assign)]
			get {
				MPSGraphPaddingMode ret;
				if (IsDirectBinding) {
					ret = (MPSGraphPaddingMode) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selBoundaryModeXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = (MPSGraphPaddingMode) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (&__objc_super__, selBoundaryModeXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setBoundaryMode:", ArgumentSemantic.Assign)]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetBoundaryMode_XHandle, (IntPtr) (long) value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (&__objc_super__, selSetBoundaryMode_XHandle, (IntPtr) (long) value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[BindAs (typeof (int[]), OriginalType = typeof (NSNumber[]))]
		public virtual int[] DilationRates {
			[Export ("dilationRates", ArgumentSemantic.Copy)]
			get {
				int[] ret;
				if (IsDirectBinding) {
					ret = NSArray.ArrayFromHandleFunc <int> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selDilationRatesXHandle), NSNumber.ToInt32, false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = NSArray.ArrayFromHandleFunc <int> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selDilationRatesXHandle), NSNumber.ToInt32, false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setDilationRates:", ArgumentSemantic.Copy)]
			set {
				if (value is null)
					ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (value));
				using var nsb_DilationRates = NSArray.FromNSObjects (o => new NSNumber (o), value);
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selSetDilationRates_XHandle, nsb_DilationRates.GetHandle ());
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selSetDilationRates_XHandle, nsb_DilationRates.GetHandle ());
						GC.KeepAlive (this);
					}
				}
				nsb_DilationRates?.Dispose ();
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[BindAs (typeof (int[]), OriginalType = typeof (NSNumber[]))]
		public virtual int[] ExplicitPadding {
			[Export ("explicitPadding", ArgumentSemantic.Copy)]
			get {
				int[] ret;
				if (IsDirectBinding) {
					ret = NSArray.ArrayFromHandleFunc <int> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selExplicitPaddingXHandle), NSNumber.ToInt32, false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = NSArray.ArrayFromHandleFunc <int> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selExplicitPaddingXHandle), NSNumber.ToInt32, false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setExplicitPadding:", ArgumentSemantic.Copy)]
			set {
				if (value is null)
					ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (value));
				using var nsb_ExplicitPadding = NSArray.FromNSObjects (o => new NSNumber (o), value);
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selSetExplicitPadding_XHandle, nsb_ExplicitPadding.GetHandle ());
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selSetExplicitPadding_XHandle, nsb_ExplicitPadding.GetHandle ());
						GC.KeepAlive (this);
					}
				}
				nsb_ExplicitPadding?.Dispose ();
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[BindAs (typeof (int[]), OriginalType = typeof (NSNumber[]))]
		public virtual int[] Offsets {
			[Export ("offsets", ArgumentSemantic.Copy)]
			get {
				int[] ret;
				if (IsDirectBinding) {
					ret = NSArray.ArrayFromHandleFunc <int> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selOffsetsXHandle), NSNumber.ToInt32, false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = NSArray.ArrayFromHandleFunc <int> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selOffsetsXHandle), NSNumber.ToInt32, false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setOffsets:", ArgumentSemantic.Copy)]
			set {
				if (value is null)
					ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (value));
				using var nsb_Offsets = NSArray.FromNSObjects (o => new NSNumber (o), value);
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selSetOffsets_XHandle, nsb_Offsets.GetHandle ());
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selSetOffsets_XHandle, nsb_Offsets.GetHandle ());
						GC.KeepAlive (this);
					}
				}
				nsb_Offsets?.Dispose ();
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual float PaddingConstant {
			[Export ("paddingConstant")]
			get {
				float ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.float_objc_msgSend (this.Handle, selPaddingConstantXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.float_objc_msgSendSuper (&__objc_super__, selPaddingConstantXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[Export ("setPaddingConstant:")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_float (this.Handle, selSetPaddingConstant_XHandle, value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_float (&__objc_super__, selSetPaddingConstant_XHandle, value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual MPSGraphPaddingStyle PaddingStyle {
			[Export ("paddingStyle", ArgumentSemantic.Assign)]
			get {
				MPSGraphPaddingStyle ret;
				if (IsDirectBinding) {
					ret = (MPSGraphPaddingStyle) (ulong) global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend (this.Handle, selPaddingStyleXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = (MPSGraphPaddingStyle) (ulong) global::ObjCRuntime.Messaging.UIntPtr_objc_msgSendSuper (&__objc_super__, selPaddingStyleXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setPaddingStyle:", ArgumentSemantic.Assign)]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_UIntPtr (this.Handle, selSetPaddingStyle_XHandle, (UIntPtr) (ulong) value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_UIntPtr (&__objc_super__, selSetPaddingStyle_XHandle, (UIntPtr) (ulong) value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual MPSGraphReductionMode ReductionMode {
			[Export ("reductionMode", ArgumentSemantic.Assign)]
			get {
				MPSGraphReductionMode ret;
				if (IsDirectBinding) {
					ret = (MPSGraphReductionMode) (ulong) global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend (this.Handle, selReductionModeXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = (MPSGraphReductionMode) (ulong) global::ObjCRuntime.Messaging.UIntPtr_objc_msgSendSuper (&__objc_super__, selReductionModeXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setReductionMode:", ArgumentSemantic.Assign)]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_UIntPtr (this.Handle, selSetReductionMode_XHandle, (UIntPtr) (ulong) value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_UIntPtr (&__objc_super__, selSetReductionMode_XHandle, (UIntPtr) (ulong) value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[BindAs (typeof (int[]), OriginalType = typeof (NSNumber[]))]
		public virtual int[] Strides {
			[Export ("strides", ArgumentSemantic.Copy)]
			get {
				int[] ret;
				if (IsDirectBinding) {
					ret = NSArray.ArrayFromHandleFunc <int> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selStridesXHandle), NSNumber.ToInt32, false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = NSArray.ArrayFromHandleFunc <int> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selStridesXHandle), NSNumber.ToInt32, false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setStrides:", ArgumentSemantic.Copy)]
			set {
				if (value is null)
					ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (value));
				using var nsb_Strides = NSArray.FromNSObjects (o => new NSNumber (o), value);
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selSetStrides_XHandle, nsb_Strides.GetHandle ());
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selSetStrides_XHandle, nsb_Strides.GetHandle ());
						GC.KeepAlive (this);
					}
				}
				nsb_Strides?.Dispose ();
			}
		}
	} /* class MPSGraphStencilOpDescriptor */
}
