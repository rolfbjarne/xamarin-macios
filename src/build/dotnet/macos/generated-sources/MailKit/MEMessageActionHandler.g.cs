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
	/// <summary>This interface represents the Objective-C protocol <c>MEMessageActionHandler</c>.</summary>
	/// <remarks>
	///   <para>A class that implements this interface (and subclasses <see cref="NSObject" />) will be exported to Objective-C as implementing the Objective-C protocol this interface represents.</para>
	///   <para>A class may also implement members from this interface to implement members from the protocol.</para>
	/// </remarks>
	[UnsupportedOSPlatform ("tvos")]
	[UnsupportedOSPlatform ("ios")]
	[UnsupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("macos")]
	[Protocol (Name = "MEMessageActionHandler", WrapperType = typeof (MEMessageActionHandlerWrapper))]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "DecideAction", Selector = "decideActionForMessage:completionHandler:", ParameterType = new Type [] { typeof (MailKit.MEMessage), typeof (global::System.Action<global::MailKit.MEMessageActionDecision>) }, ParameterByRef = new bool [] { false, false }, ParameterBlockProxy = new Type? [] { null, typeof (ObjCRuntime.Trampolines.NIDActionArity1V79) })]
	[ProtocolMember (IsRequired = false, IsProperty = true, IsStatic = false, Name = "RequiredHeaders", Selector = "requiredHeaders", PropertyType = typeof (String[]), GetterSelector = "requiredHeaders", ArgumentSemantic = ArgumentSemantic.Copy)]
	public partial interface IMEMessageActionHandler : INativeObject, IDisposable
	{
		[global::Foundation.RequiredMember]
		[Export ("decideActionForMessage:completionHandler:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void DecideAction (MEMessage message, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V79))]global::System.Action<MEMessageActionDecision> completionHandler)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal unsafe static void _DecideAction (IMEMessageActionHandler This, MEMessage message, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V79))]global::System.Action<MEMessageActionDecision> completionHandler)
		{
			var message__handle__ = message!.GetNonNullHandle (nameof (message));
			if (completionHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completionHandler));
			using var block_completionHandler = Trampolines.SDActionArity1V79.CreateBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = &block_completionHandler;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("decideActionForMessage:completionHandler:"), message__handle__, (IntPtr) block_ptr_completionHandler);
			GC.KeepAlive (This);
			GC.KeepAlive (message);
		}
		[DynamicDependencyAttribute ("DecideAction(MailKit.MEMessage,System.Action{MailKit.MEMessageActionDecision})")]
		[DynamicDependencyAttribute ("RequiredHeaders")]
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.Interfaces | DynamicallyAccessedMemberTypes.PublicConstructors, typeof (MEMessageActionHandlerWrapper))]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static IMEMessageActionHandler ()
		{
			GC.KeepAlive (null);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.OptionalMember]
		public virtual string[] RequiredHeaders {
			[Export ("requiredHeaders", ArgumentSemantic.Copy)]
			get {
				return _GetRequiredHeaders (this);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static string[] _GetRequiredHeaders (IMEMessageActionHandler This)
		{
			string[] ret;
			ret = CFArray.StringArrayFromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("requiredHeaders")), false)!;
			GC.KeepAlive (This);
			return ret;
		}
	}
	#pragma warning restore CS1573
	#pragma warning disable CS1573
	/// <summary>Extension methods to the <see cref="IMEMessageActionHandler" /> interface to support all the methods from the MEMessageActionHandler protocol.</summary>
	/// <remarks>
	///   <para>The extension methods for <see cref="IMEMessageActionHandler" /> interface allow developers to treat instances of the interface as having all the optional methods of the original MEMessageActionHandler protocol. Since the interface only contains the required members, these extension methods allow developers to call the optional members of the protocol.</para>
	/// </remarks>
	public unsafe static partial class MEMessageActionHandler_Extensions {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static string[] GetRequiredHeaders (this IMEMessageActionHandler This)
		{
			string[] ret;
			ret = CFArray.StringArrayFromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("requiredHeaders")), false)!;
			GC.KeepAlive (This);
			return ret;
		}
	}
	#pragma warning restore CS1573
	internal unsafe sealed class MEMessageActionHandlerWrapper : BaseWrapper, IMEMessageActionHandler {
		public MEMessageActionHandlerWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.PublicConstructors, typeof (MEMessageActionHandlerWrapper))]
		static MEMessageActionHandlerWrapper ()
		{
			GC.KeepAlive (null);
		}
		[Export ("decideActionForMessage:completionHandler:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe void DecideAction (MEMessage message, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V79))]global::System.Action<MEMessageActionDecision> completionHandler)
		{
			var message__handle__ = message!.GetNonNullHandle (nameof (message));
			if (completionHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completionHandler));
			using var block_completionHandler = Trampolines.SDActionArity1V79.CreateBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = &block_completionHandler;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("decideActionForMessage:completionHandler:"), message__handle__, (IntPtr) block_ptr_completionHandler);
			GC.KeepAlive (message);
		}
	}
}
