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
namespace Accessibility {
	[Register("AXChartDescriptor", true)]
	[SupportedOSPlatform ("tvos15.0")]
	[SupportedOSPlatform ("ios15.0")]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("macos")]
	public unsafe partial class AXChartDescriptor : NSObject, INSCopying {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAdditionalAxesX = "additionalAxes";
		static readonly NativeHandle selAdditionalAxesXHandle = Selector.GetHandle ("additionalAxes");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAttributedTitleX = "attributedTitle";
		static readonly NativeHandle selAttributedTitleXHandle = Selector.GetHandle ("attributedTitle");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selContentDirectionX = "contentDirection";
		static readonly NativeHandle selContentDirectionXHandle = Selector.GetHandle ("contentDirection");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selContentFrameX = "contentFrame";
		static readonly NativeHandle selContentFrameXHandle = Selector.GetHandle ("contentFrame");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selCopyWithZone_X = "copyWithZone:";
		static readonly NativeHandle selCopyWithZone_XHandle = Selector.GetHandle ("copyWithZone:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selInitWithAttributedTitle_Summary_XAxisDescriptor_YAxisDescriptor_AdditionalAxes_Series_X = "initWithAttributedTitle:summary:xAxisDescriptor:yAxisDescriptor:additionalAxes:series:";
		static readonly NativeHandle selInitWithAttributedTitle_Summary_XAxisDescriptor_YAxisDescriptor_AdditionalAxes_Series_XHandle = Selector.GetHandle ("initWithAttributedTitle:summary:xAxisDescriptor:yAxisDescriptor:additionalAxes:series:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selInitWithAttributedTitle_Summary_XAxisDescriptor_YAxisDescriptor_Series_X = "initWithAttributedTitle:summary:xAxisDescriptor:yAxisDescriptor:series:";
		static readonly NativeHandle selInitWithAttributedTitle_Summary_XAxisDescriptor_YAxisDescriptor_Series_XHandle = Selector.GetHandle ("initWithAttributedTitle:summary:xAxisDescriptor:yAxisDescriptor:series:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selInitWithTitle_Summary_XAxisDescriptor_YAxisDescriptor_AdditionalAxes_Series_X = "initWithTitle:summary:xAxisDescriptor:yAxisDescriptor:additionalAxes:series:";
		static readonly NativeHandle selInitWithTitle_Summary_XAxisDescriptor_YAxisDescriptor_AdditionalAxes_Series_XHandle = Selector.GetHandle ("initWithTitle:summary:xAxisDescriptor:yAxisDescriptor:additionalAxes:series:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selInitWithTitle_Summary_XAxisDescriptor_YAxisDescriptor_Series_X = "initWithTitle:summary:xAxisDescriptor:yAxisDescriptor:series:";
		static readonly NativeHandle selInitWithTitle_Summary_XAxisDescriptor_YAxisDescriptor_Series_XHandle = Selector.GetHandle ("initWithTitle:summary:xAxisDescriptor:yAxisDescriptor:series:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSeriesX = "series";
		static readonly NativeHandle selSeriesXHandle = Selector.GetHandle ("series");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetAdditionalAxes_X = "setAdditionalAxes:";
		static readonly NativeHandle selSetAdditionalAxes_XHandle = Selector.GetHandle ("setAdditionalAxes:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetAttributedTitle_X = "setAttributedTitle:";
		static readonly NativeHandle selSetAttributedTitle_XHandle = Selector.GetHandle ("setAttributedTitle:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetContentDirection_X = "setContentDirection:";
		static readonly NativeHandle selSetContentDirection_XHandle = Selector.GetHandle ("setContentDirection:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetContentFrame_X = "setContentFrame:";
		static readonly NativeHandle selSetContentFrame_XHandle = Selector.GetHandle ("setContentFrame:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetSeries_X = "setSeries:";
		static readonly NativeHandle selSetSeries_XHandle = Selector.GetHandle ("setSeries:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetSummary_X = "setSummary:";
		static readonly NativeHandle selSetSummary_XHandle = Selector.GetHandle ("setSummary:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetTitle_X = "setTitle:";
		static readonly NativeHandle selSetTitle_XHandle = Selector.GetHandle ("setTitle:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetXAxis_X = "setXAxis:";
		static readonly NativeHandle selSetXAxis_XHandle = Selector.GetHandle ("setXAxis:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetYAxis_X = "setYAxis:";
		static readonly NativeHandle selSetYAxis_XHandle = Selector.GetHandle ("setYAxis:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSummaryX = "summary";
		static readonly NativeHandle selSummaryXHandle = Selector.GetHandle ("summary");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selTitleX = "title";
		static readonly NativeHandle selTitleXHandle = Selector.GetHandle ("title");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selXAxisX = "xAxis";
		static readonly NativeHandle selXAxisXHandle = Selector.GetHandle ("xAxis");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selYAxisX = "yAxis";
		static readonly NativeHandle selYAxisXHandle = Selector.GetHandle ("yAxis");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly NativeHandle class_ptr = Class.GetHandle ("AXChartDescriptor");
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
		protected AXChartDescriptor (NSObjectFlag t) : base (t)
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
		protected internal AXChartDescriptor (NativeHandle handle) : base (handle)
		{
		}

		[Export ("initWithTitle:summary:xAxisDescriptor:yAxisDescriptor:series:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public AXChartDescriptor (string? title, string? summary, IAXDataAxisDescriptor xAxis, AXNumericDataAxisDescriptor? yAxis, AXDataSeriesDescriptor[] series)
			: base (NSObjectFlag.Empty)
		{
			var xAxis__handle__ = xAxis!.GetNonNullHandle (nameof (xAxis));
			var yAxis__handle__ = yAxis.GetHandle ();
			if (series is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (series));
			var nstitle = CFString.CreateNative (title);
			var nssummary = CFString.CreateNative (summary);
			using var nsa_series = NSArray.FromNSObjects (series);
			if (IsDirectBinding) {
				InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle_NativeHandle_NativeHandle (this.Handle, selInitWithTitle_Summary_XAxisDescriptor_YAxisDescriptor_Series_XHandle, nstitle, nssummary, xAxis__handle__, yAxis__handle__, nsa_series.Handle), "initWithTitle:summary:xAxisDescriptor:yAxisDescriptor:series:");
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_NativeHandle_NativeHandle_NativeHandle_NativeHandle (&__objc_super__, selInitWithTitle_Summary_XAxisDescriptor_YAxisDescriptor_Series_XHandle, nstitle, nssummary, xAxis__handle__, yAxis__handle__, nsa_series.Handle), "initWithTitle:summary:xAxisDescriptor:yAxisDescriptor:series:");
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (xAxis);
			GC.KeepAlive (yAxis);
			CFString.ReleaseNative (nstitle);
			CFString.ReleaseNative (nssummary);
		}
		[Export ("initWithAttributedTitle:summary:xAxisDescriptor:yAxisDescriptor:series:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public AXChartDescriptor (NSAttributedString? attributedTitle, string? summary, IAXDataAxisDescriptor xAxis, AXNumericDataAxisDescriptor yAxis, AXDataSeriesDescriptor[] series)
			: base (NSObjectFlag.Empty)
		{
			var attributedTitle__handle__ = attributedTitle.GetHandle ();
			var xAxis__handle__ = xAxis!.GetNonNullHandle (nameof (xAxis));
			var yAxis__handle__ = yAxis!.GetNonNullHandle (nameof (yAxis));
			if (series is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (series));
			var nssummary = CFString.CreateNative (summary);
			using var nsa_series = NSArray.FromNSObjects (series);
			if (IsDirectBinding) {
				InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle_NativeHandle_NativeHandle (this.Handle, selInitWithAttributedTitle_Summary_XAxisDescriptor_YAxisDescriptor_Series_XHandle, attributedTitle__handle__, nssummary, xAxis__handle__, yAxis__handle__, nsa_series.Handle), "initWithAttributedTitle:summary:xAxisDescriptor:yAxisDescriptor:series:");
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_NativeHandle_NativeHandle_NativeHandle_NativeHandle (&__objc_super__, selInitWithAttributedTitle_Summary_XAxisDescriptor_YAxisDescriptor_Series_XHandle, attributedTitle__handle__, nssummary, xAxis__handle__, yAxis__handle__, nsa_series.Handle), "initWithAttributedTitle:summary:xAxisDescriptor:yAxisDescriptor:series:");
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (attributedTitle);
			GC.KeepAlive (xAxis);
			GC.KeepAlive (yAxis);
			CFString.ReleaseNative (nssummary);
		}
		[Export ("initWithTitle:summary:xAxisDescriptor:yAxisDescriptor:additionalAxes:series:")]
		[DesignatedInitializer]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public AXChartDescriptor (string? title, string? summary, IAXDataAxisDescriptor xAxis, AXNumericDataAxisDescriptor? yAxis, IAXDataAxisDescriptor[]? additionalAxes, AXDataSeriesDescriptor[] series)
			: base (NSObjectFlag.Empty)
		{
			var xAxis__handle__ = xAxis!.GetNonNullHandle (nameof (xAxis));
			var yAxis__handle__ = yAxis.GetHandle ();
			if (series is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (series));
			var nstitle = CFString.CreateNative (title);
			var nssummary = CFString.CreateNative (summary);
			using var nsa_additionalAxes = additionalAxes is null ? null : NSArray.FromNSObjects (additionalAxes);
			using var nsa_series = NSArray.FromNSObjects (series);
			if (IsDirectBinding) {
				InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle_NativeHandle_NativeHandle_NativeHandle (this.Handle, selInitWithTitle_Summary_XAxisDescriptor_YAxisDescriptor_AdditionalAxes_Series_XHandle, nstitle, nssummary, xAxis__handle__, yAxis__handle__, nsa_additionalAxes.GetHandle (), nsa_series.Handle), "initWithTitle:summary:xAxisDescriptor:yAxisDescriptor:additionalAxes:series:");
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_NativeHandle_NativeHandle_NativeHandle_NativeHandle_NativeHandle (&__objc_super__, selInitWithTitle_Summary_XAxisDescriptor_YAxisDescriptor_AdditionalAxes_Series_XHandle, nstitle, nssummary, xAxis__handle__, yAxis__handle__, nsa_additionalAxes.GetHandle (), nsa_series.Handle), "initWithTitle:summary:xAxisDescriptor:yAxisDescriptor:additionalAxes:series:");
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (xAxis);
			GC.KeepAlive (yAxis);
			CFString.ReleaseNative (nstitle);
			CFString.ReleaseNative (nssummary);
		}
		[Export ("initWithAttributedTitle:summary:xAxisDescriptor:yAxisDescriptor:additionalAxes:series:")]
		[DesignatedInitializer]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public AXChartDescriptor (NSAttributedString? attributedTitle, string? summary, IAXDataAxisDescriptor xAxis, AXNumericDataAxisDescriptor? yAxis, IAXDataAxisDescriptor[]? additionalAxes, AXDataSeriesDescriptor[] series)
			: base (NSObjectFlag.Empty)
		{
			var attributedTitle__handle__ = attributedTitle.GetHandle ();
			var xAxis__handle__ = xAxis!.GetNonNullHandle (nameof (xAxis));
			var yAxis__handle__ = yAxis.GetHandle ();
			if (series is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (series));
			var nssummary = CFString.CreateNative (summary);
			using var nsa_additionalAxes = additionalAxes is null ? null : NSArray.FromNSObjects (additionalAxes);
			using var nsa_series = NSArray.FromNSObjects (series);
			if (IsDirectBinding) {
				InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle_NativeHandle_NativeHandle_NativeHandle (this.Handle, selInitWithAttributedTitle_Summary_XAxisDescriptor_YAxisDescriptor_AdditionalAxes_Series_XHandle, attributedTitle__handle__, nssummary, xAxis__handle__, yAxis__handle__, nsa_additionalAxes.GetHandle (), nsa_series.Handle), "initWithAttributedTitle:summary:xAxisDescriptor:yAxisDescriptor:additionalAxes:series:");
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_NativeHandle_NativeHandle_NativeHandle_NativeHandle_NativeHandle (&__objc_super__, selInitWithAttributedTitle_Summary_XAxisDescriptor_YAxisDescriptor_AdditionalAxes_Series_XHandle, attributedTitle__handle__, nssummary, xAxis__handle__, yAxis__handle__, nsa_additionalAxes.GetHandle (), nsa_series.Handle), "initWithAttributedTitle:summary:xAxisDescriptor:yAxisDescriptor:additionalAxes:series:");
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (attributedTitle);
			GC.KeepAlive (xAxis);
			GC.KeepAlive (yAxis);
			CFString.ReleaseNative (nssummary);
		}
		/// <param name="zone">Developers should pass <see langword="null" />.  Memory zones are no longer used.</param><summary>Performs a copy of the underlying Objective-C object.</summary><returns>The newly-allocated object.</returns><remarks><para>This method performs a "shallow copy" of <see langword="this" />. If this object contains references to external objects, the new object will contain references to the same object.</para></remarks>
		[Export ("copyWithZone:")]
		[return: ReleaseAttribute ()]
		[SupportedOSPlatform ("ios15.0")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos15.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSObject Copy (NSZone? zone)
		{
			var zone__handle__ = zone.GetHandle ();
			NSObject? ret;
			if (IsDirectBinding) {
				ret = Runtime.GetNSObject (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, selCopyWithZone_XHandle, zone__handle__), true)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = Runtime.GetNSObject (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle (&__objc_super__, selCopyWithZone_XHandle, zone__handle__), true)!;
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (zone);
			return ret!;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual IAXDataAxisDescriptor[]? AdditionalAxes {
			[Export ("additionalAxes", ArgumentSemantic.Copy)]
			get {
				IAXDataAxisDescriptor[]? ret;
				if (IsDirectBinding) {
					ret = CFArray.ArrayFromHandle<IAXDataAxisDescriptor>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selAdditionalAxesXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFArray.ArrayFromHandle<IAXDataAxisDescriptor>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selAdditionalAxesXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setAdditionalAxes:", ArgumentSemantic.Copy)]
			set {
				using var nsa_value = value is null ? null : NSArray.FromNSObjects (value);
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selSetAdditionalAxes_XHandle, nsa_value.GetHandle ());
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selSetAdditionalAxes_XHandle, nsa_value.GetHandle ());
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSAttributedString? AttributedTitle {
			[Export ("attributedTitle", ArgumentSemantic.Copy)]
			get {
				NSAttributedString? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSAttributedString> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selAttributedTitleXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<NSAttributedString> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selAttributedTitleXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setAttributedTitle:", ArgumentSemantic.Copy)]
			set {
				var value__handle__ = value.GetHandle ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selSetAttributedTitle_XHandle, value__handle__);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selSetAttributedTitle_XHandle, value__handle__);
						GC.KeepAlive (this);
					}
				}
				GC.KeepAlive (value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual AXChartDescriptorContentDirection ContentDirection {
			[Export ("contentDirection", ArgumentSemantic.Assign)]
			get {
				AXChartDescriptorContentDirection ret;
				if (IsDirectBinding) {
					ret = (Accessibility.AXChartDescriptorContentDirection) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selContentDirectionXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = (Accessibility.AXChartDescriptorContentDirection) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (&__objc_super__, selContentDirectionXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setContentDirection:", ArgumentSemantic.Assign)]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetContentDirection_XHandle, (IntPtr) (long) value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (&__objc_super__, selSetContentDirection_XHandle, (IntPtr) (long) value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual CGRect ContentFrame {
			[Export ("contentFrame", ArgumentSemantic.Assign)]
			get {
				CGRect ret;
				if (IsDirectBinding) {
					if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
						ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSend (this.Handle, selContentFrameXHandle);
					} else {
						ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSend_stret (this.Handle, selContentFrameXHandle);
					}
				} else {
					if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
						unsafe {
							var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
							ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSendSuper (&__objc_super__, selContentFrameXHandle);
							GC.KeepAlive (this);
						}
					} else {
						unsafe {
							var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
							ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSendSuper_stret (&__objc_super__, selContentFrameXHandle);
							GC.KeepAlive (this);
						}
					}
				}
				return ret!;
			}
			[Export ("setContentFrame:", ArgumentSemantic.Assign)]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_CGRect (this.Handle, selSetContentFrame_XHandle, value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_CGRect (&__objc_super__, selSetContentFrame_XHandle, value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual AXDataSeriesDescriptor[] Series {
			[Export ("series", ArgumentSemantic.Copy)]
			get {
				AXDataSeriesDescriptor[]? ret;
				if (IsDirectBinding) {
					ret = CFArray.ArrayFromHandle<AXDataSeriesDescriptor>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selSeriesXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFArray.ArrayFromHandle<AXDataSeriesDescriptor>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selSeriesXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setSeries:", ArgumentSemantic.Copy)]
			set {
				if (value is null)
					ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (value));
				using var nsa_value = NSArray.FromNSObjects (value);
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selSetSeries_XHandle, nsa_value.Handle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selSetSeries_XHandle, nsa_value.Handle);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string? Summary {
			[Export ("summary")]
			get {
				string ret;
				if (IsDirectBinding) {
					ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selSummaryXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selSummaryXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[Export ("setSummary:")]
			set {
				var nsvalue = CFString.CreateNative (value);
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selSetSummary_XHandle, nsvalue);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selSetSummary_XHandle, nsvalue);
						GC.KeepAlive (this);
					}
				}
				CFString.ReleaseNative (nsvalue);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string? Title {
			[Export ("title")]
			get {
				string ret;
				if (IsDirectBinding) {
					ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selTitleXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selTitleXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[Export ("setTitle:")]
			set {
				var nsvalue = CFString.CreateNative (value);
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selSetTitle_XHandle, nsvalue);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selSetTitle_XHandle, nsvalue);
						GC.KeepAlive (this);
					}
				}
				CFString.ReleaseNative (nsvalue);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual IAXDataAxisDescriptor XAxis {
			[Export ("xAxis", ArgumentSemantic.Retain)]
			get {
				IAXDataAxisDescriptor? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetINativeObject<IAXDataAxisDescriptor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selXAxisXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetINativeObject<IAXDataAxisDescriptor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selXAxisXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setXAxis:", ArgumentSemantic.Retain)]
			set {
				var value__handle__ = value!.GetNonNullHandle (nameof (value));
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selSetXAxis_XHandle, value__handle__);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selSetXAxis_XHandle, value__handle__);
						GC.KeepAlive (this);
					}
				}
				GC.KeepAlive (value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual AXNumericDataAxisDescriptor? YAxis {
			[Export ("yAxis", ArgumentSemantic.Retain)]
			get {
				AXNumericDataAxisDescriptor? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<AXNumericDataAxisDescriptor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selYAxisXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<AXNumericDataAxisDescriptor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selYAxisXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setYAxis:", ArgumentSemantic.Retain)]
			set {
				var value__handle__ = value.GetHandle ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selSetYAxis_XHandle, value__handle__);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selSetYAxis_XHandle, value__handle__);
						GC.KeepAlive (this);
					}
				}
				GC.KeepAlive (value);
			}
		}
	} /* class AXChartDescriptor */
}
