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
namespace ModelIO {
	#pragma warning disable CS1573
	/// <summary>This interface represents the Objective-C protocol <c>MDLTransformComponent</c>.</summary>
	/// <remarks>
	///   <para>A class that implements this interface (and subclasses <see cref="NSObject" />) will be exported to Objective-C as implementing the Objective-C protocol this interface represents.</para>
	///   <para>A class may also implement members from this interface to implement members from the protocol.</para>
	/// </remarks>
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("tvos")]
	[Protocol (Name = "MDLTransformComponent", WrapperType = typeof (MDLTransformComponentWrapper))]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "SetLocalTransform", Selector = "setLocalTransform:forTime:", ParameterType = new Type [] { typeof (NMatrix4), typeof (double) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "SetLocalTransform", Selector = "setLocalTransform:", ParameterType = new Type [] { typeof (NMatrix4) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "GetLocalTransform", Selector = "localTransformAtTime:", ReturnType = typeof (NMatrix4), ParameterType = new Type [] { typeof (double) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = true, Name = "CreateGlobalTransform", Selector = "globalTransformWithObject:atTime:", ReturnType = typeof (NMatrix4), ParameterType = new Type [] { typeof (MDLObject), typeof (double) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "Matrix", Selector = "matrix", PropertyType = typeof (NMatrix4), GetterSelector = "matrix", SetterSelector = "setMatrix:", ArgumentSemantic = ArgumentSemantic.Assign)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "ResetsTransform", Selector = "resetsTransform", PropertyType = typeof (bool), GetterSelector = "resetsTransform", SetterSelector = "setResetsTransform:", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "MinimumTime", Selector = "minimumTime", PropertyType = typeof (double), GetterSelector = "minimumTime", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "MaximumTime", Selector = "maximumTime", PropertyType = typeof (double), GetterSelector = "maximumTime", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "KeyTimes", Selector = "keyTimes", PropertyType = typeof (NSNumber[]), GetterSelector = "keyTimes", ArgumentSemantic = ArgumentSemantic.Copy)]
	public partial interface IMDLTransformComponent : INativeObject, IDisposable, 
		ModelIO.IMDLComponent
	{
		/// <summary>Causes this transform to represent the specified static transform.</summary>
		[global::Foundation.OptionalMember]
		[Export ("setLocalTransform:forTime:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetLocalTransform (NMatrix4 transform, double time)
		{
			_SetLocalTransform (this, transform, time);
		}
		/// <summary>Causes this transform to represent the specified static transform.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SetLocalTransform (IMDLTransformComponent This, NMatrix4 transform, double time)
		{
			global::ObjCRuntime.Messaging.xamarin_simd__void_objc_msgSend_NMatrix4_Double (This.Handle, Selector.GetHandle ("setLocalTransform:forTime:"), transform, time);
			GC.KeepAlive (This);
		}
		/// <summary>Causes this transform to represent the specified static transform.</summary>
		[global::Foundation.OptionalMember]
		[Export ("setLocalTransform:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetLocalTransform (NMatrix4 transform)
		{
			_SetLocalTransform (this, transform);
		}
		/// <summary>Causes this transform to represent the specified static transform.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SetLocalTransform (IMDLTransformComponent This, NMatrix4 transform)
		{
			global::ObjCRuntime.Messaging.xamarin_simd__void_objc_msgSend_NMatrix4 (This.Handle, Selector.GetHandle ("setLocalTransform:"), transform);
			GC.KeepAlive (This);
		}
		/// <param name="atTime">The time for which to retrieve the local transform.</param><summary>Gets the local transform at the specified time.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("localTransformAtTime:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NMatrix4 GetLocalTransform (double atTime)
		{
			return _GetLocalTransform (this, atTime);
		}
		/// <param name="atTime">The time for which to retrieve the local transform.</param><summary>Gets the local transform at the specified time.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static NMatrix4 _GetLocalTransform (IMDLTransformComponent This, double atTime)
		{
			NMatrix4 ret;
			if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
				ret = global::ObjCRuntime.Messaging.xamarin_simd__NMatrix4_objc_msgSend_Double (This.Handle, Selector.GetHandle ("localTransformAtTime:"), atTime);
				GC.KeepAlive (This);
			} else {
				ret = global::ObjCRuntime.Messaging.xamarin_simd__NMatrix4_objc_msgSend_stret_Double (This.Handle, Selector.GetHandle ("localTransformAtTime:"), atTime);
				GC.KeepAlive (This);
			}
			return ret!;
		}
		/// <summary>Creates and returns a global transform for the specified object at the specified time.</summary><param name="obj">The object that represents the spatial transform.</param><param name="atTime">The time at which to apply the transform.</param>
		[global::Foundation.OptionalMember]
		[Export ("globalTransformWithObject:atTime:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NMatrix4 CreateGlobalTransform<T> (MDLObject obj, double atTime) where T: NSObject, IMDLTransformComponent
		{
			var obj__handle__ = obj!.GetNonNullHandle (nameof (obj));
			var class_ptr = Class.GetHandle (typeof (T));
			NMatrix4 ret;
			if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
				ret = global::ObjCRuntime.Messaging.xamarin_simd__NMatrix4_objc_msgSend_NativeHandle_Double (class_ptr, Selector.GetHandle ("globalTransformWithObject:atTime:"), obj__handle__, atTime);
			} else {
				ret = global::ObjCRuntime.Messaging.xamarin_simd__NMatrix4_objc_msgSend_stret_NativeHandle_Double (class_ptr, Selector.GetHandle ("globalTransformWithObject:atTime:"), obj__handle__, atTime);
			}
			GC.KeepAlive (obj);
			return ret!;
		}
		[DynamicDependencyAttribute ("GetLocalTransform(System.Double)")]
		[DynamicDependencyAttribute ("KeyTimes")]
		[DynamicDependencyAttribute ("Matrix")]
		[DynamicDependencyAttribute ("MaximumTime")]
		[DynamicDependencyAttribute ("MinimumTime")]
		[DynamicDependencyAttribute ("ResetsTransform")]
		[DynamicDependencyAttribute ("SetLocalTransform(CoreGraphics.NMatrix4,System.Double)")]
		[DynamicDependencyAttribute ("SetLocalTransform(CoreGraphics.NMatrix4)")]
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.Interfaces | DynamicallyAccessedMemberTypes.PublicConstructors, typeof (MDLTransformComponentWrapper))]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static IMDLTransformComponent ()
		{
			GC.KeepAlive (null);
		}
		/// <summary>Gets or sets the matrix of the transform at the earliest specified time.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual NMatrix4 Matrix {
			[Export ("matrix", ArgumentSemantic.Assign)]
			get {
				return _GetMatrix (this);
			}
			[Export ("setMatrix:", ArgumentSemantic.Assign)]
			set {
				_SetMatrix (this, value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static NMatrix4 _GetMatrix (IMDLTransformComponent This)
		{
			NMatrix4 ret;
			if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
				ret = global::ObjCRuntime.Messaging.xamarin_simd__NMatrix4_objc_msgSend (This.Handle, Selector.GetHandle ("matrix"));
				GC.KeepAlive (This);
			} else {
				ret = global::ObjCRuntime.Messaging.xamarin_simd__NMatrix4_objc_msgSend_stret (This.Handle, Selector.GetHandle ("matrix"));
				GC.KeepAlive (This);
			}
			return ret!;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SetMatrix (IMDLTransformComponent This, NMatrix4 value)
		{
			global::ObjCRuntime.Messaging.xamarin_simd__void_objc_msgSend_NMatrix4 (This.Handle, Selector.GetHandle ("setMatrix:"), value);
			GC.KeepAlive (This);
		}
		/// <summary>Inserts the specified transform at the specified time.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[global::Foundation.RequiredMember]
		public virtual bool ResetsTransform {
			[Export ("resetsTransform")]
			get {
				return _GetResetsTransform (this);
			}
			[Export ("setResetsTransform:")]
			set {
				_SetResetsTransform (this, value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static bool _GetResetsTransform (IMDLTransformComponent This)
		{
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (This.Handle, Selector.GetHandle ("resetsTransform"));
			GC.KeepAlive (This);
			return ret != 0;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SetResetsTransform (IMDLTransformComponent This, bool value)
		{
			global::ObjCRuntime.Messaging.void_objc_msgSend_bool (This.Handle, Selector.GetHandle ("setResetsTransform:"), value ? (byte) 1 : (byte) 0);
			GC.KeepAlive (This);
		}
		/// <summary>Gets the first specified time in the transformation.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual double MinimumTime {
			[Export ("minimumTime")]
			get {
				return _GetMinimumTime (this);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static double _GetMinimumTime (IMDLTransformComponent This)
		{
			double ret;
			ret = global::ObjCRuntime.Messaging.Double_objc_msgSend (This.Handle, Selector.GetHandle ("minimumTime"));
			GC.KeepAlive (This);
			return ret;
		}
		/// <summary>Gets the last specified time in the transformation.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual double MaximumTime {
			[Export ("maximumTime")]
			get {
				return _GetMaximumTime (this);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static double _GetMaximumTime (IMDLTransformComponent This)
		{
			double ret;
			ret = global::ObjCRuntime.Messaging.Double_objc_msgSend (This.Handle, Selector.GetHandle ("maximumTime"));
			GC.KeepAlive (This);
			return ret;
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[global::Foundation.RequiredMember]
		public virtual NSNumber[] KeyTimes {
			[Export ("keyTimes", ArgumentSemantic.Copy)]
			get {
				return _GetKeyTimes (this);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static NSNumber[] _GetKeyTimes (IMDLTransformComponent This)
		{
			NSNumber[] ret;
			ret = CFArray.ArrayFromHandle<NSNumber>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("keyTimes")), false)!;
			GC.KeepAlive (This);
			return ret;
		}
	}
	#pragma warning restore CS1573
	#pragma warning disable CS1573
	/// <summary>Extension methods to the <see cref="IMDLTransformComponent" /> interface to support all the methods from the MDLTransformComponent protocol.</summary>
	/// <remarks>
	///   <para>The extension methods for <see cref="IMDLTransformComponent" /> interface allow developers to treat instances of the interface as having all the optional methods of the original MDLTransformComponent protocol. Since the interface only contains the required members, these extension methods allow developers to call the optional members of the protocol.</para>
	/// </remarks>
	public unsafe static partial class MDLTransformComponent_Extensions {
		/// <summary>Causes this transform to represent the specified static transform.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void SetLocalTransform (this IMDLTransformComponent This, NMatrix4 transform, double time)
		{
			global::ObjCRuntime.Messaging.xamarin_simd__void_objc_msgSend_NMatrix4_Double (This.Handle, Selector.GetHandle ("setLocalTransform:forTime:"), transform, time);
			GC.KeepAlive (This);
		}
		/// <summary>Causes this transform to represent the specified static transform.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void SetLocalTransform (this IMDLTransformComponent This, NMatrix4 transform)
		{
			global::ObjCRuntime.Messaging.xamarin_simd__void_objc_msgSend_NMatrix4 (This.Handle, Selector.GetHandle ("setLocalTransform:"), transform);
			GC.KeepAlive (This);
		}
		/// <param name="atTime">The time for which to retrieve the local transform.</param><summary>Gets the local transform at the specified time.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NMatrix4 GetLocalTransform (this IMDLTransformComponent This, double atTime)
		{
			NMatrix4 ret;
			if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
				ret = global::ObjCRuntime.Messaging.xamarin_simd__NMatrix4_objc_msgSend_Double (This.Handle, Selector.GetHandle ("localTransformAtTime:"), atTime);
				GC.KeepAlive (This);
			} else {
				ret = global::ObjCRuntime.Messaging.xamarin_simd__NMatrix4_objc_msgSend_stret_Double (This.Handle, Selector.GetHandle ("localTransformAtTime:"), atTime);
				GC.KeepAlive (This);
			}
			return ret!;
		}
	}
	#pragma warning restore CS1573
	internal unsafe sealed class MDLTransformComponentWrapper : BaseWrapper, IMDLTransformComponent {
		public MDLTransformComponentWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.PublicConstructors, typeof (MDLTransformComponentWrapper))]
		static MDLTransformComponentWrapper ()
		{
			GC.KeepAlive (null);
		}
		/// <summary>Gets or sets the matrix of the transform at the earliest specified time.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public NMatrix4 Matrix {
			[Export ("matrix", ArgumentSemantic.Assign)]
			get {
				NMatrix4 ret;
				if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
					ret = global::ObjCRuntime.Messaging.xamarin_simd__NMatrix4_objc_msgSend (this.Handle, Selector.GetHandle ("matrix"));
				} else {
					ret = global::ObjCRuntime.Messaging.xamarin_simd__NMatrix4_objc_msgSend_stret (this.Handle, Selector.GetHandle ("matrix"));
				}
				return ret!;
			}
			[Export ("setMatrix:", ArgumentSemantic.Assign)]
			set {
				global::ObjCRuntime.Messaging.xamarin_simd__void_objc_msgSend_NMatrix4 (this.Handle, Selector.GetHandle ("setMatrix:"), value);
			}
		}
		/// <summary>Inserts the specified transform at the specified time.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public bool ResetsTransform {
			[Export ("resetsTransform")]
			get {
				byte ret;
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("resetsTransform"));
				return ret != 0;
			}
			[Export ("setResetsTransform:")]
			set {
				global::ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("setResetsTransform:"), value ? (byte) 1 : (byte) 0);
			}
		}
		/// <summary>Gets the first specified time in the transformation.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public double MinimumTime {
			[Export ("minimumTime")]
			get {
				double ret;
				ret = global::ObjCRuntime.Messaging.Double_objc_msgSend (this.Handle, Selector.GetHandle ("minimumTime"));
				return ret;
			}
		}
		/// <summary>Gets the last specified time in the transformation.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public double MaximumTime {
			[Export ("maximumTime")]
			get {
				double ret;
				ret = global::ObjCRuntime.Messaging.Double_objc_msgSend (this.Handle, Selector.GetHandle ("maximumTime"));
				return ret;
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public NSNumber[] KeyTimes {
			[Export ("keyTimes", ArgumentSemantic.Copy)]
			get {
				NSNumber[] ret;
				ret = CFArray.ArrayFromHandle<NSNumber>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("keyTimes")), false)!;
				return ret;
			}
		}
	}
}
