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
namespace Intents {
	/// <summary>An <see cref="T:Intents.INIntent" /> indicating the user wishes to search their message history.</summary><related type="externalDocumentation" href="https://developer.apple.com/reference/Intents/INSearchForMessagesIntent">Apple documentation for <c>INSearchForMessagesIntent</c></related>
	[Register("INSearchForMessagesIntent", true)]
	[UnsupportedOSPlatform ("macos")]
	[UnsupportedOSPlatform ("tvos")]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	public unsafe partial class INSearchForMessagesIntent : INIntent {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly NativeHandle class_ptr = Class.GetHandle ("INSearchForMessagesIntent");
		/// <summary>The Objective-C class handle for this class.</summary>
		/// <value>The pointer to the Objective-C class.</value>
		/// <remarks>
		///     Each managed class mirrors an unmanaged Objective-C class.
		///     This value contains the pointer to the Objective-C class.
		///     It is similar to calling the managed <see cref="ObjCRuntime.Class.GetHandle(string)" /> or the native <see href="https://developer.apple.com/documentation/objectivec/1418952-objc_getclass">objc_getClass</see> method with the type name.
		/// </remarks>
		public override NativeHandle ClassHandle { get { return class_ptr; } }
		/// <summary>Creates a new <see cref="INSearchForMessagesIntent" /> with default values.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public INSearchForMessagesIntent () : base (NSObjectFlag.Empty)
		{
			if (IsDirectBinding) {
				InitializeHandle (global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, global::ObjCRuntime.Selector.GetHandle ("init")), "init");
			} else {
				unsafe {
				var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
				InitializeHandle (global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (&__objc_super__, global::ObjCRuntime.Selector.GetHandle ("init")), "init");
				GC.KeepAlive (this);
				}
			}
		}

		/// <summary>A constructor that initializes the object from the data stored in the unarchiver object.</summary>
		/// <param name="coder">The unarchiver object.</param>
		/// <remarks>
		///   <para>This constructor is provided to allow the class to be initialized from an unarchiver (for example, during NIB deserialization). This is part of the <see cref="Foundation.NSCoding" /> protocol.</para>
		///   <para>If developers want to create a subclass of this object and continue to support deserialization from an archive, they should implement a constructor with an identical signature: taking a single parameter of type <see cref="Foundation.NSCoder" /> and decorate it with the <c>[Export("initWithCoder:"]</c> attribute.</para>
		///   <para>The state of this object can also be serialized by using the <see cref="Foundation.INSCoding.EncodeTo" /> companion method.</para>
		/// </remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[DesignatedInitializer]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("initWithCoder:")]
		public INSearchForMessagesIntent (NSCoder coder) : base (NSObjectFlag.Empty)
		{
			if (IsDirectBinding) {
				InitializeHandle (global::ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("initWithCoder:"), coder.Handle), "initWithCoder:");
			} else {
				unsafe {
				var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
				InitializeHandle (global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper_IntPtr (&__objc_super__, Selector.GetHandle ("initWithCoder:"), coder.Handle), "initWithCoder:");
				GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (coder);
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
		protected INSearchForMessagesIntent (NSObjectFlag t) : base (t)
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
		protected internal INSearchForMessagesIntent (NativeHandle handle) : base (handle)
		{
		}

		[Export ("initWithRecipients:senders:searchTerms:attributes:dateTimeRange:identifiers:notificationIdentifiers:speakableGroupNames:")]
		[ObsoletedOSPlatform ("macos10.14", "Use the overload that takes 'conversationIdentifiers' instead.")]
		[ObsoletedOSPlatform ("ios12.0", "Use the overload that takes 'conversationIdentifiers' instead.")]
		[SupportedOSPlatform ("maccatalyst")]
		[ObsoletedOSPlatform ("maccatalyst13.1", "Use the overload that takes 'conversationIdentifiers' instead.")]
		[UnsupportedOSPlatform ("macos")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public INSearchForMessagesIntent (INPerson[]? recipients, INPerson[]? senders, string[]? searchTerms, INMessageAttributeOptions attributes, INDateComponentsRange? dateTimeRange, string[]? identifiers, string[]? notificationIdentifiers, INSpeakableString[]? speakableGroupNames)
			: base (NSObjectFlag.Empty)
		{
			var dateTimeRange__handle__ = dateTimeRange.GetHandle ();
			using var nsa_recipients = recipients is null ? null : NSArray.FromNSObjects (recipients);
			using var nsa_senders = senders is null ? null : NSArray.FromNSObjects (senders);
			using var nsa_searchTerms = NSArray.FromNullableStrings (searchTerms);
			using var nsa_identifiers = NSArray.FromNullableStrings (identifiers);
			using var nsa_notificationIdentifiers = NSArray.FromNullableStrings (notificationIdentifiers);
			using var nsa_speakableGroupNames = speakableGroupNames is null ? null : NSArray.FromNSObjects (speakableGroupNames);
			if (IsDirectBinding) {
				InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle_UIntPtr_NativeHandle_NativeHandle_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("initWithRecipients:senders:searchTerms:attributes:dateTimeRange:identifiers:notificationIdentifiers:speakableGroupNames:"), nsa_recipients.GetHandle (), nsa_senders.GetHandle (), nsa_searchTerms.GetHandle (), (UIntPtr) (ulong) attributes, dateTimeRange__handle__, nsa_identifiers.GetHandle (), nsa_notificationIdentifiers.GetHandle (), nsa_speakableGroupNames.GetHandle ()), "initWithRecipients:senders:searchTerms:attributes:dateTimeRange:identifiers:notificationIdentifiers:speakableGroupNames:");
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_NativeHandle_NativeHandle_UIntPtr_NativeHandle_NativeHandle_NativeHandle_NativeHandle (&__objc_super__, Selector.GetHandle ("initWithRecipients:senders:searchTerms:attributes:dateTimeRange:identifiers:notificationIdentifiers:speakableGroupNames:"), nsa_recipients.GetHandle (), nsa_senders.GetHandle (), nsa_searchTerms.GetHandle (), (UIntPtr) (ulong) attributes, dateTimeRange__handle__, nsa_identifiers.GetHandle (), nsa_notificationIdentifiers.GetHandle (), nsa_speakableGroupNames.GetHandle ()), "initWithRecipients:senders:searchTerms:attributes:dateTimeRange:identifiers:notificationIdentifiers:speakableGroupNames:");
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (dateTimeRange);
		}
		[Export ("initWithRecipients:senders:searchTerms:attributes:dateTimeRange:identifiers:notificationIdentifiers:speakableGroupNames:conversationIdentifiers:")]
		[SupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("macos")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios")]
		[DesignatedInitializer]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public INSearchForMessagesIntent (INPerson[]? recipients, INPerson[]? senders, string[]? searchTerms, INMessageAttributeOptions attributes, INDateComponentsRange? dateTimeRange, string[]? identifiers, string[]? notificationIdentifiers, INSpeakableString[]? speakableGroupNames, string[]? conversationIdentifiers)
			: base (NSObjectFlag.Empty)
		{
			var dateTimeRange__handle__ = dateTimeRange.GetHandle ();
			using var nsa_recipients = recipients is null ? null : NSArray.FromNSObjects (recipients);
			using var nsa_senders = senders is null ? null : NSArray.FromNSObjects (senders);
			using var nsa_searchTerms = NSArray.FromNullableStrings (searchTerms);
			using var nsa_identifiers = NSArray.FromNullableStrings (identifiers);
			using var nsa_notificationIdentifiers = NSArray.FromNullableStrings (notificationIdentifiers);
			using var nsa_speakableGroupNames = speakableGroupNames is null ? null : NSArray.FromNSObjects (speakableGroupNames);
			using var nsa_conversationIdentifiers = NSArray.FromNullableStrings (conversationIdentifiers);
			if (IsDirectBinding) {
				InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle_UIntPtr_NativeHandle_NativeHandle_NativeHandle_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("initWithRecipients:senders:searchTerms:attributes:dateTimeRange:identifiers:notificationIdentifiers:speakableGroupNames:conversationIdentifiers:"), nsa_recipients.GetHandle (), nsa_senders.GetHandle (), nsa_searchTerms.GetHandle (), (UIntPtr) (ulong) attributes, dateTimeRange__handle__, nsa_identifiers.GetHandle (), nsa_notificationIdentifiers.GetHandle (), nsa_speakableGroupNames.GetHandle (), nsa_conversationIdentifiers.GetHandle ()), "initWithRecipients:senders:searchTerms:attributes:dateTimeRange:identifiers:notificationIdentifiers:speakableGroupNames:conversationIdentifiers:");
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_NativeHandle_NativeHandle_UIntPtr_NativeHandle_NativeHandle_NativeHandle_NativeHandle_NativeHandle (&__objc_super__, Selector.GetHandle ("initWithRecipients:senders:searchTerms:attributes:dateTimeRange:identifiers:notificationIdentifiers:speakableGroupNames:conversationIdentifiers:"), nsa_recipients.GetHandle (), nsa_senders.GetHandle (), nsa_searchTerms.GetHandle (), (UIntPtr) (ulong) attributes, dateTimeRange__handle__, nsa_identifiers.GetHandle (), nsa_notificationIdentifiers.GetHandle (), nsa_speakableGroupNames.GetHandle (), nsa_conversationIdentifiers.GetHandle ()), "initWithRecipients:senders:searchTerms:attributes:dateTimeRange:identifiers:notificationIdentifiers:speakableGroupNames:conversationIdentifiers:");
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (dateTimeRange);
		}
		[Export ("initWithRecipients:senders:searchTerms:attributes:dateTimeRange:identifiers:notificationIdentifiers:groupNames:")]
		[ObsoletedOSPlatform ("macos10.13", "Use '.ctor (INPerson [], INPerson [], string [], INMessageAttributeOptions, INDateComponentsRange, string [], string [], INSpeakableString [])' instead.")]
		[ObsoletedOSPlatform ("ios11.0", "Use '.ctor (INPerson [], INPerson [], string [], INMessageAttributeOptions, INDateComponentsRange, string [], string [], INSpeakableString [])' instead.")]
		[ObsoletedOSPlatform ("maccatalyst13.1", "Use '.ctor (INPerson [], INPerson [], string [], INMessageAttributeOptions, INDateComponentsRange, string [], string [], INSpeakableString [])' instead.")]
		[UnsupportedOSPlatform ("macos")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public INSearchForMessagesIntent (INPerson[]? recipients, INPerson[]? senders, string[]? searchTerms, INMessageAttributeOptions attributes, INDateComponentsRange? dateTimeRange, string[]? identifiers, string[]? notificationIdentifiers, string[]? groupNames)
			: base (NSObjectFlag.Empty)
		{
			var dateTimeRange__handle__ = dateTimeRange.GetHandle ();
			using var nsa_recipients = recipients is null ? null : NSArray.FromNSObjects (recipients);
			using var nsa_senders = senders is null ? null : NSArray.FromNSObjects (senders);
			using var nsa_searchTerms = NSArray.FromNullableStrings (searchTerms);
			using var nsa_identifiers = NSArray.FromNullableStrings (identifiers);
			using var nsa_notificationIdentifiers = NSArray.FromNullableStrings (notificationIdentifiers);
			using var nsa_groupNames = NSArray.FromNullableStrings (groupNames);
			if (IsDirectBinding) {
				InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle_UIntPtr_NativeHandle_NativeHandle_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("initWithRecipients:senders:searchTerms:attributes:dateTimeRange:identifiers:notificationIdentifiers:groupNames:"), nsa_recipients.GetHandle (), nsa_senders.GetHandle (), nsa_searchTerms.GetHandle (), (UIntPtr) (ulong) attributes, dateTimeRange__handle__, nsa_identifiers.GetHandle (), nsa_notificationIdentifiers.GetHandle (), nsa_groupNames.GetHandle ()), "initWithRecipients:senders:searchTerms:attributes:dateTimeRange:identifiers:notificationIdentifiers:groupNames:");
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_NativeHandle_NativeHandle_UIntPtr_NativeHandle_NativeHandle_NativeHandle_NativeHandle (&__objc_super__, Selector.GetHandle ("initWithRecipients:senders:searchTerms:attributes:dateTimeRange:identifiers:notificationIdentifiers:groupNames:"), nsa_recipients.GetHandle (), nsa_senders.GetHandle (), nsa_searchTerms.GetHandle (), (UIntPtr) (ulong) attributes, dateTimeRange__handle__, nsa_identifiers.GetHandle (), nsa_notificationIdentifiers.GetHandle (), nsa_groupNames.GetHandle ()), "initWithRecipients:senders:searchTerms:attributes:dateTimeRange:identifiers:notificationIdentifiers:groupNames:");
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (dateTimeRange);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual INMessageAttributeOptions Attributes {
			[Export ("attributes", ArgumentSemantic.Assign)]
			get {
				INMessageAttributeOptions ret;
				if (IsDirectBinding) {
					ret = (Intents.INMessageAttributeOptions) (ulong) global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("attributes"));
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = (Intents.INMessageAttributeOptions) (ulong) global::ObjCRuntime.Messaging.UIntPtr_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("attributes"));
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("macos")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios")]
		public virtual string[]? ConversationIdentifiers {
			[Export ("conversationIdentifiers", ArgumentSemantic.Copy)]
			get {
				string[] ret;
				if (IsDirectBinding) {
					ret = CFArray.StringArrayFromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("conversationIdentifiers")), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFArray.StringArrayFromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("conversationIdentifiers")), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("macos")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios")]
		public virtual INConditionalOperator ConversationIdentifiersOperator {
			[Export ("conversationIdentifiersOperator", ArgumentSemantic.Assign)]
			get {
				INConditionalOperator ret;
				if (IsDirectBinding) {
					ret = (Intents.INConditionalOperator) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("conversationIdentifiersOperator"));
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = (Intents.INConditionalOperator) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("conversationIdentifiersOperator"));
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual INDateComponentsRange? DateTimeRange {
			[Export ("dateTimeRange", ArgumentSemantic.Copy)]
			get {
				INDateComponentsRange? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<INDateComponentsRange> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("dateTimeRange")), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<INDateComponentsRange> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("dateTimeRange")), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[ObsoletedOSPlatform ("macos10.13", "Use 'SpeakableGroupNames' instead.")]
		[ObsoletedOSPlatform ("ios11.0", "Use 'SpeakableGroupNames' instead.")]
		[ObsoletedOSPlatform ("maccatalyst13.1", "Use 'SpeakableGroupNames' instead.")]
		[UnsupportedOSPlatform ("macos")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("maccatalyst")]
		public virtual string[]? GroupNames {
			[Export ("groupNames", ArgumentSemantic.Copy)]
			get {
				string[] ret;
				if (IsDirectBinding) {
					ret = CFArray.StringArrayFromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("groupNames")), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFArray.StringArrayFromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("groupNames")), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[ObsoletedOSPlatform ("macos10.13", "Use 'SpeakableGroupNamesOperator' instead.")]
		[ObsoletedOSPlatform ("ios11.0", "Use 'SpeakableGroupNamesOperator' instead.")]
		[ObsoletedOSPlatform ("maccatalyst13.1", "Use 'SpeakableGroupNamesOperator' instead.")]
		[UnsupportedOSPlatform ("macos")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("maccatalyst")]
		public virtual INConditionalOperator GroupNamesOperator {
			[Export ("groupNamesOperator", ArgumentSemantic.Assign)]
			get {
				INConditionalOperator ret;
				if (IsDirectBinding) {
					ret = (Intents.INConditionalOperator) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("groupNamesOperator"));
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = (Intents.INConditionalOperator) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("groupNamesOperator"));
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string[]? Identifiers {
			[Export ("identifiers", ArgumentSemantic.Copy)]
			get {
				string[] ret;
				if (IsDirectBinding) {
					ret = CFArray.StringArrayFromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("identifiers")), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFArray.StringArrayFromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("identifiers")), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual INConditionalOperator IdentifiersOperator {
			[Export ("identifiersOperator", ArgumentSemantic.Assign)]
			get {
				INConditionalOperator ret;
				if (IsDirectBinding) {
					ret = (Intents.INConditionalOperator) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("identifiersOperator"));
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = (Intents.INConditionalOperator) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("identifiersOperator"));
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string[]? NotificationIdentifiers {
			[Export ("notificationIdentifiers", ArgumentSemantic.Copy)]
			get {
				string[] ret;
				if (IsDirectBinding) {
					ret = CFArray.StringArrayFromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("notificationIdentifiers")), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFArray.StringArrayFromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("notificationIdentifiers")), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual INConditionalOperator NotificationIdentifiersOperator {
			[Export ("notificationIdentifiersOperator", ArgumentSemantic.Assign)]
			get {
				INConditionalOperator ret;
				if (IsDirectBinding) {
					ret = (Intents.INConditionalOperator) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("notificationIdentifiersOperator"));
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = (Intents.INConditionalOperator) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("notificationIdentifiersOperator"));
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual INPerson[]? Recipients {
			[Export ("recipients", ArgumentSemantic.Copy)]
			get {
				INPerson[]? ret;
				if (IsDirectBinding) {
					ret = CFArray.ArrayFromHandle<INPerson>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("recipients")), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFArray.ArrayFromHandle<INPerson>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("recipients")), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual INConditionalOperator RecipientsOperator {
			[Export ("recipientsOperator", ArgumentSemantic.Assign)]
			get {
				INConditionalOperator ret;
				if (IsDirectBinding) {
					ret = (Intents.INConditionalOperator) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("recipientsOperator"));
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = (Intents.INConditionalOperator) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("recipientsOperator"));
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string[]? SearchTerms {
			[Export ("searchTerms", ArgumentSemantic.Copy)]
			get {
				string[] ret;
				if (IsDirectBinding) {
					ret = CFArray.StringArrayFromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("searchTerms")), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFArray.StringArrayFromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("searchTerms")), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual INConditionalOperator SearchTermsOperator {
			[Export ("searchTermsOperator", ArgumentSemantic.Assign)]
			get {
				INConditionalOperator ret;
				if (IsDirectBinding) {
					ret = (Intents.INConditionalOperator) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("searchTermsOperator"));
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = (Intents.INConditionalOperator) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("searchTermsOperator"));
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual INPerson[]? Senders {
			[Export ("senders", ArgumentSemantic.Copy)]
			get {
				INPerson[]? ret;
				if (IsDirectBinding) {
					ret = CFArray.ArrayFromHandle<INPerson>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("senders")), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFArray.ArrayFromHandle<INPerson>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("senders")), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual INConditionalOperator SendersOperator {
			[Export ("sendersOperator", ArgumentSemantic.Assign)]
			get {
				INConditionalOperator ret;
				if (IsDirectBinding) {
					ret = (Intents.INConditionalOperator) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("sendersOperator"));
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = (Intents.INConditionalOperator) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("sendersOperator"));
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("macos")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios")]
		public virtual INSpeakableString[]? SpeakableGroupNames {
			[Export ("speakableGroupNames", ArgumentSemantic.Copy)]
			get {
				INSpeakableString[]? ret;
				if (IsDirectBinding) {
					ret = CFArray.ArrayFromHandle<INSpeakableString>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("speakableGroupNames")), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFArray.ArrayFromHandle<INSpeakableString>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("speakableGroupNames")), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("macos")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios")]
		public virtual INConditionalOperator SpeakableGroupNamesOperator {
			[Export ("speakableGroupNamesOperator", ArgumentSemantic.Assign)]
			get {
				INConditionalOperator ret;
				if (IsDirectBinding) {
					ret = (Intents.INConditionalOperator) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("speakableGroupNamesOperator"));
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = (Intents.INConditionalOperator) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("speakableGroupNamesOperator"));
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
	} /* class INSearchForMessagesIntent */
}
