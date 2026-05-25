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
namespace AuthenticationServices {
	/// <summary>System-provided standard <see cref="T:UIKit.UIViewController" /> for presenting a credential provider extension.</summary>
	[Register("ASCredentialProviderViewController", true)]
	[SupportedOSPlatform ("maccatalyst")]
	[UnsupportedOSPlatform ("tvos")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	public unsafe partial class ASCredentialProviderViewController : global::UIKit.UIViewController {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly NativeHandle class_ptr = Class.GetHandle ("ASCredentialProviderViewController");
		/// <summary>The Objective-C class handle for this class.</summary>
		/// <value>The pointer to the Objective-C class.</value>
		/// <remarks>
		///     Each managed class mirrors an unmanaged Objective-C class.
		///     This value contains the pointer to the Objective-C class.
		///     It is similar to calling the managed <see cref="ObjCRuntime.Class.GetHandle(string)" /> or the native <see href="https://developer.apple.com/documentation/objectivec/1418952-objc_getclass">objc_getClass</see> method with the type name.
		/// </remarks>
		public override NativeHandle ClassHandle { get { return class_ptr; } }
		/// <summary>Creates a new <see cref="ASCredentialProviderViewController" /> with default values.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public ASCredentialProviderViewController () : base (NSObjectFlag.Empty)
		{
			if (IsDirectBinding) {
				InitializeHandle (global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, global::ObjCRuntime.Selector.GetHandle ("init")), "init");
			} else {
				unsafe {
				var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
				InitializeHandle (global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (&__objc_super__, global::ObjCRuntime.Selector.GetHandle ("init")), "init");
				GC.KeepAlive (this);
				}
			}
		}

		/// <summary>A constructor that initializes the object from the data stored in the unarchiver object.</summary>
		/// <param name="coder">The unarchiver object.</param>
		/// <remarks>
		///   <para>This constructor is provided to allow the class to be initialized from an unarchiver (for example, during NIB deserialization). This is part of the <see cref="Foundation.NSCoding" /> protocol.</para>
		///   <para>If developers want to create a subclass of this object and continue to support deserialization from an archive, they should implement a constructor with an identical signature: taking a single parameter of type <see cref="Foundation.NSCoder" /> and decorate it with the <c>[Export("initWithCoder:"]</c> attribute.</para>
		///   <para>The state of this object can also be serialized by using the <see cref="Foundation.INSCoding.EncodeTo" /> companion method.</para>
		/// </remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[DesignatedInitializer]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("initWithCoder:")]
		public ASCredentialProviderViewController (NSCoder coder) : base (NSObjectFlag.Empty)
		{
			if (IsDirectBinding) {
				InitializeHandle (global::ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("initWithCoder:"), coder.Handle), "initWithCoder:");
			} else {
				unsafe {
				var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
				InitializeHandle (global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper_IntPtr (&__objc_super__, Selector.GetHandle ("initWithCoder:"), coder.Handle), "initWithCoder:");
				GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (coder);
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
		protected ASCredentialProviderViewController (NSObjectFlag t) : base (t)
		{
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
		protected internal ASCredentialProviderViewController (NativeHandle handle) : base (handle)
		{
		}

		[Export ("performGeneratePasswordsRequestWithoutUserInteraction:")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("ios26.2")]
		[SupportedOSPlatform ("maccatalyst26.2")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void PerformGeneratePasswordsRequestWithoutUserInteraction (ASGeneratePasswordsRequest generatePasswordsRequest)
		{
			var generatePasswordsRequest__handle__ = generatePasswordsRequest!.GetNonNullHandle (nameof (generatePasswordsRequest));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("performGeneratePasswordsRequestWithoutUserInteraction:"), generatePasswordsRequest__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, Selector.GetHandle ("performGeneratePasswordsRequestWithoutUserInteraction:"), generatePasswordsRequest__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (generatePasswordsRequest);
		}
		[Export ("performPasskeyRegistrationWithoutUserInteractionIfPossible:")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("macos15.0")]
		[SupportedOSPlatform ("ios18.0")]
		[SupportedOSPlatform ("maccatalyst18.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void PerformPasskeyRegistrationWithoutUserInteractionIfPossible (ASPasskeyCredentialRequest registrationRequest)
		{
			var registrationRequest__handle__ = registrationRequest!.GetNonNullHandle (nameof (registrationRequest));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("performPasskeyRegistrationWithoutUserInteractionIfPossible:"), registrationRequest__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, Selector.GetHandle ("performPasskeyRegistrationWithoutUserInteractionIfPossible:"), registrationRequest__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (registrationRequest);
		}
		[Export ("performSavePasswordRequestWithoutUserInteractionIfPossible:")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("ios26.2")]
		[SupportedOSPlatform ("maccatalyst26.2")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void PerformSavePasswordRequestWithoutUserInteractionIfPossible (ASSavePasswordRequest savePasswordRequest)
		{
			var savePasswordRequest__handle__ = savePasswordRequest!.GetNonNullHandle (nameof (savePasswordRequest));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("performSavePasswordRequestWithoutUserInteractionIfPossible:"), savePasswordRequest__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, Selector.GetHandle ("performSavePasswordRequestWithoutUserInteractionIfPossible:"), savePasswordRequest__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (savePasswordRequest);
		}
		/// <param name="serviceIdentifiers">Zero or more service identifiers. More-specific identifiers are at lower index values.</param><summary>Developers should override this method to prepare a list of credentials for the <paramref name="serviceIdentifiers" />.</summary><remarks>To be added.</remarks>
		[Export ("prepareCredentialListForServiceIdentifiers:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void PrepareCredentialList (ASCredentialServiceIdentifier[] serviceIdentifiers)
		{
			if (serviceIdentifiers is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (serviceIdentifiers));
			using var nsa_serviceIdentifiers = NSArray.FromNSObjects (serviceIdentifiers);
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("prepareCredentialListForServiceIdentifiers:"), nsa_serviceIdentifiers.Handle);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, Selector.GetHandle ("prepareCredentialListForServiceIdentifiers:"), nsa_serviceIdentifiers.Handle);
					GC.KeepAlive (this);
				}
			}
		}
		[Export ("prepareCredentialListForServiceIdentifiers:requestParameters:")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("macos14.0")]
		[SupportedOSPlatform ("ios17.0")]
		[SupportedOSPlatform ("maccatalyst17.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void PrepareCredentialList (ASCredentialServiceIdentifier[] serviceIdentifiers, ASPasskeyCredentialRequestParameters requestParameters)
		{
			if (serviceIdentifiers is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (serviceIdentifiers));
			var requestParameters__handle__ = requestParameters!.GetNonNullHandle (nameof (requestParameters));
			using var nsa_serviceIdentifiers = NSArray.FromNSObjects (serviceIdentifiers);
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("prepareCredentialListForServiceIdentifiers:requestParameters:"), nsa_serviceIdentifiers.Handle, requestParameters__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, Selector.GetHandle ("prepareCredentialListForServiceIdentifiers:requestParameters:"), nsa_serviceIdentifiers.Handle, requestParameters__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (requestParameters);
		}
		/// <summary>Developers should override this method to prepare for the user-experience of enabling the developer's extension.</summary><remarks>To be added.</remarks>
		[Export ("prepareInterfaceForExtensionConfiguration")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void PrepareInterfaceForExtensionConfiguration ()
		{
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, Selector.GetHandle ("prepareInterfaceForExtensionConfiguration"));
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("prepareInterfaceForExtensionConfiguration"));
					GC.KeepAlive (this);
				}
			}
		}
		[Export ("prepareInterfaceForGeneratePasswordsRequest:")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("ios26.2")]
		[SupportedOSPlatform ("maccatalyst26.2")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void PrepareInterfaceForGeneratePasswordsRequest (ASGeneratePasswordsRequest generatePasswordsRequest)
		{
			var generatePasswordsRequest__handle__ = generatePasswordsRequest!.GetNonNullHandle (nameof (generatePasswordsRequest));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("prepareInterfaceForGeneratePasswordsRequest:"), generatePasswordsRequest__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, Selector.GetHandle ("prepareInterfaceForGeneratePasswordsRequest:"), generatePasswordsRequest__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (generatePasswordsRequest);
		}
		[Export ("prepareInterfaceForPasskeyRegistration:")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("macos14.0")]
		[SupportedOSPlatform ("ios17.0")]
		[SupportedOSPlatform ("maccatalyst17.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void PrepareInterfaceForPasskeyRegistration (IASCredentialRequest registrationRequest)
		{
			var registrationRequest__handle__ = registrationRequest!.GetNonNullHandle (nameof (registrationRequest));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("prepareInterfaceForPasskeyRegistration:"), registrationRequest__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, Selector.GetHandle ("prepareInterfaceForPasskeyRegistration:"), registrationRequest__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (registrationRequest);
		}
		[Export ("prepareInterfaceForSavePasswordRequest:")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("ios26.2")]
		[SupportedOSPlatform ("maccatalyst26.2")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void PrepareInterfaceForSavePasswordRequest (ASSavePasswordRequest savePasswordRequest)
		{
			var savePasswordRequest__handle__ = savePasswordRequest!.GetNonNullHandle (nameof (savePasswordRequest));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("prepareInterfaceForSavePasswordRequest:"), savePasswordRequest__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, Selector.GetHandle ("prepareInterfaceForSavePasswordRequest:"), savePasswordRequest__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (savePasswordRequest);
		}
		[Export ("prepareInterfaceForUserChoosingTextToInsert")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("ios18.0")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void PrepareInterfaceForUserChoosingTextToInsert ()
		{
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, Selector.GetHandle ("prepareInterfaceForUserChoosingTextToInsert"));
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("prepareInterfaceForUserChoosingTextToInsert"));
					GC.KeepAlive (this);
				}
			}
		}
		/// <param name="credentialIdentity">To be added.</param><summary>Developers should override this method which is called shortly before the user is shown the interface for the credential.</summary><remarks>To be added.</remarks>
		[Export ("prepareInterfaceToProvideCredentialForIdentity:")]
		[ObsoletedOSPlatform ("macos14.0", "Use 'PrepareInterfaceToProvideCredential (ASPasswordCredentialIdentity)' instead.")]
		[ObsoletedOSPlatform ("ios17.0", "Use 'PrepareInterfaceToProvideCredential (ASPasswordCredentialIdentity)' instead.")]
		[ObsoletedOSPlatform ("maccatalyst17.0", "Use 'PrepareInterfaceToProvideCredential (ASPasswordCredentialIdentity)' instead.")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void PrepareInterfaceToProvideCredential (ASPasswordCredentialIdentity credentialIdentity)
		{
			var credentialIdentity__handle__ = credentialIdentity!.GetNonNullHandle (nameof (credentialIdentity));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("prepareInterfaceToProvideCredentialForIdentity:"), credentialIdentity__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, Selector.GetHandle ("prepareInterfaceToProvideCredentialForIdentity:"), credentialIdentity__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (credentialIdentity);
		}
		[Export ("prepareInterfaceToProvideCredentialForRequest:")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("macos14.0")]
		[SupportedOSPlatform ("ios17.0")]
		[SupportedOSPlatform ("maccatalyst17.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void PrepareInterfaceToProvideCredential (IASCredentialRequest credentialRequest)
		{
			var credentialRequest__handle__ = credentialRequest!.GetNonNullHandle (nameof (credentialRequest));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("prepareInterfaceToProvideCredentialForRequest:"), credentialRequest__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, Selector.GetHandle ("prepareInterfaceToProvideCredentialForRequest:"), credentialRequest__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (credentialRequest);
		}
		[Export ("prepareOneTimeCodeCredentialListForServiceIdentifiers:")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("macos15.0")]
		[SupportedOSPlatform ("ios18.0")]
		[SupportedOSPlatform ("maccatalyst18.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void PrepareOneTimeCodeCredentialList (ASCredentialServiceIdentifier[] serviceIdentifiers)
		{
			if (serviceIdentifiers is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (serviceIdentifiers));
			using var nsa_serviceIdentifiers = NSArray.FromNSObjects (serviceIdentifiers);
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("prepareOneTimeCodeCredentialListForServiceIdentifiers:"), nsa_serviceIdentifiers.Handle);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, Selector.GetHandle ("prepareOneTimeCodeCredentialListForServiceIdentifiers:"), nsa_serviceIdentifiers.Handle);
					GC.KeepAlive (this);
				}
			}
		}
		/// <param name="credentialIdentity">To be added.</param><summary>Developers should override this method to attempt to provide the credential without user interaction.</summary><remarks>To be added.</remarks>
		[Export ("provideCredentialWithoutUserInteractionForIdentity:")]
		[ObsoletedOSPlatform ("macos14.0", "Use 'ProvideCredentialWithoutUserInteraction (ASCredentialRequest)' instead.")]
		[ObsoletedOSPlatform ("ios17.0", "Use 'ProvideCredentialWithoutUserInteraction (ASCredentialRequest)' instead.")]
		[ObsoletedOSPlatform ("maccatalyst17.0", "Use 'ProvideCredentialWithoutUserInteraction (ASCredentialRequest)' instead.")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void ProvideCredentialWithoutUserInteraction (ASPasswordCredentialIdentity credentialIdentity)
		{
			var credentialIdentity__handle__ = credentialIdentity!.GetNonNullHandle (nameof (credentialIdentity));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("provideCredentialWithoutUserInteractionForIdentity:"), credentialIdentity__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, Selector.GetHandle ("provideCredentialWithoutUserInteractionForIdentity:"), credentialIdentity__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (credentialIdentity);
		}
		[Export ("provideCredentialWithoutUserInteractionForRequest:")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("macos14.0")]
		[SupportedOSPlatform ("ios17.0")]
		[SupportedOSPlatform ("maccatalyst17.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void ProvideCredentialWithoutUserInteraction (IASCredentialRequest credentialRequest)
		{
			var credentialRequest__handle__ = credentialRequest!.GetNonNullHandle (nameof (credentialRequest));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("provideCredentialWithoutUserInteractionForRequest:"), credentialRequest__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, Selector.GetHandle ("provideCredentialWithoutUserInteractionForRequest:"), credentialRequest__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (credentialRequest);
		}
		[Export ("reportAllAcceptedPublicKeyCredentialsForRelyingParty:userHandle:acceptedCredentialIDs:")]
		[SupportedOSPlatform ("ios26.0")]
		[SupportedOSPlatform ("macos26.0")]
		[SupportedOSPlatform ("maccatalyst26.0")]
		[UnsupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void ReportAllAcceptedPublicKeyCredentials (string relyingParty, NSData userHandle, NSData[] acceptedCredentialIds)
		{
			if (relyingParty is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (relyingParty));
			var userHandle__handle__ = userHandle!.GetNonNullHandle (nameof (userHandle));
			if (acceptedCredentialIds is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (acceptedCredentialIds));
			var nsrelyingParty = CFString.CreateNative (relyingParty);
			using var nsa_acceptedCredentialIds = NSArray.FromNSObjects (acceptedCredentialIds);
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("reportAllAcceptedPublicKeyCredentialsForRelyingParty:userHandle:acceptedCredentialIDs:"), nsrelyingParty, userHandle__handle__, nsa_acceptedCredentialIds.Handle);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_NativeHandle_NativeHandle (&__objc_super__, Selector.GetHandle ("reportAllAcceptedPublicKeyCredentialsForRelyingParty:userHandle:acceptedCredentialIDs:"), nsrelyingParty, userHandle__handle__, nsa_acceptedCredentialIds.Handle);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (userHandle);
			CFString.ReleaseNative (nsrelyingParty);
		}
		[Export ("reportPublicKeyCredentialUpdateForRelyingParty:userHandle:newName:")]
		[SupportedOSPlatform ("ios26.0")]
		[SupportedOSPlatform ("macos26.0")]
		[SupportedOSPlatform ("maccatalyst26.0")]
		[UnsupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void ReportPublicKeyCredentialUpdate (string relyingParty, NSData userHandle, string newName)
		{
			if (relyingParty is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (relyingParty));
			var userHandle__handle__ = userHandle!.GetNonNullHandle (nameof (userHandle));
			if (newName is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (newName));
			var nsrelyingParty = CFString.CreateNative (relyingParty);
			var nsnewName = CFString.CreateNative (newName);
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("reportPublicKeyCredentialUpdateForRelyingParty:userHandle:newName:"), nsrelyingParty, userHandle__handle__, nsnewName);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_NativeHandle_NativeHandle (&__objc_super__, Selector.GetHandle ("reportPublicKeyCredentialUpdateForRelyingParty:userHandle:newName:"), nsrelyingParty, userHandle__handle__, nsnewName);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (userHandle);
			CFString.ReleaseNative (nsrelyingParty);
			CFString.ReleaseNative (nsnewName);
		}
		[Export ("reportUnknownPublicKeyCredentialForRelyingParty:credentialID:")]
		[SupportedOSPlatform ("ios26.0")]
		[SupportedOSPlatform ("macos26.0")]
		[SupportedOSPlatform ("maccatalyst26.0")]
		[UnsupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void ReportUnknownPublicKeyCredential (string relyingParty, NSData credentialId)
		{
			if (relyingParty is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (relyingParty));
			var credentialId__handle__ = credentialId!.GetNonNullHandle (nameof (credentialId));
			var nsrelyingParty = CFString.CreateNative (relyingParty);
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("reportUnknownPublicKeyCredentialForRelyingParty:credentialID:"), nsrelyingParty, credentialId__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, Selector.GetHandle ("reportUnknownPublicKeyCredentialForRelyingParty:credentialID:"), nsrelyingParty, credentialId__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (credentialId);
			CFString.ReleaseNative (nsrelyingParty);
		}
		[Export ("reportUnusedPasswordCredentialForDomain:userName:")]
		[SupportedOSPlatform ("ios26.0")]
		[SupportedOSPlatform ("macos26.0")]
		[SupportedOSPlatform ("maccatalyst26.0")]
		[UnsupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void ReportUnusedPasswordCredential (string domain, string userName)
		{
			if (domain is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (domain));
			if (userName is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (userName));
			var nsdomain = CFString.CreateNative (domain);
			var nsuserName = CFString.CreateNative (userName);
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("reportUnusedPasswordCredentialForDomain:userName:"), nsdomain, nsuserName);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, Selector.GetHandle ("reportUnusedPasswordCredentialForDomain:userName:"), nsdomain, nsuserName);
					GC.KeepAlive (this);
				}
			}
			CFString.ReleaseNative (nsdomain);
			CFString.ReleaseNative (nsuserName);
		}
		/// <summary>The <see cref="T:AuthenticationServices.ASCredentialProviderExtensionContext" /> of the provider.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual ASCredentialProviderExtensionContext ExtensionContext {
			[Export ("extensionContext", ArgumentSemantic.Retain)]
			get {
				ASCredentialProviderExtensionContext? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<ASCredentialProviderExtensionContext> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("extensionContext")), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<ASCredentialProviderExtensionContext> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("extensionContext")), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
	} /* class ASCredentialProviderViewController */
}
