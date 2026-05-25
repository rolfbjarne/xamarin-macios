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
	[Register("NSDiffableDataSourceSnapshot", true)]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("macos")]
	[UnsupportedOSPlatform ("tvos")]
	[UnsupportedOSPlatform ("ios")]
	public unsafe partial class NSDiffableDataSourceSnapshot<SectionIdentifierType, ItemIdentifierType> : NSObject, INSCopying 
			where SectionIdentifierType : NSObject
			where ItemIdentifierType : NSObject {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAppendItemsWithIdentifiers_X = "appendItemsWithIdentifiers:";
		static readonly NativeHandle selAppendItemsWithIdentifiers_XHandle = Selector.GetHandle ("appendItemsWithIdentifiers:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAppendItemsWithIdentifiers_IntoSectionWithIdentifier_X = "appendItemsWithIdentifiers:intoSectionWithIdentifier:";
		static readonly NativeHandle selAppendItemsWithIdentifiers_IntoSectionWithIdentifier_XHandle = Selector.GetHandle ("appendItemsWithIdentifiers:intoSectionWithIdentifier:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAppendSectionsWithIdentifiers_X = "appendSectionsWithIdentifiers:";
		static readonly NativeHandle selAppendSectionsWithIdentifiers_XHandle = Selector.GetHandle ("appendSectionsWithIdentifiers:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selCopyWithZone_X = "copyWithZone:";
		static readonly NativeHandle selCopyWithZone_XHandle = Selector.GetHandle ("copyWithZone:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selDeleteAllItemsX = "deleteAllItems";
		static readonly NativeHandle selDeleteAllItemsXHandle = Selector.GetHandle ("deleteAllItems");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selDeleteItemsWithIdentifiers_X = "deleteItemsWithIdentifiers:";
		static readonly NativeHandle selDeleteItemsWithIdentifiers_XHandle = Selector.GetHandle ("deleteItemsWithIdentifiers:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selDeleteSectionsWithIdentifiers_X = "deleteSectionsWithIdentifiers:";
		static readonly NativeHandle selDeleteSectionsWithIdentifiers_XHandle = Selector.GetHandle ("deleteSectionsWithIdentifiers:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selIndexOfItemIdentifier_X = "indexOfItemIdentifier:";
		static readonly NativeHandle selIndexOfItemIdentifier_XHandle = Selector.GetHandle ("indexOfItemIdentifier:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selIndexOfSectionIdentifier_X = "indexOfSectionIdentifier:";
		static readonly NativeHandle selIndexOfSectionIdentifier_XHandle = Selector.GetHandle ("indexOfSectionIdentifier:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selInsertItemsWithIdentifiers_AfterItemWithIdentifier_X = "insertItemsWithIdentifiers:afterItemWithIdentifier:";
		static readonly NativeHandle selInsertItemsWithIdentifiers_AfterItemWithIdentifier_XHandle = Selector.GetHandle ("insertItemsWithIdentifiers:afterItemWithIdentifier:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selInsertItemsWithIdentifiers_BeforeItemWithIdentifier_X = "insertItemsWithIdentifiers:beforeItemWithIdentifier:";
		static readonly NativeHandle selInsertItemsWithIdentifiers_BeforeItemWithIdentifier_XHandle = Selector.GetHandle ("insertItemsWithIdentifiers:beforeItemWithIdentifier:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selInsertSectionsWithIdentifiers_AfterSectionWithIdentifier_X = "insertSectionsWithIdentifiers:afterSectionWithIdentifier:";
		static readonly NativeHandle selInsertSectionsWithIdentifiers_AfterSectionWithIdentifier_XHandle = Selector.GetHandle ("insertSectionsWithIdentifiers:afterSectionWithIdentifier:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selInsertSectionsWithIdentifiers_BeforeSectionWithIdentifier_X = "insertSectionsWithIdentifiers:beforeSectionWithIdentifier:";
		static readonly NativeHandle selInsertSectionsWithIdentifiers_BeforeSectionWithIdentifier_XHandle = Selector.GetHandle ("insertSectionsWithIdentifiers:beforeSectionWithIdentifier:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selItemIdentifiersX = "itemIdentifiers";
		static readonly NativeHandle selItemIdentifiersXHandle = Selector.GetHandle ("itemIdentifiers");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selItemIdentifiersInSectionWithIdentifier_X = "itemIdentifiersInSectionWithIdentifier:";
		static readonly NativeHandle selItemIdentifiersInSectionWithIdentifier_XHandle = Selector.GetHandle ("itemIdentifiersInSectionWithIdentifier:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selMoveItemWithIdentifier_AfterItemWithIdentifier_X = "moveItemWithIdentifier:afterItemWithIdentifier:";
		static readonly NativeHandle selMoveItemWithIdentifier_AfterItemWithIdentifier_XHandle = Selector.GetHandle ("moveItemWithIdentifier:afterItemWithIdentifier:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selMoveItemWithIdentifier_BeforeItemWithIdentifier_X = "moveItemWithIdentifier:beforeItemWithIdentifier:";
		static readonly NativeHandle selMoveItemWithIdentifier_BeforeItemWithIdentifier_XHandle = Selector.GetHandle ("moveItemWithIdentifier:beforeItemWithIdentifier:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selMoveSectionWithIdentifier_AfterSectionWithIdentifier_X = "moveSectionWithIdentifier:afterSectionWithIdentifier:";
		static readonly NativeHandle selMoveSectionWithIdentifier_AfterSectionWithIdentifier_XHandle = Selector.GetHandle ("moveSectionWithIdentifier:afterSectionWithIdentifier:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selMoveSectionWithIdentifier_BeforeSectionWithIdentifier_X = "moveSectionWithIdentifier:beforeSectionWithIdentifier:";
		static readonly NativeHandle selMoveSectionWithIdentifier_BeforeSectionWithIdentifier_XHandle = Selector.GetHandle ("moveSectionWithIdentifier:beforeSectionWithIdentifier:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selNumberOfItemsX = "numberOfItems";
		static readonly NativeHandle selNumberOfItemsXHandle = Selector.GetHandle ("numberOfItems");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selNumberOfItemsInSection_X = "numberOfItemsInSection:";
		static readonly NativeHandle selNumberOfItemsInSection_XHandle = Selector.GetHandle ("numberOfItemsInSection:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selNumberOfSectionsX = "numberOfSections";
		static readonly NativeHandle selNumberOfSectionsXHandle = Selector.GetHandle ("numberOfSections");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selReconfigureItemsWithIdentifiers_X = "reconfigureItemsWithIdentifiers:";
		static readonly NativeHandle selReconfigureItemsWithIdentifiers_XHandle = Selector.GetHandle ("reconfigureItemsWithIdentifiers:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selReconfiguredItemIdentifiersX = "reconfiguredItemIdentifiers";
		static readonly NativeHandle selReconfiguredItemIdentifiersXHandle = Selector.GetHandle ("reconfiguredItemIdentifiers");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selReloadItemsWithIdentifiers_X = "reloadItemsWithIdentifiers:";
		static readonly NativeHandle selReloadItemsWithIdentifiers_XHandle = Selector.GetHandle ("reloadItemsWithIdentifiers:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selReloadSectionsWithIdentifiers_X = "reloadSectionsWithIdentifiers:";
		static readonly NativeHandle selReloadSectionsWithIdentifiers_XHandle = Selector.GetHandle ("reloadSectionsWithIdentifiers:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selReloadedItemIdentifiersX = "reloadedItemIdentifiers";
		static readonly NativeHandle selReloadedItemIdentifiersXHandle = Selector.GetHandle ("reloadedItemIdentifiers");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selReloadedSectionIdentifiersX = "reloadedSectionIdentifiers";
		static readonly NativeHandle selReloadedSectionIdentifiersXHandle = Selector.GetHandle ("reloadedSectionIdentifiers");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSectionIdentifierForSectionContainingItemIdentifier_X = "sectionIdentifierForSectionContainingItemIdentifier:";
		static readonly NativeHandle selSectionIdentifierForSectionContainingItemIdentifier_XHandle = Selector.GetHandle ("sectionIdentifierForSectionContainingItemIdentifier:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSectionIdentifiersX = "sectionIdentifiers";
		static readonly NativeHandle selSectionIdentifiersXHandle = Selector.GetHandle ("sectionIdentifiers");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly NativeHandle class_ptr = Class.GetHandle ("NSDiffableDataSourceSnapshot");
		/// <summary>The Objective-C class handle for this class.</summary>
		/// <value>The pointer to the Objective-C class.</value>
		/// <remarks>
		///     Each managed class mirrors an unmanaged Objective-C class.
		///     This value contains the pointer to the Objective-C class.
		///     It is similar to calling the managed <see cref="ObjCRuntime.Class.GetHandle(string)" /> or the native <see href="https://developer.apple.com/documentation/objectivec/1418952-objc_getclass">objc_getClass</see> method with the type name.
		/// </remarks>
		public override NativeHandle ClassHandle { get { return class_ptr; } }
		/// <summary>Creates a new <see cref="NSDiffableDataSourceSnapshot{SectionIdentifierType, ItemIdentifierType}" /> with default values.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public NSDiffableDataSourceSnapshot () : base (NSObjectFlag.Empty)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			if (IsDirectBinding) {
				InitializeHandle (global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, global::ObjCRuntime.Selector.Init), "init");
			} else {
				unsafe {
				var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
				InitializeHandle (global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (&__objc_super__, global::ObjCRuntime.Selector.Init), "init");
				GC.KeepAlive (this);
				}
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
		protected NSDiffableDataSourceSnapshot (NSObjectFlag t) : base (t)
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
		protected internal NSDiffableDataSourceSnapshot (NativeHandle handle) : base (handle)
		{
		}

		[Export ("appendItemsWithIdentifiers:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void AppendItems (ItemIdentifierType[] identifiers)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			if (identifiers is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (identifiers));
			using var nsa_identifiers = NSArray.FromNSObjects (identifiers);
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selAppendItemsWithIdentifiers_XHandle, nsa_identifiers.Handle);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selAppendItemsWithIdentifiers_XHandle, nsa_identifiers.Handle);
					GC.KeepAlive (this);
				}
			}
		}
		[Export ("appendItemsWithIdentifiers:intoSectionWithIdentifier:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void AppendItems (ItemIdentifierType[] identifiers, SectionIdentifierType sectionIdentifier)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			if (identifiers is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (identifiers));
			var sectionIdentifier__handle__ = sectionIdentifier!.GetNonNullHandle (nameof (sectionIdentifier));
			using var nsa_identifiers = NSArray.FromNSObjects (identifiers);
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (this.Handle, selAppendItemsWithIdentifiers_IntoSectionWithIdentifier_XHandle, nsa_identifiers.Handle, sectionIdentifier__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, selAppendItemsWithIdentifiers_IntoSectionWithIdentifier_XHandle, nsa_identifiers.Handle, sectionIdentifier__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (sectionIdentifier);
		}
		[Export ("appendSectionsWithIdentifiers:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void AppendSections (SectionIdentifierType[] sectionIdentifiers)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			if (sectionIdentifiers is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (sectionIdentifiers));
			using var nsa_sectionIdentifiers = NSArray.FromNSObjects (sectionIdentifiers);
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selAppendSectionsWithIdentifiers_XHandle, nsa_sectionIdentifiers.Handle);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selAppendSectionsWithIdentifiers_XHandle, nsa_sectionIdentifiers.Handle);
					GC.KeepAlive (this);
				}
			}
		}
		/// <param name="zone">Developers should pass <see langword="null" />.  Memory zones are no longer used.</param><summary>Performs a copy of the underlying Objective-C object.</summary><returns>The newly-allocated object.</returns><remarks><para>This method performs a "shallow copy" of <see langword="this" />. If this object contains references to external objects, the new object will contain references to the same object.</para></remarks>
		[Export ("copyWithZone:")]
		[return: ReleaseAttribute ()]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSObject Copy (NSZone? zone)
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
		[Export ("deleteAllItems")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DeleteAllItems ()
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, selDeleteAllItemsXHandle);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper (&__objc_super__, selDeleteAllItemsXHandle);
					GC.KeepAlive (this);
				}
			}
		}
		[Export ("deleteItemsWithIdentifiers:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DeleteItems (ItemIdentifierType[] identifiers)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			if (identifiers is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (identifiers));
			using var nsa_identifiers = NSArray.FromNSObjects (identifiers);
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selDeleteItemsWithIdentifiers_XHandle, nsa_identifiers.Handle);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selDeleteItemsWithIdentifiers_XHandle, nsa_identifiers.Handle);
					GC.KeepAlive (this);
				}
			}
		}
		[Export ("deleteSectionsWithIdentifiers:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DeleteSections (SectionIdentifierType[] sectionIdentifiers)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			if (sectionIdentifiers is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (sectionIdentifiers));
			using var nsa_sectionIdentifiers = NSArray.FromNSObjects (sectionIdentifiers);
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selDeleteSectionsWithIdentifiers_XHandle, nsa_sectionIdentifiers.Handle);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selDeleteSectionsWithIdentifiers_XHandle, nsa_sectionIdentifiers.Handle);
					GC.KeepAlive (this);
				}
			}
		}
		[Export ("indexOfItemIdentifier:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual nint GetIndex (ItemIdentifierType itemIdentifier)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var itemIdentifier__handle__ = itemIdentifier!.GetNonNullHandle (nameof (itemIdentifier));
			nint ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSend_NativeHandle (this.Handle, selIndexOfItemIdentifier_XHandle, itemIdentifier__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper_NativeHandle (&__objc_super__, selIndexOfItemIdentifier_XHandle, itemIdentifier__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (itemIdentifier);
			return ret!;
		}
		[Export ("indexOfSectionIdentifier:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual nint GetIndex (SectionIdentifierType sectionIdentifier)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var sectionIdentifier__handle__ = sectionIdentifier!.GetNonNullHandle (nameof (sectionIdentifier));
			nint ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSend_NativeHandle (this.Handle, selIndexOfSectionIdentifier_XHandle, sectionIdentifier__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper_NativeHandle (&__objc_super__, selIndexOfSectionIdentifier_XHandle, sectionIdentifier__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (sectionIdentifier);
			return ret!;
		}
		[Export ("itemIdentifiersInSectionWithIdentifier:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual ItemIdentifierType[] GetItemIdentifiersInSection (SectionIdentifierType sectionIdentifier)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var sectionIdentifier__handle__ = sectionIdentifier!.GetNonNullHandle (nameof (sectionIdentifier));
			ItemIdentifierType[]? ret;
			if (IsDirectBinding) {
				ret = CFArray.ArrayFromHandle<ItemIdentifierType>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, selItemIdentifiersInSectionWithIdentifier_XHandle, sectionIdentifier__handle__), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = CFArray.ArrayFromHandle<ItemIdentifierType>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle (&__objc_super__, selItemIdentifiersInSectionWithIdentifier_XHandle, sectionIdentifier__handle__), false)!;
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (sectionIdentifier);
			return ret!;
		}
		[Export ("numberOfItemsInSection:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual nint GetNumberOfItems (SectionIdentifierType sectionIdentifier)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var sectionIdentifier__handle__ = sectionIdentifier!.GetNonNullHandle (nameof (sectionIdentifier));
			nint ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSend_NativeHandle (this.Handle, selNumberOfItemsInSection_XHandle, sectionIdentifier__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper_NativeHandle (&__objc_super__, selNumberOfItemsInSection_XHandle, sectionIdentifier__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (sectionIdentifier);
			return ret!;
		}
		[Export ("sectionIdentifierForSectionContainingItemIdentifier:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual SectionIdentifierType? GetSectionIdentifierForSection (ItemIdentifierType itemIdentifier)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var itemIdentifier__handle__ = itemIdentifier!.GetNonNullHandle (nameof (itemIdentifier));
			SectionIdentifierType? ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<SectionIdentifierType> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, selSectionIdentifierForSectionContainingItemIdentifier_XHandle, itemIdentifier__handle__), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<SectionIdentifierType> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle (&__objc_super__, selSectionIdentifierForSectionContainingItemIdentifier_XHandle, itemIdentifier__handle__), false)!;
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (itemIdentifier);
			return ret!;
		}
		[Export ("insertItemsWithIdentifiers:afterItemWithIdentifier:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void InsertItemsAfter (ItemIdentifierType[] identifiers, ItemIdentifierType itemIdentifier)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			if (identifiers is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (identifiers));
			var itemIdentifier__handle__ = itemIdentifier!.GetNonNullHandle (nameof (itemIdentifier));
			using var nsa_identifiers = NSArray.FromNSObjects (identifiers);
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (this.Handle, selInsertItemsWithIdentifiers_AfterItemWithIdentifier_XHandle, nsa_identifiers.Handle, itemIdentifier__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, selInsertItemsWithIdentifiers_AfterItemWithIdentifier_XHandle, nsa_identifiers.Handle, itemIdentifier__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (itemIdentifier);
		}
		[Export ("insertItemsWithIdentifiers:beforeItemWithIdentifier:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void InsertItemsBefore (ItemIdentifierType[] identifiers, ItemIdentifierType itemIdentifier)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			if (identifiers is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (identifiers));
			var itemIdentifier__handle__ = itemIdentifier!.GetNonNullHandle (nameof (itemIdentifier));
			using var nsa_identifiers = NSArray.FromNSObjects (identifiers);
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (this.Handle, selInsertItemsWithIdentifiers_BeforeItemWithIdentifier_XHandle, nsa_identifiers.Handle, itemIdentifier__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, selInsertItemsWithIdentifiers_BeforeItemWithIdentifier_XHandle, nsa_identifiers.Handle, itemIdentifier__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (itemIdentifier);
		}
		[Export ("insertSectionsWithIdentifiers:afterSectionWithIdentifier:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void InsertSectionsAfter (SectionIdentifierType[] sectionIdentifiers, SectionIdentifierType toSectionIdentifier)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			if (sectionIdentifiers is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (sectionIdentifiers));
			var toSectionIdentifier__handle__ = toSectionIdentifier!.GetNonNullHandle (nameof (toSectionIdentifier));
			using var nsa_sectionIdentifiers = NSArray.FromNSObjects (sectionIdentifiers);
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (this.Handle, selInsertSectionsWithIdentifiers_AfterSectionWithIdentifier_XHandle, nsa_sectionIdentifiers.Handle, toSectionIdentifier__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, selInsertSectionsWithIdentifiers_AfterSectionWithIdentifier_XHandle, nsa_sectionIdentifiers.Handle, toSectionIdentifier__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (toSectionIdentifier);
		}
		[Export ("insertSectionsWithIdentifiers:beforeSectionWithIdentifier:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void InsertSectionsBefore (SectionIdentifierType[] sectionIdentifiers, SectionIdentifierType toSectionIdentifier)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			if (sectionIdentifiers is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (sectionIdentifiers));
			var toSectionIdentifier__handle__ = toSectionIdentifier!.GetNonNullHandle (nameof (toSectionIdentifier));
			using var nsa_sectionIdentifiers = NSArray.FromNSObjects (sectionIdentifiers);
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (this.Handle, selInsertSectionsWithIdentifiers_BeforeSectionWithIdentifier_XHandle, nsa_sectionIdentifiers.Handle, toSectionIdentifier__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, selInsertSectionsWithIdentifiers_BeforeSectionWithIdentifier_XHandle, nsa_sectionIdentifiers.Handle, toSectionIdentifier__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (toSectionIdentifier);
		}
		[Export ("moveItemWithIdentifier:afterItemWithIdentifier:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void MoveItemAfter (ItemIdentifierType fromIdentifier, ItemIdentifierType toIdentifier)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var fromIdentifier__handle__ = fromIdentifier!.GetNonNullHandle (nameof (fromIdentifier));
			var toIdentifier__handle__ = toIdentifier!.GetNonNullHandle (nameof (toIdentifier));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (this.Handle, selMoveItemWithIdentifier_AfterItemWithIdentifier_XHandle, fromIdentifier__handle__, toIdentifier__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, selMoveItemWithIdentifier_AfterItemWithIdentifier_XHandle, fromIdentifier__handle__, toIdentifier__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (fromIdentifier);
			GC.KeepAlive (toIdentifier);
		}
		[Export ("moveItemWithIdentifier:beforeItemWithIdentifier:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void MoveItemBefore (ItemIdentifierType fromIdentifier, ItemIdentifierType toIdentifier)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var fromIdentifier__handle__ = fromIdentifier!.GetNonNullHandle (nameof (fromIdentifier));
			var toIdentifier__handle__ = toIdentifier!.GetNonNullHandle (nameof (toIdentifier));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (this.Handle, selMoveItemWithIdentifier_BeforeItemWithIdentifier_XHandle, fromIdentifier__handle__, toIdentifier__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, selMoveItemWithIdentifier_BeforeItemWithIdentifier_XHandle, fromIdentifier__handle__, toIdentifier__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (fromIdentifier);
			GC.KeepAlive (toIdentifier);
		}
		[Export ("moveSectionWithIdentifier:afterSectionWithIdentifier:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void MoveSectionAfter (SectionIdentifierType fromSectionIdentifier, SectionIdentifierType toSectionIdentifier)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var fromSectionIdentifier__handle__ = fromSectionIdentifier!.GetNonNullHandle (nameof (fromSectionIdentifier));
			var toSectionIdentifier__handle__ = toSectionIdentifier!.GetNonNullHandle (nameof (toSectionIdentifier));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (this.Handle, selMoveSectionWithIdentifier_AfterSectionWithIdentifier_XHandle, fromSectionIdentifier__handle__, toSectionIdentifier__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, selMoveSectionWithIdentifier_AfterSectionWithIdentifier_XHandle, fromSectionIdentifier__handle__, toSectionIdentifier__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (fromSectionIdentifier);
			GC.KeepAlive (toSectionIdentifier);
		}
		[Export ("moveSectionWithIdentifier:beforeSectionWithIdentifier:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void MoveSectionBefore (SectionIdentifierType fromSectionIdentifier, SectionIdentifierType toSectionIdentifier)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var fromSectionIdentifier__handle__ = fromSectionIdentifier!.GetNonNullHandle (nameof (fromSectionIdentifier));
			var toSectionIdentifier__handle__ = toSectionIdentifier!.GetNonNullHandle (nameof (toSectionIdentifier));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (this.Handle, selMoveSectionWithIdentifier_BeforeSectionWithIdentifier_XHandle, fromSectionIdentifier__handle__, toSectionIdentifier__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, selMoveSectionWithIdentifier_BeforeSectionWithIdentifier_XHandle, fromSectionIdentifier__handle__, toSectionIdentifier__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (fromSectionIdentifier);
			GC.KeepAlive (toSectionIdentifier);
		}
		[Export ("reconfigureItemsWithIdentifiers:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("ios")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void ReconfigureItems (ItemIdentifierType[] identifiers)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			if (identifiers is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (identifiers));
			using var nsa_identifiers = NSArray.FromNSObjects (identifiers);
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selReconfigureItemsWithIdentifiers_XHandle, nsa_identifiers.Handle);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selReconfigureItemsWithIdentifiers_XHandle, nsa_identifiers.Handle);
					GC.KeepAlive (this);
				}
			}
		}
		[Export ("reloadItemsWithIdentifiers:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void ReloadItems (ItemIdentifierType[] identifiers)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			if (identifiers is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (identifiers));
			using var nsa_identifiers = NSArray.FromNSObjects (identifiers);
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selReloadItemsWithIdentifiers_XHandle, nsa_identifiers.Handle);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selReloadItemsWithIdentifiers_XHandle, nsa_identifiers.Handle);
					GC.KeepAlive (this);
				}
			}
		}
		[Export ("reloadSectionsWithIdentifiers:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void ReloadSections (SectionIdentifierType[] sectionIdentifiers)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			if (sectionIdentifiers is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (sectionIdentifiers));
			using var nsa_sectionIdentifiers = NSArray.FromNSObjects (sectionIdentifiers);
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selReloadSectionsWithIdentifiers_XHandle, nsa_sectionIdentifiers.Handle);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selReloadSectionsWithIdentifiers_XHandle, nsa_sectionIdentifiers.Handle);
					GC.KeepAlive (this);
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual ItemIdentifierType[] ItemIdentifiers {
			[Export ("itemIdentifiers")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				ItemIdentifierType[]? ret;
				if (IsDirectBinding) {
					ret = CFArray.ArrayFromHandle<ItemIdentifierType>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selItemIdentifiersXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFArray.ArrayFromHandle<ItemIdentifierType>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selItemIdentifiersXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual nint NumberOfItems {
			[Export ("numberOfItems")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				nint ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selNumberOfItemsXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (&__objc_super__, selNumberOfItemsXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual nint NumberOfSections {
			[Export ("numberOfSections")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				nint ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selNumberOfSectionsXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (&__objc_super__, selNumberOfSectionsXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("ios")]
		public virtual ItemIdentifierType[] ReconfiguredItemIdentifiers {
			[Export ("reconfiguredItemIdentifiers")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				ItemIdentifierType[]? ret;
				if (IsDirectBinding) {
					ret = CFArray.ArrayFromHandle<ItemIdentifierType>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selReconfiguredItemIdentifiersXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFArray.ArrayFromHandle<ItemIdentifierType>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selReconfiguredItemIdentifiersXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("ios")]
		public virtual ItemIdentifierType[] ReloadedItemIdentifiers {
			[Export ("reloadedItemIdentifiers")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				ItemIdentifierType[]? ret;
				if (IsDirectBinding) {
					ret = CFArray.ArrayFromHandle<ItemIdentifierType>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selReloadedItemIdentifiersXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFArray.ArrayFromHandle<ItemIdentifierType>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selReloadedItemIdentifiersXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("ios")]
		public virtual SectionIdentifierType[] ReloadedSectionIdentifiers {
			[Export ("reloadedSectionIdentifiers")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				SectionIdentifierType[]? ret;
				if (IsDirectBinding) {
					ret = CFArray.ArrayFromHandle<SectionIdentifierType>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selReloadedSectionIdentifiersXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFArray.ArrayFromHandle<SectionIdentifierType>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selReloadedSectionIdentifiersXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual SectionIdentifierType[] SectionIdentifiers {
			[Export ("sectionIdentifiers")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				SectionIdentifierType[]? ret;
				if (IsDirectBinding) {
					ret = CFArray.ArrayFromHandle<SectionIdentifierType>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selSectionIdentifiersXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFArray.ArrayFromHandle<SectionIdentifierType>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selSectionIdentifiersXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
	} /* class NSDiffableDataSourceSnapshot */
}
