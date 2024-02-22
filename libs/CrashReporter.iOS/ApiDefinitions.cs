using System;
using CoreFoundation;
using CrashReporter;
using Foundation;
using ObjCRuntime;

namespace CrashReporter
{
	// @interface PLCrashReporterConfig : NSObject
	[BaseType (typeof(NSObject))]
	interface PLCrashReporterConfig
	{
		// +(instancetype)defaultConfiguration;
		[Static]
		[Export ("defaultConfiguration")]
		PLCrashReporterConfig DefaultConfiguration ();

		// -(instancetype)initWithBasePath:(NSString *)basePath;
		[Export ("initWithBasePath:")]
		IntPtr Constructor (string basePath);

		// -(instancetype)initWithSignalHandlerType:(PLCrashReporterSignalHandlerType)signalHandlerType symbolicationStrategy:(PLCrashReporterSymbolicationStrategy)symbolicationStrategy;
		[Export ("initWithSignalHandlerType:symbolicationStrategy:")]
		IntPtr Constructor (PLCrashReporterSignalHandlerType signalHandlerType, PLCrashReporterSymbolicationStrategy symbolicationStrategy);

		// -(instancetype)initWithSignalHandlerType:(PLCrashReporterSignalHandlerType)signalHandlerType symbolicationStrategy:(PLCrashReporterSymbolicationStrategy)symbolicationStrategy basePath:(NSString *)basePath;
		[Export ("initWithSignalHandlerType:symbolicationStrategy:basePath:")]
		IntPtr Constructor (PLCrashReporterSignalHandlerType signalHandlerType, PLCrashReporterSymbolicationStrategy symbolicationStrategy, string basePath);

		// -(instancetype)initWithSignalHandlerType:(PLCrashReporterSignalHandlerType)signalHandlerType symbolicationStrategy:(PLCrashReporterSymbolicationStrategy)symbolicationStrategy shouldRegisterUncaughtExceptionHandler:(BOOL)shouldRegisterUncaughtExceptionHandler;
		[Export ("initWithSignalHandlerType:symbolicationStrategy:shouldRegisterUncaughtExceptionHandler:")]
		IntPtr Constructor (PLCrashReporterSignalHandlerType signalHandlerType, PLCrashReporterSymbolicationStrategy symbolicationStrategy, bool shouldRegisterUncaughtExceptionHandler);

		// -(instancetype)initWithSignalHandlerType:(PLCrashReporterSignalHandlerType)signalHandlerType symbolicationStrategy:(PLCrashReporterSymbolicationStrategy)symbolicationStrategy shouldRegisterUncaughtExceptionHandler:(BOOL)shouldRegisterUncaughtExceptionHandler basePath:(NSString *)basePath;
		[Export ("initWithSignalHandlerType:symbolicationStrategy:shouldRegisterUncaughtExceptionHandler:basePath:")]
		IntPtr Constructor (PLCrashReporterSignalHandlerType signalHandlerType, PLCrashReporterSymbolicationStrategy symbolicationStrategy, bool shouldRegisterUncaughtExceptionHandler, string basePath);

		// @property (readonly, nonatomic) NSString * basePath;
		[Export ("basePath")]
		string BasePath { get; }

		// @property (readonly, nonatomic) PLCrashReporterSignalHandlerType signalHandlerType;
		[Export ("signalHandlerType")]
		PLCrashReporterSignalHandlerType SignalHandlerType { get; }

		// @property (readonly, nonatomic) PLCrashReporterSymbolicationStrategy symbolicationStrategy;
		[Export ("symbolicationStrategy")]
		PLCrashReporterSymbolicationStrategy SymbolicationStrategy { get; }

		// @property (readonly, nonatomic) BOOL shouldRegisterUncaughtExceptionHandler;
		[Export ("shouldRegisterUncaughtExceptionHandler")]
		bool ShouldRegisterUncaughtExceptionHandler { get; }
	}

	// @interface PLCrashReporter : NSObject
	[BaseType (typeof(NSObject))]
	interface PLCrashReporter
	{
		// +(PLCrashReporter *)sharedReporter __attribute__((deprecated("")));
		[Static]
		[Export ("sharedReporter")]
		[Verify (MethodToProperty)]
		PLCrashReporter SharedReporter { get; }

		// -(instancetype)initWithConfiguration:(PLCrashReporterConfig *)config;
		[Export ("initWithConfiguration:")]
		IntPtr Constructor (PLCrashReporterConfig config);

		// -(BOOL)hasPendingCrashReport;
		[Export ("hasPendingCrashReport")]
		[Verify (MethodToProperty)]
		bool HasPendingCrashReport { get; }

		// -(NSData *)loadPendingCrashReportData;
		[Export ("loadPendingCrashReportData")]
		[Verify (MethodToProperty)]
		NSData LoadPendingCrashReportData { get; }

		// -(NSData *)loadPendingCrashReportDataAndReturnError:(NSError **)outError;
		[Export ("loadPendingCrashReportDataAndReturnError:")]
		NSData LoadPendingCrashReportDataAndReturnError (out NSError outError);

		// -(NSData *)generateLiveReportWithThread:(thread_t)thread;
		[Export ("generateLiveReportWithThread:")]
		NSData GenerateLiveReportWithThread (uint thread);

		// -(NSData *)generateLiveReportWithThread:(thread_t)thread error:(NSError **)outError;
		[Export ("generateLiveReportWithThread:error:")]
		NSData GenerateLiveReportWithThread (uint thread, out NSError outError);

		// -(NSData *)generateLiveReportWithThread:(thread_t)thread exception:(NSException *)exception error:(NSError **)outError;
		[Export ("generateLiveReportWithThread:exception:error:")]
		NSData GenerateLiveReportWithThread (uint thread, NSException exception, out NSError outError);

		// -(NSData *)generateLiveReport;
		[Export ("generateLiveReport")]
		[Verify (MethodToProperty)]
		NSData GenerateLiveReport { get; }

		// -(NSData *)generateLiveReportAndReturnError:(NSError **)outError;
		[Export ("generateLiveReportAndReturnError:")]
		NSData GenerateLiveReportAndReturnError (out NSError outError);

		// -(NSData *)generateLiveReportWithException:(NSException *)exception error:(NSError **)outError;
		[Export ("generateLiveReportWithException:error:")]
		NSData GenerateLiveReportWithException (NSException exception, out NSError outError);

		// -(BOOL)purgePendingCrashReport;
		[Export ("purgePendingCrashReport")]
		[Verify (MethodToProperty)]
		bool PurgePendingCrashReport { get; }

		// -(BOOL)purgePendingCrashReportAndReturnError:(NSError **)outError;
		[Export ("purgePendingCrashReportAndReturnError:")]
		bool PurgePendingCrashReportAndReturnError (out NSError outError);

		// -(BOOL)enableCrashReporter;
		[Export ("enableCrashReporter")]
		[Verify (MethodToProperty)]
		bool EnableCrashReporter { get; }

		// -(BOOL)enableCrashReporterAndReturnError:(NSError **)outError;
		[Export ("enableCrashReporterAndReturnError:")]
		bool EnableCrashReporterAndReturnError (out NSError outError);

		// -(void)setCrashCallbacks:(PLCrashReporterCallbacks *)callbacks;
		[Export ("setCrashCallbacks:")]
		unsafe void SetCrashCallbacks (PLCrashReporterCallbacks* callbacks);

		// -(NSString *)crashReportPath;
		[Export ("crashReportPath")]
		[Verify (MethodToProperty)]
		string CrashReportPath { get; }

		// @property (nonatomic, strong) NSData * customData;
		[Export ("customData", ArgumentSemantic.Strong)]
		NSData CustomData { get; set; }
	}

	// @interface PLCrashReportApplicationInfo : NSObject
	[BaseType (typeof(NSObject))]
	interface PLCrashReportApplicationInfo
	{
		// -(id)initWithApplicationIdentifier:(NSString *)applicationIdentifier applicationVersion:(NSString *)applicationVersion applicationMarketingVersion:(NSString *)applicationMarketingVersion;
		[Export ("initWithApplicationIdentifier:applicationVersion:applicationMarketingVersion:")]
		IntPtr Constructor (string applicationIdentifier, string applicationVersion, string applicationMarketingVersion);

		// @property (readonly, nonatomic, strong) NSString * applicationIdentifier;
		[Export ("applicationIdentifier", ArgumentSemantic.Strong)]
		string ApplicationIdentifier { get; }

		// @property (readonly, nonatomic, strong) NSString * applicationVersion;
		[Export ("applicationVersion", ArgumentSemantic.Strong)]
		string ApplicationVersion { get; }

		// @property (readonly, nonatomic, strong) NSString * applicationMarketingVersion;
		[Export ("applicationMarketingVersion", ArgumentSemantic.Strong)]
		string ApplicationMarketingVersion { get; }
	}

	// @interface PLCrashReportProcessorInfo : NSObject
	[BaseType (typeof(NSObject))]
	interface PLCrashReportProcessorInfo
	{
		// -(id)initWithTypeEncoding:(PLCrashReportProcessorTypeEncoding)typeEncoding type:(uint64_t)type subtype:(uint64_t)subtype;
		[Export ("initWithTypeEncoding:type:subtype:")]
		IntPtr Constructor (PLCrashReportProcessorTypeEncoding typeEncoding, ulong type, ulong subtype);

		// @property (readonly, nonatomic) PLCrashReportProcessorTypeEncoding typeEncoding;
		[Export ("typeEncoding")]
		PLCrashReportProcessorTypeEncoding TypeEncoding { get; }

		// @property (readonly, nonatomic) uint64_t type;
		[Export ("type")]
		ulong Type { get; }

		// @property (readonly, nonatomic) uint64_t subtype;
		[Export ("subtype")]
		ulong Subtype { get; }
	}

	// @interface PLCrashReportBinaryImageInfo : NSObject
	[BaseType (typeof(NSObject))]
	interface PLCrashReportBinaryImageInfo
	{
		// -(id)initWithCodeType:(PLCrashReportProcessorInfo *)processorInfo baseAddress:(uint64_t)baseAddress size:(uint64_t)imageSize name:(NSString *)imageName uuid:(NSData *)uuid;
		[Export ("initWithCodeType:baseAddress:size:name:uuid:")]
		IntPtr Constructor (PLCrashReportProcessorInfo processorInfo, ulong baseAddress, ulong imageSize, string imageName, NSData uuid);

		// @property (readonly, nonatomic, strong) PLCrashReportProcessorInfo * codeType;
		[Export ("codeType", ArgumentSemantic.Strong)]
		PLCrashReportProcessorInfo CodeType { get; }

		// @property (readonly, nonatomic) uint64_t imageBaseAddress;
		[Export ("imageBaseAddress")]
		ulong ImageBaseAddress { get; }

		// @property (readonly, nonatomic) uint64_t imageSize;
		[Export ("imageSize")]
		ulong ImageSize { get; }

		// @property (readonly, nonatomic, strong) NSString * imageName;
		[Export ("imageName", ArgumentSemantic.Strong)]
		string ImageName { get; }

		// @property (readonly, nonatomic) BOOL hasImageUUID;
		[Export ("hasImageUUID")]
		bool HasImageUUID { get; }

		// @property (readonly, nonatomic, strong) NSString * imageUUID;
		[Export ("imageUUID", ArgumentSemantic.Strong)]
		string ImageUUID { get; }
	}

	// @interface PLCrashReportSymbolInfo : NSObject
	[BaseType (typeof(NSObject))]
	interface PLCrashReportSymbolInfo
	{
		// -(id)initWithSymbolName:(NSString *)symbolName startAddress:(uint64_t)startAddress endAddress:(uint64_t)endAddress;
		[Export ("initWithSymbolName:startAddress:endAddress:")]
		IntPtr Constructor (string symbolName, ulong startAddress, ulong endAddress);

		// @property (readonly, nonatomic, strong) NSString * symbolName;
		[Export ("symbolName", ArgumentSemantic.Strong)]
		string SymbolName { get; }

		// @property (readonly, nonatomic) uint64_t startAddress;
		[Export ("startAddress")]
		ulong StartAddress { get; }

		// @property (readonly, nonatomic) uint64_t endAddress;
		[Export ("endAddress")]
		ulong EndAddress { get; }
	}

	// @interface PLCrashReportStackFrameInfo : NSObject
	[BaseType (typeof(NSObject))]
	interface PLCrashReportStackFrameInfo
	{
		// -(id)initWithInstructionPointer:(uint64_t)instructionPointer symbolInfo:(PLCrashReportSymbolInfo *)symbolInfo;
		[Export ("initWithInstructionPointer:symbolInfo:")]
		IntPtr Constructor (ulong instructionPointer, PLCrashReportSymbolInfo symbolInfo);

		// @property (readonly, nonatomic) uint64_t instructionPointer;
		[Export ("instructionPointer")]
		ulong InstructionPointer { get; }

		// @property (readonly, nonatomic) PLCrashReportSymbolInfo * symbolInfo;
		[Export ("symbolInfo")]
		PLCrashReportSymbolInfo SymbolInfo { get; }
	}

	// @interface PLCrashReportRegisterInfo : NSObject
	[BaseType (typeof(NSObject))]
	interface PLCrashReportRegisterInfo
	{
		// -(id)initWithRegisterName:(NSString *)registerName registerValue:(uint64_t)registerValue;
		[Export ("initWithRegisterName:registerValue:")]
		IntPtr Constructor (string registerName, ulong registerValue);

		// @property (readonly, nonatomic, strong) NSString * registerName;
		[Export ("registerName", ArgumentSemantic.Strong)]
		string RegisterName { get; }

		// @property (readonly, nonatomic) uint64_t registerValue;
		[Export ("registerValue")]
		ulong RegisterValue { get; }
	}

	// @interface PLCrashReportThreadInfo : NSObject
	[BaseType (typeof(NSObject))]
	interface PLCrashReportThreadInfo
	{
		// -(id)initWithThreadNumber:(NSInteger)threadNumber stackFrames:(NSArray *)stackFrames crashed:(BOOL)crashed registers:(NSArray *)registers;
		[Export ("initWithThreadNumber:stackFrames:crashed:registers:")]
		[Verify (StronglyTypedNSArray), Verify (StronglyTypedNSArray)]
		IntPtr Constructor (nint threadNumber, NSObject[] stackFrames, bool crashed, NSObject[] registers);

		// @property (readonly, nonatomic) NSInteger threadNumber;
		[Export ("threadNumber")]
		nint ThreadNumber { get; }

		// @property (readonly, nonatomic, strong) NSArray * stackFrames;
		[Export ("stackFrames", ArgumentSemantic.Strong)]
		[Verify (StronglyTypedNSArray)]
		NSObject[] StackFrames { get; }

		// @property (readonly, nonatomic) BOOL crashed;
		[Export ("crashed")]
		bool Crashed { get; }

		// @property (readonly, nonatomic, strong) NSArray * registers;
		[Export ("registers", ArgumentSemantic.Strong)]
		[Verify (StronglyTypedNSArray)]
		NSObject[] Registers { get; }
	}

	// @interface PLCrashReportExceptionInfo : NSObject
	[BaseType (typeof(NSObject))]
	interface PLCrashReportExceptionInfo
	{
		// -(id)initWithExceptionName:(NSString *)name reason:(NSString *)reason;
		[Export ("initWithExceptionName:reason:")]
		IntPtr Constructor (string name, string reason);

		// -(id)initWithExceptionName:(NSString *)name reason:(NSString *)reason stackFrames:(NSArray *)stackFrames;
		[Export ("initWithExceptionName:reason:stackFrames:")]
		[Verify (StronglyTypedNSArray)]
		IntPtr Constructor (string name, string reason, NSObject[] stackFrames);

		// @property (readonly, nonatomic, strong) NSString * exceptionName;
		[Export ("exceptionName", ArgumentSemantic.Strong)]
		string ExceptionName { get; }

		// @property (readonly, nonatomic, strong) NSString * exceptionReason;
		[Export ("exceptionReason", ArgumentSemantic.Strong)]
		string ExceptionReason { get; }

		// @property (readonly, nonatomic, strong) NSArray * stackFrames;
		[Export ("stackFrames", ArgumentSemantic.Strong)]
		[Verify (StronglyTypedNSArray)]
		NSObject[] StackFrames { get; }
	}

	// @interface PLCrashReportMachineInfo : NSObject
	[BaseType (typeof(NSObject))]
	interface PLCrashReportMachineInfo
	{
		// -(id)initWithModelName:(NSString *)modelName processorInfo:(PLCrashReportProcessorInfo *)processorInfo processorCount:(NSUInteger)processorCount logicalProcessorCount:(NSUInteger)logicalProcessorCount;
		[Export ("initWithModelName:processorInfo:processorCount:logicalProcessorCount:")]
		IntPtr Constructor (string modelName, PLCrashReportProcessorInfo processorInfo, nuint processorCount, nuint logicalProcessorCount);

		// @property (readonly, nonatomic, strong) NSString * modelName;
		[Export ("modelName", ArgumentSemantic.Strong)]
		string ModelName { get; }

		// @property (readonly, nonatomic, strong) PLCrashReportProcessorInfo * processorInfo;
		[Export ("processorInfo", ArgumentSemantic.Strong)]
		PLCrashReportProcessorInfo ProcessorInfo { get; }

		// @property (readonly, nonatomic) NSUInteger processorCount;
		[Export ("processorCount")]
		nuint ProcessorCount { get; }

		// @property (readonly, nonatomic) NSUInteger logicalProcessorCount;
		[Export ("logicalProcessorCount")]
		nuint LogicalProcessorCount { get; }
	}

	// @interface PLCrashReportMachExceptionInfo : NSObject
	[BaseType (typeof(NSObject))]
	interface PLCrashReportMachExceptionInfo
	{
		// -(id)initWithType:(uint64_t)type codes:(NSArray *)codes;
		[Export ("initWithType:codes:")]
		[Verify (StronglyTypedNSArray)]
		IntPtr Constructor (ulong type, NSObject[] codes);

		// @property (readonly, nonatomic) uint64_t type;
		[Export ("type")]
		ulong Type { get; }

		// @property (readonly, nonatomic, strong) NSArray * codes;
		[Export ("codes", ArgumentSemantic.Strong)]
		[Verify (StronglyTypedNSArray)]
		NSObject[] Codes { get; }
	}

	// @interface PLCrashReportProcessInfo : NSObject
	[BaseType (typeof(NSObject))]
	interface PLCrashReportProcessInfo
	{
		// -(id)initWithProcessName:(NSString *)processName processID:(NSUInteger)processID processPath:(NSString *)processPath processStartTime:(NSDate *)processStartTime parentProcessName:(NSString *)parentProcessName parentProcessID:(NSUInteger)parentProcessID native:(BOOL)native;
		[Export ("initWithProcessName:processID:processPath:processStartTime:parentProcessName:parentProcessID:native:")]
		IntPtr Constructor (string processName, nuint processID, string processPath, NSDate processStartTime, string parentProcessName, nuint parentProcessID, bool native);

		// @property (readonly, nonatomic, strong) NSString * processName;
		[Export ("processName", ArgumentSemantic.Strong)]
		string ProcessName { get; }

		// @property (readonly, nonatomic) NSUInteger processID;
		[Export ("processID")]
		nuint ProcessID { get; }

		// @property (readonly, nonatomic, strong) NSString * processPath;
		[Export ("processPath", ArgumentSemantic.Strong)]
		string ProcessPath { get; }

		// @property (readonly, nonatomic, strong) NSDate * processStartTime;
		[Export ("processStartTime", ArgumentSemantic.Strong)]
		NSDate ProcessStartTime { get; }

		// @property (readonly, nonatomic, strong) NSString * parentProcessName;
		[Export ("parentProcessName", ArgumentSemantic.Strong)]
		string ParentProcessName { get; }

		// @property (readonly, nonatomic) NSUInteger parentProcessID;
		[Export ("parentProcessID")]
		nuint ParentProcessID { get; }

		// @property (readonly, nonatomic) BOOL native;
		[Export ("native")]
		bool Native { get; }
	}

	// @interface PLCrashReportSignalInfo : NSObject
	[BaseType (typeof(NSObject))]
	interface PLCrashReportSignalInfo
	{
		// -(id)initWithSignalName:(NSString *)name code:(NSString *)code address:(uint64_t)address;
		[Export ("initWithSignalName:code:address:")]
		IntPtr Constructor (string name, string code, ulong address);

		// @property (readonly, nonatomic, strong) NSString * name;
		[Export ("name", ArgumentSemantic.Strong)]
		string Name { get; }

		// @property (readonly, nonatomic, strong) NSString * code;
		[Export ("code", ArgumentSemantic.Strong)]
		string Code { get; }

		// @property (readonly, nonatomic) uint64_t address;
		[Export ("address")]
		ulong Address { get; }
	}

	[Static]
	[Verify (ConstantsInterfaceAssociation)]
	partial interface Constants
	{
		// extern PLCrashReportOperatingSystem PLCrashReportHostOperatingSystem;
		[Field ("PLCrashReportHostOperatingSystem", "__Internal")]
		PLCrashReportOperatingSystem PLCrashReportHostOperatingSystem { get; }

		// extern PLCrashReportArchitecture PLCrashReportHostArchitecture __attribute__((deprecated("")));
		[Field ("PLCrashReportHostArchitecture", "__Internal")]
		PLCrashReportArchitecture PLCrashReportHostArchitecture { get; }
	}

	// @interface PLCrashReportSystemInfo : NSObject
	[BaseType (typeof(NSObject))]
	interface PLCrashReportSystemInfo
	{
		// -(id)initWithOperatingSystem:(PLCrashReportOperatingSystem)operatingSystem operatingSystemVersion:(NSString *)operatingSystemVersion architecture:(PLCrashReportArchitecture)architecture timestamp:(NSDate *)timestamp __attribute__((deprecated("")));
		[Export ("initWithOperatingSystem:operatingSystemVersion:architecture:timestamp:")]
		IntPtr Constructor (PLCrashReportOperatingSystem operatingSystem, string operatingSystemVersion, PLCrashReportArchitecture architecture, NSDate timestamp);

		// -(id)initWithOperatingSystem:(PLCrashReportOperatingSystem)operatingSystem operatingSystemVersion:(NSString *)operatingSystemVersion operatingSystemBuild:(NSString *)operatingSystemBuild architecture:(PLCrashReportArchitecture)architecture timestamp:(NSDate *)timestamp __attribute__((deprecated("")));
		[Export ("initWithOperatingSystem:operatingSystemVersion:operatingSystemBuild:architecture:timestamp:")]
		IntPtr Constructor (PLCrashReportOperatingSystem operatingSystem, string operatingSystemVersion, string operatingSystemBuild, PLCrashReportArchitecture architecture, NSDate timestamp);

		// -(id)initWithOperatingSystem:(PLCrashReportOperatingSystem)operatingSystem operatingSystemVersion:(NSString *)operatingSystemVersion operatingSystemBuild:(NSString *)operatingSystemBuild architecture:(PLCrashReportArchitecture)architecture processorInfo:(PLCrashReportProcessorInfo *)processorInfo timestamp:(NSDate *)timestamp;
		[Export ("initWithOperatingSystem:operatingSystemVersion:operatingSystemBuild:architecture:processorInfo:timestamp:")]
		IntPtr Constructor (PLCrashReportOperatingSystem operatingSystem, string operatingSystemVersion, string operatingSystemBuild, PLCrashReportArchitecture architecture, PLCrashReportProcessorInfo processorInfo, NSDate timestamp);

		// @property (readonly, nonatomic) PLCrashReportOperatingSystem operatingSystem;
		[Export ("operatingSystem")]
		PLCrashReportOperatingSystem OperatingSystem { get; }

		// @property (readonly, nonatomic, strong) NSString * operatingSystemVersion;
		[Export ("operatingSystemVersion", ArgumentSemantic.Strong)]
		string OperatingSystemVersion { get; }

		// @property (readonly, nonatomic, strong) NSString * operatingSystemBuild;
		[Export ("operatingSystemBuild", ArgumentSemantic.Strong)]
		string OperatingSystemBuild { get; }

		// @property (readonly, nonatomic) PLCrashReportArchitecture architecture __attribute__((deprecated("")));
		[Export ("architecture")]
		PLCrashReportArchitecture Architecture { get; }

		// @property (readonly, nonatomic, strong) NSDate * timestamp;
		[Export ("timestamp", ArgumentSemantic.Strong)]
		NSDate Timestamp { get; }

		// @property (readonly, nonatomic, strong) PLCrashReportProcessorInfo * processorInfo;
		[Export ("processorInfo", ArgumentSemantic.Strong)]
		PLCrashReportProcessorInfo ProcessorInfo { get; }
	}

	// @interface PLCrashReport : NSObject
	[BaseType (typeof(NSObject))]
	interface PLCrashReport
	{
		// -(id)initWithData:(NSData *)encodedData error:(NSError **)outError;
		[Export ("initWithData:error:")]
		IntPtr Constructor (NSData encodedData, out NSError outError);

		// -(PLCrashReportBinaryImageInfo *)imageForAddress:(uint64_t)address;
		[Export ("imageForAddress:")]
		PLCrashReportBinaryImageInfo ImageForAddress (ulong address);

		// @property (readonly, nonatomic, strong) PLCrashReportSystemInfo * systemInfo;
		[Export ("systemInfo", ArgumentSemantic.Strong)]
		PLCrashReportSystemInfo SystemInfo { get; }

		// @property (readonly, nonatomic) BOOL hasMachineInfo;
		[Export ("hasMachineInfo")]
		bool HasMachineInfo { get; }

		// @property (readonly, nonatomic, strong) PLCrashReportMachineInfo * machineInfo;
		[Export ("machineInfo", ArgumentSemantic.Strong)]
		PLCrashReportMachineInfo MachineInfo { get; }

		// @property (readonly, nonatomic, strong) PLCrashReportApplicationInfo * applicationInfo;
		[Export ("applicationInfo", ArgumentSemantic.Strong)]
		PLCrashReportApplicationInfo ApplicationInfo { get; }

		// @property (readonly, nonatomic) BOOL hasProcessInfo;
		[Export ("hasProcessInfo")]
		bool HasProcessInfo { get; }

		// @property (readonly, nonatomic, strong) PLCrashReportProcessInfo * processInfo;
		[Export ("processInfo", ArgumentSemantic.Strong)]
		PLCrashReportProcessInfo ProcessInfo { get; }

		// @property (readonly, nonatomic, strong) PLCrashReportSignalInfo * signalInfo;
		[Export ("signalInfo", ArgumentSemantic.Strong)]
		PLCrashReportSignalInfo SignalInfo { get; }

		// @property (readonly, nonatomic, strong) PLCrashReportMachExceptionInfo * machExceptionInfo;
		[Export ("machExceptionInfo", ArgumentSemantic.Strong)]
		PLCrashReportMachExceptionInfo MachExceptionInfo { get; }

		// @property (readonly, nonatomic, strong) NSArray * threads;
		[Export ("threads", ArgumentSemantic.Strong)]
		[Verify (StronglyTypedNSArray)]
		NSObject[] Threads { get; }

		// @property (readonly, nonatomic, strong) NSArray * images;
		[Export ("images", ArgumentSemantic.Strong)]
		[Verify (StronglyTypedNSArray)]
		NSObject[] Images { get; }

		// @property (readonly, nonatomic) BOOL hasExceptionInfo;
		[Export ("hasExceptionInfo")]
		bool HasExceptionInfo { get; }

		// @property (readonly, nonatomic, strong) PLCrashReportExceptionInfo * exceptionInfo;
		[Export ("exceptionInfo", ArgumentSemantic.Strong)]
		PLCrashReportExceptionInfo ExceptionInfo { get; }

		// @property (readonly, nonatomic, strong) NSData * customData;
		[Export ("customData", ArgumentSemantic.Strong)]
		NSData CustomData { get; }

		// @property (readonly, nonatomic) CFUUIDRef uuidRef;
		[Export ("uuidRef")]
		unsafe CFUUIDRef* UuidRef { get; }
	}

	// @protocol PLCrashReportFormatter
	/*
  Check whether adding [Model] to this declaration is appropriate.
  [Model] is used to generate a C# class that implements this protocol,
  and might be useful for protocols that consumers are supposed to implement,
  since consumers can subclass the generated class instead of implementing
  the generated interface. If consumers are not supposed to implement this
  protocol, then [Model] is redundant and will generate code that will never
  be used.
*/[Protocol]
	interface PLCrashReportFormatter
	{
		// @required -(NSData *)formatReport:(PLCrashReport *)report error:(NSError **)outError;
		[Abstract]
		[Export ("formatReport:error:")]
		NSData Error (PLCrashReport report, out NSError outError);
	}

	// @interface PLCrashReportTextFormatter : NSObject <PLCrashReportFormatter>
	[BaseType (typeof(NSObject))]
	interface PLCrashReportTextFormatter : IPLCrashReportFormatter
	{
		// +(NSString *)stringValueForCrashReport:(PLCrashReport *)report withTextFormat:(PLCrashReportTextFormat)textFormat;
		[Static]
		[Export ("stringValueForCrashReport:withTextFormat:")]
		string StringValueForCrashReport (PLCrashReport report, PLCrashReportTextFormat textFormat);

		// -(id)initWithTextFormat:(PLCrashReportTextFormat)textFormat stringEncoding:(NSStringEncoding)stringEncoding;
		[Export ("initWithTextFormat:stringEncoding:")]
		IntPtr Constructor (PLCrashReportTextFormat textFormat, nuint stringEncoding);
	}

	[Static]
	[Verify (ConstantsInterfaceAssociation)]
	partial interface Constants
	{
		// extern NSString * PLCrashReporterException;
		[Field ("PLCrashReporterException", "__Internal")]
		NSString PLCrashReporterException { get; }

		// extern NSString * PLCrashReporterErrorDomain;
		[Field ("PLCrashReporterErrorDomain", "__Internal")]
		NSString PLCrashReporterErrorDomain { get; }
	}
}
