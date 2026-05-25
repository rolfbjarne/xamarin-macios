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
using GLKit;
using Metal;
using CoreML;
using Photos;
using ModelIO;
using Network;
using SceneKit;
using Security;
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
using CoreAnimation;
using CoreFoundation;
using NetworkExtension;
using MetalPerformanceShadersGraph;
#nullable enable
namespace CoreML {
	#pragma warning disable CS1573
	/// <summary>Interface defining a custom CoreML model.</summary>
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("tvos")]
	[Protocol (Name = "MLCustomModel", WrapperType = typeof (MLCustomModelWrapper))]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "GetPrediction", Selector = "predictionFromFeatures:options:error:", ReturnType = typeof (IMLFeatureProvider), ParameterType = new Type [] { typeof (IMLFeatureProvider), typeof (MLPredictionOptions), typeof (NSError) }, ParameterByRef = new bool [] { false, false, true })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "GetPredictions", Selector = "predictionsFromBatch:options:error:", ReturnType = typeof (IMLBatchProvider), ParameterType = new Type [] { typeof (IMLBatchProvider), typeof (MLPredictionOptions), typeof (NSError) }, ParameterByRef = new bool [] { false, false, true })]
	public partial interface IMLCustomModel : INativeObject, IDisposable
	{
		/// <param name="modelDescription">To be added.</param><param name="parameters">To be added.</param><param name="error">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static T? CreateInstance<T> (MLModelDescription modelDescription, NSDictionary<NSString, NSObject> parameters, out NSError error) where T: NSObject, IMLCustomModel
		{
			var modelDescription__handle__ = modelDescription!.GetNonNullHandle (nameof (modelDescription));
			var parameters__handle__ = parameters!.GetNonNullHandle (nameof (parameters));
			NativeHandle errorValue = IntPtr.Zero;
			T? ret;
			IntPtr __handle__;
			__handle__ = global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (Class.GetHandle (typeof (T)), Selector.GetHandle ("alloc"));
			__handle__ = global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_ref_NativeHandle (__handle__, Selector.GetHandle ("initWithModelDescription:parameterDictionary:error:"), modelDescription__handle__, parameters__handle__, &errorValue);
			ret = global::ObjCRuntime.Runtime.GetINativeObject<T> (__handle__, true);
			GC.KeepAlive (modelDescription);
			GC.KeepAlive (parameters);
			error = Runtime.GetNSObject<NSError> (errorValue)!;
			return ret;
		}
		/// <param name="inputFeatures">To be added.</param><param name="options">To be added.</param><param name="error">To be added.</param><summary>Gets the most likely prediction for <paramref name="inputFeatures" /> and <paramref name="options" />.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.RequiredMember]
		[Export ("predictionFromFeatures:options:error:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual IMLFeatureProvider? GetPrediction (IMLFeatureProvider inputFeatures, MLPredictionOptions options, out NSError error)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="inputFeatures">To be added.</param><param name="options">To be added.</param><param name="error">To be added.</param><summary>Gets the most likely prediction for <paramref name="inputFeatures" /> and <paramref name="options" />.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal unsafe static IMLFeatureProvider? _GetPrediction (IMLCustomModel This, IMLFeatureProvider inputFeatures, MLPredictionOptions options, out NSError error)
		{
			var inputFeatures__handle__ = inputFeatures!.GetNonNullHandle (nameof (inputFeatures));
			var options__handle__ = options!.GetNonNullHandle (nameof (options));
			NativeHandle errorValue = IntPtr.Zero;
			IMLFeatureProvider? ret;
			ret =  Runtime.GetINativeObject<IMLFeatureProvider> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_ref_NativeHandle (This.Handle, Selector.GetHandle ("predictionFromFeatures:options:error:"), inputFeatures__handle__, options__handle__, &errorValue), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (inputFeatures);
			GC.KeepAlive (options);
			error = Runtime.GetNSObject<NSError> (errorValue)!;
			return ret!;
		}
		/// <param name="inputBatch">To be added.</param><param name="options">To be added.</param><param name="error">To be added.</param><summary>Gets the set of predictions for <paramref name="inputBatch" />, applying <paramref name="options" /> to each input.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("predictionsFromBatch:options:error:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual IMLBatchProvider? GetPredictions (IMLBatchProvider inputBatch, MLPredictionOptions options, out NSError error)
		{
			return _GetPredictions (this, inputBatch, options, out error);
		}
		/// <param name="inputBatch">To be added.</param><param name="options">To be added.</param><param name="error">To be added.</param><summary>Gets the set of predictions for <paramref name="inputBatch" />, applying <paramref name="options" /> to each input.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal unsafe static IMLBatchProvider? _GetPredictions (IMLCustomModel This, IMLBatchProvider inputBatch, MLPredictionOptions options, out NSError error)
		{
			var inputBatch__handle__ = inputBatch!.GetNonNullHandle (nameof (inputBatch));
			var options__handle__ = options!.GetNonNullHandle (nameof (options));
			NativeHandle errorValue = IntPtr.Zero;
			IMLBatchProvider? ret;
			ret =  Runtime.GetINativeObject<IMLBatchProvider> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_ref_NativeHandle (This.Handle, Selector.GetHandle ("predictionsFromBatch:options:error:"), inputBatch__handle__, options__handle__, &errorValue), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (inputBatch);
			GC.KeepAlive (options);
			error = Runtime.GetNSObject<NSError> (errorValue)!;
			return ret!;
		}
		[DynamicDependencyAttribute ("GetPrediction(CoreML.IMLFeatureProvider,CoreML.MLPredictionOptions,Foundation.NSError@)")]
		[DynamicDependencyAttribute ("GetPredictions(CoreML.IMLBatchProvider,CoreML.MLPredictionOptions,Foundation.NSError@)")]
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.Interfaces | DynamicallyAccessedMemberTypes.PublicConstructors, typeof (MLCustomModelWrapper))]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static IMLCustomModel ()
		{
			GC.KeepAlive (null);
		}
	}
	#pragma warning restore CS1573
	#pragma warning disable CS1573
	/// <summary>Extension methods to the <see cref="IMLCustomModel" /> interface to support all the methods from the MLCustomModel protocol.</summary>
	/// <remarks>
	///   <para>The extension methods for <see cref="IMLCustomModel" /> interface allow developers to treat instances of the interface as having all the optional methods of the original MLCustomModel protocol. Since the interface only contains the required members, these extension methods allow developers to call the optional members of the protocol.</para>
	/// </remarks>
	public unsafe static partial class MLCustomModel_Extensions {
		/// <param name="inputBatch">To be added.</param><param name="options">To be added.</param><param name="error">To be added.</param><summary>Gets the set of predictions for <paramref name="inputBatch" />, applying <paramref name="options" /> to each input.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static IMLBatchProvider? GetPredictions (this IMLCustomModel This, IMLBatchProvider inputBatch, MLPredictionOptions options, out NSError error)
		{
			var inputBatch__handle__ = inputBatch!.GetNonNullHandle (nameof (inputBatch));
			var options__handle__ = options!.GetNonNullHandle (nameof (options));
			NativeHandle errorValue = IntPtr.Zero;
			IMLBatchProvider? ret;
			ret =  Runtime.GetINativeObject<IMLBatchProvider> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_ref_NativeHandle (This.Handle, Selector.GetHandle ("predictionsFromBatch:options:error:"), inputBatch__handle__, options__handle__, &errorValue), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (inputBatch);
			GC.KeepAlive (options);
			error = Runtime.GetNSObject<NSError> (errorValue)!;
			return ret!;
		}
	}
	#pragma warning restore CS1573
	internal unsafe sealed class MLCustomModelWrapper : BaseWrapper, IMLCustomModel {
		public MLCustomModelWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.PublicConstructors, typeof (MLCustomModelWrapper))]
		static MLCustomModelWrapper ()
		{
			GC.KeepAlive (null);
		}
		/// <param name="inputFeatures">To be added.</param><param name="options">To be added.</param><param name="error">To be added.</param><summary>Gets the most likely prediction for <paramref name="inputFeatures" /> and <paramref name="options" />.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("predictionFromFeatures:options:error:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe IMLFeatureProvider? GetPrediction (IMLFeatureProvider inputFeatures, MLPredictionOptions options, out NSError error)
		{
			var inputFeatures__handle__ = inputFeatures!.GetNonNullHandle (nameof (inputFeatures));
			var options__handle__ = options!.GetNonNullHandle (nameof (options));
			NativeHandle errorValue = IntPtr.Zero;
			IMLFeatureProvider? ret;
			ret =  Runtime.GetINativeObject<IMLFeatureProvider> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_ref_NativeHandle (this.Handle, Selector.GetHandle ("predictionFromFeatures:options:error:"), inputFeatures__handle__, options__handle__, &errorValue), false)!;
			GC.KeepAlive (inputFeatures);
			GC.KeepAlive (options);
			error = Runtime.GetNSObject<NSError> (errorValue)!;
			return ret!;
		}
	}
}
namespace CoreML {
	/// <summary>Interface defining a custom CoreML model.</summary>
	[Protocol()]
	[Register("Microsoft_tvOS__CoreML_MLCustomModel", false)]
	[Model]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("tvos")]
	public unsafe abstract partial class MLCustomModel : NSObject, IMLCustomModel {
		/// <summary>Creates a new <see cref="MLCustomModel" /> with default values.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		protected MLCustomModel () : base (NSObjectFlag.Empty)
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
		protected MLCustomModel (NSObjectFlag t) : base (t)
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
		protected internal MLCustomModel (NativeHandle handle) : base (handle)
		{
			IsDirectBinding = false;
		}

		/// <param name="modelDescription">To be added.</param><param name="parameters">To be added.</param><param name="error">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("initWithModelDescription:parameterDictionary:error:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe MLCustomModel (MLModelDescription modelDescription, NSDictionary<NSString, NSObject> parameters, out NSError error)
			: base (NSObjectFlag.Empty)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="inputFeatures">To be added.</param><param name="options">To be added.</param><param name="error">To be added.</param><summary>Gets the most likely prediction for <paramref name="inputFeatures" /> and <paramref name="options" />.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("predictionFromFeatures:options:error:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual IMLFeatureProvider? GetPrediction (IMLFeatureProvider inputFeatures, MLPredictionOptions options, out NSError error)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="inputBatch">To be added.</param><param name="options">To be added.</param><param name="error">To be added.</param><summary>Gets the set of predictions for <paramref name="inputBatch" />, applying <paramref name="options" /> to each input.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("predictionsFromBatch:options:error:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual IMLBatchProvider? GetPredictions (IMLBatchProvider inputBatch, MLPredictionOptions options, out NSError error)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
	} /* class MLCustomModel */
}
