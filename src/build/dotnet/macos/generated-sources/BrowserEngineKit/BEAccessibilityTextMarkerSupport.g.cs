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
namespace BrowserEngineKit {
	#pragma warning disable CS1573
	/// <summary>This interface represents the Objective-C protocol <c>BEAccessibilityTextMarkerSupport</c>.</summary>
	/// <remarks>
	///   <para>A class that implements this interface (and subclasses <see cref="NSObject" />) will be exported to Objective-C as implementing the Objective-C protocol this interface represents.</para>
	///   <para>A class may also implement members from this interface to implement members from the protocol.</para>
	/// </remarks>
	[SupportedOSPlatform ("ios18.2")]
	[SupportedOSPlatform ("tvos18.2")]
	[SupportedOSPlatform ("macos15.2")]
	[UnsupportedOSPlatform ("maccatalyst")]
	[Protocol (Name = "BEAccessibilityTextMarkerSupport", WrapperType = typeof (BEAccessibilityTextMarkerSupportWrapper), BackwardsCompatibleCodeGeneration = false)]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "GetAccessibilityBounds", Selector = "accessibilityBoundsForTextMarkerRange:", ReturnType = typeof (CGRect), ParameterType = new Type [] { typeof (BrowserEngineKit.BEAccessibilityTextMarkerRange) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "GetAccessibilityContent", Selector = "accessibilityContentForTextMarkerRange:", ReturnType = typeof (string), ParameterType = new Type [] { typeof (BrowserEngineKit.BEAccessibilityTextMarkerRange) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "GetAccessibilityTextMarkerRangeForCurrentSelection", Selector = "accessibilityTextMarkerRangeForCurrentSelection", ReturnType = typeof (BrowserEngineKit.BEAccessibilityTextMarkerRange))]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "GetAccessibilityTextMarkerRange", Selector = "accessibilityTextMarkerRange", ReturnType = typeof (BrowserEngineKit.BEAccessibilityTextMarkerRange))]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "GetAccessibilityNextTextMarker", Selector = "accessibilityNextTextMarker:", ReturnType = typeof (BrowserEngineKit.BEAccessibilityTextMarker), ParameterType = new Type [] { typeof (BrowserEngineKit.BEAccessibilityTextMarker) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "GetAccessibilityPreviousTextMarker", Selector = "accessibilityPreviousTextMarker:", ReturnType = typeof (BrowserEngineKit.BEAccessibilityTextMarker), ParameterType = new Type [] { typeof (BrowserEngineKit.BEAccessibilityTextMarker) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "GetAccessibilityLineEndMarker", Selector = "accessibilityLineEndMarkerForMarker:", ReturnType = typeof (BrowserEngineKit.BEAccessibilityTextMarker), ParameterType = new Type [] { typeof (BrowserEngineKit.BEAccessibilityTextMarker) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "GetAccessibilityLineStartMarker", Selector = "accessibilityLineStartMarkerForMarker:", ReturnType = typeof (BrowserEngineKit.BEAccessibilityTextMarker), ParameterType = new Type [] { typeof (BrowserEngineKit.BEAccessibilityTextMarker) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "GetAccessibilityMarker", Selector = "accessibilityMarkerForPoint:", ReturnType = typeof (BrowserEngineKit.BEAccessibilityTextMarker), ParameterType = new Type [] { typeof (CGPoint) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "GetAccessibilityTextMarker", Selector = "accessibilityTextMarkerForPosition:", ReturnType = typeof (BrowserEngineKit.BEAccessibilityTextMarker), ParameterType = new Type [] { typeof (IntPtr) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "GetAccessibilityTextMarker", Selector = "accessibilityTextMarkerRangeForRange:", ReturnType = typeof (BrowserEngineKit.BEAccessibilityTextMarkerRange), ParameterType = new Type [] { typeof (NSRange) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "GetAccessibilityRange", Selector = "accessibilityRangeForTextMarkerRange:", ReturnType = typeof (NSRange), ParameterType = new Type [] { typeof (BrowserEngineKit.BEAccessibilityTextMarkerRange) }, ParameterByRef = new bool [] { false })]
	public partial interface IBEAccessibilityTextMarkerSupport : INativeObject, IDisposable
	{
		[global::Foundation.RequiredMember]
		[Export ("accessibilityBoundsForTextMarkerRange:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual CGRect GetAccessibilityBounds (BEAccessibilityTextMarkerRange range)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static CGRect _GetAccessibilityBounds (IBEAccessibilityTextMarkerSupport This, BEAccessibilityTextMarkerRange range)
		{
			var range__handle__ = range!.GetNonNullHandle (nameof (range));
			CGRect ret;
			if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
				ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("accessibilityBoundsForTextMarkerRange:"), range__handle__);
				GC.KeepAlive (This);
			} else {
				ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSend_stret_NativeHandle (This.Handle, Selector.GetHandle ("accessibilityBoundsForTextMarkerRange:"), range__handle__);
				GC.KeepAlive (This);
			}
			GC.KeepAlive (range);
			return ret!;
		}
		[global::Foundation.RequiredMember]
		[Export ("accessibilityContentForTextMarkerRange:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string? GetAccessibilityContent (BEAccessibilityTextMarkerRange range)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static string? _GetAccessibilityContent (IBEAccessibilityTextMarkerSupport This, BEAccessibilityTextMarkerRange range)
		{
			var range__handle__ = range!.GetNonNullHandle (nameof (range));
			string? ret;
			ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("accessibilityContentForTextMarkerRange:"), range__handle__), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (range);
			return ret!;
		}
		[global::Foundation.RequiredMember]
		[Export ("accessibilityTextMarkerRangeForCurrentSelection")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual BEAccessibilityTextMarkerRange? GetAccessibilityTextMarkerRangeForCurrentSelection ()
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static BEAccessibilityTextMarkerRange? _GetAccessibilityTextMarkerRangeForCurrentSelection (IBEAccessibilityTextMarkerSupport This)
		{
			BEAccessibilityTextMarkerRange ret;
			ret =  Runtime.GetNSObject<BEAccessibilityTextMarkerRange> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("accessibilityTextMarkerRangeForCurrentSelection")), false)!;
			GC.KeepAlive (This);
			return ret;
		}
		[global::Foundation.RequiredMember]
		[Export ("accessibilityTextMarkerRange")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual BEAccessibilityTextMarkerRange GetAccessibilityTextMarkerRange ()
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static BEAccessibilityTextMarkerRange _GetAccessibilityTextMarkerRange (IBEAccessibilityTextMarkerSupport This)
		{
			BEAccessibilityTextMarkerRange ret;
			ret =  Runtime.GetNSObject<BEAccessibilityTextMarkerRange> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("accessibilityTextMarkerRange")), false)!;
			GC.KeepAlive (This);
			return ret;
		}
		[global::Foundation.RequiredMember]
		[Export ("accessibilityNextTextMarker:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual BEAccessibilityTextMarker? GetAccessibilityNextTextMarker (BEAccessibilityTextMarker marker)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static BEAccessibilityTextMarker? _GetAccessibilityNextTextMarker (IBEAccessibilityTextMarkerSupport This, BEAccessibilityTextMarker marker)
		{
			var marker__handle__ = marker!.GetNonNullHandle (nameof (marker));
			BEAccessibilityTextMarker? ret;
			ret =  Runtime.GetNSObject<BEAccessibilityTextMarker> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("accessibilityNextTextMarker:"), marker__handle__), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (marker);
			return ret!;
		}
		[global::Foundation.RequiredMember]
		[Export ("accessibilityPreviousTextMarker:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual BEAccessibilityTextMarker? GetAccessibilityPreviousTextMarker (BEAccessibilityTextMarker marker)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static BEAccessibilityTextMarker? _GetAccessibilityPreviousTextMarker (IBEAccessibilityTextMarkerSupport This, BEAccessibilityTextMarker marker)
		{
			var marker__handle__ = marker!.GetNonNullHandle (nameof (marker));
			BEAccessibilityTextMarker? ret;
			ret =  Runtime.GetNSObject<BEAccessibilityTextMarker> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("accessibilityPreviousTextMarker:"), marker__handle__), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (marker);
			return ret!;
		}
		[global::Foundation.RequiredMember]
		[Export ("accessibilityLineEndMarkerForMarker:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual BEAccessibilityTextMarker? GetAccessibilityLineEndMarker (BEAccessibilityTextMarker marker)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static BEAccessibilityTextMarker? _GetAccessibilityLineEndMarker (IBEAccessibilityTextMarkerSupport This, BEAccessibilityTextMarker marker)
		{
			var marker__handle__ = marker!.GetNonNullHandle (nameof (marker));
			BEAccessibilityTextMarker? ret;
			ret =  Runtime.GetNSObject<BEAccessibilityTextMarker> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("accessibilityLineEndMarkerForMarker:"), marker__handle__), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (marker);
			return ret!;
		}
		[global::Foundation.RequiredMember]
		[Export ("accessibilityLineStartMarkerForMarker:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual BEAccessibilityTextMarker? GetAccessibilityLineStartMarker (BEAccessibilityTextMarker marker)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static BEAccessibilityTextMarker? _GetAccessibilityLineStartMarker (IBEAccessibilityTextMarkerSupport This, BEAccessibilityTextMarker marker)
		{
			var marker__handle__ = marker!.GetNonNullHandle (nameof (marker));
			BEAccessibilityTextMarker? ret;
			ret =  Runtime.GetNSObject<BEAccessibilityTextMarker> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("accessibilityLineStartMarkerForMarker:"), marker__handle__), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (marker);
			return ret!;
		}
		[global::Foundation.RequiredMember]
		[Export ("accessibilityMarkerForPoint:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual BEAccessibilityTextMarker? GetAccessibilityMarker (CGPoint point)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static BEAccessibilityTextMarker? _GetAccessibilityMarker (IBEAccessibilityTextMarkerSupport This, CGPoint point)
		{
			BEAccessibilityTextMarker ret;
			ret =  Runtime.GetNSObject<BEAccessibilityTextMarker> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_CGPoint (This.Handle, Selector.GetHandle ("accessibilityMarkerForPoint:"), point), false)!;
			GC.KeepAlive (This);
			return ret;
		}
		[global::Foundation.RequiredMember]
		[Export ("accessibilityTextMarkerForPosition:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual BEAccessibilityTextMarker? GetAccessibilityTextMarker (nint position)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static BEAccessibilityTextMarker? _GetAccessibilityTextMarker (IBEAccessibilityTextMarkerSupport This, nint position)
		{
			BEAccessibilityTextMarker ret;
			ret =  Runtime.GetNSObject<BEAccessibilityTextMarker> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("accessibilityTextMarkerForPosition:"), position), false)!;
			GC.KeepAlive (This);
			return ret;
		}
		[global::Foundation.RequiredMember]
		[Export ("accessibilityTextMarkerRangeForRange:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual BEAccessibilityTextMarkerRange? GetAccessibilityTextMarker (NSRange range)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static BEAccessibilityTextMarkerRange? _GetAccessibilityTextMarker (IBEAccessibilityTextMarkerSupport This, NSRange range)
		{
			BEAccessibilityTextMarkerRange ret;
			ret =  Runtime.GetNSObject<BEAccessibilityTextMarkerRange> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NSRange (This.Handle, Selector.GetHandle ("accessibilityTextMarkerRangeForRange:"), range), false)!;
			GC.KeepAlive (This);
			return ret;
		}
		[global::Foundation.RequiredMember]
		[Export ("accessibilityRangeForTextMarkerRange:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSRange GetAccessibilityRange (BEAccessibilityTextMarkerRange range)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static NSRange _GetAccessibilityRange (IBEAccessibilityTextMarkerSupport This, BEAccessibilityTextMarkerRange range)
		{
			var range__handle__ = range!.GetNonNullHandle (nameof (range));
			NSRange ret;
			ret = global::ObjCRuntime.Messaging.NSRange_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("accessibilityRangeForTextMarkerRange:"), range__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (range);
			return ret!;
		}
		[DynamicDependencyAttribute ("GetAccessibilityBounds(BrowserEngineKit.BEAccessibilityTextMarkerRange)")]
		[DynamicDependencyAttribute ("GetAccessibilityContent(BrowserEngineKit.BEAccessibilityTextMarkerRange)")]
		[DynamicDependencyAttribute ("GetAccessibilityLineEndMarker(BrowserEngineKit.BEAccessibilityTextMarker)")]
		[DynamicDependencyAttribute ("GetAccessibilityLineStartMarker(BrowserEngineKit.BEAccessibilityTextMarker)")]
		[DynamicDependencyAttribute ("GetAccessibilityMarker(CoreGraphics.CGPoint)")]
		[DynamicDependencyAttribute ("GetAccessibilityNextTextMarker(BrowserEngineKit.BEAccessibilityTextMarker)")]
		[DynamicDependencyAttribute ("GetAccessibilityPreviousTextMarker(BrowserEngineKit.BEAccessibilityTextMarker)")]
		[DynamicDependencyAttribute ("GetAccessibilityRange(BrowserEngineKit.BEAccessibilityTextMarkerRange)")]
		[DynamicDependencyAttribute ("GetAccessibilityTextMarker(Foundation.NSRange)")]
		[DynamicDependencyAttribute ("GetAccessibilityTextMarker(System.IntPtr)")]
		[DynamicDependencyAttribute ("GetAccessibilityTextMarkerRange()")]
		[DynamicDependencyAttribute ("GetAccessibilityTextMarkerRangeForCurrentSelection()")]
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.Interfaces | DynamicallyAccessedMemberTypes.PublicConstructors, typeof (BEAccessibilityTextMarkerSupportWrapper))]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static IBEAccessibilityTextMarkerSupport ()
		{
			GC.KeepAlive (null);
		}
	}
	#pragma warning restore CS1573
	internal unsafe sealed class BEAccessibilityTextMarkerSupportWrapper : BaseWrapper, IBEAccessibilityTextMarkerSupport {
		public BEAccessibilityTextMarkerSupportWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.PublicConstructors, typeof (BEAccessibilityTextMarkerSupportWrapper))]
		static BEAccessibilityTextMarkerSupportWrapper ()
		{
			GC.KeepAlive (null);
		}
		[Export ("accessibilityBoundsForTextMarkerRange:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public CGRect GetAccessibilityBounds (BEAccessibilityTextMarkerRange range)
		{
			var range__handle__ = range!.GetNonNullHandle (nameof (range));
			CGRect ret;
			if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
				ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("accessibilityBoundsForTextMarkerRange:"), range__handle__);
			} else {
				ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSend_stret_NativeHandle (this.Handle, Selector.GetHandle ("accessibilityBoundsForTextMarkerRange:"), range__handle__);
			}
			GC.KeepAlive (range);
			return ret!;
		}
		[Export ("accessibilityContentForTextMarkerRange:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public string? GetAccessibilityContent (BEAccessibilityTextMarkerRange range)
		{
			var range__handle__ = range!.GetNonNullHandle (nameof (range));
			string? ret;
			ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("accessibilityContentForTextMarkerRange:"), range__handle__), false)!;
			GC.KeepAlive (range);
			return ret!;
		}
		[Export ("accessibilityTextMarkerRangeForCurrentSelection")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public BEAccessibilityTextMarkerRange? GetAccessibilityTextMarkerRangeForCurrentSelection ()
		{
			BEAccessibilityTextMarkerRange ret;
			ret =  Runtime.GetNSObject<BEAccessibilityTextMarkerRange> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("accessibilityTextMarkerRangeForCurrentSelection")), false)!;
			return ret;
		}
		[Export ("accessibilityTextMarkerRange")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public BEAccessibilityTextMarkerRange GetAccessibilityTextMarkerRange ()
		{
			BEAccessibilityTextMarkerRange ret;
			ret =  Runtime.GetNSObject<BEAccessibilityTextMarkerRange> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("accessibilityTextMarkerRange")), false)!;
			return ret;
		}
		[Export ("accessibilityNextTextMarker:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public BEAccessibilityTextMarker? GetAccessibilityNextTextMarker (BEAccessibilityTextMarker marker)
		{
			var marker__handle__ = marker!.GetNonNullHandle (nameof (marker));
			BEAccessibilityTextMarker? ret;
			ret =  Runtime.GetNSObject<BEAccessibilityTextMarker> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("accessibilityNextTextMarker:"), marker__handle__), false)!;
			GC.KeepAlive (marker);
			return ret!;
		}
		[Export ("accessibilityPreviousTextMarker:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public BEAccessibilityTextMarker? GetAccessibilityPreviousTextMarker (BEAccessibilityTextMarker marker)
		{
			var marker__handle__ = marker!.GetNonNullHandle (nameof (marker));
			BEAccessibilityTextMarker? ret;
			ret =  Runtime.GetNSObject<BEAccessibilityTextMarker> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("accessibilityPreviousTextMarker:"), marker__handle__), false)!;
			GC.KeepAlive (marker);
			return ret!;
		}
		[Export ("accessibilityLineEndMarkerForMarker:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public BEAccessibilityTextMarker? GetAccessibilityLineEndMarker (BEAccessibilityTextMarker marker)
		{
			var marker__handle__ = marker!.GetNonNullHandle (nameof (marker));
			BEAccessibilityTextMarker? ret;
			ret =  Runtime.GetNSObject<BEAccessibilityTextMarker> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("accessibilityLineEndMarkerForMarker:"), marker__handle__), false)!;
			GC.KeepAlive (marker);
			return ret!;
		}
		[Export ("accessibilityLineStartMarkerForMarker:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public BEAccessibilityTextMarker? GetAccessibilityLineStartMarker (BEAccessibilityTextMarker marker)
		{
			var marker__handle__ = marker!.GetNonNullHandle (nameof (marker));
			BEAccessibilityTextMarker? ret;
			ret =  Runtime.GetNSObject<BEAccessibilityTextMarker> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("accessibilityLineStartMarkerForMarker:"), marker__handle__), false)!;
			GC.KeepAlive (marker);
			return ret!;
		}
		[Export ("accessibilityMarkerForPoint:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public BEAccessibilityTextMarker? GetAccessibilityMarker (CGPoint point)
		{
			BEAccessibilityTextMarker ret;
			ret =  Runtime.GetNSObject<BEAccessibilityTextMarker> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_CGPoint (this.Handle, Selector.GetHandle ("accessibilityMarkerForPoint:"), point), false)!;
			return ret;
		}
		[Export ("accessibilityTextMarkerForPosition:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public BEAccessibilityTextMarker? GetAccessibilityTextMarker (nint position)
		{
			BEAccessibilityTextMarker ret;
			ret =  Runtime.GetNSObject<BEAccessibilityTextMarker> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("accessibilityTextMarkerForPosition:"), position), false)!;
			return ret;
		}
		[Export ("accessibilityTextMarkerRangeForRange:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public BEAccessibilityTextMarkerRange? GetAccessibilityTextMarker (NSRange range)
		{
			BEAccessibilityTextMarkerRange ret;
			ret =  Runtime.GetNSObject<BEAccessibilityTextMarkerRange> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NSRange (this.Handle, Selector.GetHandle ("accessibilityTextMarkerRangeForRange:"), range), false)!;
			return ret;
		}
		[Export ("accessibilityRangeForTextMarkerRange:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public NSRange GetAccessibilityRange (BEAccessibilityTextMarkerRange range)
		{
			var range__handle__ = range!.GetNonNullHandle (nameof (range));
			NSRange ret;
			ret = global::ObjCRuntime.Messaging.NSRange_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("accessibilityRangeForTextMarkerRange:"), range__handle__);
			GC.KeepAlive (range);
			return ret!;
		}
	}
}
