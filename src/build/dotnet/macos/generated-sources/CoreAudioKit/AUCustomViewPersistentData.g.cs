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
namespace CoreAudioKit {
	#pragma warning disable CS1573
	/// <summary>This interface represents the Objective-C protocol <c>AUCustomViewPersistentData</c>.</summary>
	/// <remarks>
	///   <para>A class that implements this interface (and subclasses <see cref="NSObject" />) will be exported to Objective-C as implementing the Objective-C protocol this interface represents.</para>
	///   <para>A class may also implement members from this interface to implement members from the protocol.</para>
	/// </remarks>
	[UnsupportedOSPlatform ("ios")]
	[UnsupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("macos")]
	[Protocol (Name = "AUCustomViewPersistentData", WrapperType = typeof (AUCustomViewPersistentDataWrapper))]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "CustomViewPersistentData", Selector = "customViewPersistentData", PropertyType = typeof (global::Foundation.NSDictionary<NSString, NSObject>), GetterSelector = "customViewPersistentData", SetterSelector = "setCustomViewPersistentData:", ArgumentSemantic = ArgumentSemantic.Assign)]
	public partial interface IAUCustomViewPersistentData : INativeObject, IDisposable
	{
		[DynamicDependencyAttribute ("CustomViewPersistentData")]
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.Interfaces | DynamicallyAccessedMemberTypes.PublicConstructors, typeof (AUCustomViewPersistentDataWrapper))]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static IAUCustomViewPersistentData ()
		{
			GC.KeepAlive (null);
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual NSDictionary<NSString, NSObject>? CustomViewPersistentData {
			[Export ("customViewPersistentData", ArgumentSemantic.Assign)]
			get {
				return _GetCustomViewPersistentData (this);
			}
			[Export ("setCustomViewPersistentData:", ArgumentSemantic.Assign)]
			set {
				_SetCustomViewPersistentData (this, value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static NSDictionary<NSString, NSObject> _GetCustomViewPersistentData (IAUCustomViewPersistentData This)
		{
			NSDictionary<NSString, NSObject> ret;
			ret =  Runtime.GetNSObject<NSDictionary<NSString, NSObject>> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("customViewPersistentData")), false)!;
			GC.KeepAlive (This);
			return ret;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SetCustomViewPersistentData (IAUCustomViewPersistentData This, NSDictionary<NSString, NSObject>? value)
		{
			var value__handle__ = value.GetHandle ();
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("setCustomViewPersistentData:"), value__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (value);
		}
	}
	#pragma warning restore CS1573
	internal unsafe sealed class AUCustomViewPersistentDataWrapper : BaseWrapper, IAUCustomViewPersistentData {
		public AUCustomViewPersistentDataWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.PublicConstructors, typeof (AUCustomViewPersistentDataWrapper))]
		static AUCustomViewPersistentDataWrapper ()
		{
			GC.KeepAlive (null);
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public NSDictionary<NSString, NSObject>? CustomViewPersistentData {
			[Export ("customViewPersistentData", ArgumentSemantic.Assign)]
			get {
				NSDictionary<NSString, NSObject> ret;
				ret =  Runtime.GetNSObject<NSDictionary<NSString, NSObject>> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("customViewPersistentData")), false)!;
				return ret;
			}
			[Export ("setCustomViewPersistentData:", ArgumentSemantic.Assign)]
			set {
				var value__handle__ = value.GetHandle ();
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("setCustomViewPersistentData:"), value__handle__);
				GC.KeepAlive (value);
			}
		}
	}
}
