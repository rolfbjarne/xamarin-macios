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
namespace PassKit {
	#pragma warning disable CS1573
	/// <summary>This interface represents the Objective-C protocol <c>PKIdentityDocumentDescriptor</c>.</summary>
	/// <remarks>
	///   <para>A class that implements this interface (and subclasses <see cref="NSObject" />) will be exported to Objective-C as implementing the Objective-C protocol this interface represents.</para>
	///   <para>A class may also implement members from this interface to implement members from the protocol.</para>
	/// </remarks>
	[UnsupportedOSPlatform ("tvos")]
	[UnsupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("ios16.0")]
	[SupportedOSPlatform ("maccatalyst16.0")]
	[Protocol (Name = "PKIdentityDocumentDescriptor", WrapperType = typeof (PKIdentityDocumentDescriptorWrapper))]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "GetIntentToStore", Selector = "intentToStoreForElement:", ReturnType = typeof (PassKit.PKIdentityIntentToStore), ParameterType = new Type [] { typeof (PassKit.PKIdentityElement) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "AddElements", Selector = "addElements:withIntentToStore:", ParameterType = new Type [] { typeof (PassKit.PKIdentityElement[]), typeof (PassKit.PKIdentityIntentToStore) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "Elements", Selector = "elements", PropertyType = typeof (PassKit.PKIdentityElement[]), GetterSelector = "elements", ArgumentSemantic = ArgumentSemantic.None)]
	public partial interface IPKIdentityDocumentDescriptor : INativeObject, IDisposable
	{
		[global::Foundation.RequiredMember]
		[Export ("intentToStoreForElement:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual PKIdentityIntentToStore? GetIntentToStore (PKIdentityElement element)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static PKIdentityIntentToStore? _GetIntentToStore (IPKIdentityDocumentDescriptor This, PKIdentityElement element)
		{
			var element__handle__ = element!.GetNonNullHandle (nameof (element));
			PKIdentityIntentToStore? ret;
			ret =  Runtime.GetNSObject<PKIdentityIntentToStore> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("intentToStoreForElement:"), element__handle__), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (element);
			return ret!;
		}
		[global::Foundation.RequiredMember]
		[Export ("addElements:withIntentToStore:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void AddElements (PKIdentityElement[] elements, PKIdentityIntentToStore intentToStore)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _AddElements (IPKIdentityDocumentDescriptor This, PKIdentityElement[] elements, PKIdentityIntentToStore intentToStore)
		{
			if (elements is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (elements));
			var intentToStore__handle__ = intentToStore!.GetNonNullHandle (nameof (intentToStore));
			using var nsa_elements = NSArray.FromNSObjects (elements);
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("addElements:withIntentToStore:"), nsa_elements.Handle, intentToStore__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (intentToStore);
		}
		[DynamicDependencyAttribute ("AddElements(PassKit.PKIdentityElement[],PassKit.PKIdentityIntentToStore)")]
		[DynamicDependencyAttribute ("Elements")]
		[DynamicDependencyAttribute ("GetIntentToStore(PassKit.PKIdentityElement)")]
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.Interfaces | DynamicallyAccessedMemberTypes.PublicConstructors, typeof (PKIdentityDocumentDescriptorWrapper))]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static IPKIdentityDocumentDescriptor ()
		{
			GC.KeepAlive (null);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual PKIdentityElement[] Elements {
			[Export ("elements")]
			get {
				return _GetElements (this);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static PKIdentityElement[] _GetElements (IPKIdentityDocumentDescriptor This)
		{
			PKIdentityElement[] ret;
			ret = CFArray.ArrayFromHandle<PKIdentityElement>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("elements")), false)!;
			GC.KeepAlive (This);
			return ret;
		}
	}
	#pragma warning restore CS1573
	internal unsafe sealed class PKIdentityDocumentDescriptorWrapper : BaseWrapper, IPKIdentityDocumentDescriptor {
		public PKIdentityDocumentDescriptorWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.PublicConstructors, typeof (PKIdentityDocumentDescriptorWrapper))]
		static PKIdentityDocumentDescriptorWrapper ()
		{
			GC.KeepAlive (null);
		}
		[Export ("intentToStoreForElement:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public PKIdentityIntentToStore? GetIntentToStore (PKIdentityElement element)
		{
			var element__handle__ = element!.GetNonNullHandle (nameof (element));
			PKIdentityIntentToStore? ret;
			ret =  Runtime.GetNSObject<PKIdentityIntentToStore> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("intentToStoreForElement:"), element__handle__), false)!;
			GC.KeepAlive (element);
			return ret!;
		}
		[Export ("addElements:withIntentToStore:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void AddElements (PKIdentityElement[] elements, PKIdentityIntentToStore intentToStore)
		{
			if (elements is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (elements));
			var intentToStore__handle__ = intentToStore!.GetNonNullHandle (nameof (intentToStore));
			using var nsa_elements = NSArray.FromNSObjects (elements);
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("addElements:withIntentToStore:"), nsa_elements.Handle, intentToStore__handle__);
			GC.KeepAlive (intentToStore);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public PKIdentityElement[] Elements {
			[Export ("elements")]
			get {
				PKIdentityElement[] ret;
				ret = CFArray.ArrayFromHandle<PKIdentityElement>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("elements")), false)!;
				return ret;
			}
		}
	}
}
