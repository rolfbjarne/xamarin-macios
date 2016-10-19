
#if !__WATCHOS__
#define AUDIOTOOLBOX
#define AUDIOUNIT
#define COREMEDIA
#define MEDIATOOLBOX
#endif

#if __IOS__ || __TVOS__
#define AUDIOTOOLBOX_MUSICSEQUENCE
#endif

#if !__TVOS__ && !__WATCHOS__ && !MONOMAC
#define ADDRESSBOOK
#endif

#if !__TVOS__ && !__WATCHOS__
#define COREMIDI
#endif

#if !__WATCHOS__
#define COREVIDEO
#endif

#if MONOMAC
#define OPENGL
#endif

#if IKVM
using IKVM.Reflection;
using Type=IKVM.Reflection.Type;
#else
using System.Reflection;
using Type=System.Type;

using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.InteropServices;

using DictionaryContainerType = XamCore.Foundation.DictionaryContainer;


using XamCore.CoreGraphics;
using XamCore.Foundation;
#if !__UNIFIED__
using XamCore;
#endif
using XamCore.ObjCRuntime;
#if COREMEDIA
using XamCore.CoreMedia;
#endif
using XamCore.CoreFoundation;
using XamCore.Security;
using XamCore.AVFoundation;
#if COREVIDEO
using XamCore.CoreVideo;
#endif
using XamCore.AudioToolbox;
#if AUDIOUNIT
using XamCore.AudioUnit;
#endif
#if MEDIATOOLBOX
using XamCore.MediaToolbox;
#endif
#if ADDRESSBOOK
using XamCore.AddressBook;
#endif
#if COREMIDI
using XamCore.CoreMidi;
#endif
#if OPENGL
using XamCore.OpenGL;
#endif
#endif

public static class AttributeManager
{
	public static System.Attribute GetCustomAttribute (MemberInfo provider, Type type)
	{
#if IKVM
		throw new System.NotImplementedException ();
#else
		return System.Attribute.GetCustomAttribute (provider, type);
#endif
	}

	public static System.Attribute [] GetCustomAttributes (ICustomAttributeProvider provider, Type type, bool inherits)
	{
#if IKVM
		throw new System.NotImplementedException ();
		//return CustomAttributeData.GetCustomAttributes (provider, type);
#else
		return (System.Attribute []) provider.GetCustomAttributes (type, inherits);
#endif
	}

	public static object [] GetCustomAttributes (ICustomAttributeProvider provider, bool inherits)
	{
#if IKVM
		throw new System.NotImplementedException ();
		//return CustomAttributeData.GetCustomAttributes ((MemberInfo) provider);
#else
		return provider.GetCustomAttributes (inherits);
#endif
	}

	public static bool HasAttribute (ICustomAttributeProvider provider, bool inherits, params Type [] any_attribute_type)
	{
		var attribs = GetCustomAttributes (provider, inherits);
		if (attribs == null || attribs.Length == 0)
			return false;

		foreach (var attrib in attribs) {
			var attribType = GetAttributeType ((System.Attribute) attrib);
			for (int t = 0; t < any_attribute_type.Length; t++) {
				if (any_attribute_type [t] == attribType) {
					//System.Console.WriteLine ("Has exact attribute: {0}", provider);
					return true;
				}
				if (TypeManager.IsSubclassOf (any_attribute_type [t], attribType)) {
					//System.Console.WriteLine ("Has attribute: {0}", provider);
					return true;
				} else {
					//System.Console.WriteLine ("Attribute check: {0} {1} is not of {2}", provider, any_attribute_type [t], attribType);
				}
			}
		}
		//System.Console.WriteLine ("No attribute: {0}", provider);
		return false;
	}

	public static bool HasAttribute (ICustomAttributeProvider provider, Type attribute_type, bool inherits = false)
	{
		var attribs = GetCustomAttributes (provider, inherits);
		if (attribs == null || attribs.Length == 0) {
			//Console.WriteLine ("No {0} for {1}", attribute_type, provider);
			return false;
		}

		foreach (var attrib in attribs) {
			var attribType = GetAttributeType ((System.Attribute) attrib);
			if (attribute_type == attribType)
				return true;
			if (TypeManager.IsSubclassOf (attribute_type, attribType))
				return true;
		}

		return false;
	}

	public static Type GetAttributeType (System.Attribute attribute)
	{
#if IKVM
		throw new System.NotImplementedException ();
#else
		return attribute.GetType ();
#endif
	}

	public static ICustomAttributeProvider GetReturnTypeCustomAttributes (MethodInfo method)
	{
#if IKVM
		throw new System.NotImplementedException ();
#else
		return method.ReturnTypeCustomAttributes;
#endif
	}

	public static Type GetAttributeType (System.Type type)
	{
#if IKVM
		throw new System.NotImplementedException ();
#else
		return type;
#endif
	}
}

public static class TypeManager {
	public static Type System_Object { get; set; }
	public static Type System_Int32 { get; set; }
	public static Type System_Int64 { get; set; }
	public static Type System_UInt32 { get; set; }
	public static Type System_UInt64 { get; set; }
	public static Type System_Int16 { get; set; }
	public static Type System_UInt16 { get; set; }
	public static Type System_Byte { get; set; }
	public static Type System_SByte { get; set; }
	public static Type System_Double { get; set; }
	public static Type System_Float { get; set; }
	public static Type System_Boolean {get; set; }
	public static Type System_IntPtr { get; set; }
	public static Type System_nint { get; set; }
	public static Type System_nuint { get; set; }
	public static Type System_nfloat { get; set; }
	public static Type System_Void { get; set; }
	public static Type System_String { get; set; }
	public static Type System_String_Array { get; set; }
	public static Type System_Delegate { get; set; }
	public static Type System_Attribute;

	public static Type NSObject { get; set; }
	public static Type INativeObject { get; set; }
	public static Type Selector { get; set; }
	public static Type BlockLiteral { get; set; }
	public static Type Class;
	public static Type Protocol;
	public static Type Constants;

	public static Type LinkWithAttribute { get; set; }
	public static Type BaseTypeAttribute { get; set; }
	public static Type ProtocolAttribute { get; set; }
	public static Type StaticAttribute { get; set; }
	public static Type PartialAttribute { get; set; }
	public static Type StrongDictionaryAttribute { get; set; }
	public static Type FlagsAttribute { get; set; }
	public static Type AbstractAttribute { get; set; }
	public static Type NativeAttribute { get; set; }
	public static Type BlockCallbackAttribute { get; set; }
	public static Type CCallbackAttribute { get; set; }
	public static Type NullAllowedAttribute { get; set; }
	public static Type OutAttribute { get; set; }
	public static Type BindAttribute { get; set; }
	public static Type MarshalNativeExceptionsAttribute { get; set; }
	public static Type TargetAttribute { get; set; }
	public static Type WrapAttribute { get; set; }
	public static Type AlignAttribute { get; set; }
	public static Type ExportAttribute { get; set; }
	public static Type TransientAttribute { get; set; }
	public static Type IsThreadStaticAttribute;
	public static Type FieldAttribute;
	public static Type CoreImageFilterPropertyAttribute;
	public static Type AvailabilityBaseAttribute;
	public static Type RegisterAttribute;
	public static Type ModelAttribute;
	public static Type ProtocolizeAttribute;
	public static Type ParamsAttribute;
	public static Type ParamArrayAttribute;
	public static Type PrologueSnippetAttribute;
	public static Type PreSnippetAttribute;
	public static Type PostGetAttribute;
	public static Type FactoryAttribute;
	public static Type SyntheticAttribute;
	public static Type ProxyAttribute;
	public static Type PostSnippetAttribute;
	public static Type ThreadSafeAttribute;
	public static Type DesignatedInitializerAttribute;
	public static Type ManualAttribute;
	public static Type RetainAttribute;
	public static Type AsyncAttribute;
	public static Type NotImplementedAttribute;
	public static Type ZeroCopyStringsAttribute;
	public static Type CoreImageFilterAttribute;
	public static Type AdvancedAttribute;
	public static Type AppearanceAttribute;
	public static Type NotificationAttribute;
	public static Type NoDefaultValueAttribute;
	public static Type CheckDisposedAttribute;
	public static Type EventNameAttribute;
	public static Type DelegateApiNameAttribute;
	public static Type EventArgsAttribute;
	public static Type DelegateNameAttribute;
	public static Type DefaultValueAttribute;
	public static Type DefaultValueFromArgumentAttribute;
	public static Type CategoryAttribute;
	public static Type DisposeAttribute;
	public static Type InternalAttribute;
	public static Type UnifiedInternalAttribute;
	public static Type ProtectedAttribute;
	public static Type OverrideAttribute;
	public static Type NewAttribute;
	public static Type SealedAttribute;
	public static Type AutoreleaseAttribute;
	public static Type DisableZeroCopyAttribute;
	public static Type PlainStringAttribute;
	public static Type ReleaseAttribute;
#if !__UNIFIED__
	public static Type AlphaAttribute;
#endif

	public static Type FieldOffsetAttribute;
	public static Type MarshalAsAttribute;
	public static Type EditorBrowsableAttribute;
	public static Type OptionalImplementationAttribute;
	public static Type DebuggerDisplayAttribute;
	public static Type DebuggerBrowsableAttribute;
	public static Type ObsoleteAttribute;

	public static Type DictionaryContainerType { get; set; }

	public static Type AudioBuffers { get; set; }
	public static Type MusicSequence { get; set; }
	public static Type CMSampleBuffer;
	public static Type CGColor;
	public static Type CGPath;
	public static Type CGGradient;
	public static Type CGContext;
	public static Type CGImage;
	public static Type CGColorSpace;
	public static Type DispatchQueue;
	public static Type MidiEndpoint;
	public static Type CMTimebase;
	public static Type CMClock;
	public static Type NSZone;
	public static Type ABAddressBook;
	public static Type ABPerson;
	public static Type ABRecord;
	public static Type MTAudioProcessingTap;
	public static Type CVPixelBuffer;
	public static Type CGLayer;
	public static Type CVImageBuffer;
	public static Type CVPixelBufferPool;
	public static Type AudioComponent;
	public static Type CMFormatDescription;
	public static Type CMAudioFormatDescription;
	public static Type CMVideoFormatDescription;
	public static Type SecIdentity;
	public static Type SecTrust;
	public static Type SecAccessControl;
	public static Type AURenderEventEnumerator;
	public static Type CFRunLoop;
	public static Type AudioUnit;

#if __UNIFIED__
	public static Type CGRect;
	public static Type CGPoint;
	public static Type CGSize;
#endif

	public static Type CMTime;
	public static Type NSString;
	public static Type ProbePresenceAttribute;
	public static Type AVCaptureWhiteBalanceGains;
	public static Type CGLContext;
	public static Type CGLPixelFormat;

	public static bool IsSubclassOf (Type base_class, Type derived_class)
	{
#if IKVM
		throw new System.NotImplementedException ();
#else
		return base_class.IsSubclassOf (derived_class);
#endif
	}

	static TypeManager ()
	{
#if IKVM

#else
	System_Object = typeof (object);
	System_Int32 = typeof (int);
	System_Int64 = typeof (long);
	System_UInt32 = typeof (uint);
	System_UInt64 = typeof (ulong);
	System_Int16 = typeof (short);
	System_UInt16 = typeof (ushort);
	System_Byte = typeof (byte);
	System_SByte = typeof (sbyte);
	System_Double = typeof (double);
	System_Float = typeof (float);
	System_Boolean = typeof (bool);
	System_IntPtr = typeof (System.IntPtr);

	System_Void = typeof (void);
	System_String = typeof (string);
	System_String_Array = typeof (string[]);
	System_Delegate = typeof (System.Delegate);
	System_Attribute = typeof (System.Attribute);

	NSObject = typeof (NSObject);
	INativeObject = typeof (INativeObject);
	Selector = typeof (Selector);
	BlockLiteral = typeof (BlockLiteral);
	Class = typeof (Class);
	Protocol = typeof (Protocol);

#if __UNIFIED__
	Constants = typeof (XamCore.ObjCRuntime.Constants);
#else
	Constants = typeof (XamCore.Constants);
#endif

	LinkWithAttribute = typeof (LinkWithAttribute);
	BaseTypeAttribute = typeof (BaseTypeAttribute);
	ProtocolAttribute = typeof (ProtocolAttribute);
	StaticAttribute = typeof (StaticAttribute);
	PartialAttribute = typeof (PartialAttribute);
	StrongDictionaryAttribute = typeof (StrongDictionaryAttribute);
	FlagsAttribute = typeof (FlagsAttribute);
	AbstractAttribute = typeof (AbstractAttribute);
	NativeAttribute = typeof (NativeAttribute);
	BlockCallbackAttribute = typeof (BlockCallbackAttribute);
	CCallbackAttribute = typeof (CCallbackAttribute);
	NullAllowedAttribute = typeof (NullAllowedAttribute);
	OutAttribute = typeof (OutAttribute);
	BindAttribute = typeof (BindAttribute);
	MarshalNativeExceptionsAttribute = typeof (MarshalNativeExceptionsAttribute);
	TargetAttribute = typeof (TargetAttribute);
	WrapAttribute = typeof (WrapAttribute);
	AlignAttribute = typeof (AlignAttribute);
	ExportAttribute = typeof (ExportAttribute);
	TransientAttribute = typeof (TransientAttribute);
	IsThreadStaticAttribute = typeof (IsThreadStaticAttribute);
	FieldAttribute = typeof (FieldAttribute);
	CoreImageFilterPropertyAttribute = typeof (CoreImageFilterPropertyAttribute);
	AvailabilityBaseAttribute = typeof (AvailabilityBaseAttribute);
	RegisterAttribute = typeof (RegisterAttribute);
	ModelAttribute = typeof (ModelAttribute);
	ProtocolizeAttribute = typeof (ProtocolizeAttribute);
	ParamsAttribute = typeof (ParamsAttribute);
	ParamArrayAttribute = typeof (ParamArrayAttribute);
	PrologueSnippetAttribute = typeof (PrologueSnippetAttribute);
	PreSnippetAttribute = typeof (PreSnippetAttribute);
	PostGetAttribute = typeof (PostGetAttribute);
	FactoryAttribute = typeof (FactoryAttribute);
	SyntheticAttribute = typeof (SyntheticAttribute);
	ProxyAttribute = typeof (ProxyAttribute);
	PostSnippetAttribute = typeof (PostSnippetAttribute);
	ThreadSafeAttribute = typeof (ThreadSafeAttribute);
	DesignatedInitializerAttribute = typeof (DesignatedInitializerAttribute);
	ManualAttribute = typeof (ManualAttribute);
	RetainAttribute = typeof (RetainAttribute);
	AsyncAttribute = typeof (AsyncAttribute);
	NotImplementedAttribute = typeof (NotImplementedAttribute);
	ZeroCopyStringsAttribute = typeof (ZeroCopyStringsAttribute);
	CoreImageFilterAttribute = typeof (CoreImageFilterAttribute);
	AdvancedAttribute = typeof (AdvancedAttribute);
	AppearanceAttribute = typeof (AppearanceAttribute);
	NotificationAttribute = typeof (NotificationAttribute);
	NoDefaultValueAttribute = typeof (NoDefaultValueAttribute);
	CheckDisposedAttribute = typeof (CheckDisposedAttribute);
	EventNameAttribute = typeof (EventNameAttribute);
	DelegateApiNameAttribute = typeof (DelegateApiNameAttribute);
	EventArgsAttribute = typeof (EventArgsAttribute);
	DelegateNameAttribute = typeof (DelegateNameAttribute);
	DefaultValueAttribute = typeof (DefaultValueAttribute);
	DefaultValueFromArgumentAttribute = typeof (DefaultValueFromArgumentAttribute);
	CategoryAttribute = typeof (CategoryAttribute);
	DisposeAttribute = typeof (DisposeAttribute);
	InternalAttribute = typeof (InternalAttribute);
	UnifiedInternalAttribute = typeof (UnifiedInternalAttribute);
	ProtectedAttribute = typeof (ProtectedAttribute);
	OverrideAttribute = typeof (OverrideAttribute);
	NewAttribute = typeof (NewAttribute);
	SealedAttribute = typeof (SealedAttribute);
	AutoreleaseAttribute = typeof (AutoreleaseAttribute);
	DisableZeroCopyAttribute = typeof (DisableZeroCopyAttribute);
	PlainStringAttribute = typeof (PlainStringAttribute);
	ReleaseAttribute = typeof (ReleaseAttribute);
#if !__UNIFIED__
	AlphaAttribute = typeof (AlphaAttribute);
#endif

	FieldOffsetAttribute = typeof (FieldOffsetAttribute);
	MarshalAsAttribute = typeof (MarshalAsAttribute);
	EditorBrowsableAttribute = typeof (EditorBrowsableAttribute);
	OptionalImplementationAttribute = typeof (OptionalImplementationAttribute);
	DebuggerDisplayAttribute = typeof (DebuggerDisplayAttribute);
	DebuggerBrowsableAttribute = typeof (DebuggerBrowsableAttribute);
	ObsoleteAttribute = typeof (ObsoleteAttribute);

	DictionaryContainerType = typeof (DictionaryContainerType);

#if AUDIOTOOLBOX
	AudioBuffers = typeof (AudioBuffers);
#if AUDIOTOOLBOX_MUSICSEQUENCE
	MusicSequence = typeof (MusicSequence);
#endif
#endif

#if COREMEDIA
	CMSampleBuffer = typeof (CMSampleBuffer);
	CMTimebase = typeof (CMTimebase);
	CMClock = typeof (CMClock);
#endif
	CGColor = typeof (CGColor);
	CGPath = typeof (CGPath);
	CGGradient = typeof (CGGradient);
	CGContext = typeof (CGContext);
	CGImage = typeof (CGImage);
	CGColorSpace = typeof (CGColorSpace);
	DispatchQueue = typeof (DispatchQueue);
#if COREMIDI
	MidiEndpoint = typeof (MidiEndpoint);
#endif
#if ADDRESSBOOK
	ABAddressBook = typeof (ABAddressBook);
	ABPerson = typeof (ABPerson);
	ABRecord = typeof (ABRecord);
#endif

	NSZone = typeof (NSZone);
#if MEDIATOOLBOX
	MTAudioProcessingTap = typeof (MTAudioProcessingTap);
#endif
#if COREVIDEO
	CVImageBuffer = typeof (CVImageBuffer);
	CVPixelBufferPool = typeof (CVPixelBufferPool);
	CVPixelBuffer = typeof (CVPixelBuffer);
#endif
	CGLayer = typeof (CGLayer);
#if COREMEDIA
	CMTime = typeof (CMTime);
	CMFormatDescription = typeof (CMFormatDescription);
	CMAudioFormatDescription = typeof (CMAudioFormatDescription);
	CMVideoFormatDescription = typeof (CMVideoFormatDescription);
#endif
	SecIdentity = typeof (SecIdentity);
	SecTrust = typeof (SecTrust);
	SecAccessControl = typeof (SecAccessControl);
#if AUDIOUNIT
	AudioComponent = typeof (AudioComponent);
	AURenderEventEnumerator = typeof (AURenderEventEnumerator);
	AudioUnit = typeof (XamCore.AudioUnit.AudioUnit);
#endif

	// CoreFoundation
	CFRunLoop = typeof (CFRunLoop);



#if __UNIFIED__
	CGRect = typeof (CGRect);
	CGPoint = typeof (CGPoint);
	CGSize = typeof (CGSize);
#endif

	NSString = typeof (NSString);

	ProbePresenceAttribute = typeof (ProbePresenceAttribute);
	AVCaptureWhiteBalanceGains = typeof (AVCaptureWhiteBalanceGains);
#if OPENGL
	CGLContext = typeof (CGLContext);
	CGLPixelFormat = typeof (CGLPixelFormat);
#endif

#if __UNIFIED__
	System_nint = typeof (System.nint);
	System_nuint = typeof (System.nuint);
	System_nfloat = typeof (System.nfloat);
#endif
#endif // IKVM
	}

	public static Type GetUnderlyingEnumType (Type type)
	{
#if IKVM
		throw new System.NotImplementedException ();
#else
		return Enum.GetUnderlyingType (type);
#endif
	}

	public static bool IsEnumValueDefined (Type type, object value)
	{
#if IKVM
		throw new System.NotImplementedException ();
#else
		var enumValue = System.Enum.ToObject (type, value);
		return System.Array.IndexOf (System.Enum.GetValues (type), enumValue) >= 0;

#endif
		}
}