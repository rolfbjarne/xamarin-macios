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
namespace MetalPerformanceShadersGraph {
	[SupportedOSPlatform ("tvos15.4")]
	[SupportedOSPlatform ("macos12.3")]
	[SupportedOSPlatform ("ios15.4")]
	[SupportedOSPlatform ("maccatalyst15.4")]
	public unsafe static partial class MPSGraph_MPSGraphRnnOps  {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly NativeHandle class_ptr = Class.GetHandle ("MPSGraph");
		[Export ("GRUWithSourceTensor:recurrentWeight:inputWeight:bias:initState:mask:secondaryBias:descriptor:name:")]
		[SupportedOSPlatform ("tvos16.0")]
		[SupportedOSPlatform ("macos13.0")]
		[SupportedOSPlatform ("ios16.0")]
		[SupportedOSPlatform ("maccatalyst16.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MPSGraphTensor[] Gru (this MPSGraph This, MPSGraphTensor source, MPSGraphTensor recurrentWeight, MPSGraphTensor? inputWeight, MPSGraphTensor? bias, MPSGraphTensor? initState, MPSGraphTensor? mask, MPSGraphTensor? secondaryBias, MPSGraphGruDescriptor descriptor, string? name)
		{
			var source__handle__ = source!.GetNonNullHandle (nameof (source));
			var recurrentWeight__handle__ = recurrentWeight!.GetNonNullHandle (nameof (recurrentWeight));
			var inputWeight__handle__ = inputWeight.GetHandle ();
			var bias__handle__ = bias.GetHandle ();
			var initState__handle__ = initState.GetHandle ();
			var mask__handle__ = mask.GetHandle ();
			var secondaryBias__handle__ = secondaryBias.GetHandle ();
			var descriptor__handle__ = descriptor!.GetNonNullHandle (nameof (descriptor));
			var nsname = CFString.CreateNative (name);
			MPSGraphTensor[]? ret;
			ret = CFArray.ArrayFromHandle<MPSGraphTensor>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle_NativeHandle_NativeHandle_NativeHandle_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("GRUWithSourceTensor:recurrentWeight:inputWeight:bias:initState:mask:secondaryBias:descriptor:name:"), source__handle__, recurrentWeight__handle__, inputWeight__handle__, bias__handle__, initState__handle__, mask__handle__, secondaryBias__handle__, descriptor__handle__, nsname), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (source);
			GC.KeepAlive (recurrentWeight);
			GC.KeepAlive (inputWeight);
			GC.KeepAlive (bias);
			GC.KeepAlive (initState);
			GC.KeepAlive (mask);
			GC.KeepAlive (secondaryBias);
			GC.KeepAlive (descriptor);
			CFString.ReleaseNative (nsname);
			return ret!;
		}
		[Export ("GRUWithSourceTensor:recurrentWeight:inputWeight:bias:initState:descriptor:name:")]
		[SupportedOSPlatform ("tvos16.0")]
		[SupportedOSPlatform ("macos13.0")]
		[SupportedOSPlatform ("ios16.0")]
		[SupportedOSPlatform ("maccatalyst16.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MPSGraphTensor[] Gru (this MPSGraph This, MPSGraphTensor source, MPSGraphTensor recurrentWeight, MPSGraphTensor? inputWeight, MPSGraphTensor? bias, MPSGraphTensor? initState, MPSGraphGruDescriptor descriptor, string? name)
		{
			var source__handle__ = source!.GetNonNullHandle (nameof (source));
			var recurrentWeight__handle__ = recurrentWeight!.GetNonNullHandle (nameof (recurrentWeight));
			var inputWeight__handle__ = inputWeight.GetHandle ();
			var bias__handle__ = bias.GetHandle ();
			var initState__handle__ = initState.GetHandle ();
			var descriptor__handle__ = descriptor!.GetNonNullHandle (nameof (descriptor));
			var nsname = CFString.CreateNative (name);
			MPSGraphTensor[]? ret;
			ret = CFArray.ArrayFromHandle<MPSGraphTensor>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle_NativeHandle_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("GRUWithSourceTensor:recurrentWeight:inputWeight:bias:initState:descriptor:name:"), source__handle__, recurrentWeight__handle__, inputWeight__handle__, bias__handle__, initState__handle__, descriptor__handle__, nsname), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (source);
			GC.KeepAlive (recurrentWeight);
			GC.KeepAlive (inputWeight);
			GC.KeepAlive (bias);
			GC.KeepAlive (initState);
			GC.KeepAlive (descriptor);
			CFString.ReleaseNative (nsname);
			return ret!;
		}
		[Export ("GRUWithSourceTensor:recurrentWeight:inputWeight:bias:descriptor:name:")]
		[SupportedOSPlatform ("tvos16.0")]
		[SupportedOSPlatform ("macos13.0")]
		[SupportedOSPlatform ("ios16.0")]
		[SupportedOSPlatform ("maccatalyst16.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MPSGraphTensor[] Gru (this MPSGraph This, MPSGraphTensor source, MPSGraphTensor recurrentWeight, MPSGraphTensor? inputWeight, MPSGraphTensor? bias, MPSGraphGruDescriptor descriptor, string? name)
		{
			var source__handle__ = source!.GetNonNullHandle (nameof (source));
			var recurrentWeight__handle__ = recurrentWeight!.GetNonNullHandle (nameof (recurrentWeight));
			var inputWeight__handle__ = inputWeight.GetHandle ();
			var bias__handle__ = bias.GetHandle ();
			var descriptor__handle__ = descriptor!.GetNonNullHandle (nameof (descriptor));
			var nsname = CFString.CreateNative (name);
			MPSGraphTensor[]? ret;
			ret = CFArray.ArrayFromHandle<MPSGraphTensor>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("GRUWithSourceTensor:recurrentWeight:inputWeight:bias:descriptor:name:"), source__handle__, recurrentWeight__handle__, inputWeight__handle__, bias__handle__, descriptor__handle__, nsname), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (source);
			GC.KeepAlive (recurrentWeight);
			GC.KeepAlive (inputWeight);
			GC.KeepAlive (bias);
			GC.KeepAlive (descriptor);
			CFString.ReleaseNative (nsname);
			return ret!;
		}
		[Export ("GRUGradientsWithSourceTensor:recurrentWeight:sourceGradient:zState:outputFwd:stateGradient:inputWeight:bias:initState:mask:secondaryBias:descriptor:name:")]
		[SupportedOSPlatform ("tvos16.0")]
		[SupportedOSPlatform ("macos13.0")]
		[SupportedOSPlatform ("ios16.0")]
		[SupportedOSPlatform ("maccatalyst16.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MPSGraphTensor[] GruGradients (this MPSGraph This, MPSGraphTensor source, MPSGraphTensor recurrentWeight, MPSGraphTensor sourceGradient, MPSGraphTensor zState, MPSGraphTensor outputFwd, MPSGraphTensor? stateGradient, MPSGraphTensor? inputWeight, MPSGraphTensor? bias, MPSGraphTensor? initState, MPSGraphTensor? mask, MPSGraphTensor? secondaryBias, MPSGraphGruDescriptor descriptor, string? name)
		{
			var source__handle__ = source!.GetNonNullHandle (nameof (source));
			var recurrentWeight__handle__ = recurrentWeight!.GetNonNullHandle (nameof (recurrentWeight));
			var sourceGradient__handle__ = sourceGradient!.GetNonNullHandle (nameof (sourceGradient));
			var zState__handle__ = zState!.GetNonNullHandle (nameof (zState));
			var outputFwd__handle__ = outputFwd!.GetNonNullHandle (nameof (outputFwd));
			var stateGradient__handle__ = stateGradient.GetHandle ();
			var inputWeight__handle__ = inputWeight.GetHandle ();
			var bias__handle__ = bias.GetHandle ();
			var initState__handle__ = initState.GetHandle ();
			var mask__handle__ = mask.GetHandle ();
			var secondaryBias__handle__ = secondaryBias.GetHandle ();
			var descriptor__handle__ = descriptor!.GetNonNullHandle (nameof (descriptor));
			var nsname = CFString.CreateNative (name);
			MPSGraphTensor[]? ret;
			ret = CFArray.ArrayFromHandle<MPSGraphTensor>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle_NativeHandle_NativeHandle_NativeHandle_NativeHandle_NativeHandle_NativeHandle_NativeHandle_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("GRUGradientsWithSourceTensor:recurrentWeight:sourceGradient:zState:outputFwd:stateGradient:inputWeight:bias:initState:mask:secondaryBias:descriptor:name:"), source__handle__, recurrentWeight__handle__, sourceGradient__handle__, zState__handle__, outputFwd__handle__, stateGradient__handle__, inputWeight__handle__, bias__handle__, initState__handle__, mask__handle__, secondaryBias__handle__, descriptor__handle__, nsname), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (source);
			GC.KeepAlive (recurrentWeight);
			GC.KeepAlive (sourceGradient);
			GC.KeepAlive (zState);
			GC.KeepAlive (outputFwd);
			GC.KeepAlive (stateGradient);
			GC.KeepAlive (inputWeight);
			GC.KeepAlive (bias);
			GC.KeepAlive (initState);
			GC.KeepAlive (mask);
			GC.KeepAlive (secondaryBias);
			GC.KeepAlive (descriptor);
			CFString.ReleaseNative (nsname);
			return ret!;
		}
		[Export ("GRUGradientsWithSourceTensor:recurrentWeight:sourceGradient:zState:outputFwd:inputWeight:bias:initState:descriptor:name:")]
		[SupportedOSPlatform ("tvos16.0")]
		[SupportedOSPlatform ("macos13.0")]
		[SupportedOSPlatform ("ios16.0")]
		[SupportedOSPlatform ("maccatalyst16.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MPSGraphTensor[] GruGradients (this MPSGraph This, MPSGraphTensor source, MPSGraphTensor recurrentWeight, MPSGraphTensor sourceGradient, MPSGraphTensor zState, MPSGraphTensor outputFwd, MPSGraphTensor? inputWeight, MPSGraphTensor? bias, MPSGraphTensor? initState, MPSGraphGruDescriptor descriptor, string? name)
		{
			var source__handle__ = source!.GetNonNullHandle (nameof (source));
			var recurrentWeight__handle__ = recurrentWeight!.GetNonNullHandle (nameof (recurrentWeight));
			var sourceGradient__handle__ = sourceGradient!.GetNonNullHandle (nameof (sourceGradient));
			var zState__handle__ = zState!.GetNonNullHandle (nameof (zState));
			var outputFwd__handle__ = outputFwd!.GetNonNullHandle (nameof (outputFwd));
			var inputWeight__handle__ = inputWeight.GetHandle ();
			var bias__handle__ = bias.GetHandle ();
			var initState__handle__ = initState.GetHandle ();
			var descriptor__handle__ = descriptor!.GetNonNullHandle (nameof (descriptor));
			var nsname = CFString.CreateNative (name);
			MPSGraphTensor[]? ret;
			ret = CFArray.ArrayFromHandle<MPSGraphTensor>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle_NativeHandle_NativeHandle_NativeHandle_NativeHandle_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("GRUGradientsWithSourceTensor:recurrentWeight:sourceGradient:zState:outputFwd:inputWeight:bias:initState:descriptor:name:"), source__handle__, recurrentWeight__handle__, sourceGradient__handle__, zState__handle__, outputFwd__handle__, inputWeight__handle__, bias__handle__, initState__handle__, descriptor__handle__, nsname), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (source);
			GC.KeepAlive (recurrentWeight);
			GC.KeepAlive (sourceGradient);
			GC.KeepAlive (zState);
			GC.KeepAlive (outputFwd);
			GC.KeepAlive (inputWeight);
			GC.KeepAlive (bias);
			GC.KeepAlive (initState);
			GC.KeepAlive (descriptor);
			CFString.ReleaseNative (nsname);
			return ret!;
		}
		[Export ("GRUGradientsWithSourceTensor:recurrentWeight:sourceGradient:zState:outputFwd:inputWeight:bias:descriptor:name:")]
		[SupportedOSPlatform ("tvos16.0")]
		[SupportedOSPlatform ("macos13.0")]
		[SupportedOSPlatform ("ios16.0")]
		[SupportedOSPlatform ("maccatalyst16.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MPSGraphTensor[] GruGradients (this MPSGraph This, MPSGraphTensor source, MPSGraphTensor recurrentWeight, MPSGraphTensor sourceGradient, MPSGraphTensor zState, MPSGraphTensor outputFwd, MPSGraphTensor? inputWeight, MPSGraphTensor? bias, MPSGraphGruDescriptor descriptor, string? name)
		{
			var source__handle__ = source!.GetNonNullHandle (nameof (source));
			var recurrentWeight__handle__ = recurrentWeight!.GetNonNullHandle (nameof (recurrentWeight));
			var sourceGradient__handle__ = sourceGradient!.GetNonNullHandle (nameof (sourceGradient));
			var zState__handle__ = zState!.GetNonNullHandle (nameof (zState));
			var outputFwd__handle__ = outputFwd!.GetNonNullHandle (nameof (outputFwd));
			var inputWeight__handle__ = inputWeight.GetHandle ();
			var bias__handle__ = bias.GetHandle ();
			var descriptor__handle__ = descriptor!.GetNonNullHandle (nameof (descriptor));
			var nsname = CFString.CreateNative (name);
			MPSGraphTensor[]? ret;
			ret = CFArray.ArrayFromHandle<MPSGraphTensor>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle_NativeHandle_NativeHandle_NativeHandle_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("GRUGradientsWithSourceTensor:recurrentWeight:sourceGradient:zState:outputFwd:inputWeight:bias:descriptor:name:"), source__handle__, recurrentWeight__handle__, sourceGradient__handle__, zState__handle__, outputFwd__handle__, inputWeight__handle__, bias__handle__, descriptor__handle__, nsname), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (source);
			GC.KeepAlive (recurrentWeight);
			GC.KeepAlive (sourceGradient);
			GC.KeepAlive (zState);
			GC.KeepAlive (outputFwd);
			GC.KeepAlive (inputWeight);
			GC.KeepAlive (bias);
			GC.KeepAlive (descriptor);
			CFString.ReleaseNative (nsname);
			return ret!;
		}
		[Export ("LSTMWithSourceTensor:recurrentWeight:inputWeight:bias:initState:initCell:mask:peephole:descriptor:name:")]
		[SupportedOSPlatform ("tvos15.4")]
		[SupportedOSPlatform ("macos12.3")]
		[SupportedOSPlatform ("ios15.4")]
		[SupportedOSPlatform ("maccatalyst15.4")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MPSGraphTensor[] Lstm (this MPSGraph This, MPSGraphTensor source, MPSGraphTensor recurrentWeight, MPSGraphTensor? inputWeight, MPSGraphTensor? bias, MPSGraphTensor? initState, MPSGraphTensor? initCell, MPSGraphTensor? mask, MPSGraphTensor? peephole, MPSGraphLstmDescriptor descriptor, string? name)
		{
			var source__handle__ = source!.GetNonNullHandle (nameof (source));
			var recurrentWeight__handle__ = recurrentWeight!.GetNonNullHandle (nameof (recurrentWeight));
			var inputWeight__handle__ = inputWeight.GetHandle ();
			var bias__handle__ = bias.GetHandle ();
			var initState__handle__ = initState.GetHandle ();
			var initCell__handle__ = initCell.GetHandle ();
			var mask__handle__ = mask.GetHandle ();
			var peephole__handle__ = peephole.GetHandle ();
			var descriptor__handle__ = descriptor!.GetNonNullHandle (nameof (descriptor));
			var nsname = CFString.CreateNative (name);
			MPSGraphTensor[]? ret;
			ret = CFArray.ArrayFromHandle<MPSGraphTensor>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle_NativeHandle_NativeHandle_NativeHandle_NativeHandle_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("LSTMWithSourceTensor:recurrentWeight:inputWeight:bias:initState:initCell:mask:peephole:descriptor:name:"), source__handle__, recurrentWeight__handle__, inputWeight__handle__, bias__handle__, initState__handle__, initCell__handle__, mask__handle__, peephole__handle__, descriptor__handle__, nsname), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (source);
			GC.KeepAlive (recurrentWeight);
			GC.KeepAlive (inputWeight);
			GC.KeepAlive (bias);
			GC.KeepAlive (initState);
			GC.KeepAlive (initCell);
			GC.KeepAlive (mask);
			GC.KeepAlive (peephole);
			GC.KeepAlive (descriptor);
			CFString.ReleaseNative (nsname);
			return ret!;
		}
		[Export ("LSTMWithSourceTensor:recurrentWeight:inputWeight:bias:initState:initCell:descriptor:name:")]
		[SupportedOSPlatform ("tvos15.4")]
		[SupportedOSPlatform ("macos12.3")]
		[SupportedOSPlatform ("ios15.4")]
		[SupportedOSPlatform ("maccatalyst15.4")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MPSGraphTensor[] Lstm (this MPSGraph This, MPSGraphTensor source, MPSGraphTensor recurrentWeight, MPSGraphTensor? inputWeight, MPSGraphTensor? bias, MPSGraphTensor? initState, MPSGraphTensor? initCell, MPSGraphLstmDescriptor descriptor, string? name)
		{
			var source__handle__ = source!.GetNonNullHandle (nameof (source));
			var recurrentWeight__handle__ = recurrentWeight!.GetNonNullHandle (nameof (recurrentWeight));
			var inputWeight__handle__ = inputWeight.GetHandle ();
			var bias__handle__ = bias.GetHandle ();
			var initState__handle__ = initState.GetHandle ();
			var initCell__handle__ = initCell.GetHandle ();
			var descriptor__handle__ = descriptor!.GetNonNullHandle (nameof (descriptor));
			var nsname = CFString.CreateNative (name);
			MPSGraphTensor[]? ret;
			ret = CFArray.ArrayFromHandle<MPSGraphTensor>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle_NativeHandle_NativeHandle_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("LSTMWithSourceTensor:recurrentWeight:inputWeight:bias:initState:initCell:descriptor:name:"), source__handle__, recurrentWeight__handle__, inputWeight__handle__, bias__handle__, initState__handle__, initCell__handle__, descriptor__handle__, nsname), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (source);
			GC.KeepAlive (recurrentWeight);
			GC.KeepAlive (inputWeight);
			GC.KeepAlive (bias);
			GC.KeepAlive (initState);
			GC.KeepAlive (initCell);
			GC.KeepAlive (descriptor);
			CFString.ReleaseNative (nsname);
			return ret!;
		}
		[Export ("LSTMWithSourceTensor:recurrentWeight:initState:initCell:descriptor:name:")]
		[SupportedOSPlatform ("tvos15.4")]
		[SupportedOSPlatform ("macos12.3")]
		[SupportedOSPlatform ("ios15.4")]
		[SupportedOSPlatform ("maccatalyst15.4")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MPSGraphTensor[] Lstm (this MPSGraph This, MPSGraphTensor source, MPSGraphTensor recurrentWeight, MPSGraphTensor? initState, MPSGraphTensor? initCell, MPSGraphLstmDescriptor descriptor, string? name)
		{
			var source__handle__ = source!.GetNonNullHandle (nameof (source));
			var recurrentWeight__handle__ = recurrentWeight!.GetNonNullHandle (nameof (recurrentWeight));
			var initState__handle__ = initState.GetHandle ();
			var initCell__handle__ = initCell.GetHandle ();
			var descriptor__handle__ = descriptor!.GetNonNullHandle (nameof (descriptor));
			var nsname = CFString.CreateNative (name);
			MPSGraphTensor[]? ret;
			ret = CFArray.ArrayFromHandle<MPSGraphTensor>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("LSTMWithSourceTensor:recurrentWeight:initState:initCell:descriptor:name:"), source__handle__, recurrentWeight__handle__, initState__handle__, initCell__handle__, descriptor__handle__, nsname), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (source);
			GC.KeepAlive (recurrentWeight);
			GC.KeepAlive (initState);
			GC.KeepAlive (initCell);
			GC.KeepAlive (descriptor);
			CFString.ReleaseNative (nsname);
			return ret!;
		}
		[Export ("LSTMGradientsWithSourceTensor:recurrentWeight:sourceGradient:zState:cellOutputFwd:stateGradient:cellGradient:inputWeight:bias:initState:initCell:mask:peephole:descriptor:name:")]
		[SupportedOSPlatform ("tvos15.4")]
		[SupportedOSPlatform ("macos12.3")]
		[SupportedOSPlatform ("ios15.4")]
		[SupportedOSPlatform ("maccatalyst15.4")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MPSGraphTensor[] LstmGradients (this MPSGraph This, MPSGraphTensor source, MPSGraphTensor recurrentWeight, MPSGraphTensor sourceGradient, MPSGraphTensor zState, MPSGraphTensor cellOutputFwd, MPSGraphTensor? stateGradient, MPSGraphTensor? cellGradient, MPSGraphTensor? inputWeight, MPSGraphTensor? bias, MPSGraphTensor? initState, MPSGraphTensor? initCell, MPSGraphTensor? mask, MPSGraphTensor? peephole, MPSGraphLstmDescriptor descriptor, string? name)
		{
			var source__handle__ = source!.GetNonNullHandle (nameof (source));
			var recurrentWeight__handle__ = recurrentWeight!.GetNonNullHandle (nameof (recurrentWeight));
			var sourceGradient__handle__ = sourceGradient!.GetNonNullHandle (nameof (sourceGradient));
			var zState__handle__ = zState!.GetNonNullHandle (nameof (zState));
			var cellOutputFwd__handle__ = cellOutputFwd!.GetNonNullHandle (nameof (cellOutputFwd));
			var stateGradient__handle__ = stateGradient.GetHandle ();
			var cellGradient__handle__ = cellGradient.GetHandle ();
			var inputWeight__handle__ = inputWeight.GetHandle ();
			var bias__handle__ = bias.GetHandle ();
			var initState__handle__ = initState.GetHandle ();
			var initCell__handle__ = initCell.GetHandle ();
			var mask__handle__ = mask.GetHandle ();
			var peephole__handle__ = peephole.GetHandle ();
			var descriptor__handle__ = descriptor!.GetNonNullHandle (nameof (descriptor));
			var nsname = CFString.CreateNative (name);
			MPSGraphTensor[]? ret;
			ret = CFArray.ArrayFromHandle<MPSGraphTensor>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle_NativeHandle_NativeHandle_NativeHandle_NativeHandle_NativeHandle_NativeHandle_NativeHandle_NativeHandle_NativeHandle_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("LSTMGradientsWithSourceTensor:recurrentWeight:sourceGradient:zState:cellOutputFwd:stateGradient:cellGradient:inputWeight:bias:initState:initCell:mask:peephole:descriptor:name:"), source__handle__, recurrentWeight__handle__, sourceGradient__handle__, zState__handle__, cellOutputFwd__handle__, stateGradient__handle__, cellGradient__handle__, inputWeight__handle__, bias__handle__, initState__handle__, initCell__handle__, mask__handle__, peephole__handle__, descriptor__handle__, nsname), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (source);
			GC.KeepAlive (recurrentWeight);
			GC.KeepAlive (sourceGradient);
			GC.KeepAlive (zState);
			GC.KeepAlive (cellOutputFwd);
			GC.KeepAlive (stateGradient);
			GC.KeepAlive (cellGradient);
			GC.KeepAlive (inputWeight);
			GC.KeepAlive (bias);
			GC.KeepAlive (initState);
			GC.KeepAlive (initCell);
			GC.KeepAlive (mask);
			GC.KeepAlive (peephole);
			GC.KeepAlive (descriptor);
			CFString.ReleaseNative (nsname);
			return ret!;
		}
		[Export ("LSTMGradientsWithSourceTensor:recurrentWeight:sourceGradient:zState:cellOutputFwd:inputWeight:bias:initState:initCell:mask:descriptor:name:")]
		[SupportedOSPlatform ("tvos15.4")]
		[SupportedOSPlatform ("macos12.3")]
		[SupportedOSPlatform ("ios15.4")]
		[SupportedOSPlatform ("maccatalyst15.4")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MPSGraphTensor[] LstmGradients (this MPSGraph This, MPSGraphTensor source, MPSGraphTensor recurrentWeight, MPSGraphTensor sourceGradient, MPSGraphTensor zState, MPSGraphTensor cellOutputFwd, MPSGraphTensor? inputWeight, MPSGraphTensor? bias, MPSGraphTensor? initState, MPSGraphTensor? initCell, MPSGraphTensor? mask, MPSGraphLstmDescriptor descriptor, string? name)
		{
			var source__handle__ = source!.GetNonNullHandle (nameof (source));
			var recurrentWeight__handle__ = recurrentWeight!.GetNonNullHandle (nameof (recurrentWeight));
			var sourceGradient__handle__ = sourceGradient!.GetNonNullHandle (nameof (sourceGradient));
			var zState__handle__ = zState!.GetNonNullHandle (nameof (zState));
			var cellOutputFwd__handle__ = cellOutputFwd!.GetNonNullHandle (nameof (cellOutputFwd));
			var inputWeight__handle__ = inputWeight.GetHandle ();
			var bias__handle__ = bias.GetHandle ();
			var initState__handle__ = initState.GetHandle ();
			var initCell__handle__ = initCell.GetHandle ();
			var mask__handle__ = mask.GetHandle ();
			var descriptor__handle__ = descriptor!.GetNonNullHandle (nameof (descriptor));
			var nsname = CFString.CreateNative (name);
			MPSGraphTensor[]? ret;
			ret = CFArray.ArrayFromHandle<MPSGraphTensor>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle_NativeHandle_NativeHandle_NativeHandle_NativeHandle_NativeHandle_NativeHandle_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("LSTMGradientsWithSourceTensor:recurrentWeight:sourceGradient:zState:cellOutputFwd:inputWeight:bias:initState:initCell:mask:descriptor:name:"), source__handle__, recurrentWeight__handle__, sourceGradient__handle__, zState__handle__, cellOutputFwd__handle__, inputWeight__handle__, bias__handle__, initState__handle__, initCell__handle__, mask__handle__, descriptor__handle__, nsname), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (source);
			GC.KeepAlive (recurrentWeight);
			GC.KeepAlive (sourceGradient);
			GC.KeepAlive (zState);
			GC.KeepAlive (cellOutputFwd);
			GC.KeepAlive (inputWeight);
			GC.KeepAlive (bias);
			GC.KeepAlive (initState);
			GC.KeepAlive (initCell);
			GC.KeepAlive (mask);
			GC.KeepAlive (descriptor);
			CFString.ReleaseNative (nsname);
			return ret!;
		}
		[Export ("LSTMGradientsWithSourceTensor:recurrentWeight:sourceGradient:zState:cellOutputFwd:inputWeight:bias:initState:initCell:descriptor:name:")]
		[SupportedOSPlatform ("tvos15.4")]
		[SupportedOSPlatform ("macos12.3")]
		[SupportedOSPlatform ("ios15.4")]
		[SupportedOSPlatform ("maccatalyst15.4")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MPSGraphTensor[] LstmGradients (this MPSGraph This, MPSGraphTensor source, MPSGraphTensor recurrentWeight, MPSGraphTensor sourceGradient, MPSGraphTensor zState, MPSGraphTensor cellOutputFwd, MPSGraphTensor? inputWeight, MPSGraphTensor? bias, MPSGraphTensor? initState, MPSGraphTensor? initCell, MPSGraphLstmDescriptor descriptor, string? name)
		{
			var source__handle__ = source!.GetNonNullHandle (nameof (source));
			var recurrentWeight__handle__ = recurrentWeight!.GetNonNullHandle (nameof (recurrentWeight));
			var sourceGradient__handle__ = sourceGradient!.GetNonNullHandle (nameof (sourceGradient));
			var zState__handle__ = zState!.GetNonNullHandle (nameof (zState));
			var cellOutputFwd__handle__ = cellOutputFwd!.GetNonNullHandle (nameof (cellOutputFwd));
			var inputWeight__handle__ = inputWeight.GetHandle ();
			var bias__handle__ = bias.GetHandle ();
			var initState__handle__ = initState.GetHandle ();
			var initCell__handle__ = initCell.GetHandle ();
			var descriptor__handle__ = descriptor!.GetNonNullHandle (nameof (descriptor));
			var nsname = CFString.CreateNative (name);
			MPSGraphTensor[]? ret;
			ret = CFArray.ArrayFromHandle<MPSGraphTensor>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle_NativeHandle_NativeHandle_NativeHandle_NativeHandle_NativeHandle_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("LSTMGradientsWithSourceTensor:recurrentWeight:sourceGradient:zState:cellOutputFwd:inputWeight:bias:initState:initCell:descriptor:name:"), source__handle__, recurrentWeight__handle__, sourceGradient__handle__, zState__handle__, cellOutputFwd__handle__, inputWeight__handle__, bias__handle__, initState__handle__, initCell__handle__, descriptor__handle__, nsname), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (source);
			GC.KeepAlive (recurrentWeight);
			GC.KeepAlive (sourceGradient);
			GC.KeepAlive (zState);
			GC.KeepAlive (cellOutputFwd);
			GC.KeepAlive (inputWeight);
			GC.KeepAlive (bias);
			GC.KeepAlive (initState);
			GC.KeepAlive (initCell);
			GC.KeepAlive (descriptor);
			CFString.ReleaseNative (nsname);
			return ret!;
		}
		[Export ("LSTMGradientsWithSourceTensor:recurrentWeight:sourceGradient:zState:cellOutputFwd:descriptor:name:")]
		[SupportedOSPlatform ("tvos15.4")]
		[SupportedOSPlatform ("macos12.3")]
		[SupportedOSPlatform ("ios15.4")]
		[SupportedOSPlatform ("maccatalyst15.4")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MPSGraphTensor[] LstmGradients (this MPSGraph This, MPSGraphTensor source, MPSGraphTensor recurrentWeight, MPSGraphTensor sourceGradient, MPSGraphTensor zState, MPSGraphTensor cellOutputFwd, MPSGraphLstmDescriptor descriptor, string? name)
		{
			var source__handle__ = source!.GetNonNullHandle (nameof (source));
			var recurrentWeight__handle__ = recurrentWeight!.GetNonNullHandle (nameof (recurrentWeight));
			var sourceGradient__handle__ = sourceGradient!.GetNonNullHandle (nameof (sourceGradient));
			var zState__handle__ = zState!.GetNonNullHandle (nameof (zState));
			var cellOutputFwd__handle__ = cellOutputFwd!.GetNonNullHandle (nameof (cellOutputFwd));
			var descriptor__handle__ = descriptor!.GetNonNullHandle (nameof (descriptor));
			var nsname = CFString.CreateNative (name);
			MPSGraphTensor[]? ret;
			ret = CFArray.ArrayFromHandle<MPSGraphTensor>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle_NativeHandle_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("LSTMGradientsWithSourceTensor:recurrentWeight:sourceGradient:zState:cellOutputFwd:descriptor:name:"), source__handle__, recurrentWeight__handle__, sourceGradient__handle__, zState__handle__, cellOutputFwd__handle__, descriptor__handle__, nsname), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (source);
			GC.KeepAlive (recurrentWeight);
			GC.KeepAlive (sourceGradient);
			GC.KeepAlive (zState);
			GC.KeepAlive (cellOutputFwd);
			GC.KeepAlive (descriptor);
			CFString.ReleaseNative (nsname);
			return ret!;
		}
		[Export ("singleGateRNNWithSourceTensor:recurrentWeight:inputWeight:bias:initState:mask:descriptor:name:")]
		[SupportedOSPlatform ("tvos15.4")]
		[SupportedOSPlatform ("macos12.3")]
		[SupportedOSPlatform ("ios15.4")]
		[SupportedOSPlatform ("maccatalyst15.4")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MPSGraphTensor[] SingleGateRnn (this MPSGraph This, MPSGraphTensor source, MPSGraphTensor recurrentWeight, MPSGraphTensor? inputWeight, MPSGraphTensor? bias, MPSGraphTensor? initState, MPSGraphTensor? mask, MPSGraphSingleGateRnnDescriptor descriptor, string? name)
		{
			var source__handle__ = source!.GetNonNullHandle (nameof (source));
			var recurrentWeight__handle__ = recurrentWeight!.GetNonNullHandle (nameof (recurrentWeight));
			var inputWeight__handle__ = inputWeight.GetHandle ();
			var bias__handle__ = bias.GetHandle ();
			var initState__handle__ = initState.GetHandle ();
			var mask__handle__ = mask.GetHandle ();
			var descriptor__handle__ = descriptor!.GetNonNullHandle (nameof (descriptor));
			var nsname = CFString.CreateNative (name);
			MPSGraphTensor[]? ret;
			ret = CFArray.ArrayFromHandle<MPSGraphTensor>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle_NativeHandle_NativeHandle_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("singleGateRNNWithSourceTensor:recurrentWeight:inputWeight:bias:initState:mask:descriptor:name:"), source__handle__, recurrentWeight__handle__, inputWeight__handle__, bias__handle__, initState__handle__, mask__handle__, descriptor__handle__, nsname), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (source);
			GC.KeepAlive (recurrentWeight);
			GC.KeepAlive (inputWeight);
			GC.KeepAlive (bias);
			GC.KeepAlive (initState);
			GC.KeepAlive (mask);
			GC.KeepAlive (descriptor);
			CFString.ReleaseNative (nsname);
			return ret!;
		}
		[Export ("singleGateRNNWithSourceTensor:recurrentWeight:inputWeight:bias:initState:descriptor:name:")]
		[SupportedOSPlatform ("tvos15.4")]
		[SupportedOSPlatform ("macos12.3")]
		[SupportedOSPlatform ("ios15.4")]
		[SupportedOSPlatform ("maccatalyst15.4")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MPSGraphTensor[] SingleGateRnn (this MPSGraph This, MPSGraphTensor source, MPSGraphTensor recurrentWeight, MPSGraphTensor? inputWeight, MPSGraphTensor? bias, MPSGraphTensor? initState, MPSGraphSingleGateRnnDescriptor descriptor, string? name)
		{
			var source__handle__ = source!.GetNonNullHandle (nameof (source));
			var recurrentWeight__handle__ = recurrentWeight!.GetNonNullHandle (nameof (recurrentWeight));
			var inputWeight__handle__ = inputWeight.GetHandle ();
			var bias__handle__ = bias.GetHandle ();
			var initState__handle__ = initState.GetHandle ();
			var descriptor__handle__ = descriptor!.GetNonNullHandle (nameof (descriptor));
			var nsname = CFString.CreateNative (name);
			MPSGraphTensor[]? ret;
			ret = CFArray.ArrayFromHandle<MPSGraphTensor>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle_NativeHandle_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("singleGateRNNWithSourceTensor:recurrentWeight:inputWeight:bias:initState:descriptor:name:"), source__handle__, recurrentWeight__handle__, inputWeight__handle__, bias__handle__, initState__handle__, descriptor__handle__, nsname), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (source);
			GC.KeepAlive (recurrentWeight);
			GC.KeepAlive (inputWeight);
			GC.KeepAlive (bias);
			GC.KeepAlive (initState);
			GC.KeepAlive (descriptor);
			CFString.ReleaseNative (nsname);
			return ret!;
		}
		[Export ("singleGateRNNWithSourceTensor:recurrentWeight:initState:descriptor:name:")]
		[SupportedOSPlatform ("tvos15.4")]
		[SupportedOSPlatform ("macos12.3")]
		[SupportedOSPlatform ("ios15.4")]
		[SupportedOSPlatform ("maccatalyst15.4")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MPSGraphTensor[] SingleGateRnn (this MPSGraph This, MPSGraphTensor source, MPSGraphTensor recurrentWeight, MPSGraphTensor? initState, MPSGraphSingleGateRnnDescriptor descriptor, string? name)
		{
			var source__handle__ = source!.GetNonNullHandle (nameof (source));
			var recurrentWeight__handle__ = recurrentWeight!.GetNonNullHandle (nameof (recurrentWeight));
			var initState__handle__ = initState.GetHandle ();
			var descriptor__handle__ = descriptor!.GetNonNullHandle (nameof (descriptor));
			var nsname = CFString.CreateNative (name);
			MPSGraphTensor[]? ret;
			ret = CFArray.ArrayFromHandle<MPSGraphTensor>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("singleGateRNNWithSourceTensor:recurrentWeight:initState:descriptor:name:"), source__handle__, recurrentWeight__handle__, initState__handle__, descriptor__handle__, nsname), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (source);
			GC.KeepAlive (recurrentWeight);
			GC.KeepAlive (initState);
			GC.KeepAlive (descriptor);
			CFString.ReleaseNative (nsname);
			return ret!;
		}
		[Export ("singleGateRNNGradientsWithSourceTensor:recurrentWeight:sourceGradient:zState:stateGradient:inputWeight:bias:initState:mask:descriptor:name:")]
		[SupportedOSPlatform ("tvos15.4")]
		[SupportedOSPlatform ("macos12.3")]
		[SupportedOSPlatform ("ios15.4")]
		[SupportedOSPlatform ("maccatalyst15.4")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MPSGraphTensor[] SingleGateRnnGradients (this MPSGraph This, MPSGraphTensor source, MPSGraphTensor recurrentWeight, MPSGraphTensor sourceGradient, MPSGraphTensor zState, MPSGraphTensor? stateGradient, MPSGraphTensor? inputWeight, MPSGraphTensor? bias, MPSGraphTensor? initState, MPSGraphTensor? mask, MPSGraphSingleGateRnnDescriptor descriptor, string? name)
		{
			var source__handle__ = source!.GetNonNullHandle (nameof (source));
			var recurrentWeight__handle__ = recurrentWeight!.GetNonNullHandle (nameof (recurrentWeight));
			var sourceGradient__handle__ = sourceGradient!.GetNonNullHandle (nameof (sourceGradient));
			var zState__handle__ = zState!.GetNonNullHandle (nameof (zState));
			var stateGradient__handle__ = stateGradient.GetHandle ();
			var inputWeight__handle__ = inputWeight.GetHandle ();
			var bias__handle__ = bias.GetHandle ();
			var initState__handle__ = initState.GetHandle ();
			var mask__handle__ = mask.GetHandle ();
			var descriptor__handle__ = descriptor!.GetNonNullHandle (nameof (descriptor));
			var nsname = CFString.CreateNative (name);
			MPSGraphTensor[]? ret;
			ret = CFArray.ArrayFromHandle<MPSGraphTensor>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle_NativeHandle_NativeHandle_NativeHandle_NativeHandle_NativeHandle_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("singleGateRNNGradientsWithSourceTensor:recurrentWeight:sourceGradient:zState:stateGradient:inputWeight:bias:initState:mask:descriptor:name:"), source__handle__, recurrentWeight__handle__, sourceGradient__handle__, zState__handle__, stateGradient__handle__, inputWeight__handle__, bias__handle__, initState__handle__, mask__handle__, descriptor__handle__, nsname), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (source);
			GC.KeepAlive (recurrentWeight);
			GC.KeepAlive (sourceGradient);
			GC.KeepAlive (zState);
			GC.KeepAlive (stateGradient);
			GC.KeepAlive (inputWeight);
			GC.KeepAlive (bias);
			GC.KeepAlive (initState);
			GC.KeepAlive (mask);
			GC.KeepAlive (descriptor);
			CFString.ReleaseNative (nsname);
			return ret!;
		}
		[Export ("singleGateRNNGradientsWithSourceTensor:recurrentWeight:sourceGradient:zState:inputWeight:bias:initState:mask:descriptor:name:")]
		[SupportedOSPlatform ("tvos15.4")]
		[SupportedOSPlatform ("macos12.3")]
		[SupportedOSPlatform ("ios15.4")]
		[SupportedOSPlatform ("maccatalyst15.4")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MPSGraphTensor[] SingleGateRnnGradients (this MPSGraph This, MPSGraphTensor source, MPSGraphTensor recurrentWeight, MPSGraphTensor sourceGradient, MPSGraphTensor zState, MPSGraphTensor? inputWeight, MPSGraphTensor? bias, MPSGraphTensor? initState, MPSGraphTensor? mask, MPSGraphSingleGateRnnDescriptor descriptor, string? name)
		{
			var source__handle__ = source!.GetNonNullHandle (nameof (source));
			var recurrentWeight__handle__ = recurrentWeight!.GetNonNullHandle (nameof (recurrentWeight));
			var sourceGradient__handle__ = sourceGradient!.GetNonNullHandle (nameof (sourceGradient));
			var zState__handle__ = zState!.GetNonNullHandle (nameof (zState));
			var inputWeight__handle__ = inputWeight.GetHandle ();
			var bias__handle__ = bias.GetHandle ();
			var initState__handle__ = initState.GetHandle ();
			var mask__handle__ = mask.GetHandle ();
			var descriptor__handle__ = descriptor!.GetNonNullHandle (nameof (descriptor));
			var nsname = CFString.CreateNative (name);
			MPSGraphTensor[]? ret;
			ret = CFArray.ArrayFromHandle<MPSGraphTensor>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle_NativeHandle_NativeHandle_NativeHandle_NativeHandle_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("singleGateRNNGradientsWithSourceTensor:recurrentWeight:sourceGradient:zState:inputWeight:bias:initState:mask:descriptor:name:"), source__handle__, recurrentWeight__handle__, sourceGradient__handle__, zState__handle__, inputWeight__handle__, bias__handle__, initState__handle__, mask__handle__, descriptor__handle__, nsname), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (source);
			GC.KeepAlive (recurrentWeight);
			GC.KeepAlive (sourceGradient);
			GC.KeepAlive (zState);
			GC.KeepAlive (inputWeight);
			GC.KeepAlive (bias);
			GC.KeepAlive (initState);
			GC.KeepAlive (mask);
			GC.KeepAlive (descriptor);
			CFString.ReleaseNative (nsname);
			return ret!;
		}
		[Export ("singleGateRNNGradientsWithSourceTensor:recurrentWeight:sourceGradient:zState:inputWeight:bias:initState:descriptor:name:")]
		[SupportedOSPlatform ("tvos15.4")]
		[SupportedOSPlatform ("macos12.3")]
		[SupportedOSPlatform ("ios15.4")]
		[SupportedOSPlatform ("maccatalyst15.4")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MPSGraphTensor[] SingleGateRnnGradients (this MPSGraph This, MPSGraphTensor source, MPSGraphTensor recurrentWeight, MPSGraphTensor sourceGradient, MPSGraphTensor zState, MPSGraphTensor? inputWeight, MPSGraphTensor? bias, MPSGraphTensor? initState, MPSGraphSingleGateRnnDescriptor descriptor, string? name)
		{
			var source__handle__ = source!.GetNonNullHandle (nameof (source));
			var recurrentWeight__handle__ = recurrentWeight!.GetNonNullHandle (nameof (recurrentWeight));
			var sourceGradient__handle__ = sourceGradient!.GetNonNullHandle (nameof (sourceGradient));
			var zState__handle__ = zState!.GetNonNullHandle (nameof (zState));
			var inputWeight__handle__ = inputWeight.GetHandle ();
			var bias__handle__ = bias.GetHandle ();
			var initState__handle__ = initState.GetHandle ();
			var descriptor__handle__ = descriptor!.GetNonNullHandle (nameof (descriptor));
			var nsname = CFString.CreateNative (name);
			MPSGraphTensor[]? ret;
			ret = CFArray.ArrayFromHandle<MPSGraphTensor>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle_NativeHandle_NativeHandle_NativeHandle_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("singleGateRNNGradientsWithSourceTensor:recurrentWeight:sourceGradient:zState:inputWeight:bias:initState:descriptor:name:"), source__handle__, recurrentWeight__handle__, sourceGradient__handle__, zState__handle__, inputWeight__handle__, bias__handle__, initState__handle__, descriptor__handle__, nsname), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (source);
			GC.KeepAlive (recurrentWeight);
			GC.KeepAlive (sourceGradient);
			GC.KeepAlive (zState);
			GC.KeepAlive (inputWeight);
			GC.KeepAlive (bias);
			GC.KeepAlive (initState);
			GC.KeepAlive (descriptor);
			CFString.ReleaseNative (nsname);
			return ret!;
		}
		[Export ("singleGateRNNGradientsWithSourceTensor:recurrentWeight:sourceGradient:zState:initState:descriptor:name:")]
		[SupportedOSPlatform ("tvos15.4")]
		[SupportedOSPlatform ("macos12.3")]
		[SupportedOSPlatform ("ios15.4")]
		[SupportedOSPlatform ("maccatalyst15.4")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MPSGraphTensor[] SingleGateRnnGradients (this MPSGraph This, MPSGraphTensor source, MPSGraphTensor recurrentWeight, MPSGraphTensor sourceGradient, MPSGraphTensor zState, MPSGraphTensor? initState, MPSGraphSingleGateRnnDescriptor descriptor, string? name)
		{
			var source__handle__ = source!.GetNonNullHandle (nameof (source));
			var recurrentWeight__handle__ = recurrentWeight!.GetNonNullHandle (nameof (recurrentWeight));
			var sourceGradient__handle__ = sourceGradient!.GetNonNullHandle (nameof (sourceGradient));
			var zState__handle__ = zState!.GetNonNullHandle (nameof (zState));
			var initState__handle__ = initState.GetHandle ();
			var descriptor__handle__ = descriptor!.GetNonNullHandle (nameof (descriptor));
			var nsname = CFString.CreateNative (name);
			MPSGraphTensor[]? ret;
			ret = CFArray.ArrayFromHandle<MPSGraphTensor>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle_NativeHandle_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("singleGateRNNGradientsWithSourceTensor:recurrentWeight:sourceGradient:zState:initState:descriptor:name:"), source__handle__, recurrentWeight__handle__, sourceGradient__handle__, zState__handle__, initState__handle__, descriptor__handle__, nsname), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (source);
			GC.KeepAlive (recurrentWeight);
			GC.KeepAlive (sourceGradient);
			GC.KeepAlive (zState);
			GC.KeepAlive (initState);
			GC.KeepAlive (descriptor);
			CFString.ReleaseNative (nsname);
			return ret!;
		}
	} /* class MPSGraph_MPSGraphRnnOps */
}
