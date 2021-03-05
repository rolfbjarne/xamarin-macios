//
// NWPath.cs: Bindings the Netowrk nw_path_t API.
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

namespace Network {

	[TV (12,0), Mac (10,14), iOS (12,0)]
	[Watch (6,0)]
	public class NWPath : NativeObject {
		public NWPath (IntPtr handle, bool owns) : base (handle, owns) {}

		[DllImport (Constants.NetworkLibrary)]
		extern static NWPathStatus nw_path_get_status (IntPtr handle);

		public NWPathStatus Status => nw_path_get_status (GetCheckedHandle ());

		[DllImport (Constants.NetworkLibrary)]
		[return: MarshalAs(UnmanagedType.U1)]
		extern static bool nw_path_is_expensive (IntPtr handle);

		public bool IsExpensive => nw_path_is_expensive (GetCheckedHandle ());

		[DllImport (Constants.NetworkLibrary)]
		[return: MarshalAs(UnmanagedType.U1)]
		extern static bool nw_path_has_ipv4 (IntPtr handle);

		public bool HasIPV4 => nw_path_has_ipv4 (GetCheckedHandle ());

		[DllImport (Constants.NetworkLibrary)]
		[return: MarshalAs(UnmanagedType.U1)]
		extern static bool nw_path_has_ipv6 (IntPtr handle);

		public bool HasIPV6 => nw_path_has_ipv6 (GetCheckedHandle ());

		[DllImport (Constants.NetworkLibrary)]
		[return: MarshalAs(UnmanagedType.U1)]
		extern static bool nw_path_has_dns (IntPtr handle);

		public bool HasDns => nw_path_has_dns (GetCheckedHandle ());

		[DllImport (Constants.NetworkLibrary)]
		[return: MarshalAs(UnmanagedType.U1)]
		extern static bool nw_path_uses_interface_type (IntPtr handle, NWInterfaceType type);

		public bool UsesInterfaceType (NWInterfaceType type) => nw_path_uses_interface_type (GetCheckedHandle (), type);

		[DllImport (Constants.NetworkLibrary)]
		extern static IntPtr nw_path_copy_effective_local_endpoint (IntPtr handle);

		public NWEndpoint? EffectiveLocalEndpoint {
			get {
				var x = nw_path_copy_effective_local_endpoint (GetCheckedHandle ());
				if (x == IntPtr.Zero)
					return null;
				return new NWEndpoint (x, owns: true);
			}
		}

		[DllImport (Constants.NetworkLibrary)]
		extern static IntPtr nw_path_copy_effective_remote_endpoint (IntPtr handle);

		public NWEndpoint? EffectiveRemoteEndpoint {
			get {
				var x = nw_path_copy_effective_remote_endpoint (GetCheckedHandle ());
				if (x == IntPtr.Zero)
					return null;
				return new NWEndpoint (x, owns: true);
			}
		}

		[DllImport (Constants.NetworkLibrary)]
		[return: MarshalAs(UnmanagedType.U1)]
		extern static bool nw_path_is_equal (IntPtr p1, IntPtr p2);

		public bool EqualsTo (NWPath other)
		{
			if (other == null)
				return false;

			return nw_path_is_equal (GetCheckedHandle (), other.Handle);
		}

		delegate void nw_path_enumerate_interfaces_block_t (IntPtr block, IntPtr iface);
		static nw_path_enumerate_interfaces_block_t static_Enumerator = TrampolineEnumerator;

		[MonoPInvokeCallback (typeof (nw_path_enumerate_interfaces_block_t))]
		static void TrampolineEnumerator (IntPtr block, IntPtr iface)
		{
			var del = BlockLiteral.GetTarget<Action<NWInterface>> (block);
			if (del != null)
				del (new NWInterface (iface, owns: false));
		}

		[DllImport (Constants.NetworkLibrary)]
		static extern void nw_path_enumerate_interfaces (IntPtr handle, ref BlockLiteral callback);

		[BindingImpl (BindingImplOptions.Optimizable)]
		public void EnumerateInterfaces (Action<NWInterface> callback)
		{
			if (callback == null)
				return;

			BlockLiteral block_handler = new BlockLiteral ();
			block_handler.SetupBlockUnsafe (static_Enumerator, callback);

			try {
				nw_path_enumerate_interfaces (GetCheckedHandle (), ref block_handler);
			} finally {
				block_handler.CleanupBlock ();
			}
		}

		[TV (13,0), Mac (10,15), iOS (13,0)]
		[DllImport (Constants.NetworkLibrary)]
		[return: MarshalAs (UnmanagedType.I1)]
		static extern bool nw_path_is_constrained (IntPtr path);

		[TV (13,0), Mac (10,15), iOS (13,0)]
		public bool IsConstrained => nw_path_is_constrained (GetCheckedHandle ());

		[TV (13,0), Mac (10,15), iOS (13,0)]
		[DllImport (Constants.NetworkLibrary)]
		static extern void nw_path_enumerate_gateways (IntPtr path, ref BlockLiteral enumerate_block);

		delegate void nw_path_enumerate_gateways_t (IntPtr block, IntPtr endpoint);
		static nw_path_enumerate_gateways_t static_EnumerateGatewaysHandler = TrampolineGatewaysHandler;

		[MonoPInvokeCallback (typeof (nw_path_enumerate_gateways_t))]
		static void TrampolineGatewaysHandler (IntPtr block, IntPtr endpoint)
		{
			var del = BlockLiteral.GetTarget<Action<NWEndpoint>> (block);
			if (del != null) {
				var nwEndpoint = new NWEndpoint (endpoint, owns: false);
				del (nwEndpoint);
			}
		}

		[TV (13,0), Mac (10,15), iOS (13,0)]
		[BindingImpl (BindingImplOptions.Optimizable)]
		public void EnumerateGateways (Action<NWEndpoint> callback)
		{
			if (callback == null)
				throw new ArgumentNullException (nameof (callback));

			BlockLiteral block_handler = new BlockLiteral ();
			block_handler.SetupBlockUnsafe (static_Enumerator, callback);

			try {
				nw_path_enumerate_gateways (GetCheckedHandle (), ref block_handler);
			} finally {
				block_handler.CleanupBlock ();
			}
		}

		[iOS (14,2)][TV (14,2)][Watch (7,1)][Mac (11,0)]
		[DllImport (Constants.NetworkLibrary)]
		static extern NWPathUnsatisfiedReason /* nw_path_unsatisfied_reason_t */ nw_path_get_unsatisfied_reason (IntPtr /* OS_nw_path */ path);

		[iOS (14,2)][TV (14,2)][Watch (7,1)][Mac (11,0)]
		public NWPathUnsatisfiedReason GetUnsatisfiedReason ()
		{
			return nw_path_get_unsatisfied_reason (GetCheckedHandle ());
		}
	}
}
