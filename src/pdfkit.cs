//
// Copyright 2011, Novell, Inc.
// Copyright 2011, Regan Sarwas
//
//
// Permission is hereby granted, free of charge, to any person obtaining
// a copy of this software and associated documentation files (the
// "Software"), to deal in the Software without restriction, including
// without limitation the rights to use, copy, modify, merge, publish,
// distribute, sublicense, and/or sell copies of the Software, and to
// permit persons to whom the Software is furnished to do so, subject to
// the following conditions:
// 
// The above copyright notice and this permission notice shall be
// included in all copies or substantial portions of the Software.
// 
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND,
// EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF
// MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND
// NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE
// LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION
// OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION
// WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.
//

//
// PdfKit.cs: Bindings for the PdfKit API
//

#if MONOMAC
using AppKit;
using UIViewController = Foundation.NSObject;
using UIFindInteraction = Foundation.NSObject;
using UIFindInteractionDelegate = Foundation.NSObject;
using UIView = AppKit.NSView;
#else
using UIKit;
using NSColor = UIKit.UIColor;
using NSFont = UIKit.UIFont;
using NSImage = UIKit.UIImage;
using NSView = UIKit.UIView;
using NSEdgeInsets = UIKit.UIEdgeInsets;
using NSEvent = UIKit.UIEvent;
using NSBezierPath = UIKit.UIBezierPath;
using NSTextAlignment = UIKit.UITextAlignment;
// HACK: to make intermediate dll build, since we use these 
// types in a few [NoiOS] members (this way we avoid numerous #ifdefs later)
using NSPrintInfo = Foundation.NSObject;
using NSPrintOperation = Foundation.NSObject;
#endif
using CoreGraphics;
using System.ComponentModel;

// Verify/Test Delegate Models
// Check for missing NullAllowed on all object properties
// Test methods returning typed arrays in lieu of NSArray
// Check classes with no public inits - Should I make the constructors private?
// Check the few abnormal properties

namespace PdfKit {

	[MacCatalyst (13, 1)]
	[TV (18, 2)]
	enum PdfAnnotationKey {

		/// <summary>The appearance dictionary value.</summary>
		[Field ("PDFAnnotationKeyAppearanceDictionary", "+PDFKit")]
		AppearanceDictionary,

		/// <summary>The appearance state value.</summary>
		[Field ("PDFAnnotationKeyAppearanceState", "+PDFKit")]
		AppearanceState,

		/// <summary>The border value.</summary>
		[Field ("PDFAnnotationKeyBorder", "+PDFKit")]
		Border,

		/// <summary>The color value.</summary>
		[Field ("PDFAnnotationKeyColor", "+PDFKit")]
		Color,

		/// <summary>The contents value.</summary>
		[Field ("PDFAnnotationKeyContents", "+PDFKit")]
		Contents,

		/// <summary>The flags value.</summary>
		[Field ("PDFAnnotationKeyFlags", "+PDFKit")]
		Flags,

		/// <summary>The date value.</summary>
		[Field ("PDFAnnotationKeyDate", "+PDFKit")]
		Date,

		/// <summary>The name value.</summary>
		[Field ("PDFAnnotationKeyName", "+PDFKit")]
		Name,

		/// <summary>The page value.</summary>
		[Field ("PDFAnnotationKeyPage", "+PDFKit")]
		Page,

		/// <summary>The rect value.</summary>
		[Field ("PDFAnnotationKeyRect", "+PDFKit")]
		Rect,

		/// <summary>The subtype value.</summary>
		[Field ("PDFAnnotationKeySubtype", "+PDFKit")]
		Subtype,

		/// <summary>The action value.</summary>
		[Field ("PDFAnnotationKeyAction", "+PDFKit")]
		Action,

		/// <summary>The additional actions value.</summary>
		[Field ("PDFAnnotationKeyAdditionalActions", "+PDFKit")]
		AdditionalActions,

		/// <summary>The border style value.</summary>
		[Field ("PDFAnnotationKeyBorderStyle", "+PDFKit")]
		BorderStyle,

		/// <summary>The default appearance value.</summary>
		[Field ("PDFAnnotationKeyDefaultAppearance", "+PDFKit")]
		DefaultAppearance,

		/// <summary>The destination value.</summary>
		[Field ("PDFAnnotationKeyDestination", "+PDFKit")]
		Destination,

		/// <summary>The highlighting mode value.</summary>
		[Field ("PDFAnnotationKeyHighlightingMode", "+PDFKit")]
		HighlightingMode,

		/// <summary>The inklist value.</summary>
		[Field ("PDFAnnotationKeyInklist", "+PDFKit")]
		Inklist,

		/// <summary>The interior color value.</summary>
		[Field ("PDFAnnotationKeyInteriorColor", "+PDFKit")]
		InteriorColor,

		/// <summary>The line points value.</summary>
		[Field ("PDFAnnotationKeyLinePoints", "+PDFKit")]
		LinePoints,

		/// <summary>The line ending styles value.</summary>
		[Field ("PDFAnnotationKeyLineEndingStyles", "+PDFKit")]
		LineEndingStyles,

		/// <summary>The icon name value.</summary>
		[Field ("PDFAnnotationKeyIconName", "+PDFKit")]
		IconName,

		/// <summary>The open value.</summary>
		[Field ("PDFAnnotationKeyOpen", "+PDFKit")]
		Open,

		/// <summary>The parent value.</summary>
		[Field ("PDFAnnotationKeyParent", "+PDFKit")]
		Parent,

		/// <summary>The popup value.</summary>
		[Field ("PDFAnnotationKeyPopup")]
		Popup,

		/// <summary>The quadding value.</summary>
		[Field ("PDFAnnotationKeyQuadding", "+PDFKit")]
		Quadding,

		/// <summary>The quad points value.</summary>
		[Field ("PDFAnnotationKeyQuadPoints", "+PDFKit")]
		QuadPoints,

		/// <summary>The text label value.</summary>
		[Field ("PDFAnnotationKeyTextLabel", "+PDFKit")]
		TextLabel,

		/// <summary>The widget down caption value.</summary>
		[Field ("PDFAnnotationKeyWidgetDownCaption", "+PDFKit")]
		WidgetDownCaption,

		/// <summary>The widget border color value.</summary>
		[Field ("PDFAnnotationKeyWidgetBorderColor", "+PDFKit")]
		WidgetBorderColor,

		/// <summary>The widget background color value.</summary>
		[Field ("PDFAnnotationKeyWidgetBackgroundColor", "+PDFKit")]
		WidgetBackgroundColor,

		/// <summary>The widget caption value.</summary>
		[Field ("PDFAnnotationKeyWidgetCaption", "+PDFKit")]
		WidgetCaption,

		/// <summary>The widget default value value.</summary>
		[Field ("PDFAnnotationKeyWidgetDefaultValue", "+PDFKit")]
		WidgetDefaultValue,

		/// <summary>The widget field flags value.</summary>
		[Field ("PDFAnnotationKeyWidgetFieldFlags", "+PDFKit")]
		WidgetFieldFlags,

		/// <summary>The widget field type value.</summary>
		[Field ("PDFAnnotationKeyWidgetFieldType", "+PDFKit")]
		WidgetFieldType,

		/// <summary>The widget appearance dictionary value.</summary>
		[Field ("PDFAnnotationKeyWidgetAppearanceDictionary", "+PDFKit")]
		WidgetAppearanceDictionary,

		/// <summary>The widget max len value.</summary>
		[Field ("PDFAnnotationKeyWidgetMaxLen", "+PDFKit")]
		WidgetMaxLen,

		/// <summary>The widget options value.</summary>
		[Field ("PDFAnnotationKeyWidgetOptions", "+PDFKit")]
		WidgetOptions,

		/// <summary>The widget rotation value.</summary>
		[Field ("PDFAnnotationKeyWidgetRotation", "+PDFKit")]
		WidgetRotation,

		/// <summary>The widget rollover caption value.</summary>
		[Field ("PDFAnnotationKeyWidgetRolloverCaption", "+PDFKit")]
		WidgetRolloverCaption,

		/// <summary>The widget text label u i value.</summary>
		[Field ("PDFAnnotationKeyWidgetTextLabelUI", "+PDFKit")]
		WidgetTextLabelUI,

		/// <summary>The widget value value.</summary>
		[Field ("PDFAnnotationKeyWidgetValue", "+PDFKit")]
		WidgetValue,
	}

	[MacCatalyst (13, 1)]
	[TV (18, 2)]
	enum PdfAnnotationSubtype {

		/// <summary>The text value.</summary>
		[Field ("PDFAnnotationSubtypeText", "+PDFKit")]
		Text,

		/// <summary>The link value.</summary>
		[Field ("PDFAnnotationSubtypeLink", "+PDFKit")]
		Link,

		/// <summary>The free text value.</summary>
		[Field ("PDFAnnotationSubtypeFreeText", "+PDFKit")]
		FreeText,

		/// <summary>The line value.</summary>
		[Field ("PDFAnnotationSubtypeLine", "+PDFKit")]
		Line,

		/// <summary>The square value.</summary>
		[Field ("PDFAnnotationSubtypeSquare", "+PDFKit")]
		Square,

		/// <summary>The circle value.</summary>
		[Field ("PDFAnnotationSubtypeCircle", "+PDFKit")]
		Circle,

		/// <summary>The highlight value.</summary>
		[Field ("PDFAnnotationSubtypeHighlight", "+PDFKit")]
		Highlight,

		/// <summary>The underline value.</summary>
		[Field ("PDFAnnotationSubtypeUnderline", "+PDFKit")]
		Underline,

		/// <summary>The strike out value.</summary>
		[Field ("PDFAnnotationSubtypeStrikeOut", "+PDFKit")]
		StrikeOut,

		/// <summary>The ink value.</summary>
		[Field ("PDFAnnotationSubtypeInk", "+PDFKit")]
		Ink,

		/// <summary>The stamp value.</summary>
		[Field ("PDFAnnotationSubtypeStamp", "+PDFKit")]
		Stamp,

		/// <summary>The popup value.</summary>
		[Field ("PDFAnnotationSubtypePopup", "+PDFKit")]
		Popup,

		/// <summary>The widget value.</summary>
		[Field ("PDFAnnotationSubtypeWidget", "+PDFKit")]
		Widget,
	}

	[MacCatalyst (13, 1)]
	[TV (18, 2)]
	enum PdfAnnotationWidgetSubtype {

		/// <summary>The button value.</summary>
		[Field ("PDFAnnotationWidgetSubtypeButton", "+PDFKit")]
		Button,

		/// <summary>The choice value.</summary>
		[Field ("PDFAnnotationWidgetSubtypeChoice", "+PDFKit")]
		Choice,

		/// <summary>The signature value.</summary>
		[Field ("PDFAnnotationWidgetSubtypeSignature", "+PDFKit")]
		Signature,

		/// <summary>The text value.</summary>
		[Field ("PDFAnnotationWidgetSubtypeText", "+PDFKit")]
		Text,
	}

	[MacCatalyst (13, 1)]
	[TV (18, 2)]
	enum PdfAnnotationLineEndingStyle {

		/// <summary>The none value.</summary>
		[Field ("PDFAnnotationLineEndingStyleNone", "+PDFKit")]
		None,

		/// <summary>The square value.</summary>
		[Field ("PDFAnnotationLineEndingStyleSquare", "+PDFKit")]
		Square,

		/// <summary>The circle value.</summary>
		[Field ("PDFAnnotationLineEndingStyleCircle", "+PDFKit")]
		Circle,

		/// <summary>The diamond value.</summary>
		[Field ("PDFAnnotationLineEndingStyleDiamond", "+PDFKit")]
		Diamond,

		/// <summary>The open arrow value.</summary>
		[Field ("PDFAnnotationLineEndingStyleOpenArrow", "+PDFKit")]
		OpenArrow,

		/// <summary>The closed arrow value.</summary>
		[Field ("PDFAnnotationLineEndingStyleClosedArrow", "+PDFKit")]
		ClosedArrow,
	}

	[MacCatalyst (13, 1)]
	[TV (18, 2)]
	enum PdfAnnotationTextIconType {

		/// <summary>The comment value.</summary>
		[Field ("PDFAnnotationTextIconTypeComment", "+PDFKit")]
		Comment,

		/// <summary>The key value.</summary>
		[Field ("PDFAnnotationTextIconTypeKey", "+PDFKit")]
		Key,

		/// <summary>The note value.</summary>
		[Field ("PDFAnnotationTextIconTypeNote", "+PDFKit")]
		Note,

		/// <summary>The help value.</summary>
		[Field ("PDFAnnotationTextIconTypeHelp", "+PDFKit")]
		Help,

		/// <summary>The new paragraph value.</summary>
		[Field ("PDFAnnotationTextIconTypeNewParagraph", "+PDFKit")]
		NewParagraph,

		/// <summary>The paragraph value.</summary>
		[Field ("PDFAnnotationTextIconTypeParagraph", "+PDFKit")]
		Paragraph,

		/// <summary>The insert value.</summary>
		[Field ("PDFAnnotationTextIconTypeInsert", "+PDFKit")]
		Insert,
	}

	[MacCatalyst (13, 1)]
	[TV (18, 2)]
	enum PdfAnnotationHighlightingMode {

		/// <summary>The none value.</summary>
		[Field ("PDFAnnotationHighlightingModeNone", "+PDFKit")]
		None,

		/// <summary>The invert value.</summary>
		[Field ("PDFAnnotationHighlightingModeInvert", "+PDFKit")]
		Invert,

		/// <summary>The outline value.</summary>
		[Field ("PDFAnnotationHighlightingModeOutline", "+PDFKit")]
		Outline,

		/// <summary>The push value.</summary>
		[Field ("PDFAnnotationHighlightingModePush", "+PDFKit")]
		Push,
	}

	[Native]
	[iOS (15, 0), MacCatalyst (15, 0)]
	[TV (18, 2)]
	public enum PdfAccessPermissions : ulong {
		LowQualityPrinting = (1uL << 0),
		HighQualityPrinting = (1uL << 1),
		DocumentChanges = (1uL << 2),
		DocumentAssembly = (1uL << 3),
		ContentCopying = (1uL << 4),
		ContentAccessibility = (1uL << 5),
		Commenting = (1uL << 6),
		FormFieldEntry = (1uL << 7),
	}

	[Native]
	[iOS (18, 0), Mac (15, 0), MacCatalyst (18, 0)]
	[TV (18, 2)]
	enum PdfSelectionGranularity : ulong {
		Character,
		Word,
		Line,
	}

	[MacCatalyst (13, 1)]
	[TV (18, 2)]
	[Static]
	interface PdfAppearanceCharacteristicsKeys {

		/// <summary>Gets the BackgroundColorKey key constant.</summary>
		[Field ("PDFAppearanceCharacteristicsKeyBackgroundColor", "+PDFKit")]
		NSString BackgroundColorKey { get; }

		/// <summary>Gets the BorderColorKey key constant.</summary>
		[Field ("PDFAppearanceCharacteristicsKeyBorderColor", "+PDFKit")]
		NSString BorderColorKey { get; }

		/// <summary>Gets the RotationKey key constant.</summary>
		[Field ("PDFAppearanceCharacteristicsKeyRotation", "+PDFKit")]
		NSString RotationKey { get; }

		/// <summary>Gets the CaptionKey key constant.</summary>
		[Field ("PDFAppearanceCharacteristicsKeyCaption", "+PDFKit")]
		NSString CaptionKey { get; }

		/// <summary>Gets the RolloverCaptionKey key constant.</summary>
		[Field ("PDFAppearanceCharacteristicsKeyRolloverCaption", "+PDFKit")]
		NSString RolloverCaptionKey { get; }

		/// <summary>Gets the DownCaptionKey key constant.</summary>
		[Field ("PDFAppearanceCharacteristicsKeyDownCaption", "+PDFKit")]
		NSString DownCaptionKey { get; }
	}

	[MacCatalyst (13, 1)]
	[TV (18, 2)]
	[Static]
	interface PdfBorderKeys {

		/// <summary>Gets the LineWidthKey key constant.</summary>
		[Field ("PDFBorderKeyLineWidth", "+PDFKit")]
		NSString LineWidthKey { get; }

		/// <summary>Gets the StyleKey key constant.</summary>
		[Field ("PDFBorderKeyStyle", "+PDFKit")]
		NSString StyleKey { get; }

		/// <summary>Gets the DashPatternKey key constant.</summary>
		[Field ("PDFBorderKeyDashPattern", "+PDFKit")]
		NSString DashPatternKey { get; }
	}

	[MacCatalyst (13, 1)]
	[TV (18, 2)]
	[Internal]
	[Static]
	interface PdfDocumentAttributeKeys {

		[Field ("PDFDocumentTitleAttribute", "+PDFKit")]
		NSString TitleKey { get; }

		[Field ("PDFDocumentAuthorAttribute", "+PDFKit")]
		NSString AuthorKey { get; }

		[Field ("PDFDocumentSubjectAttribute", "+PDFKit")]
		NSString SubjectKey { get; }

		[Field ("PDFDocumentCreatorAttribute", "+PDFKit")]
		NSString CreatorKey { get; }

		[Field ("PDFDocumentProducerAttribute", "+PDFKit")]
		NSString ProducerKey { get; }

		[Field ("PDFDocumentCreationDateAttribute", "+PDFKit")]
		NSString CreationDateKey { get; }

		[Field ("PDFDocumentModificationDateAttribute", "+PDFKit")]
		NSString ModificationDateKey { get; }

		[Field ("PDFDocumentKeywordsAttribute", "+PDFKit")]
		NSString KeywordsKey { get; }
	}

	[Mac (13, 0), iOS (16, 0), MacCatalyst (16, 0)]
	[TV (18, 2)]
	[StrongDictionary ("PdfPageImageInitializationOptionKeys")]
	interface PdfPageImageInitializationOption {
		CGRect MediaBox { get; set; }
		int Rotation { get; set; }
		bool UpscaleIfSmaller { get; set; }
		double CompressionQuality { get; set; }
	}

	[Mac (13, 0), iOS (16, 0), MacCatalyst (16, 0)]
	[TV (18, 2)]
	[Static]
	interface PdfPageImageInitializationOptionKeys {
		[Field ("PDFPageImageInitializationOptionMediaBox")]
		NSString MediaBoxKey { get; }

		[Field ("PDFPageImageInitializationOptionRotation")]
		NSString RotationKey { get; }

		[Field ("PDFPageImageInitializationOptionUpscaleIfSmaller")]
		NSString UpscaleIfSmallerKey { get; }

		[Field ("PDFPageImageInitializationOptionCompressionQuality")]
		NSString CompressionQualityKey { get; }
	}

	[MacCatalyst (13, 1)]
	[TV (18, 2)]
	[StrongDictionary ("PdfDocumentAttributeKeys")]
	interface PdfDocumentAttributes {

		/// <summary>Gets or sets the Title value.</summary>
		string Title { get; set; }
		/// <summary>Gets or sets the Author value.</summary>
		string Author { get; set; }
		/// <summary>Gets or sets the Subject value.</summary>
		string Subject { get; set; }
		/// <summary>Gets or sets the Creator value.</summary>
		string Creator { get; set; }
		/// <summary>Gets or sets the Producer value.</summary>
		string Producer { get; set; }
		/// <summary>Gets or sets the CreationDate value.</summary>
		NSDate CreationDate { get; set; }
		/// <summary>Gets or sets the ModificationDate value.</summary>
		NSDate ModificationDate { get; set; }
		/// <summary>Gets or sets the Keywords value.</summary>
		string [] Keywords { get; set; }
	}

	[MacCatalyst (13, 1)]
	[TV (18, 2)]
	[Internal]
	[Static]
	interface PdfDocumentWriteOptionKeys {

		[Field ("PDFDocumentOwnerPasswordOption", "+PDFKit")]
		NSString OwnerPasswordKey { get; }

		[Field ("PDFDocumentUserPasswordOption", "+PDFKit")]
		NSString UserPasswordKey { get; }

		[iOS (15, 0), MacCatalyst (15, 0)]
		[Field ("PDFDocumentAccessPermissionsOption", "+PDFKit")]
		NSString AccessPermissionsKey { get; }

		[iOS (16, 0), Mac (13, 0), MacCatalyst (16, 0)]
		[Field ("PDFDocumentBurnInAnnotationsOption", "+PDFKit")]
		NSString BurnInAnnotationsKey { get; }

		[iOS (16, 0), Mac (13, 0), MacCatalyst (16, 0)]
		[Field ("PDFDocumentSaveTextFromOCROption", "+PDFKit")]
		NSString SaveTextFromOcrKey { get; }

		[iOS (16, 4), Mac (13, 3), MacCatalyst (16, 4)]
		[Field ("PDFDocumentSaveImagesAsJPEGOption", "+PDFKit")]
		NSString SaveImagesAsJpegKey { get; }

		[iOS (16, 4), Mac (13, 3), MacCatalyst (16, 4)]
		[Field ("PDFDocumentOptimizeImagesForScreenOption", "+PDFKit")]
		NSString OptimizeImagesForScreenKey { get; }
	}

	[MacCatalyst (13, 1)]
	[TV (18, 2)]
	[StrongDictionary ("PdfDocumentWriteOptionKeys")]
	interface PdfDocumentWriteOptions {

		/// <summary>Gets or sets the OwnerPassword value.</summary>
		string OwnerPassword { get; set; }
		/// <summary>Gets or sets the UserPassword value.</summary>
		string UserPassword { get; set; }

		[iOS (15, 0), MacCatalyst (15, 0)]
		string AccessPermissions { get; set; }

		[iOS (16, 0), Mac (13, 0), MacCatalyst (16, 0)]
		bool BurnInAnnotations { get; set; }

		[iOS (16, 0), Mac (13, 0), MacCatalyst (16, 0)]
		bool SaveTextFromOcr { get; set; }

		[iOS (16, 4), Mac (13, 3), MacCatalyst (16, 4)]
		bool SaveImagesAsJpeg { get; set; }

		[iOS (16, 4), Mac (13, 3), MacCatalyst (16, 4)]
		bool OptimizeImagesForScreen { get; set; }
	}

	[MacCatalyst (13, 1)]
	[TV (18, 2)]
	[BaseType (typeof (NSObject), Name = "PDFAppearanceCharacteristics")]
	interface PdfAppearanceCharacteristics : NSCopying {

		/// <summary>Gets or sets the ControlType value.</summary>
		[Export ("controlType", ArgumentSemantic.Assign)]
		PdfWidgetControlType ControlType { get; set; }

		/// <summary>Gets or sets the BackgroundColor value.</summary>
		///         <value>
		///           <para>(More documentation for this node is coming)</para>
		///           <para tool="nullallowed">This value can be <see langword="null" />.</para>
		///         </value>
		[NullAllowed, Export ("backgroundColor", ArgumentSemantic.Copy)]
		NSColor BackgroundColor { get; set; }

		/// <summary>Gets or sets the BorderColor value.</summary>
		///         <value>
		///           <para>(More documentation for this node is coming)</para>
		///           <para tool="nullallowed">This value can be <see langword="null" />.</para>
		///         </value>
		[NullAllowed, Export ("borderColor", ArgumentSemantic.Copy)]
		NSColor BorderColor { get; set; }

		/// <summary>Gets or sets the Rotation value.</summary>
		[Export ("rotation")]
		nint Rotation { get; set; }

		/// <summary>Gets or sets the Caption value.</summary>
		///         <value>
		///           <para>(More documentation for this node is coming)</para>
		///           <para tool="nullallowed">This value can be <see langword="null" />.</para>
		///         </value>
		[NullAllowed, Export ("caption")]
		string Caption { get; set; }

		/// <summary>Gets or sets the RolloverCaption value.</summary>
		///         <value>
		///           <para>(More documentation for this node is coming)</para>
		///           <para tool="nullallowed">This value can be <see langword="null" />.</para>
		///         </value>
		[NullAllowed, Export ("rolloverCaption")]
		string RolloverCaption { get; set; }

		/// <summary>Gets or sets the DownCaption value.</summary>
		///         <value>
		///           <para>(More documentation for this node is coming)</para>
		///           <para tool="nullallowed">This value can be <see langword="null" />.</para>
		///         </value>
		[NullAllowed, Export ("downCaption")]
		string DownCaption { get; set; }

		/// <summary>Gets the WeakAppearanceCharacteristicsKeyValues value.</summary>
		[Export ("appearanceCharacteristicsKeyValues", ArgumentSemantic.Copy)]
		NSDictionary WeakAppearanceCharacteristicsKeyValues { get; }
	}

	/// <summary>Base class for actions that can be performed on a PDF.</summary>
	[MacCatalyst (13, 1)]
	[TV (18, 2)]
	[BaseType (typeof (NSObject), Name = "PDFAction")]
	[Abstract]
	interface PdfAction : NSCopying {
		//This is an abstract superclass with no public init - should it have a private constructor??
		//As it is, I can create instances, that segfault when you access the type method.
		//marking the method as [Abstract] doesn't work because the subclasses do not explictly
		//define this method (although they implement it)
		/// <summary>Gets the action type.</summary>
		[Export ("type")]
		string Type { get; }
	}

	/// <summary>An action that contains data for going to a location within a PDF.</summary>
	[MacCatalyst (13, 1)]
	[TV (18, 2)]
	[BaseType (typeof (PdfAction), Name = "PDFActionGoTo")]
	interface PdfActionGoTo {

		/// <param name="destination">The PDF destination.</param>
		/// <summary>Creates a new go-to PDF action with the specified <paramref name="destination" />.</summary>
		[DesignatedInitializer]
		[Export ("initWithDestination:")]
		NativeHandle Constructor (PdfDestination destination);

		/// <summary>Gets or sets the destination of the go-to PDF action.</summary>
		[Export ("destination")]
		PdfDestination Destination { get; set; }
	}

	/// <summary>An named PDF action.</summary>
	[MacCatalyst (13, 1)]
	[TV (18, 2)]
	[BaseType (typeof (PdfAction), Name = "PDFActionNamed")]
	interface PdfActionNamed {

		/// <param name="name">The name.</param>
		/// <summary>Creates a new named PDF action with the specified <paramref name="name" />.</summary>
		[DesignatedInitializer]
		[Export ("initWithName:")]
		NativeHandle Constructor (PdfActionNamedName name);

		/// <summary>Gets or sets the name of the named PDF action.</summary>
		[Export ("name")]
		PdfActionNamedName Name { get; set; }
	}

	/// <summary>An action that contains data for going to a location in another document.</summary>
	[MacCatalyst (13, 1)]
	[TV (18, 2)]
	[BaseType (typeof (PdfAction), Name = "PDFActionRemoteGoTo")]
	interface PdfActionRemoteGoTo {

		/// <param name="pageIndex">The page index.</param>
		/// <param name="point">The point.</param>
		/// <param name="fileUrl">The file URL.</param>
		/// <summary>Creates a new remote go-to PDF action for going to the specified <paramref name="point" /> on the page at <paramref name="pageIndex" /> in the document at the specified <paramref name="fileUrl" />.</summary>
		[DesignatedInitializer]
		[Export ("initWithPageIndex:atPoint:fileURL:")]
		NativeHandle Constructor (nint pageIndex, CGPoint point, NSUrl fileUrl);

		/// <summary>Gets or sets the zero-based index of the page in the destination document.</summary>
		[Export ("pageIndex")]
		nint PageIndex { get; set; }

		/// <summary>Gets or sets the page-space point on the page in the destination document.</summary>
		[Export ("point")]
		CGPoint Point { get; set; }

		/// <summary>Gets or sets the URL for the remote document.</summary>
		[Export ("URL")]
		NSUrl Url { get; set; }
	}

	/// <summary>An action that resets a form in a PDF.</summary>
	[MacCatalyst (13, 1)]
	[TV (18, 2)]
	[DisableDefaultCtor]
	[BaseType (typeof (PdfAction), Name = "PDFActionResetForm")]
	interface PdfActionResetForm {
		// - (instancetype)init NS_DESIGNATED_INITIALIZER;
		/// <summary>Creates a new form reset action with default values.</summary>
		/// <remarks />
		[Export ("init")]
		[DesignatedInitializer]
		NativeHandle Constructor ();

		//NSArray of NSString
		/// <summary>Gets or sets the fields that will be affected by the action.</summary>
		///         <value>
		///           <para>(More documentation for this node is coming)</para>
		///           <para tool="nullallowed">This value can be <see langword="null" />.</para>
		///         </value>
		[Export ("fields"), NullAllowed]
		string [] Fields { get; set; }

		/// <summary>Gets or sets a Boolean value that controls whether the fields that are in <see cref="PdfKit.PdfActionResetForm.Fields" /> will be cleared.</summary>
		[Export ("fieldsIncludedAreCleared")]
		bool FieldsIncludedAreCleared { get; set; }
	}

	/// <summary>A PDF action for visiting a URL.</summary>
	[MacCatalyst (13, 1)]
	[TV (18, 2)]
	[BaseType (typeof (PdfAction), Name = "PDFActionURL")]
	interface PdfActionUrl {

		/// <param name="url">The URL.</param>
		/// <summary>Creates a new URL PDF action with the specified URL.</summary>
		[DesignatedInitializer]
		[Export ("initWithURL:")]
		NativeHandle Constructor (NSUrl url);

		/// <summary>Gets or sets the URL for the PDF action.</summary>
		[Export ("URL"), NullAllowed]
		NSUrl Url { get; set; }
	}

	/// <summary>Notes, highlights, or other additions to a PDF file.</summary>
	[MacCatalyst (13, 1)]
	[TV (18, 2)]
	[BaseType (typeof (NSObject), Name = "PDFAnnotation")]
	interface PdfAnnotation : NSCoding, NSCopying {

		/// <param name="bounds">The bounds rectangle.</param>
		/// <param name="annotationType">The annotation type.</param>
		/// <param name="properties">
		///           <para>A task representing the asynchronous operation.</para>
		///           <para tool="nullallowed">This parameter can be <see langword="null" />.</para>
		///         </param>
		/// <summary>Creates a new instance with the specified parameters.</summary>
		[MacCatalyst (13, 1)]
		[Export ("initWithBounds:forType:withProperties:")]
		[DesignatedInitializer]
		NativeHandle Constructor (CGRect bounds, NSString annotationType, [NullAllowed] NSDictionary properties);

		/// <param name="bounds">The bounds rectangle.</param>
		/// <param name="annotationType">The annotation type.</param>
		/// <param name="properties">The properties dictionary.</param>
		/// <summary>Creates a new instance with the specified parameters.</summary>
		[MacCatalyst (13, 1)]
		[Wrap ("this (bounds, annotationType.GetConstant ()!, properties)")]
		NativeHandle Constructor (CGRect bounds, PdfAnnotationKey annotationType, [NullAllowed] NSDictionary properties);

		/// <param name="bounds">The bounds rectangle.</param>
		/// <summary>Developers should not use this deprecated constructor. Developers should use '.ctor (CGRect, PDFAnnotationKey, NSDictionary)' instead.</summary>
		[Deprecated (PlatformName.iOS, 11, 0, message: "Use '.ctor (CGRect, PDFAnnotationKey, NSDictionary)' instead.")]
		[Deprecated (PlatformName.MacOSX, 10, 12, message: "Use '.ctor (CGRect, PDFAnnotationKey, NSDictionary)' instead.")]
		[NoMacCatalyst]
		[NoTV]
		[Deprecated (PlatformName.MacCatalyst, 13, 1, message: "Use '.ctor (CGRect, PDFAnnotationKey, NSDictionary)' instead.")]
		[Export ("initWithBounds:")]
		NativeHandle Constructor (CGRect bounds);

		/// <summary>Gets or sets the Page value.</summary>
		[Export ("page")]
		[NullAllowed]
		PdfPage Page { get; set; }

		/// <summary>Gets the Type key constant.</summary>
		[Protected]
		[Export ("type")]
		[NullAllowed]
		NSString Type { get; set; }

		/// <summary>Gets or sets the Bounds value.</summary>
		[Export ("bounds")]
		CGRect Bounds { get; set; }

		/// <summary>Gets or sets the ModificationDate value.</summary>
		[Export ("modificationDate")]
		[NullAllowed]
		NSDate ModificationDate { get; set; }

		/// <summary>Gets or sets the UserName value.</summary>
		[Export ("userName")]
		[NullAllowed]
		string UserName { get; set; }

		/// <summary>Performs the PDF operation.</summary>
		[Export ("popup")]
		[NullAllowed]
#if MONOMAC
		PdfAnnotationPopup Popup { get; set; }
#else
		PdfAnnotation Popup { get; set; }
#endif

		/// <summary>Gets or sets the ShouldDisplay value.</summary>
		[Export ("shouldDisplay")]
		bool ShouldDisplay { get; set; }

		/// <summary>Gets or sets the ShouldPrint value.</summary>
		[Export ("shouldPrint")]
		bool ShouldPrint { get; set; }

		/// <summary>Gets or sets the Border value.</summary>
		[Export ("border")]
		[NullAllowed]
		PdfBorder Border { get; set; }

		/// <summary>Gets or sets the Color value.</summary>
		[Export ("color")]
		NSColor Color { get; set; }

		/// <summary>Gets or sets the MouseUpAction value.</summary>
		[NoiOS]
		[NullAllowed]
		[Deprecated (PlatformName.MacOSX, 10, 13)]
		[NoMacCatalyst]
		[NoTV]
		[Export ("mouseUpAction")]
		PdfAction MouseUpAction { get; set; }

		/// <summary>Gets or sets the Contents value.</summary>
		[Export ("contents")]
		[NullAllowed]
		string Contents { get; set; }

		/// <summary>Gets the ToolTip value.</summary>
		[NoiOS]
		[Deprecated (PlatformName.MacOSX, 10, 12)]
		[NoMacCatalyst]
		[NoTV]
		[Export ("toolTip")]
		[NullAllowed]
		string ToolTip { get; }

		/// <summary>Gets the HasAppearanceStream value.</summary>
		[Export ("hasAppearanceStream")]
		bool HasAppearanceStream { get; }

		/// <summary>Performs the remove all appearance streams operation.</summary>
		[NoiOS]
		[Deprecated (PlatformName.MacOSX, 10, 12)]
		[NoMacCatalyst]
		[NoTV]
		[Export ("removeAllAppearanceStreams")]
		void RemoveAllAppearanceStreams ();

		/// <param name="box">The PDF display box.</param>
		///         <summary>Performs the draw operation.</summary>
		[NoiOS]
		[Deprecated (PlatformName.MacOSX, 10, 12)]
		[NoMacCatalyst]
		[NoTV]
		[Export ("drawWithBox:")]
		void Draw (PdfDisplayBox box);

		/// <summary>Gets or sets the Action value.</summary>
		///         <value>
		///           <para>(More documentation for this node is coming)</para>
		///           <para tool="nullallowed">This value can be <see langword="null" />.</para>
		///         </value>
		[MacCatalyst (13, 1)]
		[Export ("action", ArgumentSemantic.Strong), NullAllowed]
		PdfAction Action { get; set; }

		/// <summary>Gets or sets the Highlighted value.</summary>
		[MacCatalyst (13, 1)]
		[Export ("highlighted")]
		bool Highlighted { [Bind ("isHighlighted")] get; set; }

		/// <param name="box">The PDF display box.</param>
		///         <param name="context">The graphics context.</param>
		///         <summary>Performs the draw operation.</summary>
		[MacCatalyst (13, 1)]
		[Export ("drawWithBox:inContext:")]
		void Draw (PdfDisplayBox box, CGContext context);

		[Internal]
		[MacCatalyst (13, 1)]
		[Export ("setValue:forAnnotationKey:")]
		bool _SetValue (IntPtr value, NSString key);

		[Internal]
		[MacCatalyst (13, 1)]
		[Export ("valueForAnnotationKey:")]
		[return: NullAllowed]
		IntPtr _GetValue (NSString key);

		/// <param name="boolean">The boolean value.</param>
		///         <param name="key">The key.</param>
		///         <summary>Performs the set value operation.</summary>
		///         <returns>The result of the operation.</returns>
		[Protected]
		[MacCatalyst (13, 1)]
		[Export ("setBoolean:forAnnotationKey:")]
		bool SetValue (bool boolean, NSString key);

		/// <param name="boolean">The boolean value.</param>
		///         <param name="key">The key.</param>
		///         <summary>Performs the set value operation.</summary>
		///         <returns>The result of the operation.</returns>
		[MacCatalyst (13, 1)]
		[Wrap ("SetValue (boolean, key.GetConstant ()!)")]
		bool SetValue (bool boolean, PdfAnnotationKey key);

		/// <param name="rect">The rectangle.</param>
		///         <param name="key">The key.</param>
		///         <summary>Performs the set value operation.</summary>
		///         <returns>The result of the operation.</returns>
		[Protected]
		[MacCatalyst (13, 1)]
		[Export ("setRect:forAnnotationKey:")]
		bool SetValue (CGRect rect, NSString key);

		/// <param name="rect">The rectangle.</param>
		///         <param name="key">The key.</param>
		///         <summary>Performs the set value operation.</summary>
		///         <returns>The result of the operation.</returns>
		[MacCatalyst (13, 1)]
		[Wrap ("SetValue (rect, key.GetConstant ()!)")]
		bool SetValue (CGRect rect, PdfAnnotationKey key);

		/// <summary>Gets the AnnotationKeyValues value.</summary>
		[MacCatalyst (13, 1)]
		[Export ("annotationKeyValues", ArgumentSemantic.Copy)]
		NSDictionary AnnotationKeyValues { get; }

		/// <param name="key">The key.</param>
		///         <summary>Performs the remove value operation.</summary>
		[Protected]
		[MacCatalyst (13, 1)]
		[Export ("removeValueForAnnotationKey:")]
		void RemoveValue (NSString key);

		/// <param name="key">The key.</param>
		///         <summary>Performs the remove value operation.</summary>
		[MacCatalyst (13, 1)]
		[Wrap ("RemoveValue (key.GetConstant ()!)")]
		void RemoveValue (PdfAnnotationKey key);

		// PDFAnnotation (PDFAnnotationUtilities) Category

		/// <summary>Gets or sets the Font value.</summary>
		///         <value>
		///           <para>(More documentation for this node is coming)</para>
		///           <para tool="nullallowed">This value can be <see langword="null" />.</para>
		///         </value>
		[MacCatalyst (13, 1)]
		[NullAllowed, Export ("font", ArgumentSemantic.Copy)]
		NSFont Font { get; set; }

		/// <summary>Gets or sets the FontColor value.</summary>
		///         <value>
		///           <para>(More documentation for this node is coming)</para>
		///           <para tool="nullallowed">This value can be <see langword="null" />.</para>
		///         </value>
		[MacCatalyst (13, 1)]
		[NullAllowed, Export ("fontColor", ArgumentSemantic.Copy)]
		NSColor FontColor { get; set; }

		/// <summary>Gets or sets the InteriorColor value.</summary>
		///         <value>
		///           <para>(More documentation for this node is coming)</para>
		///           <para tool="nullallowed">This value can be <see langword="null" />.</para>
		///         </value>
		[MacCatalyst (13, 1)]
		[NullAllowed, Export ("interiorColor", ArgumentSemantic.Copy)]
		NSColor InteriorColor { get; set; }

		/// <summary>Gets or sets the Alignment value.</summary>
		[MacCatalyst (13, 1)]
		[Export ("alignment", ArgumentSemantic.Assign)]
		NSTextAlignment Alignment { get; set; }

		/// <summary>Gets or sets the StartPoint value.</summary>
		[MacCatalyst (13, 1)]
		[Export ("startPoint", ArgumentSemantic.Assign)]
		CGPoint StartPoint { get; set; }

		/// <summary>Gets or sets the EndPoint value.</summary>
		[MacCatalyst (13, 1)]
		[Export ("endPoint", ArgumentSemantic.Assign)]
		CGPoint EndPoint { get; set; }

		/// <summary>Gets or sets the StartLineStyle value.</summary>
		[MacCatalyst (13, 1)]
		[Export ("startLineStyle", ArgumentSemantic.Assign)]
		PdfLineStyle StartLineStyle { get; set; }

		/// <summary>Gets or sets the EndLineStyle value.</summary>
		[MacCatalyst (13, 1)]
		[Export ("endLineStyle", ArgumentSemantic.Assign)]
		PdfLineStyle EndLineStyle { get; set; }

		/// <param name="fromName">The source name.</param>
		///         <summary>Performs the get line style operation.</summary>
		///         <returns>The result of the operation.</returns>
		[MacCatalyst (13, 1)]
		[Static]
		[Export ("lineStyleFromName:")]
		PdfLineStyle GetLineStyle (string fromName);

		/// <param name="style">The border style.</param>
		///         <summary>Performs the get name operation.</summary>
		///         <returns>The result of the operation.</returns>
		[MacCatalyst (13, 1)]
		[Static]
		[Export ("nameForLineStyle:")]
		string GetName (PdfLineStyle style);

		/// <summary>Gets or sets the IconType value.</summary>
		[MacCatalyst (13, 1)]
		[Export ("iconType", ArgumentSemantic.Assign)]
		PdfTextAnnotationIconType IconType { get; set; }

		[Internal]
		[MacCatalyst (13, 1)]
		[NullAllowed, Export ("quadrilateralPoints", ArgumentSemantic.Copy)]
		IntPtr _QuadrilateralPoints { get; set; }

		/// <summary>Gets or sets the MarkupType value.</summary>
		[MacCatalyst (13, 1)]
		[Export ("markupType", ArgumentSemantic.Assign)]
		PdfMarkupType MarkupType { get; set; }

		/// <summary>Gets or sets the WidgetFieldType value.</summary>
		[MacCatalyst (13, 1)]
		[Export ("widgetFieldType")]
		string WidgetFieldType { get; set; }

		/// <summary>Gets or sets the WidgetControlType value.</summary>
		[MacCatalyst (13, 1)]
		[Export ("widgetControlType", ArgumentSemantic.Assign)]
		PdfWidgetControlType WidgetControlType { get; set; }

		/// <summary>Gets or sets the Multiline value.</summary>
		[MacCatalyst (13, 1)]
		[Export ("multiline")]
		bool Multiline { [Bind ("isMultiline")] get; set; }

		/// <summary>Gets the IsPasswordField value.</summary>
		[MacCatalyst (13, 1)]
		[Export ("isPasswordField")]
		bool IsPasswordField { get; }

		/// <summary>Gets or sets the Comb value.</summary>
		[MacCatalyst (13, 1)]
		[Export ("comb")]
		bool Comb { [Bind ("hasComb")] get; set; }

		/// <summary>Gets or sets the MaximumLength value.</summary>
		[MacCatalyst (13, 1)]
		[Export ("maximumLength")]
		nint MaximumLength { get; set; }

		/// <summary>Gets or sets the WidgetStringValue value.</summary>
		///         <value>
		///           <para>(More documentation for this node is coming)</para>
		///           <para tool="nullallowed">This value can be <see langword="null" />.</para>
		///         </value>
		[MacCatalyst (13, 1)]
		[NullAllowed, Export ("widgetStringValue")]
		string WidgetStringValue { get; set; }

		/// <summary>Gets or sets the WidgetDefaultStringValue value.</summary>
		///         <value>
		///           <para>(More documentation for this node is coming)</para>
		///           <para tool="nullallowed">This value can be <see langword="null" />.</para>
		///         </value>
		[MacCatalyst (13, 1)]
		[NullAllowed, Export ("widgetDefaultStringValue")]
		string WidgetDefaultStringValue { get; set; }

		/// <summary>Gets or sets the AllowsToggleToOff value.</summary>
		[MacCatalyst (13, 1)]
		[Export ("allowsToggleToOff")]
		bool AllowsToggleToOff { get; set; }

		/// <summary>Gets or sets the RadiosInUnison value.</summary>
		[MacCatalyst (13, 1)]
		[Export ("radiosInUnison")]
		bool RadiosInUnison { get; set; }

		/// <summary>Gets or sets the ReadOnly value.</summary>
		[MacCatalyst (13, 1)]
		[Export ("readOnly")]
		bool ReadOnly { [Bind ("isReadOnly")] get; set; }

		/// <summary>Gets or sets the ListChoice value.</summary>
		[MacCatalyst (13, 1)]
		[Export ("listChoice")]
		bool ListChoice { [Bind ("isListChoice")] get; set; }

		/// <summary>Gets or sets the Choices value.</summary>
		///         <value>
		///           <para>(More documentation for this node is coming)</para>
		///           <para tool="nullallowed">This value can be <see langword="null" />.</para>
		///         </value>
		[MacCatalyst (13, 1)]
		[NullAllowed, Export ("choices", ArgumentSemantic.Copy)]
		string [] Choices { get; set; }

		/// <summary>Gets or sets the Values value.</summary>
		///         <value>
		///           <para>(More documentation for this node is coming)</para>
		///           <para tool="nullallowed">This value can be <see langword="null" />.</para>
		///         </value>
		[MacCatalyst (13, 1)]
		[NullAllowed, Export ("values", ArgumentSemantic.Copy)]
		string [] Values { get; set; }

		/// <summary>Gets or sets the ButtonWidgetState value.</summary>
		[MacCatalyst (13, 1)]
		[Export ("buttonWidgetState", ArgumentSemantic.Assign)]
		PdfWidgetCellState ButtonWidgetState { get; set; }

		/// <summary>Gets or sets the ButtonWidgetStateString value.</summary>
		[MacCatalyst (13, 1)]
		[Export ("buttonWidgetStateString")]
		string ButtonWidgetStateString { get; set; }

		/// <summary>Gets or sets the Open value.</summary>
		[MacCatalyst (13, 1)]
		[Export ("open")]
		bool Open { [Bind ("isOpen")] get; set; }

		/// <summary>Gets the Paths value.</summary>
		///         <value>
		///           <para>(More documentation for this node is coming)</para>
		///           <para tool="nullallowed">This value can be <see langword="null" />.</para>
		///         </value>
		[MacCatalyst (13, 1)]
		[NullAllowed, Export ("paths")]
		NSBezierPath [] Paths { get; }

		/// <param name="path">The path.</param>
		///         <summary>Performs the add bezier path operation.</summary>
		[MacCatalyst (13, 1)]
		[Export ("addBezierPath:")]
		void AddBezierPath (NSBezierPath path);

		/// <param name="path">The path.</param>
		///         <summary>Performs the remove bezier path operation.</summary>
		[MacCatalyst (13, 1)]
		[Export ("removeBezierPath:")]
		void RemoveBezierPath (NSBezierPath path);

		/// <summary>Gets or sets the Destination value.</summary>
		///         <value>
		///           <para>(More documentation for this node is coming)</para>
		///           <para tool="nullallowed">This value can be <see langword="null" />.</para>
		///         </value>
		[MacCatalyst (13, 1)]
		[NullAllowed, Export ("destination", ArgumentSemantic.Strong)]
		PdfDestination Destination { get; set; }

		/// <summary>Gets or sets the Url value.</summary>
		///         <value>
		///           <para>(More documentation for this node is coming)</para>
		///           <para tool="nullallowed">This value can be <see langword="null" />.</para>
		///         </value>
		[MacCatalyst (13, 1)]
		[NullAllowed, Export ("URL", ArgumentSemantic.Copy)]
		NSUrl Url { get; set; }

		/// <summary>Gets or sets the FieldName value.</summary>
		///         <value>
		///           <para>(More documentation for this node is coming)</para>
		///           <para tool="nullallowed">This value can be <see langword="null" />.</para>
		///         </value>
		[MacCatalyst (13, 1)]
		[NullAllowed, Export ("fieldName")]
		string FieldName { get; set; }

		/// <summary>Gets or sets the Caption value.</summary>
		///         <value>
		///           <para>(More documentation for this node is coming)</para>
		///           <para tool="nullallowed">This value can be <see langword="null" />.</para>
		///         </value>
		[MacCatalyst (13, 1)]
		[NullAllowed, Export ("caption")]
		string Caption { get; set; }

		/// <summary>Gets or sets the BackgroundColor value.</summary>
		///         <value>
		///           <para>(More documentation for this node is coming)</para>
		///           <para tool="nullallowed">This value can be <see langword="null" />.</para>
		///         </value>
		[MacCatalyst (13, 1)]
		[NullAllowed, Export ("backgroundColor", ArgumentSemantic.Copy)]
		NSColor BackgroundColor { get; set; }

		/// <summary>Gets or sets the StampName value.</summary>
		///         <value>
		///           <para>(More documentation for this node is coming)</para>
		///           <para tool="nullallowed">This value can be <see langword="null" />.</para>
		///         </value>
		[MacCatalyst (13, 1)]
		[NullAllowed, Export ("stampName")]
		string StampName { get; set; }

		[iOS (17, 0), Mac (14, 0), MacCatalyst (17, 0)]
		[Export ("activatableTextField")]
		bool ActivatableTextField { [Bind ("isActivatableTextField")] get; }
	}

	[NoiOS]
	[NoTV]
	[Deprecated (PlatformName.MacOSX, 10, 12)]
	[NoMacCatalyst]
	[BaseType (typeof (PdfAnnotation), Name = "PDFAnnotationButtonWidget")]
	interface PdfAnnotationButtonWidget {
		/// <summary>Gets or sets the ControlType value.</summary>
		[Export ("controlType")]
		PdfWidgetControlType ControlType { get; set; }

		/// <summary>Gets or sets the State value.</summary>
		[Export ("state")]
		nint State { get; set; }

		/// <summary>Gets or sets the Highlighted value.</summary>
		[Export ("highlighted")]
		bool Highlighted { [Bind ("isHighlighted")] get; set; }

		/// <summary>Gets or sets the BackgroundColor value.</summary>
		[Export ("backgroundColor")]
		NSColor BackgroundColor { get; set; }

		/// <summary>Gets or sets the AllowsToggleToOff value.</summary>
		[Export ("allowsToggleToOff")]
		bool AllowsToggleToOff { get; set; }

		/// <summary>Gets or sets the Font value.</summary>
		[Export ("font")]
		NSFont Font { get; set; }

		/// <summary>Gets or sets the FontColor value.</summary>
		[Export ("fontColor")]
		NSColor FontColor { get; set; }

		/// <summary>Gets or sets the Caption value.</summary>
		[Export ("caption")]
		string Caption { get; set; }

		/// <summary>Gets or sets the FieldName value.</summary>
		[Export ("fieldName")]
		string FieldName { get; set; }

		/// <summary>Gets or sets the OnStateValue value.</summary>
		[Export ("onStateValue")]
		string OnStateValue { get; set; }
	}

	[NoiOS]
	[NoTV]
	[Deprecated (PlatformName.MacOSX, 10, 12)]
	[NoMacCatalyst]
	[BaseType (typeof (PdfAnnotation), Name = "PDFAnnotationChoiceWidget")]
	interface PdfAnnotationChoiceWidget {
		/// <summary>Gets or sets the Text value.</summary>
		[Export ("stringValue")]
		string Text { get; set; }

		/// <summary>Gets or sets the BackgroundColor value.</summary>
		[Export ("backgroundColor")]
		NSColor BackgroundColor { get; set; }

		/// <summary>Gets or sets the Font value.</summary>
		[Export ("font")]
		NSFont Font { get; set; }

		/// <summary>Gets or sets the FontColor value.</summary>
		[Export ("fontColor")]
		NSColor FontColor { get; set; }

		/// <summary>Gets or sets the FieldName value.</summary>
		[Export ("fieldName")]
		string FieldName { get; set; }

		/// <summary>Gets or sets the IsListChoice value.</summary>
		[Export ("isListChoice")]
		bool IsListChoice { get; set; }

		// NSArray of NSString
		/// <summary>Gets or sets the Choices value.</summary>
		[Export ("choices")]
		string [] Choices { get; set; }
	}

	[NoiOS]
	[NoTV]
	[Deprecated (PlatformName.MacOSX, 10, 12)]
	[NoMacCatalyst]
	[BaseType (typeof (PdfAnnotation), Name = "PDFAnnotationCircle")]
	interface PdfAnnotationCircle {
		/// <summary>Gets or sets the InteriorColor value.</summary>
		[Export ("interiorColor")]
		NSColor InteriorColor { get; set; }
	}

	[NoiOS]
	[NoTV]
	[Deprecated (PlatformName.MacOSX, 10, 12)]
	[NoMacCatalyst]
	[BaseType (typeof (PdfAnnotation), Name = "PDFAnnotationFreeText")]
	interface PdfAnnotationFreeText {
		/// <summary>Gets or sets the Font value.</summary>
		[Export ("font")]
		NSFont Font { get; set; }

		/// <summary>Gets or sets the FontColor value.</summary>
		[Export ("fontColor")]
		NSColor FontColor { get; set; }

		/// <summary>Gets or sets the Alignment value.</summary>
		[Export ("alignment")]
		NSTextAlignment Alignment { get; set; }
	}

	[NoiOS]
	[NoTV]
	[Deprecated (PlatformName.MacOSX, 10, 12)]
	[NoMacCatalyst]
	[BaseType (typeof (PdfAnnotation), Name = "PDFAnnotationInk")]
	interface PdfAnnotationInk {
		/// <summary>Gets the Paths value.</summary>
		[Export ("paths")]
		NSBezierPath [] Paths { get; }

		[Export ("addBezierPath:")]
		void AddBezierPath (NSBezierPath path);

		[Export ("removeBezierPath:")]
		void RemoveBezierPath (NSBezierPath path);
	}

	[NoiOS]
	[NoTV]
	[Deprecated (PlatformName.MacOSX, 10, 12)]
	[NoMacCatalyst]
	[BaseType (typeof (PdfAnnotation), Name = "PDFAnnotationLine")]
	interface PdfAnnotationLine {
		/// <summary>Gets or sets the StartPoint value.</summary>
		[Export ("startPoint")]
		CGPoint StartPoint { get; set; }

		/// <summary>Gets or sets the EndPoint value.</summary>
		[Export ("endPoint")]
		CGPoint EndPoint { get; set; }

		/// <summary>Gets or sets the StartLineStyle value.</summary>
		[Export ("startLineStyle")]
		PdfLineStyle StartLineStyle { get; set; }

		/// <summary>Gets or sets the EndLineStyle value.</summary>
		[Export ("endLineStyle")]
		PdfLineStyle EndLineStyle { get; set; }

		/// <summary>Gets or sets the InteriorColor value.</summary>
		[Export ("interiorColor")]
		NSColor InteriorColor { get; set; }
	}

	[NoiOS]
	[NoTV]
	[Deprecated (PlatformName.MacOSX, 10, 12)]
	[NoMacCatalyst]
	[BaseType (typeof (PdfAnnotation), Name = "PDFAnnotationLink")]
	interface PdfAnnotationLink {
		/// <summary>Gets or sets the Destination value.</summary>
		[Export ("destination")]
		PdfDestination Destination { get; set; }

		/// <summary>Gets or sets the Url value.</summary>
		[Export ("URL")]
		NSUrl Url { get; set; }

		/// <param name="highlighted">Whether the annotation is highlighted.</param>
		///         <summary>Performs the set highlighted operation.</summary>
		[Export ("setHighlighted:")]
		void SetHighlighted (bool highlighted);
	}

	[NoiOS]
	[NoTV]
	[Deprecated (PlatformName.MacOSX, 10, 12)]
	[NoMacCatalyst]
	[BaseType (typeof (PdfAnnotation), Name = "PDFAnnotationMarkup")]
	interface PdfAnnotationMarkup {
		/// <summary>Gets or sets the WeakQuadrilateralPoints value.</summary>
		[Export ("quadrilateralPoints", ArgumentSemantic.Assign), NullAllowed]
		NSArray WeakQuadrilateralPoints { get; set; }

		/// <summary>Gets or sets the MarkupType value.</summary>
		[Export ("markupType")]
		PdfMarkupType MarkupType { get; set; }
	}

	[NoiOS]
	[NoTV]
	[Deprecated (PlatformName.MacOSX, 10, 12)]
	[NoMacCatalyst]
	[BaseType (typeof (PdfAnnotation), Name = "PDFAnnotationPopup")]
	interface PdfAnnotationPopup {
		/// <summary>Gets or sets the IsOpen value.</summary>
		[Export ("isOpen")]
		bool IsOpen { get; set; }
	}

	[NoiOS]
	[NoTV]
	[Deprecated (PlatformName.MacOSX, 10, 12)]
	[NoMacCatalyst]
	[BaseType (typeof (PdfAnnotation), Name = "PDFAnnotationSquare")]
	interface PdfAnnotationSquare {
		/// <summary>Gets or sets the InteriorColor value.</summary>
		[Export ("interiorColor")]
		NSColor InteriorColor { get; set; }
	}

	[NoiOS]
	[NoTV]
	[Deprecated (PlatformName.MacOSX, 10, 12)]
	[NoMacCatalyst]
	[BaseType (typeof (PdfAnnotation), Name = "PDFAnnotationStamp")]
	interface PdfAnnotationStamp {
		/// <summary>Gets or sets the Name value.</summary>
		[Export ("name")]
		string Name { get; set; }
	}

	[NoiOS]
	[NoTV]
	[Deprecated (PlatformName.MacOSX, 10, 12)]
	[NoMacCatalyst]
	[BaseType (typeof (PdfAnnotation), Name = "PDFAnnotationText")]
	interface PdfAnnotationText {
		/// <summary>Gets or sets the IconType value.</summary>
		[Export ("iconType")]
		PdfTextAnnotationIconType IconType { get; set; }
	}

	[NoiOS]
	[NoTV]
	[Deprecated (PlatformName.MacOSX, 10, 12)]
	[NoMacCatalyst]
	[BaseType (typeof (PdfAnnotation), Name = "PDFAnnotationTextWidget")]
	interface PdfAnnotationTextWidget {
		/// <summary>Gets or sets the StringValue value.</summary>
		[Export ("stringValue")]
		string StringValue { get; set; }

		/// <summary>Gets or sets the BackgroundColor value.</summary>
		[Export ("backgroundColor")]
		NSColor BackgroundColor { get; set; }

		/// <summary>Gets or sets the Rotation value.</summary>
		[Export ("rotation")]
		int Rotation { get; set; } // (int) rotation;

		/// <summary>Gets or sets the Font value.</summary>
		[Export ("font")]
		NSFont Font { get; set; }

		/// <summary>Gets or sets the FontColor value.</summary>
		[Export ("fontColor")]
		NSColor FontColor { get; set; }

		/// <summary>Gets or sets the Alignment value.</summary>
		[Export ("alignment")]
		NSTextAlignment Alignment { get; set; }

		/// <summary>Gets or sets the MaximumLength value.</summary>
		[Export ("maximumLength")]
		nint MaximumLength { get; set; }

		/// <summary>Gets or sets the FieldName value.</summary>
		[Export ("fieldName")]
		string FieldName { get; set; }

		/// <summary>Gets or sets the AttributedStringValue value.</summary>
		[Export ("attributedStringValue")]
		NSAttributedString AttributedStringValue { get; set; }

		/// <summary>Gets or sets the IsMultiline value.</summary>
		[Export ("isMultiline")]
		bool IsMultiline { get; set; }
	}

	/// <summary>A border that may be drawn within the rectangle of an annotation.</summary>
	[MacCatalyst (13, 1)]
	[TV (18, 2)]
	[BaseType (typeof (NSObject), Name = "PDFBorder")]
	interface PdfBorder : NSCoding, NSCopying {
		/// <summary>Gets or sets the border style.</summary>
		[Export ("style")]
		PdfBorderStyle Style { get; set; }

		/// <summary>Gets or sets the line width, in points.</summary>
		[Export ("lineWidth")]
		nfloat LineWidth { get; set; }

		/// <summary>Gets or sets a weak reference to the dash pattern for the border.</summary>
		///         <value>
		///           <para>(More documentation for this node is coming)</para>
		///           <para tool="nullallowed">This value can be <see langword="null" />.</para>
		///         </value>
		[Export ("dashPattern", ArgumentSemantic.Assign), NullAllowed]
		NSArray WeakDashPattern { get; set; }

		/// <summary>Gets or sets a weak reference to the border properties dictionary.</summary>
		[MacCatalyst (13, 1)]
		[Export ("borderKeyValues", ArgumentSemantic.Copy)]
		NSDictionary WeakBorderKeyValues { get; }

		/// <param name="rect">The rectangle in which to draw.</param>
		///         <summary>Draws the border just within the specified rectangle.</summary>
		[Export ("drawInRect:")]
		void Draw (CGRect rect);
	}

	/// <summary>A destination for a go-to PDF action.</summary>
	[MacCatalyst (13, 1)]
	[TV (18, 2)]
	[BaseType (typeof (NSObject), Name = "PDFDestination")]
	interface PdfDestination : NSCopying {

		/// <summary>Gets the UnspecifiedValue value.</summary>
		[MacCatalyst (13, 1)]
		[Field ("kPDFDestinationUnspecifiedValue")]
		nfloat UnspecifiedValue { get; }

		/// <param name="page">The PDF page.</param>
		/// <param name="point">The point.</param>
		/// <summary>Creates a new PDF destination object for the specified point on the specified page.</summary>
		[DesignatedInitializer]
		[Export ("initWithPage:atPoint:")]
		NativeHandle Constructor (PdfPage page, CGPoint point);

		/// <summary>Gets the page of the destination.</summary>
		[Export ("page")]
		[NullAllowed]
		PdfPage Page { get; }

		/// <summary>Gets the point on the destination page.</summary>
		[Export ("point")]
		CGPoint Point { get; }

		/// <summary>Gets or sets the zoom level of at the destination.</summary>
		[Export ("zoom")]
		nfloat Zoom { get; set; }

		//Should Compare be more more .Net ified ?
		/// <param name="destination">The destination against which to compare.</param>
		///         <summary>Compares this PDF destination object with the provided <paramref name="destination" />.</summary>
		///         <returns>The result of the operation.</returns>
		[Export ("compare:")]
		NSComparisonResult Compare (PdfDestination destination);
	}

	//Add attributes for delegates/events
	/// <summary>Class for working with PDF documents.</summary>
	[MacCatalyst (13, 1)]
	[TV (18, 2)]
	[DisableDefaultCtor]
	[BaseType (typeof (NSObject), Name = "PDFDocument", Delegates = new string [] { "WeakDelegate" }, Events = new Type [] { typeof (PdfDocumentDelegate) })]
	interface PdfDocument : NSCopying {

		[Field ("PDFDocumentDidUnlockNotification", "+PDFKit")]
		[Notification]
		NSString DidUnlockNotification { get; }

		[Field ("PDFDocumentDidBeginFindNotification", "+PDFKit")]
		[Notification]
		NSString DidBeginFindNotification { get; }

		[Field ("PDFDocumentDidEndFindNotification", "+PDFKit")]
		[Notification]
		NSString DidEndFindNotification { get; }

		[Field ("PDFDocumentDidBeginPageFindNotification", "+PDFKit")]
		[Notification]
		NSString DidBeginPageFindNotification { get; }

		[Field ("PDFDocumentDidEndPageFindNotification", "+PDFKit")]
		[Notification]
		NSString DidEndPageFindNotification { get; }

		[Field ("PDFDocumentDidFindMatchNotification", "+PDFKit")]
		[Notification]
		NSString DidFindMatchNotification { get; }

		[Field ("PDFDocumentDidBeginWriteNotification", "+PDFKit")]
		[Notification]
		NSString DidBeginWriteNotification { get; }

		[Field ("PDFDocumentDidEndWriteNotification", "+PDFKit")]
		[Notification]
		NSString DidEndWriteNotification { get; }

		[Field ("PDFDocumentDidBeginPageWriteNotification", "+PDFKit")]
		[Notification]
		NSString DidBeginPageWriteNotification { get; }

		[Field ("PDFDocumentDidEndPageWriteNotification", "+PDFKit")]
		[Notification]
		NSString DidEndPageWriteNotification { get; }

		[iOS (15, 0), MacCatalyst (15, 0)]
		[Field ("PDFDocumentFoundSelectionKey")]
		NSString FoundSelectionKey { get; }

		[iOS (15, 0), MacCatalyst (15, 0)]
		[Field ("PDFDocumentPageIndexKey")]
		NSString PageIndexKey { get; }

		// - (instancetype)init NS_DESIGNATED_INITIALIZER;
		/// <summary>Creates a new PDF document object with default values.</summary>
		/// <remarks />
		[Export ("init")]
		[DesignatedInitializer]
		NativeHandle Constructor ();

		/// <param name="url">The URL.</param>
		/// <summary>Creates a new PDF document object from the data at the specified URL.</summary>
		[Export ("initWithURL:")]
		[DesignatedInitializer]
		NativeHandle Constructor (NSUrl url);

		/// <param name="data">The data.</param>
		/// <summary>Creates a new PDF document object with the specified data.</summary>
		[Export ("initWithData:")]
		[DesignatedInitializer]
		NativeHandle Constructor (NSData data);

		/// <summary>Gets the URL of the PDF document.</summary>
		[Export ("documentURL")]
		[NullAllowed]
		NSUrl DocumentUrl { get; }

		/// <summary>Gets a Core Graphics PDF object for this PdfKit PDF object.</summary>
		[Export ("documentRef")]
		[NullAllowed]
		CGPDFDocument Document { get; }

		/// <summary>Gets or sets the attribute dictionary.</summary>
		[Advice ("Use the strongly typed '[Get|Set]DocumentAttributes' instead.")]
		[Export ("documentAttributes", ArgumentSemantic.Copy)]
		[NullAllowed]
		NSDictionary DocumentAttributes { get; set; }

		[iOS (15, 0), MacCatalyst (15, 0)]
		[Export ("accessPermissions")]
		PdfAccessPermissions AccessPermissions { get; }

		/// <summary>Returns a dictionary of the document's attributes.</summary>
		///         <returns>The result of the operation.</returns>
		[Wrap ("new PdfDocumentAttributes (DocumentAttributes)")]
		PdfDocumentAttributes GetDocumentAttributes ();

		/// <param name="attributes">The attributes to set.</param>
		///         <summary>Assigns the document attributes.</summary>
		[Wrap ("DocumentAttributes = attributes?.GetDictionary ()")]
		void SetDocumentAttributes ([NullAllowed] PdfDocumentAttributes attributes);

		/// <summary>Gets the major version number of the document.</summary>
		[Export ("majorVersion")]
		nint MajorVersion { get; }

		/// <summary>Gets the minor version of the document.</summary>
		[Export ("minorVersion")]
		nint MinorVersion { get; }

		/// <summary>Gets a Boolean value that tells whether the document is encrypted.</summary>
		[Export ("isEncrypted")]
		bool IsEncrypted { get; }

		/// <summary>Gets a Boolean value that tells whether the document is locked.</summary>
		[Export ("isLocked")]
		bool IsLocked { get; }

		/// <param name="password">The password to use to unlock the document.</param>
		///         <summary>Attempts to unlock the document with the specified <paramref name="password" />, returning <see langword="true" /> on success.</summary>
		///         <returns>The result of the operation.</returns>
		[Export ("unlockWithPassword:")]
		bool Unlock (string password);

		/// <summary>Gets a Boolean value that tells whether the document allows printing.</summary>
		[Export ("allowsPrinting")]
		bool AllowsPrinting { get; }

		/// <summary>Gets a Boolean value that tells whether the document allows copying.</summary>
		[Export ("allowsCopying")]
		bool AllowsCopying { get; }

		/// <summary>Gets a Boolean value that tells whether the document allows changes.</summary>
		[MacCatalyst (13, 1)]
		[Export ("allowsDocumentChanges")]
		bool AllowsDocumentChanges { get; }

		/// <summary>Gets a Boolean value that tells whether the document allows document assembly.</summary>
		[MacCatalyst (13, 1)]
		[Export ("allowsDocumentAssembly")]
		bool AllowsDocumentAssembly { get; }

		/// <summary>Gets a Boolean value that tells whether the document allows content accessibility.</summary>
		[MacCatalyst (13, 1)]
		[Export ("allowsContentAccessibility")]
		bool AllowsContentAccessibility { get; }

		/// <summary>Gets a Boolean value that tells whether the document allows comments.</summary>
		[MacCatalyst (13, 1)]
		[Export ("allowsCommenting")]
		bool AllowsCommenting { get; }

		/// <summary>Gets a Boolean value that tells whether the document allows form field entry.</summary>
		[MacCatalyst (13, 1)]
		[Export ("allowsFormFieldEntry")]
		bool AllowsFormFieldEntry { get; }

		/// <summary>Gets the PermissionsStatus value.</summary>
		[Export ("permissionsStatus")]
		PdfDocumentPermissions PermissionsStatus { get; }

		/// <summary>Gets a linefeed-separated, page-oriented string that contains the entire textual content of the PDF document.</summary>
		[Export ("string")]
		[NullAllowed]
		string Text { get; }

		/// <summary>An object that can respond to the delegate protocol for this type</summary>
		///         <value>The instance that will respond to events and data requests.</value>
		///         <remarks>
		///           <para>The delegate instance assigned to this object will be used to handle events or provide data on demand to this class.</para>
		///           <para>When setting the Delegate or WeakDelegate values events will be delivered to the specified instance instead of being delivered to the C#-style events</para>
		///           <para>   Methods must be decorated with the [Export ("selectorName")] attribute to respond to each method from the protocol.   Alternatively use the Delegate method which is strongly typed and does not require the [Export] attributes on methods.</para>
		///         </remarks>
		[Export ("delegate", ArgumentSemantic.Assign), NullAllowed]
		NSObject WeakDelegate { get; set; }

		/// <summary>An instance of the PdfKit.IPdfDocumentDelegate model class which acts as the class delegate.</summary>
		///         <value>The instance of the PdfKit.IPdfDocumentDelegate model class</value>
		///         <remarks>
		///           <para>The delegate instance assigned to this object will be used to handle events or provide data on demand to this class.</para>
		///           <para>When setting the Delegate or WeakDelegate values events will be delivered to the specified instance instead of being delivered to the C#-style events</para>
		///           <para>This is the strongly typed version of the object, developers should use the WeakDelegate property instead if they want to merely assign a class derived from NSObject that has been decorated with [Export] attributes.</para>
		///         </remarks>
		[Wrap ("WeakDelegate")]
		IPdfDocumentDelegate Delegate { get; set; }

		/// <summary>Returns an NSData object that contains the PDF data.</summary>
		///         <returns>The result of the operation.</returns>
		[Export ("dataRepresentation")]
		[return: NullAllowed]
		NSData GetDataRepresentation ();

		/// <param name="options">Options to specify how the data are returned.</param>
		///         <summary>Returns an NSData object that contains the PDF data.</summary>
		///         <returns>The result of the operation.</returns>
		[Export ("dataRepresentationWithOptions:")]
		[return: NullAllowed]
		NSData GetDataRepresentation (NSDictionary options);

		/// <param name="path">The path to which to write.</param>
		///         <summary>Writes the document to the specified path.</summary>
		///         <returns>The result of the operation.</returns>
		[Export ("writeToFile:")]
		bool Write (string path);

		/// <param name="path">The path to which to write.</param>
		///         <param name="options">The write options.</param>
		///         <summary>Writes the document to the specified path with the specified options.</summary>
		///         <returns>The result of the operation.</returns>
		[Export ("writeToFile:withOptions:")]
		bool Write (string path, [NullAllowed] NSDictionary options);

		/// <param name="path">The path to which to write.</param>
		///         <param name="options">The write options.</param>
		///         <summary>Writes the document to the specified path with the specified options.</summary>
		///         <returns>The result of the operation.</returns>
		[MacCatalyst (13, 1)]
		[Wrap ("Write (path, options.GetDictionary ()!)")]
		bool Write (string path, PdfDocumentWriteOptions options);

		/// <param name="url">The URL to which to write.</param>
		///         <summary>Writes the document to the specified URL.</summary>
		///         <returns>The result of the operation.</returns>
		[Export ("writeToURL:")]
		bool Write (NSUrl url);

		/// <param name="url">The URL to which to write.</param>
		///         <param name="options">The write options.</param>
		///         <summary>Writes the document to the specified URL with the specified options.</summary>
		///         <returns>The result of the operation.</returns>
		[Export ("writeToURL:withOptions:")]
		bool Write (NSUrl url, [NullAllowed] NSDictionary options);

		/// <param name="url">The URL to which to write.</param>
		///         <param name="options">The write options.</param>
		///         <summary>Writes the document to the specified URL with the specified options.</summary>
		///         <returns>The result of the operation.</returns>
		[MacCatalyst (13, 1)]
		[Wrap ("Write (url, options.GetDictionary ()!)")]
		bool Write (NSUrl url, PdfDocumentWriteOptions options);

		/// <summary>Gets or sets the root outline object.</summary>
		///         <value>
		///           <para>(More documentation for this node is coming)</para>
		///           <para tool="nullallowed">This value can be <see langword="null" />.</para>
		///         </value>
		[NullAllowed]
		[Export ("outlineRoot")]
		PdfOutline OutlineRoot { get; set; }

		/// <param name="selection">The selection for which to return the containing outline item.</param>
		///         <summary>Returns the outline item that represents the section where a selection resides.</summary>
		///         <returns>The result of the operation.</returns>
		[Export ("outlineItemForSelection:")]
		[return: NullAllowed]
		PdfOutline OutlineItem (PdfSelection selection);

		/// <summary>Gets the number of pages in the document.</summary>
		[Export ("pageCount")]
		nint PageCount { get; }

		/// <param name="index">The index of the page to get.</param>
		/// <summary>Returns the page at the specified zero-based index.</summary>
		/// <returns>The result of the operation.</returns>
		[Export ("pageAtIndex:")]
		[return: NullAllowed]
		PdfPage GetPage (nint index);

		/// <param name="page">The page for which to return its index.</param>
		///         <summary>Returns the zero-based index for the specified page.</summary>
		///         <returns>The result of the operation.</returns>
		[Export ("indexForPage:")]
		nint GetPageIndex (PdfPage page);

		/// <param name="page">The page to insert.</param>
		/// <param name="index">The index at which to insert the page.</param>
		/// <summary>Inserts the provided <paramref name="page" /> at the specified <paramref name="index" />.</summary>
		[Export ("insertPage:atIndex:")]
		void InsertPage (PdfPage page, nint index);

		/// <param name="index">The index of the page to remove.</param>
		/// <summary>Removes the page at the specified <paramref name="index" />.</summary>
		[Export ("removePageAtIndex:")]
		void RemovePage (nint index);

		/// <param name="indexA">The index of the first page to exchange.</param>
		/// <param name="indexB">The index of the second page to exchange.</param>
		/// <summary>Swaps the page at <paramref name="indexA" /> with the one at <paramref name="indexB" />.</summary>
		[Export ("exchangePageAtIndex:withPageAtIndex:")]
		void ExchangePages (nint indexA, nint indexB);

		/// <summary>Gets the class (Objective-C type) of pages in the document.</summary>
		[Export ("pageClass")]
		Class PageClass { get; }

		/// <summary>Gets the .NET type of page objects in this document.</summary>
		[Wrap ("Class.Lookup (PageClass)")]
		Type PageType { get; }

		/// <param name="text">The text to find.</param>
		///         <param name="compareOptions">Comparison options to control text matching.</param>
		///         <summary>Searches for the specified text with the specified comparison options.</summary>
		///         <returns>The result of the operation.</returns>
		[Export ("findString:withOptions:")]
		PdfSelection [] Find (string text, NSStringCompareOptions compareOptions);

		/// <param name="text">The text to find.</param>
		///         <param name="compareOptions">Comparison options to control text matching.</param>
		///         <summary>Asynchronously searches for the specified text with the specified comparison options.</summary>
		[Export ("beginFindString:withOptions:")]
		[return: NullAllowed]
		void FindAsync (string text, NSStringCompareOptions compareOptions);

		/// <param name="text">The text to find.</param>
		///         <param name="compareOptions">Comparison options to control text matching.</param>
		///         <summary>Asynchronously searches for the specified text with the specified comparison options.</summary>
		[Export ("beginFindStrings:withOptions:")]
		[return: NullAllowed]
		void FindAsync (string [] text, NSStringCompareOptions compareOptions);

		/// <param name="text">The text to find.</param>
		///         <param name="selection">The selection to search.</param>
		///         <param name="compareOptions">Comparison options to control text matching.</param>
		///         <summary>Searches for the specified text in a selection with the specified comparison options.</summary>
		///         <returns>The result of the operation.</returns>
		[Export ("findString:fromSelection:withOptions:")]
		[return: NullAllowed]
		PdfSelection Find (string text, [NullAllowed] PdfSelection selection, NSStringCompareOptions compareOptions);

		/// <summary>Gets a Boolean value that tells whether the document is currently searching for text.</summary>
		[Export ("isFinding")]
		bool IsFinding { get; }

		/// <summary>Cancels an in-progress find operation.</summary>
		[Export ("cancelFindString")]
		void CancelFind ();

		/// <summary>Returns a selection that contains the entire document.</summary>
		///         <returns>The result of the operation.</returns>
		[Export ("selectionForEntireDocument")]
		[return: NullAllowed]
		PdfSelection SelectEntireDocument ();

		/// <param name="startPage">The page at the start of the selection.</param>
		///         <param name="startPoint">The point on the page at the start of the selection.</param>
		///         <param name="endPage">The page at the end of the selection.</param>
		///         <param name="endPoint">The point on the page at the end of the selection.</param>
		///         <summary>Returns a selection for the region that is described by the specified parameters.</summary>
		///         <returns>The result of the operation.</returns>
		[Export ("selectionFromPage:atPoint:toPage:atPoint:")]
		[return: NullAllowed]
		PdfSelection GetSelection (PdfPage startPage, CGPoint startPoint, PdfPage endPage, CGPoint endPoint);

		/// <param name="startPage">The page at the start of the selection.</param>
		/// <param name="startCharIndex">The character index on the start page for the start of the selection.</param>
		/// <param name="endPage">The page at the end of the selection.</param>
		/// <param name="endCharIndex">The character index on the end page for the end of the selection.</param>
		/// <summary>Returns a selection for the region that is described by the specified parameters.</summary>
		/// <returns>The result of the operation.</returns>
		[Export ("selectionFromPage:atCharacterIndex:toPage:atCharacterIndex:")]
		[return: NullAllowed]
		PdfSelection GetSelection (PdfPage startPage, nint startCharIndex, PdfPage endPage, nint endCharIndex);

		/// <param name="printInfo">The print info.</param>
		///         <param name="scaleMode">The scale mode.</param>
		///         <param name="doRotate">Whether to rotate.</param>
		///         <summary>Performs the PDF operation.</summary>
		///         <returns>The result of the operation.</returns>
		[NoiOS]
		[NoMacCatalyst]
		[NoTV]
		[Export ("printOperationForPrintInfo:scalingMode:autoRotate:")]
		[return: NullAllowed]
#pragma warning disable 0618 // 'PdfPrintScalingMode' is obsolete: 'This type is not available on iOS.'
		NSPrintOperation GetPrintOperation ([NullAllowed] NSPrintInfo printInfo, PdfPrintScalingMode scaleMode, bool doRotate);
#pragma warning restore

		[Mac (15, 0), iOS (18, 0), MacCatalyst (18, 0)]
		[Export ("selectionFromPage:atPoint:toPage:atPoint:withGranularity:")]
		[return: NullAllowed]
		PdfSelection GetSelection (PdfPage startPage, CGPoint startPoint, PdfPage endPage, CGPoint endPoint, PdfSelectionGranularity granularity);
	}

	interface IPdfDocumentDelegate { }

	/// <summary>Delegate object for the <see cref="PdfKit.PdfDocument" /> class, presenting methods relating to search process and results.</summary>
	[MacCatalyst (13, 1)]
	[TV (18, 2)]
	[BaseType (typeof (NSObject), Name = "PDFDocumentDelegate")]
#if IOS
	[Protocol]
#else
	[Protocol (FormalSince = "10.13", Name = "PDFDocumentDelegate")]
#endif
	[Model]
	interface PdfDocumentDelegate {

		/// <param name="notification">The notification.</param>
		///         <summary>Performs the PDF operation.</summary>
		[Export ("documentDidUnlock:"), EventArgs ("NSNotification", XmlDocs = """
			<summary>Event raised by the object.</summary>
			<remarks>If developers do not assign a value to this event, this will reset the value for the WeakDelegate property to an internal handler that maps delegates to events.</remarks>
			""")]
		void DidUnlock (NSNotification notification);

		/// <param name="notification">The notification.</param>
		///         <summary>Performs the PDF operation.</summary>
		[Export ("documentDidBeginDocumentFind:"), EventArgs ("NSNotification", XmlDocs = """
			<summary>Event raised by the object.</summary>
			<remarks>If developers do not assign a value to this event, this will reset the value for the WeakDelegate property to an internal handler that maps delegates to events.</remarks>
			""")]
		void DidBeginDocumentFind (NSNotification notification);

		/// <param name="sender">The sender.</param>
		///         <summary>Performs the PDF operation.</summary>
		[Export ("didMatchString:"), EventArgs ("PdfSelection", XmlDocs = """
			<summary>Event raised by the object.</summary>
			<remarks>If developers do not assign a value to this event, this will reset the value for the WeakDelegate property to an internal handler that maps delegates to events.</remarks>
			""")]
		void DidMatchString (PdfSelection sender);

		/// <summary>Performs the get class for page operation.</summary>
		///         <returns>The result of the operation.</returns>
		[Export ("classForPage"), IgnoredInDelegate]
		Class GetClassForPage ();

		/// <param name="annotationType">The annotation type.</param>
		///         <summary>Performs the PDF operation.</summary>
		///         <returns>The result of the operation.</returns>
		[EventArgs ("", XmlDocs = """
			<summary>Delegate invoked by the object to get a value.</summary>
			<remarks>Developers assign a function, delegate or anonymous method to this property to return a value to the object.   If developers assign a value to this property, it this will reset the value for the WeakDelegate property to an internal handler that maps delegates to events.</remarks>
			""")]
		[MacCatalyst (13, 1)]
		[DelegateName ("ClassForAnnotationTypeDelegate"), DefaultValue (null)]
		[Export ("classForAnnotationType:")]
		Class GetClassForAnnotationType (string annotationType);

		[NoiOS]
		[Deprecated (PlatformName.MacOSX, 10, 12, message: "Use 'GetClassForAnnotationType' instead.")]
		[NoTV]
		[NoMacCatalyst]
		[Export ("classForAnnotationClass:"), DelegateName ("ClassForAnnotationClassDelegate"), DefaultValue (null)]
		Class GetClassForAnnotationClass (Class sender);

		/// <param name="notification">The notification.</param>
		///         <summary>Performs the PDF operation.</summary>
		[Export ("documentDidEndDocumentFind:"), EventArgs ("NSNotification", XmlDocs = """
			<summary>Event raised by the object.</summary>
			<remarks>If developers do not assign a value to this event, this will reset the value for the WeakDelegate property to an internal handler that maps delegates to events.</remarks>
			""")]
		void FindFinished (NSNotification notification);

		/// <param name="notification">The notification.</param>
		///         <summary>Performs the PDF operation.</summary>
		[Export ("documentDidBeginPageFind:"), EventArgs ("NSNotification", XmlDocs = """
			<summary>Event raised by the object.</summary>
			<remarks>If developers do not assign a value to this event, this will reset the value for the WeakDelegate property to an internal handler that maps delegates to events.</remarks>
			""")]
		void PageFindStarted (NSNotification notification);

		/// <param name="notification">The notification.</param>
		///         <summary>Performs the PDF operation.</summary>
		[Export ("documentDidEndPageFind:"), EventArgs ("NSNotification", XmlDocs = """
			<summary>Event raised by the object.</summary>
			<remarks>If developers do not assign a value to this event, this will reset the value for the WeakDelegate property to an internal handler that maps delegates to events.</remarks>
			""")]
		void PageFindFinished (NSNotification notification);

		/// <param name="notification">The notification.</param>
		///         <summary>Performs the PDF operation.</summary>
		[Export ("documentDidFindMatch:"), EventArgs ("NSNotification", XmlDocs = """
			<summary>Event raised by the object.</summary>
			<remarks>If developers do not assign a value to this event, this will reset the value for the WeakDelegate property to an internal handler that maps delegates to events.</remarks>
			""")]
		void MatchFound (NSNotification notification);
	}

	/// <summary>A node in a logical outline of a PDF document.</summary>
	[MacCatalyst (13, 1)]
	[TV (18, 2)]
	[DisableDefaultCtor]
	[BaseType (typeof (NSObject), Name = "PDFOutline")]
	interface PdfOutline {

		// - (instancetype)init NS_DESIGNATED_INITIALIZER;
		/// <summary>Creates a new PDF outline object with default values.</summary>
		/// <remarks />
		[Export ("init")]
		[DesignatedInitializer]
		NativeHandle Constructor ();

		/// <summary>Gets the document for which this outline node participates in an outline.</summary>
		[Export ("document")]
		[NullAllowed]
		PdfDocument Document { get; }

		/// <summary>Gets the parent outline node.</summary>
		///         <value>
		///           <para>(More documentation for this node is coming)</para>
		///           <para tool="nullallowed">This value can be <see langword="null" />.</para>
		///         </value>
		[Export ("parent"), NullAllowed]
		PdfOutline Parent { get; }

		/// <summary>Gets the number of children that this outline node has.</summary>
		[Export ("numberOfChildren")]
		nint ChildrenCount { get; }

		/// <summary>Gets the index of this outline node within the parent node's list of childrent.</summary>
		[Export ("index")]
		nint Index { get; }

		/// <param name="index">The index.</param>
		/// <summary>Returns the child outline object at the specified <paramref name="index" /> in the children of this outline node.</summary>
		/// <returns>The result of the operation.</returns>
		[return: NullAllowed]
		[Export ("childAtIndex:")]
		PdfOutline Child (nint index);

		/// <param name="child">The outline to insert.</param>
		/// <param name="index">The index at which to insert the child outline.</param>
		/// <summary>Inserts the specified node in the list of children at the specified index.</summary>
		[Export ("insertChild:atIndex:")]
		void InsertChild (PdfOutline child, nint index);

		/// <summary>Removes this outline node from its parent.</summary>
		[Export ("removeFromParent")]
		void RemoveFromParent ();

		/// <summary>Gets or sets the label for the node.</summary>
		[Export ("label")]
		[NullAllowed]
		string Label { get; set; }

		/// <summary>Gets or sets a Boolean value that tells whether the outline is displayed when the document opens.</summary>
		[Export ("isOpen")]
		bool IsOpen { get; set; }

		/// <summary>Gets or sets the destination in the PDF that this outline node represents.</summary>
		///         <value>
		///           <para>(More documentation for this node is coming)</para>
		///           <para tool="nullallowed">This value can be <see langword="null" />.</para>
		///         </value>
		[Export ("destination"), NullAllowed]
		PdfDestination Destination { get; set; }

		/// <summary>Gets or sets the action to perform when responding to user taps on the outline.</summary>
		///         <value>
		///           <para>(More documentation for this node is coming)</para>
		///           <para tool="nullallowed">This value can be <see langword="null" />.</para>
		///         </value>
		[MacCatalyst (13, 1)]
		[Export ("action"), NullAllowed]
		PdfAction Action { get; set; }
	}

	/// <summary>Class for working with and rendering PDF pages.</summary>
	[MacCatalyst (13, 1)]
	[TV (18, 2)]
	[DisableDefaultCtor]
	[BaseType (typeof (NSObject), Name = "PDFPage")]
	interface PdfPage : NSCopying {

		// - (instancetype)init NS_DESIGNATED_INITIALIZER;
		/// <summary>Creates a new PDF page object with default values.</summary>
		/// <remarks />
		[Export ("init")]
		[DesignatedInitializer]
		NativeHandle Constructor ();

		/// <param name="image">The image.</param>
		/// <summary>Creates a new PDF page object from the specified <paramref name="image" />.</summary>
		[Export ("initWithImage:")]
		NativeHandle Constructor (NSImage image);

		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Mac (13, 0), iOS (16, 0), MacCatalyst (16, 0)]
		[DesignatedInitializer]
		[Export ("initWithImage:options:")]
		NativeHandle Constructor (NSImage image, NSDictionary options);

		[Mac (13, 0), iOS (16, 0), MacCatalyst (16, 0)]
		[Wrap ("this (image, options.GetDictionary ()!)")]
		NativeHandle Constructor (NSImage image, PdfPageImageInitializationOption options);

		/// <summary>Gets the PDF document object that contains the PDF page.</summary>
		///         <value>
		///           <para>(More documentation for this node is coming)</para>
		///           <para tool="nullallowed">This value can be <see langword="null" />.</para>
		///         </value>
		[Export ("document"), NullAllowed]
		PdfDocument Document { get; }

		/// <summary>Gets the Core Graphics PDFPage object for this PDF page.</summary>
		///         <value>
		///           <para>(More documentation for this node is coming)</para>
		///           <para tool="nullallowed">This value can be <see langword="null" />.</para>
		///         </value>
		[Export ("pageRef"), NullAllowed]
		CGPDFPage Page { get; }

		/// <summary>Gets the page label.</summary>
		///         <value>
		///           <para>(More documentation for this node is coming)</para>
		///           <para tool="nullallowed">This value can be <see langword="null" />.</para>
		///         </value>
		[Export ("label"), NullAllowed]
		string Label { get; }

		/// <param name="box">The box for which to get the bounding rectangle.</param>
		///         <summary>Returns a rectangle that describes the bounds for the specified display box.</summary>
		///         <returns>The result of the operation.</returns>
		[Export ("boundsForBox:")]
		CGRect GetBoundsForBox (PdfDisplayBox box);

		/// <param name="bounds">The bounds to set.</param>
		///         <param name="box">The box for which to set the bounds.</param>
		///         <summary>Sets the bounds for the specified box, creating a box if none exists.</summary>
		[Export ("setBounds:forBox:")]
		void SetBoundsForBox (CGRect bounds, PdfDisplayBox box);

		/// <summary>Gets or sets the rotation, in degrees, for displaying the page.</summary>
		[Export ("rotation")]
		nint Rotation { get; set; } // - (NSInteger) rotation; - rotation is not consistently declared

		//Check  Docs say: "array will _most likely_ be typed to subclasses of the PdfAnnotation class"
		//do they mean that if it isn't a subclass it is the base class ??
		//Maybe we should be safe and return NSArray ??
		/// <summary>Gets an array that contains all the annotations on the PDF page.</summary>
		[Export ("annotations")]
		PdfAnnotation [] Annotations { get; }

		/// <summary>Gets or sets a Boolean value that controls whether annotations are displayed.</summary>
		[Export ("displaysAnnotations")]
		bool DisplaysAnnotations { get; set; }

		/// <param name="annotation">The annotation to add.</param>
		///         <summary>Adds the specified annotation to the PDF page.</summary>
		[Export ("addAnnotation:")]
		void AddAnnotation (PdfAnnotation annotation);

		/// <param name="annotation">The annotation to remove.</param>
		///         <summary>Removes the specified annotation.</summary>
		[Export ("removeAnnotation:")]
		void RemoveAnnotation (PdfAnnotation annotation);

		/// <param name="point">The point for which to attempt to get an annotation.</param>
		///         <summary>Returns the annotation for the specified point on the page, or <see langword="null" /> if the point is not annotated.</summary>
		///         <returns>The result of the operation.</returns>
		[Export ("annotationAtPoint:")]
		[return: NullAllowed]
		PdfAnnotation GetAnnotation (CGPoint point);

		/// <param name="box">The PDF display box.</param>
		///         <summary>Performs the get transform operation.</summary>
		///         <returns>The result of the operation.</returns>
		[MacCatalyst (13, 1)]
		[Export ("transformForBox:")]
		CGAffineTransform GetTransform (PdfDisplayBox box);

		/// <param name="box">The PDF display box.</param>
		///         <summary>Performs the draw operation.</summary>
		[NoiOS]
		[Deprecated (PlatformName.MacOSX, 10, 12)]
		[NoMacCatalyst]
		[NoTV]
		[Export ("drawWithBox:")]
		void Draw (PdfDisplayBox box);

		/// <param name="box">The PDF display box.</param>
		///         <param name="context">The graphics context.</param>
		///         <summary>Performs the draw operation.</summary>
		[MacCatalyst (13, 1)]
		[Export ("drawWithBox:toContext:")]
		void Draw (PdfDisplayBox box, CGContext context);

		/// <param name="context">The graphics context.</param>
		///         <param name="box">The PDF display box.</param>
		///         <summary>Performs the transform context operation.</summary>
		[MacCatalyst (13, 1)]
		[Export ("transformContext:forBox:")]
		void TransformContext (CGContext context, PdfDisplayBox box);

		/// <summary>Get a thumbnail for this page of the specified <paramref name="size" />.</summary>
		/// <param name="size">The size of the returned thumbnail.</param>
		/// <param name="box">The box type where the thumbnail will be rendered.</param>
		[MacCatalyst (13, 1)]
		[Export ("thumbnailOfSize:forBox:")]
		NSImage GetThumbnail (CGSize size, PdfDisplayBox box);

		/// <param name="box">The PDF display box.</param>
		///         <summary>Performs the transform context operation.</summary>
		[NoiOS]
		[Deprecated (PlatformName.MacOSX, 10, 12)]
		[NoMacCatalyst]
		[NoTV]
		[Export ("transformContextForBox:")]
		void TransformContext (PdfDisplayBox box);

		/// <summary>Gets the number of characters in the text content of the PDF page.</summary>
		[Export ("numberOfCharacters")]
		nint CharacterCount { get; }

		/// <summary>Gets the text content of the page.</summary>
		[Export ("string")]
		[NullAllowed]
		string Text { get; }

		/// <summary>Gets the text contents of the PDF page as an annotate string.</summary>
		[Export ("attributedString")]
		[NullAllowed]
		NSAttributedString AttributedString { get; }

		/// <param name="index">The index of the character for which to get its bounding box.</param>
		/// <summary>Returns a rectangle that describes the bounds for the character at the specified index.</summary>
		/// <returns>The result of the operation.</returns>
		[Export ("characterBoundsAtIndex:")]
		CGRect GetCharacterBounds (nint index);

		/// <param name="point">The point over a character for which to get its bounding box.</param>
		///         <summary>Returns the index of the character at the specified point.</summary>
		///         <returns>The result of the operation.</returns>
		[Export ("characterIndexAtPoint:")]
		nint GetCharacterIndex (CGPoint point);

		/// <param name="rect">The rectangle, in user coordinates, for which to get the selection.</param>
		///         <summary>Returns the text in the specified rectangle.</summary>
		///         <returns>The result of the operation.</returns>
		[Export ("selectionForRect:")]
		[return: NullAllowed]
		PdfSelection GetSelection (CGRect rect);

		/// <param name="point">A point on the word to select.</param>
		///         <summary>Returns the word that is under the specified point.</summary>
		///         <returns>The result of the operation.</returns>
		[Export ("selectionForWordAtPoint:")]
		[return: NullAllowed]
		PdfSelection SelectWord (CGPoint point);

		/// <param name="point">A point on the line to select.</param>
		///         <summary>Returns the line of text that is under the specified point.</summary>
		///         <returns>The result of the operation.</returns>
		[Export ("selectionForLineAtPoint:")]
		[return: NullAllowed]
		PdfSelection SelectLine (CGPoint point);

		/// <param name="startPoint">The first point of the selection rectangle.</param>
		///         <param name="endPoint">The final point of the selection rectangle.</param>
		///         <summary>Returns the text in the rectangle that is specified by the user-coordinate-space start and end points.</summary>
		///         <returns>The result of the operation.</returns>
		[Export ("selectionFromPoint:toPoint:")]
		[return: NullAllowed]
		PdfSelection GetSelection (CGPoint startPoint, CGPoint endPoint);

		/// <param name="range">The text range to select.</param>
		///         <summary>Returns a selection for the specified range.</summary>
		///         <returns>The result of the operation.</returns>
		[Export ("selectionForRange:")]
		[return: NullAllowed]
		PdfSelection GetSelection (NSRange range);

		/// <summary>Gets the PDF page data as an NSData object.</summary>
		///         <value>
		///           <para>(More documentation for this node is coming)</para>
		///           <para tool="nullallowed">This value can be <see langword="null" />.</para>
		///         </value>
		[Export ("dataRepresentation"), NullAllowed]
		NSData DataRepresentation { get; }
	}

	/// <summary>A text selection in a PDF document.</summary>
	[MacCatalyst (13, 1)]
	[TV (18, 2)]
	[BaseType (typeof (NSObject), Name = "PDFSelection")]
	[DisableDefaultCtor] // An uncaught exception was raised: init: not a valid initializer for PDFSelection
	interface PdfSelection : NSCopying {

		/// <param name="document">The PDF document.</param>
		/// <summary>Creates a new, empty, PDF selection object.</summary>
		[DesignatedInitializer]
		[Export ("initWithDocument:")]
		NativeHandle Constructor (PdfDocument document);

		/// <summary>Returns the pages that are in the selection.</summary>
		[Export ("pages")]
		PdfPage [] Pages { get; }

		/// <summary>Gets or sets the color with which to draw the selection.</summary>
		///         <value>
		///           <para>This overrides both the active and inactive selection drawing colors.</para>
		///           <para tool="nullallowed">This value can be <see langword="null" />.</para>
		///         </value>
		[Export ("color", ArgumentSemantic.Copy), NullAllowed]
		NSColor Color { get; set; }

		/// <summary>Gets the text of the selection.</summary>
		///         <value>
		///           <para>(More documentation for this node is coming)</para>
		///           <para tool="nullallowed">This value can be <see langword="null" />.</para>
		///         </value>
		[Export ("string"), NullAllowed]
		string Text { get; }

		/// <summary>Returns an attributed string for this selection.</summary>
		///         <value>
		///           <para>(More documentation for this node is coming)</para>
		///           <para tool="nullallowed">This value can be <see langword="null" />.</para>
		///         </value>
		[Export ("attributedString"), NullAllowed]
		NSAttributedString AttributedString { get; }

		/// <param name="page">The PDF page.</param>
		///         <summary>Returns the selection bounds for the portion of the selection that is on the specified <paramref name="page" />.</summary>
		///         <returns>The result of the operation.</returns>
		[Export ("boundsForPage:")]
		CGRect GetBoundsForPage (PdfPage page);

		/// <param name="page">The PDF page.</param>
		///         <summary>Performs the get number of text ranges operation.</summary>
		///         <returns>The result of the operation.</returns>
		[Export ("numberOfTextRangesOnPage:")]
		nuint GetNumberOfTextRanges (PdfPage page);

		/// <param name="index">The index.</param>
		/// <param name="page">The PDF page.</param>
		/// <summary>Performs the get range operation.</summary>
		/// <returns>The result of the operation.</returns>
		[Export ("rangeAtIndex:onPage:")]
		NSRange GetRange (nuint index, PdfPage page);

		/// <summary>Returns an array that contains the selected lines.</summary>
		///         <returns>The result of the operation.</returns>
		[Export ("selectionsByLine")]
		PdfSelection [] SelectionsByLine ();

		/// <param name="selection">The PDF selection.</param>
		///         <summary>Adds the provided <paramref name="selection" /> to this selection.</summary>
		[Export ("addSelection:")]
		void AddSelection (PdfSelection selection);

		/// <param name="selections">The array of selections.</param>
		///         <summary>Adds the provided <paramref name="selections" /> to this selection.</summary>
		[Export ("addSelections:")]
		void AddSelections (PdfSelection [] selections);

		/// <param name="succeed">The selection that follows.</param>
		/// <summary>Extends the end of the selection to the position that is indicated by <paramref name="succeed" />.</summary>
		[Export ("extendSelectionAtEnd:")]
		void ExtendSelectionAtEnd (nint succeed);

		/// <param name="precede">The selection that precedes.</param>
		/// <summary>Extends the beginning of the selection to the position that is indicated by <paramref name="precede" />.</summary>
		[Export ("extendSelectionAtStart:")]
		void ExtendSelectionAtStart (nint precede);

		/// <summary>Performs the extend selection for line boundaries operation.</summary>
		[MacCatalyst (13, 1)]
		[Export ("extendSelectionForLineBoundaries")]
		void ExtendSelectionForLineBoundaries ();

		/// <param name="page">The PDF page.</param>
		///         <param name="active">Whether the selection is active.</param>
		///         <summary>Draws the default highlight rectangle in the current highlight color.</summary>
		[Export ("drawForPage:active:")]
		void Draw (PdfPage page, bool active);

		/// <param name="page">The PDF page.</param>
		///         <param name="box">The PDF display box.</param>
		///         <param name="active">Whether the selection is active.</param>
		///         <summary>Draws the specified highlight rectangle (<paramref name="box" />) in the current highlight color.</summary>
		[Export ("drawForPage:withBox:active:")]
		void Draw (PdfPage page, PdfDisplayBox box, bool active);
	}

	/// <summary>A list of thumbnail images for each page of a document.</summary>
	[MacCatalyst (13, 1)]
	[TV (18, 2)]
	[BaseType (typeof (NSView), Name = "PDFThumbnailView")]
	interface PdfThumbnailView : NSCoding {

		/// <param name="frame">Frame used by the view, expressed in iOS points.</param>
		/// <summary>Initializes the PdfThumbnailView with the specified frame.</summary>
		/// <remarks>
		///           <para>This constructor is used to programmatically create a new instance of PdfThumbnailView with the specified dimension in the frame.   The object will only be displayed once it has been added to a view hierarchy by calling AddSubview in a containing view.</para>
		///           <para>This constructor is not invoked when deserializing objects from storyboards or XIB files; instead, the constructor that takes an NSCoder parameter is invoked.</para>
		///         </remarks>
		[Export ("initWithFrame:")]
		NativeHandle Constructor (CGRect frame);

		[Field ("PDFThumbnailViewDocumentEditedNotification", "+PDFKit")]
		[Notification]
		NSString DocumentEditedNotification { get; }

		/// <summary>Returns the PDFView that displays the thumbnail view.</summary>
		///         <value>
		///           <para>(More documentation for this node is coming)</para>
		///           <para tool="nullallowed">This value can be <see langword="null" />.</para>
		///         </value>
		[Export ("PDFView", ArgumentSemantic.Weak)]
		[NullAllowed]
		PdfView PdfView { get; set; }

		/// <summary>Gets or sets the maximum thumbnail size.</summary>
		[Export ("thumbnailSize")]
		CGSize ThumbnailSize { get; set; }

		/// <summary>Gets or sets the LayoutMode value.</summary>
		[NoMac]
		[MacCatalyst (13, 1)]
		[Export ("layoutMode")]
		PdfThumbnailLayoutMode LayoutMode { get; set; }

		/// <summary>Gets or sets the ContentInset value.</summary>
		[NoMac]
		[MacCatalyst (13, 1)]
		[Export ("contentInset")]
		NSEdgeInsets ContentInset { get; set; }

		/// <summary>Gets or sets the MaximumNumberOfColumns value.</summary>
		[NoiOS]
		[NoMacCatalyst]
		[NoTV]
		[Export ("maximumNumberOfColumns")]
		nint MaximumNumberOfColumns { get; set; }

		/// <summary>Gets or sets the LabelFont value.</summary>
		[NoiOS]
		[NoMacCatalyst]
		[NoTV]
		[Export ("labelFont")]
		[NullAllowed]
		NSFont LabelFont { get; set; }

		/// <summary>Gets or sets the background color against which page thumbnails are displayed.</summary>
		[Export ("backgroundColor", ArgumentSemantic.Copy)]
		[NullAllowed]
		NSColor BackgroundColor { get; set; }

		/// <summary>Gets or sets the AllowsDragging value.</summary>
		[NoiOS]
		[NoMacCatalyst]
		[NoTV]
		[Export ("allowsDragging")]
		bool AllowsDragging { get; set; }

		/// <summary>Gets or sets the AllowsMultipleSelection value.</summary>
		[NoiOS]
		[NoMacCatalyst]
		[NoTV]
		[Export ("allowsMultipleSelection")]
		bool AllowsMultipleSelection { get; set; }

		/// <summary>Gets an array of the selected pages.</summary>
		///         <value>
		///           <para>(More documentation for this node is coming)</para>
		///           <para tool="nullallowed">This value can be <see langword="null" />.</para>
		///         </value>
		[Export ("selectedPages", ArgumentSemantic.Strong), NullAllowed]
		PdfPage [] SelectedPages { get; }
	}

	/// <summary>A viewer for PDF files.</summary>
	[MacCatalyst (13, 1)]
	[TV (18, 2)]
	[BaseType (typeof (NSView), Name = "PDFView", Delegates = new string [] { "WeakDelegate" }, Events = new Type [] { typeof (PdfViewDelegate) })]
#if TVOS
	[DisableDefaultCtor]
#endif
	interface PdfView :
#if IOS
	UIGestureRecognizerDelegate, UIFindInteractionDelegate
#elif TVOS
	UIFindInteractionDelegate
#else
	NSMenuDelegate, NSAnimationDelegate
#endif
	{
		/// <param name="frame">Frame used by the view, expressed in iOS points.</param>
		/// <summary>Initializes the PdfView with the specified frame.</summary>
		/// <remarks>
		///           <para>This constructor is used to programmatically create a new instance of PdfView with the specified dimension in the frame.   The object will only be displayed once it has been added to a view hierarchy by calling AddSubview in a containing view.</para>
		///           <para>This constructor is not invoked when deserializing objects from storyboards or XIB files; instead, the constructor that takes an NSCoder parameter is invoked.</para>
		///         </remarks>
		[Export ("initWithFrame:")]
		NativeHandle Constructor (CGRect frame);

		/// <summary>Gets or sets the document to display.</summary>
		///         <value>
		///           <para>(More documentation for this node is coming)</para>
		///           <para tool="nullallowed">This value can be <see langword="null" />.</para>
		///         </value>
		[Export ("document"), NullAllowed]
		PdfDocument Document { get; set; }

		/// <summary>Gets a Boolean value that tells whether the view can navigate to the first page.</summary>
		[Export ("canGoToFirstPage")]
		bool CanGoToFirstPage { get; }

		//Verify
		/// <param name="sender">The object that requested the operation.</param>
		///         <summary>Goes to the first page of the PDF.</summary>
		[Export ("goToFirstPage:")]
		void GoToFirstPage ([NullAllowed] NSObject sender);

		/// <summary>Gets a Boolean value that tells whether the view can navigate to the last page.</summary>
		[Export ("canGoToLastPage")]
		bool CanGoToLastPage { get; }

		/// <param name="sender">The object that requested the operation..</param>
		///         <summary>Goes to the last page of the PDF.</summary>
		[Export ("goToLastPage:")]
		void GoToLastPage ([NullAllowed] NSObject sender);

		/// <summary>Gets a Boolean value that tells whether the view can navigate to the next page.</summary>
		[Export ("canGoToNextPage")]
		bool CanGoToNextPage { get; }

		/// <param name="sender">The object that requested the operation.</param>
		///         <summary>Goes to the next page in the PDF.</summary>
		[Export ("goToNextPage:")]
		void GoToNextPage ([NullAllowed] NSObject sender);

		/// <summary>Gets a Boolean value that tells whether the view can navigate to the previous page.</summary>
		[Export ("canGoToPreviousPage")]
		bool CanGoToPreviousPage { get; }

		/// <param name="sender">The object that requested the operation.</param>
		///         <summary>Goes to the previous page in the PDF.</summary>
		[Export ("goToPreviousPage:")]
		void GoToPreviousPage ([NullAllowed] NSObject sender);

		/// <summary>Gets a Boolean value that tells whether the view can navigate back one page.</summary>
		[Export ("canGoBack")]
		bool CanGoBack { get; }

		/// <param name="sender">The object that requested the operation.</param>
		///         <summary>Goes back one page in the history.</summary>
		[Export ("goBack:")]
		void GoBack ([NullAllowed] NSObject sender);

		/// <summary>Gets a Boolean value that tells whether the view can navigate forward one page.</summary>
		[Export ("canGoForward")]
		bool CanGoForward { get; }

		/// <param name="sender">The object that requested the operation.</param>
		///         <summary>Goes forward one page in the history.</summary>
		[Export ("goForward:")]
		void GoForward ([NullAllowed] NSObject sender);

		/// <summary>Gets the currently displayed page.</summary>
		[Export ("currentPage")]
		[NullAllowed]
		PdfPage CurrentPage { get; }

		/// <param name="page">The page to which to go.</param>
		///         <summary>Goes to the specified page.</summary>
		[Export ("goToPage:")]
		void GoToPage (PdfPage page);

		/// <summary>Gets the currently displayed location.</summary>
		[Export ("currentDestination")]
		[NullAllowed]
		PdfDestination CurrentDestination { get; }

		/// <param name="destination">The destination to which to go.</param>
		///         <summary>Goes to the specified <paramref name="destination" />.</summary>
		[Export ("goToDestination:")]
		void GoToDestination (PdfDestination destination);

		/// <param name="selection">The selection to which to go.</param>
		///         <summary>Goes to the specified selection.</summary>
		[Export ("goToSelection:")]
		void GoToSelection (PdfSelection selection);

		/// <param name="rect">The rectangle to which to go.</param>
		///         <param name="page">The page that contains the rectangle.</param>
		///         <summary>Goes to the specified rectangle on the specified page.</summary>
		[Export ("goToRect:onPage:")]
		void GoToRectangle (CGRect rect, PdfPage page);

		/// <summary>Gets or sets the display mode.</summary>
		[Export ("displayMode")]
		PdfDisplayMode DisplayMode { get; set; }

		/// <summary>Gets or sets the DisplayDirection value.</summary>
		[MacCatalyst (13, 1)]
		[Export ("displayDirection")]
		PdfDisplayDirection DisplayDirection { get; set; }

		/// <summary>Gets or sets a Boolean value that controls whether page breaks will be displayed.</summary>
		[Export ("displaysPageBreaks")]
		bool DisplaysPageBreaks { get; set; }

		/// <summary>Gets or sets the PageBreakMargins value.</summary>
		[MacCatalyst (13, 1)]
		[Export ("pageBreakMargins")]
		NSEdgeInsets PageBreakMargins { get; set; }

		/// <summary>Gets or sets the display box style.</summary>
		[Export ("displayBox")]
		PdfDisplayBox DisplayBox { get; set; }

		/// <summary>Gets or sets a Boolean value that controls whether the first page is displayed as a book cover for two-up or two-up continuous display.</summary>
		[Export ("displaysAsBook")]
		bool DisplaysAsBook { get; set; }

		/// <summary>Gets or sets the DisplaysRtl value.</summary>
		[MacCatalyst (13, 1)]
		[Export ("displaysRTL")]
		bool DisplaysRtl { get; set; }

		/// <summary>Gets or sets the ShouldAntiAlias value.</summary>
		[NoiOS]
		[Deprecated (PlatformName.MacOSX, 10, 12)]
		[NoMacCatalyst]
		[NoTV]
		[Export ("shouldAntiAlias")]
		bool ShouldAntiAlias { get; set; }

		/// <summary>Developers should not use this deprecated property. </summary>
		[NoiOS]
		[Deprecated (PlatformName.MacOSX, 10, 12)]
		[NoMacCatalyst]
		[NoTV]
		[Export ("greekingThreshold")]
		nfloat GreekingThreshold { get; set; }

		/// <param name="sender">The sender.</param>
		///         <summary>Performs the take background color operation.</summary>
		[NoiOS]
		[Deprecated (PlatformName.MacOSX, 10, 12)]
		[NoMacCatalyst]
		[NoTV]
		[Export ("takeBackgroundColorFrom:")]
		void TakeBackgroundColor (NSObject sender);

		/// <summary>Gets or sets the background color for the view.</summary>
		[Export ("backgroundColor")]
		NSColor BackgroundColor { get; set; }

		/// <summary>Gets or sets the InterpolationQuality value.</summary>
		[Export ("interpolationQuality", ArgumentSemantic.Assign)]
		PdfInterpolationQuality InterpolationQuality { get; set; }

		/// <summary>Gets or sets the PageShadowsEnabled value.</summary>
		[MacCatalyst (13, 1)]
		[Export ("pageShadowsEnabled")]
		bool PageShadowsEnabled { get; [Bind ("enablePageShadows:")] set; }

		/// <param name="enable">Whether to enable.</param>
		///         <param name="viewOptions">
		///           <para>A task representing the asynchronous operation.</para>
		///           <para tool="nullallowed">This parameter can be <see langword="null" />.</para>
		///         </param>
		///         <summary>Performs the use page view controller operation.</summary>
		[NoMac]
		[MacCatalyst (13, 1)]
		[Export ("usePageViewController:withViewOptions:")]
		void UsePageViewController (bool enable, [NullAllowed] NSDictionary viewOptions);

		/// <summary>Gets the IsUsingPageViewController value.</summary>
		[NoMac]
		[MacCatalyst (13, 1)]
		[Export ("isUsingPageViewController")]
		bool IsUsingPageViewController { get; }

		/// <summary>An object that can respond to the delegate protocol for this type</summary>
		///         <value>The instance that will respond to events and data requests.</value>
		///         <remarks>
		///           <para>The delegate instance assigned to this object will be used to handle events or provide data on demand to this class.</para>
		///           <para>When setting the Delegate or WeakDelegate values events will be delivered to the specified instance instead of being delivered to the C#-style events</para>
		///           <para>   Methods must be decorated with the [Export ("selectorName")] attribute to respond to each method from the protocol.   Alternatively use the Delegate method which is strongly typed and does not require the [Export] attributes on methods.</para>
		///         </remarks>
		[Export ("delegate", ArgumentSemantic.Assign), NullAllowed]
		NSObject WeakDelegate { get; set; }

		/// <summary>An instance of the PdfKit.IPdfViewDelegate model class which acts as the class delegate.</summary>
		///         <value>The instance of the PdfKit.IPdfViewDelegate model class</value>
		///         <remarks>
		///           <para>The delegate instance assigned to this object will be used to handle events or provide data on demand to this class.</para>
		///           <para>When setting the Delegate or WeakDelegate values events will be delivered to the specified instance instead of being delivered to the C#-style events</para>
		///           <para>This is the strongly typed version of the object, developers should use the WeakDelegate property instead if they want to merely assign a class derived from NSObject that has been decorated with [Export] attributes.</para>
		///         </remarks>
		[Wrap ("WeakDelegate")]
		IPdfViewDelegate Delegate { get; set; }

		/// <summary>Gets or sets the view scale factor.</summary>
		[Export ("scaleFactor")]
		nfloat ScaleFactor { get; set; }

		/// <summary>Gets or sets the MinScaleFactor value.</summary>
		[MacCatalyst (13, 1)]
		[Export ("minScaleFactor")]
		nfloat MinScaleFactor { get; set; }

		/// <summary>Gets or sets the MaxScaleFactor value.</summary>
		[MacCatalyst (13, 1)]
		[Export ("maxScaleFactor")]
		nfloat MaxScaleFactor { get; set; }

		/// <param name="sender">The object that requested the operation.</param>
		///         <summary>Zooms in one level.</summary>
		[Export ("zoomIn:")]
		void ZoomIn ([NullAllowed] NSObject sender);

		/// <summary>Gets a Boolean value that tells whether the view can zoom in.</summary>
		[Export ("canZoomIn")]
		bool CanZoomIn { get; }

		/// <param name="sender">The object that requested the operation.</param>
		///         <summary>Zooms out one level.</summary>
		[Export ("zoomOut:")]
		void ZoomOut ([NullAllowed] NSObject sender);

		/// <summary>Gets a Boolean value that tells whether the view can zoom out.</summary>
		[Export ("canZoomOut")]
		bool CanZoomOut { get; }

		/// <summary>Gets or sets a Boolean value that controls whether the pages of the PDF autoscale to fit the view.</summary>
		[Export ("autoScales")]
		bool AutoScales { get; set; }

		/// <summary>Gets the scale factor that would fit the current PDF page(s) in the view.</summary>
		[MacCatalyst (13, 1)]
		[Export ("scaleFactorForSizeToFit")]
		nfloat ScaleFactorForSizeToFit { get; }

		/// <param name="mouseEvent">The mouse event for which to obtain the area of interest.</param>
		///         <summary>Returns the area of interest for the current cursor position.</summary>
		///         <returns>The result of the operation.</returns>
		[Export ("areaOfInterestForMouse:")]
		PdfAreaOfInterest GetAreaOfInterest (NSEvent mouseEvent);

		/// <param name="point">The point for which to obtain the area of interest</param>
		///         <summary>Returns the area of interest for the specified point.</summary>
		///         <returns>The result of the operation.</returns>
		[MacCatalyst (13, 1)]
		[Export ("areaOfInterestForPoint:")]
		PdfAreaOfInterest GetAreaOfInterest (CGPoint point);

		/// <param name="area">The area.</param>
		///         <summary>Performs the set cursor operation.</summary>
		[NoiOS]
		[NoMacCatalyst]
		[NoTV]
		[Export ("setCursorForAreaOfInterest:")]
		void SetCursor (PdfAreaOfInterest area);

		/// <param name="action">The action to perform</param>
		///         <summary>Performs the action.</summary>
		[Export ("performAction:")]
		void PerformAction (PdfAction action);

		/// <summary>Gets or sets the current selection.</summary>
		[Export ("currentSelection")]
		[NullAllowed]
		PdfSelection CurrentSelection { get; set; }

		/// <param name="selection">The selection to make current.</param>
		///         <param name="animate">Whether to animate the selection operation.</param>
		///         <summary>Sets the current selection with an optional animation.</summary>
		[Export ("setCurrentSelection:animate:")]
		void SetCurrentSelection ([NullAllowed] PdfSelection selection, bool animate);

		/// <summary>Clears all selections in the PDF.</summary>
		[Export ("clearSelection")]
		void ClearSelection ();

		/// <param name="sender">
		///           <para>The object that requested the operation.</para>
		///           <para tool="nullallowed">This parameter can be <see langword="null" />.</para>
		///         </param>
		///         <summary>Selects all the text.</summary>
		[Export ("selectAll:")]
		void SelectAll ([NullAllowed] NSObject sender);

		/// <param name="sender">The object that requested the operation.</param>
		///         <summary>Scrolls the current selection into view.</summary>
		[Export ("scrollSelectionToVisible:")]
		void ScrollSelectionToVisible ([NullAllowed] NSObject sender);

		/// <summary>Gets or sets the currently highlighted selections.</summary>
		[Export ("highlightedSelections")]
		[NullAllowed]
		PdfSelection [] HighlightedSelections { get; set; }

		/// <param name="sender">The sender.</param>
		///         <summary>Performs the take password from operation.</summary>
		[NoiOS]
		[Deprecated (PlatformName.MacOSX, 10, 12)]
		[NoMacCatalyst]
		[NoTV]
		[Export ("takePasswordFrom:")]
		void TakePasswordFrom (NSObject sender);

		/// <param name="page">The PDF page.</param>
		///         <summary>Performs the draw page operation.</summary>
		[NoiOS]
		[Deprecated (PlatformName.MacOSX, 10, 12)]
		[NoMacCatalyst]
		[NoTV]
		[Export ("drawPage:")]
		void DrawPage (PdfPage page);

		/// <param name="page">The PDF page.</param>
		///         <param name="context">The graphics context.</param>
		///         <summary>Performs the draw page operation.</summary>
		[MacCatalyst (13, 1)]
		[Export ("drawPage:toContext:")]
		void DrawPage (PdfPage page, CGContext context);

		/// <param name="page">The PDF page.</param>
		///         <param name="context">The graphics context.</param>
		///         <summary>Performs the draw page post operation.</summary>
		[MacCatalyst (13, 1)]
		[Export ("drawPagePost:toContext:")]
		void DrawPagePost (PdfPage page, CGContext context);

		/// <param name="page">The PDF page.</param>
		///         <summary>Performs the draw page post operation.</summary>
		[NoiOS]
		[Deprecated (PlatformName.MacOSX, 10, 12)]
		[NoMacCatalyst]
		[NoTV]
		[Export ("drawPagePost:")]
		void DrawPagePost (PdfPage page);

		/// <param name="sender">
		///           <para>A task representing the asynchronous operation.</para>
		///           <para tool="nullallowed">This parameter can be <see langword="null" />.</para>
		///         </param>
		///         <summary>Performs the copy operation.</summary>
		[Export ("copy:")]
		void Copy ([NullAllowed] NSObject sender);

		/// <param name="printInfo">The print info.</param>
		///         <param name="doRotate">Whether to rotate.</param>
		///         <summary>Performs the print operation.</summary>
		[NoiOS]
		[NoMacCatalyst]
		[NoTV]
		[Export ("printWithInfo:autoRotate:")]
		void Print (NSPrintInfo printInfo, bool doRotate);

		/// <param name="printInfo">The print info.</param>
		///         <param name="doRotate">Whether to rotate.</param>
		///         <param name="scaleMode">The scale mode.</param>
		///         <summary>Performs the PDF operation.</summary>
		[NoiOS]
		[NoMacCatalyst]
		[NoTV]
		[Export ("printWithInfo:autoRotate:pageScaling:")]
#pragma warning disable // 0618: 'PdfPrintScalingMode' is obsolete: 'This type is not available on iOS.'
		void Print (NSPrintInfo printInfo, bool doRotate, PdfPrintScalingMode scaleMode);
#pragma warning restore

		/// <param name="point">The point for which to return APage.</param>
		///         <param name="nearest">Whether to return the nearest page if the point is not on APage.</param>
		///         <summary>Returns the page for the point, or the nearest page if <paramref name="nearest" /> is <see langword="true" />.</summary>
		///         <returns>The result of the operation.</returns>
		[Export ("pageForPoint:nearest:")]
		[return: NullAllowed]
		PdfPage GetPage (CGPoint point, bool nearest);

		/// <param name="point">The point to convert.</param>
		///         <param name="page">The page that contains the point.</param>
		///         <summary>Converts the provided <paramref name="point" /> from view space to page space.</summary>
		///         <returns>The result of the operation.</returns>
		[Export ("convertPoint:toPage:")]
		CGPoint ConvertPointToPage (CGPoint point, PdfPage page);

		/// <param name="rect">The rectangle to convert.</param>
		///         <param name="page">The page that contains the rectangle.</param>
		///         <summary>Converts the provided rectangle from view space to page space.</summary>
		///         <returns>The result of the operation.</returns>
		[Export ("convertRect:toPage:")]
		CGRect ConvertRectangleToPage (CGRect rect, PdfPage page);

		/// <param name="point">The point to convert.</param>
		///         <param name="page">The page that contains the point.</param>
		///         <summary>Converts the provided <paramref name="point" /> from page space to view space.</summary>
		///         <returns>The result of the operation.</returns>
		[Export ("convertPoint:fromPage:")]
		CGPoint ConvertPointFromPage (CGPoint point, PdfPage page);

		/// <param name="rect">The rectangle to convert.</param>
		///         <param name="page">The page that contains the rectangle.</param>
		///         <summary>Converts the provided rectangle from page space to view space.</summary>
		///         <returns>The result of the operation.</returns>
		[Export ("convertRect:fromPage:")]
		CGRect ConvertRectangleFromPage (CGRect rect, PdfPage page);

		/// <summary>Gets the innermost view.</summary>
		[Export ("documentView")]
		[NullAllowed]
		NSView DocumentView { get; }

		/// <summary>Lays out the document view.</summary>
		[Export ("layoutDocumentView")]
		void LayoutDocumentView ();

		/// <param name="page">The page for which the annotations changed.</param>
		///         <summary>Method that is called when an annotation on the specified <paramref name="page" /> changes.</summary>
		[Export ("annotationsChangedOnPage:")]
		void AnnotationsChanged (PdfPage page);

		/// <param name="page">The page for which to get the row size.</param>
		///         <summary>Returns the display size of a row on the specified <paramref name="page" />.</summary>
		///         <returns>The result of the operation.</returns>
		[Export ("rowSizeForPage:")]
		CGSize RowSize (PdfPage page);

		/// <summary>Gets or sets the AllowsDragging value.</summary>
		[NoiOS]
		[Deprecated (PlatformName.MacOSX, 10, 13)]
		[NoMacCatalyst]
		[NoTV]
		[Export ("allowsDragging")]
		bool AllowsDragging { get; set; }

		/// <summary>Returns the currently visible pages.</summary>
		[Export ("visiblePages")]
		PdfPage [] VisiblePages { get; }

		/// <summary>Gets or sets the EnableDataDetectors value.</summary>
		[Deprecated (PlatformName.MacOSX, 15, 0)]
		[Deprecated (PlatformName.MacCatalyst, 18, 0)]
		[Deprecated (PlatformName.iOS, 18, 0)]
		[Deprecated (PlatformName.TvOS, 18, 2)]
		[Export ("enableDataDetectors")]
		bool EnableDataDetectors { get; set; }

		[Field ("PDFViewChangedHistoryNotification", "+PDFKit")]
		[Notification]
		NSString ChangedHistoryNotification { get; }

		[Field ("PDFViewDocumentChangedNotification", "+PDFKit")]
		[Notification]
		NSString DocumentChangedNotification { get; }

		[Field ("PDFViewPageChangedNotification", "+PDFKit")]
		[Notification]
		NSString PageChangedNotification { get; }

		[Field ("PDFViewScaleChangedNotification", "+PDFKit")]
		[Notification]
		NSString ScaleChangedNotification { get; }

		[Field ("PDFViewAnnotationHitNotification", "+PDFKit")]
		[Notification (typeof (PdfViewAnnotationHitEventArgs))]
		NSString AnnotationHitNotification { get; }

		[Field ("PDFViewCopyPermissionNotification", "+PDFKit")]
		[Notification]
		NSString CopyPermissionNotification { get; }

		[Field ("PDFViewPrintPermissionNotification", "+PDFKit")]
		[Notification]
		NSString PrintPermissionNotification { get; }

		[Field ("PDFViewAnnotationWillHitNotification", "+PDFKit")]
		[Notification]
		NSString AnnotationWillHitNotification { get; }

		[Field ("PDFViewSelectionChangedNotification", "+PDFKit")]
		[Notification]
		NSString SelectionChangedNotification { get; }

		[Field ("PDFViewDisplayModeChangedNotification", "+PDFKit")]
		[Notification]
		NSString DisplayModeChangedNotification { get; }

		[Field ("PDFViewDisplayBoxChangedNotification", "+PDFKit")]
		[Notification]
		NSString DisplayBoxChangedNotification { get; }

		[Field ("PDFViewVisiblePagesChangedNotification", "+PDFKit")]
		[Notification]
		NSString VisiblePagesChangedNotification { get; }

		/// <summary>Gets or sets the AcceptsDraggedFiles value.</summary>
		[NoiOS]
		[NoMacCatalyst]
		[NoTV]
		[Export ("acceptsDraggedFiles")]
		bool AcceptsDraggedFiles { get; set; }

		[iOS (16, 0), Mac (13, 0), MacCatalyst (16, 0)]
		[NullAllowed, Export ("pageOverlayViewProvider", ArgumentSemantic.Weak)]
		IPdfPageOverlayViewProvider PageOverlayViewProvider { get; set; }

		[iOS (16, 0), Mac (13, 0), MacCatalyst (16, 0)]
		[Export ("inMarkupMode")]
		bool InMarkupMode { [Bind ("isInMarkupMode")] get; set; }

		[iOS (16, 0), NoMac, MacCatalyst (16, 0), NoTV]
		[Export ("findInteraction")]
		UIFindInteraction FindInteraction { get; }

		[iOS (16, 0), NoMac, MacCatalyst (16, 0)]
		[Export ("findInteractionEnabled")]
		bool FindInteractionEnabled { [Bind ("isFindInteractionEnabled")] get; set; }
	}

	/// <summary>Provides data for the  event.</summary>
	[NoiOS]
	[NoTV]
	[NoMacCatalyst]
	interface PdfViewAnnotationHitEventArgs {
		// The 'AnnotationHit' property has manual bindings.
	}

	interface IPdfViewDelegate { }

	//Verify delegate methods.  There are default actions (not just return null ) that should occur
	//if the delegate does not implement the method.
	/// <summary>Delegate object for <see cref="PdfKit.PdfView" /> objects, allowing the developer to respond to navigation, printing, and linking events.</summary>
	[MacCatalyst (13, 1)]
	[TV (18, 2)]
	[BaseType (typeof (NSObject), Name = "PDFViewDelegate")]
#if IOS || TV
	[Protocol]
#else
	[Protocol (FormalSince = "10.12", Name = "PDFViewDelegate")]
#endif
	[Model]
	interface PdfViewDelegate {
		//from docs: 'By default, the scale factor is restricted to a range between 0.1 and 10.0 inclusive.'
		/// <param name="sender">The sender.</param>
		/// <param name="scale">The scale factor.</param>
		/// <summary>Performs the PDF operation.</summary>
		/// <returns>The result of the operation.</returns>
		[EventArgs ("", XmlDocs = """
			<summary>Performs the PDF operation.</summary>
			""")]
		[NoiOS]
		[NoMacCatalyst]
		[NoTV]
		[Export ("PDFViewWillChangeScaleFactor:toScale:"), DelegateName ("PdfViewScale"), DefaultValueFromArgument ("scale")]
		nfloat WillChangeScaleFactor (PdfView sender, nfloat scale);

		/// <param name="sender">The sender.</param>
		///         <param name="url">The URL.</param>
		///         <summary>Performs the PDF operation.</summary>
		[Export ("PDFViewWillClickOnLink:withURL:"), EventArgs ("PdfViewUrl", XmlDocs = """
			<summary>Event raised by the object.</summary>
			<remarks>If developers do not assign a value to this event, this will reset the value for the WeakDelegate property to an internal handler that maps delegates to events.</remarks>
			""")]
		void WillClickOnLink (PdfView sender, NSUrl url);

		// from the docs: 'By default, this method uses the string, if any, associated with the
		// 'Title' key in the view's PDFDocument attribute dictionary. If there is no such string,
		// this method uses the last path component if the document is URL-based.
		/// <param name="sender">The sender.</param>
		///         <summary>Performs the PDF operation.</summary>
		///         <returns>The result of the operation.</returns>
		[EventArgs ("", XmlDocs = """
			<summary>Performs the PDF operation.</summary>
			""")]
		[NoiOS]
		[NoMacCatalyst]
		[NoTV]
		[Export ("PDFViewPrintJobTitle:"), DelegateName ("PdfViewTitle"), DefaultValue ("String.Empty")]
		string TitleOfPrintJob (PdfView sender);

		/// <param name="sender">The sender.</param>
		///         <summary>Performs the PDF operation.</summary>
		[Export ("PDFViewPerformFind:"), EventArgs ("PdfView", XmlDocs = """
			<summary>Event raised by the object.</summary>
			<remarks>If developers do not assign a value to this event, this will reset the value for the WeakDelegate property to an internal handler that maps delegates to events.</remarks>
			""")]
		void PerformFind (PdfView sender);

		/// <param name="sender">The sender.</param>
		///         <summary>Performs the PDF operation.</summary>
		[Export ("PDFViewPerformGoToPage:"), EventArgs ("PdfView", XmlDocs = """
			<summary>Event raised by the object.</summary>
			<remarks>If developers do not assign a value to this event, this will reset the value for the WeakDelegate property to an internal handler that maps delegates to events.</remarks>
			""")]
		void PerformGoToPage (PdfView sender);

		/// <param name="sender">The sender.</param>
		///         <summary>Performs the PDF operation.</summary>
		[NoiOS]
		[NoMacCatalyst]
		[NoTV]
		[Export ("PDFViewPerformPrint:"), EventArgs ("PdfView", XmlDocs = """
			<summary>Performs the PDF operation.</summary>
			""")]
		void PerformPrint (PdfView sender);

		/// <param name="sender">The sender.</param>
		///         <param name="action">The PDF action.</param>
		///         <summary>Performs the PDF operation.</summary>
		[Export ("PDFViewOpenPDF:forRemoteGoToAction:"), EventArgs ("PdfViewAction", XmlDocs = """
			<summary>Event raised by the object.</summary>
			<remarks>If developers do not assign a value to this event, this will reset the value for the WeakDelegate property to an internal handler that maps delegates to events.</remarks>
			""")]
		void OpenPdf (PdfView sender, PdfActionRemoteGoTo action);

		[iOS (13, 0)]
		[NoMac]
		[MacCatalyst (13, 1)]
		[Export ("PDFViewParentViewController")]
		UIViewController ParentViewController { get; }
	}

	[Mac (13, 0), iOS (16, 0), MacCatalyst (16, 0)]
	[TV (18, 2)]
	interface IPdfPageOverlayViewProvider { }

	[Mac (13, 0), iOS (16, 0), MacCatalyst (16, 0)]
	[TV (18, 2)]
	[Protocol (Name = "PDFPageOverlayViewProvider")]
	interface PdfPageOverlayViewProvider {
		[Abstract]
		[Export ("pdfView:overlayViewForPage:")]
		[return: NullAllowed]
		UIView GetOverlayView (PdfView view, PdfPage page);

		[Export ("pdfView:willDisplayOverlayView:forPage:")]
		void WillDisplayOverlayView (PdfView pdfView, UIView overlayView, PdfPage page);

		[Export ("pdfView:willEndDisplayingOverlayView:forPage:")]
		void WillEndDisplayingOverlayView (PdfView pdfView, UIView overlayView, PdfPage page);
	}
}
