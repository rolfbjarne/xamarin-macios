//
// DispatchBlock.cs: Support for creating dispatch blocks.
//
// Authors:
//   Miguel de Icaza (miguel@gnome.org)
//
// Copyright 2019 Microsoft Corp.
//
//

#nullable enable

using System.Threading;

namespace CoreFoundation {
#if !COREBUILD
	/// <summary>To be added.</summary>
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("tvos")]
	public sealed class DispatchBlock : NativeObject {
		[Preserve (Conditional = true)]
		internal DispatchBlock (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}

		/// <param name="action">The action to perform.</param>
		///         <param name="flags">The flags.</param>
		///         <summary>To be added.</summary>
		public DispatchBlock (Action action, DispatchBlockFlags flags = DispatchBlockFlags.None)
			: base (create (action, flags), true)
		{
		}

		/// <param name="action">The action to perform.</param>
		///         <param name="flags">The flags.</param>
		///         <param name="qosClass">The qos class.</param>
		///         <param name="relative_priority">The relative_priority.</param>
		///         <summary>To be added.</summary>
		public DispatchBlock (Action action, DispatchBlockFlags flags, DispatchQualityOfService qosClass, int relative_priority)
			: base (create (flags, qosClass, relative_priority, action), true)
		{
		}

		/// <param name="dispatchBlock">The dispatch block.</param>
		///         <param name="flags">The flags.</param>
		///         <param name="qosClass">The qos class.</param>
		///         <param name="relative_priority">The relative_priority.</param>
		///         <summary>To be added.</summary>
		public DispatchBlock (DispatchBlock dispatchBlock, DispatchBlockFlags flags, DispatchQualityOfService qosClass, int relative_priority)
			: base (dispatch_block_create_with_qos_class ((nuint) (ulong) flags, qosClass, relative_priority, dispatchBlock.GetNonNullHandle (nameof (dispatchBlock))), true)
		{
			GC.KeepAlive (dispatchBlock);
		}

		/// <param name="action">The action to perform.</param>
		///         <param name="flags">The flags.</param>
		///         <summary>To be added.</summary>
		public static DispatchBlock Create (Action action, DispatchBlockFlags flags = DispatchBlockFlags.None)
		{
			if (action is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (action));
			return new DispatchBlock (action, flags);
		}

		/// <param name="action">The action to perform.</param>
		///         <param name="flags">The flags.</param>
		///         <param name="qosClass">The qos class.</param>
		///         <param name="relative_priority">The relative_priority.</param>
		///         <summary>To be added.</summary>
		public static DispatchBlock Create (Action action, DispatchBlockFlags flags, DispatchQualityOfService qosClass, int relative_priority)
		{
			if (action is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (action));
			return new DispatchBlock (action, flags, qosClass, relative_priority);
		}

		/// <param name="block">The block.</param>
		///         <param name="flags">The flags.</param>
		///         <param name="qosClass">The qos class.</param>
		///         <param name="relative_priority">The relative_priority.</param>
		///         <summary>To be added.</summary>
		public static DispatchBlock Create (DispatchBlock block, DispatchBlockFlags flags, DispatchQualityOfService qosClass, int relative_priority)
		{
			if (block is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (block));
			return block.Create (flags, qosClass, relative_priority);
		}

		/// <param name="flags">The flags.</param>
		///         <param name="qosClass">The qos class.</param>
		///         <param name="relative_priority">The relative_priority.</param>
		///         <summary>To be added.</summary>
		public DispatchBlock Create (DispatchBlockFlags flags, DispatchQualityOfService qosClass, int relative_priority)
		{
			return new DispatchBlock (dispatch_block_create_with_qos_class ((nuint) (ulong) flags, qosClass, relative_priority, GetCheckedHandle ()), true);
		}

		/// <summary>To be added.</summary>
		protected internal override void Retain ()
		{
			// Retaining a block (using _Block_copy) can move it, if it's originally
			// a stack-allocated block (it will become a heap-allocated block), and
			// in that case we end up with a different handle (so we're not)
			InitializeHandle (BlockLiteral._Block_copy (GetCheckedHandle ()));
		}

		/// <summary>To be added.</summary>
		protected internal override void Release ()
		{
			BlockLiteral._Block_release (GetCheckedHandle ());
		}

		[DllImport (Constants.libcLibrary)]
		unsafe extern static IntPtr dispatch_block_create (/*DispatchBlockFlags*/ nuint flags, BlockLiteral* block);

		// Returns a retained heap-allocated block
		[BindingImpl (BindingImplOptions.Optimizable)]
		static IntPtr create (Action action, DispatchBlockFlags flags)
		{
			if (action is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (action));

			unsafe {
				using var block = BlockStaticDispatchClass.CreateBlock (action);
				return dispatch_block_create ((nuint) (ulong) flags, &block);
			}
		}

		[DllImport (Constants.libcLibrary)]
		unsafe extern static IntPtr dispatch_block_create_with_qos_class (/*DispatchBlockFlags*/ nuint flags, DispatchQualityOfService qosClass, int relative_priority, BlockLiteral* dispatchBlock);

		[DllImport (Constants.libcLibrary)]
		extern static IntPtr dispatch_block_create_with_qos_class (/*DispatchBlockFlags*/ nuint flags, DispatchQualityOfService qosClass, int relative_priority, IntPtr dispatchBlock);

		// Returns a retained heap-allocated block
		[BindingImpl (BindingImplOptions.Optimizable)]
		static IntPtr create (DispatchBlockFlags flags, DispatchQualityOfService qosClass, int relative_priority, Action action)
		{
			if (action is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (action));

			unsafe {
				using var block = BlockStaticDispatchClass.CreateBlock (action);
				return dispatch_block_create_with_qos_class ((nuint) (ulong) flags, qosClass, relative_priority, &block);
			}
		}

		[DllImport (Constants.libcLibrary)]
		extern static void dispatch_block_cancel (IntPtr block);

		/// <summary>To be added.</summary>
		public void Cancel ()
		{
			dispatch_block_cancel (GetCheckedHandle ());
		}

		[DllImport (Constants.libcLibrary)]
		extern static void dispatch_block_notify (IntPtr block, IntPtr queue, IntPtr notification);

		/// <param name="queue">The dispatch queue on which to execute.</param>
		///         <param name="notification">The notification.</param>
		///         <summary>To be added.</summary>
		public void Notify (DispatchQueue queue, Action notification)
		{
			if (notification is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (notification));
			using (var block = new DispatchBlock (notification))
				Notify (queue, block);
		}

		/// <param name="queue">The dispatch queue on which to execute.</param>
		///         <param name="notification">The notification.</param>
		///         <summary>To be added.</summary>
		public void Notify (DispatchQueue queue, DispatchBlock notification)
		{
			if (queue is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (queue));
			if (notification is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (notification));
			dispatch_block_notify (GetCheckedHandle (), queue.GetCheckedHandle (), notification.GetCheckedHandle ());
			GC.KeepAlive (queue);
			GC.KeepAlive (notification);
		}

		[DllImport (Constants.libcLibrary)]
		extern static nint dispatch_block_testcancel (IntPtr block);

		/// <summary>To be added.</summary>
		public nint TestCancel ()
		{
			return dispatch_block_testcancel (GetCheckedHandle ());
		}

		/// <summary>To be added.</summary>
		public bool Cancelled {
			get { return TestCancel () != 0; }
		}

		[DllImport (Constants.libcLibrary)]
		extern static nint dispatch_block_wait (IntPtr block, DispatchTime time);

		/// <param name="time">The time.</param>
		///         <summary>To be added.</summary>
		public nint Wait (DispatchTime time)
		{
			return dispatch_block_wait (GetCheckedHandle (), time);
		}

		/// <param name="timeout">The timeout duration.</param>
		///         <summary>To be added.</summary>
		public nint Wait (TimeSpan timeout)
		{
			return Wait (new DispatchTime (DispatchTime.Now, timeout));
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void DispatchBlockCallback (IntPtr block);

		public static explicit operator Action? (DispatchBlock block)
		{
			if (block is null)
				return null;

			unsafe {
				var handle = (BlockLiteral*) (IntPtr) block.GetCheckedHandle ();
				var del = handle->GetDelegateForBlock<DispatchBlockCallback> ();
				var result = new Action (() => del ((IntPtr) block.GetCheckedHandle ()));
				GC.KeepAlive (block);
				return result;
			}
		}

		/// <summary>To be added.</summary>
		public void Invoke ()
		{
			((Action) this!) ();
		}
	}

	/// <summary>To be added.</summary>
	[Flags]
	[Native]
	public enum DispatchBlockFlags : ulong {
		/// <summary>Indicates none.</summary>
		None,
		/// <summary>Indicates barrier.</summary>
		Barrier = 1,
		/// <summary>Indicates detached.</summary>
		Detached = 2,
		/// <summary>Indicates assign current.</summary>
		AssignCurrent = 4,
		/// <summary>Indicates no qos class.</summary>
		NoQosClass = 8,
		/// <summary>Indicates inherit qos class.</summary>
		InheritQosClass = 16,
		/// <summary>Indicates enforce qos class.</summary>
		EnforceQosClass = 32,
	}
#endif // !COREBUILD
}
