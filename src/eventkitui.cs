//
// This file describes the API that the generator will produce
//
// Authors:
//   Miguel de Icaza
//
// Copyright 2010, Novell, Inc.
// Copyright 2014 Xamarin Inc. All rights reserved.
//
using CoreGraphics;
using CoreLocation;
using UIKit;
using EventKit;

namespace EventKitUI {
	/// <summary>UIViewController used to display the details of a calendar event.</summary>
	///     
	///     <related type="externalDocumentation" href="https://developer.apple.com/library/ios/documentation/EventKitUI/Reference/EKEventViewControllerClassRef/index.html">Apple documentation for <c>EKEventViewController</c></related>
	[BaseType (typeof (UIViewController), Delegates = new string [] { "WeakDelegate" }, Events = new Type [] { typeof (EKEventViewDelegate) })]
	interface EKEventViewController {
		/// <param name="nibName">
		///   <para>The name of the nib file, or <see langword="null" />.</para>
		///   <para tool="nullallowed">This parameter can be <see langword="null" />.</para>
		/// </param>
		/// <param name="bundle">
		///   <para>The bundle in which to search for the nib file, or <see langword="null" />.</para>
		///   <para tool="nullallowed">This parameter can be <see langword="null" />.</para>
		/// </param>
		/// <summary>Creates a new <see cref="EventKitUI.EKEventViewController" /> from the specified Nib name in the specified <paramref name="bundle" />.</summary>
		[Export ("initWithNibName:bundle:")]
		[PostGet ("NibBundle")]
		NativeHandle Constructor ([NullAllowed] string nibName, [NullAllowed] NSBundle bundle);

		/// <summary>Gets or sets the calendar event to display.</summary>
		///         <value>
		///           <para>(More documentation for this node is coming)</para>
		///           <para tool="nullallowed">This value can be <see langword="null" />.</para>
		///         </value>
		[NullAllowed] // by default this property is null
		[Export ("event")]
		EKEvent Event { get; set; }

		/// <summary>Gets or sets a Boolean value that controls whether the user can edit the event.</summary>
		/// <value><see langword="true" /> if the event can be edited; otherwise, <see langword="false" />.</value>
		[Export ("allowsEditing")]
		bool AllowsEditing { get; set; }

		/// <summary>Gets or sets a Boolean value that controls whether the event can be viewed in the day preview.</summary>
		/// <value><see langword="true" /> if calendar preview is allowed; otherwise, <see langword="false" />.</value>
		[Export ("allowsCalendarPreview")]
		bool AllowsCalendarPreview { get; set; }

		/// <summary>An object that can respond to the delegate protocol for this type</summary>
		///         <value>The instance that will respond to events and data requests.</value>
		///         <remarks>
		///           <para>The delegate instance assigned to this object will be used to handle events or provide data on demand to this class.</para>
		///           <para>When setting the Delegate or WeakDelegate values events will be delivered to the specified instance instead of being delivered to the C#-style events</para>
		///           <para>   Methods must be decorated with the [Export ("selectorName")] attribute to respond to each method from the protocol.   Alternatively use the Delegate method which is strongly typed and does not require the [Export] attributes on methods.</para>
		///         </remarks>
		[Export ("delegate", ArgumentSemantic.Weak), NullAllowed]
		NSObject WeakDelegate { get; set; }

		/// <summary>An instance of the EventKitUI.IEKEventViewDelegate model class which acts as the class delegate.</summary>
		///         <value>The instance of the EventKitUI.IEKEventViewDelegate model class</value>
		///         <remarks>
		///           <para>The delegate instance assigned to this object will be used to handle events or provide data on demand to this class.</para>
		///           <para>When setting the Delegate or WeakDelegate values events will be delivered to the specified instance instead of being delivered to the C#-style events</para>
		///           <para>This is the strongly typed version of the object, developers should use the WeakDelegate property instead if they want to merely assign a class derived from NSObject that has been decorated with [Export] attributes.</para>
		///         </remarks>
		[Wrap ("WeakDelegate")]
		IEKEventViewDelegate Delegate { get; set; }
	}

	interface IEKEventViewDelegate { }

	/// <summary>A delegate object that provides the application developer fine-grained control over events in the life-cycle of a <see cref="EventKitUI.EKEventViewController" /> object.</summary>
	///     
	///     <related type="externalDocumentation" href="https://developer.apple.com/library/ios/documentation/EventKitUI/Reference/EKEventViewDelegateProtocolRef/index.html">Apple documentation for <c>EKEventViewDelegate</c></related>
	[BaseType (typeof (NSObject))]
	[Model]
	[Protocol]
	interface EKEventViewDelegate {
		/// <param name="controller">The controller.</param>
		///         <param name="action">The action to perform.</param>
		///         <summary>To be added.</summary>
		[Abstract]
		[Export ("eventViewController:didCompleteWithAction:"), EventArgs ("EKEventView", XmlDocs = """
			<summary>Event raised by the object.</summary>
			<remarks>If developers do not assign a value to this event, this will reset the value for the WeakDelegate property to an internal handler that maps delegates to events.</remarks>
			""")]
		void Completed (EKEventViewController controller, EKEventViewAction action);
	}

	/// <summary>UIViewController used to create or edit calendar events.</summary>
	///     
	///     <related type="externalDocumentation" href="https://developer.apple.com/library/ios/documentation/EventKitUI/Reference/EKEventEditViewControllerClassRef/index.html">Apple documentation for <c>EKEventEditViewController</c></related>
	[BaseType (typeof (UINavigationController), Delegates = new string [] { "WeakEditViewDelegate" }, Events = new Type [] { typeof (EKEventEditViewDelegate) })]
	interface EKEventEditViewController : UIAppearance {
		/// <param name="nibName">
		///           <para>To be added.</para>
		///           <para tool="nullallowed">This parameter can be <see langword="null" />.</para>
		///         </param>
		/// <param name="bundle">
		///           <para>To be added.</para>
		///           <para tool="nullallowed">This parameter can be <see langword="null" />.</para>
		///         </param>
		/// <summary>Creates a new <see cref="EventKitUI.EKEventEditViewController" /> from the specified Nib name in the specified <paramref name="bundle" />.</summary>
		[Export ("initWithNibName:bundle:")]
		[PostGet ("NibBundle")]
		NativeHandle Constructor ([NullAllowed] string nibName, [NullAllowed] NSBundle bundle);

		/// <param name="rootViewController">The root view controller.</param>
		/// <summary>Creates a new <see cref="EventKitUI.EKEventEditViewController" /> with the specified root view controller.</summary>
		[Export ("initWithRootViewController:")]
		[PostGet ("ViewControllers")] // that will PostGet TopViewController and VisibleViewController too
		NativeHandle Constructor (UIViewController rootViewController);

		/// <summary>Gets or sets a weak reference to the view delegate.</summary>
		///         <value>
		///           <para>(More documentation for this node is coming)</para>
		///           <para tool="nullallowed">This value can be <see langword="null" />.</para>
		///         </value>
		[Export ("editViewDelegate", ArgumentSemantic.Weak), NullAllowed]
		NSObject WeakEditViewDelegate { get; set; }

		/// <summary>Gets or sets the delegate object to notify when editing is complete.</summary>
		///         <value>
		///           <para>(More documentation for this node is coming)</para>
		///           <para tool="nullallowed">This value can be <see langword="null" />.</para>
		///         </value>
		[Wrap ("WeakEditViewDelegate")]
		IEKEventEditViewDelegate EditViewDelegate { get; set; }

		/// <summary>Gets or sets the event store in which the event is saved.</summary>
		///         <value>To be added.</value>
		[Export ("eventStore")]
		EKEventStore EventStore { get; set; }

		/// <summary>Gets or sets the event to edit.</summary>
		///         <value>To be added.</value>
		[NullAllowed]
		[Export ("event")]
		EKEvent Event { get; set; }

		/// <summary>Cancels the editing operation, discarding any changes.</summary>
		[Export ("cancelEditing")]
		void CancelEditing ();
	}

	interface IEKEventEditViewDelegate { }

	/// <summary>Delegate class used to receive notifications from the EKEventEditViewController class.</summary>
	///     
	///     <related type="externalDocumentation" href="https://developer.apple.com/library/ios/documentation/EventKitUI/Reference/EKEventEditViewDelegateRef/index.html">Apple documentation for <c>EKEventEditViewDelegate</c></related>
	[BaseType (typeof (NSObject))]
	[Model]
	[Protocol]
	interface EKEventEditViewDelegate {
		/// <param name="controller">The controller.</param>
		///         <param name="action">The action to perform.</param>
		///         <summary>To be added.</summary>
		[Abstract]
		[Export ("eventEditViewController:didCompleteWithAction:"), EventArgs ("EKEventEdit", XmlDocs = """
			<summary>Event raised by the object.</summary>
			<remarks>If developers do not assign a value to this event, this will reset the value for the WeakEditViewDelegate property to an internal handler that maps delegates to events.</remarks>
			""")]
		void Completed (EKEventEditViewController controller, EKEventEditViewAction action);

		/// <param name="controller">The controller.</param>
		///         <summary>To be added.</summary>
		///         <returns>To be added.</returns>
		[EventArgs ("", XmlDocs = """
			<summary>Delegate invoked by the object to get a value.</summary>
			<remarks>Developers assign a function, delegate or anonymous method to this property to return a value to the object.   If developers assign a value to this property, it this will reset the value for the WeakEditViewDelegate property to an internal handler that maps delegates to events.</remarks>
			""")]
		[Export ("eventEditViewControllerDefaultCalendarForNewEvents:"), DelegateName ("EKEventEditController"), DefaultValue (null)]
		EKCalendar GetDefaultCalendarForNewEvents (EKEventEditViewController controller);
	}

	/// <summary>A <see cref="UIKit.UIViewController" /> that manages the selection of one or more calendars.</summary>
	///     
	///     <related type="externalDocumentation" href="https://developer.apple.com/library/ios/documentation/EventKitUI/Reference/EKCalendarChooserClassRef/index.html">Apple documentation for <c>EKCalendarChooser</c></related>
	[BaseType (typeof (UIViewController),
		   Delegates = new string [] { "WeakDelegate" },
		   Events = new Type [] { typeof (EKCalendarChooserDelegate) })]
	interface EKCalendarChooser {
		/// <param name="nibName">
		///           <para>To be added.</para>
		///           <para tool="nullallowed">This parameter can be <see langword="null" />.</para>
		///         </param>
		/// <param name="bundle">
		///           <para>To be added.</para>
		///           <para tool="nullallowed">This parameter can be <see langword="null" />.</para>
		///         </param>
		/// <summary>Creates a new <see cref="EventKitUI.EKCalendarChooser" /> from the specified Nib name in the specified <paramref name="bundle" />.</summary>
		[Export ("initWithNibName:bundle:")]
		[PostGet ("NibBundle")]
		NativeHandle Constructor ([NullAllowed] string nibName, [NullAllowed] NSBundle bundle);

		/// <param name="selectionStyle">The selection style.</param>
		/// <param name="displayStyle">The display style.</param>
		/// <param name="eventStore">The event store.</param>
		/// <summary>Creates a new <see cref="EventKitUI.EKCalendarChooser" /> with the specified selection style, display style, and event store.</summary>
		[Export ("initWithSelectionStyle:displayStyle:eventStore:")]
		NativeHandle Constructor (EKCalendarChooserSelectionStyle selectionStyle, EKCalendarChooserDisplayStyle displayStyle, EKEventStore eventStore);

		/// <param name="selectionStyle">The selection style.</param>
		/// <param name="displayStyle">The display style.</param>
		/// <param name="entityType">The entity type.</param>
		/// <param name="eventStore">The event store.</param>
		/// <summary>Creates a new <see cref="EventKitUI.EKCalendarChooser" /> with the provided data.</summary>
		[Export ("initWithSelectionStyle:displayStyle:entityType:eventStore:")]
		NativeHandle Constructor (EKCalendarChooserSelectionStyle selectionStyle, EKCalendarChooserDisplayStyle displayStyle, EKEntityType entityType, EKEventStore eventStore);

		/// <summary>Gets or sets a value that controls whether multiple selections may be made.</summary>
		///         <value>To be added.</value>
		[Export ("selectionStyle")]
		EKCalendarChooserSelectionStyle SelectionStyle {
			get;
		}

		/// <summary>An object that can respond to the delegate protocol for this type</summary>
		///         <value>The instance that will respond to events and data requests.</value>
		///         <remarks>
		///           <para>The delegate instance assigned to this object will be used to handle events or provide data on demand to this class.</para>
		///           <para>When setting the Delegate or WeakDelegate values events will be delivered to the specified instance instead of being delivered to the C#-style events</para>
		///           <para>   Methods must be decorated with the [Export ("selectorName")] attribute to respond to each method from the protocol.   Alternatively use the Delegate method which is strongly typed and does not require the [Export] attributes on methods.</para>
		///         </remarks>
		[Export ("delegate", ArgumentSemantic.Weak), NullAllowed]
		NSObject WeakDelegate { get; set; }

		/// <summary>An instance of the EventKitUI.IEKCalendarChooserDelegate model class which acts as the class delegate.</summary>
		///         <value>The instance of the EventKitUI.IEKCalendarChooserDelegate model class</value>
		///         <remarks>
		///           <para>The delegate instance assigned to this object will be used to handle events or provide data on demand to this class.</para>
		///           <para>When setting the Delegate or WeakDelegate values events will be delivered to the specified instance instead of being delivered to the C#-style events</para>
		///           <para>This is the strongly typed version of the object, developers should use the WeakDelegate property instead if they want to merely assign a class derived from NSObject that has been decorated with [Export] attributes.</para>
		///         </remarks>
		[Wrap ("WeakDelegate")]
		IEKCalendarChooserDelegate Delegate { get; set; }

		/// <summary>Get or sets a Boolean value that controls whether to display a "Done" button when the picker is displayed modally.</summary>
		///         <value>To be added.</value>
		[Export ("showsDoneButton")]
		bool ShowsDoneButton { get; set; }

		/// <summary>Get or sets a Boolean value that controls whether to display a cancellation button when the picker is displayed modally.</summary>
		///         <value>To be added.</value>
		[Export ("showsCancelButton")]
		bool ShowsCancelButton { get; set; }

		/// <summary>Gets or sets a set that contains the calendars that the user has currently selected.</summary>
		///         <value>
		///           <para>(More documentation for this node is coming)</para>
		///           <para tool="nullallowed">This value can be <see langword="null" />.</para>
		///         </value>
		[NullAllowed] // by default this property is null
		[Export ("selectedCalendars", ArgumentSemantic.Copy)]
		NSSet SelectedCalendars { get; set; }
	}

	interface IEKCalendarChooserDelegate { }

	/// <summary>A delegate object that provides the application developer fine-grained control over events relating to the lifecycle of a <see cref="EventKitUI.EKCalendarChooser" /> object.</summary>
	///     
	///     <related type="externalDocumentation" href="https://developer.apple.com/library/ios/documentation/EventKitUI/Reference/EKCalendarChooserDelegateProtocolRef/index.html">Apple documentation for <c>EKCalendarChooserDelegate</c></related>
	[BaseType (typeof (NSObject))]
	[Model]
	[Protocol]
	interface EKCalendarChooserDelegate {
		/// <param name="calendarChooser">The calendar chooser.</param>
		///         <summary>To be added.</summary>
		[EventArgs ("", XmlDocs = """
			<summary>Event raised by the object.</summary>
			<remarks>If developers do not assign a value to this event, this will reset the value for the WeakDelegate property to an internal handler that maps delegates to events.</remarks>
			""")]
		[Export ("calendarChooserSelectionDidChange:")]
		void SelectionChanged (EKCalendarChooser calendarChooser);

		/// <param name="calendarChooser">The calendar chooser.</param>
		///         <summary>To be added.</summary>
		[EventArgs ("", XmlDocs = """
			<summary>Event raised by the object.</summary>
			<remarks>If developers do not assign a value to this event, this will reset the value for the WeakDelegate property to an internal handler that maps delegates to events.</remarks>
			""")]
		[Export ("calendarChooserDidFinish:")]
		void Finished (EKCalendarChooser calendarChooser);

		/// <param name="calendarChooser">The calendar chooser.</param>
		///         <summary>To be added.</summary>
		[EventArgs ("", XmlDocs = """
			<summary>Event raised by the object.</summary>
			<remarks>If developers do not assign a value to this event, this will reset the value for the WeakDelegate property to an internal handler that maps delegates to events.</remarks>
			""")]
		[Export ("calendarChooserDidCancel:")]
		void Cancelled (EKCalendarChooser calendarChooser);
	}

}
