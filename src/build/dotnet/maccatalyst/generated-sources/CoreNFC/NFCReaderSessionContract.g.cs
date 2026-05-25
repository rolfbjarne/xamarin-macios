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
namespace CoreNFC {
	#pragma warning disable CS1573
	/// <summary>Interface defining the methods for an NFC detection- and reading- session.</summary>
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[Protocol (Name = "NFCReaderSession", WrapperType = typeof (NFCReaderSessionContractWrapper))]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "BeginSession", Selector = "beginSession")]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "InvalidateSession", Selector = "invalidateSession")]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "InvalidateSession", Selector = "invalidateSessionWithErrorMessage:", ParameterType = new Type [] { typeof (string) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "Ready", Selector = "ready", PropertyType = typeof (bool), GetterSelector = "isReady", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "AlertMessage", Selector = "alertMessage", PropertyType = typeof (string), GetterSelector = "alertMessage", SetterSelector = "setAlertMessage:", ArgumentSemantic = ArgumentSemantic.None)]
	public partial interface INFCReaderSessionContract : INativeObject, IDisposable
	{
		/// <summary>Starts a session for detecting and reading NFC tags.</summary><remarks>To be added.</remarks>
		[global::Foundation.RequiredMember]
		[Export ("beginSession")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void BeginSession ()
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <summary>Starts a session for detecting and reading NFC tags.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _BeginSession (INFCReaderSessionContract This)
		{
			global::ObjCRuntime.Messaging.void_objc_msgSend (This.Handle, Selector.GetHandle ("beginSession"));
			GC.KeepAlive (This);
		}
		/// <summary>Closes an NFC session. Once invalidated, a session cannot be reused.</summary><remarks>To be added.</remarks>
		[global::Foundation.RequiredMember]
		[Export ("invalidateSession")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void InvalidateSession ()
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <summary>Closes an NFC session. Once invalidated, a session cannot be reused.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _InvalidateSession (INFCReaderSessionContract This)
		{
			global::ObjCRuntime.Messaging.void_objc_msgSend (This.Handle, Selector.GetHandle ("invalidateSession"));
			GC.KeepAlive (This);
		}
		[global::Foundation.RequiredMember]
		[Export ("invalidateSessionWithErrorMessage:")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void InvalidateSession (string errorMessage)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _InvalidateSession (INFCReaderSessionContract This, string errorMessage)
		{
			if (errorMessage is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (errorMessage));
			var nserrorMessage = CFString.CreateNative (errorMessage);
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("invalidateSessionWithErrorMessage:"), nserrorMessage);
			GC.KeepAlive (This);
			CFString.ReleaseNative (nserrorMessage);
		}
		[DynamicDependencyAttribute ("AlertMessage")]
		[DynamicDependencyAttribute ("BeginSession()")]
		[DynamicDependencyAttribute ("InvalidateSession()")]
		[DynamicDependencyAttribute ("InvalidateSession(System.String)")]
		[DynamicDependencyAttribute ("Ready")]
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.Interfaces | DynamicallyAccessedMemberTypes.PublicConstructors, typeof (NFCReaderSessionContractWrapper))]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static INFCReaderSessionContract ()
		{
			GC.KeepAlive (null);
		}
		/// <summary>Gets whether the session is ready to detect and read NFC tags.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual bool Ready {
			[Export ("isReady")]
			get {
				return _GetReady (this);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static bool _GetReady (INFCReaderSessionContract This)
		{
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (This.Handle, Selector.GetHandle ("isReady"));
			GC.KeepAlive (This);
			return ret != 0;
		}
		/// <summary>Gets or sets a user-meaningful message describing the application's use of NFC.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual string AlertMessage {
			[Export ("alertMessage")]
			get {
				return _GetAlertMessage (this);
			}
			[Export ("setAlertMessage:")]
			set {
				_SetAlertMessage (this, value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static string _GetAlertMessage (INFCReaderSessionContract This)
		{
			string ret;
			ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("alertMessage")), false)!;
			GC.KeepAlive (This);
			return ret;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SetAlertMessage (INFCReaderSessionContract This, string value)
		{
			if (value is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (value));
			var nsvalue = CFString.CreateNative (value);
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("setAlertMessage:"), nsvalue);
			GC.KeepAlive (This);
			CFString.ReleaseNative (nsvalue);
		}
	}
	#pragma warning restore CS1573
	internal unsafe sealed class NFCReaderSessionContractWrapper : BaseWrapper, INFCReaderSessionContract {
		public NFCReaderSessionContractWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.PublicConstructors, typeof (NFCReaderSessionContractWrapper))]
		static NFCReaderSessionContractWrapper ()
		{
			GC.KeepAlive (null);
		}
		/// <summary>Starts a session for detecting and reading NFC tags.</summary><remarks>To be added.</remarks>
		[Export ("beginSession")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void BeginSession ()
		{
			global::ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, Selector.GetHandle ("beginSession"));
		}
		/// <summary>Closes an NFC session. Once invalidated, a session cannot be reused.</summary><remarks>To be added.</remarks>
		[Export ("invalidateSession")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void InvalidateSession ()
		{
			global::ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, Selector.GetHandle ("invalidateSession"));
		}
		[Export ("invalidateSessionWithErrorMessage:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void InvalidateSession (string errorMessage)
		{
			if (errorMessage is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (errorMessage));
			var nserrorMessage = CFString.CreateNative (errorMessage);
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("invalidateSessionWithErrorMessage:"), nserrorMessage);
			CFString.ReleaseNative (nserrorMessage);
		}
		/// <summary>Gets whether the session is ready to detect and read NFC tags.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public bool Ready {
			[Export ("isReady")]
			get {
				byte ret;
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("isReady"));
				return ret != 0;
			}
		}
		/// <summary>Gets or sets a user-meaningful message describing the application's use of NFC.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public string AlertMessage {
			[Export ("alertMessage")]
			get {
				string ret;
				ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("alertMessage")), false)!;
				return ret;
			}
			[Export ("setAlertMessage:")]
			set {
				if (value is null)
					ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (value));
				var nsvalue = CFString.CreateNative (value);
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("setAlertMessage:"), nsvalue);
				CFString.ReleaseNative (nsvalue);
			}
		}
	}
}
