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
namespace UIKit {
	#pragma warning disable CS1573
	/// <summary>This interface represents the Objective-C protocol <c>UITextSearchAggregator</c>.</summary>
	/// <remarks>
	///   <para>A class that implements this interface (and subclasses <see cref="NSObject" />) will be exported to Objective-C as implementing the Objective-C protocol this interface represents.</para>
	///   <para>A class may also implement members from this interface to implement members from the protocol.</para>
	/// </remarks>
	[UnsupportedOSPlatform ("tvos")]
	[SupportedOSPlatform ("ios16.0")]
	[SupportedOSPlatform ("maccatalyst16.0")]
	[Protocol (Name = "UITextSearchAggregator", WrapperType = typeof (UITextSearchAggregatorWrapper))]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "GetFoundRange", Selector = "foundRange:forSearchString:inDocument:", ParameterType = new Type [] { typeof (UITextRange), typeof (string), typeof (INSCopying) }, ParameterByRef = new bool [] { false, false, false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "Invalidate", Selector = "invalidateFoundRange:inDocument:", ParameterType = new Type [] { typeof (UITextRange), typeof (INSCopying) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "FinishedSearching", Selector = "finishedSearching")]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "Invalidate", Selector = "invalidate")]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "AllFoundRanges", Selector = "allFoundRanges", PropertyType = typeof (global::Foundation.NSOrderedSet<global::UIKit.UITextRange>), GetterSelector = "allFoundRanges", ArgumentSemantic = ArgumentSemantic.None)]
	public partial interface IUITextSearchAggregator : INativeObject, IDisposable
	{
		[global::Foundation.RequiredMember]
		[Export ("foundRange:forSearchString:inDocument:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void GetFoundRange (UITextRange range, string @string, INSCopying? document)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _GetFoundRange (IUITextSearchAggregator This, UITextRange range, string @string, INSCopying? document)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var range__handle__ = range!.GetNonNullHandle (nameof (range));
			if (@string is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (@string));
			var document__handle__ = document.GetHandle ();
			var nsstring = CFString.CreateNative (@string);
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("foundRange:forSearchString:inDocument:"), range__handle__, nsstring, document__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (range);
			GC.KeepAlive (document);
			CFString.ReleaseNative (nsstring);
		}
		[global::Foundation.RequiredMember]
		[Export ("invalidateFoundRange:inDocument:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void Invalidate (UITextRange foundRange, INSCopying? document)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _Invalidate (IUITextSearchAggregator This, UITextRange foundRange, INSCopying? document)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var foundRange__handle__ = foundRange!.GetNonNullHandle (nameof (foundRange));
			var document__handle__ = document.GetHandle ();
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("invalidateFoundRange:inDocument:"), foundRange__handle__, document__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (foundRange);
			GC.KeepAlive (document);
		}
		[global::Foundation.RequiredMember]
		[Export ("finishedSearching")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void FinishedSearching ()
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _FinishedSearching (IUITextSearchAggregator This)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			global::ObjCRuntime.Messaging.void_objc_msgSend (This.Handle, Selector.GetHandle ("finishedSearching"));
			GC.KeepAlive (This);
		}
		[global::Foundation.RequiredMember]
		[Export ("invalidate")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void Invalidate ()
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _Invalidate (IUITextSearchAggregator This)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			global::ObjCRuntime.Messaging.void_objc_msgSend (This.Handle, Selector.GetHandle ("invalidate"));
			GC.KeepAlive (This);
		}
		[DynamicDependencyAttribute ("AllFoundRanges")]
		[DynamicDependencyAttribute ("FinishedSearching()")]
		[DynamicDependencyAttribute ("GetFoundRange(UIKit.UITextRange,System.String,Foundation.INSCopying)")]
		[DynamicDependencyAttribute ("Invalidate()")]
		[DynamicDependencyAttribute ("Invalidate(UIKit.UITextRange,Foundation.INSCopying)")]
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.Interfaces | DynamicallyAccessedMemberTypes.PublicConstructors, typeof (UITextSearchAggregatorWrapper))]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static IUITextSearchAggregator ()
		{
			GC.KeepAlive (null);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual NSOrderedSet<UITextRange> AllFoundRanges {
			[Export ("allFoundRanges")]
			get {
				return _GetAllFoundRanges (this);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static NSOrderedSet<UITextRange> _GetAllFoundRanges (IUITextSearchAggregator This)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			NSOrderedSet<UITextRange> ret;
			ret =  Runtime.GetNSObject<NSOrderedSet<UITextRange>> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("allFoundRanges")), false)!;
			GC.KeepAlive (This);
			return ret;
		}
	}
	#pragma warning restore CS1573
	internal unsafe sealed class UITextSearchAggregatorWrapper : BaseWrapper, IUITextSearchAggregator {
		public UITextSearchAggregatorWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.PublicConstructors, typeof (UITextSearchAggregatorWrapper))]
		static UITextSearchAggregatorWrapper ()
		{
			GC.KeepAlive (null);
		}
		[Export ("foundRange:forSearchString:inDocument:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void GetFoundRange (UITextRange range, string @string, INSCopying? document)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var range__handle__ = range!.GetNonNullHandle (nameof (range));
			if (@string is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (@string));
			var document__handle__ = document.GetHandle ();
			var nsstring = CFString.CreateNative (@string);
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("foundRange:forSearchString:inDocument:"), range__handle__, nsstring, document__handle__);
			GC.KeepAlive (range);
			GC.KeepAlive (document);
			CFString.ReleaseNative (nsstring);
		}
		[Export ("invalidateFoundRange:inDocument:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void Invalidate (UITextRange foundRange, INSCopying? document)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var foundRange__handle__ = foundRange!.GetNonNullHandle (nameof (foundRange));
			var document__handle__ = document.GetHandle ();
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("invalidateFoundRange:inDocument:"), foundRange__handle__, document__handle__);
			GC.KeepAlive (foundRange);
			GC.KeepAlive (document);
		}
		[Export ("finishedSearching")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void FinishedSearching ()
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			global::ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, Selector.GetHandle ("finishedSearching"));
		}
		[Export ("invalidate")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void Invalidate ()
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			global::ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, Selector.GetHandle ("invalidate"));
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public NSOrderedSet<UITextRange> AllFoundRanges {
			[Export ("allFoundRanges")]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				NSOrderedSet<UITextRange> ret;
				ret =  Runtime.GetNSObject<NSOrderedSet<UITextRange>> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("allFoundRanges")), false)!;
				return ret;
			}
		}
	}
}
