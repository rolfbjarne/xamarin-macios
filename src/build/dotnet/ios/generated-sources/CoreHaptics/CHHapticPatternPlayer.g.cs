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
namespace CoreHaptics {
	#pragma warning disable CS1573
	/// <summary>This interface represents the Objective-C protocol <c>CHHapticPatternPlayer</c>.</summary>
	/// <remarks>
	///   <para>A class that implements this interface (and subclasses <see cref="NSObject" />) will be exported to Objective-C as implementing the Objective-C protocol this interface represents.</para>
	///   <para>A class may also implement members from this interface to implement members from the protocol.</para>
	/// </remarks>
	[SupportedOSPlatform ("ios13.0")]
	[SupportedOSPlatform ("tvos14.0")]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("macos")]
	[Protocol (Name = "CHHapticPatternPlayer", WrapperType = typeof (CHHapticPatternPlayerWrapper))]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "Start", Selector = "startAtTime:error:", ReturnType = typeof (bool), ParameterType = new Type [] { typeof (double), typeof (NSError) }, ParameterByRef = new bool [] { false, true })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "Stop", Selector = "stopAtTime:error:", ReturnType = typeof (bool), ParameterType = new Type [] { typeof (double), typeof (NSError) }, ParameterByRef = new bool [] { false, true })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "Send", Selector = "sendParameters:atTime:error:", ReturnType = typeof (bool), ParameterType = new Type [] { typeof (CoreHaptics.CHHapticDynamicParameter[]), typeof (double), typeof (NSError) }, ParameterByRef = new bool [] { false, false, true })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "Schedule", Selector = "scheduleParameterCurve:atTime:error:", ReturnType = typeof (bool), ParameterType = new Type [] { typeof (CoreHaptics.CHHapticParameterCurve), typeof (double), typeof (NSError) }, ParameterByRef = new bool [] { false, false, true })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "Cancel", Selector = "cancelAndReturnError:", ReturnType = typeof (bool), ParameterType = new Type [] { typeof (NSError) }, ParameterByRef = new bool [] { true })]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "IsMuted", Selector = "isMuted", PropertyType = typeof (bool), GetterSelector = "isMuted", SetterSelector = "setIsMuted:", ArgumentSemantic = ArgumentSemantic.None)]
	public partial interface ICHHapticPatternPlayer : INativeObject, IDisposable
	{
		[global::Foundation.RequiredMember]
		[Export ("startAtTime:error:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual bool Start (double time, out NSError? outError)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal unsafe static bool _Start (ICHHapticPatternPlayer This, double time, out NSError? outError)
		{
			NativeHandle outErrorValue = IntPtr.Zero;
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_Double_ref_NativeHandle (This.Handle, Selector.GetHandle ("startAtTime:error:"), time, &outErrorValue);
			GC.KeepAlive (This);
			outError = Runtime.GetNSObject<NSError> (outErrorValue)!;
			return ret != 0;
		}
		[global::Foundation.RequiredMember]
		[Export ("stopAtTime:error:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual bool Stop (double time, out NSError? outError)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal unsafe static bool _Stop (ICHHapticPatternPlayer This, double time, out NSError? outError)
		{
			NativeHandle outErrorValue = IntPtr.Zero;
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_Double_ref_NativeHandle (This.Handle, Selector.GetHandle ("stopAtTime:error:"), time, &outErrorValue);
			GC.KeepAlive (This);
			outError = Runtime.GetNSObject<NSError> (outErrorValue)!;
			return ret != 0;
		}
		[global::Foundation.RequiredMember]
		[Export ("sendParameters:atTime:error:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual bool Send (CHHapticDynamicParameter[] parameters, double time, out NSError? outError)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal unsafe static bool _Send (ICHHapticPatternPlayer This, CHHapticDynamicParameter[] parameters, double time, out NSError? outError)
		{
			if (parameters is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (parameters));
			NativeHandle outErrorValue = IntPtr.Zero;
			using var nsa_parameters = NSArray.FromNSObjects (parameters);
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_Double_ref_NativeHandle (This.Handle, Selector.GetHandle ("sendParameters:atTime:error:"), nsa_parameters.Handle, time, &outErrorValue);
			GC.KeepAlive (This);
			outError = Runtime.GetNSObject<NSError> (outErrorValue)!;
			return ret != 0;
		}
		[global::Foundation.RequiredMember]
		[Export ("scheduleParameterCurve:atTime:error:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual bool Schedule (CHHapticParameterCurve parameterCurve, double time, out NSError? outError)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal unsafe static bool _Schedule (ICHHapticPatternPlayer This, CHHapticParameterCurve parameterCurve, double time, out NSError? outError)
		{
			var parameterCurve__handle__ = parameterCurve!.GetNonNullHandle (nameof (parameterCurve));
			NativeHandle outErrorValue = IntPtr.Zero;
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_Double_ref_NativeHandle (This.Handle, Selector.GetHandle ("scheduleParameterCurve:atTime:error:"), parameterCurve__handle__, time, &outErrorValue);
			GC.KeepAlive (This);
			GC.KeepAlive (parameterCurve);
			outError = Runtime.GetNSObject<NSError> (outErrorValue)!;
			return ret != 0;
		}
		[global::Foundation.RequiredMember]
		[Export ("cancelAndReturnError:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual bool Cancel (out NSError? outError)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal unsafe static bool _Cancel (ICHHapticPatternPlayer This, out NSError? outError)
		{
			NativeHandle outErrorValue = IntPtr.Zero;
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_ref_NativeHandle (This.Handle, Selector.GetHandle ("cancelAndReturnError:"), &outErrorValue);
			GC.KeepAlive (This);
			outError = Runtime.GetNSObject<NSError> (outErrorValue)!;
			return ret != 0;
		}
		[DynamicDependencyAttribute ("Cancel(Foundation.NSError@)")]
		[DynamicDependencyAttribute ("IsMuted")]
		[DynamicDependencyAttribute ("Schedule(CoreHaptics.CHHapticParameterCurve,System.Double,Foundation.NSError@)")]
		[DynamicDependencyAttribute ("Send(CoreHaptics.CHHapticDynamicParameter[],System.Double,Foundation.NSError@)")]
		[DynamicDependencyAttribute ("Start(System.Double,Foundation.NSError@)")]
		[DynamicDependencyAttribute ("Stop(System.Double,Foundation.NSError@)")]
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.Interfaces | DynamicallyAccessedMemberTypes.PublicConstructors, typeof (CHHapticPatternPlayerWrapper))]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static ICHHapticPatternPlayer ()
		{
			GC.KeepAlive (null);
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
		internal static bool _GetIsMuted (ICHHapticPatternPlayer This)
		{
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (This.Handle, Selector.GetHandle ("isMuted"));
			GC.KeepAlive (This);
			return ret != 0;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SetIsMuted (ICHHapticPatternPlayer This, bool value)
		{
			global::ObjCRuntime.Messaging.void_objc_msgSend_bool (This.Handle, Selector.GetHandle ("setIsMuted:"), value ? (byte) 1 : (byte) 0);
			GC.KeepAlive (This);
		}
	}
	#pragma warning restore CS1573
	internal unsafe sealed class CHHapticPatternPlayerWrapper : BaseWrapper, ICHHapticPatternPlayer {
		public CHHapticPatternPlayerWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.PublicConstructors, typeof (CHHapticPatternPlayerWrapper))]
		static CHHapticPatternPlayerWrapper ()
		{
			GC.KeepAlive (null);
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
		public bool IsMuted {
			[Export ("isMuted")]
			get {
				byte ret;
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("isMuted"));
				return ret != 0;
			}
			[Export ("setIsMuted:")]
			set {
				global::ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("setIsMuted:"), value ? (byte) 1 : (byte) 0);
			}
		}
	}
}
