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
using Photos;
using ModelIO;
using Network;
using SceneKit;
using Security;
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
using CoreAnimation;
using CoreFoundation;
using NetworkExtension;
using MetalPerformanceShadersGraph;
#nullable enable
namespace Intents {
	#pragma warning disable CS1573
	/// <summary>Interface defining attributes of utterances made or heard by Siri.</summary><remarks>To be added.</remarks>
	[SupportedOSPlatform ("tvos14.0")]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	[Protocol (Name = "INSpeakable", WrapperType = typeof (INSpeakableWrapper))]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "SpokenPhrase", Selector = "spokenPhrase", PropertyType = typeof (string), GetterSelector = "spokenPhrase", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "PronunciationHint", Selector = "pronunciationHint", PropertyType = typeof (string), GetterSelector = "pronunciationHint", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "VocabularyIdentifier", Selector = "vocabularyIdentifier", PropertyType = typeof (string), GetterSelector = "vocabularyIdentifier", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "AlternativeSpeakableMatches", Selector = "alternativeSpeakableMatches", PropertyType = typeof (Intents.IINSpeakable[]), GetterSelector = "alternativeSpeakableMatches", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = false, IsProperty = true, IsStatic = false, Name = "Identifier", Selector = "identifier", PropertyType = typeof (string), GetterSelector = "identifier", ArgumentSemantic = ArgumentSemantic.None)]
	public partial interface IINSpeakable : INativeObject, IDisposable
	{
		[DynamicDependencyAttribute ("AlternativeSpeakableMatches")]
		[DynamicDependencyAttribute ("Identifier")]
		[DynamicDependencyAttribute ("PronunciationHint")]
		[DynamicDependencyAttribute ("SpokenPhrase")]
		[DynamicDependencyAttribute ("VocabularyIdentifier")]
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.Interfaces | DynamicallyAccessedMemberTypes.PublicConstructors, typeof (INSpeakableWrapper))]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static IINSpeakable ()
		{
			GC.KeepAlive (null);
		}
		/// <summary>Siri's interpretation of the utterance.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual string SpokenPhrase {
			[Export ("spokenPhrase")]
			get {
				return _GetSpokenPhrase (this);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static string _GetSpokenPhrase (IINSpeakable This)
		{
			string ret;
			ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("spokenPhrase")), false)!;
			GC.KeepAlive (This);
			return ret;
		}
		/// <summary>Developers can use this to clarify how a name is pronounced.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual string? PronunciationHint {
			[Export ("pronunciationHint")]
			get {
				return _GetPronunciationHint (this);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static string _GetPronunciationHint (IINSpeakable This)
		{
			string ret;
			ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("pronunciationHint")), false)!;
			GC.KeepAlive (This);
			return ret;
		}
		/// <summary>Gets an array of alternative matching phrases.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos14.0")]
		[global::Foundation.RequiredMember]
		public virtual string? VocabularyIdentifier {
			[Export ("vocabularyIdentifier")]
			get {
				return _GetVocabularyIdentifier (this);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static string _GetVocabularyIdentifier (IINSpeakable This)
		{
			string ret;
			ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("vocabularyIdentifier")), false)!;
			GC.KeepAlive (This);
			return ret;
		}
		/// <summary>Gets the identifier for this string in the app-specific vocabulary file.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos14.0")]
		[global::Foundation.RequiredMember]
		public virtual IINSpeakable[]? AlternativeSpeakableMatches {
			[Export ("alternativeSpeakableMatches")]
			get {
				return _GetAlternativeSpeakableMatches (this);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static IINSpeakable[] _GetAlternativeSpeakableMatches (IINSpeakable This)
		{
			IINSpeakable[] ret;
			ret = CFArray.ArrayFromHandle<IINSpeakable>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("alternativeSpeakableMatches")), false)!;
			GC.KeepAlive (This);
			return ret;
		}
		/// <summary>The unique identifier of this pronunciation hint.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[ObsoletedOSPlatform ("macos10.13", "Use 'VocabularyIdentifier' instead.")]
		[ObsoletedOSPlatform ("ios11.0", "Use 'VocabularyIdentifier' instead.")]
		[ObsoletedOSPlatform ("tvos11.0", "Use 'VocabularyIdentifier' instead.")]
		[ObsoletedOSPlatform ("maccatalyst13.1", "Use 'VocabularyIdentifier' instead.")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos14.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[global::Foundation.OptionalMember]
		public virtual string? Identifier {
			[Export ("identifier")]
			get {
				return _GetIdentifier (this);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static string _GetIdentifier (IINSpeakable This)
		{
			string ret;
			ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("identifier")), false)!;
			GC.KeepAlive (This);
			return ret;
		}
	}
	#pragma warning restore CS1573
	#pragma warning disable CS1573
	/// <summary>Extension methods to the <see cref="IINSpeakable" /> interface to support all the methods from the INSpeakable protocol.</summary>
	/// <remarks>
	///   <para>The extension methods for <see cref="IINSpeakable" /> interface allow developers to treat instances of the interface as having all the optional methods of the original INSpeakable protocol. Since the interface only contains the required members, these extension methods allow developers to call the optional members of the protocol.</para>
	/// </remarks>
	public unsafe static partial class INSpeakable_Extensions {
		/// <summary>The unique identifier of this pronunciation hint.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static string GetIdentifier (this IINSpeakable This)
		{
			string ret;
			ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("identifier")), false)!;
			GC.KeepAlive (This);
			return ret;
		}
	}
	#pragma warning restore CS1573
	internal unsafe sealed class INSpeakableWrapper : BaseWrapper, IINSpeakable {
		public INSpeakableWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.PublicConstructors, typeof (INSpeakableWrapper))]
		static INSpeakableWrapper ()
		{
			GC.KeepAlive (null);
		}
		/// <summary>Siri's interpretation of the utterance.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public string SpokenPhrase {
			[Export ("spokenPhrase")]
			get {
				string ret;
				ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("spokenPhrase")), false)!;
				return ret;
			}
		}
		/// <summary>Developers can use this to clarify how a name is pronounced.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public string? PronunciationHint {
			[Export ("pronunciationHint")]
			get {
				string ret;
				ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("pronunciationHint")), false)!;
				return ret;
			}
		}
		/// <summary>Gets an array of alternative matching phrases.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos14.0")]
		public string? VocabularyIdentifier {
			[Export ("vocabularyIdentifier")]
			get {
				string ret;
				ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("vocabularyIdentifier")), false)!;
				return ret;
			}
		}
		/// <summary>Gets the identifier for this string in the app-specific vocabulary file.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos14.0")]
		public IINSpeakable[]? AlternativeSpeakableMatches {
			[Export ("alternativeSpeakableMatches")]
			get {
				IINSpeakable[] ret;
				ret = CFArray.ArrayFromHandle<IINSpeakable>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("alternativeSpeakableMatches")), false)!;
				return ret;
			}
		}
	}
}
