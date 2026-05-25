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
namespace UIKit {
	#pragma warning disable CS1573
	/// <summary>This interface represents the Objective-C protocol <c>UIDataSourceModelAssociation</c>.</summary>
	/// <remarks>
	///   <para>A class that implements this interface (and subclasses <see cref="NSObject" />) will be exported to Objective-C as implementing the Objective-C protocol this interface represents.</para>
	///   <para>A class may also implement members from this interface to implement members from the protocol.</para>
	/// </remarks>
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("tvos")]
	[Protocol (Name = "UIDataSourceModelAssociation", WrapperType = typeof (UIDataSourceModelAssociationWrapper))]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "GetModelIdentifier", Selector = "modelIdentifierForElementAtIndexPath:inView:", ReturnType = typeof (string), ParameterType = new Type [] { typeof (NSIndexPath), typeof (UIView) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "GetIndexPath", Selector = "indexPathForElementWithModelIdentifier:inView:", ReturnType = typeof (NSIndexPath), ParameterType = new Type [] { typeof (string), typeof (UIView) }, ParameterByRef = new bool [] { false, false })]
	public partial interface IUIDataSourceModelAssociation : INativeObject, IDisposable
	{
		/// <param name="idx">To be added.</param><param name="view">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.RequiredMember]
		[Export ("modelIdentifierForElementAtIndexPath:inView:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string GetModelIdentifier (NSIndexPath idx, UIView view)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="idx">To be added.</param><param name="view">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static string _GetModelIdentifier (IUIDataSourceModelAssociation This, NSIndexPath idx, UIView view)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var idx__handle__ = idx!.GetNonNullHandle (nameof (idx));
			var view__handle__ = view!.GetNonNullHandle (nameof (view));
			string? ret;
			ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("modelIdentifierForElementAtIndexPath:inView:"), idx__handle__, view__handle__), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (idx);
			GC.KeepAlive (view);
			return ret!;
		}
		/// <param name="identifier">To be added.</param><param name="view">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.RequiredMember]
		[Export ("indexPathForElementWithModelIdentifier:inView:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSIndexPath GetIndexPath (string identifier, UIView view)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="identifier">To be added.</param><param name="view">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static NSIndexPath _GetIndexPath (IUIDataSourceModelAssociation This, string identifier, UIView view)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			if (identifier is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (identifier));
			var view__handle__ = view!.GetNonNullHandle (nameof (view));
			var nsidentifier = CFString.CreateNative (identifier);
			NSIndexPath? ret;
			ret =  Runtime.GetNSObject<NSIndexPath> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("indexPathForElementWithModelIdentifier:inView:"), nsidentifier, view__handle__), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (view);
			CFString.ReleaseNative (nsidentifier);
			return ret!;
		}
		[DynamicDependencyAttribute ("GetIndexPath(System.String,UIKit.UIView)")]
		[DynamicDependencyAttribute ("GetModelIdentifier(Foundation.NSIndexPath,UIKit.UIView)")]
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.Interfaces | DynamicallyAccessedMemberTypes.PublicConstructors, typeof (UIDataSourceModelAssociationWrapper))]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static IUIDataSourceModelAssociation ()
		{
			GC.KeepAlive (null);
		}
	}
	#pragma warning restore CS1573
	internal unsafe sealed class UIDataSourceModelAssociationWrapper : BaseWrapper, IUIDataSourceModelAssociation {
		public UIDataSourceModelAssociationWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.PublicConstructors, typeof (UIDataSourceModelAssociationWrapper))]
		static UIDataSourceModelAssociationWrapper ()
		{
			GC.KeepAlive (null);
		}
		/// <param name="idx">To be added.</param><param name="view">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("modelIdentifierForElementAtIndexPath:inView:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public string GetModelIdentifier (NSIndexPath idx, UIView view)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var idx__handle__ = idx!.GetNonNullHandle (nameof (idx));
			var view__handle__ = view!.GetNonNullHandle (nameof (view));
			string? ret;
			ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("modelIdentifierForElementAtIndexPath:inView:"), idx__handle__, view__handle__), false)!;
			GC.KeepAlive (idx);
			GC.KeepAlive (view);
			return ret!;
		}
		/// <param name="identifier">To be added.</param><param name="view">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("indexPathForElementWithModelIdentifier:inView:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public NSIndexPath GetIndexPath (string identifier, UIView view)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			if (identifier is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (identifier));
			var view__handle__ = view!.GetNonNullHandle (nameof (view));
			var nsidentifier = CFString.CreateNative (identifier);
			NSIndexPath? ret;
			ret =  Runtime.GetNSObject<NSIndexPath> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("indexPathForElementWithModelIdentifier:inView:"), nsidentifier, view__handle__), false)!;
			GC.KeepAlive (view);
			CFString.ReleaseNative (nsidentifier);
			return ret!;
		}
	}
}
