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
namespace AppKit {
	[UnsupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("macos")]
	public partial class NSBindingOptions : DictionaryContainer {
#if !COREBUILD
		/// <summary>Creates a new <see cref="NSBindingOptions" /> with default (empty) values.</summary>
		public NSBindingOptions () : base (new NSMutableDictionary ()) {}
		/// <summary>Creates a new <see cref="NSBindingOptions" /> from the values that are specified in <paramref name="dictionary" />.</summary>
		/// <param name="dictionary">The dictionary to use to populate the properties of this type.</param>
		public NSBindingOptions (NSDictionary? dictionary) : base (dictionary) {}
		public bool? AllowsEditingMultipleValuesSelection {
			get {
				return  GetBoolValue (NSBindingOption.AllowsEditingMultipleValuesSelection!);
			}
			set {
				SetBooleanValue (NSBindingOption.AllowsEditingMultipleValuesSelection!, value);
			}
		}
		public bool? AllowsNullArgument {
			get {
				return  GetBoolValue (NSBindingOption.AllowsNullArgument!);
			}
			set {
				SetBooleanValue (NSBindingOption.AllowsNullArgument!, value);
			}
		}
		public bool? AlwaysPresentsApplicationModalAlerts {
			get {
				return  GetBoolValue (NSBindingOption.AlwaysPresentsApplicationModalAlerts!);
			}
			set {
				SetBooleanValue (NSBindingOption.AlwaysPresentsApplicationModalAlerts!, value);
			}
		}
		public bool? ConditionallySetsEditable {
			get {
				return  GetBoolValue (NSBindingOption.ConditionallySetsEditable!);
			}
			set {
				SetBooleanValue (NSBindingOption.ConditionallySetsEditable!, value);
			}
		}
		public bool? ConditionallySetsEnabled {
			get {
				return  GetBoolValue (NSBindingOption.ConditionallySetsEnabled!);
			}
			set {
				SetBooleanValue (NSBindingOption.ConditionallySetsEnabled!, value);
			}
		}
		public bool? ConditionallySetsHidden {
			get {
				return  GetBoolValue (NSBindingOption.ConditionallySetsHidden!);
			}
			set {
				SetBooleanValue (NSBindingOption.ConditionallySetsHidden!, value);
			}
		}
		public bool? ContinuouslyUpdatesValue {
			get {
				return  GetBoolValue (NSBindingOption.ContinuouslyUpdatesValue!);
			}
			set {
				SetBooleanValue (NSBindingOption.ContinuouslyUpdatesValue!, value);
			}
		}
		public bool? CreatesSortDescriptor {
			get {
				return  GetBoolValue (NSBindingOption.CreatesSortDescriptor!);
			}
			set {
				SetBooleanValue (NSBindingOption.CreatesSortDescriptor!, value);
			}
		}
		public bool? DeletesObjectsOnRemoveBindingsOption {
			get {
				return  GetBoolValue (NSBindingOption.DeletesObjectsOnRemoveBindingsOption!);
			}
			set {
				SetBooleanValue (NSBindingOption.DeletesObjectsOnRemoveBindingsOption!, value);
			}
		}
		public string? DisplayName {
			get {
				return GetStringValue (NSBindingOption.DisplayName!);
			}
			set {
				SetStringValue (NSBindingOption.DisplayName!, value);
			}
		}
		public string? DisplayPattern {
			get {
				return GetStringValue (NSBindingOption.DisplayPattern!);
			}
			set {
				SetStringValue (NSBindingOption.DisplayPattern!, value);
			}
		}
		public nint? ContentPlacementTag {
			get {
				return  GetNIntValue (NSBindingOption.ContentPlacementTag!);
			}
			set {
				SetNumberValue (NSBindingOption.ContentPlacementTag!, value);
			}
		}
		public bool? HandlesContentAsCompoundValue {
			get {
				return  GetBoolValue (NSBindingOption.HandlesContentAsCompoundValue!);
			}
			set {
				SetBooleanValue (NSBindingOption.HandlesContentAsCompoundValue!, value);
			}
		}
		public bool? InsertsNullPlaceholder {
			get {
				return  GetBoolValue (NSBindingOption.InsertsNullPlaceholder!);
			}
			set {
				SetBooleanValue (NSBindingOption.InsertsNullPlaceholder!, value);
			}
		}
		public bool? InvokesSeparatelyWithArrayObjects {
			get {
				return  GetBoolValue (NSBindingOption.InvokesSeparatelyWithArrayObjects!);
			}
			set {
				SetBooleanValue (NSBindingOption.InvokesSeparatelyWithArrayObjects!, value);
			}
		}
		public NSObject? MultipleValuesPlaceholder {
			get {
				return GetNativeValue<Foundation.NSObject> (NSBindingOption.MultipleValuesPlaceholder!);
			}
			set {
				SetNativeValue (NSBindingOption.MultipleValuesPlaceholder!, value);
			}
		}
		public NSObject? NoSelectionPlaceholder {
			get {
				return GetNativeValue<Foundation.NSObject> (NSBindingOption.NoSelectionPlaceholder!);
			}
			set {
				SetNativeValue (NSBindingOption.NoSelectionPlaceholder!, value);
			}
		}
		public NSObject? NotApplicablePlaceholder {
			get {
				return GetNativeValue<Foundation.NSObject> (NSBindingOption.NotApplicablePlaceholder!);
			}
			set {
				SetNativeValue (NSBindingOption.NotApplicablePlaceholder!, value);
			}
		}
		public NSObject? NullPlaceholder {
			get {
				return GetNativeValue<Foundation.NSObject> (NSBindingOption.NullPlaceholder!);
			}
			set {
				SetNativeValue (NSBindingOption.NullPlaceholder!, value);
			}
		}
		public bool? RaisesForNotApplicableKeys {
			get {
				return  GetBoolValue (NSBindingOption.RaisesForNotApplicableKeys!);
			}
			set {
				SetBooleanValue (NSBindingOption.RaisesForNotApplicableKeys!, value);
			}
		}
		public string? PredicateFormat {
			get {
				return GetStringValue (NSBindingOption.PredicateFormat!);
			}
			set {
				SetStringValue (NSBindingOption.PredicateFormat!, value);
			}
		}
		public string? SelectorName {
			get {
				return GetStringValue (NSBindingOption.SelectorName!);
			}
			set {
				SetStringValue (NSBindingOption.SelectorName!, value);
			}
		}
		public bool? SelectsAllWhenSettingContent {
			get {
				return  GetBoolValue (NSBindingOption.SelectsAllWhenSettingContent!);
			}
			set {
				SetBooleanValue (NSBindingOption.SelectsAllWhenSettingContent!, value);
			}
		}
		public bool? ValidatesImmediately {
			get {
				return  GetBoolValue (NSBindingOption.ValidatesImmediately!);
			}
			set {
				SetBooleanValue (NSBindingOption.ValidatesImmediately!, value);
			}
		}
		public string? ValueTransformerName {
			get {
				return GetStringValue (NSBindingOption.ValueTransformerName!);
			}
			set {
				SetStringValue (NSBindingOption.ValueTransformerName!, value);
			}
		}
		public NSValueTransformer? ValueTransformer {
			get {
				return Dictionary [NSBindingOption.ValueTransformer!] as Foundation.NSValueTransformer;
			}
			set {
				SetNativeValue (NSBindingOption.ValueTransformer!, value);
			}
		}
#endif
	}
}
