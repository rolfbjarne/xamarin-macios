
namespace WebKit {

	[NoiOS, NoTV, NoMacCatalyst]
	[Deprecated (PlatformName.MacOSX, 10, 14, message: "No longer supported.")]
	public enum DomCssRuleType : ushort {
		/// <summary>Indicates unknown.</summary>
		Unknown = 0,
		/// <summary>Indicates style.</summary>
		Style = 1,
		/// <summary>Indicates charset.</summary>
		Charset = 2,
		/// <summary>Indicates import.</summary>
		Import = 3,
		/// <summary>Indicates media.</summary>
		Media = 4,
		/// <summary>Indicates font face.</summary>
		FontFace = 5,
		/// <summary>Indicates page.</summary>
		Page = 6,
		/// <summary>Indicates variables.</summary>
		Variables = 7,
		/// <summary>Indicates web kit key frames.</summary>
		WebKitKeyFrames = 8,
		/// <summary>Indicates web kit key frame.</summary>
		WebKitKeyFrame = 9,
		/// <summary>Indicates namespace rule.</summary>
		NamespaceRule = 10,
	}

	[NoiOS, NoTV, NoMacCatalyst]
	[Deprecated (PlatformName.MacOSX, 10, 14, message: "No longer supported.")]
	public enum DomCssValueType : ushort {
		/// <summary>Indicates inherit.</summary>
		Inherit = 0,
		/// <summary>Indicates primitive value.</summary>
		PrimitiveValue = 1,
		/// <summary>Indicates value list.</summary>
		ValueList = 2,
		/// <summary>Indicates custom.</summary>
		Custom = 3,
	}

	[NoiOS, NoTV, NoMacCatalyst]
	[Deprecated (PlatformName.MacOSX, 10, 14, message: "No longer supported.")]
	[Flags]
	public enum DomDocumentPosition : ushort {
		/// <summary>Indicates disconnected.</summary>
		Disconnected = 0x01,
		/// <summary>Indicates preceeding.</summary>
		Preceeding = 0x02,
		/// <summary>Indicates following.</summary>
		Following = 0x04,
		/// <summary>Indicates contains.</summary>
		Contains = 0x08,
		/// <summary>Indicates contained by.</summary>
		ContainedBy = 0x10,
		/// <summary>Indicates implementation specific.</summary>
		ImplementationSpecific = 0x20,
	}

	[NoiOS, NoTV, NoMacCatalyst]
	[Deprecated (PlatformName.MacOSX, 10, 14, message: "No longer supported.")]
	public enum DomNodeType : ushort {
		/// <summary>Indicates element.</summary>
		Element = 1,
		/// <summary>Indicates attribute.</summary>
		Attribute = 2,
		/// <summary>Indicates text.</summary>
		Text = 3,
		/// <summary>Indicates c data.</summary>
		CData = 4,
		/// <summary>Indicates entity reference.</summary>
		EntityReference = 5,
		/// <summary>Indicates entity.</summary>
		Entity = 6,
		/// <summary>Indicates processing instruction.</summary>
		ProcessingInstruction = 7,
		/// <summary>Indicates comment.</summary>
		Comment = 8,
		/// <summary>Indicates document.</summary>
		Document = 9,
		/// <summary>Indicates document type.</summary>
		DocumentType = 10,
		/// <summary>Indicates document fragment.</summary>
		DocumentFragment = 11,
		/// <summary>Indicates notation.</summary>
		Notation = 12,
	}

	[NoiOS, NoTV, NoMacCatalyst]
	[Deprecated (PlatformName.MacOSX, 10, 14, message: "No longer supported.")]
	public enum DomRangeCompareHow : ushort {
		/// <summary>Indicates start to start.</summary>
		StartToStart = 0,
		/// <summary>Indicates start to end.</summary>
		StartToEnd = 1,
		/// <summary>Indicates end to end.</summary>
		EndToEnd = 2,
		/// <summary>Indicates end to start.</summary>
		EndToStart = 3,
	}

	[NoiOS, NoTV, NoMacCatalyst]
	[Native]
	public enum WebCacheModel : ulong {
		/// <summary>Indicates document viewer.</summary>
		DocumentViewer,
		/// <summary>Indicates document browser.</summary>
		DocumentBrowser,
		/// <summary>Indicates primary web browser.</summary>
		PrimaryWebBrowser,
	}

	[NoiOS, NoTV, NoMacCatalyst]
	[Deprecated (PlatformName.MacOSX, 10, 14, message: "No longer supported.")]
	public enum DomEventPhase : ushort {
		/// <summary>Indicates capturing.</summary>
		Capturing = 1,
		/// <summary>Indicates at target.</summary>
		AtTarget,
		/// <summary>Indicates bubbling.</summary>
		Bubbling,
	}

	[NoiOS, NoTV, NoMacCatalyst]
	[Deprecated (PlatformName.MacOSX, 10, 14, message: "No longer supported.")]
	[Flags]
	public enum WebDragSourceAction : ulong {
		/// <summary>Indicates none.</summary>
		None = 0,
		/// <summary>Indicates DHTML.</summary>
		DHTML = 1,
		/// <summary>Indicates image.</summary>
		Image = 2,
		/// <summary>Indicates link.</summary>
		Link = 4,
		/// <summary>Indicates selection.</summary>
		Selection = 8,
		/// <summary>Indicates any.</summary>
		Any = UInt64.MaxValue,
	}

	[NoiOS, NoTV, NoMacCatalyst]
	[Deprecated (PlatformName.MacOSX, 10, 14, message: "No longer supported.")]
	[Flags]
	public enum WebDragDestinationAction : ulong {
		/// <summary>Indicates none.</summary>
		None = 0,
		/// <summary>Indicates DHTML.</summary>
		DHTML = 1,
		/// <summary>Indicates image.</summary>
		Image = 2,
		/// <summary>Indicates link.</summary>
		Link = 4,
		/// <summary>Indicates selection.</summary>
		[Obsolete ("This API is not available on this platform.")]
		Selection = 8,
		/// <summary>Indicates any element type.</summary>
		Any = UInt64.MaxValue,
	}

	[NoiOS, NoTV, NoMacCatalyst]
	[Native]
	public enum WebNavigationType : long {
		/// <summary>Indicates link clicked.</summary>
		LinkClicked,
		/// <summary>Indicates form submitted.</summary>
		FormSubmitted,
		/// <summary>Indicates back forward.</summary>
		BackForward,
		/// <summary>Indicates reload.</summary>
		Reload,
		/// <summary>Indicates form resubmitted.</summary>
		FormResubmitted,
		/// <summary>Indicates other.</summary>
		Other,
	}

	// Used as an 'unsigned int' parameter 
	[NoiOS, NoTV, NoMacCatalyst]
	[Deprecated (PlatformName.MacOSX, 10, 14, message: "No longer supported.")]
	public enum DomKeyLocation : uint {
		/// <summary>Indicates standard.</summary>
		Standard = 0,
		/// <summary>Indicates left.</summary>
		Left = 1,
		/// <summary>Indicates right.</summary>
		Right = 2,
		/// <summary>Indicates number pad.</summary>
		NumberPad = 3,
	}

	// Used as an 'int' parameter 
	[NoiOS, NoTV, NoMacCatalyst]
	[Deprecated (PlatformName.MacOSX, 10, 14, message: "No longer supported.")]
	public enum DomDelta : int {
		/// <summary>Indicates pixel.</summary>
		Pixel = 0,
		/// <summary>Indicates line.</summary>
		Line = 1,
		/// <summary>Indicates page.</summary>
		Page = 2,
	}
}
