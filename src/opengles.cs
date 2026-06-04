//
// This file describes the API that the generator will produce
//
// Authors:
//   Geoff Norton
//   Miguel de Icaza
//
// Copyright 2009, Novell, Inc.
// Copyright 2015 Xamarin Inc.
//
using CoreGraphics;
using CoreLocation;
using UIKit;

namespace OpenGLES {

	/// <summary>Manages resources that can be used by more than one EAGLContext (textures, buffers, framebuffers, renderbuffers, shaders and programs).</summary>
	///     
	///     <related type="externalDocumentation" href="https://developer.apple.com/library/ios/documentation/OpenGLES/Reference/EAGLSharegroup_ClassRef/index.html">Apple documentation for <c>EAGLSharegroup</c></related>
	[Deprecated (PlatformName.iOS, 12, 0, message: "Use 'Metal' instead.")]
	[Deprecated (PlatformName.TvOS, 12, 0, message: "Use 'Metal' instead.")]
	[BaseType (typeof (NSObject))]
	// <quote>It is created when an EAGLContext object is initialized and disposed of when the last EAGLContext object that references it is released.</quote>
	[DisableDefaultCtor]
	interface EAGLSharegroup {

		/// <summary>Gets or sets a descriptive label for the share group for debugging.</summary>
		///         <value>
		///           <para>(More documentation for this node is coming)</para>
		///           <para tool="nullallowed">This value can be <see langword="null" />.</para>
		///         </value>
		[Export ("debugLabel")]
		[NullAllowed]
		string DebugLabel { get; set; }
	}

	/// <summary>Holds the state necessary to render using OpenGL ES.</summary>
	///     
	///     <related type="externalDocumentation" href="https://developer.apple.com/library/ios/documentation/OpenGLES/Reference/EAGLContext_ClassRef/index.html">Apple documentation for <c>EAGLContext</c></related>
	[Deprecated (PlatformName.iOS, 12, 0, message: "Use 'Metal' instead.")]
	[Deprecated (PlatformName.TvOS, 12, 0, message: "Use 'Metal' instead.")]
	[BaseType (typeof (NSObject))]
	[DisableDefaultCtor] // init now marked with NS_UNAVAILABLE
	interface EAGLContext {
		/// <param name="api">The api.</param>
		/// <summary>Creates a new EAGL context that supports the specified rendering API.</summary>
		[Export ("initWithAPI:")]
		NativeHandle Constructor (EAGLRenderingAPI api);

		/// <param name="api">The api.</param>
		/// <param name="sharegroup">The sharegroup.</param>
		/// <summary>Creates a new EAGL context in the specified share group and that supports the specified rendering API.</summary>
		[DesignatedInitializer]
		[Export ("initWithAPI:sharegroup:")]
		NativeHandle Constructor (EAGLRenderingAPI api, EAGLSharegroup sharegroup);

		/// <param name="context">
		///   <para>The EAGL context to make current.</para>
		///   <para tool="nullallowed">This parameter can be <see langword="null" />.</para>
		/// </param>
		/// <summary>Makes the supplied <paramref name="context" /> the context that contains the OpenGL ES state.</summary>
		/// <returns><see langword="true" /> if the context was successfully set; otherwise, <see langword="false" />.</returns>
		[Static, Export ("setCurrentContext:")]
		bool SetCurrentContext ([NullAllowed] EAGLContext context);

		/// <summary>Gets the current EAGL context.</summary>
		///         <value>
		///           <para>(More documentation for this node is coming)</para>
		///           <para tool="nullallowed">This value can be <see langword="null" />.</para>
		///         </value>
		[Static, Export ("currentContext")]
		[NullAllowed]
		EAGLContext CurrentContext { get; }

		/// <summary>Gets the OpenGL ES rendering API version with which the EAGL context was created.</summary>
		/// <value>The rendering API version.</value>
		[Export ("API")]
		EAGLRenderingAPI API { get; }

		/// <summary>Gets the share group to which the EAGL context belongs.</summary>
		/// <value>The <see cref="T:OpenGLES.EAGLSharegroup" /> for this context.</value>
		[Export ("sharegroup")]
		EAGLSharegroup ShareGroup { get; }

		/// <summary>Gets or sets a label that is used to identify the context for debugging.</summary>
		///         <value>
		///           <para>(More documentation for this node is coming)</para>
		///           <para tool="nullallowed">This value can be <see langword="null" />.</para>
		///         </value>
		[Export ("debugLabel")]
		[NullAllowed]
		string DebugLabel { get; set; }

		//
		// These are from @interface EAGLContext (EAGLContextDrawableAdditions)
		//

		/// <param name="target">The target.</param>
		/// <param name="drawable">
		///   <para>The EAGL layer to use as the drawable surface.</para>
		///   <para tool="nullallowed">This parameter can be <see langword="null" />.</para>
		/// </param>
		/// <summary>Binds the storage of a renderbuffer to the specified drawable object.</summary>
		/// <returns><see langword="true" /> if successful; otherwise, <see langword="false" />.</returns>
		[Export ("renderbufferStorage:fromDrawable:")]
		bool RenderBufferStorage (nuint target, [NullAllowed] CoreAnimation.CAEAGLLayer drawable);

		/// <param name="target">The target.</param>
		/// <summary>Displays the contents of a render buffer.</summary>
		/// <returns><see langword="true" /> if successful; otherwise, <see langword="false" />.</returns>
		[Export ("presentRenderbuffer:")]
		bool PresentRenderBuffer (nuint target);

		[Internal]
		[Export ("presentRenderbuffer:atTime:")]
		bool _PresentRenderbufferAtTime (nuint target, double presentationTime);

		[Internal]
		[Export ("presentRenderbuffer:afterMinimumDuration:")]
		bool _PresentRenderbufferAfterMinimumDuration (nuint target, double duration);

		/// <summary>Gets or sets a Boolean value that controls whether OpenGL ES uses other threads to perform work.</summary>
		/// <value><see langword="true" /> if multi-threaded rendering is enabled; otherwise, <see langword="false" />.</value>
		[Export ("multiThreaded")]
		bool IsMultiThreaded { [Bind ("isMultiThreaded")] get; set; }

		// IOSurface (EAGLContext)

		/// <param name="ioSurface">The io surface.</param>
		/// <param name="target">The target.</param>
		/// <param name="internalFormat">The internal format.</param>
		/// <param name="width">The width.</param>
		/// <param name="height">The height.</param>
		/// <param name="format">The format.</param>
		/// <param name="type">The type.</param>
		/// <param name="plane">The plane.</param>
		/// <summary>Creates a texture from an IOSurface with the specified parameters.</summary>
		/// <returns><see langword="true" /> if the texture was successfully created; otherwise, <see langword="false" />.</returns>
		[Export ("texImageIOSurface:target:internalFormat:width:height:format:type:plane:")]
		bool TexImage (IOSurface.IOSurface ioSurface, nuint target, nuint internalFormat, uint width, uint height, nuint format, nuint type, uint plane);
	}

	[NoMac]
	[NoMacCatalyst]
	[Deprecated (PlatformName.iOS, 12, 0, message: "Use 'Metal' instead.")]
	[Deprecated (PlatformName.TvOS, 12, 0, message: "Use 'Metal' instead.")]
	[Protocol]
	// no [Model] because "The EAGLDrawable protocol is not intended to be implemented by objects outside of the iOS."
	interface EAGLDrawable {
		/// <summary>Gets or sets the drawable properties for this drawable.</summary>
		/// <value>A dictionary containing the drawable properties.</value>
		[Abstract]
		[NullAllowed] // by default this property is null
		[Export ("drawableProperties", ArgumentSemantic.Copy)]
		NSDictionary DrawableProperties { get; set; }
	}
}
