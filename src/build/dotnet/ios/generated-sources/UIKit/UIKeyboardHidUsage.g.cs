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
namespace UIKit {
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios13.4")]
	[SupportedOSPlatform ("tvos13.4")]
	[Native ("UIKeyboardHIDUsage")]
	public enum UIKeyboardHidUsage : long {
		KeyboardErrorRollOver = 1,
		KeyboardPostFail = 2,
		KeyboardErrorUndefined = 3,
		KeyboardA = 4,
		KeyboardB = 5,
		KeyboardC = 6,
		KeyboardD = 7,
		KeyboardE = 8,
		KeyboardF = 9,
		KeyboardG = 10,
		KeyboardH = 11,
		KeyboardI = 12,
		KeyboardJ = 13,
		KeyboardK = 14,
		KeyboardL = 15,
		KeyboardM = 16,
		KeyboardN = 17,
		KeyboardO = 18,
		KeyboardP = 19,
		KeyboardQ = 20,
		KeyboardR = 21,
		KeyboardS = 22,
		KeyboardT = 23,
		KeyboardU = 24,
		KeyboardV = 25,
		KeyboardW = 26,
		KeyboardX = 27,
		KeyboardY = 28,
		KeyboardZ = 29,
		Keyboard1 = 30,
		Keyboard2 = 31,
		Keyboard3 = 32,
		Keyboard4 = 33,
		Keyboard5 = 34,
		Keyboard6 = 35,
		Keyboard7 = 36,
		Keyboard8 = 37,
		Keyboard9 = 38,
		Keyboard0 = 39,
		KeyboardReturnOrEnter = 40,
		KeyboardEscape = 41,
		KeyboardDeleteOrBackspace = 42,
		KeyboardTab = 43,
		KeyboardSpacebar = 44,
		KeyboardHyphen = 45,
		KeyboardEqualSign = 46,
		KeyboardOpenBracket = 47,
		KeyboardCloseBracket = 48,
		KeyboardBackslash = 49,
		KeyboardNonUSPound = 50,
		KeyboardSemicolon = 51,
		KeyboardQuote = 52,
		KeyboardGraveAccentAndTilde = 53,
		KeyboardComma = 54,
		KeyboardPeriod = 55,
		KeyboardSlash = 56,
		KeyboardCapsLock = 57,
		KeyboardF1 = 58,
		KeyboardF2 = 59,
		KeyboardF3 = 60,
		KeyboardF4 = 61,
		KeyboardF5 = 62,
		KeyboardF6 = 63,
		KeyboardF7 = 64,
		KeyboardF8 = 65,
		KeyboardF9 = 66,
		KeyboardF10 = 67,
		KeyboardF11 = 68,
		KeyboardF12 = 69,
		KeyboardPrintScreen = 70,
		KeyboardScrollLock = 71,
		KeyboardPause = 72,
		KeyboardInsert = 73,
		KeyboardHome = 74,
		KeyboardPageUp = 75,
		KeyboardDeleteForward = 76,
		KeyboardEnd = 77,
		KeyboardPageDown = 78,
		KeyboardRightArrow = 79,
		KeyboardLeftArrow = 80,
		KeyboardDownArrow = 81,
		KeyboardUpArrow = 82,
		KeypadNumLock = 83,
		KeypadSlash = 84,
		KeypadAsterisk = 85,
		KeypadHyphen = 86,
		KeypadPlus = 87,
		KeypadEnter = 88,
		Keypad1 = 89,
		Keypad2 = 90,
		Keypad3 = 91,
		Keypad4 = 92,
		Keypad5 = 93,
		Keypad6 = 94,
		Keypad7 = 95,
		Keypad8 = 96,
		Keypad9 = 97,
		Keypad0 = 98,
		KeypadPeriod = 99,
		KeyboardNonUSBackslash = 100,
		KeyboardApplication = 101,
		KeyboardPower = 102,
		KeypadEqualSign = 103,
		KeyboardF13 = 104,
		KeyboardF14 = 105,
		KeyboardF15 = 106,
		KeyboardF16 = 107,
		KeyboardF17 = 108,
		KeyboardF18 = 109,
		KeyboardF19 = 110,
		KeyboardF20 = 111,
		KeyboardF21 = 112,
		KeyboardF22 = 113,
		KeyboardF23 = 114,
		KeyboardF24 = 115,
		KeyboardExecute = 116,
		KeyboardHelp = 117,
		KeyboardMenu = 118,
		KeyboardSelect = 119,
		KeyboardStop = 120,
		KeyboardAgain = 121,
		KeyboardUndo = 122,
		KeyboardCut = 123,
		KeyboardCopy = 124,
		KeyboardPaste = 125,
		KeyboardFind = 126,
		KeyboardMute = 127,
		KeyboardVolumeUp = 128,
		KeyboardVolumeDown = 129,
		KeyboardLockingCapsLock = 130,
		KeyboardLockingNumLock = 131,
		KeyboardLockingScrollLock = 132,
		KeypadComma = 133,
		KeypadEqualSignAS400 = 134,
		KeyboardInternational1 = 135,
		KeyboardInternational2 = 136,
		KeyboardInternational3 = 137,
		KeyboardInternational4 = 138,
		KeyboardInternational5 = 139,
		KeyboardInternational6 = 140,
		KeyboardInternational7 = 141,
		KeyboardInternational8 = 142,
		KeyboardInternational9 = 143,
		KeyboardLang1 = 144,
		KeyboardLang2 = 145,
		KeyboardLang3 = 146,
		KeyboardLang4 = 147,
		KeyboardLang5 = 148,
		KeyboardLang6 = 149,
		KeyboardLang7 = 150,
		KeyboardLang8 = 151,
		KeyboardLang9 = 152,
		KeyboardAlternateErase = 153,
		KeyboardSysReqOrAttention = 154,
		KeyboardCancel = 155,
		KeyboardClear = 156,
		KeyboardPrior = 157,
		KeyboardReturn = 158,
		KeyboardSeparator = 159,
		KeyboardOut = 160,
		KeyboardOper = 161,
		KeyboardClearOrAgain = 162,
		KeyboardCrSelOrProps = 163,
		KeyboardExSel = 164,
		KeyboardLeftControl = 224,
		KeyboardLeftShift = 225,
		KeyboardLeftAlt = 226,
		KeyboardLeftGui = 227,
		KeyboardRightControl = 228,
		KeyboardRightShift = 229,
		KeyboardRightAlt = 230,
		KeyboardRightGui = 231,
		KeyboardReserved = 65535,
		KeyboardHangul = 144,
		KeyboardHanja = 145,
		KeyboardKanaSwitch = 144,
		KeyboardAlphanumericSwitch = 145,
		KeyboardKatakana = 146,
		KeyboardHiragana = 147,
		KeyboardZenkakuHankakuKanji = 148,
	}
}
