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
namespace GameplayKit {
	#pragma warning disable CS1573
	/// <summary>Interface for GameplayKit pseudo-random number generators.</summary>
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("tvos")]
	[Protocol (Name = "GKRandom", WrapperType = typeof (GKRandomWrapper))]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "GetNextInt", Selector = "nextInt", ReturnType = typeof (IntPtr))]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "GetNextInt", Selector = "nextIntWithUpperBound:", ReturnType = typeof (UIntPtr), ParameterType = new Type [] { typeof (UIntPtr) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "GetNextUniform", Selector = "nextUniform", ReturnType = typeof (float))]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "GetNextBool", Selector = "nextBool", ReturnType = typeof (bool))]
	public partial interface IGKRandom : INativeObject, IDisposable
	{
		/// <summary>Returns an integer within the bounds of the generator.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.RequiredMember]
		[Export ("nextInt")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual nint GetNextInt ()
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <summary>Returns an integer within the bounds of the generator.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static nint _GetNextInt (IGKRandom This)
		{
			nint ret;
			ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (This.Handle, Selector.GetHandle ("nextInt"));
			GC.KeepAlive (This);
			return ret;
		}
		/// <param name="upperBound">To be added.</param><summary>Returns a random integer that is less than <paramref name="upperBound" />.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.RequiredMember]
		[Export ("nextIntWithUpperBound:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual nuint GetNextInt (nuint upperBound)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="upperBound">To be added.</param><summary>Returns a random integer that is less than <paramref name="upperBound" />.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static nuint _GetNextInt (IGKRandom This, nuint upperBound)
		{
			nuint ret;
			ret = global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend_UIntPtr (This.Handle, Selector.GetHandle ("nextIntWithUpperBound:"), upperBound);
			GC.KeepAlive (This);
			return ret;
		}
		/// <summary>Returns a random floating-point value.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.RequiredMember]
		[Export ("nextUniform")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual float GetNextUniform ()
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <summary>Returns a random floating-point value.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static float _GetNextUniform (IGKRandom This)
		{
			float ret;
			ret = global::ObjCRuntime.Messaging.float_objc_msgSend (This.Handle, Selector.GetHandle ("nextUniform"));
			GC.KeepAlive (This);
			return ret;
		}
		/// <summary>Retrieves a <see langword="true" /> or <see langword="false" /> value.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.RequiredMember]
		[Export ("nextBool")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool GetNextBool ()
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <summary>Retrieves a <see langword="true" /> or <see langword="false" /> value.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static bool _GetNextBool (IGKRandom This)
		{
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (This.Handle, Selector.GetHandle ("nextBool"));
			GC.KeepAlive (This);
			return ret != 0;
		}
		[DynamicDependencyAttribute ("GetNextBool()")]
		[DynamicDependencyAttribute ("GetNextInt()")]
		[DynamicDependencyAttribute ("GetNextInt(System.UIntPtr)")]
		[DynamicDependencyAttribute ("GetNextUniform()")]
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.Interfaces | DynamicallyAccessedMemberTypes.PublicConstructors, typeof (GKRandomWrapper))]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static IGKRandom ()
		{
			GC.KeepAlive (null);
		}
	}
	#pragma warning restore CS1573
	internal unsafe sealed class GKRandomWrapper : BaseWrapper, IGKRandom {
		public GKRandomWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.PublicConstructors, typeof (GKRandomWrapper))]
		static GKRandomWrapper ()
		{
			GC.KeepAlive (null);
		}
		/// <summary>Returns an integer within the bounds of the generator.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("nextInt")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public nint GetNextInt ()
		{
			nint ret;
			ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("nextInt"));
			return ret;
		}
		/// <param name="upperBound">To be added.</param><summary>Returns a random integer that is less than <paramref name="upperBound" />.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("nextIntWithUpperBound:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public nuint GetNextInt (nuint upperBound)
		{
			nuint ret;
			ret = global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend_UIntPtr (this.Handle, Selector.GetHandle ("nextIntWithUpperBound:"), upperBound);
			return ret;
		}
		/// <summary>Returns a random floating-point value.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("nextUniform")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public float GetNextUniform ()
		{
			float ret;
			ret = global::ObjCRuntime.Messaging.float_objc_msgSend (this.Handle, Selector.GetHandle ("nextUniform"));
			return ret;
		}
		/// <summary>Retrieves a <see langword="true" /> or <see langword="false" /> value.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("nextBool")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public bool GetNextBool ()
		{
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("nextBool"));
			return ret != 0;
		}
	}
}
