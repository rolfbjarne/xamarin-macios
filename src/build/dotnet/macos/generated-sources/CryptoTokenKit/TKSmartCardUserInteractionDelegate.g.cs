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
namespace CryptoTokenKit {
	#pragma warning disable CS1573
	/// <summary>This interface represents the Objective-C protocol <c>TKSmartCardUserInteractionDelegate</c>.</summary>
	/// <remarks>
	///   <para>A class that implements this interface (and subclasses <see cref="NSObject" />) will be exported to Objective-C as implementing the Objective-C protocol this interface represents.</para>
	///   <para>A class may also implement members from this interface to implement members from the protocol.</para>
	/// </remarks>
	[SupportedOSPlatform ("ios13.0")]
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("tvos13.0")]
	[Protocol (Name = "TKSmartCardUserInteractionDelegate", WrapperType = typeof (TKSmartCardUserInteractionDelegateWrapper))]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "CharacterEntered", Selector = "characterEnteredInUserInteraction:", ParameterType = new Type [] { typeof (CryptoTokenKit.TKSmartCardUserInteraction) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "CorrectionKeyPressed", Selector = "correctionKeyPressedInUserInteraction:", ParameterType = new Type [] { typeof (CryptoTokenKit.TKSmartCardUserInteraction) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "ValidationKeyPressed", Selector = "validationKeyPressedInUserInteraction:", ParameterType = new Type [] { typeof (CryptoTokenKit.TKSmartCardUserInteraction) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "InvalidCharacterEntered", Selector = "invalidCharacterEnteredInUserInteraction:", ParameterType = new Type [] { typeof (CryptoTokenKit.TKSmartCardUserInteraction) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "OldPinRequested", Selector = "oldPINRequestedInUserInteraction:", ParameterType = new Type [] { typeof (CryptoTokenKit.TKSmartCardUserInteraction) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "NewPinRequested", Selector = "newPINRequestedInUserInteraction:", ParameterType = new Type [] { typeof (CryptoTokenKit.TKSmartCardUserInteraction) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "NewPinConfirmationRequested", Selector = "newPINConfirmationRequestedInUserInteraction:", ParameterType = new Type [] { typeof (CryptoTokenKit.TKSmartCardUserInteraction) }, ParameterByRef = new bool [] { false })]
	public partial interface ITKSmartCardUserInteractionDelegate : INativeObject, IDisposable
	{
		[global::Foundation.OptionalMember]
		[Export ("characterEnteredInUserInteraction:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void CharacterEntered (TKSmartCardUserInteraction interaction)
		{
			_CharacterEntered (this, interaction);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _CharacterEntered (ITKSmartCardUserInteractionDelegate This, TKSmartCardUserInteraction interaction)
		{
			var interaction__handle__ = interaction!.GetNonNullHandle (nameof (interaction));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("characterEnteredInUserInteraction:"), interaction__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (interaction);
		}
		[global::Foundation.OptionalMember]
		[Export ("correctionKeyPressedInUserInteraction:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void CorrectionKeyPressed (TKSmartCardUserInteraction interaction)
		{
			_CorrectionKeyPressed (this, interaction);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _CorrectionKeyPressed (ITKSmartCardUserInteractionDelegate This, TKSmartCardUserInteraction interaction)
		{
			var interaction__handle__ = interaction!.GetNonNullHandle (nameof (interaction));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("correctionKeyPressedInUserInteraction:"), interaction__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (interaction);
		}
		[global::Foundation.OptionalMember]
		[Export ("validationKeyPressedInUserInteraction:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void ValidationKeyPressed (TKSmartCardUserInteraction interaction)
		{
			_ValidationKeyPressed (this, interaction);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _ValidationKeyPressed (ITKSmartCardUserInteractionDelegate This, TKSmartCardUserInteraction interaction)
		{
			var interaction__handle__ = interaction!.GetNonNullHandle (nameof (interaction));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("validationKeyPressedInUserInteraction:"), interaction__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (interaction);
		}
		[global::Foundation.OptionalMember]
		[Export ("invalidCharacterEnteredInUserInteraction:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void InvalidCharacterEntered (TKSmartCardUserInteraction interaction)
		{
			_InvalidCharacterEntered (this, interaction);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _InvalidCharacterEntered (ITKSmartCardUserInteractionDelegate This, TKSmartCardUserInteraction interaction)
		{
			var interaction__handle__ = interaction!.GetNonNullHandle (nameof (interaction));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("invalidCharacterEnteredInUserInteraction:"), interaction__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (interaction);
		}
		[global::Foundation.OptionalMember]
		[Export ("oldPINRequestedInUserInteraction:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void OldPinRequested (TKSmartCardUserInteraction interaction)
		{
			_OldPinRequested (this, interaction);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _OldPinRequested (ITKSmartCardUserInteractionDelegate This, TKSmartCardUserInteraction interaction)
		{
			var interaction__handle__ = interaction!.GetNonNullHandle (nameof (interaction));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("oldPINRequestedInUserInteraction:"), interaction__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (interaction);
		}
		[global::Foundation.OptionalMember]
		[Export ("newPINRequestedInUserInteraction:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void NewPinRequested (TKSmartCardUserInteraction interaction)
		{
			_NewPinRequested (this, interaction);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _NewPinRequested (ITKSmartCardUserInteractionDelegate This, TKSmartCardUserInteraction interaction)
		{
			var interaction__handle__ = interaction!.GetNonNullHandle (nameof (interaction));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("newPINRequestedInUserInteraction:"), interaction__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (interaction);
		}
		[global::Foundation.OptionalMember]
		[Export ("newPINConfirmationRequestedInUserInteraction:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void NewPinConfirmationRequested (TKSmartCardUserInteraction interaction)
		{
			_NewPinConfirmationRequested (this, interaction);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _NewPinConfirmationRequested (ITKSmartCardUserInteractionDelegate This, TKSmartCardUserInteraction interaction)
		{
			var interaction__handle__ = interaction!.GetNonNullHandle (nameof (interaction));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("newPINConfirmationRequestedInUserInteraction:"), interaction__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (interaction);
		}
		[DynamicDependencyAttribute ("CharacterEntered(CryptoTokenKit.TKSmartCardUserInteraction)")]
		[DynamicDependencyAttribute ("CorrectionKeyPressed(CryptoTokenKit.TKSmartCardUserInteraction)")]
		[DynamicDependencyAttribute ("InvalidCharacterEntered(CryptoTokenKit.TKSmartCardUserInteraction)")]
		[DynamicDependencyAttribute ("NewPinConfirmationRequested(CryptoTokenKit.TKSmartCardUserInteraction)")]
		[DynamicDependencyAttribute ("NewPinRequested(CryptoTokenKit.TKSmartCardUserInteraction)")]
		[DynamicDependencyAttribute ("OldPinRequested(CryptoTokenKit.TKSmartCardUserInteraction)")]
		[DynamicDependencyAttribute ("ValidationKeyPressed(CryptoTokenKit.TKSmartCardUserInteraction)")]
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.Interfaces | DynamicallyAccessedMemberTypes.PublicConstructors, typeof (TKSmartCardUserInteractionDelegateWrapper))]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static ITKSmartCardUserInteractionDelegate ()
		{
			GC.KeepAlive (null);
		}
	}
	#pragma warning restore CS1573
	#pragma warning disable CS1573
	/// <summary>Extension methods to the <see cref="ITKSmartCardUserInteractionDelegate" /> interface to support all the methods from the TKSmartCardUserInteractionDelegate protocol.</summary>
	/// <remarks>
	///   <para>The extension methods for <see cref="ITKSmartCardUserInteractionDelegate" /> interface allow developers to treat instances of the interface as having all the optional methods of the original TKSmartCardUserInteractionDelegate protocol. Since the interface only contains the required members, these extension methods allow developers to call the optional members of the protocol.</para>
	/// </remarks>
	public unsafe static partial class TKSmartCardUserInteractionDelegate_Extensions {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void CharacterEntered (this ITKSmartCardUserInteractionDelegate This, TKSmartCardUserInteraction interaction)
		{
			var interaction__handle__ = interaction!.GetNonNullHandle (nameof (interaction));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("characterEnteredInUserInteraction:"), interaction__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (interaction);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void CorrectionKeyPressed (this ITKSmartCardUserInteractionDelegate This, TKSmartCardUserInteraction interaction)
		{
			var interaction__handle__ = interaction!.GetNonNullHandle (nameof (interaction));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("correctionKeyPressedInUserInteraction:"), interaction__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (interaction);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void ValidationKeyPressed (this ITKSmartCardUserInteractionDelegate This, TKSmartCardUserInteraction interaction)
		{
			var interaction__handle__ = interaction!.GetNonNullHandle (nameof (interaction));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("validationKeyPressedInUserInteraction:"), interaction__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (interaction);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void InvalidCharacterEntered (this ITKSmartCardUserInteractionDelegate This, TKSmartCardUserInteraction interaction)
		{
			var interaction__handle__ = interaction!.GetNonNullHandle (nameof (interaction));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("invalidCharacterEnteredInUserInteraction:"), interaction__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (interaction);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void OldPinRequested (this ITKSmartCardUserInteractionDelegate This, TKSmartCardUserInteraction interaction)
		{
			var interaction__handle__ = interaction!.GetNonNullHandle (nameof (interaction));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("oldPINRequestedInUserInteraction:"), interaction__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (interaction);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void NewPinRequested (this ITKSmartCardUserInteractionDelegate This, TKSmartCardUserInteraction interaction)
		{
			var interaction__handle__ = interaction!.GetNonNullHandle (nameof (interaction));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("newPINRequestedInUserInteraction:"), interaction__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (interaction);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void NewPinConfirmationRequested (this ITKSmartCardUserInteractionDelegate This, TKSmartCardUserInteraction interaction)
		{
			var interaction__handle__ = interaction!.GetNonNullHandle (nameof (interaction));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("newPINConfirmationRequestedInUserInteraction:"), interaction__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (interaction);
		}
	}
	#pragma warning restore CS1573
	internal unsafe sealed class TKSmartCardUserInteractionDelegateWrapper : BaseWrapper, ITKSmartCardUserInteractionDelegate {
		public TKSmartCardUserInteractionDelegateWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.PublicConstructors, typeof (TKSmartCardUserInteractionDelegateWrapper))]
		static TKSmartCardUserInteractionDelegateWrapper ()
		{
			GC.KeepAlive (null);
		}
	}
}
