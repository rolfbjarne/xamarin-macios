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
	/// <summary>Calendar types that can be used with the NSCalendar constructor.</summary>
	public enum NSCalendarType : int {
		/// <summary>Gregorian calendar.</summary>
		Gregorian = 0,
		/// <summary>Buddhist calendar.</summary>
		Buddhist = 1,
		/// <summary>Chinese calendar.</summary>
		Chinese = 2,
		/// <summary>Hebrew calendar.</summary>
		Hebrew = 3,
		/// <summary>Islamic calendar.</summary>
		Islamic = 4,
		/// <summary>IslamicCivil calendar.</summary>
		IslamicCivil = 5,
		/// <summary>Japanese calendar.</summary>
		Japanese = 6,
		/// <summary>Calendar for Taiwan.</summary>
		[Obsolete ("Use 'RepublicOfChina' instead.", false)]
		[EditorBrowsable (EditorBrowsableState.Never)]
		Taiwan = 7,
		/// <summary>Calendar for the Republic of China.</summary>
		RepublicOfChina = 7,
		/// <summary>Persian calendar.</summary>
		Persian = 8,
		/// <summary>Indian calendar.</summary>
		Indian = 9,
		/// <summary>ISO8601 calendar.</summary>
		ISO8601 = 10,
		/// <summary>Coptic calendar.</summary>
		Coptic = 11,
		/// <summary>Ethiopic (Amete Alem) calendar.</summary>
		EthiopicAmeteAlem = 12,
		/// <summary>Ethiopic (Amete Mihret) calendar.</summary>
		EthiopicAmeteMihret = 13,
		/// <summary>Tabular Islamic calendar.</summary>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		IslamicTabular = 14,
		/// <summary>Islamic Umm al-Qura calendar.</summary>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		IslamicUmmAlQura = 15,
		[SupportedOSPlatform ("maccatalyst26.0")]
		[SupportedOSPlatform ("tvos26.0")]
		[SupportedOSPlatform ("macos26.0")]
		[SupportedOSPlatform ("ios26.0")]
		Bangla = 16,
		[SupportedOSPlatform ("maccatalyst26.0")]
		[SupportedOSPlatform ("tvos26.0")]
		[SupportedOSPlatform ("macos26.0")]
		[SupportedOSPlatform ("ios26.0")]
		Gujarati = 17,
		[SupportedOSPlatform ("maccatalyst26.0")]
		[SupportedOSPlatform ("tvos26.0")]
		[SupportedOSPlatform ("macos26.0")]
		[SupportedOSPlatform ("ios26.0")]
		Kannada = 18,
		[SupportedOSPlatform ("maccatalyst26.0")]
		[SupportedOSPlatform ("tvos26.0")]
		[SupportedOSPlatform ("macos26.0")]
		[SupportedOSPlatform ("ios26.0")]
		Malayalam = 19,
		[SupportedOSPlatform ("maccatalyst26.0")]
		[SupportedOSPlatform ("tvos26.0")]
		[SupportedOSPlatform ("macos26.0")]
		[SupportedOSPlatform ("ios26.0")]
		Marathi = 20,
		[SupportedOSPlatform ("maccatalyst26.0")]
		[SupportedOSPlatform ("tvos26.0")]
		[SupportedOSPlatform ("macos26.0")]
		[SupportedOSPlatform ("ios26.0")]
		Odia = 21,
		[SupportedOSPlatform ("maccatalyst26.0")]
		[SupportedOSPlatform ("tvos26.0")]
		[SupportedOSPlatform ("macos26.0")]
		[SupportedOSPlatform ("ios26.0")]
		Tamil = 22,
		[SupportedOSPlatform ("maccatalyst26.0")]
		[SupportedOSPlatform ("tvos26.0")]
		[SupportedOSPlatform ("macos26.0")]
		[SupportedOSPlatform ("ios26.0")]
		Telugu = 23,
		[SupportedOSPlatform ("maccatalyst26.0")]
		[SupportedOSPlatform ("tvos26.0")]
		[SupportedOSPlatform ("macos26.0")]
		[SupportedOSPlatform ("ios26.0")]
		Vikram = 24,
		[SupportedOSPlatform ("maccatalyst26.0")]
		[SupportedOSPlatform ("tvos26.0")]
		[SupportedOSPlatform ("macos26.0")]
		[SupportedOSPlatform ("ios26.0")]
		Dangi = 25,
		[SupportedOSPlatform ("maccatalyst26.0")]
		[SupportedOSPlatform ("tvos26.0")]
		[SupportedOSPlatform ("macos26.0")]
		[SupportedOSPlatform ("ios26.0")]
		Vietnamese = 26,
	}
	/// <summary>Extension methods for the <see cref="global::Foundation.NSCalendarType" /> enumeration.</summary>
	[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	static public partial class NSCalendarTypeExtensions {
		static IntPtr[] values = new IntPtr [27];
		[Field ("NSCalendarIdentifierGregorian", "Foundation")]
		internal unsafe static IntPtr NSCalendarIdentifierGregorian {
			get {
				fixed (IntPtr *storage = &values [0])
					return Dlfcn.CachePointer (Libraries.Foundation.Handle, "NSCalendarIdentifierGregorian", storage);
			}
		}
		[Field ("NSCalendarIdentifierBuddhist", "Foundation")]
		internal unsafe static IntPtr NSCalendarIdentifierBuddhist {
			get {
				fixed (IntPtr *storage = &values [1])
					return Dlfcn.CachePointer (Libraries.Foundation.Handle, "NSCalendarIdentifierBuddhist", storage);
			}
		}
		[Field ("NSCalendarIdentifierChinese", "Foundation")]
		internal unsafe static IntPtr NSCalendarIdentifierChinese {
			get {
				fixed (IntPtr *storage = &values [2])
					return Dlfcn.CachePointer (Libraries.Foundation.Handle, "NSCalendarIdentifierChinese", storage);
			}
		}
		[Field ("NSCalendarIdentifierHebrew", "Foundation")]
		internal unsafe static IntPtr NSCalendarIdentifierHebrew {
			get {
				fixed (IntPtr *storage = &values [3])
					return Dlfcn.CachePointer (Libraries.Foundation.Handle, "NSCalendarIdentifierHebrew", storage);
			}
		}
		[Field ("NSIslamicCalendar", "Foundation")]
		internal unsafe static IntPtr NSIslamicCalendar {
			get {
				fixed (IntPtr *storage = &values [4])
					return Dlfcn.CachePointer (Libraries.Foundation.Handle, "NSIslamicCalendar", storage);
			}
		}
		[Field ("NSCalendarIdentifierIslamicCivil", "Foundation")]
		internal unsafe static IntPtr NSCalendarIdentifierIslamicCivil {
			get {
				fixed (IntPtr *storage = &values [5])
					return Dlfcn.CachePointer (Libraries.Foundation.Handle, "NSCalendarIdentifierIslamicCivil", storage);
			}
		}
		[Field ("NSCalendarIdentifierJapanese", "Foundation")]
		internal unsafe static IntPtr NSCalendarIdentifierJapanese {
			get {
				fixed (IntPtr *storage = &values [6])
					return Dlfcn.CachePointer (Libraries.Foundation.Handle, "NSCalendarIdentifierJapanese", storage);
			}
		}
		[Field ("NSCalendarIdentifierRepublicOfChina", "Foundation")]
		internal unsafe static IntPtr NSCalendarIdentifierRepublicOfChina {
			get {
				fixed (IntPtr *storage = &values [7])
					return Dlfcn.CachePointer (Libraries.Foundation.Handle, "NSCalendarIdentifierRepublicOfChina", storage);
			}
		}
		[Field ("NSCalendarIdentifierPersian", "Foundation")]
		internal unsafe static IntPtr NSCalendarIdentifierPersian {
			get {
				fixed (IntPtr *storage = &values [8])
					return Dlfcn.CachePointer (Libraries.Foundation.Handle, "NSCalendarIdentifierPersian", storage);
			}
		}
		[Field ("NSCalendarIdentifierIndian", "Foundation")]
		internal unsafe static IntPtr NSCalendarIdentifierIndian {
			get {
				fixed (IntPtr *storage = &values [9])
					return Dlfcn.CachePointer (Libraries.Foundation.Handle, "NSCalendarIdentifierIndian", storage);
			}
		}
		[Field ("NSCalendarIdentifierISO8601", "Foundation")]
		internal unsafe static IntPtr NSCalendarIdentifierISO8601 {
			get {
				fixed (IntPtr *storage = &values [10])
					return Dlfcn.CachePointer (Libraries.Foundation.Handle, "NSCalendarIdentifierISO8601", storage);
			}
		}
		[Field ("NSCalendarIdentifierCoptic", "Foundation")]
		internal unsafe static IntPtr NSCalendarIdentifierCoptic {
			get {
				fixed (IntPtr *storage = &values [11])
					return Dlfcn.CachePointer (Libraries.Foundation.Handle, "NSCalendarIdentifierCoptic", storage);
			}
		}
		[Field ("NSCalendarIdentifierEthiopicAmeteAlem", "Foundation")]
		internal unsafe static IntPtr NSCalendarIdentifierEthiopicAmeteAlem {
			get {
				fixed (IntPtr *storage = &values [12])
					return Dlfcn.CachePointer (Libraries.Foundation.Handle, "NSCalendarIdentifierEthiopicAmeteAlem", storage);
			}
		}
		[Field ("NSCalendarIdentifierEthiopicAmeteMihret", "Foundation")]
		internal unsafe static IntPtr NSCalendarIdentifierEthiopicAmeteMihret {
			get {
				fixed (IntPtr *storage = &values [13])
					return Dlfcn.CachePointer (Libraries.Foundation.Handle, "NSCalendarIdentifierEthiopicAmeteMihret", storage);
			}
		}
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[Field ("NSCalendarIdentifierIslamicTabular", "Foundation")]
		internal unsafe static IntPtr NSCalendarIdentifierIslamicTabular {
			get {
				fixed (IntPtr *storage = &values [14])
					return Dlfcn.CachePointer (Libraries.Foundation.Handle, "NSCalendarIdentifierIslamicTabular", storage);
			}
		}
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[Field ("NSCalendarIdentifierIslamicUmmAlQura", "Foundation")]
		internal unsafe static IntPtr NSCalendarIdentifierIslamicUmmAlQura {
			get {
				fixed (IntPtr *storage = &values [15])
					return Dlfcn.CachePointer (Libraries.Foundation.Handle, "NSCalendarIdentifierIslamicUmmAlQura", storage);
			}
		}
		[SupportedOSPlatform ("maccatalyst26.0")]
		[SupportedOSPlatform ("tvos26.0")]
		[SupportedOSPlatform ("macos26.0")]
		[SupportedOSPlatform ("ios26.0")]
		[Field ("NSCalendarIdentifierBangla", "Foundation")]
		internal unsafe static IntPtr NSCalendarIdentifierBangla {
			get {
				fixed (IntPtr *storage = &values [16])
					return Dlfcn.CachePointer (Libraries.Foundation.Handle, "NSCalendarIdentifierBangla", storage);
			}
		}
		[SupportedOSPlatform ("maccatalyst26.0")]
		[SupportedOSPlatform ("tvos26.0")]
		[SupportedOSPlatform ("macos26.0")]
		[SupportedOSPlatform ("ios26.0")]
		[Field ("NSCalendarIdentifierGujarati", "Foundation")]
		internal unsafe static IntPtr NSCalendarIdentifierGujarati {
			get {
				fixed (IntPtr *storage = &values [17])
					return Dlfcn.CachePointer (Libraries.Foundation.Handle, "NSCalendarIdentifierGujarati", storage);
			}
		}
		[SupportedOSPlatform ("maccatalyst26.0")]
		[SupportedOSPlatform ("tvos26.0")]
		[SupportedOSPlatform ("macos26.0")]
		[SupportedOSPlatform ("ios26.0")]
		[Field ("NSCalendarIdentifierKannada", "Foundation")]
		internal unsafe static IntPtr NSCalendarIdentifierKannada {
			get {
				fixed (IntPtr *storage = &values [18])
					return Dlfcn.CachePointer (Libraries.Foundation.Handle, "NSCalendarIdentifierKannada", storage);
			}
		}
		[SupportedOSPlatform ("maccatalyst26.0")]
		[SupportedOSPlatform ("tvos26.0")]
		[SupportedOSPlatform ("macos26.0")]
		[SupportedOSPlatform ("ios26.0")]
		[Field ("NSCalendarIdentifierMalayalam", "Foundation")]
		internal unsafe static IntPtr NSCalendarIdentifierMalayalam {
			get {
				fixed (IntPtr *storage = &values [19])
					return Dlfcn.CachePointer (Libraries.Foundation.Handle, "NSCalendarIdentifierMalayalam", storage);
			}
		}
		[SupportedOSPlatform ("maccatalyst26.0")]
		[SupportedOSPlatform ("tvos26.0")]
		[SupportedOSPlatform ("macos26.0")]
		[SupportedOSPlatform ("ios26.0")]
		[Field ("NSCalendarIdentifierMarathi", "Foundation")]
		internal unsafe static IntPtr NSCalendarIdentifierMarathi {
			get {
				fixed (IntPtr *storage = &values [20])
					return Dlfcn.CachePointer (Libraries.Foundation.Handle, "NSCalendarIdentifierMarathi", storage);
			}
		}
		[SupportedOSPlatform ("maccatalyst26.0")]
		[SupportedOSPlatform ("tvos26.0")]
		[SupportedOSPlatform ("macos26.0")]
		[SupportedOSPlatform ("ios26.0")]
		[Field ("NSCalendarIdentifierOdia", "Foundation")]
		internal unsafe static IntPtr NSCalendarIdentifierOdia {
			get {
				fixed (IntPtr *storage = &values [21])
					return Dlfcn.CachePointer (Libraries.Foundation.Handle, "NSCalendarIdentifierOdia", storage);
			}
		}
		[SupportedOSPlatform ("maccatalyst26.0")]
		[SupportedOSPlatform ("tvos26.0")]
		[SupportedOSPlatform ("macos26.0")]
		[SupportedOSPlatform ("ios26.0")]
		[Field ("NSCalendarIdentifierTamil", "Foundation")]
		internal unsafe static IntPtr NSCalendarIdentifierTamil {
			get {
				fixed (IntPtr *storage = &values [22])
					return Dlfcn.CachePointer (Libraries.Foundation.Handle, "NSCalendarIdentifierTamil", storage);
			}
		}
		[SupportedOSPlatform ("maccatalyst26.0")]
		[SupportedOSPlatform ("tvos26.0")]
		[SupportedOSPlatform ("macos26.0")]
		[SupportedOSPlatform ("ios26.0")]
		[Field ("NSCalendarIdentifierTelugu", "Foundation")]
		internal unsafe static IntPtr NSCalendarIdentifierTelugu {
			get {
				fixed (IntPtr *storage = &values [23])
					return Dlfcn.CachePointer (Libraries.Foundation.Handle, "NSCalendarIdentifierTelugu", storage);
			}
		}
		[SupportedOSPlatform ("maccatalyst26.0")]
		[SupportedOSPlatform ("tvos26.0")]
		[SupportedOSPlatform ("macos26.0")]
		[SupportedOSPlatform ("ios26.0")]
		[Field ("NSCalendarIdentifierVikram", "Foundation")]
		internal unsafe static IntPtr NSCalendarIdentifierVikram {
			get {
				fixed (IntPtr *storage = &values [24])
					return Dlfcn.CachePointer (Libraries.Foundation.Handle, "NSCalendarIdentifierVikram", storage);
			}
		}
		[SupportedOSPlatform ("maccatalyst26.0")]
		[SupportedOSPlatform ("tvos26.0")]
		[SupportedOSPlatform ("macos26.0")]
		[SupportedOSPlatform ("ios26.0")]
		[Field ("NSCalendarIdentifierDangi", "Foundation")]
		internal unsafe static IntPtr NSCalendarIdentifierDangi {
			get {
				fixed (IntPtr *storage = &values [25])
					return Dlfcn.CachePointer (Libraries.Foundation.Handle, "NSCalendarIdentifierDangi", storage);
			}
		}
		[SupportedOSPlatform ("maccatalyst26.0")]
		[SupportedOSPlatform ("tvos26.0")]
		[SupportedOSPlatform ("macos26.0")]
		[SupportedOSPlatform ("ios26.0")]
		[Field ("NSCalendarIdentifierVietnamese", "Foundation")]
		internal unsafe static IntPtr NSCalendarIdentifierVietnamese {
			get {
				fixed (IntPtr *storage = &values [26])
					return Dlfcn.CachePointer (Libraries.Foundation.Handle, "NSCalendarIdentifierVietnamese", storage);
			}
		}
		/// <summary>Retrieves the <see cref="global::Foundation.NSString" /> constant that describes <paramref name="self" />.</summary>
		/// <param name="self">The instance on which this method operates.</param>
		public static NSString? GetConstant (this NSCalendarType self)
		{
			IntPtr ptr = IntPtr.Zero;
			switch ((int) self) {
			case 0: // NSCalendarType.Gregorian
				ptr = NSCalendarIdentifierGregorian;
				break;
			case 1: // NSCalendarType.Buddhist
				ptr = NSCalendarIdentifierBuddhist;
				break;
			case 2: // NSCalendarType.Chinese
				ptr = NSCalendarIdentifierChinese;
				break;
			case 3: // NSCalendarType.Hebrew
				ptr = NSCalendarIdentifierHebrew;
				break;
			case 4: // NSCalendarType.Islamic
				ptr = NSIslamicCalendar;
				break;
			case 5: // NSCalendarType.IslamicCivil
				ptr = NSCalendarIdentifierIslamicCivil;
				break;
			case 6: // NSCalendarType.Japanese
				ptr = NSCalendarIdentifierJapanese;
				break;
			case 7: // NSCalendarType.RepublicOfChina
				ptr = NSCalendarIdentifierRepublicOfChina;
				break;
			case 8: // NSCalendarType.Persian
				ptr = NSCalendarIdentifierPersian;
				break;
			case 9: // NSCalendarType.Indian
				ptr = NSCalendarIdentifierIndian;
				break;
			case 10: // NSCalendarType.ISO8601
				ptr = NSCalendarIdentifierISO8601;
				break;
			case 11: // NSCalendarType.Coptic
				ptr = NSCalendarIdentifierCoptic;
				break;
			case 12: // NSCalendarType.EthiopicAmeteAlem
				ptr = NSCalendarIdentifierEthiopicAmeteAlem;
				break;
			case 13: // NSCalendarType.EthiopicAmeteMihret
				ptr = NSCalendarIdentifierEthiopicAmeteMihret;
				break;
			case 14: // NSCalendarType.IslamicTabular
				ptr = NSCalendarIdentifierIslamicTabular;
				break;
			case 15: // NSCalendarType.IslamicUmmAlQura
				ptr = NSCalendarIdentifierIslamicUmmAlQura;
				break;
			case 16: // NSCalendarType.Bangla
				ptr = NSCalendarIdentifierBangla;
				break;
			case 17: // NSCalendarType.Gujarati
				ptr = NSCalendarIdentifierGujarati;
				break;
			case 18: // NSCalendarType.Kannada
				ptr = NSCalendarIdentifierKannada;
				break;
			case 19: // NSCalendarType.Malayalam
				ptr = NSCalendarIdentifierMalayalam;
				break;
			case 20: // NSCalendarType.Marathi
				ptr = NSCalendarIdentifierMarathi;
				break;
			case 21: // NSCalendarType.Odia
				ptr = NSCalendarIdentifierOdia;
				break;
			case 22: // NSCalendarType.Tamil
				ptr = NSCalendarIdentifierTamil;
				break;
			case 23: // NSCalendarType.Telugu
				ptr = NSCalendarIdentifierTelugu;
				break;
			case 24: // NSCalendarType.Vikram
				ptr = NSCalendarIdentifierVikram;
				break;
			case 25: // NSCalendarType.Dangi
				ptr = NSCalendarIdentifierDangi;
				break;
			case 26: // NSCalendarType.Vietnamese
				ptr = NSCalendarIdentifierVietnamese;
				break;
			}
			return (NSString?) Runtime.GetNSObject (ptr);
		}
		/// <summary>Retrieves the <see cref="global::Foundation.NSCalendarType" /> value named by <paramref name="constant" />.</summary>
		/// <param name="constant">The name of the constant to retrieve.</param>
		public static NSCalendarType GetValue (NSString constant)
		{
			if (constant is null)
				throw new ArgumentNullException (nameof (constant));
			if (constant.IsEqualTo (NSCalendarIdentifierGregorian))
				return NSCalendarType.Gregorian;
			if (constant.IsEqualTo (NSCalendarIdentifierBuddhist))
				return NSCalendarType.Buddhist;
			if (constant.IsEqualTo (NSCalendarIdentifierChinese))
				return NSCalendarType.Chinese;
			if (constant.IsEqualTo (NSCalendarIdentifierHebrew))
				return NSCalendarType.Hebrew;
			if (constant.IsEqualTo (NSIslamicCalendar))
				return NSCalendarType.Islamic;
			if (constant.IsEqualTo (NSCalendarIdentifierIslamicCivil))
				return NSCalendarType.IslamicCivil;
			if (constant.IsEqualTo (NSCalendarIdentifierJapanese))
				return NSCalendarType.Japanese;
			if (constant.IsEqualTo (NSCalendarIdentifierRepublicOfChina))
				return NSCalendarType.RepublicOfChina;
			if (constant.IsEqualTo (NSCalendarIdentifierPersian))
				return NSCalendarType.Persian;
			if (constant.IsEqualTo (NSCalendarIdentifierIndian))
				return NSCalendarType.Indian;
			if (constant.IsEqualTo (NSCalendarIdentifierISO8601))
				return NSCalendarType.ISO8601;
			if (constant.IsEqualTo (NSCalendarIdentifierCoptic))
				return NSCalendarType.Coptic;
			if (constant.IsEqualTo (NSCalendarIdentifierEthiopicAmeteAlem))
				return NSCalendarType.EthiopicAmeteAlem;
			if (constant.IsEqualTo (NSCalendarIdentifierEthiopicAmeteMihret))
				return NSCalendarType.EthiopicAmeteMihret;
			if (constant.IsEqualTo (NSCalendarIdentifierIslamicTabular))
				return NSCalendarType.IslamicTabular;
			if (constant.IsEqualTo (NSCalendarIdentifierIslamicUmmAlQura))
				return NSCalendarType.IslamicUmmAlQura;
			if (constant.IsEqualTo (NSCalendarIdentifierBangla))
				return NSCalendarType.Bangla;
			if (constant.IsEqualTo (NSCalendarIdentifierGujarati))
				return NSCalendarType.Gujarati;
			if (constant.IsEqualTo (NSCalendarIdentifierKannada))
				return NSCalendarType.Kannada;
			if (constant.IsEqualTo (NSCalendarIdentifierMalayalam))
				return NSCalendarType.Malayalam;
			if (constant.IsEqualTo (NSCalendarIdentifierMarathi))
				return NSCalendarType.Marathi;
			if (constant.IsEqualTo (NSCalendarIdentifierOdia))
				return NSCalendarType.Odia;
			if (constant.IsEqualTo (NSCalendarIdentifierTamil))
				return NSCalendarType.Tamil;
			if (constant.IsEqualTo (NSCalendarIdentifierTelugu))
				return NSCalendarType.Telugu;
			if (constant.IsEqualTo (NSCalendarIdentifierVikram))
				return NSCalendarType.Vikram;
			if (constant.IsEqualTo (NSCalendarIdentifierDangi))
				return NSCalendarType.Dangi;
			if (constant.IsEqualTo (NSCalendarIdentifierVietnamese))
				return NSCalendarType.Vietnamese;
			throw new NotSupportedException ($"{constant} has no associated enum value on this platform.");
		}
		/// <summary>Retrieves the <see cref="global::Foundation.NSCalendarType" /> value represented by the backing field value in <paramref name="handle" />.</summary>
		/// <param name="handle">The native handle with the name of the constant to retrieve.</param>
		public static NSCalendarType GetValue (NativeHandle handle)
		{
			using var str = Runtime.GetNSObject<NSString> (handle)!;
			return GetValue (str);
		}
		/// <summary>Retrieves the <see cref="global::Foundation.NSCalendarType" /> value represented by the backing field value in <paramref name="handle" />.</summary>
		/// <param name="handle">The native handle with the name of the constant to retrieve.</param>
		public static NSCalendarType? GetNullableValue (NativeHandle handle)
		{
			using var str = Runtime.GetNSObject<NSString> (handle);
			if (str is null)
				return null;
			return GetValue (str);
		}
		/// <summary>Converts an array of <see cref="global::Foundation.NSCalendarType" /> enum values into an array of their corresponding constants.</summary>
		/// <param name="values">The array of enum values to convert.</param>
		internal static NSString?[]? ToConstantArray (this NSCalendarType[]? values)
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
		internal static NSCalendarType[]? ToEnumArray (this NSString[]? values)
		{
			if (values is null)
				return null;
			var rv = new global::System.Collections.Generic.List<NSCalendarType> ();
			for (var i = 0; i < values.Length; i++) {
				var value = values [i];
				rv.Add (GetValue (value));
			}
			return rv.ToArray ();
		}
	}
}
