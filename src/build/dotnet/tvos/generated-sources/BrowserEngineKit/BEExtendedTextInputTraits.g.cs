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
namespace BrowserEngineKit {
	#pragma warning disable CS1573
	/// <summary>This interface represents the Objective-C protocol <c>BEExtendedTextInputTraits</c>.</summary>
	/// <remarks>
	///   <para>A class that implements this interface (and subclasses <see cref="NSObject" />) will be exported to Objective-C as implementing the Objective-C protocol this interface represents.</para>
	///   <para>A class may also implement members from this interface to implement members from the protocol.</para>
	/// </remarks>
	[SupportedOSPlatform ("tvos17.4")]
	[UnsupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("ios17.4")]
	[UnsupportedOSPlatform ("maccatalyst")]
	[Protocol (Name = "BEExtendedTextInputTraits", WrapperType = typeof (BEExtendedTextInputTraitsWrapper), BackwardsCompatibleCodeGeneration = false)]
	[ProtocolMember (IsRequired = false, IsProperty = true, IsStatic = false, Name = "SingleLineDocument", Selector = "singleLineDocument", PropertyType = typeof (bool), GetterSelector = "isSingleLineDocument", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = false, IsProperty = true, IsStatic = false, Name = "TypingAdaptationEnabled", Selector = "typingAdaptationEnabled", PropertyType = typeof (bool), GetterSelector = "isTypingAdaptationEnabled", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = false, IsProperty = true, IsStatic = false, Name = "InsertionPointColor", Selector = "insertionPointColor", PropertyType = typeof (UIColor), GetterSelector = "insertionPointColor", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = false, IsProperty = true, IsStatic = false, Name = "SelectionHandleColor", Selector = "selectionHandleColor", PropertyType = typeof (UIColor), GetterSelector = "selectionHandleColor", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = false, IsProperty = true, IsStatic = false, Name = "SelectionHighlightColor", Selector = "selectionHighlightColor", PropertyType = typeof (UIColor), GetterSelector = "selectionHighlightColor", ArgumentSemantic = ArgumentSemantic.None)]
	public partial interface IBEExtendedTextInputTraits : INativeObject, IDisposable, 
		UIKit.IUITextInputTraits
	{
		[DynamicDependencyAttribute ("InsertionPointColor")]
		[DynamicDependencyAttribute ("SelectionHandleColor")]
		[DynamicDependencyAttribute ("SelectionHighlightColor")]
		[DynamicDependencyAttribute ("SingleLineDocument")]
		[DynamicDependencyAttribute ("TypingAdaptationEnabled")]
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.Interfaces | DynamicallyAccessedMemberTypes.PublicConstructors, typeof (BEExtendedTextInputTraitsWrapper))]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static IBEExtendedTextInputTraits ()
		{
			GC.KeepAlive (null);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.OptionalMember]
		public virtual bool SingleLineDocument {
			[Export ("isSingleLineDocument")]
			get {
				return _GetSingleLineDocument (this);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static bool _GetSingleLineDocument (IBEExtendedTextInputTraits This)
		{
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (This.Handle, Selector.GetHandle ("isSingleLineDocument"));
			GC.KeepAlive (This);
			return ret != 0;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.OptionalMember]
		public virtual bool TypingAdaptationEnabled {
			[Export ("isTypingAdaptationEnabled")]
			get {
				return _GetTypingAdaptationEnabled (this);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static bool _GetTypingAdaptationEnabled (IBEExtendedTextInputTraits This)
		{
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (This.Handle, Selector.GetHandle ("isTypingAdaptationEnabled"));
			GC.KeepAlive (This);
			return ret != 0;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.OptionalMember]
		public virtual global::UIKit.UIColor? InsertionPointColor {
			[Export ("insertionPointColor")]
			get {
				return _GetInsertionPointColor (this);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static global::UIKit.UIColor _GetInsertionPointColor (IBEExtendedTextInputTraits This)
		{
			global::UIKit.UIColor ret;
			ret =  Runtime.GetNSObject<global::UIKit.UIColor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("insertionPointColor")), false)!;
			GC.KeepAlive (This);
			return ret;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.OptionalMember]
		public virtual global::UIKit.UIColor? SelectionHandleColor {
			[Export ("selectionHandleColor")]
			get {
				return _GetSelectionHandleColor (this);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static global::UIKit.UIColor _GetSelectionHandleColor (IBEExtendedTextInputTraits This)
		{
			global::UIKit.UIColor ret;
			ret =  Runtime.GetNSObject<global::UIKit.UIColor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("selectionHandleColor")), false)!;
			GC.KeepAlive (This);
			return ret;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.OptionalMember]
		public virtual global::UIKit.UIColor? SelectionHighlightColor {
			[Export ("selectionHighlightColor")]
			get {
				return _GetSelectionHighlightColor (this);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static global::UIKit.UIColor _GetSelectionHighlightColor (IBEExtendedTextInputTraits This)
		{
			global::UIKit.UIColor ret;
			ret =  Runtime.GetNSObject<global::UIKit.UIColor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("selectionHighlightColor")), false)!;
			GC.KeepAlive (This);
			return ret;
		}
	}
	#pragma warning restore CS1573
	internal unsafe sealed class BEExtendedTextInputTraitsWrapper : BaseWrapper, IBEExtendedTextInputTraits {
		public BEExtendedTextInputTraitsWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.PublicConstructors, typeof (BEExtendedTextInputTraitsWrapper))]
		static BEExtendedTextInputTraitsWrapper ()
		{
			GC.KeepAlive (null);
		}
	}
}
