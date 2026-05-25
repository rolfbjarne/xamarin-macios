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
namespace Accounts {
	/// <summary>Encapsulates the Accounts database, providing access to <see cref="T:Accounts.ACAccount" /> objects.</summary><remarks><para>The Accounts database on iOS provides account information for social networks. The social networks stored in the database are:</para><list type="bullet"><item><term><see cref="P:Accounts.ACAccountType.Facebook" /></term></item><item><term><see cref="P:Accounts.ACAccountType.SinaWeibo" /></term></item><item><term><see cref="P:Accounts.ACAccountType.Twitter" /></term></item></list><para>
	/// The following example shows the basic structure of code accessing the <see cref="T:Accounts.ACAccountStore" /> object, requesting access to a specific account, and retrieving credentials: 
	/// </para><example><code lang="csharp lang-csharp"><![CDATA[
	/// var store = new ACAccountStore();
	/// var type = store.FindAccountType(ACAccountType.Twitter);
	/// 
	/// store.RequestAccess(type, null, (granted, error) => {
	/// if(granted){
	/// ]]></code></example></remarks><related type="externalDocumentation" href="https://developer.apple.com/library/ios/documentation/Accounts/Reference/ACAccountStoreClassRef/index.html">Apple documentation for <c>ACAccountStore</c></related>
	[Register("ACAccountStore", true)]
	[ObsoletedOSPlatform ("ios15.0", "Use the non-Apple SDK relating to your account type instead.")]
	[ObsoletedOSPlatform ("macos12.0", "Use the non-Apple SDK relating to your account type instead.")]
	[ObsoletedOSPlatform ("maccatalyst15.0", "Use the non-Apple SDK relating to your account type instead.")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("maccatalyst")]
	public unsafe partial class ACAccountStore : NSObject {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly NativeHandle class_ptr = Class.GetHandle ("ACAccountStore");
		/// <summary>The Objective-C class handle for this class.</summary>
		/// <value>The pointer to the Objective-C class.</value>
		/// <remarks>
		///     Each managed class mirrors an unmanaged Objective-C class.
		///     This value contains the pointer to the Objective-C class.
		///     It is similar to calling the managed <see cref="ObjCRuntime.Class.GetHandle(string)" /> or the native <see href="https://developer.apple.com/documentation/objectivec/1418952-objc_getclass">objc_getClass</see> method with the type name.
		/// </remarks>
		public override NativeHandle ClassHandle { get { return class_ptr; } }
		/// <summary>Creates a new <see cref="ACAccountStore" /> with default values.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public ACAccountStore () : base (NSObjectFlag.Empty)
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
		protected ACAccountStore (NSObjectFlag t) : base (t)
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
		protected internal ACAccountStore (NativeHandle handle) : base (handle)
		{
		}

		[Export ("accountWithIdentifier:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual ACAccount FindAccount (string identifier)
		{
			if (identifier is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (identifier));
			var nsidentifier = CFString.CreateNative (identifier);
			ACAccount? ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<ACAccount> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("accountWithIdentifier:"), nsidentifier), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<ACAccount> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle (&__objc_super__, Selector.GetHandle ("accountWithIdentifier:"), nsidentifier), false)!;
					GC.KeepAlive (this);
				}
			}
			CFString.ReleaseNative (nsidentifier);
			return ret!;
		}
		[Export ("accountTypeWithAccountTypeIdentifier:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual ACAccountType FindAccountType (string typeIdentifier)
		{
			if (typeIdentifier is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (typeIdentifier));
			var nstypeIdentifier = CFString.CreateNative (typeIdentifier);
			ACAccountType? ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<ACAccountType> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("accountTypeWithAccountTypeIdentifier:"), nstypeIdentifier), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<ACAccountType> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle (&__objc_super__, Selector.GetHandle ("accountTypeWithAccountTypeIdentifier:"), nstypeIdentifier), false)!;
					GC.KeepAlive (this);
				}
			}
			CFString.ReleaseNative (nstypeIdentifier);
			return ret!;
		}
		[Export ("accountsWithAccountType:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual ACAccount[] FindAccounts (ACAccountType accountType)
		{
			var accountType__handle__ = accountType!.GetNonNullHandle (nameof (accountType));
			ACAccount[]? ret;
			if (IsDirectBinding) {
				ret = CFArray.ArrayFromHandle<ACAccount>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("accountsWithAccountType:"), accountType__handle__), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = CFArray.ArrayFromHandle<ACAccount>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle (&__objc_super__, Selector.GetHandle ("accountsWithAccountType:"), accountType__handle__), false)!;
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (accountType);
			return ret!;
		}
		[Export ("removeAccount:withCompletionHandler:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void RemoveAccount (ACAccount account, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDACAccountStoreRemoveCompletionHandler))]ACAccountStoreRemoveCompletionHandler completionHandler)
		{
			var account__handle__ = account!.GetNonNullHandle (nameof (account));
			if (completionHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completionHandler));
			using var block_completionHandler = Trampolines.SDACAccountStoreRemoveCompletionHandler.CreateBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = &block_completionHandler;
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("removeAccount:withCompletionHandler:"), account__handle__, (IntPtr) block_ptr_completionHandler);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, Selector.GetHandle ("removeAccount:withCompletionHandler:"), account__handle__, (IntPtr) block_ptr_completionHandler);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (account);
		}
		/// <param name="account">The account to remove.</param>
		/// <summary>Removes the specified <paramref name="account" /> from the account store, and runs a completion handler after the operation is complete.</summary>
		/// <returns>
		///           <para>A task that represents the asynchronous RemoveAccount operation.   The value of the TResult parameter is a Accounts.ACAccountStoreRemoveCompletionHandler.</para>
		///         </returns>
		/// <remarks>
		///           <para copied="true">The RemoveAccountAsync method is suitable to be used with C# async by returning control to the caller with a Task representing the operation.</para>
		///           <para copied="true">To be added.</para>
		///         </remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual Task<Tuple<bool,NSError?>> RemoveAccountAsync (ACAccount account)
		{
			var tcs = new TaskCompletionSource<Tuple<bool,NSError?>> ();
			RemoveAccount(account, (success_, error_) => {
				tcs.SetResult (new Tuple<bool,NSError?> (success_, error_));
			});
			return tcs.Task;
		}
		[Export ("renewCredentialsForAccount:completion:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void RenewCredentials (ACAccount account, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity2V26))]global::System.Action<ACAccountCredentialRenewResult, NSError> completionHandler)
		{
			var account__handle__ = account!.GetNonNullHandle (nameof (account));
			if (completionHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completionHandler));
			using var block_completionHandler = Trampolines.SDActionArity2V26.CreateBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = &block_completionHandler;
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("renewCredentialsForAccount:completion:"), account__handle__, (IntPtr) block_ptr_completionHandler);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, Selector.GetHandle ("renewCredentialsForAccount:completion:"), account__handle__, (IntPtr) block_ptr_completionHandler);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (account);
		}
		/// <param name="account">The account whose credentials require renewing.</param>
		/// <summary>Attempts to renew credentials if they have become invalid.</summary>
		/// <returns>
		///           <para class="improve-task-t-return-type-description">A task that represents the asynchronous RenewCredentials operation.  The value of the TResult parameter is of type System.Action&lt;Accounts.ACAccountCredentialRenewResult,Foundation.NSError&gt;.</para>
		///         </returns>
		/// <remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual Task<ACAccountCredentialRenewResult> RenewCredentialsAsync (ACAccount account)
		{
			var tcs = new TaskCompletionSource<ACAccountCredentialRenewResult> ();
			RenewCredentials(account, (arg1_, arg2_) => {
				if (arg2_ is not null)
					tcs.SetException (new NSErrorException(arg2_));
				else
					tcs.SetResult (arg1_!);
			});
			return tcs.Task;
		}
		[Export ("requestAccessToAccountsWithType:withCompletionHandler:")]
		[UnsupportedOSPlatform ("macos")]
		[ObsoletedOSPlatform ("ios6.0", "Use 'RequestAccess (ACAccountType, AccountStoreOptions, ACRequestCompletionHandler)' instead.")]
		[SupportedOSPlatform ("maccatalyst")]
		[ObsoletedOSPlatform ("maccatalyst13.1", "Use 'RequestAccess (ACAccountType, AccountStoreOptions, ACRequestCompletionHandler)' instead.")]
		[ObsoletedOSPlatform ("macos12.0", "Use the non-Apple SDK relating to your account type instead.")]
		[SupportedOSPlatform ("ios")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void RequestAccess (ACAccountType accountType, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDACRequestCompletionHandler))]ACRequestCompletionHandler completionHandler)
		{
			var accountType__handle__ = accountType!.GetNonNullHandle (nameof (accountType));
			if (completionHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completionHandler));
			using var block_completionHandler = Trampolines.SDACRequestCompletionHandler.CreateBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = &block_completionHandler;
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("requestAccessToAccountsWithType:withCompletionHandler:"), accountType__handle__, (IntPtr) block_ptr_completionHandler);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, Selector.GetHandle ("requestAccessToAccountsWithType:withCompletionHandler:"), accountType__handle__, (IntPtr) block_ptr_completionHandler);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (accountType);
		}
		/// <param name="accountType">The type of account for which access is being requested.</param>
		/// <summary>Requests access to a type of social account.</summary>
		/// <returns>
		///           <para>A task that represents the asynchronous RequestAccess operation.   The value of the TResult parameter is a Accounts.ACRequestCompletionHandler.</para>
		///         </returns>
		/// <remarks>To be added.</remarks>
		[UnsupportedOSPlatform ("macos")]
		[ObsoletedOSPlatform ("ios6.0", "Use 'RequestAccess (ACAccountType, AccountStoreOptions, ACRequestCompletionHandler)' instead.")]
		[SupportedOSPlatform ("maccatalyst")]
		[ObsoletedOSPlatform ("maccatalyst13.1", "Use 'RequestAccess (ACAccountType, AccountStoreOptions, ACRequestCompletionHandler)' instead.")]
		[ObsoletedOSPlatform ("macos12.0", "Use the non-Apple SDK relating to your account type instead.")]
		[SupportedOSPlatform ("ios")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual Task<Tuple<bool,NSError?>> RequestAccessAsync (ACAccountType accountType)
		{
			var tcs = new TaskCompletionSource<Tuple<bool,NSError?>> ();
			RequestAccess(accountType, (granted_, error_) => {
				tcs.SetResult (new Tuple<bool,NSError?> (granted_, error_));
			});
			return tcs.Task;
		}
		[Export ("requestAccessToAccountsWithType:options:completion:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		protected unsafe virtual void RequestAccess (ACAccountType accountType, NSDictionary? options, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDACRequestCompletionHandler))]ACRequestCompletionHandler completion)
		{
			var accountType__handle__ = accountType!.GetNonNullHandle (nameof (accountType));
			var options__handle__ = options.GetHandle ();
			if (completion is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completion));
			using var block_completion = Trampolines.SDACRequestCompletionHandler.CreateBlock (completion);
			BlockLiteral *block_ptr_completion = &block_completion;
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("requestAccessToAccountsWithType:options:completion:"), accountType__handle__, options__handle__, (IntPtr) block_ptr_completion);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_NativeHandle_NativeHandle (&__objc_super__, Selector.GetHandle ("requestAccessToAccountsWithType:options:completion:"), accountType__handle__, options__handle__, (IntPtr) block_ptr_completion);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (accountType);
			GC.KeepAlive (options);
		}
		/// <param name="accountType">To be added.</param>
		/// <param name="options">To be added.</param>
		/// <summary>To be added.</summary>
		/// <returns>To be added.</returns>
		/// <remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		protected unsafe virtual Task<Tuple<bool,NSError?>> RequestAccessAsync (ACAccountType accountType, NSDictionary? options)
		{
			var tcs = new TaskCompletionSource<Tuple<bool,NSError?>> ();
			RequestAccess(accountType, options, (granted_, error_) => {
				tcs.SetResult (new Tuple<bool,NSError?> (granted_, error_));
			});
			return tcs.Task;
		}
		/// <param name="accountType">The type of account for which access is being requested.</param><param name="options">Options for accessing Facebook accounts or <see langword="null" />.</param><param name="completion">The handler to be called when the method completes.</param><summary>Requests access to a type of social account.</summary><remarks><para>Application developers can retrieve the <paramref name="accountType" /> object with the <see cref="M:Accounts.ACAccountStore.FindAccountType(System.String)" /> method.
		/// </para><example><code lang="csharp lang-csharp"><![CDATA[
		/// var objStore = new ACAccountStore();
		/// var options = new AccountStoreOptions();
		/// objStore.RequestAccess(objStore.FindAccountType(ACAccountType.Facebook), options, (granted, error) => { });
		/// ]]></code></example></remarks><altmember cref="T:Accounts.AccountStoreOptions" />
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe void RequestAccess (ACAccountType accountType, AccountStoreOptions? options, ACRequestCompletionHandler completion)
		{
			RequestAccess (accountType, options.GetDictionary (), completion);
		}
		/// <param name="accountType">To be added.</param>
		/// <param name="options">To be added.</param>
		/// <summary>To be added.</summary>
		/// <returns>To be added.</returns>
		/// <remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe Task<Tuple<bool,NSError?>> RequestAccessAsync (ACAccountType accountType, AccountStoreOptions? options)
		{
			var tcs = new TaskCompletionSource<Tuple<bool,NSError?>> ();
			RequestAccess(accountType, options, (granted_, error_) => {
				tcs.SetResult (new Tuple<bool,NSError?> (granted_, error_));
			});
			return tcs.Task;
		}
		[Export ("saveAccount:withCompletionHandler:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void SaveAccount (ACAccount account, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDACAccountStoreSaveCompletionHandler))]ACAccountStoreSaveCompletionHandler completionHandler)
		{
			var account__handle__ = account!.GetNonNullHandle (nameof (account));
			if (completionHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completionHandler));
			using var block_completionHandler = Trampolines.SDACAccountStoreSaveCompletionHandler.CreateBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = &block_completionHandler;
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("saveAccount:withCompletionHandler:"), account__handle__, (IntPtr) block_ptr_completionHandler);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, Selector.GetHandle ("saveAccount:withCompletionHandler:"), account__handle__, (IntPtr) block_ptr_completionHandler);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (account);
		}
		/// <param name="account">The account to be saved.</param>
		/// <summary>Attempts to save an <see cref="Accounts.ACAccount" /> to the Accounts database.</summary>
		/// <returns>
		///           <para>A task that represents the asynchronous SaveAccount operation.   The value of the TResult parameter is a Accounts.ACAccountStoreSaveCompletionHandler.</para>
		///         </returns>
		/// <remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual Task<Tuple<bool,NSError?>> SaveAccountAsync (ACAccount account)
		{
			var tcs = new TaskCompletionSource<Tuple<bool,NSError?>> ();
			SaveAccount(account, (success_, error_) => {
				tcs.SetResult (new Tuple<bool,NSError?> (success_, error_));
			});
			return tcs.Task;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		object? __mt_Accounts_var;
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual ACAccount[] Accounts {
			[Export ("accounts", ArgumentSemantic.Weak)]
			get {
				ACAccount[]? ret;
				if (IsDirectBinding) {
					ret = CFArray.ArrayFromHandle<ACAccount>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("accounts")), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFArray.ArrayFromHandle<ACAccount>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("accounts")), false)!;
						GC.KeepAlive (this);
					}
				}
				MarkDirty ();
				__mt_Accounts_var = ret;
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ChangeNotification;
		/// <summary>Notification constant for Change</summary>
		/// <value><see cref="NSString" /> constant, should be used as a token to <see cref="NSNotificationCenter" />.</value>
		/// <remarks>
		///   <para>
		///     This constant can be used with <see cref="NSNotificationCenter" /> to register a listener for this notification.
		///     This is an <see cref="NSString" /> instead of a string, because these values can be used as tokens in some native
		///     libraries instead of being used purely for their actual string content. The 'notification' parameter to the callback
		///     contains extra information that is specific to the notification type.
		///   </para>
		///   <para>
		///     To subscribe to this notification, developers can use the convenience <see cref="Notifications.ObserveChange(NSObject,EventHandler{NSNotificationEventArgs})" />
		///     or <see cref="Notifications.ObserveChange(EventHandler{NSNotificationEventArgs})" /> methods,
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
		/// notification = ACAccountStore.Notifications.ObserveChange ((sender, args) => {
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
		/// void Callback (object sender, ACAccountStore.NSNotificationEventArgs args)
		/// {
		///     // Access strongly typed args
		///     Console.WriteLine ("Notification: {0}", args.Notification);
		/// }
		///
		/// void Setup ()
		/// {
		///     notification = ACAccountStore.Notifications.ObserveChange (Callback);
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
		///     ACAccountStore.ChangeNotification, (notification) => { Console.WriteLine ("Received the notification Change", notification); }
		/// );
		///
		/// // Method style
		/// void Callback (NSNotification notification)
		/// {
		///     Console.WriteLine ("Received the notification Change", notification);
		/// }
		///
		/// void Setup ()
		/// {
		///     NSNotificationCenter.DefaultCenter.AddObserver (ACAccountStore.ChangeNotification, Callback);
		/// }
		/// ]]></code>
		///   </example>
		/// </remarks>
		[Field ("ACAccountStoreDidChangeNotification",  "Accounts")]
		[ObsoletedOSPlatform ("ios14.0")]
		[ObsoletedOSPlatform ("macos11.0")]
		[ObsoletedOSPlatform ("maccatalyst14.0")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("maccatalyst")]
		[Advice ("Use ACAccountStore.Notifications.ObserveChange helper method instead.")]
		public static NSString ChangeNotification {
			[ObsoletedOSPlatform ("ios14.0")]
			[ObsoletedOSPlatform ("macos11.0")]
			[ObsoletedOSPlatform ("maccatalyst14.0")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("maccatalyst")]
			get {
				if (_ChangeNotification is null)
					_ChangeNotification = Dlfcn.GetStringConstant (Libraries.Accounts.Handle, "ACAccountStoreDidChangeNotification")!;
				return _ChangeNotification;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		protected override void Dispose (bool disposing)
		{
			base.Dispose (disposing);
			if (Handle == IntPtr.Zero) {
				__mt_Accounts_var = null;
			}
		}
		//
		// Notifications
		//
		/// <summary>Notifications posted by the <see cref="global::Accounts.ACAccountStore" /> class.</summary>
		/// <remarks>
		///    <para>This class contains various helper methods that allow developers to observe events posted in the notification hub (<see cref="Foundation.NSNotificationCenter" />).</para>
		///    <para>The methods defined in this class post events that invoke the provided method or lambda with a <see cref="Foundation.NSNotificationEventArgs" /> parameter, which contains strongly typed properties for the notification arguments.</para>
		/// </remarks>
		public static partial class Notifications {
			/// <summary>Strongly typed notification for the <see cref="global::Accounts.ACAccountStore.ChangeNotification" /> constant.</summary>
			/// <param name="handler">The handler that responds to the notification when it occurs.</param>
			/// <returns>Token object that can be used to stop receiving notifications by either disposing it or passing it to <see cref="Foundation.NSNotificationCenter.RemoveObservers(System.Collections.Generic.IEnumerable{Foundation.NSObject})" />.</returns>
			/// <remarks>
			///   <para>This method can be used to subscribe to <see cref="global::Accounts.ACAccountStore.ChangeNotification" /> notifications.</para>
			///   <example>
			///   <code lang="csharp lang-csharp"><![CDATA[
			/// // Listen to all notifications posted for any object
			/// var token = ACAccountStore.Notifications.ObserveChange ((notification) => {
			///   Console.WriteLine ("Observed ChangeNotification!");
			/// };
			/// 
			/// // Stop listening for notifications
			/// token.Dispose ();
			/// ]]></code>
			///   </example>
			/// </remarks>
			public static NSObject ObserveChange (EventHandler<NSNotificationEventArgs> handler)
			{
				return NSNotificationCenter.DefaultCenter.AddObserver (ChangeNotification, notification => handler (null, new NSNotificationEventArgs (notification)));
			}
			/// <summary>Strongly typed notification for the <see cref="global::Accounts.ACAccountStore.ChangeNotification" /> constant.</summary>
			/// <param name="objectToObserve">The specific object to observe.</param>
			/// <param name="handler">The handler that responds to the notification when it occurs.</param>
			/// <returns>Token object that can be used to stop receiving notifications by either disposing it or passing it to <see cref="Foundation.NSNotificationCenter.RemoveObservers(System.Collections.Generic.IEnumerable{Foundation.NSObject})" />.</returns>
			/// <remarks>
			///   <para>This method can be used to subscribe to <see cref="global::Accounts.ACAccountStore.ChangeNotification" /> notifications.</para>
			///   <example>
			///     <code lang="csharp lang-csharp"><![CDATA[
			/// // Listen to all notifications posted for a single object
			/// var token = ACAccountStore.Notifications.ObserveChange (objectToObserve, (notification) => {
			///   Console.WriteLine ($"Observed ChangeNotification for {nameof (objectToObserve)}!");
			/// };
			/// 
			/// // Stop listening for notifications
			/// token.Dispose ();
			/// ]]></code>
			///   </example>
			/// </remarks>
			public static NSObject ObserveChange (NSObject objectToObserve, EventHandler<NSNotificationEventArgs> handler)
			{
				return NSNotificationCenter.DefaultCenter.AddObserver (ChangeNotification, notification => handler (null, new NSNotificationEventArgs (notification)), objectToObserve);
			}
		}
	} /* class ACAccountStore */
}
