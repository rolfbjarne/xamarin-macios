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
	/// <summary>This interface represents the Objective-C protocol <c>UIContentConfiguration</c>.</summary>
	/// <remarks>
	///   <para>A class that implements this interface (and subclasses <see cref="NSObject" />) will be exported to Objective-C as implementing the Objective-C protocol this interface represents.</para>
	///   <para>A class may also implement members from this interface to implement members from the protocol.</para>
	/// </remarks>
	[SupportedOSPlatform ("tvos14.0")]
	[SupportedOSPlatform ("ios14.0")]
	[SupportedOSPlatform ("maccatalyst")]
	[UnsupportedOSPlatform ("macos")]
	[Protocol (Name = "UIContentConfiguration", WrapperType = typeof (UIContentConfigurationWrapper))]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "MakeContentView", Selector = "makeContentView", ReturnType = typeof (IUIContentView))]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "GetUpdatedConfiguration", Selector = "updatedConfigurationForState:", ReturnType = typeof (IUIContentConfiguration), ParameterType = new Type [] { typeof (IUIConfigurationState) }, ParameterByRef = new bool [] { false })]
	public partial interface IUIContentConfiguration : INativeObject, IDisposable, 
		Foundation.INSCopying
	{
		[global::Foundation.RequiredMember]
		[Export ("makeContentView")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual IUIContentView MakeContentView ()
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static IUIContentView _MakeContentView (IUIContentConfiguration This)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			IUIContentView ret;
			ret =  Runtime.GetINativeObject<IUIContentView> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("makeContentView")), false)!;
			GC.KeepAlive (This);
			return ret;
		}
		[global::Foundation.RequiredMember]
		[Export ("updatedConfigurationForState:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual IUIContentConfiguration GetUpdatedConfiguration (IUIConfigurationState state)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static IUIContentConfiguration _GetUpdatedConfiguration (IUIContentConfiguration This, IUIConfigurationState state)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var state__handle__ = state!.GetNonNullHandle (nameof (state));
			IUIContentConfiguration? ret;
			ret =  Runtime.GetINativeObject<IUIContentConfiguration> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("updatedConfigurationForState:"), state__handle__), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (state);
			return ret!;
		}
		[DynamicDependencyAttribute ("GetUpdatedConfiguration(UIKit.IUIConfigurationState)")]
		[DynamicDependencyAttribute ("MakeContentView()")]
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.Interfaces | DynamicallyAccessedMemberTypes.PublicConstructors, typeof (UIContentConfigurationWrapper))]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static IUIContentConfiguration ()
		{
			GC.KeepAlive (null);
		}
	}
	#pragma warning restore CS1573
	internal unsafe sealed class UIContentConfigurationWrapper : BaseWrapper, IUIContentConfiguration {
		public UIContentConfigurationWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.PublicConstructors, typeof (UIContentConfigurationWrapper))]
		static UIContentConfigurationWrapper ()
		{
			GC.KeepAlive (null);
		}
		[Export ("makeContentView")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public IUIContentView MakeContentView ()
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			IUIContentView ret;
			ret =  Runtime.GetINativeObject<IUIContentView> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("makeContentView")), false)!;
			return ret;
		}
		[Export ("updatedConfigurationForState:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public IUIContentConfiguration GetUpdatedConfiguration (IUIConfigurationState state)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var state__handle__ = state!.GetNonNullHandle (nameof (state));
			IUIContentConfiguration? ret;
			ret =  Runtime.GetINativeObject<IUIContentConfiguration> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("updatedConfigurationForState:"), state__handle__), false)!;
			GC.KeepAlive (state);
			return ret!;
		}
		/// <param name="zone">Developers should pass <see langword="null" />.  Memory zones are no longer used.</param><summary>Performs a copy of the underlying Objective-C object.</summary><returns>The newly-allocated object.</returns><remarks><para>This method performs a "shallow copy" of <see langword="this" />. If this object contains references to external objects, the new object will contain references to the same object.</para></remarks>
		[Export ("copyWithZone:")]
		[return: ReleaseAttribute ()]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public NSObject Copy (NSZone? zone)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var zone__handle__ = zone.GetHandle ();
			NSObject? ret;
			ret = Runtime.GetNSObject (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("copyWithZone:"), zone__handle__), true)!;
			GC.KeepAlive (zone);
			return ret!;
		}
	}
}
