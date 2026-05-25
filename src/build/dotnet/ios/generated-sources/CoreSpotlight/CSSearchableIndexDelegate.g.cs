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
namespace CoreSpotlight {
	#pragma warning disable CS1573
	/// <summary>Delegate object providing members that are called when reindexing the index.</summary><related type="externalDocumentation" href="https://developer.apple.com/library/ios/documentation/CoreSpotlight/Reference/CSSearchableIndexDelegate_Protocol/index.html">Apple documentation for <c>CSSearchableIndexDelegate</c></related>
	[UnsupportedOSPlatform ("tvos")]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	[Protocol (Name = "CSSearchableIndexDelegate", WrapperType = typeof (CSSearchableIndexDelegateWrapper))]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "ReindexAllSearchableItems", Selector = "searchableIndex:reindexAllSearchableItemsWithAcknowledgementHandler:", ParameterType = new Type [] { typeof (CoreSpotlight.CSSearchableIndex), typeof (Action) }, ParameterByRef = new bool [] { false, false }, ParameterBlockProxy = new Type? [] { null, typeof (ObjCRuntime.Trampolines.NIDAction) })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "ReindexSearchableItems", Selector = "searchableIndex:reindexSearchableItemsWithIdentifiers:acknowledgementHandler:", ParameterType = new Type [] { typeof (CoreSpotlight.CSSearchableIndex), typeof (String[]), typeof (Action) }, ParameterByRef = new bool [] { false, false, false }, ParameterBlockProxy = new Type? [] { null, null, typeof (ObjCRuntime.Trampolines.NIDAction) })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidThrottle", Selector = "searchableIndexDidThrottle:", ParameterType = new Type [] { typeof (CoreSpotlight.CSSearchableIndex) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidFinishThrottle", Selector = "searchableIndexDidFinishThrottle:", ParameterType = new Type [] { typeof (CoreSpotlight.CSSearchableIndex) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "GetData", Selector = "dataForSearchableIndex:itemIdentifier:typeIdentifier:error:", ReturnType = typeof (NSData), ParameterType = new Type [] { typeof (CoreSpotlight.CSSearchableIndex), typeof (string), typeof (string), typeof (NSError) }, ParameterByRef = new bool [] { false, false, false, true })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "GetFileUrl", Selector = "fileURLForSearchableIndex:itemIdentifier:typeIdentifier:inPlace:error:", ReturnType = typeof (NSUrl), ParameterType = new Type [] { typeof (CoreSpotlight.CSSearchableIndex), typeof (string), typeof (string), typeof (bool), typeof (NSError) }, ParameterByRef = new bool [] { false, false, false, false, true })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "GetSearchableItems", Selector = "searchableItemsForIdentifiers:searchableItemsHandler:", ParameterType = new Type [] { typeof (String[]), typeof (CoreSpotlight.CSSearchableIndexDelegateGetSearchableItemsHandler) }, ParameterByRef = new bool [] { false, false }, ParameterBlockProxy = new Type? [] { null, typeof (ObjCRuntime.Trampolines.NIDCSSearchableIndexDelegateGetSearchableItemsHandler) })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidUpdate", Selector = "searchableItemsDidUpdate:", ParameterType = new Type [] { typeof (CoreSpotlight.CSSearchableItem[]) }, ParameterByRef = new bool [] { false })]
	public partial interface ICSSearchableIndexDelegate : INativeObject, IDisposable
	{
		/// <param name="searchableIndex">To be added.</param><param name="acknowledgementHandler">To be added.</param><summary>Reindexes all items in the specified index and runs <paramref name="acknowledgementHandler" /> when finished.</summary><remarks>To be added.</remarks>
		[global::Foundation.RequiredMember]
		[Export ("searchableIndex:reindexAllSearchableItemsWithAcknowledgementHandler:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void ReindexAllSearchableItems (CSSearchableIndex searchableIndex, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDAction))]global::System.Action acknowledgementHandler)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="searchableIndex">To be added.</param><param name="acknowledgementHandler">To be added.</param><summary>Reindexes all items in the specified index and runs <paramref name="acknowledgementHandler" /> when finished.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal unsafe static void _ReindexAllSearchableItems (ICSSearchableIndexDelegate This, CSSearchableIndex searchableIndex, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDAction))]global::System.Action acknowledgementHandler)
		{
			var searchableIndex__handle__ = searchableIndex!.GetNonNullHandle (nameof (searchableIndex));
			if (acknowledgementHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (acknowledgementHandler));
			using var block_acknowledgementHandler = Trampolines.SDAction.CreateBlock (acknowledgementHandler);
			BlockLiteral *block_ptr_acknowledgementHandler = &block_acknowledgementHandler;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("searchableIndex:reindexAllSearchableItemsWithAcknowledgementHandler:"), searchableIndex__handle__, (IntPtr) block_ptr_acknowledgementHandler);
			GC.KeepAlive (This);
			GC.KeepAlive (searchableIndex);
		}
		/// <param name="searchableIndex">To be added.</param><param name="identifiers">To be added.</param><param name="acknowledgementHandler">To be added.</param><summary>Reindexes the specified items in the specified index and runs <paramref name="acknowledgementHandler" /> when finished.</summary><remarks>To be added.</remarks>
		[global::Foundation.RequiredMember]
		[Export ("searchableIndex:reindexSearchableItemsWithIdentifiers:acknowledgementHandler:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void ReindexSearchableItems (CSSearchableIndex searchableIndex, string[] identifiers, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDAction))]global::System.Action acknowledgementHandler)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="searchableIndex">To be added.</param><param name="identifiers">To be added.</param><param name="acknowledgementHandler">To be added.</param><summary>Reindexes the specified items in the specified index and runs <paramref name="acknowledgementHandler" /> when finished.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal unsafe static void _ReindexSearchableItems (ICSSearchableIndexDelegate This, CSSearchableIndex searchableIndex, string[] identifiers, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDAction))]global::System.Action acknowledgementHandler)
		{
			var searchableIndex__handle__ = searchableIndex!.GetNonNullHandle (nameof (searchableIndex));
			if (identifiers is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (identifiers));
			if (acknowledgementHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (acknowledgementHandler));
			using var nsa_identifiers = NSArray.FromStrings (identifiers);
			using var block_acknowledgementHandler = Trampolines.SDAction.CreateBlock (acknowledgementHandler);
			BlockLiteral *block_ptr_acknowledgementHandler = &block_acknowledgementHandler;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("searchableIndex:reindexSearchableItemsWithIdentifiers:acknowledgementHandler:"), searchableIndex__handle__, nsa_identifiers.Handle, (IntPtr) block_ptr_acknowledgementHandler);
			GC.KeepAlive (This);
			GC.KeepAlive (searchableIndex);
		}
		/// <param name="searchableIndex">To be added.</param><summary>Method that is called after index throttling starts.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("searchableIndexDidThrottle:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidThrottle (CSSearchableIndex searchableIndex)
		{
			_DidThrottle (this, searchableIndex);
		}
		/// <param name="searchableIndex">To be added.</param><summary>Method that is called after index throttling starts.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _DidThrottle (ICSSearchableIndexDelegate This, CSSearchableIndex searchableIndex)
		{
			var searchableIndex__handle__ = searchableIndex!.GetNonNullHandle (nameof (searchableIndex));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("searchableIndexDidThrottle:"), searchableIndex__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (searchableIndex);
		}
		/// <param name="searchableIndex">To be added.</param><summary>Method that is called after index throttling is stopped..</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("searchableIndexDidFinishThrottle:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidFinishThrottle (CSSearchableIndex searchableIndex)
		{
			_DidFinishThrottle (this, searchableIndex);
		}
		/// <param name="searchableIndex">To be added.</param><summary>Method that is called after index throttling is stopped..</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _DidFinishThrottle (ICSSearchableIndexDelegate This, CSSearchableIndex searchableIndex)
		{
			var searchableIndex__handle__ = searchableIndex!.GetNonNullHandle (nameof (searchableIndex));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("searchableIndexDidFinishThrottle:"), searchableIndex__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (searchableIndex);
		}
		/// <param name="searchableIndex">To be added.</param><param name="itemIdentifier">To be added.</param><param name="typeIdentifier">To be added.</param><param name="outError">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("dataForSearchableIndex:itemIdentifier:typeIdentifier:error:")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual NSData? GetData (CSSearchableIndex searchableIndex, string itemIdentifier, string typeIdentifier, out NSError outError)
		{
			return _GetData (this, searchableIndex, itemIdentifier, typeIdentifier, out outError);
		}
		/// <param name="searchableIndex">To be added.</param><param name="itemIdentifier">To be added.</param><param name="typeIdentifier">To be added.</param><param name="outError">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal unsafe static NSData? _GetData (ICSSearchableIndexDelegate This, CSSearchableIndex searchableIndex, string itemIdentifier, string typeIdentifier, out NSError outError)
		{
			var searchableIndex__handle__ = searchableIndex!.GetNonNullHandle (nameof (searchableIndex));
			if (itemIdentifier is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (itemIdentifier));
			if (typeIdentifier is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (typeIdentifier));
			NativeHandle outErrorValue = IntPtr.Zero;
			var nsitemIdentifier = CFString.CreateNative (itemIdentifier);
			var nstypeIdentifier = CFString.CreateNative (typeIdentifier);
			NSData? ret;
			ret =  Runtime.GetNSObject<NSData> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle_ref_NativeHandle (This.Handle, Selector.GetHandle ("dataForSearchableIndex:itemIdentifier:typeIdentifier:error:"), searchableIndex__handle__, nsitemIdentifier, nstypeIdentifier, &outErrorValue), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (searchableIndex);
			CFString.ReleaseNative (nsitemIdentifier);
			CFString.ReleaseNative (nstypeIdentifier);
			outError = Runtime.GetNSObject<NSError> (outErrorValue)!;
			return ret!;
		}
		/// <param name="searchableIndex">To be added.</param><param name="itemIdentifier">To be added.</param><param name="typeIdentifier">To be added.</param><param name="inPlace">To be added.</param><param name="outError">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("fileURLForSearchableIndex:itemIdentifier:typeIdentifier:inPlace:error:")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual NSUrl? GetFileUrl (CSSearchableIndex searchableIndex, string itemIdentifier, string typeIdentifier, bool inPlace, out NSError outError)
		{
			return _GetFileUrl (this, searchableIndex, itemIdentifier, typeIdentifier, inPlace, out outError);
		}
		/// <param name="searchableIndex">To be added.</param><param name="itemIdentifier">To be added.</param><param name="typeIdentifier">To be added.</param><param name="inPlace">To be added.</param><param name="outError">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal unsafe static NSUrl? _GetFileUrl (ICSSearchableIndexDelegate This, CSSearchableIndex searchableIndex, string itemIdentifier, string typeIdentifier, bool inPlace, out NSError outError)
		{
			var searchableIndex__handle__ = searchableIndex!.GetNonNullHandle (nameof (searchableIndex));
			if (itemIdentifier is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (itemIdentifier));
			if (typeIdentifier is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (typeIdentifier));
			NativeHandle outErrorValue = IntPtr.Zero;
			var nsitemIdentifier = CFString.CreateNative (itemIdentifier);
			var nstypeIdentifier = CFString.CreateNative (typeIdentifier);
			NSUrl? ret;
			ret =  Runtime.GetNSObject<NSUrl> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle_bool_ref_NativeHandle (This.Handle, Selector.GetHandle ("fileURLForSearchableIndex:itemIdentifier:typeIdentifier:inPlace:error:"), searchableIndex__handle__, nsitemIdentifier, nstypeIdentifier, inPlace ? (byte) 1 : (byte) 0, &outErrorValue), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (searchableIndex);
			CFString.ReleaseNative (nsitemIdentifier);
			CFString.ReleaseNative (nstypeIdentifier);
			outError = Runtime.GetNSObject<NSError> (outErrorValue)!;
			return ret!;
		}
		[global::Foundation.OptionalMember]
		[Export ("searchableItemsForIdentifiers:searchableItemsHandler:")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios18.4")]
		[SupportedOSPlatform ("macos15.4")]
		[SupportedOSPlatform ("maccatalyst18.4")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void GetSearchableItems (string[] identifiers, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDCSSearchableIndexDelegateGetSearchableItemsHandler))]CSSearchableIndexDelegateGetSearchableItemsHandler searchableItemsHandler)
		{
			_GetSearchableItems (this, identifiers, searchableItemsHandler);
		}
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios18.4")]
		[SupportedOSPlatform ("macos15.4")]
		[SupportedOSPlatform ("maccatalyst18.4")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal unsafe static void _GetSearchableItems (ICSSearchableIndexDelegate This, string[] identifiers, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDCSSearchableIndexDelegateGetSearchableItemsHandler))]CSSearchableIndexDelegateGetSearchableItemsHandler searchableItemsHandler)
		{
			if (identifiers is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (identifiers));
			if (searchableItemsHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (searchableItemsHandler));
			using var nsa_identifiers = NSArray.FromStrings (identifiers);
			using var block_searchableItemsHandler = Trampolines.SDCSSearchableIndexDelegateGetSearchableItemsHandler.CreateBlock (searchableItemsHandler);
			BlockLiteral *block_ptr_searchableItemsHandler = &block_searchableItemsHandler;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("searchableItemsForIdentifiers:searchableItemsHandler:"), nsa_identifiers.Handle, (IntPtr) block_ptr_searchableItemsHandler);
			GC.KeepAlive (This);
		}
		[global::Foundation.OptionalMember]
		[Export ("searchableItemsDidUpdate:")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios18.4")]
		[SupportedOSPlatform ("macos15.4")]
		[SupportedOSPlatform ("maccatalyst18.4")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidUpdate (CSSearchableItem[] items)
		{
			_DidUpdate (this, items);
		}
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios18.4")]
		[SupportedOSPlatform ("macos15.4")]
		[SupportedOSPlatform ("maccatalyst18.4")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _DidUpdate (ICSSearchableIndexDelegate This, CSSearchableItem[] items)
		{
			if (items is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (items));
			using var nsa_items = NSArray.FromNSObjects (items);
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("searchableItemsDidUpdate:"), nsa_items.Handle);
			GC.KeepAlive (This);
		}
		[DynamicDependencyAttribute ("DidFinishThrottle(CoreSpotlight.CSSearchableIndex)")]
		[DynamicDependencyAttribute ("DidThrottle(CoreSpotlight.CSSearchableIndex)")]
		[DynamicDependencyAttribute ("DidUpdate(CoreSpotlight.CSSearchableItem[])")]
		[DynamicDependencyAttribute ("GetData(CoreSpotlight.CSSearchableIndex,System.String,System.String,Foundation.NSError@)")]
		[DynamicDependencyAttribute ("GetFileUrl(CoreSpotlight.CSSearchableIndex,System.String,System.String,System.Boolean,Foundation.NSError@)")]
		[DynamicDependencyAttribute ("GetSearchableItems(System.String[],CoreSpotlight.CSSearchableIndexDelegateGetSearchableItemsHandler)")]
		[DynamicDependencyAttribute ("ReindexAllSearchableItems(CoreSpotlight.CSSearchableIndex,System.Action)")]
		[DynamicDependencyAttribute ("ReindexSearchableItems(CoreSpotlight.CSSearchableIndex,System.String[],System.Action)")]
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.Interfaces | DynamicallyAccessedMemberTypes.PublicConstructors, typeof (CSSearchableIndexDelegateWrapper))]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static ICSSearchableIndexDelegate ()
		{
			GC.KeepAlive (null);
		}
	}
	#pragma warning restore CS1573
	#pragma warning disable CS1573
	/// <summary>Extension methods to the <see cref="ICSSearchableIndexDelegate" /> interface to support all the methods from the CSSearchableIndexDelegate protocol.</summary>
	/// <remarks>
	///   <para>The extension methods for <see cref="ICSSearchableIndexDelegate" /> interface allow developers to treat instances of the interface as having all the optional methods of the original CSSearchableIndexDelegate protocol. Since the interface only contains the required members, these extension methods allow developers to call the optional members of the protocol.</para>
	/// </remarks>
	public unsafe static partial class CSSearchableIndexDelegate_Extensions {
		/// <param name="searchableIndex">To be added.</param><summary>Method that is called after index throttling starts.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void DidThrottle (this ICSSearchableIndexDelegate This, CSSearchableIndex searchableIndex)
		{
			var searchableIndex__handle__ = searchableIndex!.GetNonNullHandle (nameof (searchableIndex));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("searchableIndexDidThrottle:"), searchableIndex__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (searchableIndex);
		}
		/// <param name="searchableIndex">To be added.</param><summary>Method that is called after index throttling is stopped..</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void DidFinishThrottle (this ICSSearchableIndexDelegate This, CSSearchableIndex searchableIndex)
		{
			var searchableIndex__handle__ = searchableIndex!.GetNonNullHandle (nameof (searchableIndex));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("searchableIndexDidFinishThrottle:"), searchableIndex__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (searchableIndex);
		}
		/// <param name="searchableIndex">To be added.</param><param name="itemIdentifier">To be added.</param><param name="typeIdentifier">To be added.</param><param name="outError">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static NSData? GetData (this ICSSearchableIndexDelegate This, CSSearchableIndex searchableIndex, string itemIdentifier, string typeIdentifier, out NSError outError)
		{
			var searchableIndex__handle__ = searchableIndex!.GetNonNullHandle (nameof (searchableIndex));
			if (itemIdentifier is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (itemIdentifier));
			if (typeIdentifier is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (typeIdentifier));
			NativeHandle outErrorValue = IntPtr.Zero;
			var nsitemIdentifier = CFString.CreateNative (itemIdentifier);
			var nstypeIdentifier = CFString.CreateNative (typeIdentifier);
			NSData? ret;
			ret =  Runtime.GetNSObject<NSData> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle_ref_NativeHandle (This.Handle, Selector.GetHandle ("dataForSearchableIndex:itemIdentifier:typeIdentifier:error:"), searchableIndex__handle__, nsitemIdentifier, nstypeIdentifier, &outErrorValue), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (searchableIndex);
			CFString.ReleaseNative (nsitemIdentifier);
			CFString.ReleaseNative (nstypeIdentifier);
			outError = Runtime.GetNSObject<NSError> (outErrorValue)!;
			return ret!;
		}
		/// <param name="searchableIndex">To be added.</param><param name="itemIdentifier">To be added.</param><param name="typeIdentifier">To be added.</param><param name="inPlace">To be added.</param><param name="outError">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static NSUrl? GetFileUrl (this ICSSearchableIndexDelegate This, CSSearchableIndex searchableIndex, string itemIdentifier, string typeIdentifier, bool inPlace, out NSError outError)
		{
			var searchableIndex__handle__ = searchableIndex!.GetNonNullHandle (nameof (searchableIndex));
			if (itemIdentifier is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (itemIdentifier));
			if (typeIdentifier is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (typeIdentifier));
			NativeHandle outErrorValue = IntPtr.Zero;
			var nsitemIdentifier = CFString.CreateNative (itemIdentifier);
			var nstypeIdentifier = CFString.CreateNative (typeIdentifier);
			NSUrl? ret;
			ret =  Runtime.GetNSObject<NSUrl> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle_bool_ref_NativeHandle (This.Handle, Selector.GetHandle ("fileURLForSearchableIndex:itemIdentifier:typeIdentifier:inPlace:error:"), searchableIndex__handle__, nsitemIdentifier, nstypeIdentifier, inPlace ? (byte) 1 : (byte) 0, &outErrorValue), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (searchableIndex);
			CFString.ReleaseNative (nsitemIdentifier);
			CFString.ReleaseNative (nstypeIdentifier);
			outError = Runtime.GetNSObject<NSError> (outErrorValue)!;
			return ret!;
		}
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios18.4")]
		[SupportedOSPlatform ("macos15.4")]
		[SupportedOSPlatform ("maccatalyst18.4")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static void GetSearchableItems (this ICSSearchableIndexDelegate This, string[] identifiers, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDCSSearchableIndexDelegateGetSearchableItemsHandler))]CSSearchableIndexDelegateGetSearchableItemsHandler searchableItemsHandler)
		{
			if (identifiers is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (identifiers));
			if (searchableItemsHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (searchableItemsHandler));
			using var nsa_identifiers = NSArray.FromStrings (identifiers);
			using var block_searchableItemsHandler = Trampolines.SDCSSearchableIndexDelegateGetSearchableItemsHandler.CreateBlock (searchableItemsHandler);
			BlockLiteral *block_ptr_searchableItemsHandler = &block_searchableItemsHandler;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("searchableItemsForIdentifiers:searchableItemsHandler:"), nsa_identifiers.Handle, (IntPtr) block_ptr_searchableItemsHandler);
			GC.KeepAlive (This);
		}
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios18.4")]
		[SupportedOSPlatform ("macos15.4")]
		[SupportedOSPlatform ("maccatalyst18.4")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void DidUpdate (this ICSSearchableIndexDelegate This, CSSearchableItem[] items)
		{
			if (items is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (items));
			using var nsa_items = NSArray.FromNSObjects (items);
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("searchableItemsDidUpdate:"), nsa_items.Handle);
			GC.KeepAlive (This);
		}
	}
	#pragma warning restore CS1573
	internal unsafe sealed class CSSearchableIndexDelegateWrapper : BaseWrapper, ICSSearchableIndexDelegate {
		public CSSearchableIndexDelegateWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.PublicConstructors, typeof (CSSearchableIndexDelegateWrapper))]
		static CSSearchableIndexDelegateWrapper ()
		{
			GC.KeepAlive (null);
		}
		/// <param name="searchableIndex">To be added.</param><param name="acknowledgementHandler">To be added.</param><summary>Reindexes all items in the specified index and runs <paramref name="acknowledgementHandler" /> when finished.</summary><remarks>To be added.</remarks>
		[Export ("searchableIndex:reindexAllSearchableItemsWithAcknowledgementHandler:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe void ReindexAllSearchableItems (CSSearchableIndex searchableIndex, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDAction))]global::System.Action acknowledgementHandler)
		{
			var searchableIndex__handle__ = searchableIndex!.GetNonNullHandle (nameof (searchableIndex));
			if (acknowledgementHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (acknowledgementHandler));
			using var block_acknowledgementHandler = Trampolines.SDAction.CreateBlock (acknowledgementHandler);
			BlockLiteral *block_ptr_acknowledgementHandler = &block_acknowledgementHandler;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("searchableIndex:reindexAllSearchableItemsWithAcknowledgementHandler:"), searchableIndex__handle__, (IntPtr) block_ptr_acknowledgementHandler);
			GC.KeepAlive (searchableIndex);
		}
		/// <param name="searchableIndex">To be added.</param><param name="identifiers">To be added.</param><param name="acknowledgementHandler">To be added.</param><summary>Reindexes the specified items in the specified index and runs <paramref name="acknowledgementHandler" /> when finished.</summary><remarks>To be added.</remarks>
		[Export ("searchableIndex:reindexSearchableItemsWithIdentifiers:acknowledgementHandler:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe void ReindexSearchableItems (CSSearchableIndex searchableIndex, string[] identifiers, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDAction))]global::System.Action acknowledgementHandler)
		{
			var searchableIndex__handle__ = searchableIndex!.GetNonNullHandle (nameof (searchableIndex));
			if (identifiers is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (identifiers));
			if (acknowledgementHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (acknowledgementHandler));
			using var nsa_identifiers = NSArray.FromStrings (identifiers);
			using var block_acknowledgementHandler = Trampolines.SDAction.CreateBlock (acknowledgementHandler);
			BlockLiteral *block_ptr_acknowledgementHandler = &block_acknowledgementHandler;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("searchableIndex:reindexSearchableItemsWithIdentifiers:acknowledgementHandler:"), searchableIndex__handle__, nsa_identifiers.Handle, (IntPtr) block_ptr_acknowledgementHandler);
			GC.KeepAlive (searchableIndex);
		}
	}
}
namespace CoreSpotlight {
	/// <summary>Delegate object providing members that are called when reindexing the index.</summary><related type="externalDocumentation" href="https://developer.apple.com/library/ios/documentation/CoreSpotlight/Reference/CSSearchableIndexDelegate_Protocol/index.html">Apple documentation for <c>CSSearchableIndexDelegate</c></related>
	[Protocol()]
	[Register("Microsoft_iOS__CoreSpotlight_CSSearchableIndexDelegate", false)]
	[Model]
	[UnsupportedOSPlatform ("tvos")]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	public unsafe abstract partial class CSSearchableIndexDelegate : NSObject, ICSSearchableIndexDelegate {
		/// <summary>Creates a new <see cref="CSSearchableIndexDelegate" /> with default values.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		protected CSSearchableIndexDelegate () : base (NSObjectFlag.Empty)
		{
			IsDirectBinding = false;
			unsafe {
			var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
			InitializeHandle (global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (&__objc_super__, global::ObjCRuntime.Selector.GetHandle ("init")), "init");
			GC.KeepAlive (this);
			}
		}

		/// <summary>Constructor to call on derived classes to skip initialization and merely allocate the object.</summary>
		/// <param name="t">Unused sentinel value, pass NSObjectFlag.Empty.</param>
		/// <remarks>
		///     <para>
		///         This constructor should be called by derived classes when they completely construct the object in managed code and merely want the runtime to allocate and initialize the <see cref="Foundation.NSObject" />.
		///         This is required to implement the two-step initialization process that Objective-C uses, the first step is to perform the object allocation, the second step is to initialize the object.
		///         When developers invoke this constructor, they take advantage of a direct path that goes all the way up to <see cref="Foundation.NSObject" /> to merely allocate the object's memory and bind the Objective-C and C# objects together.
		///         The actual initialization of the object is up to the developer.
		///     </para>
		///     <para>
		///         This constructor is typically used by the binding generator to allocate the object, but prevent the actual initialization to take place.
		///         Once the allocation has taken place, the constructor has to initialize the object.
		///         With constructors generated by the binding generator this means that it manually invokes one of the "init" methods to initialize the object.
		///     </para>
		///     <para>It is the developer's responsibility to completely initialize the object if they chain up using this constructor chain.</para>
		///     <para>
		///         In general, if the developer's constructor invokes the corresponding base implementation, then it should also call an Objective-C init method.
		///         If this is not the case, developers should instead chain to the proper constructor in their class.
		///     </para>
		///     <para>
		///         The argument value is ignored and merely ensures that the only code that is executed is the construction phase is the basic <see cref="Foundation.NSObject" /> allocation and runtime type registration.
		///         Typically the chaining would look like this:
		///     </para>
		///     <example>
		///             <code lang="csharp lang-csharp"><![CDATA[
		/// //
		/// // The NSObjectFlag constructor merely allocates the object and registers the C# class with the Objective-C runtime if necessary.
		/// // No actual initXxx method is invoked, that is done later in the constructor
		/// //
		/// // This is taken from the iOS SDK's source code for the UIView class:
		/// //
		/// [Export ("initWithFrame:")]
		/// public UIView (CGRect frame) : base (NSObjectFlag.Empty)
		/// {
		///     // Invoke the init method now.
		///     var initWithFrame = new Selector ("initWithFrame:").Handle;
		///     if (IsDirectBinding) {
		///         Handle = ObjCRuntime.Messaging.IntPtr_objc_msgSend_CGRect (this.Handle, initWithFrame, frame);
		///     } else {
		///         unsafe {
		///             var __objc_super__ = new ObjCRuntime.ObjCSuper (this);
		///             Handle = ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper_CGRect (&__objc_super__, initWithFrame, frame);
		///         }
		///         GC.KeepAlive (this);
		///     }
		/// }
		/// ]]></code>
		///     </example>
		/// </remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected CSSearchableIndexDelegate (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = false;
		}

		/// <summary>A constructor used when creating managed representations of unmanaged objects. Called by the runtime.</summary>
		/// <param name="handle">Pointer (handle) to the unmanaged object.</param>
		/// <remarks>
		///     <para>
		///         This constructor is invoked by the runtime infrastructure (<see cref="ObjCRuntime.Runtime.GetNSObject(System.IntPtr)" />) to create a new managed representation for a pointer to an unmanaged Objective-C object.
		///         Developers should not invoke this method directly, instead they should call <see cref="ObjCRuntime.Runtime.GetNSObject(System.IntPtr)" /> as it will prevent two instances of a managed object pointing to the same native object.
		///     </para>
		/// </remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal CSSearchableIndexDelegate (NativeHandle handle) : base (handle)
		{
			IsDirectBinding = false;
		}

		/// <param name="searchableIndex">To be added.</param><summary>Method that is called after index throttling is stopped..</summary><remarks>To be added.</remarks>
		[Export ("searchableIndexDidFinishThrottle:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidFinishThrottle (CSSearchableIndex searchableIndex)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="searchableIndex">To be added.</param><summary>Method that is called after index throttling starts.</summary><remarks>To be added.</remarks>
		[Export ("searchableIndexDidThrottle:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidThrottle (CSSearchableIndex searchableIndex)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("searchableItemsDidUpdate:")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios18.4")]
		[SupportedOSPlatform ("macos15.4")]
		[SupportedOSPlatform ("maccatalyst18.4")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidUpdate (CSSearchableItem[] items)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="searchableIndex">To be added.</param><param name="itemIdentifier">To be added.</param><param name="typeIdentifier">To be added.</param><param name="outError">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("dataForSearchableIndex:itemIdentifier:typeIdentifier:error:")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual NSData? GetData (CSSearchableIndex searchableIndex, string itemIdentifier, string typeIdentifier, out NSError outError)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="searchableIndex">To be added.</param><param name="itemIdentifier">To be added.</param><param name="typeIdentifier">To be added.</param><param name="inPlace">To be added.</param><param name="outError">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("fileURLForSearchableIndex:itemIdentifier:typeIdentifier:inPlace:error:")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual NSUrl? GetFileUrl (CSSearchableIndex searchableIndex, string itemIdentifier, string typeIdentifier, bool inPlace, out NSError outError)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("searchableItemsForIdentifiers:searchableItemsHandler:")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios18.4")]
		[SupportedOSPlatform ("macos15.4")]
		[SupportedOSPlatform ("maccatalyst18.4")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void GetSearchableItems (string[] identifiers, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDCSSearchableIndexDelegateGetSearchableItemsHandler))]CSSearchableIndexDelegateGetSearchableItemsHandler searchableItemsHandler)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="searchableIndex">To be added.</param><param name="acknowledgementHandler">To be added.</param><summary>Reindexes all items in the specified index and runs <paramref name="acknowledgementHandler" /> when finished.</summary><remarks>To be added.</remarks>
		[Export ("searchableIndex:reindexAllSearchableItemsWithAcknowledgementHandler:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void ReindexAllSearchableItems (CSSearchableIndex searchableIndex, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDAction))]global::System.Action acknowledgementHandler)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="searchableIndex">To be added.</param><param name="identifiers">To be added.</param><param name="acknowledgementHandler">To be added.</param><summary>Reindexes the specified items in the specified index and runs <paramref name="acknowledgementHandler" /> when finished.</summary><remarks>To be added.</remarks>
		[Export ("searchableIndex:reindexSearchableItemsWithIdentifiers:acknowledgementHandler:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void ReindexSearchableItems (CSSearchableIndex searchableIndex, string[] identifiers, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDAction))]global::System.Action acknowledgementHandler)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
	} /* class CSSearchableIndexDelegate */
}
