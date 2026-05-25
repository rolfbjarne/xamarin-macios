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
namespace TVMLKit {
	#pragma warning disable CS1573
	/// <summary>This interface represents the Objective-C protocol <c>TVPlaybackEventMarshaling</c>.</summary>
	/// <remarks>
	///   <para>A class that implements this interface (and subclasses <see cref="NSObject" />) will be exported to Objective-C as implementing the Objective-C protocol this interface represents.</para>
	///   <para>A class may also implement members from this interface to implement members from the protocol.</para>
	/// </remarks>
	[ObsoletedOSPlatform ("tvos18.0", "Use SwiftUI or UIKit instead.")]
	[SupportedOSPlatform ("tvos")]
	[Protocol (Name = "TVPlaybackEventMarshaling", WrapperType = typeof (TVPlaybackEventMarshalingWrapper))]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "ProcessReturn", Selector = "processReturnJSValue:inContext:", ParameterType = new Type [] { typeof (JavaScriptCore.JSValue), typeof (JavaScriptCore.JSContext) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "Properties", Selector = "properties", PropertyType = typeof (global::Foundation.NSDictionary<NSString, NSObject>), GetterSelector = "properties", ArgumentSemantic = ArgumentSemantic.Retain)]
	public partial interface ITVPlaybackEventMarshaling : INativeObject, IDisposable
	{
		[global::Foundation.OptionalMember]
		[Export ("processReturnJSValue:inContext:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void ProcessReturn (global::JavaScriptCore.JSValue value, global::JavaScriptCore.JSContext jsContext)
		{
			_ProcessReturn (this, value, jsContext);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _ProcessReturn (ITVPlaybackEventMarshaling This, global::JavaScriptCore.JSValue value, global::JavaScriptCore.JSContext jsContext)
		{
			var value__handle__ = value!.GetNonNullHandle (nameof (value));
			var jsContext__handle__ = jsContext!.GetNonNullHandle (nameof (jsContext));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("processReturnJSValue:inContext:"), value__handle__, jsContext__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (value);
			GC.KeepAlive (jsContext);
		}
		[DynamicDependencyAttribute ("ProcessReturn(JavaScriptCore.JSValue,JavaScriptCore.JSContext)")]
		[DynamicDependencyAttribute ("Properties")]
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.Interfaces | DynamicallyAccessedMemberTypes.PublicConstructors, typeof (TVPlaybackEventMarshalingWrapper))]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static ITVPlaybackEventMarshaling ()
		{
			GC.KeepAlive (null);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual NSDictionary<NSString, NSObject>? Properties {
			[Export ("properties", ArgumentSemantic.Retain)]
			get {
				return _GetProperties (this);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static NSDictionary<NSString, NSObject> _GetProperties (ITVPlaybackEventMarshaling This)
		{
			NSDictionary<NSString, NSObject> ret;
			ret =  Runtime.GetNSObject<NSDictionary<NSString, NSObject>> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("properties")), false)!;
			GC.KeepAlive (This);
			return ret;
		}
	}
	#pragma warning restore CS1573
	#pragma warning disable CS1573
	/// <summary>Extension methods to the <see cref="ITVPlaybackEventMarshaling" /> interface to support all the methods from the TVPlaybackEventMarshaling protocol.</summary>
	/// <remarks>
	///   <para>The extension methods for <see cref="ITVPlaybackEventMarshaling" /> interface allow developers to treat instances of the interface as having all the optional methods of the original TVPlaybackEventMarshaling protocol. Since the interface only contains the required members, these extension methods allow developers to call the optional members of the protocol.</para>
	/// </remarks>
	public unsafe static partial class TVPlaybackEventMarshaling_Extensions {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void ProcessReturn (this ITVPlaybackEventMarshaling This, global::JavaScriptCore.JSValue value, global::JavaScriptCore.JSContext jsContext)
		{
			var value__handle__ = value!.GetNonNullHandle (nameof (value));
			var jsContext__handle__ = jsContext!.GetNonNullHandle (nameof (jsContext));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("processReturnJSValue:inContext:"), value__handle__, jsContext__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (value);
			GC.KeepAlive (jsContext);
		}
	}
	#pragma warning restore CS1573
	internal unsafe sealed class TVPlaybackEventMarshalingWrapper : BaseWrapper, ITVPlaybackEventMarshaling {
		public TVPlaybackEventMarshalingWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.PublicConstructors, typeof (TVPlaybackEventMarshalingWrapper))]
		static TVPlaybackEventMarshalingWrapper ()
		{
			GC.KeepAlive (null);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public NSDictionary<NSString, NSObject>? Properties {
			[Export ("properties", ArgumentSemantic.Retain)]
			get {
				NSDictionary<NSString, NSObject> ret;
				ret =  Runtime.GetNSObject<NSDictionary<NSString, NSObject>> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("properties")), false)!;
				return ret;
			}
		}
	}
}
