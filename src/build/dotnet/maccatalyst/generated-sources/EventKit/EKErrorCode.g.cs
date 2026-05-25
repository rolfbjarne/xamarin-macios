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
namespace EventKit {
	/// <summary>Errors returned by Event Kit.</summary>
	[Native]
	public enum EKErrorCode : long {
		/// <summary>The event cannot be modified.</summary>
		EventNotMutable = 0,
		/// <summary>The event does not have an associated calendar.</summary>
		NoCalendar = 1,
		/// <summary>The StartDate property has not been set for the event.</summary>
		NoStartDate = 2,
		/// <summary>The EndDate property has not been set for the event.</summary>
		NoEndDate = 3,
		/// <summary>The event EndDate cannot occur before the event StartDate</summary>
		DatesInverted = 4,
		/// <summary>An internal error has occurred.</summary>
		InternalFailure = 5,
		/// <summary>The calendar cannot be modified.</summary>
		CalendarReadOnly = 6,
		/// <summary>The event duration is too large for the interval specified by the event's recurrence rule.</summary>
		DurationGreaterThanRecurrence = 7,
		/// <summary>The alarm's RelativeOffset is too large for the interval specified by the event's recurrence rule.</summary>
		AlarmGreaterThanRecurrence = 8,
		/// <summary>The event's StartDate is beyond the end of the calendar.</summary>
		StartDateTooFarInFuture = 9,
		/// <summary>The event's StartDate is set to collide with other occurrences of the same event.</summary>
		StartDateCollidesWithOtherOccurrence = 10,
		/// <summary>The object is not stored in the same event store.</summary>
		ObjectBelongsToDifferentStore = 11,
		/// <summary>Invites cannot be modified.</summary>
		InvitesCannotBeMoved = 12,
		/// <summary>The time span for the event was invalid.</summary>
		InvalidSpan = 13,
		/// <summary>The calendar could not be saved because its source was not set.</summary>
		CalendarHasNoSource = 14,
		/// <summary>The calendar source can not be modified.</summary>
		CalendarSourceCannotBeModified = 15,
		/// <summary>The calendar is immutable.</summary>
		CalendarIsImmutable = 16,
		/// <summary>The source will not allow the developer to add or delete calendars.</summary>
		SourceDoesNotAllowCalendarAddDelete = 17,
		/// <summary>A recurring reminder's due date was missing.</summary>
		RecurringReminderRequiresDueDate = 18,
		/// <summary>The source does not support structured locations.</summary>
		StructuredLocationsNotSupported = 19,
		/// <summary>Locations are not supported for reminders on the source.</summary>
		ReminderLocationsNotSupported = 20,
		/// <summary>Geofenced alarms are not supported.</summary>
		AlarmProximityNotSupported = 21,
		/// <summary>The calendar does not allow events.</summary>
		CalendarDoesNotAllowEvents = 22,
		/// <summary>The calendar does not allow reminders.</summary>
		CalendarDoesNotAllowReminders = 23,
		/// <summary>The source does not allow reminders.</summary>
		SourceDoesNotAllowReminders = 24,
		/// <summary>The source does not allow events.</summary>
		SourceDoesNotAllowEvents = 25,
		/// <summary>To be added.</summary>
		PriorityIsInvalid = 26,
		/// <summary>To be added.</summary>
		InvalidEntityType = 27,
		/// <summary>To be added.</summary>
		ProcedureAlarmsNotMutable = 28,
		/// <summary>To be added.</summary>
		EventStoreNotAuthorized = 29,
		/// <summary>To be added.</summary>
		OSNotSupported = 30,
		InvalidInviteReplyCalendar = 31,
		NotificationsCollectionFlagNotSet = 32,
		SourceMismatch = 33,
		NotificationCollectionMismatch = 34,
		NotificationSavedWithoutCollection = 35,
		ReminderAlarmContainsEmailOrUrl = 36,
	}
	/// <summary>Extension methods for the <see cref="global::EventKit.EKErrorCode" /> enumeration.</summary>
	/// <remarks>
	///   <para>The extension method for the <see cref="global::EventKit.EKErrorCode" /> enumeration can be used to fetch the error domain associated with these error codes.</para>
	/// </remarks>
	[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	static public partial class EKErrorCodeExtensions {
		[Field ("EKErrorDomain", "EventKit")]
		static NSString? _domain;
		/// <summary>Returns the error domain associated with the EventKit.EKErrorCode value</summary>
		/// <param name="self">The enumeration value</param>
		/// <remarks>
		///   <para>See the <see cref="global::Foundation.NSError" /> for information on how to use the error domains when reporting errors.</para>
		/// </remarks>
		public static NSString? GetDomain (this EKErrorCode self)
		{
			if (_domain is null)
				_domain = Dlfcn.GetStringConstant (Libraries.EventKit.Handle, "EKErrorDomain");
			return _domain;
		}
	}
}
