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
namespace CoreHaptics {
	#pragma warning disable CS1573
	/// <summary>This interface represents the Objective-C protocol <c>CHHapticAdvancedPatternPlayer</c>.</summary>
	/// <remarks>
	///   <para>A class that implements this interface (and subclasses <see cref="NSObject" />) will be exported to Objective-C as implementing the Objective-C protocol this interface represents.</para>
	///   <para>A class may also implement members from this interface to implement members from the protocol.</para>
	/// </remarks>
	[SupportedOSPlatform ("ios13.0")]
	[SupportedOSPlatform ("tvos14.0")]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("macos")]
	[Protocol (Name = "CHHapticAdvancedPatternPlayer", WrapperType = typeof (CHHapticAdvancedPatternPlayerWrapper))]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "Pause", Selector = "pauseAtTime:error:", ReturnType = typeof (bool), ParameterType = new Type [] { typeof (double), typeof (NSError) }, ParameterByRef = new bool [] { false, true })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "Resume", Selector = "resumeAtTime:error:", ReturnType = typeof (bool), ParameterType = new Type [] { typeof (double), typeof (NSError) }, ParameterByRef = new bool [] { false, true })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "Seek", Selector = "seekToOffset:error:", ReturnType = typeof (bool), ParameterType = new Type [] { typeof (double), typeof (NSError) }, ParameterByRef = new bool [] { false, true })]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "LoopEnabled", Selector = "loopEnabled", PropertyType = typeof (bool), GetterSelector = "loopEnabled", SetterSelector = "setLoopEnabled:", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "LoopEnd", Selector = "loopEnd", PropertyType = typeof (double), GetterSelector = "loopEnd", SetterSelector = "setLoopEnd:", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "PlaybackRate", Selector = "playbackRate", PropertyType = typeof (float), GetterSelector = "playbackRate", SetterSelector = "setPlaybackRate:", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "CompletionHandler", Selector = "completionHandler", PropertyType = typeof (global::System.Action<NSError>), GetterSelector = "completionHandler", SetterSelector = "setCompletionHandler:", ArgumentSemantic = ArgumentSemantic.Assign, ParameterBlockProxy = new Type [] { typeof (ObjCRuntime.Trampolines.NIDActionArity1V16) }, ReturnTypeDelegateProxy = typeof (ObjCRuntime.Trampolines.SDActionArity1V16))]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "IsMuted", Selector = "isMuted", PropertyType = typeof (bool), GetterSelector = "isMuted", SetterSelector = "setIsMuted:", ArgumentSemantic = ArgumentSemantic.None)]
	public partial interface ICHHapticAdvancedPatternPlayer : INativeObject, IDisposable, 
		CoreHaptics.ICHHapticPatternPlayer
	{
		[global::Foundation.RequiredMember]
		[Export ("pauseAtTime:error:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual bool Pause (double time, out NSError? outError)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal unsafe static bool _Pause (ICHHapticAdvancedPatternPlayer This, double time, out NSError? outError)
		{
			NativeHandle outErrorValue = IntPtr.Zero;
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_Double_ref_NativeHandle (This.Handle, Selector.GetHandle ("pauseAtTime:error:"), time, &outErrorValue);
			GC.KeepAlive (This);
			outError = Runtime.GetNSObject<NSError> (outErrorValue)!;
			return ret != 0;
		}
		[global::Foundation.RequiredMember]
		[Export ("resumeAtTime:error:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual bool Resume (double time, out NSError? outError)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal unsafe static bool _Resume (ICHHapticAdvancedPatternPlayer This, double time, out NSError? outError)
		{
			NativeHandle outErrorValue = IntPtr.Zero;
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_Double_ref_NativeHandle (This.Handle, Selector.GetHandle ("resumeAtTime:error:"), time, &outErrorValue);
			GC.KeepAlive (This);
			outError = Runtime.GetNSObject<NSError> (outErrorValue)!;
			return ret != 0;
		}
		[global::Foundation.RequiredMember]
		[Export ("seekToOffset:error:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual bool Seek (double offsetTime, out NSError? outError)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal unsafe static bool _Seek (ICHHapticAdvancedPatternPlayer This, double offsetTime, out NSError? outError)
		{
			NativeHandle outErrorValue = IntPtr.Zero;
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_Double_ref_NativeHandle (This.Handle, Selector.GetHandle ("seekToOffset:error:"), offsetTime, &outErrorValue);
			GC.KeepAlive (This);
			outError = Runtime.GetNSObject<NSError> (outErrorValue)!;
			return ret != 0;
		}
		[DynamicDependencyAttribute ("CompletionHandler")]
		[DynamicDependencyAttribute ("IsMuted")]
		[DynamicDependencyAttribute ("LoopEnabled")]
		[DynamicDependencyAttribute ("LoopEnd")]
		[DynamicDependencyAttribute ("Pause(System.Double,Foundation.NSError@)")]
		[DynamicDependencyAttribute ("PlaybackRate")]
		[DynamicDependencyAttribute ("Resume(System.Double,Foundation.NSError@)")]
		[DynamicDependencyAttribute ("Seek(System.Double,Foundation.NSError@)")]
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.Interfaces | DynamicallyAccessedMemberTypes.PublicConstructors, typeof (CHHapticAdvancedPatternPlayerWrapper))]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static ICHHapticAdvancedPatternPlayer ()
		{
			GC.KeepAlive (null);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual bool LoopEnabled {
			[Export ("loopEnabled")]
			get {
				return _GetLoopEnabled (this);
			}
			[Export ("setLoopEnabled:")]
			set {
				_SetLoopEnabled (this, value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static bool _GetLoopEnabled (ICHHapticAdvancedPatternPlayer This)
		{
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (This.Handle, Selector.GetHandle ("loopEnabled"));
			GC.KeepAlive (This);
			return ret != 0;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SetLoopEnabled (ICHHapticAdvancedPatternPlayer This, bool value)
		{
			global::ObjCRuntime.Messaging.void_objc_msgSend_bool (This.Handle, Selector.GetHandle ("setLoopEnabled:"), value ? (byte) 1 : (byte) 0);
			GC.KeepAlive (This);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual double LoopEnd {
			[Export ("loopEnd")]
			get {
				return _GetLoopEnd (this);
			}
			[Export ("setLoopEnd:")]
			set {
				_SetLoopEnd (this, value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static double _GetLoopEnd (ICHHapticAdvancedPatternPlayer This)
		{
			double ret;
			ret = global::ObjCRuntime.Messaging.Double_objc_msgSend (This.Handle, Selector.GetHandle ("loopEnd"));
			GC.KeepAlive (This);
			return ret;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SetLoopEnd (ICHHapticAdvancedPatternPlayer This, double value)
		{
			global::ObjCRuntime.Messaging.void_objc_msgSend_Double (This.Handle, Selector.GetHandle ("setLoopEnd:"), value);
			GC.KeepAlive (This);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual float PlaybackRate {
			[Export ("playbackRate")]
			get {
				return _GetPlaybackRate (this);
			}
			[Export ("setPlaybackRate:")]
			set {
				_SetPlaybackRate (this, value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static float _GetPlaybackRate (ICHHapticAdvancedPatternPlayer This)
		{
			float ret;
			ret = global::ObjCRuntime.Messaging.float_objc_msgSend (This.Handle, Selector.GetHandle ("playbackRate"));
			GC.KeepAlive (This);
			return ret;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SetPlaybackRate (ICHHapticAdvancedPatternPlayer This, float value)
		{
			global::ObjCRuntime.Messaging.void_objc_msgSend_float (This.Handle, Selector.GetHandle ("setPlaybackRate:"), value);
			GC.KeepAlive (This);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public unsafe virtual global::System.Action<NSError> CompletionHandler {
			[return: DelegateProxy (typeof (ObjCRuntime.Trampolines.SDActionArity1V16))]
			[Export ("completionHandler", ArgumentSemantic.Assign)]
			get {
				return _GetCompletionHandler (this);
			}
			[param: BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V16))]
			[Export ("setCompletionHandler:", ArgumentSemantic.Assign)]
			set {
				_SetCompletionHandler (this, value);
			}
		}
		[return: DelegateProxy (typeof (ObjCRuntime.Trampolines.SDActionArity1V16))]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal unsafe static global::System.Action<NSError> _GetCompletionHandler (ICHHapticAdvancedPatternPlayer This)
		{
			NativeHandle ret;
			ret = global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("completionHandler"));
			GC.KeepAlive (This);
			return global::ObjCRuntime.Trampolines.NIDActionArity1V16.Create (ret)!;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal unsafe static void _SetCompletionHandler (ICHHapticAdvancedPatternPlayer This, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V16))]global::System.Action<NSError> value)
		{
			if (value is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (value));
			using var block_value = Trampolines.SDActionArity1V16.CreateBlock (value);
			BlockLiteral *block_ptr_value = &block_value;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("setCompletionHandler:"), (IntPtr) block_ptr_value);
			GC.KeepAlive (This);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual bool IsMuted {
			[Export ("isMuted")]
			get {
				return _GetIsMuted (this);
			}
			[Export ("setIsMuted:")]
			set {
				_SetIsMuted (this, value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static bool _GetIsMuted (ICHHapticAdvancedPatternPlayer This)
		{
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (This.Handle, Selector.GetHandle ("isMuted"));
			GC.KeepAlive (This);
			return ret != 0;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SetIsMuted (ICHHapticAdvancedPatternPlayer This, bool value)
		{
			global::ObjCRuntime.Messaging.void_objc_msgSend_bool (This.Handle, Selector.GetHandle ("setIsMuted:"), value ? (byte) 1 : (byte) 0);
			GC.KeepAlive (This);
		}
	}
	#pragma warning restore CS1573
	internal unsafe sealed class CHHapticAdvancedPatternPlayerWrapper : BaseWrapper, ICHHapticAdvancedPatternPlayer {
		public CHHapticAdvancedPatternPlayerWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.PublicConstructors, typeof (CHHapticAdvancedPatternPlayerWrapper))]
		static CHHapticAdvancedPatternPlayerWrapper ()
		{
			GC.KeepAlive (null);
		}
		[Export ("pauseAtTime:error:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe bool Pause (double time, out NSError? outError)
		{
			NativeHandle outErrorValue = IntPtr.Zero;
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_Double_ref_NativeHandle (this.Handle, Selector.GetHandle ("pauseAtTime:error:"), time, &outErrorValue);
			outError = Runtime.GetNSObject<NSError> (outErrorValue)!;
			return ret != 0;
		}
		[Export ("resumeAtTime:error:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe bool Resume (double time, out NSError? outError)
		{
			NativeHandle outErrorValue = IntPtr.Zero;
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_Double_ref_NativeHandle (this.Handle, Selector.GetHandle ("resumeAtTime:error:"), time, &outErrorValue);
			outError = Runtime.GetNSObject<NSError> (outErrorValue)!;
			return ret != 0;
		}
		[Export ("seekToOffset:error:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe bool Seek (double offsetTime, out NSError? outError)
		{
			NativeHandle outErrorValue = IntPtr.Zero;
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_Double_ref_NativeHandle (this.Handle, Selector.GetHandle ("seekToOffset:error:"), offsetTime, &outErrorValue);
			outError = Runtime.GetNSObject<NSError> (outErrorValue)!;
			return ret != 0;
		}
		[Export ("startAtTime:error:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe bool Start (double time, out NSError? outError)
		{
			NativeHandle outErrorValue = IntPtr.Zero;
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_Double_ref_NativeHandle (this.Handle, Selector.GetHandle ("startAtTime:error:"), time, &outErrorValue);
			outError = Runtime.GetNSObject<NSError> (outErrorValue)!;
			return ret != 0;
		}
		[Export ("stopAtTime:error:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe bool Stop (double time, out NSError? outError)
		{
			NativeHandle outErrorValue = IntPtr.Zero;
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_Double_ref_NativeHandle (this.Handle, Selector.GetHandle ("stopAtTime:error:"), time, &outErrorValue);
			outError = Runtime.GetNSObject<NSError> (outErrorValue)!;
			return ret != 0;
		}
		[Export ("sendParameters:atTime:error:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe bool Send (CHHapticDynamicParameter[] parameters, double time, out NSError? outError)
		{
			if (parameters is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (parameters));
			NativeHandle outErrorValue = IntPtr.Zero;
			using var nsa_parameters = NSArray.FromNSObjects (parameters);
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_Double_ref_NativeHandle (this.Handle, Selector.GetHandle ("sendParameters:atTime:error:"), nsa_parameters.Handle, time, &outErrorValue);
			outError = Runtime.GetNSObject<NSError> (outErrorValue)!;
			return ret != 0;
		}
		[Export ("scheduleParameterCurve:atTime:error:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe bool Schedule (CHHapticParameterCurve parameterCurve, double time, out NSError? outError)
		{
			var parameterCurve__handle__ = parameterCurve!.GetNonNullHandle (nameof (parameterCurve));
			NativeHandle outErrorValue = IntPtr.Zero;
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_Double_ref_NativeHandle (this.Handle, Selector.GetHandle ("scheduleParameterCurve:atTime:error:"), parameterCurve__handle__, time, &outErrorValue);
			GC.KeepAlive (parameterCurve);
			outError = Runtime.GetNSObject<NSError> (outErrorValue)!;
			return ret != 0;
		}
		[Export ("cancelAndReturnError:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe bool Cancel (out NSError? outError)
		{
			NativeHandle outErrorValue = IntPtr.Zero;
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_ref_NativeHandle (this.Handle, Selector.GetHandle ("cancelAndReturnError:"), &outErrorValue);
			outError = Runtime.GetNSObject<NSError> (outErrorValue)!;
			return ret != 0;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public bool LoopEnabled {
			[Export ("loopEnabled")]
			get {
				byte ret;
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("loopEnabled"));
				return ret != 0;
			}
			[Export ("setLoopEnabled:")]
			set {
				global::ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("setLoopEnabled:"), value ? (byte) 1 : (byte) 0);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public double LoopEnd {
			[Export ("loopEnd")]
			get {
				double ret;
				ret = global::ObjCRuntime.Messaging.Double_objc_msgSend (this.Handle, Selector.GetHandle ("loopEnd"));
				return ret;
			}
			[Export ("setLoopEnd:")]
			set {
				global::ObjCRuntime.Messaging.void_objc_msgSend_Double (this.Handle, Selector.GetHandle ("setLoopEnd:"), value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public float PlaybackRate {
			[Export ("playbackRate")]
			get {
				float ret;
				ret = global::ObjCRuntime.Messaging.float_objc_msgSend (this.Handle, Selector.GetHandle ("playbackRate"));
				return ret;
			}
			[Export ("setPlaybackRate:")]
			set {
				global::ObjCRuntime.Messaging.void_objc_msgSend_float (this.Handle, Selector.GetHandle ("setPlaybackRate:"), value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe global::System.Action<NSError> CompletionHandler {
			[return: DelegateProxy (typeof (ObjCRuntime.Trampolines.SDActionArity1V16))]
			[Export ("completionHandler", ArgumentSemantic.Assign)]
			get {
				NativeHandle ret;
				ret = global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("completionHandler"));
				return global::ObjCRuntime.Trampolines.NIDActionArity1V16.Create (ret)!;
			}
			[param: BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V16))]
			[Export ("setCompletionHandler:", ArgumentSemantic.Assign)]
			set {
				if (value is null)
					ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (value));
				using var block_value = Trampolines.SDActionArity1V16.CreateBlock (value);
				BlockLiteral *block_ptr_value = &block_value;
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("setCompletionHandler:"), (IntPtr) block_ptr_value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos14.0")]
		[SupportedOSPlatform ("maccatalyst")]
		public bool IsMuted {
			[Export ("isMuted")]
			[SupportedOSPlatform ("ios13.0")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos14.0")]
			[SupportedOSPlatform ("maccatalyst")]
			get {
				byte ret;
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("isMuted"));
				return ret != 0;
			}
			[Export ("setIsMuted:")]
			[SupportedOSPlatform ("ios13.0")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos14.0")]
			[SupportedOSPlatform ("maccatalyst")]
			set {
				global::ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("setIsMuted:"), value ? (byte) 1 : (byte) 0);
			}
		}
	}
}
