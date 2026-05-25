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
namespace ModelIO {
	#pragma warning disable CS1573
	/// <summary>This interface represents the Objective-C protocol <c>MDLTransformOp</c>.</summary>
	/// <remarks>
	///   <para>A class that implements this interface (and subclasses <see cref="NSObject" />) will be exported to Objective-C as implementing the Objective-C protocol this interface represents.</para>
	///   <para>A class may also implement members from this interface to implement members from the protocol.</para>
	/// </remarks>
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("tvos")]
	[Protocol (Name = "MDLTransformOp", WrapperType = typeof (MDLTransformOpWrapper))]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "GetNMatrix4", Selector = "float4x4AtTime:", ReturnType = typeof (NMatrix4), ParameterType = new Type [] { typeof (double) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "GetNMatrix4d", Selector = "double4x4AtTime:", ReturnType = typeof (NMatrix4d), ParameterType = new Type [] { typeof (double) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "Name", Selector = "name", PropertyType = typeof (string), GetterSelector = "name", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "IsInverseOp", Selector = "IsInverseOp", PropertyType = typeof (bool), GetterSelector = "IsInverseOp", ArgumentSemantic = ArgumentSemantic.None)]
	public partial interface IMDLTransformOp : INativeObject, IDisposable
	{
		/// <param name="atTime">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.RequiredMember]
		[Export ("float4x4AtTime:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NMatrix4 GetNMatrix4 (double atTime)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="atTime">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static NMatrix4 _GetNMatrix4 (IMDLTransformOp This, double atTime)
		{
			NMatrix4 ret;
			if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
				ret = global::ObjCRuntime.Messaging.xamarin_simd__NMatrix4_objc_msgSend_Double (This.Handle, Selector.GetHandle ("float4x4AtTime:"), atTime);
				GC.KeepAlive (This);
			} else {
				ret = global::ObjCRuntime.Messaging.xamarin_simd__NMatrix4_objc_msgSend_stret_Double (This.Handle, Selector.GetHandle ("float4x4AtTime:"), atTime);
				GC.KeepAlive (This);
			}
			return ret!;
		}
		/// <param name="atTime">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.RequiredMember]
		[Export ("double4x4AtTime:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NMatrix4d GetNMatrix4d (double atTime)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="atTime">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static NMatrix4d _GetNMatrix4d (IMDLTransformOp This, double atTime)
		{
			NMatrix4d ret;
			if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
				ret = global::ObjCRuntime.Messaging.xamarin_simd__NMatrix4d_objc_msgSend_Double (This.Handle, Selector.GetHandle ("double4x4AtTime:"), atTime);
				GC.KeepAlive (This);
			} else {
				ret = global::ObjCRuntime.Messaging.xamarin_simd__NMatrix4d_objc_msgSend_stret_Double (This.Handle, Selector.GetHandle ("double4x4AtTime:"), atTime);
				GC.KeepAlive (This);
			}
			return ret!;
		}
		[DynamicDependencyAttribute ("GetNMatrix4(System.Double)")]
		[DynamicDependencyAttribute ("GetNMatrix4d(System.Double)")]
		[DynamicDependencyAttribute ("IsInverseOp")]
		[DynamicDependencyAttribute ("Name")]
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.Interfaces | DynamicallyAccessedMemberTypes.PublicConstructors, typeof (MDLTransformOpWrapper))]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static IMDLTransformOp ()
		{
			GC.KeepAlive (null);
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual string Name {
			[Export ("name")]
			get {
				return _GetName (this);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static string _GetName (IMDLTransformOp This)
		{
			string ret;
			ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("name")), false)!;
			GC.KeepAlive (This);
			return ret;
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual bool IsInverseOp {
			[Export ("IsInverseOp")]
			get {
				return _GetIsInverseOp (this);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static bool _GetIsInverseOp (IMDLTransformOp This)
		{
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (This.Handle, Selector.GetHandle ("IsInverseOp"));
			GC.KeepAlive (This);
			return ret != 0;
		}
	}
	#pragma warning restore CS1573
	internal unsafe sealed class MDLTransformOpWrapper : BaseWrapper, IMDLTransformOp {
		public MDLTransformOpWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.PublicConstructors, typeof (MDLTransformOpWrapper))]
		static MDLTransformOpWrapper ()
		{
			GC.KeepAlive (null);
		}
		/// <param name="atTime">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("float4x4AtTime:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public NMatrix4 GetNMatrix4 (double atTime)
		{
			NMatrix4 ret;
			if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
				ret = global::ObjCRuntime.Messaging.xamarin_simd__NMatrix4_objc_msgSend_Double (this.Handle, Selector.GetHandle ("float4x4AtTime:"), atTime);
			} else {
				ret = global::ObjCRuntime.Messaging.xamarin_simd__NMatrix4_objc_msgSend_stret_Double (this.Handle, Selector.GetHandle ("float4x4AtTime:"), atTime);
			}
			return ret!;
		}
		/// <param name="atTime">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("double4x4AtTime:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public NMatrix4d GetNMatrix4d (double atTime)
		{
			NMatrix4d ret;
			if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
				ret = global::ObjCRuntime.Messaging.xamarin_simd__NMatrix4d_objc_msgSend_Double (this.Handle, Selector.GetHandle ("double4x4AtTime:"), atTime);
			} else {
				ret = global::ObjCRuntime.Messaging.xamarin_simd__NMatrix4d_objc_msgSend_stret_Double (this.Handle, Selector.GetHandle ("double4x4AtTime:"), atTime);
			}
			return ret!;
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public string Name {
			[Export ("name")]
			get {
				string ret;
				ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("name")), false)!;
				return ret;
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public bool IsInverseOp {
			[Export ("IsInverseOp")]
			get {
				byte ret;
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("IsInverseOp"));
				return ret != 0;
			}
		}
	}
}
