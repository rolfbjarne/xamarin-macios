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
namespace UIKit {
	#pragma warning disable CS1573
	/// <summary>This interface represents the Objective-C protocol <c>UIGuidedAccessRestrictionDelegate</c>.</summary>
	/// <remarks>
	///   <para>A class that implements this interface (and subclasses <see cref="NSObject" />) will be exported to Objective-C as implementing the Objective-C protocol this interface represents.</para>
	///   <para>A class may also implement members from this interface to implement members from the protocol.</para>
	/// </remarks>
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("tvos")]
	[Protocol (Name = "UIGuidedAccessRestrictionDelegate", WrapperType = typeof (UIGuidedAccessRestrictionDelegateWrapper))]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "GuidedAccessRestrictionChangedState", Selector = "guidedAccessRestrictionWithIdentifier:didChangeState:", ParameterType = new Type [] { typeof (string), typeof (UIGuidedAccessRestrictionState) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "GetTextForGuidedAccessRestriction", Selector = "textForGuidedAccessRestrictionWithIdentifier:", ReturnType = typeof (string), ParameterType = new Type [] { typeof (string) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "GetDetailTextForGuidedAccessRestriction", Selector = "detailTextForGuidedAccessRestrictionWithIdentifier:", ReturnType = typeof (string), ParameterType = new Type [] { typeof (string) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "GetGuidedAccessRestrictionIdentifiers", Selector = "guidedAccessRestrictionIdentifiers", PropertyType = typeof (String[]), GetterSelector = "guidedAccessRestrictionIdentifiers", ArgumentSemantic = ArgumentSemantic.None)]
	public partial interface IUIGuidedAccessRestrictionDelegate : INativeObject, IDisposable
	{
		/// <param name="restrictionIdentifier">To be added.</param><param name="newRestrictionState">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[global::Foundation.RequiredMember]
		[Export ("guidedAccessRestrictionWithIdentifier:didChangeState:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void GuidedAccessRestrictionChangedState (string restrictionIdentifier, UIGuidedAccessRestrictionState newRestrictionState)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="restrictionIdentifier">To be added.</param><param name="newRestrictionState">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _GuidedAccessRestrictionChangedState (IUIGuidedAccessRestrictionDelegate This, string restrictionIdentifier, UIGuidedAccessRestrictionState newRestrictionState)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			if (restrictionIdentifier is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (restrictionIdentifier));
			var nsrestrictionIdentifier = CFString.CreateNative (restrictionIdentifier);
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_IntPtr (This.Handle, Selector.GetHandle ("guidedAccessRestrictionWithIdentifier:didChangeState:"), nsrestrictionIdentifier, (IntPtr) (long) newRestrictionState);
			GC.KeepAlive (This);
			CFString.ReleaseNative (nsrestrictionIdentifier);
		}
		/// <param name="restrictionIdentifier">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.RequiredMember]
		[Export ("textForGuidedAccessRestrictionWithIdentifier:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string GetTextForGuidedAccessRestriction (string restrictionIdentifier)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="restrictionIdentifier">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static string _GetTextForGuidedAccessRestriction (IUIGuidedAccessRestrictionDelegate This, string restrictionIdentifier)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			if (restrictionIdentifier is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (restrictionIdentifier));
			var nsrestrictionIdentifier = CFString.CreateNative (restrictionIdentifier);
			string? ret;
			ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("textForGuidedAccessRestrictionWithIdentifier:"), nsrestrictionIdentifier), false)!;
			GC.KeepAlive (This);
			CFString.ReleaseNative (nsrestrictionIdentifier);
			return ret!;
		}
		/// <param name="restrictionIdentifier">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("detailTextForGuidedAccessRestrictionWithIdentifier:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string GetDetailTextForGuidedAccessRestriction (string restrictionIdentifier)
		{
			return _GetDetailTextForGuidedAccessRestriction (this, restrictionIdentifier);
		}
		/// <param name="restrictionIdentifier">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static string _GetDetailTextForGuidedAccessRestriction (IUIGuidedAccessRestrictionDelegate This, string restrictionIdentifier)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			if (restrictionIdentifier is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (restrictionIdentifier));
			var nsrestrictionIdentifier = CFString.CreateNative (restrictionIdentifier);
			string? ret;
			ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("detailTextForGuidedAccessRestrictionWithIdentifier:"), nsrestrictionIdentifier), false)!;
			GC.KeepAlive (This);
			CFString.ReleaseNative (nsrestrictionIdentifier);
			return ret!;
		}
		[DynamicDependencyAttribute ("GetDetailTextForGuidedAccessRestriction(System.String)")]
		[DynamicDependencyAttribute ("GetGuidedAccessRestrictionIdentifiers")]
		[DynamicDependencyAttribute ("GetTextForGuidedAccessRestriction(System.String)")]
		[DynamicDependencyAttribute ("GuidedAccessRestrictionChangedState(System.String,UIKit.UIGuidedAccessRestrictionState)")]
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.Interfaces | DynamicallyAccessedMemberTypes.PublicConstructors, typeof (UIGuidedAccessRestrictionDelegateWrapper))]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static IUIGuidedAccessRestrictionDelegate ()
		{
			GC.KeepAlive (null);
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual string[] GetGuidedAccessRestrictionIdentifiers {
			[Export ("guidedAccessRestrictionIdentifiers")]
			get {
				return _GetGetGuidedAccessRestrictionIdentifiers (this);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static string[] _GetGetGuidedAccessRestrictionIdentifiers (IUIGuidedAccessRestrictionDelegate This)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			string[] ret;
			ret = CFArray.StringArrayFromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("guidedAccessRestrictionIdentifiers")), false)!;
			GC.KeepAlive (This);
			return ret;
		}
	}
	#pragma warning restore CS1573
	#pragma warning disable CS1573
	/// <summary>Extension methods to the <see cref="IUIGuidedAccessRestrictionDelegate" /> interface to support all the methods from the UIGuidedAccessRestrictionDelegate protocol.</summary>
	/// <remarks>
	///   <para>The extension methods for <see cref="IUIGuidedAccessRestrictionDelegate" /> interface allow developers to treat instances of the interface as having all the optional methods of the original UIGuidedAccessRestrictionDelegate protocol. Since the interface only contains the required members, these extension methods allow developers to call the optional members of the protocol.</para>
	/// </remarks>
	public unsafe static partial class UIGuidedAccessRestrictionDelegate_Extensions {
		/// <param name="restrictionIdentifier">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static string GetDetailTextForGuidedAccessRestriction (this IUIGuidedAccessRestrictionDelegate This, string restrictionIdentifier)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			if (restrictionIdentifier is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (restrictionIdentifier));
			var nsrestrictionIdentifier = CFString.CreateNative (restrictionIdentifier);
			string? ret;
			ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("detailTextForGuidedAccessRestrictionWithIdentifier:"), nsrestrictionIdentifier), false)!;
			GC.KeepAlive (This);
			CFString.ReleaseNative (nsrestrictionIdentifier);
			return ret!;
		}
	}
	#pragma warning restore CS1573
	internal unsafe sealed class UIGuidedAccessRestrictionDelegateWrapper : BaseWrapper, IUIGuidedAccessRestrictionDelegate {
		public UIGuidedAccessRestrictionDelegateWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.PublicConstructors, typeof (UIGuidedAccessRestrictionDelegateWrapper))]
		static UIGuidedAccessRestrictionDelegateWrapper ()
		{
			GC.KeepAlive (null);
		}
		/// <param name="restrictionIdentifier">To be added.</param><param name="newRestrictionState">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("guidedAccessRestrictionWithIdentifier:didChangeState:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void GuidedAccessRestrictionChangedState (string restrictionIdentifier, UIGuidedAccessRestrictionState newRestrictionState)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			if (restrictionIdentifier is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (restrictionIdentifier));
			var nsrestrictionIdentifier = CFString.CreateNative (restrictionIdentifier);
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_IntPtr (this.Handle, Selector.GetHandle ("guidedAccessRestrictionWithIdentifier:didChangeState:"), nsrestrictionIdentifier, (IntPtr) (long) newRestrictionState);
			CFString.ReleaseNative (nsrestrictionIdentifier);
		}
		/// <param name="restrictionIdentifier">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("textForGuidedAccessRestrictionWithIdentifier:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public string GetTextForGuidedAccessRestriction (string restrictionIdentifier)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			if (restrictionIdentifier is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (restrictionIdentifier));
			var nsrestrictionIdentifier = CFString.CreateNative (restrictionIdentifier);
			string? ret;
			ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("textForGuidedAccessRestrictionWithIdentifier:"), nsrestrictionIdentifier), false)!;
			CFString.ReleaseNative (nsrestrictionIdentifier);
			return ret!;
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public string[] GetGuidedAccessRestrictionIdentifiers {
			[Export ("guidedAccessRestrictionIdentifiers")]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				string[] ret;
				ret = CFArray.StringArrayFromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("guidedAccessRestrictionIdentifiers")), false)!;
				return ret;
			}
		}
	}
}
