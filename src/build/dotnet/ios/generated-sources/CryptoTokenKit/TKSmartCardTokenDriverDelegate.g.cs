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
namespace CryptoTokenKit {
	#pragma warning disable CS1573
	/// <summary>This interface represents the Objective-C protocol <c>TKSmartCardTokenDriverDelegate</c>.</summary>
	/// <remarks>
	///   <para>A class that implements this interface (and subclasses <see cref="NSObject" />) will be exported to Objective-C as implementing the Objective-C protocol this interface represents.</para>
	///   <para>A class may also implement members from this interface to implement members from the protocol.</para>
	/// </remarks>
	[SupportedOSPlatform ("ios13.0")]
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("tvos13.0")]
	[Protocol (Name = "TKSmartCardTokenDriverDelegate", WrapperType = typeof (TKSmartCardTokenDriverDelegateWrapper))]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "CreateToken", Selector = "tokenDriver:createTokenForSmartCard:AID:error:", ReturnType = typeof (CryptoTokenKit.TKSmartCardToken), ParameterType = new Type [] { typeof (CryptoTokenKit.TKSmartCardTokenDriver), typeof (CryptoTokenKit.TKSmartCard), typeof (NSData), typeof (NSError) }, ParameterByRef = new bool [] { false, false, false, true })]
	public partial interface ITKSmartCardTokenDriverDelegate : INativeObject, IDisposable, 
		CryptoTokenKit.ITKTokenDriverDelegate
	{
		[global::Foundation.RequiredMember]
		[Export ("tokenDriver:createTokenForSmartCard:AID:error:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual TKSmartCardToken? CreateToken (TKSmartCardTokenDriver driver, TKSmartCard smartCard, NSData? aid, out NSError? error)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal unsafe static TKSmartCardToken? _CreateToken (ITKSmartCardTokenDriverDelegate This, TKSmartCardTokenDriver driver, TKSmartCard smartCard, NSData? aid, out NSError? error)
		{
			var driver__handle__ = driver!.GetNonNullHandle (nameof (driver));
			var smartCard__handle__ = smartCard!.GetNonNullHandle (nameof (smartCard));
			var aid__handle__ = aid.GetHandle ();
			NativeHandle errorValue = IntPtr.Zero;
			TKSmartCardToken? ret;
			ret =  Runtime.GetNSObject<TKSmartCardToken> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle_ref_NativeHandle (This.Handle, Selector.GetHandle ("tokenDriver:createTokenForSmartCard:AID:error:"), driver__handle__, smartCard__handle__, aid__handle__, &errorValue), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (driver);
			GC.KeepAlive (smartCard);
			GC.KeepAlive (aid);
			error = Runtime.GetNSObject<NSError> (errorValue)!;
			return ret!;
		}
		[DynamicDependencyAttribute ("CreateToken(CryptoTokenKit.TKSmartCardTokenDriver,CryptoTokenKit.TKSmartCard,Foundation.NSData,Foundation.NSError@)")]
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.Interfaces | DynamicallyAccessedMemberTypes.PublicConstructors, typeof (TKSmartCardTokenDriverDelegateWrapper))]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static ITKSmartCardTokenDriverDelegate ()
		{
			GC.KeepAlive (null);
		}
	}
	#pragma warning restore CS1573
	internal unsafe sealed class TKSmartCardTokenDriverDelegateWrapper : BaseWrapper, ITKSmartCardTokenDriverDelegate {
		public TKSmartCardTokenDriverDelegateWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.PublicConstructors, typeof (TKSmartCardTokenDriverDelegateWrapper))]
		static TKSmartCardTokenDriverDelegateWrapper ()
		{
			GC.KeepAlive (null);
		}
		[Export ("tokenDriver:createTokenForSmartCard:AID:error:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe TKSmartCardToken? CreateToken (TKSmartCardTokenDriver driver, TKSmartCard smartCard, NSData? aid, out NSError? error)
		{
			var driver__handle__ = driver!.GetNonNullHandle (nameof (driver));
			var smartCard__handle__ = smartCard!.GetNonNullHandle (nameof (smartCard));
			var aid__handle__ = aid.GetHandle ();
			NativeHandle errorValue = IntPtr.Zero;
			TKSmartCardToken? ret;
			ret =  Runtime.GetNSObject<TKSmartCardToken> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle_ref_NativeHandle (this.Handle, Selector.GetHandle ("tokenDriver:createTokenForSmartCard:AID:error:"), driver__handle__, smartCard__handle__, aid__handle__, &errorValue), false)!;
			GC.KeepAlive (driver);
			GC.KeepAlive (smartCard);
			GC.KeepAlive (aid);
			error = Runtime.GetNSObject<NSError> (errorValue)!;
			return ret!;
		}
	}
}
