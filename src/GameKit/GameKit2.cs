//
// GameKit.cs: This file describes the API that the generator will produce for GameKit
//
// Authors:
//   Miguel de Icaza
//
// Copyright 2009, Novell, Inc.
// Copyright 2014 Xamarin Inc. All rights reserved
//

using CoreFoundation;

#nullable enable

namespace GameKit {
#if !MONOMAC && !TVOS
	/// <summary>Provides data for the <see cref="GameKit.GKSession.ReceiveData" /> event.</summary>
	///     <remarks>
	///     </remarks>
	public class GKDataReceivedEventArgs : EventArgs {
		/// <param name="data">The data to use.</param>
		///         <param name="peer">The peer.</param>
		///         <param name="session">The session.</param>
		///         <summary>Initializes a new instance of the GKDataReceivedEventArgs class.</summary>
		///         <remarks>
		///         </remarks>
		public GKDataReceivedEventArgs (NSData data, string peer, GKSession session)
		{
			Data = data;
			PeerID = peer;
			Session = session;
		}
	/// <summary>Gets the data that was received.</summary>
		public NSData Data { get; private set; }
	/// <summary>Gets the peer ID of the sender.</summary>
		public string PeerID { get; private set; }
	/// <summary>Gets the session on which the data was received.</summary>
		public GKSession Session { get; private set; }
	}

#if !TVOS
	public partial class GKSession {
		[Register ("MonoTouch_GKSession_ReceivedObject")]
		internal class ReceiverObject : NSObject {
			internal EventHandler<GKDataReceivedEventArgs>? receiver;

			public ReceiverObject ()
			{
				IsDirectBinding = false;
			}

			[Export ("receiveData:fromPeer:inSession:context:")]
			[Preserve (Conditional = true)]
			void Receive (NSData data, string peer, GKSession session, IntPtr context)
			{
				if (receiver is not null)
					receiver (session, new GKDataReceivedEventArgs (data, peer, session));
			}

		}

		//
		// This delegate is used by the 
		ReceiverObject? receiver;
	/// <summary>Occurs when data is received from a peer.</summary>
		public event EventHandler<GKDataReceivedEventArgs>? ReceiveData {
			add {
				if (receiver is null) {
					receiver = new ReceiverObject ();
					_SetDataReceiveHandler (receiver, IntPtr.Zero);
					MarkDirty ();
				}
				receiver.receiver += value;
			}

			remove {
				if (receiver is null)
					return;
				receiver.receiver -= value;
			}
		}

		/// <param name="obj">The obj.</param>
		///         <param name="context">The context to use.</param>
		/// <summary>Sets the data receive handler for this session.</summary>
		public void SetDataReceiveHandler (NSObject obj, IntPtr context)
		{
			receiver = null;
			_SetDataReceiveHandler (obj, context);
		}

		//
		// The C# event handlers
		//
		Mono_GKSessionDelegate EnsureDelegate ()
		{
			var del = WeakDelegate;
			if (del is null || (!(del is Mono_GKSessionDelegate))) {
				del = new Mono_GKSessionDelegate ();
				WeakDelegate = del;
			}
			return (Mono_GKSessionDelegate) del;
		}

	/// <summary>Occurs when a peer changes its connection state.</summary>
		public event EventHandler<GKPeerChangedStateEventArgs> PeerChanged {
			add {
				EnsureDelegate ().cbPeerChanged += value;
			}

			remove {
				EnsureDelegate ().cbPeerChanged -= value;
			}
		}

	/// <summary>Occurs when a connection request is received from a peer.</summary>
		public event EventHandler<GKPeerConnectionEventArgs> ConnectionRequest {
			add {
				EnsureDelegate ().cbConnectionRequest += value;
			}

			remove {
				EnsureDelegate ().cbConnectionRequest -= value;
			}
		}

	/// <summary>Occurs when a connection attempt fails.</summary>
		public event EventHandler<GKPeerConnectionEventArgs> ConnectionFailed {
			add {
				EnsureDelegate ().cbConnectionFailed += value;
			}

			remove {
				EnsureDelegate ().cbConnectionFailed -= value;
			}
		}
	/// <summary>Occurs when the session encounters an error.</summary>
		public event EventHandler<GKPeerConnectionEventArgs> Failed {
			add {
				EnsureDelegate ().cbFailedWithError += value;
			}

			remove {
				EnsureDelegate ().cbFailedWithError -= value;
			}
		}
	}

	class Mono_GKSessionDelegate : GKSessionDelegate {
		internal EventHandler<GKPeerChangedStateEventArgs>? cbPeerChanged;
		internal EventHandler<GKPeerConnectionEventArgs>? cbConnectionRequest;
		internal EventHandler<GKPeerConnectionEventArgs>? cbConnectionFailed;
		internal EventHandler<GKPeerConnectionEventArgs>? cbFailedWithError;

		public Mono_GKSessionDelegate ()
		{
			IsDirectBinding = false;
		}

		[Preserve (Conditional = true)]
		public override void PeerChangedState (GKSession session, string peerID, GKPeerConnectionState state)
		{
			if (cbPeerChanged is not null)
				cbPeerChanged (session, new GKPeerChangedStateEventArgs (session, peerID, state));
		}

		[Preserve (Conditional = true)]
		public override void PeerConnectionRequest (GKSession session, string peerID)
		{
			if (cbConnectionRequest is not null)
				cbConnectionRequest (session, new GKPeerConnectionEventArgs (session, peerID, null));
		}

		[Preserve (Conditional = true)]
		public override void PeerConnectionFailed (GKSession session, string peerID, NSError error)
		{
			if (cbConnectionFailed is not null)
				cbConnectionFailed (session, new GKPeerConnectionEventArgs (session, peerID, error));

		}

		[Preserve (Conditional = true)]
		public override void FailedWithError (GKSession session, NSError error)
		{
			if (cbFailedWithError is not null)
				cbFailedWithError (session, new GKPeerConnectionEventArgs (session, null, error));
		}
	}
#endif // !TVOS

	/// <summary>Provides data for the <see cref="GameKit.GKSession.PeerChanged" /> event.</summary>
	///     <remarks>
	///     </remarks>
	public class GKPeerChangedStateEventArgs : EventArgs {
		/// <param name="session">The session.</param>
		///         <param name="peerID">The peer i d.</param>
		///         <param name="state">The state.</param>
		///         <summary>Initializes a new instance of the GKPeerChangedStateEventArgs class.</summary>
		///         <remarks>
		///         </remarks>
		public GKPeerChangedStateEventArgs (GKSession session, string peerID, GKPeerConnectionState state)
		{
			Session = session;
			PeerID = peerID;
			State = state;
		}

	/// <summary>Gets the session associated with this event.</summary>
		public GKSession Session { get; private set; }
	/// <summary>Gets the peer ID associated with this event.</summary>
		public string PeerID { get; private set; }
	/// <summary>Gets the connection state of the peer.</summary>
		public GKPeerConnectionState State { get; private set; }
	}

	/// <summary>Provides data for the <see cref="GameKit.GKSession.Failed" />, <see cref="GameKit.GKSession.ConnectionRequest" /> and <see cref="GameKit.GKSession.ConnectionFailed" /> events.</summary>
	///     <remarks>
	///     </remarks>
	public class GKPeerConnectionEventArgs : EventArgs {
		/// <param name="session">The session.</param>
		///         <param name="peerID">The peer i d.</param>
		///         <param name="error">The error that occurred, or <see langword="null" /> if no error occurred.</param>
		///         <summary>Initializes a new instance of the GKPeerConnectionEventArgs class.</summary>
		///         <remarks>
		///         </remarks>
		public GKPeerConnectionEventArgs (GKSession session, string? peerID, NSError? error)
		{
			Session = session;
			PeerID = peerID;
			Error = error;
		}
	/// <summary>Gets the session associated with this event.</summary>
		public GKSession Session { get; private set; }
	/// <summary>Gets the peer ID associated with this event, or <see langword="null" /> if not applicable.</summary>
		public string? PeerID { get; private set; }
	/// <summary>Gets the error that occurred, or <see langword="null" /> if no error occurred.</summary>
		public NSError? Error { get; private set; }
	}
#endif

	public partial class GKVoiceChat {
	}

	public partial class GKTurnBasedExchange {

		/// <summary>Returns a string representation of the value of the current instance.</summary>
		///         <returns>
		///         </returns>
		///         <remarks>
		///         </remarks>
		public override string ToString ()
		{
			return "GKTurnBasedExchange";
		}
	}

	public partial class GKTurnBasedExchangeReply {

		/// <summary>Returns a string representation of the value of the current instance.</summary>
		///         <returns>
		///         </returns>
		///         <remarks>
		///         </remarks>
		public override string ToString ()
		{
			return "GKTurnBasedExchangeReply";
		}
	}

	public partial class GKChallenge {

		/// <summary>Returns a string representation of the value of the current instance.</summary>
		///         <returns>
		///         </returns>
		///         <remarks>
		///         </remarks>
		public override string ToString ()
		{
			return GetType ().ToString ();
		}
	}

	public partial class GKMatch {
	}
}
