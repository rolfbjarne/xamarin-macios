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
namespace Foundation {
	#pragma warning disable CS1573
	/// <summary>This interface represents the Objective-C protocol <c>NSKeyedUnarchiverDelegate</c>.</summary>
	/// <remarks>
	///   <para>A class that implements this interface (and subclasses <see cref="NSObject" />) will be exported to Objective-C as implementing the Objective-C protocol this interface represents.</para>
	///   <para>A class may also implement members from this interface to implement members from the protocol.</para>
	/// </remarks>
	[Protocol (Name = "NSKeyedUnarchiverDelegate", WrapperType = typeof (NSKeyedUnarchiverDelegateWrapper))]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DecodedObject", Selector = "unarchiver:didDecodeObject:", ReturnType = typeof (NSObject), ParameterType = new Type [] { typeof (NSKeyedUnarchiver), typeof (NSObject) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "Finished", Selector = "unarchiverDidFinish:", ParameterType = new Type [] { typeof (NSKeyedUnarchiver) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "CannotDecodeClass", Selector = "unarchiver:cannotDecodeObjectOfClassName:originalClasses:", ReturnType = typeof (Class), ParameterType = new Type [] { typeof (NSKeyedUnarchiver), typeof (string), typeof (String[]) }, ParameterByRef = new bool [] { false, false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "Finishing", Selector = "unarchiverWillFinish:", ParameterType = new Type [] { typeof (NSKeyedUnarchiver) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "ReplacingObject", Selector = "unarchiver:willReplaceObject:withObject:", ParameterType = new Type [] { typeof (NSKeyedUnarchiver), typeof (NSObject), typeof (NSObject) }, ParameterByRef = new bool [] { false, false, false })]
	public partial interface INSKeyedUnarchiverDelegate : INativeObject, IDisposable
	{
		/// <param name="unarchiver">To be added.</param><param name="obj">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("unarchiver:didDecodeObject:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSObject DecodedObject (NSKeyedUnarchiver unarchiver, NSObject obj)
		{
			return _DecodedObject (this, unarchiver, obj);
		}
		/// <param name="unarchiver">To be added.</param><param name="obj">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static NSObject _DecodedObject (INSKeyedUnarchiverDelegate This, NSKeyedUnarchiver unarchiver, NSObject obj)
		{
			var unarchiver__handle__ = unarchiver!.GetNonNullHandle (nameof (unarchiver));
			var obj__handle__ = obj!.GetNonNullHandle (nameof (obj));
			NSObject? ret;
			ret = Runtime.GetNSObject (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("unarchiver:didDecodeObject:"), unarchiver__handle__, obj__handle__), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (unarchiver);
			GC.KeepAlive (obj);
			return ret!;
		}
		/// <param name="unarchiver">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("unarchiverDidFinish:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void Finished (NSKeyedUnarchiver unarchiver)
		{
			_Finished (this, unarchiver);
		}
		/// <param name="unarchiver">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _Finished (INSKeyedUnarchiverDelegate This, NSKeyedUnarchiver unarchiver)
		{
			var unarchiver__handle__ = unarchiver!.GetNonNullHandle (nameof (unarchiver));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("unarchiverDidFinish:"), unarchiver__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (unarchiver);
		}
		/// <param name="unarchiver">To be added.</param><param name="klass">To be added.</param><param name="classes">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("unarchiver:cannotDecodeObjectOfClassName:originalClasses:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual Class CannotDecodeClass (NSKeyedUnarchiver unarchiver, string klass, string[] classes)
		{
			return _CannotDecodeClass (this, unarchiver, klass, classes);
		}
		/// <param name="unarchiver">To be added.</param><param name="klass">To be added.</param><param name="classes">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static Class _CannotDecodeClass (INSKeyedUnarchiverDelegate This, NSKeyedUnarchiver unarchiver, string klass, string[] classes)
		{
			var unarchiver__handle__ = unarchiver!.GetNonNullHandle (nameof (unarchiver));
			if (klass is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (klass));
			if (classes is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (classes));
			var nsklass = CFString.CreateNative (klass);
			using var nsa_classes = NSArray.FromStrings (classes);
			Class? ret;
			ret = Runtime.GetINativeObject<global::ObjCRuntime.Class> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("unarchiver:cannotDecodeObjectOfClassName:originalClasses:"), unarchiver__handle__, nsklass, nsa_classes.Handle), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (unarchiver);
			CFString.ReleaseNative (nsklass);
			return ret!;
		}
		/// <param name="unarchiver">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("unarchiverWillFinish:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void Finishing (NSKeyedUnarchiver unarchiver)
		{
			_Finishing (this, unarchiver);
		}
		/// <param name="unarchiver">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _Finishing (INSKeyedUnarchiverDelegate This, NSKeyedUnarchiver unarchiver)
		{
			var unarchiver__handle__ = unarchiver!.GetNonNullHandle (nameof (unarchiver));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("unarchiverWillFinish:"), unarchiver__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (unarchiver);
		}
		/// <param name="unarchiver">To be added.</param><param name="oldObject">To be added.</param><param name="newObject">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("unarchiver:willReplaceObject:withObject:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void ReplacingObject (NSKeyedUnarchiver unarchiver, NSObject oldObject, NSObject newObject)
		{
			_ReplacingObject (this, unarchiver, oldObject, newObject);
		}
		/// <param name="unarchiver">To be added.</param><param name="oldObject">To be added.</param><param name="newObject">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _ReplacingObject (INSKeyedUnarchiverDelegate This, NSKeyedUnarchiver unarchiver, NSObject oldObject, NSObject newObject)
		{
			var unarchiver__handle__ = unarchiver!.GetNonNullHandle (nameof (unarchiver));
			var oldObject__handle__ = oldObject!.GetNonNullHandle (nameof (oldObject));
			var newObject__handle__ = newObject!.GetNonNullHandle (nameof (newObject));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("unarchiver:willReplaceObject:withObject:"), unarchiver__handle__, oldObject__handle__, newObject__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (unarchiver);
			GC.KeepAlive (oldObject);
			GC.KeepAlive (newObject);
		}
		[DynamicDependencyAttribute ("CannotDecodeClass(Foundation.NSKeyedUnarchiver,System.String,System.String[])")]
		[DynamicDependencyAttribute ("DecodedObject(Foundation.NSKeyedUnarchiver,Foundation.NSObject)")]
		[DynamicDependencyAttribute ("Finished(Foundation.NSKeyedUnarchiver)")]
		[DynamicDependencyAttribute ("Finishing(Foundation.NSKeyedUnarchiver)")]
		[DynamicDependencyAttribute ("ReplacingObject(Foundation.NSKeyedUnarchiver,Foundation.NSObject,Foundation.NSObject)")]
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.Interfaces | DynamicallyAccessedMemberTypes.PublicConstructors, typeof (NSKeyedUnarchiverDelegateWrapper))]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static INSKeyedUnarchiverDelegate ()
		{
			GC.KeepAlive (null);
		}
	}
	#pragma warning restore CS1573
	#pragma warning disable CS1573
	/// <summary>Extension methods to the <see cref="INSKeyedUnarchiverDelegate" /> interface to support all the methods from the NSKeyedUnarchiverDelegate protocol.</summary>
	/// <remarks>
	///   <para>The extension methods for <see cref="INSKeyedUnarchiverDelegate" /> interface allow developers to treat instances of the interface as having all the optional methods of the original NSKeyedUnarchiverDelegate protocol. Since the interface only contains the required members, these extension methods allow developers to call the optional members of the protocol.</para>
	/// </remarks>
	public unsafe static partial class NSKeyedUnarchiverDelegate_Extensions {
		/// <param name="unarchiver">To be added.</param><param name="obj">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSObject DecodedObject (this INSKeyedUnarchiverDelegate This, NSKeyedUnarchiver unarchiver, NSObject obj)
		{
			var unarchiver__handle__ = unarchiver!.GetNonNullHandle (nameof (unarchiver));
			var obj__handle__ = obj!.GetNonNullHandle (nameof (obj));
			NSObject? ret;
			ret = Runtime.GetNSObject (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("unarchiver:didDecodeObject:"), unarchiver__handle__, obj__handle__), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (unarchiver);
			GC.KeepAlive (obj);
			return ret!;
		}
		/// <param name="unarchiver">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void Finished (this INSKeyedUnarchiverDelegate This, NSKeyedUnarchiver unarchiver)
		{
			var unarchiver__handle__ = unarchiver!.GetNonNullHandle (nameof (unarchiver));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("unarchiverDidFinish:"), unarchiver__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (unarchiver);
		}
		/// <param name="unarchiver">To be added.</param><param name="klass">To be added.</param><param name="classes">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static Class CannotDecodeClass (this INSKeyedUnarchiverDelegate This, NSKeyedUnarchiver unarchiver, string klass, string[] classes)
		{
			var unarchiver__handle__ = unarchiver!.GetNonNullHandle (nameof (unarchiver));
			if (klass is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (klass));
			if (classes is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (classes));
			var nsklass = CFString.CreateNative (klass);
			using var nsa_classes = NSArray.FromStrings (classes);
			Class? ret;
			ret = Runtime.GetINativeObject<global::ObjCRuntime.Class> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("unarchiver:cannotDecodeObjectOfClassName:originalClasses:"), unarchiver__handle__, nsklass, nsa_classes.Handle), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (unarchiver);
			CFString.ReleaseNative (nsklass);
			return ret!;
		}
		/// <param name="unarchiver">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void Finishing (this INSKeyedUnarchiverDelegate This, NSKeyedUnarchiver unarchiver)
		{
			var unarchiver__handle__ = unarchiver!.GetNonNullHandle (nameof (unarchiver));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("unarchiverWillFinish:"), unarchiver__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (unarchiver);
		}
		/// <param name="unarchiver">To be added.</param><param name="oldObject">To be added.</param><param name="newObject">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void ReplacingObject (this INSKeyedUnarchiverDelegate This, NSKeyedUnarchiver unarchiver, NSObject oldObject, NSObject newObject)
		{
			var unarchiver__handle__ = unarchiver!.GetNonNullHandle (nameof (unarchiver));
			var oldObject__handle__ = oldObject!.GetNonNullHandle (nameof (oldObject));
			var newObject__handle__ = newObject!.GetNonNullHandle (nameof (newObject));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("unarchiver:willReplaceObject:withObject:"), unarchiver__handle__, oldObject__handle__, newObject__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (unarchiver);
			GC.KeepAlive (oldObject);
			GC.KeepAlive (newObject);
		}
	}
	#pragma warning restore CS1573
	internal unsafe sealed class NSKeyedUnarchiverDelegateWrapper : BaseWrapper, INSKeyedUnarchiverDelegate {
		public NSKeyedUnarchiverDelegateWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.PublicConstructors, typeof (NSKeyedUnarchiverDelegateWrapper))]
		static NSKeyedUnarchiverDelegateWrapper ()
		{
			GC.KeepAlive (null);
		}
	}
}
namespace Foundation {
	/// <summary>
	///   <para>This is a class that implements the interface <see cref="INSKeyedUnarchiverDelegate" /> (for the protocol <c>NSKeyedUnarchiverDelegate</c>).</para>
	///   <para>Subclass this class to easily create a type that implements the protocol.</para>
	///   <para>An alternative is to create a subclass of <see cref="NSObject" /> and then implemented the interface <see cref="INSKeyedUnarchiverDelegate" />.</para>
	/// </summary>
	[Protocol()]
	[Register("Microsoft_macOS__Foundation_NSKeyedUnarchiverDelegate", false)]
	[Model]
	public unsafe partial class NSKeyedUnarchiverDelegate : NSObject, INSKeyedUnarchiverDelegate {
		/// <summary>Creates a new <see cref="NSKeyedUnarchiverDelegate" /> with default values.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public NSKeyedUnarchiverDelegate () : base (NSObjectFlag.Empty)
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
		protected NSKeyedUnarchiverDelegate (NSObjectFlag t) : base (t)
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
		protected internal NSKeyedUnarchiverDelegate (NativeHandle handle) : base (handle)
		{
			IsDirectBinding = false;
		}

		/// <param name="unarchiver">To be added.</param><param name="klass">To be added.</param><param name="classes">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("unarchiver:cannotDecodeObjectOfClassName:originalClasses:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual Class CannotDecodeClass (NSKeyedUnarchiver unarchiver, string klass, string[] classes)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="unarchiver">To be added.</param><param name="obj">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("unarchiver:didDecodeObject:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSObject DecodedObject (NSKeyedUnarchiver unarchiver, NSObject obj)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="unarchiver">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("unarchiverDidFinish:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void Finished (NSKeyedUnarchiver unarchiver)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="unarchiver">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("unarchiverWillFinish:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void Finishing (NSKeyedUnarchiver unarchiver)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="unarchiver">To be added.</param><param name="oldObject">To be added.</param><param name="newObject">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("unarchiver:willReplaceObject:withObject:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void ReplacingObject (NSKeyedUnarchiver unarchiver, NSObject oldObject, NSObject newObject)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
	} /* class NSKeyedUnarchiverDelegate */
}
