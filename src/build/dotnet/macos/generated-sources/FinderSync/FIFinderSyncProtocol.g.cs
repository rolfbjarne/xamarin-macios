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
namespace FinderSync {
	#pragma warning disable CS1573
	/// <summary>This interface represents the Objective-C protocol <c>FIFinderSync</c>.</summary>
	/// <remarks>
	///   <para>A class that implements this interface (and subclasses <see cref="NSObject" />) will be exported to Objective-C as implementing the Objective-C protocol this interface represents.</para>
	///   <para>A class may also implement members from this interface to implement members from the protocol.</para>
	/// </remarks>
	[Protocol (Name = "FIFinderSync", WrapperType = typeof (FIFinderSyncProtocolWrapper))]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "GetMenu", Selector = "menuForMenuKind:", ReturnType = typeof (NSMenu), ParameterType = new Type [] { typeof (FinderSync.FIMenuKind) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "BeginObservingDirectory", Selector = "beginObservingDirectoryAtURL:", ParameterType = new Type [] { typeof (NSUrl) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "EndObservingDirectory", Selector = "endObservingDirectoryAtURL:", ParameterType = new Type [] { typeof (NSUrl) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "RequestBadgeIdentifier", Selector = "requestBadgeIdentifierForURL:", ParameterType = new Type [] { typeof (NSUrl) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "SupportedServiceNames", Selector = "supportedServiceNamesForItemWithURL:", ReturnType = typeof (String[]), ParameterType = new Type [] { typeof (NSUrl) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "GetValues", Selector = "valuesForAttributes:forItemWithURL:completion:", ParameterType = new Type [] { typeof (String[]), typeof (NSUrl), typeof (FinderSync.GetValuesCompletionHandler) }, ParameterByRef = new bool [] { false, false, false }, ParameterBlockProxy = new Type? [] { null, null, typeof (ObjCRuntime.Trampolines.NIDGetValuesCompletionHandler) })]
	[ProtocolMember (IsRequired = false, IsProperty = true, IsStatic = false, Name = "ToolbarItemName", Selector = "toolbarItemName", PropertyType = typeof (string), GetterSelector = "toolbarItemName", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = false, IsProperty = true, IsStatic = false, Name = "ToolbarItemImage", Selector = "toolbarItemImage", PropertyType = typeof (NSImage), GetterSelector = "toolbarItemImage", ArgumentSemantic = ArgumentSemantic.Copy)]
	[ProtocolMember (IsRequired = false, IsProperty = true, IsStatic = false, Name = "ToolbarItemToolTip", Selector = "toolbarItemToolTip", PropertyType = typeof (string), GetterSelector = "toolbarItemToolTip", ArgumentSemantic = ArgumentSemantic.None)]
	public partial interface IFIFinderSyncProtocol : INativeObject, IDisposable
	{
		/// <param name="menuKind">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("menuForMenuKind:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual global::AppKit.NSMenu? GetMenu (FIMenuKind menuKind)
		{
			return _GetMenu (this, menuKind);
		}
		/// <param name="menuKind">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static global::AppKit.NSMenu? _GetMenu (IFIFinderSyncProtocol This, FIMenuKind menuKind)
		{
			global::AppKit.NSMenu ret;
			ret =  Runtime.GetNSObject<global::AppKit.NSMenu> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_UIntPtr (This.Handle, Selector.GetHandle ("menuForMenuKind:"), (UIntPtr) (ulong) menuKind), false)!;
			GC.KeepAlive (This);
			return ret;
		}
		/// <param name="url">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("beginObservingDirectoryAtURL:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void BeginObservingDirectory (NSUrl url)
		{
			_BeginObservingDirectory (this, url);
		}
		/// <param name="url">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _BeginObservingDirectory (IFIFinderSyncProtocol This, NSUrl url)
		{
			var url__handle__ = url!.GetNonNullHandle (nameof (url));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("beginObservingDirectoryAtURL:"), url__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (url);
		}
		/// <param name="url">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("endObservingDirectoryAtURL:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void EndObservingDirectory (NSUrl url)
		{
			_EndObservingDirectory (this, url);
		}
		/// <param name="url">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _EndObservingDirectory (IFIFinderSyncProtocol This, NSUrl url)
		{
			var url__handle__ = url!.GetNonNullHandle (nameof (url));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("endObservingDirectoryAtURL:"), url__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (url);
		}
		/// <param name="url">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("requestBadgeIdentifierForURL:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void RequestBadgeIdentifier (NSUrl url)
		{
			_RequestBadgeIdentifier (this, url);
		}
		/// <param name="url">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _RequestBadgeIdentifier (IFIFinderSyncProtocol This, NSUrl url)
		{
			var url__handle__ = url!.GetNonNullHandle (nameof (url));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("requestBadgeIdentifierForURL:"), url__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (url);
		}
		/// <param name="itemUrl">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("supportedServiceNamesForItemWithURL:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string[] SupportedServiceNames (NSUrl itemUrl)
		{
			return _SupportedServiceNames (this, itemUrl);
		}
		/// <param name="itemUrl">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static string[] _SupportedServiceNames (IFIFinderSyncProtocol This, NSUrl itemUrl)
		{
			var itemUrl__handle__ = itemUrl!.GetNonNullHandle (nameof (itemUrl));
			string[]? ret;
			ret = CFArray.StringArrayFromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("supportedServiceNamesForItemWithURL:"), itemUrl__handle__), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (itemUrl);
			return ret!;
		}
		/// <param name="attributes">To be added.</param><param name="itemUrl">To be added.</param><param name="completion">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("valuesForAttributes:forItemWithURL:completion:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void GetValues (string[] attributes, NSUrl itemUrl, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDGetValuesCompletionHandler))]GetValuesCompletionHandler completion)
		{
			_GetValues (this, attributes, itemUrl, completion);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual Task<NSDictionary<NSString, NSObject>> GetValuesAsync (string[] attributes, NSUrl itemUrl)
		{
			var tcs = new TaskCompletionSource<NSDictionary<NSString, NSObject>> ();
			GetValues(attributes, itemUrl, (values_, error_) => {
				if (error_ is not null)
					tcs.SetException (new NSErrorException(error_));
				else
					tcs.SetResult (values_!);
			});
			return tcs.Task;
		}
		/// <param name="attributes">To be added.</param><param name="itemUrl">To be added.</param><param name="completion">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal unsafe static void _GetValues (IFIFinderSyncProtocol This, string[] attributes, NSUrl itemUrl, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDGetValuesCompletionHandler))]GetValuesCompletionHandler completion)
		{
			if (attributes is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (attributes));
			var itemUrl__handle__ = itemUrl!.GetNonNullHandle (nameof (itemUrl));
			if (completion is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completion));
			using var nsa_attributes = NSArray.FromStrings (attributes);
			using var block_completion = Trampolines.SDGetValuesCompletionHandler.CreateBlock (completion);
			BlockLiteral *block_ptr_completion = &block_completion;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("valuesForAttributes:forItemWithURL:completion:"), nsa_attributes.Handle, itemUrl__handle__, (IntPtr) block_ptr_completion);
			GC.KeepAlive (This);
			GC.KeepAlive (itemUrl);
		}
		[DynamicDependencyAttribute ("BeginObservingDirectory(Foundation.NSUrl)")]
		[DynamicDependencyAttribute ("EndObservingDirectory(Foundation.NSUrl)")]
		[DynamicDependencyAttribute ("GetMenu(FinderSync.FIMenuKind)")]
		[DynamicDependencyAttribute ("GetValues(System.String[],Foundation.NSUrl,FinderSync.GetValuesCompletionHandler)")]
		[DynamicDependencyAttribute ("RequestBadgeIdentifier(Foundation.NSUrl)")]
		[DynamicDependencyAttribute ("SupportedServiceNames(Foundation.NSUrl)")]
		[DynamicDependencyAttribute ("ToolbarItemImage")]
		[DynamicDependencyAttribute ("ToolbarItemName")]
		[DynamicDependencyAttribute ("ToolbarItemToolTip")]
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.Interfaces | DynamicallyAccessedMemberTypes.PublicConstructors, typeof (FIFinderSyncProtocolWrapper))]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static IFIFinderSyncProtocol ()
		{
			GC.KeepAlive (null);
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.OptionalMember]
		public virtual string ToolbarItemName {
			[Export ("toolbarItemName")]
			get {
				return _GetToolbarItemName (this);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static string _GetToolbarItemName (IFIFinderSyncProtocol This)
		{
			string ret;
			ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("toolbarItemName")), false)!;
			GC.KeepAlive (This);
			return ret;
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.OptionalMember]
		public virtual global::AppKit.NSImage ToolbarItemImage {
			[Export ("toolbarItemImage", ArgumentSemantic.Copy)]
			get {
				return _GetToolbarItemImage (this);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static global::AppKit.NSImage _GetToolbarItemImage (IFIFinderSyncProtocol This)
		{
			global::AppKit.NSImage ret;
			ret =  Runtime.GetNSObject<global::AppKit.NSImage> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("toolbarItemImage")), false)!;
			GC.KeepAlive (This);
			return ret;
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.OptionalMember]
		public virtual string ToolbarItemToolTip {
			[Export ("toolbarItemToolTip")]
			get {
				return _GetToolbarItemToolTip (this);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static string _GetToolbarItemToolTip (IFIFinderSyncProtocol This)
		{
			string ret;
			ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("toolbarItemToolTip")), false)!;
			GC.KeepAlive (This);
			return ret;
		}
	}
	#pragma warning restore CS1573
	#pragma warning disable CS1573
	/// <summary>Extension methods to the <see cref="IFIFinderSyncProtocol" /> interface to support all the methods from the FIFinderSync protocol.</summary>
	/// <remarks>
	///   <para>The extension methods for <see cref="IFIFinderSyncProtocol" /> interface allow developers to treat instances of the interface as having all the optional methods of the original FIFinderSync protocol. Since the interface only contains the required members, these extension methods allow developers to call the optional members of the protocol.</para>
	/// </remarks>
	public unsafe static partial class FIFinderSyncProtocol_Extensions {
		/// <param name="menuKind">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static global::AppKit.NSMenu? GetMenu (this IFIFinderSyncProtocol This, FIMenuKind menuKind)
		{
			global::AppKit.NSMenu ret;
			ret =  Runtime.GetNSObject<global::AppKit.NSMenu> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_UIntPtr (This.Handle, Selector.GetHandle ("menuForMenuKind:"), (UIntPtr) (ulong) menuKind), false)!;
			GC.KeepAlive (This);
			return ret;
		}
		/// <param name="url">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void BeginObservingDirectory (this IFIFinderSyncProtocol This, NSUrl url)
		{
			var url__handle__ = url!.GetNonNullHandle (nameof (url));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("beginObservingDirectoryAtURL:"), url__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (url);
		}
		/// <param name="url">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void EndObservingDirectory (this IFIFinderSyncProtocol This, NSUrl url)
		{
			var url__handle__ = url!.GetNonNullHandle (nameof (url));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("endObservingDirectoryAtURL:"), url__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (url);
		}
		/// <param name="url">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void RequestBadgeIdentifier (this IFIFinderSyncProtocol This, NSUrl url)
		{
			var url__handle__ = url!.GetNonNullHandle (nameof (url));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("requestBadgeIdentifierForURL:"), url__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (url);
		}
		/// <param name="itemUrl">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static string[] SupportedServiceNames (this IFIFinderSyncProtocol This, NSUrl itemUrl)
		{
			var itemUrl__handle__ = itemUrl!.GetNonNullHandle (nameof (itemUrl));
			string[]? ret;
			ret = CFArray.StringArrayFromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("supportedServiceNamesForItemWithURL:"), itemUrl__handle__), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (itemUrl);
			return ret!;
		}
		/// <param name="attributes">To be added.</param><param name="itemUrl">To be added.</param><param name="completion">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static void GetValues (this IFIFinderSyncProtocol This, string[] attributes, NSUrl itemUrl, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDGetValuesCompletionHandler))]GetValuesCompletionHandler completion)
		{
			if (attributes is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (attributes));
			var itemUrl__handle__ = itemUrl!.GetNonNullHandle (nameof (itemUrl));
			if (completion is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completion));
			using var nsa_attributes = NSArray.FromStrings (attributes);
			using var block_completion = Trampolines.SDGetValuesCompletionHandler.CreateBlock (completion);
			BlockLiteral *block_ptr_completion = &block_completion;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("valuesForAttributes:forItemWithURL:completion:"), nsa_attributes.Handle, itemUrl__handle__, (IntPtr) block_ptr_completion);
			GC.KeepAlive (This);
			GC.KeepAlive (itemUrl);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static Task<NSDictionary<NSString, NSObject>> GetValuesAsync (this IFIFinderSyncProtocol This, string[] attributes, NSUrl itemUrl)
		{
			var tcs = new TaskCompletionSource<NSDictionary<NSString, NSObject>> ();
			This.GetValues(attributes, itemUrl, (values_, error_) => {
				if (error_ is not null)
					tcs.SetException (new NSErrorException(error_));
				else
					tcs.SetResult (values_!);
			});
			return tcs.Task;
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static string GetToolbarItemName (this IFIFinderSyncProtocol This)
		{
			string ret;
			ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("toolbarItemName")), false)!;
			GC.KeepAlive (This);
			return ret;
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static global::AppKit.NSImage GetToolbarItemImage (this IFIFinderSyncProtocol This)
		{
			global::AppKit.NSImage ret;
			ret =  Runtime.GetNSObject<global::AppKit.NSImage> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("toolbarItemImage")), false)!;
			GC.KeepAlive (This);
			return ret;
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static string GetToolbarItemToolTip (this IFIFinderSyncProtocol This)
		{
			string ret;
			ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("toolbarItemToolTip")), false)!;
			GC.KeepAlive (This);
			return ret;
		}
	}
	#pragma warning restore CS1573
	internal unsafe sealed class FIFinderSyncProtocolWrapper : BaseWrapper, IFIFinderSyncProtocol {
		public FIFinderSyncProtocolWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.PublicConstructors, typeof (FIFinderSyncProtocolWrapper))]
		static FIFinderSyncProtocolWrapper ()
		{
			GC.KeepAlive (null);
		}
	}
}
