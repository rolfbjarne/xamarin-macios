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
namespace FileProvider {
	#pragma warning disable CS1573
	/// <summary>Provides a communication channel between host applications and file provider extensions.</summary>
	[UnsupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	[Protocol (Name = "NSFileProviderServiceSource", WrapperType = typeof (NSFileProviderServiceSourceWrapper))]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "MakeListenerEndpoint", Selector = "makeListenerEndpointAndReturnError:", ReturnType = typeof (NSXpcListenerEndpoint), ParameterType = new Type [] { typeof (NSError) }, ParameterByRef = new bool [] { true })]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "ServiceName", Selector = "serviceName", PropertyType = typeof (string), GetterSelector = "serviceName", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = false, IsProperty = true, IsStatic = false, Name = "Restricted", Selector = "restricted", PropertyType = typeof (bool), GetterSelector = "isRestricted", ArgumentSemantic = ArgumentSemantic.None)]
	public partial interface INSFileProviderServiceSource : INativeObject, IDisposable
	{
		/// <param name="error">On failure, contains the error that occurred.</param><summary>Creates and returns an endpoint for communicating with the file provider extension.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.RequiredMember]
		[Export ("makeListenerEndpointAndReturnError:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual NSXpcListenerEndpoint? MakeListenerEndpoint (out NSError error)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="error">On failure, contains the error that occurred.</param><summary>Creates and returns an endpoint for communicating with the file provider extension.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal unsafe static NSXpcListenerEndpoint? _MakeListenerEndpoint (INSFileProviderServiceSource This, out NSError error)
		{
			NativeHandle errorValue = IntPtr.Zero;
			NSXpcListenerEndpoint? ret;
			ret =  Runtime.GetNSObject<NSXpcListenerEndpoint> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_ref_NativeHandle (This.Handle, Selector.GetHandle ("makeListenerEndpointAndReturnError:"), &errorValue), false)!;
			GC.KeepAlive (This);
			error = Runtime.GetNSObject<NSError> (errorValue)!;
			return ret!;
		}
		[DynamicDependencyAttribute ("MakeListenerEndpoint(Foundation.NSError@)")]
		[DynamicDependencyAttribute ("Restricted")]
		[DynamicDependencyAttribute ("ServiceName")]
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.Interfaces | DynamicallyAccessedMemberTypes.PublicConstructors, typeof (NSFileProviderServiceSourceWrapper))]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static INSFileProviderServiceSource ()
		{
			GC.KeepAlive (null);
		}
		/// <summary>Gets the unique service name.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual string ServiceName {
			[Export ("serviceName")]
			get {
				return _GetServiceName (this);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static string _GetServiceName (INSFileProviderServiceSource This)
		{
			string ret;
			ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("serviceName")), false)!;
			GC.KeepAlive (This);
			return ret;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos13.0")]
		[SupportedOSPlatform ("ios16.0")]
		[global::Foundation.OptionalMember]
		public virtual bool Restricted {
			[Export ("isRestricted")]
			get {
				return _GetRestricted (this);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static bool _GetRestricted (INSFileProviderServiceSource This)
		{
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (This.Handle, Selector.GetHandle ("isRestricted"));
			GC.KeepAlive (This);
			return ret != 0;
		}
	}
	#pragma warning restore CS1573
	#pragma warning disable CS1573
	/// <summary>Extension methods to the <see cref="INSFileProviderServiceSource" /> interface to support all the methods from the NSFileProviderServiceSource protocol.</summary>
	/// <remarks>
	///   <para>The extension methods for <see cref="INSFileProviderServiceSource" /> interface allow developers to treat instances of the interface as having all the optional methods of the original NSFileProviderServiceSource protocol. Since the interface only contains the required members, these extension methods allow developers to call the optional members of the protocol.</para>
	/// </remarks>
	public unsafe static partial class NSFileProviderServiceSource_Extensions {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool GetRestricted (this INSFileProviderServiceSource This)
		{
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (This.Handle, Selector.GetHandle ("isRestricted"));
			GC.KeepAlive (This);
			return ret != 0;
		}
	}
	#pragma warning restore CS1573
	internal unsafe sealed class NSFileProviderServiceSourceWrapper : BaseWrapper, INSFileProviderServiceSource {
		public NSFileProviderServiceSourceWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.PublicConstructors, typeof (NSFileProviderServiceSourceWrapper))]
		static NSFileProviderServiceSourceWrapper ()
		{
			GC.KeepAlive (null);
		}
		/// <param name="error">On failure, contains the error that occurred.</param><summary>Creates and returns an endpoint for communicating with the file provider extension.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("makeListenerEndpointAndReturnError:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe NSXpcListenerEndpoint? MakeListenerEndpoint (out NSError error)
		{
			NativeHandle errorValue = IntPtr.Zero;
			NSXpcListenerEndpoint? ret;
			ret =  Runtime.GetNSObject<NSXpcListenerEndpoint> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_ref_NativeHandle (this.Handle, Selector.GetHandle ("makeListenerEndpointAndReturnError:"), &errorValue), false)!;
			error = Runtime.GetNSObject<NSError> (errorValue)!;
			return ret!;
		}
		/// <summary>Gets the unique service name.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public string ServiceName {
			[Export ("serviceName")]
			get {
				string ret;
				ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("serviceName")), false)!;
				return ret;
			}
		}
	}
}
