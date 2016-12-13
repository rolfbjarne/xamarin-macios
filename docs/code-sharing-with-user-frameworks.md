Code sharing with user frameworks
=================================

Xamarin.iOS can AOT-compile assemblies into:

* A static object (one static object per assembly).
* A dynamic library (one dynamic library per assembly). This is used for
  incremental builds.
* A user framework (one or more assemblies per framework).

The last case is interesting, because user frameworks can be used to share
code between extensions and the main app.

Xamarin.iOS leverages this to build one framework for all the assemblies in
the SDK, and this framework is shared between extensions and the main app.
This significantly reduces total code size of the app.


