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
namespace AppKit {
	#pragma warning disable CS1573
	/// <summary>This interface represents the Objective-C protocol <c>NSUserInterfaceItemSearching</c>.</summary>
	/// <remarks>
	///   <para>A class that implements this interface (and subclasses <see cref="NSObject" />) will be exported to Objective-C as implementing the Objective-C protocol this interface represents.</para>
	///   <para>A class may also implement members from this interface to implement members from the protocol.</para>
	/// </remarks>
	[UnsupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("macos")]
	[Protocol (Name = "NSUserInterfaceItemSearching", WrapperType = typeof (NSUserInterfaceItemSearchingWrapper))]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "SearchForItems", Selector = "searchForItemsWithSearchString:resultLimit:matchedItemHandler:", ParameterType = new Type [] { typeof (string), typeof (IntPtr), typeof (global::System.Action<NSObject[]>) }, ParameterByRef = new bool [] { false, false, false }, ParameterBlockProxy = new Type? [] { null, null, typeof (ObjCRuntime.Trampolines.NIDActionArity1V22) })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "GetLocalizedTitles", Selector = "localizedTitlesForItem:", ReturnType = typeof (String[]), ParameterType = new Type [] { typeof (NSObject) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "PerformAction", Selector = "performActionForItem:", ParameterType = new Type [] { typeof (NSObject) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "ShowAllHelpTopics", Selector = "showAllHelpTopicsForSearchString:", ParameterType = new Type [] { typeof (string) }, ParameterByRef = new bool [] { false })]
	public partial interface INSUserInterfaceItemSearching : INativeObject, IDisposable
	{
		[global::Foundation.RequiredMember]
		[Export ("searchForItemsWithSearchString:resultLimit:matchedItemHandler:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void SearchForItems (string searchString, nint resultLimit, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V22))]global::System.Action<NSObject[]> matchedItemHandler)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal unsafe static void _SearchForItems (INSUserInterfaceItemSearching This, string searchString, nint resultLimit, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V22))]global::System.Action<NSObject[]> matchedItemHandler)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			if (searchString is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (searchString));
			if (matchedItemHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (matchedItemHandler));
			var nssearchString = CFString.CreateNative (searchString);
			using var block_matchedItemHandler = Trampolines.SDActionArity1V22.CreateBlock (matchedItemHandler);
			BlockLiteral *block_ptr_matchedItemHandler = &block_matchedItemHandler;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_IntPtr_NativeHandle (This.Handle, Selector.GetHandle ("searchForItemsWithSearchString:resultLimit:matchedItemHandler:"), nssearchString, resultLimit, (IntPtr) block_ptr_matchedItemHandler);
			GC.KeepAlive (This);
			CFString.ReleaseNative (nssearchString);
		}
		[global::Foundation.RequiredMember]
		[Export ("localizedTitlesForItem:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string[] GetLocalizedTitles (NSObject forItem)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static string[] _GetLocalizedTitles (INSUserInterfaceItemSearching This, NSObject forItem)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var forItem__handle__ = forItem!.GetNonNullHandle (nameof (forItem));
			string[]? ret;
			ret = CFArray.StringArrayFromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("localizedTitlesForItem:"), forItem__handle__), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (forItem);
			return ret!;
		}
		[global::Foundation.OptionalMember]
		[Export ("performActionForItem:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void PerformAction (NSObject forItem)
		{
			_PerformAction (this, forItem);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _PerformAction (INSUserInterfaceItemSearching This, NSObject forItem)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var forItem__handle__ = forItem!.GetNonNullHandle (nameof (forItem));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("performActionForItem:"), forItem__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (forItem);
		}
		[global::Foundation.OptionalMember]
		[Export ("showAllHelpTopicsForSearchString:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void ShowAllHelpTopics (string searchString)
		{
			_ShowAllHelpTopics (this, searchString);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _ShowAllHelpTopics (INSUserInterfaceItemSearching This, string searchString)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			if (searchString is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (searchString));
			var nssearchString = CFString.CreateNative (searchString);
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("showAllHelpTopicsForSearchString:"), nssearchString);
			GC.KeepAlive (This);
			CFString.ReleaseNative (nssearchString);
		}
		[DynamicDependencyAttribute ("GetLocalizedTitles(Foundation.NSObject)")]
		[DynamicDependencyAttribute ("PerformAction(Foundation.NSObject)")]
		[DynamicDependencyAttribute ("SearchForItems(System.String,System.IntPtr,System.Action{Foundation.NSObject[]})")]
		[DynamicDependencyAttribute ("ShowAllHelpTopics(System.String)")]
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.Interfaces | DynamicallyAccessedMemberTypes.PublicConstructors, typeof (NSUserInterfaceItemSearchingWrapper))]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static INSUserInterfaceItemSearching ()
		{
			GC.KeepAlive (null);
		}
	}
	#pragma warning restore CS1573
	#pragma warning disable CS1573
	/// <summary>Extension methods to the <see cref="INSUserInterfaceItemSearching" /> interface to support all the methods from the NSUserInterfaceItemSearching protocol.</summary>
	/// <remarks>
	///   <para>The extension methods for <see cref="INSUserInterfaceItemSearching" /> interface allow developers to treat instances of the interface as having all the optional methods of the original NSUserInterfaceItemSearching protocol. Since the interface only contains the required members, these extension methods allow developers to call the optional members of the protocol.</para>
	/// </remarks>
	public unsafe static partial class NSUserInterfaceItemSearching_Extensions {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void PerformAction (this INSUserInterfaceItemSearching This, NSObject forItem)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var forItem__handle__ = forItem!.GetNonNullHandle (nameof (forItem));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("performActionForItem:"), forItem__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (forItem);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void ShowAllHelpTopics (this INSUserInterfaceItemSearching This, string searchString)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			if (searchString is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (searchString));
			var nssearchString = CFString.CreateNative (searchString);
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("showAllHelpTopicsForSearchString:"), nssearchString);
			GC.KeepAlive (This);
			CFString.ReleaseNative (nssearchString);
		}
	}
	#pragma warning restore CS1573
	internal unsafe sealed class NSUserInterfaceItemSearchingWrapper : BaseWrapper, INSUserInterfaceItemSearching {
		public NSUserInterfaceItemSearchingWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.PublicConstructors, typeof (NSUserInterfaceItemSearchingWrapper))]
		static NSUserInterfaceItemSearchingWrapper ()
		{
			GC.KeepAlive (null);
		}
		[Export ("searchForItemsWithSearchString:resultLimit:matchedItemHandler:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe void SearchForItems (string searchString, nint resultLimit, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V22))]global::System.Action<NSObject[]> matchedItemHandler)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			if (searchString is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (searchString));
			if (matchedItemHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (matchedItemHandler));
			var nssearchString = CFString.CreateNative (searchString);
			using var block_matchedItemHandler = Trampolines.SDActionArity1V22.CreateBlock (matchedItemHandler);
			BlockLiteral *block_ptr_matchedItemHandler = &block_matchedItemHandler;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_IntPtr_NativeHandle (this.Handle, Selector.GetHandle ("searchForItemsWithSearchString:resultLimit:matchedItemHandler:"), nssearchString, resultLimit, (IntPtr) block_ptr_matchedItemHandler);
			CFString.ReleaseNative (nssearchString);
		}
		[Export ("localizedTitlesForItem:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public string[] GetLocalizedTitles (NSObject forItem)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var forItem__handle__ = forItem!.GetNonNullHandle (nameof (forItem));
			string[]? ret;
			ret = CFArray.StringArrayFromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("localizedTitlesForItem:"), forItem__handle__), false)!;
			GC.KeepAlive (forItem);
			return ret!;
		}
	}
}
