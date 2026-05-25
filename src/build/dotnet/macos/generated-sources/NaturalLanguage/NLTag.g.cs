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
	/// <summary>Enumerates token types.</summary>
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("tvos")]
	public unsafe static partial class NLTag  {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _Adjective;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("NLTagAdjective",  "NaturalLanguage")]
		public static NSString Adjective {
			get {
				if (_Adjective is null)
					_Adjective = Dlfcn.GetStringConstant (Libraries.NaturalLanguage.Handle, "NLTagAdjective")!;
				return _Adjective;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _Adverb;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("NLTagAdverb",  "NaturalLanguage")]
		public static NSString Adverb {
			get {
				if (_Adverb is null)
					_Adverb = Dlfcn.GetStringConstant (Libraries.NaturalLanguage.Handle, "NLTagAdverb")!;
				return _Adverb;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _Classifier;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("NLTagClassifier",  "NaturalLanguage")]
		public static NSString Classifier {
			get {
				if (_Classifier is null)
					_Classifier = Dlfcn.GetStringConstant (Libraries.NaturalLanguage.Handle, "NLTagClassifier")!;
				return _Classifier;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _CloseParenthesis;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("NLTagCloseParenthesis",  "NaturalLanguage")]
		public static NSString CloseParenthesis {
			get {
				if (_CloseParenthesis is null)
					_CloseParenthesis = Dlfcn.GetStringConstant (Libraries.NaturalLanguage.Handle, "NLTagCloseParenthesis")!;
				return _CloseParenthesis;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _CloseQuote;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("NLTagCloseQuote",  "NaturalLanguage")]
		public static NSString CloseQuote {
			get {
				if (_CloseQuote is null)
					_CloseQuote = Dlfcn.GetStringConstant (Libraries.NaturalLanguage.Handle, "NLTagCloseQuote")!;
				return _CloseQuote;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _Conjunction;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("NLTagConjunction",  "NaturalLanguage")]
		public static NSString Conjunction {
			get {
				if (_Conjunction is null)
					_Conjunction = Dlfcn.GetStringConstant (Libraries.NaturalLanguage.Handle, "NLTagConjunction")!;
				return _Conjunction;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _Dash;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("NLTagDash",  "NaturalLanguage")]
		public static NSString Dash {
			get {
				if (_Dash is null)
					_Dash = Dlfcn.GetStringConstant (Libraries.NaturalLanguage.Handle, "NLTagDash")!;
				return _Dash;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _Determiner;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("NLTagDeterminer",  "NaturalLanguage")]
		public static NSString Determiner {
			get {
				if (_Determiner is null)
					_Determiner = Dlfcn.GetStringConstant (Libraries.NaturalLanguage.Handle, "NLTagDeterminer")!;
				return _Determiner;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _Idiom;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("NLTagIdiom",  "NaturalLanguage")]
		public static NSString Idiom {
			get {
				if (_Idiom is null)
					_Idiom = Dlfcn.GetStringConstant (Libraries.NaturalLanguage.Handle, "NLTagIdiom")!;
				return _Idiom;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _Interjection;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("NLTagInterjection",  "NaturalLanguage")]
		public static NSString Interjection {
			get {
				if (_Interjection is null)
					_Interjection = Dlfcn.GetStringConstant (Libraries.NaturalLanguage.Handle, "NLTagInterjection")!;
				return _Interjection;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _Noun;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("NLTagNoun",  "NaturalLanguage")]
		public static NSString Noun {
			get {
				if (_Noun is null)
					_Noun = Dlfcn.GetStringConstant (Libraries.NaturalLanguage.Handle, "NLTagNoun")!;
				return _Noun;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _Number;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("NLTagNumber",  "NaturalLanguage")]
		public static NSString Number {
			get {
				if (_Number is null)
					_Number = Dlfcn.GetStringConstant (Libraries.NaturalLanguage.Handle, "NLTagNumber")!;
				return _Number;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _OpenParenthesis;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("NLTagOpenParenthesis",  "NaturalLanguage")]
		public static NSString OpenParenthesis {
			get {
				if (_OpenParenthesis is null)
					_OpenParenthesis = Dlfcn.GetStringConstant (Libraries.NaturalLanguage.Handle, "NLTagOpenParenthesis")!;
				return _OpenParenthesis;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _OpenQuote;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("NLTagOpenQuote",  "NaturalLanguage")]
		public static NSString OpenQuote {
			get {
				if (_OpenQuote is null)
					_OpenQuote = Dlfcn.GetStringConstant (Libraries.NaturalLanguage.Handle, "NLTagOpenQuote")!;
				return _OpenQuote;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _OrganizationName;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("NLTagOrganizationName",  "NaturalLanguage")]
		public static NSString OrganizationName {
			get {
				if (_OrganizationName is null)
					_OrganizationName = Dlfcn.GetStringConstant (Libraries.NaturalLanguage.Handle, "NLTagOrganizationName")!;
				return _OrganizationName;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _Other;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("NLTagOther",  "NaturalLanguage")]
		public static NSString Other {
			get {
				if (_Other is null)
					_Other = Dlfcn.GetStringConstant (Libraries.NaturalLanguage.Handle, "NLTagOther")!;
				return _Other;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _OtherPunctuation;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("NLTagOtherPunctuation",  "NaturalLanguage")]
		public static NSString OtherPunctuation {
			get {
				if (_OtherPunctuation is null)
					_OtherPunctuation = Dlfcn.GetStringConstant (Libraries.NaturalLanguage.Handle, "NLTagOtherPunctuation")!;
				return _OtherPunctuation;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _OtherWhitespace;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("NLTagOtherWhitespace",  "NaturalLanguage")]
		public static NSString OtherWhitespace {
			get {
				if (_OtherWhitespace is null)
					_OtherWhitespace = Dlfcn.GetStringConstant (Libraries.NaturalLanguage.Handle, "NLTagOtherWhitespace")!;
				return _OtherWhitespace;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _OtherWord;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("NLTagOtherWord",  "NaturalLanguage")]
		public static NSString OtherWord {
			get {
				if (_OtherWord is null)
					_OtherWord = Dlfcn.GetStringConstant (Libraries.NaturalLanguage.Handle, "NLTagOtherWord")!;
				return _OtherWord;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ParagraphBreak;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("NLTagParagraphBreak",  "NaturalLanguage")]
		public static NSString ParagraphBreak {
			get {
				if (_ParagraphBreak is null)
					_ParagraphBreak = Dlfcn.GetStringConstant (Libraries.NaturalLanguage.Handle, "NLTagParagraphBreak")!;
				return _ParagraphBreak;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _Particle;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("NLTagParticle",  "NaturalLanguage")]
		public static NSString Particle {
			get {
				if (_Particle is null)
					_Particle = Dlfcn.GetStringConstant (Libraries.NaturalLanguage.Handle, "NLTagParticle")!;
				return _Particle;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _PersonalName;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("NLTagPersonalName",  "NaturalLanguage")]
		public static NSString PersonalName {
			get {
				if (_PersonalName is null)
					_PersonalName = Dlfcn.GetStringConstant (Libraries.NaturalLanguage.Handle, "NLTagPersonalName")!;
				return _PersonalName;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _PlaceName;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("NLTagPlaceName",  "NaturalLanguage")]
		public static NSString PlaceName {
			get {
				if (_PlaceName is null)
					_PlaceName = Dlfcn.GetStringConstant (Libraries.NaturalLanguage.Handle, "NLTagPlaceName")!;
				return _PlaceName;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _Preposition;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("NLTagPreposition",  "NaturalLanguage")]
		public static NSString Preposition {
			get {
				if (_Preposition is null)
					_Preposition = Dlfcn.GetStringConstant (Libraries.NaturalLanguage.Handle, "NLTagPreposition")!;
				return _Preposition;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _Pronoun;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("NLTagPronoun",  "NaturalLanguage")]
		public static NSString Pronoun {
			get {
				if (_Pronoun is null)
					_Pronoun = Dlfcn.GetStringConstant (Libraries.NaturalLanguage.Handle, "NLTagPronoun")!;
				return _Pronoun;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _Punctuation;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("NLTagPunctuation",  "NaturalLanguage")]
		public static NSString Punctuation {
			get {
				if (_Punctuation is null)
					_Punctuation = Dlfcn.GetStringConstant (Libraries.NaturalLanguage.Handle, "NLTagPunctuation")!;
				return _Punctuation;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _SentenceTerminator;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("NLTagSentenceTerminator",  "NaturalLanguage")]
		public static NSString SentenceTerminator {
			get {
				if (_SentenceTerminator is null)
					_SentenceTerminator = Dlfcn.GetStringConstant (Libraries.NaturalLanguage.Handle, "NLTagSentenceTerminator")!;
				return _SentenceTerminator;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _Verb;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("NLTagVerb",  "NaturalLanguage")]
		public static NSString Verb {
			get {
				if (_Verb is null)
					_Verb = Dlfcn.GetStringConstant (Libraries.NaturalLanguage.Handle, "NLTagVerb")!;
				return _Verb;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _Whitespace;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("NLTagWhitespace",  "NaturalLanguage")]
		public static NSString Whitespace {
			get {
				if (_Whitespace is null)
					_Whitespace = Dlfcn.GetStringConstant (Libraries.NaturalLanguage.Handle, "NLTagWhitespace")!;
				return _Whitespace;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _Word;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("NLTagWord",  "NaturalLanguage")]
		public static NSString Word {
			get {
				if (_Word is null)
					_Word = Dlfcn.GetStringConstant (Libraries.NaturalLanguage.Handle, "NLTagWord")!;
				return _Word;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _WordJoiner;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("NLTagWordJoiner",  "NaturalLanguage")]
		public static NSString WordJoiner {
			get {
				if (_WordJoiner is null)
					_WordJoiner = Dlfcn.GetStringConstant (Libraries.NaturalLanguage.Handle, "NLTagWordJoiner")!;
				return _WordJoiner;
			}
		}
	} /* class NLTag */
}
