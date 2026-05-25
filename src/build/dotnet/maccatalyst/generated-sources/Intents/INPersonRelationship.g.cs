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
using Metal;
using CoreML;
using AppKit;
using MapKit;
using Photos;
using ModelIO;
using Network;
using SceneKit;
using Contacts;
using Security;
using CloudKit;
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
using FileProvider;
using CoreAnimation;
using CoreFoundation;
using NetworkExtension;
using MetalPerformanceShadersGraph;
#nullable enable
namespace Intents {
	/// <summary>Enumerates known interpersonal relationships.</summary>
	[UnsupportedOSPlatform ("tvos")]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	public enum INPersonRelationship : int {
		/// <summary>A relationship is not known.</summary>
		None = 0,
		/// <summary>Indicates a father.</summary>
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios")]
		Father = 1,
		/// <summary>Indicates a mother.</summary>
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios")]
		Mother = 2,
		/// <summary>Indicates a parent.</summary>
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios")]
		Parent = 3,
		/// <summary>Indicates a brother.</summary>
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios")]
		Brother = 4,
		/// <summary>Indicates a sister.</summary>
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios")]
		Sister = 5,
		/// <summary>Indicates a child.</summary>
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios")]
		Child = 6,
		/// <summary>Indicates a friend.</summary>
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios")]
		Friend = 7,
		/// <summary>Indicates a spouse.</summary>
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios")]
		Spouse = 8,
		/// <summary>Indicates a partner.</summary>
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios")]
		Partner = 9,
		/// <summary>Indicates an assistant.</summary>
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios")]
		Assistant = 10,
		/// <summary>Indicates a manager.</summary>
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios")]
		Manager = 11,
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		Son = 12,
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		Daughter = 13,
	}
	/// <summary>Extension methods for the <see cref="global::Intents.INPersonRelationship" /> enumeration.</summary>
	[UnsupportedOSPlatform ("tvos")]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	static public partial class INPersonRelationshipExtensions {
		static IntPtr[] values = new IntPtr [13];
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios")]
		[Field ("INPersonRelationshipFather", "Intents")]
		internal unsafe static IntPtr INPersonRelationshipFather {
			get {
				fixed (IntPtr *storage = &values [0])
					return Dlfcn.CachePointer (Libraries.Intents.Handle, "INPersonRelationshipFather", storage);
			}
		}
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios")]
		[Field ("INPersonRelationshipMother", "Intents")]
		internal unsafe static IntPtr INPersonRelationshipMother {
			get {
				fixed (IntPtr *storage = &values [1])
					return Dlfcn.CachePointer (Libraries.Intents.Handle, "INPersonRelationshipMother", storage);
			}
		}
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios")]
		[Field ("INPersonRelationshipParent", "Intents")]
		internal unsafe static IntPtr INPersonRelationshipParent {
			get {
				fixed (IntPtr *storage = &values [2])
					return Dlfcn.CachePointer (Libraries.Intents.Handle, "INPersonRelationshipParent", storage);
			}
		}
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios")]
		[Field ("INPersonRelationshipBrother", "Intents")]
		internal unsafe static IntPtr INPersonRelationshipBrother {
			get {
				fixed (IntPtr *storage = &values [3])
					return Dlfcn.CachePointer (Libraries.Intents.Handle, "INPersonRelationshipBrother", storage);
			}
		}
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios")]
		[Field ("INPersonRelationshipSister", "Intents")]
		internal unsafe static IntPtr INPersonRelationshipSister {
			get {
				fixed (IntPtr *storage = &values [4])
					return Dlfcn.CachePointer (Libraries.Intents.Handle, "INPersonRelationshipSister", storage);
			}
		}
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios")]
		[Field ("INPersonRelationshipChild", "Intents")]
		internal unsafe static IntPtr INPersonRelationshipChild {
			get {
				fixed (IntPtr *storage = &values [5])
					return Dlfcn.CachePointer (Libraries.Intents.Handle, "INPersonRelationshipChild", storage);
			}
		}
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios")]
		[Field ("INPersonRelationshipFriend", "Intents")]
		internal unsafe static IntPtr INPersonRelationshipFriend {
			get {
				fixed (IntPtr *storage = &values [6])
					return Dlfcn.CachePointer (Libraries.Intents.Handle, "INPersonRelationshipFriend", storage);
			}
		}
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios")]
		[Field ("INPersonRelationshipSpouse", "Intents")]
		internal unsafe static IntPtr INPersonRelationshipSpouse {
			get {
				fixed (IntPtr *storage = &values [7])
					return Dlfcn.CachePointer (Libraries.Intents.Handle, "INPersonRelationshipSpouse", storage);
			}
		}
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios")]
		[Field ("INPersonRelationshipPartner", "Intents")]
		internal unsafe static IntPtr INPersonRelationshipPartner {
			get {
				fixed (IntPtr *storage = &values [8])
					return Dlfcn.CachePointer (Libraries.Intents.Handle, "INPersonRelationshipPartner", storage);
			}
		}
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios")]
		[Field ("INPersonRelationshipAssistant", "Intents")]
		internal unsafe static IntPtr INPersonRelationshipAssistant {
			get {
				fixed (IntPtr *storage = &values [9])
					return Dlfcn.CachePointer (Libraries.Intents.Handle, "INPersonRelationshipAssistant", storage);
			}
		}
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios")]
		[Field ("INPersonRelationshipManager", "Intents")]
		internal unsafe static IntPtr INPersonRelationshipManager {
			get {
				fixed (IntPtr *storage = &values [10])
					return Dlfcn.CachePointer (Libraries.Intents.Handle, "INPersonRelationshipManager", storage);
			}
		}
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[Field ("INPersonRelationshipSon", "Intents")]
		internal unsafe static IntPtr INPersonRelationshipSon {
			get {
				fixed (IntPtr *storage = &values [11])
					return Dlfcn.CachePointer (Libraries.Intents.Handle, "INPersonRelationshipSon", storage);
			}
		}
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[Field ("INPersonRelationshipDaughter", "Intents")]
		internal unsafe static IntPtr INPersonRelationshipDaughter {
			get {
				fixed (IntPtr *storage = &values [12])
					return Dlfcn.CachePointer (Libraries.Intents.Handle, "INPersonRelationshipDaughter", storage);
			}
		}
		/// <summary>Retrieves the <see cref="global::Foundation.NSString" /> constant that describes <paramref name="self" />.</summary>
		/// <param name="self">The instance on which this method operates.</param>
		public static NSString? GetConstant (this INPersonRelationship self)
		{
			IntPtr ptr = IntPtr.Zero;
			switch ((int) self) {
			case 1: // INPersonRelationship.Father
				ptr = INPersonRelationshipFather;
				break;
			case 2: // INPersonRelationship.Mother
				ptr = INPersonRelationshipMother;
				break;
			case 3: // INPersonRelationship.Parent
				ptr = INPersonRelationshipParent;
				break;
			case 4: // INPersonRelationship.Brother
				ptr = INPersonRelationshipBrother;
				break;
			case 5: // INPersonRelationship.Sister
				ptr = INPersonRelationshipSister;
				break;
			case 6: // INPersonRelationship.Child
				ptr = INPersonRelationshipChild;
				break;
			case 7: // INPersonRelationship.Friend
				ptr = INPersonRelationshipFriend;
				break;
			case 8: // INPersonRelationship.Spouse
				ptr = INPersonRelationshipSpouse;
				break;
			case 9: // INPersonRelationship.Partner
				ptr = INPersonRelationshipPartner;
				break;
			case 10: // INPersonRelationship.Assistant
				ptr = INPersonRelationshipAssistant;
				break;
			case 11: // INPersonRelationship.Manager
				ptr = INPersonRelationshipManager;
				break;
			case 12: // INPersonRelationship.Son
				ptr = INPersonRelationshipSon;
				break;
			case 13: // INPersonRelationship.Daughter
				ptr = INPersonRelationshipDaughter;
				break;
			}
			return (NSString?) Runtime.GetNSObject (ptr);
		}
		/// <summary>Retrieves the <see cref="global::Intents.INPersonRelationship" /> value named by <paramref name="constant" />.</summary>
		/// <param name="constant">The name of the constant to retrieve.</param>
		public static INPersonRelationship GetValue (NSString? constant)
		{
			if (constant is null)
				return INPersonRelationship.None;
			if (constant.IsEqualTo (INPersonRelationshipFather))
				return INPersonRelationship.Father;
			if (constant.IsEqualTo (INPersonRelationshipMother))
				return INPersonRelationship.Mother;
			if (constant.IsEqualTo (INPersonRelationshipParent))
				return INPersonRelationship.Parent;
			if (constant.IsEqualTo (INPersonRelationshipBrother))
				return INPersonRelationship.Brother;
			if (constant.IsEqualTo (INPersonRelationshipSister))
				return INPersonRelationship.Sister;
			if (constant.IsEqualTo (INPersonRelationshipChild))
				return INPersonRelationship.Child;
			if (constant.IsEqualTo (INPersonRelationshipFriend))
				return INPersonRelationship.Friend;
			if (constant.IsEqualTo (INPersonRelationshipSpouse))
				return INPersonRelationship.Spouse;
			if (constant.IsEqualTo (INPersonRelationshipPartner))
				return INPersonRelationship.Partner;
			if (constant.IsEqualTo (INPersonRelationshipAssistant))
				return INPersonRelationship.Assistant;
			if (constant.IsEqualTo (INPersonRelationshipManager))
				return INPersonRelationship.Manager;
			if (constant.IsEqualTo (INPersonRelationshipSon))
				return INPersonRelationship.Son;
			if (constant.IsEqualTo (INPersonRelationshipDaughter))
				return INPersonRelationship.Daughter;
			throw new NotSupportedException ($"{constant} has no associated enum value on this platform.");
		}
		/// <summary>Retrieves the <see cref="global::Intents.INPersonRelationship" /> value represented by the backing field value in <paramref name="handle" />.</summary>
		/// <param name="handle">The native handle with the name of the constant to retrieve.</param>
		public static INPersonRelationship GetValue (NativeHandle handle)
		{
			using var str = Runtime.GetNSObject<NSString> (handle);
			return GetValue (str);
		}
		/// <summary>Retrieves the <see cref="global::Intents.INPersonRelationship" /> value represented by the backing field value in <paramref name="handle" />.</summary>
		/// <param name="handle">The native handle with the name of the constant to retrieve.</param>
		public static INPersonRelationship? GetNullableValue (NativeHandle handle)
		{
			using var str = Runtime.GetNSObject<NSString> (handle);
			if (str is null)
				return null;
			return GetValue (str);
		}
		/// <summary>Converts an array of <see cref="global::Intents.INPersonRelationship" /> enum values into an array of their corresponding constants.</summary>
		/// <param name="values">The array of enum values to convert.</param>
		internal static NSString?[]? ToConstantArray (this INPersonRelationship[]? values)
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
		internal static INPersonRelationship[]? ToEnumArray (this NSString[]? values)
		{
			if (values is null)
				return null;
			var rv = new global::System.Collections.Generic.List<INPersonRelationship> ();
			for (var i = 0; i < values.Length; i++) {
				var value = values [i];
				rv.Add (GetValue (value));
			}
			return rv.ToArray ();
		}
	}
}
