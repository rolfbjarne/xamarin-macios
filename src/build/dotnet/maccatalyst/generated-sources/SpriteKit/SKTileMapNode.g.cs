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
namespace SpriteKit {
	/// <summary>A <see cref="T:SpriteKit.SKNode" /> that encapsulates a tiled map and a <see cref="T:SpriteKit.SKTileSet" />.</summary><remarks><para>The <see cref="T:SpriteKit.SKTileMapNode" /> subclass of <see cref="T:SpriteKit.SKNode" /> allows developers to easily create and manipulate tile-based maps with a variety of geometries and perspectives. An <see cref="T:SpriteKit.SKTileMapNode" /> contains a <see cref="T:SpriteKit.SKTileSet" /> that defines the overall map. In addition, the <see cref="T:SpriteKit.SKTileSet" /> contains one or more <see cref="T:SpriteKit.SKTileGroup" /> objects, each of which represents one style of tile, which may have several representations.</para><example><code lang="csharp lang-csharp"><![CDATA[
	/// //Load tile set
	/// var tileSet = SKTileSet.FromName ("MyTileSet");
	/// //Create a 16x16 map
	/// var tileNode = new SKTileMapNode (tileSet, 16, 16, tileSet.DefaultTileSize);
	/// 
	/// //Fill the node's grid with the default tile 
	/// var tg = tileSet.DefaultTileGroup;
	/// tileNode.Fill (tg);
	/// ]]></code><para>The relationship between a <see cref="T:SpriteKit.SKTileMapNode" /> and it's tiles is shown in the following image:</para><para><img href="~/xml/SpriteKit/_images/SKTileMapNode.Hierarchy.png" alt="UML class diagram showing important classes relating to SKTileMapNode" /></para></example></remarks><related type="externalDocumentation" href="https://developer.apple.com/reference/SpriteKit/SKTileMapNode">Apple documentation for <c>SKTileMapNode</c></related>
	[Register("SKTileMapNode", true)]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("tvos")]
	public unsafe partial class SKTileMapNode : SKNode, INSCoding, INSCopying, INSSecureCoding {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly NativeHandle class_ptr = Class.GetHandle ("SKTileMapNode");
		/// <summary>The Objective-C class handle for this class.</summary>
		/// <value>The pointer to the Objective-C class.</value>
		/// <remarks>
		///     Each managed class mirrors an unmanaged Objective-C class.
		///     This value contains the pointer to the Objective-C class.
		///     It is similar to calling the managed <see cref="ObjCRuntime.Class.GetHandle(string)" /> or the native <see href="https://developer.apple.com/documentation/objectivec/1418952-objc_getclass">objc_getClass</see> method with the type name.
		/// </remarks>
		public override NativeHandle ClassHandle { get { return class_ptr; } }
		/// <summary>Creates a new <see cref="SKTileMapNode" /> with default values.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public SKTileMapNode () : base (NSObjectFlag.Empty)
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
		public SKTileMapNode (NSCoder coder) : base (NSObjectFlag.Empty)
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
		protected SKTileMapNode (NSObjectFlag t) : base (t)
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
		protected internal SKTileMapNode (NativeHandle handle) : base (handle)
		{
		}

		/// <param name="tileSet">To be added.</param><param name="columns">To be added.</param><param name="rows">To be added.</param><param name="tileSize">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("initWithTileSet:columns:rows:tileSize:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public SKTileMapNode (SKTileSet tileSet, nuint columns, nuint rows, CGSize tileSize)
			: base (NSObjectFlag.Empty)
		{
			var tileSet__handle__ = tileSet!.GetNonNullHandle (nameof (tileSet));
			if (IsDirectBinding) {
				InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_UIntPtr_UIntPtr_CGSize (this.Handle, Selector.GetHandle ("initWithTileSet:columns:rows:tileSize:"), tileSet__handle__, columns, rows, tileSize), "initWithTileSet:columns:rows:tileSize:");
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_UIntPtr_UIntPtr_CGSize (&__objc_super__, Selector.GetHandle ("initWithTileSet:columns:rows:tileSize:"), tileSet__handle__, columns, rows, tileSize), "initWithTileSet:columns:rows:tileSize:");
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (tileSet);
		}
		/// <param name="tileSet">To be added.</param><param name="columns">To be added.</param><param name="rows">To be added.</param><param name="tileSize">To be added.</param><param name="tileGroup">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("initWithTileSet:columns:rows:tileSize:fillWithTileGroup:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public SKTileMapNode (SKTileSet tileSet, nuint columns, nuint rows, CGSize tileSize, SKTileGroup tileGroup)
			: base (NSObjectFlag.Empty)
		{
			var tileSet__handle__ = tileSet!.GetNonNullHandle (nameof (tileSet));
			var tileGroup__handle__ = tileGroup!.GetNonNullHandle (nameof (tileGroup));
			if (IsDirectBinding) {
				InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_UIntPtr_UIntPtr_CGSize_NativeHandle (this.Handle, Selector.GetHandle ("initWithTileSet:columns:rows:tileSize:fillWithTileGroup:"), tileSet__handle__, columns, rows, tileSize, tileGroup__handle__), "initWithTileSet:columns:rows:tileSize:fillWithTileGroup:");
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_UIntPtr_UIntPtr_CGSize_NativeHandle (&__objc_super__, Selector.GetHandle ("initWithTileSet:columns:rows:tileSize:fillWithTileGroup:"), tileSet__handle__, columns, rows, tileSize, tileGroup__handle__), "initWithTileSet:columns:rows:tileSize:fillWithTileGroup:");
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (tileSet);
			GC.KeepAlive (tileGroup);
		}
		/// <param name="tileSet">To be added.</param><param name="columns">To be added.</param><param name="rows">To be added.</param><param name="tileSize">To be added.</param><param name="tileGroupLayout">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("initWithTileSet:columns:rows:tileSize:tileGroupLayout:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public SKTileMapNode (SKTileSet tileSet, nuint columns, nuint rows, CGSize tileSize, SKTileGroup[] tileGroupLayout)
			: base (NSObjectFlag.Empty)
		{
			var tileSet__handle__ = tileSet!.GetNonNullHandle (nameof (tileSet));
			if (tileGroupLayout is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (tileGroupLayout));
			using var nsa_tileGroupLayout = NSArray.FromNSObjects (tileGroupLayout);
			if (IsDirectBinding) {
				InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_UIntPtr_UIntPtr_CGSize_NativeHandle (this.Handle, Selector.GetHandle ("initWithTileSet:columns:rows:tileSize:tileGroupLayout:"), tileSet__handle__, columns, rows, tileSize, nsa_tileGroupLayout.Handle), "initWithTileSet:columns:rows:tileSize:tileGroupLayout:");
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_UIntPtr_UIntPtr_CGSize_NativeHandle (&__objc_super__, Selector.GetHandle ("initWithTileSet:columns:rows:tileSize:tileGroupLayout:"), tileSet__handle__, columns, rows, tileSize, nsa_tileGroupLayout.Handle), "initWithTileSet:columns:rows:tileSize:tileGroupLayout:");
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (tileSet);
		}
		/// <param name="zone">Developers should pass <see langword="null" />.  Memory zones are no longer used.</param><summary>Performs a copy of the underlying Objective-C object.</summary><returns>The newly-allocated object.</returns><remarks><para>This method performs a "shallow copy" of <see langword="this" />. If this object contains references to external objects, the new object will contain references to the same object.</para></remarks>
		[Export ("copyWithZone:")]
		[return: ReleaseAttribute ()]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public new virtual NSObject Copy (NSZone? zone)
		{
			var zone__handle__ = zone.GetHandle ();
			NSObject? ret;
			if (IsDirectBinding) {
				ret = Runtime.GetNSObject (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("copyWithZone:"), zone__handle__), true)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = Runtime.GetNSObject (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle (&__objc_super__, Selector.GetHandle ("copyWithZone:"), zone__handle__), true)!;
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (zone);
			return ret!;
		}
		/// <param name="tileSet">To be added.</param><param name="columns">To be added.</param><param name="rows">To be added.</param><param name="tileSize">To be added.</param><summary>Factory method to create an <see cref="T:SpriteKit.SKTileMapNode" /> with the specified properties.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("tileMapNodeWithTileSet:columns:rows:tileSize:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static SKTileMapNode Create (SKTileSet tileSet, nuint columns, nuint rows, CGSize tileSize)
		{
			var tileSet__handle__ = tileSet!.GetNonNullHandle (nameof (tileSet));
			SKTileMapNode? ret;
			ret =  Runtime.GetNSObject<SKTileMapNode> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_UIntPtr_UIntPtr_CGSize (class_ptr, Selector.GetHandle ("tileMapNodeWithTileSet:columns:rows:tileSize:"), tileSet__handle__, columns, rows, tileSize), false)!;
			GC.KeepAlive (tileSet);
			return ret!;
		}
		/// <param name="tileSet">To be added.</param><param name="columns">To be added.</param><param name="rows">To be added.</param><param name="tileSize">To be added.</param><param name="tileGroup">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("tileMapNodeWithTileSet:columns:rows:tileSize:fillWithTileGroup:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static SKTileMapNode Create (SKTileSet tileSet, nuint columns, nuint rows, CGSize tileSize, SKTileGroup tileGroup)
		{
			var tileSet__handle__ = tileSet!.GetNonNullHandle (nameof (tileSet));
			var tileGroup__handle__ = tileGroup!.GetNonNullHandle (nameof (tileGroup));
			SKTileMapNode? ret;
			ret =  Runtime.GetNSObject<SKTileMapNode> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_UIntPtr_UIntPtr_CGSize_NativeHandle (class_ptr, Selector.GetHandle ("tileMapNodeWithTileSet:columns:rows:tileSize:fillWithTileGroup:"), tileSet__handle__, columns, rows, tileSize, tileGroup__handle__), false)!;
			GC.KeepAlive (tileSet);
			GC.KeepAlive (tileGroup);
			return ret!;
		}
		/// <param name="tileSet">To be added.</param><param name="columns">To be added.</param><param name="rows">To be added.</param><param name="tileSize">To be added.</param><param name="tileGroupLayout">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("tileMapNodeWithTileSet:columns:rows:tileSize:tileGroupLayout:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static SKTileMapNode Create (SKTileSet tileSet, nuint columns, nuint rows, CGSize tileSize, SKTileGroup[] tileGroupLayout)
		{
			var tileSet__handle__ = tileSet!.GetNonNullHandle (nameof (tileSet));
			if (tileGroupLayout is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (tileGroupLayout));
			using var nsa_tileGroupLayout = NSArray.FromNSObjects (tileGroupLayout);
			SKTileMapNode? ret;
			ret =  Runtime.GetNSObject<SKTileMapNode> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_UIntPtr_UIntPtr_CGSize_NativeHandle (class_ptr, Selector.GetHandle ("tileMapNodeWithTileSet:columns:rows:tileSize:tileGroupLayout:"), tileSet__handle__, columns, rows, tileSize, nsa_tileGroupLayout.Handle), false)!;
			GC.KeepAlive (tileSet);
			return ret!;
		}
		/// <summary>Encodes the state of the object using the provided encoder.</summary><param name="encoder">The encoder object where the state of the object will be stored</param><remarks><para>This method is part of the <see cref="T:Foundation.INSCoding" /> protocol and is used by applications to preserve the state of the object into an archive.</para><para>Developers will typically create an <see cref="T:Foundation.NSKeyedArchiver" /> and then invoke the <see cref="M:Foundation.NSKeyedArchiver.ArchiveRootObjectToFile(Foundation.NSObject,System.String)" /> method which will call into this method.</para><para>If developers want to allow their object to be archived, they should override this method and store their state in using the provided <paramref name="encoder" /> parameter. In addition, developers should also implement a constructor that takes an NSCoder argument and is exported with <c>[Export ("initWithCoder:")]</c>.</para><example><code lang="csharp lang-csharp"><![CDATA[public void override EncodeTo (NSCoder coder) {
		/// coder.Encode (1, key: "version");
		/// coder.Encode (userName, key: "userName");
		/// coder.Encode (hostName, key: "hostName");]]></code></example></remarks>
		[Export ("encodeWithCoder:")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public new virtual void EncodeTo (NSCoder encoder)
		{
			var encoder__handle__ = encoder!.GetNonNullHandle (nameof (encoder));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("encodeWithCoder:"), encoder__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, Selector.GetHandle ("encodeWithCoder:"), encoder__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (encoder);
		}
		[Export ("fillWithTileGroup:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void Fill (SKTileGroup? tileGroup)
		{
			var tileGroup__handle__ = tileGroup.GetHandle ();
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("fillWithTileGroup:"), tileGroup__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, Selector.GetHandle ("fillWithTileGroup:"), tileGroup__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (tileGroup);
		}
		/// <param name="tileSet">To be added.</param><param name="columns">To be added.</param><param name="rows">To be added.</param><param name="tileSize">To be added.</param><param name="noiseMap">To be added.</param><param name="thresholds">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("tileMapNodesWithTileSet:columns:rows:tileSize:fromNoiseMap:tileTypeNoiseMapThresholds:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static SKTileMapNode[] FromTileSet (SKTileSet tileSet, nuint columns, nuint rows, CGSize tileSize, global::GameplayKit.GKNoiseMap noiseMap, NSNumber[] thresholds)
		{
			var tileSet__handle__ = tileSet!.GetNonNullHandle (nameof (tileSet));
			var noiseMap__handle__ = noiseMap!.GetNonNullHandle (nameof (noiseMap));
			if (thresholds is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (thresholds));
			using var nsa_thresholds = NSArray.FromNSObjects (thresholds);
			SKTileMapNode[]? ret;
			ret = CFArray.ArrayFromHandle<SKTileMapNode>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_UIntPtr_UIntPtr_CGSize_NativeHandle_NativeHandle (class_ptr, Selector.GetHandle ("tileMapNodesWithTileSet:columns:rows:tileSize:fromNoiseMap:tileTypeNoiseMapThresholds:"), tileSet__handle__, columns, rows, tileSize, noiseMap__handle__, nsa_thresholds.Handle), false)!;
			GC.KeepAlive (tileSet);
			GC.KeepAlive (noiseMap);
			return ret!;
		}
		/// <param name="column">To be added.</param><param name="row">To be added.</param><summary>Retrieves the <see cref="T:CoreGraphics.CGPoint" /> at the center of the specified position.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("centerOfTileAtColumn:row:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual CGPoint GetCenterOfTile (nuint column, nuint row)
		{
			CGPoint ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.CGPoint_objc_msgSend_UIntPtr_UIntPtr (this.Handle, Selector.GetHandle ("centerOfTileAtColumn:row:"), column, row);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.CGPoint_objc_msgSendSuper_UIntPtr_UIntPtr (&__objc_super__, Selector.GetHandle ("centerOfTileAtColumn:row:"), column, row);
					GC.KeepAlive (this);
				}
			}
			return ret;
		}
		[Export ("tileColumnIndexFromPosition:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual nuint GetTileColumnIndex (CGPoint position)
		{
			nuint ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend_CGPoint (this.Handle, Selector.GetHandle ("tileColumnIndexFromPosition:"), position);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.UIntPtr_objc_msgSendSuper_CGPoint (&__objc_super__, Selector.GetHandle ("tileColumnIndexFromPosition:"), position);
					GC.KeepAlive (this);
				}
			}
			return ret;
		}
		/// <param name="column">To be added.</param><param name="row">To be added.</param><summary>Gets the <see cref="T:SpriteKit.SKTileDefinition" /> for the tile at the specified position.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("tileDefinitionAtColumn:row:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual SKTileDefinition? GetTileDefinition (nuint column, nuint row)
		{
			SKTileDefinition ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<SKTileDefinition> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_UIntPtr_UIntPtr (this.Handle, Selector.GetHandle ("tileDefinitionAtColumn:row:"), column, row), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<SKTileDefinition> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_UIntPtr_UIntPtr (&__objc_super__, Selector.GetHandle ("tileDefinitionAtColumn:row:"), column, row), false)!;
					GC.KeepAlive (this);
				}
			}
			return ret;
		}
		/// <param name="column">To be added.</param><param name="row">To be added.</param><summary>Gets the <see cref="T:SpriteKit.SKTileGroup" /> for the tile at the specified position.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("tileGroupAtColumn:row:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual SKTileGroup? GetTileGroup (nuint column, nuint row)
		{
			SKTileGroup ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<SKTileGroup> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_UIntPtr_UIntPtr (this.Handle, Selector.GetHandle ("tileGroupAtColumn:row:"), column, row), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<SKTileGroup> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_UIntPtr_UIntPtr (&__objc_super__, Selector.GetHandle ("tileGroupAtColumn:row:"), column, row), false)!;
					GC.KeepAlive (this);
				}
			}
			return ret;
		}
		[Export ("tileRowIndexFromPosition:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual nuint GetTileRowIndex (CGPoint position)
		{
			nuint ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend_CGPoint (this.Handle, Selector.GetHandle ("tileRowIndexFromPosition:"), position);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.UIntPtr_objc_msgSendSuper_CGPoint (&__objc_super__, Selector.GetHandle ("tileRowIndexFromPosition:"), position);
					GC.KeepAlive (this);
				}
			}
			return ret;
		}
		[Export ("valueForAttributeNamed:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual SKAttributeValue? GetValue (string key)
		{
			if (key is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (key));
			var nskey = CFString.CreateNative (key);
			SKAttributeValue? ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<SKAttributeValue> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("valueForAttributeNamed:"), nskey), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<SKAttributeValue> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle (&__objc_super__, Selector.GetHandle ("valueForAttributeNamed:"), nskey), false)!;
					GC.KeepAlive (this);
				}
			}
			CFString.ReleaseNative (nskey);
			return ret!;
		}
		/// <param name="tileGroup"><para>To be added.</para><para tool="nullallowed">This parameter can be <see langword="null" />.</para></param><param name="column">To be added.</param><param name="row">To be added.</param><summary>Sets the <see cref="T:SpriteKit.SKTileGroup" /> at the specified location.</summary><remarks>To be added.</remarks>
		[Export ("setTileGroup:forColumn:row:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetTileGroup (SKTileGroup? tileGroup, nuint column, nuint row)
		{
			var tileGroup__handle__ = tileGroup.GetHandle ();
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_UIntPtr_UIntPtr (this.Handle, Selector.GetHandle ("setTileGroup:forColumn:row:"), tileGroup__handle__, column, row);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_UIntPtr_UIntPtr (&__objc_super__, Selector.GetHandle ("setTileGroup:forColumn:row:"), tileGroup__handle__, column, row);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (tileGroup);
		}
		/// <param name="tileGroup">To be added.</param><param name="tileDefinition">To be added.</param><param name="column">To be added.</param><param name="row">To be added.</param><summary>Sets the <paramref name="tileGroup" /> and <paramref name="tileDefinition" /> at the specified location.</summary><remarks>To be added.</remarks>
		[Export ("setTileGroup:andTileDefinition:forColumn:row:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetTileGroup (SKTileGroup tileGroup, SKTileDefinition tileDefinition, nuint column, nuint row)
		{
			var tileGroup__handle__ = tileGroup!.GetNonNullHandle (nameof (tileGroup));
			var tileDefinition__handle__ = tileDefinition!.GetNonNullHandle (nameof (tileDefinition));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_UIntPtr_UIntPtr (this.Handle, Selector.GetHandle ("setTileGroup:andTileDefinition:forColumn:row:"), tileGroup__handle__, tileDefinition__handle__, column, row);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_NativeHandle_UIntPtr_UIntPtr (&__objc_super__, Selector.GetHandle ("setTileGroup:andTileDefinition:forColumn:row:"), tileGroup__handle__, tileDefinition__handle__, column, row);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (tileGroup);
			GC.KeepAlive (tileDefinition);
		}
		[Export ("setValue:forAttributeNamed:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetValue (SKAttributeValue value, string key)
		{
			var value__handle__ = value!.GetNonNullHandle (nameof (value));
			if (key is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (key));
			var nskey = CFString.CreateNative (key);
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("setValue:forAttributeNamed:"), value__handle__, nskey);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, Selector.GetHandle ("setValue:forAttributeNamed:"), value__handle__, nskey);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (value);
			CFString.ReleaseNative (nskey);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual CGPoint AnchorPoint {
			[Export ("anchorPoint", ArgumentSemantic.Assign)]
			get {
				CGPoint ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.CGPoint_objc_msgSend (this.Handle, Selector.GetHandle ("anchorPoint"));
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.CGPoint_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("anchorPoint"));
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[Export ("setAnchorPoint:", ArgumentSemantic.Assign)]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_CGPoint (this.Handle, Selector.GetHandle ("setAnchorPoint:"), value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_CGPoint (&__objc_super__, Selector.GetHandle ("setAnchorPoint:"), value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSDictionary<NSString, SKAttributeValue> AttributeValues {
			[Export ("attributeValues", ArgumentSemantic.Copy)]
			get {
				NSDictionary<NSString, SKAttributeValue>? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSDictionary<NSString, SKAttributeValue>> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("attributeValues")), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<NSDictionary<NSString, SKAttributeValue>> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("attributeValues")), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setAttributeValues:", ArgumentSemantic.Copy)]
			set {
				var value__handle__ = value!.GetNonNullHandle (nameof (value));
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("setAttributeValues:"), value__handle__);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, Selector.GetHandle ("setAttributeValues:"), value__handle__);
						GC.KeepAlive (this);
					}
				}
				GC.KeepAlive (value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual SKBlendMode BlendMode {
			[Export ("blendMode", ArgumentSemantic.Assign)]
			get {
				SKBlendMode ret;
				if (IsDirectBinding) {
					ret = (SKBlendMode) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("blendMode"));
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = (SKBlendMode) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("blendMode"));
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setBlendMode:", ArgumentSemantic.Assign)]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setBlendMode:"), (IntPtr) (long) value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (&__objc_super__, Selector.GetHandle ("setBlendMode:"), (IntPtr) (long) value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual global::UIKit.UIColor Color {
			[Export ("color", ArgumentSemantic.Retain)]
			get {
				global::UIKit.UIColor? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<global::UIKit.UIColor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("color")), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<global::UIKit.UIColor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("color")), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setColor:", ArgumentSemantic.Retain)]
			set {
				var value__handle__ = value!.GetNonNullHandle (nameof (value));
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
		public virtual nfloat ColorBlendFactor {
			[Export ("colorBlendFactor")]
			get {
				nfloat ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.nfloat_objc_msgSend (this.Handle, Selector.GetHandle ("colorBlendFactor"));
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.nfloat_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("colorBlendFactor"));
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[Export ("setColorBlendFactor:")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_nfloat (this.Handle, Selector.GetHandle ("setColorBlendFactor:"), value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_nfloat (&__objc_super__, Selector.GetHandle ("setColorBlendFactor:"), value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool EnableAutomapping {
			[Export ("enableAutomapping")]
			get {
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("enableAutomapping"));
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("enableAutomapping"));
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
			[Export ("setEnableAutomapping:")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("setEnableAutomapping:"), value ? (byte) 1 : (byte) 0);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (&__objc_super__, Selector.GetHandle ("setEnableAutomapping:"), value ? (byte) 1 : (byte) 0);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual uint LightingBitMask {
			[Export ("lightingBitMask")]
			get {
				uint ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.UInt32_objc_msgSend (this.Handle, Selector.GetHandle ("lightingBitMask"));
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.UInt32_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("lightingBitMask"));
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[Export ("setLightingBitMask:")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_UInt32 (this.Handle, Selector.GetHandle ("setLightingBitMask:"), value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_UInt32 (&__objc_super__, Selector.GetHandle ("setLightingBitMask:"), value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual CGSize MapSize {
			[Export ("mapSize")]
			get {
				CGSize ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.CGSize_objc_msgSend (this.Handle, Selector.GetHandle ("mapSize"));
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.CGSize_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("mapSize"));
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual nuint NumberOfColumns {
			[Export ("numberOfColumns")]
			get {
				nuint ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("numberOfColumns"));
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.UIntPtr_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("numberOfColumns"));
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[Export ("setNumberOfColumns:")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_UIntPtr (this.Handle, Selector.GetHandle ("setNumberOfColumns:"), value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_UIntPtr (&__objc_super__, Selector.GetHandle ("setNumberOfColumns:"), value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual nuint NumberOfRows {
			[Export ("numberOfRows")]
			get {
				nuint ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("numberOfRows"));
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.UIntPtr_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("numberOfRows"));
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[Export ("setNumberOfRows:")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_UIntPtr (this.Handle, Selector.GetHandle ("setNumberOfRows:"), value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_UIntPtr (&__objc_super__, Selector.GetHandle ("setNumberOfRows:"), value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual SKShader? Shader {
			[Export ("shader", ArgumentSemantic.Retain)]
			get {
				SKShader? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<SKShader> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("shader")), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<SKShader> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("shader")), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setShader:", ArgumentSemantic.Retain)]
			set {
				var value__handle__ = value.GetHandle ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("setShader:"), value__handle__);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, Selector.GetHandle ("setShader:"), value__handle__);
						GC.KeepAlive (this);
					}
				}
				GC.KeepAlive (value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		object? __mt_TileSet_var;
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual SKTileSet TileSet {
			[Export ("tileSet", ArgumentSemantic.Assign)]
			get {
				SKTileSet? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<SKTileSet> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("tileSet")), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<SKTileSet> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("tileSet")), false)!;
						GC.KeepAlive (this);
					}
				}
				MarkDirty ();
				__mt_TileSet_var = ret;
				return ret!;
			}
			[Export ("setTileSet:", ArgumentSemantic.Assign)]
			set {
				var value__handle__ = value!.GetNonNullHandle (nameof (value));
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("setTileSet:"), value__handle__);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, Selector.GetHandle ("setTileSet:"), value__handle__);
						GC.KeepAlive (this);
					}
				}
				GC.KeepAlive (value);
				MarkDirty ();
				__mt_TileSet_var = value;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual CGSize TileSize {
			[Export ("tileSize", ArgumentSemantic.Assign)]
			get {
				CGSize ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.CGSize_objc_msgSend (this.Handle, Selector.GetHandle ("tileSize"));
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.CGSize_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("tileSize"));
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[Export ("setTileSize:", ArgumentSemantic.Assign)]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_CGSize (this.Handle, Selector.GetHandle ("setTileSize:"), value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_CGSize (&__objc_super__, Selector.GetHandle ("setTileSize:"), value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		protected override void Dispose (bool disposing)
		{
			base.Dispose (disposing);
			if (Handle == IntPtr.Zero) {
				__mt_TileSet_var = null;
			}
		}
	} /* class SKTileMapNode */
}
