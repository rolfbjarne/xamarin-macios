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
namespace Foundation {
	[Register("NSMutableOrderedSet", true)]
	public unsafe partial class NSMutableOrderedSet : NSOrderedSet {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAddObject_X = "addObject:";
		static readonly NativeHandle selAddObject_XHandle = Selector.GetHandle ("addObject:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAddObjectsFromArray_X = "addObjectsFromArray:";
		static readonly NativeHandle selAddObjectsFromArray_XHandle = Selector.GetHandle ("addObjectsFromArray:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selExchangeObjectAtIndex_WithObjectAtIndex_X = "exchangeObjectAtIndex:withObjectAtIndex:";
		static readonly NativeHandle selExchangeObjectAtIndex_WithObjectAtIndex_XHandle = Selector.GetHandle ("exchangeObjectAtIndex:withObjectAtIndex:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selInitWithArray_X = "initWithArray:";
		static readonly NativeHandle selInitWithArray_XHandle = Selector.GetHandle ("initWithArray:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selInitWithCapacity_X = "initWithCapacity:";
		static readonly NativeHandle selInitWithCapacity_XHandle = Selector.GetHandle ("initWithCapacity:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selInitWithObject_X = "initWithObject:";
		static readonly NativeHandle selInitWithObject_XHandle = Selector.GetHandle ("initWithObject:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selInitWithOrderedSet_X = "initWithOrderedSet:";
		static readonly NativeHandle selInitWithOrderedSet_XHandle = Selector.GetHandle ("initWithOrderedSet:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selInitWithSet_X = "initWithSet:";
		static readonly NativeHandle selInitWithSet_XHandle = Selector.GetHandle ("initWithSet:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selInsertObject_AtIndex_X = "insertObject:atIndex:";
		static readonly NativeHandle selInsertObject_AtIndex_XHandle = Selector.GetHandle ("insertObject:atIndex:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selInsertObjects_AtIndexes_X = "insertObjects:atIndexes:";
		static readonly NativeHandle selInsertObjects_AtIndexes_XHandle = Selector.GetHandle ("insertObjects:atIndexes:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selIntersectOrderedSet_X = "intersectOrderedSet:";
		static readonly NativeHandle selIntersectOrderedSet_XHandle = Selector.GetHandle ("intersectOrderedSet:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selIntersectSet_X = "intersectSet:";
		static readonly NativeHandle selIntersectSet_XHandle = Selector.GetHandle ("intersectSet:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selMinusOrderedSet_X = "minusOrderedSet:";
		static readonly NativeHandle selMinusOrderedSet_XHandle = Selector.GetHandle ("minusOrderedSet:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selMinusSet_X = "minusSet:";
		static readonly NativeHandle selMinusSet_XHandle = Selector.GetHandle ("minusSet:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selMoveObjectsAtIndexes_ToIndex_X = "moveObjectsAtIndexes:toIndex:";
		static readonly NativeHandle selMoveObjectsAtIndexes_ToIndex_XHandle = Selector.GetHandle ("moveObjectsAtIndexes:toIndex:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selRemoveAllObjectsX = "removeAllObjects";
		static readonly NativeHandle selRemoveAllObjectsXHandle = Selector.GetHandle ("removeAllObjects");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selRemoveObject_X = "removeObject:";
		static readonly NativeHandle selRemoveObject_XHandle = Selector.GetHandle ("removeObject:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selRemoveObjectAtIndex_X = "removeObjectAtIndex:";
		static readonly NativeHandle selRemoveObjectAtIndex_XHandle = Selector.GetHandle ("removeObjectAtIndex:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selRemoveObjectsAtIndexes_X = "removeObjectsAtIndexes:";
		static readonly NativeHandle selRemoveObjectsAtIndexes_XHandle = Selector.GetHandle ("removeObjectsAtIndexes:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selRemoveObjectsInArray_X = "removeObjectsInArray:";
		static readonly NativeHandle selRemoveObjectsInArray_XHandle = Selector.GetHandle ("removeObjectsInArray:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selRemoveObjectsInRange_X = "removeObjectsInRange:";
		static readonly NativeHandle selRemoveObjectsInRange_XHandle = Selector.GetHandle ("removeObjectsInRange:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selReplaceObjectAtIndex_WithObject_X = "replaceObjectAtIndex:withObject:";
		static readonly NativeHandle selReplaceObjectAtIndex_WithObject_XHandle = Selector.GetHandle ("replaceObjectAtIndex:withObject:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selReplaceObjectsAtIndexes_WithObjects_X = "replaceObjectsAtIndexes:withObjects:";
		static readonly NativeHandle selReplaceObjectsAtIndexes_WithObjects_XHandle = Selector.GetHandle ("replaceObjectsAtIndexes:withObjects:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetObject_AtIndex_X = "setObject:atIndex:";
		static readonly NativeHandle selSetObject_AtIndex_XHandle = Selector.GetHandle ("setObject:atIndex:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSortRange_Options_UsingComparator_X = "sortRange:options:usingComparator:";
		static readonly NativeHandle selSortRange_Options_UsingComparator_XHandle = Selector.GetHandle ("sortRange:options:usingComparator:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSortUsingComparator_X = "sortUsingComparator:";
		static readonly NativeHandle selSortUsingComparator_XHandle = Selector.GetHandle ("sortUsingComparator:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSortWithOptions_UsingComparator_X = "sortWithOptions:usingComparator:";
		static readonly NativeHandle selSortWithOptions_UsingComparator_XHandle = Selector.GetHandle ("sortWithOptions:usingComparator:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selUnionOrderedSet_X = "unionOrderedSet:";
		static readonly NativeHandle selUnionOrderedSet_XHandle = Selector.GetHandle ("unionOrderedSet:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selUnionSet_X = "unionSet:";
		static readonly NativeHandle selUnionSet_XHandle = Selector.GetHandle ("unionSet:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly NativeHandle class_ptr = Class.GetHandle ("NSMutableOrderedSet");
		/// <summary>The Objective-C class handle for this class.</summary>
		/// <value>The pointer to the Objective-C class.</value>
		/// <remarks>
		///     Each managed class mirrors an unmanaged Objective-C class.
		///     This value contains the pointer to the Objective-C class.
		///     It is similar to calling the managed <see cref="ObjCRuntime.Class.GetHandle(string)" /> or the native <see href="https://developer.apple.com/documentation/objectivec/1418952-objc_getclass">objc_getClass</see> method with the type name.
		/// </remarks>
		public override NativeHandle ClassHandle { get { return class_ptr; } }
		/// <summary>Creates a new <see cref="NSMutableOrderedSet" /> with default values.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[DesignatedInitializer]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public NSMutableOrderedSet () : base (NSObjectFlag.Empty)
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
		public NSMutableOrderedSet (NSCoder coder) : base (NSObjectFlag.Empty)
		{
			if (IsDirectBinding) {
				InitializeHandle (global::ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr (this.Handle, Selector.InitWithCoder, coder.Handle), "initWithCoder:");
			} else {
				unsafe {
				var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
				InitializeHandle (global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper_IntPtr (&__objc_super__, Selector.InitWithCoder, coder.Handle), "initWithCoder:");
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
		protected NSMutableOrderedSet (NSObjectFlag t) : base (t)
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
		protected internal NSMutableOrderedSet (NativeHandle handle) : base (handle)
		{
		}

		[Export ("initWithObject:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public NSMutableOrderedSet (NSObject start)
			: base (NSObjectFlag.Empty)
		{
			var start__handle__ = start!.GetNonNullHandle (nameof (start));
			if (IsDirectBinding) {
				InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, selInitWithObject_XHandle, start__handle__), "initWithObject:");
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle (&__objc_super__, selInitWithObject_XHandle, start__handle__), "initWithObject:");
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (start);
		}
		[Export ("initWithSet:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public NSMutableOrderedSet (NSSet source)
			: base (NSObjectFlag.Empty)
		{
			var source__handle__ = source!.GetNonNullHandle (nameof (source));
			if (IsDirectBinding) {
				InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, selInitWithSet_XHandle, source__handle__), "initWithSet:");
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle (&__objc_super__, selInitWithSet_XHandle, source__handle__), "initWithSet:");
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (source);
		}
		[Export ("initWithOrderedSet:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public NSMutableOrderedSet (NSOrderedSet source)
			: base (NSObjectFlag.Empty)
		{
			var source__handle__ = source!.GetNonNullHandle (nameof (source));
			if (IsDirectBinding) {
				InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, selInitWithOrderedSet_XHandle, source__handle__), "initWithOrderedSet:");
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle (&__objc_super__, selInitWithOrderedSet_XHandle, source__handle__), "initWithOrderedSet:");
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (source);
		}
		/// <param name="capacity">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("initWithCapacity:")]
		[DesignatedInitializer]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public NSMutableOrderedSet (nint capacity)
			: base (NSObjectFlag.Empty)
		{
			if (IsDirectBinding) {
				InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_IntPtr (this.Handle, selInitWithCapacity_XHandle, capacity), "initWithCapacity:");
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_IntPtr (&__objc_super__, selInitWithCapacity_XHandle, capacity), "initWithCapacity:");
					GC.KeepAlive (this);
				}
			}
		}
		[Export ("initWithArray:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal NSMutableOrderedSet (NSArray array)
			: base (NSObjectFlag.Empty)
		{
			var array__handle__ = array!.GetNonNullHandle (nameof (array));
			if (IsDirectBinding) {
				InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, selInitWithArray_XHandle, array__handle__), "initWithArray:");
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle (&__objc_super__, selInitWithArray_XHandle, array__handle__), "initWithArray:");
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (array);
		}
		[Export ("addObject:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void Add (NSObject obj)
		{
			var obj__handle__ = obj!.GetNonNullHandle (nameof (obj));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selAddObject_XHandle, obj__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selAddObject_XHandle, obj__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (obj);
		}
		[Export ("addObjectsFromArray:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void AddObjects (NSObject[] source)
		{
			if (source is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (source));
			using var nsa_source = NSArray.FromNSObjects (source);
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selAddObjectsFromArray_XHandle, nsa_source.Handle);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selAddObjectsFromArray_XHandle, nsa_source.Handle);
					GC.KeepAlive (this);
				}
			}
		}
		/// <param name="first">To be added.</param><param name="second">To be added.</param><summary>Exchanges the objects at the specified indices.</summary><remarks>To be added.</remarks>
		[Export ("exchangeObjectAtIndex:withObjectAtIndex:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void ExchangeObject (nint first, nint second)
		{
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr_IntPtr (this.Handle, selExchangeObjectAtIndex_WithObjectAtIndex_XHandle, first, second);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr_IntPtr (&__objc_super__, selExchangeObjectAtIndex_WithObjectAtIndex_XHandle, first, second);
					GC.KeepAlive (this);
				}
			}
		}
		/// <param name="obj">To be added.</param><param name="atIndex">To be added.</param><summary>Inserts the specified object at the specified index.</summary><remarks>To be added.</remarks>
		[Export ("insertObject:atIndex:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void Insert (NSObject obj, nint atIndex)
		{
			var obj__handle__ = obj!.GetNonNullHandle (nameof (obj));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_IntPtr (this.Handle, selInsertObject_AtIndex_XHandle, obj__handle__, atIndex);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_IntPtr (&__objc_super__, selInsertObject_AtIndex_XHandle, obj__handle__, atIndex);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (obj);
		}
		[Export ("insertObjects:atIndexes:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void InsertObjects (NSObject[] objects, NSIndexSet atIndexes)
		{
			if (objects is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (objects));
			var atIndexes__handle__ = atIndexes!.GetNonNullHandle (nameof (atIndexes));
			using var nsa_objects = NSArray.FromNSObjects (objects);
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (this.Handle, selInsertObjects_AtIndexes_XHandle, nsa_objects.Handle, atIndexes__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, selInsertObjects_AtIndexes_XHandle, nsa_objects.Handle, atIndexes__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (atIndexes);
		}
		[Export ("intersectOrderedSet:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void Intersect (NSOrderedSet intersectWith)
		{
			var intersectWith__handle__ = intersectWith!.GetNonNullHandle (nameof (intersectWith));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selIntersectOrderedSet_XHandle, intersectWith__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selIntersectOrderedSet_XHandle, intersectWith__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (intersectWith);
		}
		[Export ("intersectSet:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void Intersect (NSSet intersectWith)
		{
			var intersectWith__handle__ = intersectWith!.GetNonNullHandle (nameof (intersectWith));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selIntersectSet_XHandle, intersectWith__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selIntersectSet_XHandle, intersectWith__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (intersectWith);
		}
		[Export ("minusSet:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal virtual void MinusSet (NSSet other)
		{
			var other__handle__ = other!.GetNonNullHandle (nameof (other));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selMinusSet_XHandle, other__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selMinusSet_XHandle, other__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (other);
		}
		[Export ("minusOrderedSet:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal virtual void MinusSet (NSOrderedSet other)
		{
			var other__handle__ = other!.GetNonNullHandle (nameof (other));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selMinusOrderedSet_XHandle, other__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selMinusOrderedSet_XHandle, other__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (other);
		}
		/// <param name="indexSet">To be added.</param><param name="destination">To be added.</param><summary>Moves the objects currently at the specified indices so that they start at the specified destination index.</summary><remarks>To be added.</remarks>
		[Export ("moveObjectsAtIndexes:toIndex:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void MoveObjects (NSIndexSet indexSet, nint destination)
		{
			var indexSet__handle__ = indexSet!.GetNonNullHandle (nameof (indexSet));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_IntPtr (this.Handle, selMoveObjectsAtIndexes_ToIndex_XHandle, indexSet__handle__, destination);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_IntPtr (&__objc_super__, selMoveObjectsAtIndexes_ToIndex_XHandle, indexSet__handle__, destination);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (indexSet);
		}
		/// <param name="index">To be added.</param><summary>Removes the object at the specified index.</summary><remarks>To be added.</remarks>
		[Export ("removeObjectAtIndex:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void Remove (nint index)
		{
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selRemoveObjectAtIndex_XHandle, index);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (&__objc_super__, selRemoveObjectAtIndex_XHandle, index);
					GC.KeepAlive (this);
				}
			}
		}
		[Export ("removeAllObjects")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void RemoveAllObjects ()
		{
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, selRemoveAllObjectsXHandle);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper (&__objc_super__, selRemoveAllObjectsXHandle);
					GC.KeepAlive (this);
				}
			}
		}
		[Export ("removeObject:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void RemoveObject (NSObject obj)
		{
			var obj__handle__ = obj!.GetNonNullHandle (nameof (obj));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selRemoveObject_XHandle, obj__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selRemoveObject_XHandle, obj__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (obj);
		}
		[Export ("removeObjectsAtIndexes:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void RemoveObjects (NSIndexSet indexSet)
		{
			var indexSet__handle__ = indexSet!.GetNonNullHandle (nameof (indexSet));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selRemoveObjectsAtIndexes_XHandle, indexSet__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selRemoveObjectsAtIndexes_XHandle, indexSet__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (indexSet);
		}
		[Export ("removeObjectsInRange:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void RemoveObjects (NSRange range)
		{
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NSRange (this.Handle, selRemoveObjectsInRange_XHandle, range);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NSRange (&__objc_super__, selRemoveObjectsInRange_XHandle, range);
					GC.KeepAlive (this);
				}
			}
		}
		[Export ("removeObjectsInArray:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void RemoveObjects (NSObject[] objects)
		{
			if (objects is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (objects));
			using var nsa_objects = NSArray.FromNSObjects (objects);
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selRemoveObjectsInArray_XHandle, nsa_objects.Handle);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selRemoveObjectsInArray_XHandle, nsa_objects.Handle);
					GC.KeepAlive (this);
				}
			}
		}
		/// <param name="objectAtIndex">To be added.</param><param name="newObject">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("replaceObjectAtIndex:withObject:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void Replace (nint objectAtIndex, NSObject newObject)
		{
			var newObject__handle__ = newObject!.GetNonNullHandle (nameof (newObject));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr_NativeHandle (this.Handle, selReplaceObjectAtIndex_WithObject_XHandle, objectAtIndex, newObject__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr_NativeHandle (&__objc_super__, selReplaceObjectAtIndex_WithObject_XHandle, objectAtIndex, newObject__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (newObject);
		}
		[Export ("replaceObjectsAtIndexes:withObjects:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void ReplaceObjects (NSIndexSet indexSet, NSObject[] replacementObjects)
		{
			var indexSet__handle__ = indexSet!.GetNonNullHandle (nameof (indexSet));
			if (replacementObjects is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (replacementObjects));
			using var nsa_replacementObjects = NSArray.FromNSObjects (replacementObjects);
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (this.Handle, selReplaceObjectsAtIndexes_WithObjects_XHandle, indexSet__handle__, nsa_replacementObjects.Handle);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, selReplaceObjectsAtIndexes_WithObjects_XHandle, indexSet__handle__, nsa_replacementObjects.Handle);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (indexSet);
		}
		/// <param name="obj">To be added.</param><param name="index">To be added.</param><summary>Appends or replaces the object at the specified index.</summary><remarks>To be added.</remarks>
		[Export ("setObject:atIndex:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetObject (NSObject obj, nint index)
		{
			var obj__handle__ = obj!.GetNonNullHandle (nameof (obj));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_IntPtr (this.Handle, selSetObject_AtIndex_XHandle, obj__handle__, index);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_IntPtr (&__objc_super__, selSetObject_AtIndex_XHandle, obj__handle__, index);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (obj);
		}
		[Export ("sortUsingComparator:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void Sort ([BlockProxy (typeof (ObjCRuntime.Trampolines.NIDNSComparator))]NSComparator comparator)
		{
			if (comparator is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (comparator));
			using var block_comparator = Trampolines.SDNSComparator.CreateBlock (comparator);
			BlockLiteral *block_ptr_comparator = &block_comparator;
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selSortUsingComparator_XHandle, (IntPtr) block_ptr_comparator);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selSortUsingComparator_XHandle, (IntPtr) block_ptr_comparator);
					GC.KeepAlive (this);
				}
			}
		}
		[Export ("sortWithOptions:usingComparator:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void Sort (NSSortOptions sortOptions, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDNSComparator))]NSComparator comparator)
		{
			if (comparator is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (comparator));
			using var block_comparator = Trampolines.SDNSComparator.CreateBlock (comparator);
			BlockLiteral *block_ptr_comparator = &block_comparator;
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_UIntPtr_NativeHandle (this.Handle, selSortWithOptions_UsingComparator_XHandle, (UIntPtr) (ulong) sortOptions, (IntPtr) block_ptr_comparator);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_UIntPtr_NativeHandle (&__objc_super__, selSortWithOptions_UsingComparator_XHandle, (UIntPtr) (ulong) sortOptions, (IntPtr) block_ptr_comparator);
					GC.KeepAlive (this);
				}
			}
		}
		[Export ("sortRange:options:usingComparator:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void SortRange (NSRange range, NSSortOptions sortOptions, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDNSComparator))]NSComparator comparator)
		{
			if (comparator is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (comparator));
			using var block_comparator = Trampolines.SDNSComparator.CreateBlock (comparator);
			BlockLiteral *block_ptr_comparator = &block_comparator;
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NSRange_UIntPtr_NativeHandle (this.Handle, selSortRange_Options_UsingComparator_XHandle, range, (UIntPtr) (ulong) sortOptions, (IntPtr) block_ptr_comparator);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NSRange_UIntPtr_NativeHandle (&__objc_super__, selSortRange_Options_UsingComparator_XHandle, range, (UIntPtr) (ulong) sortOptions, (IntPtr) block_ptr_comparator);
					GC.KeepAlive (this);
				}
			}
		}
		[Export ("unionSet:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal virtual void UnionSet (NSSet other)
		{
			var other__handle__ = other!.GetNonNullHandle (nameof (other));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selUnionSet_XHandle, other__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selUnionSet_XHandle, other__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (other);
		}
		[Export ("unionOrderedSet:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal virtual void UnionSet (NSOrderedSet other)
		{
			var other__handle__ = other!.GetNonNullHandle (nameof (other));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selUnionOrderedSet_XHandle, other__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selUnionOrderedSet_XHandle, other__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (other);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal void _Add (nint obj)
		{
			global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selAddObject_XHandle, obj);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal void _AddObjects (NSArray source)
		{
			var source__handle__ = source!.GetNonNullHandle (nameof (source));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selAddObjectsFromArray_XHandle, source__handle__);
			GC.KeepAlive (source);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal void _Insert (nint obj, nint atIndex)
		{
			global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr_IntPtr (this.Handle, selInsertObject_AtIndex_XHandle, obj, atIndex);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal void _InsertObjects (NSArray objects, NSIndexSet atIndexes)
		{
			var objects__handle__ = objects!.GetNonNullHandle (nameof (objects));
			var atIndexes__handle__ = atIndexes!.GetNonNullHandle (nameof (atIndexes));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (this.Handle, selInsertObjects_AtIndexes_XHandle, objects__handle__, atIndexes__handle__);
			GC.KeepAlive (objects);
			GC.KeepAlive (atIndexes);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal void _RemoveObject (nint obj)
		{
			global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selRemoveObject_XHandle, obj);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal void _RemoveObjects (NSArray objects)
		{
			var objects__handle__ = objects!.GetNonNullHandle (nameof (objects));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selRemoveObjectsInArray_XHandle, objects__handle__);
			GC.KeepAlive (objects);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal void _Replace (nint objectAtIndex, nint newObject)
		{
			global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr_IntPtr (this.Handle, selReplaceObjectAtIndex_WithObject_XHandle, objectAtIndex, newObject);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal void _ReplaceObjects (NSIndexSet indexSet, NSArray replacementObjects)
		{
			var indexSet__handle__ = indexSet!.GetNonNullHandle (nameof (indexSet));
			var replacementObjects__handle__ = replacementObjects!.GetNonNullHandle (nameof (replacementObjects));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (this.Handle, selReplaceObjectsAtIndexes_WithObjects_XHandle, indexSet__handle__, replacementObjects__handle__);
			GC.KeepAlive (indexSet);
			GC.KeepAlive (replacementObjects);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal void _SetObject (nint obj, nint index)
		{
			global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr_IntPtr (this.Handle, selSetObject_AtIndex_XHandle, obj, index);
		}
	} /* class NSMutableOrderedSet */
}
