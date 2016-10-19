using System;

#if IKVM
using IKVM.Reflection;
using Type=IKVM.Reflection.Type;
#else
using System.Reflection;
using Type = System.Type;
#endif

//#if IKVM
//public class ExportAttribute : Attribute {}
//public class AvailabilityBaseAttribute : Attribute {}
//public class ProtocolAttribute : Attribute {}
//#endif
