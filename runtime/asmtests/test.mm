#include <stdio.h>

#include <Foundation/Foundation.h>

extern "C" {
	int xamarin_get_frame_length (id self, SEL sel);
	void xamarin_dyn_objc_msgSend (id self, SEL sel);
	void objc_msgSend ();
	void xamarin_process_nsexception_with_mode (NSException *exc, bool something, void** exception_gchandle);
	void whatever ();
	void whatever2 (int i);
}
extern int xamarin_marshal_objectivec_exception_mode;
/*
void xamarin_dyn_objc_msgSend (id self, SEL sel)
{
	@try {
		int i = xamarin_get_frame_length (self, sel);
		objc_msgSend ();
	} @catch (NSException *exc) {
		xamarin_process_nsexception_with_mode (exc, false, NULL);
	}
}
*/

void whatever ()
{
	objc_msgSend ();
	whatever2 (xamarin_marshal_objectivec_exception_mode);
}
