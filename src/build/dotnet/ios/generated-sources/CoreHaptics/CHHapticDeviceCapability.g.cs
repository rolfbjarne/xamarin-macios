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
	/// <summary>This interface represents the Objective-C protocol <c>CHHapticDeviceCapability</c>.</summary>
	/// <remarks>
	///   <para>A class that implements this interface (and subclasses <see cref="NSObject" />) will be exported to Objective-C as implementing the Objective-C protocol this interface represents.</para>
	///   <para>A class may also implement members from this interface to implement members from the protocol.</para>
	/// </remarks>
	[SupportedOSPlatform ("ios13.0")]
	[SupportedOSPlatform ("tvos14.0")]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("macos")]
	[Protocol (Name = "CHHapticDeviceCapability", WrapperType = typeof (CHHapticDeviceCapabilityWrapper))]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "GetAttributes", Selector = "attributesForEventParameter:eventType:error:", ReturnType = typeof (CoreHaptics.ICHHapticParameterAttributes), ParameterType = new Type [] { typeof (NSString), typeof (string), typeof (NSError) }, ParameterByRef = new bool [] { false, false, true })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "GetAttributes", Selector = "attributesForDynamicParameter:error:", ReturnType = typeof (CoreHaptics.ICHHapticParameterAttributes), ParameterType = new Type [] { typeof (NSString), typeof (NSError) }, ParameterByRef = new bool [] { false, true })]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "SupportsHaptics", Selector = "supportsHaptics", PropertyType = typeof (bool), GetterSelector = "supportsHaptics", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "SupportsAudio", Selector = "supportsAudio", PropertyType = typeof (bool), GetterSelector = "supportsAudio", ArgumentSemantic = ArgumentSemantic.None)]
	public partial interface ICHHapticDeviceCapability : INativeObject, IDisposable
	{
		[global::Foundation.RequiredMember]
		[Export ("attributesForEventParameter:eventType:error:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual ICHHapticParameterAttributes? GetAttributes (NSString eventParameter, string type, out NSError? outError)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal unsafe static ICHHapticParameterAttributes? _GetAttributes (ICHHapticDeviceCapability This, NSString eventParameter, string type, out NSError? outError)
		{
			var eventParameter__handle__ = eventParameter!.GetNonNullHandle (nameof (eventParameter));
			if (type is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (type));
			NativeHandle outErrorValue = IntPtr.Zero;
			var nstype = CFString.CreateNative (type);
			ICHHapticParameterAttributes? ret;
			ret =  Runtime.GetINativeObject<ICHHapticParameterAttributes> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_ref_NativeHandle (This.Handle, Selector.GetHandle ("attributesForEventParameter:eventType:error:"), eventParameter__handle__, nstype, &outErrorValue), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (eventParameter);
			CFString.ReleaseNative (nstype);
			outError = Runtime.GetNSObject<NSError> (outErrorValue)!;
			return ret!;
		}
		[global::Foundation.RequiredMember]
		[Export ("attributesForDynamicParameter:error:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual ICHHapticParameterAttributes? GetAttributes (NSString eventParameter, out NSError? outError)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal unsafe static ICHHapticParameterAttributes? _GetAttributes (ICHHapticDeviceCapability This, NSString eventParameter, out NSError? outError)
		{
			var eventParameter__handle__ = eventParameter!.GetNonNullHandle (nameof (eventParameter));
			NativeHandle outErrorValue = IntPtr.Zero;
			ICHHapticParameterAttributes? ret;
			ret =  Runtime.GetINativeObject<ICHHapticParameterAttributes> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_ref_NativeHandle (This.Handle, Selector.GetHandle ("attributesForDynamicParameter:error:"), eventParameter__handle__, &outErrorValue), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (eventParameter);
			outError = Runtime.GetNSObject<NSError> (outErrorValue)!;
			return ret!;
		}
		[DynamicDependencyAttribute ("GetAttributes(Foundation.NSString,Foundation.NSError@)")]
		[DynamicDependencyAttribute ("GetAttributes(Foundation.NSString,System.String,Foundation.NSError@)")]
		[DynamicDependencyAttribute ("SupportsAudio")]
		[DynamicDependencyAttribute ("SupportsHaptics")]
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.Interfaces | DynamicallyAccessedMemberTypes.PublicConstructors, typeof (CHHapticDeviceCapabilityWrapper))]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static ICHHapticDeviceCapability ()
		{
			GC.KeepAlive (null);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual bool SupportsHaptics {
			[Export ("supportsHaptics")]
			get {
				return _GetSupportsHaptics (this);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static bool _GetSupportsHaptics (ICHHapticDeviceCapability This)
		{
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (This.Handle, Selector.GetHandle ("supportsHaptics"));
			GC.KeepAlive (This);
			return ret != 0;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual bool SupportsAudio {
			[Export ("supportsAudio")]
			get {
				return _GetSupportsAudio (this);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static bool _GetSupportsAudio (ICHHapticDeviceCapability This)
		{
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (This.Handle, Selector.GetHandle ("supportsAudio"));
			GC.KeepAlive (This);
			return ret != 0;
		}
	}
	#pragma warning restore CS1573
	internal unsafe sealed class CHHapticDeviceCapabilityWrapper : BaseWrapper, ICHHapticDeviceCapability {
		public CHHapticDeviceCapabilityWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.PublicConstructors, typeof (CHHapticDeviceCapabilityWrapper))]
		static CHHapticDeviceCapabilityWrapper ()
		{
			GC.KeepAlive (null);
		}
		[Export ("attributesForEventParameter:eventType:error:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe ICHHapticParameterAttributes? GetAttributes (NSString eventParameter, string type, out NSError? outError)
		{
			var eventParameter__handle__ = eventParameter!.GetNonNullHandle (nameof (eventParameter));
			if (type is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (type));
			NativeHandle outErrorValue = IntPtr.Zero;
			var nstype = CFString.CreateNative (type);
			ICHHapticParameterAttributes? ret;
			ret =  Runtime.GetINativeObject<ICHHapticParameterAttributes> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_ref_NativeHandle (this.Handle, Selector.GetHandle ("attributesForEventParameter:eventType:error:"), eventParameter__handle__, nstype, &outErrorValue), false)!;
			GC.KeepAlive (eventParameter);
			CFString.ReleaseNative (nstype);
			outError = Runtime.GetNSObject<NSError> (outErrorValue)!;
			return ret!;
		}
		[Export ("attributesForDynamicParameter:error:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe ICHHapticParameterAttributes? GetAttributes (NSString eventParameter, out NSError? outError)
		{
			var eventParameter__handle__ = eventParameter!.GetNonNullHandle (nameof (eventParameter));
			NativeHandle outErrorValue = IntPtr.Zero;
			ICHHapticParameterAttributes? ret;
			ret =  Runtime.GetINativeObject<ICHHapticParameterAttributes> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_ref_NativeHandle (this.Handle, Selector.GetHandle ("attributesForDynamicParameter:error:"), eventParameter__handle__, &outErrorValue), false)!;
			GC.KeepAlive (eventParameter);
			outError = Runtime.GetNSObject<NSError> (outErrorValue)!;
			return ret!;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public bool SupportsHaptics {
			[Export ("supportsHaptics")]
			get {
				byte ret;
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("supportsHaptics"));
				return ret != 0;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public bool SupportsAudio {
			[Export ("supportsAudio")]
			get {
				byte ret;
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("supportsAudio"));
				return ret != 0;
			}
		}
	}
}
