//
// NWProtocolMetadata.cs: Bindings the Netowrk nw_protocol_metadata_t API.
//
// Authors:
//   Miguel de Icaza (miguel@microsoft.com)
//
// Copyrigh 2018 Microsoft Inc
//

#nullable enable

using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using ObjCRuntime;
using Foundation;
using CoreFoundation;
using Security;
using OS_nw_protocol_definition=System.IntPtr;
using OS_nw_protocol_metadata=System.IntPtr;
using nw_service_class_t=System.IntPtr;

namespace Network {

	[TV (12,0), Mac (10,14), iOS (12,0)]
	[Watch (6,0)]
	public class NWProtocolMetadata : NativeObject {

		[DllImport (Constants.NetworkLibrary)]
		internal static extern OS_nw_protocol_metadata nw_ip_create_metadata ();

#if !XAMCORE_4_0
		[Obsolete ("Use the 'NWIPMetadata' class and methods instead.")]
		public static NWProtocolMetadata CreateIPMetadata ()
		{
			return new NWProtocolMetadata (nw_ip_create_metadata (), owns: true);
		}
#endif

		[DllImport (Constants.NetworkLibrary)]
		internal static extern OS_nw_protocol_metadata nw_udp_create_metadata ();

#if !XAMCORE_4_0
		[Obsolete ("Use the 'NSUdpMetadata' class and methods instead.")]
		public static NWProtocolMetadata CreateUdpMetadata ()
		{
			return new NWProtocolMetadata (nw_udp_create_metadata (), owns: true);
		}
#endif

		public NWProtocolMetadata (IntPtr handle, bool owns) : base (handle, owns) {}

		[DllImport (Constants.NetworkLibrary)]
		internal static extern OS_nw_protocol_definition nw_protocol_metadata_copy_definition (OS_nw_protocol_metadata metadata);

		public NWProtocolDefinition ProtocolDefinition => new NWProtocolDefinition (nw_protocol_metadata_copy_definition (GetCheckedHandle ()), owns: true);

		[DllImport (Constants.NetworkLibrary)]
		[return: MarshalAs (UnmanagedType.I1)]
		internal static extern bool nw_protocol_metadata_is_ip (OS_nw_protocol_metadata metadata);

		public bool IsIP => nw_protocol_metadata_is_ip (GetCheckedHandle ());

		[DllImport (Constants.NetworkLibrary)]
		[return: MarshalAs (UnmanagedType.I1)]
		internal static extern bool nw_protocol_metadata_is_udp (OS_nw_protocol_metadata metadata);

		public bool IsUdp => nw_protocol_metadata_is_udp (GetCheckedHandle ());

		[DllImport (Constants.NetworkLibrary)]
		[return: MarshalAs (UnmanagedType.I1)]
		internal static extern bool nw_protocol_metadata_is_tls (OS_nw_protocol_metadata metadata);

		public bool IsTls => nw_protocol_metadata_is_tls (GetCheckedHandle ());

		[DllImport (Constants.NetworkLibrary)]
		[return: MarshalAs (UnmanagedType.I1)]
		internal static extern bool nw_protocol_metadata_is_tcp (OS_nw_protocol_metadata metadata);

		public bool IsTcp => nw_protocol_metadata_is_tcp (GetCheckedHandle ());

		[DllImport (Constants.NetworkLibrary)]
		internal static extern IntPtr nw_tls_copy_sec_protocol_metadata (IntPtr handle);

		void CheckIsIP ()
		{
			if (!IsIP)
				throw new InvalidOperationException ("This metadata is not IP metadata.");
		}

		void CheckIsTcp ()
		{
			if (!IsTcp)
				throw new InvalidOperationException ("This metadata is not TCP metadata.");
		}

		void CheckIsTls ()
		{
			if (!IsTls)
				throw new InvalidOperationException ("This metadata is not TLS metadata.");
		}

#if !XAMCORE_4_0
		[Obsolete ("Use the 'NWTlsMetadata' class and methods instead.")]
		public SecProtocolMetadata SecProtocolMetadata => TlsSecProtocolMetadata;

		[Obsolete ("Use the 'NWTlsMetadata' class and methods instead.")]
		public SecProtocolMetadata TlsSecProtocolMetadata {
			get {
				CheckIsTls ();
				return new SecProtocolMetadata (nw_tls_copy_sec_protocol_metadata (GetCheckedHandle ()), owns: true);
			}
		}
#endif

		[DllImport (Constants.NetworkLibrary)]
		internal static extern void nw_ip_metadata_set_ecn_flag (OS_nw_protocol_metadata metadata, NWIPEcnFlag ecn_flag);

		[DllImport (Constants.NetworkLibrary)]
		internal static extern NWIPEcnFlag nw_ip_metadata_get_ecn_flag (OS_nw_protocol_metadata metadata);

#if !XAMCORE_4_0
		[Obsolete ("Use the 'NWIPMetadata' class and methods instead.")]
		public NWIPEcnFlag IPMetadataEcnFlag {
			get {
				CheckIsIP ();
				return nw_ip_metadata_get_ecn_flag (GetCheckedHandle ());
			}
			set {
				CheckIsIP ();
				nw_ip_metadata_set_ecn_flag (GetCheckedHandle (), value);
			}
		}
#endif

		[DllImport (Constants.NetworkLibrary)]
		internal static extern /* uint64_t */ ulong nw_ip_metadata_get_receive_time (OS_nw_protocol_metadata metadata);

#if !XAMCORE_4_0
		[Obsolete ("Use the 'NWIPMetadata' class and methods instead.")]
		public ulong IPMetadataReceiveTime {
			get {
				CheckIsIP ();
				return nw_ip_metadata_get_receive_time (GetCheckedHandle ());
			}
		}
#endif

		[DllImport (Constants.NetworkLibrary)]
		internal static extern void nw_ip_metadata_set_service_class (OS_nw_protocol_metadata metadata, NWServiceClass service_class);

		[DllImport (Constants.NetworkLibrary)]
		internal static extern NWServiceClass nw_ip_metadata_get_service_class (OS_nw_protocol_metadata metadata);

#if !XAMCORE_4_0
		[Obsolete ("Use the 'NWIPMetadata' class and methods instead.")]
		public NWServiceClass ServiceClass {
			get => IPServiceClass;
			set => IPServiceClass = value;
		}

		[Obsolete ("Use the 'NWIPMetadata' class and methods instead.")]
		public NWServiceClass IPServiceClass {
			get {
				CheckIsIP ();
				return nw_ip_metadata_get_service_class (GetCheckedHandle ());
			}
			set {
				CheckIsIP ();
				nw_ip_metadata_set_service_class (GetCheckedHandle (), value);
			}
		}
#endif

		[DllImport (Constants.NetworkLibrary)]
		internal extern static /* uint32_t */ uint nw_tcp_get_available_receive_buffer (IntPtr handle);

#if !XAMCORE_4_0
		[Obsolete ("Use the 'NWTcpMetadata' class and methods instead.")]
		public uint TcpGetAvailableReceiveBuffer ()
		{
			CheckIsTcp ();
			return nw_tcp_get_available_receive_buffer (GetCheckedHandle ());
		}
#endif

		[DllImport (Constants.NetworkLibrary)]
		internal extern static /* uint32_t */ uint nw_tcp_get_available_send_buffer (IntPtr handle);

#if !XAMCORE_4_0
		[Obsolete ("Use the 'NWTcpMetadata' class and methods instead.")]
		public uint TcpGetAvailableSendBuffer ()
		{
			CheckIsTcp ();
			return nw_tcp_get_available_send_buffer (GetCheckedHandle ());
		}
#endif

		[TV (13,0), Mac (10,15), iOS (13,0)]
		[DllImport (Constants.NetworkLibrary)]
		[return: MarshalAs (UnmanagedType.I1)]
		internal static extern bool nw_protocol_metadata_is_framer_message (OS_nw_protocol_metadata metadata);

		[TV (13,0), Mac (10,15), iOS (13,0)]
		public bool IsFramerMessage => nw_protocol_metadata_is_framer_message (GetCheckedHandle ());

		[TV (13,0), Mac (10,15), iOS (13,0)]
		[DllImport (Constants.NetworkLibrary)]
		[return: MarshalAs (UnmanagedType.I1)]
		internal static extern bool nw_protocol_metadata_is_ws (OS_nw_protocol_metadata metadata);

		[TV (13,0), Mac (10,15), iOS (13,0)]
		public bool IsWebSocket => nw_protocol_metadata_is_ws (GetCheckedHandle ());
	}
}
