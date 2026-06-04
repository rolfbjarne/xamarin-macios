//
// MessageUI.cs: This file describes the API that the generator will produce for MessageUI
//
// Authors:
//   Miguel de Icaza
//
// Copyright 2009, Novell, Inc.
//

#nullable enable

using CoreFoundation;

namespace MessageUI {

	/// <summary>Provides data for the <see cref="MessageUI.MFMailComposeViewController.Finished" /> event.</summary>
	///     <remarks />
	public class MFComposeResultEventArgs : EventArgs {
		/// <param name="controller">The controller.</param>
		///         <param name="result">The result.</param>
		///         <param name="error">The error that occurred, or <see langword="null" /> if no error occurred.</param>
		///         <summary>Initializes a new instance of the MFComposeResultEventArgs class.</summary>
		///         <remarks>
		///         </remarks>
		public MFComposeResultEventArgs (MFMailComposeViewController controller, MFMailComposeResult result, NSError? error)
		{
			Result = result;
			Error = error;
			Controller = controller;
		}
		/// <summary>To be added.</summary>
		///         <value>To be added.</value>
		public MFMailComposeResult Result { get; private set; }
		/// <summary>To be added.</summary>
		///         <value>To be added.</value>
		public NSError? Error { get; private set; }
		/// <summary>To be added.</summary>
		///         <value>To be added.</value>
		public MFMailComposeViewController Controller { get; private set; }
	}

	public partial class MFMailComposeViewController {
		Mono_MFMailComposeViewControllerDelegate EnsureDelegate ()
		{
			NSObject? del = WeakMailComposeDelegate;
			if (del is null || (!(del is Mono_MFMailComposeViewControllerDelegate))) {
				del = new Mono_MFMailComposeViewControllerDelegate ();
				WeakMailComposeDelegate = del;
			}
			return (Mono_MFMailComposeViewControllerDelegate) del;
		}

		/// <summary>To be added.</summary>
		public event EventHandler<MFComposeResultEventArgs> Finished {
			add {
				EnsureDelegate ().cbFinished += value;
			}

			remove {
				EnsureDelegate ().cbFinished -= value;
			}
		}
	}

	class Mono_MFMailComposeViewControllerDelegate : MFMailComposeViewControllerDelegate {
		internal EventHandler<MFComposeResultEventArgs>? cbFinished;

		public Mono_MFMailComposeViewControllerDelegate ()
		{
			IsDirectBinding = false;
		}

		[Preserve (Conditional = true)]
		public override void Finished (MFMailComposeViewController controller, MFMailComposeResult result, NSError? error)
		{
			if (cbFinished is not null)
				cbFinished (controller, new MFComposeResultEventArgs (controller, result, error));
		}
	}


	/// <summary>Provides data for the <see cref="MessageUI.MFMessageComposeViewController.Finished" /> event.</summary>
	///     <remarks>
	///     </remarks>
	public class MFMessageComposeResultEventArgs : EventArgs {
		/// <param name="controller">The controller.</param>
		///         <param name="result">The result.</param>
		///         <summary>Initializes a new instance of the MFMessageComposeResultEventArgs class.</summary>
		///         <remarks>
		///         </remarks>
		public MFMessageComposeResultEventArgs (MFMessageComposeViewController controller, MessageComposeResult result)
		{
			Result = result;
			Controller = controller;
		}
		/// <summary>To be added.</summary>
		///         <value>To be added.</value>
		public MessageComposeResult Result { get; private set; }
		/// <summary>To be added.</summary>
		///         <value>To be added.</value>
		public MFMessageComposeViewController Controller { get; private set; }
	}


	public partial class MFMessageComposeViewController {
		Mono_MFMessageComposeViewControllerDelegate EnsureDelegate ()
		{
			NSObject? del = WeakMessageComposeDelegate;
			if (del is null || (!(del is Mono_MFMessageComposeViewControllerDelegate))) {
				del = new Mono_MFMessageComposeViewControllerDelegate ();
				WeakMessageComposeDelegate = del;
			}
			return (Mono_MFMessageComposeViewControllerDelegate) del;
		}

		/// <summary>To be added.</summary>
		public event EventHandler<MFMessageComposeResultEventArgs> Finished {
			add {
				EnsureDelegate ().cbFinished += value;
			}

			remove {
				EnsureDelegate ().cbFinished -= value;
			}
		}
	}

	class Mono_MFMessageComposeViewControllerDelegate : MFMessageComposeViewControllerDelegate {
		internal EventHandler<MFMessageComposeResultEventArgs>? cbFinished;

		public Mono_MFMessageComposeViewControllerDelegate ()
		{
			IsDirectBinding = false;
		}

		[Preserve (Conditional = true)]
		public override void Finished (MFMessageComposeViewController controller, MessageComposeResult result)
		{
			if (cbFinished is not null)
				cbFinished (controller, new MFMessageComposeResultEventArgs (controller, result));
		}
	}


}
