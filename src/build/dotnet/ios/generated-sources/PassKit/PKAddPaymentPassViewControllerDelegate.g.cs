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
namespace PassKit {
	#pragma warning disable CS1573
	/// <summary>Delegate object for <see cref="T:PassKit.PKAddPaymentPassViewController" /> whose members are called when prompting for an add payment request and when an <see cref="T:PassKit.PKAddPaymentPassRequest" /> has failed.</summary><related type="externalDocumentation" href="https://developer.apple.com/library/ios/documentation/PassKit/Reference/PKAddPaymentPassViewControllerDelegate_Protocol/index.html">Apple documentation for <c>PKAddPaymentPassViewControllerDelegate</c></related>
	[UnsupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[Protocol (Name = "PKAddPaymentPassViewControllerDelegate", WrapperType = typeof (PKAddPaymentPassViewControllerDelegateWrapper))]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "GenerateRequestWithCertificateChain", Selector = "addPaymentPassViewController:generateRequestWithCertificateChain:nonce:nonceSignature:completionHandler:", ParameterType = new Type [] { typeof (PassKit.PKAddPaymentPassViewController), typeof (NSData[]), typeof (NSData), typeof (NSData), typeof (global::System.Action<global::PassKit.PKAddPaymentPassRequest>) }, ParameterByRef = new bool [] { false, false, false, false, false }, ParameterBlockProxy = new Type? [] { null, null, null, null, typeof (ObjCRuntime.Trampolines.NIDActionArity1V228) })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "DidFinishAddingPaymentPass", Selector = "addPaymentPassViewController:didFinishAddingPaymentPass:error:", ParameterType = new Type [] { typeof (PassKit.PKAddPaymentPassViewController), typeof (PassKit.PKPaymentPass), typeof (NSError) }, ParameterByRef = new bool [] { false, false, false })]
	public partial interface IPKAddPaymentPassViewControllerDelegate : INativeObject, IDisposable
	{
		/// <param name="controller">To be added.</param><param name="certificates">To be added.</param><param name="nonce">To be added.</param><param name="nonceSignature">To be added.</param><param name="handler">To be added.</param><summary>Called to create an "add payment" request.</summary><remarks>To be added.</remarks>
		[global::Foundation.RequiredMember]
		[Export ("addPaymentPassViewController:generateRequestWithCertificateChain:nonce:nonceSignature:completionHandler:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void GenerateRequestWithCertificateChain (PKAddPaymentPassViewController controller, NSData[] certificates, NSData nonce, NSData nonceSignature, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V228))]global::System.Action<PKAddPaymentPassRequest> handler)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="controller">To be added.</param><param name="certificates">To be added.</param><param name="nonce">To be added.</param><param name="nonceSignature">To be added.</param><param name="handler">To be added.</param><summary>Called to create an "add payment" request.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal unsafe static void _GenerateRequestWithCertificateChain (IPKAddPaymentPassViewControllerDelegate This, PKAddPaymentPassViewController controller, NSData[] certificates, NSData nonce, NSData nonceSignature, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V228))]global::System.Action<PKAddPaymentPassRequest> handler)
		{
			var controller__handle__ = controller!.GetNonNullHandle (nameof (controller));
			if (certificates is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (certificates));
			var nonce__handle__ = nonce!.GetNonNullHandle (nameof (nonce));
			var nonceSignature__handle__ = nonceSignature!.GetNonNullHandle (nameof (nonceSignature));
			if (handler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (handler));
			using var nsa_certificates = NSArray.FromNSObjects (certificates);
			using var block_handler = Trampolines.SDActionArity1V228.CreateBlock (handler);
			BlockLiteral *block_ptr_handler = &block_handler;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("addPaymentPassViewController:generateRequestWithCertificateChain:nonce:nonceSignature:completionHandler:"), controller__handle__, nsa_certificates.Handle, nonce__handle__, nonceSignature__handle__, (IntPtr) block_ptr_handler);
			GC.KeepAlive (This);
			GC.KeepAlive (controller);
			GC.KeepAlive (nonce);
			GC.KeepAlive (nonceSignature);
		}
		/// <param name="controller">To be added.</param><param name="pass"><para>To be added.</para><para tool="nullallowed">This parameter can be <see langword="null" />.</para></param><param name="error"><para>To be added.</para><para tool="nullallowed">This parameter can be <see langword="null" />.</para></param><summary>Called to prompt the user for an "add payment" request.</summary><remarks>To be added.</remarks>
		[global::Foundation.RequiredMember]
		[Export ("addPaymentPassViewController:didFinishAddingPaymentPass:error:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidFinishAddingPaymentPass (PKAddPaymentPassViewController controller, PKPaymentPass? pass, NSError? error)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="controller">To be added.</param><param name="pass"><para>To be added.</para><para tool="nullallowed">This parameter can be <see langword="null" />.</para></param><param name="error"><para>To be added.</para><para tool="nullallowed">This parameter can be <see langword="null" />.</para></param><summary>Called to prompt the user for an "add payment" request.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _DidFinishAddingPaymentPass (IPKAddPaymentPassViewControllerDelegate This, PKAddPaymentPassViewController controller, PKPaymentPass? pass, NSError? error)
		{
			var controller__handle__ = controller!.GetNonNullHandle (nameof (controller));
			var pass__handle__ = pass.GetHandle ();
			var error__handle__ = error.GetHandle ();
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("addPaymentPassViewController:didFinishAddingPaymentPass:error:"), controller__handle__, pass__handle__, error__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (controller);
			GC.KeepAlive (pass);
			GC.KeepAlive (error);
		}
		[DynamicDependencyAttribute ("DidFinishAddingPaymentPass(PassKit.PKAddPaymentPassViewController,PassKit.PKPaymentPass,Foundation.NSError)")]
		[DynamicDependencyAttribute ("GenerateRequestWithCertificateChain(PassKit.PKAddPaymentPassViewController,Foundation.NSData[],Foundation.NSData,Foundation.NSData,System.Action{PassKit.PKAddPaymentPassRequest})")]
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.Interfaces | DynamicallyAccessedMemberTypes.PublicConstructors, typeof (PKAddPaymentPassViewControllerDelegateWrapper))]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static IPKAddPaymentPassViewControllerDelegate ()
		{
			GC.KeepAlive (null);
		}
	}
	#pragma warning restore CS1573
	internal unsafe sealed class PKAddPaymentPassViewControllerDelegateWrapper : BaseWrapper, IPKAddPaymentPassViewControllerDelegate {
		public PKAddPaymentPassViewControllerDelegateWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.PublicConstructors, typeof (PKAddPaymentPassViewControllerDelegateWrapper))]
		static PKAddPaymentPassViewControllerDelegateWrapper ()
		{
			GC.KeepAlive (null);
		}
		/// <param name="controller">To be added.</param><param name="certificates">To be added.</param><param name="nonce">To be added.</param><param name="nonceSignature">To be added.</param><param name="handler">To be added.</param><summary>Called to create an "add payment" request.</summary><remarks>To be added.</remarks>
		[Export ("addPaymentPassViewController:generateRequestWithCertificateChain:nonce:nonceSignature:completionHandler:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe void GenerateRequestWithCertificateChain (PKAddPaymentPassViewController controller, NSData[] certificates, NSData nonce, NSData nonceSignature, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V228))]global::System.Action<PKAddPaymentPassRequest> handler)
		{
			var controller__handle__ = controller!.GetNonNullHandle (nameof (controller));
			if (certificates is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (certificates));
			var nonce__handle__ = nonce!.GetNonNullHandle (nameof (nonce));
			var nonceSignature__handle__ = nonceSignature!.GetNonNullHandle (nameof (nonceSignature));
			if (handler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (handler));
			using var nsa_certificates = NSArray.FromNSObjects (certificates);
			using var block_handler = Trampolines.SDActionArity1V228.CreateBlock (handler);
			BlockLiteral *block_ptr_handler = &block_handler;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("addPaymentPassViewController:generateRequestWithCertificateChain:nonce:nonceSignature:completionHandler:"), controller__handle__, nsa_certificates.Handle, nonce__handle__, nonceSignature__handle__, (IntPtr) block_ptr_handler);
			GC.KeepAlive (controller);
			GC.KeepAlive (nonce);
			GC.KeepAlive (nonceSignature);
		}
		/// <param name="controller">To be added.</param><param name="pass"><para>To be added.</para><para tool="nullallowed">This parameter can be <see langword="null" />.</para></param><param name="error"><para>To be added.</para><para tool="nullallowed">This parameter can be <see langword="null" />.</para></param><summary>Called to prompt the user for an "add payment" request.</summary><remarks>To be added.</remarks>
		[Export ("addPaymentPassViewController:didFinishAddingPaymentPass:error:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void DidFinishAddingPaymentPass (PKAddPaymentPassViewController controller, PKPaymentPass? pass, NSError? error)
		{
			var controller__handle__ = controller!.GetNonNullHandle (nameof (controller));
			var pass__handle__ = pass.GetHandle ();
			var error__handle__ = error.GetHandle ();
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("addPaymentPassViewController:didFinishAddingPaymentPass:error:"), controller__handle__, pass__handle__, error__handle__);
			GC.KeepAlive (controller);
			GC.KeepAlive (pass);
			GC.KeepAlive (error);
		}
	}
}
namespace PassKit {
	/// <summary>Delegate object for <see cref="T:PassKit.PKAddPaymentPassViewController" /> whose members are called when prompting for an add payment request and when an <see cref="T:PassKit.PKAddPaymentPassRequest" /> has failed.</summary><related type="externalDocumentation" href="https://developer.apple.com/library/ios/documentation/PassKit/Reference/PKAddPaymentPassViewControllerDelegate_Protocol/index.html">Apple documentation for <c>PKAddPaymentPassViewControllerDelegate</c></related>
	[Protocol()]
	[Register("Microsoft_iOS__PassKit_PKAddPaymentPassViewControllerDelegate", false)]
	[Model]
	[UnsupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	public unsafe abstract partial class PKAddPaymentPassViewControllerDelegate : NSObject, IPKAddPaymentPassViewControllerDelegate {
		/// <summary>Creates a new <see cref="PKAddPaymentPassViewControllerDelegate" /> with default values.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		protected PKAddPaymentPassViewControllerDelegate () : base (NSObjectFlag.Empty)
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
		protected PKAddPaymentPassViewControllerDelegate (NSObjectFlag t) : base (t)
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
		protected internal PKAddPaymentPassViewControllerDelegate (NativeHandle handle) : base (handle)
		{
			IsDirectBinding = false;
		}

		/// <param name="controller">To be added.</param><param name="pass"><para>To be added.</para><para tool="nullallowed">This parameter can be <see langword="null" />.</para></param><param name="error"><para>To be added.</para><para tool="nullallowed">This parameter can be <see langword="null" />.</para></param><summary>Called to prompt the user for an "add payment" request.</summary><remarks>To be added.</remarks>
		[Export ("addPaymentPassViewController:didFinishAddingPaymentPass:error:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidFinishAddingPaymentPass (PKAddPaymentPassViewController controller, PKPaymentPass? pass, NSError? error)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="controller">To be added.</param><param name="certificates">To be added.</param><param name="nonce">To be added.</param><param name="nonceSignature">To be added.</param><param name="handler">To be added.</param><summary>Called to create an "add payment" request.</summary><remarks>To be added.</remarks>
		[Export ("addPaymentPassViewController:generateRequestWithCertificateChain:nonce:nonceSignature:completionHandler:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void GenerateRequestWithCertificateChain (PKAddPaymentPassViewController controller, NSData[] certificates, NSData nonce, NSData nonceSignature, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V228))]global::System.Action<PKAddPaymentPassRequest> handler)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
	} /* class PKAddPaymentPassViewControllerDelegate */
}
