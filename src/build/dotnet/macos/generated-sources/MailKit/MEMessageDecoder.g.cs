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
namespace MailKit {
	#pragma warning disable CS1573
	/// <summary>This interface represents the Objective-C protocol <c>MEMessageDecoder</c>.</summary>
	/// <remarks>
	///   <para>A class that implements this interface (and subclasses <see cref="NSObject" />) will be exported to Objective-C as implementing the Objective-C protocol this interface represents.</para>
	///   <para>A class may also implement members from this interface to implement members from the protocol.</para>
	/// </remarks>
	[UnsupportedOSPlatform ("tvos")]
	[UnsupportedOSPlatform ("ios")]
	[UnsupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("macos")]
	[Protocol (Name = "MEMessageDecoder", WrapperType = typeof (MEMessageDecoderWrapper))]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "DecodedMessage", Selector = "decodedMessageForMessageData:", ReturnType = typeof (MailKit.MEDecodedMessage), ParameterType = new Type [] { typeof (NSData) }, ParameterByRef = new bool [] { false })]
	public partial interface IMEMessageDecoder : INativeObject, IDisposable
	{
		[global::Foundation.RequiredMember]
		[Export ("decodedMessageForMessageData:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual MEDecodedMessage? DecodedMessage (NSData data)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static MEDecodedMessage? _DecodedMessage (IMEMessageDecoder This, NSData data)
		{
			var data__handle__ = data!.GetNonNullHandle (nameof (data));
			MEDecodedMessage? ret;
			ret =  Runtime.GetNSObject<MEDecodedMessage> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("decodedMessageForMessageData:"), data__handle__), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (data);
			return ret!;
		}
		[DynamicDependencyAttribute ("DecodedMessage(Foundation.NSData)")]
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.Interfaces | DynamicallyAccessedMemberTypes.PublicConstructors, typeof (MEMessageDecoderWrapper))]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static IMEMessageDecoder ()
		{
			GC.KeepAlive (null);
		}
	}
	#pragma warning restore CS1573
	internal unsafe sealed class MEMessageDecoderWrapper : BaseWrapper, IMEMessageDecoder {
		public MEMessageDecoderWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.PublicConstructors, typeof (MEMessageDecoderWrapper))]
		static MEMessageDecoderWrapper ()
		{
			GC.KeepAlive (null);
		}
		[Export ("decodedMessageForMessageData:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public MEDecodedMessage? DecodedMessage (NSData data)
		{
			var data__handle__ = data!.GetNonNullHandle (nameof (data));
			MEDecodedMessage? ret;
			ret =  Runtime.GetNSObject<MEDecodedMessage> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("decodedMessageForMessageData:"), data__handle__), false)!;
			GC.KeepAlive (data);
			return ret!;
		}
	}
}
