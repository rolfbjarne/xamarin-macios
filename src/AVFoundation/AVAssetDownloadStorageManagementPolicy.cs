#if IOS

#nullable enable

namespace AVFoundation {
	public partial class AVAssetDownloadStorageManagementPolicy {

		/// <summary>Gets or sets the priority.</summary>
		public virtual AVAssetDownloadedAssetEvictionPriority Priority {
			get { return AVAssetDownloadedAssetEvictionPriorityExtensions.GetValue (_Priority); }
			set { throw new NotImplementedException (); }
		}
	}

	public partial class AVMutableAssetDownloadStorageManagementPolicy {

		/// <summary>Gets or sets the priority.</summary>
		public override AVAssetDownloadedAssetEvictionPriority Priority {
			get { return AVAssetDownloadedAssetEvictionPriorityExtensions.GetValue (_Priority); }
			set { _Priority = value.GetConstant () ?? throw new ArgumentOutOfRangeException (nameof (Priority)); }
		}
	}
}

#endif
