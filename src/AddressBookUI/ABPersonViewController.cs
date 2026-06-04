// 
// ABPersonViewController.cs: 
//
// Authors: Mono Team
//     
// Copyright (C) 2009 Novell, Inc
//

#nullable enable

using AddressBook;

namespace AddressBookUI {
	/// <summary>Provides data for the <see cref="AddressBookUI.ABUnknownPersonViewController.PerformDefaultAction" /> and <see cref="AddressBookUI.ABPersonViewController.PerformDefaultAction" /> events.</summary>
	///     <remarks>
	///     </remarks>
	[SupportedOSPlatform ("ios")]
	[ObsoletedOSPlatform ("ios", "Use the 'Contacts' API instead.")]
	[SupportedOSPlatform ("maccatalyst")]
	[ObsoletedOSPlatform ("maccatalyst", "Use the 'Contacts' API instead.")]
	[UnsupportedOSPlatform ("macos")]
	[UnsupportedOSPlatform ("tvos")]
	public class ABPersonViewPerformDefaultActionEventArgs : EventArgs {
		/// <param name="person">The person.</param>
		///         <param name="property">The property.</param>
		///         <param name="identifier">The identifier to use.</param>
		///         <summary>Initializes a new instance of the ABPersonViewPerformDefaultActionEventArgs class.</summary>
		///         <remarks>
		///         </remarks>
		public ABPersonViewPerformDefaultActionEventArgs (ABPerson person, ABPersonProperty property, int? identifier)
		{
			Person = person;
			Property = property;
			Identifier = identifier;
		}

		/// <summary>Gets or sets the person.</summary>
		public ABPerson Person { get; private set; }
		/// <summary>Gets or sets the property.</summary>
		public ABPersonProperty Property { get; private set; }
		/// <summary>Gets or sets the identifier.</summary>
		public int? Identifier { get; private set; }

		/// <summary>Gets or sets the should perform default action.</summary>
		public bool ShouldPerformDefaultAction { get; set; }
	}

	[SupportedOSPlatform ("ios")]
	[ObsoletedOSPlatform ("ios", "Use the 'Contacts' API instead.")]
	[SupportedOSPlatform ("maccatalyst")]
	[ObsoletedOSPlatform ("maccatalyst", "Use the 'Contacts' API instead.")]
	[UnsupportedOSPlatform ("macos")]
	[UnsupportedOSPlatform ("tvos")]
	class InternalABPersonViewControllerDelegate : ABPersonViewControllerDelegate {

		internal EventHandler<ABPersonViewPerformDefaultActionEventArgs>? performDefaultAction;

		public InternalABPersonViewControllerDelegate ()
		{
			IsDirectBinding = false;
		}

		[Preserve (Conditional = true)]
		public override bool ShouldPerformDefaultActionForPerson (ABPersonViewController personViewController, ABPerson person, int propertyId, int identifier)
		{
			ABPersonProperty property = ABPersonPropertyId.ToPersonProperty (propertyId);
			int? id = identifier == ABRecord.InvalidPropertyId ? null : (int?) identifier;

			var e = new ABPersonViewPerformDefaultActionEventArgs (person, property, id);
			personViewController.OnPerformDefaultAction (e);
			return e.ShouldPerformDefaultAction;
		}
	}

	partial class ABPersonViewController {

		ABPerson? displayedPerson;
		/// <summary>Returns the <see cref="AddressBook.ABPerson" /> associated with the displayed data.</summary>
		public ABPerson? DisplayedPerson {
			get {
				MarkDirty ();
				return BackingField.Get (ref displayedPerson, _DisplayedPerson, h => new ABPerson (h, AddressBook));
			}
			set {
				_DisplayedPerson = BackingField.Save (ref displayedPerson, value);
				MarkDirty ();
			}
		}

		DisplayedPropertiesCollection? displayedProperties;
		/// <summary>Gets the collection of properties that are displayed about the <see cref="AddressBookUI.ABPersonViewController.DisplayedPerson" />.</summary>
		public DisplayedPropertiesCollection? DisplayedProperties {
			get {
				if (displayedProperties is null) {
					displayedProperties = new DisplayedPropertiesCollection (
							() => _DisplayedProperties,
							v => _DisplayedProperties = v);
					MarkDirty ();
				}
				return displayedProperties;
			}
		}

		ABAddressBook? addressBook;
		/// <summary>Gets or sets the <see cref="AddressBook.ABAddressBook" /> that is the store for the data.</summary>
		public ABAddressBook? AddressBook {
			get {
				MarkDirty ();
				return BackingField.Get (ref addressBook, _AddressBook, h => new ABAddressBook (h, false));
			}
			set {
				_AddressBook = BackingField.Save (ref addressBook, value);
				MarkDirty ();
			}
		}

		/// <param name="property">The property.</param>
		///         <param name="identifier">The identifier to use.</param>
		///         <summary>Highlights the item indexed by <paramref name="identifier" /> in the specified <paramref name="property" />.</summary>
		public void SetHighlightedItemForProperty (ABPersonProperty property, int? identifier)
		{
			SetHighlightedItemForProperty (
					ABPersonPropertyId.ToId (property),
					identifier ?? ABRecord.InvalidPropertyId);
		}

		/// <param name="property">The property.</param>
		///         <summary>Highlights the specified <paramref name="property" />.</summary>
		public void SetHighlightedProperty (ABPersonProperty property)
		{
			SetHighlightedItemForProperty (
					ABPersonPropertyId.ToId (property),
					ABRecord.InvalidPropertyId);
		}

		InternalABPersonViewControllerDelegate EnsureEventDelegate ()
		{
			var d = WeakDelegate as InternalABPersonViewControllerDelegate;
			if (d is null) {
				d = new InternalABPersonViewControllerDelegate ();
				WeakDelegate = d;
			}
			return d;
		}

		/// <param name="e">The event arguments.</param>
		/// <summary>Raises the PerformDefaultAction event.</summary>
		protected internal virtual void OnPerformDefaultAction (ABPersonViewPerformDefaultActionEventArgs e)
		{
			var h = EnsureEventDelegate ().performDefaultAction;
			if (h is not null)
				h (this, e);
		}

		/// <summary>Events handler.</summary>
		public event EventHandler<ABPersonViewPerformDefaultActionEventArgs> PerformDefaultAction {
			add { EnsureEventDelegate ().performDefaultAction += value; }
			remove { EnsureEventDelegate ().performDefaultAction -= value; }
		}
	}
}
