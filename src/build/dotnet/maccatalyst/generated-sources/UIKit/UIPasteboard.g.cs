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
namespace UIKit {
	/// <summary>Support for the system pasteboard  for cut, copy and paste.</summary><remarks><format type="text/html"><h2>Pasteboards</h2></format><para>
	/// 	Pasteboards allow information to be shared across
	/// 	applications.  The general pasteboard (accessible via the <see cref="P:UIKit.UIPasteboard.General" /> property) is
	/// 	the system-wide pasteboard that applications use by default.
	/// 	Developers can also transfer information across their own
	/// 	applications (those that share their team ID) by creating
	/// 	their own pasteboards.
	/// </para><format type="text/html"><h2>Setting Pasteboard Data</h2></format><para>
	/// 	All operations that set the contents of the pasteboard clear any data
	/// 	that is currently stored there.
	/// </para><para>
	/// 	To set the pasteboard contents to <see cref="T:Foundation.NSString" />, <see cref="T:Foundation.NSArray" />, <see cref="T:Foundation.NSDictionary" />, <see cref="T:Foundation.NSDate" />, <see cref="T:Foundation.NSNumber" />, <see cref="T:UIKit.UIImage" /> or <see cref="T:Foundation.NSUrl" /> use
	/// 	the <see cref="M:UIKit.UIPasteboard.SetValue(Foundation.NSObject,System.String)" /> method.
	/// </para><para>
	/// 	To set the pasteboard contents to an image, use the
	/// 	<see cref="P:UIKit.UIPasteboard.Image" />.  
	/// 	property.
	/// </para><para>
	/// 	To set the pasteboard contents to a set of images, use the
	/// 	<see cref="UIKit.UIPasteboard.Images" />.  
	/// 	property.
	/// </para><para>
	/// 	To set the values to arbitrary data types, use the
	/// 	<see cref="M:UIKit.UIPasteboard.SetData(Foundation.NSData,System.String)" /> method.
	/// </para><para>
	/// 	You can use the convenience properties <see cref="P:UIKit.UIPasteboard.String" />, <see cref="P:UIKit.UIPasteboard.Strings" />, <see cref="P:UIKit.UIPasteboard.Image" />, <see cref="UIKit.UIPasteboard.Images" />, <see cref="P:UIKit.UIPasteboard.Url" />, <see cref="P:UIKit.UIPasteboard.Urls" />, <see cref="P:UIKit.UIPasteboard.Color" /> and <see cref="P:UIKit.UIPasteboard.Colors" /> to set and get
	/// 	strings, images, Urls or Colors on the pasteboard.
	/// </para><example><code lang="csharp lang-csharp"><![CDATA[
	/// //
	/// // Setting the contents of the pasteboard to "Hello World"
	/// // by specifying the UTI type for text.
	/// //
	/// var text = new NSString ("Hello world")
	/// UIPasteboard.General.SetValue (text, MonoTouch.MobileCoreServices.UTType.Text);
	/// 
	/// // 
	/// // Setting the contents of the pasteboard to "So hello"
	/// // using the convenience property:
	/// //
	/// UIPasteboard.General.String = "So hello";
	/// 	]]></code></example><format type="text/html"><h2>Pasteboard Types</h2></format><para>
	/// 	Whenever possible, you should use an UTI type to set the type
	/// 	of the information that is being stored on the pasteboard.
	/// 	You can find a list of common iOS/Mac UTI types on the <see cref="T:MobileCoreServices.UTType" /> type.
	/// 
	/// </para><para>
	/// 	UTI types are merely strings separated by dots.  For example
	/// 	the UTI type for an image is "public.image".  Apple maintains
	/// 	the "public.*" directory of UTI types.  	
	/// </para><para>
	/// 	Apple recommends that if you need to use your own data type to
	/// 	use an inverse domain to name them.   For example, "com.xamarin.t-shirt-application.sales-information". 
	/// 
	/// </para></remarks><related type="article" href="https://developer.apple.com/library/mac/documentation/FileManagement/Conceptual/understanding_utis/understand_utis_intro/understand_utis_intro.html">Introduction to Uniform Type Identifiers Overview</related><related type="article" href="https://en.wikipedia.org/wiki/Uniform_Type_Identifier">"Uniform Type Identifier" on Wikipedia</related><related type="externalDocumentation" href="https://developer.apple.com/library/ios/documentation/UIKit/Reference/UIPasteboard_Class/index.html">Apple documentation for <c>UIPasteboard</c></related>
	[Register("UIPasteboard", true)]
	[UnsupportedOSPlatform ("tvos")]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	public unsafe partial class UIPasteboard : NSObject {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly NativeHandle class_ptr = Class.GetHandle ("UIPasteboard");
		/// <summary>The Objective-C class handle for this class.</summary>
		/// <value>The pointer to the Objective-C class.</value>
		/// <remarks>
		///     Each managed class mirrors an unmanaged Objective-C class.
		///     This value contains the pointer to the Objective-C class.
		///     It is similar to calling the managed <see cref="ObjCRuntime.Class.GetHandle(string)" /> or the native <see href="https://developer.apple.com/documentation/objectivec/1418952-objc_getclass">objc_getClass</see> method with the type name.
		/// </remarks>
		public override NativeHandle ClassHandle { get { return class_ptr; } }
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
		protected UIPasteboard (NSObjectFlag t) : base (t)
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
		protected internal UIPasteboard (NativeHandle handle) : base (handle)
		{
		}

		[Export ("addItems:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void AddItems (NSDictionary[] items)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			if (items is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (items));
			using var nsa_items = NSArray.FromNSObjects (items);
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("addItems:"), nsa_items.Handle);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, Selector.GetHandle ("addItems:"), nsa_items.Handle);
					GC.KeepAlive (this);
				}
			}
		}
		[Export ("containsPasteboardTypes:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool Contains (string[] pasteboardTypes)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			if (pasteboardTypes is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (pasteboardTypes));
			using var nsa_pasteboardTypes = NSArray.FromStrings (pasteboardTypes);
			byte ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("containsPasteboardTypes:"), nsa_pasteboardTypes.Handle);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper_NativeHandle (&__objc_super__, Selector.GetHandle ("containsPasteboardTypes:"), nsa_pasteboardTypes.Handle);
					GC.KeepAlive (this);
				}
			}
			return ret != 0;
		}
		[Export ("containsPasteboardTypes:inItemSet:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool Contains (string[] pasteboardTypes, NSIndexSet? itemSet)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			if (pasteboardTypes is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (pasteboardTypes));
			var itemSet__handle__ = itemSet.GetHandle ();
			using var nsa_pasteboardTypes = NSArray.FromStrings (pasteboardTypes);
			byte ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("containsPasteboardTypes:inItemSet:"), nsa_pasteboardTypes.Handle, itemSet__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, Selector.GetHandle ("containsPasteboardTypes:inItemSet:"), nsa_pasteboardTypes.Handle, itemSet__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (itemSet);
			return ret != 0;
		}
		[Export ("dataForPasteboardType:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSData? DataForPasteboardType (string pasteboardType)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			if (pasteboardType is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (pasteboardType));
			var nspasteboardType = CFString.CreateNative (pasteboardType);
			NSData? ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<NSData> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("dataForPasteboardType:"), nspasteboardType), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<NSData> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle (&__objc_super__, Selector.GetHandle ("dataForPasteboardType:"), nspasteboardType), false)!;
					GC.KeepAlive (this);
				}
			}
			CFString.ReleaseNative (nspasteboardType);
			return ret!;
		}
		[Export ("detectPatternsForPatterns:completionHandler:")]
		[SupportedOSPlatform ("tvos14.0")]
		[SupportedOSPlatform ("ios14.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void DetectPatterns (NSSet<NSString> patterns, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity2V165))]global::System.Action<NSSet<NSString>, NSError> completionHandler)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var patterns__handle__ = patterns!.GetNonNullHandle (nameof (patterns));
			if (completionHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completionHandler));
			using var block_completionHandler = Trampolines.SDActionArity2V165.CreateBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = &block_completionHandler;
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("detectPatternsForPatterns:completionHandler:"), patterns__handle__, (IntPtr) block_ptr_completionHandler);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, Selector.GetHandle ("detectPatternsForPatterns:completionHandler:"), patterns__handle__, (IntPtr) block_ptr_completionHandler);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (patterns);
		}
		[SupportedOSPlatform ("tvos14.0")]
		[SupportedOSPlatform ("ios14.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual Task<NSSet<NSString>> DetectPatternsAsync (NSSet<NSString> patterns)
		{
			var tcs = new TaskCompletionSource<NSSet<NSString>> ();
			DetectPatterns(patterns, (arg1_, arg2_) => {
				if (arg2_ is not null)
					tcs.SetException (new NSErrorException(arg2_));
				else
					tcs.SetResult (arg1_!);
			});
			return tcs.Task;
		}
		[Export ("detectPatternsForPatterns:inItemSet:completionHandler:")]
		[SupportedOSPlatform ("tvos14.0")]
		[SupportedOSPlatform ("ios14.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void DetectPatterns (NSSet<NSString> patterns, NSIndexSet? itemSet, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity2V166))]global::System.Action<NSSet<NSString>[], NSError> completionHandler)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var patterns__handle__ = patterns!.GetNonNullHandle (nameof (patterns));
			var itemSet__handle__ = itemSet.GetHandle ();
			if (completionHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completionHandler));
			using var block_completionHandler = Trampolines.SDActionArity2V166.CreateBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = &block_completionHandler;
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("detectPatternsForPatterns:inItemSet:completionHandler:"), patterns__handle__, itemSet__handle__, (IntPtr) block_ptr_completionHandler);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_NativeHandle_NativeHandle (&__objc_super__, Selector.GetHandle ("detectPatternsForPatterns:inItemSet:completionHandler:"), patterns__handle__, itemSet__handle__, (IntPtr) block_ptr_completionHandler);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (patterns);
			GC.KeepAlive (itemSet);
		}
		[SupportedOSPlatform ("tvos14.0")]
		[SupportedOSPlatform ("ios14.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual Task<NSSet<NSString>[]> DetectPatternsAsync (NSSet<NSString> patterns, NSIndexSet? itemSet)
		{
			var tcs = new TaskCompletionSource<NSSet<NSString>[]> ();
			DetectPatterns(patterns, itemSet, (arg1_, arg2_) => {
				if (arg2_ is not null)
					tcs.SetException (new NSErrorException(arg2_));
				else
					tcs.SetResult (arg1_!);
			});
			return tcs.Task;
		}
		[Export ("detectValuesForPatterns:completionHandler:")]
		[SupportedOSPlatform ("tvos14.0")]
		[SupportedOSPlatform ("ios14.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void DetectValues (NSSet<NSString> patterns, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity2V167))]global::System.Action<NSDictionary<NSString, NSObject>, NSError> completionHandler)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var patterns__handle__ = patterns!.GetNonNullHandle (nameof (patterns));
			if (completionHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completionHandler));
			using var block_completionHandler = Trampolines.SDActionArity2V167.CreateBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = &block_completionHandler;
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("detectValuesForPatterns:completionHandler:"), patterns__handle__, (IntPtr) block_ptr_completionHandler);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, Selector.GetHandle ("detectValuesForPatterns:completionHandler:"), patterns__handle__, (IntPtr) block_ptr_completionHandler);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (patterns);
		}
		[SupportedOSPlatform ("tvos14.0")]
		[SupportedOSPlatform ("ios14.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual Task<NSDictionary<NSString, NSObject>> DetectValuesAsync (NSSet<NSString> patterns)
		{
			var tcs = new TaskCompletionSource<NSDictionary<NSString, NSObject>> ();
			DetectValues(patterns, (arg1_, arg2_) => {
				if (arg2_ is not null)
					tcs.SetException (new NSErrorException(arg2_));
				else
					tcs.SetResult (arg1_!);
			});
			return tcs.Task;
		}
		[Export ("detectValuesForPatterns:inItemSet:completionHandler:")]
		[SupportedOSPlatform ("tvos14.0")]
		[SupportedOSPlatform ("ios14.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void DetectValues (NSSet<NSString> patterns, NSIndexSet? itemSet, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity2V168))]global::System.Action<NSDictionary<NSString, NSObject>[], NSError> completionHandler)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var patterns__handle__ = patterns!.GetNonNullHandle (nameof (patterns));
			var itemSet__handle__ = itemSet.GetHandle ();
			if (completionHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completionHandler));
			using var block_completionHandler = Trampolines.SDActionArity2V168.CreateBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = &block_completionHandler;
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("detectValuesForPatterns:inItemSet:completionHandler:"), patterns__handle__, itemSet__handle__, (IntPtr) block_ptr_completionHandler);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_NativeHandle_NativeHandle (&__objc_super__, Selector.GetHandle ("detectValuesForPatterns:inItemSet:completionHandler:"), patterns__handle__, itemSet__handle__, (IntPtr) block_ptr_completionHandler);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (patterns);
			GC.KeepAlive (itemSet);
		}
		[SupportedOSPlatform ("tvos14.0")]
		[SupportedOSPlatform ("ios14.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual Task<NSDictionary<NSString, NSObject>[]> DetectValuesAsync (NSSet<NSString> patterns, NSIndexSet? itemSet)
		{
			var tcs = new TaskCompletionSource<NSDictionary<NSString, NSObject>[]> ();
			DetectValues(patterns, itemSet, (arg1_, arg2_) => {
				if (arg2_ is not null)
					tcs.SetException (new NSErrorException(arg2_));
				else
					tcs.SetResult (arg1_!);
			});
			return tcs.Task;
		}
		[Export ("pasteboardWithName:create:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static UIPasteboard FromName (string name, bool create)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			if (name is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (name));
			var nsname = CFString.CreateNative (name);
			UIPasteboard? ret;
			ret =  Runtime.GetNSObject<UIPasteboard> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_bool (class_ptr, Selector.GetHandle ("pasteboardWithName:create:"), nsname, create ? (byte) 1 : (byte) 0), false)!;
			CFString.ReleaseNative (nsname);
			return ret!;
		}
		[Export ("dataForPasteboardType:inItemSet:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSData[]? GetDataForPasteboardType (string pasteboardType, NSIndexSet? itemSet)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			if (pasteboardType is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (pasteboardType));
			var itemSet__handle__ = itemSet.GetHandle ();
			var nspasteboardType = CFString.CreateNative (pasteboardType);
			NSData[]? ret;
			if (IsDirectBinding) {
				ret = CFArray.ArrayFromHandle<NSData>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("dataForPasteboardType:inItemSet:"), nspasteboardType, itemSet__handle__), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = CFArray.ArrayFromHandle<NSData>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, Selector.GetHandle ("dataForPasteboardType:inItemSet:"), nspasteboardType, itemSet__handle__), false)!;
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (itemSet);
			CFString.ReleaseNative (nspasteboardType);
			return ret!;
		}
		[Export ("pasteboardTypesForItemSet:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSArray<NSString>[]? GetPasteBoardTypes (NSIndexSet? itemSet)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var itemSet__handle__ = itemSet.GetHandle ();
			NSArray<NSString>[]? ret;
			if (IsDirectBinding) {
				ret = CFArray.ArrayFromHandle<NSArray<NSString>>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("pasteboardTypesForItemSet:"), itemSet__handle__), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = CFArray.ArrayFromHandle<NSArray<NSString>>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle (&__objc_super__, Selector.GetHandle ("pasteboardTypesForItemSet:"), itemSet__handle__), false)!;
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (itemSet);
			return ret!;
		}
		[Export ("pasteboardWithUniqueName")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static UIPasteboard GetUnique ()
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			UIPasteboard ret;
			ret =  Runtime.GetNSObject<UIPasteboard> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (class_ptr, Selector.GetHandle ("pasteboardWithUniqueName")), false)!;
			return ret;
		}
		[Export ("valueForPasteboardType:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSObject? GetValue (string pasteboardType)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			if (pasteboardType is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (pasteboardType));
			var nspasteboardType = CFString.CreateNative (pasteboardType);
			NSObject? ret;
			if (IsDirectBinding) {
				ret = Runtime.GetNSObject (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("valueForPasteboardType:"), nspasteboardType), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = Runtime.GetNSObject (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle (&__objc_super__, Selector.GetHandle ("valueForPasteboardType:"), nspasteboardType), false)!;
					GC.KeepAlive (this);
				}
			}
			CFString.ReleaseNative (nspasteboardType);
			return ret!;
		}
		[Export ("valuesForPasteboardType:inItemSet:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSData[]? GetValuesForPasteboardType (string pasteboardType, NSIndexSet? itemSet)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			if (pasteboardType is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (pasteboardType));
			var itemSet__handle__ = itemSet.GetHandle ();
			var nspasteboardType = CFString.CreateNative (pasteboardType);
			NSData[]? ret;
			if (IsDirectBinding) {
				ret = CFArray.ArrayFromHandle<NSData>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("valuesForPasteboardType:inItemSet:"), nspasteboardType, itemSet__handle__), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = CFArray.ArrayFromHandle<NSData>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, Selector.GetHandle ("valuesForPasteboardType:inItemSet:"), nspasteboardType, itemSet__handle__), false)!;
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (itemSet);
			CFString.ReleaseNative (nspasteboardType);
			return ret!;
		}
		[Export ("itemSetWithPasteboardTypes:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSIndexSet? ItemSetWithPasteboardTypes (string[] pasteboardTypes)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			if (pasteboardTypes is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (pasteboardTypes));
			using var nsa_pasteboardTypes = NSArray.FromStrings (pasteboardTypes);
			NSIndexSet ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<NSIndexSet> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("itemSetWithPasteboardTypes:"), nsa_pasteboardTypes.Handle), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<NSIndexSet> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle (&__objc_super__, Selector.GetHandle ("itemSetWithPasteboardTypes:"), nsa_pasteboardTypes.Handle), false)!;
					GC.KeepAlive (this);
				}
			}
			return ret;
		}
		[Export ("removePasteboardWithName:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void Remove (string name)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			if (name is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (name));
			var nsname = CFString.CreateNative (name);
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (class_ptr, Selector.GetHandle ("removePasteboardWithName:"), nsname);
			CFString.ReleaseNative (nsname);
		}
		[Export ("setData:forPasteboardType:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetData (NSData data, string forPasteboardType)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var data__handle__ = data!.GetNonNullHandle (nameof (data));
			if (forPasteboardType is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (forPasteboardType));
			var nsforPasteboardType = CFString.CreateNative (forPasteboardType);
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("setData:forPasteboardType:"), data__handle__, nsforPasteboardType);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, Selector.GetHandle ("setData:forPasteboardType:"), data__handle__, nsforPasteboardType);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (data);
			CFString.ReleaseNative (nsforPasteboardType);
		}
		[Export ("setItemProviders:localOnly:expirationDate:")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetItemProviders (NSItemProvider[] itemProviders, bool localOnly, NSDate? expirationDate)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			if (itemProviders is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (itemProviders));
			var expirationDate__handle__ = expirationDate.GetHandle ();
			using var nsa_itemProviders = NSArray.FromNSObjects (itemProviders);
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_bool_NativeHandle (this.Handle, Selector.GetHandle ("setItemProviders:localOnly:expirationDate:"), nsa_itemProviders.Handle, localOnly ? (byte) 1 : (byte) 0, expirationDate__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_bool_NativeHandle (&__objc_super__, Selector.GetHandle ("setItemProviders:localOnly:expirationDate:"), nsa_itemProviders.Handle, localOnly ? (byte) 1 : (byte) 0, expirationDate__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (expirationDate);
		}
		[Export ("setItems:options:")]
		[SupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetItems (NSDictionary<NSString, NSObject>[] items, NSDictionary options)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			if (items is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (items));
			var options__handle__ = options!.GetNonNullHandle (nameof (options));
			using var nsa_items = NSArray.FromNSObjects (items);
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("setItems:options:"), nsa_items.Handle, options__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, Selector.GetHandle ("setItems:options:"), nsa_items.Handle, options__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (options);
		}
		/// <param name="items">To be added.</param><param name="pasteboardOptions">To be added.</param><summary>Adds <paramref name="items" /> to the pasteboard.</summary><remarks>To be added.</remarks>
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void SetItems (NSDictionary<NSString, NSObject>[] items, UIPasteboardOptions pasteboardOptions)
		{
			SetItems (items, pasteboardOptions.GetDictionary ()!);
		}
		[Export ("setObjects:")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetObjects (INSItemProviderWriting[] objects)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			if (objects is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (objects));
			using var nsa_objects = NSArray.FromNSObjects (objects);
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("setObjects:"), nsa_objects.Handle);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, Selector.GetHandle ("setObjects:"), nsa_objects.Handle);
					GC.KeepAlive (this);
				}
			}
		}
		[Export ("setObjects:localOnly:expirationDate:")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetObjects (INSItemProviderWriting[] objects, bool localOnly, NSDate? expirationDate)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			if (objects is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (objects));
			var expirationDate__handle__ = expirationDate.GetHandle ();
			using var nsa_objects = NSArray.FromNSObjects (objects);
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_bool_NativeHandle (this.Handle, Selector.GetHandle ("setObjects:localOnly:expirationDate:"), nsa_objects.Handle, localOnly ? (byte) 1 : (byte) 0, expirationDate__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_bool_NativeHandle (&__objc_super__, Selector.GetHandle ("setObjects:localOnly:expirationDate:"), nsa_objects.Handle, localOnly ? (byte) 1 : (byte) 0, expirationDate__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (expirationDate);
		}
		[Export ("setValue:forPasteboardType:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetValue (NSObject value, string pasteboardType)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var value__handle__ = value!.GetNonNullHandle (nameof (value));
			if (pasteboardType is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (pasteboardType));
			var nspasteboardType = CFString.CreateNative (pasteboardType);
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("setValue:forPasteboardType:"), value__handle__, nspasteboardType);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, Selector.GetHandle ("setValue:forPasteboardType:"), value__handle__, nspasteboardType);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (value);
			CFString.ReleaseNative (nspasteboardType);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual nint ChangeCount {
			[Export ("changeCount")]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				nint ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("changeCount"));
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("changeCount"));
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual UIColor? Color {
			[Export ("color", ArgumentSemantic.Copy)]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				UIColor? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<UIColor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("color")), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<UIColor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("color")), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setColor:", ArgumentSemantic.Copy)]
			set {
				global::UIKit.UIApplication.EnsureUIThread ();
				var value__handle__ = value.GetHandle ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("setColor:"), value__handle__);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, Selector.GetHandle ("setColor:"), value__handle__);
						GC.KeepAlive (this);
					}
				}
				GC.KeepAlive (value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual UIColor[]? Colors {
			[Export ("colors", ArgumentSemantic.Copy)]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				UIColor[]? ret;
				if (IsDirectBinding) {
					ret = CFArray.ArrayFromHandle<UIColor>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("colors")), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFArray.ArrayFromHandle<UIColor>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("colors")), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setColors:", ArgumentSemantic.Copy)]
			set {
				global::UIKit.UIApplication.EnsureUIThread ();
				using var nsa_value = value is null ? null : NSArray.FromNSObjects (value);
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("setColors:"), nsa_value.GetHandle ());
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, Selector.GetHandle ("setColors:"), nsa_value.GetHandle ());
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual nint Count {
			[Export ("numberOfItems")]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				nint ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("numberOfItems"));
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("numberOfItems"));
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static UIPasteboard General {
			[Export ("generalPasteboard")]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				UIPasteboard? ret;
				ret =  Runtime.GetNSObject<UIPasteboard> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (class_ptr, Selector.GetHandle ("generalPasteboard")), false)!;
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		public virtual bool HasColors {
			[Export ("hasColors")]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("hasColors"));
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("hasColors"));
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		public virtual bool HasImages {
			[Export ("hasImages")]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("hasImages"));
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("hasImages"));
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		public virtual bool HasStrings {
			[Export ("hasStrings")]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("hasStrings"));
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("hasStrings"));
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		public virtual bool HasUrls {
			[Export ("hasURLs")]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("hasURLs"));
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("hasURLs"));
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual UIImage? Image {
			[Export ("image", ArgumentSemantic.Copy)]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				UIImage? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<UIImage> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("image")), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<UIImage> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("image")), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setImage:", ArgumentSemantic.Copy)]
			set {
				global::UIKit.UIApplication.EnsureUIThread ();
				var value__handle__ = value.GetHandle ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("setImage:"), value__handle__);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, Selector.GetHandle ("setImage:"), value__handle__);
						GC.KeepAlive (this);
					}
				}
				GC.KeepAlive (value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		public virtual NSItemProvider[] ItemProviders {
			[Export ("itemProviders", ArgumentSemantic.Copy)]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				NSItemProvider[]? ret;
				if (IsDirectBinding) {
					ret = CFArray.ArrayFromHandle<NSItemProvider>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("itemProviders")), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFArray.ArrayFromHandle<NSItemProvider>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("itemProviders")), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setItemProviders:", ArgumentSemantic.Copy)]
			set {
				global::UIKit.UIApplication.EnsureUIThread ();
				if (value is null)
					ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (value));
				using var nsa_value = NSArray.FromNSObjects (value);
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("setItemProviders:"), nsa_value.Handle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, Selector.GetHandle ("setItemProviders:"), nsa_value.Handle);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSDictionary[] Items {
			[Export ("items", ArgumentSemantic.Copy)]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				NSDictionary[]? ret;
				if (IsDirectBinding) {
					ret = CFArray.ArrayFromHandle<NSDictionary>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("items")), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFArray.ArrayFromHandle<NSDictionary>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("items")), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setItems:", ArgumentSemantic.Copy)]
			set {
				global::UIKit.UIApplication.EnsureUIThread ();
				if (value is null)
					ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (value));
				using var nsa_value = NSArray.FromNSObjects (value);
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("setItems:"), nsa_value.Handle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, Selector.GetHandle ("setItems:"), nsa_value.Handle);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string Name {
			[Export ("name")]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				string ret;
				if (IsDirectBinding) {
					ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("name")), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("name")), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool Persistent {
			[Export ("isPersistent")]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("isPersistent"));
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("isPersistent"));
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
			[Export ("setPersistent:")]
			[ObsoletedOSPlatform ("ios10.0")]
			[ObsoletedOSPlatform ("maccatalyst13.1")]
			[UnsupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("maccatalyst")]
			set {
				global::UIKit.UIApplication.EnsureUIThread ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("setPersistent:"), value ? (byte) 1 : (byte) 0);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (&__objc_super__, Selector.GetHandle ("setPersistent:"), value ? (byte) 1 : (byte) 0);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string? String {
			[Export ("string", ArgumentSemantic.Copy)]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				string ret;
				if (IsDirectBinding) {
					ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("string")), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("string")), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[Export ("setString:", ArgumentSemantic.Copy)]
			set {
				global::UIKit.UIApplication.EnsureUIThread ();
				var nsvalue = CFString.CreateNative (value);
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("setString:"), nsvalue);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, Selector.GetHandle ("setString:"), nsvalue);
						GC.KeepAlive (this);
					}
				}
				CFString.ReleaseNative (nsvalue);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string[]? Strings {
			[Export ("strings", ArgumentSemantic.Copy)]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				string[] ret;
				if (IsDirectBinding) {
					ret = CFArray.StringArrayFromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("strings")), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFArray.StringArrayFromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("strings")), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[Export ("setStrings:", ArgumentSemantic.Copy)]
			set {
				global::UIKit.UIApplication.EnsureUIThread ();
				using var nsa_value = NSArray.FromNullableStrings (value);
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("setStrings:"), nsa_value.GetHandle ());
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, Selector.GetHandle ("setStrings:"), nsa_value.GetHandle ());
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string[] Types {
			[Export ("pasteboardTypes")]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				string[] ret;
				if (IsDirectBinding) {
					ret = CFArray.StringArrayFromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("pasteboardTypes")), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFArray.StringArrayFromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("pasteboardTypes")), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSUrl? Url {
			[Export ("URL", ArgumentSemantic.Copy)]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				NSUrl? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSUrl> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("URL")), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<NSUrl> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("URL")), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setURL:", ArgumentSemantic.Copy)]
			set {
				global::UIKit.UIApplication.EnsureUIThread ();
				var value__handle__ = value.GetHandle ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("setURL:"), value__handle__);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, Selector.GetHandle ("setURL:"), value__handle__);
						GC.KeepAlive (this);
					}
				}
				GC.KeepAlive (value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSUrl[]? Urls {
			[Export ("URLs", ArgumentSemantic.Copy)]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				NSUrl[]? ret;
				if (IsDirectBinding) {
					ret = CFArray.ArrayFromHandle<NSUrl>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("URLs")), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFArray.ArrayFromHandle<NSUrl>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("URLs")), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setURLs:", ArgumentSemantic.Copy)]
			set {
				global::UIKit.UIApplication.EnsureUIThread ();
				using var nsa_value = value is null ? null : NSArray.FromNSObjects (value);
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("setURLs:"), nsa_value.GetHandle ());
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, Selector.GetHandle ("setURLs:"), nsa_value.GetHandle ());
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _Automatic;
		/// <summary>Key indicating that pasteboard types should have their Uniform Type Identifiers determined automatically.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("UIPasteboardTypeAutomatic",  "UIKit")]
		[SupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios")]
		public static NSString Automatic {
			[SupportedOSPlatform ("maccatalyst")]
			[UnsupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("ios")]
			get {
				if (_Automatic is null)
					_Automatic = Dlfcn.GetStringConstant (Libraries.UIKit.Handle, "UIPasteboardTypeAutomatic")!;
				return _Automatic;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ChangedNotification;
		/// <summary>Notification constant for Changed</summary>
		/// <value><see cref="NSString" /> constant, should be used as a token to <see cref="NSNotificationCenter" />.</value>
		/// <remarks>
		///   <para>
		///     This constant can be used with <see cref="NSNotificationCenter" /> to register a listener for this notification.
		///     This is an <see cref="NSString" /> instead of a string, because these values can be used as tokens in some native
		///     libraries instead of being used purely for their actual string content. The 'notification' parameter to the callback
		///     contains extra information that is specific to the notification type.
		///   </para>
		///   <para>
		///     To subscribe to this notification, developers can use the convenience <see cref="Notifications.ObserveChanged(NSObject,EventHandler{UIPasteboardChangeEventArgs})" />
		///     or <see cref="Notifications.ObserveChanged(EventHandler{UIPasteboardChangeEventArgs})" /> methods,
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
		/// notification = UIPasteboard.Notifications.ObserveChanged ((sender, args) => {
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
		/// void Callback (object sender, UIPasteboard.UIPasteboardChangeEventArgs args)
		/// {
		///     // Access strongly typed args
		///     Console.WriteLine ("Notification: {0}", args.Notification);
		/// }
		///
		/// void Setup ()
		/// {
		///     notification = UIPasteboard.Notifications.ObserveChanged (Callback);
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
		///     UIPasteboard.ChangedNotification, (notification) => { Console.WriteLine ("Received the notification Changed", notification); }
		/// );
		///
		/// // Method style
		/// void Callback (NSNotification notification)
		/// {
		///     Console.WriteLine ("Received the notification Changed", notification);
		/// }
		///
		/// void Setup ()
		/// {
		///     NSNotificationCenter.DefaultCenter.AddObserver (UIPasteboard.ChangedNotification, Callback);
		/// }
		/// ]]></code>
		///   </example>
		/// </remarks>
		[Field ("UIPasteboardChangedNotification",  "UIKit")]
		[Advice ("Use UIPasteboard.Notifications.ObserveChanged helper method instead.")]
		public static NSString ChangedNotification {
			get {
				if (_ChangedNotification is null)
					_ChangedNotification = Dlfcn.GetStringConstant (Libraries.UIKit.Handle, "UIPasteboardChangedNotification")!;
				return _ChangedNotification;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ChangedTypesAddedKey;
		/// <summary>Represents the value associated with the constant UIPasteboardChangedTypesAddedKey</summary><value></value><remarks>To be added.</remarks>
		[Field ("UIPasteboardChangedTypesAddedKey",  "UIKit")]
		public static NSString ChangedTypesAddedKey {
			get {
				if (_ChangedTypesAddedKey is null)
					_ChangedTypesAddedKey = Dlfcn.GetStringConstant (Libraries.UIKit.Handle, "UIPasteboardChangedTypesAddedKey")!;
				return _ChangedTypesAddedKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ChangedTypesRemovedKey;
		/// <summary>Represents the value associated with the constant UIPasteboardChangedTypesRemovedKey</summary><value></value><remarks>To be added.</remarks>
		[Field ("UIPasteboardChangedTypesRemovedKey",  "UIKit")]
		public static NSString ChangedTypesRemovedKey {
			get {
				if (_ChangedTypesRemovedKey is null)
					_ChangedTypesRemovedKey = Dlfcn.GetStringConstant (Libraries.UIKit.Handle, "UIPasteboardChangedTypesRemovedKey")!;
				return _ChangedTypesRemovedKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _RemovedNotification;
		/// <summary>Notification constant for Removed</summary>
		/// <value><see cref="NSString" /> constant, should be used as a token to <see cref="NSNotificationCenter" />.</value>
		/// <remarks>
		///   <para>
		///     This constant can be used with <see cref="NSNotificationCenter" /> to register a listener for this notification.
		///     This is an <see cref="NSString" /> instead of a string, because these values can be used as tokens in some native
		///     libraries instead of being used purely for their actual string content. The 'notification' parameter to the callback
		///     contains extra information that is specific to the notification type.
		///   </para>
		///   <para>
		///     To subscribe to this notification, developers can use the convenience <see cref="Notifications.ObserveRemoved(NSObject,EventHandler{UIPasteboardChangeEventArgs})" />
		///     or <see cref="Notifications.ObserveRemoved(EventHandler{UIPasteboardChangeEventArgs})" /> methods,
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
		/// notification = UIPasteboard.Notifications.ObserveRemoved ((sender, args) => {
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
		/// void Callback (object sender, UIPasteboard.UIPasteboardChangeEventArgs args)
		/// {
		///     // Access strongly typed args
		///     Console.WriteLine ("Notification: {0}", args.Notification);
		/// }
		///
		/// void Setup ()
		/// {
		///     notification = UIPasteboard.Notifications.ObserveRemoved (Callback);
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
		///     UIPasteboard.RemovedNotification, (notification) => { Console.WriteLine ("Received the notification Removed", notification); }
		/// );
		///
		/// // Method style
		/// void Callback (NSNotification notification)
		/// {
		///     Console.WriteLine ("Received the notification Removed", notification);
		/// }
		///
		/// void Setup ()
		/// {
		///     NSNotificationCenter.DefaultCenter.AddObserver (UIPasteboard.RemovedNotification, Callback);
		/// }
		/// ]]></code>
		///   </example>
		/// </remarks>
		[Field ("UIPasteboardRemovedNotification",  "UIKit")]
		[Advice ("Use UIPasteboard.Notifications.ObserveRemoved helper method instead.")]
		public static NSString RemovedNotification {
			get {
				if (_RemovedNotification is null)
					_RemovedNotification = Dlfcn.GetStringConstant (Libraries.UIKit.Handle, "UIPasteboardRemovedNotification")!;
				return _RemovedNotification;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSArray? _TypeListColor;
		/// <summary>Represents the value associated with the constant UIPasteboardTypeListColor</summary><value></value><remarks>To be added.</remarks>
		[Field ("UIPasteboardTypeListColor",  "UIKit")]
		public static NSArray TypeListColor {
			get {
				if (_TypeListColor is null)
					_TypeListColor = Runtime.GetNSObject<NSArray> (Dlfcn.GetIndirect (Libraries.UIKit.Handle, "UIPasteboardTypeListColor"))!;
				return _TypeListColor;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSArray? _TypeListImage;
		/// <summary>Represents the value associated with the constant UIPasteboardTypeListImage</summary><value></value><remarks>To be added.</remarks>
		[Field ("UIPasteboardTypeListImage",  "UIKit")]
		public static NSArray TypeListImage {
			get {
				if (_TypeListImage is null)
					_TypeListImage = Runtime.GetNSObject<NSArray> (Dlfcn.GetIndirect (Libraries.UIKit.Handle, "UIPasteboardTypeListImage"))!;
				return _TypeListImage;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSArray? _TypeListString;
		/// <summary>Represents the value associated with the constant UIPasteboardTypeListString</summary><value></value><remarks>To be added.</remarks>
		[Field ("UIPasteboardTypeListString",  "UIKit")]
		public static NSArray TypeListString {
			get {
				if (_TypeListString is null)
					_TypeListString = Runtime.GetNSObject<NSArray> (Dlfcn.GetIndirect (Libraries.UIKit.Handle, "UIPasteboardTypeListString"))!;
				return _TypeListString;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSArray? _TypeListURL;
		/// <summary>Represents the value associated with the constant UIPasteboardTypeListURL</summary><value></value><remarks>To be added.</remarks>
		[Field ("UIPasteboardTypeListURL",  "UIKit")]
		public static NSArray TypeListURL {
			get {
				if (_TypeListURL is null)
					_TypeListURL = Runtime.GetNSObject<NSArray> (Dlfcn.GetIndirect (Libraries.UIKit.Handle, "UIPasteboardTypeListURL"))!;
				return _TypeListURL;
			}
		}
		//
		// Notifications
		//
		/// <summary>Notifications posted by the <see cref="global::UIKit.UIPasteboard" /> class.</summary>
		/// <remarks>
		///    <para>This class contains various helper methods that allow developers to observe events posted in the notification hub (<see cref="Foundation.NSNotificationCenter" />).</para>
		///    <para>The methods defined in this class post events that invoke the provided method or lambda with a <see cref="Foundation.NSNotificationEventArgs" /> parameter, which contains strongly typed properties for the notification arguments.</para>
		/// </remarks>
		public static partial class Notifications {
			/// <summary>Strongly typed notification for the <see cref="global::UIKit.UIPasteboard.ChangedNotification" /> constant.</summary>
			/// <param name="handler">The handler that responds to the notification when it occurs.</param>
			/// <returns>Token object that can be used to stop receiving notifications by either disposing it or passing it to <see cref="Foundation.NSNotificationCenter.RemoveObservers(System.Collections.Generic.IEnumerable{Foundation.NSObject})" />.</returns>
			/// <remarks>
			///   <para>This method can be used to subscribe to <see cref="global::UIKit.UIPasteboard.ChangedNotification" /> notifications.</para>
			///   <example>
			///   <code lang="csharp lang-csharp"><![CDATA[
			/// // Listen to all notifications posted for any object
			/// var token = UIPasteboard.Notifications.ObserveChanged ((notification) => {
			///   Console.WriteLine ("Observed ChangedNotification!");
			/// };
			/// 
			/// // Stop listening for notifications
			/// token.Dispose ();
			/// ]]></code>
			///   </example>
			/// </remarks>
			public static NSObject ObserveChanged (EventHandler<UIKit.UIPasteboardChangeEventArgs> handler)
			{
				return NSNotificationCenter.DefaultCenter.AddObserver (ChangedNotification, notification => handler (null, new UIKit.UIPasteboardChangeEventArgs (notification)));
			}
			/// <summary>Strongly typed notification for the <see cref="global::UIKit.UIPasteboard.ChangedNotification" /> constant.</summary>
			/// <param name="objectToObserve">The specific object to observe.</param>
			/// <param name="handler">The handler that responds to the notification when it occurs.</param>
			/// <returns>Token object that can be used to stop receiving notifications by either disposing it or passing it to <see cref="Foundation.NSNotificationCenter.RemoveObservers(System.Collections.Generic.IEnumerable{Foundation.NSObject})" />.</returns>
			/// <remarks>
			///   <para>This method can be used to subscribe to <see cref="global::UIKit.UIPasteboard.ChangedNotification" /> notifications.</para>
			///   <example>
			///     <code lang="csharp lang-csharp"><![CDATA[
			/// // Listen to all notifications posted for a single object
			/// var token = UIPasteboard.Notifications.ObserveChanged (objectToObserve, (notification) => {
			///   Console.WriteLine ($"Observed ChangedNotification for {nameof (objectToObserve)}!");
			/// };
			/// 
			/// // Stop listening for notifications
			/// token.Dispose ();
			/// ]]></code>
			///   </example>
			/// </remarks>
			public static NSObject ObserveChanged (NSObject objectToObserve, EventHandler<UIKit.UIPasteboardChangeEventArgs> handler)
			{
				return NSNotificationCenter.DefaultCenter.AddObserver (ChangedNotification, notification => handler (null, new UIKit.UIPasteboardChangeEventArgs (notification)), objectToObserve);
			}
			/// <summary>Strongly typed notification for the <see cref="global::UIKit.UIPasteboard.RemovedNotification" /> constant.</summary>
			/// <param name="handler">The handler that responds to the notification when it occurs.</param>
			/// <returns>Token object that can be used to stop receiving notifications by either disposing it or passing it to <see cref="Foundation.NSNotificationCenter.RemoveObservers(System.Collections.Generic.IEnumerable{Foundation.NSObject})" />.</returns>
			/// <remarks>
			///   <para>This method can be used to subscribe to <see cref="global::UIKit.UIPasteboard.RemovedNotification" /> notifications.</para>
			///   <example>
			///   <code lang="csharp lang-csharp"><![CDATA[
			/// // Listen to all notifications posted for any object
			/// var token = UIPasteboard.Notifications.ObserveRemoved ((notification) => {
			///   Console.WriteLine ("Observed RemovedNotification!");
			/// };
			/// 
			/// // Stop listening for notifications
			/// token.Dispose ();
			/// ]]></code>
			///   </example>
			/// </remarks>
			public static NSObject ObserveRemoved (EventHandler<UIKit.UIPasteboardChangeEventArgs> handler)
			{
				return NSNotificationCenter.DefaultCenter.AddObserver (RemovedNotification, notification => handler (null, new UIKit.UIPasteboardChangeEventArgs (notification)));
			}
			/// <summary>Strongly typed notification for the <see cref="global::UIKit.UIPasteboard.RemovedNotification" /> constant.</summary>
			/// <param name="objectToObserve">The specific object to observe.</param>
			/// <param name="handler">The handler that responds to the notification when it occurs.</param>
			/// <returns>Token object that can be used to stop receiving notifications by either disposing it or passing it to <see cref="Foundation.NSNotificationCenter.RemoveObservers(System.Collections.Generic.IEnumerable{Foundation.NSObject})" />.</returns>
			/// <remarks>
			///   <para>This method can be used to subscribe to <see cref="global::UIKit.UIPasteboard.RemovedNotification" /> notifications.</para>
			///   <example>
			///     <code lang="csharp lang-csharp"><![CDATA[
			/// // Listen to all notifications posted for a single object
			/// var token = UIPasteboard.Notifications.ObserveRemoved (objectToObserve, (notification) => {
			///   Console.WriteLine ($"Observed RemovedNotification for {nameof (objectToObserve)}!");
			/// };
			/// 
			/// // Stop listening for notifications
			/// token.Dispose ();
			/// ]]></code>
			///   </example>
			/// </remarks>
			public static NSObject ObserveRemoved (NSObject objectToObserve, EventHandler<UIKit.UIPasteboardChangeEventArgs> handler)
			{
				return NSNotificationCenter.DefaultCenter.AddObserver (RemovedNotification, notification => handler (null, new UIKit.UIPasteboardChangeEventArgs (notification)), objectToObserve);
			}
		}
	} /* class UIPasteboard */
}
