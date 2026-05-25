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
namespace ClassKit {
	#pragma warning disable CS1573
	/// <summary>Delegate for requesting data store contexts.</summary><remarks><para>ClassKit contexts are used to arrange nested content, such as chapters and sections of a lesson plan, in order to organize and track student progress and tests. ClassKit supports a maximum of 8 layers of content nesting.</para></remarks>
	[SupportedOSPlatform ("maccatalyst")]
	[UnsupportedOSPlatform ("tvos")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	[Protocol (Name = "CLSDataStoreDelegate", WrapperType = typeof (CLSDataStoreDelegateWrapper))]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "CreateContext", Selector = "createContextForIdentifier:parentContext:parentIdentifierPath:", ReturnType = typeof (ClassKit.CLSContext), ParameterType = new Type [] { typeof (string), typeof (ClassKit.CLSContext), typeof (String[]) }, ParameterByRef = new bool [] { false, false, false })]
	public partial interface ICLSDataStoreDelegate : INativeObject, IDisposable
	{
		/// <param name="identifier">The identifier for the context to create.</param><param name="parentContext">The parent context for the context to create.</param><param name="parentIdentifierPath">The identifier path for the parent of the context to create.</param><summary>Requests a context for the provided parameters.</summary><returns>A new ClassKit store context.</returns><remarks><para>ClassKit contexts are used to arrange nested content, such as chapters and sections of a lesson plan, in order to organize and track student progress and tests. ClassKit supports a maximum of 8 layers of content nesting.</para></remarks>
		[global::Foundation.RequiredMember]
		[Export ("createContextForIdentifier:parentContext:parentIdentifierPath:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual CLSContext? CreateContext (string identifier, CLSContext parentContext, string[] parentIdentifierPath)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="identifier">The identifier for the context to create.</param><param name="parentContext">The parent context for the context to create.</param><param name="parentIdentifierPath">The identifier path for the parent of the context to create.</param><summary>Requests a context for the provided parameters.</summary><returns>A new ClassKit store context.</returns><remarks><para>ClassKit contexts are used to arrange nested content, such as chapters and sections of a lesson plan, in order to organize and track student progress and tests. ClassKit supports a maximum of 8 layers of content nesting.</para></remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static CLSContext? _CreateContext (ICLSDataStoreDelegate This, string identifier, CLSContext parentContext, string[] parentIdentifierPath)
		{
			if (identifier is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (identifier));
			var parentContext__handle__ = parentContext!.GetNonNullHandle (nameof (parentContext));
			if (parentIdentifierPath is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (parentIdentifierPath));
			var nsidentifier = CFString.CreateNative (identifier);
			using var nsa_parentIdentifierPath = NSArray.FromStrings (parentIdentifierPath);
			CLSContext? ret;
			ret =  Runtime.GetNSObject<CLSContext> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("createContextForIdentifier:parentContext:parentIdentifierPath:"), nsidentifier, parentContext__handle__, nsa_parentIdentifierPath.Handle), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (parentContext);
			CFString.ReleaseNative (nsidentifier);
			return ret!;
		}
		[DynamicDependencyAttribute ("CreateContext(System.String,ClassKit.CLSContext,System.String[])")]
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.Interfaces | DynamicallyAccessedMemberTypes.PublicConstructors, typeof (CLSDataStoreDelegateWrapper))]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static ICLSDataStoreDelegate ()
		{
			GC.KeepAlive (null);
		}
	}
	#pragma warning restore CS1573
	internal unsafe sealed class CLSDataStoreDelegateWrapper : BaseWrapper, ICLSDataStoreDelegate {
		public CLSDataStoreDelegateWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.PublicConstructors, typeof (CLSDataStoreDelegateWrapper))]
		static CLSDataStoreDelegateWrapper ()
		{
			GC.KeepAlive (null);
		}
		/// <param name="identifier">The identifier for the context to create.</param><param name="parentContext">The parent context for the context to create.</param><param name="parentIdentifierPath">The identifier path for the parent of the context to create.</param><summary>Requests a context for the provided parameters.</summary><returns>A new ClassKit store context.</returns><remarks><para>ClassKit contexts are used to arrange nested content, such as chapters and sections of a lesson plan, in order to organize and track student progress and tests. ClassKit supports a maximum of 8 layers of content nesting.</para></remarks>
		[Export ("createContextForIdentifier:parentContext:parentIdentifierPath:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public CLSContext? CreateContext (string identifier, CLSContext parentContext, string[] parentIdentifierPath)
		{
			if (identifier is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (identifier));
			var parentContext__handle__ = parentContext!.GetNonNullHandle (nameof (parentContext));
			if (parentIdentifierPath is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (parentIdentifierPath));
			var nsidentifier = CFString.CreateNative (identifier);
			using var nsa_parentIdentifierPath = NSArray.FromStrings (parentIdentifierPath);
			CLSContext? ret;
			ret =  Runtime.GetNSObject<CLSContext> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("createContextForIdentifier:parentContext:parentIdentifierPath:"), nsidentifier, parentContext__handle__, nsa_parentIdentifierPath.Handle), false)!;
			GC.KeepAlive (parentContext);
			CFString.ReleaseNative (nsidentifier);
			return ret!;
		}
	}
}
namespace ClassKit {
	/// <summary>Delegate for requesting data store contexts.</summary><remarks><para>ClassKit contexts are used to arrange nested content, such as chapters and sections of a lesson plan, in order to organize and track student progress and tests. ClassKit supports a maximum of 8 layers of content nesting.</para></remarks>
	[Protocol()]
	[Register("Microsoft_macOS__ClassKit_CLSDataStoreDelegate", false)]
	[Model]
	[SupportedOSPlatform ("maccatalyst")]
	[UnsupportedOSPlatform ("tvos")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	public unsafe abstract partial class CLSDataStoreDelegate : NSObject, ICLSDataStoreDelegate {
		/// <summary>Creates a new <see cref="CLSDataStoreDelegate" /> with default values.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		protected CLSDataStoreDelegate () : base (NSObjectFlag.Empty)
		{
			IsDirectBinding = false;
			unsafe {
			var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
			InitializeHandle (global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (&__objc_super__, global::ObjCRuntime.Selector.Init), "init");
			GC.KeepAlive (this);
			}
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
		protected CLSDataStoreDelegate (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = false;
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
		protected internal CLSDataStoreDelegate (NativeHandle handle) : base (handle)
		{
			IsDirectBinding = false;
		}

		/// <param name="identifier">The identifier for the context to create.</param><param name="parentContext">The parent context for the context to create.</param><param name="parentIdentifierPath">The identifier path for the parent of the context to create.</param><summary>Requests a context for the provided parameters.</summary><returns>A new ClassKit store context.</returns><remarks><para>ClassKit contexts are used to arrange nested content, such as chapters and sections of a lesson plan, in order to organize and track student progress and tests. ClassKit supports a maximum of 8 layers of content nesting.</para></remarks>
		[Export ("createContextForIdentifier:parentContext:parentIdentifierPath:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual CLSContext? CreateContext (string identifier, CLSContext parentContext, string[] parentIdentifierPath)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
	} /* class CLSDataStoreDelegate */
}
