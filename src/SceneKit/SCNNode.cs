//
// SCNNode.cs: extensions to SCNNode
//
// Authors:
//   Aaron Bockover (abock@xamarin.com)   
//
// Copyright Xamarin Inc.
//

using System;
using System.Collections;
using System.Collections.Generic;

using CoreAnimation;
using Foundation;
using ObjCRuntime;

#nullable enable

namespace SceneKit {
	public partial class SCNNode : IEnumerable, IEnumerable<SCNNode> {
		public void Add (SCNNode node)
		{
			AddChildNode (node);
		}

		public void AddNodes (params SCNNode [] nodes)
		{
			if (nodes is null)
				return;
			foreach (var n in nodes)
				AddChildNode (n);
		}

		public IEnumerator<SCNNode> GetEnumerator ()
		{
			foreach (var node in ChildNodes)
				yield return node;
		}

		IEnumerator IEnumerable.GetEnumerator ()
		{
			return GetEnumerator ();
		}

		public void AddAnimation (CAAnimation animation, string? key)
		{
			if (key is null) {
				((ISCNAnimatable) this).AddAnimation (animation, (NSString?) null);
			} else {
				using (var s = new NSString (key))
					((ISCNAnimatable) this).AddAnimation (animation, s);
			}
		}

		[ObsoletedOSPlatform ("tvos11.0", "Use 'RemoveAnimationUsingBlendOutDuration' instead.")]
		[ObsoletedOSPlatform ("ios11.0", "Use 'RemoveAnimationUsingBlendOutDuration' instead.")]
		[ObsoletedOSPlatform ("macos10.13", "Use 'RemoveAnimationUsingBlendOutDuration' instead.")]
		[SupportedOSPlatform ("maccatalyst15.0")]
		[ObsoletedOSPlatform ("maccatalyst13.1", "Use 'RemoveAnimationUsingBlendOutDuration' instead.")]
		[SupportedOSPlatform ("ios12.2")]
		[SupportedOSPlatform ("macos12.0")]
		[SupportedOSPlatform ("tvos12.2")]
		public void RemoveAnimation (string key, nfloat duration)
		{
			if (string.IsNullOrEmpty (key))
				ObjCRuntime.ThrowHelper.ThrowArgumentException (nameof (key));

			using (var s = new NSString (key))
				((ISCNAnimatable) this).RemoveAnimation (s, duration);
		}

		public void RemoveAnimation (string key)
		{
			if (string.IsNullOrEmpty (key))
				ObjCRuntime.ThrowHelper.ThrowArgumentException (nameof (key));

			using (var s = new NSString (key))
				((ISCNAnimatable) this).RemoveAnimation (s);
		}

		[ObsoletedOSPlatform ("tvos11.0", "Use 'GetAnimationPlayer' instead.")]
		[ObsoletedOSPlatform ("ios11.0", "Use 'GetAnimationPlayer' instead.")]
		[ObsoletedOSPlatform ("macos10.13", "Use 'GetAnimationPlayer' instead.")]
		[SupportedOSPlatform ("maccatalyst15.0")]
		[ObsoletedOSPlatform ("maccatalyst13.1", "Use 'GetAnimationPlayer' instead.")]
		[SupportedOSPlatform ("ios12.2")]
		[SupportedOSPlatform ("macos12.0")]
		[SupportedOSPlatform ("tvos12.2")]
		public CAAnimation? GetAnimation (string key)
		{
			if (string.IsNullOrEmpty (key))
				ObjCRuntime.ThrowHelper.ThrowArgumentException (nameof (key));

			using (var s = new NSString (key))
				return ((ISCNAnimatable) this).GetAnimation (s);
		}

		[ObsoletedOSPlatform ("tvos11.0", "Use 'SCNAnimationPlayer.Paused' instead.")]
		[ObsoletedOSPlatform ("ios11.0", "Use 'SCNAnimationPlayer.Paused' instead.")]
		[ObsoletedOSPlatform ("macos10.13", "Use 'SCNAnimationPlayer.Paused' instead.")]
		[SupportedOSPlatform ("maccatalyst15.0")]
		[ObsoletedOSPlatform ("maccatalyst13.1", "Use 'SCNAnimationPlayer.Paused' instead.")]
		[SupportedOSPlatform ("ios12.2")]
		[SupportedOSPlatform ("macos12.0")]
		[SupportedOSPlatform ("tvos12.2")]
		public void PauseAnimation (string key)
		{
			if (string.IsNullOrEmpty (key))
				ObjCRuntime.ThrowHelper.ThrowArgumentException (nameof (key));

			using (var s = new NSString (key))
				((ISCNAnimatable) this).PauseAnimation (s);
		}

		[ObsoletedOSPlatform ("tvos11.0", "Use 'SCNAnimationPlayer.Paused' instead.")]
		[ObsoletedOSPlatform ("ios11.0", "Use 'SCNAnimationPlayer.Paused' instead.")]
		[ObsoletedOSPlatform ("macos10.13", "Use 'SCNAnimationPlayer.Paused' instead.")]
		[SupportedOSPlatform ("maccatalyst15.0")]
		[ObsoletedOSPlatform ("maccatalyst13.1", "Use 'SCNAnimationPlayer.Paused' instead.")]
		[SupportedOSPlatform ("ios12.2")]
		[SupportedOSPlatform ("macos12.0")]
		[SupportedOSPlatform ("tvos12.2")]
		public void ResumeAnimation (string key)
		{
			if (string.IsNullOrEmpty (key))
				ObjCRuntime.ThrowHelper.ThrowArgumentException (nameof (key));

			using (var s = new NSString (key))
				((ISCNAnimatable) this).ResumeAnimation (s);
		}

		[ObsoletedOSPlatform ("tvos11.0", "Use 'SCNAnimationPlayer.Paused' instead.")]
		[ObsoletedOSPlatform ("ios11.0", "Use 'SCNAnimationPlayer.Paused' instead.")]
		[ObsoletedOSPlatform ("macos10.13", "Use 'SCNAnimationPlayer.Paused' instead.")]
		[SupportedOSPlatform ("maccatalyst15.0")]
		[ObsoletedOSPlatform ("maccatalyst13.1", "Use 'SCNAnimationPlayer.Paused' instead.")]
		[SupportedOSPlatform ("ios12.2")]
		[SupportedOSPlatform ("macos12.0")]
		[SupportedOSPlatform ("tvos12.2")]
		public bool IsAnimationPaused (string key)
		{
			if (string.IsNullOrEmpty (key))
				ObjCRuntime.ThrowHelper.ThrowArgumentException (nameof (key));

			bool isPaused;

			using (var s = new NSString (key))
				isPaused = ((ISCNAnimatable) this).IsAnimationPaused (s);

			return isPaused;
		}

#if !NET
		// SCNNodePredicate is defined as:
		// 	delegate bool SCNNodePredicate (SCNNode node, out bool stop);
		// but the actual objective-c definition of the block is
		// 	void (^)(SCNNode *child, BOOL *stop)
		//
		[Obsolete ("Use the overload that takes a 'SCNNodeHandler' instead.")]
		public virtual void EnumerateChildNodes (SCNNodePredicate predicate)
		{
			SCNNodeHandler predHandler = (SCNNode node, out bool stop) => {
				predicate (node, out stop);
			};
			EnumerateChildNodes (predHandler);
		}
#endif
	}
}
