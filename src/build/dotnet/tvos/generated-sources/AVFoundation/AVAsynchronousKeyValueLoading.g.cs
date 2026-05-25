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
using Photos;
using ModelIO;
using Network;
using SceneKit;
using Security;
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
using CoreAnimation;
using CoreFoundation;
using NetworkExtension;
using MetalPerformanceShadersGraph;
#nullable enable
namespace AVFoundation {
	#pragma warning disable CS1573
	/// <summary>This interface represents the Objective-C protocol <c>AVAsynchronousKeyValueLoading</c>.</summary>
	/// <remarks>
	///   <para>A class that implements this interface (and subclasses <see cref="NSObject" />) will be exported to Objective-C as implementing the Objective-C protocol this interface represents.</para>
	///   <para>A class may also implement members from this interface to implement members from the protocol.</para>
	/// </remarks>
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("tvos")]
	[Protocol (Name = "AVAsynchronousKeyValueLoading", WrapperType = typeof (AVAsynchronousKeyValueLoadingWrapper))]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "GetStatusOfValue", Selector = "statusOfValueForKey:error:", ReturnType = typeof (AVKeyValueStatus), ParameterType = new Type [] { typeof (string), typeof (NSError) }, ParameterByRef = new bool [] { false, true })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "LoadValuesAsynchronously", Selector = "loadValuesAsynchronouslyForKeys:completionHandler:", ParameterType = new Type [] { typeof (String[]), typeof (Action) }, ParameterByRef = new bool [] { false, false }, ParameterBlockProxy = new Type? [] { null, typeof (ObjCRuntime.Trampolines.NIDAction) })]
	public partial interface IAVAsynchronousKeyValueLoading : INativeObject, IDisposable
	{
		[global::Foundation.RequiredMember]
		[Export ("statusOfValueForKey:error:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual AVKeyValueStatus GetStatusOfValue (string forKey, out NSError error)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal unsafe static AVKeyValueStatus _GetStatusOfValue (IAVAsynchronousKeyValueLoading This, string forKey, out NSError error)
		{
			if (forKey is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (forKey));
			NativeHandle errorValue = IntPtr.Zero;
			var nsforKey = CFString.CreateNative (forKey);
			AVKeyValueStatus ret;
			ret = (AVKeyValueStatus) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSend_NativeHandle_ref_NativeHandle (This.Handle, Selector.GetHandle ("statusOfValueForKey:error:"), nsforKey, &errorValue);
			GC.KeepAlive (This);
			CFString.ReleaseNative (nsforKey);
			error = Runtime.GetNSObject<NSError> (errorValue)!;
			return ret!;
		}
		/// <param name="keys">To be added.</param><param name="handler">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[global::Foundation.RequiredMember]
		[Export ("loadValuesAsynchronouslyForKeys:completionHandler:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void LoadValuesAsynchronously (string[] keys, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDAction))]global::System.Action? handler)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="keys">To be added.</param><param name="handler">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal unsafe static void _LoadValuesAsynchronously (IAVAsynchronousKeyValueLoading This, string[] keys, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDAction))]global::System.Action? handler)
		{
			if (keys is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (keys));
			using var nsa_keys = NSArray.FromStrings (keys);
			using var block_handler = Trampolines.SDAction.CreateNullableBlock (handler);
			BlockLiteral *block_ptr_handler = null;
			if (handler is not null)
				block_ptr_handler = &block_handler;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("loadValuesAsynchronouslyForKeys:completionHandler:"), nsa_keys.Handle, (IntPtr) block_ptr_handler);
			GC.KeepAlive (This);
		}
		[DynamicDependencyAttribute ("GetStatusOfValue(System.String,Foundation.NSError@)")]
		[DynamicDependencyAttribute ("LoadValuesAsynchronously(System.String[],System.Action)")]
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.Interfaces | DynamicallyAccessedMemberTypes.PublicConstructors, typeof (AVAsynchronousKeyValueLoadingWrapper))]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static IAVAsynchronousKeyValueLoading ()
		{
			GC.KeepAlive (null);
		}
	}
	#pragma warning restore CS1573
	internal unsafe sealed class AVAsynchronousKeyValueLoadingWrapper : BaseWrapper, IAVAsynchronousKeyValueLoading {
		public AVAsynchronousKeyValueLoadingWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.PublicConstructors, typeof (AVAsynchronousKeyValueLoadingWrapper))]
		static AVAsynchronousKeyValueLoadingWrapper ()
		{
			GC.KeepAlive (null);
		}
		[Export ("statusOfValueForKey:error:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe AVKeyValueStatus GetStatusOfValue (string forKey, out NSError error)
		{
			if (forKey is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (forKey));
			NativeHandle errorValue = IntPtr.Zero;
			var nsforKey = CFString.CreateNative (forKey);
			AVKeyValueStatus ret;
			ret = (AVKeyValueStatus) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSend_NativeHandle_ref_NativeHandle (this.Handle, Selector.GetHandle ("statusOfValueForKey:error:"), nsforKey, &errorValue);
			CFString.ReleaseNative (nsforKey);
			error = Runtime.GetNSObject<NSError> (errorValue)!;
			return ret!;
		}
		/// <param name="keys">To be added.</param><param name="handler">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("loadValuesAsynchronouslyForKeys:completionHandler:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe void LoadValuesAsynchronously (string[] keys, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDAction))]global::System.Action? handler)
		{
			if (keys is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (keys));
			using var nsa_keys = NSArray.FromStrings (keys);
			using var block_handler = Trampolines.SDAction.CreateNullableBlock (handler);
			BlockLiteral *block_ptr_handler = null;
			if (handler is not null)
				block_ptr_handler = &block_handler;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("loadValuesAsynchronouslyForKeys:completionHandler:"), nsa_keys.Handle, (IntPtr) block_ptr_handler);
		}
	}
}
namespace AVFoundation {
	/// <summary>
	///   <para>This is a class that implements the interface <see cref="IAVAsynchronousKeyValueLoading" /> (for the protocol <c>AVAsynchronousKeyValueLoading</c>).</para>
	///   <para>Subclass this class to easily create a type that implements the protocol.</para>
	///   <para>An alternative is to create a subclass of <see cref="NSObject" /> and then implemented the interface <see cref="IAVAsynchronousKeyValueLoading" />.</para>
	/// </summary>
	[Protocol()]
	[Register("Microsoft_tvOS__AVFoundation_AVAsynchronousKeyValueLoading", false)]
	[Model]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("tvos")]
	public unsafe abstract partial class AVAsynchronousKeyValueLoading : NSObject, IAVAsynchronousKeyValueLoading {
		/// <summary>Creates a new <see cref="AVAsynchronousKeyValueLoading" /> with default values.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		protected AVAsynchronousKeyValueLoading () : base (NSObjectFlag.Empty)
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
		protected AVAsynchronousKeyValueLoading (NSObjectFlag t) : base (t)
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
		protected internal AVAsynchronousKeyValueLoading (NativeHandle handle) : base (handle)
		{
			IsDirectBinding = false;
		}

		[Export ("statusOfValueForKey:error:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual AVKeyValueStatus GetStatusOfValue (string forKey, out NSError error)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="keys">To be added.</param><param name="handler">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("loadValuesAsynchronouslyForKeys:completionHandler:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void LoadValuesAsynchronously (string[] keys, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDAction))]global::System.Action? handler)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
	} /* class AVAsynchronousKeyValueLoading */
}
