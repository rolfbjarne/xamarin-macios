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
	/// <summary>This interface represents the Objective-C protocol <c>UITraitOverrides</c>.</summary>
	/// <remarks>
	///   <para>A class that implements this interface (and subclasses <see cref="NSObject" />) will be exported to Objective-C as implementing the Objective-C protocol this interface represents.</para>
	///   <para>A class may also implement members from this interface to implement members from the protocol.</para>
	/// </remarks>
	[SupportedOSPlatform ("tvos17.0")]
	[SupportedOSPlatform ("ios17.0")]
	[SupportedOSPlatform ("maccatalyst17.0")]
	[Protocol (Name = "UITraitOverrides", WrapperType = typeof (UITraitOverridesWrapper))]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "ContainsTrait", Selector = "containsTrait:", ReturnType = typeof (bool), ParameterType = new Type [] { typeof (IUITraitDefinition) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "RemoveTrait", Selector = "removeTrait:", ParameterType = new Type [] { typeof (IUITraitDefinition) }, ParameterByRef = new bool [] { false })]
	public partial interface IUITraitOverrides : INativeObject, IDisposable, 
		UIKit.IUIMutableTraits
	{
		[global::Foundation.RequiredMember]
		[Export ("containsTrait:")]
		[Obsolete ("Use 'ContainsTrait<T> ()', 'ContainsTrait (Type)' or 'ContainsTrait (Class)' instead.", false)]
		[EditorBrowsable (EditorBrowsableState.Never)]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool ContainsTrait (IUITraitDefinition trait)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Obsolete ("Use 'ContainsTrait<T> ()', 'ContainsTrait (Type)' or 'ContainsTrait (Class)' instead.", false)]
		[EditorBrowsable (EditorBrowsableState.Never)]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static bool _ContainsTrait (IUITraitOverrides This, IUITraitDefinition trait)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var trait__handle__ = trait!.GetNonNullHandle (nameof (trait));
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("containsTrait:"), trait__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (trait);
			return ret != 0;
		}
		[global::Foundation.RequiredMember]
		[Export ("removeTrait:")]
		[Obsolete ("Use 'RemoveTrait<T> ()', 'RemoveTrait (Type)' or 'RemoveTrait (Class)' instead.", false)]
		[EditorBrowsable (EditorBrowsableState.Never)]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void RemoveTrait (IUITraitDefinition trait)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Obsolete ("Use 'RemoveTrait<T> ()', 'RemoveTrait (Type)' or 'RemoveTrait (Class)' instead.", false)]
		[EditorBrowsable (EditorBrowsableState.Never)]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _RemoveTrait (IUITraitOverrides This, IUITraitDefinition trait)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var trait__handle__ = trait!.GetNonNullHandle (nameof (trait));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("removeTrait:"), trait__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (trait);
		}
		[DynamicDependencyAttribute ("ContainsTrait(UIKit.IUITraitDefinition)")]
		[DynamicDependencyAttribute ("RemoveTrait(UIKit.IUITraitDefinition)")]
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.Interfaces | DynamicallyAccessedMemberTypes.PublicConstructors, typeof (UITraitOverridesWrapper))]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static IUITraitOverrides ()
		{
			GC.KeepAlive (null);
		}
	}
	#pragma warning restore CS1573
	internal unsafe sealed class UITraitOverridesWrapper : BaseWrapper, IUITraitOverrides {
		public UITraitOverridesWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.PublicConstructors, typeof (UITraitOverridesWrapper))]
		static UITraitOverridesWrapper ()
		{
			GC.KeepAlive (null);
		}
		[Export ("containsTrait:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public bool ContainsTrait (IUITraitDefinition trait)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var trait__handle__ = trait!.GetNonNullHandle (nameof (trait));
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("containsTrait:"), trait__handle__);
			GC.KeepAlive (trait);
			return ret != 0;
		}
		[Export ("removeTrait:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void RemoveTrait (IUITraitDefinition trait)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var trait__handle__ = trait!.GetNonNullHandle (nameof (trait));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("removeTrait:"), trait__handle__);
			GC.KeepAlive (trait);
		}
		[Export ("setCGFloatValue:forTrait:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void SetValue (nfloat value, IUICGFloatTraitDefinition trait)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var trait__handle__ = trait!.GetNonNullHandle (nameof (trait));
			global::ObjCRuntime.Messaging.void_objc_msgSend_nfloat_NativeHandle (this.Handle, Selector.GetHandle ("setCGFloatValue:forTrait:"), value, trait__handle__);
			GC.KeepAlive (trait);
		}
		[Export ("valueForCGFloatTrait:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public nfloat GetValue (IUICGFloatTraitDefinition trait)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var trait__handle__ = trait!.GetNonNullHandle (nameof (trait));
			nfloat ret;
			ret = global::ObjCRuntime.Messaging.nfloat_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("valueForCGFloatTrait:"), trait__handle__);
			GC.KeepAlive (trait);
			return ret!;
		}
		[Export ("setNSIntegerValue:forTrait:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void SetValue (nint value, IUINSIntegerTraitDefinition trait)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var trait__handle__ = trait!.GetNonNullHandle (nameof (trait));
			global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr_NativeHandle (this.Handle, Selector.GetHandle ("setNSIntegerValue:forTrait:"), value, trait__handle__);
			GC.KeepAlive (trait);
		}
		[Export ("valueForNSIntegerTrait:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public nint GetValue (IUINSIntegerTraitDefinition trait)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var trait__handle__ = trait!.GetNonNullHandle (nameof (trait));
			nint ret;
			ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("valueForNSIntegerTrait:"), trait__handle__);
			GC.KeepAlive (trait);
			return ret!;
		}
		[Export ("setObject:forTrait:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void SetObject (NSObject? @object, IUIObjectTraitDefinition trait)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var @object__handle__ = @object.GetHandle ();
			var trait__handle__ = trait!.GetNonNullHandle (nameof (trait));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("setObject:forTrait:"), @object__handle__, trait__handle__);
			GC.KeepAlive (@object);
			GC.KeepAlive (trait);
		}
		[Export ("objectForTrait:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public NSObject? GetObject (IUIObjectTraitDefinition trait)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var trait__handle__ = trait!.GetNonNullHandle (nameof (trait));
			NSObject? ret;
			ret = Runtime.GetNSObject (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("objectForTrait:"), trait__handle__), false)!;
			GC.KeepAlive (trait);
			return ret!;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("ios17.0")]
		[SupportedOSPlatform ("tvos17.0")]
		[SupportedOSPlatform ("maccatalyst17.0")]
		public UIUserInterfaceIdiom UserInterfaceIdiom {
			[Export ("userInterfaceIdiom", ArgumentSemantic.Assign)]
			[SupportedOSPlatform ("ios17.0")]
			[SupportedOSPlatform ("tvos17.0")]
			[SupportedOSPlatform ("maccatalyst17.0")]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				UIUserInterfaceIdiom ret;
				ret = (UIUserInterfaceIdiom) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("userInterfaceIdiom"));
				return ret!;
			}
			[Export ("setUserInterfaceIdiom:", ArgumentSemantic.Assign)]
			[SupportedOSPlatform ("ios17.0")]
			[SupportedOSPlatform ("tvos17.0")]
			[SupportedOSPlatform ("maccatalyst17.0")]
			set {
				global::UIKit.UIApplication.EnsureUIThread ();
				global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setUserInterfaceIdiom:"), (IntPtr) (long) value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("ios17.0")]
		[SupportedOSPlatform ("tvos17.0")]
		[SupportedOSPlatform ("maccatalyst17.0")]
		public UIUserInterfaceStyle UserInterfaceStyle {
			[Export ("userInterfaceStyle", ArgumentSemantic.Assign)]
			[SupportedOSPlatform ("ios17.0")]
			[SupportedOSPlatform ("tvos17.0")]
			[SupportedOSPlatform ("maccatalyst17.0")]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				UIUserInterfaceStyle ret;
				ret = (UIUserInterfaceStyle) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("userInterfaceStyle"));
				return ret!;
			}
			[Export ("setUserInterfaceStyle:", ArgumentSemantic.Assign)]
			[SupportedOSPlatform ("ios17.0")]
			[SupportedOSPlatform ("tvos17.0")]
			[SupportedOSPlatform ("maccatalyst17.0")]
			set {
				global::UIKit.UIApplication.EnsureUIThread ();
				global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setUserInterfaceStyle:"), (IntPtr) (long) value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("ios17.0")]
		[SupportedOSPlatform ("tvos17.0")]
		[SupportedOSPlatform ("maccatalyst17.0")]
		public UITraitEnvironmentLayoutDirection LayoutDirection {
			[Export ("layoutDirection", ArgumentSemantic.Assign)]
			[SupportedOSPlatform ("ios17.0")]
			[SupportedOSPlatform ("tvos17.0")]
			[SupportedOSPlatform ("maccatalyst17.0")]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				UITraitEnvironmentLayoutDirection ret;
				ret = (UITraitEnvironmentLayoutDirection) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("layoutDirection"));
				return ret!;
			}
			[Export ("setLayoutDirection:", ArgumentSemantic.Assign)]
			[SupportedOSPlatform ("ios17.0")]
			[SupportedOSPlatform ("tvos17.0")]
			[SupportedOSPlatform ("maccatalyst17.0")]
			set {
				global::UIKit.UIApplication.EnsureUIThread ();
				global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setLayoutDirection:"), (IntPtr) (long) value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("ios17.0")]
		[SupportedOSPlatform ("tvos17.0")]
		[SupportedOSPlatform ("maccatalyst17.0")]
		public nfloat DisplayScale {
			[Export ("displayScale")]
			[SupportedOSPlatform ("ios17.0")]
			[SupportedOSPlatform ("tvos17.0")]
			[SupportedOSPlatform ("maccatalyst17.0")]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				nfloat ret;
				ret = global::ObjCRuntime.Messaging.nfloat_objc_msgSend (this.Handle, Selector.GetHandle ("displayScale"));
				return ret;
			}
			[Export ("setDisplayScale:")]
			[SupportedOSPlatform ("ios17.0")]
			[SupportedOSPlatform ("tvos17.0")]
			[SupportedOSPlatform ("maccatalyst17.0")]
			set {
				global::UIKit.UIApplication.EnsureUIThread ();
				global::ObjCRuntime.Messaging.void_objc_msgSend_nfloat (this.Handle, Selector.GetHandle ("setDisplayScale:"), value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("ios17.0")]
		[SupportedOSPlatform ("tvos17.0")]
		[SupportedOSPlatform ("maccatalyst17.0")]
		public UIUserInterfaceSizeClass HorizontalSizeClass {
			[Export ("horizontalSizeClass", ArgumentSemantic.Assign)]
			[SupportedOSPlatform ("ios17.0")]
			[SupportedOSPlatform ("tvos17.0")]
			[SupportedOSPlatform ("maccatalyst17.0")]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				UIUserInterfaceSizeClass ret;
				ret = (UIUserInterfaceSizeClass) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("horizontalSizeClass"));
				return ret!;
			}
			[Export ("setHorizontalSizeClass:", ArgumentSemantic.Assign)]
			[SupportedOSPlatform ("ios17.0")]
			[SupportedOSPlatform ("tvos17.0")]
			[SupportedOSPlatform ("maccatalyst17.0")]
			set {
				global::UIKit.UIApplication.EnsureUIThread ();
				global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setHorizontalSizeClass:"), (IntPtr) (long) value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("ios17.0")]
		[SupportedOSPlatform ("tvos17.0")]
		[SupportedOSPlatform ("maccatalyst17.0")]
		public UIUserInterfaceSizeClass VerticalSizeClass {
			[Export ("verticalSizeClass", ArgumentSemantic.Assign)]
			[SupportedOSPlatform ("ios17.0")]
			[SupportedOSPlatform ("tvos17.0")]
			[SupportedOSPlatform ("maccatalyst17.0")]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				UIUserInterfaceSizeClass ret;
				ret = (UIUserInterfaceSizeClass) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("verticalSizeClass"));
				return ret!;
			}
			[Export ("setVerticalSizeClass:", ArgumentSemantic.Assign)]
			[SupportedOSPlatform ("ios17.0")]
			[SupportedOSPlatform ("tvos17.0")]
			[SupportedOSPlatform ("maccatalyst17.0")]
			set {
				global::UIKit.UIApplication.EnsureUIThread ();
				global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setVerticalSizeClass:"), (IntPtr) (long) value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("ios17.0")]
		[SupportedOSPlatform ("tvos17.0")]
		[SupportedOSPlatform ("maccatalyst17.0")]
		public UIForceTouchCapability ForceTouchCapability {
			[Export ("forceTouchCapability", ArgumentSemantic.Assign)]
			[SupportedOSPlatform ("ios17.0")]
			[SupportedOSPlatform ("tvos17.0")]
			[SupportedOSPlatform ("maccatalyst17.0")]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				UIForceTouchCapability ret;
				ret = (UIForceTouchCapability) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("forceTouchCapability"));
				return ret!;
			}
			[Export ("setForceTouchCapability:", ArgumentSemantic.Assign)]
			[SupportedOSPlatform ("ios17.0")]
			[SupportedOSPlatform ("tvos17.0")]
			[SupportedOSPlatform ("maccatalyst17.0")]
			set {
				global::UIKit.UIApplication.EnsureUIThread ();
				global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setForceTouchCapability:"), (IntPtr) (long) value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("ios17.0")]
		[SupportedOSPlatform ("tvos17.0")]
		[SupportedOSPlatform ("maccatalyst17.0")]
		public string PreferredContentSizeCategory {
			[Export ("preferredContentSizeCategory")]
			[SupportedOSPlatform ("ios17.0")]
			[SupportedOSPlatform ("tvos17.0")]
			[SupportedOSPlatform ("maccatalyst17.0")]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				string ret;
				ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("preferredContentSizeCategory")), false)!;
				return ret;
			}
			[Export ("setPreferredContentSizeCategory:")]
			[SupportedOSPlatform ("ios17.0")]
			[SupportedOSPlatform ("tvos17.0")]
			[SupportedOSPlatform ("maccatalyst17.0")]
			set {
				global::UIKit.UIApplication.EnsureUIThread ();
				if (value is null)
					ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (value));
				var nsvalue = CFString.CreateNative (value);
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("setPreferredContentSizeCategory:"), nsvalue);
				CFString.ReleaseNative (nsvalue);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("ios17.0")]
		[SupportedOSPlatform ("tvos17.0")]
		[SupportedOSPlatform ("maccatalyst17.0")]
		public UIDisplayGamut DisplayGamut {
			[Export ("displayGamut", ArgumentSemantic.Assign)]
			[SupportedOSPlatform ("ios17.0")]
			[SupportedOSPlatform ("tvos17.0")]
			[SupportedOSPlatform ("maccatalyst17.0")]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				UIDisplayGamut ret;
				ret = (UIDisplayGamut) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("displayGamut"));
				return ret!;
			}
			[Export ("setDisplayGamut:", ArgumentSemantic.Assign)]
			[SupportedOSPlatform ("ios17.0")]
			[SupportedOSPlatform ("tvos17.0")]
			[SupportedOSPlatform ("maccatalyst17.0")]
			set {
				global::UIKit.UIApplication.EnsureUIThread ();
				global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setDisplayGamut:"), (IntPtr) (long) value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("ios17.0")]
		[SupportedOSPlatform ("tvos17.0")]
		[SupportedOSPlatform ("maccatalyst17.0")]
		public UIAccessibilityContrast AccessibilityContrast {
			[Export ("accessibilityContrast", ArgumentSemantic.Assign)]
			[SupportedOSPlatform ("ios17.0")]
			[SupportedOSPlatform ("tvos17.0")]
			[SupportedOSPlatform ("maccatalyst17.0")]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				UIAccessibilityContrast ret;
				ret = (UIAccessibilityContrast) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("accessibilityContrast"));
				return ret!;
			}
			[Export ("setAccessibilityContrast:", ArgumentSemantic.Assign)]
			[SupportedOSPlatform ("ios17.0")]
			[SupportedOSPlatform ("tvos17.0")]
			[SupportedOSPlatform ("maccatalyst17.0")]
			set {
				global::UIKit.UIApplication.EnsureUIThread ();
				global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setAccessibilityContrast:"), (IntPtr) (long) value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios17.0")]
		[SupportedOSPlatform ("maccatalyst17.0")]
		public UIUserInterfaceLevel UserInterfaceLevel {
			[Export ("userInterfaceLevel", ArgumentSemantic.Assign)]
			[UnsupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("ios17.0")]
			[SupportedOSPlatform ("maccatalyst17.0")]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				UIUserInterfaceLevel ret;
				ret = (UIUserInterfaceLevel) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("userInterfaceLevel"));
				return ret!;
			}
			[Export ("setUserInterfaceLevel:", ArgumentSemantic.Assign)]
			[UnsupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("ios17.0")]
			[SupportedOSPlatform ("maccatalyst17.0")]
			set {
				global::UIKit.UIApplication.EnsureUIThread ();
				global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setUserInterfaceLevel:"), (IntPtr) (long) value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("ios17.0")]
		[SupportedOSPlatform ("tvos17.0")]
		[SupportedOSPlatform ("maccatalyst17.0")]
		public UILegibilityWeight LegibilityWeight {
			[Export ("legibilityWeight", ArgumentSemantic.Assign)]
			[SupportedOSPlatform ("ios17.0")]
			[SupportedOSPlatform ("tvos17.0")]
			[SupportedOSPlatform ("maccatalyst17.0")]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				UILegibilityWeight ret;
				ret = (UILegibilityWeight) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("legibilityWeight"));
				return ret!;
			}
			[Export ("setLegibilityWeight:", ArgumentSemantic.Assign)]
			[SupportedOSPlatform ("ios17.0")]
			[SupportedOSPlatform ("tvos17.0")]
			[SupportedOSPlatform ("maccatalyst17.0")]
			set {
				global::UIKit.UIApplication.EnsureUIThread ();
				global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setLegibilityWeight:"), (IntPtr) (long) value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("ios17.0")]
		[SupportedOSPlatform ("tvos17.0")]
		[SupportedOSPlatform ("maccatalyst17.0")]
		public global::UIKit.UIUserInterfaceActiveAppearance ActiveAppearance {
			[Export ("activeAppearance", ArgumentSemantic.Assign)]
			[SupportedOSPlatform ("ios17.0")]
			[SupportedOSPlatform ("tvos17.0")]
			[SupportedOSPlatform ("maccatalyst17.0")]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				global::UIKit.UIUserInterfaceActiveAppearance ret;
				ret = (UIUserInterfaceActiveAppearance) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("activeAppearance"));
				return ret!;
			}
			[Export ("setActiveAppearance:", ArgumentSemantic.Assign)]
			[SupportedOSPlatform ("ios17.0")]
			[SupportedOSPlatform ("tvos17.0")]
			[SupportedOSPlatform ("maccatalyst17.0")]
			set {
				global::UIKit.UIApplication.EnsureUIThread ();
				global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setActiveAppearance:"), (IntPtr) (long) value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("ios17.0")]
		[SupportedOSPlatform ("tvos17.0")]
		[SupportedOSPlatform ("maccatalyst17.0")]
		public UINSToolbarItemPresentationSize ToolbarItemPresentationSize {
			[Export ("toolbarItemPresentationSize", ArgumentSemantic.Assign)]
			[SupportedOSPlatform ("ios17.0")]
			[SupportedOSPlatform ("tvos17.0")]
			[SupportedOSPlatform ("maccatalyst17.0")]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				UINSToolbarItemPresentationSize ret;
				ret = (UINSToolbarItemPresentationSize) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("toolbarItemPresentationSize"));
				return ret!;
			}
			[Export ("setToolbarItemPresentationSize:", ArgumentSemantic.Assign)]
			[SupportedOSPlatform ("ios17.0")]
			[SupportedOSPlatform ("tvos17.0")]
			[SupportedOSPlatform ("maccatalyst17.0")]
			set {
				global::UIKit.UIApplication.EnsureUIThread ();
				global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setToolbarItemPresentationSize:"), (IntPtr) (long) value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("ios17.0")]
		[SupportedOSPlatform ("tvos17.0")]
		[SupportedOSPlatform ("maccatalyst17.0")]
		public UIImageDynamicRange ImageDynamicRange {
			[Export ("imageDynamicRange", ArgumentSemantic.Assign)]
			[SupportedOSPlatform ("ios17.0")]
			[SupportedOSPlatform ("tvos17.0")]
			[SupportedOSPlatform ("maccatalyst17.0")]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				UIImageDynamicRange ret;
				ret = (UIImageDynamicRange) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("imageDynamicRange"));
				return ret!;
			}
			[Export ("setImageDynamicRange:", ArgumentSemantic.Assign)]
			[SupportedOSPlatform ("ios17.0")]
			[SupportedOSPlatform ("tvos17.0")]
			[SupportedOSPlatform ("maccatalyst17.0")]
			set {
				global::UIKit.UIApplication.EnsureUIThread ();
				global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setImageDynamicRange:"), (IntPtr) (long) value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("ios17.0")]
		[SupportedOSPlatform ("tvos17.0")]
		[SupportedOSPlatform ("maccatalyst17.0")]
		public UISceneCaptureState SceneCaptureState {
			[Export ("sceneCaptureState", ArgumentSemantic.Assign)]
			[SupportedOSPlatform ("ios17.0")]
			[SupportedOSPlatform ("tvos17.0")]
			[SupportedOSPlatform ("maccatalyst17.0")]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				UISceneCaptureState ret;
				ret = (UISceneCaptureState) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("sceneCaptureState"));
				return ret!;
			}
			[Export ("setSceneCaptureState:", ArgumentSemantic.Assign)]
			[SupportedOSPlatform ("ios17.0")]
			[SupportedOSPlatform ("tvos17.0")]
			[SupportedOSPlatform ("maccatalyst17.0")]
			set {
				global::UIKit.UIApplication.EnsureUIThread ();
				global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setSceneCaptureState:"), (IntPtr) (long) value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("ios17.0")]
		[SupportedOSPlatform ("tvos17.0")]
		[SupportedOSPlatform ("maccatalyst17.0")]
		public string TypesettingLanguage {
			[Export ("typesettingLanguage")]
			[SupportedOSPlatform ("ios17.0")]
			[SupportedOSPlatform ("tvos17.0")]
			[SupportedOSPlatform ("maccatalyst17.0")]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				string ret;
				ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("typesettingLanguage")), false)!;
				return ret;
			}
			[Export ("setTypesettingLanguage:")]
			[SupportedOSPlatform ("ios17.0")]
			[SupportedOSPlatform ("tvos17.0")]
			[SupportedOSPlatform ("maccatalyst17.0")]
			set {
				global::UIKit.UIApplication.EnsureUIThread ();
				if (value is null)
					ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (value));
				var nsvalue = CFString.CreateNative (value);
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("setTypesettingLanguage:"), nsvalue);
				CFString.ReleaseNative (nsvalue);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("tvos18.0")]
		[SupportedOSPlatform ("ios18.0")]
		[SupportedOSPlatform ("maccatalyst18.0")]
		public UIListEnvironment ListEnvironment {
			[Export ("listEnvironment")]
			[SupportedOSPlatform ("ios18.0")]
			[SupportedOSPlatform ("tvos18.0")]
			[SupportedOSPlatform ("maccatalyst18.0")]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				UIListEnvironment ret;
				ret = (UIListEnvironment) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("listEnvironment"));
				return ret!;
			}
			[Export ("setListEnvironment:")]
			[SupportedOSPlatform ("ios18.0")]
			[SupportedOSPlatform ("tvos18.0")]
			[SupportedOSPlatform ("maccatalyst18.0")]
			set {
				global::UIKit.UIApplication.EnsureUIThread ();
				global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setListEnvironment:"), (IntPtr) (long) value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios26.0")]
		[SupportedOSPlatform ("maccatalyst26.0")]
		public UITabAccessoryEnvironment TabAccessoryEnvironment {
			[Export ("tabAccessoryEnvironment", ArgumentSemantic.Assign)]
			[UnsupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("ios26.0")]
			[SupportedOSPlatform ("maccatalyst26.0")]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				UITabAccessoryEnvironment ret;
				ret = (UITabAccessoryEnvironment) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("tabAccessoryEnvironment"));
				return ret!;
			}
			[Export ("setTabAccessoryEnvironment:", ArgumentSemantic.Assign)]
			[UnsupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("ios26.0")]
			[SupportedOSPlatform ("maccatalyst26.0")]
			set {
				global::UIKit.UIApplication.EnsureUIThread ();
				global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setTabAccessoryEnvironment:"), (IntPtr) (long) value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("tvos26.0")]
		[SupportedOSPlatform ("ios26.0")]
		[SupportedOSPlatform ("maccatalyst26.0")]
		public UISplitViewControllerLayoutEnvironment SplitViewControllerLayoutEnvironment {
			[Export ("splitViewControllerLayoutEnvironment", ArgumentSemantic.Assign)]
			[SupportedOSPlatform ("ios26.0")]
			[SupportedOSPlatform ("tvos26.0")]
			[SupportedOSPlatform ("maccatalyst26.0")]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				UISplitViewControllerLayoutEnvironment ret;
				ret = (UISplitViewControllerLayoutEnvironment) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("splitViewControllerLayoutEnvironment"));
				return ret!;
			}
			[Export ("setSplitViewControllerLayoutEnvironment:", ArgumentSemantic.Assign)]
			[SupportedOSPlatform ("ios26.0")]
			[SupportedOSPlatform ("tvos26.0")]
			[SupportedOSPlatform ("maccatalyst26.0")]
			set {
				global::UIKit.UIApplication.EnsureUIThread ();
				global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setSplitViewControllerLayoutEnvironment:"), (IntPtr) (long) value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("tvos26.0")]
		[SupportedOSPlatform ("ios26.0")]
		[SupportedOSPlatform ("maccatalyst26.0")]
		public bool ResolvesNaturalAlignmentWithBaseWritingDirection {
			[Export ("resolvesNaturalAlignmentWithBaseWritingDirection")]
			[SupportedOSPlatform ("ios26.0")]
			[SupportedOSPlatform ("tvos26.0")]
			[SupportedOSPlatform ("maccatalyst26.0")]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				byte ret;
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("resolvesNaturalAlignmentWithBaseWritingDirection"));
				return ret != 0;
			}
			[Export ("setResolvesNaturalAlignmentWithBaseWritingDirection:")]
			[SupportedOSPlatform ("ios26.0")]
			[SupportedOSPlatform ("tvos26.0")]
			[SupportedOSPlatform ("maccatalyst26.0")]
			set {
				global::UIKit.UIApplication.EnsureUIThread ();
				global::ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("setResolvesNaturalAlignmentWithBaseWritingDirection:"), value ? (byte) 1 : (byte) 0);
			}
		}
	}
}
