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
namespace Contacts {
	/// <summary>A request that performs a save operation for contacts.</summary><related type="externalDocumentation" href="https://developer.apple.com/library/ios/documentation/Contacts/Reference/CNSaveRequest_Class/index.html">Apple documentation for <c>CNSaveRequest</c></related>
	[Register("CNSaveRequest", true)]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	public unsafe partial class CNSaveRequest : NSObject {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAddContact_ToContainerWithIdentifier_X = "addContact:toContainerWithIdentifier:";
		static readonly NativeHandle selAddContact_ToContainerWithIdentifier_XHandle = Selector.GetHandle ("addContact:toContainerWithIdentifier:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAddGroup_ToContainerWithIdentifier_X = "addGroup:toContainerWithIdentifier:";
		static readonly NativeHandle selAddGroup_ToContainerWithIdentifier_XHandle = Selector.GetHandle ("addGroup:toContainerWithIdentifier:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAddMember_ToGroup_X = "addMember:toGroup:";
		static readonly NativeHandle selAddMember_ToGroup_XHandle = Selector.GetHandle ("addMember:toGroup:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAddSubgroup_ToGroup_X = "addSubgroup:toGroup:";
		static readonly NativeHandle selAddSubgroup_ToGroup_XHandle = Selector.GetHandle ("addSubgroup:toGroup:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selDeleteContact_X = "deleteContact:";
		static readonly NativeHandle selDeleteContact_XHandle = Selector.GetHandle ("deleteContact:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selDeleteGroup_X = "deleteGroup:";
		static readonly NativeHandle selDeleteGroup_XHandle = Selector.GetHandle ("deleteGroup:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selRemoveMember_FromGroup_X = "removeMember:fromGroup:";
		static readonly NativeHandle selRemoveMember_FromGroup_XHandle = Selector.GetHandle ("removeMember:fromGroup:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selRemoveSubgroup_FromGroup_X = "removeSubgroup:fromGroup:";
		static readonly NativeHandle selRemoveSubgroup_FromGroup_XHandle = Selector.GetHandle ("removeSubgroup:fromGroup:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetShouldRefetchContacts_X = "setShouldRefetchContacts:";
		static readonly NativeHandle selSetShouldRefetchContacts_XHandle = Selector.GetHandle ("setShouldRefetchContacts:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetTransactionAuthor_X = "setTransactionAuthor:";
		static readonly NativeHandle selSetTransactionAuthor_XHandle = Selector.GetHandle ("setTransactionAuthor:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selShouldRefetchContactsX = "shouldRefetchContacts";
		static readonly NativeHandle selShouldRefetchContactsXHandle = Selector.GetHandle ("shouldRefetchContacts");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selTransactionAuthorX = "transactionAuthor";
		static readonly NativeHandle selTransactionAuthorXHandle = Selector.GetHandle ("transactionAuthor");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selUpdateContact_X = "updateContact:";
		static readonly NativeHandle selUpdateContact_XHandle = Selector.GetHandle ("updateContact:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selUpdateGroup_X = "updateGroup:";
		static readonly NativeHandle selUpdateGroup_XHandle = Selector.GetHandle ("updateGroup:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly NativeHandle class_ptr = Class.GetHandle ("CNSaveRequest");
		/// <summary>The Objective-C class handle for this class.</summary>
		/// <value>The pointer to the Objective-C class.</value>
		/// <remarks>
		///     Each managed class mirrors an unmanaged Objective-C class.
		///     This value contains the pointer to the Objective-C class.
		///     It is similar to calling the managed <see cref="ObjCRuntime.Class.GetHandle(string)" /> or the native <see href="https://developer.apple.com/documentation/objectivec/1418952-objc_getclass">objc_getClass</see> method with the type name.
		/// </remarks>
		public override NativeHandle ClassHandle { get { return class_ptr; } }
		/// <summary>Creates a new <see cref="CNSaveRequest" /> with default values.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public CNSaveRequest () : base (NSObjectFlag.Empty)
		{
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
		protected CNSaveRequest (NSObjectFlag t) : base (t)
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
		protected internal CNSaveRequest (NativeHandle handle) : base (handle)
		{
		}

		[Export ("addContact:toContainerWithIdentifier:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void AddContact (CNMutableContact contact, string? identifier)
		{
			var contact__handle__ = contact!.GetNonNullHandle (nameof (contact));
			var nsidentifier = CFString.CreateNative (identifier);
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (this.Handle, selAddContact_ToContainerWithIdentifier_XHandle, contact__handle__, nsidentifier);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, selAddContact_ToContainerWithIdentifier_XHandle, contact__handle__, nsidentifier);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (contact);
			CFString.ReleaseNative (nsidentifier);
		}
		[Export ("addGroup:toContainerWithIdentifier:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void AddGroup (CNMutableGroup group, string? identifier)
		{
			var group__handle__ = group!.GetNonNullHandle (nameof (group));
			var nsidentifier = CFString.CreateNative (identifier);
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (this.Handle, selAddGroup_ToContainerWithIdentifier_XHandle, group__handle__, nsidentifier);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, selAddGroup_ToContainerWithIdentifier_XHandle, group__handle__, nsidentifier);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (group);
			CFString.ReleaseNative (nsidentifier);
		}
		[Export ("addMember:toGroup:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void AddMember (CNContact contact, CNGroup group)
		{
			var contact__handle__ = contact!.GetNonNullHandle (nameof (contact));
			var group__handle__ = group!.GetNonNullHandle (nameof (group));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (this.Handle, selAddMember_ToGroup_XHandle, contact__handle__, group__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, selAddMember_ToGroup_XHandle, contact__handle__, group__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (contact);
			GC.KeepAlive (group);
		}
		[Export ("addSubgroup:toGroup:")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void AddSubgroup (CNGroup subgroup, CNGroup group)
		{
			var subgroup__handle__ = subgroup!.GetNonNullHandle (nameof (subgroup));
			var group__handle__ = group!.GetNonNullHandle (nameof (group));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (this.Handle, selAddSubgroup_ToGroup_XHandle, subgroup__handle__, group__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, selAddSubgroup_ToGroup_XHandle, subgroup__handle__, group__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (subgroup);
			GC.KeepAlive (group);
		}
		[Export ("deleteContact:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DeleteContact (CNMutableContact contact)
		{
			var contact__handle__ = contact!.GetNonNullHandle (nameof (contact));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selDeleteContact_XHandle, contact__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selDeleteContact_XHandle, contact__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (contact);
		}
		[Export ("deleteGroup:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DeleteGroup (CNMutableGroup group)
		{
			var group__handle__ = group!.GetNonNullHandle (nameof (group));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selDeleteGroup_XHandle, group__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selDeleteGroup_XHandle, group__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (group);
		}
		[Export ("removeMember:fromGroup:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void RemoveMember (CNContact contact, CNGroup group)
		{
			var contact__handle__ = contact!.GetNonNullHandle (nameof (contact));
			var group__handle__ = group!.GetNonNullHandle (nameof (group));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (this.Handle, selRemoveMember_FromGroup_XHandle, contact__handle__, group__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, selRemoveMember_FromGroup_XHandle, contact__handle__, group__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (contact);
			GC.KeepAlive (group);
		}
		[Export ("removeSubgroup:fromGroup:")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void RemoveSubgroup (CNGroup subgroup, CNGroup group)
		{
			var subgroup__handle__ = subgroup!.GetNonNullHandle (nameof (subgroup));
			var group__handle__ = group!.GetNonNullHandle (nameof (group));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (this.Handle, selRemoveSubgroup_FromGroup_XHandle, subgroup__handle__, group__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, selRemoveSubgroup_FromGroup_XHandle, subgroup__handle__, group__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (subgroup);
			GC.KeepAlive (group);
		}
		[Export ("updateContact:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void UpdateContact (CNMutableContact contact)
		{
			var contact__handle__ = contact!.GetNonNullHandle (nameof (contact));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selUpdateContact_XHandle, contact__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selUpdateContact_XHandle, contact__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (contact);
		}
		[Export ("updateGroup:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void UpdateGroup (CNMutableGroup group)
		{
			var group__handle__ = group!.GetNonNullHandle (nameof (group));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selUpdateGroup_XHandle, group__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selUpdateGroup_XHandle, group__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (group);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("macos12.3")]
		[SupportedOSPlatform ("ios15.4")]
		[SupportedOSPlatform ("maccatalyst15.4")]
		public virtual bool ShouldRefetchContacts {
			[Export ("shouldRefetchContacts")]
			get {
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selShouldRefetchContactsXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, selShouldRefetchContactsXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
			[Export ("setShouldRefetchContacts:")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, selSetShouldRefetchContacts_XHandle, value ? (byte) 1 : (byte) 0);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (&__objc_super__, selSetShouldRefetchContacts_XHandle, value ? (byte) 1 : (byte) 0);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("ios15.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public virtual string? TransactionAuthor {
			[Export ("transactionAuthor")]
			get {
				string ret;
				if (IsDirectBinding) {
					ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selTransactionAuthorXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selTransactionAuthorXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[Export ("setTransactionAuthor:")]
			set {
				var nsvalue = CFString.CreateNative (value);
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selSetTransactionAuthor_XHandle, nsvalue);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selSetTransactionAuthor_XHandle, nsvalue);
						GC.KeepAlive (this);
					}
				}
				CFString.ReleaseNative (nsvalue);
			}
		}
	} /* class CNSaveRequest */
}
