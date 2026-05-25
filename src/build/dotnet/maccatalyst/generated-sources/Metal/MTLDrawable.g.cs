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
using Metal;
using CoreML;
using AppKit;
using MapKit;
using Photos;
using ModelIO;
using Network;
using SceneKit;
using Contacts;
using Security;
using CloudKit;
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
using FileProvider;
using CoreAnimation;
using CoreFoundation;
using NetworkExtension;
using MetalPerformanceShadersGraph;
#nullable enable
namespace Metal {
	#pragma warning disable CS1573
	/// <summary>Interface definition for objects that can receive rendering commands.</summary><related type="externalDocumentation" href="https://developer.apple.com/library/ios/documentation/Metal/Reference/MTLDrawable_Ref/index.html">Apple documentation for <c>MTLDrawable</c></related>
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("tvos")]
	[Protocol (Name = "MTLDrawable", WrapperType = typeof (MTLDrawableWrapper))]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "Present", Selector = "present")]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "Present", Selector = "presentAtTime:", ParameterType = new Type [] { typeof (double) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "PresentAfter", Selector = "presentAfterMinimumDuration:", ParameterType = new Type [] { typeof (double) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "AddPresentedHandler", Selector = "addPresentedHandler:", ParameterType = new Type [] { typeof (global::System.Action<global::Metal.IMTLDrawable>) }, ParameterByRef = new bool [] { false }, ParameterBlockProxy = new Type? [] { typeof (ObjCRuntime.Trampolines.NIDActionArity1V29) })]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "PresentedTime", Selector = "presentedTime", PropertyType = typeof (double), GetterSelector = "presentedTime", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "DrawableId", Selector = "drawableID", PropertyType = typeof (UIntPtr), GetterSelector = "drawableID", ArgumentSemantic = ArgumentSemantic.None)]
	public partial interface IMTLDrawable : INativeObject, IDisposable
	{
		/// <summary>To be added.</summary><remarks>To be added.</remarks>
		[global::Foundation.RequiredMember]
		[Export ("present")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void Present ()
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _Present (IMTLDrawable This)
		{
			global::ObjCRuntime.Messaging.void_objc_msgSend (This.Handle, Selector.GetHandle ("present"));
			GC.KeepAlive (This);
		}
		/// <param name="presentationTime">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[global::Foundation.RequiredMember]
		[Export ("presentAtTime:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void Present (double presentationTime)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="presentationTime">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _Present (IMTLDrawable This, double presentationTime)
		{
			global::ObjCRuntime.Messaging.void_objc_msgSend_Double (This.Handle, Selector.GetHandle ("presentAtTime:"), presentationTime);
			GC.KeepAlive (This);
		}
		/// <summary>Causes the drawable to be presented at least <paramref name="duration" /> seconds after the previous drawable has been presented.</summary><param name="duration">The minimum time after which to display the drawable.</param>
		[global::Foundation.RequiredMember]
		[Export ("presentAfterMinimumDuration:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void PresentAfter (double duration)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <summary>Causes the drawable to be presented at least <paramref name="duration" /> seconds after the previous drawable has been presented.</summary><param name="duration">The minimum time after which to display the drawable.</param>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _PresentAfter (IMTLDrawable This, double duration)
		{
			global::ObjCRuntime.Messaging.void_objc_msgSend_Double (This.Handle, Selector.GetHandle ("presentAfterMinimumDuration:"), duration);
			GC.KeepAlive (This);
		}
		/// <summary>Causes the provided <paramref name="block" /> to be run after the drawable is displayed.</summary><param name="block">The code that will be called after the drawable is displayed.</param>
		[global::Foundation.RequiredMember]
		[Export ("addPresentedHandler:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void AddPresentedHandler ([BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V29))]global::System.Action<IMTLDrawable> block)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <summary>Causes the provided <paramref name="block" /> to be run after the drawable is displayed.</summary><param name="block">The code that will be called after the drawable is displayed.</param>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal unsafe static void _AddPresentedHandler (IMTLDrawable This, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V29))]global::System.Action<IMTLDrawable> block)
		{
			if (block is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (block));
			using var block_block = Trampolines.SDActionArity1V29.CreateBlock (block);
			BlockLiteral *block_ptr_block = &block_block;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("addPresentedHandler:"), (IntPtr) block_ptr_block);
			GC.KeepAlive (This);
		}
		[DynamicDependencyAttribute ("AddPresentedHandler(System.Action{Metal.IMTLDrawable})")]
		[DynamicDependencyAttribute ("DrawableId")]
		[DynamicDependencyAttribute ("Present()")]
		[DynamicDependencyAttribute ("Present(System.Double)")]
		[DynamicDependencyAttribute ("PresentAfter(System.Double)")]
		[DynamicDependencyAttribute ("PresentedTime")]
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.Interfaces | DynamicallyAccessedMemberTypes.PublicConstructors, typeof (MTLDrawableWrapper))]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static IMTLDrawable ()
		{
			GC.KeepAlive (null);
		}
		/// <summary>Returns the time, in seconds, when the host displayed this drawable.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[global::Foundation.RequiredMember]
		public virtual double PresentedTime {
			[Export ("presentedTime")]
			get {
				return _GetPresentedTime (this);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static double _GetPresentedTime (IMTLDrawable This)
		{
			double ret;
			ret = global::ObjCRuntime.Messaging.Double_objc_msgSend (This.Handle, Selector.GetHandle ("presentedTime"));
			GC.KeepAlive (This);
			return ret;
		}
		/// <summary>Returns the positive integer that identifies the drawable.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[global::Foundation.RequiredMember]
		public virtual nuint DrawableId {
			[Export ("drawableID")]
			get {
				return _GetDrawableId (this);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static nuint _GetDrawableId (IMTLDrawable This)
		{
			nuint ret;
			ret = global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend (This.Handle, Selector.GetHandle ("drawableID"));
			GC.KeepAlive (This);
			return ret;
		}
	}
	#pragma warning restore CS1573
	internal unsafe sealed class MTLDrawableWrapper : BaseWrapper, IMTLDrawable {
		public MTLDrawableWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.PublicConstructors, typeof (MTLDrawableWrapper))]
		static MTLDrawableWrapper ()
		{
			GC.KeepAlive (null);
		}
		/// <summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("present")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void Present ()
		{
			global::ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, Selector.GetHandle ("present"));
		}
		/// <param name="presentationTime">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("presentAtTime:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void Present (double presentationTime)
		{
			global::ObjCRuntime.Messaging.void_objc_msgSend_Double (this.Handle, Selector.GetHandle ("presentAtTime:"), presentationTime);
		}
		/// <summary>Causes the drawable to be presented at least <paramref name="duration" /> seconds after the previous drawable has been presented.</summary><param name="duration">The minimum time after which to display the drawable.</param>
		[Export ("presentAfterMinimumDuration:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void PresentAfter (double duration)
		{
			global::ObjCRuntime.Messaging.void_objc_msgSend_Double (this.Handle, Selector.GetHandle ("presentAfterMinimumDuration:"), duration);
		}
		/// <summary>Causes the provided <paramref name="block" /> to be run after the drawable is displayed.</summary><param name="block">The code that will be called after the drawable is displayed.</param>
		[Export ("addPresentedHandler:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe void AddPresentedHandler ([BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V29))]global::System.Action<IMTLDrawable> block)
		{
			if (block is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (block));
			using var block_block = Trampolines.SDActionArity1V29.CreateBlock (block);
			BlockLiteral *block_ptr_block = &block_block;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("addPresentedHandler:"), (IntPtr) block_ptr_block);
		}
		/// <summary>Returns the time, in seconds, when the host displayed this drawable.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public double PresentedTime {
			[Export ("presentedTime")]
			get {
				double ret;
				ret = global::ObjCRuntime.Messaging.Double_objc_msgSend (this.Handle, Selector.GetHandle ("presentedTime"));
				return ret;
			}
		}
		/// <summary>Returns the positive integer that identifies the drawable.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public nuint DrawableId {
			[Export ("drawableID")]
			get {
				nuint ret;
				ret = global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("drawableID"));
				return ret;
			}
		}
	}
}
namespace Metal {
	/// <summary>Interface definition for objects that can receive rendering commands.</summary><related type="externalDocumentation" href="https://developer.apple.com/library/ios/documentation/Metal/Reference/MTLDrawable_Ref/index.html">Apple documentation for <c>MTLDrawable</c></related>
	[Protocol()]
	[Register("Microsoft_MacCatalyst__Metal_MTLDrawable", false)]
	[Model]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("tvos")]
	public unsafe abstract partial class MTLDrawable : NSObject, IMTLDrawable {
		/// <summary>Creates a new <see cref="MTLDrawable" /> with default values.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		protected MTLDrawable () : base (NSObjectFlag.Empty)
		{
			IsDirectBinding = false;
			unsafe {
			var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
			InitializeHandle (global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (&__objc_super__, global::ObjCRuntime.Selector.GetHandle ("init")), "init");
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
		protected MTLDrawable (NSObjectFlag t) : base (t)
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
		protected internal MTLDrawable (NativeHandle handle) : base (handle)
		{
			IsDirectBinding = false;
		}

		/// <summary>Causes the provided <paramref name="block" /> to be run after the drawable is displayed.</summary><param name="block">The code that will be called after the drawable is displayed.</param>
		[Export ("addPresentedHandler:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void AddPresentedHandler ([BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V29))]global::System.Action<IMTLDrawable> block)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("present")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void Present ()
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="presentationTime">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("presentAtTime:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void Present (double presentationTime)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <summary>Causes the drawable to be presented at least <paramref name="duration" /> seconds after the previous drawable has been presented.</summary><param name="duration">The minimum time after which to display the drawable.</param>
		[Export ("presentAfterMinimumDuration:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void PresentAfter (double duration)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <summary>Returns the positive integer that identifies the drawable.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public virtual nuint DrawableId {
			[Export ("drawableID")]
			get {
				throw new ModelNotImplementedException ();
			}
		}
		/// <summary>Returns the time, in seconds, when the host displayed this drawable.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public virtual double PresentedTime {
			[Export ("presentedTime")]
			get {
				throw new ModelNotImplementedException ();
			}
		}
	} /* class MTLDrawable */
}
