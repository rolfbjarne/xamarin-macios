//
// SCNParticleSystem.cs: extensions to SCNParticleSystem
//
// Authors:
//   Miguel de Icaza (miguel@xamarin.com)
//
// Copyright Xamarin Inc.
//

using System.Collections;
using System.Collections.Generic;

#nullable enable

namespace SceneKit {
/// <summary>Provides property controllers for animating SceneKit particle system properties.</summary>
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("tvos")]
	public class SCNPropertyControllers {
		NSMutableDictionary? mutDict;
		internal NSDictionary dict;

		internal SCNPropertyControllers (NSDictionary dict)
		{
			this.dict = dict;
			if (dict is NSMutableDictionary)
				mutDict = (NSMutableDictionary) dict;
		}

	/// <summary>Initializes a new empty instance of the <see cref="SCNPropertyControllers" /> class.</summary>
		public SCNPropertyControllers ()
		{
			mutDict = new NSMutableDictionary ();
			dict = mutDict;
		}

		internal void Set (NSString key, SCNParticlePropertyController? value)
		{
			if (value is null && mutDict is null)
				return;

			if (mutDict is null) {
				mutDict = new NSMutableDictionary (dict);
				dict = mutDict;
			}
			if (value is null) {
				mutDict.Remove (key);
			} else {
				mutDict [key] = value;
			}
		}

	/// <summary>Gets or sets the property controller for particle position.</summary>
		public SCNParticlePropertyController? Position {
			get {
				return dict [SCNParticleProperty.Position] as SCNParticlePropertyController;
			}
			set {
				Set (SCNParticleProperty.Position, value);
			}
		}

	/// <summary>Gets or sets the property controller for particle angle.</summary>
		public SCNParticlePropertyController? Angle {
			get {
				return dict [SCNParticleProperty.Angle] as SCNParticlePropertyController;
			}
			set {
				Set (SCNParticleProperty.Angle, value);
			}
		}

	/// <summary>Gets or sets the property controller for particle rotation axis.</summary>
		public SCNParticlePropertyController? RotationAxis {
			get {
				return dict [SCNParticleProperty.RotationAxis] as SCNParticlePropertyController;
			}
			set {
				Set (SCNParticleProperty.RotationAxis, value);
			}
		}

	/// <summary>Gets or sets the property controller for particle velocity.</summary>
		public SCNParticlePropertyController? Velocity {
			get {
				return dict [SCNParticleProperty.Velocity] as SCNParticlePropertyController;
			}
			set {
				Set (SCNParticleProperty.Velocity, value);
			}
		}

	/// <summary>Gets or sets the property controller for particle angular velocity.</summary>
		public SCNParticlePropertyController? AngularVelocity {
			get {
				return dict [SCNParticleProperty.AngularVelocity] as SCNParticlePropertyController;
			}
			set {
				Set (SCNParticleProperty.AngularVelocity, value);
			}
		}

	/// <summary>Gets or sets the property controller for particle life.</summary>
		public SCNParticlePropertyController? Life {
			get {
				return dict [SCNParticleProperty.Life] as SCNParticlePropertyController;
			}
			set {
				Set (SCNParticleProperty.Life, value);
			}
		}

	/// <summary>Gets or sets the property controller for particle color.</summary>
		public SCNParticlePropertyController? Color {
			get {
				return dict [SCNParticleProperty.Color] as SCNParticlePropertyController;
			}
			set {
				Set (SCNParticleProperty.Color, value);
			}
		}

	/// <summary>Gets or sets the property controller for particle opacity.</summary>
		public SCNParticlePropertyController? Opacity {
			get {
				return dict [SCNParticleProperty.Opacity] as SCNParticlePropertyController;
			}
			set {
				Set (SCNParticleProperty.Opacity, value);
			}
		}

	/// <summary>Gets or sets the property controller for particle size.</summary>
		public SCNParticlePropertyController? Size {
			get {
				return dict [SCNParticleProperty.Size] as SCNParticlePropertyController;
			}
			set {
				Set (SCNParticleProperty.Size, value);
			}
		}

	/// <summary>Gets or sets the property controller for particle frame.</summary>
		public SCNParticlePropertyController? Frame {
			get {
				return dict [SCNParticleProperty.Frame] as SCNParticlePropertyController;
			}
			set {
				Set (SCNParticleProperty.Frame, value);
			}
		}

	/// <summary>Gets or sets the property controller for particle frame rate.</summary>
		public SCNParticlePropertyController? FrameRate {
			get {
				return dict [SCNParticleProperty.FrameRate] as SCNParticlePropertyController;
			}
			set {
				Set (SCNParticleProperty.FrameRate, value);
			}
		}

	/// <summary>Gets or sets the property controller for particle bounce.</summary>
		public SCNParticlePropertyController? Bounce {
			get {
				return dict [SCNParticleProperty.Bounce] as SCNParticlePropertyController;
			}
			set {
				Set (SCNParticleProperty.Bounce, value);
			}
		}

	/// <summary>Gets or sets the property controller for particle charge.</summary>
		public SCNParticlePropertyController? Charge {
			get {
				return dict [SCNParticleProperty.Charge] as SCNParticlePropertyController;
			}
			set {
				Set (SCNParticleProperty.Charge, value);
			}
		}

	/// <summary>Gets or sets the property controller for particle friction.</summary>
		public SCNParticlePropertyController? Friction {
			get {
				return dict [SCNParticleProperty.Friction] as SCNParticlePropertyController;
			}
			set {
				Set (SCNParticleProperty.Friction, value);
			}
		}

	}

	public partial class SCNParticleSystem {
		/// <summary>Gets or sets a dictionary of controllers that animate different properties of particles in the system.</summary>
		public SCNPropertyControllers? PropertyControllers {
			get {
				var weak = WeakPropertyControllers;
				if (weak is null)
					return null;
				return new SCNPropertyControllers (weak);
			}
			set {
				WeakPropertyControllers = value?.dict;
			}
		}
	}
}
