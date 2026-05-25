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
namespace CoreImage {
	#pragma warning disable CS1573
	/// <summary>This interface represents the Objective-C protocol <c>CIPDF417BarcodeGenerator</c>.</summary>
	/// <remarks>
	///   <para>A class that implements this interface (and subclasses <see cref="NSObject" />) will be exported to Objective-C as implementing the Objective-C protocol this interface represents.</para>
	///   <para>A class may also implement members from this interface to implement members from the protocol.</para>
	/// </remarks>
	[SupportedOSPlatform ("ios13.0")]
	[SupportedOSPlatform ("tvos13.0")]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("macos")]
	[Protocol (Name = "CIPDF417BarcodeGenerator", WrapperType = typeof (CIPdf417BarcodeGeneratorProtocolWrapper))]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "Message", Selector = "message", PropertyType = typeof (NSData), GetterSelector = "message", SetterSelector = "setMessage:", ArgumentSemantic = ArgumentSemantic.Retain)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "MinWidth", Selector = "minWidth", PropertyType = typeof (float), GetterSelector = "minWidth", SetterSelector = "setMinWidth:", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "MaxWidth", Selector = "maxWidth", PropertyType = typeof (float), GetterSelector = "maxWidth", SetterSelector = "setMaxWidth:", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "MinHeight", Selector = "minHeight", PropertyType = typeof (float), GetterSelector = "minHeight", SetterSelector = "setMinHeight:", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "MaxHeight", Selector = "maxHeight", PropertyType = typeof (float), GetterSelector = "maxHeight", SetterSelector = "setMaxHeight:", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "InputDataColumns", Selector = "dataColumns", PropertyType = typeof (float), GetterSelector = "dataColumns", SetterSelector = "setDataColumns:", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "InputRows", Selector = "rows", PropertyType = typeof (float), GetterSelector = "rows", SetterSelector = "setRows:", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "PreferredAspectRatio", Selector = "preferredAspectRatio", PropertyType = typeof (float), GetterSelector = "preferredAspectRatio", SetterSelector = "setPreferredAspectRatio:", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "InputCompactionMode", Selector = "compactionMode", PropertyType = typeof (float), GetterSelector = "compactionMode", SetterSelector = "setCompactionMode:", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "InputCompactStyle", Selector = "compactStyle", PropertyType = typeof (float), GetterSelector = "compactStyle", SetterSelector = "setCompactStyle:", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "InputCorrectionLevel", Selector = "correctionLevel", PropertyType = typeof (float), GetterSelector = "correctionLevel", SetterSelector = "setCorrectionLevel:", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "InputAlwaysSpecifyCompaction", Selector = "alwaysSpecifyCompaction", PropertyType = typeof (float), GetterSelector = "alwaysSpecifyCompaction", SetterSelector = "setAlwaysSpecifyCompaction:", ArgumentSemantic = ArgumentSemantic.None)]
	public partial interface ICIPdf417BarcodeGeneratorProtocol : INativeObject, IDisposable, 
		CoreImage.ICIFilterProtocol
	{
		[DynamicDependencyAttribute ("InputAlwaysSpecifyCompaction")]
		[DynamicDependencyAttribute ("InputCompactionMode")]
		[DynamicDependencyAttribute ("InputCompactStyle")]
		[DynamicDependencyAttribute ("InputCorrectionLevel")]
		[DynamicDependencyAttribute ("InputDataColumns")]
		[DynamicDependencyAttribute ("InputRows")]
		[DynamicDependencyAttribute ("MaxHeight")]
		[DynamicDependencyAttribute ("MaxWidth")]
		[DynamicDependencyAttribute ("Message")]
		[DynamicDependencyAttribute ("MinHeight")]
		[DynamicDependencyAttribute ("MinWidth")]
		[DynamicDependencyAttribute ("PreferredAspectRatio")]
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.Interfaces | DynamicallyAccessedMemberTypes.PublicConstructors, typeof (CIPdf417BarcodeGeneratorProtocolWrapper))]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static ICIPdf417BarcodeGeneratorProtocol ()
		{
			GC.KeepAlive (null);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual NSData Message {
			[Export ("message", ArgumentSemantic.Retain)]
			get {
				return _GetMessage (this);
			}
			[Export ("setMessage:", ArgumentSemantic.Retain)]
			set {
				_SetMessage (this, value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static NSData _GetMessage (ICIPdf417BarcodeGeneratorProtocol This)
		{
			NSData ret;
			ret =  Runtime.GetNSObject<NSData> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("message")), false)!;
			GC.KeepAlive (This);
			return ret;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SetMessage (ICIPdf417BarcodeGeneratorProtocol This, NSData value)
		{
			var value__handle__ = value!.GetNonNullHandle (nameof (value));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("setMessage:"), value__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (value);
		}
		/// <summary>Gets or sets the minimum width of the data area, in pixels.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual float MinWidth {
			[Export ("minWidth")]
			get {
				return _GetMinWidth (this);
			}
			[Export ("setMinWidth:")]
			set {
				_SetMinWidth (this, value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static float _GetMinWidth (ICIPdf417BarcodeGeneratorProtocol This)
		{
			float ret;
			ret = global::ObjCRuntime.Messaging.float_objc_msgSend (This.Handle, Selector.GetHandle ("minWidth"));
			GC.KeepAlive (This);
			return ret;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SetMinWidth (ICIPdf417BarcodeGeneratorProtocol This, float value)
		{
			global::ObjCRuntime.Messaging.void_objc_msgSend_float (This.Handle, Selector.GetHandle ("setMinWidth:"), value);
			GC.KeepAlive (This);
		}
		/// <summary>Gets or sets the maximum width of the data area, in pixels.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual float MaxWidth {
			[Export ("maxWidth")]
			get {
				return _GetMaxWidth (this);
			}
			[Export ("setMaxWidth:")]
			set {
				_SetMaxWidth (this, value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static float _GetMaxWidth (ICIPdf417BarcodeGeneratorProtocol This)
		{
			float ret;
			ret = global::ObjCRuntime.Messaging.float_objc_msgSend (This.Handle, Selector.GetHandle ("maxWidth"));
			GC.KeepAlive (This);
			return ret;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SetMaxWidth (ICIPdf417BarcodeGeneratorProtocol This, float value)
		{
			global::ObjCRuntime.Messaging.void_objc_msgSend_float (This.Handle, Selector.GetHandle ("setMaxWidth:"), value);
			GC.KeepAlive (This);
		}
		/// <summary>Gets or sets the minimum height of the data area, in pixels.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual float MinHeight {
			[Export ("minHeight")]
			get {
				return _GetMinHeight (this);
			}
			[Export ("setMinHeight:")]
			set {
				_SetMinHeight (this, value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static float _GetMinHeight (ICIPdf417BarcodeGeneratorProtocol This)
		{
			float ret;
			ret = global::ObjCRuntime.Messaging.float_objc_msgSend (This.Handle, Selector.GetHandle ("minHeight"));
			GC.KeepAlive (This);
			return ret;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SetMinHeight (ICIPdf417BarcodeGeneratorProtocol This, float value)
		{
			global::ObjCRuntime.Messaging.void_objc_msgSend_float (This.Handle, Selector.GetHandle ("setMinHeight:"), value);
			GC.KeepAlive (This);
		}
		/// <summary>Gets or sets the maximum height of the data area, in pixels.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual float MaxHeight {
			[Export ("maxHeight")]
			get {
				return _GetMaxHeight (this);
			}
			[Export ("setMaxHeight:")]
			set {
				_SetMaxHeight (this, value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static float _GetMaxHeight (ICIPdf417BarcodeGeneratorProtocol This)
		{
			float ret;
			ret = global::ObjCRuntime.Messaging.float_objc_msgSend (This.Handle, Selector.GetHandle ("maxHeight"));
			GC.KeepAlive (This);
			return ret;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SetMaxHeight (ICIPdf417BarcodeGeneratorProtocol This, float value)
		{
			global::ObjCRuntime.Messaging.void_objc_msgSend_float (This.Handle, Selector.GetHandle ("setMaxHeight:"), value);
			GC.KeepAlive (This);
		}
		/// <summary>Gets or sets an integer value in the range [0,8] that controls how much error correction data to include in the code.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual float InputDataColumns {
			[Export ("dataColumns")]
			get {
				return _GetInputDataColumns (this);
			}
			[Export ("setDataColumns:")]
			set {
				_SetInputDataColumns (this, value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static float _GetInputDataColumns (ICIPdf417BarcodeGeneratorProtocol This)
		{
			float ret;
			ret = global::ObjCRuntime.Messaging.float_objc_msgSend (This.Handle, Selector.GetHandle ("dataColumns"));
			GC.KeepAlive (This);
			return ret;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SetInputDataColumns (ICIPdf417BarcodeGeneratorProtocol This, float value)
		{
			global::ObjCRuntime.Messaging.void_objc_msgSend_float (This.Handle, Selector.GetHandle ("setDataColumns:"), value);
			GC.KeepAlive (This);
		}
		/// <summary>Gets or sets the number of rows in the code. <c>0</c> causes the number of rows to be chosen based on the barcode extents.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual float InputRows {
			[Export ("rows")]
			get {
				return _GetInputRows (this);
			}
			[Export ("setRows:")]
			set {
				_SetInputRows (this, value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static float _GetInputRows (ICIPdf417BarcodeGeneratorProtocol This)
		{
			float ret;
			ret = global::ObjCRuntime.Messaging.float_objc_msgSend (This.Handle, Selector.GetHandle ("rows"));
			GC.KeepAlive (This);
			return ret;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SetInputRows (ICIPdf417BarcodeGeneratorProtocol This, float value)
		{
			global::ObjCRuntime.Messaging.void_objc_msgSend_float (This.Handle, Selector.GetHandle ("setRows:"), value);
			GC.KeepAlive (This);
		}
		/// <summary>Gets or sets the preferred aspect ratio of the generated code.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual float PreferredAspectRatio {
			[Export ("preferredAspectRatio")]
			get {
				return _GetPreferredAspectRatio (this);
			}
			[Export ("setPreferredAspectRatio:")]
			set {
				_SetPreferredAspectRatio (this, value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static float _GetPreferredAspectRatio (ICIPdf417BarcodeGeneratorProtocol This)
		{
			float ret;
			ret = global::ObjCRuntime.Messaging.float_objc_msgSend (This.Handle, Selector.GetHandle ("preferredAspectRatio"));
			GC.KeepAlive (This);
			return ret;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SetPreferredAspectRatio (ICIPdf417BarcodeGeneratorProtocol This, float value)
		{
			global::ObjCRuntime.Messaging.void_objc_msgSend_float (This.Handle, Selector.GetHandle ("setPreferredAspectRatio:"), value);
			GC.KeepAlive (This);
		}
		/// <summary>Gets or sets a value that controls how the data are compressed in the resulting code.</summary><remarks><c>0</c> indicates that the compression mode should be determined by the data type. <c>1</c> indicates that the data represent ASCII digits. <c>2</c> indicates that the data is ASCII text, numbers, and punctuation. <c>3</c> indicates that the data are in an unspecified format; The least compact compression scheme will be used.
		/// </remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual float InputCompactionMode {
			[Export ("compactionMode")]
			get {
				return _GetInputCompactionMode (this);
			}
			[Export ("setCompactionMode:")]
			set {
				_SetInputCompactionMode (this, value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static float _GetInputCompactionMode (ICIPdf417BarcodeGeneratorProtocol This)
		{
			float ret;
			ret = global::ObjCRuntime.Messaging.float_objc_msgSend (This.Handle, Selector.GetHandle ("compactionMode"));
			GC.KeepAlive (This);
			return ret;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SetInputCompactionMode (ICIPdf417BarcodeGeneratorProtocol This, float value)
		{
			global::ObjCRuntime.Messaging.void_objc_msgSend_float (This.Handle, Selector.GetHandle ("setCompactionMode:"), value);
			GC.KeepAlive (This);
		}
		/// <summary>Gets or sets an integer with Boolean semantics that controls whether redundant elements should be omitted to save space. <c>1</c> is true. <c>0</c> is false.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual float InputCompactStyle {
			[Export ("compactStyle")]
			get {
				return _GetInputCompactStyle (this);
			}
			[Export ("setCompactStyle:")]
			set {
				_SetInputCompactStyle (this, value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static float _GetInputCompactStyle (ICIPdf417BarcodeGeneratorProtocol This)
		{
			float ret;
			ret = global::ObjCRuntime.Messaging.float_objc_msgSend (This.Handle, Selector.GetHandle ("compactStyle"));
			GC.KeepAlive (This);
			return ret;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SetInputCompactStyle (ICIPdf417BarcodeGeneratorProtocol This, float value)
		{
			global::ObjCRuntime.Messaging.void_objc_msgSend_float (This.Handle, Selector.GetHandle ("setCompactStyle:"), value);
			GC.KeepAlive (This);
		}
		/// <summary>Gets or sets an integer value in the range [0,8] that controls how much error correction data to include in the code.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual float InputCorrectionLevel {
			[Export ("correctionLevel")]
			get {
				return _GetInputCorrectionLevel (this);
			}
			[Export ("setCorrectionLevel:")]
			set {
				_SetInputCorrectionLevel (this, value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static float _GetInputCorrectionLevel (ICIPdf417BarcodeGeneratorProtocol This)
		{
			float ret;
			ret = global::ObjCRuntime.Messaging.float_objc_msgSend (This.Handle, Selector.GetHandle ("correctionLevel"));
			GC.KeepAlive (This);
			return ret;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SetInputCorrectionLevel (ICIPdf417BarcodeGeneratorProtocol This, float value)
		{
			global::ObjCRuntime.Messaging.void_objc_msgSend_float (This.Handle, Selector.GetHandle ("setCorrectionLevel:"), value);
			GC.KeepAlive (This);
		}
		/// <summary>If <see langword="true" />, the barcode will contain compaction information, even if that information is redundant.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual float InputAlwaysSpecifyCompaction {
			[Export ("alwaysSpecifyCompaction")]
			get {
				return _GetInputAlwaysSpecifyCompaction (this);
			}
			[Export ("setAlwaysSpecifyCompaction:")]
			set {
				_SetInputAlwaysSpecifyCompaction (this, value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static float _GetInputAlwaysSpecifyCompaction (ICIPdf417BarcodeGeneratorProtocol This)
		{
			float ret;
			ret = global::ObjCRuntime.Messaging.float_objc_msgSend (This.Handle, Selector.GetHandle ("alwaysSpecifyCompaction"));
			GC.KeepAlive (This);
			return ret;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SetInputAlwaysSpecifyCompaction (ICIPdf417BarcodeGeneratorProtocol This, float value)
		{
			global::ObjCRuntime.Messaging.void_objc_msgSend_float (This.Handle, Selector.GetHandle ("setAlwaysSpecifyCompaction:"), value);
			GC.KeepAlive (This);
		}
	}
	#pragma warning restore CS1573
	internal unsafe sealed class CIPdf417BarcodeGeneratorProtocolWrapper : BaseWrapper, ICIPdf417BarcodeGeneratorProtocol {
		public CIPdf417BarcodeGeneratorProtocolWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.PublicConstructors, typeof (CIPdf417BarcodeGeneratorProtocolWrapper))]
		static CIPdf417BarcodeGeneratorProtocolWrapper ()
		{
			GC.KeepAlive (null);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public NSData Message {
			[Export ("message", ArgumentSemantic.Retain)]
			get {
				NSData ret;
				ret =  Runtime.GetNSObject<NSData> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("message")), false)!;
				return ret;
			}
			[Export ("setMessage:", ArgumentSemantic.Retain)]
			set {
				var value__handle__ = value!.GetNonNullHandle (nameof (value));
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("setMessage:"), value__handle__);
				GC.KeepAlive (value);
			}
		}
		/// <summary>Gets or sets the minimum width of the data area, in pixels.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public float MinWidth {
			[Export ("minWidth")]
			get {
				float ret;
				ret = global::ObjCRuntime.Messaging.float_objc_msgSend (this.Handle, Selector.GetHandle ("minWidth"));
				return ret;
			}
			[Export ("setMinWidth:")]
			set {
				global::ObjCRuntime.Messaging.void_objc_msgSend_float (this.Handle, Selector.GetHandle ("setMinWidth:"), value);
			}
		}
		/// <summary>Gets or sets the maximum width of the data area, in pixels.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public float MaxWidth {
			[Export ("maxWidth")]
			get {
				float ret;
				ret = global::ObjCRuntime.Messaging.float_objc_msgSend (this.Handle, Selector.GetHandle ("maxWidth"));
				return ret;
			}
			[Export ("setMaxWidth:")]
			set {
				global::ObjCRuntime.Messaging.void_objc_msgSend_float (this.Handle, Selector.GetHandle ("setMaxWidth:"), value);
			}
		}
		/// <summary>Gets or sets the minimum height of the data area, in pixels.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public float MinHeight {
			[Export ("minHeight")]
			get {
				float ret;
				ret = global::ObjCRuntime.Messaging.float_objc_msgSend (this.Handle, Selector.GetHandle ("minHeight"));
				return ret;
			}
			[Export ("setMinHeight:")]
			set {
				global::ObjCRuntime.Messaging.void_objc_msgSend_float (this.Handle, Selector.GetHandle ("setMinHeight:"), value);
			}
		}
		/// <summary>Gets or sets the maximum height of the data area, in pixels.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public float MaxHeight {
			[Export ("maxHeight")]
			get {
				float ret;
				ret = global::ObjCRuntime.Messaging.float_objc_msgSend (this.Handle, Selector.GetHandle ("maxHeight"));
				return ret;
			}
			[Export ("setMaxHeight:")]
			set {
				global::ObjCRuntime.Messaging.void_objc_msgSend_float (this.Handle, Selector.GetHandle ("setMaxHeight:"), value);
			}
		}
		/// <summary>Gets or sets an integer value in the range [0,8] that controls how much error correction data to include in the code.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public float InputDataColumns {
			[Export ("dataColumns")]
			get {
				float ret;
				ret = global::ObjCRuntime.Messaging.float_objc_msgSend (this.Handle, Selector.GetHandle ("dataColumns"));
				return ret;
			}
			[Export ("setDataColumns:")]
			set {
				global::ObjCRuntime.Messaging.void_objc_msgSend_float (this.Handle, Selector.GetHandle ("setDataColumns:"), value);
			}
		}
		/// <summary>Gets or sets the number of rows in the code. <c>0</c> causes the number of rows to be chosen based on the barcode extents.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public float InputRows {
			[Export ("rows")]
			get {
				float ret;
				ret = global::ObjCRuntime.Messaging.float_objc_msgSend (this.Handle, Selector.GetHandle ("rows"));
				return ret;
			}
			[Export ("setRows:")]
			set {
				global::ObjCRuntime.Messaging.void_objc_msgSend_float (this.Handle, Selector.GetHandle ("setRows:"), value);
			}
		}
		/// <summary>Gets or sets the preferred aspect ratio of the generated code.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public float PreferredAspectRatio {
			[Export ("preferredAspectRatio")]
			get {
				float ret;
				ret = global::ObjCRuntime.Messaging.float_objc_msgSend (this.Handle, Selector.GetHandle ("preferredAspectRatio"));
				return ret;
			}
			[Export ("setPreferredAspectRatio:")]
			set {
				global::ObjCRuntime.Messaging.void_objc_msgSend_float (this.Handle, Selector.GetHandle ("setPreferredAspectRatio:"), value);
			}
		}
		/// <summary>Gets or sets a value that controls how the data are compressed in the resulting code.</summary><remarks><c>0</c> indicates that the compression mode should be determined by the data type. <c>1</c> indicates that the data represent ASCII digits. <c>2</c> indicates that the data is ASCII text, numbers, and punctuation. <c>3</c> indicates that the data are in an unspecified format; The least compact compression scheme will be used.
		/// </remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public float InputCompactionMode {
			[Export ("compactionMode")]
			get {
				float ret;
				ret = global::ObjCRuntime.Messaging.float_objc_msgSend (this.Handle, Selector.GetHandle ("compactionMode"));
				return ret;
			}
			[Export ("setCompactionMode:")]
			set {
				global::ObjCRuntime.Messaging.void_objc_msgSend_float (this.Handle, Selector.GetHandle ("setCompactionMode:"), value);
			}
		}
		/// <summary>Gets or sets an integer with Boolean semantics that controls whether redundant elements should be omitted to save space. <c>1</c> is true. <c>0</c> is false.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public float InputCompactStyle {
			[Export ("compactStyle")]
			get {
				float ret;
				ret = global::ObjCRuntime.Messaging.float_objc_msgSend (this.Handle, Selector.GetHandle ("compactStyle"));
				return ret;
			}
			[Export ("setCompactStyle:")]
			set {
				global::ObjCRuntime.Messaging.void_objc_msgSend_float (this.Handle, Selector.GetHandle ("setCompactStyle:"), value);
			}
		}
		/// <summary>Gets or sets an integer value in the range [0,8] that controls how much error correction data to include in the code.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public float InputCorrectionLevel {
			[Export ("correctionLevel")]
			get {
				float ret;
				ret = global::ObjCRuntime.Messaging.float_objc_msgSend (this.Handle, Selector.GetHandle ("correctionLevel"));
				return ret;
			}
			[Export ("setCorrectionLevel:")]
			set {
				global::ObjCRuntime.Messaging.void_objc_msgSend_float (this.Handle, Selector.GetHandle ("setCorrectionLevel:"), value);
			}
		}
		/// <summary>If <see langword="true" />, the barcode will contain compaction information, even if that information is redundant.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public float InputAlwaysSpecifyCompaction {
			[Export ("alwaysSpecifyCompaction")]
			get {
				float ret;
				ret = global::ObjCRuntime.Messaging.float_objc_msgSend (this.Handle, Selector.GetHandle ("alwaysSpecifyCompaction"));
				return ret;
			}
			[Export ("setAlwaysSpecifyCompaction:")]
			set {
				global::ObjCRuntime.Messaging.void_objc_msgSend_float (this.Handle, Selector.GetHandle ("setAlwaysSpecifyCompaction:"), value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		public CIImage? OutputImage {
			[Export ("outputImage")]
			[SupportedOSPlatform ("ios13.0")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos13.0")]
			[SupportedOSPlatform ("maccatalyst")]
			get {
				CIImage ret;
				ret =  Runtime.GetNSObject<CIImage> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("outputImage")), false)!;
				return ret;
			}
		}
	}
}
