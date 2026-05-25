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
namespace UIKit {
	#pragma warning disable CS1573
	/// <summary>This interface represents the Objective-C protocol <c>UISearchBarDelegate</c>.</summary>
	/// <remarks>
	///   <para>A class that implements this interface (and subclasses <see cref="NSObject" />) will be exported to Objective-C as implementing the Objective-C protocol this interface represents.</para>
	///   <para>A class may also implement members from this interface to implement members from the protocol.</para>
	/// </remarks>
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("tvos")]
	[Protocol (Name = "UISearchBarDelegate", WrapperType = typeof (UISearchBarDelegateWrapper))]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "ShouldBeginEditing", Selector = "searchBarShouldBeginEditing:", ReturnType = typeof (bool), ParameterType = new Type [] { typeof (UISearchBar) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "OnEditingStarted", Selector = "searchBarTextDidBeginEditing:", ParameterType = new Type [] { typeof (UISearchBar) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "ShouldEndEditing", Selector = "searchBarShouldEndEditing:", ReturnType = typeof (bool), ParameterType = new Type [] { typeof (UISearchBar) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "OnEditingStopped", Selector = "searchBarTextDidEndEditing:", ParameterType = new Type [] { typeof (UISearchBar) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "TextChanged", Selector = "searchBar:textDidChange:", ParameterType = new Type [] { typeof (UISearchBar), typeof (string) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "ShouldChangeTextInRange", Selector = "searchBar:shouldChangeTextInRange:replacementText:", ReturnType = typeof (bool), ParameterType = new Type [] { typeof (UISearchBar), typeof (NSRange), typeof (string) }, ParameterByRef = new bool [] { false, false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "SearchButtonClicked", Selector = "searchBarSearchButtonClicked:", ParameterType = new Type [] { typeof (UISearchBar) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "SelectedScopeButtonIndexChanged", Selector = "searchBar:selectedScopeButtonIndexDidChange:", ParameterType = new Type [] { typeof (UISearchBar), typeof (IntPtr) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "ShouldChangeText", Selector = "searchBar:shouldChangeTextInRanges:replacementText:", ReturnType = typeof (bool), ParameterType = new Type [] { typeof (UISearchBar), typeof (NSValue[]), typeof (string) }, ParameterByRef = new bool [] { false, false, false })]
	public partial interface IUISearchBarDelegate : INativeObject, IDisposable, 
		UIKit.IUIBarPositioningDelegate
	{
		/// <param name="searchBar">To be added.</param><summary>Whether editing of the search text should be allowed.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("searchBarShouldBeginEditing:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool ShouldBeginEditing (UISearchBar searchBar)
		{
			return _ShouldBeginEditing (this, searchBar);
		}
		/// <param name="searchBar">To be added.</param><summary>Whether editing of the search text should be allowed.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static bool _ShouldBeginEditing (IUISearchBarDelegate This, UISearchBar searchBar)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var searchBar__handle__ = searchBar!.GetNonNullHandle (nameof (searchBar));
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("searchBarShouldBeginEditing:"), searchBar__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (searchBar);
			return ret != 0;
		}
		/// <param name="searchBar">To be added.</param><summary>Indicates that the user has begun editing the search text.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("searchBarTextDidBeginEditing:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void OnEditingStarted (UISearchBar searchBar)
		{
			_OnEditingStarted (this, searchBar);
		}
		/// <param name="searchBar">To be added.</param><summary>Indicates that the user has begun editing the search text.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _OnEditingStarted (IUISearchBarDelegate This, UISearchBar searchBar)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var searchBar__handle__ = searchBar!.GetNonNullHandle (nameof (searchBar));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("searchBarTextDidBeginEditing:"), searchBar__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (searchBar);
		}
		/// <param name="searchBar">To be added.</param><summary>Whether the editing of the search text should end.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("searchBarShouldEndEditing:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool ShouldEndEditing (UISearchBar searchBar)
		{
			return _ShouldEndEditing (this, searchBar);
		}
		/// <param name="searchBar">To be added.</param><summary>Whether the editing of the search text should end.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static bool _ShouldEndEditing (IUISearchBarDelegate This, UISearchBar searchBar)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var searchBar__handle__ = searchBar!.GetNonNullHandle (nameof (searchBar));
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("searchBarShouldEndEditing:"), searchBar__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (searchBar);
			return ret != 0;
		}
		/// <param name="searchBar">To be added.</param><summary>Indicates that the user has stopped editing the text field.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("searchBarTextDidEndEditing:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void OnEditingStopped (UISearchBar searchBar)
		{
			_OnEditingStopped (this, searchBar);
		}
		/// <param name="searchBar">To be added.</param><summary>Indicates that the user has stopped editing the text field.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _OnEditingStopped (IUISearchBarDelegate This, UISearchBar searchBar)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var searchBar__handle__ = searchBar!.GetNonNullHandle (nameof (searchBar));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("searchBarTextDidEndEditing:"), searchBar__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (searchBar);
		}
		/// <param name="searchBar">To be added.</param><param name="searchText">To be added.</param><summary>Indicates that the search text has changed.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("searchBar:textDidChange:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void TextChanged (UISearchBar searchBar, string searchText)
		{
			_TextChanged (this, searchBar, searchText);
		}
		/// <param name="searchBar">To be added.</param><param name="searchText">To be added.</param><summary>Indicates that the search text has changed.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _TextChanged (IUISearchBarDelegate This, UISearchBar searchBar, string searchText)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var searchBar__handle__ = searchBar!.GetNonNullHandle (nameof (searchBar));
			if (searchText is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (searchText));
			var nssearchText = CFString.CreateNative (searchText);
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("searchBar:textDidChange:"), searchBar__handle__, nssearchText);
			GC.KeepAlive (This);
			GC.KeepAlive (searchBar);
			CFString.ReleaseNative (nssearchText);
		}
		/// <param name="searchBar">To be added.</param><param name="range">To be added.</param><param name="text">To be added.</param><summary>Whether the text in the specified range should be replaced with the specified text.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("searchBar:shouldChangeTextInRange:replacementText:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool ShouldChangeTextInRange (UISearchBar searchBar, NSRange range, string text)
		{
			return _ShouldChangeTextInRange (this, searchBar, range, text);
		}
		/// <param name="searchBar">To be added.</param><param name="range">To be added.</param><param name="text">To be added.</param><summary>Whether the text in the specified range should be replaced with the specified text.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static bool _ShouldChangeTextInRange (IUISearchBarDelegate This, UISearchBar searchBar, NSRange range, string text)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var searchBar__handle__ = searchBar!.GetNonNullHandle (nameof (searchBar));
			if (text is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (text));
			var nstext = CFString.CreateNative (text);
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_NSRange_NativeHandle (This.Handle, Selector.GetHandle ("searchBar:shouldChangeTextInRange:replacementText:"), searchBar__handle__, range, nstext);
			GC.KeepAlive (This);
			GC.KeepAlive (searchBar);
			CFString.ReleaseNative (nstext);
			return ret != 0;
		}
		/// <param name="searchBar">To be added.</param><summary>Indicates that the search button was tapped.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("searchBarSearchButtonClicked:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SearchButtonClicked (UISearchBar searchBar)
		{
			_SearchButtonClicked (this, searchBar);
		}
		/// <param name="searchBar">To be added.</param><summary>Indicates that the search button was tapped.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SearchButtonClicked (IUISearchBarDelegate This, UISearchBar searchBar)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var searchBar__handle__ = searchBar!.GetNonNullHandle (nameof (searchBar));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("searchBarSearchButtonClicked:"), searchBar__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (searchBar);
		}
		/// <param name="searchBar">To be added.</param><param name="selectedScope">To be added.</param><summary>Indicates that the scope button selection has changed.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("searchBar:selectedScopeButtonIndexDidChange:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SelectedScopeButtonIndexChanged (UISearchBar searchBar, nint selectedScope)
		{
			_SelectedScopeButtonIndexChanged (this, searchBar, selectedScope);
		}
		/// <param name="searchBar">To be added.</param><param name="selectedScope">To be added.</param><summary>Indicates that the scope button selection has changed.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SelectedScopeButtonIndexChanged (IUISearchBarDelegate This, UISearchBar searchBar, nint selectedScope)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var searchBar__handle__ = searchBar!.GetNonNullHandle (nameof (searchBar));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_IntPtr (This.Handle, Selector.GetHandle ("searchBar:selectedScopeButtonIndexDidChange:"), searchBar__handle__, selectedScope);
			GC.KeepAlive (This);
			GC.KeepAlive (searchBar);
		}
		[global::Foundation.OptionalMember]
		[Export ("searchBar:shouldChangeTextInRanges:replacementText:")]
		[SupportedOSPlatform ("maccatalyst26.0")]
		[SupportedOSPlatform ("tvos26.0")]
		[SupportedOSPlatform ("ios26.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool ShouldChangeText (UISearchBar searchBar, NSValue[] ranges, string replacementText)
		{
			return _ShouldChangeText (this, searchBar, ranges, replacementText);
		}
		[SupportedOSPlatform ("maccatalyst26.0")]
		[SupportedOSPlatform ("tvos26.0")]
		[SupportedOSPlatform ("ios26.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static bool _ShouldChangeText (IUISearchBarDelegate This, UISearchBar searchBar, NSValue[] ranges, string replacementText)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var searchBar__handle__ = searchBar!.GetNonNullHandle (nameof (searchBar));
			if (ranges is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (ranges));
			if (replacementText is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (replacementText));
			using var nsa_ranges = NSArray.FromNSObjects (ranges);
			var nsreplacementText = CFString.CreateNative (replacementText);
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("searchBar:shouldChangeTextInRanges:replacementText:"), searchBar__handle__, nsa_ranges.Handle, nsreplacementText);
			GC.KeepAlive (This);
			GC.KeepAlive (searchBar);
			CFString.ReleaseNative (nsreplacementText);
			return ret != 0;
		}
		[DynamicDependencyAttribute ("OnEditingStarted(UIKit.UISearchBar)")]
		[DynamicDependencyAttribute ("OnEditingStopped(UIKit.UISearchBar)")]
		[DynamicDependencyAttribute ("SearchButtonClicked(UIKit.UISearchBar)")]
		[DynamicDependencyAttribute ("SelectedScopeButtonIndexChanged(UIKit.UISearchBar,System.IntPtr)")]
		[DynamicDependencyAttribute ("ShouldBeginEditing(UIKit.UISearchBar)")]
		[DynamicDependencyAttribute ("ShouldChangeText(UIKit.UISearchBar,Foundation.NSValue[],System.String)")]
		[DynamicDependencyAttribute ("ShouldChangeTextInRange(UIKit.UISearchBar,Foundation.NSRange,System.String)")]
		[DynamicDependencyAttribute ("ShouldEndEditing(UIKit.UISearchBar)")]
		[DynamicDependencyAttribute ("TextChanged(UIKit.UISearchBar,System.String)")]
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.Interfaces | DynamicallyAccessedMemberTypes.PublicConstructors, typeof (UISearchBarDelegateWrapper))]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static IUISearchBarDelegate ()
		{
			GC.KeepAlive (null);
		}
	}
	#pragma warning restore CS1573
	#pragma warning disable CS1573
	/// <summary>Extension methods to the <see cref="IUISearchBarDelegate" /> interface to support all the methods from the UISearchBarDelegate protocol.</summary>
	/// <remarks>
	///   <para>The extension methods for <see cref="IUISearchBarDelegate" /> interface allow developers to treat instances of the interface as having all the optional methods of the original UISearchBarDelegate protocol. Since the interface only contains the required members, these extension methods allow developers to call the optional members of the protocol.</para>
	/// </remarks>
	public unsafe static partial class UISearchBarDelegate_Extensions {
		/// <param name="searchBar">To be added.</param><summary>Whether editing of the search text should be allowed.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool ShouldBeginEditing (this IUISearchBarDelegate This, UISearchBar searchBar)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var searchBar__handle__ = searchBar!.GetNonNullHandle (nameof (searchBar));
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("searchBarShouldBeginEditing:"), searchBar__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (searchBar);
			return ret != 0;
		}
		/// <param name="searchBar">To be added.</param><summary>Indicates that the user has begun editing the search text.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void OnEditingStarted (this IUISearchBarDelegate This, UISearchBar searchBar)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var searchBar__handle__ = searchBar!.GetNonNullHandle (nameof (searchBar));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("searchBarTextDidBeginEditing:"), searchBar__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (searchBar);
		}
		/// <param name="searchBar">To be added.</param><summary>Whether the editing of the search text should end.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool ShouldEndEditing (this IUISearchBarDelegate This, UISearchBar searchBar)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var searchBar__handle__ = searchBar!.GetNonNullHandle (nameof (searchBar));
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("searchBarShouldEndEditing:"), searchBar__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (searchBar);
			return ret != 0;
		}
		/// <param name="searchBar">To be added.</param><summary>Indicates that the user has stopped editing the text field.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void OnEditingStopped (this IUISearchBarDelegate This, UISearchBar searchBar)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var searchBar__handle__ = searchBar!.GetNonNullHandle (nameof (searchBar));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("searchBarTextDidEndEditing:"), searchBar__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (searchBar);
		}
		/// <param name="searchBar">To be added.</param><param name="searchText">To be added.</param><summary>Indicates that the search text has changed.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void TextChanged (this IUISearchBarDelegate This, UISearchBar searchBar, string searchText)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var searchBar__handle__ = searchBar!.GetNonNullHandle (nameof (searchBar));
			if (searchText is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (searchText));
			var nssearchText = CFString.CreateNative (searchText);
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("searchBar:textDidChange:"), searchBar__handle__, nssearchText);
			GC.KeepAlive (This);
			GC.KeepAlive (searchBar);
			CFString.ReleaseNative (nssearchText);
		}
		/// <param name="searchBar">To be added.</param><param name="range">To be added.</param><param name="text">To be added.</param><summary>Whether the text in the specified range should be replaced with the specified text.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool ShouldChangeTextInRange (this IUISearchBarDelegate This, UISearchBar searchBar, NSRange range, string text)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var searchBar__handle__ = searchBar!.GetNonNullHandle (nameof (searchBar));
			if (text is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (text));
			var nstext = CFString.CreateNative (text);
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_NSRange_NativeHandle (This.Handle, Selector.GetHandle ("searchBar:shouldChangeTextInRange:replacementText:"), searchBar__handle__, range, nstext);
			GC.KeepAlive (This);
			GC.KeepAlive (searchBar);
			CFString.ReleaseNative (nstext);
			return ret != 0;
		}
		/// <param name="searchBar">To be added.</param><summary>Indicates that the search button was tapped.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void SearchButtonClicked (this IUISearchBarDelegate This, UISearchBar searchBar)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var searchBar__handle__ = searchBar!.GetNonNullHandle (nameof (searchBar));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("searchBarSearchButtonClicked:"), searchBar__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (searchBar);
		}
		/// <param name="searchBar">To be added.</param><param name="selectedScope">To be added.</param><summary>Indicates that the scope button selection has changed.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void SelectedScopeButtonIndexChanged (this IUISearchBarDelegate This, UISearchBar searchBar, nint selectedScope)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var searchBar__handle__ = searchBar!.GetNonNullHandle (nameof (searchBar));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_IntPtr (This.Handle, Selector.GetHandle ("searchBar:selectedScopeButtonIndexDidChange:"), searchBar__handle__, selectedScope);
			GC.KeepAlive (This);
			GC.KeepAlive (searchBar);
		}
		[SupportedOSPlatform ("maccatalyst26.0")]
		[SupportedOSPlatform ("tvos26.0")]
		[SupportedOSPlatform ("ios26.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool ShouldChangeText (this IUISearchBarDelegate This, UISearchBar searchBar, NSValue[] ranges, string replacementText)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var searchBar__handle__ = searchBar!.GetNonNullHandle (nameof (searchBar));
			if (ranges is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (ranges));
			if (replacementText is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (replacementText));
			using var nsa_ranges = NSArray.FromNSObjects (ranges);
			var nsreplacementText = CFString.CreateNative (replacementText);
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("searchBar:shouldChangeTextInRanges:replacementText:"), searchBar__handle__, nsa_ranges.Handle, nsreplacementText);
			GC.KeepAlive (This);
			GC.KeepAlive (searchBar);
			CFString.ReleaseNative (nsreplacementText);
			return ret != 0;
		}
	}
	#pragma warning restore CS1573
	internal unsafe sealed class UISearchBarDelegateWrapper : BaseWrapper, IUISearchBarDelegate {
		public UISearchBarDelegateWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.PublicConstructors, typeof (UISearchBarDelegateWrapper))]
		static UISearchBarDelegateWrapper ()
		{
			GC.KeepAlive (null);
		}
	}
}
namespace UIKit {
	/// <summary>
	///   <para>This is a class that implements the interface <see cref="IUISearchBarDelegate" /> (for the protocol <c>UISearchBarDelegate</c>).</para>
	///   <para>Subclass this class to easily create a type that implements the protocol.</para>
	///   <para>An alternative is to create a subclass of <see cref="NSObject" /> and then implemented the interface <see cref="IUISearchBarDelegate" />.</para>
	/// </summary>
	[Protocol()]
	[Register("Microsoft_tvOS__UIKit_UISearchBarDelegate", false)]
	[Model]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("tvos")]
	public unsafe partial class UISearchBarDelegate : UIBarPositioningDelegate, IUISearchBarDelegate {
		/// <summary>Creates a new <see cref="UISearchBarDelegate" /> with default values.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public UISearchBarDelegate () : base (NSObjectFlag.Empty)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
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
		protected UISearchBarDelegate (NSObjectFlag t) : base (t)
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
		protected internal UISearchBarDelegate (NativeHandle handle) : base (handle)
		{
			IsDirectBinding = false;
		}

		/// <param name="searchBar">To be added.</param><summary>Indicates that the user has begun editing the search text.</summary><remarks>To be added.</remarks>
		[Export ("searchBarTextDidBeginEditing:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void OnEditingStarted (UISearchBar searchBar)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="searchBar">To be added.</param><summary>Indicates that the user has stopped editing the text field.</summary><remarks>To be added.</remarks>
		[Export ("searchBarTextDidEndEditing:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void OnEditingStopped (UISearchBar searchBar)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="searchBar">To be added.</param><summary>Indicates that the search button was tapped.</summary><remarks>To be added.</remarks>
		[Export ("searchBarSearchButtonClicked:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SearchButtonClicked (UISearchBar searchBar)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="searchBar">To be added.</param><param name="selectedScope">To be added.</param><summary>Indicates that the scope button selection has changed.</summary><remarks>To be added.</remarks>
		[Export ("searchBar:selectedScopeButtonIndexDidChange:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SelectedScopeButtonIndexChanged (UISearchBar searchBar, nint selectedScope)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="searchBar">To be added.</param><summary>Whether editing of the search text should be allowed.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("searchBarShouldBeginEditing:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool ShouldBeginEditing (UISearchBar searchBar)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("searchBar:shouldChangeTextInRanges:replacementText:")]
		[SupportedOSPlatform ("maccatalyst26.0")]
		[SupportedOSPlatform ("tvos26.0")]
		[SupportedOSPlatform ("ios26.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool ShouldChangeText (UISearchBar searchBar, NSValue[] ranges, string replacementText)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="searchBar">To be added.</param><param name="range">To be added.</param><param name="text">To be added.</param><summary>Whether the text in the specified range should be replaced with the specified text.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("searchBar:shouldChangeTextInRange:replacementText:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool ShouldChangeTextInRange (UISearchBar searchBar, NSRange range, string text)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="searchBar">To be added.</param><summary>Whether the editing of the search text should end.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("searchBarShouldEndEditing:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool ShouldEndEditing (UISearchBar searchBar)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="searchBar">To be added.</param><param name="searchText">To be added.</param><summary>Indicates that the search text has changed.</summary><remarks>To be added.</remarks>
		[Export ("searchBar:textDidChange:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void TextChanged (UISearchBar searchBar, string searchText)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
	} /* class UISearchBarDelegate */
}
