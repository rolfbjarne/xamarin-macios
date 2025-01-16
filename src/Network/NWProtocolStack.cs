//
// NWProtocolStack.cs: Bindings the Netowrk nw_protocol_stack_t API.
//
// Authors:
//   Miguel de Icaza (miguel@microsoft.com)
//
// Copyrigh 2018 Microsoft Inc
//

#nullable enable

using System;
using System.Runtime.InteropServices;
using ObjCRuntime;
using Foundation;
using CoreFoundation;

using OS_nw_protocol_definition = System.IntPtr;
using OS_nw_protocol_metadata = System.IntPtr;
using nw_service_class_t = System.IntPtr;
using nw_protocol_stack_t = System.IntPtr;
using nw_protocol_options_t = System.IntPtr;

#if !NET
using NativeHandle = System.IntPtr;
#endif

namespace Network {

#if NET
	[SupportedOSPlatform ("tvos12.2")]
	[SupportedOSPlatform ("macos12.0")]
	[SupportedOSPlatform ("ios12.2")]
	[SupportedOSPlatform ("maccatalyst15.0")]
#endif
	public class NWProtocolStack : NativeObject {
		[Preserve (Conditional = true)]
#if NET
		internal NWProtocolStack (NativeHandle handle, bool owns) : base (handle, owns) {}
#else
		public NWProtocolStack (NativeHandle handle, bool owns) : base (handle, owns) { }
#endif

		[DllImport (Constants.NetworkLibrary)]
		static extern void nw_protocol_stack_prepend_application_protocol (nw_protocol_stack_t stack, nw_protocol_options_t options);

		public void PrependApplicationProtocol (NWProtocolOptions options)
		{
			if (options is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (options));
			nw_protocol_stack_prepend_application_protocol (GetCheckedHandle (), options.Handle);
		}

		[DllImport (Constants.NetworkLibrary)]
		static extern void nw_protocol_stack_clear_application_protocols (nw_protocol_stack_t stack);

		public void ClearApplicationProtocols ()
		{
			nw_protocol_stack_clear_application_protocols (GetCheckedHandle ());
		}

#if !NET
		delegate void nw_protocol_stack_iterate_protocols_block_t (IntPtr block, IntPtr options);
		static nw_protocol_stack_iterate_protocols_block_t static_iterateHandler = TrampolineIterateHandler;

		[MonoPInvokeCallback (typeof (nw_protocol_stack_iterate_protocols_block_t))]
#else
		[UnmanagedCallersOnly]
#endif
		static void TrampolineIterateHandler (IntPtr block, IntPtr options)
		{
			var del = BlockLiteral.GetTarget<Action<NWProtocolOptions>> (block);
			if (del is not null) {
				using (var tempOptions = new NWProtocolOptions (options, owns: false))
				using (var definition = tempOptions.ProtocolDefinition) {
					NWProtocolOptions? castedOptions = null;

					if (definition.Equals (NWProtocolDefinition.CreateTcpDefinition ())) {
						castedOptions = new NWProtocolTcpOptions (options, owns: false);
					} else if (definition.Equals (NWProtocolDefinition.CreateUdpDefinition ())) {
						castedOptions = new NWProtocolUdpOptions (options, owns: false);
					} else if (definition.Equals (NWProtocolDefinition.CreateTlsDefinition ())) {
						castedOptions = new NWProtocolTlsOptions (options, owns: false);
#pragma warning disable CA1416 // This call site is reachable on: 'ios' 12.2 and later, 'maccatalyst' 12.2 and later, 'macOS/OSX' 12.0 and later, 'tvos' 12.2 and later. 'NWProtocolIPOptions' is only supported on: 'ios' 13.0 and later, 'maccatalyst' 13.0 and later, 'tvos' 13.0 and later.
					} else if (definition.Equals (NWProtocolDefinition.CreateIPDefinition ())) {
						castedOptions = new NWProtocolIPOptions (options, owns: false);
#pragma warning restore CA1416
#pragma warning disable CA1416 // This call site is reachable on: 'ios' 12.2 and later, 'maccatalyst' 12.2 and later, 'macOS/OSX' 12.0 and later, 'tvos' 12.2 and later. 'NWWebSocketOptions' is only supported on: 'ios' 13.0 and later, 'maccatalyst' 13.0 and later, 'tvos' 13.0 and later.
					} else if (definition.Equals (NWProtocolDefinition.CreateWebSocketDefinition ())) {
						castedOptions = new NWWebSocketOptions (options, owns: false);
#pragma warning restore CA1416
					}

					del (castedOptions ?? tempOptions);
					castedOptions?.Dispose ();
				}
			}
		}

		[DllImport (Constants.NetworkLibrary)]
		unsafe extern static void nw_protocol_stack_iterate_application_protocols (nw_protocol_stack_t stack, BlockLiteral* completion);

		[BindingImpl (BindingImplOptions.Optimizable)]
		public void IterateProtocols (Action<NWProtocolOptions> callback)
		{
			unsafe {
#if NET
				delegate* unmanaged<IntPtr, IntPtr, void> trampoline = &TrampolineIterateHandler;
				using var block = new BlockLiteral (trampoline, callback, typeof (NWProtocolStack), nameof (TrampolineIterateHandler));
#else
				using var block = new BlockLiteral ();
				block.SetupBlockUnsafe (static_iterateHandler, callback);
#endif
				nw_protocol_stack_iterate_application_protocols (GetCheckedHandle (), &block);
			}
		}

		[DllImport (Constants.NetworkLibrary)]
		extern static IntPtr nw_protocol_stack_copy_transport_protocol (nw_protocol_stack_t stack);

		[DllImport (Constants.NetworkLibrary)]
		extern static void nw_protocol_stack_set_transport_protocol (nw_protocol_stack_t stack, IntPtr value);

		public NWProtocolOptions? TransportProtocol {
			get {
				var pHandle = nw_protocol_stack_copy_transport_protocol (GetCheckedHandle ());
				if (pHandle == IntPtr.Zero)
					return null;
				var tempOptions = new NWProtocolOptions (pHandle, owns: true);

				using (var definition = tempOptions.ProtocolDefinition) {
					NWProtocolOptions? castedOptions = null;
					if (definition.Equals (NWProtocolDefinition.CreateTcpDefinition ())) {
						castedOptions = new NWProtocolTcpOptions (pHandle, owns: true);
					}
					if (definition.Equals (NWProtocolDefinition.CreateUdpDefinition ())) {
						castedOptions = new NWProtocolUdpOptions (pHandle, owns: true);
					}
					if (castedOptions is null) {
						return tempOptions;
					} else {
						tempOptions.Dispose ();
						return castedOptions;
					}
				}
			}
			set => nw_protocol_stack_set_transport_protocol (GetCheckedHandle (), value.GetHandle ());
		}

		[DllImport (Constants.NetworkLibrary)]
		extern static IntPtr nw_protocol_stack_copy_internet_protocol (nw_protocol_stack_t stack);

#if NET
		[SupportedOSPlatform ("tvos13.0")]
		[SupportedOSPlatform ("macos12.0")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst15.0")]
		public NWProtocolIPOptions? InternetProtocol {
#else
		public NWProtocolOptions? InternetProtocol {
#endif
			get {
				var pHandle = nw_protocol_stack_copy_internet_protocol (GetCheckedHandle ());
				return (pHandle == IntPtr.Zero) ? null : new NWProtocolIPOptions (pHandle, owns: true);
			}
		}
	}
}
