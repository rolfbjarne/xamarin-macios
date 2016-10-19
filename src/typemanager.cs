#if IKVM
using IKVM.Reflection;
using Type=IKVM.Reflection.Type;
#else
using System.Reflection;
using Type=System.Type;
#endif


public static class TypeManager {
	public static Type System_Int32 { get; set; }
	public static Type System_Int64 { get; set; }
	public static Type System_UInt32 { get; set; }
	public static Type System_UInt64 { get; set; }
	public static Type System_Int16 { get; set; }
	public static Type System_UInt16 { get; set; }
	public static Type System_Byte { get; set; }
	public static Type System_SByte { get; set; }
	public static Type System_Double { get; set; }
	public static Type System_Float { get; set; }
	public static Type System_Boolean {get; set; }
	public static Type System_IntPtr { get; set; }
	public static Type System_nint { get; set; }
	public static Type System_nuint { get; set; }
	public static Type System_nfloat { get; set; }

	static TypeManager ()
	{
#if IKVM

#else
	System_Int32 = typeof (int);
	System_Int64 = typeof (long);
	System_UInt32 = typeof (uint);
	System_UInt64 = typeof (ulong);
	System_Int16 = typeof (short);
	System_UInt16 = typeof (ushort);
	System_Byte = typeof (byte);
	System_SByte = typeof (sbyte);
	System_Double = typeof (double);
	System_Float = typeof (float);
	System_Boolean = typeof (bool);
	System_IntPtr = typeof (System.IntPtr);
#if __UNIFIED__
	System_nint = typeof (System.nint);
	System_nuint = typeof (System.nuint);
	System_nfloat = typeof (System.nfloat);
#endif
#endif
	}
}