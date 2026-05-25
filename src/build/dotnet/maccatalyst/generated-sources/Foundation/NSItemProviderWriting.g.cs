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
	/// <summary>Interface used by <see cref="T:Foundation.NSItemProvider" /> for retrieving data from an object.</summary><remarks>To be added.</remarks>
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("tvos")]
	[Protocol (Name = "NSItemProviderWriting", WrapperType = typeof (NSItemProviderWritingWrapper))]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "GetItemProviderVisibilityForTypeIdentifier", Selector = "itemProviderVisibilityForRepresentationWithTypeIdentifier:", ReturnType = typeof (NSItemProviderRepresentationVisibility), ParameterType = new Type [] { typeof (string) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "LoadData", Selector = "loadDataWithTypeIdentifier:forItemProviderCompletionHandler:", ReturnType = typeof (NSProgress), ParameterType = new Type [] { typeof (string), typeof (global::System.Action<NSData, NSError>) }, ParameterByRef = new bool [] { false, false }, ParameterBlockProxy = new Type? [] { null, typeof (ObjCRuntime.Trampolines.NIDActionArity2V16) })]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = true, Name = "WritableTypeIdentifiers", Selector = "writableTypeIdentifiersForItemProvider", PropertyType = typeof (String[]), GetterSelector = "writableTypeIdentifiersForItemProvider", ArgumentSemantic = ArgumentSemantic.Copy)]
	[ProtocolMember (IsRequired = false, IsProperty = true, IsStatic = false, Name = "WritableTypeIdentifiersForItemProvider", Selector = "writableTypeIdentifiersForItemProvider", PropertyType = typeof (String[]), GetterSelector = "writableTypeIdentifiersForItemProvider", ArgumentSemantic = ArgumentSemantic.Copy)]
	public partial interface INSItemProviderWriting : INativeObject, IDisposable
	{
		/// <param name="typeIdentifier">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("itemProviderVisibilityForRepresentationWithTypeIdentifier:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSItemProviderRepresentationVisibility GetItemProviderVisibilityForTypeIdentifier (string typeIdentifier)
		{
			return _GetItemProviderVisibilityForTypeIdentifier (this, typeIdentifier);
		}
		/// <param name="typeIdentifier">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static NSItemProviderRepresentationVisibility _GetItemProviderVisibilityForTypeIdentifier (INSItemProviderWriting This, string typeIdentifier)
		{
			if (typeIdentifier is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (typeIdentifier));
			var nstypeIdentifier = CFString.CreateNative (typeIdentifier);
			NSItemProviderRepresentationVisibility ret;
			ret = (NSItemProviderRepresentationVisibility) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("itemProviderVisibilityForRepresentationWithTypeIdentifier:"), nstypeIdentifier);
			GC.KeepAlive (This);
			CFString.ReleaseNative (nstypeIdentifier);
			return ret!;
		}
		/// <param name="typeIdentifier">A Universal Type Identifier (UTI) indicating the type of data to load.</param><param name="completionHandler">The method called after the data is loaded.</param><summary>Implement this method to customize the loading of data by an <see cref="T:Foundation.NSItemProvider" />.</summary><returns>An <see cref="T:Foundation.NSProgress" /> object reflecting the data-loading operation.</returns><remarks><para>The <paramref name="typeIdentifier" /> must be in the set of values returned by <see cref="Foundation.NSItemProviderWriting_Extensions.GetWritableTypeIdentifiersForItemProvider(Foundation.INSItemProviderWriting)" />.</para></remarks>
		[global::Foundation.RequiredMember]
		[Export ("loadDataWithTypeIdentifier:forItemProviderCompletionHandler:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual NSProgress? LoadData (string typeIdentifier, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity2V16))]global::System.Action<NSData, NSError> completionHandler)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="typeIdentifier">A Universal Type Identifier (UTI) indicating the type of data to load.</param>
		/// <summary>Asynchronously loads data for the identified type from an item provider, returning a task that contains the data.</summary>
		/// <returns>To be added.</returns>
		/// <remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual Task<NSData> LoadDataAsync (string typeIdentifier)
		{
			var tcs = new TaskCompletionSource<NSData> ();
			LoadData(typeIdentifier, (arg1_, arg2_) => {
				if (arg2_ is not null)
					tcs.SetException (new NSErrorException(arg2_));
				else
					tcs.SetResult (arg1_!);
			});
			return tcs.Task;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual Task<NSData> LoadDataAsync (string typeIdentifier, out NSProgress result)
		{
			var tcs = new TaskCompletionSource<NSData> ();
			result = LoadData(typeIdentifier, (arg1_, arg2_) => {
				if (arg2_ is not null)
					tcs.SetException (new NSErrorException(arg2_));
				else
					tcs.SetResult (arg1_!);
			})!;
			return tcs.Task;
		}
		/// <param name="typeIdentifier">A Universal Type Identifier (UTI) indicating the type of data to load.</param><param name="completionHandler">The method called after the data is loaded.</param><summary>Implement this method to customize the loading of data by an <see cref="T:Foundation.NSItemProvider" />.</summary><returns>An <see cref="T:Foundation.NSProgress" /> object reflecting the data-loading operation.</returns><remarks><para>The <paramref name="typeIdentifier" /> must be in the set of values returned by <see cref="Foundation.NSItemProviderWriting_Extensions.GetWritableTypeIdentifiersForItemProvider(Foundation.INSItemProviderWriting)" />.</para></remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal unsafe static NSProgress? _LoadData (INSItemProviderWriting This, string typeIdentifier, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity2V16))]global::System.Action<NSData, NSError> completionHandler)
		{
			if (typeIdentifier is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (typeIdentifier));
			if (completionHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completionHandler));
			var nstypeIdentifier = CFString.CreateNative (typeIdentifier);
			using var block_completionHandler = Trampolines.SDActionArity2V16.CreateBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = &block_completionHandler;
			NSProgress? ret;
			ret =  Runtime.GetNSObject<NSProgress> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("loadDataWithTypeIdentifier:forItemProviderCompletionHandler:"), nstypeIdentifier, (IntPtr) block_ptr_completionHandler), false)!;
			GC.KeepAlive (This);
			CFString.ReleaseNative (nstypeIdentifier);
			return ret!;
		}
		[DynamicDependencyAttribute ("GetItemProviderVisibilityForTypeIdentifier(System.String)")]
		[DynamicDependencyAttribute ("LoadData(System.String,System.Action{Foundation.NSData,Foundation.NSError})")]
		[DynamicDependencyAttribute ("WritableTypeIdentifiersForItemProvider")]
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.Interfaces | DynamicallyAccessedMemberTypes.PublicConstructors, typeof (NSItemProviderWritingWrapper))]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static INSItemProviderWriting ()
		{
			GC.KeepAlive (null);
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.OptionalMember]
		public virtual string[] WritableTypeIdentifiersForItemProvider {
			[Export ("writableTypeIdentifiersForItemProvider", ArgumentSemantic.Copy)]
			get {
				return _GetWritableTypeIdentifiersForItemProvider (this);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static string[] _GetWritableTypeIdentifiersForItemProvider (INSItemProviderWriting This)
		{
			string[] ret;
			ret = CFArray.StringArrayFromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("writableTypeIdentifiersForItemProvider")), false)!;
			GC.KeepAlive (This);
			return ret;
		}
		[global::Foundation.RequiredMember]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static string[] GetWritableTypeIdentifiers<T> () where T: NSObject, INSItemProviderWriting
		{
			var class_ptr = Class.GetHandle (typeof (T));
			string[] ret;
			ret = CFArray.StringArrayFromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (class_ptr, Selector.GetHandle ("writableTypeIdentifiersForItemProvider")), false)!;
			return ret;
		}
	}
	#pragma warning restore CS1573
	#pragma warning disable CS1573
	/// <summary>Extension methods to the <see cref="INSItemProviderWriting" /> interface to support all the methods from the NSItemProviderWriting protocol.</summary>
	/// <remarks>
	///   <para>The extension methods for <see cref="INSItemProviderWriting" /> interface allow developers to treat instances of the interface as having all the optional methods of the original NSItemProviderWriting protocol. Since the interface only contains the required members, these extension methods allow developers to call the optional members of the protocol.</para>
	/// </remarks>
	public unsafe static partial class NSItemProviderWriting_Extensions {
		/// <param name="typeIdentifier">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSItemProviderRepresentationVisibility GetItemProviderVisibilityForTypeIdentifier (this INSItemProviderWriting This, string typeIdentifier)
		{
			if (typeIdentifier is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (typeIdentifier));
			var nstypeIdentifier = CFString.CreateNative (typeIdentifier);
			NSItemProviderRepresentationVisibility ret;
			ret = (NSItemProviderRepresentationVisibility) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("itemProviderVisibilityForRepresentationWithTypeIdentifier:"), nstypeIdentifier);
			GC.KeepAlive (This);
			CFString.ReleaseNative (nstypeIdentifier);
			return ret!;
		}
		/// <param name="typeIdentifier">A Universal Type Identifier (UTI) indicating the type of data to load.</param>
		/// <summary>Asynchronously loads data for the identified type from an item provider, returning a task that contains the data.</summary>
		/// <returns>To be added.</returns>
		/// <remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static Task<NSData> LoadDataAsync (this INSItemProviderWriting This, string typeIdentifier)
		{
			var tcs = new TaskCompletionSource<NSData> ();
			This.LoadData(typeIdentifier, (arg1_, arg2_) => {
				if (arg2_ is not null)
					tcs.SetException (new NSErrorException(arg2_));
				else
					tcs.SetResult (arg1_!);
			});
			return tcs.Task;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static Task<NSData> LoadDataAsync (this INSItemProviderWriting This, string typeIdentifier, out NSProgress result)
		{
			var tcs = new TaskCompletionSource<NSData> ();
			result = This.LoadData(typeIdentifier, (arg1_, arg2_) => {
				if (arg2_ is not null)
					tcs.SetException (new NSErrorException(arg2_));
				else
					tcs.SetResult (arg1_!);
			})!;
			return tcs.Task;
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static string[] GetWritableTypeIdentifiersForItemProvider (this INSItemProviderWriting This)
		{
			string[] ret;
			ret = CFArray.StringArrayFromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("writableTypeIdentifiersForItemProvider")), false)!;
			GC.KeepAlive (This);
			return ret;
		}
	}
	#pragma warning restore CS1573
	internal unsafe sealed class NSItemProviderWritingWrapper : BaseWrapper, INSItemProviderWriting {
		public NSItemProviderWritingWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.PublicConstructors, typeof (NSItemProviderWritingWrapper))]
		static NSItemProviderWritingWrapper ()
		{
			GC.KeepAlive (null);
		}
		/// <param name="typeIdentifier">A Universal Type Identifier (UTI) indicating the type of data to load.</param><param name="completionHandler">The method called after the data is loaded.</param><summary>Implement this method to customize the loading of data by an <see cref="T:Foundation.NSItemProvider" />.</summary><returns>An <see cref="T:Foundation.NSProgress" /> object reflecting the data-loading operation.</returns><remarks><para>The <paramref name="typeIdentifier" /> must be in the set of values returned by <see cref="Foundation.NSItemProviderWriting_Extensions.GetWritableTypeIdentifiersForItemProvider(Foundation.INSItemProviderWriting)" />.</para></remarks>
		[Export ("loadDataWithTypeIdentifier:forItemProviderCompletionHandler:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe NSProgress? LoadData (string typeIdentifier, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity2V16))]global::System.Action<NSData, NSError> completionHandler)
		{
			if (typeIdentifier is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (typeIdentifier));
			if (completionHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completionHandler));
			var nstypeIdentifier = CFString.CreateNative (typeIdentifier);
			using var block_completionHandler = Trampolines.SDActionArity2V16.CreateBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = &block_completionHandler;
			NSProgress? ret;
			ret =  Runtime.GetNSObject<NSProgress> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("loadDataWithTypeIdentifier:forItemProviderCompletionHandler:"), nstypeIdentifier, (IntPtr) block_ptr_completionHandler), false)!;
			CFString.ReleaseNative (nstypeIdentifier);
			return ret!;
		}
	}
}
