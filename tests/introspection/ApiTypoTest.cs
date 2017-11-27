﻿//
// Test the generated API selectors against typos or non-existing cases
//
// Authors:
//	Paola Villarreal  <paola.villarreal@xamarin.com>
//
// Copyright 2015 Xamarin Inc.
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//   http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
//

using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using NUnit.Framework;
#if XAMCORE_2_0
using ObjCRuntime;
#if MONOMAC
using AppKit;
#else
using UIKit;
#endif
using Foundation;
#else
#if MONOMAC
using MonoMac.AppKit;
using MonoMac.ObjCRuntime;
using MonoMac.Foundation;
#else
using MonoTouch.UIKit;
#endif
using MonoTouch.Foundation;
#endif

namespace Introspection
{
	public abstract class ApiTypoTest : ApiBaseTest
	{
		protected ApiTypoTest ()
		{
			ContinueOnFailure = true;
		}

		public virtual bool Skip (Type baseType, string typo) {
			return SkipAllowed (baseType.Name, null, typo);
		}

		public virtual bool Skip (MemberInfo methodName, string typo) {
			return SkipAllowed (methodName.DeclaringType.Name, methodName.Name, typo);
		}

		HashSet<string> allowedMemberRule4 = new HashSet<string> {
			"Platform",
			"PlatformHelper",
			"AvailabilityAttribute",
			"iOSAttribute",
			"MacAttribute",
		};

		HashSet<string> allowed = new HashSet<string> () {
			"Aac",
			"Accurracy",
			"Achivements",
			"Acos",
			"Acn",
			"Actionname",
			"Activitiy",
			"Addin",
			"Addr",
			"Adjustmentfor",
			"Aifc",
			"Aiff",
			"Alg", // short for Algorithm
			"Amete",
			"Amr",
			"Anglet",
			"Arraycollation",
			"Argb",
			"Asal",
			"Asin",
			"Atan",
			"Ats",	// App Transport Security
			"Attrib",
			"Attributevalue",
			"Audiofile",
			"Automapping",
			"Automounted",
			"Autoredirect",
			"Avci", // file type
			"Aliasable",
			"Arcball",
			"Backface",
			"Bancaire", // french
			"Bancaires", // french
			"Bary",
			"Batc",
			"Bgra", // acrnym for Blue, Green, Red, Alpha
			"Bim",
			"Biquad",
			"Bitangent",
			"Blinn",
			"Blit",
			"Bokeh",
			"Bggr", // acronym for Blue, Green, Green, Red 
			"Bsln",
			"Bssid",
			"Bzip",
			"Cabac",
			"Caf", // acronym: Core Audio Format
			"Cancellable",
			"Cavlc",
			"Cda", // acronym: Clinical Document Architecture
			"Celp", // MPEG4ObjectID
			"Characterteristic",
			"Chapv",
			"Chromaticities",
			"Ciff",
			"Cinepak",
			"Clearcoat",
			"Cnn", // Convolutional Neural Network
			"Colos",
			"Commerical",
			"Composable",
			"Conflictserror",
			"Connnect",
			"Counterclock",
			"Copyback",
			"Craete",
			"Crosstraining",
			"Cubemap",
			"Cmyk", // acronym: Cyan, magenta, yellow and key
			"Daap",
			"Dav",
			"Dcip", // acronym: Digital Cinema Implementation Partners
			"Deca",
			"Decomposables",
			"Deinterlace",
			"Descendents",
			"Descrete",
			"Dhe", // Diffie–Hellman key exchange
			"Differental",
			"Diffie",
			"Directionfor",
			"Dist",
			"dlclose",
			"dlerror",
			"Dlfcn",
			"dlopen",
			"Dlsym",
			"dlsym",
			"Dng",
			"Dns",
			"Dont",
			"Dop",
			"Downsample",
			"Downmix", // Sound terminology that means making a stereo mix from a 5.1 surround mix.
			"Dpa",
			"Dpad", // Directional pad (D-pad)
			"Droste",
			"Dtls",
			"Dtmf", // DTMF
			"dy",
			"Eap",
			"Ebu",
			"Ecc",   // Elliptic Curve Cryptography
			"Ecdh",  // Elliptic Curve Diffie–Hellman
			"Ecdsa", // Elliptic Curve Digital Signature Algorithm
			"Ecies", // Elliptic Curve Integrated Encryption Scheme
			"Editability", 
			"Eof", // acronym End-Of-File
			"Emagic",
			"Emaili",
			"Eppc",
			"Exhange",
			"Exp",
			"Felica", // Japanese contactless RFID smart card system
			"Femtowatts",
			"Flipside",
			"Formati",
			"Fov",
			"Framebuffer",
			"Framesetter",
			"Freq",
			"Ftps",
			"Func",
			"Gadu",
			"Gbrg",	// acronym for Green-Blue-Reg-Green
			"Geocoder",
			"Gigapascals",
			"Gpp",
			"Gpu",	// acronym for Graphics Processing Unit
			"Grbg", // acronym for Green-Red-Blue-Green
			"Greeking",
			"Hdmi",
			"Hdr",
			"Hectopascals",
			"Heic", // file type
			"Heif", // file type
			"Hevc", // CMVideoCodecType / High Efficiency Video Coding
			"Heif", // High Efficiency Image File Format
			"Hfp",
			"Hipass",
			"Hlg", // Hybrid Log-Gamma
			"Hls",
			"Hoa",
			"Hrtf", // acronym used in AUSpatializationAlgorithm
			"Hvxc", // MPEG4ObjectID
			"Ies",
			"Icq",
			"Identd",
			"Imageblock",
			"Imagefor",
			"Imap",
			"Imaps",
			"Img",
			"Indoorrun",
			"Indoorcycle",
			"Inklist",
			"Indoorwalk",
			"Inser",
			"Interac",
			"Interframe",
			"Interitem",
			"Intermenstrual",
			"Intoi",
			"Ios",
			"Ipa",
			"Ipp",
			"Iptc",
			"Ircs",
			"Itf",
			"Itu",
			"Jcb", // Japanese credit card company
			"Jfif",
			"Json",
			"Keyerror",
			"Keyi",
			"Keyspace",
			"ks",
			"Kiloampere",
			"Kiloamperes",
			"Kiloohms",
			"Kilopascals",
			"Langauges",
			"Lacunarity",
			"Ldaps",
			"Lerp",
			"Linecap",
			"Lingustic",
			"Lod",
			"Lopass",
			"Lowlevel",
			"Mapbuffer",
			"Matchingcoalesce",
			"Megaampere",
			"Megaamperes",
			"Megaliters",
			"Megameters",
			"Megaohms",
			"Megapascals",
			"Metacharacters",
			"Metalness",
			"Metadatas",
			"Microampere",
			"Microamperes",
			"Microohms",
			"Microwatts",
			"Millimoles",
			"Milliohms",
			"Mimap",
			"Minification",
			"Mncs",
			"Mobike", // acronym
			"Morpher",
			"Mpe", // acronym
			"Mtu", // acronym
			"Mtc", // acronym
			"Mul",
			"Mult",
			"Multipath",
			"Multipeer",
			"Muxed",
			"Nai",
			"Nanograms",
			"Nanowatts",
			"nfloat",
			"Nfnt",
			"nint",
			"Nntps",
			"Ntlm",
			"Ntsc",
			"nuint",
			"Ndef",
			"Numbernumber",
			"Nyquist",
			"Oaep", // Optimal asymmetric encryption padding
			"Objectfor",
			"Occlussion",
			"Ocurrences",
			"Octree",
			"Oid",
			"Olus",
			"Oneup", // TVElementKeyOneupTemplate
			"Orthographyrange",
			"Orth",
			"Ostprandial",
			"ove",
			"Paeth", // PNG filter
			"Parms", // short for Parameters
			"Peap",
			"Perlin",
			"Persistable",
			"Pausable",
			"Pcl",
			"Pcm",
			"Pdu",
			"Persistance",
			"Pesented",
			"Pfs", // acronym
			"Picometers",
			"Picowatts",
			"Pkcs",
			"Placemark",
			"Playthrough",
			"Pointillize",
			"Polyline",
			"Popularimeter",
			"Preds", // short for Predicates
			"Prerolls",
			"Preseti",
			"Propogate",
			"Psec",
			"Psm", // Protocol/Service Multiplexer
			"Pvrtc", // MTLBlitOption - PowerVR Texture Compression
			"Quaterniond",
			"Quadding",
			"Qura",
			"Quic",
			"Reacquirer",
			"Reinvitation",
			"Reinvite",
			"Reprandial",
			"Replayable",
			"Requestwith",
			"Ridesharing",
			"Rgb",
			"Rgba",
			"Rggb", // acronym for Red, Green, Green, Blue
			"Roi",
			"Romm", // acronym: Reference Output Medium Metric
			"Rpa",
			"Rpn", // acronym
			"Rsa", // Rivest, Shamir and Adleman
			"Rssi",
			"Rtp",
			"Rtl",
			"Rtsp",
			"Saml", // acronym
			"Scn",
			"Sdk",
			"Sdtv", // acronym: Standard Definition Tele Vision
			"Sdnn",
			"Seekable",
			"Shadable",
			"Sharegroup",
			"Siemen",
			"simd",
			"Sinh",
			"Sint", // as in "Signed Integer"
			"Simd",
			"Slerp",
			"Slomo",
			"Smpte",
			"Snapshotter",
			"Snorm",
			"Sobel",
			"Spacei",
			"Sqrt",
			"Srgb",
			"Ssid",
			"Ssids",
			"Standarize",
			"Stateful",
			"Stateright",
			"Subbeat",
			"Subcaption",
			"Subcardioid",
			"Subentities",
			"Subheadline",
			"Sublocality",
			"Submesh",
			"Submeshes",
			"Subpixel",
			"Subsec",
			"Suica", // Japanese contactless smart card type
			"Superentity",
			"Sym",
			"Synchronizable",
			"Symbologies",
			"Tanh",
			"Tessellator",
			"Texcoord",
			"Texel",
			"th",
			"Threadgroup",
			"Threadgroups",
			"Thumbstick",
			"Timelapse",
			"Timelapses",
			"Tls",
			"Ttls",
			"Tlv",
			"Toi",
			"Transceive",
			"Trc",
			"Truncantion",
			"Tweening",
			"tx",
			"ty",
			"Udi",
			"Udp",
			"Unconfigured",
			"Undecodable",
			"Underrun",
			"Unflagged",
			"Unfocusing",
			"Unorm",
			"Unpremultiplied",
			"Unpremultiplying",
			"Unprepare",
			"Unproject",
			"Unpublish",
			"Uterance",
			"Unentitled",
			"Untrash",
			"Utf",
			"Upce",
			"Uti",
			"Varispeed",
			"Vergence",
			"Voronoi",
			"Vnode",
			"Vpn",
			"Wep",
			"Wpa",
			"Warpable",
			"Whitespaces",
			"Writeability",
			"Xpc",
			"xy",
			"Xyz",
			"Xzy",
			"Yxz",
			"Yzx",
			"Zxy",
			"Zyx",
			"yuvs",
			"yx",
			"yy",
			"Yyy",
#if !XAMCORE_2_0
			// classic only mistakes - that should not change anymore
			"Timetime",
			"Rectfrom",
			"Distancefrom",
			"Calendarc",
			"Negotiat",
			"Trus",
			"Placemarks",
			"Chage",
			"Elipse",
			"intptr",
			"rbool",
			"rint",
			"rfloat",
			"rdouble",
			"rintptr",
			"cgsize",
			"cgpoint",
			"cgrect",
			"nsrange",
			"stret",
			"monotouch",
			"xamarin",
			"Dimiss",
			"Owneroptions",
			"Delegat",
			"Nibfor",
			"Delegatequeue",
			"Sispatch",
#endif
#if MONOMAC
			"Abbr",
			"Accum",
			"Addin",
			"Addons",
			"Appactive",
			"Approx",
			"Arae",
			"Attr",
			"Attributesfor",
			"Autoresizin",
			"Avc",
			"Callpout",
			"Ccitt",
			"Commited",
			"Constrainted",
			"Ctm",
			"Cymk",
			"Cymka",
			"Cmyka",
			"Compat",
			"Credendtials",
			"Descriptorat",
			"Descriptorfor",
			"Dimensionsfor",
			"Dissapearing",
			"Dirs",
			"Editability",
			"Eisu",
			"Entryat",
			"Equiv",
			"Fourty",
			"Grammarl",
			"Greeking",
			"Hsb",
			"Hsba",
			"Ibss",
			"Iconfor",
			"Incrementor",
			"Indexeffective",
			"Indexestable",
			"Itemto",
			"Lowsrc",
			"Lpcm",
			"Lzw",
			"Mihret",
			"Mps",
			"Nonenumerated",
			"Nsevent",
			"Numberof",
			"Orginal",
			"Parms",
			"Pbm",
			"Pde",
			"Performwith",
			"Phy",
			"Pmgt",
			"Preceeding",
			"Preds",
			"Previewable",
			"Qtvr",
			"Rangewith",
			"Rangeswith",
			"Reassociation",
			"Rectfrom",
			"Registeration",
			"Segmentnew",
			"Semitransient",
			"Sixtyfour",
			"Sourcei",
			"Steppable",
			"Stringto",
			"Succesfully",
			"Supression",
			"Targetand",
			"Tkip",
			"Tsn",
			"Tunesi",
			"Twentyfour",
			"Uneditable",
			"Unfocus",
			"Unpublish",
			"Usec",
			"Usedby",
			"Viewwrite",
			"Wep",
			"Wme",
			"Writeln",
			"Xattr",
#if !XAMCORE_2_0
			// classic only mistakes - that should not change anymore
			"Oml",
			"Abgr",
			"Alc",
			"Alignmentrange",
			"Amd",
			"Argb",
			"Arrayrestricted",
			"Arrowhighlight",
			"Atc",
			"Atrrib",
			"Attribs",
			"Backgrounn",
			"Bgr",
			"Bgra",
			"Blittable",
			"Bptc",
			"Bufferi",
			"Ccw",
			"Chn",
			"Classand",
			"Clipmap",
			"Cnd",
			"Coeff",
			"Columnto",
			"Columnwith",
			"Completionfor",
			"Compressionfactor",
			"Coumn",
			"Decr",
			"Depthfunc",
			"Dfx",
			"Directionrange",
			"Dsize",
			"Dsdt",
			"Dst",
			"Dudv",
			"Edgeflag",
			"Efx",
			"Envmap",
			"Ffd",
			"Framebuffers",
			"Framezoom",
			"Frg",
			"Froom",
			"Funcs",
			"Gainsboro",
			"Gequal",
			"Gremedy",
			"Minmax",
			"Ibm",
			"ImgProgramBinary",
			"Incr",
			"Indexvalue",
			"Ingr",
			"Itemat",
			"Iui",
			"Latc",
			"Layeredge",
			"Lequal",
			"Listenerfv",
			"Lsb",
			"Markerto",
			"Meminfo",
			"Minmax",
			"monomac",
			"Mousein",
			"Multisampled",
			"Multitexture",
			"Mux",
			"Mvp",
			"Nand",
			"Nodechild",
			"Oes",
			"Opacityin",
			"Ortho",
			"Paletted",
			"Panelfor",
			"Pasteboardtype",
			"Pasteboardtypes",
			"Perfmon",
			"Pgi",
			"Phasein",
			"Preclip",
			"Pointerv",
			"Positionof",
			"Priorityfor",
			"Qcom",
			"Rangeaffinitystill",
			"Rangesaffinitystill",
			"Rangereplacement",
			"Rangesreplacement",
			"Recip",
			"Rectby",
			"Rectcolorturned",
			"Rectto",
			"Rectwith",
			"Rgtc",
			"Rowcolumn",
			"Rowin",
			"Scalebias",
			"Sgi",
			"Sgis",
			"Sgix",
			"SgixYcrcba",
			"Sgx",
			"Sluminance",
			"Sourceb",
			"Sourcef",
			"Staterange",
			"Stq",
			"Strq",
			"Subtexture",
			"Sunx",
			"Tesselation",
			"Texgen",
			"Tipfor",
			"Unmap",
			"Unqueue",
			"Unsignaled",
			"Vdpau",
			"Vec",
			"Vtc",
			"Writemask",
			"Writeonly",
			"Ycbaycr",
			"Ycbycr",
			"Ycrcb",
			"Ycbcr",
			"Ycrcba",
#endif
#endif
		};

		// ease maintenance of the list
		HashSet<string> used = new HashSet<string> ();

		bool SkipAllowed (string typeName, string methodName, string typo)
		{
			if (allowed.Contains (typo)) {
				used.Add (typo);
				return true;
			}
			return false;
		}

		bool IsObsolete (MemberInfo mi)
		{
			if (mi == null)
				return false;
			if (mi.GetCustomAttributes<ObsoleteAttribute> (true).Any ())
				return true;
			if (mi.GetCustomAttributes<ObsoletedAttribute> (true).Any ())
				return true;
			return IsObsolete (mi.DeclaringType);
		}

		[Test]
		public void TypoTest ()
		{
			var types = Assembly.GetTypes ();
			int totalErrors = 0;
			foreach (Type t in types) {
				if (t.IsPublic) {
					AttributesMessageTypoRules (t, t.Name, ref totalErrors);

					if (IsObsolete (t))
						continue;

					string txt = NameCleaner (t.Name);
					var typo = GetTypo (txt);
					if (typo.Length > 0 ) {
						if (!Skip (t, typo)) {
							ReportError ("Typo in TYPE: {0} - {1} ", t.Name, typo);
							totalErrors++;
						}
					}

					var fields = t.GetFields ();
					foreach (FieldInfo f in fields) {
						if (!f.IsPublic && !f.IsFamily)
							continue;

						AttributesMessageTypoRules (f, t.Name, ref totalErrors);

						if (IsObsolete (f))
							continue;
						
						txt = NameCleaner (f.Name);
						typo = GetTypo (txt);
						if (typo.Length > 0) {
							if (!Skip (f, typo)) {
								ReportError ("Typo in FIELD name: {0} - {1}, Type: {2}", f.Name, typo, t.Name);
								totalErrors++;
							}
						}
					}

					var methods = t.GetMethods ();
					foreach (MethodInfo m in methods) {
						if (!m.IsPublic && !m.IsFamily)
							continue;

						AttributesMessageTypoRules (m, t.Name, ref totalErrors);

						if (IsObsolete (m))
							continue;
						
						txt = NameCleaner (m.Name);
						typo = GetTypo (txt);
						if (typo.Length > 0) {
							if (!Skip (m, typo)) {
								ReportError ("Typo in METHOD name: {0} - {1}, Type: {2}", m.Name, typo, t.Name);
								totalErrors++;
							}
						}
#if false
						var parameters = m.GetParameters ();
						foreach (ParameterInfo p in parameters) {
							txt = NameCleaner (p.Name);
							typo = GetTypo (txt);
							if (typo.Length > 0) {
								ReportError ("Typo in PARAMETER Name: {0} - {1}, Method: {2}, Type: {3}", p.Name, typo, m.Name, t.Name);
								totalErrors++;
							}
						}
#endif
					}
				}
			}
#if false
			// ease removal of unrequired values (but needs to be checked for every profile)
			var unused = allowed.Except (used);
			foreach (var typo in unused)
				Console.WriteLine ("Unused entry \"{0}\"", typo);
#endif
			Assert.IsTrue ((totalErrors == 0), "We have {0} typos!", totalErrors);
		}

		string GetMessage (object attribute)
		{
			string message = null;
			if (attribute is AdviceAttribute)
				message = ((AdviceAttribute)attribute).Message;
			if (attribute is ObsoleteAttribute)
				message = ((ObsoleteAttribute)attribute).Message;
			if (attribute is AvailabilityBaseAttribute)
				message = ((AvailabilityBaseAttribute)attribute).Message;

			return message;
		}

		void AttributesMessageTypoRules (MemberInfo mi, string typeName, ref int totalErrors)
		{
			if (mi == null)
				return;

			foreach (object ca in mi.GetCustomAttributes ()) {
				string message = GetMessage (ca);
				if (message != null) {
					var memberAndTypeFormat = mi.Name == typeName ? "Type: {0}" : "Member name: {1}, Type: {0}";
					var memberAndType = string.Format (memberAndTypeFormat, typeName, mi.Name);

					// Rule 1: https://github.com/xamarin/xamarin-macios/wiki/BINDINGS#rule-1
					// Note: we don't enforce that rule for the Obsolete (not Obsoleted) attribute since the attribute itself doesn't support versions.
					if (!(ca is ObsoleteAttribute)) {
						var forbiddenOSNames = new [] { "iOS", "watchOS", "tvOS", "macOS" };
						if (forbiddenOSNames.Any (s => Regex.IsMatch (message, $"({s} ?)[0-9]+"))) {
							ReportError ("[Rule 1] Don't put OS information in attribute's message: \"{0}\" - {1}", message, memberAndType);
							totalErrors++;
						}
					}

					// Rule 2: https://github.com/xamarin/xamarin-macios/wiki/BINDINGS#rule-2
					if (message.Contains ('`')) {
						ReportError ("[Rule 2] Replace grave accent (`) by apostrophe (') in attribute's message: \"{0}\" - {1}", message, memberAndType);
						totalErrors++;
					}

					// Rule 3: https://github.com/xamarin/xamarin-macios/wiki/BINDINGS#rule-3
					if (!message.EndsWith (".", StringComparison.Ordinal)) {
						ReportError ("[Rule 3] Missing '.' in attribute's message: \"{0}\" - {1}", message, memberAndType);
						totalErrors++;
					}

					// Rule 4: https://github.com/xamarin/xamarin-macios/wiki/BINDINGS#rule-4
					if (!allowedMemberRule4.Contains (mi.Name)) {
						var forbiddenAvailabilityKeywords = new [] { "introduced", "deprecated", "obsolete", "obsoleted" };
						if (forbiddenAvailabilityKeywords.Any (s => Regex.IsMatch (message, $"({s})", RegexOptions.IgnoreCase))) {
							ReportError ("[Rule 4] Don't use availability keywords in attribute's message: \"{0}\" - {1}", message, memberAndType);
							totalErrors++;
						}
					}

					var forbiddensWords = new [] { "OSX", "OS X" };
					for (int i = 0; i < forbiddensWords.Length; i++) {
						var word = forbiddensWords [i];
						if (Regex.IsMatch (message, $"({word})", RegexOptions.IgnoreCase)) {
							ReportError ("Don't use {0} in attribute's message: \"{1}\" - {2}", word, message, memberAndType);
							totalErrors++;
						}
					}
				}
			}
		}

		public abstract string GetTypo (string txt);

		static StringBuilder clean = new StringBuilder ();

		static string NameCleaner (string name)
		{
			clean.Clear ();
			foreach (char c in name) {
				if (Char.IsUpper (c)) {
					clean.Append (' ').Append (c);
					continue;
				}
				if (Char.IsDigit (c)) {
					clean.Append (' ');
					continue;
				}
				switch (c) {
				case '<':
				case '>':
				case '_':
					clean.Append (' ');
					break;
				default:
					clean.Append (c);
					break;
				}
			}
			return clean.ToString ();
		}
	}
}
