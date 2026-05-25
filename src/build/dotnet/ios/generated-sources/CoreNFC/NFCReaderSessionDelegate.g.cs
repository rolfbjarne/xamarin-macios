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
namespace CoreNFC {
	#pragma warning disable CS1573
	/// <summary>Delegate object for <see cref="T:CoreNFC.NFCReaderSession" /> objects.</summary>
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[Protocol (Name = "NFCReaderSessionDelegate", WrapperType = typeof (NFCReaderSessionDelegateWrapper))]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "DidBecomeActive", Selector = "readerSessionDidBecomeActive:", ParameterType = new Type [] { typeof (CoreNFC.NFCReaderSession) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidDetectTags", Selector = "readerSession:didDetectTags:", ParameterType = new Type [] { typeof (CoreNFC.NFCReaderSession), typeof (CoreNFC.INFCTag[]) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "DidInvalidate", Selector = "readerSession:didInvalidateWithError:", ParameterType = new Type [] { typeof (CoreNFC.NFCReaderSession), typeof (NSError) }, ParameterByRef = new bool [] { false, false })]
	public partial interface INFCReaderSessionDelegate : INativeObject, IDisposable
	{
		/// <param name="session">The session that became active.</param><summary>Developers may override this method to react to the <see cref="T:CoreNFC.NFCReaderSession" /> activating.</summary><remarks>To be added.</remarks>
		[global::Foundation.RequiredMember]
		[Export ("readerSessionDidBecomeActive:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidBecomeActive (NFCReaderSession session)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="session">The session that became active.</param><summary>Developers may override this method to react to the <see cref="T:CoreNFC.NFCReaderSession" /> activating.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _DidBecomeActive (INFCReaderSessionDelegate This, NFCReaderSession session)
		{
			var session__handle__ = session!.GetNonNullHandle (nameof (session));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("readerSessionDidBecomeActive:"), session__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (session);
		}
		/// <param name="session">The session that detected the tags.</param><param name="tags">The tags that were detected.</param><summary>Developers may override this method to react to the detection of NFC <paramref name="tags" />.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("readerSession:didDetectTags:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidDetectTags (NFCReaderSession session, INFCTag[] tags)
		{
			_DidDetectTags (this, session, tags);
		}
		/// <param name="session">The session that detected the tags.</param><param name="tags">The tags that were detected.</param><summary>Developers may override this method to react to the detection of NFC <paramref name="tags" />.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _DidDetectTags (INFCReaderSessionDelegate This, NFCReaderSession session, INFCTag[] tags)
		{
			var session__handle__ = session!.GetNonNullHandle (nameof (session));
			if (tags is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (tags));
			using var nsa_tags = NSArray.FromNSObjects (tags);
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("readerSession:didDetectTags:"), session__handle__, nsa_tags.Handle);
			GC.KeepAlive (This);
			GC.KeepAlive (session);
		}
		/// <param name="session">The session that was invalidated.</param><param name="error">The error that invalidated the session.</param><summary>Developers may override this method to react to the invalidation of the <see cref="T:CoreNFC.NFCReaderSession" />.</summary><remarks>To be added.</remarks>
		[global::Foundation.RequiredMember]
		[Export ("readerSession:didInvalidateWithError:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidInvalidate (NFCReaderSession session, NSError error)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="session">The session that was invalidated.</param><param name="error">The error that invalidated the session.</param><summary>Developers may override this method to react to the invalidation of the <see cref="T:CoreNFC.NFCReaderSession" />.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _DidInvalidate (INFCReaderSessionDelegate This, NFCReaderSession session, NSError error)
		{
			var session__handle__ = session!.GetNonNullHandle (nameof (session));
			var error__handle__ = error!.GetNonNullHandle (nameof (error));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("readerSession:didInvalidateWithError:"), session__handle__, error__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (session);
			GC.KeepAlive (error);
		}
		[DynamicDependencyAttribute ("DidBecomeActive(CoreNFC.NFCReaderSession)")]
		[DynamicDependencyAttribute ("DidDetectTags(CoreNFC.NFCReaderSession,CoreNFC.INFCTag[])")]
		[DynamicDependencyAttribute ("DidInvalidate(CoreNFC.NFCReaderSession,Foundation.NSError)")]
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.Interfaces | DynamicallyAccessedMemberTypes.PublicConstructors, typeof (NFCReaderSessionDelegateWrapper))]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static INFCReaderSessionDelegate ()
		{
			GC.KeepAlive (null);
		}
	}
	#pragma warning restore CS1573
	#pragma warning disable CS1573
	/// <summary>Extension methods to the <see cref="INFCReaderSessionDelegate" /> interface to support all the methods from the NFCReaderSessionDelegate protocol.</summary>
	/// <remarks>
	///   <para>The extension methods for <see cref="INFCReaderSessionDelegate" /> interface allow developers to treat instances of the interface as having all the optional methods of the original NFCReaderSessionDelegate protocol. Since the interface only contains the required members, these extension methods allow developers to call the optional members of the protocol.</para>
	/// </remarks>
	public unsafe static partial class NFCReaderSessionDelegate_Extensions {
		/// <param name="session">The session that detected the tags.</param><param name="tags">The tags that were detected.</param><summary>Developers may override this method to react to the detection of NFC <paramref name="tags" />.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void DidDetectTags (this INFCReaderSessionDelegate This, NFCReaderSession session, INFCTag[] tags)
		{
			var session__handle__ = session!.GetNonNullHandle (nameof (session));
			if (tags is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (tags));
			using var nsa_tags = NSArray.FromNSObjects (tags);
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("readerSession:didDetectTags:"), session__handle__, nsa_tags.Handle);
			GC.KeepAlive (This);
			GC.KeepAlive (session);
		}
	}
	#pragma warning restore CS1573
	internal unsafe sealed class NFCReaderSessionDelegateWrapper : BaseWrapper, INFCReaderSessionDelegate {
		public NFCReaderSessionDelegateWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.PublicConstructors, typeof (NFCReaderSessionDelegateWrapper))]
		static NFCReaderSessionDelegateWrapper ()
		{
			GC.KeepAlive (null);
		}
		/// <param name="session">The session that became active.</param><summary>Developers may override this method to react to the <see cref="T:CoreNFC.NFCReaderSession" /> activating.</summary><remarks>To be added.</remarks>
		[Export ("readerSessionDidBecomeActive:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void DidBecomeActive (NFCReaderSession session)
		{
			var session__handle__ = session!.GetNonNullHandle (nameof (session));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("readerSessionDidBecomeActive:"), session__handle__);
			GC.KeepAlive (session);
		}
		/// <param name="session">The session that was invalidated.</param><param name="error">The error that invalidated the session.</param><summary>Developers may override this method to react to the invalidation of the <see cref="T:CoreNFC.NFCReaderSession" />.</summary><remarks>To be added.</remarks>
		[Export ("readerSession:didInvalidateWithError:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void DidInvalidate (NFCReaderSession session, NSError error)
		{
			var session__handle__ = session!.GetNonNullHandle (nameof (session));
			var error__handle__ = error!.GetNonNullHandle (nameof (error));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("readerSession:didInvalidateWithError:"), session__handle__, error__handle__);
			GC.KeepAlive (session);
			GC.KeepAlive (error);
		}
	}
}
namespace CoreNFC {
	/// <summary>Delegate object for <see cref="T:CoreNFC.NFCReaderSession" /> objects.</summary>
	[Protocol()]
	[Register("Microsoft_iOS__CoreNFC_NFCReaderSessionDelegate", false)]
	[Model]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	public unsafe abstract partial class NFCReaderSessionDelegate : NSObject, INFCReaderSessionDelegate {
		/// <summary>Creates a new <see cref="NFCReaderSessionDelegate" /> with default values.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		protected NFCReaderSessionDelegate () : base (NSObjectFlag.Empty)
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
		protected NFCReaderSessionDelegate (NSObjectFlag t) : base (t)
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
		protected internal NFCReaderSessionDelegate (NativeHandle handle) : base (handle)
		{
			IsDirectBinding = false;
		}

		/// <param name="session">The session that became active.</param><summary>Developers may override this method to react to the <see cref="T:CoreNFC.NFCReaderSession" /> activating.</summary><remarks>To be added.</remarks>
		[Export ("readerSessionDidBecomeActive:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidBecomeActive (NFCReaderSession session)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="session">The session that detected the tags.</param><param name="tags">The tags that were detected.</param><summary>Developers may override this method to react to the detection of NFC <paramref name="tags" />.</summary><remarks>To be added.</remarks>
		[Export ("readerSession:didDetectTags:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidDetectTags (NFCReaderSession session, INFCTag[] tags)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="session">The session that was invalidated.</param><param name="error">The error that invalidated the session.</param><summary>Developers may override this method to react to the invalidation of the <see cref="T:CoreNFC.NFCReaderSession" />.</summary><remarks>To be added.</remarks>
		[Export ("readerSession:didInvalidateWithError:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidInvalidate (NFCReaderSession session, NSError error)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
	} /* class NFCReaderSessionDelegate */
}
