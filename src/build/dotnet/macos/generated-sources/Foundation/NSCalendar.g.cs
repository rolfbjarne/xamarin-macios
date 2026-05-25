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
	[Register("NSCalendar", true)]
	public unsafe partial class NSCalendar : NSObject, INSCoding, INSCopying, INSSecureCoding {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAMSymbolX = "AMSymbol";
		static readonly NativeHandle selAMSymbolXHandle = Selector.GetHandle ("AMSymbol");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selPMSymbolX = "PMSymbol";
		static readonly NativeHandle selPMSymbolXHandle = Selector.GetHandle ("PMSymbol");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selCalendarIdentifierX = "calendarIdentifier";
		static readonly NativeHandle selCalendarIdentifierXHandle = Selector.GetHandle ("calendarIdentifier");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selCompareDate_ToDate_ToUnitGranularity_X = "compareDate:toDate:toUnitGranularity:";
		static readonly NativeHandle selCompareDate_ToDate_ToUnitGranularity_XHandle = Selector.GetHandle ("compareDate:toDate:toUnitGranularity:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selComponent_FromDate_X = "component:fromDate:";
		static readonly NativeHandle selComponent_FromDate_XHandle = Selector.GetHandle ("component:fromDate:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selComponents_FromDate_X = "components:fromDate:";
		static readonly NativeHandle selComponents_FromDate_XHandle = Selector.GetHandle ("components:fromDate:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selComponents_FromDate_ToDate_Options_X = "components:fromDate:toDate:options:";
		static readonly NativeHandle selComponents_FromDate_ToDate_Options_XHandle = Selector.GetHandle ("components:fromDate:toDate:options:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selComponents_FromDateComponents_ToDateComponents_Options_X = "components:fromDateComponents:toDateComponents:options:";
		static readonly NativeHandle selComponents_FromDateComponents_ToDateComponents_Options_XHandle = Selector.GetHandle ("components:fromDateComponents:toDateComponents:options:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selComponentsInTimeZone_FromDate_X = "componentsInTimeZone:fromDate:";
		static readonly NativeHandle selComponentsInTimeZone_FromDate_XHandle = Selector.GetHandle ("componentsInTimeZone:fromDate:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selCopyWithZone_X = "copyWithZone:";
		static readonly NativeHandle selCopyWithZone_XHandle = Selector.GetHandle ("copyWithZone:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selCurrentCalendarX = "currentCalendar";
		static readonly NativeHandle selCurrentCalendarXHandle = Selector.GetHandle ("currentCalendar");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selDate_MatchesComponents_X = "date:matchesComponents:";
		static readonly NativeHandle selDate_MatchesComponents_XHandle = Selector.GetHandle ("date:matchesComponents:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selDateByAddingComponents_ToDate_Options_X = "dateByAddingComponents:toDate:options:";
		static readonly NativeHandle selDateByAddingComponents_ToDate_Options_XHandle = Selector.GetHandle ("dateByAddingComponents:toDate:options:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selDateByAddingUnit_Value_ToDate_Options_X = "dateByAddingUnit:value:toDate:options:";
		static readonly NativeHandle selDateByAddingUnit_Value_ToDate_Options_XHandle = Selector.GetHandle ("dateByAddingUnit:value:toDate:options:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selDateBySettingHour_Minute_Second_OfDate_Options_X = "dateBySettingHour:minute:second:ofDate:options:";
		static readonly NativeHandle selDateBySettingHour_Minute_Second_OfDate_Options_XHandle = Selector.GetHandle ("dateBySettingHour:minute:second:ofDate:options:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selDateBySettingUnit_Value_OfDate_Options_X = "dateBySettingUnit:value:ofDate:options:";
		static readonly NativeHandle selDateBySettingUnit_Value_OfDate_Options_XHandle = Selector.GetHandle ("dateBySettingUnit:value:ofDate:options:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selDateFromComponents_X = "dateFromComponents:";
		static readonly NativeHandle selDateFromComponents_XHandle = Selector.GetHandle ("dateFromComponents:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selDateWithEra_Year_Month_Day_Hour_Minute_Second_Nanosecond_X = "dateWithEra:year:month:day:hour:minute:second:nanosecond:";
		static readonly NativeHandle selDateWithEra_Year_Month_Day_Hour_Minute_Second_Nanosecond_XHandle = Selector.GetHandle ("dateWithEra:year:month:day:hour:minute:second:nanosecond:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selDateWithEra_YearForWeekOfYear_WeekOfYear_Weekday_Hour_Minute_Second_Nanosecond_X = "dateWithEra:yearForWeekOfYear:weekOfYear:weekday:hour:minute:second:nanosecond:";
		static readonly NativeHandle selDateWithEra_YearForWeekOfYear_WeekOfYear_Weekday_Hour_Minute_Second_Nanosecond_XHandle = Selector.GetHandle ("dateWithEra:yearForWeekOfYear:weekOfYear:weekday:hour:minute:second:nanosecond:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selEncodeWithCoder_X = "encodeWithCoder:";
		static readonly NativeHandle selEncodeWithCoder_XHandle = Selector.GetHandle ("encodeWithCoder:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selEnumerateDatesStartingAfterDate_MatchingComponents_Options_UsingBlock_X = "enumerateDatesStartingAfterDate:matchingComponents:options:usingBlock:";
		static readonly NativeHandle selEnumerateDatesStartingAfterDate_MatchingComponents_Options_UsingBlock_XHandle = Selector.GetHandle ("enumerateDatesStartingAfterDate:matchingComponents:options:usingBlock:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selEraSymbolsX = "eraSymbols";
		static readonly NativeHandle selEraSymbolsXHandle = Selector.GetHandle ("eraSymbols");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selFirstWeekdayX = "firstWeekday";
		static readonly NativeHandle selFirstWeekdayXHandle = Selector.GetHandle ("firstWeekday");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selGetEra_Year_Month_Day_FromDate_X = "getEra:year:month:day:fromDate:";
		static readonly NativeHandle selGetEra_Year_Month_Day_FromDate_XHandle = Selector.GetHandle ("getEra:year:month:day:fromDate:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selGetEra_YearForWeekOfYear_WeekOfYear_Weekday_FromDate_X = "getEra:yearForWeekOfYear:weekOfYear:weekday:fromDate:";
		static readonly NativeHandle selGetEra_YearForWeekOfYear_WeekOfYear_Weekday_FromDate_XHandle = Selector.GetHandle ("getEra:yearForWeekOfYear:weekOfYear:weekday:fromDate:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selGetHour_Minute_Second_Nanosecond_FromDate_X = "getHour:minute:second:nanosecond:fromDate:";
		static readonly NativeHandle selGetHour_Minute_Second_Nanosecond_FromDate_XHandle = Selector.GetHandle ("getHour:minute:second:nanosecond:fromDate:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selInitWithCalendarIdentifier_X = "initWithCalendarIdentifier:";
		static readonly NativeHandle selInitWithCalendarIdentifier_XHandle = Selector.GetHandle ("initWithCalendarIdentifier:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selInitWithCoder_X = "initWithCoder:";
		static readonly NativeHandle selInitWithCoder_XHandle = Selector.GetHandle ("initWithCoder:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selIsDate_EqualToDate_ToUnitGranularity_X = "isDate:equalToDate:toUnitGranularity:";
		static readonly NativeHandle selIsDate_EqualToDate_ToUnitGranularity_XHandle = Selector.GetHandle ("isDate:equalToDate:toUnitGranularity:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selIsDate_InSameDayAsDate_X = "isDate:inSameDayAsDate:";
		static readonly NativeHandle selIsDate_InSameDayAsDate_XHandle = Selector.GetHandle ("isDate:inSameDayAsDate:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selIsDateInToday_X = "isDateInToday:";
		static readonly NativeHandle selIsDateInToday_XHandle = Selector.GetHandle ("isDateInToday:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selIsDateInTomorrow_X = "isDateInTomorrow:";
		static readonly NativeHandle selIsDateInTomorrow_XHandle = Selector.GetHandle ("isDateInTomorrow:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selIsDateInWeekend_X = "isDateInWeekend:";
		static readonly NativeHandle selIsDateInWeekend_XHandle = Selector.GetHandle ("isDateInWeekend:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selIsDateInYesterday_X = "isDateInYesterday:";
		static readonly NativeHandle selIsDateInYesterday_XHandle = Selector.GetHandle ("isDateInYesterday:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selLocaleX = "locale";
		static readonly NativeHandle selLocaleXHandle = Selector.GetHandle ("locale");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selLongEraSymbolsX = "longEraSymbols";
		static readonly NativeHandle selLongEraSymbolsXHandle = Selector.GetHandle ("longEraSymbols");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selMaximumRangeOfUnit_X = "maximumRangeOfUnit:";
		static readonly NativeHandle selMaximumRangeOfUnit_XHandle = Selector.GetHandle ("maximumRangeOfUnit:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selMinimumDaysInFirstWeekX = "minimumDaysInFirstWeek";
		static readonly NativeHandle selMinimumDaysInFirstWeekXHandle = Selector.GetHandle ("minimumDaysInFirstWeek");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selMinimumRangeOfUnit_X = "minimumRangeOfUnit:";
		static readonly NativeHandle selMinimumRangeOfUnit_XHandle = Selector.GetHandle ("minimumRangeOfUnit:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selMonthSymbolsX = "monthSymbols";
		static readonly NativeHandle selMonthSymbolsXHandle = Selector.GetHandle ("monthSymbols");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selNextDateAfterDate_MatchingComponents_Options_X = "nextDateAfterDate:matchingComponents:options:";
		static readonly NativeHandle selNextDateAfterDate_MatchingComponents_Options_XHandle = Selector.GetHandle ("nextDateAfterDate:matchingComponents:options:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selNextDateAfterDate_MatchingHour_Minute_Second_Options_X = "nextDateAfterDate:matchingHour:minute:second:options:";
		static readonly NativeHandle selNextDateAfterDate_MatchingHour_Minute_Second_Options_XHandle = Selector.GetHandle ("nextDateAfterDate:matchingHour:minute:second:options:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selNextDateAfterDate_MatchingUnit_Value_Options_X = "nextDateAfterDate:matchingUnit:value:options:";
		static readonly NativeHandle selNextDateAfterDate_MatchingUnit_Value_Options_XHandle = Selector.GetHandle ("nextDateAfterDate:matchingUnit:value:options:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selNextWeekendStartDate_Interval_Options_AfterDate_X = "nextWeekendStartDate:interval:options:afterDate:";
		static readonly NativeHandle selNextWeekendStartDate_Interval_Options_AfterDate_XHandle = Selector.GetHandle ("nextWeekendStartDate:interval:options:afterDate:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selOrdinalityOfUnit_InUnit_ForDate_X = "ordinalityOfUnit:inUnit:forDate:";
		static readonly NativeHandle selOrdinalityOfUnit_InUnit_ForDate_XHandle = Selector.GetHandle ("ordinalityOfUnit:inUnit:forDate:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selQuarterSymbolsX = "quarterSymbols";
		static readonly NativeHandle selQuarterSymbolsXHandle = Selector.GetHandle ("quarterSymbols");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selRangeOfUnit_InUnit_ForDate_X = "rangeOfUnit:inUnit:forDate:";
		static readonly NativeHandle selRangeOfUnit_InUnit_ForDate_XHandle = Selector.GetHandle ("rangeOfUnit:inUnit:forDate:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selRangeOfUnit_StartDate_Interval_ForDate_X = "rangeOfUnit:startDate:interval:forDate:";
		static readonly NativeHandle selRangeOfUnit_StartDate_Interval_ForDate_XHandle = Selector.GetHandle ("rangeOfUnit:startDate:interval:forDate:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selRangeOfWeekendStartDate_Interval_ContainingDate_X = "rangeOfWeekendStartDate:interval:containingDate:";
		static readonly NativeHandle selRangeOfWeekendStartDate_Interval_ContainingDate_XHandle = Selector.GetHandle ("rangeOfWeekendStartDate:interval:containingDate:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetFirstWeekday_X = "setFirstWeekday:";
		static readonly NativeHandle selSetFirstWeekday_XHandle = Selector.GetHandle ("setFirstWeekday:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetLocale_X = "setLocale:";
		static readonly NativeHandle selSetLocale_XHandle = Selector.GetHandle ("setLocale:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetMinimumDaysInFirstWeek_X = "setMinimumDaysInFirstWeek:";
		static readonly NativeHandle selSetMinimumDaysInFirstWeek_XHandle = Selector.GetHandle ("setMinimumDaysInFirstWeek:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetTimeZone_X = "setTimeZone:";
		static readonly NativeHandle selSetTimeZone_XHandle = Selector.GetHandle ("setTimeZone:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selShortMonthSymbolsX = "shortMonthSymbols";
		static readonly NativeHandle selShortMonthSymbolsXHandle = Selector.GetHandle ("shortMonthSymbols");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selShortQuarterSymbolsX = "shortQuarterSymbols";
		static readonly NativeHandle selShortQuarterSymbolsXHandle = Selector.GetHandle ("shortQuarterSymbols");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selShortStandaloneMonthSymbolsX = "shortStandaloneMonthSymbols";
		static readonly NativeHandle selShortStandaloneMonthSymbolsXHandle = Selector.GetHandle ("shortStandaloneMonthSymbols");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selShortStandaloneQuarterSymbolsX = "shortStandaloneQuarterSymbols";
		static readonly NativeHandle selShortStandaloneQuarterSymbolsXHandle = Selector.GetHandle ("shortStandaloneQuarterSymbols");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selShortStandaloneWeekdaySymbolsX = "shortStandaloneWeekdaySymbols";
		static readonly NativeHandle selShortStandaloneWeekdaySymbolsXHandle = Selector.GetHandle ("shortStandaloneWeekdaySymbols");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selShortWeekdaySymbolsX = "shortWeekdaySymbols";
		static readonly NativeHandle selShortWeekdaySymbolsXHandle = Selector.GetHandle ("shortWeekdaySymbols");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selStandaloneMonthSymbolsX = "standaloneMonthSymbols";
		static readonly NativeHandle selStandaloneMonthSymbolsXHandle = Selector.GetHandle ("standaloneMonthSymbols");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selStandaloneQuarterSymbolsX = "standaloneQuarterSymbols";
		static readonly NativeHandle selStandaloneQuarterSymbolsXHandle = Selector.GetHandle ("standaloneQuarterSymbols");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selStandaloneWeekdaySymbolsX = "standaloneWeekdaySymbols";
		static readonly NativeHandle selStandaloneWeekdaySymbolsXHandle = Selector.GetHandle ("standaloneWeekdaySymbols");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selStartOfDayForDate_X = "startOfDayForDate:";
		static readonly NativeHandle selStartOfDayForDate_XHandle = Selector.GetHandle ("startOfDayForDate:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selTimeZoneX = "timeZone";
		static readonly NativeHandle selTimeZoneXHandle = Selector.GetHandle ("timeZone");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selVeryShortMonthSymbolsX = "veryShortMonthSymbols";
		static readonly NativeHandle selVeryShortMonthSymbolsXHandle = Selector.GetHandle ("veryShortMonthSymbols");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selVeryShortStandaloneMonthSymbolsX = "veryShortStandaloneMonthSymbols";
		static readonly NativeHandle selVeryShortStandaloneMonthSymbolsXHandle = Selector.GetHandle ("veryShortStandaloneMonthSymbols");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selVeryShortStandaloneWeekdaySymbolsX = "veryShortStandaloneWeekdaySymbols";
		static readonly NativeHandle selVeryShortStandaloneWeekdaySymbolsXHandle = Selector.GetHandle ("veryShortStandaloneWeekdaySymbols");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selVeryShortWeekdaySymbolsX = "veryShortWeekdaySymbols";
		static readonly NativeHandle selVeryShortWeekdaySymbolsXHandle = Selector.GetHandle ("veryShortWeekdaySymbols");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selWeekdaySymbolsX = "weekdaySymbols";
		static readonly NativeHandle selWeekdaySymbolsXHandle = Selector.GetHandle ("weekdaySymbols");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly NativeHandle class_ptr = Class.GetHandle ("NSCalendar");
		/// <summary>The Objective-C class handle for this class.</summary>
		/// <value>The pointer to the Objective-C class.</value>
		/// <remarks>
		///     Each managed class mirrors an unmanaged Objective-C class.
		///     This value contains the pointer to the Objective-C class.
		///     It is similar to calling the managed <see cref="ObjCRuntime.Class.GetHandle(string)" /> or the native <see href="https://developer.apple.com/documentation/objectivec/1418952-objc_getclass">objc_getClass</see> method with the type name.
		/// </remarks>
		public override NativeHandle ClassHandle { get { return class_ptr; } }
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
		public NSCalendar (NSCoder coder) : base (NSObjectFlag.Empty)
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
		protected NSCalendar (NSObjectFlag t) : base (t)
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
		protected internal NSCalendar (NativeHandle handle) : base (handle)
		{
		}

		[Export ("initWithCalendarIdentifier:")]
		[DesignatedInitializer]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public NSCalendar (NSString identifier)
			: base (NSObjectFlag.Empty)
		{
			var identifier__handle__ = identifier!.GetNonNullHandle (nameof (identifier));
			if (IsDirectBinding) {
				InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, selInitWithCalendarIdentifier_XHandle, identifier__handle__), "initWithCalendarIdentifier:");
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle (&__objc_super__, selInitWithCalendarIdentifier_XHandle, identifier__handle__), "initWithCalendarIdentifier:");
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (identifier);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public NSCalendar (NSCalendarType calendarType)
			: this (calendarType.GetConstant ()!)
		{
		}
		[Export ("compareDate:toDate:toUnitGranularity:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSComparisonResult CompareDate (NSDate date1, NSDate date2, NSCalendarUnit granularity)
		{
			var date1__handle__ = date1!.GetNonNullHandle (nameof (date1));
			var date2__handle__ = date2!.GetNonNullHandle (nameof (date2));
			NSComparisonResult ret;
			if (IsDirectBinding) {
				ret = (NSComparisonResult) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSend_NativeHandle_NativeHandle_UIntPtr (this.Handle, selCompareDate_ToDate_ToUnitGranularity_XHandle, date1__handle__, date2__handle__, (UIntPtr) (ulong) granularity);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = (NSComparisonResult) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper_NativeHandle_NativeHandle_UIntPtr (&__objc_super__, selCompareDate_ToDate_ToUnitGranularity_XHandle, date1__handle__, date2__handle__, (UIntPtr) (ulong) granularity);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (date1);
			GC.KeepAlive (date2);
			return ret!;
		}
		[Export ("components:fromDate:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSDateComponents Components (NSCalendarUnit unitFlags, NSDate fromDate)
		{
			var fromDate__handle__ = fromDate!.GetNonNullHandle (nameof (fromDate));
			NSDateComponents? ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<NSDateComponents> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_UIntPtr_NativeHandle (this.Handle, selComponents_FromDate_XHandle, (UIntPtr) (ulong) unitFlags, fromDate__handle__), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<NSDateComponents> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_UIntPtr_NativeHandle (&__objc_super__, selComponents_FromDate_XHandle, (UIntPtr) (ulong) unitFlags, fromDate__handle__), false)!;
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (fromDate);
			return ret!;
		}
		[Export ("components:fromDate:toDate:options:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSDateComponents Components (NSCalendarUnit unitFlags, NSDate fromDate, NSDate toDate, NSCalendarOptions opts)
		{
			var fromDate__handle__ = fromDate!.GetNonNullHandle (nameof (fromDate));
			var toDate__handle__ = toDate!.GetNonNullHandle (nameof (toDate));
			NSDateComponents? ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<NSDateComponents> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_UIntPtr_NativeHandle_NativeHandle_UIntPtr (this.Handle, selComponents_FromDate_ToDate_Options_XHandle, (UIntPtr) (ulong) unitFlags, fromDate__handle__, toDate__handle__, (UIntPtr) (ulong) opts), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<NSDateComponents> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_UIntPtr_NativeHandle_NativeHandle_UIntPtr (&__objc_super__, selComponents_FromDate_ToDate_Options_XHandle, (UIntPtr) (ulong) unitFlags, fromDate__handle__, toDate__handle__, (UIntPtr) (ulong) opts), false)!;
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (fromDate);
			GC.KeepAlive (toDate);
			return ret!;
		}
		[Export ("components:fromDateComponents:toDateComponents:options:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSDateComponents ComponentsFromDateToDate (NSCalendarUnit unitFlags, NSDateComponents startingDate, NSDateComponents resultDate, NSCalendarOptions options)
		{
			var startingDate__handle__ = startingDate!.GetNonNullHandle (nameof (startingDate));
			var resultDate__handle__ = resultDate!.GetNonNullHandle (nameof (resultDate));
			NSDateComponents? ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<NSDateComponents> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_UIntPtr_NativeHandle_NativeHandle_UIntPtr (this.Handle, selComponents_FromDateComponents_ToDateComponents_Options_XHandle, (UIntPtr) (ulong) unitFlags, startingDate__handle__, resultDate__handle__, (UIntPtr) (ulong) options), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<NSDateComponents> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_UIntPtr_NativeHandle_NativeHandle_UIntPtr (&__objc_super__, selComponents_FromDateComponents_ToDateComponents_Options_XHandle, (UIntPtr) (ulong) unitFlags, startingDate__handle__, resultDate__handle__, (UIntPtr) (ulong) options), false)!;
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (startingDate);
			GC.KeepAlive (resultDate);
			return ret!;
		}
		[Export ("componentsInTimeZone:fromDate:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSDateComponents ComponentsInTimeZone (NSTimeZone timezone, NSDate date)
		{
			var timezone__handle__ = timezone!.GetNonNullHandle (nameof (timezone));
			var date__handle__ = date!.GetNonNullHandle (nameof (date));
			NSDateComponents? ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<NSDateComponents> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (this.Handle, selComponentsInTimeZone_FromDate_XHandle, timezone__handle__, date__handle__), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<NSDateComponents> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, selComponentsInTimeZone_FromDate_XHandle, timezone__handle__, date__handle__), false)!;
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (timezone);
			GC.KeepAlive (date);
			return ret!;
		}
		/// <param name="zone">Developers should pass <see langword="null" />.  Memory zones are no longer used.</param><summary>Performs a copy of the underlying Objective-C object.</summary><returns>The newly-allocated object.</returns><remarks><para>This method performs a "shallow copy" of <see langword="this" />. If this object contains references to external objects, the new object will contain references to the same object.</para></remarks>
		[Export ("copyWithZone:")]
		[return: ReleaseAttribute ()]
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
		/// <param name="era">To be added.</param><param name="year">To be added.</param><param name="month">To be added.</param><param name="date">To be added.</param><param name="hour">To be added.</param><param name="minute">To be added.</param><param name="second">To be added.</param><param name="nanosecond">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("dateWithEra:year:month:day:hour:minute:second:nanosecond:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSDate Date (nint era, nint year, nint month, nint date, nint hour, nint minute, nint second, nint nanosecond)
		{
			NSDate ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<NSDate> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_IntPtr_IntPtr_IntPtr_IntPtr_IntPtr_IntPtr_IntPtr_IntPtr (this.Handle, selDateWithEra_Year_Month_Day_Hour_Minute_Second_Nanosecond_XHandle, era, year, month, date, hour, minute, second, nanosecond), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<NSDate> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_IntPtr_IntPtr_IntPtr_IntPtr_IntPtr_IntPtr_IntPtr_IntPtr (&__objc_super__, selDateWithEra_Year_Month_Day_Hour_Minute_Second_Nanosecond_XHandle, era, year, month, date, hour, minute, second, nanosecond), false)!;
					GC.KeepAlive (this);
				}
			}
			return ret;
		}
		[Export ("dateByAddingComponents:toDate:options:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSDate DateByAddingComponents (NSDateComponents comps, NSDate date, NSCalendarOptions opts)
		{
			var comps__handle__ = comps!.GetNonNullHandle (nameof (comps));
			var date__handle__ = date!.GetNonNullHandle (nameof (date));
			NSDate? ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<NSDate> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_UIntPtr (this.Handle, selDateByAddingComponents_ToDate_Options_XHandle, comps__handle__, date__handle__, (UIntPtr) (ulong) opts), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<NSDate> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_NativeHandle_UIntPtr (&__objc_super__, selDateByAddingComponents_ToDate_Options_XHandle, comps__handle__, date__handle__, (UIntPtr) (ulong) opts), false)!;
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (comps);
			GC.KeepAlive (date);
			return ret!;
		}
		/// <param name="unit">To be added.</param><param name="value">To be added.</param><param name="date">To be added.</param><param name="options">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("dateByAddingUnit:value:toDate:options:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSDate DateByAddingUnit (NSCalendarUnit unit, nint value, NSDate date, NSCalendarOptions options)
		{
			var date__handle__ = date!.GetNonNullHandle (nameof (date));
			NSDate? ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<NSDate> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_UIntPtr_IntPtr_NativeHandle_UIntPtr (this.Handle, selDateByAddingUnit_Value_ToDate_Options_XHandle, (UIntPtr) (ulong) unit, value, date__handle__, (UIntPtr) (ulong) options), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<NSDate> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_UIntPtr_IntPtr_NativeHandle_UIntPtr (&__objc_super__, selDateByAddingUnit_Value_ToDate_Options_XHandle, (UIntPtr) (ulong) unit, value, date__handle__, (UIntPtr) (ulong) options), false)!;
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (date);
			return ret!;
		}
		/// <param name="unit">To be added.</param><param name="value">To be added.</param><param name="date">To be added.</param><param name="options">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("dateBySettingUnit:value:ofDate:options:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSDate DateBySettingUnit (NSCalendarUnit unit, nint value, NSDate date, NSCalendarOptions options)
		{
			var date__handle__ = date!.GetNonNullHandle (nameof (date));
			NSDate? ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<NSDate> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_UIntPtr_IntPtr_NativeHandle_UIntPtr (this.Handle, selDateBySettingUnit_Value_OfDate_Options_XHandle, (UIntPtr) (ulong) unit, value, date__handle__, (UIntPtr) (ulong) options), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<NSDate> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_UIntPtr_IntPtr_NativeHandle_UIntPtr (&__objc_super__, selDateBySettingUnit_Value_OfDate_Options_XHandle, (UIntPtr) (ulong) unit, value, date__handle__, (UIntPtr) (ulong) options), false)!;
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (date);
			return ret!;
		}
		/// <param name="hour">To be added.</param><param name="minute">To be added.</param><param name="second">To be added.</param><param name="date">To be added.</param><param name="options">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("dateBySettingHour:minute:second:ofDate:options:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSDate DateBySettingsHour (nint hour, nint minute, nint second, NSDate date, NSCalendarOptions options)
		{
			var date__handle__ = date!.GetNonNullHandle (nameof (date));
			NSDate? ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<NSDate> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_IntPtr_IntPtr_IntPtr_NativeHandle_UIntPtr (this.Handle, selDateBySettingHour_Minute_Second_OfDate_Options_XHandle, hour, minute, second, date__handle__, (UIntPtr) (ulong) options), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<NSDate> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_IntPtr_IntPtr_IntPtr_NativeHandle_UIntPtr (&__objc_super__, selDateBySettingHour_Minute_Second_OfDate_Options_XHandle, hour, minute, second, date__handle__, (UIntPtr) (ulong) options), false)!;
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (date);
			return ret!;
		}
		/// <param name="era">To be added.</param><param name="year">To be added.</param><param name="week">To be added.</param><param name="weekday">To be added.</param><param name="hour">To be added.</param><param name="minute">To be added.</param><param name="second">To be added.</param><param name="nanosecond">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("dateWithEra:yearForWeekOfYear:weekOfYear:weekday:hour:minute:second:nanosecond:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSDate DateForWeekOfYear (nint era, nint year, nint week, nint weekday, nint hour, nint minute, nint second, nint nanosecond)
		{
			NSDate ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<NSDate> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_IntPtr_IntPtr_IntPtr_IntPtr_IntPtr_IntPtr_IntPtr_IntPtr (this.Handle, selDateWithEra_YearForWeekOfYear_WeekOfYear_Weekday_Hour_Minute_Second_Nanosecond_XHandle, era, year, week, weekday, hour, minute, second, nanosecond), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<NSDate> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_IntPtr_IntPtr_IntPtr_IntPtr_IntPtr_IntPtr_IntPtr_IntPtr (&__objc_super__, selDateWithEra_YearForWeekOfYear_WeekOfYear_Weekday_Hour_Minute_Second_Nanosecond_XHandle, era, year, week, weekday, hour, minute, second, nanosecond), false)!;
					GC.KeepAlive (this);
				}
			}
			return ret;
		}
		[Export ("dateFromComponents:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSDate DateFromComponents (NSDateComponents comps)
		{
			var comps__handle__ = comps!.GetNonNullHandle (nameof (comps));
			NSDate? ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<NSDate> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, selDateFromComponents_XHandle, comps__handle__), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<NSDate> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle (&__objc_super__, selDateFromComponents_XHandle, comps__handle__), false)!;
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (comps);
			return ret!;
		}
		/// <summary>Encodes the state of the object using the provided encoder.</summary><param name="encoder">The encoder object where the state of the object will be stored</param><remarks><para>This method is part of the <see cref="T:Foundation.INSCoding" /> protocol and is used by applications to preserve the state of the object into an archive.</para><para>Developers will typically create an <see cref="T:Foundation.NSKeyedArchiver" /> and then invoke the <see cref="M:Foundation.NSKeyedArchiver.ArchiveRootObjectToFile(Foundation.NSObject,System.String)" /> method which will call into this method.</para><para>If developers want to allow their object to be archived, they should override this method and store their state in using the provided <paramref name="encoder" /> parameter. In addition, developers should also implement a constructor that takes an NSCoder argument and is exported with <c>[Export ("initWithCoder:")]</c>.</para><example><code lang="csharp lang-csharp"><![CDATA[public void override EncodeTo (NSCoder coder) {
		/// coder.Encode (1, key: "version");
		/// coder.Encode (userName, key: "userName");
		/// coder.Encode (hostName, key: "hostName");]]></code></example></remarks>
		[Export ("encodeWithCoder:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void EncodeTo (NSCoder encoder)
		{
			var encoder__handle__ = encoder!.GetNonNullHandle (nameof (encoder));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selEncodeWithCoder_XHandle, encoder__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selEncodeWithCoder_XHandle, encoder__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (encoder);
		}
		[Export ("enumerateDatesStartingAfterDate:matchingComponents:options:usingBlock:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void EnumerateDatesStartingAfterDate (NSDate start, NSDateComponents matchingComponents, NSCalendarOptions options, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDEnumerateDatesCallback))]EnumerateDatesCallback callback)
		{
			var start__handle__ = start!.GetNonNullHandle (nameof (start));
			var matchingComponents__handle__ = matchingComponents!.GetNonNullHandle (nameof (matchingComponents));
			if (callback is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (callback));
			using var block_callback = Trampolines.SDEnumerateDatesCallback.CreateBlock (callback);
			BlockLiteral *block_ptr_callback = &block_callback;
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_UIntPtr_NativeHandle (this.Handle, selEnumerateDatesStartingAfterDate_MatchingComponents_Options_UsingBlock_XHandle, start__handle__, matchingComponents__handle__, (UIntPtr) (ulong) options, (IntPtr) block_ptr_callback);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_NativeHandle_UIntPtr_NativeHandle (&__objc_super__, selEnumerateDatesStartingAfterDate_MatchingComponents_Options_UsingBlock_XHandle, start__handle__, matchingComponents__handle__, (UIntPtr) (ulong) options, (IntPtr) block_ptr_callback);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (start);
			GC.KeepAlive (matchingComponents);
		}
		[Export ("nextDateAfterDate:matchingComponents:options:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSDate? FindNextDateAfterDateMatching (NSDate date, NSDateComponents components, NSCalendarOptions options)
		{
			var date__handle__ = date!.GetNonNullHandle (nameof (date));
			var components__handle__ = components!.GetNonNullHandle (nameof (components));
			IntPtr exception_gchandle = IntPtr.Zero;
			NSDate? ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<NSDate> (global::ObjCRuntime.Messaging.xamarin_NativeHandle_objc_msgSend_NativeHandle_NativeHandle_UIntPtr_exception (this.Handle, selNextDateAfterDate_MatchingComponents_Options_XHandle, date__handle__, components__handle__, (UIntPtr) (ulong) options, &exception_gchandle), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<NSDate> (global::ObjCRuntime.Messaging.xamarin_NativeHandle_objc_msgSendSuper_NativeHandle_NativeHandle_UIntPtr_exception (&__objc_super__, selNextDateAfterDate_MatchingComponents_Options_XHandle, date__handle__, components__handle__, (UIntPtr) (ulong) options, &exception_gchandle), false)!;
					GC.KeepAlive (this);
				}
			}
			Runtime.ThrowException (exception_gchandle);
			GC.KeepAlive (date);
			GC.KeepAlive (components);
			return ret!;
		}
		/// <param name="date">To be added.</param><param name="hour">To be added.</param><param name="minute">To be added.</param><param name="second">To be added.</param><param name="options">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("nextDateAfterDate:matchingHour:minute:second:options:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSDate? FindNextDateAfterDateMatching (NSDate date, nint hour, nint minute, nint second, NSCalendarOptions options)
		{
			var date__handle__ = date!.GetNonNullHandle (nameof (date));
			IntPtr exception_gchandle = IntPtr.Zero;
			NSDate? ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<NSDate> (global::ObjCRuntime.Messaging.xamarin_NativeHandle_objc_msgSend_NativeHandle_IntPtr_IntPtr_IntPtr_UIntPtr_exception (this.Handle, selNextDateAfterDate_MatchingHour_Minute_Second_Options_XHandle, date__handle__, hour, minute, second, (UIntPtr) (ulong) options, &exception_gchandle), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<NSDate> (global::ObjCRuntime.Messaging.xamarin_NativeHandle_objc_msgSendSuper_NativeHandle_IntPtr_IntPtr_IntPtr_UIntPtr_exception (&__objc_super__, selNextDateAfterDate_MatchingHour_Minute_Second_Options_XHandle, date__handle__, hour, minute, second, (UIntPtr) (ulong) options, &exception_gchandle), false)!;
					GC.KeepAlive (this);
				}
			}
			Runtime.ThrowException (exception_gchandle);
			GC.KeepAlive (date);
			return ret!;
		}
		/// <param name="date">To be added.</param><param name="unit">To be added.</param><param name="value">To be added.</param><param name="options">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("nextDateAfterDate:matchingUnit:value:options:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSDate? FindNextDateAfterDateMatching (NSDate date, NSCalendarUnit unit, nint value, NSCalendarOptions options)
		{
			var date__handle__ = date!.GetNonNullHandle (nameof (date));
			IntPtr exception_gchandle = IntPtr.Zero;
			NSDate? ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<NSDate> (global::ObjCRuntime.Messaging.xamarin_NativeHandle_objc_msgSend_NativeHandle_UIntPtr_IntPtr_UIntPtr_exception (this.Handle, selNextDateAfterDate_MatchingUnit_Value_Options_XHandle, date__handle__, (UIntPtr) (ulong) unit, value, (UIntPtr) (ulong) options, &exception_gchandle), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<NSDate> (global::ObjCRuntime.Messaging.xamarin_NativeHandle_objc_msgSendSuper_NativeHandle_UIntPtr_IntPtr_UIntPtr_exception (&__objc_super__, selNextDateAfterDate_MatchingUnit_Value_Options_XHandle, date__handle__, (UIntPtr) (ulong) unit, value, (UIntPtr) (ulong) options, &exception_gchandle), false)!;
					GC.KeepAlive (this);
				}
			}
			Runtime.ThrowException (exception_gchandle);
			GC.KeepAlive (date);
			return ret!;
		}
		[Export ("nextWeekendStartDate:interval:options:afterDate:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual bool FindNextWeekend (out NSDate date, out double interval, NSCalendarOptions options, NSDate afterDate)
		{
			var afterDate__handle__ = afterDate!.GetNonNullHandle (nameof (afterDate));
			NativeHandle dateValue = IntPtr.Zero;
			fixed (double* interval__pointer = &interval) {
			interval = default;
			byte ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_ref_NativeHandle_out_Double_UIntPtr_NativeHandle (this.Handle, selNextWeekendStartDate_Interval_Options_AfterDate_XHandle, &dateValue, interval__pointer, (UIntPtr) (ulong) options, afterDate__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper_ref_NativeHandle_out_Double_UIntPtr_NativeHandle (&__objc_super__, selNextWeekendStartDate_Interval_Options_AfterDate_XHandle, &dateValue, interval__pointer, (UIntPtr) (ulong) options, afterDate__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (afterDate);
			date = Runtime.GetNSObject<NSDate> (dateValue)!;
			return ret != 0;
			}
		}
		[Export ("component:fromDate:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual nint GetComponentFromDate (NSCalendarUnit unit, NSDate date)
		{
			var date__handle__ = date!.GetNonNullHandle (nameof (date));
			nint ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSend_UIntPtr_NativeHandle (this.Handle, selComponent_FromDate_XHandle, (UIntPtr) (ulong) unit, date__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper_UIntPtr_NativeHandle (&__objc_super__, selComponent_FromDate_XHandle, (UIntPtr) (ulong) unit, date__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (date);
			return ret!;
		}
		/// <param name="era">To be added.</param><param name="year">To be added.</param><param name="month">To be added.</param><param name="day">To be added.</param><param name="date">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("getEra:year:month:day:fromDate:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void GetComponentsFromDate (out nint era, out nint year, out nint month, out nint day, NSDate date)
		{
			var date__handle__ = date!.GetNonNullHandle (nameof (date));
			fixed (nint* era__pointer = &era) {
			fixed (nint* year__pointer = &year) {
			fixed (nint* month__pointer = &month) {
			fixed (nint* day__pointer = &day) {
			era = default;
			year = default;
			month = default;
			day = default;
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_out_IntPtr_out_IntPtr_out_IntPtr_out_IntPtr_NativeHandle (this.Handle, selGetEra_Year_Month_Day_FromDate_XHandle, era__pointer, year__pointer, month__pointer, day__pointer, date__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_out_IntPtr_out_IntPtr_out_IntPtr_out_IntPtr_NativeHandle (&__objc_super__, selGetEra_Year_Month_Day_FromDate_XHandle, era__pointer, year__pointer, month__pointer, day__pointer, date__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (date);
			}
			}
			}
			}
		}
		/// <param name="era">To be added.</param><param name="year">To be added.</param><param name="weekOfYear">To be added.</param><param name="weekday">To be added.</param><param name="date">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("getEra:yearForWeekOfYear:weekOfYear:weekday:fromDate:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void GetComponentsFromDateForWeekOfYear (out nint era, out nint year, out nint weekOfYear, out nint weekday, NSDate date)
		{
			var date__handle__ = date!.GetNonNullHandle (nameof (date));
			fixed (nint* era__pointer = &era) {
			fixed (nint* year__pointer = &year) {
			fixed (nint* weekOfYear__pointer = &weekOfYear) {
			fixed (nint* weekday__pointer = &weekday) {
			era = default;
			year = default;
			weekOfYear = default;
			weekday = default;
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_out_IntPtr_out_IntPtr_out_IntPtr_out_IntPtr_NativeHandle (this.Handle, selGetEra_YearForWeekOfYear_WeekOfYear_Weekday_FromDate_XHandle, era__pointer, year__pointer, weekOfYear__pointer, weekday__pointer, date__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_out_IntPtr_out_IntPtr_out_IntPtr_out_IntPtr_NativeHandle (&__objc_super__, selGetEra_YearForWeekOfYear_WeekOfYear_Weekday_FromDate_XHandle, era__pointer, year__pointer, weekOfYear__pointer, weekday__pointer, date__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (date);
			}
			}
			}
			}
		}
		/// <param name="hour">To be added.</param><param name="minute">To be added.</param><param name="second">To be added.</param><param name="nanosecond">To be added.</param><param name="date">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("getHour:minute:second:nanosecond:fromDate:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void GetHourComponentsFromDate (out nint hour, out nint minute, out nint second, out nint nanosecond, NSDate date)
		{
			var date__handle__ = date!.GetNonNullHandle (nameof (date));
			fixed (nint* hour__pointer = &hour) {
			fixed (nint* minute__pointer = &minute) {
			fixed (nint* second__pointer = &second) {
			fixed (nint* nanosecond__pointer = &nanosecond) {
			hour = default;
			minute = default;
			second = default;
			nanosecond = default;
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_out_IntPtr_out_IntPtr_out_IntPtr_out_IntPtr_NativeHandle (this.Handle, selGetHour_Minute_Second_Nanosecond_FromDate_XHandle, hour__pointer, minute__pointer, second__pointer, nanosecond__pointer, date__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_out_IntPtr_out_IntPtr_out_IntPtr_out_IntPtr_NativeHandle (&__objc_super__, selGetHour_Minute_Second_Nanosecond_FromDate_XHandle, hour__pointer, minute__pointer, second__pointer, nanosecond__pointer, date__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (date);
			}
			}
			}
			}
		}
		[Export ("isDateInToday:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool IsDateInToday (NSDate date)
		{
			var date__handle__ = date!.GetNonNullHandle (nameof (date));
			byte ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle (this.Handle, selIsDateInToday_XHandle, date__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper_NativeHandle (&__objc_super__, selIsDateInToday_XHandle, date__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (date);
			return ret != 0;
		}
		[Export ("isDateInTomorrow:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool IsDateInTomorrow (NSDate date)
		{
			var date__handle__ = date!.GetNonNullHandle (nameof (date));
			byte ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle (this.Handle, selIsDateInTomorrow_XHandle, date__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper_NativeHandle (&__objc_super__, selIsDateInTomorrow_XHandle, date__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (date);
			return ret != 0;
		}
		[Export ("isDateInWeekend:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool IsDateInWeekend (NSDate date)
		{
			var date__handle__ = date!.GetNonNullHandle (nameof (date));
			byte ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle (this.Handle, selIsDateInWeekend_XHandle, date__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper_NativeHandle (&__objc_super__, selIsDateInWeekend_XHandle, date__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (date);
			return ret != 0;
		}
		[Export ("isDateInYesterday:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool IsDateInYesterday (NSDate date)
		{
			var date__handle__ = date!.GetNonNullHandle (nameof (date));
			byte ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle (this.Handle, selIsDateInYesterday_XHandle, date__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper_NativeHandle (&__objc_super__, selIsDateInYesterday_XHandle, date__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (date);
			return ret != 0;
		}
		[Export ("isDate:equalToDate:toUnitGranularity:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool IsEqualToUnitGranularity (NSDate date1, NSDate date2, NSCalendarUnit unit)
		{
			var date1__handle__ = date1!.GetNonNullHandle (nameof (date1));
			var date2__handle__ = date2!.GetNonNullHandle (nameof (date2));
			byte ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_NativeHandle_UIntPtr (this.Handle, selIsDate_EqualToDate_ToUnitGranularity_XHandle, date1__handle__, date2__handle__, (UIntPtr) (ulong) unit);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper_NativeHandle_NativeHandle_UIntPtr (&__objc_super__, selIsDate_EqualToDate_ToUnitGranularity_XHandle, date1__handle__, date2__handle__, (UIntPtr) (ulong) unit);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (date1);
			GC.KeepAlive (date2);
			return ret != 0;
		}
		[Export ("isDate:inSameDayAsDate:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool IsInSameDay (NSDate date1, NSDate date2)
		{
			var date1__handle__ = date1!.GetNonNullHandle (nameof (date1));
			var date2__handle__ = date2!.GetNonNullHandle (nameof (date2));
			byte ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_NativeHandle (this.Handle, selIsDate_InSameDayAsDate_XHandle, date1__handle__, date2__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, selIsDate_InSameDayAsDate_XHandle, date1__handle__, date2__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (date1);
			GC.KeepAlive (date2);
			return ret != 0;
		}
		[Export ("date:matchesComponents:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool Matches (NSDate date, NSDateComponents components)
		{
			var date__handle__ = date!.GetNonNullHandle (nameof (date));
			var components__handle__ = components!.GetNonNullHandle (nameof (components));
			byte ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_NativeHandle (this.Handle, selDate_MatchesComponents_XHandle, date__handle__, components__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, selDate_MatchesComponents_XHandle, date__handle__, components__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (date);
			GC.KeepAlive (components);
			return ret != 0;
		}
		[Export ("maximumRangeOfUnit:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSRange MaximumRange (NSCalendarUnit unit)
		{
			NSRange ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.NSRange_objc_msgSend_UIntPtr (this.Handle, selMaximumRangeOfUnit_XHandle, (UIntPtr) (ulong) unit);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.NSRange_objc_msgSendSuper_UIntPtr (&__objc_super__, selMaximumRangeOfUnit_XHandle, (UIntPtr) (ulong) unit);
					GC.KeepAlive (this);
				}
			}
			return ret;
		}
		[Export ("minimumRangeOfUnit:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSRange MinimumRange (NSCalendarUnit unit)
		{
			NSRange ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.NSRange_objc_msgSend_UIntPtr (this.Handle, selMinimumRangeOfUnit_XHandle, (UIntPtr) (ulong) unit);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.NSRange_objc_msgSendSuper_UIntPtr (&__objc_super__, selMinimumRangeOfUnit_XHandle, (UIntPtr) (ulong) unit);
					GC.KeepAlive (this);
				}
			}
			return ret;
		}
		[Export ("ordinalityOfUnit:inUnit:forDate:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual nuint Ordinality (NSCalendarUnit smaller, NSCalendarUnit larger, NSDate date)
		{
			var date__handle__ = date!.GetNonNullHandle (nameof (date));
			nuint ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend_UIntPtr_UIntPtr_NativeHandle (this.Handle, selOrdinalityOfUnit_InUnit_ForDate_XHandle, (UIntPtr) (ulong) smaller, (UIntPtr) (ulong) larger, date__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.UIntPtr_objc_msgSendSuper_UIntPtr_UIntPtr_NativeHandle (&__objc_super__, selOrdinalityOfUnit_InUnit_ForDate_XHandle, (UIntPtr) (ulong) smaller, (UIntPtr) (ulong) larger, date__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (date);
			return ret!;
		}
		[Export ("rangeOfUnit:inUnit:forDate:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSRange Range (NSCalendarUnit smaller, NSCalendarUnit larger, NSDate date)
		{
			var date__handle__ = date!.GetNonNullHandle (nameof (date));
			NSRange ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.NSRange_objc_msgSend_UIntPtr_UIntPtr_NativeHandle (this.Handle, selRangeOfUnit_InUnit_ForDate_XHandle, (UIntPtr) (ulong) smaller, (UIntPtr) (ulong) larger, date__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.NSRange_objc_msgSendSuper_UIntPtr_UIntPtr_NativeHandle (&__objc_super__, selRangeOfUnit_InUnit_ForDate_XHandle, (UIntPtr) (ulong) smaller, (UIntPtr) (ulong) larger, date__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (date);
			return ret!;
		}
		[Export ("rangeOfUnit:startDate:interval:forDate:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual bool Range (NSCalendarUnit unit, out NSDate? datep, out double interval, NSDate date)
		{
			var date__handle__ = date!.GetNonNullHandle (nameof (date));
			NativeHandle datepValue = IntPtr.Zero;
			fixed (double* interval__pointer = &interval) {
			interval = default;
			byte ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_UIntPtr_ref_NativeHandle_out_Double_NativeHandle (this.Handle, selRangeOfUnit_StartDate_Interval_ForDate_XHandle, (UIntPtr) (ulong) unit, &datepValue, interval__pointer, date__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper_UIntPtr_ref_NativeHandle_out_Double_NativeHandle (&__objc_super__, selRangeOfUnit_StartDate_Interval_ForDate_XHandle, (UIntPtr) (ulong) unit, &datepValue, interval__pointer, date__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (date);
			datep = Runtime.GetNSObject<NSDate> (datepValue)!;
			return ret != 0;
			}
		}
		[Export ("rangeOfWeekendStartDate:interval:containingDate:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual bool RangeOfWeekendContainingDate (out NSDate weekendStartDate, out double interval, NSDate date)
		{
			var date__handle__ = date!.GetNonNullHandle (nameof (date));
			NativeHandle weekendStartDateValue = IntPtr.Zero;
			fixed (double* interval__pointer = &interval) {
			interval = default;
			byte ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_ref_NativeHandle_out_Double_NativeHandle (this.Handle, selRangeOfWeekendStartDate_Interval_ContainingDate_XHandle, &weekendStartDateValue, interval__pointer, date__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper_ref_NativeHandle_out_Double_NativeHandle (&__objc_super__, selRangeOfWeekendStartDate_Interval_ContainingDate_XHandle, &weekendStartDateValue, interval__pointer, date__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (date);
			weekendStartDate = Runtime.GetNSObject<NSDate> (weekendStartDateValue)!;
			return ret != 0;
			}
		}
		[Export ("startOfDayForDate:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSDate StartOfDayForDate (NSDate date)
		{
			var date__handle__ = date!.GetNonNullHandle (nameof (date));
			NSDate? ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<NSDate> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, selStartOfDayForDate_XHandle, date__handle__), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<NSDate> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle (&__objc_super__, selStartOfDayForDate_XHandle, date__handle__), false)!;
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (date);
			return ret!;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string AMSymbol {
			[Export ("AMSymbol")]
			get {
				string ret;
				if (IsDirectBinding) {
					ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selAMSymbolXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selAMSymbolXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSCalendar CurrentCalendar {
			[Export ("currentCalendar")]
			get {
				NSCalendar? ret;
				ret =  Runtime.GetNSObject<NSCalendar> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (class_ptr, selCurrentCalendarXHandle), false)!;
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string[] EraSymbols {
			[Export ("eraSymbols")]
			get {
				string[] ret;
				if (IsDirectBinding) {
					ret = CFArray.StringArrayFromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selEraSymbolsXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFArray.StringArrayFromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selEraSymbolsXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual nuint FirstWeekDay {
			[Export ("firstWeekday")]
			get {
				nuint ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend (this.Handle, selFirstWeekdayXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.UIntPtr_objc_msgSendSuper (&__objc_super__, selFirstWeekdayXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[Export ("setFirstWeekday:")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_UIntPtr (this.Handle, selSetFirstWeekday_XHandle, value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_UIntPtr (&__objc_super__, selSetFirstWeekday_XHandle, value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string Identifier {
			[Export ("calendarIdentifier")]
			get {
				string ret;
				if (IsDirectBinding) {
					ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selCalendarIdentifierXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selCalendarIdentifierXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSLocale Locale {
			[Export ("locale", ArgumentSemantic.Copy)]
			get {
				NSLocale? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSLocale> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selLocaleXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<NSLocale> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selLocaleXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setLocale:", ArgumentSemantic.Copy)]
			set {
				var value__handle__ = value!.GetNonNullHandle (nameof (value));
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selSetLocale_XHandle, value__handle__);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selSetLocale_XHandle, value__handle__);
						GC.KeepAlive (this);
					}
				}
				GC.KeepAlive (value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string[] LongEraSymbols {
			[Export ("longEraSymbols")]
			get {
				string[] ret;
				if (IsDirectBinding) {
					ret = CFArray.StringArrayFromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selLongEraSymbolsXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFArray.StringArrayFromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selLongEraSymbolsXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual nuint MinimumDaysInFirstWeek {
			[Export ("minimumDaysInFirstWeek")]
			get {
				nuint ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend (this.Handle, selMinimumDaysInFirstWeekXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.UIntPtr_objc_msgSendSuper (&__objc_super__, selMinimumDaysInFirstWeekXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[Export ("setMinimumDaysInFirstWeek:")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_UIntPtr (this.Handle, selSetMinimumDaysInFirstWeek_XHandle, value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_UIntPtr (&__objc_super__, selSetMinimumDaysInFirstWeek_XHandle, value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string[] MonthSymbols {
			[Export ("monthSymbols")]
			get {
				string[] ret;
				if (IsDirectBinding) {
					ret = CFArray.StringArrayFromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selMonthSymbolsXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFArray.StringArrayFromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selMonthSymbolsXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string PMSymbol {
			[Export ("PMSymbol")]
			get {
				string ret;
				if (IsDirectBinding) {
					ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selPMSymbolXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selPMSymbolXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string[] QuarterSymbols {
			[Export ("quarterSymbols")]
			get {
				string[] ret;
				if (IsDirectBinding) {
					ret = CFArray.StringArrayFromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selQuarterSymbolsXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFArray.StringArrayFromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selQuarterSymbolsXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string[] ShortMonthSymbols {
			[Export ("shortMonthSymbols")]
			get {
				string[] ret;
				if (IsDirectBinding) {
					ret = CFArray.StringArrayFromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selShortMonthSymbolsXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFArray.StringArrayFromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selShortMonthSymbolsXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string[] ShortQuarterSymbols {
			[Export ("shortQuarterSymbols")]
			get {
				string[] ret;
				if (IsDirectBinding) {
					ret = CFArray.StringArrayFromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selShortQuarterSymbolsXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFArray.StringArrayFromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selShortQuarterSymbolsXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string[] ShortStandaloneMonthSymbols {
			[Export ("shortStandaloneMonthSymbols")]
			get {
				string[] ret;
				if (IsDirectBinding) {
					ret = CFArray.StringArrayFromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selShortStandaloneMonthSymbolsXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFArray.StringArrayFromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selShortStandaloneMonthSymbolsXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string[] ShortStandaloneQuarterSymbols {
			[Export ("shortStandaloneQuarterSymbols")]
			get {
				string[] ret;
				if (IsDirectBinding) {
					ret = CFArray.StringArrayFromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selShortStandaloneQuarterSymbolsXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFArray.StringArrayFromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selShortStandaloneQuarterSymbolsXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string[] ShortStandaloneWeekdaySymbols {
			[Export ("shortStandaloneWeekdaySymbols")]
			get {
				string[] ret;
				if (IsDirectBinding) {
					ret = CFArray.StringArrayFromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selShortStandaloneWeekdaySymbolsXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFArray.StringArrayFromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selShortStandaloneWeekdaySymbolsXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string[] ShortWeekdaySymbols {
			[Export ("shortWeekdaySymbols")]
			get {
				string[] ret;
				if (IsDirectBinding) {
					ret = CFArray.StringArrayFromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selShortWeekdaySymbolsXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFArray.StringArrayFromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selShortWeekdaySymbolsXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string[] StandaloneMonthSymbols {
			[Export ("standaloneMonthSymbols")]
			get {
				string[] ret;
				if (IsDirectBinding) {
					ret = CFArray.StringArrayFromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selStandaloneMonthSymbolsXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFArray.StringArrayFromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selStandaloneMonthSymbolsXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string[] StandaloneQuarterSymbols {
			[Export ("standaloneQuarterSymbols")]
			get {
				string[] ret;
				if (IsDirectBinding) {
					ret = CFArray.StringArrayFromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selStandaloneQuarterSymbolsXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFArray.StringArrayFromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selStandaloneQuarterSymbolsXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string[] StandaloneWeekdaySymbols {
			[Export ("standaloneWeekdaySymbols")]
			get {
				string[] ret;
				if (IsDirectBinding) {
					ret = CFArray.StringArrayFromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selStandaloneWeekdaySymbolsXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFArray.StringArrayFromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selStandaloneWeekdaySymbolsXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSTimeZone TimeZone {
			[Export ("timeZone", ArgumentSemantic.Copy)]
			get {
				NSTimeZone? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSTimeZone> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selTimeZoneXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<NSTimeZone> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selTimeZoneXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setTimeZone:", ArgumentSemantic.Copy)]
			set {
				var value__handle__ = value!.GetNonNullHandle (nameof (value));
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selSetTimeZone_XHandle, value__handle__);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selSetTimeZone_XHandle, value__handle__);
						GC.KeepAlive (this);
					}
				}
				GC.KeepAlive (value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string[] VeryShortMonthSymbols {
			[Export ("veryShortMonthSymbols")]
			get {
				string[] ret;
				if (IsDirectBinding) {
					ret = CFArray.StringArrayFromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selVeryShortMonthSymbolsXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFArray.StringArrayFromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selVeryShortMonthSymbolsXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string[] VeryShortStandaloneMonthSymbols {
			[Export ("veryShortStandaloneMonthSymbols")]
			get {
				string[] ret;
				if (IsDirectBinding) {
					ret = CFArray.StringArrayFromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selVeryShortStandaloneMonthSymbolsXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFArray.StringArrayFromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selVeryShortStandaloneMonthSymbolsXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string[] VeryShortStandaloneWeekdaySymbols {
			[Export ("veryShortStandaloneWeekdaySymbols")]
			get {
				string[] ret;
				if (IsDirectBinding) {
					ret = CFArray.StringArrayFromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selVeryShortStandaloneWeekdaySymbolsXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFArray.StringArrayFromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selVeryShortStandaloneWeekdaySymbolsXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string[] VeryShortWeekdaySymbols {
			[Export ("veryShortWeekdaySymbols")]
			get {
				string[] ret;
				if (IsDirectBinding) {
					ret = CFArray.StringArrayFromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selVeryShortWeekdaySymbolsXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFArray.StringArrayFromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selVeryShortWeekdaySymbolsXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string[] WeekdaySymbols {
			[Export ("weekdaySymbols")]
			get {
				string[] ret;
				if (IsDirectBinding) {
					ret = CFArray.StringArrayFromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selWeekdaySymbolsXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFArray.StringArrayFromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selWeekdaySymbolsXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _DayChangedNotification;
		/// <summary>Notification constant for DayChanged</summary>
		/// <value><see cref="NSString" /> constant, should be used as a token to <see cref="NSNotificationCenter" />.</value>
		/// <remarks>
		///   <para>
		///     This constant can be used with <see cref="NSNotificationCenter" /> to register a listener for this notification.
		///     This is an <see cref="NSString" /> instead of a string, because these values can be used as tokens in some native
		///     libraries instead of being used purely for their actual string content. The 'notification' parameter to the callback
		///     contains extra information that is specific to the notification type.
		///   </para>
		///   <para>
		///     To subscribe to this notification, developers can use the convenience <see cref="Notifications.ObserveDayChanged(NSObject,EventHandler{NSNotificationEventArgs})" />
		///     or <see cref="Notifications.ObserveDayChanged(EventHandler{NSNotificationEventArgs})" /> methods,
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
		/// notification = NSCalendar.Notifications.ObserveDayChanged ((sender, args) => {
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
		/// void Callback (object sender, NSCalendar.NSNotificationEventArgs args)
		/// {
		///     // Access strongly typed args
		///     Console.WriteLine ("Notification: {0}", args.Notification);
		/// }
		///
		/// void Setup ()
		/// {
		///     notification = NSCalendar.Notifications.ObserveDayChanged (Callback);
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
		///     NSCalendar.DayChangedNotification, (notification) => { Console.WriteLine ("Received the notification DayChanged", notification); }
		/// );
		///
		/// // Method style
		/// void Callback (NSNotification notification)
		/// {
		///     Console.WriteLine ("Received the notification DayChanged", notification);
		/// }
		///
		/// void Setup ()
		/// {
		///     NSNotificationCenter.DefaultCenter.AddObserver (NSCalendar.DayChangedNotification, Callback);
		/// }
		/// ]]></code>
		///   </example>
		/// </remarks>
		[Field ("NSCalendarDayChangedNotification",  "Foundation")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[Advice ("Use NSCalendar.Notifications.ObserveDayChanged helper method instead.")]
		public static NSString DayChangedNotification {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_DayChangedNotification is null)
					_DayChangedNotification = Dlfcn.GetStringConstant (Libraries.Foundation.Handle, "NSCalendarDayChangedNotification")!;
				return _DayChangedNotification;
			}
		}
		//
		// Notifications
		//
		/// <summary>Notifications posted by the <see cref="global::Foundation.NSCalendar" /> class.</summary>
		/// <remarks>
		///    <para>This class contains various helper methods that allow developers to observe events posted in the notification hub (<see cref="Foundation.NSNotificationCenter" />).</para>
		///    <para>The methods defined in this class post events that invoke the provided method or lambda with a <see cref="Foundation.NSNotificationEventArgs" /> parameter, which contains strongly typed properties for the notification arguments.</para>
		/// </remarks>
		public static partial class Notifications {
			/// <summary>Strongly typed notification for the <see cref="global::Foundation.NSCalendar.DayChangedNotification" /> constant.</summary>
			/// <param name="handler">The handler that responds to the notification when it occurs.</param>
			/// <returns>Token object that can be used to stop receiving notifications by either disposing it or passing it to <see cref="Foundation.NSNotificationCenter.RemoveObservers(System.Collections.Generic.IEnumerable{Foundation.NSObject})" />.</returns>
			/// <remarks>
			///   <para>This method can be used to subscribe to <see cref="global::Foundation.NSCalendar.DayChangedNotification" /> notifications.</para>
			///   <example>
			///   <code lang="csharp lang-csharp"><![CDATA[
			/// // Listen to all notifications posted for any object
			/// var token = NSCalendar.Notifications.ObserveDayChanged ((notification) => {
			///   Console.WriteLine ("Observed DayChangedNotification!");
			/// };
			/// 
			/// // Stop listening for notifications
			/// token.Dispose ();
			/// ]]></code>
			///   </example>
			/// </remarks>
			public static NSObject ObserveDayChanged (EventHandler<NSNotificationEventArgs> handler)
			{
				return NSNotificationCenter.DefaultCenter.AddObserver (DayChangedNotification, notification => handler (null, new NSNotificationEventArgs (notification)));
			}
			/// <summary>Strongly typed notification for the <see cref="global::Foundation.NSCalendar.DayChangedNotification" /> constant.</summary>
			/// <param name="objectToObserve">The specific object to observe.</param>
			/// <param name="handler">The handler that responds to the notification when it occurs.</param>
			/// <returns>Token object that can be used to stop receiving notifications by either disposing it or passing it to <see cref="Foundation.NSNotificationCenter.RemoveObservers(System.Collections.Generic.IEnumerable{Foundation.NSObject})" />.</returns>
			/// <remarks>
			///   <para>This method can be used to subscribe to <see cref="global::Foundation.NSCalendar.DayChangedNotification" /> notifications.</para>
			///   <example>
			///     <code lang="csharp lang-csharp"><![CDATA[
			/// // Listen to all notifications posted for a single object
			/// var token = NSCalendar.Notifications.ObserveDayChanged (objectToObserve, (notification) => {
			///   Console.WriteLine ($"Observed DayChangedNotification for {nameof (objectToObserve)}!");
			/// };
			/// 
			/// // Stop listening for notifications
			/// token.Dispose ();
			/// ]]></code>
			///   </example>
			/// </remarks>
			public static NSObject ObserveDayChanged (NSObject objectToObserve, EventHandler<NSNotificationEventArgs> handler)
			{
				return NSNotificationCenter.DefaultCenter.AddObserver (DayChangedNotification, notification => handler (null, new NSNotificationEventArgs (notification)), objectToObserve);
			}
		}
	} /* class NSCalendar */
}
