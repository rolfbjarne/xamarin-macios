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
namespace CloudKit {
	#pragma warning disable CS1573
	/// <summary>This interface represents the Objective-C protocol <c>CKSyncEngineDelegate</c>.</summary>
	/// <remarks>
	///   <para>A class that implements this interface (and subclasses <see cref="NSObject" />) will be exported to Objective-C as implementing the Objective-C protocol this interface represents.</para>
	///   <para>A class may also implement members from this interface to implement members from the protocol.</para>
	/// </remarks>
	[SupportedOSPlatform ("tvos17.0")]
	[SupportedOSPlatform ("macos14.0")]
	[SupportedOSPlatform ("ios17.0")]
	[SupportedOSPlatform ("maccatalyst17.0")]
	[Protocol (Name = "CKSyncEngineDelegate", WrapperType = typeof (CKSyncEngineDelegateWrapper))]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "SyncEngine", Selector = "syncEngine:handleEvent:", ParameterType = new Type [] { typeof (CloudKit.CKSyncEngine), typeof (CloudKit.CKSyncEngineEvent) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "SyncEngine", Selector = "syncEngine:nextRecordZoneChangeBatchForContext:", ReturnType = typeof (CloudKit.CKSyncEngineRecordZoneChangeBatch), ParameterType = new Type [] { typeof (CloudKit.CKSyncEngine), typeof (CloudKit.CKSyncEngineSendChangesContext) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "SyncEngine", Selector = "syncEngine:nextFetchChangesOptionsForContext:", ReturnType = typeof (CloudKit.CKSyncEngineFetchChangesOptions), ParameterType = new Type [] { typeof (CloudKit.CKSyncEngine), typeof (CloudKit.CKSyncEngineFetchChangesContext) }, ParameterByRef = new bool [] { false, false })]
	public partial interface ICKSyncEngineDelegate : INativeObject, IDisposable
	{
		[global::Foundation.RequiredMember]
		[Export ("syncEngine:handleEvent:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SyncEngine (CKSyncEngine syncEngine, CKSyncEngineEvent @event)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SyncEngine (ICKSyncEngineDelegate This, CKSyncEngine syncEngine, CKSyncEngineEvent @event)
		{
			var syncEngine__handle__ = syncEngine!.GetNonNullHandle (nameof (syncEngine));
			var @event__handle__ = @event!.GetNonNullHandle (nameof (@event));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("syncEngine:handleEvent:"), syncEngine__handle__, @event__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (syncEngine);
			GC.KeepAlive (@event);
		}
		[global::Foundation.RequiredMember]
		[Export ("syncEngine:nextRecordZoneChangeBatchForContext:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual CKSyncEngineRecordZoneChangeBatch? SyncEngine (CKSyncEngine syncEngine, CKSyncEngineSendChangesContext context)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static CKSyncEngineRecordZoneChangeBatch? _SyncEngine (ICKSyncEngineDelegate This, CKSyncEngine syncEngine, CKSyncEngineSendChangesContext context)
		{
			var syncEngine__handle__ = syncEngine!.GetNonNullHandle (nameof (syncEngine));
			var context__handle__ = context!.GetNonNullHandle (nameof (context));
			CKSyncEngineRecordZoneChangeBatch? ret;
			ret =  Runtime.GetNSObject<CKSyncEngineRecordZoneChangeBatch> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("syncEngine:nextRecordZoneChangeBatchForContext:"), syncEngine__handle__, context__handle__), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (syncEngine);
			GC.KeepAlive (context);
			return ret!;
		}
		[global::Foundation.OptionalMember]
		[Export ("syncEngine:nextFetchChangesOptionsForContext:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual CKSyncEngineFetchChangesOptions SyncEngine (CKSyncEngine syncEngine, CKSyncEngineFetchChangesContext context)
		{
			return _SyncEngine (this, syncEngine, context);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static CKSyncEngineFetchChangesOptions _SyncEngine (ICKSyncEngineDelegate This, CKSyncEngine syncEngine, CKSyncEngineFetchChangesContext context)
		{
			var syncEngine__handle__ = syncEngine!.GetNonNullHandle (nameof (syncEngine));
			var context__handle__ = context!.GetNonNullHandle (nameof (context));
			CKSyncEngineFetchChangesOptions? ret;
			ret =  Runtime.GetNSObject<CKSyncEngineFetchChangesOptions> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("syncEngine:nextFetchChangesOptionsForContext:"), syncEngine__handle__, context__handle__), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (syncEngine);
			GC.KeepAlive (context);
			return ret!;
		}
		[DynamicDependencyAttribute ("SyncEngine(CloudKit.CKSyncEngine,CloudKit.CKSyncEngineEvent)")]
		[DynamicDependencyAttribute ("SyncEngine(CloudKit.CKSyncEngine,CloudKit.CKSyncEngineFetchChangesContext)")]
		[DynamicDependencyAttribute ("SyncEngine(CloudKit.CKSyncEngine,CloudKit.CKSyncEngineSendChangesContext)")]
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.Interfaces | DynamicallyAccessedMemberTypes.PublicConstructors, typeof (CKSyncEngineDelegateWrapper))]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static ICKSyncEngineDelegate ()
		{
			GC.KeepAlive (null);
		}
	}
	#pragma warning restore CS1573
	#pragma warning disable CS1573
	/// <summary>Extension methods to the <see cref="ICKSyncEngineDelegate" /> interface to support all the methods from the CKSyncEngineDelegate protocol.</summary>
	/// <remarks>
	///   <para>The extension methods for <see cref="ICKSyncEngineDelegate" /> interface allow developers to treat instances of the interface as having all the optional methods of the original CKSyncEngineDelegate protocol. Since the interface only contains the required members, these extension methods allow developers to call the optional members of the protocol.</para>
	/// </remarks>
	public unsafe static partial class CKSyncEngineDelegate_Extensions {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static CKSyncEngineFetchChangesOptions SyncEngine (this ICKSyncEngineDelegate This, CKSyncEngine syncEngine, CKSyncEngineFetchChangesContext context)
		{
			var syncEngine__handle__ = syncEngine!.GetNonNullHandle (nameof (syncEngine));
			var context__handle__ = context!.GetNonNullHandle (nameof (context));
			CKSyncEngineFetchChangesOptions? ret;
			ret =  Runtime.GetNSObject<CKSyncEngineFetchChangesOptions> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("syncEngine:nextFetchChangesOptionsForContext:"), syncEngine__handle__, context__handle__), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (syncEngine);
			GC.KeepAlive (context);
			return ret!;
		}
	}
	#pragma warning restore CS1573
	internal unsafe sealed class CKSyncEngineDelegateWrapper : BaseWrapper, ICKSyncEngineDelegate {
		public CKSyncEngineDelegateWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.PublicConstructors, typeof (CKSyncEngineDelegateWrapper))]
		static CKSyncEngineDelegateWrapper ()
		{
			GC.KeepAlive (null);
		}
		[Export ("syncEngine:handleEvent:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void SyncEngine (CKSyncEngine syncEngine, CKSyncEngineEvent @event)
		{
			var syncEngine__handle__ = syncEngine!.GetNonNullHandle (nameof (syncEngine));
			var @event__handle__ = @event!.GetNonNullHandle (nameof (@event));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("syncEngine:handleEvent:"), syncEngine__handle__, @event__handle__);
			GC.KeepAlive (syncEngine);
			GC.KeepAlive (@event);
		}
		[Export ("syncEngine:nextRecordZoneChangeBatchForContext:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public CKSyncEngineRecordZoneChangeBatch? SyncEngine (CKSyncEngine syncEngine, CKSyncEngineSendChangesContext context)
		{
			var syncEngine__handle__ = syncEngine!.GetNonNullHandle (nameof (syncEngine));
			var context__handle__ = context!.GetNonNullHandle (nameof (context));
			CKSyncEngineRecordZoneChangeBatch? ret;
			ret =  Runtime.GetNSObject<CKSyncEngineRecordZoneChangeBatch> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("syncEngine:nextRecordZoneChangeBatchForContext:"), syncEngine__handle__, context__handle__), false)!;
			GC.KeepAlive (syncEngine);
			GC.KeepAlive (context);
			return ret!;
		}
	}
}
namespace CloudKit {
	/// <summary>
	///   <para>This is a class that implements the interface <see cref="ICKSyncEngineDelegate" /> (for the protocol <c>CKSyncEngineDelegate</c>).</para>
	///   <para>Subclass this class to easily create a type that implements the protocol.</para>
	///   <para>An alternative is to create a subclass of <see cref="NSObject" /> and then implemented the interface <see cref="ICKSyncEngineDelegate" />.</para>
	/// </summary>
	[Protocol()]
	[Register("Microsoft_iOS__CloudKit_CKSyncEngineDelegate", false)]
	[Model]
	[SupportedOSPlatform ("tvos17.0")]
	[SupportedOSPlatform ("macos14.0")]
	[SupportedOSPlatform ("ios17.0")]
	[SupportedOSPlatform ("maccatalyst17.0")]
	public unsafe abstract partial class CKSyncEngineDelegate : NSObject, ICKSyncEngineDelegate {
		/// <summary>Creates a new <see cref="CKSyncEngineDelegate" /> with default values.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		protected CKSyncEngineDelegate () : base (NSObjectFlag.Empty)
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
		protected CKSyncEngineDelegate (NSObjectFlag t) : base (t)
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
		protected internal CKSyncEngineDelegate (NativeHandle handle) : base (handle)
		{
			IsDirectBinding = false;
		}

		[Export ("syncEngine:handleEvent:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SyncEngine (CKSyncEngine syncEngine, CKSyncEngineEvent @event)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("syncEngine:nextRecordZoneChangeBatchForContext:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual CKSyncEngineRecordZoneChangeBatch? SyncEngine (CKSyncEngine syncEngine, CKSyncEngineSendChangesContext context)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("syncEngine:nextFetchChangesOptionsForContext:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual CKSyncEngineFetchChangesOptions SyncEngine (CKSyncEngine syncEngine, CKSyncEngineFetchChangesContext context)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
	} /* class CKSyncEngineDelegate */
}
