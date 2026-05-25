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
	/// <summary>This interface represents the Objective-C protocol <c>UIMenuBuilder</c>.</summary>
	/// <remarks>
	///   <para>A class that implements this interface (and subclasses <see cref="NSObject" />) will be exported to Objective-C as implementing the Objective-C protocol this interface represents.</para>
	///   <para>A class may also implement members from this interface to implement members from the protocol.</para>
	/// </remarks>
	[SupportedOSPlatform ("ios13.0")]
	[SupportedOSPlatform ("tvos13.0")]
	[SupportedOSPlatform ("maccatalyst")]
	[Protocol (Name = "UIMenuBuilder", WrapperType = typeof (UIMenuBuilderWrapper))]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "GetMenu", Selector = "menuForIdentifier:", ReturnType = typeof (UIMenu), ParameterType = new Type [] { typeof (string) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "GetAction", Selector = "actionForIdentifier:", ReturnType = typeof (UIAction), ParameterType = new Type [] { typeof (string) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "GetCommand", Selector = "commandForAction:propertyList:", ReturnType = typeof (UICommand), ParameterType = new Type [] { typeof (Selector), typeof (NSObject) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "ReplaceMenu", Selector = "replaceMenuForIdentifier:withMenu:", ParameterType = new Type [] { typeof (string), typeof (UIMenu) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "ReplaceChildrenOfMenu", Selector = "replaceChildrenOfMenuForIdentifier:fromChildrenBlock:", ParameterType = new Type [] { typeof (string), typeof (global::System.Func<global::UIKit.UIMenuElement[], global::UIKit.UIMenuElement[]>) }, ParameterByRef = new bool [] { false, false }, ParameterBlockProxy = new Type? [] { null, typeof (ObjCRuntime.Trampolines.NIDFuncArity2V14) })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "ReplaceAction", Selector = "replaceActionForIdentifier:withElements:", ParameterType = new Type [] { typeof (string), typeof (UIMenuElement[]) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "ReplaceCommand", Selector = "replaceCommandForAction:propertyList:withElements:", ParameterType = new Type [] { typeof (Selector), typeof (NSObject), typeof (UIMenuElement[]) }, ParameterByRef = new bool [] { false, false, false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "InsertSiblingMenuBefore", Selector = "insertSiblingMenu:beforeMenuForIdentifier:", ParameterType = new Type [] { typeof (UIMenu), typeof (string) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "ReplaceMenu", Selector = "replaceMenuForIdentifier:withElements:", ParameterType = new Type [] { typeof (string), typeof (UIMenuElement[]) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "InsertElementsBeforeMenu", Selector = "insertElements:beforeMenuForIdentifier:", ParameterType = new Type [] { typeof (UIMenuElement[]), typeof (string) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "InsertElementsAfterMenu", Selector = "insertElements:afterMenuForIdentifier:", ParameterType = new Type [] { typeof (UIMenuElement[]), typeof (string) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "InsertSiblingMenuAfter", Selector = "insertSiblingMenu:afterMenuForIdentifier:", ParameterType = new Type [] { typeof (UIMenu), typeof (string) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "InsertChildMenuAtStart", Selector = "insertChildMenu:atStartOfMenuForIdentifier:", ParameterType = new Type [] { typeof (UIMenu), typeof (string) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "InsertElementsBeforeAction", Selector = "insertElements:beforeActionForIdentifier:", ParameterType = new Type [] { typeof (UIMenuElement[]), typeof (string) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "InsertElementsAfterAction", Selector = "insertElements:afterActionForIdentifier:", ParameterType = new Type [] { typeof (UIMenuElement[]), typeof (string) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "InsertElementsBeforeCommand", Selector = "insertElements:beforeCommandForAction:propertyList:", ParameterType = new Type [] { typeof (UIMenuElement[]), typeof (Selector), typeof (NSObject) }, ParameterByRef = new bool [] { false, false, false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "InsertElementsAfterCommand", Selector = "insertElements:afterCommandForAction:propertyList:", ParameterType = new Type [] { typeof (UIMenuElement[]), typeof (Selector), typeof (NSObject) }, ParameterByRef = new bool [] { false, false, false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "InsertElementsAtStartOfMenu", Selector = "insertElements:atStartOfMenuForIdentifier:", ParameterType = new Type [] { typeof (UIMenuElement[]), typeof (string) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "InsertChildMenuAtEnd", Selector = "insertChildMenu:atEndOfMenuForIdentifier:", ParameterType = new Type [] { typeof (UIMenu), typeof (string) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "InsertElementsAtEndOfMenu", Selector = "insertElements:atEndOfMenuForIdentifier:", ParameterType = new Type [] { typeof (UIMenuElement[]), typeof (string) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "RemoveMenu", Selector = "removeMenuForIdentifier:", ParameterType = new Type [] { typeof (string) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "RemoveAction", Selector = "removeActionForIdentifier:", ParameterType = new Type [] { typeof (string) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "RemoveCommand", Selector = "removeCommandForAction:propertyList:", ParameterType = new Type [] { typeof (Selector), typeof (NSObject) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "System", Selector = "system", PropertyType = typeof (UIMenuSystem), GetterSelector = "system", ArgumentSemantic = ArgumentSemantic.None)]
	public partial interface IUIMenuBuilder : INativeObject, IDisposable
	{
		[global::Foundation.RequiredMember]
		[Export ("menuForIdentifier:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual UIMenu? GetMenu (string identifier)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static UIMenu? _GetMenu (IUIMenuBuilder This, string identifier)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			if (identifier is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (identifier));
			var nsidentifier = CFString.CreateNative (identifier);
			UIMenu? ret;
			ret =  Runtime.GetNSObject<UIMenu> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("menuForIdentifier:"), nsidentifier), false)!;
			GC.KeepAlive (This);
			CFString.ReleaseNative (nsidentifier);
			return ret!;
		}
		[global::Foundation.RequiredMember]
		[Export ("actionForIdentifier:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual UIAction? GetAction (string identifier)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static UIAction? _GetAction (IUIMenuBuilder This, string identifier)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			if (identifier is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (identifier));
			var nsidentifier = CFString.CreateNative (identifier);
			UIAction? ret;
			ret =  Runtime.GetNSObject<UIAction> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("actionForIdentifier:"), nsidentifier), false)!;
			GC.KeepAlive (This);
			CFString.ReleaseNative (nsidentifier);
			return ret!;
		}
		[global::Foundation.RequiredMember]
		[Export ("commandForAction:propertyList:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual UICommand? GetCommand (Selector action, NSObject? propertyList)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static UICommand? _GetCommand (IUIMenuBuilder This, Selector action, NSObject? propertyList)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var action__handle__ = action!.GetNonNullHandle (nameof (action));
			var propertyList__handle__ = propertyList.GetHandle ();
			UICommand? ret;
			ret =  Runtime.GetNSObject<UICommand> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("commandForAction:propertyList:"), action.Handle, propertyList__handle__), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (action);
			GC.KeepAlive (propertyList);
			return ret!;
		}
		[global::Foundation.RequiredMember]
		[Export ("replaceMenuForIdentifier:withMenu:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void ReplaceMenu (string replacedIdentifier, UIMenu replacementMenu)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _ReplaceMenu (IUIMenuBuilder This, string replacedIdentifier, UIMenu replacementMenu)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			if (replacedIdentifier is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (replacedIdentifier));
			var replacementMenu__handle__ = replacementMenu!.GetNonNullHandle (nameof (replacementMenu));
			var nsreplacedIdentifier = CFString.CreateNative (replacedIdentifier);
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("replaceMenuForIdentifier:withMenu:"), nsreplacedIdentifier, replacementMenu__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (replacementMenu);
			CFString.ReleaseNative (nsreplacedIdentifier);
		}
		[global::Foundation.RequiredMember]
		[Export ("replaceChildrenOfMenuForIdentifier:fromChildrenBlock:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void ReplaceChildrenOfMenu (string parentIdentifier, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDFuncArity2V14))]global::System.Func<UIMenuElement[], UIMenuElement[]> childrenBlock)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal unsafe static void _ReplaceChildrenOfMenu (IUIMenuBuilder This, string parentIdentifier, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDFuncArity2V14))]global::System.Func<UIMenuElement[], UIMenuElement[]> childrenBlock)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			if (parentIdentifier is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (parentIdentifier));
			if (childrenBlock is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (childrenBlock));
			var nsparentIdentifier = CFString.CreateNative (parentIdentifier);
			using var block_childrenBlock = Trampolines.SDFuncArity2V14.CreateBlock (childrenBlock);
			BlockLiteral *block_ptr_childrenBlock = &block_childrenBlock;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("replaceChildrenOfMenuForIdentifier:fromChildrenBlock:"), nsparentIdentifier, (IntPtr) block_ptr_childrenBlock);
			GC.KeepAlive (This);
			CFString.ReleaseNative (nsparentIdentifier);
		}
		[global::Foundation.RequiredMember]
		[Export ("replaceActionForIdentifier:withElements:")]
		[SupportedOSPlatform ("ios26.0")]
		[SupportedOSPlatform ("tvos26.0")]
		[SupportedOSPlatform ("maccatalyst26.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void ReplaceAction (string replacedIdentifier, UIMenuElement[] replacementElements)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[SupportedOSPlatform ("ios26.0")]
		[SupportedOSPlatform ("tvos26.0")]
		[SupportedOSPlatform ("maccatalyst26.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _ReplaceAction (IUIMenuBuilder This, string replacedIdentifier, UIMenuElement[] replacementElements)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			if (replacedIdentifier is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (replacedIdentifier));
			if (replacementElements is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (replacementElements));
			var nsreplacedIdentifier = CFString.CreateNative (replacedIdentifier);
			using var nsa_replacementElements = NSArray.FromNSObjects (replacementElements);
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("replaceActionForIdentifier:withElements:"), nsreplacedIdentifier, nsa_replacementElements.Handle);
			GC.KeepAlive (This);
			CFString.ReleaseNative (nsreplacedIdentifier);
		}
		[global::Foundation.RequiredMember]
		[Export ("replaceCommandForAction:propertyList:withElements:")]
		[SupportedOSPlatform ("ios26.0")]
		[SupportedOSPlatform ("tvos26.0")]
		[SupportedOSPlatform ("maccatalyst26.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void ReplaceCommand (Selector replacedAction, NSObject? replacedPropertyList, UIMenuElement[] replacementElements)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[SupportedOSPlatform ("ios26.0")]
		[SupportedOSPlatform ("tvos26.0")]
		[SupportedOSPlatform ("maccatalyst26.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _ReplaceCommand (IUIMenuBuilder This, Selector replacedAction, NSObject? replacedPropertyList, UIMenuElement[] replacementElements)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var replacedAction__handle__ = replacedAction!.GetNonNullHandle (nameof (replacedAction));
			var replacedPropertyList__handle__ = replacedPropertyList.GetHandle ();
			if (replacementElements is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (replacementElements));
			using var nsa_replacementElements = NSArray.FromNSObjects (replacementElements);
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("replaceCommandForAction:propertyList:withElements:"), replacedAction.Handle, replacedPropertyList__handle__, nsa_replacementElements.Handle);
			GC.KeepAlive (This);
			GC.KeepAlive (replacedAction);
			GC.KeepAlive (replacedPropertyList);
		}
		[global::Foundation.RequiredMember]
		[Export ("insertSiblingMenu:beforeMenuForIdentifier:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void InsertSiblingMenuBefore (UIMenu siblingMenu, string siblingIdentifier)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _InsertSiblingMenuBefore (IUIMenuBuilder This, UIMenu siblingMenu, string siblingIdentifier)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var siblingMenu__handle__ = siblingMenu!.GetNonNullHandle (nameof (siblingMenu));
			if (siblingIdentifier is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (siblingIdentifier));
			var nssiblingIdentifier = CFString.CreateNative (siblingIdentifier);
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("insertSiblingMenu:beforeMenuForIdentifier:"), siblingMenu__handle__, nssiblingIdentifier);
			GC.KeepAlive (This);
			GC.KeepAlive (siblingMenu);
			CFString.ReleaseNative (nssiblingIdentifier);
		}
		[global::Foundation.RequiredMember]
		[Export ("replaceMenuForIdentifier:withElements:")]
		[SupportedOSPlatform ("ios26.0")]
		[SupportedOSPlatform ("tvos26.0")]
		[SupportedOSPlatform ("maccatalyst26.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void ReplaceMenu (string replacedIdentifier, UIMenuElement[] replacementElements)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[SupportedOSPlatform ("ios26.0")]
		[SupportedOSPlatform ("tvos26.0")]
		[SupportedOSPlatform ("maccatalyst26.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _ReplaceMenu (IUIMenuBuilder This, string replacedIdentifier, UIMenuElement[] replacementElements)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			if (replacedIdentifier is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (replacedIdentifier));
			if (replacementElements is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (replacementElements));
			var nsreplacedIdentifier = CFString.CreateNative (replacedIdentifier);
			using var nsa_replacementElements = NSArray.FromNSObjects (replacementElements);
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("replaceMenuForIdentifier:withElements:"), nsreplacedIdentifier, nsa_replacementElements.Handle);
			GC.KeepAlive (This);
			CFString.ReleaseNative (nsreplacedIdentifier);
		}
		[global::Foundation.RequiredMember]
		[Export ("insertElements:beforeMenuForIdentifier:")]
		[SupportedOSPlatform ("ios26.0")]
		[SupportedOSPlatform ("tvos26.0")]
		[SupportedOSPlatform ("maccatalyst26.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void InsertElementsBeforeMenu (UIMenuElement[] insertedElements, string siblingIdentifier)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[SupportedOSPlatform ("ios26.0")]
		[SupportedOSPlatform ("tvos26.0")]
		[SupportedOSPlatform ("maccatalyst26.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _InsertElementsBeforeMenu (IUIMenuBuilder This, UIMenuElement[] insertedElements, string siblingIdentifier)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			if (insertedElements is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (insertedElements));
			if (siblingIdentifier is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (siblingIdentifier));
			using var nsa_insertedElements = NSArray.FromNSObjects (insertedElements);
			var nssiblingIdentifier = CFString.CreateNative (siblingIdentifier);
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("insertElements:beforeMenuForIdentifier:"), nsa_insertedElements.Handle, nssiblingIdentifier);
			GC.KeepAlive (This);
			CFString.ReleaseNative (nssiblingIdentifier);
		}
		[global::Foundation.RequiredMember]
		[Export ("insertElements:afterMenuForIdentifier:")]
		[SupportedOSPlatform ("ios26.0")]
		[SupportedOSPlatform ("tvos26.0")]
		[SupportedOSPlatform ("maccatalyst26.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void InsertElementsAfterMenu (UIMenuElement[] insertedElements, string siblingIdentifier)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[SupportedOSPlatform ("ios26.0")]
		[SupportedOSPlatform ("tvos26.0")]
		[SupportedOSPlatform ("maccatalyst26.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _InsertElementsAfterMenu (IUIMenuBuilder This, UIMenuElement[] insertedElements, string siblingIdentifier)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			if (insertedElements is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (insertedElements));
			if (siblingIdentifier is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (siblingIdentifier));
			using var nsa_insertedElements = NSArray.FromNSObjects (insertedElements);
			var nssiblingIdentifier = CFString.CreateNative (siblingIdentifier);
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("insertElements:afterMenuForIdentifier:"), nsa_insertedElements.Handle, nssiblingIdentifier);
			GC.KeepAlive (This);
			CFString.ReleaseNative (nssiblingIdentifier);
		}
		[global::Foundation.RequiredMember]
		[Export ("insertSiblingMenu:afterMenuForIdentifier:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void InsertSiblingMenuAfter (UIMenu siblingMenu, string siblingIdentifier)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _InsertSiblingMenuAfter (IUIMenuBuilder This, UIMenu siblingMenu, string siblingIdentifier)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var siblingMenu__handle__ = siblingMenu!.GetNonNullHandle (nameof (siblingMenu));
			if (siblingIdentifier is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (siblingIdentifier));
			var nssiblingIdentifier = CFString.CreateNative (siblingIdentifier);
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("insertSiblingMenu:afterMenuForIdentifier:"), siblingMenu__handle__, nssiblingIdentifier);
			GC.KeepAlive (This);
			GC.KeepAlive (siblingMenu);
			CFString.ReleaseNative (nssiblingIdentifier);
		}
		[global::Foundation.RequiredMember]
		[Export ("insertChildMenu:atStartOfMenuForIdentifier:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void InsertChildMenuAtStart (UIMenu childMenu, string parentIdentifier)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _InsertChildMenuAtStart (IUIMenuBuilder This, UIMenu childMenu, string parentIdentifier)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var childMenu__handle__ = childMenu!.GetNonNullHandle (nameof (childMenu));
			if (parentIdentifier is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (parentIdentifier));
			var nsparentIdentifier = CFString.CreateNative (parentIdentifier);
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("insertChildMenu:atStartOfMenuForIdentifier:"), childMenu__handle__, nsparentIdentifier);
			GC.KeepAlive (This);
			GC.KeepAlive (childMenu);
			CFString.ReleaseNative (nsparentIdentifier);
		}
		[global::Foundation.RequiredMember]
		[Export ("insertElements:beforeActionForIdentifier:")]
		[SupportedOSPlatform ("ios26.0")]
		[SupportedOSPlatform ("tvos26.0")]
		[SupportedOSPlatform ("maccatalyst26.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void InsertElementsBeforeAction (UIMenuElement[] insertedElements, string siblingIdentifier)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[SupportedOSPlatform ("ios26.0")]
		[SupportedOSPlatform ("tvos26.0")]
		[SupportedOSPlatform ("maccatalyst26.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _InsertElementsBeforeAction (IUIMenuBuilder This, UIMenuElement[] insertedElements, string siblingIdentifier)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			if (insertedElements is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (insertedElements));
			if (siblingIdentifier is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (siblingIdentifier));
			using var nsa_insertedElements = NSArray.FromNSObjects (insertedElements);
			var nssiblingIdentifier = CFString.CreateNative (siblingIdentifier);
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("insertElements:beforeActionForIdentifier:"), nsa_insertedElements.Handle, nssiblingIdentifier);
			GC.KeepAlive (This);
			CFString.ReleaseNative (nssiblingIdentifier);
		}
		[global::Foundation.RequiredMember]
		[Export ("insertElements:afterActionForIdentifier:")]
		[SupportedOSPlatform ("ios26.0")]
		[SupportedOSPlatform ("tvos26.0")]
		[SupportedOSPlatform ("maccatalyst26.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void InsertElementsAfterAction (UIMenuElement[] insertedElements, string siblingIdentifier)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[SupportedOSPlatform ("ios26.0")]
		[SupportedOSPlatform ("tvos26.0")]
		[SupportedOSPlatform ("maccatalyst26.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _InsertElementsAfterAction (IUIMenuBuilder This, UIMenuElement[] insertedElements, string siblingIdentifier)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			if (insertedElements is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (insertedElements));
			if (siblingIdentifier is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (siblingIdentifier));
			using var nsa_insertedElements = NSArray.FromNSObjects (insertedElements);
			var nssiblingIdentifier = CFString.CreateNative (siblingIdentifier);
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("insertElements:afterActionForIdentifier:"), nsa_insertedElements.Handle, nssiblingIdentifier);
			GC.KeepAlive (This);
			CFString.ReleaseNative (nssiblingIdentifier);
		}
		[global::Foundation.RequiredMember]
		[Export ("insertElements:beforeCommandForAction:propertyList:")]
		[SupportedOSPlatform ("ios26.0")]
		[SupportedOSPlatform ("tvos26.0")]
		[SupportedOSPlatform ("maccatalyst26.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void InsertElementsBeforeCommand (UIMenuElement[] insertedElements, Selector siblingAction, NSObject? siblingPropertyList)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[SupportedOSPlatform ("ios26.0")]
		[SupportedOSPlatform ("tvos26.0")]
		[SupportedOSPlatform ("maccatalyst26.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _InsertElementsBeforeCommand (IUIMenuBuilder This, UIMenuElement[] insertedElements, Selector siblingAction, NSObject? siblingPropertyList)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			if (insertedElements is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (insertedElements));
			var siblingAction__handle__ = siblingAction!.GetNonNullHandle (nameof (siblingAction));
			var siblingPropertyList__handle__ = siblingPropertyList.GetHandle ();
			using var nsa_insertedElements = NSArray.FromNSObjects (insertedElements);
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("insertElements:beforeCommandForAction:propertyList:"), nsa_insertedElements.Handle, siblingAction.Handle, siblingPropertyList__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (siblingAction);
			GC.KeepAlive (siblingPropertyList);
		}
		[global::Foundation.RequiredMember]
		[Export ("insertElements:afterCommandForAction:propertyList:")]
		[SupportedOSPlatform ("ios26.0")]
		[SupportedOSPlatform ("tvos26.0")]
		[SupportedOSPlatform ("maccatalyst26.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void InsertElementsAfterCommand (UIMenuElement[] insertedElements, Selector siblingAction, NSObject? siblingPropertyList)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[SupportedOSPlatform ("ios26.0")]
		[SupportedOSPlatform ("tvos26.0")]
		[SupportedOSPlatform ("maccatalyst26.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _InsertElementsAfterCommand (IUIMenuBuilder This, UIMenuElement[] insertedElements, Selector siblingAction, NSObject? siblingPropertyList)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			if (insertedElements is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (insertedElements));
			var siblingAction__handle__ = siblingAction!.GetNonNullHandle (nameof (siblingAction));
			var siblingPropertyList__handle__ = siblingPropertyList.GetHandle ();
			using var nsa_insertedElements = NSArray.FromNSObjects (insertedElements);
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("insertElements:afterCommandForAction:propertyList:"), nsa_insertedElements.Handle, siblingAction.Handle, siblingPropertyList__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (siblingAction);
			GC.KeepAlive (siblingPropertyList);
		}
		[global::Foundation.RequiredMember]
		[Export ("insertElements:atStartOfMenuForIdentifier:")]
		[SupportedOSPlatform ("ios26.0")]
		[SupportedOSPlatform ("tvos26.0")]
		[SupportedOSPlatform ("maccatalyst26.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void InsertElementsAtStartOfMenu (UIMenuElement[] childElements, string parentIdentifier)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[SupportedOSPlatform ("ios26.0")]
		[SupportedOSPlatform ("tvos26.0")]
		[SupportedOSPlatform ("maccatalyst26.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _InsertElementsAtStartOfMenu (IUIMenuBuilder This, UIMenuElement[] childElements, string parentIdentifier)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			if (childElements is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (childElements));
			if (parentIdentifier is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (parentIdentifier));
			using var nsa_childElements = NSArray.FromNSObjects (childElements);
			var nsparentIdentifier = CFString.CreateNative (parentIdentifier);
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("insertElements:atStartOfMenuForIdentifier:"), nsa_childElements.Handle, nsparentIdentifier);
			GC.KeepAlive (This);
			CFString.ReleaseNative (nsparentIdentifier);
		}
		[global::Foundation.RequiredMember]
		[Export ("insertChildMenu:atEndOfMenuForIdentifier:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void InsertChildMenuAtEnd (UIMenu childMenu, string parentIdentifier)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _InsertChildMenuAtEnd (IUIMenuBuilder This, UIMenu childMenu, string parentIdentifier)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var childMenu__handle__ = childMenu!.GetNonNullHandle (nameof (childMenu));
			if (parentIdentifier is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (parentIdentifier));
			var nsparentIdentifier = CFString.CreateNative (parentIdentifier);
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("insertChildMenu:atEndOfMenuForIdentifier:"), childMenu__handle__, nsparentIdentifier);
			GC.KeepAlive (This);
			GC.KeepAlive (childMenu);
			CFString.ReleaseNative (nsparentIdentifier);
		}
		[global::Foundation.RequiredMember]
		[Export ("insertElements:atEndOfMenuForIdentifier:")]
		[SupportedOSPlatform ("ios26.0")]
		[SupportedOSPlatform ("tvos26.0")]
		[SupportedOSPlatform ("maccatalyst26.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void InsertElementsAtEndOfMenu (UIMenuElement[] childElements, string parentIdentifier)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[SupportedOSPlatform ("ios26.0")]
		[SupportedOSPlatform ("tvos26.0")]
		[SupportedOSPlatform ("maccatalyst26.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _InsertElementsAtEndOfMenu (IUIMenuBuilder This, UIMenuElement[] childElements, string parentIdentifier)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			if (childElements is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (childElements));
			if (parentIdentifier is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (parentIdentifier));
			using var nsa_childElements = NSArray.FromNSObjects (childElements);
			var nsparentIdentifier = CFString.CreateNative (parentIdentifier);
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("insertElements:atEndOfMenuForIdentifier:"), nsa_childElements.Handle, nsparentIdentifier);
			GC.KeepAlive (This);
			CFString.ReleaseNative (nsparentIdentifier);
		}
		[global::Foundation.RequiredMember]
		[Export ("removeMenuForIdentifier:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void RemoveMenu (string removedIdentifier)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _RemoveMenu (IUIMenuBuilder This, string removedIdentifier)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			if (removedIdentifier is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (removedIdentifier));
			var nsremovedIdentifier = CFString.CreateNative (removedIdentifier);
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("removeMenuForIdentifier:"), nsremovedIdentifier);
			GC.KeepAlive (This);
			CFString.ReleaseNative (nsremovedIdentifier);
		}
		[global::Foundation.RequiredMember]
		[Export ("removeActionForIdentifier:")]
		[SupportedOSPlatform ("ios26.0")]
		[SupportedOSPlatform ("tvos26.0")]
		[SupportedOSPlatform ("maccatalyst26.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void RemoveAction (string removedIdentifier)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[SupportedOSPlatform ("ios26.0")]
		[SupportedOSPlatform ("tvos26.0")]
		[SupportedOSPlatform ("maccatalyst26.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _RemoveAction (IUIMenuBuilder This, string removedIdentifier)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			if (removedIdentifier is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (removedIdentifier));
			var nsremovedIdentifier = CFString.CreateNative (removedIdentifier);
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("removeActionForIdentifier:"), nsremovedIdentifier);
			GC.KeepAlive (This);
			CFString.ReleaseNative (nsremovedIdentifier);
		}
		[global::Foundation.RequiredMember]
		[Export ("removeCommandForAction:propertyList:")]
		[SupportedOSPlatform ("ios26.0")]
		[SupportedOSPlatform ("tvos26.0")]
		[SupportedOSPlatform ("maccatalyst26.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void RemoveCommand (Selector removedAction, NSObject? removedPropertyList)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[SupportedOSPlatform ("ios26.0")]
		[SupportedOSPlatform ("tvos26.0")]
		[SupportedOSPlatform ("maccatalyst26.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _RemoveCommand (IUIMenuBuilder This, Selector removedAction, NSObject? removedPropertyList)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var removedAction__handle__ = removedAction!.GetNonNullHandle (nameof (removedAction));
			var removedPropertyList__handle__ = removedPropertyList.GetHandle ();
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("removeCommandForAction:propertyList:"), removedAction.Handle, removedPropertyList__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (removedAction);
			GC.KeepAlive (removedPropertyList);
		}
		[DynamicDependencyAttribute ("GetAction(System.String)")]
		[DynamicDependencyAttribute ("GetCommand(ObjCRuntime.Selector,Foundation.NSObject)")]
		[DynamicDependencyAttribute ("GetMenu(System.String)")]
		[DynamicDependencyAttribute ("InsertChildMenuAtEnd(UIKit.UIMenu,System.String)")]
		[DynamicDependencyAttribute ("InsertChildMenuAtStart(UIKit.UIMenu,System.String)")]
		[DynamicDependencyAttribute ("InsertElementsAfterAction(UIKit.UIMenuElement[],System.String)")]
		[DynamicDependencyAttribute ("InsertElementsAfterCommand(UIKit.UIMenuElement[],ObjCRuntime.Selector,Foundation.NSObject)")]
		[DynamicDependencyAttribute ("InsertElementsAfterMenu(UIKit.UIMenuElement[],System.String)")]
		[DynamicDependencyAttribute ("InsertElementsAtEndOfMenu(UIKit.UIMenuElement[],System.String)")]
		[DynamicDependencyAttribute ("InsertElementsAtStartOfMenu(UIKit.UIMenuElement[],System.String)")]
		[DynamicDependencyAttribute ("InsertElementsBeforeAction(UIKit.UIMenuElement[],System.String)")]
		[DynamicDependencyAttribute ("InsertElementsBeforeCommand(UIKit.UIMenuElement[],ObjCRuntime.Selector,Foundation.NSObject)")]
		[DynamicDependencyAttribute ("InsertElementsBeforeMenu(UIKit.UIMenuElement[],System.String)")]
		[DynamicDependencyAttribute ("InsertSiblingMenuAfter(UIKit.UIMenu,System.String)")]
		[DynamicDependencyAttribute ("InsertSiblingMenuBefore(UIKit.UIMenu,System.String)")]
		[DynamicDependencyAttribute ("RemoveAction(System.String)")]
		[DynamicDependencyAttribute ("RemoveCommand(ObjCRuntime.Selector,Foundation.NSObject)")]
		[DynamicDependencyAttribute ("RemoveMenu(System.String)")]
		[DynamicDependencyAttribute ("ReplaceAction(System.String,UIKit.UIMenuElement[])")]
		[DynamicDependencyAttribute ("ReplaceChildrenOfMenu(System.String,System.Func{UIKit.UIMenuElement[],UIKit.UIMenuElement[]})")]
		[DynamicDependencyAttribute ("ReplaceCommand(ObjCRuntime.Selector,Foundation.NSObject,UIKit.UIMenuElement[])")]
		[DynamicDependencyAttribute ("ReplaceMenu(System.String,UIKit.UIMenu)")]
		[DynamicDependencyAttribute ("ReplaceMenu(System.String,UIKit.UIMenuElement[])")]
		[DynamicDependencyAttribute ("System")]
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.Interfaces | DynamicallyAccessedMemberTypes.PublicConstructors, typeof (UIMenuBuilderWrapper))]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static IUIMenuBuilder ()
		{
			GC.KeepAlive (null);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual UIMenuSystem System {
			[Export ("system")]
			get {
				return _GetSystem (this);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static UIMenuSystem _GetSystem (IUIMenuBuilder This)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			UIMenuSystem ret;
			ret =  Runtime.GetNSObject<UIMenuSystem> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("system")), false)!;
			GC.KeepAlive (This);
			return ret;
		}
	}
	#pragma warning restore CS1573
	internal unsafe sealed class UIMenuBuilderWrapper : BaseWrapper, IUIMenuBuilder {
		public UIMenuBuilderWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.PublicConstructors, typeof (UIMenuBuilderWrapper))]
		static UIMenuBuilderWrapper ()
		{
			GC.KeepAlive (null);
		}
		[Export ("menuForIdentifier:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public UIMenu? GetMenu (string identifier)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			if (identifier is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (identifier));
			var nsidentifier = CFString.CreateNative (identifier);
			UIMenu? ret;
			ret =  Runtime.GetNSObject<UIMenu> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("menuForIdentifier:"), nsidentifier), false)!;
			CFString.ReleaseNative (nsidentifier);
			return ret!;
		}
		[Export ("actionForIdentifier:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public UIAction? GetAction (string identifier)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			if (identifier is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (identifier));
			var nsidentifier = CFString.CreateNative (identifier);
			UIAction? ret;
			ret =  Runtime.GetNSObject<UIAction> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("actionForIdentifier:"), nsidentifier), false)!;
			CFString.ReleaseNative (nsidentifier);
			return ret!;
		}
		[Export ("commandForAction:propertyList:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public UICommand? GetCommand (Selector action, NSObject? propertyList)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var action__handle__ = action!.GetNonNullHandle (nameof (action));
			var propertyList__handle__ = propertyList.GetHandle ();
			UICommand? ret;
			ret =  Runtime.GetNSObject<UICommand> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("commandForAction:propertyList:"), action.Handle, propertyList__handle__), false)!;
			GC.KeepAlive (action);
			GC.KeepAlive (propertyList);
			return ret!;
		}
		[Export ("replaceMenuForIdentifier:withMenu:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void ReplaceMenu (string replacedIdentifier, UIMenu replacementMenu)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			if (replacedIdentifier is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (replacedIdentifier));
			var replacementMenu__handle__ = replacementMenu!.GetNonNullHandle (nameof (replacementMenu));
			var nsreplacedIdentifier = CFString.CreateNative (replacedIdentifier);
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("replaceMenuForIdentifier:withMenu:"), nsreplacedIdentifier, replacementMenu__handle__);
			GC.KeepAlive (replacementMenu);
			CFString.ReleaseNative (nsreplacedIdentifier);
		}
		[Export ("replaceChildrenOfMenuForIdentifier:fromChildrenBlock:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe void ReplaceChildrenOfMenu (string parentIdentifier, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDFuncArity2V14))]global::System.Func<UIMenuElement[], UIMenuElement[]> childrenBlock)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			if (parentIdentifier is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (parentIdentifier));
			if (childrenBlock is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (childrenBlock));
			var nsparentIdentifier = CFString.CreateNative (parentIdentifier);
			using var block_childrenBlock = Trampolines.SDFuncArity2V14.CreateBlock (childrenBlock);
			BlockLiteral *block_ptr_childrenBlock = &block_childrenBlock;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("replaceChildrenOfMenuForIdentifier:fromChildrenBlock:"), nsparentIdentifier, (IntPtr) block_ptr_childrenBlock);
			CFString.ReleaseNative (nsparentIdentifier);
		}
		[Export ("replaceActionForIdentifier:withElements:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void ReplaceAction (string replacedIdentifier, UIMenuElement[] replacementElements)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			if (replacedIdentifier is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (replacedIdentifier));
			if (replacementElements is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (replacementElements));
			var nsreplacedIdentifier = CFString.CreateNative (replacedIdentifier);
			using var nsa_replacementElements = NSArray.FromNSObjects (replacementElements);
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("replaceActionForIdentifier:withElements:"), nsreplacedIdentifier, nsa_replacementElements.Handle);
			CFString.ReleaseNative (nsreplacedIdentifier);
		}
		[Export ("replaceCommandForAction:propertyList:withElements:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void ReplaceCommand (Selector replacedAction, NSObject? replacedPropertyList, UIMenuElement[] replacementElements)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var replacedAction__handle__ = replacedAction!.GetNonNullHandle (nameof (replacedAction));
			var replacedPropertyList__handle__ = replacedPropertyList.GetHandle ();
			if (replacementElements is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (replacementElements));
			using var nsa_replacementElements = NSArray.FromNSObjects (replacementElements);
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("replaceCommandForAction:propertyList:withElements:"), replacedAction.Handle, replacedPropertyList__handle__, nsa_replacementElements.Handle);
			GC.KeepAlive (replacedAction);
			GC.KeepAlive (replacedPropertyList);
		}
		[Export ("insertSiblingMenu:beforeMenuForIdentifier:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void InsertSiblingMenuBefore (UIMenu siblingMenu, string siblingIdentifier)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var siblingMenu__handle__ = siblingMenu!.GetNonNullHandle (nameof (siblingMenu));
			if (siblingIdentifier is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (siblingIdentifier));
			var nssiblingIdentifier = CFString.CreateNative (siblingIdentifier);
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("insertSiblingMenu:beforeMenuForIdentifier:"), siblingMenu__handle__, nssiblingIdentifier);
			GC.KeepAlive (siblingMenu);
			CFString.ReleaseNative (nssiblingIdentifier);
		}
		[Export ("replaceMenuForIdentifier:withElements:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void ReplaceMenu (string replacedIdentifier, UIMenuElement[] replacementElements)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			if (replacedIdentifier is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (replacedIdentifier));
			if (replacementElements is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (replacementElements));
			var nsreplacedIdentifier = CFString.CreateNative (replacedIdentifier);
			using var nsa_replacementElements = NSArray.FromNSObjects (replacementElements);
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("replaceMenuForIdentifier:withElements:"), nsreplacedIdentifier, nsa_replacementElements.Handle);
			CFString.ReleaseNative (nsreplacedIdentifier);
		}
		[Export ("insertElements:beforeMenuForIdentifier:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void InsertElementsBeforeMenu (UIMenuElement[] insertedElements, string siblingIdentifier)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			if (insertedElements is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (insertedElements));
			if (siblingIdentifier is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (siblingIdentifier));
			using var nsa_insertedElements = NSArray.FromNSObjects (insertedElements);
			var nssiblingIdentifier = CFString.CreateNative (siblingIdentifier);
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("insertElements:beforeMenuForIdentifier:"), nsa_insertedElements.Handle, nssiblingIdentifier);
			CFString.ReleaseNative (nssiblingIdentifier);
		}
		[Export ("insertElements:afterMenuForIdentifier:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void InsertElementsAfterMenu (UIMenuElement[] insertedElements, string siblingIdentifier)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			if (insertedElements is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (insertedElements));
			if (siblingIdentifier is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (siblingIdentifier));
			using var nsa_insertedElements = NSArray.FromNSObjects (insertedElements);
			var nssiblingIdentifier = CFString.CreateNative (siblingIdentifier);
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("insertElements:afterMenuForIdentifier:"), nsa_insertedElements.Handle, nssiblingIdentifier);
			CFString.ReleaseNative (nssiblingIdentifier);
		}
		[Export ("insertSiblingMenu:afterMenuForIdentifier:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void InsertSiblingMenuAfter (UIMenu siblingMenu, string siblingIdentifier)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var siblingMenu__handle__ = siblingMenu!.GetNonNullHandle (nameof (siblingMenu));
			if (siblingIdentifier is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (siblingIdentifier));
			var nssiblingIdentifier = CFString.CreateNative (siblingIdentifier);
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("insertSiblingMenu:afterMenuForIdentifier:"), siblingMenu__handle__, nssiblingIdentifier);
			GC.KeepAlive (siblingMenu);
			CFString.ReleaseNative (nssiblingIdentifier);
		}
		[Export ("insertChildMenu:atStartOfMenuForIdentifier:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void InsertChildMenuAtStart (UIMenu childMenu, string parentIdentifier)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var childMenu__handle__ = childMenu!.GetNonNullHandle (nameof (childMenu));
			if (parentIdentifier is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (parentIdentifier));
			var nsparentIdentifier = CFString.CreateNative (parentIdentifier);
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("insertChildMenu:atStartOfMenuForIdentifier:"), childMenu__handle__, nsparentIdentifier);
			GC.KeepAlive (childMenu);
			CFString.ReleaseNative (nsparentIdentifier);
		}
		[Export ("insertElements:beforeActionForIdentifier:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void InsertElementsBeforeAction (UIMenuElement[] insertedElements, string siblingIdentifier)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			if (insertedElements is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (insertedElements));
			if (siblingIdentifier is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (siblingIdentifier));
			using var nsa_insertedElements = NSArray.FromNSObjects (insertedElements);
			var nssiblingIdentifier = CFString.CreateNative (siblingIdentifier);
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("insertElements:beforeActionForIdentifier:"), nsa_insertedElements.Handle, nssiblingIdentifier);
			CFString.ReleaseNative (nssiblingIdentifier);
		}
		[Export ("insertElements:afterActionForIdentifier:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void InsertElementsAfterAction (UIMenuElement[] insertedElements, string siblingIdentifier)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			if (insertedElements is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (insertedElements));
			if (siblingIdentifier is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (siblingIdentifier));
			using var nsa_insertedElements = NSArray.FromNSObjects (insertedElements);
			var nssiblingIdentifier = CFString.CreateNative (siblingIdentifier);
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("insertElements:afterActionForIdentifier:"), nsa_insertedElements.Handle, nssiblingIdentifier);
			CFString.ReleaseNative (nssiblingIdentifier);
		}
		[Export ("insertElements:beforeCommandForAction:propertyList:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void InsertElementsBeforeCommand (UIMenuElement[] insertedElements, Selector siblingAction, NSObject? siblingPropertyList)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			if (insertedElements is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (insertedElements));
			var siblingAction__handle__ = siblingAction!.GetNonNullHandle (nameof (siblingAction));
			var siblingPropertyList__handle__ = siblingPropertyList.GetHandle ();
			using var nsa_insertedElements = NSArray.FromNSObjects (insertedElements);
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("insertElements:beforeCommandForAction:propertyList:"), nsa_insertedElements.Handle, siblingAction.Handle, siblingPropertyList__handle__);
			GC.KeepAlive (siblingAction);
			GC.KeepAlive (siblingPropertyList);
		}
		[Export ("insertElements:afterCommandForAction:propertyList:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void InsertElementsAfterCommand (UIMenuElement[] insertedElements, Selector siblingAction, NSObject? siblingPropertyList)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			if (insertedElements is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (insertedElements));
			var siblingAction__handle__ = siblingAction!.GetNonNullHandle (nameof (siblingAction));
			var siblingPropertyList__handle__ = siblingPropertyList.GetHandle ();
			using var nsa_insertedElements = NSArray.FromNSObjects (insertedElements);
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("insertElements:afterCommandForAction:propertyList:"), nsa_insertedElements.Handle, siblingAction.Handle, siblingPropertyList__handle__);
			GC.KeepAlive (siblingAction);
			GC.KeepAlive (siblingPropertyList);
		}
		[Export ("insertElements:atStartOfMenuForIdentifier:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void InsertElementsAtStartOfMenu (UIMenuElement[] childElements, string parentIdentifier)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			if (childElements is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (childElements));
			if (parentIdentifier is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (parentIdentifier));
			using var nsa_childElements = NSArray.FromNSObjects (childElements);
			var nsparentIdentifier = CFString.CreateNative (parentIdentifier);
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("insertElements:atStartOfMenuForIdentifier:"), nsa_childElements.Handle, nsparentIdentifier);
			CFString.ReleaseNative (nsparentIdentifier);
		}
		[Export ("insertChildMenu:atEndOfMenuForIdentifier:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void InsertChildMenuAtEnd (UIMenu childMenu, string parentIdentifier)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var childMenu__handle__ = childMenu!.GetNonNullHandle (nameof (childMenu));
			if (parentIdentifier is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (parentIdentifier));
			var nsparentIdentifier = CFString.CreateNative (parentIdentifier);
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("insertChildMenu:atEndOfMenuForIdentifier:"), childMenu__handle__, nsparentIdentifier);
			GC.KeepAlive (childMenu);
			CFString.ReleaseNative (nsparentIdentifier);
		}
		[Export ("insertElements:atEndOfMenuForIdentifier:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void InsertElementsAtEndOfMenu (UIMenuElement[] childElements, string parentIdentifier)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			if (childElements is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (childElements));
			if (parentIdentifier is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (parentIdentifier));
			using var nsa_childElements = NSArray.FromNSObjects (childElements);
			var nsparentIdentifier = CFString.CreateNative (parentIdentifier);
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("insertElements:atEndOfMenuForIdentifier:"), nsa_childElements.Handle, nsparentIdentifier);
			CFString.ReleaseNative (nsparentIdentifier);
		}
		[Export ("removeMenuForIdentifier:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void RemoveMenu (string removedIdentifier)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			if (removedIdentifier is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (removedIdentifier));
			var nsremovedIdentifier = CFString.CreateNative (removedIdentifier);
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("removeMenuForIdentifier:"), nsremovedIdentifier);
			CFString.ReleaseNative (nsremovedIdentifier);
		}
		[Export ("removeActionForIdentifier:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void RemoveAction (string removedIdentifier)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			if (removedIdentifier is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (removedIdentifier));
			var nsremovedIdentifier = CFString.CreateNative (removedIdentifier);
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("removeActionForIdentifier:"), nsremovedIdentifier);
			CFString.ReleaseNative (nsremovedIdentifier);
		}
		[Export ("removeCommandForAction:propertyList:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void RemoveCommand (Selector removedAction, NSObject? removedPropertyList)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var removedAction__handle__ = removedAction!.GetNonNullHandle (nameof (removedAction));
			var removedPropertyList__handle__ = removedPropertyList.GetHandle ();
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("removeCommandForAction:propertyList:"), removedAction.Handle, removedPropertyList__handle__);
			GC.KeepAlive (removedAction);
			GC.KeepAlive (removedPropertyList);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public UIMenuSystem System {
			[Export ("system")]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				UIMenuSystem ret;
				ret =  Runtime.GetNSObject<UIMenuSystem> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("system")), false)!;
				return ret;
			}
		}
	}
}
