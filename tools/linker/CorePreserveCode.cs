using System;

using Mono.Cecil;
using Mono.Linker;
using Mono.Linker.Steps;
using Mono.Tuner;

using Xamarin.Bundler;

namespace Xamarin.Linker {

	public class CorePreserveCode : IStep {

		public CorePreserveCode (I18nAssemblies i18n)
		{
			I18n = i18n;
		}

		protected LinkContext Context { get; private set; }

		protected AssemblyDefinition Corlib { get; private set; }

		protected I18nAssemblies I18n { get; private set; }

		public virtual void Process (LinkContext context)
		{
			Context = context;
			Corlib = context.GetAssembly (Driver.IsDotNet ? "System.Private.CoreLib" : "mscorlib");

			if (Corlib == null)
				throw ErrorHelper.CreateError (99, Errors.MX0099, "Could not find mscorlib.dll?");

			if (I18n.HasFlag (I18nAssemblies.MidEast)) {
				PreserveCalendar ("UmAlQuraCalendar");
				PreserveCalendar ("HijriCalendar");
			}
			if (I18n.HasFlag (I18nAssemblies.Other))
				PreserveCalendar ("ThaiBuddhistCalendar");

			PreserveResourceSet ();
		}

		void PreserveCalendar (string name)
		{
			var calendar = Corlib.MainModule.GetType ("System.Globalization", name);
			if (calendar == null || !calendar.HasMethods)
				return;

			// we just preserve the default .ctor so Activation.Create will work, 
			// the normal linker logic will do the rest
			foreach (MethodDefinition ctor in calendar.Methods) {
				if (ctor.IsConstructor && !ctor.IsStatic && !ctor.HasParameters) {
					Context.Annotations.AddPreservedMethod (calendar, ctor);
					// we need to mark the type or the above won't be processed
					Context.Annotations.Mark (calendar);
				}
			}
		}

		void PreserveResourceSet ()
		{
			var resource_set = Corlib.MainModule.GetType ("System.Resources", "RuntimeResourceSet");
			if (resource_set == null || !resource_set.HasMethods)
				return;

			foreach (MethodDefinition ctor in resource_set.Methods) {
				if (ctor.IsConstructor)
					Context.Annotations.AddPreservedMethod (resource_set, ctor);
			}
		}
	}
}