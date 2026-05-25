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
using Metal;
using CoreML;
using AppKit;
using MapKit;
using Photos;
using ModelIO;
using Network;
using SceneKit;
using Contacts;
using Security;
using CloudKit;
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
using FileProvider;
using CoreAnimation;
using CoreFoundation;
using NetworkExtension;
using MetalPerformanceShadersGraph;
#nullable enable
namespace Foundation {
	#pragma warning disable CS1573
	/// <summary>This interface represents the Objective-C protocol <c>NSItemProviderReading</c>.</summary>
	/// <remarks>
	///   <para>A class that implements this interface (and subclasses <see cref="NSObject" />) will be exported to Objective-C as implementing the Objective-C protocol this interface represents.</para>
	///   <para>A class may also implement members from this interface to implement members from the protocol.</para>
	/// </remarks>
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("tvos")]
	[Protocol (Name = "NSItemProviderReading", WrapperType = typeof (NSItemProviderReadingWrapper))]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = true, Name = "GetObject", Selector = "objectWithItemProviderData:typeIdentifier:error:", ReturnType = typeof (INSItemProviderReading), ParameterType = new Type [] { typeof (NSData), typeof (string), typeof (NSError) }, ParameterByRef = new bool [] { false, false, true })]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = true, Name = "ReadableTypeIdentifiers", Selector = "readableTypeIdentifiersForItemProvider", PropertyType = typeof (String[]), GetterSelector = "readableTypeIdentifiersForItemProvider", ArgumentSemantic = ArgumentSemantic.Copy)]
	public partial interface INSItemProviderReading : INativeObject, IDisposable
	{
		/// <param name="data">To be added.</param><param name="typeIdentifier">To be added.</param><param name="outError">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.RequiredMember]
		[Export ("objectWithItemProviderData:typeIdentifier:error:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static INSItemProviderReading? GetObject<T> (NSData data, string typeIdentifier, out NSError? outError) where T: NSObject, INSItemProviderReading
		{
			var data__handle__ = data!.GetNonNullHandle (nameof (data));
			if (typeIdentifier is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (typeIdentifier));
			var class_ptr = Class.GetHandle (typeof (T));
			NativeHandle outErrorValue = IntPtr.Zero;
			var nstypeIdentifier = CFString.CreateNative (typeIdentifier);
			INSItemProviderReading? ret;
			ret =  Runtime.GetINativeObject<INSItemProviderReading> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_ref_NativeHandle (class_ptr, Selector.GetHandle ("objectWithItemProviderData:typeIdentifier:error:"), data__handle__, nstypeIdentifier, &outErrorValue), false)!;
			GC.KeepAlive (data);
			CFString.ReleaseNative (nstypeIdentifier);
			outError = Runtime.GetNSObject<NSError> (outErrorValue)!;
			return ret!;
		}
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.Interfaces | DynamicallyAccessedMemberTypes.PublicConstructors, typeof (NSItemProviderReadingWrapper))]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static INSItemProviderReading ()
		{
			GC.KeepAlive (null);
		}
		[global::Foundation.RequiredMember]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static string[] GetReadableTypeIdentifiers<T> () where T: NSObject, INSItemProviderReading
		{
			var class_ptr = Class.GetHandle (typeof (T));
			string[] ret;
			ret = CFArray.StringArrayFromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (class_ptr, Selector.GetHandle ("readableTypeIdentifiersForItemProvider")), false)!;
			return ret;
		}
	}
	#pragma warning restore CS1573
	internal unsafe sealed class NSItemProviderReadingWrapper : BaseWrapper, INSItemProviderReading {
		public NSItemProviderReadingWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.PublicConstructors, typeof (NSItemProviderReadingWrapper))]
		static NSItemProviderReadingWrapper ()
		{
			GC.KeepAlive (null);
		}
	}
}
