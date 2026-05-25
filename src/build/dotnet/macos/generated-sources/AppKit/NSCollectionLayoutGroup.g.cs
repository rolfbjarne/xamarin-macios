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
	[Register("NSCollectionLayoutGroup", true)]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("macos")]
	[UnsupportedOSPlatform ("tvos")]
	[UnsupportedOSPlatform ("ios")]
	public unsafe partial class NSCollectionLayoutGroup : NSCollectionLayoutItem, INSCopying {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selCopyWithZone_X = "copyWithZone:";
		static readonly NativeHandle selCopyWithZone_XHandle = Selector.GetHandle ("copyWithZone:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selCustomGroupWithLayoutSize_ItemProvider_X = "customGroupWithLayoutSize:itemProvider:";
		static readonly NativeHandle selCustomGroupWithLayoutSize_ItemProvider_XHandle = Selector.GetHandle ("customGroupWithLayoutSize:itemProvider:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selHorizontalGroupWithLayoutSize_RepeatingSubitem_Count_X = "horizontalGroupWithLayoutSize:repeatingSubitem:count:";
		static readonly NativeHandle selHorizontalGroupWithLayoutSize_RepeatingSubitem_Count_XHandle = Selector.GetHandle ("horizontalGroupWithLayoutSize:repeatingSubitem:count:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selHorizontalGroupWithLayoutSize_Subitem_Count_X = "horizontalGroupWithLayoutSize:subitem:count:";
		static readonly NativeHandle selHorizontalGroupWithLayoutSize_Subitem_Count_XHandle = Selector.GetHandle ("horizontalGroupWithLayoutSize:subitem:count:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selHorizontalGroupWithLayoutSize_Subitems_X = "horizontalGroupWithLayoutSize:subitems:";
		static readonly NativeHandle selHorizontalGroupWithLayoutSize_Subitems_XHandle = Selector.GetHandle ("horizontalGroupWithLayoutSize:subitems:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selInterItemSpacingX = "interItemSpacing";
		static readonly NativeHandle selInterItemSpacingXHandle = Selector.GetHandle ("interItemSpacing");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetInterItemSpacing_X = "setInterItemSpacing:";
		static readonly NativeHandle selSetInterItemSpacing_XHandle = Selector.GetHandle ("setInterItemSpacing:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetSupplementaryItems_X = "setSupplementaryItems:";
		static readonly NativeHandle selSetSupplementaryItems_XHandle = Selector.GetHandle ("setSupplementaryItems:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSubitemsX = "subitems";
		static readonly NativeHandle selSubitemsXHandle = Selector.GetHandle ("subitems");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSupplementaryItemsX = "supplementaryItems";
		static readonly NativeHandle selSupplementaryItemsXHandle = Selector.GetHandle ("supplementaryItems");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selVerticalGroupWithLayoutSize_RepeatingSubitem_Count_X = "verticalGroupWithLayoutSize:repeatingSubitem:count:";
		static readonly NativeHandle selVerticalGroupWithLayoutSize_RepeatingSubitem_Count_XHandle = Selector.GetHandle ("verticalGroupWithLayoutSize:repeatingSubitem:count:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selVerticalGroupWithLayoutSize_Subitem_Count_X = "verticalGroupWithLayoutSize:subitem:count:";
		static readonly NativeHandle selVerticalGroupWithLayoutSize_Subitem_Count_XHandle = Selector.GetHandle ("verticalGroupWithLayoutSize:subitem:count:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selVerticalGroupWithLayoutSize_Subitems_X = "verticalGroupWithLayoutSize:subitems:";
		static readonly NativeHandle selVerticalGroupWithLayoutSize_Subitems_XHandle = Selector.GetHandle ("verticalGroupWithLayoutSize:subitems:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selVisualDescriptionX = "visualDescription";
		static readonly NativeHandle selVisualDescriptionXHandle = Selector.GetHandle ("visualDescription");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly NativeHandle class_ptr = Class.GetHandle ("NSCollectionLayoutGroup");
		/// <summary>The Objective-C class handle for this class.</summary>
		/// <value>The pointer to the Objective-C class.</value>
		/// <remarks>
		///     Each managed class mirrors an unmanaged Objective-C class.
		///     This value contains the pointer to the Objective-C class.
		///     It is similar to calling the managed <see cref="ObjCRuntime.Class.GetHandle(string)" /> or the native <see href="https://developer.apple.com/documentation/objectivec/1418952-objc_getclass">objc_getClass</see> method with the type name.
		/// </remarks>
		public override NativeHandle ClassHandle { get { return class_ptr; } }
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
		protected NSCollectionLayoutGroup (NSObjectFlag t) : base (t)
		{
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
		protected internal NSCollectionLayoutGroup (NativeHandle handle) : base (handle)
		{
		}

		/// <param name="zone">Developers should pass <see langword="null" />.  Memory zones are no longer used.</param><summary>Performs a copy of the underlying Objective-C object.</summary><returns>The newly-allocated object.</returns><remarks><para>This method performs a "shallow copy" of <see langword="this" />. If this object contains references to external objects, the new object will contain references to the same object.</para></remarks>
		[Export ("copyWithZone:")]
		[return: ReleaseAttribute ()]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public new virtual NSObject Copy (NSZone? zone)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var zone__handle__ = zone.GetHandle ();
			NSObject? ret;
			if (IsDirectBinding) {
				ret = Runtime.GetNSObject (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, selCopyWithZone_XHandle, zone__handle__), true)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = Runtime.GetNSObject (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle (&__objc_super__, selCopyWithZone_XHandle, zone__handle__), true)!;
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (zone);
			return ret!;
		}
		[Export ("customGroupWithLayoutSize:itemProvider:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static NSCollectionLayoutGroup CreateCustom (NSCollectionLayoutSize layoutSize, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDNSCollectionLayoutGroupCustomItemProvider))]NSCollectionLayoutGroupCustomItemProvider itemProvider)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var layoutSize__handle__ = layoutSize!.GetNonNullHandle (nameof (layoutSize));
			if (itemProvider is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (itemProvider));
			using var block_itemProvider = Trampolines.SDNSCollectionLayoutGroupCustomItemProvider.CreateBlock (itemProvider);
			BlockLiteral *block_ptr_itemProvider = &block_itemProvider;
			NSCollectionLayoutGroup? ret;
			ret =  Runtime.GetNSObject<NSCollectionLayoutGroup> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (class_ptr, selCustomGroupWithLayoutSize_ItemProvider_XHandle, layoutSize__handle__, (IntPtr) block_ptr_itemProvider), false)!;
			GC.KeepAlive (layoutSize);
			return ret!;
		}
		[Export ("horizontalGroupWithLayoutSize:subitem:count:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSCollectionLayoutGroup CreateHorizontal (NSCollectionLayoutSize layoutSize, NSCollectionLayoutItem subitem, nint count)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var layoutSize__handle__ = layoutSize!.GetNonNullHandle (nameof (layoutSize));
			var subitem__handle__ = subitem!.GetNonNullHandle (nameof (subitem));
			NSCollectionLayoutGroup? ret;
			ret =  Runtime.GetNSObject<NSCollectionLayoutGroup> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_IntPtr (class_ptr, selHorizontalGroupWithLayoutSize_Subitem_Count_XHandle, layoutSize__handle__, subitem__handle__, count), false)!;
			GC.KeepAlive (layoutSize);
			GC.KeepAlive (subitem);
			return ret!;
		}
		[Export ("horizontalGroupWithLayoutSize:subitems:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSCollectionLayoutGroup CreateHorizontal (NSCollectionLayoutSize layoutSize, params NSCollectionLayoutItem[] subitems)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var layoutSize__handle__ = layoutSize!.GetNonNullHandle (nameof (layoutSize));
			if (subitems is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (subitems));
			using var nsa_subitems = NSArray.FromNSObjects (subitems);
			NSCollectionLayoutGroup? ret;
			ret =  Runtime.GetNSObject<NSCollectionLayoutGroup> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (class_ptr, selHorizontalGroupWithLayoutSize_Subitems_XHandle, layoutSize__handle__, nsa_subitems.Handle), false)!;
			GC.KeepAlive (layoutSize);
			return ret!;
		}
		[Export ("verticalGroupWithLayoutSize:subitem:count:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSCollectionLayoutGroup CreateVertical (NSCollectionLayoutSize layoutSize, NSCollectionLayoutItem subitem, nint count)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var layoutSize__handle__ = layoutSize!.GetNonNullHandle (nameof (layoutSize));
			var subitem__handle__ = subitem!.GetNonNullHandle (nameof (subitem));
			NSCollectionLayoutGroup? ret;
			ret =  Runtime.GetNSObject<NSCollectionLayoutGroup> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_IntPtr (class_ptr, selVerticalGroupWithLayoutSize_Subitem_Count_XHandle, layoutSize__handle__, subitem__handle__, count), false)!;
			GC.KeepAlive (layoutSize);
			GC.KeepAlive (subitem);
			return ret!;
		}
		[Export ("verticalGroupWithLayoutSize:subitems:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSCollectionLayoutGroup CreateVertical (NSCollectionLayoutSize layoutSize, params NSCollectionLayoutItem[] subitems)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var layoutSize__handle__ = layoutSize!.GetNonNullHandle (nameof (layoutSize));
			if (subitems is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (subitems));
			using var nsa_subitems = NSArray.FromNSObjects (subitems);
			NSCollectionLayoutGroup? ret;
			ret =  Runtime.GetNSObject<NSCollectionLayoutGroup> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (class_ptr, selVerticalGroupWithLayoutSize_Subitems_XHandle, layoutSize__handle__, nsa_subitems.Handle), false)!;
			GC.KeepAlive (layoutSize);
			return ret!;
		}
		[Export ("horizontalGroupWithLayoutSize:repeatingSubitem:count:")]
		[SupportedOSPlatform ("maccatalyst16.0")]
		[SupportedOSPlatform ("macos13.0")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("ios")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSCollectionLayoutGroup GetHorizontalGroup (NSCollectionLayoutSize layoutSize, NSCollectionLayoutItem repeatingSubitem, nint count)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var layoutSize__handle__ = layoutSize!.GetNonNullHandle (nameof (layoutSize));
			var repeatingSubitem__handle__ = repeatingSubitem!.GetNonNullHandle (nameof (repeatingSubitem));
			NSCollectionLayoutGroup? ret;
			ret =  Runtime.GetNSObject<NSCollectionLayoutGroup> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_IntPtr (class_ptr, selHorizontalGroupWithLayoutSize_RepeatingSubitem_Count_XHandle, layoutSize__handle__, repeatingSubitem__handle__, count), false)!;
			GC.KeepAlive (layoutSize);
			GC.KeepAlive (repeatingSubitem);
			return ret!;
		}
		[Export ("verticalGroupWithLayoutSize:repeatingSubitem:count:")]
		[SupportedOSPlatform ("maccatalyst16.0")]
		[SupportedOSPlatform ("macos13.0")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("ios")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSCollectionLayoutGroup GetVerticalGroup (NSCollectionLayoutSize layoutSize, NSCollectionLayoutItem repeatingSubitem, nint count)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var layoutSize__handle__ = layoutSize!.GetNonNullHandle (nameof (layoutSize));
			var repeatingSubitem__handle__ = repeatingSubitem!.GetNonNullHandle (nameof (repeatingSubitem));
			NSCollectionLayoutGroup? ret;
			ret =  Runtime.GetNSObject<NSCollectionLayoutGroup> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_IntPtr (class_ptr, selVerticalGroupWithLayoutSize_RepeatingSubitem_Count_XHandle, layoutSize__handle__, repeatingSubitem__handle__, count), false)!;
			GC.KeepAlive (layoutSize);
			GC.KeepAlive (repeatingSubitem);
			return ret!;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSCollectionLayoutSpacing? InterItemSpacing {
			[Export ("interItemSpacing", ArgumentSemantic.Copy)]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				NSCollectionLayoutSpacing? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSCollectionLayoutSpacing> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selInterItemSpacingXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<NSCollectionLayoutSpacing> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selInterItemSpacingXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setInterItemSpacing:", ArgumentSemantic.Copy)]
			set {
				global::AppKit.NSApplication.EnsureUIThread ();
				var value__handle__ = value.GetHandle ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selSetInterItemSpacing_XHandle, value__handle__);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selSetInterItemSpacing_XHandle, value__handle__);
						GC.KeepAlive (this);
					}
				}
				GC.KeepAlive (value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSCollectionLayoutItem[] Subitems {
			[Export ("subitems")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				NSCollectionLayoutItem[]? ret;
				if (IsDirectBinding) {
					ret = CFArray.ArrayFromHandle<NSCollectionLayoutItem>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selSubitemsXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFArray.ArrayFromHandle<NSCollectionLayoutItem>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selSubitemsXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSCollectionLayoutSupplementaryItem[] SupplementaryItems {
			[Export ("supplementaryItems", ArgumentSemantic.Copy)]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				NSCollectionLayoutSupplementaryItem[]? ret;
				if (IsDirectBinding) {
					ret = CFArray.ArrayFromHandle<NSCollectionLayoutSupplementaryItem>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selSupplementaryItemsXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFArray.ArrayFromHandle<NSCollectionLayoutSupplementaryItem>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selSupplementaryItemsXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setSupplementaryItems:", ArgumentSemantic.Copy)]
			set {
				global::AppKit.NSApplication.EnsureUIThread ();
				if (value is null)
					ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (value));
				using var nsa_value = NSArray.FromNSObjects (value);
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selSetSupplementaryItems_XHandle, nsa_value.Handle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selSetSupplementaryItems_XHandle, nsa_value.Handle);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string VisualDescription {
			[Export ("visualDescription")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				string ret;
				if (IsDirectBinding) {
					ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selVisualDescriptionXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selVisualDescriptionXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
	} /* class NSCollectionLayoutGroup */
}
