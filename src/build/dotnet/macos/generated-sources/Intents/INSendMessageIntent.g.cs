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
namespace Intents {
	/// <summary>An <see cref="T:Intents.INIntent" /> indicating the user wishes to send a message.</summary><related type="externalDocumentation" href="https://developer.apple.com/reference/Intents/INSendMessageIntent">Apple documentation for <c>INSendMessageIntent</c></related>
	[Register("INSendMessageIntent", true)]
	[UnsupportedOSPlatform ("tvos")]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	public unsafe partial class INSendMessageIntent : INIntent, global::UserNotifications.IUNNotificationContentProviding {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAttachmentsX = "attachments";
		static readonly NativeHandle selAttachmentsXHandle = Selector.GetHandle ("attachments");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selContentX = "content";
		static readonly NativeHandle selContentXHandle = Selector.GetHandle ("content");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selConversationIdentifierX = "conversationIdentifier";
		static readonly NativeHandle selConversationIdentifierXHandle = Selector.GetHandle ("conversationIdentifier");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selGroupNameX = "groupName";
		static readonly NativeHandle selGroupNameXHandle = Selector.GetHandle ("groupName");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selInitWithRecipients_Content_GroupName_ServiceName_Sender_X = "initWithRecipients:content:groupName:serviceName:sender:";
		static readonly NativeHandle selInitWithRecipients_Content_GroupName_ServiceName_Sender_XHandle = Selector.GetHandle ("initWithRecipients:content:groupName:serviceName:sender:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selInitWithRecipients_Content_SpeakableGroupName_ConversationIdentifier_ServiceName_Sender_X = "initWithRecipients:content:speakableGroupName:conversationIdentifier:serviceName:sender:";
		static readonly NativeHandle selInitWithRecipients_Content_SpeakableGroupName_ConversationIdentifier_ServiceName_Sender_XHandle = Selector.GetHandle ("initWithRecipients:content:speakableGroupName:conversationIdentifier:serviceName:sender:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selInitWithRecipients_OutgoingMessageType_Content_SpeakableGroupName_ConversationIdentifier_ServiceName_Sender_Attachments_X = "initWithRecipients:outgoingMessageType:content:speakableGroupName:conversationIdentifier:serviceName:sender:attachments:";
		static readonly NativeHandle selInitWithRecipients_OutgoingMessageType_Content_SpeakableGroupName_ConversationIdentifier_ServiceName_Sender_Attachments_XHandle = Selector.GetHandle ("initWithRecipients:outgoingMessageType:content:speakableGroupName:conversationIdentifier:serviceName:sender:attachments:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selOutgoingMessageTypeX = "outgoingMessageType";
		static readonly NativeHandle selOutgoingMessageTypeXHandle = Selector.GetHandle ("outgoingMessageType");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selRecipientsX = "recipients";
		static readonly NativeHandle selRecipientsXHandle = Selector.GetHandle ("recipients");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSenderX = "sender";
		static readonly NativeHandle selSenderXHandle = Selector.GetHandle ("sender");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selServiceNameX = "serviceName";
		static readonly NativeHandle selServiceNameXHandle = Selector.GetHandle ("serviceName");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSpeakableGroupNameX = "speakableGroupName";
		static readonly NativeHandle selSpeakableGroupNameXHandle = Selector.GetHandle ("speakableGroupName");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly NativeHandle class_ptr = Class.GetHandle ("INSendMessageIntent");
		/// <summary>The Objective-C class handle for this class.</summary>
		/// <value>The pointer to the Objective-C class.</value>
		/// <remarks>
		///     Each managed class mirrors an unmanaged Objective-C class.
		///     This value contains the pointer to the Objective-C class.
		///     It is similar to calling the managed <see cref="ObjCRuntime.Class.GetHandle(string)" /> or the native <see href="https://developer.apple.com/documentation/objectivec/1418952-objc_getclass">objc_getClass</see> method with the type name.
		/// </remarks>
		public override NativeHandle ClassHandle { get { return class_ptr; } }
		/// <summary>Creates a new <see cref="INSendMessageIntent" /> with default values.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public INSendMessageIntent () : base (NSObjectFlag.Empty)
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
		public INSendMessageIntent (NSCoder coder) : base (NSObjectFlag.Empty)
		{
			if (IsDirectBinding) {
				InitializeHandle (global::ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr (this.Handle, Selector.InitWithCoder, coder.Handle), "initWithCoder:");
			} else {
				unsafe {
				var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
				InitializeHandle (global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper_IntPtr (&__objc_super__, Selector.InitWithCoder, coder.Handle), "initWithCoder:");
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
		protected INSendMessageIntent (NSObjectFlag t) : base (t)
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
		protected internal INSendMessageIntent (NativeHandle handle) : base (handle)
		{
		}

		[Export ("initWithRecipients:outgoingMessageType:content:speakableGroupName:conversationIdentifier:serviceName:sender:attachments:")]
		[SupportedOSPlatform ("ios14.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("macos")]
		[DesignatedInitializer]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public INSendMessageIntent (INPerson[]? recipients, INOutgoingMessageType outgoingMessageType, string? content, INSpeakableString? speakableGroupName, string? conversationIdentifier, string? serviceName, INPerson? sender, INSendMessageAttachment[]? attachments)
			: base (NSObjectFlag.Empty)
		{
			var speakableGroupName__handle__ = speakableGroupName.GetHandle ();
			var sender__handle__ = sender.GetHandle ();
			using var nsa_recipients = recipients is null ? null : NSArray.FromNSObjects (recipients);
			var nscontent = CFString.CreateNative (content);
			var nsconversationIdentifier = CFString.CreateNative (conversationIdentifier);
			var nsserviceName = CFString.CreateNative (serviceName);
			using var nsa_attachments = attachments is null ? null : NSArray.FromNSObjects (attachments);
			if (IsDirectBinding) {
				InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_IntPtr_NativeHandle_NativeHandle_NativeHandle_NativeHandle_NativeHandle_NativeHandle (this.Handle, selInitWithRecipients_OutgoingMessageType_Content_SpeakableGroupName_ConversationIdentifier_ServiceName_Sender_Attachments_XHandle, nsa_recipients.GetHandle (), (IntPtr) (long) outgoingMessageType, nscontent, speakableGroupName__handle__, nsconversationIdentifier, nsserviceName, sender__handle__, nsa_attachments.GetHandle ()), "initWithRecipients:outgoingMessageType:content:speakableGroupName:conversationIdentifier:serviceName:sender:attachments:");
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_IntPtr_NativeHandle_NativeHandle_NativeHandle_NativeHandle_NativeHandle_NativeHandle (&__objc_super__, selInitWithRecipients_OutgoingMessageType_Content_SpeakableGroupName_ConversationIdentifier_ServiceName_Sender_Attachments_XHandle, nsa_recipients.GetHandle (), (IntPtr) (long) outgoingMessageType, nscontent, speakableGroupName__handle__, nsconversationIdentifier, nsserviceName, sender__handle__, nsa_attachments.GetHandle ()), "initWithRecipients:outgoingMessageType:content:speakableGroupName:conversationIdentifier:serviceName:sender:attachments:");
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (speakableGroupName);
			GC.KeepAlive (sender);
			CFString.ReleaseNative (nscontent);
			CFString.ReleaseNative (nsconversationIdentifier);
			CFString.ReleaseNative (nsserviceName);
		}
		[Export ("initWithRecipients:content:speakableGroupName:conversationIdentifier:serviceName:sender:")]
		[ObsoletedOSPlatform ("macos11.0", "Use '.ctor (INPerson[], INOutgoingMessageType, string, INSpeakableString, string, string, INPerson, INSendMessageAttachment[])' instead.")]
		[ObsoletedOSPlatform ("ios14.0", "Use '.ctor (INPerson[], INOutgoingMessageType, string, INSpeakableString, string, string, INPerson, INSendMessageAttachment[])' instead.")]
		[SupportedOSPlatform ("maccatalyst")]
		[ObsoletedOSPlatform ("maccatalyst14.0", "Use '.ctor (INPerson[], INOutgoingMessageType, string, INSpeakableString, string, string, INPerson, INSendMessageAttachment[])' instead.")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public INSendMessageIntent (INPerson[]? recipients, string? content, INSpeakableString? speakableGroupName, string? conversationIdentifier, string? serviceName, INPerson? sender)
			: base (NSObjectFlag.Empty)
		{
			var speakableGroupName__handle__ = speakableGroupName.GetHandle ();
			var sender__handle__ = sender.GetHandle ();
			using var nsa_recipients = recipients is null ? null : NSArray.FromNSObjects (recipients);
			var nscontent = CFString.CreateNative (content);
			var nsconversationIdentifier = CFString.CreateNative (conversationIdentifier);
			var nsserviceName = CFString.CreateNative (serviceName);
			if (IsDirectBinding) {
				InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle_NativeHandle_NativeHandle_NativeHandle (this.Handle, selInitWithRecipients_Content_SpeakableGroupName_ConversationIdentifier_ServiceName_Sender_XHandle, nsa_recipients.GetHandle (), nscontent, speakableGroupName__handle__, nsconversationIdentifier, nsserviceName, sender__handle__), "initWithRecipients:content:speakableGroupName:conversationIdentifier:serviceName:sender:");
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_NativeHandle_NativeHandle_NativeHandle_NativeHandle_NativeHandle (&__objc_super__, selInitWithRecipients_Content_SpeakableGroupName_ConversationIdentifier_ServiceName_Sender_XHandle, nsa_recipients.GetHandle (), nscontent, speakableGroupName__handle__, nsconversationIdentifier, nsserviceName, sender__handle__), "initWithRecipients:content:speakableGroupName:conversationIdentifier:serviceName:sender:");
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (speakableGroupName);
			GC.KeepAlive (sender);
			CFString.ReleaseNative (nscontent);
			CFString.ReleaseNative (nsconversationIdentifier);
			CFString.ReleaseNative (nsserviceName);
		}
		[Export ("initWithRecipients:content:groupName:serviceName:sender:")]
		[ObsoletedOSPlatform ("macos12.0", "Use '.ctor (INPerson [], string, INSpeakableString, string, string, INPerson)' instead.")]
		[ObsoletedOSPlatform ("ios11.0", "Use '.ctor (INPerson [], string, INSpeakableString, string, string, INPerson)' instead.")]
		[ObsoletedOSPlatform ("maccatalyst13.1", "Use '.ctor (INPerson [], string, INSpeakableString, string, string, INPerson)' instead.")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public INSendMessageIntent (INPerson[]? recipients, string? content, string? groupName, string? serviceName, INPerson? sender)
			: base (NSObjectFlag.Empty)
		{
			var sender__handle__ = sender.GetHandle ();
			using var nsa_recipients = recipients is null ? null : NSArray.FromNSObjects (recipients);
			var nscontent = CFString.CreateNative (content);
			var nsgroupName = CFString.CreateNative (groupName);
			var nsserviceName = CFString.CreateNative (serviceName);
			if (IsDirectBinding) {
				InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle_NativeHandle_NativeHandle (this.Handle, selInitWithRecipients_Content_GroupName_ServiceName_Sender_XHandle, nsa_recipients.GetHandle (), nscontent, nsgroupName, nsserviceName, sender__handle__), "initWithRecipients:content:groupName:serviceName:sender:");
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_NativeHandle_NativeHandle_NativeHandle_NativeHandle (&__objc_super__, selInitWithRecipients_Content_GroupName_ServiceName_Sender_XHandle, nsa_recipients.GetHandle (), nscontent, nsgroupName, nsserviceName, sender__handle__), "initWithRecipients:content:groupName:serviceName:sender:");
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (sender);
			CFString.ReleaseNative (nscontent);
			CFString.ReleaseNative (nsgroupName);
			CFString.ReleaseNative (nsserviceName);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("ios14.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("macos")]
		public virtual INSendMessageAttachment[]? Attachments {
			[Export ("attachments", ArgumentSemantic.Copy)]
			get {
				INSendMessageAttachment[]? ret;
				if (IsDirectBinding) {
					ret = CFArray.ArrayFromHandle<INSendMessageAttachment>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selAttachmentsXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFArray.ArrayFromHandle<INSendMessageAttachment>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selAttachmentsXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string? Content {
			[Export ("content")]
			get {
				string ret;
				if (IsDirectBinding) {
					ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selContentXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selContentXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		public virtual string? ConversationIdentifier {
			[Export ("conversationIdentifier")]
			get {
				string ret;
				if (IsDirectBinding) {
					ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selConversationIdentifierXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selConversationIdentifierXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[ObsoletedOSPlatform ("macos12.0", "Use 'SpeakableGroupNames' instead.")]
		[ObsoletedOSPlatform ("ios11.0", "Use 'SpeakableGroupNames' instead.")]
		[ObsoletedOSPlatform ("maccatalyst13.1", "Use 'SpeakableGroupNames' instead.")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("maccatalyst")]
		public virtual string? GroupName {
			[Export ("groupName")]
			get {
				string ret;
				if (IsDirectBinding) {
					ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selGroupNameXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selGroupNameXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("ios14.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("macos")]
		public virtual INOutgoingMessageType OutgoingMessageType {
			[Export ("outgoingMessageType", ArgumentSemantic.Assign)]
			get {
				INOutgoingMessageType ret;
				if (IsDirectBinding) {
					ret = (Intents.INOutgoingMessageType) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selOutgoingMessageTypeXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = (Intents.INOutgoingMessageType) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (&__objc_super__, selOutgoingMessageTypeXHandle);
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
					ret = CFArray.ArrayFromHandle<INPerson>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selRecipientsXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFArray.ArrayFromHandle<INPerson>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selRecipientsXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual INPerson? Sender {
			[Export ("sender", ArgumentSemantic.Copy)]
			get {
				INPerson? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<INPerson> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selSenderXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<INPerson> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selSenderXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string? ServiceName {
			[Export ("serviceName")]
			get {
				string ret;
				if (IsDirectBinding) {
					ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selServiceNameXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selServiceNameXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		public virtual INSpeakableString? SpeakableGroupName {
			[Export ("speakableGroupName", ArgumentSemantic.Copy)]
			get {
				INSpeakableString? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<INSpeakableString> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selSpeakableGroupNameXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<INSpeakableString> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selSpeakableGroupNameXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
	} /* class INSendMessageIntent */
}
