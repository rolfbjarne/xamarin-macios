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
using MapKit;
using Photos;
using ModelIO;
using Network;
using SceneKit;
using Contacts;
using Security;
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
using NewsstandKit;
using FileProvider;
using CoreAnimation;
using CoreFoundation;
using NetworkExtension;
using MetalPerformanceShadersGraph;
#nullable enable
namespace AVFoundation {
	#pragma warning disable CS1573
	/// <summary>This interface represents the Objective-C protocol <c>AVAudio3DMixing</c>.</summary>
	/// <remarks>
	///   <para>A class that implements this interface (and subclasses <see cref="NSObject" />) will be exported to Objective-C as implementing the Objective-C protocol this interface represents.</para>
	///   <para>A class may also implement members from this interface to implement members from the protocol.</para>
	/// </remarks>
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("tvos")]
	[Protocol (Name = "AVAudio3DMixing", WrapperType = typeof (AVAudio3DMixingWrapper))]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "RenderingAlgorithm", Selector = "renderingAlgorithm", PropertyType = typeof (AVAudio3DMixingRenderingAlgorithm), GetterSelector = "renderingAlgorithm", SetterSelector = "setRenderingAlgorithm:", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "Rate", Selector = "rate", PropertyType = typeof (float), GetterSelector = "rate", SetterSelector = "setRate:", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "ReverbBlend", Selector = "reverbBlend", PropertyType = typeof (float), GetterSelector = "reverbBlend", SetterSelector = "setReverbBlend:", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "Obstruction", Selector = "obstruction", PropertyType = typeof (float), GetterSelector = "obstruction", SetterSelector = "setObstruction:", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "Occlusion", Selector = "occlusion", PropertyType = typeof (float), GetterSelector = "occlusion", SetterSelector = "setOcclusion:", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "Position", Selector = "position", PropertyType = typeof (System.Numerics.Vector3), GetterSelector = "position", SetterSelector = "setPosition:", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "SourceMode", Selector = "sourceMode", PropertyType = typeof (AVAudio3DMixingSourceMode), GetterSelector = "sourceMode", SetterSelector = "setSourceMode:", ArgumentSemantic = ArgumentSemantic.Assign)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "PointSourceInHeadMode", Selector = "pointSourceInHeadMode", PropertyType = typeof (AVAudio3DMixingPointSourceInHeadMode), GetterSelector = "pointSourceInHeadMode", SetterSelector = "setPointSourceInHeadMode:", ArgumentSemantic = ArgumentSemantic.Assign)]
	public partial interface IAVAudio3DMixing : INativeObject, IDisposable
	{
		[DynamicDependencyAttribute ("Obstruction")]
		[DynamicDependencyAttribute ("Occlusion")]
		[DynamicDependencyAttribute ("PointSourceInHeadMode")]
		[DynamicDependencyAttribute ("Position")]
		[DynamicDependencyAttribute ("Rate")]
		[DynamicDependencyAttribute ("RenderingAlgorithm")]
		[DynamicDependencyAttribute ("ReverbBlend")]
		[DynamicDependencyAttribute ("SourceMode")]
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.Interfaces | DynamicallyAccessedMemberTypes.PublicConstructors, typeof (AVAudio3DMixingWrapper))]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static IAVAudio3DMixing ()
		{
			GC.KeepAlive (null);
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual AVAudio3DMixingRenderingAlgorithm RenderingAlgorithm {
			[Export ("renderingAlgorithm")]
			get {
				return _GetRenderingAlgorithm (this);
			}
			[Export ("setRenderingAlgorithm:")]
			set {
				_SetRenderingAlgorithm (this, value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static AVAudio3DMixingRenderingAlgorithm _GetRenderingAlgorithm (IAVAudio3DMixing This)
		{
			AVAudio3DMixingRenderingAlgorithm ret;
			ret = (AVAudio3DMixingRenderingAlgorithm) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (This.Handle, Selector.GetHandle ("renderingAlgorithm"));
			GC.KeepAlive (This);
			return ret!;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SetRenderingAlgorithm (IAVAudio3DMixing This, AVAudio3DMixingRenderingAlgorithm value)
		{
			global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("setRenderingAlgorithm:"), (IntPtr) (long) value);
			GC.KeepAlive (This);
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual float Rate {
			[Export ("rate")]
			get {
				return _GetRate (this);
			}
			[Export ("setRate:")]
			set {
				_SetRate (this, value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static float _GetRate (IAVAudio3DMixing This)
		{
			float ret;
			ret = global::ObjCRuntime.Messaging.float_objc_msgSend (This.Handle, Selector.GetHandle ("rate"));
			GC.KeepAlive (This);
			return ret;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SetRate (IAVAudio3DMixing This, float value)
		{
			global::ObjCRuntime.Messaging.void_objc_msgSend_float (This.Handle, Selector.GetHandle ("setRate:"), value);
			GC.KeepAlive (This);
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual float ReverbBlend {
			[Export ("reverbBlend")]
			get {
				return _GetReverbBlend (this);
			}
			[Export ("setReverbBlend:")]
			set {
				_SetReverbBlend (this, value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static float _GetReverbBlend (IAVAudio3DMixing This)
		{
			float ret;
			ret = global::ObjCRuntime.Messaging.float_objc_msgSend (This.Handle, Selector.GetHandle ("reverbBlend"));
			GC.KeepAlive (This);
			return ret;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SetReverbBlend (IAVAudio3DMixing This, float value)
		{
			global::ObjCRuntime.Messaging.void_objc_msgSend_float (This.Handle, Selector.GetHandle ("setReverbBlend:"), value);
			GC.KeepAlive (This);
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual float Obstruction {
			[Export ("obstruction")]
			get {
				return _GetObstruction (this);
			}
			[Export ("setObstruction:")]
			set {
				_SetObstruction (this, value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static float _GetObstruction (IAVAudio3DMixing This)
		{
			float ret;
			ret = global::ObjCRuntime.Messaging.float_objc_msgSend (This.Handle, Selector.GetHandle ("obstruction"));
			GC.KeepAlive (This);
			return ret;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SetObstruction (IAVAudio3DMixing This, float value)
		{
			global::ObjCRuntime.Messaging.void_objc_msgSend_float (This.Handle, Selector.GetHandle ("setObstruction:"), value);
			GC.KeepAlive (This);
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual float Occlusion {
			[Export ("occlusion")]
			get {
				return _GetOcclusion (this);
			}
			[Export ("setOcclusion:")]
			set {
				_SetOcclusion (this, value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static float _GetOcclusion (IAVAudio3DMixing This)
		{
			float ret;
			ret = global::ObjCRuntime.Messaging.float_objc_msgSend (This.Handle, Selector.GetHandle ("occlusion"));
			GC.KeepAlive (This);
			return ret;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SetOcclusion (IAVAudio3DMixing This, float value)
		{
			global::ObjCRuntime.Messaging.void_objc_msgSend_float (This.Handle, Selector.GetHandle ("setOcclusion:"), value);
			GC.KeepAlive (This);
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual global::System.Numerics.Vector3 Position {
			[Export ("position")]
			get {
				return _GetPosition (this);
			}
			[Export ("setPosition:")]
			set {
				_SetPosition (this, value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static global::System.Numerics.Vector3 _GetPosition (IAVAudio3DMixing This)
		{
			global::System.Numerics.Vector3 ret;
			ret = global::ObjCRuntime.Messaging.Vector3_objc_msgSend (This.Handle, Selector.GetHandle ("position"));
			GC.KeepAlive (This);
			return ret;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SetPosition (IAVAudio3DMixing This, global::System.Numerics.Vector3 value)
		{
			global::ObjCRuntime.Messaging.void_objc_msgSend_Vector3 (This.Handle, Selector.GetHandle ("setPosition:"), value);
			GC.KeepAlive (This);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("tvos13.0")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[global::Foundation.RequiredMember]
		public virtual AVAudio3DMixingSourceMode SourceMode {
			[Export ("sourceMode", ArgumentSemantic.Assign)]
			get {
				return _GetSourceMode (this);
			}
			[Export ("setSourceMode:", ArgumentSemantic.Assign)]
			set {
				_SetSourceMode (this, value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static AVAudio3DMixingSourceMode _GetSourceMode (IAVAudio3DMixing This)
		{
			AVAudio3DMixingSourceMode ret;
			ret = (AVAudio3DMixingSourceMode) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (This.Handle, Selector.GetHandle ("sourceMode"));
			GC.KeepAlive (This);
			return ret!;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SetSourceMode (IAVAudio3DMixing This, AVAudio3DMixingSourceMode value)
		{
			global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("setSourceMode:"), (IntPtr) (long) value);
			GC.KeepAlive (This);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("tvos13.0")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[global::Foundation.RequiredMember]
		public virtual AVAudio3DMixingPointSourceInHeadMode PointSourceInHeadMode {
			[Export ("pointSourceInHeadMode", ArgumentSemantic.Assign)]
			get {
				return _GetPointSourceInHeadMode (this);
			}
			[Export ("setPointSourceInHeadMode:", ArgumentSemantic.Assign)]
			set {
				_SetPointSourceInHeadMode (this, value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static AVAudio3DMixingPointSourceInHeadMode _GetPointSourceInHeadMode (IAVAudio3DMixing This)
		{
			AVAudio3DMixingPointSourceInHeadMode ret;
			ret = (AVAudio3DMixingPointSourceInHeadMode) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (This.Handle, Selector.GetHandle ("pointSourceInHeadMode"));
			GC.KeepAlive (This);
			return ret!;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SetPointSourceInHeadMode (IAVAudio3DMixing This, AVAudio3DMixingPointSourceInHeadMode value)
		{
			global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("setPointSourceInHeadMode:"), (IntPtr) (long) value);
			GC.KeepAlive (This);
		}
	}
	#pragma warning restore CS1573
	internal unsafe sealed class AVAudio3DMixingWrapper : BaseWrapper, IAVAudio3DMixing {
		public AVAudio3DMixingWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.PublicConstructors, typeof (AVAudio3DMixingWrapper))]
		static AVAudio3DMixingWrapper ()
		{
			GC.KeepAlive (null);
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public AVAudio3DMixingRenderingAlgorithm RenderingAlgorithm {
			[Export ("renderingAlgorithm")]
			get {
				AVAudio3DMixingRenderingAlgorithm ret;
				ret = (AVAudio3DMixingRenderingAlgorithm) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("renderingAlgorithm"));
				return ret!;
			}
			[Export ("setRenderingAlgorithm:")]
			set {
				global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setRenderingAlgorithm:"), (IntPtr) (long) value);
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public float Rate {
			[Export ("rate")]
			get {
				float ret;
				ret = global::ObjCRuntime.Messaging.float_objc_msgSend (this.Handle, Selector.GetHandle ("rate"));
				return ret;
			}
			[Export ("setRate:")]
			set {
				global::ObjCRuntime.Messaging.void_objc_msgSend_float (this.Handle, Selector.GetHandle ("setRate:"), value);
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public float ReverbBlend {
			[Export ("reverbBlend")]
			get {
				float ret;
				ret = global::ObjCRuntime.Messaging.float_objc_msgSend (this.Handle, Selector.GetHandle ("reverbBlend"));
				return ret;
			}
			[Export ("setReverbBlend:")]
			set {
				global::ObjCRuntime.Messaging.void_objc_msgSend_float (this.Handle, Selector.GetHandle ("setReverbBlend:"), value);
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public float Obstruction {
			[Export ("obstruction")]
			get {
				float ret;
				ret = global::ObjCRuntime.Messaging.float_objc_msgSend (this.Handle, Selector.GetHandle ("obstruction"));
				return ret;
			}
			[Export ("setObstruction:")]
			set {
				global::ObjCRuntime.Messaging.void_objc_msgSend_float (this.Handle, Selector.GetHandle ("setObstruction:"), value);
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public float Occlusion {
			[Export ("occlusion")]
			get {
				float ret;
				ret = global::ObjCRuntime.Messaging.float_objc_msgSend (this.Handle, Selector.GetHandle ("occlusion"));
				return ret;
			}
			[Export ("setOcclusion:")]
			set {
				global::ObjCRuntime.Messaging.void_objc_msgSend_float (this.Handle, Selector.GetHandle ("setOcclusion:"), value);
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public global::System.Numerics.Vector3 Position {
			[Export ("position")]
			get {
				global::System.Numerics.Vector3 ret;
				ret = global::ObjCRuntime.Messaging.Vector3_objc_msgSend (this.Handle, Selector.GetHandle ("position"));
				return ret;
			}
			[Export ("setPosition:")]
			set {
				global::ObjCRuntime.Messaging.void_objc_msgSend_Vector3 (this.Handle, Selector.GetHandle ("setPosition:"), value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("tvos13.0")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public AVAudio3DMixingSourceMode SourceMode {
			[Export ("sourceMode", ArgumentSemantic.Assign)]
			get {
				AVAudio3DMixingSourceMode ret;
				ret = (AVAudio3DMixingSourceMode) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("sourceMode"));
				return ret!;
			}
			[Export ("setSourceMode:", ArgumentSemantic.Assign)]
			set {
				global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setSourceMode:"), (IntPtr) (long) value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("tvos13.0")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public AVAudio3DMixingPointSourceInHeadMode PointSourceInHeadMode {
			[Export ("pointSourceInHeadMode", ArgumentSemantic.Assign)]
			get {
				AVAudio3DMixingPointSourceInHeadMode ret;
				ret = (AVAudio3DMixingPointSourceInHeadMode) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("pointSourceInHeadMode"));
				return ret!;
			}
			[Export ("setPointSourceInHeadMode:", ArgumentSemantic.Assign)]
			set {
				global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setPointSourceInHeadMode:"), (IntPtr) (long) value);
			}
		}
	}
}
namespace AVFoundation {
	/// <summary>
	///   <para>This is a class that implements the interface <see cref="IAVAudio3DMixing" /> (for the protocol <c>AVAudio3DMixing</c>).</para>
	///   <para>Subclass this class to easily create a type that implements the protocol.</para>
	///   <para>An alternative is to create a subclass of <see cref="NSObject" /> and then implemented the interface <see cref="IAVAudio3DMixing" />.</para>
	/// </summary>
	[Protocol()]
	[Register("Microsoft_iOS__AVFoundation_AVAudio3DMixing", false)]
	[Model]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("tvos")]
	public unsafe abstract partial class AVAudio3DMixing : NSObject, IAVAudio3DMixing {
		/// <summary>Creates a new <see cref="AVAudio3DMixing" /> with default values.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		protected AVAudio3DMixing () : base (NSObjectFlag.Empty)
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
		protected AVAudio3DMixing (NSObjectFlag t) : base (t)
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
		protected internal AVAudio3DMixing (NativeHandle handle) : base (handle)
		{
			IsDirectBinding = false;
		}

		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual float Obstruction {
			[Export ("obstruction")]
			get {
				throw new ModelNotImplementedException ();
			}
			[Export ("setObstruction:")]
			set {
				throw new ModelNotImplementedException ();
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual float Occlusion {
			[Export ("occlusion")]
			get {
				throw new ModelNotImplementedException ();
			}
			[Export ("setOcclusion:")]
			set {
				throw new ModelNotImplementedException ();
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("tvos13.0")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public virtual AVAudio3DMixingPointSourceInHeadMode PointSourceInHeadMode {
			[Export ("pointSourceInHeadMode", ArgumentSemantic.Assign)]
			get {
				throw new ModelNotImplementedException ();
			}
			[Export ("setPointSourceInHeadMode:", ArgumentSemantic.Assign)]
			set {
				throw new ModelNotImplementedException ();
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual global::System.Numerics.Vector3 Position {
			[Export ("position")]
			get {
				throw new ModelNotImplementedException ();
			}
			[Export ("setPosition:")]
			set {
				throw new ModelNotImplementedException ();
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual float Rate {
			[Export ("rate")]
			get {
				throw new ModelNotImplementedException ();
			}
			[Export ("setRate:")]
			set {
				throw new ModelNotImplementedException ();
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual AVAudio3DMixingRenderingAlgorithm RenderingAlgorithm {
			[Export ("renderingAlgorithm")]
			get {
				throw new ModelNotImplementedException ();
			}
			[Export ("setRenderingAlgorithm:")]
			set {
				throw new ModelNotImplementedException ();
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual float ReverbBlend {
			[Export ("reverbBlend")]
			get {
				throw new ModelNotImplementedException ();
			}
			[Export ("setReverbBlend:")]
			set {
				throw new ModelNotImplementedException ();
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("tvos13.0")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public virtual AVAudio3DMixingSourceMode SourceMode {
			[Export ("sourceMode", ArgumentSemantic.Assign)]
			get {
				throw new ModelNotImplementedException ();
			}
			[Export ("setSourceMode:", ArgumentSemantic.Assign)]
			set {
				throw new ModelNotImplementedException ();
			}
		}
	} /* class AVAudio3DMixing */
}
