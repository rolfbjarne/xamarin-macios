#if !COREBUILD

namespace Foundation {
	public partial class NSProgress {
		//Manual bindings until BindAs support is merged
		/// <summary>Gets or sets the estimated time remaining.</summary>
		public nint? EstimatedTimeRemaining {
			get { return _EstimatedTimeRemaining?.NIntValue; }
			set { _EstimatedTimeRemaining = value is not null ? new NSNumber (value.Value) : null; }
		}

		/// <summary>Gets or sets the throughput.</summary>
		public nint? Throughput {
			get { return _Throughput?.NIntValue; }
			set { _Throughput = value is not null ? new NSNumber (value.Value) : null; }
		}

		/// <summary>Gets or sets the file total count.</summary>
		public nint? FileTotalCount {
			get { return _FileTotalCount?.NIntValue; }
			set { _FileTotalCount = value is not null ? new NSNumber (value.Value) : null; }
		}

		/// <summary>Gets or sets the file completed count.</summary>
		public nint? FileCompletedCount {
			get { return _FileCompletedCount?.NIntValue; }
			set { _FileCompletedCount = value is not null ? new NSNumber (value.Value) : null; }
		}
	}
}
#endif
