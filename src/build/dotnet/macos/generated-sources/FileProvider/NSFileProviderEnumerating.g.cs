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
namespace FileProvider {
	#pragma warning disable CS1573
	/// <summary>This interface represents the Objective-C protocol <c>NSFileProviderEnumerating</c>.</summary>
	/// <remarks>
	///   <para>A class that implements this interface (and subclasses <see cref="NSObject" />) will be exported to Objective-C as implementing the Objective-C protocol this interface represents.</para>
	///   <para>A class may also implement members from this interface to implement members from the protocol.</para>
	/// </remarks>
	[UnsupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios16.0")]
	[SupportedOSPlatform ("macos")]
	[Protocol (Name = "NSFileProviderEnumerating", WrapperType = typeof (NSFileProviderEnumeratingWrapper))]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "GetEnumerator", Selector = "enumeratorForContainerItemIdentifier:request:error:", ReturnType = typeof (INSFileProviderEnumerator), ParameterType = new Type [] { typeof (string), typeof (NSFileProviderRequest), typeof (NSError) }, ParameterByRef = new bool [] { false, false, true })]
	public partial interface INSFileProviderEnumerating : INativeObject, IDisposable
	{
		[global::Foundation.RequiredMember]
		[Export ("enumeratorForContainerItemIdentifier:request:error:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual INSFileProviderEnumerator? GetEnumerator (string containerItemIdentifier, NSFileProviderRequest request, out NSError? error)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal unsafe static INSFileProviderEnumerator? _GetEnumerator (INSFileProviderEnumerating This, string containerItemIdentifier, NSFileProviderRequest request, out NSError? error)
		{
			if (containerItemIdentifier is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (containerItemIdentifier));
			var request__handle__ = request!.GetNonNullHandle (nameof (request));
			NativeHandle errorValue = IntPtr.Zero;
			var nscontainerItemIdentifier = CFString.CreateNative (containerItemIdentifier);
			INSFileProviderEnumerator? ret;
			ret =  Runtime.GetINativeObject<INSFileProviderEnumerator> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_ref_NativeHandle (This.Handle, Selector.GetHandle ("enumeratorForContainerItemIdentifier:request:error:"), nscontainerItemIdentifier, request__handle__, &errorValue), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (request);
			CFString.ReleaseNative (nscontainerItemIdentifier);
			error = Runtime.GetNSObject<NSError> (errorValue)!;
			return ret!;
		}
		[DynamicDependencyAttribute ("GetEnumerator(System.String,FileProvider.NSFileProviderRequest,Foundation.NSError@)")]
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.Interfaces | DynamicallyAccessedMemberTypes.PublicConstructors, typeof (NSFileProviderEnumeratingWrapper))]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static INSFileProviderEnumerating ()
		{
			GC.KeepAlive (null);
		}
	}
	#pragma warning restore CS1573
	internal unsafe sealed class NSFileProviderEnumeratingWrapper : BaseWrapper, INSFileProviderEnumerating {
		public NSFileProviderEnumeratingWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.PublicConstructors, typeof (NSFileProviderEnumeratingWrapper))]
		static NSFileProviderEnumeratingWrapper ()
		{
			GC.KeepAlive (null);
		}
		[Export ("enumeratorForContainerItemIdentifier:request:error:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe INSFileProviderEnumerator? GetEnumerator (string containerItemIdentifier, NSFileProviderRequest request, out NSError? error)
		{
			if (containerItemIdentifier is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (containerItemIdentifier));
			var request__handle__ = request!.GetNonNullHandle (nameof (request));
			NativeHandle errorValue = IntPtr.Zero;
			var nscontainerItemIdentifier = CFString.CreateNative (containerItemIdentifier);
			INSFileProviderEnumerator? ret;
			ret =  Runtime.GetINativeObject<INSFileProviderEnumerator> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_ref_NativeHandle (this.Handle, Selector.GetHandle ("enumeratorForContainerItemIdentifier:request:error:"), nscontainerItemIdentifier, request__handle__, &errorValue), false)!;
			GC.KeepAlive (request);
			CFString.ReleaseNative (nscontainerItemIdentifier);
			error = Runtime.GetNSObject<NSError> (errorValue)!;
			return ret!;
		}
	}
}
