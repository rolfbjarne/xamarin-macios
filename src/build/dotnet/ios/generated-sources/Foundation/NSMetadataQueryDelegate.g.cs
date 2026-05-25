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
namespace Foundation {
	#pragma warning disable CS1573
	/// <summary>Defines optional methods relating to the lifecycle of <see cref="T:Foundation.NSMetadataQuery" />s.</summary><remarks>To be added.</remarks><related type="externalDocumentation" href="https://developer.apple.com/library/ios/documentation/Cocoa/Reference/NSMetadataQueryDelegate_Protocol/index.html">Apple documentation for <c>NSMetadataQueryDelegate</c></related>
	[Protocol (Name = "NSMetadataQueryDelegate", WrapperType = typeof (NSMetadataQueryDelegateWrapper))]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "ReplacementObjectForResultObject", Selector = "metadataQuery:replacementObjectForResultObject:", ReturnType = typeof (NSObject), ParameterType = new Type [] { typeof (NSMetadataQuery), typeof (NSMetadataItem) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "ReplacementValueForAttributevalue", Selector = "metadataQuery:replacementValueForAttribute:value:", ReturnType = typeof (NSObject), ParameterType = new Type [] { typeof (NSMetadataQuery), typeof (string), typeof (NSObject) }, ParameterByRef = new bool [] { false, false, false })]
	public partial interface INSMetadataQueryDelegate : INativeObject, IDisposable
	{
		/// <param name="query">To be added.</param><param name="result">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("metadataQuery:replacementObjectForResultObject:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSObject ReplacementObjectForResultObject (NSMetadataQuery query, NSMetadataItem result)
		{
			return _ReplacementObjectForResultObject (this, query, result);
		}
		/// <param name="query">To be added.</param><param name="result">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static NSObject _ReplacementObjectForResultObject (INSMetadataQueryDelegate This, NSMetadataQuery query, NSMetadataItem result)
		{
			var query__handle__ = query!.GetNonNullHandle (nameof (query));
			var result__handle__ = result!.GetNonNullHandle (nameof (result));
			NSObject? ret;
			ret = Runtime.GetNSObject (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("metadataQuery:replacementObjectForResultObject:"), query__handle__, result__handle__), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (query);
			GC.KeepAlive (result);
			return ret!;
		}
		/// <param name="query">To be added.</param><param name="attributeName">To be added.</param><param name="value">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("metadataQuery:replacementValueForAttribute:value:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSObject ReplacementValueForAttributevalue (NSMetadataQuery query, string attributeName, NSObject value)
		{
			return _ReplacementValueForAttributevalue (this, query, attributeName, value);
		}
		/// <param name="query">To be added.</param><param name="attributeName">To be added.</param><param name="value">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static NSObject _ReplacementValueForAttributevalue (INSMetadataQueryDelegate This, NSMetadataQuery query, string attributeName, NSObject value)
		{
			var query__handle__ = query!.GetNonNullHandle (nameof (query));
			if (attributeName is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (attributeName));
			var value__handle__ = value!.GetNonNullHandle (nameof (value));
			var nsattributeName = CFString.CreateNative (attributeName);
			NSObject? ret;
			ret = Runtime.GetNSObject (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("metadataQuery:replacementValueForAttribute:value:"), query__handle__, nsattributeName, value__handle__), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (query);
			GC.KeepAlive (value);
			CFString.ReleaseNative (nsattributeName);
			return ret!;
		}
		[DynamicDependencyAttribute ("ReplacementObjectForResultObject(Foundation.NSMetadataQuery,Foundation.NSMetadataItem)")]
		[DynamicDependencyAttribute ("ReplacementValueForAttributevalue(Foundation.NSMetadataQuery,System.String,Foundation.NSObject)")]
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.Interfaces | DynamicallyAccessedMemberTypes.PublicConstructors, typeof (NSMetadataQueryDelegateWrapper))]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static INSMetadataQueryDelegate ()
		{
			GC.KeepAlive (null);
		}
	}
	#pragma warning restore CS1573
	#pragma warning disable CS1573
	/// <summary>Extension methods to the <see cref="INSMetadataQueryDelegate" /> interface to support all the methods from the NSMetadataQueryDelegate protocol.</summary>
	/// <remarks>
	///   <para>The extension methods for <see cref="INSMetadataQueryDelegate" /> interface allow developers to treat instances of the interface as having all the optional methods of the original NSMetadataQueryDelegate protocol. Since the interface only contains the required members, these extension methods allow developers to call the optional members of the protocol.</para>
	/// </remarks>
	public unsafe static partial class NSMetadataQueryDelegate_Extensions {
		/// <param name="query">To be added.</param><param name="result">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSObject ReplacementObjectForResultObject (this INSMetadataQueryDelegate This, NSMetadataQuery query, NSMetadataItem result)
		{
			var query__handle__ = query!.GetNonNullHandle (nameof (query));
			var result__handle__ = result!.GetNonNullHandle (nameof (result));
			NSObject? ret;
			ret = Runtime.GetNSObject (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("metadataQuery:replacementObjectForResultObject:"), query__handle__, result__handle__), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (query);
			GC.KeepAlive (result);
			return ret!;
		}
		/// <param name="query">To be added.</param><param name="attributeName">To be added.</param><param name="value">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSObject ReplacementValueForAttributevalue (this INSMetadataQueryDelegate This, NSMetadataQuery query, string attributeName, NSObject value)
		{
			var query__handle__ = query!.GetNonNullHandle (nameof (query));
			if (attributeName is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (attributeName));
			var value__handle__ = value!.GetNonNullHandle (nameof (value));
			var nsattributeName = CFString.CreateNative (attributeName);
			NSObject? ret;
			ret = Runtime.GetNSObject (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("metadataQuery:replacementValueForAttribute:value:"), query__handle__, nsattributeName, value__handle__), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (query);
			GC.KeepAlive (value);
			CFString.ReleaseNative (nsattributeName);
			return ret!;
		}
	}
	#pragma warning restore CS1573
	internal unsafe sealed class NSMetadataQueryDelegateWrapper : BaseWrapper, INSMetadataQueryDelegate {
		public NSMetadataQueryDelegateWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.PublicConstructors, typeof (NSMetadataQueryDelegateWrapper))]
		static NSMetadataQueryDelegateWrapper ()
		{
			GC.KeepAlive (null);
		}
	}
}
namespace Foundation {
	/// <summary>Defines optional methods relating to the lifecycle of <see cref="T:Foundation.NSMetadataQuery" />s.</summary><remarks>To be added.</remarks><related type="externalDocumentation" href="https://developer.apple.com/library/ios/documentation/Cocoa/Reference/NSMetadataQueryDelegate_Protocol/index.html">Apple documentation for <c>NSMetadataQueryDelegate</c></related>
	[Protocol()]
	[Register("Microsoft_iOS__Foundation_NSMetadataQueryDelegate", false)]
	[Model]
	public unsafe partial class NSMetadataQueryDelegate : NSObject, INSMetadataQueryDelegate {
		/// <summary>Creates a new <see cref="NSMetadataQueryDelegate" /> with default values.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public NSMetadataQueryDelegate () : base (NSObjectFlag.Empty)
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
		protected NSMetadataQueryDelegate (NSObjectFlag t) : base (t)
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
		protected internal NSMetadataQueryDelegate (NativeHandle handle) : base (handle)
		{
			IsDirectBinding = false;
		}

		/// <param name="query">To be added.</param><param name="result">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("metadataQuery:replacementObjectForResultObject:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSObject ReplacementObjectForResultObject (NSMetadataQuery query, NSMetadataItem result)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="query">To be added.</param><param name="attributeName">To be added.</param><param name="value">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("metadataQuery:replacementValueForAttribute:value:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSObject ReplacementValueForAttributevalue (NSMetadataQuery query, string attributeName, NSObject value)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
	} /* class NSMetadataQueryDelegate */
}
