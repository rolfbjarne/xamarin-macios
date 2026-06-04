using System.ComponentModel;
using System.Threading.Tasks;

#nullable enable

namespace PassKit {
#if !XAMCORE_5_0
#if __IOS__ || __MACCATALYST__
	// Apple just removed this class from their headers in Xcode 15 (beta 1).
	// It's also not found on their documentation site, so I'm assuming it's done on purpose.
	/// <summary>To be added.</summary>
	///     <remarks>To be added.</remarks>
	[UnsupportedOSPlatform ("macos")]
	[UnsupportedOSPlatform ("ios")]
	[UnsupportedOSPlatform ("maccatalyst")]
	[EditorBrowsable (EditorBrowsableState.Never)]
	[Obsolete ("This class is removed.")]
	public unsafe partial class PKDisbursementVoucher : NSObject {

		/// <summary>To be added.</summary>
		public override NativeHandle ClassHandle => throw new InvalidOperationException (Constants.RemovedFromPassKit);

		/// <param name="t">The t.</param>
		///         <summary>To be added.</summary>
		protected PKDisbursementVoucher (NSObjectFlag t) : base (t)
		{
			throw new InvalidOperationException (Constants.RemovedFromPassKit);
		}

		protected internal PKDisbursementVoucher (NativeHandle handle) : base (handle)
		{
			throw new InvalidOperationException (Constants.RemovedFromPassKit);
		}

		/// <summary>To be added.</summary>
		public virtual NSData Data => throw new InvalidOperationException (Constants.RemovedFromPassKit);
		/// <summary>To be added.</summary>
		public virtual NSUrl RedemptionUrl => throw new InvalidOperationException (Constants.RemovedFromPassKit);
	} /* class PKDisbursementVoucher */

	// Apple just removed this class from their headers in Xcode 15 (beta 1).
	// It's also not found on their documentation site, so I'm assuming it's done on purpose.
	/// <summary>To be added.</summary>
	///     <remarks>To be added.</remarks>
	[UnsupportedOSPlatform ("macos")]
	[UnsupportedOSPlatform ("ios")]
	[UnsupportedOSPlatform ("maccatalyst")]
	[EditorBrowsable (EditorBrowsableState.Never)]
	[Obsolete ("This class is removed.")]
	public unsafe partial class PKDisbursementAuthorizationController : NSObject {

		/// <summary>To be added.</summary>
		public override NativeHandle ClassHandle { get { throw new InvalidOperationException (Constants.RemovedFromPassKit); } }

		/// <param name="t">The t.</param>
		///         <summary>To be added.</summary>
		protected PKDisbursementAuthorizationController (NSObjectFlag t) : base (t)
		{
			throw new InvalidOperationException (Constants.RemovedFromPassKit);
		}

		protected internal PKDisbursementAuthorizationController (NativeHandle handle) : base (handle)
		{
			throw new InvalidOperationException (Constants.RemovedFromPassKit);
		}

		/// <param name="disbursementRequest">The disbursement request.</param>
		///         <param name="delegate">The delegate to use.</param>
		///         <summary>To be added.</summary>
		public PKDisbursementAuthorizationController (PKDisbursementRequest disbursementRequest, IPKDisbursementAuthorizationControllerDelegate @delegate)
			: base (NSObjectFlag.Empty)
		{
			throw new InvalidOperationException (Constants.RemovedFromPassKit);
		}

		/// <param name="completion">The completion.</param>
		///         <summary>To be added.</summary>
		public unsafe virtual void AuthorizeDisbursement (global::System.Action<bool, NSError> completion)
		{
			throw new InvalidOperationException (Constants.RemovedFromPassKit);
		}

		/// <summary>To be added.</summary>
		public unsafe virtual Task<Tuple<bool, NSError>> AuthorizeDisbursementAsync ()
		{
			throw new InvalidOperationException (Constants.RemovedFromPassKit);
		}

		/// <summary>To be added.</summary>
		public IPKDisbursementAuthorizationControllerDelegate Delegate {
			get {
				throw new InvalidOperationException (Constants.RemovedFromPassKit);
			}
		}

		/// <summary>To be added.</summary>
		public static bool SupportsDisbursements {
			get {
				throw new InvalidOperationException (Constants.RemovedFromPassKit);
			}
		}

		/// <summary>To be added.</summary>
		public virtual NSObject? WeakDelegate {
			get {
				throw new InvalidOperationException (Constants.RemovedFromPassKit);
			}
		}

		/// <inheritdoc />
		protected override void Dispose (bool disposing)
		{
			throw new InvalidOperationException (Constants.RemovedFromPassKit);
		}
	} /* class PKDisbursementAuthorizationController */

	// Apple just removed this protocol from their headers in Xcode 15 (beta 1).
	// It's also not found on their documentation site, so I'm assuming it's done on purpose.
	/// <summary>To be added.</summary>
	///     <remarks>To be added.</remarks>
	[UnsupportedOSPlatform ("macos")]
	[UnsupportedOSPlatform ("ios")]
	[UnsupportedOSPlatform ("maccatalyst")]
	[EditorBrowsable (EditorBrowsableState.Never)]
	[Obsolete ("This class is removed.")]
	public partial interface IPKDisbursementAuthorizationControllerDelegate : INativeObject, IDisposable {
		/// <param name="controller">To be added.</param>
		///         <param name="disbursementVoucher">To be added.</param>
		///         <summary>To be added.</summary>
		void DidAuthorize (PKDisbursementAuthorizationController controller, PKDisbursementVoucher disbursementVoucher);
		/// <param name="controller">The controller.</param>
		///         <summary>To be added.</summary>
		void DidFinish (PKDisbursementAuthorizationController controller);
	}

	// Apple just removed this protocol from their headers in Xcode 15 (beta 1).
	// It's also not found on their documentation site, so I'm assuming it's done on purpose.
	/// <summary>To be added.</summary>
	///     <remarks>To be added.</remarks>
	[UnsupportedOSPlatform ("macos")]
	[UnsupportedOSPlatform ("ios")]
	[UnsupportedOSPlatform ("maccatalyst")]
	[EditorBrowsable (EditorBrowsableState.Never)]
	[Obsolete ("This class is removed.")]
	public unsafe abstract partial class PKDisbursementAuthorizationControllerDelegate : NSObject, IPKDisbursementAuthorizationControllerDelegate {
		/// <summary>To be added.</summary>
		///         <remarks>To be added.</remarks>
		protected PKDisbursementAuthorizationControllerDelegate () : base (NSObjectFlag.Empty)
		{
			throw new InvalidOperationException (Constants.RemovedFromPassKit);
		}

		/// <param name="t">The t.</param>
		///         <summary>To be added.</summary>
		protected PKDisbursementAuthorizationControllerDelegate (NSObjectFlag t) : base (t)
		{
			throw new InvalidOperationException (Constants.RemovedFromPassKit);
		}

		protected internal PKDisbursementAuthorizationControllerDelegate (NativeHandle handle) : base (handle)
		{
			throw new InvalidOperationException (Constants.RemovedFromPassKit);
		}

		/// <param name="controller">The controller.</param>
		///         <param name="disbursementVoucher">The disbursement voucher.</param>
		///         <summary>To be added.</summary>
		public virtual void DidAuthorize (PKDisbursementAuthorizationController controller, PKDisbursementVoucher disbursementVoucher)
		{
			throw new InvalidOperationException (Constants.RemovedFromPassKit);
		}

		/// <param name="controller">The controller.</param>
		///         <summary>To be added.</summary>
		public virtual void DidFinish (PKDisbursementAuthorizationController controller)
		{
			throw new InvalidOperationException (Constants.RemovedFromPassKit);
		}
	} /* class PKDisbursementAuthorizationControllerDelegate */

	/// <summary>To be added.</summary>
	public partial class PKDisbursementRequest {

		// Apple just removed this protocol from their headers in Xcode 15 (beta 1).
		// It's also not found on their documentation site, so I'm assuming it's done on purpose.
		/// <summary>To be added.</summary>
		[UnsupportedOSPlatform ("macos")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[EditorBrowsable (EditorBrowsableState.Never)]
		[Obsolete ("This property is removed.")]
		public virtual NSDecimalNumber Amount {
			get => throw new InvalidOperationException (Constants.RemovedFromPassKit);
			set => throw new InvalidOperationException (Constants.RemovedFromPassKit);
		}

		/// <summary>To be added.</summary>
		[UnsupportedOSPlatform ("macos")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[EditorBrowsable (EditorBrowsableState.Never)]
		[Obsolete ("This property is removed.")]
		public virtual string CountryCode {
			get => throw new InvalidOperationException (Constants.RemovedFromPassKit);
			set => throw new InvalidOperationException (Constants.RemovedFromPassKit);
		}

		/// <summary>To be added.</summary>
		[UnsupportedOSPlatform ("macos")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[EditorBrowsable (EditorBrowsableState.Never)]
		[Obsolete ("This property is removed.")]
		public virtual PKDisbursementRequestSchedule RequestSchedule {
			get => throw new InvalidOperationException (Constants.RemovedFromPassKit);
			set => throw new InvalidOperationException (Constants.RemovedFromPassKit);
		}

	} /* class PKDisbursementRequest */
#endif // __IOS__ || __MACCATALYST__
#endif // !XAMCORE_5_0
}
