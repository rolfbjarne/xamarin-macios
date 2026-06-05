//
// IOSurface bindings
//
// Authors:
//	Miguel de Icaza  <miguel@microsoft.com>
//
// Copyright 2017 Microsoft Inc. All rights reserved.
//

using System.Diagnostics.CodeAnalysis;
using CoreFoundation;

namespace IOSurface {

	[Static]
	[Internal]
	// See bug #59201 
	[MacCatalyst (13, 1)]
	interface IOSurfacePropertyKey {
		[Internal]
		[Field ("IOSurfacePropertyAllocSizeKey")]
		NSString _DeprecatedAllocSizeKey { get; }

		[MacCatalyst (13, 1)]
		[Internal]
		[Field ("IOSurfacePropertyKeyAllocSize")]
		NSString _NewAllocSizeKey { get; }

		[Field ("IOSurfacePropertyKeyWidth")]
		NSString WidthKey { get; }

		[Field ("IOSurfacePropertyKeyHeight")]
		NSString HeightKey { get; }

		[Field ("IOSurfacePropertyKeyBytesPerRow")]
		NSString BytesPerRowKey { get; }

		[Field ("IOSurfacePropertyKeyBytesPerElement")]
		NSString BytesPerElementKey { get; }

		[Field ("IOSurfacePropertyKeyElementWidth")]
		NSString ElementWidthKey { get; }

		[Field ("IOSurfacePropertyKeyElementHeight")]
		NSString ElementHeightKey { get; }

		[Field ("IOSurfacePropertyKeyOffset")]
		NSString OffsetKey { get; }

		[Field ("IOSurfacePropertyKeyPlaneInfo")]
		NSString PlaneInfoKey { get; }

		[Field ("IOSurfacePropertyKeyPlaneWidth")]
		NSString PlaneWidthKey { get; }

		[Field ("IOSurfacePropertyKeyPlaneHeight")]
		NSString PlaneHeightKey { get; }

		[Field ("IOSurfacePropertyKeyPlaneBytesPerRow")]
		NSString PlaneBytesPerRowKey { get; }

		[Field ("IOSurfacePropertyKeyPlaneOffset")]
		NSString PlaneOffsetKey { get; }

		[Field ("IOSurfacePropertyKeyPlaneSize")]
		NSString PlaneSizeKey { get; }

		[Field ("IOSurfacePropertyKeyPlaneBase")]
		NSString PlaneBaseKey { get; }

		[Field ("IOSurfacePropertyKeyPlaneBytesPerElement")]
		NSString PlaneBytesPerElementKey { get; }

		[Field ("IOSurfacePropertyKeyPlaneElementWidth")]
		NSString PlaneElementWidthKey { get; }

		[Field ("IOSurfacePropertyKeyPlaneElementHeight")]
		NSString PlaneElementHeightKey { get; }

		[Field ("IOSurfacePropertyKeyCacheMode")]
		NSString CacheModeKey { get; }

		[Field ("IOSurfacePropertyKeyPixelFormat")]
		NSString PixelFormatKey { get; }

		[Field ("IOSurfacePropertyKeyPixelSizeCastingAllowed")]
		NSString PixelSizeCastingAllowedKey { get; }

		[iOS (16, 0), TV (16, 0), Mac (13, 0), MacCatalyst (16, 0)]
		[Field ("IOSurfacePropertyKeyName")]
		NSString NameKey { get; }
	}

	[StrongDictionary ("IOSurfacePropertyKey")]
	partial interface IOSurfaceOptions {
		/// <summary>Gets or sets the total allocation size of the IOSurface.</summary>
		/// <value>The allocation size in bytes.</value>
		
		nint AllocSize { get; set; }
		/// <summary>Gets or sets the width of the IOSurface.</summary>
		/// <value>The width in pixels.</value>
		
		nint Width { get; set; }
		/// <summary>Gets or sets the height of the IOSurface.</summary>
		/// <value>The height in pixels.</value>
		
		nint Height { get; set; }
		/// <summary>Gets or sets the number of bytes per row.</summary>
		/// <value>The number of bytes per row.</value>
		
		nint BytesPerRow { get; set; }
		/// <summary>Gets or sets the number of bytes per element.</summary>
		/// <value>The number of bytes per element.</value>
		
		nint BytesPerElement { get; set; }
		/// <summary>Gets or sets the element width.</summary>
		/// <value>The width of each element in pixels.</value>
		
		nint ElementWidth { get; set; }
		/// <summary>Gets or sets the element height.</summary>
		/// <value>The height of each element in pixels.</value>
		
		nint ElementHeight { get; set; }
		/// <summary>Gets or sets the byte offset from the base address to the start of the buffer data.</summary>
		/// <value>The offset in bytes.</value>
		
		nint Offset { get; set; }
		/// <summary>Gets or sets the array of plane information dictionaries.</summary>
		/// <value>An array of dictionaries describing each plane.</value>
		
		NSDictionary [] PlaneInfo { get; set; }
		/// <summary>Gets or sets the width of the specified plane.</summary>
		/// <value>The plane width in pixels.</value>
		
		nint PlaneWidth { get; set; }
		/// <summary>Gets or sets the height of the specified plane.</summary>
		/// <value>The plane height in pixels.</value>
		
		nint PlaneHeight { get; set; }
		/// <summary>Gets or sets the bytes per row of the specified plane.</summary>
		/// <value>The number of bytes per row in the plane.</value>
		
		nint PlaneBytesPerRow { get; set; }
		/// <summary>Gets or sets the byte offset of the specified plane.</summary>
		/// <value>The offset in bytes for the plane.</value>
		
		nint PlaneOffset { get; set; }
		/// <summary>Gets or sets the size of the specified plane.</summary>
		/// <value>The plane size in bytes.</value>
		
		nint PlaneSize { get; set; }
		/// <summary>Gets or sets the base address of the specified plane.</summary>
		/// <value>The base address offset for the plane.</value>
		
		nint PlaneBase { get; set; }
		/// <summary>Gets or sets the bytes per element of the specified plane.</summary>
		/// <value>The number of bytes per element in the plane.</value>
		
		nint PlaneBytesPerElement { get; set; }
		/// <summary>Gets or sets the element width of the specified plane.</summary>
		/// <value>The element width in pixels for the plane.</value>
		
		nint PlaneElementWidth { get; set; }
		/// <summary>Gets or sets the element height of the specified plane.</summary>
		/// <value>The element height in pixels for the plane.</value>
		
		nint PlaneElementHeight { get; set; }
		/// <summary>Gets or sets the cache mode for the IOSurface.</summary>
		/// <value>The memory cache mode.</value>
		
		IOSurfaceMemoryMap CacheMode { get; set; }
		/// <summary>Gets or sets the pixel format of the IOSurface.</summary>
		/// <value>The pixel format as a four-character code.</value>
		
		uint PixelFormat { get; set; }
		/// <summary>Gets or sets whether pixel size casting is allowed.</summary>
		/// <value><see langword="true" /> if pixel size casting is allowed; otherwise, <see langword="false" />.</value>
		
		bool PixelSizeCastingAllowed { get; set; }
		[iOS (16, 0), TV (16, 0), Mac (13, 0), MacCatalyst (16, 0)]
		string Name { get; set; }
	}

	[MacCatalyst (13, 1)]
	[BaseType (typeof (NSObject))]
	interface IOSurface : NSSecureCoding {
		[Internal, Export ("initWithProperties:")]
		NativeHandle Constructor (NSDictionary properties);

		/// <param name="properties">To be added.</param>
		/// <summary>To be added.</summary>
		/// <remarks>To be added.</remarks>
		[Wrap ("this (properties.GetDictionary ()!)")]
		NativeHandle Constructor (IOSurfaceOptions properties);

		[Internal, Export ("lockWithOptions:seed:")]
		int _Lock (IOSurfaceLockOptions options, IntPtr seedPtr);

		[Internal, Export ("unlockWithOptions:seed:")]
		int _Unlock (IOSurfaceLockOptions options, IntPtr seed);

		[Export ("allocationSize")]
		nint AllocationSize { get; }

		[Export ("width")]
		nint Width { get; }

		[Export ("height")]
		nint Height { get; }

		[Export ("baseAddress")]
		IntPtr BaseAddress { get; }

		[Export ("pixelFormat")]
		uint PixelFormat { get; }

		[Export ("bytesPerRow")]
		nint BytesPerRow { get; }

		[Export ("bytesPerElement")]
		nint BytesPerElement { get; }

		[Export ("elementWidth")]
		nint ElementWidth { get; }

		[Export ("elementHeight")]
		nint ElementHeight { get; }

		[TV (18, 0), Mac (15, 0), iOS (18, 0), MacCatalyst (18, 0)]
		[Export ("surfaceID")]
		uint SurfaceId { get; }

		[Export ("seed")]
		uint Seed { get; }

		[Export ("planeCount")]
		nuint PlaneCount { get; }

		/// <param name="planeIndex">To be added.</param>
		/// <summary>To be added.</summary>
		/// <returns>To be added.</returns>
		/// <remarks>To be added.</remarks>
		[Export ("widthOfPlaneAtIndex:")]
		nint GetWidth (nuint planeIndex);

		/// <param name="planeIndex">To be added.</param>
		/// <summary>To be added.</summary>
		/// <returns>To be added.</returns>
		/// <remarks>To be added.</remarks>
		[Export ("heightOfPlaneAtIndex:")]
		nint GetHeight (nuint planeIndex);

		/// <param name="planeIndex">To be added.</param>
		/// <summary>To be added.</summary>
		/// <returns>To be added.</returns>
		/// <remarks>To be added.</remarks>
		[Export ("bytesPerRowOfPlaneAtIndex:")]
		nint GetBytesPerRow (nuint planeIndex);

		/// <param name="planeIndex">To be added.</param>
		/// <summary>To be added.</summary>
		/// <returns>To be added.</returns>
		/// <remarks>To be added.</remarks>
		[Export ("bytesPerElementOfPlaneAtIndex:")]
		nint GetBytesPerElement (nuint planeIndex);

		/// <param name="planeIndex">To be added.</param>
		/// <summary>To be added.</summary>
		/// <returns>To be added.</returns>
		/// <remarks>To be added.</remarks>
		[Export ("elementWidthOfPlaneAtIndex:")]
		nint GetElementWidth (nuint planeIndex);

		/// <param name="planeIndex">To be added.</param>
		/// <summary>To be added.</summary>
		/// <returns>To be added.</returns>
		/// <remarks>To be added.</remarks>
		[Export ("elementHeightOfPlaneAtIndex:")]
		nint GetElementHeight (nuint planeIndex);

		/// <param name="planeIndex">To be added.</param>
		/// <summary>To be added.</summary>
		/// <returns>To be added.</returns>
		/// <remarks>To be added.</remarks>
		[Export ("baseAddressOfPlaneAtIndex:")]
		IntPtr GetBaseAddress (nuint planeIndex);

		[Export ("setAttachment:forKey:")]
		void SetAttachment (NSObject anObject, NSString key);

		[Export ("attachmentForKey:")]
		[return: NullAllowed]
		NSObject GetAttachment (NSString key);

		[Export ("removeAttachmentForKey:")]
		void RemoveAttachment (NSString key);

		[Export ("allAttachments")]
		NSDictionary<NSString, NSObject> AllAttachments {
			// in ObjC it's not defined as a `@property` and the getter can return null but the setter does not accept it
			[return: MaybeNull]
			get;
			set;
		}

		[Export ("removeAllAttachments")]
		void RemoveAllAttachments ();

		/// <summary>To be added.</summary>
		///         <value>To be added.</value>
		///         <remarks>To be added.</remarks>
		[Export ("inUse")]
		bool InUse { [Bind ("isInUse")] get; }

		[Export ("incrementUseCount")]
		void IncrementUseCount ();

		[Export ("decrementUseCount")]
		void DecrementUseCount ();

		[Export ("localUseCount")]
		int LocalUseCount { get; }

		[Export ("allowsPixelSizeCasting")]
		bool AllowsPixelSizeCasting { get; }

		[MacCatalyst (13, 1)]
		[Internal, Export ("setPurgeable:oldState:")]
		int _SetPurgeable (IOSurfacePurgeabilityState newState, IntPtr oldStatePtr);
	}
}
