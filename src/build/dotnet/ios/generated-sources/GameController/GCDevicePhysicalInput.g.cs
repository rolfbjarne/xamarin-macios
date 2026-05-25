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
namespace GameController {
	#pragma warning disable CS1573
	/// <summary>This interface represents the Objective-C protocol <c>GCDevicePhysicalInput</c>.</summary>
	/// <remarks>
	///   <para>A class that implements this interface (and subclasses <see cref="NSObject" />) will be exported to Objective-C as implementing the Objective-C protocol this interface represents.</para>
	///   <para>A class may also implement members from this interface to implement members from the protocol.</para>
	/// </remarks>
	[SupportedOSPlatform ("macos13.0")]
	[SupportedOSPlatform ("ios16.0")]
	[SupportedOSPlatform ("maccatalyst16.0")]
	[SupportedOSPlatform ("tvos16.0")]
	[Protocol (Name = "GCDevicePhysicalInput", WrapperType = typeof (GCDevicePhysicalInputWrapper))]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "Device", Selector = "device", PropertyType = typeof (GameController.IGCDevice), GetterSelector = "device", ArgumentSemantic = ArgumentSemantic.Weak)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "ElementValueDidChangeHandler", Selector = "elementValueDidChangeHandler", PropertyType = typeof (GameController.ElementValueDidChangeHandler), GetterSelector = "elementValueDidChangeHandler", SetterSelector = "setElementValueDidChangeHandler:", ArgumentSemantic = ArgumentSemantic.Copy, ParameterBlockProxy = new Type [] { typeof (ObjCRuntime.Trampolines.NIDElementValueDidChangeHandler) }, ReturnTypeDelegateProxy = typeof (ObjCRuntime.Trampolines.SDElementValueDidChangeHandler))]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "Capture", Selector = "capture", PropertyType = typeof (GameController.IGCDevicePhysicalInputState), GetterSelector = "capture", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "InputStateAvailableHandler", Selector = "inputStateAvailableHandler", PropertyType = typeof (GameController.InputStateAvailableHandler), GetterSelector = "inputStateAvailableHandler", SetterSelector = "setInputStateAvailableHandler:", ArgumentSemantic = ArgumentSemantic.Copy, ParameterBlockProxy = new Type [] { typeof (ObjCRuntime.Trampolines.NIDInputStateAvailableHandler) }, ReturnTypeDelegateProxy = typeof (ObjCRuntime.Trampolines.SDInputStateAvailableHandler))]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "InputStateQueueDepth", Selector = "inputStateQueueDepth", PropertyType = typeof (IntPtr), GetterSelector = "inputStateQueueDepth", SetterSelector = "setInputStateQueueDepth:", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "NextInputState", Selector = "nextInputState", PropertyType = typeof (NSObject), GetterSelector = "nextInputState", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "Queue", Selector = "queue", PropertyType = typeof (DispatchQueue), GetterSelector = "queue", SetterSelector = "setQueue:", ArgumentSemantic = ArgumentSemantic.Retain)]
	public partial interface IGCDevicePhysicalInput : INativeObject, IDisposable, 
		GameController.IGCDevicePhysicalInputState
	{
		[DynamicDependencyAttribute ("Capture")]
		[DynamicDependencyAttribute ("Device")]
		[DynamicDependencyAttribute ("ElementValueDidChangeHandler")]
		[DynamicDependencyAttribute ("InputStateAvailableHandler")]
		[DynamicDependencyAttribute ("InputStateQueueDepth")]
		[DynamicDependencyAttribute ("NextInputState")]
		[DynamicDependencyAttribute ("Queue")]
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.Interfaces | DynamicallyAccessedMemberTypes.PublicConstructors, typeof (GCDevicePhysicalInputWrapper))]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static IGCDevicePhysicalInput ()
		{
			GC.KeepAlive (null);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual IGCDevice? Device {
			[Export ("device", ArgumentSemantic.Weak)]
			get {
				return _GetDevice (this);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static IGCDevice _GetDevice (IGCDevicePhysicalInput This)
		{
			IGCDevice ret;
			ret =  Runtime.GetINativeObject<IGCDevice> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("device")), false)!;
			GC.KeepAlive (This);
			return ret;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public unsafe virtual ElementValueDidChangeHandler? ElementValueDidChangeHandler {
			[return: DelegateProxy (typeof (ObjCRuntime.Trampolines.SDElementValueDidChangeHandler))]
			[Export ("elementValueDidChangeHandler", ArgumentSemantic.Copy)]
			get {
				return _GetElementValueDidChangeHandler (this);
			}
			[param: BlockProxy (typeof (ObjCRuntime.Trampolines.NIDElementValueDidChangeHandler))]
			[Export ("setElementValueDidChangeHandler:", ArgumentSemantic.Copy)]
			set {
				_SetElementValueDidChangeHandler (this, value);
			}
		}
		[return: DelegateProxy (typeof (ObjCRuntime.Trampolines.SDElementValueDidChangeHandler))]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal unsafe static ElementValueDidChangeHandler _GetElementValueDidChangeHandler (IGCDevicePhysicalInput This)
		{
			NativeHandle ret;
			ret = global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("elementValueDidChangeHandler"));
			GC.KeepAlive (This);
			return global::ObjCRuntime.Trampolines.NIDElementValueDidChangeHandler.Create (ret)!;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal unsafe static void _SetElementValueDidChangeHandler (IGCDevicePhysicalInput This, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDElementValueDidChangeHandler))]ElementValueDidChangeHandler? value)
		{
			using var block_value = Trampolines.SDElementValueDidChangeHandler.CreateNullableBlock (value);
			BlockLiteral *block_ptr_value = null;
			if (value is not null)
				block_ptr_value = &block_value;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("setElementValueDidChangeHandler:"), (IntPtr) block_ptr_value);
			GC.KeepAlive (This);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual IGCDevicePhysicalInputState Capture {
			[Export ("capture")]
			get {
				return _GetCapture (this);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static IGCDevicePhysicalInputState _GetCapture (IGCDevicePhysicalInput This)
		{
			IGCDevicePhysicalInputState ret;
			ret =  Runtime.GetINativeObject<IGCDevicePhysicalInputState> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("capture")), false)!;
			GC.KeepAlive (This);
			return ret;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public unsafe virtual InputStateAvailableHandler? InputStateAvailableHandler {
			[return: DelegateProxy (typeof (ObjCRuntime.Trampolines.SDInputStateAvailableHandler))]
			[Export ("inputStateAvailableHandler", ArgumentSemantic.Copy)]
			get {
				return _GetInputStateAvailableHandler (this);
			}
			[param: BlockProxy (typeof (ObjCRuntime.Trampolines.NIDInputStateAvailableHandler))]
			[Export ("setInputStateAvailableHandler:", ArgumentSemantic.Copy)]
			set {
				_SetInputStateAvailableHandler (this, value);
			}
		}
		[return: DelegateProxy (typeof (ObjCRuntime.Trampolines.SDInputStateAvailableHandler))]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal unsafe static InputStateAvailableHandler _GetInputStateAvailableHandler (IGCDevicePhysicalInput This)
		{
			NativeHandle ret;
			ret = global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("inputStateAvailableHandler"));
			GC.KeepAlive (This);
			return global::ObjCRuntime.Trampolines.NIDInputStateAvailableHandler.Create (ret)!;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal unsafe static void _SetInputStateAvailableHandler (IGCDevicePhysicalInput This, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDInputStateAvailableHandler))]InputStateAvailableHandler? value)
		{
			using var block_value = Trampolines.SDInputStateAvailableHandler.CreateNullableBlock (value);
			BlockLiteral *block_ptr_value = null;
			if (value is not null)
				block_ptr_value = &block_value;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("setInputStateAvailableHandler:"), (IntPtr) block_ptr_value);
			GC.KeepAlive (This);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual nint InputStateQueueDepth {
			[Export ("inputStateQueueDepth")]
			get {
				return _GetInputStateQueueDepth (this);
			}
			[Export ("setInputStateQueueDepth:")]
			set {
				_SetInputStateQueueDepth (this, value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static nint _GetInputStateQueueDepth (IGCDevicePhysicalInput This)
		{
			nint ret;
			ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (This.Handle, Selector.GetHandle ("inputStateQueueDepth"));
			GC.KeepAlive (This);
			return ret;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SetInputStateQueueDepth (IGCDevicePhysicalInput This, nint value)
		{
			global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("setInputStateQueueDepth:"), value);
			GC.KeepAlive (This);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual NSObject? NextInputState {
			[Export ("nextInputState")]
			get {
				return _GetNextInputState (this);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static NSObject _GetNextInputState (IGCDevicePhysicalInput This)
		{
			NSObject ret;
			ret = Runtime.GetNSObject (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("nextInputState")), false)!;
			GC.KeepAlive (This);
			return ret;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("tvos17.0")]
		[SupportedOSPlatform ("macos14.0")]
		[SupportedOSPlatform ("ios17.0")]
		[SupportedOSPlatform ("maccatalyst17.0")]
		[global::Foundation.RequiredMember]
		public virtual global::CoreFoundation.DispatchQueue? Queue {
			[Export ("queue", ArgumentSemantic.Retain)]
			get {
				return _GetQueue (this);
			}
			[Export ("setQueue:", ArgumentSemantic.Retain)]
			set {
				_SetQueue (this, value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static global::CoreFoundation.DispatchQueue _GetQueue (IGCDevicePhysicalInput This)
		{
			global::CoreFoundation.DispatchQueue ret;
			ret = Runtime.GetINativeObject<global::CoreFoundation.DispatchQueue> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("queue")), false)!;
			GC.KeepAlive (This);
			return ret;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SetQueue (IGCDevicePhysicalInput This, global::CoreFoundation.DispatchQueue? value)
		{
			var value__handle__ = value.GetHandle ();
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("setQueue:"), value__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (value);
		}
	}
	#pragma warning restore CS1573
	internal unsafe sealed class GCDevicePhysicalInputWrapper : BaseWrapper, IGCDevicePhysicalInput {
		public GCDevicePhysicalInputWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.PublicConstructors, typeof (GCDevicePhysicalInputWrapper))]
		static GCDevicePhysicalInputWrapper ()
		{
			GC.KeepAlive (null);
		}
		[Export ("objectForKeyedSubscript:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public IGCPhysicalInputElement? GetObject (string key)
		{
			if (key is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (key));
			var nskey = CFString.CreateNative (key);
			IGCPhysicalInputElement? ret;
			ret =  Runtime.GetINativeObject<IGCPhysicalInputElement> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("objectForKeyedSubscript:"), nskey), false)!;
			CFString.ReleaseNative (nskey);
			return ret!;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe ElementValueDidChangeHandler? ElementValueDidChangeHandler {
			[return: DelegateProxy (typeof (ObjCRuntime.Trampolines.SDElementValueDidChangeHandler))]
			[Export ("elementValueDidChangeHandler", ArgumentSemantic.Copy)]
			get {
				NativeHandle ret;
				ret = global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("elementValueDidChangeHandler"));
				return global::ObjCRuntime.Trampolines.NIDElementValueDidChangeHandler.Create (ret)!;
			}
			[param: BlockProxy (typeof (ObjCRuntime.Trampolines.NIDElementValueDidChangeHandler))]
			[Export ("setElementValueDidChangeHandler:", ArgumentSemantic.Copy)]
			set {
				using var block_value = Trampolines.SDElementValueDidChangeHandler.CreateNullableBlock (value);
				BlockLiteral *block_ptr_value = null;
				if (value is not null)
					block_ptr_value = &block_value;
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("setElementValueDidChangeHandler:"), (IntPtr) block_ptr_value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public IGCDevicePhysicalInputState Capture {
			[Export ("capture")]
			get {
				IGCDevicePhysicalInputState ret;
				ret =  Runtime.GetINativeObject<IGCDevicePhysicalInputState> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("capture")), false)!;
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe InputStateAvailableHandler? InputStateAvailableHandler {
			[return: DelegateProxy (typeof (ObjCRuntime.Trampolines.SDInputStateAvailableHandler))]
			[Export ("inputStateAvailableHandler", ArgumentSemantic.Copy)]
			get {
				NativeHandle ret;
				ret = global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("inputStateAvailableHandler"));
				return global::ObjCRuntime.Trampolines.NIDInputStateAvailableHandler.Create (ret)!;
			}
			[param: BlockProxy (typeof (ObjCRuntime.Trampolines.NIDInputStateAvailableHandler))]
			[Export ("setInputStateAvailableHandler:", ArgumentSemantic.Copy)]
			set {
				using var block_value = Trampolines.SDInputStateAvailableHandler.CreateNullableBlock (value);
				BlockLiteral *block_ptr_value = null;
				if (value is not null)
					block_ptr_value = &block_value;
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("setInputStateAvailableHandler:"), (IntPtr) block_ptr_value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public nint InputStateQueueDepth {
			[Export ("inputStateQueueDepth")]
			get {
				nint ret;
				ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("inputStateQueueDepth"));
				return ret;
			}
			[Export ("setInputStateQueueDepth:")]
			set {
				global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setInputStateQueueDepth:"), value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public NSObject? NextInputState {
			[Export ("nextInputState")]
			get {
				NSObject ret;
				ret = Runtime.GetNSObject (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("nextInputState")), false)!;
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("tvos17.0")]
		[SupportedOSPlatform ("macos14.0")]
		[SupportedOSPlatform ("ios17.0")]
		[SupportedOSPlatform ("maccatalyst17.0")]
		public global::CoreFoundation.DispatchQueue? Queue {
			[Export ("queue", ArgumentSemantic.Retain)]
			get {
				global::CoreFoundation.DispatchQueue ret;
				ret = Runtime.GetINativeObject<global::CoreFoundation.DispatchQueue> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("queue")), false)!;
				return ret;
			}
			[Export ("setQueue:", ArgumentSemantic.Retain)]
			set {
				var value__handle__ = value.GetHandle ();
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("setQueue:"), value__handle__);
				GC.KeepAlive (value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("ios16.0")]
		[SupportedOSPlatform ("macos13.0")]
		[SupportedOSPlatform ("tvos16.0")]
		[SupportedOSPlatform ("maccatalyst16.0")]
		public IGCDevice? Device {
			[Export ("device", ArgumentSemantic.Weak)]
			[SupportedOSPlatform ("ios16.0")]
			[SupportedOSPlatform ("macos13.0")]
			[SupportedOSPlatform ("tvos16.0")]
			[SupportedOSPlatform ("maccatalyst16.0")]
			get {
				IGCDevice ret;
				ret =  Runtime.GetINativeObject<IGCDevice> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("device")), false)!;
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("ios16.0")]
		[SupportedOSPlatform ("macos13.0")]
		[SupportedOSPlatform ("tvos16.0")]
		[SupportedOSPlatform ("maccatalyst16.0")]
		public double LastEventTimestamp {
			[Export ("lastEventTimestamp")]
			[SupportedOSPlatform ("ios16.0")]
			[SupportedOSPlatform ("macos13.0")]
			[SupportedOSPlatform ("tvos16.0")]
			[SupportedOSPlatform ("maccatalyst16.0")]
			get {
				double ret;
				ret = global::ObjCRuntime.Messaging.Double_objc_msgSend (this.Handle, Selector.GetHandle ("lastEventTimestamp"));
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("ios16.0")]
		[SupportedOSPlatform ("macos13.0")]
		[SupportedOSPlatform ("tvos16.0")]
		[SupportedOSPlatform ("maccatalyst16.0")]
		public double LastEventLatency {
			[Export ("lastEventLatency")]
			[SupportedOSPlatform ("ios16.0")]
			[SupportedOSPlatform ("macos13.0")]
			[SupportedOSPlatform ("tvos16.0")]
			[SupportedOSPlatform ("maccatalyst16.0")]
			get {
				double ret;
				ret = global::ObjCRuntime.Messaging.Double_objc_msgSend (this.Handle, Selector.GetHandle ("lastEventLatency"));
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("ios16.0")]
		[SupportedOSPlatform ("macos13.0")]
		[SupportedOSPlatform ("tvos16.0")]
		[SupportedOSPlatform ("maccatalyst16.0")]
		public GCPhysicalInputElementCollection<NSString, IGCPhysicalInputElement> Elements {
			[Export ("elements")]
			[SupportedOSPlatform ("ios16.0")]
			[SupportedOSPlatform ("macos13.0")]
			[SupportedOSPlatform ("tvos16.0")]
			[SupportedOSPlatform ("maccatalyst16.0")]
			get {
				GCPhysicalInputElementCollection<NSString, IGCPhysicalInputElement> ret;
				ret =  Runtime.GetNSObject<GCPhysicalInputElementCollection<NSString, IGCPhysicalInputElement>> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("elements")), false)!;
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("ios16.0")]
		[SupportedOSPlatform ("macos13.0")]
		[SupportedOSPlatform ("tvos16.0")]
		[SupportedOSPlatform ("maccatalyst16.0")]
		public GCPhysicalInputElementCollection<NSString, IGCButtonElement> Buttons {
			[Export ("buttons")]
			[SupportedOSPlatform ("ios16.0")]
			[SupportedOSPlatform ("macos13.0")]
			[SupportedOSPlatform ("tvos16.0")]
			[SupportedOSPlatform ("maccatalyst16.0")]
			get {
				GCPhysicalInputElementCollection<NSString, IGCButtonElement> ret;
				ret =  Runtime.GetNSObject<GCPhysicalInputElementCollection<NSString, IGCButtonElement>> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("buttons")), false)!;
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("ios16.0")]
		[SupportedOSPlatform ("macos13.0")]
		[SupportedOSPlatform ("tvos16.0")]
		[SupportedOSPlatform ("maccatalyst16.0")]
		public GCPhysicalInputElementCollection<NSString, IGCAxisElement> Axes {
			[Export ("axes")]
			[SupportedOSPlatform ("ios16.0")]
			[SupportedOSPlatform ("macos13.0")]
			[SupportedOSPlatform ("tvos16.0")]
			[SupportedOSPlatform ("maccatalyst16.0")]
			get {
				GCPhysicalInputElementCollection<NSString, IGCAxisElement> ret;
				ret =  Runtime.GetNSObject<GCPhysicalInputElementCollection<NSString, IGCAxisElement>> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("axes")), false)!;
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("ios16.0")]
		[SupportedOSPlatform ("macos13.0")]
		[SupportedOSPlatform ("tvos16.0")]
		[SupportedOSPlatform ("maccatalyst16.0")]
		public GCPhysicalInputElementCollection<NSString, IGCSwitchElement> Switches {
			[Export ("switches")]
			[SupportedOSPlatform ("ios16.0")]
			[SupportedOSPlatform ("macos13.0")]
			[SupportedOSPlatform ("tvos16.0")]
			[SupportedOSPlatform ("maccatalyst16.0")]
			get {
				GCPhysicalInputElementCollection<NSString, IGCSwitchElement> ret;
				ret =  Runtime.GetNSObject<GCPhysicalInputElementCollection<NSString, IGCSwitchElement>> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("switches")), false)!;
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("ios16.0")]
		[SupportedOSPlatform ("macos13.0")]
		[SupportedOSPlatform ("tvos16.0")]
		[SupportedOSPlatform ("maccatalyst16.0")]
		public GCPhysicalInputElementCollection<NSString, IGCDirectionPadElement> Dpads {
			[Export ("dpads")]
			[SupportedOSPlatform ("ios16.0")]
			[SupportedOSPlatform ("macos13.0")]
			[SupportedOSPlatform ("tvos16.0")]
			[SupportedOSPlatform ("maccatalyst16.0")]
			get {
				GCPhysicalInputElementCollection<NSString, IGCDirectionPadElement> ret;
				ret =  Runtime.GetNSObject<GCPhysicalInputElementCollection<NSString, IGCDirectionPadElement>> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("dpads")), false)!;
				return ret;
			}
		}
	}
}
