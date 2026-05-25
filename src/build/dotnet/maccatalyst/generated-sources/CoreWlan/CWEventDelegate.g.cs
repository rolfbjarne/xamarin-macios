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
namespace CoreWlan {
	#pragma warning disable CS1573
	/// <summary>This interface represents the Objective-C protocol <c>CWEventDelegate</c>.</summary>
	/// <remarks>
	///   <para>A class that implements this interface (and subclasses <see cref="NSObject" />) will be exported to Objective-C as implementing the Objective-C protocol this interface represents.</para>
	///   <para>A class may also implement members from this interface to implement members from the protocol.</para>
	/// </remarks>
	[Protocol (Name = "CWEventDelegate", WrapperType = typeof (CWEventDelegateWrapper))]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "ClientConnectionInterrupted", Selector = "clientConnectionInterrupted")]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "ClientConnectionInvalidated", Selector = "clientConnectionInvalidated")]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "PowerStateDidChangeForWiFi", Selector = "powerStateDidChangeForWiFiInterfaceWithName:", ParameterType = new Type [] { typeof (string) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "SsidDidChangeForWiFi", Selector = "ssidDidChangeForWiFiInterfaceWithName:", ParameterType = new Type [] { typeof (string) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "BssidDidChangeForWiFi", Selector = "bssidDidChangeForWiFiInterfaceWithName:", ParameterType = new Type [] { typeof (string) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "CountryCodeDidChangeForWiFi", Selector = "countryCodeDidChangeForWiFiInterfaceWithName:", ParameterType = new Type [] { typeof (string) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "LinkDidChangeForWiFi", Selector = "linkDidChangeForWiFiInterfaceWithName:", ParameterType = new Type [] { typeof (string) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "LinkQualityDidChangeForWiFi", Selector = "linkQualityDidChangeForWiFiInterfaceWithName:rssi:transmitRate:", ParameterType = new Type [] { typeof (string), typeof (int), typeof (double) }, ParameterByRef = new bool [] { false, false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "ModeDidChangeForWiFi", Selector = "modeDidChangeForWiFiInterfaceWithName:", ParameterType = new Type [] { typeof (string) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "ScanCacheUpdatedForWiFi", Selector = "scanCacheUpdatedForWiFiInterfaceWithName:", ParameterType = new Type [] { typeof (string) }, ParameterByRef = new bool [] { false })]
	public partial interface ICWEventDelegate : INativeObject, IDisposable
	{
		/// <summary>To be added.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("clientConnectionInterrupted")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void ClientConnectionInterrupted ()
		{
			_ClientConnectionInterrupted (this);
		}
		/// <summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _ClientConnectionInterrupted (ICWEventDelegate This)
		{
			global::ObjCRuntime.Messaging.void_objc_msgSend (This.Handle, Selector.GetHandle ("clientConnectionInterrupted"));
			GC.KeepAlive (This);
		}
		/// <summary>To be added.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("clientConnectionInvalidated")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void ClientConnectionInvalidated ()
		{
			_ClientConnectionInvalidated (this);
		}
		/// <summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _ClientConnectionInvalidated (ICWEventDelegate This)
		{
			global::ObjCRuntime.Messaging.void_objc_msgSend (This.Handle, Selector.GetHandle ("clientConnectionInvalidated"));
			GC.KeepAlive (This);
		}
		/// <param name="interfaceName">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("powerStateDidChangeForWiFiInterfaceWithName:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void PowerStateDidChangeForWiFi (string interfaceName)
		{
			_PowerStateDidChangeForWiFi (this, interfaceName);
		}
		/// <param name="interfaceName">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _PowerStateDidChangeForWiFi (ICWEventDelegate This, string interfaceName)
		{
			if (interfaceName is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (interfaceName));
			var nsinterfaceName = CFString.CreateNative (interfaceName);
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("powerStateDidChangeForWiFiInterfaceWithName:"), nsinterfaceName);
			GC.KeepAlive (This);
			CFString.ReleaseNative (nsinterfaceName);
		}
		/// <param name="interfaceName">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("ssidDidChangeForWiFiInterfaceWithName:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SsidDidChangeForWiFi (string interfaceName)
		{
			_SsidDidChangeForWiFi (this, interfaceName);
		}
		/// <param name="interfaceName">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SsidDidChangeForWiFi (ICWEventDelegate This, string interfaceName)
		{
			if (interfaceName is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (interfaceName));
			var nsinterfaceName = CFString.CreateNative (interfaceName);
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("ssidDidChangeForWiFiInterfaceWithName:"), nsinterfaceName);
			GC.KeepAlive (This);
			CFString.ReleaseNative (nsinterfaceName);
		}
		/// <param name="interfaceName">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("bssidDidChangeForWiFiInterfaceWithName:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void BssidDidChangeForWiFi (string interfaceName)
		{
			_BssidDidChangeForWiFi (this, interfaceName);
		}
		/// <param name="interfaceName">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _BssidDidChangeForWiFi (ICWEventDelegate This, string interfaceName)
		{
			if (interfaceName is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (interfaceName));
			var nsinterfaceName = CFString.CreateNative (interfaceName);
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("bssidDidChangeForWiFiInterfaceWithName:"), nsinterfaceName);
			GC.KeepAlive (This);
			CFString.ReleaseNative (nsinterfaceName);
		}
		/// <param name="interfaceName">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("countryCodeDidChangeForWiFiInterfaceWithName:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void CountryCodeDidChangeForWiFi (string interfaceName)
		{
			_CountryCodeDidChangeForWiFi (this, interfaceName);
		}
		/// <param name="interfaceName">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _CountryCodeDidChangeForWiFi (ICWEventDelegate This, string interfaceName)
		{
			if (interfaceName is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (interfaceName));
			var nsinterfaceName = CFString.CreateNative (interfaceName);
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("countryCodeDidChangeForWiFiInterfaceWithName:"), nsinterfaceName);
			GC.KeepAlive (This);
			CFString.ReleaseNative (nsinterfaceName);
		}
		/// <param name="interfaceName">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("linkDidChangeForWiFiInterfaceWithName:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void LinkDidChangeForWiFi (string interfaceName)
		{
			_LinkDidChangeForWiFi (this, interfaceName);
		}
		/// <param name="interfaceName">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _LinkDidChangeForWiFi (ICWEventDelegate This, string interfaceName)
		{
			if (interfaceName is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (interfaceName));
			var nsinterfaceName = CFString.CreateNative (interfaceName);
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("linkDidChangeForWiFiInterfaceWithName:"), nsinterfaceName);
			GC.KeepAlive (This);
			CFString.ReleaseNative (nsinterfaceName);
		}
		/// <param name="interfaceName">To be added.</param><param name="rssi">To be added.</param><param name="transmitRate">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("linkQualityDidChangeForWiFiInterfaceWithName:rssi:transmitRate:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void LinkQualityDidChangeForWiFi (string interfaceName, int rssi, double transmitRate)
		{
			_LinkQualityDidChangeForWiFi (this, interfaceName, rssi, transmitRate);
		}
		/// <param name="interfaceName">To be added.</param><param name="rssi">To be added.</param><param name="transmitRate">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _LinkQualityDidChangeForWiFi (ICWEventDelegate This, string interfaceName, int rssi, double transmitRate)
		{
			if (interfaceName is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (interfaceName));
			var nsinterfaceName = CFString.CreateNative (interfaceName);
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_int_Double (This.Handle, Selector.GetHandle ("linkQualityDidChangeForWiFiInterfaceWithName:rssi:transmitRate:"), nsinterfaceName, rssi, transmitRate);
			GC.KeepAlive (This);
			CFString.ReleaseNative (nsinterfaceName);
		}
		/// <param name="interfaceName">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("modeDidChangeForWiFiInterfaceWithName:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void ModeDidChangeForWiFi (string interfaceName)
		{
			_ModeDidChangeForWiFi (this, interfaceName);
		}
		/// <param name="interfaceName">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _ModeDidChangeForWiFi (ICWEventDelegate This, string interfaceName)
		{
			if (interfaceName is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (interfaceName));
			var nsinterfaceName = CFString.CreateNative (interfaceName);
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("modeDidChangeForWiFiInterfaceWithName:"), nsinterfaceName);
			GC.KeepAlive (This);
			CFString.ReleaseNative (nsinterfaceName);
		}
		/// <param name="interfaceName">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("scanCacheUpdatedForWiFiInterfaceWithName:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void ScanCacheUpdatedForWiFi (string interfaceName)
		{
			_ScanCacheUpdatedForWiFi (this, interfaceName);
		}
		/// <param name="interfaceName">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _ScanCacheUpdatedForWiFi (ICWEventDelegate This, string interfaceName)
		{
			if (interfaceName is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (interfaceName));
			var nsinterfaceName = CFString.CreateNative (interfaceName);
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("scanCacheUpdatedForWiFiInterfaceWithName:"), nsinterfaceName);
			GC.KeepAlive (This);
			CFString.ReleaseNative (nsinterfaceName);
		}
		[DynamicDependencyAttribute ("BssidDidChangeForWiFi(System.String)")]
		[DynamicDependencyAttribute ("ClientConnectionInterrupted()")]
		[DynamicDependencyAttribute ("ClientConnectionInvalidated()")]
		[DynamicDependencyAttribute ("CountryCodeDidChangeForWiFi(System.String)")]
		[DynamicDependencyAttribute ("LinkDidChangeForWiFi(System.String)")]
		[DynamicDependencyAttribute ("LinkQualityDidChangeForWiFi(System.String,System.Int32,System.Double)")]
		[DynamicDependencyAttribute ("ModeDidChangeForWiFi(System.String)")]
		[DynamicDependencyAttribute ("PowerStateDidChangeForWiFi(System.String)")]
		[DynamicDependencyAttribute ("ScanCacheUpdatedForWiFi(System.String)")]
		[DynamicDependencyAttribute ("SsidDidChangeForWiFi(System.String)")]
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.Interfaces | DynamicallyAccessedMemberTypes.PublicConstructors, typeof (CWEventDelegateWrapper))]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static ICWEventDelegate ()
		{
			GC.KeepAlive (null);
		}
	}
	#pragma warning restore CS1573
	#pragma warning disable CS1573
	/// <summary>Extension methods to the <see cref="ICWEventDelegate" /> interface to support all the methods from the CWEventDelegate protocol.</summary>
	/// <remarks>
	///   <para>The extension methods for <see cref="ICWEventDelegate" /> interface allow developers to treat instances of the interface as having all the optional methods of the original CWEventDelegate protocol. Since the interface only contains the required members, these extension methods allow developers to call the optional members of the protocol.</para>
	/// </remarks>
	public unsafe static partial class CWEventDelegate_Extensions {
		/// <summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void ClientConnectionInterrupted (this ICWEventDelegate This)
		{
			global::ObjCRuntime.Messaging.void_objc_msgSend (This.Handle, Selector.GetHandle ("clientConnectionInterrupted"));
			GC.KeepAlive (This);
		}
		/// <summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void ClientConnectionInvalidated (this ICWEventDelegate This)
		{
			global::ObjCRuntime.Messaging.void_objc_msgSend (This.Handle, Selector.GetHandle ("clientConnectionInvalidated"));
			GC.KeepAlive (This);
		}
		/// <param name="interfaceName">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void PowerStateDidChangeForWiFi (this ICWEventDelegate This, string interfaceName)
		{
			if (interfaceName is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (interfaceName));
			var nsinterfaceName = CFString.CreateNative (interfaceName);
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("powerStateDidChangeForWiFiInterfaceWithName:"), nsinterfaceName);
			GC.KeepAlive (This);
			CFString.ReleaseNative (nsinterfaceName);
		}
		/// <param name="interfaceName">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void SsidDidChangeForWiFi (this ICWEventDelegate This, string interfaceName)
		{
			if (interfaceName is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (interfaceName));
			var nsinterfaceName = CFString.CreateNative (interfaceName);
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("ssidDidChangeForWiFiInterfaceWithName:"), nsinterfaceName);
			GC.KeepAlive (This);
			CFString.ReleaseNative (nsinterfaceName);
		}
		/// <param name="interfaceName">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void BssidDidChangeForWiFi (this ICWEventDelegate This, string interfaceName)
		{
			if (interfaceName is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (interfaceName));
			var nsinterfaceName = CFString.CreateNative (interfaceName);
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("bssidDidChangeForWiFiInterfaceWithName:"), nsinterfaceName);
			GC.KeepAlive (This);
			CFString.ReleaseNative (nsinterfaceName);
		}
		/// <param name="interfaceName">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void CountryCodeDidChangeForWiFi (this ICWEventDelegate This, string interfaceName)
		{
			if (interfaceName is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (interfaceName));
			var nsinterfaceName = CFString.CreateNative (interfaceName);
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("countryCodeDidChangeForWiFiInterfaceWithName:"), nsinterfaceName);
			GC.KeepAlive (This);
			CFString.ReleaseNative (nsinterfaceName);
		}
		/// <param name="interfaceName">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void LinkDidChangeForWiFi (this ICWEventDelegate This, string interfaceName)
		{
			if (interfaceName is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (interfaceName));
			var nsinterfaceName = CFString.CreateNative (interfaceName);
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("linkDidChangeForWiFiInterfaceWithName:"), nsinterfaceName);
			GC.KeepAlive (This);
			CFString.ReleaseNative (nsinterfaceName);
		}
		/// <param name="interfaceName">To be added.</param><param name="rssi">To be added.</param><param name="transmitRate">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void LinkQualityDidChangeForWiFi (this ICWEventDelegate This, string interfaceName, int rssi, double transmitRate)
		{
			if (interfaceName is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (interfaceName));
			var nsinterfaceName = CFString.CreateNative (interfaceName);
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_int_Double (This.Handle, Selector.GetHandle ("linkQualityDidChangeForWiFiInterfaceWithName:rssi:transmitRate:"), nsinterfaceName, rssi, transmitRate);
			GC.KeepAlive (This);
			CFString.ReleaseNative (nsinterfaceName);
		}
		/// <param name="interfaceName">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void ModeDidChangeForWiFi (this ICWEventDelegate This, string interfaceName)
		{
			if (interfaceName is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (interfaceName));
			var nsinterfaceName = CFString.CreateNative (interfaceName);
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("modeDidChangeForWiFiInterfaceWithName:"), nsinterfaceName);
			GC.KeepAlive (This);
			CFString.ReleaseNative (nsinterfaceName);
		}
		/// <param name="interfaceName">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void ScanCacheUpdatedForWiFi (this ICWEventDelegate This, string interfaceName)
		{
			if (interfaceName is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (interfaceName));
			var nsinterfaceName = CFString.CreateNative (interfaceName);
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("scanCacheUpdatedForWiFiInterfaceWithName:"), nsinterfaceName);
			GC.KeepAlive (This);
			CFString.ReleaseNative (nsinterfaceName);
		}
	}
	#pragma warning restore CS1573
	internal unsafe sealed class CWEventDelegateWrapper : BaseWrapper, ICWEventDelegate {
		public CWEventDelegateWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.PublicConstructors, typeof (CWEventDelegateWrapper))]
		static CWEventDelegateWrapper ()
		{
			GC.KeepAlive (null);
		}
	}
}
namespace CoreWlan {
	/// <summary>
	///   <para>This is a class that implements the interface <see cref="ICWEventDelegate" /> (for the protocol <c>CWEventDelegate</c>).</para>
	///   <para>Subclass this class to easily create a type that implements the protocol.</para>
	///   <para>An alternative is to create a subclass of <see cref="NSObject" /> and then implemented the interface <see cref="ICWEventDelegate" />.</para>
	/// </summary>
	[Protocol()]
	[Register("Microsoft_MacCatalyst__CoreWlan_CWEventDelegate", false)]
	[Model]
	public unsafe partial class CWEventDelegate : NSObject, ICWEventDelegate {
		/// <summary>Creates a new <see cref="CWEventDelegate" /> with default values.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public CWEventDelegate () : base (NSObjectFlag.Empty)
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
		protected CWEventDelegate (NSObjectFlag t) : base (t)
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
		protected internal CWEventDelegate (NativeHandle handle) : base (handle)
		{
			IsDirectBinding = false;
		}

		/// <param name="interfaceName">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("bssidDidChangeForWiFiInterfaceWithName:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void BssidDidChangeForWiFi (string interfaceName)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("clientConnectionInterrupted")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void ClientConnectionInterrupted ()
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("clientConnectionInvalidated")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void ClientConnectionInvalidated ()
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="interfaceName">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("countryCodeDidChangeForWiFiInterfaceWithName:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void CountryCodeDidChangeForWiFi (string interfaceName)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="interfaceName">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("linkDidChangeForWiFiInterfaceWithName:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void LinkDidChangeForWiFi (string interfaceName)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="interfaceName">To be added.</param><param name="rssi">To be added.</param><param name="transmitRate">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("linkQualityDidChangeForWiFiInterfaceWithName:rssi:transmitRate:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void LinkQualityDidChangeForWiFi (string interfaceName, int rssi, double transmitRate)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="interfaceName">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("modeDidChangeForWiFiInterfaceWithName:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void ModeDidChangeForWiFi (string interfaceName)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="interfaceName">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("powerStateDidChangeForWiFiInterfaceWithName:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void PowerStateDidChangeForWiFi (string interfaceName)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="interfaceName">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("scanCacheUpdatedForWiFiInterfaceWithName:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void ScanCacheUpdatedForWiFi (string interfaceName)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="interfaceName">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("ssidDidChangeForWiFiInterfaceWithName:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SsidDidChangeForWiFi (string interfaceName)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
	} /* class CWEventDelegate */
}
