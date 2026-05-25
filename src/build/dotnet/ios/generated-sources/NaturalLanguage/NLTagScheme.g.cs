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
using MapKit;
using Photos;
using ModelIO;
using Network;
using SceneKit;
using Contacts;
using Security;
using Messages;
using AudioUnit;
using CoreVideo;
using CoreMedia;
using QuickLook;
using CoreImage;
using SpriteKit;
using Foundation;
using CoreMotion;
using ObjCRuntime;
using AddressBook;
using MediaPlayer;
using GameplayKit;
using CoreGraphics;
using CoreLocation;
using AVFoundation;
using NewsstandKit;
using FileProvider;
using CoreAnimation;
using CoreFoundation;
using NetworkExtension;
using MetalPerformanceShadersGraph;
#nullable enable
namespace NaturalLanguage {
	/// <summary>Enumerates classes of tags that are returned from a text classifier.</summary>
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("tvos")]
	public enum NLTagScheme : int {
		/// <summary>Indicates that tokens will be tagged with information about whether they are words, whitespace, or punctuation.</summary>
		TokenType = 0,
		/// <summary>Indicates that tokens will be returned for whether they are part of speech or whitespace, or their punctuation type if they are punctuation.</summary>
		LexicalClass = 1,
		/// <summary>Indicates that tokens will be tagged with the type of name of which they are a part. (For example, part of a personal name.)</summary>
		NameType = 2,
		/// <summary>Indicates that tokens will be tagged those tags indicated by <see cref="F:NaturalLanguage.NLTagScheme.LexicalClass" /> and <see cref="F:NaturalLanguage.NLTagScheme.NameType" />.</summary>
		NameTypeOrLexicalClass = 3,
		/// <summary>Indicates that tokens will be tagged with their stem, if known.</summary>
		Lemma = 4,
		/// <summary>Indicates that tokens will be tagged with their language, if known.</summary>
		Language = 5,
		/// <summary>Indicates that tokens will be tagged with the script in which they were written.</summary>
		Script = 6,
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("tvos13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		SentimentScore = 7,
	}
	/// <summary>Extension methods for the <see cref="global::NaturalLanguage.NLTagScheme" /> enumeration.</summary>
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("tvos")]
	[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	static public partial class NLTagSchemeExtensions {
		static IntPtr[] values = new IntPtr [8];
		[Field ("NLTagSchemeTokenType", "NaturalLanguage")]
		internal unsafe static IntPtr NLTagSchemeTokenType {
			get {
				fixed (IntPtr *storage = &values [0])
					return Dlfcn.CachePointer (Libraries.NaturalLanguage.Handle, "NLTagSchemeTokenType", storage);
			}
		}
		[Field ("NLTagSchemeLexicalClass", "NaturalLanguage")]
		internal unsafe static IntPtr NLTagSchemeLexicalClass {
			get {
				fixed (IntPtr *storage = &values [1])
					return Dlfcn.CachePointer (Libraries.NaturalLanguage.Handle, "NLTagSchemeLexicalClass", storage);
			}
		}
		[Field ("NLTagSchemeNameType", "NaturalLanguage")]
		internal unsafe static IntPtr NLTagSchemeNameType {
			get {
				fixed (IntPtr *storage = &values [2])
					return Dlfcn.CachePointer (Libraries.NaturalLanguage.Handle, "NLTagSchemeNameType", storage);
			}
		}
		[Field ("NLTagSchemeNameTypeOrLexicalClass", "NaturalLanguage")]
		internal unsafe static IntPtr NLTagSchemeNameTypeOrLexicalClass {
			get {
				fixed (IntPtr *storage = &values [3])
					return Dlfcn.CachePointer (Libraries.NaturalLanguage.Handle, "NLTagSchemeNameTypeOrLexicalClass", storage);
			}
		}
		[Field ("NLTagSchemeLemma", "NaturalLanguage")]
		internal unsafe static IntPtr NLTagSchemeLemma {
			get {
				fixed (IntPtr *storage = &values [4])
					return Dlfcn.CachePointer (Libraries.NaturalLanguage.Handle, "NLTagSchemeLemma", storage);
			}
		}
		[Field ("NLTagSchemeLanguage", "NaturalLanguage")]
		internal unsafe static IntPtr NLTagSchemeLanguage {
			get {
				fixed (IntPtr *storage = &values [5])
					return Dlfcn.CachePointer (Libraries.NaturalLanguage.Handle, "NLTagSchemeLanguage", storage);
			}
		}
		[Field ("NLTagSchemeScript", "NaturalLanguage")]
		internal unsafe static IntPtr NLTagSchemeScript {
			get {
				fixed (IntPtr *storage = &values [6])
					return Dlfcn.CachePointer (Libraries.NaturalLanguage.Handle, "NLTagSchemeScript", storage);
			}
		}
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("tvos13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[Field ("NLTagSchemeSentimentScore", "NaturalLanguage")]
		internal unsafe static IntPtr NLTagSchemeSentimentScore {
			get {
				fixed (IntPtr *storage = &values [7])
					return Dlfcn.CachePointer (Libraries.NaturalLanguage.Handle, "NLTagSchemeSentimentScore", storage);
			}
		}
		/// <summary>Retrieves the <see cref="global::Foundation.NSString" /> constant that describes <paramref name="self" />.</summary>
		/// <param name="self">The instance on which this method operates.</param>
		public static NSString? GetConstant (this NLTagScheme self)
		{
			IntPtr ptr = IntPtr.Zero;
			switch ((int) self) {
			case 0: // NLTagScheme.TokenType
				ptr = NLTagSchemeTokenType;
				break;
			case 1: // NLTagScheme.LexicalClass
				ptr = NLTagSchemeLexicalClass;
				break;
			case 2: // NLTagScheme.NameType
				ptr = NLTagSchemeNameType;
				break;
			case 3: // NLTagScheme.NameTypeOrLexicalClass
				ptr = NLTagSchemeNameTypeOrLexicalClass;
				break;
			case 4: // NLTagScheme.Lemma
				ptr = NLTagSchemeLemma;
				break;
			case 5: // NLTagScheme.Language
				ptr = NLTagSchemeLanguage;
				break;
			case 6: // NLTagScheme.Script
				ptr = NLTagSchemeScript;
				break;
			case 7: // NLTagScheme.SentimentScore
				ptr = NLTagSchemeSentimentScore;
				break;
			}
			return (NSString?) Runtime.GetNSObject (ptr);
		}
		/// <summary>Retrieves the <see cref="global::NaturalLanguage.NLTagScheme" /> value named by <paramref name="constant" />.</summary>
		/// <param name="constant">The name of the constant to retrieve.</param>
		public static NLTagScheme GetValue (NSString constant)
		{
			if (constant is null)
				throw new ArgumentNullException (nameof (constant));
			if (constant.IsEqualTo (NLTagSchemeTokenType))
				return NLTagScheme.TokenType;
			if (constant.IsEqualTo (NLTagSchemeLexicalClass))
				return NLTagScheme.LexicalClass;
			if (constant.IsEqualTo (NLTagSchemeNameType))
				return NLTagScheme.NameType;
			if (constant.IsEqualTo (NLTagSchemeNameTypeOrLexicalClass))
				return NLTagScheme.NameTypeOrLexicalClass;
			if (constant.IsEqualTo (NLTagSchemeLemma))
				return NLTagScheme.Lemma;
			if (constant.IsEqualTo (NLTagSchemeLanguage))
				return NLTagScheme.Language;
			if (constant.IsEqualTo (NLTagSchemeScript))
				return NLTagScheme.Script;
			if (constant.IsEqualTo (NLTagSchemeSentimentScore))
				return NLTagScheme.SentimentScore;
			throw new NotSupportedException ($"{constant} has no associated enum value on this platform.");
		}
		/// <summary>Retrieves the <see cref="global::NaturalLanguage.NLTagScheme" /> value represented by the backing field value in <paramref name="handle" />.</summary>
		/// <param name="handle">The native handle with the name of the constant to retrieve.</param>
		public static NLTagScheme GetValue (NativeHandle handle)
		{
			using var str = Runtime.GetNSObject<NSString> (handle)!;
			return GetValue (str);
		}
		/// <summary>Retrieves the <see cref="global::NaturalLanguage.NLTagScheme" /> value represented by the backing field value in <paramref name="handle" />.</summary>
		/// <param name="handle">The native handle with the name of the constant to retrieve.</param>
		public static NLTagScheme? GetNullableValue (NativeHandle handle)
		{
			using var str = Runtime.GetNSObject<NSString> (handle);
			if (str is null)
				return null;
			return GetValue (str);
		}
		/// <summary>Converts an array of <see cref="global::NaturalLanguage.NLTagScheme" /> enum values into an array of their corresponding constants.</summary>
		/// <param name="values">The array of enum values to convert.</param>
		internal static NSString?[]? ToConstantArray (this NLTagScheme[]? values)
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
		internal static NLTagScheme[]? ToEnumArray (this NSString[]? values)
		{
			if (values is null)
				return null;
			var rv = new global::System.Collections.Generic.List<NLTagScheme> ();
			for (var i = 0; i < values.Length; i++) {
				var value = values [i];
				rv.Add (GetValue (value));
			}
			return rv.ToArray ();
		}
	}
}
