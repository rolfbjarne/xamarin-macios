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
using Metal;
using CoreML;
using AppKit;
using MapKit;
using Photos;
using ModelIO;
using Network;
using SceneKit;
using Contacts;
using Security;
using CloudKit;
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
using FileProvider;
using CoreAnimation;
using CoreFoundation;
using NetworkExtension;
using MetalPerformanceShadersGraph;
#nullable enable
namespace SensorKit {
	#pragma warning disable CS1573
	/// <summary>This interface represents the Objective-C protocol <c>SRSensorReaderDelegate</c>.</summary>
	/// <remarks>
	///   <para>A class that implements this interface (and subclasses <see cref="NSObject" />) will be exported to Objective-C as implementing the Objective-C protocol this interface represents.</para>
	///   <para>A class may also implement members from this interface to implement members from the protocol.</para>
	/// </remarks>
	[UnsupportedOSPlatform ("tvos")]
	[UnsupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("ios14.0")]
	[SupportedOSPlatform ("maccatalyst")]
	[Protocol (Name = "SRSensorReaderDelegate", WrapperType = typeof (SRSensorReaderDelegateWrapper))]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidFetchResult", Selector = "sensorReader:fetchingRequest:didFetchResult:", ReturnType = typeof (bool), ParameterType = new Type [] { typeof (SensorKit.SRSensorReader), typeof (SensorKit.SRFetchRequest), typeof (global::SensorKit.SRFetchResult<NSObject>) }, ParameterByRef = new bool [] { false, false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidCompleteFetch", Selector = "sensorReader:didCompleteFetch:", ParameterType = new Type [] { typeof (SensorKit.SRSensorReader), typeof (SensorKit.SRFetchRequest) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "FetchingRequestFailed", Selector = "sensorReader:fetchingRequest:failedWithError:", ParameterType = new Type [] { typeof (SensorKit.SRSensorReader), typeof (SensorKit.SRFetchRequest), typeof (NSError) }, ParameterByRef = new bool [] { false, false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidChangeAuthorizationStatus", Selector = "sensorReader:didChangeAuthorizationStatus:", ParameterType = new Type [] { typeof (SensorKit.SRSensorReader), typeof (SensorKit.SRAuthorizationStatus) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "WillStartRecording", Selector = "sensorReaderWillStartRecording:", ParameterType = new Type [] { typeof (SensorKit.SRSensorReader) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "StartRecordingFailed", Selector = "sensorReader:startRecordingFailedWithError:", ParameterType = new Type [] { typeof (SensorKit.SRSensorReader), typeof (NSError) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidStopRecording", Selector = "sensorReaderDidStopRecording:", ParameterType = new Type [] { typeof (SensorKit.SRSensorReader) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "StopRecordingFailed", Selector = "sensorReader:stopRecordingFailedWithError:", ParameterType = new Type [] { typeof (SensorKit.SRSensorReader), typeof (NSError) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidFetchDevices", Selector = "sensorReader:didFetchDevices:", ParameterType = new Type [] { typeof (SensorKit.SRSensorReader), typeof (SensorKit.SRDevice[]) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "FetchDevicesFailed", Selector = "sensorReader:fetchDevicesDidFailWithError:", ParameterType = new Type [] { typeof (SensorKit.SRSensorReader), typeof (NSError) }, ParameterByRef = new bool [] { false, false })]
	public partial interface ISRSensorReaderDelegate : INativeObject, IDisposable
	{
		[global::Foundation.OptionalMember]
		[Export ("sensorReader:fetchingRequest:didFetchResult:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool DidFetchResult (SRSensorReader reader, SRFetchRequest fetchRequest, SRFetchResult<NSObject> result)
		{
			return _DidFetchResult (this, reader, fetchRequest, result);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static bool _DidFetchResult (ISRSensorReaderDelegate This, SRSensorReader reader, SRFetchRequest fetchRequest, SRFetchResult<NSObject> result)
		{
			var reader__handle__ = reader!.GetNonNullHandle (nameof (reader));
			var fetchRequest__handle__ = fetchRequest!.GetNonNullHandle (nameof (fetchRequest));
			var result__handle__ = result!.GetNonNullHandle (nameof (result));
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("sensorReader:fetchingRequest:didFetchResult:"), reader__handle__, fetchRequest__handle__, result__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (reader);
			GC.KeepAlive (fetchRequest);
			GC.KeepAlive (result);
			return ret != 0;
		}
		[global::Foundation.OptionalMember]
		[Export ("sensorReader:didCompleteFetch:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidCompleteFetch (SRSensorReader reader, SRFetchRequest fetchRequest)
		{
			_DidCompleteFetch (this, reader, fetchRequest);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _DidCompleteFetch (ISRSensorReaderDelegate This, SRSensorReader reader, SRFetchRequest fetchRequest)
		{
			var reader__handle__ = reader!.GetNonNullHandle (nameof (reader));
			var fetchRequest__handle__ = fetchRequest!.GetNonNullHandle (nameof (fetchRequest));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("sensorReader:didCompleteFetch:"), reader__handle__, fetchRequest__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (reader);
			GC.KeepAlive (fetchRequest);
		}
		[global::Foundation.OptionalMember]
		[Export ("sensorReader:fetchingRequest:failedWithError:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void FetchingRequestFailed (SRSensorReader reader, SRFetchRequest fetchRequest, NSError error)
		{
			_FetchingRequestFailed (this, reader, fetchRequest, error);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _FetchingRequestFailed (ISRSensorReaderDelegate This, SRSensorReader reader, SRFetchRequest fetchRequest, NSError error)
		{
			var reader__handle__ = reader!.GetNonNullHandle (nameof (reader));
			var fetchRequest__handle__ = fetchRequest!.GetNonNullHandle (nameof (fetchRequest));
			var error__handle__ = error!.GetNonNullHandle (nameof (error));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("sensorReader:fetchingRequest:failedWithError:"), reader__handle__, fetchRequest__handle__, error__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (reader);
			GC.KeepAlive (fetchRequest);
			GC.KeepAlive (error);
		}
		[global::Foundation.OptionalMember]
		[Export ("sensorReader:didChangeAuthorizationStatus:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidChangeAuthorizationStatus (SRSensorReader reader, SRAuthorizationStatus authorizationStatus)
		{
			_DidChangeAuthorizationStatus (this, reader, authorizationStatus);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _DidChangeAuthorizationStatus (ISRSensorReaderDelegate This, SRSensorReader reader, SRAuthorizationStatus authorizationStatus)
		{
			var reader__handle__ = reader!.GetNonNullHandle (nameof (reader));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_IntPtr (This.Handle, Selector.GetHandle ("sensorReader:didChangeAuthorizationStatus:"), reader__handle__, (IntPtr) (long) authorizationStatus);
			GC.KeepAlive (This);
			GC.KeepAlive (reader);
		}
		[global::Foundation.OptionalMember]
		[Export ("sensorReaderWillStartRecording:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void WillStartRecording (SRSensorReader reader)
		{
			_WillStartRecording (this, reader);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _WillStartRecording (ISRSensorReaderDelegate This, SRSensorReader reader)
		{
			var reader__handle__ = reader!.GetNonNullHandle (nameof (reader));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("sensorReaderWillStartRecording:"), reader__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (reader);
		}
		[global::Foundation.OptionalMember]
		[Export ("sensorReader:startRecordingFailedWithError:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void StartRecordingFailed (SRSensorReader reader, NSError error)
		{
			_StartRecordingFailed (this, reader, error);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _StartRecordingFailed (ISRSensorReaderDelegate This, SRSensorReader reader, NSError error)
		{
			var reader__handle__ = reader!.GetNonNullHandle (nameof (reader));
			var error__handle__ = error!.GetNonNullHandle (nameof (error));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("sensorReader:startRecordingFailedWithError:"), reader__handle__, error__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (reader);
			GC.KeepAlive (error);
		}
		[global::Foundation.OptionalMember]
		[Export ("sensorReaderDidStopRecording:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidStopRecording (SRSensorReader reader)
		{
			_DidStopRecording (this, reader);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _DidStopRecording (ISRSensorReaderDelegate This, SRSensorReader reader)
		{
			var reader__handle__ = reader!.GetNonNullHandle (nameof (reader));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("sensorReaderDidStopRecording:"), reader__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (reader);
		}
		[global::Foundation.OptionalMember]
		[Export ("sensorReader:stopRecordingFailedWithError:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void StopRecordingFailed (SRSensorReader reader, NSError error)
		{
			_StopRecordingFailed (this, reader, error);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _StopRecordingFailed (ISRSensorReaderDelegate This, SRSensorReader reader, NSError error)
		{
			var reader__handle__ = reader!.GetNonNullHandle (nameof (reader));
			var error__handle__ = error!.GetNonNullHandle (nameof (error));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("sensorReader:stopRecordingFailedWithError:"), reader__handle__, error__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (reader);
			GC.KeepAlive (error);
		}
		[global::Foundation.OptionalMember]
		[Export ("sensorReader:didFetchDevices:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidFetchDevices (SRSensorReader reader, SRDevice[] devices)
		{
			_DidFetchDevices (this, reader, devices);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _DidFetchDevices (ISRSensorReaderDelegate This, SRSensorReader reader, SRDevice[] devices)
		{
			var reader__handle__ = reader!.GetNonNullHandle (nameof (reader));
			if (devices is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (devices));
			using var nsa_devices = NSArray.FromNSObjects (devices);
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("sensorReader:didFetchDevices:"), reader__handle__, nsa_devices.Handle);
			GC.KeepAlive (This);
			GC.KeepAlive (reader);
		}
		[global::Foundation.OptionalMember]
		[Export ("sensorReader:fetchDevicesDidFailWithError:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void FetchDevicesFailed (SRSensorReader reader, NSError error)
		{
			_FetchDevicesFailed (this, reader, error);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _FetchDevicesFailed (ISRSensorReaderDelegate This, SRSensorReader reader, NSError error)
		{
			var reader__handle__ = reader!.GetNonNullHandle (nameof (reader));
			var error__handle__ = error!.GetNonNullHandle (nameof (error));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("sensorReader:fetchDevicesDidFailWithError:"), reader__handle__, error__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (reader);
			GC.KeepAlive (error);
		}
		[DynamicDependencyAttribute ("DidChangeAuthorizationStatus(SensorKit.SRSensorReader,SensorKit.SRAuthorizationStatus)")]
		[DynamicDependencyAttribute ("DidCompleteFetch(SensorKit.SRSensorReader,SensorKit.SRFetchRequest)")]
		[DynamicDependencyAttribute ("DidFetchDevices(SensorKit.SRSensorReader,SensorKit.SRDevice[])")]
		[DynamicDependencyAttribute ("DidFetchResult(SensorKit.SRSensorReader,SensorKit.SRFetchRequest,SensorKit.SRFetchResult{Foundation.NSObject})")]
		[DynamicDependencyAttribute ("DidStopRecording(SensorKit.SRSensorReader)")]
		[DynamicDependencyAttribute ("FetchDevicesFailed(SensorKit.SRSensorReader,Foundation.NSError)")]
		[DynamicDependencyAttribute ("FetchingRequestFailed(SensorKit.SRSensorReader,SensorKit.SRFetchRequest,Foundation.NSError)")]
		[DynamicDependencyAttribute ("StartRecordingFailed(SensorKit.SRSensorReader,Foundation.NSError)")]
		[DynamicDependencyAttribute ("StopRecordingFailed(SensorKit.SRSensorReader,Foundation.NSError)")]
		[DynamicDependencyAttribute ("WillStartRecording(SensorKit.SRSensorReader)")]
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.Interfaces | DynamicallyAccessedMemberTypes.PublicConstructors, typeof (SRSensorReaderDelegateWrapper))]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static ISRSensorReaderDelegate ()
		{
			GC.KeepAlive (null);
		}
	}
	#pragma warning restore CS1573
	#pragma warning disable CS1573
	/// <summary>Extension methods to the <see cref="ISRSensorReaderDelegate" /> interface to support all the methods from the SRSensorReaderDelegate protocol.</summary>
	/// <remarks>
	///   <para>The extension methods for <see cref="ISRSensorReaderDelegate" /> interface allow developers to treat instances of the interface as having all the optional methods of the original SRSensorReaderDelegate protocol. Since the interface only contains the required members, these extension methods allow developers to call the optional members of the protocol.</para>
	/// </remarks>
	public unsafe static partial class SRSensorReaderDelegate_Extensions {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool DidFetchResult (this ISRSensorReaderDelegate This, SRSensorReader reader, SRFetchRequest fetchRequest, SRFetchResult<NSObject> result)
		{
			var reader__handle__ = reader!.GetNonNullHandle (nameof (reader));
			var fetchRequest__handle__ = fetchRequest!.GetNonNullHandle (nameof (fetchRequest));
			var result__handle__ = result!.GetNonNullHandle (nameof (result));
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("sensorReader:fetchingRequest:didFetchResult:"), reader__handle__, fetchRequest__handle__, result__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (reader);
			GC.KeepAlive (fetchRequest);
			GC.KeepAlive (result);
			return ret != 0;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void DidCompleteFetch (this ISRSensorReaderDelegate This, SRSensorReader reader, SRFetchRequest fetchRequest)
		{
			var reader__handle__ = reader!.GetNonNullHandle (nameof (reader));
			var fetchRequest__handle__ = fetchRequest!.GetNonNullHandle (nameof (fetchRequest));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("sensorReader:didCompleteFetch:"), reader__handle__, fetchRequest__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (reader);
			GC.KeepAlive (fetchRequest);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void FetchingRequestFailed (this ISRSensorReaderDelegate This, SRSensorReader reader, SRFetchRequest fetchRequest, NSError error)
		{
			var reader__handle__ = reader!.GetNonNullHandle (nameof (reader));
			var fetchRequest__handle__ = fetchRequest!.GetNonNullHandle (nameof (fetchRequest));
			var error__handle__ = error!.GetNonNullHandle (nameof (error));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("sensorReader:fetchingRequest:failedWithError:"), reader__handle__, fetchRequest__handle__, error__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (reader);
			GC.KeepAlive (fetchRequest);
			GC.KeepAlive (error);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void DidChangeAuthorizationStatus (this ISRSensorReaderDelegate This, SRSensorReader reader, SRAuthorizationStatus authorizationStatus)
		{
			var reader__handle__ = reader!.GetNonNullHandle (nameof (reader));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_IntPtr (This.Handle, Selector.GetHandle ("sensorReader:didChangeAuthorizationStatus:"), reader__handle__, (IntPtr) (long) authorizationStatus);
			GC.KeepAlive (This);
			GC.KeepAlive (reader);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void WillStartRecording (this ISRSensorReaderDelegate This, SRSensorReader reader)
		{
			var reader__handle__ = reader!.GetNonNullHandle (nameof (reader));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("sensorReaderWillStartRecording:"), reader__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (reader);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void StartRecordingFailed (this ISRSensorReaderDelegate This, SRSensorReader reader, NSError error)
		{
			var reader__handle__ = reader!.GetNonNullHandle (nameof (reader));
			var error__handle__ = error!.GetNonNullHandle (nameof (error));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("sensorReader:startRecordingFailedWithError:"), reader__handle__, error__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (reader);
			GC.KeepAlive (error);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void DidStopRecording (this ISRSensorReaderDelegate This, SRSensorReader reader)
		{
			var reader__handle__ = reader!.GetNonNullHandle (nameof (reader));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("sensorReaderDidStopRecording:"), reader__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (reader);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void StopRecordingFailed (this ISRSensorReaderDelegate This, SRSensorReader reader, NSError error)
		{
			var reader__handle__ = reader!.GetNonNullHandle (nameof (reader));
			var error__handle__ = error!.GetNonNullHandle (nameof (error));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("sensorReader:stopRecordingFailedWithError:"), reader__handle__, error__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (reader);
			GC.KeepAlive (error);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void DidFetchDevices (this ISRSensorReaderDelegate This, SRSensorReader reader, SRDevice[] devices)
		{
			var reader__handle__ = reader!.GetNonNullHandle (nameof (reader));
			if (devices is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (devices));
			using var nsa_devices = NSArray.FromNSObjects (devices);
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("sensorReader:didFetchDevices:"), reader__handle__, nsa_devices.Handle);
			GC.KeepAlive (This);
			GC.KeepAlive (reader);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void FetchDevicesFailed (this ISRSensorReaderDelegate This, SRSensorReader reader, NSError error)
		{
			var reader__handle__ = reader!.GetNonNullHandle (nameof (reader));
			var error__handle__ = error!.GetNonNullHandle (nameof (error));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("sensorReader:fetchDevicesDidFailWithError:"), reader__handle__, error__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (reader);
			GC.KeepAlive (error);
		}
	}
	#pragma warning restore CS1573
	internal unsafe sealed class SRSensorReaderDelegateWrapper : BaseWrapper, ISRSensorReaderDelegate {
		public SRSensorReaderDelegateWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.PublicConstructors, typeof (SRSensorReaderDelegateWrapper))]
		static SRSensorReaderDelegateWrapper ()
		{
			GC.KeepAlive (null);
		}
	}
}
namespace SensorKit {
	/// <summary>
	///   <para>This is a class that implements the interface <see cref="ISRSensorReaderDelegate" /> (for the protocol <c>SRSensorReaderDelegate</c>).</para>
	///   <para>Subclass this class to easily create a type that implements the protocol.</para>
	///   <para>An alternative is to create a subclass of <see cref="NSObject" /> and then implemented the interface <see cref="ISRSensorReaderDelegate" />.</para>
	/// </summary>
	[Protocol()]
	[Register("Microsoft_MacCatalyst__SensorKit_SRSensorReaderDelegate", false)]
	[Model]
	[UnsupportedOSPlatform ("tvos")]
	[UnsupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("ios14.0")]
	[SupportedOSPlatform ("maccatalyst")]
	public unsafe partial class SRSensorReaderDelegate : NSObject, ISRSensorReaderDelegate {
		/// <summary>Creates a new <see cref="SRSensorReaderDelegate" /> with default values.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public SRSensorReaderDelegate () : base (NSObjectFlag.Empty)
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
		protected SRSensorReaderDelegate (NSObjectFlag t) : base (t)
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
		protected internal SRSensorReaderDelegate (NativeHandle handle) : base (handle)
		{
			IsDirectBinding = false;
		}

		[Export ("sensorReader:didChangeAuthorizationStatus:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidChangeAuthorizationStatus (SRSensorReader reader, SRAuthorizationStatus authorizationStatus)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("sensorReader:didCompleteFetch:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidCompleteFetch (SRSensorReader reader, SRFetchRequest fetchRequest)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("sensorReader:didFetchDevices:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidFetchDevices (SRSensorReader reader, SRDevice[] devices)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("sensorReader:fetchingRequest:didFetchResult:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool DidFetchResult (SRSensorReader reader, SRFetchRequest fetchRequest, SRFetchResult<NSObject> result)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("sensorReaderDidStopRecording:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidStopRecording (SRSensorReader reader)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("sensorReader:fetchDevicesDidFailWithError:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void FetchDevicesFailed (SRSensorReader reader, NSError error)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("sensorReader:fetchingRequest:failedWithError:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void FetchingRequestFailed (SRSensorReader reader, SRFetchRequest fetchRequest, NSError error)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("sensorReader:startRecordingFailedWithError:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void StartRecordingFailed (SRSensorReader reader, NSError error)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("sensorReader:stopRecordingFailedWithError:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void StopRecordingFailed (SRSensorReader reader, NSError error)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("sensorReaderWillStartRecording:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void WillStartRecording (SRSensorReader reader)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
	} /* class SRSensorReaderDelegate */
}
