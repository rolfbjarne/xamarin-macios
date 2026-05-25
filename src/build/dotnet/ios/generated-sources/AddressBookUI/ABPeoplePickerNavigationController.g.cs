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
using GLKit;
using Metal;
using CoreML;
using MapKit;
using Photos;
using ModelIO;
using Network;
using SceneKit;
using Contacts;
using Security;
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
using NewsstandKit;
using FileProvider;
using CoreAnimation;
using CoreFoundation;
using NetworkExtension;
using MetalPerformanceShadersGraph;
#nullable enable
namespace AddressBookUI {
	/// <summary>A <see cref="T:UIKit.UINavigationController" /> that allows the application user to select a contact or contact information from an <see cref="T:AddressBook.ABAddressBook" />.</summary><remarks><para>In iOS 8 and later bringing up a people-picker navigtion controller does not require the app to have access to a user’s contacts, and the user will not be prompted to grant access. If the app does not itself have access to the user’s contacts, a temporary copy of the contact selected by the user will be returned to the app.</para><para><format type="text/html"><span>See a <a href="https://github.com/xamarin/monotouch-samples/tree/master/ios8/PeoplePicker">sample project</a> illustrating the use of a people-picker navigation controller.</span></format></para><para>
	/// 	With the introduction of iOS 8.0, it is possible to filter the
	/// 	information displayed by setting one or more of the Predicate
	/// 	properties in this class.   
	/// </para><para>
	/// 	The predicates are: <see cref="P:AddressBookUI.ABPeoplePickerNavigationController.PredicateForEnablingPerson" />,
	/// 	<see cref="P:AddressBookUI.ABPeoplePickerNavigationController.PredicateForSelectionOfPerson" />
	/// 	and <see cref="P:AddressBookUI.ABPeoplePickerNavigationController.PredicateForSelectionOfProperty" />.
	/// </para><para>
	/// 	The predicates can use the various members in <see cref="T:AddressBookUI.ABPersonPredicateKey" /> as
	/// 	constants in the above predicates, or you can use the hardcoded strings shown below.
	/// </para><para>
	/// 	Each one of these properties has either a native type (like a
	/// 	string), an array of elements or is a structured type that
	/// 	contains elements that you can access from the predicate
	/// 	expression.
	/// 
	/// </para><list type="table"><listheader><term>Structured Type Name</term><description>Property Contents</description><description></description></listheader><item><term>LabeledValue</term><description>'label' and 'value'.</description></item><item><term>PhoneNumber</term><description>'stringValue', 'countryCode', 'formattedStringValue' and 'normalizedStringValue'</description></item><item><term>InstantMessageAddress</term><description>'username' and 'service'</description></item><item><term>SocialProfile</term><description>'username' and 'service'</description></item><item><term>PostalAddress</term><description>'street' property, 'subLocality' property, 'city' property, 'subAdministrativeArea' property, 'state' property, 'postalCode' property, 'country/region' and 'ISOCountryCode'.</description></item></list><list type="table"><listheader><term>ABPersonPredicateKey</term><description>String Name</description><description>Key value</description></listheader><item><term>NamePrefix</term><description>"namePrefix"</description><description>string</description></item><item><term>GivenName</term><description>"givenName"</description><description>string</description></item><item><term>MiddleName</term><description>"middleName"</description><description>string</description></item><item><term>FamilyName</term><description>"familyName"</description><description>string</description></item><item><term>NameSuffix</term><description>"nameSuffix"</description><description>string</description></item><item><term>PreviousFamilyName</term><description>"previousFamilyName"</description><description>string</description></item><item><term>Nickname</term><description>"nickname"</description><description>string</description></item><item><term>PhoneticGivenName</term><description>"phoneticGivenName"</description><description>string</description></item><item><term>PhoneticMiddleName</term><description>"phoneticMiddleName"</description><description>string</description></item><item><term>PhoneticFamilyName</term><description>"phoneticFamilyName"</description><description>string</description></item><item><term>OrganizationName</term><description>"organizationName"</description><description>string</description></item><item><term>DepartmentName</term><description>"departmentName"</description><description>string</description></item><item><term>JobTitle</term><description>"jobTitle"</description><description>string</description></item><item><term>Birthday</term><description>"birthday"</description><description>NSDateComponents</description></item><item><term>Note</term><description>"note"</description><description>string</description></item><item><term>PhoneNumbers</term><description>"phoneNumbers"</description><description>Array of LabeledValue with PhoneNumber values</description></item><item><term>EmailAddresses</term><description>"emailAddresses"</description><description>array of LabeledValue with string values</description></item><item><term>UrlAddresses</term><description>"urlAddresses"</description><description>array of LabeledValue with string values</description></item><item><term>Dates</term><description>"dates"</description><description>array of LabeledValue with NSDateComponents values</description></item><item><term>InstantMessageAddresses</term><description>"instantMessageAddresses"</description><description>array of LabeledValue with InstantMessageAddress values</description></item><item><term>RelatedNames</term><description>"relatedNames"</description><description>array of LabeledValue with string values</description></item><item><term>SocialProfiles</term><description>"socialProfiles"</description><description>array of LabeledValue with SocialProfile values</description></item><item><term>PostalAddresses</term><description>"postalAddresses"</description><description>array of LabeledValue with PostalAddress values</description></item></list><example><code lang="csharp lang-csharp"><![CDATA[[Register ("CompatibleEmailPickerViewController")]
	/// public class CompatibleEmailPickerViewController : UIViewController
	/// {
	/// [Outlet]
	/// UILabel ResultLabel { get ; set; }
	/// 
	/// public CompatibleEmailPickerViewController (IntPtr handle)
	/// : base (handle)
	/// {
	/// }
	/// 
	/// [Export("showPicker:")]
	/// void ShowPicker(NSObject sender)
	/// {
	/// ABPeoplePickerNavigationController picker = new ABPeoplePickerNavigationController ();
	/// 
	/// 	// Hook up to both events to support iOS 7 and iOS 8 idioms
	/// 
	/// 	// Hooks up to the iOS 7 and lower idioms
	/// picker.SelectPerson += HandleSelectPerson;
	/// picker.PerformAction += HandlePerformAction;
	/// 
	/// 	// Hook up to the new iOS 8 idioms and parameters
	/// picker.SelectPerson2 += HandleSelectPerson2;
	/// picker.PerformAction2 += HandlePerformAction2;
	/// 
	/// picker.Cancelled += HandleCancelled;
	/// 
	/// // The people picker will only display the person's name, 
	/// 	// image and email properties in ABPersonViewController.
	/// picker.DisplayedProperties.Add (ABPersonProperty.Email);
	/// 
	/// // The people picker will enable selection 
	/// 	// of persons that have at least one email address.
	/// if(picker.RespondsToSelector(new Selector("setPredicateForEnablingPerson:")))
	/// picker.PredicateForEnablingPerson = NSPredicate.FromFormat ("emailAddresses.@count > 0");
	/// 
	/// // The people picker will select a person that has exactly one email address and 
	/// 	// call peoplePickerNavigationController:didSelectPerson:,
	/// // otherwise the people picker will present an ABPersonViewController for the 
	/// 	// user to pick one of the email addresses.
	/// if(picker.RespondsToSelector(new Selector("setPredicateForSelectionOfPerson:")))
	/// picker.PredicateForSelectionOfPerson = NSPredicate.FromFormat ("emailAddresses.@count = 1");
	/// 
	/// PresentViewController (picker, true, null);
	/// }
	/// 
	/// // iOS7 and below
	/// void HandleSelectPerson (object sender, ABPeoplePickerSelectPersonEventArgs e)
	/// {
	/// var peoplePicker = (ABPeoplePickerNavigationController)sender;
	/// 
	/// e.Continue = false;
	/// using (ABMultiValue<string> emails = e.Person.GetEmails ())
	/// e.Continue = emails.Count == 1;
	/// 
	/// if (!e.Continue) {
	/// ResultLabel.Text = PersonFormatter.GetPickedEmail (e.Person);
	/// peoplePicker.DismissViewController (true, null);
	/// }
	/// }
	/// 
	/// // iOS8+
	/// void HandleSelectPerson2 (object sender, ABPeoplePickerSelectPerson2EventArgs e)
	/// {
	/// ResultLabel.Text = PersonFormatter.GetPickedEmail (e.Person);
	/// }
	/// 
	/// // iOS7 and below
	/// void HandlePerformAction (object sender, ABPeoplePickerPerformActionEventArgs e)
	/// {
	/// var peoplePicker = (ABPeoplePickerNavigationController)sender;
	/// 
	/// ResultLabel.Text = PersonFormatter.GetPickedEmail (e.Person, e.Identifier);
	/// peoplePicker.DismissViewController (true, null);
	/// 
	/// e.Continue = false;
	/// }
	/// 
	/// // iOS8+
	/// void HandlePerformAction2 (object sender, ABPeoplePickerPerformAction2EventArgs e)
	/// {
	/// ResultLabel.Text = PersonFormatter.GetPickedEmail (e.Person, e.Identifier);
	/// }
	/// 
	/// void HandleCancelled (object sender, EventArgs e)
	/// {
	/// var peoplePicker = (ABPeoplePickerNavigationController)sender;
	/// peoplePicker.DismissViewController (true, null);
	/// }
	/// }]]></code></example>.</remarks><related type="externalDocumentation" href="https://developer.apple.com/library/ios/documentation/AddressBookUI/Reference/ABPeoplePickerNavigationController_Class/index.html">Apple documentation for <c>ABPeoplePickerNavigationController</c></related>
	[Register("ABPeoplePickerNavigationController", true)]
	[ObsoletedOSPlatform ("ios9.0", "Use the 'Contacts' API instead.")]
	[SupportedOSPlatform ("ios")]
	[UnsupportedOSPlatform ("maccatalyst")]
	public unsafe partial class ABPeoplePickerNavigationController : global::UIKit.UINavigationController, global::UIKit.IUIAppearance {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly NativeHandle class_ptr = Class.GetHandle ("ABPeoplePickerNavigationController");
		/// <summary>The Objective-C class handle for this class.</summary>
		/// <value>The pointer to the Objective-C class.</value>
		/// <remarks>
		///     Each managed class mirrors an unmanaged Objective-C class.
		///     This value contains the pointer to the Objective-C class.
		///     It is similar to calling the managed <see cref="ObjCRuntime.Class.GetHandle(string)" /> or the native <see href="https://developer.apple.com/documentation/objectivec/1418952-objc_getclass">objc_getClass</see> method with the type name.
		/// </remarks>
		public override NativeHandle ClassHandle { get { return class_ptr; } }
		/// <summary>Creates a new <see cref="ABPeoplePickerNavigationController" /> with default values.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public ABPeoplePickerNavigationController () : base (NSObjectFlag.Empty)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
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
		public ABPeoplePickerNavigationController (NSCoder coder) : base (NSObjectFlag.Empty)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
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
		protected ABPeoplePickerNavigationController (NSObjectFlag t) : base (t)
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
		protected internal ABPeoplePickerNavigationController (NativeHandle handle) : base (handle)
		{
		}

		/// <param name="nibName"><para>To be added.</para><para tool="nullallowed">This parameter can be <see langword="null" />.</para></param><param name="bundle"><para>To be added.</para><para tool="nullallowed">This parameter can be <see langword="null" />.</para></param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("initWithNibName:bundle:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public ABPeoplePickerNavigationController (string? nibName, NSBundle? bundle)
			: base (NSObjectFlag.Empty)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var bundle__handle__ = bundle.GetHandle ();
			var nsnibName = CFString.CreateNative (nibName);
			if (IsDirectBinding) {
				InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("initWithNibName:bundle:"), nsnibName, bundle__handle__), "initWithNibName:bundle:");
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, Selector.GetHandle ("initWithNibName:bundle:"), nsnibName, bundle__handle__), "initWithNibName:bundle:");
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (bundle);
			CFString.ReleaseNative (nsnibName);
			#pragma warning disable 168
			#pragma warning restore 168
		}
		/// <param name="rootViewController">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("initWithRootViewController:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public ABPeoplePickerNavigationController (global::UIKit.UIViewController rootViewController)
			: base (NSObjectFlag.Empty)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var rootViewController__handle__ = rootViewController!.GetNonNullHandle (nameof (rootViewController));
			if (IsDirectBinding) {
				InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("initWithRootViewController:"), rootViewController__handle__), "initWithRootViewController:");
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle (&__objc_super__, Selector.GetHandle ("initWithRootViewController:"), rootViewController__handle__), "initWithRootViewController:");
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (rootViewController);
			#pragma warning disable 168
			#pragma warning restore 168
		}
		/// <summary>An instance of the AddressBookUI.IABPeoplePickerNavigationControllerDelegate model class which acts as the class delegate.</summary><value>The instance of the AddressBookUI.IABPeoplePickerNavigationControllerDelegate model class</value><remarks><para>The delegate instance assigned to this object will be used to handle events or provide data on demand to this class.</para><para>When setting the Delegate or WeakDelegate values events will be delivered to the specified instance instead of being delivered to the C#-style events</para><para>This is the strongly typed version of the object, developers should use the WeakDelegate property instead if they want to merely assign a class derived from NSObject that has been decorated with [Export] attributes.</para></remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public IABPeoplePickerNavigationControllerDelegate Delegate {
			get {
				return (WeakDelegate as IABPeoplePickerNavigationControllerDelegate)!;
			}
			set {
				var rvalue = value as NSObject;
				if (!(value is null) && rvalue is null)
					throw new ArgumentException ("The object passed of type " + value.GetType () + " does not derive from NSObject");
				WeakDelegate = rvalue;
			}
		}
		/// <summary>Use this property to set a predicate that determines whether the person can be selected or not.</summary><value><para>If the value is null, all persons are selectable;  Otherwise only those persons that match the predicate will be.</para><para tool="nullallowed">This value can be <see langword="null" />.</para></value><remarks></remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSPredicate? PredicateForEnablingPerson {
			[Export ("predicateForEnablingPerson", ArgumentSemantic.Copy)]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				NSPredicate? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSPredicate> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("predicateForEnablingPerson")), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<NSPredicate> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("predicateForEnablingPerson")), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setPredicateForEnablingPerson:", ArgumentSemantic.Copy)]
			set {
				global::UIKit.UIApplication.EnsureUIThread ();
				var value__handle__ = value.GetHandle ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("setPredicateForEnablingPerson:"), value__handle__);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, Selector.GetHandle ("setPredicateForEnablingPerson:"), value__handle__);
						GC.KeepAlive (this);
					}
				}
				GC.KeepAlive (value);
			}
		}
		/// <summary>Use this property to set a predicate that determines whether the person should be returned to the app, or displayed to the user.</summary><value><para>If set, the predicate that determines whether to return the person to the app (the predicate evaluates to true) or displayed (the predicate evaluates to false).</para><para>If the value is not set, the decision on whether the person is returned or displayed rests on the methods from the <see cref="T:AddressBookUI.ABPeoplePickerNavigationControllerDelegate" /> delegate.</para><para tool="nullallowed">This value can be <see langword="null" />.</para></value><remarks></remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSPredicate? PredicateForSelectionOfPerson {
			[Export ("predicateForSelectionOfPerson", ArgumentSemantic.Copy)]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				NSPredicate? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSPredicate> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("predicateForSelectionOfPerson")), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<NSPredicate> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("predicateForSelectionOfPerson")), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setPredicateForSelectionOfPerson:", ArgumentSemantic.Copy)]
			set {
				global::UIKit.UIApplication.EnsureUIThread ();
				var value__handle__ = value.GetHandle ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("setPredicateForSelectionOfPerson:"), value__handle__);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, Selector.GetHandle ("setPredicateForSelectionOfPerson:"), value__handle__);
						GC.KeepAlive (this);
					}
				}
				GC.KeepAlive (value);
			}
		}
		/// <summary>To be added.</summary><value><para>(More documentation for this node is coming)</para><para tool="nullallowed">This value can be <see langword="null" />.</para></value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSPredicate? PredicateForSelectionOfProperty {
			[Export ("predicateForSelectionOfProperty", ArgumentSemantic.Copy)]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				NSPredicate? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSPredicate> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("predicateForSelectionOfProperty")), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<NSPredicate> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("predicateForSelectionOfProperty")), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setPredicateForSelectionOfProperty:", ArgumentSemantic.Copy)]
			set {
				global::UIKit.UIApplication.EnsureUIThread ();
				var value__handle__ = value.GetHandle ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("setPredicateForSelectionOfProperty:"), value__handle__);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, Selector.GetHandle ("setPredicateForSelectionOfProperty:"), value__handle__);
						GC.KeepAlive (this);
					}
				}
				GC.KeepAlive (value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		object? __mt_WeakDelegate_var;
		/// <summary>An object that can respond to the delegate protocol for this type</summary><value>The instance that will respond to events and data requests.</value><remarks><para>The delegate instance assigned to this object will be used to handle events or provide data on demand to this class.</para><para>When setting the Delegate or WeakDelegate values events will be delivered to the specified instance instead of being delivered to the C#-style events</para><para>   Methods must be decorated with the [Export ("selectorName")] attribute to respond to each method from the protocol.   Alternatively use the Delegate method which is strongly typed and does not require the [Export] attributes on methods.</para></remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSObject? WeakDelegate {
			[Export ("peoplePickerDelegate", ArgumentSemantic.Assign)]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				NSObject? ret;
				if (IsDirectBinding) {
					ret = Runtime.GetNSObject (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("peoplePickerDelegate")), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = Runtime.GetNSObject (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("peoplePickerDelegate")), false)!;
						GC.KeepAlive (this);
					}
				}
				MarkDirty ();
				__mt_WeakDelegate_var = ret;
				return ret!;
			}
			[Export ("setPeoplePickerDelegate:", ArgumentSemantic.Assign)]
			set {
				global::UIKit.UIApplication.EnsureUIThread ();
				var value__handle__ = value.GetHandle ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("setPeoplePickerDelegate:"), value__handle__);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, Selector.GetHandle ("setPeoplePickerDelegate:"), value__handle__);
						GC.KeepAlive (this);
					}
				}
				GC.KeepAlive (value);
				MarkDirty ();
				__mt_WeakDelegate_var = value;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal virtual nint _AddressBook {
			[Export ("addressBook")]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				nint ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("addressBook"));
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("addressBook"));
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[Export ("setAddressBook:")]
			set {
				global::UIKit.UIApplication.EnsureUIThread ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setAddressBook:"), value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (&__objc_super__, Selector.GetHandle ("setAddressBook:"), value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal virtual NSNumber[]? _DisplayedProperties {
			[Export ("displayedProperties", ArgumentSemantic.Copy)]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				NSNumber[]? ret;
				if (IsDirectBinding) {
					ret = CFArray.ArrayFromHandle<NSNumber>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("displayedProperties")), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFArray.ArrayFromHandle<NSNumber>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("displayedProperties")), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setDisplayedProperties:", ArgumentSemantic.Copy)]
			set {
				global::UIKit.UIApplication.EnsureUIThread ();
				using var nsa_value = value is null ? null : NSArray.FromNSObjects (value);
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("setDisplayedProperties:"), nsa_value.GetHandle ());
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, Selector.GetHandle ("setDisplayedProperties:"), nsa_value.GetHandle ());
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		protected override void Dispose (bool disposing)
		{
			base.Dispose (disposing);
			if (Handle == IntPtr.Zero) {
				__mt_WeakDelegate_var = null;
			}
		}
		/// <summary>Appearance class for objects of type <see cref="global::AddressBookUI.ABPeoplePickerNavigationController" />.</summary>
		/// <remarks>
		///     <para>This appearance class is a strongly typed subclass of UIAppearance that is intended to be used with objects of class <see cref="global::AddressBookUI.ABPeoplePickerNavigationController" />.</para>
		///     <para>You can obtain an instance to this class by either accessing the static <see cref="global::AddressBookUI.ABPeoplePickerNavigationController.Appearance" /> property or by calling <see cref="global::AddressBookUI.ABPeoplePickerNavigationController.AppearanceWhenContainedIn(System.Type[])" /> to get a UIAppearance that is context sensitive.</para>
		/// </remarks>
		public partial class ABPeoplePickerNavigationControllerAppearance : UIAppearance {
			protected internal ABPeoplePickerNavigationControllerAppearance (IntPtr handle) : base (handle) {}
		}
		/// <summary>Strongly-typed property that returns the UIAppearance class for this class.</summary>
		/// <remarks>
		///   <para>Setting any appearance properties on this instance will affect the appearance of all instances of <see cref="global::AddressBookUI.ABPeoplePickerNavigationController" />.</para>
		///   <para>If developers want to control the appearance of subclasses of <see cref="global::AddressBookUI.ABPeoplePickerNavigationController" />, they should use the <see cref="global::AddressBookUI.ABPeoplePickerNavigationController.GetAppearance&lt;T&gt;(UIKit.UITraitCollection,System.Type[])" /> method.</para>
		/// </remarks>
		public static ABPeoplePickerNavigationControllerAppearance Appearance {
			get { return new ABPeoplePickerNavigationControllerAppearance (global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (class_ptr, ObjCRuntime.Selector.GetHandle ("appearance"))); }
		}
		/// <summary>Obtains the appearance proxy <see cref="global::AddressBookUI.ABPeoplePickerNavigationController.ABPeoplePickerNavigationControllerAppearance" /> for the subclass of <see cref="global::AddressBookUI.ABPeoplePickerNavigationController" />.</summary>
		/// <typeparam name="T">The type for which the <see cref="global::UIKit.UIAppearance" /> proxy must be returned.  This is a subclass of <see cref="global::AddressBookUI.ABPeoplePickerNavigationController" />.</typeparam>
		/// <returns>
		///   <para>An appearance proxy object for the specified type.</para>
		/// </returns>
		/// <remarks>
		///   <para>Setting any appearance properties on the returned object will affect the appearance of all classes and subclasses of the type parameter.</para>
		///   <para>Unlike the <see cref="global::AddressBookUI.ABPeoplePickerNavigationController.Appearance" /> property, or the <see cref="global::AddressBookUI.ABPeoplePickerNavigationController.AppearanceWhenContainedIn(System.Type[])" /> method which only work on instances of this particular class, the proxies returned by this method can be used to change the style of subclasses.</para>
		///   <para>The following example shows how this method works:</para>
		///   <example>
		///   <code lang="csharp lang-csharp"><![CDATA[
		///var myTheme = ABPeoplePickerNavigationController.GetAppearance<MyABPeoplePickerNavigationControllerSubclass> ();
		///myTheme.TintColor = UIColor.Red;
		///]]></code>
		///   </example>
		///   <para>For more information, see the documentation for the <see cref="global::UIKit.UIAppearance" /> class.</para>
		/// </remarks>
		public static ABPeoplePickerNavigationControllerAppearance GetAppearance<T> () where T: ABPeoplePickerNavigationController {
			return new ABPeoplePickerNavigationControllerAppearance (global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (Class.GetHandle (typeof (T)), ObjCRuntime.Selector.GetHandle ("appearance")));
		}
		/// <param name="containers">List of types that developers want to have as the containers to apply this particular appearance</param>
		/// <summary>Returns a strongly typed <see cref="global::UIKit.UIAppearance" /> for instances of this class when the view is hosted in the specified hierarchy.</summary>
		/// <returns>The appearance proxy object that developers can use to set properties when the given container hierarchy is active</returns>
		/// <remarks>
		///   <para>The returned object represents the <see cref="global::UIKit.UIAppearance" /> proxy where developers can set appearance properties for instances of <see cref="global::AddressBookUI.ABPeoplePickerNavigationController" /> when those instances are contained in the hierarchy specified by the <paramref name="containers" /> parameter.</para>
		///   <para>If developers want to control the appearance of subclasses of <see cref="global::AddressBookUI.ABPeoplePickerNavigationController" />, they should use the <see cref="global::AddressBookUI.ABPeoplePickerNavigationController.GetAppearance&lt;T&gt;(UIKit.UITraitCollection,System.Type[])" /> method.</para>
		///   <para>The following example shows how this method works:</para>
		///   <example>
		///     <code lang="csharp lang-csharp"><![CDATA[
		///var mySliders = UISlider.AppearanceWhenContainedIn (typeof (UINavigationBar), typeof (UIPopoverController));
		///mySliders.TintColor = UIColor.Red;
		///]]></code>
		///   </example>
		///   <para>For more information, see the documentation for the <see cref="global::UIKit.UIAppearance" /> class.</para>
		/// </remarks>
		public static ABPeoplePickerNavigationControllerAppearance AppearanceWhenContainedIn (params Type [] containers)
		{
			return new ABPeoplePickerNavigationControllerAppearance (UIAppearance.GetAppearance (class_ptr, containers));
		}
		/// <summary>Obtains the appearance proxy <see cref="global::AddressBookUI.ABPeoplePickerNavigationController.ABPeoplePickerNavigationControllerAppearance" /> for <see cref="global::AddressBookUI.ABPeoplePickerNavigationController" />.</summary>
		/// <param name="traits">Trait collection to match.</param>
		/// <returns>
		///   <para>An appearance proxy object for the specified type.</para>
		/// </returns>
		/// <remarks>
		///   <para>The following example shows how this method works:</para>
		///   <example>
		///   <code lang="csharp lang-csharp"><![CDATA[
		///var myTraits = new UITraitCollection ();
		///var myTheme = ABPeoplePickerNavigationController.GetAppearance (myTraits);
		///myTheme.TintColor = UIColor.Red;
		///]]></code>
		///   </example>
		///   <para>If developers want to control the appearance of subclasses of <see cref="global::AddressBookUI.ABPeoplePickerNavigationController" />, they should use the <see cref="global::AddressBookUI.ABPeoplePickerNavigationController.GetAppearance&lt;T&gt;(UIKit.UITraitCollection)" /> method.</para>
		///   <para>For more information, see the documentation for the <see cref="global::UIKit.UIAppearance" /> class.</para>
		/// </remarks>
		public static ABPeoplePickerNavigationControllerAppearance GetAppearance (UITraitCollection traits) {
			return new ABPeoplePickerNavigationControllerAppearance (UIAppearance.GetAppearance (class_ptr, traits));
		}
		/// <summary>Obtains the appearance proxy <see cref="global::AddressBookUI.ABPeoplePickerNavigationController.ABPeoplePickerNavigationControllerAppearance" /> for <see cref="global::AddressBookUI.ABPeoplePickerNavigationController" />.</summary>
		/// <param name="traits">Trait collection to match.</param>
		/// <param name="containers">List of types that the developer wishes to have as the containers to apply this particular appearance.</param>
		/// <returns>
		///   <para>An appearance proxy object for the specified type.</para>
		/// </returns>
		/// <remarks>
		///   <para>The following example shows how this method works:</para>
		///   <example>
		///   <code lang="csharp lang-csharp"><![CDATA[
		///var myTraits = new UITraitCollection ();
		///var myTheme = ABPeoplePickerNavigationController.GetAppearance (myTraits, typeof (UINavigationBar), typeof (UIPopoverController));
		///myTheme.TintColor = UIColor.Red;
		///]]></code>
		///   </example>
		///   <para>If developers want to control the appearance of subclasses of <see cref="global::AddressBookUI.ABPeoplePickerNavigationController" />, they should use the <see cref="global::AddressBookUI.ABPeoplePickerNavigationController.GetAppearance&lt;T&gt;(UIKit.UITraitCollection,System.Type[])" /> method.</para>
		///   <para>For more information, see the documentation for the <see cref="global::UIKit.UIAppearance" /> class.</para>
		/// </remarks>
		public static ABPeoplePickerNavigationControllerAppearance GetAppearance (UITraitCollection traits, params Type [] containers) {
			return new ABPeoplePickerNavigationControllerAppearance (UIAppearance.GetAppearance (class_ptr, traits, containers));
		}
		/// <summary>Obtains the appearance proxy <see cref="global::AddressBookUI.ABPeoplePickerNavigationController.ABPeoplePickerNavigationControllerAppearance" /> for the subclass of <see cref="global::AddressBookUI.ABPeoplePickerNavigationController" />.</summary>
		/// <typeparam name="T">The type for which the <see cref="global::UIKit.UIAppearance" /> proxy must be returned.  This is a subclass of <see cref="global::AddressBookUI.ABPeoplePickerNavigationController" />.</typeparam>
		/// <param name="traits">Trait collection to match.</param>
		/// <returns>
		///   <para>An appearance proxy object for the specified type.</para>
		/// </returns>
		/// <remarks>
		///   <para>Setting any appearance properties on the returned object will affect the appearance of all classes and subclasses of the type parameter.</para>
		///   <para>Unlike the <see cref="global::AddressBookUI.ABPeoplePickerNavigationController.Appearance" /> property, or the <see cref="global::AddressBookUI.ABPeoplePickerNavigationController.AppearanceWhenContainedIn(System.Type[])" /> method which only work on instances of this particular class, the proxies returned by this method can be used to change the style of subclasses.</para>
		///   <para>The following example shows how this method works:</para>
		///   <example>
		///   <code lang="csharp lang-csharp"><![CDATA[
		///var myTraits = new UITraitCollection ();
		///var myTheme = ABPeoplePickerNavigationController.GetAppearance<MyABPeoplePickerNavigationControllerSubclass> (myTraits);
		///myTheme.TintColor = UIColor.Red;
		///]]></code>
		///   </example>
		///   <para>For more information, see the documentation for the <see cref="global::UIKit.UIAppearance" /> class.</para>
		/// </remarks>
		public static ABPeoplePickerNavigationControllerAppearance GetAppearance<T> (UITraitCollection traits) where T: ABPeoplePickerNavigationController {
			return new ABPeoplePickerNavigationControllerAppearance (UIAppearance.GetAppearance (Class.GetHandle (typeof (T)), traits));
		}
		/// <summary>Obtains the appearance proxy <see cref="global::AddressBookUI.ABPeoplePickerNavigationController.ABPeoplePickerNavigationControllerAppearance" /> for the subclass of <see cref="global::AddressBookUI.ABPeoplePickerNavigationController" />.</summary>
		/// <typeparam name="T">The type for which the <see cref="global::UIKit.UIAppearance" /> proxy must be returned.  This is a subclass of <see cref="global::AddressBookUI.ABPeoplePickerNavigationController" />.</typeparam>
		/// <param name="traits">Trait collection to match.</param>
		/// <param name="containers">List of types that the developer wishes to have as the containers to apply this particular appearance.</param>
		/// <returns>
		///   <para>An appearance proxy object for the specified type.</para>
		/// </returns>
		/// <remarks>
		///   <para>Setting any appearance properties on the returned object will affect the appearance of all classes and subclasses of the type parameter.</para>
		///   <para>Unlike the <see cref="global::AddressBookUI.ABPeoplePickerNavigationController.Appearance" /> property, or the <see cref="global::AddressBookUI.ABPeoplePickerNavigationController.AppearanceWhenContainedIn(System.Type[])" /> method which only work on instances of this particular class, the proxies returned by this method can be used to change the style of subclasses.</para>
		///   <para>The following example shows how this method works:</para>
		///   <example>
		///   <code lang="csharp lang-csharp"><![CDATA[
		///var myTraits = new UITraitCollection ();
		///var myTheme = ABPeoplePickerNavigationController.GetAppearance<MyABPeoplePickerNavigationControllerSubclass> (myTraits, typeof (UINavigationBar), typeof (UIPopoverController));
		///myTheme.TintColor = UIColor.Red;
		///]]></code>
		///   </example>
		///   <para>For more information, see the documentation for the <see cref="global::UIKit.UIAppearance" /> class.</para>
		/// </remarks>
		public static ABPeoplePickerNavigationControllerAppearance GetAppearance<T> (UITraitCollection traits, params Type [] containers) where T: ABPeoplePickerNavigationController{
			return new ABPeoplePickerNavigationControllerAppearance (UIAppearance.GetAppearance (Class.GetHandle (typeof (T)), containers));
		}
	} /* class ABPeoplePickerNavigationController */
}
