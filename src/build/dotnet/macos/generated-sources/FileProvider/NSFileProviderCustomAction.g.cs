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
	/// <summary>This interface represents the Objective-C protocol <c>NSFileProviderCustomAction</c>.</summary>
	/// <remarks>
	///   <para>A class that implements this interface (and subclasses <see cref="NSObject" />) will be exported to Objective-C as implementing the Objective-C protocol this interface represents.</para>
	///   <para>A class may also implement members from this interface to implement members from the protocol.</para>
	/// </remarks>
	[UnsupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios16.0")]
	[SupportedOSPlatform ("macos")]
	[Protocol (Name = "NSFileProviderCustomAction", WrapperType = typeof (NSFileProviderCustomActionWrapper))]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "PerformAction", Selector = "performActionWithIdentifier:onItemsWithIdentifiers:completionHandler:", ReturnType = typeof (NSProgress), ParameterType = new Type [] { typeof (string), typeof (String[]), typeof (global::System.Action<NSError>) }, ParameterByRef = new bool [] { false, false, false }, ParameterBlockProxy = new Type? [] { null, null, typeof (ObjCRuntime.Trampolines.NIDActionArity1V16) })]
	public partial interface INSFileProviderCustomAction : INativeObject, IDisposable
	{
		[global::Foundation.RequiredMember]
		[Export ("performActionWithIdentifier:onItemsWithIdentifiers:completionHandler:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual NSProgress PerformAction (string actionIdentifier, string[] itemIdentifiers, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V16))]global::System.Action<NSError> completionHandler)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal unsafe static NSProgress _PerformAction (INSFileProviderCustomAction This, string actionIdentifier, string[] itemIdentifiers, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V16))]global::System.Action<NSError> completionHandler)
		{
			if (actionIdentifier is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (actionIdentifier));
			if (itemIdentifiers is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (itemIdentifiers));
			if (completionHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completionHandler));
			var nsactionIdentifier = CFString.CreateNative (actionIdentifier);
			using var nsa_itemIdentifiers = NSArray.FromStrings (itemIdentifiers);
			using var block_completionHandler = Trampolines.SDActionArity1V16.CreateBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = &block_completionHandler;
			NSProgress? ret;
			ret =  Runtime.GetNSObject<NSProgress> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("performActionWithIdentifier:onItemsWithIdentifiers:completionHandler:"), nsactionIdentifier, nsa_itemIdentifiers.Handle, (IntPtr) block_ptr_completionHandler), false)!;
			GC.KeepAlive (This);
			CFString.ReleaseNative (nsactionIdentifier);
			return ret!;
		}
		[DynamicDependencyAttribute ("PerformAction(System.String,System.String[],System.Action{Foundation.NSError})")]
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.Interfaces | DynamicallyAccessedMemberTypes.PublicConstructors, typeof (NSFileProviderCustomActionWrapper))]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static INSFileProviderCustomAction ()
		{
			GC.KeepAlive (null);
		}
	}
	#pragma warning restore CS1573
	internal unsafe sealed class NSFileProviderCustomActionWrapper : BaseWrapper, INSFileProviderCustomAction {
		public NSFileProviderCustomActionWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.PublicConstructors, typeof (NSFileProviderCustomActionWrapper))]
		static NSFileProviderCustomActionWrapper ()
		{
			GC.KeepAlive (null);
		}
		[Export ("performActionWithIdentifier:onItemsWithIdentifiers:completionHandler:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe NSProgress PerformAction (string actionIdentifier, string[] itemIdentifiers, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V16))]global::System.Action<NSError> completionHandler)
		{
			if (actionIdentifier is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (actionIdentifier));
			if (itemIdentifiers is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (itemIdentifiers));
			if (completionHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completionHandler));
			var nsactionIdentifier = CFString.CreateNative (actionIdentifier);
			using var nsa_itemIdentifiers = NSArray.FromStrings (itemIdentifiers);
			using var block_completionHandler = Trampolines.SDActionArity1V16.CreateBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = &block_completionHandler;
			NSProgress? ret;
			ret =  Runtime.GetNSObject<NSProgress> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("performActionWithIdentifier:onItemsWithIdentifiers:completionHandler:"), nsactionIdentifier, nsa_itemIdentifiers.Handle, (IntPtr) block_ptr_completionHandler), false)!;
			CFString.ReleaseNative (nsactionIdentifier);
			return ret!;
		}
	}
}
