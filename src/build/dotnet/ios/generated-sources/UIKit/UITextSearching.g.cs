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
namespace UIKit {
	#pragma warning disable CS1573
	/// <summary>This interface represents the Objective-C protocol <c>UITextSearching</c>.</summary>
	/// <remarks>
	///   <para>A class that implements this interface (and subclasses <see cref="NSObject" />) will be exported to Objective-C as implementing the Objective-C protocol this interface represents.</para>
	///   <para>A class may also implement members from this interface to implement members from the protocol.</para>
	/// </remarks>
	[UnsupportedOSPlatform ("tvos")]
	[SupportedOSPlatform ("ios16.0")]
	[SupportedOSPlatform ("maccatalyst16.0")]
	[Protocol (Name = "UITextSearching", WrapperType = typeof (UITextSearchingWrapper))]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "Compare", Selector = "compareFoundRange:toRange:inDocument:", ReturnType = typeof (NSComparisonResult), ParameterType = new Type [] { typeof (UITextRange), typeof (UITextRange), typeof (INSCopying) }, ParameterByRef = new bool [] { false, false, false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "PerformTextSearch", Selector = "performTextSearchWithQueryString:usingOptions:resultAggregator:", ParameterType = new Type [] { typeof (string), typeof (UITextSearchOptions), typeof (IUITextSearchAggregator) }, ParameterByRef = new bool [] { false, false, false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "Decorate", Selector = "decorateFoundTextRange:inDocument:usingStyle:", ParameterType = new Type [] { typeof (UITextRange), typeof (INSCopying), typeof (UITextSearchFoundTextStyle) }, ParameterByRef = new bool [] { false, false, false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "ClearAllDecoratedFoundText", Selector = "clearAllDecoratedFoundText")]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "ShouldReplaceFoundText", Selector = "shouldReplaceFoundTextInRange:inDocument:withText:", ReturnType = typeof (bool), ParameterType = new Type [] { typeof (UITextRange), typeof (INSCopying), typeof (string) }, ParameterByRef = new bool [] { false, false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "ReplaceFoundText", Selector = "replaceFoundTextInRange:inDocument:withText:", ParameterType = new Type [] { typeof (UITextRange), typeof (INSCopying), typeof (string) }, ParameterByRef = new bool [] { false, false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "ReplaceAllOccurrences", Selector = "replaceAllOccurrencesOfQueryString:usingOptions:withText:", ParameterType = new Type [] { typeof (string), typeof (UITextSearchOptions), typeof (string) }, ParameterByRef = new bool [] { false, false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "WillHighlight", Selector = "willHighlightFoundTextRange:inDocument:", ParameterType = new Type [] { typeof (UITextRange), typeof (INSCopying) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "ScrollRangeToVisible", Selector = "scrollRangeToVisible:inDocument:", ParameterType = new Type [] { typeof (UITextRange), typeof (INSCopying) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "CompareOrder", Selector = "compareOrderFromDocument:toDocument:", ReturnType = typeof (NSComparisonResult), ParameterType = new Type [] { typeof (INSCopying), typeof (INSCopying) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "SelectedTextRange", Selector = "selectedTextRange", PropertyType = typeof (UITextRange), GetterSelector = "selectedTextRange", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = false, IsProperty = true, IsStatic = false, Name = "SupportsTextReplacement", Selector = "supportsTextReplacement", PropertyType = typeof (bool), GetterSelector = "supportsTextReplacement", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = false, IsProperty = true, IsStatic = false, Name = "SelectedTextSearchDocument", Selector = "selectedTextSearchDocument", PropertyType = typeof (INSCopying), GetterSelector = "selectedTextSearchDocument", ArgumentSemantic = ArgumentSemantic.None)]
	public partial interface IUITextSearching : INativeObject, IDisposable
	{
		[global::Foundation.RequiredMember]
		[Export ("compareFoundRange:toRange:inDocument:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSComparisonResult Compare (UITextRange foundRange, UITextRange toRange, INSCopying? document)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static NSComparisonResult _Compare (IUITextSearching This, UITextRange foundRange, UITextRange toRange, INSCopying? document)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var foundRange__handle__ = foundRange!.GetNonNullHandle (nameof (foundRange));
			var toRange__handle__ = toRange!.GetNonNullHandle (nameof (toRange));
			var document__handle__ = document.GetHandle ();
			NSComparisonResult ret;
			ret = (NSComparisonResult) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("compareFoundRange:toRange:inDocument:"), foundRange__handle__, toRange__handle__, document__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (foundRange);
			GC.KeepAlive (toRange);
			GC.KeepAlive (document);
			return ret!;
		}
		[global::Foundation.RequiredMember]
		[Export ("performTextSearchWithQueryString:usingOptions:resultAggregator:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void PerformTextSearch (string @string, UITextSearchOptions options, IUITextSearchAggregator aggregator)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _PerformTextSearch (IUITextSearching This, string @string, UITextSearchOptions options, IUITextSearchAggregator aggregator)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			if (@string is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (@string));
			var options__handle__ = options!.GetNonNullHandle (nameof (options));
			var aggregator__handle__ = aggregator!.GetNonNullHandle (nameof (aggregator));
			var nsstring = CFString.CreateNative (@string);
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("performTextSearchWithQueryString:usingOptions:resultAggregator:"), nsstring, options__handle__, aggregator__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (options);
			GC.KeepAlive (aggregator);
			CFString.ReleaseNative (nsstring);
		}
		[global::Foundation.RequiredMember]
		[Export ("decorateFoundTextRange:inDocument:usingStyle:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void Decorate (UITextRange foundRange, INSCopying? document, UITextSearchFoundTextStyle style)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _Decorate (IUITextSearching This, UITextRange foundRange, INSCopying? document, UITextSearchFoundTextStyle style)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var foundRange__handle__ = foundRange!.GetNonNullHandle (nameof (foundRange));
			var document__handle__ = document.GetHandle ();
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_IntPtr (This.Handle, Selector.GetHandle ("decorateFoundTextRange:inDocument:usingStyle:"), foundRange__handle__, document__handle__, (IntPtr) (long) style);
			GC.KeepAlive (This);
			GC.KeepAlive (foundRange);
			GC.KeepAlive (document);
		}
		[global::Foundation.RequiredMember]
		[Export ("clearAllDecoratedFoundText")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void ClearAllDecoratedFoundText ()
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _ClearAllDecoratedFoundText (IUITextSearching This)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			global::ObjCRuntime.Messaging.void_objc_msgSend (This.Handle, Selector.GetHandle ("clearAllDecoratedFoundText"));
			GC.KeepAlive (This);
		}
		[global::Foundation.OptionalMember]
		[Export ("shouldReplaceFoundTextInRange:inDocument:withText:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool ShouldReplaceFoundText (UITextRange range, INSCopying? document, string replacementText)
		{
			return _ShouldReplaceFoundText (this, range, document, replacementText);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static bool _ShouldReplaceFoundText (IUITextSearching This, UITextRange range, INSCopying? document, string replacementText)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var range__handle__ = range!.GetNonNullHandle (nameof (range));
			var document__handle__ = document.GetHandle ();
			if (replacementText is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (replacementText));
			var nsreplacementText = CFString.CreateNative (replacementText);
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("shouldReplaceFoundTextInRange:inDocument:withText:"), range__handle__, document__handle__, nsreplacementText);
			GC.KeepAlive (This);
			GC.KeepAlive (range);
			GC.KeepAlive (document);
			CFString.ReleaseNative (nsreplacementText);
			return ret != 0;
		}
		[global::Foundation.OptionalMember]
		[Export ("replaceFoundTextInRange:inDocument:withText:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void ReplaceFoundText (UITextRange range, INSCopying? document, string replacementText)
		{
			_ReplaceFoundText (this, range, document, replacementText);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _ReplaceFoundText (IUITextSearching This, UITextRange range, INSCopying? document, string replacementText)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var range__handle__ = range!.GetNonNullHandle (nameof (range));
			var document__handle__ = document.GetHandle ();
			if (replacementText is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (replacementText));
			var nsreplacementText = CFString.CreateNative (replacementText);
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("replaceFoundTextInRange:inDocument:withText:"), range__handle__, document__handle__, nsreplacementText);
			GC.KeepAlive (This);
			GC.KeepAlive (range);
			GC.KeepAlive (document);
			CFString.ReleaseNative (nsreplacementText);
		}
		[global::Foundation.OptionalMember]
		[Export ("replaceAllOccurrencesOfQueryString:usingOptions:withText:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void ReplaceAllOccurrences (string queryString, UITextSearchOptions options, string replacementText)
		{
			_ReplaceAllOccurrences (this, queryString, options, replacementText);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _ReplaceAllOccurrences (IUITextSearching This, string queryString, UITextSearchOptions options, string replacementText)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			if (queryString is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (queryString));
			var options__handle__ = options!.GetNonNullHandle (nameof (options));
			if (replacementText is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (replacementText));
			var nsqueryString = CFString.CreateNative (queryString);
			var nsreplacementText = CFString.CreateNative (replacementText);
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("replaceAllOccurrencesOfQueryString:usingOptions:withText:"), nsqueryString, options__handle__, nsreplacementText);
			GC.KeepAlive (This);
			GC.KeepAlive (options);
			CFString.ReleaseNative (nsqueryString);
			CFString.ReleaseNative (nsreplacementText);
		}
		[global::Foundation.OptionalMember]
		[Export ("willHighlightFoundTextRange:inDocument:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void WillHighlight (UITextRange foundRange, INSCopying? document)
		{
			_WillHighlight (this, foundRange, document);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _WillHighlight (IUITextSearching This, UITextRange foundRange, INSCopying? document)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var foundRange__handle__ = foundRange!.GetNonNullHandle (nameof (foundRange));
			var document__handle__ = document.GetHandle ();
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("willHighlightFoundTextRange:inDocument:"), foundRange__handle__, document__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (foundRange);
			GC.KeepAlive (document);
		}
		[global::Foundation.OptionalMember]
		[Export ("scrollRangeToVisible:inDocument:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void ScrollRangeToVisible (UITextRange range, INSCopying? document)
		{
			_ScrollRangeToVisible (this, range, document);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _ScrollRangeToVisible (IUITextSearching This, UITextRange range, INSCopying? document)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var range__handle__ = range!.GetNonNullHandle (nameof (range));
			var document__handle__ = document.GetHandle ();
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("scrollRangeToVisible:inDocument:"), range__handle__, document__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (range);
			GC.KeepAlive (document);
		}
		[global::Foundation.OptionalMember]
		[Export ("compareOrderFromDocument:toDocument:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSComparisonResult CompareOrder (INSCopying fromDocument, INSCopying toDocument)
		{
			return _CompareOrder (this, fromDocument, toDocument);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static NSComparisonResult _CompareOrder (IUITextSearching This, INSCopying fromDocument, INSCopying toDocument)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var fromDocument__handle__ = fromDocument!.GetNonNullHandle (nameof (fromDocument));
			var toDocument__handle__ = toDocument!.GetNonNullHandle (nameof (toDocument));
			NSComparisonResult ret;
			ret = (NSComparisonResult) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("compareOrderFromDocument:toDocument:"), fromDocument__handle__, toDocument__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (fromDocument);
			GC.KeepAlive (toDocument);
			return ret!;
		}
		[DynamicDependencyAttribute ("ClearAllDecoratedFoundText()")]
		[DynamicDependencyAttribute ("Compare(UIKit.UITextRange,UIKit.UITextRange,Foundation.INSCopying)")]
		[DynamicDependencyAttribute ("CompareOrder(Foundation.INSCopying,Foundation.INSCopying)")]
		[DynamicDependencyAttribute ("Decorate(UIKit.UITextRange,Foundation.INSCopying,UIKit.UITextSearchFoundTextStyle)")]
		[DynamicDependencyAttribute ("PerformTextSearch(System.String,UIKit.UITextSearchOptions,UIKit.IUITextSearchAggregator)")]
		[DynamicDependencyAttribute ("ReplaceAllOccurrences(System.String,UIKit.UITextSearchOptions,System.String)")]
		[DynamicDependencyAttribute ("ReplaceFoundText(UIKit.UITextRange,Foundation.INSCopying,System.String)")]
		[DynamicDependencyAttribute ("ScrollRangeToVisible(UIKit.UITextRange,Foundation.INSCopying)")]
		[DynamicDependencyAttribute ("SelectedTextRange")]
		[DynamicDependencyAttribute ("SelectedTextSearchDocument")]
		[DynamicDependencyAttribute ("ShouldReplaceFoundText(UIKit.UITextRange,Foundation.INSCopying,System.String)")]
		[DynamicDependencyAttribute ("SupportsTextReplacement")]
		[DynamicDependencyAttribute ("WillHighlight(UIKit.UITextRange,Foundation.INSCopying)")]
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.Interfaces | DynamicallyAccessedMemberTypes.PublicConstructors, typeof (UITextSearchingWrapper))]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static IUITextSearching ()
		{
			GC.KeepAlive (null);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual UITextRange? SelectedTextRange {
			[Export ("selectedTextRange")]
			get {
				return _GetSelectedTextRange (this);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static UITextRange _GetSelectedTextRange (IUITextSearching This)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			UITextRange ret;
			ret =  Runtime.GetNSObject<UITextRange> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("selectedTextRange")), false)!;
			GC.KeepAlive (This);
			return ret;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.OptionalMember]
		public virtual bool SupportsTextReplacement {
			[Export ("supportsTextReplacement")]
			get {
				return _GetSupportsTextReplacement (this);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static bool _GetSupportsTextReplacement (IUITextSearching This)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (This.Handle, Selector.GetHandle ("supportsTextReplacement"));
			GC.KeepAlive (This);
			return ret != 0;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.OptionalMember]
		public virtual INSCopying? SelectedTextSearchDocument {
			[Export ("selectedTextSearchDocument")]
			get {
				return _GetSelectedTextSearchDocument (this);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static INSCopying _GetSelectedTextSearchDocument (IUITextSearching This)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			INSCopying ret;
			ret =  Runtime.GetINativeObject<INSCopying> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("selectedTextSearchDocument")), false)!;
			GC.KeepAlive (This);
			return ret;
		}
	}
	#pragma warning restore CS1573
	#pragma warning disable CS1573
	/// <summary>Extension methods to the <see cref="IUITextSearching" /> interface to support all the methods from the UITextSearching protocol.</summary>
	/// <remarks>
	///   <para>The extension methods for <see cref="IUITextSearching" /> interface allow developers to treat instances of the interface as having all the optional methods of the original UITextSearching protocol. Since the interface only contains the required members, these extension methods allow developers to call the optional members of the protocol.</para>
	/// </remarks>
	public unsafe static partial class UITextSearching_Extensions {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool ShouldReplaceFoundText (this IUITextSearching This, UITextRange range, INSCopying? document, string replacementText)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var range__handle__ = range!.GetNonNullHandle (nameof (range));
			var document__handle__ = document.GetHandle ();
			if (replacementText is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (replacementText));
			var nsreplacementText = CFString.CreateNative (replacementText);
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("shouldReplaceFoundTextInRange:inDocument:withText:"), range__handle__, document__handle__, nsreplacementText);
			GC.KeepAlive (This);
			GC.KeepAlive (range);
			GC.KeepAlive (document);
			CFString.ReleaseNative (nsreplacementText);
			return ret != 0;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void ReplaceFoundText (this IUITextSearching This, UITextRange range, INSCopying? document, string replacementText)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var range__handle__ = range!.GetNonNullHandle (nameof (range));
			var document__handle__ = document.GetHandle ();
			if (replacementText is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (replacementText));
			var nsreplacementText = CFString.CreateNative (replacementText);
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("replaceFoundTextInRange:inDocument:withText:"), range__handle__, document__handle__, nsreplacementText);
			GC.KeepAlive (This);
			GC.KeepAlive (range);
			GC.KeepAlive (document);
			CFString.ReleaseNative (nsreplacementText);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void ReplaceAllOccurrences (this IUITextSearching This, string queryString, UITextSearchOptions options, string replacementText)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			if (queryString is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (queryString));
			var options__handle__ = options!.GetNonNullHandle (nameof (options));
			if (replacementText is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (replacementText));
			var nsqueryString = CFString.CreateNative (queryString);
			var nsreplacementText = CFString.CreateNative (replacementText);
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("replaceAllOccurrencesOfQueryString:usingOptions:withText:"), nsqueryString, options__handle__, nsreplacementText);
			GC.KeepAlive (This);
			GC.KeepAlive (options);
			CFString.ReleaseNative (nsqueryString);
			CFString.ReleaseNative (nsreplacementText);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void WillHighlight (this IUITextSearching This, UITextRange foundRange, INSCopying? document)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var foundRange__handle__ = foundRange!.GetNonNullHandle (nameof (foundRange));
			var document__handle__ = document.GetHandle ();
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("willHighlightFoundTextRange:inDocument:"), foundRange__handle__, document__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (foundRange);
			GC.KeepAlive (document);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void ScrollRangeToVisible (this IUITextSearching This, UITextRange range, INSCopying? document)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var range__handle__ = range!.GetNonNullHandle (nameof (range));
			var document__handle__ = document.GetHandle ();
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("scrollRangeToVisible:inDocument:"), range__handle__, document__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (range);
			GC.KeepAlive (document);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSComparisonResult CompareOrder (this IUITextSearching This, INSCopying fromDocument, INSCopying toDocument)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var fromDocument__handle__ = fromDocument!.GetNonNullHandle (nameof (fromDocument));
			var toDocument__handle__ = toDocument!.GetNonNullHandle (nameof (toDocument));
			NSComparisonResult ret;
			ret = (NSComparisonResult) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("compareOrderFromDocument:toDocument:"), fromDocument__handle__, toDocument__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (fromDocument);
			GC.KeepAlive (toDocument);
			return ret!;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool GetSupportsTextReplacement (this IUITextSearching This)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (This.Handle, Selector.GetHandle ("supportsTextReplacement"));
			GC.KeepAlive (This);
			return ret != 0;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static INSCopying GetSelectedTextSearchDocument (this IUITextSearching This)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			INSCopying ret;
			ret =  Runtime.GetINativeObject<INSCopying> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("selectedTextSearchDocument")), false)!;
			GC.KeepAlive (This);
			return ret;
		}
	}
	#pragma warning restore CS1573
	internal unsafe sealed class UITextSearchingWrapper : BaseWrapper, IUITextSearching {
		public UITextSearchingWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.PublicConstructors, typeof (UITextSearchingWrapper))]
		static UITextSearchingWrapper ()
		{
			GC.KeepAlive (null);
		}
		[Export ("compareFoundRange:toRange:inDocument:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public NSComparisonResult Compare (UITextRange foundRange, UITextRange toRange, INSCopying? document)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var foundRange__handle__ = foundRange!.GetNonNullHandle (nameof (foundRange));
			var toRange__handle__ = toRange!.GetNonNullHandle (nameof (toRange));
			var document__handle__ = document.GetHandle ();
			NSComparisonResult ret;
			ret = (NSComparisonResult) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("compareFoundRange:toRange:inDocument:"), foundRange__handle__, toRange__handle__, document__handle__);
			GC.KeepAlive (foundRange);
			GC.KeepAlive (toRange);
			GC.KeepAlive (document);
			return ret!;
		}
		[Export ("performTextSearchWithQueryString:usingOptions:resultAggregator:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void PerformTextSearch (string @string, UITextSearchOptions options, IUITextSearchAggregator aggregator)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			if (@string is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (@string));
			var options__handle__ = options!.GetNonNullHandle (nameof (options));
			var aggregator__handle__ = aggregator!.GetNonNullHandle (nameof (aggregator));
			var nsstring = CFString.CreateNative (@string);
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("performTextSearchWithQueryString:usingOptions:resultAggregator:"), nsstring, options__handle__, aggregator__handle__);
			GC.KeepAlive (options);
			GC.KeepAlive (aggregator);
			CFString.ReleaseNative (nsstring);
		}
		[Export ("decorateFoundTextRange:inDocument:usingStyle:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void Decorate (UITextRange foundRange, INSCopying? document, UITextSearchFoundTextStyle style)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var foundRange__handle__ = foundRange!.GetNonNullHandle (nameof (foundRange));
			var document__handle__ = document.GetHandle ();
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_IntPtr (this.Handle, Selector.GetHandle ("decorateFoundTextRange:inDocument:usingStyle:"), foundRange__handle__, document__handle__, (IntPtr) (long) style);
			GC.KeepAlive (foundRange);
			GC.KeepAlive (document);
		}
		[Export ("clearAllDecoratedFoundText")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void ClearAllDecoratedFoundText ()
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			global::ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, Selector.GetHandle ("clearAllDecoratedFoundText"));
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public UITextRange? SelectedTextRange {
			[Export ("selectedTextRange")]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				UITextRange ret;
				ret =  Runtime.GetNSObject<UITextRange> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("selectedTextRange")), false)!;
				return ret;
			}
		}
	}
}
