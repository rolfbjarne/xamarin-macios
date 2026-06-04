//
// NSHost.cs: augment NSHost with C#isms and
// System.Net's IPAddress and IPHostEntry.
//
// Authors:
//   Aaron Bockover <abock@xamarin.com>
//
// Copyright 2013 Xamarin, Inc. All rights reserved.
//

#if MONOMAC

#nullable enable

using System.Net;
using System.Collections;
using System.Collections.Generic;

namespace Foundation {
	public partial class NSHost : IEquatable<NSHost>, IEnumerable<IPAddress> {
		static NSHost? CheckNull (NSHost? host)
		{
			if (host is null)
				return null;

			var addrs = host._Addresses;
			if (addrs is null || addrs.Length == 0)
				return null;

			return host;
		}

	/// <summary>Gets the current host.</summary>
		public static NSHost? Current {
			get { return CheckNull (_Current); }
		}

		/// <param name="address">The address.</param>
		/// <summary>Creates an NSHost from the specified IP address string.</summary>
		public static NSHost? FromAddress (string? address)
		{
			if (address is null)
				return null;
			return CheckNull (_FromAddress (address));
		}

		/// <param name="name">The name to use.</param>
		/// <summary>Creates an NSHost from the specified hostname.</summary>
		public static NSHost? FromName (string? name)
		{
			if (name is null)
				return null;
			return CheckNull (_FromName (name));
		}

		public static explicit operator IPAddress? (NSHost? host)
		{
			if (host is null)
				return null;

			return host.Address;
		}

		public static explicit operator NSHost? (IPAddress? address)
		{
			return FromAddress (address);
		}

		public static explicit operator IPHostEntry? (NSHost host)
		{
			if (host is null)
				return null;

			return host.ToIPHostEntry ();
		}

		public static explicit operator NSHost? (IPHostEntry? hostEntry)
		{
			return FromIPHostEntry (hostEntry);
		}

		/// <param name="hostEntry">The host entry.</param>
		/// <summary>Creates an NSHost from the specified IP host entry.</summary>
		public static NSHost? FromIPHostEntry (IPHostEntry? hostEntry)
		{
			if (hostEntry is null)
				return null;

			if (hostEntry.AddressList is not null) {
				foreach (var addr in hostEntry.AddressList) {
					var host = FromAddress (addr);
					if (host is not null)
						return host;
				}
			}

			if (hostEntry.HostName is not null) {
				var host = FromName (hostEntry.HostName);
				if (host is not null)
					return host;
			}

			if (hostEntry.Aliases is not null) {
				foreach (var name in hostEntry.Aliases) {
					var host = FromName (name);
					if (host is not null)
						return host;
				}
			}

			return null;
		}

	/// <summary>Converts this host to an <see cref="T:System.Net.IPHostEntry" />.</summary>
		public IPHostEntry ToIPHostEntry ()
		{
			return new IPHostEntry {
				HostName = Name!,
				AddressList = Addresses,
				Aliases = Names,
			};
		}

		/// <param name="address">The address.</param>
		/// <summary>Creates an NSHost from the specified IP address.</summary>
		public static NSHost? FromAddress (IPAddress? address)
		{
			if (address is null)
				return null;
			return FromAddress (address.ToString ());
		}

	/// <summary>Gets the first IP address of this host.</summary>
		public IPAddress? Address {
			get {
				var address = _Address;
				if (address is null)
					return null;
				return IPAddress.Parse (address);
			}
		}

	/// <summary>Gets all IP addresses of this host.</summary>
		public IPAddress [] Addresses {
			get {
				var addrs = new IPAddress [_Addresses.Length];
				for (int i = 0; i < addrs.Length; i++)
					addrs [i] = IPAddress.Parse (_Addresses [i]);
				return addrs;
			}
		}

	/// <summary>Returns the hash code for this host.</summary>
		public override int GetHashCode ()
		{
			return (int) _Hash;
		}

		/// <param name="obj">The obj.</param>
		/// <summary>Determines whether this host is equal to the specified object.</summary>
		public override bool Equals (object? obj)
		{
			if (obj == this)
				return true;

			var host = obj as NSHost;
			if (host is not null)
				return Equals (host);

			return false;
		}

	/// <summary>Returns an enumerator that iterates through the IP addresses of this host.</summary>
		public IEnumerator<IPAddress> GetEnumerator ()
		{
			foreach (var address in Addresses)
				yield return address;
		}

	/// <summary>Returns an enumerator that iterates through the IP addresses of this host.</summary>
		IEnumerator IEnumerable.GetEnumerator ()
		{
			return GetEnumerator ();
		}

		bool IEquatable<NSHost>.Equals (NSHost? other)
		{
			return Equals ((object?) other);
		}
	}
}

#endif // MONOMAC
