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
namespace AppKit {
	#pragma warning disable CS1573
	/// <summary>This interface represents the Objective-C protocol <c>NSCloudSharingValidation</c>.</summary>
	/// <remarks>
	///   <para>A class that implements this interface (and subclasses <see cref="NSObject" />) will be exported to Objective-C as implementing the Objective-C protocol this interface represents.</para>
	///   <para>A class may also implement members from this interface to implement members from the protocol.</para>
	/// </remarks>
	[UnsupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("macos")]
	[Protocol (Name = "NSCloudSharingValidation", WrapperType = typeof (NSCloudSharingValidationWrapper))]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "GetCloudShare", Selector = "cloudShareForUserInterfaceItem:", ReturnType = typeof (CKShare), ParameterType = new Type [] { typeof (INSValidatedUserInterfaceItem) }, ParameterByRef = new bool [] { false })]
	public partial interface INSCloudSharingValidation : INativeObject, IDisposable
	{
		/// <param name="item">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.RequiredMember]
		[Export ("cloudShareForUserInterfaceItem:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual global::CloudKit.CKShare? GetCloudShare (INSValidatedUserInterfaceItem item)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="item">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static global::CloudKit.CKShare? _GetCloudShare (INSCloudSharingValidation This, INSValidatedUserInterfaceItem item)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var item__handle__ = item!.GetNonNullHandle (nameof (item));
			global::CloudKit.CKShare? ret;
			ret =  Runtime.GetNSObject<global::CloudKit.CKShare> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("cloudShareForUserInterfaceItem:"), item__handle__), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (item);
			return ret!;
		}
		[DynamicDependencyAttribute ("GetCloudShare(AppKit.INSValidatedUserInterfaceItem)")]
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.Interfaces | DynamicallyAccessedMemberTypes.PublicConstructors, typeof (NSCloudSharingValidationWrapper))]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static INSCloudSharingValidation ()
		{
			GC.KeepAlive (null);
		}
	}
	#pragma warning restore CS1573
	internal unsafe sealed class NSCloudSharingValidationWrapper : BaseWrapper, INSCloudSharingValidation {
		public NSCloudSharingValidationWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.PublicConstructors, typeof (NSCloudSharingValidationWrapper))]
		static NSCloudSharingValidationWrapper ()
		{
			GC.KeepAlive (null);
		}
		/// <param name="item">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("cloudShareForUserInterfaceItem:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public global::CloudKit.CKShare? GetCloudShare (INSValidatedUserInterfaceItem item)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var item__handle__ = item!.GetNonNullHandle (nameof (item));
			global::CloudKit.CKShare? ret;
			ret =  Runtime.GetNSObject<global::CloudKit.CKShare> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("cloudShareForUserInterfaceItem:"), item__handle__), false)!;
			GC.KeepAlive (item);
			return ret!;
		}
	}
}
