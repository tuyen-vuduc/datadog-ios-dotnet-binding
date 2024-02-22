using System;
using DatadogCore;
using Foundation;

namespace DatadogCore
{
	// [Static]
	// partial interface Constants
	// {
	// 	// extern double DatadogVersionNumber;
	// 	[Field ("DatadogVersionNumber", "__Internal")]
	// 	double DatadogVersionNumber { get; }

	// 	// extern const unsigned char[] DatadogVersionString;
	// 	[Field ("DatadogVersionString", "__Internal")]
	// 	byte[] DatadogVersionString { get; }
	// }

	// @interface __dd_private_AppLaunchHandler : NSObject
	[BaseType (typeof(NSObject))]
	[DisableDefaultCtor]
	interface __dd_private_AppLaunchHandler
	{
		// @property (readonly, class) __dd_private_AppLaunchHandler * _Nonnull shared;
		[Static]
		[Export ("shared")]
		__dd_private_AppLaunchHandler Shared { get; }

		// @property (readonly, atomic) NSDate * _Nonnull launchDate;
		[Export ("launchDate")]
		NSDate LaunchDate { get; }

		// @property (readonly, atomic) NSNumber * _Nullable launchTime;
		[NullAllowed, Export ("launchTime")]
		NSNumber LaunchTime { get; }

		// @property (readonly, atomic) BOOL isActivePrewarm;
		[Export ("isActivePrewarm")]
		bool IsActivePrewarm { get; }

		// -(void)setApplicationDidBecomeActiveCallback:(UIApplicationDidBecomeActiveCallback _Nonnull)callback;
		[Export ("setApplicationDidBecomeActiveCallback:")]
		void SetApplicationDidBecomeActiveCallback (UIApplicationDidBecomeActiveCallback callback);
	}

	// typedef void (^UIApplicationDidBecomeActiveCallback)(NSTimeInterval);
	delegate void UIApplicationDidBecomeActiveCallback (double arg0);

	// @interface __dd_private_ObjcExceptionHandler : NSObject
	[BaseType (typeof(NSObject))]
	interface __dd_private_ObjcExceptionHandler
	{
		// -(BOOL)catchException:(void (^ _Nonnull)(void))tryBlock error:(NSError * _Nullable * _Nullable)error __attribute__((swift_name("rethrowToSwift(tryBlock:)")));
		[Export ("catchException:error:")]
		bool CatchException (Action tryBlock, [NullAllowed] out NSError error);
	}
}
