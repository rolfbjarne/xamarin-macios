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

static unsigned char *
xamarin_load_aot_data (MonoAssembly *assembly, int size, gpointer user_data, void **out_handle)
{
	// COOP: This is a callback called by the AOT runtime, I believe we don't have to change the GC mode here (even though it accesses managed memory).
	*out_handle = NULL;

	char path [1024];
	char name [1024];
	MonoAssemblyName *assembly_name = mono_assembly_get_name (assembly);
	const char *aname = mono_assembly_name_get_name (assembly_name);
	xamarin_get_assembly_name_without_extension (aname, name, sizeof (name));

	// LOG (PRODUCT ": Looking for aot data for assembly '%s'.", name);

	strlcat (name, ".aotdata", sizeof (name));

	bool found = xamarin_locate_assembly_resource_for_name (assembly_name, name, path, sizeof (path));

	if (!found) {
		LOG (PRODUCT ": Could not find the aot data for %s.\n", aname)
		return NULL;
	}
	
	int fd = open (path, O_RDONLY);
	if (fd < 0) {
		LOG (PRODUCT ": Could not load the aot data for %s from %s: %s\n", aname, path, strerror (errno));
		return NULL;
	}

	void *ptr = mmap (NULL, size, PROT_READ, MAP_FILE | MAP_PRIVATE, fd, 0);
	if (ptr == MAP_FAILED) {
		LOG (PRODUCT ": Could not map the aot file for %s: %s\n", aname, strerror (errno));
		close (fd);
		return NULL;
	}
	
	close (fd);

	//LOG (PRODUCT ": Loaded aot data for %s.\n", name);

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
static MonoAssembly*
assembly_preload_hook (MonoAssemblyName *aname, char **assemblies_path, void* user_data)
{
	// COOP: This is a callback called by the AOT runtime, I belive we don't have to change the GC mode here.
	char filename [1024];
	char path [1024];
	const char *name = mono_assembly_name_get_name (aname);
	const char *culture = mono_assembly_name_get_culture (aname);

	// LOG (PRODUCT ": Looking for assembly '%s' (culture: '%s')\n", name, culture);

	int len = strlen (name);
	int has_extension = len > 3 && name [len - 4] == '.' && (!strcmp ("exe", name + (len - 3)) || !strcmp ("dll", name + (len - 3)));
	bool dual_check = false;

	// add extensions if required.
	strlcpy (filename, name, sizeof (filename));
	if (!has_extension) {	
		// Figure out if we need to append 'dll' or 'exe'
		if (xamarin_executable_name != NULL) {
			// xamarin_executable_name already has the ".exe", so only compare the rest of the filename.
			if (culture == NULL && !strncmp (xamarin_executable_name, filename, strlen (xamarin_executable_name) - 4)) {
				strlcat (filename, ".exe", sizeof (filename));
			} else {
				strlcat (filename, ".dll", sizeof (filename));
			}
		} else {
			// we need to check both :|
			dual_check = true;
			// start with .dll
			strlcat (filename, ".dll", sizeof (filename));
		}
	}

	if (culture == NULL)
		culture = "";

	bool found = xamarin_locate_assembly_resource_for_name (aname, filename, path, sizeof (path));
	if (!found && dual_check) {
		filename [strlen (filename) - 4] = 0;
		strlcat (filename, ".exe", sizeof (filename));
		found = xamarin_locate_assembly_resource_for_name (aname, filename, path, sizeof (path));
	}

	if (!found) {
		LOG (PRODUCT ": Unable to locate assembly '%s' (culture: '%s')\n", name, culture);
		return NULL;
	}

	// LOG (PRODUCT ": Found assembly '%s' (culture: '%s'): %s\n", name, culture, path);

	return mono_assembly_open (path, NULL);
}

#ifdef DEBUG_LAUNCH_TIME
uint64_t startDate = 0;
uint64_t date = 0;
void debug_launch_time_print (const char *msg)
{
	uint64_t unow;
	struct timeval now;

	gettimeofday (&now, NULL);
	unow = now.tv_sec * 1000000ULL + now.tv_usec;

	if (startDate == 0) {
		startDate = unow;
		date = startDate;
	}

	PRINT ("%s: %llu us Total: %llu us", msg, unow - date, unow - startDate);

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
	if (self = [super init]) {
#if defined (__arm__) || defined(__aarch64__)
		[self start];
#endif
#if TARGET_OS_WATCH
		// I haven't found a way to listen for memory warnings on watchOS.
		// fprintf (stderr, "Need to listen for memory warnings on the watch\n");
#else
		[[NSNotificationCenter defaultCenter] addObserver:self selector:@selector(memoryWarning:) name:UIApplicationDidReceiveMemoryWarningNotification object:nil];
#endif
	}

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
xamarin_main (int argc, char *argv[], enum XamarinLaunchMode launch_mode)
{
fprintf (stderr, "xamarin_main: 1\n");
	// COOP: ?
fprintf (stderr, "xamarin_main: 2\n");
	// + 1 for the initial "monotouch" +1 for the final NULL = +2.
fprintf (stderr, "xamarin_main: 3\n");
	// This is not an exact number (it will most likely be lower, since there
fprintf (stderr, "xamarin_main: 4\n");
	// are other arguments besides --app-arg), but it's a guaranteed and bound
fprintf (stderr, "xamarin_main: 5\n");
	// upper limit.
fprintf (stderr, "xamarin_main: 6\n");
	const char *managed_argv [argc + 2];
fprintf (stderr, "xamarin_main: 7\n");
	int managed_argc = 1;
fprintf (stderr, "xamarin_main: 8\n");

fprintf (stderr, "xamarin_main: 9\n");
#if defined(__x86_64__)
fprintf (stderr, "xamarin_main: 10\n");
	patch_sigaction ();
fprintf (stderr, "xamarin_main: 11\n");
#endif
fprintf (stderr, "xamarin_main: 12\n");

fprintf (stderr, "xamarin_main: 13\n");
	xamarin_launch_mode = launch_mode;
fprintf (stderr, "xamarin_main: 14\n");

fprintf (stderr, "xamarin_main: 15\n");
	memset (managed_argv, 0, sizeof (char*) * (argc + 2));
fprintf (stderr, "xamarin_main: 16\n");
	managed_argv [0] = "monotouch";
fprintf (stderr, "xamarin_main: 17\n");

fprintf (stderr, "xamarin_main: 18\n");
	DEBUG_LAUNCH_TIME_PRINT ("Main entered");
fprintf (stderr, "xamarin_main: 19\n");

fprintf (stderr, "xamarin_main: 20\n");
	xamarin_setup ();
fprintf (stderr, "xamarin_main: 21\n");
	DEBUG_LAUNCH_TIME_PRINT ("MonoTouch setup time");
fprintf (stderr, "xamarin_main: 22\n");

fprintf (stderr, "xamarin_main: 23\n");
	MonoAssembly *assembly;
fprintf (stderr, "xamarin_main: 24\n");
	guint32 exception_gchandle = 0;
fprintf (stderr, "xamarin_main: 25\n");
	
fprintf (stderr, "xamarin_main: 26\n");
	const char *c_bundle_path = xamarin_get_bundle_path ();
fprintf (stderr, "xamarin_main: 27\n");

fprintf (stderr, "xamarin_main: 28\n");
	chdir (c_bundle_path);
fprintf (stderr, "xamarin_main: 29\n");
	setenv ("MONO_PATH", c_bundle_path, 1);
fprintf (stderr, "xamarin_main: 30\n");

fprintf (stderr, "xamarin_main: 31\n");
	setenv ("MONO_XMLSERIALIZER_THS", "no", 1);
fprintf (stderr, "xamarin_main: 32\n");
	setenv ("DYLD_BIND_AT_LAUNCH", "1", 1);
fprintf (stderr, "xamarin_main: 33\n");
	setenv ("MONO_REFLECTION_SERIALIZER", "yes", 1);
fprintf (stderr, "xamarin_main: 34\n");

fprintf (stderr, "xamarin_main: 35\n");
#if TARGET_OS_WATCH
fprintf (stderr, "xamarin_main: 36\n");
	// watchOS can raise signals just fine...
fprintf (stderr, "xamarin_main: 37\n");
	// we might want to move this inside mono at some point.
fprintf (stderr, "xamarin_main: 38\n");
	signal (SIGPIPE, SIG_IGN);
fprintf (stderr, "xamarin_main: 39\n");
#endif
fprintf (stderr, "xamarin_main: 40\n");

fprintf (stderr, "xamarin_main: 41\n");
#if TARGET_OS_WATCH || TARGET_OS_TV
fprintf (stderr, "xamarin_main: 42\n");
	mini_parse_debug_option ("explicit-null-checks");
fprintf (stderr, "xamarin_main: 43\n");
#endif
fprintf (stderr, "xamarin_main: 44\n");
	// see http://bugzilla.xamarin.com/show_bug.cgi?id=820
fprintf (stderr, "xamarin_main: 45\n");
	// take this line out once the bug is fixed
fprintf (stderr, "xamarin_main: 46\n");
	mini_parse_debug_option ("no-gdb-backtrace");
fprintf (stderr, "xamarin_main: 47\n");

fprintf (stderr, "xamarin_main: 48\n");
	DEBUG_LAUNCH_TIME_PRINT ("Spin-up time");
fprintf (stderr, "xamarin_main: 49\n");

fprintf (stderr, "xamarin_main: 50\n");
	{
fprintf (stderr, "xamarin_main: 51\n");
		/*
fprintf (stderr, "xamarin_main: 52\n");
		 * Command line arguments:
fprintf (stderr, "xamarin_main: 53\n");
		 * -debugtrack: [Simulator only]
fprintf (stderr, "xamarin_main: 54\n");
		 *         If we should track zombie NSObjects and aggressively poke the GC to collect
fprintf (stderr, "xamarin_main: 55\n");
		 *         every second.
fprintf (stderr, "xamarin_main: 56\n");
		 * -monodevelop-port=<port>
fprintf (stderr, "xamarin_main: 57\n");
		 *         The port MonoDevelop is listening on (or we should listen on).
fprintf (stderr, "xamarin_main: 58\n");
		 *         Overrides whatever any configuration file says.
fprintf (stderr, "xamarin_main: 59\n");
		 * -debug: 
fprintf (stderr, "xamarin_main: 60\n");
		 *         Enables debugging (it is enabled by default, but maybe one day in the future
fprintf (stderr, "xamarin_main: 61\n");
		 *         we can disable it by default so that when the user clicks on the app on the
fprintf (stderr, "xamarin_main: 62\n");
		 *         device while *not* debugging he doesn't have to wait 2 extra seconds for it
fprintf (stderr, "xamarin_main: 63\n");
		 *         to start up).
fprintf (stderr, "xamarin_main: 64\n");
		 * -connection-mode=[wifi|usb|none]:
fprintf (stderr, "xamarin_main: 65\n");
		 *         Select how to connect (or not) to MonoDevelop. No need to rebuild the
fprintf (stderr, "xamarin_main: 66\n");
		 *         app anymore when switching between wifi and usb debugging since this
fprintf (stderr, "xamarin_main: 67\n");
		 *         option overrides whatever the configuration files says. Setting 'none'
fprintf (stderr, "xamarin_main: 68\n");
		 *         when not debugging or profiling saves 2s on startup (since the app
fprintf (stderr, "xamarin_main: 69\n");
		 *         won't try to connect to MonoDevelop). If not set the current default is
fprintf (stderr, "xamarin_main: 70\n");
		 *         to check the configuration files (some time in the future this will be
fprintf (stderr, "xamarin_main: 71\n");
		 *         changed, so that it defaults to 'none'. This way there will be no 
fprintf (stderr, "xamarin_main: 72\n");
		 *         2s delay on startup when running it manually by clicking on the icon).
fprintf (stderr, "xamarin_main: 73\n");
		 * -app-arg=<argument>:
fprintf (stderr, "xamarin_main: 74\n");
		 *         <argument> will be passed to the app as a command line argument. Can be
fprintf (stderr, "xamarin_main: 75\n");
		 *         specified multiple times.
fprintf (stderr, "xamarin_main: 76\n");
		 * -setenv=<key>=<value>
fprintf (stderr, "xamarin_main: 77\n");
		 *         Set the environment variable <key> to the value <value>
fprintf (stderr, "xamarin_main: 78\n");
		 */
fprintf (stderr, "xamarin_main: 79\n");
		int i = 0;
fprintf (stderr, "xamarin_main: 80\n");
		for (i = 0; i < argc; i++) {
fprintf (stderr, "xamarin_main: 81\n");
			char *arg = argv [i];
fprintf (stderr, "xamarin_main: 82\n");
			char *name;
fprintf (stderr, "xamarin_main: 83\n");
			char *value;
fprintf (stderr, "xamarin_main: 84\n");
			
fprintf (stderr, "xamarin_main: 85\n");
			if (arg [0] == '-') {
fprintf (stderr, "xamarin_main: 86\n");
				arg++;
fprintf (stderr, "xamarin_main: 87\n");
				if (arg [0] == '-')
fprintf (stderr, "xamarin_main: 88\n");
					arg++;
fprintf (stderr, "xamarin_main: 89\n");
			} else if (arg [0] == '/') {
fprintf (stderr, "xamarin_main: 90\n");
				arg++;
fprintf (stderr, "xamarin_main: 91\n");
			} else {
fprintf (stderr, "xamarin_main: 92\n");
				continue;
fprintf (stderr, "xamarin_main: 93\n");
			}
fprintf (stderr, "xamarin_main: 94\n");
			
fprintf (stderr, "xamarin_main: 95\n");
			value = arg;
fprintf (stderr, "xamarin_main: 96\n");
			name = NULL;
fprintf (stderr, "xamarin_main: 97\n");
			
fprintf (stderr, "xamarin_main: 98\n");
			while (*++value) {
fprintf (stderr, "xamarin_main: 99\n");
				if (*value == '=' || *value == ':') {
fprintf (stderr, "xamarin_main: 100\n");
					name = strndup (arg, value - arg);
fprintf (stderr, "xamarin_main: 101\n");
					value++;
fprintf (stderr, "xamarin_main: 102\n");
					break;
fprintf (stderr, "xamarin_main: 103\n");
				}
fprintf (stderr, "xamarin_main: 104\n");
			}
fprintf (stderr, "xamarin_main: 105\n");
			
fprintf (stderr, "xamarin_main: 106\n");
			if (name == NULL) {
fprintf (stderr, "xamarin_main: 107\n");
				name = strdup (arg);
fprintf (stderr, "xamarin_main: 108\n");
			}
fprintf (stderr, "xamarin_main: 109\n");
			
fprintf (stderr, "xamarin_main: 110\n");
			if (*value == 0) {
fprintf (stderr, "xamarin_main: 111\n");
				value = NULL;
fprintf (stderr, "xamarin_main: 112\n");
			}
fprintf (stderr, "xamarin_main: 113\n");

fprintf (stderr, "xamarin_main: 114\n");
#ifdef DEBUG
fprintf (stderr, "xamarin_main: 115\n");
			if (!strcmp (name, "debugtrack")) {
fprintf (stderr, "xamarin_main: 116\n");
				xamarin_gc_pump = true;
fprintf (stderr, "xamarin_main: 117\n");
			} else if (!strcmp (name, "monodevelop-port")) {
fprintf (stderr, "xamarin_main: 118\n");
				if (!value && argc > i + 1)
fprintf (stderr, "xamarin_main: 119\n");
					value = argv [++i];
fprintf (stderr, "xamarin_main: 120\n");
				if (value) {
fprintf (stderr, "xamarin_main: 121\n");
					monotouch_set_monodevelop_port (strtol (value, NULL, 10));
fprintf (stderr, "xamarin_main: 122\n");
				} else {
fprintf (stderr, "xamarin_main: 123\n");
					PRINT ("MonoTouch: --%s requires an argument.", name);
fprintf (stderr, "xamarin_main: 124\n");
				}
fprintf (stderr, "xamarin_main: 125\n");
			} else if (!strcmp (name, "connection-mode")) {
fprintf (stderr, "xamarin_main: 126\n");
				if (!value && argc > i + 1)
fprintf (stderr, "xamarin_main: 127\n");
					value = argv [++i];
fprintf (stderr, "xamarin_main: 128\n");
				if (value) {
fprintf (stderr, "xamarin_main: 129\n");
					monotouch_set_connection_mode (value);
fprintf (stderr, "xamarin_main: 130\n");
				} else {
fprintf (stderr, "xamarin_main: 131\n");
					PRINT ("MonoTouch: --%s requires an argument.", name);
fprintf (stderr, "xamarin_main: 132\n");
				}
fprintf (stderr, "xamarin_main: 133\n");
			} 
fprintf (stderr, "xamarin_main: 134\n");
#endif /* DEBUG */
fprintf (stderr, "xamarin_main: 135\n");

fprintf (stderr, "xamarin_main: 136\n");
			if (!strcmp (name, "app-arg")) {
fprintf (stderr, "xamarin_main: 137\n");
				if (!value && argc > i + 1)
fprintf (stderr, "xamarin_main: 138\n");
					value = argv [++i];
fprintf (stderr, "xamarin_main: 139\n");
				if (value) {
fprintf (stderr, "xamarin_main: 140\n");
					managed_argv [managed_argc++] = value;
fprintf (stderr, "xamarin_main: 141\n");
				} else {
fprintf (stderr, "xamarin_main: 142\n");
					PRINT ("MonoTouch: --%s requires an argument.", name);
fprintf (stderr, "xamarin_main: 143\n");
				}
fprintf (stderr, "xamarin_main: 144\n");
			} else if (!strcmp (name, "setenv")) {
fprintf (stderr, "xamarin_main: 145\n");
				if (!value && argc > i + 1) {
fprintf (stderr, "xamarin_main: 146\n");
					value = argv [++i];
fprintf (stderr, "xamarin_main: 147\n");
				}
fprintf (stderr, "xamarin_main: 148\n");
				if (value) {
fprintf (stderr, "xamarin_main: 149\n");
					char *k = strdup (value);
fprintf (stderr, "xamarin_main: 150\n");
					char *v = strchr (k, '=');
fprintf (stderr, "xamarin_main: 151\n");
					if (v) {
fprintf (stderr, "xamarin_main: 152\n");
						*v = 0;
fprintf (stderr, "xamarin_main: 153\n");
						v++;
fprintf (stderr, "xamarin_main: 154\n");
						LOG ("MonoTouch: Setting %s=%s", k, v);
fprintf (stderr, "xamarin_main: 155\n");
						setenv (k, v, 1);
fprintf (stderr, "xamarin_main: 156\n");
					}
fprintf (stderr, "xamarin_main: 157\n");
					free (k);
fprintf (stderr, "xamarin_main: 158\n");
				} else {
fprintf (stderr, "xamarin_main: 159\n");
					PRINT ("MonoTouch: --%s requires an argument.", name);
fprintf (stderr, "xamarin_main: 160\n");
				}
fprintf (stderr, "xamarin_main: 161\n");
			}
fprintf (stderr, "xamarin_main: 162\n");
			
fprintf (stderr, "xamarin_main: 163\n");
			free (name);
fprintf (stderr, "xamarin_main: 164\n");
		}
fprintf (stderr, "xamarin_main: 165\n");
	}
fprintf (stderr, "xamarin_main: 166\n");

fprintf (stderr, "xamarin_main: 167\n");
#ifdef DEBUG
fprintf (stderr, "xamarin_main: 168\n");
	xamarin_initialize_cocoa_threads (monotouch_configure_debugging);
fprintf (stderr, "xamarin_main: 169\n");
#else
fprintf (stderr, "xamarin_main: 170\n");
	xamarin_initialize_cocoa_threads (NULL);
fprintf (stderr, "xamarin_main: 171\n");
#endif
fprintf (stderr, "xamarin_main: 172\n");

fprintf (stderr, "xamarin_main: 173\n");
#if defined (__arm__) || defined(__aarch64__)
fprintf (stderr, "xamarin_main: 174\n");
	xamarin_register_modules ();
fprintf (stderr, "xamarin_main: 175\n");
#endif
fprintf (stderr, "xamarin_main: 176\n");
	DEBUG_LAUNCH_TIME_PRINT ("\tAOT register time");
fprintf (stderr, "xamarin_main: 177\n");

fprintf (stderr, "xamarin_main: 178\n");
#ifdef DEBUG
fprintf (stderr, "xamarin_main: 179\n");
	monotouch_start_debugging ();
fprintf (stderr, "xamarin_main: 180\n");
	DEBUG_LAUNCH_TIME_PRINT ("\tDebug init time");
fprintf (stderr, "xamarin_main: 181\n");
#endif
fprintf (stderr, "xamarin_main: 182\n");
	
fprintf (stderr, "xamarin_main: 183\n");
	if (xamarin_init_mono_debug) {
fprintf (stderr, "xamarin_main: 184\n");
		mono_debug_init (MONO_DEBUG_FORMAT_MONO);
fprintf (stderr, "xamarin_main: 185\n");
	}
fprintf (stderr, "xamarin_main: 186\n");
	
fprintf (stderr, "xamarin_main: 187\n");
	mono_install_assembly_preload_hook (assembly_preload_hook, NULL);
fprintf (stderr, "xamarin_main: 188\n");
	mono_install_load_aot_data_hook (xamarin_load_aot_data, xamarin_free_aot_data, NULL);
fprintf (stderr, "xamarin_main: 189\n");

fprintf (stderr, "xamarin_main: 190\n");
#ifdef DEBUG
fprintf (stderr, "xamarin_main: 191\n");
	monotouch_start_profiling ();
fprintf (stderr, "xamarin_main: 192\n");
	DEBUG_LAUNCH_TIME_PRINT ("\tProfiler config time");
fprintf (stderr, "xamarin_main: 193\n");
#endif
fprintf (stderr, "xamarin_main: 194\n");

fprintf (stderr, "xamarin_main: 195\n");
	mono_set_signal_chaining (TRUE);
fprintf (stderr, "xamarin_main: 196\n");
	mono_set_crash_chaining (TRUE);
fprintf (stderr, "xamarin_main: 197\n");
	mono_install_unhandled_exception_hook (xamarin_unhandled_exception_handler, NULL);
fprintf (stderr, "xamarin_main: 198\n");
	mono_install_ftnptr_eh_callback (xamarin_ftnptr_exception_handler);
fprintf (stderr, "xamarin_main: 199\n");

fprintf (stderr, "xamarin_main: 200\n");
	mono_jit_init_version ("MonoTouch", "mobile");
fprintf (stderr, "xamarin_main: 201\n");
	/*
fprintf (stderr, "xamarin_main: 202\n");
	  As part of mono initialization a preload hook is added that overrides ours, so we need to re-instate it here.
fprintf (stderr, "xamarin_main: 203\n");
	  This is wasteful, but there's no way to manipulate the preload hook list except by adding to it.
fprintf (stderr, "xamarin_main: 204\n");
	*/
fprintf (stderr, "xamarin_main: 205\n");
	mono_install_assembly_preload_hook (assembly_preload_hook, NULL);
fprintf (stderr, "xamarin_main: 206\n");
	DEBUG_LAUNCH_TIME_PRINT ("\tJIT init time");
fprintf (stderr, "xamarin_main: 207\n");

fprintf (stderr, "xamarin_main: 208\n");
	xamarin_initialize ();
fprintf (stderr, "xamarin_main: 209\n");
	DEBUG_LAUNCH_TIME_PRINT ("\tmonotouch init time");
fprintf (stderr, "xamarin_main: 210\n");

fprintf (stderr, "xamarin_main: 211\n");
#if defined (__arm__) || defined(__aarch64__)
fprintf (stderr, "xamarin_main: 212\n");
	xamarin_register_assemblies ();
fprintf (stderr, "xamarin_main: 213\n");
	assembly = xamarin_open_and_register (xamarin_executable_name, &exception_gchandle);
fprintf (stderr, "xamarin_main: 214\n");
	if (exception_gchandle != 0) {
fprintf (stderr, "xamarin_main: 215\n");
		xamarin_process_managed_exception_gchandle (exception_gchandle);
fprintf (stderr, "xamarin_main: 216\n");
	}
fprintf (stderr, "xamarin_main: 217\n");
#else
fprintf (stderr, "xamarin_main: 218\n");
	if (xamarin_executable_name) {
fprintf (stderr, "xamarin_main: 219\n");
		assembly = xamarin_open_and_register (xamarin_executable_name, &exception_gchandle);
fprintf (stderr, "xamarin_main: 220\n");
		if (exception_gchandle != 0) {
fprintf (stderr, "xamarin_main: 221\n");
			xamarin_process_managed_exception_gchandle (exception_gchandle);
fprintf (stderr, "xamarin_main: 222\n");
		}
fprintf (stderr, "xamarin_main: 223\n");
	} else {
fprintf (stderr, "xamarin_main: 224\n");
		const char *last_slash = strrchr (argv [0], '/');
fprintf (stderr, "xamarin_main: 225\n");
		const char *basename = last_slash ? last_slash + 1 : argv [0];
fprintf (stderr, "xamarin_main: 226\n");
		char *aname = xamarin_strdup_printf ("%s.exe", basename);
fprintf (stderr, "xamarin_main: 227\n");

fprintf (stderr, "xamarin_main: 228\n");
		assembly = xamarin_open_and_register (aname, &exception_gchandle);
fprintf (stderr, "xamarin_main: 229\n");
		xamarin_free (aname);
fprintf (stderr, "xamarin_main: 230\n");

fprintf (stderr, "xamarin_main: 231\n");
		if (exception_gchandle != 0) {
fprintf (stderr, "xamarin_main: 232\n");
			xamarin_process_managed_exception_gchandle (exception_gchandle);
fprintf (stderr, "xamarin_main: 233\n");
		}
fprintf (stderr, "xamarin_main: 234\n");
	}
fprintf (stderr, "xamarin_main: 235\n");

fprintf (stderr, "xamarin_main: 236\n");
	if (xamarin_supports_dynamic_registration) {
fprintf (stderr, "xamarin_main: 237\n");
		xamarin_register_entry_assembly (mono_assembly_get_object (mono_domain_get (), assembly), &exception_gchandle);
fprintf (stderr, "xamarin_main: 238\n");
		if (exception_gchandle != 0) {
fprintf (stderr, "xamarin_main: 239\n");
			xamarin_process_managed_exception_gchandle (exception_gchandle);
fprintf (stderr, "xamarin_main: 240\n");
		}
fprintf (stderr, "xamarin_main: 241\n");
	}
fprintf (stderr, "xamarin_main: 242\n");
#endif
fprintf (stderr, "xamarin_main: 243\n");

fprintf (stderr, "xamarin_main: 244\n");
	DEBUG_LAUNCH_TIME_PRINT ("\tAssembly register time");
fprintf (stderr, "xamarin_main: 245\n");

fprintf (stderr, "xamarin_main: 246\n");
	[[[XamarinGCSupport alloc] init] autorelease];
fprintf (stderr, "xamarin_main: 247\n");

fprintf (stderr, "xamarin_main: 248\n");
	DEBUG_LAUNCH_TIME_PRINT ("\tGC defer time");
fprintf (stderr, "xamarin_main: 249\n");

fprintf (stderr, "xamarin_main: 250\n");
	DEBUG_LAUNCH_TIME_PRINT ("Total initialization time");
fprintf (stderr, "xamarin_main: 251\n");

fprintf (stderr, "xamarin_main: 252\n");
	int rv = 0;
fprintf (stderr, "xamarin_main: 253\n");
	switch (launch_mode) {
fprintf (stderr, "xamarin_main: 254\n");
	case XamarinLaunchModeExtension:
fprintf (stderr, "xamarin_main: 255\n");
		char base_dir [1024];
fprintf (stderr, "xamarin_main: 256\n");
		char config_file_name [1024];
fprintf (stderr, "xamarin_main: 257\n");

fprintf (stderr, "xamarin_main: 258\n");
		snprintf (base_dir, sizeof (base_dir), "%s/" ARCH_SUBDIR, xamarin_get_bundle_path ());
fprintf (stderr, "xamarin_main: 259\n");
		snprintf (config_file_name, sizeof (config_file_name), "%s/%s.config", base_dir, xamarin_executable_name); // xamarin_executable_name should never be NULL for extensions.
fprintf (stderr, "xamarin_main: 260\n");

fprintf (stderr, "xamarin_main: 261\n");
		mono_domain_set_config (mono_domain_get (), base_dir, config_file_name);
fprintf (stderr, "xamarin_main: 262\n");

fprintf (stderr, "xamarin_main: 263\n");
		MONO_ENTER_GC_SAFE;
fprintf (stderr, "xamarin_main: 264\n");
		rv = xamarin_extension_main (argc, argv);
fprintf (stderr, "xamarin_main: 265\n");
		MONO_EXIT_GC_SAFE;
fprintf (stderr, "xamarin_main: 266\n");
		break;
fprintf (stderr, "xamarin_main: 267\n");
	case XamarinLaunchModeApp:
fprintf (stderr, "xamarin_main: 268\n");
		rv = mono_jit_exec (mono_domain_get (), assembly, managed_argc, managed_argv);
fprintf (stderr, "xamarin_main: 269\n");
		break;
fprintf (stderr, "xamarin_main: 270\n");
	case XamarinLaunchModeEmbedded:
fprintf (stderr, "xamarin_main: 271\n");
		// do nothing
fprintf (stderr, "xamarin_main: 272\n");
		break;
fprintf (stderr, "xamarin_main: 273\n");
	default:
fprintf (stderr, "xamarin_main: 274\n");
		xamarin_assertion_message ("Invalid launch mode: %i.", launch_mode);
fprintf (stderr, "xamarin_main: 275\n");
		break;
fprintf (stderr, "xamarin_main: 276\n");
	}
fprintf (stderr, "xamarin_main: 277\n");
	
fprintf (stderr, "xamarin_main: 278\n");
	return rv;
}
