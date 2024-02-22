using Foundation;

namespace DatadogCrashReporting
{
	// @interface DDCrashReporter : NSObject
	[BaseType (typeof(NSObject))]
	interface DDCrashReporter
	{
		// +(void)enable;
		[Static]
		[Export ("enable")]
		void Enable ();
	}

	[Static]
	[Verify (ConstantsInterfaceAssociation)]
	partial interface Constants
	{
		// extern double DatadogCrashReportingVersionNumber;
		[Field ("DatadogCrashReportingVersionNumber", "__Internal")]
		double DatadogCrashReportingVersionNumber { get; }

		// extern const unsigned char[] DatadogCrashReportingVersionString;
		[Field ("DatadogCrashReportingVersionString", "__Internal")]
		byte[] DatadogCrashReportingVersionString { get; }
	}
}
