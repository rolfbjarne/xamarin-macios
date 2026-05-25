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
	/// <summary>This interface represents the Objective-C protocol <c>UIMutableTraits</c>.</summary>
	/// <remarks>
	///   <para>A class that implements this interface (and subclasses <see cref="NSObject" />) will be exported to Objective-C as implementing the Objective-C protocol this interface represents.</para>
	///   <para>A class may also implement members from this interface to implement members from the protocol.</para>
	/// </remarks>
	[SupportedOSPlatform ("tvos17.0")]
	[SupportedOSPlatform ("ios17.0")]
	[SupportedOSPlatform ("maccatalyst17.0")]
	[Protocol (Name = "UIMutableTraits", WrapperType = typeof (UIMutableTraitsWrapper))]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "SetValue", Selector = "setCGFloatValue:forTrait:", ParameterType = new Type [] { typeof (NFloat), typeof (IUICGFloatTraitDefinition) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "GetValue", Selector = "valueForCGFloatTrait:", ReturnType = typeof (NFloat), ParameterType = new Type [] { typeof (IUICGFloatTraitDefinition) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "SetValue", Selector = "setNSIntegerValue:forTrait:", ParameterType = new Type [] { typeof (IntPtr), typeof (IUINSIntegerTraitDefinition) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "GetValue", Selector = "valueForNSIntegerTrait:", ReturnType = typeof (IntPtr), ParameterType = new Type [] { typeof (IUINSIntegerTraitDefinition) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "SetObject", Selector = "setObject:forTrait:", ParameterType = new Type [] { typeof (NSObject), typeof (IUIObjectTraitDefinition) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "GetObject", Selector = "objectForTrait:", ReturnType = typeof (NSObject), ParameterType = new Type [] { typeof (IUIObjectTraitDefinition) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "UserInterfaceIdiom", Selector = "userInterfaceIdiom", PropertyType = typeof (UIUserInterfaceIdiom), GetterSelector = "userInterfaceIdiom", SetterSelector = "setUserInterfaceIdiom:", ArgumentSemantic = ArgumentSemantic.Assign)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "UserInterfaceStyle", Selector = "userInterfaceStyle", PropertyType = typeof (UIUserInterfaceStyle), GetterSelector = "userInterfaceStyle", SetterSelector = "setUserInterfaceStyle:", ArgumentSemantic = ArgumentSemantic.Assign)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "LayoutDirection", Selector = "layoutDirection", PropertyType = typeof (UITraitEnvironmentLayoutDirection), GetterSelector = "layoutDirection", SetterSelector = "setLayoutDirection:", ArgumentSemantic = ArgumentSemantic.Assign)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "DisplayScale", Selector = "displayScale", PropertyType = typeof (NFloat), GetterSelector = "displayScale", SetterSelector = "setDisplayScale:", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "HorizontalSizeClass", Selector = "horizontalSizeClass", PropertyType = typeof (UIUserInterfaceSizeClass), GetterSelector = "horizontalSizeClass", SetterSelector = "setHorizontalSizeClass:", ArgumentSemantic = ArgumentSemantic.Assign)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "VerticalSizeClass", Selector = "verticalSizeClass", PropertyType = typeof (UIUserInterfaceSizeClass), GetterSelector = "verticalSizeClass", SetterSelector = "setVerticalSizeClass:", ArgumentSemantic = ArgumentSemantic.Assign)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "ForceTouchCapability", Selector = "forceTouchCapability", PropertyType = typeof (UIForceTouchCapability), GetterSelector = "forceTouchCapability", SetterSelector = "setForceTouchCapability:", ArgumentSemantic = ArgumentSemantic.Assign)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "PreferredContentSizeCategory", Selector = "preferredContentSizeCategory", PropertyType = typeof (string), GetterSelector = "preferredContentSizeCategory", SetterSelector = "setPreferredContentSizeCategory:", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "DisplayGamut", Selector = "displayGamut", PropertyType = typeof (UIDisplayGamut), GetterSelector = "displayGamut", SetterSelector = "setDisplayGamut:", ArgumentSemantic = ArgumentSemantic.Assign)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "AccessibilityContrast", Selector = "accessibilityContrast", PropertyType = typeof (UIAccessibilityContrast), GetterSelector = "accessibilityContrast", SetterSelector = "setAccessibilityContrast:", ArgumentSemantic = ArgumentSemantic.Assign)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "UserInterfaceLevel", Selector = "userInterfaceLevel", PropertyType = typeof (UIUserInterfaceLevel), GetterSelector = "userInterfaceLevel", SetterSelector = "setUserInterfaceLevel:", ArgumentSemantic = ArgumentSemantic.Assign)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "LegibilityWeight", Selector = "legibilityWeight", PropertyType = typeof (UILegibilityWeight), GetterSelector = "legibilityWeight", SetterSelector = "setLegibilityWeight:", ArgumentSemantic = ArgumentSemantic.Assign)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "ActiveAppearance", Selector = "activeAppearance", PropertyType = typeof (UIUserInterfaceActiveAppearance), GetterSelector = "activeAppearance", SetterSelector = "setActiveAppearance:", ArgumentSemantic = ArgumentSemantic.Assign)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "ToolbarItemPresentationSize", Selector = "toolbarItemPresentationSize", PropertyType = typeof (UINSToolbarItemPresentationSize), GetterSelector = "toolbarItemPresentationSize", SetterSelector = "setToolbarItemPresentationSize:", ArgumentSemantic = ArgumentSemantic.Assign)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "ImageDynamicRange", Selector = "imageDynamicRange", PropertyType = typeof (UIImageDynamicRange), GetterSelector = "imageDynamicRange", SetterSelector = "setImageDynamicRange:", ArgumentSemantic = ArgumentSemantic.Assign)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "SceneCaptureState", Selector = "sceneCaptureState", PropertyType = typeof (UISceneCaptureState), GetterSelector = "sceneCaptureState", SetterSelector = "setSceneCaptureState:", ArgumentSemantic = ArgumentSemantic.Assign)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "TypesettingLanguage", Selector = "typesettingLanguage", PropertyType = typeof (string), GetterSelector = "typesettingLanguage", SetterSelector = "setTypesettingLanguage:", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "ListEnvironment", Selector = "listEnvironment", PropertyType = typeof (UIListEnvironment), GetterSelector = "listEnvironment", SetterSelector = "setListEnvironment:", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "TabAccessoryEnvironment", Selector = "tabAccessoryEnvironment", PropertyType = typeof (UITabAccessoryEnvironment), GetterSelector = "tabAccessoryEnvironment", SetterSelector = "setTabAccessoryEnvironment:", ArgumentSemantic = ArgumentSemantic.Assign)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "SplitViewControllerLayoutEnvironment", Selector = "splitViewControllerLayoutEnvironment", PropertyType = typeof (UISplitViewControllerLayoutEnvironment), GetterSelector = "splitViewControllerLayoutEnvironment", SetterSelector = "setSplitViewControllerLayoutEnvironment:", ArgumentSemantic = ArgumentSemantic.Assign)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "ResolvesNaturalAlignmentWithBaseWritingDirection", Selector = "resolvesNaturalAlignmentWithBaseWritingDirection", PropertyType = typeof (bool), GetterSelector = "resolvesNaturalAlignmentWithBaseWritingDirection", SetterSelector = "setResolvesNaturalAlignmentWithBaseWritingDirection:", ArgumentSemantic = ArgumentSemantic.None)]
	public partial interface IUIMutableTraits : INativeObject, IDisposable
	{
		[global::Foundation.RequiredMember]
		[Export ("setCGFloatValue:forTrait:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetValue (nfloat value, IUICGFloatTraitDefinition trait)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SetValue (IUIMutableTraits This, nfloat value, IUICGFloatTraitDefinition trait)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var trait__handle__ = trait!.GetNonNullHandle (nameof (trait));
			global::ObjCRuntime.Messaging.void_objc_msgSend_nfloat_NativeHandle (This.Handle, Selector.GetHandle ("setCGFloatValue:forTrait:"), value, trait__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (trait);
		}
		[global::Foundation.RequiredMember]
		[Export ("valueForCGFloatTrait:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual nfloat GetValue (IUICGFloatTraitDefinition trait)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static nfloat _GetValue (IUIMutableTraits This, IUICGFloatTraitDefinition trait)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var trait__handle__ = trait!.GetNonNullHandle (nameof (trait));
			nfloat ret;
			ret = global::ObjCRuntime.Messaging.nfloat_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("valueForCGFloatTrait:"), trait__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (trait);
			return ret!;
		}
		[global::Foundation.RequiredMember]
		[Export ("setNSIntegerValue:forTrait:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetValue (nint value, IUINSIntegerTraitDefinition trait)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SetValue (IUIMutableTraits This, nint value, IUINSIntegerTraitDefinition trait)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var trait__handle__ = trait!.GetNonNullHandle (nameof (trait));
			global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr_NativeHandle (This.Handle, Selector.GetHandle ("setNSIntegerValue:forTrait:"), value, trait__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (trait);
		}
		[global::Foundation.RequiredMember]
		[Export ("valueForNSIntegerTrait:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual nint GetValue (IUINSIntegerTraitDefinition trait)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static nint _GetValue (IUIMutableTraits This, IUINSIntegerTraitDefinition trait)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var trait__handle__ = trait!.GetNonNullHandle (nameof (trait));
			nint ret;
			ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("valueForNSIntegerTrait:"), trait__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (trait);
			return ret!;
		}
		[global::Foundation.RequiredMember]
		[Export ("setObject:forTrait:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetObject (NSObject? @object, IUIObjectTraitDefinition trait)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SetObject (IUIMutableTraits This, NSObject? @object, IUIObjectTraitDefinition trait)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var @object__handle__ = @object.GetHandle ();
			var trait__handle__ = trait!.GetNonNullHandle (nameof (trait));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("setObject:forTrait:"), @object__handle__, trait__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (@object);
			GC.KeepAlive (trait);
		}
		[global::Foundation.RequiredMember]
		[Export ("objectForTrait:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSObject? GetObject (IUIObjectTraitDefinition trait)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static NSObject? _GetObject (IUIMutableTraits This, IUIObjectTraitDefinition trait)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var trait__handle__ = trait!.GetNonNullHandle (nameof (trait));
			NSObject? ret;
			ret = Runtime.GetNSObject (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("objectForTrait:"), trait__handle__), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (trait);
			return ret!;
		}
		[DynamicDependencyAttribute ("AccessibilityContrast")]
		[DynamicDependencyAttribute ("ActiveAppearance")]
		[DynamicDependencyAttribute ("DisplayGamut")]
		[DynamicDependencyAttribute ("DisplayScale")]
		[DynamicDependencyAttribute ("ForceTouchCapability")]
		[DynamicDependencyAttribute ("GetObject(UIKit.IUIObjectTraitDefinition)")]
		[DynamicDependencyAttribute ("GetValue(UIKit.IUICGFloatTraitDefinition)")]
		[DynamicDependencyAttribute ("GetValue(UIKit.IUINSIntegerTraitDefinition)")]
		[DynamicDependencyAttribute ("HorizontalSizeClass")]
		[DynamicDependencyAttribute ("ImageDynamicRange")]
		[DynamicDependencyAttribute ("LayoutDirection")]
		[DynamicDependencyAttribute ("LegibilityWeight")]
		[DynamicDependencyAttribute ("ListEnvironment")]
		[DynamicDependencyAttribute ("PreferredContentSizeCategory")]
		[DynamicDependencyAttribute ("ResolvesNaturalAlignmentWithBaseWritingDirection")]
		[DynamicDependencyAttribute ("SceneCaptureState")]
		[DynamicDependencyAttribute ("SetObject(Foundation.NSObject,UIKit.IUIObjectTraitDefinition)")]
		[DynamicDependencyAttribute ("SetValue(System.IntPtr,UIKit.IUINSIntegerTraitDefinition)")]
		[DynamicDependencyAttribute ("SetValue(System.Runtime.InteropServices.NFloat,UIKit.IUICGFloatTraitDefinition)")]
		[DynamicDependencyAttribute ("SplitViewControllerLayoutEnvironment")]
		[DynamicDependencyAttribute ("TabAccessoryEnvironment")]
		[DynamicDependencyAttribute ("ToolbarItemPresentationSize")]
		[DynamicDependencyAttribute ("TypesettingLanguage")]
		[DynamicDependencyAttribute ("UserInterfaceIdiom")]
		[DynamicDependencyAttribute ("UserInterfaceLevel")]
		[DynamicDependencyAttribute ("UserInterfaceStyle")]
		[DynamicDependencyAttribute ("VerticalSizeClass")]
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.Interfaces | DynamicallyAccessedMemberTypes.PublicConstructors, typeof (UIMutableTraitsWrapper))]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static IUIMutableTraits ()
		{
			GC.KeepAlive (null);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual UIUserInterfaceIdiom UserInterfaceIdiom {
			[Export ("userInterfaceIdiom", ArgumentSemantic.Assign)]
			get {
				return _GetUserInterfaceIdiom (this);
			}
			[Export ("setUserInterfaceIdiom:", ArgumentSemantic.Assign)]
			set {
				_SetUserInterfaceIdiom (this, value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static UIUserInterfaceIdiom _GetUserInterfaceIdiom (IUIMutableTraits This)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			UIUserInterfaceIdiom ret;
			ret = (UIUserInterfaceIdiom) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (This.Handle, Selector.GetHandle ("userInterfaceIdiom"));
			GC.KeepAlive (This);
			return ret!;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SetUserInterfaceIdiom (IUIMutableTraits This, UIUserInterfaceIdiom value)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("setUserInterfaceIdiom:"), (IntPtr) (long) value);
			GC.KeepAlive (This);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual UIUserInterfaceStyle UserInterfaceStyle {
			[Export ("userInterfaceStyle", ArgumentSemantic.Assign)]
			get {
				return _GetUserInterfaceStyle (this);
			}
			[Export ("setUserInterfaceStyle:", ArgumentSemantic.Assign)]
			set {
				_SetUserInterfaceStyle (this, value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static UIUserInterfaceStyle _GetUserInterfaceStyle (IUIMutableTraits This)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			UIUserInterfaceStyle ret;
			ret = (UIUserInterfaceStyle) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (This.Handle, Selector.GetHandle ("userInterfaceStyle"));
			GC.KeepAlive (This);
			return ret!;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SetUserInterfaceStyle (IUIMutableTraits This, UIUserInterfaceStyle value)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("setUserInterfaceStyle:"), (IntPtr) (long) value);
			GC.KeepAlive (This);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual UITraitEnvironmentLayoutDirection LayoutDirection {
			[Export ("layoutDirection", ArgumentSemantic.Assign)]
			get {
				return _GetLayoutDirection (this);
			}
			[Export ("setLayoutDirection:", ArgumentSemantic.Assign)]
			set {
				_SetLayoutDirection (this, value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static UITraitEnvironmentLayoutDirection _GetLayoutDirection (IUIMutableTraits This)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			UITraitEnvironmentLayoutDirection ret;
			ret = (UITraitEnvironmentLayoutDirection) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (This.Handle, Selector.GetHandle ("layoutDirection"));
			GC.KeepAlive (This);
			return ret!;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SetLayoutDirection (IUIMutableTraits This, UITraitEnvironmentLayoutDirection value)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("setLayoutDirection:"), (IntPtr) (long) value);
			GC.KeepAlive (This);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual nfloat DisplayScale {
			[Export ("displayScale")]
			get {
				return _GetDisplayScale (this);
			}
			[Export ("setDisplayScale:")]
			set {
				_SetDisplayScale (this, value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static nfloat _GetDisplayScale (IUIMutableTraits This)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			nfloat ret;
			ret = global::ObjCRuntime.Messaging.nfloat_objc_msgSend (This.Handle, Selector.GetHandle ("displayScale"));
			GC.KeepAlive (This);
			return ret;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SetDisplayScale (IUIMutableTraits This, nfloat value)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			global::ObjCRuntime.Messaging.void_objc_msgSend_nfloat (This.Handle, Selector.GetHandle ("setDisplayScale:"), value);
			GC.KeepAlive (This);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual UIUserInterfaceSizeClass HorizontalSizeClass {
			[Export ("horizontalSizeClass", ArgumentSemantic.Assign)]
			get {
				return _GetHorizontalSizeClass (this);
			}
			[Export ("setHorizontalSizeClass:", ArgumentSemantic.Assign)]
			set {
				_SetHorizontalSizeClass (this, value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static UIUserInterfaceSizeClass _GetHorizontalSizeClass (IUIMutableTraits This)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			UIUserInterfaceSizeClass ret;
			ret = (UIUserInterfaceSizeClass) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (This.Handle, Selector.GetHandle ("horizontalSizeClass"));
			GC.KeepAlive (This);
			return ret!;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SetHorizontalSizeClass (IUIMutableTraits This, UIUserInterfaceSizeClass value)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("setHorizontalSizeClass:"), (IntPtr) (long) value);
			GC.KeepAlive (This);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual UIUserInterfaceSizeClass VerticalSizeClass {
			[Export ("verticalSizeClass", ArgumentSemantic.Assign)]
			get {
				return _GetVerticalSizeClass (this);
			}
			[Export ("setVerticalSizeClass:", ArgumentSemantic.Assign)]
			set {
				_SetVerticalSizeClass (this, value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static UIUserInterfaceSizeClass _GetVerticalSizeClass (IUIMutableTraits This)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			UIUserInterfaceSizeClass ret;
			ret = (UIUserInterfaceSizeClass) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (This.Handle, Selector.GetHandle ("verticalSizeClass"));
			GC.KeepAlive (This);
			return ret!;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SetVerticalSizeClass (IUIMutableTraits This, UIUserInterfaceSizeClass value)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("setVerticalSizeClass:"), (IntPtr) (long) value);
			GC.KeepAlive (This);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual UIForceTouchCapability ForceTouchCapability {
			[Export ("forceTouchCapability", ArgumentSemantic.Assign)]
			get {
				return _GetForceTouchCapability (this);
			}
			[Export ("setForceTouchCapability:", ArgumentSemantic.Assign)]
			set {
				_SetForceTouchCapability (this, value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static UIForceTouchCapability _GetForceTouchCapability (IUIMutableTraits This)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			UIForceTouchCapability ret;
			ret = (UIForceTouchCapability) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (This.Handle, Selector.GetHandle ("forceTouchCapability"));
			GC.KeepAlive (This);
			return ret!;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SetForceTouchCapability (IUIMutableTraits This, UIForceTouchCapability value)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("setForceTouchCapability:"), (IntPtr) (long) value);
			GC.KeepAlive (This);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual string PreferredContentSizeCategory {
			[Export ("preferredContentSizeCategory")]
			get {
				return _GetPreferredContentSizeCategory (this);
			}
			[Export ("setPreferredContentSizeCategory:")]
			set {
				_SetPreferredContentSizeCategory (this, value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static string _GetPreferredContentSizeCategory (IUIMutableTraits This)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			string ret;
			ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("preferredContentSizeCategory")), false)!;
			GC.KeepAlive (This);
			return ret;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SetPreferredContentSizeCategory (IUIMutableTraits This, string value)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			if (value is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (value));
			var nsvalue = CFString.CreateNative (value);
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("setPreferredContentSizeCategory:"), nsvalue);
			GC.KeepAlive (This);
			CFString.ReleaseNative (nsvalue);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual UIDisplayGamut DisplayGamut {
			[Export ("displayGamut", ArgumentSemantic.Assign)]
			get {
				return _GetDisplayGamut (this);
			}
			[Export ("setDisplayGamut:", ArgumentSemantic.Assign)]
			set {
				_SetDisplayGamut (this, value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static UIDisplayGamut _GetDisplayGamut (IUIMutableTraits This)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			UIDisplayGamut ret;
			ret = (UIDisplayGamut) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (This.Handle, Selector.GetHandle ("displayGamut"));
			GC.KeepAlive (This);
			return ret!;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SetDisplayGamut (IUIMutableTraits This, UIDisplayGamut value)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("setDisplayGamut:"), (IntPtr) (long) value);
			GC.KeepAlive (This);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual UIAccessibilityContrast AccessibilityContrast {
			[Export ("accessibilityContrast", ArgumentSemantic.Assign)]
			get {
				return _GetAccessibilityContrast (this);
			}
			[Export ("setAccessibilityContrast:", ArgumentSemantic.Assign)]
			set {
				_SetAccessibilityContrast (this, value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static UIAccessibilityContrast _GetAccessibilityContrast (IUIMutableTraits This)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			UIAccessibilityContrast ret;
			ret = (UIAccessibilityContrast) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (This.Handle, Selector.GetHandle ("accessibilityContrast"));
			GC.KeepAlive (This);
			return ret!;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SetAccessibilityContrast (IUIMutableTraits This, UIAccessibilityContrast value)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("setAccessibilityContrast:"), (IntPtr) (long) value);
			GC.KeepAlive (This);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios17.0")]
		[SupportedOSPlatform ("maccatalyst17.0")]
		[global::Foundation.RequiredMember]
		public virtual UIUserInterfaceLevel UserInterfaceLevel {
			[Export ("userInterfaceLevel", ArgumentSemantic.Assign)]
			get {
				return _GetUserInterfaceLevel (this);
			}
			[Export ("setUserInterfaceLevel:", ArgumentSemantic.Assign)]
			set {
				_SetUserInterfaceLevel (this, value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static UIUserInterfaceLevel _GetUserInterfaceLevel (IUIMutableTraits This)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			UIUserInterfaceLevel ret;
			ret = (UIUserInterfaceLevel) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (This.Handle, Selector.GetHandle ("userInterfaceLevel"));
			GC.KeepAlive (This);
			return ret!;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SetUserInterfaceLevel (IUIMutableTraits This, UIUserInterfaceLevel value)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("setUserInterfaceLevel:"), (IntPtr) (long) value);
			GC.KeepAlive (This);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual UILegibilityWeight LegibilityWeight {
			[Export ("legibilityWeight", ArgumentSemantic.Assign)]
			get {
				return _GetLegibilityWeight (this);
			}
			[Export ("setLegibilityWeight:", ArgumentSemantic.Assign)]
			set {
				_SetLegibilityWeight (this, value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static UILegibilityWeight _GetLegibilityWeight (IUIMutableTraits This)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			UILegibilityWeight ret;
			ret = (UILegibilityWeight) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (This.Handle, Selector.GetHandle ("legibilityWeight"));
			GC.KeepAlive (This);
			return ret!;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SetLegibilityWeight (IUIMutableTraits This, UILegibilityWeight value)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("setLegibilityWeight:"), (IntPtr) (long) value);
			GC.KeepAlive (This);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual global::UIKit.UIUserInterfaceActiveAppearance ActiveAppearance {
			[Export ("activeAppearance", ArgumentSemantic.Assign)]
			get {
				return _GetActiveAppearance (this);
			}
			[Export ("setActiveAppearance:", ArgumentSemantic.Assign)]
			set {
				_SetActiveAppearance (this, value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static global::UIKit.UIUserInterfaceActiveAppearance _GetActiveAppearance (IUIMutableTraits This)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			global::UIKit.UIUserInterfaceActiveAppearance ret;
			ret = (UIUserInterfaceActiveAppearance) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (This.Handle, Selector.GetHandle ("activeAppearance"));
			GC.KeepAlive (This);
			return ret!;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SetActiveAppearance (IUIMutableTraits This, global::UIKit.UIUserInterfaceActiveAppearance value)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("setActiveAppearance:"), (IntPtr) (long) value);
			GC.KeepAlive (This);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual UINSToolbarItemPresentationSize ToolbarItemPresentationSize {
			[Export ("toolbarItemPresentationSize", ArgumentSemantic.Assign)]
			get {
				return _GetToolbarItemPresentationSize (this);
			}
			[Export ("setToolbarItemPresentationSize:", ArgumentSemantic.Assign)]
			set {
				_SetToolbarItemPresentationSize (this, value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static UINSToolbarItemPresentationSize _GetToolbarItemPresentationSize (IUIMutableTraits This)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			UINSToolbarItemPresentationSize ret;
			ret = (UINSToolbarItemPresentationSize) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (This.Handle, Selector.GetHandle ("toolbarItemPresentationSize"));
			GC.KeepAlive (This);
			return ret!;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SetToolbarItemPresentationSize (IUIMutableTraits This, UINSToolbarItemPresentationSize value)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("setToolbarItemPresentationSize:"), (IntPtr) (long) value);
			GC.KeepAlive (This);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual UIImageDynamicRange ImageDynamicRange {
			[Export ("imageDynamicRange", ArgumentSemantic.Assign)]
			get {
				return _GetImageDynamicRange (this);
			}
			[Export ("setImageDynamicRange:", ArgumentSemantic.Assign)]
			set {
				_SetImageDynamicRange (this, value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static UIImageDynamicRange _GetImageDynamicRange (IUIMutableTraits This)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			UIImageDynamicRange ret;
			ret = (UIImageDynamicRange) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (This.Handle, Selector.GetHandle ("imageDynamicRange"));
			GC.KeepAlive (This);
			return ret!;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SetImageDynamicRange (IUIMutableTraits This, UIImageDynamicRange value)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("setImageDynamicRange:"), (IntPtr) (long) value);
			GC.KeepAlive (This);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual UISceneCaptureState SceneCaptureState {
			[Export ("sceneCaptureState", ArgumentSemantic.Assign)]
			get {
				return _GetSceneCaptureState (this);
			}
			[Export ("setSceneCaptureState:", ArgumentSemantic.Assign)]
			set {
				_SetSceneCaptureState (this, value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static UISceneCaptureState _GetSceneCaptureState (IUIMutableTraits This)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			UISceneCaptureState ret;
			ret = (UISceneCaptureState) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (This.Handle, Selector.GetHandle ("sceneCaptureState"));
			GC.KeepAlive (This);
			return ret!;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SetSceneCaptureState (IUIMutableTraits This, UISceneCaptureState value)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("setSceneCaptureState:"), (IntPtr) (long) value);
			GC.KeepAlive (This);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual string TypesettingLanguage {
			[Export ("typesettingLanguage")]
			get {
				return _GetTypesettingLanguage (this);
			}
			[Export ("setTypesettingLanguage:")]
			set {
				_SetTypesettingLanguage (this, value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static string _GetTypesettingLanguage (IUIMutableTraits This)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			string ret;
			ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("typesettingLanguage")), false)!;
			GC.KeepAlive (This);
			return ret;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SetTypesettingLanguage (IUIMutableTraits This, string value)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			if (value is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (value));
			var nsvalue = CFString.CreateNative (value);
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("setTypesettingLanguage:"), nsvalue);
			GC.KeepAlive (This);
			CFString.ReleaseNative (nsvalue);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("tvos18.0")]
		[SupportedOSPlatform ("ios18.0")]
		[SupportedOSPlatform ("maccatalyst18.0")]
		[global::Foundation.RequiredMember]
		public virtual UIListEnvironment ListEnvironment {
			[Export ("listEnvironment")]
			get {
				return _GetListEnvironment (this);
			}
			[Export ("setListEnvironment:")]
			set {
				_SetListEnvironment (this, value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static UIListEnvironment _GetListEnvironment (IUIMutableTraits This)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			UIListEnvironment ret;
			ret = (UIListEnvironment) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (This.Handle, Selector.GetHandle ("listEnvironment"));
			GC.KeepAlive (This);
			return ret!;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SetListEnvironment (IUIMutableTraits This, UIListEnvironment value)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("setListEnvironment:"), (IntPtr) (long) value);
			GC.KeepAlive (This);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios26.0")]
		[SupportedOSPlatform ("maccatalyst26.0")]
		[global::Foundation.RequiredMember]
		public virtual UITabAccessoryEnvironment TabAccessoryEnvironment {
			[Export ("tabAccessoryEnvironment", ArgumentSemantic.Assign)]
			get {
				return _GetTabAccessoryEnvironment (this);
			}
			[Export ("setTabAccessoryEnvironment:", ArgumentSemantic.Assign)]
			set {
				_SetTabAccessoryEnvironment (this, value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static UITabAccessoryEnvironment _GetTabAccessoryEnvironment (IUIMutableTraits This)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			UITabAccessoryEnvironment ret;
			ret = (UITabAccessoryEnvironment) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (This.Handle, Selector.GetHandle ("tabAccessoryEnvironment"));
			GC.KeepAlive (This);
			return ret!;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SetTabAccessoryEnvironment (IUIMutableTraits This, UITabAccessoryEnvironment value)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("setTabAccessoryEnvironment:"), (IntPtr) (long) value);
			GC.KeepAlive (This);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("tvos26.0")]
		[SupportedOSPlatform ("ios26.0")]
		[SupportedOSPlatform ("maccatalyst26.0")]
		[global::Foundation.RequiredMember]
		public virtual UISplitViewControllerLayoutEnvironment SplitViewControllerLayoutEnvironment {
			[Export ("splitViewControllerLayoutEnvironment", ArgumentSemantic.Assign)]
			get {
				return _GetSplitViewControllerLayoutEnvironment (this);
			}
			[Export ("setSplitViewControllerLayoutEnvironment:", ArgumentSemantic.Assign)]
			set {
				_SetSplitViewControllerLayoutEnvironment (this, value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static UISplitViewControllerLayoutEnvironment _GetSplitViewControllerLayoutEnvironment (IUIMutableTraits This)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			UISplitViewControllerLayoutEnvironment ret;
			ret = (UISplitViewControllerLayoutEnvironment) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (This.Handle, Selector.GetHandle ("splitViewControllerLayoutEnvironment"));
			GC.KeepAlive (This);
			return ret!;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SetSplitViewControllerLayoutEnvironment (IUIMutableTraits This, UISplitViewControllerLayoutEnvironment value)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("setSplitViewControllerLayoutEnvironment:"), (IntPtr) (long) value);
			GC.KeepAlive (This);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("tvos26.0")]
		[SupportedOSPlatform ("ios26.0")]
		[SupportedOSPlatform ("maccatalyst26.0")]
		[global::Foundation.RequiredMember]
		public virtual bool ResolvesNaturalAlignmentWithBaseWritingDirection {
			[Export ("resolvesNaturalAlignmentWithBaseWritingDirection")]
			get {
				return _GetResolvesNaturalAlignmentWithBaseWritingDirection (this);
			}
			[Export ("setResolvesNaturalAlignmentWithBaseWritingDirection:")]
			set {
				_SetResolvesNaturalAlignmentWithBaseWritingDirection (this, value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static bool _GetResolvesNaturalAlignmentWithBaseWritingDirection (IUIMutableTraits This)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (This.Handle, Selector.GetHandle ("resolvesNaturalAlignmentWithBaseWritingDirection"));
			GC.KeepAlive (This);
			return ret != 0;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SetResolvesNaturalAlignmentWithBaseWritingDirection (IUIMutableTraits This, bool value)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			global::ObjCRuntime.Messaging.void_objc_msgSend_bool (This.Handle, Selector.GetHandle ("setResolvesNaturalAlignmentWithBaseWritingDirection:"), value ? (byte) 1 : (byte) 0);
			GC.KeepAlive (This);
		}
	}
	#pragma warning restore CS1573
	internal unsafe sealed class UIMutableTraitsWrapper : BaseWrapper, IUIMutableTraits {
		public UIMutableTraitsWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.PublicConstructors, typeof (UIMutableTraitsWrapper))]
		static UIMutableTraitsWrapper ()
		{
			GC.KeepAlive (null);
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
		public UIUserInterfaceIdiom UserInterfaceIdiom {
			[Export ("userInterfaceIdiom", ArgumentSemantic.Assign)]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				UIUserInterfaceIdiom ret;
				ret = (UIUserInterfaceIdiom) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("userInterfaceIdiom"));
				return ret!;
			}
			[Export ("setUserInterfaceIdiom:", ArgumentSemantic.Assign)]
			set {
				global::UIKit.UIApplication.EnsureUIThread ();
				global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setUserInterfaceIdiom:"), (IntPtr) (long) value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public UIUserInterfaceStyle UserInterfaceStyle {
			[Export ("userInterfaceStyle", ArgumentSemantic.Assign)]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				UIUserInterfaceStyle ret;
				ret = (UIUserInterfaceStyle) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("userInterfaceStyle"));
				return ret!;
			}
			[Export ("setUserInterfaceStyle:", ArgumentSemantic.Assign)]
			set {
				global::UIKit.UIApplication.EnsureUIThread ();
				global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setUserInterfaceStyle:"), (IntPtr) (long) value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public UITraitEnvironmentLayoutDirection LayoutDirection {
			[Export ("layoutDirection", ArgumentSemantic.Assign)]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				UITraitEnvironmentLayoutDirection ret;
				ret = (UITraitEnvironmentLayoutDirection) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("layoutDirection"));
				return ret!;
			}
			[Export ("setLayoutDirection:", ArgumentSemantic.Assign)]
			set {
				global::UIKit.UIApplication.EnsureUIThread ();
				global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setLayoutDirection:"), (IntPtr) (long) value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public nfloat DisplayScale {
			[Export ("displayScale")]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				nfloat ret;
				ret = global::ObjCRuntime.Messaging.nfloat_objc_msgSend (this.Handle, Selector.GetHandle ("displayScale"));
				return ret;
			}
			[Export ("setDisplayScale:")]
			set {
				global::UIKit.UIApplication.EnsureUIThread ();
				global::ObjCRuntime.Messaging.void_objc_msgSend_nfloat (this.Handle, Selector.GetHandle ("setDisplayScale:"), value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public UIUserInterfaceSizeClass HorizontalSizeClass {
			[Export ("horizontalSizeClass", ArgumentSemantic.Assign)]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				UIUserInterfaceSizeClass ret;
				ret = (UIUserInterfaceSizeClass) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("horizontalSizeClass"));
				return ret!;
			}
			[Export ("setHorizontalSizeClass:", ArgumentSemantic.Assign)]
			set {
				global::UIKit.UIApplication.EnsureUIThread ();
				global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setHorizontalSizeClass:"), (IntPtr) (long) value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public UIUserInterfaceSizeClass VerticalSizeClass {
			[Export ("verticalSizeClass", ArgumentSemantic.Assign)]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				UIUserInterfaceSizeClass ret;
				ret = (UIUserInterfaceSizeClass) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("verticalSizeClass"));
				return ret!;
			}
			[Export ("setVerticalSizeClass:", ArgumentSemantic.Assign)]
			set {
				global::UIKit.UIApplication.EnsureUIThread ();
				global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setVerticalSizeClass:"), (IntPtr) (long) value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public UIForceTouchCapability ForceTouchCapability {
			[Export ("forceTouchCapability", ArgumentSemantic.Assign)]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				UIForceTouchCapability ret;
				ret = (UIForceTouchCapability) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("forceTouchCapability"));
				return ret!;
			}
			[Export ("setForceTouchCapability:", ArgumentSemantic.Assign)]
			set {
				global::UIKit.UIApplication.EnsureUIThread ();
				global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setForceTouchCapability:"), (IntPtr) (long) value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public string PreferredContentSizeCategory {
			[Export ("preferredContentSizeCategory")]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				string ret;
				ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("preferredContentSizeCategory")), false)!;
				return ret;
			}
			[Export ("setPreferredContentSizeCategory:")]
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
		public UIDisplayGamut DisplayGamut {
			[Export ("displayGamut", ArgumentSemantic.Assign)]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				UIDisplayGamut ret;
				ret = (UIDisplayGamut) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("displayGamut"));
				return ret!;
			}
			[Export ("setDisplayGamut:", ArgumentSemantic.Assign)]
			set {
				global::UIKit.UIApplication.EnsureUIThread ();
				global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setDisplayGamut:"), (IntPtr) (long) value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public UIAccessibilityContrast AccessibilityContrast {
			[Export ("accessibilityContrast", ArgumentSemantic.Assign)]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				UIAccessibilityContrast ret;
				ret = (UIAccessibilityContrast) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("accessibilityContrast"));
				return ret!;
			}
			[Export ("setAccessibilityContrast:", ArgumentSemantic.Assign)]
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
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				UIUserInterfaceLevel ret;
				ret = (UIUserInterfaceLevel) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("userInterfaceLevel"));
				return ret!;
			}
			[Export ("setUserInterfaceLevel:", ArgumentSemantic.Assign)]
			set {
				global::UIKit.UIApplication.EnsureUIThread ();
				global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setUserInterfaceLevel:"), (IntPtr) (long) value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public UILegibilityWeight LegibilityWeight {
			[Export ("legibilityWeight", ArgumentSemantic.Assign)]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				UILegibilityWeight ret;
				ret = (UILegibilityWeight) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("legibilityWeight"));
				return ret!;
			}
			[Export ("setLegibilityWeight:", ArgumentSemantic.Assign)]
			set {
				global::UIKit.UIApplication.EnsureUIThread ();
				global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setLegibilityWeight:"), (IntPtr) (long) value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public global::UIKit.UIUserInterfaceActiveAppearance ActiveAppearance {
			[Export ("activeAppearance", ArgumentSemantic.Assign)]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				global::UIKit.UIUserInterfaceActiveAppearance ret;
				ret = (UIUserInterfaceActiveAppearance) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("activeAppearance"));
				return ret!;
			}
			[Export ("setActiveAppearance:", ArgumentSemantic.Assign)]
			set {
				global::UIKit.UIApplication.EnsureUIThread ();
				global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setActiveAppearance:"), (IntPtr) (long) value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public UINSToolbarItemPresentationSize ToolbarItemPresentationSize {
			[Export ("toolbarItemPresentationSize", ArgumentSemantic.Assign)]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				UINSToolbarItemPresentationSize ret;
				ret = (UINSToolbarItemPresentationSize) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("toolbarItemPresentationSize"));
				return ret!;
			}
			[Export ("setToolbarItemPresentationSize:", ArgumentSemantic.Assign)]
			set {
				global::UIKit.UIApplication.EnsureUIThread ();
				global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setToolbarItemPresentationSize:"), (IntPtr) (long) value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public UIImageDynamicRange ImageDynamicRange {
			[Export ("imageDynamicRange", ArgumentSemantic.Assign)]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				UIImageDynamicRange ret;
				ret = (UIImageDynamicRange) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("imageDynamicRange"));
				return ret!;
			}
			[Export ("setImageDynamicRange:", ArgumentSemantic.Assign)]
			set {
				global::UIKit.UIApplication.EnsureUIThread ();
				global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setImageDynamicRange:"), (IntPtr) (long) value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public UISceneCaptureState SceneCaptureState {
			[Export ("sceneCaptureState", ArgumentSemantic.Assign)]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				UISceneCaptureState ret;
				ret = (UISceneCaptureState) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("sceneCaptureState"));
				return ret!;
			}
			[Export ("setSceneCaptureState:", ArgumentSemantic.Assign)]
			set {
				global::UIKit.UIApplication.EnsureUIThread ();
				global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setSceneCaptureState:"), (IntPtr) (long) value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public string TypesettingLanguage {
			[Export ("typesettingLanguage")]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				string ret;
				ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("typesettingLanguage")), false)!;
				return ret;
			}
			[Export ("setTypesettingLanguage:")]
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
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				UIListEnvironment ret;
				ret = (UIListEnvironment) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("listEnvironment"));
				return ret!;
			}
			[Export ("setListEnvironment:")]
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
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				UITabAccessoryEnvironment ret;
				ret = (UITabAccessoryEnvironment) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("tabAccessoryEnvironment"));
				return ret!;
			}
			[Export ("setTabAccessoryEnvironment:", ArgumentSemantic.Assign)]
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
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				UISplitViewControllerLayoutEnvironment ret;
				ret = (UISplitViewControllerLayoutEnvironment) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("splitViewControllerLayoutEnvironment"));
				return ret!;
			}
			[Export ("setSplitViewControllerLayoutEnvironment:", ArgumentSemantic.Assign)]
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
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				byte ret;
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("resolvesNaturalAlignmentWithBaseWritingDirection"));
				return ret != 0;
			}
			[Export ("setResolvesNaturalAlignmentWithBaseWritingDirection:")]
			set {
				global::UIKit.UIApplication.EnsureUIThread ();
				global::ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("setResolvesNaturalAlignmentWithBaseWritingDirection:"), value ? (byte) 1 : (byte) 0);
			}
		}
	}
}
namespace UIKit {
	/// <summary>
	///   <para>This is a class that implements the interface <see cref="IUIMutableTraits" /> (for the protocol <c>UIMutableTraits</c>).</para>
	///   <para>Subclass this class to easily create a type that implements the protocol.</para>
	///   <para>An alternative is to create a subclass of <see cref="NSObject" /> and then implemented the interface <see cref="IUIMutableTraits" />.</para>
	/// </summary>
	[Protocol()]
	[Register("Microsoft_MacCatalyst__UIKit_UIMutableTraits", false)]
	[Model]
	[SupportedOSPlatform ("tvos17.0")]
	[SupportedOSPlatform ("ios17.0")]
	[SupportedOSPlatform ("maccatalyst17.0")]
	public unsafe abstract partial class UIMutableTraits : NSObject, IUIMutableTraits {
		/// <summary>Creates a new <see cref="UIMutableTraits" /> with default values.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		protected UIMutableTraits () : base (NSObjectFlag.Empty)
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
		protected UIMutableTraits (NSObjectFlag t) : base (t)
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
		protected internal UIMutableTraits (NativeHandle handle) : base (handle)
		{
			IsDirectBinding = false;
		}

		[Export ("objectForTrait:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSObject? GetObject (IUIObjectTraitDefinition trait)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("valueForCGFloatTrait:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual nfloat GetValue (IUICGFloatTraitDefinition trait)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("valueForNSIntegerTrait:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual nint GetValue (IUINSIntegerTraitDefinition trait)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("setObject:forTrait:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetObject (NSObject? @object, IUIObjectTraitDefinition trait)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("setCGFloatValue:forTrait:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetValue (nfloat value, IUICGFloatTraitDefinition trait)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("setNSIntegerValue:forTrait:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetValue (nint value, IUINSIntegerTraitDefinition trait)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual UIAccessibilityContrast AccessibilityContrast {
			[Export ("accessibilityContrast", ArgumentSemantic.Assign)]
			get {
				throw new ModelNotImplementedException ();
			}
			[Export ("setAccessibilityContrast:", ArgumentSemantic.Assign)]
			set {
				throw new ModelNotImplementedException ();
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual global::UIKit.UIUserInterfaceActiveAppearance ActiveAppearance {
			[Export ("activeAppearance", ArgumentSemantic.Assign)]
			get {
				throw new ModelNotImplementedException ();
			}
			[Export ("setActiveAppearance:", ArgumentSemantic.Assign)]
			set {
				throw new ModelNotImplementedException ();
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual UIDisplayGamut DisplayGamut {
			[Export ("displayGamut", ArgumentSemantic.Assign)]
			get {
				throw new ModelNotImplementedException ();
			}
			[Export ("setDisplayGamut:", ArgumentSemantic.Assign)]
			set {
				throw new ModelNotImplementedException ();
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual nfloat DisplayScale {
			[Export ("displayScale")]
			get {
				throw new ModelNotImplementedException ();
			}
			[Export ("setDisplayScale:")]
			set {
				throw new ModelNotImplementedException ();
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual UIForceTouchCapability ForceTouchCapability {
			[Export ("forceTouchCapability", ArgumentSemantic.Assign)]
			get {
				throw new ModelNotImplementedException ();
			}
			[Export ("setForceTouchCapability:", ArgumentSemantic.Assign)]
			set {
				throw new ModelNotImplementedException ();
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual UIUserInterfaceSizeClass HorizontalSizeClass {
			[Export ("horizontalSizeClass", ArgumentSemantic.Assign)]
			get {
				throw new ModelNotImplementedException ();
			}
			[Export ("setHorizontalSizeClass:", ArgumentSemantic.Assign)]
			set {
				throw new ModelNotImplementedException ();
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual UIImageDynamicRange ImageDynamicRange {
			[Export ("imageDynamicRange", ArgumentSemantic.Assign)]
			get {
				throw new ModelNotImplementedException ();
			}
			[Export ("setImageDynamicRange:", ArgumentSemantic.Assign)]
			set {
				throw new ModelNotImplementedException ();
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual UITraitEnvironmentLayoutDirection LayoutDirection {
			[Export ("layoutDirection", ArgumentSemantic.Assign)]
			get {
				throw new ModelNotImplementedException ();
			}
			[Export ("setLayoutDirection:", ArgumentSemantic.Assign)]
			set {
				throw new ModelNotImplementedException ();
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual UILegibilityWeight LegibilityWeight {
			[Export ("legibilityWeight", ArgumentSemantic.Assign)]
			get {
				throw new ModelNotImplementedException ();
			}
			[Export ("setLegibilityWeight:", ArgumentSemantic.Assign)]
			set {
				throw new ModelNotImplementedException ();
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("tvos18.0")]
		[SupportedOSPlatform ("ios18.0")]
		[SupportedOSPlatform ("maccatalyst18.0")]
		public virtual UIListEnvironment ListEnvironment {
			[Export ("listEnvironment")]
			get {
				throw new ModelNotImplementedException ();
			}
			[Export ("setListEnvironment:")]
			set {
				throw new ModelNotImplementedException ();
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string PreferredContentSizeCategory {
			[Export ("preferredContentSizeCategory")]
			get {
				throw new ModelNotImplementedException ();
			}
			[Export ("setPreferredContentSizeCategory:")]
			set {
				throw new ModelNotImplementedException ();
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("tvos26.0")]
		[SupportedOSPlatform ("ios26.0")]
		[SupportedOSPlatform ("maccatalyst26.0")]
		public virtual bool ResolvesNaturalAlignmentWithBaseWritingDirection {
			[Export ("resolvesNaturalAlignmentWithBaseWritingDirection")]
			get {
				throw new ModelNotImplementedException ();
			}
			[Export ("setResolvesNaturalAlignmentWithBaseWritingDirection:")]
			set {
				throw new ModelNotImplementedException ();
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual UISceneCaptureState SceneCaptureState {
			[Export ("sceneCaptureState", ArgumentSemantic.Assign)]
			get {
				throw new ModelNotImplementedException ();
			}
			[Export ("setSceneCaptureState:", ArgumentSemantic.Assign)]
			set {
				throw new ModelNotImplementedException ();
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("tvos26.0")]
		[SupportedOSPlatform ("ios26.0")]
		[SupportedOSPlatform ("maccatalyst26.0")]
		public virtual UISplitViewControllerLayoutEnvironment SplitViewControllerLayoutEnvironment {
			[Export ("splitViewControllerLayoutEnvironment", ArgumentSemantic.Assign)]
			get {
				throw new ModelNotImplementedException ();
			}
			[Export ("setSplitViewControllerLayoutEnvironment:", ArgumentSemantic.Assign)]
			set {
				throw new ModelNotImplementedException ();
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios26.0")]
		[SupportedOSPlatform ("maccatalyst26.0")]
		public virtual UITabAccessoryEnvironment TabAccessoryEnvironment {
			[Export ("tabAccessoryEnvironment", ArgumentSemantic.Assign)]
			get {
				throw new ModelNotImplementedException ();
			}
			[Export ("setTabAccessoryEnvironment:", ArgumentSemantic.Assign)]
			set {
				throw new ModelNotImplementedException ();
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual UINSToolbarItemPresentationSize ToolbarItemPresentationSize {
			[Export ("toolbarItemPresentationSize", ArgumentSemantic.Assign)]
			get {
				throw new ModelNotImplementedException ();
			}
			[Export ("setToolbarItemPresentationSize:", ArgumentSemantic.Assign)]
			set {
				throw new ModelNotImplementedException ();
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string TypesettingLanguage {
			[Export ("typesettingLanguage")]
			get {
				throw new ModelNotImplementedException ();
			}
			[Export ("setTypesettingLanguage:")]
			set {
				throw new ModelNotImplementedException ();
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual UIUserInterfaceIdiom UserInterfaceIdiom {
			[Export ("userInterfaceIdiom", ArgumentSemantic.Assign)]
			get {
				throw new ModelNotImplementedException ();
			}
			[Export ("setUserInterfaceIdiom:", ArgumentSemantic.Assign)]
			set {
				throw new ModelNotImplementedException ();
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios17.0")]
		[SupportedOSPlatform ("maccatalyst17.0")]
		public virtual UIUserInterfaceLevel UserInterfaceLevel {
			[Export ("userInterfaceLevel", ArgumentSemantic.Assign)]
			get {
				throw new ModelNotImplementedException ();
			}
			[Export ("setUserInterfaceLevel:", ArgumentSemantic.Assign)]
			set {
				throw new ModelNotImplementedException ();
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual UIUserInterfaceStyle UserInterfaceStyle {
			[Export ("userInterfaceStyle", ArgumentSemantic.Assign)]
			get {
				throw new ModelNotImplementedException ();
			}
			[Export ("setUserInterfaceStyle:", ArgumentSemantic.Assign)]
			set {
				throw new ModelNotImplementedException ();
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual UIUserInterfaceSizeClass VerticalSizeClass {
			[Export ("verticalSizeClass", ArgumentSemantic.Assign)]
			get {
				throw new ModelNotImplementedException ();
			}
			[Export ("setVerticalSizeClass:", ArgumentSemantic.Assign)]
			set {
				throw new ModelNotImplementedException ();
			}
		}
	} /* class UIMutableTraits */
}
