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
namespace CoreImage {
	/// <summary>Generator for 2-dimensional PDF417 bar codes.</summary>
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("tvos")]
	public partial class CIPdf417BarcodeGenerator : CICodeGenerator, ICIPdf417BarcodeGeneratorProtocol, ICIFilterProtocol {
		/// <summary>Creates a new <see cref="CIPdf417BarcodeGenerator" /> with default values.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public CIPdf417BarcodeGenerator () : base ("CIPDF417BarcodeGenerator")
		{
		}
		/// <summary>A constructor used when creating managed representations of unmanaged objects. Called by the runtime.</summary>
		/// <param name="handle">A pointer (handle) to the unmanaged object.</param>
		/// <remarks>
		///     <para>
		///         This constructor is invoked by the runtime infrastructure (<see cref="ObjCRuntime.Runtime.GetNSObject(ObjCRuntime.NativeHandle)" />) to create a new managed representation for a pointer to an unmanaged Objective-C object.
		///         Developers should not invoke this method directly, instead they should call <see cref="ObjCRuntime.Runtime.GetNSObject(ObjCRuntime.NativeHandle)" /> as it will prevent two instances of a managed object pointing to the same native object.
		///     </para>
		/// </remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		protected internal CIPdf417BarcodeGenerator (NativeHandle handle) : base (handle)
		{
		}
		/// <summary>Constructor to call on derived classes to skip initialization and merely allocate the object.</summary>
		/// <param name="t">Unused sentinel value, pass NSObjectFlag.Empty.</param>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected CIPdf417BarcodeGenerator (NSObjectFlag t) : base (t)
		{
		}
		/// <summary>A constructor that initializes the object from the data stored in the unarchiver object.</summary>
		/// <param name="coder">The unarchiver object.</param>
		/// <remarks>
		///   <para>This constructor is provided to allow the class to be initialized from an unarchiver (for example, during NIB deserialization). This is part of the <see cref="Foundation.NSCoding" /> protocol.</para>
		///   <para>If developers want to create a subclass of this object and continue to support deserialization from an archive, they should implement a constructor with an identical signature: taking a single parameter of type <see cref="Foundation.NSCoder" /> and decorate it with the <c>[Export("initWithCoder:"]</c> attribute.</para>
		///   <para>The state of this object can also be serialized by using the <see cref="Foundation.INSCoding.EncodeTo" /> companion method.</para>
		/// </remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("initWithCoder:")]
		public CIPdf417BarcodeGenerator (NSCoder coder) : base (NSObjectFlag.Empty)
		{
			if (coder is null)
				throw new ArgumentNullException (nameof (coder));
			NativeHandle h;
			if (IsDirectBinding) {
				h = global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("initWithCoder:"), coder.Handle);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					h = global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle (&__objc_super__, Selector.GetHandle ("initWithCoder:"), coder.Handle);
					GC.KeepAlive (this);
				}
			}
			InitializeHandle (h, "initWithCoder:");
			GC.KeepAlive (coder);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public CGImage OutputCGImage {
			get {
				return Runtime.GetINativeObject <CGImage> (GetHandle ("outputCGImage"), false)!;
			}
		}
		// CIPdf417BarcodeGeneratorProtocol protocol members 
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public NSData Message {
			[Export ("message", ArgumentSemantic.Retain)]
			get {
				return Runtime.GetNSObject <NSData> (GetHandle ("inputMessage"), false)!;
			}
			[Export ("setMessage:", ArgumentSemantic.Retain)]
			set {
				SetValue ("inputMessage", value);
			}
		}
		/// <summary>Gets or sets the minimum width of the data area, in pixels.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public float MinWidth {
			[Export ("minWidth")]
			get {
				return GetFloat ("inputMinWidth");
			}
			[Export ("setMinWidth:")]
			set {
				SetFloat ("inputMinWidth", value);
			}
		}
		/// <summary>Gets or sets the maximum width of the data area, in pixels.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public float MaxWidth {
			[Export ("maxWidth")]
			get {
				return GetFloat ("inputMaxWidth");
			}
			[Export ("setMaxWidth:")]
			set {
				SetFloat ("inputMaxWidth", value);
			}
		}
		/// <summary>Gets or sets the minimum height of the data area, in pixels.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public float MinHeight {
			[Export ("minHeight")]
			get {
				return GetFloat ("inputMinHeight");
			}
			[Export ("setMinHeight:")]
			set {
				SetFloat ("inputMinHeight", value);
			}
		}
		/// <summary>Gets or sets the maximum height of the data area, in pixels.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public float MaxHeight {
			[Export ("maxHeight")]
			get {
				return GetFloat ("inputMaxHeight");
			}
			[Export ("setMaxHeight:")]
			set {
				SetFloat ("inputMaxHeight", value);
			}
		}
		/// <summary>Gets or sets an integer value in the range [0,8] that controls how much error correction data to include in the code.</summary>
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public float InputDataColumns {
			[Export ("dataColumns")]
			get {
				return GetFloat ("inputDataColumns");
			}
			[Export ("setDataColumns:")]
			set {
				SetFloat ("inputDataColumns", value);
			}
		}
		/// <summary>Gets or sets the number of rows in the code. <c>0</c> causes the number of rows to be chosen based on the barcode extents.</summary>
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public float InputRows {
			[Export ("rows")]
			get {
				return GetFloat ("inputRows");
			}
			[Export ("setRows:")]
			set {
				SetFloat ("inputRows", value);
			}
		}
		/// <summary>Gets or sets the preferred aspect ratio of the generated code.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public float PreferredAspectRatio {
			[Export ("preferredAspectRatio")]
			get {
				return GetFloat ("inputPreferredAspectRatio");
			}
			[Export ("setPreferredAspectRatio:")]
			set {
				SetFloat ("inputPreferredAspectRatio", value);
			}
		}
		/// <summary>Gets or sets a value that controls how the data are compressed in the resulting code.</summary><remarks><c>0</c> indicates that the compression mode should be determined by the data type. <c>1</c> indicates that the data represent ASCII digits. <c>2</c> indicates that the data is ASCII text, numbers, and punctuation. <c>3</c> indicates that the data are in an unspecified format; The least compact compression scheme will be used.
		/// </remarks>
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public float InputCompactionMode {
			[Export ("compactionMode")]
			get {
				return GetFloat ("inputCompactionMode");
			}
			[Export ("setCompactionMode:")]
			set {
				SetFloat ("inputCompactionMode", value);
			}
		}
		/// <summary>Gets or sets an integer with Boolean semantics that controls whether redundant elements should be omitted to save space. <c>1</c> is true. <c>0</c> is false.</summary>
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public float InputCompactStyle {
			[Export ("compactStyle")]
			get {
				return GetFloat ("inputCompactStyle");
			}
			[Export ("setCompactStyle:")]
			set {
				SetFloat ("inputCompactStyle", value);
			}
		}
		/// <summary>Gets or sets an integer value in the range [0,8] that controls how much error correction data to include in the code.</summary>
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public float InputCorrectionLevel {
			[Export ("correctionLevel")]
			get {
				return GetFloat ("inputCorrectionLevel");
			}
			[Export ("setCorrectionLevel:")]
			set {
				SetFloat ("inputCorrectionLevel", value);
			}
		}
		/// <summary>If <see langword="true" />, the barcode will contain compaction information, even if that information is redundant.</summary>
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public float InputAlwaysSpecifyCompaction {
			[Export ("alwaysSpecifyCompaction")]
			get {
				return GetFloat ("inputAlwaysSpecifyCompaction");
			}
			[Export ("setAlwaysSpecifyCompaction:")]
			set {
				SetFloat ("inputAlwaysSpecifyCompaction", value);
			}
		}
		// CIFilterProtocol protocol members 
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public CIImage? OutputImage {
			[Export ("outputImage")]
			get {
				return (ValueForKey ("outputImage") as CIImage)!;
			}
		}
	}
}
