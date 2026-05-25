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
using Metal;
using CoreML;
using OpenGL;
using AppKit;
using Photos;
using ModelIO;
using Network;
using SceneKit;
using Contacts;
using Security;
using CloudKit;
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
using FileProvider;
using CoreAnimation;
using CoreFoundation;
using NetworkExtension;
using MetalPerformanceShadersGraph;
#nullable enable
namespace iTunesLibrary {
	public enum ITLibPlaylistProperty : int {
		/// <summary>To be added.</summary>
		Name = 0,
		/// <summary>To be added.</summary>
		AllItemsPlaylist = 1,
		/// <summary>To be added.</summary>
		DistinguisedKind = 2,
		/// <summary>To be added.</summary>
		[ObsoletedOSPlatform ("macos12.0", "Use 'Primary' instead.")]
		[SupportedOSPlatform ("macos")]
		Master = 3,
		/// <summary>To be added.</summary>
		ParentPersistentId = 4,
		Primary = 5,
		/// <summary>To be added.</summary>
		Visible = 6,
		/// <summary>To be added.</summary>
		Items = 7,
		/// <summary>To be added.</summary>
		Kind = 8,
	}
	/// <summary>Extension methods for the <see cref="global::iTunesLibrary.ITLibPlaylistProperty" /> enumeration.</summary>
	[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	static public partial class ITLibPlaylistPropertyExtensions {
		static IntPtr[] values = new IntPtr [9];
		[Field ("ITLibPlaylistPropertyName", "iTunesLibrary")]
		internal unsafe static IntPtr ITLibPlaylistPropertyName {
			get {
				fixed (IntPtr *storage = &values [0])
					return Dlfcn.CachePointer (Libraries.iTunesLibrary.Handle, "ITLibPlaylistPropertyName", storage);
			}
		}
		[Field ("ITLibPlaylistPropertyAllItemsPlaylist", "iTunesLibrary")]
		internal unsafe static IntPtr ITLibPlaylistPropertyAllItemsPlaylist {
			get {
				fixed (IntPtr *storage = &values [1])
					return Dlfcn.CachePointer (Libraries.iTunesLibrary.Handle, "ITLibPlaylistPropertyAllItemsPlaylist", storage);
			}
		}
		[Field ("ITLibPlaylistPropertyDistinguisedKind", "iTunesLibrary")]
		internal unsafe static IntPtr ITLibPlaylistPropertyDistinguisedKind {
			get {
				fixed (IntPtr *storage = &values [2])
					return Dlfcn.CachePointer (Libraries.iTunesLibrary.Handle, "ITLibPlaylistPropertyDistinguisedKind", storage);
			}
		}
		[ObsoletedOSPlatform ("macos12.0", "Use 'Primary' instead.")]
		[SupportedOSPlatform ("macos")]
		[Field ("ITLibPlaylistPropertyMaster", "iTunesLibrary")]
		internal unsafe static IntPtr ITLibPlaylistPropertyMaster {
			get {
				fixed (IntPtr *storage = &values [3])
					return Dlfcn.CachePointer (Libraries.iTunesLibrary.Handle, "ITLibPlaylistPropertyMaster", storage);
			}
		}
		[Field ("ITLibPlaylistPropertyParentPersistentID", "iTunesLibrary")]
		internal unsafe static IntPtr ITLibPlaylistPropertyParentPersistentID {
			get {
				fixed (IntPtr *storage = &values [4])
					return Dlfcn.CachePointer (Libraries.iTunesLibrary.Handle, "ITLibPlaylistPropertyParentPersistentID", storage);
			}
		}
		[Field ("ITLibPlaylistPropertyPrimary", "iTunesLibrary")]
		internal unsafe static IntPtr ITLibPlaylistPropertyPrimary {
			get {
				fixed (IntPtr *storage = &values [5])
					return Dlfcn.CachePointer (Libraries.iTunesLibrary.Handle, "ITLibPlaylistPropertyPrimary", storage);
			}
		}
		[Field ("ITLibPlaylistPropertyVisible", "iTunesLibrary")]
		internal unsafe static IntPtr ITLibPlaylistPropertyVisible {
			get {
				fixed (IntPtr *storage = &values [6])
					return Dlfcn.CachePointer (Libraries.iTunesLibrary.Handle, "ITLibPlaylistPropertyVisible", storage);
			}
		}
		[Field ("ITLibPlaylistPropertyItems", "iTunesLibrary")]
		internal unsafe static IntPtr ITLibPlaylistPropertyItems {
			get {
				fixed (IntPtr *storage = &values [7])
					return Dlfcn.CachePointer (Libraries.iTunesLibrary.Handle, "ITLibPlaylistPropertyItems", storage);
			}
		}
		[Field ("ITLibPlaylistPropertyKind", "iTunesLibrary")]
		internal unsafe static IntPtr ITLibPlaylistPropertyKind {
			get {
				fixed (IntPtr *storage = &values [8])
					return Dlfcn.CachePointer (Libraries.iTunesLibrary.Handle, "ITLibPlaylistPropertyKind", storage);
			}
		}
		/// <summary>Retrieves the <see cref="global::Foundation.NSString" /> constant that describes <paramref name="self" />.</summary>
		/// <param name="self">The instance on which this method operates.</param>
		public static NSString? GetConstant (this ITLibPlaylistProperty self)
		{
			IntPtr ptr = IntPtr.Zero;
			switch ((int) self) {
			case 0: // ITLibPlaylistProperty.Name
				ptr = ITLibPlaylistPropertyName;
				break;
			case 1: // ITLibPlaylistProperty.AllItemsPlaylist
				ptr = ITLibPlaylistPropertyAllItemsPlaylist;
				break;
			case 2: // ITLibPlaylistProperty.DistinguisedKind
				ptr = ITLibPlaylistPropertyDistinguisedKind;
				break;
			case 3: // ITLibPlaylistProperty.Master
				ptr = ITLibPlaylistPropertyMaster;
				break;
			case 4: // ITLibPlaylistProperty.ParentPersistentId
				ptr = ITLibPlaylistPropertyParentPersistentID;
				break;
			case 5: // ITLibPlaylistProperty.Primary
				ptr = ITLibPlaylistPropertyPrimary;
				break;
			case 6: // ITLibPlaylistProperty.Visible
				ptr = ITLibPlaylistPropertyVisible;
				break;
			case 7: // ITLibPlaylistProperty.Items
				ptr = ITLibPlaylistPropertyItems;
				break;
			case 8: // ITLibPlaylistProperty.Kind
				ptr = ITLibPlaylistPropertyKind;
				break;
			}
			return (NSString?) Runtime.GetNSObject (ptr);
		}
		/// <summary>Retrieves the <see cref="global::iTunesLibrary.ITLibPlaylistProperty" /> value named by <paramref name="constant" />.</summary>
		/// <param name="constant">The name of the constant to retrieve.</param>
		public static ITLibPlaylistProperty GetValue (NSString constant)
		{
			if (constant is null)
				throw new ArgumentNullException (nameof (constant));
			if (constant.IsEqualTo (ITLibPlaylistPropertyName))
				return ITLibPlaylistProperty.Name;
			if (constant.IsEqualTo (ITLibPlaylistPropertyAllItemsPlaylist))
				return ITLibPlaylistProperty.AllItemsPlaylist;
			if (constant.IsEqualTo (ITLibPlaylistPropertyDistinguisedKind))
				return ITLibPlaylistProperty.DistinguisedKind;
			if (constant.IsEqualTo (ITLibPlaylistPropertyMaster))
				return ITLibPlaylistProperty.Master;
			if (constant.IsEqualTo (ITLibPlaylistPropertyParentPersistentID))
				return ITLibPlaylistProperty.ParentPersistentId;
			if (constant.IsEqualTo (ITLibPlaylistPropertyPrimary))
				return ITLibPlaylistProperty.Primary;
			if (constant.IsEqualTo (ITLibPlaylistPropertyVisible))
				return ITLibPlaylistProperty.Visible;
			if (constant.IsEqualTo (ITLibPlaylistPropertyItems))
				return ITLibPlaylistProperty.Items;
			if (constant.IsEqualTo (ITLibPlaylistPropertyKind))
				return ITLibPlaylistProperty.Kind;
			throw new NotSupportedException ($"{constant} has no associated enum value on this platform.");
		}
		/// <summary>Retrieves the <see cref="global::iTunesLibrary.ITLibPlaylistProperty" /> value represented by the backing field value in <paramref name="handle" />.</summary>
		/// <param name="handle">The native handle with the name of the constant to retrieve.</param>
		public static ITLibPlaylistProperty GetValue (NativeHandle handle)
		{
			using var str = Runtime.GetNSObject<NSString> (handle)!;
			return GetValue (str);
		}
		/// <summary>Retrieves the <see cref="global::iTunesLibrary.ITLibPlaylistProperty" /> value represented by the backing field value in <paramref name="handle" />.</summary>
		/// <param name="handle">The native handle with the name of the constant to retrieve.</param>
		public static ITLibPlaylistProperty? GetNullableValue (NativeHandle handle)
		{
			using var str = Runtime.GetNSObject<NSString> (handle);
			if (str is null)
				return null;
			return GetValue (str);
		}
		/// <summary>Converts an array of <see cref="global::iTunesLibrary.ITLibPlaylistProperty" /> enum values into an array of their corresponding constants.</summary>
		/// <param name="values">The array of enum values to convert.</param>
		internal static NSString?[]? ToConstantArray (this ITLibPlaylistProperty[]? values)
		{
			if (values is null)
				return null;
			var rv = new global::System.Collections.Generic.List<NSString?> ();
			for (var i = 0; i < values.Length; i++) {
				var value = values [i];
				rv.Add (value.GetConstant ());
			}
			return rv.ToArray ();
		}
		/// <summary>Converts an array of <see cref="NSString" /> values into an array of their corresponding enum values.</summary>
		/// <param name="values">The array if <see cref="NSString" /> values to convert.</param>
		internal static ITLibPlaylistProperty[]? ToEnumArray (this NSString[]? values)
		{
			if (values is null)
				return null;
			var rv = new global::System.Collections.Generic.List<ITLibPlaylistProperty> ();
			for (var i = 0; i < values.Length; i++) {
				var value = values [i];
				rv.Add (GetValue (value));
			}
			return rv.ToArray ();
		}
	}
}
