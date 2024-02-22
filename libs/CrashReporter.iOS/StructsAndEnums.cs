using System;
using System.Runtime.InteropServices;
using ObjCRuntime;

namespace CrashReporter
{
	[Native]
	public enum PLCrashReporterSignalHandlerType : ulong
	{
		Bsd = 0,
		Mach = 1
	}

	[Flags]
	[Native]
	public enum PLCrashReporterSymbolicationStrategy : ulong
	{
		None = 0x0,
		SymbolTable = 1uL << 0,
		ObjC = 1uL << 1,
		All = (SymbolTable | ObjC)
	}

	[StructLayout (LayoutKind.Sequential)]
	public struct PLCrashReporterCallbacks
	{
		public ushort version;

		public unsafe IntPtr context;

		public unsafe IntPtr handleSignal;
	}

	public enum PLCrashReportProcessorTypeEncoding : uint
	{
		Unknown = 0,
		Mach = 1
	}

	public enum PLCrashReportOperatingSystem : uint
	{
		MacOSX = 0,
		iPhoneOS = 1,
		iPhoneSimulator = 2,
		Unknown = 3,
		AppleTVOS = 4
	}

	public enum PLCrashReportArchitecture : uint
	{
		X8632 = 0,
		X8664 = 1,
		ARMv6 = 2,
		Arm = ARMv6,
		Ppc = 3,
		Ppc64 = 4,
		ARMv7 = 5,
		Unknown = 6
	}

	[StructLayout (LayoutKind.Sequential)]
	public struct PLCrashReportFileHeader
	{
		public sbyte[] magic;

		public byte version;

		public byte[] data;
	}

	public enum PLCrashReportTextFormat : uint
	{
		PLCrashReportTextFormatiOS = 0
	}

	public enum PLCrashReporterError : uint
	{
		Unknown = 0,
		OperatingSystem = 1,
		CrashReportInvalid = 2,
		ResourceBusy = 3
	}
}
