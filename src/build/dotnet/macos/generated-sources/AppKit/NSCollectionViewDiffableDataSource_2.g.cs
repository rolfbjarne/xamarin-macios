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
	[Register("NSCollectionViewDiffableDataSource", true)]
	[UnsupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("macos")]
	public unsafe partial class NSCollectionViewDiffableDataSource<SectionIdentifierType, ItemIdentifierType> : NSObject, INSCollectionViewDataSource 
			where SectionIdentifierType : NSObject
			where ItemIdentifierType : NSObject {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selApplySnapshot_AnimatingDifferences_X = "applySnapshot:animatingDifferences:";
		static readonly NativeHandle selApplySnapshot_AnimatingDifferences_XHandle = Selector.GetHandle ("applySnapshot:animatingDifferences:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selCollectionView_ItemForRepresentedObjectAtIndexPath_X = "collectionView:itemForRepresentedObjectAtIndexPath:";
		static readonly NativeHandle selCollectionView_ItemForRepresentedObjectAtIndexPath_XHandle = Selector.GetHandle ("collectionView:itemForRepresentedObjectAtIndexPath:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selCollectionView_NumberOfItemsInSection_X = "collectionView:numberOfItemsInSection:";
		static readonly NativeHandle selCollectionView_NumberOfItemsInSection_XHandle = Selector.GetHandle ("collectionView:numberOfItemsInSection:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selCollectionView_ViewForSupplementaryElementOfKind_AtIndexPath_X = "collectionView:viewForSupplementaryElementOfKind:atIndexPath:";
		static readonly NativeHandle selCollectionView_ViewForSupplementaryElementOfKind_AtIndexPath_XHandle = Selector.GetHandle ("collectionView:viewForSupplementaryElementOfKind:atIndexPath:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selIndexPathForItemIdentifier_X = "indexPathForItemIdentifier:";
		static readonly NativeHandle selIndexPathForItemIdentifier_XHandle = Selector.GetHandle ("indexPathForItemIdentifier:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selInitWithCollectionView_ItemProvider_X = "initWithCollectionView:itemProvider:";
		static readonly NativeHandle selInitWithCollectionView_ItemProvider_XHandle = Selector.GetHandle ("initWithCollectionView:itemProvider:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selItemIdentifierForIndexPath_X = "itemIdentifierForIndexPath:";
		static readonly NativeHandle selItemIdentifierForIndexPath_XHandle = Selector.GetHandle ("itemIdentifierForIndexPath:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selNumberOfSectionsInCollectionView_X = "numberOfSectionsInCollectionView:";
		static readonly NativeHandle selNumberOfSectionsInCollectionView_XHandle = Selector.GetHandle ("numberOfSectionsInCollectionView:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetSupplementaryViewProvider_X = "setSupplementaryViewProvider:";
		static readonly NativeHandle selSetSupplementaryViewProvider_XHandle = Selector.GetHandle ("setSupplementaryViewProvider:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSnapshotX = "snapshot";
		static readonly NativeHandle selSnapshotXHandle = Selector.GetHandle ("snapshot");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSupplementaryViewProviderX = "supplementaryViewProvider";
		static readonly NativeHandle selSupplementaryViewProviderXHandle = Selector.GetHandle ("supplementaryViewProvider");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly NativeHandle class_ptr = Class.GetHandle ("NSCollectionViewDiffableDataSource");
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
		protected NSCollectionViewDiffableDataSource (NSObjectFlag t) : base (t)
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
		protected internal NSCollectionViewDiffableDataSource (NativeHandle handle) : base (handle)
		{
		}

		[Export ("initWithCollectionView:itemProvider:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe NSCollectionViewDiffableDataSource (NSCollectionView collectionView, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDNSCollectionViewDiffableDataSourceItemProvider))]NSCollectionViewDiffableDataSourceItemProvider itemProvider)
			: base (NSObjectFlag.Empty)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var collectionView__handle__ = collectionView!.GetNonNullHandle (nameof (collectionView));
			if (itemProvider is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (itemProvider));
			using var block_itemProvider = Trampolines.SDNSCollectionViewDiffableDataSourceItemProvider.CreateBlock (itemProvider);
			BlockLiteral *block_ptr_itemProvider = &block_itemProvider;
			if (IsDirectBinding) {
				InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (this.Handle, selInitWithCollectionView_ItemProvider_XHandle, collectionView__handle__, (IntPtr) block_ptr_itemProvider), "initWithCollectionView:itemProvider:");
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, selInitWithCollectionView_ItemProvider_XHandle, collectionView__handle__, (IntPtr) block_ptr_itemProvider), "initWithCollectionView:itemProvider:");
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (collectionView);
		}
		[Export ("applySnapshot:animatingDifferences:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void Apply (NSDiffableDataSourceSnapshot<SectionIdentifierType, ItemIdentifierType> snapshot, bool animatingDifferences)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var snapshot__handle__ = snapshot!.GetNonNullHandle (nameof (snapshot));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_bool (this.Handle, selApplySnapshot_AnimatingDifferences_XHandle, snapshot__handle__, animatingDifferences ? (byte) 1 : (byte) 0);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_bool (&__objc_super__, selApplySnapshot_AnimatingDifferences_XHandle, snapshot__handle__, animatingDifferences ? (byte) 1 : (byte) 0);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (snapshot);
		}
		[Export ("indexPathForItemIdentifier:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSIndexPath? GetIndexPath (ItemIdentifierType identifier)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var identifier__handle__ = identifier!.GetNonNullHandle (nameof (identifier));
			NSIndexPath? ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<NSIndexPath> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, selIndexPathForItemIdentifier_XHandle, identifier__handle__), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<NSIndexPath> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle (&__objc_super__, selIndexPathForItemIdentifier_XHandle, identifier__handle__), false)!;
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (identifier);
			return ret!;
		}
		/// <param name="collectionView">To be added.</param><param name="indexPath">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("collectionView:itemForRepresentedObjectAtIndexPath:")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSCollectionViewItem GetItem (NSCollectionView collectionView, NSIndexPath indexPath)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var collectionView__handle__ = collectionView!.GetNonNullHandle (nameof (collectionView));
			var indexPath__handle__ = indexPath!.GetNonNullHandle (nameof (indexPath));
			NSCollectionViewItem? ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<NSCollectionViewItem> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (this.Handle, selCollectionView_ItemForRepresentedObjectAtIndexPath_XHandle, collectionView__handle__, indexPath__handle__), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<NSCollectionViewItem> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, selCollectionView_ItemForRepresentedObjectAtIndexPath_XHandle, collectionView__handle__, indexPath__handle__), false)!;
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (collectionView);
			GC.KeepAlive (indexPath);
			return ret!;
		}
		[Export ("itemIdentifierForIndexPath:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual ItemIdentifierType? GetItemIdentifier (NSIndexPath indexPath)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var indexPath__handle__ = indexPath!.GetNonNullHandle (nameof (indexPath));
			ItemIdentifierType? ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<ItemIdentifierType> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, selItemIdentifierForIndexPath_XHandle, indexPath__handle__), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<ItemIdentifierType> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle (&__objc_super__, selItemIdentifierForIndexPath_XHandle, indexPath__handle__), false)!;
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (indexPath);
			return ret!;
		}
		/// <param name="collectionView">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("numberOfSectionsInCollectionView:")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual nint GetNumberOfSections (NSCollectionView collectionView)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var collectionView__handle__ = collectionView!.GetNonNullHandle (nameof (collectionView));
			nint ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSend_NativeHandle (this.Handle, selNumberOfSectionsInCollectionView_XHandle, collectionView__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper_NativeHandle (&__objc_super__, selNumberOfSectionsInCollectionView_XHandle, collectionView__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (collectionView);
			return ret!;
		}
		/// <param name="collectionView">To be added.</param><param name="section">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("collectionView:numberOfItemsInSection:")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual nint GetNumberofItems (NSCollectionView collectionView, nint section)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var collectionView__handle__ = collectionView!.GetNonNullHandle (nameof (collectionView));
			nint ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSend_NativeHandle_IntPtr (this.Handle, selCollectionView_NumberOfItemsInSection_XHandle, collectionView__handle__, section);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper_NativeHandle_IntPtr (&__objc_super__, selCollectionView_NumberOfItemsInSection_XHandle, collectionView__handle__, section);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (collectionView);
			return ret!;
		}
		/// <param name="collectionView">To be added.</param><param name="kind">To be added.</param><param name="indexPath">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("collectionView:viewForSupplementaryElementOfKind:atIndexPath:")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSView GetView (NSCollectionView collectionView, NSString kind, NSIndexPath indexPath)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var collectionView__handle__ = collectionView!.GetNonNullHandle (nameof (collectionView));
			var kind__handle__ = kind!.GetNonNullHandle (nameof (kind));
			var indexPath__handle__ = indexPath!.GetNonNullHandle (nameof (indexPath));
			NSView? ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<NSView> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (this.Handle, selCollectionView_ViewForSupplementaryElementOfKind_AtIndexPath_XHandle, collectionView__handle__, kind__handle__, indexPath__handle__), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<NSView> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_NativeHandle_NativeHandle (&__objc_super__, selCollectionView_ViewForSupplementaryElementOfKind_AtIndexPath_XHandle, collectionView__handle__, kind__handle__, indexPath__handle__), false)!;
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (collectionView);
			GC.KeepAlive (kind);
			GC.KeepAlive (indexPath);
			return ret!;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSDiffableDataSourceSnapshot<SectionIdentifierType, ItemIdentifierType> Snapshot {
			[Export ("snapshot")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				NSDiffableDataSourceSnapshot<SectionIdentifierType, ItemIdentifierType>? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSDiffableDataSourceSnapshot<SectionIdentifierType, ItemIdentifierType>> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selSnapshotXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<NSDiffableDataSourceSnapshot<SectionIdentifierType, ItemIdentifierType>> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selSnapshotXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual NSCollectionViewDiffableDataSourceSupplementaryViewProvider? SupplementaryViewProvider {
			[return: DelegateProxy (typeof (ObjCRuntime.Trampolines.SDNSCollectionViewDiffableDataSourceSupplementaryViewProvider))]
			[Export ("supplementaryViewProvider", ArgumentSemantic.Copy)]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				NativeHandle ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selSupplementaryViewProviderXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selSupplementaryViewProviderXHandle);
						GC.KeepAlive (this);
					}
				}
				return global::ObjCRuntime.Trampolines.NIDNSCollectionViewDiffableDataSourceSupplementaryViewProvider.Create (ret)!;
			}
			[param: BlockProxy (typeof (ObjCRuntime.Trampolines.NIDNSCollectionViewDiffableDataSourceSupplementaryViewProvider))]
			[Export ("setSupplementaryViewProvider:", ArgumentSemantic.Copy)]
			set {
				global::AppKit.NSApplication.EnsureUIThread ();
				using var block_value = Trampolines.SDNSCollectionViewDiffableDataSourceSupplementaryViewProvider.CreateNullableBlock (value);
				BlockLiteral *block_ptr_value = null;
				if (value is not null)
					block_ptr_value = &block_value;
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selSetSupplementaryViewProvider_XHandle, (IntPtr) block_ptr_value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selSetSupplementaryViewProvider_XHandle, (IntPtr) block_ptr_value);
						GC.KeepAlive (this);
					}
				}
			}
		}
	} /* class NSCollectionViewDiffableDataSource */
}
