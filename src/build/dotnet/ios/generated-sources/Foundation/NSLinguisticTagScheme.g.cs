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
namespace Foundation {
	/// <summary>Enumerates classes of tags that are returned from a text classifier.</summary>
	public enum NSLinguisticTagScheme : int {
		/// <summary>Indicates that tokens will be tagged with information about whether they are words, whitespace, or punctuation.</summary>
		Token = 0,
		/// <summary>Indicates that tokens will be returned for whether they are part of speech or whitespace, or their punctuation type if they are punctuation.</summary>
		LexicalClass = 1,
		/// <summary>Indicates that tokens will be tagged as names of which they are a part.</summary>
		Name = 2,
		/// <summary>Indicates that tokens will be tagged those tags indicated by <see cref="F:Foundation.NSLinguisticTagScheme.LexicalClass" /> and <see cref="F:Foundation.NSLinguisticTagScheme.Name" />.</summary>
		NameOrLexicalClass = 3,
		/// <summary>Indicates that tokens will be tagged with their stem, if known.</summary>
		Lemma = 4,
		/// <summary>Indicates that tokens will be tagged with their language, if known.</summary>
		Language = 5,
		/// <summary>Indicates that tokens will be tagged with the script in which they were written.</summary>
		Script = 6,
	}
	/// <summary>Extension methods for the <see cref="global::Foundation.NSLinguisticTagScheme" /> enumeration.</summary>
	[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	static public partial class NSLinguisticTagSchemeExtensions {
		static IntPtr[] values = new IntPtr [7];
		[Field ("NSLinguisticTagSchemeTokenType", "Foundation")]
		internal unsafe static IntPtr NSLinguisticTagSchemeTokenType {
			get {
				fixed (IntPtr *storage = &values [0])
					return Dlfcn.CachePointer (Libraries.Foundation.Handle, "NSLinguisticTagSchemeTokenType", storage);
			}
		}
		[Field ("NSLinguisticTagSchemeLexicalClass", "Foundation")]
		internal unsafe static IntPtr NSLinguisticTagSchemeLexicalClass {
			get {
				fixed (IntPtr *storage = &values [1])
					return Dlfcn.CachePointer (Libraries.Foundation.Handle, "NSLinguisticTagSchemeLexicalClass", storage);
			}
		}
		[Field ("NSLinguisticTagSchemeNameType", "Foundation")]
		internal unsafe static IntPtr NSLinguisticTagSchemeNameType {
			get {
				fixed (IntPtr *storage = &values [2])
					return Dlfcn.CachePointer (Libraries.Foundation.Handle, "NSLinguisticTagSchemeNameType", storage);
			}
		}
		[Field ("NSLinguisticTagSchemeNameTypeOrLexicalClass", "Foundation")]
		internal unsafe static IntPtr NSLinguisticTagSchemeNameTypeOrLexicalClass {
			get {
				fixed (IntPtr *storage = &values [3])
					return Dlfcn.CachePointer (Libraries.Foundation.Handle, "NSLinguisticTagSchemeNameTypeOrLexicalClass", storage);
			}
		}
		[Field ("NSLinguisticTagSchemeLemma", "Foundation")]
		internal unsafe static IntPtr NSLinguisticTagSchemeLemma {
			get {
				fixed (IntPtr *storage = &values [4])
					return Dlfcn.CachePointer (Libraries.Foundation.Handle, "NSLinguisticTagSchemeLemma", storage);
			}
		}
		[Field ("NSLinguisticTagSchemeLanguage", "Foundation")]
		internal unsafe static IntPtr NSLinguisticTagSchemeLanguage {
			get {
				fixed (IntPtr *storage = &values [5])
					return Dlfcn.CachePointer (Libraries.Foundation.Handle, "NSLinguisticTagSchemeLanguage", storage);
			}
		}
		[Field ("NSLinguisticTagSchemeScript", "Foundation")]
		internal unsafe static IntPtr NSLinguisticTagSchemeScript {
			get {
				fixed (IntPtr *storage = &values [6])
					return Dlfcn.CachePointer (Libraries.Foundation.Handle, "NSLinguisticTagSchemeScript", storage);
			}
		}
		/// <summary>Retrieves the <see cref="global::Foundation.NSString" /> constant that describes <paramref name="self" />.</summary>
		/// <param name="self">The instance on which this method operates.</param>
		public static NSString? GetConstant (this NSLinguisticTagScheme self)
		{
			IntPtr ptr = IntPtr.Zero;
			switch ((int) self) {
			case 0: // NSLinguisticTagScheme.Token
				ptr = NSLinguisticTagSchemeTokenType;
				break;
			case 1: // NSLinguisticTagScheme.LexicalClass
				ptr = NSLinguisticTagSchemeLexicalClass;
				break;
			case 2: // NSLinguisticTagScheme.Name
				ptr = NSLinguisticTagSchemeNameType;
				break;
			case 3: // NSLinguisticTagScheme.NameOrLexicalClass
				ptr = NSLinguisticTagSchemeNameTypeOrLexicalClass;
				break;
			case 4: // NSLinguisticTagScheme.Lemma
				ptr = NSLinguisticTagSchemeLemma;
				break;
			case 5: // NSLinguisticTagScheme.Language
				ptr = NSLinguisticTagSchemeLanguage;
				break;
			case 6: // NSLinguisticTagScheme.Script
				ptr = NSLinguisticTagSchemeScript;
				break;
			}
			return (NSString?) Runtime.GetNSObject (ptr);
		}
		/// <summary>Retrieves the <see cref="global::Foundation.NSLinguisticTagScheme" /> value named by <paramref name="constant" />.</summary>
		/// <param name="constant">The name of the constant to retrieve.</param>
		public static NSLinguisticTagScheme GetValue (NSString constant)
		{
			if (constant is null)
				throw new ArgumentNullException (nameof (constant));
			if (constant.IsEqualTo (NSLinguisticTagSchemeTokenType))
				return NSLinguisticTagScheme.Token;
			if (constant.IsEqualTo (NSLinguisticTagSchemeLexicalClass))
				return NSLinguisticTagScheme.LexicalClass;
			if (constant.IsEqualTo (NSLinguisticTagSchemeNameType))
				return NSLinguisticTagScheme.Name;
			if (constant.IsEqualTo (NSLinguisticTagSchemeNameTypeOrLexicalClass))
				return NSLinguisticTagScheme.NameOrLexicalClass;
			if (constant.IsEqualTo (NSLinguisticTagSchemeLemma))
				return NSLinguisticTagScheme.Lemma;
			if (constant.IsEqualTo (NSLinguisticTagSchemeLanguage))
				return NSLinguisticTagScheme.Language;
			if (constant.IsEqualTo (NSLinguisticTagSchemeScript))
				return NSLinguisticTagScheme.Script;
			throw new NotSupportedException ($"{constant} has no associated enum value on this platform.");
		}
		/// <summary>Retrieves the <see cref="global::Foundation.NSLinguisticTagScheme" /> value represented by the backing field value in <paramref name="handle" />.</summary>
		/// <param name="handle">The native handle with the name of the constant to retrieve.</param>
		public static NSLinguisticTagScheme GetValue (NativeHandle handle)
		{
			using var str = Runtime.GetNSObject<NSString> (handle)!;
			return GetValue (str);
		}
		/// <summary>Retrieves the <see cref="global::Foundation.NSLinguisticTagScheme" /> value represented by the backing field value in <paramref name="handle" />.</summary>
		/// <param name="handle">The native handle with the name of the constant to retrieve.</param>
		public static NSLinguisticTagScheme? GetNullableValue (NativeHandle handle)
		{
			using var str = Runtime.GetNSObject<NSString> (handle);
			if (str is null)
				return null;
			return GetValue (str);
		}
		/// <summary>Converts an array of <see cref="global::Foundation.NSLinguisticTagScheme" /> enum values into an array of their corresponding constants.</summary>
		/// <param name="values">The array of enum values to convert.</param>
		internal static NSString?[]? ToConstantArray (this NSLinguisticTagScheme[]? values)
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
		internal static NSLinguisticTagScheme[]? ToEnumArray (this NSString[]? values)
		{
			if (values is null)
				return null;
			var rv = new global::System.Collections.Generic.List<NSLinguisticTagScheme> ();
			for (var i = 0; i < values.Length; i++) {
				var value = values [i];
				rv.Add (GetValue (value));
			}
			return rv.ToArray ();
		}
	}
}
