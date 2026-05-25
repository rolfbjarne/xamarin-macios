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
namespace UIKit {
	#pragma warning disable CS1573
	/// <summary>Interface that describes a text view drop request.</summary>
	[UnsupportedOSPlatform ("tvos")]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[Protocol (Name = "UITextDropRequest", WrapperType = typeof (UITextDropRequestWrapper))]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "DropPosition", Selector = "dropPosition", PropertyType = typeof (UITextPosition), GetterSelector = "dropPosition", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "SuggestedProposal", Selector = "suggestedProposal", PropertyType = typeof (UITextDropProposal), GetterSelector = "suggestedProposal", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "SameView", Selector = "sameView", PropertyType = typeof (bool), GetterSelector = "isSameView", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "DropSession", Selector = "dropSession", PropertyType = typeof (IUIDropSession), GetterSelector = "dropSession", ArgumentSemantic = ArgumentSemantic.None)]
	public partial interface IUITextDropRequest : INativeObject, IDisposable
	{
		[DynamicDependencyAttribute ("DropPosition")]
		[DynamicDependencyAttribute ("DropSession")]
		[DynamicDependencyAttribute ("SameView")]
		[DynamicDependencyAttribute ("SuggestedProposal")]
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.Interfaces | DynamicallyAccessedMemberTypes.PublicConstructors, typeof (UITextDropRequestWrapper))]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static IUITextDropRequest ()
		{
			GC.KeepAlive (null);
		}
		/// <summary>Gets the text position where dropped text will appear.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual UITextPosition DropPosition {
			[Export ("dropPosition")]
			get {
				return _GetDropPosition (this);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static UITextPosition _GetDropPosition (IUITextDropRequest This)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			UITextPosition ret;
			ret =  Runtime.GetNSObject<UITextPosition> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("dropPosition")), false)!;
			GC.KeepAlive (This);
			return ret;
		}
		/// <summary>Gets the drop proposal that the text view is offering.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual UITextDropProposal SuggestedProposal {
			[Export ("suggestedProposal")]
			get {
				return _GetSuggestedProposal (this);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static UITextDropProposal _GetSuggestedProposal (IUITextDropRequest This)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			UITextDropProposal ret;
			ret =  Runtime.GetNSObject<UITextDropProposal> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("suggestedProposal")), false)!;
			GC.KeepAlive (This);
			return ret;
		}
		/// <summary>Gets a Boolean value that tells whether the drag for the drop started in the same view.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual bool SameView {
			[Export ("isSameView")]
			get {
				return _GetSameView (this);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static bool _GetSameView (IUITextDropRequest This)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (This.Handle, Selector.GetHandle ("isSameView"));
			GC.KeepAlive (This);
			return ret != 0;
		}
		/// <summary>Gets the drop session.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual IUIDropSession DropSession {
			[Export ("dropSession")]
			get {
				return _GetDropSession (this);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static IUIDropSession _GetDropSession (IUITextDropRequest This)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			IUIDropSession ret;
			ret =  Runtime.GetINativeObject<IUIDropSession> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("dropSession")), false)!;
			GC.KeepAlive (This);
			return ret;
		}
	}
	#pragma warning restore CS1573
	internal unsafe sealed class UITextDropRequestWrapper : BaseWrapper, IUITextDropRequest {
		public UITextDropRequestWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.PublicConstructors, typeof (UITextDropRequestWrapper))]
		static UITextDropRequestWrapper ()
		{
			GC.KeepAlive (null);
		}
		/// <summary>Gets the text position where dropped text will appear.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public UITextPosition DropPosition {
			[Export ("dropPosition")]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				UITextPosition ret;
				ret =  Runtime.GetNSObject<UITextPosition> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("dropPosition")), false)!;
				return ret;
			}
		}
		/// <summary>Gets the drop proposal that the text view is offering.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public UITextDropProposal SuggestedProposal {
			[Export ("suggestedProposal")]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				UITextDropProposal ret;
				ret =  Runtime.GetNSObject<UITextDropProposal> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("suggestedProposal")), false)!;
				return ret;
			}
		}
		/// <summary>Gets a Boolean value that tells whether the drag for the drop started in the same view.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public bool SameView {
			[Export ("isSameView")]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				byte ret;
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("isSameView"));
				return ret != 0;
			}
		}
		/// <summary>Gets the drop session.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public IUIDropSession DropSession {
			[Export ("dropSession")]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				IUIDropSession ret;
				ret =  Runtime.GetINativeObject<IUIDropSession> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("dropSession")), false)!;
				return ret;
			}
		}
	}
}
