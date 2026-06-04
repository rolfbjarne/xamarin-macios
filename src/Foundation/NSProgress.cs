#if !COREBUILD

namespace Foundation {
	public partial class NSProgress {
		//Manual bindings until BindAs support is merged
		/// <summary>To be added.</summary>
		///         <value>To be added.</value>
		public nint? EstimatedTimeRemaining {
			get { return _EstimatedTimeRemaining?.NIntValue; }
			set { _EstimatedTimeRemaining = value is not null ? new NSNumber (value.Value) : null; }
		}

		/// <summary>To be added.</summary>
		///         <value>To be added.</value>
		public nint? Throughput {
			get { return _Throughput?.NIntValue; }
			set { _Throughput = value is not null ? new NSNumber (value.Value) : null; }
		}

		/// <summary>To be added.</summary>
		///         <value>To be added.</value>
		public nint? FileTotalCount {
			get { return _FileTotalCount?.NIntValue; }
			set { _FileTotalCount = value is not null ? new NSNumber (value.Value) : null; }
		}

		/// <summary>To be added.</summary>
		///         <value>To be added.</value>
		public nint? FileCompletedCount {
			get { return _FileCompletedCount?.NIntValue; }
			set { _FileCompletedCount = value is not null ? new NSNumber (value.Value) : null; }
		}
	}
}
#endif
