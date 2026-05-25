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
	/// <summary>This interface represents the Objective-C protocol <c>UITraitDefinition</c>.</summary>
	/// <remarks>
	///   <para>A class that implements this interface (and subclasses <see cref="NSObject" />) will be exported to Objective-C as implementing the Objective-C protocol this interface represents.</para>
	///   <para>A class may also implement members from this interface to implement members from the protocol.</para>
	/// </remarks>
	[SupportedOSPlatform ("tvos17.0")]
	[SupportedOSPlatform ("ios17.0")]
	[SupportedOSPlatform ("maccatalyst17.0")]
	[Protocol (Name = "UITraitDefinition", WrapperType = typeof (UITraitDefinitionWrapper))]
	[ProtocolMember (IsRequired = false, IsProperty = true, IsStatic = true, Name = "Identifier", Selector = "identifier", PropertyType = typeof (string), GetterSelector = "identifier", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = false, IsProperty = true, IsStatic = true, Name = "Name", Selector = "name", PropertyType = typeof (string), GetterSelector = "name", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = false, IsProperty = true, IsStatic = true, Name = "AffectsColorAppearance", Selector = "affectsColorAppearance", PropertyType = typeof (bool), GetterSelector = "affectsColorAppearance", ArgumentSemantic = ArgumentSemantic.None)]
	public partial interface IUITraitDefinition : INativeObject, IDisposable
	{
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.Interfaces | DynamicallyAccessedMemberTypes.PublicConstructors, typeof (UITraitDefinitionWrapper))]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static IUITraitDefinition ()
		{
			GC.KeepAlive (null);
		}
		[global::Foundation.OptionalMember]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static string GetIdentifier<T> () where T: NSObject, IUITraitDefinition
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var class_ptr = Class.GetHandle (typeof (T));
			string ret;
			ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (class_ptr, Selector.GetHandle ("identifier")), false)!;
			return ret;
		}
		[global::Foundation.OptionalMember]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static string GetName<T> () where T: NSObject, IUITraitDefinition
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var class_ptr = Class.GetHandle (typeof (T));
			string ret;
			ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (class_ptr, Selector.GetHandle ("name")), false)!;
			return ret;
		}
		[global::Foundation.OptionalMember]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool GetAffectsColorAppearance<T> () where T: NSObject, IUITraitDefinition
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var class_ptr = Class.GetHandle (typeof (T));
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (class_ptr, Selector.GetHandle ("affectsColorAppearance"));
			return ret != 0;
		}
	}
	#pragma warning restore CS1573
	internal unsafe sealed class UITraitDefinitionWrapper : BaseWrapper, IUITraitDefinition {
		public UITraitDefinitionWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.PublicConstructors, typeof (UITraitDefinitionWrapper))]
		static UITraitDefinitionWrapper ()
		{
			GC.KeepAlive (null);
		}
	}
}
