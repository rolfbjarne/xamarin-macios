//
// SCNNode.cs: extensions to SCNNode
//
// Authors:
//   Aaron Bockover (abock@xamarin.com)   
//
// Copyright Xamarin Inc.
//

using System.Collections;
using System.Collections.Generic;

using CoreFoundation;

#nullable enable

namespace SpriteKit {
	public partial class SKNode : IEnumerable, IEnumerable<SKNode> {
		/// <typeparam name="T">To be added.</typeparam>
		///         <param name="file">
		///
		/// Filename containing the SpriteKit assets, without the extension.</param>
		///         <summary>Creates a new <see cref="SpriteKit.SKNode" /> by loading the assets from a file included in the application. </summary>
		///         <returns>
		///
		/// The new instance of the node.   The parameter type <typeparamref name="T" /> is used to determine which kind of class you want to get out of the file.</returns>
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("tvos")]
		public static T? FromFile<T> (string file) where T : SKNode
		{
			var fileHandle = CFString.CreateNative (file);
			try {
				var handle = ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr (Class.GetHandle (typeof (T)), Selector.GetHandle ("nodeWithFileNamed:"), fileHandle);
				return Runtime.GetNSObject<T> (handle);
			} finally {
				CFString.ReleaseNative (fileHandle);
			}
		}

		/// <param name="node">The node.</param>
		///         <summary>Adds <paramref name="node" /> to the end of the list of child nodes.</summary>
		public void Add (SKNode node)
		{
			AddChild (node);
		}

		/// <param name="nodes">The nodes.</param>
		///         <summary>Adds <paramref name="nodes" /> to the end of the list of child nodes.</summary>
		public void AddNodes (params SKNode []? nodes)
		{
			if (nodes is null)
				return;
			foreach (var n in nodes)
				AddChild (n);
		}

		/// <summary>Returns an enumerator that iterates over the child nodes that belong to the current node.</summary>
		public IEnumerator<SKNode> GetEnumerator ()
		{
			foreach (var node in Children)
				yield return node;
		}

		/// <summary>Internal.</summary>
		IEnumerator IEnumerable.GetEnumerator ()
		{
			return GetEnumerator ();
		}

		/// <param name="filename">The filename.</param>
		///         <param name="types">The types.</param>
		///         <param name="error">The error that occurred, or <see langword="null" /> if no error occurred.</param>
		///         <summary>Create.</summary>
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("maccatalyst")]
		public static SKNode? Create (string filename, Type [] types, out NSError error)
		{
			// Let's fail early.
			if (filename is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (filename));
			if (types is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (types));
			if (types.Length == 0)
				ObjCRuntime.ThrowHelper.ThrowArgumentException (nameof (types), "Length must be greater than zero.");

			using (var classes = new NSMutableSet<Class> ((nint) types.Length)) {
				foreach (var type in types)
					classes.Add (new Class (type));
				SKNode? result = Create (filename, classes.Handle, out error);
				GC.KeepAlive (classes);
				return result;
			}
		}

		/// <param name="filename">The filename.</param>
		///         <param name="classes">The classes.</param>
		///         <param name="error">The error that occurred, or <see langword="null" /> if no error occurred.</param>
		///         <summary>Create.</summary>
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("maccatalyst")]
		public static SKNode? Create (string filename, NSSet<Class> classes, out NSError error)
		{
			// `filename` will be checked by `Create` later
			if (classes is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (classes));
			if (classes.Count == 0)
				ObjCRuntime.ThrowHelper.ThrowArgumentException (nameof (classes), "Length must be greater than zero.");

			SKNode? result = Create (filename, classes.Handle, out error);
			GC.KeepAlive (classes);
			return result;
		}
	}
}
