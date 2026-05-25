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
namespace Foundation {
	[SupportedOSPlatform ("tvos15.0")]
	[SupportedOSPlatform ("ios15.0")]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("macos")]
	public enum NSAttributedStringNameKey : int {
		AlternateDescription = 0,
		ImageUrl = 1,
		InflectionRule = 2,
		InflectionAlternative = 3,
		InlinePresentationIntent = 4,
		LanguageIdentifier = 5,
		[SupportedOSPlatform ("tvos16.0")]
		[SupportedOSPlatform ("macos13.0")]
		[SupportedOSPlatform ("ios16.0")]
		[SupportedOSPlatform ("maccatalyst16.0")]
		MarkdownSourcePosition = 6,
		Morphology = 7,
		PresentationIntentAttributeName = 8,
		ReplacementIndex = 9,
		[SupportedOSPlatform ("tvos17.0")]
		[SupportedOSPlatform ("macos14.0")]
		[SupportedOSPlatform ("ios17.0")]
		[SupportedOSPlatform ("maccatalyst17.0")]
		InflectionAgreementArgument = 10,
		[SupportedOSPlatform ("tvos17.0")]
		[SupportedOSPlatform ("macos14.0")]
		[SupportedOSPlatform ("ios17.0")]
		[SupportedOSPlatform ("maccatalyst17.0")]
		InflectionAgreementConcept = 11,
		[SupportedOSPlatform ("tvos17.0")]
		[SupportedOSPlatform ("macos14.0")]
		[SupportedOSPlatform ("ios17.0")]
		[SupportedOSPlatform ("maccatalyst17.0")]
		InflectionReferentConcept = 12,
		[SupportedOSPlatform ("tvos18.0")]
		[SupportedOSPlatform ("macos15.0")]
		[SupportedOSPlatform ("ios18.0")]
		[SupportedOSPlatform ("maccatalyst18.0")]
		LocalizedNumberFormat = 13,
		[SupportedOSPlatform ("tvos26.0")]
		[SupportedOSPlatform ("macos26.0")]
		[SupportedOSPlatform ("ios26.0")]
		[SupportedOSPlatform ("maccatalyst26.0")]
		ListItemDelimiter = 14,
	}
	/// <summary>Extension methods for the <see cref="global::Foundation.NSAttributedStringNameKey" /> enumeration.</summary>
	[SupportedOSPlatform ("tvos15.0")]
	[SupportedOSPlatform ("ios15.0")]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("macos")]
	[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	static public partial class NSAttributedStringNameKeyExtensions {
		static IntPtr[] values = new IntPtr [15];
		[Field ("NSAlternateDescriptionAttributeName", "Foundation")]
		internal unsafe static IntPtr NSAlternateDescriptionAttributeName {
			get {
				fixed (IntPtr *storage = &values [0])
					return Dlfcn.CachePointer (Libraries.Foundation.Handle, "NSAlternateDescriptionAttributeName", storage);
			}
		}
		[Field ("NSImageURLAttributeName", "Foundation")]
		internal unsafe static IntPtr NSImageURLAttributeName {
			get {
				fixed (IntPtr *storage = &values [1])
					return Dlfcn.CachePointer (Libraries.Foundation.Handle, "NSImageURLAttributeName", storage);
			}
		}
		[Field ("NSInflectionRuleAttributeName", "Foundation")]
		internal unsafe static IntPtr NSInflectionRuleAttributeName {
			get {
				fixed (IntPtr *storage = &values [2])
					return Dlfcn.CachePointer (Libraries.Foundation.Handle, "NSInflectionRuleAttributeName", storage);
			}
		}
		[Field ("NSInflectionAlternativeAttributeName", "Foundation")]
		internal unsafe static IntPtr NSInflectionAlternativeAttributeName {
			get {
				fixed (IntPtr *storage = &values [3])
					return Dlfcn.CachePointer (Libraries.Foundation.Handle, "NSInflectionAlternativeAttributeName", storage);
			}
		}
		[Field ("NSInlinePresentationIntentAttributeName", "Foundation")]
		internal unsafe static IntPtr NSInlinePresentationIntentAttributeName {
			get {
				fixed (IntPtr *storage = &values [4])
					return Dlfcn.CachePointer (Libraries.Foundation.Handle, "NSInlinePresentationIntentAttributeName", storage);
			}
		}
		[Field ("NSLanguageIdentifierAttributeName", "Foundation")]
		internal unsafe static IntPtr NSLanguageIdentifierAttributeName {
			get {
				fixed (IntPtr *storage = &values [5])
					return Dlfcn.CachePointer (Libraries.Foundation.Handle, "NSLanguageIdentifierAttributeName", storage);
			}
		}
		[SupportedOSPlatform ("tvos16.0")]
		[SupportedOSPlatform ("macos13.0")]
		[SupportedOSPlatform ("ios16.0")]
		[SupportedOSPlatform ("maccatalyst16.0")]
		[Field ("NSMarkdownSourcePositionAttributeName", "Foundation")]
		internal unsafe static IntPtr NSMarkdownSourcePositionAttributeName {
			get {
				fixed (IntPtr *storage = &values [6])
					return Dlfcn.CachePointer (Libraries.Foundation.Handle, "NSMarkdownSourcePositionAttributeName", storage);
			}
		}
		[Field ("NSMorphologyAttributeName", "Foundation")]
		internal unsafe static IntPtr NSMorphologyAttributeName {
			get {
				fixed (IntPtr *storage = &values [7])
					return Dlfcn.CachePointer (Libraries.Foundation.Handle, "NSMorphologyAttributeName", storage);
			}
		}
		[Field ("NSPresentationIntentAttributeName", "Foundation")]
		internal unsafe static IntPtr NSPresentationIntentAttributeName {
			get {
				fixed (IntPtr *storage = &values [8])
					return Dlfcn.CachePointer (Libraries.Foundation.Handle, "NSPresentationIntentAttributeName", storage);
			}
		}
		[Field ("NSReplacementIndexAttributeName", "Foundation")]
		internal unsafe static IntPtr NSReplacementIndexAttributeName {
			get {
				fixed (IntPtr *storage = &values [9])
					return Dlfcn.CachePointer (Libraries.Foundation.Handle, "NSReplacementIndexAttributeName", storage);
			}
		}
		[SupportedOSPlatform ("tvos17.0")]
		[SupportedOSPlatform ("macos14.0")]
		[SupportedOSPlatform ("ios17.0")]
		[SupportedOSPlatform ("maccatalyst17.0")]
		[Field ("NSInflectionAgreementArgumentAttributeName", "Foundation")]
		internal unsafe static IntPtr NSInflectionAgreementArgumentAttributeName {
			get {
				fixed (IntPtr *storage = &values [10])
					return Dlfcn.CachePointer (Libraries.Foundation.Handle, "NSInflectionAgreementArgumentAttributeName", storage);
			}
		}
		[SupportedOSPlatform ("tvos17.0")]
		[SupportedOSPlatform ("macos14.0")]
		[SupportedOSPlatform ("ios17.0")]
		[SupportedOSPlatform ("maccatalyst17.0")]
		[Field ("NSInflectionAgreementConceptAttributeName", "Foundation")]
		internal unsafe static IntPtr NSInflectionAgreementConceptAttributeName {
			get {
				fixed (IntPtr *storage = &values [11])
					return Dlfcn.CachePointer (Libraries.Foundation.Handle, "NSInflectionAgreementConceptAttributeName", storage);
			}
		}
		[SupportedOSPlatform ("tvos17.0")]
		[SupportedOSPlatform ("macos14.0")]
		[SupportedOSPlatform ("ios17.0")]
		[SupportedOSPlatform ("maccatalyst17.0")]
		[Field ("NSInflectionReferentConceptAttributeName", "Foundation")]
		internal unsafe static IntPtr NSInflectionReferentConceptAttributeName {
			get {
				fixed (IntPtr *storage = &values [12])
					return Dlfcn.CachePointer (Libraries.Foundation.Handle, "NSInflectionReferentConceptAttributeName", storage);
			}
		}
		[SupportedOSPlatform ("tvos18.0")]
		[SupportedOSPlatform ("macos15.0")]
		[SupportedOSPlatform ("ios18.0")]
		[SupportedOSPlatform ("maccatalyst18.0")]
		[Field ("NSLocalizedNumberFormatAttributeName", "Foundation")]
		internal unsafe static IntPtr NSLocalizedNumberFormatAttributeName {
			get {
				fixed (IntPtr *storage = &values [13])
					return Dlfcn.CachePointer (Libraries.Foundation.Handle, "NSLocalizedNumberFormatAttributeName", storage);
			}
		}
		[SupportedOSPlatform ("tvos26.0")]
		[SupportedOSPlatform ("macos26.0")]
		[SupportedOSPlatform ("ios26.0")]
		[SupportedOSPlatform ("maccatalyst26.0")]
		[Field ("NSListItemDelimiterAttributeName", "Foundation")]
		internal unsafe static IntPtr NSListItemDelimiterAttributeName {
			get {
				fixed (IntPtr *storage = &values [14])
					return Dlfcn.CachePointer (Libraries.Foundation.Handle, "NSListItemDelimiterAttributeName", storage);
			}
		}
		/// <summary>Retrieves the <see cref="global::Foundation.NSString" /> constant that describes <paramref name="self" />.</summary>
		/// <param name="self">The instance on which this method operates.</param>
		public static NSString? GetConstant (this NSAttributedStringNameKey self)
		{
			IntPtr ptr = IntPtr.Zero;
			switch ((int) self) {
			case 0: // NSAttributedStringNameKey.AlternateDescription
				ptr = NSAlternateDescriptionAttributeName;
				break;
			case 1: // NSAttributedStringNameKey.ImageUrl
				ptr = NSImageURLAttributeName;
				break;
			case 2: // NSAttributedStringNameKey.InflectionRule
				ptr = NSInflectionRuleAttributeName;
				break;
			case 3: // NSAttributedStringNameKey.InflectionAlternative
				ptr = NSInflectionAlternativeAttributeName;
				break;
			case 4: // NSAttributedStringNameKey.InlinePresentationIntent
				ptr = NSInlinePresentationIntentAttributeName;
				break;
			case 5: // NSAttributedStringNameKey.LanguageIdentifier
				ptr = NSLanguageIdentifierAttributeName;
				break;
			case 6: // NSAttributedStringNameKey.MarkdownSourcePosition
				ptr = NSMarkdownSourcePositionAttributeName;
				break;
			case 7: // NSAttributedStringNameKey.Morphology
				ptr = NSMorphologyAttributeName;
				break;
			case 8: // NSAttributedStringNameKey.PresentationIntentAttributeName
				ptr = NSPresentationIntentAttributeName;
				break;
			case 9: // NSAttributedStringNameKey.ReplacementIndex
				ptr = NSReplacementIndexAttributeName;
				break;
			case 10: // NSAttributedStringNameKey.InflectionAgreementArgument
				ptr = NSInflectionAgreementArgumentAttributeName;
				break;
			case 11: // NSAttributedStringNameKey.InflectionAgreementConcept
				ptr = NSInflectionAgreementConceptAttributeName;
				break;
			case 12: // NSAttributedStringNameKey.InflectionReferentConcept
				ptr = NSInflectionReferentConceptAttributeName;
				break;
			case 13: // NSAttributedStringNameKey.LocalizedNumberFormat
				ptr = NSLocalizedNumberFormatAttributeName;
				break;
			case 14: // NSAttributedStringNameKey.ListItemDelimiter
				ptr = NSListItemDelimiterAttributeName;
				break;
			}
			return (NSString?) Runtime.GetNSObject (ptr);
		}
		/// <summary>Retrieves the <see cref="global::Foundation.NSAttributedStringNameKey" /> value named by <paramref name="constant" />.</summary>
		/// <param name="constant">The name of the constant to retrieve.</param>
		public static NSAttributedStringNameKey GetValue (NSString constant)
		{
			if (constant is null)
				throw new ArgumentNullException (nameof (constant));
			if (constant.IsEqualTo (NSAlternateDescriptionAttributeName))
				return NSAttributedStringNameKey.AlternateDescription;
			if (constant.IsEqualTo (NSImageURLAttributeName))
				return NSAttributedStringNameKey.ImageUrl;
			if (constant.IsEqualTo (NSInflectionRuleAttributeName))
				return NSAttributedStringNameKey.InflectionRule;
			if (constant.IsEqualTo (NSInflectionAlternativeAttributeName))
				return NSAttributedStringNameKey.InflectionAlternative;
			if (constant.IsEqualTo (NSInlinePresentationIntentAttributeName))
				return NSAttributedStringNameKey.InlinePresentationIntent;
			if (constant.IsEqualTo (NSLanguageIdentifierAttributeName))
				return NSAttributedStringNameKey.LanguageIdentifier;
			if (constant.IsEqualTo (NSMarkdownSourcePositionAttributeName))
				return NSAttributedStringNameKey.MarkdownSourcePosition;
			if (constant.IsEqualTo (NSMorphologyAttributeName))
				return NSAttributedStringNameKey.Morphology;
			if (constant.IsEqualTo (NSPresentationIntentAttributeName))
				return NSAttributedStringNameKey.PresentationIntentAttributeName;
			if (constant.IsEqualTo (NSReplacementIndexAttributeName))
				return NSAttributedStringNameKey.ReplacementIndex;
			if (constant.IsEqualTo (NSInflectionAgreementArgumentAttributeName))
				return NSAttributedStringNameKey.InflectionAgreementArgument;
			if (constant.IsEqualTo (NSInflectionAgreementConceptAttributeName))
				return NSAttributedStringNameKey.InflectionAgreementConcept;
			if (constant.IsEqualTo (NSInflectionReferentConceptAttributeName))
				return NSAttributedStringNameKey.InflectionReferentConcept;
			if (constant.IsEqualTo (NSLocalizedNumberFormatAttributeName))
				return NSAttributedStringNameKey.LocalizedNumberFormat;
			if (constant.IsEqualTo (NSListItemDelimiterAttributeName))
				return NSAttributedStringNameKey.ListItemDelimiter;
			throw new NotSupportedException ($"{constant} has no associated enum value on this platform.");
		}
		/// <summary>Retrieves the <see cref="global::Foundation.NSAttributedStringNameKey" /> value represented by the backing field value in <paramref name="handle" />.</summary>
		/// <param name="handle">The native handle with the name of the constant to retrieve.</param>
		public static NSAttributedStringNameKey GetValue (NativeHandle handle)
		{
			using var str = Runtime.GetNSObject<NSString> (handle)!;
			return GetValue (str);
		}
		/// <summary>Retrieves the <see cref="global::Foundation.NSAttributedStringNameKey" /> value represented by the backing field value in <paramref name="handle" />.</summary>
		/// <param name="handle">The native handle with the name of the constant to retrieve.</param>
		public static NSAttributedStringNameKey? GetNullableValue (NativeHandle handle)
		{
			using var str = Runtime.GetNSObject<NSString> (handle);
			if (str is null)
				return null;
			return GetValue (str);
		}
		/// <summary>Converts an array of <see cref="global::Foundation.NSAttributedStringNameKey" /> enum values into an array of their corresponding constants.</summary>
		/// <param name="values">The array of enum values to convert.</param>
		internal static NSString?[]? ToConstantArray (this NSAttributedStringNameKey[]? values)
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
		internal static NSAttributedStringNameKey[]? ToEnumArray (this NSString[]? values)
		{
			if (values is null)
				return null;
			var rv = new global::System.Collections.Generic.List<NSAttributedStringNameKey> ();
			for (var i = 0; i < values.Length; i++) {
				var value = values [i];
				rv.Add (GetValue (value));
			}
			return rv.ToArray ();
		}
	}
}
