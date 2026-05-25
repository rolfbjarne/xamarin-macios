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
	[Register("NSEvent", true)]
	[UnsupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("macos")]
	public unsafe partial class NSEvent : NSObject, INSCoding, INSCopying {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selCGEventX = "CGEvent";
		static readonly NativeHandle selCGEventXHandle = Selector.GetHandle ("CGEvent");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAbsoluteXX = "absoluteX";
		static readonly NativeHandle selAbsoluteXXHandle = Selector.GetHandle ("absoluteX");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAbsoluteYX = "absoluteY";
		static readonly NativeHandle selAbsoluteYXHandle = Selector.GetHandle ("absoluteY");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAbsoluteZX = "absoluteZ";
		static readonly NativeHandle selAbsoluteZXHandle = Selector.GetHandle ("absoluteZ");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAddGlobalMonitorForEventsMatchingMask_Handler_X = "addGlobalMonitorForEventsMatchingMask:handler:";
		static readonly NativeHandle selAddGlobalMonitorForEventsMatchingMask_Handler_XHandle = Selector.GetHandle ("addGlobalMonitorForEventsMatchingMask:handler:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAddLocalMonitorForEventsMatchingMask_Handler_X = "addLocalMonitorForEventsMatchingMask:handler:";
		static readonly NativeHandle selAddLocalMonitorForEventsMatchingMask_Handler_XHandle = Selector.GetHandle ("addLocalMonitorForEventsMatchingMask:handler:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAllTouchesX = "allTouches";
		static readonly NativeHandle selAllTouchesXHandle = Selector.GetHandle ("allTouches");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAssociatedEventsMaskX = "associatedEventsMask";
		static readonly NativeHandle selAssociatedEventsMaskXHandle = Selector.GetHandle ("associatedEventsMask");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selButtonMaskX = "buttonMask";
		static readonly NativeHandle selButtonMaskXHandle = Selector.GetHandle ("buttonMask");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selButtonNumberX = "buttonNumber";
		static readonly NativeHandle selButtonNumberXHandle = Selector.GetHandle ("buttonNumber");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selCapabilityMaskX = "capabilityMask";
		static readonly NativeHandle selCapabilityMaskXHandle = Selector.GetHandle ("capabilityMask");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selCharactersX = "characters";
		static readonly NativeHandle selCharactersXHandle = Selector.GetHandle ("characters");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selCharactersByApplyingModifiers_X = "charactersByApplyingModifiers:";
		static readonly NativeHandle selCharactersByApplyingModifiers_XHandle = Selector.GetHandle ("charactersByApplyingModifiers:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selCharactersIgnoringModifiersX = "charactersIgnoringModifiers";
		static readonly NativeHandle selCharactersIgnoringModifiersXHandle = Selector.GetHandle ("charactersIgnoringModifiers");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selClickCountX = "clickCount";
		static readonly NativeHandle selClickCountXHandle = Selector.GetHandle ("clickCount");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selCoalescedTouchesForTouch_X = "coalescedTouchesForTouch:";
		static readonly NativeHandle selCoalescedTouchesForTouch_XHandle = Selector.GetHandle ("coalescedTouchesForTouch:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selContextX = "context";
		static readonly NativeHandle selContextXHandle = Selector.GetHandle ("context");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selCopyWithZone_X = "copyWithZone:";
		static readonly NativeHandle selCopyWithZone_XHandle = Selector.GetHandle ("copyWithZone:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selData1X = "data1";
		static readonly NativeHandle selData1XHandle = Selector.GetHandle ("data1");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selData2X = "data2";
		static readonly NativeHandle selData2XHandle = Selector.GetHandle ("data2");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selDeltaXX = "deltaX";
		static readonly NativeHandle selDeltaXXHandle = Selector.GetHandle ("deltaX");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selDeltaYX = "deltaY";
		static readonly NativeHandle selDeltaYXHandle = Selector.GetHandle ("deltaY");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selDeltaZX = "deltaZ";
		static readonly NativeHandle selDeltaZXHandle = Selector.GetHandle ("deltaZ");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selDeviceIDX = "deviceID";
		static readonly NativeHandle selDeviceIDXHandle = Selector.GetHandle ("deviceID");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selDoubleClickIntervalX = "doubleClickInterval";
		static readonly NativeHandle selDoubleClickIntervalXHandle = Selector.GetHandle ("doubleClickInterval");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selEncodeWithCoder_X = "encodeWithCoder:";
		static readonly NativeHandle selEncodeWithCoder_XHandle = Selector.GetHandle ("encodeWithCoder:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selEnterExitEventWithType_Location_ModifierFlags_Timestamp_WindowNumber_Context_EventNumber_TrackingNumber_UserData_X = "enterExitEventWithType:location:modifierFlags:timestamp:windowNumber:context:eventNumber:trackingNumber:userData:";
		static readonly NativeHandle selEnterExitEventWithType_Location_ModifierFlags_Timestamp_WindowNumber_Context_EventNumber_TrackingNumber_UserData_XHandle = Selector.GetHandle ("enterExitEventWithType:location:modifierFlags:timestamp:windowNumber:context:eventNumber:trackingNumber:userData:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selEventNumberX = "eventNumber";
		static readonly NativeHandle selEventNumberXHandle = Selector.GetHandle ("eventNumber");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selEventRefX = "eventRef";
		static readonly NativeHandle selEventRefXHandle = Selector.GetHandle ("eventRef");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selEventWithCGEvent_X = "eventWithCGEvent:";
		static readonly NativeHandle selEventWithCGEvent_XHandle = Selector.GetHandle ("eventWithCGEvent:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selEventWithEventRef_X = "eventWithEventRef:";
		static readonly NativeHandle selEventWithEventRef_XHandle = Selector.GetHandle ("eventWithEventRef:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selHasPreciseScrollingDeltasX = "hasPreciseScrollingDeltas";
		static readonly NativeHandle selHasPreciseScrollingDeltasXHandle = Selector.GetHandle ("hasPreciseScrollingDeltas");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selInitWithCoder_X = "initWithCoder:";
		static readonly NativeHandle selInitWithCoder_XHandle = Selector.GetHandle ("initWithCoder:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selIsARepeatX = "isARepeat";
		static readonly NativeHandle selIsARepeatXHandle = Selector.GetHandle ("isARepeat");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selIsDirectionInvertedFromDeviceX = "isDirectionInvertedFromDevice";
		static readonly NativeHandle selIsDirectionInvertedFromDeviceXHandle = Selector.GetHandle ("isDirectionInvertedFromDevice");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selIsEnteringProximityX = "isEnteringProximity";
		static readonly NativeHandle selIsEnteringProximityXHandle = Selector.GetHandle ("isEnteringProximity");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selIsMouseCoalescingEnabledX = "isMouseCoalescingEnabled";
		static readonly NativeHandle selIsMouseCoalescingEnabledXHandle = Selector.GetHandle ("isMouseCoalescingEnabled");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selIsSwipeTrackingFromScrollEventsEnabledX = "isSwipeTrackingFromScrollEventsEnabled";
		static readonly NativeHandle selIsSwipeTrackingFromScrollEventsEnabledXHandle = Selector.GetHandle ("isSwipeTrackingFromScrollEventsEnabled");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selKeyCodeX = "keyCode";
		static readonly NativeHandle selKeyCodeXHandle = Selector.GetHandle ("keyCode");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selKeyEventWithType_Location_ModifierFlags_Timestamp_WindowNumber_Context_Characters_CharactersIgnoringModifiers_IsARepeat_KeyCode_X = "keyEventWithType:location:modifierFlags:timestamp:windowNumber:context:characters:charactersIgnoringModifiers:isARepeat:keyCode:";
		static readonly NativeHandle selKeyEventWithType_Location_ModifierFlags_Timestamp_WindowNumber_Context_Characters_CharactersIgnoringModifiers_IsARepeat_KeyCode_XHandle = Selector.GetHandle ("keyEventWithType:location:modifierFlags:timestamp:windowNumber:context:characters:charactersIgnoringModifiers:isARepeat:keyCode:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selKeyRepeatDelayX = "keyRepeatDelay";
		static readonly NativeHandle selKeyRepeatDelayXHandle = Selector.GetHandle ("keyRepeatDelay");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selKeyRepeatIntervalX = "keyRepeatInterval";
		static readonly NativeHandle selKeyRepeatIntervalXHandle = Selector.GetHandle ("keyRepeatInterval");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selLocationInWindowX = "locationInWindow";
		static readonly NativeHandle selLocationInWindowXHandle = Selector.GetHandle ("locationInWindow");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selMagnificationX = "magnification";
		static readonly NativeHandle selMagnificationXHandle = Selector.GetHandle ("magnification");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selModifierFlagsX = "modifierFlags";
		static readonly NativeHandle selModifierFlagsXHandle = Selector.GetHandle ("modifierFlags");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selMomentumPhaseX = "momentumPhase";
		static readonly NativeHandle selMomentumPhaseXHandle = Selector.GetHandle ("momentumPhase");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selMouseEventWithType_Location_ModifierFlags_Timestamp_WindowNumber_Context_EventNumber_ClickCount_Pressure_X = "mouseEventWithType:location:modifierFlags:timestamp:windowNumber:context:eventNumber:clickCount:pressure:";
		static readonly NativeHandle selMouseEventWithType_Location_ModifierFlags_Timestamp_WindowNumber_Context_EventNumber_ClickCount_Pressure_XHandle = Selector.GetHandle ("mouseEventWithType:location:modifierFlags:timestamp:windowNumber:context:eventNumber:clickCount:pressure:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selMouseLocationX = "mouseLocation";
		static readonly NativeHandle selMouseLocationXHandle = Selector.GetHandle ("mouseLocation");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selOtherEventWithType_Location_ModifierFlags_Timestamp_WindowNumber_Context_Subtype_Data1_Data2_X = "otherEventWithType:location:modifierFlags:timestamp:windowNumber:context:subtype:data1:data2:";
		static readonly NativeHandle selOtherEventWithType_Location_ModifierFlags_Timestamp_WindowNumber_Context_Subtype_Data1_Data2_XHandle = Selector.GetHandle ("otherEventWithType:location:modifierFlags:timestamp:windowNumber:context:subtype:data1:data2:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selPhaseX = "phase";
		static readonly NativeHandle selPhaseXHandle = Selector.GetHandle ("phase");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selPointingDeviceIDX = "pointingDeviceID";
		static readonly NativeHandle selPointingDeviceIDXHandle = Selector.GetHandle ("pointingDeviceID");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selPointingDeviceSerialNumberX = "pointingDeviceSerialNumber";
		static readonly NativeHandle selPointingDeviceSerialNumberXHandle = Selector.GetHandle ("pointingDeviceSerialNumber");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selPointingDeviceTypeX = "pointingDeviceType";
		static readonly NativeHandle selPointingDeviceTypeXHandle = Selector.GetHandle ("pointingDeviceType");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selPressedMouseButtonsX = "pressedMouseButtons";
		static readonly NativeHandle selPressedMouseButtonsXHandle = Selector.GetHandle ("pressedMouseButtons");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selPressureX = "pressure";
		static readonly NativeHandle selPressureXHandle = Selector.GetHandle ("pressure");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selRemoveMonitor_X = "removeMonitor:";
		static readonly NativeHandle selRemoveMonitor_XHandle = Selector.GetHandle ("removeMonitor:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selRotationX = "rotation";
		static readonly NativeHandle selRotationXHandle = Selector.GetHandle ("rotation");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selScrollingDeltaXX = "scrollingDeltaX";
		static readonly NativeHandle selScrollingDeltaXXHandle = Selector.GetHandle ("scrollingDeltaX");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selScrollingDeltaYX = "scrollingDeltaY";
		static readonly NativeHandle selScrollingDeltaYXHandle = Selector.GetHandle ("scrollingDeltaY");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetMouseCoalescingEnabled_X = "setMouseCoalescingEnabled:";
		static readonly NativeHandle selSetMouseCoalescingEnabled_XHandle = Selector.GetHandle ("setMouseCoalescingEnabled:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selStageX = "stage";
		static readonly NativeHandle selStageXHandle = Selector.GetHandle ("stage");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selStageTransitionX = "stageTransition";
		static readonly NativeHandle selStageTransitionXHandle = Selector.GetHandle ("stageTransition");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selStartPeriodicEventsAfterDelay_WithPeriod_X = "startPeriodicEventsAfterDelay:withPeriod:";
		static readonly NativeHandle selStartPeriodicEventsAfterDelay_WithPeriod_XHandle = Selector.GetHandle ("startPeriodicEventsAfterDelay:withPeriod:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selStopPeriodicEventsX = "stopPeriodicEvents";
		static readonly NativeHandle selStopPeriodicEventsXHandle = Selector.GetHandle ("stopPeriodicEvents");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSubtypeX = "subtype";
		static readonly NativeHandle selSubtypeXHandle = Selector.GetHandle ("subtype");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSystemTabletIDX = "systemTabletID";
		static readonly NativeHandle selSystemTabletIDXHandle = Selector.GetHandle ("systemTabletID");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selTabletIDX = "tabletID";
		static readonly NativeHandle selTabletIDXHandle = Selector.GetHandle ("tabletID");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selTangentialPressureX = "tangentialPressure";
		static readonly NativeHandle selTangentialPressureXHandle = Selector.GetHandle ("tangentialPressure");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selTiltX = "tilt";
		static readonly NativeHandle selTiltXHandle = Selector.GetHandle ("tilt");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selTimestampX = "timestamp";
		static readonly NativeHandle selTimestampXHandle = Selector.GetHandle ("timestamp");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selTouchesForView_X = "touchesForView:";
		static readonly NativeHandle selTouchesForView_XHandle = Selector.GetHandle ("touchesForView:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selTouchesMatchingPhase_InView_X = "touchesMatchingPhase:inView:";
		static readonly NativeHandle selTouchesMatchingPhase_InView_XHandle = Selector.GetHandle ("touchesMatchingPhase:inView:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selTrackSwipeEventWithOptions_DampenAmountThresholdMin_Max_UsingHandler_X = "trackSwipeEventWithOptions:dampenAmountThresholdMin:max:usingHandler:";
		static readonly NativeHandle selTrackSwipeEventWithOptions_DampenAmountThresholdMin_Max_UsingHandler_XHandle = Selector.GetHandle ("trackSwipeEventWithOptions:dampenAmountThresholdMin:max:usingHandler:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selTrackingAreaX = "trackingArea";
		static readonly NativeHandle selTrackingAreaXHandle = Selector.GetHandle ("trackingArea");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selTrackingNumberX = "trackingNumber";
		static readonly NativeHandle selTrackingNumberXHandle = Selector.GetHandle ("trackingNumber");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selTypeX = "type";
		static readonly NativeHandle selTypeXHandle = Selector.GetHandle ("type");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selUniqueIDX = "uniqueID";
		static readonly NativeHandle selUniqueIDXHandle = Selector.GetHandle ("uniqueID");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selUserDataX = "userData";
		static readonly NativeHandle selUserDataXHandle = Selector.GetHandle ("userData");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selVendorDefinedX = "vendorDefined";
		static readonly NativeHandle selVendorDefinedXHandle = Selector.GetHandle ("vendorDefined");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selVendorIDX = "vendorID";
		static readonly NativeHandle selVendorIDXHandle = Selector.GetHandle ("vendorID");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selVendorPointingDeviceTypeX = "vendorPointingDeviceType";
		static readonly NativeHandle selVendorPointingDeviceTypeXHandle = Selector.GetHandle ("vendorPointingDeviceType");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selWindowX = "window";
		static readonly NativeHandle selWindowXHandle = Selector.GetHandle ("window");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selWindowNumberX = "windowNumber";
		static readonly NativeHandle selWindowNumberXHandle = Selector.GetHandle ("windowNumber");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly NativeHandle class_ptr = Class.GetHandle ("NSEvent");
		/// <summary>The Objective-C class handle for this class.</summary>
		/// <value>The pointer to the Objective-C class.</value>
		/// <remarks>
		///     Each managed class mirrors an unmanaged Objective-C class.
		///     This value contains the pointer to the Objective-C class.
		///     It is similar to calling the managed <see cref="ObjCRuntime.Class.GetHandle(string)" /> or the native <see href="https://developer.apple.com/documentation/objectivec/1418952-objc_getclass">objc_getClass</see> method with the type name.
		/// </remarks>
		public override NativeHandle ClassHandle { get { return class_ptr; } }
		/// <summary>Creates a new <see cref="NSEvent" /> with default values.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public NSEvent () : base (NSObjectFlag.Empty)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			if (IsDirectBinding) {
				InitializeHandle (global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, global::ObjCRuntime.Selector.Init), "init");
			} else {
				unsafe {
				var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
				InitializeHandle (global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (&__objc_super__, global::ObjCRuntime.Selector.Init), "init");
				GC.KeepAlive (this);
				}
			}
		}

		/// <summary>A constructor that initializes the object from the data stored in the unarchiver object.</summary>
		/// <param name="coder">The unarchiver object.</param>
		/// <remarks>
		///   <para>This constructor is provided to allow the class to be initialized from an unarchiver (for example, during NIB deserialization). This is part of the <see cref="Foundation.NSCoding" /> protocol.</para>
		///   <para>If developers want to create a subclass of this object and continue to support deserialization from an archive, they should implement a constructor with an identical signature: taking a single parameter of type <see cref="Foundation.NSCoder" /> and decorate it with the <c>[Export("initWithCoder:"]</c> attribute.</para>
		///   <para>The state of this object can also be serialized by using the <see cref="Foundation.INSCoding.EncodeTo" /> companion method.</para>
		/// </remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[DesignatedInitializer]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("initWithCoder:")]
		public NSEvent (NSCoder coder) : base (NSObjectFlag.Empty)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			if (IsDirectBinding) {
				InitializeHandle (global::ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr (this.Handle, Selector.InitWithCoder, coder.Handle), "initWithCoder:");
			} else {
				unsafe {
				var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
				InitializeHandle (global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper_IntPtr (&__objc_super__, Selector.InitWithCoder, coder.Handle), "initWithCoder:");
				GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (coder);
		}

		/// <summary>Constructor to call on derived classes to skip initialization and merely allocate the object.</summary>
		/// <param name="t">Unused sentinel value, pass NSObjectFlag.Empty.</param>
		/// <remarks>
		///     <para>
		///         This constructor should be called by derived classes when they completely construct the object in managed code and merely want the runtime to allocate and initialize the <see cref="Foundation.NSObject" />.
		///         This is required to implement the two-step initialization process that Objective-C uses, the first step is to perform the object allocation, the second step is to initialize the object.
		///         When developers invoke this constructor, they take advantage of a direct path that goes all the way up to <see cref="Foundation.NSObject" /> to merely allocate the object's memory and bind the Objective-C and C# objects together.
		///         The actual initialization of the object is up to the developer.
		///     </para>
		///     <para>
		///         This constructor is typically used by the binding generator to allocate the object, but prevent the actual initialization to take place.
		///         Once the allocation has taken place, the constructor has to initialize the object.
		///         With constructors generated by the binding generator this means that it manually invokes one of the "init" methods to initialize the object.
		///     </para>
		///     <para>It is the developer's responsibility to completely initialize the object if they chain up using this constructor chain.</para>
		///     <para>
		///         In general, if the developer's constructor invokes the corresponding base implementation, then it should also call an Objective-C init method.
		///         If this is not the case, developers should instead chain to the proper constructor in their class.
		///     </para>
		///     <para>
		///         The argument value is ignored and merely ensures that the only code that is executed is the construction phase is the basic <see cref="Foundation.NSObject" /> allocation and runtime type registration.
		///         Typically the chaining would look like this:
		///     </para>
		///     <example>
		///             <code lang="csharp lang-csharp"><![CDATA[
		/// //
		/// // The NSObjectFlag constructor merely allocates the object and registers the C# class with the Objective-C runtime if necessary.
		/// // No actual initXxx method is invoked, that is done later in the constructor
		/// //
		/// // This is taken from the iOS SDK's source code for the UIView class:
		/// //
		/// [Export ("initWithFrame:")]
		/// public UIView (CGRect frame) : base (NSObjectFlag.Empty)
		/// {
		///     // Invoke the init method now.
		///     var initWithFrame = new Selector ("initWithFrame:").Handle;
		///     if (IsDirectBinding) {
		///         Handle = ObjCRuntime.Messaging.IntPtr_objc_msgSend_CGRect (this.Handle, initWithFrame, frame);
		///     } else {
		///         unsafe {
		///             var __objc_super__ = new ObjCRuntime.ObjCSuper (this);
		///             Handle = ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper_CGRect (&__objc_super__, initWithFrame, frame);
		///         }
		///         GC.KeepAlive (this);
		///     }
		/// }
		/// ]]></code>
		///     </example>
		/// </remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected NSEvent (NSObjectFlag t) : base (t)
		{
		}

		/// <summary>A constructor used when creating managed representations of unmanaged objects. Called by the runtime.</summary>
		/// <param name="handle">Pointer (handle) to the unmanaged object.</param>
		/// <remarks>
		///     <para>
		///         This constructor is invoked by the runtime infrastructure (<see cref="ObjCRuntime.Runtime.GetNSObject(System.IntPtr)" />) to create a new managed representation for a pointer to an unmanaged Objective-C object.
		///         Developers should not invoke this method directly, instead they should call <see cref="ObjCRuntime.Runtime.GetNSObject(System.IntPtr)" /> as it will prevent two instances of a managed object pointing to the same native object.
		///     </para>
		/// </remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal NSEvent (NativeHandle handle) : base (handle)
		{
		}

		[Export ("addGlobalMonitorForEventsMatchingMask:handler:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static NSObject AddGlobalMonitorForEventsMatchingMask (NSEventMask mask, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDGlobalEventHandler))]GlobalEventHandler handler)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			if (handler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (handler));
			using var block_handler = Trampolines.SDGlobalEventHandler.CreateBlock (handler);
			BlockLiteral *block_ptr_handler = &block_handler;
			NSObject ret;
			ret = Runtime.GetNSObject (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_UInt64_NativeHandle (class_ptr, selAddGlobalMonitorForEventsMatchingMask_Handler_XHandle, (UInt64)mask, (IntPtr) block_ptr_handler), false)!;
			return ret;
		}
		[Export ("addLocalMonitorForEventsMatchingMask:handler:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static NSObject AddLocalMonitorForEventsMatchingMask (NSEventMask mask, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDLocalEventHandler))]LocalEventHandler handler)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			if (handler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (handler));
			using var block_handler = Trampolines.SDLocalEventHandler.CreateBlock (handler);
			BlockLiteral *block_ptr_handler = &block_handler;
			NSObject ret;
			ret = Runtime.GetNSObject (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_UInt64_NativeHandle (class_ptr, selAddLocalMonitorForEventsMatchingMask_Handler_XHandle, (UInt64)mask, (IntPtr) block_ptr_handler), false)!;
			return ret;
		}
		/// <param name="zone">Developers should pass <see langword="null" />.  Memory zones are no longer used.</param><summary>Performs a copy of the underlying Objective-C object.</summary><returns>The newly-allocated object.</returns><remarks><para>This method performs a "shallow copy" of <see langword="this" />. If this object contains references to external objects, the new object will contain references to the same object.</para></remarks>
		[Export ("copyWithZone:")]
		[return: ReleaseAttribute ()]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSObject Copy (NSZone? zone)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var zone__handle__ = zone.GetHandle ();
			NSObject? ret;
			if (IsDirectBinding) {
				ret = Runtime.GetNSObject (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, selCopyWithZone_XHandle, zone__handle__), true)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = Runtime.GetNSObject (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle (&__objc_super__, selCopyWithZone_XHandle, zone__handle__), true)!;
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (zone);
			return ret!;
		}
		/// <summary>Encodes the state of the object using the provided encoder.</summary><param name="encoder">The encoder object where the state of the object will be stored</param><remarks><para>This method is part of the <see cref="T:Foundation.INSCoding" /> protocol and is used by applications to preserve the state of the object into an archive.</para><para>Developers will typically create an <see cref="T:Foundation.NSKeyedArchiver" /> and then invoke the <see cref="M:Foundation.NSKeyedArchiver.ArchiveRootObjectToFile(Foundation.NSObject,System.String)" /> method which will call into this method.</para><para>If developers want to allow their object to be archived, they should override this method and store their state in using the provided <paramref name="encoder" /> parameter. In addition, developers should also implement a constructor that takes an NSCoder argument and is exported with <c>[Export ("initWithCoder:")]</c>.</para><example><code lang="csharp lang-csharp"><![CDATA[public void override EncodeTo (NSCoder coder) {
		/// coder.Encode (1, key: "version");
		/// coder.Encode (userName, key: "userName");
		/// coder.Encode (hostName, key: "hostName");]]></code></example></remarks>
		[Export ("encodeWithCoder:")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void EncodeTo (NSCoder encoder)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var encoder__handle__ = encoder!.GetNonNullHandle (nameof (encoder));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selEncodeWithCoder_XHandle, encoder__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selEncodeWithCoder_XHandle, encoder__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (encoder);
		}
		[Export ("enterExitEventWithType:location:modifierFlags:timestamp:windowNumber:context:eventNumber:trackingNumber:userData:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSEvent EnterExitEvent (NSEventType type, CGPoint location, NSEventModifierMask flags, double time, nint wNum, NSGraphicsContext? context, nint eNum, nint tNum, nint data)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var context__handle__ = context.GetHandle ();
			NSEvent? ret;
			ret =  Runtime.GetNSObject<NSEvent> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_UIntPtr_CGPoint_UIntPtr_Double_IntPtr_NativeHandle_IntPtr_IntPtr_IntPtr (class_ptr, selEnterExitEventWithType_Location_ModifierFlags_Timestamp_WindowNumber_Context_EventNumber_TrackingNumber_UserData_XHandle, (UIntPtr) (ulong) type, location, (UIntPtr) (ulong) flags, time, wNum, context__handle__, eNum, tNum, data), false)!;
			GC.KeepAlive (context);
			return ret!;
		}
		[Export ("eventWithCGEvent:")]
		[Obsolete ("Use 'Create (CGEvent)' instead.", false)]
		[EditorBrowsable (EditorBrowsableState.Never)]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSEvent EventWithCGEvent (nint cgEventPtr)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			NSEvent ret;
			ret =  Runtime.GetNSObject<NSEvent> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_IntPtr (class_ptr, selEventWithCGEvent_XHandle, cgEventPtr), false)!;
			return ret;
		}
		[Export ("eventWithEventRef:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSEvent EventWithEventRef (nint cgEventRef)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			NSEvent ret;
			ret =  Runtime.GetNSObject<NSEvent> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_IntPtr (class_ptr, selEventWithEventRef_XHandle, cgEventRef), false)!;
			return ret;
		}
		/// <summary>The CGEvent object corresponding to this event.</summary><appledoc>https://developer.apple.com/documentation/appkit/nsevent/1530429-cgevent?language=objc</appledoc>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public CGEvent? GetCGEventObject ()
		{
			return Runtime.GetINativeObject<CGEvent> (CGEvent, false);
		}
		[Export ("charactersByApplyingModifiers:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string? GetCharacters (NSEventModifierFlags modifiers)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			string ret;
			if (IsDirectBinding) {
				ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_UIntPtr (this.Handle, selCharactersByApplyingModifiers_XHandle, (UIntPtr) (ulong) modifiers), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_UIntPtr (&__objc_super__, selCharactersByApplyingModifiers_XHandle, (UIntPtr) (ulong) modifiers), false)!;
					GC.KeepAlive (this);
				}
			}
			return ret;
		}
		[Export ("coalescedTouchesForTouch:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSTouch[] GetCoalescedTouches (NSTouch touch)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var touch__handle__ = touch!.GetNonNullHandle (nameof (touch));
			NSTouch[]? ret;
			if (IsDirectBinding) {
				ret = CFArray.ArrayFromHandle<NSTouch>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, selCoalescedTouchesForTouch_XHandle, touch__handle__), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = CFArray.ArrayFromHandle<NSTouch>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle (&__objc_super__, selCoalescedTouchesForTouch_XHandle, touch__handle__), false)!;
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (touch);
			return ret!;
		}
		[Export ("touchesForView:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSSet<NSTouch> GetTouches (NSView view)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var view__handle__ = view!.GetNonNullHandle (nameof (view));
			NSSet<NSTouch>? ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<NSSet<NSTouch>> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, selTouchesForView_XHandle, view__handle__), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<NSSet<NSTouch>> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle (&__objc_super__, selTouchesForView_XHandle, view__handle__), false)!;
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (view);
			return ret!;
		}
		[Export ("keyEventWithType:location:modifierFlags:timestamp:windowNumber:context:characters:charactersIgnoringModifiers:isARepeat:keyCode:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSEvent KeyEvent (NSEventType type, CGPoint location, NSEventModifierMask flags, double time, nint wNum, NSGraphicsContext? context, string keys, string ukeys, bool isARepeat, ushort code)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var context__handle__ = context.GetHandle ();
			if (keys is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (keys));
			if (ukeys is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (ukeys));
			var nskeys = CFString.CreateNative (keys);
			var nsukeys = CFString.CreateNative (ukeys);
			NSEvent? ret;
			ret =  Runtime.GetNSObject<NSEvent> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_UIntPtr_CGPoint_UIntPtr_Double_IntPtr_NativeHandle_NativeHandle_NativeHandle_bool_UInt16 (class_ptr, selKeyEventWithType_Location_ModifierFlags_Timestamp_WindowNumber_Context_Characters_CharactersIgnoringModifiers_IsARepeat_KeyCode_XHandle, (UIntPtr) (ulong) type, location, (UIntPtr) (ulong) flags, time, wNum, context__handle__, nskeys, nsukeys, isARepeat ? (byte) 1 : (byte) 0, code), false)!;
			GC.KeepAlive (context);
			CFString.ReleaseNative (nskeys);
			CFString.ReleaseNative (nsukeys);
			return ret!;
		}
		[Export ("mouseEventWithType:location:modifierFlags:timestamp:windowNumber:context:eventNumber:clickCount:pressure:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSEvent MouseEvent (NSEventType type, CGPoint location, NSEventModifierMask flags, double time, nint wNum, NSGraphicsContext? context, nint eNum, nint cNum, float pressure)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var context__handle__ = context.GetHandle ();
			NSEvent? ret;
			ret =  Runtime.GetNSObject<NSEvent> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_UIntPtr_CGPoint_UIntPtr_Double_IntPtr_NativeHandle_IntPtr_IntPtr_float (class_ptr, selMouseEventWithType_Location_ModifierFlags_Timestamp_WindowNumber_Context_EventNumber_ClickCount_Pressure_XHandle, (UIntPtr) (ulong) type, location, (UIntPtr) (ulong) flags, time, wNum, context__handle__, eNum, cNum, pressure), false)!;
			GC.KeepAlive (context);
			return ret!;
		}
		[Export ("otherEventWithType:location:modifierFlags:timestamp:windowNumber:context:subtype:data1:data2:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSEvent OtherEvent (NSEventType type, CGPoint location, NSEventModifierMask flags, double time, nint wNum, NSGraphicsContext? context, short subtype, nint d1, nint d2)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var context__handle__ = context.GetHandle ();
			NSEvent? ret;
			ret =  Runtime.GetNSObject<NSEvent> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_UIntPtr_CGPoint_UIntPtr_Double_IntPtr_NativeHandle_short_IntPtr_IntPtr (class_ptr, selOtherEventWithType_Location_ModifierFlags_Timestamp_WindowNumber_Context_Subtype_Data1_Data2_XHandle, (UIntPtr) (ulong) type, location, (UIntPtr) (ulong) flags, time, wNum, context__handle__, subtype, d1, d2), false)!;
			GC.KeepAlive (context);
			return ret!;
		}
		[Export ("pointingDeviceID")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual nuint PointingDeviceID ()
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			nuint ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend (this.Handle, selPointingDeviceIDXHandle);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.UIntPtr_objc_msgSendSuper (&__objc_super__, selPointingDeviceIDXHandle);
					GC.KeepAlive (this);
				}
			}
			return ret;
		}
		[Export ("removeMonitor:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void RemoveMonitor (NSObject eventMonitor)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var eventMonitor__handle__ = eventMonitor!.GetNonNullHandle (nameof (eventMonitor));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (class_ptr, selRemoveMonitor_XHandle, eventMonitor__handle__);
			GC.KeepAlive (eventMonitor);
		}
		[Export ("startPeriodicEventsAfterDelay:withPeriod:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void StartPeriodicEventsAfterDelay (double delay, double period)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			global::ObjCRuntime.Messaging.void_objc_msgSend_Double_Double (class_ptr, selStartPeriodicEventsAfterDelay_WithPeriod_XHandle, delay, period);
		}
		[Export ("stopPeriodicEvents")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void StopPeriodicEvents ()
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			global::ObjCRuntime.Messaging.void_objc_msgSend (class_ptr, selStopPeriodicEventsXHandle);
		}
		[Export ("touchesMatchingPhase:inView:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSSet TouchesMatchingPhase (NSTouchPhase phase, NSView view)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var view__handle__ = view!.GetNonNullHandle (nameof (view));
			NSSet? ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<NSSet> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_UIntPtr_NativeHandle (this.Handle, selTouchesMatchingPhase_InView_XHandle, (UIntPtr) (ulong) phase, view__handle__), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<NSSet> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_UIntPtr_NativeHandle (&__objc_super__, selTouchesMatchingPhase_InView_XHandle, (UIntPtr) (ulong) phase, view__handle__), false)!;
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (view);
			return ret!;
		}
		[Export ("trackSwipeEventWithOptions:dampenAmountThresholdMin:max:usingHandler:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void TrackSwipeEvent (NSEventSwipeTrackingOptions options, nfloat minDampenThreshold, nfloat maxDampenThreshold, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDNSEventTrackHandler))]NSEventTrackHandler trackingHandler)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			if (trackingHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (trackingHandler));
			using var block_trackingHandler = Trampolines.SDNSEventTrackHandler.CreateBlock (trackingHandler);
			BlockLiteral *block_ptr_trackingHandler = &block_trackingHandler;
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_UIntPtr_nfloat_nfloat_NativeHandle (this.Handle, selTrackSwipeEventWithOptions_DampenAmountThresholdMin_Max_UsingHandler_XHandle, (UIntPtr) (ulong) options, minDampenThreshold, maxDampenThreshold, (IntPtr) block_ptr_trackingHandler);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_UIntPtr_nfloat_nfloat_NativeHandle (&__objc_super__, selTrackSwipeEventWithOptions_DampenAmountThresholdMin_Max_UsingHandler_XHandle, (UIntPtr) (ulong) options, minDampenThreshold, maxDampenThreshold, (IntPtr) block_ptr_trackingHandler);
					GC.KeepAlive (this);
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[DebuggerBrowsable (DebuggerBrowsableState.Never)]
		public virtual nint AbsoluteX {
			[Export ("absoluteX")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				nint ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selAbsoluteXXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (&__objc_super__, selAbsoluteXXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[DebuggerBrowsable (DebuggerBrowsableState.Never)]
		public virtual nint AbsoluteY {
			[Export ("absoluteY")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				nint ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selAbsoluteYXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (&__objc_super__, selAbsoluteYXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[DebuggerBrowsable (DebuggerBrowsableState.Never)]
		public virtual nint AbsoluteZ {
			[Export ("absoluteZ")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				nint ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selAbsoluteZXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (&__objc_super__, selAbsoluteZXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSSet<NSTouch> AllTouches {
			[Export ("allTouches")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				NSSet<NSTouch>? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSSet<NSTouch>> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selAllTouchesXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<NSSet<NSTouch>> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selAllTouchesXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSEventMask AssociatedEventsMask {
			[Export ("associatedEventsMask")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				NSEventMask ret;
				if (IsDirectBinding) {
					ret = (NSEventMask) global::ObjCRuntime.Messaging.UInt64_objc_msgSend (this.Handle, selAssociatedEventsMaskXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = (NSEventMask) global::ObjCRuntime.Messaging.UInt64_objc_msgSendSuper (&__objc_super__, selAssociatedEventsMaskXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[DebuggerBrowsable (DebuggerBrowsableState.Never)]
		public virtual nuint ButtonMask {
			[Export ("buttonMask")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				nuint ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend (this.Handle, selButtonMaskXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.UIntPtr_objc_msgSendSuper (&__objc_super__, selButtonMaskXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[DebuggerBrowsable (DebuggerBrowsableState.Never)]
		public virtual nint ButtonNumber {
			[Export ("buttonNumber")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				nint ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selButtonNumberXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (&__objc_super__, selButtonNumberXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual nint CGEvent {
			[Export ("CGEvent")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				nint ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selCGEventXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (&__objc_super__, selCGEventXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[DebuggerBrowsable (DebuggerBrowsableState.Never)]
		public virtual nuint CapabilityMask {
			[Export ("capabilityMask")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				nuint ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend (this.Handle, selCapabilityMaskXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.UIntPtr_objc_msgSendSuper (&__objc_super__, selCapabilityMaskXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[DebuggerBrowsable (DebuggerBrowsableState.Never)]
		public virtual string Characters {
			[Export ("characters")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				string ret;
				if (IsDirectBinding) {
					ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selCharactersXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selCharactersXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[DebuggerBrowsable (DebuggerBrowsableState.Never)]
		public virtual string CharactersIgnoringModifiers {
			[Export ("charactersIgnoringModifiers")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				string ret;
				if (IsDirectBinding) {
					ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selCharactersIgnoringModifiersXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selCharactersIgnoringModifiersXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[DebuggerBrowsable (DebuggerBrowsableState.Never)]
		public virtual nint ClickCount {
			[Export ("clickCount")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				nint ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selClickCountXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (&__objc_super__, selClickCountXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[DebuggerBrowsable (DebuggerBrowsableState.Never)]
		[ObsoletedOSPlatform ("macos10.12", "This method always returns null. If you need access to the current drawing context, use NSGraphicsContext.CurrentContext inside of a draw operation.")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public virtual NSGraphicsContext Context {
			[Export ("context")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				NSGraphicsContext? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSGraphicsContext> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selContextXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<NSGraphicsContext> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selContextXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSEventModifierMask CurrentModifierFlags {
			[Export ("modifierFlags")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				NSEventModifierMask ret;
				ret = (NSEventModifierMask) (ulong) global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend (class_ptr, selModifierFlagsXHandle);
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static CGPoint CurrentMouseLocation {
			[Export ("mouseLocation")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				CGPoint ret;
				ret = global::ObjCRuntime.Messaging.CGPoint_objc_msgSend (class_ptr, selMouseLocationXHandle);
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static nuint CurrentPressedMouseButtons {
			[Export ("pressedMouseButtons")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				nuint ret;
				ret = global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend (class_ptr, selPressedMouseButtonsXHandle);
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[DebuggerBrowsable (DebuggerBrowsableState.Never)]
		public virtual nint Data1 {
			[Export ("data1")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				nint ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selData1XHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (&__objc_super__, selData1XHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[DebuggerBrowsable (DebuggerBrowsableState.Never)]
		public virtual nint Data2 {
			[Export ("data2")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				nint ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selData2XHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (&__objc_super__, selData2XHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[DebuggerBrowsable (DebuggerBrowsableState.Never)]
		public virtual nfloat DeltaX {
			[Export ("deltaX")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				nfloat ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.nfloat_objc_msgSend (this.Handle, selDeltaXXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.nfloat_objc_msgSendSuper (&__objc_super__, selDeltaXXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[DebuggerBrowsable (DebuggerBrowsableState.Never)]
		public virtual nfloat DeltaY {
			[Export ("deltaY")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				nfloat ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.nfloat_objc_msgSend (this.Handle, selDeltaYXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.nfloat_objc_msgSendSuper (&__objc_super__, selDeltaYXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[DebuggerBrowsable (DebuggerBrowsableState.Never)]
		public virtual nfloat DeltaZ {
			[Export ("deltaZ")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				nfloat ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.nfloat_objc_msgSend (this.Handle, selDeltaZXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.nfloat_objc_msgSendSuper (&__objc_super__, selDeltaZXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[DebuggerBrowsable (DebuggerBrowsableState.Never)]
		public virtual nuint DeviceID {
			[Export ("deviceID")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				nuint ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend (this.Handle, selDeviceIDXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.UIntPtr_objc_msgSendSuper (&__objc_super__, selDeviceIDXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static double DoubleClickInterval {
			[Export ("doubleClickInterval")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				double ret;
				ret = global::ObjCRuntime.Messaging.Double_objc_msgSend (class_ptr, selDoubleClickIntervalXHandle);
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[DebuggerBrowsable (DebuggerBrowsableState.Never)]
		public virtual nint EventNumber {
			[Export ("eventNumber")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				nint ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selEventNumberXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (&__objc_super__, selEventNumberXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual nint EventRef {
			[Export ("eventRef")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				nint ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selEventRefXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (&__objc_super__, selEventRefXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[DebuggerBrowsable (DebuggerBrowsableState.Never)]
		public virtual bool HasPreciseScrollingDeltas {
			[Export ("hasPreciseScrollingDeltas")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selHasPreciseScrollingDeltasXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, selHasPreciseScrollingDeltasXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[DebuggerBrowsable (DebuggerBrowsableState.Never)]
		public virtual bool IsARepeat {
			[Export ("isARepeat")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selIsARepeatXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, selIsARepeatXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[DebuggerBrowsable (DebuggerBrowsableState.Never)]
		public virtual bool IsDirectionInvertedFromDevice {
			[Export ("isDirectionInvertedFromDevice")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selIsDirectionInvertedFromDeviceXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, selIsDirectionInvertedFromDeviceXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[DebuggerBrowsable (DebuggerBrowsableState.Never)]
		public virtual bool IsEnteringProximity {
			[Export ("isEnteringProximity")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selIsEnteringProximityXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, selIsEnteringProximityXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool IsSwipeTrackingFromScrollEventsEnabled {
			[Export ("isSwipeTrackingFromScrollEventsEnabled")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				byte ret;
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (class_ptr, selIsSwipeTrackingFromScrollEventsEnabledXHandle);
				return ret != 0;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[DebuggerBrowsable (DebuggerBrowsableState.Never)]
		public virtual ushort KeyCode {
			[Export ("keyCode")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				ushort ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.UInt16_objc_msgSend (this.Handle, selKeyCodeXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.UInt16_objc_msgSendSuper (&__objc_super__, selKeyCodeXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static double KeyRepeatDelay {
			[Export ("keyRepeatDelay")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				double ret;
				ret = global::ObjCRuntime.Messaging.Double_objc_msgSend (class_ptr, selKeyRepeatDelayXHandle);
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static double KeyRepeatInterval {
			[Export ("keyRepeatInterval")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				double ret;
				ret = global::ObjCRuntime.Messaging.Double_objc_msgSend (class_ptr, selKeyRepeatIntervalXHandle);
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[DebuggerBrowsable (DebuggerBrowsableState.Never)]
		public virtual CGPoint LocationInWindow {
			[Export ("locationInWindow")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				CGPoint ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.CGPoint_objc_msgSend (this.Handle, selLocationInWindowXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.CGPoint_objc_msgSendSuper (&__objc_super__, selLocationInWindowXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[DebuggerBrowsable (DebuggerBrowsableState.Never)]
		public virtual nfloat Magnification {
			[Export ("magnification")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				nfloat ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.nfloat_objc_msgSend (this.Handle, selMagnificationXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.nfloat_objc_msgSendSuper (&__objc_super__, selMagnificationXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSEventModifierMask ModifierFlags {
			[Export ("modifierFlags")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				NSEventModifierMask ret;
				if (IsDirectBinding) {
					ret = (NSEventModifierMask) (ulong) global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend (this.Handle, selModifierFlagsXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = (NSEventModifierMask) (ulong) global::ObjCRuntime.Messaging.UIntPtr_objc_msgSendSuper (&__objc_super__, selModifierFlagsXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[DebuggerBrowsable (DebuggerBrowsableState.Never)]
		public virtual NSEventPhase MomentumPhase {
			[Export ("momentumPhase")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				NSEventPhase ret;
				if (IsDirectBinding) {
					ret = (NSEventPhase) (ulong) global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend (this.Handle, selMomentumPhaseXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = (NSEventPhase) (ulong) global::ObjCRuntime.Messaging.UIntPtr_objc_msgSendSuper (&__objc_super__, selMomentumPhaseXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool MouseCoalescingEnabled {
			[Export ("isMouseCoalescingEnabled")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				byte ret;
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (class_ptr, selIsMouseCoalescingEnabledXHandle);
				return ret != 0;
			}
			[Export ("setMouseCoalescingEnabled:")]
			set {
				global::AppKit.NSApplication.EnsureUIThread ();
				global::ObjCRuntime.Messaging.void_objc_msgSend_bool (class_ptr, selSetMouseCoalescingEnabled_XHandle, value ? (byte) 1 : (byte) 0);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[DebuggerBrowsable (DebuggerBrowsableState.Never)]
		public virtual NSEventPhase Phase {
			[Export ("phase")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				NSEventPhase ret;
				if (IsDirectBinding) {
					ret = (NSEventPhase) (ulong) global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend (this.Handle, selPhaseXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = (NSEventPhase) (ulong) global::ObjCRuntime.Messaging.UIntPtr_objc_msgSendSuper (&__objc_super__, selPhaseXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[DebuggerBrowsable (DebuggerBrowsableState.Never)]
		public virtual nuint PointingDeviceSerialNumber {
			[Export ("pointingDeviceSerialNumber")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				nuint ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend (this.Handle, selPointingDeviceSerialNumberXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.UIntPtr_objc_msgSendSuper (&__objc_super__, selPointingDeviceSerialNumberXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[DebuggerBrowsable (DebuggerBrowsableState.Never)]
		public virtual NSPointingDeviceType PointingDeviceType {
			[Export ("pointingDeviceType")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				NSPointingDeviceType ret;
				if (IsDirectBinding) {
					ret = (NSPointingDeviceType) (ulong) global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend (this.Handle, selPointingDeviceTypeXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = (NSPointingDeviceType) (ulong) global::ObjCRuntime.Messaging.UIntPtr_objc_msgSendSuper (&__objc_super__, selPointingDeviceTypeXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[DebuggerBrowsable (DebuggerBrowsableState.Never)]
		public virtual float Pressure {
			[Export ("pressure")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				float ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.float_objc_msgSend (this.Handle, selPressureXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.float_objc_msgSendSuper (&__objc_super__, selPressureXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[DebuggerBrowsable (DebuggerBrowsableState.Never)]
		public virtual float Rotation {
			[Export ("rotation")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				float ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.float_objc_msgSend (this.Handle, selRotationXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.float_objc_msgSendSuper (&__objc_super__, selRotationXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[DebuggerBrowsable (DebuggerBrowsableState.Never)]
		public virtual nfloat ScrollingDeltaX {
			[Export ("scrollingDeltaX")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				nfloat ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.nfloat_objc_msgSend (this.Handle, selScrollingDeltaXXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.nfloat_objc_msgSendSuper (&__objc_super__, selScrollingDeltaXXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[DebuggerBrowsable (DebuggerBrowsableState.Never)]
		public virtual nfloat ScrollingDeltaY {
			[Export ("scrollingDeltaY")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				nfloat ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.nfloat_objc_msgSend (this.Handle, selScrollingDeltaYXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.nfloat_objc_msgSendSuper (&__objc_super__, selScrollingDeltaYXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual nint Stage {
			[Export ("stage")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				nint ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selStageXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (&__objc_super__, selStageXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual nfloat StageTransition {
			[Export ("stageTransition")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				nfloat ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.nfloat_objc_msgSend (this.Handle, selStageTransitionXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.nfloat_objc_msgSendSuper (&__objc_super__, selStageTransitionXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[DebuggerBrowsable (DebuggerBrowsableState.Never)]
		public virtual short Subtype {
			[Export ("subtype")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				short ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.short_objc_msgSend (this.Handle, selSubtypeXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.short_objc_msgSendSuper (&__objc_super__, selSubtypeXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[DebuggerBrowsable (DebuggerBrowsableState.Never)]
		public virtual nuint SystemTabletID {
			[Export ("systemTabletID")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				nuint ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend (this.Handle, selSystemTabletIDXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.UIntPtr_objc_msgSendSuper (&__objc_super__, selSystemTabletIDXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[DebuggerBrowsable (DebuggerBrowsableState.Never)]
		public virtual nuint TabletID {
			[Export ("tabletID")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				nuint ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend (this.Handle, selTabletIDXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.UIntPtr_objc_msgSendSuper (&__objc_super__, selTabletIDXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[DebuggerBrowsable (DebuggerBrowsableState.Never)]
		public virtual float TangentialPressure {
			[Export ("tangentialPressure")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				float ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.float_objc_msgSend (this.Handle, selTangentialPressureXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.float_objc_msgSendSuper (&__objc_super__, selTangentialPressureXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[DebuggerBrowsable (DebuggerBrowsableState.Never)]
		public virtual CGPoint Tilt {
			[Export ("tilt")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				CGPoint ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.CGPoint_objc_msgSend (this.Handle, selTiltXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.CGPoint_objc_msgSendSuper (&__objc_super__, selTiltXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual double Timestamp {
			[Export ("timestamp")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				double ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.Double_objc_msgSend (this.Handle, selTimestampXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.Double_objc_msgSendSuper (&__objc_super__, selTimestampXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[DebuggerBrowsable (DebuggerBrowsableState.Never)]
		public virtual NSTrackingArea TrackingArea {
			[Export ("trackingArea")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				NSTrackingArea? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSTrackingArea> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selTrackingAreaXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<NSTrackingArea> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selTrackingAreaXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[DebuggerBrowsable (DebuggerBrowsableState.Never)]
		public virtual nint TrackingNumber {
			[Export ("trackingNumber")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				nint ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selTrackingNumberXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (&__objc_super__, selTrackingNumberXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSEventType Type {
			[Export ("type")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				NSEventType ret;
				if (IsDirectBinding) {
					ret = (NSEventType) (ulong) global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend (this.Handle, selTypeXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = (NSEventType) (ulong) global::ObjCRuntime.Messaging.UIntPtr_objc_msgSendSuper (&__objc_super__, selTypeXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[DebuggerBrowsable (DebuggerBrowsableState.Never)]
		public virtual long UniqueID {
			[Export ("uniqueID")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				long ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.Int64_objc_msgSend (this.Handle, selUniqueIDXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.Int64_objc_msgSendSuper (&__objc_super__, selUniqueIDXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[DebuggerBrowsable (DebuggerBrowsableState.Never)]
		public virtual nint UserData {
			[Export ("userData")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				nint ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selUserDataXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (&__objc_super__, selUserDataXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[DebuggerBrowsable (DebuggerBrowsableState.Never)]
		public virtual NSObject VendorDefined {
			[Export ("vendorDefined")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				NSObject? ret;
				if (IsDirectBinding) {
					ret = Runtime.GetNSObject (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selVendorDefinedXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = Runtime.GetNSObject (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selVendorDefinedXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[DebuggerBrowsable (DebuggerBrowsableState.Never)]
		public virtual nuint VendorID {
			[Export ("vendorID")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				nuint ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend (this.Handle, selVendorIDXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.UIntPtr_objc_msgSendSuper (&__objc_super__, selVendorIDXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[DebuggerBrowsable (DebuggerBrowsableState.Never)]
		public virtual nuint VendorPointingDeviceType {
			[Export ("vendorPointingDeviceType")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				nuint ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend (this.Handle, selVendorPointingDeviceTypeXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.UIntPtr_objc_msgSendSuper (&__objc_super__, selVendorPointingDeviceTypeXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSWindow Window {
			[Export ("window")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				NSWindow? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSWindow> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selWindowXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<NSWindow> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selWindowXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual nint WindowNumber {
			[Export ("windowNumber")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				nint ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selWindowNumberXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (&__objc_super__, selWindowNumberXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
	} /* class NSEvent */
}
