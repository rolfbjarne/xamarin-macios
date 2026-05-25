//
// Auto-generated from generator.cs, do not edit
//
// We keep references to objects, so warning 414 is expected
#pragma warning disable 414
using System;
using System.Drawing;
using System.Diagnostics;
using System.ComponentModel;
using System.Threading.Tasks;
using System.Runtime.Versioning;
using System.Runtime.InteropServices;
using System.Diagnostics.CodeAnalysis;
using UIKit;
using GLKit;
using Metal;
using CoreML;
using Photos;
using ModelIO;
using Network;
using SceneKit;
using Security;
using AudioUnit;
using CoreVideo;
using CoreMedia;
using CoreImage;
using SpriteKit;
using Foundation;
using ObjCRuntime;
using MediaPlayer;
using GameplayKit;
using CoreGraphics;
using CoreLocation;
using AVFoundation;
using CoreAnimation;
using CoreFoundation;
using NetworkExtension;
using MetalPerformanceShadersGraph;
#nullable enable
namespace SceneKit {
	/// <summary>Configuration options for hit-testing in SCNNode and SCNSceneRenderer</summary><remarks><para>
	/// 	You create an instance of this class to configure how hit-testing should be evaluated by the HitTest methods.
	/// </para><para>
	/// 	Hit testing uses two 3D vectors in the case of <see cref="T:SceneKit.SCNNode" /> and a 2D point in the case of the <see cref="T:SceneKit.SCNSceneRenderer" />.
	/// </para></remarks>
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("tvos")]
	public partial class SCNHitTestOptions : DictionaryContainer {
#if !COREBUILD
		/// <summary>Creates a new <see cref="SCNHitTestOptions" /> with default (empty) values.</summary>
		public SCNHitTestOptions () : base (new NSMutableDictionary ()) {}
		/// <summary>Creates a new <see cref="SCNHitTestOptions" /> from the values that are specified in <paramref name="dictionary" />.</summary>
		/// <param name="dictionary">The dictionary to use to populate the properties of this type.</param>
		public SCNHitTestOptions (NSDictionary? dictionary) : base (dictionary) {}
		/// <summary>Controls whether only the first hit match is returned.   Caveat: the first match returned might not be the nearest object.</summary><value>If not specified, the value assumed is false.</value><remarks></remarks>
		public bool? FirstFoundOnly {
			get {
				return  GetBoolValue (SCNHitTest.FirstFoundOnlyKey!);
			}
			set {
				SetBooleanValue (SCNHitTest.FirstFoundOnlyKey!, value);
			}
		}
		/// <summary>If set, sorts the returned hit-test results from nearest to farthest.</summary><value>If not specified, the value is assumed to be true, so the results are sorted.</value><remarks></remarks>
		public bool? SortResults {
			get {
				return  GetBoolValue (SCNHitTest.SortResultsKey!);
			}
			set {
				SetBooleanValue (SCNHitTest.SortResultsKey!, value);
			}
		}
		/// <summary>Determines whether to ignore polygons that are not facing the camera for hit-testing.</summary><value>If not specified, the default is to assume that you want back-face culling.</value><remarks></remarks>
		public bool? BackFaceCulling {
			get {
				return  GetBoolValue (SCNHitTest.BackFaceCullingKey!);
			}
			set {
				SetBooleanValue (SCNHitTest.BackFaceCullingKey!, value);
			}
		}
		/// <summary>Controls whether hit-testing uses the node's geometry, or whether a bounding box is used to optimize performance.</summary><value>If this value is not specified, the value assumed is false.</value><remarks>
		/// 	  By default, the hit-testing will use the node's geometry
		/// 	  information to determine whether there was a hit.  This
		/// 	  process can be slow, so you can set this property to true to
		/// 	  constrain the search space to the bounding box of the
		/// 	  target.
		/// 	</remarks>
		public bool? BoundingBoxOnly {
			get {
				return  GetBoolValue (SCNHitTest.BoundingBoxOnlyKey!);
			}
			set {
				SetBooleanValue (SCNHitTest.BoundingBoxOnlyKey!, value);
			}
		}
		/// <summary>Controls whether hit-testing will consider all nodes of the hierarchy, or only the node specified in the RootNode property.</summary><value>If not specified, the value is assumed to be false.</value><remarks>
		/// 	  By default this will search all the nodes in the hierarchy.
		/// 	  If you set this value to true, you can limit the search to
		/// 	  the node specified in <see cref="P:SceneKit.SCNHitTestOptions.RootNode" />
		/// 	  property.
		/// 	</remarks>
		public bool? IgnoreChildNodes {
			get {
				return  GetBoolValue (SCNHitTest.IgnoreChildNodesKey!);
			}
			set {
				SetBooleanValue (SCNHitTest.IgnoreChildNodesKey!, value);
			}
		}
		/// <summary>Controls whether hit-testing will return hidden nodes or not.</summary><value>If not specified, the value is assumed to be true.</value><remarks>
		/// 	  The default is to skip hidden nodes.   Set this value to false if you want to perform hit-testing including nodes that have set their <see cref="P:SceneKit.SCNNode.Hidden" /> property to true.
		/// 	</remarks>
		public bool? IgnoreHiddenNodes {
			get {
				return  GetBoolValue (SCNHitTest.IgnoreHiddenNodesKey!);
			}
			set {
				SetBooleanValue (SCNHitTest.IgnoreHiddenNodesKey!, value);
			}
		}
		/// <summary>Limits the hit-testing to this node as well as its children (you must also set IgnoreChildNodes).</summary><value><para>
		/// 	    The node that will be used as the root node to search for hits.
		/// 	  </para><para>
		/// 	    If not specified, when used with a <see cref="T:SceneKit.SCNSceneRenderer" /> the default
		/// 	    value would be the presented scene's root node.
		/// 	  </para><para>
		/// 	    If not specified, when used with a <see cref="T:SceneKit.SCNNode" /> the default
		/// 	    value is the node itself.
		/// 	  </para></value><remarks><para></para></remarks>
		public SCNNode? RootNode {
			get {
				return Dictionary [SCNHitTest.RootNodeKey!] as SceneKit.SCNNode;
			}
			set {
				SetNativeValue (SCNHitTest.RootNodeKey!, value);
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		public SCNHitTestSearchMode? SearchMode {
			get {
				return (SCNHitTestSearchMode?) (long?) GetNIntValue (SCNHitTest.SearchModeKey!);
			}
			set {
				SetNumberValue (SCNHitTest.SearchModeKey!, (System.Int64?)value);
			}
		}
		[SupportedOSPlatform ("tvos13.0")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public bool? IgnoreLightArea {
			get {
				return  GetBoolValue (SCNHitTest.IgnoreLightAreaKey!);
			}
			set {
				SetBooleanValue (SCNHitTest.IgnoreLightAreaKey!, value);
			}
		}
#endif
	}
}
