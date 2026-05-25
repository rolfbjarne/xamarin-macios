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
namespace NaturalLanguage {
	[SupportedOSPlatform ("tvos17.0")]
	[SupportedOSPlatform ("macos14.0")]
	[SupportedOSPlatform ("ios17.0")]
	[SupportedOSPlatform ("maccatalyst17.0")]
	public enum NLContextualEmebeddingKey : int {
		Languages = 0,
		Scripts = 1,
		Revision = 2,
	}
	/// <summary>Extension methods for the <see cref="global::NaturalLanguage.NLContextualEmebeddingKey" /> enumeration.</summary>
	[SupportedOSPlatform ("tvos17.0")]
	[SupportedOSPlatform ("macos14.0")]
	[SupportedOSPlatform ("ios17.0")]
	[SupportedOSPlatform ("maccatalyst17.0")]
	[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	static public partial class NLContextualEmebeddingKeyExtensions {
		static IntPtr[] values = new IntPtr [3];
		[Field ("NLContextualEmbeddingKeyLanguages", "NaturalLanguage")]
		internal unsafe static IntPtr NLContextualEmbeddingKeyLanguages {
			get {
				fixed (IntPtr *storage = &values [0])
					return Dlfcn.CachePointer (Libraries.NaturalLanguage.Handle, "NLContextualEmbeddingKeyLanguages", storage);
			}
		}
		[Field ("NLContextualEmbeddingKeyScripts", "NaturalLanguage")]
		internal unsafe static IntPtr NLContextualEmbeddingKeyScripts {
			get {
				fixed (IntPtr *storage = &values [1])
					return Dlfcn.CachePointer (Libraries.NaturalLanguage.Handle, "NLContextualEmbeddingKeyScripts", storage);
			}
		}
		[Field ("NLContextualEmbeddingKeyRevision", "NaturalLanguage")]
		internal unsafe static IntPtr NLContextualEmbeddingKeyRevision {
			get {
				fixed (IntPtr *storage = &values [2])
					return Dlfcn.CachePointer (Libraries.NaturalLanguage.Handle, "NLContextualEmbeddingKeyRevision", storage);
			}
		}
		/// <summary>Retrieves the <see cref="global::Foundation.NSString" /> constant that describes <paramref name="self" />.</summary>
		/// <param name="self">The instance on which this method operates.</param>
		public static NSString? GetConstant (this NLContextualEmebeddingKey self)
		{
			IntPtr ptr = IntPtr.Zero;
			switch ((int) self) {
			case 0: // NLContextualEmebeddingKey.Languages
				ptr = NLContextualEmbeddingKeyLanguages;
				break;
			case 1: // NLContextualEmebeddingKey.Scripts
				ptr = NLContextualEmbeddingKeyScripts;
				break;
			case 2: // NLContextualEmebeddingKey.Revision
				ptr = NLContextualEmbeddingKeyRevision;
				break;
			}
			return (NSString?) Runtime.GetNSObject (ptr);
		}
		/// <summary>Retrieves the <see cref="global::NaturalLanguage.NLContextualEmebeddingKey" /> value named by <paramref name="constant" />.</summary>
		/// <param name="constant">The name of the constant to retrieve.</param>
		public static NLContextualEmebeddingKey GetValue (NSString constant)
		{
			if (constant is null)
				throw new ArgumentNullException (nameof (constant));
			if (constant.IsEqualTo (NLContextualEmbeddingKeyLanguages))
				return NLContextualEmebeddingKey.Languages;
			if (constant.IsEqualTo (NLContextualEmbeddingKeyScripts))
				return NLContextualEmebeddingKey.Scripts;
			if (constant.IsEqualTo (NLContextualEmbeddingKeyRevision))
				return NLContextualEmebeddingKey.Revision;
			throw new NotSupportedException ($"{constant} has no associated enum value on this platform.");
		}
		/// <summary>Retrieves the <see cref="global::NaturalLanguage.NLContextualEmebeddingKey" /> value represented by the backing field value in <paramref name="handle" />.</summary>
		/// <param name="handle">The native handle with the name of the constant to retrieve.</param>
		public static NLContextualEmebeddingKey GetValue (NativeHandle handle)
		{
			using var str = Runtime.GetNSObject<NSString> (handle)!;
			return GetValue (str);
		}
		/// <summary>Retrieves the <see cref="global::NaturalLanguage.NLContextualEmebeddingKey" /> value represented by the backing field value in <paramref name="handle" />.</summary>
		/// <param name="handle">The native handle with the name of the constant to retrieve.</param>
		public static NLContextualEmebeddingKey? GetNullableValue (NativeHandle handle)
		{
			using var str = Runtime.GetNSObject<NSString> (handle);
			if (str is null)
				return null;
			return GetValue (str);
		}
		/// <summary>Converts an array of <see cref="global::NaturalLanguage.NLContextualEmebeddingKey" /> enum values into an array of their corresponding constants.</summary>
		/// <param name="values">The array of enum values to convert.</param>
		internal static NSString?[]? ToConstantArray (this NLContextualEmebeddingKey[]? values)
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
		internal static NLContextualEmebeddingKey[]? ToEnumArray (this NSString[]? values)
		{
			if (values is null)
				return null;
			var rv = new global::System.Collections.Generic.List<NLContextualEmebeddingKey> ();
			for (var i = 0; i < values.Length; i++) {
				var value = values [i];
				rv.Add (GetValue (value));
			}
			return rv.ToArray ();
		}
	}
}
