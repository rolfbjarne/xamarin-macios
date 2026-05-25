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
namespace Accessibility {
	#pragma warning disable CS1573
	/// <summary>This interface represents the Objective-C protocol <c>AXMathExpressionProvider</c>.</summary>
	/// <remarks>
	///   <para>A class that implements this interface (and subclasses <see cref="NSObject" />) will be exported to Objective-C as implementing the Objective-C protocol this interface represents.</para>
	///   <para>A class may also implement members from this interface to implement members from the protocol.</para>
	/// </remarks>
	[SupportedOSPlatform ("tvos18.2")]
	[SupportedOSPlatform ("macos15.2")]
	[SupportedOSPlatform ("ios18.2")]
	[SupportedOSPlatform ("maccatalyst18.2")]
	[Protocol (Name = "AXMathExpressionProvider", WrapperType = typeof (AXMathExpressionProviderWrapper), BackwardsCompatibleCodeGeneration = false)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "AccessibilityMathExpression", Selector = "accessibilityMathExpression", PropertyType = typeof (Accessibility.AXMathExpression), GetterSelector = "accessibilityMathExpression", ArgumentSemantic = ArgumentSemantic.None)]
	public partial interface IAXMathExpressionProvider : INativeObject, IDisposable
	{
		[DynamicDependencyAttribute ("AccessibilityMathExpression")]
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.Interfaces | DynamicallyAccessedMemberTypes.PublicConstructors, typeof (AXMathExpressionProviderWrapper))]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static IAXMathExpressionProvider ()
		{
			GC.KeepAlive (null);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual AXMathExpression? AccessibilityMathExpression {
			[Export ("accessibilityMathExpression")]
			get {
				return _GetAccessibilityMathExpression (this);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static AXMathExpression _GetAccessibilityMathExpression (IAXMathExpressionProvider This)
		{
			AXMathExpression ret;
			ret =  Runtime.GetNSObject<AXMathExpression> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("accessibilityMathExpression")), false)!;
			GC.KeepAlive (This);
			return ret;
		}
	}
	#pragma warning restore CS1573
	internal unsafe sealed class AXMathExpressionProviderWrapper : BaseWrapper, IAXMathExpressionProvider {
		public AXMathExpressionProviderWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.PublicConstructors, typeof (AXMathExpressionProviderWrapper))]
		static AXMathExpressionProviderWrapper ()
		{
			GC.KeepAlive (null);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public AXMathExpression? AccessibilityMathExpression {
			[Export ("accessibilityMathExpression")]
			get {
				AXMathExpression ret;
				ret =  Runtime.GetNSObject<AXMathExpression> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("accessibilityMathExpression")), false)!;
				return ret;
			}
		}
	}
}
