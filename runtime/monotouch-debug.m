//
// debug.m: Debugging code for MonoTouch
// 
// Authors:
//   Geoff Norton
//   Rolf Bjarne Kvinge <rolf@xamarin.com>
//
// Copyright 2009 Novell, Inc.
// Copyright 2011-2013 Xamarin Inc. 
//

#ifdef DEBUG

#include <UIKit/UIKit.h>

#include <zlib.h>

#include <stdlib.h>
#include <string.h>
#include <arpa/inet.h>
#include <sys/types.h>
#include <sys/socket.h>
#include <sys/select.h>
#include <sys/time.h>
#include <netinet/in.h>
#include <netinet/tcp.h>
#include <unistd.h>
#include <fcntl.h>
#include <errno.h>
#include <ctype.h>
#include <pthread.h>
#include <objc/objc.h>
#include <objc/runtime.h>
#include <sys/shm.h>

#include "xamarin/xamarin.h"
#include "runtime-internal.h"
#include "monotouch-debug.h"
#include "product.h"

// permanent connection variables
int monodevelop_port = -1;
int sdb_fd = -1;
int profiler_fd = -1;
int heapshot_fd = -1; // this is the socket to write 'heapshot' to to requests heapshots from the profiler
int heapshot_port = -1;
char *profiler_description = NULL; 
// old variables
int output_port;
int debug_port; 
char *debug_host = NULL;

enum DebuggingMode
{
	DebuggingModeNone,
	DebuggingModeUsb,
	DebuggingModeWifi,
	DebuggingModeHttp,
};

static pthread_mutex_t mutex = PTHREAD_MUTEX_INITIALIZER;
static pthread_cond_t cond = PTHREAD_COND_INITIALIZER;
static bool debugging_configured = false;
static bool profiler_configured = false;
static bool config_timedout = false;
static DebuggingMode debugging_mode = DebuggingModeWifi;
static const char *connection_mode = "default"; // this is set from the cmd line, can be either 'usb', 'wifi', 'http' or 'none'

int monotouch_connect_usb ();
int monotouch_connect_wifi (NSMutableArray *hosts);
int xamarin_connect_http (NSMutableArray *hosts);
int monotouch_debug_listen (int debug_port, int output_port);
int monotouch_debug_connect (NSMutableArray *hosts, int debug_port, int output_port);
void monotouch_configure_debugging ();
void monotouch_load_profiler ();
void monotouch_load_debugger ();
bool monotouch_process_connection (int fd);

static struct timeval wait_tv;
static struct timespec wait_ts;

/*
 *
 */
/*
@interface XamarinHttpInputStream : NSInputStream {
	int _0; // _cfinfo
 	int _1; // flags
 	int _2; // error
 	int _3; // *client   0x10
 	int _4; // info      0x14
 	int _5; // callbacks 0x18
 	int _6; // streamLock
 	int _7; // previousRunloopsAndModes
 	int _8; // queue
 	int _9; // ?
 }
 	@property (nonatomic, assign) id _x_delegate;
	@property (nonatomic) NSStreamStatus streamStatus;
	@property (readonly, copy) NSError *streamError;
	@property (nonatomic) void *buffer;
	-(void) setDelegate: (id<NSStreamDelegate>) delegate;
	-(id<NSStreamDelegate>) delegate;
	-(void) scheduleInRunLoop:(NSRunLoop *)aRunLoop forMode:(NSString *)mode;
	-(void) removeFromRunLoop:(NSRunLoop *)aRunLoop forMode:(NSString *)mode;
	-(id) propertyForKey:(NSString *)key;
	-(BOOL) setProperty:(id)property forKey:(NSString *)key;
@end

static NSInteger const kBufferSize = 32768;
@implementation XamarinHttpInputStream
@synthesize streamStatus;

-(void) setDelegate: (id<NSStreamDelegate>) delegate
{
	self._x_delegate = delegate;
}

-(id<NSStreamDelegate>) delegate
{
	if (self._x_delegate)
		return self._x_delegate;
	return (id<NSStreamDelegate>) self;
}

-(instancetype) init
{
	NSLog (@"XamarinHttpInputStream init");
    self = [super init];
    if (self) {
        _buffer =  malloc(kBufferSize);
        NSAssert(_buffer, @"Unable to create buffer");
        memset(_buffer, 0, kBufferSize);
        // _1 = 1;
        // _2 = 2;
        // _3 = 3;
        // _4 = 4;
        _5 = 5;
        _6 = 6;
        _7 = 7;
        _8 = 8;
        _9 = 9;
    }
    return self;
}

- (void)dealloc
{
	NSLog (@"XamarinHttpInputStream dealloc");
    if (_buffer) {
        free(_buffer);
        self.buffer = NULL;
    }
    [super dealloc];
}

- (void)open
{
	NSLog (@"XamarinHttpInputStream open");
    self.streamStatus = NSStreamStatusOpen;
}

- (void)close
{
	NSLog (@"XamarinHttpInputStream close");
    self.streamStatus = NSStreamStatusClosed;
}

- (NSInteger)read:(uint8_t *)buffer maxLength:(NSUInteger)len
{
	NSLog (@"XamarinHttpInputStream: read len 1 maxLength: %i", (int) len);
	*buffer = 1;
	return 1;

    // NSUInteger bytesToCopy = MIN(len, kBufferSize);
    // memcpy(buffer, _buffer, bytesToCopy);

    // return bytesToCopy;
}

- (BOOL)getBuffer:(uint8_t **)buffer length:(NSUInteger *)len
{
	NSLog (@"XamarinHttpInputStream getBuffer");
    return NO;
}

- (BOOL)hasBytesAvailable
{
	NSLog (@"XamarinHttpInputStream hasBytesAvailable");
    return self.streamStatus == NSStreamStatusOpen;
}

- (void)scheduleInRunLoop:(__unused NSRunLoop *)aRunLoop
                  forMode:(__unused NSString *)mode
{
	NSLog (@"scheduleInRunLoop");
}

- (void)removeFromRunLoop:(__unused NSRunLoop *)aRunLoop
                  forMode:(__unused NSString *)mode
{
	NSLog (@"removeFromRunLoop");
}

- (void)_scheduleInCFRunLoop:(__unused CFRunLoopRef)aRunLoop
                     forMode:(__unused CFStringRef)aMode
{
	NSLog (@"_scheduleInCFRunLoop");
}

- (void)_unscheduleFromCFRunLoop:(__unused CFRunLoopRef)aRunLoop
                         forMode:(__unused CFStringRef)aMode
{
	NSLog (@"_unscheduleFromCFRunLoop");
}

- (BOOL)_setCFClientFlags:(__unused CFOptionFlags)inFlags
                 callback:(__unused CFReadStreamClientCallBack)inCallback
                  context:(__unused CFStreamClientContext *)inContext {
	NSLog (@"_setCFClientFlags");
    return NO;
}

-(id) propertyForKey:(NSString *)key
{
	NSLog (@"propertyForKey: %@", key);
	return [super propertyForKey: key];
}

-(BOOL) setProperty:(id)property forKey:(NSString *)key
{
	NSLog (@"setProperty: %@ forKey: %@", property, key);
	return [super setProperty: property forKey: key];
}
@end
*/

pthread_mutex_t http_data_lock = PTHREAD_MUTEX_INITIALIZER;
pthread_cond_t http_data_condition = PTHREAD_COND_INITIALIZER;
NSURLSessionConfiguration *http_session_config;

/*
 * XamarinHttpConnection
 */

@interface XamarinHttpConnection : NSObject<NSURLSessionDelegate> {
	NSURLSession *http_session;
	NSMutableData *http_send_data;
	NSMutableData *http_recv_data;
	int http_sockets[2];
	int http_send_counter;
}
	@property (nonatomic, assign) NSInputStream* inputStream;
	@property void (^completion_handler)(bool);
	@property (copy) NSString* ip;
	@property int id;

	-(int) fileDescriptor;
	-(int) localDescriptor;
	-(void) reportCompletion: (bool) success;

	-(void) connect: (NSString *) ip port: (int) port completionHandler: (void (^)(bool)) completionHandler;
	-(void) sendData: (void *) buffer length: (int) length;
	-(int) recvData: (void *) buffer length: (int) length;

	/* NSURLSessionDelegate */
	-(void) URLSession:(NSURLSession *)session didBecomeInvalidWithError:(NSError *)error;
	-(void) URLSession:(NSURLSession *)session didReceiveChallenge:(NSURLAuthenticationChallenge *)challenge  completionHandler:(void (^)(NSURLSessionAuthChallengeDisposition disposition, NSURLCredential *credential))completionHandler;
	/* NSURLSessionDataDelegate */
	-(void) URLSession:(NSURLSession *)session dataTask:(NSURLSessionDataTask *)dataTask didReceiveResponse:(NSURLResponse *)response completionHandler:(void (^)(NSURLSessionResponseDisposition disposition))completionHandler;
	-(void) URLSession:(NSURLSession *)session dataTask:(NSURLSessionDataTask *)dataTask didReceiveData:(NSData *)data;

	/* NSURLSessionTaskDelegate */
	// -(void) URLSession:(NSURLSession *)session task:(NSURLSessionTask *)task needNewBodyStream:(void (^)(NSInputStream *bodyStream))completionHandler;
	-(void) URLSession:(NSURLSession *)session task:(NSURLSessionTask *)task didCompleteWithError:(NSError *)error;
@end

void *
x_http_send (void *c)
{
	XamarinHttpConnection *connection = (XamarinHttpConnection *) c;
	int id = connection.id;
	@autoreleasepool {
		int fd = connection.localDescriptor;
		void* buf [1024];
		do {
			NSLog (@"%i http send reading to send data to fd=%i", id, fd);
			errno = 0;
			int rv = read (fd, buf, 1024);
			NSLog (@"%i http send read %i bytes from fd=%i; %i=%s", id, rv, fd, errno, strerror (errno));
			if (rv > 0) {
				[connection sendData: buf length: rv];
			} else if (rv == -1) {
				if (errno == EINTR)
					continue;
				NSLog (@"%i http send: %i => %s", id, errno, strerror (errno));
				break;
			} else {
				NSLog (@"%i http send: eof", id);
				break;
			}
		} while (true);
		NSLog (@"%i http send done", id);
	}
	return NULL;
}

void *
x_http_recv (void *c)
{
	XamarinHttpConnection *connection = (XamarinHttpConnection *) c;
	int id = connection.id;
	@autoreleasepool {
		int fd = connection.localDescriptor;
		void* buf [1024];
		do {
			errno = 0;
			NSLog (@"%i http recv reading to send data to fd=%i", id, fd);
			int rv = [connection recvData: buf length: 1024];
			NSLog (@"%i http recv read %i bytes to %i; %i=%s", id, rv, fd, errno, strerror (errno));
			if (rv > 0) {
				int wr;
				do {
					wr = write (fd, buf, rv);
				} while (wr == -1 && errno == EINTR);
				// FIXME: Continue writing until we've written everything we received
				NSLog (@"%i http recv wrote %i bytes to %i; %i=%s", id, wr, fd, errno, strerror (errno));
			} else if (rv == -1) {
				NSLog (@"%i http recv: %i => %s", id, errno, strerror (errno));
				break;
			} else {
				NSLog (@"%i http recv: eof", id);
				break;
			}
		} while (true);
		NSLog (@"%i http recv done", id);
	}
	return NULL;
}

int connect_counter = 0;

@implementation XamarinHttpConnection
-(void) reportCompletion: (bool) success
{
	pthread_mutex_lock (&http_data_lock);
	if (self.completion_handler) {
		NSLog (@"%i reportCompletion (%i)", self.id, success);
		self.completion_handler (success);
		self.completion_handler = NULL; // don't call more than once.
	}
	pthread_mutex_unlock (&http_data_lock);
}

-(int) fileDescriptor
{
	return http_sockets [0];	
}

-(int) localDescriptor
{
	return http_sockets [1];
}

-(void) connect: (NSString *) ip port: (int) port completionHandler: (void (^)(bool)) completionHandler
{
	NSLog (@"Connecting to: %@:%i", ip, port);
	self.completion_handler = completionHandler;

	pthread_mutex_lock (&http_data_lock);
	self.id = ++connect_counter;
	http_recv_data = [NSMutableData dataWithCapacity: 1024];
	pthread_mutex_unlock (&http_data_lock);

	int rv = socketpair (PF_LOCAL, SOCK_STREAM, 0, http_sockets);
	if (rv != 0) {
		[self reportCompletion: false];
		return;
	}

	NSLog (@"%i Created socket pair: %i, %i", self.id, http_sockets [0], http_sockets [1]);

	pthread_t thr;
	pthread_create (&thr, NULL, x_http_send, self);
	pthread_detach (thr);
	pthread_create (&thr, NULL, x_http_recv, self);
	pthread_detach (thr);

	if (http_session_config == NULL) {
		http_session_config = [NSURLSessionConfiguration ephemeralSessionConfiguration];
		http_session_config.allowsCellularAccess = NO;
		http_session_config.networkServiceType = NSURLNetworkServiceTypeVoIP; // not quite right, but this will wake up the app for incoming network traffic
		http_session_config.timeoutIntervalForRequest = 60;
		http_session_config.requestCachePolicy = NSURLRequestReloadIgnoringLocalCacheData;
		http_session_config.HTTPMaximumConnectionsPerHost = 20;
	}

	NSOperationQueue *queue = [[NSOperationQueue alloc] init];
	http_session = [NSURLSession sessionWithConfiguration: http_session_config delegate: self delegateQueue: queue];

	NSURL *downloadURL = [NSURL URLWithString: [NSString stringWithFormat: @"http://192.168.2.8:9999/download/%i", self.id]];
	NSURLSessionDataTask *downloadTask = [http_session dataTaskWithURL: downloadURL];
	[downloadTask resume];

	NSLog (@"%i Connected to: %@:%i downloadTask: %@", self.id, ip, port, [[downloadTask currentRequest] URL]);
}

-(void) sendData: (void *)buffer length: (int) length
{
	// NSLog (@"%i sendData length: %i", self.id, length);
	// bool create_request = false;
	int c;
	pthread_mutex_lock (&http_data_lock);
	c = ++http_send_counter;
	// if (http_send_data == NULL) {
	// 	http_send_data = [NSMutableData dataWithCapacity: 1024];
	// 	create_request = true;
	// }
	// [http_send_data appendBytes: buffer length: length];
	pthread_mutex_unlock (&http_data_lock);



	// if (create_request) {
		NSURL *uploadURL = [NSURL URLWithString: [NSString stringWithFormat: @"http://192.168.2.8:9999/upload/%i/%i", c, self.id]];
		NSLog (@"%i sendData length: %i url: %@", self.id, length, uploadURL);
		NSMutableURLRequest *uploadRequest = [[[NSMutableURLRequest alloc] initWithURL: uploadURL] autorelease];
		uploadRequest.HTTPMethod = @"POST";
		// NSURLSessionUploadTask *uploadTask = [http_session uploadTaskWithStreamedRequest: uploadRequest];
		NSURLSessionUploadTask *uploadTask = [http_session uploadTaskWithRequest: uploadRequest fromData: [NSData dataWithBytes: buffer length: length]];
		[uploadTask resume];
	// } else {
	// 	NSLog (@"%i sendData length: %i - not creating request", self.id, length);
	// }
}

-(int) recvData: (void *) buffer length: (int) length
{
	int rv = 0;

	NSLog (@"%i recvData %p %i", self.id, buffer, length);
	pthread_mutex_lock (&http_data_lock);

	// Wait until we receive data
	while ([http_recv_data length] == 0) {
		pthread_cond_wait (&http_data_condition, &http_data_lock);
		NSLog (@"%i recvData signaled, length: %i", self.id, (int) [http_recv_data length]);
	}

	NSLog (@"%i recvData woken", self.id);

	NSUInteger data_length = [http_recv_data length];
	uint8_t *mutableBytes = (uint8_t *) [http_recv_data mutableBytes];
	rv = MIN (length, data_length);
	
	// Copy the data we've received
	memcpy (buffer, mutableBytes, rv);
	// If we have more data left, make sure to move it up in the buffer we have
	if (data_length > rv) 
		memmove (mutableBytes, mutableBytes + rv, data_length - rv);
	http_recv_data.length = data_length - rv;

	pthread_mutex_unlock (&http_data_lock);

	NSLog (@"%i recvData %p %i => %i", self.id, buffer, length, rv);

	return rv;
}

/* NSURLSessionDataDelegate */
- (void)URLSession:(NSURLSession *)session didBecomeInvalidWithError:(NSError *)error
{
	NSLog (@"%i didBecomeInvalidWithError: %@", self.id, error);
	[self reportCompletion: false];
}

- (void)URLSession:(NSURLSession *)session didReceiveChallenge:(NSURLAuthenticationChallenge *)challenge  completionHandler:(void (^)(NSURLSessionAuthChallengeDisposition disposition, NSURLCredential *credential))completionHandler
{
	NSLog (@"%i didReceiveChallenge", self.id);
}

-(void) URLSession:(NSURLSession *)session dataTask:(NSURLSessionDataTask *)dataTask didReceiveResponse:(NSURLResponse *)response completionHandler:(void (^)(NSURLSessionResponseDisposition disposition))completionHandler
{
	NSLog (@"%i didReceiveResponse: task: %@ url: %@", self.id, dataTask, [[dataTask originalRequest] URL]);
	completionHandler (NSURLSessionResponseAllow);
	[self reportCompletion: true];
}

- (void)URLSession:(NSURLSession *)session dataTask:(NSURLSessionDataTask *)dataTask didReceiveData:(NSData *)data
{
	NSLog (@"%i didReceiveData length: %li %@", self.id, (unsigned long) [data length], data);
	pthread_mutex_lock (&http_data_lock);
	[http_recv_data appendData: data];
	pthread_cond_broadcast (&http_data_condition);
	NSLog (@"%i didReceiveData length: %li signalled, there is now %li bytes in http_recv_data", self.id, (unsigned long) [data length], (unsigned long) [http_recv_data length]);
	pthread_mutex_unlock (&http_data_lock);
}

// /* NSURLSessionTaskDelegate */
// -(void) URLSession:(NSURLSession *)session task:(NSURLSessionTask *)task needNewBodyStream:(void (^)(NSInputStream *bodyStream))completionHandler
// {
// 	NSMutableData *data;

// 	pthread_mutex_lock (&http_data_lock);
// 	data = http_send_data;
// 	http_send_data = NULL;
// 	pthread_mutex_unlock (&http_data_lock);

// 	NSLog (@"%i needNewBodyStream: %@ sending %i bytes", self.id, task, (int) [data length]);

// 	NSInputStream *stream = [NSInputStream inputStreamWithData: data];
// 	completionHandler (stream);
// }

-(void)URLSession:(NSURLSession *)session task:(NSURLSessionTask *)task didCompleteWithError:(NSError *)error
{
	NSLog (@"%i didCompleteWithError: %@ task: %@ url: %@", self.id, error, task, [[task originalRequest] URL]);
}
@end

// /*
//  * XamarinSdbHttpTransport
//  */
// @interface XamarinSdbHttpTransport : NSObject {
// 	// const char *url;
// }
// -(bool) connect: (const char *) url;
// -(void) close1;
// -(void) close2;
// -(bool) send: (void *) buf length: (int) len;
// -(int) recv: (void *) buf length: (int) len;
// @end

// @implementation XamarinSdbHttpTransport
// {
// }
// -(bool) connect: (const char *) url
// {
// 	NSLog (@"connect: %s", url);
// 	return true;
// }
// -(void) close1
// {
// 	NSLog (@"close1");
// }
// -(void) close2
// {
// 	NSLog (@"close2");
// }
// -(bool) send: (void *) buf length: (int) len
// {

// 	NSLog (@"send %p %i", buf, len);
// 	http
// 	return true;
// }

// -(int) recv: (void *) buf length: (int) len
// {
// 	int rv = 0;

// 	NSLog (@"receiving %p %i", buf, len);
// 	pthread_mutex_lock (&http_data_lock);

// 	// Wait until we receive data
// 	while ([http_recv_data length] == 0)
// 		pthread_cond_wait (&http_data_condition, &http_data_lock);

// 	NSUInteger data_length = [http_recv_data length];
// 	void *mutableBytes = [http_recv_data mutableBytes];
// 	rv = MIN (len, data_length);
	
// 	// Copy the data we've received
// 	memcpy (buf, mutableBytes, rv);
// 	// If we have more data left, make sure to move it up in the buffer we have
// 	if (data_length > rv) 
// 		memmove (mutableBytes, mutableBytes + rv, data_length - rv)
// 	http_recv_data.length = data_length - rv;

// 	pthread_mutex_unlock (&http_data_lock);

// 	NSLog (@"received %p %i => %i", buf, len, rv);

// 	return rv;
// }
// @end

// static XamarinSdbHttpTransport *http_transport = NULL;

// static void
// xamarin_http_connect (const char *address)
// {
// 	gboolean shaked;

// 	assert (!http_transport);
// 	http_transport = [[XamarinSdbHttpTransport alloc] init];

// 	MONO_ENTER_GC_UNSAFE;
// 	shaked = mono_debugger_agent_transport_handshake ();
// 	MONO_EXIT_GC_UNSAFE;
	
// 	if (!shaked)
// 		NSLog (@PRODUCT ": Handshake error with IDE.");

// 	return;
// }

// static void
// xamarin_http_close1 (void)
// {
// 	// shutdown (sdb_fd, SHUT_RD);
// 	[http_transport close1];
// }

// static void
// xamarin_http_close2 (void)
// {
// 	// shutdown (sdb_fd, SHUT_RDWR);
// 	[http_transport close2];
// }

// static gboolean
// xamarin_http_send (void *buf, int len)
// {
// 	gboolean rv;

// 	if (debugging_configured) {
// 		MONO_ENTER_GC_SAFE;
// 		rv = [http_transport send: buf length: len];
// 		MONO_EXIT_GC_SAFE;
// 	} else {
// 		rv = [http_transport send: buf length: len];
// 	}

// 	return rv;
// }


// static int
// xamarin_http_recv (void *buf, int len)
// {
// 	int rv;

// 	if (debugging_configured) {
// 		MONO_ENTER_GC_SAFE;
// 		rv = [http_transport recv: buf length: len];
// 		MONO_EXIT_GC_SAFE;
// 	} else {
// 		rv = [http_transport recv: buf length: len];
// 	}

// 	return rv;
// }


void
monotouch_set_connection_mode (const char *mode)
{
	connection_mode = mode;
}

void
monotouch_set_monodevelop_port (int port)
{
	monodevelop_port = port;
}

void
monotouch_start_debugging ()
{
	// COOP: this is at startup and doesn't access managed memory: safe mode.
	MONO_ASSERT_GC_STARTING;
	
	bool debug_enabled = strcmp (connection_mode, "none");
	if (xamarin_debug_mode) {
		if (debug_enabled) {
			// wait for debug configuration to finish
			gettimeofday(&wait_tv, NULL);
			wait_ts.tv_sec = wait_tv.tv_sec + 2;
			wait_ts.tv_nsec = wait_tv.tv_usec * 1000;
			
			pthread_mutex_lock (&mutex);
			while (!debugging_configured && !config_timedout) {
				if (pthread_cond_timedwait (&cond, &mutex, &wait_ts) == ETIMEDOUT)
					config_timedout = true;
			}
			pthread_mutex_unlock (&mutex);
			
			if (!config_timedout)
				monotouch_load_debugger ();
		} else {
			LOG (PRODUCT ": Not connecting to the IDE, debug has been disabled\n");
		}
	
		char *trace = getenv ("MONO_TRACE");
		if (trace && *trace) {
			if (!strncmp (trace, "--trace=", 8))
				trace += 8;

			MONO_ENTER_GC_UNSAFE;
			mono_jit_set_trace_options (trace);
			MONO_EXIT_GC_UNSAFE;
		}
	}
}

void
monotouch_start_profiling ()
{
	// COOP: at startup, should be in safe mode here. If that's not the case, we need to switch to safe mode when calling pthread_mutex_lock.
	MONO_ASSERT_GC_STARTING;
	
	bool debug_enabled = strcmp (connection_mode, "none");
	if (xamarin_debug_mode && debug_enabled) {
		// wait for profiler configuration to finish
		pthread_mutex_lock (&mutex);
		while (!profiler_configured && !config_timedout) {
			if (pthread_cond_timedwait (&cond, &mutex, &wait_ts) == ETIMEDOUT)
				config_timedout = true;
		}
		pthread_mutex_unlock (&mutex);
	
		if (!config_timedout)
			monotouch_load_profiler ();
	}
}

static NSString *
get_preference (NSArray *preferences, NSUserDefaults *defaults, NSString *lookupKey)
{
	NSDictionary *dict;
 
	// Apple appears to return nil if the user has never opened the Settings, so we
	// manually parse it here.  This has the added benefits that if people don't open
	// settings we can control the default from MD

	// User Preferences have the highest precedence
	for (dict in preferences) {
		NSString *key = [dict objectForKey:@"Key"];
		if (![key isEqualToString:lookupKey])
			continue;
		
		return [dict objectForKey:@"DefaultValue"];
	}

	// Global Defaults have the second highest precedence
	return defaults ? [defaults stringForKey:lookupKey] : nil;
}

void monotouch_configure_debugging ()
{
	// COOP: this is at startup, before initializing the mono runtime, so we're in the STARTING mode. If that's not the case, at the very least we must transition to safe mode when calling pthread_mutex_lock.
	MONO_ASSERT_GC_STARTING;
	
	// This method is invoked on a separate thread
	NSUserDefaults *defaults = [NSUserDefaults standardUserDefaults];
	NSString *bundle_path = [NSString stringWithUTF8String:xamarin_get_bundle_path ()];
	NSString *settings_path = [bundle_path stringByAppendingPathComponent:@"Settings.bundle"]; 
	NSString *root_plist = [settings_path stringByAppendingPathComponent:@"Root.plist"];
	NSDictionary *settings = [NSDictionary dictionaryWithContentsOfFile: root_plist];
	NSArray *preferences = [settings objectForKey:@"PreferenceSpecifiers"];
	NSMutableArray *hosts = [NSMutableArray array];
	bool debug_enabled;
	NSString *monodevelop_host;
	NSString *monotouch_debug_enabled;

	if (!strcmp (connection_mode, "default")) {
		char *evar = getenv ("__XAMARIN_DEBUG_MODE__");
		if (evar && *evar) {
			connection_mode = evar;
			LOG (PRODUCT ": Found debug mode %s in environment variables\n", connection_mode);
			unsetenv ("__XAMARIN_DEBUG_MODE__");
		}
	}
	
	if (!strcmp (connection_mode, "none")) {
		// nothing to do
		return;
	}
 
	// If debugging is enabled
	monotouch_debug_enabled = get_preference (preferences, NULL, @"__monotouch_debug_enabled"); 
	if (monotouch_debug_enabled != nil) {
		debug_enabled = [monotouch_debug_enabled isEqualToString:@"1"];
	} else {
		debug_enabled = [defaults boolForKey:@"__monotouch_debug_enabled"];
	}

	//        We get the IPs of the dev machine + one port (monodevelop_port).
	//        We start up a thread (using the same thread that we have to start up
	//        anyway to initialize cocoa threading) and then establishes several
	//        connections to MD (for usb we listen for connections and for wifi we
	//        connect to MD using any of the IPs we got). MD then sends instructions
	//        on those connections telling us what to do with them. We never stop
	//        processing connections and commands from that thread - this way MD can
	//        send an exit request when MD wants us to exit.
	monodevelop_host = get_preference (preferences, defaults, @"__monodevelop_host");
	if (monodevelop_host != nil && ![monodevelop_host isEqualToString:@"automatic"]) {
		[hosts addObject:monodevelop_host];
		LOG (PRODUCT ": Added host from settings to look for the IDE: %s\n", [monodevelop_host UTF8String]);
	}

	char *evar = getenv ("__XAMARIN_DEBUG_PORT__");
	if (evar && *evar) {
		if (monodevelop_port == -1) {
			monodevelop_port = strtol (evar, NULL, 10);
			LOG (PRODUCT ": Found port %i in environment variables\n", monodevelop_port);
		}
		unsetenv ("__XAMARIN_DEBUG_PORT__");
	}

	evar = getenv ("__XAMARIN_DEBUG_HOSTS__");
	if (evar && *evar) {
		NSArray *ips = [[NSString stringWithUTF8String:evar] componentsSeparatedByString:@";"];
		for (int i = 0; i < [ips count]; i++) {
			NSString *ip = [ips objectAtIndex:i];
			if (![hosts containsObject:ip]) {
				[hosts addObject:ip];
				LOG (PRODUCT ": Found host %s in environment variables\n", [ip UTF8String]);
			}
		}
		unsetenv ("__XAMARIN_DEBUG_HOSTS__");
	}

#if MONOTOUCH && (defined(__i386__) || defined (__x86_64__))
	// Try to read shared memory as well
	key_t shmkey = ftok ("/Library/Frameworks/Xamarin.iOS.framework/Versions/Current/bin/mtouch", 0);
	if (shmkey == -1) {
		LOG (PRODUCT ": Could not create shared memory key: %s\n", strerror (errno));
	} else {
		int shmsize = 1024;
		int shmid = shmget (shmkey, shmsize, 0);
		if (shmid == -1) {
			LOG (PRODUCT ": Could not get shared memory id: %s\n", strerror (errno));
		} else {
			void *ptr = shmat (shmid, NULL, SHM_RDONLY);
			if (ptr == NULL || ptr == (void *) -1) {
				LOG (PRODUCT ": Could not map shared memory: %s\n", strerror (errno));
			} else {
				LOG (PRODUCT ": Read %i bytes from shared memory: %p with key %i and id %i\n", shmsize, ptr, shmkey, shmid);
				// Make a local copy of the shared memory, so that it doesn't change while we're parsing it.
				char *data = strndup ((const char *) ptr, shmsize); // strndup will null-terminate
				char *line = data;
				// Parse!
				while (*line) {
					char *nline = line;
					// find the end of the line, null-terminate the line and make 'nptr' to the next line. 
					do {
						if (*nline == '\n') {
							*nline = 0;
							nline++;
							break;
						}
					} while (*++nline);

					if (!strncmp (line, "__XAMARIN_DEBUG_PORT__=", 23)) {
						int shm_monodevelop_port = strtol (line + 23, NULL, 10);
						if (monodevelop_port == -1) {
							monodevelop_port = shm_monodevelop_port;
							LOG (PRODUCT ": Found port %i in shared memory\n", monodevelop_port);
						} else  {
							LOG (PRODUCT ": Found port %i in shared memory, but not overriding existing port %i\n", shm_monodevelop_port, monodevelop_port);
						}
					} else {
						LOG (PRODUCT ": Unknown data found in shared memory: %s\n", line);
					}
					line = nline;
				}
				free (data);
				shmdt (ptr);
			}
		}
	}
#endif

	// Finally, fall back to loading values from MonoTouchDebugConfiguration.txt
	FILE *debug_conf = fopen ("MonoTouchDebugConfiguration.txt", "r");
	if (debug_conf != NULL) { 
		bool add_hosts = [hosts count] == 0;
		char line [128];
		int i;

		while (!feof (debug_conf)) {
			if (fgets (line, sizeof (line), debug_conf) != NULL) {
				// Remove trailing newline
				for (i = 0; line[i]; i++) {
					if (line [i] == '\n' || line [i] == '\r') {
						line [i] = 0;
						break;
					}
				}
				
				if (!strncmp ("IP: ", line, 4)) {
					if (add_hosts) {
						NSString *ip;

						ip = [NSString stringWithUTF8String:line + 4];
						if (![hosts containsObject:ip]) {
							[hosts addObject:ip];
							LOG (PRODUCT ": Added IP to look for the IDE: %s\n", [ip UTF8String]);
						}
					}
				} else if (!strncmp ("USB Debugging: ", line, 15) && (connection_mode == NULL || !strcmp (connection_mode, "default"))) {
#if defined(__arm__) || defined(__aarch64__)
					debugging_mode = !strncmp ("USB Debugging: 1", line, 16) ? DebuggingModeUsb : DebuggingModeWifi;
#endif
				} else if (!strncmp ("Port: ", line, 6) && monodevelop_port == -1) {
					monodevelop_port = strtol (line + 6, NULL, 10);
				}
			}
		}
		
		fclose (debug_conf);
	}

	if (debug_enabled) {
		int rv;

		// connection_mode is set from the command line, and will override any other setting
		if (connection_mode != NULL) {
			if (!strcmp (connection_mode, "usb")) {
				debugging_mode = DebuggingModeUsb;
			} else if (!strcmp (connection_mode, "wifi")) {
				debugging_mode = DebuggingModeWifi;
			} else if (!strcmp (connection_mode, "http")) {
				debugging_mode = DebuggingModeHttp;
			}
		}

		debugging_mode = DebuggingModeHttp; // FIXME!!!

		if (monodevelop_port <= 0) {
			LOG (PRODUCT ": Invalid IDE Port: %i\n", monodevelop_port);
		} else {
			LOG (PRODUCT ": IDE Port: %i Transport: %s\n", monodevelop_port, debugging_mode == DebuggingModeHttp ? "HTTP" : (debugging_mode == DebuggingModeUsb ? "USB" : "WiFi"));
			if (debugging_mode == DebuggingModeUsb) {
				rv = monotouch_connect_usb ();
			} else if (debugging_mode == DebuggingModeWifi) {
				rv = monotouch_connect_wifi (hosts);
			}  else if (debugging_mode == DebuggingModeHttp) {
				rv = xamarin_connect_http (hosts);
			}
		}
	}

	profiler_configured = true;
	debugging_configured = true;
	MONO_ASSERT_GC_STARTING;
	pthread_mutex_lock (&mutex);
	pthread_cond_signal (&cond);
	pthread_mutex_unlock (&mutex);
}

void sdb_connect (const char *address)
{
	gboolean shaked;

	NSLog (@"sdb_connect (%s)", address);

	MONO_ENTER_GC_UNSAFE;
	shaked = mono_debugger_agent_transport_handshake ();
	MONO_EXIT_GC_UNSAFE;
	
	if (!shaked)
		NSLog (@PRODUCT ": Handshake error with IDE.");

	NSLog (@"sdb_connect (%s): %i", address, shaked);

	return;
}

void sdb_close1 (void)
{
	shutdown (sdb_fd, SHUT_RD);
}

void sdb_close2 (void)
{
	shutdown (sdb_fd, SHUT_RDWR);
}

int send_counter = 0;
gboolean send_uninterrupted (int fd, const void *buf, int len)
{
	int res;

	NSLog (@"send_uninterrupted (fd=%i): counter: %.4i len: %i", fd, ++send_counter, len);

	do {
		res = send (fd, buf, len, 0);
	} while (res == -1 && errno == EINTR);

	NSLog (@"send_uninterrupted (fd=%i): counter: %.4i len: %i res: %i", fd, ++send_counter, len, res);

	return res == len;
}

int recv_counter = 0;
int recv_uninterrupted (int fd, void *buf, int len)
{
	int res;
	int total = 0;
	int flags = 0;

	NSLog (@"recv_uninterrupted (fd=%i): counter: %.4i len: %i", fd, ++recv_counter, len);

	do { 
		res = recv (fd, (char *) buf + total, len - total, flags); 
		if (res > 0)
			total += res;
	} while ((res > 0 && total < len) || (res == -1 && errno == EINTR));

	NSLog (@"recv_uninterrupted (fd=%i): counter: %.4i len: %i total: %i", fd, ++recv_counter, len, total);

	return total;
}

gboolean sdb_send (void *buf, int len)
{
	NSLog (@"sdb_send (fd: %i, %p, %i)", sdb_fd, buf, len);
	gboolean rv;

	if (debugging_configured) {
		MONO_ENTER_GC_SAFE;
		rv = send_uninterrupted (sdb_fd, buf, len);
		MONO_EXIT_GC_SAFE;
	} else {
		rv = send_uninterrupted (sdb_fd, buf, len);
	}

	NSLog (@"sdb_send (fd: %i, %p, %i): %i", sdb_fd, buf, len, rv);

	return rv;
}


int sdb_recv (void *buf, int len)
{
	int rv;

	NSLog (@"sdb_recv (fd: %i, %p, %i)", sdb_fd, buf, len);

	if (debugging_configured) {
		MONO_ENTER_GC_SAFE;
		rv = recv_uninterrupted (sdb_fd, buf, len);
		MONO_EXIT_GC_SAFE;
	} else {
		rv = recv_uninterrupted (sdb_fd, buf, len);
	}

	NSLog (@"sdb_recv (fd: %i, %p, %i): %i", sdb_fd, buf, len, rv);

	return rv;
}

static XamarinHttpConnection *connected_connection = NULL;
static NSString *connected_ip = NULL;
static pthread_cond_t connected_event = PTHREAD_COND_INITIALIZER;
static pthread_mutex_t connected_mutex = PTHREAD_MUTEX_INITIALIZER;

int
xamarin_connect_http (NSMutableArray *ips)
{
	// COOP: this is at startup and doesn't access managed memory, so we should be in safe mode here.
	MONO_ASSERT_GC_STARTING;
	
	int ip_count = [ips count];
	NSMutableArray<XamarinHttpConnection *> *connections = NULL;

	if (ip_count == 0) {
		NSLog (@PRODUCT ": No IPs to connect to.");
		return 2;
	}
	
	NSLog (@PRODUCT ": Connecting to %i IPs.", ip_count);

	connections = [[[NSMutableArray<XamarinHttpConnection *> alloc] init] autorelease];

	do {
		pthread_mutex_lock (&connected_mutex);
		if (connected_connection != NULL) {
			NSLog (@"Will reconnect");
			// We've already made sure one IP works, no need to try the others again.
			[ips removeAllObjects];
			[ips addObject: connected_ip];
			connected_connection = NULL;
		}
		pthread_mutex_unlock (&connected_mutex);

		for (int i = 0; i < ip_count; i++) {
			XamarinHttpConnection *connection = [[[XamarinHttpConnection alloc] init] autorelease];
			connection.ip = [ips objectAtIndex: i];
			[connections addObject: connection];
			[connection connect: [ips objectAtIndex: i] port: monodevelop_port completionHandler: ^void (bool success)
			{
				NSLog (@"Connected: %@: %i", connection, success);
				if (success) {
					pthread_mutex_lock (&connected_mutex);
					if (connected_connection == NULL) {
						connected_ip = [connection ip];
						connected_connection = connection;
						pthread_cond_signal (&connected_event);
					}
					pthread_mutex_unlock (&connected_mutex);
				}
			}];
		}

		NSLog (@"Will wait for connections");
		pthread_mutex_lock (&connected_mutex);
		while (connected_connection == NULL)
			pthread_cond_wait (&connected_event, &connected_mutex);
		pthread_mutex_unlock (&connected_mutex);
		NSLog (@"Connection received fd: %i", connected_connection.fileDescriptor);
	} while (monotouch_process_connection (connected_connection.fileDescriptor));

	return 0;
}

int monotouch_connect_wifi (NSMutableArray *ips)
{
	// COOP: this is at startup and doesn't access managed memory, so we should be in safe mode here.
	MONO_ASSERT_GC_STARTING;
	
	int listen_port = monodevelop_port;
	unsigned char sockaddr[sizeof (struct sockaddr_in6)];
	struct sockaddr_in6 *sin6 = (struct sockaddr_in6 *) sockaddr;
	struct sockaddr_in *sin = (struct sockaddr_in *) sockaddr;
	int family, waiting, len, rv, i;
	int ip_count = [ips count];
	const char *family_str;
	int connected;
	const char *ip;
	int *sockets;
	long flags;
	
	if (ip_count == 0) {
		NSLog (@PRODUCT ": No IPs to connect to.");
		return 2;
	}
	
	sockets = (int *) malloc (sizeof (int) * ip_count);
	for (i = 0; i < ip_count; i++)
		sockets[i] = -2;
	
	// Open a socket and try to establish a connection for each IP
	do {
		waiting = 0;
		connected = -1;
		for (i = 0; i < ip_count; i++) {
			if (sockets [i] == -1)
				continue;

			ip = [[ips objectAtIndex:i] UTF8String];
			
			memset (sockaddr, 0, sizeof (sockaddr));
			
			// Parse the host IP, assuming IPv4 and falling back to IPv6
			if ((rv = inet_pton (AF_INET, ip, &sin->sin_addr)) == 1) {
				len = sin->sin_len = sizeof (struct sockaddr_in);
				family = sin->sin_family = AF_INET;
				sin->sin_port = htons (listen_port);
				family_str = "IPv4";
			} else if (rv == 0 && (rv = inet_pton (AF_INET6, ip, &sin6->sin6_addr)) == 1) {
				len = sin6->sin6_len = sizeof (struct sockaddr_in6);
				family = sin6->sin6_family = AF_INET6;
				sin6->sin6_port = htons (listen_port);
				family_str = "IPv6";
			} else {
				NSLog (@PRODUCT ": Error parsing '%s': %s", ip, errno ? strerror (errno) : "unsupported address type");
				sockets[i] = -1;
				continue;
			}
			
			if ((sockets[i] = socket (family, SOCK_STREAM, IPPROTO_TCP)) == -1) {
				NSLog (@PRODUCT ": Failed to create %s socket: %s", family_str, strerror (errno));
				continue;
			}
			
			// Make the socket non-blocking
			flags = fcntl (sockets[i], F_GETFL, NULL);
			fcntl (sockets[i], F_SETFL, flags | O_NONBLOCK);
			
			// Connect to the host
			if ((rv = connect (sockets[i], (struct sockaddr *) sockaddr, len)) == 0) {
				// connection completed, this is our man.
				connected = i;
				break;
			}
			
			if (rv < 0 && errno != EINPROGRESS) {
				NSLog (@PRODUCT ": Failed to connect to %s on port %d: %s", ip, listen_port, strerror (errno));
				close (sockets[i]);
				sockets[i] = -1;
				continue;
			}
			
			// asynchronous connect
			waiting++;
		}
	
		// Wait for async socket connections to become available
		while (connected == -1 && waiting > 0) {
			socklen_t optlen = sizeof (int);
			fd_set rset, wset, xset;
			struct timeval tv;
			int max_fd = -1;
			int error;
			
			tv.tv_sec = 2;
			tv.tv_usec = 0;
			
			FD_ZERO (&rset);
			FD_ZERO (&wset);
			FD_ZERO (&xset);
			
			for (i = 0; i < ip_count; i++) {
				if (sockets[i] < 0)
					continue;
				
				max_fd = MAX (max_fd, sockets[i]);
				FD_SET (sockets[i], &rset);
				FD_SET (sockets[i], &wset);
				FD_SET (sockets[i], &xset);
			}
			
			if ((rv = select (max_fd + 1, &rset, &wset, &xset, &tv)) == 0) {
				// timeout hit, no connections available.
				free (sockets);
				return 1;
			}
			
			if (rv < 0) {
				if (errno == EINTR || errno == EAGAIN)
					continue;
				
				// irrecoverable error
				NSLog (@PRODUCT ": Error while waiting for connections: %s", strerror (errno));
				free (sockets);
				return 1;
			}
			
			for (i = 0; i < ip_count; i++) {
				if (sockets[i] < 0)
					continue;
				
				if (FD_ISSET (sockets[i], &xset)) {
					// exception on this socket
					close (sockets[i]);
					sockets[i] = -1;
					waiting--;
					continue;
				}
				
				if (!FD_ISSET (sockets[i], &rset) && !FD_ISSET (sockets[i], &wset)) {
					// still waiting...
					continue;
				}
				
				// okay, this socket is ready for reading or writing...
				if (getsockopt (sockets[i], SOL_SOCKET, SO_ERROR, &error, &optlen) < 0) {
					NSLog (@PRODUCT ": Error while trying to get socket options for %s: %s", [[ips objectAtIndex:i] UTF8String], strerror (errno));
					close (sockets[i]);
					sockets[i] = -1;
					waiting--;
					continue;
				}
				
				if (error != 0) {
					NSLog (@PRODUCT ": Socket error while connecting to IDE on %s:%d: %s", [[ips objectAtIndex:i] UTF8String], listen_port, strerror (error));
					close (sockets[i]);
					sockets[i] = -1;
					waiting--;
					continue;
				}
				
				// success!
				connected = i;
				break;
			}
		}
	
		if (connected == -1) {
			free (sockets);
			return 1;
		}
	
		// close the remaining sockets
		for (i = 0; i < ip_count; i++) {
			if (i == connected || sockets[i] < 0)
				continue;
			
			close (sockets[i]);
			sockets[i] = -1;
		}
	
		LOG (PRODUCT ": Established connection with the IDE (fd: %i)\n", sockets [connected]);
	} while (monotouch_process_connection (sockets [connected]));

	free (sockets);

	return 0;
}

int monotouch_connect_usb ()
{
	// COOP: this is at startup and doesn't access managed memory, so we should be in safe mode here.
	MONO_ASSERT_GC_STARTING;
	
	int listen_port = monodevelop_port;
	struct sockaddr_in listen_addr;
	int listen_socket = -1;
	int fd;
	socklen_t len;
	int rv;
	fd_set rset;
	struct timeval tv;
	struct timeval start;
	struct timeval now;
	int flags;
	
	// Create the listen socket and set it up
	listen_socket = socket (PF_INET, SOCK_STREAM, IPPROTO_TCP);
	if (listen_socket == -1) {
		NSLog (@PRODUCT ": Could not create socket for the IDE to connect to: %s", strerror (errno));
		return 1;
	}
	
	flags = 1;
	if (setsockopt (listen_socket, SOL_SOCKET, SO_REUSEADDR, &flags, sizeof (flags)) == -1) {
		NSLog (@PRODUCT ": Could not set SO_REUSEADDR on the listening socket (%s)", strerror (errno));
		// not a fatal failure
	}
	
	// Bind
	memset (&listen_addr, 0, sizeof (listen_addr));
	listen_addr.sin_family = AF_INET;
	listen_addr.sin_port = htons (listen_port);
	listen_addr.sin_addr.s_addr = INADDR_ANY;
	rv = bind (listen_socket, (struct sockaddr *) &listen_addr, sizeof (listen_addr));
	if (rv == -1) {
		NSLog (@PRODUCT ": Could not bind to address: %s", strerror (errno));
		rv = 2;
		goto cleanup;
	}

	// Make the socket non-blocking
	flags = fcntl (listen_socket, F_GETFL, NULL);
	flags |= O_NONBLOCK;
	fcntl (listen_socket, F_SETFL, flags);

	rv = listen (listen_socket, 1);
	if (rv == -1) {
		NSLog (@PRODUCT ": Could not listen for the IDE: %s", strerror (errno));
		rv = 2;
		goto cleanup;
	}

	// Wait for connections
	start.tv_sec = 0;
	start.tv_usec = 0;
	do {
		FD_ZERO (&rset);
		FD_SET (listen_socket, &rset);

		do {
			// Calculate how long we can wait if we can only work for 2s since we started
			gettimeofday (&now, NULL);
			if (start.tv_sec == 0) {
				start.tv_sec = now.tv_sec;
				start.tv_usec = now.tv_usec;
				tv.tv_sec = 2;
				tv.tv_usec = 0;
			} else if ((start.tv_sec + 2 == now.tv_sec && start.tv_usec < now.tv_usec) || start.tv_sec + 2 < now.tv_sec) {
				// timeout
			} else {
				tv.tv_sec = start.tv_sec + 2 - now.tv_sec;
				if (start.tv_usec > now.tv_usec) {
					tv.tv_usec = start.tv_usec - now.tv_usec;
				} else {
					tv.tv_sec--;
					tv.tv_usec = 1000000 + start.tv_usec - now.tv_usec;
				}
			}

			// LOG (PRODUCT ": Waiting for connections from the IDE, sec: %i usec: %i\n", (int) tv.tv_sec, (int) tv.tv_usec);

			if ((rv = select (listen_socket + 1, &rset, NULL, NULL, &tv)) == 0) {
				// timeout hit, no connections available.
				LOG (PRODUCT ": Listened for connections from the IDE for 2 seconds, nobody connected.\n");
				rv = 3;
				goto cleanup;
			}
		} while (rv == -1 && errno == EINTR);

		if (rv == -1) {
			NSLog (@PRODUCT ": Failed while waiting for the IDE to connect: %s", strerror (errno));
			rv = 2;
			goto cleanup;
		}

		len = sizeof (struct sockaddr_in);
		fd = accept (listen_socket, (struct sockaddr *) &listen_addr, &len);
		if (fd == -1) {
			NSLog (@PRODUCT ": Failed to accept connection from the IDE: %s", strerror (errno));
			rv = 3;
			goto cleanup;
		}

		flags = 1;
		if (setsockopt (fd, IPPROTO_TCP, TCP_NODELAY, (char *) &flags, sizeof (flags)) < 0) {
			NSLog (@PRODUCT ": Could not set TCP_NODELAY on socket (%s)", strerror (errno));
			// not a fatal failure
		}

		LOG (PRODUCT ": Successfully received USB connection from the IDE on port %i, fd: %i\n", listen_port, fd);
	} while (monotouch_process_connection (fd));

	LOG (PRODUCT ": Successfully talked to the IDE. Will continue startup now.\n");

cleanup:
	close (listen_socket);
	return rv;
}

void
monotouch_dump_objc_api (Class klass)
{
	unsigned int c;
	Ivar *vars;
	Method *methods;
	objc_property_t *props;
	
	printf ("Dumping class %p = %s\n", klass, class_getName (klass));
	
	vars = class_copyIvarList (klass, &c);
	printf ("\t%i instance variables:\n", c);
	for (int i = 0; i < c; i++)
		printf ("\t\t#%i: %s\n", i + 1, ivar_getName (vars [i]));
	free (vars);
	
	methods = class_copyMethodList (klass, &c);
	printf ("\t%i instance methods:\n", c);
	for (int i = 0; i < c; i++)
		printf ("\t\t#%i: %s\n", i + 1, sel_getName (method_getName (methods [i])));
	free (methods);
	
	props = class_copyPropertyList (klass, &c);
	printf ("\t%i instance properties:\n", c);
	for (int i = 0; i < c; i++)
		printf ("\t\t#%i: %s\n", i + 1, property_getName (props [i]));
	free (props);
	
	fflush (stdout);
}

void
monotouch_load_debugger ()
{
	// COOP: this is at startup and doesn't access managed memory, so we should be in safe mode here.
	MONO_ASSERT_GC_STARTING;
	
	// main thread only 
	if (sdb_fd != -1) {
		DebuggerTransport transport;

		transport.name = "custom_transport";
		transport.connect = sdb_connect;
		transport.close1 = sdb_close1;
		transport.close2 = sdb_close2;
		transport.send = sdb_send;
		transport.recv = sdb_recv;

		mono_debugger_agent_register_transport (&transport);
	
		// transport.name = "custom_http_transport";
		// transport.connect = xamarin_http_connect;
		// transport.close1 = xamarin_http_close1;
		// transport.close2 = xamarin_http_close2;
		// transport.send = xamarin_http_send;
		// transport.recv = xamarin_http_recv;

		mono_debugger_agent_parse_options ("transport=custom_transport,address=dummy,embedding=1");

		LOG (PRODUCT ": Debugger loaded with custom transport (fd: %i)\n", sdb_fd);
	} else {
		LOG (PRODUCT ": Debugger not loaded (disabled).\n");
	}
}

void
monotouch_load_profiler ()
{
	// COOP: this is at startup and doesn't access managed memory, so we should be in safe mode here.
	MONO_ASSERT_GC_STARTING;
	
	// TODO: make this generic enough for other profilers to work too
	// Main thread only
	if (profiler_description != NULL) {
		mono_profiler_load (profiler_description);

		LOG (PRODUCT ": Profiler loaded: %s\n", profiler_description);
		free (profiler_description);
		profiler_description = NULL;
	} else {
		LOG (PRODUCT ": Profiler not loaded (disabled)\n");
	}
}

// returns true if it's necessary to create more
// connections to process more data.
bool
monotouch_process_connection (int fd)
{
	// COOP: should be in safe mode here. If that's not the case, at the very least need to switch to safe mode when calling pthread_mutex_lock.
	MONO_ASSERT_GC_STARTING;
	
	// make sure the fd/socket blocks on reads/writes
	fcntl (fd, F_SETFL, fcntl (fd, F_GETFL, NULL) & ~O_NONBLOCK);

	while (true) {
		char command [257];
		int rv;
		unsigned char cmd_len;

		rv = recv_uninterrupted (fd, &cmd_len, 1);
		if (rv <= 0) {
			LOG (PRODUCT ": Error while receiving command from the IDE (%s)\n", strerror (errno));
			return false;
		}

		rv = recv_uninterrupted (fd, command, cmd_len);
		if (rv <= 0) {
			LOG (PRODUCT ": Error while receiving command from the IDE (%s)\n", strerror (errno));
			return false;
		}
		
		// null-terminate
		command [cmd_len] = 0;

		LOG (PRODUCT ": Processing: '%s'\n", command);
		
		if (!strcmp (command, "connect output")) {
			// dup2 (fd, 1);
			// dup2 (fd, 2);
			return true; 
		} else if (!strcmp (command, "connect stdout")) {
			dup2 (fd, 1);
			return true;
		} else if (!strcmp (command, "connect stderr")) {
			dup2 (fd, 2);
			return true;
		} else if (!strcmp (command, "discard")) {
			return true;
		} else if (!strcmp (command, "ping")) {
			if (!send_uninterrupted (fd, "pong", 5))
				LOG (PRODUCT ": Got keepalive request from the IDE, but could not send response back (%s)\n", strerror (errno));
		} else if (!strcmp (command, "exit process")) {
			LOG (PRODUCT ": The IDE requested an exit, will exit immediately.\n");
			fflush (stderr);
			exit (0);
		} else if (!strncmp (command, "start debugger: ", 16)) {
			const char *debugger = command + 16;
			bool use_fd = false;
			if (!strcmp (debugger, "no")) {
				/* disabled */
			} else if (!strcmp (debugger, "sdb")) {
				sdb_fd = fd;
				use_fd = true;
			}
			debugging_configured = true;
			MONO_ASSERT_GC_STARTING;
			pthread_mutex_lock (&mutex);
			pthread_cond_signal (&cond);
			pthread_mutex_unlock (&mutex);
			if (use_fd)
				return true;
		} else if (!strncmp (command, "start profiler: ", 16)) {
			// initialize the log profiler if we're debugging
			const char *prof = command + 16;
			bool use_fd = false;
			
			if (!strcmp (prof, "no")) {
				/* disabled */
			} else if (!strncmp (prof, "log:", 4)) {
#if defined(__i386__) || defined (__x86_64__)
				profiler_description = strdup (prof);
#else
				use_fd = true;
				profiler_fd = fd;
				profiler_description = xamarin_strdup_printf ("%s,output=#%i", prof, profiler_fd);
#endif
				xamarin_set_gc_pump_enabled (false);
			} else {
				LOG (PRODUCT ": Unknown profiler, expect unexpected behavior (%s)\n", prof);
				profiler_description = strdup (prof);
			}
			profiler_configured = true;
			MONO_ASSERT_GC_STARTING;
			pthread_mutex_lock (&mutex);
			pthread_cond_signal (&cond);
			pthread_mutex_unlock (&mutex);
			if (use_fd)
				return true;
		} else if (!strncmp (command, "set heapshot port: ", 19)) {
			heapshot_port = strtol (command + 19, NULL, 0);
			LOG (PRODUCT ": HeapShot port is now: %i\n", heapshot_port);
		} else if (!strcmp (command, "heapshot")) {
			if (heapshot_fd == -1) {
				struct sockaddr_in heapshot_addr;

				memset (&heapshot_addr, 0, sizeof (heapshot_addr));
				heapshot_addr.sin_len = sizeof (heapshot_addr);
				heapshot_addr.sin_port = htons (heapshot_port);
				heapshot_addr.sin_addr.s_addr = htonl (INADDR_LOOPBACK);
				heapshot_addr.sin_family = AF_INET;

				if ((heapshot_fd = socket (AF_INET, SOCK_STREAM, IPPROTO_TCP)) == -1) {
					LOG (PRODUCT ": Failed to create socket to connect to profiler: %s\n", strerror (errno));
				} else if (connect (heapshot_fd, (struct sockaddr *) &heapshot_addr, sizeof (heapshot_addr)) != 0) {
					LOG (PRODUCT ": Failed to connect to profiler to request a heapshot: %s\n", strerror (errno));
					close (heapshot_fd);
					heapshot_fd = -1;
				} else {
					// Success!
				}
			}
			if (heapshot_fd != -1) {
				if (!send_uninterrupted (heapshot_fd, "heapshot\n", 9))
					LOG (PRODUCT ": Failed to request heapshot: %s\n", strerror (errno));
			}
		} else {
			LOG (PRODUCT ": Unknown command received from the IDE: '%s'\n", command);
		}
	}
}

int monotouch_debug_listen (int debug_port, int output_port)
{
	struct sockaddr_in listen_addr;
	int listen_socket;
	int output_socket;
	socklen_t len;
	int rv;
	long flags;
	int flag;
	fd_set rset;
	struct timeval tv;
	
	// Create the listen socket and set it up
	listen_socket = socket (PF_INET, SOCK_STREAM, IPPROTO_TCP);
	if (listen_socket == -1) {
		NSLog (@PRODUCT ": Could not create socket for the IDE to connect to: %s", strerror (errno));
		return 1;
	} else {
		flag = 1;
		if (setsockopt (listen_socket, SOL_SOCKET, SO_REUSEADDR, &flag, sizeof (flag)) == -1) {
			NSLog (@PRODUCT ": Could not set SO_REUSEADDR on the listening socket (%s)", strerror (errno));
			// not a fatal failure
		}

		memset (&listen_addr, 0, sizeof (listen_addr));
		listen_addr.sin_family = AF_INET;
		listen_addr.sin_port = htons (output_port);
		listen_addr.sin_addr.s_addr = INADDR_ANY;
		rv = bind (listen_socket, (struct sockaddr *) &listen_addr, sizeof (listen_addr));
		if (rv == -1) {
			NSLog (@PRODUCT ": Could not bind to address: %s", strerror (errno));
			close (listen_socket);
			return 2;
		} else {
			// Make the socket non-blocking
			flags = fcntl (listen_socket, F_GETFL, NULL);
			flags |= O_NONBLOCK;
			fcntl (listen_socket, F_SETFL, flags);

			rv = listen (listen_socket, 1);
			if (rv == -1) {
				NSLog (@PRODUCT ": Could not listen for the IDE: %s", strerror (errno));
				close (listen_socket);
				return 2;
			} else {
				// Yay!
			}
		}
	}

	tv.tv_sec = 2;
	tv.tv_usec = 0;
	
	FD_ZERO (&rset);
	FD_SET (listen_socket, &rset);
	
	do {
		if ((rv = select (listen_socket + 1, &rset, NULL, NULL, &tv)) == 0) {
			// timeout hit, no connections available.
			NSLog (@PRODUCT ": Listened for connections from the IDE for 2 seconds, nobody connected.");
			close (listen_socket);
			return 3;
		}
	} while (rv == -1 && errno == EINTR);
	
	if (rv == -1) {
		NSLog (@PRODUCT ": Failed while waiting for the IDE to connect: %s", strerror (errno));
		close (listen_socket);
		return 2;
	}

	len = sizeof (struct sockaddr_in);
	output_socket = accept (listen_socket, (struct sockaddr *) &listen_addr, &len);
	if (output_socket == -1) {
		NSLog (@PRODUCT ": Failed to accept connection from the IDE: %s", strerror (errno));
		close (listen_socket);
		return 3;
	}

	flag = 1;
	if (setsockopt (output_socket, IPPROTO_TCP, TCP_NODELAY, (char *) &flag, sizeof (flag)) < 0) {
		NSLog (@PRODUCT ": Could not set TCP_NODELAY on socket (%s)", strerror (errno));
		// not a fatal failure
	}
		
	LOG (PRODUCT ": Successfully received USB connection from the IDE on port %i.\n", output_port);

	// make the socket block on reads/writes
	flags = fcntl (output_socket, F_GETFL, NULL);
	fcntl (output_socket, F_SETFL, flags & ~O_NONBLOCK);

	dup2 (output_socket, 1);
	dup2 (output_socket, 2);

	close (listen_socket); // no need to listen anymore
 
	debug_host = strdup ("127.0.0.1");

	return 0;
}

// SUCCESS = 0
// FAILURE > 0
int monotouch_debug_connect (NSMutableArray *ips, int debug_port, int output_port)
{
	// COOP: this is at startup and doesn't access managed memory, so we should be in safe mode here.
	MONO_ASSERT_GC_STARTING;
	
	unsigned char sockaddr[sizeof (struct sockaddr_in6)];
	struct sockaddr_in6 *sin6 = (struct sockaddr_in6 *) sockaddr;
	struct sockaddr_in *sin = (struct sockaddr_in *) sockaddr;
	int family, waiting, len, rv, i;
	int ip_count = [ips count];
	const char *family_str;
	int connected = -1;
	const char *ip;
	int *sockets;
	long flags;
	
	if (ip_count == 0) {
		NSLog (@PRODUCT ": No IPs to connect to.");
		return 2;
	}
	
	sockets = (int *) malloc (sizeof (int) * ip_count);
	for (i = 0; i < ip_count; i++)
		sockets[i] = -1;
	
	// Open a socket and try to establish a connection for each IP
	waiting = 0;
	for (i = 0; i < ip_count; i++) {
		ip = [[ips objectAtIndex:i] UTF8String];
		
		memset (sockaddr, 0, sizeof (sockaddr));
		
		// Parse the host IP, assuming IPv4 and falling back to IPv6
		if ((rv = inet_pton (AF_INET, ip, &sin->sin_addr)) == 1) {
			len = sin->sin_len = sizeof (struct sockaddr_in);
			family = sin->sin_family = AF_INET;
			sin->sin_port = htons (output_port);
			family_str = "IPv4";
		} else if (rv == 0 && (rv = inet_pton (AF_INET6, ip, &sin6->sin6_addr)) == 1) {
			len = sin6->sin6_len = sizeof (struct sockaddr_in6);
			family = sin6->sin6_family = AF_INET6;
			sin6->sin6_port = htons (output_port);
			family_str = "IPv6";
		} else {
			NSLog (@PRODUCT ": Error parsing '%s': %s", ip, errno ? strerror (errno) : "unsupported address type");
			sockets[i] = -1;
			continue;
		}
		
		if ((sockets[i] = socket (family, SOCK_STREAM, IPPROTO_TCP)) == -1) {
			NSLog (@PRODUCT ": Failed to create %s socket: %s", family_str, strerror (errno));
			continue;
		}
		
		// Make the socket non-blocking
		flags = fcntl (sockets[i], F_GETFL, NULL);
		fcntl (sockets[i], F_SETFL, flags | O_NONBLOCK);
		
		// Connect to the host
		if ((rv = connect (sockets[i], (struct sockaddr *) sockaddr, len)) == 0) {
			// connection completed, this is our man.
			connected = i;
			break;
		}
		
		if (rv < 0 && errno != EINPROGRESS) {
			NSLog (@PRODUCT ": Failed to connect to %s on port %d: %s", ip, output_port, strerror (errno));
			close (sockets[i]);
			sockets[i] = -1;
			continue;
		}
		
		// asynchronous connect
		waiting++;
	}
	
	// Wait for async socket connections to become available
	while (connected == -1 && waiting > 0) {
		socklen_t optlen = sizeof (int);
		fd_set rset, wset, xset;
		struct timeval tv;
		int max_fd = -1;
		int error;
		
		tv.tv_sec = 2;
		tv.tv_usec = 0;
		
		FD_ZERO (&rset);
		FD_ZERO (&wset);
		FD_ZERO (&xset);
		
		for (i = 0; i < ip_count; i++) {
			if (sockets[i] < 0)
				continue;
			
			max_fd = MAX (max_fd, sockets[i]);
			FD_SET (sockets[i], &rset);
			FD_SET (sockets[i], &wset);
			FD_SET (sockets[i], &xset);
		}
		
		if ((rv = select (max_fd + 1, &rset, &wset, &xset, &tv)) == 0) {
			// timeout hit, no connections available.
			free (sockets);
			return 1;
		}
		
		if (rv < 0) {
			if (errno == EINTR || errno == EAGAIN)
				continue;
			
			// irrecoverable error
			NSLog (@PRODUCT ": Error while waiting for connections: %s", strerror (errno));
			free (sockets);
			return 1;
		}
		
		for (i = 0; i < ip_count; i++) {
			if (sockets[i] < 0)
				continue;
			
			if (FD_ISSET (sockets[i], &xset)) {
				// exception on this socket
				close (sockets[i]);
				sockets[i] = -1;
				waiting--;
				continue;
			}
			
			if (!FD_ISSET (sockets[i], &rset) && !FD_ISSET (sockets[i], &wset)) {
				// still waiting...
				continue;
			}
			
			// okay, this socket is ready for reading or writing...
			if (getsockopt (sockets[i], SOL_SOCKET, SO_ERROR, &error, &optlen) < 0) {
				NSLog (@PRODUCT ": Error while trying to get socket options for %s: %s", [[ips objectAtIndex:i] UTF8String], strerror (errno));
				close (sockets[i]);
				sockets[i] = -1;
				waiting--;
				continue;
			}
			
			if (error != 0) {
				NSLog (@PRODUCT ": Socket error while connecting to the IDE on %s:%d: %s", [[ips objectAtIndex:i] UTF8String], output_port, strerror (error));
				close (sockets[i]);
				sockets[i] = -1;
				waiting--;
				continue;
			}
			
			// success!
			connected = i;
			break;
		}
	}
	
	if (connected == -1) {
		free (sockets);
		return 1;
	}
	
	// make the socket block on reads/writes
	flags = fcntl (sockets[connected], F_GETFL, NULL);
	fcntl (sockets[connected], F_SETFL, flags & ~O_NONBLOCK);
 
	LOG (PRODUCT ": Connected output to the IDE on %s:%d\n", [[ips objectAtIndex:i] UTF8String], output_port);

	dup2 (sockets[connected], 1);
	dup2 (sockets[connected], 2);

	debug_host = strdup ([[ips objectAtIndex:connected] UTF8String]);
	
	// close the remaining sockets
	for (i = 0; i < ip_count; i++) {
		if (i == connected || sockets[i] < 0)
			continue;
		
		close (sockets[i]);
		sockets[i] = -1;
	}
	
	free (sockets);
	
	return 0;
}

#else
int fix_ranlib_warning_about_no_symbols_v2;
#endif /* DEBUG */

