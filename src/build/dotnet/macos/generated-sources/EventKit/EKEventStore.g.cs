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
namespace EventKit {
	/// <summary>The repository for Calendar and Reminder events.</summary><remarks><para>
	/// 		    The EventStore is required to perform any operations in EventKit. It can be thought of as the persistent storage, 
	/// 		   	or database, engine for all EventKit data. From EKEventStore you have access to both the calendars and calendar 	
	/// 		    events in the Calendar Application, as well as reminders in the Reminders Application.
	/// 	</para><para>
	/// 			Because EKEventStore is like a database engine, it should be long-lived, meaning that it should be created and 
	/// 			destroyed as little as possible during the lifetime of an application instance. In fact, it’s recommended that 
	/// 			once you create one instance of an EDEventStore in an application, you keep that reference around for the entire 
	/// 			lifetime of the application, unless you’re sure you won’t need it again. Additionally, all calls should go to a 
	/// 			single EKEventStore instance. For this reason, the Singleton pattern is recommended for keeping a single instance 
	/// 			available.
	/// 		</para><para>
	/// 			The following code illustrates an easy and efficient way to create a single instance of the EventStore class 
	/// 			and make it available statically from within an application:
	/// 		</para><example><code lang="csharp lang-csharp"><![CDATA[
	/// public class App
	/// {
	/// 	public static App Current {
	/// 		get { return current; }
	/// 	}
	/// 	private static App current;
	/// 
	/// 	public EKEventStore EventStore {
	/// 		get { return eventStore; }
	/// 	}
	/// 	protected EKEventStore eventStore;
	/// 
	/// 	static App ()
	/// 	{
	/// 		current = new App();
	/// 	}
	/// 	protected App () 
	/// 	{
	/// 		eventStore = new EKEventStore ( );
	/// 	}
	/// }			
	/// 			]]></code></example><para>
	/// 			The code above uses the Singleton pattern to instantiate an instance of the EventStore when the application 
	/// 			loads. The EventStore can then be accessed globally from within the application as follows:
	/// 				<c>App.Current.EventStore;</c></para><para>
	/// 			Before being allowed to access any data via the EKEventStore, an application must first request access to 
	/// 			either the calendar events data or reminders data, depending on which one you need. To facilitate this, the 
	/// 			KEEventStore exposes a method called RequestAccess which, when called, will show an alert view to the user 
	/// 			telling them the application is requesting access to either the calendar data, or reminder data, depending 
	/// 			on which EKEntityType is passed to it. Because it raises an alert view, the call is asynchronous and will 
	/// 			call a completion handler passed as an NSAction (or Lambda) to it which will receive two parameters, a 
	/// 			boolean of whether or not access was granted, and an NSError, which, if not-null will contain any error 
	/// 			information in the request. For example, the following coded will request access to calendar event data and 
	/// 			show an alert view if the request was not granted:
	/// 		</para><example><code lang="csharp lang-csharp"><![CDATA[
	/// App.Current.EventStore.RequestAccess (EKEntityType.Event, 
	/// 	(bool granted, NSError e) => {
	/// 		if (granted)
	/// 			//do something here
	/// 		else
	/// 			new UIAlertView ( "Access Denied", 
	/// "User Denied Access to Calendar Data", null,
	/// "ok", null).Show ();
	/// 		} );
	/// 			]]></code></example><para>
	/// 			Once the request has been granted, it will be remembered as long as the application is installed on the 
	/// 			device and will not pop up an alert to the user. However, access is only given to the type of resource, 
	/// 			either calendar events or reminders granted. If an application needs access to both, it should request both.
	/// 		</para><para>
	/// 			Because permission is remembered, it’s relatively cheap to make the request each time, so it’s a good idea 
	/// 			to always request access before performing an operation.
	/// 		</para><para>
	/// 			Additionally, because the completion handler is called on a separate (non-UI) thread, any updates to the 
	/// 			UI in the completion handler should be called via InovkeOnMainThread, otherwise an exception will be thrown, 
	/// 			and if not caught, the application will crash.
	/// 		</para></remarks><related type="externalDocumentation" href="https://developer.apple.com/library/ios/documentation/EventKit/Reference/EKEventStoreClassRef/index.html">Apple documentation for <c>EKEventStore</c></related>
	[Register("EKEventStore", true)]
	public unsafe partial class EKEventStore : NSObject {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAuthorizationStatusForEntityType_X = "authorizationStatusForEntityType:";
		static readonly NativeHandle selAuthorizationStatusForEntityType_XHandle = Selector.GetHandle ("authorizationStatusForEntityType:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selCalendarItemWithIdentifier_X = "calendarItemWithIdentifier:";
		static readonly NativeHandle selCalendarItemWithIdentifier_XHandle = Selector.GetHandle ("calendarItemWithIdentifier:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selCalendarItemsWithExternalIdentifier_X = "calendarItemsWithExternalIdentifier:";
		static readonly NativeHandle selCalendarItemsWithExternalIdentifier_XHandle = Selector.GetHandle ("calendarItemsWithExternalIdentifier:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selCalendarWithIdentifier_X = "calendarWithIdentifier:";
		static readonly NativeHandle selCalendarWithIdentifier_XHandle = Selector.GetHandle ("calendarWithIdentifier:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selCalendarsForEntityType_X = "calendarsForEntityType:";
		static readonly NativeHandle selCalendarsForEntityType_XHandle = Selector.GetHandle ("calendarsForEntityType:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selCancelFetchRequest_X = "cancelFetchRequest:";
		static readonly NativeHandle selCancelFetchRequest_XHandle = Selector.GetHandle ("cancelFetchRequest:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selCommit_X = "commit:";
		static readonly NativeHandle selCommit_XHandle = Selector.GetHandle ("commit:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selDefaultCalendarForNewEventsX = "defaultCalendarForNewEvents";
		static readonly NativeHandle selDefaultCalendarForNewEventsXHandle = Selector.GetHandle ("defaultCalendarForNewEvents");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selDefaultCalendarForNewRemindersX = "defaultCalendarForNewReminders";
		static readonly NativeHandle selDefaultCalendarForNewRemindersXHandle = Selector.GetHandle ("defaultCalendarForNewReminders");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selDelegateSourcesX = "delegateSources";
		static readonly NativeHandle selDelegateSourcesXHandle = Selector.GetHandle ("delegateSources");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selEnumerateEventsMatchingPredicate_UsingBlock_X = "enumerateEventsMatchingPredicate:usingBlock:";
		static readonly NativeHandle selEnumerateEventsMatchingPredicate_UsingBlock_XHandle = Selector.GetHandle ("enumerateEventsMatchingPredicate:usingBlock:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selEventStoreIdentifierX = "eventStoreIdentifier";
		static readonly NativeHandle selEventStoreIdentifierXHandle = Selector.GetHandle ("eventStoreIdentifier");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selEventWithIdentifier_X = "eventWithIdentifier:";
		static readonly NativeHandle selEventWithIdentifier_XHandle = Selector.GetHandle ("eventWithIdentifier:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selEventsMatchingPredicate_X = "eventsMatchingPredicate:";
		static readonly NativeHandle selEventsMatchingPredicate_XHandle = Selector.GetHandle ("eventsMatchingPredicate:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selFetchRemindersMatchingPredicate_Completion_X = "fetchRemindersMatchingPredicate:completion:";
		static readonly NativeHandle selFetchRemindersMatchingPredicate_Completion_XHandle = Selector.GetHandle ("fetchRemindersMatchingPredicate:completion:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selInitWithAccessToEntityTypes_X = "initWithAccessToEntityTypes:";
		static readonly NativeHandle selInitWithAccessToEntityTypes_XHandle = Selector.GetHandle ("initWithAccessToEntityTypes:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selInitWithSources_X = "initWithSources:";
		static readonly NativeHandle selInitWithSources_XHandle = Selector.GetHandle ("initWithSources:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selPredicateForCompletedRemindersWithCompletionDateStarting_Ending_Calendars_X = "predicateForCompletedRemindersWithCompletionDateStarting:ending:calendars:";
		static readonly NativeHandle selPredicateForCompletedRemindersWithCompletionDateStarting_Ending_Calendars_XHandle = Selector.GetHandle ("predicateForCompletedRemindersWithCompletionDateStarting:ending:calendars:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selPredicateForEventsWithStartDate_EndDate_Calendars_X = "predicateForEventsWithStartDate:endDate:calendars:";
		static readonly NativeHandle selPredicateForEventsWithStartDate_EndDate_Calendars_XHandle = Selector.GetHandle ("predicateForEventsWithStartDate:endDate:calendars:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selPredicateForIncompleteRemindersWithDueDateStarting_Ending_Calendars_X = "predicateForIncompleteRemindersWithDueDateStarting:ending:calendars:";
		static readonly NativeHandle selPredicateForIncompleteRemindersWithDueDateStarting_Ending_Calendars_XHandle = Selector.GetHandle ("predicateForIncompleteRemindersWithDueDateStarting:ending:calendars:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selPredicateForRemindersInCalendars_X = "predicateForRemindersInCalendars:";
		static readonly NativeHandle selPredicateForRemindersInCalendars_XHandle = Selector.GetHandle ("predicateForRemindersInCalendars:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selRefreshSourcesIfNecessaryX = "refreshSourcesIfNecessary";
		static readonly NativeHandle selRefreshSourcesIfNecessaryXHandle = Selector.GetHandle ("refreshSourcesIfNecessary");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selRemoveCalendar_Commit_Error_X = "removeCalendar:commit:error:";
		static readonly NativeHandle selRemoveCalendar_Commit_Error_XHandle = Selector.GetHandle ("removeCalendar:commit:error:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selRemoveEvent_Span_Commit_Error_X = "removeEvent:span:commit:error:";
		static readonly NativeHandle selRemoveEvent_Span_Commit_Error_XHandle = Selector.GetHandle ("removeEvent:span:commit:error:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selRemoveEvent_Span_Error_X = "removeEvent:span:error:";
		static readonly NativeHandle selRemoveEvent_Span_Error_XHandle = Selector.GetHandle ("removeEvent:span:error:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selRemoveReminder_Commit_Error_X = "removeReminder:commit:error:";
		static readonly NativeHandle selRemoveReminder_Commit_Error_XHandle = Selector.GetHandle ("removeReminder:commit:error:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selRequestAccessToEntityType_Completion_X = "requestAccessToEntityType:completion:";
		static readonly NativeHandle selRequestAccessToEntityType_Completion_XHandle = Selector.GetHandle ("requestAccessToEntityType:completion:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selRequestFullAccessToEventsWithCompletion_X = "requestFullAccessToEventsWithCompletion:";
		static readonly NativeHandle selRequestFullAccessToEventsWithCompletion_XHandle = Selector.GetHandle ("requestFullAccessToEventsWithCompletion:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selRequestFullAccessToRemindersWithCompletion_X = "requestFullAccessToRemindersWithCompletion:";
		static readonly NativeHandle selRequestFullAccessToRemindersWithCompletion_XHandle = Selector.GetHandle ("requestFullAccessToRemindersWithCompletion:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selRequestWriteOnlyAccessToEventsWithCompletion_X = "requestWriteOnlyAccessToEventsWithCompletion:";
		static readonly NativeHandle selRequestWriteOnlyAccessToEventsWithCompletion_XHandle = Selector.GetHandle ("requestWriteOnlyAccessToEventsWithCompletion:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selResetX = "reset";
		static readonly NativeHandle selResetXHandle = Selector.GetHandle ("reset");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSaveCalendar_Commit_Error_X = "saveCalendar:commit:error:";
		static readonly NativeHandle selSaveCalendar_Commit_Error_XHandle = Selector.GetHandle ("saveCalendar:commit:error:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSaveEvent_Span_Commit_Error_X = "saveEvent:span:commit:error:";
		static readonly NativeHandle selSaveEvent_Span_Commit_Error_XHandle = Selector.GetHandle ("saveEvent:span:commit:error:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSaveEvent_Span_Error_X = "saveEvent:span:error:";
		static readonly NativeHandle selSaveEvent_Span_Error_XHandle = Selector.GetHandle ("saveEvent:span:error:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSaveReminder_Commit_Error_X = "saveReminder:commit:error:";
		static readonly NativeHandle selSaveReminder_Commit_Error_XHandle = Selector.GetHandle ("saveReminder:commit:error:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSourceWithIdentifier_X = "sourceWithIdentifier:";
		static readonly NativeHandle selSourceWithIdentifier_XHandle = Selector.GetHandle ("sourceWithIdentifier:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSourcesX = "sources";
		static readonly NativeHandle selSourcesXHandle = Selector.GetHandle ("sources");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly NativeHandle class_ptr = Class.GetHandle ("EKEventStore");
		/// <summary>The Objective-C class handle for this class.</summary>
		/// <value>The pointer to the Objective-C class.</value>
		/// <remarks>
		///     Each managed class mirrors an unmanaged Objective-C class.
		///     This value contains the pointer to the Objective-C class.
		///     It is similar to calling the managed <see cref="ObjCRuntime.Class.GetHandle(string)" /> or the native <see href="https://developer.apple.com/documentation/objectivec/1418952-objc_getclass">objc_getClass</see> method with the type name.
		/// </remarks>
		public override NativeHandle ClassHandle { get { return class_ptr; } }
		/// <summary>Creates a new <see cref="EKEventStore" /> with default values.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public EKEventStore () : base (NSObjectFlag.Empty)
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
		protected EKEventStore (NSObjectFlag t) : base (t)
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
		protected internal EKEventStore (NativeHandle handle) : base (handle)
		{
		}

		[Export ("initWithSources:")]
		[SupportedOSPlatform ("ios16.0")]
		[SupportedOSPlatform ("maccatalyst16.0")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public EKEventStore (EKSource[] sources)
			: base (NSObjectFlag.Empty)
		{
			if (sources is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (sources));
			using var nsa_sources = NSArray.FromNSObjects (sources);
			if (IsDirectBinding) {
				InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, selInitWithSources_XHandle, nsa_sources.Handle), "initWithSources:");
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle (&__objc_super__, selInitWithSources_XHandle, nsa_sources.Handle), "initWithSources:");
					GC.KeepAlive (this);
				}
			}
		}
		[Export ("initWithAccessToEntityTypes:")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("tvos")]
		[ObsoletedOSPlatform ("macos10.9")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public EKEventStore (EKEntityMask accessToEntityTypes)
			: base (NSObjectFlag.Empty)
		{
			if (IsDirectBinding) {
				InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_UIntPtr (this.Handle, selInitWithAccessToEntityTypes_XHandle, (UIntPtr) (ulong) accessToEntityTypes), "initWithAccessToEntityTypes:");
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_UIntPtr (&__objc_super__, selInitWithAccessToEntityTypes_XHandle, (UIntPtr) (ulong) accessToEntityTypes), "initWithAccessToEntityTypes:");
					GC.KeepAlive (this);
				}
			}
		}
		[Export ("cancelFetchRequest:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void CancelFetchRequest (nint fetchIdentifier)
		{
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selCancelFetchRequest_XHandle, fetchIdentifier);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (&__objc_super__, selCancelFetchRequest_XHandle, fetchIdentifier);
					GC.KeepAlive (this);
				}
			}
		}
		[Export ("commit:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual bool Commit (out NSError error)
		{
			NativeHandle errorValue = IntPtr.Zero;
			byte ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_ref_NativeHandle (this.Handle, selCommit_XHandle, &errorValue);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper_ref_NativeHandle (&__objc_super__, selCommit_XHandle, &errorValue);
					GC.KeepAlive (this);
				}
			}
			error = Runtime.GetNSObject<NSError> (errorValue)!;
			return ret != 0;
		}
		[Export ("enumerateEventsMatchingPredicate:usingBlock:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void EnumerateEvents (NSPredicate predicate, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDEKEventSearchCallback))]EKEventSearchCallback block)
		{
			var predicate__handle__ = predicate!.GetNonNullHandle (nameof (predicate));
			if (block is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (block));
			using var block_block = Trampolines.SDEKEventSearchCallback.CreateBlock (block);
			BlockLiteral *block_ptr_block = &block_block;
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (this.Handle, selEnumerateEventsMatchingPredicate_UsingBlock_XHandle, predicate__handle__, (IntPtr) block_ptr_block);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, selEnumerateEventsMatchingPredicate_UsingBlock_XHandle, predicate__handle__, (IntPtr) block_ptr_block);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (predicate);
		}
		[Export ("eventWithIdentifier:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual EKEvent? EventFromIdentifier (string identifier)
		{
			if (identifier is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (identifier));
			var nsidentifier = CFString.CreateNative (identifier);
			EKEvent? ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<EKEvent> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, selEventWithIdentifier_XHandle, nsidentifier), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<EKEvent> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle (&__objc_super__, selEventWithIdentifier_XHandle, nsidentifier), false)!;
					GC.KeepAlive (this);
				}
			}
			CFString.ReleaseNative (nsidentifier);
			return ret!;
		}
		[Export ("eventsMatchingPredicate:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual EKEvent[] EventsMatching (NSPredicate predicate)
		{
			var predicate__handle__ = predicate!.GetNonNullHandle (nameof (predicate));
			EKEvent[]? ret;
			if (IsDirectBinding) {
				ret = CFArray.ArrayFromHandle<EKEvent>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, selEventsMatchingPredicate_XHandle, predicate__handle__), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = CFArray.ArrayFromHandle<EKEvent>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle (&__objc_super__, selEventsMatchingPredicate_XHandle, predicate__handle__), false)!;
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (predicate);
			return ret!;
		}
		[Export ("fetchRemindersMatchingPredicate:completion:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual nint FetchReminders (NSPredicate predicate, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V47))]global::System.Action<EKReminder[]> completion)
		{
			var predicate__handle__ = predicate!.GetNonNullHandle (nameof (predicate));
			if (completion is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completion));
			using var block_completion = Trampolines.SDActionArity1V47.CreateBlock (completion);
			BlockLiteral *block_ptr_completion = &block_completion;
			nint ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSend_NativeHandle_NativeHandle (this.Handle, selFetchRemindersMatchingPredicate_Completion_XHandle, predicate__handle__, (IntPtr) block_ptr_completion);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, selFetchRemindersMatchingPredicate_Completion_XHandle, predicate__handle__, (IntPtr) block_ptr_completion);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (predicate);
			return ret!;
		}
		/// <param name="predicate">A predicate for the reminders you want to fetch.</param>
		/// <summary>Fetches the reminders that match the specified predicate.</summary>
		/// <returns>
		///           <para class="improve-task-t-return-type-description">A task that represents the asynchronous FetchReminders operation.  The value of the TResult parameter is of type System.Action&lt;EventKit.EKReminder[]&gt;.</para>
		///         </returns>
		/// <remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual Task<EKReminder[]> FetchRemindersAsync (NSPredicate predicate)
		{
			var tcs = new TaskCompletionSource<EKReminder[]> ();
			FetchReminders(predicate, (obj_) => {
				tcs.SetResult (obj_!);
			});
			return tcs.Task;
		}
		/// <param name="predicate">To be added.</param>
		/// <param name="result">To be added.</param>
		/// <summary>To be added.</summary>
		/// <returns>To be added.</returns>
		/// <remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual Task<EKReminder[]> FetchRemindersAsync (NSPredicate predicate, out nint result)
		{
			var tcs = new TaskCompletionSource<EKReminder[]> ();
			result = FetchReminders(predicate, (obj_) => {
				tcs.SetResult (obj_!);
			})!;
			return tcs.Task;
		}
		[Export ("authorizationStatusForEntityType:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static EKAuthorizationStatus GetAuthorizationStatus (EKEntityType entityType)
		{
			EKAuthorizationStatus ret;
			ret = (EventKit.EKAuthorizationStatus) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSend_UIntPtr (class_ptr, selAuthorizationStatusForEntityType_XHandle, (UIntPtr) (ulong) entityType);
			return ret!;
		}
		[Export ("calendarWithIdentifier:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual EKCalendar? GetCalendar (string identifier)
		{
			if (identifier is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (identifier));
			var nsidentifier = CFString.CreateNative (identifier);
			EKCalendar? ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<EKCalendar> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, selCalendarWithIdentifier_XHandle, nsidentifier), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<EKCalendar> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle (&__objc_super__, selCalendarWithIdentifier_XHandle, nsidentifier), false)!;
					GC.KeepAlive (this);
				}
			}
			CFString.ReleaseNative (nsidentifier);
			return ret!;
		}
		[Export ("calendarItemWithIdentifier:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual EKCalendarItem? GetCalendarItem (string identifier)
		{
			if (identifier is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (identifier));
			var nsidentifier = CFString.CreateNative (identifier);
			EKCalendarItem? ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<EKCalendarItem> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, selCalendarItemWithIdentifier_XHandle, nsidentifier), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<EKCalendarItem> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle (&__objc_super__, selCalendarItemWithIdentifier_XHandle, nsidentifier), false)!;
					GC.KeepAlive (this);
				}
			}
			CFString.ReleaseNative (nsidentifier);
			return ret!;
		}
		[Export ("calendarItemsWithExternalIdentifier:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual EKCalendarItem[] GetCalendarItems (string externalIdentifier)
		{
			if (externalIdentifier is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (externalIdentifier));
			var nsexternalIdentifier = CFString.CreateNative (externalIdentifier);
			EKCalendarItem[]? ret;
			if (IsDirectBinding) {
				ret = CFArray.ArrayFromHandle<EKCalendarItem>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, selCalendarItemsWithExternalIdentifier_XHandle, nsexternalIdentifier), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = CFArray.ArrayFromHandle<EKCalendarItem>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle (&__objc_super__, selCalendarItemsWithExternalIdentifier_XHandle, nsexternalIdentifier), false)!;
					GC.KeepAlive (this);
				}
			}
			CFString.ReleaseNative (nsexternalIdentifier);
			return ret!;
		}
		[Export ("calendarsForEntityType:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual EKCalendar[] GetCalendars (EKEntityType entityType)
		{
			EKCalendar[] ret;
			if (IsDirectBinding) {
				ret = CFArray.ArrayFromHandle<EKCalendar>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_UIntPtr (this.Handle, selCalendarsForEntityType_XHandle, (UIntPtr) (ulong) entityType), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = CFArray.ArrayFromHandle<EKCalendar>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_UIntPtr (&__objc_super__, selCalendarsForEntityType_XHandle, (UIntPtr) (ulong) entityType), false)!;
					GC.KeepAlive (this);
				}
			}
			return ret;
		}
		[Export ("sourceWithIdentifier:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual EKSource? GetSource (string identifier)
		{
			if (identifier is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (identifier));
			var nsidentifier = CFString.CreateNative (identifier);
			EKSource? ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<EKSource> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, selSourceWithIdentifier_XHandle, nsidentifier), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<EKSource> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle (&__objc_super__, selSourceWithIdentifier_XHandle, nsidentifier), false)!;
					GC.KeepAlive (this);
				}
			}
			CFString.ReleaseNative (nsidentifier);
			return ret!;
		}
		[Export ("predicateForCompletedRemindersWithCompletionDateStarting:ending:calendars:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSPredicate PredicateForCompleteReminders (NSDate? startDate, NSDate? endDate, EKCalendar[]? calendars)
		{
			var startDate__handle__ = startDate.GetHandle ();
			var endDate__handle__ = endDate.GetHandle ();
			using var nsa_calendars = calendars is null ? null : NSArray.FromNSObjects (calendars);
			NSPredicate? ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<NSPredicate> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (this.Handle, selPredicateForCompletedRemindersWithCompletionDateStarting_Ending_Calendars_XHandle, startDate__handle__, endDate__handle__, nsa_calendars.GetHandle ()), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<NSPredicate> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_NativeHandle_NativeHandle (&__objc_super__, selPredicateForCompletedRemindersWithCompletionDateStarting_Ending_Calendars_XHandle, startDate__handle__, endDate__handle__, nsa_calendars.GetHandle ()), false)!;
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (startDate);
			GC.KeepAlive (endDate);
			return ret!;
		}
		[Export ("predicateForEventsWithStartDate:endDate:calendars:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSPredicate PredicateForEvents (NSDate startDate, NSDate endDate, EKCalendar[]? calendars)
		{
			var startDate__handle__ = startDate!.GetNonNullHandle (nameof (startDate));
			var endDate__handle__ = endDate!.GetNonNullHandle (nameof (endDate));
			using var nsa_calendars = calendars is null ? null : NSArray.FromNSObjects (calendars);
			NSPredicate? ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<NSPredicate> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (this.Handle, selPredicateForEventsWithStartDate_EndDate_Calendars_XHandle, startDate__handle__, endDate__handle__, nsa_calendars.GetHandle ()), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<NSPredicate> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_NativeHandle_NativeHandle (&__objc_super__, selPredicateForEventsWithStartDate_EndDate_Calendars_XHandle, startDate__handle__, endDate__handle__, nsa_calendars.GetHandle ()), false)!;
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (startDate);
			GC.KeepAlive (endDate);
			return ret!;
		}
		[Export ("predicateForIncompleteRemindersWithDueDateStarting:ending:calendars:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSPredicate PredicateForIncompleteReminders (NSDate? startDate, NSDate? endDate, EKCalendar[]? calendars)
		{
			var startDate__handle__ = startDate.GetHandle ();
			var endDate__handle__ = endDate.GetHandle ();
			using var nsa_calendars = calendars is null ? null : NSArray.FromNSObjects (calendars);
			NSPredicate? ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<NSPredicate> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (this.Handle, selPredicateForIncompleteRemindersWithDueDateStarting_Ending_Calendars_XHandle, startDate__handle__, endDate__handle__, nsa_calendars.GetHandle ()), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<NSPredicate> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_NativeHandle_NativeHandle (&__objc_super__, selPredicateForIncompleteRemindersWithDueDateStarting_Ending_Calendars_XHandle, startDate__handle__, endDate__handle__, nsa_calendars.GetHandle ()), false)!;
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (startDate);
			GC.KeepAlive (endDate);
			return ret!;
		}
		[Export ("predicateForRemindersInCalendars:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSPredicate PredicateForReminders (EKCalendar[]? calendars)
		{
			using var nsa_calendars = calendars is null ? null : NSArray.FromNSObjects (calendars);
			NSPredicate ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<NSPredicate> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, selPredicateForRemindersInCalendars_XHandle, nsa_calendars.GetHandle ()), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<NSPredicate> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle (&__objc_super__, selPredicateForRemindersInCalendars_XHandle, nsa_calendars.GetHandle ()), false)!;
					GC.KeepAlive (this);
				}
			}
			return ret;
		}
		[Export ("refreshSourcesIfNecessary")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void RefreshSourcesIfNecessary ()
		{
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, selRefreshSourcesIfNecessaryXHandle);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper (&__objc_super__, selRefreshSourcesIfNecessaryXHandle);
					GC.KeepAlive (this);
				}
			}
		}
		[Export ("removeCalendar:commit:error:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual bool RemoveCalendar (EKCalendar calendar, bool commit, out NSError error)
		{
			var calendar__handle__ = calendar!.GetNonNullHandle (nameof (calendar));
			NativeHandle errorValue = IntPtr.Zero;
			byte ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_bool_ref_NativeHandle (this.Handle, selRemoveCalendar_Commit_Error_XHandle, calendar__handle__, commit ? (byte) 1 : (byte) 0, &errorValue);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper_NativeHandle_bool_ref_NativeHandle (&__objc_super__, selRemoveCalendar_Commit_Error_XHandle, calendar__handle__, commit ? (byte) 1 : (byte) 0, &errorValue);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (calendar);
			error = Runtime.GetNSObject<NSError> (errorValue)!;
			return ret != 0;
		}
		[Export ("removeEvent:span:commit:error:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual bool RemoveEvent (EKEvent ekEvent, EKSpan span, bool commit, out NSError error)
		{
			var ekEvent__handle__ = ekEvent!.GetNonNullHandle (nameof (ekEvent));
			NativeHandle errorValue = IntPtr.Zero;
			byte ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_IntPtr_bool_ref_NativeHandle (this.Handle, selRemoveEvent_Span_Commit_Error_XHandle, ekEvent__handle__, (IntPtr) (long) span, commit ? (byte) 1 : (byte) 0, &errorValue);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper_NativeHandle_IntPtr_bool_ref_NativeHandle (&__objc_super__, selRemoveEvent_Span_Commit_Error_XHandle, ekEvent__handle__, (IntPtr) (long) span, commit ? (byte) 1 : (byte) 0, &errorValue);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (ekEvent);
			error = Runtime.GetNSObject<NSError> (errorValue)!;
			return ret != 0;
		}
		[Export ("removeEvent:span:error:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual bool RemoveEvents (EKEvent theEvent, EKSpan span, out NSError error)
		{
			var theEvent__handle__ = theEvent!.GetNonNullHandle (nameof (theEvent));
			NativeHandle errorValue = IntPtr.Zero;
			byte ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_IntPtr_ref_NativeHandle (this.Handle, selRemoveEvent_Span_Error_XHandle, theEvent__handle__, (IntPtr) (long) span, &errorValue);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper_NativeHandle_IntPtr_ref_NativeHandle (&__objc_super__, selRemoveEvent_Span_Error_XHandle, theEvent__handle__, (IntPtr) (long) span, &errorValue);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (theEvent);
			error = Runtime.GetNSObject<NSError> (errorValue)!;
			return ret != 0;
		}
		[Export ("removeReminder:commit:error:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual bool RemoveReminder (EKReminder reminder, bool commit, out NSError error)
		{
			var reminder__handle__ = reminder!.GetNonNullHandle (nameof (reminder));
			NativeHandle errorValue = IntPtr.Zero;
			byte ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_bool_ref_NativeHandle (this.Handle, selRemoveReminder_Commit_Error_XHandle, reminder__handle__, commit ? (byte) 1 : (byte) 0, &errorValue);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper_NativeHandle_bool_ref_NativeHandle (&__objc_super__, selRemoveReminder_Commit_Error_XHandle, reminder__handle__, commit ? (byte) 1 : (byte) 0, &errorValue);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (reminder);
			error = Runtime.GetNSObject<NSError> (errorValue)!;
			return ret != 0;
		}
		[Export ("requestAccessToEntityType:completion:")]
		[SupportedOSPlatform ("maccatalyst")]
		[ObsoletedOSPlatform ("ios17.0", "Use RequestFullAccessToEvents, RequestWriteOnlyAccessToEvents, or RequestFullAccessToReminders.")]
		[ObsoletedOSPlatform ("macos14.0", "Use RequestFullAccessToEvents, RequestWriteOnlyAccessToEvents, or RequestFullAccessToReminders.")]
		[ObsoletedOSPlatform ("maccatalyst17.0", "Use RequestFullAccessToEvents, RequestWriteOnlyAccessToEvents, or RequestFullAccessToReminders.")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void RequestAccess (EKEntityType entityType, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity2V13))]global::System.Action<bool, NSError> completionHandler)
		{
			if (completionHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completionHandler));
			using var block_completionHandler = Trampolines.SDActionArity2V13.CreateBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = &block_completionHandler;
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_UIntPtr_NativeHandle (this.Handle, selRequestAccessToEntityType_Completion_XHandle, (UIntPtr) (ulong) entityType, (IntPtr) block_ptr_completionHandler);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_UIntPtr_NativeHandle (&__objc_super__, selRequestAccessToEntityType_Completion_XHandle, (UIntPtr) (ulong) entityType, (IntPtr) block_ptr_completionHandler);
					GC.KeepAlive (this);
				}
			}
		}
		/// <param name="entityType">The  for which access is being requested.</param>
		/// <summary>Shows, if necessary, the standard permissions dialog for the specified <paramref name="entityType" />.</summary>
		/// <returns>
		///           <para class="improve-task-t-return-type-description">A task that represents the asynchronous RequestAccess operation.  The value of the TResult parameter is of type System.Action&lt;System.Boolean,Foundation.NSError&gt;.</para>
		///         </returns>
		/// <remarks>
		///           <para copied="true">The RequestAccessAsync method is suitable to be used with C# async by returning control to the caller with a Task representing the operation.</para>
		///         </remarks>
		[SupportedOSPlatform ("maccatalyst")]
		[ObsoletedOSPlatform ("ios17.0", "Use RequestFullAccessToEvents, RequestWriteOnlyAccessToEvents, or RequestFullAccessToReminders.")]
		[ObsoletedOSPlatform ("macos14.0", "Use RequestFullAccessToEvents, RequestWriteOnlyAccessToEvents, or RequestFullAccessToReminders.")]
		[ObsoletedOSPlatform ("maccatalyst17.0", "Use RequestFullAccessToEvents, RequestWriteOnlyAccessToEvents, or RequestFullAccessToReminders.")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual Task<Tuple<bool,NSError>> RequestAccessAsync (EKEntityType entityType)
		{
			var tcs = new TaskCompletionSource<Tuple<bool,NSError>> ();
			RequestAccess(entityType, (arg1_, arg2_) => {
				tcs.SetResult (new Tuple<bool,NSError> (arg1_, arg2_));
			});
			return tcs.Task;
		}
		[Export ("requestFullAccessToEventsWithCompletion:")]
		[SupportedOSPlatform ("macos14.0")]
		[SupportedOSPlatform ("ios17.0")]
		[SupportedOSPlatform ("maccatalyst17.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void RequestFullAccessToEvents ([BlockProxy (typeof (ObjCRuntime.Trampolines.NIDEKEventStoreRequestAccessCompletionHandler))]EKEventStoreRequestAccessCompletionHandler completion)
		{
			if (completion is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completion));
			using var block_completion = Trampolines.SDEKEventStoreRequestAccessCompletionHandler.CreateBlock (completion);
			BlockLiteral *block_ptr_completion = &block_completion;
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selRequestFullAccessToEventsWithCompletion_XHandle, (IntPtr) block_ptr_completion);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selRequestFullAccessToEventsWithCompletion_XHandle, (IntPtr) block_ptr_completion);
					GC.KeepAlive (this);
				}
			}
		}
		[SupportedOSPlatform ("macos14.0")]
		[SupportedOSPlatform ("ios17.0")]
		[SupportedOSPlatform ("maccatalyst17.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual Task<Tuple<bool,NSError?>> RequestFullAccessToEventsAsync ()
		{
			var tcs = new TaskCompletionSource<Tuple<bool,NSError?>> ();
			RequestFullAccessToEvents((didRequestAccess_, error_) => {
				tcs.SetResult (new Tuple<bool,NSError?> (didRequestAccess_, error_));
			});
			return tcs.Task;
		}
		[Export ("requestFullAccessToRemindersWithCompletion:")]
		[SupportedOSPlatform ("macos14.0")]
		[SupportedOSPlatform ("ios17.0")]
		[SupportedOSPlatform ("maccatalyst17.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void RequestFullAccessToReminders ([BlockProxy (typeof (ObjCRuntime.Trampolines.NIDEKEventStoreRequestAccessCompletionHandler))]EKEventStoreRequestAccessCompletionHandler completion)
		{
			if (completion is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completion));
			using var block_completion = Trampolines.SDEKEventStoreRequestAccessCompletionHandler.CreateBlock (completion);
			BlockLiteral *block_ptr_completion = &block_completion;
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selRequestFullAccessToRemindersWithCompletion_XHandle, (IntPtr) block_ptr_completion);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selRequestFullAccessToRemindersWithCompletion_XHandle, (IntPtr) block_ptr_completion);
					GC.KeepAlive (this);
				}
			}
		}
		[SupportedOSPlatform ("macos14.0")]
		[SupportedOSPlatform ("ios17.0")]
		[SupportedOSPlatform ("maccatalyst17.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual Task<Tuple<bool,NSError?>> RequestFullAccessToRemindersAsync ()
		{
			var tcs = new TaskCompletionSource<Tuple<bool,NSError?>> ();
			RequestFullAccessToReminders((didRequestAccess_, error_) => {
				tcs.SetResult (new Tuple<bool,NSError?> (didRequestAccess_, error_));
			});
			return tcs.Task;
		}
		[Export ("requestWriteOnlyAccessToEventsWithCompletion:")]
		[SupportedOSPlatform ("macos14.0")]
		[SupportedOSPlatform ("ios17.0")]
		[SupportedOSPlatform ("maccatalyst17.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void RequestWriteOnlyAccessToEvents ([BlockProxy (typeof (ObjCRuntime.Trampolines.NIDEKEventStoreRequestAccessCompletionHandler))]EKEventStoreRequestAccessCompletionHandler completion)
		{
			if (completion is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completion));
			using var block_completion = Trampolines.SDEKEventStoreRequestAccessCompletionHandler.CreateBlock (completion);
			BlockLiteral *block_ptr_completion = &block_completion;
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selRequestWriteOnlyAccessToEventsWithCompletion_XHandle, (IntPtr) block_ptr_completion);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selRequestWriteOnlyAccessToEventsWithCompletion_XHandle, (IntPtr) block_ptr_completion);
					GC.KeepAlive (this);
				}
			}
		}
		[SupportedOSPlatform ("macos14.0")]
		[SupportedOSPlatform ("ios17.0")]
		[SupportedOSPlatform ("maccatalyst17.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual Task<Tuple<bool,NSError?>> RequestWriteOnlyAccessToEventsAsync ()
		{
			var tcs = new TaskCompletionSource<Tuple<bool,NSError?>> ();
			RequestWriteOnlyAccessToEvents((didRequestAccess_, error_) => {
				tcs.SetResult (new Tuple<bool,NSError?> (didRequestAccess_, error_));
			});
			return tcs.Task;
		}
		[Export ("reset")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void Reset ()
		{
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, selResetXHandle);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper (&__objc_super__, selResetXHandle);
					GC.KeepAlive (this);
				}
			}
		}
		[Export ("saveCalendar:commit:error:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual bool SaveCalendar (EKCalendar calendar, bool commit, out NSError error)
		{
			var calendar__handle__ = calendar!.GetNonNullHandle (nameof (calendar));
			NativeHandle errorValue = IntPtr.Zero;
			byte ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_bool_ref_NativeHandle (this.Handle, selSaveCalendar_Commit_Error_XHandle, calendar__handle__, commit ? (byte) 1 : (byte) 0, &errorValue);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper_NativeHandle_bool_ref_NativeHandle (&__objc_super__, selSaveCalendar_Commit_Error_XHandle, calendar__handle__, commit ? (byte) 1 : (byte) 0, &errorValue);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (calendar);
			error = Runtime.GetNSObject<NSError> (errorValue)!;
			return ret != 0;
		}
		[Export ("saveEvent:span:error:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual bool SaveEvent (EKEvent theEvent, EKSpan span, out NSError error)
		{
			var theEvent__handle__ = theEvent!.GetNonNullHandle (nameof (theEvent));
			NativeHandle errorValue = IntPtr.Zero;
			byte ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_IntPtr_ref_NativeHandle (this.Handle, selSaveEvent_Span_Error_XHandle, theEvent__handle__, (IntPtr) (long) span, &errorValue);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper_NativeHandle_IntPtr_ref_NativeHandle (&__objc_super__, selSaveEvent_Span_Error_XHandle, theEvent__handle__, (IntPtr) (long) span, &errorValue);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (theEvent);
			error = Runtime.GetNSObject<NSError> (errorValue)!;
			return ret != 0;
		}
		[Export ("saveEvent:span:commit:error:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual bool SaveEvent (EKEvent ekEvent, EKSpan span, bool commit, out NSError error)
		{
			var ekEvent__handle__ = ekEvent!.GetNonNullHandle (nameof (ekEvent));
			NativeHandle errorValue = IntPtr.Zero;
			byte ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_IntPtr_bool_ref_NativeHandle (this.Handle, selSaveEvent_Span_Commit_Error_XHandle, ekEvent__handle__, (IntPtr) (long) span, commit ? (byte) 1 : (byte) 0, &errorValue);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper_NativeHandle_IntPtr_bool_ref_NativeHandle (&__objc_super__, selSaveEvent_Span_Commit_Error_XHandle, ekEvent__handle__, (IntPtr) (long) span, commit ? (byte) 1 : (byte) 0, &errorValue);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (ekEvent);
			error = Runtime.GetNSObject<NSError> (errorValue)!;
			return ret != 0;
		}
		[Export ("saveReminder:commit:error:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual bool SaveReminder (EKReminder reminder, bool commit, out NSError error)
		{
			var reminder__handle__ = reminder!.GetNonNullHandle (nameof (reminder));
			NativeHandle errorValue = IntPtr.Zero;
			byte ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_bool_ref_NativeHandle (this.Handle, selSaveReminder_Commit_Error_XHandle, reminder__handle__, commit ? (byte) 1 : (byte) 0, &errorValue);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper_NativeHandle_bool_ref_NativeHandle (&__objc_super__, selSaveReminder_Commit_Error_XHandle, reminder__handle__, commit ? (byte) 1 : (byte) 0, &errorValue);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (reminder);
			error = Runtime.GetNSObject<NSError> (errorValue)!;
			return ret != 0;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual EKCalendar? DefaultCalendarForNewEvents {
			[Export ("defaultCalendarForNewEvents")]
			get {
				EKCalendar? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<EKCalendar> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selDefaultCalendarForNewEventsXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<EKCalendar> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selDefaultCalendarForNewEventsXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual EKCalendar? DefaultCalendarForNewReminders {
			[Export ("defaultCalendarForNewReminders")]
			get {
				EKCalendar? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<EKCalendar> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selDefaultCalendarForNewRemindersXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<EKCalendar> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selDefaultCalendarForNewRemindersXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		public virtual EKSource[] DelegateSources {
			[Export ("delegateSources")]
			get {
				EKSource[]? ret;
				if (IsDirectBinding) {
					ret = CFArray.ArrayFromHandle<EKSource>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selDelegateSourcesXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFArray.ArrayFromHandle<EKSource>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selDelegateSourcesXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string EventStoreIdentifier {
			[Export ("eventStoreIdentifier")]
			get {
				string ret;
				if (IsDirectBinding) {
					ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selEventStoreIdentifierXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selEventStoreIdentifierXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual EKSource[] Sources {
			[Export ("sources")]
			get {
				EKSource[]? ret;
				if (IsDirectBinding) {
					ret = CFArray.ArrayFromHandle<EKSource>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selSourcesXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFArray.ArrayFromHandle<EKSource>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selSourcesXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ChangedNotification;
		/// <summary>Notification constant for Changed</summary>
		/// <value><see cref="NSString" /> constant, should be used as a token to <see cref="NSNotificationCenter" />.</value>
		/// <remarks>
		///   <para>
		///     This constant can be used with <see cref="NSNotificationCenter" /> to register a listener for this notification.
		///     This is an <see cref="NSString" /> instead of a string, because these values can be used as tokens in some native
		///     libraries instead of being used purely for their actual string content. The 'notification' parameter to the callback
		///     contains extra information that is specific to the notification type.
		///   </para>
		///   <para>
		///     To subscribe to this notification, developers can use the convenience <see cref="Notifications.ObserveChanged(NSObject,EventHandler{NSNotificationEventArgs})" />
		///     or <see cref="Notifications.ObserveChanged(EventHandler{NSNotificationEventArgs})" /> methods,
		///     which offers strongly typed access to the parameters of the notification.
		///   </para>
		///   <para>
		///     The following example shows how to use the strongly typed <see cref="Notifications" /> class, to take the guesswork
		///     out of the available properties in the notification:
		///   </para>
		///   <example>
		///     <code lang="csharp lang-csharp"><![CDATA[
		/// //
		/// // Lambda style
		/// //
		///
		/// // listening
		/// notification = EKEventStore.Notifications.ObserveChanged ((sender, args) => {
		/// /* Access strongly typed args */
		/// Console.WriteLine ("Notification: {0}", args.Notification);
		/// });
		///
		/// // To stop listening:
		/// notification.Dispose ();
		///
		/// //
		/// // Method style
		/// //
		/// NSObject notification;
		/// void Callback (object sender, EKEventStore.NSNotificationEventArgs args)
		/// {
		///     // Access strongly typed args
		///     Console.WriteLine ("Notification: {0}", args.Notification);
		/// }
		///
		/// void Setup ()
		/// {
		///     notification = EKEventStore.Notifications.ObserveChanged (Callback);
		/// }
		///
		/// void Teardown ()
		/// {
		///     notification.Dispose ();
		/// }]]></code>
		///   </example>
		///   <para>
		///     The following example shows how to use the notification with the DefaultCenter API:
		///   </para>
		///   <example>
		///     <code lang="csharp lang-csharp"><![CDATA[
		/// // Lambda style
		/// NSNotificationCenter.DefaultCenter.AddObserver (
		///     EKEventStore.ChangedNotification, (notification) => { Console.WriteLine ("Received the notification Changed", notification); }
		/// );
		///
		/// // Method style
		/// void Callback (NSNotification notification)
		/// {
		///     Console.WriteLine ("Received the notification Changed", notification);
		/// }
		///
		/// void Setup ()
		/// {
		///     NSNotificationCenter.DefaultCenter.AddObserver (EKEventStore.ChangedNotification, Callback);
		/// }
		/// ]]></code>
		///   </example>
		/// </remarks>
		[Field ("EKEventStoreChangedNotification",  "EventKit")]
		[Advice ("Use EKEventStore.Notifications.ObserveChanged helper method instead.")]
		public static NSString ChangedNotification {
			get {
				if (_ChangedNotification is null)
					_ChangedNotification = Dlfcn.GetStringConstant (Libraries.EventKit.Handle, "EKEventStoreChangedNotification")!;
				return _ChangedNotification;
			}
		}
		//
		// Notifications
		//
		/// <summary>Notifications posted by the <see cref="global::EventKit.EKEventStore" /> class.</summary>
		/// <remarks>
		///    <para>This class contains various helper methods that allow developers to observe events posted in the notification hub (<see cref="Foundation.NSNotificationCenter" />).</para>
		///    <para>The methods defined in this class post events that invoke the provided method or lambda with a <see cref="Foundation.NSNotificationEventArgs" /> parameter, which contains strongly typed properties for the notification arguments.</para>
		/// </remarks>
		public static partial class Notifications {
			/// <summary>Strongly typed notification for the <see cref="global::EventKit.EKEventStore.ChangedNotification" /> constant.</summary>
			/// <param name="handler">The handler that responds to the notification when it occurs.</param>
			/// <returns>Token object that can be used to stop receiving notifications by either disposing it or passing it to <see cref="Foundation.NSNotificationCenter.RemoveObservers(System.Collections.Generic.IEnumerable{Foundation.NSObject})" />.</returns>
			/// <remarks>
			///   <para>This method can be used to subscribe to <see cref="global::EventKit.EKEventStore.ChangedNotification" /> notifications.</para>
			///   <example>
			///   <code lang="csharp lang-csharp"><![CDATA[
			/// // Listen to all notifications posted for any object
			/// var token = EKEventStore.Notifications.ObserveChanged ((notification) => {
			///   Console.WriteLine ("Observed ChangedNotification!");
			/// };
			/// 
			/// // Stop listening for notifications
			/// token.Dispose ();
			/// ]]></code>
			///   </example>
			/// </remarks>
			public static NSObject ObserveChanged (EventHandler<NSNotificationEventArgs> handler)
			{
				return NSNotificationCenter.DefaultCenter.AddObserver (ChangedNotification, notification => handler (null, new NSNotificationEventArgs (notification)));
			}
			/// <summary>Strongly typed notification for the <see cref="global::EventKit.EKEventStore.ChangedNotification" /> constant.</summary>
			/// <param name="objectToObserve">The specific object to observe.</param>
			/// <param name="handler">The handler that responds to the notification when it occurs.</param>
			/// <returns>Token object that can be used to stop receiving notifications by either disposing it or passing it to <see cref="Foundation.NSNotificationCenter.RemoveObservers(System.Collections.Generic.IEnumerable{Foundation.NSObject})" />.</returns>
			/// <remarks>
			///   <para>This method can be used to subscribe to <see cref="global::EventKit.EKEventStore.ChangedNotification" /> notifications.</para>
			///   <example>
			///     <code lang="csharp lang-csharp"><![CDATA[
			/// // Listen to all notifications posted for a single object
			/// var token = EKEventStore.Notifications.ObserveChanged (objectToObserve, (notification) => {
			///   Console.WriteLine ($"Observed ChangedNotification for {nameof (objectToObserve)}!");
			/// };
			/// 
			/// // Stop listening for notifications
			/// token.Dispose ();
			/// ]]></code>
			///   </example>
			/// </remarks>
			public static NSObject ObserveChanged (NSObject objectToObserve, EventHandler<NSNotificationEventArgs> handler)
			{
				return NSNotificationCenter.DefaultCenter.AddObserver (ChangedNotification, notification => handler (null, new NSNotificationEventArgs (notification)), objectToObserve);
			}
		}
	} /* class EKEventStore */
}
