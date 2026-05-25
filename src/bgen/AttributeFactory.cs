using System.Collections.Generic;
using System.Linq;

#nullable enable

public static partial class AttributeFactory {

	public static T CreateNewAttribute<T> (Type [] ctorTypes, object? [] ctorValues)
		where T : Attribute
	{
		var attribType = typeof (T);
		var ctor = attribType.GetConstructor (ctorTypes);
		if (ctor is null)
			throw ErrorHelper.CreateError (1058, attribType.FullName);

		return (T) ctor.Invoke (ctorValues);
	}

	public static T CreateNewAttribute<T> (PlatformName platform, int major, int minor, string? message = null)
		where T : Attribute
	{
		var args = new ConstructorArguments (platform, major, minor, message);
		return CreateNewAttribute<T> (args.GetCtorTypes (), args.GetCtorValues ());
	}

	public static T CreateNewAttribute<T> (PlatformName platform, int major, int minor, int build, string? message = null)
		where T : Attribute
	{
		var args = new ConstructorArguments (platform, major, minor, build, message);
		return CreateNewAttribute<T> (args.GetCtorTypes (), args.GetCtorValues ());
	}

	public static T CreateNewAttribute<T> (PlatformName platform, string? message = null) where T : Attribute
	{
		var args = new ConstructorArguments (platform, message);
		return CreateNewAttribute<T> (args.GetCtorTypes (), args.GetCtorValues ());
	}

	static readonly IntroducedAttribute [] noVersionSupportedCache = new IntroducedAttribute [] {
		new (PlatformName.iOS),
		new (PlatformName.TvOS),
		new (PlatformName.MacOSX),
		new (PlatformName.MacCatalyst),
	};

	static readonly UnavailableAttribute [] unsupportedCache = new UnavailableAttribute [] {
		new (PlatformName.iOS),
		new (PlatformName.MacCatalyst),
		new (PlatformName.MacOSX),
		new (PlatformName.TvOS),
	};

	public static IntroducedAttribute CreateNoVersionSupportedAttribute (PlatformName platform)
	{
		switch (platform) {
		case PlatformName.iOS:
			return noVersionSupportedCache [0];
		case PlatformName.TvOS:
			return noVersionSupportedCache [1];
		case PlatformName.MacOSX:
			return noVersionSupportedCache [2];
		case PlatformName.MacCatalyst:
			return noVersionSupportedCache [3];
		case PlatformName.WatchOS:
			throw new InvalidOperationException ("CreateNoVersionSupportedAttribute for WatchOS never makes sense");
		default:
			throw new NotImplementedException ();
		}
	}

	public static UnavailableAttribute CreateUnsupportedAttribute (PlatformName platform)
	{
		switch (platform) {
		case PlatformName.iOS:
			return unsupportedCache [0];
		case PlatformName.MacCatalyst:
			return unsupportedCache [1];
		case PlatformName.MacOSX:
			return unsupportedCache [2];
		case PlatformName.TvOS:
			return unsupportedCache [3];
		case PlatformName.WatchOS:
			throw new InvalidOperationException ("CreateUnsupportedAttribute for WatchOS never makes sense");
		default:
			throw new NotImplementedException ();
		}
	}

	public static AvailabilityBaseAttribute CloneFromOtherPlatform (AvailabilityBaseAttribute attr, PlatformName platform)
	{
		if (attr.Version is null && string.IsNullOrEmpty (attr.Message)) {
			// For no-version, no-message attributes, return the cached singletons
			switch (attr.AvailabilityKind) {
			case AvailabilityKind.Introduced:
				return CreateNoVersionSupportedAttribute (platform);
			case AvailabilityKind.Unavailable:
				return CreateUnsupportedAttribute (platform);
			}
		}

		if (attr.Version is null) {
			switch (attr.AvailabilityKind) {
			case AvailabilityKind.Introduced:
				return new IntroducedAttribute (platform, message: attr.Message);
			case AvailabilityKind.Deprecated:
				return new DeprecatedAttribute (platform, message: attr.Message);
			case AvailabilityKind.Obsoleted:
				return new ObsoletedAttribute (platform, message: attr.Message);
			case AvailabilityKind.Unavailable:
				return new UnavailableAttribute (platform, message: attr.Message);
			default:
				throw new NotImplementedException ();
			}
		}

		// Due to the absurd API of Version, you can not pass a -1 to the build constructor
		// nor can you coerse to 0, as that will fail with "16.0.0 <= 16.0" => false in the registrar
		// So determine if the build is -1, and use the 2 or 3 param ctor...
		var version = attr.Version;
		var minimum = Xamarin.SdkVersions.GetMinVersion (platform.AsApplePlatform ());
		if (version < minimum)
			version = minimum;

		if (version.Build == -1) {
			switch (attr.AvailabilityKind) {
			case AvailabilityKind.Introduced:
				return new IntroducedAttribute (platform, version.Major, version.Minor, message: attr.Message);
			case AvailabilityKind.Deprecated:
				return new DeprecatedAttribute (platform, version.Major, version.Minor, message: attr.Message);
			case AvailabilityKind.Obsoleted:
				return new ObsoletedAttribute (platform, version.Major, version.Minor, message: attr.Message);
			case AvailabilityKind.Unavailable:
				return new UnavailableAttribute (platform, message: attr.Message);
			default:
				throw new NotImplementedException ();
			}
		}

		switch (attr.AvailabilityKind) {
		case AvailabilityKind.Introduced:
			return new IntroducedAttribute (platform, version.Major, version.Minor, version.Build, message: attr.Message);
		case AvailabilityKind.Deprecated:
			return new DeprecatedAttribute (platform, version.Major, version.Minor, version.Build, message: attr.Message);
		case AvailabilityKind.Obsoleted:
			return new ObsoletedAttribute (platform, version.Major, version.Minor, version.Build, message: attr.Message);
		case AvailabilityKind.Unavailable:
			return new UnavailableAttribute (platform, message: attr.Message);
		default:
			throw new NotImplementedException ();
		}
	}

	// Find the introduced attribute with the highest version between the target list and the additions.
	// If the destination list has an introduced attribute, replace it if it's not the one with the highest version
	// If the destination list does not have an introduced attribute, then add one if there's one in the additions and there's not already an unavailable attribute.
	public static void FindHighestIntroducedAttributes (List<AvailabilityBaseAttribute> dest, List<AvailabilityBaseAttribute> additions)
	{
		if (additions.Count == 0)
			return;

		foreach (var platform in BindingTouch.AllPlatformNames) {
			// find the availability attribute with the highest version we're trying to add
			AvailabilityBaseAttribute? latestAddition = null;
			for (int j = 0; j < additions.Count; j++) {
				var v = additions [j];
				if (v.AvailabilityKind == AvailabilityKind.Introduced && v.Platform == platform) {
					if (latestAddition is null || (v.Version is not null && (latestAddition.Version is null || v.Version > latestAddition.Version)))
						latestAddition = v;
				}
			}
			if (latestAddition is null)
				continue;

			var added = CloneFromOtherPlatform (latestAddition, latestAddition.Platform);
			int idx = -1;
			for (int i = 0; i < dest.Count; i++) {
				if (dest [i].Platform == platform && dest [i].AvailabilityKind == AvailabilityKind.Introduced) {
					idx = i;
					break;
				}
			}
			if (idx == -1) {
				// no existing introduced attribute: add it unless there's already an unavailable attribute
				bool hasUnavailable = false;
				for (int i = 0; i < dest.Count; i++) {
					if (dest [i].Platform == platform && dest [i].AvailabilityKind == AvailabilityKind.Unavailable) {
						hasUnavailable = true;
						break;
					}
				}
				if (!hasUnavailable)
					dest.Add (added);
			} else if (added.Version > dest [idx].Version) {
				// replace any existing introduced attribute if the existing version is lower than the added one
				dest [idx] = added;
			}
		}
	}

	static bool IsValidToCopyTo (List<AvailabilityBaseAttribute> dest, AvailabilityBaseAttribute addition, bool allowIntroducedOnUnavailable = false)
	{
		// If we are duplicating an existing attribute
		for (int i = 0; i < dest.Count; i++) {
			if (dest [i].Platform == addition.Platform && dest [i].AvailabilityKind == addition.AvailabilityKind)
				return false;
		}
		// If we are introduced and there is already an Unavailable
		if (allowIntroducedOnUnavailable)
			return true;
		if (addition is not IntroducedAttribute)
			return true;
		for (int i = 0; i < dest.Count; i++) {
			if (dest [i].Platform == addition.Platform && dest [i].AvailabilityKind == AvailabilityKind.Unavailable)
				return false;
		}
		return true;
	}

	public static void CopyValidAttributes (List<AvailabilityBaseAttribute> dest, List<AvailabilityBaseAttribute> additions, AvailabilityKind? excludeKind = null)
	{
		for (int i = 0; i < additions.Count; i++) {
			var addition = additions [i];
			if (excludeKind is not null && addition.AvailabilityKind == excludeKind.Value)
				continue;
			if (IsValidToCopyTo (dest, addition))
				dest.Add (CloneFromOtherPlatform (addition, addition.Platform));
		}
	}
}
