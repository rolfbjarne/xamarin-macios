//
// IntentsUI bindings
//
// Authors:
//	Alex Soto  <alexsoto@microsoft.com>
//
// Copyright 2016 Xamarin Inc. All rights reserved.
//

using CoreGraphics;
using Intents;
#if MONOMAC
using AppKit;
#else
using UIKit;
#endif

namespace IntentsUI {

	[NoMac]
	[MacCatalyst (13, 1)]
	[Native]
	public enum INUIHostedViewContext : ulong {
		/// <summary>Indicates siri snippet.</summary>
		SiriSnippet,
		/// <summary>Indicates maps card.</summary>
		MapsCard,
	}

	[NoMac]
	[Native]
	public enum INUIInteractiveBehavior : ulong {
		/// <summary>Indicates none.</summary>
		None,
		/// <summary>Indicates next view.</summary>
		NextView,
		/// <summary>Indicates launch.</summary>
		Launch,
		/// <summary>Indicates generic action.</summary>
		GenericAction,
	}

	[NoTV]
	[MacCatalyst (13, 1)]
	[Native]
	public enum INUIAddVoiceShortcutButtonStyle : ulong {
		/// <summary>Indicates white.</summary>
		White = 0,
		/// <summary>Indicates white outline.</summary>
		WhiteOutline,
		/// <summary>Indicates black.</summary>
		Black,
		/// <summary>Indicates black outline.</summary>
		BlackOutline,
		[iOS (13, 0)]
		[MacCatalyst (13, 1)]
		Automatic,
		[iOS (13, 0)]
		[MacCatalyst (13, 1)]
		AutomaticOutLine,
	}

	[NoMac]
	[MacCatalyst (13, 1)]
	delegate void INUIHostedViewControllingConfigureViewHandler (bool success, NSSet<INParameter> configuredParameters, CGSize desiredSize);

	[NoMac]
	[MacCatalyst (13, 1)]
	[Protocol]
	interface INUIHostedViewControlling {
		/// <param name="interaction">The interaction.</param>
		/// <param name="context">The context to use.</param>
		/// <param name="completion">The completion.</param>
		/// <summary>To be added.</summary>
		[Export ("configureWithInteraction:context:completion:")]
		void Configure (INInteraction interaction, INUIHostedViewContext context, Action<CGSize> completion);

		/// <param name="parameters">The parameters.</param>
		/// <param name="interaction">The interaction.</param>
		/// <param name="interactiveBehavior">The interactive behavior.</param>
		/// <param name="context">The context to use.</param>
		/// <param name="completionHandler">The completion handler to call when the operation completes.</param>
		/// <summary>To be added.</summary>
		[MacCatalyst (13, 1)]
		[Export ("configureViewForParameters:ofInteraction:interactiveBehavior:context:completion:")]
		void ConfigureView (NSSet<INParameter> parameters, INInteraction interaction, INUIInteractiveBehavior interactiveBehavior, INUIHostedViewContext context, INUIHostedViewControllingConfigureViewHandler completionHandler);
	}

	/// <summary>Interface for presenting custom map and Siri content.</summary>
	[NoMac]
	[MacCatalyst (13, 1)]
	[Category]
	[BaseType (typeof (NSExtensionContext))]
	interface NSExtensionContext_INUIHostedViewControlling {

		/// <summary>To be added.</summary>
		/// <returns>To be added.</returns>
		[Export ("hostedViewMinimumAllowedSize")]
		CGSize GetHostedViewMinimumAllowedSize ();

		/// <summary>To be added.</summary>
		/// <returns>To be added.</returns>
		[Export ("hostedViewMaximumAllowedSize")]
		CGSize GetHostedViewMaximumAllowedSize ();

		/// <summary>To be added.</summary>
		/// <returns>To be added.</returns>
		[MacCatalyst (13, 1)]
		[Export ("interfaceParametersDescription")]
		string GetInterfaceParametersDescription ();
	}

	[NoMac]
	[MacCatalyst (13, 1)]
	[Protocol]
	interface INUIHostedViewSiriProviding {

		[Export ("displaysMap")]
		bool DisplaysMap { get; }

		[Export ("displaysMessage")]
		bool DisplaysMessage { get; }

		[Export ("displaysPaymentTransaction")]
		bool DisplaysPaymentTransaction { get; }
	}

	[MacCatalyst (13, 1)]
#if MONOMAC
	[BaseType (typeof (NSViewController))]
#else
	[BaseType (typeof (UIViewController))]
#endif
	[DisableDefaultCtor]
	interface INUIAddVoiceShortcutViewController {

		/// <summary>An instance of the IntentsUI.IINUIAddVoiceShortcutViewControllerDelegate model class which acts as the class delegate.</summary>
		///         <value>The instance of the IntentsUI.IINUIAddVoiceShortcutViewControllerDelegate model class</value>
		///         <remarks>
		///           <para>The delegate instance assigned to this object will be used to handle events or provide data on demand to this class.</para>
		///           <para>When setting the Delegate or WeakDelegate values events will be delivered to the specified instance instead of being delivered to the C#-style events</para>
		///           <para>This is the strongly typed version of the object, developers should use the WeakDelegate property instead if they want to merely assign a class derived from NSObject that has been decorated with [Export] attributes.</para>
		///         </remarks>
		[Wrap ("WeakDelegate")]
		[NullAllowed]
		IINUIAddVoiceShortcutViewControllerDelegate Delegate { get; set; }

		[NullAllowed, Export ("delegate", ArgumentSemantic.Weak)]
		NSObject WeakDelegate { get; set; }

		[MacCatalyst (13, 4)]
		[Export ("initWithShortcut:")]
		NativeHandle Constructor (INShortcut shortcut);
	}

	interface IINUIAddVoiceShortcutViewControllerDelegate { }

	[MacCatalyst (13, 1)]
	[Protocol, Model]
	[BaseType (typeof (NSObject))]
	interface INUIAddVoiceShortcutViewControllerDelegate {

		/// <param name="controller">The controller.</param>
		/// <param name="voiceShortcut">The voice shortcut.</param>
		/// <param name="error">The error that occurred, or <see langword="null" /> if no error occurred.</param>
		/// <summary>To be added.</summary>
		[Abstract]
		[Export ("addVoiceShortcutViewController:didFinishWithVoiceShortcut:error:")]
		void DidFinish (INUIAddVoiceShortcutViewController controller, [NullAllowed] INVoiceShortcut voiceShortcut, [NullAllowed] NSError error);

		/// <param name="controller">The controller.</param>
		/// <summary>To be added.</summary>
		[Abstract]
		[Export ("addVoiceShortcutViewControllerDidCancel:")]
		void DidCancel (INUIAddVoiceShortcutViewController controller);
	}

	[MacCatalyst (13, 1)]
#if MONOMAC
	[BaseType (typeof (NSViewController))]
#else
	[BaseType (typeof (UIViewController))]
#endif
	[DisableDefaultCtor]
	interface INUIEditVoiceShortcutViewController {

		/// <summary>An instance of the IntentsUI.IINUIEditVoiceShortcutViewControllerDelegate model class which acts as the class delegate.</summary>
		///         <value>The instance of the IntentsUI.IINUIEditVoiceShortcutViewControllerDelegate model class</value>
		///         <remarks>
		///           <para>The delegate instance assigned to this object will be used to handle events or provide data on demand to this class.</para>
		///           <para>When setting the Delegate or WeakDelegate values events will be delivered to the specified instance instead of being delivered to the C#-style events</para>
		///           <para>This is the strongly typed version of the object, developers should use the WeakDelegate property instead if they want to merely assign a class derived from NSObject that has been decorated with [Export] attributes.</para>
		///         </remarks>
		[Wrap ("WeakDelegate")]
		[NullAllowed]
		IINUIEditVoiceShortcutViewControllerDelegate Delegate { get; set; }

		[NullAllowed, Export ("delegate", ArgumentSemantic.Weak)]
		NSObject WeakDelegate { get; set; }

		[MacCatalyst (13, 4)]
		[Export ("initWithVoiceShortcut:")]
		NativeHandle Constructor (INVoiceShortcut voiceShortcut);
	}

	interface IINUIEditVoiceShortcutViewControllerDelegate { }

	[MacCatalyst (13, 1)]
	[Protocol, Model]
	[BaseType (typeof (NSObject))]
	interface INUIEditVoiceShortcutViewControllerDelegate {

		/// <param name="controller">The controller.</param>
		/// <param name="voiceShortcut">The voice shortcut.</param>
		/// <param name="error">The error that occurred, or <see langword="null" /> if no error occurred.</param>
		/// <summary>To be added.</summary>
		[Abstract]
		[Export ("editVoiceShortcutViewController:didUpdateVoiceShortcut:error:")]
		void DidUpdate (INUIEditVoiceShortcutViewController controller, [NullAllowed] INVoiceShortcut voiceShortcut, [NullAllowed] NSError error);

		/// <param name="controller">The controller.</param>
		/// <param name="deletedVoiceShortcutIdentifier">The deleted voice shortcut identifier.</param>
		/// <summary>To be added.</summary>
		[Abstract]
		[Export ("editVoiceShortcutViewController:didDeleteVoiceShortcutWithIdentifier:")]
		void DidDelete (INUIEditVoiceShortcutViewController controller, NSUuid deletedVoiceShortcutIdentifier);

		/// <param name="controller">The controller.</param>
		/// <summary>To be added.</summary>
		[Abstract]
		[Export ("editVoiceShortcutViewControllerDidCancel:")]
		void DidCancel (INUIEditVoiceShortcutViewController controller);
	}

	/// <summary>A button that is used to add a Siri shortcut.</summary>
	[NoTV]
	[MacCatalyst (13, 1)]
#if MONOMAC
	[BaseType (typeof (NSButton))]
#else
	[BaseType (typeof (UIButton))]
#endif
	[DisableDefaultCtor]
	interface INUIAddVoiceShortcutButton {

		[MacCatalyst (13, 4)]
		[Export ("initWithStyle:")]
		[DesignatedInitializer]
		NativeHandle Constructor (INUIAddVoiceShortcutButtonStyle style);

		[Export ("style")]
		INUIAddVoiceShortcutButtonStyle Style { get; }

		/// <summary>To be added.</summary>
		///         <value>To be added.</value>
		[Wrap ("WeakDelegate")]
		[NullAllowed]
		IINUIAddVoiceShortcutButtonDelegate Delegate { get; set; }

		[NullAllowed, Export ("delegate", ArgumentSemantic.Weak)]
		NSObject WeakDelegate { get; set; }

		[NullAllowed, Export ("shortcut", ArgumentSemantic.Strong)]
		INShortcut Shortcut { get; set; }

		[MacCatalyst (13, 1)]
		[Export ("cornerRadius", ArgumentSemantic.Assign)]
		nfloat CornerRadius { get; set; }

		[iOS (13, 0)]
		[MacCatalyst (13, 1)]
		[Export ("setStyle:")]
		void SetStyle (INUIAddVoiceShortcutButtonStyle style);
	}

	interface IINUIAddVoiceShortcutButtonDelegate { }

	[NoTV]
	[MacCatalyst (13, 1)]
	[Protocol, Model]
	[BaseType (typeof (NSObject))]
	interface INUIAddVoiceShortcutButtonDelegate {

		/// <param name="addVoiceShortcutViewController">The add voice shortcut view controller.</param>
		/// <param name="addVoiceShortcutButton">The add voice shortcut button.</param>
		/// <summary>To be added.</summary>
		[Abstract]
		[Export ("presentAddVoiceShortcutViewController:forAddVoiceShortcutButton:")]
		void PresentAddVoiceShortcut (INUIAddVoiceShortcutViewController addVoiceShortcutViewController, INUIAddVoiceShortcutButton addVoiceShortcutButton);

		/// <param name="editVoiceShortcutViewController">The edit voice shortcut view controller.</param>
		/// <param name="addVoiceShortcutButton">The add voice shortcut button.</param>
		/// <summary>To be added.</summary>
		[Abstract]
		[Export ("presentEditVoiceShortcutViewController:forAddVoiceShortcutButton:")]
		void PresentEditVoiceShortcut (INUIEditVoiceShortcutViewController editVoiceShortcutViewController, INUIAddVoiceShortcutButton addVoiceShortcutButton);
	}
}
