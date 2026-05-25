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
namespace CoreAnimation {
	#pragma warning disable CS1573
	/// <summary>Provides a hierarchical timing system, with support for repetition and sequencing.</summary><related type="externalDocumentation" href="https://developer.apple.com/library/ios/documentation/GraphicsImaging/Reference/CAMediaTiming_protocol/index.html">Apple documentation for <c>CAMediaTiming</c></related>
	[Protocol (Name = "CAMediaTiming", WrapperType = typeof (CAMediaTimingWrapper))]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "BeginTime", Selector = "beginTime", PropertyType = typeof (double), GetterSelector = "beginTime", SetterSelector = "setBeginTime:", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "Duration", Selector = "duration", PropertyType = typeof (double), GetterSelector = "duration", SetterSelector = "setDuration:", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "Speed", Selector = "speed", PropertyType = typeof (float), GetterSelector = "speed", SetterSelector = "setSpeed:", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "TimeOffset", Selector = "timeOffset", PropertyType = typeof (double), GetterSelector = "timeOffset", SetterSelector = "setTimeOffset:", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "RepeatCount", Selector = "repeatCount", PropertyType = typeof (float), GetterSelector = "repeatCount", SetterSelector = "setRepeatCount:", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "RepeatDuration", Selector = "repeatDuration", PropertyType = typeof (double), GetterSelector = "repeatDuration", SetterSelector = "setRepeatDuration:", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "AutoReverses", Selector = "autoreverses", PropertyType = typeof (bool), GetterSelector = "autoreverses", SetterSelector = "setAutoreverses:", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "FillMode", Selector = "fillMode", PropertyType = typeof (string), GetterSelector = "fillMode", SetterSelector = "setFillMode:", ArgumentSemantic = ArgumentSemantic.Copy)]
	public partial interface ICAMediaTiming : INativeObject, IDisposable
	{
		[DynamicDependencyAttribute ("AutoReverses")]
		[DynamicDependencyAttribute ("BeginTime")]
		[DynamicDependencyAttribute ("Duration")]
		[DynamicDependencyAttribute ("FillMode")]
		[DynamicDependencyAttribute ("RepeatCount")]
		[DynamicDependencyAttribute ("RepeatDuration")]
		[DynamicDependencyAttribute ("Speed")]
		[DynamicDependencyAttribute ("TimeOffset")]
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.Interfaces | DynamicallyAccessedMemberTypes.PublicConstructors, typeof (CAMediaTimingWrapper))]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static ICAMediaTiming ()
		{
			GC.KeepAlive (null);
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual double BeginTime {
			[Export ("beginTime")]
			get {
				return _GetBeginTime (this);
			}
			[Export ("setBeginTime:")]
			set {
				_SetBeginTime (this, value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static double _GetBeginTime (ICAMediaTiming This)
		{
			double ret;
			ret = global::ObjCRuntime.Messaging.Double_objc_msgSend (This.Handle, Selector.GetHandle ("beginTime"));
			GC.KeepAlive (This);
			return ret;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SetBeginTime (ICAMediaTiming This, double value)
		{
			global::ObjCRuntime.Messaging.void_objc_msgSend_Double (This.Handle, Selector.GetHandle ("setBeginTime:"), value);
			GC.KeepAlive (This);
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual double Duration {
			[Export ("duration")]
			get {
				return _GetDuration (this);
			}
			[Export ("setDuration:")]
			set {
				_SetDuration (this, value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static double _GetDuration (ICAMediaTiming This)
		{
			double ret;
			ret = global::ObjCRuntime.Messaging.Double_objc_msgSend (This.Handle, Selector.GetHandle ("duration"));
			GC.KeepAlive (This);
			return ret;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SetDuration (ICAMediaTiming This, double value)
		{
			global::ObjCRuntime.Messaging.void_objc_msgSend_Double (This.Handle, Selector.GetHandle ("setDuration:"), value);
			GC.KeepAlive (This);
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual float Speed {
			[Export ("speed")]
			get {
				return _GetSpeed (this);
			}
			[Export ("setSpeed:")]
			set {
				_SetSpeed (this, value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static float _GetSpeed (ICAMediaTiming This)
		{
			float ret;
			ret = global::ObjCRuntime.Messaging.float_objc_msgSend (This.Handle, Selector.GetHandle ("speed"));
			GC.KeepAlive (This);
			return ret;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SetSpeed (ICAMediaTiming This, float value)
		{
			global::ObjCRuntime.Messaging.void_objc_msgSend_float (This.Handle, Selector.GetHandle ("setSpeed:"), value);
			GC.KeepAlive (This);
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual double TimeOffset {
			[Export ("timeOffset")]
			get {
				return _GetTimeOffset (this);
			}
			[Export ("setTimeOffset:")]
			set {
				_SetTimeOffset (this, value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static double _GetTimeOffset (ICAMediaTiming This)
		{
			double ret;
			ret = global::ObjCRuntime.Messaging.Double_objc_msgSend (This.Handle, Selector.GetHandle ("timeOffset"));
			GC.KeepAlive (This);
			return ret;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SetTimeOffset (ICAMediaTiming This, double value)
		{
			global::ObjCRuntime.Messaging.void_objc_msgSend_Double (This.Handle, Selector.GetHandle ("setTimeOffset:"), value);
			GC.KeepAlive (This);
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual float RepeatCount {
			[Export ("repeatCount")]
			get {
				return _GetRepeatCount (this);
			}
			[Export ("setRepeatCount:")]
			set {
				_SetRepeatCount (this, value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static float _GetRepeatCount (ICAMediaTiming This)
		{
			float ret;
			ret = global::ObjCRuntime.Messaging.float_objc_msgSend (This.Handle, Selector.GetHandle ("repeatCount"));
			GC.KeepAlive (This);
			return ret;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SetRepeatCount (ICAMediaTiming This, float value)
		{
			global::ObjCRuntime.Messaging.void_objc_msgSend_float (This.Handle, Selector.GetHandle ("setRepeatCount:"), value);
			GC.KeepAlive (This);
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual double RepeatDuration {
			[Export ("repeatDuration")]
			get {
				return _GetRepeatDuration (this);
			}
			[Export ("setRepeatDuration:")]
			set {
				_SetRepeatDuration (this, value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static double _GetRepeatDuration (ICAMediaTiming This)
		{
			double ret;
			ret = global::ObjCRuntime.Messaging.Double_objc_msgSend (This.Handle, Selector.GetHandle ("repeatDuration"));
			GC.KeepAlive (This);
			return ret;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SetRepeatDuration (ICAMediaTiming This, double value)
		{
			global::ObjCRuntime.Messaging.void_objc_msgSend_Double (This.Handle, Selector.GetHandle ("setRepeatDuration:"), value);
			GC.KeepAlive (This);
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual bool AutoReverses {
			[Export ("autoreverses")]
			get {
				return _GetAutoReverses (this);
			}
			[Export ("setAutoreverses:")]
			set {
				_SetAutoReverses (this, value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static bool _GetAutoReverses (ICAMediaTiming This)
		{
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (This.Handle, Selector.GetHandle ("autoreverses"));
			GC.KeepAlive (This);
			return ret != 0;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SetAutoReverses (ICAMediaTiming This, bool value)
		{
			global::ObjCRuntime.Messaging.void_objc_msgSend_bool (This.Handle, Selector.GetHandle ("setAutoreverses:"), value ? (byte) 1 : (byte) 0);
			GC.KeepAlive (This);
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual string FillMode {
			[Export ("fillMode", ArgumentSemantic.Copy)]
			get {
				return _GetFillMode (this);
			}
			[Export ("setFillMode:", ArgumentSemantic.Copy)]
			set {
				_SetFillMode (this, value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static string _GetFillMode (ICAMediaTiming This)
		{
			string ret;
			ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("fillMode")), false)!;
			GC.KeepAlive (This);
			return ret;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SetFillMode (ICAMediaTiming This, string value)
		{
			if (value is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (value));
			var nsvalue = CFString.CreateNative (value);
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("setFillMode:"), nsvalue);
			GC.KeepAlive (This);
			CFString.ReleaseNative (nsvalue);
		}
	}
	#pragma warning restore CS1573
	internal unsafe sealed class CAMediaTimingWrapper : BaseWrapper, ICAMediaTiming {
		public CAMediaTimingWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.PublicConstructors, typeof (CAMediaTimingWrapper))]
		static CAMediaTimingWrapper ()
		{
			GC.KeepAlive (null);
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public double BeginTime {
			[Export ("beginTime")]
			get {
				double ret;
				ret = global::ObjCRuntime.Messaging.Double_objc_msgSend (this.Handle, Selector.GetHandle ("beginTime"));
				return ret;
			}
			[Export ("setBeginTime:")]
			set {
				global::ObjCRuntime.Messaging.void_objc_msgSend_Double (this.Handle, Selector.GetHandle ("setBeginTime:"), value);
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public double Duration {
			[Export ("duration")]
			get {
				double ret;
				ret = global::ObjCRuntime.Messaging.Double_objc_msgSend (this.Handle, Selector.GetHandle ("duration"));
				return ret;
			}
			[Export ("setDuration:")]
			set {
				global::ObjCRuntime.Messaging.void_objc_msgSend_Double (this.Handle, Selector.GetHandle ("setDuration:"), value);
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public float Speed {
			[Export ("speed")]
			get {
				float ret;
				ret = global::ObjCRuntime.Messaging.float_objc_msgSend (this.Handle, Selector.GetHandle ("speed"));
				return ret;
			}
			[Export ("setSpeed:")]
			set {
				global::ObjCRuntime.Messaging.void_objc_msgSend_float (this.Handle, Selector.GetHandle ("setSpeed:"), value);
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public double TimeOffset {
			[Export ("timeOffset")]
			get {
				double ret;
				ret = global::ObjCRuntime.Messaging.Double_objc_msgSend (this.Handle, Selector.GetHandle ("timeOffset"));
				return ret;
			}
			[Export ("setTimeOffset:")]
			set {
				global::ObjCRuntime.Messaging.void_objc_msgSend_Double (this.Handle, Selector.GetHandle ("setTimeOffset:"), value);
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public float RepeatCount {
			[Export ("repeatCount")]
			get {
				float ret;
				ret = global::ObjCRuntime.Messaging.float_objc_msgSend (this.Handle, Selector.GetHandle ("repeatCount"));
				return ret;
			}
			[Export ("setRepeatCount:")]
			set {
				global::ObjCRuntime.Messaging.void_objc_msgSend_float (this.Handle, Selector.GetHandle ("setRepeatCount:"), value);
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public double RepeatDuration {
			[Export ("repeatDuration")]
			get {
				double ret;
				ret = global::ObjCRuntime.Messaging.Double_objc_msgSend (this.Handle, Selector.GetHandle ("repeatDuration"));
				return ret;
			}
			[Export ("setRepeatDuration:")]
			set {
				global::ObjCRuntime.Messaging.void_objc_msgSend_Double (this.Handle, Selector.GetHandle ("setRepeatDuration:"), value);
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public bool AutoReverses {
			[Export ("autoreverses")]
			get {
				byte ret;
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("autoreverses"));
				return ret != 0;
			}
			[Export ("setAutoreverses:")]
			set {
				global::ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("setAutoreverses:"), value ? (byte) 1 : (byte) 0);
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public string FillMode {
			[Export ("fillMode", ArgumentSemantic.Copy)]
			get {
				string ret;
				ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("fillMode")), false)!;
				return ret;
			}
			[Export ("setFillMode:", ArgumentSemantic.Copy)]
			set {
				if (value is null)
					ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (value));
				var nsvalue = CFString.CreateNative (value);
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("setFillMode:"), nsvalue);
				CFString.ReleaseNative (nsvalue);
			}
		}
	}
}
namespace CoreAnimation {
	/// <summary>Provides a hierarchical timing system, with support for repetition and sequencing.</summary><related type="externalDocumentation" href="https://developer.apple.com/library/ios/documentation/GraphicsImaging/Reference/CAMediaTiming_protocol/index.html">Apple documentation for <c>CAMediaTiming</c></related>
	[Protocol()]
	[Register("Microsoft_tvOS__CoreAnimation_CAMediaTiming", false)]
	[Model]
	public unsafe abstract partial class CAMediaTiming : NSObject, ICAMediaTiming {
		/// <summary>Creates a new <see cref="CAMediaTiming" /> with default values.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		protected CAMediaTiming () : base (NSObjectFlag.Empty)
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
		protected CAMediaTiming (NSObjectFlag t) : base (t)
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
		protected internal CAMediaTiming (NativeHandle handle) : base (handle)
		{
			IsDirectBinding = false;
		}

		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool AutoReverses {
			[Export ("autoreverses")]
			get {
				throw new ModelNotImplementedException ();
			}
			[Export ("setAutoreverses:")]
			set {
				throw new ModelNotImplementedException ();
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual double BeginTime {
			[Export ("beginTime")]
			get {
				throw new ModelNotImplementedException ();
			}
			[Export ("setBeginTime:")]
			set {
				throw new ModelNotImplementedException ();
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual double Duration {
			[Export ("duration")]
			get {
				throw new ModelNotImplementedException ();
			}
			[Export ("setDuration:")]
			set {
				throw new ModelNotImplementedException ();
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string FillMode {
			[Export ("fillMode", ArgumentSemantic.Copy)]
			get {
				throw new ModelNotImplementedException ();
			}
			[Export ("setFillMode:", ArgumentSemantic.Copy)]
			set {
				throw new ModelNotImplementedException ();
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual float RepeatCount {
			[Export ("repeatCount")]
			get {
				throw new ModelNotImplementedException ();
			}
			[Export ("setRepeatCount:")]
			set {
				throw new ModelNotImplementedException ();
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual double RepeatDuration {
			[Export ("repeatDuration")]
			get {
				throw new ModelNotImplementedException ();
			}
			[Export ("setRepeatDuration:")]
			set {
				throw new ModelNotImplementedException ();
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual float Speed {
			[Export ("speed")]
			get {
				throw new ModelNotImplementedException ();
			}
			[Export ("setSpeed:")]
			set {
				throw new ModelNotImplementedException ();
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual double TimeOffset {
			[Export ("timeOffset")]
			get {
				throw new ModelNotImplementedException ();
			}
			[Export ("setTimeOffset:")]
			set {
				throw new ModelNotImplementedException ();
			}
		}
	} /* class CAMediaTiming */
}
