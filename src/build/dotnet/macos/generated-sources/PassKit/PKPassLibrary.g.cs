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
namespace PassKit {
	/// <summary>Represents the user's library of passes.</summary><related type="externalDocumentation" href="https://developer.apple.com/library/ios/documentation/PassKit/Reference/PKPassLibrary_Ref/index.html">Apple documentation for <c>PKPassLibrary</c></related>
	[Register("PKPassLibrary", true)]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	public unsafe partial class PKPassLibrary : NSObject {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selActivateSecureElementPass_WithActivationData_Completion_X = "activateSecureElementPass:withActivationData:completion:";
		static readonly NativeHandle selActivateSecureElementPass_WithActivationData_Completion_XHandle = Selector.GetHandle ("activateSecureElementPass:withActivationData:completion:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAddPasses_WithCompletionHandler_X = "addPasses:withCompletionHandler:";
		static readonly NativeHandle selAddPasses_WithCompletionHandler_XHandle = Selector.GetHandle ("addPasses:withCompletionHandler:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAuthorizationStatusForCapability_X = "authorizationStatusForCapability:";
		static readonly NativeHandle selAuthorizationStatusForCapability_XHandle = Selector.GetHandle ("authorizationStatusForCapability:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selCanAddFelicaPassX = "canAddFelicaPass";
		static readonly NativeHandle selCanAddFelicaPassXHandle = Selector.GetHandle ("canAddFelicaPass");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selCanAddSecureElementPassWithPrimaryAccountIdentifier_X = "canAddSecureElementPassWithPrimaryAccountIdentifier:";
		static readonly NativeHandle selCanAddSecureElementPassWithPrimaryAccountIdentifier_XHandle = Selector.GetHandle ("canAddSecureElementPassWithPrimaryAccountIdentifier:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selContainsPass_X = "containsPass:";
		static readonly NativeHandle selContainsPass_XHandle = Selector.GetHandle ("containsPass:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selEncryptedServiceProviderDataForSecureElementPass_Completion_X = "encryptedServiceProviderDataForSecureElementPass:completion:";
		static readonly NativeHandle selEncryptedServiceProviderDataForSecureElementPass_Completion_XHandle = Selector.GetHandle ("encryptedServiceProviderDataForSecureElementPass:completion:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selEndAutomaticPassPresentationSuppressionWithRequestToken_X = "endAutomaticPassPresentationSuppressionWithRequestToken:";
		static readonly NativeHandle selEndAutomaticPassPresentationSuppressionWithRequestToken_XHandle = Selector.GetHandle ("endAutomaticPassPresentationSuppressionWithRequestToken:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selIsPassLibraryAvailableX = "isPassLibraryAvailable";
		static readonly NativeHandle selIsPassLibraryAvailableXHandle = Selector.GetHandle ("isPassLibraryAvailable");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selIsSecureElementPassActivationAvailableX = "isSecureElementPassActivationAvailable";
		static readonly NativeHandle selIsSecureElementPassActivationAvailableXHandle = Selector.GetHandle ("isSecureElementPassActivationAvailable");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selIsSuppressingAutomaticPassPresentationX = "isSuppressingAutomaticPassPresentation";
		static readonly NativeHandle selIsSuppressingAutomaticPassPresentationXHandle = Selector.GetHandle ("isSuppressingAutomaticPassPresentation");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selOpenPaymentSetupX = "openPaymentSetup";
		static readonly NativeHandle selOpenPaymentSetupXHandle = Selector.GetHandle ("openPaymentSetup");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selOpenPaymentSetupWithMerchantIdentifier_X = "openPaymentSetupWithMerchantIdentifier:";
		static readonly NativeHandle selOpenPaymentSetupWithMerchantIdentifier_XHandle = Selector.GetHandle ("openPaymentSetupWithMerchantIdentifier:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selPassWithPassTypeIdentifier_SerialNumber_X = "passWithPassTypeIdentifier:serialNumber:";
		static readonly NativeHandle selPassWithPassTypeIdentifier_SerialNumber_XHandle = Selector.GetHandle ("passWithPassTypeIdentifier:serialNumber:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selPassesX = "passes";
		static readonly NativeHandle selPassesXHandle = Selector.GetHandle ("passes");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selPassesOfType_X = "passesOfType:";
		static readonly NativeHandle selPassesOfType_XHandle = Selector.GetHandle ("passesOfType:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selPassesWithReaderIdentifier_X = "passesWithReaderIdentifier:";
		static readonly NativeHandle selPassesWithReaderIdentifier_XHandle = Selector.GetHandle ("passesWithReaderIdentifier:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selPresentSecureElementPass_X = "presentSecureElementPass:";
		static readonly NativeHandle selPresentSecureElementPass_XHandle = Selector.GetHandle ("presentSecureElementPass:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selRemoteSecureElementPassesX = "remoteSecureElementPasses";
		static readonly NativeHandle selRemoteSecureElementPassesXHandle = Selector.GetHandle ("remoteSecureElementPasses");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selRemovePass_X = "removePass:";
		static readonly NativeHandle selRemovePass_XHandle = Selector.GetHandle ("removePass:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selReplacePassWithPass_X = "replacePassWithPass:";
		static readonly NativeHandle selReplacePassWithPass_XHandle = Selector.GetHandle ("replacePassWithPass:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selRequestAuthorizationForCapability_Completion_X = "requestAuthorizationForCapability:completion:";
		static readonly NativeHandle selRequestAuthorizationForCapability_Completion_XHandle = Selector.GetHandle ("requestAuthorizationForCapability:completion:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selRequestAutomaticPassPresentationSuppressionWithResponseHandler_X = "requestAutomaticPassPresentationSuppressionWithResponseHandler:";
		static readonly NativeHandle selRequestAutomaticPassPresentationSuppressionWithResponseHandler_XHandle = Selector.GetHandle ("requestAutomaticPassPresentationSuppressionWithResponseHandler:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selServiceProviderDataForSecureElementPass_Completion_X = "serviceProviderDataForSecureElementPass:completion:";
		static readonly NativeHandle selServiceProviderDataForSecureElementPass_Completion_XHandle = Selector.GetHandle ("serviceProviderDataForSecureElementPass:completion:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSignData_WithSecureElementPass_Completion_X = "signData:withSecureElementPass:completion:";
		static readonly NativeHandle selSignData_WithSecureElementPass_Completion_XHandle = Selector.GetHandle ("signData:withSecureElementPass:completion:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly NativeHandle class_ptr = Class.GetHandle ("PKPassLibrary");
		/// <summary>The Objective-C class handle for this class.</summary>
		/// <value>The pointer to the Objective-C class.</value>
		/// <remarks>
		///     Each managed class mirrors an unmanaged Objective-C class.
		///     This value contains the pointer to the Objective-C class.
		///     It is similar to calling the managed <see cref="ObjCRuntime.Class.GetHandle(string)" /> or the native <see href="https://developer.apple.com/documentation/objectivec/1418952-objc_getclass">objc_getClass</see> method with the type name.
		/// </remarks>
		public override NativeHandle ClassHandle { get { return class_ptr; } }
		/// <summary>Creates a new <see cref="PKPassLibrary" /> with default values.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public PKPassLibrary () : base (NSObjectFlag.Empty)
		{
			if (IsDirectBinding) {
				InitializeHandle (global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, global::ObjCRuntime.Selector.Init), "init");
			} else {
				unsafe {
				var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
				InitializeHandle (global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (&__objc_super__, global::ObjCRuntime.Selector.Init), "init");
				GC.KeepAlive (this);
				}
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
		protected PKPassLibrary (NSObjectFlag t) : base (t)
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
		protected internal PKPassLibrary (NativeHandle handle) : base (handle)
		{
		}

		[Export ("activateSecureElementPass:withActivationData:completion:")]
		[SupportedOSPlatform ("ios13.4")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void ActivateSecureElementPass (PKSecureElementPass secureElementPass, NSData activationData, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity2V13))]global::System.Action<bool, NSError>? completion)
		{
			var secureElementPass__handle__ = secureElementPass!.GetNonNullHandle (nameof (secureElementPass));
			var activationData__handle__ = activationData!.GetNonNullHandle (nameof (activationData));
			using var block_completion = Trampolines.SDActionArity2V13.CreateNullableBlock (completion);
			BlockLiteral *block_ptr_completion = null;
			if (completion is not null)
				block_ptr_completion = &block_completion;
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (this.Handle, selActivateSecureElementPass_WithActivationData_Completion_XHandle, secureElementPass__handle__, activationData__handle__, (IntPtr) block_ptr_completion);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_NativeHandle_NativeHandle (&__objc_super__, selActivateSecureElementPass_WithActivationData_Completion_XHandle, secureElementPass__handle__, activationData__handle__, (IntPtr) block_ptr_completion);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (secureElementPass);
			GC.KeepAlive (activationData);
		}
		[SupportedOSPlatform ("ios13.4")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual Task<Tuple<bool,NSError>> ActivateSecureElementPassAsync (PKSecureElementPass secureElementPass, NSData activationData)
		{
			var tcs = new TaskCompletionSource<Tuple<bool,NSError>> ();
			ActivateSecureElementPass(secureElementPass, activationData, (arg1_, arg2_) => {
				tcs.SetResult (new Tuple<bool,NSError> (arg1_, arg2_));
			});
			return tcs.Task;
		}
		/// <param name="passes">To be added.</param><param name="completion"><para>To be added.</para><para tool="nullallowed">This parameter can be <see langword="null" />.</para></param><summary>Presents a standard UX for adding multiple passes.</summary><remarks>To be added.</remarks>
		[Export ("addPasses:withCompletionHandler:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void AddPasses (PKPass[] passes, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V89))]global::System.Action<PKPassLibraryAddPassesStatus>? completion)
		{
			if (passes is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (passes));
			using var nsa_passes = NSArray.FromNSObjects (passes);
			using var block_completion = Trampolines.SDActionArity1V89.CreateNullableBlock (completion);
			BlockLiteral *block_ptr_completion = null;
			if (completion is not null)
				block_ptr_completion = &block_completion;
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (this.Handle, selAddPasses_WithCompletionHandler_XHandle, nsa_passes.Handle, (IntPtr) block_ptr_completion);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, selAddPasses_WithCompletionHandler_XHandle, nsa_passes.Handle, (IntPtr) block_ptr_completion);
					GC.KeepAlive (this);
				}
			}
		}
		/// <param name="passes">To be added.</param>
		/// <summary>Presents a standard UX for adding multiple passes.</summary>
		/// <returns>
		///           <para class="improve-task-t-return-type-description">A task that represents the asynchronous AddPasses operation.  The value of the TResult parameter is of type System.Action&lt;PassKit.PKPassLibraryAddPassesStatus&gt;.</para>
		///         </returns>
		/// <remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual Task<PKPassLibraryAddPassesStatus> AddPassesAsync (PKPass[] passes)
		{
			var tcs = new TaskCompletionSource<PKPassLibraryAddPassesStatus> ();
			AddPasses(passes, (obj_) => {
				tcs.SetResult (obj_!);
			});
			return tcs.Task;
		}
		[Export ("canAddSecureElementPassWithPrimaryAccountIdentifier:")]
		[SupportedOSPlatform ("ios13.4")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool CanAddSecureElementPass (string primaryAccountIdentifier)
		{
			if (primaryAccountIdentifier is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (primaryAccountIdentifier));
			var nsprimaryAccountIdentifier = CFString.CreateNative (primaryAccountIdentifier);
			byte ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle (this.Handle, selCanAddSecureElementPassWithPrimaryAccountIdentifier_XHandle, nsprimaryAccountIdentifier);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper_NativeHandle (&__objc_super__, selCanAddSecureElementPassWithPrimaryAccountIdentifier_XHandle, nsprimaryAccountIdentifier);
					GC.KeepAlive (this);
				}
			}
			CFString.ReleaseNative (nsprimaryAccountIdentifier);
			return ret != 0;
		}
		/// <param name="pass">To be added.</param><summary>Whether the specified <paramref name="pass" /> is available.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("containsPass:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool Contains (PKPass pass)
		{
			var pass__handle__ = pass!.GetNonNullHandle (nameof (pass));
			byte ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle (this.Handle, selContainsPass_XHandle, pass__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper_NativeHandle (&__objc_super__, selContainsPass_XHandle, pass__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (pass);
			return ret != 0;
		}
		/// <param name="requestToken">To be added.</param><summary>Enables automatic display of the Apple Pay UI.</summary><remarks>To be added.</remarks>
		[Export ("endAutomaticPassPresentationSuppressionWithRequestToken:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void EndAutomaticPassPresentationSuppression (nuint requestToken)
		{
			global::ObjCRuntime.Messaging.void_objc_msgSend_UIntPtr (class_ptr, selEndAutomaticPassPresentationSuppressionWithRequestToken_XHandle, requestToken);
		}
		[Export ("authorizationStatusForCapability:")]
		[SupportedOSPlatform ("ios26.0")]
		[SupportedOSPlatform ("maccatalyst26.0")]
		[SupportedOSPlatform ("macos26.0")]
		[UnsupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual PKPassLibraryAuthorizationStatus GetAuthorizationStatus (PKPassLibraryCapability capability)
		{
			PKPassLibraryAuthorizationStatus ret;
			if (IsDirectBinding) {
				ret = (PassKit.PKPassLibraryAuthorizationStatus) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr (this.Handle, selAuthorizationStatusForCapability_XHandle, (IntPtr) (long) capability);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = (PassKit.PKPassLibraryAuthorizationStatus) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper_IntPtr (&__objc_super__, selAuthorizationStatusForCapability_XHandle, (IntPtr) (long) capability);
					GC.KeepAlive (this);
				}
			}
			return ret!;
		}
		[Export ("encryptedServiceProviderDataForSecureElementPass:completion:")]
		[SupportedOSPlatform ("ios16.0")]
		[SupportedOSPlatform ("maccatalyst16.0")]
		[SupportedOSPlatform ("macos13.0")]
		[UnsupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void GetEncryptedServiceProviderData (PKSecureElementPass secureElementPass, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity2V104))]global::System.Action<NSDictionary, NSError> completion)
		{
			var secureElementPass__handle__ = secureElementPass!.GetNonNullHandle (nameof (secureElementPass));
			if (completion is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completion));
			using var block_completion = Trampolines.SDActionArity2V104.CreateBlock (completion);
			BlockLiteral *block_ptr_completion = &block_completion;
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (this.Handle, selEncryptedServiceProviderDataForSecureElementPass_Completion_XHandle, secureElementPass__handle__, (IntPtr) block_ptr_completion);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, selEncryptedServiceProviderDataForSecureElementPass_Completion_XHandle, secureElementPass__handle__, (IntPtr) block_ptr_completion);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (secureElementPass);
		}
		[SupportedOSPlatform ("ios16.0")]
		[SupportedOSPlatform ("maccatalyst16.0")]
		[SupportedOSPlatform ("macos13.0")]
		[UnsupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual Task<NSDictionary> GetEncryptedServiceProviderDataAsync (PKSecureElementPass secureElementPass)
		{
			var tcs = new TaskCompletionSource<NSDictionary> ();
			GetEncryptedServiceProviderData(secureElementPass, (arg1_, arg2_) => {
				if (arg2_ is not null)
					tcs.SetException (new NSErrorException(arg2_));
				else
					tcs.SetResult (arg1_!);
			});
			return tcs.Task;
		}
		/// <param name="identifier">To be added.</param><param name="serialNumber">To be added.</param><summary>Returns the  <see cref="T:PassKit.PKPass" /> whose <see cref="P:PassKit.PKPass.PassTypeIdentifier" /> and <see cref="P:PassKit.PKPass.SerialNumber" /> match the arguments.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("passWithPassTypeIdentifier:serialNumber:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual PKPass? GetPass (string identifier, string serialNumber)
		{
			if (identifier is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (identifier));
			if (serialNumber is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (serialNumber));
			var nsidentifier = CFString.CreateNative (identifier);
			var nsserialNumber = CFString.CreateNative (serialNumber);
			PKPass? ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<PKPass> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (this.Handle, selPassWithPassTypeIdentifier_SerialNumber_XHandle, nsidentifier, nsserialNumber), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<PKPass> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, selPassWithPassTypeIdentifier_SerialNumber_XHandle, nsidentifier, nsserialNumber), false)!;
					GC.KeepAlive (this);
				}
			}
			CFString.ReleaseNative (nsidentifier);
			CFString.ReleaseNative (nsserialNumber);
			return ret!;
		}
		/// <summary>The passes in the user's pass library.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("passes")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual PKPass[] GetPasses ()
		{
			PKPass[] ret;
			if (IsDirectBinding) {
				ret = CFArray.ArrayFromHandle<PKPass>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selPassesXHandle), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = CFArray.ArrayFromHandle<PKPass>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selPassesXHandle), false)!;
					GC.KeepAlive (this);
				}
			}
			return ret;
		}
		[Export ("passesWithReaderIdentifier:")]
		[SupportedOSPlatform ("ios18.2")]
		[SupportedOSPlatform ("maccatalyst18.2")]
		[SupportedOSPlatform ("macos15.2")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSSet<PKSecureElementPass> GetPasses (string readerIdentifier)
		{
			if (readerIdentifier is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (readerIdentifier));
			var nsreaderIdentifier = CFString.CreateNative (readerIdentifier);
			NSSet<PKSecureElementPass>? ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<NSSet<PKSecureElementPass>> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, selPassesWithReaderIdentifier_XHandle, nsreaderIdentifier), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<NSSet<PKSecureElementPass>> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle (&__objc_super__, selPassesWithReaderIdentifier_XHandle, nsreaderIdentifier), false)!;
					GC.KeepAlive (this);
				}
			}
			CFString.ReleaseNative (nsreaderIdentifier);
			return ret!;
		}
		/// <param name="passType">To be added.</param><summary>The passes in the user's pass library whose <see cref="P:PassKit.PKPass.PassType" /> matches <paramref name="passType" />.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("passesOfType:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual PKPass[] GetPasses (PKPassType passType)
		{
			PKPass[] ret;
			if (IsDirectBinding) {
				ret = CFArray.ArrayFromHandle<PKPass>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_UIntPtr (this.Handle, selPassesOfType_XHandle, (UIntPtr) (ulong) passType), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = CFArray.ArrayFromHandle<PKPass>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_UIntPtr (&__objc_super__, selPassesOfType_XHandle, (UIntPtr) (ulong) passType), false)!;
					GC.KeepAlive (this);
				}
			}
			return ret;
		}
		[Export ("serviceProviderDataForSecureElementPass:completion:")]
		[SupportedOSPlatform ("ios15.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void GetServiceProviderData (PKSecureElementPass secureElementPass, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity2V16))]global::System.Action<NSData, NSError> completion)
		{
			var secureElementPass__handle__ = secureElementPass!.GetNonNullHandle (nameof (secureElementPass));
			if (completion is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completion));
			using var block_completion = Trampolines.SDActionArity2V16.CreateBlock (completion);
			BlockLiteral *block_ptr_completion = &block_completion;
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (this.Handle, selServiceProviderDataForSecureElementPass_Completion_XHandle, secureElementPass__handle__, (IntPtr) block_ptr_completion);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, selServiceProviderDataForSecureElementPass_Completion_XHandle, secureElementPass__handle__, (IntPtr) block_ptr_completion);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (secureElementPass);
		}
		[SupportedOSPlatform ("ios15.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual Task<NSData> GetServiceProviderDataAsync (PKSecureElementPass secureElementPass)
		{
			var tcs = new TaskCompletionSource<NSData> ();
			GetServiceProviderData(secureElementPass, (arg1_, arg2_) => {
				if (arg2_ is not null)
					tcs.SetException (new NSErrorException(arg2_));
				else
					tcs.SetResult (arg1_!);
			});
			return tcs.Task;
		}
		/// <summary>Presents to the user the standard interface to set up credit cards for use with Apple Pay.</summary><remarks>To be added.</remarks>
		[Export ("openPaymentSetup")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void OpenPaymentSetup ()
		{
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, selOpenPaymentSetupXHandle);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper (&__objc_super__, selOpenPaymentSetupXHandle);
					GC.KeepAlive (this);
				}
			}
		}
		/// <summary>Presents the standard interface for the specified merchant to set up credit cards for use with Apple Pay.</summary>
		[Export ("openPaymentSetupWithMerchantIdentifier:")]
		[SupportedOSPlatform ("ios26.4")]
		[SupportedOSPlatform ("macos26.4")]
		[SupportedOSPlatform ("maccatalyst26.4")]
		[UnsupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void OpenPaymentSetup (string merchantIdentifier)
		{
			if (merchantIdentifier is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (merchantIdentifier));
			var nsmerchantIdentifier = CFString.CreateNative (merchantIdentifier);
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selOpenPaymentSetupWithMerchantIdentifier_XHandle, nsmerchantIdentifier);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selOpenPaymentSetupWithMerchantIdentifier_XHandle, nsmerchantIdentifier);
					GC.KeepAlive (this);
				}
			}
			CFString.ReleaseNative (nsmerchantIdentifier);
		}
		[Export ("presentSecureElementPass:")]
		[SupportedOSPlatform ("ios13.4")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void PresentSecureElementPass (PKSecureElementPass pass)
		{
			var pass__handle__ = pass!.GetNonNullHandle (nameof (pass));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selPresentSecureElementPass_XHandle, pass__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selPresentSecureElementPass_XHandle, pass__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (pass);
		}
		/// <param name="pass">To be added.</param><summary>Removes the specified <paramref name="pass" /> from the pass library.</summary><remarks>To be added.</remarks>
		[Export ("removePass:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void Remove (PKPass pass)
		{
			var pass__handle__ = pass!.GetNonNullHandle (nameof (pass));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selRemovePass_XHandle, pass__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selRemovePass_XHandle, pass__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (pass);
		}
		/// <param name="pass">To be added.</param><summary>Replaces an existing pass with <paramref name="pass" />.</summary><returns>To be added.</returns><remarks>To be added.</remarks><!-- Huh? How do it know which one to replace? -->
		[Export ("replacePassWithPass:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool Replace (PKPass pass)
		{
			var pass__handle__ = pass!.GetNonNullHandle (nameof (pass));
			byte ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle (this.Handle, selReplacePassWithPass_XHandle, pass__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper_NativeHandle (&__objc_super__, selReplacePassWithPass_XHandle, pass__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (pass);
			return ret != 0;
		}
		[Export ("requestAuthorizationForCapability:completion:")]
		[SupportedOSPlatform ("ios26.0")]
		[SupportedOSPlatform ("maccatalyst26.0")]
		[SupportedOSPlatform ("macos26.0")]
		[UnsupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void RequestAuthorization (PKPassLibraryCapability capability, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V90))]global::System.Action<PKPassLibraryAuthorizationStatus> completion)
		{
			if (completion is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completion));
			using var block_completion = Trampolines.SDActionArity1V90.CreateBlock (completion);
			BlockLiteral *block_ptr_completion = &block_completion;
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr_NativeHandle (this.Handle, selRequestAuthorizationForCapability_Completion_XHandle, (IntPtr) (long) capability, (IntPtr) block_ptr_completion);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr_NativeHandle (&__objc_super__, selRequestAuthorizationForCapability_Completion_XHandle, (IntPtr) (long) capability, (IntPtr) block_ptr_completion);
					GC.KeepAlive (this);
				}
			}
		}
		[SupportedOSPlatform ("ios26.0")]
		[SupportedOSPlatform ("maccatalyst26.0")]
		[SupportedOSPlatform ("macos26.0")]
		[UnsupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual Task<PKPassLibraryAuthorizationStatus> RequestAuthorizationAsync (PKPassLibraryCapability capability)
		{
			var tcs = new TaskCompletionSource<PKPassLibraryAuthorizationStatus> ();
			RequestAuthorization(capability, (obj_) => {
				tcs.SetResult (obj_!);
			});
			return tcs.Task;
		}
		/// <param name="responseHandler">To be added.</param><summary>Stops the device from automatically presenting Apply Pay.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("requestAutomaticPassPresentationSuppressionWithResponseHandler:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static nuint RequestAutomaticPassPresentationSuppression ([BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V91))]global::System.Action<PKAutomaticPassPresentationSuppressionResult> responseHandler)
		{
			if (responseHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (responseHandler));
			using var block_responseHandler = Trampolines.SDActionArity1V91.CreateBlock (responseHandler);
			BlockLiteral *block_ptr_responseHandler = &block_responseHandler;
			nuint ret;
			ret = global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend_NativeHandle (class_ptr, selRequestAutomaticPassPresentationSuppressionWithResponseHandler_XHandle, (IntPtr) block_ptr_responseHandler);
			return ret;
		}
		[Export ("signData:withSecureElementPass:completion:")]
		[SupportedOSPlatform ("ios13.4")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void SignData (NSData signData, PKSecureElementPass secureElementPass, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDPKPassLibrarySignDataCompletionHandler))]PKPassLibrarySignDataCompletionHandler completion)
		{
			var signData__handle__ = signData!.GetNonNullHandle (nameof (signData));
			var secureElementPass__handle__ = secureElementPass!.GetNonNullHandle (nameof (secureElementPass));
			if (completion is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completion));
			using var block_completion = Trampolines.SDPKPassLibrarySignDataCompletionHandler.CreateBlock (completion);
			BlockLiteral *block_ptr_completion = &block_completion;
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (this.Handle, selSignData_WithSecureElementPass_Completion_XHandle, signData__handle__, secureElementPass__handle__, (IntPtr) block_ptr_completion);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_NativeHandle_NativeHandle (&__objc_super__, selSignData_WithSecureElementPass_Completion_XHandle, signData__handle__, secureElementPass__handle__, (IntPtr) block_ptr_completion);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (signData);
			GC.KeepAlive (secureElementPass);
		}
		[SupportedOSPlatform ("ios13.4")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual Task<PKSignDataCompletionResult> SignDataAsync (NSData signData, PKSecureElementPass secureElementPass)
		{
			var tcs = new TaskCompletionSource<PKSignDataCompletionResult> ();
			SignData(signData, secureElementPass, (signedData_, signature_, error_) => {
				if (error_ is not null)
					tcs.SetException (new NSErrorException(error_));
				else
					tcs.SetResult (new PKSignDataCompletionResult (signedData_!, signature_!));
			});
			return tcs.Task;
		}
		/// <summary>Gets a Boolean value that tells whether Felica passes can be added to the library.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		public virtual bool CanAddFelicaPass {
			[Export ("canAddFelicaPass")]
			get {
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selCanAddFelicaPassXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, selCanAddFelicaPassXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
		}
		/// <summary>Whether the pass library is available.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool IsAvailable {
			[Export ("isPassLibraryAvailable")]
			get {
				byte ret;
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (class_ptr, selIsPassLibraryAvailableXHandle);
				return ret != 0;
			}
		}
		/// <summary>Whether the system is suppressing automatic presentation of passes.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		public static bool IsSuppressingAutomaticPassPresentation {
			[Export ("isSuppressingAutomaticPassPresentation")]
			get {
				byte ret;
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (class_ptr, selIsSuppressingAutomaticPassPresentationXHandle);
				return ret != 0;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("ios13.4")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public virtual PKSecureElementPass[] RemoteSecureElementPasses {
			[Export ("remoteSecureElementPasses", ArgumentSemantic.Copy)]
			get {
				PKSecureElementPass[]? ret;
				if (IsDirectBinding) {
					ret = CFArray.ArrayFromHandle<PKSecureElementPass>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selRemoteSecureElementPassesXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFArray.ArrayFromHandle<PKSecureElementPass>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selRemoteSecureElementPassesXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("ios13.4")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public virtual bool SecureElementPassActivationAvailable {
			[Export ("isSecureElementPassActivationAvailable")]
			get {
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selIsSecureElementPassActivationAvailableXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, selIsSecureElementPassActivationAvailableXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _DidChangeNotification;
		/// <summary>Notification constant for DidChange</summary>
		/// <value><see cref="NSString" /> constant, should be used as a token to <see cref="NSNotificationCenter" />.</value>
		/// <remarks>
		///   <para>
		///     This constant can be used with <see cref="NSNotificationCenter" /> to register a listener for this notification.
		///     This is an <see cref="NSString" /> instead of a string, because these values can be used as tokens in some native
		///     libraries instead of being used purely for their actual string content. The 'notification' parameter to the callback
		///     contains extra information that is specific to the notification type.
		///   </para>
		///   <para>
		///     To subscribe to this notification, developers can use the convenience <see cref="Notifications.ObserveDidChange(NSObject,EventHandler{NSNotificationEventArgs})" />
		///     or <see cref="Notifications.ObserveDidChange(EventHandler{NSNotificationEventArgs})" /> methods,
		///     which offers strongly typed access to the parameters of the notification.
		///   </para>
		///   <para>
		///     The following example shows how to use the strongly typed <see cref="Notifications" /> class, to take the guesswork
		///     out of the available properties in the notification:
		///   </para>
		///   <example>
		///     <code lang="csharp lang-csharp"><![CDATA[
		/// //
		/// // Lambda style
		/// //
		///
		/// // listening
		/// notification = PKPassLibrary.Notifications.ObserveDidChange ((sender, args) => {
		/// /* Access strongly typed args */
		/// Console.WriteLine ("Notification: {0}", args.Notification);
		/// });
		///
		/// // To stop listening:
		/// notification.Dispose ();
		///
		/// //
		/// // Method style
		/// //
		/// NSObject notification;
		/// void Callback (object sender, PKPassLibrary.NSNotificationEventArgs args)
		/// {
		///     // Access strongly typed args
		///     Console.WriteLine ("Notification: {0}", args.Notification);
		/// }
		///
		/// void Setup ()
		/// {
		///     notification = PKPassLibrary.Notifications.ObserveDidChange (Callback);
		/// }
		///
		/// void Teardown ()
		/// {
		///     notification.Dispose ();
		/// }]]></code>
		///   </example>
		///   <para>
		///     The following example shows how to use the notification with the DefaultCenter API:
		///   </para>
		///   <example>
		///     <code lang="csharp lang-csharp"><![CDATA[
		/// // Lambda style
		/// NSNotificationCenter.DefaultCenter.AddObserver (
		///     PKPassLibrary.DidChangeNotification, (notification) => { Console.WriteLine ("Received the notification DidChange", notification); }
		/// );
		///
		/// // Method style
		/// void Callback (NSNotification notification)
		/// {
		///     Console.WriteLine ("Received the notification DidChange", notification);
		/// }
		///
		/// void Setup ()
		/// {
		///     NSNotificationCenter.DefaultCenter.AddObserver (PKPassLibrary.DidChangeNotification, Callback);
		/// }
		/// ]]></code>
		///   </example>
		/// </remarks>
		[Field ("PKPassLibraryDidChangeNotification",  "PassKit")]
		[Advice ("Use PKPassLibrary.Notifications.ObserveDidChange helper method instead.")]
		public static NSString DidChangeNotification {
			get {
				if (_DidChangeNotification is null)
					_DidChangeNotification = Dlfcn.GetStringConstant (Libraries.PassKit.Handle, "PKPassLibraryDidChangeNotification")!;
				return _DidChangeNotification;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _RemotePaymentPassesDidChangeNotification;
		/// <summary>Notification constant for RemotePaymentPassesDidChange</summary>
		/// <value><see cref="NSString" /> constant, should be used as a token to <see cref="NSNotificationCenter" />.</value>
		/// <remarks>
		///   <para>
		///     This constant can be used with <see cref="NSNotificationCenter" /> to register a listener for this notification.
		///     This is an <see cref="NSString" /> instead of a string, because these values can be used as tokens in some native
		///     libraries instead of being used purely for their actual string content. The 'notification' parameter to the callback
		///     contains extra information that is specific to the notification type.
		///   </para>
		///   <para>
		///     To subscribe to this notification, developers can use the convenience <see cref="Notifications.ObserveRemotePaymentPassesDidChange(NSObject,EventHandler{NSNotificationEventArgs})" />
		///     or <see cref="Notifications.ObserveRemotePaymentPassesDidChange(EventHandler{NSNotificationEventArgs})" /> methods,
		///     which offers strongly typed access to the parameters of the notification.
		///   </para>
		///   <para>
		///     The following example shows how to use the strongly typed <see cref="Notifications" /> class, to take the guesswork
		///     out of the available properties in the notification:
		///   </para>
		///   <example>
		///     <code lang="csharp lang-csharp"><![CDATA[
		/// //
		/// // Lambda style
		/// //
		///
		/// // listening
		/// notification = PKPassLibrary.Notifications.ObserveRemotePaymentPassesDidChange ((sender, args) => {
		/// /* Access strongly typed args */
		/// Console.WriteLine ("Notification: {0}", args.Notification);
		/// });
		///
		/// // To stop listening:
		/// notification.Dispose ();
		///
		/// //
		/// // Method style
		/// //
		/// NSObject notification;
		/// void Callback (object sender, PKPassLibrary.NSNotificationEventArgs args)
		/// {
		///     // Access strongly typed args
		///     Console.WriteLine ("Notification: {0}", args.Notification);
		/// }
		///
		/// void Setup ()
		/// {
		///     notification = PKPassLibrary.Notifications.ObserveRemotePaymentPassesDidChange (Callback);
		/// }
		///
		/// void Teardown ()
		/// {
		///     notification.Dispose ();
		/// }]]></code>
		///   </example>
		///   <para>
		///     The following example shows how to use the notification with the DefaultCenter API:
		///   </para>
		///   <example>
		///     <code lang="csharp lang-csharp"><![CDATA[
		/// // Lambda style
		/// NSNotificationCenter.DefaultCenter.AddObserver (
		///     PKPassLibrary.RemotePaymentPassesDidChangeNotification, (notification) => { Console.WriteLine ("Received the notification RemotePaymentPassesDidChange", notification); }
		/// );
		///
		/// // Method style
		/// void Callback (NSNotification notification)
		/// {
		///     Console.WriteLine ("Received the notification RemotePaymentPassesDidChange", notification);
		/// }
		///
		/// void Setup ()
		/// {
		///     NSNotificationCenter.DefaultCenter.AddObserver (PKPassLibrary.RemotePaymentPassesDidChangeNotification, Callback);
		/// }
		/// ]]></code>
		///   </example>
		/// </remarks>
		[Field ("PKPassLibraryRemotePaymentPassesDidChangeNotification",  "PassKit")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[Advice ("Use PKPassLibrary.Notifications.ObserveRemotePaymentPassesDidChange helper method instead.")]
		public static NSString RemotePaymentPassesDidChangeNotification {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			get {
				if (_RemotePaymentPassesDidChangeNotification is null)
					_RemotePaymentPassesDidChangeNotification = Dlfcn.GetStringConstant (Libraries.PassKit.Handle, "PKPassLibraryRemotePaymentPassesDidChangeNotification")!;
				return _RemotePaymentPassesDidChangeNotification;
			}
		}
		//
		// Notifications
		//
		/// <summary>Notifications posted by the <see cref="global::PassKit.PKPassLibrary" /> class.</summary>
		/// <remarks>
		///    <para>This class contains various helper methods that allow developers to observe events posted in the notification hub (<see cref="Foundation.NSNotificationCenter" />).</para>
		///    <para>The methods defined in this class post events that invoke the provided method or lambda with a <see cref="Foundation.NSNotificationEventArgs" /> parameter, which contains strongly typed properties for the notification arguments.</para>
		/// </remarks>
		public static partial class Notifications {
			/// <summary>Strongly typed notification for the <see cref="global::PassKit.PKPassLibrary.DidChangeNotification" /> constant.</summary>
			/// <param name="handler">The handler that responds to the notification when it occurs.</param>
			/// <returns>Token object that can be used to stop receiving notifications by either disposing it or passing it to <see cref="Foundation.NSNotificationCenter.RemoveObservers(System.Collections.Generic.IEnumerable{Foundation.NSObject})" />.</returns>
			/// <remarks>
			///   <para>This method can be used to subscribe to <see cref="global::PassKit.PKPassLibrary.DidChangeNotification" /> notifications.</para>
			///   <example>
			///   <code lang="csharp lang-csharp"><![CDATA[
			/// // Listen to all notifications posted for any object
			/// var token = PKPassLibrary.Notifications.ObserveDidChange ((notification) => {
			///   Console.WriteLine ("Observed DidChangeNotification!");
			/// };
			/// 
			/// // Stop listening for notifications
			/// token.Dispose ();
			/// ]]></code>
			///   </example>
			/// </remarks>
			public static NSObject ObserveDidChange (EventHandler<NSNotificationEventArgs> handler)
			{
				return NSNotificationCenter.DefaultCenter.AddObserver (DidChangeNotification, notification => handler (null, new NSNotificationEventArgs (notification)));
			}
			/// <summary>Strongly typed notification for the <see cref="global::PassKit.PKPassLibrary.DidChangeNotification" /> constant.</summary>
			/// <param name="objectToObserve">The specific object to observe.</param>
			/// <param name="handler">The handler that responds to the notification when it occurs.</param>
			/// <returns>Token object that can be used to stop receiving notifications by either disposing it or passing it to <see cref="Foundation.NSNotificationCenter.RemoveObservers(System.Collections.Generic.IEnumerable{Foundation.NSObject})" />.</returns>
			/// <remarks>
			///   <para>This method can be used to subscribe to <see cref="global::PassKit.PKPassLibrary.DidChangeNotification" /> notifications.</para>
			///   <example>
			///     <code lang="csharp lang-csharp"><![CDATA[
			/// // Listen to all notifications posted for a single object
			/// var token = PKPassLibrary.Notifications.ObserveDidChange (objectToObserve, (notification) => {
			///   Console.WriteLine ($"Observed DidChangeNotification for {nameof (objectToObserve)}!");
			/// };
			/// 
			/// // Stop listening for notifications
			/// token.Dispose ();
			/// ]]></code>
			///   </example>
			/// </remarks>
			public static NSObject ObserveDidChange (NSObject objectToObserve, EventHandler<NSNotificationEventArgs> handler)
			{
				return NSNotificationCenter.DefaultCenter.AddObserver (DidChangeNotification, notification => handler (null, new NSNotificationEventArgs (notification)), objectToObserve);
			}
			/// <summary>Strongly typed notification for the <see cref="global::PassKit.PKPassLibrary.RemotePaymentPassesDidChangeNotification" /> constant.</summary>
			/// <param name="handler">The handler that responds to the notification when it occurs.</param>
			/// <returns>Token object that can be used to stop receiving notifications by either disposing it or passing it to <see cref="Foundation.NSNotificationCenter.RemoveObservers(System.Collections.Generic.IEnumerable{Foundation.NSObject})" />.</returns>
			/// <remarks>
			///   <para>This method can be used to subscribe to <see cref="global::PassKit.PKPassLibrary.RemotePaymentPassesDidChangeNotification" /> notifications.</para>
			///   <example>
			///   <code lang="csharp lang-csharp"><![CDATA[
			/// // Listen to all notifications posted for any object
			/// var token = PKPassLibrary.Notifications.ObserveRemotePaymentPassesDidChange ((notification) => {
			///   Console.WriteLine ("Observed RemotePaymentPassesDidChangeNotification!");
			/// };
			/// 
			/// // Stop listening for notifications
			/// token.Dispose ();
			/// ]]></code>
			///   </example>
			/// </remarks>
			public static NSObject ObserveRemotePaymentPassesDidChange (EventHandler<NSNotificationEventArgs> handler)
			{
				return NSNotificationCenter.DefaultCenter.AddObserver (RemotePaymentPassesDidChangeNotification, notification => handler (null, new NSNotificationEventArgs (notification)));
			}
			/// <summary>Strongly typed notification for the <see cref="global::PassKit.PKPassLibrary.RemotePaymentPassesDidChangeNotification" /> constant.</summary>
			/// <param name="objectToObserve">The specific object to observe.</param>
			/// <param name="handler">The handler that responds to the notification when it occurs.</param>
			/// <returns>Token object that can be used to stop receiving notifications by either disposing it or passing it to <see cref="Foundation.NSNotificationCenter.RemoveObservers(System.Collections.Generic.IEnumerable{Foundation.NSObject})" />.</returns>
			/// <remarks>
			///   <para>This method can be used to subscribe to <see cref="global::PassKit.PKPassLibrary.RemotePaymentPassesDidChangeNotification" /> notifications.</para>
			///   <example>
			///     <code lang="csharp lang-csharp"><![CDATA[
			/// // Listen to all notifications posted for a single object
			/// var token = PKPassLibrary.Notifications.ObserveRemotePaymentPassesDidChange (objectToObserve, (notification) => {
			///   Console.WriteLine ($"Observed RemotePaymentPassesDidChangeNotification for {nameof (objectToObserve)}!");
			/// };
			/// 
			/// // Stop listening for notifications
			/// token.Dispose ();
			/// ]]></code>
			///   </example>
			/// </remarks>
			public static NSObject ObserveRemotePaymentPassesDidChange (NSObject objectToObserve, EventHandler<NSNotificationEventArgs> handler)
			{
				return NSNotificationCenter.DefaultCenter.AddObserver (RemotePaymentPassesDidChangeNotification, notification => handler (null, new NSNotificationEventArgs (notification)), objectToObserve);
			}
		}
	} /* class PKPassLibrary */
	//
	// Async result classes
	//
	/// <summary>This class holds the return values for an asynchronous operation.</summary>
	public partial class PKServiceProviderDataCompletionResult {
		/// <summary>The result value from the asynchronous operation.</summary>
		public NSData Arg1 { get; set; }
		partial void Initialize ();
		/// <summary>Creates a new instance of this class.</summary>
		/// <param name="arg1">Result value from an asynchronous operation.</param>
		public PKServiceProviderDataCompletionResult (NSData arg1) {
			this.Arg1 = arg1;
			Initialize ();
		}
	}
	/// <summary>This class holds the return values for an asynchronous operation.</summary>
	public partial class PKSignDataCompletionResult {
		/// <summary>The result value from the asynchronous operation.</summary>
		public NSData SignedData { get; set; }
		/// <summary>The result value from the asynchronous operation.</summary>
		public NSData Signature { get; set; }
		partial void Initialize ();
		/// <summary>Creates a new instance of this class.</summary>
		/// <param name="signedData">Result value from an asynchronous operation.</param>
		/// <param name="signature">Result value from an asynchronous operation.</param>
		public PKSignDataCompletionResult (NSData signedData, NSData signature) {
			this.SignedData = signedData;
			this.Signature = signature;
			Initialize ();
		}
	}
}
