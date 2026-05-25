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
	/// <summary>Contains read-only static properties corresponding to the parts of speech recognized by a <see cref="T:Foundation.NSLinguisticTagger" />.</summary><summary>Enumerates tag values for linguistic units.</summary>
	public enum NSLinguisticTag : int {
		Word = 0,
		Punctuation = 1,
		Whitespace = 2,
		Other = 3,
		Noun = 4,
		Verb = 5,
		Adjective = 6,
		Adverb = 7,
		Pronoun = 8,
		Determiner = 9,
		Particle = 10,
		Preposition = 11,
		Number = 12,
		Conjunction = 13,
		Interjection = 14,
		Classifier = 15,
		Idiom = 16,
		OtherWord = 17,
		Terminator = 18,
		OpenQuote = 19,
		CloseQuote = 20,
		OpenParenthesis = 21,
		CloseParenthesis = 22,
		WordJoiner = 23,
		Dash = 24,
		OtherPunctuation = 25,
		ParagraphBreak = 26,
		OtherWhitespace = 27,
		PersonalName = 28,
		OrganizationName = 29,
		PlaceName = 30,
	}
	/// <summary>Extension methods for the <see cref="global::Foundation.NSLinguisticTag" /> enumeration.</summary>
	[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	static public partial class NSLinguisticTagExtensions {
		static IntPtr[] values = new IntPtr [31];
		[Field ("NSLinguisticTagWord", "Foundation")]
		internal unsafe static IntPtr NSLinguisticTagWord {
			get {
				fixed (IntPtr *storage = &values [0])
					return Dlfcn.CachePointer (Libraries.Foundation.Handle, "NSLinguisticTagWord", storage);
			}
		}
		[Field ("NSLinguisticTagPunctuation", "Foundation")]
		internal unsafe static IntPtr NSLinguisticTagPunctuation {
			get {
				fixed (IntPtr *storage = &values [1])
					return Dlfcn.CachePointer (Libraries.Foundation.Handle, "NSLinguisticTagPunctuation", storage);
			}
		}
		[Field ("NSLinguisticTagWhitespace", "Foundation")]
		internal unsafe static IntPtr NSLinguisticTagWhitespace {
			get {
				fixed (IntPtr *storage = &values [2])
					return Dlfcn.CachePointer (Libraries.Foundation.Handle, "NSLinguisticTagWhitespace", storage);
			}
		}
		[Field ("NSLinguisticTagOther", "Foundation")]
		internal unsafe static IntPtr NSLinguisticTagOther {
			get {
				fixed (IntPtr *storage = &values [3])
					return Dlfcn.CachePointer (Libraries.Foundation.Handle, "NSLinguisticTagOther", storage);
			}
		}
		[Field ("NSLinguisticTagNoun", "Foundation")]
		internal unsafe static IntPtr NSLinguisticTagNoun {
			get {
				fixed (IntPtr *storage = &values [4])
					return Dlfcn.CachePointer (Libraries.Foundation.Handle, "NSLinguisticTagNoun", storage);
			}
		}
		[Field ("NSLinguisticTagVerb", "Foundation")]
		internal unsafe static IntPtr NSLinguisticTagVerb {
			get {
				fixed (IntPtr *storage = &values [5])
					return Dlfcn.CachePointer (Libraries.Foundation.Handle, "NSLinguisticTagVerb", storage);
			}
		}
		[Field ("NSLinguisticTagAdjective", "Foundation")]
		internal unsafe static IntPtr NSLinguisticTagAdjective {
			get {
				fixed (IntPtr *storage = &values [6])
					return Dlfcn.CachePointer (Libraries.Foundation.Handle, "NSLinguisticTagAdjective", storage);
			}
		}
		[Field ("NSLinguisticTagAdverb", "Foundation")]
		internal unsafe static IntPtr NSLinguisticTagAdverb {
			get {
				fixed (IntPtr *storage = &values [7])
					return Dlfcn.CachePointer (Libraries.Foundation.Handle, "NSLinguisticTagAdverb", storage);
			}
		}
		[Field ("NSLinguisticTagPronoun", "Foundation")]
		internal unsafe static IntPtr NSLinguisticTagPronoun {
			get {
				fixed (IntPtr *storage = &values [8])
					return Dlfcn.CachePointer (Libraries.Foundation.Handle, "NSLinguisticTagPronoun", storage);
			}
		}
		[Field ("NSLinguisticTagDeterminer", "Foundation")]
		internal unsafe static IntPtr NSLinguisticTagDeterminer {
			get {
				fixed (IntPtr *storage = &values [9])
					return Dlfcn.CachePointer (Libraries.Foundation.Handle, "NSLinguisticTagDeterminer", storage);
			}
		}
		[Field ("NSLinguisticTagParticle", "Foundation")]
		internal unsafe static IntPtr NSLinguisticTagParticle {
			get {
				fixed (IntPtr *storage = &values [10])
					return Dlfcn.CachePointer (Libraries.Foundation.Handle, "NSLinguisticTagParticle", storage);
			}
		}
		[Field ("NSLinguisticTagPreposition", "Foundation")]
		internal unsafe static IntPtr NSLinguisticTagPreposition {
			get {
				fixed (IntPtr *storage = &values [11])
					return Dlfcn.CachePointer (Libraries.Foundation.Handle, "NSLinguisticTagPreposition", storage);
			}
		}
		[Field ("NSLinguisticTagNumber", "Foundation")]
		internal unsafe static IntPtr NSLinguisticTagNumber {
			get {
				fixed (IntPtr *storage = &values [12])
					return Dlfcn.CachePointer (Libraries.Foundation.Handle, "NSLinguisticTagNumber", storage);
			}
		}
		[Field ("NSLinguisticTagConjunction", "Foundation")]
		internal unsafe static IntPtr NSLinguisticTagConjunction {
			get {
				fixed (IntPtr *storage = &values [13])
					return Dlfcn.CachePointer (Libraries.Foundation.Handle, "NSLinguisticTagConjunction", storage);
			}
		}
		[Field ("NSLinguisticTagInterjection", "Foundation")]
		internal unsafe static IntPtr NSLinguisticTagInterjection {
			get {
				fixed (IntPtr *storage = &values [14])
					return Dlfcn.CachePointer (Libraries.Foundation.Handle, "NSLinguisticTagInterjection", storage);
			}
		}
		[Field ("NSLinguisticTagClassifier", "Foundation")]
		internal unsafe static IntPtr NSLinguisticTagClassifier {
			get {
				fixed (IntPtr *storage = &values [15])
					return Dlfcn.CachePointer (Libraries.Foundation.Handle, "NSLinguisticTagClassifier", storage);
			}
		}
		[Field ("NSLinguisticTagIdiom", "Foundation")]
		internal unsafe static IntPtr NSLinguisticTagIdiom {
			get {
				fixed (IntPtr *storage = &values [16])
					return Dlfcn.CachePointer (Libraries.Foundation.Handle, "NSLinguisticTagIdiom", storage);
			}
		}
		[Field ("NSLinguisticTagOtherWord", "Foundation")]
		internal unsafe static IntPtr NSLinguisticTagOtherWord {
			get {
				fixed (IntPtr *storage = &values [17])
					return Dlfcn.CachePointer (Libraries.Foundation.Handle, "NSLinguisticTagOtherWord", storage);
			}
		}
		[Field ("NSLinguisticTagSentenceTerminator", "Foundation")]
		internal unsafe static IntPtr NSLinguisticTagSentenceTerminator {
			get {
				fixed (IntPtr *storage = &values [18])
					return Dlfcn.CachePointer (Libraries.Foundation.Handle, "NSLinguisticTagSentenceTerminator", storage);
			}
		}
		[Field ("NSLinguisticTagOpenQuote", "Foundation")]
		internal unsafe static IntPtr NSLinguisticTagOpenQuote {
			get {
				fixed (IntPtr *storage = &values [19])
					return Dlfcn.CachePointer (Libraries.Foundation.Handle, "NSLinguisticTagOpenQuote", storage);
			}
		}
		[Field ("NSLinguisticTagCloseQuote", "Foundation")]
		internal unsafe static IntPtr NSLinguisticTagCloseQuote {
			get {
				fixed (IntPtr *storage = &values [20])
					return Dlfcn.CachePointer (Libraries.Foundation.Handle, "NSLinguisticTagCloseQuote", storage);
			}
		}
		[Field ("NSLinguisticTagOpenParenthesis", "Foundation")]
		internal unsafe static IntPtr NSLinguisticTagOpenParenthesis {
			get {
				fixed (IntPtr *storage = &values [21])
					return Dlfcn.CachePointer (Libraries.Foundation.Handle, "NSLinguisticTagOpenParenthesis", storage);
			}
		}
		[Field ("NSLinguisticTagCloseParenthesis", "Foundation")]
		internal unsafe static IntPtr NSLinguisticTagCloseParenthesis {
			get {
				fixed (IntPtr *storage = &values [22])
					return Dlfcn.CachePointer (Libraries.Foundation.Handle, "NSLinguisticTagCloseParenthesis", storage);
			}
		}
		[Field ("NSLinguisticTagWordJoiner", "Foundation")]
		internal unsafe static IntPtr NSLinguisticTagWordJoiner {
			get {
				fixed (IntPtr *storage = &values [23])
					return Dlfcn.CachePointer (Libraries.Foundation.Handle, "NSLinguisticTagWordJoiner", storage);
			}
		}
		[Field ("NSLinguisticTagDash", "Foundation")]
		internal unsafe static IntPtr NSLinguisticTagDash {
			get {
				fixed (IntPtr *storage = &values [24])
					return Dlfcn.CachePointer (Libraries.Foundation.Handle, "NSLinguisticTagDash", storage);
			}
		}
		[Field ("NSLinguisticTagOtherPunctuation", "Foundation")]
		internal unsafe static IntPtr NSLinguisticTagOtherPunctuation {
			get {
				fixed (IntPtr *storage = &values [25])
					return Dlfcn.CachePointer (Libraries.Foundation.Handle, "NSLinguisticTagOtherPunctuation", storage);
			}
		}
		[Field ("NSLinguisticTagParagraphBreak", "Foundation")]
		internal unsafe static IntPtr NSLinguisticTagParagraphBreak {
			get {
				fixed (IntPtr *storage = &values [26])
					return Dlfcn.CachePointer (Libraries.Foundation.Handle, "NSLinguisticTagParagraphBreak", storage);
			}
		}
		[Field ("NSLinguisticTagOtherWhitespace", "Foundation")]
		internal unsafe static IntPtr NSLinguisticTagOtherWhitespace {
			get {
				fixed (IntPtr *storage = &values [27])
					return Dlfcn.CachePointer (Libraries.Foundation.Handle, "NSLinguisticTagOtherWhitespace", storage);
			}
		}
		[Field ("NSLinguisticTagPersonalName", "Foundation")]
		internal unsafe static IntPtr NSLinguisticTagPersonalName {
			get {
				fixed (IntPtr *storage = &values [28])
					return Dlfcn.CachePointer (Libraries.Foundation.Handle, "NSLinguisticTagPersonalName", storage);
			}
		}
		[Field ("NSLinguisticTagOrganizationName", "Foundation")]
		internal unsafe static IntPtr NSLinguisticTagOrganizationName {
			get {
				fixed (IntPtr *storage = &values [29])
					return Dlfcn.CachePointer (Libraries.Foundation.Handle, "NSLinguisticTagOrganizationName", storage);
			}
		}
		[Field ("NSLinguisticTagPlaceName", "Foundation")]
		internal unsafe static IntPtr NSLinguisticTagPlaceName {
			get {
				fixed (IntPtr *storage = &values [30])
					return Dlfcn.CachePointer (Libraries.Foundation.Handle, "NSLinguisticTagPlaceName", storage);
			}
		}
		/// <summary>Retrieves the <see cref="global::Foundation.NSString" /> constant that describes <paramref name="self" />.</summary>
		/// <param name="self">The instance on which this method operates.</param>
		public static NSString? GetConstant (this NSLinguisticTag self)
		{
			IntPtr ptr = IntPtr.Zero;
			switch ((int) self) {
			case 0: // NSLinguisticTag.Word
				ptr = NSLinguisticTagWord;
				break;
			case 1: // NSLinguisticTag.Punctuation
				ptr = NSLinguisticTagPunctuation;
				break;
			case 2: // NSLinguisticTag.Whitespace
				ptr = NSLinguisticTagWhitespace;
				break;
			case 3: // NSLinguisticTag.Other
				ptr = NSLinguisticTagOther;
				break;
			case 4: // NSLinguisticTag.Noun
				ptr = NSLinguisticTagNoun;
				break;
			case 5: // NSLinguisticTag.Verb
				ptr = NSLinguisticTagVerb;
				break;
			case 6: // NSLinguisticTag.Adjective
				ptr = NSLinguisticTagAdjective;
				break;
			case 7: // NSLinguisticTag.Adverb
				ptr = NSLinguisticTagAdverb;
				break;
			case 8: // NSLinguisticTag.Pronoun
				ptr = NSLinguisticTagPronoun;
				break;
			case 9: // NSLinguisticTag.Determiner
				ptr = NSLinguisticTagDeterminer;
				break;
			case 10: // NSLinguisticTag.Particle
				ptr = NSLinguisticTagParticle;
				break;
			case 11: // NSLinguisticTag.Preposition
				ptr = NSLinguisticTagPreposition;
				break;
			case 12: // NSLinguisticTag.Number
				ptr = NSLinguisticTagNumber;
				break;
			case 13: // NSLinguisticTag.Conjunction
				ptr = NSLinguisticTagConjunction;
				break;
			case 14: // NSLinguisticTag.Interjection
				ptr = NSLinguisticTagInterjection;
				break;
			case 15: // NSLinguisticTag.Classifier
				ptr = NSLinguisticTagClassifier;
				break;
			case 16: // NSLinguisticTag.Idiom
				ptr = NSLinguisticTagIdiom;
				break;
			case 17: // NSLinguisticTag.OtherWord
				ptr = NSLinguisticTagOtherWord;
				break;
			case 18: // NSLinguisticTag.Terminator
				ptr = NSLinguisticTagSentenceTerminator;
				break;
			case 19: // NSLinguisticTag.OpenQuote
				ptr = NSLinguisticTagOpenQuote;
				break;
			case 20: // NSLinguisticTag.CloseQuote
				ptr = NSLinguisticTagCloseQuote;
				break;
			case 21: // NSLinguisticTag.OpenParenthesis
				ptr = NSLinguisticTagOpenParenthesis;
				break;
			case 22: // NSLinguisticTag.CloseParenthesis
				ptr = NSLinguisticTagCloseParenthesis;
				break;
			case 23: // NSLinguisticTag.WordJoiner
				ptr = NSLinguisticTagWordJoiner;
				break;
			case 24: // NSLinguisticTag.Dash
				ptr = NSLinguisticTagDash;
				break;
			case 25: // NSLinguisticTag.OtherPunctuation
				ptr = NSLinguisticTagOtherPunctuation;
				break;
			case 26: // NSLinguisticTag.ParagraphBreak
				ptr = NSLinguisticTagParagraphBreak;
				break;
			case 27: // NSLinguisticTag.OtherWhitespace
				ptr = NSLinguisticTagOtherWhitespace;
				break;
			case 28: // NSLinguisticTag.PersonalName
				ptr = NSLinguisticTagPersonalName;
				break;
			case 29: // NSLinguisticTag.OrganizationName
				ptr = NSLinguisticTagOrganizationName;
				break;
			case 30: // NSLinguisticTag.PlaceName
				ptr = NSLinguisticTagPlaceName;
				break;
			}
			return (NSString?) Runtime.GetNSObject (ptr);
		}
		/// <summary>Retrieves the <see cref="global::Foundation.NSLinguisticTag" /> value named by <paramref name="constant" />.</summary>
		/// <param name="constant">The name of the constant to retrieve.</param>
		public static NSLinguisticTag GetValue (NSString constant)
		{
			if (constant is null)
				throw new ArgumentNullException (nameof (constant));
			if (constant.IsEqualTo (NSLinguisticTagWord))
				return NSLinguisticTag.Word;
			if (constant.IsEqualTo (NSLinguisticTagPunctuation))
				return NSLinguisticTag.Punctuation;
			if (constant.IsEqualTo (NSLinguisticTagWhitespace))
				return NSLinguisticTag.Whitespace;
			if (constant.IsEqualTo (NSLinguisticTagOther))
				return NSLinguisticTag.Other;
			if (constant.IsEqualTo (NSLinguisticTagNoun))
				return NSLinguisticTag.Noun;
			if (constant.IsEqualTo (NSLinguisticTagVerb))
				return NSLinguisticTag.Verb;
			if (constant.IsEqualTo (NSLinguisticTagAdjective))
				return NSLinguisticTag.Adjective;
			if (constant.IsEqualTo (NSLinguisticTagAdverb))
				return NSLinguisticTag.Adverb;
			if (constant.IsEqualTo (NSLinguisticTagPronoun))
				return NSLinguisticTag.Pronoun;
			if (constant.IsEqualTo (NSLinguisticTagDeterminer))
				return NSLinguisticTag.Determiner;
			if (constant.IsEqualTo (NSLinguisticTagParticle))
				return NSLinguisticTag.Particle;
			if (constant.IsEqualTo (NSLinguisticTagPreposition))
				return NSLinguisticTag.Preposition;
			if (constant.IsEqualTo (NSLinguisticTagNumber))
				return NSLinguisticTag.Number;
			if (constant.IsEqualTo (NSLinguisticTagConjunction))
				return NSLinguisticTag.Conjunction;
			if (constant.IsEqualTo (NSLinguisticTagInterjection))
				return NSLinguisticTag.Interjection;
			if (constant.IsEqualTo (NSLinguisticTagClassifier))
				return NSLinguisticTag.Classifier;
			if (constant.IsEqualTo (NSLinguisticTagIdiom))
				return NSLinguisticTag.Idiom;
			if (constant.IsEqualTo (NSLinguisticTagOtherWord))
				return NSLinguisticTag.OtherWord;
			if (constant.IsEqualTo (NSLinguisticTagSentenceTerminator))
				return NSLinguisticTag.Terminator;
			if (constant.IsEqualTo (NSLinguisticTagOpenQuote))
				return NSLinguisticTag.OpenQuote;
			if (constant.IsEqualTo (NSLinguisticTagCloseQuote))
				return NSLinguisticTag.CloseQuote;
			if (constant.IsEqualTo (NSLinguisticTagOpenParenthesis))
				return NSLinguisticTag.OpenParenthesis;
			if (constant.IsEqualTo (NSLinguisticTagCloseParenthesis))
				return NSLinguisticTag.CloseParenthesis;
			if (constant.IsEqualTo (NSLinguisticTagWordJoiner))
				return NSLinguisticTag.WordJoiner;
			if (constant.IsEqualTo (NSLinguisticTagDash))
				return NSLinguisticTag.Dash;
			if (constant.IsEqualTo (NSLinguisticTagOtherPunctuation))
				return NSLinguisticTag.OtherPunctuation;
			if (constant.IsEqualTo (NSLinguisticTagParagraphBreak))
				return NSLinguisticTag.ParagraphBreak;
			if (constant.IsEqualTo (NSLinguisticTagOtherWhitespace))
				return NSLinguisticTag.OtherWhitespace;
			if (constant.IsEqualTo (NSLinguisticTagPersonalName))
				return NSLinguisticTag.PersonalName;
			if (constant.IsEqualTo (NSLinguisticTagOrganizationName))
				return NSLinguisticTag.OrganizationName;
			if (constant.IsEqualTo (NSLinguisticTagPlaceName))
				return NSLinguisticTag.PlaceName;
			throw new NotSupportedException ($"{constant} has no associated enum value on this platform.");
		}
		/// <summary>Retrieves the <see cref="global::Foundation.NSLinguisticTag" /> value represented by the backing field value in <paramref name="handle" />.</summary>
		/// <param name="handle">The native handle with the name of the constant to retrieve.</param>
		public static NSLinguisticTag GetValue (NativeHandle handle)
		{
			using var str = Runtime.GetNSObject<NSString> (handle)!;
			return GetValue (str);
		}
		/// <summary>Retrieves the <see cref="global::Foundation.NSLinguisticTag" /> value represented by the backing field value in <paramref name="handle" />.</summary>
		/// <param name="handle">The native handle with the name of the constant to retrieve.</param>
		public static NSLinguisticTag? GetNullableValue (NativeHandle handle)
		{
			using var str = Runtime.GetNSObject<NSString> (handle);
			if (str is null)
				return null;
			return GetValue (str);
		}
		/// <summary>Converts an array of <see cref="global::Foundation.NSLinguisticTag" /> enum values into an array of their corresponding constants.</summary>
		/// <param name="values">The array of enum values to convert.</param>
		internal static NSString?[]? ToConstantArray (this NSLinguisticTag[]? values)
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
		internal static NSLinguisticTag[]? ToEnumArray (this NSString[]? values)
		{
			if (values is null)
				return null;
			var rv = new global::System.Collections.Generic.List<NSLinguisticTag> ();
			for (var i = 0; i < values.Length; i++) {
				var value = values [i];
				rv.Add (GetValue (value));
			}
			return rv.ToArray ();
		}
	}
}
