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
namespace MediaExtension {
	#pragma warning disable CS1573
	/// <summary>This interface represents the Objective-C protocol <c>MEFormatReaderExtension</c>.</summary>
	/// <remarks>
	///   <para>A class that implements this interface (and subclasses <see cref="NSObject" />) will be exported to Objective-C as implementing the Objective-C protocol this interface represents.</para>
	///   <para>A class may also implement members from this interface to implement members from the protocol.</para>
	/// </remarks>
	[UnsupportedOSPlatform ("tvos")]
	[UnsupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos15.0")]
	[UnsupportedOSPlatform ("maccatalyst")]
	[Protocol (Name = "MEFormatReaderExtension", WrapperType = typeof (MEFormatReaderExtensionWrapper), BackwardsCompatibleCodeGeneration = false)]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "CreateFormatReader", Selector = "formatReaderWithByteSource:options:error:", ReturnType = typeof (MediaExtension.IMEFormatReader), ParameterType = new Type [] { typeof (MediaExtension.MEByteSource), typeof (MediaExtension.MEFormatReaderInstantiationOptions), typeof (NSError) }, ParameterByRef = new bool [] { false, false, true })]
	public partial interface IMEFormatReaderExtension : INativeObject, IDisposable
	{
		[global::Foundation.RequiredMember]
		[Export ("formatReaderWithByteSource:options:error:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual IMEFormatReader? CreateFormatReader (MEByteSource primaryByteSource, MEFormatReaderInstantiationOptions? options, out NSError? error)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal unsafe static IMEFormatReader? _CreateFormatReader (IMEFormatReaderExtension This, MEByteSource primaryByteSource, MEFormatReaderInstantiationOptions? options, out NSError? error)
		{
			var primaryByteSource__handle__ = primaryByteSource!.GetNonNullHandle (nameof (primaryByteSource));
			var options__handle__ = options.GetHandle ();
			NativeHandle errorValue = IntPtr.Zero;
			IMEFormatReader? ret;
			ret =  Runtime.GetINativeObject<IMEFormatReader> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_ref_NativeHandle (This.Handle, Selector.GetHandle ("formatReaderWithByteSource:options:error:"), primaryByteSource__handle__, options__handle__, &errorValue), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (primaryByteSource);
			GC.KeepAlive (options);
			error = Runtime.GetNSObject<NSError> (errorValue)!;
			return ret!;
		}
		[DynamicDependencyAttribute ("CreateFormatReader(MediaExtension.MEByteSource,MediaExtension.MEFormatReaderInstantiationOptions,Foundation.NSError@)")]
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.Interfaces | DynamicallyAccessedMemberTypes.PublicConstructors, typeof (MEFormatReaderExtensionWrapper))]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static IMEFormatReaderExtension ()
		{
			GC.KeepAlive (null);
		}
	}
	#pragma warning restore CS1573
	internal unsafe sealed class MEFormatReaderExtensionWrapper : BaseWrapper, IMEFormatReaderExtension {
		public MEFormatReaderExtensionWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.PublicConstructors, typeof (MEFormatReaderExtensionWrapper))]
		static MEFormatReaderExtensionWrapper ()
		{
			GC.KeepAlive (null);
		}
		[Export ("formatReaderWithByteSource:options:error:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe IMEFormatReader? CreateFormatReader (MEByteSource primaryByteSource, MEFormatReaderInstantiationOptions? options, out NSError? error)
		{
			var primaryByteSource__handle__ = primaryByteSource!.GetNonNullHandle (nameof (primaryByteSource));
			var options__handle__ = options.GetHandle ();
			NativeHandle errorValue = IntPtr.Zero;
			IMEFormatReader? ret;
			ret =  Runtime.GetINativeObject<IMEFormatReader> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_ref_NativeHandle (this.Handle, Selector.GetHandle ("formatReaderWithByteSource:options:error:"), primaryByteSource__handle__, options__handle__, &errorValue), false)!;
			GC.KeepAlive (primaryByteSource);
			GC.KeepAlive (options);
			error = Runtime.GetNSObject<NSError> (errorValue)!;
			return ret!;
		}
	}
}
