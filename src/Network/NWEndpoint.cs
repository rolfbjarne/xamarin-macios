//
// NWEndpoint.cs: Bindings the Netowrk nw_endpoint_t API.
//
// Authors:
//   Miguel de Icaza (miguel@microsoft.com)
//
// Copyrigh 2018 Microsoft Inc
//

#nullable enable

using System.Runtime.CompilerServices;
using CoreFoundation;

using OS_nw_endpoint = System.IntPtr;
using OS_nw_txt_record = System.IntPtr;

namespace Network {
/// <summary>Represents a network endpoint, such as a host/port pair, Bonjour service, or URL.</summary>
	[SupportedOSPlatform ("tvos")]
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("maccatalyst")]

	public class NWEndpoint : NativeObject {
		[Preserve (Conditional = true)]
		internal NWEndpoint (NativeHandle handle, bool owns) : base (handle, owns) { }

#if !COREBUILD
		[DllImport (Constants.NetworkLibrary)]
		extern static NWEndpointType nw_endpoint_get_type (OS_nw_endpoint handle);

	/// <summary>Gets the type of this network endpoint.</summary>
		public NWEndpointType Type => nw_endpoint_get_type (GetCheckedHandle ());

		[DllImport (Constants.NetworkLibrary)]
		extern static OS_nw_endpoint nw_endpoint_create_host (IntPtr hostname, IntPtr port);

		/// <param name="hostname">The hostname.</param>
		///         <param name="port">The port.</param>
		/// <summary>Creates a network endpoint with the specified hostname and port.</summary>
		public static NWEndpoint? Create (string hostname, string port)
		{
			if (hostname is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (hostname));
			if (port is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (port));
			using var hostnamePtr = new TransientString (hostname);
			using var portPtr = new TransientString (port);
			var handle = nw_endpoint_create_host (hostnamePtr, portPtr);
			if (handle == IntPtr.Zero)
				return null;
			return new NWEndpoint (handle, owns: true);
		}

		[DllImport (Constants.NetworkLibrary)]
		static extern IntPtr nw_endpoint_get_hostname (OS_nw_endpoint endpoint);

	/// <summary>Gets the hostname of this endpoint.</summary>
		public string? Hostname => Marshal.PtrToStringAnsi (nw_endpoint_get_hostname (GetCheckedHandle ()));

		[DllImport (Constants.NetworkLibrary, EntryPoint = "nw_endpoint_copy_port_string")]
		static extern IntPtr nw_endpoint_copy_port_string_ptr (OS_nw_endpoint endpoint);

		static string nw_endpoint_copy_port_string (OS_nw_endpoint endpoint)
		{
			var ptr = nw_endpoint_copy_port_string_ptr (endpoint);
			return TransientString.ToStringAndFree (ptr)!;
		}

	/// <summary>Gets the port string of this endpoint.</summary>
		public string Port => nw_endpoint_copy_port_string (GetCheckedHandle ());

		[DllImport (Constants.NetworkLibrary)]
		static extern ushort nw_endpoint_get_port (OS_nw_endpoint endpoint);

	/// <summary>Gets the port number of this endpoint.</summary>
		public ushort PortNumber => nw_endpoint_get_port (GetCheckedHandle ());

		[DllImport (Constants.NetworkLibrary)]
		static extern OS_nw_endpoint nw_endpoint_create_address (IntPtr sockaddrPtr);

		// TODO: .NET has a SocketAddress type, we could use it for simplicity, but the
		// address family would have to be mapped, and it does not look like a very useful
		// type to begin with.

		[DllImport (Constants.NetworkLibrary, EntryPoint = "nw_endpoint_copy_address_string")]
		static extern IntPtr nw_endpoint_copy_address_string_ptr (OS_nw_endpoint endpoint);

		static string nw_endpoint_copy_address_string (OS_nw_endpoint endpoint)
		{
			var ptr = nw_endpoint_copy_address_string_ptr (endpoint);
			return TransientString.ToStringAndFree (ptr)!;
		}

	/// <summary>Gets the address string of this endpoint.</summary>
		public string Address => nw_endpoint_copy_address_string (GetCheckedHandle ());

#if false
	// need to sort out sockaddr binding.
		[DllImport (Constants.NetworkLibrary)]
		static extern IntPtr /* struct sockaddr* */ nw_endpoint_get_address (OS_nw_endpoint endpoint);
#endif

		// TODO: same
		[DllImport (Constants.NetworkLibrary)]
		static extern unsafe OS_nw_endpoint nw_endpoint_create_bonjour_service (IntPtr name, IntPtr type, IntPtr domain);

		/// <param name="name">The name to use.</param>
		///         <param name="serviceType">The service type.</param>
		///         <param name="domain">The domain.</param>
		/// <summary>Creates a Bonjour service endpoint with the specified name, type, and domain.</summary>
		public static NWEndpoint? CreateBonjourService (string name, string serviceType, string domain)
		{
			if (serviceType is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (serviceType));
			using var namePtr = new TransientString (name);
			using var serviceTypePtr = new TransientString (serviceType);
			using var domainPtr = new TransientString (domain);
			var x = nw_endpoint_create_bonjour_service (namePtr, serviceTypePtr, domainPtr);
			if (x == IntPtr.Zero)
				return null;
			return new NWEndpoint (x, owns: true);
		}

		[DllImport (Constants.NetworkLibrary)]
		static extern unsafe IntPtr nw_endpoint_get_bonjour_service_name (OS_nw_endpoint endpoint);

	/// <summary>Gets the Bonjour service name of this endpoint.</summary>
		public string? BonjourServiceName => Marshal.PtrToStringAnsi (nw_endpoint_get_bonjour_service_name (GetCheckedHandle ()));

		[DllImport (Constants.NetworkLibrary)]
		static extern IntPtr nw_endpoint_get_bonjour_service_type (OS_nw_endpoint endpoint);

	/// <summary>Gets the Bonjour service type of this endpoint.</summary>
		public string? BonjourServiceType => Marshal.PtrToStringAnsi (nw_endpoint_get_bonjour_service_type (GetCheckedHandle ()));

		[DllImport (Constants.NetworkLibrary)]
		static extern IntPtr nw_endpoint_get_bonjour_service_domain (OS_nw_endpoint endpoint);

	/// <summary>Gets the Bonjour service domain of this endpoint.</summary>
		public string? BonjourServiceDomain => Marshal.PtrToStringAnsi (nw_endpoint_get_bonjour_service_domain (GetCheckedHandle ()));

		[SupportedOSPlatform ("tvos13.0")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[DllImport (Constants.NetworkLibrary, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
		static extern OS_nw_endpoint nw_endpoint_create_url (IntPtr url);

		[SupportedOSPlatform ("tvos13.0")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		public static NWEndpoint? Create (string url)
		{
			if (url is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (url));
			using var urlPtr = new TransientString (url);
			var handle = nw_endpoint_create_url (urlPtr);
			if (handle == IntPtr.Zero)
				return null;
			return new NWEndpoint (handle, owns: true);
		}

		[SupportedOSPlatform ("tvos13.0")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[DllImport (Constants.NetworkLibrary, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr nw_endpoint_get_url (OS_nw_endpoint endpoint);

		[SupportedOSPlatform ("tvos13.0")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		public string? Url => Marshal.PtrToStringAnsi (nw_endpoint_get_url (GetCheckedHandle ()));

		[SupportedOSPlatform ("tvos16.0")]
		[SupportedOSPlatform ("macos13.0")]
		[SupportedOSPlatform ("ios16.0")]
		[SupportedOSPlatform ("maccatalyst16.0")]
		[DllImport (Constants.NetworkLibrary)]
		static extern unsafe byte* nw_endpoint_get_signature (OS_nw_endpoint endpoint, nuint* out_signature_length);

		[SupportedOSPlatform ("tvos16.0")]
		[SupportedOSPlatform ("macos13.0")]
		[SupportedOSPlatform ("ios16.0")]
		[SupportedOSPlatform ("maccatalyst16.0")]
		public ReadOnlySpan<byte> Signature {
			get {
				unsafe {
					nuint length;
					var data = nw_endpoint_get_signature (GetCheckedHandle (), &length);
					var mValue = new ReadOnlySpan<byte> (data, (int) length);
					// we do not know who manages the byte array, so we return a copy, is more expensive but
					// safer until we know what is the mem management.
					return new ReadOnlySpan<byte> (mValue.ToArray ());
				}
			}
		}

		[SupportedOSPlatform ("tvos16.0")]
		[SupportedOSPlatform ("macos13.0")]
		[SupportedOSPlatform ("ios16.0")]
		[SupportedOSPlatform ("maccatalyst16.0")]
		[DllImport (Constants.NetworkLibrary)]
		static extern OS_nw_txt_record nw_endpoint_copy_txt_record (OS_nw_endpoint endpoint);

		[SupportedOSPlatform ("tvos16.0")]
		[SupportedOSPlatform ("macos13.0")]
		[SupportedOSPlatform ("ios16.0")]
		[SupportedOSPlatform ("maccatalyst16.0")]
		public NWTxtRecord? TxtRecord {
			get {
				var record = nw_endpoint_copy_txt_record (GetCheckedHandle ());
				if (record == IntPtr.Zero)
					return null;
				return new NWTxtRecord (record, owns: true);
			}
		}

		/// <summary>Returns an autoreleased NSArray handle.</summary>
		internal IntPtr ToNSArrayHandle (NWEndpoint [] array)
		{
			using var rv = NSArray.FromNSObjects (array);
			if (rv is null)
				return IntPtr.Zero;
#pragma warning disable RBI0014
			rv.DangerousRetain ();
			rv.DangerousAutorelease ();
			return rv.Handle;
#pragma warning restore RBI0014
		}
#endif // !COREBUILD

	}
}
