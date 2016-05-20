//
// main.m: Basic startup code for Mono on the iPhone
// 
// Authors:
//   Geoff Norton
//   Rolf Bjarne Kvinge <rolf@xamarin.com>
//
// Copyright 2009 Novell, Inc.
// Copyright 2011-2012 Xamarin Inc. 
//

#include <UIKit/UIKit.h>
#include <sys/time.h>
#include <zlib.h>
#include <dlfcn.h>
#include <objc/message.h>
#include <sys/mman.h>

#include "xamarin/xamarin.h"
#include "monotouch-debug.h"

#include "shared.h"
#include "product.h"
#include "runtime-internal.h"
#include "delegates.h"

#if defined(__x86_64__)
#include "../tools/mtouch/monotouch-fixes.c"
#endif

const char *monotouch_dll = NULL; // NULL = try Xamarin.iOS.dll first, then monotouch.dll.

static unsigned char *
xamarin_load_aot_data (MonoAssembly *assembly, int size, gpointer user_data, void **out_handle)
{
	// COOP: This is a callback called by the AOT runtime, I believe we don't have to change the GC mode here (even though it accesses managed memory).
	*out_handle = NULL;
	
	const char *name = mono_assembly_name_get_name (mono_assembly_get_name (assembly));
	char *path;
	const char *pattern;
	
	if (xamarin_use_new_assemblies) {
		pattern = "%s/" ARCH_SUBDIR "/%s.%s.aotdata";
	} else {
		pattern = "%s/%s.%s.aotdata";
	}
	path = xamarin_strdup_printf (pattern, [[[NSBundle mainBundle] bundlePath] UTF8String], name, xamarin_arch_name);
	
	int fd = open (path, O_RDONLY);
	if (fd < 0) {
		LOG (PRODUCT ": Could not load the aot data for %s from %s: %s\n", name, path, strerror (errno));
		xamarin_free (path);
		return NULL;
	}
	xamarin_free (path);

	void *ptr = mmap (NULL, size, PROT_READ, MAP_FILE | MAP_PRIVATE, fd, 0);
	if (ptr == MAP_FAILED) {
		LOG (PRODUCT ": Could not map the aot file for %s: %s\n", name, strerror (errno));
		close (fd);
		return NULL;
	}
	
	close (fd);

	//LOG (PRODUCT ": Loaded aot data for %s successfully.\n", name);

	*out_handle = ptr;

	return (unsigned char *) ptr;
}

static void
xamarin_free_aot_data (MonoAssembly *assembly, int size, gpointer user_data, void *handle)
{
	// COOP: This is a callback called by the AOT runtime, I belive we don't have to change the GC mode here.
	munmap (handle, size);
}

/*
This hook avoids the gazillion of filesystem probes we do as part of assembly loading.
*/
MonoAssembly*
assembly_preload_hook (MonoAssemblyName *aname, char **assemblies_path, void* user_data)
{
	// COOP: This is a callback called by the AOT runtime, I belive we don't have to change the GC mode here.
	char filename [1024];
	char path [1024];
	const char *name = mono_assembly_name_get_name (aname);
	const char *culture = mono_assembly_name_get_culture (aname);
	int len = strlen (name);
	int has_extension = len > 3 && name [len - 4] == '.' && (!strcmp ("exe", name + (len - 3)) || !strcmp ("dll", name + (len - 3)));
	bool dual_check = false;

	// add extensions if required.
	strncpy (filename, name, 1024);
	if (!has_extension) {	
		// Figure out if we need to append 'dll' or 'exe'
		if (xamarin_executable_name != NULL) {
			// xamarin_executable_name already has the ".exe", so only compare the rest of the filename.
			if (culture == NULL && !strncmp (xamarin_executable_name, filename, strlen (xamarin_executable_name) - 4)) {
				strcat (filename, ".exe");
			} else {
				strcat (filename, ".dll");
			}
		} else {
			// we need to check both :|
			dual_check = true;
			// start with .dll
			strcat (filename, ".dll");
		}
	}

	if (culture == NULL)
		culture = "";

do_second_check:
	if (xamarin_use_new_assemblies) {
		snprintf (path, sizeof (path), "%s/" ARCH_SUBDIR "/%s/%s", xamarin_get_bundle_path (), culture, filename);

		if (xamarin_file_exists (path)) {
			// fprintf (stderr, "MonoTouch: loading %s\n", path);
			return mono_assembly_open (path, NULL);
		}
	}
			
	snprintf (path, sizeof (path), "%s/%s/%s", xamarin_get_bundle_path (), culture, filename);

	if (xamarin_file_exists (path)) {
		// fprintf (stderr, "MonoTouch: loading %s\n", path);
		return mono_assembly_open (path, NULL);
	}

	if (dual_check) {
		dual_check = false;
		filename [strlen (filename) - 4] = 0;
		strcat (filename, ".exe");
		goto do_second_check;
	}

	//fprintf (stderr, "MonoTouch: unable to find %s\n", name);

	return NULL;
}

#ifdef DEBUG_LAUNCH_TIME
guint64 startDate = 0;
guint64 date = 0;
void debug_launch_time_print (const char *msg)
{
	guint64 unow;
	struct timeval now;

	gettimeofday (&now, NULL);
	unow = now.tv_sec * 1000000ULL + now.tv_usec;

	if (startDate == 0) {
		startDate = unow;
		date = startDate;
	}

	NSLog (@"%s: %llu us Total: %llu us", msg, unow - date, unow - startDate);

	date = unow;
}
#else
inline void debug_launch_time_print (const char *msg)
{
}
#endif

/*
 * This class will listen for memory warnings and when received, force
 * a full garbage collection.
 * 
 * On device it will also delay the creation of the finalizer thread for 5 seconds
 * in release builds.
 */

#if defined (__arm__) || defined(__aarch64__)
extern void mono_gc_init_finalizer_thread (void);
#endif

@interface XamarinGCSupport : NSObject {
}
- (id) init;
- (void) start;
@end

@implementation XamarinGCSupport
- (id) init
{
#if TARGET_OS_WATCH
	// I haven't found a way to listen for memory warnings on watchOS.
	// fprintf (stderr, "Need to listen for memory warnings on the watch\n");
#else
	if (self = [super init]) {
#if defined (__arm__) || defined(__aarch64__)
		[self start];
#endif
		[[NSNotificationCenter defaultCenter] addObserver:self selector:@selector(memoryWarning:) name:UIApplicationDidReceiveMemoryWarningNotification object:nil];
	}
#endif /* TARGET_OS_WATCH */

	return self;
}

- (void) start
{
	// COOP: ?
#if defined (__arm__) || defined(__aarch64__)
	mono_gc_init_finalizer_thread ();
#endif
}

- (void) memoryWarning: (NSNotification *) sender
{
	// COOP: ?
	mono_gc_collect (mono_gc_max_generation ());
}

@end

/*
 * The main method
 */

int
xamarin_main (int argc, char *argv[], bool is_extension)
{
	// COOP: ?
	// + 1 for the initial "monotouch" +1 for the final NULL = +2.
	// This is not an exact number (it will most likely be lower, since there
	// are other arguments besides --app-arg), but it's a guaranteed and bound
	// upper limit.
	const char *managed_argv [argc + 2];
	int managed_argc = 1;

#if defined(__x86_64__)
	patch_sigaction ();
#endif

	memset (managed_argv, 0, sizeof (char*) * (argc + 2));
	managed_argv [0] = "monotouch";

	DEBUG_LAUNCH_TIME_PRINT ("Main entered");

	xamarin_setup ();
	DEBUG_LAUNCH_TIME_PRINT ("MonoTouch setup time");

	MonoAssembly *assembly;
	
	const char *c_bundle_path = xamarin_get_bundle_path ();

	chdir (c_bundle_path);
	setenv ("MONO_PATH", c_bundle_path, 1);

	setenv ("MONO_XMLSERIALIZER_THS", "no", 1);
	setenv ("DYLD_BIND_AT_LAUNCH", "1", 1);
	setenv ("MONO_REFLECTION_SERIALIZER", "yes", 1);


#if TARGET_OS_WATCH || TARGET_OS_TV
	mini_parse_debug_option ("explicit-null-checks");
	signal (SIGPIPE, SIG_IGN);
#endif
	// see http://bugzilla.xamarin.com/show_bug.cgi?id=820
	// take this line out once the bug is fixed
	mini_parse_debug_option ("no-gdb-backtrace");
	if (xamarin_compact_seq_points)
		mini_parse_debug_option ("gen-compact-seq-points");

	DEBUG_LAUNCH_TIME_PRINT ("Spin-up time");

	{
		/*
		 * Command line arguments:
		 * -debugtrack: [Simulator only]
		 *         If we should track zombie NSObjects and aggressively poke the GC to collect
		 *         every second.
		 * -monodevelop-port=<port>
		 *         The port MonoDevelop is listening on (or we should listen on).
		 *         Overrides whatever any configuration file says.
		 * -debug: 
		 *         Enables debugging (it is enabled by default, but maybe one day in the future
		 *         we can disable it by default so that when the user clicks on the app on the
		 *         device while *not* debugging he doesn't have to wait 2 extra seconds for it
		 *         to start up).
		 * -connection-mode=[wifi|usb|none]:
		 *         Select how to connect (or not) to MonoDevelop. No need to rebuild the
		 *         app anymore when switching between wifi and usb debugging since this
		 *         option overrides whatever the configuration files says. Setting 'none'
		 *         when not debugging or profiling saves 2s on startup (since the app
		 *         won't try to connect to MonoDevelop). If not set the current default is
		 *         to check the configuration files (some time in the future this will be
		 *         changed, so that it defaults to 'none'. This way there will be no 
		 *         2s delay on startup when running it manually by clicking on the icon).
		 * -app-arg=<argument>:
		 *         <argument> will be passed to the app as a command line argument. Can be
		 *         specified multiple times.
		 * -setenv=<key>=<value>
		 *         Set the environment variable <key> to the value <value>
		 */
		int i = 0;
		for (i = 0; i < argc; i++) {
			char *arg = argv [i];
			char *name;
			char *value;
			
			if (arg [0] == '-') {
				arg++;
				if (arg [0] == '-')
					arg++;
			} else if (arg [0] == '/') {
				arg++;
			} else {
				continue;
			}
			
			value = arg;
			name = NULL;
			
			while (*++value) {
				if (*value == '=' || *value == ':') {
					name = strndup (arg, value - arg);
					value++;
					break;
				}
			}
			
			if (name == NULL)
				name = strdup (arg);
			
			if (*value == 0)
				value = NULL;

#ifdef DEBUG
			if (!strcmp (name, "debugtrack")) {
				xamarin_gc_pump = true;
			} else if (!strcmp (name, "monodevelop-port")) {
				if (!value && argc > i + 1)
					value = argv [++i];
				if (value) {
					monotouch_set_monodevelop_port (strtol (value, NULL, 10));
				} else {
					NSLog (@"MonoTouch: --%s requires an argument.", name);
				}
			} else if (!strcmp (name, "connection-mode")) {
				if (!value && argc > i + 1)
					value = argv [++i];
				if (value) {
					monotouch_set_connection_mode (value);
				} else {
					NSLog (@"MonoTouch: --%s requires an argument.", name);
				}
			} 
#endif /* DEBUG */

			if (!strcmp (name, "app-arg")) {
				if (!value && argc > i + 1)
					value = argv [++i];
				if (value) {
					managed_argv [managed_argc++] = value;
				} else {
					NSLog (@"MonoTouch: --%s requires an argument.", name);
				}
			} else if (!strcmp (name, "setenv")) {
				if (!value && argc > i + 1)
					value = argv [++i];
				if (value) {
					char *k = strdup (value);
					char *v = strchr (k, '=');
					if (v) {
						*v = 0;
						v++;
						LOG ("MonoTouch: Setting %s=%s", k, v);
						setenv (k, v, 1);
					}
					free (k);
				} else {
					NSLog (@"MonoTouch: --%s requires an argument.", name);
				}
			}
			
			free (name);
		}
	}

#ifdef DEBUG
	initialize_cocoa_threads (monotouch_configure_debugging);
#else
	initialize_cocoa_threads (NULL);
#endif

#if defined (__arm__) || defined(__aarch64__)
	xamarin_register_modules ();
	mono_jit_set_aot_only (TRUE);
#endif
	DEBUG_LAUNCH_TIME_PRINT ("\tAOT register time");

#ifdef DEBUG
	monotouch_start_debugging ();
	DEBUG_LAUNCH_TIME_PRINT ("\tDebug init time");
#endif
	
	if (xamarin_init_mono_debug)
		mono_debug_init (MONO_DEBUG_FORMAT_MONO);
	
	mono_install_assembly_preload_hook (assembly_preload_hook, NULL);
	mono_install_load_aot_data_hook (xamarin_load_aot_data, xamarin_free_aot_data, NULL);

#ifdef DEBUG
	monotouch_start_profiling ();
	DEBUG_LAUNCH_TIME_PRINT ("\tProfiler config time");
#endif

	mono_set_signal_chaining (TRUE);
	mono_install_unhandled_exception_hook (xamarin_unhandled_exception_handler, NULL);

	mono_jit_init_version ("MonoTouch", "mobile");
	/*
	  As part of mono initialization a preload hook is added that overrides ours, so we need to re-instate it here.
	  This is wasteful, but there's no way to manipulate the preload hook list except by adding to it.
	*/
	mono_install_assembly_preload_hook (assembly_preload_hook, NULL);
	DEBUG_LAUNCH_TIME_PRINT ("\tJIT init time");

	xamarin_initialize ();
	DEBUG_LAUNCH_TIME_PRINT ("\tmonotouch init time");

#if defined (__arm__) || defined(__aarch64__)
	xamarin_register_assemblies ();
	assembly = xamarin_open_and_register (xamarin_executable_name);
#else
	if (xamarin_executable_name) {
		assembly = xamarin_open_and_register (xamarin_executable_name);
	} else {
		const char *last_slash = strrchr (argv [0], '/');
		const char *basename = last_slash ? last_slash + 1 : argv [0];
		char *aname = xamarin_strdup_printf ("%s.exe", basename);

		assembly = xamarin_open_and_register (aname);

		xamarin_free (aname);
	}

	xamarin_register_entry_assembly (mono_assembly_get_object (mono_domain_get (), assembly));
#endif

	DEBUG_LAUNCH_TIME_PRINT ("\tAssembly register time");

	[[[XamarinGCSupport alloc] init] autorelease];

	DEBUG_LAUNCH_TIME_PRINT ("\tGC defer time");

	DEBUG_LAUNCH_TIME_PRINT ("Total initialization time");

	int rv = 0;
	if (is_extension) {
		MONO_ENTER_GC_SAFE;
		rv = xamarin_extension_main (argc, argv);
		MONO_EXIT_GC_SAFE;
	} else {
		mono_jit_exec (mono_domain_get (), assembly, managed_argc, managed_argv);
	}
	
	return rv;
}
