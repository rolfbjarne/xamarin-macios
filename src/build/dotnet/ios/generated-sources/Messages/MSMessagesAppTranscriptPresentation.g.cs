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
namespace Messages {
	#pragma warning disable CS1573
	/// <summary>This interface represents the Objective-C protocol <c>MSMessagesAppTranscriptPresentation</c>.</summary>
	/// <remarks>
	///   <para>A class that implements this interface (and subclasses <see cref="NSObject" />) will be exported to Objective-C as implementing the Objective-C protocol this interface represents.</para>
	///   <para>A class may also implement members from this interface to implement members from the protocol.</para>
	/// </remarks>
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[Protocol (Name = "MSMessagesAppTranscriptPresentation", WrapperType = typeof (MSMessagesAppTranscriptPresentationWrapper))]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "GetContentSizeThatFits", Selector = "contentSizeThatFits:", ReturnType = typeof (CGSize), ParameterType = new Type [] { typeof (CGSize) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "InvalidateMessageTintColor", Selector = "invalidateMessageTintColor")]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "MessageTintColor", Selector = "messageTintColor", PropertyType = typeof (UIColor), GetterSelector = "messageTintColor", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "MessageCornerRadius", Selector = "messageCornerRadius", PropertyType = typeof (NFloat), GetterSelector = "messageCornerRadius", ArgumentSemantic = ArgumentSemantic.None)]
	public partial interface IMSMessagesAppTranscriptPresentation : INativeObject, IDisposable
	{
		/// <param name="size">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.RequiredMember]
		[Export ("contentSizeThatFits:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual CGSize GetContentSizeThatFits (CGSize size)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="size">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static CGSize _GetContentSizeThatFits (IMSMessagesAppTranscriptPresentation This, CGSize size)
		{
			CGSize ret;
			ret = global::ObjCRuntime.Messaging.CGSize_objc_msgSend_CGSize (This.Handle, Selector.GetHandle ("contentSizeThatFits:"), size);
			GC.KeepAlive (This);
			return ret;
		}
		[global::Foundation.RequiredMember]
		[Export ("invalidateMessageTintColor")]
		[SupportedOSPlatform ("ios26.0")]
		[SupportedOSPlatform ("maccatalyst26.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void InvalidateMessageTintColor ()
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[SupportedOSPlatform ("ios26.0")]
		[SupportedOSPlatform ("maccatalyst26.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _InvalidateMessageTintColor (IMSMessagesAppTranscriptPresentation This)
		{
			global::ObjCRuntime.Messaging.void_objc_msgSend (This.Handle, Selector.GetHandle ("invalidateMessageTintColor"));
			GC.KeepAlive (This);
		}
		[DynamicDependencyAttribute ("GetContentSizeThatFits(CoreGraphics.CGSize)")]
		[DynamicDependencyAttribute ("InvalidateMessageTintColor()")]
		[DynamicDependencyAttribute ("MessageCornerRadius")]
		[DynamicDependencyAttribute ("MessageTintColor")]
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.Interfaces | DynamicallyAccessedMemberTypes.PublicConstructors, typeof (MSMessagesAppTranscriptPresentationWrapper))]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static IMSMessagesAppTranscriptPresentation ()
		{
			GC.KeepAlive (null);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("ios26.0")]
		[SupportedOSPlatform ("maccatalyst26.0")]
		[global::Foundation.RequiredMember]
		public virtual global::UIKit.UIColor MessageTintColor {
			[Export ("messageTintColor")]
			get {
				return _GetMessageTintColor (this);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static global::UIKit.UIColor _GetMessageTintColor (IMSMessagesAppTranscriptPresentation This)
		{
			global::UIKit.UIColor ret;
			ret =  Runtime.GetNSObject<global::UIKit.UIColor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("messageTintColor")), false)!;
			GC.KeepAlive (This);
			return ret;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("ios26.0")]
		[SupportedOSPlatform ("maccatalyst26.0")]
		[global::Foundation.RequiredMember]
		public virtual nfloat MessageCornerRadius {
			[Export ("messageCornerRadius")]
			get {
				return _GetMessageCornerRadius (this);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static nfloat _GetMessageCornerRadius (IMSMessagesAppTranscriptPresentation This)
		{
			nfloat ret;
			ret = global::ObjCRuntime.Messaging.nfloat_objc_msgSend (This.Handle, Selector.GetHandle ("messageCornerRadius"));
			GC.KeepAlive (This);
			return ret;
		}
	}
	#pragma warning restore CS1573
	internal unsafe sealed class MSMessagesAppTranscriptPresentationWrapper : BaseWrapper, IMSMessagesAppTranscriptPresentation {
		public MSMessagesAppTranscriptPresentationWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.PublicConstructors, typeof (MSMessagesAppTranscriptPresentationWrapper))]
		static MSMessagesAppTranscriptPresentationWrapper ()
		{
			GC.KeepAlive (null);
		}
		/// <param name="size">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("contentSizeThatFits:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public CGSize GetContentSizeThatFits (CGSize size)
		{
			CGSize ret;
			ret = global::ObjCRuntime.Messaging.CGSize_objc_msgSend_CGSize (this.Handle, Selector.GetHandle ("contentSizeThatFits:"), size);
			return ret;
		}
		[Export ("invalidateMessageTintColor")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void InvalidateMessageTintColor ()
		{
			global::ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, Selector.GetHandle ("invalidateMessageTintColor"));
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("ios26.0")]
		[SupportedOSPlatform ("maccatalyst26.0")]
		public global::UIKit.UIColor MessageTintColor {
			[Export ("messageTintColor")]
			get {
				global::UIKit.UIColor ret;
				ret =  Runtime.GetNSObject<global::UIKit.UIColor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("messageTintColor")), false)!;
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("ios26.0")]
		[SupportedOSPlatform ("maccatalyst26.0")]
		public nfloat MessageCornerRadius {
			[Export ("messageCornerRadius")]
			get {
				nfloat ret;
				ret = global::ObjCRuntime.Messaging.nfloat_objc_msgSend (this.Handle, Selector.GetHandle ("messageCornerRadius"));
				return ret;
			}
		}
	}
}
