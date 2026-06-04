//
// NSPredicateEditorRowTemplate.cs
//
// Authors:
//   Aaron Bockover (abock@xamarin.com)
//
// Copyright 2013 Xamarin Inc
//

#if !__MACCATALYST__

using System.Linq;
using System.Collections.Generic;

using CoreData;

#nullable enable

namespace AppKit {
	public partial class NSPredicateEditorRowTemplate {
		/// <param name="compoundTypes">The compound types.</param>
		///         <summary>Creates a new <see cref="NSPredicateEditorRowTemplate" /> instance.</summary>
		public NSPredicateEditorRowTemplate (params NSCompoundPredicateType [] compoundTypes)
			: this (Array.ConvertAll (compoundTypes, t => NSNumber.FromUInt32 ((uint) t)))
		{
		}

		/// <param name="leftExpressions">The left expressions.</param>
		///         <param name="rightExpressions">The right expressions.</param>
		///         <param name="operators">The operators.</param>
		///         <param name="modifier">The modifier.</param>
		///         <param name="options">The options to use.</param>
		///         <summary>Creates a new <see cref="NSPredicateEditorRowTemplate" /> instance.</summary>
		public NSPredicateEditorRowTemplate (
			IEnumerable<NSExpression> leftExpressions,
			IEnumerable<NSExpression> rightExpressions,
			IEnumerable<NSPredicateOperatorType> operators,
			NSComparisonPredicateModifier modifier = NSComparisonPredicateModifier.Direct,
			NSComparisonPredicateOptions options = NSComparisonPredicateOptions.None)
			: this (
				leftExpressions.ToArray (),
				rightExpressions.ToArray (),
				modifier,
				operators.Select (o => NSNumber.FromUInt32 ((uint) o)).ToArray (),
				options)
		{
		}

		/// <param name="leftExpressionsFromKeyPaths">The left expressions from key paths.</param>
		///         <param name="rightExpressionsFromConstants">The right expressions from constants.</param>
		///         <param name="operators">The operators.</param>
		///         <param name="modifier">The modifier.</param>
		///         <param name="options">The options to use.</param>
		///         <summary>Creates a new <see cref="NSPredicateEditorRowTemplate" /> instance.</summary>
		public NSPredicateEditorRowTemplate (
			IEnumerable<string> leftExpressionsFromKeyPaths,
			IEnumerable<string> rightExpressionsFromConstants,
			IEnumerable<NSPredicateOperatorType> operators,
			NSComparisonPredicateModifier modifier = NSComparisonPredicateModifier.Direct,
			NSComparisonPredicateOptions options = NSComparisonPredicateOptions.None)
			: this (
				leftExpressionsFromKeyPaths.Select (k => NSExpression.FromKeyPath (k)),
				rightExpressionsFromConstants.Select (k => NSExpression.FromConstant (new NSString (k))),
				operators,
				modifier,
				options)
		{
		}

		/// <param name="leftExpressionFromKeyPath">The left expression from key path.</param>
		///         <param name="rightExpressionFromConstant">The right expression from constant.</param>
		///         <param name="operators">The operators.</param>
		///         <param name="modifier">The modifier.</param>
		///         <param name="options">The options to use.</param>
		///         <summary>Creates a new <see cref="NSPredicateEditorRowTemplate" /> instance.</summary>
		public NSPredicateEditorRowTemplate (
			string leftExpressionFromKeyPath,
			string rightExpressionFromConstant,
			IEnumerable<NSPredicateOperatorType> operators,
			NSComparisonPredicateModifier modifier = NSComparisonPredicateModifier.Direct,
			NSComparisonPredicateOptions options = NSComparisonPredicateOptions.None)
			: this (
				new [] { leftExpressionFromKeyPath },
				new [] { rightExpressionFromConstant },
				operators,
				modifier,
				options)
		{
		}

		/// <param name="leftExpressionFromKeyPath">The left expression from key path.</param>
		///         <param name="rightExpressionsFromConstants">The right expressions from constants.</param>
		///         <param name="operators">The operators.</param>
		///         <param name="modifier">The modifier.</param>
		///         <param name="options">The options to use.</param>
		///         <summary>Creates a new <see cref="NSPredicateEditorRowTemplate" /> instance.</summary>
		public NSPredicateEditorRowTemplate (
			string leftExpressionFromKeyPath,
			IEnumerable<string> rightExpressionsFromConstants,
			IEnumerable<NSPredicateOperatorType> operators,
			NSComparisonPredicateModifier modifier = NSComparisonPredicateModifier.Direct,
			NSComparisonPredicateOptions options = NSComparisonPredicateOptions.None)
			: this (
				new [] { leftExpressionFromKeyPath },
				rightExpressionsFromConstants,
				operators,
				modifier,
				options)
		{
		}

		/// <param name="leftExpressions">The left expressions.</param>
		///         <param name="attributeType">The attribute type.</param>
		///         <param name="operators">The operators.</param>
		///         <param name="modifier">The modifier.</param>
		///         <param name="options">The options to use.</param>
		///         <summary>Creates a new <see cref="NSPredicateEditorRowTemplate" /> instance.</summary>
		public NSPredicateEditorRowTemplate (
			IEnumerable<NSExpression> leftExpressions,
			NSAttributeType attributeType,
			IEnumerable<NSPredicateOperatorType> operators,
			NSComparisonPredicateModifier modifier = NSComparisonPredicateModifier.Direct,
			NSComparisonPredicateOptions options = NSComparisonPredicateOptions.None)
			: this (
				leftExpressions.ToArray (),
				attributeType,
				modifier,
				operators.Select (o => NSNumber.FromUInt32 ((uint) o)).ToArray (),
				options)
		{
		}

		/// <param name="leftExpressionsFromKeyPaths">The left expressions from key paths.</param>
		///         <param name="attributeType">The attribute type.</param>
		///         <param name="operators">The operators.</param>
		///         <param name="modifier">The modifier.</param>
		///         <param name="options">The options to use.</param>
		///         <summary>Creates a new <see cref="NSPredicateEditorRowTemplate" /> instance.</summary>
		public NSPredicateEditorRowTemplate (
			IEnumerable<string> leftExpressionsFromKeyPaths,
			NSAttributeType attributeType,
			IEnumerable<NSPredicateOperatorType> operators,
			NSComparisonPredicateModifier modifier = NSComparisonPredicateModifier.Direct,
			NSComparisonPredicateOptions options = NSComparisonPredicateOptions.None)
			: this (
				leftExpressionsFromKeyPaths.Select (k => NSExpression.FromKeyPath (k)),
				attributeType,
				operators,
				modifier,
				options)
		{
		}

		/// <param name="leftExpressionFromKeyPath">The left expression from key path.</param>
		///         <param name="attributeType">The attribute type.</param>
		///         <param name="operators">The operators.</param>
		///         <param name="modifier">The modifier.</param>
		///         <param name="options">The options to use.</param>
		///         <summary>Creates a new <see cref="NSPredicateEditorRowTemplate" /> instance.</summary>
		public NSPredicateEditorRowTemplate (
			string leftExpressionFromKeyPath,
			NSAttributeType attributeType,
			IEnumerable<NSPredicateOperatorType> operators,
			NSComparisonPredicateModifier modifier = NSComparisonPredicateModifier.Direct,
			NSComparisonPredicateOptions options = NSComparisonPredicateOptions.None)
			: this (
				new [] { leftExpressionFromKeyPath },
				attributeType,
				operators,
				modifier,
				options)
		{
		}
	}
}
#endif // !__MACCATALYST__
